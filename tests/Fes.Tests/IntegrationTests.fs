module Fes.Tests.IntegrationTests

open System
open Xunit
open FsUnit.Xunit
open Fes
open Fes.Generated
open Fes.Generated.Operations

// ============================================================================
// Integration tests — require a running Elasticsearch instance on localhost:9200
// Run in CI via the ES service container. Filter with: dotnet test --filter "Category=Integration"
// ============================================================================

/// Helper to generate unique index names per test to avoid conflicts
let private testIndex (name: string) =
    let suffix = Guid.NewGuid().ToString("N").[..7]
    $"fes-test-{name}-{suffix}"

/// Transport connected to local Elasticsearch
let private transport () = ES.connect "http://localhost:9200"

/// Delete an index, ignoring errors
let private cleanup (t: Elastic.Transport.ITransport) (idx: string) =
    let delReq = indicesDeleteRequest { index (Types.Indices.IndexName idx) }
    (ES.sendAsync<System.Text.Json.JsonElement, _> t delReq).GetAwaiter().GetResult() |> ignore

/// Helper to parse a string as a JsonElement
let private jsonElement (s: string) =
    System.Text.Json.JsonDocument.Parse(s).RootElement.Clone()

// ============================================================================
// Index creation with simple and complex mappings
// ============================================================================

[<Fact>]
[<Trait("Category", "Integration")>]
let ``Create index with default settings`` () =
    let idx = testIndex "simple"
    let t = transport ()

    try
        let req = indicesCreateRequest { index idx }
        let result : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync t req
        let taskResult = result.GetAwaiter().GetResult()

        match taskResult with
        | Ok json ->
            json.GetProperty("acknowledged").GetBoolean() |> should be True
        | Error e -> failwith $"Failed to create index: {e.Message}"
    finally
        cleanup t idx

[<Fact>]
[<Trait("Category", "Integration")>]
let ``Create index with explicit property mappings`` () =
    let idx = testIndex "mappings"
    let t = transport ()

    try
        // Use the settings/mappings body to define explicit mappings with a text and a float field
        let textProp = { Types.TextProperty.empty with Analyzer = Some "standard" }
        let floatProp = Types.FloatNumberProperty.empty
        let mapping = {
            Types.TypeMapping.empty with
                Properties = Some (Map.ofList [
                    "title", Types.Property.TextProperty textProp
                    "price", Types.Property.FloatNumberProperty floatProp
                ])
        }
        let req = indicesCreateRequest {
            index idx
            mappings mapping
        }
        let result : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync t req
        let taskResult = result.GetAwaiter().GetResult()

        match taskResult with
        | Ok json ->
            json.GetProperty("acknowledged").GetBoolean() |> should be True
        | Error e -> failwith $"Failed to create index with mappings: {e.Message}"
    finally
        cleanup t idx

// ============================================================================
// Index documents with simple and complex structures
// ============================================================================

[<Fact>]
[<Trait("Category", "Integration")>]
let ``Index a simple document and retrieve it`` () =
    let idx = testIndex "index-simple"
    let t = transport ()

    try
        // Create index
        let createReq = indicesCreateRequest { index idx }
        (ES.sendAsync<System.Text.Json.JsonElement, _> t createReq).GetAwaiter().GetResult() |> ignore

        // Index a document
        let doc = {| title = "Test Product"; price = 19.99; inStock = true |}
        let req = indexRequest {
            index idx
            id "doc-1"
            document doc
            refresh Types.Refresh.WaitFor
        }
        let result : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync t req
        let taskResult = result.GetAwaiter().GetResult()

        match taskResult with
        | Ok json ->
            json.GetProperty("result").GetString() |> should equal "created"
            json.GetProperty("_id").GetString() |> should equal "doc-1"
        | Error e -> failwith $"Failed to index document: {e.Message}"

        // Retrieve the document
        let getReq = getRequest { index idx; id "doc-1" }
        let getResult : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync t getReq
        let getTaskResult = getResult.GetAwaiter().GetResult()

        match getTaskResult with
        | Ok json ->
            json.GetProperty("found").GetBoolean() |> should be True
            let source = json.GetProperty("_source")
            source.GetProperty("title").GetString() |> should equal "Test Product"
            source.GetProperty("price").GetDouble() |> should equal 19.99
        | Error e -> failwith $"Failed to get document: {e.Message}"
    finally
        cleanup t idx

[<Fact>]
[<Trait("Category", "Integration")>]
let ``Index a complex nested document`` () =
    let idx = testIndex "index-complex"
    let t = transport ()

    try
        // Create index
        let createReq = indicesCreateRequest { index idx }
        (ES.sendAsync<System.Text.Json.JsonElement, _> t createReq).GetAwaiter().GetResult() |> ignore

        // Index a document with nested objects and arrays
        let doc = {|
            name = "Gaming Laptop"
            price = 1299.99
            specs = {| ram = 16; cpu = "Intel i7"; gpu = "RTX 4060" |}
            tags = [| "electronics"; "gaming"; "laptop" |]
            available = true
        |}
        let req = indexRequest {
            index idx
            id "complex-1"
            document doc
            refresh Types.Refresh.WaitFor
        }
        let result : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync t req
        let taskResult = result.GetAwaiter().GetResult()

        match taskResult with
        | Ok json ->
            json.GetProperty("result").GetString() |> should equal "created"
        | Error e -> failwith $"Failed to index complex document: {e.Message}"

        // Verify retrieval
        let getReq = getRequest { index idx; id "complex-1" }
        let getResult : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync t getReq
        let getTaskResult = getResult.GetAwaiter().GetResult()

        match getTaskResult with
        | Ok json ->
            let source = json.GetProperty("_source")
            source.GetProperty("name").GetString() |> should equal "Gaming Laptop"
            source.GetProperty("specs").GetProperty("ram").GetInt32() |> should equal 16
            source.GetProperty("tags").GetArrayLength() |> should equal 3
        | Error e -> failwith $"Failed to get complex document: {e.Message}"
    finally
        cleanup t idx

// ============================================================================
// Query documents — simple and complex queries
// ============================================================================

[<Fact>]
[<Trait("Category", "Integration")>]
let ``Search with simple query string`` () =
    let idx = testIndex "query-simple"
    let t = transport ()

    try
        // Create index and index documents
        let createReq = indicesCreateRequest { index idx }
        (ES.sendAsync<System.Text.Json.JsonElement, _> t createReq).GetAwaiter().GetResult() |> ignore

        let docs = [
            "1", {| title = "Wireless Mouse"; category = "electronics"; price = 29.99 |}
            "2", {| title = "Keyboard"; category = "electronics"; price = 49.99 |}
            "3", {| title = "Running Shoes"; category = "sports"; price = 89.99 |}
        ]

        for (docId, doc) in docs do
            let req = indexRequest {
                index idx
                id docId
                document doc
                refresh Types.Refresh.WaitFor
            }
            (ES.sendAsync<System.Text.Json.JsonElement, _> t req).GetAwaiter().GetResult() |> ignore

        // Search with query string
        let searchReq = searchRequest {
            index (Types.Indices.IndexName idx)
            q "Wireless"
        }
        let searchResult : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync t searchReq
        let searchTaskResult = searchResult.GetAwaiter().GetResult()

        match searchTaskResult with
        | Ok json ->
            let hits = json.GetProperty("hits").GetProperty("hits")
            hits.GetArrayLength() |> should be (greaterThanOrEqualTo 1)
        | Error e -> failwith $"Search failed: {e.Message}"
    finally
        cleanup t idx

[<Fact>]
[<Trait("Category", "Integration")>]
let ``Search with match query`` () =
    let idx = testIndex "query-match"
    let t = transport ()

    try
        // Create index and index documents
        let createReq = indicesCreateRequest { index idx }
        (ES.sendAsync<System.Text.Json.JsonElement, _> t createReq).GetAwaiter().GetResult() |> ignore

        let docs = [
            "1", {| title = "Wireless Bluetooth Mouse"; category = "electronics" |}
            "2", {| title = "Wired USB Keyboard"; category = "electronics" |}
            "3", {| title = "Running Shoes Nike"; category = "sports" |}
        ]

        for (docId, doc) in docs do
            let req = indexRequest {
                index idx
                id docId
                document doc
                refresh Types.Refresh.WaitFor
            }
            (ES.sendAsync<System.Text.Json.JsonElement, _> t req).GetAwaiter().GetResult() |> ignore

        // Search with match query on specific field
        let matchQuery = Types.QueryContainer.Match ("title", {
            Types.MatchQuery.empty with
                Query = jsonElement "\"Wireless\""
        })
        let searchReq = searchRequest {
            index (Types.Indices.IndexName idx)
            query matchQuery
        }
        let searchResult : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync t searchReq
        let searchTaskResult = searchResult.GetAwaiter().GetResult()

        match searchTaskResult with
        | Ok json ->
            let hits = json.GetProperty("hits").GetProperty("hits")
            hits.GetArrayLength() |> should be (greaterThanOrEqualTo 1)
            let firstHit = hits[0].GetProperty("_source")
            firstHit.GetProperty("title").GetString() |> should haveSubstring "Wireless"
        | Error e -> failwith $"Match query search failed: {e.Message}"
    finally
        cleanup t idx

[<Fact>]
[<Trait("Category", "Integration")>]
let ``Search with bool query combining must and filter`` () =
    let idx = testIndex "query-bool"
    let t = transport ()

    try
        // Create index and index documents
        let createReq = indicesCreateRequest { index idx }
        (ES.sendAsync<System.Text.Json.JsonElement, _> t createReq).GetAwaiter().GetResult() |> ignore

        let docs = [
            "1", {| title = "Wireless Mouse"; category = "electronics"; price = 29.99 |}
            "2", {| title = "Wireless Keyboard"; category = "electronics"; price = 59.99 |}
            "3", {| title = "Wireless Headphones"; category = "audio"; price = 149.99 |}
            "4", {| title = "Running Shoes"; category = "sports"; price = 89.99 |}
        ]

        for (docId, doc) in docs do
            let req = indexRequest {
                index idx
                id docId
                document doc
                refresh Types.Refresh.WaitFor
            }
            (ES.sendAsync<System.Text.Json.JsonElement, _> t req).GetAwaiter().GetResult() |> ignore

        // Bool query: must match "Wireless" AND filter category = "electronics"
        let mustJson = Json.serialize [
            Types.QueryContainer.Match ("title", {
                Types.MatchQuery.empty with
                    Query = jsonElement "\"Wireless\""
            })
        ]
        let filterJson = Json.serialize [
            Types.QueryContainer.Term ("category", {
                Value = Types.FieldValue.String "electronics"
                CaseInsensitive = None
            })
        ]
        let boolQuery = Types.QueryContainer.Bool {
            Must = Some (jsonElement mustJson)
            Filter = Some (jsonElement filterJson)
            Should = None
            MustNot = None
            MinimumShouldMatch = None
        }
        let searchReq = searchRequest {
            index (Types.Indices.IndexName idx)
            query boolQuery
        }
        let searchResult : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync t searchReq
        let searchTaskResult = searchResult.GetAwaiter().GetResult()

        match searchTaskResult with
        | Ok json ->
            let hits = json.GetProperty("hits").GetProperty("hits")
            // Should match "Wireless Mouse" and "Wireless Keyboard" (electronics), not Headphones (audio)
            hits.GetArrayLength() |> should equal 2
        | Error e -> failwith $"Bool query search failed: {e.Message}"
    finally
        cleanup t idx

[<Fact>]
[<Trait("Category", "Integration")>]
let ``Search with size and from for pagination`` () =
    let idx = testIndex "query-pagination"
    let t = transport ()

    try
        // Create index and index documents
        let createReq = indicesCreateRequest { index idx }
        (ES.sendAsync<System.Text.Json.JsonElement, _> t createReq).GetAwaiter().GetResult() |> ignore

        for i in 1..5 do
            let doc = {| title = $"Product {i}"; order = i |}
            let req = indexRequest {
                index idx
                id (string i)
                document doc
                refresh Types.Refresh.WaitFor
            }
            (ES.sendAsync<System.Text.Json.JsonElement, _> t req).GetAwaiter().GetResult() |> ignore

        // Page 1: size=2, from=0
        let searchReq = searchRequest {
            index (Types.Indices.IndexName idx)
            size 2
            from 0
        }
        let searchResult : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync t searchReq
        let searchTaskResult = searchResult.GetAwaiter().GetResult()

        match searchTaskResult with
        | Ok json ->
            let hits = json.GetProperty("hits").GetProperty("hits")
            hits.GetArrayLength() |> should equal 2
            let total = json.GetProperty("hits").GetProperty("total").GetProperty("value").GetInt32()
            total |> should equal 5
        | Error e -> failwith $"Pagination search failed: {e.Message}"
    finally
        cleanup t idx

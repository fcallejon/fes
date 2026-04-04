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
// Index creation — simple & complex
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
        let req = indicesCreateRequest {
            index idx
            mappings (Mapping.mapping [
                Mapping.text "title" { Types.TextProperty.empty with Analyzer = Some "standard" }
                Mapping.keyword "category" Types.KeywordProperty.empty
                Mapping.float' "price" Types.FloatNumberProperty.empty
                Mapping.boolean "in_stock" Types.BooleanProperty.empty
                Mapping.integer "quantity" Types.IntegerNumberProperty.empty
                Mapping.date "created_at" Types.DateProperty.empty
            ])
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
// Index documents — simple & complex nested
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
// Search — query string, match query, bool query, pagination
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
        let boolQuery = Types.QueryContainer.Bool {
            Types.BoolQuery.empty with
                Must = Some [
                    Types.QueryContainer.Match ("title", {
                        Types.MatchQuery.empty with
                            Query = jsonElement "\"Wireless\""
                    })
                ]
                Filter = Some [
                    Types.QueryContainer.Term ("category", {
                        Types.TermQuery.empty with
                            Value = Types.FieldValue.String "electronics"
                    })
                ]
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

// ============================================================================
// Update documents
// ============================================================================

[<Fact>]
[<Trait("Category", "Integration")>]
let ``Update a document with partial data`` () =
    let idx = testIndex "update-doc"
    let t = transport ()

    try
        // Create index and index a document
        let createReq = indicesCreateRequest { index idx }
        (ES.sendAsync<System.Text.Json.JsonElement, _> t createReq).GetAwaiter().GetResult() |> ignore

        let doc = {| title = "Original Title"; price = 10.00; category = "books" |}
        let idxReq = indexRequest {
            index idx
            id "update-1"
            document doc
            refresh Types.Refresh.WaitFor
        }
        (ES.sendAsync<System.Text.Json.JsonElement, _> t idxReq).GetAwaiter().GetResult() |> ignore

        // Update only the price and title via partial document
        let partialDoc = {| title = "Updated Title"; price = 25.00 |}
        let updReq = updateRequest {
            index idx
            id "update-1"
            doc partialDoc
            refresh Types.Refresh.WaitFor
        }
        let updResult : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync t updReq
        let updTaskResult = updResult.GetAwaiter().GetResult()

        match updTaskResult with
        | Ok json ->
            json.GetProperty("result").GetString() |> should equal "updated"
        | Error e -> failwith $"Failed to update document: {e.Message}"

        // Verify the update
        let getReq = getRequest { index idx; id "update-1" }
        let getResult : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync t getReq
        let getTaskResult = getResult.GetAwaiter().GetResult()

        match getTaskResult with
        | Ok json ->
            let source = json.GetProperty("_source")
            source.GetProperty("title").GetString() |> should equal "Updated Title"
            source.GetProperty("price").GetDouble() |> should equal 25.00
            // category should still be there (not overwritten)
            source.GetProperty("category").GetString() |> should equal "books"
        | Error e -> failwith $"Failed to get updated document: {e.Message}"
    finally
        cleanup t idx

[<Fact>]
[<Trait("Category", "Integration")>]
let ``Upsert a document that does not exist`` () =
    let idx = testIndex "upsert-doc"
    let t = transport ()

    try
        // Create index (no document yet)
        let createReq = indicesCreateRequest { index idx }
        (ES.sendAsync<System.Text.Json.JsonElement, _> t createReq).GetAwaiter().GetResult() |> ignore

        // Upsert — doc does not exist, so the upsert value should be used
        let updReq = updateRequest {
            index idx
            id "upsert-1"
            doc {| title = "Partial only" |}
            upsert {| title = "Upserted Product"; price = 42.00 |}
            refresh Types.Refresh.WaitFor
        }
        let updResult : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync t updReq
        let updTaskResult = updResult.GetAwaiter().GetResult()

        match updTaskResult with
        | Ok json ->
            json.GetProperty("result").GetString() |> should equal "created"
        | Error e -> failwith $"Upsert failed: {e.Message}"

        // Verify the document was created with upsert content
        let getReq = getRequest { index idx; id "upsert-1" }
        let getResult : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync t getReq
        let getTaskResult = getResult.GetAwaiter().GetResult()

        match getTaskResult with
        | Ok json ->
            let source = json.GetProperty("_source")
            source.GetProperty("title").GetString() |> should equal "Upserted Product"
            source.GetProperty("price").GetDouble() |> should equal 42.00
        | Error e -> failwith $"Failed to get upserted document: {e.Message}"
    finally
        cleanup t idx

// ============================================================================
// Delete documents
// ============================================================================

[<Fact>]
[<Trait("Category", "Integration")>]
let ``Delete a document`` () =
    let idx = testIndex "delete-doc"
    let t = transport ()

    try
        // Create index and index a document
        let createReq = indicesCreateRequest { index idx }
        (ES.sendAsync<System.Text.Json.JsonElement, _> t createReq).GetAwaiter().GetResult() |> ignore

        let doc = {| title = "To Be Deleted"; price = 5.00 |}
        let idxReq = indexRequest {
            index idx
            id "del-1"
            document doc
            refresh Types.Refresh.WaitFor
        }
        (ES.sendAsync<System.Text.Json.JsonElement, _> t idxReq).GetAwaiter().GetResult() |> ignore

        // Delete the document
        let delReq = deleteRequest {
            index idx
            id "del-1"
            refresh Types.Refresh.WaitFor
        }
        let delResult : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync t delReq
        let delTaskResult = delResult.GetAwaiter().GetResult()

        match delTaskResult with
        | Ok json ->
            json.GetProperty("result").GetString() |> should equal "deleted"
        | Error e -> failwith $"Failed to delete document: {e.Message}"

        // Verify the document is gone (GET should return found=false)
        let getReq = getRequest { index idx; id "del-1" }
        let getResult : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync t getReq
        let getTaskResult = getResult.GetAwaiter().GetResult()

        // Elasticsearch returns 404 for missing docs — our transport returns Error
        match getTaskResult with
        | Error _ -> () // Expected: document not found
        | Ok json ->
            // Some ES versions return found=false with 200
            json.GetProperty("found").GetBoolean() |> should be False
    finally
        cleanup t idx

// ============================================================================
// Delete index
// ============================================================================

[<Fact>]
[<Trait("Category", "Integration")>]
let ``Delete an index`` () =
    let idx = testIndex "delete-idx"
    let t = transport ()

    // Create the index first
    let createReq = indicesCreateRequest { index idx }
    let createResult : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync t createReq
    let createTaskResult = createResult.GetAwaiter().GetResult()

    match createTaskResult with
    | Ok json ->
        json.GetProperty("acknowledged").GetBoolean() |> should be True
    | Error e -> failwith $"Failed to create index for deletion test: {e.Message}"

    // Delete the index
    let delReq = indicesDeleteRequest { index (Types.Indices.IndexName idx) }
    let delResult : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync t delReq
    let delTaskResult = delResult.GetAwaiter().GetResult()

    match delTaskResult with
    | Ok json ->
        json.GetProperty("acknowledged").GetBoolean() |> should be True
    | Error e -> failwith $"Failed to delete index: {e.Message}"

    // Verify the index no longer exists (search on it should fail)
    let searchReq = searchRequest { index (Types.Indices.IndexName idx) }
    let searchResult : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync t searchReq
    let searchTaskResult = searchResult.GetAwaiter().GetResult()

    match searchTaskResult with
    | Error _ -> () // Expected: index not found
    | Ok _ -> failwith "Expected error when searching deleted index"

// ============================================================================
// Full CRUD lifecycle in a single test
// ============================================================================

[<Fact>]
[<Trait("Category", "Integration")>]
let ``Full CRUD lifecycle — create index, index doc, search, update, delete doc, delete index`` () =
    let idx = testIndex "crud"
    let t = transport ()

    try
        // 1. Create index with mappings (uses Mapping convenience module)
        let req = indicesCreateRequest {
            index idx
            mappings (Mapping.mapping [
                Mapping.text "name" Types.TextProperty.empty
                Mapping.keyword "status" Types.KeywordProperty.empty
                Mapping.float' "price" Types.FloatNumberProperty.empty
            ])
        }
        let createResult = (ES.sendAsync<System.Text.Json.JsonElement, _> t req).GetAwaiter().GetResult()
        match createResult with
        | Ok json -> json.GetProperty("acknowledged").GetBoolean() |> should be True
        | Error e -> failwith $"Create index failed: {e.Message}"

        // 2. Index a document
        let doc = {| name = "Widget"; status = "active"; price = 9.99 |}
        let idxReq = indexRequest {
            index idx
            id "crud-1"
            document doc
            refresh Types.Refresh.WaitFor
        }
        let idxResult = (ES.sendAsync<System.Text.Json.JsonElement, _> t idxReq).GetAwaiter().GetResult()
        match idxResult with
        | Ok json -> json.GetProperty("result").GetString() |> should equal "created"
        | Error e -> failwith $"Index doc failed: {e.Message}"

        // 3. Search for it
        let searchReq = searchRequest {
            index (Types.Indices.IndexName idx)
            q "Widget"
        }
        let searchResult = (ES.sendAsync<System.Text.Json.JsonElement, _> t searchReq).GetAwaiter().GetResult()
        match searchResult with
        | Ok json ->
            json.GetProperty("hits").GetProperty("hits").GetArrayLength() |> should equal 1
        | Error e -> failwith $"Search failed: {e.Message}"

        // 4. Update the document
        let updReq = updateRequest {
            index idx
            id "crud-1"
            doc {| price = 14.99; status = "on_sale" |}
            refresh Types.Refresh.WaitFor
        }
        let updResult = (ES.sendAsync<System.Text.Json.JsonElement, _> t updReq).GetAwaiter().GetResult()
        match updResult with
        | Ok json -> json.GetProperty("result").GetString() |> should equal "updated"
        | Error e -> failwith $"Update failed: {e.Message}"

        // Verify update
        let getReq = getRequest { index idx; id "crud-1" }
        let getResult = (ES.sendAsync<System.Text.Json.JsonElement, _> t getReq).GetAwaiter().GetResult()
        match getResult with
        | Ok json ->
            let source = json.GetProperty("_source")
            source.GetProperty("name").GetString() |> should equal "Widget"
            source.GetProperty("price").GetDouble() |> should equal 14.99
            source.GetProperty("status").GetString() |> should equal "on_sale"
        | Error e -> failwith $"Get after update failed: {e.Message}"

        // 5. Delete the document
        let delReq = deleteRequest {
            index idx
            id "crud-1"
            refresh Types.Refresh.WaitFor
        }
        let delResult = (ES.sendAsync<System.Text.Json.JsonElement, _> t delReq).GetAwaiter().GetResult()
        match delResult with
        | Ok json -> json.GetProperty("result").GetString() |> should equal "deleted"
        | Error e -> failwith $"Delete doc failed: {e.Message}"

        // Verify document is gone
        let getResult2 = (ES.sendAsync<System.Text.Json.JsonElement, _> t getReq).GetAwaiter().GetResult()
        match getResult2 with
        | Error _ -> () // Expected
        | Ok json -> json.GetProperty("found").GetBoolean() |> should be False

        // 6. Delete the index
        let delIdxReq = indicesDeleteRequest { index (Types.Indices.IndexName idx) }
        let delIdxResult = (ES.sendAsync<System.Text.Json.JsonElement, _> t delIdxReq).GetAwaiter().GetResult()
        match delIdxResult with
        | Ok json -> json.GetProperty("acknowledged").GetBoolean() |> should be True
        | Error e -> failwith $"Delete index failed: {e.Message}"
    with
    | _ ->
        cleanup t idx
        reraise ()


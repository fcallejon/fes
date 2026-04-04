module Fes.Tests.PipelineTests

open Xunit
open FsUnit.Xunit
open Fes
open Fes.Generated
open Fes.Generated.Operations

// ============================================================================
// Full pipeline tests using in-memory transport
// ============================================================================

[<Fact>]
let ``Search request through in-memory transport returns Ok`` () =
    let responseJson = """{"took":1,"timed_out":false,"_shards":{"total":1,"successful":1,"skipped":0,"failed":0},"hits":{"total":{"value":0,"relation":"eq"},"max_score":null,"hits":[]}}"""
    let transport = TestTransport.withOkResponse responseJson

    let req = searchRequest {
        index (Types.Indices.IndexName "products")
        q "wireless"
        size 10
    }

    let result : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync transport req
    let taskResult = result.GetAwaiter().GetResult()

    match taskResult with
    | Ok _ -> ()
    | Error e -> failwith $"Expected Ok but got Error: {e.Message}"

[<Fact>]
let ``Error response returns Error result`` () =
    let errorJson = """{"error":{"root_cause":[{"type":"index_not_found_exception","reason":"no such index [missing]"}],"type":"index_not_found_exception","reason":"no such index [missing]"},"status":404}"""
    let transport = TestTransport.withResponse errorJson 404

    let req = searchRequest {
        index (Types.Indices.IndexName "missing")
    }

    let result : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync transport req
    let taskResult = result.GetAwaiter().GetResult()

    match taskResult with
    | Error _ -> ()
    | Ok _ -> failwith "Expected Error but got Ok"

[<Fact>]
let ``Get request through in-memory transport`` () =
    let responseJson = """{"_index":"products","_id":"1","_version":1,"_seq_no":0,"_primary_term":1,"found":true,"_source":{"name":"test"}}"""
    let transport = TestTransport.withOkResponse responseJson

    let req = getRequest {
        index "products"
        id "1"
    }

    let result : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync transport req
    let taskResult = result.GetAwaiter().GetResult()

    match taskResult with
    | Ok json ->
        json.GetProperty("found").GetBoolean() |> should be True
    | Error e -> failwith $"Expected Ok but got Error: {e.Message}"

[<Fact>]
let ``Indices create through in-memory transport`` () =
    let responseJson = """{"acknowledged":true,"shards_acknowledged":true,"index":"test-index"}"""
    let transport = TestTransport.withOkResponse responseJson

    let req = indicesCreateRequest {
        index "test-index"
    }

    let result : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync transport req
    let taskResult = result.GetAwaiter().GetResult()

    match taskResult with
    | Ok json ->
        json.GetProperty("acknowledged").GetBoolean() |> should be True
    | Error e -> failwith $"Expected Ok but got Error: {e.Message}"

[<Fact>]
let ``Query DU serialises correctly in request body`` () =
    let boolQuery = Types.QueryContainer.Bool Types.BoolQuery.empty
    let json = Json.serialize boolQuery
    json |> should haveSubstring "\"bool\""

[<Fact>]
let ``Aggregation DU serialises correctly`` () =
    let termsAgg = Types.AggregationContainer.Terms {
        Field = Some "category"; Size = Some 10.0
        CollectMode = None; Exclude = None; ExecutionHint = None
        Include = None; MinDocCount = None; Missing = None
        MissingOrder = None; MissingBucket = None; ValueType = None
        Order = None; Script = None; ShardMinDocCount = None
        ShardSize = None; ShowTermDocCountError = None; Format = None
    }
    let json = Json.serialize termsAgg
    json |> should haveSubstring "\"terms\""
    json |> should haveSubstring "\"category\""
    json |> should haveSubstring "10"

// ============================================================================
// Index (document indexing) pipeline tests
// ============================================================================

[<Fact>]
let ``Index request through in-memory transport returns Ok`` () =
    let responseJson = """{"_index":"products","_id":"1","_version":1,"result":"created","_shards":{"total":2,"successful":1,"failed":0},"_seq_no":0,"_primary_term":1}"""
    let transport = TestTransport.withOkResponse responseJson

    let req = indexRequest {
        index "products"
        id "1"
        document {| name = "laptop"; price = 999.99 |}
    }

    let result : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync transport req
    let taskResult = result.GetAwaiter().GetResult()

    match taskResult with
    | Ok json ->
        json.GetProperty("result").GetString() |> should equal "created"
    | Error e -> failwith $"Expected Ok but got Error: {e.Message}"

[<Fact>]
let ``Index request serialises document as body`` () =
    let responseJson = """{"_index":"products","_id":"1","_version":1,"result":"created","_shards":{"total":2,"successful":1,"failed":0},"_seq_no":0,"_primary_term":1}"""
    let transport = TestTransport.withOkResponse responseJson

    let doc = {| name = "wireless mouse"; category = "electronics"; price = 29.99 |}
    let req = indexRequest {
        index "products"
        id "1"
        document doc
    }

    let (_, postData) = IndexRequest.ToEndpoint(req)
    postData.IsSome |> should be True

[<Fact>]
let ``Index request with complex document`` () =
    let responseJson = """{"_index":"products","_id":"1","_version":1,"result":"created","_shards":{"total":2,"successful":1,"failed":0},"_seq_no":0,"_primary_term":1}"""
    let transport = TestTransport.withOkResponse responseJson

    let doc = {| name = "laptop"; specs = {| ram = 16; cpu = "i7" |}; tags = [| "electronics"; "sale" |] |}
    let req = indexRequest {
        index "products"
        id "complex-1"
        document doc
    }

    let result : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync transport req
    let taskResult = result.GetAwaiter().GetResult()

    match taskResult with
    | Ok _ -> ()
    | Error e -> failwith $"Expected Ok but got Error: {e.Message}"

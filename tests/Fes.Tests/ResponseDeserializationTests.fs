module Fes.Tests.ResponseDeserializationTests

open Xunit
open FsUnit.Xunit
open Fes
open System.Text.Json

// ============================================================================
// Search response
// ============================================================================

[<Fact>]
let ``Search response JSON deserialises took and timed_out`` () =
    let json = """{"took":5,"timed_out":false,"_shards":{"total":1,"successful":1,"skipped":0,"failed":0},"hits":{"total":{"value":2,"relation":"eq"},"max_score":1.0,"hits":[]}}"""
    let el = JsonDocument.Parse(json).RootElement
    el.GetProperty("took").GetInt32() |> should equal 5
    el.GetProperty("timed_out").GetBoolean() |> should equal false

[<Fact>]
let ``Search response JSON has hits array`` () =
    let json = """{"took":1,"timed_out":false,"_shards":{"total":1,"successful":1,"skipped":0,"failed":0},"hits":{"total":{"value":1,"relation":"eq"},"max_score":1.5,"hits":[{"_index":"products","_id":"1","_score":1.5,"_source":{"name":"test"}}]}}"""
    let el = JsonDocument.Parse(json).RootElement
    let hits = el.GetProperty("hits").GetProperty("hits")
    hits.GetArrayLength() |> should equal 1
    hits[0].GetProperty("_id").GetString() |> should equal "1"

// ============================================================================
// Create index response
// ============================================================================

[<Fact>]
let ``Index create response JSON has acknowledged`` () =
    let json = """{"acknowledged":true,"shards_acknowledged":true,"index":"my-index"}"""
    let el = JsonDocument.Parse(json).RootElement
    el.GetProperty("acknowledged").GetBoolean() |> should be True
    el.GetProperty("index").GetString() |> should equal "my-index"

// ============================================================================
// Get response
// ============================================================================

[<Fact>]
let ``Get response JSON has found and source`` () =
    let json = """{"_index":"products","_id":"1","_version":1,"_seq_no":0,"_primary_term":1,"found":true,"_source":{"name":"Laptop"}}"""
    let el = JsonDocument.Parse(json).RootElement
    el.GetProperty("found").GetBoolean() |> should be True
    el.GetProperty("_index").GetString() |> should equal "products"
    el.GetProperty("_source").GetProperty("name").GetString() |> should equal "Laptop"

// ============================================================================
// Cluster health response (typed)
// ============================================================================

[<Fact>]
let ``Cluster health response JSON has status and nodes`` () =
    let json = """{"cluster_name":"test-cluster","status":"green","timed_out":false,"number_of_nodes":3,"number_of_data_nodes":2,"active_primary_shards":5,"active_shards":10,"relocating_shards":0,"initializing_shards":0,"unassigned_shards":0,"delayed_unassigned_shards":0,"number_of_pending_tasks":0,"number_of_in_flight_fetch":0,"task_max_waiting_in_queue_millis":0,"active_shards_percent_as_number":100.0}"""
    let el = JsonDocument.Parse(json).RootElement
    el.GetProperty("cluster_name").GetString() |> should equal "test-cluster"
    el.GetProperty("status").GetString() |> should equal "green"
    el.GetProperty("number_of_nodes").GetInt32() |> should equal 3

// ============================================================================
// Error response
// ============================================================================

[<Fact>]
let ``Elasticsearch error response deserialises`` () =
    let json = """{"error":{"root_cause":[{"type":"index_not_found_exception","reason":"no such index [missing]"}],"type":"index_not_found_exception","reason":"no such index [missing]"},"status":404}"""
    let result = Fes.ElasticsearchException.ofString json
    match result with
    | Ok ex ->
        ex.Status |> should equal System.Net.HttpStatusCode.NotFound
        ex.Reason |> should equal "no such index [missing]"
    | Error e -> failwith (sprintf "Failed to parse: %s" e.Message)

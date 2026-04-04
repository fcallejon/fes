module Fes.Tests.RequestBodyTests

open Xunit
open FsUnit.Xunit
open Fes
open Fes.Generated
open Fes.Generated.Types
open Fes.Generated.Builders

// ============================================================================
// Query DSL serialisation
// ============================================================================

[<Fact>]
let ``bool query serialises with bool key`` () =
    let q = QueryContainer.Bool {
        Must = None; Should = None; MustNot = None; Filter = None
        MinimumShouldMatch = None
    }
    let json = Json.serialize q
    Assert.Contains("bool", json)

[<Fact>]
let ``term query serialises with field name`` () =
    let q = QueryContainer.Term ("status", Types.TermQuery.empty)
    let json = Json.serialize q
    Assert.Contains("term", json)
    Assert.Contains("status", json)

[<Fact>]
let ``match query serialises with field and query value`` () =
    let queryValue = System.Text.Json.JsonDocument.Parse("\"laptop\"").RootElement
    let mq = matchQuery { query queryValue }
    let q = Query.match' "name" mq
    let json = Json.serialize q
    Assert.Contains("match", json)
    Assert.Contains("name", json)
    Assert.Contains("laptop", json)

// ============================================================================
// Aggregation serialisation
// ============================================================================

[<Fact>]
let ``terms aggregation serialises with field and size`` () =
    let agg = Aggregation.terms (termsAggregation { field "category"; size 10 })
    let json = Json.serialize agg
    Assert.Contains("terms", json)
    Assert.Contains("category", json)
    Assert.Contains("10", json)

// ============================================================================
// Enum serialisation
// ============================================================================

[<Fact>]
let ``Refresh enum serialises and deserialises`` () =
    let trueJson = Json.serialize Refresh.True
    let expectedTrue = "\"true\""
    Assert.Equal(expectedTrue, trueJson)

    let wfJson = Json.serialize Refresh.WaitFor
    let expectedWf = "\"wait_for\""
    Assert.Equal(expectedWf, wfJson)

    let input = "\"wait_for\""
    let value = Json.deserialize<Refresh> input
    value |> should equal Refresh.WaitFor

[<Fact>]
let ``HealthStatus enum round-trips`` () =
    let json = Json.serialize HealthStatus.Green
    let expected = "\"green\""
    Assert.Equal(expected, json)
    let rt = Json.deserialize<HealthStatus> json
    rt |> should equal HealthStatus.Green

// ============================================================================
// Container variant round-trips
// ============================================================================

[<Fact>]
let ``QueryContainer.Bool round-trips through JSON`` () =
    let original = QueryContainer.Bool {
        Must = None; Should = None; MustNot = None; Filter = None
        MinimumShouldMatch = None
    }
    let json = Json.serialize original
    let roundTripped = Json.deserialize<QueryContainer> json
    match roundTripped with
    | QueryContainer.Bool _ -> ()
    | _ -> failwith "Expected Bool case after round-trip"

[<Fact>]
let ``AggregationContainer.Terms round-trips through JSON`` () =
    let original = Aggregation.terms (termsAggregation { field "category"; size 10 })
    let json = Json.serialize original
    let roundTripped = Json.deserialize<AggregationContainer> json
    match roundTripped with
    | AggregationContainer.Terms t ->
        t.Field |> should equal (Some "category")
    | _ -> failwith "Expected Terms case after round-trip"

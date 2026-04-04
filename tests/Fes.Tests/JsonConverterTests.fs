module Fes.Tests.JsonConverterTests

open Xunit
open FsUnit.Xunit
open Fes
open Fes.Generated
open Fes.Generated.Types

// ============================================================================
// Enum serialisation round-trips
// ============================================================================

[<Fact>]
let ``Refresh enum serialises to string`` () =
    let json = Json.serialize Types.Refresh.True
    json |> should equal "\"true\""

[<Fact>]
let ``Refresh enum deserialises from string`` () =
    let value = Json.deserialize<Types.Refresh> "\"wait_for\""
    value |> should equal Types.Refresh.WaitFor

[<Fact>]
let ``HealthStatus enum round-trips`` () =
    let original = Types.HealthStatus.Green
    let json = Json.serialize original
    let roundTripped = Json.deserialize<Types.HealthStatus> json
    roundTripped |> should equal original

[<Fact>]
let ``SearchType enum round-trips`` () =
    let original = Types.SearchType.DfsQueryThenFetch
    let json = Json.serialize original
    let roundTripped = Json.deserialize<Types.SearchType> json
    roundTripped |> should equal original

// ============================================================================
// Container variant (DU) serialisation
// ============================================================================

[<Fact>]
let ``QueryContainer.Bool serialises with bool key`` () =
    let q = Types.QueryContainer.Bool Types.BoolQuery.empty
    let json = Json.serialize q
    json |> should haveSubstring "\"bool\""

[<Fact>]
let ``QueryContainer.Term serialises with field-keyed structure`` () =
    let q = Types.QueryContainer.Term ("status", Types.TermQuery.empty)
    let json = Json.serialize q
    json |> should haveSubstring "\"term\""
    json |> should haveSubstring "\"status\""

[<Fact>]
let ``AggregationContainer.Terms serialises with terms key`` () =
    let agg = Types.AggregationContainer.Terms {
        Field = Some "category"; Size = Some 10
        CollectMode = None; Exclude = None; ExecutionHint = None
        Include = None; MinDocCount = None; Missing = None
        MissingOrder = None; MissingBucket = None; ValueType = None
        Order = None; Script = None; ShardMinDocCount = None
        ShardSize = None; ShowTermDocCountError = None; Format = None
    }
    let json = Json.serialize agg
    json |> should haveSubstring "\"terms\""
    json |> should haveSubstring "\"category\""

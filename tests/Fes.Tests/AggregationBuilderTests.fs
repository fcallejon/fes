module Fes.Tests.AggregationBuilderTests

open Xunit
open FsUnit.Xunit
open Fes.Generated.Types
open Fes.Generated.Builders

// ============================================================================
// Aggregation DU construction via builders
// ============================================================================

[<Fact>]
let ``Aggregation.terms creates Terms case`` () =
    let termsAgg = termsAggregation {
        field "category"
        size 10
    }
    let agg = Aggregation.terms termsAgg
    match agg with
    | AggregationContainer.Terms t ->
        t.Field |> should equal (Some "category")
        t.Size |> should equal (Some 10.0)
    | _ -> failwith "Expected Terms case"

[<Fact>]
let ``Aggregation.dateHistogram creates DateHistogram case`` () =
    let dhAgg = dateHistogramAggregation {
        field "timestamp"
    }
    let agg = Aggregation.dateHistogram dhAgg
    match agg with
    | AggregationContainer.DateHistogram dh ->
        dh.Field |> should equal (Some "timestamp")
    | _ -> failwith "Expected DateHistogram case"

// ============================================================================
// Aggregation CE builders
// ============================================================================

[<Fact>]
let ``termsAggregation CE sets field`` () =
    let ta = termsAggregation { field "x" }
    ta.Field |> should equal (Some "x")
    ta.MinDocCount |> should equal None

[<Fact>]
let ``termsAggregation CE sets size`` () =
    let ta = termsAggregation {
        field "category"
        size 25
    }
    ta.Size |> should equal (Some 25.0)

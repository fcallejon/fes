module Fes.Tests.QueryBuilderTests

open Xunit
open FsUnit.Xunit
open Fes.Generated
open Fes.Generated.Builders

// ============================================================================
// Query DU construction — verify the right case is created
// ============================================================================

[<Fact>]
let ``Query.bool wraps BoolQuery in QueryContainer.Bool`` () =
    let bq = Types.BoolQuery.empty
    let q = Query.bool bq
    // Verify it's the Bool case by serialising — should contain "bool" key
    let json = Fes.Json.serialize q
    json |> should haveSubstring "\"bool\""

[<Fact>]
let ``Query.match' creates Match case with field`` () =
    let queryValue = System.Text.Json.JsonDocument.Parse("\"laptop\"").RootElement
    let mq = matchQuery { query queryValue }
    let q = Query.match' "title" mq
    let json = Fes.Json.serialize q
    json |> should haveSubstring "\"match\""
    json |> should haveSubstring "\"title\""

[<Fact>]
let ``Query.term wraps TermQuery with field name`` () =
    let tq = Types.TermQuery.empty
    let q = Query.term "status" tq
    let json = Fes.Json.serialize q
    json |> should haveSubstring "\"term\""
    json |> should haveSubstring "\"status\""

// ============================================================================
// CE builders for query types
// ============================================================================

[<Fact>]
let ``matchQuery CE sets query field`` () =
    let queryValue = System.Text.Json.JsonDocument.Parse("\"test\"").RootElement
    let mq : Types.MatchQuery = matchQuery {
        query queryValue
    }
    mq.Analyzer |> should equal None

[<Fact>]
let ``matchQuery CE sets optional fields`` () =
    let mq : Types.MatchQuery = matchQuery {
        query (System.Text.Json.JsonDocument.Parse("\"test\"").RootElement)
        analyzer "english"
    }
    mq.Analyzer |> should equal (Some "english")

namespace Fes.Tests

open Fes.DSL
open Fes.DSL.Models.Types
open Fes
open Xunit
open System.Text.Json

module QueryBuilderTests =

    [<Fact>]
    let ``matchAll produces match_all clause`` () =
        let q = QueryBuilders.matchAll ()
        Assert.True(Option.isSome q.MatchAll)
        Assert.True(Option.isNone q.Bool)
        Assert.True(Option.isNone q.Term)
        Assert.True(Option.isNone q.Match)

    [<Fact>]
    let ``matchQuery produces match clause for field`` () =
        let q = QueryBuilders.matchQuery "title" "hello world"
        Assert.True(Option.isSome q.Match)
        let map = q.Match.Value
        Assert.True(Map.containsKey "title" map)
        let json = Json.serialize q
        Assert.Contains("\"match\"", json)
        Assert.Contains("\"title\"", json)
        Assert.Contains("hello world", json)

    [<Fact>]
    let ``term produces term clause for field`` () =
        let q = QueryBuilders.term "status" "active"
        Assert.True(Option.isSome q.Term)
        let map = q.Term.Value
        Assert.True(Map.containsKey "status" map)
        let json = Json.serialize q
        Assert.Contains("\"term\"", json)
        Assert.Contains("\"status\"", json)
        Assert.Contains("active", json)

    [<Fact>]
    let ``exists produces exists clause`` () =
        let q = QueryBuilders.exists "email"
        Assert.True(Option.isSome q.Exists)
        Assert.Equal("email", q.Exists.Value.Field)
        let json = Json.serialize q
        Assert.Contains("\"exists\"", json)
        Assert.Contains("\"email\"", json)

    [<Fact>]
    let ``ids produces ids clause`` () =
        let q = QueryBuilders.ids ["1"; "2"; "3"]
        Assert.True(Option.isSome q.Ids)
        Assert.True(Option.isSome q.Ids.Value.Values)
        let json = Json.serialize q
        Assert.Contains("\"ids\"", json)

    [<Fact>]
    let ``queryString produces query_string clause`` () =
        let q = QueryBuilders.queryString "name:laptop AND price:[100 TO 500]"
        Assert.True(Option.isSome q.QueryString)
        Assert.Equal("name:laptop AND price:[100 TO 500]", q.QueryString.Value.Query)
        let json = Json.serialize q
        Assert.Contains("\"query_string\"", json)

    [<Fact>]
    let ``bool with must produces bool clause`` () =
        let must = [ QueryBuilders.term "status" "active" ]
        let q = QueryBuilders.bool (Option.Some must) Option.None Option.None Option.None
        Assert.True(Option.isSome q.Bool)
        Assert.True(Option.isSome q.Bool.Value.Must)
        Assert.True(Option.isNone q.Bool.Value.Should)
        let json = Json.serialize q
        Assert.Contains("\"bool\"", json)
        Assert.Contains("\"must\"", json)

    [<Fact>]
    let ``bool with should produces bool clause`` () =
        let should = [ QueryBuilders.matchQuery "title" "laptop"; QueryBuilders.matchQuery "description" "laptop" ]
        let q = QueryBuilders.bool Option.None (Option.Some should) Option.None Option.None
        Assert.True(Option.isSome q.Bool)
        Assert.True(Option.isSome q.Bool.Value.Should)
        Assert.True(Option.isNone q.Bool.Value.Must)
        let json = Json.serialize q
        Assert.Contains("\"bool\"", json)
        Assert.Contains("\"should\"", json)

    [<Fact>]
    let ``bool with filter produces bool clause`` () =
        let filter = [ QueryBuilders.term "in_stock" true ]
        let q = QueryBuilders.bool Option.None Option.None Option.None (Option.Some filter)
        Assert.True(Option.isSome q.Bool)
        Assert.True(Option.isSome q.Bool.Value.Filter)
        let json = Json.serialize q
        Assert.Contains("\"bool\"", json)
        Assert.Contains("\"filter\"", json)

    [<Fact>]
    let ``bool with all clauses produces complete bool query`` () =
        let must    = [ QueryBuilders.matchQuery "title" "laptop" ]
        let should  = [ QueryBuilders.term "category" "electronics" ]
        let mustNot = [ QueryBuilders.term "discontinued" true ]
        let filter  = [ QueryBuilders.exists "price" ]
        let q = QueryBuilders.bool (Option.Some must) (Option.Some should) (Option.Some mustNot) (Option.Some filter)
        let boolQ = q.Bool.Value
        Assert.True(Option.isSome boolQ.Must)
        Assert.True(Option.isSome boolQ.Should)
        Assert.True(Option.isSome boolQ.MustNot)
        Assert.True(Option.isSome boolQ.Filter)
        let json = Json.serialize q
        Assert.Contains("\"must\"", json)
        Assert.Contains("\"should\"", json)
        Assert.Contains("\"must_not\"", json)
        Assert.Contains("\"filter\"", json)

    [<Fact>]
    let ``all builders produce containers with only one clause set`` () =
        // Verify that no other fields leak in
        let matchAllQ = QueryBuilders.matchAll ()
        Assert.True(Option.isNone matchAllQ.Bool)
        Assert.True(Option.isNone matchAllQ.Term)
        Assert.True(Option.isNone matchAllQ.Match)
        Assert.True(Option.isNone matchAllQ.Exists)
        Assert.True(Option.isNone matchAllQ.QueryString)

        let termQ = QueryBuilders.term "f" "v"
        Assert.True(Option.isNone termQ.Bool)
        Assert.True(Option.isNone termQ.MatchAll)
        Assert.True(Option.isNone termQ.Match)

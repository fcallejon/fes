namespace Fes.Tests

open Fes
open Fes.DSL.Models.Types
open Xunit

/// Tests for utility functions in the Fes library
module HttpUtilityTests =

    [<Fact>]
    let ``toQueryValue converts true bool to lowercase string`` () =
        let result = Http.toQueryValue true
        Assert.Equal("true", result)

    [<Fact>]
    let ``toQueryValue converts false bool to lowercase string`` () =
        let result = Http.toQueryValue false
        Assert.Equal("false", result)

    [<Fact>]
    let ``toQueryValue converts integer to string`` () =
        let result = Http.toQueryValue 42
        Assert.Equal("42", result)

    [<Fact>]
    let ``toQueryValue converts float to string`` () =
        let result = Http.toQueryValue 10.0
        Assert.Equal("10", result)

    [<Fact>]
    let ``toQueryValue converts string to string`` () =
        let result = Http.toQueryValue "my_index"
        Assert.Equal("my_index", result)

    [<Fact>]
    let ``toQueryValue converts HealthStatus enum via ToString`` () =
        let result = Http.toQueryValue HealthStatus.Yellow
        Assert.Equal("yellow", result)

    [<Fact>]
    let ``toQueryValue converts SearchType enum via ToString`` () =
        let result = Http.toQueryValue SearchType.DfsQueryThenFetch
        Assert.Equal("dfs_query_then_fetch", result)


module ResultModuleTests =

    [<Fact>]
    let ``ofChoice converts Choice1Of2 to Ok`` () =
        let choice = Choice1Of2 42
        let result = Result.ofChoice choice
        Assert.Equal(Result.Ok 42, result)

    [<Fact>]
    let ``ofChoice converts Choice2Of2 to Error`` () =
        let choice = Choice2Of2 "error"
        let result = Result.ofChoice choice
        Assert.Equal(Result.Error "error", result)


module StringsModuleTests =

    [<Fact>]
    let ``joinByChar joins strings with separator`` () =
        let result = Strings.joinByChar ',' [| "a"; "b"; "c" |]
        Assert.Equal("a,b,c", result)

    [<Fact>]
    let ``joinByChar with single element returns element`` () =
        let result = Strings.joinByChar ',' [| "only" |]
        Assert.Equal("only", result)

    [<Fact>]
    let ``joinByChar with empty array returns empty string`` () =
        let result = Strings.joinByChar ',' [||]
        Assert.Equal("", result)


module PreludeTests =

    [<Fact>]
    let ``konst ignores second argument and returns first`` () =
        let f = konst 42
        Assert.Equal(42, f "ignored")
        Assert.Equal(42, f "also ignored")

    [<Fact>]
    let ``teeOk calls function on Ok value and passes result through`` () =
        let mutable called = false
        let result : Result<int, string> = Result.Ok 42 |> teeOk (fun x -> called <- true; Assert.Equal(42, x))
        Assert.True(called)
        Assert.Equal(Result.Ok 42, result)

    [<Fact>]
    let ``teeOk does not call function on Error`` () =
        let mutable called = false
        let result : Result<int, string> = Result.Error "fail" |> teeOk (fun _ -> called <- true)
        Assert.False(called)
        Assert.Equal(Result.Error "fail", result)

    [<Fact>]
    let ``teeError calls function on Error value and passes result through`` () =
        let mutable called = false
        let result : Result<int, string> = Result.Error "problem" |> teeError (fun e -> called <- true; Assert.Equal("problem", e))
        Assert.True(called)
        Assert.Equal(Result.Error "problem", result)

    [<Fact>]
    let ``teeError does not call function on Ok`` () =
        let mutable called = false
        let result : Result<int, string> = Result.Ok 42 |> teeError (fun _ -> called <- true)
        Assert.False(called)
        Assert.Equal(Result.Ok 42, result)


module AdditionalEnumJsonTests =

    [<Fact>]
    let ``VersionType enum round-trips correctly`` () =
        let values = [ VersionType.Internal; VersionType.External; VersionType.ExternalGte ]
        for v in values do
            let json = Json.serialize v
            let parsed = Json.deserialize<VersionType> json
            Assert.Equal(v, parsed)

    [<Fact>]
    let ``SearchType enum round-trips correctly`` () =
        let values = [ SearchType.QueryThenFetch; SearchType.DfsQueryThenFetch ]
        for v in values do
            let json = Json.serialize v
            let parsed = Json.deserialize<SearchType> json
            Assert.Equal(v, parsed)

    [<Fact>]
    let ``OpType enum round-trips correctly`` () =
        let values = [ OpType.Index; OpType.Create ]
        for v in values do
            let json = Json.serialize v
            let parsed = Json.deserialize<OpType> json
            Assert.Equal(v, parsed)

    [<Fact>]
    let ``VersionType External deserializes from string 'external'`` () =
        let result = Json.deserialize<VersionType> "\"external\""
        Assert.Equal(VersionType.External, result)

    [<Fact>]
    let ``VersionType ExternalGte deserializes from string 'external_gte'`` () =
        let result = Json.deserialize<VersionType> "\"external_gte\""
        Assert.Equal(VersionType.ExternalGte, result)

    [<Fact>]
    let ``OpType Index deserializes from string 'index'`` () =
        let result = Json.deserialize<OpType> "\"index\""
        Assert.Equal(OpType.Index, result)

    [<Fact>]
    let ``OpType Create deserializes from string 'create'`` () =
        let result = Json.deserialize<OpType> "\"create\""
        Assert.Equal(OpType.Create, result)

    [<Fact>]
    let ``SearchType QueryThenFetch deserializes from string 'query_then_fetch'`` () =
        let result = Json.deserialize<SearchType> "\"query_then_fetch\""
        Assert.Equal(SearchType.QueryThenFetch, result)

    [<Fact>]
    let ``SearchType DfsQueryThenFetch deserializes from string 'dfs_query_then_fetch'`` () =
        let result = Json.deserialize<SearchType> "\"dfs_query_then_fetch\""
        Assert.Equal(SearchType.DfsQueryThenFetch, result)

    [<Fact>]
    let ``SearchType fails on unknown value`` () =
        let ex = Assert.Throws<System.Exception>(fun () ->
            Json.deserialize<SearchType> "\"unknown_search_type\"" |> ignore)
        Assert.Contains("Unknown SearchType", ex.Message)

    [<Fact>]
    let ``OpType fails on unknown value`` () =
        let ex = Assert.Throws<System.Exception>(fun () ->
            Json.deserialize<OpType> "\"unknown_op\"" |> ignore)
        Assert.Contains("Unknown OpType", ex.Message)


module AdditionalElasticsearchExceptionTests =

    open Fes.Exceptions

    let private makeErrorJson exType reason status =
        $"""{{
            "error": {{
                "type": "{exType}",
                "reason": "{reason}",
                "root_cause": [
                    {{ "type": "{exType}", "reason": "{reason}" }}
                ]
            }},
            "status": {status}
        }}"""

    [<Fact>]
    let ``ResourceAlreadyExistsException is parsed correctly`` () =
        let json = makeErrorJson "resource_already_exists_exception" "index [my_index] already exists" 400
        let result = ElasticsearchException.ofString json
        match result with
        | Result.Ok ex ->
            Assert.Equal(ElasticsearchExceptions.ResourceAlreadyExistsException, ex.ErrorType)
            Assert.Equal(400, int ex.Status)
        | Result.Error e -> raise e

    [<Fact>]
    let ``IndexNotFoundException is parsed correctly`` () =
        let json = makeErrorJson "index_not_found_exception" "no such index [missing]" 404
        let result = ElasticsearchException.ofString json
        match result with
        | Result.Ok ex ->
            Assert.Equal(ElasticsearchExceptions.IndexNotFoundException, ex.ErrorType)
            Assert.Equal(404, int ex.Status)
        | Result.Error e -> raise e

    [<Fact>]
    let ``MapperParsingException is parsed correctly`` () =
        let json = makeErrorJson "mapper_parsing_exception" "failed to parse" 400
        let result = ElasticsearchException.ofString json
        match result with
        | Result.Ok ex ->
            Assert.Equal(ElasticsearchExceptions.MapperParsingException, ex.ErrorType)
        | Result.Error e -> raise e

    [<Fact>]
    let ``Unknown exception type is wrapped in Unknown case`` () =
        let json = makeErrorJson "some_new_exception_type" "something went wrong" 500
        let result = ElasticsearchException.ofString json
        match result with
        | Result.Ok ex ->
            Assert.Equal(ElasticsearchExceptions.Unknown "some_new_exception_type", ex.ErrorType)
        | Result.Error e -> raise e

    [<Fact>]
    let ``InvalidIndexNameException is parsed correctly`` () =
        let json = makeErrorJson "invalid_index_name_exception" "Invalid index name [_bad]" 400
        let result = ElasticsearchException.ofString json
        match result with
        | Result.Ok ex ->
            Assert.Equal(ElasticsearchExceptions.InvalidIndexNameException, ex.ErrorType)
        | Result.Error e -> raise e

    [<Fact>]
    let ``SearchPhaseExecutionException is parsed correctly`` () =
        let json = makeErrorJson "search_phase_execution_exception" "all shards failed" 503
        let result = ElasticsearchException.ofString json
        match result with
        | Result.Ok ex ->
            Assert.Equal(ElasticsearchExceptions.SearchPhaseExecutionException, ex.ErrorType)
        | Result.Error e -> raise e

    [<Fact>]
    let ``Exception with index field includes index in result`` () =
        let json = """
        {
            "error": {
                "type": "index_not_found_exception",
                "reason": "no such index [my_index]",
                "index": "my_index",
                "root_cause": [
                    { "type": "index_not_found_exception", "reason": "no such index [my_index]" }
                ]
            },
            "status": 404
        }"""
        let result = ElasticsearchException.ofString json
        match result with
        | Result.Ok ex ->
            Assert.Equal(Some "my_index", ex.Index)
        | Result.Error e -> raise e

    [<Fact>]
    let ``Invalid JSON returns Error`` () =
        let result = ElasticsearchException.ofString "not valid json"
        Assert.True(Result.isError result)

    [<Fact>]
    let ``RawJson is preserved on the exception`` () =
        let json = makeErrorJson "illegal_argument_exception" "bad argument" 400
        let result = ElasticsearchException.ofString json
        match result with
        | Result.Ok ex ->
            Assert.Contains("illegal_argument_exception", ex.RawJson)
        | Result.Error e -> raise e

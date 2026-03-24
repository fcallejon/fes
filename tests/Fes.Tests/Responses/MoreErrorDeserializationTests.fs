namespace Fes.Tests.Responses

open Fes
open Fes.Exceptions
open Xunit

/// Tests for error deserialization of additional Elasticsearch exception types.
/// Covers search_phase_execution_exception (with failed_shards, phase, grouped),
/// index_not_found_exception (with index field), resource_already_exists_exception,
/// and Unknown exception-type fallback.
module MoreErrorDeserializationTests =

    let inline systemJsonSerialize x =
        System.Text.Json.JsonSerializer.Serialize(x)

    // ------------------------------------------------------------------
    // search_phase_execution_exception
    // ------------------------------------------------------------------

    let search_phase_execution_exception_payload =
        {|
            error = {|
                root_cause = [
                    {|
                        ``type`` = "query_shard_exception"
                        reason = "Failed to create query"
                    |}
                ]
                ``type`` = "search_phase_execution_exception"
                reason = "all shards failed"
                phase = "query"
                grouped = true
                failed_shards = {|
                    shard = 0
                    index = "products"
                    node = "node1"
                    reason = {|
                        ``type`` = "query_shard_exception"
                        reason = "Failed to create query"
                    |}
                |}
            |}
            status = 400
        |}

    [<Fact>]
    let ``search_phase_execution_exception deserializes phase and grouped`` () =
        let json = systemJsonSerialize search_phase_execution_exception_payload

        let result = ElasticsearchException.ofString json

        match result with
        | Error e -> Assert.Fail($"Expected Ok but got Error: {e.Message}")
        | Ok ex ->
            Assert.Equal(ElasticsearchExceptions.SearchPhaseExecutionException, ex.ErrorType)
            Assert.Equal(400, int ex.Status)
            Assert.Equal("all shards failed", ex.Reason, ignoreCase = true, ignoreLineEndingDifferences = true, ignoreWhiteSpaceDifferences = true)
            Assert.Equal(Some "query", ex.Phase)
            Assert.Equal(Some true, ex.Grouped)

    [<Fact>]
    let ``search_phase_execution_exception deserializes failed_shards`` () =
        let json = systemJsonSerialize search_phase_execution_exception_payload

        let result = ElasticsearchException.ofString json

        match result with
        | Error e -> Assert.Fail($"Expected Ok but got Error: {e.Message}")
        | Ok ex ->
            Assert.True(ex.FailedShards.IsSome, "FailedShards should be Some")
            let shards = ex.FailedShards.Value
            Assert.Equal(0, shards.Shard)
            Assert.Equal("products", shards.Index)
            Assert.Equal("node1", shards.Node)
            Assert.Equal("Failed to create query", shards.Reason.Reason, ignoreCase = true, ignoreLineEndingDifferences = true, ignoreWhiteSpaceDifferences = true)

    // ------------------------------------------------------------------
    // index_not_found_exception  (has an "index" field in the error object)
    // ------------------------------------------------------------------

    let index_not_found_exception_payload =
        {|
            error = {|
                root_cause = [
                    {|
                        ``type`` = "index_not_found_exception"
                        reason = "no such index [missing_index]"
                    |}
                ]
                ``type`` = "index_not_found_exception"
                reason = "no such index [missing_index]"
                index = "missing_index"
            |}
            status = 404
        |}

    [<Fact>]
    let ``index_not_found_exception deserializes index field`` () =
        let json = systemJsonSerialize index_not_found_exception_payload

        let result = ElasticsearchException.ofString json

        match result with
        | Error e -> Assert.Fail($"Expected Ok but got Error: {e.Message}")
        | Ok ex ->
            Assert.Equal(ElasticsearchExceptions.IndexNotFoundException, ex.ErrorType)
            Assert.Equal(404, int ex.Status)
            Assert.Equal(Some "missing_index", ex.Index)
            Assert.Equal("no such index [missing_index]", ex.Reason, ignoreCase = true, ignoreLineEndingDifferences = true, ignoreWhiteSpaceDifferences = true)

    // ------------------------------------------------------------------
    // resource_already_exists_exception
    // ------------------------------------------------------------------

    let resource_already_exists_payload =
        {|
            error = {|
                root_cause = [
                    {|
                        ``type`` = "resource_already_exists_exception"
                        reason = "index [products/abc123] already exists"
                    |}
                ]
                ``type`` = "resource_already_exists_exception"
                reason = "index [products/abc123] already exists"
            |}
            status = 400
        |}

    [<Fact>]
    let ``resource_already_exists_exception deserializes correctly`` () =
        let json = systemJsonSerialize resource_already_exists_payload

        let result = ElasticsearchException.ofString json

        match result with
        | Error e -> Assert.Fail($"Expected Ok but got Error: {e.Message}")
        | Ok ex ->
            Assert.Equal(ElasticsearchExceptions.ResourceAlreadyExistsException, ex.ErrorType)
            Assert.Equal(400, int ex.Status)
            Assert.Equal("index [products/abc123] already exists", ex.Reason, ignoreCase = true, ignoreLineEndingDifferences = true, ignoreWhiteSpaceDifferences = true)

    // ------------------------------------------------------------------
    // Unknown exception type falls back to Unknown discriminated union case
    // ------------------------------------------------------------------

    let unknown_exception_payload =
        {|
            error = {|
                root_cause = [
                    {|
                        ``type`` = "some_new_exception_type"
                        reason = "Something unexpected happened"
                    |}
                ]
                ``type`` = "some_new_exception_type"
                reason = "Something unexpected happened"
            |}
            status = 500
        |}

    [<Fact>]
    let ``unknown exception type deserializes to Unknown case`` () =
        let json = systemJsonSerialize unknown_exception_payload

        let result = ElasticsearchException.ofString json

        match result with
        | Error e -> Assert.Fail($"Expected Ok but got Error: {e.Message}")
        | Ok ex ->
            match ex.ErrorType with
            | ElasticsearchExceptions.Unknown typeName ->
                Assert.Equal("some_new_exception_type", typeName)
            | other ->
                Assert.Fail($"Expected Unknown but got {other}")
            Assert.Equal(500, int ex.Status)

    // ------------------------------------------------------------------
    // Malformed JSON returns an Error result (not an exception)
    // ------------------------------------------------------------------

    [<Fact>]
    let ``malformed JSON returns Error result`` () =
        let result = ElasticsearchException.ofString "{not valid json"
        Assert.True(result |> Result.isError, "Expected Error for malformed JSON")

    [<Fact>]
    let ``valid JSON without required error field returns Error result`` () =
        let result = ElasticsearchException.ofString """{"status": 400}"""
        Assert.True(result |> Result.isError, "Expected Error when 'error' field is missing")

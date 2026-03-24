namespace Fes.Tests

open System.Net
open System.Net.Http
open System.Text
open Xunit
open Fes
open Fes.Exceptions

/// Integration tests for Http.Response.toResult — the full HTTP response
/// processing pipeline: success path (JSON deserialisation) and error path
/// (Elasticsearch error response parsing).
module HttpResponseTests =

    // ------------------------------------------------------------------
    // Helpers
    // ------------------------------------------------------------------

    let private makeResponse (status: HttpStatusCode) (body: string) =
        let msg = new HttpResponseMessage(status)
        msg.Content <- new StringContent(body, Encoding.UTF8, "application/json")
        msg

    let private awaitResult (t: System.Threading.Tasks.Task<Result<'a, exn>>) =
        t.Result

    // ------------------------------------------------------------------
    // Success path — 2xx responses deserialise body as 'a
    // ------------------------------------------------------------------

    [<Fact>]
    let ``toResult on 200 deserialises JSON body into Ok`` () =
        let json = """{"acknowledged":true,"shards_acknowledged":true,"index":"test_idx"}"""
        let response = makeResponse HttpStatusCode.OK json

        let result =
            Http.Response.toResult response
            |> awaitResult

        match result with
        | Error e -> Assert.Fail($"Expected Ok but got Error: {e.Message}")
        | Ok (r: DSL.Models.Types.IndicesCreateResponse) ->
            Assert.True(r.Acknowledged)
            Assert.True(r.ShardsAcknowledged)
            Assert.Equal("test_idx", string r.Index)

    [<Fact>]
    let ``toResult on 201 deserialises JSON body into Ok`` () =
        let json = """
        {
            "_id": "doc1",
            "_index": "my_index",
            "_version": 1,
            "result": "created",
            "_shards": { "total": 2, "successful": 1, "failed": 0 }
        }"""
        let response = makeResponse HttpStatusCode.Created json

        let result =
            Http.Response.toResult response
            |> awaitResult

        match result with
        | Error e -> Assert.Fail($"Expected Ok but got Error: {e.Message}")
        | Ok (r: DSL.Models.Types.WriteResponseBase) ->
            Assert.Equal("doc1", string r.Id)
            Assert.Equal(DSL.Models.Types.Result.Created, r.Result)

    [<Fact>]
    let ``toResult on 200 with malformed JSON returns Error`` () =
        let response = makeResponse HttpStatusCode.OK "not-valid-json"

        let result =
            Http.Response.toResult response
            |> awaitResult

        match result with
        | Ok _ -> Assert.Fail("Expected Error from malformed JSON but got Ok")
        | Error _ -> () // correct: deserialization failure becomes Error

    // ------------------------------------------------------------------
    // Error path — non-2xx responses parse as ElasticsearchException
    // ------------------------------------------------------------------

    let private illegalArgPayload =
        """
        {
            "error": {
                "root_cause": [
                    { "type": "illegal_argument_exception", "reason": "Bad arg" }
                ],
                "type": "illegal_argument_exception",
                "reason": "Bad arg"
            },
            "status": 400
        }
        """

    [<Fact>]
    let ``toResult on 400 returns Error with ElasticsearchException`` () =
        let response = makeResponse HttpStatusCode.BadRequest illegalArgPayload

        let result =
            Http.Response.toResult response
            |> awaitResult

        match result with
        | Ok _ -> Assert.Fail("Expected Error for 400 response but got Ok")
        | Error ex ->
            let esEx = Assert.IsType<ElasticsearchException>(ex)
            Assert.Equal(ElasticsearchExceptions.IllegalArgumentException, esEx.ErrorType)
            Assert.Equal(400, int esEx.Status)
            Assert.Equal("Bad arg", esEx.Reason, ignoreCase = true,
                         ignoreLineEndingDifferences = true,
                         ignoreWhiteSpaceDifferences = true)

    [<Fact>]
    let ``toResult on 404 returns Error with ElasticsearchException`` () =
        let payload =
            """
            {
                "error": {
                    "root_cause": [],
                    "type": "index_not_found_exception",
                    "reason": "no such index [missing]",
                    "index": "missing"
                },
                "status": 404
            }
            """
        let response = makeResponse HttpStatusCode.NotFound payload

        let result =
            Http.Response.toResult response
            |> awaitResult

        match result with
        | Ok _ -> Assert.Fail("Expected Error for 404 response but got Ok")
        | Error ex ->
            let esEx = Assert.IsType<ElasticsearchException>(ex)
            Assert.Equal(ElasticsearchExceptions.IndexNotFoundException, esEx.ErrorType)
            Assert.Equal(404, int esEx.Status)

    [<Fact>]
    let ``toResult on 500 with unparseable body returns Error`` () =
        // A 500 response whose body is not a valid ES error JSON
        let response = makeResponse HttpStatusCode.InternalServerError "gateway timeout"

        let result =
            Http.Response.toResult response
            |> awaitResult

        match result with
        | Ok _ -> Assert.Fail("Expected Error for 500 response but got Ok")
        | Error ex ->
            // The error message should mention the raw response body
            Assert.Contains("Server Raw Error", ex.Message)

    [<Fact>]
    let ``toResult on 503 with valid ES error returns Error`` () =
        let payload =
            """
            {
                "error": {
                    "root_cause": [],
                    "type": "search_phase_execution_exception",
                    "reason": "all shards failed",
                    "phase": "query",
                    "grouped": true
                },
                "status": 503
            }
            """
        let response = makeResponse HttpStatusCode.ServiceUnavailable payload

        let result =
            Http.Response.toResult response
            |> awaitResult

        match result with
        | Ok _ -> Assert.Fail("Expected Error for 503 response but got Ok")
        | Error ex ->
            let esEx = Assert.IsType<ElasticsearchException>(ex)
            Assert.Equal(ElasticsearchExceptions.SearchPhaseExecutionException, esEx.ErrorType)
            Assert.Equal(503, int esEx.Status)

namespace Fes.Tests

open Fes
open Fes.DSL.Models.Types
open Fes.DSL.Operations
open Xunit

/// Tests for JSON deserialization of Elasticsearch response types
/// These tests ensure that converters work correctly for all response types
module JsonDeserializationTests =

    // ==========================================================================
    // Positive tests - valid JSON should parse correctly
    // ==========================================================================

    [<Fact>]
    let ``Result enum deserializes from string 'deleted'`` () =
        let json = "\"deleted\""
        let result = Json.deserialize<Result> json
        Assert.Equal(Result.Deleted, result)

    [<Fact>]
    let ``Result enum deserializes from string 'created'`` () =
        let json = "\"created\""
        let result = Json.deserialize<Result> json
        Assert.Equal(Result.Created, result)

    [<Fact>]
    let ``Result enum deserializes from string 'updated'`` () =
        let json = "\"updated\""
        let result = Json.deserialize<Result> json
        Assert.Equal(Result.Updated, result)

    [<Fact>]
    let ``Result enum deserializes from string 'not_found'`` () =
        let json = "\"not_found\""
        let result = Json.deserialize<Result> json
        Assert.Equal(Result.NotFound, result)

    [<Fact>]
    let ``Result enum deserializes from string 'noop'`` () =
        let json = "\"noop\""
        let result = Json.deserialize<Result> json
        Assert.Equal(Result.Noop, result)

    [<Fact>]
    let ``WriteResponseBase deserializes with string result`` () =
        let json = """
        {
            "_id": "test_doc",
            "_index": "test_index",
            "_version": 1,
            "result": "deleted",
            "_shards": {
                "total": 2,
                "successful": 1,
                "failed": 0
            }
        }
        """
        let response = Json.deserialize<WriteResponseBase> json
        Assert.Equal("test_doc", string response.Id)
        Assert.Equal("test_index", string response.Index)
        Assert.Equal(Result.Deleted, response.Result)

    [<Fact>]
    let ``Refresh enum deserializes correctly`` () =
        Assert.Equal(Refresh.True, Json.deserialize<Refresh> "\"true\"")
        Assert.Equal(Refresh.False, Json.deserialize<Refresh> "\"false\"")
        Assert.Equal(Refresh.WaitFor, Json.deserialize<Refresh> "\"wait_for\"")

    [<Fact>]
    let ``HealthStatus enum deserializes correctly`` () =
        Assert.Equal(HealthStatus.Green, Json.deserialize<HealthStatus> "\"green\"")
        Assert.Equal(HealthStatus.Yellow, Json.deserialize<HealthStatus> "\"yellow\"")
        Assert.Equal(HealthStatus.Red, Json.deserialize<HealthStatus> "\"red\"")

    [<Fact>]
    let ``IndicesCreateResponse deserializes correctly`` () =
        let json = """
        {
            "acknowledged": true,
            "shards_acknowledged": true,
            "index": "my_index"
        }
        """
        let response = Json.deserialize<IndicesCreateResponse> json
        Assert.True(response.Acknowledged)
        Assert.True(response.ShardsAcknowledged)
        Assert.Equal("my_index", string response.Index)

    [<Fact>]
    let ``SearchResponseBody deserializes basic response`` () =
        let json = """
        {
            "took": 5,
            "timed_out": false,
            "_shards": {
                "total": 5,
                "successful": 5,
                "skipped": 0,
                "failed": 0
            },
            "hits": {
                "total": { "value": 10, "relation": "eq" },
                "max_score": 1.0,
                "hits": []
            }
        }
        """
        let response = Json.deserialize<SearchResponseBody> json
        Assert.Equal(5.0, response.Took)
        Assert.False(response.TimedOut)
        Assert.Equal(0, response.Hits.Hits.Length)

    // ==========================================================================
    // Negative tests - invalid JSON should fail with descriptive errors
    // ==========================================================================

    [<Fact>]
    let ``Result enum fails on invalid string`` () =
        let json = "\"invalid_result\""
        let ex = Assert.Throws<System.Exception>(fun () ->
            Json.deserialize<Result> json |> ignore)
        Assert.Contains("Unknown Result", ex.Message)

    [<Fact>]
    let ``Refresh enum fails on invalid string`` () =
        let json = "\"invalid\""
        let ex = Assert.Throws<System.Exception>(fun () ->
            Json.deserialize<Refresh> json |> ignore)
        Assert.Contains("Unknown Refresh", ex.Message)

    [<Fact>]
    let ``WriteResponseBase fails on missing required fields`` () =
        let json = """{ "_id": "test" }"""
        Assert.Throws<System.Text.Json.JsonException>(fun () ->
            Json.deserialize<WriteResponseBase> json |> ignore)

    // ==========================================================================
    // Round-trip tests - serialize then deserialize should preserve values
    // ==========================================================================

    [<Fact>]
    let ``Result enum round-trips correctly`` () =
        let values = [Result.Created; Result.Updated; Result.Deleted; Result.NotFound; Result.Noop]
        for value in values do
            let json = Json.serialize value
            let parsed = Json.deserialize<Result> json
            Assert.Equal(value, parsed)

    [<Fact>]
    let ``Refresh enum round-trips correctly`` () =
        let values = [Refresh.True; Refresh.False; Refresh.WaitFor]
        for value in values do
            let json = Json.serialize value
            let parsed = Json.deserialize<Refresh> json
            Assert.Equal(value, parsed)

    [<Fact>]
    let ``HealthStatus enum round-trips correctly`` () =
        let values = [HealthStatus.Green; HealthStatus.Yellow; HealthStatus.Red]
        for value in values do
            let json = Json.serialize value
            let parsed = Json.deserialize<HealthStatus> json
            Assert.Equal(value, parsed)

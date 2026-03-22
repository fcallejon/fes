namespace Fes.Tests.Responses

open Fes
open Fes.Exceptions
open Xunit

module ErrorDeserialization =
    let illegal_argument_exception =
      {|
        error = {|
          root_cause = [
            {|
              ``type`` = "illegal_argument_exception"
              reason = "Failed to parse int parameter [size] with value [surprise_me]"
            |}
          ]
          ``type`` = "illegal_argument_exception"
          reason = "Failed to parse int parameter [size] with value [surprise_me]"
          caused_by = {|
            ``type`` = "number_format_exception"
            reason = "For input string: \"surprise_me\""
          |}
        |}
        status = 400
      |}

    let search_phase_execution_exception =
      {|
        error = {|
          root_cause = [||]
          ``type`` = "search_phase_execution_exception"
          reason = "all shards failed"
          phase = "query"
          grouped = true
          failed_shards = [
            {|
              shard = 0
              index = "my-index"
              node = "abc123"
              reason = {|
                ``type`` = "parsing_exception"
                reason = "Unknown key for a VALUE_STRING in [query]."
              |}
            |}
          ]
        |}
        status = 400
      |}

    let inline systemJsonSerialize x =
      System.Text.Json.JsonSerializer.Serialize(x)

    [<Fact>]
    let ``illegal_argument_exception from ES can be parsed`` () =
      let assertValues (iaException: ElasticsearchException) =
        Assert.Equal(illegal_argument_exception.error.reason, iaException.Reason, true, true, true)
        Assert.Equal(illegal_argument_exception.error.root_cause.Head.reason, iaException.RootCause.[0].Reason, true, true, true)
        Assert.Equal(illegal_argument_exception.status, (int iaException.Status))
        Assert.Equal(ElasticsearchExceptions.IllegalArgumentException, iaException.ErrorType)
        Assert.Equal(ElasticsearchCauseByType.NumberFormat, iaException.Cause.Value.Type)
        Assert.Equal(illegal_argument_exception.error.caused_by.reason, iaException.Cause.Value.Reason, true, true, true)

      match illegal_argument_exception |> systemJsonSerialize |> ElasticsearchException.ofString with
      | Ok ex -> assertValues ex
      | Error e -> raise e

    [<Fact>]
    let ``search_phase_execution_exception phase and failed_shards are deserialized from error object`` () =
      match search_phase_execution_exception |> systemJsonSerialize |> ElasticsearchException.ofString with
      | Ok ex ->
        Assert.Equal(ElasticsearchExceptions.SearchPhaseExecutionException, ex.ErrorType)
        Assert.Equal("query", ex.Phase.Value)
        Assert.True(ex.Grouped.Value)
        let shards = ex.FailedShards.Value
        Assert.Equal(1, shards.Length)
        Assert.Equal(0, shards.[0].Shard)
        Assert.Equal("my-index", shards.[0].Index)
      | Error e -> raise e

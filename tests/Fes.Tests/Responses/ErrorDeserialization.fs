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

    let inline systemJsonSerialize x =
      System.Text.Json.JsonSerializer.Serialize(x)

    [<Fact>]
    let ``illegal_argument_exception from ES can be parsed`` () =
      let assertValues (iaException: ElasticsearchException) =
        Assert.Equal(illegal_argument_exception.error.reason, iaException.reason, true, true, true)
        Assert.Equal(illegal_argument_exception.error.root_cause.Head.reason, iaException.root.[0].Reason, true, true, true)
        Assert.Equal(illegal_argument_exception.status, (int iaException.status))
        Assert.Equal(ElasticsearchExceptions.IllegalArgumentException, iaException.esType)
        Assert.Equal(ElasticsearchCauseByType.NumberFormat, iaException.cause.Value.Type)
        Assert.Equal(illegal_argument_exception.error.caused_by.reason, iaException.cause.Value.Reason, true, true, true)

      illegal_argument_exception
      |> systemJsonSerialize
      |> ElasticsearchException.ofString
      |> Result.map assertValues
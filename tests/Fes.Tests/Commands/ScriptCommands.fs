namespace Fes.Tests

open Fes.DSL.Models.Types
open Fes.DSL.Operations
open Xunit

/// Tests for script operations, including validation of path vs query parameter collision handling
module ScriptCommands =

    [<Fact>]
    let ``Put script request uses Context in path and Context2 in query`` () =
        // This test validates the fix for the JsonPropertyName collision bug
        // Context goes in the URL path: /_scripts/{id}/{context}
        // Context2 goes in the query string: ?context=...

        // Create a minimal StoredScript for the body
        let storedScript : StoredScript =
            { Lang = Option.Some "painless"
              Options = Option.None
              Source = Option.Some "doc['field'].value * 2" }

        let putReq = putScriptRequest {
            id "my_script"
            context "score"              // Path parameter: /_scripts/my_script/score
            context2 "filter"            // Query parameter: ?context=filter
            timeout "30s"
            script storedScript
        }

        let result = putReq |> toRequestString

        // Verify the path contains the Context value
        Assert.Contains("/_scripts/my_script/score", result)

        // Verify the query string contains Context2 as "context" parameter
        Assert.Contains("context=filter", result)

        // Verify timeout is also in query string
        Assert.Contains("timeout=30s", result)

        // Verify it's a POST request
        Assert.Contains("Method: POST", result)

    [<Fact>]
    let ``Put script request with only path context works correctly`` () =
        let storedScript : StoredScript =
            { Lang = Option.Some "painless"
              Options = Option.None
              Source = Option.Some "return 1" }

        let putReq = putScriptRequest {
            id "simple_script"
            context "score"
            script storedScript
        }

        let result = putReq |> toRequestString

        // Path should contain context
        Assert.Contains("/_scripts/simple_script/score", result)

        // No query context parameter since Context2 is not set
        // The URL should end with just the path or have other params but not "context="

    [<Fact>]
    let ``Get script request returns correct HTTP call`` () =
        let getReq = getScriptRequest {
            id "my_script"
        }

        let result = getReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/_scripts/my_script", result)

    [<Fact>]
    let ``Delete script request returns correct HTTP call`` () =
        let deleteReq = deleteScriptRequest {
            id "my_script"
            timeout "30s"
        }

        let result = deleteReq |> toRequestString

        Assert.Contains("Method: DELETE", result)
        Assert.Contains("/_scripts/my_script", result)
        Assert.Contains("timeout=30s", result)

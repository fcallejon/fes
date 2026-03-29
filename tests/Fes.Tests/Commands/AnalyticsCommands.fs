namespace Fes.Tests

open Fes.DSL.Models.Types
open Fes.DSL.Operations
open Xunit

module AnalyticsCommands =

    [<Fact>]
    let ``Get behavioral analytics with single name returns correct path`` () =
        let req = searchApplicationGetBehavioralAnalyticsRequest {
            name [| "my_collection" |]
        }

        let result = req |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/_application/analytics/my_collection", result)

    [<Fact>]
    let ``Get behavioral analytics with multiple names returns comma-separated path`` () =
        let req = searchApplicationGetBehavioralAnalyticsRequest {
            name [| "collection_a"; "collection_b" |]
        }

        let result = req |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/_application/analytics/collection_a,collection_b", result)

    [<Fact>]
    let ``Put behavioral analytics returns correct path`` () =
        let req = searchApplicationPutBehavioralAnalyticsRequest {
            name "my_collection"
        }

        let result = req |> toRequestString

        Assert.Contains("Method: PUT", result)
        Assert.Contains("/_application/analytics/my_collection", result)

    [<Fact>]
    let ``Delete behavioral analytics returns correct path`` () =
        let req = searchApplicationDeleteBehavioralAnalyticsRequest {
            name "my_collection"
        }

        let result = req |> toRequestString

        Assert.Contains("Method: DELETE", result)
        Assert.Contains("/_application/analytics/my_collection", result)

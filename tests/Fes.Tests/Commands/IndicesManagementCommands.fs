namespace Fes.Tests

open Fes.DSL.Models.Types
open Fes.DSL.Operations
open Xunit

module IndicesManagementCommands =

    [<Fact>]
    let ``Indices get request returns correct HTTP call`` () =
        let req = indicesGetRequest {
            index (box "products" : Indices)
        }

        let result = req |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/products", result)

    [<Fact>]
    let ``Indices get request with options returns correct HTTP call`` () =
        let req = indicesGetRequest {
            index (box "products" : Indices)
            flat_settings true
            include_defaults true
        }

        let result = req |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/products", result)
        Assert.Contains("flat_settings=true", result)
        Assert.Contains("include_defaults=true", result)

    [<Fact>]
    let ``Indices delete request returns correct HTTP call`` () =
        let req = indicesDeleteRequest {
            index (box "old-index" : Indices)
        }

        let result = req |> toRequestString

        Assert.Contains("Method: DELETE", result)
        Assert.Contains("/old-index", result)

    [<Fact>]
    let ``Indices delete request with timeout returns correct HTTP call`` () =
        let req = indicesDeleteRequest {
            index (box "old-index" : Indices)
            timeout "30s"
        }

        let result = req |> toRequestString

        Assert.Contains("Method: DELETE", result)
        Assert.Contains("/old-index", result)
        Assert.Contains("timeout=30s", result)

    [<Fact>]
    let ``Indices exists request returns correct HTTP call`` () =
        let req = indicesExistsRequest {
            index (box "products" : Indices)
        }

        let result = req |> toRequestString

        Assert.Contains("Method: HEAD", result)
        Assert.Contains("/products", result)

    [<Fact>]
    let ``Indices refresh request returns correct HTTP call`` () =
        let req = indicesRefreshRequest {
            index (box "products" : Indices)
        }

        let result = req |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_refresh", result)

    [<Fact>]
    let ``Indices refresh request with ignore_unavailable returns correct HTTP call`` () =
        let req = indicesRefreshRequest {
            index (box "products" : Indices)
            ignore_unavailable true
        }

        let result = req |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_refresh", result)
        Assert.Contains("ignore_unavailable=true", result)

    [<Fact>]
    let ``Indices flush request returns correct HTTP call`` () =
        let req = indicesFlushRequest {
            index (box "products" : Indices)
        }

        let result = req |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_flush", result)

    [<Fact>]
    let ``Indices flush request with force returns correct HTTP call`` () =
        let req = indicesFlushRequest {
            index (box "products" : Indices)
            force true
        }

        let result = req |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_flush", result)
        Assert.Contains("force=true", result)

    [<Fact>]
    let ``Indices close request returns correct HTTP call`` () =
        let req = indicesCloseRequest {
            index (box "products" : Indices)
        }

        let result = req |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_close", result)

    [<Fact>]
    let ``Indices open request returns correct HTTP call`` () =
        let req = indicesOpenRequest {
            index (box "products" : Indices)
        }

        let result = req |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_open", result)

    [<Fact>]
    let ``Indices clear cache request returns correct HTTP call`` () =
        let req = indicesClearCacheRequest {
            index (box "products" : Indices)
        }

        let result = req |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_cache/clear", result)

    [<Fact>]
    let ``Indices forcemerge request returns correct HTTP call`` () =
        let req = indicesForcemergeRequest {
            index (box "products" : Indices)
        }

        let result = req |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_forcemerge", result)

    [<Fact>]
    let ``Indices forcemerge request with max segments returns correct HTTP call`` () =
        let req = indicesForcemergeRequest {
            index (box "products" : Indices)
            max_num_segments 1.0
            only_expunge_deletes true
        }

        let result = req |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_forcemerge", result)
        Assert.Contains("max_num_segments=1", result)
        Assert.Contains("only_expunge_deletes=true", result)

    [<Fact>]
    let ``Indices get mapping request returns correct HTTP call`` () =
        let req = indicesGetMappingRequest {
            index (box "products" : Indices)
        }

        let result = req |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/products/_mapping", result)

    [<Fact>]
    let ``Indices get settings request returns correct HTTP call`` () =
        let req = indicesGetSettingsRequest {
            index (box "products" : Indices)
            name (box "*" : Names)
        }

        let result = req |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/products/_settings/*", result)

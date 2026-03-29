namespace Fes.Tests

open Fes.DSL.Models.Types
open Fes.DSL.Operations
open Xunit

module DataStreamCommands =

    [<Fact>]
    let ``Get data stream request returns correct HTTP call`` () =
        let getReq = indicesGetDataStreamRequest {
            name (box "my-data-stream" : DataStreamNames)
        }

        let result = getReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("RequestUri: '/_data_stream/my-data-stream'", result)

    [<Fact>]
    let ``Get data stream request with options returns correct HTTP call`` () =
        let getReq = indicesGetDataStreamRequest {
            name (box "my-data-stream" : DataStreamNames)
            include_defaults true
            verbose true
            master_timeout "30s"
        }

        let result = getReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/_data_stream/my-data-stream", result)
        Assert.Contains("include_defaults=true", result)
        Assert.Contains("verbose=true", result)
        Assert.Contains("master_timeout=30s", result)

    [<Fact>]
    let ``Create data stream request returns correct HTTP call`` () =
        let createReq = indicesCreateDataStreamRequest {
            name "my-data-stream"
        }

        let result = createReq |> toRequestString

        Assert.Contains("Method: PUT", result)
        Assert.Contains("RequestUri: '/_data_stream/my-data-stream'", result)

    [<Fact>]
    let ``Create data stream request with timeout returns correct HTTP call`` () =
        let createReq = indicesCreateDataStreamRequest {
            name "my-data-stream"
            timeout "30s"
            master_timeout "60s"
        }

        let result = createReq |> toRequestString

        Assert.Contains("Method: PUT", result)
        Assert.Contains("/_data_stream/my-data-stream", result)
        Assert.Contains("timeout=30s", result)
        Assert.Contains("master_timeout=60s", result)

    [<Fact>]
    let ``Delete data stream request returns correct HTTP call`` () =
        let deleteReq = indicesDeleteDataStreamRequest {
            name (box "my-data-stream" : DataStreamNames)
        }

        let result = deleteReq |> toRequestString

        Assert.Contains("Method: DELETE", result)
        Assert.Contains("RequestUri: '/_data_stream/my-data-stream'", result)

    [<Fact>]
    let ``Delete data stream request with options returns correct HTTP call`` () =
        let deleteReq = indicesDeleteDataStreamRequest {
            name (box "logs-*" : DataStreamNames)
            master_timeout "30s"
        }

        let result = deleteReq |> toRequestString

        Assert.Contains("Method: DELETE", result)
        Assert.Contains("/_data_stream/logs-*", result)
        Assert.Contains("master_timeout=30s", result)

    [<Fact>]
    let ``Data stream stats request returns correct HTTP call`` () =
        let statsReq = indicesDataStreamsStatsRequest {
            name (box "my-data-stream" : Indices)
        }

        let result = statsReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/_data_stream/my-data-stream/_stats", result)

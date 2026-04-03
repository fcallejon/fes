// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module StreamsOperations =

    type StreamsLogsDisableRequest = {
        Name: Types.StreamType
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: StreamsLogsDisableRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_streams/{req.Name}/_disable"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type StreamsLogsDisableResponse = Types.AcknowledgedResponseBase

    type StreamsLogsDisableRequestBuilder() =
        member _.Yield(_: unit) : StreamsLogsDisableRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: StreamsLogsDisableRequest, value: Types.StreamType) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: StreamsLogsDisableRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: StreamsLogsDisableRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let streamsLogsDisableRequest = StreamsLogsDisableRequestBuilder()

    module LogsDisable =
        let withMasterTimeout (value: Types.Duration) (req: StreamsLogsDisableRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: StreamsLogsDisableRequest) =
            { req with Timeout = Some value }

    type StreamsLogsEnableRequest = {
        Name: Types.StreamType
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: StreamsLogsEnableRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_streams/{req.Name}/_enable"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type StreamsLogsEnableResponse = Types.AcknowledgedResponseBase

    type StreamsLogsEnableRequestBuilder() =
        member _.Yield(_: unit) : StreamsLogsEnableRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: StreamsLogsEnableRequest, value: Types.StreamType) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: StreamsLogsEnableRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: StreamsLogsEnableRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let streamsLogsEnableRequest = StreamsLogsEnableRequestBuilder()

    module LogsEnable =
        let withMasterTimeout (value: Types.Duration) (req: StreamsLogsEnableRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: StreamsLogsEnableRequest) =
            { req with Timeout = Some value }

    type StreamsStatusRequest = {
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: StreamsStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_streams/status"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type StreamsStatusResponse = System.Text.Json.JsonElement

    type StreamsStatusRequestBuilder() =
        member _.Yield(_: unit) : StreamsStatusRequest =
            {
                MasterTimeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: StreamsStatusRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let streamsStatusRequest = StreamsStatusRequestBuilder()

    module Status =
        let withMasterTimeout (value: Types.Duration) (req: StreamsStatusRequest) =
            { req with MasterTimeout = Some value }


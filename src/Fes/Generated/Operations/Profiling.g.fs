// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module ProfilingOperations =

    type ProfilingFlamegraphRequest = {
        Document: obj
    }

        with
        static member ToRequest(req: ProfilingFlamegraphRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_profiling/flamegraph"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type ProfilingFlamegraphResponse = System.Text.Json.JsonElement

    type ProfilingFlamegraphRequestBuilder() =
        member _.Yield(_: unit) : ProfilingFlamegraphRequest =
            {
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("document")>]
        member _.Document(state: ProfilingFlamegraphRequest, value) =
            { state with Document = value }

    let profilingFlamegraphRequest = ProfilingFlamegraphRequestBuilder()

    type ProfilingStacktracesRequest = {
        Document: obj
    }

        with
        static member ToRequest(req: ProfilingStacktracesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_profiling/stacktraces"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type ProfilingStacktracesResponse = System.Text.Json.JsonElement

    type ProfilingStacktracesRequestBuilder() =
        member _.Yield(_: unit) : ProfilingStacktracesRequest =
            {
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("document")>]
        member _.Document(state: ProfilingStacktracesRequest, value) =
            { state with Document = value }

    let profilingStacktracesRequest = ProfilingStacktracesRequestBuilder()

    type ProfilingStatusRequest = {
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        WaitForResourcesCreated: bool option
    }

        with
        static member ToRequest(req: ProfilingStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_profiling/status"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        req.WaitForResourcesCreated |> Option.map (fun v -> "wait_for_resources_created", Fes.Http.toQueryValue v)
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

    type ProfilingStatusResponse = System.Text.Json.JsonElement

    type ProfilingStatusRequestBuilder() =
        member _.Yield(_: unit) : ProfilingStatusRequest =
            {
                MasterTimeout = None
                Timeout = None
                WaitForResourcesCreated = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: ProfilingStatusRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: ProfilingStatusRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("waitForResourcesCreated")>]
        member _.WaitForResourcesCreated(state: ProfilingStatusRequest, value: bool) =
            { state with WaitForResourcesCreated = Some value }

    let profilingStatusRequest = ProfilingStatusRequestBuilder()

    module Status =
        let withMasterTimeout (value: Types.Duration) (req: ProfilingStatusRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: ProfilingStatusRequest) =
            { req with Timeout = Some value }
        let withWaitForResourcesCreated (value: bool) (req: ProfilingStatusRequest) =
            { req with WaitForResourcesCreated = Some value }

    type ProfilingTopnFunctionsRequest = {
        Document: obj
    }

        with
        static member ToRequest(req: ProfilingTopnFunctionsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_profiling/topn/functions"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type ProfilingTopnFunctionsResponse = System.Text.Json.JsonElement

    type ProfilingTopnFunctionsRequestBuilder() =
        member _.Yield(_: unit) : ProfilingTopnFunctionsRequest =
            {
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("document")>]
        member _.Document(state: ProfilingTopnFunctionsRequest, value) =
            { state with Document = value }

    let profilingTopnFunctionsRequest = ProfilingTopnFunctionsRequestBuilder()


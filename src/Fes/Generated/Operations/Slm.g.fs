// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module SlmOperations =

    type SlmDeleteLifecycleRequest = {
        PolicyId: CoreTypes.Name
        MasterTimeout: CoreTypes.Duration option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: SlmDeleteLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_slm/policy/{req.PolicyId}"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type SlmDeleteLifecycleResponse = CoreTypes.AcknowledgedResponseBase

    type SlmDeleteLifecycleRequestBuilder() =
        member _.Yield(_: unit) : SlmDeleteLifecycleRequest =
            {
                PolicyId = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("policyId")>]
        member _.PolicyId(state: SlmDeleteLifecycleRequest, value: CoreTypes.Name) =
            { state with PolicyId = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SlmDeleteLifecycleRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmDeleteLifecycleRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let slmDeleteLifecycleRequest = SlmDeleteLifecycleRequestBuilder()

    module DeleteLifecycle =
        let withMasterTimeout (value: CoreTypes.Duration) (req: SlmDeleteLifecycleRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: SlmDeleteLifecycleRequest) =
            { req with Timeout = Some value }

    type SlmExecuteLifecycleRequest = {
        PolicyId: CoreTypes.Name
        MasterTimeout: CoreTypes.Duration option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: SlmExecuteLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_slm/policy/{req.PolicyId}/_execute"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Result.Ok
            with ex -> Result.Error ex

    type SlmExecuteLifecycleResponse = System.Text.Json.JsonElement

    type SlmExecuteLifecycleRequestBuilder() =
        member _.Yield(_: unit) : SlmExecuteLifecycleRequest =
            {
                PolicyId = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("policyId")>]
        member _.PolicyId(state: SlmExecuteLifecycleRequest, value: CoreTypes.Name) =
            { state with PolicyId = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SlmExecuteLifecycleRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmExecuteLifecycleRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let slmExecuteLifecycleRequest = SlmExecuteLifecycleRequestBuilder()

    module ExecuteLifecycle =
        let withMasterTimeout (value: CoreTypes.Duration) (req: SlmExecuteLifecycleRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: SlmExecuteLifecycleRequest) =
            { req with Timeout = Some value }

    type SlmExecuteRetentionRequest = {
        MasterTimeout: CoreTypes.Duration option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: SlmExecuteRetentionRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_slm/_execute_retention"
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

    type SlmExecuteRetentionResponse = CoreTypes.AcknowledgedResponseBase

    type SlmExecuteRetentionRequestBuilder() =
        member _.Yield(_: unit) : SlmExecuteRetentionRequest =
            {
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SlmExecuteRetentionRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmExecuteRetentionRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let slmExecuteRetentionRequest = SlmExecuteRetentionRequestBuilder()

    module ExecuteRetention =
        let withMasterTimeout (value: CoreTypes.Duration) (req: SlmExecuteRetentionRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: SlmExecuteRetentionRequest) =
            { req with Timeout = Some value }

    type SlmGetLifecycleRequest = {
        PolicyId: CoreTypes.Names
        MasterTimeout: CoreTypes.Duration option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: SlmGetLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_slm/policy/{req.PolicyId}"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type SlmGetLifecycleResponse = Map<CoreTypes.Id, SlmTypes.SnapshotLifecycle>

    type SlmGetLifecycleRequestBuilder() =
        member _.Yield(_: unit) : SlmGetLifecycleRequest =
            {
                PolicyId = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("policyId")>]
        member _.PolicyId(state: SlmGetLifecycleRequest, value: CoreTypes.Names) =
            { state with PolicyId = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SlmGetLifecycleRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmGetLifecycleRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let slmGetLifecycleRequest = SlmGetLifecycleRequestBuilder()

    module GetLifecycle =
        let withMasterTimeout (value: CoreTypes.Duration) (req: SlmGetLifecycleRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: SlmGetLifecycleRequest) =
            { req with Timeout = Some value }

    type SlmGetStatsRequest = {
        MasterTimeout: CoreTypes.Duration option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: SlmGetStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_slm/stats"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type SlmGetStatsResponse = System.Text.Json.JsonElement

    type SlmGetStatsRequestBuilder() =
        member _.Yield(_: unit) : SlmGetStatsRequest =
            {
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SlmGetStatsRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmGetStatsRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let slmGetStatsRequest = SlmGetStatsRequestBuilder()

    module GetStats =
        let withMasterTimeout (value: CoreTypes.Duration) (req: SlmGetStatsRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: SlmGetStatsRequest) =
            { req with Timeout = Some value }

    type SlmGetStatusRequest = {
        MasterTimeout: CoreTypes.Duration option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: SlmGetStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_slm/status"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type SlmGetStatusResponse = System.Text.Json.JsonElement

    type SlmGetStatusRequestBuilder() =
        member _.Yield(_: unit) : SlmGetStatusRequest =
            {
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SlmGetStatusRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmGetStatusRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let slmGetStatusRequest = SlmGetStatusRequestBuilder()

    module GetStatus =
        let withMasterTimeout (value: CoreTypes.Duration) (req: SlmGetStatusRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: SlmGetStatusRequest) =
            { req with Timeout = Some value }

    type SlmPutLifecycleRequest = {
        PolicyId: CoreTypes.Name
        MasterTimeout: CoreTypes.Duration option
        Timeout: CoreTypes.Duration option
        Config: SlmTypes.Configuration option
        Name: CoreTypes.Name option
        Repository: string option
        Retention: SlmTypes.Retention option
        Schedule: WatcherTypes.CronExpression option
    }

        with
        static member ToRequest(req: SlmPutLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_slm/policy/{req.PolicyId}"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SlmPutLifecycleResponse = CoreTypes.AcknowledgedResponseBase

    type SlmPutLifecycleRequestBuilder() =
        member _.Yield(_: unit) : SlmPutLifecycleRequest =
            {
                PolicyId = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
                Config = None
                Name = None
                Repository = None
                Retention = None
                Schedule = None
            }

        [<CustomOperation("policyId")>]
        member _.PolicyId(state: SlmPutLifecycleRequest, value: CoreTypes.Name) =
            { state with PolicyId = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SlmPutLifecycleRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmPutLifecycleRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("config")>]
        member _.Config(state: SlmPutLifecycleRequest, value: SlmTypes.Configuration) =
            { state with Config = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: SlmPutLifecycleRequest, value: CoreTypes.Name) =
            { state with Name = Some value }

        [<CustomOperation("repository")>]
        member _.Repository(state: SlmPutLifecycleRequest, value: string) =
            { state with Repository = Some value }

        [<CustomOperation("retention")>]
        member _.Retention(state: SlmPutLifecycleRequest, value: SlmTypes.Retention) =
            { state with Retention = Some value }

        [<CustomOperation("schedule")>]
        member _.Schedule(state: SlmPutLifecycleRequest, value: WatcherTypes.CronExpression) =
            { state with Schedule = Some value }

    let slmPutLifecycleRequest = SlmPutLifecycleRequestBuilder()

    module PutLifecycle =
        let withMasterTimeout (value: CoreTypes.Duration) (req: SlmPutLifecycleRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: SlmPutLifecycleRequest) =
            { req with Timeout = Some value }
        let withConfig (value: SlmTypes.Configuration) (req: SlmPutLifecycleRequest) =
            { req with Config = Some value }
        let withName (value: CoreTypes.Name) (req: SlmPutLifecycleRequest) =
            { req with Name = Some value }
        let withRepository (value: string) (req: SlmPutLifecycleRequest) =
            { req with Repository = Some value }
        let withRetention (value: SlmTypes.Retention) (req: SlmPutLifecycleRequest) =
            { req with Retention = Some value }
        let withSchedule (value: WatcherTypes.CronExpression) (req: SlmPutLifecycleRequest) =
            { req with Schedule = Some value }

    type SlmStartRequest = {
        MasterTimeout: CoreTypes.Duration option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: SlmStartRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_slm/start"
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

    type SlmStartResponse = CoreTypes.AcknowledgedResponseBase

    type SlmStartRequestBuilder() =
        member _.Yield(_: unit) : SlmStartRequest =
            {
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SlmStartRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmStartRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let slmStartRequest = SlmStartRequestBuilder()

    module Start =
        let withMasterTimeout (value: CoreTypes.Duration) (req: SlmStartRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: SlmStartRequest) =
            { req with Timeout = Some value }

    type SlmStopRequest = {
        MasterTimeout: CoreTypes.Duration option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: SlmStopRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_slm/stop"
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

    type SlmStopResponse = CoreTypes.AcknowledgedResponseBase

    type SlmStopRequestBuilder() =
        member _.Yield(_: unit) : SlmStopRequest =
            {
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SlmStopRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmStopRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let slmStopRequest = SlmStopRequestBuilder()

    module Stop =
        let withMasterTimeout (value: CoreTypes.Duration) (req: SlmStopRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: SlmStopRequest) =
            { req with Timeout = Some value }


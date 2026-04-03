// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module SlmOperations =

    type SlmDeleteLifecycleRequest = {
        PolicyId: Types.Name
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: SlmDeleteLifecycleRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type SlmDeleteLifecycleResponse = Types.AcknowledgedResponseBase

    type SlmDeleteLifecycleRequestBuilder() =
        member _.Yield(_: unit) : SlmDeleteLifecycleRequest =
            {
                PolicyId = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("policyId")>]
        member _.PolicyId(state: SlmDeleteLifecycleRequest, value: Types.Name) =
            { state with PolicyId = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SlmDeleteLifecycleRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmDeleteLifecycleRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let slmDeleteLifecycleRequest = SlmDeleteLifecycleRequestBuilder()

    module DeleteLifecycle =
        let withMasterTimeout (value: Types.Duration) (req: SlmDeleteLifecycleRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: SlmDeleteLifecycleRequest) =
            { req with Timeout = Some value }

    type SlmExecuteLifecycleRequest = {
        PolicyId: Types.Name
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: SlmExecuteLifecycleRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            endpoint, ValueNone

    type SlmExecuteLifecycleResponse = System.Text.Json.JsonElement

    type SlmExecuteLifecycleRequestBuilder() =
        member _.Yield(_: unit) : SlmExecuteLifecycleRequest =
            {
                PolicyId = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("policyId")>]
        member _.PolicyId(state: SlmExecuteLifecycleRequest, value: Types.Name) =
            { state with PolicyId = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SlmExecuteLifecycleRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmExecuteLifecycleRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let slmExecuteLifecycleRequest = SlmExecuteLifecycleRequestBuilder()

    module ExecuteLifecycle =
        let withMasterTimeout (value: Types.Duration) (req: SlmExecuteLifecycleRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: SlmExecuteLifecycleRequest) =
            { req with Timeout = Some value }

    type SlmExecuteRetentionRequest = {
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: SlmExecuteRetentionRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            endpoint, ValueNone

    type SlmExecuteRetentionResponse = Types.AcknowledgedResponseBase

    type SlmExecuteRetentionRequestBuilder() =
        member _.Yield(_: unit) : SlmExecuteRetentionRequest =
            {
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SlmExecuteRetentionRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmExecuteRetentionRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let slmExecuteRetentionRequest = SlmExecuteRetentionRequestBuilder()

    module ExecuteRetention =
        let withMasterTimeout (value: Types.Duration) (req: SlmExecuteRetentionRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: SlmExecuteRetentionRequest) =
            { req with Timeout = Some value }

    type SlmGetLifecycleRequest = {
        PolicyId: Types.Names
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: SlmGetLifecycleRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type SlmGetLifecycleResponse = Map<Types.Id, Types.SnapshotLifecycle>

    type SlmGetLifecycleRequestBuilder() =
        member _.Yield(_: unit) : SlmGetLifecycleRequest =
            {
                PolicyId = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("policyId")>]
        member _.PolicyId(state: SlmGetLifecycleRequest, value: Types.Names) =
            { state with PolicyId = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SlmGetLifecycleRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmGetLifecycleRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let slmGetLifecycleRequest = SlmGetLifecycleRequestBuilder()

    module GetLifecycle =
        let withMasterTimeout (value: Types.Duration) (req: SlmGetLifecycleRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: SlmGetLifecycleRequest) =
            { req with Timeout = Some value }

    type SlmGetStatsRequest = {
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: SlmGetStatsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type SlmGetStatsResponse = System.Text.Json.JsonElement

    type SlmGetStatsRequestBuilder() =
        member _.Yield(_: unit) : SlmGetStatsRequest =
            {
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SlmGetStatsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmGetStatsRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let slmGetStatsRequest = SlmGetStatsRequestBuilder()

    module GetStats =
        let withMasterTimeout (value: Types.Duration) (req: SlmGetStatsRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: SlmGetStatsRequest) =
            { req with Timeout = Some value }

    type SlmGetStatusRequest = {
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: SlmGetStatusRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type SlmGetStatusResponse = System.Text.Json.JsonElement

    type SlmGetStatusRequestBuilder() =
        member _.Yield(_: unit) : SlmGetStatusRequest =
            {
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SlmGetStatusRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmGetStatusRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let slmGetStatusRequest = SlmGetStatusRequestBuilder()

    module GetStatus =
        let withMasterTimeout (value: Types.Duration) (req: SlmGetStatusRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: SlmGetStatusRequest) =
            { req with Timeout = Some value }

    type SlmPutLifecycleRequest = {
        PolicyId: Types.Name
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("config")>]
        Config: Types.Configuration option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("repository")>]
        Repository: string option
        [<System.Text.Json.Serialization.JsonPropertyName("retention")>]
        Retention: Types.Retention option
        [<System.Text.Json.Serialization.JsonPropertyName("schedule")>]
        Schedule: Types.CronExpression option
    }

        with
        static member ToEndpoint(req: SlmPutLifecycleRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type SlmPutLifecycleResponse = Types.AcknowledgedResponseBase

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
        member _.PolicyId(state: SlmPutLifecycleRequest, value: Types.Name) =
            { state with PolicyId = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SlmPutLifecycleRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmPutLifecycleRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("config")>]
        member _.Config(state: SlmPutLifecycleRequest, value: Types.Configuration) =
            { state with Config = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: SlmPutLifecycleRequest, value: Types.Name) =
            { state with Name = Some value }

        [<CustomOperation("repository")>]
        member _.Repository(state: SlmPutLifecycleRequest, value: string) =
            { state with Repository = Some value }

        [<CustomOperation("retention")>]
        member _.Retention(state: SlmPutLifecycleRequest, value: Types.Retention) =
            { state with Retention = Some value }

        [<CustomOperation("schedule")>]
        member _.Schedule(state: SlmPutLifecycleRequest, value: Types.CronExpression) =
            { state with Schedule = Some value }

    let slmPutLifecycleRequest = SlmPutLifecycleRequestBuilder()

    module PutLifecycle =
        let withMasterTimeout (value: Types.Duration) (req: SlmPutLifecycleRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: SlmPutLifecycleRequest) =
            { req with Timeout = Some value }
        let withConfig (value: Types.Configuration) (req: SlmPutLifecycleRequest) =
            { req with Config = Some value }
        let withName (value: Types.Name) (req: SlmPutLifecycleRequest) =
            { req with Name = Some value }
        let withRepository (value: string) (req: SlmPutLifecycleRequest) =
            { req with Repository = Some value }
        let withRetention (value: Types.Retention) (req: SlmPutLifecycleRequest) =
            { req with Retention = Some value }
        let withSchedule (value: Types.CronExpression) (req: SlmPutLifecycleRequest) =
            { req with Schedule = Some value }

    type SlmStartRequest = {
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: SlmStartRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            endpoint, ValueNone

    type SlmStartResponse = Types.AcknowledgedResponseBase

    type SlmStartRequestBuilder() =
        member _.Yield(_: unit) : SlmStartRequest =
            {
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SlmStartRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmStartRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let slmStartRequest = SlmStartRequestBuilder()

    module Start =
        let withMasterTimeout (value: Types.Duration) (req: SlmStartRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: SlmStartRequest) =
            { req with Timeout = Some value }

    type SlmStopRequest = {
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: SlmStopRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            endpoint, ValueNone

    type SlmStopResponse = Types.AcknowledgedResponseBase

    type SlmStopRequestBuilder() =
        member _.Yield(_: unit) : SlmStopRequest =
            {
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SlmStopRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmStopRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let slmStopRequest = SlmStopRequestBuilder()

    module Stop =
        let withMasterTimeout (value: Types.Duration) (req: SlmStopRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: SlmStopRequest) =
            { req with Timeout = Some value }


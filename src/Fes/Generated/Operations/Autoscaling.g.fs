// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module AutoscalingOperations =

    type AutoscalingDeleteAutoscalingPolicyRequest = {
        Name: CoreTypes.Name
        MasterTimeout: CoreTypes.Duration option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: AutoscalingDeleteAutoscalingPolicyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_autoscaling/policy/{req.Name}"
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

    type AutoscalingDeleteAutoscalingPolicyResponse = CoreTypes.AcknowledgedResponseBase

    type AutoscalingDeleteAutoscalingPolicyRequestBuilder() =
        member _.Yield(_: unit) : AutoscalingDeleteAutoscalingPolicyRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: AutoscalingDeleteAutoscalingPolicyRequest, value: CoreTypes.Name) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: AutoscalingDeleteAutoscalingPolicyRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: AutoscalingDeleteAutoscalingPolicyRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let autoscalingDeleteAutoscalingPolicyRequest = AutoscalingDeleteAutoscalingPolicyRequestBuilder()

    module DeleteAutoscalingPolicy =
        let withMasterTimeout (value: CoreTypes.Duration) (req: AutoscalingDeleteAutoscalingPolicyRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: AutoscalingDeleteAutoscalingPolicyRequest) =
            { req with Timeout = Some value }

    type AutoscalingGetAutoscalingCapacityRequest = {
        MasterTimeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: AutoscalingGetAutoscalingCapacityRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_autoscaling/capacity"
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

    type AutoscalingGetAutoscalingCapacityResponse = System.Text.Json.JsonElement

    type AutoscalingGetAutoscalingCapacityRequestBuilder() =
        member _.Yield(_: unit) : AutoscalingGetAutoscalingCapacityRequest =
            {
                MasterTimeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: AutoscalingGetAutoscalingCapacityRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

    let autoscalingGetAutoscalingCapacityRequest = AutoscalingGetAutoscalingCapacityRequestBuilder()

    module GetAutoscalingCapacity =
        let withMasterTimeout (value: CoreTypes.Duration) (req: AutoscalingGetAutoscalingCapacityRequest) =
            { req with MasterTimeout = Some value }

    type AutoscalingGetAutoscalingPolicyRequest = {
        Name: CoreTypes.Name
        MasterTimeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: AutoscalingGetAutoscalingPolicyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_autoscaling/policy/{req.Name}"
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

    type AutoscalingGetAutoscalingPolicyResponse = AutoscalingTypes.AutoscalingPolicy

    type AutoscalingGetAutoscalingPolicyRequestBuilder() =
        member _.Yield(_: unit) : AutoscalingGetAutoscalingPolicyRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: AutoscalingGetAutoscalingPolicyRequest, value: CoreTypes.Name) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: AutoscalingGetAutoscalingPolicyRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

    let autoscalingGetAutoscalingPolicyRequest = AutoscalingGetAutoscalingPolicyRequestBuilder()

    module GetAutoscalingPolicy =
        let withMasterTimeout (value: CoreTypes.Duration) (req: AutoscalingGetAutoscalingPolicyRequest) =
            { req with MasterTimeout = Some value }

    type AutoscalingPutAutoscalingPolicyRequest = {
        Name: CoreTypes.Name
        MasterTimeout: CoreTypes.Duration option
        Timeout: CoreTypes.Duration option
        Document: obj
    }

        with
        static member ToRequest(req: AutoscalingPutAutoscalingPolicyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_autoscaling/policy/{req.Name}"
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
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type AutoscalingPutAutoscalingPolicyResponse = CoreTypes.AcknowledgedResponseBase

    type AutoscalingPutAutoscalingPolicyRequestBuilder() =
        member _.Yield(_: unit) : AutoscalingPutAutoscalingPolicyRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("name")>]
        member _.Name(state: AutoscalingPutAutoscalingPolicyRequest, value: CoreTypes.Name) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: AutoscalingPutAutoscalingPolicyRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: AutoscalingPutAutoscalingPolicyRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: AutoscalingPutAutoscalingPolicyRequest, value) =
            { state with Document = value }

    let autoscalingPutAutoscalingPolicyRequest = AutoscalingPutAutoscalingPolicyRequestBuilder()

    module PutAutoscalingPolicy =
        let withMasterTimeout (value: CoreTypes.Duration) (req: AutoscalingPutAutoscalingPolicyRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: AutoscalingPutAutoscalingPolicyRequest) =
            { req with Timeout = Some value }


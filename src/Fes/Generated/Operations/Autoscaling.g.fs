// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module AutoscalingOperations =

    type AutoscalingDeleteAutoscalingPolicyRequest = {
        Name: Types.Name
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
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

    type AutoscalingDeleteAutoscalingPolicyResponse = Types.AcknowledgedResponseBase

    type AutoscalingDeleteAutoscalingPolicyRequestBuilder() =
        member _.Yield(_: unit) : AutoscalingDeleteAutoscalingPolicyRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: AutoscalingDeleteAutoscalingPolicyRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: AutoscalingDeleteAutoscalingPolicyRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: AutoscalingDeleteAutoscalingPolicyRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let autoscalingDeleteAutoscalingPolicyRequest = AutoscalingDeleteAutoscalingPolicyRequestBuilder()

    module DeleteAutoscalingPolicy =
        let withMasterTimeout (value: Types.Duration) (req: AutoscalingDeleteAutoscalingPolicyRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: AutoscalingDeleteAutoscalingPolicyRequest) =
            { req with Timeout = Some value }

    type AutoscalingGetAutoscalingCapacityRequest = {
        MasterTimeout: Types.Duration option
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
        member _.MasterTimeout(state: AutoscalingGetAutoscalingCapacityRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let autoscalingGetAutoscalingCapacityRequest = AutoscalingGetAutoscalingCapacityRequestBuilder()

    module GetAutoscalingCapacity =
        let withMasterTimeout (value: Types.Duration) (req: AutoscalingGetAutoscalingCapacityRequest) =
            { req with MasterTimeout = Some value }

    type AutoscalingGetAutoscalingPolicyRequest = {
        Name: Types.Name
        MasterTimeout: Types.Duration option
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
        member _.Name(state: AutoscalingGetAutoscalingPolicyRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: AutoscalingGetAutoscalingPolicyRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let autoscalingGetAutoscalingPolicyRequest = AutoscalingGetAutoscalingPolicyRequestBuilder()

    module GetAutoscalingPolicy =
        let withMasterTimeout (value: Types.Duration) (req: AutoscalingGetAutoscalingPolicyRequest) =
            { req with MasterTimeout = Some value }

    type AutoscalingPutAutoscalingPolicyRequest = {
        Name: Types.Name
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
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

    type AutoscalingPutAutoscalingPolicyResponse = Types.AcknowledgedResponseBase

    type AutoscalingPutAutoscalingPolicyRequestBuilder() =
        member _.Yield(_: unit) : AutoscalingPutAutoscalingPolicyRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("name")>]
        member _.Name(state: AutoscalingPutAutoscalingPolicyRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: AutoscalingPutAutoscalingPolicyRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: AutoscalingPutAutoscalingPolicyRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: AutoscalingPutAutoscalingPolicyRequest, value) =
            { state with Document = value }

    let autoscalingPutAutoscalingPolicyRequest = AutoscalingPutAutoscalingPolicyRequestBuilder()

    module PutAutoscalingPolicy =
        let withMasterTimeout (value: Types.Duration) (req: AutoscalingPutAutoscalingPolicyRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: AutoscalingPutAutoscalingPolicyRequest) =
            { req with Timeout = Some value }


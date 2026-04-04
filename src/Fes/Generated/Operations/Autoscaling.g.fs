// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module AutoscalingOperations =

    type AutoscalingDeleteAutoscalingPolicyRequest = {
        Name: Types.Name
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: AutoscalingDeleteAutoscalingPolicyRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_autoscaling/policy/{Fes.Http.toPathSegment req.Name}"
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
        static member ToEndpoint(req: AutoscalingGetAutoscalingCapacityRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_autoscaling/capacity"
            let queryParams =
                [
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

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
        static member ToEndpoint(req: AutoscalingGetAutoscalingPolicyRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_autoscaling/policy/{Fes.Http.toPathSegment req.Name}"
            let queryParams =
                [
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type AutoscalingGetAutoscalingPolicyResponse = Types.AutoscalingPolicy

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
        Document: Types.AutoscalingPolicy
    }

        with
        static member ToEndpoint(req: AutoscalingPutAutoscalingPolicyRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_autoscaling/policy/{Fes.Http.toPathSegment req.Name}"
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
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req.Document)
            endpoint, ValueSome postData

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


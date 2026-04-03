// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module EnrichOperations =

    type EnrichDeletePolicyRequest = {
        Name: Types.Name
        MasterTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: EnrichDeletePolicyRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_enrich/policy/{Fes.Http.toPathSegment req.Name}"
            let queryParams =
                [
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type EnrichDeletePolicyResponse = Types.AcknowledgedResponseBase

    type EnrichDeletePolicyRequestBuilder() =
        member _.Yield(_: unit) : EnrichDeletePolicyRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: EnrichDeletePolicyRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: EnrichDeletePolicyRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let enrichDeletePolicyRequest = EnrichDeletePolicyRequestBuilder()

    module DeletePolicy =
        let withMasterTimeout (value: Types.Duration) (req: EnrichDeletePolicyRequest) =
            { req with MasterTimeout = Some value }

    type EnrichExecutePolicyRequest = {
        Name: Types.Name
        MasterTimeout: Types.Duration option
        WaitForCompletion: bool option
    }

        with
        static member ToEndpoint(req: EnrichExecutePolicyRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_enrich/policy/{Fes.Http.toPathSegment req.Name}/_execute"
            let queryParams =
                [
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            endpoint, ValueNone

    type EnrichExecutePolicyResponse = System.Text.Json.JsonElement

    type EnrichExecutePolicyRequestBuilder() =
        member _.Yield(_: unit) : EnrichExecutePolicyRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
                WaitForCompletion = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: EnrichExecutePolicyRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: EnrichExecutePolicyRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: EnrichExecutePolicyRequest, value: bool) =
            { state with WaitForCompletion = Some value }

    let enrichExecutePolicyRequest = EnrichExecutePolicyRequestBuilder()

    module ExecutePolicy =
        let withMasterTimeout (value: Types.Duration) (req: EnrichExecutePolicyRequest) =
            { req with MasterTimeout = Some value }
        let withWaitForCompletion (value: bool) (req: EnrichExecutePolicyRequest) =
            { req with WaitForCompletion = Some value }

    type EnrichGetPolicyRequest = {
        Name: Types.Names
        MasterTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: EnrichGetPolicyRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_enrich/policy/{Fes.Http.toPathSegment req.Name}"
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

    type EnrichGetPolicyResponse = System.Text.Json.JsonElement

    type EnrichGetPolicyRequestBuilder() =
        member _.Yield(_: unit) : EnrichGetPolicyRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: EnrichGetPolicyRequest, value: Types.Names) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: EnrichGetPolicyRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let enrichGetPolicyRequest = EnrichGetPolicyRequestBuilder()

    module GetPolicy =
        let withMasterTimeout (value: Types.Duration) (req: EnrichGetPolicyRequest) =
            { req with MasterTimeout = Some value }

    type EnrichPutPolicyRequest = {
        Name: Types.Name
        MasterTimeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("geo_match")>]
        GeoMatch: Types.EnrichTypesPolicy option
        [<System.Text.Json.Serialization.JsonPropertyName("match")>]
        Match: Types.EnrichTypesPolicy option
        [<System.Text.Json.Serialization.JsonPropertyName("range")>]
        Range: Types.EnrichTypesPolicy option
    }

        with
        static member ToEndpoint(req: EnrichPutPolicyRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_enrich/policy/{Fes.Http.toPathSegment req.Name}"
            let queryParams =
                [
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type EnrichPutPolicyResponse = Types.AcknowledgedResponseBase

    type EnrichPutPolicyRequestBuilder() =
        member _.Yield(_: unit) : EnrichPutPolicyRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
                GeoMatch = None
                Match = None
                Range = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: EnrichPutPolicyRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: EnrichPutPolicyRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("geoMatch")>]
        member _.GeoMatch(state: EnrichPutPolicyRequest, value: Types.EnrichTypesPolicy) =
            { state with GeoMatch = Some value }

        [<CustomOperation("match'")>]
        member _.Match(state: EnrichPutPolicyRequest, value: Types.EnrichTypesPolicy) =
            { state with Match = Some value }

        [<CustomOperation("range")>]
        member _.Range(state: EnrichPutPolicyRequest, value: Types.EnrichTypesPolicy) =
            { state with Range = Some value }

    let enrichPutPolicyRequest = EnrichPutPolicyRequestBuilder()

    module PutPolicy =
        let withMasterTimeout (value: Types.Duration) (req: EnrichPutPolicyRequest) =
            { req with MasterTimeout = Some value }
        let withGeoMatch (value: Types.EnrichTypesPolicy) (req: EnrichPutPolicyRequest) =
            { req with GeoMatch = Some value }
        let withMatch (value: Types.EnrichTypesPolicy) (req: EnrichPutPolicyRequest) =
            { req with Match = Some value }
        let withRange (value: Types.EnrichTypesPolicy) (req: EnrichPutPolicyRequest) =
            { req with Range = Some value }

    type EnrichStatsRequest = {
        MasterTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: EnrichStatsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_enrich/_stats"
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

    type EnrichStatsResponse = System.Text.Json.JsonElement

    type EnrichStatsRequestBuilder() =
        member _.Yield(_: unit) : EnrichStatsRequest =
            {
                MasterTimeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: EnrichStatsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let enrichStatsRequest = EnrichStatsRequestBuilder()

    module Stats =
        let withMasterTimeout (value: Types.Duration) (req: EnrichStatsRequest) =
            { req with MasterTimeout = Some value }


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module FeaturesOperations =

    type FeaturesGetFeaturesRequest = {
        MasterTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: FeaturesGetFeaturesRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_features"
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

    type FeaturesGetFeaturesResponse = System.Text.Json.JsonElement

    type FeaturesGetFeaturesRequestBuilder() =
        member _.Yield(_: unit) : FeaturesGetFeaturesRequest =
            {
                MasterTimeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: FeaturesGetFeaturesRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let featuresGetFeaturesRequest = FeaturesGetFeaturesRequestBuilder()

    module GetFeatures =
        let withMasterTimeout (value: Types.Duration) (req: FeaturesGetFeaturesRequest) =
            { req with MasterTimeout = Some value }

    type FeaturesResetFeaturesRequest = {
        MasterTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: FeaturesResetFeaturesRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_features/_reset"
            let queryParams =
                [
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            endpoint, ValueNone

    type FeaturesResetFeaturesResponse = System.Text.Json.JsonElement

    type FeaturesResetFeaturesRequestBuilder() =
        member _.Yield(_: unit) : FeaturesResetFeaturesRequest =
            {
                MasterTimeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: FeaturesResetFeaturesRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let featuresResetFeaturesRequest = FeaturesResetFeaturesRequestBuilder()

    module ResetFeatures =
        let withMasterTimeout (value: Types.Duration) (req: FeaturesResetFeaturesRequest) =
            { req with MasterTimeout = Some value }


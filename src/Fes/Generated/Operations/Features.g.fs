// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module FeaturesOperations =

    type FeaturesGetFeaturesRequest = {
        MasterTimeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: FeaturesGetFeaturesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_features"
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

    type FeaturesGetFeaturesResponse = System.Text.Json.JsonElement

    type FeaturesGetFeaturesRequestBuilder() =
        member _.Yield(_: unit) : FeaturesGetFeaturesRequest =
            {
                MasterTimeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: FeaturesGetFeaturesRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

    let featuresGetFeaturesRequest = FeaturesGetFeaturesRequestBuilder()

    module GetFeatures =
        let withMasterTimeout (value: CoreTypes.Duration) (req: FeaturesGetFeaturesRequest) =
            { req with MasterTimeout = Some value }

    type FeaturesResetFeaturesRequest = {
        MasterTimeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: FeaturesResetFeaturesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_features/_reset"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type FeaturesResetFeaturesResponse = System.Text.Json.JsonElement

    type FeaturesResetFeaturesRequestBuilder() =
        member _.Yield(_: unit) : FeaturesResetFeaturesRequest =
            {
                MasterTimeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: FeaturesResetFeaturesRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

    let featuresResetFeaturesRequest = FeaturesResetFeaturesRequestBuilder()

    module ResetFeatures =
        let withMasterTimeout (value: CoreTypes.Duration) (req: FeaturesResetFeaturesRequest) =
            { req with MasterTimeout = Some value }


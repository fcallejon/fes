// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module FeaturesOperations =

    type FeaturesGetFeaturesRequest = {
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: FeaturesGetFeaturesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_features"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module FeaturesGetFeaturesRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: FeaturesGetFeaturesRequest) : Result<Fes.Http.RequestMsg, exn> =
            FeaturesGetFeaturesRequest.ToRequest request

    type FeaturesGetFeaturesRequestBuilder() =
        member _.Yield(_: unit) : FeaturesGetFeaturesRequest =
            {
                FeaturesGetFeaturesRequest.MasterTimeout = Option.None
            } : FeaturesGetFeaturesRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: FeaturesGetFeaturesRequest, value: Duration) =
            { state with FeaturesGetFeaturesRequest.MasterTimeout = Option.Some value } : FeaturesGetFeaturesRequest

    let featuresGetFeaturesRequest = FeaturesGetFeaturesRequestBuilder()

    type FeaturesGetFeaturesResponse = {
        [<JsonPropertyName("features")>]
        Features: TypesFeature array
    }

    type FeaturesResetFeaturesRequest = {
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: FeaturesResetFeaturesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_features/_reset"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module FeaturesResetFeaturesRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: FeaturesResetFeaturesRequest) : Result<Fes.Http.RequestMsg, exn> =
            FeaturesResetFeaturesRequest.ToRequest request

    type FeaturesResetFeaturesRequestBuilder() =
        member _.Yield(_: unit) : FeaturesResetFeaturesRequest =
            {
                FeaturesResetFeaturesRequest.MasterTimeout = Option.None
            } : FeaturesResetFeaturesRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: FeaturesResetFeaturesRequest, value: Duration) =
            { state with FeaturesResetFeaturesRequest.MasterTimeout = Option.Some value } : FeaturesResetFeaturesRequest

    let featuresResetFeaturesRequest = FeaturesResetFeaturesRequestBuilder()

    type FeaturesResetFeaturesResponse = {
        [<JsonPropertyName("features")>]
        Features: TypesFeature array
    }


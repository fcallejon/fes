// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module XpackOperations =

    type XpackInfoRequest = {
        Categories: XpackInfo.XPackCategory list option
        AcceptEnterprise: bool option
        Human: bool option
    }

        with
        static member ToRequest(req: XpackInfoRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_xpack"
                let queryParams =
                    [
                        req.Categories |> Option.map (fun v -> "categories", Fes.Http.toQueryValue v)
                        req.AcceptEnterprise |> Option.map (fun v -> "accept_enterprise", Fes.Http.toQueryValue v)
                        req.Human |> Option.map (fun v -> "human", Fes.Http.toQueryValue v)
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

    type XpackInfoResponse = System.Text.Json.JsonElement

    type XpackInfoRequestBuilder() =
        member _.Yield(_: unit) : XpackInfoRequest =
            {
                Categories = None
                AcceptEnterprise = None
                Human = None
            }

        [<CustomOperation("categories")>]
        member _.Categories(state: XpackInfoRequest, value: XpackInfo.XPackCategory list) =
            { state with Categories = Some value }

        [<CustomOperation("acceptEnterprise")>]
        member _.AcceptEnterprise(state: XpackInfoRequest, value: bool) =
            { state with AcceptEnterprise = Some value }

        [<CustomOperation("human")>]
        member _.Human(state: XpackInfoRequest, value: bool) =
            { state with Human = Some value }

    let xpackInfoRequest = XpackInfoRequestBuilder()

    module Info =
        let withCategories (value: XpackInfo.XPackCategory list) (req: XpackInfoRequest) =
            { req with Categories = Some value }
        let withAcceptEnterprise (value: bool) (req: XpackInfoRequest) =
            { req with AcceptEnterprise = Some value }
        let withHuman (value: bool) (req: XpackInfoRequest) =
            { req with Human = Some value }

    type XpackUsageRequest = {
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: XpackUsageRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_xpack/usage"
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

    type XpackUsageResponse = System.Text.Json.JsonElement

    type XpackUsageRequestBuilder() =
        member _.Yield(_: unit) : XpackUsageRequest =
            {
                MasterTimeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: XpackUsageRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let xpackUsageRequest = XpackUsageRequestBuilder()

    module Usage =
        let withMasterTimeout (value: Types.Duration) (req: XpackUsageRequest) =
            { req with MasterTimeout = Some value }


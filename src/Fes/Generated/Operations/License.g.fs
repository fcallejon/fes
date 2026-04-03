// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module LicenseOperations =

    type LicenseDeleteRequest = {
        MasterTimeout: CoreTypes.Duration option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: LicenseDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_license"
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

    type LicenseDeleteResponse = CoreTypes.AcknowledgedResponseBase

    type LicenseDeleteRequestBuilder() =
        member _.Yield(_: unit) : LicenseDeleteRequest =
            {
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: LicenseDeleteRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: LicenseDeleteRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let licenseDeleteRequest = LicenseDeleteRequestBuilder()

    module Delete =
        let withMasterTimeout (value: CoreTypes.Duration) (req: LicenseDeleteRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: LicenseDeleteRequest) =
            { req with Timeout = Some value }

    type LicenseGetRequest = {
        AcceptEnterprise: bool option
        Local: bool option
    }

        with
        static member ToRequest(req: LicenseGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_license"
                let queryParams =
                    [
                        req.AcceptEnterprise |> Option.map (fun v -> "accept_enterprise", Fes.Http.toQueryValue v)
                        req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
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

    type LicenseGetResponse = System.Text.Json.JsonElement

    type LicenseGetRequestBuilder() =
        member _.Yield(_: unit) : LicenseGetRequest =
            {
                AcceptEnterprise = None
                Local = None
            }

        [<CustomOperation("acceptEnterprise")>]
        member _.AcceptEnterprise(state: LicenseGetRequest, value: bool) =
            { state with AcceptEnterprise = Some value }

        [<CustomOperation("local")>]
        member _.Local(state: LicenseGetRequest, value: bool) =
            { state with Local = Some value }

    let licenseGetRequest = LicenseGetRequestBuilder()

    module Get =
        let withAcceptEnterprise (value: bool) (req: LicenseGetRequest) =
            { req with AcceptEnterprise = Some value }
        let withLocal (value: bool) (req: LicenseGetRequest) =
            { req with Local = Some value }

    type LicenseGetBasicStatusRequest = | LicenseGetBasicStatusRequest

        with
        static member ToRequest(req: LicenseGetBasicStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_license/basic_status"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type LicenseGetBasicStatusResponse = System.Text.Json.JsonElement

    type LicenseGetBasicStatusRequestBuilder() =
        member _.Yield(_: unit) : LicenseGetBasicStatusRequest =
            {
            }

    let licenseGetBasicStatusRequest = LicenseGetBasicStatusRequestBuilder()

    type LicenseGetTrialStatusRequest = | LicenseGetTrialStatusRequest

        with
        static member ToRequest(req: LicenseGetTrialStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_license/trial_status"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type LicenseGetTrialStatusResponse = System.Text.Json.JsonElement

    type LicenseGetTrialStatusRequestBuilder() =
        member _.Yield(_: unit) : LicenseGetTrialStatusRequest =
            {
            }

    let licenseGetTrialStatusRequest = LicenseGetTrialStatusRequestBuilder()

    type LicensePostRequest = {
        Acknowledge: bool option
        MasterTimeout: CoreTypes.Duration option
        Timeout: CoreTypes.Duration option
        License: LicenseTypes.License option
        Licenses: LicenseTypes.License list option
    }

        with
        static member ToRequest(req: LicensePostRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_license"
                let queryParams =
                    [
                        req.Acknowledge |> Option.map (fun v -> "acknowledge", Fes.Http.toQueryValue v)
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
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type LicensePostResponse = System.Text.Json.JsonElement

    type LicensePostRequestBuilder() =
        member _.Yield(_: unit) : LicensePostRequest =
            {
                Acknowledge = None
                MasterTimeout = None
                Timeout = None
                License = None
                Licenses = None
            }

        [<CustomOperation("acknowledge")>]
        member _.Acknowledge(state: LicensePostRequest, value: bool) =
            { state with Acknowledge = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: LicensePostRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: LicensePostRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("license")>]
        member _.License(state: LicensePostRequest, value: LicenseTypes.License) =
            { state with License = Some value }

        [<CustomOperation("licenses")>]
        member _.Licenses(state: LicensePostRequest, value: LicenseTypes.License list) =
            { state with Licenses = Some value }

    let licensePostRequest = LicensePostRequestBuilder()

    module Post =
        let withAcknowledge (value: bool) (req: LicensePostRequest) =
            { req with Acknowledge = Some value }
        let withMasterTimeout (value: CoreTypes.Duration) (req: LicensePostRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: LicensePostRequest) =
            { req with Timeout = Some value }
        let withLicense (value: LicenseTypes.License) (req: LicensePostRequest) =
            { req with License = Some value }
        let withLicenses (value: LicenseTypes.License list) (req: LicensePostRequest) =
            { req with Licenses = Some value }

    type LicensePostStartBasicRequest = {
        Acknowledge: bool option
        MasterTimeout: CoreTypes.Duration option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: LicensePostStartBasicRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_license/start_basic"
                let queryParams =
                    [
                        req.Acknowledge |> Option.map (fun v -> "acknowledge", Fes.Http.toQueryValue v)
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

    type LicensePostStartBasicResponse = System.Text.Json.JsonElement

    type LicensePostStartBasicRequestBuilder() =
        member _.Yield(_: unit) : LicensePostStartBasicRequest =
            {
                Acknowledge = None
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("acknowledge")>]
        member _.Acknowledge(state: LicensePostStartBasicRequest, value: bool) =
            { state with Acknowledge = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: LicensePostStartBasicRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: LicensePostStartBasicRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let licensePostStartBasicRequest = LicensePostStartBasicRequestBuilder()

    module PostStartBasic =
        let withAcknowledge (value: bool) (req: LicensePostStartBasicRequest) =
            { req with Acknowledge = Some value }
        let withMasterTimeout (value: CoreTypes.Duration) (req: LicensePostStartBasicRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: LicensePostStartBasicRequest) =
            { req with Timeout = Some value }

    type LicensePostStartTrialRequest = {
        Acknowledge: bool option
        Type: string option
        MasterTimeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: LicensePostStartTrialRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_license/start_trial"
                let queryParams =
                    [
                        req.Acknowledge |> Option.map (fun v -> "acknowledge", Fes.Http.toQueryValue v)
                        req.Type |> Option.map (fun v -> "type", Fes.Http.toQueryValue v)
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

    type LicensePostStartTrialResponse = System.Text.Json.JsonElement

    type LicensePostStartTrialRequestBuilder() =
        member _.Yield(_: unit) : LicensePostStartTrialRequest =
            {
                Acknowledge = None
                Type = None
                MasterTimeout = None
            }

        [<CustomOperation("acknowledge")>]
        member _.Acknowledge(state: LicensePostStartTrialRequest, value: bool) =
            { state with Acknowledge = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: LicensePostStartTrialRequest, value: string) =
            { state with Type = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: LicensePostStartTrialRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

    let licensePostStartTrialRequest = LicensePostStartTrialRequestBuilder()

    module PostStartTrial =
        let withAcknowledge (value: bool) (req: LicensePostStartTrialRequest) =
            { req with Acknowledge = Some value }
        let withType (value: string) (req: LicensePostStartTrialRequest) =
            { req with Type = Some value }
        let withMasterTimeout (value: CoreTypes.Duration) (req: LicensePostStartTrialRequest) =
            { req with MasterTimeout = Some value }


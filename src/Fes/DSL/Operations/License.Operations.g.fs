// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module LicenseOperations =

    type LicenseGetRequest = {
        AcceptEnterprise: bool option
        Local: bool option
    } with
        static member ToRequest(request: LicenseGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_license"
                let queryParams =
                    [
                        request.AcceptEnterprise |> Option.map (fun v -> "accept_enterprise", Fes.Http.toQueryValue v)
                        request.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
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

    module LicenseGetRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: LicenseGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            LicenseGetRequest.ToRequest request

    type LicenseGetRequestBuilder() =
        member _.Yield(_: unit) : LicenseGetRequest =
            {
                LicenseGetRequest.AcceptEnterprise = Option.None
                LicenseGetRequest.Local = Option.None
            } : LicenseGetRequest

        [<CustomOperation("accept_enterprise")>]
        member _.AcceptEnterprise(state: LicenseGetRequest, value: bool) =
            { state with LicenseGetRequest.AcceptEnterprise = Option.Some value } : LicenseGetRequest

        [<CustomOperation("local")>]
        member _.Local(state: LicenseGetRequest, value: bool) =
            { state with LicenseGetRequest.Local = Option.Some value } : LicenseGetRequest

    let licenseGetRequest = LicenseGetRequestBuilder()

    type LicenseGetResponse = {
        [<JsonPropertyName("license")>]
        License: GetLicenseInformation
    }

    type LicensePostRequest = {
        Acknowledge: bool option
        MasterTimeout: Duration option
        Timeout: Duration option
        [<JsonPropertyName("license")>]
        License: TypesLicense option
        [<JsonPropertyName("licenses")>]
        Licenses: TypesLicense array option
    } with
        static member ToRequest(request: LicensePostRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_license"
                let queryParams =
                    [
                        request.Acknowledge |> Option.map (fun v -> "acknowledge", Fes.Http.toQueryValue v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``license`` = request.License; ``licenses`` = request.Licenses |}
                |> Result.Ok
            with ex -> Result.Error ex

    module LicensePostRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: LicensePostRequest) : Result<Fes.Http.RequestMsg, exn> =
            LicensePostRequest.ToRequest request

    type LicensePostRequestBuilder() =
        member _.Yield(_: unit) : LicensePostRequest =
            {
                LicensePostRequest.Acknowledge = Option.None
                LicensePostRequest.MasterTimeout = Option.None
                LicensePostRequest.Timeout = Option.None
                LicensePostRequest.License = Option.None
                LicensePostRequest.Licenses = Option.None
            } : LicensePostRequest

        [<CustomOperation("acknowledge")>]
        member _.Acknowledge(state: LicensePostRequest, value: bool) =
            { state with LicensePostRequest.Acknowledge = Option.Some value } : LicensePostRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: LicensePostRequest, value: Duration) =
            { state with LicensePostRequest.MasterTimeout = Option.Some value } : LicensePostRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: LicensePostRequest, value: Duration) =
            { state with LicensePostRequest.Timeout = Option.Some value } : LicensePostRequest

        [<CustomOperation("license")>]
        member _.License(state: LicensePostRequest, value: TypesLicense) =
            { state with LicensePostRequest.License = Option.Some value } : LicensePostRequest

        [<CustomOperation("licenses")>]
        member _.Licenses(state: LicensePostRequest, value: TypesLicense array) =
            { state with LicensePostRequest.Licenses = Option.Some value } : LicensePostRequest

    let licensePostRequest = LicensePostRequestBuilder()

    type LicenseDeleteRequest = {
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: LicenseDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_license"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module LicenseDeleteRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: LicenseDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            LicenseDeleteRequest.ToRequest request

    type LicenseDeleteRequestBuilder() =
        member _.Yield(_: unit) : LicenseDeleteRequest =
            {
                LicenseDeleteRequest.MasterTimeout = Option.None
                LicenseDeleteRequest.Timeout = Option.None
            } : LicenseDeleteRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: LicenseDeleteRequest, value: Duration) =
            { state with LicenseDeleteRequest.MasterTimeout = Option.Some value } : LicenseDeleteRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: LicenseDeleteRequest, value: Duration) =
            { state with LicenseDeleteRequest.Timeout = Option.Some value } : LicenseDeleteRequest

    let licenseDeleteRequest = LicenseDeleteRequestBuilder()

    type LicenseDeleteResponse = AcknowledgedResponseBase

    type LicenseGetBasicStatusRequest = unit

    let licenseGetBasicStatusRequest = ()

    type LicenseGetBasicStatusResponse = {
        [<JsonPropertyName("eligible_to_start_basic")>]
        EligibleToStartBasic: bool
    }

    type LicenseGetTrialStatusRequest = unit

    let licenseGetTrialStatusRequest = ()

    type LicenseGetTrialStatusResponse = {
        [<JsonPropertyName("eligible_to_start_trial")>]
        EligibleToStartTrial: bool
    }

    type LicensePostStartBasicRequest = {
        Acknowledge: bool option
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: LicensePostStartBasicRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_license/start_basic"
                let queryParams =
                    [
                        request.Acknowledge |> Option.map (fun v -> "acknowledge", Fes.Http.toQueryValue v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
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

    module LicensePostStartBasicRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: LicensePostStartBasicRequest) : Result<Fes.Http.RequestMsg, exn> =
            LicensePostStartBasicRequest.ToRequest request

    type LicensePostStartBasicRequestBuilder() =
        member _.Yield(_: unit) : LicensePostStartBasicRequest =
            {
                LicensePostStartBasicRequest.Acknowledge = Option.None
                LicensePostStartBasicRequest.MasterTimeout = Option.None
                LicensePostStartBasicRequest.Timeout = Option.None
            } : LicensePostStartBasicRequest

        [<CustomOperation("acknowledge")>]
        member _.Acknowledge(state: LicensePostStartBasicRequest, value: bool) =
            { state with LicensePostStartBasicRequest.Acknowledge = Option.Some value } : LicensePostStartBasicRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: LicensePostStartBasicRequest, value: Duration) =
            { state with LicensePostStartBasicRequest.MasterTimeout = Option.Some value } : LicensePostStartBasicRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: LicensePostStartBasicRequest, value: Duration) =
            { state with LicensePostStartBasicRequest.Timeout = Option.Some value } : LicensePostStartBasicRequest

    let licensePostStartBasicRequest = LicensePostStartBasicRequestBuilder()

    type LicensePostStartBasicResponse = {
        [<JsonPropertyName("acknowledged")>]
        Acknowledged: bool
        [<JsonPropertyName("basic_was_started")>]
        BasicWasStarted: bool
        [<JsonPropertyName("error_message")>]
        ErrorMessage: string option
        [<JsonPropertyName("type")>]
        Type: TypesLicenseType option
        [<JsonPropertyName("acknowledge")>]
        Acknowledge: Map<string, System.Text.Json.JsonElement> option
    }

    type LicensePostStartTrialRequest = {
        Acknowledge: bool option
        Type: string option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: LicensePostStartTrialRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_license/start_trial"
                let queryParams =
                    [
                        request.Acknowledge |> Option.map (fun v -> "acknowledge", Fes.Http.toQueryValue v)
                        request.Type |> Option.map (fun v -> "type", Fes.Http.toQueryValue v)
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

    module LicensePostStartTrialRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: LicensePostStartTrialRequest) : Result<Fes.Http.RequestMsg, exn> =
            LicensePostStartTrialRequest.ToRequest request

    type LicensePostStartTrialRequestBuilder() =
        member _.Yield(_: unit) : LicensePostStartTrialRequest =
            {
                LicensePostStartTrialRequest.Acknowledge = Option.None
                LicensePostStartTrialRequest.Type = Option.None
                LicensePostStartTrialRequest.MasterTimeout = Option.None
            } : LicensePostStartTrialRequest

        [<CustomOperation("acknowledge")>]
        member _.Acknowledge(state: LicensePostStartTrialRequest, value: bool) =
            { state with LicensePostStartTrialRequest.Acknowledge = Option.Some value } : LicensePostStartTrialRequest

        [<CustomOperation("type")>]
        member _.Type(state: LicensePostStartTrialRequest, value: string) =
            { state with LicensePostStartTrialRequest.Type = Option.Some value } : LicensePostStartTrialRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: LicensePostStartTrialRequest, value: Duration) =
            { state with LicensePostStartTrialRequest.MasterTimeout = Option.Some value } : LicensePostStartTrialRequest

    let licensePostStartTrialRequest = LicensePostStartTrialRequestBuilder()

    type LicensePostStartTrialResponse = {
        [<JsonPropertyName("acknowledged")>]
        Acknowledged: bool
        [<JsonPropertyName("error_message")>]
        ErrorMessage: string option
        [<JsonPropertyName("trial_was_started")>]
        TrialWasStarted: bool
        [<JsonPropertyName("type")>]
        Type: TypesLicenseType option
    }


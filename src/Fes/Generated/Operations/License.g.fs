// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module LicenseOperations =

    type LicenseDeleteRequest = {
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: LicenseDeleteRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type LicenseDeleteResponse = Types.AcknowledgedResponseBase

    type LicenseDeleteRequestBuilder() =
        member _.Yield(_: unit) : LicenseDeleteRequest =
            {
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: LicenseDeleteRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: LicenseDeleteRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let licenseDeleteRequest = LicenseDeleteRequestBuilder()

    module Delete =
        let withMasterTimeout (value: Types.Duration) (req: LicenseDeleteRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: LicenseDeleteRequest) =
            { req with Timeout = Some value }

    type LicenseGetRequest = {
        AcceptEnterprise: bool option
        Local: bool option
    }

        with
        static member ToEndpoint(req: LicenseGetRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

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
        static member ToEndpoint(req: LicenseGetBasicStatusRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_license/basic_status"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type LicenseGetBasicStatusResponse = System.Text.Json.JsonElement

    type LicenseGetTrialStatusRequest = | LicenseGetTrialStatusRequest

        with
        static member ToEndpoint(req: LicenseGetTrialStatusRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_license/trial_status"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type LicenseGetTrialStatusResponse = System.Text.Json.JsonElement

    type LicensePostRequest = {
        Acknowledge: bool option
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("license")>]
        License: Types.License option
        [<System.Text.Json.Serialization.JsonPropertyName("licenses")>]
        Licenses: Types.License list option
    }

        with
        static member ToEndpoint(req: LicensePostRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.MasterTimeout(state: LicensePostRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: LicensePostRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("license")>]
        member _.License(state: LicensePostRequest, value: Types.License) =
            { state with License = Some value }

        [<CustomOperation("licenses")>]
        member _.Licenses(state: LicensePostRequest, value: Types.License list) =
            { state with Licenses = Some value }

    let licensePostRequest = LicensePostRequestBuilder()

    module Post =
        let withAcknowledge (value: bool) (req: LicensePostRequest) =
            { req with Acknowledge = Some value }
        let withMasterTimeout (value: Types.Duration) (req: LicensePostRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: LicensePostRequest) =
            { req with Timeout = Some value }
        let withLicense (value: Types.License) (req: LicensePostRequest) =
            { req with License = Some value }
        let withLicenses (value: Types.License list) (req: LicensePostRequest) =
            { req with Licenses = Some value }

    type LicensePostStartBasicRequest = {
        Acknowledge: bool option
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: LicensePostStartBasicRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            endpoint, ValueNone

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
        member _.MasterTimeout(state: LicensePostStartBasicRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: LicensePostStartBasicRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let licensePostStartBasicRequest = LicensePostStartBasicRequestBuilder()

    module PostStartBasic =
        let withAcknowledge (value: bool) (req: LicensePostStartBasicRequest) =
            { req with Acknowledge = Some value }
        let withMasterTimeout (value: Types.Duration) (req: LicensePostStartBasicRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: LicensePostStartBasicRequest) =
            { req with Timeout = Some value }

    type LicensePostStartTrialRequest = {
        Acknowledge: bool option
        Type: string option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: LicensePostStartTrialRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            endpoint, ValueNone

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
        member _.MasterTimeout(state: LicensePostStartTrialRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let licensePostStartTrialRequest = LicensePostStartTrialRequestBuilder()

    module PostStartTrial =
        let withAcknowledge (value: bool) (req: LicensePostStartTrialRequest) =
            { req with Acknowledge = Some value }
        let withType (value: string) (req: LicensePostStartTrialRequest) =
            { req with Type = Some value }
        let withMasterTimeout (value: Types.Duration) (req: LicensePostStartTrialRequest) =
            { req with MasterTimeout = Some value }


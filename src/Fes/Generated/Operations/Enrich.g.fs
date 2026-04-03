// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module EnrichOperations =

    type EnrichDeletePolicyRequest = {
        Name: CoreTypes.Name
        MasterTimeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: EnrichDeletePolicyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_enrich/policy/{req.Name}"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type EnrichDeletePolicyResponse = CoreTypes.AcknowledgedResponseBase

    type EnrichDeletePolicyRequestBuilder() =
        member _.Yield(_: unit) : EnrichDeletePolicyRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: EnrichDeletePolicyRequest, value: CoreTypes.Name) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: EnrichDeletePolicyRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

    let enrichDeletePolicyRequest = EnrichDeletePolicyRequestBuilder()

    module DeletePolicy =
        let withMasterTimeout (value: CoreTypes.Duration) (req: EnrichDeletePolicyRequest) =
            { req with MasterTimeout = Some value }

    type EnrichExecutePolicyRequest = {
        Name: CoreTypes.Name
        MasterTimeout: CoreTypes.Duration option
        WaitForCompletion: bool option
    }

        with
        static member ToRequest(req: EnrichExecutePolicyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_enrich/policy/{req.Name}/_execute"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Result.Ok
            with ex -> Result.Error ex

    type EnrichExecutePolicyResponse = System.Text.Json.JsonElement

    type EnrichExecutePolicyRequestBuilder() =
        member _.Yield(_: unit) : EnrichExecutePolicyRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
                WaitForCompletion = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: EnrichExecutePolicyRequest, value: CoreTypes.Name) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: EnrichExecutePolicyRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: EnrichExecutePolicyRequest, value: bool) =
            { state with WaitForCompletion = Some value }

    let enrichExecutePolicyRequest = EnrichExecutePolicyRequestBuilder()

    module ExecutePolicy =
        let withMasterTimeout (value: CoreTypes.Duration) (req: EnrichExecutePolicyRequest) =
            { req with MasterTimeout = Some value }
        let withWaitForCompletion (value: bool) (req: EnrichExecutePolicyRequest) =
            { req with WaitForCompletion = Some value }

    type EnrichGetPolicyRequest = {
        Name: CoreTypes.Names
        MasterTimeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: EnrichGetPolicyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_enrich/policy/{req.Name}"
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

    type EnrichGetPolicyResponse = System.Text.Json.JsonElement

    type EnrichGetPolicyRequestBuilder() =
        member _.Yield(_: unit) : EnrichGetPolicyRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: EnrichGetPolicyRequest, value: CoreTypes.Names) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: EnrichGetPolicyRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

    let enrichGetPolicyRequest = EnrichGetPolicyRequestBuilder()

    module GetPolicy =
        let withMasterTimeout (value: CoreTypes.Duration) (req: EnrichGetPolicyRequest) =
            { req with MasterTimeout = Some value }

    type EnrichPutPolicyRequest = {
        Name: CoreTypes.Name
        MasterTimeout: CoreTypes.Duration option
        GeoMatch: EnrichTypes.Policy option
        Match: EnrichTypes.Policy option
        Range: EnrichTypes.Policy option
    }

        with
        static member ToRequest(req: EnrichPutPolicyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_enrich/policy/{req.Name}"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type EnrichPutPolicyResponse = CoreTypes.AcknowledgedResponseBase

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
        member _.Name(state: EnrichPutPolicyRequest, value: CoreTypes.Name) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: EnrichPutPolicyRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("geoMatch")>]
        member _.GeoMatch(state: EnrichPutPolicyRequest, value: EnrichTypes.Policy) =
            { state with GeoMatch = Some value }

        [<CustomOperation("match'")>]
        member _.Match(state: EnrichPutPolicyRequest, value: EnrichTypes.Policy) =
            { state with Match = Some value }

        [<CustomOperation("range")>]
        member _.Range(state: EnrichPutPolicyRequest, value: EnrichTypes.Policy) =
            { state with Range = Some value }

    let enrichPutPolicyRequest = EnrichPutPolicyRequestBuilder()

    module PutPolicy =
        let withMasterTimeout (value: CoreTypes.Duration) (req: EnrichPutPolicyRequest) =
            { req with MasterTimeout = Some value }
        let withGeoMatch (value: EnrichTypes.Policy) (req: EnrichPutPolicyRequest) =
            { req with GeoMatch = Some value }
        let withMatch (value: EnrichTypes.Policy) (req: EnrichPutPolicyRequest) =
            { req with Match = Some value }
        let withRange (value: EnrichTypes.Policy) (req: EnrichPutPolicyRequest) =
            { req with Range = Some value }

    type EnrichStatsRequest = {
        MasterTimeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: EnrichStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_enrich/_stats"
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

    type EnrichStatsResponse = System.Text.Json.JsonElement

    type EnrichStatsRequestBuilder() =
        member _.Yield(_: unit) : EnrichStatsRequest =
            {
                MasterTimeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: EnrichStatsRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

    let enrichStatsRequest = EnrichStatsRequestBuilder()

    module Stats =
        let withMasterTimeout (value: CoreTypes.Duration) (req: EnrichStatsRequest) =
            { req with MasterTimeout = Some value }


// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module EnrichOperations =

    type EnrichGetPolicyRequest = {
        Name: Names
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: EnrichGetPolicyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_enrich/policy/{request.Name}"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
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

    module EnrichGetPolicyRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: EnrichGetPolicyRequest) : Result<Fes.Http.RequestMsg, exn> =
            EnrichGetPolicyRequest.ToRequest request

    type EnrichGetPolicyRequestBuilder() =
        member _.Yield(_: unit) : EnrichGetPolicyRequest =
            {
                EnrichGetPolicyRequest.Name = Unchecked.defaultof<Names>
                EnrichGetPolicyRequest.MasterTimeout = Option.None
            } : EnrichGetPolicyRequest

        [<CustomOperation("name")>]
        member _.Name(state: EnrichGetPolicyRequest, value: Names) =
            { state with EnrichGetPolicyRequest.Name = value } : EnrichGetPolicyRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: EnrichGetPolicyRequest, value: Duration) =
            { state with EnrichGetPolicyRequest.MasterTimeout = Option.Some value } : EnrichGetPolicyRequest

    let enrichGetPolicyRequest = EnrichGetPolicyRequestBuilder()

    type EnrichPutPolicyRequest = {
        Name: Name
        MasterTimeout: Duration option
        [<JsonPropertyName("geo_match")>]
        GeoMatch: TypesPolicy option
        [<JsonPropertyName("match")>]
        Match: TypesPolicy option
        [<JsonPropertyName("range")>]
        Range: TypesPolicy option
    } with
        static member ToRequest(request: EnrichPutPolicyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_enrich/policy/{request.Name}"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module EnrichPutPolicyRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: EnrichPutPolicyRequest) : Result<Fes.Http.RequestMsg, exn> =
            EnrichPutPolicyRequest.ToRequest request

    type EnrichPutPolicyRequestBuilder() =
        member _.Yield(_: unit) : EnrichPutPolicyRequest =
            {
                EnrichPutPolicyRequest.Name = Unchecked.defaultof<Name>
                EnrichPutPolicyRequest.MasterTimeout = Option.None
                EnrichPutPolicyRequest.GeoMatch = Option.None
                EnrichPutPolicyRequest.Match = Option.None
                EnrichPutPolicyRequest.Range = Option.None
            } : EnrichPutPolicyRequest

        [<CustomOperation("name")>]
        member _.Name(state: EnrichPutPolicyRequest, value: Name) =
            { state with EnrichPutPolicyRequest.Name = value } : EnrichPutPolicyRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: EnrichPutPolicyRequest, value: Duration) =
            { state with EnrichPutPolicyRequest.MasterTimeout = Option.Some value } : EnrichPutPolicyRequest

        [<CustomOperation("geo_match")>]
        member _.GeoMatch(state: EnrichPutPolicyRequest, value: TypesPolicy) =
            { state with EnrichPutPolicyRequest.GeoMatch = Option.Some value } : EnrichPutPolicyRequest

        [<CustomOperation("match")>]
        member _.Match(state: EnrichPutPolicyRequest, value: TypesPolicy) =
            { state with EnrichPutPolicyRequest.Match = Option.Some value } : EnrichPutPolicyRequest

        [<CustomOperation("range")>]
        member _.Range(state: EnrichPutPolicyRequest, value: TypesPolicy) =
            { state with EnrichPutPolicyRequest.Range = Option.Some value } : EnrichPutPolicyRequest

    let enrichPutPolicyRequest = EnrichPutPolicyRequestBuilder()

    type EnrichPutPolicyResponse = AcknowledgedResponseBase

    type EnrichDeletePolicyRequest = {
        Name: Name
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: EnrichDeletePolicyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_enrich/policy/{request.Name}"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
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

    module EnrichDeletePolicyRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: EnrichDeletePolicyRequest) : Result<Fes.Http.RequestMsg, exn> =
            EnrichDeletePolicyRequest.ToRequest request

    type EnrichDeletePolicyRequestBuilder() =
        member _.Yield(_: unit) : EnrichDeletePolicyRequest =
            {
                EnrichDeletePolicyRequest.Name = Unchecked.defaultof<Name>
                EnrichDeletePolicyRequest.MasterTimeout = Option.None
            } : EnrichDeletePolicyRequest

        [<CustomOperation("name")>]
        member _.Name(state: EnrichDeletePolicyRequest, value: Name) =
            { state with EnrichDeletePolicyRequest.Name = value } : EnrichDeletePolicyRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: EnrichDeletePolicyRequest, value: Duration) =
            { state with EnrichDeletePolicyRequest.MasterTimeout = Option.Some value } : EnrichDeletePolicyRequest

    let enrichDeletePolicyRequest = EnrichDeletePolicyRequestBuilder()

    type EnrichDeletePolicyResponse = AcknowledgedResponseBase

    type EnrichExecutePolicyRequest = {
        Name: Name
        MasterTimeout: Duration option
        WaitForCompletion: bool option
    } with
        static member ToRequest(request: EnrichExecutePolicyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_enrich/policy/{request.Name}/_execute"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                        request.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Result.Ok
            with ex -> Result.Error ex

    module EnrichExecutePolicyRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: EnrichExecutePolicyRequest) : Result<Fes.Http.RequestMsg, exn> =
            EnrichExecutePolicyRequest.ToRequest request

    type EnrichExecutePolicyRequestBuilder() =
        member _.Yield(_: unit) : EnrichExecutePolicyRequest =
            {
                EnrichExecutePolicyRequest.Name = Unchecked.defaultof<Name>
                EnrichExecutePolicyRequest.MasterTimeout = Option.None
                EnrichExecutePolicyRequest.WaitForCompletion = Option.None
            } : EnrichExecutePolicyRequest

        [<CustomOperation("name")>]
        member _.Name(state: EnrichExecutePolicyRequest, value: Name) =
            { state with EnrichExecutePolicyRequest.Name = value } : EnrichExecutePolicyRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: EnrichExecutePolicyRequest, value: Duration) =
            { state with EnrichExecutePolicyRequest.MasterTimeout = Option.Some value } : EnrichExecutePolicyRequest

        [<CustomOperation("wait_for_completion")>]
        member _.WaitForCompletion(state: EnrichExecutePolicyRequest, value: bool) =
            { state with EnrichExecutePolicyRequest.WaitForCompletion = Option.Some value } : EnrichExecutePolicyRequest

    let enrichExecutePolicyRequest = EnrichExecutePolicyRequestBuilder()

    type EnrichExecutePolicyResponse = {
        [<JsonPropertyName("status")>]
        Status: ExecutePolicyExecuteEnrichPolicyStatus option
        [<JsonPropertyName("task")>]
        Task: TaskId option
    }

    type EnrichStatsRequest = {
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: EnrichStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_enrich/_stats"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
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

    module EnrichStatsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: EnrichStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            EnrichStatsRequest.ToRequest request

    type EnrichStatsRequestBuilder() =
        member _.Yield(_: unit) : EnrichStatsRequest =
            {
                EnrichStatsRequest.MasterTimeout = Option.None
            } : EnrichStatsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: EnrichStatsRequest, value: Duration) =
            { state with EnrichStatsRequest.MasterTimeout = Option.Some value } : EnrichStatsRequest

    let enrichStatsRequest = EnrichStatsRequestBuilder()

    type EnrichStatsResponse = {
        [<JsonPropertyName("coordinator_stats")>]
        CoordinatorStats: StatsCoordinatorStats array
        [<JsonPropertyName("executing_policies")>]
        ExecutingPolicies: StatsExecutingPolicy array
        [<JsonPropertyName("cache_stats")>]
        CacheStats: StatsCacheStats array option
    }


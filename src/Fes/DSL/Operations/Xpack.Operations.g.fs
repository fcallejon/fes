// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module XpackOperations =

    type XpackInfoRequest = {
        Categories: InfoXPackCategory array option
        AcceptEnterprise: bool option
        Human: bool option
    } with
        static member ToRequest(request: XpackInfoRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_xpack"
                let queryParams =
                    [
                        request.Categories |> Option.map (fun v -> "categories", Fes.Http.toQueryValue v)
                        request.AcceptEnterprise |> Option.map (fun v -> "accept_enterprise", Fes.Http.toQueryValue v)
                        request.Human |> Option.map (fun v -> "human", Fes.Http.toQueryValue v)
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

    module XpackInfoRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: XpackInfoRequest) : Result<Fes.Http.RequestMsg, exn> =
            XpackInfoRequest.ToRequest request

    type XpackInfoRequestBuilder() =
        member _.Yield(_: unit) : XpackInfoRequest =
            {
                XpackInfoRequest.Categories = Option.None
                XpackInfoRequest.AcceptEnterprise = Option.None
                XpackInfoRequest.Human = Option.None
            } : XpackInfoRequest

        [<CustomOperation("categories")>]
        member _.Categories(state: XpackInfoRequest, value: InfoXPackCategory array) =
            { state with XpackInfoRequest.Categories = Option.Some value } : XpackInfoRequest

        [<CustomOperation("accept_enterprise")>]
        member _.AcceptEnterprise(state: XpackInfoRequest, value: bool) =
            { state with XpackInfoRequest.AcceptEnterprise = Option.Some value } : XpackInfoRequest

        [<CustomOperation("human")>]
        member _.Human(state: XpackInfoRequest, value: bool) =
            { state with XpackInfoRequest.Human = Option.Some value } : XpackInfoRequest

    let xpackInfoRequest = XpackInfoRequestBuilder()

    type XpackInfoResponse = {
        [<JsonPropertyName("build")>]
        Build: InfoBuildInformation
        [<JsonPropertyName("features")>]
        Features: InfoFeatures
        [<JsonPropertyName("license")>]
        License: InfoMinimalLicenseInformation
        [<JsonPropertyName("tagline")>]
        Tagline: string
    }

    type XpackUsageRequest = {
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: XpackUsageRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_xpack/usage"
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

    module XpackUsageRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: XpackUsageRequest) : Result<Fes.Http.RequestMsg, exn> =
            XpackUsageRequest.ToRequest request

    type XpackUsageRequestBuilder() =
        member _.Yield(_: unit) : XpackUsageRequest =
            {
                XpackUsageRequest.MasterTimeout = Option.None
            } : XpackUsageRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: XpackUsageRequest, value: Duration) =
            { state with XpackUsageRequest.MasterTimeout = Option.Some value } : XpackUsageRequest

    let xpackUsageRequest = XpackUsageRequestBuilder()

    type XpackUsageResponse = {
        [<JsonPropertyName("aggregate_metric")>]
        AggregateMetric: UsageBase
        [<JsonPropertyName("analytics")>]
        Analytics: UsageAnalytics
        [<JsonPropertyName("archive")>]
        Archive: UsageArchive
        [<JsonPropertyName("watcher")>]
        Watcher: UsageWatcher
        [<JsonPropertyName("ccr")>]
        Ccr: UsageCcr
        [<JsonPropertyName("data_frame")>]
        DataFrame: UsageBase option
        [<JsonPropertyName("data_science")>]
        DataScience: UsageBase option
        [<JsonPropertyName("data_streams")>]
        DataStreams: UsageDataStreams option
        [<JsonPropertyName("data_tiers")>]
        DataTiers: UsageDataTiers
        [<JsonPropertyName("enrich")>]
        Enrich: UsageBase option
        [<JsonPropertyName("eql")>]
        Eql: UsageEql
        [<JsonPropertyName("flattened")>]
        Flattened: UsageFlattened option
        [<JsonPropertyName("graph")>]
        Graph: UsageBase
        [<JsonPropertyName("health_api")>]
        HealthApi: UsageHealthStatistics option
        [<JsonPropertyName("ilm")>]
        Ilm: UsageIlm
        [<JsonPropertyName("logstash")>]
        Logstash: UsageBase
        [<JsonPropertyName("ml")>]
        Ml: UsageMachineLearning
        [<JsonPropertyName("monitoring")>]
        Monitoring: UsageMonitoring
        [<JsonPropertyName("rollup")>]
        Rollup: UsageBase
        [<JsonPropertyName("runtime_fields")>]
        RuntimeFields: UsageRuntimeFieldTypes option
        [<JsonPropertyName("spatial")>]
        Spatial: UsageBase
        [<JsonPropertyName("searchable_snapshots")>]
        SearchableSnapshots: UsageSearchableSnapshots
        [<JsonPropertyName("security")>]
        Security: UsageSecurity
        [<JsonPropertyName("slm")>]
        Slm: UsageSlm
        [<JsonPropertyName("sql")>]
        Sql: UsageSql
        [<JsonPropertyName("transform")>]
        Transform: UsageBase
        [<JsonPropertyName("vectors")>]
        Vectors: UsageVector option
        [<JsonPropertyName("voting_only")>]
        VotingOnly: UsageBase
    }


// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module CatOperations =

    type CatAliasesRequest = {
        Name: Names
        H: TypesCatAliasesColumns option
        S: Names option
        ExpandWildcards: ExpandWildcards option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: CatAliasesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cat/aliases/{request.Name}"
                let queryParams =
                    [
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", string v)
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

    module CatAliasesRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatAliasesRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatAliasesRequest.ToRequest request

    type CatAliasesRequestBuilder() =
        member _.Yield(_: unit) : CatAliasesRequest =
            {
                CatAliasesRequest.Name = Unchecked.defaultof<Names>
                CatAliasesRequest.H = Option.None
                CatAliasesRequest.S = Option.None
                CatAliasesRequest.ExpandWildcards = Option.None
                CatAliasesRequest.MasterTimeout = Option.None
            } : CatAliasesRequest

        [<CustomOperation("name")>]
        member _.Name(state: CatAliasesRequest, value: Names) =
            { state with CatAliasesRequest.Name = value } : CatAliasesRequest

        [<CustomOperation("h")>]
        member _.H(state: CatAliasesRequest, value: TypesCatAliasesColumns) =
            { state with CatAliasesRequest.H = Option.Some value } : CatAliasesRequest

        [<CustomOperation("s")>]
        member _.S(state: CatAliasesRequest, value: Names) =
            { state with CatAliasesRequest.S = Option.Some value } : CatAliasesRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: CatAliasesRequest, value: ExpandWildcards) =
            { state with CatAliasesRequest.ExpandWildcards = Option.Some value } : CatAliasesRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CatAliasesRequest, value: Duration) =
            { state with CatAliasesRequest.MasterTimeout = Option.Some value } : CatAliasesRequest

    let catAliasesRequest = CatAliasesRequestBuilder()

    type CatAllocationRequest = {
        NodeId: NodeIds
        H: TypesCatAllocationColumns option
        S: Names option
        Local: bool option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: CatAllocationRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cat/allocation/{request.NodeId}"
                let queryParams =
                    [
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
                        request.Local |> Option.map (fun v -> "local", string v)
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

    module CatAllocationRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatAllocationRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatAllocationRequest.ToRequest request

    type CatAllocationRequestBuilder() =
        member _.Yield(_: unit) : CatAllocationRequest =
            {
                CatAllocationRequest.NodeId = Unchecked.defaultof<NodeIds>
                CatAllocationRequest.H = Option.None
                CatAllocationRequest.S = Option.None
                CatAllocationRequest.Local = Option.None
                CatAllocationRequest.MasterTimeout = Option.None
            } : CatAllocationRequest

        [<CustomOperation("node_id")>]
        member _.NodeId(state: CatAllocationRequest, value: NodeIds) =
            { state with CatAllocationRequest.NodeId = value } : CatAllocationRequest

        [<CustomOperation("h")>]
        member _.H(state: CatAllocationRequest, value: TypesCatAllocationColumns) =
            { state with CatAllocationRequest.H = Option.Some value } : CatAllocationRequest

        [<CustomOperation("s")>]
        member _.S(state: CatAllocationRequest, value: Names) =
            { state with CatAllocationRequest.S = Option.Some value } : CatAllocationRequest

        [<CustomOperation("local")>]
        member _.Local(state: CatAllocationRequest, value: bool) =
            { state with CatAllocationRequest.Local = Option.Some value } : CatAllocationRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CatAllocationRequest, value: Duration) =
            { state with CatAllocationRequest.MasterTimeout = Option.Some value } : CatAllocationRequest

    let catAllocationRequest = CatAllocationRequestBuilder()

    type CatCircuitBreakerRequest = {
        CircuitBreakerPatterns: System.Text.Json.JsonElement
        H: TypesCatCircuitBreakerColumns option
        S: Names option
        Local: bool option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: CatCircuitBreakerRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cat/circuit_breaker/{request.CircuitBreakerPatterns}"
                let queryParams =
                    [
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
                        request.Local |> Option.map (fun v -> "local", string v)
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

    module CatCircuitBreakerRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatCircuitBreakerRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatCircuitBreakerRequest.ToRequest request

    type CatCircuitBreakerRequestBuilder() =
        member _.Yield(_: unit) : CatCircuitBreakerRequest =
            {
                CatCircuitBreakerRequest.CircuitBreakerPatterns = Unchecked.defaultof<System.Text.Json.JsonElement>
                CatCircuitBreakerRequest.H = Option.None
                CatCircuitBreakerRequest.S = Option.None
                CatCircuitBreakerRequest.Local = Option.None
                CatCircuitBreakerRequest.MasterTimeout = Option.None
            } : CatCircuitBreakerRequest

        [<CustomOperation("circuit_breaker_patterns")>]
        member _.CircuitBreakerPatterns(state: CatCircuitBreakerRequest, value: System.Text.Json.JsonElement) =
            { state with CatCircuitBreakerRequest.CircuitBreakerPatterns = value } : CatCircuitBreakerRequest

        [<CustomOperation("h")>]
        member _.H(state: CatCircuitBreakerRequest, value: TypesCatCircuitBreakerColumns) =
            { state with CatCircuitBreakerRequest.H = Option.Some value } : CatCircuitBreakerRequest

        [<CustomOperation("s")>]
        member _.S(state: CatCircuitBreakerRequest, value: Names) =
            { state with CatCircuitBreakerRequest.S = Option.Some value } : CatCircuitBreakerRequest

        [<CustomOperation("local")>]
        member _.Local(state: CatCircuitBreakerRequest, value: bool) =
            { state with CatCircuitBreakerRequest.Local = Option.Some value } : CatCircuitBreakerRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CatCircuitBreakerRequest, value: Duration) =
            { state with CatCircuitBreakerRequest.MasterTimeout = Option.Some value } : CatCircuitBreakerRequest

    let catCircuitBreakerRequest = CatCircuitBreakerRequestBuilder()

    type CatComponentTemplatesRequest = {
        Name: string
        H: TypesCatComponentColumns option
        S: Names option
        Local: bool option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: CatComponentTemplatesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cat/component_templates/{request.Name}"
                let queryParams =
                    [
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
                        request.Local |> Option.map (fun v -> "local", string v)
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

    module CatComponentTemplatesRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatComponentTemplatesRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatComponentTemplatesRequest.ToRequest request

    type CatComponentTemplatesRequestBuilder() =
        member _.Yield(_: unit) : CatComponentTemplatesRequest =
            {
                CatComponentTemplatesRequest.Name = String.Empty
                CatComponentTemplatesRequest.H = Option.None
                CatComponentTemplatesRequest.S = Option.None
                CatComponentTemplatesRequest.Local = Option.None
                CatComponentTemplatesRequest.MasterTimeout = Option.None
            } : CatComponentTemplatesRequest

        [<CustomOperation("name")>]
        member _.Name(state: CatComponentTemplatesRequest, value: string) =
            { state with CatComponentTemplatesRequest.Name = value } : CatComponentTemplatesRequest

        [<CustomOperation("h")>]
        member _.H(state: CatComponentTemplatesRequest, value: TypesCatComponentColumns) =
            { state with CatComponentTemplatesRequest.H = Option.Some value } : CatComponentTemplatesRequest

        [<CustomOperation("s")>]
        member _.S(state: CatComponentTemplatesRequest, value: Names) =
            { state with CatComponentTemplatesRequest.S = Option.Some value } : CatComponentTemplatesRequest

        [<CustomOperation("local")>]
        member _.Local(state: CatComponentTemplatesRequest, value: bool) =
            { state with CatComponentTemplatesRequest.Local = Option.Some value } : CatComponentTemplatesRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CatComponentTemplatesRequest, value: Duration) =
            { state with CatComponentTemplatesRequest.MasterTimeout = Option.Some value } : CatComponentTemplatesRequest

    let catComponentTemplatesRequest = CatComponentTemplatesRequestBuilder()

    type CatCountRequest = {
        Index: Indices
        H: TypesCatCountColumns option
        S: Names option
    } with
        static member ToRequest(request: CatCountRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cat/count/{request.Index}"
                let queryParams =
                    [
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
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

    module CatCountRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatCountRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatCountRequest.ToRequest request

    type CatCountRequestBuilder() =
        member _.Yield(_: unit) : CatCountRequest =
            {
                CatCountRequest.Index = Unchecked.defaultof<Indices>
                CatCountRequest.H = Option.None
                CatCountRequest.S = Option.None
            } : CatCountRequest

        [<CustomOperation("index")>]
        member _.Index(state: CatCountRequest, value: Indices) =
            { state with CatCountRequest.Index = value } : CatCountRequest

        [<CustomOperation("h")>]
        member _.H(state: CatCountRequest, value: TypesCatCountColumns) =
            { state with CatCountRequest.H = Option.Some value } : CatCountRequest

        [<CustomOperation("s")>]
        member _.S(state: CatCountRequest, value: Names) =
            { state with CatCountRequest.S = Option.Some value } : CatCountRequest

    let catCountRequest = CatCountRequestBuilder()

    type CatFielddataRequest = {
        Fields: Fields
        Fields2: Fields option
        H: TypesCatFieldDataColumns option
        S: Names option
    } with
        static member ToRequest(request: CatFielddataRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cat/fielddata/{request.Fields}"
                let queryParams =
                    [
                        request.Fields2 |> Option.map (fun v -> "fields", string v)
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
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

    module CatFielddataRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatFielddataRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatFielddataRequest.ToRequest request

    type CatFielddataRequestBuilder() =
        member _.Yield(_: unit) : CatFielddataRequest =
            {
                CatFielddataRequest.Fields = Unchecked.defaultof<Fields>
                CatFielddataRequest.Fields2 = Option.None
                CatFielddataRequest.H = Option.None
                CatFielddataRequest.S = Option.None
            } : CatFielddataRequest

        [<CustomOperation("fields")>]
        member _.Fields(state: CatFielddataRequest, value: Fields) =
            { state with CatFielddataRequest.Fields = value } : CatFielddataRequest

        [<CustomOperation("fields2")>]
        member _.Fields2(state: CatFielddataRequest, value: Fields) =
            { state with CatFielddataRequest.Fields2 = Option.Some value } : CatFielddataRequest

        [<CustomOperation("h")>]
        member _.H(state: CatFielddataRequest, value: TypesCatFieldDataColumns) =
            { state with CatFielddataRequest.H = Option.Some value } : CatFielddataRequest

        [<CustomOperation("s")>]
        member _.S(state: CatFielddataRequest, value: Names) =
            { state with CatFielddataRequest.S = Option.Some value } : CatFielddataRequest

    let catFielddataRequest = CatFielddataRequestBuilder()

    type CatHealthRequest = {
        Ts: bool option
        H: TypesCatHealthColumns option
        S: Names option
    } with
        static member ToRequest(request: CatHealthRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_cat/health"
                let queryParams =
                    [
                        request.Ts |> Option.map (fun v -> "ts", string v)
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
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

    module CatHealthRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatHealthRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatHealthRequest.ToRequest request

    type CatHealthRequestBuilder() =
        member _.Yield(_: unit) : CatHealthRequest =
            {
                CatHealthRequest.Ts = Option.None
                CatHealthRequest.H = Option.None
                CatHealthRequest.S = Option.None
            } : CatHealthRequest

        [<CustomOperation("ts")>]
        member _.Ts(state: CatHealthRequest, value: bool) =
            { state with CatHealthRequest.Ts = Option.Some value } : CatHealthRequest

        [<CustomOperation("h")>]
        member _.H(state: CatHealthRequest, value: TypesCatHealthColumns) =
            { state with CatHealthRequest.H = Option.Some value } : CatHealthRequest

        [<CustomOperation("s")>]
        member _.S(state: CatHealthRequest, value: Names) =
            { state with CatHealthRequest.S = Option.Some value } : CatHealthRequest

    let catHealthRequest = CatHealthRequestBuilder()

    type CatHelpRequest = unit

    let catHelpRequest = ()

    type CatIndicesRequest = {
        Index: Indices
        ExpandWildcards: ExpandWildcards option
        Health: HealthStatus option
        IncludeUnloadedSegments: bool option
        Pri: bool option
        MasterTimeout: Duration option
        H: TypesCatIndicesColumns option
        S: Names option
    } with
        static member ToRequest(request: CatIndicesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cat/indices/{request.Index}"
                let queryParams =
                    [
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", string v)
                        request.Health |> Option.map (fun v -> "health", string v)
                        request.IncludeUnloadedSegments |> Option.map (fun v -> "include_unloaded_segments", string v)
                        request.Pri |> Option.map (fun v -> "pri", string v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
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

    module CatIndicesRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatIndicesRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatIndicesRequest.ToRequest request

    type CatIndicesRequestBuilder() =
        member _.Yield(_: unit) : CatIndicesRequest =
            {
                CatIndicesRequest.Index = Unchecked.defaultof<Indices>
                CatIndicesRequest.ExpandWildcards = Option.None
                CatIndicesRequest.Health = Option.None
                CatIndicesRequest.IncludeUnloadedSegments = Option.None
                CatIndicesRequest.Pri = Option.None
                CatIndicesRequest.MasterTimeout = Option.None
                CatIndicesRequest.H = Option.None
                CatIndicesRequest.S = Option.None
            } : CatIndicesRequest

        [<CustomOperation("index")>]
        member _.Index(state: CatIndicesRequest, value: Indices) =
            { state with CatIndicesRequest.Index = value } : CatIndicesRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: CatIndicesRequest, value: ExpandWildcards) =
            { state with CatIndicesRequest.ExpandWildcards = Option.Some value } : CatIndicesRequest

        [<CustomOperation("health")>]
        member _.Health(state: CatIndicesRequest, value: HealthStatus) =
            { state with CatIndicesRequest.Health = Option.Some value } : CatIndicesRequest

        [<CustomOperation("include_unloaded_segments")>]
        member _.IncludeUnloadedSegments(state: CatIndicesRequest, value: bool) =
            { state with CatIndicesRequest.IncludeUnloadedSegments = Option.Some value } : CatIndicesRequest

        [<CustomOperation("pri")>]
        member _.Pri(state: CatIndicesRequest, value: bool) =
            { state with CatIndicesRequest.Pri = Option.Some value } : CatIndicesRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CatIndicesRequest, value: Duration) =
            { state with CatIndicesRequest.MasterTimeout = Option.Some value } : CatIndicesRequest

        [<CustomOperation("h")>]
        member _.H(state: CatIndicesRequest, value: TypesCatIndicesColumns) =
            { state with CatIndicesRequest.H = Option.Some value } : CatIndicesRequest

        [<CustomOperation("s")>]
        member _.S(state: CatIndicesRequest, value: Names) =
            { state with CatIndicesRequest.S = Option.Some value } : CatIndicesRequest

    let catIndicesRequest = CatIndicesRequestBuilder()

    type CatMasterRequest = {
        H: TypesCatMasterColumns option
        S: Names option
        Local: bool option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: CatMasterRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_cat/master"
                let queryParams =
                    [
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
                        request.Local |> Option.map (fun v -> "local", string v)
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

    module CatMasterRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatMasterRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatMasterRequest.ToRequest request

    type CatMasterRequestBuilder() =
        member _.Yield(_: unit) : CatMasterRequest =
            {
                CatMasterRequest.H = Option.None
                CatMasterRequest.S = Option.None
                CatMasterRequest.Local = Option.None
                CatMasterRequest.MasterTimeout = Option.None
            } : CatMasterRequest

        [<CustomOperation("h")>]
        member _.H(state: CatMasterRequest, value: TypesCatMasterColumns) =
            { state with CatMasterRequest.H = Option.Some value } : CatMasterRequest

        [<CustomOperation("s")>]
        member _.S(state: CatMasterRequest, value: Names) =
            { state with CatMasterRequest.S = Option.Some value } : CatMasterRequest

        [<CustomOperation("local")>]
        member _.Local(state: CatMasterRequest, value: bool) =
            { state with CatMasterRequest.Local = Option.Some value } : CatMasterRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CatMasterRequest, value: Duration) =
            { state with CatMasterRequest.MasterTimeout = Option.Some value } : CatMasterRequest

    let catMasterRequest = CatMasterRequestBuilder()

    type CatMlDataFrameAnalyticsRequest = {
        Id: Id
        AllowNoMatch: bool option
        H: TypesCatDfaColumns option
        S: TypesCatDfaColumns option
    } with
        static member ToRequest(request: CatMlDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cat/ml/data_frame/analytics/{request.Id}"
                let queryParams =
                    [
                        request.AllowNoMatch |> Option.map (fun v -> "allow_no_match", string v)
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
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

    module CatMlDataFrameAnalyticsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatMlDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatMlDataFrameAnalyticsRequest.ToRequest request

    type CatMlDataFrameAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : CatMlDataFrameAnalyticsRequest =
            {
                CatMlDataFrameAnalyticsRequest.Id = Unchecked.defaultof<Id>
                CatMlDataFrameAnalyticsRequest.AllowNoMatch = Option.None
                CatMlDataFrameAnalyticsRequest.H = Option.None
                CatMlDataFrameAnalyticsRequest.S = Option.None
            } : CatMlDataFrameAnalyticsRequest

        [<CustomOperation("id")>]
        member _.Id(state: CatMlDataFrameAnalyticsRequest, value: Id) =
            { state with CatMlDataFrameAnalyticsRequest.Id = value } : CatMlDataFrameAnalyticsRequest

        [<CustomOperation("allow_no_match")>]
        member _.AllowNoMatch(state: CatMlDataFrameAnalyticsRequest, value: bool) =
            { state with CatMlDataFrameAnalyticsRequest.AllowNoMatch = Option.Some value } : CatMlDataFrameAnalyticsRequest

        [<CustomOperation("h")>]
        member _.H(state: CatMlDataFrameAnalyticsRequest, value: TypesCatDfaColumns) =
            { state with CatMlDataFrameAnalyticsRequest.H = Option.Some value } : CatMlDataFrameAnalyticsRequest

        [<CustomOperation("s")>]
        member _.S(state: CatMlDataFrameAnalyticsRequest, value: TypesCatDfaColumns) =
            { state with CatMlDataFrameAnalyticsRequest.S = Option.Some value } : CatMlDataFrameAnalyticsRequest

    let catMlDataFrameAnalyticsRequest = CatMlDataFrameAnalyticsRequestBuilder()

    type CatMlDatafeedsRequest = {
        DatafeedId: Id
        AllowNoMatch: bool option
        H: TypesCatDatafeedColumns option
        S: TypesCatDatafeedColumns option
    } with
        static member ToRequest(request: CatMlDatafeedsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cat/ml/datafeeds/{request.DatafeedId}"
                let queryParams =
                    [
                        request.AllowNoMatch |> Option.map (fun v -> "allow_no_match", string v)
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
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

    module CatMlDatafeedsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatMlDatafeedsRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatMlDatafeedsRequest.ToRequest request

    type CatMlDatafeedsRequestBuilder() =
        member _.Yield(_: unit) : CatMlDatafeedsRequest =
            {
                CatMlDatafeedsRequest.DatafeedId = Unchecked.defaultof<Id>
                CatMlDatafeedsRequest.AllowNoMatch = Option.None
                CatMlDatafeedsRequest.H = Option.None
                CatMlDatafeedsRequest.S = Option.None
            } : CatMlDatafeedsRequest

        [<CustomOperation("datafeed_id")>]
        member _.DatafeedId(state: CatMlDatafeedsRequest, value: Id) =
            { state with CatMlDatafeedsRequest.DatafeedId = value } : CatMlDatafeedsRequest

        [<CustomOperation("allow_no_match")>]
        member _.AllowNoMatch(state: CatMlDatafeedsRequest, value: bool) =
            { state with CatMlDatafeedsRequest.AllowNoMatch = Option.Some value } : CatMlDatafeedsRequest

        [<CustomOperation("h")>]
        member _.H(state: CatMlDatafeedsRequest, value: TypesCatDatafeedColumns) =
            { state with CatMlDatafeedsRequest.H = Option.Some value } : CatMlDatafeedsRequest

        [<CustomOperation("s")>]
        member _.S(state: CatMlDatafeedsRequest, value: TypesCatDatafeedColumns) =
            { state with CatMlDatafeedsRequest.S = Option.Some value } : CatMlDatafeedsRequest

    let catMlDatafeedsRequest = CatMlDatafeedsRequestBuilder()

    type CatMlJobsRequest = {
        JobId: Id
        AllowNoMatch: bool option
        H: TypesCatAnomalyDetectorColumns option
        S: TypesCatAnomalyDetectorColumns option
    } with
        static member ToRequest(request: CatMlJobsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cat/ml/anomaly_detectors/{request.JobId}"
                let queryParams =
                    [
                        request.AllowNoMatch |> Option.map (fun v -> "allow_no_match", string v)
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
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

    module CatMlJobsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatMlJobsRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatMlJobsRequest.ToRequest request

    type CatMlJobsRequestBuilder() =
        member _.Yield(_: unit) : CatMlJobsRequest =
            {
                CatMlJobsRequest.JobId = Unchecked.defaultof<Id>
                CatMlJobsRequest.AllowNoMatch = Option.None
                CatMlJobsRequest.H = Option.None
                CatMlJobsRequest.S = Option.None
            } : CatMlJobsRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: CatMlJobsRequest, value: Id) =
            { state with CatMlJobsRequest.JobId = value } : CatMlJobsRequest

        [<CustomOperation("allow_no_match")>]
        member _.AllowNoMatch(state: CatMlJobsRequest, value: bool) =
            { state with CatMlJobsRequest.AllowNoMatch = Option.Some value } : CatMlJobsRequest

        [<CustomOperation("h")>]
        member _.H(state: CatMlJobsRequest, value: TypesCatAnomalyDetectorColumns) =
            { state with CatMlJobsRequest.H = Option.Some value } : CatMlJobsRequest

        [<CustomOperation("s")>]
        member _.S(state: CatMlJobsRequest, value: TypesCatAnomalyDetectorColumns) =
            { state with CatMlJobsRequest.S = Option.Some value } : CatMlJobsRequest

    let catMlJobsRequest = CatMlJobsRequestBuilder()

    type CatMlTrainedModelsRequest = {
        ModelId: Id
        AllowNoMatch: bool option
        H: TypesCatTrainedModelsColumns option
        S: TypesCatTrainedModelsColumns option
        From: float option
        Size: float option
    } with
        static member ToRequest(request: CatMlTrainedModelsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cat/ml/trained_models/{request.ModelId}"
                let queryParams =
                    [
                        request.AllowNoMatch |> Option.map (fun v -> "allow_no_match", string v)
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
                        request.From |> Option.map (fun v -> "from", string v)
                        request.Size |> Option.map (fun v -> "size", string v)
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

    module CatMlTrainedModelsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatMlTrainedModelsRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatMlTrainedModelsRequest.ToRequest request

    type CatMlTrainedModelsRequestBuilder() =
        member _.Yield(_: unit) : CatMlTrainedModelsRequest =
            {
                CatMlTrainedModelsRequest.ModelId = Unchecked.defaultof<Id>
                CatMlTrainedModelsRequest.AllowNoMatch = Option.None
                CatMlTrainedModelsRequest.H = Option.None
                CatMlTrainedModelsRequest.S = Option.None
                CatMlTrainedModelsRequest.From = Option.None
                CatMlTrainedModelsRequest.Size = Option.None
            } : CatMlTrainedModelsRequest

        [<CustomOperation("model_id")>]
        member _.ModelId(state: CatMlTrainedModelsRequest, value: Id) =
            { state with CatMlTrainedModelsRequest.ModelId = value } : CatMlTrainedModelsRequest

        [<CustomOperation("allow_no_match")>]
        member _.AllowNoMatch(state: CatMlTrainedModelsRequest, value: bool) =
            { state with CatMlTrainedModelsRequest.AllowNoMatch = Option.Some value } : CatMlTrainedModelsRequest

        [<CustomOperation("h")>]
        member _.H(state: CatMlTrainedModelsRequest, value: TypesCatTrainedModelsColumns) =
            { state with CatMlTrainedModelsRequest.H = Option.Some value } : CatMlTrainedModelsRequest

        [<CustomOperation("s")>]
        member _.S(state: CatMlTrainedModelsRequest, value: TypesCatTrainedModelsColumns) =
            { state with CatMlTrainedModelsRequest.S = Option.Some value } : CatMlTrainedModelsRequest

        [<CustomOperation("from")>]
        member _.From(state: CatMlTrainedModelsRequest, value: float) =
            { state with CatMlTrainedModelsRequest.From = Option.Some value } : CatMlTrainedModelsRequest

        [<CustomOperation("size")>]
        member _.Size(state: CatMlTrainedModelsRequest, value: float) =
            { state with CatMlTrainedModelsRequest.Size = Option.Some value } : CatMlTrainedModelsRequest

    let catMlTrainedModelsRequest = CatMlTrainedModelsRequestBuilder()

    type CatNodeattrsRequest = {
        H: TypesCatNodeattrsColumns option
        S: Names option
        Local: bool option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: CatNodeattrsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_cat/nodeattrs"
                let queryParams =
                    [
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
                        request.Local |> Option.map (fun v -> "local", string v)
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

    module CatNodeattrsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatNodeattrsRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatNodeattrsRequest.ToRequest request

    type CatNodeattrsRequestBuilder() =
        member _.Yield(_: unit) : CatNodeattrsRequest =
            {
                CatNodeattrsRequest.H = Option.None
                CatNodeattrsRequest.S = Option.None
                CatNodeattrsRequest.Local = Option.None
                CatNodeattrsRequest.MasterTimeout = Option.None
            } : CatNodeattrsRequest

        [<CustomOperation("h")>]
        member _.H(state: CatNodeattrsRequest, value: TypesCatNodeattrsColumns) =
            { state with CatNodeattrsRequest.H = Option.Some value } : CatNodeattrsRequest

        [<CustomOperation("s")>]
        member _.S(state: CatNodeattrsRequest, value: Names) =
            { state with CatNodeattrsRequest.S = Option.Some value } : CatNodeattrsRequest

        [<CustomOperation("local")>]
        member _.Local(state: CatNodeattrsRequest, value: bool) =
            { state with CatNodeattrsRequest.Local = Option.Some value } : CatNodeattrsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CatNodeattrsRequest, value: Duration) =
            { state with CatNodeattrsRequest.MasterTimeout = Option.Some value } : CatNodeattrsRequest

    let catNodeattrsRequest = CatNodeattrsRequestBuilder()

    type CatNodesRequest = {
        FullId: bool option
        IncludeUnloadedSegments: bool option
        H: TypesCatNodeColumns option
        S: Names option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: CatNodesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_cat/nodes"
                let queryParams =
                    [
                        request.FullId |> Option.map (fun v -> "full_id", string v)
                        request.IncludeUnloadedSegments |> Option.map (fun v -> "include_unloaded_segments", string v)
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
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

    module CatNodesRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatNodesRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatNodesRequest.ToRequest request

    type CatNodesRequestBuilder() =
        member _.Yield(_: unit) : CatNodesRequest =
            {
                CatNodesRequest.FullId = Option.None
                CatNodesRequest.IncludeUnloadedSegments = Option.None
                CatNodesRequest.H = Option.None
                CatNodesRequest.S = Option.None
                CatNodesRequest.MasterTimeout = Option.None
            } : CatNodesRequest

        [<CustomOperation("full_id")>]
        member _.FullId(state: CatNodesRequest, value: bool) =
            { state with CatNodesRequest.FullId = Option.Some value } : CatNodesRequest

        [<CustomOperation("include_unloaded_segments")>]
        member _.IncludeUnloadedSegments(state: CatNodesRequest, value: bool) =
            { state with CatNodesRequest.IncludeUnloadedSegments = Option.Some value } : CatNodesRequest

        [<CustomOperation("h")>]
        member _.H(state: CatNodesRequest, value: TypesCatNodeColumns) =
            { state with CatNodesRequest.H = Option.Some value } : CatNodesRequest

        [<CustomOperation("s")>]
        member _.S(state: CatNodesRequest, value: Names) =
            { state with CatNodesRequest.S = Option.Some value } : CatNodesRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CatNodesRequest, value: Duration) =
            { state with CatNodesRequest.MasterTimeout = Option.Some value } : CatNodesRequest

    let catNodesRequest = CatNodesRequestBuilder()

    type CatPendingTasksRequest = {
        H: TypesCatPendingTasksColumns option
        S: Names option
        Local: bool option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: CatPendingTasksRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_cat/pending_tasks"
                let queryParams =
                    [
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
                        request.Local |> Option.map (fun v -> "local", string v)
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

    module CatPendingTasksRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatPendingTasksRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatPendingTasksRequest.ToRequest request

    type CatPendingTasksRequestBuilder() =
        member _.Yield(_: unit) : CatPendingTasksRequest =
            {
                CatPendingTasksRequest.H = Option.None
                CatPendingTasksRequest.S = Option.None
                CatPendingTasksRequest.Local = Option.None
                CatPendingTasksRequest.MasterTimeout = Option.None
            } : CatPendingTasksRequest

        [<CustomOperation("h")>]
        member _.H(state: CatPendingTasksRequest, value: TypesCatPendingTasksColumns) =
            { state with CatPendingTasksRequest.H = Option.Some value } : CatPendingTasksRequest

        [<CustomOperation("s")>]
        member _.S(state: CatPendingTasksRequest, value: Names) =
            { state with CatPendingTasksRequest.S = Option.Some value } : CatPendingTasksRequest

        [<CustomOperation("local")>]
        member _.Local(state: CatPendingTasksRequest, value: bool) =
            { state with CatPendingTasksRequest.Local = Option.Some value } : CatPendingTasksRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CatPendingTasksRequest, value: Duration) =
            { state with CatPendingTasksRequest.MasterTimeout = Option.Some value } : CatPendingTasksRequest

    let catPendingTasksRequest = CatPendingTasksRequestBuilder()

    type CatPluginsRequest = {
        H: TypesCatPluginsColumns option
        S: Names option
        IncludeBootstrap: bool option
        Local: bool option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: CatPluginsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_cat/plugins"
                let queryParams =
                    [
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
                        request.IncludeBootstrap |> Option.map (fun v -> "include_bootstrap", string v)
                        request.Local |> Option.map (fun v -> "local", string v)
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

    module CatPluginsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatPluginsRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatPluginsRequest.ToRequest request

    type CatPluginsRequestBuilder() =
        member _.Yield(_: unit) : CatPluginsRequest =
            {
                CatPluginsRequest.H = Option.None
                CatPluginsRequest.S = Option.None
                CatPluginsRequest.IncludeBootstrap = Option.None
                CatPluginsRequest.Local = Option.None
                CatPluginsRequest.MasterTimeout = Option.None
            } : CatPluginsRequest

        [<CustomOperation("h")>]
        member _.H(state: CatPluginsRequest, value: TypesCatPluginsColumns) =
            { state with CatPluginsRequest.H = Option.Some value } : CatPluginsRequest

        [<CustomOperation("s")>]
        member _.S(state: CatPluginsRequest, value: Names) =
            { state with CatPluginsRequest.S = Option.Some value } : CatPluginsRequest

        [<CustomOperation("include_bootstrap")>]
        member _.IncludeBootstrap(state: CatPluginsRequest, value: bool) =
            { state with CatPluginsRequest.IncludeBootstrap = Option.Some value } : CatPluginsRequest

        [<CustomOperation("local")>]
        member _.Local(state: CatPluginsRequest, value: bool) =
            { state with CatPluginsRequest.Local = Option.Some value } : CatPluginsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CatPluginsRequest, value: Duration) =
            { state with CatPluginsRequest.MasterTimeout = Option.Some value } : CatPluginsRequest

    let catPluginsRequest = CatPluginsRequestBuilder()

    type CatRecoveryRequest = {
        Index: Indices
        ActiveOnly: bool option
        Detailed: bool option
        Index2: Indices option
        H: TypesCatRecoveryColumns option
        S: Names option
    } with
        static member ToRequest(request: CatRecoveryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cat/recovery/{request.Index}"
                let queryParams =
                    [
                        request.ActiveOnly |> Option.map (fun v -> "active_only", string v)
                        request.Detailed |> Option.map (fun v -> "detailed", string v)
                        request.Index2 |> Option.map (fun v -> "index", string v)
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
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

    module CatRecoveryRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatRecoveryRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatRecoveryRequest.ToRequest request

    type CatRecoveryRequestBuilder() =
        member _.Yield(_: unit) : CatRecoveryRequest =
            {
                CatRecoveryRequest.Index = Unchecked.defaultof<Indices>
                CatRecoveryRequest.ActiveOnly = Option.None
                CatRecoveryRequest.Detailed = Option.None
                CatRecoveryRequest.Index2 = Option.None
                CatRecoveryRequest.H = Option.None
                CatRecoveryRequest.S = Option.None
            } : CatRecoveryRequest

        [<CustomOperation("index")>]
        member _.Index(state: CatRecoveryRequest, value: Indices) =
            { state with CatRecoveryRequest.Index = value } : CatRecoveryRequest

        [<CustomOperation("active_only")>]
        member _.ActiveOnly(state: CatRecoveryRequest, value: bool) =
            { state with CatRecoveryRequest.ActiveOnly = Option.Some value } : CatRecoveryRequest

        [<CustomOperation("detailed")>]
        member _.Detailed(state: CatRecoveryRequest, value: bool) =
            { state with CatRecoveryRequest.Detailed = Option.Some value } : CatRecoveryRequest

        [<CustomOperation("index2")>]
        member _.Index2(state: CatRecoveryRequest, value: Indices) =
            { state with CatRecoveryRequest.Index2 = Option.Some value } : CatRecoveryRequest

        [<CustomOperation("h")>]
        member _.H(state: CatRecoveryRequest, value: TypesCatRecoveryColumns) =
            { state with CatRecoveryRequest.H = Option.Some value } : CatRecoveryRequest

        [<CustomOperation("s")>]
        member _.S(state: CatRecoveryRequest, value: Names) =
            { state with CatRecoveryRequest.S = Option.Some value } : CatRecoveryRequest

    let catRecoveryRequest = CatRecoveryRequestBuilder()

    type CatRepositoriesRequest = {
        H: Names option
        S: Names option
        Local: bool option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: CatRepositoriesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_cat/repositories"
                let queryParams =
                    [
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
                        request.Local |> Option.map (fun v -> "local", string v)
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

    module CatRepositoriesRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatRepositoriesRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatRepositoriesRequest.ToRequest request

    type CatRepositoriesRequestBuilder() =
        member _.Yield(_: unit) : CatRepositoriesRequest =
            {
                CatRepositoriesRequest.H = Option.None
                CatRepositoriesRequest.S = Option.None
                CatRepositoriesRequest.Local = Option.None
                CatRepositoriesRequest.MasterTimeout = Option.None
            } : CatRepositoriesRequest

        [<CustomOperation("h")>]
        member _.H(state: CatRepositoriesRequest, value: Names) =
            { state with CatRepositoriesRequest.H = Option.Some value } : CatRepositoriesRequest

        [<CustomOperation("s")>]
        member _.S(state: CatRepositoriesRequest, value: Names) =
            { state with CatRepositoriesRequest.S = Option.Some value } : CatRepositoriesRequest

        [<CustomOperation("local")>]
        member _.Local(state: CatRepositoriesRequest, value: bool) =
            { state with CatRepositoriesRequest.Local = Option.Some value } : CatRepositoriesRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CatRepositoriesRequest, value: Duration) =
            { state with CatRepositoriesRequest.MasterTimeout = Option.Some value } : CatRepositoriesRequest

    let catRepositoriesRequest = CatRepositoriesRequestBuilder()

    type CatSegmentsRequest = {
        Index: Indices
        H: TypesCatSegmentsColumns option
        S: Names option
        Local: bool option
        MasterTimeout: Duration option
        ExpandWildcards: ExpandWildcards option
        AllowNoIndices: bool option
        IgnoreThrottled: bool option
        IgnoreUnavailable: bool option
        AllowClosed: bool option
    } with
        static member ToRequest(request: CatSegmentsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cat/segments/{request.Index}"
                let queryParams =
                    [
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
                        request.Local |> Option.map (fun v -> "local", string v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", string v)
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", string v)
                        request.IgnoreThrottled |> Option.map (fun v -> "ignore_throttled", string v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", string v)
                        request.AllowClosed |> Option.map (fun v -> "allow_closed", string v)
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

    module CatSegmentsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatSegmentsRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatSegmentsRequest.ToRequest request

    type CatSegmentsRequestBuilder() =
        member _.Yield(_: unit) : CatSegmentsRequest =
            {
                CatSegmentsRequest.Index = Unchecked.defaultof<Indices>
                CatSegmentsRequest.H = Option.None
                CatSegmentsRequest.S = Option.None
                CatSegmentsRequest.Local = Option.None
                CatSegmentsRequest.MasterTimeout = Option.None
                CatSegmentsRequest.ExpandWildcards = Option.None
                CatSegmentsRequest.AllowNoIndices = Option.None
                CatSegmentsRequest.IgnoreThrottled = Option.None
                CatSegmentsRequest.IgnoreUnavailable = Option.None
                CatSegmentsRequest.AllowClosed = Option.None
            } : CatSegmentsRequest

        [<CustomOperation("index")>]
        member _.Index(state: CatSegmentsRequest, value: Indices) =
            { state with CatSegmentsRequest.Index = value } : CatSegmentsRequest

        [<CustomOperation("h")>]
        member _.H(state: CatSegmentsRequest, value: TypesCatSegmentsColumns) =
            { state with CatSegmentsRequest.H = Option.Some value } : CatSegmentsRequest

        [<CustomOperation("s")>]
        member _.S(state: CatSegmentsRequest, value: Names) =
            { state with CatSegmentsRequest.S = Option.Some value } : CatSegmentsRequest

        [<CustomOperation("local")>]
        member _.Local(state: CatSegmentsRequest, value: bool) =
            { state with CatSegmentsRequest.Local = Option.Some value } : CatSegmentsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CatSegmentsRequest, value: Duration) =
            { state with CatSegmentsRequest.MasterTimeout = Option.Some value } : CatSegmentsRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: CatSegmentsRequest, value: ExpandWildcards) =
            { state with CatSegmentsRequest.ExpandWildcards = Option.Some value } : CatSegmentsRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: CatSegmentsRequest, value: bool) =
            { state with CatSegmentsRequest.AllowNoIndices = Option.Some value } : CatSegmentsRequest

        [<CustomOperation("ignore_throttled")>]
        member _.IgnoreThrottled(state: CatSegmentsRequest, value: bool) =
            { state with CatSegmentsRequest.IgnoreThrottled = Option.Some value } : CatSegmentsRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: CatSegmentsRequest, value: bool) =
            { state with CatSegmentsRequest.IgnoreUnavailable = Option.Some value } : CatSegmentsRequest

        [<CustomOperation("allow_closed")>]
        member _.AllowClosed(state: CatSegmentsRequest, value: bool) =
            { state with CatSegmentsRequest.AllowClosed = Option.Some value } : CatSegmentsRequest

    let catSegmentsRequest = CatSegmentsRequestBuilder()

    type CatShardsRequest = {
        Index: Indices
        H: TypesCatShardColumns option
        S: Names option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: CatShardsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cat/shards/{request.Index}"
                let queryParams =
                    [
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
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

    module CatShardsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatShardsRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatShardsRequest.ToRequest request

    type CatShardsRequestBuilder() =
        member _.Yield(_: unit) : CatShardsRequest =
            {
                CatShardsRequest.Index = Unchecked.defaultof<Indices>
                CatShardsRequest.H = Option.None
                CatShardsRequest.S = Option.None
                CatShardsRequest.MasterTimeout = Option.None
            } : CatShardsRequest

        [<CustomOperation("index")>]
        member _.Index(state: CatShardsRequest, value: Indices) =
            { state with CatShardsRequest.Index = value } : CatShardsRequest

        [<CustomOperation("h")>]
        member _.H(state: CatShardsRequest, value: TypesCatShardColumns) =
            { state with CatShardsRequest.H = Option.Some value } : CatShardsRequest

        [<CustomOperation("s")>]
        member _.S(state: CatShardsRequest, value: Names) =
            { state with CatShardsRequest.S = Option.Some value } : CatShardsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CatShardsRequest, value: Duration) =
            { state with CatShardsRequest.MasterTimeout = Option.Some value } : CatShardsRequest

    let catShardsRequest = CatShardsRequestBuilder()

    type CatSnapshotsRequest = {
        Repository: Names
        IgnoreUnavailable: bool option
        H: TypesCatSnapshotsColumns option
        S: Names option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: CatSnapshotsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cat/snapshots/{request.Repository}"
                let queryParams =
                    [
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", string v)
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
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

    module CatSnapshotsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatSnapshotsRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatSnapshotsRequest.ToRequest request

    type CatSnapshotsRequestBuilder() =
        member _.Yield(_: unit) : CatSnapshotsRequest =
            {
                CatSnapshotsRequest.Repository = Unchecked.defaultof<Names>
                CatSnapshotsRequest.IgnoreUnavailable = Option.None
                CatSnapshotsRequest.H = Option.None
                CatSnapshotsRequest.S = Option.None
                CatSnapshotsRequest.MasterTimeout = Option.None
            } : CatSnapshotsRequest

        [<CustomOperation("repository")>]
        member _.Repository(state: CatSnapshotsRequest, value: Names) =
            { state with CatSnapshotsRequest.Repository = value } : CatSnapshotsRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: CatSnapshotsRequest, value: bool) =
            { state with CatSnapshotsRequest.IgnoreUnavailable = Option.Some value } : CatSnapshotsRequest

        [<CustomOperation("h")>]
        member _.H(state: CatSnapshotsRequest, value: TypesCatSnapshotsColumns) =
            { state with CatSnapshotsRequest.H = Option.Some value } : CatSnapshotsRequest

        [<CustomOperation("s")>]
        member _.S(state: CatSnapshotsRequest, value: Names) =
            { state with CatSnapshotsRequest.S = Option.Some value } : CatSnapshotsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CatSnapshotsRequest, value: Duration) =
            { state with CatSnapshotsRequest.MasterTimeout = Option.Some value } : CatSnapshotsRequest

    let catSnapshotsRequest = CatSnapshotsRequestBuilder()

    type CatTasksRequest = {
        Actions: string array option
        Detailed: bool option
        Nodes: string array option
        ParentTaskId: string option
        H: TypesCatTasksColumns option
        S: Names option
        Timeout: Duration option
        WaitForCompletion: bool option
    } with
        static member ToRequest(request: CatTasksRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_cat/tasks"
                let queryParams =
                    [
                        request.Actions |> Option.map (fun v -> "actions", string v)
                        request.Detailed |> Option.map (fun v -> "detailed", string v)
                        request.Nodes |> Option.map (fun v -> "nodes", string v)
                        request.ParentTaskId |> Option.map (fun v -> "parent_task_id", string v)
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                        request.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", string v)
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

    module CatTasksRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatTasksRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatTasksRequest.ToRequest request

    type CatTasksRequestBuilder() =
        member _.Yield(_: unit) : CatTasksRequest =
            {
                CatTasksRequest.Actions = Option.None
                CatTasksRequest.Detailed = Option.None
                CatTasksRequest.Nodes = Option.None
                CatTasksRequest.ParentTaskId = Option.None
                CatTasksRequest.H = Option.None
                CatTasksRequest.S = Option.None
                CatTasksRequest.Timeout = Option.None
                CatTasksRequest.WaitForCompletion = Option.None
            } : CatTasksRequest

        [<CustomOperation("actions")>]
        member _.Actions(state: CatTasksRequest, value: string array) =
            { state with CatTasksRequest.Actions = Option.Some value } : CatTasksRequest

        [<CustomOperation("detailed")>]
        member _.Detailed(state: CatTasksRequest, value: bool) =
            { state with CatTasksRequest.Detailed = Option.Some value } : CatTasksRequest

        [<CustomOperation("nodes")>]
        member _.Nodes(state: CatTasksRequest, value: string array) =
            { state with CatTasksRequest.Nodes = Option.Some value } : CatTasksRequest

        [<CustomOperation("parent_task_id")>]
        member _.ParentTaskId(state: CatTasksRequest, value: string) =
            { state with CatTasksRequest.ParentTaskId = Option.Some value } : CatTasksRequest

        [<CustomOperation("h")>]
        member _.H(state: CatTasksRequest, value: TypesCatTasksColumns) =
            { state with CatTasksRequest.H = Option.Some value } : CatTasksRequest

        [<CustomOperation("s")>]
        member _.S(state: CatTasksRequest, value: Names) =
            { state with CatTasksRequest.S = Option.Some value } : CatTasksRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: CatTasksRequest, value: Duration) =
            { state with CatTasksRequest.Timeout = Option.Some value } : CatTasksRequest

        [<CustomOperation("wait_for_completion")>]
        member _.WaitForCompletion(state: CatTasksRequest, value: bool) =
            { state with CatTasksRequest.WaitForCompletion = Option.Some value } : CatTasksRequest

    let catTasksRequest = CatTasksRequestBuilder()

    type CatTemplatesRequest = {
        Name: Name
        H: TypesCatTemplatesColumns option
        S: Names option
        Local: bool option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: CatTemplatesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cat/templates/{request.Name}"
                let queryParams =
                    [
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
                        request.Local |> Option.map (fun v -> "local", string v)
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

    module CatTemplatesRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatTemplatesRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatTemplatesRequest.ToRequest request

    type CatTemplatesRequestBuilder() =
        member _.Yield(_: unit) : CatTemplatesRequest =
            {
                CatTemplatesRequest.Name = Unchecked.defaultof<Name>
                CatTemplatesRequest.H = Option.None
                CatTemplatesRequest.S = Option.None
                CatTemplatesRequest.Local = Option.None
                CatTemplatesRequest.MasterTimeout = Option.None
            } : CatTemplatesRequest

        [<CustomOperation("name")>]
        member _.Name(state: CatTemplatesRequest, value: Name) =
            { state with CatTemplatesRequest.Name = value } : CatTemplatesRequest

        [<CustomOperation("h")>]
        member _.H(state: CatTemplatesRequest, value: TypesCatTemplatesColumns) =
            { state with CatTemplatesRequest.H = Option.Some value } : CatTemplatesRequest

        [<CustomOperation("s")>]
        member _.S(state: CatTemplatesRequest, value: Names) =
            { state with CatTemplatesRequest.S = Option.Some value } : CatTemplatesRequest

        [<CustomOperation("local")>]
        member _.Local(state: CatTemplatesRequest, value: bool) =
            { state with CatTemplatesRequest.Local = Option.Some value } : CatTemplatesRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CatTemplatesRequest, value: Duration) =
            { state with CatTemplatesRequest.MasterTimeout = Option.Some value } : CatTemplatesRequest

    let catTemplatesRequest = CatTemplatesRequestBuilder()

    type CatThreadPoolRequest = {
        ThreadPoolPatterns: Names
        H: TypesCatThreadPoolColumns option
        S: Names option
        Local: bool option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: CatThreadPoolRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cat/thread_pool/{request.ThreadPoolPatterns}"
                let queryParams =
                    [
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
                        request.Local |> Option.map (fun v -> "local", string v)
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

    module CatThreadPoolRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatThreadPoolRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatThreadPoolRequest.ToRequest request

    type CatThreadPoolRequestBuilder() =
        member _.Yield(_: unit) : CatThreadPoolRequest =
            {
                CatThreadPoolRequest.ThreadPoolPatterns = Unchecked.defaultof<Names>
                CatThreadPoolRequest.H = Option.None
                CatThreadPoolRequest.S = Option.None
                CatThreadPoolRequest.Local = Option.None
                CatThreadPoolRequest.MasterTimeout = Option.None
            } : CatThreadPoolRequest

        [<CustomOperation("thread_pool_patterns")>]
        member _.ThreadPoolPatterns(state: CatThreadPoolRequest, value: Names) =
            { state with CatThreadPoolRequest.ThreadPoolPatterns = value } : CatThreadPoolRequest

        [<CustomOperation("h")>]
        member _.H(state: CatThreadPoolRequest, value: TypesCatThreadPoolColumns) =
            { state with CatThreadPoolRequest.H = Option.Some value } : CatThreadPoolRequest

        [<CustomOperation("s")>]
        member _.S(state: CatThreadPoolRequest, value: Names) =
            { state with CatThreadPoolRequest.S = Option.Some value } : CatThreadPoolRequest

        [<CustomOperation("local")>]
        member _.Local(state: CatThreadPoolRequest, value: bool) =
            { state with CatThreadPoolRequest.Local = Option.Some value } : CatThreadPoolRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CatThreadPoolRequest, value: Duration) =
            { state with CatThreadPoolRequest.MasterTimeout = Option.Some value } : CatThreadPoolRequest

    let catThreadPoolRequest = CatThreadPoolRequestBuilder()

    type CatTransformsRequest = {
        TransformId: Id
        AllowNoMatch: bool option
        From: float option
        H: TypesCatTransformColumns option
        S: TypesCatTransformColumns option
        Size: float option
    } with
        static member ToRequest(request: CatTransformsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cat/transforms/{request.TransformId}"
                let queryParams =
                    [
                        request.AllowNoMatch |> Option.map (fun v -> "allow_no_match", string v)
                        request.From |> Option.map (fun v -> "from", string v)
                        request.H |> Option.map (fun v -> "h", string v)
                        request.S |> Option.map (fun v -> "s", string v)
                        request.Size |> Option.map (fun v -> "size", string v)
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

    module CatTransformsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CatTransformsRequest) : Result<Fes.Http.RequestMsg, exn> =
            CatTransformsRequest.ToRequest request

    type CatTransformsRequestBuilder() =
        member _.Yield(_: unit) : CatTransformsRequest =
            {
                CatTransformsRequest.TransformId = Unchecked.defaultof<Id>
                CatTransformsRequest.AllowNoMatch = Option.None
                CatTransformsRequest.From = Option.None
                CatTransformsRequest.H = Option.None
                CatTransformsRequest.S = Option.None
                CatTransformsRequest.Size = Option.None
            } : CatTransformsRequest

        [<CustomOperation("transform_id")>]
        member _.TransformId(state: CatTransformsRequest, value: Id) =
            { state with CatTransformsRequest.TransformId = value } : CatTransformsRequest

        [<CustomOperation("allow_no_match")>]
        member _.AllowNoMatch(state: CatTransformsRequest, value: bool) =
            { state with CatTransformsRequest.AllowNoMatch = Option.Some value } : CatTransformsRequest

        [<CustomOperation("from")>]
        member _.From(state: CatTransformsRequest, value: float) =
            { state with CatTransformsRequest.From = Option.Some value } : CatTransformsRequest

        [<CustomOperation("h")>]
        member _.H(state: CatTransformsRequest, value: TypesCatTransformColumns) =
            { state with CatTransformsRequest.H = Option.Some value } : CatTransformsRequest

        [<CustomOperation("s")>]
        member _.S(state: CatTransformsRequest, value: TypesCatTransformColumns) =
            { state with CatTransformsRequest.S = Option.Some value } : CatTransformsRequest

        [<CustomOperation("size")>]
        member _.Size(state: CatTransformsRequest, value: float) =
            { state with CatTransformsRequest.Size = Option.Some value } : CatTransformsRequest

    let catTransformsRequest = CatTransformsRequestBuilder()


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module CatOperations =

    type CatAliasesRequest = {
        Name: Types.Names
        H: Types.CatAliasesColumns option
        S: Types.Names option
        ExpandWildcards: Types.ExpandWildcards option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: CatAliasesRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/aliases/{req.Name}"
            let queryParams =
                [
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                    req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatAliasesResponse = Types.AliasesRecord list

    type CatAliasesRequestBuilder() =
        member _.Yield(_: unit) : CatAliasesRequest =
            {
                Name = Unchecked.defaultof<_>
                H = None
                S = None
                ExpandWildcards = None
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: CatAliasesRequest, value: Types.Names) =
            { state with Name = value }

        [<CustomOperation("h")>]
        member _.H(state: CatAliasesRequest, value: Types.CatAliasesColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatAliasesRequest, value: Types.Names) =
            { state with S = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: CatAliasesRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CatAliasesRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let catAliasesRequest = CatAliasesRequestBuilder()

    module Aliases =
        let withH (value: Types.CatAliasesColumns) (req: CatAliasesRequest) =
            { req with H = Some value }
        let withS (value: Types.Names) (req: CatAliasesRequest) =
            { req with S = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: CatAliasesRequest) =
            { req with ExpandWildcards = Some value }
        let withMasterTimeout (value: Types.Duration) (req: CatAliasesRequest) =
            { req with MasterTimeout = Some value }

    type CatAllocationRequest = {
        NodeId: Types.NodeIds
        H: Types.CatAllocationColumns option
        S: Types.Names option
        Local: bool option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: CatAllocationRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/allocation/{req.NodeId}"
            let queryParams =
                [
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                    req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatAllocationResponse = Types.AllocationRecord list

    type CatAllocationRequestBuilder() =
        member _.Yield(_: unit) : CatAllocationRequest =
            {
                NodeId = Unchecked.defaultof<_>
                H = None
                S = None
                Local = None
                MasterTimeout = None
            }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: CatAllocationRequest, value: Types.NodeIds) =
            { state with NodeId = value }

        [<CustomOperation("h")>]
        member _.H(state: CatAllocationRequest, value: Types.CatAllocationColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatAllocationRequest, value: Types.Names) =
            { state with S = Some value }

        [<CustomOperation("local")>]
        member _.Local(state: CatAllocationRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CatAllocationRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let catAllocationRequest = CatAllocationRequestBuilder()

    module Allocation =
        let withH (value: Types.CatAllocationColumns) (req: CatAllocationRequest) =
            { req with H = Some value }
        let withS (value: Types.Names) (req: CatAllocationRequest) =
            { req with S = Some value }
        let withLocal (value: bool) (req: CatAllocationRequest) =
            { req with Local = Some value }
        let withMasterTimeout (value: Types.Duration) (req: CatAllocationRequest) =
            { req with MasterTimeout = Some value }

    type CatCircuitBreakerRequest = {
        CircuitBreakerPatterns: System.Text.Json.JsonElement
        H: Types.CatCircuitBreakerColumns option
        S: Types.Names option
        Local: bool option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: CatCircuitBreakerRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/circuit_breaker/{req.CircuitBreakerPatterns}"
            let queryParams =
                [
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                    req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatCircuitBreakerResponse = Types.CircuitBreakerRecord list

    type CatCircuitBreakerRequestBuilder() =
        member _.Yield(_: unit) : CatCircuitBreakerRequest =
            {
                CircuitBreakerPatterns = Unchecked.defaultof<_>
                H = None
                S = None
                Local = None
                MasterTimeout = None
            }

        [<CustomOperation("circuitBreakerPatterns")>]
        member _.CircuitBreakerPatterns(state: CatCircuitBreakerRequest, value: System.Text.Json.JsonElement) =
            { state with CircuitBreakerPatterns = value }

        [<CustomOperation("h")>]
        member _.H(state: CatCircuitBreakerRequest, value: Types.CatCircuitBreakerColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatCircuitBreakerRequest, value: Types.Names) =
            { state with S = Some value }

        [<CustomOperation("local")>]
        member _.Local(state: CatCircuitBreakerRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CatCircuitBreakerRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let catCircuitBreakerRequest = CatCircuitBreakerRequestBuilder()

    module CircuitBreaker =
        let withH (value: Types.CatCircuitBreakerColumns) (req: CatCircuitBreakerRequest) =
            { req with H = Some value }
        let withS (value: Types.Names) (req: CatCircuitBreakerRequest) =
            { req with S = Some value }
        let withLocal (value: bool) (req: CatCircuitBreakerRequest) =
            { req with Local = Some value }
        let withMasterTimeout (value: Types.Duration) (req: CatCircuitBreakerRequest) =
            { req with MasterTimeout = Some value }

    type CatComponentTemplatesRequest = {
        Name: string
        H: Types.CatComponentColumns option
        S: Types.Names option
        Local: bool option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: CatComponentTemplatesRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/component_templates/{req.Name}"
            let queryParams =
                [
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                    req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatComponentTemplatesResponse = Types.CatComponentTemplatesComponentTemplate list

    type CatComponentTemplatesRequestBuilder() =
        member _.Yield(_: unit) : CatComponentTemplatesRequest =
            {
                Name = Unchecked.defaultof<_>
                H = None
                S = None
                Local = None
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: CatComponentTemplatesRequest, value: string) =
            { state with Name = value }

        [<CustomOperation("h")>]
        member _.H(state: CatComponentTemplatesRequest, value: Types.CatComponentColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatComponentTemplatesRequest, value: Types.Names) =
            { state with S = Some value }

        [<CustomOperation("local")>]
        member _.Local(state: CatComponentTemplatesRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CatComponentTemplatesRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let catComponentTemplatesRequest = CatComponentTemplatesRequestBuilder()

    module ComponentTemplates =
        let withH (value: Types.CatComponentColumns) (req: CatComponentTemplatesRequest) =
            { req with H = Some value }
        let withS (value: Types.Names) (req: CatComponentTemplatesRequest) =
            { req with S = Some value }
        let withLocal (value: bool) (req: CatComponentTemplatesRequest) =
            { req with Local = Some value }
        let withMasterTimeout (value: Types.Duration) (req: CatComponentTemplatesRequest) =
            { req with MasterTimeout = Some value }

    type CatCountRequest = {
        Index: Types.Indices
        H: Types.CatCountColumns option
        S: Types.Names option
        [<System.Text.Json.Serialization.JsonPropertyName("project_routing")>]
        ProjectRouting: Types.ProjectRouting option
    }

        with
        static member ToEndpoint(req: CatCountRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/count/{req.Index}"
            let queryParams =
                [
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type CatCountResponse = Types.CountRecord list

    type CatCountRequestBuilder() =
        member _.Yield(_: unit) : CatCountRequest =
            {
                Index = Unchecked.defaultof<_>
                H = None
                S = None
                ProjectRouting = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: CatCountRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("h")>]
        member _.H(state: CatCountRequest, value: Types.CatCountColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatCountRequest, value: Types.Names) =
            { state with S = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: CatCountRequest, value: Types.ProjectRouting) =
            { state with ProjectRouting = Some value }

    let catCountRequest = CatCountRequestBuilder()

    module Count =
        let withH (value: Types.CatCountColumns) (req: CatCountRequest) =
            { req with H = Some value }
        let withS (value: Types.Names) (req: CatCountRequest) =
            { req with S = Some value }
        let withProjectRouting (value: Types.ProjectRouting) (req: CatCountRequest) =
            { req with ProjectRouting = Some value }

    type CatFielddataRequest = {
        Fields: Types.Fields
        queryFields: Types.Fields option
        H: Types.CatFieldDataColumns option
        S: Types.Names option
    }

        with
        static member ToEndpoint(req: CatFielddataRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/fielddata/{req.Fields}"
            let queryParams =
                [
                    req.queryFields |> Option.map (fun v -> "fields", Fes.Http.toQueryValue v)
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatFielddataResponse = Types.FielddataRecord list

    type CatFielddataRequestBuilder() =
        member _.Yield(_: unit) : CatFielddataRequest =
            {
                Fields = Unchecked.defaultof<_>
                queryFields = None
                H = None
                S = None
            }

        [<CustomOperation("fields")>]
        member _.Fields(state: CatFielddataRequest, value: Types.Fields) =
            { state with Fields = value }

        [<CustomOperation("queryFields")>]
        member _.QueryFields(state: CatFielddataRequest, value: Types.Fields) =
            { state with queryFields = Some value }

        [<CustomOperation("h")>]
        member _.H(state: CatFielddataRequest, value: Types.CatFieldDataColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatFielddataRequest, value: Types.Names) =
            { state with S = Some value }

    let catFielddataRequest = CatFielddataRequestBuilder()

    module Fielddata =
        let withFields (value: Types.Fields) (req: CatFielddataRequest) =
            { req with queryFields = Some value }
        let withH (value: Types.CatFieldDataColumns) (req: CatFielddataRequest) =
            { req with H = Some value }
        let withS (value: Types.Names) (req: CatFielddataRequest) =
            { req with S = Some value }

    type CatHealthRequest = {
        Ts: bool option
        H: Types.CatHealthColumns option
        S: Types.Names option
    }

        with
        static member ToEndpoint(req: CatHealthRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/health"
            let queryParams =
                [
                    req.Ts |> Option.map (fun v -> "ts", Fes.Http.toQueryValue v)
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatHealthResponse = Types.HealthRecord list

    type CatHealthRequestBuilder() =
        member _.Yield(_: unit) : CatHealthRequest =
            {
                Ts = None
                H = None
                S = None
            }

        [<CustomOperation("ts")>]
        member _.Ts(state: CatHealthRequest, value: bool) =
            { state with Ts = Some value }

        [<CustomOperation("h")>]
        member _.H(state: CatHealthRequest, value: Types.CatHealthColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatHealthRequest, value: Types.Names) =
            { state with S = Some value }

    let catHealthRequest = CatHealthRequestBuilder()

    module Health =
        let withTs (value: bool) (req: CatHealthRequest) =
            { req with Ts = Some value }
        let withH (value: Types.CatHealthColumns) (req: CatHealthRequest) =
            { req with H = Some value }
        let withS (value: Types.Names) (req: CatHealthRequest) =
            { req with S = Some value }

    type CatHelpRequest = | CatHelpRequest

        with
        static member ToEndpoint(req: CatHelpRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatHelpResponse = System.Text.Json.JsonElement

    type CatIndicesRequest = {
        Index: Types.Indices
        ExpandWildcards: Types.ExpandWildcards option
        Health: Types.HealthStatus option
        IncludeUnloadedSegments: bool option
        Pri: bool option
        MasterTimeout: Types.Duration option
        H: Types.CatIndicesColumns option
        S: Types.Names option
    }

        with
        static member ToEndpoint(req: CatIndicesRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/indices/{req.Index}"
            let queryParams =
                [
                    req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                    req.Health |> Option.map (fun v -> "health", Fes.Http.toQueryValue v)
                    req.IncludeUnloadedSegments |> Option.map (fun v -> "include_unloaded_segments", Fes.Http.toQueryValue v)
                    req.Pri |> Option.map (fun v -> "pri", Fes.Http.toQueryValue v)
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatIndicesResponse = Types.IndicesRecord list

    type CatIndicesRequestBuilder() =
        member _.Yield(_: unit) : CatIndicesRequest =
            {
                Index = Unchecked.defaultof<_>
                ExpandWildcards = None
                Health = None
                IncludeUnloadedSegments = None
                Pri = None
                MasterTimeout = None
                H = None
                S = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: CatIndicesRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: CatIndicesRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("health")>]
        member _.Health(state: CatIndicesRequest, value: Types.HealthStatus) =
            { state with Health = Some value }

        [<CustomOperation("includeUnloadedSegments")>]
        member _.IncludeUnloadedSegments(state: CatIndicesRequest, value: bool) =
            { state with IncludeUnloadedSegments = Some value }

        [<CustomOperation("pri")>]
        member _.Pri(state: CatIndicesRequest, value: bool) =
            { state with Pri = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CatIndicesRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("h")>]
        member _.H(state: CatIndicesRequest, value: Types.CatIndicesColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatIndicesRequest, value: Types.Names) =
            { state with S = Some value }

    let catIndicesRequest = CatIndicesRequestBuilder()

    module Indices =
        let withExpandWildcards (value: Types.ExpandWildcards) (req: CatIndicesRequest) =
            { req with ExpandWildcards = Some value }
        let withHealth (value: Types.HealthStatus) (req: CatIndicesRequest) =
            { req with Health = Some value }
        let withIncludeUnloadedSegments (value: bool) (req: CatIndicesRequest) =
            { req with IncludeUnloadedSegments = Some value }
        let withPri (value: bool) (req: CatIndicesRequest) =
            { req with Pri = Some value }
        let withMasterTimeout (value: Types.Duration) (req: CatIndicesRequest) =
            { req with MasterTimeout = Some value }
        let withH (value: Types.CatIndicesColumns) (req: CatIndicesRequest) =
            { req with H = Some value }
        let withS (value: Types.Names) (req: CatIndicesRequest) =
            { req with S = Some value }

    type CatMasterRequest = {
        H: Types.CatMasterColumns option
        S: Types.Names option
        Local: bool option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: CatMasterRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/master"
            let queryParams =
                [
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                    req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatMasterResponse = Types.MasterRecord list

    type CatMasterRequestBuilder() =
        member _.Yield(_: unit) : CatMasterRequest =
            {
                H = None
                S = None
                Local = None
                MasterTimeout = None
            }

        [<CustomOperation("h")>]
        member _.H(state: CatMasterRequest, value: Types.CatMasterColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatMasterRequest, value: Types.Names) =
            { state with S = Some value }

        [<CustomOperation("local")>]
        member _.Local(state: CatMasterRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CatMasterRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let catMasterRequest = CatMasterRequestBuilder()

    module Master =
        let withH (value: Types.CatMasterColumns) (req: CatMasterRequest) =
            { req with H = Some value }
        let withS (value: Types.Names) (req: CatMasterRequest) =
            { req with S = Some value }
        let withLocal (value: bool) (req: CatMasterRequest) =
            { req with Local = Some value }
        let withMasterTimeout (value: Types.Duration) (req: CatMasterRequest) =
            { req with MasterTimeout = Some value }

    type CatMlDataFrameAnalyticsRequest = {
        Id: Types.Id
        AllowNoMatch: bool option
        H: Types.CatDfaColumns option
        S: Types.CatDfaColumns option
    }

        with
        static member ToEndpoint(req: CatMlDataFrameAnalyticsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/ml/data_frame/analytics/{req.Id}"
            let queryParams =
                [
                    req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatMlDataFrameAnalyticsResponse = Types.DataFrameAnalyticsRecord list

    type CatMlDataFrameAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : CatMlDataFrameAnalyticsRequest =
            {
                Id = Unchecked.defaultof<_>
                AllowNoMatch = None
                H = None
                S = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: CatMlDataFrameAnalyticsRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: CatMlDataFrameAnalyticsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("h")>]
        member _.H(state: CatMlDataFrameAnalyticsRequest, value: Types.CatDfaColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatMlDataFrameAnalyticsRequest, value: Types.CatDfaColumns) =
            { state with S = Some value }

    let catMlDataFrameAnalyticsRequest = CatMlDataFrameAnalyticsRequestBuilder()

    module MlDataFrameAnalytics =
        let withAllowNoMatch (value: bool) (req: CatMlDataFrameAnalyticsRequest) =
            { req with AllowNoMatch = Some value }
        let withH (value: Types.CatDfaColumns) (req: CatMlDataFrameAnalyticsRequest) =
            { req with H = Some value }
        let withS (value: Types.CatDfaColumns) (req: CatMlDataFrameAnalyticsRequest) =
            { req with S = Some value }

    type CatMlDatafeedsRequest = {
        DatafeedId: Types.Id
        AllowNoMatch: bool option
        H: Types.CatDatafeedColumns option
        S: Types.CatDatafeedColumns option
    }

        with
        static member ToEndpoint(req: CatMlDatafeedsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/ml/datafeeds/{req.DatafeedId}"
            let queryParams =
                [
                    req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatMlDatafeedsResponse = Types.DatafeedsRecord list

    type CatMlDatafeedsRequestBuilder() =
        member _.Yield(_: unit) : CatMlDatafeedsRequest =
            {
                DatafeedId = Unchecked.defaultof<_>
                AllowNoMatch = None
                H = None
                S = None
            }

        [<CustomOperation("datafeedId")>]
        member _.DatafeedId(state: CatMlDatafeedsRequest, value: Types.Id) =
            { state with DatafeedId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: CatMlDatafeedsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("h")>]
        member _.H(state: CatMlDatafeedsRequest, value: Types.CatDatafeedColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatMlDatafeedsRequest, value: Types.CatDatafeedColumns) =
            { state with S = Some value }

    let catMlDatafeedsRequest = CatMlDatafeedsRequestBuilder()

    module MlDatafeeds =
        let withAllowNoMatch (value: bool) (req: CatMlDatafeedsRequest) =
            { req with AllowNoMatch = Some value }
        let withH (value: Types.CatDatafeedColumns) (req: CatMlDatafeedsRequest) =
            { req with H = Some value }
        let withS (value: Types.CatDatafeedColumns) (req: CatMlDatafeedsRequest) =
            { req with S = Some value }

    type CatMlJobsRequest = {
        JobId: Types.Id
        AllowNoMatch: bool option
        H: Types.CatAnomalyDetectorColumns option
        S: Types.CatAnomalyDetectorColumns option
    }

        with
        static member ToEndpoint(req: CatMlJobsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/ml/anomaly_detectors/{req.JobId}"
            let queryParams =
                [
                    req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatMlJobsResponse = Types.JobsRecord list

    type CatMlJobsRequestBuilder() =
        member _.Yield(_: unit) : CatMlJobsRequest =
            {
                JobId = Unchecked.defaultof<_>
                AllowNoMatch = None
                H = None
                S = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: CatMlJobsRequest, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: CatMlJobsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("h")>]
        member _.H(state: CatMlJobsRequest, value: Types.CatAnomalyDetectorColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatMlJobsRequest, value: Types.CatAnomalyDetectorColumns) =
            { state with S = Some value }

    let catMlJobsRequest = CatMlJobsRequestBuilder()

    module MlJobs =
        let withAllowNoMatch (value: bool) (req: CatMlJobsRequest) =
            { req with AllowNoMatch = Some value }
        let withH (value: Types.CatAnomalyDetectorColumns) (req: CatMlJobsRequest) =
            { req with H = Some value }
        let withS (value: Types.CatAnomalyDetectorColumns) (req: CatMlJobsRequest) =
            { req with S = Some value }

    type CatMlTrainedModelsRequest = {
        ModelId: Types.Id
        AllowNoMatch: bool option
        H: Types.CatTrainedModelsColumns option
        S: Types.CatTrainedModelsColumns option
        From: Types.Integer option
        Size: Types.Integer option
    }

        with
        static member ToEndpoint(req: CatMlTrainedModelsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/ml/trained_models/{req.ModelId}"
            let queryParams =
                [
                    req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                    req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                    req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatMlTrainedModelsResponse = Types.TrainedModelsRecord list

    type CatMlTrainedModelsRequestBuilder() =
        member _.Yield(_: unit) : CatMlTrainedModelsRequest =
            {
                ModelId = Unchecked.defaultof<_>
                AllowNoMatch = None
                H = None
                S = None
                From = None
                Size = None
            }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: CatMlTrainedModelsRequest, value: Types.Id) =
            { state with ModelId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: CatMlTrainedModelsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("h")>]
        member _.H(state: CatMlTrainedModelsRequest, value: Types.CatTrainedModelsColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatMlTrainedModelsRequest, value: Types.CatTrainedModelsColumns) =
            { state with S = Some value }

        [<CustomOperation("from")>]
        member _.From(state: CatMlTrainedModelsRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: CatMlTrainedModelsRequest, value: Types.Integer) =
            { state with Size = Some value }

    let catMlTrainedModelsRequest = CatMlTrainedModelsRequestBuilder()

    module MlTrainedModels =
        let withAllowNoMatch (value: bool) (req: CatMlTrainedModelsRequest) =
            { req with AllowNoMatch = Some value }
        let withH (value: Types.CatTrainedModelsColumns) (req: CatMlTrainedModelsRequest) =
            { req with H = Some value }
        let withS (value: Types.CatTrainedModelsColumns) (req: CatMlTrainedModelsRequest) =
            { req with S = Some value }
        let withFrom (value: Types.Integer) (req: CatMlTrainedModelsRequest) =
            { req with From = Some value }
        let withSize (value: Types.Integer) (req: CatMlTrainedModelsRequest) =
            { req with Size = Some value }

    type CatNodeattrsRequest = {
        H: Types.CatNodeattrsColumns option
        S: Types.Names option
        Local: bool option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: CatNodeattrsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/nodeattrs"
            let queryParams =
                [
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                    req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatNodeattrsResponse = Types.NodeAttributesRecord list

    type CatNodeattrsRequestBuilder() =
        member _.Yield(_: unit) : CatNodeattrsRequest =
            {
                H = None
                S = None
                Local = None
                MasterTimeout = None
            }

        [<CustomOperation("h")>]
        member _.H(state: CatNodeattrsRequest, value: Types.CatNodeattrsColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatNodeattrsRequest, value: Types.Names) =
            { state with S = Some value }

        [<CustomOperation("local")>]
        member _.Local(state: CatNodeattrsRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CatNodeattrsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let catNodeattrsRequest = CatNodeattrsRequestBuilder()

    module Nodeattrs =
        let withH (value: Types.CatNodeattrsColumns) (req: CatNodeattrsRequest) =
            { req with H = Some value }
        let withS (value: Types.Names) (req: CatNodeattrsRequest) =
            { req with S = Some value }
        let withLocal (value: bool) (req: CatNodeattrsRequest) =
            { req with Local = Some value }
        let withMasterTimeout (value: Types.Duration) (req: CatNodeattrsRequest) =
            { req with MasterTimeout = Some value }

    type CatNodesRequest = {
        FullId: bool option
        IncludeUnloadedSegments: bool option
        H: Types.CatNodeColumns option
        S: Types.Names option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: CatNodesRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/nodes"
            let queryParams =
                [
                    req.FullId |> Option.map (fun v -> "full_id", Fes.Http.toQueryValue v)
                    req.IncludeUnloadedSegments |> Option.map (fun v -> "include_unloaded_segments", Fes.Http.toQueryValue v)
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatNodesResponse = Types.NodesRecord list

    type CatNodesRequestBuilder() =
        member _.Yield(_: unit) : CatNodesRequest =
            {
                FullId = None
                IncludeUnloadedSegments = None
                H = None
                S = None
                MasterTimeout = None
            }

        [<CustomOperation("fullId")>]
        member _.FullId(state: CatNodesRequest, value: bool) =
            { state with FullId = Some value }

        [<CustomOperation("includeUnloadedSegments")>]
        member _.IncludeUnloadedSegments(state: CatNodesRequest, value: bool) =
            { state with IncludeUnloadedSegments = Some value }

        [<CustomOperation("h")>]
        member _.H(state: CatNodesRequest, value: Types.CatNodeColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatNodesRequest, value: Types.Names) =
            { state with S = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CatNodesRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let catNodesRequest = CatNodesRequestBuilder()

    module Nodes =
        let withFullId (value: bool) (req: CatNodesRequest) =
            { req with FullId = Some value }
        let withIncludeUnloadedSegments (value: bool) (req: CatNodesRequest) =
            { req with IncludeUnloadedSegments = Some value }
        let withH (value: Types.CatNodeColumns) (req: CatNodesRequest) =
            { req with H = Some value }
        let withS (value: Types.Names) (req: CatNodesRequest) =
            { req with S = Some value }
        let withMasterTimeout (value: Types.Duration) (req: CatNodesRequest) =
            { req with MasterTimeout = Some value }

    type CatPendingTasksRequest = {
        H: Types.CatPendingTasksColumns option
        S: Types.Names option
        Local: bool option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: CatPendingTasksRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/pending_tasks"
            let queryParams =
                [
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                    req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatPendingTasksResponse = Types.PendingTasksRecord list

    type CatPendingTasksRequestBuilder() =
        member _.Yield(_: unit) : CatPendingTasksRequest =
            {
                H = None
                S = None
                Local = None
                MasterTimeout = None
            }

        [<CustomOperation("h")>]
        member _.H(state: CatPendingTasksRequest, value: Types.CatPendingTasksColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatPendingTasksRequest, value: Types.Names) =
            { state with S = Some value }

        [<CustomOperation("local")>]
        member _.Local(state: CatPendingTasksRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CatPendingTasksRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let catPendingTasksRequest = CatPendingTasksRequestBuilder()

    module PendingTasks =
        let withH (value: Types.CatPendingTasksColumns) (req: CatPendingTasksRequest) =
            { req with H = Some value }
        let withS (value: Types.Names) (req: CatPendingTasksRequest) =
            { req with S = Some value }
        let withLocal (value: bool) (req: CatPendingTasksRequest) =
            { req with Local = Some value }
        let withMasterTimeout (value: Types.Duration) (req: CatPendingTasksRequest) =
            { req with MasterTimeout = Some value }

    type CatPluginsRequest = {
        H: Types.CatPluginsColumns option
        S: Types.Names option
        IncludeBootstrap: bool option
        Local: bool option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: CatPluginsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/plugins"
            let queryParams =
                [
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                    req.IncludeBootstrap |> Option.map (fun v -> "include_bootstrap", Fes.Http.toQueryValue v)
                    req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatPluginsResponse = Types.PluginsRecord list

    type CatPluginsRequestBuilder() =
        member _.Yield(_: unit) : CatPluginsRequest =
            {
                H = None
                S = None
                IncludeBootstrap = None
                Local = None
                MasterTimeout = None
            }

        [<CustomOperation("h")>]
        member _.H(state: CatPluginsRequest, value: Types.CatPluginsColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatPluginsRequest, value: Types.Names) =
            { state with S = Some value }

        [<CustomOperation("includeBootstrap")>]
        member _.IncludeBootstrap(state: CatPluginsRequest, value: bool) =
            { state with IncludeBootstrap = Some value }

        [<CustomOperation("local")>]
        member _.Local(state: CatPluginsRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CatPluginsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let catPluginsRequest = CatPluginsRequestBuilder()

    module Plugins =
        let withH (value: Types.CatPluginsColumns) (req: CatPluginsRequest) =
            { req with H = Some value }
        let withS (value: Types.Names) (req: CatPluginsRequest) =
            { req with S = Some value }
        let withIncludeBootstrap (value: bool) (req: CatPluginsRequest) =
            { req with IncludeBootstrap = Some value }
        let withLocal (value: bool) (req: CatPluginsRequest) =
            { req with Local = Some value }
        let withMasterTimeout (value: Types.Duration) (req: CatPluginsRequest) =
            { req with MasterTimeout = Some value }

    type CatRecoveryRequest = {
        Index: Types.Indices
        ActiveOnly: bool option
        Detailed: bool option
        queryIndex: Types.Indices option
        H: Types.CatRecoveryColumns option
        S: Types.Names option
    }

        with
        static member ToEndpoint(req: CatRecoveryRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/recovery/{req.Index}"
            let queryParams =
                [
                    req.ActiveOnly |> Option.map (fun v -> "active_only", Fes.Http.toQueryValue v)
                    req.Detailed |> Option.map (fun v -> "detailed", Fes.Http.toQueryValue v)
                    req.queryIndex |> Option.map (fun v -> "index", Fes.Http.toQueryValue v)
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatRecoveryResponse = Types.RecoveryRecord list

    type CatRecoveryRequestBuilder() =
        member _.Yield(_: unit) : CatRecoveryRequest =
            {
                Index = Unchecked.defaultof<_>
                ActiveOnly = None
                Detailed = None
                queryIndex = None
                H = None
                S = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: CatRecoveryRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("activeOnly")>]
        member _.ActiveOnly(state: CatRecoveryRequest, value: bool) =
            { state with ActiveOnly = Some value }

        [<CustomOperation("detailed")>]
        member _.Detailed(state: CatRecoveryRequest, value: bool) =
            { state with Detailed = Some value }

        [<CustomOperation("queryIndex")>]
        member _.QueryIndex(state: CatRecoveryRequest, value: Types.Indices) =
            { state with queryIndex = Some value }

        [<CustomOperation("h")>]
        member _.H(state: CatRecoveryRequest, value: Types.CatRecoveryColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatRecoveryRequest, value: Types.Names) =
            { state with S = Some value }

    let catRecoveryRequest = CatRecoveryRequestBuilder()

    module Recovery =
        let withActiveOnly (value: bool) (req: CatRecoveryRequest) =
            { req with ActiveOnly = Some value }
        let withDetailed (value: bool) (req: CatRecoveryRequest) =
            { req with Detailed = Some value }
        let withIndex (value: Types.Indices) (req: CatRecoveryRequest) =
            { req with queryIndex = Some value }
        let withH (value: Types.CatRecoveryColumns) (req: CatRecoveryRequest) =
            { req with H = Some value }
        let withS (value: Types.Names) (req: CatRecoveryRequest) =
            { req with S = Some value }

    type CatRepositoriesRequest = {
        H: Types.Names option
        S: Types.Names option
        Local: bool option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: CatRepositoriesRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/repositories"
            let queryParams =
                [
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                    req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatRepositoriesResponse = Types.RepositoriesRecord list

    type CatRepositoriesRequestBuilder() =
        member _.Yield(_: unit) : CatRepositoriesRequest =
            {
                H = None
                S = None
                Local = None
                MasterTimeout = None
            }

        [<CustomOperation("h")>]
        member _.H(state: CatRepositoriesRequest, value: Types.Names) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatRepositoriesRequest, value: Types.Names) =
            { state with S = Some value }

        [<CustomOperation("local")>]
        member _.Local(state: CatRepositoriesRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CatRepositoriesRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let catRepositoriesRequest = CatRepositoriesRequestBuilder()

    module Repositories =
        let withH (value: Types.Names) (req: CatRepositoriesRequest) =
            { req with H = Some value }
        let withS (value: Types.Names) (req: CatRepositoriesRequest) =
            { req with S = Some value }
        let withLocal (value: bool) (req: CatRepositoriesRequest) =
            { req with Local = Some value }
        let withMasterTimeout (value: Types.Duration) (req: CatRepositoriesRequest) =
            { req with MasterTimeout = Some value }

    type CatSegmentsRequest = {
        Index: Types.Indices
        H: Types.CatSegmentsColumns option
        S: Types.Names option
        Local: bool option
        MasterTimeout: Types.Duration option
        ExpandWildcards: Types.ExpandWildcards option
        AllowNoIndices: bool option
        IgnoreThrottled: bool option
        IgnoreUnavailable: bool option
        AllowClosed: bool option
    }

        with
        static member ToEndpoint(req: CatSegmentsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/segments/{req.Index}"
            let queryParams =
                [
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                    req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                    req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                    req.IgnoreThrottled |> Option.map (fun v -> "ignore_throttled", Fes.Http.toQueryValue v)
                    req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                    req.AllowClosed |> Option.map (fun v -> "allow_closed", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatSegmentsResponse = Types.SegmentsRecord list

    type CatSegmentsRequestBuilder() =
        member _.Yield(_: unit) : CatSegmentsRequest =
            {
                Index = Unchecked.defaultof<_>
                H = None
                S = None
                Local = None
                MasterTimeout = None
                ExpandWildcards = None
                AllowNoIndices = None
                IgnoreThrottled = None
                IgnoreUnavailable = None
                AllowClosed = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: CatSegmentsRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("h")>]
        member _.H(state: CatSegmentsRequest, value: Types.CatSegmentsColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatSegmentsRequest, value: Types.Names) =
            { state with S = Some value }

        [<CustomOperation("local")>]
        member _.Local(state: CatSegmentsRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CatSegmentsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: CatSegmentsRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: CatSegmentsRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("ignoreThrottled")>]
        member _.IgnoreThrottled(state: CatSegmentsRequest, value: bool) =
            { state with IgnoreThrottled = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: CatSegmentsRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("allowClosed")>]
        member _.AllowClosed(state: CatSegmentsRequest, value: bool) =
            { state with AllowClosed = Some value }

    let catSegmentsRequest = CatSegmentsRequestBuilder()

    module Segments =
        let withH (value: Types.CatSegmentsColumns) (req: CatSegmentsRequest) =
            { req with H = Some value }
        let withS (value: Types.Names) (req: CatSegmentsRequest) =
            { req with S = Some value }
        let withLocal (value: bool) (req: CatSegmentsRequest) =
            { req with Local = Some value }
        let withMasterTimeout (value: Types.Duration) (req: CatSegmentsRequest) =
            { req with MasterTimeout = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: CatSegmentsRequest) =
            { req with ExpandWildcards = Some value }
        let withAllowNoIndices (value: bool) (req: CatSegmentsRequest) =
            { req with AllowNoIndices = Some value }
        let withIgnoreThrottled (value: bool) (req: CatSegmentsRequest) =
            { req with IgnoreThrottled = Some value }
        let withIgnoreUnavailable (value: bool) (req: CatSegmentsRequest) =
            { req with IgnoreUnavailable = Some value }
        let withAllowClosed (value: bool) (req: CatSegmentsRequest) =
            { req with AllowClosed = Some value }

    type CatShardsRequest = {
        Index: Types.Indices
        H: Types.CatShardColumns option
        S: Types.Names option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: CatShardsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/shards/{req.Index}"
            let queryParams =
                [
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatShardsResponse = Types.ShardsRecord list

    type CatShardsRequestBuilder() =
        member _.Yield(_: unit) : CatShardsRequest =
            {
                Index = Unchecked.defaultof<_>
                H = None
                S = None
                MasterTimeout = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: CatShardsRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("h")>]
        member _.H(state: CatShardsRequest, value: Types.CatShardColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatShardsRequest, value: Types.Names) =
            { state with S = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CatShardsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let catShardsRequest = CatShardsRequestBuilder()

    module Shards =
        let withH (value: Types.CatShardColumns) (req: CatShardsRequest) =
            { req with H = Some value }
        let withS (value: Types.Names) (req: CatShardsRequest) =
            { req with S = Some value }
        let withMasterTimeout (value: Types.Duration) (req: CatShardsRequest) =
            { req with MasterTimeout = Some value }

    type CatSnapshotsRequest = {
        Repository: Types.Names
        IgnoreUnavailable: bool option
        H: Types.CatSnapshotsColumns option
        S: Types.Names option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: CatSnapshotsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/snapshots/{req.Repository}"
            let queryParams =
                [
                    req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatSnapshotsResponse = Types.SnapshotsRecord list

    type CatSnapshotsRequestBuilder() =
        member _.Yield(_: unit) : CatSnapshotsRequest =
            {
                Repository = Unchecked.defaultof<_>
                IgnoreUnavailable = None
                H = None
                S = None
                MasterTimeout = None
            }

        [<CustomOperation("repository")>]
        member _.Repository(state: CatSnapshotsRequest, value: Types.Names) =
            { state with Repository = value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: CatSnapshotsRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("h")>]
        member _.H(state: CatSnapshotsRequest, value: Types.CatSnapshotsColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatSnapshotsRequest, value: Types.Names) =
            { state with S = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CatSnapshotsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let catSnapshotsRequest = CatSnapshotsRequestBuilder()

    module Snapshots =
        let withIgnoreUnavailable (value: bool) (req: CatSnapshotsRequest) =
            { req with IgnoreUnavailable = Some value }
        let withH (value: Types.CatSnapshotsColumns) (req: CatSnapshotsRequest) =
            { req with H = Some value }
        let withS (value: Types.Names) (req: CatSnapshotsRequest) =
            { req with S = Some value }
        let withMasterTimeout (value: Types.Duration) (req: CatSnapshotsRequest) =
            { req with MasterTimeout = Some value }

    type CatTasksRequest = {
        Actions: string list option
        Detailed: bool option
        Nodes: string list option
        ParentTaskId: string option
        H: Types.CatTasksColumns option
        S: Types.Names option
        Timeout: Types.Duration option
        WaitForCompletion: bool option
    }

        with
        static member ToEndpoint(req: CatTasksRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/tasks"
            let queryParams =
                [
                    req.Actions |> Option.map (fun v -> "actions", Fes.Http.toQueryValue v)
                    req.Detailed |> Option.map (fun v -> "detailed", Fes.Http.toQueryValue v)
                    req.Nodes |> Option.map (fun v -> "nodes", Fes.Http.toQueryValue v)
                    req.ParentTaskId |> Option.map (fun v -> "parent_task_id", Fes.Http.toQueryValue v)
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatTasksResponse = Types.TasksRecord list

    type CatTasksRequestBuilder() =
        member _.Yield(_: unit) : CatTasksRequest =
            {
                Actions = None
                Detailed = None
                Nodes = None
                ParentTaskId = None
                H = None
                S = None
                Timeout = None
                WaitForCompletion = None
            }

        [<CustomOperation("actions")>]
        member _.Actions(state: CatTasksRequest, value: string list) =
            { state with Actions = Some value }

        [<CustomOperation("detailed")>]
        member _.Detailed(state: CatTasksRequest, value: bool) =
            { state with Detailed = Some value }

        [<CustomOperation("nodes")>]
        member _.Nodes(state: CatTasksRequest, value: string list) =
            { state with Nodes = Some value }

        [<CustomOperation("parentTaskId")>]
        member _.ParentTaskId(state: CatTasksRequest, value: string) =
            { state with ParentTaskId = Some value }

        [<CustomOperation("h")>]
        member _.H(state: CatTasksRequest, value: Types.CatTasksColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatTasksRequest, value: Types.Names) =
            { state with S = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: CatTasksRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: CatTasksRequest, value: bool) =
            { state with WaitForCompletion = Some value }

    let catTasksRequest = CatTasksRequestBuilder()

    module Tasks =
        let withActions (value: string list) (req: CatTasksRequest) =
            { req with Actions = Some value }
        let withDetailed (value: bool) (req: CatTasksRequest) =
            { req with Detailed = Some value }
        let withNodes (value: string list) (req: CatTasksRequest) =
            { req with Nodes = Some value }
        let withParentTaskId (value: string) (req: CatTasksRequest) =
            { req with ParentTaskId = Some value }
        let withH (value: Types.CatTasksColumns) (req: CatTasksRequest) =
            { req with H = Some value }
        let withS (value: Types.Names) (req: CatTasksRequest) =
            { req with S = Some value }
        let withTimeout (value: Types.Duration) (req: CatTasksRequest) =
            { req with Timeout = Some value }
        let withWaitForCompletion (value: bool) (req: CatTasksRequest) =
            { req with WaitForCompletion = Some value }

    type CatTemplatesRequest = {
        Name: Types.Name
        H: Types.CatTemplatesColumns option
        S: Types.Names option
        Local: bool option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: CatTemplatesRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/templates/{req.Name}"
            let queryParams =
                [
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                    req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatTemplatesResponse = Types.TemplatesRecord list

    type CatTemplatesRequestBuilder() =
        member _.Yield(_: unit) : CatTemplatesRequest =
            {
                Name = Unchecked.defaultof<_>
                H = None
                S = None
                Local = None
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: CatTemplatesRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("h")>]
        member _.H(state: CatTemplatesRequest, value: Types.CatTemplatesColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatTemplatesRequest, value: Types.Names) =
            { state with S = Some value }

        [<CustomOperation("local")>]
        member _.Local(state: CatTemplatesRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CatTemplatesRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let catTemplatesRequest = CatTemplatesRequestBuilder()

    module Templates =
        let withH (value: Types.CatTemplatesColumns) (req: CatTemplatesRequest) =
            { req with H = Some value }
        let withS (value: Types.Names) (req: CatTemplatesRequest) =
            { req with S = Some value }
        let withLocal (value: bool) (req: CatTemplatesRequest) =
            { req with Local = Some value }
        let withMasterTimeout (value: Types.Duration) (req: CatTemplatesRequest) =
            { req with MasterTimeout = Some value }

    type CatThreadPoolRequest = {
        ThreadPoolPatterns: Types.Names
        H: Types.CatThreadPoolColumns option
        S: Types.Names option
        Local: bool option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: CatThreadPoolRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/thread_pool/{req.ThreadPoolPatterns}"
            let queryParams =
                [
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                    req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatThreadPoolResponse = Types.ThreadPoolRecord list

    type CatThreadPoolRequestBuilder() =
        member _.Yield(_: unit) : CatThreadPoolRequest =
            {
                ThreadPoolPatterns = Unchecked.defaultof<_>
                H = None
                S = None
                Local = None
                MasterTimeout = None
            }

        [<CustomOperation("threadPoolPatterns")>]
        member _.ThreadPoolPatterns(state: CatThreadPoolRequest, value: Types.Names) =
            { state with ThreadPoolPatterns = value }

        [<CustomOperation("h")>]
        member _.H(state: CatThreadPoolRequest, value: Types.CatThreadPoolColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatThreadPoolRequest, value: Types.Names) =
            { state with S = Some value }

        [<CustomOperation("local")>]
        member _.Local(state: CatThreadPoolRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CatThreadPoolRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let catThreadPoolRequest = CatThreadPoolRequestBuilder()

    module ThreadPool =
        let withH (value: Types.CatThreadPoolColumns) (req: CatThreadPoolRequest) =
            { req with H = Some value }
        let withS (value: Types.Names) (req: CatThreadPoolRequest) =
            { req with S = Some value }
        let withLocal (value: bool) (req: CatThreadPoolRequest) =
            { req with Local = Some value }
        let withMasterTimeout (value: Types.Duration) (req: CatThreadPoolRequest) =
            { req with MasterTimeout = Some value }

    type CatTransformsRequest = {
        TransformId: Types.Id
        AllowNoMatch: bool option
        From: Types.Integer option
        H: Types.CatTransformColumns option
        S: Types.CatTransformColumns option
        Size: Types.Integer option
    }

        with
        static member ToEndpoint(req: CatTransformsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_cat/transforms/{req.TransformId}"
            let queryParams =
                [
                    req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                    req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                    req.H |> Option.map (fun v -> "h", Fes.Http.toQueryValue v)
                    req.S |> Option.map (fun v -> "s", Fes.Http.toQueryValue v)
                    req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CatTransformsResponse = Types.TransformsRecord list

    type CatTransformsRequestBuilder() =
        member _.Yield(_: unit) : CatTransformsRequest =
            {
                TransformId = Unchecked.defaultof<_>
                AllowNoMatch = None
                From = None
                H = None
                S = None
                Size = None
            }

        [<CustomOperation("transformId")>]
        member _.TransformId(state: CatTransformsRequest, value: Types.Id) =
            { state with TransformId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: CatTransformsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("from")>]
        member _.From(state: CatTransformsRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("h")>]
        member _.H(state: CatTransformsRequest, value: Types.CatTransformColumns) =
            { state with H = Some value }

        [<CustomOperation("s")>]
        member _.S(state: CatTransformsRequest, value: Types.CatTransformColumns) =
            { state with S = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: CatTransformsRequest, value: Types.Integer) =
            { state with Size = Some value }

    let catTransformsRequest = CatTransformsRequestBuilder()

    module Transforms =
        let withAllowNoMatch (value: bool) (req: CatTransformsRequest) =
            { req with AllowNoMatch = Some value }
        let withFrom (value: Types.Integer) (req: CatTransformsRequest) =
            { req with From = Some value }
        let withH (value: Types.CatTransformColumns) (req: CatTransformsRequest) =
            { req with H = Some value }
        let withS (value: Types.CatTransformColumns) (req: CatTransformsRequest) =
            { req with S = Some value }
        let withSize (value: Types.Integer) (req: CatTransformsRequest) =
            { req with Size = Some value }


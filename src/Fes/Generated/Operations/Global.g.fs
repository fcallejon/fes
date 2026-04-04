// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module GlobalOperations =

    type BulkRequest<'TDocument, 'TPartialDocument> = {
        Index: Types.IndexName
        IncludeSourceOnError: bool option
        ListExecutedPipelines: bool option
        Pipeline: string option
        Refresh: Types.Refresh option
        Routing: Types.Routing option
        Source: Types.SourceConfigParam option
        SourceExcludes: Types.Fields option
        SourceIncludes: Types.Fields option
        Timeout: Types.Duration option
        WaitForActiveShards: Types.WaitForActiveShards option
        RequireAlias: bool option
        RequireDataStream: bool option
        Document: System.Text.Json.JsonElement list
    }

        with
        static member ToEndpoint(req: BulkRequest<'TDocument, 'TPartialDocument>) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_bulk"
            let queryParams =
                [
                    req.IncludeSourceOnError |> Option.map (fun v -> "include_source_on_error", Fes.Http.toQueryValue v)
                    req.ListExecutedPipelines |> Option.map (fun v -> "list_executed_pipelines", Fes.Http.toQueryValue v)
                    req.Pipeline |> Option.map (fun v -> "pipeline", Fes.Http.toQueryValue v)
                    req.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                    req.Source |> Option.map (fun v -> "_source", Fes.Http.toQueryValue v)
                    req.SourceExcludes |> Option.map (fun v -> "_source_excludes", Fes.Http.toQueryValue v)
                    req.SourceIncludes |> Option.map (fun v -> "_source_includes", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    req.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                    req.RequireAlias |> Option.map (fun v -> "require_alias", Fes.Http.toQueryValue v)
                    req.RequireDataStream |> Option.map (fun v -> "require_data_stream", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req.Document)
            endpoint, ValueSome postData

    type BulkResponse = System.Text.Json.JsonElement

    type BulkRequestBuilder() =
        member _.Yield(_: unit) : BulkRequest<_, _> =
            {
                Index = Unchecked.defaultof<_>
                IncludeSourceOnError = None
                ListExecutedPipelines = None
                Pipeline = None
                Refresh = None
                Routing = None
                Source = None
                SourceExcludes = None
                SourceIncludes = None
                Timeout = None
                WaitForActiveShards = None
                RequireAlias = None
                RequireDataStream = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("index")>]
        member _.Index(state: BulkRequest<_, _>, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("includeSourceOnError")>]
        member _.IncludeSourceOnError(state: BulkRequest<_, _>, value: bool) =
            { state with IncludeSourceOnError = Some value }

        [<CustomOperation("listExecutedPipelines")>]
        member _.ListExecutedPipelines(state: BulkRequest<_, _>, value: bool) =
            { state with ListExecutedPipelines = Some value }

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: BulkRequest<_, _>, value: string) =
            { state with Pipeline = Some value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: BulkRequest<_, _>, value: Types.Refresh) =
            { state with Refresh = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: BulkRequest<_, _>, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: BulkRequest<_, _>, value: Types.SourceConfigParam) =
            { state with Source = Some value }

        [<CustomOperation("sourceExcludes")>]
        member _.SourceExcludes(state: BulkRequest<_, _>, value: Types.Fields) =
            { state with SourceExcludes = Some value }

        [<CustomOperation("sourceIncludes")>]
        member _.SourceIncludes(state: BulkRequest<_, _>, value: Types.Fields) =
            { state with SourceIncludes = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: BulkRequest<_, _>, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: BulkRequest<_, _>, value: Types.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

        [<CustomOperation("requireAlias")>]
        member _.RequireAlias(state: BulkRequest<_, _>, value: bool) =
            { state with RequireAlias = Some value }

        [<CustomOperation("requireDataStream")>]
        member _.RequireDataStream(state: BulkRequest<_, _>, value: bool) =
            { state with RequireDataStream = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: BulkRequest<_, _>, value) =
            { state with Document = value }

    let bulkRequest = BulkRequestBuilder()

    module Bulk =
        let withIncludeSourceOnError (value: bool) (req: BulkRequest<_, _>) =
            { req with IncludeSourceOnError = Some value }
        let withListExecutedPipelines (value: bool) (req: BulkRequest<_, _>) =
            { req with ListExecutedPipelines = Some value }
        let withPipeline (value: string) (req: BulkRequest<_, _>) =
            { req with Pipeline = Some value }
        let withRefresh (value: Types.Refresh) (req: BulkRequest<_, _>) =
            { req with Refresh = Some value }
        let withRouting (value: Types.Routing) (req: BulkRequest<_, _>) =
            { req with Routing = Some value }
        let withSource (value: Types.SourceConfigParam) (req: BulkRequest<_, _>) =
            { req with Source = Some value }
        let withSourceExcludes (value: Types.Fields) (req: BulkRequest<_, _>) =
            { req with SourceExcludes = Some value }
        let withSourceIncludes (value: Types.Fields) (req: BulkRequest<_, _>) =
            { req with SourceIncludes = Some value }
        let withTimeout (value: Types.Duration) (req: BulkRequest<_, _>) =
            { req with Timeout = Some value }
        let withWaitForActiveShards (value: Types.WaitForActiveShards) (req: BulkRequest<_, _>) =
            { req with WaitForActiveShards = Some value }
        let withRequireAlias (value: bool) (req: BulkRequest<_, _>) =
            { req with RequireAlias = Some value }
        let withRequireDataStream (value: bool) (req: BulkRequest<_, _>) =
            { req with RequireDataStream = Some value }

    type CapabilitiesRequest = {
        Method: Types.RestMethod option
        Path: string option
        Parameters: System.Text.Json.JsonElement option
        Capabilities: System.Text.Json.JsonElement option
        LocalOnly: bool option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: CapabilitiesRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_capabilities"
            let queryParams =
                [
                    req.Method |> Option.map (fun v -> "method", Fes.Http.toQueryValue v)
                    req.Path |> Option.map (fun v -> "path", Fes.Http.toQueryValue v)
                    req.Parameters |> Option.map (fun v -> "parameters", Fes.Http.toQueryValue v)
                    req.Capabilities |> Option.map (fun v -> "capabilities", Fes.Http.toQueryValue v)
                    req.LocalOnly |> Option.map (fun v -> "local_only", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type CapabilitiesResponse = System.Text.Json.JsonElement

    type CapabilitiesRequestBuilder() =
        member _.Yield(_: unit) : CapabilitiesRequest =
            {
                Method = None
                Path = None
                Parameters = None
                Capabilities = None
                LocalOnly = None
                Timeout = None
            }

        [<CustomOperation("method")>]
        member _.Method(state: CapabilitiesRequest, value: Types.RestMethod) =
            { state with Method = Some value }

        [<CustomOperation("path")>]
        member _.Path(state: CapabilitiesRequest, value: string) =
            { state with Path = Some value }

        [<CustomOperation("parameters")>]
        member _.Parameters(state: CapabilitiesRequest, value: System.Text.Json.JsonElement) =
            { state with Parameters = Some value }

        [<CustomOperation("capabilities")>]
        member _.Capabilities(state: CapabilitiesRequest, value: System.Text.Json.JsonElement) =
            { state with Capabilities = Some value }

        [<CustomOperation("localOnly")>]
        member _.LocalOnly(state: CapabilitiesRequest, value: bool) =
            { state with LocalOnly = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: CapabilitiesRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let capabilitiesRequest = CapabilitiesRequestBuilder()

    module Capabilities =
        let withMethod (value: Types.RestMethod) (req: CapabilitiesRequest) =
            { req with Method = Some value }
        let withPath (value: string) (req: CapabilitiesRequest) =
            { req with Path = Some value }
        let withParameters (value: System.Text.Json.JsonElement) (req: CapabilitiesRequest) =
            { req with Parameters = Some value }
        let withCapabilities (value: System.Text.Json.JsonElement) (req: CapabilitiesRequest) =
            { req with Capabilities = Some value }
        let withLocalOnly (value: bool) (req: CapabilitiesRequest) =
            { req with LocalOnly = Some value }
        let withTimeout (value: Types.Duration) (req: CapabilitiesRequest) =
            { req with Timeout = Some value }

    type ClearScrollRequest = {
        ScrollId: Types.ScrollIds
        [<System.Text.Json.Serialization.JsonPropertyName("scroll_id")>]
        bodyScrollId: Types.ScrollIds option
    }

        with
        static member ToEndpoint(req: ClearScrollRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_search/scroll/{Fes.Http.toPathSegment req.ScrollId}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type ClearScrollResponse = System.Text.Json.JsonElement

    type ClearScrollRequestBuilder() =
        member _.Yield(_: unit) : ClearScrollRequest =
            {
                ScrollId = Unchecked.defaultof<_>
                bodyScrollId = None
            }

        [<CustomOperation("scrollId")>]
        member _.ScrollId(state: ClearScrollRequest, value: Types.ScrollIds) =
            { state with ScrollId = value }

        [<CustomOperation("scrollId")>]
        member _.BodyScrollId(state: ClearScrollRequest, value: Types.ScrollIds) =
            { state with bodyScrollId = Some value }

    let clearScrollRequest = ClearScrollRequestBuilder()

    module ClearScroll =
        let withBodyScrollId (value: Types.ScrollIds) (req: ClearScrollRequest) =
            { req with bodyScrollId = Some value }

    type ClosePointInTimeRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id
    }

        with
        static member ToEndpoint(req: ClosePointInTimeRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_pit"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type ClosePointInTimeResponse = System.Text.Json.JsonElement

    type ClosePointInTimeRequestBuilder() =
        member _.Yield(_: unit) : ClosePointInTimeRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: ClosePointInTimeRequest, value: Types.Id) =
            { state with Id = value }

    let closePointInTimeRequest = ClosePointInTimeRequestBuilder()

    module ClosePointInTime =
        let withId (value: Types.Id) (req: ClosePointInTimeRequest) =
            { req with Id = value }

    type CountRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        Analyzer: string option
        AnalyzeWildcard: bool option
        DefaultOperator: Types.Operator option
        Df: string option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreThrottled: bool option
        IgnoreUnavailable: bool option
        Lenient: bool option
        MinScore: Types.Double option
        Preference: string option
        Routing: Types.Routing option
        TerminateAfter: Types.Long option
        Q: string option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: Types.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("project_routing")>]
        ProjectRouting: Types.ProjectRouting option
    }

        with
        static member ToEndpoint(req: CountRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_count"
            let queryParams =
                [
                    req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                    req.Analyzer |> Option.map (fun v -> "analyzer", Fes.Http.toQueryValue v)
                    req.AnalyzeWildcard |> Option.map (fun v -> "analyze_wildcard", Fes.Http.toQueryValue v)
                    req.DefaultOperator |> Option.map (fun v -> "default_operator", Fes.Http.toQueryValue v)
                    req.Df |> Option.map (fun v -> "df", Fes.Http.toQueryValue v)
                    req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                    req.IgnoreThrottled |> Option.map (fun v -> "ignore_throttled", Fes.Http.toQueryValue v)
                    req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                    req.Lenient |> Option.map (fun v -> "lenient", Fes.Http.toQueryValue v)
                    req.MinScore |> Option.map (fun v -> "min_score", Fes.Http.toQueryValue v)
                    req.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                    req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                    req.TerminateAfter |> Option.map (fun v -> "terminate_after", Fes.Http.toQueryValue v)
                    req.Q |> Option.map (fun v -> "q", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type CountResponse = System.Text.Json.JsonElement

    type CountRequestBuilder() =
        member _.Yield(_: unit) : CountRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                Analyzer = None
                AnalyzeWildcard = None
                DefaultOperator = None
                Df = None
                ExpandWildcards = None
                IgnoreThrottled = None
                IgnoreUnavailable = None
                Lenient = None
                MinScore = None
                Preference = None
                Routing = None
                TerminateAfter = None
                Q = None
                Query = None
                ProjectRouting = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: CountRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: CountRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: CountRequest, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("analyzeWildcard")>]
        member _.AnalyzeWildcard(state: CountRequest, value: bool) =
            { state with AnalyzeWildcard = Some value }

        [<CustomOperation("defaultOperator")>]
        member _.DefaultOperator(state: CountRequest, value: Types.Operator) =
            { state with DefaultOperator = Some value }

        [<CustomOperation("df")>]
        member _.Df(state: CountRequest, value: string) =
            { state with Df = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: CountRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreThrottled")>]
        member _.IgnoreThrottled(state: CountRequest, value: bool) =
            { state with IgnoreThrottled = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: CountRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("lenient")>]
        member _.Lenient(state: CountRequest, value: bool) =
            { state with Lenient = Some value }

        [<CustomOperation("minScore")>]
        member _.MinScore(state: CountRequest, value: Types.Double) =
            { state with MinScore = Some value }

        [<CustomOperation("preference")>]
        member _.Preference(state: CountRequest, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: CountRequest, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("terminateAfter")>]
        member _.TerminateAfter(state: CountRequest, value: Types.Long) =
            { state with TerminateAfter = Some value }

        [<CustomOperation("q")>]
        member _.Q(state: CountRequest, value: string) =
            { state with Q = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: CountRequest, value: Types.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: CountRequest, value: Types.ProjectRouting) =
            { state with ProjectRouting = Some value }

    let countRequest = CountRequestBuilder()

    module Count =
        let withAllowNoIndices (value: bool) (req: CountRequest) =
            { req with AllowNoIndices = Some value }
        let withAnalyzer (value: string) (req: CountRequest) =
            { req with Analyzer = Some value }
        let withAnalyzeWildcard (value: bool) (req: CountRequest) =
            { req with AnalyzeWildcard = Some value }
        let withDefaultOperator (value: Types.Operator) (req: CountRequest) =
            { req with DefaultOperator = Some value }
        let withDf (value: string) (req: CountRequest) =
            { req with Df = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: CountRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreThrottled (value: bool) (req: CountRequest) =
            { req with IgnoreThrottled = Some value }
        let withIgnoreUnavailable (value: bool) (req: CountRequest) =
            { req with IgnoreUnavailable = Some value }
        let withLenient (value: bool) (req: CountRequest) =
            { req with Lenient = Some value }
        let withMinScore (value: Types.Double) (req: CountRequest) =
            { req with MinScore = Some value }
        let withPreference (value: string) (req: CountRequest) =
            { req with Preference = Some value }
        let withRouting (value: Types.Routing) (req: CountRequest) =
            { req with Routing = Some value }
        let withTerminateAfter (value: Types.Long) (req: CountRequest) =
            { req with TerminateAfter = Some value }
        let withQ (value: string) (req: CountRequest) =
            { req with Q = Some value }
        let withQuery (value: Types.QueryContainer) (req: CountRequest) =
            { req with Query = Some value }
        let withProjectRouting (value: Types.ProjectRouting) (req: CountRequest) =
            { req with ProjectRouting = Some value }

    type CreateRequest<'TDocument> = {
        Id: Types.Id
        Index: Types.IndexName
        IncludeSourceOnError: bool option
        Pipeline: string option
        Refresh: Types.Refresh option
        RequireAlias: bool option
        RequireDataStream: bool option
        Routing: Types.Routing option
        Timeout: Types.Duration option
        Version: Types.VersionNumber option
        VersionType: Types.VersionType option
        WaitForActiveShards: Types.WaitForActiveShards option
        Document: 'TDocument
    }

        with
        static member ToEndpoint(req: CreateRequest<'TDocument>) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_create/{Fes.Http.toPathSegment req.Id}"
            let queryParams =
                [
                    req.IncludeSourceOnError |> Option.map (fun v -> "include_source_on_error", Fes.Http.toQueryValue v)
                    req.Pipeline |> Option.map (fun v -> "pipeline", Fes.Http.toQueryValue v)
                    req.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    req.RequireAlias |> Option.map (fun v -> "require_alias", Fes.Http.toQueryValue v)
                    req.RequireDataStream |> Option.map (fun v -> "require_data_stream", Fes.Http.toQueryValue v)
                    req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    req.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                    req.VersionType |> Option.map (fun v -> "version_type", Fes.Http.toQueryValue v)
                    req.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req.Document)
            endpoint, ValueSome postData

    type CreateResponse = Types.WriteResponseBase

    type CreateRequestBuilder() =
        member _.Yield(_: unit) : CreateRequest<_> =
            {
                Id = Unchecked.defaultof<_>
                Index = Unchecked.defaultof<_>
                IncludeSourceOnError = None
                Pipeline = None
                Refresh = None
                RequireAlias = None
                RequireDataStream = None
                Routing = None
                Timeout = None
                Version = None
                VersionType = None
                WaitForActiveShards = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: CreateRequest<_>, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: CreateRequest<_>, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("includeSourceOnError")>]
        member _.IncludeSourceOnError(state: CreateRequest<_>, value: bool) =
            { state with IncludeSourceOnError = Some value }

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: CreateRequest<_>, value: string) =
            { state with Pipeline = Some value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: CreateRequest<_>, value: Types.Refresh) =
            { state with Refresh = Some value }

        [<CustomOperation("requireAlias")>]
        member _.RequireAlias(state: CreateRequest<_>, value: bool) =
            { state with RequireAlias = Some value }

        [<CustomOperation("requireDataStream")>]
        member _.RequireDataStream(state: CreateRequest<_>, value: bool) =
            { state with RequireDataStream = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: CreateRequest<_>, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: CreateRequest<_>, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: CreateRequest<_>, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: CreateRequest<_>, value: Types.VersionType) =
            { state with VersionType = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: CreateRequest<_>, value: Types.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: CreateRequest<_>, value) =
            { state with Document = value }

    let createRequest = CreateRequestBuilder()

    module Create =
        let withIncludeSourceOnError (value: bool) (req: CreateRequest<_>) =
            { req with IncludeSourceOnError = Some value }
        let withPipeline (value: string) (req: CreateRequest<_>) =
            { req with Pipeline = Some value }
        let withRefresh (value: Types.Refresh) (req: CreateRequest<_>) =
            { req with Refresh = Some value }
        let withRequireAlias (value: bool) (req: CreateRequest<_>) =
            { req with RequireAlias = Some value }
        let withRequireDataStream (value: bool) (req: CreateRequest<_>) =
            { req with RequireDataStream = Some value }
        let withRouting (value: Types.Routing) (req: CreateRequest<_>) =
            { req with Routing = Some value }
        let withTimeout (value: Types.Duration) (req: CreateRequest<_>) =
            { req with Timeout = Some value }
        let withVersion (value: Types.VersionNumber) (req: CreateRequest<_>) =
            { req with Version = Some value }
        let withVersionType (value: Types.VersionType) (req: CreateRequest<_>) =
            { req with VersionType = Some value }
        let withWaitForActiveShards (value: Types.WaitForActiveShards) (req: CreateRequest<_>) =
            { req with WaitForActiveShards = Some value }

    type DeleteRequest = {
        Id: Types.Id
        Index: Types.IndexName
        IfPrimaryTerm: Types.Long option
        IfSeqNo: Types.SequenceNumber option
        Refresh: Types.Refresh option
        Routing: Types.Routing option
        Timeout: Types.Duration option
        Version: Types.VersionNumber option
        VersionType: Types.VersionType option
        WaitForActiveShards: Types.WaitForActiveShards option
    }

        with
        static member ToEndpoint(req: DeleteRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_doc/{Fes.Http.toPathSegment req.Id}"
            let queryParams =
                [
                    req.IfPrimaryTerm |> Option.map (fun v -> "if_primary_term", Fes.Http.toQueryValue v)
                    req.IfSeqNo |> Option.map (fun v -> "if_seq_no", Fes.Http.toQueryValue v)
                    req.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    req.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                    req.VersionType |> Option.map (fun v -> "version_type", Fes.Http.toQueryValue v)
                    req.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type DeleteResponse = Types.WriteResponseBase

    type DeleteRequestBuilder() =
        member _.Yield(_: unit) : DeleteRequest =
            {
                Id = Unchecked.defaultof<_>
                Index = Unchecked.defaultof<_>
                IfPrimaryTerm = None
                IfSeqNo = None
                Refresh = None
                Routing = None
                Timeout = None
                Version = None
                VersionType = None
                WaitForActiveShards = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: DeleteRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: DeleteRequest, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("ifPrimaryTerm")>]
        member _.IfPrimaryTerm(state: DeleteRequest, value: Types.Long) =
            { state with IfPrimaryTerm = Some value }

        [<CustomOperation("ifSeqNo")>]
        member _.IfSeqNo(state: DeleteRequest, value: Types.SequenceNumber) =
            { state with IfSeqNo = Some value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: DeleteRequest, value: Types.Refresh) =
            { state with Refresh = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: DeleteRequest, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: DeleteRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: DeleteRequest, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: DeleteRequest, value: Types.VersionType) =
            { state with VersionType = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: DeleteRequest, value: Types.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

    let deleteRequest = DeleteRequestBuilder()

    module Delete =
        let withIfPrimaryTerm (value: Types.Long) (req: DeleteRequest) =
            { req with IfPrimaryTerm = Some value }
        let withIfSeqNo (value: Types.SequenceNumber) (req: DeleteRequest) =
            { req with IfSeqNo = Some value }
        let withRefresh (value: Types.Refresh) (req: DeleteRequest) =
            { req with Refresh = Some value }
        let withRouting (value: Types.Routing) (req: DeleteRequest) =
            { req with Routing = Some value }
        let withTimeout (value: Types.Duration) (req: DeleteRequest) =
            { req with Timeout = Some value }
        let withVersion (value: Types.VersionNumber) (req: DeleteRequest) =
            { req with Version = Some value }
        let withVersionType (value: Types.VersionType) (req: DeleteRequest) =
            { req with VersionType = Some value }
        let withWaitForActiveShards (value: Types.WaitForActiveShards) (req: DeleteRequest) =
            { req with WaitForActiveShards = Some value }

    type DeleteByQueryRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        Analyzer: string option
        AnalyzeWildcard: bool option
        Conflicts: Types.Conflicts option
        DefaultOperator: Types.Operator option
        Df: string option
        ExpandWildcards: Types.ExpandWildcards option
        From: Types.Long option
        IgnoreUnavailable: bool option
        Lenient: bool option
        MaxDocs: Types.Long option
        Preference: string option
        Refresh: bool option
        RequestCache: bool option
        RequestsPerSecond: Types.Float option
        Routing: Types.Routing option
        Q: string option
        Scroll: Types.Duration option
        ScrollSize: Types.Long option
        SearchTimeout: Types.Duration option
        SearchType: Types.SearchType option
        Slices: Types.Slices option
        Sort: string list option
        Stats: string list option
        TerminateAfter: Types.Long option
        Timeout: Types.Duration option
        Version: bool option
        WaitForActiveShards: Types.WaitForActiveShards option
        WaitForCompletion: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("max_docs")>]
        bodyMaxDocs: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: Types.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("slice")>]
        Slice: Types.SlicedScroll option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        bodySort: Types.Sort option
    }

        with
        static member ToEndpoint(req: DeleteByQueryRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_delete_by_query"
            let queryParams =
                [
                    req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                    req.Analyzer |> Option.map (fun v -> "analyzer", Fes.Http.toQueryValue v)
                    req.AnalyzeWildcard |> Option.map (fun v -> "analyze_wildcard", Fes.Http.toQueryValue v)
                    req.Conflicts |> Option.map (fun v -> "conflicts", Fes.Http.toQueryValue v)
                    req.DefaultOperator |> Option.map (fun v -> "default_operator", Fes.Http.toQueryValue v)
                    req.Df |> Option.map (fun v -> "df", Fes.Http.toQueryValue v)
                    req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                    req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                    req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                    req.Lenient |> Option.map (fun v -> "lenient", Fes.Http.toQueryValue v)
                    req.MaxDocs |> Option.map (fun v -> "max_docs", Fes.Http.toQueryValue v)
                    req.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                    req.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    req.RequestCache |> Option.map (fun v -> "request_cache", Fes.Http.toQueryValue v)
                    req.RequestsPerSecond |> Option.map (fun v -> "requests_per_second", Fes.Http.toQueryValue v)
                    req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                    req.Q |> Option.map (fun v -> "q", Fes.Http.toQueryValue v)
                    req.Scroll |> Option.map (fun v -> "scroll", Fes.Http.toQueryValue v)
                    req.ScrollSize |> Option.map (fun v -> "scroll_size", Fes.Http.toQueryValue v)
                    req.SearchTimeout |> Option.map (fun v -> "search_timeout", Fes.Http.toQueryValue v)
                    req.SearchType |> Option.map (fun v -> "search_type", Fes.Http.toQueryValue v)
                    req.Slices |> Option.map (fun v -> "slices", Fes.Http.toQueryValue v)
                    req.Sort |> Option.map (fun v -> "sort", Fes.Http.toQueryValue v)
                    req.Stats |> Option.map (fun v -> "stats", Fes.Http.toQueryValue v)
                    req.TerminateAfter |> Option.map (fun v -> "terminate_after", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    req.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                    req.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                    req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type DeleteByQueryResponse = System.Text.Json.JsonElement

    type DeleteByQueryRequestBuilder() =
        member _.Yield(_: unit) : DeleteByQueryRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                Analyzer = None
                AnalyzeWildcard = None
                Conflicts = None
                DefaultOperator = None
                Df = None
                ExpandWildcards = None
                From = None
                IgnoreUnavailable = None
                Lenient = None
                MaxDocs = None
                Preference = None
                Refresh = None
                RequestCache = None
                RequestsPerSecond = None
                Routing = None
                Q = None
                Scroll = None
                ScrollSize = None
                SearchTimeout = None
                SearchType = None
                Slices = None
                Sort = None
                Stats = None
                TerminateAfter = None
                Timeout = None
                Version = None
                WaitForActiveShards = None
                WaitForCompletion = None
                bodyMaxDocs = None
                Query = None
                Slice = None
                bodySort = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: DeleteByQueryRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: DeleteByQueryRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: DeleteByQueryRequest, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("analyzeWildcard")>]
        member _.AnalyzeWildcard(state: DeleteByQueryRequest, value: bool) =
            { state with AnalyzeWildcard = Some value }

        [<CustomOperation("conflicts")>]
        member _.Conflicts(state: DeleteByQueryRequest, value: Types.Conflicts) =
            { state with Conflicts = Some value }

        [<CustomOperation("defaultOperator")>]
        member _.DefaultOperator(state: DeleteByQueryRequest, value: Types.Operator) =
            { state with DefaultOperator = Some value }

        [<CustomOperation("df")>]
        member _.Df(state: DeleteByQueryRequest, value: string) =
            { state with Df = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: DeleteByQueryRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("from")>]
        member _.From(state: DeleteByQueryRequest, value: Types.Long) =
            { state with From = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: DeleteByQueryRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("lenient")>]
        member _.Lenient(state: DeleteByQueryRequest, value: bool) =
            { state with Lenient = Some value }

        [<CustomOperation("maxDocs")>]
        member _.MaxDocs(state: DeleteByQueryRequest, value: Types.Long) =
            { state with MaxDocs = Some value }

        [<CustomOperation("preference")>]
        member _.Preference(state: DeleteByQueryRequest, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: DeleteByQueryRequest, value: bool) =
            { state with Refresh = Some value }

        [<CustomOperation("requestCache")>]
        member _.RequestCache(state: DeleteByQueryRequest, value: bool) =
            { state with RequestCache = Some value }

        [<CustomOperation("requestsPerSecond")>]
        member _.RequestsPerSecond(state: DeleteByQueryRequest, value: Types.Float) =
            { state with RequestsPerSecond = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: DeleteByQueryRequest, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("q")>]
        member _.Q(state: DeleteByQueryRequest, value: string) =
            { state with Q = Some value }

        [<CustomOperation("scroll")>]
        member _.Scroll(state: DeleteByQueryRequest, value: Types.Duration) =
            { state with Scroll = Some value }

        [<CustomOperation("scrollSize")>]
        member _.ScrollSize(state: DeleteByQueryRequest, value: Types.Long) =
            { state with ScrollSize = Some value }

        [<CustomOperation("searchTimeout")>]
        member _.SearchTimeout(state: DeleteByQueryRequest, value: Types.Duration) =
            { state with SearchTimeout = Some value }

        [<CustomOperation("searchType")>]
        member _.SearchType(state: DeleteByQueryRequest, value: Types.SearchType) =
            { state with SearchType = Some value }

        [<CustomOperation("slices")>]
        member _.Slices(state: DeleteByQueryRequest, value: Types.Slices) =
            { state with Slices = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: DeleteByQueryRequest, value: string list) =
            { state with Sort = Some value }

        [<CustomOperation("stats")>]
        member _.Stats(state: DeleteByQueryRequest, value: string list) =
            { state with Stats = Some value }

        [<CustomOperation("terminateAfter")>]
        member _.TerminateAfter(state: DeleteByQueryRequest, value: Types.Long) =
            { state with TerminateAfter = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: DeleteByQueryRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: DeleteByQueryRequest, value: bool) =
            { state with Version = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: DeleteByQueryRequest, value: Types.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: DeleteByQueryRequest, value: bool) =
            { state with WaitForCompletion = Some value }

        [<CustomOperation("bodyMaxDocs")>]
        member _.BodyMaxDocs(state: DeleteByQueryRequest, value: Types.Long) =
            { state with bodyMaxDocs = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: DeleteByQueryRequest, value: Types.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("slice")>]
        member _.Slice(state: DeleteByQueryRequest, value: Types.SlicedScroll) =
            { state with Slice = Some value }

        [<CustomOperation("bodySort")>]
        member _.BodySort(state: DeleteByQueryRequest, value: Types.Sort) =
            { state with bodySort = Some value }

    let deleteByQueryRequest = DeleteByQueryRequestBuilder()

    module DeleteByQuery =
        let withAllowNoIndices (value: bool) (req: DeleteByQueryRequest) =
            { req with AllowNoIndices = Some value }
        let withAnalyzer (value: string) (req: DeleteByQueryRequest) =
            { req with Analyzer = Some value }
        let withAnalyzeWildcard (value: bool) (req: DeleteByQueryRequest) =
            { req with AnalyzeWildcard = Some value }
        let withConflicts (value: Types.Conflicts) (req: DeleteByQueryRequest) =
            { req with Conflicts = Some value }
        let withDefaultOperator (value: Types.Operator) (req: DeleteByQueryRequest) =
            { req with DefaultOperator = Some value }
        let withDf (value: string) (req: DeleteByQueryRequest) =
            { req with Df = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: DeleteByQueryRequest) =
            { req with ExpandWildcards = Some value }
        let withFrom (value: Types.Long) (req: DeleteByQueryRequest) =
            { req with From = Some value }
        let withIgnoreUnavailable (value: bool) (req: DeleteByQueryRequest) =
            { req with IgnoreUnavailable = Some value }
        let withLenient (value: bool) (req: DeleteByQueryRequest) =
            { req with Lenient = Some value }
        let withMaxDocs (value: Types.Long) (req: DeleteByQueryRequest) =
            { req with MaxDocs = Some value }
        let withPreference (value: string) (req: DeleteByQueryRequest) =
            { req with Preference = Some value }
        let withRefresh (value: bool) (req: DeleteByQueryRequest) =
            { req with Refresh = Some value }
        let withRequestCache (value: bool) (req: DeleteByQueryRequest) =
            { req with RequestCache = Some value }
        let withRequestsPerSecond (value: Types.Float) (req: DeleteByQueryRequest) =
            { req with RequestsPerSecond = Some value }
        let withRouting (value: Types.Routing) (req: DeleteByQueryRequest) =
            { req with Routing = Some value }
        let withQ (value: string) (req: DeleteByQueryRequest) =
            { req with Q = Some value }
        let withScroll (value: Types.Duration) (req: DeleteByQueryRequest) =
            { req with Scroll = Some value }
        let withScrollSize (value: Types.Long) (req: DeleteByQueryRequest) =
            { req with ScrollSize = Some value }
        let withSearchTimeout (value: Types.Duration) (req: DeleteByQueryRequest) =
            { req with SearchTimeout = Some value }
        let withSearchType (value: Types.SearchType) (req: DeleteByQueryRequest) =
            { req with SearchType = Some value }
        let withSlices (value: Types.Slices) (req: DeleteByQueryRequest) =
            { req with Slices = Some value }
        let withSort (value: string list) (req: DeleteByQueryRequest) =
            { req with Sort = Some value }
        let withStats (value: string list) (req: DeleteByQueryRequest) =
            { req with Stats = Some value }
        let withTerminateAfter (value: Types.Long) (req: DeleteByQueryRequest) =
            { req with TerminateAfter = Some value }
        let withTimeout (value: Types.Duration) (req: DeleteByQueryRequest) =
            { req with Timeout = Some value }
        let withVersion (value: bool) (req: DeleteByQueryRequest) =
            { req with Version = Some value }
        let withWaitForActiveShards (value: Types.WaitForActiveShards) (req: DeleteByQueryRequest) =
            { req with WaitForActiveShards = Some value }
        let withWaitForCompletion (value: bool) (req: DeleteByQueryRequest) =
            { req with WaitForCompletion = Some value }
        let withBodyMaxDocs (value: Types.Long) (req: DeleteByQueryRequest) =
            { req with bodyMaxDocs = Some value }
        let withQuery (value: Types.QueryContainer) (req: DeleteByQueryRequest) =
            { req with Query = Some value }
        let withSlice (value: Types.SlicedScroll) (req: DeleteByQueryRequest) =
            { req with Slice = Some value }
        let withBodySort (value: Types.Sort) (req: DeleteByQueryRequest) =
            { req with bodySort = Some value }

    type DeleteByQueryRethrottleRequest = {
        TaskId: Types.TaskId
        RequestsPerSecond: Types.Float
    }

        with
        static member ToEndpoint(req: DeleteByQueryRethrottleRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_delete_by_query/{Fes.Http.toPathSegment req.TaskId}/_rethrottle"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            endpoint, ValueNone

    type DeleteByQueryRethrottleResponse = Types.TaskListResponseBase

    type DeleteByQueryRethrottleRequestBuilder() =
        member _.Yield(_: unit) : DeleteByQueryRethrottleRequest =
            {
                TaskId = Unchecked.defaultof<_>
                RequestsPerSecond = Unchecked.defaultof<_>
            }

        [<CustomOperation("taskId")>]
        member _.TaskId(state: DeleteByQueryRethrottleRequest, value: Types.TaskId) =
            { state with TaskId = value }

        [<CustomOperation("requestsPerSecond")>]
        member _.RequestsPerSecond(state: DeleteByQueryRethrottleRequest, value: Types.Float) =
            { state with RequestsPerSecond = value }

    let deleteByQueryRethrottleRequest = DeleteByQueryRethrottleRequestBuilder()

    module DeleteByQueryRethrottle =
        let withRequestsPerSecond (value: Types.Float) (req: DeleteByQueryRethrottleRequest) =
            { req with RequestsPerSecond = value }

    type DeleteScriptRequest = {
        Id: Types.Id
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: DeleteScriptRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_scripts/{Fes.Http.toPathSegment req.Id}"
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

    type DeleteScriptResponse = Types.AcknowledgedResponseBase

    type DeleteScriptRequestBuilder() =
        member _.Yield(_: unit) : DeleteScriptRequest =
            {
                Id = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: DeleteScriptRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: DeleteScriptRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: DeleteScriptRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let deleteScriptRequest = DeleteScriptRequestBuilder()

    module DeleteScript =
        let withMasterTimeout (value: Types.Duration) (req: DeleteScriptRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: DeleteScriptRequest) =
            { req with Timeout = Some value }

    type ExistsRequest = {
        Id: Types.Id
        Index: Types.IndexName
        Preference: string option
        Realtime: bool option
        Refresh: bool option
        Routing: Types.Routing option
        Source: Types.SourceConfigParam option
        SourceExcludes: Types.Fields option
        SourceIncludes: Types.Fields option
        StoredFields: Types.Fields option
        Version: Types.VersionNumber option
        VersionType: Types.VersionType option
    }

        with
        static member ToEndpoint(req: ExistsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_doc/{Fes.Http.toPathSegment req.Id}"
            let queryParams =
                [
                    req.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                    req.Realtime |> Option.map (fun v -> "realtime", Fes.Http.toQueryValue v)
                    req.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                    req.Source |> Option.map (fun v -> "_source", Fes.Http.toQueryValue v)
                    req.SourceExcludes |> Option.map (fun v -> "_source_excludes", Fes.Http.toQueryValue v)
                    req.SourceIncludes |> Option.map (fun v -> "_source_includes", Fes.Http.toQueryValue v)
                    req.StoredFields |> Option.map (fun v -> "stored_fields", Fes.Http.toQueryValue v)
                    req.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                    req.VersionType |> Option.map (fun v -> "version_type", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.HEAD, fullPath)
            endpoint, ValueNone

    type ExistsResponse = unit

    type ExistsRequestBuilder() =
        member _.Yield(_: unit) : ExistsRequest =
            {
                Id = Unchecked.defaultof<_>
                Index = Unchecked.defaultof<_>
                Preference = None
                Realtime = None
                Refresh = None
                Routing = None
                Source = None
                SourceExcludes = None
                SourceIncludes = None
                StoredFields = None
                Version = None
                VersionType = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: ExistsRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: ExistsRequest, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("preference")>]
        member _.Preference(state: ExistsRequest, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("realtime")>]
        member _.Realtime(state: ExistsRequest, value: bool) =
            { state with Realtime = Some value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: ExistsRequest, value: bool) =
            { state with Refresh = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: ExistsRequest, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: ExistsRequest, value: Types.SourceConfigParam) =
            { state with Source = Some value }

        [<CustomOperation("sourceExcludes")>]
        member _.SourceExcludes(state: ExistsRequest, value: Types.Fields) =
            { state with SourceExcludes = Some value }

        [<CustomOperation("sourceIncludes")>]
        member _.SourceIncludes(state: ExistsRequest, value: Types.Fields) =
            { state with SourceIncludes = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: ExistsRequest, value: Types.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: ExistsRequest, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: ExistsRequest, value: Types.VersionType) =
            { state with VersionType = Some value }

    let existsRequest = ExistsRequestBuilder()

    module Exists =
        let withPreference (value: string) (req: ExistsRequest) =
            { req with Preference = Some value }
        let withRealtime (value: bool) (req: ExistsRequest) =
            { req with Realtime = Some value }
        let withRefresh (value: bool) (req: ExistsRequest) =
            { req with Refresh = Some value }
        let withRouting (value: Types.Routing) (req: ExistsRequest) =
            { req with Routing = Some value }
        let withSource (value: Types.SourceConfigParam) (req: ExistsRequest) =
            { req with Source = Some value }
        let withSourceExcludes (value: Types.Fields) (req: ExistsRequest) =
            { req with SourceExcludes = Some value }
        let withSourceIncludes (value: Types.Fields) (req: ExistsRequest) =
            { req with SourceIncludes = Some value }
        let withStoredFields (value: Types.Fields) (req: ExistsRequest) =
            { req with StoredFields = Some value }
        let withVersion (value: Types.VersionNumber) (req: ExistsRequest) =
            { req with Version = Some value }
        let withVersionType (value: Types.VersionType) (req: ExistsRequest) =
            { req with VersionType = Some value }

    type ExistsSourceRequest = {
        Id: Types.Id
        Index: Types.IndexName
        Preference: string option
        Realtime: bool option
        Refresh: bool option
        Routing: Types.Routing option
        Source: Types.SourceConfigParam option
        SourceExcludes: Types.Fields option
        SourceIncludes: Types.Fields option
        Version: Types.VersionNumber option
        VersionType: Types.VersionType option
    }

        with
        static member ToEndpoint(req: ExistsSourceRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_source/{Fes.Http.toPathSegment req.Id}"
            let queryParams =
                [
                    req.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                    req.Realtime |> Option.map (fun v -> "realtime", Fes.Http.toQueryValue v)
                    req.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                    req.Source |> Option.map (fun v -> "_source", Fes.Http.toQueryValue v)
                    req.SourceExcludes |> Option.map (fun v -> "_source_excludes", Fes.Http.toQueryValue v)
                    req.SourceIncludes |> Option.map (fun v -> "_source_includes", Fes.Http.toQueryValue v)
                    req.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                    req.VersionType |> Option.map (fun v -> "version_type", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.HEAD, fullPath)
            endpoint, ValueNone

    type ExistsSourceResponse = unit

    type ExistsSourceRequestBuilder() =
        member _.Yield(_: unit) : ExistsSourceRequest =
            {
                Id = Unchecked.defaultof<_>
                Index = Unchecked.defaultof<_>
                Preference = None
                Realtime = None
                Refresh = None
                Routing = None
                Source = None
                SourceExcludes = None
                SourceIncludes = None
                Version = None
                VersionType = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: ExistsSourceRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: ExistsSourceRequest, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("preference")>]
        member _.Preference(state: ExistsSourceRequest, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("realtime")>]
        member _.Realtime(state: ExistsSourceRequest, value: bool) =
            { state with Realtime = Some value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: ExistsSourceRequest, value: bool) =
            { state with Refresh = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: ExistsSourceRequest, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: ExistsSourceRequest, value: Types.SourceConfigParam) =
            { state with Source = Some value }

        [<CustomOperation("sourceExcludes")>]
        member _.SourceExcludes(state: ExistsSourceRequest, value: Types.Fields) =
            { state with SourceExcludes = Some value }

        [<CustomOperation("sourceIncludes")>]
        member _.SourceIncludes(state: ExistsSourceRequest, value: Types.Fields) =
            { state with SourceIncludes = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: ExistsSourceRequest, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: ExistsSourceRequest, value: Types.VersionType) =
            { state with VersionType = Some value }

    let existsSourceRequest = ExistsSourceRequestBuilder()

    module ExistsSource =
        let withPreference (value: string) (req: ExistsSourceRequest) =
            { req with Preference = Some value }
        let withRealtime (value: bool) (req: ExistsSourceRequest) =
            { req with Realtime = Some value }
        let withRefresh (value: bool) (req: ExistsSourceRequest) =
            { req with Refresh = Some value }
        let withRouting (value: Types.Routing) (req: ExistsSourceRequest) =
            { req with Routing = Some value }
        let withSource (value: Types.SourceConfigParam) (req: ExistsSourceRequest) =
            { req with Source = Some value }
        let withSourceExcludes (value: Types.Fields) (req: ExistsSourceRequest) =
            { req with SourceExcludes = Some value }
        let withSourceIncludes (value: Types.Fields) (req: ExistsSourceRequest) =
            { req with SourceIncludes = Some value }
        let withVersion (value: Types.VersionNumber) (req: ExistsSourceRequest) =
            { req with Version = Some value }
        let withVersionType (value: Types.VersionType) (req: ExistsSourceRequest) =
            { req with VersionType = Some value }

    type ExplainRequest = {
        Id: Types.Id
        Index: Types.IndexName
        Analyzer: string option
        AnalyzeWildcard: bool option
        DefaultOperator: Types.Operator option
        Df: string option
        Lenient: bool option
        Preference: string option
        Routing: Types.Routing option
        Source: Types.SourceConfigParam option
        SourceExcludes: Types.Fields option
        SourceIncludes: Types.Fields option
        StoredFields: Types.Fields option
        Q: string option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: Types.QueryContainer option
    }

        with
        static member ToEndpoint(req: ExplainRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_explain/{Fes.Http.toPathSegment req.Id}"
            let queryParams =
                [
                    req.Analyzer |> Option.map (fun v -> "analyzer", Fes.Http.toQueryValue v)
                    req.AnalyzeWildcard |> Option.map (fun v -> "analyze_wildcard", Fes.Http.toQueryValue v)
                    req.DefaultOperator |> Option.map (fun v -> "default_operator", Fes.Http.toQueryValue v)
                    req.Df |> Option.map (fun v -> "df", Fes.Http.toQueryValue v)
                    req.Lenient |> Option.map (fun v -> "lenient", Fes.Http.toQueryValue v)
                    req.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                    req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                    req.Source |> Option.map (fun v -> "_source", Fes.Http.toQueryValue v)
                    req.SourceExcludes |> Option.map (fun v -> "_source_excludes", Fes.Http.toQueryValue v)
                    req.SourceIncludes |> Option.map (fun v -> "_source_includes", Fes.Http.toQueryValue v)
                    req.StoredFields |> Option.map (fun v -> "stored_fields", Fes.Http.toQueryValue v)
                    req.Q |> Option.map (fun v -> "q", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type ExplainResponse = System.Text.Json.JsonElement

    type ExplainRequestBuilder() =
        member _.Yield(_: unit) : ExplainRequest =
            {
                Id = Unchecked.defaultof<_>
                Index = Unchecked.defaultof<_>
                Analyzer = None
                AnalyzeWildcard = None
                DefaultOperator = None
                Df = None
                Lenient = None
                Preference = None
                Routing = None
                Source = None
                SourceExcludes = None
                SourceIncludes = None
                StoredFields = None
                Q = None
                Query = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: ExplainRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: ExplainRequest, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: ExplainRequest, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("analyzeWildcard")>]
        member _.AnalyzeWildcard(state: ExplainRequest, value: bool) =
            { state with AnalyzeWildcard = Some value }

        [<CustomOperation("defaultOperator")>]
        member _.DefaultOperator(state: ExplainRequest, value: Types.Operator) =
            { state with DefaultOperator = Some value }

        [<CustomOperation("df")>]
        member _.Df(state: ExplainRequest, value: string) =
            { state with Df = Some value }

        [<CustomOperation("lenient")>]
        member _.Lenient(state: ExplainRequest, value: bool) =
            { state with Lenient = Some value }

        [<CustomOperation("preference")>]
        member _.Preference(state: ExplainRequest, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: ExplainRequest, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: ExplainRequest, value: Types.SourceConfigParam) =
            { state with Source = Some value }

        [<CustomOperation("sourceExcludes")>]
        member _.SourceExcludes(state: ExplainRequest, value: Types.Fields) =
            { state with SourceExcludes = Some value }

        [<CustomOperation("sourceIncludes")>]
        member _.SourceIncludes(state: ExplainRequest, value: Types.Fields) =
            { state with SourceIncludes = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: ExplainRequest, value: Types.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("q")>]
        member _.Q(state: ExplainRequest, value: string) =
            { state with Q = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: ExplainRequest, value: Types.QueryContainer) =
            { state with Query = Some value }

    let explainRequest = ExplainRequestBuilder()

    module Explain =
        let withAnalyzer (value: string) (req: ExplainRequest) =
            { req with Analyzer = Some value }
        let withAnalyzeWildcard (value: bool) (req: ExplainRequest) =
            { req with AnalyzeWildcard = Some value }
        let withDefaultOperator (value: Types.Operator) (req: ExplainRequest) =
            { req with DefaultOperator = Some value }
        let withDf (value: string) (req: ExplainRequest) =
            { req with Df = Some value }
        let withLenient (value: bool) (req: ExplainRequest) =
            { req with Lenient = Some value }
        let withPreference (value: string) (req: ExplainRequest) =
            { req with Preference = Some value }
        let withRouting (value: Types.Routing) (req: ExplainRequest) =
            { req with Routing = Some value }
        let withSource (value: Types.SourceConfigParam) (req: ExplainRequest) =
            { req with Source = Some value }
        let withSourceExcludes (value: Types.Fields) (req: ExplainRequest) =
            { req with SourceExcludes = Some value }
        let withSourceIncludes (value: Types.Fields) (req: ExplainRequest) =
            { req with SourceIncludes = Some value }
        let withStoredFields (value: Types.Fields) (req: ExplainRequest) =
            { req with StoredFields = Some value }
        let withQ (value: string) (req: ExplainRequest) =
            { req with Q = Some value }
        let withQuery (value: Types.QueryContainer) (req: ExplainRequest) =
            { req with Query = Some value }

    type FieldCapsRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        Fields: Types.Fields option
        IgnoreUnavailable: bool option
        IncludeUnmapped: bool option
        Filters: System.Text.Json.JsonElement option
        Types: string list option
        IncludeEmptyFields: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        bodyFields: Types.Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("index_filter")>]
        IndexFilter: Types.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: Types.RuntimeFields option
        [<System.Text.Json.Serialization.JsonPropertyName("project_routing")>]
        ProjectRouting: Types.ProjectRouting option
    }

        with
        static member ToEndpoint(req: FieldCapsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_field_caps"
            let queryParams =
                [
                    req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                    req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                    req.Fields |> Option.map (fun v -> "fields", Fes.Http.toQueryValue v)
                    req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                    req.IncludeUnmapped |> Option.map (fun v -> "include_unmapped", Fes.Http.toQueryValue v)
                    req.Filters |> Option.map (fun v -> "filters", Fes.Http.toQueryValue v)
                    req.Types |> Option.map (fun v -> "types", Fes.Http.toQueryValue v)
                    req.IncludeEmptyFields |> Option.map (fun v -> "include_empty_fields", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type FieldCapsResponse = System.Text.Json.JsonElement

    type FieldCapsRequestBuilder() =
        member _.Yield(_: unit) : FieldCapsRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                Fields = None
                IgnoreUnavailable = None
                IncludeUnmapped = None
                Filters = None
                Types = None
                IncludeEmptyFields = None
                bodyFields = None
                IndexFilter = None
                RuntimeMappings = None
                ProjectRouting = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: FieldCapsRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: FieldCapsRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: FieldCapsRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: FieldCapsRequest, value: Types.Fields) =
            { state with Fields = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: FieldCapsRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("includeUnmapped")>]
        member _.IncludeUnmapped(state: FieldCapsRequest, value: bool) =
            { state with IncludeUnmapped = Some value }

        [<CustomOperation("filters")>]
        member _.Filters(state: FieldCapsRequest, value: System.Text.Json.JsonElement) =
            { state with Filters = Some value }

        [<CustomOperation("types")>]
        member _.Types(state: FieldCapsRequest, value: string list) =
            { state with Types = Some value }

        [<CustomOperation("includeEmptyFields")>]
        member _.IncludeEmptyFields(state: FieldCapsRequest, value: bool) =
            { state with IncludeEmptyFields = Some value }

        [<CustomOperation("bodyFields")>]
        member _.BodyFields(state: FieldCapsRequest, value: Types.Fields) =
            { state with bodyFields = Some value }

        [<CustomOperation("indexFilter")>]
        member _.IndexFilter(state: FieldCapsRequest, value: Types.QueryContainer) =
            { state with IndexFilter = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: FieldCapsRequest, value: Types.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: FieldCapsRequest, value: Types.ProjectRouting) =
            { state with ProjectRouting = Some value }

    let fieldCapsRequest = FieldCapsRequestBuilder()

    module FieldCaps =
        let withAllowNoIndices (value: bool) (req: FieldCapsRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: FieldCapsRequest) =
            { req with ExpandWildcards = Some value }
        let withFields (value: Types.Fields) (req: FieldCapsRequest) =
            { req with Fields = Some value }
        let withIgnoreUnavailable (value: bool) (req: FieldCapsRequest) =
            { req with IgnoreUnavailable = Some value }
        let withIncludeUnmapped (value: bool) (req: FieldCapsRequest) =
            { req with IncludeUnmapped = Some value }
        let withFilters (value: System.Text.Json.JsonElement) (req: FieldCapsRequest) =
            { req with Filters = Some value }
        let withTypes (value: string list) (req: FieldCapsRequest) =
            { req with Types = Some value }
        let withIncludeEmptyFields (value: bool) (req: FieldCapsRequest) =
            { req with IncludeEmptyFields = Some value }
        let withBodyFields (value: Types.Fields) (req: FieldCapsRequest) =
            { req with bodyFields = Some value }
        let withIndexFilter (value: Types.QueryContainer) (req: FieldCapsRequest) =
            { req with IndexFilter = Some value }
        let withRuntimeMappings (value: Types.RuntimeFields) (req: FieldCapsRequest) =
            { req with RuntimeMappings = Some value }
        let withProjectRouting (value: Types.ProjectRouting) (req: FieldCapsRequest) =
            { req with ProjectRouting = Some value }

    type GetRequest = {
        Id: Types.Id
        Index: Types.IndexName
        ForceSyntheticSource: bool option
        Preference: string option
        Realtime: bool option
        Refresh: bool option
        Routing: Types.Routing option
        Source: Types.SourceConfigParam option
        SourceExcludes: Types.Fields option
        SourceExcludeVectors: bool option
        SourceIncludes: Types.Fields option
        StoredFields: Types.Fields option
        Version: Types.VersionNumber option
        VersionType: Types.VersionType option
    }

        with
        static member ToEndpoint(req: GetRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_doc/{Fes.Http.toPathSegment req.Id}"
            let queryParams =
                [
                    req.ForceSyntheticSource |> Option.map (fun v -> "force_synthetic_source", Fes.Http.toQueryValue v)
                    req.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                    req.Realtime |> Option.map (fun v -> "realtime", Fes.Http.toQueryValue v)
                    req.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                    req.Source |> Option.map (fun v -> "_source", Fes.Http.toQueryValue v)
                    req.SourceExcludes |> Option.map (fun v -> "_source_excludes", Fes.Http.toQueryValue v)
                    req.SourceExcludeVectors |> Option.map (fun v -> "_source_exclude_vectors", Fes.Http.toQueryValue v)
                    req.SourceIncludes |> Option.map (fun v -> "_source_includes", Fes.Http.toQueryValue v)
                    req.StoredFields |> Option.map (fun v -> "stored_fields", Fes.Http.toQueryValue v)
                    req.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                    req.VersionType |> Option.map (fun v -> "version_type", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type GetResponse<'TDocument> = Types.GetResult<'TDocument>

    type GetRequestBuilder() =
        member _.Yield(_: unit) : GetRequest =
            {
                Id = Unchecked.defaultof<_>
                Index = Unchecked.defaultof<_>
                ForceSyntheticSource = None
                Preference = None
                Realtime = None
                Refresh = None
                Routing = None
                Source = None
                SourceExcludes = None
                SourceExcludeVectors = None
                SourceIncludes = None
                StoredFields = None
                Version = None
                VersionType = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: GetRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: GetRequest, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("forceSyntheticSource")>]
        member _.ForceSyntheticSource(state: GetRequest, value: bool) =
            { state with ForceSyntheticSource = Some value }

        [<CustomOperation("preference")>]
        member _.Preference(state: GetRequest, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("realtime")>]
        member _.Realtime(state: GetRequest, value: bool) =
            { state with Realtime = Some value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: GetRequest, value: bool) =
            { state with Refresh = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: GetRequest, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: GetRequest, value: Types.SourceConfigParam) =
            { state with Source = Some value }

        [<CustomOperation("sourceExcludes")>]
        member _.SourceExcludes(state: GetRequest, value: Types.Fields) =
            { state with SourceExcludes = Some value }

        [<CustomOperation("sourceExcludeVectors")>]
        member _.SourceExcludeVectors(state: GetRequest, value: bool) =
            { state with SourceExcludeVectors = Some value }

        [<CustomOperation("sourceIncludes")>]
        member _.SourceIncludes(state: GetRequest, value: Types.Fields) =
            { state with SourceIncludes = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: GetRequest, value: Types.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: GetRequest, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: GetRequest, value: Types.VersionType) =
            { state with VersionType = Some value }

    let getRequest = GetRequestBuilder()

    module Get =
        let withForceSyntheticSource (value: bool) (req: GetRequest) =
            { req with ForceSyntheticSource = Some value }
        let withPreference (value: string) (req: GetRequest) =
            { req with Preference = Some value }
        let withRealtime (value: bool) (req: GetRequest) =
            { req with Realtime = Some value }
        let withRefresh (value: bool) (req: GetRequest) =
            { req with Refresh = Some value }
        let withRouting (value: Types.Routing) (req: GetRequest) =
            { req with Routing = Some value }
        let withSource (value: Types.SourceConfigParam) (req: GetRequest) =
            { req with Source = Some value }
        let withSourceExcludes (value: Types.Fields) (req: GetRequest) =
            { req with SourceExcludes = Some value }
        let withSourceExcludeVectors (value: bool) (req: GetRequest) =
            { req with SourceExcludeVectors = Some value }
        let withSourceIncludes (value: Types.Fields) (req: GetRequest) =
            { req with SourceIncludes = Some value }
        let withStoredFields (value: Types.Fields) (req: GetRequest) =
            { req with StoredFields = Some value }
        let withVersion (value: Types.VersionNumber) (req: GetRequest) =
            { req with Version = Some value }
        let withVersionType (value: Types.VersionType) (req: GetRequest) =
            { req with VersionType = Some value }

    type GetScriptRequest = {
        Id: Types.Id
        MasterTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: GetScriptRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_scripts/{Fes.Http.toPathSegment req.Id}"
            let queryParams =
                [
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type GetScriptResponse = System.Text.Json.JsonElement

    type GetScriptRequestBuilder() =
        member _.Yield(_: unit) : GetScriptRequest =
            {
                Id = Unchecked.defaultof<_>
                MasterTimeout = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: GetScriptRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: GetScriptRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let getScriptRequest = GetScriptRequestBuilder()

    module GetScript =
        let withMasterTimeout (value: Types.Duration) (req: GetScriptRequest) =
            { req with MasterTimeout = Some value }

    type GetScriptContextRequest = | GetScriptContextRequest

        with
        static member ToEndpoint(req: GetScriptContextRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_script_context"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type GetScriptContextResponse = System.Text.Json.JsonElement

    type GetScriptLanguagesRequest = | GetScriptLanguagesRequest

        with
        static member ToEndpoint(req: GetScriptLanguagesRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_script_language"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type GetScriptLanguagesResponse = System.Text.Json.JsonElement

    type GetSourceRequest = {
        Id: Types.Id
        Index: Types.IndexName
        Preference: string option
        Realtime: bool option
        Refresh: bool option
        Routing: Types.Routing option
        Source: Types.SourceConfigParam option
        SourceExcludes: Types.Fields option
        SourceIncludes: Types.Fields option
        Version: Types.VersionNumber option
        VersionType: Types.VersionType option
    }

        with
        static member ToEndpoint(req: GetSourceRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_source/{Fes.Http.toPathSegment req.Id}"
            let queryParams =
                [
                    req.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                    req.Realtime |> Option.map (fun v -> "realtime", Fes.Http.toQueryValue v)
                    req.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                    req.Source |> Option.map (fun v -> "_source", Fes.Http.toQueryValue v)
                    req.SourceExcludes |> Option.map (fun v -> "_source_excludes", Fes.Http.toQueryValue v)
                    req.SourceIncludes |> Option.map (fun v -> "_source_includes", Fes.Http.toQueryValue v)
                    req.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                    req.VersionType |> Option.map (fun v -> "version_type", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type GetSourceResponse<'TDocument> = 'TDocument

    type GetSourceRequestBuilder() =
        member _.Yield(_: unit) : GetSourceRequest =
            {
                Id = Unchecked.defaultof<_>
                Index = Unchecked.defaultof<_>
                Preference = None
                Realtime = None
                Refresh = None
                Routing = None
                Source = None
                SourceExcludes = None
                SourceIncludes = None
                Version = None
                VersionType = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: GetSourceRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: GetSourceRequest, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("preference")>]
        member _.Preference(state: GetSourceRequest, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("realtime")>]
        member _.Realtime(state: GetSourceRequest, value: bool) =
            { state with Realtime = Some value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: GetSourceRequest, value: bool) =
            { state with Refresh = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: GetSourceRequest, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: GetSourceRequest, value: Types.SourceConfigParam) =
            { state with Source = Some value }

        [<CustomOperation("sourceExcludes")>]
        member _.SourceExcludes(state: GetSourceRequest, value: Types.Fields) =
            { state with SourceExcludes = Some value }

        [<CustomOperation("sourceIncludes")>]
        member _.SourceIncludes(state: GetSourceRequest, value: Types.Fields) =
            { state with SourceIncludes = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: GetSourceRequest, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: GetSourceRequest, value: Types.VersionType) =
            { state with VersionType = Some value }

    let getSourceRequest = GetSourceRequestBuilder()

    module GetSource =
        let withPreference (value: string) (req: GetSourceRequest) =
            { req with Preference = Some value }
        let withRealtime (value: bool) (req: GetSourceRequest) =
            { req with Realtime = Some value }
        let withRefresh (value: bool) (req: GetSourceRequest) =
            { req with Refresh = Some value }
        let withRouting (value: Types.Routing) (req: GetSourceRequest) =
            { req with Routing = Some value }
        let withSource (value: Types.SourceConfigParam) (req: GetSourceRequest) =
            { req with Source = Some value }
        let withSourceExcludes (value: Types.Fields) (req: GetSourceRequest) =
            { req with SourceExcludes = Some value }
        let withSourceIncludes (value: Types.Fields) (req: GetSourceRequest) =
            { req with SourceIncludes = Some value }
        let withVersion (value: Types.VersionNumber) (req: GetSourceRequest) =
            { req with Version = Some value }
        let withVersionType (value: Types.VersionType) (req: GetSourceRequest) =
            { req with VersionType = Some value }

    type HealthReportRequest = {
        Feature: System.Text.Json.JsonElement
        Timeout: Types.Duration option
        Verbose: bool option
        Size: Types.Integer option
    }

        with
        static member ToEndpoint(req: HealthReportRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_health_report/{Fes.Http.toPathSegment req.Feature}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    req.Verbose |> Option.map (fun v -> "verbose", Fes.Http.toQueryValue v)
                    req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type HealthReportResponse = System.Text.Json.JsonElement

    type HealthReportRequestBuilder() =
        member _.Yield(_: unit) : HealthReportRequest =
            {
                Feature = Unchecked.defaultof<_>
                Timeout = None
                Verbose = None
                Size = None
            }

        [<CustomOperation("feature")>]
        member _.Feature(state: HealthReportRequest, value: System.Text.Json.JsonElement) =
            { state with Feature = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: HealthReportRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("verbose")>]
        member _.Verbose(state: HealthReportRequest, value: bool) =
            { state with Verbose = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: HealthReportRequest, value: Types.Integer) =
            { state with Size = Some value }

    let healthReportRequest = HealthReportRequestBuilder()

    module HealthReport =
        let withTimeout (value: Types.Duration) (req: HealthReportRequest) =
            { req with Timeout = Some value }
        let withVerbose (value: bool) (req: HealthReportRequest) =
            { req with Verbose = Some value }
        let withSize (value: Types.Integer) (req: HealthReportRequest) =
            { req with Size = Some value }

    type IndexRequest<'TDocument> = {
        Id: Types.Id
        Index: Types.IndexName
        IfPrimaryTerm: Types.Long option
        IfSeqNo: Types.SequenceNumber option
        IncludeSourceOnError: bool option
        OpType: Types.OpType option
        Pipeline: string option
        Refresh: Types.Refresh option
        Routing: Types.Routing option
        Timeout: Types.Duration option
        Version: Types.VersionNumber option
        VersionType: Types.VersionType option
        WaitForActiveShards: Types.WaitForActiveShards option
        RequireAlias: bool option
        RequireDataStream: bool option
        Document: 'TDocument
    }

        with
        static member ToEndpoint(req: IndexRequest<'TDocument>) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_doc/{Fes.Http.toPathSegment req.Id}"
            let queryParams =
                [
                    req.IfPrimaryTerm |> Option.map (fun v -> "if_primary_term", Fes.Http.toQueryValue v)
                    req.IfSeqNo |> Option.map (fun v -> "if_seq_no", Fes.Http.toQueryValue v)
                    req.IncludeSourceOnError |> Option.map (fun v -> "include_source_on_error", Fes.Http.toQueryValue v)
                    req.OpType |> Option.map (fun v -> "op_type", Fes.Http.toQueryValue v)
                    req.Pipeline |> Option.map (fun v -> "pipeline", Fes.Http.toQueryValue v)
                    req.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    req.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                    req.VersionType |> Option.map (fun v -> "version_type", Fes.Http.toQueryValue v)
                    req.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                    req.RequireAlias |> Option.map (fun v -> "require_alias", Fes.Http.toQueryValue v)
                    req.RequireDataStream |> Option.map (fun v -> "require_data_stream", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req.Document)
            endpoint, ValueSome postData

    type IndexResponse = Types.WriteResponseBase

    type IndexRequestBuilder() =
        member _.Yield(_: unit) : IndexRequest<_> =
            {
                Id = Unchecked.defaultof<_>
                Index = Unchecked.defaultof<_>
                IfPrimaryTerm = None
                IfSeqNo = None
                IncludeSourceOnError = None
                OpType = None
                Pipeline = None
                Refresh = None
                Routing = None
                Timeout = None
                Version = None
                VersionType = None
                WaitForActiveShards = None
                RequireAlias = None
                RequireDataStream = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: IndexRequest<_>, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: IndexRequest<_>, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("ifPrimaryTerm")>]
        member _.IfPrimaryTerm(state: IndexRequest<_>, value: Types.Long) =
            { state with IfPrimaryTerm = Some value }

        [<CustomOperation("ifSeqNo")>]
        member _.IfSeqNo(state: IndexRequest<_>, value: Types.SequenceNumber) =
            { state with IfSeqNo = Some value }

        [<CustomOperation("includeSourceOnError")>]
        member _.IncludeSourceOnError(state: IndexRequest<_>, value: bool) =
            { state with IncludeSourceOnError = Some value }

        [<CustomOperation("opType")>]
        member _.OpType(state: IndexRequest<_>, value: Types.OpType) =
            { state with OpType = Some value }

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: IndexRequest<_>, value: string) =
            { state with Pipeline = Some value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: IndexRequest<_>, value: Types.Refresh) =
            { state with Refresh = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: IndexRequest<_>, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndexRequest<_>, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: IndexRequest<_>, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: IndexRequest<_>, value: Types.VersionType) =
            { state with VersionType = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: IndexRequest<_>, value: Types.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

        [<CustomOperation("requireAlias")>]
        member _.RequireAlias(state: IndexRequest<_>, value: bool) =
            { state with RequireAlias = Some value }

        [<CustomOperation("requireDataStream")>]
        member _.RequireDataStream(state: IndexRequest<_>, value: bool) =
            { state with RequireDataStream = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: IndexRequest<_>, value) =
            { state with Document = value }

    let indexRequest = IndexRequestBuilder()

    module Index =
        let withIfPrimaryTerm (value: Types.Long) (req: IndexRequest<_>) =
            { req with IfPrimaryTerm = Some value }
        let withIfSeqNo (value: Types.SequenceNumber) (req: IndexRequest<_>) =
            { req with IfSeqNo = Some value }
        let withIncludeSourceOnError (value: bool) (req: IndexRequest<_>) =
            { req with IncludeSourceOnError = Some value }
        let withOpType (value: Types.OpType) (req: IndexRequest<_>) =
            { req with OpType = Some value }
        let withPipeline (value: string) (req: IndexRequest<_>) =
            { req with Pipeline = Some value }
        let withRefresh (value: Types.Refresh) (req: IndexRequest<_>) =
            { req with Refresh = Some value }
        let withRouting (value: Types.Routing) (req: IndexRequest<_>) =
            { req with Routing = Some value }
        let withTimeout (value: Types.Duration) (req: IndexRequest<_>) =
            { req with Timeout = Some value }
        let withVersion (value: Types.VersionNumber) (req: IndexRequest<_>) =
            { req with Version = Some value }
        let withVersionType (value: Types.VersionType) (req: IndexRequest<_>) =
            { req with VersionType = Some value }
        let withWaitForActiveShards (value: Types.WaitForActiveShards) (req: IndexRequest<_>) =
            { req with WaitForActiveShards = Some value }
        let withRequireAlias (value: bool) (req: IndexRequest<_>) =
            { req with RequireAlias = Some value }
        let withRequireDataStream (value: bool) (req: IndexRequest<_>) =
            { req with RequireDataStream = Some value }

    type InfoRequest = | InfoRequest

        with
        static member ToEndpoint(req: InfoRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type InfoResponse = System.Text.Json.JsonElement

    type KnnSearchRequest = {
        Index: Types.Indices
        Routing: Types.Routing option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: Types.SourceConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("docvalue_fields")>]
        DocvalueFields: Types.FieldAndFormat list option
        [<System.Text.Json.Serialization.JsonPropertyName("stored_fields")>]
        StoredFields: Types.Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Types.Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("knn")>]
        Knn: Types.KnnSearchQuery
    }

        with
        static member ToEndpoint(req: KnnSearchRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_knn_search"
            let queryParams =
                [
                    req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type KnnSearchResponse = System.Text.Json.JsonElement

    type KnnSearchRequestBuilder() =
        member _.Yield(_: unit) : KnnSearchRequest =
            {
                Index = Unchecked.defaultof<_>
                Routing = None
                Source = None
                DocvalueFields = None
                StoredFields = None
                Fields = None
                Filter = None
                Knn = Unchecked.defaultof<_>
            }

        [<CustomOperation("index")>]
        member _.Index(state: KnnSearchRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("routing")>]
        member _.Routing(state: KnnSearchRequest, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: KnnSearchRequest, value: Types.SourceConfig) =
            { state with Source = Some value }

        [<CustomOperation("docvalueFields")>]
        member _.DocvalueFields(state: KnnSearchRequest, value: Types.FieldAndFormat list) =
            { state with DocvalueFields = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: KnnSearchRequest, value: Types.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: KnnSearchRequest, value: Types.Fields) =
            { state with Fields = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: KnnSearchRequest, value: System.Text.Json.JsonElement) =
            { state with Filter = Some value }

        [<CustomOperation("knn")>]
        member _.Knn(state: KnnSearchRequest, value: Types.KnnSearchQuery) =
            { state with Knn = value }

    let knnSearchRequest = KnnSearchRequestBuilder()

    module KnnSearch =
        let withRouting (value: Types.Routing) (req: KnnSearchRequest) =
            { req with Routing = Some value }
        let withSource (value: Types.SourceConfig) (req: KnnSearchRequest) =
            { req with Source = Some value }
        let withDocvalueFields (value: Types.FieldAndFormat list) (req: KnnSearchRequest) =
            { req with DocvalueFields = Some value }
        let withStoredFields (value: Types.Fields) (req: KnnSearchRequest) =
            { req with StoredFields = Some value }
        let withFields (value: Types.Fields) (req: KnnSearchRequest) =
            { req with Fields = Some value }
        let withFilter (value: System.Text.Json.JsonElement) (req: KnnSearchRequest) =
            { req with Filter = Some value }
        let withKnn (value: Types.KnnSearchQuery) (req: KnnSearchRequest) =
            { req with Knn = value }

    type MgetRequest = {
        Index: Types.IndexName
        ForceSyntheticSource: bool option
        Preference: string option
        Realtime: bool option
        Refresh: bool option
        Routing: Types.Routing option
        Source: Types.SourceConfigParam option
        SourceExcludes: Types.Fields option
        SourceIncludes: Types.Fields option
        StoredFields: Types.Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("docs")>]
        Docs: Types.GlobalMgetOperation list option
        [<System.Text.Json.Serialization.JsonPropertyName("ids")>]
        Ids: Types.Ids option
    }

        with
        static member ToEndpoint(req: MgetRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_mget"
            let queryParams =
                [
                    req.ForceSyntheticSource |> Option.map (fun v -> "force_synthetic_source", Fes.Http.toQueryValue v)
                    req.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                    req.Realtime |> Option.map (fun v -> "realtime", Fes.Http.toQueryValue v)
                    req.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                    req.Source |> Option.map (fun v -> "_source", Fes.Http.toQueryValue v)
                    req.SourceExcludes |> Option.map (fun v -> "_source_excludes", Fes.Http.toQueryValue v)
                    req.SourceIncludes |> Option.map (fun v -> "_source_includes", Fes.Http.toQueryValue v)
                    req.StoredFields |> Option.map (fun v -> "stored_fields", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type MgetResponse = System.Text.Json.JsonElement

    type MgetRequestBuilder() =
        member _.Yield(_: unit) : MgetRequest =
            {
                Index = Unchecked.defaultof<_>
                ForceSyntheticSource = None
                Preference = None
                Realtime = None
                Refresh = None
                Routing = None
                Source = None
                SourceExcludes = None
                SourceIncludes = None
                StoredFields = None
                Docs = None
                Ids = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: MgetRequest, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("forceSyntheticSource")>]
        member _.ForceSyntheticSource(state: MgetRequest, value: bool) =
            { state with ForceSyntheticSource = Some value }

        [<CustomOperation("preference")>]
        member _.Preference(state: MgetRequest, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("realtime")>]
        member _.Realtime(state: MgetRequest, value: bool) =
            { state with Realtime = Some value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: MgetRequest, value: bool) =
            { state with Refresh = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: MgetRequest, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: MgetRequest, value: Types.SourceConfigParam) =
            { state with Source = Some value }

        [<CustomOperation("sourceExcludes")>]
        member _.SourceExcludes(state: MgetRequest, value: Types.Fields) =
            { state with SourceExcludes = Some value }

        [<CustomOperation("sourceIncludes")>]
        member _.SourceIncludes(state: MgetRequest, value: Types.Fields) =
            { state with SourceIncludes = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: MgetRequest, value: Types.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("docs")>]
        member _.Docs(state: MgetRequest, value: Types.GlobalMgetOperation list) =
            { state with Docs = Some value }

        [<CustomOperation("ids")>]
        member _.Ids(state: MgetRequest, value: Types.Ids) =
            { state with Ids = Some value }

    let mgetRequest = MgetRequestBuilder()

    module Mget =
        let withForceSyntheticSource (value: bool) (req: MgetRequest) =
            { req with ForceSyntheticSource = Some value }
        let withPreference (value: string) (req: MgetRequest) =
            { req with Preference = Some value }
        let withRealtime (value: bool) (req: MgetRequest) =
            { req with Realtime = Some value }
        let withRefresh (value: bool) (req: MgetRequest) =
            { req with Refresh = Some value }
        let withRouting (value: Types.Routing) (req: MgetRequest) =
            { req with Routing = Some value }
        let withSource (value: Types.SourceConfigParam) (req: MgetRequest) =
            { req with Source = Some value }
        let withSourceExcludes (value: Types.Fields) (req: MgetRequest) =
            { req with SourceExcludes = Some value }
        let withSourceIncludes (value: Types.Fields) (req: MgetRequest) =
            { req with SourceIncludes = Some value }
        let withStoredFields (value: Types.Fields) (req: MgetRequest) =
            { req with StoredFields = Some value }
        let withDocs (value: Types.GlobalMgetOperation list) (req: MgetRequest) =
            { req with Docs = Some value }
        let withIds (value: Types.Ids) (req: MgetRequest) =
            { req with Ids = Some value }

    type MsearchRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        CcsMinimizeRoundtrips: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreThrottled: bool option
        IgnoreUnavailable: bool option
        IncludeNamedQueriesScore: bool option
        queryIndex: Types.Indices option
        MaxConcurrentSearches: Types.Integer option
        MaxConcurrentShardRequests: Types.Integer option
        PreFilterShardSize: Types.Long option
        ProjectRouting: Types.ProjectRouting option
        RestTotalHitsAsInt: bool option
        Routing: Types.Routing option
        SearchType: Types.SearchType option
        TypedKeys: bool option
        Document: Types.GlobalMsearchRequestItem list
    }

        with
        static member ToEndpoint(req: MsearchRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_msearch"
            let queryParams =
                [
                    req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                    req.CcsMinimizeRoundtrips |> Option.map (fun v -> "ccs_minimize_roundtrips", Fes.Http.toQueryValue v)
                    req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                    req.IgnoreThrottled |> Option.map (fun v -> "ignore_throttled", Fes.Http.toQueryValue v)
                    req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                    req.IncludeNamedQueriesScore |> Option.map (fun v -> "include_named_queries_score", Fes.Http.toQueryValue v)
                    req.queryIndex |> Option.map (fun v -> "index", Fes.Http.toQueryValue v)
                    req.MaxConcurrentSearches |> Option.map (fun v -> "max_concurrent_searches", Fes.Http.toQueryValue v)
                    req.MaxConcurrentShardRequests |> Option.map (fun v -> "max_concurrent_shard_requests", Fes.Http.toQueryValue v)
                    req.PreFilterShardSize |> Option.map (fun v -> "pre_filter_shard_size", Fes.Http.toQueryValue v)
                    req.ProjectRouting |> Option.map (fun v -> "project_routing", Fes.Http.toQueryValue v)
                    req.RestTotalHitsAsInt |> Option.map (fun v -> "rest_total_hits_as_int", Fes.Http.toQueryValue v)
                    req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                    req.SearchType |> Option.map (fun v -> "search_type", Fes.Http.toQueryValue v)
                    req.TypedKeys |> Option.map (fun v -> "typed_keys", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req.Document)
            endpoint, ValueSome postData

    type MsearchResponse<'TDocument> = Types.MultiSearchResult<'TDocument>

    type MsearchRequestBuilder() =
        member _.Yield(_: unit) : MsearchRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                CcsMinimizeRoundtrips = None
                ExpandWildcards = None
                IgnoreThrottled = None
                IgnoreUnavailable = None
                IncludeNamedQueriesScore = None
                queryIndex = None
                MaxConcurrentSearches = None
                MaxConcurrentShardRequests = None
                PreFilterShardSize = None
                ProjectRouting = None
                RestTotalHitsAsInt = None
                Routing = None
                SearchType = None
                TypedKeys = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("index")>]
        member _.Index(state: MsearchRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: MsearchRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("ccsMinimizeRoundtrips")>]
        member _.CcsMinimizeRoundtrips(state: MsearchRequest, value: bool) =
            { state with CcsMinimizeRoundtrips = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: MsearchRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreThrottled")>]
        member _.IgnoreThrottled(state: MsearchRequest, value: bool) =
            { state with IgnoreThrottled = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: MsearchRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("includeNamedQueriesScore")>]
        member _.IncludeNamedQueriesScore(state: MsearchRequest, value: bool) =
            { state with IncludeNamedQueriesScore = Some value }

        [<CustomOperation("queryIndex")>]
        member _.QueryIndex(state: MsearchRequest, value: Types.Indices) =
            { state with queryIndex = Some value }

        [<CustomOperation("maxConcurrentSearches")>]
        member _.MaxConcurrentSearches(state: MsearchRequest, value: Types.Integer) =
            { state with MaxConcurrentSearches = Some value }

        [<CustomOperation("maxConcurrentShardRequests")>]
        member _.MaxConcurrentShardRequests(state: MsearchRequest, value: Types.Integer) =
            { state with MaxConcurrentShardRequests = Some value }

        [<CustomOperation("preFilterShardSize")>]
        member _.PreFilterShardSize(state: MsearchRequest, value: Types.Long) =
            { state with PreFilterShardSize = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: MsearchRequest, value: Types.ProjectRouting) =
            { state with ProjectRouting = Some value }

        [<CustomOperation("restTotalHitsAsInt")>]
        member _.RestTotalHitsAsInt(state: MsearchRequest, value: bool) =
            { state with RestTotalHitsAsInt = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: MsearchRequest, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("searchType")>]
        member _.SearchType(state: MsearchRequest, value: Types.SearchType) =
            { state with SearchType = Some value }

        [<CustomOperation("typedKeys")>]
        member _.TypedKeys(state: MsearchRequest, value: bool) =
            { state with TypedKeys = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: MsearchRequest, value) =
            { state with Document = value }

    let msearchRequest = MsearchRequestBuilder()

    module Msearch =
        let withAllowNoIndices (value: bool) (req: MsearchRequest) =
            { req with AllowNoIndices = Some value }
        let withCcsMinimizeRoundtrips (value: bool) (req: MsearchRequest) =
            { req with CcsMinimizeRoundtrips = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: MsearchRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreThrottled (value: bool) (req: MsearchRequest) =
            { req with IgnoreThrottled = Some value }
        let withIgnoreUnavailable (value: bool) (req: MsearchRequest) =
            { req with IgnoreUnavailable = Some value }
        let withIncludeNamedQueriesScore (value: bool) (req: MsearchRequest) =
            { req with IncludeNamedQueriesScore = Some value }
        let withIndex (value: Types.Indices) (req: MsearchRequest) =
            { req with queryIndex = Some value }
        let withMaxConcurrentSearches (value: Types.Integer) (req: MsearchRequest) =
            { req with MaxConcurrentSearches = Some value }
        let withMaxConcurrentShardRequests (value: Types.Integer) (req: MsearchRequest) =
            { req with MaxConcurrentShardRequests = Some value }
        let withPreFilterShardSize (value: Types.Long) (req: MsearchRequest) =
            { req with PreFilterShardSize = Some value }
        let withProjectRouting (value: Types.ProjectRouting) (req: MsearchRequest) =
            { req with ProjectRouting = Some value }
        let withRestTotalHitsAsInt (value: bool) (req: MsearchRequest) =
            { req with RestTotalHitsAsInt = Some value }
        let withRouting (value: Types.Routing) (req: MsearchRequest) =
            { req with Routing = Some value }
        let withSearchType (value: Types.SearchType) (req: MsearchRequest) =
            { req with SearchType = Some value }
        let withTypedKeys (value: bool) (req: MsearchRequest) =
            { req with TypedKeys = Some value }

    type MsearchTemplateRequest = {
        Index: Types.Indices
        CcsMinimizeRoundtrips: bool option
        MaxConcurrentSearches: Types.Long option
        ProjectRouting: Types.ProjectRouting option
        SearchType: Types.SearchType option
        RestTotalHitsAsInt: bool option
        TypedKeys: bool option
        Document: Types.GlobalMsearchTemplateRequestItem list
    }

        with
        static member ToEndpoint(req: MsearchTemplateRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_msearch/template"
            let queryParams =
                [
                    req.CcsMinimizeRoundtrips |> Option.map (fun v -> "ccs_minimize_roundtrips", Fes.Http.toQueryValue v)
                    req.MaxConcurrentSearches |> Option.map (fun v -> "max_concurrent_searches", Fes.Http.toQueryValue v)
                    req.ProjectRouting |> Option.map (fun v -> "project_routing", Fes.Http.toQueryValue v)
                    req.SearchType |> Option.map (fun v -> "search_type", Fes.Http.toQueryValue v)
                    req.RestTotalHitsAsInt |> Option.map (fun v -> "rest_total_hits_as_int", Fes.Http.toQueryValue v)
                    req.TypedKeys |> Option.map (fun v -> "typed_keys", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req.Document)
            endpoint, ValueSome postData

    type MsearchTemplateResponse<'TDocument> = Types.MultiSearchResult<'TDocument>

    type MsearchTemplateRequestBuilder() =
        member _.Yield(_: unit) : MsearchTemplateRequest =
            {
                Index = Unchecked.defaultof<_>
                CcsMinimizeRoundtrips = None
                MaxConcurrentSearches = None
                ProjectRouting = None
                SearchType = None
                RestTotalHitsAsInt = None
                TypedKeys = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("index")>]
        member _.Index(state: MsearchTemplateRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("ccsMinimizeRoundtrips")>]
        member _.CcsMinimizeRoundtrips(state: MsearchTemplateRequest, value: bool) =
            { state with CcsMinimizeRoundtrips = Some value }

        [<CustomOperation("maxConcurrentSearches")>]
        member _.MaxConcurrentSearches(state: MsearchTemplateRequest, value: Types.Long) =
            { state with MaxConcurrentSearches = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: MsearchTemplateRequest, value: Types.ProjectRouting) =
            { state with ProjectRouting = Some value }

        [<CustomOperation("searchType")>]
        member _.SearchType(state: MsearchTemplateRequest, value: Types.SearchType) =
            { state with SearchType = Some value }

        [<CustomOperation("restTotalHitsAsInt")>]
        member _.RestTotalHitsAsInt(state: MsearchTemplateRequest, value: bool) =
            { state with RestTotalHitsAsInt = Some value }

        [<CustomOperation("typedKeys")>]
        member _.TypedKeys(state: MsearchTemplateRequest, value: bool) =
            { state with TypedKeys = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: MsearchTemplateRequest, value) =
            { state with Document = value }

    let msearchTemplateRequest = MsearchTemplateRequestBuilder()

    module MsearchTemplate =
        let withCcsMinimizeRoundtrips (value: bool) (req: MsearchTemplateRequest) =
            { req with CcsMinimizeRoundtrips = Some value }
        let withMaxConcurrentSearches (value: Types.Long) (req: MsearchTemplateRequest) =
            { req with MaxConcurrentSearches = Some value }
        let withProjectRouting (value: Types.ProjectRouting) (req: MsearchTemplateRequest) =
            { req with ProjectRouting = Some value }
        let withSearchType (value: Types.SearchType) (req: MsearchTemplateRequest) =
            { req with SearchType = Some value }
        let withRestTotalHitsAsInt (value: bool) (req: MsearchTemplateRequest) =
            { req with RestTotalHitsAsInt = Some value }
        let withTypedKeys (value: bool) (req: MsearchTemplateRequest) =
            { req with TypedKeys = Some value }

    type MtermvectorsRequest = {
        Index: Types.IndexName
        Ids: Types.Id list option
        Fields: Types.Fields option
        FieldStatistics: bool option
        Offsets: bool option
        Payloads: bool option
        Positions: bool option
        Preference: string option
        Realtime: bool option
        Routing: Types.Routing option
        TermStatistics: bool option
        Version: Types.VersionNumber option
        VersionType: Types.VersionType option
        [<System.Text.Json.Serialization.JsonPropertyName("docs")>]
        Docs: Types.GlobalMtermvectorsOperation list option
        [<System.Text.Json.Serialization.JsonPropertyName("ids")>]
        bodyIds: Types.Id list option
    }

        with
        static member ToEndpoint(req: MtermvectorsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_mtermvectors"
            let queryParams =
                [
                    req.Ids |> Option.map (fun v -> "ids", Fes.Http.toQueryValue v)
                    req.Fields |> Option.map (fun v -> "fields", Fes.Http.toQueryValue v)
                    req.FieldStatistics |> Option.map (fun v -> "field_statistics", Fes.Http.toQueryValue v)
                    req.Offsets |> Option.map (fun v -> "offsets", Fes.Http.toQueryValue v)
                    req.Payloads |> Option.map (fun v -> "payloads", Fes.Http.toQueryValue v)
                    req.Positions |> Option.map (fun v -> "positions", Fes.Http.toQueryValue v)
                    req.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                    req.Realtime |> Option.map (fun v -> "realtime", Fes.Http.toQueryValue v)
                    req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                    req.TermStatistics |> Option.map (fun v -> "term_statistics", Fes.Http.toQueryValue v)
                    req.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                    req.VersionType |> Option.map (fun v -> "version_type", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type MtermvectorsResponse = System.Text.Json.JsonElement

    type MtermvectorsRequestBuilder() =
        member _.Yield(_: unit) : MtermvectorsRequest =
            {
                Index = Unchecked.defaultof<_>
                Ids = None
                Fields = None
                FieldStatistics = None
                Offsets = None
                Payloads = None
                Positions = None
                Preference = None
                Realtime = None
                Routing = None
                TermStatistics = None
                Version = None
                VersionType = None
                Docs = None
                bodyIds = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: MtermvectorsRequest, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("ids")>]
        member _.Ids(state: MtermvectorsRequest, value: Types.Id list) =
            { state with Ids = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: MtermvectorsRequest, value: Types.Fields) =
            { state with Fields = Some value }

        [<CustomOperation("fieldStatistics")>]
        member _.FieldStatistics(state: MtermvectorsRequest, value: bool) =
            { state with FieldStatistics = Some value }

        [<CustomOperation("offsets")>]
        member _.Offsets(state: MtermvectorsRequest, value: bool) =
            { state with Offsets = Some value }

        [<CustomOperation("payloads")>]
        member _.Payloads(state: MtermvectorsRequest, value: bool) =
            { state with Payloads = Some value }

        [<CustomOperation("positions")>]
        member _.Positions(state: MtermvectorsRequest, value: bool) =
            { state with Positions = Some value }

        [<CustomOperation("preference")>]
        member _.Preference(state: MtermvectorsRequest, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("realtime")>]
        member _.Realtime(state: MtermvectorsRequest, value: bool) =
            { state with Realtime = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: MtermvectorsRequest, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("termStatistics")>]
        member _.TermStatistics(state: MtermvectorsRequest, value: bool) =
            { state with TermStatistics = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: MtermvectorsRequest, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: MtermvectorsRequest, value: Types.VersionType) =
            { state with VersionType = Some value }

        [<CustomOperation("docs")>]
        member _.Docs(state: MtermvectorsRequest, value: Types.GlobalMtermvectorsOperation list) =
            { state with Docs = Some value }

        [<CustomOperation("bodyIds")>]
        member _.BodyIds(state: MtermvectorsRequest, value: Types.Id list) =
            { state with bodyIds = Some value }

    let mtermvectorsRequest = MtermvectorsRequestBuilder()

    module Mtermvectors =
        let withIds (value: Types.Id list) (req: MtermvectorsRequest) =
            { req with Ids = Some value }
        let withFields (value: Types.Fields) (req: MtermvectorsRequest) =
            { req with Fields = Some value }
        let withFieldStatistics (value: bool) (req: MtermvectorsRequest) =
            { req with FieldStatistics = Some value }
        let withOffsets (value: bool) (req: MtermvectorsRequest) =
            { req with Offsets = Some value }
        let withPayloads (value: bool) (req: MtermvectorsRequest) =
            { req with Payloads = Some value }
        let withPositions (value: bool) (req: MtermvectorsRequest) =
            { req with Positions = Some value }
        let withPreference (value: string) (req: MtermvectorsRequest) =
            { req with Preference = Some value }
        let withRealtime (value: bool) (req: MtermvectorsRequest) =
            { req with Realtime = Some value }
        let withRouting (value: Types.Routing) (req: MtermvectorsRequest) =
            { req with Routing = Some value }
        let withTermStatistics (value: bool) (req: MtermvectorsRequest) =
            { req with TermStatistics = Some value }
        let withVersion (value: Types.VersionNumber) (req: MtermvectorsRequest) =
            { req with Version = Some value }
        let withVersionType (value: Types.VersionType) (req: MtermvectorsRequest) =
            { req with VersionType = Some value }
        let withDocs (value: Types.GlobalMtermvectorsOperation list) (req: MtermvectorsRequest) =
            { req with Docs = Some value }
        let withBodyIds (value: Types.Id list) (req: MtermvectorsRequest) =
            { req with bodyIds = Some value }

    type OpenPointInTimeRequest = {
        Index: Types.Indices
        KeepAlive: Types.Duration
        IgnoreUnavailable: bool option
        Preference: string option
        Routing: Types.Routing option
        ExpandWildcards: Types.ExpandWildcards option
        AllowPartialSearchResults: bool option
        MaxConcurrentShardRequests: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("index_filter")>]
        IndexFilter: Types.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("project_routing")>]
        ProjectRouting: Types.ProjectRouting option
    }

        with
        static member ToEndpoint(req: OpenPointInTimeRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_pit"
            let queryParams =
                [
                    req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                    req.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                    req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                    req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                    req.AllowPartialSearchResults |> Option.map (fun v -> "allow_partial_search_results", Fes.Http.toQueryValue v)
                    req.MaxConcurrentShardRequests |> Option.map (fun v -> "max_concurrent_shard_requests", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type OpenPointInTimeResponse = System.Text.Json.JsonElement

    type OpenPointInTimeRequestBuilder() =
        member _.Yield(_: unit) : OpenPointInTimeRequest =
            {
                Index = Unchecked.defaultof<_>
                KeepAlive = Unchecked.defaultof<_>
                IgnoreUnavailable = None
                Preference = None
                Routing = None
                ExpandWildcards = None
                AllowPartialSearchResults = None
                MaxConcurrentShardRequests = None
                IndexFilter = None
                ProjectRouting = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: OpenPointInTimeRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("keepAlive")>]
        member _.KeepAlive(state: OpenPointInTimeRequest, value: Types.Duration) =
            { state with KeepAlive = value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: OpenPointInTimeRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("preference")>]
        member _.Preference(state: OpenPointInTimeRequest, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: OpenPointInTimeRequest, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: OpenPointInTimeRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("allowPartialSearchResults")>]
        member _.AllowPartialSearchResults(state: OpenPointInTimeRequest, value: bool) =
            { state with AllowPartialSearchResults = Some value }

        [<CustomOperation("maxConcurrentShardRequests")>]
        member _.MaxConcurrentShardRequests(state: OpenPointInTimeRequest, value: Types.Integer) =
            { state with MaxConcurrentShardRequests = Some value }

        [<CustomOperation("indexFilter")>]
        member _.IndexFilter(state: OpenPointInTimeRequest, value: Types.QueryContainer) =
            { state with IndexFilter = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: OpenPointInTimeRequest, value: Types.ProjectRouting) =
            { state with ProjectRouting = Some value }

    let openPointInTimeRequest = OpenPointInTimeRequestBuilder()

    module OpenPointInTime =
        let withKeepAlive (value: Types.Duration) (req: OpenPointInTimeRequest) =
            { req with KeepAlive = value }
        let withIgnoreUnavailable (value: bool) (req: OpenPointInTimeRequest) =
            { req with IgnoreUnavailable = Some value }
        let withPreference (value: string) (req: OpenPointInTimeRequest) =
            { req with Preference = Some value }
        let withRouting (value: Types.Routing) (req: OpenPointInTimeRequest) =
            { req with Routing = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: OpenPointInTimeRequest) =
            { req with ExpandWildcards = Some value }
        let withAllowPartialSearchResults (value: bool) (req: OpenPointInTimeRequest) =
            { req with AllowPartialSearchResults = Some value }
        let withMaxConcurrentShardRequests (value: Types.Integer) (req: OpenPointInTimeRequest) =
            { req with MaxConcurrentShardRequests = Some value }
        let withIndexFilter (value: Types.QueryContainer) (req: OpenPointInTimeRequest) =
            { req with IndexFilter = Some value }
        let withProjectRouting (value: Types.ProjectRouting) (req: OpenPointInTimeRequest) =
            { req with ProjectRouting = Some value }

    type PingRequest = | PingRequest

        with
        static member ToEndpoint(req: PingRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.HEAD, fullPath)
            endpoint, ValueNone

    type PingResponse = unit

    type PutScriptRequest = {
        Id: Types.Id
        Context: Types.Name
        queryContext: Types.Name option
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.StoredScript
    }

        with
        static member ToEndpoint(req: PutScriptRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_scripts/{Fes.Http.toPathSegment req.Id}/{Fes.Http.toPathSegment req.Context}"
            let queryParams =
                [
                    req.queryContext |> Option.map (fun v -> "context", Fes.Http.toQueryValue v)
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

    type PutScriptResponse = Types.AcknowledgedResponseBase

    type PutScriptRequestBuilder() =
        member _.Yield(_: unit) : PutScriptRequest =
            {
                Id = Unchecked.defaultof<_>
                Context = Unchecked.defaultof<_>
                queryContext = None
                MasterTimeout = None
                Timeout = None
                Script = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: PutScriptRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("context")>]
        member _.Context(state: PutScriptRequest, value: Types.Name) =
            { state with Context = value }

        [<CustomOperation("queryContext")>]
        member _.QueryContext(state: PutScriptRequest, value: Types.Name) =
            { state with queryContext = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: PutScriptRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: PutScriptRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: PutScriptRequest, value: Types.StoredScript) =
            { state with Script = value }

    let putScriptRequest = PutScriptRequestBuilder()

    module PutScript =
        let withContext (value: Types.Name) (req: PutScriptRequest) =
            { req with queryContext = Some value }
        let withMasterTimeout (value: Types.Duration) (req: PutScriptRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: PutScriptRequest) =
            { req with Timeout = Some value }
        let withScript (value: Types.StoredScript) (req: PutScriptRequest) =
            { req with Script = value }

    type RankEvalRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreUnavailable: bool option
        SearchType: Types.SearchType option
        [<System.Text.Json.Serialization.JsonPropertyName("requests")>]
        Requests: Types.RankEvalRequestItem list
        [<System.Text.Json.Serialization.JsonPropertyName("metric")>]
        Metric: Types.RankEvalMetric option
    }

        with
        static member ToEndpoint(req: RankEvalRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_rank_eval"
            let queryParams =
                [
                    req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                    req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                    req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                    req.SearchType |> Option.map (fun v -> "search_type", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type RankEvalResponse = System.Text.Json.JsonElement

    type RankEvalRequestBuilder() =
        member _.Yield(_: unit) : RankEvalRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreUnavailable = None
                SearchType = None
                Requests = Unchecked.defaultof<_>
                Metric = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: RankEvalRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: RankEvalRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: RankEvalRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: RankEvalRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("searchType")>]
        member _.SearchType(state: RankEvalRequest, value: Types.SearchType) =
            { state with SearchType = Some value }

        [<CustomOperation("requests")>]
        member _.Requests(state: RankEvalRequest, value: Types.RankEvalRequestItem list) =
            { state with Requests = value }

        [<CustomOperation("metric")>]
        member _.Metric(state: RankEvalRequest, value: Types.RankEvalMetric) =
            { state with Metric = Some value }

    let rankEvalRequest = RankEvalRequestBuilder()

    module RankEval =
        let withAllowNoIndices (value: bool) (req: RankEvalRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: RankEvalRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreUnavailable (value: bool) (req: RankEvalRequest) =
            { req with IgnoreUnavailable = Some value }
        let withSearchType (value: Types.SearchType) (req: RankEvalRequest) =
            { req with SearchType = Some value }
        let withRequests (value: Types.RankEvalRequestItem list) (req: RankEvalRequest) =
            { req with Requests = value }
        let withMetric (value: Types.RankEvalMetric) (req: RankEvalRequest) =
            { req with Metric = Some value }

    type ReindexRequest = {
        Refresh: bool option
        RequestsPerSecond: Types.Float option
        Scroll: Types.Duration option
        Slices: Types.Slices option
        MaxDocs: Types.Integer option
        Timeout: Types.Duration option
        WaitForActiveShards: Types.WaitForActiveShards option
        WaitForCompletion: bool option
        RequireAlias: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("conflicts")>]
        Conflicts: Types.Conflicts option
        [<System.Text.Json.Serialization.JsonPropertyName("dest")>]
        Dest: Types.GlobalReindexDestination
        [<System.Text.Json.Serialization.JsonPropertyName("max_docs")>]
        bodyMaxDocs: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: Types.GlobalReindexSource
    }

        with
        static member ToEndpoint(req: ReindexRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_reindex"
            let queryParams =
                [
                    req.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    req.RequestsPerSecond |> Option.map (fun v -> "requests_per_second", Fes.Http.toQueryValue v)
                    req.Scroll |> Option.map (fun v -> "scroll", Fes.Http.toQueryValue v)
                    req.Slices |> Option.map (fun v -> "slices", Fes.Http.toQueryValue v)
                    req.MaxDocs |> Option.map (fun v -> "max_docs", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    req.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                    req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                    req.RequireAlias |> Option.map (fun v -> "require_alias", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type ReindexResponse = System.Text.Json.JsonElement

    type ReindexRequestBuilder() =
        member _.Yield(_: unit) : ReindexRequest =
            {
                Refresh = None
                RequestsPerSecond = None
                Scroll = None
                Slices = None
                MaxDocs = None
                Timeout = None
                WaitForActiveShards = None
                WaitForCompletion = None
                RequireAlias = None
                Conflicts = None
                Dest = Unchecked.defaultof<_>
                bodyMaxDocs = None
                Script = None
                Source = Unchecked.defaultof<_>
            }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: ReindexRequest, value: bool) =
            { state with Refresh = Some value }

        [<CustomOperation("requestsPerSecond")>]
        member _.RequestsPerSecond(state: ReindexRequest, value: Types.Float) =
            { state with RequestsPerSecond = Some value }

        [<CustomOperation("scroll")>]
        member _.Scroll(state: ReindexRequest, value: Types.Duration) =
            { state with Scroll = Some value }

        [<CustomOperation("slices")>]
        member _.Slices(state: ReindexRequest, value: Types.Slices) =
            { state with Slices = Some value }

        [<CustomOperation("maxDocs")>]
        member _.MaxDocs(state: ReindexRequest, value: Types.Integer) =
            { state with MaxDocs = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: ReindexRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: ReindexRequest, value: Types.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: ReindexRequest, value: bool) =
            { state with WaitForCompletion = Some value }

        [<CustomOperation("requireAlias")>]
        member _.RequireAlias(state: ReindexRequest, value: bool) =
            { state with RequireAlias = Some value }

        [<CustomOperation("conflicts")>]
        member _.Conflicts(state: ReindexRequest, value: Types.Conflicts) =
            { state with Conflicts = Some value }

        [<CustomOperation("dest")>]
        member _.Dest(state: ReindexRequest, value: Types.GlobalReindexDestination) =
            { state with Dest = value }

        [<CustomOperation("bodyMaxDocs")>]
        member _.BodyMaxDocs(state: ReindexRequest, value: Types.Long) =
            { state with bodyMaxDocs = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: ReindexRequest, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: ReindexRequest, value: Types.GlobalReindexSource) =
            { state with Source = value }

    let reindexRequest = ReindexRequestBuilder()

    module Reindex =
        let withRefresh (value: bool) (req: ReindexRequest) =
            { req with Refresh = Some value }
        let withRequestsPerSecond (value: Types.Float) (req: ReindexRequest) =
            { req with RequestsPerSecond = Some value }
        let withScroll (value: Types.Duration) (req: ReindexRequest) =
            { req with Scroll = Some value }
        let withSlices (value: Types.Slices) (req: ReindexRequest) =
            { req with Slices = Some value }
        let withMaxDocs (value: Types.Integer) (req: ReindexRequest) =
            { req with MaxDocs = Some value }
        let withTimeout (value: Types.Duration) (req: ReindexRequest) =
            { req with Timeout = Some value }
        let withWaitForActiveShards (value: Types.WaitForActiveShards) (req: ReindexRequest) =
            { req with WaitForActiveShards = Some value }
        let withWaitForCompletion (value: bool) (req: ReindexRequest) =
            { req with WaitForCompletion = Some value }
        let withRequireAlias (value: bool) (req: ReindexRequest) =
            { req with RequireAlias = Some value }
        let withConflicts (value: Types.Conflicts) (req: ReindexRequest) =
            { req with Conflicts = Some value }
        let withDest (value: Types.GlobalReindexDestination) (req: ReindexRequest) =
            { req with Dest = value }
        let withBodyMaxDocs (value: Types.Long) (req: ReindexRequest) =
            { req with bodyMaxDocs = Some value }
        let withScript (value: Types.Script) (req: ReindexRequest) =
            { req with Script = Some value }
        let withSource (value: Types.GlobalReindexSource) (req: ReindexRequest) =
            { req with Source = value }

    type ReindexRethrottleRequest = {
        TaskId: Types.Id
        RequestsPerSecond: Types.Float
        GroupBy: Types.GroupBy option
    }

        with
        static member ToEndpoint(req: ReindexRethrottleRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_reindex/{Fes.Http.toPathSegment req.TaskId}/_rethrottle"
            let queryParams =
                [
                    req.GroupBy |> Option.map (fun v -> "group_by", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            endpoint, ValueNone

    type ReindexRethrottleResponse = System.Text.Json.JsonElement

    type ReindexRethrottleRequestBuilder() =
        member _.Yield(_: unit) : ReindexRethrottleRequest =
            {
                TaskId = Unchecked.defaultof<_>
                RequestsPerSecond = Unchecked.defaultof<_>
                GroupBy = None
            }

        [<CustomOperation("taskId")>]
        member _.TaskId(state: ReindexRethrottleRequest, value: Types.Id) =
            { state with TaskId = value }

        [<CustomOperation("requestsPerSecond")>]
        member _.RequestsPerSecond(state: ReindexRethrottleRequest, value: Types.Float) =
            { state with RequestsPerSecond = value }

        [<CustomOperation("groupBy")>]
        member _.GroupBy(state: ReindexRethrottleRequest, value: Types.GroupBy) =
            { state with GroupBy = Some value }

    let reindexRethrottleRequest = ReindexRethrottleRequestBuilder()

    module ReindexRethrottle =
        let withRequestsPerSecond (value: Types.Float) (req: ReindexRethrottleRequest) =
            { req with RequestsPerSecond = value }
        let withGroupBy (value: Types.GroupBy) (req: ReindexRethrottleRequest) =
            { req with GroupBy = Some value }

    type RenderSearchTemplateRequest = {
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        bodyId: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("file")>]
        File: string option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: Types.ScriptSource option
    }

        with
        static member ToEndpoint(req: RenderSearchTemplateRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_render/template/{Fes.Http.toPathSegment req.Id}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type RenderSearchTemplateResponse = System.Text.Json.JsonElement

    type RenderSearchTemplateRequestBuilder() =
        member _.Yield(_: unit) : RenderSearchTemplateRequest =
            {
                Id = Unchecked.defaultof<_>
                bodyId = None
                File = None
                Params = None
                Source = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: RenderSearchTemplateRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("id")>]
        member _.BodyId(state: RenderSearchTemplateRequest, value: Types.Id) =
            { state with bodyId = Some value }

        [<CustomOperation("file")>]
        member _.File(state: RenderSearchTemplateRequest, value: string) =
            { state with File = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: RenderSearchTemplateRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: RenderSearchTemplateRequest, value: Types.ScriptSource) =
            { state with Source = Some value }

    let renderSearchTemplateRequest = RenderSearchTemplateRequestBuilder()

    module RenderSearchTemplate =
        let withBodyId (value: Types.Id) (req: RenderSearchTemplateRequest) =
            { req with bodyId = Some value }
        let withFile (value: string) (req: RenderSearchTemplateRequest) =
            { req with File = Some value }
        let withParams (value: Map<string, System.Text.Json.JsonElement>) (req: RenderSearchTemplateRequest) =
            { req with Params = Some value }
        let withSource (value: Types.ScriptSource) (req: RenderSearchTemplateRequest) =
            { req with Source = Some value }

    type ScriptsPainlessExecuteRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("context")>]
        Context: Types.PainlessContext option
        [<System.Text.Json.Serialization.JsonPropertyName("context_setup")>]
        ContextSetup: Types.PainlessContextSetup option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
    }

        with
        static member ToEndpoint(req: ScriptsPainlessExecuteRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_scripts/painless/_execute"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type ScriptsPainlessExecuteResponse = System.Text.Json.JsonElement

    type ScriptsPainlessExecuteRequestBuilder() =
        member _.Yield(_: unit) : ScriptsPainlessExecuteRequest =
            {
                Context = None
                ContextSetup = None
                Script = None
            }

        [<CustomOperation("context")>]
        member _.Context(state: ScriptsPainlessExecuteRequest, value: Types.PainlessContext) =
            { state with Context = Some value }

        [<CustomOperation("contextSetup")>]
        member _.ContextSetup(state: ScriptsPainlessExecuteRequest, value: Types.PainlessContextSetup) =
            { state with ContextSetup = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: ScriptsPainlessExecuteRequest, value: Types.Script) =
            { state with Script = Some value }

    let scriptsPainlessExecuteRequest = ScriptsPainlessExecuteRequestBuilder()

    module ScriptsPainlessExecute =
        let withContext (value: Types.PainlessContext) (req: ScriptsPainlessExecuteRequest) =
            { req with Context = Some value }
        let withContextSetup (value: Types.PainlessContextSetup) (req: ScriptsPainlessExecuteRequest) =
            { req with ContextSetup = Some value }
        let withScript (value: Types.Script) (req: ScriptsPainlessExecuteRequest) =
            { req with Script = Some value }

    type ScrollRequest = {
        ScrollId: Types.ScrollId
        Scroll: Types.Duration option
        queryScrollId: Types.ScrollId option
        RestTotalHitsAsInt: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("scroll")>]
        bodyScroll: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("scroll_id")>]
        bodyScrollId: Types.ScrollId
    }

        with
        static member ToEndpoint(req: ScrollRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_search/scroll/{Fes.Http.toPathSegment req.ScrollId}"
            let queryParams =
                [
                    req.Scroll |> Option.map (fun v -> "scroll", Fes.Http.toQueryValue v)
                    req.queryScrollId |> Option.map (fun v -> "scroll_id", Fes.Http.toQueryValue v)
                    req.RestTotalHitsAsInt |> Option.map (fun v -> "rest_total_hits_as_int", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type ScrollResponse<'TDocument> = Types.ResponseBody<'TDocument>

    type ScrollRequestBuilder() =
        member _.Yield(_: unit) : ScrollRequest =
            {
                ScrollId = Unchecked.defaultof<_>
                Scroll = None
                queryScrollId = None
                RestTotalHitsAsInt = None
                bodyScroll = None
                bodyScrollId = Unchecked.defaultof<_>
            }

        [<CustomOperation("scrollId")>]
        member _.ScrollId(state: ScrollRequest, value: Types.ScrollId) =
            { state with ScrollId = value }

        [<CustomOperation("scroll")>]
        member _.Scroll(state: ScrollRequest, value: Types.Duration) =
            { state with Scroll = Some value }

        [<CustomOperation("queryScrollId")>]
        member _.QueryScrollId(state: ScrollRequest, value: Types.ScrollId) =
            { state with queryScrollId = Some value }

        [<CustomOperation("restTotalHitsAsInt")>]
        member _.RestTotalHitsAsInt(state: ScrollRequest, value: bool) =
            { state with RestTotalHitsAsInt = Some value }

        [<CustomOperation("bodyScroll")>]
        member _.BodyScroll(state: ScrollRequest, value: Types.Duration) =
            { state with bodyScroll = Some value }

        [<CustomOperation("bodyScrollId")>]
        member _.BodyScrollId(state: ScrollRequest, value: Types.ScrollId) =
            { state with bodyScrollId = value }

    let scrollRequest = ScrollRequestBuilder()

    module Scroll =
        let withScroll (value: Types.Duration) (req: ScrollRequest) =
            { req with Scroll = Some value }
        let withScrollId (value: Types.ScrollId) (req: ScrollRequest) =
            { req with queryScrollId = Some value }
        let withRestTotalHitsAsInt (value: bool) (req: ScrollRequest) =
            { req with RestTotalHitsAsInt = Some value }
        let withBodyScroll (value: Types.Duration) (req: ScrollRequest) =
            { req with bodyScroll = Some value }
        let withBodyScrollId (value: Types.ScrollId) (req: ScrollRequest) =
            { req with bodyScrollId = value }

    type SearchRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        AllowPartialSearchResults: bool option
        Analyzer: string option
        AnalyzeWildcard: bool option
        BatchedReduceSize: Types.Long option
        CcsMinimizeRoundtrips: bool option
        DefaultOperator: Types.Operator option
        Df: string option
        DocvalueFields: Types.Fields option
        ExpandWildcards: Types.ExpandWildcards option
        Explain: bool option
        IgnoreThrottled: bool option
        IgnoreUnavailable: bool option
        IncludeNamedQueriesScore: bool option
        Lenient: bool option
        MaxConcurrentShardRequests: Types.Integer option
        Preference: string option
        PreFilterShardSize: Types.Long option
        RequestCache: bool option
        Routing: Types.Routing option
        Scroll: Types.Duration option
        SearchType: Types.SearchType option
        Stats: string list option
        StoredFields: Types.Fields option
        SuggestField: Types.Field option
        SuggestMode: Types.SuggestMode option
        SuggestSize: Types.Long option
        SuggestText: string option
        TerminateAfter: Types.Long option
        Timeout: Types.Duration option
        TrackTotalHits: Types.TrackHits option
        TrackScores: bool option
        TypedKeys: bool option
        RestTotalHitsAsInt: bool option
        Version: bool option
        Source: Types.SourceConfigParam option
        SourceExcludes: Types.Fields option
        SourceExcludeVectors: bool option
        SourceIncludes: Types.Fields option
        SeqNoPrimaryTerm: bool option
        Q: string option
        Size: Types.Integer option
        From: Types.Integer option
        Sort: System.Text.Json.JsonElement option
        ForceSyntheticSource: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("aggregations")>]
        Aggregations: Map<string, Types.AggregationContainer> option
        [<System.Text.Json.Serialization.JsonPropertyName("collapse")>]
        Collapse: Types.FieldCollapse option
        [<System.Text.Json.Serialization.JsonPropertyName("explain")>]
        bodyExplain: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ext")>]
        Ext: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        bodyFrom: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("highlight")>]
        Highlight: Types.Highlight option
        [<System.Text.Json.Serialization.JsonPropertyName("track_total_hits")>]
        bodyTrackTotalHits: Types.TrackHits option
        [<System.Text.Json.Serialization.JsonPropertyName("indices_boost")>]
        IndicesBoost: Map<Types.IndexName, Types.Double> list option
        [<System.Text.Json.Serialization.JsonPropertyName("docvalue_fields")>]
        bodyDocvalueFields: Types.FieldAndFormat list option
        [<System.Text.Json.Serialization.JsonPropertyName("knn")>]
        Knn: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("rank")>]
        Rank: Types.RankContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_score")>]
        MinScore: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("post_filter")>]
        PostFilter: Types.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("profile")>]
        Profile: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: Types.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("rescore")>]
        Rescore: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("retriever")>]
        Retriever: Types.RetrieverContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("script_fields")>]
        ScriptFields: Map<string, Types.ScriptField> option
        [<System.Text.Json.Serialization.JsonPropertyName("search_after")>]
        SearchAfter: Types.SortResults option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        bodySize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("slice")>]
        Slice: Types.SlicedScroll option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        bodySort: Types.Sort option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        bodySource: Types.SourceConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Types.FieldAndFormat list option
        [<System.Text.Json.Serialization.JsonPropertyName("suggest")>]
        Suggest: Types.Suggester option
        [<System.Text.Json.Serialization.JsonPropertyName("terminate_after")>]
        bodyTerminateAfter: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("timeout")>]
        bodyTimeout: string option
        [<System.Text.Json.Serialization.JsonPropertyName("track_scores")>]
        bodyTrackScores: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        bodyVersion: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("seq_no_primary_term")>]
        bodySeqNoPrimaryTerm: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("stored_fields")>]
        bodyStoredFields: Types.Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("pit")>]
        Pit: Types.PointInTimeReference option
        [<System.Text.Json.Serialization.JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: Types.RuntimeFields option
        [<System.Text.Json.Serialization.JsonPropertyName("stats")>]
        bodyStats: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("project_routing")>]
        ProjectRouting: Types.ProjectRouting option
    }

        with
        static member ToEndpoint(req: SearchRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_search"
            let queryParams =
                [
                    req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                    req.AllowPartialSearchResults |> Option.map (fun v -> "allow_partial_search_results", Fes.Http.toQueryValue v)
                    req.Analyzer |> Option.map (fun v -> "analyzer", Fes.Http.toQueryValue v)
                    req.AnalyzeWildcard |> Option.map (fun v -> "analyze_wildcard", Fes.Http.toQueryValue v)
                    req.BatchedReduceSize |> Option.map (fun v -> "batched_reduce_size", Fes.Http.toQueryValue v)
                    req.CcsMinimizeRoundtrips |> Option.map (fun v -> "ccs_minimize_roundtrips", Fes.Http.toQueryValue v)
                    req.DefaultOperator |> Option.map (fun v -> "default_operator", Fes.Http.toQueryValue v)
                    req.Df |> Option.map (fun v -> "df", Fes.Http.toQueryValue v)
                    req.DocvalueFields |> Option.map (fun v -> "docvalue_fields", Fes.Http.toQueryValue v)
                    req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                    req.Explain |> Option.map (fun v -> "explain", Fes.Http.toQueryValue v)
                    req.IgnoreThrottled |> Option.map (fun v -> "ignore_throttled", Fes.Http.toQueryValue v)
                    req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                    req.IncludeNamedQueriesScore |> Option.map (fun v -> "include_named_queries_score", Fes.Http.toQueryValue v)
                    req.Lenient |> Option.map (fun v -> "lenient", Fes.Http.toQueryValue v)
                    req.MaxConcurrentShardRequests |> Option.map (fun v -> "max_concurrent_shard_requests", Fes.Http.toQueryValue v)
                    req.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                    req.PreFilterShardSize |> Option.map (fun v -> "pre_filter_shard_size", Fes.Http.toQueryValue v)
                    req.RequestCache |> Option.map (fun v -> "request_cache", Fes.Http.toQueryValue v)
                    req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                    req.Scroll |> Option.map (fun v -> "scroll", Fes.Http.toQueryValue v)
                    req.SearchType |> Option.map (fun v -> "search_type", Fes.Http.toQueryValue v)
                    req.Stats |> Option.map (fun v -> "stats", Fes.Http.toQueryValue v)
                    req.StoredFields |> Option.map (fun v -> "stored_fields", Fes.Http.toQueryValue v)
                    req.SuggestField |> Option.map (fun v -> "suggest_field", Fes.Http.toQueryValue v)
                    req.SuggestMode |> Option.map (fun v -> "suggest_mode", Fes.Http.toQueryValue v)
                    req.SuggestSize |> Option.map (fun v -> "suggest_size", Fes.Http.toQueryValue v)
                    req.SuggestText |> Option.map (fun v -> "suggest_text", Fes.Http.toQueryValue v)
                    req.TerminateAfter |> Option.map (fun v -> "terminate_after", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    req.TrackTotalHits |> Option.map (fun v -> "track_total_hits", Fes.Http.toQueryValue v)
                    req.TrackScores |> Option.map (fun v -> "track_scores", Fes.Http.toQueryValue v)
                    req.TypedKeys |> Option.map (fun v -> "typed_keys", Fes.Http.toQueryValue v)
                    req.RestTotalHitsAsInt |> Option.map (fun v -> "rest_total_hits_as_int", Fes.Http.toQueryValue v)
                    req.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                    req.Source |> Option.map (fun v -> "_source", Fes.Http.toQueryValue v)
                    req.SourceExcludes |> Option.map (fun v -> "_source_excludes", Fes.Http.toQueryValue v)
                    req.SourceExcludeVectors |> Option.map (fun v -> "_source_exclude_vectors", Fes.Http.toQueryValue v)
                    req.SourceIncludes |> Option.map (fun v -> "_source_includes", Fes.Http.toQueryValue v)
                    req.SeqNoPrimaryTerm |> Option.map (fun v -> "seq_no_primary_term", Fes.Http.toQueryValue v)
                    req.Q |> Option.map (fun v -> "q", Fes.Http.toQueryValue v)
                    req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                    req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                    req.Sort |> Option.map (fun v -> "sort", Fes.Http.toQueryValue v)
                    req.ForceSyntheticSource |> Option.map (fun v -> "force_synthetic_source", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type SearchResponse<'TDocument> = Types.ResponseBody<'TDocument>

    type SearchRequestBuilder() =
        member _.Yield(_: unit) : SearchRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                AllowPartialSearchResults = None
                Analyzer = None
                AnalyzeWildcard = None
                BatchedReduceSize = None
                CcsMinimizeRoundtrips = None
                DefaultOperator = None
                Df = None
                DocvalueFields = None
                ExpandWildcards = None
                Explain = None
                IgnoreThrottled = None
                IgnoreUnavailable = None
                IncludeNamedQueriesScore = None
                Lenient = None
                MaxConcurrentShardRequests = None
                Preference = None
                PreFilterShardSize = None
                RequestCache = None
                Routing = None
                Scroll = None
                SearchType = None
                Stats = None
                StoredFields = None
                SuggestField = None
                SuggestMode = None
                SuggestSize = None
                SuggestText = None
                TerminateAfter = None
                Timeout = None
                TrackTotalHits = None
                TrackScores = None
                TypedKeys = None
                RestTotalHitsAsInt = None
                Version = None
                Source = None
                SourceExcludes = None
                SourceExcludeVectors = None
                SourceIncludes = None
                SeqNoPrimaryTerm = None
                Q = None
                Size = None
                From = None
                Sort = None
                ForceSyntheticSource = None
                Aggregations = None
                Collapse = None
                bodyExplain = None
                Ext = None
                bodyFrom = None
                Highlight = None
                bodyTrackTotalHits = None
                IndicesBoost = None
                bodyDocvalueFields = None
                Knn = None
                Rank = None
                MinScore = None
                PostFilter = None
                Profile = None
                Query = None
                Rescore = None
                Retriever = None
                ScriptFields = None
                SearchAfter = None
                bodySize = None
                Slice = None
                bodySort = None
                bodySource = None
                Fields = None
                Suggest = None
                bodyTerminateAfter = None
                bodyTimeout = None
                bodyTrackScores = None
                bodyVersion = None
                bodySeqNoPrimaryTerm = None
                bodyStoredFields = None
                Pit = None
                RuntimeMappings = None
                bodyStats = None
                ProjectRouting = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: SearchRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: SearchRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("allowPartialSearchResults")>]
        member _.AllowPartialSearchResults(state: SearchRequest, value: bool) =
            { state with AllowPartialSearchResults = Some value }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: SearchRequest, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("analyzeWildcard")>]
        member _.AnalyzeWildcard(state: SearchRequest, value: bool) =
            { state with AnalyzeWildcard = Some value }

        [<CustomOperation("batchedReduceSize")>]
        member _.BatchedReduceSize(state: SearchRequest, value: Types.Long) =
            { state with BatchedReduceSize = Some value }

        [<CustomOperation("ccsMinimizeRoundtrips")>]
        member _.CcsMinimizeRoundtrips(state: SearchRequest, value: bool) =
            { state with CcsMinimizeRoundtrips = Some value }

        [<CustomOperation("defaultOperator")>]
        member _.DefaultOperator(state: SearchRequest, value: Types.Operator) =
            { state with DefaultOperator = Some value }

        [<CustomOperation("df")>]
        member _.Df(state: SearchRequest, value: string) =
            { state with Df = Some value }

        [<CustomOperation("docvalueFields")>]
        member _.DocvalueFields(state: SearchRequest, value: Types.Fields) =
            { state with DocvalueFields = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: SearchRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("explain")>]
        member _.Explain(state: SearchRequest, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("ignoreThrottled")>]
        member _.IgnoreThrottled(state: SearchRequest, value: bool) =
            { state with IgnoreThrottled = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: SearchRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("includeNamedQueriesScore")>]
        member _.IncludeNamedQueriesScore(state: SearchRequest, value: bool) =
            { state with IncludeNamedQueriesScore = Some value }

        [<CustomOperation("lenient")>]
        member _.Lenient(state: SearchRequest, value: bool) =
            { state with Lenient = Some value }

        [<CustomOperation("maxConcurrentShardRequests")>]
        member _.MaxConcurrentShardRequests(state: SearchRequest, value: Types.Integer) =
            { state with MaxConcurrentShardRequests = Some value }

        [<CustomOperation("preference")>]
        member _.Preference(state: SearchRequest, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("preFilterShardSize")>]
        member _.PreFilterShardSize(state: SearchRequest, value: Types.Long) =
            { state with PreFilterShardSize = Some value }

        [<CustomOperation("requestCache")>]
        member _.RequestCache(state: SearchRequest, value: bool) =
            { state with RequestCache = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: SearchRequest, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("scroll")>]
        member _.Scroll(state: SearchRequest, value: Types.Duration) =
            { state with Scroll = Some value }

        [<CustomOperation("searchType")>]
        member _.SearchType(state: SearchRequest, value: Types.SearchType) =
            { state with SearchType = Some value }

        [<CustomOperation("stats")>]
        member _.Stats(state: SearchRequest, value: string list) =
            { state with Stats = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: SearchRequest, value: Types.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("suggestField")>]
        member _.SuggestField(state: SearchRequest, value: Types.Field) =
            { state with SuggestField = Some value }

        [<CustomOperation("suggestMode")>]
        member _.SuggestMode(state: SearchRequest, value: Types.SuggestMode) =
            { state with SuggestMode = Some value }

        [<CustomOperation("suggestSize")>]
        member _.SuggestSize(state: SearchRequest, value: Types.Long) =
            { state with SuggestSize = Some value }

        [<CustomOperation("suggestText")>]
        member _.SuggestText(state: SearchRequest, value: string) =
            { state with SuggestText = Some value }

        [<CustomOperation("terminateAfter")>]
        member _.TerminateAfter(state: SearchRequest, value: Types.Long) =
            { state with TerminateAfter = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SearchRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("trackTotalHits")>]
        member _.TrackTotalHits(state: SearchRequest, value: Types.TrackHits) =
            { state with TrackTotalHits = Some value }

        [<CustomOperation("trackScores")>]
        member _.TrackScores(state: SearchRequest, value: bool) =
            { state with TrackScores = Some value }

        [<CustomOperation("typedKeys")>]
        member _.TypedKeys(state: SearchRequest, value: bool) =
            { state with TypedKeys = Some value }

        [<CustomOperation("restTotalHitsAsInt")>]
        member _.RestTotalHitsAsInt(state: SearchRequest, value: bool) =
            { state with RestTotalHitsAsInt = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: SearchRequest, value: bool) =
            { state with Version = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: SearchRequest, value: Types.SourceConfigParam) =
            { state with Source = Some value }

        [<CustomOperation("sourceExcludes")>]
        member _.SourceExcludes(state: SearchRequest, value: Types.Fields) =
            { state with SourceExcludes = Some value }

        [<CustomOperation("sourceExcludeVectors")>]
        member _.SourceExcludeVectors(state: SearchRequest, value: bool) =
            { state with SourceExcludeVectors = Some value }

        [<CustomOperation("sourceIncludes")>]
        member _.SourceIncludes(state: SearchRequest, value: Types.Fields) =
            { state with SourceIncludes = Some value }

        [<CustomOperation("seqNoPrimaryTerm")>]
        member _.SeqNoPrimaryTerm(state: SearchRequest, value: bool) =
            { state with SeqNoPrimaryTerm = Some value }

        [<CustomOperation("q")>]
        member _.Q(state: SearchRequest, value: string) =
            { state with Q = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: SearchRequest, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("from")>]
        member _.From(state: SearchRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: SearchRequest, value: System.Text.Json.JsonElement) =
            { state with Sort = Some value }

        [<CustomOperation("forceSyntheticSource")>]
        member _.ForceSyntheticSource(state: SearchRequest, value: bool) =
            { state with ForceSyntheticSource = Some value }

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: SearchRequest, value: Map<string, Types.AggregationContainer>) =
            { state with Aggregations = Some value }

        [<CustomOperation("collapse")>]
        member _.Collapse(state: SearchRequest, value: Types.FieldCollapse) =
            { state with Collapse = Some value }

        [<CustomOperation("bodyExplain")>]
        member _.BodyExplain(state: SearchRequest, value: bool) =
            { state with bodyExplain = Some value }

        [<CustomOperation("ext")>]
        member _.Ext(state: SearchRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Ext = Some value }

        [<CustomOperation("bodyFrom")>]
        member _.BodyFrom(state: SearchRequest, value: Types.Integer) =
            { state with bodyFrom = Some value }

        [<CustomOperation("highlight")>]
        member _.Highlight(state: SearchRequest, value: Types.Highlight) =
            { state with Highlight = Some value }

        [<CustomOperation("bodyTrackTotalHits")>]
        member _.BodyTrackTotalHits(state: SearchRequest, value: Types.TrackHits) =
            { state with bodyTrackTotalHits = Some value }

        [<CustomOperation("indicesBoost")>]
        member _.IndicesBoost(state: SearchRequest, value: Map<Types.IndexName, Types.Double> list) =
            { state with IndicesBoost = Some value }

        [<CustomOperation("bodyDocvalueFields")>]
        member _.BodyDocvalueFields(state: SearchRequest, value: Types.FieldAndFormat list) =
            { state with bodyDocvalueFields = Some value }

        [<CustomOperation("knn")>]
        member _.Knn(state: SearchRequest, value: System.Text.Json.JsonElement) =
            { state with Knn = Some value }

        [<CustomOperation("rank")>]
        member _.Rank(state: SearchRequest, value: Types.RankContainer) =
            { state with Rank = Some value }

        [<CustomOperation("minScore")>]
        member _.MinScore(state: SearchRequest, value: Types.Double) =
            { state with MinScore = Some value }

        [<CustomOperation("postFilter")>]
        member _.PostFilter(state: SearchRequest, value: Types.QueryContainer) =
            { state with PostFilter = Some value }

        [<CustomOperation("profile")>]
        member _.Profile(state: SearchRequest, value: bool) =
            { state with Profile = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: SearchRequest, value: Types.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("rescore")>]
        member _.Rescore(state: SearchRequest, value: System.Text.Json.JsonElement) =
            { state with Rescore = Some value }

        [<CustomOperation("retriever")>]
        member _.Retriever(state: SearchRequest, value: Types.RetrieverContainer) =
            { state with Retriever = Some value }

        [<CustomOperation("scriptFields")>]
        member _.ScriptFields(state: SearchRequest, value: Map<string, Types.ScriptField>) =
            { state with ScriptFields = Some value }

        [<CustomOperation("searchAfter")>]
        member _.SearchAfter(state: SearchRequest, value: Types.SortResults) =
            { state with SearchAfter = Some value }

        [<CustomOperation("bodySize")>]
        member _.BodySize(state: SearchRequest, value: Types.Integer) =
            { state with bodySize = Some value }

        [<CustomOperation("slice")>]
        member _.Slice(state: SearchRequest, value: Types.SlicedScroll) =
            { state with Slice = Some value }

        [<CustomOperation("bodySort")>]
        member _.BodySort(state: SearchRequest, value: Types.Sort) =
            { state with bodySort = Some value }

        [<CustomOperation("bodySource")>]
        member _.BodySource(state: SearchRequest, value: Types.SourceConfig) =
            { state with bodySource = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: SearchRequest, value: Types.FieldAndFormat list) =
            { state with Fields = Some value }

        [<CustomOperation("suggest")>]
        member _.Suggest(state: SearchRequest, value: Types.Suggester) =
            { state with Suggest = Some value }

        [<CustomOperation("bodyTerminateAfter")>]
        member _.BodyTerminateAfter(state: SearchRequest, value: Types.Long) =
            { state with bodyTerminateAfter = Some value }

        [<CustomOperation("bodyTimeout")>]
        member _.BodyTimeout(state: SearchRequest, value: string) =
            { state with bodyTimeout = Some value }

        [<CustomOperation("bodyTrackScores")>]
        member _.BodyTrackScores(state: SearchRequest, value: bool) =
            { state with bodyTrackScores = Some value }

        [<CustomOperation("bodyVersion")>]
        member _.BodyVersion(state: SearchRequest, value: bool) =
            { state with bodyVersion = Some value }

        [<CustomOperation("bodySeqNoPrimaryTerm")>]
        member _.BodySeqNoPrimaryTerm(state: SearchRequest, value: bool) =
            { state with bodySeqNoPrimaryTerm = Some value }

        [<CustomOperation("bodyStoredFields")>]
        member _.BodyStoredFields(state: SearchRequest, value: Types.Fields) =
            { state with bodyStoredFields = Some value }

        [<CustomOperation("pit")>]
        member _.Pit(state: SearchRequest, value: Types.PointInTimeReference) =
            { state with Pit = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: SearchRequest, value: Types.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("bodyStats")>]
        member _.BodyStats(state: SearchRequest, value: string list) =
            { state with bodyStats = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: SearchRequest, value: Types.ProjectRouting) =
            { state with ProjectRouting = Some value }

    let searchRequest = SearchRequestBuilder()

    module Search =
        let withAllowNoIndices (value: bool) (req: SearchRequest) =
            { req with AllowNoIndices = Some value }
        let withAllowPartialSearchResults (value: bool) (req: SearchRequest) =
            { req with AllowPartialSearchResults = Some value }
        let withAnalyzer (value: string) (req: SearchRequest) =
            { req with Analyzer = Some value }
        let withAnalyzeWildcard (value: bool) (req: SearchRequest) =
            { req with AnalyzeWildcard = Some value }
        let withBatchedReduceSize (value: Types.Long) (req: SearchRequest) =
            { req with BatchedReduceSize = Some value }
        let withCcsMinimizeRoundtrips (value: bool) (req: SearchRequest) =
            { req with CcsMinimizeRoundtrips = Some value }
        let withDefaultOperator (value: Types.Operator) (req: SearchRequest) =
            { req with DefaultOperator = Some value }
        let withDf (value: string) (req: SearchRequest) =
            { req with Df = Some value }
        let withDocvalueFields (value: Types.Fields) (req: SearchRequest) =
            { req with DocvalueFields = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: SearchRequest) =
            { req with ExpandWildcards = Some value }
        let withExplain (value: bool) (req: SearchRequest) =
            { req with Explain = Some value }
        let withIgnoreThrottled (value: bool) (req: SearchRequest) =
            { req with IgnoreThrottled = Some value }
        let withIgnoreUnavailable (value: bool) (req: SearchRequest) =
            { req with IgnoreUnavailable = Some value }
        let withIncludeNamedQueriesScore (value: bool) (req: SearchRequest) =
            { req with IncludeNamedQueriesScore = Some value }
        let withLenient (value: bool) (req: SearchRequest) =
            { req with Lenient = Some value }
        let withMaxConcurrentShardRequests (value: Types.Integer) (req: SearchRequest) =
            { req with MaxConcurrentShardRequests = Some value }
        let withPreference (value: string) (req: SearchRequest) =
            { req with Preference = Some value }
        let withPreFilterShardSize (value: Types.Long) (req: SearchRequest) =
            { req with PreFilterShardSize = Some value }
        let withRequestCache (value: bool) (req: SearchRequest) =
            { req with RequestCache = Some value }
        let withRouting (value: Types.Routing) (req: SearchRequest) =
            { req with Routing = Some value }
        let withScroll (value: Types.Duration) (req: SearchRequest) =
            { req with Scroll = Some value }
        let withSearchType (value: Types.SearchType) (req: SearchRequest) =
            { req with SearchType = Some value }
        let withStats (value: string list) (req: SearchRequest) =
            { req with Stats = Some value }
        let withStoredFields (value: Types.Fields) (req: SearchRequest) =
            { req with StoredFields = Some value }
        let withSuggestField (value: Types.Field) (req: SearchRequest) =
            { req with SuggestField = Some value }
        let withSuggestMode (value: Types.SuggestMode) (req: SearchRequest) =
            { req with SuggestMode = Some value }
        let withSuggestSize (value: Types.Long) (req: SearchRequest) =
            { req with SuggestSize = Some value }
        let withSuggestText (value: string) (req: SearchRequest) =
            { req with SuggestText = Some value }
        let withTerminateAfter (value: Types.Long) (req: SearchRequest) =
            { req with TerminateAfter = Some value }
        let withTimeout (value: Types.Duration) (req: SearchRequest) =
            { req with Timeout = Some value }
        let withTrackTotalHits (value: Types.TrackHits) (req: SearchRequest) =
            { req with TrackTotalHits = Some value }
        let withTrackScores (value: bool) (req: SearchRequest) =
            { req with TrackScores = Some value }
        let withTypedKeys (value: bool) (req: SearchRequest) =
            { req with TypedKeys = Some value }
        let withRestTotalHitsAsInt (value: bool) (req: SearchRequest) =
            { req with RestTotalHitsAsInt = Some value }
        let withVersion (value: bool) (req: SearchRequest) =
            { req with Version = Some value }
        let withSource (value: Types.SourceConfigParam) (req: SearchRequest) =
            { req with Source = Some value }
        let withSourceExcludes (value: Types.Fields) (req: SearchRequest) =
            { req with SourceExcludes = Some value }
        let withSourceExcludeVectors (value: bool) (req: SearchRequest) =
            { req with SourceExcludeVectors = Some value }
        let withSourceIncludes (value: Types.Fields) (req: SearchRequest) =
            { req with SourceIncludes = Some value }
        let withSeqNoPrimaryTerm (value: bool) (req: SearchRequest) =
            { req with SeqNoPrimaryTerm = Some value }
        let withQ (value: string) (req: SearchRequest) =
            { req with Q = Some value }
        let withSize (value: Types.Integer) (req: SearchRequest) =
            { req with Size = Some value }
        let withFrom (value: Types.Integer) (req: SearchRequest) =
            { req with From = Some value }
        let withSort (value: System.Text.Json.JsonElement) (req: SearchRequest) =
            { req with Sort = Some value }
        let withForceSyntheticSource (value: bool) (req: SearchRequest) =
            { req with ForceSyntheticSource = Some value }
        let withAggregations (value: Map<string, Types.AggregationContainer>) (req: SearchRequest) =
            { req with Aggregations = Some value }
        let withCollapse (value: Types.FieldCollapse) (req: SearchRequest) =
            { req with Collapse = Some value }
        let withBodyExplain (value: bool) (req: SearchRequest) =
            { req with bodyExplain = Some value }
        let withExt (value: Map<string, System.Text.Json.JsonElement>) (req: SearchRequest) =
            { req with Ext = Some value }
        let withBodyFrom (value: Types.Integer) (req: SearchRequest) =
            { req with bodyFrom = Some value }
        let withHighlight (value: Types.Highlight) (req: SearchRequest) =
            { req with Highlight = Some value }
        let withBodyTrackTotalHits (value: Types.TrackHits) (req: SearchRequest) =
            { req with bodyTrackTotalHits = Some value }
        let withIndicesBoost (value: Map<Types.IndexName, Types.Double> list) (req: SearchRequest) =
            { req with IndicesBoost = Some value }
        let withBodyDocvalueFields (value: Types.FieldAndFormat list) (req: SearchRequest) =
            { req with bodyDocvalueFields = Some value }
        let withKnn (value: System.Text.Json.JsonElement) (req: SearchRequest) =
            { req with Knn = Some value }
        let withRank (value: Types.RankContainer) (req: SearchRequest) =
            { req with Rank = Some value }
        let withMinScore (value: Types.Double) (req: SearchRequest) =
            { req with MinScore = Some value }
        let withPostFilter (value: Types.QueryContainer) (req: SearchRequest) =
            { req with PostFilter = Some value }
        let withProfile (value: bool) (req: SearchRequest) =
            { req with Profile = Some value }
        let withQuery (value: Types.QueryContainer) (req: SearchRequest) =
            { req with Query = Some value }
        let withRescore (value: System.Text.Json.JsonElement) (req: SearchRequest) =
            { req with Rescore = Some value }
        let withRetriever (value: Types.RetrieverContainer) (req: SearchRequest) =
            { req with Retriever = Some value }
        let withScriptFields (value: Map<string, Types.ScriptField>) (req: SearchRequest) =
            { req with ScriptFields = Some value }
        let withSearchAfter (value: Types.SortResults) (req: SearchRequest) =
            { req with SearchAfter = Some value }
        let withBodySize (value: Types.Integer) (req: SearchRequest) =
            { req with bodySize = Some value }
        let withSlice (value: Types.SlicedScroll) (req: SearchRequest) =
            { req with Slice = Some value }
        let withBodySort (value: Types.Sort) (req: SearchRequest) =
            { req with bodySort = Some value }
        let withBodySource (value: Types.SourceConfig) (req: SearchRequest) =
            { req with bodySource = Some value }
        let withFields (value: Types.FieldAndFormat list) (req: SearchRequest) =
            { req with Fields = Some value }
        let withSuggest (value: Types.Suggester) (req: SearchRequest) =
            { req with Suggest = Some value }
        let withBodyTerminateAfter (value: Types.Long) (req: SearchRequest) =
            { req with bodyTerminateAfter = Some value }
        let withBodyTimeout (value: string) (req: SearchRequest) =
            { req with bodyTimeout = Some value }
        let withBodyTrackScores (value: bool) (req: SearchRequest) =
            { req with bodyTrackScores = Some value }
        let withBodyVersion (value: bool) (req: SearchRequest) =
            { req with bodyVersion = Some value }
        let withBodySeqNoPrimaryTerm (value: bool) (req: SearchRequest) =
            { req with bodySeqNoPrimaryTerm = Some value }
        let withBodyStoredFields (value: Types.Fields) (req: SearchRequest) =
            { req with bodyStoredFields = Some value }
        let withPit (value: Types.PointInTimeReference) (req: SearchRequest) =
            { req with Pit = Some value }
        let withRuntimeMappings (value: Types.RuntimeFields) (req: SearchRequest) =
            { req with RuntimeMappings = Some value }
        let withBodyStats (value: string list) (req: SearchRequest) =
            { req with bodyStats = Some value }
        let withProjectRouting (value: Types.ProjectRouting) (req: SearchRequest) =
            { req with ProjectRouting = Some value }

    type SearchMvtRequest = {
        Index: Types.Indices
        Field: Types.Field
        Zoom: Types.ZoomLevel
        X: Types.Coordinate
        Y: Types.Coordinate
        ExactBounds: bool option
        Extent: Types.Integer option
        GridAgg: Types.GridAggregationType option
        GridPrecision: Types.Integer option
        GridType: Types.GridType option
        Size: Types.Integer option
        TrackTotalHits: Types.TrackHits option
        WithLabels: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("aggs")>]
        Aggs: Map<string, Types.AggregationContainer> option
        [<System.Text.Json.Serialization.JsonPropertyName("buffer")>]
        Buffer: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("exact_bounds")>]
        bodyExactBounds: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("extent")>]
        bodyExtent: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Types.Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("grid_agg")>]
        bodyGridAgg: Types.GridAggregationType option
        [<System.Text.Json.Serialization.JsonPropertyName("grid_precision")>]
        bodyGridPrecision: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("grid_type")>]
        bodyGridType: Types.GridType option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: Types.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: Types.RuntimeFields option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        bodySize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: Types.Sort option
        [<System.Text.Json.Serialization.JsonPropertyName("track_total_hits")>]
        bodyTrackTotalHits: Types.TrackHits option
        [<System.Text.Json.Serialization.JsonPropertyName("with_labels")>]
        bodyWithLabels: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("project_routing")>]
        ProjectRouting: Types.ProjectRouting option
    }

        with
        static member ToEndpoint(req: SearchMvtRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_mvt/{Fes.Http.toPathSegment req.Field}/{Fes.Http.toPathSegment req.Zoom}/{Fes.Http.toPathSegment req.X}/{Fes.Http.toPathSegment req.Y}"
            let queryParams =
                [
                    req.ExactBounds |> Option.map (fun v -> "exact_bounds", Fes.Http.toQueryValue v)
                    req.Extent |> Option.map (fun v -> "extent", Fes.Http.toQueryValue v)
                    req.GridAgg |> Option.map (fun v -> "grid_agg", Fes.Http.toQueryValue v)
                    req.GridPrecision |> Option.map (fun v -> "grid_precision", Fes.Http.toQueryValue v)
                    req.GridType |> Option.map (fun v -> "grid_type", Fes.Http.toQueryValue v)
                    req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                    req.TrackTotalHits |> Option.map (fun v -> "track_total_hits", Fes.Http.toQueryValue v)
                    req.WithLabels |> Option.map (fun v -> "with_labels", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type SearchMvtResponse = Types.MapboxVectorTiles

    type SearchMvtRequestBuilder() =
        member _.Yield(_: unit) : SearchMvtRequest =
            {
                Index = Unchecked.defaultof<_>
                Field = Unchecked.defaultof<_>
                Zoom = Unchecked.defaultof<_>
                X = Unchecked.defaultof<_>
                Y = Unchecked.defaultof<_>
                ExactBounds = None
                Extent = None
                GridAgg = None
                GridPrecision = None
                GridType = None
                Size = None
                TrackTotalHits = None
                WithLabels = None
                Aggs = None
                Buffer = None
                bodyExactBounds = None
                bodyExtent = None
                Fields = None
                bodyGridAgg = None
                bodyGridPrecision = None
                bodyGridType = None
                Query = None
                RuntimeMappings = None
                bodySize = None
                Sort = None
                bodyTrackTotalHits = None
                bodyWithLabels = None
                ProjectRouting = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: SearchMvtRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("field")>]
        member _.Field(state: SearchMvtRequest, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("zoom")>]
        member _.Zoom(state: SearchMvtRequest, value: Types.ZoomLevel) =
            { state with Zoom = value }

        [<CustomOperation("x")>]
        member _.X(state: SearchMvtRequest, value: Types.Coordinate) =
            { state with X = value }

        [<CustomOperation("y")>]
        member _.Y(state: SearchMvtRequest, value: Types.Coordinate) =
            { state with Y = value }

        [<CustomOperation("exactBounds")>]
        member _.ExactBounds(state: SearchMvtRequest, value: bool) =
            { state with ExactBounds = Some value }

        [<CustomOperation("extent")>]
        member _.Extent(state: SearchMvtRequest, value: Types.Integer) =
            { state with Extent = Some value }

        [<CustomOperation("gridAgg")>]
        member _.GridAgg(state: SearchMvtRequest, value: Types.GridAggregationType) =
            { state with GridAgg = Some value }

        [<CustomOperation("gridPrecision")>]
        member _.GridPrecision(state: SearchMvtRequest, value: Types.Integer) =
            { state with GridPrecision = Some value }

        [<CustomOperation("gridType")>]
        member _.GridType(state: SearchMvtRequest, value: Types.GridType) =
            { state with GridType = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: SearchMvtRequest, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("trackTotalHits")>]
        member _.TrackTotalHits(state: SearchMvtRequest, value: Types.TrackHits) =
            { state with TrackTotalHits = Some value }

        [<CustomOperation("withLabels")>]
        member _.WithLabels(state: SearchMvtRequest, value: bool) =
            { state with WithLabels = Some value }

        [<CustomOperation("aggs")>]
        member _.Aggs(state: SearchMvtRequest, value: Map<string, Types.AggregationContainer>) =
            { state with Aggs = Some value }

        [<CustomOperation("buffer")>]
        member _.Buffer(state: SearchMvtRequest, value: Types.Integer) =
            { state with Buffer = Some value }

        [<CustomOperation("bodyExactBounds")>]
        member _.BodyExactBounds(state: SearchMvtRequest, value: bool) =
            { state with bodyExactBounds = Some value }

        [<CustomOperation("bodyExtent")>]
        member _.BodyExtent(state: SearchMvtRequest, value: Types.Integer) =
            { state with bodyExtent = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: SearchMvtRequest, value: Types.Fields) =
            { state with Fields = Some value }

        [<CustomOperation("bodyGridAgg")>]
        member _.BodyGridAgg(state: SearchMvtRequest, value: Types.GridAggregationType) =
            { state with bodyGridAgg = Some value }

        [<CustomOperation("bodyGridPrecision")>]
        member _.BodyGridPrecision(state: SearchMvtRequest, value: Types.Integer) =
            { state with bodyGridPrecision = Some value }

        [<CustomOperation("bodyGridType")>]
        member _.BodyGridType(state: SearchMvtRequest, value: Types.GridType) =
            { state with bodyGridType = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: SearchMvtRequest, value: Types.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: SearchMvtRequest, value: Types.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("bodySize")>]
        member _.BodySize(state: SearchMvtRequest, value: Types.Integer) =
            { state with bodySize = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: SearchMvtRequest, value: Types.Sort) =
            { state with Sort = Some value }

        [<CustomOperation("bodyTrackTotalHits")>]
        member _.BodyTrackTotalHits(state: SearchMvtRequest, value: Types.TrackHits) =
            { state with bodyTrackTotalHits = Some value }

        [<CustomOperation("bodyWithLabels")>]
        member _.BodyWithLabels(state: SearchMvtRequest, value: bool) =
            { state with bodyWithLabels = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: SearchMvtRequest, value: Types.ProjectRouting) =
            { state with ProjectRouting = Some value }

    let searchMvtRequest = SearchMvtRequestBuilder()

    module SearchMvt =
        let withExactBounds (value: bool) (req: SearchMvtRequest) =
            { req with ExactBounds = Some value }
        let withExtent (value: Types.Integer) (req: SearchMvtRequest) =
            { req with Extent = Some value }
        let withGridAgg (value: Types.GridAggregationType) (req: SearchMvtRequest) =
            { req with GridAgg = Some value }
        let withGridPrecision (value: Types.Integer) (req: SearchMvtRequest) =
            { req with GridPrecision = Some value }
        let withGridType (value: Types.GridType) (req: SearchMvtRequest) =
            { req with GridType = Some value }
        let withSize (value: Types.Integer) (req: SearchMvtRequest) =
            { req with Size = Some value }
        let withTrackTotalHits (value: Types.TrackHits) (req: SearchMvtRequest) =
            { req with TrackTotalHits = Some value }
        let withWithLabels (value: bool) (req: SearchMvtRequest) =
            { req with WithLabels = Some value }
        let withAggs (value: Map<string, Types.AggregationContainer>) (req: SearchMvtRequest) =
            { req with Aggs = Some value }
        let withBuffer (value: Types.Integer) (req: SearchMvtRequest) =
            { req with Buffer = Some value }
        let withBodyExactBounds (value: bool) (req: SearchMvtRequest) =
            { req with bodyExactBounds = Some value }
        let withBodyExtent (value: Types.Integer) (req: SearchMvtRequest) =
            { req with bodyExtent = Some value }
        let withFields (value: Types.Fields) (req: SearchMvtRequest) =
            { req with Fields = Some value }
        let withBodyGridAgg (value: Types.GridAggregationType) (req: SearchMvtRequest) =
            { req with bodyGridAgg = Some value }
        let withBodyGridPrecision (value: Types.Integer) (req: SearchMvtRequest) =
            { req with bodyGridPrecision = Some value }
        let withBodyGridType (value: Types.GridType) (req: SearchMvtRequest) =
            { req with bodyGridType = Some value }
        let withQuery (value: Types.QueryContainer) (req: SearchMvtRequest) =
            { req with Query = Some value }
        let withRuntimeMappings (value: Types.RuntimeFields) (req: SearchMvtRequest) =
            { req with RuntimeMappings = Some value }
        let withBodySize (value: Types.Integer) (req: SearchMvtRequest) =
            { req with bodySize = Some value }
        let withSort (value: Types.Sort) (req: SearchMvtRequest) =
            { req with Sort = Some value }
        let withBodyTrackTotalHits (value: Types.TrackHits) (req: SearchMvtRequest) =
            { req with bodyTrackTotalHits = Some value }
        let withBodyWithLabels (value: bool) (req: SearchMvtRequest) =
            { req with bodyWithLabels = Some value }
        let withProjectRouting (value: Types.ProjectRouting) (req: SearchMvtRequest) =
            { req with ProjectRouting = Some value }

    type SearchShardsRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreUnavailable: bool option
        Local: bool option
        MasterTimeout: Types.Duration option
        Preference: string option
        Routing: Types.Routing option
    }

        with
        static member ToEndpoint(req: SearchShardsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_search_shards"
            let queryParams =
                [
                    req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                    req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                    req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                    req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    req.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                    req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            endpoint, ValueNone

    type SearchShardsResponse = System.Text.Json.JsonElement

    type SearchShardsRequestBuilder() =
        member _.Yield(_: unit) : SearchShardsRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreUnavailable = None
                Local = None
                MasterTimeout = None
                Preference = None
                Routing = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: SearchShardsRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: SearchShardsRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: SearchShardsRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: SearchShardsRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("local")>]
        member _.Local(state: SearchShardsRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SearchShardsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("preference")>]
        member _.Preference(state: SearchShardsRequest, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: SearchShardsRequest, value: Types.Routing) =
            { state with Routing = Some value }

    let searchShardsRequest = SearchShardsRequestBuilder()

    module SearchShards =
        let withAllowNoIndices (value: bool) (req: SearchShardsRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: SearchShardsRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreUnavailable (value: bool) (req: SearchShardsRequest) =
            { req with IgnoreUnavailable = Some value }
        let withLocal (value: bool) (req: SearchShardsRequest) =
            { req with Local = Some value }
        let withMasterTimeout (value: Types.Duration) (req: SearchShardsRequest) =
            { req with MasterTimeout = Some value }
        let withPreference (value: string) (req: SearchShardsRequest) =
            { req with Preference = Some value }
        let withRouting (value: Types.Routing) (req: SearchShardsRequest) =
            { req with Routing = Some value }

    type SearchTemplateRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        CcsMinimizeRoundtrips: bool option
        ExpandWildcards: Types.ExpandWildcards option
        Explain: bool option
        IgnoreThrottled: bool option
        IgnoreUnavailable: bool option
        Preference: string option
        Profile: bool option
        Routing: Types.Routing option
        Scroll: Types.Duration option
        SearchType: Types.SearchType option
        RestTotalHitsAsInt: bool option
        TypedKeys: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("explain")>]
        bodyExplain: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("profile")>]
        bodyProfile: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: Types.ScriptSource option
        [<System.Text.Json.Serialization.JsonPropertyName("project_routing")>]
        ProjectRouting: Types.ProjectRouting option
    }

        with
        static member ToEndpoint(req: SearchTemplateRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_search/template"
            let queryParams =
                [
                    req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                    req.CcsMinimizeRoundtrips |> Option.map (fun v -> "ccs_minimize_roundtrips", Fes.Http.toQueryValue v)
                    req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                    req.Explain |> Option.map (fun v -> "explain", Fes.Http.toQueryValue v)
                    req.IgnoreThrottled |> Option.map (fun v -> "ignore_throttled", Fes.Http.toQueryValue v)
                    req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                    req.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                    req.Profile |> Option.map (fun v -> "profile", Fes.Http.toQueryValue v)
                    req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                    req.Scroll |> Option.map (fun v -> "scroll", Fes.Http.toQueryValue v)
                    req.SearchType |> Option.map (fun v -> "search_type", Fes.Http.toQueryValue v)
                    req.RestTotalHitsAsInt |> Option.map (fun v -> "rest_total_hits_as_int", Fes.Http.toQueryValue v)
                    req.TypedKeys |> Option.map (fun v -> "typed_keys", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type SearchTemplateResponse = System.Text.Json.JsonElement

    type SearchTemplateRequestBuilder() =
        member _.Yield(_: unit) : SearchTemplateRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                CcsMinimizeRoundtrips = None
                ExpandWildcards = None
                Explain = None
                IgnoreThrottled = None
                IgnoreUnavailable = None
                Preference = None
                Profile = None
                Routing = None
                Scroll = None
                SearchType = None
                RestTotalHitsAsInt = None
                TypedKeys = None
                bodyExplain = None
                Id = None
                Params = None
                bodyProfile = None
                Source = None
                ProjectRouting = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: SearchTemplateRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: SearchTemplateRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("ccsMinimizeRoundtrips")>]
        member _.CcsMinimizeRoundtrips(state: SearchTemplateRequest, value: bool) =
            { state with CcsMinimizeRoundtrips = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: SearchTemplateRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("explain")>]
        member _.Explain(state: SearchTemplateRequest, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("ignoreThrottled")>]
        member _.IgnoreThrottled(state: SearchTemplateRequest, value: bool) =
            { state with IgnoreThrottled = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: SearchTemplateRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("preference")>]
        member _.Preference(state: SearchTemplateRequest, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("profile")>]
        member _.Profile(state: SearchTemplateRequest, value: bool) =
            { state with Profile = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: SearchTemplateRequest, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("scroll")>]
        member _.Scroll(state: SearchTemplateRequest, value: Types.Duration) =
            { state with Scroll = Some value }

        [<CustomOperation("searchType")>]
        member _.SearchType(state: SearchTemplateRequest, value: Types.SearchType) =
            { state with SearchType = Some value }

        [<CustomOperation("restTotalHitsAsInt")>]
        member _.RestTotalHitsAsInt(state: SearchTemplateRequest, value: bool) =
            { state with RestTotalHitsAsInt = Some value }

        [<CustomOperation("typedKeys")>]
        member _.TypedKeys(state: SearchTemplateRequest, value: bool) =
            { state with TypedKeys = Some value }

        [<CustomOperation("bodyExplain")>]
        member _.BodyExplain(state: SearchTemplateRequest, value: bool) =
            { state with bodyExplain = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: SearchTemplateRequest, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: SearchTemplateRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("bodyProfile")>]
        member _.BodyProfile(state: SearchTemplateRequest, value: bool) =
            { state with bodyProfile = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: SearchTemplateRequest, value: Types.ScriptSource) =
            { state with Source = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: SearchTemplateRequest, value: Types.ProjectRouting) =
            { state with ProjectRouting = Some value }

    let searchTemplateRequest = SearchTemplateRequestBuilder()

    module SearchTemplate =
        let withAllowNoIndices (value: bool) (req: SearchTemplateRequest) =
            { req with AllowNoIndices = Some value }
        let withCcsMinimizeRoundtrips (value: bool) (req: SearchTemplateRequest) =
            { req with CcsMinimizeRoundtrips = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: SearchTemplateRequest) =
            { req with ExpandWildcards = Some value }
        let withExplain (value: bool) (req: SearchTemplateRequest) =
            { req with Explain = Some value }
        let withIgnoreThrottled (value: bool) (req: SearchTemplateRequest) =
            { req with IgnoreThrottled = Some value }
        let withIgnoreUnavailable (value: bool) (req: SearchTemplateRequest) =
            { req with IgnoreUnavailable = Some value }
        let withPreference (value: string) (req: SearchTemplateRequest) =
            { req with Preference = Some value }
        let withProfile (value: bool) (req: SearchTemplateRequest) =
            { req with Profile = Some value }
        let withRouting (value: Types.Routing) (req: SearchTemplateRequest) =
            { req with Routing = Some value }
        let withScroll (value: Types.Duration) (req: SearchTemplateRequest) =
            { req with Scroll = Some value }
        let withSearchType (value: Types.SearchType) (req: SearchTemplateRequest) =
            { req with SearchType = Some value }
        let withRestTotalHitsAsInt (value: bool) (req: SearchTemplateRequest) =
            { req with RestTotalHitsAsInt = Some value }
        let withTypedKeys (value: bool) (req: SearchTemplateRequest) =
            { req with TypedKeys = Some value }
        let withBodyExplain (value: bool) (req: SearchTemplateRequest) =
            { req with bodyExplain = Some value }
        let withId (value: Types.Id) (req: SearchTemplateRequest) =
            { req with Id = Some value }
        let withParams (value: Map<string, System.Text.Json.JsonElement>) (req: SearchTemplateRequest) =
            { req with Params = Some value }
        let withBodyProfile (value: bool) (req: SearchTemplateRequest) =
            { req with bodyProfile = Some value }
        let withSource (value: Types.ScriptSource) (req: SearchTemplateRequest) =
            { req with Source = Some value }
        let withProjectRouting (value: Types.ProjectRouting) (req: SearchTemplateRequest) =
            { req with ProjectRouting = Some value }

    type TermsEnumRequest = {
        Index: Types.Indices
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("timeout")>]
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("case_insensitive")>]
        CaseInsensitive: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index_filter")>]
        IndexFilter: Types.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("string")>]
        String: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search_after")>]
        SearchAfter: string option
    }

        with
        static member ToEndpoint(req: TermsEnumRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_terms_enum"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type TermsEnumResponse = System.Text.Json.JsonElement

    type TermsEnumRequestBuilder() =
        member _.Yield(_: unit) : TermsEnumRequest =
            {
                Index = Unchecked.defaultof<_>
                Field = Unchecked.defaultof<_>
                Size = None
                Timeout = None
                CaseInsensitive = None
                IndexFilter = None
                String = None
                SearchAfter = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: TermsEnumRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("field")>]
        member _.Field(state: TermsEnumRequest, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("size")>]
        member _.Size(state: TermsEnumRequest, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TermsEnumRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("caseInsensitive")>]
        member _.CaseInsensitive(state: TermsEnumRequest, value: bool) =
            { state with CaseInsensitive = Some value }

        [<CustomOperation("indexFilter")>]
        member _.IndexFilter(state: TermsEnumRequest, value: Types.QueryContainer) =
            { state with IndexFilter = Some value }

        [<CustomOperation("string")>]
        member _.String(state: TermsEnumRequest, value: string) =
            { state with String = Some value }

        [<CustomOperation("searchAfter")>]
        member _.SearchAfter(state: TermsEnumRequest, value: string) =
            { state with SearchAfter = Some value }

    let termsEnumRequest = TermsEnumRequestBuilder()

    module TermsEnum =
        let withField (value: Types.Field) (req: TermsEnumRequest) =
            { req with Field = value }
        let withSize (value: Types.Integer) (req: TermsEnumRequest) =
            { req with Size = Some value }
        let withTimeout (value: Types.Duration) (req: TermsEnumRequest) =
            { req with Timeout = Some value }
        let withCaseInsensitive (value: bool) (req: TermsEnumRequest) =
            { req with CaseInsensitive = Some value }
        let withIndexFilter (value: Types.QueryContainer) (req: TermsEnumRequest) =
            { req with IndexFilter = Some value }
        let withString (value: string) (req: TermsEnumRequest) =
            { req with String = Some value }
        let withSearchAfter (value: string) (req: TermsEnumRequest) =
            { req with SearchAfter = Some value }

    type TermvectorsRequest<'TDocument> = {
        Index: Types.IndexName
        Id: Types.Id
        Fields: Types.Fields option
        FieldStatistics: bool option
        Offsets: bool option
        Payloads: bool option
        Positions: bool option
        Preference: string option
        Realtime: bool option
        Routing: Types.Routing option
        TermStatistics: bool option
        Version: Types.VersionNumber option
        VersionType: Types.VersionType option
        [<System.Text.Json.Serialization.JsonPropertyName("doc")>]
        Doc: 'TDocument option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: Types.GlobalTermvectorsFilter option
        [<System.Text.Json.Serialization.JsonPropertyName("per_field_analyzer")>]
        PerFieldAnalyzer: Map<Types.Field, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        bodyFields: Types.Field list option
        [<System.Text.Json.Serialization.JsonPropertyName("field_statistics")>]
        bodyFieldStatistics: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("offsets")>]
        bodyOffsets: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("payloads")>]
        bodyPayloads: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("positions")>]
        bodyPositions: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("term_statistics")>]
        bodyTermStatistics: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        bodyRouting: Types.Routing option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        bodyVersion: Types.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("version_type")>]
        bodyVersionType: Types.VersionType option
    }

        with
        static member ToEndpoint(req: TermvectorsRequest<'TDocument>) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_termvectors/{Fes.Http.toPathSegment req.Id}"
            let queryParams =
                [
                    req.Fields |> Option.map (fun v -> "fields", Fes.Http.toQueryValue v)
                    req.FieldStatistics |> Option.map (fun v -> "field_statistics", Fes.Http.toQueryValue v)
                    req.Offsets |> Option.map (fun v -> "offsets", Fes.Http.toQueryValue v)
                    req.Payloads |> Option.map (fun v -> "payloads", Fes.Http.toQueryValue v)
                    req.Positions |> Option.map (fun v -> "positions", Fes.Http.toQueryValue v)
                    req.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                    req.Realtime |> Option.map (fun v -> "realtime", Fes.Http.toQueryValue v)
                    req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                    req.TermStatistics |> Option.map (fun v -> "term_statistics", Fes.Http.toQueryValue v)
                    req.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                    req.VersionType |> Option.map (fun v -> "version_type", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type TermvectorsResponse = System.Text.Json.JsonElement

    type TermvectorsRequestBuilder() =
        member _.Yield(_: unit) : TermvectorsRequest<_> =
            {
                Index = Unchecked.defaultof<_>
                Id = Unchecked.defaultof<_>
                Fields = None
                FieldStatistics = None
                Offsets = None
                Payloads = None
                Positions = None
                Preference = None
                Realtime = None
                Routing = None
                TermStatistics = None
                Version = None
                VersionType = None
                Doc = None
                Filter = None
                PerFieldAnalyzer = None
                bodyFields = None
                bodyFieldStatistics = None
                bodyOffsets = None
                bodyPayloads = None
                bodyPositions = None
                bodyTermStatistics = None
                bodyRouting = None
                bodyVersion = None
                bodyVersionType = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: TermvectorsRequest<_>, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("id")>]
        member _.Id(state: TermvectorsRequest<_>, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("fields")>]
        member _.Fields(state: TermvectorsRequest<_>, value: Types.Fields) =
            { state with Fields = Some value }

        [<CustomOperation("fieldStatistics")>]
        member _.FieldStatistics(state: TermvectorsRequest<_>, value: bool) =
            { state with FieldStatistics = Some value }

        [<CustomOperation("offsets")>]
        member _.Offsets(state: TermvectorsRequest<_>, value: bool) =
            { state with Offsets = Some value }

        [<CustomOperation("payloads")>]
        member _.Payloads(state: TermvectorsRequest<_>, value: bool) =
            { state with Payloads = Some value }

        [<CustomOperation("positions")>]
        member _.Positions(state: TermvectorsRequest<_>, value: bool) =
            { state with Positions = Some value }

        [<CustomOperation("preference")>]
        member _.Preference(state: TermvectorsRequest<_>, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("realtime")>]
        member _.Realtime(state: TermvectorsRequest<_>, value: bool) =
            { state with Realtime = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: TermvectorsRequest<_>, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("termStatistics")>]
        member _.TermStatistics(state: TermvectorsRequest<_>, value: bool) =
            { state with TermStatistics = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: TermvectorsRequest<_>, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: TermvectorsRequest<_>, value: Types.VersionType) =
            { state with VersionType = Some value }

        [<CustomOperation("doc")>]
        member _.Doc(state: TermvectorsRequest<_>, value: 'TDocument) =
            { state with Doc = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: TermvectorsRequest<_>, value: Types.GlobalTermvectorsFilter) =
            { state with Filter = Some value }

        [<CustomOperation("perFieldAnalyzer")>]
        member _.PerFieldAnalyzer(state: TermvectorsRequest<_>, value: Map<Types.Field, string>) =
            { state with PerFieldAnalyzer = Some value }

        [<CustomOperation("bodyFields")>]
        member _.BodyFields(state: TermvectorsRequest<_>, value: Types.Field list) =
            { state with bodyFields = Some value }

        [<CustomOperation("bodyFieldStatistics")>]
        member _.BodyFieldStatistics(state: TermvectorsRequest<_>, value: bool) =
            { state with bodyFieldStatistics = Some value }

        [<CustomOperation("bodyOffsets")>]
        member _.BodyOffsets(state: TermvectorsRequest<_>, value: bool) =
            { state with bodyOffsets = Some value }

        [<CustomOperation("bodyPayloads")>]
        member _.BodyPayloads(state: TermvectorsRequest<_>, value: bool) =
            { state with bodyPayloads = Some value }

        [<CustomOperation("bodyPositions")>]
        member _.BodyPositions(state: TermvectorsRequest<_>, value: bool) =
            { state with bodyPositions = Some value }

        [<CustomOperation("bodyTermStatistics")>]
        member _.BodyTermStatistics(state: TermvectorsRequest<_>, value: bool) =
            { state with bodyTermStatistics = Some value }

        [<CustomOperation("bodyRouting")>]
        member _.BodyRouting(state: TermvectorsRequest<_>, value: Types.Routing) =
            { state with bodyRouting = Some value }

        [<CustomOperation("bodyVersion")>]
        member _.BodyVersion(state: TermvectorsRequest<_>, value: Types.VersionNumber) =
            { state with bodyVersion = Some value }

        [<CustomOperation("bodyVersionType")>]
        member _.BodyVersionType(state: TermvectorsRequest<_>, value: Types.VersionType) =
            { state with bodyVersionType = Some value }

    let termvectorsRequest = TermvectorsRequestBuilder()

    module Termvectors =
        let withFields (value: Types.Fields) (req: TermvectorsRequest<_>) =
            { req with Fields = Some value }
        let withFieldStatistics (value: bool) (req: TermvectorsRequest<_>) =
            { req with FieldStatistics = Some value }
        let withOffsets (value: bool) (req: TermvectorsRequest<_>) =
            { req with Offsets = Some value }
        let withPayloads (value: bool) (req: TermvectorsRequest<_>) =
            { req with Payloads = Some value }
        let withPositions (value: bool) (req: TermvectorsRequest<_>) =
            { req with Positions = Some value }
        let withPreference (value: string) (req: TermvectorsRequest<_>) =
            { req with Preference = Some value }
        let withRealtime (value: bool) (req: TermvectorsRequest<_>) =
            { req with Realtime = Some value }
        let withRouting (value: Types.Routing) (req: TermvectorsRequest<_>) =
            { req with Routing = Some value }
        let withTermStatistics (value: bool) (req: TermvectorsRequest<_>) =
            { req with TermStatistics = Some value }
        let withVersion (value: Types.VersionNumber) (req: TermvectorsRequest<_>) =
            { req with Version = Some value }
        let withVersionType (value: Types.VersionType) (req: TermvectorsRequest<_>) =
            { req with VersionType = Some value }
        let withDoc (value: 'TDocument) (req: TermvectorsRequest<_>) =
            { req with Doc = Some value }
        let withFilter (value: Types.GlobalTermvectorsFilter) (req: TermvectorsRequest<_>) =
            { req with Filter = Some value }
        let withPerFieldAnalyzer (value: Map<Types.Field, string>) (req: TermvectorsRequest<_>) =
            { req with PerFieldAnalyzer = Some value }
        let withBodyFields (value: Types.Field list) (req: TermvectorsRequest<_>) =
            { req with bodyFields = Some value }
        let withBodyFieldStatistics (value: bool) (req: TermvectorsRequest<_>) =
            { req with bodyFieldStatistics = Some value }
        let withBodyOffsets (value: bool) (req: TermvectorsRequest<_>) =
            { req with bodyOffsets = Some value }
        let withBodyPayloads (value: bool) (req: TermvectorsRequest<_>) =
            { req with bodyPayloads = Some value }
        let withBodyPositions (value: bool) (req: TermvectorsRequest<_>) =
            { req with bodyPositions = Some value }
        let withBodyTermStatistics (value: bool) (req: TermvectorsRequest<_>) =
            { req with bodyTermStatistics = Some value }
        let withBodyRouting (value: Types.Routing) (req: TermvectorsRequest<_>) =
            { req with bodyRouting = Some value }
        let withBodyVersion (value: Types.VersionNumber) (req: TermvectorsRequest<_>) =
            { req with bodyVersion = Some value }
        let withBodyVersionType (value: Types.VersionType) (req: TermvectorsRequest<_>) =
            { req with bodyVersionType = Some value }

    type UpdateRequest<'TDocument, 'TPartialDocument> = {
        Id: Types.Id
        Index: Types.IndexName
        IfPrimaryTerm: Types.Long option
        IfSeqNo: Types.SequenceNumber option
        IncludeSourceOnError: bool option
        Lang: string option
        Refresh: Types.Refresh option
        RequireAlias: bool option
        RetryOnConflict: Types.Integer option
        Routing: Types.Routing option
        Timeout: Types.Duration option
        WaitForActiveShards: Types.WaitForActiveShards option
        Source: Types.SourceConfigParam option
        SourceExcludes: Types.Fields option
        SourceIncludes: Types.Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("detect_noop")>]
        DetectNoop: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("doc")>]
        Doc: 'TPartialDocument option
        [<System.Text.Json.Serialization.JsonPropertyName("doc_as_upsert")>]
        DocAsUpsert: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("scripted_upsert")>]
        ScriptedUpsert: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        bodySource: Types.SourceConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("upsert")>]
        Upsert: 'TDocument option
    }

        with
        static member ToEndpoint(req: UpdateRequest<'TDocument, 'TPartialDocument>) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_update/{Fes.Http.toPathSegment req.Id}"
            let queryParams =
                [
                    req.IfPrimaryTerm |> Option.map (fun v -> "if_primary_term", Fes.Http.toQueryValue v)
                    req.IfSeqNo |> Option.map (fun v -> "if_seq_no", Fes.Http.toQueryValue v)
                    req.IncludeSourceOnError |> Option.map (fun v -> "include_source_on_error", Fes.Http.toQueryValue v)
                    req.Lang |> Option.map (fun v -> "lang", Fes.Http.toQueryValue v)
                    req.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    req.RequireAlias |> Option.map (fun v -> "require_alias", Fes.Http.toQueryValue v)
                    req.RetryOnConflict |> Option.map (fun v -> "retry_on_conflict", Fes.Http.toQueryValue v)
                    req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    req.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                    req.Source |> Option.map (fun v -> "_source", Fes.Http.toQueryValue v)
                    req.SourceExcludes |> Option.map (fun v -> "_source_excludes", Fes.Http.toQueryValue v)
                    req.SourceIncludes |> Option.map (fun v -> "_source_includes", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type UpdateResponse<'TDocument> = Types.UpdateWriteResponseBase<'TDocument>

    type UpdateRequestBuilder() =
        member _.Yield(_: unit) : UpdateRequest<_, _> =
            {
                Id = Unchecked.defaultof<_>
                Index = Unchecked.defaultof<_>
                IfPrimaryTerm = None
                IfSeqNo = None
                IncludeSourceOnError = None
                Lang = None
                Refresh = None
                RequireAlias = None
                RetryOnConflict = None
                Routing = None
                Timeout = None
                WaitForActiveShards = None
                Source = None
                SourceExcludes = None
                SourceIncludes = None
                DetectNoop = None
                Doc = None
                DocAsUpsert = None
                Script = None
                ScriptedUpsert = None
                bodySource = None
                Upsert = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: UpdateRequest<_, _>, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: UpdateRequest<_, _>, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("ifPrimaryTerm")>]
        member _.IfPrimaryTerm(state: UpdateRequest<_, _>, value: Types.Long) =
            { state with IfPrimaryTerm = Some value }

        [<CustomOperation("ifSeqNo")>]
        member _.IfSeqNo(state: UpdateRequest<_, _>, value: Types.SequenceNumber) =
            { state with IfSeqNo = Some value }

        [<CustomOperation("includeSourceOnError")>]
        member _.IncludeSourceOnError(state: UpdateRequest<_, _>, value: bool) =
            { state with IncludeSourceOnError = Some value }

        [<CustomOperation("lang")>]
        member _.Lang(state: UpdateRequest<_, _>, value: string) =
            { state with Lang = Some value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: UpdateRequest<_, _>, value: Types.Refresh) =
            { state with Refresh = Some value }

        [<CustomOperation("requireAlias")>]
        member _.RequireAlias(state: UpdateRequest<_, _>, value: bool) =
            { state with RequireAlias = Some value }

        [<CustomOperation("retryOnConflict")>]
        member _.RetryOnConflict(state: UpdateRequest<_, _>, value: Types.Integer) =
            { state with RetryOnConflict = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: UpdateRequest<_, _>, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: UpdateRequest<_, _>, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: UpdateRequest<_, _>, value: Types.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: UpdateRequest<_, _>, value: Types.SourceConfigParam) =
            { state with Source = Some value }

        [<CustomOperation("sourceExcludes")>]
        member _.SourceExcludes(state: UpdateRequest<_, _>, value: Types.Fields) =
            { state with SourceExcludes = Some value }

        [<CustomOperation("sourceIncludes")>]
        member _.SourceIncludes(state: UpdateRequest<_, _>, value: Types.Fields) =
            { state with SourceIncludes = Some value }

        [<CustomOperation("detectNoop")>]
        member _.DetectNoop(state: UpdateRequest<_, _>, value: bool) =
            { state with DetectNoop = Some value }

        [<CustomOperation("doc")>]
        member _.Doc(state: UpdateRequest<_, _>, value: 'TPartialDocument) =
            { state with Doc = Some value }

        [<CustomOperation("docAsUpsert")>]
        member _.DocAsUpsert(state: UpdateRequest<_, _>, value: bool) =
            { state with DocAsUpsert = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: UpdateRequest<_, _>, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("scriptedUpsert")>]
        member _.ScriptedUpsert(state: UpdateRequest<_, _>, value: bool) =
            { state with ScriptedUpsert = Some value }

        [<CustomOperation("bodySource")>]
        member _.BodySource(state: UpdateRequest<_, _>, value: Types.SourceConfig) =
            { state with bodySource = Some value }

        [<CustomOperation("upsert")>]
        member _.Upsert(state: UpdateRequest<_, _>, value: 'TDocument) =
            { state with Upsert = Some value }

    let updateRequest = UpdateRequestBuilder()

    module Update =
        let withIfPrimaryTerm (value: Types.Long) (req: UpdateRequest<_, _>) =
            { req with IfPrimaryTerm = Some value }
        let withIfSeqNo (value: Types.SequenceNumber) (req: UpdateRequest<_, _>) =
            { req with IfSeqNo = Some value }
        let withIncludeSourceOnError (value: bool) (req: UpdateRequest<_, _>) =
            { req with IncludeSourceOnError = Some value }
        let withLang (value: string) (req: UpdateRequest<_, _>) =
            { req with Lang = Some value }
        let withRefresh (value: Types.Refresh) (req: UpdateRequest<_, _>) =
            { req with Refresh = Some value }
        let withRequireAlias (value: bool) (req: UpdateRequest<_, _>) =
            { req with RequireAlias = Some value }
        let withRetryOnConflict (value: Types.Integer) (req: UpdateRequest<_, _>) =
            { req with RetryOnConflict = Some value }
        let withRouting (value: Types.Routing) (req: UpdateRequest<_, _>) =
            { req with Routing = Some value }
        let withTimeout (value: Types.Duration) (req: UpdateRequest<_, _>) =
            { req with Timeout = Some value }
        let withWaitForActiveShards (value: Types.WaitForActiveShards) (req: UpdateRequest<_, _>) =
            { req with WaitForActiveShards = Some value }
        let withSource (value: Types.SourceConfigParam) (req: UpdateRequest<_, _>) =
            { req with Source = Some value }
        let withSourceExcludes (value: Types.Fields) (req: UpdateRequest<_, _>) =
            { req with SourceExcludes = Some value }
        let withSourceIncludes (value: Types.Fields) (req: UpdateRequest<_, _>) =
            { req with SourceIncludes = Some value }
        let withDetectNoop (value: bool) (req: UpdateRequest<_, _>) =
            { req with DetectNoop = Some value }
        let withDoc (value: 'TPartialDocument) (req: UpdateRequest<_, _>) =
            { req with Doc = Some value }
        let withDocAsUpsert (value: bool) (req: UpdateRequest<_, _>) =
            { req with DocAsUpsert = Some value }
        let withScript (value: Types.Script) (req: UpdateRequest<_, _>) =
            { req with Script = Some value }
        let withScriptedUpsert (value: bool) (req: UpdateRequest<_, _>) =
            { req with ScriptedUpsert = Some value }
        let withBodySource (value: Types.SourceConfig) (req: UpdateRequest<_, _>) =
            { req with bodySource = Some value }
        let withUpsert (value: 'TDocument) (req: UpdateRequest<_, _>) =
            { req with Upsert = Some value }

    type UpdateByQueryRequest = {
        Index: Types.Indices
        AllowNoIndices: bool option
        Analyzer: string option
        AnalyzeWildcard: bool option
        Conflicts: Types.Conflicts option
        DefaultOperator: Types.Operator option
        Df: string option
        ExpandWildcards: Types.ExpandWildcards option
        From: Types.Long option
        IgnoreUnavailable: bool option
        Lenient: bool option
        MaxDocs: Types.Long option
        Pipeline: string option
        Preference: string option
        Q: string option
        Refresh: bool option
        RequestCache: bool option
        RequestsPerSecond: Types.Float option
        Routing: Types.Routing option
        Scroll: Types.Duration option
        ScrollSize: Types.Long option
        SearchTimeout: Types.Duration option
        SearchType: Types.SearchType option
        Slices: Types.Slices option
        Sort: string list option
        Stats: string list option
        TerminateAfter: Types.Long option
        Timeout: Types.Duration option
        Version: bool option
        VersionType: bool option
        WaitForActiveShards: Types.WaitForActiveShards option
        WaitForCompletion: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("max_docs")>]
        bodyMaxDocs: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: Types.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("slice")>]
        Slice: Types.SlicedScroll option
        [<System.Text.Json.Serialization.JsonPropertyName("conflicts")>]
        bodyConflicts: Types.Conflicts option
    }

        with
        static member ToEndpoint(req: UpdateByQueryRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_update_by_query"
            let queryParams =
                [
                    req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                    req.Analyzer |> Option.map (fun v -> "analyzer", Fes.Http.toQueryValue v)
                    req.AnalyzeWildcard |> Option.map (fun v -> "analyze_wildcard", Fes.Http.toQueryValue v)
                    req.Conflicts |> Option.map (fun v -> "conflicts", Fes.Http.toQueryValue v)
                    req.DefaultOperator |> Option.map (fun v -> "default_operator", Fes.Http.toQueryValue v)
                    req.Df |> Option.map (fun v -> "df", Fes.Http.toQueryValue v)
                    req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                    req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                    req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                    req.Lenient |> Option.map (fun v -> "lenient", Fes.Http.toQueryValue v)
                    req.MaxDocs |> Option.map (fun v -> "max_docs", Fes.Http.toQueryValue v)
                    req.Pipeline |> Option.map (fun v -> "pipeline", Fes.Http.toQueryValue v)
                    req.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                    req.Q |> Option.map (fun v -> "q", Fes.Http.toQueryValue v)
                    req.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    req.RequestCache |> Option.map (fun v -> "request_cache", Fes.Http.toQueryValue v)
                    req.RequestsPerSecond |> Option.map (fun v -> "requests_per_second", Fes.Http.toQueryValue v)
                    req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                    req.Scroll |> Option.map (fun v -> "scroll", Fes.Http.toQueryValue v)
                    req.ScrollSize |> Option.map (fun v -> "scroll_size", Fes.Http.toQueryValue v)
                    req.SearchTimeout |> Option.map (fun v -> "search_timeout", Fes.Http.toQueryValue v)
                    req.SearchType |> Option.map (fun v -> "search_type", Fes.Http.toQueryValue v)
                    req.Slices |> Option.map (fun v -> "slices", Fes.Http.toQueryValue v)
                    req.Sort |> Option.map (fun v -> "sort", Fes.Http.toQueryValue v)
                    req.Stats |> Option.map (fun v -> "stats", Fes.Http.toQueryValue v)
                    req.TerminateAfter |> Option.map (fun v -> "terminate_after", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    req.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                    req.VersionType |> Option.map (fun v -> "version_type", Fes.Http.toQueryValue v)
                    req.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                    req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type UpdateByQueryResponse = System.Text.Json.JsonElement

    type UpdateByQueryRequestBuilder() =
        member _.Yield(_: unit) : UpdateByQueryRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                Analyzer = None
                AnalyzeWildcard = None
                Conflicts = None
                DefaultOperator = None
                Df = None
                ExpandWildcards = None
                From = None
                IgnoreUnavailable = None
                Lenient = None
                MaxDocs = None
                Pipeline = None
                Preference = None
                Q = None
                Refresh = None
                RequestCache = None
                RequestsPerSecond = None
                Routing = None
                Scroll = None
                ScrollSize = None
                SearchTimeout = None
                SearchType = None
                Slices = None
                Sort = None
                Stats = None
                TerminateAfter = None
                Timeout = None
                Version = None
                VersionType = None
                WaitForActiveShards = None
                WaitForCompletion = None
                bodyMaxDocs = None
                Query = None
                Script = None
                Slice = None
                bodyConflicts = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: UpdateByQueryRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: UpdateByQueryRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: UpdateByQueryRequest, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("analyzeWildcard")>]
        member _.AnalyzeWildcard(state: UpdateByQueryRequest, value: bool) =
            { state with AnalyzeWildcard = Some value }

        [<CustomOperation("conflicts")>]
        member _.Conflicts(state: UpdateByQueryRequest, value: Types.Conflicts) =
            { state with Conflicts = Some value }

        [<CustomOperation("defaultOperator")>]
        member _.DefaultOperator(state: UpdateByQueryRequest, value: Types.Operator) =
            { state with DefaultOperator = Some value }

        [<CustomOperation("df")>]
        member _.Df(state: UpdateByQueryRequest, value: string) =
            { state with Df = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: UpdateByQueryRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("from")>]
        member _.From(state: UpdateByQueryRequest, value: Types.Long) =
            { state with From = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: UpdateByQueryRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("lenient")>]
        member _.Lenient(state: UpdateByQueryRequest, value: bool) =
            { state with Lenient = Some value }

        [<CustomOperation("maxDocs")>]
        member _.MaxDocs(state: UpdateByQueryRequest, value: Types.Long) =
            { state with MaxDocs = Some value }

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: UpdateByQueryRequest, value: string) =
            { state with Pipeline = Some value }

        [<CustomOperation("preference")>]
        member _.Preference(state: UpdateByQueryRequest, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("q")>]
        member _.Q(state: UpdateByQueryRequest, value: string) =
            { state with Q = Some value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: UpdateByQueryRequest, value: bool) =
            { state with Refresh = Some value }

        [<CustomOperation("requestCache")>]
        member _.RequestCache(state: UpdateByQueryRequest, value: bool) =
            { state with RequestCache = Some value }

        [<CustomOperation("requestsPerSecond")>]
        member _.RequestsPerSecond(state: UpdateByQueryRequest, value: Types.Float) =
            { state with RequestsPerSecond = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: UpdateByQueryRequest, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("scroll")>]
        member _.Scroll(state: UpdateByQueryRequest, value: Types.Duration) =
            { state with Scroll = Some value }

        [<CustomOperation("scrollSize")>]
        member _.ScrollSize(state: UpdateByQueryRequest, value: Types.Long) =
            { state with ScrollSize = Some value }

        [<CustomOperation("searchTimeout")>]
        member _.SearchTimeout(state: UpdateByQueryRequest, value: Types.Duration) =
            { state with SearchTimeout = Some value }

        [<CustomOperation("searchType")>]
        member _.SearchType(state: UpdateByQueryRequest, value: Types.SearchType) =
            { state with SearchType = Some value }

        [<CustomOperation("slices")>]
        member _.Slices(state: UpdateByQueryRequest, value: Types.Slices) =
            { state with Slices = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: UpdateByQueryRequest, value: string list) =
            { state with Sort = Some value }

        [<CustomOperation("stats")>]
        member _.Stats(state: UpdateByQueryRequest, value: string list) =
            { state with Stats = Some value }

        [<CustomOperation("terminateAfter")>]
        member _.TerminateAfter(state: UpdateByQueryRequest, value: Types.Long) =
            { state with TerminateAfter = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: UpdateByQueryRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: UpdateByQueryRequest, value: bool) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: UpdateByQueryRequest, value: bool) =
            { state with VersionType = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: UpdateByQueryRequest, value: Types.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: UpdateByQueryRequest, value: bool) =
            { state with WaitForCompletion = Some value }

        [<CustomOperation("bodyMaxDocs")>]
        member _.BodyMaxDocs(state: UpdateByQueryRequest, value: Types.Long) =
            { state with bodyMaxDocs = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: UpdateByQueryRequest, value: Types.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: UpdateByQueryRequest, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("slice")>]
        member _.Slice(state: UpdateByQueryRequest, value: Types.SlicedScroll) =
            { state with Slice = Some value }

        [<CustomOperation("bodyConflicts")>]
        member _.BodyConflicts(state: UpdateByQueryRequest, value: Types.Conflicts) =
            { state with bodyConflicts = Some value }

    let updateByQueryRequest = UpdateByQueryRequestBuilder()

    module UpdateByQuery =
        let withAllowNoIndices (value: bool) (req: UpdateByQueryRequest) =
            { req with AllowNoIndices = Some value }
        let withAnalyzer (value: string) (req: UpdateByQueryRequest) =
            { req with Analyzer = Some value }
        let withAnalyzeWildcard (value: bool) (req: UpdateByQueryRequest) =
            { req with AnalyzeWildcard = Some value }
        let withConflicts (value: Types.Conflicts) (req: UpdateByQueryRequest) =
            { req with Conflicts = Some value }
        let withDefaultOperator (value: Types.Operator) (req: UpdateByQueryRequest) =
            { req with DefaultOperator = Some value }
        let withDf (value: string) (req: UpdateByQueryRequest) =
            { req with Df = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: UpdateByQueryRequest) =
            { req with ExpandWildcards = Some value }
        let withFrom (value: Types.Long) (req: UpdateByQueryRequest) =
            { req with From = Some value }
        let withIgnoreUnavailable (value: bool) (req: UpdateByQueryRequest) =
            { req with IgnoreUnavailable = Some value }
        let withLenient (value: bool) (req: UpdateByQueryRequest) =
            { req with Lenient = Some value }
        let withMaxDocs (value: Types.Long) (req: UpdateByQueryRequest) =
            { req with MaxDocs = Some value }
        let withPipeline (value: string) (req: UpdateByQueryRequest) =
            { req with Pipeline = Some value }
        let withPreference (value: string) (req: UpdateByQueryRequest) =
            { req with Preference = Some value }
        let withQ (value: string) (req: UpdateByQueryRequest) =
            { req with Q = Some value }
        let withRefresh (value: bool) (req: UpdateByQueryRequest) =
            { req with Refresh = Some value }
        let withRequestCache (value: bool) (req: UpdateByQueryRequest) =
            { req with RequestCache = Some value }
        let withRequestsPerSecond (value: Types.Float) (req: UpdateByQueryRequest) =
            { req with RequestsPerSecond = Some value }
        let withRouting (value: Types.Routing) (req: UpdateByQueryRequest) =
            { req with Routing = Some value }
        let withScroll (value: Types.Duration) (req: UpdateByQueryRequest) =
            { req with Scroll = Some value }
        let withScrollSize (value: Types.Long) (req: UpdateByQueryRequest) =
            { req with ScrollSize = Some value }
        let withSearchTimeout (value: Types.Duration) (req: UpdateByQueryRequest) =
            { req with SearchTimeout = Some value }
        let withSearchType (value: Types.SearchType) (req: UpdateByQueryRequest) =
            { req with SearchType = Some value }
        let withSlices (value: Types.Slices) (req: UpdateByQueryRequest) =
            { req with Slices = Some value }
        let withSort (value: string list) (req: UpdateByQueryRequest) =
            { req with Sort = Some value }
        let withStats (value: string list) (req: UpdateByQueryRequest) =
            { req with Stats = Some value }
        let withTerminateAfter (value: Types.Long) (req: UpdateByQueryRequest) =
            { req with TerminateAfter = Some value }
        let withTimeout (value: Types.Duration) (req: UpdateByQueryRequest) =
            { req with Timeout = Some value }
        let withVersion (value: bool) (req: UpdateByQueryRequest) =
            { req with Version = Some value }
        let withVersionType (value: bool) (req: UpdateByQueryRequest) =
            { req with VersionType = Some value }
        let withWaitForActiveShards (value: Types.WaitForActiveShards) (req: UpdateByQueryRequest) =
            { req with WaitForActiveShards = Some value }
        let withWaitForCompletion (value: bool) (req: UpdateByQueryRequest) =
            { req with WaitForCompletion = Some value }
        let withBodyMaxDocs (value: Types.Long) (req: UpdateByQueryRequest) =
            { req with bodyMaxDocs = Some value }
        let withQuery (value: Types.QueryContainer) (req: UpdateByQueryRequest) =
            { req with Query = Some value }
        let withScript (value: Types.Script) (req: UpdateByQueryRequest) =
            { req with Script = Some value }
        let withSlice (value: Types.SlicedScroll) (req: UpdateByQueryRequest) =
            { req with Slice = Some value }
        let withBodyConflicts (value: Types.Conflicts) (req: UpdateByQueryRequest) =
            { req with bodyConflicts = Some value }

    type UpdateByQueryRethrottleRequest = {
        TaskId: Types.Id
        RequestsPerSecond: Types.Float
    }

        with
        static member ToEndpoint(req: UpdateByQueryRethrottleRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_update_by_query/{Fes.Http.toPathSegment req.TaskId}/_rethrottle"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            endpoint, ValueNone

    type UpdateByQueryRethrottleResponse = System.Text.Json.JsonElement

    type UpdateByQueryRethrottleRequestBuilder() =
        member _.Yield(_: unit) : UpdateByQueryRethrottleRequest =
            {
                TaskId = Unchecked.defaultof<_>
                RequestsPerSecond = Unchecked.defaultof<_>
            }

        [<CustomOperation("taskId")>]
        member _.TaskId(state: UpdateByQueryRethrottleRequest, value: Types.Id) =
            { state with TaskId = value }

        [<CustomOperation("requestsPerSecond")>]
        member _.RequestsPerSecond(state: UpdateByQueryRethrottleRequest, value: Types.Float) =
            { state with RequestsPerSecond = value }

    let updateByQueryRethrottleRequest = UpdateByQueryRethrottleRequestBuilder()

    module UpdateByQueryRethrottle =
        let withRequestsPerSecond (value: Types.Float) (req: UpdateByQueryRethrottleRequest) =
            { req with RequestsPerSecond = value }


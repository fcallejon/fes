// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module GlobalOperations =

    type BulkRequest = {
        Index: CoreTypes.IndexName
        IncludeSourceOnError: bool option
        ListExecutedPipelines: bool option
        Pipeline: string option
        Refresh: CoreTypes.Refresh option
        Routing: CoreTypes.Routing option
        Source: GlobalSearchTypes.SourceConfigParam option
        SourceExcludes: CoreTypes.Fields option
        SourceIncludes: CoreTypes.Fields option
        Timeout: CoreTypes.Duration option
        WaitForActiveShards: CoreTypes.WaitForActiveShards option
        RequireAlias: bool option
        RequireDataStream: bool option
        Document: obj
    }

        with
        static member ToRequest(req: BulkRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_bulk"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type BulkResponse = System.Text.Json.JsonElement

    type BulkRequestBuilder() =
        member _.Yield(_: unit) : BulkRequest =
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
        member _.Index(state: BulkRequest, value: CoreTypes.IndexName) =
            { state with Index = value }

        [<CustomOperation("includeSourceOnError")>]
        member _.IncludeSourceOnError(state: BulkRequest, value: bool) =
            { state with IncludeSourceOnError = Some value }

        [<CustomOperation("listExecutedPipelines")>]
        member _.ListExecutedPipelines(state: BulkRequest, value: bool) =
            { state with ListExecutedPipelines = Some value }

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: BulkRequest, value: string) =
            { state with Pipeline = Some value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: BulkRequest, value: CoreTypes.Refresh) =
            { state with Refresh = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: BulkRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: BulkRequest, value: GlobalSearchTypes.SourceConfigParam) =
            { state with Source = Some value }

        [<CustomOperation("sourceExcludes")>]
        member _.SourceExcludes(state: BulkRequest, value: CoreTypes.Fields) =
            { state with SourceExcludes = Some value }

        [<CustomOperation("sourceIncludes")>]
        member _.SourceIncludes(state: BulkRequest, value: CoreTypes.Fields) =
            { state with SourceIncludes = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: BulkRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: BulkRequest, value: CoreTypes.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

        [<CustomOperation("requireAlias")>]
        member _.RequireAlias(state: BulkRequest, value: bool) =
            { state with RequireAlias = Some value }

        [<CustomOperation("requireDataStream")>]
        member _.RequireDataStream(state: BulkRequest, value: bool) =
            { state with RequireDataStream = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: BulkRequest, value) =
            { state with Document = value }

    let bulkRequest = BulkRequestBuilder()

    module Bulk =
        let withIncludeSourceOnError (value: bool) (req: BulkRequest) =
            { req with IncludeSourceOnError = Some value }
        let withListExecutedPipelines (value: bool) (req: BulkRequest) =
            { req with ListExecutedPipelines = Some value }
        let withPipeline (value: string) (req: BulkRequest) =
            { req with Pipeline = Some value }
        let withRefresh (value: CoreTypes.Refresh) (req: BulkRequest) =
            { req with Refresh = Some value }
        let withRouting (value: CoreTypes.Routing) (req: BulkRequest) =
            { req with Routing = Some value }
        let withSource (value: GlobalSearchTypes.SourceConfigParam) (req: BulkRequest) =
            { req with Source = Some value }
        let withSourceExcludes (value: CoreTypes.Fields) (req: BulkRequest) =
            { req with SourceExcludes = Some value }
        let withSourceIncludes (value: CoreTypes.Fields) (req: BulkRequest) =
            { req with SourceIncludes = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: BulkRequest) =
            { req with Timeout = Some value }
        let withWaitForActiveShards (value: CoreTypes.WaitForActiveShards) (req: BulkRequest) =
            { req with WaitForActiveShards = Some value }
        let withRequireAlias (value: bool) (req: BulkRequest) =
            { req with RequireAlias = Some value }
        let withRequireDataStream (value: bool) (req: BulkRequest) =
            { req with RequireDataStream = Some value }

    type CapabilitiesRequest = {
        Method: GlobalCapabilities.RestMethod option
        Path: string option
        Parameters: System.Text.Json.JsonElement option
        Capabilities: System.Text.Json.JsonElement option
        LocalOnly: bool option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: CapabilitiesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

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
        member _.Method(state: CapabilitiesRequest, value: GlobalCapabilities.RestMethod) =
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
        member _.Timeout(state: CapabilitiesRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let capabilitiesRequest = CapabilitiesRequestBuilder()

    module Capabilities =
        let withMethod (value: GlobalCapabilities.RestMethod) (req: CapabilitiesRequest) =
            { req with Method = Some value }
        let withPath (value: string) (req: CapabilitiesRequest) =
            { req with Path = Some value }
        let withParameters (value: System.Text.Json.JsonElement) (req: CapabilitiesRequest) =
            { req with Parameters = Some value }
        let withCapabilities (value: System.Text.Json.JsonElement) (req: CapabilitiesRequest) =
            { req with Capabilities = Some value }
        let withLocalOnly (value: bool) (req: CapabilitiesRequest) =
            { req with LocalOnly = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: CapabilitiesRequest) =
            { req with Timeout = Some value }

    type ClearScrollRequest = {
        ScrollId: CoreTypes.ScrollIds
        ScrollId: CoreTypes.ScrollIds option
    }

        with
        static member ToRequest(req: ClearScrollRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_search/scroll/{req.ScrollId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ClearScrollResponse = System.Text.Json.JsonElement

    type ClearScrollRequestBuilder() =
        member _.Yield(_: unit) : ClearScrollRequest =
            {
                ScrollId = Unchecked.defaultof<_>
                ScrollId = None
            }

        [<CustomOperation("scrollId")>]
        member _.ScrollId(state: ClearScrollRequest, value: CoreTypes.ScrollIds) =
            { state with ScrollId = value }

        [<CustomOperation("scrollId")>]
        member _.ScrollId(state: ClearScrollRequest, value: CoreTypes.ScrollIds) =
            { state with ScrollId = Some value }

    let clearScrollRequest = ClearScrollRequestBuilder()

    module ClearScroll =
        let withScrollId (value: CoreTypes.ScrollIds) (req: ClearScrollRequest) =
            { req with ScrollId = Some value }

    type ClosePointInTimeRequest = {
        Id: CoreTypes.Id
    }

        with
        static member ToRequest(req: ClosePointInTimeRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_pit"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ClosePointInTimeResponse = System.Text.Json.JsonElement

    type ClosePointInTimeRequestBuilder() =
        member _.Yield(_: unit) : ClosePointInTimeRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: ClosePointInTimeRequest, value: CoreTypes.Id) =
            { state with Id = value }

    let closePointInTimeRequest = ClosePointInTimeRequestBuilder()

    module ClosePointInTime =
        let withId (value: CoreTypes.Id) (req: ClosePointInTimeRequest) =
            { req with Id = value }

    type CountRequest = {
        Index: CoreTypes.Indices
        AllowNoIndices: bool option
        Analyzer: string option
        AnalyzeWildcard: bool option
        DefaultOperator: CoreTypes.Operator option
        Df: string option
        ExpandWildcards: CoreTypes.ExpandWildcards option
        IgnoreThrottled: bool option
        IgnoreUnavailable: bool option
        Lenient: bool option
        MinScore: CoreTypes.Double option
        Preference: string option
        Routing: CoreTypes.Routing option
        TerminateAfter: CoreTypes.Long option
        Q: string option
        Query: CoreTypes.QueryContainer option
        ProjectRouting: CoreTypes.ProjectRouting option
    }

        with
        static member ToRequest(req: CountRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_count"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

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
        member _.Index(state: CountRequest, value: CoreTypes.Indices) =
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
        member _.DefaultOperator(state: CountRequest, value: CoreTypes.Operator) =
            { state with DefaultOperator = Some value }

        [<CustomOperation("df")>]
        member _.Df(state: CountRequest, value: string) =
            { state with Df = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: CountRequest, value: CoreTypes.ExpandWildcards) =
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
        member _.MinScore(state: CountRequest, value: CoreTypes.Double) =
            { state with MinScore = Some value }

        [<CustomOperation("preference")>]
        member _.Preference(state: CountRequest, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: CountRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("terminateAfter")>]
        member _.TerminateAfter(state: CountRequest, value: CoreTypes.Long) =
            { state with TerminateAfter = Some value }

        [<CustomOperation("q")>]
        member _.Q(state: CountRequest, value: string) =
            { state with Q = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: CountRequest, value: CoreTypes.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: CountRequest, value: CoreTypes.ProjectRouting) =
            { state with ProjectRouting = Some value }

    let countRequest = CountRequestBuilder()

    module Count =
        let withAllowNoIndices (value: bool) (req: CountRequest) =
            { req with AllowNoIndices = Some value }
        let withAnalyzer (value: string) (req: CountRequest) =
            { req with Analyzer = Some value }
        let withAnalyzeWildcard (value: bool) (req: CountRequest) =
            { req with AnalyzeWildcard = Some value }
        let withDefaultOperator (value: CoreTypes.Operator) (req: CountRequest) =
            { req with DefaultOperator = Some value }
        let withDf (value: string) (req: CountRequest) =
            { req with Df = Some value }
        let withExpandWildcards (value: CoreTypes.ExpandWildcards) (req: CountRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreThrottled (value: bool) (req: CountRequest) =
            { req with IgnoreThrottled = Some value }
        let withIgnoreUnavailable (value: bool) (req: CountRequest) =
            { req with IgnoreUnavailable = Some value }
        let withLenient (value: bool) (req: CountRequest) =
            { req with Lenient = Some value }
        let withMinScore (value: CoreTypes.Double) (req: CountRequest) =
            { req with MinScore = Some value }
        let withPreference (value: string) (req: CountRequest) =
            { req with Preference = Some value }
        let withRouting (value: CoreTypes.Routing) (req: CountRequest) =
            { req with Routing = Some value }
        let withTerminateAfter (value: CoreTypes.Long) (req: CountRequest) =
            { req with TerminateAfter = Some value }
        let withQ (value: string) (req: CountRequest) =
            { req with Q = Some value }
        let withQuery (value: CoreTypes.QueryContainer) (req: CountRequest) =
            { req with Query = Some value }
        let withProjectRouting (value: CoreTypes.ProjectRouting) (req: CountRequest) =
            { req with ProjectRouting = Some value }

    type CreateRequest = {
        Id: CoreTypes.Id
        Index: CoreTypes.IndexName
        IncludeSourceOnError: bool option
        Pipeline: string option
        Refresh: CoreTypes.Refresh option
        RequireAlias: bool option
        RequireDataStream: bool option
        Routing: CoreTypes.Routing option
        Timeout: CoreTypes.Duration option
        Version: CoreTypes.VersionNumber option
        VersionType: CoreTypes.VersionType option
        WaitForActiveShards: CoreTypes.WaitForActiveShards option
        Document: obj
    }

        with
        static member ToRequest(req: CreateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_create/{req.Id}"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type CreateResponse = CoreTypes.WriteResponseBase

    type CreateRequestBuilder() =
        member _.Yield(_: unit) : CreateRequest =
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
        member _.Id(state: CreateRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: CreateRequest, value: CoreTypes.IndexName) =
            { state with Index = value }

        [<CustomOperation("includeSourceOnError")>]
        member _.IncludeSourceOnError(state: CreateRequest, value: bool) =
            { state with IncludeSourceOnError = Some value }

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: CreateRequest, value: string) =
            { state with Pipeline = Some value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: CreateRequest, value: CoreTypes.Refresh) =
            { state with Refresh = Some value }

        [<CustomOperation("requireAlias")>]
        member _.RequireAlias(state: CreateRequest, value: bool) =
            { state with RequireAlias = Some value }

        [<CustomOperation("requireDataStream")>]
        member _.RequireDataStream(state: CreateRequest, value: bool) =
            { state with RequireDataStream = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: CreateRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: CreateRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: CreateRequest, value: CoreTypes.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: CreateRequest, value: CoreTypes.VersionType) =
            { state with VersionType = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: CreateRequest, value: CoreTypes.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: CreateRequest, value) =
            { state with Document = value }

    let createRequest = CreateRequestBuilder()

    module Create =
        let withIncludeSourceOnError (value: bool) (req: CreateRequest) =
            { req with IncludeSourceOnError = Some value }
        let withPipeline (value: string) (req: CreateRequest) =
            { req with Pipeline = Some value }
        let withRefresh (value: CoreTypes.Refresh) (req: CreateRequest) =
            { req with Refresh = Some value }
        let withRequireAlias (value: bool) (req: CreateRequest) =
            { req with RequireAlias = Some value }
        let withRequireDataStream (value: bool) (req: CreateRequest) =
            { req with RequireDataStream = Some value }
        let withRouting (value: CoreTypes.Routing) (req: CreateRequest) =
            { req with Routing = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: CreateRequest) =
            { req with Timeout = Some value }
        let withVersion (value: CoreTypes.VersionNumber) (req: CreateRequest) =
            { req with Version = Some value }
        let withVersionType (value: CoreTypes.VersionType) (req: CreateRequest) =
            { req with VersionType = Some value }
        let withWaitForActiveShards (value: CoreTypes.WaitForActiveShards) (req: CreateRequest) =
            { req with WaitForActiveShards = Some value }

    type DeleteRequest = {
        Id: CoreTypes.Id
        Index: CoreTypes.IndexName
        IfPrimaryTerm: CoreTypes.Long option
        IfSeqNo: CoreTypes.SequenceNumber option
        Refresh: CoreTypes.Refresh option
        Routing: CoreTypes.Routing option
        Timeout: CoreTypes.Duration option
        Version: CoreTypes.VersionNumber option
        VersionType: CoreTypes.VersionType option
        WaitForActiveShards: CoreTypes.WaitForActiveShards option
    }

        with
        static member ToRequest(req: DeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_doc/{req.Id}"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type DeleteResponse = CoreTypes.WriteResponseBase

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
        member _.Id(state: DeleteRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: DeleteRequest, value: CoreTypes.IndexName) =
            { state with Index = value }

        [<CustomOperation("ifPrimaryTerm")>]
        member _.IfPrimaryTerm(state: DeleteRequest, value: CoreTypes.Long) =
            { state with IfPrimaryTerm = Some value }

        [<CustomOperation("ifSeqNo")>]
        member _.IfSeqNo(state: DeleteRequest, value: CoreTypes.SequenceNumber) =
            { state with IfSeqNo = Some value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: DeleteRequest, value: CoreTypes.Refresh) =
            { state with Refresh = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: DeleteRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: DeleteRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: DeleteRequest, value: CoreTypes.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: DeleteRequest, value: CoreTypes.VersionType) =
            { state with VersionType = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: DeleteRequest, value: CoreTypes.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

    let deleteRequest = DeleteRequestBuilder()

    module Delete =
        let withIfPrimaryTerm (value: CoreTypes.Long) (req: DeleteRequest) =
            { req with IfPrimaryTerm = Some value }
        let withIfSeqNo (value: CoreTypes.SequenceNumber) (req: DeleteRequest) =
            { req with IfSeqNo = Some value }
        let withRefresh (value: CoreTypes.Refresh) (req: DeleteRequest) =
            { req with Refresh = Some value }
        let withRouting (value: CoreTypes.Routing) (req: DeleteRequest) =
            { req with Routing = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: DeleteRequest) =
            { req with Timeout = Some value }
        let withVersion (value: CoreTypes.VersionNumber) (req: DeleteRequest) =
            { req with Version = Some value }
        let withVersionType (value: CoreTypes.VersionType) (req: DeleteRequest) =
            { req with VersionType = Some value }
        let withWaitForActiveShards (value: CoreTypes.WaitForActiveShards) (req: DeleteRequest) =
            { req with WaitForActiveShards = Some value }

    type DeleteByQueryRequest = {
        Index: CoreTypes.Indices
        AllowNoIndices: bool option
        Analyzer: string option
        AnalyzeWildcard: bool option
        Conflicts: CoreTypes.Conflicts option
        DefaultOperator: CoreTypes.Operator option
        Df: string option
        ExpandWildcards: CoreTypes.ExpandWildcards option
        From: CoreTypes.Long option
        IgnoreUnavailable: bool option
        Lenient: bool option
        MaxDocs: CoreTypes.Long option
        Preference: string option
        Refresh: bool option
        RequestCache: bool option
        RequestsPerSecond: CoreTypes.Float option
        Routing: CoreTypes.Routing option
        Q: string option
        Scroll: CoreTypes.Duration option
        ScrollSize: CoreTypes.Long option
        SearchTimeout: CoreTypes.Duration option
        SearchType: CoreTypes.SearchType option
        Slices: CoreTypes.Slices option
        Sort: string list option
        Stats: string list option
        TerminateAfter: CoreTypes.Long option
        Timeout: CoreTypes.Duration option
        Version: bool option
        WaitForActiveShards: CoreTypes.WaitForActiveShards option
        WaitForCompletion: bool option
        MaxDocs: CoreTypes.Long option
        Query: CoreTypes.QueryContainer option
        Slice: CoreTypes.SlicedScroll option
        Sort: CoreTypes.Sort option
    }

        with
        static member ToRequest(req: DeleteByQueryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_delete_by_query"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

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
                MaxDocs = None
                Query = None
                Slice = None
                Sort = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: DeleteByQueryRequest, value: CoreTypes.Indices) =
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
        member _.Conflicts(state: DeleteByQueryRequest, value: CoreTypes.Conflicts) =
            { state with Conflicts = Some value }

        [<CustomOperation("defaultOperator")>]
        member _.DefaultOperator(state: DeleteByQueryRequest, value: CoreTypes.Operator) =
            { state with DefaultOperator = Some value }

        [<CustomOperation("df")>]
        member _.Df(state: DeleteByQueryRequest, value: string) =
            { state with Df = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: DeleteByQueryRequest, value: CoreTypes.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("from")>]
        member _.From(state: DeleteByQueryRequest, value: CoreTypes.Long) =
            { state with From = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: DeleteByQueryRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("lenient")>]
        member _.Lenient(state: DeleteByQueryRequest, value: bool) =
            { state with Lenient = Some value }

        [<CustomOperation("maxDocs")>]
        member _.MaxDocs(state: DeleteByQueryRequest, value: CoreTypes.Long) =
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
        member _.RequestsPerSecond(state: DeleteByQueryRequest, value: CoreTypes.Float) =
            { state with RequestsPerSecond = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: DeleteByQueryRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("q")>]
        member _.Q(state: DeleteByQueryRequest, value: string) =
            { state with Q = Some value }

        [<CustomOperation("scroll")>]
        member _.Scroll(state: DeleteByQueryRequest, value: CoreTypes.Duration) =
            { state with Scroll = Some value }

        [<CustomOperation("scrollSize")>]
        member _.ScrollSize(state: DeleteByQueryRequest, value: CoreTypes.Long) =
            { state with ScrollSize = Some value }

        [<CustomOperation("searchTimeout")>]
        member _.SearchTimeout(state: DeleteByQueryRequest, value: CoreTypes.Duration) =
            { state with SearchTimeout = Some value }

        [<CustomOperation("searchType")>]
        member _.SearchType(state: DeleteByQueryRequest, value: CoreTypes.SearchType) =
            { state with SearchType = Some value }

        [<CustomOperation("slices")>]
        member _.Slices(state: DeleteByQueryRequest, value: CoreTypes.Slices) =
            { state with Slices = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: DeleteByQueryRequest, value: string list) =
            { state with Sort = Some value }

        [<CustomOperation("stats")>]
        member _.Stats(state: DeleteByQueryRequest, value: string list) =
            { state with Stats = Some value }

        [<CustomOperation("terminateAfter")>]
        member _.TerminateAfter(state: DeleteByQueryRequest, value: CoreTypes.Long) =
            { state with TerminateAfter = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: DeleteByQueryRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: DeleteByQueryRequest, value: bool) =
            { state with Version = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: DeleteByQueryRequest, value: CoreTypes.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: DeleteByQueryRequest, value: bool) =
            { state with WaitForCompletion = Some value }

        [<CustomOperation("maxDocs")>]
        member _.MaxDocs(state: DeleteByQueryRequest, value: CoreTypes.Long) =
            { state with MaxDocs = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: DeleteByQueryRequest, value: CoreTypes.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("slice")>]
        member _.Slice(state: DeleteByQueryRequest, value: CoreTypes.SlicedScroll) =
            { state with Slice = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: DeleteByQueryRequest, value: CoreTypes.Sort) =
            { state with Sort = Some value }

    let deleteByQueryRequest = DeleteByQueryRequestBuilder()

    module DeleteByQuery =
        let withAllowNoIndices (value: bool) (req: DeleteByQueryRequest) =
            { req with AllowNoIndices = Some value }
        let withAnalyzer (value: string) (req: DeleteByQueryRequest) =
            { req with Analyzer = Some value }
        let withAnalyzeWildcard (value: bool) (req: DeleteByQueryRequest) =
            { req with AnalyzeWildcard = Some value }
        let withConflicts (value: CoreTypes.Conflicts) (req: DeleteByQueryRequest) =
            { req with Conflicts = Some value }
        let withDefaultOperator (value: CoreTypes.Operator) (req: DeleteByQueryRequest) =
            { req with DefaultOperator = Some value }
        let withDf (value: string) (req: DeleteByQueryRequest) =
            { req with Df = Some value }
        let withExpandWildcards (value: CoreTypes.ExpandWildcards) (req: DeleteByQueryRequest) =
            { req with ExpandWildcards = Some value }
        let withFrom (value: CoreTypes.Long) (req: DeleteByQueryRequest) =
            { req with From = Some value }
        let withIgnoreUnavailable (value: bool) (req: DeleteByQueryRequest) =
            { req with IgnoreUnavailable = Some value }
        let withLenient (value: bool) (req: DeleteByQueryRequest) =
            { req with Lenient = Some value }
        let withMaxDocs (value: CoreTypes.Long) (req: DeleteByQueryRequest) =
            { req with MaxDocs = Some value }
        let withPreference (value: string) (req: DeleteByQueryRequest) =
            { req with Preference = Some value }
        let withRefresh (value: bool) (req: DeleteByQueryRequest) =
            { req with Refresh = Some value }
        let withRequestCache (value: bool) (req: DeleteByQueryRequest) =
            { req with RequestCache = Some value }
        let withRequestsPerSecond (value: CoreTypes.Float) (req: DeleteByQueryRequest) =
            { req with RequestsPerSecond = Some value }
        let withRouting (value: CoreTypes.Routing) (req: DeleteByQueryRequest) =
            { req with Routing = Some value }
        let withQ (value: string) (req: DeleteByQueryRequest) =
            { req with Q = Some value }
        let withScroll (value: CoreTypes.Duration) (req: DeleteByQueryRequest) =
            { req with Scroll = Some value }
        let withScrollSize (value: CoreTypes.Long) (req: DeleteByQueryRequest) =
            { req with ScrollSize = Some value }
        let withSearchTimeout (value: CoreTypes.Duration) (req: DeleteByQueryRequest) =
            { req with SearchTimeout = Some value }
        let withSearchType (value: CoreTypes.SearchType) (req: DeleteByQueryRequest) =
            { req with SearchType = Some value }
        let withSlices (value: CoreTypes.Slices) (req: DeleteByQueryRequest) =
            { req with Slices = Some value }
        let withSort (value: string list) (req: DeleteByQueryRequest) =
            { req with Sort = Some value }
        let withStats (value: string list) (req: DeleteByQueryRequest) =
            { req with Stats = Some value }
        let withTerminateAfter (value: CoreTypes.Long) (req: DeleteByQueryRequest) =
            { req with TerminateAfter = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: DeleteByQueryRequest) =
            { req with Timeout = Some value }
        let withVersion (value: bool) (req: DeleteByQueryRequest) =
            { req with Version = Some value }
        let withWaitForActiveShards (value: CoreTypes.WaitForActiveShards) (req: DeleteByQueryRequest) =
            { req with WaitForActiveShards = Some value }
        let withWaitForCompletion (value: bool) (req: DeleteByQueryRequest) =
            { req with WaitForCompletion = Some value }
        let withMaxDocs (value: CoreTypes.Long) (req: DeleteByQueryRequest) =
            { req with MaxDocs = Some value }
        let withQuery (value: CoreTypes.QueryContainer) (req: DeleteByQueryRequest) =
            { req with Query = Some value }
        let withSlice (value: CoreTypes.SlicedScroll) (req: DeleteByQueryRequest) =
            { req with Slice = Some value }
        let withSort (value: CoreTypes.Sort) (req: DeleteByQueryRequest) =
            { req with Sort = Some value }

    type DeleteByQueryRethrottleRequest = {
        TaskId: CoreTypes.TaskId
        RequestsPerSecond: CoreTypes.Float
    }

        with
        static member ToRequest(req: DeleteByQueryRethrottleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_delete_by_query/{req.TaskId}/_rethrottle"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type DeleteByQueryRethrottleResponse = TasksTypes.TaskListResponseBase

    type DeleteByQueryRethrottleRequestBuilder() =
        member _.Yield(_: unit) : DeleteByQueryRethrottleRequest =
            {
                TaskId = Unchecked.defaultof<_>
                RequestsPerSecond = Unchecked.defaultof<_>
            }

        [<CustomOperation("taskId")>]
        member _.TaskId(state: DeleteByQueryRethrottleRequest, value: CoreTypes.TaskId) =
            { state with TaskId = value }

        [<CustomOperation("requestsPerSecond")>]
        member _.RequestsPerSecond(state: DeleteByQueryRethrottleRequest, value: CoreTypes.Float) =
            { state with RequestsPerSecond = value }

    let deleteByQueryRethrottleRequest = DeleteByQueryRethrottleRequestBuilder()

    module DeleteByQueryRethrottle =
        let withRequestsPerSecond (value: CoreTypes.Float) (req: DeleteByQueryRethrottleRequest) =
            { req with RequestsPerSecond = value }

    type DeleteScriptRequest = {
        Id: CoreTypes.Id
        MasterTimeout: CoreTypes.Duration option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: DeleteScriptRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_scripts/{req.Id}"
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

    type DeleteScriptResponse = CoreTypes.AcknowledgedResponseBase

    type DeleteScriptRequestBuilder() =
        member _.Yield(_: unit) : DeleteScriptRequest =
            {
                Id = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: DeleteScriptRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: DeleteScriptRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: DeleteScriptRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let deleteScriptRequest = DeleteScriptRequestBuilder()

    module DeleteScript =
        let withMasterTimeout (value: CoreTypes.Duration) (req: DeleteScriptRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: DeleteScriptRequest) =
            { req with Timeout = Some value }

    type ExistsRequest = {
        Id: CoreTypes.Id
        Index: CoreTypes.IndexName
        Preference: string option
        Realtime: bool option
        Refresh: bool option
        Routing: CoreTypes.Routing option
        Source: GlobalSearchTypes.SourceConfigParam option
        SourceExcludes: CoreTypes.Fields option
        SourceIncludes: CoreTypes.Fields option
        StoredFields: CoreTypes.Fields option
        Version: CoreTypes.VersionNumber option
        VersionType: CoreTypes.VersionType option
    }

        with
        static member ToRequest(req: ExistsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_doc/{req.Id}"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Head
                |> Result.Ok
            with ex -> Result.Error ex

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
        member _.Id(state: ExistsRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: ExistsRequest, value: CoreTypes.IndexName) =
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
        member _.Routing(state: ExistsRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: ExistsRequest, value: GlobalSearchTypes.SourceConfigParam) =
            { state with Source = Some value }

        [<CustomOperation("sourceExcludes")>]
        member _.SourceExcludes(state: ExistsRequest, value: CoreTypes.Fields) =
            { state with SourceExcludes = Some value }

        [<CustomOperation("sourceIncludes")>]
        member _.SourceIncludes(state: ExistsRequest, value: CoreTypes.Fields) =
            { state with SourceIncludes = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: ExistsRequest, value: CoreTypes.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: ExistsRequest, value: CoreTypes.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: ExistsRequest, value: CoreTypes.VersionType) =
            { state with VersionType = Some value }

    let existsRequest = ExistsRequestBuilder()

    module Exists =
        let withPreference (value: string) (req: ExistsRequest) =
            { req with Preference = Some value }
        let withRealtime (value: bool) (req: ExistsRequest) =
            { req with Realtime = Some value }
        let withRefresh (value: bool) (req: ExistsRequest) =
            { req with Refresh = Some value }
        let withRouting (value: CoreTypes.Routing) (req: ExistsRequest) =
            { req with Routing = Some value }
        let withSource (value: GlobalSearchTypes.SourceConfigParam) (req: ExistsRequest) =
            { req with Source = Some value }
        let withSourceExcludes (value: CoreTypes.Fields) (req: ExistsRequest) =
            { req with SourceExcludes = Some value }
        let withSourceIncludes (value: CoreTypes.Fields) (req: ExistsRequest) =
            { req with SourceIncludes = Some value }
        let withStoredFields (value: CoreTypes.Fields) (req: ExistsRequest) =
            { req with StoredFields = Some value }
        let withVersion (value: CoreTypes.VersionNumber) (req: ExistsRequest) =
            { req with Version = Some value }
        let withVersionType (value: CoreTypes.VersionType) (req: ExistsRequest) =
            { req with VersionType = Some value }

    type ExistsSourceRequest = {
        Id: CoreTypes.Id
        Index: CoreTypes.IndexName
        Preference: string option
        Realtime: bool option
        Refresh: bool option
        Routing: CoreTypes.Routing option
        Source: GlobalSearchTypes.SourceConfigParam option
        SourceExcludes: CoreTypes.Fields option
        SourceIncludes: CoreTypes.Fields option
        Version: CoreTypes.VersionNumber option
        VersionType: CoreTypes.VersionType option
    }

        with
        static member ToRequest(req: ExistsSourceRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_source/{req.Id}"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Head
                |> Result.Ok
            with ex -> Result.Error ex

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
        member _.Id(state: ExistsSourceRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: ExistsSourceRequest, value: CoreTypes.IndexName) =
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
        member _.Routing(state: ExistsSourceRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: ExistsSourceRequest, value: GlobalSearchTypes.SourceConfigParam) =
            { state with Source = Some value }

        [<CustomOperation("sourceExcludes")>]
        member _.SourceExcludes(state: ExistsSourceRequest, value: CoreTypes.Fields) =
            { state with SourceExcludes = Some value }

        [<CustomOperation("sourceIncludes")>]
        member _.SourceIncludes(state: ExistsSourceRequest, value: CoreTypes.Fields) =
            { state with SourceIncludes = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: ExistsSourceRequest, value: CoreTypes.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: ExistsSourceRequest, value: CoreTypes.VersionType) =
            { state with VersionType = Some value }

    let existsSourceRequest = ExistsSourceRequestBuilder()

    module ExistsSource =
        let withPreference (value: string) (req: ExistsSourceRequest) =
            { req with Preference = Some value }
        let withRealtime (value: bool) (req: ExistsSourceRequest) =
            { req with Realtime = Some value }
        let withRefresh (value: bool) (req: ExistsSourceRequest) =
            { req with Refresh = Some value }
        let withRouting (value: CoreTypes.Routing) (req: ExistsSourceRequest) =
            { req with Routing = Some value }
        let withSource (value: GlobalSearchTypes.SourceConfigParam) (req: ExistsSourceRequest) =
            { req with Source = Some value }
        let withSourceExcludes (value: CoreTypes.Fields) (req: ExistsSourceRequest) =
            { req with SourceExcludes = Some value }
        let withSourceIncludes (value: CoreTypes.Fields) (req: ExistsSourceRequest) =
            { req with SourceIncludes = Some value }
        let withVersion (value: CoreTypes.VersionNumber) (req: ExistsSourceRequest) =
            { req with Version = Some value }
        let withVersionType (value: CoreTypes.VersionType) (req: ExistsSourceRequest) =
            { req with VersionType = Some value }

    type ExplainRequest = {
        Id: CoreTypes.Id
        Index: CoreTypes.IndexName
        Analyzer: string option
        AnalyzeWildcard: bool option
        DefaultOperator: CoreTypes.Operator option
        Df: string option
        Lenient: bool option
        Preference: string option
        Routing: CoreTypes.Routing option
        Source: GlobalSearchTypes.SourceConfigParam option
        SourceExcludes: CoreTypes.Fields option
        SourceIncludes: CoreTypes.Fields option
        StoredFields: CoreTypes.Fields option
        Q: string option
        Query: CoreTypes.QueryContainer option
    }

        with
        static member ToRequest(req: ExplainRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_explain/{req.Id}"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

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
        member _.Id(state: ExplainRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: ExplainRequest, value: CoreTypes.IndexName) =
            { state with Index = value }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: ExplainRequest, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("analyzeWildcard")>]
        member _.AnalyzeWildcard(state: ExplainRequest, value: bool) =
            { state with AnalyzeWildcard = Some value }

        [<CustomOperation("defaultOperator")>]
        member _.DefaultOperator(state: ExplainRequest, value: CoreTypes.Operator) =
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
        member _.Routing(state: ExplainRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: ExplainRequest, value: GlobalSearchTypes.SourceConfigParam) =
            { state with Source = Some value }

        [<CustomOperation("sourceExcludes")>]
        member _.SourceExcludes(state: ExplainRequest, value: CoreTypes.Fields) =
            { state with SourceExcludes = Some value }

        [<CustomOperation("sourceIncludes")>]
        member _.SourceIncludes(state: ExplainRequest, value: CoreTypes.Fields) =
            { state with SourceIncludes = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: ExplainRequest, value: CoreTypes.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("q")>]
        member _.Q(state: ExplainRequest, value: string) =
            { state with Q = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: ExplainRequest, value: CoreTypes.QueryContainer) =
            { state with Query = Some value }

    let explainRequest = ExplainRequestBuilder()

    module Explain =
        let withAnalyzer (value: string) (req: ExplainRequest) =
            { req with Analyzer = Some value }
        let withAnalyzeWildcard (value: bool) (req: ExplainRequest) =
            { req with AnalyzeWildcard = Some value }
        let withDefaultOperator (value: CoreTypes.Operator) (req: ExplainRequest) =
            { req with DefaultOperator = Some value }
        let withDf (value: string) (req: ExplainRequest) =
            { req with Df = Some value }
        let withLenient (value: bool) (req: ExplainRequest) =
            { req with Lenient = Some value }
        let withPreference (value: string) (req: ExplainRequest) =
            { req with Preference = Some value }
        let withRouting (value: CoreTypes.Routing) (req: ExplainRequest) =
            { req with Routing = Some value }
        let withSource (value: GlobalSearchTypes.SourceConfigParam) (req: ExplainRequest) =
            { req with Source = Some value }
        let withSourceExcludes (value: CoreTypes.Fields) (req: ExplainRequest) =
            { req with SourceExcludes = Some value }
        let withSourceIncludes (value: CoreTypes.Fields) (req: ExplainRequest) =
            { req with SourceIncludes = Some value }
        let withStoredFields (value: CoreTypes.Fields) (req: ExplainRequest) =
            { req with StoredFields = Some value }
        let withQ (value: string) (req: ExplainRequest) =
            { req with Q = Some value }
        let withQuery (value: CoreTypes.QueryContainer) (req: ExplainRequest) =
            { req with Query = Some value }

    type FieldCapsRequest = {
        Index: CoreTypes.Indices
        AllowNoIndices: bool option
        ExpandWildcards: CoreTypes.ExpandWildcards option
        Fields: CoreTypes.Fields option
        IgnoreUnavailable: bool option
        IncludeUnmapped: bool option
        Filters: System.Text.Json.JsonElement option
        Types: string list option
        IncludeEmptyFields: bool option
        Fields: CoreTypes.Fields option
        IndexFilter: CoreTypes.QueryContainer option
        RuntimeMappings: CoreTypes.RuntimeFields option
        ProjectRouting: CoreTypes.ProjectRouting option
    }

        with
        static member ToRequest(req: FieldCapsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_field_caps"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

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
                Fields = None
                IndexFilter = None
                RuntimeMappings = None
                ProjectRouting = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: FieldCapsRequest, value: CoreTypes.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: FieldCapsRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: FieldCapsRequest, value: CoreTypes.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: FieldCapsRequest, value: CoreTypes.Fields) =
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

        [<CustomOperation("fields")>]
        member _.Fields(state: FieldCapsRequest, value: CoreTypes.Fields) =
            { state with Fields = Some value }

        [<CustomOperation("indexFilter")>]
        member _.IndexFilter(state: FieldCapsRequest, value: CoreTypes.QueryContainer) =
            { state with IndexFilter = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: FieldCapsRequest, value: CoreTypes.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: FieldCapsRequest, value: CoreTypes.ProjectRouting) =
            { state with ProjectRouting = Some value }

    let fieldCapsRequest = FieldCapsRequestBuilder()

    module FieldCaps =
        let withAllowNoIndices (value: bool) (req: FieldCapsRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: CoreTypes.ExpandWildcards) (req: FieldCapsRequest) =
            { req with ExpandWildcards = Some value }
        let withFields (value: CoreTypes.Fields) (req: FieldCapsRequest) =
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
        let withFields (value: CoreTypes.Fields) (req: FieldCapsRequest) =
            { req with Fields = Some value }
        let withIndexFilter (value: CoreTypes.QueryContainer) (req: FieldCapsRequest) =
            { req with IndexFilter = Some value }
        let withRuntimeMappings (value: CoreTypes.RuntimeFields) (req: FieldCapsRequest) =
            { req with RuntimeMappings = Some value }
        let withProjectRouting (value: CoreTypes.ProjectRouting) (req: FieldCapsRequest) =
            { req with ProjectRouting = Some value }

    type GetRequest = {
        Id: CoreTypes.Id
        Index: CoreTypes.IndexName
        ForceSyntheticSource: bool option
        Preference: string option
        Realtime: bool option
        Refresh: bool option
        Routing: CoreTypes.Routing option
        Source: GlobalSearchTypes.SourceConfigParam option
        SourceExcludes: CoreTypes.Fields option
        SourceExcludeVectors: bool option
        SourceIncludes: CoreTypes.Fields option
        StoredFields: CoreTypes.Fields option
        Version: CoreTypes.VersionNumber option
        VersionType: CoreTypes.VersionType option
    }

        with
        static member ToRequest(req: GetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_doc/{req.Id}"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type GetResponse = GlobalGet.GetResult<GlobalGetResponse.TDocument>

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
        member _.Id(state: GetRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: GetRequest, value: CoreTypes.IndexName) =
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
        member _.Routing(state: GetRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: GetRequest, value: GlobalSearchTypes.SourceConfigParam) =
            { state with Source = Some value }

        [<CustomOperation("sourceExcludes")>]
        member _.SourceExcludes(state: GetRequest, value: CoreTypes.Fields) =
            { state with SourceExcludes = Some value }

        [<CustomOperation("sourceExcludeVectors")>]
        member _.SourceExcludeVectors(state: GetRequest, value: bool) =
            { state with SourceExcludeVectors = Some value }

        [<CustomOperation("sourceIncludes")>]
        member _.SourceIncludes(state: GetRequest, value: CoreTypes.Fields) =
            { state with SourceIncludes = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: GetRequest, value: CoreTypes.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: GetRequest, value: CoreTypes.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: GetRequest, value: CoreTypes.VersionType) =
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
        let withRouting (value: CoreTypes.Routing) (req: GetRequest) =
            { req with Routing = Some value }
        let withSource (value: GlobalSearchTypes.SourceConfigParam) (req: GetRequest) =
            { req with Source = Some value }
        let withSourceExcludes (value: CoreTypes.Fields) (req: GetRequest) =
            { req with SourceExcludes = Some value }
        let withSourceExcludeVectors (value: bool) (req: GetRequest) =
            { req with SourceExcludeVectors = Some value }
        let withSourceIncludes (value: CoreTypes.Fields) (req: GetRequest) =
            { req with SourceIncludes = Some value }
        let withStoredFields (value: CoreTypes.Fields) (req: GetRequest) =
            { req with StoredFields = Some value }
        let withVersion (value: CoreTypes.VersionNumber) (req: GetRequest) =
            { req with Version = Some value }
        let withVersionType (value: CoreTypes.VersionType) (req: GetRequest) =
            { req with VersionType = Some value }

    type GetScriptRequest = {
        Id: CoreTypes.Id
        MasterTimeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: GetScriptRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_scripts/{req.Id}"
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

    type GetScriptResponse = System.Text.Json.JsonElement

    type GetScriptRequestBuilder() =
        member _.Yield(_: unit) : GetScriptRequest =
            {
                Id = Unchecked.defaultof<_>
                MasterTimeout = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: GetScriptRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: GetScriptRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

    let getScriptRequest = GetScriptRequestBuilder()

    module GetScript =
        let withMasterTimeout (value: CoreTypes.Duration) (req: GetScriptRequest) =
            { req with MasterTimeout = Some value }

    type GetScriptContextRequest = | GetScriptContextRequest

        with
        static member ToRequest(req: GetScriptContextRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_script_context"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type GetScriptContextResponse = System.Text.Json.JsonElement

    type GetScriptContextRequestBuilder() =
        member _.Yield(_: unit) : GetScriptContextRequest =
            {
            }

    let getScriptContextRequest = GetScriptContextRequestBuilder()

    type GetScriptLanguagesRequest = | GetScriptLanguagesRequest

        with
        static member ToRequest(req: GetScriptLanguagesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_script_language"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type GetScriptLanguagesResponse = System.Text.Json.JsonElement

    type GetScriptLanguagesRequestBuilder() =
        member _.Yield(_: unit) : GetScriptLanguagesRequest =
            {
            }

    let getScriptLanguagesRequest = GetScriptLanguagesRequestBuilder()

    type GetSourceRequest = {
        Id: CoreTypes.Id
        Index: CoreTypes.IndexName
        Preference: string option
        Realtime: bool option
        Refresh: bool option
        Routing: CoreTypes.Routing option
        Source: GlobalSearchTypes.SourceConfigParam option
        SourceExcludes: CoreTypes.Fields option
        SourceIncludes: CoreTypes.Fields option
        Version: CoreTypes.VersionNumber option
        VersionType: CoreTypes.VersionType option
    }

        with
        static member ToRequest(req: GetSourceRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_source/{req.Id}"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type GetSourceResponse = GlobalGetSourceResponse.TDocument

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
        member _.Id(state: GetSourceRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: GetSourceRequest, value: CoreTypes.IndexName) =
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
        member _.Routing(state: GetSourceRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: GetSourceRequest, value: GlobalSearchTypes.SourceConfigParam) =
            { state with Source = Some value }

        [<CustomOperation("sourceExcludes")>]
        member _.SourceExcludes(state: GetSourceRequest, value: CoreTypes.Fields) =
            { state with SourceExcludes = Some value }

        [<CustomOperation("sourceIncludes")>]
        member _.SourceIncludes(state: GetSourceRequest, value: CoreTypes.Fields) =
            { state with SourceIncludes = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: GetSourceRequest, value: CoreTypes.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: GetSourceRequest, value: CoreTypes.VersionType) =
            { state with VersionType = Some value }

    let getSourceRequest = GetSourceRequestBuilder()

    module GetSource =
        let withPreference (value: string) (req: GetSourceRequest) =
            { req with Preference = Some value }
        let withRealtime (value: bool) (req: GetSourceRequest) =
            { req with Realtime = Some value }
        let withRefresh (value: bool) (req: GetSourceRequest) =
            { req with Refresh = Some value }
        let withRouting (value: CoreTypes.Routing) (req: GetSourceRequest) =
            { req with Routing = Some value }
        let withSource (value: GlobalSearchTypes.SourceConfigParam) (req: GetSourceRequest) =
            { req with Source = Some value }
        let withSourceExcludes (value: CoreTypes.Fields) (req: GetSourceRequest) =
            { req with SourceExcludes = Some value }
        let withSourceIncludes (value: CoreTypes.Fields) (req: GetSourceRequest) =
            { req with SourceIncludes = Some value }
        let withVersion (value: CoreTypes.VersionNumber) (req: GetSourceRequest) =
            { req with Version = Some value }
        let withVersionType (value: CoreTypes.VersionType) (req: GetSourceRequest) =
            { req with VersionType = Some value }

    type HealthReportRequest = {
        Feature: System.Text.Json.JsonElement
        Timeout: CoreTypes.Duration option
        Verbose: bool option
        Size: CoreTypes.Integer option
    }

        with
        static member ToRequest(req: HealthReportRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_health_report/{req.Feature}"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

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
        member _.Timeout(state: HealthReportRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("verbose")>]
        member _.Verbose(state: HealthReportRequest, value: bool) =
            { state with Verbose = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: HealthReportRequest, value: CoreTypes.Integer) =
            { state with Size = Some value }

    let healthReportRequest = HealthReportRequestBuilder()

    module HealthReport =
        let withTimeout (value: CoreTypes.Duration) (req: HealthReportRequest) =
            { req with Timeout = Some value }
        let withVerbose (value: bool) (req: HealthReportRequest) =
            { req with Verbose = Some value }
        let withSize (value: CoreTypes.Integer) (req: HealthReportRequest) =
            { req with Size = Some value }

    type IndexRequest = {
        Id: CoreTypes.Id
        Index: CoreTypes.IndexName
        IfPrimaryTerm: CoreTypes.Long option
        IfSeqNo: CoreTypes.SequenceNumber option
        IncludeSourceOnError: bool option
        OpType: CoreTypes.OpType option
        Pipeline: string option
        Refresh: CoreTypes.Refresh option
        Routing: CoreTypes.Routing option
        Timeout: CoreTypes.Duration option
        Version: CoreTypes.VersionNumber option
        VersionType: CoreTypes.VersionType option
        WaitForActiveShards: CoreTypes.WaitForActiveShards option
        RequireAlias: bool option
        RequireDataStream: bool option
        Document: obj
    }

        with
        static member ToRequest(req: IndexRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_doc/{req.Id}"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type IndexResponse = CoreTypes.WriteResponseBase

    type IndexRequestBuilder() =
        member _.Yield(_: unit) : IndexRequest =
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
        member _.Id(state: IndexRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: IndexRequest, value: CoreTypes.IndexName) =
            { state with Index = value }

        [<CustomOperation("ifPrimaryTerm")>]
        member _.IfPrimaryTerm(state: IndexRequest, value: CoreTypes.Long) =
            { state with IfPrimaryTerm = Some value }

        [<CustomOperation("ifSeqNo")>]
        member _.IfSeqNo(state: IndexRequest, value: CoreTypes.SequenceNumber) =
            { state with IfSeqNo = Some value }

        [<CustomOperation("includeSourceOnError")>]
        member _.IncludeSourceOnError(state: IndexRequest, value: bool) =
            { state with IncludeSourceOnError = Some value }

        [<CustomOperation("opType")>]
        member _.OpType(state: IndexRequest, value: CoreTypes.OpType) =
            { state with OpType = Some value }

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: IndexRequest, value: string) =
            { state with Pipeline = Some value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: IndexRequest, value: CoreTypes.Refresh) =
            { state with Refresh = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: IndexRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndexRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: IndexRequest, value: CoreTypes.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: IndexRequest, value: CoreTypes.VersionType) =
            { state with VersionType = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: IndexRequest, value: CoreTypes.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

        [<CustomOperation("requireAlias")>]
        member _.RequireAlias(state: IndexRequest, value: bool) =
            { state with RequireAlias = Some value }

        [<CustomOperation("requireDataStream")>]
        member _.RequireDataStream(state: IndexRequest, value: bool) =
            { state with RequireDataStream = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: IndexRequest, value) =
            { state with Document = value }

    let indexRequest = IndexRequestBuilder()

    module Index =
        let withIfPrimaryTerm (value: CoreTypes.Long) (req: IndexRequest) =
            { req with IfPrimaryTerm = Some value }
        let withIfSeqNo (value: CoreTypes.SequenceNumber) (req: IndexRequest) =
            { req with IfSeqNo = Some value }
        let withIncludeSourceOnError (value: bool) (req: IndexRequest) =
            { req with IncludeSourceOnError = Some value }
        let withOpType (value: CoreTypes.OpType) (req: IndexRequest) =
            { req with OpType = Some value }
        let withPipeline (value: string) (req: IndexRequest) =
            { req with Pipeline = Some value }
        let withRefresh (value: CoreTypes.Refresh) (req: IndexRequest) =
            { req with Refresh = Some value }
        let withRouting (value: CoreTypes.Routing) (req: IndexRequest) =
            { req with Routing = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: IndexRequest) =
            { req with Timeout = Some value }
        let withVersion (value: CoreTypes.VersionNumber) (req: IndexRequest) =
            { req with Version = Some value }
        let withVersionType (value: CoreTypes.VersionType) (req: IndexRequest) =
            { req with VersionType = Some value }
        let withWaitForActiveShards (value: CoreTypes.WaitForActiveShards) (req: IndexRequest) =
            { req with WaitForActiveShards = Some value }
        let withRequireAlias (value: bool) (req: IndexRequest) =
            { req with RequireAlias = Some value }
        let withRequireDataStream (value: bool) (req: IndexRequest) =
            { req with RequireDataStream = Some value }

    type InfoRequest = | InfoRequest

        with
        static member ToRequest(req: InfoRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type InfoResponse = System.Text.Json.JsonElement

    type InfoRequestBuilder() =
        member _.Yield(_: unit) : InfoRequest =
            {
            }

    let infoRequest = InfoRequestBuilder()

    type KnnSearchRequest = {
        Index: CoreTypes.Indices
        Routing: CoreTypes.Routing option
        Source: GlobalSearchTypes.SourceConfig option
        DocvalueFields: CoreTypes.FieldAndFormat list option
        StoredFields: CoreTypes.Fields option
        Fields: CoreTypes.Fields option
        Filter: System.Text.Json.JsonElement option
        Knn: GlobalKnnSearchTypes.KnnSearchQuery
    }

        with
        static member ToRequest(req: KnnSearchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_knn_search"
                let queryParams =
                    [
                        req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
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
        member _.Index(state: KnnSearchRequest, value: CoreTypes.Indices) =
            { state with Index = value }

        [<CustomOperation("routing")>]
        member _.Routing(state: KnnSearchRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: KnnSearchRequest, value: GlobalSearchTypes.SourceConfig) =
            { state with Source = Some value }

        [<CustomOperation("docvalueFields")>]
        member _.DocvalueFields(state: KnnSearchRequest, value: CoreTypes.FieldAndFormat list) =
            { state with DocvalueFields = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: KnnSearchRequest, value: CoreTypes.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: KnnSearchRequest, value: CoreTypes.Fields) =
            { state with Fields = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: KnnSearchRequest, value: System.Text.Json.JsonElement) =
            { state with Filter = Some value }

        [<CustomOperation("knn")>]
        member _.Knn(state: KnnSearchRequest, value: GlobalKnnSearchTypes.KnnSearchQuery) =
            { state with Knn = value }

    let knnSearchRequest = KnnSearchRequestBuilder()

    module KnnSearch =
        let withRouting (value: CoreTypes.Routing) (req: KnnSearchRequest) =
            { req with Routing = Some value }
        let withSource (value: GlobalSearchTypes.SourceConfig) (req: KnnSearchRequest) =
            { req with Source = Some value }
        let withDocvalueFields (value: CoreTypes.FieldAndFormat list) (req: KnnSearchRequest) =
            { req with DocvalueFields = Some value }
        let withStoredFields (value: CoreTypes.Fields) (req: KnnSearchRequest) =
            { req with StoredFields = Some value }
        let withFields (value: CoreTypes.Fields) (req: KnnSearchRequest) =
            { req with Fields = Some value }
        let withFilter (value: System.Text.Json.JsonElement) (req: KnnSearchRequest) =
            { req with Filter = Some value }
        let withKnn (value: GlobalKnnSearchTypes.KnnSearchQuery) (req: KnnSearchRequest) =
            { req with Knn = value }

    type MgetRequest = {
        Index: CoreTypes.IndexName
        ForceSyntheticSource: bool option
        Preference: string option
        Realtime: bool option
        Refresh: bool option
        Routing: CoreTypes.Routing option
        Source: GlobalSearchTypes.SourceConfigParam option
        SourceExcludes: CoreTypes.Fields option
        SourceIncludes: CoreTypes.Fields option
        StoredFields: CoreTypes.Fields option
        Docs: GlobalMget.Operation list option
        Ids: CoreTypes.Ids option
    }

        with
        static member ToRequest(req: MgetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_mget"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

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
        member _.Index(state: MgetRequest, value: CoreTypes.IndexName) =
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
        member _.Routing(state: MgetRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: MgetRequest, value: GlobalSearchTypes.SourceConfigParam) =
            { state with Source = Some value }

        [<CustomOperation("sourceExcludes")>]
        member _.SourceExcludes(state: MgetRequest, value: CoreTypes.Fields) =
            { state with SourceExcludes = Some value }

        [<CustomOperation("sourceIncludes")>]
        member _.SourceIncludes(state: MgetRequest, value: CoreTypes.Fields) =
            { state with SourceIncludes = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: MgetRequest, value: CoreTypes.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("docs")>]
        member _.Docs(state: MgetRequest, value: GlobalMget.Operation list) =
            { state with Docs = Some value }

        [<CustomOperation("ids")>]
        member _.Ids(state: MgetRequest, value: CoreTypes.Ids) =
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
        let withRouting (value: CoreTypes.Routing) (req: MgetRequest) =
            { req with Routing = Some value }
        let withSource (value: GlobalSearchTypes.SourceConfigParam) (req: MgetRequest) =
            { req with Source = Some value }
        let withSourceExcludes (value: CoreTypes.Fields) (req: MgetRequest) =
            { req with SourceExcludes = Some value }
        let withSourceIncludes (value: CoreTypes.Fields) (req: MgetRequest) =
            { req with SourceIncludes = Some value }
        let withStoredFields (value: CoreTypes.Fields) (req: MgetRequest) =
            { req with StoredFields = Some value }
        let withDocs (value: GlobalMget.Operation list) (req: MgetRequest) =
            { req with Docs = Some value }
        let withIds (value: CoreTypes.Ids) (req: MgetRequest) =
            { req with Ids = Some value }

    type MsearchRequest = {
        Index: CoreTypes.Indices
        AllowNoIndices: bool option
        CcsMinimizeRoundtrips: bool option
        ExpandWildcards: CoreTypes.ExpandWildcards option
        IgnoreThrottled: bool option
        IgnoreUnavailable: bool option
        IncludeNamedQueriesScore: bool option
        Index: CoreTypes.Indices option
        MaxConcurrentSearches: CoreTypes.Integer option
        MaxConcurrentShardRequests: CoreTypes.Integer option
        PreFilterShardSize: CoreTypes.Long option
        ProjectRouting: CoreTypes.ProjectRouting option
        RestTotalHitsAsInt: bool option
        Routing: CoreTypes.Routing option
        SearchType: CoreTypes.SearchType option
        TypedKeys: bool option
        Document: obj
    }

        with
        static member ToRequest(req: MsearchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_msearch"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.CcsMinimizeRoundtrips |> Option.map (fun v -> "ccs_minimize_roundtrips", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.IgnoreThrottled |> Option.map (fun v -> "ignore_throttled", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.IncludeNamedQueriesScore |> Option.map (fun v -> "include_named_queries_score", Fes.Http.toQueryValue v)
                        req.Index |> Option.map (fun v -> "index", Fes.Http.toQueryValue v)
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type MsearchResponse = GlobalMsearch.MultiSearchResult<GlobalMsearchResponse.TDocument>

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
                Index = None
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
        member _.Index(state: MsearchRequest, value: CoreTypes.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: MsearchRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("ccsMinimizeRoundtrips")>]
        member _.CcsMinimizeRoundtrips(state: MsearchRequest, value: bool) =
            { state with CcsMinimizeRoundtrips = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: MsearchRequest, value: CoreTypes.ExpandWildcards) =
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

        [<CustomOperation("index")>]
        member _.Index(state: MsearchRequest, value: CoreTypes.Indices) =
            { state with Index = Some value }

        [<CustomOperation("maxConcurrentSearches")>]
        member _.MaxConcurrentSearches(state: MsearchRequest, value: CoreTypes.Integer) =
            { state with MaxConcurrentSearches = Some value }

        [<CustomOperation("maxConcurrentShardRequests")>]
        member _.MaxConcurrentShardRequests(state: MsearchRequest, value: CoreTypes.Integer) =
            { state with MaxConcurrentShardRequests = Some value }

        [<CustomOperation("preFilterShardSize")>]
        member _.PreFilterShardSize(state: MsearchRequest, value: CoreTypes.Long) =
            { state with PreFilterShardSize = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: MsearchRequest, value: CoreTypes.ProjectRouting) =
            { state with ProjectRouting = Some value }

        [<CustomOperation("restTotalHitsAsInt")>]
        member _.RestTotalHitsAsInt(state: MsearchRequest, value: bool) =
            { state with RestTotalHitsAsInt = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: MsearchRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("searchType")>]
        member _.SearchType(state: MsearchRequest, value: CoreTypes.SearchType) =
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
        let withExpandWildcards (value: CoreTypes.ExpandWildcards) (req: MsearchRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreThrottled (value: bool) (req: MsearchRequest) =
            { req with IgnoreThrottled = Some value }
        let withIgnoreUnavailable (value: bool) (req: MsearchRequest) =
            { req with IgnoreUnavailable = Some value }
        let withIncludeNamedQueriesScore (value: bool) (req: MsearchRequest) =
            { req with IncludeNamedQueriesScore = Some value }
        let withIndex (value: CoreTypes.Indices) (req: MsearchRequest) =
            { req with Index = Some value }
        let withMaxConcurrentSearches (value: CoreTypes.Integer) (req: MsearchRequest) =
            { req with MaxConcurrentSearches = Some value }
        let withMaxConcurrentShardRequests (value: CoreTypes.Integer) (req: MsearchRequest) =
            { req with MaxConcurrentShardRequests = Some value }
        let withPreFilterShardSize (value: CoreTypes.Long) (req: MsearchRequest) =
            { req with PreFilterShardSize = Some value }
        let withProjectRouting (value: CoreTypes.ProjectRouting) (req: MsearchRequest) =
            { req with ProjectRouting = Some value }
        let withRestTotalHitsAsInt (value: bool) (req: MsearchRequest) =
            { req with RestTotalHitsAsInt = Some value }
        let withRouting (value: CoreTypes.Routing) (req: MsearchRequest) =
            { req with Routing = Some value }
        let withSearchType (value: CoreTypes.SearchType) (req: MsearchRequest) =
            { req with SearchType = Some value }
        let withTypedKeys (value: bool) (req: MsearchRequest) =
            { req with TypedKeys = Some value }

    type MsearchTemplateRequest = {
        Index: CoreTypes.Indices
        CcsMinimizeRoundtrips: bool option
        MaxConcurrentSearches: CoreTypes.Long option
        ProjectRouting: CoreTypes.ProjectRouting option
        SearchType: CoreTypes.SearchType option
        RestTotalHitsAsInt: bool option
        TypedKeys: bool option
        Document: obj
    }

        with
        static member ToRequest(req: MsearchTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_msearch/template"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type MsearchTemplateResponse = GlobalMsearch.MultiSearchResult<GlobalMsearchTemplateResponse.TDocument>

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
        member _.Index(state: MsearchTemplateRequest, value: CoreTypes.Indices) =
            { state with Index = value }

        [<CustomOperation("ccsMinimizeRoundtrips")>]
        member _.CcsMinimizeRoundtrips(state: MsearchTemplateRequest, value: bool) =
            { state with CcsMinimizeRoundtrips = Some value }

        [<CustomOperation("maxConcurrentSearches")>]
        member _.MaxConcurrentSearches(state: MsearchTemplateRequest, value: CoreTypes.Long) =
            { state with MaxConcurrentSearches = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: MsearchTemplateRequest, value: CoreTypes.ProjectRouting) =
            { state with ProjectRouting = Some value }

        [<CustomOperation("searchType")>]
        member _.SearchType(state: MsearchTemplateRequest, value: CoreTypes.SearchType) =
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
        let withMaxConcurrentSearches (value: CoreTypes.Long) (req: MsearchTemplateRequest) =
            { req with MaxConcurrentSearches = Some value }
        let withProjectRouting (value: CoreTypes.ProjectRouting) (req: MsearchTemplateRequest) =
            { req with ProjectRouting = Some value }
        let withSearchType (value: CoreTypes.SearchType) (req: MsearchTemplateRequest) =
            { req with SearchType = Some value }
        let withRestTotalHitsAsInt (value: bool) (req: MsearchTemplateRequest) =
            { req with RestTotalHitsAsInt = Some value }
        let withTypedKeys (value: bool) (req: MsearchTemplateRequest) =
            { req with TypedKeys = Some value }

    type MtermvectorsRequest = {
        Index: CoreTypes.IndexName
        Ids: CoreTypes.Id list option
        Fields: CoreTypes.Fields option
        FieldStatistics: bool option
        Offsets: bool option
        Payloads: bool option
        Positions: bool option
        Preference: string option
        Realtime: bool option
        Routing: CoreTypes.Routing option
        TermStatistics: bool option
        Version: CoreTypes.VersionNumber option
        VersionType: CoreTypes.VersionType option
        Docs: GlobalMtermvectors.Operation list option
        Ids: CoreTypes.Id list option
    }

        with
        static member ToRequest(req: MtermvectorsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_mtermvectors"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

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
                Ids = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: MtermvectorsRequest, value: CoreTypes.IndexName) =
            { state with Index = value }

        [<CustomOperation("ids")>]
        member _.Ids(state: MtermvectorsRequest, value: CoreTypes.Id list) =
            { state with Ids = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: MtermvectorsRequest, value: CoreTypes.Fields) =
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
        member _.Routing(state: MtermvectorsRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("termStatistics")>]
        member _.TermStatistics(state: MtermvectorsRequest, value: bool) =
            { state with TermStatistics = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: MtermvectorsRequest, value: CoreTypes.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: MtermvectorsRequest, value: CoreTypes.VersionType) =
            { state with VersionType = Some value }

        [<CustomOperation("docs")>]
        member _.Docs(state: MtermvectorsRequest, value: GlobalMtermvectors.Operation list) =
            { state with Docs = Some value }

        [<CustomOperation("ids")>]
        member _.Ids(state: MtermvectorsRequest, value: CoreTypes.Id list) =
            { state with Ids = Some value }

    let mtermvectorsRequest = MtermvectorsRequestBuilder()

    module Mtermvectors =
        let withIds (value: CoreTypes.Id list) (req: MtermvectorsRequest) =
            { req with Ids = Some value }
        let withFields (value: CoreTypes.Fields) (req: MtermvectorsRequest) =
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
        let withRouting (value: CoreTypes.Routing) (req: MtermvectorsRequest) =
            { req with Routing = Some value }
        let withTermStatistics (value: bool) (req: MtermvectorsRequest) =
            { req with TermStatistics = Some value }
        let withVersion (value: CoreTypes.VersionNumber) (req: MtermvectorsRequest) =
            { req with Version = Some value }
        let withVersionType (value: CoreTypes.VersionType) (req: MtermvectorsRequest) =
            { req with VersionType = Some value }
        let withDocs (value: GlobalMtermvectors.Operation list) (req: MtermvectorsRequest) =
            { req with Docs = Some value }
        let withIds (value: CoreTypes.Id list) (req: MtermvectorsRequest) =
            { req with Ids = Some value }

    type OpenPointInTimeRequest = {
        Index: CoreTypes.Indices
        KeepAlive: CoreTypes.Duration
        IgnoreUnavailable: bool option
        Preference: string option
        Routing: CoreTypes.Routing option
        ExpandWildcards: CoreTypes.ExpandWildcards option
        AllowPartialSearchResults: bool option
        MaxConcurrentShardRequests: CoreTypes.Integer option
        IndexFilter: CoreTypes.QueryContainer option
        ProjectRouting: CoreTypes.ProjectRouting option
    }

        with
        static member ToRequest(req: OpenPointInTimeRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_pit"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

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
        member _.Index(state: OpenPointInTimeRequest, value: CoreTypes.Indices) =
            { state with Index = value }

        [<CustomOperation("keepAlive")>]
        member _.KeepAlive(state: OpenPointInTimeRequest, value: CoreTypes.Duration) =
            { state with KeepAlive = value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: OpenPointInTimeRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("preference")>]
        member _.Preference(state: OpenPointInTimeRequest, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: OpenPointInTimeRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: OpenPointInTimeRequest, value: CoreTypes.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("allowPartialSearchResults")>]
        member _.AllowPartialSearchResults(state: OpenPointInTimeRequest, value: bool) =
            { state with AllowPartialSearchResults = Some value }

        [<CustomOperation("maxConcurrentShardRequests")>]
        member _.MaxConcurrentShardRequests(state: OpenPointInTimeRequest, value: CoreTypes.Integer) =
            { state with MaxConcurrentShardRequests = Some value }

        [<CustomOperation("indexFilter")>]
        member _.IndexFilter(state: OpenPointInTimeRequest, value: CoreTypes.QueryContainer) =
            { state with IndexFilter = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: OpenPointInTimeRequest, value: CoreTypes.ProjectRouting) =
            { state with ProjectRouting = Some value }

    let openPointInTimeRequest = OpenPointInTimeRequestBuilder()

    module OpenPointInTime =
        let withKeepAlive (value: CoreTypes.Duration) (req: OpenPointInTimeRequest) =
            { req with KeepAlive = value }
        let withIgnoreUnavailable (value: bool) (req: OpenPointInTimeRequest) =
            { req with IgnoreUnavailable = Some value }
        let withPreference (value: string) (req: OpenPointInTimeRequest) =
            { req with Preference = Some value }
        let withRouting (value: CoreTypes.Routing) (req: OpenPointInTimeRequest) =
            { req with Routing = Some value }
        let withExpandWildcards (value: CoreTypes.ExpandWildcards) (req: OpenPointInTimeRequest) =
            { req with ExpandWildcards = Some value }
        let withAllowPartialSearchResults (value: bool) (req: OpenPointInTimeRequest) =
            { req with AllowPartialSearchResults = Some value }
        let withMaxConcurrentShardRequests (value: CoreTypes.Integer) (req: OpenPointInTimeRequest) =
            { req with MaxConcurrentShardRequests = Some value }
        let withIndexFilter (value: CoreTypes.QueryContainer) (req: OpenPointInTimeRequest) =
            { req with IndexFilter = Some value }
        let withProjectRouting (value: CoreTypes.ProjectRouting) (req: OpenPointInTimeRequest) =
            { req with ProjectRouting = Some value }

    type PingRequest = | PingRequest

        with
        static member ToRequest(req: PingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Head
                |> Result.Ok
            with ex -> Result.Error ex

    type PingResponse = unit

    type PingRequestBuilder() =
        member _.Yield(_: unit) : PingRequest =
            {
            }

    let pingRequest = PingRequestBuilder()

    type PutScriptRequest = {
        Id: CoreTypes.Id
        Context: CoreTypes.Name
        Context: CoreTypes.Name option
        MasterTimeout: CoreTypes.Duration option
        Timeout: CoreTypes.Duration option
        Script: CoreTypes.StoredScript
    }

        with
        static member ToRequest(req: PutScriptRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_scripts/{req.Id}/{req.Context}"
                let queryParams =
                    [
                        req.Context |> Option.map (fun v -> "context", Fes.Http.toQueryValue v)
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

    type PutScriptResponse = CoreTypes.AcknowledgedResponseBase

    type PutScriptRequestBuilder() =
        member _.Yield(_: unit) : PutScriptRequest =
            {
                Id = Unchecked.defaultof<_>
                Context = Unchecked.defaultof<_>
                Context = None
                MasterTimeout = None
                Timeout = None
                Script = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: PutScriptRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("context")>]
        member _.Context(state: PutScriptRequest, value: CoreTypes.Name) =
            { state with Context = value }

        [<CustomOperation("context")>]
        member _.Context(state: PutScriptRequest, value: CoreTypes.Name) =
            { state with Context = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: PutScriptRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: PutScriptRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: PutScriptRequest, value: CoreTypes.StoredScript) =
            { state with Script = value }

    let putScriptRequest = PutScriptRequestBuilder()

    module PutScript =
        let withContext (value: CoreTypes.Name) (req: PutScriptRequest) =
            { req with Context = Some value }
        let withMasterTimeout (value: CoreTypes.Duration) (req: PutScriptRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: PutScriptRequest) =
            { req with Timeout = Some value }
        let withScript (value: CoreTypes.StoredScript) (req: PutScriptRequest) =
            { req with Script = value }

    type RankEvalRequest = {
        Index: CoreTypes.Indices
        AllowNoIndices: bool option
        ExpandWildcards: CoreTypes.ExpandWildcards option
        IgnoreUnavailable: bool option
        SearchType: CoreTypes.SearchType option
        Requests: GlobalRankEval.RankEvalRequestItem list
        Metric: GlobalRankEval.RankEvalMetric option
    }

        with
        static member ToRequest(req: RankEvalRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_rank_eval"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

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
        member _.Index(state: RankEvalRequest, value: CoreTypes.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: RankEvalRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: RankEvalRequest, value: CoreTypes.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: RankEvalRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("searchType")>]
        member _.SearchType(state: RankEvalRequest, value: CoreTypes.SearchType) =
            { state with SearchType = Some value }

        [<CustomOperation("requests")>]
        member _.Requests(state: RankEvalRequest, value: GlobalRankEval.RankEvalRequestItem list) =
            { state with Requests = value }

        [<CustomOperation("metric")>]
        member _.Metric(state: RankEvalRequest, value: GlobalRankEval.RankEvalMetric) =
            { state with Metric = Some value }

    let rankEvalRequest = RankEvalRequestBuilder()

    module RankEval =
        let withAllowNoIndices (value: bool) (req: RankEvalRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: CoreTypes.ExpandWildcards) (req: RankEvalRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreUnavailable (value: bool) (req: RankEvalRequest) =
            { req with IgnoreUnavailable = Some value }
        let withSearchType (value: CoreTypes.SearchType) (req: RankEvalRequest) =
            { req with SearchType = Some value }
        let withRequests (value: GlobalRankEval.RankEvalRequestItem list) (req: RankEvalRequest) =
            { req with Requests = value }
        let withMetric (value: GlobalRankEval.RankEvalMetric) (req: RankEvalRequest) =
            { req with Metric = Some value }

    type ReindexRequest = {
        Refresh: bool option
        RequestsPerSecond: CoreTypes.Float option
        Scroll: CoreTypes.Duration option
        Slices: CoreTypes.Slices option
        MaxDocs: CoreTypes.Integer option
        Timeout: CoreTypes.Duration option
        WaitForActiveShards: CoreTypes.WaitForActiveShards option
        WaitForCompletion: bool option
        RequireAlias: bool option
        Conflicts: CoreTypes.Conflicts option
        Dest: GlobalReindex.Destination
        MaxDocs: CoreTypes.Long option
        Script: CoreTypes.Script option
        Source: GlobalReindex.Source
    }

        with
        static member ToRequest(req: ReindexRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

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
                MaxDocs = None
                Script = None
                Source = Unchecked.defaultof<_>
            }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: ReindexRequest, value: bool) =
            { state with Refresh = Some value }

        [<CustomOperation("requestsPerSecond")>]
        member _.RequestsPerSecond(state: ReindexRequest, value: CoreTypes.Float) =
            { state with RequestsPerSecond = Some value }

        [<CustomOperation("scroll")>]
        member _.Scroll(state: ReindexRequest, value: CoreTypes.Duration) =
            { state with Scroll = Some value }

        [<CustomOperation("slices")>]
        member _.Slices(state: ReindexRequest, value: CoreTypes.Slices) =
            { state with Slices = Some value }

        [<CustomOperation("maxDocs")>]
        member _.MaxDocs(state: ReindexRequest, value: CoreTypes.Integer) =
            { state with MaxDocs = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: ReindexRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: ReindexRequest, value: CoreTypes.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: ReindexRequest, value: bool) =
            { state with WaitForCompletion = Some value }

        [<CustomOperation("requireAlias")>]
        member _.RequireAlias(state: ReindexRequest, value: bool) =
            { state with RequireAlias = Some value }

        [<CustomOperation("conflicts")>]
        member _.Conflicts(state: ReindexRequest, value: CoreTypes.Conflicts) =
            { state with Conflicts = Some value }

        [<CustomOperation("dest")>]
        member _.Dest(state: ReindexRequest, value: GlobalReindex.Destination) =
            { state with Dest = value }

        [<CustomOperation("maxDocs")>]
        member _.MaxDocs(state: ReindexRequest, value: CoreTypes.Long) =
            { state with MaxDocs = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: ReindexRequest, value: CoreTypes.Script) =
            { state with Script = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: ReindexRequest, value: GlobalReindex.Source) =
            { state with Source = value }

    let reindexRequest = ReindexRequestBuilder()

    module Reindex =
        let withRefresh (value: bool) (req: ReindexRequest) =
            { req with Refresh = Some value }
        let withRequestsPerSecond (value: CoreTypes.Float) (req: ReindexRequest) =
            { req with RequestsPerSecond = Some value }
        let withScroll (value: CoreTypes.Duration) (req: ReindexRequest) =
            { req with Scroll = Some value }
        let withSlices (value: CoreTypes.Slices) (req: ReindexRequest) =
            { req with Slices = Some value }
        let withMaxDocs (value: CoreTypes.Integer) (req: ReindexRequest) =
            { req with MaxDocs = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: ReindexRequest) =
            { req with Timeout = Some value }
        let withWaitForActiveShards (value: CoreTypes.WaitForActiveShards) (req: ReindexRequest) =
            { req with WaitForActiveShards = Some value }
        let withWaitForCompletion (value: bool) (req: ReindexRequest) =
            { req with WaitForCompletion = Some value }
        let withRequireAlias (value: bool) (req: ReindexRequest) =
            { req with RequireAlias = Some value }
        let withConflicts (value: CoreTypes.Conflicts) (req: ReindexRequest) =
            { req with Conflicts = Some value }
        let withDest (value: GlobalReindex.Destination) (req: ReindexRequest) =
            { req with Dest = value }
        let withMaxDocs (value: CoreTypes.Long) (req: ReindexRequest) =
            { req with MaxDocs = Some value }
        let withScript (value: CoreTypes.Script) (req: ReindexRequest) =
            { req with Script = Some value }
        let withSource (value: GlobalReindex.Source) (req: ReindexRequest) =
            { req with Source = value }

    type ReindexRethrottleRequest = {
        TaskId: CoreTypes.Id
        RequestsPerSecond: CoreTypes.Float
        GroupBy: TasksTypes.GroupBy option
    }

        with
        static member ToRequest(req: ReindexRethrottleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_reindex/{req.TaskId}/_rethrottle"
                let queryParams =
                    [
                        req.GroupBy |> Option.map (fun v -> "group_by", Fes.Http.toQueryValue v)
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

    type ReindexRethrottleResponse = System.Text.Json.JsonElement

    type ReindexRethrottleRequestBuilder() =
        member _.Yield(_: unit) : ReindexRethrottleRequest =
            {
                TaskId = Unchecked.defaultof<_>
                RequestsPerSecond = Unchecked.defaultof<_>
                GroupBy = None
            }

        [<CustomOperation("taskId")>]
        member _.TaskId(state: ReindexRethrottleRequest, value: CoreTypes.Id) =
            { state with TaskId = value }

        [<CustomOperation("requestsPerSecond")>]
        member _.RequestsPerSecond(state: ReindexRethrottleRequest, value: CoreTypes.Float) =
            { state with RequestsPerSecond = value }

        [<CustomOperation("groupBy")>]
        member _.GroupBy(state: ReindexRethrottleRequest, value: TasksTypes.GroupBy) =
            { state with GroupBy = Some value }

    let reindexRethrottleRequest = ReindexRethrottleRequestBuilder()

    module ReindexRethrottle =
        let withRequestsPerSecond (value: CoreTypes.Float) (req: ReindexRethrottleRequest) =
            { req with RequestsPerSecond = value }
        let withGroupBy (value: TasksTypes.GroupBy) (req: ReindexRethrottleRequest) =
            { req with GroupBy = Some value }

    type RenderSearchTemplateRequest = {
        Id: CoreTypes.Id
        Id: CoreTypes.Id option
        File: string option
        Params: Map<string, System.Text.Json.JsonElement> option
        Source: CoreTypes.ScriptSource option
    }

        with
        static member ToRequest(req: RenderSearchTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_render/template/{req.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type RenderSearchTemplateResponse = System.Text.Json.JsonElement

    type RenderSearchTemplateRequestBuilder() =
        member _.Yield(_: unit) : RenderSearchTemplateRequest =
            {
                Id = Unchecked.defaultof<_>
                Id = None
                File = None
                Params = None
                Source = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: RenderSearchTemplateRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("id")>]
        member _.Id(state: RenderSearchTemplateRequest, value: CoreTypes.Id) =
            { state with Id = Some value }

        [<CustomOperation("file")>]
        member _.File(state: RenderSearchTemplateRequest, value: string) =
            { state with File = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: RenderSearchTemplateRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: RenderSearchTemplateRequest, value: CoreTypes.ScriptSource) =
            { state with Source = Some value }

    let renderSearchTemplateRequest = RenderSearchTemplateRequestBuilder()

    module RenderSearchTemplate =
        let withId (value: CoreTypes.Id) (req: RenderSearchTemplateRequest) =
            { req with Id = Some value }
        let withFile (value: string) (req: RenderSearchTemplateRequest) =
            { req with File = Some value }
        let withParams (value: Map<string, System.Text.Json.JsonElement>) (req: RenderSearchTemplateRequest) =
            { req with Params = Some value }
        let withSource (value: CoreTypes.ScriptSource) (req: RenderSearchTemplateRequest) =
            { req with Source = Some value }

    type ScriptsPainlessExecuteRequest = {
        Context: GlobalScriptsPainlessExecute.PainlessContext option
        ContextSetup: GlobalScriptsPainlessExecute.PainlessContextSetup option
        Script: CoreTypes.Script option
    }

        with
        static member ToRequest(req: ScriptsPainlessExecuteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_scripts/painless/_execute"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ScriptsPainlessExecuteResponse = System.Text.Json.JsonElement

    type ScriptsPainlessExecuteRequestBuilder() =
        member _.Yield(_: unit) : ScriptsPainlessExecuteRequest =
            {
                Context = None
                ContextSetup = None
                Script = None
            }

        [<CustomOperation("context")>]
        member _.Context(state: ScriptsPainlessExecuteRequest, value: GlobalScriptsPainlessExecute.PainlessContext) =
            { state with Context = Some value }

        [<CustomOperation("contextSetup")>]
        member _.ContextSetup(state: ScriptsPainlessExecuteRequest, value: GlobalScriptsPainlessExecute.PainlessContextSetup) =
            { state with ContextSetup = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: ScriptsPainlessExecuteRequest, value: CoreTypes.Script) =
            { state with Script = Some value }

    let scriptsPainlessExecuteRequest = ScriptsPainlessExecuteRequestBuilder()

    module ScriptsPainlessExecute =
        let withContext (value: GlobalScriptsPainlessExecute.PainlessContext) (req: ScriptsPainlessExecuteRequest) =
            { req with Context = Some value }
        let withContextSetup (value: GlobalScriptsPainlessExecute.PainlessContextSetup) (req: ScriptsPainlessExecuteRequest) =
            { req with ContextSetup = Some value }
        let withScript (value: CoreTypes.Script) (req: ScriptsPainlessExecuteRequest) =
            { req with Script = Some value }

    type ScrollRequest = {
        ScrollId: CoreTypes.ScrollId
        Scroll: CoreTypes.Duration option
        ScrollId: CoreTypes.ScrollId option
        RestTotalHitsAsInt: bool option
        Scroll: CoreTypes.Duration option
        ScrollId: CoreTypes.ScrollId
    }

        with
        static member ToRequest(req: ScrollRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_search/scroll/{req.ScrollId}"
                let queryParams =
                    [
                        req.Scroll |> Option.map (fun v -> "scroll", Fes.Http.toQueryValue v)
                        req.ScrollId |> Option.map (fun v -> "scroll_id", Fes.Http.toQueryValue v)
                        req.RestTotalHitsAsInt |> Option.map (fun v -> "rest_total_hits_as_int", Fes.Http.toQueryValue v)
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

    type ScrollResponse = GlobalSearch.ResponseBody<GlobalScrollResponse.TDocument>

    type ScrollRequestBuilder() =
        member _.Yield(_: unit) : ScrollRequest =
            {
                ScrollId = Unchecked.defaultof<_>
                Scroll = None
                ScrollId = None
                RestTotalHitsAsInt = None
                Scroll = None
                ScrollId = Unchecked.defaultof<_>
            }

        [<CustomOperation("scrollId")>]
        member _.ScrollId(state: ScrollRequest, value: CoreTypes.ScrollId) =
            { state with ScrollId = value }

        [<CustomOperation("scroll")>]
        member _.Scroll(state: ScrollRequest, value: CoreTypes.Duration) =
            { state with Scroll = Some value }

        [<CustomOperation("scrollId")>]
        member _.ScrollId(state: ScrollRequest, value: CoreTypes.ScrollId) =
            { state with ScrollId = Some value }

        [<CustomOperation("restTotalHitsAsInt")>]
        member _.RestTotalHitsAsInt(state: ScrollRequest, value: bool) =
            { state with RestTotalHitsAsInt = Some value }

        [<CustomOperation("scroll")>]
        member _.Scroll(state: ScrollRequest, value: CoreTypes.Duration) =
            { state with Scroll = Some value }

        [<CustomOperation("scrollId")>]
        member _.ScrollId(state: ScrollRequest, value: CoreTypes.ScrollId) =
            { state with ScrollId = value }

    let scrollRequest = ScrollRequestBuilder()

    module Scroll =
        let withScroll (value: CoreTypes.Duration) (req: ScrollRequest) =
            { req with Scroll = Some value }
        let withScrollId (value: CoreTypes.ScrollId) (req: ScrollRequest) =
            { req with ScrollId = Some value }
        let withRestTotalHitsAsInt (value: bool) (req: ScrollRequest) =
            { req with RestTotalHitsAsInt = Some value }
        let withScroll (value: CoreTypes.Duration) (req: ScrollRequest) =
            { req with Scroll = Some value }
        let withScrollId (value: CoreTypes.ScrollId) (req: ScrollRequest) =
            { req with ScrollId = value }

    type SearchRequest = {
        Index: CoreTypes.Indices
        AllowNoIndices: bool option
        AllowPartialSearchResults: bool option
        Analyzer: string option
        AnalyzeWildcard: bool option
        BatchedReduceSize: CoreTypes.Long option
        CcsMinimizeRoundtrips: bool option
        DefaultOperator: CoreTypes.Operator option
        Df: string option
        DocvalueFields: CoreTypes.Fields option
        ExpandWildcards: CoreTypes.ExpandWildcards option
        Explain: bool option
        IgnoreThrottled: bool option
        IgnoreUnavailable: bool option
        IncludeNamedQueriesScore: bool option
        Lenient: bool option
        MaxConcurrentShardRequests: CoreTypes.Integer option
        Preference: string option
        PreFilterShardSize: CoreTypes.Long option
        RequestCache: bool option
        Routing: CoreTypes.Routing option
        Scroll: CoreTypes.Duration option
        SearchType: CoreTypes.SearchType option
        Stats: string list option
        StoredFields: CoreTypes.Fields option
        SuggestField: CoreTypes.Field option
        SuggestMode: CoreTypes.SuggestMode option
        SuggestSize: CoreTypes.Long option
        SuggestText: string option
        TerminateAfter: CoreTypes.Long option
        Timeout: CoreTypes.Duration option
        TrackTotalHits: GlobalSearchTypes.TrackHits option
        TrackScores: bool option
        TypedKeys: bool option
        RestTotalHitsAsInt: bool option
        Version: bool option
        Source: GlobalSearchTypes.SourceConfigParam option
        SourceExcludes: CoreTypes.Fields option
        SourceExcludeVectors: bool option
        SourceIncludes: CoreTypes.Fields option
        SeqNoPrimaryTerm: bool option
        Q: string option
        Size: CoreTypes.Integer option
        From: CoreTypes.Integer option
        Sort: System.Text.Json.JsonElement option
        ForceSyntheticSource: bool option
        Aggregations: Map<string, CoreTypes.AggregationContainer> option
        Collapse: GlobalSearchTypes.FieldCollapse option
        Explain: bool option
        Ext: Map<string, System.Text.Json.JsonElement> option
        From: CoreTypes.Integer option
        Highlight: GlobalSearchTypes.Highlight option
        TrackTotalHits: GlobalSearchTypes.TrackHits option
        IndicesBoost: Map<CoreTypes.IndexName, CoreTypes.Double> list option
        DocvalueFields: CoreTypes.FieldAndFormat list option
        Knn: System.Text.Json.JsonElement option
        Rank: CoreTypes.RankContainer option
        MinScore: CoreTypes.Double option
        PostFilter: CoreTypes.QueryContainer option
        Profile: bool option
        Query: CoreTypes.QueryContainer option
        Rescore: System.Text.Json.JsonElement option
        Retriever: CoreTypes.RetrieverContainer option
        ScriptFields: Map<string, CoreTypes.ScriptField> option
        SearchAfter: CoreTypes.SortResults option
        Size: CoreTypes.Integer option
        Slice: CoreTypes.SlicedScroll option
        Sort: CoreTypes.Sort option
        Source: GlobalSearchTypes.SourceConfig option
        Fields: CoreTypes.FieldAndFormat list option
        Suggest: GlobalSearchTypes.Suggester option
        TerminateAfter: CoreTypes.Long option
        Timeout: string option
        TrackScores: bool option
        Version: bool option
        SeqNoPrimaryTerm: bool option
        StoredFields: CoreTypes.Fields option
        Pit: GlobalSearchTypes.PointInTimeReference option
        RuntimeMappings: CoreTypes.RuntimeFields option
        Stats: string list option
        ProjectRouting: CoreTypes.ProjectRouting option
    }

        with
        static member ToRequest(req: SearchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_search"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SearchResponse = GlobalSearch.ResponseBody<GlobalSearchResponse.TDocument>

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
                Explain = None
                Ext = None
                From = None
                Highlight = None
                TrackTotalHits = None
                IndicesBoost = None
                DocvalueFields = None
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
                Size = None
                Slice = None
                Sort = None
                Source = None
                Fields = None
                Suggest = None
                TerminateAfter = None
                Timeout = None
                TrackScores = None
                Version = None
                SeqNoPrimaryTerm = None
                StoredFields = None
                Pit = None
                RuntimeMappings = None
                Stats = None
                ProjectRouting = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: SearchRequest, value: CoreTypes.Indices) =
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
        member _.BatchedReduceSize(state: SearchRequest, value: CoreTypes.Long) =
            { state with BatchedReduceSize = Some value }

        [<CustomOperation("ccsMinimizeRoundtrips")>]
        member _.CcsMinimizeRoundtrips(state: SearchRequest, value: bool) =
            { state with CcsMinimizeRoundtrips = Some value }

        [<CustomOperation("defaultOperator")>]
        member _.DefaultOperator(state: SearchRequest, value: CoreTypes.Operator) =
            { state with DefaultOperator = Some value }

        [<CustomOperation("df")>]
        member _.Df(state: SearchRequest, value: string) =
            { state with Df = Some value }

        [<CustomOperation("docvalueFields")>]
        member _.DocvalueFields(state: SearchRequest, value: CoreTypes.Fields) =
            { state with DocvalueFields = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: SearchRequest, value: CoreTypes.ExpandWildcards) =
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
        member _.MaxConcurrentShardRequests(state: SearchRequest, value: CoreTypes.Integer) =
            { state with MaxConcurrentShardRequests = Some value }

        [<CustomOperation("preference")>]
        member _.Preference(state: SearchRequest, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("preFilterShardSize")>]
        member _.PreFilterShardSize(state: SearchRequest, value: CoreTypes.Long) =
            { state with PreFilterShardSize = Some value }

        [<CustomOperation("requestCache")>]
        member _.RequestCache(state: SearchRequest, value: bool) =
            { state with RequestCache = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: SearchRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("scroll")>]
        member _.Scroll(state: SearchRequest, value: CoreTypes.Duration) =
            { state with Scroll = Some value }

        [<CustomOperation("searchType")>]
        member _.SearchType(state: SearchRequest, value: CoreTypes.SearchType) =
            { state with SearchType = Some value }

        [<CustomOperation("stats")>]
        member _.Stats(state: SearchRequest, value: string list) =
            { state with Stats = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: SearchRequest, value: CoreTypes.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("suggestField")>]
        member _.SuggestField(state: SearchRequest, value: CoreTypes.Field) =
            { state with SuggestField = Some value }

        [<CustomOperation("suggestMode")>]
        member _.SuggestMode(state: SearchRequest, value: CoreTypes.SuggestMode) =
            { state with SuggestMode = Some value }

        [<CustomOperation("suggestSize")>]
        member _.SuggestSize(state: SearchRequest, value: CoreTypes.Long) =
            { state with SuggestSize = Some value }

        [<CustomOperation("suggestText")>]
        member _.SuggestText(state: SearchRequest, value: string) =
            { state with SuggestText = Some value }

        [<CustomOperation("terminateAfter")>]
        member _.TerminateAfter(state: SearchRequest, value: CoreTypes.Long) =
            { state with TerminateAfter = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SearchRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("trackTotalHits")>]
        member _.TrackTotalHits(state: SearchRequest, value: GlobalSearchTypes.TrackHits) =
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
        member _.Source(state: SearchRequest, value: GlobalSearchTypes.SourceConfigParam) =
            { state with Source = Some value }

        [<CustomOperation("sourceExcludes")>]
        member _.SourceExcludes(state: SearchRequest, value: CoreTypes.Fields) =
            { state with SourceExcludes = Some value }

        [<CustomOperation("sourceExcludeVectors")>]
        member _.SourceExcludeVectors(state: SearchRequest, value: bool) =
            { state with SourceExcludeVectors = Some value }

        [<CustomOperation("sourceIncludes")>]
        member _.SourceIncludes(state: SearchRequest, value: CoreTypes.Fields) =
            { state with SourceIncludes = Some value }

        [<CustomOperation("seqNoPrimaryTerm")>]
        member _.SeqNoPrimaryTerm(state: SearchRequest, value: bool) =
            { state with SeqNoPrimaryTerm = Some value }

        [<CustomOperation("q")>]
        member _.Q(state: SearchRequest, value: string) =
            { state with Q = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: SearchRequest, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("from")>]
        member _.From(state: SearchRequest, value: CoreTypes.Integer) =
            { state with From = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: SearchRequest, value: System.Text.Json.JsonElement) =
            { state with Sort = Some value }

        [<CustomOperation("forceSyntheticSource")>]
        member _.ForceSyntheticSource(state: SearchRequest, value: bool) =
            { state with ForceSyntheticSource = Some value }

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: SearchRequest, value: Map<string, CoreTypes.AggregationContainer>) =
            { state with Aggregations = Some value }

        [<CustomOperation("collapse")>]
        member _.Collapse(state: SearchRequest, value: GlobalSearchTypes.FieldCollapse) =
            { state with Collapse = Some value }

        [<CustomOperation("explain")>]
        member _.Explain(state: SearchRequest, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("ext")>]
        member _.Ext(state: SearchRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Ext = Some value }

        [<CustomOperation("from")>]
        member _.From(state: SearchRequest, value: CoreTypes.Integer) =
            { state with From = Some value }

        [<CustomOperation("highlight")>]
        member _.Highlight(state: SearchRequest, value: GlobalSearchTypes.Highlight) =
            { state with Highlight = Some value }

        [<CustomOperation("trackTotalHits")>]
        member _.TrackTotalHits(state: SearchRequest, value: GlobalSearchTypes.TrackHits) =
            { state with TrackTotalHits = Some value }

        [<CustomOperation("indicesBoost")>]
        member _.IndicesBoost(state: SearchRequest, value: Map<CoreTypes.IndexName, CoreTypes.Double> list) =
            { state with IndicesBoost = Some value }

        [<CustomOperation("docvalueFields")>]
        member _.DocvalueFields(state: SearchRequest, value: CoreTypes.FieldAndFormat list) =
            { state with DocvalueFields = Some value }

        [<CustomOperation("knn")>]
        member _.Knn(state: SearchRequest, value: System.Text.Json.JsonElement) =
            { state with Knn = Some value }

        [<CustomOperation("rank")>]
        member _.Rank(state: SearchRequest, value: CoreTypes.RankContainer) =
            { state with Rank = Some value }

        [<CustomOperation("minScore")>]
        member _.MinScore(state: SearchRequest, value: CoreTypes.Double) =
            { state with MinScore = Some value }

        [<CustomOperation("postFilter")>]
        member _.PostFilter(state: SearchRequest, value: CoreTypes.QueryContainer) =
            { state with PostFilter = Some value }

        [<CustomOperation("profile")>]
        member _.Profile(state: SearchRequest, value: bool) =
            { state with Profile = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: SearchRequest, value: CoreTypes.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("rescore")>]
        member _.Rescore(state: SearchRequest, value: System.Text.Json.JsonElement) =
            { state with Rescore = Some value }

        [<CustomOperation("retriever")>]
        member _.Retriever(state: SearchRequest, value: CoreTypes.RetrieverContainer) =
            { state with Retriever = Some value }

        [<CustomOperation("scriptFields")>]
        member _.ScriptFields(state: SearchRequest, value: Map<string, CoreTypes.ScriptField>) =
            { state with ScriptFields = Some value }

        [<CustomOperation("searchAfter")>]
        member _.SearchAfter(state: SearchRequest, value: CoreTypes.SortResults) =
            { state with SearchAfter = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: SearchRequest, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("slice")>]
        member _.Slice(state: SearchRequest, value: CoreTypes.SlicedScroll) =
            { state with Slice = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: SearchRequest, value: CoreTypes.Sort) =
            { state with Sort = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: SearchRequest, value: GlobalSearchTypes.SourceConfig) =
            { state with Source = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: SearchRequest, value: CoreTypes.FieldAndFormat list) =
            { state with Fields = Some value }

        [<CustomOperation("suggest")>]
        member _.Suggest(state: SearchRequest, value: GlobalSearchTypes.Suggester) =
            { state with Suggest = Some value }

        [<CustomOperation("terminateAfter")>]
        member _.TerminateAfter(state: SearchRequest, value: CoreTypes.Long) =
            { state with TerminateAfter = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SearchRequest, value: string) =
            { state with Timeout = Some value }

        [<CustomOperation("trackScores")>]
        member _.TrackScores(state: SearchRequest, value: bool) =
            { state with TrackScores = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: SearchRequest, value: bool) =
            { state with Version = Some value }

        [<CustomOperation("seqNoPrimaryTerm")>]
        member _.SeqNoPrimaryTerm(state: SearchRequest, value: bool) =
            { state with SeqNoPrimaryTerm = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: SearchRequest, value: CoreTypes.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("pit")>]
        member _.Pit(state: SearchRequest, value: GlobalSearchTypes.PointInTimeReference) =
            { state with Pit = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: SearchRequest, value: CoreTypes.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("stats")>]
        member _.Stats(state: SearchRequest, value: string list) =
            { state with Stats = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: SearchRequest, value: CoreTypes.ProjectRouting) =
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
        let withBatchedReduceSize (value: CoreTypes.Long) (req: SearchRequest) =
            { req with BatchedReduceSize = Some value }
        let withCcsMinimizeRoundtrips (value: bool) (req: SearchRequest) =
            { req with CcsMinimizeRoundtrips = Some value }
        let withDefaultOperator (value: CoreTypes.Operator) (req: SearchRequest) =
            { req with DefaultOperator = Some value }
        let withDf (value: string) (req: SearchRequest) =
            { req with Df = Some value }
        let withDocvalueFields (value: CoreTypes.Fields) (req: SearchRequest) =
            { req with DocvalueFields = Some value }
        let withExpandWildcards (value: CoreTypes.ExpandWildcards) (req: SearchRequest) =
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
        let withMaxConcurrentShardRequests (value: CoreTypes.Integer) (req: SearchRequest) =
            { req with MaxConcurrentShardRequests = Some value }
        let withPreference (value: string) (req: SearchRequest) =
            { req with Preference = Some value }
        let withPreFilterShardSize (value: CoreTypes.Long) (req: SearchRequest) =
            { req with PreFilterShardSize = Some value }
        let withRequestCache (value: bool) (req: SearchRequest) =
            { req with RequestCache = Some value }
        let withRouting (value: CoreTypes.Routing) (req: SearchRequest) =
            { req with Routing = Some value }
        let withScroll (value: CoreTypes.Duration) (req: SearchRequest) =
            { req with Scroll = Some value }
        let withSearchType (value: CoreTypes.SearchType) (req: SearchRequest) =
            { req with SearchType = Some value }
        let withStats (value: string list) (req: SearchRequest) =
            { req with Stats = Some value }
        let withStoredFields (value: CoreTypes.Fields) (req: SearchRequest) =
            { req with StoredFields = Some value }
        let withSuggestField (value: CoreTypes.Field) (req: SearchRequest) =
            { req with SuggestField = Some value }
        let withSuggestMode (value: CoreTypes.SuggestMode) (req: SearchRequest) =
            { req with SuggestMode = Some value }
        let withSuggestSize (value: CoreTypes.Long) (req: SearchRequest) =
            { req with SuggestSize = Some value }
        let withSuggestText (value: string) (req: SearchRequest) =
            { req with SuggestText = Some value }
        let withTerminateAfter (value: CoreTypes.Long) (req: SearchRequest) =
            { req with TerminateAfter = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: SearchRequest) =
            { req with Timeout = Some value }
        let withTrackTotalHits (value: GlobalSearchTypes.TrackHits) (req: SearchRequest) =
            { req with TrackTotalHits = Some value }
        let withTrackScores (value: bool) (req: SearchRequest) =
            { req with TrackScores = Some value }
        let withTypedKeys (value: bool) (req: SearchRequest) =
            { req with TypedKeys = Some value }
        let withRestTotalHitsAsInt (value: bool) (req: SearchRequest) =
            { req with RestTotalHitsAsInt = Some value }
        let withVersion (value: bool) (req: SearchRequest) =
            { req with Version = Some value }
        let withSource (value: GlobalSearchTypes.SourceConfigParam) (req: SearchRequest) =
            { req with Source = Some value }
        let withSourceExcludes (value: CoreTypes.Fields) (req: SearchRequest) =
            { req with SourceExcludes = Some value }
        let withSourceExcludeVectors (value: bool) (req: SearchRequest) =
            { req with SourceExcludeVectors = Some value }
        let withSourceIncludes (value: CoreTypes.Fields) (req: SearchRequest) =
            { req with SourceIncludes = Some value }
        let withSeqNoPrimaryTerm (value: bool) (req: SearchRequest) =
            { req with SeqNoPrimaryTerm = Some value }
        let withQ (value: string) (req: SearchRequest) =
            { req with Q = Some value }
        let withSize (value: CoreTypes.Integer) (req: SearchRequest) =
            { req with Size = Some value }
        let withFrom (value: CoreTypes.Integer) (req: SearchRequest) =
            { req with From = Some value }
        let withSort (value: System.Text.Json.JsonElement) (req: SearchRequest) =
            { req with Sort = Some value }
        let withForceSyntheticSource (value: bool) (req: SearchRequest) =
            { req with ForceSyntheticSource = Some value }
        let withAggregations (value: Map<string, CoreTypes.AggregationContainer>) (req: SearchRequest) =
            { req with Aggregations = Some value }
        let withCollapse (value: GlobalSearchTypes.FieldCollapse) (req: SearchRequest) =
            { req with Collapse = Some value }
        let withExplain (value: bool) (req: SearchRequest) =
            { req with Explain = Some value }
        let withExt (value: Map<string, System.Text.Json.JsonElement>) (req: SearchRequest) =
            { req with Ext = Some value }
        let withFrom (value: CoreTypes.Integer) (req: SearchRequest) =
            { req with From = Some value }
        let withHighlight (value: GlobalSearchTypes.Highlight) (req: SearchRequest) =
            { req with Highlight = Some value }
        let withTrackTotalHits (value: GlobalSearchTypes.TrackHits) (req: SearchRequest) =
            { req with TrackTotalHits = Some value }
        let withIndicesBoost (value: Map<CoreTypes.IndexName, CoreTypes.Double> list) (req: SearchRequest) =
            { req with IndicesBoost = Some value }
        let withDocvalueFields (value: CoreTypes.FieldAndFormat list) (req: SearchRequest) =
            { req with DocvalueFields = Some value }
        let withKnn (value: System.Text.Json.JsonElement) (req: SearchRequest) =
            { req with Knn = Some value }
        let withRank (value: CoreTypes.RankContainer) (req: SearchRequest) =
            { req with Rank = Some value }
        let withMinScore (value: CoreTypes.Double) (req: SearchRequest) =
            { req with MinScore = Some value }
        let withPostFilter (value: CoreTypes.QueryContainer) (req: SearchRequest) =
            { req with PostFilter = Some value }
        let withProfile (value: bool) (req: SearchRequest) =
            { req with Profile = Some value }
        let withQuery (value: CoreTypes.QueryContainer) (req: SearchRequest) =
            { req with Query = Some value }
        let withRescore (value: System.Text.Json.JsonElement) (req: SearchRequest) =
            { req with Rescore = Some value }
        let withRetriever (value: CoreTypes.RetrieverContainer) (req: SearchRequest) =
            { req with Retriever = Some value }
        let withScriptFields (value: Map<string, CoreTypes.ScriptField>) (req: SearchRequest) =
            { req with ScriptFields = Some value }
        let withSearchAfter (value: CoreTypes.SortResults) (req: SearchRequest) =
            { req with SearchAfter = Some value }
        let withSize (value: CoreTypes.Integer) (req: SearchRequest) =
            { req with Size = Some value }
        let withSlice (value: CoreTypes.SlicedScroll) (req: SearchRequest) =
            { req with Slice = Some value }
        let withSort (value: CoreTypes.Sort) (req: SearchRequest) =
            { req with Sort = Some value }
        let withSource (value: GlobalSearchTypes.SourceConfig) (req: SearchRequest) =
            { req with Source = Some value }
        let withFields (value: CoreTypes.FieldAndFormat list) (req: SearchRequest) =
            { req with Fields = Some value }
        let withSuggest (value: GlobalSearchTypes.Suggester) (req: SearchRequest) =
            { req with Suggest = Some value }
        let withTerminateAfter (value: CoreTypes.Long) (req: SearchRequest) =
            { req with TerminateAfter = Some value }
        let withTimeout (value: string) (req: SearchRequest) =
            { req with Timeout = Some value }
        let withTrackScores (value: bool) (req: SearchRequest) =
            { req with TrackScores = Some value }
        let withVersion (value: bool) (req: SearchRequest) =
            { req with Version = Some value }
        let withSeqNoPrimaryTerm (value: bool) (req: SearchRequest) =
            { req with SeqNoPrimaryTerm = Some value }
        let withStoredFields (value: CoreTypes.Fields) (req: SearchRequest) =
            { req with StoredFields = Some value }
        let withPit (value: GlobalSearchTypes.PointInTimeReference) (req: SearchRequest) =
            { req with Pit = Some value }
        let withRuntimeMappings (value: CoreTypes.RuntimeFields) (req: SearchRequest) =
            { req with RuntimeMappings = Some value }
        let withStats (value: string list) (req: SearchRequest) =
            { req with Stats = Some value }
        let withProjectRouting (value: CoreTypes.ProjectRouting) (req: SearchRequest) =
            { req with ProjectRouting = Some value }

    type SearchMvtRequest = {
        Index: CoreTypes.Indices
        Field: CoreTypes.Field
        Zoom: GlobalSearchMvtTypes.ZoomLevel
        X: GlobalSearchMvtTypes.Coordinate
        Y: GlobalSearchMvtTypes.Coordinate
        ExactBounds: bool option
        Extent: CoreTypes.Integer option
        GridAgg: GlobalSearchMvtTypes.GridAggregationType option
        GridPrecision: CoreTypes.Integer option
        GridType: GlobalSearchMvtTypes.GridType option
        Size: CoreTypes.Integer option
        TrackTotalHits: GlobalSearchTypes.TrackHits option
        WithLabels: bool option
        Aggs: Map<string, CoreTypes.AggregationContainer> option
        Buffer: CoreTypes.Integer option
        ExactBounds: bool option
        Extent: CoreTypes.Integer option
        Fields: CoreTypes.Fields option
        GridAgg: GlobalSearchMvtTypes.GridAggregationType option
        GridPrecision: CoreTypes.Integer option
        GridType: GlobalSearchMvtTypes.GridType option
        Query: CoreTypes.QueryContainer option
        RuntimeMappings: CoreTypes.RuntimeFields option
        Size: CoreTypes.Integer option
        Sort: CoreTypes.Sort option
        TrackTotalHits: GlobalSearchTypes.TrackHits option
        WithLabels: bool option
        ProjectRouting: CoreTypes.ProjectRouting option
    }

        with
        static member ToRequest(req: SearchMvtRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_mvt/{req.Field}/{req.Zoom}/{req.X}/{req.Y}"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SearchMvtResponse = CoreTypes.MapboxVectorTiles

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
                ExactBounds = None
                Extent = None
                Fields = None
                GridAgg = None
                GridPrecision = None
                GridType = None
                Query = None
                RuntimeMappings = None
                Size = None
                Sort = None
                TrackTotalHits = None
                WithLabels = None
                ProjectRouting = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: SearchMvtRequest, value: CoreTypes.Indices) =
            { state with Index = value }

        [<CustomOperation("field")>]
        member _.Field(state: SearchMvtRequest, value: CoreTypes.Field) =
            { state with Field = value }

        [<CustomOperation("zoom")>]
        member _.Zoom(state: SearchMvtRequest, value: GlobalSearchMvtTypes.ZoomLevel) =
            { state with Zoom = value }

        [<CustomOperation("x")>]
        member _.X(state: SearchMvtRequest, value: GlobalSearchMvtTypes.Coordinate) =
            { state with X = value }

        [<CustomOperation("y")>]
        member _.Y(state: SearchMvtRequest, value: GlobalSearchMvtTypes.Coordinate) =
            { state with Y = value }

        [<CustomOperation("exactBounds")>]
        member _.ExactBounds(state: SearchMvtRequest, value: bool) =
            { state with ExactBounds = Some value }

        [<CustomOperation("extent")>]
        member _.Extent(state: SearchMvtRequest, value: CoreTypes.Integer) =
            { state with Extent = Some value }

        [<CustomOperation("gridAgg")>]
        member _.GridAgg(state: SearchMvtRequest, value: GlobalSearchMvtTypes.GridAggregationType) =
            { state with GridAgg = Some value }

        [<CustomOperation("gridPrecision")>]
        member _.GridPrecision(state: SearchMvtRequest, value: CoreTypes.Integer) =
            { state with GridPrecision = Some value }

        [<CustomOperation("gridType")>]
        member _.GridType(state: SearchMvtRequest, value: GlobalSearchMvtTypes.GridType) =
            { state with GridType = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: SearchMvtRequest, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("trackTotalHits")>]
        member _.TrackTotalHits(state: SearchMvtRequest, value: GlobalSearchTypes.TrackHits) =
            { state with TrackTotalHits = Some value }

        [<CustomOperation("withLabels")>]
        member _.WithLabels(state: SearchMvtRequest, value: bool) =
            { state with WithLabels = Some value }

        [<CustomOperation("aggs")>]
        member _.Aggs(state: SearchMvtRequest, value: Map<string, CoreTypes.AggregationContainer>) =
            { state with Aggs = Some value }

        [<CustomOperation("buffer")>]
        member _.Buffer(state: SearchMvtRequest, value: CoreTypes.Integer) =
            { state with Buffer = Some value }

        [<CustomOperation("exactBounds")>]
        member _.ExactBounds(state: SearchMvtRequest, value: bool) =
            { state with ExactBounds = Some value }

        [<CustomOperation("extent")>]
        member _.Extent(state: SearchMvtRequest, value: CoreTypes.Integer) =
            { state with Extent = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: SearchMvtRequest, value: CoreTypes.Fields) =
            { state with Fields = Some value }

        [<CustomOperation("gridAgg")>]
        member _.GridAgg(state: SearchMvtRequest, value: GlobalSearchMvtTypes.GridAggregationType) =
            { state with GridAgg = Some value }

        [<CustomOperation("gridPrecision")>]
        member _.GridPrecision(state: SearchMvtRequest, value: CoreTypes.Integer) =
            { state with GridPrecision = Some value }

        [<CustomOperation("gridType")>]
        member _.GridType(state: SearchMvtRequest, value: GlobalSearchMvtTypes.GridType) =
            { state with GridType = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: SearchMvtRequest, value: CoreTypes.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: SearchMvtRequest, value: CoreTypes.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: SearchMvtRequest, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: SearchMvtRequest, value: CoreTypes.Sort) =
            { state with Sort = Some value }

        [<CustomOperation("trackTotalHits")>]
        member _.TrackTotalHits(state: SearchMvtRequest, value: GlobalSearchTypes.TrackHits) =
            { state with TrackTotalHits = Some value }

        [<CustomOperation("withLabels")>]
        member _.WithLabels(state: SearchMvtRequest, value: bool) =
            { state with WithLabels = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: SearchMvtRequest, value: CoreTypes.ProjectRouting) =
            { state with ProjectRouting = Some value }

    let searchMvtRequest = SearchMvtRequestBuilder()

    module SearchMvt =
        let withExactBounds (value: bool) (req: SearchMvtRequest) =
            { req with ExactBounds = Some value }
        let withExtent (value: CoreTypes.Integer) (req: SearchMvtRequest) =
            { req with Extent = Some value }
        let withGridAgg (value: GlobalSearchMvtTypes.GridAggregationType) (req: SearchMvtRequest) =
            { req with GridAgg = Some value }
        let withGridPrecision (value: CoreTypes.Integer) (req: SearchMvtRequest) =
            { req with GridPrecision = Some value }
        let withGridType (value: GlobalSearchMvtTypes.GridType) (req: SearchMvtRequest) =
            { req with GridType = Some value }
        let withSize (value: CoreTypes.Integer) (req: SearchMvtRequest) =
            { req with Size = Some value }
        let withTrackTotalHits (value: GlobalSearchTypes.TrackHits) (req: SearchMvtRequest) =
            { req with TrackTotalHits = Some value }
        let withWithLabels (value: bool) (req: SearchMvtRequest) =
            { req with WithLabels = Some value }
        let withAggs (value: Map<string, CoreTypes.AggregationContainer>) (req: SearchMvtRequest) =
            { req with Aggs = Some value }
        let withBuffer (value: CoreTypes.Integer) (req: SearchMvtRequest) =
            { req with Buffer = Some value }
        let withExactBounds (value: bool) (req: SearchMvtRequest) =
            { req with ExactBounds = Some value }
        let withExtent (value: CoreTypes.Integer) (req: SearchMvtRequest) =
            { req with Extent = Some value }
        let withFields (value: CoreTypes.Fields) (req: SearchMvtRequest) =
            { req with Fields = Some value }
        let withGridAgg (value: GlobalSearchMvtTypes.GridAggregationType) (req: SearchMvtRequest) =
            { req with GridAgg = Some value }
        let withGridPrecision (value: CoreTypes.Integer) (req: SearchMvtRequest) =
            { req with GridPrecision = Some value }
        let withGridType (value: GlobalSearchMvtTypes.GridType) (req: SearchMvtRequest) =
            { req with GridType = Some value }
        let withQuery (value: CoreTypes.QueryContainer) (req: SearchMvtRequest) =
            { req with Query = Some value }
        let withRuntimeMappings (value: CoreTypes.RuntimeFields) (req: SearchMvtRequest) =
            { req with RuntimeMappings = Some value }
        let withSize (value: CoreTypes.Integer) (req: SearchMvtRequest) =
            { req with Size = Some value }
        let withSort (value: CoreTypes.Sort) (req: SearchMvtRequest) =
            { req with Sort = Some value }
        let withTrackTotalHits (value: GlobalSearchTypes.TrackHits) (req: SearchMvtRequest) =
            { req with TrackTotalHits = Some value }
        let withWithLabels (value: bool) (req: SearchMvtRequest) =
            { req with WithLabels = Some value }
        let withProjectRouting (value: CoreTypes.ProjectRouting) (req: SearchMvtRequest) =
            { req with ProjectRouting = Some value }

    type SearchShardsRequest = {
        Index: CoreTypes.Indices
        AllowNoIndices: bool option
        ExpandWildcards: CoreTypes.ExpandWildcards option
        IgnoreUnavailable: bool option
        Local: bool option
        MasterTimeout: CoreTypes.Duration option
        Preference: string option
        Routing: CoreTypes.Routing option
    }

        with
        static member ToRequest(req: SearchShardsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_search_shards"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

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
        member _.Index(state: SearchShardsRequest, value: CoreTypes.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: SearchShardsRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: SearchShardsRequest, value: CoreTypes.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: SearchShardsRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("local")>]
        member _.Local(state: SearchShardsRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SearchShardsRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("preference")>]
        member _.Preference(state: SearchShardsRequest, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: SearchShardsRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

    let searchShardsRequest = SearchShardsRequestBuilder()

    module SearchShards =
        let withAllowNoIndices (value: bool) (req: SearchShardsRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: CoreTypes.ExpandWildcards) (req: SearchShardsRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreUnavailable (value: bool) (req: SearchShardsRequest) =
            { req with IgnoreUnavailable = Some value }
        let withLocal (value: bool) (req: SearchShardsRequest) =
            { req with Local = Some value }
        let withMasterTimeout (value: CoreTypes.Duration) (req: SearchShardsRequest) =
            { req with MasterTimeout = Some value }
        let withPreference (value: string) (req: SearchShardsRequest) =
            { req with Preference = Some value }
        let withRouting (value: CoreTypes.Routing) (req: SearchShardsRequest) =
            { req with Routing = Some value }

    type SearchTemplateRequest = {
        Index: CoreTypes.Indices
        AllowNoIndices: bool option
        CcsMinimizeRoundtrips: bool option
        ExpandWildcards: CoreTypes.ExpandWildcards option
        Explain: bool option
        IgnoreThrottled: bool option
        IgnoreUnavailable: bool option
        Preference: string option
        Profile: bool option
        Routing: CoreTypes.Routing option
        Scroll: CoreTypes.Duration option
        SearchType: CoreTypes.SearchType option
        RestTotalHitsAsInt: bool option
        TypedKeys: bool option
        Explain: bool option
        Id: CoreTypes.Id option
        Params: Map<string, System.Text.Json.JsonElement> option
        Profile: bool option
        Source: CoreTypes.ScriptSource option
        ProjectRouting: CoreTypes.ProjectRouting option
    }

        with
        static member ToRequest(req: SearchTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_search/template"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

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
                Explain = None
                Id = None
                Params = None
                Profile = None
                Source = None
                ProjectRouting = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: SearchTemplateRequest, value: CoreTypes.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: SearchTemplateRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("ccsMinimizeRoundtrips")>]
        member _.CcsMinimizeRoundtrips(state: SearchTemplateRequest, value: bool) =
            { state with CcsMinimizeRoundtrips = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: SearchTemplateRequest, value: CoreTypes.ExpandWildcards) =
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
        member _.Routing(state: SearchTemplateRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("scroll")>]
        member _.Scroll(state: SearchTemplateRequest, value: CoreTypes.Duration) =
            { state with Scroll = Some value }

        [<CustomOperation("searchType")>]
        member _.SearchType(state: SearchTemplateRequest, value: CoreTypes.SearchType) =
            { state with SearchType = Some value }

        [<CustomOperation("restTotalHitsAsInt")>]
        member _.RestTotalHitsAsInt(state: SearchTemplateRequest, value: bool) =
            { state with RestTotalHitsAsInt = Some value }

        [<CustomOperation("typedKeys")>]
        member _.TypedKeys(state: SearchTemplateRequest, value: bool) =
            { state with TypedKeys = Some value }

        [<CustomOperation("explain")>]
        member _.Explain(state: SearchTemplateRequest, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: SearchTemplateRequest, value: CoreTypes.Id) =
            { state with Id = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: SearchTemplateRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("profile")>]
        member _.Profile(state: SearchTemplateRequest, value: bool) =
            { state with Profile = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: SearchTemplateRequest, value: CoreTypes.ScriptSource) =
            { state with Source = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: SearchTemplateRequest, value: CoreTypes.ProjectRouting) =
            { state with ProjectRouting = Some value }

    let searchTemplateRequest = SearchTemplateRequestBuilder()

    module SearchTemplate =
        let withAllowNoIndices (value: bool) (req: SearchTemplateRequest) =
            { req with AllowNoIndices = Some value }
        let withCcsMinimizeRoundtrips (value: bool) (req: SearchTemplateRequest) =
            { req with CcsMinimizeRoundtrips = Some value }
        let withExpandWildcards (value: CoreTypes.ExpandWildcards) (req: SearchTemplateRequest) =
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
        let withRouting (value: CoreTypes.Routing) (req: SearchTemplateRequest) =
            { req with Routing = Some value }
        let withScroll (value: CoreTypes.Duration) (req: SearchTemplateRequest) =
            { req with Scroll = Some value }
        let withSearchType (value: CoreTypes.SearchType) (req: SearchTemplateRequest) =
            { req with SearchType = Some value }
        let withRestTotalHitsAsInt (value: bool) (req: SearchTemplateRequest) =
            { req with RestTotalHitsAsInt = Some value }
        let withTypedKeys (value: bool) (req: SearchTemplateRequest) =
            { req with TypedKeys = Some value }
        let withExplain (value: bool) (req: SearchTemplateRequest) =
            { req with Explain = Some value }
        let withId (value: CoreTypes.Id) (req: SearchTemplateRequest) =
            { req with Id = Some value }
        let withParams (value: Map<string, System.Text.Json.JsonElement>) (req: SearchTemplateRequest) =
            { req with Params = Some value }
        let withProfile (value: bool) (req: SearchTemplateRequest) =
            { req with Profile = Some value }
        let withSource (value: CoreTypes.ScriptSource) (req: SearchTemplateRequest) =
            { req with Source = Some value }
        let withProjectRouting (value: CoreTypes.ProjectRouting) (req: SearchTemplateRequest) =
            { req with ProjectRouting = Some value }

    type TermsEnumRequest = {
        Index: CoreTypes.Indices
        Field: CoreTypes.Field
        Size: CoreTypes.Integer option
        Timeout: CoreTypes.Duration option
        CaseInsensitive: bool option
        IndexFilter: CoreTypes.QueryContainer option
        String: string option
        SearchAfter: string option
    }

        with
        static member ToRequest(req: TermsEnumRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_terms_enum"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

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
        member _.Index(state: TermsEnumRequest, value: CoreTypes.Indices) =
            { state with Index = value }

        [<CustomOperation("field")>]
        member _.Field(state: TermsEnumRequest, value: CoreTypes.Field) =
            { state with Field = value }

        [<CustomOperation("size")>]
        member _.Size(state: TermsEnumRequest, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TermsEnumRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("caseInsensitive")>]
        member _.CaseInsensitive(state: TermsEnumRequest, value: bool) =
            { state with CaseInsensitive = Some value }

        [<CustomOperation("indexFilter")>]
        member _.IndexFilter(state: TermsEnumRequest, value: CoreTypes.QueryContainer) =
            { state with IndexFilter = Some value }

        [<CustomOperation("string")>]
        member _.String(state: TermsEnumRequest, value: string) =
            { state with String = Some value }

        [<CustomOperation("searchAfter")>]
        member _.SearchAfter(state: TermsEnumRequest, value: string) =
            { state with SearchAfter = Some value }

    let termsEnumRequest = TermsEnumRequestBuilder()

    module TermsEnum =
        let withField (value: CoreTypes.Field) (req: TermsEnumRequest) =
            { req with Field = value }
        let withSize (value: CoreTypes.Integer) (req: TermsEnumRequest) =
            { req with Size = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: TermsEnumRequest) =
            { req with Timeout = Some value }
        let withCaseInsensitive (value: bool) (req: TermsEnumRequest) =
            { req with CaseInsensitive = Some value }
        let withIndexFilter (value: CoreTypes.QueryContainer) (req: TermsEnumRequest) =
            { req with IndexFilter = Some value }
        let withString (value: string) (req: TermsEnumRequest) =
            { req with String = Some value }
        let withSearchAfter (value: string) (req: TermsEnumRequest) =
            { req with SearchAfter = Some value }

    type TermvectorsRequest = {
        Index: CoreTypes.IndexName
        Id: CoreTypes.Id
        Fields: CoreTypes.Fields option
        FieldStatistics: bool option
        Offsets: bool option
        Payloads: bool option
        Positions: bool option
        Preference: string option
        Realtime: bool option
        Routing: CoreTypes.Routing option
        TermStatistics: bool option
        Version: CoreTypes.VersionNumber option
        VersionType: CoreTypes.VersionType option
        Doc: 'tDocument option
        Filter: GlobalTermvectors.Filter option
        PerFieldAnalyzer: Map<CoreTypes.Field, string> option
        Fields: CoreTypes.Field list option
        FieldStatistics: bool option
        Offsets: bool option
        Payloads: bool option
        Positions: bool option
        TermStatistics: bool option
        Routing: CoreTypes.Routing option
        Version: CoreTypes.VersionNumber option
        VersionType: CoreTypes.VersionType option
    }

        with
        static member ToRequest(req: TermvectorsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_termvectors/{req.Id}"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type TermvectorsResponse = System.Text.Json.JsonElement

    type TermvectorsRequestBuilder() =
        member _.Yield(_: unit) : TermvectorsRequest =
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
                Fields = None
                FieldStatistics = None
                Offsets = None
                Payloads = None
                Positions = None
                TermStatistics = None
                Routing = None
                Version = None
                VersionType = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: TermvectorsRequest, value: CoreTypes.IndexName) =
            { state with Index = value }

        [<CustomOperation("id")>]
        member _.Id(state: TermvectorsRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("fields")>]
        member _.Fields(state: TermvectorsRequest, value: CoreTypes.Fields) =
            { state with Fields = Some value }

        [<CustomOperation("fieldStatistics")>]
        member _.FieldStatistics(state: TermvectorsRequest, value: bool) =
            { state with FieldStatistics = Some value }

        [<CustomOperation("offsets")>]
        member _.Offsets(state: TermvectorsRequest, value: bool) =
            { state with Offsets = Some value }

        [<CustomOperation("payloads")>]
        member _.Payloads(state: TermvectorsRequest, value: bool) =
            { state with Payloads = Some value }

        [<CustomOperation("positions")>]
        member _.Positions(state: TermvectorsRequest, value: bool) =
            { state with Positions = Some value }

        [<CustomOperation("preference")>]
        member _.Preference(state: TermvectorsRequest, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("realtime")>]
        member _.Realtime(state: TermvectorsRequest, value: bool) =
            { state with Realtime = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: TermvectorsRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("termStatistics")>]
        member _.TermStatistics(state: TermvectorsRequest, value: bool) =
            { state with TermStatistics = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: TermvectorsRequest, value: CoreTypes.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: TermvectorsRequest, value: CoreTypes.VersionType) =
            { state with VersionType = Some value }

        [<CustomOperation("doc")>]
        member _.Doc(state: TermvectorsRequest, value: 'tDocument) =
            { state with Doc = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: TermvectorsRequest, value: GlobalTermvectors.Filter) =
            { state with Filter = Some value }

        [<CustomOperation("perFieldAnalyzer")>]
        member _.PerFieldAnalyzer(state: TermvectorsRequest, value: Map<CoreTypes.Field, string>) =
            { state with PerFieldAnalyzer = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: TermvectorsRequest, value: CoreTypes.Field list) =
            { state with Fields = Some value }

        [<CustomOperation("fieldStatistics")>]
        member _.FieldStatistics(state: TermvectorsRequest, value: bool) =
            { state with FieldStatistics = Some value }

        [<CustomOperation("offsets")>]
        member _.Offsets(state: TermvectorsRequest, value: bool) =
            { state with Offsets = Some value }

        [<CustomOperation("payloads")>]
        member _.Payloads(state: TermvectorsRequest, value: bool) =
            { state with Payloads = Some value }

        [<CustomOperation("positions")>]
        member _.Positions(state: TermvectorsRequest, value: bool) =
            { state with Positions = Some value }

        [<CustomOperation("termStatistics")>]
        member _.TermStatistics(state: TermvectorsRequest, value: bool) =
            { state with TermStatistics = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: TermvectorsRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: TermvectorsRequest, value: CoreTypes.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: TermvectorsRequest, value: CoreTypes.VersionType) =
            { state with VersionType = Some value }

    let termvectorsRequest = TermvectorsRequestBuilder()

    module Termvectors =
        let withFields (value: CoreTypes.Fields) (req: TermvectorsRequest) =
            { req with Fields = Some value }
        let withFieldStatistics (value: bool) (req: TermvectorsRequest) =
            { req with FieldStatistics = Some value }
        let withOffsets (value: bool) (req: TermvectorsRequest) =
            { req with Offsets = Some value }
        let withPayloads (value: bool) (req: TermvectorsRequest) =
            { req with Payloads = Some value }
        let withPositions (value: bool) (req: TermvectorsRequest) =
            { req with Positions = Some value }
        let withPreference (value: string) (req: TermvectorsRequest) =
            { req with Preference = Some value }
        let withRealtime (value: bool) (req: TermvectorsRequest) =
            { req with Realtime = Some value }
        let withRouting (value: CoreTypes.Routing) (req: TermvectorsRequest) =
            { req with Routing = Some value }
        let withTermStatistics (value: bool) (req: TermvectorsRequest) =
            { req with TermStatistics = Some value }
        let withVersion (value: CoreTypes.VersionNumber) (req: TermvectorsRequest) =
            { req with Version = Some value }
        let withVersionType (value: CoreTypes.VersionType) (req: TermvectorsRequest) =
            { req with VersionType = Some value }
        let withDoc (value: 'tDocument) (req: TermvectorsRequest) =
            { req with Doc = Some value }
        let withFilter (value: GlobalTermvectors.Filter) (req: TermvectorsRequest) =
            { req with Filter = Some value }
        let withPerFieldAnalyzer (value: Map<CoreTypes.Field, string>) (req: TermvectorsRequest) =
            { req with PerFieldAnalyzer = Some value }
        let withFields (value: CoreTypes.Field list) (req: TermvectorsRequest) =
            { req with Fields = Some value }
        let withFieldStatistics (value: bool) (req: TermvectorsRequest) =
            { req with FieldStatistics = Some value }
        let withOffsets (value: bool) (req: TermvectorsRequest) =
            { req with Offsets = Some value }
        let withPayloads (value: bool) (req: TermvectorsRequest) =
            { req with Payloads = Some value }
        let withPositions (value: bool) (req: TermvectorsRequest) =
            { req with Positions = Some value }
        let withTermStatistics (value: bool) (req: TermvectorsRequest) =
            { req with TermStatistics = Some value }
        let withRouting (value: CoreTypes.Routing) (req: TermvectorsRequest) =
            { req with Routing = Some value }
        let withVersion (value: CoreTypes.VersionNumber) (req: TermvectorsRequest) =
            { req with Version = Some value }
        let withVersionType (value: CoreTypes.VersionType) (req: TermvectorsRequest) =
            { req with VersionType = Some value }

    type UpdateRequest = {
        Id: CoreTypes.Id
        Index: CoreTypes.IndexName
        IfPrimaryTerm: CoreTypes.Long option
        IfSeqNo: CoreTypes.SequenceNumber option
        IncludeSourceOnError: bool option
        Lang: string option
        Refresh: CoreTypes.Refresh option
        RequireAlias: bool option
        RetryOnConflict: CoreTypes.Integer option
        Routing: CoreTypes.Routing option
        Timeout: CoreTypes.Duration option
        WaitForActiveShards: CoreTypes.WaitForActiveShards option
        Source: GlobalSearchTypes.SourceConfigParam option
        SourceExcludes: CoreTypes.Fields option
        SourceIncludes: CoreTypes.Fields option
        DetectNoop: bool option
        Doc: 'tPartialDocument option
        DocAsUpsert: bool option
        Script: CoreTypes.Script option
        ScriptedUpsert: bool option
        Source: GlobalSearchTypes.SourceConfig option
        Upsert: 'tDocument option
    }

        with
        static member ToRequest(req: UpdateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_update/{req.Id}"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type UpdateResponse = GlobalUpdate.UpdateWriteResponseBase<'tDocument>

    type UpdateRequestBuilder() =
        member _.Yield(_: unit) : UpdateRequest =
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
                Source = None
                Upsert = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: UpdateRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: UpdateRequest, value: CoreTypes.IndexName) =
            { state with Index = value }

        [<CustomOperation("ifPrimaryTerm")>]
        member _.IfPrimaryTerm(state: UpdateRequest, value: CoreTypes.Long) =
            { state with IfPrimaryTerm = Some value }

        [<CustomOperation("ifSeqNo")>]
        member _.IfSeqNo(state: UpdateRequest, value: CoreTypes.SequenceNumber) =
            { state with IfSeqNo = Some value }

        [<CustomOperation("includeSourceOnError")>]
        member _.IncludeSourceOnError(state: UpdateRequest, value: bool) =
            { state with IncludeSourceOnError = Some value }

        [<CustomOperation("lang")>]
        member _.Lang(state: UpdateRequest, value: string) =
            { state with Lang = Some value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: UpdateRequest, value: CoreTypes.Refresh) =
            { state with Refresh = Some value }

        [<CustomOperation("requireAlias")>]
        member _.RequireAlias(state: UpdateRequest, value: bool) =
            { state with RequireAlias = Some value }

        [<CustomOperation("retryOnConflict")>]
        member _.RetryOnConflict(state: UpdateRequest, value: CoreTypes.Integer) =
            { state with RetryOnConflict = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: UpdateRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: UpdateRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: UpdateRequest, value: CoreTypes.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: UpdateRequest, value: GlobalSearchTypes.SourceConfigParam) =
            { state with Source = Some value }

        [<CustomOperation("sourceExcludes")>]
        member _.SourceExcludes(state: UpdateRequest, value: CoreTypes.Fields) =
            { state with SourceExcludes = Some value }

        [<CustomOperation("sourceIncludes")>]
        member _.SourceIncludes(state: UpdateRequest, value: CoreTypes.Fields) =
            { state with SourceIncludes = Some value }

        [<CustomOperation("detectNoop")>]
        member _.DetectNoop(state: UpdateRequest, value: bool) =
            { state with DetectNoop = Some value }

        [<CustomOperation("doc")>]
        member _.Doc(state: UpdateRequest, value: 'tPartialDocument) =
            { state with Doc = Some value }

        [<CustomOperation("docAsUpsert")>]
        member _.DocAsUpsert(state: UpdateRequest, value: bool) =
            { state with DocAsUpsert = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: UpdateRequest, value: CoreTypes.Script) =
            { state with Script = Some value }

        [<CustomOperation("scriptedUpsert")>]
        member _.ScriptedUpsert(state: UpdateRequest, value: bool) =
            { state with ScriptedUpsert = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: UpdateRequest, value: GlobalSearchTypes.SourceConfig) =
            { state with Source = Some value }

        [<CustomOperation("upsert")>]
        member _.Upsert(state: UpdateRequest, value: 'tDocument) =
            { state with Upsert = Some value }

    let updateRequest = UpdateRequestBuilder()

    module Update =
        let withIfPrimaryTerm (value: CoreTypes.Long) (req: UpdateRequest) =
            { req with IfPrimaryTerm = Some value }
        let withIfSeqNo (value: CoreTypes.SequenceNumber) (req: UpdateRequest) =
            { req with IfSeqNo = Some value }
        let withIncludeSourceOnError (value: bool) (req: UpdateRequest) =
            { req with IncludeSourceOnError = Some value }
        let withLang (value: string) (req: UpdateRequest) =
            { req with Lang = Some value }
        let withRefresh (value: CoreTypes.Refresh) (req: UpdateRequest) =
            { req with Refresh = Some value }
        let withRequireAlias (value: bool) (req: UpdateRequest) =
            { req with RequireAlias = Some value }
        let withRetryOnConflict (value: CoreTypes.Integer) (req: UpdateRequest) =
            { req with RetryOnConflict = Some value }
        let withRouting (value: CoreTypes.Routing) (req: UpdateRequest) =
            { req with Routing = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: UpdateRequest) =
            { req with Timeout = Some value }
        let withWaitForActiveShards (value: CoreTypes.WaitForActiveShards) (req: UpdateRequest) =
            { req with WaitForActiveShards = Some value }
        let withSource (value: GlobalSearchTypes.SourceConfigParam) (req: UpdateRequest) =
            { req with Source = Some value }
        let withSourceExcludes (value: CoreTypes.Fields) (req: UpdateRequest) =
            { req with SourceExcludes = Some value }
        let withSourceIncludes (value: CoreTypes.Fields) (req: UpdateRequest) =
            { req with SourceIncludes = Some value }
        let withDetectNoop (value: bool) (req: UpdateRequest) =
            { req with DetectNoop = Some value }
        let withDoc (value: 'tPartialDocument) (req: UpdateRequest) =
            { req with Doc = Some value }
        let withDocAsUpsert (value: bool) (req: UpdateRequest) =
            { req with DocAsUpsert = Some value }
        let withScript (value: CoreTypes.Script) (req: UpdateRequest) =
            { req with Script = Some value }
        let withScriptedUpsert (value: bool) (req: UpdateRequest) =
            { req with ScriptedUpsert = Some value }
        let withSource (value: GlobalSearchTypes.SourceConfig) (req: UpdateRequest) =
            { req with Source = Some value }
        let withUpsert (value: 'tDocument) (req: UpdateRequest) =
            { req with Upsert = Some value }

    type UpdateByQueryRequest = {
        Index: CoreTypes.Indices
        AllowNoIndices: bool option
        Analyzer: string option
        AnalyzeWildcard: bool option
        Conflicts: CoreTypes.Conflicts option
        DefaultOperator: CoreTypes.Operator option
        Df: string option
        ExpandWildcards: CoreTypes.ExpandWildcards option
        From: CoreTypes.Long option
        IgnoreUnavailable: bool option
        Lenient: bool option
        MaxDocs: CoreTypes.Long option
        Pipeline: string option
        Preference: string option
        Q: string option
        Refresh: bool option
        RequestCache: bool option
        RequestsPerSecond: CoreTypes.Float option
        Routing: CoreTypes.Routing option
        Scroll: CoreTypes.Duration option
        ScrollSize: CoreTypes.Long option
        SearchTimeout: CoreTypes.Duration option
        SearchType: CoreTypes.SearchType option
        Slices: CoreTypes.Slices option
        Sort: string list option
        Stats: string list option
        TerminateAfter: CoreTypes.Long option
        Timeout: CoreTypes.Duration option
        Version: bool option
        VersionType: bool option
        WaitForActiveShards: CoreTypes.WaitForActiveShards option
        WaitForCompletion: bool option
        MaxDocs: CoreTypes.Long option
        Query: CoreTypes.QueryContainer option
        Script: CoreTypes.Script option
        Slice: CoreTypes.SlicedScroll option
        Conflicts: CoreTypes.Conflicts option
    }

        with
        static member ToRequest(req: UpdateByQueryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_update_by_query"
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

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
                MaxDocs = None
                Query = None
                Script = None
                Slice = None
                Conflicts = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: UpdateByQueryRequest, value: CoreTypes.Indices) =
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
        member _.Conflicts(state: UpdateByQueryRequest, value: CoreTypes.Conflicts) =
            { state with Conflicts = Some value }

        [<CustomOperation("defaultOperator")>]
        member _.DefaultOperator(state: UpdateByQueryRequest, value: CoreTypes.Operator) =
            { state with DefaultOperator = Some value }

        [<CustomOperation("df")>]
        member _.Df(state: UpdateByQueryRequest, value: string) =
            { state with Df = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: UpdateByQueryRequest, value: CoreTypes.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("from")>]
        member _.From(state: UpdateByQueryRequest, value: CoreTypes.Long) =
            { state with From = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: UpdateByQueryRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("lenient")>]
        member _.Lenient(state: UpdateByQueryRequest, value: bool) =
            { state with Lenient = Some value }

        [<CustomOperation("maxDocs")>]
        member _.MaxDocs(state: UpdateByQueryRequest, value: CoreTypes.Long) =
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
        member _.RequestsPerSecond(state: UpdateByQueryRequest, value: CoreTypes.Float) =
            { state with RequestsPerSecond = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: UpdateByQueryRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("scroll")>]
        member _.Scroll(state: UpdateByQueryRequest, value: CoreTypes.Duration) =
            { state with Scroll = Some value }

        [<CustomOperation("scrollSize")>]
        member _.ScrollSize(state: UpdateByQueryRequest, value: CoreTypes.Long) =
            { state with ScrollSize = Some value }

        [<CustomOperation("searchTimeout")>]
        member _.SearchTimeout(state: UpdateByQueryRequest, value: CoreTypes.Duration) =
            { state with SearchTimeout = Some value }

        [<CustomOperation("searchType")>]
        member _.SearchType(state: UpdateByQueryRequest, value: CoreTypes.SearchType) =
            { state with SearchType = Some value }

        [<CustomOperation("slices")>]
        member _.Slices(state: UpdateByQueryRequest, value: CoreTypes.Slices) =
            { state with Slices = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: UpdateByQueryRequest, value: string list) =
            { state with Sort = Some value }

        [<CustomOperation("stats")>]
        member _.Stats(state: UpdateByQueryRequest, value: string list) =
            { state with Stats = Some value }

        [<CustomOperation("terminateAfter")>]
        member _.TerminateAfter(state: UpdateByQueryRequest, value: CoreTypes.Long) =
            { state with TerminateAfter = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: UpdateByQueryRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: UpdateByQueryRequest, value: bool) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: UpdateByQueryRequest, value: bool) =
            { state with VersionType = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: UpdateByQueryRequest, value: CoreTypes.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: UpdateByQueryRequest, value: bool) =
            { state with WaitForCompletion = Some value }

        [<CustomOperation("maxDocs")>]
        member _.MaxDocs(state: UpdateByQueryRequest, value: CoreTypes.Long) =
            { state with MaxDocs = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: UpdateByQueryRequest, value: CoreTypes.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: UpdateByQueryRequest, value: CoreTypes.Script) =
            { state with Script = Some value }

        [<CustomOperation("slice")>]
        member _.Slice(state: UpdateByQueryRequest, value: CoreTypes.SlicedScroll) =
            { state with Slice = Some value }

        [<CustomOperation("conflicts")>]
        member _.Conflicts(state: UpdateByQueryRequest, value: CoreTypes.Conflicts) =
            { state with Conflicts = Some value }

    let updateByQueryRequest = UpdateByQueryRequestBuilder()

    module UpdateByQuery =
        let withAllowNoIndices (value: bool) (req: UpdateByQueryRequest) =
            { req with AllowNoIndices = Some value }
        let withAnalyzer (value: string) (req: UpdateByQueryRequest) =
            { req with Analyzer = Some value }
        let withAnalyzeWildcard (value: bool) (req: UpdateByQueryRequest) =
            { req with AnalyzeWildcard = Some value }
        let withConflicts (value: CoreTypes.Conflicts) (req: UpdateByQueryRequest) =
            { req with Conflicts = Some value }
        let withDefaultOperator (value: CoreTypes.Operator) (req: UpdateByQueryRequest) =
            { req with DefaultOperator = Some value }
        let withDf (value: string) (req: UpdateByQueryRequest) =
            { req with Df = Some value }
        let withExpandWildcards (value: CoreTypes.ExpandWildcards) (req: UpdateByQueryRequest) =
            { req with ExpandWildcards = Some value }
        let withFrom (value: CoreTypes.Long) (req: UpdateByQueryRequest) =
            { req with From = Some value }
        let withIgnoreUnavailable (value: bool) (req: UpdateByQueryRequest) =
            { req with IgnoreUnavailable = Some value }
        let withLenient (value: bool) (req: UpdateByQueryRequest) =
            { req with Lenient = Some value }
        let withMaxDocs (value: CoreTypes.Long) (req: UpdateByQueryRequest) =
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
        let withRequestsPerSecond (value: CoreTypes.Float) (req: UpdateByQueryRequest) =
            { req with RequestsPerSecond = Some value }
        let withRouting (value: CoreTypes.Routing) (req: UpdateByQueryRequest) =
            { req with Routing = Some value }
        let withScroll (value: CoreTypes.Duration) (req: UpdateByQueryRequest) =
            { req with Scroll = Some value }
        let withScrollSize (value: CoreTypes.Long) (req: UpdateByQueryRequest) =
            { req with ScrollSize = Some value }
        let withSearchTimeout (value: CoreTypes.Duration) (req: UpdateByQueryRequest) =
            { req with SearchTimeout = Some value }
        let withSearchType (value: CoreTypes.SearchType) (req: UpdateByQueryRequest) =
            { req with SearchType = Some value }
        let withSlices (value: CoreTypes.Slices) (req: UpdateByQueryRequest) =
            { req with Slices = Some value }
        let withSort (value: string list) (req: UpdateByQueryRequest) =
            { req with Sort = Some value }
        let withStats (value: string list) (req: UpdateByQueryRequest) =
            { req with Stats = Some value }
        let withTerminateAfter (value: CoreTypes.Long) (req: UpdateByQueryRequest) =
            { req with TerminateAfter = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: UpdateByQueryRequest) =
            { req with Timeout = Some value }
        let withVersion (value: bool) (req: UpdateByQueryRequest) =
            { req with Version = Some value }
        let withVersionType (value: bool) (req: UpdateByQueryRequest) =
            { req with VersionType = Some value }
        let withWaitForActiveShards (value: CoreTypes.WaitForActiveShards) (req: UpdateByQueryRequest) =
            { req with WaitForActiveShards = Some value }
        let withWaitForCompletion (value: bool) (req: UpdateByQueryRequest) =
            { req with WaitForCompletion = Some value }
        let withMaxDocs (value: CoreTypes.Long) (req: UpdateByQueryRequest) =
            { req with MaxDocs = Some value }
        let withQuery (value: CoreTypes.QueryContainer) (req: UpdateByQueryRequest) =
            { req with Query = Some value }
        let withScript (value: CoreTypes.Script) (req: UpdateByQueryRequest) =
            { req with Script = Some value }
        let withSlice (value: CoreTypes.SlicedScroll) (req: UpdateByQueryRequest) =
            { req with Slice = Some value }
        let withConflicts (value: CoreTypes.Conflicts) (req: UpdateByQueryRequest) =
            { req with Conflicts = Some value }

    type UpdateByQueryRethrottleRequest = {
        TaskId: CoreTypes.Id
        RequestsPerSecond: CoreTypes.Float
    }

        with
        static member ToRequest(req: UpdateByQueryRethrottleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_update_by_query/{req.TaskId}/_rethrottle"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type UpdateByQueryRethrottleResponse = System.Text.Json.JsonElement

    type UpdateByQueryRethrottleRequestBuilder() =
        member _.Yield(_: unit) : UpdateByQueryRethrottleRequest =
            {
                TaskId = Unchecked.defaultof<_>
                RequestsPerSecond = Unchecked.defaultof<_>
            }

        [<CustomOperation("taskId")>]
        member _.TaskId(state: UpdateByQueryRethrottleRequest, value: CoreTypes.Id) =
            { state with TaskId = value }

        [<CustomOperation("requestsPerSecond")>]
        member _.RequestsPerSecond(state: UpdateByQueryRethrottleRequest, value: CoreTypes.Float) =
            { state with RequestsPerSecond = value }

    let updateByQueryRethrottleRequest = UpdateByQueryRethrottleRequestBuilder()

    module UpdateByQueryRethrottle =
        let withRequestsPerSecond (value: CoreTypes.Float) (req: UpdateByQueryRethrottleRequest) =
            { req with RequestsPerSecond = value }


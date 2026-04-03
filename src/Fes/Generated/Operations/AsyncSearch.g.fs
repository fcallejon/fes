// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module AsyncSearchOperations =

    type AsyncSearchDeleteRequest = {
        Id: Types.Id
    }

        with
        static member ToRequest(req: AsyncSearchDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_async_search/{req.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type AsyncSearchDeleteResponse = Types.AcknowledgedResponseBase

    type AsyncSearchDeleteRequestBuilder() =
        member _.Yield(_: unit) : AsyncSearchDeleteRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: AsyncSearchDeleteRequest, value: Types.Id) =
            { state with Id = value }

    let asyncSearchDeleteRequest = AsyncSearchDeleteRequestBuilder()

    type AsyncSearchGetRequest = {
        Id: Types.Id
        KeepAlive: Types.Duration option
        TypedKeys: bool option
        WaitForCompletionTimeout: Types.Duration option
        ReturnIntermediateResults: bool option
    }

        with
        static member ToRequest(req: AsyncSearchGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_async_search/{req.Id}"
                let queryParams =
                    [
                        req.KeepAlive |> Option.map (fun v -> "keep_alive", Fes.Http.toQueryValue v)
                        req.TypedKeys |> Option.map (fun v -> "typed_keys", Fes.Http.toQueryValue v)
                        req.WaitForCompletionTimeout |> Option.map (fun v -> "wait_for_completion_timeout", Fes.Http.toQueryValue v)
                        req.ReturnIntermediateResults |> Option.map (fun v -> "return_intermediate_results", Fes.Http.toQueryValue v)
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

    type AsyncSearchGetResponse<'tDocument> = Types.AsyncSearchDocumentResponseBase<'tDocument>

    type AsyncSearchGetRequestBuilder() =
        member _.Yield(_: unit) : AsyncSearchGetRequest =
            {
                Id = Unchecked.defaultof<_>
                KeepAlive = None
                TypedKeys = None
                WaitForCompletionTimeout = None
                ReturnIntermediateResults = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: AsyncSearchGetRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("keepAlive")>]
        member _.KeepAlive(state: AsyncSearchGetRequest, value: Types.Duration) =
            { state with KeepAlive = Some value }

        [<CustomOperation("typedKeys")>]
        member _.TypedKeys(state: AsyncSearchGetRequest, value: bool) =
            { state with TypedKeys = Some value }

        [<CustomOperation("waitForCompletionTimeout")>]
        member _.WaitForCompletionTimeout(state: AsyncSearchGetRequest, value: Types.Duration) =
            { state with WaitForCompletionTimeout = Some value }

        [<CustomOperation("returnIntermediateResults")>]
        member _.ReturnIntermediateResults(state: AsyncSearchGetRequest, value: bool) =
            { state with ReturnIntermediateResults = Some value }

    let asyncSearchGetRequest = AsyncSearchGetRequestBuilder()

    module Get =
        let withKeepAlive (value: Types.Duration) (req: AsyncSearchGetRequest) =
            { req with KeepAlive = Some value }
        let withTypedKeys (value: bool) (req: AsyncSearchGetRequest) =
            { req with TypedKeys = Some value }
        let withWaitForCompletionTimeout (value: Types.Duration) (req: AsyncSearchGetRequest) =
            { req with WaitForCompletionTimeout = Some value }
        let withReturnIntermediateResults (value: bool) (req: AsyncSearchGetRequest) =
            { req with ReturnIntermediateResults = Some value }

    type AsyncSearchStatusRequest = {
        Id: Types.Id
        KeepAlive: Types.Duration option
    }

        with
        static member ToRequest(req: AsyncSearchStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_async_search/status/{req.Id}"
                let queryParams =
                    [
                        req.KeepAlive |> Option.map (fun v -> "keep_alive", Fes.Http.toQueryValue v)
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

    type AsyncSearchStatusResponse = Types.StatusResponseBase

    type AsyncSearchStatusRequestBuilder() =
        member _.Yield(_: unit) : AsyncSearchStatusRequest =
            {
                Id = Unchecked.defaultof<_>
                KeepAlive = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: AsyncSearchStatusRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("keepAlive")>]
        member _.KeepAlive(state: AsyncSearchStatusRequest, value: Types.Duration) =
            { state with KeepAlive = Some value }

    let asyncSearchStatusRequest = AsyncSearchStatusRequestBuilder()

    module Status =
        let withKeepAlive (value: Types.Duration) (req: AsyncSearchStatusRequest) =
            { req with KeepAlive = Some value }

    type AsyncSearchSubmitRequest = {
        Index: Types.Indices
        WaitForCompletionTimeout: Types.Duration option
        KeepAlive: Types.Duration option
        KeepOnCompletion: bool option
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
        Lenient: bool option
        MaxConcurrentShardRequests: Types.Integer option
        Preference: string option
        RequestCache: bool option
        Routing: Types.Routing option
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
        SourceIncludes: Types.Fields option
        SeqNoPrimaryTerm: bool option
        Q: string option
        Size: Types.Integer option
        From: Types.Integer option
        Sort: System.Text.Json.JsonElement option
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
        static member ToRequest(req: AsyncSearchSubmitRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_async_search"
                let queryParams =
                    [
                        req.WaitForCompletionTimeout |> Option.map (fun v -> "wait_for_completion_timeout", Fes.Http.toQueryValue v)
                        req.KeepAlive |> Option.map (fun v -> "keep_alive", Fes.Http.toQueryValue v)
                        req.KeepOnCompletion |> Option.map (fun v -> "keep_on_completion", Fes.Http.toQueryValue v)
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
                        req.Lenient |> Option.map (fun v -> "lenient", Fes.Http.toQueryValue v)
                        req.MaxConcurrentShardRequests |> Option.map (fun v -> "max_concurrent_shard_requests", Fes.Http.toQueryValue v)
                        req.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                        req.RequestCache |> Option.map (fun v -> "request_cache", Fes.Http.toQueryValue v)
                        req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
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
                        req.SourceIncludes |> Option.map (fun v -> "_source_includes", Fes.Http.toQueryValue v)
                        req.SeqNoPrimaryTerm |> Option.map (fun v -> "seq_no_primary_term", Fes.Http.toQueryValue v)
                        req.Q |> Option.map (fun v -> "q", Fes.Http.toQueryValue v)
                        req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                        req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        req.Sort |> Option.map (fun v -> "sort", Fes.Http.toQueryValue v)
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

    type AsyncSearchSubmitResponse<'tDocument> = Types.AsyncSearchDocumentResponseBase<'tDocument>

    type AsyncSearchSubmitRequestBuilder() =
        member _.Yield(_: unit) : AsyncSearchSubmitRequest =
            {
                Index = Unchecked.defaultof<_>
                WaitForCompletionTimeout = None
                KeepAlive = None
                KeepOnCompletion = None
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
                Lenient = None
                MaxConcurrentShardRequests = None
                Preference = None
                RequestCache = None
                Routing = None
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
                SourceIncludes = None
                SeqNoPrimaryTerm = None
                Q = None
                Size = None
                From = None
                Sort = None
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
                MinScore = None
                PostFilter = None
                Profile = None
                Query = None
                Rescore = None
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
        member _.Index(state: AsyncSearchSubmitRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("waitForCompletionTimeout")>]
        member _.WaitForCompletionTimeout(state: AsyncSearchSubmitRequest, value: Types.Duration) =
            { state with WaitForCompletionTimeout = Some value }

        [<CustomOperation("keepAlive")>]
        member _.KeepAlive(state: AsyncSearchSubmitRequest, value: Types.Duration) =
            { state with KeepAlive = Some value }

        [<CustomOperation("keepOnCompletion")>]
        member _.KeepOnCompletion(state: AsyncSearchSubmitRequest, value: bool) =
            { state with KeepOnCompletion = Some value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: AsyncSearchSubmitRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("allowPartialSearchResults")>]
        member _.AllowPartialSearchResults(state: AsyncSearchSubmitRequest, value: bool) =
            { state with AllowPartialSearchResults = Some value }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: AsyncSearchSubmitRequest, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("analyzeWildcard")>]
        member _.AnalyzeWildcard(state: AsyncSearchSubmitRequest, value: bool) =
            { state with AnalyzeWildcard = Some value }

        [<CustomOperation("batchedReduceSize")>]
        member _.BatchedReduceSize(state: AsyncSearchSubmitRequest, value: Types.Long) =
            { state with BatchedReduceSize = Some value }

        [<CustomOperation("ccsMinimizeRoundtrips")>]
        member _.CcsMinimizeRoundtrips(state: AsyncSearchSubmitRequest, value: bool) =
            { state with CcsMinimizeRoundtrips = Some value }

        [<CustomOperation("defaultOperator")>]
        member _.DefaultOperator(state: AsyncSearchSubmitRequest, value: Types.Operator) =
            { state with DefaultOperator = Some value }

        [<CustomOperation("df")>]
        member _.Df(state: AsyncSearchSubmitRequest, value: string) =
            { state with Df = Some value }

        [<CustomOperation("docvalueFields")>]
        member _.DocvalueFields(state: AsyncSearchSubmitRequest, value: Types.Fields) =
            { state with DocvalueFields = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: AsyncSearchSubmitRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("explain")>]
        member _.Explain(state: AsyncSearchSubmitRequest, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("ignoreThrottled")>]
        member _.IgnoreThrottled(state: AsyncSearchSubmitRequest, value: bool) =
            { state with IgnoreThrottled = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: AsyncSearchSubmitRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("lenient")>]
        member _.Lenient(state: AsyncSearchSubmitRequest, value: bool) =
            { state with Lenient = Some value }

        [<CustomOperation("maxConcurrentShardRequests")>]
        member _.MaxConcurrentShardRequests(state: AsyncSearchSubmitRequest, value: Types.Integer) =
            { state with MaxConcurrentShardRequests = Some value }

        [<CustomOperation("preference")>]
        member _.Preference(state: AsyncSearchSubmitRequest, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("requestCache")>]
        member _.RequestCache(state: AsyncSearchSubmitRequest, value: bool) =
            { state with RequestCache = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: AsyncSearchSubmitRequest, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("searchType")>]
        member _.SearchType(state: AsyncSearchSubmitRequest, value: Types.SearchType) =
            { state with SearchType = Some value }

        [<CustomOperation("stats")>]
        member _.Stats(state: AsyncSearchSubmitRequest, value: string list) =
            { state with Stats = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: AsyncSearchSubmitRequest, value: Types.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("suggestField")>]
        member _.SuggestField(state: AsyncSearchSubmitRequest, value: Types.Field) =
            { state with SuggestField = Some value }

        [<CustomOperation("suggestMode")>]
        member _.SuggestMode(state: AsyncSearchSubmitRequest, value: Types.SuggestMode) =
            { state with SuggestMode = Some value }

        [<CustomOperation("suggestSize")>]
        member _.SuggestSize(state: AsyncSearchSubmitRequest, value: Types.Long) =
            { state with SuggestSize = Some value }

        [<CustomOperation("suggestText")>]
        member _.SuggestText(state: AsyncSearchSubmitRequest, value: string) =
            { state with SuggestText = Some value }

        [<CustomOperation("terminateAfter")>]
        member _.TerminateAfter(state: AsyncSearchSubmitRequest, value: Types.Long) =
            { state with TerminateAfter = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: AsyncSearchSubmitRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("trackTotalHits")>]
        member _.TrackTotalHits(state: AsyncSearchSubmitRequest, value: Types.TrackHits) =
            { state with TrackTotalHits = Some value }

        [<CustomOperation("trackScores")>]
        member _.TrackScores(state: AsyncSearchSubmitRequest, value: bool) =
            { state with TrackScores = Some value }

        [<CustomOperation("typedKeys")>]
        member _.TypedKeys(state: AsyncSearchSubmitRequest, value: bool) =
            { state with TypedKeys = Some value }

        [<CustomOperation("restTotalHitsAsInt")>]
        member _.RestTotalHitsAsInt(state: AsyncSearchSubmitRequest, value: bool) =
            { state with RestTotalHitsAsInt = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: AsyncSearchSubmitRequest, value: bool) =
            { state with Version = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: AsyncSearchSubmitRequest, value: Types.SourceConfigParam) =
            { state with Source = Some value }

        [<CustomOperation("sourceExcludes")>]
        member _.SourceExcludes(state: AsyncSearchSubmitRequest, value: Types.Fields) =
            { state with SourceExcludes = Some value }

        [<CustomOperation("sourceIncludes")>]
        member _.SourceIncludes(state: AsyncSearchSubmitRequest, value: Types.Fields) =
            { state with SourceIncludes = Some value }

        [<CustomOperation("seqNoPrimaryTerm")>]
        member _.SeqNoPrimaryTerm(state: AsyncSearchSubmitRequest, value: bool) =
            { state with SeqNoPrimaryTerm = Some value }

        [<CustomOperation("q")>]
        member _.Q(state: AsyncSearchSubmitRequest, value: string) =
            { state with Q = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: AsyncSearchSubmitRequest, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("from")>]
        member _.From(state: AsyncSearchSubmitRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: AsyncSearchSubmitRequest, value: System.Text.Json.JsonElement) =
            { state with Sort = Some value }

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: AsyncSearchSubmitRequest, value: Map<string, Types.AggregationContainer>) =
            { state with Aggregations = Some value }

        [<CustomOperation("collapse")>]
        member _.Collapse(state: AsyncSearchSubmitRequest, value: Types.FieldCollapse) =
            { state with Collapse = Some value }

        [<CustomOperation("explain")>]
        member _.Explain(state: AsyncSearchSubmitRequest, value: bool) =
            { state with bodyExplain = Some value }

        [<CustomOperation("ext")>]
        member _.Ext(state: AsyncSearchSubmitRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Ext = Some value }

        [<CustomOperation("from")>]
        member _.From(state: AsyncSearchSubmitRequest, value: Types.Integer) =
            { state with bodyFrom = Some value }

        [<CustomOperation("highlight")>]
        member _.Highlight(state: AsyncSearchSubmitRequest, value: Types.Highlight) =
            { state with Highlight = Some value }

        [<CustomOperation("trackTotalHits")>]
        member _.TrackTotalHits(state: AsyncSearchSubmitRequest, value: Types.TrackHits) =
            { state with bodyTrackTotalHits = Some value }

        [<CustomOperation("indicesBoost")>]
        member _.IndicesBoost(state: AsyncSearchSubmitRequest, value: Map<Types.IndexName, Types.Double> list) =
            { state with IndicesBoost = Some value }

        [<CustomOperation("docvalueFields")>]
        member _.DocvalueFields(state: AsyncSearchSubmitRequest, value: Types.FieldAndFormat list) =
            { state with bodyDocvalueFields = Some value }

        [<CustomOperation("knn")>]
        member _.Knn(state: AsyncSearchSubmitRequest, value: System.Text.Json.JsonElement) =
            { state with Knn = Some value }

        [<CustomOperation("minScore")>]
        member _.MinScore(state: AsyncSearchSubmitRequest, value: Types.Double) =
            { state with MinScore = Some value }

        [<CustomOperation("postFilter")>]
        member _.PostFilter(state: AsyncSearchSubmitRequest, value: Types.QueryContainer) =
            { state with PostFilter = Some value }

        [<CustomOperation("profile")>]
        member _.Profile(state: AsyncSearchSubmitRequest, value: bool) =
            { state with Profile = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: AsyncSearchSubmitRequest, value: Types.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("rescore")>]
        member _.Rescore(state: AsyncSearchSubmitRequest, value: System.Text.Json.JsonElement) =
            { state with Rescore = Some value }

        [<CustomOperation("scriptFields")>]
        member _.ScriptFields(state: AsyncSearchSubmitRequest, value: Map<string, Types.ScriptField>) =
            { state with ScriptFields = Some value }

        [<CustomOperation("searchAfter")>]
        member _.SearchAfter(state: AsyncSearchSubmitRequest, value: Types.SortResults) =
            { state with SearchAfter = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: AsyncSearchSubmitRequest, value: Types.Integer) =
            { state with bodySize = Some value }

        [<CustomOperation("slice")>]
        member _.Slice(state: AsyncSearchSubmitRequest, value: Types.SlicedScroll) =
            { state with Slice = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: AsyncSearchSubmitRequest, value: Types.Sort) =
            { state with bodySort = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: AsyncSearchSubmitRequest, value: Types.SourceConfig) =
            { state with bodySource = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: AsyncSearchSubmitRequest, value: Types.FieldAndFormat list) =
            { state with Fields = Some value }

        [<CustomOperation("suggest")>]
        member _.Suggest(state: AsyncSearchSubmitRequest, value: Types.Suggester) =
            { state with Suggest = Some value }

        [<CustomOperation("terminateAfter")>]
        member _.TerminateAfter(state: AsyncSearchSubmitRequest, value: Types.Long) =
            { state with bodyTerminateAfter = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: AsyncSearchSubmitRequest, value: string) =
            { state with bodyTimeout = Some value }

        [<CustomOperation("trackScores")>]
        member _.TrackScores(state: AsyncSearchSubmitRequest, value: bool) =
            { state with bodyTrackScores = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: AsyncSearchSubmitRequest, value: bool) =
            { state with bodyVersion = Some value }

        [<CustomOperation("seqNoPrimaryTerm")>]
        member _.SeqNoPrimaryTerm(state: AsyncSearchSubmitRequest, value: bool) =
            { state with bodySeqNoPrimaryTerm = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: AsyncSearchSubmitRequest, value: Types.Fields) =
            { state with bodyStoredFields = Some value }

        [<CustomOperation("pit")>]
        member _.Pit(state: AsyncSearchSubmitRequest, value: Types.PointInTimeReference) =
            { state with Pit = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: AsyncSearchSubmitRequest, value: Types.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("stats")>]
        member _.Stats(state: AsyncSearchSubmitRequest, value: string list) =
            { state with bodyStats = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: AsyncSearchSubmitRequest, value: Types.ProjectRouting) =
            { state with ProjectRouting = Some value }

    let asyncSearchSubmitRequest = AsyncSearchSubmitRequestBuilder()

    module Submit =
        let withWaitForCompletionTimeout (value: Types.Duration) (req: AsyncSearchSubmitRequest) =
            { req with WaitForCompletionTimeout = Some value }
        let withKeepAlive (value: Types.Duration) (req: AsyncSearchSubmitRequest) =
            { req with KeepAlive = Some value }
        let withKeepOnCompletion (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with KeepOnCompletion = Some value }
        let withAllowNoIndices (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with AllowNoIndices = Some value }
        let withAllowPartialSearchResults (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with AllowPartialSearchResults = Some value }
        let withAnalyzer (value: string) (req: AsyncSearchSubmitRequest) =
            { req with Analyzer = Some value }
        let withAnalyzeWildcard (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with AnalyzeWildcard = Some value }
        let withBatchedReduceSize (value: Types.Long) (req: AsyncSearchSubmitRequest) =
            { req with BatchedReduceSize = Some value }
        let withCcsMinimizeRoundtrips (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with CcsMinimizeRoundtrips = Some value }
        let withDefaultOperator (value: Types.Operator) (req: AsyncSearchSubmitRequest) =
            { req with DefaultOperator = Some value }
        let withDf (value: string) (req: AsyncSearchSubmitRequest) =
            { req with Df = Some value }
        let withDocvalueFields (value: Types.Fields) (req: AsyncSearchSubmitRequest) =
            { req with bodyDocvalueFields = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: AsyncSearchSubmitRequest) =
            { req with ExpandWildcards = Some value }
        let withExplain (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with bodyExplain = Some value }
        let withIgnoreThrottled (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with IgnoreThrottled = Some value }
        let withIgnoreUnavailable (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with IgnoreUnavailable = Some value }
        let withLenient (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with Lenient = Some value }
        let withMaxConcurrentShardRequests (value: Types.Integer) (req: AsyncSearchSubmitRequest) =
            { req with MaxConcurrentShardRequests = Some value }
        let withPreference (value: string) (req: AsyncSearchSubmitRequest) =
            { req with Preference = Some value }
        let withRequestCache (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with RequestCache = Some value }
        let withRouting (value: Types.Routing) (req: AsyncSearchSubmitRequest) =
            { req with Routing = Some value }
        let withSearchType (value: Types.SearchType) (req: AsyncSearchSubmitRequest) =
            { req with SearchType = Some value }
        let withStats (value: string list) (req: AsyncSearchSubmitRequest) =
            { req with bodyStats = Some value }
        let withStoredFields (value: Types.Fields) (req: AsyncSearchSubmitRequest) =
            { req with bodyStoredFields = Some value }
        let withSuggestField (value: Types.Field) (req: AsyncSearchSubmitRequest) =
            { req with SuggestField = Some value }
        let withSuggestMode (value: Types.SuggestMode) (req: AsyncSearchSubmitRequest) =
            { req with SuggestMode = Some value }
        let withSuggestSize (value: Types.Long) (req: AsyncSearchSubmitRequest) =
            { req with SuggestSize = Some value }
        let withSuggestText (value: string) (req: AsyncSearchSubmitRequest) =
            { req with SuggestText = Some value }
        let withTerminateAfter (value: Types.Long) (req: AsyncSearchSubmitRequest) =
            { req with bodyTerminateAfter = Some value }
        let withTimeout (value: Types.Duration) (req: AsyncSearchSubmitRequest) =
            { req with bodyTimeout = Some value }
        let withTrackTotalHits (value: Types.TrackHits) (req: AsyncSearchSubmitRequest) =
            { req with bodyTrackTotalHits = Some value }
        let withTrackScores (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with bodyTrackScores = Some value }
        let withTypedKeys (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with TypedKeys = Some value }
        let withRestTotalHitsAsInt (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with RestTotalHitsAsInt = Some value }
        let withVersion (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with bodyVersion = Some value }
        let withSource (value: Types.SourceConfigParam) (req: AsyncSearchSubmitRequest) =
            { req with bodySource = Some value }
        let withSourceExcludes (value: Types.Fields) (req: AsyncSearchSubmitRequest) =
            { req with SourceExcludes = Some value }
        let withSourceIncludes (value: Types.Fields) (req: AsyncSearchSubmitRequest) =
            { req with SourceIncludes = Some value }
        let withSeqNoPrimaryTerm (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with bodySeqNoPrimaryTerm = Some value }
        let withQ (value: string) (req: AsyncSearchSubmitRequest) =
            { req with Q = Some value }
        let withSize (value: Types.Integer) (req: AsyncSearchSubmitRequest) =
            { req with bodySize = Some value }
        let withFrom (value: Types.Integer) (req: AsyncSearchSubmitRequest) =
            { req with bodyFrom = Some value }
        let withSort (value: System.Text.Json.JsonElement) (req: AsyncSearchSubmitRequest) =
            { req with bodySort = Some value }
        let withAggregations (value: Map<string, Types.AggregationContainer>) (req: AsyncSearchSubmitRequest) =
            { req with Aggregations = Some value }
        let withCollapse (value: Types.FieldCollapse) (req: AsyncSearchSubmitRequest) =
            { req with Collapse = Some value }
        let withExplain (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with bodyExplain = Some value }
        let withExt (value: Map<string, System.Text.Json.JsonElement>) (req: AsyncSearchSubmitRequest) =
            { req with Ext = Some value }
        let withFrom (value: Types.Integer) (req: AsyncSearchSubmitRequest) =
            { req with bodyFrom = Some value }
        let withHighlight (value: Types.Highlight) (req: AsyncSearchSubmitRequest) =
            { req with Highlight = Some value }
        let withTrackTotalHits (value: Types.TrackHits) (req: AsyncSearchSubmitRequest) =
            { req with bodyTrackTotalHits = Some value }
        let withIndicesBoost (value: Map<Types.IndexName, Types.Double> list) (req: AsyncSearchSubmitRequest) =
            { req with IndicesBoost = Some value }
        let withDocvalueFields (value: Types.FieldAndFormat list) (req: AsyncSearchSubmitRequest) =
            { req with bodyDocvalueFields = Some value }
        let withKnn (value: System.Text.Json.JsonElement) (req: AsyncSearchSubmitRequest) =
            { req with Knn = Some value }
        let withMinScore (value: Types.Double) (req: AsyncSearchSubmitRequest) =
            { req with MinScore = Some value }
        let withPostFilter (value: Types.QueryContainer) (req: AsyncSearchSubmitRequest) =
            { req with PostFilter = Some value }
        let withProfile (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with Profile = Some value }
        let withQuery (value: Types.QueryContainer) (req: AsyncSearchSubmitRequest) =
            { req with Query = Some value }
        let withRescore (value: System.Text.Json.JsonElement) (req: AsyncSearchSubmitRequest) =
            { req with Rescore = Some value }
        let withScriptFields (value: Map<string, Types.ScriptField>) (req: AsyncSearchSubmitRequest) =
            { req with ScriptFields = Some value }
        let withSearchAfter (value: Types.SortResults) (req: AsyncSearchSubmitRequest) =
            { req with SearchAfter = Some value }
        let withSize (value: Types.Integer) (req: AsyncSearchSubmitRequest) =
            { req with bodySize = Some value }
        let withSlice (value: Types.SlicedScroll) (req: AsyncSearchSubmitRequest) =
            { req with Slice = Some value }
        let withSort (value: Types.Sort) (req: AsyncSearchSubmitRequest) =
            { req with bodySort = Some value }
        let withSource (value: Types.SourceConfig) (req: AsyncSearchSubmitRequest) =
            { req with bodySource = Some value }
        let withFields (value: Types.FieldAndFormat list) (req: AsyncSearchSubmitRequest) =
            { req with Fields = Some value }
        let withSuggest (value: Types.Suggester) (req: AsyncSearchSubmitRequest) =
            { req with Suggest = Some value }
        let withTerminateAfter (value: Types.Long) (req: AsyncSearchSubmitRequest) =
            { req with bodyTerminateAfter = Some value }
        let withTimeout (value: string) (req: AsyncSearchSubmitRequest) =
            { req with bodyTimeout = Some value }
        let withTrackScores (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with bodyTrackScores = Some value }
        let withVersion (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with bodyVersion = Some value }
        let withSeqNoPrimaryTerm (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with bodySeqNoPrimaryTerm = Some value }
        let withStoredFields (value: Types.Fields) (req: AsyncSearchSubmitRequest) =
            { req with bodyStoredFields = Some value }
        let withPit (value: Types.PointInTimeReference) (req: AsyncSearchSubmitRequest) =
            { req with Pit = Some value }
        let withRuntimeMappings (value: Types.RuntimeFields) (req: AsyncSearchSubmitRequest) =
            { req with RuntimeMappings = Some value }
        let withStats (value: string list) (req: AsyncSearchSubmitRequest) =
            { req with bodyStats = Some value }
        let withProjectRouting (value: Types.ProjectRouting) (req: AsyncSearchSubmitRequest) =
            { req with ProjectRouting = Some value }


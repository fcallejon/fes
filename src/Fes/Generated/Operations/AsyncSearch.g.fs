// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module AsyncSearchOperations =

    type AsyncSearchDeleteRequest = {
        Id: CoreTypes.Id
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

    type AsyncSearchDeleteResponse = CoreTypes.AcknowledgedResponseBase

    type AsyncSearchDeleteRequestBuilder() =
        member _.Yield(_: unit) : AsyncSearchDeleteRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: AsyncSearchDeleteRequest, value: CoreTypes.Id) =
            { state with Id = value }

    let asyncSearchDeleteRequest = AsyncSearchDeleteRequestBuilder()

    type AsyncSearchGetRequest = {
        Id: CoreTypes.Id
        KeepAlive: CoreTypes.Duration option
        TypedKeys: bool option
        WaitForCompletionTimeout: CoreTypes.Duration option
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

    type AsyncSearchGetResponse = AsyncSearchTypes.AsyncSearchDocumentResponseBase<AsyncSearchGetResponse.TDocument>

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
        member _.Id(state: AsyncSearchGetRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("keepAlive")>]
        member _.KeepAlive(state: AsyncSearchGetRequest, value: CoreTypes.Duration) =
            { state with KeepAlive = Some value }

        [<CustomOperation("typedKeys")>]
        member _.TypedKeys(state: AsyncSearchGetRequest, value: bool) =
            { state with TypedKeys = Some value }

        [<CustomOperation("waitForCompletionTimeout")>]
        member _.WaitForCompletionTimeout(state: AsyncSearchGetRequest, value: CoreTypes.Duration) =
            { state with WaitForCompletionTimeout = Some value }

        [<CustomOperation("returnIntermediateResults")>]
        member _.ReturnIntermediateResults(state: AsyncSearchGetRequest, value: bool) =
            { state with ReturnIntermediateResults = Some value }

    let asyncSearchGetRequest = AsyncSearchGetRequestBuilder()

    module Get =
        let withKeepAlive (value: CoreTypes.Duration) (req: AsyncSearchGetRequest) =
            { req with KeepAlive = Some value }
        let withTypedKeys (value: bool) (req: AsyncSearchGetRequest) =
            { req with TypedKeys = Some value }
        let withWaitForCompletionTimeout (value: CoreTypes.Duration) (req: AsyncSearchGetRequest) =
            { req with WaitForCompletionTimeout = Some value }
        let withReturnIntermediateResults (value: bool) (req: AsyncSearchGetRequest) =
            { req with ReturnIntermediateResults = Some value }

    type AsyncSearchStatusRequest = {
        Id: CoreTypes.Id
        KeepAlive: CoreTypes.Duration option
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

    type AsyncSearchStatusResponse = AsyncSearchStatus.StatusResponseBase

    type AsyncSearchStatusRequestBuilder() =
        member _.Yield(_: unit) : AsyncSearchStatusRequest =
            {
                Id = Unchecked.defaultof<_>
                KeepAlive = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: AsyncSearchStatusRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("keepAlive")>]
        member _.KeepAlive(state: AsyncSearchStatusRequest, value: CoreTypes.Duration) =
            { state with KeepAlive = Some value }

    let asyncSearchStatusRequest = AsyncSearchStatusRequestBuilder()

    module Status =
        let withKeepAlive (value: CoreTypes.Duration) (req: AsyncSearchStatusRequest) =
            { req with KeepAlive = Some value }

    type AsyncSearchSubmitRequest = {
        Index: CoreTypes.Indices
        WaitForCompletionTimeout: CoreTypes.Duration option
        KeepAlive: CoreTypes.Duration option
        KeepOnCompletion: bool option
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
        Lenient: bool option
        MaxConcurrentShardRequests: CoreTypes.Integer option
        Preference: string option
        RequestCache: bool option
        Routing: CoreTypes.Routing option
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
        SourceIncludes: CoreTypes.Fields option
        SeqNoPrimaryTerm: bool option
        Q: string option
        Size: CoreTypes.Integer option
        From: CoreTypes.Integer option
        Sort: System.Text.Json.JsonElement option
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
        MinScore: CoreTypes.Double option
        PostFilter: CoreTypes.QueryContainer option
        Profile: bool option
        Query: CoreTypes.QueryContainer option
        Rescore: System.Text.Json.JsonElement option
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

    type AsyncSearchSubmitResponse = AsyncSearchTypes.AsyncSearchDocumentResponseBase<AsyncSearchSubmitResponse.TDocument>

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
                Explain = None
                Ext = None
                From = None
                Highlight = None
                TrackTotalHits = None
                IndicesBoost = None
                DocvalueFields = None
                Knn = None
                MinScore = None
                PostFilter = None
                Profile = None
                Query = None
                Rescore = None
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
        member _.Index(state: AsyncSearchSubmitRequest, value: CoreTypes.Indices) =
            { state with Index = value }

        [<CustomOperation("waitForCompletionTimeout")>]
        member _.WaitForCompletionTimeout(state: AsyncSearchSubmitRequest, value: CoreTypes.Duration) =
            { state with WaitForCompletionTimeout = Some value }

        [<CustomOperation("keepAlive")>]
        member _.KeepAlive(state: AsyncSearchSubmitRequest, value: CoreTypes.Duration) =
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
        member _.BatchedReduceSize(state: AsyncSearchSubmitRequest, value: CoreTypes.Long) =
            { state with BatchedReduceSize = Some value }

        [<CustomOperation("ccsMinimizeRoundtrips")>]
        member _.CcsMinimizeRoundtrips(state: AsyncSearchSubmitRequest, value: bool) =
            { state with CcsMinimizeRoundtrips = Some value }

        [<CustomOperation("defaultOperator")>]
        member _.DefaultOperator(state: AsyncSearchSubmitRequest, value: CoreTypes.Operator) =
            { state with DefaultOperator = Some value }

        [<CustomOperation("df")>]
        member _.Df(state: AsyncSearchSubmitRequest, value: string) =
            { state with Df = Some value }

        [<CustomOperation("docvalueFields")>]
        member _.DocvalueFields(state: AsyncSearchSubmitRequest, value: CoreTypes.Fields) =
            { state with DocvalueFields = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: AsyncSearchSubmitRequest, value: CoreTypes.ExpandWildcards) =
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
        member _.MaxConcurrentShardRequests(state: AsyncSearchSubmitRequest, value: CoreTypes.Integer) =
            { state with MaxConcurrentShardRequests = Some value }

        [<CustomOperation("preference")>]
        member _.Preference(state: AsyncSearchSubmitRequest, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("requestCache")>]
        member _.RequestCache(state: AsyncSearchSubmitRequest, value: bool) =
            { state with RequestCache = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: AsyncSearchSubmitRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("searchType")>]
        member _.SearchType(state: AsyncSearchSubmitRequest, value: CoreTypes.SearchType) =
            { state with SearchType = Some value }

        [<CustomOperation("stats")>]
        member _.Stats(state: AsyncSearchSubmitRequest, value: string list) =
            { state with Stats = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: AsyncSearchSubmitRequest, value: CoreTypes.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("suggestField")>]
        member _.SuggestField(state: AsyncSearchSubmitRequest, value: CoreTypes.Field) =
            { state with SuggestField = Some value }

        [<CustomOperation("suggestMode")>]
        member _.SuggestMode(state: AsyncSearchSubmitRequest, value: CoreTypes.SuggestMode) =
            { state with SuggestMode = Some value }

        [<CustomOperation("suggestSize")>]
        member _.SuggestSize(state: AsyncSearchSubmitRequest, value: CoreTypes.Long) =
            { state with SuggestSize = Some value }

        [<CustomOperation("suggestText")>]
        member _.SuggestText(state: AsyncSearchSubmitRequest, value: string) =
            { state with SuggestText = Some value }

        [<CustomOperation("terminateAfter")>]
        member _.TerminateAfter(state: AsyncSearchSubmitRequest, value: CoreTypes.Long) =
            { state with TerminateAfter = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: AsyncSearchSubmitRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("trackTotalHits")>]
        member _.TrackTotalHits(state: AsyncSearchSubmitRequest, value: GlobalSearchTypes.TrackHits) =
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
        member _.Source(state: AsyncSearchSubmitRequest, value: GlobalSearchTypes.SourceConfigParam) =
            { state with Source = Some value }

        [<CustomOperation("sourceExcludes")>]
        member _.SourceExcludes(state: AsyncSearchSubmitRequest, value: CoreTypes.Fields) =
            { state with SourceExcludes = Some value }

        [<CustomOperation("sourceIncludes")>]
        member _.SourceIncludes(state: AsyncSearchSubmitRequest, value: CoreTypes.Fields) =
            { state with SourceIncludes = Some value }

        [<CustomOperation("seqNoPrimaryTerm")>]
        member _.SeqNoPrimaryTerm(state: AsyncSearchSubmitRequest, value: bool) =
            { state with SeqNoPrimaryTerm = Some value }

        [<CustomOperation("q")>]
        member _.Q(state: AsyncSearchSubmitRequest, value: string) =
            { state with Q = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: AsyncSearchSubmitRequest, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("from")>]
        member _.From(state: AsyncSearchSubmitRequest, value: CoreTypes.Integer) =
            { state with From = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: AsyncSearchSubmitRequest, value: System.Text.Json.JsonElement) =
            { state with Sort = Some value }

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: AsyncSearchSubmitRequest, value: Map<string, CoreTypes.AggregationContainer>) =
            { state with Aggregations = Some value }

        [<CustomOperation("collapse")>]
        member _.Collapse(state: AsyncSearchSubmitRequest, value: GlobalSearchTypes.FieldCollapse) =
            { state with Collapse = Some value }

        [<CustomOperation("explain")>]
        member _.Explain(state: AsyncSearchSubmitRequest, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("ext")>]
        member _.Ext(state: AsyncSearchSubmitRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Ext = Some value }

        [<CustomOperation("from")>]
        member _.From(state: AsyncSearchSubmitRequest, value: CoreTypes.Integer) =
            { state with From = Some value }

        [<CustomOperation("highlight")>]
        member _.Highlight(state: AsyncSearchSubmitRequest, value: GlobalSearchTypes.Highlight) =
            { state with Highlight = Some value }

        [<CustomOperation("trackTotalHits")>]
        member _.TrackTotalHits(state: AsyncSearchSubmitRequest, value: GlobalSearchTypes.TrackHits) =
            { state with TrackTotalHits = Some value }

        [<CustomOperation("indicesBoost")>]
        member _.IndicesBoost(state: AsyncSearchSubmitRequest, value: Map<CoreTypes.IndexName, CoreTypes.Double> list) =
            { state with IndicesBoost = Some value }

        [<CustomOperation("docvalueFields")>]
        member _.DocvalueFields(state: AsyncSearchSubmitRequest, value: CoreTypes.FieldAndFormat list) =
            { state with DocvalueFields = Some value }

        [<CustomOperation("knn")>]
        member _.Knn(state: AsyncSearchSubmitRequest, value: System.Text.Json.JsonElement) =
            { state with Knn = Some value }

        [<CustomOperation("minScore")>]
        member _.MinScore(state: AsyncSearchSubmitRequest, value: CoreTypes.Double) =
            { state with MinScore = Some value }

        [<CustomOperation("postFilter")>]
        member _.PostFilter(state: AsyncSearchSubmitRequest, value: CoreTypes.QueryContainer) =
            { state with PostFilter = Some value }

        [<CustomOperation("profile")>]
        member _.Profile(state: AsyncSearchSubmitRequest, value: bool) =
            { state with Profile = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: AsyncSearchSubmitRequest, value: CoreTypes.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("rescore")>]
        member _.Rescore(state: AsyncSearchSubmitRequest, value: System.Text.Json.JsonElement) =
            { state with Rescore = Some value }

        [<CustomOperation("scriptFields")>]
        member _.ScriptFields(state: AsyncSearchSubmitRequest, value: Map<string, CoreTypes.ScriptField>) =
            { state with ScriptFields = Some value }

        [<CustomOperation("searchAfter")>]
        member _.SearchAfter(state: AsyncSearchSubmitRequest, value: CoreTypes.SortResults) =
            { state with SearchAfter = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: AsyncSearchSubmitRequest, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("slice")>]
        member _.Slice(state: AsyncSearchSubmitRequest, value: CoreTypes.SlicedScroll) =
            { state with Slice = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: AsyncSearchSubmitRequest, value: CoreTypes.Sort) =
            { state with Sort = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: AsyncSearchSubmitRequest, value: GlobalSearchTypes.SourceConfig) =
            { state with Source = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: AsyncSearchSubmitRequest, value: CoreTypes.FieldAndFormat list) =
            { state with Fields = Some value }

        [<CustomOperation("suggest")>]
        member _.Suggest(state: AsyncSearchSubmitRequest, value: GlobalSearchTypes.Suggester) =
            { state with Suggest = Some value }

        [<CustomOperation("terminateAfter")>]
        member _.TerminateAfter(state: AsyncSearchSubmitRequest, value: CoreTypes.Long) =
            { state with TerminateAfter = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: AsyncSearchSubmitRequest, value: string) =
            { state with Timeout = Some value }

        [<CustomOperation("trackScores")>]
        member _.TrackScores(state: AsyncSearchSubmitRequest, value: bool) =
            { state with TrackScores = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: AsyncSearchSubmitRequest, value: bool) =
            { state with Version = Some value }

        [<CustomOperation("seqNoPrimaryTerm")>]
        member _.SeqNoPrimaryTerm(state: AsyncSearchSubmitRequest, value: bool) =
            { state with SeqNoPrimaryTerm = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: AsyncSearchSubmitRequest, value: CoreTypes.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("pit")>]
        member _.Pit(state: AsyncSearchSubmitRequest, value: GlobalSearchTypes.PointInTimeReference) =
            { state with Pit = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: AsyncSearchSubmitRequest, value: CoreTypes.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("stats")>]
        member _.Stats(state: AsyncSearchSubmitRequest, value: string list) =
            { state with Stats = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: AsyncSearchSubmitRequest, value: CoreTypes.ProjectRouting) =
            { state with ProjectRouting = Some value }

    let asyncSearchSubmitRequest = AsyncSearchSubmitRequestBuilder()

    module Submit =
        let withWaitForCompletionTimeout (value: CoreTypes.Duration) (req: AsyncSearchSubmitRequest) =
            { req with WaitForCompletionTimeout = Some value }
        let withKeepAlive (value: CoreTypes.Duration) (req: AsyncSearchSubmitRequest) =
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
        let withBatchedReduceSize (value: CoreTypes.Long) (req: AsyncSearchSubmitRequest) =
            { req with BatchedReduceSize = Some value }
        let withCcsMinimizeRoundtrips (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with CcsMinimizeRoundtrips = Some value }
        let withDefaultOperator (value: CoreTypes.Operator) (req: AsyncSearchSubmitRequest) =
            { req with DefaultOperator = Some value }
        let withDf (value: string) (req: AsyncSearchSubmitRequest) =
            { req with Df = Some value }
        let withDocvalueFields (value: CoreTypes.Fields) (req: AsyncSearchSubmitRequest) =
            { req with DocvalueFields = Some value }
        let withExpandWildcards (value: CoreTypes.ExpandWildcards) (req: AsyncSearchSubmitRequest) =
            { req with ExpandWildcards = Some value }
        let withExplain (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with Explain = Some value }
        let withIgnoreThrottled (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with IgnoreThrottled = Some value }
        let withIgnoreUnavailable (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with IgnoreUnavailable = Some value }
        let withLenient (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with Lenient = Some value }
        let withMaxConcurrentShardRequests (value: CoreTypes.Integer) (req: AsyncSearchSubmitRequest) =
            { req with MaxConcurrentShardRequests = Some value }
        let withPreference (value: string) (req: AsyncSearchSubmitRequest) =
            { req with Preference = Some value }
        let withRequestCache (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with RequestCache = Some value }
        let withRouting (value: CoreTypes.Routing) (req: AsyncSearchSubmitRequest) =
            { req with Routing = Some value }
        let withSearchType (value: CoreTypes.SearchType) (req: AsyncSearchSubmitRequest) =
            { req with SearchType = Some value }
        let withStats (value: string list) (req: AsyncSearchSubmitRequest) =
            { req with Stats = Some value }
        let withStoredFields (value: CoreTypes.Fields) (req: AsyncSearchSubmitRequest) =
            { req with StoredFields = Some value }
        let withSuggestField (value: CoreTypes.Field) (req: AsyncSearchSubmitRequest) =
            { req with SuggestField = Some value }
        let withSuggestMode (value: CoreTypes.SuggestMode) (req: AsyncSearchSubmitRequest) =
            { req with SuggestMode = Some value }
        let withSuggestSize (value: CoreTypes.Long) (req: AsyncSearchSubmitRequest) =
            { req with SuggestSize = Some value }
        let withSuggestText (value: string) (req: AsyncSearchSubmitRequest) =
            { req with SuggestText = Some value }
        let withTerminateAfter (value: CoreTypes.Long) (req: AsyncSearchSubmitRequest) =
            { req with TerminateAfter = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: AsyncSearchSubmitRequest) =
            { req with Timeout = Some value }
        let withTrackTotalHits (value: GlobalSearchTypes.TrackHits) (req: AsyncSearchSubmitRequest) =
            { req with TrackTotalHits = Some value }
        let withTrackScores (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with TrackScores = Some value }
        let withTypedKeys (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with TypedKeys = Some value }
        let withRestTotalHitsAsInt (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with RestTotalHitsAsInt = Some value }
        let withVersion (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with Version = Some value }
        let withSource (value: GlobalSearchTypes.SourceConfigParam) (req: AsyncSearchSubmitRequest) =
            { req with Source = Some value }
        let withSourceExcludes (value: CoreTypes.Fields) (req: AsyncSearchSubmitRequest) =
            { req with SourceExcludes = Some value }
        let withSourceIncludes (value: CoreTypes.Fields) (req: AsyncSearchSubmitRequest) =
            { req with SourceIncludes = Some value }
        let withSeqNoPrimaryTerm (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with SeqNoPrimaryTerm = Some value }
        let withQ (value: string) (req: AsyncSearchSubmitRequest) =
            { req with Q = Some value }
        let withSize (value: CoreTypes.Integer) (req: AsyncSearchSubmitRequest) =
            { req with Size = Some value }
        let withFrom (value: CoreTypes.Integer) (req: AsyncSearchSubmitRequest) =
            { req with From = Some value }
        let withSort (value: System.Text.Json.JsonElement) (req: AsyncSearchSubmitRequest) =
            { req with Sort = Some value }
        let withAggregations (value: Map<string, CoreTypes.AggregationContainer>) (req: AsyncSearchSubmitRequest) =
            { req with Aggregations = Some value }
        let withCollapse (value: GlobalSearchTypes.FieldCollapse) (req: AsyncSearchSubmitRequest) =
            { req with Collapse = Some value }
        let withExplain (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with Explain = Some value }
        let withExt (value: Map<string, System.Text.Json.JsonElement>) (req: AsyncSearchSubmitRequest) =
            { req with Ext = Some value }
        let withFrom (value: CoreTypes.Integer) (req: AsyncSearchSubmitRequest) =
            { req with From = Some value }
        let withHighlight (value: GlobalSearchTypes.Highlight) (req: AsyncSearchSubmitRequest) =
            { req with Highlight = Some value }
        let withTrackTotalHits (value: GlobalSearchTypes.TrackHits) (req: AsyncSearchSubmitRequest) =
            { req with TrackTotalHits = Some value }
        let withIndicesBoost (value: Map<CoreTypes.IndexName, CoreTypes.Double> list) (req: AsyncSearchSubmitRequest) =
            { req with IndicesBoost = Some value }
        let withDocvalueFields (value: CoreTypes.FieldAndFormat list) (req: AsyncSearchSubmitRequest) =
            { req with DocvalueFields = Some value }
        let withKnn (value: System.Text.Json.JsonElement) (req: AsyncSearchSubmitRequest) =
            { req with Knn = Some value }
        let withMinScore (value: CoreTypes.Double) (req: AsyncSearchSubmitRequest) =
            { req with MinScore = Some value }
        let withPostFilter (value: CoreTypes.QueryContainer) (req: AsyncSearchSubmitRequest) =
            { req with PostFilter = Some value }
        let withProfile (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with Profile = Some value }
        let withQuery (value: CoreTypes.QueryContainer) (req: AsyncSearchSubmitRequest) =
            { req with Query = Some value }
        let withRescore (value: System.Text.Json.JsonElement) (req: AsyncSearchSubmitRequest) =
            { req with Rescore = Some value }
        let withScriptFields (value: Map<string, CoreTypes.ScriptField>) (req: AsyncSearchSubmitRequest) =
            { req with ScriptFields = Some value }
        let withSearchAfter (value: CoreTypes.SortResults) (req: AsyncSearchSubmitRequest) =
            { req with SearchAfter = Some value }
        let withSize (value: CoreTypes.Integer) (req: AsyncSearchSubmitRequest) =
            { req with Size = Some value }
        let withSlice (value: CoreTypes.SlicedScroll) (req: AsyncSearchSubmitRequest) =
            { req with Slice = Some value }
        let withSort (value: CoreTypes.Sort) (req: AsyncSearchSubmitRequest) =
            { req with Sort = Some value }
        let withSource (value: GlobalSearchTypes.SourceConfig) (req: AsyncSearchSubmitRequest) =
            { req with Source = Some value }
        let withFields (value: CoreTypes.FieldAndFormat list) (req: AsyncSearchSubmitRequest) =
            { req with Fields = Some value }
        let withSuggest (value: GlobalSearchTypes.Suggester) (req: AsyncSearchSubmitRequest) =
            { req with Suggest = Some value }
        let withTerminateAfter (value: CoreTypes.Long) (req: AsyncSearchSubmitRequest) =
            { req with TerminateAfter = Some value }
        let withTimeout (value: string) (req: AsyncSearchSubmitRequest) =
            { req with Timeout = Some value }
        let withTrackScores (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with TrackScores = Some value }
        let withVersion (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with Version = Some value }
        let withSeqNoPrimaryTerm (value: bool) (req: AsyncSearchSubmitRequest) =
            { req with SeqNoPrimaryTerm = Some value }
        let withStoredFields (value: CoreTypes.Fields) (req: AsyncSearchSubmitRequest) =
            { req with StoredFields = Some value }
        let withPit (value: GlobalSearchTypes.PointInTimeReference) (req: AsyncSearchSubmitRequest) =
            { req with Pit = Some value }
        let withRuntimeMappings (value: CoreTypes.RuntimeFields) (req: AsyncSearchSubmitRequest) =
            { req with RuntimeMappings = Some value }
        let withStats (value: string list) (req: AsyncSearchSubmitRequest) =
            { req with Stats = Some value }
        let withProjectRouting (value: CoreTypes.ProjectRouting) (req: AsyncSearchSubmitRequest) =
            { req with ProjectRouting = Some value }


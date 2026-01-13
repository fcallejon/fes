// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module SearchOperations =

    type AsyncSearchGetRequest = {
        [<JsonPropertyName("id")>]
        Id: Id
        [<JsonPropertyName("keep_alive")>]
        KeepAlive: Duration option
        [<JsonPropertyName("typed_keys")>]
        TypedKeys: bool option
        [<JsonPropertyName("wait_for_completion_timeout")>]
        WaitForCompletionTimeout: Duration option
    } with
        static member ToRequest(request: AsyncSearchGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_async_search/{request.Id}"
                let queryParams =
                    [
                        request.KeepAlive |> Option.map (fun v -> "keep_alive", string v)
                        request.TypedKeys |> Option.map (fun v -> "typed_keys", string v)
                        request.WaitForCompletionTimeout |> Option.map (fun v -> "wait_for_completion_timeout", string v)
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

    module AsyncSearchGetRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: AsyncSearchGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            AsyncSearchGetRequest.ToRequest request

    type AsyncSearchGetRequestBuilder() =
        member _.Yield(_: unit) : AsyncSearchGetRequest =
            {
                AsyncSearchGetRequest.Id = Unchecked.defaultof<Id>
                AsyncSearchGetRequest.KeepAlive = Option.None
                AsyncSearchGetRequest.TypedKeys = Option.None
                AsyncSearchGetRequest.WaitForCompletionTimeout = Option.None
            } : AsyncSearchGetRequest

        [<CustomOperation("id")>]
        member _.Id(state: AsyncSearchGetRequest, value: Id) =
            { state with AsyncSearchGetRequest.Id = value } : AsyncSearchGetRequest

        [<CustomOperation("keep_alive")>]
        member _.KeepAlive(state: AsyncSearchGetRequest, value: Duration) =
            { state with AsyncSearchGetRequest.KeepAlive = Option.Some value } : AsyncSearchGetRequest

        [<CustomOperation("typed_keys")>]
        member _.TypedKeys(state: AsyncSearchGetRequest, value: bool) =
            { state with AsyncSearchGetRequest.TypedKeys = Option.Some value } : AsyncSearchGetRequest

        [<CustomOperation("wait_for_completion_timeout")>]
        member _.WaitForCompletionTimeout(state: AsyncSearchGetRequest, value: Duration) =
            { state with AsyncSearchGetRequest.WaitForCompletionTimeout = Option.Some value } : AsyncSearchGetRequest

    let asyncSearchGetRequest = AsyncSearchGetRequestBuilder()

    type AsyncSearchGetResponse = TypesAsyncSearchDocumentResponseBase

    type AsyncSearchDeleteRequest = {
        [<JsonPropertyName("id")>]
        Id: Id
    } with
        static member ToRequest(request: AsyncSearchDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_async_search/{request.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module AsyncSearchDeleteRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: AsyncSearchDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            AsyncSearchDeleteRequest.ToRequest request

    type AsyncSearchDeleteRequestBuilder() =
        member _.Yield(_: unit) : AsyncSearchDeleteRequest =
            {
                AsyncSearchDeleteRequest.Id = Unchecked.defaultof<Id>
            } : AsyncSearchDeleteRequest

        [<CustomOperation("id")>]
        member _.Id(state: AsyncSearchDeleteRequest, value: Id) =
            { state with AsyncSearchDeleteRequest.Id = value } : AsyncSearchDeleteRequest

    let asyncSearchDeleteRequest = AsyncSearchDeleteRequestBuilder()

    type AsyncSearchDeleteResponse = AcknowledgedResponseBase

    type AsyncSearchStatusRequest = {
        [<JsonPropertyName("id")>]
        Id: Id
        [<JsonPropertyName("keep_alive")>]
        KeepAlive: Duration option
    } with
        static member ToRequest(request: AsyncSearchStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_async_search/status/{request.Id}"
                let queryParams =
                    [
                        request.KeepAlive |> Option.map (fun v -> "keep_alive", string v)
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

    module AsyncSearchStatusRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: AsyncSearchStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            AsyncSearchStatusRequest.ToRequest request

    type AsyncSearchStatusRequestBuilder() =
        member _.Yield(_: unit) : AsyncSearchStatusRequest =
            {
                AsyncSearchStatusRequest.Id = Unchecked.defaultof<Id>
                AsyncSearchStatusRequest.KeepAlive = Option.None
            } : AsyncSearchStatusRequest

        [<CustomOperation("id")>]
        member _.Id(state: AsyncSearchStatusRequest, value: Id) =
            { state with AsyncSearchStatusRequest.Id = value } : AsyncSearchStatusRequest

        [<CustomOperation("keep_alive")>]
        member _.KeepAlive(state: AsyncSearchStatusRequest, value: Duration) =
            { state with AsyncSearchStatusRequest.KeepAlive = Option.Some value } : AsyncSearchStatusRequest

    let asyncSearchStatusRequest = AsyncSearchStatusRequestBuilder()

    type AsyncSearchStatusResponse = StatusStatusResponseBase

    type AsyncSearchSubmitRequest = {
        [<JsonPropertyName("index")>]
        Index: Indices
        [<JsonPropertyName("wait_for_completion_timeout")>]
        WaitForCompletionTimeout: Duration option
        [<JsonPropertyName("keep_alive")>]
        KeepAlive: Duration option
        [<JsonPropertyName("keep_on_completion")>]
        KeepOnCompletion: bool option
        [<JsonPropertyName("allow_no_indices")>]
        AllowNoIndices: bool option
        [<JsonPropertyName("allow_partial_search_results")>]
        AllowPartialSearchResults: bool option
        [<JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<JsonPropertyName("analyze_wildcard")>]
        AnalyzeWildcard: bool option
        [<JsonPropertyName("batched_reduce_size")>]
        BatchedReduceSize: float option
        [<JsonPropertyName("ccs_minimize_roundtrips")>]
        CcsMinimizeRoundtrips: bool option
        [<JsonPropertyName("default_operator")>]
        DefaultOperator: QueryDslOperator option
        [<JsonPropertyName("df")>]
        Df: string option
        [<JsonPropertyName("docvalue_fields")>]
        DocvalueFields: Fields option
        [<JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: ExpandWildcards option
        [<JsonPropertyName("explain")>]
        Explain: bool option
        [<JsonPropertyName("ignore_throttled")>]
        IgnoreThrottled: bool option
        [<JsonPropertyName("ignore_unavailable")>]
        IgnoreUnavailable: bool option
        [<JsonPropertyName("lenient")>]
        Lenient: bool option
        [<JsonPropertyName("max_concurrent_shard_requests")>]
        MaxConcurrentShardRequests: float option
        [<JsonPropertyName("preference")>]
        Preference: string option
        [<JsonPropertyName("request_cache")>]
        RequestCache: bool option
        [<JsonPropertyName("routing")>]
        Routing: Routing option
        [<JsonPropertyName("search_type")>]
        SearchType: SearchType option
        [<JsonPropertyName("stats")>]
        Stats: string array option
        [<JsonPropertyName("stored_fields")>]
        StoredFields: Fields option
        [<JsonPropertyName("suggest_field")>]
        SuggestField: Field option
        [<JsonPropertyName("suggest_mode")>]
        SuggestMode: SuggestMode option
        [<JsonPropertyName("suggest_size")>]
        SuggestSize: float option
        [<JsonPropertyName("suggest_text")>]
        SuggestText: string option
        [<JsonPropertyName("terminate_after")>]
        TerminateAfter: float option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
        [<JsonPropertyName("track_total_hits")>]
        TrackTotalHits: SearchTypesTrackHits option
        [<JsonPropertyName("track_scores")>]
        TrackScores: bool option
        [<JsonPropertyName("typed_keys")>]
        TypedKeys: bool option
        [<JsonPropertyName("rest_total_hits_as_int")>]
        RestTotalHitsAsInt: bool option
        [<JsonPropertyName("version")>]
        Version: bool option
        [<JsonPropertyName("_source")>]
        Source: SearchTypesSourceConfigParam option
        [<JsonPropertyName("_source_excludes")>]
        SourceExcludes: Fields option
        [<JsonPropertyName("_source_includes")>]
        SourceIncludes: Fields option
        [<JsonPropertyName("seq_no_primary_term")>]
        SeqNoPrimaryTerm: bool option
        [<JsonPropertyName("q")>]
        Q: string option
        [<JsonPropertyName("size")>]
        Size: float option
        [<JsonPropertyName("from")>]
        From: float option
        [<JsonPropertyName("sort")>]
        Sort: System.Text.Json.JsonElement option
        [<JsonPropertyName("aggregations")>]
        Aggregations: Map<string, AggregationsAggregationContainer> option
        [<JsonPropertyName("collapse")>]
        Collapse: SearchTypesFieldCollapse option
        [<JsonPropertyName("explain")>]
        Explain2: bool option
        [<JsonPropertyName("ext")>]
        Ext: Map<string, obj> option
        [<JsonPropertyName("from")>]
        From2: float option
        [<JsonPropertyName("highlight")>]
        Highlight: SearchTypesHighlight option
        [<JsonPropertyName("track_total_hits")>]
        TrackTotalHits2: SearchTypesTrackHits option
        [<JsonPropertyName("indices_boost")>]
        IndicesBoost: Map<string, float> array option
        [<JsonPropertyName("docvalue_fields")>]
        DocvalueFields2: QueryDslFieldAndFormat array option
        [<JsonPropertyName("knn")>]
        Knn: System.Text.Json.JsonElement option
        [<JsonPropertyName("min_score")>]
        MinScore: float option
        [<JsonPropertyName("post_filter")>]
        PostFilter: QueryDslQueryContainer option
        [<JsonPropertyName("profile")>]
        Profile: bool option
        [<JsonPropertyName("query")>]
        Query: QueryDslQueryContainer option
        [<JsonPropertyName("rescore")>]
        Rescore: System.Text.Json.JsonElement option
        [<JsonPropertyName("script_fields")>]
        ScriptFields: Map<string, ScriptField> option
        [<JsonPropertyName("search_after")>]
        SearchAfter: SortResults option
        [<JsonPropertyName("size")>]
        Size2: float option
        [<JsonPropertyName("slice")>]
        Slice: SlicedScroll option
        [<JsonPropertyName("sort")>]
        Sort2: Sort option
        [<JsonPropertyName("_source")>]
        Source2: SearchTypesSourceConfig option
        [<JsonPropertyName("fields")>]
        Fields: QueryDslFieldAndFormat array option
        [<JsonPropertyName("suggest")>]
        Suggest: SearchTypesSuggester option
        [<JsonPropertyName("terminate_after")>]
        TerminateAfter2: float option
        [<JsonPropertyName("timeout")>]
        Timeout2: string option
        [<JsonPropertyName("track_scores")>]
        TrackScores2: bool option
        [<JsonPropertyName("version")>]
        Version2: bool option
        [<JsonPropertyName("seq_no_primary_term")>]
        SeqNoPrimaryTerm2: bool option
        [<JsonPropertyName("stored_fields")>]
        StoredFields2: Fields option
        [<JsonPropertyName("pit")>]
        Pit: SearchTypesPointInTimeReference option
        [<JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: MappingRuntimeFields option
        [<JsonPropertyName("stats")>]
        Stats2: string array option
    } with
        static member ToRequest(request: AsyncSearchSubmitRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_async_search"
                let queryParams =
                    [
                        request.WaitForCompletionTimeout |> Option.map (fun v -> "wait_for_completion_timeout", string v)
                        request.KeepAlive |> Option.map (fun v -> "keep_alive", string v)
                        request.KeepOnCompletion |> Option.map (fun v -> "keep_on_completion", string v)
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", string v)
                        request.AllowPartialSearchResults |> Option.map (fun v -> "allow_partial_search_results", string v)
                        request.Analyzer |> Option.map (fun v -> "analyzer", string v)
                        request.AnalyzeWildcard |> Option.map (fun v -> "analyze_wildcard", string v)
                        request.BatchedReduceSize |> Option.map (fun v -> "batched_reduce_size", string v)
                        request.CcsMinimizeRoundtrips |> Option.map (fun v -> "ccs_minimize_roundtrips", string v)
                        request.DefaultOperator |> Option.map (fun v -> "default_operator", string v)
                        request.Df |> Option.map (fun v -> "df", string v)
                        request.DocvalueFields |> Option.map (fun v -> "docvalue_fields", string v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", string v)
                        request.Explain |> Option.map (fun v -> "explain", string v)
                        request.IgnoreThrottled |> Option.map (fun v -> "ignore_throttled", string v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", string v)
                        request.Lenient |> Option.map (fun v -> "lenient", string v)
                        request.MaxConcurrentShardRequests |> Option.map (fun v -> "max_concurrent_shard_requests", string v)
                        request.Preference |> Option.map (fun v -> "preference", string v)
                        request.RequestCache |> Option.map (fun v -> "request_cache", string v)
                        request.Routing |> Option.map (fun v -> "routing", string v)
                        request.SearchType |> Option.map (fun v -> "search_type", string v)
                        request.Stats |> Option.map (fun v -> "stats", string v)
                        request.StoredFields |> Option.map (fun v -> "stored_fields", string v)
                        request.SuggestField |> Option.map (fun v -> "suggest_field", string v)
                        request.SuggestMode |> Option.map (fun v -> "suggest_mode", string v)
                        request.SuggestSize |> Option.map (fun v -> "suggest_size", string v)
                        request.SuggestText |> Option.map (fun v -> "suggest_text", string v)
                        request.TerminateAfter |> Option.map (fun v -> "terminate_after", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                        request.TrackTotalHits |> Option.map (fun v -> "track_total_hits", string v)
                        request.TrackScores |> Option.map (fun v -> "track_scores", string v)
                        request.TypedKeys |> Option.map (fun v -> "typed_keys", string v)
                        request.RestTotalHitsAsInt |> Option.map (fun v -> "rest_total_hits_as_int", string v)
                        request.Version |> Option.map (fun v -> "version", string v)
                        request.Source |> Option.map (fun v -> "_source", string v)
                        request.SourceExcludes |> Option.map (fun v -> "_source_excludes", string v)
                        request.SourceIncludes |> Option.map (fun v -> "_source_includes", string v)
                        request.SeqNoPrimaryTerm |> Option.map (fun v -> "seq_no_primary_term", string v)
                        request.Q |> Option.map (fun v -> "q", string v)
                        request.Size |> Option.map (fun v -> "size", string v)
                        request.From |> Option.map (fun v -> "from", string v)
                        request.Sort |> Option.map (fun v -> "sort", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module AsyncSearchSubmitRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: AsyncSearchSubmitRequest) : Result<Fes.Http.RequestMsg, exn> =
            AsyncSearchSubmitRequest.ToRequest request

    type AsyncSearchSubmitRequestBuilder() =
        member _.Yield(_: unit) : AsyncSearchSubmitRequest =
            {
                AsyncSearchSubmitRequest.Index = Unchecked.defaultof<Indices>
                AsyncSearchSubmitRequest.WaitForCompletionTimeout = Option.None
                AsyncSearchSubmitRequest.KeepAlive = Option.None
                AsyncSearchSubmitRequest.KeepOnCompletion = Option.None
                AsyncSearchSubmitRequest.AllowNoIndices = Option.None
                AsyncSearchSubmitRequest.AllowPartialSearchResults = Option.None
                AsyncSearchSubmitRequest.Analyzer = Option.None
                AsyncSearchSubmitRequest.AnalyzeWildcard = Option.None
                AsyncSearchSubmitRequest.BatchedReduceSize = Option.None
                AsyncSearchSubmitRequest.CcsMinimizeRoundtrips = Option.None
                AsyncSearchSubmitRequest.DefaultOperator = Option.None
                AsyncSearchSubmitRequest.Df = Option.None
                AsyncSearchSubmitRequest.DocvalueFields = Option.None
                AsyncSearchSubmitRequest.ExpandWildcards = Option.None
                AsyncSearchSubmitRequest.Explain = Option.None
                AsyncSearchSubmitRequest.IgnoreThrottled = Option.None
                AsyncSearchSubmitRequest.IgnoreUnavailable = Option.None
                AsyncSearchSubmitRequest.Lenient = Option.None
                AsyncSearchSubmitRequest.MaxConcurrentShardRequests = Option.None
                AsyncSearchSubmitRequest.Preference = Option.None
                AsyncSearchSubmitRequest.RequestCache = Option.None
                AsyncSearchSubmitRequest.Routing = Option.None
                AsyncSearchSubmitRequest.SearchType = Option.None
                AsyncSearchSubmitRequest.Stats = Option.None
                AsyncSearchSubmitRequest.StoredFields = Option.None
                AsyncSearchSubmitRequest.SuggestField = Option.None
                AsyncSearchSubmitRequest.SuggestMode = Option.None
                AsyncSearchSubmitRequest.SuggestSize = Option.None
                AsyncSearchSubmitRequest.SuggestText = Option.None
                AsyncSearchSubmitRequest.TerminateAfter = Option.None
                AsyncSearchSubmitRequest.Timeout = Option.None
                AsyncSearchSubmitRequest.TrackTotalHits = Option.None
                AsyncSearchSubmitRequest.TrackScores = Option.None
                AsyncSearchSubmitRequest.TypedKeys = Option.None
                AsyncSearchSubmitRequest.RestTotalHitsAsInt = Option.None
                AsyncSearchSubmitRequest.Version = Option.None
                AsyncSearchSubmitRequest.Source = Option.None
                AsyncSearchSubmitRequest.SourceExcludes = Option.None
                AsyncSearchSubmitRequest.SourceIncludes = Option.None
                AsyncSearchSubmitRequest.SeqNoPrimaryTerm = Option.None
                AsyncSearchSubmitRequest.Q = Option.None
                AsyncSearchSubmitRequest.Size = Option.None
                AsyncSearchSubmitRequest.From = Option.None
                AsyncSearchSubmitRequest.Sort = Option.None
                AsyncSearchSubmitRequest.Aggregations = Option.None
                AsyncSearchSubmitRequest.Collapse = Option.None
                AsyncSearchSubmitRequest.Explain2 = Option.None
                AsyncSearchSubmitRequest.Ext = Option.None
                AsyncSearchSubmitRequest.From2 = Option.None
                AsyncSearchSubmitRequest.Highlight = Option.None
                AsyncSearchSubmitRequest.TrackTotalHits2 = Option.None
                AsyncSearchSubmitRequest.IndicesBoost = Option.None
                AsyncSearchSubmitRequest.DocvalueFields2 = Option.None
                AsyncSearchSubmitRequest.Knn = Option.None
                AsyncSearchSubmitRequest.MinScore = Option.None
                AsyncSearchSubmitRequest.PostFilter = Option.None
                AsyncSearchSubmitRequest.Profile = Option.None
                AsyncSearchSubmitRequest.Query = Option.None
                AsyncSearchSubmitRequest.Rescore = Option.None
                AsyncSearchSubmitRequest.ScriptFields = Option.None
                AsyncSearchSubmitRequest.SearchAfter = Option.None
                AsyncSearchSubmitRequest.Size2 = Option.None
                AsyncSearchSubmitRequest.Slice = Option.None
                AsyncSearchSubmitRequest.Sort2 = Option.None
                AsyncSearchSubmitRequest.Source2 = Option.None
                AsyncSearchSubmitRequest.Fields = Option.None
                AsyncSearchSubmitRequest.Suggest = Option.None
                AsyncSearchSubmitRequest.TerminateAfter2 = Option.None
                AsyncSearchSubmitRequest.Timeout2 = Option.None
                AsyncSearchSubmitRequest.TrackScores2 = Option.None
                AsyncSearchSubmitRequest.Version2 = Option.None
                AsyncSearchSubmitRequest.SeqNoPrimaryTerm2 = Option.None
                AsyncSearchSubmitRequest.StoredFields2 = Option.None
                AsyncSearchSubmitRequest.Pit = Option.None
                AsyncSearchSubmitRequest.RuntimeMappings = Option.None
                AsyncSearchSubmitRequest.Stats2 = Option.None
            } : AsyncSearchSubmitRequest

        [<CustomOperation("index")>]
        member _.Index(state: AsyncSearchSubmitRequest, value: Indices) =
            { state with AsyncSearchSubmitRequest.Index = value } : AsyncSearchSubmitRequest

        [<CustomOperation("wait_for_completion_timeout")>]
        member _.WaitForCompletionTimeout(state: AsyncSearchSubmitRequest, value: Duration) =
            { state with AsyncSearchSubmitRequest.WaitForCompletionTimeout = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("keep_alive")>]
        member _.KeepAlive(state: AsyncSearchSubmitRequest, value: Duration) =
            { state with AsyncSearchSubmitRequest.KeepAlive = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("keep_on_completion")>]
        member _.KeepOnCompletion(state: AsyncSearchSubmitRequest, value: bool) =
            { state with AsyncSearchSubmitRequest.KeepOnCompletion = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: AsyncSearchSubmitRequest, value: bool) =
            { state with AsyncSearchSubmitRequest.AllowNoIndices = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("allow_partial_search_results")>]
        member _.AllowPartialSearchResults(state: AsyncSearchSubmitRequest, value: bool) =
            { state with AsyncSearchSubmitRequest.AllowPartialSearchResults = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: AsyncSearchSubmitRequest, value: string) =
            { state with AsyncSearchSubmitRequest.Analyzer = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("analyze_wildcard")>]
        member _.AnalyzeWildcard(state: AsyncSearchSubmitRequest, value: bool) =
            { state with AsyncSearchSubmitRequest.AnalyzeWildcard = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("batched_reduce_size")>]
        member _.BatchedReduceSize(state: AsyncSearchSubmitRequest, value: float) =
            { state with AsyncSearchSubmitRequest.BatchedReduceSize = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("ccs_minimize_roundtrips")>]
        member _.CcsMinimizeRoundtrips(state: AsyncSearchSubmitRequest, value: bool) =
            { state with AsyncSearchSubmitRequest.CcsMinimizeRoundtrips = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("default_operator")>]
        member _.DefaultOperator(state: AsyncSearchSubmitRequest, value: QueryDslOperator) =
            { state with AsyncSearchSubmitRequest.DefaultOperator = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("df")>]
        member _.Df(state: AsyncSearchSubmitRequest, value: string) =
            { state with AsyncSearchSubmitRequest.Df = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("docvalue_fields")>]
        member _.DocvalueFields(state: AsyncSearchSubmitRequest, value: Fields) =
            { state with AsyncSearchSubmitRequest.DocvalueFields = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: AsyncSearchSubmitRequest, value: ExpandWildcards) =
            { state with AsyncSearchSubmitRequest.ExpandWildcards = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("explain")>]
        member _.Explain(state: AsyncSearchSubmitRequest, value: bool) =
            { state with AsyncSearchSubmitRequest.Explain = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("ignore_throttled")>]
        member _.IgnoreThrottled(state: AsyncSearchSubmitRequest, value: bool) =
            { state with AsyncSearchSubmitRequest.IgnoreThrottled = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: AsyncSearchSubmitRequest, value: bool) =
            { state with AsyncSearchSubmitRequest.IgnoreUnavailable = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("lenient")>]
        member _.Lenient(state: AsyncSearchSubmitRequest, value: bool) =
            { state with AsyncSearchSubmitRequest.Lenient = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("max_concurrent_shard_requests")>]
        member _.MaxConcurrentShardRequests(state: AsyncSearchSubmitRequest, value: float) =
            { state with AsyncSearchSubmitRequest.MaxConcurrentShardRequests = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("preference")>]
        member _.Preference(state: AsyncSearchSubmitRequest, value: string) =
            { state with AsyncSearchSubmitRequest.Preference = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("request_cache")>]
        member _.RequestCache(state: AsyncSearchSubmitRequest, value: bool) =
            { state with AsyncSearchSubmitRequest.RequestCache = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: AsyncSearchSubmitRequest, value: Routing) =
            { state with AsyncSearchSubmitRequest.Routing = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("search_type")>]
        member _.SearchType(state: AsyncSearchSubmitRequest, value: SearchType) =
            { state with AsyncSearchSubmitRequest.SearchType = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("stats")>]
        member _.Stats(state: AsyncSearchSubmitRequest, value: string array) =
            { state with AsyncSearchSubmitRequest.Stats = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("stored_fields")>]
        member _.StoredFields(state: AsyncSearchSubmitRequest, value: Fields) =
            { state with AsyncSearchSubmitRequest.StoredFields = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("suggest_field")>]
        member _.SuggestField(state: AsyncSearchSubmitRequest, value: Field) =
            { state with AsyncSearchSubmitRequest.SuggestField = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("suggest_mode")>]
        member _.SuggestMode(state: AsyncSearchSubmitRequest, value: SuggestMode) =
            { state with AsyncSearchSubmitRequest.SuggestMode = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("suggest_size")>]
        member _.SuggestSize(state: AsyncSearchSubmitRequest, value: float) =
            { state with AsyncSearchSubmitRequest.SuggestSize = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("suggest_text")>]
        member _.SuggestText(state: AsyncSearchSubmitRequest, value: string) =
            { state with AsyncSearchSubmitRequest.SuggestText = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("terminate_after")>]
        member _.TerminateAfter(state: AsyncSearchSubmitRequest, value: float) =
            { state with AsyncSearchSubmitRequest.TerminateAfter = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: AsyncSearchSubmitRequest, value: Duration) =
            { state with AsyncSearchSubmitRequest.Timeout = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("track_total_hits")>]
        member _.TrackTotalHits(state: AsyncSearchSubmitRequest, value: SearchTypesTrackHits) =
            { state with AsyncSearchSubmitRequest.TrackTotalHits = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("track_scores")>]
        member _.TrackScores(state: AsyncSearchSubmitRequest, value: bool) =
            { state with AsyncSearchSubmitRequest.TrackScores = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("typed_keys")>]
        member _.TypedKeys(state: AsyncSearchSubmitRequest, value: bool) =
            { state with AsyncSearchSubmitRequest.TypedKeys = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("rest_total_hits_as_int")>]
        member _.RestTotalHitsAsInt(state: AsyncSearchSubmitRequest, value: bool) =
            { state with AsyncSearchSubmitRequest.RestTotalHitsAsInt = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("version")>]
        member _.Version(state: AsyncSearchSubmitRequest, value: bool) =
            { state with AsyncSearchSubmitRequest.Version = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("_source")>]
        member _.Source(state: AsyncSearchSubmitRequest, value: SearchTypesSourceConfigParam) =
            { state with AsyncSearchSubmitRequest.Source = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("_source_excludes")>]
        member _.SourceExcludes(state: AsyncSearchSubmitRequest, value: Fields) =
            { state with AsyncSearchSubmitRequest.SourceExcludes = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("_source_includes")>]
        member _.SourceIncludes(state: AsyncSearchSubmitRequest, value: Fields) =
            { state with AsyncSearchSubmitRequest.SourceIncludes = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("seq_no_primary_term")>]
        member _.SeqNoPrimaryTerm(state: AsyncSearchSubmitRequest, value: bool) =
            { state with AsyncSearchSubmitRequest.SeqNoPrimaryTerm = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("q")>]
        member _.Q(state: AsyncSearchSubmitRequest, value: string) =
            { state with AsyncSearchSubmitRequest.Q = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("size")>]
        member _.Size(state: AsyncSearchSubmitRequest, value: float) =
            { state with AsyncSearchSubmitRequest.Size = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("from")>]
        member _.From(state: AsyncSearchSubmitRequest, value: float) =
            { state with AsyncSearchSubmitRequest.From = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("sort")>]
        member _.Sort(state: AsyncSearchSubmitRequest, value: System.Text.Json.JsonElement) =
            { state with AsyncSearchSubmitRequest.Sort = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: AsyncSearchSubmitRequest, value: Map<string, AggregationsAggregationContainer>) =
            { state with AsyncSearchSubmitRequest.Aggregations = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("collapse")>]
        member _.Collapse(state: AsyncSearchSubmitRequest, value: SearchTypesFieldCollapse) =
            { state with AsyncSearchSubmitRequest.Collapse = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("explain2")>]
        member _.Explain2(state: AsyncSearchSubmitRequest, value: bool) =
            { state with AsyncSearchSubmitRequest.Explain2 = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("ext")>]
        member _.Ext(state: AsyncSearchSubmitRequest, value: Map<string, obj>) =
            { state with AsyncSearchSubmitRequest.Ext = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("from2")>]
        member _.From2(state: AsyncSearchSubmitRequest, value: float) =
            { state with AsyncSearchSubmitRequest.From2 = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("highlight")>]
        member _.Highlight(state: AsyncSearchSubmitRequest, value: SearchTypesHighlight) =
            { state with AsyncSearchSubmitRequest.Highlight = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("track_total_hits2")>]
        member _.TrackTotalHits2(state: AsyncSearchSubmitRequest, value: SearchTypesTrackHits) =
            { state with AsyncSearchSubmitRequest.TrackTotalHits2 = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("indices_boost")>]
        member _.IndicesBoost(state: AsyncSearchSubmitRequest, value: Map<string, float> array) =
            { state with AsyncSearchSubmitRequest.IndicesBoost = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("docvalue_fields2")>]
        member _.DocvalueFields2(state: AsyncSearchSubmitRequest, value: QueryDslFieldAndFormat array) =
            { state with AsyncSearchSubmitRequest.DocvalueFields2 = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("knn")>]
        member _.Knn(state: AsyncSearchSubmitRequest, value: System.Text.Json.JsonElement) =
            { state with AsyncSearchSubmitRequest.Knn = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("min_score")>]
        member _.MinScore(state: AsyncSearchSubmitRequest, value: float) =
            { state with AsyncSearchSubmitRequest.MinScore = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("post_filter")>]
        member _.PostFilter(state: AsyncSearchSubmitRequest, value: QueryDslQueryContainer) =
            { state with AsyncSearchSubmitRequest.PostFilter = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("profile")>]
        member _.Profile(state: AsyncSearchSubmitRequest, value: bool) =
            { state with AsyncSearchSubmitRequest.Profile = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("query")>]
        member _.Query(state: AsyncSearchSubmitRequest, value: QueryDslQueryContainer) =
            { state with AsyncSearchSubmitRequest.Query = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("rescore")>]
        member _.Rescore(state: AsyncSearchSubmitRequest, value: System.Text.Json.JsonElement) =
            { state with AsyncSearchSubmitRequest.Rescore = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("script_fields")>]
        member _.ScriptFields(state: AsyncSearchSubmitRequest, value: Map<string, ScriptField>) =
            { state with AsyncSearchSubmitRequest.ScriptFields = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("search_after")>]
        member _.SearchAfter(state: AsyncSearchSubmitRequest, value: SortResults) =
            { state with AsyncSearchSubmitRequest.SearchAfter = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("size2")>]
        member _.Size2(state: AsyncSearchSubmitRequest, value: float) =
            { state with AsyncSearchSubmitRequest.Size2 = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("slice")>]
        member _.Slice(state: AsyncSearchSubmitRequest, value: SlicedScroll) =
            { state with AsyncSearchSubmitRequest.Slice = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("sort2")>]
        member _.Sort2(state: AsyncSearchSubmitRequest, value: Sort) =
            { state with AsyncSearchSubmitRequest.Sort2 = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("_source2")>]
        member _.Source2(state: AsyncSearchSubmitRequest, value: SearchTypesSourceConfig) =
            { state with AsyncSearchSubmitRequest.Source2 = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("fields")>]
        member _.Fields(state: AsyncSearchSubmitRequest, value: QueryDslFieldAndFormat array) =
            { state with AsyncSearchSubmitRequest.Fields = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("suggest")>]
        member _.Suggest(state: AsyncSearchSubmitRequest, value: SearchTypesSuggester) =
            { state with AsyncSearchSubmitRequest.Suggest = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("terminate_after2")>]
        member _.TerminateAfter2(state: AsyncSearchSubmitRequest, value: float) =
            { state with AsyncSearchSubmitRequest.TerminateAfter2 = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("timeout2")>]
        member _.Timeout2(state: AsyncSearchSubmitRequest, value: string) =
            { state with AsyncSearchSubmitRequest.Timeout2 = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("track_scores2")>]
        member _.TrackScores2(state: AsyncSearchSubmitRequest, value: bool) =
            { state with AsyncSearchSubmitRequest.TrackScores2 = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("version2")>]
        member _.Version2(state: AsyncSearchSubmitRequest, value: bool) =
            { state with AsyncSearchSubmitRequest.Version2 = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("seq_no_primary_term2")>]
        member _.SeqNoPrimaryTerm2(state: AsyncSearchSubmitRequest, value: bool) =
            { state with AsyncSearchSubmitRequest.SeqNoPrimaryTerm2 = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("stored_fields2")>]
        member _.StoredFields2(state: AsyncSearchSubmitRequest, value: Fields) =
            { state with AsyncSearchSubmitRequest.StoredFields2 = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("pit")>]
        member _.Pit(state: AsyncSearchSubmitRequest, value: SearchTypesPointInTimeReference) =
            { state with AsyncSearchSubmitRequest.Pit = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("runtime_mappings")>]
        member _.RuntimeMappings(state: AsyncSearchSubmitRequest, value: MappingRuntimeFields) =
            { state with AsyncSearchSubmitRequest.RuntimeMappings = Option.Some value } : AsyncSearchSubmitRequest

        [<CustomOperation("stats2")>]
        member _.Stats2(state: AsyncSearchSubmitRequest, value: string array) =
            { state with AsyncSearchSubmitRequest.Stats2 = Option.Some value } : AsyncSearchSubmitRequest

    let asyncSearchSubmitRequest = AsyncSearchSubmitRequestBuilder()

    type ScrollRequest = {
        [<JsonPropertyName("scroll_id")>]
        ScrollId: ScrollId
        [<JsonPropertyName("scroll")>]
        Scroll: Duration option
        [<JsonPropertyName("scroll_id")>]
        ScrollId2: ScrollId option
        [<JsonPropertyName("rest_total_hits_as_int")>]
        RestTotalHitsAsInt: bool option
        [<JsonPropertyName("scroll")>]
        Scroll2: Duration option
        [<JsonPropertyName("scroll_id")>]
        ScrollId3: ScrollId
    } with
        static member ToRequest(request: ScrollRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_search/scroll/{request.ScrollId}"
                let queryParams =
                    [
                        request.Scroll |> Option.map (fun v -> "scroll", string v)
                        request.ScrollId2 |> Option.map (fun v -> "scroll_id", string v)
                        request.RestTotalHitsAsInt |> Option.map (fun v -> "rest_total_hits_as_int", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module ScrollRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ScrollRequest) : Result<Fes.Http.RequestMsg, exn> =
            ScrollRequest.ToRequest request

    type ScrollRequestBuilder() =
        member _.Yield(_: unit) : ScrollRequest =
            {
                ScrollRequest.ScrollId = Unchecked.defaultof<ScrollId>
                ScrollRequest.Scroll = Option.None
                ScrollRequest.ScrollId2 = Option.None
                ScrollRequest.RestTotalHitsAsInt = Option.None
                ScrollRequest.Scroll2 = Option.None
                ScrollRequest.ScrollId3 = Unchecked.defaultof<ScrollId>
            } : ScrollRequest

        [<CustomOperation("scroll_id")>]
        member _.ScrollId(state: ScrollRequest, value: ScrollId) =
            { state with ScrollRequest.ScrollId = value } : ScrollRequest

        [<CustomOperation("scroll")>]
        member _.Scroll(state: ScrollRequest, value: Duration) =
            { state with ScrollRequest.Scroll = Option.Some value } : ScrollRequest

        [<CustomOperation("scroll_id2")>]
        member _.ScrollId2(state: ScrollRequest, value: ScrollId) =
            { state with ScrollRequest.ScrollId2 = Option.Some value } : ScrollRequest

        [<CustomOperation("rest_total_hits_as_int")>]
        member _.RestTotalHitsAsInt(state: ScrollRequest, value: bool) =
            { state with ScrollRequest.RestTotalHitsAsInt = Option.Some value } : ScrollRequest

        [<CustomOperation("scroll2")>]
        member _.Scroll2(state: ScrollRequest, value: Duration) =
            { state with ScrollRequest.Scroll2 = Option.Some value } : ScrollRequest

        [<CustomOperation("scroll_id3")>]
        member _.ScrollId3(state: ScrollRequest, value: ScrollId) =
            { state with ScrollRequest.ScrollId3 = value } : ScrollRequest

    let scrollRequest = ScrollRequestBuilder()

    type ClearScrollRequest = {
        [<JsonPropertyName("scroll_id")>]
        ScrollId: ScrollIds
        [<JsonPropertyName("scroll_id")>]
        ScrollId2: ScrollIds option
    } with
        static member ToRequest(request: ClearScrollRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_search/scroll/{request.ScrollId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module ClearScrollRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ClearScrollRequest) : Result<Fes.Http.RequestMsg, exn> =
            ClearScrollRequest.ToRequest request

    type ClearScrollRequestBuilder() =
        member _.Yield(_: unit) : ClearScrollRequest =
            {
                ClearScrollRequest.ScrollId = Unchecked.defaultof<ScrollIds>
                ClearScrollRequest.ScrollId2 = Option.None
            } : ClearScrollRequest

        [<CustomOperation("scroll_id")>]
        member _.ScrollId(state: ClearScrollRequest, value: ScrollIds) =
            { state with ClearScrollRequest.ScrollId = value } : ClearScrollRequest

        [<CustomOperation("scroll_id2")>]
        member _.ScrollId2(state: ClearScrollRequest, value: ScrollIds) =
            { state with ClearScrollRequest.ScrollId2 = Option.Some value } : ClearScrollRequest

    let clearScrollRequest = ClearScrollRequestBuilder()

    type ClosePointInTimeRequest = {
        [<JsonPropertyName("id")>]
        Id: Id
    } with
        static member ToRequest(request: ClosePointInTimeRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_pit"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module ClosePointInTimeRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ClosePointInTimeRequest) : Result<Fes.Http.RequestMsg, exn> =
            ClosePointInTimeRequest.ToRequest request

    type ClosePointInTimeRequestBuilder() =
        member _.Yield(_: unit) : ClosePointInTimeRequest =
            {
                ClosePointInTimeRequest.Id = Unchecked.defaultof<Id>
            } : ClosePointInTimeRequest

        [<CustomOperation("id")>]
        member _.Id(state: ClosePointInTimeRequest, value: Id) =
            { state with ClosePointInTimeRequest.Id = value } : ClosePointInTimeRequest

    let closePointInTimeRequest = ClosePointInTimeRequestBuilder()

    type ClosePointInTimeResponse = {
        [<JsonPropertyName("succeeded")>]
        Succeeded: bool
        [<JsonPropertyName("num_freed")>]
        NumFreed: float
    }

    type CountRequest = {
        [<JsonPropertyName("index")>]
        Index: Indices
        [<JsonPropertyName("allow_no_indices")>]
        AllowNoIndices: bool option
        [<JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<JsonPropertyName("analyze_wildcard")>]
        AnalyzeWildcard: bool option
        [<JsonPropertyName("default_operator")>]
        DefaultOperator: QueryDslOperator option
        [<JsonPropertyName("df")>]
        Df: string option
        [<JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: ExpandWildcards option
        [<JsonPropertyName("ignore_throttled")>]
        IgnoreThrottled: bool option
        [<JsonPropertyName("ignore_unavailable")>]
        IgnoreUnavailable: bool option
        [<JsonPropertyName("lenient")>]
        Lenient: bool option
        [<JsonPropertyName("min_score")>]
        MinScore: float option
        [<JsonPropertyName("preference")>]
        Preference: string option
        [<JsonPropertyName("routing")>]
        Routing: Routing option
        [<JsonPropertyName("terminate_after")>]
        TerminateAfter: float option
        [<JsonPropertyName("q")>]
        Q: string option
        [<JsonPropertyName("query")>]
        Query: QueryDslQueryContainer option
    } with
        static member ToRequest(request: CountRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_count"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", string v)
                        request.Analyzer |> Option.map (fun v -> "analyzer", string v)
                        request.AnalyzeWildcard |> Option.map (fun v -> "analyze_wildcard", string v)
                        request.DefaultOperator |> Option.map (fun v -> "default_operator", string v)
                        request.Df |> Option.map (fun v -> "df", string v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", string v)
                        request.IgnoreThrottled |> Option.map (fun v -> "ignore_throttled", string v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", string v)
                        request.Lenient |> Option.map (fun v -> "lenient", string v)
                        request.MinScore |> Option.map (fun v -> "min_score", string v)
                        request.Preference |> Option.map (fun v -> "preference", string v)
                        request.Routing |> Option.map (fun v -> "routing", string v)
                        request.TerminateAfter |> Option.map (fun v -> "terminate_after", string v)
                        request.Q |> Option.map (fun v -> "q", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module CountRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CountRequest) : Result<Fes.Http.RequestMsg, exn> =
            CountRequest.ToRequest request

    type CountRequestBuilder() =
        member _.Yield(_: unit) : CountRequest =
            {
                CountRequest.Index = Unchecked.defaultof<Indices>
                CountRequest.AllowNoIndices = Option.None
                CountRequest.Analyzer = Option.None
                CountRequest.AnalyzeWildcard = Option.None
                CountRequest.DefaultOperator = Option.None
                CountRequest.Df = Option.None
                CountRequest.ExpandWildcards = Option.None
                CountRequest.IgnoreThrottled = Option.None
                CountRequest.IgnoreUnavailable = Option.None
                CountRequest.Lenient = Option.None
                CountRequest.MinScore = Option.None
                CountRequest.Preference = Option.None
                CountRequest.Routing = Option.None
                CountRequest.TerminateAfter = Option.None
                CountRequest.Q = Option.None
                CountRequest.Query = Option.None
            } : CountRequest

        [<CustomOperation("index")>]
        member _.Index(state: CountRequest, value: Indices) =
            { state with CountRequest.Index = value } : CountRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: CountRequest, value: bool) =
            { state with CountRequest.AllowNoIndices = Option.Some value } : CountRequest

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: CountRequest, value: string) =
            { state with CountRequest.Analyzer = Option.Some value } : CountRequest

        [<CustomOperation("analyze_wildcard")>]
        member _.AnalyzeWildcard(state: CountRequest, value: bool) =
            { state with CountRequest.AnalyzeWildcard = Option.Some value } : CountRequest

        [<CustomOperation("default_operator")>]
        member _.DefaultOperator(state: CountRequest, value: QueryDslOperator) =
            { state with CountRequest.DefaultOperator = Option.Some value } : CountRequest

        [<CustomOperation("df")>]
        member _.Df(state: CountRequest, value: string) =
            { state with CountRequest.Df = Option.Some value } : CountRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: CountRequest, value: ExpandWildcards) =
            { state with CountRequest.ExpandWildcards = Option.Some value } : CountRequest

        [<CustomOperation("ignore_throttled")>]
        member _.IgnoreThrottled(state: CountRequest, value: bool) =
            { state with CountRequest.IgnoreThrottled = Option.Some value } : CountRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: CountRequest, value: bool) =
            { state with CountRequest.IgnoreUnavailable = Option.Some value } : CountRequest

        [<CustomOperation("lenient")>]
        member _.Lenient(state: CountRequest, value: bool) =
            { state with CountRequest.Lenient = Option.Some value } : CountRequest

        [<CustomOperation("min_score")>]
        member _.MinScore(state: CountRequest, value: float) =
            { state with CountRequest.MinScore = Option.Some value } : CountRequest

        [<CustomOperation("preference")>]
        member _.Preference(state: CountRequest, value: string) =
            { state with CountRequest.Preference = Option.Some value } : CountRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: CountRequest, value: Routing) =
            { state with CountRequest.Routing = Option.Some value } : CountRequest

        [<CustomOperation("terminate_after")>]
        member _.TerminateAfter(state: CountRequest, value: float) =
            { state with CountRequest.TerminateAfter = Option.Some value } : CountRequest

        [<CustomOperation("q")>]
        member _.Q(state: CountRequest, value: string) =
            { state with CountRequest.Q = Option.Some value } : CountRequest

        [<CustomOperation("query")>]
        member _.Query(state: CountRequest, value: QueryDslQueryContainer) =
            { state with CountRequest.Query = Option.Some value } : CountRequest

    let countRequest = CountRequestBuilder()

    type ExplainRequest = {
        [<JsonPropertyName("index")>]
        Index: IndexName
        [<JsonPropertyName("id")>]
        Id: Id
        [<JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<JsonPropertyName("analyze_wildcard")>]
        AnalyzeWildcard: bool option
        [<JsonPropertyName("default_operator")>]
        DefaultOperator: QueryDslOperator option
        [<JsonPropertyName("df")>]
        Df: string option
        [<JsonPropertyName("lenient")>]
        Lenient: bool option
        [<JsonPropertyName("preference")>]
        Preference: string option
        [<JsonPropertyName("routing")>]
        Routing: Routing option
        [<JsonPropertyName("_source")>]
        Source: SearchTypesSourceConfigParam option
        [<JsonPropertyName("_source_excludes")>]
        SourceExcludes: Fields option
        [<JsonPropertyName("_source_includes")>]
        SourceIncludes: Fields option
        [<JsonPropertyName("stored_fields")>]
        StoredFields: Fields option
        [<JsonPropertyName("q")>]
        Q: string option
        [<JsonPropertyName("query")>]
        Query: QueryDslQueryContainer option
    } with
        static member ToRequest(request: ExplainRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_explain/{request.Id}"
                let queryParams =
                    [
                        request.Analyzer |> Option.map (fun v -> "analyzer", string v)
                        request.AnalyzeWildcard |> Option.map (fun v -> "analyze_wildcard", string v)
                        request.DefaultOperator |> Option.map (fun v -> "default_operator", string v)
                        request.Df |> Option.map (fun v -> "df", string v)
                        request.Lenient |> Option.map (fun v -> "lenient", string v)
                        request.Preference |> Option.map (fun v -> "preference", string v)
                        request.Routing |> Option.map (fun v -> "routing", string v)
                        request.Source |> Option.map (fun v -> "_source", string v)
                        request.SourceExcludes |> Option.map (fun v -> "_source_excludes", string v)
                        request.SourceIncludes |> Option.map (fun v -> "_source_includes", string v)
                        request.StoredFields |> Option.map (fun v -> "stored_fields", string v)
                        request.Q |> Option.map (fun v -> "q", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module ExplainRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ExplainRequest) : Result<Fes.Http.RequestMsg, exn> =
            ExplainRequest.ToRequest request

    type ExplainRequestBuilder() =
        member _.Yield(_: unit) : ExplainRequest =
            {
                ExplainRequest.Index = Unchecked.defaultof<IndexName>
                ExplainRequest.Id = Unchecked.defaultof<Id>
                ExplainRequest.Analyzer = Option.None
                ExplainRequest.AnalyzeWildcard = Option.None
                ExplainRequest.DefaultOperator = Option.None
                ExplainRequest.Df = Option.None
                ExplainRequest.Lenient = Option.None
                ExplainRequest.Preference = Option.None
                ExplainRequest.Routing = Option.None
                ExplainRequest.Source = Option.None
                ExplainRequest.SourceExcludes = Option.None
                ExplainRequest.SourceIncludes = Option.None
                ExplainRequest.StoredFields = Option.None
                ExplainRequest.Q = Option.None
                ExplainRequest.Query = Option.None
            } : ExplainRequest

        [<CustomOperation("index")>]
        member _.Index(state: ExplainRequest, value: IndexName) =
            { state with ExplainRequest.Index = value } : ExplainRequest

        [<CustomOperation("id")>]
        member _.Id(state: ExplainRequest, value: Id) =
            { state with ExplainRequest.Id = value } : ExplainRequest

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: ExplainRequest, value: string) =
            { state with ExplainRequest.Analyzer = Option.Some value } : ExplainRequest

        [<CustomOperation("analyze_wildcard")>]
        member _.AnalyzeWildcard(state: ExplainRequest, value: bool) =
            { state with ExplainRequest.AnalyzeWildcard = Option.Some value } : ExplainRequest

        [<CustomOperation("default_operator")>]
        member _.DefaultOperator(state: ExplainRequest, value: QueryDslOperator) =
            { state with ExplainRequest.DefaultOperator = Option.Some value } : ExplainRequest

        [<CustomOperation("df")>]
        member _.Df(state: ExplainRequest, value: string) =
            { state with ExplainRequest.Df = Option.Some value } : ExplainRequest

        [<CustomOperation("lenient")>]
        member _.Lenient(state: ExplainRequest, value: bool) =
            { state with ExplainRequest.Lenient = Option.Some value } : ExplainRequest

        [<CustomOperation("preference")>]
        member _.Preference(state: ExplainRequest, value: string) =
            { state with ExplainRequest.Preference = Option.Some value } : ExplainRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: ExplainRequest, value: Routing) =
            { state with ExplainRequest.Routing = Option.Some value } : ExplainRequest

        [<CustomOperation("_source")>]
        member _.Source(state: ExplainRequest, value: SearchTypesSourceConfigParam) =
            { state with ExplainRequest.Source = Option.Some value } : ExplainRequest

        [<CustomOperation("_source_excludes")>]
        member _.SourceExcludes(state: ExplainRequest, value: Fields) =
            { state with ExplainRequest.SourceExcludes = Option.Some value } : ExplainRequest

        [<CustomOperation("_source_includes")>]
        member _.SourceIncludes(state: ExplainRequest, value: Fields) =
            { state with ExplainRequest.SourceIncludes = Option.Some value } : ExplainRequest

        [<CustomOperation("stored_fields")>]
        member _.StoredFields(state: ExplainRequest, value: Fields) =
            { state with ExplainRequest.StoredFields = Option.Some value } : ExplainRequest

        [<CustomOperation("q")>]
        member _.Q(state: ExplainRequest, value: string) =
            { state with ExplainRequest.Q = Option.Some value } : ExplainRequest

        [<CustomOperation("query")>]
        member _.Query(state: ExplainRequest, value: QueryDslQueryContainer) =
            { state with ExplainRequest.Query = Option.Some value } : ExplainRequest

    let explainRequest = ExplainRequestBuilder()

    type FieldCapsRequest = {
        [<JsonPropertyName("index")>]
        Index: Indices
        [<JsonPropertyName("allow_no_indices")>]
        AllowNoIndices: bool option
        [<JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: ExpandWildcards option
        [<JsonPropertyName("fields")>]
        Fields: Fields option
        [<JsonPropertyName("ignore_unavailable")>]
        IgnoreUnavailable: bool option
        [<JsonPropertyName("include_unmapped")>]
        IncludeUnmapped: bool option
        [<JsonPropertyName("filters")>]
        Filters: System.Text.Json.JsonElement option
        [<JsonPropertyName("types")>]
        Types: string array option
        [<JsonPropertyName("include_empty_fields")>]
        IncludeEmptyFields: bool option
        [<JsonPropertyName("fields")>]
        Fields2: Fields option
        [<JsonPropertyName("index_filter")>]
        IndexFilter: QueryDslQueryContainer option
        [<JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: MappingRuntimeFields option
    } with
        static member ToRequest(request: FieldCapsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_field_caps"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", string v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", string v)
                        request.Fields |> Option.map (fun v -> "fields", string v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", string v)
                        request.IncludeUnmapped |> Option.map (fun v -> "include_unmapped", string v)
                        request.Filters |> Option.map (fun v -> "filters", string v)
                        request.Types |> Option.map (fun v -> "types", string v)
                        request.IncludeEmptyFields |> Option.map (fun v -> "include_empty_fields", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module FieldCapsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: FieldCapsRequest) : Result<Fes.Http.RequestMsg, exn> =
            FieldCapsRequest.ToRequest request

    type FieldCapsRequestBuilder() =
        member _.Yield(_: unit) : FieldCapsRequest =
            {
                FieldCapsRequest.Index = Unchecked.defaultof<Indices>
                FieldCapsRequest.AllowNoIndices = Option.None
                FieldCapsRequest.ExpandWildcards = Option.None
                FieldCapsRequest.Fields = Option.None
                FieldCapsRequest.IgnoreUnavailable = Option.None
                FieldCapsRequest.IncludeUnmapped = Option.None
                FieldCapsRequest.Filters = Option.None
                FieldCapsRequest.Types = Option.None
                FieldCapsRequest.IncludeEmptyFields = Option.None
                FieldCapsRequest.Fields2 = Option.None
                FieldCapsRequest.IndexFilter = Option.None
                FieldCapsRequest.RuntimeMappings = Option.None
            } : FieldCapsRequest

        [<CustomOperation("index")>]
        member _.Index(state: FieldCapsRequest, value: Indices) =
            { state with FieldCapsRequest.Index = value } : FieldCapsRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: FieldCapsRequest, value: bool) =
            { state with FieldCapsRequest.AllowNoIndices = Option.Some value } : FieldCapsRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: FieldCapsRequest, value: ExpandWildcards) =
            { state with FieldCapsRequest.ExpandWildcards = Option.Some value } : FieldCapsRequest

        [<CustomOperation("fields")>]
        member _.Fields(state: FieldCapsRequest, value: Fields) =
            { state with FieldCapsRequest.Fields = Option.Some value } : FieldCapsRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: FieldCapsRequest, value: bool) =
            { state with FieldCapsRequest.IgnoreUnavailable = Option.Some value } : FieldCapsRequest

        [<CustomOperation("include_unmapped")>]
        member _.IncludeUnmapped(state: FieldCapsRequest, value: bool) =
            { state with FieldCapsRequest.IncludeUnmapped = Option.Some value } : FieldCapsRequest

        [<CustomOperation("filters")>]
        member _.Filters(state: FieldCapsRequest, value: System.Text.Json.JsonElement) =
            { state with FieldCapsRequest.Filters = Option.Some value } : FieldCapsRequest

        [<CustomOperation("types")>]
        member _.Types(state: FieldCapsRequest, value: string array) =
            { state with FieldCapsRequest.Types = Option.Some value } : FieldCapsRequest

        [<CustomOperation("include_empty_fields")>]
        member _.IncludeEmptyFields(state: FieldCapsRequest, value: bool) =
            { state with FieldCapsRequest.IncludeEmptyFields = Option.Some value } : FieldCapsRequest

        [<CustomOperation("fields2")>]
        member _.Fields2(state: FieldCapsRequest, value: Fields) =
            { state with FieldCapsRequest.Fields2 = Option.Some value } : FieldCapsRequest

        [<CustomOperation("index_filter")>]
        member _.IndexFilter(state: FieldCapsRequest, value: QueryDslQueryContainer) =
            { state with FieldCapsRequest.IndexFilter = Option.Some value } : FieldCapsRequest

        [<CustomOperation("runtime_mappings")>]
        member _.RuntimeMappings(state: FieldCapsRequest, value: MappingRuntimeFields) =
            { state with FieldCapsRequest.RuntimeMappings = Option.Some value } : FieldCapsRequest

    let fieldCapsRequest = FieldCapsRequestBuilder()

    type MsearchRequest = {
        [<JsonPropertyName("index")>]
        Index: Indices
        [<JsonPropertyName("allow_no_indices")>]
        AllowNoIndices: bool option
        [<JsonPropertyName("ccs_minimize_roundtrips")>]
        CcsMinimizeRoundtrips: bool option
        [<JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: ExpandWildcards option
        [<JsonPropertyName("ignore_throttled")>]
        IgnoreThrottled: bool option
        [<JsonPropertyName("ignore_unavailable")>]
        IgnoreUnavailable: bool option
        [<JsonPropertyName("include_named_queries_score")>]
        IncludeNamedQueriesScore: bool option
        [<JsonPropertyName("index")>]
        Index2: Indices option
        [<JsonPropertyName("max_concurrent_searches")>]
        MaxConcurrentSearches: float option
        [<JsonPropertyName("max_concurrent_shard_requests")>]
        MaxConcurrentShardRequests: float option
        [<JsonPropertyName("pre_filter_shard_size")>]
        PreFilterShardSize: float option
        [<JsonPropertyName("rest_total_hits_as_int")>]
        RestTotalHitsAsInt: bool option
        [<JsonPropertyName("routing")>]
        Routing: Routing option
        [<JsonPropertyName("search_type")>]
        SearchType: SearchType option
        [<JsonPropertyName("typed_keys")>]
        TypedKeys: bool option
    } with
        static member ToRequest(request: MsearchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_msearch"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", string v)
                        request.CcsMinimizeRoundtrips |> Option.map (fun v -> "ccs_minimize_roundtrips", string v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", string v)
                        request.IgnoreThrottled |> Option.map (fun v -> "ignore_throttled", string v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", string v)
                        request.IncludeNamedQueriesScore |> Option.map (fun v -> "include_named_queries_score", string v)
                        request.Index2 |> Option.map (fun v -> "index", string v)
                        request.MaxConcurrentSearches |> Option.map (fun v -> "max_concurrent_searches", string v)
                        request.MaxConcurrentShardRequests |> Option.map (fun v -> "max_concurrent_shard_requests", string v)
                        request.PreFilterShardSize |> Option.map (fun v -> "pre_filter_shard_size", string v)
                        request.RestTotalHitsAsInt |> Option.map (fun v -> "rest_total_hits_as_int", string v)
                        request.Routing |> Option.map (fun v -> "routing", string v)
                        request.SearchType |> Option.map (fun v -> "search_type", string v)
                        request.TypedKeys |> Option.map (fun v -> "typed_keys", string v)
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

    module MsearchRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MsearchRequest) : Result<Fes.Http.RequestMsg, exn> =
            MsearchRequest.ToRequest request

    type MsearchRequestBuilder() =
        member _.Yield(_: unit) : MsearchRequest =
            {
                MsearchRequest.Index = Unchecked.defaultof<Indices>
                MsearchRequest.AllowNoIndices = Option.None
                MsearchRequest.CcsMinimizeRoundtrips = Option.None
                MsearchRequest.ExpandWildcards = Option.None
                MsearchRequest.IgnoreThrottled = Option.None
                MsearchRequest.IgnoreUnavailable = Option.None
                MsearchRequest.IncludeNamedQueriesScore = Option.None
                MsearchRequest.Index2 = Option.None
                MsearchRequest.MaxConcurrentSearches = Option.None
                MsearchRequest.MaxConcurrentShardRequests = Option.None
                MsearchRequest.PreFilterShardSize = Option.None
                MsearchRequest.RestTotalHitsAsInt = Option.None
                MsearchRequest.Routing = Option.None
                MsearchRequest.SearchType = Option.None
                MsearchRequest.TypedKeys = Option.None
            } : MsearchRequest

        [<CustomOperation("index")>]
        member _.Index(state: MsearchRequest, value: Indices) =
            { state with MsearchRequest.Index = value } : MsearchRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: MsearchRequest, value: bool) =
            { state with MsearchRequest.AllowNoIndices = Option.Some value } : MsearchRequest

        [<CustomOperation("ccs_minimize_roundtrips")>]
        member _.CcsMinimizeRoundtrips(state: MsearchRequest, value: bool) =
            { state with MsearchRequest.CcsMinimizeRoundtrips = Option.Some value } : MsearchRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: MsearchRequest, value: ExpandWildcards) =
            { state with MsearchRequest.ExpandWildcards = Option.Some value } : MsearchRequest

        [<CustomOperation("ignore_throttled")>]
        member _.IgnoreThrottled(state: MsearchRequest, value: bool) =
            { state with MsearchRequest.IgnoreThrottled = Option.Some value } : MsearchRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: MsearchRequest, value: bool) =
            { state with MsearchRequest.IgnoreUnavailable = Option.Some value } : MsearchRequest

        [<CustomOperation("include_named_queries_score")>]
        member _.IncludeNamedQueriesScore(state: MsearchRequest, value: bool) =
            { state with MsearchRequest.IncludeNamedQueriesScore = Option.Some value } : MsearchRequest

        [<CustomOperation("index2")>]
        member _.Index2(state: MsearchRequest, value: Indices) =
            { state with MsearchRequest.Index2 = Option.Some value } : MsearchRequest

        [<CustomOperation("max_concurrent_searches")>]
        member _.MaxConcurrentSearches(state: MsearchRequest, value: float) =
            { state with MsearchRequest.MaxConcurrentSearches = Option.Some value } : MsearchRequest

        [<CustomOperation("max_concurrent_shard_requests")>]
        member _.MaxConcurrentShardRequests(state: MsearchRequest, value: float) =
            { state with MsearchRequest.MaxConcurrentShardRequests = Option.Some value } : MsearchRequest

        [<CustomOperation("pre_filter_shard_size")>]
        member _.PreFilterShardSize(state: MsearchRequest, value: float) =
            { state with MsearchRequest.PreFilterShardSize = Option.Some value } : MsearchRequest

        [<CustomOperation("rest_total_hits_as_int")>]
        member _.RestTotalHitsAsInt(state: MsearchRequest, value: bool) =
            { state with MsearchRequest.RestTotalHitsAsInt = Option.Some value } : MsearchRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: MsearchRequest, value: Routing) =
            { state with MsearchRequest.Routing = Option.Some value } : MsearchRequest

        [<CustomOperation("search_type")>]
        member _.SearchType(state: MsearchRequest, value: SearchType) =
            { state with MsearchRequest.SearchType = Option.Some value } : MsearchRequest

        [<CustomOperation("typed_keys")>]
        member _.TypedKeys(state: MsearchRequest, value: bool) =
            { state with MsearchRequest.TypedKeys = Option.Some value } : MsearchRequest

    let msearchRequest = MsearchRequestBuilder()

    type MsearchTemplateRequest = {
        [<JsonPropertyName("index")>]
        Index: Indices
        [<JsonPropertyName("ccs_minimize_roundtrips")>]
        CcsMinimizeRoundtrips: bool option
        [<JsonPropertyName("max_concurrent_searches")>]
        MaxConcurrentSearches: float option
        [<JsonPropertyName("search_type")>]
        SearchType: SearchType option
        [<JsonPropertyName("rest_total_hits_as_int")>]
        RestTotalHitsAsInt: bool option
        [<JsonPropertyName("typed_keys")>]
        TypedKeys: bool option
    } with
        static member ToRequest(request: MsearchTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_msearch/template"
                let queryParams =
                    [
                        request.CcsMinimizeRoundtrips |> Option.map (fun v -> "ccs_minimize_roundtrips", string v)
                        request.MaxConcurrentSearches |> Option.map (fun v -> "max_concurrent_searches", string v)
                        request.SearchType |> Option.map (fun v -> "search_type", string v)
                        request.RestTotalHitsAsInt |> Option.map (fun v -> "rest_total_hits_as_int", string v)
                        request.TypedKeys |> Option.map (fun v -> "typed_keys", string v)
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

    module MsearchTemplateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MsearchTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            MsearchTemplateRequest.ToRequest request

    type MsearchTemplateRequestBuilder() =
        member _.Yield(_: unit) : MsearchTemplateRequest =
            {
                MsearchTemplateRequest.Index = Unchecked.defaultof<Indices>
                MsearchTemplateRequest.CcsMinimizeRoundtrips = Option.None
                MsearchTemplateRequest.MaxConcurrentSearches = Option.None
                MsearchTemplateRequest.SearchType = Option.None
                MsearchTemplateRequest.RestTotalHitsAsInt = Option.None
                MsearchTemplateRequest.TypedKeys = Option.None
            } : MsearchTemplateRequest

        [<CustomOperation("index")>]
        member _.Index(state: MsearchTemplateRequest, value: Indices) =
            { state with MsearchTemplateRequest.Index = value } : MsearchTemplateRequest

        [<CustomOperation("ccs_minimize_roundtrips")>]
        member _.CcsMinimizeRoundtrips(state: MsearchTemplateRequest, value: bool) =
            { state with MsearchTemplateRequest.CcsMinimizeRoundtrips = Option.Some value } : MsearchTemplateRequest

        [<CustomOperation("max_concurrent_searches")>]
        member _.MaxConcurrentSearches(state: MsearchTemplateRequest, value: float) =
            { state with MsearchTemplateRequest.MaxConcurrentSearches = Option.Some value } : MsearchTemplateRequest

        [<CustomOperation("search_type")>]
        member _.SearchType(state: MsearchTemplateRequest, value: SearchType) =
            { state with MsearchTemplateRequest.SearchType = Option.Some value } : MsearchTemplateRequest

        [<CustomOperation("rest_total_hits_as_int")>]
        member _.RestTotalHitsAsInt(state: MsearchTemplateRequest, value: bool) =
            { state with MsearchTemplateRequest.RestTotalHitsAsInt = Option.Some value } : MsearchTemplateRequest

        [<CustomOperation("typed_keys")>]
        member _.TypedKeys(state: MsearchTemplateRequest, value: bool) =
            { state with MsearchTemplateRequest.TypedKeys = Option.Some value } : MsearchTemplateRequest

    let msearchTemplateRequest = MsearchTemplateRequestBuilder()

    type OpenPointInTimeRequest = {
        [<JsonPropertyName("index")>]
        Index: Indices
        [<JsonPropertyName("keep_alive")>]
        KeepAlive: Duration
        [<JsonPropertyName("ignore_unavailable")>]
        IgnoreUnavailable: bool option
        [<JsonPropertyName("preference")>]
        Preference: string option
        [<JsonPropertyName("routing")>]
        Routing: Routing option
        [<JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: ExpandWildcards option
        [<JsonPropertyName("allow_partial_search_results")>]
        AllowPartialSearchResults: bool option
        [<JsonPropertyName("max_concurrent_shard_requests")>]
        MaxConcurrentShardRequests: float option
        [<JsonPropertyName("index_filter")>]
        IndexFilter: QueryDslQueryContainer option
    } with
        static member ToRequest(request: OpenPointInTimeRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_pit"
                let queryParams =
                    [
                        Some ("keep_alive", string request.KeepAlive)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", string v)
                        request.Preference |> Option.map (fun v -> "preference", string v)
                        request.Routing |> Option.map (fun v -> "routing", string v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", string v)
                        request.AllowPartialSearchResults |> Option.map (fun v -> "allow_partial_search_results", string v)
                        request.MaxConcurrentShardRequests |> Option.map (fun v -> "max_concurrent_shard_requests", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module OpenPointInTimeRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: OpenPointInTimeRequest) : Result<Fes.Http.RequestMsg, exn> =
            OpenPointInTimeRequest.ToRequest request

    type OpenPointInTimeRequestBuilder() =
        member _.Yield(_: unit) : OpenPointInTimeRequest =
            {
                OpenPointInTimeRequest.Index = Unchecked.defaultof<Indices>
                OpenPointInTimeRequest.KeepAlive = Unchecked.defaultof<Duration>
                OpenPointInTimeRequest.IgnoreUnavailable = Option.None
                OpenPointInTimeRequest.Preference = Option.None
                OpenPointInTimeRequest.Routing = Option.None
                OpenPointInTimeRequest.ExpandWildcards = Option.None
                OpenPointInTimeRequest.AllowPartialSearchResults = Option.None
                OpenPointInTimeRequest.MaxConcurrentShardRequests = Option.None
                OpenPointInTimeRequest.IndexFilter = Option.None
            } : OpenPointInTimeRequest

        [<CustomOperation("index")>]
        member _.Index(state: OpenPointInTimeRequest, value: Indices) =
            { state with OpenPointInTimeRequest.Index = value } : OpenPointInTimeRequest

        [<CustomOperation("keep_alive")>]
        member _.KeepAlive(state: OpenPointInTimeRequest, value: Duration) =
            { state with OpenPointInTimeRequest.KeepAlive = value } : OpenPointInTimeRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: OpenPointInTimeRequest, value: bool) =
            { state with OpenPointInTimeRequest.IgnoreUnavailable = Option.Some value } : OpenPointInTimeRequest

        [<CustomOperation("preference")>]
        member _.Preference(state: OpenPointInTimeRequest, value: string) =
            { state with OpenPointInTimeRequest.Preference = Option.Some value } : OpenPointInTimeRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: OpenPointInTimeRequest, value: Routing) =
            { state with OpenPointInTimeRequest.Routing = Option.Some value } : OpenPointInTimeRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: OpenPointInTimeRequest, value: ExpandWildcards) =
            { state with OpenPointInTimeRequest.ExpandWildcards = Option.Some value } : OpenPointInTimeRequest

        [<CustomOperation("allow_partial_search_results")>]
        member _.AllowPartialSearchResults(state: OpenPointInTimeRequest, value: bool) =
            { state with OpenPointInTimeRequest.AllowPartialSearchResults = Option.Some value } : OpenPointInTimeRequest

        [<CustomOperation("max_concurrent_shard_requests")>]
        member _.MaxConcurrentShardRequests(state: OpenPointInTimeRequest, value: float) =
            { state with OpenPointInTimeRequest.MaxConcurrentShardRequests = Option.Some value } : OpenPointInTimeRequest

        [<CustomOperation("index_filter")>]
        member _.IndexFilter(state: OpenPointInTimeRequest, value: QueryDslQueryContainer) =
            { state with OpenPointInTimeRequest.IndexFilter = Option.Some value } : OpenPointInTimeRequest

    let openPointInTimeRequest = OpenPointInTimeRequestBuilder()

    type OpenPointInTimeResponse = {
        [<JsonPropertyName("_shards")>]
        Shards: ShardStatistics
        [<JsonPropertyName("id")>]
        Id: Id
    }

    type RankEvalRequest = {
        [<JsonPropertyName("index")>]
        Index: Indices
        [<JsonPropertyName("allow_no_indices")>]
        AllowNoIndices: bool option
        [<JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: ExpandWildcards option
        [<JsonPropertyName("ignore_unavailable")>]
        IgnoreUnavailable: bool option
        [<JsonPropertyName("search_type")>]
        SearchType: SearchType option
        [<JsonPropertyName("requests")>]
        Requests: RankEvalRankEvalRequestItem array
        [<JsonPropertyName("metric")>]
        Metric: RankEvalRankEvalMetric option
    } with
        static member ToRequest(request: RankEvalRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_rank_eval"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", string v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", string v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", string v)
                        request.SearchType |> Option.map (fun v -> "search_type", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module RankEvalRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: RankEvalRequest) : Result<Fes.Http.RequestMsg, exn> =
            RankEvalRequest.ToRequest request

    type RankEvalRequestBuilder() =
        member _.Yield(_: unit) : RankEvalRequest =
            {
                RankEvalRequest.Index = Unchecked.defaultof<Indices>
                RankEvalRequest.AllowNoIndices = Option.None
                RankEvalRequest.ExpandWildcards = Option.None
                RankEvalRequest.IgnoreUnavailable = Option.None
                RankEvalRequest.SearchType = Option.None
                RankEvalRequest.Requests = [||]
                RankEvalRequest.Metric = Option.None
            } : RankEvalRequest

        [<CustomOperation("index")>]
        member _.Index(state: RankEvalRequest, value: Indices) =
            { state with RankEvalRequest.Index = value } : RankEvalRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: RankEvalRequest, value: bool) =
            { state with RankEvalRequest.AllowNoIndices = Option.Some value } : RankEvalRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: RankEvalRequest, value: ExpandWildcards) =
            { state with RankEvalRequest.ExpandWildcards = Option.Some value } : RankEvalRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: RankEvalRequest, value: bool) =
            { state with RankEvalRequest.IgnoreUnavailable = Option.Some value } : RankEvalRequest

        [<CustomOperation("search_type")>]
        member _.SearchType(state: RankEvalRequest, value: SearchType) =
            { state with RankEvalRequest.SearchType = Option.Some value } : RankEvalRequest

        [<CustomOperation("requests")>]
        member _.Requests(state: RankEvalRequest, value: RankEvalRankEvalRequestItem array) =
            { state with RankEvalRequest.Requests = value } : RankEvalRequest

        [<CustomOperation("metric")>]
        member _.Metric(state: RankEvalRequest, value: RankEvalRankEvalMetric) =
            { state with RankEvalRequest.Metric = Option.Some value } : RankEvalRequest

    let rankEvalRequest = RankEvalRequestBuilder()

    type RenderSearchTemplateRequest = {
        [<JsonPropertyName("id")>]
        Id: Id
        [<JsonPropertyName("id")>]
        Id2: Id option
        [<JsonPropertyName("file")>]
        File: string option
        [<JsonPropertyName("params")>]
        Params: Map<string, obj> option
        [<JsonPropertyName("source")>]
        Source: ScriptSource option
    } with
        static member ToRequest(request: RenderSearchTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_render/template/{request.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module RenderSearchTemplateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: RenderSearchTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            RenderSearchTemplateRequest.ToRequest request

    type RenderSearchTemplateRequestBuilder() =
        member _.Yield(_: unit) : RenderSearchTemplateRequest =
            {
                RenderSearchTemplateRequest.Id = Unchecked.defaultof<Id>
                RenderSearchTemplateRequest.Id2 = Option.None
                RenderSearchTemplateRequest.File = Option.None
                RenderSearchTemplateRequest.Params = Option.None
                RenderSearchTemplateRequest.Source = Option.None
            } : RenderSearchTemplateRequest

        [<CustomOperation("id")>]
        member _.Id(state: RenderSearchTemplateRequest, value: Id) =
            { state with RenderSearchTemplateRequest.Id = value } : RenderSearchTemplateRequest

        [<CustomOperation("id2")>]
        member _.Id2(state: RenderSearchTemplateRequest, value: Id) =
            { state with RenderSearchTemplateRequest.Id2 = Option.Some value } : RenderSearchTemplateRequest

        [<CustomOperation("file")>]
        member _.File(state: RenderSearchTemplateRequest, value: string) =
            { state with RenderSearchTemplateRequest.File = Option.Some value } : RenderSearchTemplateRequest

        [<CustomOperation("params")>]
        member _.Params(state: RenderSearchTemplateRequest, value: Map<string, obj>) =
            { state with RenderSearchTemplateRequest.Params = Option.Some value } : RenderSearchTemplateRequest

        [<CustomOperation("source")>]
        member _.Source(state: RenderSearchTemplateRequest, value: ScriptSource) =
            { state with RenderSearchTemplateRequest.Source = Option.Some value } : RenderSearchTemplateRequest

    let renderSearchTemplateRequest = RenderSearchTemplateRequestBuilder()

    type SearchRequest = {
        [<JsonPropertyName("index")>]
        Index: Indices
        [<JsonPropertyName("allow_no_indices")>]
        AllowNoIndices: bool option
        [<JsonPropertyName("allow_partial_search_results")>]
        AllowPartialSearchResults: bool option
        [<JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<JsonPropertyName("analyze_wildcard")>]
        AnalyzeWildcard: bool option
        [<JsonPropertyName("batched_reduce_size")>]
        BatchedReduceSize: float option
        [<JsonPropertyName("ccs_minimize_roundtrips")>]
        CcsMinimizeRoundtrips: bool option
        [<JsonPropertyName("default_operator")>]
        DefaultOperator: QueryDslOperator option
        [<JsonPropertyName("df")>]
        Df: string option
        [<JsonPropertyName("docvalue_fields")>]
        DocvalueFields: Fields option
        [<JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: ExpandWildcards option
        [<JsonPropertyName("explain")>]
        Explain: bool option
        [<JsonPropertyName("ignore_throttled")>]
        IgnoreThrottled: bool option
        [<JsonPropertyName("ignore_unavailable")>]
        IgnoreUnavailable: bool option
        [<JsonPropertyName("include_named_queries_score")>]
        IncludeNamedQueriesScore: bool option
        [<JsonPropertyName("lenient")>]
        Lenient: bool option
        [<JsonPropertyName("max_concurrent_shard_requests")>]
        MaxConcurrentShardRequests: float option
        [<JsonPropertyName("preference")>]
        Preference: string option
        [<JsonPropertyName("pre_filter_shard_size")>]
        PreFilterShardSize: float option
        [<JsonPropertyName("request_cache")>]
        RequestCache: bool option
        [<JsonPropertyName("routing")>]
        Routing: Routing option
        [<JsonPropertyName("scroll")>]
        Scroll: Duration option
        [<JsonPropertyName("search_type")>]
        SearchType: SearchType option
        [<JsonPropertyName("stats")>]
        Stats: string array option
        [<JsonPropertyName("stored_fields")>]
        StoredFields: Fields option
        [<JsonPropertyName("suggest_field")>]
        SuggestField: Field option
        [<JsonPropertyName("suggest_mode")>]
        SuggestMode: SuggestMode option
        [<JsonPropertyName("suggest_size")>]
        SuggestSize: float option
        [<JsonPropertyName("suggest_text")>]
        SuggestText: string option
        [<JsonPropertyName("terminate_after")>]
        TerminateAfter: float option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
        [<JsonPropertyName("track_total_hits")>]
        TrackTotalHits: SearchTypesTrackHits option
        [<JsonPropertyName("track_scores")>]
        TrackScores: bool option
        [<JsonPropertyName("typed_keys")>]
        TypedKeys: bool option
        [<JsonPropertyName("rest_total_hits_as_int")>]
        RestTotalHitsAsInt: bool option
        [<JsonPropertyName("version")>]
        Version: bool option
        [<JsonPropertyName("_source")>]
        Source: SearchTypesSourceConfigParam option
        [<JsonPropertyName("_source_excludes")>]
        SourceExcludes: Fields option
        [<JsonPropertyName("_source_exclude_vectors")>]
        SourceExcludeVectors: bool option
        [<JsonPropertyName("_source_includes")>]
        SourceIncludes: Fields option
        [<JsonPropertyName("seq_no_primary_term")>]
        SeqNoPrimaryTerm: bool option
        [<JsonPropertyName("q")>]
        Q: string option
        [<JsonPropertyName("size")>]
        Size: float option
        [<JsonPropertyName("from")>]
        From: float option
        [<JsonPropertyName("sort")>]
        Sort: System.Text.Json.JsonElement option
        [<JsonPropertyName("aggregations")>]
        Aggregations: Map<string, AggregationsAggregationContainer> option
        [<JsonPropertyName("collapse")>]
        Collapse: SearchTypesFieldCollapse option
        [<JsonPropertyName("explain")>]
        Explain2: bool option
        [<JsonPropertyName("ext")>]
        Ext: Map<string, obj> option
        [<JsonPropertyName("from")>]
        From2: float option
        [<JsonPropertyName("highlight")>]
        Highlight: SearchTypesHighlight option
        [<JsonPropertyName("track_total_hits")>]
        TrackTotalHits2: SearchTypesTrackHits option
        [<JsonPropertyName("indices_boost")>]
        IndicesBoost: Map<string, float> array option
        [<JsonPropertyName("docvalue_fields")>]
        DocvalueFields2: QueryDslFieldAndFormat array option
        [<JsonPropertyName("knn")>]
        Knn: System.Text.Json.JsonElement option
        [<JsonPropertyName("rank")>]
        Rank: RankContainer option
        [<JsonPropertyName("min_score")>]
        MinScore: float option
        [<JsonPropertyName("post_filter")>]
        PostFilter: QueryDslQueryContainer option
        [<JsonPropertyName("profile")>]
        Profile: bool option
        [<JsonPropertyName("query")>]
        Query: QueryDslQueryContainer option
        [<JsonPropertyName("rescore")>]
        Rescore: System.Text.Json.JsonElement option
        [<JsonPropertyName("retriever")>]
        Retriever: RetrieverContainer option
        [<JsonPropertyName("script_fields")>]
        ScriptFields: Map<string, ScriptField> option
        [<JsonPropertyName("search_after")>]
        SearchAfter: SortResults option
        [<JsonPropertyName("size")>]
        Size2: float option
        [<JsonPropertyName("slice")>]
        Slice: SlicedScroll option
        [<JsonPropertyName("sort")>]
        Sort2: Sort option
        [<JsonPropertyName("_source")>]
        Source2: SearchTypesSourceConfig option
        [<JsonPropertyName("fields")>]
        Fields: QueryDslFieldAndFormat array option
        [<JsonPropertyName("suggest")>]
        Suggest: SearchTypesSuggester option
        [<JsonPropertyName("terminate_after")>]
        TerminateAfter2: float option
        [<JsonPropertyName("timeout")>]
        Timeout2: string option
        [<JsonPropertyName("track_scores")>]
        TrackScores2: bool option
        [<JsonPropertyName("version")>]
        Version2: bool option
        [<JsonPropertyName("seq_no_primary_term")>]
        SeqNoPrimaryTerm2: bool option
        [<JsonPropertyName("stored_fields")>]
        StoredFields2: Fields option
        [<JsonPropertyName("pit")>]
        Pit: SearchTypesPointInTimeReference option
        [<JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: MappingRuntimeFields option
        [<JsonPropertyName("stats")>]
        Stats2: string array option
    } with
        static member ToRequest(request: SearchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_search"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", string v)
                        request.AllowPartialSearchResults |> Option.map (fun v -> "allow_partial_search_results", string v)
                        request.Analyzer |> Option.map (fun v -> "analyzer", string v)
                        request.AnalyzeWildcard |> Option.map (fun v -> "analyze_wildcard", string v)
                        request.BatchedReduceSize |> Option.map (fun v -> "batched_reduce_size", string v)
                        request.CcsMinimizeRoundtrips |> Option.map (fun v -> "ccs_minimize_roundtrips", string v)
                        request.DefaultOperator |> Option.map (fun v -> "default_operator", string v)
                        request.Df |> Option.map (fun v -> "df", string v)
                        request.DocvalueFields |> Option.map (fun v -> "docvalue_fields", string v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", string v)
                        request.Explain |> Option.map (fun v -> "explain", string v)
                        request.IgnoreThrottled |> Option.map (fun v -> "ignore_throttled", string v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", string v)
                        request.IncludeNamedQueriesScore |> Option.map (fun v -> "include_named_queries_score", string v)
                        request.Lenient |> Option.map (fun v -> "lenient", string v)
                        request.MaxConcurrentShardRequests |> Option.map (fun v -> "max_concurrent_shard_requests", string v)
                        request.Preference |> Option.map (fun v -> "preference", string v)
                        request.PreFilterShardSize |> Option.map (fun v -> "pre_filter_shard_size", string v)
                        request.RequestCache |> Option.map (fun v -> "request_cache", string v)
                        request.Routing |> Option.map (fun v -> "routing", string v)
                        request.Scroll |> Option.map (fun v -> "scroll", string v)
                        request.SearchType |> Option.map (fun v -> "search_type", string v)
                        request.Stats |> Option.map (fun v -> "stats", string v)
                        request.StoredFields |> Option.map (fun v -> "stored_fields", string v)
                        request.SuggestField |> Option.map (fun v -> "suggest_field", string v)
                        request.SuggestMode |> Option.map (fun v -> "suggest_mode", string v)
                        request.SuggestSize |> Option.map (fun v -> "suggest_size", string v)
                        request.SuggestText |> Option.map (fun v -> "suggest_text", string v)
                        request.TerminateAfter |> Option.map (fun v -> "terminate_after", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                        request.TrackTotalHits |> Option.map (fun v -> "track_total_hits", string v)
                        request.TrackScores |> Option.map (fun v -> "track_scores", string v)
                        request.TypedKeys |> Option.map (fun v -> "typed_keys", string v)
                        request.RestTotalHitsAsInt |> Option.map (fun v -> "rest_total_hits_as_int", string v)
                        request.Version |> Option.map (fun v -> "version", string v)
                        request.Source |> Option.map (fun v -> "_source", string v)
                        request.SourceExcludes |> Option.map (fun v -> "_source_excludes", string v)
                        request.SourceExcludeVectors |> Option.map (fun v -> "_source_exclude_vectors", string v)
                        request.SourceIncludes |> Option.map (fun v -> "_source_includes", string v)
                        request.SeqNoPrimaryTerm |> Option.map (fun v -> "seq_no_primary_term", string v)
                        request.Q |> Option.map (fun v -> "q", string v)
                        request.Size |> Option.map (fun v -> "size", string v)
                        request.From |> Option.map (fun v -> "from", string v)
                        request.Sort |> Option.map (fun v -> "sort", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module SearchRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SearchRequest) : Result<Fes.Http.RequestMsg, exn> =
            SearchRequest.ToRequest request

    type SearchRequestBuilder() =
        member _.Yield(_: unit) : SearchRequest =
            {
                SearchRequest.Index = Unchecked.defaultof<Indices>
                SearchRequest.AllowNoIndices = Option.None
                SearchRequest.AllowPartialSearchResults = Option.None
                SearchRequest.Analyzer = Option.None
                SearchRequest.AnalyzeWildcard = Option.None
                SearchRequest.BatchedReduceSize = Option.None
                SearchRequest.CcsMinimizeRoundtrips = Option.None
                SearchRequest.DefaultOperator = Option.None
                SearchRequest.Df = Option.None
                SearchRequest.DocvalueFields = Option.None
                SearchRequest.ExpandWildcards = Option.None
                SearchRequest.Explain = Option.None
                SearchRequest.IgnoreThrottled = Option.None
                SearchRequest.IgnoreUnavailable = Option.None
                SearchRequest.IncludeNamedQueriesScore = Option.None
                SearchRequest.Lenient = Option.None
                SearchRequest.MaxConcurrentShardRequests = Option.None
                SearchRequest.Preference = Option.None
                SearchRequest.PreFilterShardSize = Option.None
                SearchRequest.RequestCache = Option.None
                SearchRequest.Routing = Option.None
                SearchRequest.Scroll = Option.None
                SearchRequest.SearchType = Option.None
                SearchRequest.Stats = Option.None
                SearchRequest.StoredFields = Option.None
                SearchRequest.SuggestField = Option.None
                SearchRequest.SuggestMode = Option.None
                SearchRequest.SuggestSize = Option.None
                SearchRequest.SuggestText = Option.None
                SearchRequest.TerminateAfter = Option.None
                SearchRequest.Timeout = Option.None
                SearchRequest.TrackTotalHits = Option.None
                SearchRequest.TrackScores = Option.None
                SearchRequest.TypedKeys = Option.None
                SearchRequest.RestTotalHitsAsInt = Option.None
                SearchRequest.Version = Option.None
                SearchRequest.Source = Option.None
                SearchRequest.SourceExcludes = Option.None
                SearchRequest.SourceExcludeVectors = Option.None
                SearchRequest.SourceIncludes = Option.None
                SearchRequest.SeqNoPrimaryTerm = Option.None
                SearchRequest.Q = Option.None
                SearchRequest.Size = Option.None
                SearchRequest.From = Option.None
                SearchRequest.Sort = Option.None
                SearchRequest.Aggregations = Option.None
                SearchRequest.Collapse = Option.None
                SearchRequest.Explain2 = Option.None
                SearchRequest.Ext = Option.None
                SearchRequest.From2 = Option.None
                SearchRequest.Highlight = Option.None
                SearchRequest.TrackTotalHits2 = Option.None
                SearchRequest.IndicesBoost = Option.None
                SearchRequest.DocvalueFields2 = Option.None
                SearchRequest.Knn = Option.None
                SearchRequest.Rank = Option.None
                SearchRequest.MinScore = Option.None
                SearchRequest.PostFilter = Option.None
                SearchRequest.Profile = Option.None
                SearchRequest.Query = Option.None
                SearchRequest.Rescore = Option.None
                SearchRequest.Retriever = Option.None
                SearchRequest.ScriptFields = Option.None
                SearchRequest.SearchAfter = Option.None
                SearchRequest.Size2 = Option.None
                SearchRequest.Slice = Option.None
                SearchRequest.Sort2 = Option.None
                SearchRequest.Source2 = Option.None
                SearchRequest.Fields = Option.None
                SearchRequest.Suggest = Option.None
                SearchRequest.TerminateAfter2 = Option.None
                SearchRequest.Timeout2 = Option.None
                SearchRequest.TrackScores2 = Option.None
                SearchRequest.Version2 = Option.None
                SearchRequest.SeqNoPrimaryTerm2 = Option.None
                SearchRequest.StoredFields2 = Option.None
                SearchRequest.Pit = Option.None
                SearchRequest.RuntimeMappings = Option.None
                SearchRequest.Stats2 = Option.None
            } : SearchRequest

        [<CustomOperation("index")>]
        member _.Index(state: SearchRequest, value: Indices) =
            { state with SearchRequest.Index = value } : SearchRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: SearchRequest, value: bool) =
            { state with SearchRequest.AllowNoIndices = Option.Some value } : SearchRequest

        [<CustomOperation("allow_partial_search_results")>]
        member _.AllowPartialSearchResults(state: SearchRequest, value: bool) =
            { state with SearchRequest.AllowPartialSearchResults = Option.Some value } : SearchRequest

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: SearchRequest, value: string) =
            { state with SearchRequest.Analyzer = Option.Some value } : SearchRequest

        [<CustomOperation("analyze_wildcard")>]
        member _.AnalyzeWildcard(state: SearchRequest, value: bool) =
            { state with SearchRequest.AnalyzeWildcard = Option.Some value } : SearchRequest

        [<CustomOperation("batched_reduce_size")>]
        member _.BatchedReduceSize(state: SearchRequest, value: float) =
            { state with SearchRequest.BatchedReduceSize = Option.Some value } : SearchRequest

        [<CustomOperation("ccs_minimize_roundtrips")>]
        member _.CcsMinimizeRoundtrips(state: SearchRequest, value: bool) =
            { state with SearchRequest.CcsMinimizeRoundtrips = Option.Some value } : SearchRequest

        [<CustomOperation("default_operator")>]
        member _.DefaultOperator(state: SearchRequest, value: QueryDslOperator) =
            { state with SearchRequest.DefaultOperator = Option.Some value } : SearchRequest

        [<CustomOperation("df")>]
        member _.Df(state: SearchRequest, value: string) =
            { state with SearchRequest.Df = Option.Some value } : SearchRequest

        [<CustomOperation("docvalue_fields")>]
        member _.DocvalueFields(state: SearchRequest, value: Fields) =
            { state with SearchRequest.DocvalueFields = Option.Some value } : SearchRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: SearchRequest, value: ExpandWildcards) =
            { state with SearchRequest.ExpandWildcards = Option.Some value } : SearchRequest

        [<CustomOperation("explain")>]
        member _.Explain(state: SearchRequest, value: bool) =
            { state with SearchRequest.Explain = Option.Some value } : SearchRequest

        [<CustomOperation("ignore_throttled")>]
        member _.IgnoreThrottled(state: SearchRequest, value: bool) =
            { state with SearchRequest.IgnoreThrottled = Option.Some value } : SearchRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: SearchRequest, value: bool) =
            { state with SearchRequest.IgnoreUnavailable = Option.Some value } : SearchRequest

        [<CustomOperation("include_named_queries_score")>]
        member _.IncludeNamedQueriesScore(state: SearchRequest, value: bool) =
            { state with SearchRequest.IncludeNamedQueriesScore = Option.Some value } : SearchRequest

        [<CustomOperation("lenient")>]
        member _.Lenient(state: SearchRequest, value: bool) =
            { state with SearchRequest.Lenient = Option.Some value } : SearchRequest

        [<CustomOperation("max_concurrent_shard_requests")>]
        member _.MaxConcurrentShardRequests(state: SearchRequest, value: float) =
            { state with SearchRequest.MaxConcurrentShardRequests = Option.Some value } : SearchRequest

        [<CustomOperation("preference")>]
        member _.Preference(state: SearchRequest, value: string) =
            { state with SearchRequest.Preference = Option.Some value } : SearchRequest

        [<CustomOperation("pre_filter_shard_size")>]
        member _.PreFilterShardSize(state: SearchRequest, value: float) =
            { state with SearchRequest.PreFilterShardSize = Option.Some value } : SearchRequest

        [<CustomOperation("request_cache")>]
        member _.RequestCache(state: SearchRequest, value: bool) =
            { state with SearchRequest.RequestCache = Option.Some value } : SearchRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: SearchRequest, value: Routing) =
            { state with SearchRequest.Routing = Option.Some value } : SearchRequest

        [<CustomOperation("scroll")>]
        member _.Scroll(state: SearchRequest, value: Duration) =
            { state with SearchRequest.Scroll = Option.Some value } : SearchRequest

        [<CustomOperation("search_type")>]
        member _.SearchType(state: SearchRequest, value: SearchType) =
            { state with SearchRequest.SearchType = Option.Some value } : SearchRequest

        [<CustomOperation("stats")>]
        member _.Stats(state: SearchRequest, value: string array) =
            { state with SearchRequest.Stats = Option.Some value } : SearchRequest

        [<CustomOperation("stored_fields")>]
        member _.StoredFields(state: SearchRequest, value: Fields) =
            { state with SearchRequest.StoredFields = Option.Some value } : SearchRequest

        [<CustomOperation("suggest_field")>]
        member _.SuggestField(state: SearchRequest, value: Field) =
            { state with SearchRequest.SuggestField = Option.Some value } : SearchRequest

        [<CustomOperation("suggest_mode")>]
        member _.SuggestMode(state: SearchRequest, value: SuggestMode) =
            { state with SearchRequest.SuggestMode = Option.Some value } : SearchRequest

        [<CustomOperation("suggest_size")>]
        member _.SuggestSize(state: SearchRequest, value: float) =
            { state with SearchRequest.SuggestSize = Option.Some value } : SearchRequest

        [<CustomOperation("suggest_text")>]
        member _.SuggestText(state: SearchRequest, value: string) =
            { state with SearchRequest.SuggestText = Option.Some value } : SearchRequest

        [<CustomOperation("terminate_after")>]
        member _.TerminateAfter(state: SearchRequest, value: float) =
            { state with SearchRequest.TerminateAfter = Option.Some value } : SearchRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SearchRequest, value: Duration) =
            { state with SearchRequest.Timeout = Option.Some value } : SearchRequest

        [<CustomOperation("track_total_hits")>]
        member _.TrackTotalHits(state: SearchRequest, value: SearchTypesTrackHits) =
            { state with SearchRequest.TrackTotalHits = Option.Some value } : SearchRequest

        [<CustomOperation("track_scores")>]
        member _.TrackScores(state: SearchRequest, value: bool) =
            { state with SearchRequest.TrackScores = Option.Some value } : SearchRequest

        [<CustomOperation("typed_keys")>]
        member _.TypedKeys(state: SearchRequest, value: bool) =
            { state with SearchRequest.TypedKeys = Option.Some value } : SearchRequest

        [<CustomOperation("rest_total_hits_as_int")>]
        member _.RestTotalHitsAsInt(state: SearchRequest, value: bool) =
            { state with SearchRequest.RestTotalHitsAsInt = Option.Some value } : SearchRequest

        [<CustomOperation("version")>]
        member _.Version(state: SearchRequest, value: bool) =
            { state with SearchRequest.Version = Option.Some value } : SearchRequest

        [<CustomOperation("_source")>]
        member _.Source(state: SearchRequest, value: SearchTypesSourceConfigParam) =
            { state with SearchRequest.Source = Option.Some value } : SearchRequest

        [<CustomOperation("_source_excludes")>]
        member _.SourceExcludes(state: SearchRequest, value: Fields) =
            { state with SearchRequest.SourceExcludes = Option.Some value } : SearchRequest

        [<CustomOperation("_source_exclude_vectors")>]
        member _.SourceExcludeVectors(state: SearchRequest, value: bool) =
            { state with SearchRequest.SourceExcludeVectors = Option.Some value } : SearchRequest

        [<CustomOperation("_source_includes")>]
        member _.SourceIncludes(state: SearchRequest, value: Fields) =
            { state with SearchRequest.SourceIncludes = Option.Some value } : SearchRequest

        [<CustomOperation("seq_no_primary_term")>]
        member _.SeqNoPrimaryTerm(state: SearchRequest, value: bool) =
            { state with SearchRequest.SeqNoPrimaryTerm = Option.Some value } : SearchRequest

        [<CustomOperation("q")>]
        member _.Q(state: SearchRequest, value: string) =
            { state with SearchRequest.Q = Option.Some value } : SearchRequest

        [<CustomOperation("size")>]
        member _.Size(state: SearchRequest, value: float) =
            { state with SearchRequest.Size = Option.Some value } : SearchRequest

        [<CustomOperation("from")>]
        member _.From(state: SearchRequest, value: float) =
            { state with SearchRequest.From = Option.Some value } : SearchRequest

        [<CustomOperation("sort")>]
        member _.Sort(state: SearchRequest, value: System.Text.Json.JsonElement) =
            { state with SearchRequest.Sort = Option.Some value } : SearchRequest

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: SearchRequest, value: Map<string, AggregationsAggregationContainer>) =
            { state with SearchRequest.Aggregations = Option.Some value } : SearchRequest

        [<CustomOperation("collapse")>]
        member _.Collapse(state: SearchRequest, value: SearchTypesFieldCollapse) =
            { state with SearchRequest.Collapse = Option.Some value } : SearchRequest

        [<CustomOperation("explain2")>]
        member _.Explain2(state: SearchRequest, value: bool) =
            { state with SearchRequest.Explain2 = Option.Some value } : SearchRequest

        [<CustomOperation("ext")>]
        member _.Ext(state: SearchRequest, value: Map<string, obj>) =
            { state with SearchRequest.Ext = Option.Some value } : SearchRequest

        [<CustomOperation("from2")>]
        member _.From2(state: SearchRequest, value: float) =
            { state with SearchRequest.From2 = Option.Some value } : SearchRequest

        [<CustomOperation("highlight")>]
        member _.Highlight(state: SearchRequest, value: SearchTypesHighlight) =
            { state with SearchRequest.Highlight = Option.Some value } : SearchRequest

        [<CustomOperation("track_total_hits2")>]
        member _.TrackTotalHits2(state: SearchRequest, value: SearchTypesTrackHits) =
            { state with SearchRequest.TrackTotalHits2 = Option.Some value } : SearchRequest

        [<CustomOperation("indices_boost")>]
        member _.IndicesBoost(state: SearchRequest, value: Map<string, float> array) =
            { state with SearchRequest.IndicesBoost = Option.Some value } : SearchRequest

        [<CustomOperation("docvalue_fields2")>]
        member _.DocvalueFields2(state: SearchRequest, value: QueryDslFieldAndFormat array) =
            { state with SearchRequest.DocvalueFields2 = Option.Some value } : SearchRequest

        [<CustomOperation("knn")>]
        member _.Knn(state: SearchRequest, value: System.Text.Json.JsonElement) =
            { state with SearchRequest.Knn = Option.Some value } : SearchRequest

        [<CustomOperation("rank")>]
        member _.Rank(state: SearchRequest, value: RankContainer) =
            { state with SearchRequest.Rank = Option.Some value } : SearchRequest

        [<CustomOperation("min_score")>]
        member _.MinScore(state: SearchRequest, value: float) =
            { state with SearchRequest.MinScore = Option.Some value } : SearchRequest

        [<CustomOperation("post_filter")>]
        member _.PostFilter(state: SearchRequest, value: QueryDslQueryContainer) =
            { state with SearchRequest.PostFilter = Option.Some value } : SearchRequest

        [<CustomOperation("profile")>]
        member _.Profile(state: SearchRequest, value: bool) =
            { state with SearchRequest.Profile = Option.Some value } : SearchRequest

        [<CustomOperation("query")>]
        member _.Query(state: SearchRequest, value: QueryDslQueryContainer) =
            { state with SearchRequest.Query = Option.Some value } : SearchRequest

        [<CustomOperation("rescore")>]
        member _.Rescore(state: SearchRequest, value: System.Text.Json.JsonElement) =
            { state with SearchRequest.Rescore = Option.Some value } : SearchRequest

        [<CustomOperation("retriever")>]
        member _.Retriever(state: SearchRequest, value: RetrieverContainer) =
            { state with SearchRequest.Retriever = Option.Some value } : SearchRequest

        [<CustomOperation("script_fields")>]
        member _.ScriptFields(state: SearchRequest, value: Map<string, ScriptField>) =
            { state with SearchRequest.ScriptFields = Option.Some value } : SearchRequest

        [<CustomOperation("search_after")>]
        member _.SearchAfter(state: SearchRequest, value: SortResults) =
            { state with SearchRequest.SearchAfter = Option.Some value } : SearchRequest

        [<CustomOperation("size2")>]
        member _.Size2(state: SearchRequest, value: float) =
            { state with SearchRequest.Size2 = Option.Some value } : SearchRequest

        [<CustomOperation("slice")>]
        member _.Slice(state: SearchRequest, value: SlicedScroll) =
            { state with SearchRequest.Slice = Option.Some value } : SearchRequest

        [<CustomOperation("sort2")>]
        member _.Sort2(state: SearchRequest, value: Sort) =
            { state with SearchRequest.Sort2 = Option.Some value } : SearchRequest

        [<CustomOperation("_source2")>]
        member _.Source2(state: SearchRequest, value: SearchTypesSourceConfig) =
            { state with SearchRequest.Source2 = Option.Some value } : SearchRequest

        [<CustomOperation("fields")>]
        member _.Fields(state: SearchRequest, value: QueryDslFieldAndFormat array) =
            { state with SearchRequest.Fields = Option.Some value } : SearchRequest

        [<CustomOperation("suggest")>]
        member _.Suggest(state: SearchRequest, value: SearchTypesSuggester) =
            { state with SearchRequest.Suggest = Option.Some value } : SearchRequest

        [<CustomOperation("terminate_after2")>]
        member _.TerminateAfter2(state: SearchRequest, value: float) =
            { state with SearchRequest.TerminateAfter2 = Option.Some value } : SearchRequest

        [<CustomOperation("timeout2")>]
        member _.Timeout2(state: SearchRequest, value: string) =
            { state with SearchRequest.Timeout2 = Option.Some value } : SearchRequest

        [<CustomOperation("track_scores2")>]
        member _.TrackScores2(state: SearchRequest, value: bool) =
            { state with SearchRequest.TrackScores2 = Option.Some value } : SearchRequest

        [<CustomOperation("version2")>]
        member _.Version2(state: SearchRequest, value: bool) =
            { state with SearchRequest.Version2 = Option.Some value } : SearchRequest

        [<CustomOperation("seq_no_primary_term2")>]
        member _.SeqNoPrimaryTerm2(state: SearchRequest, value: bool) =
            { state with SearchRequest.SeqNoPrimaryTerm2 = Option.Some value } : SearchRequest

        [<CustomOperation("stored_fields2")>]
        member _.StoredFields2(state: SearchRequest, value: Fields) =
            { state with SearchRequest.StoredFields2 = Option.Some value } : SearchRequest

        [<CustomOperation("pit")>]
        member _.Pit(state: SearchRequest, value: SearchTypesPointInTimeReference) =
            { state with SearchRequest.Pit = Option.Some value } : SearchRequest

        [<CustomOperation("runtime_mappings")>]
        member _.RuntimeMappings(state: SearchRequest, value: MappingRuntimeFields) =
            { state with SearchRequest.RuntimeMappings = Option.Some value } : SearchRequest

        [<CustomOperation("stats2")>]
        member _.Stats2(state: SearchRequest, value: string array) =
            { state with SearchRequest.Stats2 = Option.Some value } : SearchRequest

    let searchRequest = SearchRequestBuilder()

    type SearchMvtRequest = {
        [<JsonPropertyName("index")>]
        Index: Indices
        [<JsonPropertyName("field")>]
        Field: Field
        [<JsonPropertyName("zoom")>]
        Zoom: SearchMvtTypesZoomLevel
        [<JsonPropertyName("x")>]
        X: SearchMvtTypesCoordinate
        [<JsonPropertyName("y")>]
        Y: SearchMvtTypesCoordinate
        [<JsonPropertyName("exact_bounds")>]
        ExactBounds: bool option
        [<JsonPropertyName("extent")>]
        Extent: float option
        [<JsonPropertyName("grid_agg")>]
        GridAgg: SearchMvtTypesGridAggregationType option
        [<JsonPropertyName("grid_precision")>]
        GridPrecision: float option
        [<JsonPropertyName("grid_type")>]
        GridType: SearchMvtTypesGridType option
        [<JsonPropertyName("size")>]
        Size: float option
        [<JsonPropertyName("track_total_hits")>]
        TrackTotalHits: SearchTypesTrackHits option
        [<JsonPropertyName("with_labels")>]
        WithLabels: bool option
        [<JsonPropertyName("aggs")>]
        Aggs: Map<string, AggregationsAggregationContainer> option
        [<JsonPropertyName("buffer")>]
        Buffer: float option
        [<JsonPropertyName("exact_bounds")>]
        ExactBounds2: bool option
        [<JsonPropertyName("extent")>]
        Extent2: float option
        [<JsonPropertyName("fields")>]
        Fields: Fields option
        [<JsonPropertyName("grid_agg")>]
        GridAgg2: SearchMvtTypesGridAggregationType option
        [<JsonPropertyName("grid_precision")>]
        GridPrecision2: float option
        [<JsonPropertyName("grid_type")>]
        GridType2: SearchMvtTypesGridType option
        [<JsonPropertyName("query")>]
        Query: QueryDslQueryContainer option
        [<JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: MappingRuntimeFields option
        [<JsonPropertyName("size")>]
        Size2: float option
        [<JsonPropertyName("sort")>]
        Sort: Sort option
        [<JsonPropertyName("track_total_hits")>]
        TrackTotalHits2: SearchTypesTrackHits option
        [<JsonPropertyName("with_labels")>]
        WithLabels2: bool option
    } with
        static member ToRequest(request: SearchMvtRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_mvt/{request.Field}/{request.Zoom}/{request.X}/{request.Y}"
                let queryParams =
                    [
                        request.ExactBounds |> Option.map (fun v -> "exact_bounds", string v)
                        request.Extent |> Option.map (fun v -> "extent", string v)
                        request.GridAgg |> Option.map (fun v -> "grid_agg", string v)
                        request.GridPrecision |> Option.map (fun v -> "grid_precision", string v)
                        request.GridType |> Option.map (fun v -> "grid_type", string v)
                        request.Size |> Option.map (fun v -> "size", string v)
                        request.TrackTotalHits |> Option.map (fun v -> "track_total_hits", string v)
                        request.WithLabels |> Option.map (fun v -> "with_labels", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module SearchMvtRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SearchMvtRequest) : Result<Fes.Http.RequestMsg, exn> =
            SearchMvtRequest.ToRequest request

    type SearchMvtRequestBuilder() =
        member _.Yield(_: unit) : SearchMvtRequest =
            {
                SearchMvtRequest.Index = Unchecked.defaultof<Indices>
                SearchMvtRequest.Field = Unchecked.defaultof<Field>
                SearchMvtRequest.Zoom = Unchecked.defaultof<SearchMvtTypesZoomLevel>
                SearchMvtRequest.X = Unchecked.defaultof<SearchMvtTypesCoordinate>
                SearchMvtRequest.Y = Unchecked.defaultof<SearchMvtTypesCoordinate>
                SearchMvtRequest.ExactBounds = Option.None
                SearchMvtRequest.Extent = Option.None
                SearchMvtRequest.GridAgg = Option.None
                SearchMvtRequest.GridPrecision = Option.None
                SearchMvtRequest.GridType = Option.None
                SearchMvtRequest.Size = Option.None
                SearchMvtRequest.TrackTotalHits = Option.None
                SearchMvtRequest.WithLabels = Option.None
                SearchMvtRequest.Aggs = Option.None
                SearchMvtRequest.Buffer = Option.None
                SearchMvtRequest.ExactBounds2 = Option.None
                SearchMvtRequest.Extent2 = Option.None
                SearchMvtRequest.Fields = Option.None
                SearchMvtRequest.GridAgg2 = Option.None
                SearchMvtRequest.GridPrecision2 = Option.None
                SearchMvtRequest.GridType2 = Option.None
                SearchMvtRequest.Query = Option.None
                SearchMvtRequest.RuntimeMappings = Option.None
                SearchMvtRequest.Size2 = Option.None
                SearchMvtRequest.Sort = Option.None
                SearchMvtRequest.TrackTotalHits2 = Option.None
                SearchMvtRequest.WithLabels2 = Option.None
            } : SearchMvtRequest

        [<CustomOperation("index")>]
        member _.Index(state: SearchMvtRequest, value: Indices) =
            { state with SearchMvtRequest.Index = value } : SearchMvtRequest

        [<CustomOperation("field")>]
        member _.Field(state: SearchMvtRequest, value: Field) =
            { state with SearchMvtRequest.Field = value } : SearchMvtRequest

        [<CustomOperation("zoom")>]
        member _.Zoom(state: SearchMvtRequest, value: SearchMvtTypesZoomLevel) =
            { state with SearchMvtRequest.Zoom = value } : SearchMvtRequest

        [<CustomOperation("x")>]
        member _.X(state: SearchMvtRequest, value: SearchMvtTypesCoordinate) =
            { state with SearchMvtRequest.X = value } : SearchMvtRequest

        [<CustomOperation("y")>]
        member _.Y(state: SearchMvtRequest, value: SearchMvtTypesCoordinate) =
            { state with SearchMvtRequest.Y = value } : SearchMvtRequest

        [<CustomOperation("exact_bounds")>]
        member _.ExactBounds(state: SearchMvtRequest, value: bool) =
            { state with SearchMvtRequest.ExactBounds = Option.Some value } : SearchMvtRequest

        [<CustomOperation("extent")>]
        member _.Extent(state: SearchMvtRequest, value: float) =
            { state with SearchMvtRequest.Extent = Option.Some value } : SearchMvtRequest

        [<CustomOperation("grid_agg")>]
        member _.GridAgg(state: SearchMvtRequest, value: SearchMvtTypesGridAggregationType) =
            { state with SearchMvtRequest.GridAgg = Option.Some value } : SearchMvtRequest

        [<CustomOperation("grid_precision")>]
        member _.GridPrecision(state: SearchMvtRequest, value: float) =
            { state with SearchMvtRequest.GridPrecision = Option.Some value } : SearchMvtRequest

        [<CustomOperation("grid_type")>]
        member _.GridType(state: SearchMvtRequest, value: SearchMvtTypesGridType) =
            { state with SearchMvtRequest.GridType = Option.Some value } : SearchMvtRequest

        [<CustomOperation("size")>]
        member _.Size(state: SearchMvtRequest, value: float) =
            { state with SearchMvtRequest.Size = Option.Some value } : SearchMvtRequest

        [<CustomOperation("track_total_hits")>]
        member _.TrackTotalHits(state: SearchMvtRequest, value: SearchTypesTrackHits) =
            { state with SearchMvtRequest.TrackTotalHits = Option.Some value } : SearchMvtRequest

        [<CustomOperation("with_labels")>]
        member _.WithLabels(state: SearchMvtRequest, value: bool) =
            { state with SearchMvtRequest.WithLabels = Option.Some value } : SearchMvtRequest

        [<CustomOperation("aggs")>]
        member _.Aggs(state: SearchMvtRequest, value: Map<string, AggregationsAggregationContainer>) =
            { state with SearchMvtRequest.Aggs = Option.Some value } : SearchMvtRequest

        [<CustomOperation("buffer")>]
        member _.Buffer(state: SearchMvtRequest, value: float) =
            { state with SearchMvtRequest.Buffer = Option.Some value } : SearchMvtRequest

        [<CustomOperation("exact_bounds2")>]
        member _.ExactBounds2(state: SearchMvtRequest, value: bool) =
            { state with SearchMvtRequest.ExactBounds2 = Option.Some value } : SearchMvtRequest

        [<CustomOperation("extent2")>]
        member _.Extent2(state: SearchMvtRequest, value: float) =
            { state with SearchMvtRequest.Extent2 = Option.Some value } : SearchMvtRequest

        [<CustomOperation("fields")>]
        member _.Fields(state: SearchMvtRequest, value: Fields) =
            { state with SearchMvtRequest.Fields = Option.Some value } : SearchMvtRequest

        [<CustomOperation("grid_agg2")>]
        member _.GridAgg2(state: SearchMvtRequest, value: SearchMvtTypesGridAggregationType) =
            { state with SearchMvtRequest.GridAgg2 = Option.Some value } : SearchMvtRequest

        [<CustomOperation("grid_precision2")>]
        member _.GridPrecision2(state: SearchMvtRequest, value: float) =
            { state with SearchMvtRequest.GridPrecision2 = Option.Some value } : SearchMvtRequest

        [<CustomOperation("grid_type2")>]
        member _.GridType2(state: SearchMvtRequest, value: SearchMvtTypesGridType) =
            { state with SearchMvtRequest.GridType2 = Option.Some value } : SearchMvtRequest

        [<CustomOperation("query")>]
        member _.Query(state: SearchMvtRequest, value: QueryDslQueryContainer) =
            { state with SearchMvtRequest.Query = Option.Some value } : SearchMvtRequest

        [<CustomOperation("runtime_mappings")>]
        member _.RuntimeMappings(state: SearchMvtRequest, value: MappingRuntimeFields) =
            { state with SearchMvtRequest.RuntimeMappings = Option.Some value } : SearchMvtRequest

        [<CustomOperation("size2")>]
        member _.Size2(state: SearchMvtRequest, value: float) =
            { state with SearchMvtRequest.Size2 = Option.Some value } : SearchMvtRequest

        [<CustomOperation("sort")>]
        member _.Sort(state: SearchMvtRequest, value: Sort) =
            { state with SearchMvtRequest.Sort = Option.Some value } : SearchMvtRequest

        [<CustomOperation("track_total_hits2")>]
        member _.TrackTotalHits2(state: SearchMvtRequest, value: SearchTypesTrackHits) =
            { state with SearchMvtRequest.TrackTotalHits2 = Option.Some value } : SearchMvtRequest

        [<CustomOperation("with_labels2")>]
        member _.WithLabels2(state: SearchMvtRequest, value: bool) =
            { state with SearchMvtRequest.WithLabels2 = Option.Some value } : SearchMvtRequest

    let searchMvtRequest = SearchMvtRequestBuilder()

    type SearchShardsRequest = {
        [<JsonPropertyName("index")>]
        Index: Indices
        [<JsonPropertyName("allow_no_indices")>]
        AllowNoIndices: bool option
        [<JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: ExpandWildcards option
        [<JsonPropertyName("ignore_unavailable")>]
        IgnoreUnavailable: bool option
        [<JsonPropertyName("local")>]
        Local: bool option
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
        [<JsonPropertyName("preference")>]
        Preference: string option
        [<JsonPropertyName("routing")>]
        Routing: Routing option
    } with
        static member ToRequest(request: SearchShardsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_search_shards"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", string v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", string v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", string v)
                        request.Local |> Option.map (fun v -> "local", string v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                        request.Preference |> Option.map (fun v -> "preference", string v)
                        request.Routing |> Option.map (fun v -> "routing", string v)
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

    module SearchShardsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SearchShardsRequest) : Result<Fes.Http.RequestMsg, exn> =
            SearchShardsRequest.ToRequest request

    type SearchShardsRequestBuilder() =
        member _.Yield(_: unit) : SearchShardsRequest =
            {
                SearchShardsRequest.Index = Unchecked.defaultof<Indices>
                SearchShardsRequest.AllowNoIndices = Option.None
                SearchShardsRequest.ExpandWildcards = Option.None
                SearchShardsRequest.IgnoreUnavailable = Option.None
                SearchShardsRequest.Local = Option.None
                SearchShardsRequest.MasterTimeout = Option.None
                SearchShardsRequest.Preference = Option.None
                SearchShardsRequest.Routing = Option.None
            } : SearchShardsRequest

        [<CustomOperation("index")>]
        member _.Index(state: SearchShardsRequest, value: Indices) =
            { state with SearchShardsRequest.Index = value } : SearchShardsRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: SearchShardsRequest, value: bool) =
            { state with SearchShardsRequest.AllowNoIndices = Option.Some value } : SearchShardsRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: SearchShardsRequest, value: ExpandWildcards) =
            { state with SearchShardsRequest.ExpandWildcards = Option.Some value } : SearchShardsRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: SearchShardsRequest, value: bool) =
            { state with SearchShardsRequest.IgnoreUnavailable = Option.Some value } : SearchShardsRequest

        [<CustomOperation("local")>]
        member _.Local(state: SearchShardsRequest, value: bool) =
            { state with SearchShardsRequest.Local = Option.Some value } : SearchShardsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SearchShardsRequest, value: Duration) =
            { state with SearchShardsRequest.MasterTimeout = Option.Some value } : SearchShardsRequest

        [<CustomOperation("preference")>]
        member _.Preference(state: SearchShardsRequest, value: string) =
            { state with SearchShardsRequest.Preference = Option.Some value } : SearchShardsRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: SearchShardsRequest, value: Routing) =
            { state with SearchShardsRequest.Routing = Option.Some value } : SearchShardsRequest

    let searchShardsRequest = SearchShardsRequestBuilder()

    type SearchTemplateRequest = {
        [<JsonPropertyName("index")>]
        Index: Indices
        [<JsonPropertyName("allow_no_indices")>]
        AllowNoIndices: bool option
        [<JsonPropertyName("ccs_minimize_roundtrips")>]
        CcsMinimizeRoundtrips: bool option
        [<JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: ExpandWildcards option
        [<JsonPropertyName("explain")>]
        Explain: bool option
        [<JsonPropertyName("ignore_throttled")>]
        IgnoreThrottled: bool option
        [<JsonPropertyName("ignore_unavailable")>]
        IgnoreUnavailable: bool option
        [<JsonPropertyName("preference")>]
        Preference: string option
        [<JsonPropertyName("profile")>]
        Profile: bool option
        [<JsonPropertyName("routing")>]
        Routing: Routing option
        [<JsonPropertyName("scroll")>]
        Scroll: Duration option
        [<JsonPropertyName("search_type")>]
        SearchType: SearchType option
        [<JsonPropertyName("rest_total_hits_as_int")>]
        RestTotalHitsAsInt: bool option
        [<JsonPropertyName("typed_keys")>]
        TypedKeys: bool option
        [<JsonPropertyName("explain")>]
        Explain2: bool option
        [<JsonPropertyName("id")>]
        Id: Id option
        [<JsonPropertyName("params")>]
        Params: Map<string, obj> option
        [<JsonPropertyName("profile")>]
        Profile2: bool option
        [<JsonPropertyName("source")>]
        Source: ScriptSource option
    } with
        static member ToRequest(request: SearchTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_search/template"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", string v)
                        request.CcsMinimizeRoundtrips |> Option.map (fun v -> "ccs_minimize_roundtrips", string v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", string v)
                        request.Explain |> Option.map (fun v -> "explain", string v)
                        request.IgnoreThrottled |> Option.map (fun v -> "ignore_throttled", string v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", string v)
                        request.Preference |> Option.map (fun v -> "preference", string v)
                        request.Profile |> Option.map (fun v -> "profile", string v)
                        request.Routing |> Option.map (fun v -> "routing", string v)
                        request.Scroll |> Option.map (fun v -> "scroll", string v)
                        request.SearchType |> Option.map (fun v -> "search_type", string v)
                        request.RestTotalHitsAsInt |> Option.map (fun v -> "rest_total_hits_as_int", string v)
                        request.TypedKeys |> Option.map (fun v -> "typed_keys", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module SearchTemplateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SearchTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            SearchTemplateRequest.ToRequest request

    type SearchTemplateRequestBuilder() =
        member _.Yield(_: unit) : SearchTemplateRequest =
            {
                SearchTemplateRequest.Index = Unchecked.defaultof<Indices>
                SearchTemplateRequest.AllowNoIndices = Option.None
                SearchTemplateRequest.CcsMinimizeRoundtrips = Option.None
                SearchTemplateRequest.ExpandWildcards = Option.None
                SearchTemplateRequest.Explain = Option.None
                SearchTemplateRequest.IgnoreThrottled = Option.None
                SearchTemplateRequest.IgnoreUnavailable = Option.None
                SearchTemplateRequest.Preference = Option.None
                SearchTemplateRequest.Profile = Option.None
                SearchTemplateRequest.Routing = Option.None
                SearchTemplateRequest.Scroll = Option.None
                SearchTemplateRequest.SearchType = Option.None
                SearchTemplateRequest.RestTotalHitsAsInt = Option.None
                SearchTemplateRequest.TypedKeys = Option.None
                SearchTemplateRequest.Explain2 = Option.None
                SearchTemplateRequest.Id = Option.None
                SearchTemplateRequest.Params = Option.None
                SearchTemplateRequest.Profile2 = Option.None
                SearchTemplateRequest.Source = Option.None
            } : SearchTemplateRequest

        [<CustomOperation("index")>]
        member _.Index(state: SearchTemplateRequest, value: Indices) =
            { state with SearchTemplateRequest.Index = value } : SearchTemplateRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: SearchTemplateRequest, value: bool) =
            { state with SearchTemplateRequest.AllowNoIndices = Option.Some value } : SearchTemplateRequest

        [<CustomOperation("ccs_minimize_roundtrips")>]
        member _.CcsMinimizeRoundtrips(state: SearchTemplateRequest, value: bool) =
            { state with SearchTemplateRequest.CcsMinimizeRoundtrips = Option.Some value } : SearchTemplateRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: SearchTemplateRequest, value: ExpandWildcards) =
            { state with SearchTemplateRequest.ExpandWildcards = Option.Some value } : SearchTemplateRequest

        [<CustomOperation("explain")>]
        member _.Explain(state: SearchTemplateRequest, value: bool) =
            { state with SearchTemplateRequest.Explain = Option.Some value } : SearchTemplateRequest

        [<CustomOperation("ignore_throttled")>]
        member _.IgnoreThrottled(state: SearchTemplateRequest, value: bool) =
            { state with SearchTemplateRequest.IgnoreThrottled = Option.Some value } : SearchTemplateRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: SearchTemplateRequest, value: bool) =
            { state with SearchTemplateRequest.IgnoreUnavailable = Option.Some value } : SearchTemplateRequest

        [<CustomOperation("preference")>]
        member _.Preference(state: SearchTemplateRequest, value: string) =
            { state with SearchTemplateRequest.Preference = Option.Some value } : SearchTemplateRequest

        [<CustomOperation("profile")>]
        member _.Profile(state: SearchTemplateRequest, value: bool) =
            { state with SearchTemplateRequest.Profile = Option.Some value } : SearchTemplateRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: SearchTemplateRequest, value: Routing) =
            { state with SearchTemplateRequest.Routing = Option.Some value } : SearchTemplateRequest

        [<CustomOperation("scroll")>]
        member _.Scroll(state: SearchTemplateRequest, value: Duration) =
            { state with SearchTemplateRequest.Scroll = Option.Some value } : SearchTemplateRequest

        [<CustomOperation("search_type")>]
        member _.SearchType(state: SearchTemplateRequest, value: SearchType) =
            { state with SearchTemplateRequest.SearchType = Option.Some value } : SearchTemplateRequest

        [<CustomOperation("rest_total_hits_as_int")>]
        member _.RestTotalHitsAsInt(state: SearchTemplateRequest, value: bool) =
            { state with SearchTemplateRequest.RestTotalHitsAsInt = Option.Some value } : SearchTemplateRequest

        [<CustomOperation("typed_keys")>]
        member _.TypedKeys(state: SearchTemplateRequest, value: bool) =
            { state with SearchTemplateRequest.TypedKeys = Option.Some value } : SearchTemplateRequest

        [<CustomOperation("explain2")>]
        member _.Explain2(state: SearchTemplateRequest, value: bool) =
            { state with SearchTemplateRequest.Explain2 = Option.Some value } : SearchTemplateRequest

        [<CustomOperation("id")>]
        member _.Id(state: SearchTemplateRequest, value: Id) =
            { state with SearchTemplateRequest.Id = Option.Some value } : SearchTemplateRequest

        [<CustomOperation("params")>]
        member _.Params(state: SearchTemplateRequest, value: Map<string, obj>) =
            { state with SearchTemplateRequest.Params = Option.Some value } : SearchTemplateRequest

        [<CustomOperation("profile2")>]
        member _.Profile2(state: SearchTemplateRequest, value: bool) =
            { state with SearchTemplateRequest.Profile2 = Option.Some value } : SearchTemplateRequest

        [<CustomOperation("source")>]
        member _.Source(state: SearchTemplateRequest, value: ScriptSource) =
            { state with SearchTemplateRequest.Source = Option.Some value } : SearchTemplateRequest

    let searchTemplateRequest = SearchTemplateRequestBuilder()

    type TermsEnumRequest = {
        [<JsonPropertyName("index")>]
        Index: Indices
        [<JsonPropertyName("field")>]
        Field: Field
        [<JsonPropertyName("size")>]
        Size: float option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
        [<JsonPropertyName("case_insensitive")>]
        CaseInsensitive: bool option
        [<JsonPropertyName("index_filter")>]
        IndexFilter: QueryDslQueryContainer option
        [<JsonPropertyName("string")>]
        String: string option
        [<JsonPropertyName("search_after")>]
        SearchAfter: string option
    } with
        static member ToRequest(request: TermsEnumRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_terms_enum"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module TermsEnumRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: TermsEnumRequest) : Result<Fes.Http.RequestMsg, exn> =
            TermsEnumRequest.ToRequest request

    type TermsEnumRequestBuilder() =
        member _.Yield(_: unit) : TermsEnumRequest =
            {
                TermsEnumRequest.Index = Unchecked.defaultof<Indices>
                TermsEnumRequest.Field = Unchecked.defaultof<Field>
                TermsEnumRequest.Size = Option.None
                TermsEnumRequest.Timeout = Option.None
                TermsEnumRequest.CaseInsensitive = Option.None
                TermsEnumRequest.IndexFilter = Option.None
                TermsEnumRequest.String = Option.None
                TermsEnumRequest.SearchAfter = Option.None
            } : TermsEnumRequest

        [<CustomOperation("index")>]
        member _.Index(state: TermsEnumRequest, value: Indices) =
            { state with TermsEnumRequest.Index = value } : TermsEnumRequest

        [<CustomOperation("field")>]
        member _.Field(state: TermsEnumRequest, value: Field) =
            { state with TermsEnumRequest.Field = value } : TermsEnumRequest

        [<CustomOperation("size")>]
        member _.Size(state: TermsEnumRequest, value: float) =
            { state with TermsEnumRequest.Size = Option.Some value } : TermsEnumRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TermsEnumRequest, value: Duration) =
            { state with TermsEnumRequest.Timeout = Option.Some value } : TermsEnumRequest

        [<CustomOperation("case_insensitive")>]
        member _.CaseInsensitive(state: TermsEnumRequest, value: bool) =
            { state with TermsEnumRequest.CaseInsensitive = Option.Some value } : TermsEnumRequest

        [<CustomOperation("index_filter")>]
        member _.IndexFilter(state: TermsEnumRequest, value: QueryDslQueryContainer) =
            { state with TermsEnumRequest.IndexFilter = Option.Some value } : TermsEnumRequest

        [<CustomOperation("string")>]
        member _.String(state: TermsEnumRequest, value: string) =
            { state with TermsEnumRequest.String = Option.Some value } : TermsEnumRequest

        [<CustomOperation("search_after")>]
        member _.SearchAfter(state: TermsEnumRequest, value: string) =
            { state with TermsEnumRequest.SearchAfter = Option.Some value } : TermsEnumRequest

    let termsEnumRequest = TermsEnumRequestBuilder()


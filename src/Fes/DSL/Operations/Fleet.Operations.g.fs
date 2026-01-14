// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module FleetOperations =

    type FleetGlobalCheckpointsRequest = {
        Index: System.Text.Json.JsonElement
        WaitForAdvance: bool option
        WaitForIndex: bool option
        Checkpoints: TypesCheckpoint array option
        Timeout: Duration option
    } with
        static member ToRequest(request: FleetGlobalCheckpointsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_fleet/global_checkpoints"
                let queryParams =
                    [
                        request.WaitForAdvance |> Option.map (fun v -> "wait_for_advance", Fes.Http.toQueryValue v)
                        request.WaitForIndex |> Option.map (fun v -> "wait_for_index", Fes.Http.toQueryValue v)
                        request.Checkpoints |> Option.map (fun v -> "checkpoints", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
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

    module FleetGlobalCheckpointsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: FleetGlobalCheckpointsRequest) : Result<Fes.Http.RequestMsg, exn> =
            FleetGlobalCheckpointsRequest.ToRequest request

    type FleetGlobalCheckpointsRequestBuilder() =
        member _.Yield(_: unit) : FleetGlobalCheckpointsRequest =
            {
                FleetGlobalCheckpointsRequest.Index = Unchecked.defaultof<System.Text.Json.JsonElement>
                FleetGlobalCheckpointsRequest.WaitForAdvance = Option.None
                FleetGlobalCheckpointsRequest.WaitForIndex = Option.None
                FleetGlobalCheckpointsRequest.Checkpoints = Option.None
                FleetGlobalCheckpointsRequest.Timeout = Option.None
            } : FleetGlobalCheckpointsRequest

        [<CustomOperation("index")>]
        member _.Index(state: FleetGlobalCheckpointsRequest, value: System.Text.Json.JsonElement) =
            { state with FleetGlobalCheckpointsRequest.Index = value } : FleetGlobalCheckpointsRequest

        [<CustomOperation("wait_for_advance")>]
        member _.WaitForAdvance(state: FleetGlobalCheckpointsRequest, value: bool) =
            { state with FleetGlobalCheckpointsRequest.WaitForAdvance = Option.Some value } : FleetGlobalCheckpointsRequest

        [<CustomOperation("wait_for_index")>]
        member _.WaitForIndex(state: FleetGlobalCheckpointsRequest, value: bool) =
            { state with FleetGlobalCheckpointsRequest.WaitForIndex = Option.Some value } : FleetGlobalCheckpointsRequest

        [<CustomOperation("checkpoints")>]
        member _.Checkpoints(state: FleetGlobalCheckpointsRequest, value: TypesCheckpoint array) =
            { state with FleetGlobalCheckpointsRequest.Checkpoints = Option.Some value } : FleetGlobalCheckpointsRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: FleetGlobalCheckpointsRequest, value: Duration) =
            { state with FleetGlobalCheckpointsRequest.Timeout = Option.Some value } : FleetGlobalCheckpointsRequest

    let fleetGlobalCheckpointsRequest = FleetGlobalCheckpointsRequestBuilder()

    type FleetGlobalCheckpointsResponse = {
        [<JsonPropertyName("global_checkpoints")>]
        GlobalCheckpoints: TypesCheckpoint array
        [<JsonPropertyName("timed_out")>]
        TimedOut: bool
    }

    type FleetMsearchRequest = {
        Index: System.Text.Json.JsonElement
        AllowNoIndices: bool option
        CcsMinimizeRoundtrips: bool option
        ExpandWildcards: ExpandWildcards option
        IgnoreThrottled: bool option
        IgnoreUnavailable: bool option
        MaxConcurrentSearches: float option
        MaxConcurrentShardRequests: float option
        PreFilterShardSize: float option
        SearchType: SearchType option
        RestTotalHitsAsInt: bool option
        TypedKeys: bool option
        WaitForCheckpoints: TypesCheckpoint array option
        AllowPartialSearchResults: bool option
    } with
        static member ToRequest(request: FleetMsearchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_fleet/_fleet_msearch"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.CcsMinimizeRoundtrips |> Option.map (fun v -> "ccs_minimize_roundtrips", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.IgnoreThrottled |> Option.map (fun v -> "ignore_throttled", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.MaxConcurrentSearches |> Option.map (fun v -> "max_concurrent_searches", Fes.Http.toQueryValue v)
                        request.MaxConcurrentShardRequests |> Option.map (fun v -> "max_concurrent_shard_requests", Fes.Http.toQueryValue v)
                        request.PreFilterShardSize |> Option.map (fun v -> "pre_filter_shard_size", Fes.Http.toQueryValue v)
                        request.SearchType |> Option.map (fun v -> "search_type", Fes.Http.toQueryValue v)
                        request.RestTotalHitsAsInt |> Option.map (fun v -> "rest_total_hits_as_int", Fes.Http.toQueryValue v)
                        request.TypedKeys |> Option.map (fun v -> "typed_keys", Fes.Http.toQueryValue v)
                        request.WaitForCheckpoints |> Option.map (fun v -> "wait_for_checkpoints", Fes.Http.toQueryValue v)
                        request.AllowPartialSearchResults |> Option.map (fun v -> "allow_partial_search_results", Fes.Http.toQueryValue v)
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

    module FleetMsearchRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: FleetMsearchRequest) : Result<Fes.Http.RequestMsg, exn> =
            FleetMsearchRequest.ToRequest request

    type FleetMsearchRequestBuilder() =
        member _.Yield(_: unit) : FleetMsearchRequest =
            {
                FleetMsearchRequest.Index = Unchecked.defaultof<System.Text.Json.JsonElement>
                FleetMsearchRequest.AllowNoIndices = Option.None
                FleetMsearchRequest.CcsMinimizeRoundtrips = Option.None
                FleetMsearchRequest.ExpandWildcards = Option.None
                FleetMsearchRequest.IgnoreThrottled = Option.None
                FleetMsearchRequest.IgnoreUnavailable = Option.None
                FleetMsearchRequest.MaxConcurrentSearches = Option.None
                FleetMsearchRequest.MaxConcurrentShardRequests = Option.None
                FleetMsearchRequest.PreFilterShardSize = Option.None
                FleetMsearchRequest.SearchType = Option.None
                FleetMsearchRequest.RestTotalHitsAsInt = Option.None
                FleetMsearchRequest.TypedKeys = Option.None
                FleetMsearchRequest.WaitForCheckpoints = Option.None
                FleetMsearchRequest.AllowPartialSearchResults = Option.None
            } : FleetMsearchRequest

        [<CustomOperation("index")>]
        member _.Index(state: FleetMsearchRequest, value: System.Text.Json.JsonElement) =
            { state with FleetMsearchRequest.Index = value } : FleetMsearchRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: FleetMsearchRequest, value: bool) =
            { state with FleetMsearchRequest.AllowNoIndices = Option.Some value } : FleetMsearchRequest

        [<CustomOperation("ccs_minimize_roundtrips")>]
        member _.CcsMinimizeRoundtrips(state: FleetMsearchRequest, value: bool) =
            { state with FleetMsearchRequest.CcsMinimizeRoundtrips = Option.Some value } : FleetMsearchRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: FleetMsearchRequest, value: ExpandWildcards) =
            { state with FleetMsearchRequest.ExpandWildcards = Option.Some value } : FleetMsearchRequest

        [<CustomOperation("ignore_throttled")>]
        member _.IgnoreThrottled(state: FleetMsearchRequest, value: bool) =
            { state with FleetMsearchRequest.IgnoreThrottled = Option.Some value } : FleetMsearchRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: FleetMsearchRequest, value: bool) =
            { state with FleetMsearchRequest.IgnoreUnavailable = Option.Some value } : FleetMsearchRequest

        [<CustomOperation("max_concurrent_searches")>]
        member _.MaxConcurrentSearches(state: FleetMsearchRequest, value: float) =
            { state with FleetMsearchRequest.MaxConcurrentSearches = Option.Some value } : FleetMsearchRequest

        [<CustomOperation("max_concurrent_shard_requests")>]
        member _.MaxConcurrentShardRequests(state: FleetMsearchRequest, value: float) =
            { state with FleetMsearchRequest.MaxConcurrentShardRequests = Option.Some value } : FleetMsearchRequest

        [<CustomOperation("pre_filter_shard_size")>]
        member _.PreFilterShardSize(state: FleetMsearchRequest, value: float) =
            { state with FleetMsearchRequest.PreFilterShardSize = Option.Some value } : FleetMsearchRequest

        [<CustomOperation("search_type")>]
        member _.SearchType(state: FleetMsearchRequest, value: SearchType) =
            { state with FleetMsearchRequest.SearchType = Option.Some value } : FleetMsearchRequest

        [<CustomOperation("rest_total_hits_as_int")>]
        member _.RestTotalHitsAsInt(state: FleetMsearchRequest, value: bool) =
            { state with FleetMsearchRequest.RestTotalHitsAsInt = Option.Some value } : FleetMsearchRequest

        [<CustomOperation("typed_keys")>]
        member _.TypedKeys(state: FleetMsearchRequest, value: bool) =
            { state with FleetMsearchRequest.TypedKeys = Option.Some value } : FleetMsearchRequest

        [<CustomOperation("wait_for_checkpoints")>]
        member _.WaitForCheckpoints(state: FleetMsearchRequest, value: TypesCheckpoint array) =
            { state with FleetMsearchRequest.WaitForCheckpoints = Option.Some value } : FleetMsearchRequest

        [<CustomOperation("allow_partial_search_results")>]
        member _.AllowPartialSearchResults(state: FleetMsearchRequest, value: bool) =
            { state with FleetMsearchRequest.AllowPartialSearchResults = Option.Some value } : FleetMsearchRequest

    let fleetMsearchRequest = FleetMsearchRequestBuilder()

    type FleetSearchRequest = {
        Index: System.Text.Json.JsonElement
        AllowNoIndices: bool option
        Analyzer: string option
        AnalyzeWildcard: bool option
        BatchedReduceSize: float option
        CcsMinimizeRoundtrips: bool option
        DefaultOperator: QueryDslOperator option
        Df: string option
        DocvalueFields: Fields option
        ExpandWildcards: ExpandWildcards option
        Explain: bool option
        IgnoreThrottled: bool option
        IgnoreUnavailable: bool option
        Lenient: bool option
        MaxConcurrentShardRequests: float option
        Preference: string option
        PreFilterShardSize: float option
        RequestCache: bool option
        Routing: Routing option
        Scroll: Duration option
        SearchType: SearchType option
        Stats: string array option
        StoredFields: Fields option
        SuggestField: Field option
        SuggestMode: SuggestMode option
        SuggestSize: float option
        SuggestText: string option
        TerminateAfter: float option
        Timeout: Duration option
        TrackTotalHits: SearchTypesTrackHits option
        TrackScores: bool option
        TypedKeys: bool option
        RestTotalHitsAsInt: bool option
        Version: bool option
        Source: SearchTypesSourceConfigParam option
        SourceExcludes: Fields option
        SourceIncludes: Fields option
        SeqNoPrimaryTerm: bool option
        Q: string option
        Size: float option
        From: float option
        Sort: System.Text.Json.JsonElement option
        WaitForCheckpoints: TypesCheckpoint array option
        AllowPartialSearchResults: bool option
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
        static member ToRequest(request: FleetSearchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_fleet/_fleet_search"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.Analyzer |> Option.map (fun v -> "analyzer", Fes.Http.toQueryValue v)
                        request.AnalyzeWildcard |> Option.map (fun v -> "analyze_wildcard", Fes.Http.toQueryValue v)
                        request.BatchedReduceSize |> Option.map (fun v -> "batched_reduce_size", Fes.Http.toQueryValue v)
                        request.CcsMinimizeRoundtrips |> Option.map (fun v -> "ccs_minimize_roundtrips", Fes.Http.toQueryValue v)
                        request.DefaultOperator |> Option.map (fun v -> "default_operator", Fes.Http.toQueryValue v)
                        request.Df |> Option.map (fun v -> "df", Fes.Http.toQueryValue v)
                        request.DocvalueFields |> Option.map (fun v -> "docvalue_fields", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.Explain |> Option.map (fun v -> "explain", Fes.Http.toQueryValue v)
                        request.IgnoreThrottled |> Option.map (fun v -> "ignore_throttled", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        request.Lenient |> Option.map (fun v -> "lenient", Fes.Http.toQueryValue v)
                        request.MaxConcurrentShardRequests |> Option.map (fun v -> "max_concurrent_shard_requests", Fes.Http.toQueryValue v)
                        request.Preference |> Option.map (fun v -> "preference", Fes.Http.toQueryValue v)
                        request.PreFilterShardSize |> Option.map (fun v -> "pre_filter_shard_size", Fes.Http.toQueryValue v)
                        request.RequestCache |> Option.map (fun v -> "request_cache", Fes.Http.toQueryValue v)
                        request.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                        request.Scroll |> Option.map (fun v -> "scroll", Fes.Http.toQueryValue v)
                        request.SearchType |> Option.map (fun v -> "search_type", Fes.Http.toQueryValue v)
                        request.Stats |> Option.map (fun v -> "stats", Fes.Http.toQueryValue v)
                        request.StoredFields |> Option.map (fun v -> "stored_fields", Fes.Http.toQueryValue v)
                        request.SuggestField |> Option.map (fun v -> "suggest_field", Fes.Http.toQueryValue v)
                        request.SuggestMode |> Option.map (fun v -> "suggest_mode", Fes.Http.toQueryValue v)
                        request.SuggestSize |> Option.map (fun v -> "suggest_size", Fes.Http.toQueryValue v)
                        request.SuggestText |> Option.map (fun v -> "suggest_text", Fes.Http.toQueryValue v)
                        request.TerminateAfter |> Option.map (fun v -> "terminate_after", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        request.TrackTotalHits |> Option.map (fun v -> "track_total_hits", Fes.Http.toQueryValue v)
                        request.TrackScores |> Option.map (fun v -> "track_scores", Fes.Http.toQueryValue v)
                        request.TypedKeys |> Option.map (fun v -> "typed_keys", Fes.Http.toQueryValue v)
                        request.RestTotalHitsAsInt |> Option.map (fun v -> "rest_total_hits_as_int", Fes.Http.toQueryValue v)
                        request.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                        request.Source |> Option.map (fun v -> "_source", Fes.Http.toQueryValue v)
                        request.SourceExcludes |> Option.map (fun v -> "_source_excludes", Fes.Http.toQueryValue v)
                        request.SourceIncludes |> Option.map (fun v -> "_source_includes", Fes.Http.toQueryValue v)
                        request.SeqNoPrimaryTerm |> Option.map (fun v -> "seq_no_primary_term", Fes.Http.toQueryValue v)
                        request.Q |> Option.map (fun v -> "q", Fes.Http.toQueryValue v)
                        request.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                        request.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        request.Sort |> Option.map (fun v -> "sort", Fes.Http.toQueryValue v)
                        request.WaitForCheckpoints |> Option.map (fun v -> "wait_for_checkpoints", Fes.Http.toQueryValue v)
                        request.AllowPartialSearchResults |> Option.map (fun v -> "allow_partial_search_results", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``aggregations`` = request.Aggregations; ``collapse`` = request.Collapse; ``explain`` = request.Explain2; ``ext`` = request.Ext; ``from`` = request.From2; ``highlight`` = request.Highlight; ``track_total_hits`` = request.TrackTotalHits2; ``indices_boost`` = request.IndicesBoost; ``docvalue_fields`` = request.DocvalueFields2; ``min_score`` = request.MinScore; ``post_filter`` = request.PostFilter; ``profile`` = request.Profile; ``query`` = request.Query; ``rescore`` = request.Rescore; ``script_fields`` = request.ScriptFields; ``search_after`` = request.SearchAfter; ``size`` = request.Size2; ``slice`` = request.Slice; ``sort`` = request.Sort2; ``_source`` = request.Source2; ``fields`` = request.Fields; ``suggest`` = request.Suggest; ``terminate_after`` = request.TerminateAfter2; ``timeout`` = request.Timeout2; ``track_scores`` = request.TrackScores2; ``version`` = request.Version2; ``seq_no_primary_term`` = request.SeqNoPrimaryTerm2; ``stored_fields`` = request.StoredFields2; ``pit`` = request.Pit; ``runtime_mappings`` = request.RuntimeMappings; ``stats`` = request.Stats2 |}
                |> Result.Ok
            with ex -> Result.Error ex

    module FleetSearchRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: FleetSearchRequest) : Result<Fes.Http.RequestMsg, exn> =
            FleetSearchRequest.ToRequest request

    type FleetSearchRequestBuilder() =
        member _.Yield(_: unit) : FleetSearchRequest =
            {
                FleetSearchRequest.Index = Unchecked.defaultof<System.Text.Json.JsonElement>
                FleetSearchRequest.AllowNoIndices = Option.None
                FleetSearchRequest.Analyzer = Option.None
                FleetSearchRequest.AnalyzeWildcard = Option.None
                FleetSearchRequest.BatchedReduceSize = Option.None
                FleetSearchRequest.CcsMinimizeRoundtrips = Option.None
                FleetSearchRequest.DefaultOperator = Option.None
                FleetSearchRequest.Df = Option.None
                FleetSearchRequest.DocvalueFields = Option.None
                FleetSearchRequest.ExpandWildcards = Option.None
                FleetSearchRequest.Explain = Option.None
                FleetSearchRequest.IgnoreThrottled = Option.None
                FleetSearchRequest.IgnoreUnavailable = Option.None
                FleetSearchRequest.Lenient = Option.None
                FleetSearchRequest.MaxConcurrentShardRequests = Option.None
                FleetSearchRequest.Preference = Option.None
                FleetSearchRequest.PreFilterShardSize = Option.None
                FleetSearchRequest.RequestCache = Option.None
                FleetSearchRequest.Routing = Option.None
                FleetSearchRequest.Scroll = Option.None
                FleetSearchRequest.SearchType = Option.None
                FleetSearchRequest.Stats = Option.None
                FleetSearchRequest.StoredFields = Option.None
                FleetSearchRequest.SuggestField = Option.None
                FleetSearchRequest.SuggestMode = Option.None
                FleetSearchRequest.SuggestSize = Option.None
                FleetSearchRequest.SuggestText = Option.None
                FleetSearchRequest.TerminateAfter = Option.None
                FleetSearchRequest.Timeout = Option.None
                FleetSearchRequest.TrackTotalHits = Option.None
                FleetSearchRequest.TrackScores = Option.None
                FleetSearchRequest.TypedKeys = Option.None
                FleetSearchRequest.RestTotalHitsAsInt = Option.None
                FleetSearchRequest.Version = Option.None
                FleetSearchRequest.Source = Option.None
                FleetSearchRequest.SourceExcludes = Option.None
                FleetSearchRequest.SourceIncludes = Option.None
                FleetSearchRequest.SeqNoPrimaryTerm = Option.None
                FleetSearchRequest.Q = Option.None
                FleetSearchRequest.Size = Option.None
                FleetSearchRequest.From = Option.None
                FleetSearchRequest.Sort = Option.None
                FleetSearchRequest.WaitForCheckpoints = Option.None
                FleetSearchRequest.AllowPartialSearchResults = Option.None
                FleetSearchRequest.Aggregations = Option.None
                FleetSearchRequest.Collapse = Option.None
                FleetSearchRequest.Explain2 = Option.None
                FleetSearchRequest.Ext = Option.None
                FleetSearchRequest.From2 = Option.None
                FleetSearchRequest.Highlight = Option.None
                FleetSearchRequest.TrackTotalHits2 = Option.None
                FleetSearchRequest.IndicesBoost = Option.None
                FleetSearchRequest.DocvalueFields2 = Option.None
                FleetSearchRequest.MinScore = Option.None
                FleetSearchRequest.PostFilter = Option.None
                FleetSearchRequest.Profile = Option.None
                FleetSearchRequest.Query = Option.None
                FleetSearchRequest.Rescore = Option.None
                FleetSearchRequest.ScriptFields = Option.None
                FleetSearchRequest.SearchAfter = Option.None
                FleetSearchRequest.Size2 = Option.None
                FleetSearchRequest.Slice = Option.None
                FleetSearchRequest.Sort2 = Option.None
                FleetSearchRequest.Source2 = Option.None
                FleetSearchRequest.Fields = Option.None
                FleetSearchRequest.Suggest = Option.None
                FleetSearchRequest.TerminateAfter2 = Option.None
                FleetSearchRequest.Timeout2 = Option.None
                FleetSearchRequest.TrackScores2 = Option.None
                FleetSearchRequest.Version2 = Option.None
                FleetSearchRequest.SeqNoPrimaryTerm2 = Option.None
                FleetSearchRequest.StoredFields2 = Option.None
                FleetSearchRequest.Pit = Option.None
                FleetSearchRequest.RuntimeMappings = Option.None
                FleetSearchRequest.Stats2 = Option.None
            } : FleetSearchRequest

        [<CustomOperation("index")>]
        member _.Index(state: FleetSearchRequest, value: System.Text.Json.JsonElement) =
            { state with FleetSearchRequest.Index = value } : FleetSearchRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: FleetSearchRequest, value: bool) =
            { state with FleetSearchRequest.AllowNoIndices = Option.Some value } : FleetSearchRequest

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: FleetSearchRequest, value: string) =
            { state with FleetSearchRequest.Analyzer = Option.Some value } : FleetSearchRequest

        [<CustomOperation("analyze_wildcard")>]
        member _.AnalyzeWildcard(state: FleetSearchRequest, value: bool) =
            { state with FleetSearchRequest.AnalyzeWildcard = Option.Some value } : FleetSearchRequest

        [<CustomOperation("batched_reduce_size")>]
        member _.BatchedReduceSize(state: FleetSearchRequest, value: float) =
            { state with FleetSearchRequest.BatchedReduceSize = Option.Some value } : FleetSearchRequest

        [<CustomOperation("ccs_minimize_roundtrips")>]
        member _.CcsMinimizeRoundtrips(state: FleetSearchRequest, value: bool) =
            { state with FleetSearchRequest.CcsMinimizeRoundtrips = Option.Some value } : FleetSearchRequest

        [<CustomOperation("default_operator")>]
        member _.DefaultOperator(state: FleetSearchRequest, value: QueryDslOperator) =
            { state with FleetSearchRequest.DefaultOperator = Option.Some value } : FleetSearchRequest

        [<CustomOperation("df")>]
        member _.Df(state: FleetSearchRequest, value: string) =
            { state with FleetSearchRequest.Df = Option.Some value } : FleetSearchRequest

        [<CustomOperation("docvalue_fields")>]
        member _.DocvalueFields(state: FleetSearchRequest, value: Fields) =
            { state with FleetSearchRequest.DocvalueFields = Option.Some value } : FleetSearchRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: FleetSearchRequest, value: ExpandWildcards) =
            { state with FleetSearchRequest.ExpandWildcards = Option.Some value } : FleetSearchRequest

        [<CustomOperation("explain")>]
        member _.Explain(state: FleetSearchRequest, value: bool) =
            { state with FleetSearchRequest.Explain = Option.Some value } : FleetSearchRequest

        [<CustomOperation("ignore_throttled")>]
        member _.IgnoreThrottled(state: FleetSearchRequest, value: bool) =
            { state with FleetSearchRequest.IgnoreThrottled = Option.Some value } : FleetSearchRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: FleetSearchRequest, value: bool) =
            { state with FleetSearchRequest.IgnoreUnavailable = Option.Some value } : FleetSearchRequest

        [<CustomOperation("lenient")>]
        member _.Lenient(state: FleetSearchRequest, value: bool) =
            { state with FleetSearchRequest.Lenient = Option.Some value } : FleetSearchRequest

        [<CustomOperation("max_concurrent_shard_requests")>]
        member _.MaxConcurrentShardRequests(state: FleetSearchRequest, value: float) =
            { state with FleetSearchRequest.MaxConcurrentShardRequests = Option.Some value } : FleetSearchRequest

        [<CustomOperation("preference")>]
        member _.Preference(state: FleetSearchRequest, value: string) =
            { state with FleetSearchRequest.Preference = Option.Some value } : FleetSearchRequest

        [<CustomOperation("pre_filter_shard_size")>]
        member _.PreFilterShardSize(state: FleetSearchRequest, value: float) =
            { state with FleetSearchRequest.PreFilterShardSize = Option.Some value } : FleetSearchRequest

        [<CustomOperation("request_cache")>]
        member _.RequestCache(state: FleetSearchRequest, value: bool) =
            { state with FleetSearchRequest.RequestCache = Option.Some value } : FleetSearchRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: FleetSearchRequest, value: Routing) =
            { state with FleetSearchRequest.Routing = Option.Some value } : FleetSearchRequest

        [<CustomOperation("scroll")>]
        member _.Scroll(state: FleetSearchRequest, value: Duration) =
            { state with FleetSearchRequest.Scroll = Option.Some value } : FleetSearchRequest

        [<CustomOperation("search_type")>]
        member _.SearchType(state: FleetSearchRequest, value: SearchType) =
            { state with FleetSearchRequest.SearchType = Option.Some value } : FleetSearchRequest

        [<CustomOperation("stats")>]
        member _.Stats(state: FleetSearchRequest, value: string array) =
            { state with FleetSearchRequest.Stats = Option.Some value } : FleetSearchRequest

        [<CustomOperation("stored_fields")>]
        member _.StoredFields(state: FleetSearchRequest, value: Fields) =
            { state with FleetSearchRequest.StoredFields = Option.Some value } : FleetSearchRequest

        [<CustomOperation("suggest_field")>]
        member _.SuggestField(state: FleetSearchRequest, value: Field) =
            { state with FleetSearchRequest.SuggestField = Option.Some value } : FleetSearchRequest

        [<CustomOperation("suggest_mode")>]
        member _.SuggestMode(state: FleetSearchRequest, value: SuggestMode) =
            { state with FleetSearchRequest.SuggestMode = Option.Some value } : FleetSearchRequest

        [<CustomOperation("suggest_size")>]
        member _.SuggestSize(state: FleetSearchRequest, value: float) =
            { state with FleetSearchRequest.SuggestSize = Option.Some value } : FleetSearchRequest

        [<CustomOperation("suggest_text")>]
        member _.SuggestText(state: FleetSearchRequest, value: string) =
            { state with FleetSearchRequest.SuggestText = Option.Some value } : FleetSearchRequest

        [<CustomOperation("terminate_after")>]
        member _.TerminateAfter(state: FleetSearchRequest, value: float) =
            { state with FleetSearchRequest.TerminateAfter = Option.Some value } : FleetSearchRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: FleetSearchRequest, value: Duration) =
            { state with FleetSearchRequest.Timeout = Option.Some value } : FleetSearchRequest

        [<CustomOperation("track_total_hits")>]
        member _.TrackTotalHits(state: FleetSearchRequest, value: SearchTypesTrackHits) =
            { state with FleetSearchRequest.TrackTotalHits = Option.Some value } : FleetSearchRequest

        [<CustomOperation("track_scores")>]
        member _.TrackScores(state: FleetSearchRequest, value: bool) =
            { state with FleetSearchRequest.TrackScores = Option.Some value } : FleetSearchRequest

        [<CustomOperation("typed_keys")>]
        member _.TypedKeys(state: FleetSearchRequest, value: bool) =
            { state with FleetSearchRequest.TypedKeys = Option.Some value } : FleetSearchRequest

        [<CustomOperation("rest_total_hits_as_int")>]
        member _.RestTotalHitsAsInt(state: FleetSearchRequest, value: bool) =
            { state with FleetSearchRequest.RestTotalHitsAsInt = Option.Some value } : FleetSearchRequest

        [<CustomOperation("version")>]
        member _.Version(state: FleetSearchRequest, value: bool) =
            { state with FleetSearchRequest.Version = Option.Some value } : FleetSearchRequest

        [<CustomOperation("_source")>]
        member _.Source(state: FleetSearchRequest, value: SearchTypesSourceConfigParam) =
            { state with FleetSearchRequest.Source = Option.Some value } : FleetSearchRequest

        [<CustomOperation("_source_excludes")>]
        member _.SourceExcludes(state: FleetSearchRequest, value: Fields) =
            { state with FleetSearchRequest.SourceExcludes = Option.Some value } : FleetSearchRequest

        [<CustomOperation("_source_includes")>]
        member _.SourceIncludes(state: FleetSearchRequest, value: Fields) =
            { state with FleetSearchRequest.SourceIncludes = Option.Some value } : FleetSearchRequest

        [<CustomOperation("seq_no_primary_term")>]
        member _.SeqNoPrimaryTerm(state: FleetSearchRequest, value: bool) =
            { state with FleetSearchRequest.SeqNoPrimaryTerm = Option.Some value } : FleetSearchRequest

        [<CustomOperation("q")>]
        member _.Q(state: FleetSearchRequest, value: string) =
            { state with FleetSearchRequest.Q = Option.Some value } : FleetSearchRequest

        [<CustomOperation("size")>]
        member _.Size(state: FleetSearchRequest, value: float) =
            { state with FleetSearchRequest.Size = Option.Some value } : FleetSearchRequest

        [<CustomOperation("from")>]
        member _.From(state: FleetSearchRequest, value: float) =
            { state with FleetSearchRequest.From = Option.Some value } : FleetSearchRequest

        [<CustomOperation("sort")>]
        member _.Sort(state: FleetSearchRequest, value: System.Text.Json.JsonElement) =
            { state with FleetSearchRequest.Sort = Option.Some value } : FleetSearchRequest

        [<CustomOperation("wait_for_checkpoints")>]
        member _.WaitForCheckpoints(state: FleetSearchRequest, value: TypesCheckpoint array) =
            { state with FleetSearchRequest.WaitForCheckpoints = Option.Some value } : FleetSearchRequest

        [<CustomOperation("allow_partial_search_results")>]
        member _.AllowPartialSearchResults(state: FleetSearchRequest, value: bool) =
            { state with FleetSearchRequest.AllowPartialSearchResults = Option.Some value } : FleetSearchRequest

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: FleetSearchRequest, value: Map<string, AggregationsAggregationContainer>) =
            { state with FleetSearchRequest.Aggregations = Option.Some value } : FleetSearchRequest

        [<CustomOperation("collapse")>]
        member _.Collapse(state: FleetSearchRequest, value: SearchTypesFieldCollapse) =
            { state with FleetSearchRequest.Collapse = Option.Some value } : FleetSearchRequest

        [<CustomOperation("explain2")>]
        member _.Explain2(state: FleetSearchRequest, value: bool) =
            { state with FleetSearchRequest.Explain2 = Option.Some value } : FleetSearchRequest

        [<CustomOperation("ext")>]
        member _.Ext(state: FleetSearchRequest, value: Map<string, obj>) =
            { state with FleetSearchRequest.Ext = Option.Some value } : FleetSearchRequest

        [<CustomOperation("from2")>]
        member _.From2(state: FleetSearchRequest, value: float) =
            { state with FleetSearchRequest.From2 = Option.Some value } : FleetSearchRequest

        [<CustomOperation("highlight")>]
        member _.Highlight(state: FleetSearchRequest, value: SearchTypesHighlight) =
            { state with FleetSearchRequest.Highlight = Option.Some value } : FleetSearchRequest

        [<CustomOperation("track_total_hits2")>]
        member _.TrackTotalHits2(state: FleetSearchRequest, value: SearchTypesTrackHits) =
            { state with FleetSearchRequest.TrackTotalHits2 = Option.Some value } : FleetSearchRequest

        [<CustomOperation("indices_boost")>]
        member _.IndicesBoost(state: FleetSearchRequest, value: Map<string, float> array) =
            { state with FleetSearchRequest.IndicesBoost = Option.Some value } : FleetSearchRequest

        [<CustomOperation("docvalue_fields2")>]
        member _.DocvalueFields2(state: FleetSearchRequest, value: QueryDslFieldAndFormat array) =
            { state with FleetSearchRequest.DocvalueFields2 = Option.Some value } : FleetSearchRequest

        [<CustomOperation("min_score")>]
        member _.MinScore(state: FleetSearchRequest, value: float) =
            { state with FleetSearchRequest.MinScore = Option.Some value } : FleetSearchRequest

        [<CustomOperation("post_filter")>]
        member _.PostFilter(state: FleetSearchRequest, value: QueryDslQueryContainer) =
            { state with FleetSearchRequest.PostFilter = Option.Some value } : FleetSearchRequest

        [<CustomOperation("profile")>]
        member _.Profile(state: FleetSearchRequest, value: bool) =
            { state with FleetSearchRequest.Profile = Option.Some value } : FleetSearchRequest

        [<CustomOperation("query")>]
        member _.Query(state: FleetSearchRequest, value: QueryDslQueryContainer) =
            { state with FleetSearchRequest.Query = Option.Some value } : FleetSearchRequest

        [<CustomOperation("rescore")>]
        member _.Rescore(state: FleetSearchRequest, value: System.Text.Json.JsonElement) =
            { state with FleetSearchRequest.Rescore = Option.Some value } : FleetSearchRequest

        [<CustomOperation("script_fields")>]
        member _.ScriptFields(state: FleetSearchRequest, value: Map<string, ScriptField>) =
            { state with FleetSearchRequest.ScriptFields = Option.Some value } : FleetSearchRequest

        [<CustomOperation("search_after")>]
        member _.SearchAfter(state: FleetSearchRequest, value: SortResults) =
            { state with FleetSearchRequest.SearchAfter = Option.Some value } : FleetSearchRequest

        [<CustomOperation("size2")>]
        member _.Size2(state: FleetSearchRequest, value: float) =
            { state with FleetSearchRequest.Size2 = Option.Some value } : FleetSearchRequest

        [<CustomOperation("slice")>]
        member _.Slice(state: FleetSearchRequest, value: SlicedScroll) =
            { state with FleetSearchRequest.Slice = Option.Some value } : FleetSearchRequest

        [<CustomOperation("sort2")>]
        member _.Sort2(state: FleetSearchRequest, value: Sort) =
            { state with FleetSearchRequest.Sort2 = Option.Some value } : FleetSearchRequest

        [<CustomOperation("_source2")>]
        member _.Source2(state: FleetSearchRequest, value: SearchTypesSourceConfig) =
            { state with FleetSearchRequest.Source2 = Option.Some value } : FleetSearchRequest

        [<CustomOperation("fields")>]
        member _.Fields(state: FleetSearchRequest, value: QueryDslFieldAndFormat array) =
            { state with FleetSearchRequest.Fields = Option.Some value } : FleetSearchRequest

        [<CustomOperation("suggest")>]
        member _.Suggest(state: FleetSearchRequest, value: SearchTypesSuggester) =
            { state with FleetSearchRequest.Suggest = Option.Some value } : FleetSearchRequest

        [<CustomOperation("terminate_after2")>]
        member _.TerminateAfter2(state: FleetSearchRequest, value: float) =
            { state with FleetSearchRequest.TerminateAfter2 = Option.Some value } : FleetSearchRequest

        [<CustomOperation("timeout2")>]
        member _.Timeout2(state: FleetSearchRequest, value: string) =
            { state with FleetSearchRequest.Timeout2 = Option.Some value } : FleetSearchRequest

        [<CustomOperation("track_scores2")>]
        member _.TrackScores2(state: FleetSearchRequest, value: bool) =
            { state with FleetSearchRequest.TrackScores2 = Option.Some value } : FleetSearchRequest

        [<CustomOperation("version2")>]
        member _.Version2(state: FleetSearchRequest, value: bool) =
            { state with FleetSearchRequest.Version2 = Option.Some value } : FleetSearchRequest

        [<CustomOperation("seq_no_primary_term2")>]
        member _.SeqNoPrimaryTerm2(state: FleetSearchRequest, value: bool) =
            { state with FleetSearchRequest.SeqNoPrimaryTerm2 = Option.Some value } : FleetSearchRequest

        [<CustomOperation("stored_fields2")>]
        member _.StoredFields2(state: FleetSearchRequest, value: Fields) =
            { state with FleetSearchRequest.StoredFields2 = Option.Some value } : FleetSearchRequest

        [<CustomOperation("pit")>]
        member _.Pit(state: FleetSearchRequest, value: SearchTypesPointInTimeReference) =
            { state with FleetSearchRequest.Pit = Option.Some value } : FleetSearchRequest

        [<CustomOperation("runtime_mappings")>]
        member _.RuntimeMappings(state: FleetSearchRequest, value: MappingRuntimeFields) =
            { state with FleetSearchRequest.RuntimeMappings = Option.Some value } : FleetSearchRequest

        [<CustomOperation("stats2")>]
        member _.Stats2(state: FleetSearchRequest, value: string array) =
            { state with FleetSearchRequest.Stats2 = Option.Some value } : FleetSearchRequest

    let fleetSearchRequest = FleetSearchRequestBuilder()


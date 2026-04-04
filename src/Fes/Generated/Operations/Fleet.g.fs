// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module FleetOperations =

    type FleetDeleteSecretRequest = {
        Id: string
    }

        with
        static member ToEndpoint(req: FleetDeleteSecretRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_fleet/secret/{Fes.Http.toPathSegment req.Id}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type FleetDeleteSecretResponse = System.Text.Json.JsonElement

    type FleetDeleteSecretRequestBuilder() =
        member _.Yield(_: unit) : FleetDeleteSecretRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: FleetDeleteSecretRequest, value: string) =
            { state with Id = value }

    let fleetDeleteSecretRequest = FleetDeleteSecretRequestBuilder()

    type FleetGetSecretRequest = {
        Id: string
    }

        with
        static member ToEndpoint(req: FleetGetSecretRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_fleet/secret/{Fes.Http.toPathSegment req.Id}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type FleetGetSecretResponse = System.Text.Json.JsonElement

    type FleetGetSecretRequestBuilder() =
        member _.Yield(_: unit) : FleetGetSecretRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: FleetGetSecretRequest, value: string) =
            { state with Id = value }

    let fleetGetSecretRequest = FleetGetSecretRequestBuilder()

    type FleetGlobalCheckpointsRequest = {
        Index: System.Text.Json.JsonElement
        WaitForAdvance: bool option
        WaitForIndex: bool option
        Checkpoints: Types.Checkpoint list option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: FleetGlobalCheckpointsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_fleet/global_checkpoints"
            let queryParams =
                [
                    req.WaitForAdvance |> Option.map (fun v -> "wait_for_advance", Fes.Http.toQueryValue v)
                    req.WaitForIndex |> Option.map (fun v -> "wait_for_index", Fes.Http.toQueryValue v)
                    req.Checkpoints |> Option.map (fun v -> "checkpoints", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type FleetGlobalCheckpointsResponse = System.Text.Json.JsonElement

    type FleetGlobalCheckpointsRequestBuilder() =
        member _.Yield(_: unit) : FleetGlobalCheckpointsRequest =
            {
                Index = Unchecked.defaultof<_>
                WaitForAdvance = None
                WaitForIndex = None
                Checkpoints = None
                Timeout = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: FleetGlobalCheckpointsRequest, value: System.Text.Json.JsonElement) =
            { state with Index = value }

        [<CustomOperation("waitForAdvance")>]
        member _.WaitForAdvance(state: FleetGlobalCheckpointsRequest, value: bool) =
            { state with WaitForAdvance = Some value }

        [<CustomOperation("waitForIndex")>]
        member _.WaitForIndex(state: FleetGlobalCheckpointsRequest, value: bool) =
            { state with WaitForIndex = Some value }

        [<CustomOperation("checkpoints")>]
        member _.Checkpoints(state: FleetGlobalCheckpointsRequest, value: Types.Checkpoint list) =
            { state with Checkpoints = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: FleetGlobalCheckpointsRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let fleetGlobalCheckpointsRequest = FleetGlobalCheckpointsRequestBuilder()

    module GlobalCheckpoints =
        let withWaitForAdvance (value: bool) (req: FleetGlobalCheckpointsRequest) =
            { req with WaitForAdvance = Some value }
        let withWaitForIndex (value: bool) (req: FleetGlobalCheckpointsRequest) =
            { req with WaitForIndex = Some value }
        let withCheckpoints (value: Types.Checkpoint list) (req: FleetGlobalCheckpointsRequest) =
            { req with Checkpoints = Some value }
        let withTimeout (value: Types.Duration) (req: FleetGlobalCheckpointsRequest) =
            { req with Timeout = Some value }

    type FleetMsearchRequest = {
        Index: System.Text.Json.JsonElement
        AllowNoIndices: bool option
        CcsMinimizeRoundtrips: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreThrottled: bool option
        IgnoreUnavailable: bool option
        MaxConcurrentSearches: Types.Integer option
        MaxConcurrentShardRequests: Types.Integer option
        PreFilterShardSize: Types.Long option
        SearchType: Types.SearchType option
        RestTotalHitsAsInt: bool option
        TypedKeys: bool option
        WaitForCheckpoints: Types.Checkpoint list option
        AllowPartialSearchResults: bool option
        Document: Types.GlobalMsearchRequestItem list
    }

        with
        static member ToEndpoint(req: FleetMsearchRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_fleet/_fleet_msearch"
            let queryParams =
                [
                    req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                    req.CcsMinimizeRoundtrips |> Option.map (fun v -> "ccs_minimize_roundtrips", Fes.Http.toQueryValue v)
                    req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                    req.IgnoreThrottled |> Option.map (fun v -> "ignore_throttled", Fes.Http.toQueryValue v)
                    req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                    req.MaxConcurrentSearches |> Option.map (fun v -> "max_concurrent_searches", Fes.Http.toQueryValue v)
                    req.MaxConcurrentShardRequests |> Option.map (fun v -> "max_concurrent_shard_requests", Fes.Http.toQueryValue v)
                    req.PreFilterShardSize |> Option.map (fun v -> "pre_filter_shard_size", Fes.Http.toQueryValue v)
                    req.SearchType |> Option.map (fun v -> "search_type", Fes.Http.toQueryValue v)
                    req.RestTotalHitsAsInt |> Option.map (fun v -> "rest_total_hits_as_int", Fes.Http.toQueryValue v)
                    req.TypedKeys |> Option.map (fun v -> "typed_keys", Fes.Http.toQueryValue v)
                    req.WaitForCheckpoints |> Option.map (fun v -> "wait_for_checkpoints", Fes.Http.toQueryValue v)
                    req.AllowPartialSearchResults |> Option.map (fun v -> "allow_partial_search_results", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req.Document)
            endpoint, ValueSome postData

    type FleetMsearchResponse = System.Text.Json.JsonElement

    type FleetMsearchRequestBuilder() =
        member _.Yield(_: unit) : FleetMsearchRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                CcsMinimizeRoundtrips = None
                ExpandWildcards = None
                IgnoreThrottled = None
                IgnoreUnavailable = None
                MaxConcurrentSearches = None
                MaxConcurrentShardRequests = None
                PreFilterShardSize = None
                SearchType = None
                RestTotalHitsAsInt = None
                TypedKeys = None
                WaitForCheckpoints = None
                AllowPartialSearchResults = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("index")>]
        member _.Index(state: FleetMsearchRequest, value: System.Text.Json.JsonElement) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: FleetMsearchRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("ccsMinimizeRoundtrips")>]
        member _.CcsMinimizeRoundtrips(state: FleetMsearchRequest, value: bool) =
            { state with CcsMinimizeRoundtrips = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: FleetMsearchRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreThrottled")>]
        member _.IgnoreThrottled(state: FleetMsearchRequest, value: bool) =
            { state with IgnoreThrottled = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: FleetMsearchRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("maxConcurrentSearches")>]
        member _.MaxConcurrentSearches(state: FleetMsearchRequest, value: Types.Integer) =
            { state with MaxConcurrentSearches = Some value }

        [<CustomOperation("maxConcurrentShardRequests")>]
        member _.MaxConcurrentShardRequests(state: FleetMsearchRequest, value: Types.Integer) =
            { state with MaxConcurrentShardRequests = Some value }

        [<CustomOperation("preFilterShardSize")>]
        member _.PreFilterShardSize(state: FleetMsearchRequest, value: Types.Long) =
            { state with PreFilterShardSize = Some value }

        [<CustomOperation("searchType")>]
        member _.SearchType(state: FleetMsearchRequest, value: Types.SearchType) =
            { state with SearchType = Some value }

        [<CustomOperation("restTotalHitsAsInt")>]
        member _.RestTotalHitsAsInt(state: FleetMsearchRequest, value: bool) =
            { state with RestTotalHitsAsInt = Some value }

        [<CustomOperation("typedKeys")>]
        member _.TypedKeys(state: FleetMsearchRequest, value: bool) =
            { state with TypedKeys = Some value }

        [<CustomOperation("waitForCheckpoints")>]
        member _.WaitForCheckpoints(state: FleetMsearchRequest, value: Types.Checkpoint list) =
            { state with WaitForCheckpoints = Some value }

        [<CustomOperation("allowPartialSearchResults")>]
        member _.AllowPartialSearchResults(state: FleetMsearchRequest, value: bool) =
            { state with AllowPartialSearchResults = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: FleetMsearchRequest, value) =
            { state with Document = value }

    let fleetMsearchRequest = FleetMsearchRequestBuilder()

    module Msearch =
        let withAllowNoIndices (value: bool) (req: FleetMsearchRequest) =
            { req with AllowNoIndices = Some value }
        let withCcsMinimizeRoundtrips (value: bool) (req: FleetMsearchRequest) =
            { req with CcsMinimizeRoundtrips = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: FleetMsearchRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreThrottled (value: bool) (req: FleetMsearchRequest) =
            { req with IgnoreThrottled = Some value }
        let withIgnoreUnavailable (value: bool) (req: FleetMsearchRequest) =
            { req with IgnoreUnavailable = Some value }
        let withMaxConcurrentSearches (value: Types.Integer) (req: FleetMsearchRequest) =
            { req with MaxConcurrentSearches = Some value }
        let withMaxConcurrentShardRequests (value: Types.Integer) (req: FleetMsearchRequest) =
            { req with MaxConcurrentShardRequests = Some value }
        let withPreFilterShardSize (value: Types.Long) (req: FleetMsearchRequest) =
            { req with PreFilterShardSize = Some value }
        let withSearchType (value: Types.SearchType) (req: FleetMsearchRequest) =
            { req with SearchType = Some value }
        let withRestTotalHitsAsInt (value: bool) (req: FleetMsearchRequest) =
            { req with RestTotalHitsAsInt = Some value }
        let withTypedKeys (value: bool) (req: FleetMsearchRequest) =
            { req with TypedKeys = Some value }
        let withWaitForCheckpoints (value: Types.Checkpoint list) (req: FleetMsearchRequest) =
            { req with WaitForCheckpoints = Some value }
        let withAllowPartialSearchResults (value: bool) (req: FleetMsearchRequest) =
            { req with AllowPartialSearchResults = Some value }

    type FleetPostSecretRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: string
    }

        with
        static member ToEndpoint(req: FleetPostSecretRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_fleet/secret"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type FleetPostSecretResponse = System.Text.Json.JsonElement

    type FleetPostSecretRequestBuilder() =
        member _.Yield(_: unit) : FleetPostSecretRequest =
            {
                Value = Unchecked.defaultof<_>
            }

        [<CustomOperation("value")>]
        member _.Value(state: FleetPostSecretRequest, value: string) =
            { state with Value = value }

    let fleetPostSecretRequest = FleetPostSecretRequestBuilder()

    module PostSecret =
        let withValue (value: string) (req: FleetPostSecretRequest) =
            { req with Value = value }

    type FleetSearchRequest = {
        Index: System.Text.Json.JsonElement
        AllowNoIndices: bool option
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
        SourceIncludes: Types.Fields option
        SeqNoPrimaryTerm: bool option
        Q: string option
        Size: Types.Integer option
        From: Types.Integer option
        Sort: string list option
        WaitForCheckpoints: Types.Checkpoint list option
        AllowPartialSearchResults: bool option
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
        [<System.Text.Json.Serialization.JsonPropertyName("min_score")>]
        MinScore: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("post_filter")>]
        PostFilter: Types.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("profile")>]
        Profile: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: Types.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("rescore")>]
        Rescore: Types.Rescore list option
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
    }

        with
        static member ToEndpoint(req: FleetSearchRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_fleet/_fleet_search"
            let queryParams =
                [
                    req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
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
                    req.SourceIncludes |> Option.map (fun v -> "_source_includes", Fes.Http.toQueryValue v)
                    req.SeqNoPrimaryTerm |> Option.map (fun v -> "seq_no_primary_term", Fes.Http.toQueryValue v)
                    req.Q |> Option.map (fun v -> "q", Fes.Http.toQueryValue v)
                    req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                    req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                    req.Sort |> Option.map (fun v -> "sort", Fes.Http.toQueryValue v)
                    req.WaitForCheckpoints |> Option.map (fun v -> "wait_for_checkpoints", Fes.Http.toQueryValue v)
                    req.AllowPartialSearchResults |> Option.map (fun v -> "allow_partial_search_results", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type FleetSearchResponse = System.Text.Json.JsonElement

    type FleetSearchRequestBuilder() =
        member _.Yield(_: unit) : FleetSearchRequest =
            {
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
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
                SourceIncludes = None
                SeqNoPrimaryTerm = None
                Q = None
                Size = None
                From = None
                Sort = None
                WaitForCheckpoints = None
                AllowPartialSearchResults = None
                Aggregations = None
                Collapse = None
                bodyExplain = None
                Ext = None
                bodyFrom = None
                Highlight = None
                bodyTrackTotalHits = None
                IndicesBoost = None
                bodyDocvalueFields = None
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
            }

        [<CustomOperation("index")>]
        member _.Index(state: FleetSearchRequest, value: System.Text.Json.JsonElement) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: FleetSearchRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: FleetSearchRequest, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("analyzeWildcard")>]
        member _.AnalyzeWildcard(state: FleetSearchRequest, value: bool) =
            { state with AnalyzeWildcard = Some value }

        [<CustomOperation("batchedReduceSize")>]
        member _.BatchedReduceSize(state: FleetSearchRequest, value: Types.Long) =
            { state with BatchedReduceSize = Some value }

        [<CustomOperation("ccsMinimizeRoundtrips")>]
        member _.CcsMinimizeRoundtrips(state: FleetSearchRequest, value: bool) =
            { state with CcsMinimizeRoundtrips = Some value }

        [<CustomOperation("defaultOperator")>]
        member _.DefaultOperator(state: FleetSearchRequest, value: Types.Operator) =
            { state with DefaultOperator = Some value }

        [<CustomOperation("df")>]
        member _.Df(state: FleetSearchRequest, value: string) =
            { state with Df = Some value }

        [<CustomOperation("docvalueFields")>]
        member _.DocvalueFields(state: FleetSearchRequest, value: Types.Fields) =
            { state with DocvalueFields = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: FleetSearchRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("explain")>]
        member _.Explain(state: FleetSearchRequest, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("ignoreThrottled")>]
        member _.IgnoreThrottled(state: FleetSearchRequest, value: bool) =
            { state with IgnoreThrottled = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: FleetSearchRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("lenient")>]
        member _.Lenient(state: FleetSearchRequest, value: bool) =
            { state with Lenient = Some value }

        [<CustomOperation("maxConcurrentShardRequests")>]
        member _.MaxConcurrentShardRequests(state: FleetSearchRequest, value: Types.Integer) =
            { state with MaxConcurrentShardRequests = Some value }

        [<CustomOperation("preference")>]
        member _.Preference(state: FleetSearchRequest, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("preFilterShardSize")>]
        member _.PreFilterShardSize(state: FleetSearchRequest, value: Types.Long) =
            { state with PreFilterShardSize = Some value }

        [<CustomOperation("requestCache")>]
        member _.RequestCache(state: FleetSearchRequest, value: bool) =
            { state with RequestCache = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: FleetSearchRequest, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("scroll")>]
        member _.Scroll(state: FleetSearchRequest, value: Types.Duration) =
            { state with Scroll = Some value }

        [<CustomOperation("searchType")>]
        member _.SearchType(state: FleetSearchRequest, value: Types.SearchType) =
            { state with SearchType = Some value }

        [<CustomOperation("stats")>]
        member _.Stats(state: FleetSearchRequest, value: string list) =
            { state with Stats = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: FleetSearchRequest, value: Types.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("suggestField")>]
        member _.SuggestField(state: FleetSearchRequest, value: Types.Field) =
            { state with SuggestField = Some value }

        [<CustomOperation("suggestMode")>]
        member _.SuggestMode(state: FleetSearchRequest, value: Types.SuggestMode) =
            { state with SuggestMode = Some value }

        [<CustomOperation("suggestSize")>]
        member _.SuggestSize(state: FleetSearchRequest, value: Types.Long) =
            { state with SuggestSize = Some value }

        [<CustomOperation("suggestText")>]
        member _.SuggestText(state: FleetSearchRequest, value: string) =
            { state with SuggestText = Some value }

        [<CustomOperation("terminateAfter")>]
        member _.TerminateAfter(state: FleetSearchRequest, value: Types.Long) =
            { state with TerminateAfter = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: FleetSearchRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("trackTotalHits")>]
        member _.TrackTotalHits(state: FleetSearchRequest, value: Types.TrackHits) =
            { state with TrackTotalHits = Some value }

        [<CustomOperation("trackScores")>]
        member _.TrackScores(state: FleetSearchRequest, value: bool) =
            { state with TrackScores = Some value }

        [<CustomOperation("typedKeys")>]
        member _.TypedKeys(state: FleetSearchRequest, value: bool) =
            { state with TypedKeys = Some value }

        [<CustomOperation("restTotalHitsAsInt")>]
        member _.RestTotalHitsAsInt(state: FleetSearchRequest, value: bool) =
            { state with RestTotalHitsAsInt = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: FleetSearchRequest, value: bool) =
            { state with Version = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: FleetSearchRequest, value: Types.SourceConfigParam) =
            { state with Source = Some value }

        [<CustomOperation("sourceExcludes")>]
        member _.SourceExcludes(state: FleetSearchRequest, value: Types.Fields) =
            { state with SourceExcludes = Some value }

        [<CustomOperation("sourceIncludes")>]
        member _.SourceIncludes(state: FleetSearchRequest, value: Types.Fields) =
            { state with SourceIncludes = Some value }

        [<CustomOperation("seqNoPrimaryTerm")>]
        member _.SeqNoPrimaryTerm(state: FleetSearchRequest, value: bool) =
            { state with SeqNoPrimaryTerm = Some value }

        [<CustomOperation("q")>]
        member _.Q(state: FleetSearchRequest, value: string) =
            { state with Q = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: FleetSearchRequest, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("from")>]
        member _.From(state: FleetSearchRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: FleetSearchRequest, value: string list) =
            { state with Sort = Some value }

        [<CustomOperation("waitForCheckpoints")>]
        member _.WaitForCheckpoints(state: FleetSearchRequest, value: Types.Checkpoint list) =
            { state with WaitForCheckpoints = Some value }

        [<CustomOperation("allowPartialSearchResults")>]
        member _.AllowPartialSearchResults(state: FleetSearchRequest, value: bool) =
            { state with AllowPartialSearchResults = Some value }

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: FleetSearchRequest, value: Map<string, Types.AggregationContainer>) =
            { state with Aggregations = Some value }

        [<CustomOperation("collapse")>]
        member _.Collapse(state: FleetSearchRequest, value: Types.FieldCollapse) =
            { state with Collapse = Some value }

        [<CustomOperation("bodyExplain")>]
        member _.BodyExplain(state: FleetSearchRequest, value: bool) =
            { state with bodyExplain = Some value }

        [<CustomOperation("ext")>]
        member _.Ext(state: FleetSearchRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Ext = Some value }

        [<CustomOperation("bodyFrom")>]
        member _.BodyFrom(state: FleetSearchRequest, value: Types.Integer) =
            { state with bodyFrom = Some value }

        [<CustomOperation("highlight")>]
        member _.Highlight(state: FleetSearchRequest, value: Types.Highlight) =
            { state with Highlight = Some value }

        [<CustomOperation("bodyTrackTotalHits")>]
        member _.BodyTrackTotalHits(state: FleetSearchRequest, value: Types.TrackHits) =
            { state with bodyTrackTotalHits = Some value }

        [<CustomOperation("indicesBoost")>]
        member _.IndicesBoost(state: FleetSearchRequest, value: Map<Types.IndexName, Types.Double> list) =
            { state with IndicesBoost = Some value }

        [<CustomOperation("bodyDocvalueFields")>]
        member _.BodyDocvalueFields(state: FleetSearchRequest, value: Types.FieldAndFormat list) =
            { state with bodyDocvalueFields = Some value }

        [<CustomOperation("minScore")>]
        member _.MinScore(state: FleetSearchRequest, value: Types.Double) =
            { state with MinScore = Some value }

        [<CustomOperation("postFilter")>]
        member _.PostFilter(state: FleetSearchRequest, value: Types.QueryContainer) =
            { state with PostFilter = Some value }

        [<CustomOperation("profile")>]
        member _.Profile(state: FleetSearchRequest, value: bool) =
            { state with Profile = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: FleetSearchRequest, value: Types.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("rescore")>]
        member _.Rescore(state: FleetSearchRequest, value: Types.Rescore list) =
            { state with Rescore = Some value }

        [<CustomOperation("scriptFields")>]
        member _.ScriptFields(state: FleetSearchRequest, value: Map<string, Types.ScriptField>) =
            { state with ScriptFields = Some value }

        [<CustomOperation("searchAfter")>]
        member _.SearchAfter(state: FleetSearchRequest, value: Types.SortResults) =
            { state with SearchAfter = Some value }

        [<CustomOperation("bodySize")>]
        member _.BodySize(state: FleetSearchRequest, value: Types.Integer) =
            { state with bodySize = Some value }

        [<CustomOperation("slice")>]
        member _.Slice(state: FleetSearchRequest, value: Types.SlicedScroll) =
            { state with Slice = Some value }

        [<CustomOperation("bodySort")>]
        member _.BodySort(state: FleetSearchRequest, value: Types.Sort) =
            { state with bodySort = Some value }

        [<CustomOperation("bodySource")>]
        member _.BodySource(state: FleetSearchRequest, value: Types.SourceConfig) =
            { state with bodySource = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: FleetSearchRequest, value: Types.FieldAndFormat list) =
            { state with Fields = Some value }

        [<CustomOperation("suggest")>]
        member _.Suggest(state: FleetSearchRequest, value: Types.Suggester) =
            { state with Suggest = Some value }

        [<CustomOperation("bodyTerminateAfter")>]
        member _.BodyTerminateAfter(state: FleetSearchRequest, value: Types.Long) =
            { state with bodyTerminateAfter = Some value }

        [<CustomOperation("bodyTimeout")>]
        member _.BodyTimeout(state: FleetSearchRequest, value: string) =
            { state with bodyTimeout = Some value }

        [<CustomOperation("bodyTrackScores")>]
        member _.BodyTrackScores(state: FleetSearchRequest, value: bool) =
            { state with bodyTrackScores = Some value }

        [<CustomOperation("bodyVersion")>]
        member _.BodyVersion(state: FleetSearchRequest, value: bool) =
            { state with bodyVersion = Some value }

        [<CustomOperation("bodySeqNoPrimaryTerm")>]
        member _.BodySeqNoPrimaryTerm(state: FleetSearchRequest, value: bool) =
            { state with bodySeqNoPrimaryTerm = Some value }

        [<CustomOperation("bodyStoredFields")>]
        member _.BodyStoredFields(state: FleetSearchRequest, value: Types.Fields) =
            { state with bodyStoredFields = Some value }

        [<CustomOperation("pit")>]
        member _.Pit(state: FleetSearchRequest, value: Types.PointInTimeReference) =
            { state with Pit = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: FleetSearchRequest, value: Types.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("bodyStats")>]
        member _.BodyStats(state: FleetSearchRequest, value: string list) =
            { state with bodyStats = Some value }

    let fleetSearchRequest = FleetSearchRequestBuilder()

    module Search =
        let withAllowNoIndices (value: bool) (req: FleetSearchRequest) =
            { req with AllowNoIndices = Some value }
        let withAnalyzer (value: string) (req: FleetSearchRequest) =
            { req with Analyzer = Some value }
        let withAnalyzeWildcard (value: bool) (req: FleetSearchRequest) =
            { req with AnalyzeWildcard = Some value }
        let withBatchedReduceSize (value: Types.Long) (req: FleetSearchRequest) =
            { req with BatchedReduceSize = Some value }
        let withCcsMinimizeRoundtrips (value: bool) (req: FleetSearchRequest) =
            { req with CcsMinimizeRoundtrips = Some value }
        let withDefaultOperator (value: Types.Operator) (req: FleetSearchRequest) =
            { req with DefaultOperator = Some value }
        let withDf (value: string) (req: FleetSearchRequest) =
            { req with Df = Some value }
        let withDocvalueFields (value: Types.Fields) (req: FleetSearchRequest) =
            { req with DocvalueFields = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: FleetSearchRequest) =
            { req with ExpandWildcards = Some value }
        let withExplain (value: bool) (req: FleetSearchRequest) =
            { req with Explain = Some value }
        let withIgnoreThrottled (value: bool) (req: FleetSearchRequest) =
            { req with IgnoreThrottled = Some value }
        let withIgnoreUnavailable (value: bool) (req: FleetSearchRequest) =
            { req with IgnoreUnavailable = Some value }
        let withLenient (value: bool) (req: FleetSearchRequest) =
            { req with Lenient = Some value }
        let withMaxConcurrentShardRequests (value: Types.Integer) (req: FleetSearchRequest) =
            { req with MaxConcurrentShardRequests = Some value }
        let withPreference (value: string) (req: FleetSearchRequest) =
            { req with Preference = Some value }
        let withPreFilterShardSize (value: Types.Long) (req: FleetSearchRequest) =
            { req with PreFilterShardSize = Some value }
        let withRequestCache (value: bool) (req: FleetSearchRequest) =
            { req with RequestCache = Some value }
        let withRouting (value: Types.Routing) (req: FleetSearchRequest) =
            { req with Routing = Some value }
        let withScroll (value: Types.Duration) (req: FleetSearchRequest) =
            { req with Scroll = Some value }
        let withSearchType (value: Types.SearchType) (req: FleetSearchRequest) =
            { req with SearchType = Some value }
        let withStats (value: string list) (req: FleetSearchRequest) =
            { req with Stats = Some value }
        let withStoredFields (value: Types.Fields) (req: FleetSearchRequest) =
            { req with StoredFields = Some value }
        let withSuggestField (value: Types.Field) (req: FleetSearchRequest) =
            { req with SuggestField = Some value }
        let withSuggestMode (value: Types.SuggestMode) (req: FleetSearchRequest) =
            { req with SuggestMode = Some value }
        let withSuggestSize (value: Types.Long) (req: FleetSearchRequest) =
            { req with SuggestSize = Some value }
        let withSuggestText (value: string) (req: FleetSearchRequest) =
            { req with SuggestText = Some value }
        let withTerminateAfter (value: Types.Long) (req: FleetSearchRequest) =
            { req with TerminateAfter = Some value }
        let withTimeout (value: Types.Duration) (req: FleetSearchRequest) =
            { req with Timeout = Some value }
        let withTrackTotalHits (value: Types.TrackHits) (req: FleetSearchRequest) =
            { req with TrackTotalHits = Some value }
        let withTrackScores (value: bool) (req: FleetSearchRequest) =
            { req with TrackScores = Some value }
        let withTypedKeys (value: bool) (req: FleetSearchRequest) =
            { req with TypedKeys = Some value }
        let withRestTotalHitsAsInt (value: bool) (req: FleetSearchRequest) =
            { req with RestTotalHitsAsInt = Some value }
        let withVersion (value: bool) (req: FleetSearchRequest) =
            { req with Version = Some value }
        let withSource (value: Types.SourceConfigParam) (req: FleetSearchRequest) =
            { req with Source = Some value }
        let withSourceExcludes (value: Types.Fields) (req: FleetSearchRequest) =
            { req with SourceExcludes = Some value }
        let withSourceIncludes (value: Types.Fields) (req: FleetSearchRequest) =
            { req with SourceIncludes = Some value }
        let withSeqNoPrimaryTerm (value: bool) (req: FleetSearchRequest) =
            { req with SeqNoPrimaryTerm = Some value }
        let withQ (value: string) (req: FleetSearchRequest) =
            { req with Q = Some value }
        let withSize (value: Types.Integer) (req: FleetSearchRequest) =
            { req with Size = Some value }
        let withFrom (value: Types.Integer) (req: FleetSearchRequest) =
            { req with From = Some value }
        let withSort (value: string list) (req: FleetSearchRequest) =
            { req with Sort = Some value }
        let withWaitForCheckpoints (value: Types.Checkpoint list) (req: FleetSearchRequest) =
            { req with WaitForCheckpoints = Some value }
        let withAllowPartialSearchResults (value: bool) (req: FleetSearchRequest) =
            { req with AllowPartialSearchResults = Some value }
        let withAggregations (value: Map<string, Types.AggregationContainer>) (req: FleetSearchRequest) =
            { req with Aggregations = Some value }
        let withCollapse (value: Types.FieldCollapse) (req: FleetSearchRequest) =
            { req with Collapse = Some value }
        let withBodyExplain (value: bool) (req: FleetSearchRequest) =
            { req with bodyExplain = Some value }
        let withExt (value: Map<string, System.Text.Json.JsonElement>) (req: FleetSearchRequest) =
            { req with Ext = Some value }
        let withBodyFrom (value: Types.Integer) (req: FleetSearchRequest) =
            { req with bodyFrom = Some value }
        let withHighlight (value: Types.Highlight) (req: FleetSearchRequest) =
            { req with Highlight = Some value }
        let withBodyTrackTotalHits (value: Types.TrackHits) (req: FleetSearchRequest) =
            { req with bodyTrackTotalHits = Some value }
        let withIndicesBoost (value: Map<Types.IndexName, Types.Double> list) (req: FleetSearchRequest) =
            { req with IndicesBoost = Some value }
        let withBodyDocvalueFields (value: Types.FieldAndFormat list) (req: FleetSearchRequest) =
            { req with bodyDocvalueFields = Some value }
        let withMinScore (value: Types.Double) (req: FleetSearchRequest) =
            { req with MinScore = Some value }
        let withPostFilter (value: Types.QueryContainer) (req: FleetSearchRequest) =
            { req with PostFilter = Some value }
        let withProfile (value: bool) (req: FleetSearchRequest) =
            { req with Profile = Some value }
        let withQuery (value: Types.QueryContainer) (req: FleetSearchRequest) =
            { req with Query = Some value }
        let withRescore (value: Types.Rescore list) (req: FleetSearchRequest) =
            { req with Rescore = Some value }
        let withScriptFields (value: Map<string, Types.ScriptField>) (req: FleetSearchRequest) =
            { req with ScriptFields = Some value }
        let withSearchAfter (value: Types.SortResults) (req: FleetSearchRequest) =
            { req with SearchAfter = Some value }
        let withBodySize (value: Types.Integer) (req: FleetSearchRequest) =
            { req with bodySize = Some value }
        let withSlice (value: Types.SlicedScroll) (req: FleetSearchRequest) =
            { req with Slice = Some value }
        let withBodySort (value: Types.Sort) (req: FleetSearchRequest) =
            { req with bodySort = Some value }
        let withBodySource (value: Types.SourceConfig) (req: FleetSearchRequest) =
            { req with bodySource = Some value }
        let withFields (value: Types.FieldAndFormat list) (req: FleetSearchRequest) =
            { req with Fields = Some value }
        let withSuggest (value: Types.Suggester) (req: FleetSearchRequest) =
            { req with Suggest = Some value }
        let withBodyTerminateAfter (value: Types.Long) (req: FleetSearchRequest) =
            { req with bodyTerminateAfter = Some value }
        let withBodyTimeout (value: string) (req: FleetSearchRequest) =
            { req with bodyTimeout = Some value }
        let withBodyTrackScores (value: bool) (req: FleetSearchRequest) =
            { req with bodyTrackScores = Some value }
        let withBodyVersion (value: bool) (req: FleetSearchRequest) =
            { req with bodyVersion = Some value }
        let withBodySeqNoPrimaryTerm (value: bool) (req: FleetSearchRequest) =
            { req with bodySeqNoPrimaryTerm = Some value }
        let withBodyStoredFields (value: Types.Fields) (req: FleetSearchRequest) =
            { req with bodyStoredFields = Some value }
        let withPit (value: Types.PointInTimeReference) (req: FleetSearchRequest) =
            { req with Pit = Some value }
        let withRuntimeMappings (value: Types.RuntimeFields) (req: FleetSearchRequest) =
            { req with RuntimeMappings = Some value }
        let withBodyStats (value: string list) (req: FleetSearchRequest) =
            { req with bodyStats = Some value }


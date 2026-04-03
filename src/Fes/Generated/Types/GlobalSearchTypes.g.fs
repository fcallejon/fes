// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalSearchTypes =

    type AggregationBreakdown = {
        [<System.Text.Json.Serialization.JsonPropertyName("build_aggregation")>]
        BuildAggregation: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("build_aggregation_count")>]
        BuildAggregationCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("build_leaf_collector")>]
        BuildLeafCollector: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("build_leaf_collector_count")>]
        BuildLeafCollectorCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("collect")>]
        Collect: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("collect_count")>]
        CollectCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("initialize")>]
        Initialize: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("initialize_count")>]
        InitializeCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("post_collection")>]
        PostCollection: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("post_collection_count")>]
        PostCollectionCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("reduce")>]
        Reduce: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("reduce_count")>]
        ReduceCount: Types.Long
    }

    type AggregationProfileDelegateDebugFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("results_from_metadata")>]
        ResultsFromMetadata: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string option
        [<System.Text.Json.Serialization.JsonPropertyName("specialized_for")>]
        SpecializedFor: string option
        [<System.Text.Json.Serialization.JsonPropertyName("segments_counted_in_constant_time")>]
        SegmentsCountedInConstantTime: Types.Integer option
    }

    type AggregationProfileDebug = {
        [<System.Text.Json.Serialization.JsonPropertyName("segments_with_multi_valued_ords")>]
        SegmentsWithMultiValuedOrds: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("collection_strategy")>]
        CollectionStrategy: string option
        [<System.Text.Json.Serialization.JsonPropertyName("segments_with_single_valued_ords")>]
        SegmentsWithSingleValuedOrds: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("total_buckets")>]
        TotalBuckets: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("built_buckets")>]
        BuiltBuckets: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("result_strategy")>]
        ResultStrategy: string option
        [<System.Text.Json.Serialization.JsonPropertyName("has_filter")>]
        HasFilter: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("delegate")>]
        Delegate: string option
        [<System.Text.Json.Serialization.JsonPropertyName("delegate_debug")>]
        DelegateDebug: GlobalSearchTypes.AggregationProfileDebug option
        [<System.Text.Json.Serialization.JsonPropertyName("chars_fetched")>]
        CharsFetched: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("extract_count")>]
        ExtractCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("extract_ns")>]
        ExtractNs: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("values_fetched")>]
        ValuesFetched: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("collect_analyzed_ns")>]
        CollectAnalyzedNs: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("collect_analyzed_count")>]
        CollectAnalyzedCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("surviving_buckets")>]
        SurvivingBuckets: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("ordinals_collectors_used")>]
        OrdinalsCollectorsUsed: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("ordinals_collectors_overhead_too_high")>]
        OrdinalsCollectorsOverheadTooHigh: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("string_hashing_collectors_used")>]
        StringHashingCollectorsUsed: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("numeric_collectors_used")>]
        NumericCollectorsUsed: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("empty_collectors_used")>]
        EmptyCollectorsUsed: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("deferred_aggregators")>]
        DeferredAggregators: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("segments_with_doc_count_field")>]
        SegmentsWithDocCountField: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("segments_with_deleted_docs")>]
        SegmentsWithDeletedDocs: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("filters")>]
        Filters: GlobalSearchTypes.AggregationProfileDelegateDebugFilter list option
        [<System.Text.Json.Serialization.JsonPropertyName("segments_counted")>]
        SegmentsCounted: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("segments_collected")>]
        SegmentsCollected: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("map_reducer")>]
        MapReducer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("brute_force_used")>]
        BruteForceUsed: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("dynamic_pruning_attempted")>]
        DynamicPruningAttempted: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("dynamic_pruning_used")>]
        DynamicPruningUsed: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("skipped_due_to_no_data")>]
        SkippedDueToNoData: Types.Integer option
    }

    type AggregationProfile = {
        [<System.Text.Json.Serialization.JsonPropertyName("breakdown")>]
        Breakdown: GlobalSearchTypes.AggregationBreakdown
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_nanos")>]
        TimeInNanos: Types.DurationValue<Types.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("debug")>]
        Debug: GlobalSearchTypes.AggregationProfileDebug option
        [<System.Text.Json.Serialization.JsonPropertyName("children")>]
        Children: GlobalSearchTypes.AggregationProfile list option
    }

    [<RequireQualifiedAccess>]
    type BoundaryScanner =
        | Chars
        | Sentence
        | Word

    type Collector = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_nanos")>]
        TimeInNanos: Types.DurationValue<Types.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("children")>]
        Children: GlobalSearchTypes.Collector list option
    }

    /// Text or location that we want similar documents for or a lookup to a document's field for the text.
    [<RequireQualifiedAccess>]
    type Context =
        | String of string
        | GeoLocation of Types.GeoLocation

    type CompletionContext = {
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("context")>]
        Context: GlobalSearchTypes.Context
        [<System.Text.Json.Serialization.JsonPropertyName("neighbours")>]
        Neighbours: Types.GeoHashPrecision list option
        [<System.Text.Json.Serialization.JsonPropertyName("precision")>]
        Precision: Types.GeoHashPrecision option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix")>]
        Prefix: bool option
    }

    type CompletionSuggestOption<'tDocument> = {
        [<System.Text.Json.Serialization.JsonPropertyName("collate_match")>]
        CollateMatch: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("contexts")>]
        Contexts: Map<string, GlobalSearchTypes.Context list> option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: string option
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: Types.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("_routing")>]
        Routing: string option
        [<System.Text.Json.Serialization.JsonPropertyName("_score")>]
        Score: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: 'tDocument option
        [<System.Text.Json.Serialization.JsonPropertyName("text")>]
        Text: string
        [<System.Text.Json.Serialization.JsonPropertyName("score")>]
        Score: Types.Double option
    }

    type SuggestBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("length")>]
        Length: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("offset")>]
        Offset: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("text")>]
        Text: string
    }

    type CompletionSuggest<'tDocument> = {
        [<System.Text.Json.Serialization.JsonPropertyName("options")>]
        Options: System.Text.Json.JsonElement
    }

    type SuggestFuzziness = {
        [<System.Text.Json.Serialization.JsonPropertyName("fuzziness")>]
        Fuzziness: Types.Fuzziness option
        [<System.Text.Json.Serialization.JsonPropertyName("min_length")>]
        MinLength: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix_length")>]
        PrefixLength: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("transpositions")>]
        Transpositions: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("unicode_aware")>]
        UnicodeAware: bool option
    }

    type RegexOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("flags")>]
        Flags: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("max_determinized_states")>]
        MaxDeterminizedStates: Types.Integer option
    }

    type SuggesterBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
    }

    type CompletionSuggester = {
        [<System.Text.Json.Serialization.JsonPropertyName("contexts")>]
        Contexts: Map<Types.Field, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy")>]
        Fuzzy: GlobalSearchTypes.SuggestFuzziness option
        [<System.Text.Json.Serialization.JsonPropertyName("regex")>]
        Regex: GlobalSearchTypes.RegexOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("skip_duplicates")>]
        SkipDuplicates: bool option
    }

    type KnnQueryProfileBreakdown = {
        [<System.Text.Json.Serialization.JsonPropertyName("advance")>]
        Advance: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("advance_count")>]
        AdvanceCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("build_scorer")>]
        BuildScorer: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("build_scorer_count")>]
        BuildScorerCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("compute_max_score")>]
        ComputeMaxScore: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("compute_max_score_count")>]
        ComputeMaxScoreCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("count_weight")>]
        CountWeight: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("count_weight_count")>]
        CountWeightCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("create_weight")>]
        CreateWeight: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("create_weight_count")>]
        CreateWeightCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("match")>]
        Match: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("match_count")>]
        MatchCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("next_doc")>]
        NextDoc: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("next_doc_count")>]
        NextDocCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("score")>]
        Score: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("score_count")>]
        ScoreCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("set_min_competitive_score")>]
        SetMinCompetitiveScore: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("set_min_competitive_score_count")>]
        SetMinCompetitiveScoreCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("shallow_advance")>]
        ShallowAdvance: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("shallow_advance_count")>]
        ShallowAdvanceCount: Types.Long
    }

    type KnnQueryProfileResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string
        [<System.Text.Json.Serialization.JsonPropertyName("time")>]
        Time: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_nanos")>]
        TimeInNanos: Types.DurationValue<Types.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("breakdown")>]
        Breakdown: GlobalSearchTypes.KnnQueryProfileBreakdown
        [<System.Text.Json.Serialization.JsonPropertyName("debug")>]
        Debug: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("children")>]
        Children: GlobalSearchTypes.KnnQueryProfileResult list option
    }

    type KnnCollectorResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string
        [<System.Text.Json.Serialization.JsonPropertyName("time")>]
        Time: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_nanos")>]
        TimeInNanos: Types.DurationValue<Types.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("children")>]
        Children: GlobalSearchTypes.KnnCollectorResult list option
    }

    type DfsKnnProfile = {
        [<System.Text.Json.Serialization.JsonPropertyName("vector_operations_count")>]
        VectorOperationsCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: GlobalSearchTypes.KnnQueryProfileResult list
        [<System.Text.Json.Serialization.JsonPropertyName("rewrite_time")>]
        RewriteTime: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("collector")>]
        Collector: GlobalSearchTypes.KnnCollectorResult list
    }

    type DfsStatisticsBreakdown = {
        [<System.Text.Json.Serialization.JsonPropertyName("collection_statistics")>]
        CollectionStatistics: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("collection_statistics_count")>]
        CollectionStatisticsCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("create_weight")>]
        CreateWeight: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("create_weight_count")>]
        CreateWeightCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("rewrite")>]
        Rewrite: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("rewrite_count")>]
        RewriteCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("term_statistics")>]
        TermStatistics: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("term_statistics_count")>]
        TermStatisticsCount: Types.Long
    }

    type DfsStatisticsProfile = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string
        [<System.Text.Json.Serialization.JsonPropertyName("time")>]
        Time: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_nanos")>]
        TimeInNanos: Types.DurationValue<Types.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("breakdown")>]
        Breakdown: GlobalSearchTypes.DfsStatisticsBreakdown
        [<System.Text.Json.Serialization.JsonPropertyName("debug")>]
        Debug: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("children")>]
        Children: GlobalSearchTypes.DfsStatisticsProfile list option
    }

    type DfsProfile = {
        [<System.Text.Json.Serialization.JsonPropertyName("statistics")>]
        Statistics: GlobalSearchTypes.DfsStatisticsProfile option
        [<System.Text.Json.Serialization.JsonPropertyName("knn")>]
        Knn: GlobalSearchTypes.DfsKnnProfile list option
    }

    type DirectGenerator = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("max_edits")>]
        MaxEdits: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_inspections")>]
        MaxInspections: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("max_term_freq")>]
        MaxTermFreq: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_freq")>]
        MinDocFreq: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("min_word_length")>]
        MinWordLength: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("post_filter")>]
        PostFilter: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pre_filter")>]
        PreFilter: string option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix_length")>]
        PrefixLength: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("suggest_mode")>]
        SuggestMode: Types.SuggestMode option
    }

    type FetchProfileBreakdown = {
        [<System.Text.Json.Serialization.JsonPropertyName("load_source")>]
        LoadSource: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("load_source_count")>]
        LoadSourceCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("load_stored_fields")>]
        LoadStoredFields: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("load_stored_fields_count")>]
        LoadStoredFieldsCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("next_reader")>]
        NextReader: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("next_reader_count")>]
        NextReaderCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("process_count")>]
        ProcessCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("process")>]
        Process: Types.Integer option
    }

    type FetchProfileDebug = {
        [<System.Text.Json.Serialization.JsonPropertyName("stored_fields")>]
        StoredFields: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("fast_path")>]
        FastPath: Types.Integer option
    }

    type FetchProfile = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_nanos")>]
        TimeInNanos: Types.DurationValue<Types.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("breakdown")>]
        Breakdown: GlobalSearchTypes.FetchProfileBreakdown
        [<System.Text.Json.Serialization.JsonPropertyName("debug")>]
        Debug: GlobalSearchTypes.FetchProfileDebug option
        [<System.Text.Json.Serialization.JsonPropertyName("children")>]
        Children: GlobalSearchTypes.FetchProfile list option
    }

    [<RequireQualifiedAccess>]
    type HighlighterEncoder =
        | Default
        | Html

    [<RequireQualifiedAccess>]
    type HighlighterType =
        | Plain
        | Fvh
        | Unified
        | Custom of string

    [<RequireQualifiedAccess>]
    type HighlighterFragmenter =
        | Simple
        | Span

    [<RequireQualifiedAccess>]
    type HighlighterOrder =
        | Score

    [<RequireQualifiedAccess>]
    type HighlighterTagsSchema =
        | Styled

    type HighlightBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: GlobalSearchTypes.HighlighterType option
        [<System.Text.Json.Serialization.JsonPropertyName("boundary_chars")>]
        BoundaryChars: string option
        [<System.Text.Json.Serialization.JsonPropertyName("boundary_max_scan")>]
        BoundaryMaxScan: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("boundary_scanner")>]
        BoundaryScanner: GlobalSearchTypes.BoundaryScanner option
        [<System.Text.Json.Serialization.JsonPropertyName("boundary_scanner_locale")>]
        BoundaryScannerLocale: string option
        [<System.Text.Json.Serialization.JsonPropertyName("force_source")>]
        ForceSource: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("fragmenter")>]
        Fragmenter: GlobalSearchTypes.HighlighterFragmenter option
        [<System.Text.Json.Serialization.JsonPropertyName("fragment_size")>]
        FragmentSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("highlight_filter")>]
        HighlightFilter: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("highlight_query")>]
        HighlightQuery: TypesQueryDsl.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_fragment_length")>]
        MaxFragmentLength: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_analyzed_offset")>]
        MaxAnalyzedOffset: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("no_match_size")>]
        NoMatchSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_fragments")>]
        NumberOfFragments: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("options")>]
        Options: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: GlobalSearchTypes.HighlighterOrder option
        [<System.Text.Json.Serialization.JsonPropertyName("phrase_limit")>]
        PhraseLimit: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("post_tags")>]
        PostTags: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("pre_tags")>]
        PreTags: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("require_field_match")>]
        RequireFieldMatch: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("tags_schema")>]
        TagsSchema: GlobalSearchTypes.HighlighterTagsSchema option
    }

    type HighlightField = {
        [<System.Text.Json.Serialization.JsonPropertyName("fragment_offset")>]
        FragmentOffset: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("matched_fields")>]
        MatchedFields: Types.Fields option
    }

    type Highlight = {
        [<System.Text.Json.Serialization.JsonPropertyName("encoder")>]
        Encoder: GlobalSearchTypes.HighlighterEncoder option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: System.Text.Json.JsonElement
    }

    type SourceFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("exclude_vectors")>]
        ExcludeVectors: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("excludes")>]
        Excludes: Types.Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("includes")>]
        Includes: Types.Fields option
    }

    /// Defines how to fetch a source. Fetching can be disabled entirely, or the source can be filtered.
    [<RequireQualifiedAccess>]
    type SourceConfig =
        | Boolean of bool
        | SourceFilter of GlobalSearchTypes.SourceFilter

    type FieldCollapse = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("inner_hits")>]
        InnerHits: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("max_concurrent_group_searches")>]
        MaxConcurrentGroupSearches: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("collapse")>]
        Collapse: GlobalSearchTypes.FieldCollapse option
    }

    and InnerHits = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        From: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("collapse")>]
        Collapse: GlobalSearchTypes.FieldCollapse option
        [<System.Text.Json.Serialization.JsonPropertyName("docvalue_fields")>]
        DocvalueFields: TypesQueryDsl.FieldAndFormat list option
        [<System.Text.Json.Serialization.JsonPropertyName("explain")>]
        Explain: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("highlight")>]
        Highlight: GlobalSearchTypes.Highlight option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unmapped")>]
        IgnoreUnmapped: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("script_fields")>]
        ScriptFields: Map<Types.Field, Types.ScriptField> option
        [<System.Text.Json.Serialization.JsonPropertyName("seq_no_primary_term")>]
        SeqNoPrimaryTerm: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Types.Field list option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: Types.Sort option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: GlobalSearchTypes.SourceConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("stored_fields")>]
        StoredFields: Types.Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("track_scores")>]
        TrackScores: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: bool option
    }

    type PhraseSuggestCollateQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: Types.ScriptSource option
    }

    type PhraseSuggestCollate = {
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("prune")>]
        Prune: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: GlobalSearchTypes.PhraseSuggestCollateQuery
    }

    type PhraseSuggestHighlight = {
        [<System.Text.Json.Serialization.JsonPropertyName("post_tag")>]
        PostTag: string
        [<System.Text.Json.Serialization.JsonPropertyName("pre_tag")>]
        PreTag: string
    }

    type LaplaceSmoothingModel = {
        [<System.Text.Json.Serialization.JsonPropertyName("alpha")>]
        Alpha: Types.Double
    }

    type LinearInterpolationSmoothingModel = {
        [<System.Text.Json.Serialization.JsonPropertyName("bigram_lambda")>]
        BigramLambda: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("trigram_lambda")>]
        TrigramLambda: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("unigram_lambda")>]
        UnigramLambda: Types.Double
    }

    type StupidBackoffSmoothingModel = {
        [<System.Text.Json.Serialization.JsonPropertyName("discount")>]
        Discount: Types.Double
    }

    [<RequireQualifiedAccess>]
    type SmoothingModelContainer =
        | Laplace of GlobalSearchTypes.LaplaceSmoothingModel
        | LinearInterpolation of GlobalSearchTypes.LinearInterpolationSmoothingModel
        | StupidBackoff of GlobalSearchTypes.StupidBackoffSmoothingModel

    type PhraseSuggester = {
        [<System.Text.Json.Serialization.JsonPropertyName("collate")>]
        Collate: GlobalSearchTypes.PhraseSuggestCollate option
        [<System.Text.Json.Serialization.JsonPropertyName("confidence")>]
        Confidence: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("direct_generator")>]
        DirectGenerator: GlobalSearchTypes.DirectGenerator list option
        [<System.Text.Json.Serialization.JsonPropertyName("force_unigrams")>]
        ForceUnigrams: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("gram_size")>]
        GramSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("highlight")>]
        Highlight: GlobalSearchTypes.PhraseSuggestHighlight option
        [<System.Text.Json.Serialization.JsonPropertyName("max_errors")>]
        MaxErrors: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("real_word_error_likelihood")>]
        RealWordErrorLikelihood: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("separator")>]
        Separator: string option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("smoothing")>]
        Smoothing: GlobalSearchTypes.SmoothingModelContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("token_limit")>]
        TokenLimit: Types.Integer option
    }

    [<RequireQualifiedAccess>]
    type SuggestSort =
        | Score
        | Frequency

    [<RequireQualifiedAccess>]
    type StringDistance =
        | Internal
        | DamerauLevenshtein
        | Levenshtein
        | JaroWinkler
        | Ngram

    type TermSuggester = {
        [<System.Text.Json.Serialization.JsonPropertyName("lowercase_terms")>]
        LowercaseTerms: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("max_edits")>]
        MaxEdits: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_inspections")>]
        MaxInspections: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_term_freq")>]
        MaxTermFreq: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_freq")>]
        MinDocFreq: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("min_word_length")>]
        MinWordLength: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix_length")>]
        PrefixLength: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: GlobalSearchTypes.SuggestSort option
        [<System.Text.Json.Serialization.JsonPropertyName("string_distance")>]
        StringDistance: GlobalSearchTypes.StringDistance option
        [<System.Text.Json.Serialization.JsonPropertyName("suggest_mode")>]
        SuggestMode: Types.SuggestMode option
    }

    [<RequireQualifiedAccess>]
    type FieldSuggester =
        | Completion of GlobalSearchTypes.CompletionSuggester
        | Phrase of GlobalSearchTypes.PhraseSuggester
        | Term of GlobalSearchTypes.TermSuggester
        | Unknown of name: string * System.Text.Json.JsonElement

    and FieldSuggesterMeta = {
        [<System.Text.Json.Serialization.JsonPropertyName("prefix")>]
        Prefix: string option
        [<System.Text.Json.Serialization.JsonPropertyName("regex")>]
        Regex: string option
        [<System.Text.Json.Serialization.JsonPropertyName("text")>]
        Text: string option
    }

    [<RequireQualifiedAccess>]
    type TotalHitsRelation =
        | Eq
        | Gte

    type TotalHits = {
        [<System.Text.Json.Serialization.JsonPropertyName("relation")>]
        Relation: GlobalSearchTypes.TotalHitsRelation
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: Types.Long
    }

    type NestedIdentity = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("offset")>]
        Offset: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("_nested")>]
        Nested: GlobalSearchTypes.NestedIdentity option
    }

    type Hit<'tDocument> = {
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("_score")>]
        Score: Types.Double option option
        [<System.Text.Json.Serialization.JsonPropertyName("_explanation")>]
        Explanation: GlobalExplain.Explanation option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("highlight")>]
        Highlight: Map<string, string list> option
        [<System.Text.Json.Serialization.JsonPropertyName("inner_hits")>]
        InnerHits: Map<string, GlobalSearchTypes.InnerHitsResult> option
        [<System.Text.Json.Serialization.JsonPropertyName("matched_queries")>]
        MatchedQueries: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("_nested")>]
        Nested: GlobalSearchTypes.NestedIdentity option
        [<System.Text.Json.Serialization.JsonPropertyName("_ignored")>]
        Ignored: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("ignored_field_values")>]
        IgnoredFieldValues: Map<string, System.Text.Json.JsonElement list> option
        [<System.Text.Json.Serialization.JsonPropertyName("_shard")>]
        Shard: string option
        [<System.Text.Json.Serialization.JsonPropertyName("_node")>]
        Node: string option
        [<System.Text.Json.Serialization.JsonPropertyName("_routing")>]
        Routing: string option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: 'tDocument option
        [<System.Text.Json.Serialization.JsonPropertyName("_rank")>]
        Rank: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("_seq_no")>]
        SeqNo: Types.SequenceNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("_primary_term")>]
        PrimaryTerm: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("_version")>]
        Version: Types.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: Types.SortResults option
    }

    and InnerHitsResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("hits")>]
        Hits: GlobalSearchTypes.HitsMetadata<System.Text.Json.JsonElement>
    }

    and HitsMetadata<'t> = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("hits")>]
        Hits: GlobalSearchTypes.Hit<'t> list
        [<System.Text.Json.Serialization.JsonPropertyName("max_score")>]
        MaxScore: Types.Double option option
    }

    type LearningToRank = {
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: string
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
    }

    type PhraseSuggestOption = {
        [<System.Text.Json.Serialization.JsonPropertyName("text")>]
        Text: string
        [<System.Text.Json.Serialization.JsonPropertyName("score")>]
        Score: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("highlighted")>]
        Highlighted: string option
        [<System.Text.Json.Serialization.JsonPropertyName("collate_match")>]
        CollateMatch: bool option
    }

    type PhraseSuggest = {
        [<System.Text.Json.Serialization.JsonPropertyName("options")>]
        Options: System.Text.Json.JsonElement
    }

    type PointInTimeReference = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("keep_alive")>]
        KeepAlive: Types.Duration option
    }

    type QueryBreakdown = {
        [<System.Text.Json.Serialization.JsonPropertyName("advance")>]
        Advance: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("advance_count")>]
        AdvanceCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("build_scorer")>]
        BuildScorer: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("build_scorer_count")>]
        BuildScorerCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("create_weight")>]
        CreateWeight: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("create_weight_count")>]
        CreateWeightCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("match")>]
        Match: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("match_count")>]
        MatchCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("shallow_advance")>]
        ShallowAdvance: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("shallow_advance_count")>]
        ShallowAdvanceCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("next_doc")>]
        NextDoc: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("next_doc_count")>]
        NextDocCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("score")>]
        Score: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("score_count")>]
        ScoreCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("compute_max_score")>]
        ComputeMaxScore: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("compute_max_score_count")>]
        ComputeMaxScoreCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("count_weight")>]
        CountWeight: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("count_weight_count")>]
        CountWeightCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("set_min_competitive_score")>]
        SetMinCompetitiveScore: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("set_min_competitive_score_count")>]
        SetMinCompetitiveScoreCount: Types.Long
    }

    type QueryProfile = {
        [<System.Text.Json.Serialization.JsonPropertyName("breakdown")>]
        Breakdown: GlobalSearchTypes.QueryBreakdown
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_nanos")>]
        TimeInNanos: Types.DurationValue<Types.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("children")>]
        Children: GlobalSearchTypes.QueryProfile list option
    }

    type SearchProfile = {
        [<System.Text.Json.Serialization.JsonPropertyName("collector")>]
        Collector: GlobalSearchTypes.Collector list
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: GlobalSearchTypes.QueryProfile list
        [<System.Text.Json.Serialization.JsonPropertyName("rewrite_time")>]
        RewriteTime: Types.Long
    }

    type ShardProfile = {
        [<System.Text.Json.Serialization.JsonPropertyName("aggregations")>]
        Aggregations: GlobalSearchTypes.AggregationProfile list
        [<System.Text.Json.Serialization.JsonPropertyName("cluster")>]
        Cluster: string
        [<System.Text.Json.Serialization.JsonPropertyName("dfs")>]
        Dfs: GlobalSearchTypes.DfsProfile option
        [<System.Text.Json.Serialization.JsonPropertyName("fetch")>]
        Fetch: GlobalSearchTypes.FetchProfile option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: string
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("node_id")>]
        NodeId: Types.NodeId
        [<System.Text.Json.Serialization.JsonPropertyName("searches")>]
        Searches: GlobalSearchTypes.SearchProfile list
        [<System.Text.Json.Serialization.JsonPropertyName("shard_id")>]
        ShardId: Types.Integer
    }

    type Profile = {
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: GlobalSearchTypes.ShardProfile list
    }

    [<RequireQualifiedAccess>]
    type ScoreMode =
        | Avg
        | Max
        | Min
        | Multiply
        | Total

    type RescoreQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("rescore_query")>]
        RescoreQuery: TypesQueryDsl.QueryContainer
        [<System.Text.Json.Serialization.JsonPropertyName("query_weight")>]
        QueryWeight: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("rescore_query_weight")>]
        RescoreQueryWeight: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("score_mode")>]
        ScoreMode: GlobalSearchTypes.ScoreMode option
    }

    type ScriptRescore = {
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script
    }

    [<RequireQualifiedAccess>]
    type Rescore =
        | Query of GlobalSearchTypes.RescoreQuery
        | LearningToRank of GlobalSearchTypes.LearningToRank
        | Script of GlobalSearchTypes.ScriptRescore
        | Unknown of name: string * System.Text.Json.JsonElement

    and RescoreMeta = {
        [<System.Text.Json.Serialization.JsonPropertyName("window_size")>]
        WindowSize: Types.Integer option
    }

    /// Number of hits matching the query to count accurately. If true, the exact
number of hits is returned at the cost of some performance. If false, the
response does not include the total number of hits m...
    [<RequireQualifiedAccess>]
    type TrackHits =
        | Boolean of bool
        | Integer of Types.Integer

    type Suggester = {
        [<System.Text.Json.Serialization.JsonPropertyName("text")>]
        Text: string option
    }

    type SearchRequestBody = {
        [<System.Text.Json.Serialization.JsonPropertyName("aggregations")>]
        Aggregations: Map<string, TypesAggregations.AggregationContainer> option
        [<System.Text.Json.Serialization.JsonPropertyName("collapse")>]
        Collapse: GlobalSearchTypes.FieldCollapse option
        [<System.Text.Json.Serialization.JsonPropertyName("explain")>]
        Explain: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ext")>]
        Ext: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        From: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("highlight")>]
        Highlight: GlobalSearchTypes.Highlight option
        [<System.Text.Json.Serialization.JsonPropertyName("track_total_hits")>]
        TrackTotalHits: GlobalSearchTypes.TrackHits option
        [<System.Text.Json.Serialization.JsonPropertyName("indices_boost")>]
        IndicesBoost: Map<Types.IndexName, Types.Double> list option
        [<System.Text.Json.Serialization.JsonPropertyName("docvalue_fields")>]
        DocvalueFields: TypesQueryDsl.FieldAndFormat list option
        [<System.Text.Json.Serialization.JsonPropertyName("knn")>]
        Knn: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("rank")>]
        Rank: Types.RankContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_score")>]
        MinScore: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("post_filter")>]
        PostFilter: TypesQueryDsl.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("profile")>]
        Profile: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: TypesQueryDsl.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("rescore")>]
        Rescore: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("retriever")>]
        Retriever: Types.RetrieverContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("script_fields")>]
        ScriptFields: Map<string, Types.ScriptField> option
        [<System.Text.Json.Serialization.JsonPropertyName("search_after")>]
        SearchAfter: Types.SortResults option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("slice")>]
        Slice: Types.SlicedScroll option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: Types.Sort option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: GlobalSearchTypes.SourceConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: TypesQueryDsl.FieldAndFormat list option
        [<System.Text.Json.Serialization.JsonPropertyName("suggest")>]
        Suggest: GlobalSearchTypes.Suggester option
        [<System.Text.Json.Serialization.JsonPropertyName("terminate_after")>]
        TerminateAfter: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("timeout")>]
        Timeout: string option
        [<System.Text.Json.Serialization.JsonPropertyName("track_scores")>]
        TrackScores: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("seq_no_primary_term")>]
        SeqNoPrimaryTerm: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("stored_fields")>]
        StoredFields: Types.Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("pit")>]
        Pit: GlobalSearchTypes.PointInTimeReference option
        [<System.Text.Json.Serialization.JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: TypesMapping.RuntimeFields option
        [<System.Text.Json.Serialization.JsonPropertyName("stats")>]
        Stats: string list option
    }

    /// Defines how to fetch a source. Fetching can be disabled entirely, or the source can be filtered.
Used as a query parameter along with the `_source_includes` and `_source_excludes` parameters.
    [<RequireQualifiedAccess>]
    type SourceConfigParam =
        | Boolean of bool
        | Fields of Types.Fields

    type TermSuggestOption = {
        [<System.Text.Json.Serialization.JsonPropertyName("text")>]
        Text: string
        [<System.Text.Json.Serialization.JsonPropertyName("score")>]
        Score: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("freq")>]
        Freq: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("highlighted")>]
        Highlighted: string option
        [<System.Text.Json.Serialization.JsonPropertyName("collate_match")>]
        CollateMatch: bool option
    }

    type TermSuggest = {
        [<System.Text.Json.Serialization.JsonPropertyName("options")>]
        Options: System.Text.Json.JsonElement
    }

    [<RequireQualifiedAccess>]
    type Suggest<'tDocument> =
        | CompletionSuggest of GlobalSearchTypes.CompletionSuggest<'tDocument>
        | PhraseSuggest of GlobalSearchTypes.PhraseSuggest
        | TermSuggest of GlobalSearchTypes.TermSuggest


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalSearchTypes =

    type AggregationBreakdown = {
        [<System.Text.Json.Serialization.JsonPropertyName("build_aggregation")>]
        BuildAggregation: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("build_aggregation_count")>]
        BuildAggregationCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("build_leaf_collector")>]
        BuildLeafCollector: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("build_leaf_collector_count")>]
        BuildLeafCollectorCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("collect")>]
        Collect: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("collect_count")>]
        CollectCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("initialize")>]
        Initialize: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("initialize_count")>]
        InitializeCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("post_collection")>]
        PostCollection: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("post_collection_count")>]
        PostCollectionCount: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("reduce")>]
        Reduce: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("reduce_count")>]
        ReduceCount: CoreTypes.Long
    }

    type AggregationProfileDelegateDebugFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("results_from_metadata")>]
        ResultsFromMetadata: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string option
        [<System.Text.Json.Serialization.JsonPropertyName("specialized_for")>]
        SpecializedFor: string option
        [<System.Text.Json.Serialization.JsonPropertyName("segments_counted_in_constant_time")>]
        SegmentsCountedInConstantTime: CoreTypes.Integer option
    }

    type AggregationProfileDebug = {
        [<System.Text.Json.Serialization.JsonPropertyName("segments_with_multi_valued_ords")>]
        SegmentsWithMultiValuedOrds: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("collection_strategy")>]
        CollectionStrategy: string option
        [<System.Text.Json.Serialization.JsonPropertyName("segments_with_single_valued_ords")>]
        SegmentsWithSingleValuedOrds: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("total_buckets")>]
        TotalBuckets: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("built_buckets")>]
        BuiltBuckets: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("result_strategy")>]
        ResultStrategy: string option
        [<System.Text.Json.Serialization.JsonPropertyName("has_filter")>]
        HasFilter: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("delegate")>]
        Delegate: string option
        [<System.Text.Json.Serialization.JsonPropertyName("delegate_debug")>]
        DelegateDebug: AggregationProfileDebug option
        [<System.Text.Json.Serialization.JsonPropertyName("chars_fetched")>]
        CharsFetched: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("extract_count")>]
        ExtractCount: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("extract_ns")>]
        ExtractNs: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("values_fetched")>]
        ValuesFetched: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("collect_analyzed_ns")>]
        CollectAnalyzedNs: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("collect_analyzed_count")>]
        CollectAnalyzedCount: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("surviving_buckets")>]
        SurvivingBuckets: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("ordinals_collectors_used")>]
        OrdinalsCollectorsUsed: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("ordinals_collectors_overhead_too_high")>]
        OrdinalsCollectorsOverheadTooHigh: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("string_hashing_collectors_used")>]
        StringHashingCollectorsUsed: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("numeric_collectors_used")>]
        NumericCollectorsUsed: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("empty_collectors_used")>]
        EmptyCollectorsUsed: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("deferred_aggregators")>]
        DeferredAggregators: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("segments_with_doc_count_field")>]
        SegmentsWithDocCountField: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("segments_with_deleted_docs")>]
        SegmentsWithDeletedDocs: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("filters")>]
        Filters: AggregationProfileDelegateDebugFilter list option
        [<System.Text.Json.Serialization.JsonPropertyName("segments_counted")>]
        SegmentsCounted: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("segments_collected")>]
        SegmentsCollected: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("map_reducer")>]
        MapReducer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("brute_force_used")>]
        BruteForceUsed: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("dynamic_pruning_attempted")>]
        DynamicPruningAttempted: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("dynamic_pruning_used")>]
        DynamicPruningUsed: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("skipped_due_to_no_data")>]
        SkippedDueToNoData: CoreTypes.Integer option
    }

    type AggregationProfile = {
        [<System.Text.Json.Serialization.JsonPropertyName("breakdown")>]
        Breakdown: AggregationBreakdown
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_nanos")>]
        TimeInNanos: CoreTypes.DurationValue<CoreTypes.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("debug")>]
        Debug: AggregationProfileDebug option
        [<System.Text.Json.Serialization.JsonPropertyName("children")>]
        Children: AggregationProfile list option
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
        TimeInNanos: CoreTypes.DurationValue<CoreTypes.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("children")>]
        Children: Collector list option
    }

    /// Text or location that we want similar documents for or a lookup to a document's field for the text.
    [<RequireQualifiedAccess>]
    type Context =
        | String of string
        | GeoLocation of CoreTypes.GeoLocation

    type CompletionContext = {
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("context")>]
        Context: Context
        [<System.Text.Json.Serialization.JsonPropertyName("neighbours")>]
        Neighbours: CoreTypes.GeoHashPrecision list option
        [<System.Text.Json.Serialization.JsonPropertyName("precision")>]
        Precision: CoreTypes.GeoHashPrecision option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix")>]
        Prefix: bool option
    }

    type CompletionSuggestOption<'tDocument> = {
        [<System.Text.Json.Serialization.JsonPropertyName("collate_match")>]
        CollateMatch: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("contexts")>]
        Contexts: Map<string, Context list> option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: string option
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: CoreTypes.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("_routing")>]
        Routing: string option
        [<System.Text.Json.Serialization.JsonPropertyName("_score")>]
        Score: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: 'tDocument option
        [<System.Text.Json.Serialization.JsonPropertyName("text")>]
        Text: string
        [<System.Text.Json.Serialization.JsonPropertyName("score")>]
        Score: CoreTypes.Double option
    }

    type SuggestBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("length")>]
        Length: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("offset")>]
        Offset: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("text")>]
        Text: string
    }

    type CompletionSuggest<'tDocument> = {
        [<System.Text.Json.Serialization.JsonPropertyName("options")>]
        Options: System.Text.Json.JsonElement
    }

    type SuggestFuzziness = {
        [<System.Text.Json.Serialization.JsonPropertyName("fuzziness")>]
        Fuzziness: CoreTypes.Fuzziness option
        [<System.Text.Json.Serialization.JsonPropertyName("min_length")>]
        MinLength: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix_length")>]
        PrefixLength: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("transpositions")>]
        Transpositions: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("unicode_aware")>]
        UnicodeAware: bool option
    }

    type RegexOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("flags")>]
        Flags: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("max_determinized_states")>]
        MaxDeterminizedStates: CoreTypes.Integer option
    }

    type SuggesterBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: CoreTypes.Integer option
    }

    type CompletionSuggester = {
        [<System.Text.Json.Serialization.JsonPropertyName("contexts")>]
        Contexts: Map<CoreTypes.Field, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy")>]
        Fuzzy: SuggestFuzziness option
        [<System.Text.Json.Serialization.JsonPropertyName("regex")>]
        Regex: RegexOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("skip_duplicates")>]
        SkipDuplicates: bool option
    }

    type KnnQueryProfileBreakdown = {
        [<System.Text.Json.Serialization.JsonPropertyName("advance")>]
        Advance: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("advance_count")>]
        AdvanceCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("build_scorer")>]
        BuildScorer: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("build_scorer_count")>]
        BuildScorerCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("compute_max_score")>]
        ComputeMaxScore: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("compute_max_score_count")>]
        ComputeMaxScoreCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("count_weight")>]
        CountWeight: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("count_weight_count")>]
        CountWeightCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("create_weight")>]
        CreateWeight: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("create_weight_count")>]
        CreateWeightCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("match")>]
        Match: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("match_count")>]
        MatchCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("next_doc")>]
        NextDoc: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("next_doc_count")>]
        NextDocCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("score")>]
        Score: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("score_count")>]
        ScoreCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("set_min_competitive_score")>]
        SetMinCompetitiveScore: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("set_min_competitive_score_count")>]
        SetMinCompetitiveScoreCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("shallow_advance")>]
        ShallowAdvance: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("shallow_advance_count")>]
        ShallowAdvanceCount: CoreTypes.Long
    }

    type KnnQueryProfileResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string
        [<System.Text.Json.Serialization.JsonPropertyName("time")>]
        Time: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_nanos")>]
        TimeInNanos: CoreTypes.DurationValue<CoreTypes.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("breakdown")>]
        Breakdown: KnnQueryProfileBreakdown
        [<System.Text.Json.Serialization.JsonPropertyName("debug")>]
        Debug: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("children")>]
        Children: KnnQueryProfileResult list option
    }

    type KnnCollectorResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string
        [<System.Text.Json.Serialization.JsonPropertyName("time")>]
        Time: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_nanos")>]
        TimeInNanos: CoreTypes.DurationValue<CoreTypes.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("children")>]
        Children: KnnCollectorResult list option
    }

    type DfsKnnProfile = {
        [<System.Text.Json.Serialization.JsonPropertyName("vector_operations_count")>]
        VectorOperationsCount: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: KnnQueryProfileResult list
        [<System.Text.Json.Serialization.JsonPropertyName("rewrite_time")>]
        RewriteTime: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("collector")>]
        Collector: KnnCollectorResult list
    }

    type DfsStatisticsBreakdown = {
        [<System.Text.Json.Serialization.JsonPropertyName("collection_statistics")>]
        CollectionStatistics: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("collection_statistics_count")>]
        CollectionStatisticsCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("create_weight")>]
        CreateWeight: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("create_weight_count")>]
        CreateWeightCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("rewrite")>]
        Rewrite: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("rewrite_count")>]
        RewriteCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("term_statistics")>]
        TermStatistics: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("term_statistics_count")>]
        TermStatisticsCount: CoreTypes.Long
    }

    type DfsStatisticsProfile = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string
        [<System.Text.Json.Serialization.JsonPropertyName("time")>]
        Time: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_nanos")>]
        TimeInNanos: CoreTypes.DurationValue<CoreTypes.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("breakdown")>]
        Breakdown: DfsStatisticsBreakdown
        [<System.Text.Json.Serialization.JsonPropertyName("debug")>]
        Debug: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("children")>]
        Children: DfsStatisticsProfile list option
    }

    type DfsProfile = {
        [<System.Text.Json.Serialization.JsonPropertyName("statistics")>]
        Statistics: DfsStatisticsProfile option
        [<System.Text.Json.Serialization.JsonPropertyName("knn")>]
        Knn: DfsKnnProfile list option
    }

    type DirectGenerator = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("max_edits")>]
        MaxEdits: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_inspections")>]
        MaxInspections: CoreTypes.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("max_term_freq")>]
        MaxTermFreq: CoreTypes.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_freq")>]
        MinDocFreq: CoreTypes.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("min_word_length")>]
        MinWordLength: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("post_filter")>]
        PostFilter: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pre_filter")>]
        PreFilter: string option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix_length")>]
        PrefixLength: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("suggest_mode")>]
        SuggestMode: CoreTypes.SuggestMode option
    }

    type FetchProfileBreakdown = {
        [<System.Text.Json.Serialization.JsonPropertyName("load_source")>]
        LoadSource: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("load_source_count")>]
        LoadSourceCount: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("load_stored_fields")>]
        LoadStoredFields: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("load_stored_fields_count")>]
        LoadStoredFieldsCount: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("next_reader")>]
        NextReader: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("next_reader_count")>]
        NextReaderCount: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("process_count")>]
        ProcessCount: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("process")>]
        Process: CoreTypes.Integer option
    }

    type FetchProfileDebug = {
        [<System.Text.Json.Serialization.JsonPropertyName("stored_fields")>]
        StoredFields: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("fast_path")>]
        FastPath: CoreTypes.Integer option
    }

    type FetchProfile = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_nanos")>]
        TimeInNanos: CoreTypes.DurationValue<CoreTypes.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("breakdown")>]
        Breakdown: FetchProfileBreakdown
        [<System.Text.Json.Serialization.JsonPropertyName("debug")>]
        Debug: FetchProfileDebug option
        [<System.Text.Json.Serialization.JsonPropertyName("children")>]
        Children: FetchProfile list option
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
        Type: HighlighterType option
        [<System.Text.Json.Serialization.JsonPropertyName("boundary_chars")>]
        BoundaryChars: string option
        [<System.Text.Json.Serialization.JsonPropertyName("boundary_max_scan")>]
        BoundaryMaxScan: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("boundary_scanner")>]
        BoundaryScanner: BoundaryScanner option
        [<System.Text.Json.Serialization.JsonPropertyName("boundary_scanner_locale")>]
        BoundaryScannerLocale: string option
        [<System.Text.Json.Serialization.JsonPropertyName("force_source")>]
        ForceSource: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("fragmenter")>]
        Fragmenter: HighlighterFragmenter option
        [<System.Text.Json.Serialization.JsonPropertyName("fragment_size")>]
        FragmentSize: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("highlight_filter")>]
        HighlightFilter: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("highlight_query")>]
        HighlightQuery: CoreTypes.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_fragment_length")>]
        MaxFragmentLength: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_analyzed_offset")>]
        MaxAnalyzedOffset: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("no_match_size")>]
        NoMatchSize: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_fragments")>]
        NumberOfFragments: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("options")>]
        Options: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: HighlighterOrder option
        [<System.Text.Json.Serialization.JsonPropertyName("phrase_limit")>]
        PhraseLimit: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("post_tags")>]
        PostTags: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("pre_tags")>]
        PreTags: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("require_field_match")>]
        RequireFieldMatch: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("tags_schema")>]
        TagsSchema: HighlighterTagsSchema option
    }

    type HighlightField = {
        [<System.Text.Json.Serialization.JsonPropertyName("fragment_offset")>]
        FragmentOffset: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("matched_fields")>]
        MatchedFields: CoreTypes.Fields option
    }

    type Highlight = {
        [<System.Text.Json.Serialization.JsonPropertyName("encoder")>]
        Encoder: HighlighterEncoder option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: System.Text.Json.JsonElement
    }

    type SourceFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("exclude_vectors")>]
        ExcludeVectors: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("excludes")>]
        Excludes: CoreTypes.Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("includes")>]
        Includes: CoreTypes.Fields option
    }

    /// Defines how to fetch a source. Fetching can be disabled entirely, or the source can be filtered.
    [<RequireQualifiedAccess>]
    type SourceConfig =
        | Boolean of bool
        | SourceFilter of SourceFilter

    type FieldCollapse = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("inner_hits")>]
        InnerHits: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("max_concurrent_group_searches")>]
        MaxConcurrentGroupSearches: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("collapse")>]
        Collapse: FieldCollapse option
    }

    and InnerHits = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        From: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("collapse")>]
        Collapse: FieldCollapse option
        [<System.Text.Json.Serialization.JsonPropertyName("docvalue_fields")>]
        DocvalueFields: CoreTypes.FieldAndFormat list option
        [<System.Text.Json.Serialization.JsonPropertyName("explain")>]
        Explain: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("highlight")>]
        Highlight: Highlight option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unmapped")>]
        IgnoreUnmapped: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("script_fields")>]
        ScriptFields: Map<CoreTypes.Field, CoreTypes.ScriptField> option
        [<System.Text.Json.Serialization.JsonPropertyName("seq_no_primary_term")>]
        SeqNoPrimaryTerm: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: CoreTypes.Field list option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: CoreTypes.Sort option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: SourceConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("stored_fields")>]
        StoredFields: CoreTypes.Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("track_scores")>]
        TrackScores: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: bool option
    }

    type PhraseSuggestCollateQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: CoreTypes.ScriptSource option
    }

    type PhraseSuggestCollate = {
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("prune")>]
        Prune: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: PhraseSuggestCollateQuery
    }

    type PhraseSuggestHighlight = {
        [<System.Text.Json.Serialization.JsonPropertyName("post_tag")>]
        PostTag: string
        [<System.Text.Json.Serialization.JsonPropertyName("pre_tag")>]
        PreTag: string
    }

    type LaplaceSmoothingModel = {
        [<System.Text.Json.Serialization.JsonPropertyName("alpha")>]
        Alpha: CoreTypes.Double
    }

    type LinearInterpolationSmoothingModel = {
        [<System.Text.Json.Serialization.JsonPropertyName("bigram_lambda")>]
        BigramLambda: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("trigram_lambda")>]
        TrigramLambda: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("unigram_lambda")>]
        UnigramLambda: CoreTypes.Double
    }

    type StupidBackoffSmoothingModel = {
        [<System.Text.Json.Serialization.JsonPropertyName("discount")>]
        Discount: CoreTypes.Double
    }

    [<RequireQualifiedAccess>]
    type SmoothingModelContainer =
        | Laplace of LaplaceSmoothingModel
        | LinearInterpolation of LinearInterpolationSmoothingModel
        | StupidBackoff of StupidBackoffSmoothingModel

    type PhraseSuggester = {
        [<System.Text.Json.Serialization.JsonPropertyName("collate")>]
        Collate: PhraseSuggestCollate option
        [<System.Text.Json.Serialization.JsonPropertyName("confidence")>]
        Confidence: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("direct_generator")>]
        DirectGenerator: DirectGenerator list option
        [<System.Text.Json.Serialization.JsonPropertyName("force_unigrams")>]
        ForceUnigrams: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("gram_size")>]
        GramSize: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("highlight")>]
        Highlight: PhraseSuggestHighlight option
        [<System.Text.Json.Serialization.JsonPropertyName("max_errors")>]
        MaxErrors: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("real_word_error_likelihood")>]
        RealWordErrorLikelihood: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("separator")>]
        Separator: string option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("smoothing")>]
        Smoothing: SmoothingModelContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("token_limit")>]
        TokenLimit: CoreTypes.Integer option
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
        MaxEdits: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_inspections")>]
        MaxInspections: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_term_freq")>]
        MaxTermFreq: CoreTypes.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_freq")>]
        MinDocFreq: CoreTypes.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("min_word_length")>]
        MinWordLength: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix_length")>]
        PrefixLength: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: SuggestSort option
        [<System.Text.Json.Serialization.JsonPropertyName("string_distance")>]
        StringDistance: StringDistance option
        [<System.Text.Json.Serialization.JsonPropertyName("suggest_mode")>]
        SuggestMode: CoreTypes.SuggestMode option
    }

    [<RequireQualifiedAccess>]
    type FieldSuggester =
        | Completion of CompletionSuggester
        | Phrase of PhraseSuggester
        | Term of TermSuggester
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
        Relation: TotalHitsRelation
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: CoreTypes.Long
    }

    type NestedIdentity = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("offset")>]
        Offset: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("_nested")>]
        Nested: NestedIdentity option
    }

    type Hit<'tDocument> = {
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("_score")>]
        Score: CoreTypes.Double option option
        [<System.Text.Json.Serialization.JsonPropertyName("_explanation")>]
        Explanation: GlobalExplain.Explanation option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("highlight")>]
        Highlight: Map<string, string list> option
        [<System.Text.Json.Serialization.JsonPropertyName("inner_hits")>]
        InnerHits: Map<string, InnerHitsResult> option
        [<System.Text.Json.Serialization.JsonPropertyName("matched_queries")>]
        MatchedQueries: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("_nested")>]
        Nested: NestedIdentity option
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
        Rank: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("_seq_no")>]
        SeqNo: CoreTypes.SequenceNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("_primary_term")>]
        PrimaryTerm: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("_version")>]
        Version: CoreTypes.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: CoreTypes.SortResults option
    }

    and InnerHitsResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("hits")>]
        Hits: HitsMetadata<System.Text.Json.JsonElement>
    }

    and HitsMetadata<'t> = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("hits")>]
        Hits: Hit<'t> list
        [<System.Text.Json.Serialization.JsonPropertyName("max_score")>]
        MaxScore: CoreTypes.Double option option
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
        Score: CoreTypes.Double
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
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("keep_alive")>]
        KeepAlive: CoreTypes.Duration option
    }

    type QueryBreakdown = {
        [<System.Text.Json.Serialization.JsonPropertyName("advance")>]
        Advance: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("advance_count")>]
        AdvanceCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("build_scorer")>]
        BuildScorer: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("build_scorer_count")>]
        BuildScorerCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("create_weight")>]
        CreateWeight: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("create_weight_count")>]
        CreateWeightCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("match")>]
        Match: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("match_count")>]
        MatchCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("shallow_advance")>]
        ShallowAdvance: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("shallow_advance_count")>]
        ShallowAdvanceCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("next_doc")>]
        NextDoc: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("next_doc_count")>]
        NextDocCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("score")>]
        Score: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("score_count")>]
        ScoreCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("compute_max_score")>]
        ComputeMaxScore: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("compute_max_score_count")>]
        ComputeMaxScoreCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("count_weight")>]
        CountWeight: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("count_weight_count")>]
        CountWeightCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("set_min_competitive_score")>]
        SetMinCompetitiveScore: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("set_min_competitive_score_count")>]
        SetMinCompetitiveScoreCount: CoreTypes.Long
    }

    type QueryProfile = {
        [<System.Text.Json.Serialization.JsonPropertyName("breakdown")>]
        Breakdown: QueryBreakdown
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_nanos")>]
        TimeInNanos: CoreTypes.DurationValue<CoreTypes.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("children")>]
        Children: QueryProfile list option
    }

    type SearchProfile = {
        [<System.Text.Json.Serialization.JsonPropertyName("collector")>]
        Collector: Collector list
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: QueryProfile list
        [<System.Text.Json.Serialization.JsonPropertyName("rewrite_time")>]
        RewriteTime: CoreTypes.Long
    }

    type ShardProfile = {
        [<System.Text.Json.Serialization.JsonPropertyName("aggregations")>]
        Aggregations: AggregationProfile list
        [<System.Text.Json.Serialization.JsonPropertyName("cluster")>]
        Cluster: string
        [<System.Text.Json.Serialization.JsonPropertyName("dfs")>]
        Dfs: DfsProfile option
        [<System.Text.Json.Serialization.JsonPropertyName("fetch")>]
        Fetch: FetchProfile option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: string
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("node_id")>]
        NodeId: CoreTypes.NodeId
        [<System.Text.Json.Serialization.JsonPropertyName("searches")>]
        Searches: SearchProfile list
        [<System.Text.Json.Serialization.JsonPropertyName("shard_id")>]
        ShardId: CoreTypes.Integer
    }

    type Profile = {
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: ShardProfile list
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
        RescoreQuery: CoreTypes.QueryContainer
        [<System.Text.Json.Serialization.JsonPropertyName("query_weight")>]
        QueryWeight: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("rescore_query_weight")>]
        RescoreQueryWeight: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("score_mode")>]
        ScoreMode: ScoreMode option
    }

    type ScriptRescore = {
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: CoreTypes.Script
    }

    [<RequireQualifiedAccess>]
    type Rescore =
        | Query of RescoreQuery
        | LearningToRank of LearningToRank
        | Script of ScriptRescore
        | Unknown of name: string * System.Text.Json.JsonElement

    and RescoreMeta = {
        [<System.Text.Json.Serialization.JsonPropertyName("window_size")>]
        WindowSize: CoreTypes.Integer option
    }

    /// Number of hits matching the query to count accurately. If true, the exact
    [<RequireQualifiedAccess>]
    type TrackHits =
        | Boolean of bool
        | Integer of CoreTypes.Integer

    type Suggester = {
        [<System.Text.Json.Serialization.JsonPropertyName("text")>]
        Text: string option
    }

    type SearchRequestBody = {
        [<System.Text.Json.Serialization.JsonPropertyName("aggregations")>]
        Aggregations: Map<string, CoreTypes.AggregationContainer> option
        [<System.Text.Json.Serialization.JsonPropertyName("collapse")>]
        Collapse: FieldCollapse option
        [<System.Text.Json.Serialization.JsonPropertyName("explain")>]
        Explain: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ext")>]
        Ext: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        From: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("highlight")>]
        Highlight: Highlight option
        [<System.Text.Json.Serialization.JsonPropertyName("track_total_hits")>]
        TrackTotalHits: TrackHits option
        [<System.Text.Json.Serialization.JsonPropertyName("indices_boost")>]
        IndicesBoost: Map<CoreTypes.IndexName, CoreTypes.Double> list option
        [<System.Text.Json.Serialization.JsonPropertyName("docvalue_fields")>]
        DocvalueFields: CoreTypes.FieldAndFormat list option
        [<System.Text.Json.Serialization.JsonPropertyName("knn")>]
        Knn: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("rank")>]
        Rank: CoreTypes.RankContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_score")>]
        MinScore: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("post_filter")>]
        PostFilter: CoreTypes.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("profile")>]
        Profile: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: CoreTypes.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("rescore")>]
        Rescore: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("retriever")>]
        Retriever: CoreTypes.RetrieverContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("script_fields")>]
        ScriptFields: Map<string, CoreTypes.ScriptField> option
        [<System.Text.Json.Serialization.JsonPropertyName("search_after")>]
        SearchAfter: CoreTypes.SortResults option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("slice")>]
        Slice: CoreTypes.SlicedScroll option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: CoreTypes.Sort option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: SourceConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: CoreTypes.FieldAndFormat list option
        [<System.Text.Json.Serialization.JsonPropertyName("suggest")>]
        Suggest: Suggester option
        [<System.Text.Json.Serialization.JsonPropertyName("terminate_after")>]
        TerminateAfter: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("timeout")>]
        Timeout: string option
        [<System.Text.Json.Serialization.JsonPropertyName("track_scores")>]
        TrackScores: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("seq_no_primary_term")>]
        SeqNoPrimaryTerm: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("stored_fields")>]
        StoredFields: CoreTypes.Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("pit")>]
        Pit: PointInTimeReference option
        [<System.Text.Json.Serialization.JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: CoreTypes.RuntimeFields option
        [<System.Text.Json.Serialization.JsonPropertyName("stats")>]
        Stats: string list option
    }

    /// Defines how to fetch a source. Fetching can be disabled entirely, or the source can be filtered.
    [<RequireQualifiedAccess>]
    type SourceConfigParam =
        | Boolean of bool
        | Fields of CoreTypes.Fields

    type TermSuggestOption = {
        [<System.Text.Json.Serialization.JsonPropertyName("text")>]
        Text: string
        [<System.Text.Json.Serialization.JsonPropertyName("score")>]
        Score: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("freq")>]
        Freq: CoreTypes.Long
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
        | CompletionSuggest of CompletionSuggest<'tDocument>
        | PhraseSuggest of PhraseSuggest
        | TermSuggest of TermSuggest


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module MlTypes =

    type AdaptiveAllocationsSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
        [<System.Text.Json.Serialization.JsonPropertyName("min_number_of_allocations")>]
        MinNumberOfAllocations: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_number_of_allocations")>]
        MaxNumberOfAllocations: CoreTypes.Integer option
    }

    type CategorizationAnalyzerDefinition = {
        [<System.Text.Json.Serialization.JsonPropertyName("char_filter")>]
        CharFilter: CoreTypes.CharFilter list option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: CoreTypes.TokenFilter list option
        [<System.Text.Json.Serialization.JsonPropertyName("tokenizer")>]
        Tokenizer: CoreTypes.Tokenizer option
    }

    [<RequireQualifiedAccess>]
    type CategorizationAnalyzer =
        | String of string
        | CategorizationAnalyzerDefinition of CategorizationAnalyzerDefinition

    [<RequireQualifiedAccess>]
    type RuleAction =
        | SkipResult
        | SkipModelUpdate

    [<RequireQualifiedAccess>]
    type AppliesTo =
        | Actual
        | Typical
        | DiffFromTypical
        | Time

    [<RequireQualifiedAccess>]
    type ConditionOperator =
        | Gt
        | Gte
        | Lt
        | Lte

    type RuleCondition = {
        [<System.Text.Json.Serialization.JsonPropertyName("applies_to")>]
        AppliesTo: AppliesTo
        [<System.Text.Json.Serialization.JsonPropertyName("operator")>]
        Operator: ConditionOperator
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: CoreTypes.Double
    }

    [<RequireQualifiedAccess>]
    type FilterType =
        | Include
        | Exclude

    type FilterRef = {
        [<System.Text.Json.Serialization.JsonPropertyName("filter_id")>]
        FilterId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("filter_type")>]
        FilterType: FilterType option
    }

    type DetectionRule = {
        [<System.Text.Json.Serialization.JsonPropertyName("actions")>]
        Actions: RuleAction list option
        [<System.Text.Json.Serialization.JsonPropertyName("conditions")>]
        Conditions: RuleCondition list option
        [<System.Text.Json.Serialization.JsonPropertyName("scope")>]
        Scope: Map<CoreTypes.Field, FilterRef> option
    }

    [<RequireQualifiedAccess>]
    type ExcludeFrequent =
        | All
        | None
        | By
        | Over

    type Detector = {
        [<System.Text.Json.Serialization.JsonPropertyName("by_field_name")>]
        ByFieldName: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("custom_rules")>]
        CustomRules: DetectionRule list option
        [<System.Text.Json.Serialization.JsonPropertyName("detector_description")>]
        DetectorDescription: string option
        [<System.Text.Json.Serialization.JsonPropertyName("detector_index")>]
        DetectorIndex: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("exclude_frequent")>]
        ExcludeFrequent: ExcludeFrequent option
        [<System.Text.Json.Serialization.JsonPropertyName("field_name")>]
        FieldName: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("function")>]
        Function: string option
        [<System.Text.Json.Serialization.JsonPropertyName("over_field_name")>]
        OverFieldName: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("partition_field_name")>]
        PartitionFieldName: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("use_null")>]
        UseNull: bool option
    }

    type PerPartitionCategorization = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("stop_on_warn")>]
        StopOnWarn: bool option
    }

    type AnalysisConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_span")>]
        BucketSpan: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_analyzer")>]
        CategorizationAnalyzer: CategorizationAnalyzer option
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_field_name")>]
        CategorizationFieldName: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_filters")>]
        CategorizationFilters: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("detectors")>]
        Detectors: Detector list
        [<System.Text.Json.Serialization.JsonPropertyName("influencers")>]
        Influencers: CoreTypes.Field list option
        [<System.Text.Json.Serialization.JsonPropertyName("latency")>]
        Latency: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("model_prune_window")>]
        ModelPruneWindow: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("multivariate_by_fields")>]
        MultivariateByFields: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("per_partition_categorization")>]
        PerPartitionCategorization: PerPartitionCategorization option
        [<System.Text.Json.Serialization.JsonPropertyName("summary_count_field_name")>]
        SummaryCountFieldName: CoreTypes.Field option
    }

    type DetectorRead = {
        [<System.Text.Json.Serialization.JsonPropertyName("function")>]
        Function: string
        [<System.Text.Json.Serialization.JsonPropertyName("by_field_name")>]
        ByFieldName: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("custom_rules")>]
        CustomRules: DetectionRule list option
        [<System.Text.Json.Serialization.JsonPropertyName("detector_description")>]
        DetectorDescription: string option
        [<System.Text.Json.Serialization.JsonPropertyName("detector_index")>]
        DetectorIndex: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("exclude_frequent")>]
        ExcludeFrequent: ExcludeFrequent option
        [<System.Text.Json.Serialization.JsonPropertyName("field_name")>]
        FieldName: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("over_field_name")>]
        OverFieldName: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("partition_field_name")>]
        PartitionFieldName: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("use_null")>]
        UseNull: bool option
    }

    type AnalysisConfigRead = {
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_span")>]
        BucketSpan: CoreTypes.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("detectors")>]
        Detectors: DetectorRead list
        [<System.Text.Json.Serialization.JsonPropertyName("influencers")>]
        Influencers: CoreTypes.Field list
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_analyzer")>]
        CategorizationAnalyzer: CategorizationAnalyzer option
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_field_name")>]
        CategorizationFieldName: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_filters")>]
        CategorizationFilters: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("latency")>]
        Latency: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("model_prune_window")>]
        ModelPruneWindow: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("multivariate_by_fields")>]
        MultivariateByFields: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("per_partition_categorization")>]
        PerPartitionCategorization: PerPartitionCategorization option
        [<System.Text.Json.Serialization.JsonPropertyName("summary_count_field_name")>]
        SummaryCountFieldName: CoreTypes.Field option
    }

    type AnalysisLimits = {
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_examples_limit")>]
        CategorizationExamplesLimit: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("model_memory_limit")>]
        ModelMemoryLimit: CoreTypes.ByteSize option
    }

    type AnalysisMemoryLimit = {
        [<System.Text.Json.Serialization.JsonPropertyName("model_memory_limit")>]
        ModelMemoryLimit: string
    }

    type AnomalyExplanation = {
        [<System.Text.Json.Serialization.JsonPropertyName("anomaly_characteristics_impact")>]
        AnomalyCharacteristicsImpact: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("anomaly_length")>]
        AnomalyLength: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("anomaly_type")>]
        AnomalyType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("high_variance_penalty")>]
        HighVariancePenalty: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("incomplete_bucket_penalty")>]
        IncompleteBucketPenalty: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("lower_confidence_bound")>]
        LowerConfidenceBound: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("multi_bucket_impact")>]
        MultiBucketImpact: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("single_bucket_impact")>]
        SingleBucketImpact: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("typical_value")>]
        TypicalValue: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("upper_confidence_bound")>]
        UpperConfidenceBound: CoreTypes.Double option
    }

    type GeoResults = {
        [<System.Text.Json.Serialization.JsonPropertyName("actual_point")>]
        ActualPoint: string option
        [<System.Text.Json.Serialization.JsonPropertyName("typical_point")>]
        TypicalPoint: string option
    }

    type Influence = {
        [<System.Text.Json.Serialization.JsonPropertyName("influencer_field_name")>]
        InfluencerFieldName: string
        [<System.Text.Json.Serialization.JsonPropertyName("influencer_field_values")>]
        InfluencerFieldValues: string list
    }

    type AnomalyCause = {
        [<System.Text.Json.Serialization.JsonPropertyName("actual")>]
        Actual: CoreTypes.Double list option
        [<System.Text.Json.Serialization.JsonPropertyName("by_field_name")>]
        ByFieldName: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("by_field_value")>]
        ByFieldValue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("correlated_by_field_value")>]
        CorrelatedByFieldValue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("field_name")>]
        FieldName: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("function")>]
        Function: string option
        [<System.Text.Json.Serialization.JsonPropertyName("function_description")>]
        FunctionDescription: string option
        [<System.Text.Json.Serialization.JsonPropertyName("geo_results")>]
        GeoResults: GeoResults option
        [<System.Text.Json.Serialization.JsonPropertyName("influencers")>]
        Influencers: Influence list option
        [<System.Text.Json.Serialization.JsonPropertyName("over_field_name")>]
        OverFieldName: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("over_field_value")>]
        OverFieldValue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("partition_field_name")>]
        PartitionFieldName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("partition_field_value")>]
        PartitionFieldValue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("probability")>]
        Probability: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("typical")>]
        Typical: CoreTypes.Double list option
    }

    type Anomaly = {
        [<System.Text.Json.Serialization.JsonPropertyName("actual")>]
        Actual: CoreTypes.Double list option
        [<System.Text.Json.Serialization.JsonPropertyName("anomaly_score_explanation")>]
        AnomalyScoreExplanation: AnomalyExplanation option
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_span")>]
        BucketSpan: CoreTypes.DurationValue<CoreTypes.UnitSeconds>
        [<System.Text.Json.Serialization.JsonPropertyName("by_field_name")>]
        ByFieldName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("by_field_value")>]
        ByFieldValue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("causes")>]
        Causes: AnomalyCause list option
        [<System.Text.Json.Serialization.JsonPropertyName("detector_index")>]
        DetectorIndex: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("field_name")>]
        FieldName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("function")>]
        Function: string option
        [<System.Text.Json.Serialization.JsonPropertyName("function_description")>]
        FunctionDescription: string option
        [<System.Text.Json.Serialization.JsonPropertyName("geo_results")>]
        GeoResults: GeoResults option
        [<System.Text.Json.Serialization.JsonPropertyName("influencers")>]
        Influencers: Influence list option
        [<System.Text.Json.Serialization.JsonPropertyName("initial_record_score")>]
        InitialRecordScore: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("is_interim")>]
        IsInterim: bool
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: string
        [<System.Text.Json.Serialization.JsonPropertyName("over_field_name")>]
        OverFieldName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("over_field_value")>]
        OverFieldValue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("partition_field_name")>]
        PartitionFieldName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("partition_field_value")>]
        PartitionFieldValue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("probability")>]
        Probability: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("record_score")>]
        RecordScore: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("result_type")>]
        ResultType: string
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("typical")>]
        Typical: CoreTypes.Double list option
    }

    type ApiKeyAuthorization = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: string
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
    }

    type BucketInfluencer = {
        [<System.Text.Json.Serialization.JsonPropertyName("anomaly_score")>]
        AnomalyScore: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_span")>]
        BucketSpan: CoreTypes.DurationValue<CoreTypes.UnitSeconds>
        [<System.Text.Json.Serialization.JsonPropertyName("influencer_field_name")>]
        InfluencerFieldName: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("initial_anomaly_score")>]
        InitialAnomalyScore: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("is_interim")>]
        IsInterim: bool
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("probability")>]
        Probability: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("raw_anomaly_score")>]
        RawAnomalyScore: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("result_type")>]
        ResultType: string
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp_string")>]
        TimestampString: CoreTypes.DateTime option
    }

    type BucketSummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("anomaly_score")>]
        AnomalyScore: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_influencers")>]
        BucketInfluencers: BucketInfluencer list
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_span")>]
        BucketSpan: CoreTypes.DurationValue<CoreTypes.UnitSeconds>
        [<System.Text.Json.Serialization.JsonPropertyName("event_count")>]
        EventCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("initial_anomaly_score")>]
        InitialAnomalyScore: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("is_interim")>]
        IsInterim: bool
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("processing_time_ms")>]
        ProcessingTimeMs: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("result_type")>]
        ResultType: string
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp_string")>]
        TimestampString: CoreTypes.DateTime option
    }

    type CalendarEvent = {
        [<System.Text.Json.Serialization.JsonPropertyName("calendar_id")>]
        CalendarId: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("event_id")>]
        EventId: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string
        [<System.Text.Json.Serialization.JsonPropertyName("end_time")>]
        EndTime: CoreTypes.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("start_time")>]
        StartTime: CoreTypes.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("skip_result")>]
        SkipResult: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("skip_model_update")>]
        SkipModelUpdate: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("force_time_shift")>]
        ForceTimeShift: CoreTypes.Integer option
    }

    [<RequireQualifiedAccess>]
    type CategorizationStatus =
        | Ok
        | Warn

    type Category = {
        [<System.Text.Json.Serialization.JsonPropertyName("category_id")>]
        CategoryId: CoreTypes.Ulong
        [<System.Text.Json.Serialization.JsonPropertyName("examples")>]
        Examples: string list
        [<System.Text.Json.Serialization.JsonPropertyName("grok_pattern")>]
        GrokPattern: CoreTypes.GrokPattern option
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("max_matching_length")>]
        MaxMatchingLength: CoreTypes.Ulong
        [<System.Text.Json.Serialization.JsonPropertyName("partition_field_name")>]
        PartitionFieldName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("partition_field_value")>]
        PartitionFieldValue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("regex")>]
        Regex: string
        [<System.Text.Json.Serialization.JsonPropertyName("terms")>]
        Terms: string
        [<System.Text.Json.Serialization.JsonPropertyName("num_matches")>]
        NumMatches: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("preferred_to_categories")>]
        PreferredToCategories: CoreTypes.Id list option
        [<System.Text.Json.Serialization.JsonPropertyName("p")>]
        P: string option
        [<System.Text.Json.Serialization.JsonPropertyName("result_type")>]
        ResultType: string
        [<System.Text.Json.Serialization.JsonPropertyName("mlcategory")>]
        Mlcategory: string
    }

    [<RequireQualifiedAccess>]
    type ChunkingMode =
        | Auto
        | Manual
        | Off

    type ChunkingConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: ChunkingMode
        [<System.Text.Json.Serialization.JsonPropertyName("time_span")>]
        TimeSpan: CoreTypes.Duration option
    }

    type ClassificationInferenceOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_classes")>]
        NumTopClasses: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_feature_importance_values")>]
        NumTopFeatureImportanceValues: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("prediction_field_type")>]
        PredictionFieldType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
        [<System.Text.Json.Serialization.JsonPropertyName("top_classes_results_field")>]
        TopClassesResultsField: string option
    }

    [<RequireQualifiedAccess>]
    type TokenizationTruncate =
        | First
        | Second
        | None

    type CommonTokenizationConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("do_lower_case")>]
        DoLowerCase: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("max_sequence_length")>]
        MaxSequenceLength: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("span")>]
        Span: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("truncate")>]
        Truncate: TokenizationTruncate option
        [<System.Text.Json.Serialization.JsonPropertyName("with_special_tokens")>]
        WithSpecialTokens: bool option
    }

    /// Custom metadata about the job
    type CustomSettings = System.Text.Json.JsonElement

    type DataCounts = {
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_count")>]
        BucketCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("earliest_record_timestamp")>]
        EarliestRecordTimestamp: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("empty_bucket_count")>]
        EmptyBucketCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("input_bytes")>]
        InputBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("input_field_count")>]
        InputFieldCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("input_record_count")>]
        InputRecordCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("invalid_date_count")>]
        InvalidDateCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("last_data_time")>]
        LastDataTime: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("latest_empty_bucket_timestamp")>]
        LatestEmptyBucketTimestamp: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("latest_record_timestamp")>]
        LatestRecordTimestamp: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("latest_sparse_bucket_timestamp")>]
        LatestSparseBucketTimestamp: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("latest_bucket_timestamp")>]
        LatestBucketTimestamp: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("log_time")>]
        LogTime: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("missing_field_count")>]
        MissingFieldCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("out_of_order_timestamp_count")>]
        OutOfOrderTimestampCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("processed_field_count")>]
        ProcessedFieldCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("processed_record_count")>]
        ProcessedRecordCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("sparse_bucket_count")>]
        SparseBucketCount: CoreTypes.Long
    }

    type DataDescription = {
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("time_field")>]
        TimeField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("time_format")>]
        TimeFormat: string option
        [<System.Text.Json.Serialization.JsonPropertyName("field_delimiter")>]
        FieldDelimiter: string option
    }

    type DatafeedAuthorization = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: ApiKeyAuthorization option
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("service_account")>]
        ServiceAccount: string option
    }

    type DelayedDataCheckConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("check_window")>]
        CheckWindow: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
    }

    type Datafeed = {
        [<System.Text.Json.Serialization.JsonPropertyName("aggregations")>]
        Aggregations: Map<string, CoreTypes.AggregationContainer> option
        [<System.Text.Json.Serialization.JsonPropertyName("authorization")>]
        Authorization: DatafeedAuthorization option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_config")>]
        ChunkingConfig: ChunkingConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("datafeed_id")>]
        DatafeedId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("frequency")>]
        Frequency: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: string list
        [<System.Text.Json.Serialization.JsonPropertyName("indexes")>]
        Indexes: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("max_empty_searches")>]
        MaxEmptySearches: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: CoreTypes.QueryContainer
        [<System.Text.Json.Serialization.JsonPropertyName("query_delay")>]
        QueryDelay: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("script_fields")>]
        ScriptFields: Map<string, CoreTypes.ScriptField> option
        [<System.Text.Json.Serialization.JsonPropertyName("scroll_size")>]
        ScrollSize: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("delayed_data_check_config")>]
        DelayedDataCheckConfig: DelayedDataCheckConfig
        [<System.Text.Json.Serialization.JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: CoreTypes.RuntimeFields option
        [<System.Text.Json.Serialization.JsonPropertyName("indices_options")>]
        IndicesOptions: CoreTypes.IndicesOptions option
    }

    type DatafeedConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("aggregations")>]
        Aggregations: Map<string, CoreTypes.AggregationContainer> option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_config")>]
        ChunkingConfig: ChunkingConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("datafeed_id")>]
        DatafeedId: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("delayed_data_check_config")>]
        DelayedDataCheckConfig: DelayedDataCheckConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("frequency")>]
        Frequency: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: CoreTypes.Indices option
        [<System.Text.Json.Serialization.JsonPropertyName("indices_options")>]
        IndicesOptions: CoreTypes.IndicesOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("max_empty_searches")>]
        MaxEmptySearches: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: CoreTypes.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("query_delay")>]
        QueryDelay: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: CoreTypes.RuntimeFields option
        [<System.Text.Json.Serialization.JsonPropertyName("script_fields")>]
        ScriptFields: Map<string, CoreTypes.ScriptField> option
        [<System.Text.Json.Serialization.JsonPropertyName("scroll_size")>]
        ScrollSize: CoreTypes.Integer option
    }

    type RunningStateSearchInterval = {
        [<System.Text.Json.Serialization.JsonPropertyName("end")>]
        End: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("end_ms")>]
        EndMs: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("start")>]
        Start: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("start_ms")>]
        StartMs: CoreTypes.DurationValue<CoreTypes.UnitMillis>
    }

    type DatafeedRunningState = {
        [<System.Text.Json.Serialization.JsonPropertyName("real_time_configured")>]
        RealTimeConfigured: bool
        [<System.Text.Json.Serialization.JsonPropertyName("real_time_running")>]
        RealTimeRunning: bool
        [<System.Text.Json.Serialization.JsonPropertyName("search_interval")>]
        SearchInterval: RunningStateSearchInterval option
    }

    [<RequireQualifiedAccess>]
    type DatafeedState =
        | Started
        | Stopped
        | Starting
        | Stopping

    /// Alternative representation of DiscoveryNode used in ml.get_job_stats and ml.get_datafeed_stats
    type DiscoveryNodeCompact = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("ephemeral_id")>]
        EphemeralId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("transport_address")>]
        TransportAddress: CoreTypes.TransportAddress
        [<System.Text.Json.Serialization.JsonPropertyName("attributes")>]
        Attributes: Map<string, string>
    }

    type ExponentialAverageCalculationContext = {
        [<System.Text.Json.Serialization.JsonPropertyName("incremental_metric_value_ms")>]
        IncrementalMetricValueMs: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("latest_timestamp")>]
        LatestTimestamp: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("previous_exponential_average_ms")>]
        PreviousExponentialAverageMs: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis> option
    }

    type DatafeedTimingStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_count")>]
        BucketCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("exponential_average_search_time_per_hour_ms")>]
        ExponentialAverageSearchTimePerHourMs: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("exponential_average_calculation_context")>]
        ExponentialAverageCalculationContext: ExponentialAverageCalculationContext option
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("search_count")>]
        SearchCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_search_time_ms")>]
        TotalSearchTimeMs: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("average_search_time_per_bucket_ms")>]
        AverageSearchTimePerBucketMs: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis> option
    }

    type DatafeedStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("assignment_explanation")>]
        AssignmentExplanation: string option
        [<System.Text.Json.Serialization.JsonPropertyName("datafeed_id")>]
        DatafeedId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: DiscoveryNodeCompact option
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: DatafeedState
        [<System.Text.Json.Serialization.JsonPropertyName("timing_stats")>]
        TimingStats: DatafeedTimingStats option
        [<System.Text.Json.Serialization.JsonPropertyName("running_state")>]
        RunningState: DatafeedRunningState option
    }

    type DataframeAnalysisFeatureProcessorFrequencyEncoding = {
        [<System.Text.Json.Serialization.JsonPropertyName("feature_name")>]
        FeatureName: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("frequency_map")>]
        FrequencyMap: Map<string, CoreTypes.Double>
    }

    type DataframeAnalysisFeatureProcessorMultiEncoding = {
        [<System.Text.Json.Serialization.JsonPropertyName("processors")>]
        Processors: CoreTypes.Integer list
    }

    type DataframeAnalysisFeatureProcessorNGramEncoding = {
        [<System.Text.Json.Serialization.JsonPropertyName("feature_prefix")>]
        FeaturePrefix: string option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("length")>]
        Length: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("n_grams")>]
        NGrams: CoreTypes.Integer list
        [<System.Text.Json.Serialization.JsonPropertyName("start")>]
        Start: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("custom")>]
        Custom: bool option
    }

    type DataframeAnalysisFeatureProcessorOneHotEncoding = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("hot_map")>]
        HotMap: string
    }

    type DataframeAnalysisFeatureProcessorTargetMeanEncoding = {
        [<System.Text.Json.Serialization.JsonPropertyName("default_value")>]
        DefaultValue: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("feature_name")>]
        FeatureName: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("target_map")>]
        TargetMap: Map<string, System.Text.Json.JsonElement>
    }

    [<RequireQualifiedAccess>]
    type DataframeAnalysisFeatureProcessor =
        | FrequencyEncoding of DataframeAnalysisFeatureProcessorFrequencyEncoding
        | MultiEncoding of DataframeAnalysisFeatureProcessorMultiEncoding
        | NGramEncoding of DataframeAnalysisFeatureProcessorNGramEncoding
        | OneHotEncoding of DataframeAnalysisFeatureProcessorOneHotEncoding
        | TargetMeanEncoding of DataframeAnalysisFeatureProcessorTargetMeanEncoding

    type DataframeAnalysis = {
        [<System.Text.Json.Serialization.JsonPropertyName("alpha")>]
        Alpha: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("dependent_variable")>]
        DependentVariable: string
        [<System.Text.Json.Serialization.JsonPropertyName("downsample_factor")>]
        DownsampleFactor: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("early_stopping_enabled")>]
        EarlyStoppingEnabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("eta")>]
        Eta: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("eta_growth_rate_per_tree")>]
        EtaGrowthRatePerTree: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_bag_fraction")>]
        FeatureBagFraction: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_processors")>]
        FeatureProcessors: DataframeAnalysisFeatureProcessor list option
        [<System.Text.Json.Serialization.JsonPropertyName("gamma")>]
        Gamma: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("lambda")>]
        Lambda: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("max_optimization_rounds_per_hyperparameter")>]
        MaxOptimizationRoundsPerHyperparameter: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_trees")>]
        MaxTrees: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_feature_importance_values")>]
        NumTopFeatureImportanceValues: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("prediction_field_name")>]
        PredictionFieldName: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("randomize_seed")>]
        RandomizeSeed: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("soft_tree_depth_limit")>]
        SoftTreeDepthLimit: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("soft_tree_depth_tolerance")>]
        SoftTreeDepthTolerance: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("training_percent")>]
        TrainingPercent: CoreTypes.Percentage option
    }

    type DataframeAnalysisAnalyzedFields = {
        [<System.Text.Json.Serialization.JsonPropertyName("includes")>]
        Includes: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("excludes")>]
        Excludes: string list option
    }

    type DataframeAnalysisClassification = {
        [<System.Text.Json.Serialization.JsonPropertyName("class_assignment_objective")>]
        ClassAssignmentObjective: string option
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_classes")>]
        NumTopClasses: CoreTypes.Integer option
    }

    type DataframeAnalysisOutlierDetection = {
        [<System.Text.Json.Serialization.JsonPropertyName("compute_feature_influence")>]
        ComputeFeatureInfluence: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_influence_threshold")>]
        FeatureInfluenceThreshold: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("method")>]
        Method: string option
        [<System.Text.Json.Serialization.JsonPropertyName("n_neighbors")>]
        NNeighbors: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("outlier_fraction")>]
        OutlierFraction: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("standardization_enabled")>]
        StandardizationEnabled: bool option
    }

    type DataframeAnalysisRegression = {
        [<System.Text.Json.Serialization.JsonPropertyName("loss_function")>]
        LossFunction: string option
        [<System.Text.Json.Serialization.JsonPropertyName("loss_function_parameter")>]
        LossFunctionParameter: CoreTypes.Double option
    }

    [<RequireQualifiedAccess>]
    type DataframeAnalysisContainer =
        | Classification of DataframeAnalysisClassification
        | OutlierDetection of DataframeAnalysisOutlierDetection
        | Regression of DataframeAnalysisRegression

    type Hyperparameters = {
        [<System.Text.Json.Serialization.JsonPropertyName("alpha")>]
        Alpha: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("lambda")>]
        Lambda: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("gamma")>]
        Gamma: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("eta")>]
        Eta: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("eta_growth_rate_per_tree")>]
        EtaGrowthRatePerTree: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_bag_fraction")>]
        FeatureBagFraction: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("downsample_factor")>]
        DownsampleFactor: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("max_attempts_to_add_tree")>]
        MaxAttemptsToAddTree: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_optimization_rounds_per_hyperparameter")>]
        MaxOptimizationRoundsPerHyperparameter: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_trees")>]
        MaxTrees: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("num_folds")>]
        NumFolds: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("num_splits_per_feature")>]
        NumSplitsPerFeature: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("soft_tree_depth_limit")>]
        SoftTreeDepthLimit: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("soft_tree_depth_tolerance")>]
        SoftTreeDepthTolerance: CoreTypes.Double option
    }

    type TimingStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("elapsed_time")>]
        ElapsedTime: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("iteration_time")>]
        IterationTime: CoreTypes.DurationValue<CoreTypes.UnitMillis> option
    }

    type ValidationLoss = {
        [<System.Text.Json.Serialization.JsonPropertyName("fold_values")>]
        FoldValues: string list
        [<System.Text.Json.Serialization.JsonPropertyName("loss_type")>]
        LossType: string
    }

    type DataframeAnalyticsStatsHyperparameters = {
        [<System.Text.Json.Serialization.JsonPropertyName("hyperparameters")>]
        Hyperparameters: Hyperparameters
        [<System.Text.Json.Serialization.JsonPropertyName("iteration")>]
        Iteration: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("timing_stats")>]
        TimingStats: TimingStats
        [<System.Text.Json.Serialization.JsonPropertyName("validation_loss")>]
        ValidationLoss: ValidationLoss
    }

    type OutlierDetectionParameters = {
        [<System.Text.Json.Serialization.JsonPropertyName("compute_feature_influence")>]
        ComputeFeatureInfluence: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_influence_threshold")>]
        FeatureInfluenceThreshold: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("method")>]
        Method: string option
        [<System.Text.Json.Serialization.JsonPropertyName("n_neighbors")>]
        NNeighbors: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("outlier_fraction")>]
        OutlierFraction: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("standardization_enabled")>]
        StandardizationEnabled: bool option
    }

    type DataframeAnalyticsStatsOutlierDetection = {
        [<System.Text.Json.Serialization.JsonPropertyName("parameters")>]
        Parameters: OutlierDetectionParameters
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("timing_stats")>]
        TimingStats: TimingStats
    }

    [<RequireQualifiedAccess>]
    type DataframeAnalyticsStatsContainer =
        | ClassificationStats of DataframeAnalyticsStatsHyperparameters
        | OutlierDetectionStats of DataframeAnalyticsStatsOutlierDetection
        | RegressionStats of DataframeAnalyticsStatsHyperparameters

    type DataframeAnalyticsStatsDataCounts = {
        [<System.Text.Json.Serialization.JsonPropertyName("skipped_docs_count")>]
        SkippedDocsCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("test_docs_count")>]
        TestDocsCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("training_docs_count")>]
        TrainingDocsCount: CoreTypes.Integer
    }

    type DataframeAnalyticsStatsMemoryUsage = {
        [<System.Text.Json.Serialization.JsonPropertyName("memory_reestimate_bytes")>]
        MemoryReestimateBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("peak_usage_bytes")>]
        PeakUsageBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: string
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
    }

    type DataframeAnalyticsStatsProgress = {
        [<System.Text.Json.Serialization.JsonPropertyName("phase")>]
        Phase: string
        [<System.Text.Json.Serialization.JsonPropertyName("progress_percent")>]
        ProgressPercent: CoreTypes.Integer
    }

    [<RequireQualifiedAccess>]
    type DataframeState =
        | Started
        | Stopped
        | Starting
        | Stopping
        | Failed

    type DataframeAnalytics = {
        [<System.Text.Json.Serialization.JsonPropertyName("analysis_stats")>]
        AnalysisStats: DataframeAnalyticsStatsContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("assignment_explanation")>]
        AssignmentExplanation: string option
        [<System.Text.Json.Serialization.JsonPropertyName("data_counts")>]
        DataCounts: DataframeAnalyticsStatsDataCounts
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("memory_usage")>]
        MemoryUsage: DataframeAnalyticsStatsMemoryUsage
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: CoreTypes.NodeAttributes option
        [<System.Text.Json.Serialization.JsonPropertyName("progress")>]
        Progress: DataframeAnalyticsStatsProgress list
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: DataframeState
    }

    type DataframeAnalyticsAuthorization = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: ApiKeyAuthorization option
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("service_account")>]
        ServiceAccount: string option
    }

    type DataframeAnalyticsDestination = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: CoreTypes.Field option
    }

    type DataframeAnalyticsFieldSelection = {
        [<System.Text.Json.Serialization.JsonPropertyName("is_included")>]
        IsIncluded: bool
        [<System.Text.Json.Serialization.JsonPropertyName("is_required")>]
        IsRequired: bool
        [<System.Text.Json.Serialization.JsonPropertyName("feature_type")>]
        FeatureType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("mapping_types")>]
        MappingTypes: string list
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string option
    }

    type DataframeAnalyticsMemoryEstimation = {
        [<System.Text.Json.Serialization.JsonPropertyName("expected_memory_with_disk")>]
        ExpectedMemoryWithDisk: string
        [<System.Text.Json.Serialization.JsonPropertyName("expected_memory_without_disk")>]
        ExpectedMemoryWithoutDisk: string
    }

    type DataframeAnalyticsSource = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.Indices
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: CoreTypes.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: CoreTypes.RuntimeFields option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: DataframeAnalysisAnalyzedFields option
    }

    type DataframeAnalyticsSummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("allow_lazy_start")>]
        AllowLazyStart: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("analysis")>]
        Analysis: DataframeAnalysisContainer
        [<System.Text.Json.Serialization.JsonPropertyName("analyzed_fields")>]
        AnalyzedFields: DataframeAnalysisAnalyzedFields option
        [<System.Text.Json.Serialization.JsonPropertyName("authorization")>]
        Authorization: DataframeAnalyticsAuthorization option
        [<System.Text.Json.Serialization.JsonPropertyName("create_time")>]
        CreateTime: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("dest")>]
        Dest: DataframeAnalyticsDestination
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("max_num_threads")>]
        MaxNumThreads: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("model_memory_limit")>]
        ModelMemoryLimit: string option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: DataframeAnalyticsSource
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: CoreTypes.Metadata option
    }

    type DataframeEvaluationClassificationMetricsAucRoc = {
        [<System.Text.Json.Serialization.JsonPropertyName("class_name")>]
        ClassName: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("include_curve")>]
        IncludeCurve: bool option
    }

    type DataframeEvaluationMetrics = {
        [<System.Text.Json.Serialization.JsonPropertyName("auc_roc")>]
        AucRoc: DataframeEvaluationClassificationMetricsAucRoc option
        [<System.Text.Json.Serialization.JsonPropertyName("precision")>]
        Precision: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("recall")>]
        Recall: Map<string, System.Text.Json.JsonElement> option
    }

    type DataframeEvaluationClassificationMetrics = {
        [<System.Text.Json.Serialization.JsonPropertyName("accuracy")>]
        Accuracy: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("multiclass_confusion_matrix")>]
        MulticlassConfusionMatrix: Map<string, System.Text.Json.JsonElement> option
    }

    type DataframeEvaluationClassification = {
        [<System.Text.Json.Serialization.JsonPropertyName("actual_field")>]
        ActualField: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("predicted_field")>]
        PredictedField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("top_classes_field")>]
        TopClassesField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("metrics")>]
        Metrics: DataframeEvaluationClassificationMetrics option
    }

    type DataframeEvaluationOutlierDetectionMetrics = {
        [<System.Text.Json.Serialization.JsonPropertyName("confusion_matrix")>]
        ConfusionMatrix: Map<string, System.Text.Json.JsonElement> option
    }

    type DataframeEvaluationOutlierDetection = {
        [<System.Text.Json.Serialization.JsonPropertyName("actual_field")>]
        ActualField: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("predicted_probability_field")>]
        PredictedProbabilityField: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("metrics")>]
        Metrics: DataframeEvaluationOutlierDetectionMetrics option
    }

    type DataframeEvaluationRegressionMetricsMsle = {
        [<System.Text.Json.Serialization.JsonPropertyName("offset")>]
        Offset: CoreTypes.Double option
    }

    type DataframeEvaluationRegressionMetricsHuber = {
        [<System.Text.Json.Serialization.JsonPropertyName("delta")>]
        Delta: CoreTypes.Double option
    }

    type DataframeEvaluationRegressionMetrics = {
        [<System.Text.Json.Serialization.JsonPropertyName("mse")>]
        Mse: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("msle")>]
        Msle: DataframeEvaluationRegressionMetricsMsle option
        [<System.Text.Json.Serialization.JsonPropertyName("huber")>]
        Huber: DataframeEvaluationRegressionMetricsHuber option
        [<System.Text.Json.Serialization.JsonPropertyName("r_squared")>]
        RSquared: Map<string, System.Text.Json.JsonElement> option
    }

    type DataframeEvaluationRegression = {
        [<System.Text.Json.Serialization.JsonPropertyName("actual_field")>]
        ActualField: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("predicted_field")>]
        PredictedField: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("metrics")>]
        Metrics: DataframeEvaluationRegressionMetrics option
    }

    [<RequireQualifiedAccess>]
    type DataframeEvaluationContainer =
        | Classification of DataframeEvaluationClassification
        | OutlierDetection of DataframeEvaluationOutlierDetection
        | Regression of DataframeEvaluationRegression

    [<RequireQualifiedAccess>]
    type DeploymentAllocationState =
        | Started
        | Starting
        | FullyAllocated

    [<RequireQualifiedAccess>]
    type DeploymentAssignmentState =
        | Started
        | Starting
        | Stopping
        | Failed

    type DetectorUpdate = {
        [<System.Text.Json.Serialization.JsonPropertyName("detector_index")>]
        DetectorIndex: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("custom_rules")>]
        CustomRules: DetectionRule list option
    }

    type DiscoveryNodeContent = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("ephemeral_id")>]
        EphemeralId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("transport_address")>]
        TransportAddress: CoreTypes.TransportAddress
        [<System.Text.Json.Serialization.JsonPropertyName("external_id")>]
        ExternalId: string
        [<System.Text.Json.Serialization.JsonPropertyName("attributes")>]
        Attributes: Map<string, string>
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: string list
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("min_index_version")>]
        MinIndexVersion: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("max_index_version")>]
        MaxIndexVersion: CoreTypes.Integer
    }

    type DiscoveryNode = Map<CoreTypes.Id, DiscoveryNodeContent>

    type QueryFeatureExtractor = {
        [<System.Text.Json.Serialization.JsonPropertyName("default_score")>]
        DefaultScore: CoreTypes.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_name")>]
        FeatureName: string
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: CoreTypes.QueryContainer
    }

    type FeatureExtractor = QueryFeatureExtractor

    /// BERT and MPNet tokenization configuration options
    type NlpBertTokenizationConfig = System.Text.Json.JsonElement

    /// RoBERTa tokenization configuration options
    type NlpRobertaTokenizationConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("add_prefix_space")>]
        AddPrefixSpace: bool option
    }

    type XlmRobertaTokenizationConfig = System.Text.Json.JsonElement

    /// Tokenization options stored in inference configuration
    [<RequireQualifiedAccess>]
    type TokenizationConfigContainer =
        | Bert of NlpBertTokenizationConfig
        | BertJa of NlpBertTokenizationConfig
        | Mpnet of NlpBertTokenizationConfig
        | Roberta of NlpRobertaTokenizationConfig
        | XlmRoberta of XlmRobertaTokenizationConfig

    type Vocabulary = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName
    }

    /// Fill mask inference options
    type FillMaskInferenceOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("mask_token")>]
        MaskToken: string option
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_classes")>]
        NumTopClasses: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: TokenizationConfigContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
        [<System.Text.Json.Serialization.JsonPropertyName("vocabulary")>]
        Vocabulary: Vocabulary option
    }

    type NlpTokenizationUpdateOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("truncate")>]
        Truncate: TokenizationTruncate option
        [<System.Text.Json.Serialization.JsonPropertyName("span")>]
        Span: CoreTypes.Integer option
    }

    type FillMaskInferenceUpdateOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_classes")>]
        NumTopClasses: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: NlpTokenizationUpdateOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
    }

    type Filter = {
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("filter_id")>]
        FilterId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("items")>]
        Items: string list
    }

    type Hyperparameter = {
        [<System.Text.Json.Serialization.JsonPropertyName("absolute_importance")>]
        AbsoluteImportance: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("relative_importance")>]
        RelativeImportance: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("supplied")>]
        Supplied: bool
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: CoreTypes.Double
    }

    [<RequireQualifiedAccess>]
    type Include =
        | Definition
        | FeatureImportanceBaseline
        | Hyperparameters
        | TotalFeatureImportance
        | DefinitionStatus

    type RegressionInferenceOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_feature_importance_values")>]
        NumTopFeatureImportanceValues: CoreTypes.Integer option
    }

    /// Text classification configuration options
    type TextClassificationInferenceOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_classes")>]
        NumTopClasses: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: TokenizationConfigContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
        [<System.Text.Json.Serialization.JsonPropertyName("classification_labels")>]
        ClassificationLabels: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("vocabulary")>]
        Vocabulary: Vocabulary option
    }

    /// Zero shot classification configuration options
    type ZeroShotClassificationInferenceOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: TokenizationConfigContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("hypothesis_template")>]
        HypothesisTemplate: string option
        [<System.Text.Json.Serialization.JsonPropertyName("classification_labels")>]
        ClassificationLabels: string list
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
        [<System.Text.Json.Serialization.JsonPropertyName("multi_label")>]
        MultiLabel: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("labels")>]
        Labels: string list option
    }

    type LearningToRankConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("default_params")>]
        DefaultParams: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_extractors")>]
        FeatureExtractors: Map<string, FeatureExtractor> list option
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_feature_importance_values")>]
        NumTopFeatureImportanceValues: CoreTypes.Integer
    }

    /// Named entity recognition options
    type NerInferenceOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: TokenizationConfigContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
        [<System.Text.Json.Serialization.JsonPropertyName("classification_labels")>]
        ClassificationLabels: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("vocabulary")>]
        Vocabulary: Vocabulary option
    }

    /// Pass through configuration options
    type PassThroughInferenceOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: TokenizationConfigContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
        [<System.Text.Json.Serialization.JsonPropertyName("vocabulary")>]
        Vocabulary: Vocabulary option
    }

    /// Text embedding inference options
    type TextEmbeddingInferenceOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("embedding_size")>]
        EmbeddingSize: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: TokenizationConfigContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
        [<System.Text.Json.Serialization.JsonPropertyName("vocabulary")>]
        Vocabulary: Vocabulary option
    }

    /// Text expansion inference options
    type TextExpansionInferenceOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: TokenizationConfigContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
        [<System.Text.Json.Serialization.JsonPropertyName("vocabulary")>]
        Vocabulary: Vocabulary option
    }

    /// Question answering inference options
    type QuestionAnsweringInferenceOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_classes")>]
        NumTopClasses: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: TokenizationConfigContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_answer_length")>]
        MaxAnswerLength: CoreTypes.Integer option
    }

    /// Inference configuration provided when storing the model config
    [<RequireQualifiedAccess>]
    type InferenceConfigCreateContainer =
        | Regression of RegressionInferenceOptions
        | Classification of ClassificationInferenceOptions
        | TextClassification of TextClassificationInferenceOptions
        | ZeroShotClassification of ZeroShotClassificationInferenceOptions
        | FillMask of FillMaskInferenceOptions
        | LearningToRank of LearningToRankConfig
        | Ner of NerInferenceOptions
        | PassThrough of PassThroughInferenceOptions
        | TextEmbedding of TextEmbeddingInferenceOptions
        | TextExpansion of TextExpansionInferenceOptions
        | QuestionAnswering of QuestionAnsweringInferenceOptions

    type TextClassificationInferenceUpdateOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_classes")>]
        NumTopClasses: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: NlpTokenizationUpdateOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
        [<System.Text.Json.Serialization.JsonPropertyName("classification_labels")>]
        ClassificationLabels: string list option
    }

    type ZeroShotClassificationInferenceUpdateOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: NlpTokenizationUpdateOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
        [<System.Text.Json.Serialization.JsonPropertyName("multi_label")>]
        MultiLabel: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("labels")>]
        Labels: string list
    }

    type NerInferenceUpdateOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: NlpTokenizationUpdateOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
    }

    type PassThroughInferenceUpdateOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: NlpTokenizationUpdateOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
    }

    type TextEmbeddingInferenceUpdateOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: NlpTokenizationUpdateOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
    }

    type TextExpansionInferenceUpdateOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: NlpTokenizationUpdateOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
    }

    type QuestionAnsweringInferenceUpdateOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("question")>]
        Question: string
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_classes")>]
        NumTopClasses: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: NlpTokenizationUpdateOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_answer_length")>]
        MaxAnswerLength: CoreTypes.Integer option
    }

    [<RequireQualifiedAccess>]
    type InferenceConfigUpdateContainer =
        | Regression of RegressionInferenceOptions
        | Classification of ClassificationInferenceOptions
        | TextClassification of TextClassificationInferenceUpdateOptions
        | ZeroShotClassification of ZeroShotClassificationInferenceUpdateOptions
        | FillMask of FillMaskInferenceUpdateOptions
        | Ner of NerInferenceUpdateOptions
        | PassThrough of PassThroughInferenceUpdateOptions
        | TextEmbedding of TextEmbeddingInferenceUpdateOptions
        | TextExpansion of TextExpansionInferenceUpdateOptions
        | QuestionAnswering of QuestionAnsweringInferenceUpdateOptions

    type TrainedModelEntities = {
        [<System.Text.Json.Serialization.JsonPropertyName("class_name")>]
        ClassName: string
        [<System.Text.Json.Serialization.JsonPropertyName("class_probability")>]
        ClassProbability: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("entity")>]
        Entity: string
        [<System.Text.Json.Serialization.JsonPropertyName("start_pos")>]
        StartPos: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("end_pos")>]
        EndPos: CoreTypes.Integer
    }

    [<RequireQualifiedAccess>]
    type PredictedValue =
        | ScalarValue of CoreTypes.ScalarValue
        | Array of CoreTypes.ScalarValue list

    type TopClassEntry = {
        [<System.Text.Json.Serialization.JsonPropertyName("class_name")>]
        ClassName: string
        [<System.Text.Json.Serialization.JsonPropertyName("class_probability")>]
        ClassProbability: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("class_score")>]
        ClassScore: CoreTypes.Double
    }

    type TrainedModelInferenceClassImportance = {
        [<System.Text.Json.Serialization.JsonPropertyName("class_name")>]
        ClassName: string
        [<System.Text.Json.Serialization.JsonPropertyName("importance")>]
        Importance: CoreTypes.Double
    }

    type TrainedModelInferenceFeatureImportance = {
        [<System.Text.Json.Serialization.JsonPropertyName("feature_name")>]
        FeatureName: string
        [<System.Text.Json.Serialization.JsonPropertyName("importance")>]
        Importance: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("classes")>]
        Classes: TrainedModelInferenceClassImportance list option
    }

    type InferenceResponseResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("entities")>]
        Entities: TrainedModelEntities list option
        [<System.Text.Json.Serialization.JsonPropertyName("is_truncated")>]
        IsTruncated: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("predicted_value")>]
        PredictedValue: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("predicted_value_sequence")>]
        PredictedValueSequence: string option
        [<System.Text.Json.Serialization.JsonPropertyName("prediction_probability")>]
        PredictionProbability: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("prediction_score")>]
        PredictionScore: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("top_classes")>]
        TopClasses: TopClassEntry list option
        [<System.Text.Json.Serialization.JsonPropertyName("warning")>]
        Warning: string option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_importance")>]
        FeatureImportance: TrainedModelInferenceFeatureImportance list option
    }

    type Influencer = {
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_span")>]
        BucketSpan: CoreTypes.DurationValue<CoreTypes.UnitSeconds>
        [<System.Text.Json.Serialization.JsonPropertyName("influencer_score")>]
        InfluencerScore: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("influencer_field_name")>]
        InfluencerFieldName: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("influencer_field_value")>]
        InfluencerFieldValue: string
        [<System.Text.Json.Serialization.JsonPropertyName("initial_influencer_score")>]
        InitialInfluencerScore: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("is_interim")>]
        IsInterim: bool
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("probability")>]
        Probability: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("result_type")>]
        ResultType: string
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("foo")>]
        Foo: string option
    }

    [<RequireQualifiedAccess>]
    type JobBlockedReason =
        | Delete
        | Reset
        | Revert

    type JobBlocked = {
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: JobBlockedReason
        [<System.Text.Json.Serialization.JsonPropertyName("task_id")>]
        TaskId: CoreTypes.TaskId option
    }

    type ModelPlotConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("annotations_enabled")>]
        AnnotationsEnabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("terms")>]
        Terms: CoreTypes.Field option
    }

    type Job = {
        [<System.Text.Json.Serialization.JsonPropertyName("allow_lazy_open")>]
        AllowLazyOpen: bool
        [<System.Text.Json.Serialization.JsonPropertyName("analysis_config")>]
        AnalysisConfig: AnalysisConfig
        [<System.Text.Json.Serialization.JsonPropertyName("analysis_limits")>]
        AnalysisLimits: AnalysisLimits option
        [<System.Text.Json.Serialization.JsonPropertyName("background_persist_interval")>]
        BackgroundPersistInterval: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("blocked")>]
        Blocked: JobBlocked option
        [<System.Text.Json.Serialization.JsonPropertyName("create_time")>]
        CreateTime: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("custom_settings")>]
        CustomSettings: CustomSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("daily_model_snapshot_retention_after_days")>]
        DailyModelSnapshotRetentionAfterDays: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("data_description")>]
        DataDescription: DataDescription
        [<System.Text.Json.Serialization.JsonPropertyName("datafeed_config")>]
        DatafeedConfig: Datafeed option
        [<System.Text.Json.Serialization.JsonPropertyName("deleting")>]
        Deleting: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("finished_time")>]
        FinishedTime: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("groups")>]
        Groups: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("job_type")>]
        JobType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("job_version")>]
        JobVersion: CoreTypes.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("model_plot_config")>]
        ModelPlotConfig: ModelPlotConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("model_snapshot_id")>]
        ModelSnapshotId: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("model_snapshot_retention_days")>]
        ModelSnapshotRetentionDays: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("renormalization_window_days")>]
        RenormalizationWindowDays: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("results_index_name")>]
        ResultsIndexName: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("results_retention_days")>]
        ResultsRetentionDays: CoreTypes.Long option
    }

    type JobConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("allow_lazy_open")>]
        AllowLazyOpen: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("analysis_config")>]
        AnalysisConfig: AnalysisConfig
        [<System.Text.Json.Serialization.JsonPropertyName("analysis_limits")>]
        AnalysisLimits: AnalysisLimits option
        [<System.Text.Json.Serialization.JsonPropertyName("background_persist_interval")>]
        BackgroundPersistInterval: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("custom_settings")>]
        CustomSettings: CustomSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("daily_model_snapshot_retention_after_days")>]
        DailyModelSnapshotRetentionAfterDays: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("data_description")>]
        DataDescription: DataDescription
        [<System.Text.Json.Serialization.JsonPropertyName("datafeed_config")>]
        DatafeedConfig: DatafeedConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("groups")>]
        Groups: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("job_type")>]
        JobType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model_plot_config")>]
        ModelPlotConfig: ModelPlotConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("model_snapshot_retention_days")>]
        ModelSnapshotRetentionDays: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("renormalization_window_days")>]
        RenormalizationWindowDays: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("results_index_name")>]
        ResultsIndexName: CoreTypes.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("results_retention_days")>]
        ResultsRetentionDays: CoreTypes.Long option
    }

    type JobStatistics = {
        [<System.Text.Json.Serialization.JsonPropertyName("avg")>]
        Avg: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("min")>]
        Min: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.Double
    }

    type JobForecastStatistics = {
        [<System.Text.Json.Serialization.JsonPropertyName("memory_bytes")>]
        MemoryBytes: JobStatistics option
        [<System.Text.Json.Serialization.JsonPropertyName("processing_time_ms")>]
        ProcessingTimeMs: JobStatistics option
        [<System.Text.Json.Serialization.JsonPropertyName("records")>]
        Records: JobStatistics option
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: Map<string, CoreTypes.Long> option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("forecasted_jobs")>]
        ForecastedJobs: CoreTypes.Integer
    }

    [<RequireQualifiedAccess>]
    type JobState =
        | Closing
        | Closed
        | Opened
        | Failed
        | Opening

    [<RequireQualifiedAccess>]
    type MemoryStatus =
        | Ok
        | SoftLimit
        | HardLimit

    type ModelSizeStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_allocation_failures_count")>]
        BucketAllocationFailuresCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("log_time")>]
        LogTime: CoreTypes.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("memory_status")>]
        MemoryStatus: MemoryStatus
        [<System.Text.Json.Serialization.JsonPropertyName("model_bytes")>]
        ModelBytes: CoreTypes.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("model_bytes_exceeded")>]
        ModelBytesExceeded: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("model_bytes_memory_limit")>]
        ModelBytesMemoryLimit: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("output_memory_allocator_bytes")>]
        OutputMemoryAllocatorBytes: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("peak_model_bytes")>]
        PeakModelBytes: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("assignment_memory_basis")>]
        AssignmentMemoryBasis: string option
        [<System.Text.Json.Serialization.JsonPropertyName("result_type")>]
        ResultType: string
        [<System.Text.Json.Serialization.JsonPropertyName("total_by_field_count")>]
        TotalByFieldCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_over_field_count")>]
        TotalOverFieldCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_partition_field_count")>]
        TotalPartitionFieldCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_status")>]
        CategorizationStatus: CategorizationStatus
        [<System.Text.Json.Serialization.JsonPropertyName("categorized_doc_count")>]
        CategorizedDocCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("dead_category_count")>]
        DeadCategoryCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("failed_category_count")>]
        FailedCategoryCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("frequent_category_count")>]
        FrequentCategoryCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("rare_category_count")>]
        RareCategoryCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("total_category_count")>]
        TotalCategoryCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.Long option
    }

    type JobTimingStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("average_bucket_processing_time_ms")>]
        AverageBucketProcessingTimeMs: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_count")>]
        BucketCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("exponential_average_bucket_processing_time_ms")>]
        ExponentialAverageBucketProcessingTimeMs: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("exponential_average_bucket_processing_time_per_hour_ms")>]
        ExponentialAverageBucketProcessingTimePerHourMs: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("total_bucket_processing_time_ms")>]
        TotalBucketProcessingTimeMs: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("maximum_bucket_processing_time_ms")>]
        MaximumBucketProcessingTimeMs: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_bucket_processing_time_ms")>]
        MinimumBucketProcessingTimeMs: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis> option
    }

    type JobStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("assignment_explanation")>]
        AssignmentExplanation: string option
        [<System.Text.Json.Serialization.JsonPropertyName("data_counts")>]
        DataCounts: DataCounts
        [<System.Text.Json.Serialization.JsonPropertyName("forecasts_stats")>]
        ForecastsStats: JobForecastStatistics
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: string
        [<System.Text.Json.Serialization.JsonPropertyName("model_size_stats")>]
        ModelSizeStats: ModelSizeStats
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: DiscoveryNodeCompact option
        [<System.Text.Json.Serialization.JsonPropertyName("open_time")>]
        OpenTime: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: JobState
        [<System.Text.Json.Serialization.JsonPropertyName("timing_stats")>]
        TimingStats: JobTimingStats
        [<System.Text.Json.Serialization.JsonPropertyName("deleting")>]
        Deleting: bool option
    }

    type TrainedModelPrefixStrings = {
        [<System.Text.Json.Serialization.JsonPropertyName("ingest")>]
        Ingest: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search")>]
        Search: string option
    }

    type ModelPackageConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("create_time")>]
        CreateTime: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_config")>]
        InferenceConfig: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: CoreTypes.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_version")>]
        MinimumVersion: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model_repository")>]
        ModelRepository: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model_type")>]
        ModelType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("packaged_model_id")>]
        PackagedModelId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("platform_architecture")>]
        PlatformArchitecture: string option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix_strings")>]
        PrefixStrings: TrainedModelPrefixStrings option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("sha256")>]
        Sha256: string option
        [<System.Text.Json.Serialization.JsonPropertyName("tags")>]
        Tags: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("vocabulary_file")>]
        VocabularyFile: string option
    }

    type ModelSnapshot = {
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("latest_record_time_stamp")>]
        LatestRecordTimeStamp: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("latest_result_time_stamp")>]
        LatestResultTimeStamp: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_version")>]
        MinVersion: CoreTypes.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("model_size_stats")>]
        ModelSizeStats: ModelSizeStats option
        [<System.Text.Json.Serialization.JsonPropertyName("retain")>]
        Retain: bool
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot_doc_count")>]
        SnapshotDocCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot_id")>]
        SnapshotId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.Long
    }

    [<RequireQualifiedAccess>]
    type SnapshotUpgradeState =
        | LoadingOldState
        | SavingNewState
        | Stopped
        | Failed

    type ModelSnapshotUpgrade = {
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot_id")>]
        SnapshotId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: SnapshotUpgradeState
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: DiscoveryNode
        [<System.Text.Json.Serialization.JsonPropertyName("assignment_explanation")>]
        AssignmentExplanation: string
    }

    type OverallBucketJob = {
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("max_anomaly_score")>]
        MaxAnomalyScore: CoreTypes.Double
    }

    type OverallBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_span")>]
        BucketSpan: CoreTypes.DurationValue<CoreTypes.UnitSeconds>
        [<System.Text.Json.Serialization.JsonPropertyName("is_interim")>]
        IsInterim: bool
        [<System.Text.Json.Serialization.JsonPropertyName("jobs")>]
        Jobs: OverallBucketJob list
        [<System.Text.Json.Serialization.JsonPropertyName("overall_score")>]
        OverallScore: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("result_type")>]
        ResultType: string
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp_string")>]
        TimestampString: CoreTypes.DateTime option
    }

    type Page = {
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        From: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: CoreTypes.Integer option
    }

    [<RequireQualifiedAccess>]
    type RoutingState =
        | Failed
        | Started
        | Starting
        | Stopped
        | Stopping

    type TotalFeatureImportanceStatistics = {
        [<System.Text.Json.Serialization.JsonPropertyName("mean_magnitude")>]
        MeanMagnitude: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("min")>]
        Min: CoreTypes.Integer
    }

    type TotalFeatureImportanceClass = {
        [<System.Text.Json.Serialization.JsonPropertyName("class_name")>]
        ClassName: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("importance")>]
        Importance: TotalFeatureImportanceStatistics list
    }

    type TotalFeatureImportance = {
        [<System.Text.Json.Serialization.JsonPropertyName("feature_name")>]
        FeatureName: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("importance")>]
        Importance: TotalFeatureImportanceStatistics list
        [<System.Text.Json.Serialization.JsonPropertyName("classes")>]
        Classes: TotalFeatureImportanceClass list
    }

    type TrainedModelAssignmentRoutingTable = {
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string option
        [<System.Text.Json.Serialization.JsonPropertyName("routing_state")>]
        RoutingState: RoutingState
        [<System.Text.Json.Serialization.JsonPropertyName("current_allocations")>]
        CurrentAllocations: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("target_allocations")>]
        TargetAllocations: CoreTypes.Integer
    }

    [<RequireQualifiedAccess>]
    type TrainingPriority =
        | Normal
        | Low

    type TrainedModelAssignmentTaskParameters = {
        [<System.Text.Json.Serialization.JsonPropertyName("model_bytes")>]
        ModelBytes: CoreTypes.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("deployment_id")>]
        DeploymentId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("cache_size")>]
        CacheSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_allocations")>]
        NumberOfAllocations: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("priority")>]
        Priority: TrainingPriority
        [<System.Text.Json.Serialization.JsonPropertyName("per_deployment_memory_bytes")>]
        PerDeploymentMemoryBytes: CoreTypes.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("per_allocation_memory_bytes")>]
        PerAllocationMemoryBytes: CoreTypes.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("queue_capacity")>]
        QueueCapacity: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("threads_per_allocation")>]
        ThreadsPerAllocation: CoreTypes.Integer
    }

    type TrainedModelAssignment = {
        [<System.Text.Json.Serialization.JsonPropertyName("adaptive_allocations")>]
        AdaptiveAllocations: AdaptiveAllocationsSettings option option
        [<System.Text.Json.Serialization.JsonPropertyName("assignment_state")>]
        AssignmentState: DeploymentAssignmentState
        [<System.Text.Json.Serialization.JsonPropertyName("max_assigned_allocations")>]
        MaxAssignedAllocations: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string option
        [<System.Text.Json.Serialization.JsonPropertyName("routing_table")>]
        RoutingTable: Map<string, TrainedModelAssignmentRoutingTable>
        [<System.Text.Json.Serialization.JsonPropertyName("start_time")>]
        StartTime: CoreTypes.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("task_parameters")>]
        TaskParameters: TrainedModelAssignmentTaskParameters
    }

    type TrainedModelAssignmentRoutingStateAndReason = {
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string option
        [<System.Text.Json.Serialization.JsonPropertyName("routing_state")>]
        RoutingState: RoutingState
    }

    [<RequireQualifiedAccess>]
    type TrainedModelType =
        | TreeEnsemble
        | LangIdent
        | Pytorch

    type TrainedModelConfigInput = {
        [<System.Text.Json.Serialization.JsonPropertyName("field_names")>]
        FieldNames: CoreTypes.Field list
    }

    type TrainedModelConfigMetadata = {
        [<System.Text.Json.Serialization.JsonPropertyName("model_aliases")>]
        ModelAliases: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_importance_baseline")>]
        FeatureImportanceBaseline: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("hyperparameters")>]
        Hyperparameters: Hyperparameter list option
        [<System.Text.Json.Serialization.JsonPropertyName("total_feature_importance")>]
        TotalFeatureImportance: TotalFeatureImportance list option
    }

    type TrainedModelLocationIndex = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.IndexName
    }

    type TrainedModelLocation = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: TrainedModelLocationIndex
    }

    type TrainedModelConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("model_type")>]
        ModelType: TrainedModelType option
        [<System.Text.Json.Serialization.JsonPropertyName("tags")>]
        Tags: string list
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("compressed_definition")>]
        CompressedDefinition: string option
        [<System.Text.Json.Serialization.JsonPropertyName("created_by")>]
        CreatedBy: string option
        [<System.Text.Json.Serialization.JsonPropertyName("create_time")>]
        CreateTime: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("default_field_map")>]
        DefaultFieldMap: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("estimated_heap_memory_usage_bytes")>]
        EstimatedHeapMemoryUsageBytes: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("estimated_operations")>]
        EstimatedOperations: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("fully_defined")>]
        FullyDefined: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_config")>]
        InferenceConfig: InferenceConfigCreateContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("input")>]
        Input: TrainedModelConfigInput
        [<System.Text.Json.Serialization.JsonPropertyName("license_level")>]
        LicenseLevel: string option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: TrainedModelConfigMetadata option
        [<System.Text.Json.Serialization.JsonPropertyName("model_size_bytes")>]
        ModelSizeBytes: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("model_package")>]
        ModelPackage: ModelPackageConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("location")>]
        Location: TrainedModelLocation option
        [<System.Text.Json.Serialization.JsonPropertyName("platform_architecture")>]
        PlatformArchitecture: string option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix_strings")>]
        PrefixStrings: TrainedModelPrefixStrings option
    }

    type TrainedModelDeploymentAllocationStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("allocation_count")>]
        AllocationCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: DeploymentAllocationState
        [<System.Text.Json.Serialization.JsonPropertyName("target_allocation_count")>]
        TargetAllocationCount: CoreTypes.Integer
    }

    type TrainedModelDeploymentNodesStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("average_inference_time_ms")>]
        AverageInferenceTimeMs: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("average_inference_time_ms_last_minute")>]
        AverageInferenceTimeMsLastMinute: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("average_inference_time_ms_excluding_cache_hits")>]
        AverageInferenceTimeMsExcludingCacheHits: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("error_count")>]
        ErrorCount: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_count")>]
        InferenceCount: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_cache_hit_count")>]
        InferenceCacheHitCount: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_cache_hit_count_last_minute")>]
        InferenceCacheHitCountLastMinute: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("last_access")>]
        LastAccess: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: DiscoveryNode option
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_allocations")>]
        NumberOfAllocations: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_pending_requests")>]
        NumberOfPendingRequests: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("peak_throughput_per_minute")>]
        PeakThroughputPerMinute: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("rejected_execution_count")>]
        RejectedExecutionCount: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("routing_state")>]
        RoutingState: TrainedModelAssignmentRoutingStateAndReason
        [<System.Text.Json.Serialization.JsonPropertyName("start_time")>]
        StartTime: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("threads_per_allocation")>]
        ThreadsPerAllocation: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("throughput_last_minute")>]
        ThroughputLastMinute: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("timeout_count")>]
        TimeoutCount: CoreTypes.Integer option
    }

    type TrainedModelDeploymentStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("adaptive_allocations")>]
        AdaptiveAllocations: AdaptiveAllocationsSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("allocation_status")>]
        AllocationStatus: TrainedModelDeploymentAllocationStatus option
        [<System.Text.Json.Serialization.JsonPropertyName("cache_size")>]
        CacheSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("deployment_id")>]
        DeploymentId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("error_count")>]
        ErrorCount: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_count")>]
        InferenceCount: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("nodes")>]
        Nodes: TrainedModelDeploymentNodesStats list
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_allocations")>]
        NumberOfAllocations: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("peak_throughput_per_minute")>]
        PeakThroughputPerMinute: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("priority")>]
        Priority: TrainingPriority
        [<System.Text.Json.Serialization.JsonPropertyName("queue_capacity")>]
        QueueCapacity: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("rejected_execution_count")>]
        RejectedExecutionCount: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string option
        [<System.Text.Json.Serialization.JsonPropertyName("start_time")>]
        StartTime: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: DeploymentAssignmentState option
        [<System.Text.Json.Serialization.JsonPropertyName("threads_per_allocation")>]
        ThreadsPerAllocation: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("timeout_count")>]
        TimeoutCount: CoreTypes.Integer option
    }

    type TrainedModelInferenceStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("cache_miss_count")>]
        CacheMissCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("failure_count")>]
        FailureCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("inference_count")>]
        InferenceCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("missing_all_fields_count")>]
        MissingAllFieldsCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.EpochTime<CoreTypes.UnitMillis>
    }

    type TrainedModelSizeStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("model_size_bytes")>]
        ModelSizeBytes: CoreTypes.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("required_native_memory_bytes")>]
        RequiredNativeMemoryBytes: CoreTypes.ByteSize
    }

    type TrainedModelStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("deployment_stats")>]
        DeploymentStats: TrainedModelDeploymentStats option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_stats")>]
        InferenceStats: TrainedModelInferenceStats option
        [<System.Text.Json.Serialization.JsonPropertyName("ingest")>]
        Ingest: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("model_size_stats")>]
        ModelSizeStats: TrainedModelSizeStats
        [<System.Text.Json.Serialization.JsonPropertyName("pipeline_count")>]
        PipelineCount: CoreTypes.Integer
    }

    type TransformAuthorization = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: ApiKeyAuthorization option
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("service_account")>]
        ServiceAccount: string option
    }


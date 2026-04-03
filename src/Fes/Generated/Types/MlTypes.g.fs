// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module MlTypes =

    type AdaptiveAllocationsSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
        [<System.Text.Json.Serialization.JsonPropertyName("min_number_of_allocations")>]
        MinNumberOfAllocations: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_number_of_allocations")>]
        MaxNumberOfAllocations: Types.Integer option
    }

    type CategorizationAnalyzerDefinition = {
        [<System.Text.Json.Serialization.JsonPropertyName("char_filter")>]
        CharFilter: TypesAnalysis.CharFilter list option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: TypesAnalysis.TokenFilter list option
        [<System.Text.Json.Serialization.JsonPropertyName("tokenizer")>]
        Tokenizer: TypesAnalysis.Tokenizer option
    }

    [<RequireQualifiedAccess>]
    type CategorizationAnalyzer =
        | String of string
        | CategorizationAnalyzerDefinition of MlTypes.CategorizationAnalyzerDefinition

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
        AppliesTo: MlTypes.AppliesTo
        [<System.Text.Json.Serialization.JsonPropertyName("operator")>]
        Operator: MlTypes.ConditionOperator
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: Types.Double
    }

    [<RequireQualifiedAccess>]
    type FilterType =
        | Include
        | Exclude

    type FilterRef = {
        [<System.Text.Json.Serialization.JsonPropertyName("filter_id")>]
        FilterId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("filter_type")>]
        FilterType: MlTypes.FilterType option
    }

    type DetectionRule = {
        [<System.Text.Json.Serialization.JsonPropertyName("actions")>]
        Actions: MlTypes.RuleAction list option
        [<System.Text.Json.Serialization.JsonPropertyName("conditions")>]
        Conditions: MlTypes.RuleCondition list option
        [<System.Text.Json.Serialization.JsonPropertyName("scope")>]
        Scope: Map<Types.Field, MlTypes.FilterRef> option
    }

    [<RequireQualifiedAccess>]
    type ExcludeFrequent =
        | All
        | None
        | By
        | Over

    type Detector = {
        [<System.Text.Json.Serialization.JsonPropertyName("by_field_name")>]
        ByFieldName: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("custom_rules")>]
        CustomRules: MlTypes.DetectionRule list option
        [<System.Text.Json.Serialization.JsonPropertyName("detector_description")>]
        DetectorDescription: string option
        [<System.Text.Json.Serialization.JsonPropertyName("detector_index")>]
        DetectorIndex: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("exclude_frequent")>]
        ExcludeFrequent: MlTypes.ExcludeFrequent option
        [<System.Text.Json.Serialization.JsonPropertyName("field_name")>]
        FieldName: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("function")>]
        Function: string option
        [<System.Text.Json.Serialization.JsonPropertyName("over_field_name")>]
        OverFieldName: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("partition_field_name")>]
        PartitionFieldName: Types.Field option
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
        BucketSpan: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_analyzer")>]
        CategorizationAnalyzer: MlTypes.CategorizationAnalyzer option
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_field_name")>]
        CategorizationFieldName: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_filters")>]
        CategorizationFilters: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("detectors")>]
        Detectors: MlTypes.Detector list
        [<System.Text.Json.Serialization.JsonPropertyName("influencers")>]
        Influencers: Types.Field list option
        [<System.Text.Json.Serialization.JsonPropertyName("latency")>]
        Latency: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("model_prune_window")>]
        ModelPruneWindow: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("multivariate_by_fields")>]
        MultivariateByFields: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("per_partition_categorization")>]
        PerPartitionCategorization: MlTypes.PerPartitionCategorization option
        [<System.Text.Json.Serialization.JsonPropertyName("summary_count_field_name")>]
        SummaryCountFieldName: Types.Field option
    }

    type DetectorRead = {
        [<System.Text.Json.Serialization.JsonPropertyName("function")>]
        Function: string
        [<System.Text.Json.Serialization.JsonPropertyName("by_field_name")>]
        ByFieldName: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("custom_rules")>]
        CustomRules: MlTypes.DetectionRule list option
        [<System.Text.Json.Serialization.JsonPropertyName("detector_description")>]
        DetectorDescription: string option
        [<System.Text.Json.Serialization.JsonPropertyName("detector_index")>]
        DetectorIndex: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("exclude_frequent")>]
        ExcludeFrequent: MlTypes.ExcludeFrequent option
        [<System.Text.Json.Serialization.JsonPropertyName("field_name")>]
        FieldName: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("over_field_name")>]
        OverFieldName: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("partition_field_name")>]
        PartitionFieldName: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("use_null")>]
        UseNull: bool option
    }

    type AnalysisConfigRead = {
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_span")>]
        BucketSpan: Types.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("detectors")>]
        Detectors: MlTypes.DetectorRead list
        [<System.Text.Json.Serialization.JsonPropertyName("influencers")>]
        Influencers: Types.Field list
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_analyzer")>]
        CategorizationAnalyzer: MlTypes.CategorizationAnalyzer option
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_field_name")>]
        CategorizationFieldName: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_filters")>]
        CategorizationFilters: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("latency")>]
        Latency: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("model_prune_window")>]
        ModelPruneWindow: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("multivariate_by_fields")>]
        MultivariateByFields: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("per_partition_categorization")>]
        PerPartitionCategorization: MlTypes.PerPartitionCategorization option
        [<System.Text.Json.Serialization.JsonPropertyName("summary_count_field_name")>]
        SummaryCountFieldName: Types.Field option
    }

    type AnalysisLimits = {
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_examples_limit")>]
        CategorizationExamplesLimit: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("model_memory_limit")>]
        ModelMemoryLimit: Types.ByteSize option
    }

    type AnalysisMemoryLimit = {
        [<System.Text.Json.Serialization.JsonPropertyName("model_memory_limit")>]
        ModelMemoryLimit: string
    }

    type AnomalyExplanation = {
        [<System.Text.Json.Serialization.JsonPropertyName("anomaly_characteristics_impact")>]
        AnomalyCharacteristicsImpact: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("anomaly_length")>]
        AnomalyLength: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("anomaly_type")>]
        AnomalyType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("high_variance_penalty")>]
        HighVariancePenalty: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("incomplete_bucket_penalty")>]
        IncompleteBucketPenalty: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("lower_confidence_bound")>]
        LowerConfidenceBound: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("multi_bucket_impact")>]
        MultiBucketImpact: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("single_bucket_impact")>]
        SingleBucketImpact: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("typical_value")>]
        TypicalValue: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("upper_confidence_bound")>]
        UpperConfidenceBound: Types.Double option
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
        Actual: Types.Double list option
        [<System.Text.Json.Serialization.JsonPropertyName("by_field_name")>]
        ByFieldName: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("by_field_value")>]
        ByFieldValue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("correlated_by_field_value")>]
        CorrelatedByFieldValue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("field_name")>]
        FieldName: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("function")>]
        Function: string option
        [<System.Text.Json.Serialization.JsonPropertyName("function_description")>]
        FunctionDescription: string option
        [<System.Text.Json.Serialization.JsonPropertyName("geo_results")>]
        GeoResults: MlTypes.GeoResults option
        [<System.Text.Json.Serialization.JsonPropertyName("influencers")>]
        Influencers: MlTypes.Influence list option
        [<System.Text.Json.Serialization.JsonPropertyName("over_field_name")>]
        OverFieldName: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("over_field_value")>]
        OverFieldValue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("partition_field_name")>]
        PartitionFieldName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("partition_field_value")>]
        PartitionFieldValue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("probability")>]
        Probability: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("typical")>]
        Typical: Types.Double list option
    }

    type Anomaly = {
        [<System.Text.Json.Serialization.JsonPropertyName("actual")>]
        Actual: Types.Double list option
        [<System.Text.Json.Serialization.JsonPropertyName("anomaly_score_explanation")>]
        AnomalyScoreExplanation: MlTypes.AnomalyExplanation option
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_span")>]
        BucketSpan: Types.DurationValue<Types.UnitSeconds>
        [<System.Text.Json.Serialization.JsonPropertyName("by_field_name")>]
        ByFieldName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("by_field_value")>]
        ByFieldValue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("causes")>]
        Causes: MlTypes.AnomalyCause list option
        [<System.Text.Json.Serialization.JsonPropertyName("detector_index")>]
        DetectorIndex: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("field_name")>]
        FieldName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("function")>]
        Function: string option
        [<System.Text.Json.Serialization.JsonPropertyName("function_description")>]
        FunctionDescription: string option
        [<System.Text.Json.Serialization.JsonPropertyName("geo_results")>]
        GeoResults: MlTypes.GeoResults option
        [<System.Text.Json.Serialization.JsonPropertyName("influencers")>]
        Influencers: MlTypes.Influence list option
        [<System.Text.Json.Serialization.JsonPropertyName("initial_record_score")>]
        InitialRecordScore: Types.Double
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
        Probability: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("record_score")>]
        RecordScore: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("result_type")>]
        ResultType: string
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("typical")>]
        Typical: Types.Double list option
    }

    type ApiKeyAuthorization = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: string
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
    }

    type BucketInfluencer = {
        [<System.Text.Json.Serialization.JsonPropertyName("anomaly_score")>]
        AnomalyScore: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_span")>]
        BucketSpan: Types.DurationValue<Types.UnitSeconds>
        [<System.Text.Json.Serialization.JsonPropertyName("influencer_field_name")>]
        InfluencerFieldName: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("initial_anomaly_score")>]
        InitialAnomalyScore: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("is_interim")>]
        IsInterim: bool
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("probability")>]
        Probability: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("raw_anomaly_score")>]
        RawAnomalyScore: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("result_type")>]
        ResultType: string
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp_string")>]
        TimestampString: Types.DateTime option
    }

    type BucketSummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("anomaly_score")>]
        AnomalyScore: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_influencers")>]
        BucketInfluencers: MlTypes.BucketInfluencer list
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_span")>]
        BucketSpan: Types.DurationValue<Types.UnitSeconds>
        [<System.Text.Json.Serialization.JsonPropertyName("event_count")>]
        EventCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("initial_anomaly_score")>]
        InitialAnomalyScore: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("is_interim")>]
        IsInterim: bool
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("processing_time_ms")>]
        ProcessingTimeMs: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("result_type")>]
        ResultType: string
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp_string")>]
        TimestampString: Types.DateTime option
    }

    type CalendarEvent = {
        [<System.Text.Json.Serialization.JsonPropertyName("calendar_id")>]
        CalendarId: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("event_id")>]
        EventId: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string
        [<System.Text.Json.Serialization.JsonPropertyName("end_time")>]
        EndTime: Types.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("start_time")>]
        StartTime: Types.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("skip_result")>]
        SkipResult: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("skip_model_update")>]
        SkipModelUpdate: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("force_time_shift")>]
        ForceTimeShift: Types.Integer option
    }

    [<RequireQualifiedAccess>]
    type CategorizationStatus =
        | Ok
        | Warn

    type Category = {
        [<System.Text.Json.Serialization.JsonPropertyName("category_id")>]
        CategoryId: Types.Ulong
        [<System.Text.Json.Serialization.JsonPropertyName("examples")>]
        Examples: string list
        [<System.Text.Json.Serialization.JsonPropertyName("grok_pattern")>]
        GrokPattern: Types.GrokPattern option
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("max_matching_length")>]
        MaxMatchingLength: Types.Ulong
        [<System.Text.Json.Serialization.JsonPropertyName("partition_field_name")>]
        PartitionFieldName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("partition_field_value")>]
        PartitionFieldValue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("regex")>]
        Regex: string
        [<System.Text.Json.Serialization.JsonPropertyName("terms")>]
        Terms: string
        [<System.Text.Json.Serialization.JsonPropertyName("num_matches")>]
        NumMatches: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("preferred_to_categories")>]
        PreferredToCategories: Types.Id list option
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
        Mode: MlTypes.ChunkingMode
        [<System.Text.Json.Serialization.JsonPropertyName("time_span")>]
        TimeSpan: Types.Duration option
    }

    type ClassificationInferenceOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_classes")>]
        NumTopClasses: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_feature_importance_values")>]
        NumTopFeatureImportanceValues: Types.Integer option
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
        MaxSequenceLength: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("span")>]
        Span: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("truncate")>]
        Truncate: MlTypes.TokenizationTruncate option
        [<System.Text.Json.Serialization.JsonPropertyName("with_special_tokens")>]
        WithSpecialTokens: bool option
    }

    /// Custom metadata about the job
    type CustomSettings = System.Text.Json.JsonElement

    type DataCounts = {
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_count")>]
        BucketCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("earliest_record_timestamp")>]
        EarliestRecordTimestamp: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("empty_bucket_count")>]
        EmptyBucketCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("input_bytes")>]
        InputBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("input_field_count")>]
        InputFieldCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("input_record_count")>]
        InputRecordCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("invalid_date_count")>]
        InvalidDateCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("last_data_time")>]
        LastDataTime: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("latest_empty_bucket_timestamp")>]
        LatestEmptyBucketTimestamp: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("latest_record_timestamp")>]
        LatestRecordTimestamp: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("latest_sparse_bucket_timestamp")>]
        LatestSparseBucketTimestamp: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("latest_bucket_timestamp")>]
        LatestBucketTimestamp: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("log_time")>]
        LogTime: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("missing_field_count")>]
        MissingFieldCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("out_of_order_timestamp_count")>]
        OutOfOrderTimestampCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("processed_field_count")>]
        ProcessedFieldCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("processed_record_count")>]
        ProcessedRecordCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("sparse_bucket_count")>]
        SparseBucketCount: Types.Long
    }

    type DataDescription = {
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("time_field")>]
        TimeField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("time_format")>]
        TimeFormat: string option
        [<System.Text.Json.Serialization.JsonPropertyName("field_delimiter")>]
        FieldDelimiter: string option
    }

    type DatafeedAuthorization = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: MlTypes.ApiKeyAuthorization option
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("service_account")>]
        ServiceAccount: string option
    }

    type DelayedDataCheckConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("check_window")>]
        CheckWindow: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
    }

    type Datafeed = {
        [<System.Text.Json.Serialization.JsonPropertyName("aggregations")>]
        Aggregations: Map<string, TypesAggregations.AggregationContainer> option
        [<System.Text.Json.Serialization.JsonPropertyName("authorization")>]
        Authorization: MlTypes.DatafeedAuthorization option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_config")>]
        ChunkingConfig: MlTypes.ChunkingConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("datafeed_id")>]
        DatafeedId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("frequency")>]
        Frequency: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: string list
        [<System.Text.Json.Serialization.JsonPropertyName("indexes")>]
        Indexes: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("max_empty_searches")>]
        MaxEmptySearches: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: TypesQueryDsl.QueryContainer
        [<System.Text.Json.Serialization.JsonPropertyName("query_delay")>]
        QueryDelay: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("script_fields")>]
        ScriptFields: Map<string, Types.ScriptField> option
        [<System.Text.Json.Serialization.JsonPropertyName("scroll_size")>]
        ScrollSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("delayed_data_check_config")>]
        DelayedDataCheckConfig: MlTypes.DelayedDataCheckConfig
        [<System.Text.Json.Serialization.JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: TypesMapping.RuntimeFields option
        [<System.Text.Json.Serialization.JsonPropertyName("indices_options")>]
        IndicesOptions: Types.IndicesOptions option
    }

    type DatafeedConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("aggregations")>]
        Aggregations: Map<string, TypesAggregations.AggregationContainer> option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_config")>]
        ChunkingConfig: MlTypes.ChunkingConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("datafeed_id")>]
        DatafeedId: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("delayed_data_check_config")>]
        DelayedDataCheckConfig: MlTypes.DelayedDataCheckConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("frequency")>]
        Frequency: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: Types.Indices option
        [<System.Text.Json.Serialization.JsonPropertyName("indices_options")>]
        IndicesOptions: Types.IndicesOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("max_empty_searches")>]
        MaxEmptySearches: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: TypesQueryDsl.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("query_delay")>]
        QueryDelay: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: TypesMapping.RuntimeFields option
        [<System.Text.Json.Serialization.JsonPropertyName("script_fields")>]
        ScriptFields: Map<string, Types.ScriptField> option
        [<System.Text.Json.Serialization.JsonPropertyName("scroll_size")>]
        ScrollSize: Types.Integer option
    }

    type RunningStateSearchInterval = {
        [<System.Text.Json.Serialization.JsonPropertyName("end")>]
        End: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("end_ms")>]
        EndMs: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("start")>]
        Start: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("start_ms")>]
        StartMs: Types.DurationValue<Types.UnitMillis>
    }

    type DatafeedRunningState = {
        [<System.Text.Json.Serialization.JsonPropertyName("real_time_configured")>]
        RealTimeConfigured: bool
        [<System.Text.Json.Serialization.JsonPropertyName("real_time_running")>]
        RealTimeRunning: bool
        [<System.Text.Json.Serialization.JsonPropertyName("search_interval")>]
        SearchInterval: MlTypes.RunningStateSearchInterval option
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
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("ephemeral_id")>]
        EphemeralId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("transport_address")>]
        TransportAddress: Types.TransportAddress
        [<System.Text.Json.Serialization.JsonPropertyName("attributes")>]
        Attributes: Map<string, string>
    }

    type ExponentialAverageCalculationContext = {
        [<System.Text.Json.Serialization.JsonPropertyName("incremental_metric_value_ms")>]
        IncrementalMetricValueMs: Types.DurationValue<Types.UnitFloatMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("latest_timestamp")>]
        LatestTimestamp: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("previous_exponential_average_ms")>]
        PreviousExponentialAverageMs: Types.DurationValue<Types.UnitFloatMillis> option
    }

    type DatafeedTimingStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_count")>]
        BucketCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("exponential_average_search_time_per_hour_ms")>]
        ExponentialAverageSearchTimePerHourMs: Types.DurationValue<Types.UnitFloatMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("exponential_average_calculation_context")>]
        ExponentialAverageCalculationContext: MlTypes.ExponentialAverageCalculationContext option
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("search_count")>]
        SearchCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_search_time_ms")>]
        TotalSearchTimeMs: Types.DurationValue<Types.UnitFloatMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("average_search_time_per_bucket_ms")>]
        AverageSearchTimePerBucketMs: Types.DurationValue<Types.UnitFloatMillis> option
    }

    type DatafeedStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("assignment_explanation")>]
        AssignmentExplanation: string option
        [<System.Text.Json.Serialization.JsonPropertyName("datafeed_id")>]
        DatafeedId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: MlTypes.DiscoveryNodeCompact option
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: MlTypes.DatafeedState
        [<System.Text.Json.Serialization.JsonPropertyName("timing_stats")>]
        TimingStats: MlTypes.DatafeedTimingStats option
        [<System.Text.Json.Serialization.JsonPropertyName("running_state")>]
        RunningState: MlTypes.DatafeedRunningState option
    }

    type DataframeAnalysisFeatureProcessorFrequencyEncoding = {
        [<System.Text.Json.Serialization.JsonPropertyName("feature_name")>]
        FeatureName: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("frequency_map")>]
        FrequencyMap: Map<string, Types.Double>
    }

    type DataframeAnalysisFeatureProcessorMultiEncoding = {
        [<System.Text.Json.Serialization.JsonPropertyName("processors")>]
        Processors: Types.Integer list
    }

    type DataframeAnalysisFeatureProcessorNGramEncoding = {
        [<System.Text.Json.Serialization.JsonPropertyName("feature_prefix")>]
        FeaturePrefix: string option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("length")>]
        Length: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("n_grams")>]
        NGrams: Types.Integer list
        [<System.Text.Json.Serialization.JsonPropertyName("start")>]
        Start: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("custom")>]
        Custom: bool option
    }

    type DataframeAnalysisFeatureProcessorOneHotEncoding = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("hot_map")>]
        HotMap: string
    }

    type DataframeAnalysisFeatureProcessorTargetMeanEncoding = {
        [<System.Text.Json.Serialization.JsonPropertyName("default_value")>]
        DefaultValue: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("feature_name")>]
        FeatureName: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("target_map")>]
        TargetMap: Map<string, System.Text.Json.JsonElement>
    }

    [<RequireQualifiedAccess>]
    type DataframeAnalysisFeatureProcessor =
        | FrequencyEncoding of MlTypes.DataframeAnalysisFeatureProcessorFrequencyEncoding
        | MultiEncoding of MlTypes.DataframeAnalysisFeatureProcessorMultiEncoding
        | NGramEncoding of MlTypes.DataframeAnalysisFeatureProcessorNGramEncoding
        | OneHotEncoding of MlTypes.DataframeAnalysisFeatureProcessorOneHotEncoding
        | TargetMeanEncoding of MlTypes.DataframeAnalysisFeatureProcessorTargetMeanEncoding

    type DataframeAnalysis = {
        [<System.Text.Json.Serialization.JsonPropertyName("alpha")>]
        Alpha: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("dependent_variable")>]
        DependentVariable: string
        [<System.Text.Json.Serialization.JsonPropertyName("downsample_factor")>]
        DownsampleFactor: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("early_stopping_enabled")>]
        EarlyStoppingEnabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("eta")>]
        Eta: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("eta_growth_rate_per_tree")>]
        EtaGrowthRatePerTree: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_bag_fraction")>]
        FeatureBagFraction: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_processors")>]
        FeatureProcessors: MlTypes.DataframeAnalysisFeatureProcessor list option
        [<System.Text.Json.Serialization.JsonPropertyName("gamma")>]
        Gamma: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("lambda")>]
        Lambda: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("max_optimization_rounds_per_hyperparameter")>]
        MaxOptimizationRoundsPerHyperparameter: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_trees")>]
        MaxTrees: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_feature_importance_values")>]
        NumTopFeatureImportanceValues: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("prediction_field_name")>]
        PredictionFieldName: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("randomize_seed")>]
        RandomizeSeed: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("soft_tree_depth_limit")>]
        SoftTreeDepthLimit: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("soft_tree_depth_tolerance")>]
        SoftTreeDepthTolerance: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("training_percent")>]
        TrainingPercent: Types.Percentage option
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
        NumTopClasses: Types.Integer option
    }

    type DataframeAnalysisOutlierDetection = {
        [<System.Text.Json.Serialization.JsonPropertyName("compute_feature_influence")>]
        ComputeFeatureInfluence: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_influence_threshold")>]
        FeatureInfluenceThreshold: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("method")>]
        Method: string option
        [<System.Text.Json.Serialization.JsonPropertyName("n_neighbors")>]
        NNeighbors: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("outlier_fraction")>]
        OutlierFraction: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("standardization_enabled")>]
        StandardizationEnabled: bool option
    }

    type DataframeAnalysisRegression = {
        [<System.Text.Json.Serialization.JsonPropertyName("loss_function")>]
        LossFunction: string option
        [<System.Text.Json.Serialization.JsonPropertyName("loss_function_parameter")>]
        LossFunctionParameter: Types.Double option
    }

    [<RequireQualifiedAccess>]
    type DataframeAnalysisContainer =
        | Classification of MlTypes.DataframeAnalysisClassification
        | OutlierDetection of MlTypes.DataframeAnalysisOutlierDetection
        | Regression of MlTypes.DataframeAnalysisRegression

    type Hyperparameters = {
        [<System.Text.Json.Serialization.JsonPropertyName("alpha")>]
        Alpha: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("lambda")>]
        Lambda: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("gamma")>]
        Gamma: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("eta")>]
        Eta: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("eta_growth_rate_per_tree")>]
        EtaGrowthRatePerTree: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_bag_fraction")>]
        FeatureBagFraction: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("downsample_factor")>]
        DownsampleFactor: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("max_attempts_to_add_tree")>]
        MaxAttemptsToAddTree: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_optimization_rounds_per_hyperparameter")>]
        MaxOptimizationRoundsPerHyperparameter: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_trees")>]
        MaxTrees: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("num_folds")>]
        NumFolds: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("num_splits_per_feature")>]
        NumSplitsPerFeature: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("soft_tree_depth_limit")>]
        SoftTreeDepthLimit: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("soft_tree_depth_tolerance")>]
        SoftTreeDepthTolerance: Types.Double option
    }

    type TimingStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("elapsed_time")>]
        ElapsedTime: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("iteration_time")>]
        IterationTime: Types.DurationValue<Types.UnitMillis> option
    }

    type ValidationLoss = {
        [<System.Text.Json.Serialization.JsonPropertyName("fold_values")>]
        FoldValues: string list
        [<System.Text.Json.Serialization.JsonPropertyName("loss_type")>]
        LossType: string
    }

    type DataframeAnalyticsStatsHyperparameters = {
        [<System.Text.Json.Serialization.JsonPropertyName("hyperparameters")>]
        Hyperparameters: MlTypes.Hyperparameters
        [<System.Text.Json.Serialization.JsonPropertyName("iteration")>]
        Iteration: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("timing_stats")>]
        TimingStats: MlTypes.TimingStats
        [<System.Text.Json.Serialization.JsonPropertyName("validation_loss")>]
        ValidationLoss: MlTypes.ValidationLoss
    }

    type OutlierDetectionParameters = {
        [<System.Text.Json.Serialization.JsonPropertyName("compute_feature_influence")>]
        ComputeFeatureInfluence: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_influence_threshold")>]
        FeatureInfluenceThreshold: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("method")>]
        Method: string option
        [<System.Text.Json.Serialization.JsonPropertyName("n_neighbors")>]
        NNeighbors: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("outlier_fraction")>]
        OutlierFraction: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("standardization_enabled")>]
        StandardizationEnabled: bool option
    }

    type DataframeAnalyticsStatsOutlierDetection = {
        [<System.Text.Json.Serialization.JsonPropertyName("parameters")>]
        Parameters: MlTypes.OutlierDetectionParameters
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("timing_stats")>]
        TimingStats: MlTypes.TimingStats
    }

    [<RequireQualifiedAccess>]
    type DataframeAnalyticsStatsContainer =
        | ClassificationStats of MlTypes.DataframeAnalyticsStatsHyperparameters
        | OutlierDetectionStats of MlTypes.DataframeAnalyticsStatsOutlierDetection
        | RegressionStats of MlTypes.DataframeAnalyticsStatsHyperparameters

    type DataframeAnalyticsStatsDataCounts = {
        [<System.Text.Json.Serialization.JsonPropertyName("skipped_docs_count")>]
        SkippedDocsCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("test_docs_count")>]
        TestDocsCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("training_docs_count")>]
        TrainingDocsCount: Types.Integer
    }

    type DataframeAnalyticsStatsMemoryUsage = {
        [<System.Text.Json.Serialization.JsonPropertyName("memory_reestimate_bytes")>]
        MemoryReestimateBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("peak_usage_bytes")>]
        PeakUsageBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: string
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.EpochTime<Types.UnitMillis> option
    }

    type DataframeAnalyticsStatsProgress = {
        [<System.Text.Json.Serialization.JsonPropertyName("phase")>]
        Phase: string
        [<System.Text.Json.Serialization.JsonPropertyName("progress_percent")>]
        ProgressPercent: Types.Integer
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
        AnalysisStats: MlTypes.DataframeAnalyticsStatsContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("assignment_explanation")>]
        AssignmentExplanation: string option
        [<System.Text.Json.Serialization.JsonPropertyName("data_counts")>]
        DataCounts: MlTypes.DataframeAnalyticsStatsDataCounts
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("memory_usage")>]
        MemoryUsage: MlTypes.DataframeAnalyticsStatsMemoryUsage
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: Types.NodeAttributes option
        [<System.Text.Json.Serialization.JsonPropertyName("progress")>]
        Progress: MlTypes.DataframeAnalyticsStatsProgress list
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: MlTypes.DataframeState
    }

    type DataframeAnalyticsAuthorization = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: MlTypes.ApiKeyAuthorization option
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("service_account")>]
        ServiceAccount: string option
    }

    type DataframeAnalyticsDestination = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: Types.Field option
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
        Name: Types.Field
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
        Index: Types.Indices
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: TypesQueryDsl.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: TypesMapping.RuntimeFields option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: MlTypes.DataframeAnalysisAnalyzedFields option
    }

    type DataframeAnalyticsSummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("allow_lazy_start")>]
        AllowLazyStart: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("analysis")>]
        Analysis: MlTypes.DataframeAnalysisContainer
        [<System.Text.Json.Serialization.JsonPropertyName("analyzed_fields")>]
        AnalyzedFields: MlTypes.DataframeAnalysisAnalyzedFields option
        [<System.Text.Json.Serialization.JsonPropertyName("authorization")>]
        Authorization: MlTypes.DataframeAnalyticsAuthorization option
        [<System.Text.Json.Serialization.JsonPropertyName("create_time")>]
        CreateTime: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("dest")>]
        Dest: MlTypes.DataframeAnalyticsDestination
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("max_num_threads")>]
        MaxNumThreads: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("model_memory_limit")>]
        ModelMemoryLimit: string option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: MlTypes.DataframeAnalyticsSource
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: Types.Metadata option
    }

    type DataframeEvaluationClassificationMetricsAucRoc = {
        [<System.Text.Json.Serialization.JsonPropertyName("class_name")>]
        ClassName: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("include_curve")>]
        IncludeCurve: bool option
    }

    type DataframeEvaluationMetrics = {
        [<System.Text.Json.Serialization.JsonPropertyName("auc_roc")>]
        AucRoc: MlTypes.DataframeEvaluationClassificationMetricsAucRoc option
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
        ActualField: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("predicted_field")>]
        PredictedField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("top_classes_field")>]
        TopClassesField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("metrics")>]
        Metrics: MlTypes.DataframeEvaluationClassificationMetrics option
    }

    type DataframeEvaluationOutlierDetectionMetrics = {
        [<System.Text.Json.Serialization.JsonPropertyName("confusion_matrix")>]
        ConfusionMatrix: Map<string, System.Text.Json.JsonElement> option
    }

    type DataframeEvaluationOutlierDetection = {
        [<System.Text.Json.Serialization.JsonPropertyName("actual_field")>]
        ActualField: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("predicted_probability_field")>]
        PredictedProbabilityField: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("metrics")>]
        Metrics: MlTypes.DataframeEvaluationOutlierDetectionMetrics option
    }

    type DataframeEvaluationRegressionMetricsMsle = {
        [<System.Text.Json.Serialization.JsonPropertyName("offset")>]
        Offset: Types.Double option
    }

    type DataframeEvaluationRegressionMetricsHuber = {
        [<System.Text.Json.Serialization.JsonPropertyName("delta")>]
        Delta: Types.Double option
    }

    type DataframeEvaluationRegressionMetrics = {
        [<System.Text.Json.Serialization.JsonPropertyName("mse")>]
        Mse: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("msle")>]
        Msle: MlTypes.DataframeEvaluationRegressionMetricsMsle option
        [<System.Text.Json.Serialization.JsonPropertyName("huber")>]
        Huber: MlTypes.DataframeEvaluationRegressionMetricsHuber option
        [<System.Text.Json.Serialization.JsonPropertyName("r_squared")>]
        RSquared: Map<string, System.Text.Json.JsonElement> option
    }

    type DataframeEvaluationRegression = {
        [<System.Text.Json.Serialization.JsonPropertyName("actual_field")>]
        ActualField: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("predicted_field")>]
        PredictedField: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("metrics")>]
        Metrics: MlTypes.DataframeEvaluationRegressionMetrics option
    }

    [<RequireQualifiedAccess>]
    type DataframeEvaluationContainer =
        | Classification of MlTypes.DataframeEvaluationClassification
        | OutlierDetection of MlTypes.DataframeEvaluationOutlierDetection
        | Regression of MlTypes.DataframeEvaluationRegression

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
        DetectorIndex: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("custom_rules")>]
        CustomRules: MlTypes.DetectionRule list option
    }

    type DiscoveryNodeContent = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("ephemeral_id")>]
        EphemeralId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("transport_address")>]
        TransportAddress: Types.TransportAddress
        [<System.Text.Json.Serialization.JsonPropertyName("external_id")>]
        ExternalId: string
        [<System.Text.Json.Serialization.JsonPropertyName("attributes")>]
        Attributes: Map<string, string>
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: string list
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("min_index_version")>]
        MinIndexVersion: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("max_index_version")>]
        MaxIndexVersion: Types.Integer
    }

    type DiscoveryNode = Map<Types.Id, MlTypes.DiscoveryNodeContent>

    type QueryFeatureExtractor = {
        [<System.Text.Json.Serialization.JsonPropertyName("default_score")>]
        DefaultScore: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_name")>]
        FeatureName: string
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: TypesQueryDsl.QueryContainer
    }

    type FeatureExtractor = MlTypes.QueryFeatureExtractor

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
        | Bert of MlTypes.NlpBertTokenizationConfig
        | BertJa of MlTypes.NlpBertTokenizationConfig
        | Mpnet of MlTypes.NlpBertTokenizationConfig
        | Roberta of MlTypes.NlpRobertaTokenizationConfig
        | XlmRoberta of MlTypes.XlmRobertaTokenizationConfig

    type Vocabulary = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName
    }

    /// Fill mask inference options
    type FillMaskInferenceOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("mask_token")>]
        MaskToken: string option
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_classes")>]
        NumTopClasses: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: MlTypes.TokenizationConfigContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
        [<System.Text.Json.Serialization.JsonPropertyName("vocabulary")>]
        Vocabulary: MlTypes.Vocabulary option
    }

    type NlpTokenizationUpdateOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("truncate")>]
        Truncate: MlTypes.TokenizationTruncate option
        [<System.Text.Json.Serialization.JsonPropertyName("span")>]
        Span: Types.Integer option
    }

    type FillMaskInferenceUpdateOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_classes")>]
        NumTopClasses: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: MlTypes.NlpTokenizationUpdateOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
    }

    type Filter = {
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("filter_id")>]
        FilterId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("items")>]
        Items: string list
    }

    type Hyperparameter = {
        [<System.Text.Json.Serialization.JsonPropertyName("absolute_importance")>]
        AbsoluteImportance: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("relative_importance")>]
        RelativeImportance: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("supplied")>]
        Supplied: bool
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: Types.Double
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
        ResultsField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_feature_importance_values")>]
        NumTopFeatureImportanceValues: Types.Integer option
    }

    /// Text classification configuration options
    type TextClassificationInferenceOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_classes")>]
        NumTopClasses: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: MlTypes.TokenizationConfigContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
        [<System.Text.Json.Serialization.JsonPropertyName("classification_labels")>]
        ClassificationLabels: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("vocabulary")>]
        Vocabulary: MlTypes.Vocabulary option
    }

    /// Zero shot classification configuration options
    type ZeroShotClassificationInferenceOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: MlTypes.TokenizationConfigContainer option
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
        FeatureExtractors: Map<string, MlTypes.FeatureExtractor> list option
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_feature_importance_values")>]
        NumTopFeatureImportanceValues: Types.Integer
    }

    /// Named entity recognition options
    type NerInferenceOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: MlTypes.TokenizationConfigContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
        [<System.Text.Json.Serialization.JsonPropertyName("classification_labels")>]
        ClassificationLabels: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("vocabulary")>]
        Vocabulary: MlTypes.Vocabulary option
    }

    /// Pass through configuration options
    type PassThroughInferenceOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: MlTypes.TokenizationConfigContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
        [<System.Text.Json.Serialization.JsonPropertyName("vocabulary")>]
        Vocabulary: MlTypes.Vocabulary option
    }

    /// Text embedding inference options
    type TextEmbeddingInferenceOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("embedding_size")>]
        EmbeddingSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: MlTypes.TokenizationConfigContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
        [<System.Text.Json.Serialization.JsonPropertyName("vocabulary")>]
        Vocabulary: MlTypes.Vocabulary option
    }

    /// Text expansion inference options
    type TextExpansionInferenceOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: MlTypes.TokenizationConfigContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
        [<System.Text.Json.Serialization.JsonPropertyName("vocabulary")>]
        Vocabulary: MlTypes.Vocabulary option
    }

    /// Question answering inference options
    type QuestionAnsweringInferenceOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_classes")>]
        NumTopClasses: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: MlTypes.TokenizationConfigContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_answer_length")>]
        MaxAnswerLength: Types.Integer option
    }

    /// Inference configuration provided when storing the model config
    [<RequireQualifiedAccess>]
    type InferenceConfigCreateContainer =
        | Regression of MlTypes.RegressionInferenceOptions
        | Classification of MlTypes.ClassificationInferenceOptions
        | TextClassification of MlTypes.TextClassificationInferenceOptions
        | ZeroShotClassification of MlTypes.ZeroShotClassificationInferenceOptions
        | FillMask of MlTypes.FillMaskInferenceOptions
        | LearningToRank of MlTypes.LearningToRankConfig
        | Ner of MlTypes.NerInferenceOptions
        | PassThrough of MlTypes.PassThroughInferenceOptions
        | TextEmbedding of MlTypes.TextEmbeddingInferenceOptions
        | TextExpansion of MlTypes.TextExpansionInferenceOptions
        | QuestionAnswering of MlTypes.QuestionAnsweringInferenceOptions

    type TextClassificationInferenceUpdateOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_classes")>]
        NumTopClasses: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: MlTypes.NlpTokenizationUpdateOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
        [<System.Text.Json.Serialization.JsonPropertyName("classification_labels")>]
        ClassificationLabels: string list option
    }

    type ZeroShotClassificationInferenceUpdateOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: MlTypes.NlpTokenizationUpdateOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
        [<System.Text.Json.Serialization.JsonPropertyName("multi_label")>]
        MultiLabel: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("labels")>]
        Labels: string list
    }

    type NerInferenceUpdateOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: MlTypes.NlpTokenizationUpdateOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
    }

    type PassThroughInferenceUpdateOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: MlTypes.NlpTokenizationUpdateOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
    }

    type TextEmbeddingInferenceUpdateOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: MlTypes.NlpTokenizationUpdateOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
    }

    type TextExpansionInferenceUpdateOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: MlTypes.NlpTokenizationUpdateOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
    }

    type QuestionAnsweringInferenceUpdateOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("question")>]
        Question: string
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_classes")>]
        NumTopClasses: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("tokenization")>]
        Tokenization: MlTypes.NlpTokenizationUpdateOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_answer_length")>]
        MaxAnswerLength: Types.Integer option
    }

    [<RequireQualifiedAccess>]
    type InferenceConfigUpdateContainer =
        | Regression of MlTypes.RegressionInferenceOptions
        | Classification of MlTypes.ClassificationInferenceOptions
        | TextClassification of MlTypes.TextClassificationInferenceUpdateOptions
        | ZeroShotClassification of MlTypes.ZeroShotClassificationInferenceUpdateOptions
        | FillMask of MlTypes.FillMaskInferenceUpdateOptions
        | Ner of MlTypes.NerInferenceUpdateOptions
        | PassThrough of MlTypes.PassThroughInferenceUpdateOptions
        | TextEmbedding of MlTypes.TextEmbeddingInferenceUpdateOptions
        | TextExpansion of MlTypes.TextExpansionInferenceUpdateOptions
        | QuestionAnswering of MlTypes.QuestionAnsweringInferenceUpdateOptions

    type TrainedModelEntities = {
        [<System.Text.Json.Serialization.JsonPropertyName("class_name")>]
        ClassName: string
        [<System.Text.Json.Serialization.JsonPropertyName("class_probability")>]
        ClassProbability: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("entity")>]
        Entity: string
        [<System.Text.Json.Serialization.JsonPropertyName("start_pos")>]
        StartPos: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("end_pos")>]
        EndPos: Types.Integer
    }

    [<RequireQualifiedAccess>]
    type PredictedValue =
        | ScalarValue of Types.ScalarValue
        | Array of Types.ScalarValue list

    type TopClassEntry = {
        [<System.Text.Json.Serialization.JsonPropertyName("class_name")>]
        ClassName: string
        [<System.Text.Json.Serialization.JsonPropertyName("class_probability")>]
        ClassProbability: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("class_score")>]
        ClassScore: Types.Double
    }

    type TrainedModelInferenceClassImportance = {
        [<System.Text.Json.Serialization.JsonPropertyName("class_name")>]
        ClassName: string
        [<System.Text.Json.Serialization.JsonPropertyName("importance")>]
        Importance: Types.Double
    }

    type TrainedModelInferenceFeatureImportance = {
        [<System.Text.Json.Serialization.JsonPropertyName("feature_name")>]
        FeatureName: string
        [<System.Text.Json.Serialization.JsonPropertyName("importance")>]
        Importance: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("classes")>]
        Classes: MlTypes.TrainedModelInferenceClassImportance list option
    }

    type InferenceResponseResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("entities")>]
        Entities: MlTypes.TrainedModelEntities list option
        [<System.Text.Json.Serialization.JsonPropertyName("is_truncated")>]
        IsTruncated: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("predicted_value")>]
        PredictedValue: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("predicted_value_sequence")>]
        PredictedValueSequence: string option
        [<System.Text.Json.Serialization.JsonPropertyName("prediction_probability")>]
        PredictionProbability: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("prediction_score")>]
        PredictionScore: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("top_classes")>]
        TopClasses: MlTypes.TopClassEntry list option
        [<System.Text.Json.Serialization.JsonPropertyName("warning")>]
        Warning: string option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_importance")>]
        FeatureImportance: MlTypes.TrainedModelInferenceFeatureImportance list option
    }

    type Influencer = {
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_span")>]
        BucketSpan: Types.DurationValue<Types.UnitSeconds>
        [<System.Text.Json.Serialization.JsonPropertyName("influencer_score")>]
        InfluencerScore: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("influencer_field_name")>]
        InfluencerFieldName: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("influencer_field_value")>]
        InfluencerFieldValue: string
        [<System.Text.Json.Serialization.JsonPropertyName("initial_influencer_score")>]
        InitialInfluencerScore: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("is_interim")>]
        IsInterim: bool
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("probability")>]
        Probability: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("result_type")>]
        ResultType: string
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.EpochTime<Types.UnitMillis>
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
        Reason: MlTypes.JobBlockedReason
        [<System.Text.Json.Serialization.JsonPropertyName("task_id")>]
        TaskId: Types.TaskId option
    }

    type ModelPlotConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("annotations_enabled")>]
        AnnotationsEnabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("terms")>]
        Terms: Types.Field option
    }

    type Job = {
        [<System.Text.Json.Serialization.JsonPropertyName("allow_lazy_open")>]
        AllowLazyOpen: bool
        [<System.Text.Json.Serialization.JsonPropertyName("analysis_config")>]
        AnalysisConfig: MlTypes.AnalysisConfig
        [<System.Text.Json.Serialization.JsonPropertyName("analysis_limits")>]
        AnalysisLimits: MlTypes.AnalysisLimits option
        [<System.Text.Json.Serialization.JsonPropertyName("background_persist_interval")>]
        BackgroundPersistInterval: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("blocked")>]
        Blocked: MlTypes.JobBlocked option
        [<System.Text.Json.Serialization.JsonPropertyName("create_time")>]
        CreateTime: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("custom_settings")>]
        CustomSettings: MlTypes.CustomSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("daily_model_snapshot_retention_after_days")>]
        DailyModelSnapshotRetentionAfterDays: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("data_description")>]
        DataDescription: MlTypes.DataDescription
        [<System.Text.Json.Serialization.JsonPropertyName("datafeed_config")>]
        DatafeedConfig: MlTypes.Datafeed option
        [<System.Text.Json.Serialization.JsonPropertyName("deleting")>]
        Deleting: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("finished_time")>]
        FinishedTime: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("groups")>]
        Groups: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("job_type")>]
        JobType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("job_version")>]
        JobVersion: Types.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("model_plot_config")>]
        ModelPlotConfig: MlTypes.ModelPlotConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("model_snapshot_id")>]
        ModelSnapshotId: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("model_snapshot_retention_days")>]
        ModelSnapshotRetentionDays: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("renormalization_window_days")>]
        RenormalizationWindowDays: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("results_index_name")>]
        ResultsIndexName: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("results_retention_days")>]
        ResultsRetentionDays: Types.Long option
    }

    type JobConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("allow_lazy_open")>]
        AllowLazyOpen: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("analysis_config")>]
        AnalysisConfig: MlTypes.AnalysisConfig
        [<System.Text.Json.Serialization.JsonPropertyName("analysis_limits")>]
        AnalysisLimits: MlTypes.AnalysisLimits option
        [<System.Text.Json.Serialization.JsonPropertyName("background_persist_interval")>]
        BackgroundPersistInterval: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("custom_settings")>]
        CustomSettings: MlTypes.CustomSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("daily_model_snapshot_retention_after_days")>]
        DailyModelSnapshotRetentionAfterDays: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("data_description")>]
        DataDescription: MlTypes.DataDescription
        [<System.Text.Json.Serialization.JsonPropertyName("datafeed_config")>]
        DatafeedConfig: MlTypes.DatafeedConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("groups")>]
        Groups: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("job_type")>]
        JobType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model_plot_config")>]
        ModelPlotConfig: MlTypes.ModelPlotConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("model_snapshot_retention_days")>]
        ModelSnapshotRetentionDays: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("renormalization_window_days")>]
        RenormalizationWindowDays: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("results_index_name")>]
        ResultsIndexName: Types.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("results_retention_days")>]
        ResultsRetentionDays: Types.Long option
    }

    type JobStatistics = {
        [<System.Text.Json.Serialization.JsonPropertyName("avg")>]
        Avg: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("min")>]
        Min: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Double
    }

    type JobForecastStatistics = {
        [<System.Text.Json.Serialization.JsonPropertyName("memory_bytes")>]
        MemoryBytes: MlTypes.JobStatistics option
        [<System.Text.Json.Serialization.JsonPropertyName("processing_time_ms")>]
        ProcessingTimeMs: MlTypes.JobStatistics option
        [<System.Text.Json.Serialization.JsonPropertyName("records")>]
        Records: MlTypes.JobStatistics option
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: Map<string, Types.Long> option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("forecasted_jobs")>]
        ForecastedJobs: Types.Integer
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
        BucketAllocationFailuresCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("log_time")>]
        LogTime: Types.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("memory_status")>]
        MemoryStatus: MlTypes.MemoryStatus
        [<System.Text.Json.Serialization.JsonPropertyName("model_bytes")>]
        ModelBytes: Types.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("model_bytes_exceeded")>]
        ModelBytesExceeded: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("model_bytes_memory_limit")>]
        ModelBytesMemoryLimit: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("output_memory_allocator_bytes")>]
        OutputMemoryAllocatorBytes: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("peak_model_bytes")>]
        PeakModelBytes: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("assignment_memory_basis")>]
        AssignmentMemoryBasis: string option
        [<System.Text.Json.Serialization.JsonPropertyName("result_type")>]
        ResultType: string
        [<System.Text.Json.Serialization.JsonPropertyName("total_by_field_count")>]
        TotalByFieldCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_over_field_count")>]
        TotalOverFieldCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_partition_field_count")>]
        TotalPartitionFieldCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_status")>]
        CategorizationStatus: MlTypes.CategorizationStatus
        [<System.Text.Json.Serialization.JsonPropertyName("categorized_doc_count")>]
        CategorizedDocCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("dead_category_count")>]
        DeadCategoryCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("failed_category_count")>]
        FailedCategoryCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("frequent_category_count")>]
        FrequentCategoryCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("rare_category_count")>]
        RareCategoryCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("total_category_count")>]
        TotalCategoryCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.Long option
    }

    type JobTimingStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("average_bucket_processing_time_ms")>]
        AverageBucketProcessingTimeMs: Types.DurationValue<Types.UnitFloatMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_count")>]
        BucketCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("exponential_average_bucket_processing_time_ms")>]
        ExponentialAverageBucketProcessingTimeMs: Types.DurationValue<Types.UnitFloatMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("exponential_average_bucket_processing_time_per_hour_ms")>]
        ExponentialAverageBucketProcessingTimePerHourMs: Types.DurationValue<Types.UnitFloatMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("total_bucket_processing_time_ms")>]
        TotalBucketProcessingTimeMs: Types.DurationValue<Types.UnitFloatMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("maximum_bucket_processing_time_ms")>]
        MaximumBucketProcessingTimeMs: Types.DurationValue<Types.UnitFloatMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_bucket_processing_time_ms")>]
        MinimumBucketProcessingTimeMs: Types.DurationValue<Types.UnitFloatMillis> option
    }

    type JobStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("assignment_explanation")>]
        AssignmentExplanation: string option
        [<System.Text.Json.Serialization.JsonPropertyName("data_counts")>]
        DataCounts: MlTypes.DataCounts
        [<System.Text.Json.Serialization.JsonPropertyName("forecasts_stats")>]
        ForecastsStats: MlTypes.JobForecastStatistics
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: string
        [<System.Text.Json.Serialization.JsonPropertyName("model_size_stats")>]
        ModelSizeStats: MlTypes.ModelSizeStats
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: MlTypes.DiscoveryNodeCompact option
        [<System.Text.Json.Serialization.JsonPropertyName("open_time")>]
        OpenTime: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: MlTypes.JobState
        [<System.Text.Json.Serialization.JsonPropertyName("timing_stats")>]
        TimingStats: MlTypes.JobTimingStats
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
        CreateTime: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_config")>]
        InferenceConfig: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_version")>]
        MinimumVersion: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model_repository")>]
        ModelRepository: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model_type")>]
        ModelType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("packaged_model_id")>]
        PackagedModelId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("platform_architecture")>]
        PlatformArchitecture: string option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix_strings")>]
        PrefixStrings: MlTypes.TrainedModelPrefixStrings option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.ByteSize option
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
        JobId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("latest_record_time_stamp")>]
        LatestRecordTimeStamp: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("latest_result_time_stamp")>]
        LatestResultTimeStamp: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_version")>]
        MinVersion: Types.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("model_size_stats")>]
        ModelSizeStats: MlTypes.ModelSizeStats option
        [<System.Text.Json.Serialization.JsonPropertyName("retain")>]
        Retain: bool
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot_doc_count")>]
        SnapshotDocCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot_id")>]
        SnapshotId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.Long
    }

    [<RequireQualifiedAccess>]
    type SnapshotUpgradeState =
        | LoadingOldState
        | SavingNewState
        | Stopped
        | Failed

    type ModelSnapshotUpgrade = {
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot_id")>]
        SnapshotId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: MlTypes.SnapshotUpgradeState
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: MlTypes.DiscoveryNode
        [<System.Text.Json.Serialization.JsonPropertyName("assignment_explanation")>]
        AssignmentExplanation: string
    }

    type OverallBucketJob = {
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("max_anomaly_score")>]
        MaxAnomalyScore: Types.Double
    }

    type OverallBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_span")>]
        BucketSpan: Types.DurationValue<Types.UnitSeconds>
        [<System.Text.Json.Serialization.JsonPropertyName("is_interim")>]
        IsInterim: bool
        [<System.Text.Json.Serialization.JsonPropertyName("jobs")>]
        Jobs: MlTypes.OverallBucketJob list
        [<System.Text.Json.Serialization.JsonPropertyName("overall_score")>]
        OverallScore: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("result_type")>]
        ResultType: string
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp_string")>]
        TimestampString: Types.DateTime option
    }

    type Page = {
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        From: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
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
        MeanMagnitude: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("min")>]
        Min: Types.Integer
    }

    type TotalFeatureImportanceClass = {
        [<System.Text.Json.Serialization.JsonPropertyName("class_name")>]
        ClassName: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("importance")>]
        Importance: MlTypes.TotalFeatureImportanceStatistics list
    }

    type TotalFeatureImportance = {
        [<System.Text.Json.Serialization.JsonPropertyName("feature_name")>]
        FeatureName: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("importance")>]
        Importance: MlTypes.TotalFeatureImportanceStatistics list
        [<System.Text.Json.Serialization.JsonPropertyName("classes")>]
        Classes: MlTypes.TotalFeatureImportanceClass list
    }

    type TrainedModelAssignmentRoutingTable = {
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string option
        [<System.Text.Json.Serialization.JsonPropertyName("routing_state")>]
        RoutingState: MlTypes.RoutingState
        [<System.Text.Json.Serialization.JsonPropertyName("current_allocations")>]
        CurrentAllocations: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("target_allocations")>]
        TargetAllocations: Types.Integer
    }

    [<RequireQualifiedAccess>]
    type TrainingPriority =
        | Normal
        | Low

    type TrainedModelAssignmentTaskParameters = {
        [<System.Text.Json.Serialization.JsonPropertyName("model_bytes")>]
        ModelBytes: Types.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("deployment_id")>]
        DeploymentId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("cache_size")>]
        CacheSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_allocations")>]
        NumberOfAllocations: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("priority")>]
        Priority: MlTypes.TrainingPriority
        [<System.Text.Json.Serialization.JsonPropertyName("per_deployment_memory_bytes")>]
        PerDeploymentMemoryBytes: Types.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("per_allocation_memory_bytes")>]
        PerAllocationMemoryBytes: Types.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("queue_capacity")>]
        QueueCapacity: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("threads_per_allocation")>]
        ThreadsPerAllocation: Types.Integer
    }

    type TrainedModelAssignment = {
        [<System.Text.Json.Serialization.JsonPropertyName("adaptive_allocations")>]
        AdaptiveAllocations: MlTypes.AdaptiveAllocationsSettings option option
        [<System.Text.Json.Serialization.JsonPropertyName("assignment_state")>]
        AssignmentState: MlTypes.DeploymentAssignmentState
        [<System.Text.Json.Serialization.JsonPropertyName("max_assigned_allocations")>]
        MaxAssignedAllocations: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string option
        [<System.Text.Json.Serialization.JsonPropertyName("routing_table")>]
        RoutingTable: Map<string, MlTypes.TrainedModelAssignmentRoutingTable>
        [<System.Text.Json.Serialization.JsonPropertyName("start_time")>]
        StartTime: Types.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("task_parameters")>]
        TaskParameters: MlTypes.TrainedModelAssignmentTaskParameters
    }

    type TrainedModelAssignmentRoutingStateAndReason = {
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string option
        [<System.Text.Json.Serialization.JsonPropertyName("routing_state")>]
        RoutingState: MlTypes.RoutingState
    }

    [<RequireQualifiedAccess>]
    type TrainedModelType =
        | TreeEnsemble
        | LangIdent
        | Pytorch

    type TrainedModelConfigInput = {
        [<System.Text.Json.Serialization.JsonPropertyName("field_names")>]
        FieldNames: Types.Field list
    }

    type TrainedModelConfigMetadata = {
        [<System.Text.Json.Serialization.JsonPropertyName("model_aliases")>]
        ModelAliases: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_importance_baseline")>]
        FeatureImportanceBaseline: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("hyperparameters")>]
        Hyperparameters: MlTypes.Hyperparameter list option
        [<System.Text.Json.Serialization.JsonPropertyName("total_feature_importance")>]
        TotalFeatureImportance: MlTypes.TotalFeatureImportance list option
    }

    type TrainedModelLocationIndex = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.IndexName
    }

    type TrainedModelLocation = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: MlTypes.TrainedModelLocationIndex
    }

    type TrainedModelConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("model_type")>]
        ModelType: MlTypes.TrainedModelType option
        [<System.Text.Json.Serialization.JsonPropertyName("tags")>]
        Tags: string list
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("compressed_definition")>]
        CompressedDefinition: string option
        [<System.Text.Json.Serialization.JsonPropertyName("created_by")>]
        CreatedBy: string option
        [<System.Text.Json.Serialization.JsonPropertyName("create_time")>]
        CreateTime: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("default_field_map")>]
        DefaultFieldMap: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("estimated_heap_memory_usage_bytes")>]
        EstimatedHeapMemoryUsageBytes: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("estimated_operations")>]
        EstimatedOperations: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("fully_defined")>]
        FullyDefined: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_config")>]
        InferenceConfig: MlTypes.InferenceConfigCreateContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("input")>]
        Input: MlTypes.TrainedModelConfigInput
        [<System.Text.Json.Serialization.JsonPropertyName("license_level")>]
        LicenseLevel: string option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: MlTypes.TrainedModelConfigMetadata option
        [<System.Text.Json.Serialization.JsonPropertyName("model_size_bytes")>]
        ModelSizeBytes: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("model_package")>]
        ModelPackage: MlTypes.ModelPackageConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("location")>]
        Location: MlTypes.TrainedModelLocation option
        [<System.Text.Json.Serialization.JsonPropertyName("platform_architecture")>]
        PlatformArchitecture: string option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix_strings")>]
        PrefixStrings: MlTypes.TrainedModelPrefixStrings option
    }

    type TrainedModelDeploymentAllocationStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("allocation_count")>]
        AllocationCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: MlTypes.DeploymentAllocationState
        [<System.Text.Json.Serialization.JsonPropertyName("target_allocation_count")>]
        TargetAllocationCount: Types.Integer
    }

    type TrainedModelDeploymentNodesStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("average_inference_time_ms")>]
        AverageInferenceTimeMs: Types.DurationValue<Types.UnitFloatMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("average_inference_time_ms_last_minute")>]
        AverageInferenceTimeMsLastMinute: Types.DurationValue<Types.UnitFloatMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("average_inference_time_ms_excluding_cache_hits")>]
        AverageInferenceTimeMsExcludingCacheHits: Types.DurationValue<Types.UnitFloatMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("error_count")>]
        ErrorCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_count")>]
        InferenceCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_cache_hit_count")>]
        InferenceCacheHitCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_cache_hit_count_last_minute")>]
        InferenceCacheHitCountLastMinute: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("last_access")>]
        LastAccess: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: MlTypes.DiscoveryNode option
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_allocations")>]
        NumberOfAllocations: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_pending_requests")>]
        NumberOfPendingRequests: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("peak_throughput_per_minute")>]
        PeakThroughputPerMinute: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("rejected_execution_count")>]
        RejectedExecutionCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("routing_state")>]
        RoutingState: MlTypes.TrainedModelAssignmentRoutingStateAndReason
        [<System.Text.Json.Serialization.JsonPropertyName("start_time")>]
        StartTime: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("threads_per_allocation")>]
        ThreadsPerAllocation: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("throughput_last_minute")>]
        ThroughputLastMinute: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("timeout_count")>]
        TimeoutCount: Types.Integer option
    }

    type TrainedModelDeploymentStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("adaptive_allocations")>]
        AdaptiveAllocations: MlTypes.AdaptiveAllocationsSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("allocation_status")>]
        AllocationStatus: MlTypes.TrainedModelDeploymentAllocationStatus option
        [<System.Text.Json.Serialization.JsonPropertyName("cache_size")>]
        CacheSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("deployment_id")>]
        DeploymentId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("error_count")>]
        ErrorCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_count")>]
        InferenceCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("nodes")>]
        Nodes: MlTypes.TrainedModelDeploymentNodesStats list
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_allocations")>]
        NumberOfAllocations: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("peak_throughput_per_minute")>]
        PeakThroughputPerMinute: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("priority")>]
        Priority: MlTypes.TrainingPriority
        [<System.Text.Json.Serialization.JsonPropertyName("queue_capacity")>]
        QueueCapacity: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("rejected_execution_count")>]
        RejectedExecutionCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string option
        [<System.Text.Json.Serialization.JsonPropertyName("start_time")>]
        StartTime: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: MlTypes.DeploymentAssignmentState option
        [<System.Text.Json.Serialization.JsonPropertyName("threads_per_allocation")>]
        ThreadsPerAllocation: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("timeout_count")>]
        TimeoutCount: Types.Integer option
    }

    type TrainedModelInferenceStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("cache_miss_count")>]
        CacheMissCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("failure_count")>]
        FailureCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("inference_count")>]
        InferenceCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("missing_all_fields_count")>]
        MissingAllFieldsCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.EpochTime<Types.UnitMillis>
    }

    type TrainedModelSizeStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("model_size_bytes")>]
        ModelSizeBytes: Types.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("required_native_memory_bytes")>]
        RequiredNativeMemoryBytes: Types.ByteSize
    }

    type TrainedModelStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("deployment_stats")>]
        DeploymentStats: MlTypes.TrainedModelDeploymentStats option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_stats")>]
        InferenceStats: MlTypes.TrainedModelInferenceStats option
        [<System.Text.Json.Serialization.JsonPropertyName("ingest")>]
        Ingest: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("model_size_stats")>]
        ModelSizeStats: MlTypes.TrainedModelSizeStats
        [<System.Text.Json.Serialization.JsonPropertyName("pipeline_count")>]
        PipelineCount: Types.Integer
    }

    type TransformAuthorization = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: MlTypes.ApiKeyAuthorization option
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("service_account")>]
        ServiceAccount: string option
    }


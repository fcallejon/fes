// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module XpackUsage =

    type AnalyticsStatistics = {
        [<System.Text.Json.Serialization.JsonPropertyName("boxplot_usage")>]
        BoxplotUsage: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("cumulative_cardinality_usage")>]
        CumulativeCardinalityUsage: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("string_stats_usage")>]
        StringStatsUsage: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("top_metrics_usage")>]
        TopMetricsUsage: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("t_test_usage")>]
        TTestUsage: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("moving_percentiles_usage")>]
        MovingPercentilesUsage: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("normalize_usage")>]
        NormalizeUsage: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("rate_usage")>]
        RateUsage: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("multi_terms_usage")>]
        MultiTermsUsage: CoreTypes.Long option
    }

    type Base = {
        [<System.Text.Json.Serialization.JsonPropertyName("available")>]
        Available: bool
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
    }

    type Analytics = {
        [<System.Text.Json.Serialization.JsonPropertyName("stats")>]
        Stats: AnalyticsStatistics
    }

    type Archive = {
        [<System.Text.Json.Serialization.JsonPropertyName("indices_count")>]
        IndicesCount: CoreTypes.Long
    }

    type FeatureToggle = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
    }

    type Audit = {
        [<System.Text.Json.Serialization.JsonPropertyName("outputs")>]
        Outputs: string list option
    }

    type Ccr = {
        [<System.Text.Json.Serialization.JsonPropertyName("auto_follow_patterns_count")>]
        AutoFollowPatternsCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("follower_indices_count")>]
        FollowerIndicesCount: CoreTypes.Integer
    }

    type Counter = {
        [<System.Text.Json.Serialization.JsonPropertyName("active")>]
        Active: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.Long
    }

    type DataStreams = {
        [<System.Text.Json.Serialization.JsonPropertyName("data_streams")>]
        DataStreams: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("indices_count")>]
        IndicesCount: CoreTypes.Long
    }

    type DataTierPhaseStatistics = {
        [<System.Text.Json.Serialization.JsonPropertyName("node_count")>]
        NodeCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("index_count")>]
        IndexCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_shard_count")>]
        TotalShardCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("primary_shard_count")>]
        PrimaryShardCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("doc_count")>]
        DocCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_size_bytes")>]
        TotalSizeBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("primary_size_bytes")>]
        PrimarySizeBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("primary_shard_size_avg_bytes")>]
        PrimaryShardSizeAvgBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("primary_shard_size_median_bytes")>]
        PrimaryShardSizeMedianBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("primary_shard_size_mad_bytes")>]
        PrimaryShardSizeMadBytes: CoreTypes.Long
    }

    type DataTiers = {
        [<System.Text.Json.Serialization.JsonPropertyName("data_warm")>]
        DataWarm: DataTierPhaseStatistics
        [<System.Text.Json.Serialization.JsonPropertyName("data_frozen")>]
        DataFrozen: DataTierPhaseStatistics option
        [<System.Text.Json.Serialization.JsonPropertyName("data_cold")>]
        DataCold: DataTierPhaseStatistics
        [<System.Text.Json.Serialization.JsonPropertyName("data_content")>]
        DataContent: DataTierPhaseStatistics
        [<System.Text.Json.Serialization.JsonPropertyName("data_hot")>]
        DataHot: DataTierPhaseStatistics
    }

    type Datafeed = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Long
    }

    type EqlFeaturesJoin = {
        [<System.Text.Json.Serialization.JsonPropertyName("join_queries_two")>]
        JoinQueriesTwo: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("join_queries_three")>]
        JoinQueriesThree: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("join_until")>]
        JoinUntil: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("join_queries_five_or_more")>]
        JoinQueriesFiveOrMore: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("join_queries_four")>]
        JoinQueriesFour: CoreTypes.Uint
    }

    type EqlFeaturesKeys = {
        [<System.Text.Json.Serialization.JsonPropertyName("join_keys_two")>]
        JoinKeysTwo: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("join_keys_one")>]
        JoinKeysOne: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("join_keys_three")>]
        JoinKeysThree: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("join_keys_five_or_more")>]
        JoinKeysFiveOrMore: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("join_keys_four")>]
        JoinKeysFour: CoreTypes.Uint
    }

    type EqlFeaturesPipes = {
        [<System.Text.Json.Serialization.JsonPropertyName("pipe_tail")>]
        PipeTail: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("pipe_head")>]
        PipeHead: CoreTypes.Uint
    }

    type EqlFeaturesSequences = {
        [<System.Text.Json.Serialization.JsonPropertyName("sequence_queries_three")>]
        SequenceQueriesThree: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("sequence_queries_four")>]
        SequenceQueriesFour: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("sequence_queries_two")>]
        SequenceQueriesTwo: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("sequence_until")>]
        SequenceUntil: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("sequence_queries_five_or_more")>]
        SequenceQueriesFiveOrMore: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("sequence_maxspan")>]
        SequenceMaxspan: CoreTypes.Uint
    }

    type EqlFeatures = {
        [<System.Text.Json.Serialization.JsonPropertyName("join")>]
        Join: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("joins")>]
        Joins: EqlFeaturesJoin
        [<System.Text.Json.Serialization.JsonPropertyName("keys")>]
        Keys: EqlFeaturesKeys
        [<System.Text.Json.Serialization.JsonPropertyName("event")>]
        Event: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("pipes")>]
        Pipes: EqlFeaturesPipes
        [<System.Text.Json.Serialization.JsonPropertyName("sequence")>]
        Sequence: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("sequences")>]
        Sequences: EqlFeaturesSequences
    }

    type Query = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("failed")>]
        Failed: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("paging")>]
        Paging: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.Integer option
    }

    type Eql = {
        [<System.Text.Json.Serialization.JsonPropertyName("features")>]
        Features: EqlFeatures
        [<System.Text.Json.Serialization.JsonPropertyName("queries")>]
        Queries: Map<string, Query>
    }

    type Flattened = {
        [<System.Text.Json.Serialization.JsonPropertyName("field_count")>]
        FieldCount: CoreTypes.Integer
    }

    /// Per-node GPU statistics for vector indexing.
    type GpuNodeStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("memory_in_bytes")>]
        MemoryInBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
        [<System.Text.Json.Serialization.JsonPropertyName("index_build_count")>]
        IndexBuildCount: CoreTypes.Long
    }

    /// GPU vector indexing usage statistics.
    type GpuVectorIndexing = {
        [<System.Text.Json.Serialization.JsonPropertyName("index_build_count")>]
        IndexBuildCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("nodes_with_gpu")>]
        NodesWithGpu: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("nodes")>]
        Nodes: GpuNodeStats list
    }

    type Invocations = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.Long
    }

    type HealthStatistics = {
        [<System.Text.Json.Serialization.JsonPropertyName("invocations")>]
        Invocations: Invocations
    }

    type Phase = {
        [<System.Text.Json.Serialization.JsonPropertyName("actions")>]
        Actions: string list
        [<System.Text.Json.Serialization.JsonPropertyName("min_age")>]
        MinAge: CoreTypes.DurationValue<CoreTypes.UnitMillis>
    }

    type Phases = {
        [<System.Text.Json.Serialization.JsonPropertyName("cold")>]
        Cold: Phase option
        [<System.Text.Json.Serialization.JsonPropertyName("delete")>]
        Delete: Phase option
        [<System.Text.Json.Serialization.JsonPropertyName("frozen")>]
        Frozen: Phase option
        [<System.Text.Json.Serialization.JsonPropertyName("hot")>]
        Hot: Phase option
        [<System.Text.Json.Serialization.JsonPropertyName("warm")>]
        Warm: Phase option
    }

    type IlmPolicyStatistics = {
        [<System.Text.Json.Serialization.JsonPropertyName("indices_managed")>]
        IndicesManaged: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("phases")>]
        Phases: Phases
    }

    type Ilm = {
        [<System.Text.Json.Serialization.JsonPropertyName("policy_count")>]
        PolicyCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("policy_stats")>]
        PolicyStats: IlmPolicyStatistics list
    }

    type IpFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("http")>]
        Http: bool
        [<System.Text.Json.Serialization.JsonPropertyName("transport")>]
        Transport: bool
    }

    type MlJobForecasts = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("forecasted_jobs")>]
        ForecastedJobs: CoreTypes.Long
    }

    type JobUsage = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("created_by")>]
        CreatedBy: Map<string, CoreTypes.Long>
        [<System.Text.Json.Serialization.JsonPropertyName("detectors")>]
        Detectors: MlTypes.JobStatistics
        [<System.Text.Json.Serialization.JsonPropertyName("forecasts")>]
        Forecasts: MlJobForecasts
        [<System.Text.Json.Serialization.JsonPropertyName("model_size")>]
        ModelSize: MlTypes.JobStatistics
    }

    type MlDataFrameAnalyticsJobsMemory = {
        [<System.Text.Json.Serialization.JsonPropertyName("peak_usage_bytes")>]
        PeakUsageBytes: MlTypes.JobStatistics
    }

    type MlDataFrameAnalyticsJobsCount = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Long
    }

    type MlDataFrameAnalyticsJobsAnalysis = {
        [<System.Text.Json.Serialization.JsonPropertyName("classification")>]
        Classification: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("outlier_detection")>]
        OutlierDetection: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("regression")>]
        Regression: CoreTypes.Integer option
    }

    type MlDataFrameAnalyticsJobs = {
        [<System.Text.Json.Serialization.JsonPropertyName("memory_usage")>]
        MemoryUsage: MlDataFrameAnalyticsJobsMemory option
        [<System.Text.Json.Serialization.JsonPropertyName("_all")>]
        All: MlDataFrameAnalyticsJobsCount
        [<System.Text.Json.Serialization.JsonPropertyName("analysis_counts")>]
        AnalysisCounts: MlDataFrameAnalyticsJobsAnalysis option
        [<System.Text.Json.Serialization.JsonPropertyName("stopped")>]
        Stopped: MlDataFrameAnalyticsJobsCount option
    }

    type MlInferenceIngestProcessorCount = {
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("sum")>]
        Sum: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("min")>]
        Min: CoreTypes.Long
    }

    type MlCounter = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Long
    }

    type MlInferenceIngestProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("num_docs_processed")>]
        NumDocsProcessed: MlInferenceIngestProcessorCount
        [<System.Text.Json.Serialization.JsonPropertyName("pipelines")>]
        Pipelines: MlCounter
        [<System.Text.Json.Serialization.JsonPropertyName("num_failures")>]
        NumFailures: MlInferenceIngestProcessorCount
        [<System.Text.Json.Serialization.JsonPropertyName("time_ms")>]
        TimeMs: MlInferenceIngestProcessorCount
    }

    type MlInferenceTrainedModelsCount = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("prepackaged")>]
        Prepackaged: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("other")>]
        Other: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("pass_through")>]
        PassThrough: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("regression")>]
        Regression: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("classification")>]
        Classification: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("ner")>]
        Ner: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("text_embedding")>]
        TextEmbedding: CoreTypes.Long option
    }

    type MlInferenceTrainedModels = {
        [<System.Text.Json.Serialization.JsonPropertyName("estimated_operations")>]
        EstimatedOperations: MlTypes.JobStatistics option
        [<System.Text.Json.Serialization.JsonPropertyName("estimated_heap_memory_usage_bytes")>]
        EstimatedHeapMemoryUsageBytes: MlTypes.JobStatistics option
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: MlInferenceTrainedModelsCount option
        [<System.Text.Json.Serialization.JsonPropertyName("_all")>]
        All: MlCounter
        [<System.Text.Json.Serialization.JsonPropertyName("model_size_bytes")>]
        ModelSizeBytes: MlTypes.JobStatistics option
    }

    type MlInferenceDeploymentsTimeMs = {
        [<System.Text.Json.Serialization.JsonPropertyName("avg")>]
        Avg: CoreTypes.Double
    }

    type MlInferenceDeployments = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("inference_counts")>]
        InferenceCounts: MlTypes.JobStatistics
        [<System.Text.Json.Serialization.JsonPropertyName("model_sizes_bytes")>]
        ModelSizesBytes: MlTypes.JobStatistics
        [<System.Text.Json.Serialization.JsonPropertyName("time_ms")>]
        TimeMs: MlInferenceDeploymentsTimeMs
    }

    type MlInference = {
        [<System.Text.Json.Serialization.JsonPropertyName("ingest_processors")>]
        IngestProcessors: Map<string, MlInferenceIngestProcessor>
        [<System.Text.Json.Serialization.JsonPropertyName("trained_models")>]
        TrainedModels: MlInferenceTrainedModels
        [<System.Text.Json.Serialization.JsonPropertyName("deployments")>]
        Deployments: MlInferenceDeployments option
    }

    type MachineLearning = {
        [<System.Text.Json.Serialization.JsonPropertyName("datafeeds")>]
        Datafeeds: Map<string, Datafeed>
        [<System.Text.Json.Serialization.JsonPropertyName("jobs")>]
        Jobs: Map<string, JobUsage>
        [<System.Text.Json.Serialization.JsonPropertyName("node_count")>]
        NodeCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("data_frame_analytics_jobs")>]
        DataFrameAnalyticsJobs: MlDataFrameAnalyticsJobs
        [<System.Text.Json.Serialization.JsonPropertyName("inference")>]
        Inference: MlInference
    }

    type Monitoring = {
        [<System.Text.Json.Serialization.JsonPropertyName("collection_enabled")>]
        CollectionEnabled: bool
        [<System.Text.Json.Serialization.JsonPropertyName("enabled_exporters")>]
        EnabledExporters: Map<string, CoreTypes.Long>
    }

    type RealmCache = {
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: CoreTypes.Long
    }

    type Realm = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: CoreTypes.Long list option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: CoreTypes.Long list option
        [<System.Text.Json.Serialization.JsonPropertyName("cache")>]
        Cache: RealmCache list option
        [<System.Text.Json.Serialization.JsonPropertyName("has_authorization_realms")>]
        HasAuthorizationRealms: bool list option
        [<System.Text.Json.Serialization.JsonPropertyName("has_default_username_pattern")>]
        HasDefaultUsernamePattern: bool list option
        [<System.Text.Json.Serialization.JsonPropertyName("has_truststore")>]
        HasTruststore: bool list option
        [<System.Text.Json.Serialization.JsonPropertyName("is_authentication_delegated")>]
        IsAuthenticationDelegated: bool list option
    }

    type RoleMapping = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: CoreTypes.Integer
    }

    type RuntimeFieldsType = {
        [<System.Text.Json.Serialization.JsonPropertyName("chars_max")>]
        CharsMax: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("chars_total")>]
        CharsTotal: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("doc_max")>]
        DocMax: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("doc_total")>]
        DocTotal: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("index_count")>]
        IndexCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("lang")>]
        Lang: string list
        [<System.Text.Json.Serialization.JsonPropertyName("lines_max")>]
        LinesMax: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("lines_total")>]
        LinesTotal: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("scriptless_count")>]
        ScriptlessCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("shadowed_count")>]
        ShadowedCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("source_max")>]
        SourceMax: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("source_total")>]
        SourceTotal: CoreTypes.Long
    }

    type RuntimeFieldTypes = {
        [<System.Text.Json.Serialization.JsonPropertyName("field_types")>]
        FieldTypes: RuntimeFieldsType list
    }

    type SearchableSnapshots = {
        [<System.Text.Json.Serialization.JsonPropertyName("indices_count")>]
        IndicesCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("full_copy_indices_count")>]
        FullCopyIndicesCount: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("shared_cache_indices_count")>]
        SharedCacheIndicesCount: CoreTypes.Integer option
    }

    type SecurityRolesNative = {
        [<System.Text.Json.Serialization.JsonPropertyName("dls")>]
        Dls: bool
        [<System.Text.Json.Serialization.JsonPropertyName("fls")>]
        Fls: bool
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: CoreTypes.Long
    }

    type SecurityRolesDlsBitSetCache = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("memory")>]
        Memory: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("memory_in_bytes")>]
        MemoryInBytes: CoreTypes.Ulong
        [<System.Text.Json.Serialization.JsonPropertyName("hits")>]
        Hits: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("misses")>]
        Misses: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("evictions")>]
        Evictions: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("hits_time_in_millis")>]
        HitsTimeInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("misses_time_in_millis")>]
        MissesTimeInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
    }

    type SecurityRolesDls = {
        [<System.Text.Json.Serialization.JsonPropertyName("bit_set_cache")>]
        BitSetCache: SecurityRolesDlsBitSetCache
    }

    type SecurityRolesFile = {
        [<System.Text.Json.Serialization.JsonPropertyName("dls")>]
        Dls: bool
        [<System.Text.Json.Serialization.JsonPropertyName("fls")>]
        Fls: bool
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: CoreTypes.Long
    }

    type SecurityRoles = {
        [<System.Text.Json.Serialization.JsonPropertyName("native")>]
        Native: SecurityRolesNative
        [<System.Text.Json.Serialization.JsonPropertyName("dls")>]
        Dls: SecurityRolesDls
        [<System.Text.Json.Serialization.JsonPropertyName("file")>]
        File: SecurityRolesFile
    }

    type Ssl = {
        [<System.Text.Json.Serialization.JsonPropertyName("http")>]
        Http: FeatureToggle
        [<System.Text.Json.Serialization.JsonPropertyName("transport")>]
        Transport: FeatureToggle
    }

    type Security = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key_service")>]
        ApiKeyService: FeatureToggle
        [<System.Text.Json.Serialization.JsonPropertyName("anonymous")>]
        Anonymous: FeatureToggle
        [<System.Text.Json.Serialization.JsonPropertyName("audit")>]
        Audit: Audit
        [<System.Text.Json.Serialization.JsonPropertyName("fips_140")>]
        Fips140: FeatureToggle
        [<System.Text.Json.Serialization.JsonPropertyName("ipfilter")>]
        Ipfilter: IpFilter
        [<System.Text.Json.Serialization.JsonPropertyName("realms")>]
        Realms: Map<string, Realm>
        [<System.Text.Json.Serialization.JsonPropertyName("role_mapping")>]
        RoleMapping: Map<string, RoleMapping>
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: SecurityRoles
        [<System.Text.Json.Serialization.JsonPropertyName("ssl")>]
        Ssl: Ssl
        [<System.Text.Json.Serialization.JsonPropertyName("system_key")>]
        SystemKey: FeatureToggle option
        [<System.Text.Json.Serialization.JsonPropertyName("token_service")>]
        TokenService: FeatureToggle
        [<System.Text.Json.Serialization.JsonPropertyName("operator_privileges")>]
        OperatorPrivileges: Base
    }

    type Slm = {
        [<System.Text.Json.Serialization.JsonPropertyName("policy_count")>]
        PolicyCount: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("policy_stats")>]
        PolicyStats: SlmTypes.Statistics option
    }

    type Sql = {
        [<System.Text.Json.Serialization.JsonPropertyName("features")>]
        Features: Map<string, CoreTypes.Integer>
        [<System.Text.Json.Serialization.JsonPropertyName("queries")>]
        Queries: Map<string, Query>
    }

    type Vector = {
        [<System.Text.Json.Serialization.JsonPropertyName("dense_vector_dims_avg_count")>]
        DenseVectorDimsAvgCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("dense_vector_fields_count")>]
        DenseVectorFieldsCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("sparse_vector_fields_count")>]
        SparseVectorFieldsCount: CoreTypes.Integer option
    }

    type WatcherActionTotals = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("total_time_in_ms")>]
        TotalTimeInMs: CoreTypes.DurationValue<CoreTypes.UnitMillis>
    }

    type WatcherActions = {
        [<System.Text.Json.Serialization.JsonPropertyName("actions")>]
        Actions: Map<CoreTypes.Name, WatcherActionTotals>
    }

    type WatcherWatchTriggerSchedule = {
        [<System.Text.Json.Serialization.JsonPropertyName("cron")>]
        Cron: Counter
        [<System.Text.Json.Serialization.JsonPropertyName("_all")>]
        All: Counter
    }

    type WatcherWatchTrigger = {
        [<System.Text.Json.Serialization.JsonPropertyName("schedule")>]
        Schedule: WatcherWatchTriggerSchedule option
        [<System.Text.Json.Serialization.JsonPropertyName("_all")>]
        All: Counter
    }

    type WatcherWatch = {
        [<System.Text.Json.Serialization.JsonPropertyName("input")>]
        Input: Map<CoreTypes.Name, Counter>
        [<System.Text.Json.Serialization.JsonPropertyName("condition")>]
        Condition: Map<CoreTypes.Name, Counter> option
        [<System.Text.Json.Serialization.JsonPropertyName("action")>]
        Action: Map<CoreTypes.Name, Counter> option
        [<System.Text.Json.Serialization.JsonPropertyName("trigger")>]
        Trigger: WatcherWatchTrigger
    }

    type Watcher = {
        [<System.Text.Json.Serialization.JsonPropertyName("execution")>]
        Execution: WatcherActions
        [<System.Text.Json.Serialization.JsonPropertyName("watch")>]
        Watch: WatcherWatch
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Counter
    }


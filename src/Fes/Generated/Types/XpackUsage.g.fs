// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module XpackUsage =

    type AnalyticsStatistics = {
        [<System.Text.Json.Serialization.JsonPropertyName("boxplot_usage")>]
        BoxplotUsage: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("cumulative_cardinality_usage")>]
        CumulativeCardinalityUsage: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("string_stats_usage")>]
        StringStatsUsage: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("top_metrics_usage")>]
        TopMetricsUsage: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("t_test_usage")>]
        TTestUsage: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("moving_percentiles_usage")>]
        MovingPercentilesUsage: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("normalize_usage")>]
        NormalizeUsage: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("rate_usage")>]
        RateUsage: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("multi_terms_usage")>]
        MultiTermsUsage: Types.Long option
    }

    type Base = {
        [<System.Text.Json.Serialization.JsonPropertyName("available")>]
        Available: bool
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
    }

    type Analytics = {
        [<System.Text.Json.Serialization.JsonPropertyName("stats")>]
        Stats: XpackUsage.AnalyticsStatistics
    }

    type Archive = {
        [<System.Text.Json.Serialization.JsonPropertyName("indices_count")>]
        IndicesCount: Types.Long
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
        AutoFollowPatternsCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("follower_indices_count")>]
        FollowerIndicesCount: Types.Integer
    }

    type Counter = {
        [<System.Text.Json.Serialization.JsonPropertyName("active")>]
        Active: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Long
    }

    type DataStreams = {
        [<System.Text.Json.Serialization.JsonPropertyName("data_streams")>]
        DataStreams: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("indices_count")>]
        IndicesCount: Types.Long
    }

    type DataTierPhaseStatistics = {
        [<System.Text.Json.Serialization.JsonPropertyName("node_count")>]
        NodeCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("index_count")>]
        IndexCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_shard_count")>]
        TotalShardCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("primary_shard_count")>]
        PrimaryShardCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("doc_count")>]
        DocCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_size_bytes")>]
        TotalSizeBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("primary_size_bytes")>]
        PrimarySizeBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("primary_shard_size_avg_bytes")>]
        PrimaryShardSizeAvgBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("primary_shard_size_median_bytes")>]
        PrimaryShardSizeMedianBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("primary_shard_size_mad_bytes")>]
        PrimaryShardSizeMadBytes: Types.Long
    }

    type DataTiers = {
        [<System.Text.Json.Serialization.JsonPropertyName("data_warm")>]
        DataWarm: XpackUsage.DataTierPhaseStatistics
        [<System.Text.Json.Serialization.JsonPropertyName("data_frozen")>]
        DataFrozen: XpackUsage.DataTierPhaseStatistics option
        [<System.Text.Json.Serialization.JsonPropertyName("data_cold")>]
        DataCold: XpackUsage.DataTierPhaseStatistics
        [<System.Text.Json.Serialization.JsonPropertyName("data_content")>]
        DataContent: XpackUsage.DataTierPhaseStatistics
        [<System.Text.Json.Serialization.JsonPropertyName("data_hot")>]
        DataHot: XpackUsage.DataTierPhaseStatistics
    }

    type Datafeed = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long
    }

    type EqlFeaturesJoin = {
        [<System.Text.Json.Serialization.JsonPropertyName("join_queries_two")>]
        JoinQueriesTwo: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("join_queries_three")>]
        JoinQueriesThree: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("join_until")>]
        JoinUntil: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("join_queries_five_or_more")>]
        JoinQueriesFiveOrMore: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("join_queries_four")>]
        JoinQueriesFour: Types.Uint
    }

    type EqlFeaturesKeys = {
        [<System.Text.Json.Serialization.JsonPropertyName("join_keys_two")>]
        JoinKeysTwo: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("join_keys_one")>]
        JoinKeysOne: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("join_keys_three")>]
        JoinKeysThree: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("join_keys_five_or_more")>]
        JoinKeysFiveOrMore: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("join_keys_four")>]
        JoinKeysFour: Types.Uint
    }

    type EqlFeaturesPipes = {
        [<System.Text.Json.Serialization.JsonPropertyName("pipe_tail")>]
        PipeTail: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("pipe_head")>]
        PipeHead: Types.Uint
    }

    type EqlFeaturesSequences = {
        [<System.Text.Json.Serialization.JsonPropertyName("sequence_queries_three")>]
        SequenceQueriesThree: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("sequence_queries_four")>]
        SequenceQueriesFour: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("sequence_queries_two")>]
        SequenceQueriesTwo: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("sequence_until")>]
        SequenceUntil: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("sequence_queries_five_or_more")>]
        SequenceQueriesFiveOrMore: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("sequence_maxspan")>]
        SequenceMaxspan: Types.Uint
    }

    type EqlFeatures = {
        [<System.Text.Json.Serialization.JsonPropertyName("join")>]
        Join: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("joins")>]
        Joins: XpackUsage.EqlFeaturesJoin
        [<System.Text.Json.Serialization.JsonPropertyName("keys")>]
        Keys: XpackUsage.EqlFeaturesKeys
        [<System.Text.Json.Serialization.JsonPropertyName("event")>]
        Event: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("pipes")>]
        Pipes: XpackUsage.EqlFeaturesPipes
        [<System.Text.Json.Serialization.JsonPropertyName("sequence")>]
        Sequence: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("sequences")>]
        Sequences: XpackUsage.EqlFeaturesSequences
    }

    type Query = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("failed")>]
        Failed: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("paging")>]
        Paging: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Integer option
    }

    type Eql = {
        [<System.Text.Json.Serialization.JsonPropertyName("features")>]
        Features: XpackUsage.EqlFeatures
        [<System.Text.Json.Serialization.JsonPropertyName("queries")>]
        Queries: Map<string, XpackUsage.Query>
    }

    type Flattened = {
        [<System.Text.Json.Serialization.JsonPropertyName("field_count")>]
        FieldCount: Types.Integer
    }

    /// Per-node GPU statistics for vector indexing.
    type GpuNodeStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("memory_in_bytes")>]
        MemoryInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
        [<System.Text.Json.Serialization.JsonPropertyName("index_build_count")>]
        IndexBuildCount: Types.Long
    }

    /// GPU vector indexing usage statistics.
    type GpuVectorIndexing = {
        [<System.Text.Json.Serialization.JsonPropertyName("index_build_count")>]
        IndexBuildCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("nodes_with_gpu")>]
        NodesWithGpu: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("nodes")>]
        Nodes: XpackUsage.GpuNodeStats list
    }

    type Invocations = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Long
    }

    type HealthStatistics = {
        [<System.Text.Json.Serialization.JsonPropertyName("invocations")>]
        Invocations: XpackUsage.Invocations
    }

    type Phase = {
        [<System.Text.Json.Serialization.JsonPropertyName("actions")>]
        Actions: string list
        [<System.Text.Json.Serialization.JsonPropertyName("min_age")>]
        MinAge: Types.DurationValue<Types.UnitMillis>
    }

    type Phases = {
        [<System.Text.Json.Serialization.JsonPropertyName("cold")>]
        Cold: XpackUsage.Phase option
        [<System.Text.Json.Serialization.JsonPropertyName("delete")>]
        Delete: XpackUsage.Phase option
        [<System.Text.Json.Serialization.JsonPropertyName("frozen")>]
        Frozen: XpackUsage.Phase option
        [<System.Text.Json.Serialization.JsonPropertyName("hot")>]
        Hot: XpackUsage.Phase option
        [<System.Text.Json.Serialization.JsonPropertyName("warm")>]
        Warm: XpackUsage.Phase option
    }

    type IlmPolicyStatistics = {
        [<System.Text.Json.Serialization.JsonPropertyName("indices_managed")>]
        IndicesManaged: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("phases")>]
        Phases: XpackUsage.Phases
    }

    type Ilm = {
        [<System.Text.Json.Serialization.JsonPropertyName("policy_count")>]
        PolicyCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("policy_stats")>]
        PolicyStats: XpackUsage.IlmPolicyStatistics list
    }

    type IpFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("http")>]
        Http: bool
        [<System.Text.Json.Serialization.JsonPropertyName("transport")>]
        Transport: bool
    }

    type MlJobForecasts = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("forecasted_jobs")>]
        ForecastedJobs: Types.Long
    }

    type JobUsage = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("created_by")>]
        CreatedBy: Map<string, Types.Long>
        [<System.Text.Json.Serialization.JsonPropertyName("detectors")>]
        Detectors: MlTypes.JobStatistics
        [<System.Text.Json.Serialization.JsonPropertyName("forecasts")>]
        Forecasts: XpackUsage.MlJobForecasts
        [<System.Text.Json.Serialization.JsonPropertyName("model_size")>]
        ModelSize: MlTypes.JobStatistics
    }

    type MlDataFrameAnalyticsJobsMemory = {
        [<System.Text.Json.Serialization.JsonPropertyName("peak_usage_bytes")>]
        PeakUsageBytes: MlTypes.JobStatistics
    }

    type MlDataFrameAnalyticsJobsCount = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long
    }

    type MlDataFrameAnalyticsJobsAnalysis = {
        [<System.Text.Json.Serialization.JsonPropertyName("classification")>]
        Classification: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("outlier_detection")>]
        OutlierDetection: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("regression")>]
        Regression: Types.Integer option
    }

    type MlDataFrameAnalyticsJobs = {
        [<System.Text.Json.Serialization.JsonPropertyName("memory_usage")>]
        MemoryUsage: XpackUsage.MlDataFrameAnalyticsJobsMemory option
        [<System.Text.Json.Serialization.JsonPropertyName("_all")>]
        All: XpackUsage.MlDataFrameAnalyticsJobsCount
        [<System.Text.Json.Serialization.JsonPropertyName("analysis_counts")>]
        AnalysisCounts: XpackUsage.MlDataFrameAnalyticsJobsAnalysis option
        [<System.Text.Json.Serialization.JsonPropertyName("stopped")>]
        Stopped: XpackUsage.MlDataFrameAnalyticsJobsCount option
    }

    type MlInferenceIngestProcessorCount = {
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("sum")>]
        Sum: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("min")>]
        Min: Types.Long
    }

    type MlCounter = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long
    }

    type MlInferenceIngestProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("num_docs_processed")>]
        NumDocsProcessed: XpackUsage.MlInferenceIngestProcessorCount
        [<System.Text.Json.Serialization.JsonPropertyName("pipelines")>]
        Pipelines: XpackUsage.MlCounter
        [<System.Text.Json.Serialization.JsonPropertyName("num_failures")>]
        NumFailures: XpackUsage.MlInferenceIngestProcessorCount
        [<System.Text.Json.Serialization.JsonPropertyName("time_ms")>]
        TimeMs: XpackUsage.MlInferenceIngestProcessorCount
    }

    type MlInferenceTrainedModelsCount = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("prepackaged")>]
        Prepackaged: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("other")>]
        Other: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("pass_through")>]
        PassThrough: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("regression")>]
        Regression: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("classification")>]
        Classification: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("ner")>]
        Ner: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("text_embedding")>]
        TextEmbedding: Types.Long option
    }

    type MlInferenceTrainedModels = {
        [<System.Text.Json.Serialization.JsonPropertyName("estimated_operations")>]
        EstimatedOperations: MlTypes.JobStatistics option
        [<System.Text.Json.Serialization.JsonPropertyName("estimated_heap_memory_usage_bytes")>]
        EstimatedHeapMemoryUsageBytes: MlTypes.JobStatistics option
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: XpackUsage.MlInferenceTrainedModelsCount option
        [<System.Text.Json.Serialization.JsonPropertyName("_all")>]
        All: XpackUsage.MlCounter
        [<System.Text.Json.Serialization.JsonPropertyName("model_size_bytes")>]
        ModelSizeBytes: MlTypes.JobStatistics option
    }

    type MlInferenceDeploymentsTimeMs = {
        [<System.Text.Json.Serialization.JsonPropertyName("avg")>]
        Avg: Types.Double
    }

    type MlInferenceDeployments = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("inference_counts")>]
        InferenceCounts: MlTypes.JobStatistics
        [<System.Text.Json.Serialization.JsonPropertyName("model_sizes_bytes")>]
        ModelSizesBytes: MlTypes.JobStatistics
        [<System.Text.Json.Serialization.JsonPropertyName("time_ms")>]
        TimeMs: XpackUsage.MlInferenceDeploymentsTimeMs
    }

    type MlInference = {
        [<System.Text.Json.Serialization.JsonPropertyName("ingest_processors")>]
        IngestProcessors: Map<string, XpackUsage.MlInferenceIngestProcessor>
        [<System.Text.Json.Serialization.JsonPropertyName("trained_models")>]
        TrainedModels: XpackUsage.MlInferenceTrainedModels
        [<System.Text.Json.Serialization.JsonPropertyName("deployments")>]
        Deployments: XpackUsage.MlInferenceDeployments option
    }

    type MachineLearning = {
        [<System.Text.Json.Serialization.JsonPropertyName("datafeeds")>]
        Datafeeds: Map<string, XpackUsage.Datafeed>
        [<System.Text.Json.Serialization.JsonPropertyName("jobs")>]
        Jobs: Map<string, XpackUsage.JobUsage>
        [<System.Text.Json.Serialization.JsonPropertyName("node_count")>]
        NodeCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("data_frame_analytics_jobs")>]
        DataFrameAnalyticsJobs: XpackUsage.MlDataFrameAnalyticsJobs
        [<System.Text.Json.Serialization.JsonPropertyName("inference")>]
        Inference: XpackUsage.MlInference
    }

    type Monitoring = {
        [<System.Text.Json.Serialization.JsonPropertyName("collection_enabled")>]
        CollectionEnabled: bool
        [<System.Text.Json.Serialization.JsonPropertyName("enabled_exporters")>]
        EnabledExporters: Map<string, Types.Long>
    }

    type RealmCache = {
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Long
    }

    type Realm = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: Types.Long list option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Long list option
        [<System.Text.Json.Serialization.JsonPropertyName("cache")>]
        Cache: XpackUsage.RealmCache list option
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
        Enabled: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer
    }

    type RuntimeFieldsType = {
        [<System.Text.Json.Serialization.JsonPropertyName("chars_max")>]
        CharsMax: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("chars_total")>]
        CharsTotal: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("doc_max")>]
        DocMax: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("doc_total")>]
        DocTotal: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("index_count")>]
        IndexCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("lang")>]
        Lang: string list
        [<System.Text.Json.Serialization.JsonPropertyName("lines_max")>]
        LinesMax: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("lines_total")>]
        LinesTotal: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("scriptless_count")>]
        ScriptlessCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("shadowed_count")>]
        ShadowedCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("source_max")>]
        SourceMax: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("source_total")>]
        SourceTotal: Types.Long
    }

    type RuntimeFieldTypes = {
        [<System.Text.Json.Serialization.JsonPropertyName("field_types")>]
        FieldTypes: XpackUsage.RuntimeFieldsType list
    }

    type SearchableSnapshots = {
        [<System.Text.Json.Serialization.JsonPropertyName("indices_count")>]
        IndicesCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("full_copy_indices_count")>]
        FullCopyIndicesCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("shared_cache_indices_count")>]
        SharedCacheIndicesCount: Types.Integer option
    }

    type SecurityRolesNative = {
        [<System.Text.Json.Serialization.JsonPropertyName("dls")>]
        Dls: bool
        [<System.Text.Json.Serialization.JsonPropertyName("fls")>]
        Fls: bool
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Long
    }

    type SecurityRolesDlsBitSetCache = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("memory")>]
        Memory: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("memory_in_bytes")>]
        MemoryInBytes: Types.Ulong
        [<System.Text.Json.Serialization.JsonPropertyName("hits")>]
        Hits: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("misses")>]
        Misses: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("evictions")>]
        Evictions: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("hits_time_in_millis")>]
        HitsTimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("misses_time_in_millis")>]
        MissesTimeInMillis: Types.DurationValue<Types.UnitMillis>
    }

    type SecurityRolesDls = {
        [<System.Text.Json.Serialization.JsonPropertyName("bit_set_cache")>]
        BitSetCache: XpackUsage.SecurityRolesDlsBitSetCache
    }

    type SecurityRolesFile = {
        [<System.Text.Json.Serialization.JsonPropertyName("dls")>]
        Dls: bool
        [<System.Text.Json.Serialization.JsonPropertyName("fls")>]
        Fls: bool
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Long
    }

    type SecurityRoles = {
        [<System.Text.Json.Serialization.JsonPropertyName("native")>]
        Native: XpackUsage.SecurityRolesNative
        [<System.Text.Json.Serialization.JsonPropertyName("dls")>]
        Dls: XpackUsage.SecurityRolesDls
        [<System.Text.Json.Serialization.JsonPropertyName("file")>]
        File: XpackUsage.SecurityRolesFile
    }

    type Ssl = {
        [<System.Text.Json.Serialization.JsonPropertyName("http")>]
        Http: XpackUsage.FeatureToggle
        [<System.Text.Json.Serialization.JsonPropertyName("transport")>]
        Transport: XpackUsage.FeatureToggle
    }

    type Security = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key_service")>]
        ApiKeyService: XpackUsage.FeatureToggle
        [<System.Text.Json.Serialization.JsonPropertyName("anonymous")>]
        Anonymous: XpackUsage.FeatureToggle
        [<System.Text.Json.Serialization.JsonPropertyName("audit")>]
        Audit: XpackUsage.Audit
        [<System.Text.Json.Serialization.JsonPropertyName("fips_140")>]
        Fips140: XpackUsage.FeatureToggle
        [<System.Text.Json.Serialization.JsonPropertyName("ipfilter")>]
        Ipfilter: XpackUsage.IpFilter
        [<System.Text.Json.Serialization.JsonPropertyName("realms")>]
        Realms: Map<string, XpackUsage.Realm>
        [<System.Text.Json.Serialization.JsonPropertyName("role_mapping")>]
        RoleMapping: Map<string, XpackUsage.RoleMapping>
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: XpackUsage.SecurityRoles
        [<System.Text.Json.Serialization.JsonPropertyName("ssl")>]
        Ssl: XpackUsage.Ssl
        [<System.Text.Json.Serialization.JsonPropertyName("system_key")>]
        SystemKey: XpackUsage.FeatureToggle option
        [<System.Text.Json.Serialization.JsonPropertyName("token_service")>]
        TokenService: XpackUsage.FeatureToggle
        [<System.Text.Json.Serialization.JsonPropertyName("operator_privileges")>]
        OperatorPrivileges: XpackUsage.Base
    }

    type Slm = {
        [<System.Text.Json.Serialization.JsonPropertyName("policy_count")>]
        PolicyCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("policy_stats")>]
        PolicyStats: SlmTypes.Statistics option
    }

    type Sql = {
        [<System.Text.Json.Serialization.JsonPropertyName("features")>]
        Features: Map<string, Types.Integer>
        [<System.Text.Json.Serialization.JsonPropertyName("queries")>]
        Queries: Map<string, XpackUsage.Query>
    }

    type Vector = {
        [<System.Text.Json.Serialization.JsonPropertyName("dense_vector_dims_avg_count")>]
        DenseVectorDimsAvgCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("dense_vector_fields_count")>]
        DenseVectorFieldsCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("sparse_vector_fields_count")>]
        SparseVectorFieldsCount: Types.Integer option
    }

    type WatcherActionTotals = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("total_time_in_ms")>]
        TotalTimeInMs: Types.DurationValue<Types.UnitMillis>
    }

    type WatcherActions = {
        [<System.Text.Json.Serialization.JsonPropertyName("actions")>]
        Actions: Map<Types.Name, XpackUsage.WatcherActionTotals>
    }

    type WatcherWatchTriggerSchedule = {
        [<System.Text.Json.Serialization.JsonPropertyName("cron")>]
        Cron: XpackUsage.Counter
        [<System.Text.Json.Serialization.JsonPropertyName("_all")>]
        All: XpackUsage.Counter
    }

    type WatcherWatchTrigger = {
        [<System.Text.Json.Serialization.JsonPropertyName("schedule")>]
        Schedule: XpackUsage.WatcherWatchTriggerSchedule option
        [<System.Text.Json.Serialization.JsonPropertyName("_all")>]
        All: XpackUsage.Counter
    }

    type WatcherWatch = {
        [<System.Text.Json.Serialization.JsonPropertyName("input")>]
        Input: Map<Types.Name, XpackUsage.Counter>
        [<System.Text.Json.Serialization.JsonPropertyName("condition")>]
        Condition: Map<Types.Name, XpackUsage.Counter> option
        [<System.Text.Json.Serialization.JsonPropertyName("action")>]
        Action: Map<Types.Name, XpackUsage.Counter> option
        [<System.Text.Json.Serialization.JsonPropertyName("trigger")>]
        Trigger: XpackUsage.WatcherWatchTrigger
    }

    type Watcher = {
        [<System.Text.Json.Serialization.JsonPropertyName("execution")>]
        Execution: XpackUsage.WatcherActions
        [<System.Text.Json.Serialization.JsonPropertyName("watch")>]
        Watch: XpackUsage.WatcherWatch
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: XpackUsage.Counter
    }


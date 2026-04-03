// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesTypes =

    type Alias = {
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: TypesQueryDsl.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("index_routing")>]
        IndexRouting: string option
        [<System.Text.Json.Serialization.JsonPropertyName("is_hidden")>]
        IsHidden: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("is_write_index")>]
        IsWriteIndex: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search_routing")>]
        SearchRouting: string option
    }

    type AliasDefinition = {
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: TypesQueryDsl.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("index_routing")>]
        IndexRouting: string option
        [<System.Text.Json.Serialization.JsonPropertyName("is_write_index")>]
        IsWriteIndex: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search_routing")>]
        SearchRouting: string option
        [<System.Text.Json.Serialization.JsonPropertyName("is_hidden")>]
        IsHidden: bool option
    }

    type CacheQueries = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
    }

    [<RequireQualifiedAccess>]
    type ManagedBy =
        | Index Lifecycle Management
        | Data stream lifecycle
        | Unmanaged

    [<RequireQualifiedAccess>]
    type IndexMode =
        | Standard
        | TimeSeries
        | Logsdb
        | Lookup

    type DataStreamIndex = {
        [<System.Text.Json.Serialization.JsonPropertyName("index_name")>]
        IndexName: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("index_uuid")>]
        IndexUuid: Types.Uuid
        [<System.Text.Json.Serialization.JsonPropertyName("ilm_policy")>]
        IlmPolicy: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("managed_by")>]
        ManagedBy: IndicesTypes.ManagedBy option
        [<System.Text.Json.Serialization.JsonPropertyName("prefer_ilm")>]
        PreferIlm: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index_mode")>]
        IndexMode: IndicesTypes.IndexMode option
    }

    type FailureStore = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: IndicesTypes.DataStreamIndex list
        [<System.Text.Json.Serialization.JsonPropertyName("rollover_on_write")>]
        RolloverOnWrite: bool
    }

    type DataStreamLifecycleRolloverConditions = {
        [<System.Text.Json.Serialization.JsonPropertyName("min_age")>]
        MinAge: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("max_age")>]
        MaxAge: string option
        [<System.Text.Json.Serialization.JsonPropertyName("min_docs")>]
        MinDocs: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("max_docs")>]
        MaxDocs: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("min_size")>]
        MinSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("max_size")>]
        MaxSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("min_primary_shard_size")>]
        MinPrimaryShardSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("max_primary_shard_size")>]
        MaxPrimaryShardSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("min_primary_shard_docs")>]
        MinPrimaryShardDocs: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("max_primary_shard_docs")>]
        MaxPrimaryShardDocs: Types.Long option
    }

    type DownsamplingRound = {
        [<System.Text.Json.Serialization.JsonPropertyName("after")>]
        After: Types.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("fixed_interval")>]
        FixedInterval: Types.DurationLarge
    }

    [<RequireQualifiedAccess>]
    type SamplingMethod =
        | Aggregate
        | LastValue

    /// Data stream lifecycle denotes that a data stream is managed by the data stream lifecycle and contains the configuration.
    type DataStreamLifecycle = {
        [<System.Text.Json.Serialization.JsonPropertyName("data_retention")>]
        DataRetention: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("downsampling")>]
        Downsampling: IndicesTypes.DownsamplingRound list option
        [<System.Text.Json.Serialization.JsonPropertyName("downsampling_method")>]
        DownsamplingMethod: IndicesTypes.SamplingMethod option
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("frozen_after")>]
        FrozenAfter: Types.Duration option
    }

    /// Data stream lifecycle with rollover can be used to display the configuration including the default rollover conditions,
    type DataStreamLifecycleWithRollover = {
        [<System.Text.Json.Serialization.JsonPropertyName("rollover")>]
        Rollover: IndicesTypes.DataStreamLifecycleRolloverConditions option
    }

    type RetentionLease = {
        [<System.Text.Json.Serialization.JsonPropertyName("period")>]
        Period: Types.Duration
    }

    type SoftDeletes = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("retention_lease")>]
        RetentionLease: IndicesTypes.RetentionLease option
    }

    [<RequireQualifiedAccess>]
    type SegmentSortOrder =
        | Asc
        | Desc

    [<RequireQualifiedAccess>]
    type SegmentSortMode =
        | Min
        | Max

    [<RequireQualifiedAccess>]
    type SegmentSortMissing =
        | Last
        | First

    type IndexSegmentSort = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: System.Text.Json.JsonElement option
    }

    [<RequireQualifiedAccess>]
    type IndexCheckOnStartup =
        | True
        | False
        | Checksum

    type MergeScheduler = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_thread_count")>]
        MaxThreadCount: SpecUtils.Stringified<Types.Integer> option
        [<System.Text.Json.Serialization.JsonPropertyName("max_merge_count")>]
        MaxMergeCount: SpecUtils.Stringified<Types.Integer> option
    }

    type Merge = {
        [<System.Text.Json.Serialization.JsonPropertyName("scheduler")>]
        Scheduler: IndicesTypes.MergeScheduler option
    }

    type SearchIdle = {
        [<System.Text.Json.Serialization.JsonPropertyName("after")>]
        After: Types.Duration option
    }

    type SlowlogTresholdLevels = {
        [<System.Text.Json.Serialization.JsonPropertyName("warn")>]
        Warn: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("info")>]
        Info: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("debug")>]
        Debug: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("trace")>]
        Trace: Types.Duration option
    }

    type SlowlogTresholds = {
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: IndicesTypes.SlowlogTresholdLevels option
        [<System.Text.Json.Serialization.JsonPropertyName("fetch")>]
        Fetch: IndicesTypes.SlowlogTresholdLevels option
    }

    type SlowlogSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("level")>]
        Level: string option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("reformat")>]
        Reformat: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("threshold")>]
        Threshold: IndicesTypes.SlowlogTresholds option
    }

    type SettingsSearch = {
        [<System.Text.Json.Serialization.JsonPropertyName("idle")>]
        Idle: IndicesTypes.SearchIdle option
        [<System.Text.Json.Serialization.JsonPropertyName("slowlog")>]
        Slowlog: IndicesTypes.SlowlogSettings option
    }

    type IndexSettingBlocks = {
        [<System.Text.Json.Serialization.JsonPropertyName("read_only")>]
        ReadOnly: SpecUtils.Stringified<bool> option
        [<System.Text.Json.Serialization.JsonPropertyName("read_only_allow_delete")>]
        ReadOnlyAllowDelete: SpecUtils.Stringified<bool> option
        [<System.Text.Json.Serialization.JsonPropertyName("read")>]
        Read: SpecUtils.Stringified<bool> option
        [<System.Text.Json.Serialization.JsonPropertyName("write")>]
        Write: SpecUtils.Stringified<bool> option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: SpecUtils.Stringified<bool> option
    }

    type SettingsAnalyze = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_token_count")>]
        MaxTokenCount: SpecUtils.Stringified<Types.Integer> option
    }

    type SettingsHighlight = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_analyzed_offset")>]
        MaxAnalyzedOffset: Types.Integer option
    }

    [<RequireQualifiedAccess>]
    type IndexRoutingAllocationOptions =
        | All
        | Primaries
        | NewPrimaries
        | None

    type IndexRoutingAllocationInclude = {
        [<System.Text.Json.Serialization.JsonPropertyName("_tier_preference")>]
        TierPreference: string option
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: Types.Id option
    }

    type IndexRoutingAllocationInitialRecovery = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: Types.Id option
    }

    type IndexRoutingAllocationDisk = {
        [<System.Text.Json.Serialization.JsonPropertyName("threshold_enabled")>]
        ThresholdEnabled: System.Text.Json.JsonElement option
    }

    type IndexRoutingAllocation = {
        [<System.Text.Json.Serialization.JsonPropertyName("enable")>]
        Enable: IndicesTypes.IndexRoutingAllocationOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("include")>]
        Include: IndicesTypes.IndexRoutingAllocationInclude option
        [<System.Text.Json.Serialization.JsonPropertyName("initial_recovery")>]
        InitialRecovery: IndicesTypes.IndexRoutingAllocationInitialRecovery option
        [<System.Text.Json.Serialization.JsonPropertyName("disk")>]
        Disk: IndicesTypes.IndexRoutingAllocationDisk option
    }

    [<RequireQualifiedAccess>]
    type IndexRoutingRebalanceOptions =
        | All
        | Primaries
        | Replicas
        | None

    type IndexRoutingRebalance = {
        [<System.Text.Json.Serialization.JsonPropertyName("enable")>]
        Enable: IndicesTypes.IndexRoutingRebalanceOptions
    }

    type IndexRouting = {
        [<System.Text.Json.Serialization.JsonPropertyName("allocation")>]
        Allocation: IndicesTypes.IndexRoutingAllocation option
        [<System.Text.Json.Serialization.JsonPropertyName("rebalance")>]
        Rebalance: IndicesTypes.IndexRoutingRebalance option
    }

    type IndexSettingsLifecycleStep = {
        [<System.Text.Json.Serialization.JsonPropertyName("wait_time_threshold")>]
        WaitTimeThreshold: Types.Duration option
    }

    type IndexSettingsLifecycle = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing_complete")>]
        IndexingComplete: SpecUtils.Stringified<bool> option
        [<System.Text.Json.Serialization.JsonPropertyName("origination_date")>]
        OriginationDate: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("parse_origination_date")>]
        ParseOriginationDate: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("step")>]
        Step: IndicesTypes.IndexSettingsLifecycleStep option
        [<System.Text.Json.Serialization.JsonPropertyName("rollover_alias")>]
        RolloverAlias: string option
        [<System.Text.Json.Serialization.JsonPropertyName("prefer_ilm")>]
        PreferIlm: System.Text.Json.JsonElement option
    }

    type IndexVersioning = {
        [<System.Text.Json.Serialization.JsonPropertyName("created")>]
        Created: Types.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("created_string")>]
        CreatedString: string option
    }

    [<RequireQualifiedAccess>]
    type TranslogDurability =
        | Request
        | Async

    type TranslogRetention = {
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("age")>]
        Age: Types.Duration option
    }

    type Translog = {
        [<System.Text.Json.Serialization.JsonPropertyName("sync_interval")>]
        SyncInterval: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("durability")>]
        Durability: IndicesTypes.TranslogDurability option
        [<System.Text.Json.Serialization.JsonPropertyName("flush_threshold_size")>]
        FlushThresholdSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("retention")>]
        Retention: IndicesTypes.TranslogRetention option
    }

    type SettingsQueryString = {
        [<System.Text.Json.Serialization.JsonPropertyName("lenient")>]
        Lenient: SpecUtils.Stringified<bool>
    }

    type IndexSettingsAnalysis = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: Map<string, TypesAnalysis.Analyzer> option
        [<System.Text.Json.Serialization.JsonPropertyName("char_filter")>]
        CharFilter: Map<string, TypesAnalysis.CharFilter> option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: Map<string, TypesAnalysis.TokenFilter> option
        [<System.Text.Json.Serialization.JsonPropertyName("normalizer")>]
        Normalizer: Map<string, TypesAnalysis.Normalizer> option
        [<System.Text.Json.Serialization.JsonPropertyName("tokenizer")>]
        Tokenizer: Map<string, TypesAnalysis.Tokenizer> option
    }

    type IndexSettingsTimeSeries = {
        [<System.Text.Json.Serialization.JsonPropertyName("end_time")>]
        EndTime: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("start_time")>]
        StartTime: Types.DateTime option
    }

    type Queries = {
        [<System.Text.Json.Serialization.JsonPropertyName("cache")>]
        Cache: IndicesTypes.CacheQueries option
    }

    type SettingsSimilarityBm25 = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("b")>]
        B: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("discount_overlaps")>]
        DiscountOverlaps: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("k1")>]
        K1: Types.Double option
    }

    type SettingsSimilarityBoolean = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type SettingsSimilarityDfi = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("independence_measure")>]
        IndependenceMeasure: Types.DFIIndependenceMeasure
    }

    type SettingsSimilarityDfr = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("after_effect")>]
        AfterEffect: Types.DFRAfterEffect
        [<System.Text.Json.Serialization.JsonPropertyName("basic_model")>]
        BasicModel: Types.DFRBasicModel
        [<System.Text.Json.Serialization.JsonPropertyName("normalization")>]
        Normalization: Types.Normalization
    }

    type SettingsSimilarityIb = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("distribution")>]
        Distribution: Types.IBDistribution
        [<System.Text.Json.Serialization.JsonPropertyName("lambda")>]
        Lambda: Types.IBLambda
        [<System.Text.Json.Serialization.JsonPropertyName("normalization")>]
        Normalization: Types.Normalization
    }

    type SettingsSimilarityLmd = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("mu")>]
        Mu: Types.Double option
    }

    type SettingsSimilarityLmj = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("lambda")>]
        Lambda: Types.Double option
    }

    type SettingsSimilarityScripted = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script
        [<System.Text.Json.Serialization.JsonPropertyName("weight_script")>]
        WeightScript: Types.Script option
    }

    [<RequireQualifiedAccess>]
    type SettingsSimilarity =
        | SettingsSimilarityBm25 of IndicesTypes.SettingsSimilarityBm25
        | SettingsSimilarityBoolean of IndicesTypes.SettingsSimilarityBoolean
        | SettingsSimilarityDfi of IndicesTypes.SettingsSimilarityDfi
        | SettingsSimilarityDfr of IndicesTypes.SettingsSimilarityDfr
        | SettingsSimilarityIb of IndicesTypes.SettingsSimilarityIb
        | SettingsSimilarityLmd of IndicesTypes.SettingsSimilarityLmd
        | SettingsSimilarityLmj of IndicesTypes.SettingsSimilarityLmj
        | SettingsSimilarityScripted of IndicesTypes.SettingsSimilarityScripted
        | Unknown of name: string * System.Text.Json.JsonElement

    type MappingLimitSettingsTotalFields = {
        [<System.Text.Json.Serialization.JsonPropertyName("limit")>]
        Limit: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_dynamic_beyond_limit")>]
        IgnoreDynamicBeyondLimit: System.Text.Json.JsonElement option
    }

    type MappingLimitSettingsDepth = {
        [<System.Text.Json.Serialization.JsonPropertyName("limit")>]
        Limit: Types.Long option
    }

    type MappingLimitSettingsNestedFields = {
        [<System.Text.Json.Serialization.JsonPropertyName("limit")>]
        Limit: Types.Long option
    }

    type MappingLimitSettingsNestedObjects = {
        [<System.Text.Json.Serialization.JsonPropertyName("limit")>]
        Limit: Types.Long option
    }

    type MappingLimitSettingsFieldNameLength = {
        [<System.Text.Json.Serialization.JsonPropertyName("limit")>]
        Limit: Types.Long option
    }

    type MappingLimitSettingsDimensionFields = {
        [<System.Text.Json.Serialization.JsonPropertyName("limit")>]
        Limit: Types.Long option
    }

    [<RequireQualifiedAccess>]
    type SourceMode =
        | Disabled
        | Stored
        | Synthetic

    type MappingLimitSettingsSourceFields = {
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: IndicesTypes.SourceMode
    }

    /// Mapping Limit Settings
    type MappingLimitSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("coerce")>]
        Coerce: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("total_fields")>]
        TotalFields: IndicesTypes.MappingLimitSettingsTotalFields option
        [<System.Text.Json.Serialization.JsonPropertyName("depth")>]
        Depth: IndicesTypes.MappingLimitSettingsDepth option
        [<System.Text.Json.Serialization.JsonPropertyName("nested_fields")>]
        NestedFields: IndicesTypes.MappingLimitSettingsNestedFields option
        [<System.Text.Json.Serialization.JsonPropertyName("nested_objects")>]
        NestedObjects: IndicesTypes.MappingLimitSettingsNestedObjects option
        [<System.Text.Json.Serialization.JsonPropertyName("field_name_length")>]
        FieldNameLength: IndicesTypes.MappingLimitSettingsFieldNameLength option
        [<System.Text.Json.Serialization.JsonPropertyName("dimension_fields")>]
        DimensionFields: IndicesTypes.MappingLimitSettingsDimensionFields option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: IndicesTypes.MappingLimitSettingsSourceFields option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_malformed")>]
        IgnoreMalformed: System.Text.Json.JsonElement option
    }

    type IndexingSlowlogTresholds = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: IndicesTypes.SlowlogTresholdLevels option
    }

    type IndexingSlowlogSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("level")>]
        Level: string option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("reformat")>]
        Reformat: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("threshold")>]
        Threshold: IndicesTypes.IndexingSlowlogTresholds option
    }

    type IndexingPressureMemory = {
        [<System.Text.Json.Serialization.JsonPropertyName("limit")>]
        Limit: Types.Integer option
    }

    type IndexingPressure = {
        [<System.Text.Json.Serialization.JsonPropertyName("memory")>]
        Memory: IndicesTypes.IndexingPressureMemory
    }

    [<RequireQualifiedAccess>]
    type StorageType =
        | Fs
        | Niofs
        | Mmapfs
        | Hybridfs
        | Custom of string

    type Storage = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: IndicesTypes.StorageType
        [<System.Text.Json.Serialization.JsonPropertyName("allow_mmap")>]
        AllowMmap: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("stats_refresh_interval")>]
        StatsRefreshInterval: Types.Duration option
    }

    type IndexSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: IndicesTypes.IndexSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: string option
        [<System.Text.Json.Serialization.JsonPropertyName("routing_path")>]
        RoutingPath: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("soft_deletes")>]
        SoftDeletes: IndicesTypes.SoftDeletes option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: IndicesTypes.IndexSegmentSort option
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_shards")>]
        NumberOfShards: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_replicas")>]
        NumberOfReplicas: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_routing_shards")>]
        NumberOfRoutingShards: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("check_on_startup")>]
        CheckOnStartup: IndicesTypes.IndexCheckOnStartup option
        [<System.Text.Json.Serialization.JsonPropertyName("codec")>]
        Codec: string option
        [<System.Text.Json.Serialization.JsonPropertyName("routing_partition_size")>]
        RoutingPartitionSize: SpecUtils.Stringified<Types.Integer> option
        [<System.Text.Json.Serialization.JsonPropertyName("load_fixed_bitset_filters_eagerly")>]
        LoadFixedBitsetFiltersEagerly: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("hidden")>]
        Hidden: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("auto_expand_replicas")>]
        AutoExpandReplicas: SpecUtils.WithNullValue<string> option
        [<System.Text.Json.Serialization.JsonPropertyName("merge")>]
        Merge: IndicesTypes.Merge option
        [<System.Text.Json.Serialization.JsonPropertyName("search")>]
        Search: IndicesTypes.SettingsSearch option
        [<System.Text.Json.Serialization.JsonPropertyName("refresh_interval")>]
        RefreshInterval: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("max_result_window")>]
        MaxResultWindow: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_inner_result_window")>]
        MaxInnerResultWindow: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_rescore_window")>]
        MaxRescoreWindow: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_docvalue_fields_search")>]
        MaxDocvalueFieldsSearch: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_script_fields")>]
        MaxScriptFields: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_ngram_diff")>]
        MaxNgramDiff: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_shingle_diff")>]
        MaxShingleDiff: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("blocks")>]
        Blocks: IndicesTypes.IndexSettingBlocks option
        [<System.Text.Json.Serialization.JsonPropertyName("max_refresh_listeners")>]
        MaxRefreshListeners: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("analyze")>]
        Analyze: IndicesTypes.SettingsAnalyze option
        [<System.Text.Json.Serialization.JsonPropertyName("highlight")>]
        Highlight: IndicesTypes.SettingsHighlight option
        [<System.Text.Json.Serialization.JsonPropertyName("max_terms_count")>]
        MaxTermsCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_regex_length")>]
        MaxRegexLength: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: IndicesTypes.IndexRouting option
        [<System.Text.Json.Serialization.JsonPropertyName("gc_deletes")>]
        GcDeletes: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("default_pipeline")>]
        DefaultPipeline: Types.PipelineName option
        [<System.Text.Json.Serialization.JsonPropertyName("final_pipeline")>]
        FinalPipeline: Types.PipelineName option
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle")>]
        Lifecycle: IndicesTypes.IndexSettingsLifecycle option
        [<System.Text.Json.Serialization.JsonPropertyName("provided_name")>]
        ProvidedName: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("creation_date")>]
        CreationDate: SpecUtils.Stringified<Types.EpochTime<Types.UnitMillis>> option
        [<System.Text.Json.Serialization.JsonPropertyName("creation_date_string")>]
        CreationDateString: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("uuid")>]
        Uuid: Types.Uuid option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: IndicesTypes.IndexVersioning option
        [<System.Text.Json.Serialization.JsonPropertyName("verified_before_close")>]
        VerifiedBeforeClose: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("max_slices_per_scroll")>]
        MaxSlicesPerScroll: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("translog")>]
        Translog: IndicesTypes.Translog option
        [<System.Text.Json.Serialization.JsonPropertyName("query_string")>]
        QueryString: IndicesTypes.SettingsQueryString option
        [<System.Text.Json.Serialization.JsonPropertyName("priority")>]
        Priority: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("top_metrics_max_size")>]
        TopMetricsMaxSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("analysis")>]
        Analysis: IndicesTypes.IndexSettingsAnalysis option
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: IndicesTypes.IndexSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("time_series")>]
        TimeSeries: IndicesTypes.IndexSettingsTimeSeries option
        [<System.Text.Json.Serialization.JsonPropertyName("queries")>]
        Queries: IndicesTypes.Queries option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity")>]
        Similarity: Map<string, IndicesTypes.SettingsSimilarity> option
        [<System.Text.Json.Serialization.JsonPropertyName("mapping")>]
        Mapping: IndicesTypes.MappingLimitSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing.slowlog")>]
        IndexingSlowlog: IndicesTypes.IndexingSlowlogSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing_pressure")>]
        IndexingPressure: IndicesTypes.IndexingPressure option
        [<System.Text.Json.Serialization.JsonPropertyName("store")>]
        Store: IndicesTypes.Storage option
    }

    type DataStreamTimestampField = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Field
    }

    type DataStream = {
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_custom_routing")>]
        AllowCustomRouting: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("failure_store")>]
        FailureStore: IndicesTypes.FailureStore option
        [<System.Text.Json.Serialization.JsonPropertyName("generation")>]
        Generation: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("hidden")>]
        Hidden: bool
        [<System.Text.Json.Serialization.JsonPropertyName("ilm_policy")>]
        IlmPolicy: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("next_generation_managed_by")>]
        NextGenerationManagedBy: IndicesTypes.ManagedBy
        [<System.Text.Json.Serialization.JsonPropertyName("prefer_ilm")>]
        PreferIlm: bool
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: IndicesTypes.DataStreamIndex list
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle")>]
        Lifecycle: IndicesTypes.DataStreamLifecycleWithRollover option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.DataStreamName
        [<System.Text.Json.Serialization.JsonPropertyName("replicated")>]
        Replicated: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("rollover_on_write")>]
        RolloverOnWrite: bool
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: IndicesTypes.IndexSettings
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: TypesMapping.TypeMapping option
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: Types.HealthStatus
        [<System.Text.Json.Serialization.JsonPropertyName("system")>]
        System: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("template")>]
        Template: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp_field")>]
        TimestampField: IndicesTypes.DataStreamTimestampField
        [<System.Text.Json.Serialization.JsonPropertyName("index_mode")>]
        IndexMode: IndicesTypes.IndexMode option
    }

    /// The failure store lifecycle configures the data stream lifecycle configuration for failure indices.
    type FailureStoreLifecycle = {
        [<System.Text.Json.Serialization.JsonPropertyName("data_retention")>]
        DataRetention: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
    }

    /// Data stream failure store contains the configuration of the failure store for a given data stream.
    type DataStreamFailureStore = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle")>]
        Lifecycle: IndicesTypes.FailureStoreLifecycle option
    }

    /// Template equivalent of FailureStoreLifecycle that allows nullable values.
    type FailureStoreLifecycleTemplate = {
        [<System.Text.Json.Serialization.JsonPropertyName("data_retention")>]
        DataRetention: Types.Duration option option
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
    }

    /// Template equivalent of DataStreamFailureStore that allows nullable values.
    type DataStreamFailureStoreTemplate = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option option
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle")>]
        Lifecycle: IndicesTypes.FailureStoreLifecycleTemplate option option
    }

    /// Data stream options contain the configuration of data stream level features for a given data stream, for example,
    type DataStreamOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("failure_store")>]
        FailureStore: IndicesTypes.DataStreamFailureStore option
    }

    /// Data stream options template contains the same information as DataStreamOptions but allows them to be set explicitly to null.
    type DataStreamOptionsTemplate = {
        [<System.Text.Json.Serialization.JsonPropertyName("failure_store")>]
        FailureStore: IndicesTypes.DataStreamFailureStoreTemplate option option
    }

    type DataStreamVisibility = {
        [<System.Text.Json.Serialization.JsonPropertyName("hidden")>]
        Hidden: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_custom_routing")>]
        AllowCustomRouting: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("failure_store")>]
        FailureStore: bool option
    }

    type DownsampleConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("fixed_interval")>]
        FixedInterval: Types.DurationLarge
        [<System.Text.Json.Serialization.JsonPropertyName("sampling_method")>]
        SamplingMethod: IndicesTypes.SamplingMethod option
    }

    type FielddataFrequencyFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("min")>]
        Min: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("min_segment_size")>]
        MinSegmentSize: Types.Integer
    }

    type IndexState = {
        [<System.Text.Json.Serialization.JsonPropertyName("aliases")>]
        Aliases: Map<Types.IndexName, IndicesTypes.Alias> option
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: TypesMapping.TypeMapping option
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: IndicesTypes.IndexSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("defaults")>]
        Defaults: IndicesTypes.IndexSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("data_stream")>]
        DataStream: Types.DataStreamName option
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle")>]
        Lifecycle: IndicesTypes.DataStreamLifecycle option
    }

    type IndexTemplateSummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("aliases")>]
        Aliases: Map<Types.IndexName, IndicesTypes.Alias> option
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: TypesMapping.TypeMapping option
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: IndicesTypes.IndexSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle")>]
        Lifecycle: IndicesTypes.DataStreamLifecycle option
        [<System.Text.Json.Serialization.JsonPropertyName("data_stream_options")>]
        DataStreamOptions: IndicesTypes.DataStreamOptions option
    }

    type IndexTemplateDataStreamConfiguration = {
        [<System.Text.Json.Serialization.JsonPropertyName("hidden")>]
        Hidden: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_custom_routing")>]
        AllowCustomRouting: bool option
    }

    type IndexTemplate = {
        [<System.Text.Json.Serialization.JsonPropertyName("index_patterns")>]
        IndexPatterns: Types.Names
        [<System.Text.Json.Serialization.JsonPropertyName("composed_of")>]
        ComposedOf: Types.Name list
        [<System.Text.Json.Serialization.JsonPropertyName("template")>]
        Template: IndicesTypes.IndexTemplateSummary option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("priority")>]
        Priority: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_auto_create")>]
        AllowAutoCreate: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("data_stream")>]
        DataStream: IndicesTypes.IndexTemplateDataStreamConfiguration option
        [<System.Text.Json.Serialization.JsonPropertyName("deprecated")>]
        Deprecated: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing_component_templates")>]
        IgnoreMissingComponentTemplates: Types.Names option
        [<System.Text.Json.Serialization.JsonPropertyName("created_date")>]
        CreatedDate: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("created_date_millis")>]
        CreatedDateMillis: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date")>]
        ModifiedDate: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date_millis")>]
        ModifiedDateMillis: Types.EpochTime<Types.UnitMillis> option
    }

    type IndexTemplateSummaryWithRollover = {
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle")>]
        Lifecycle: IndicesTypes.DataStreamLifecycleWithRollover option
        [<System.Text.Json.Serialization.JsonPropertyName("aliases")>]
        Aliases: Map<Types.IndexName, IndicesTypes.Alias> option
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: TypesMapping.TypeMapping option
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: IndicesTypes.IndexSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("data_stream_options")>]
        DataStreamOptions: IndicesTypes.DataStreamOptions option
    }

    type IndexTemplateWithRollover = {
        [<System.Text.Json.Serialization.JsonPropertyName("template")>]
        Template: IndicesTypes.IndexTemplateSummaryWithRollover option
        [<System.Text.Json.Serialization.JsonPropertyName("index_patterns")>]
        IndexPatterns: Types.Names
        [<System.Text.Json.Serialization.JsonPropertyName("composed_of")>]
        ComposedOf: Types.Name list
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("priority")>]
        Priority: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_auto_create")>]
        AllowAutoCreate: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("data_stream")>]
        DataStream: IndicesTypes.IndexTemplateDataStreamConfiguration option
        [<System.Text.Json.Serialization.JsonPropertyName("deprecated")>]
        Deprecated: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing_component_templates")>]
        IgnoreMissingComponentTemplates: Types.Names option
        [<System.Text.Json.Serialization.JsonPropertyName("created_date")>]
        CreatedDate: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("created_date_millis")>]
        CreatedDateMillis: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date")>]
        ModifiedDate: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date_millis")>]
        ModifiedDateMillis: Types.EpochTime<Types.UnitMillis> option
    }

    [<RequireQualifiedAccess>]
    type IndicesBlockOptions =
        | Metadata
        | Read
        | ReadOnly
        | Write

    [<RequireQualifiedAccess>]
    type NumericFielddataFormat =
        | Array
        | Disabled

    type NumericFielddata = {
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: IndicesTypes.NumericFielddataFormat
    }

    type TemplateMapping = {
        [<System.Text.Json.Serialization.JsonPropertyName("aliases")>]
        Aliases: Map<Types.IndexName, IndicesTypes.Alias>
        [<System.Text.Json.Serialization.JsonPropertyName("index_patterns")>]
        IndexPatterns: Types.Name list
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: TypesMapping.TypeMapping
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: Map<string, System.Text.Json.JsonElement>
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionNumber option
    }


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesTypes =

    type Alias = {
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: CoreTypes.QueryContainer option
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
        Filter: CoreTypes.QueryContainer option
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
        | IndexLifecycleManagement
        | DataStreamLifecycle
        | Unmanaged

    [<RequireQualifiedAccess>]
    type IndexMode =
        | Standard
        | TimeSeries
        | Logsdb
        | Lookup

    type DataStreamIndex = {
        [<System.Text.Json.Serialization.JsonPropertyName("index_name")>]
        IndexName: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("index_uuid")>]
        IndexUuid: CoreTypes.Uuid
        [<System.Text.Json.Serialization.JsonPropertyName("ilm_policy")>]
        IlmPolicy: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("managed_by")>]
        ManagedBy: ManagedBy option
        [<System.Text.Json.Serialization.JsonPropertyName("prefer_ilm")>]
        PreferIlm: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index_mode")>]
        IndexMode: IndexMode option
    }

    type FailureStore = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: DataStreamIndex list
        [<System.Text.Json.Serialization.JsonPropertyName("rollover_on_write")>]
        RolloverOnWrite: bool
    }

    type DataStreamLifecycleRolloverConditions = {
        [<System.Text.Json.Serialization.JsonPropertyName("min_age")>]
        MinAge: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("max_age")>]
        MaxAge: string option
        [<System.Text.Json.Serialization.JsonPropertyName("min_docs")>]
        MinDocs: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("max_docs")>]
        MaxDocs: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("min_size")>]
        MinSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("max_size")>]
        MaxSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("min_primary_shard_size")>]
        MinPrimaryShardSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("max_primary_shard_size")>]
        MaxPrimaryShardSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("min_primary_shard_docs")>]
        MinPrimaryShardDocs: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("max_primary_shard_docs")>]
        MaxPrimaryShardDocs: CoreTypes.Long option
    }

    type DownsamplingRound = {
        [<System.Text.Json.Serialization.JsonPropertyName("after")>]
        After: CoreTypes.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("fixed_interval")>]
        FixedInterval: CoreTypes.DurationLarge
    }

    [<RequireQualifiedAccess>]
    type SamplingMethod =
        | Aggregate
        | LastValue

    /// Data stream lifecycle denotes that a data stream is managed by the data stream lifecycle and contains the configuration.
    type DataStreamLifecycle = {
        [<System.Text.Json.Serialization.JsonPropertyName("data_retention")>]
        DataRetention: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("downsampling")>]
        Downsampling: DownsamplingRound list option
        [<System.Text.Json.Serialization.JsonPropertyName("downsampling_method")>]
        DownsamplingMethod: SamplingMethod option
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("frozen_after")>]
        FrozenAfter: CoreTypes.Duration option
    }

    /// Data stream lifecycle with rollover can be used to display the configuration including the default rollover conditions,
    type DataStreamLifecycleWithRollover = {
        [<System.Text.Json.Serialization.JsonPropertyName("rollover")>]
        Rollover: DataStreamLifecycleRolloverConditions option
    }

    type RetentionLease = {
        [<System.Text.Json.Serialization.JsonPropertyName("period")>]
        Period: CoreTypes.Duration
    }

    type SoftDeletes = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("retention_lease")>]
        RetentionLease: RetentionLease option
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
        Field: CoreTypes.Fields option
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
        MaxThreadCount: CoreTypes.Stringified<CoreTypes.Integer> option
        [<System.Text.Json.Serialization.JsonPropertyName("max_merge_count")>]
        MaxMergeCount: CoreTypes.Stringified<CoreTypes.Integer> option
    }

    type Merge = {
        [<System.Text.Json.Serialization.JsonPropertyName("scheduler")>]
        Scheduler: MergeScheduler option
    }

    type SearchIdle = {
        [<System.Text.Json.Serialization.JsonPropertyName("after")>]
        After: CoreTypes.Duration option
    }

    type SlowlogTresholdLevels = {
        [<System.Text.Json.Serialization.JsonPropertyName("warn")>]
        Warn: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("info")>]
        Info: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("debug")>]
        Debug: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("trace")>]
        Trace: CoreTypes.Duration option
    }

    type SlowlogTresholds = {
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: SlowlogTresholdLevels option
        [<System.Text.Json.Serialization.JsonPropertyName("fetch")>]
        Fetch: SlowlogTresholdLevels option
    }

    type SlowlogSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("level")>]
        Level: string option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("reformat")>]
        Reformat: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("threshold")>]
        Threshold: SlowlogTresholds option
    }

    type SettingsSearch = {
        [<System.Text.Json.Serialization.JsonPropertyName("idle")>]
        Idle: SearchIdle option
        [<System.Text.Json.Serialization.JsonPropertyName("slowlog")>]
        Slowlog: SlowlogSettings option
    }

    type IndexSettingBlocks = {
        [<System.Text.Json.Serialization.JsonPropertyName("read_only")>]
        ReadOnly: CoreTypes.Stringified<bool> option
        [<System.Text.Json.Serialization.JsonPropertyName("read_only_allow_delete")>]
        ReadOnlyAllowDelete: CoreTypes.Stringified<bool> option
        [<System.Text.Json.Serialization.JsonPropertyName("read")>]
        Read: CoreTypes.Stringified<bool> option
        [<System.Text.Json.Serialization.JsonPropertyName("write")>]
        Write: CoreTypes.Stringified<bool> option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: CoreTypes.Stringified<bool> option
    }

    type SettingsAnalyze = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_token_count")>]
        MaxTokenCount: CoreTypes.Stringified<CoreTypes.Integer> option
    }

    type SettingsHighlight = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_analyzed_offset")>]
        MaxAnalyzedOffset: CoreTypes.Integer option
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
        Id: CoreTypes.Id option
    }

    type IndexRoutingAllocationInitialRecovery = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: CoreTypes.Id option
    }

    type IndexRoutingAllocationDisk = {
        [<System.Text.Json.Serialization.JsonPropertyName("threshold_enabled")>]
        ThresholdEnabled: System.Text.Json.JsonElement option
    }

    type IndexRoutingAllocation = {
        [<System.Text.Json.Serialization.JsonPropertyName("enable")>]
        Enable: IndexRoutingAllocationOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("include")>]
        Include: IndexRoutingAllocationInclude option
        [<System.Text.Json.Serialization.JsonPropertyName("initial_recovery")>]
        InitialRecovery: IndexRoutingAllocationInitialRecovery option
        [<System.Text.Json.Serialization.JsonPropertyName("disk")>]
        Disk: IndexRoutingAllocationDisk option
    }

    [<RequireQualifiedAccess>]
    type IndexRoutingRebalanceOptions =
        | All
        | Primaries
        | Replicas
        | None

    type IndexRoutingRebalance = {
        [<System.Text.Json.Serialization.JsonPropertyName("enable")>]
        Enable: IndexRoutingRebalanceOptions
    }

    type IndexRouting = {
        [<System.Text.Json.Serialization.JsonPropertyName("allocation")>]
        Allocation: IndexRoutingAllocation option
        [<System.Text.Json.Serialization.JsonPropertyName("rebalance")>]
        Rebalance: IndexRoutingRebalance option
    }

    type IndexSettingsLifecycleStep = {
        [<System.Text.Json.Serialization.JsonPropertyName("wait_time_threshold")>]
        WaitTimeThreshold: CoreTypes.Duration option
    }

    type IndexSettingsLifecycle = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing_complete")>]
        IndexingComplete: CoreTypes.Stringified<bool> option
        [<System.Text.Json.Serialization.JsonPropertyName("origination_date")>]
        OriginationDate: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("parse_origination_date")>]
        ParseOriginationDate: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("step")>]
        Step: IndexSettingsLifecycleStep option
        [<System.Text.Json.Serialization.JsonPropertyName("rollover_alias")>]
        RolloverAlias: string option
        [<System.Text.Json.Serialization.JsonPropertyName("prefer_ilm")>]
        PreferIlm: System.Text.Json.JsonElement option
    }

    type IndexVersioning = {
        [<System.Text.Json.Serialization.JsonPropertyName("created")>]
        Created: CoreTypes.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("created_string")>]
        CreatedString: string option
    }

    [<RequireQualifiedAccess>]
    type TranslogDurability =
        | Request
        | Async

    type TranslogRetention = {
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("age")>]
        Age: CoreTypes.Duration option
    }

    type Translog = {
        [<System.Text.Json.Serialization.JsonPropertyName("sync_interval")>]
        SyncInterval: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("durability")>]
        Durability: TranslogDurability option
        [<System.Text.Json.Serialization.JsonPropertyName("flush_threshold_size")>]
        FlushThresholdSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("retention")>]
        Retention: TranslogRetention option
    }

    type SettingsQueryString = {
        [<System.Text.Json.Serialization.JsonPropertyName("lenient")>]
        Lenient: CoreTypes.Stringified<bool>
    }

    type IndexSettingsAnalysis = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: Map<string, CoreTypes.Analyzer> option
        [<System.Text.Json.Serialization.JsonPropertyName("char_filter")>]
        CharFilter: Map<string, CoreTypes.CharFilter> option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: Map<string, CoreTypes.TokenFilter> option
        [<System.Text.Json.Serialization.JsonPropertyName("normalizer")>]
        Normalizer: Map<string, CoreTypes.Normalizer> option
        [<System.Text.Json.Serialization.JsonPropertyName("tokenizer")>]
        Tokenizer: Map<string, CoreTypes.Tokenizer> option
    }

    type IndexSettingsTimeSeries = {
        [<System.Text.Json.Serialization.JsonPropertyName("end_time")>]
        EndTime: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("start_time")>]
        StartTime: CoreTypes.DateTime option
    }

    type Queries = {
        [<System.Text.Json.Serialization.JsonPropertyName("cache")>]
        Cache: CacheQueries option
    }

    type SettingsSimilarityBm25 = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("b")>]
        B: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("discount_overlaps")>]
        DiscountOverlaps: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("k1")>]
        K1: CoreTypes.Double option
    }

    type SettingsSimilarityBoolean = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type SettingsSimilarityDfi = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("independence_measure")>]
        IndependenceMeasure: CoreTypes.DFIIndependenceMeasure
    }

    type SettingsSimilarityDfr = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("after_effect")>]
        AfterEffect: CoreTypes.DFRAfterEffect
        [<System.Text.Json.Serialization.JsonPropertyName("basic_model")>]
        BasicModel: CoreTypes.DFRBasicModel
        [<System.Text.Json.Serialization.JsonPropertyName("normalization")>]
        Normalization: CoreTypes.Normalization
    }

    type SettingsSimilarityIb = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("distribution")>]
        Distribution: CoreTypes.IBDistribution
        [<System.Text.Json.Serialization.JsonPropertyName("lambda")>]
        Lambda: CoreTypes.IBLambda
        [<System.Text.Json.Serialization.JsonPropertyName("normalization")>]
        Normalization: CoreTypes.Normalization
    }

    type SettingsSimilarityLmd = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("mu")>]
        Mu: CoreTypes.Double option
    }

    type SettingsSimilarityLmj = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("lambda")>]
        Lambda: CoreTypes.Double option
    }

    type SettingsSimilarityScripted = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: CoreTypes.Script
        [<System.Text.Json.Serialization.JsonPropertyName("weight_script")>]
        WeightScript: CoreTypes.Script option
    }

    [<RequireQualifiedAccess>]
    type SettingsSimilarity =
        | SettingsSimilarityBm25 of SettingsSimilarityBm25
        | SettingsSimilarityBoolean of SettingsSimilarityBoolean
        | SettingsSimilarityDfi of SettingsSimilarityDfi
        | SettingsSimilarityDfr of SettingsSimilarityDfr
        | SettingsSimilarityIb of SettingsSimilarityIb
        | SettingsSimilarityLmd of SettingsSimilarityLmd
        | SettingsSimilarityLmj of SettingsSimilarityLmj
        | SettingsSimilarityScripted of SettingsSimilarityScripted
        | Unknown of name: string * System.Text.Json.JsonElement

    type MappingLimitSettingsTotalFields = {
        [<System.Text.Json.Serialization.JsonPropertyName("limit")>]
        Limit: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_dynamic_beyond_limit")>]
        IgnoreDynamicBeyondLimit: System.Text.Json.JsonElement option
    }

    type MappingLimitSettingsDepth = {
        [<System.Text.Json.Serialization.JsonPropertyName("limit")>]
        Limit: CoreTypes.Long option
    }

    type MappingLimitSettingsNestedFields = {
        [<System.Text.Json.Serialization.JsonPropertyName("limit")>]
        Limit: CoreTypes.Long option
    }

    type MappingLimitSettingsNestedObjects = {
        [<System.Text.Json.Serialization.JsonPropertyName("limit")>]
        Limit: CoreTypes.Long option
    }

    type MappingLimitSettingsFieldNameLength = {
        [<System.Text.Json.Serialization.JsonPropertyName("limit")>]
        Limit: CoreTypes.Long option
    }

    type MappingLimitSettingsDimensionFields = {
        [<System.Text.Json.Serialization.JsonPropertyName("limit")>]
        Limit: CoreTypes.Long option
    }

    [<RequireQualifiedAccess>]
    type SourceMode =
        | Disabled
        | Stored
        | Synthetic

    type MappingLimitSettingsSourceFields = {
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: SourceMode
    }

    /// Mapping Limit Settings
    type MappingLimitSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("coerce")>]
        Coerce: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("total_fields")>]
        TotalFields: MappingLimitSettingsTotalFields option
        [<System.Text.Json.Serialization.JsonPropertyName("depth")>]
        Depth: MappingLimitSettingsDepth option
        [<System.Text.Json.Serialization.JsonPropertyName("nested_fields")>]
        NestedFields: MappingLimitSettingsNestedFields option
        [<System.Text.Json.Serialization.JsonPropertyName("nested_objects")>]
        NestedObjects: MappingLimitSettingsNestedObjects option
        [<System.Text.Json.Serialization.JsonPropertyName("field_name_length")>]
        FieldNameLength: MappingLimitSettingsFieldNameLength option
        [<System.Text.Json.Serialization.JsonPropertyName("dimension_fields")>]
        DimensionFields: MappingLimitSettingsDimensionFields option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: MappingLimitSettingsSourceFields option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_malformed")>]
        IgnoreMalformed: System.Text.Json.JsonElement option
    }

    type IndexingSlowlogTresholds = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: SlowlogTresholdLevels option
    }

    type IndexingSlowlogSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("level")>]
        Level: string option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("reformat")>]
        Reformat: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("threshold")>]
        Threshold: IndexingSlowlogTresholds option
    }

    type IndexingPressureMemory = {
        [<System.Text.Json.Serialization.JsonPropertyName("limit")>]
        Limit: CoreTypes.Integer option
    }

    type IndexingPressure = {
        [<System.Text.Json.Serialization.JsonPropertyName("memory")>]
        Memory: IndexingPressureMemory
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
        Type: StorageType
        [<System.Text.Json.Serialization.JsonPropertyName("allow_mmap")>]
        AllowMmap: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("stats_refresh_interval")>]
        StatsRefreshInterval: CoreTypes.Duration option
    }

    type IndexSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: IndexSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: string option
        [<System.Text.Json.Serialization.JsonPropertyName("routing_path")>]
        RoutingPath: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("soft_deletes")>]
        SoftDeletes: SoftDeletes option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: IndexSegmentSort option
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_shards")>]
        NumberOfShards: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_replicas")>]
        NumberOfReplicas: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_routing_shards")>]
        NumberOfRoutingShards: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("check_on_startup")>]
        CheckOnStartup: IndexCheckOnStartup option
        [<System.Text.Json.Serialization.JsonPropertyName("codec")>]
        Codec: string option
        [<System.Text.Json.Serialization.JsonPropertyName("routing_partition_size")>]
        RoutingPartitionSize: CoreTypes.Stringified<CoreTypes.Integer> option
        [<System.Text.Json.Serialization.JsonPropertyName("load_fixed_bitset_filters_eagerly")>]
        LoadFixedBitsetFiltersEagerly: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("hidden")>]
        Hidden: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("auto_expand_replicas")>]
        AutoExpandReplicas: CoreTypes.WithNullValue<string> option
        [<System.Text.Json.Serialization.JsonPropertyName("merge")>]
        Merge: Merge option
        [<System.Text.Json.Serialization.JsonPropertyName("search")>]
        Search: SettingsSearch option
        [<System.Text.Json.Serialization.JsonPropertyName("refresh_interval")>]
        RefreshInterval: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("max_result_window")>]
        MaxResultWindow: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_inner_result_window")>]
        MaxInnerResultWindow: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_rescore_window")>]
        MaxRescoreWindow: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_docvalue_fields_search")>]
        MaxDocvalueFieldsSearch: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_script_fields")>]
        MaxScriptFields: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_ngram_diff")>]
        MaxNgramDiff: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_shingle_diff")>]
        MaxShingleDiff: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("blocks")>]
        Blocks: IndexSettingBlocks option
        [<System.Text.Json.Serialization.JsonPropertyName("max_refresh_listeners")>]
        MaxRefreshListeners: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("analyze")>]
        Analyze: SettingsAnalyze option
        [<System.Text.Json.Serialization.JsonPropertyName("highlight")>]
        Highlight: SettingsHighlight option
        [<System.Text.Json.Serialization.JsonPropertyName("max_terms_count")>]
        MaxTermsCount: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_regex_length")>]
        MaxRegexLength: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: IndexRouting option
        [<System.Text.Json.Serialization.JsonPropertyName("gc_deletes")>]
        GcDeletes: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("default_pipeline")>]
        DefaultPipeline: CoreTypes.PipelineName option
        [<System.Text.Json.Serialization.JsonPropertyName("final_pipeline")>]
        FinalPipeline: CoreTypes.PipelineName option
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle")>]
        Lifecycle: IndexSettingsLifecycle option
        [<System.Text.Json.Serialization.JsonPropertyName("provided_name")>]
        ProvidedName: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("creation_date")>]
        CreationDate: CoreTypes.Stringified<CoreTypes.EpochTime<CoreTypes.UnitMillis>> option
        [<System.Text.Json.Serialization.JsonPropertyName("creation_date_string")>]
        CreationDateString: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("uuid")>]
        Uuid: CoreTypes.Uuid option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: IndexVersioning option
        [<System.Text.Json.Serialization.JsonPropertyName("verified_before_close")>]
        VerifiedBeforeClose: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("max_slices_per_scroll")>]
        MaxSlicesPerScroll: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("translog")>]
        Translog: Translog option
        [<System.Text.Json.Serialization.JsonPropertyName("query_string")>]
        QueryString: SettingsQueryString option
        [<System.Text.Json.Serialization.JsonPropertyName("priority")>]
        Priority: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("top_metrics_max_size")>]
        TopMetricsMaxSize: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("analysis")>]
        Analysis: IndexSettingsAnalysis option
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: IndexSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("time_series")>]
        TimeSeries: IndexSettingsTimeSeries option
        [<System.Text.Json.Serialization.JsonPropertyName("queries")>]
        Queries: Queries option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity")>]
        Similarity: Map<string, SettingsSimilarity> option
        [<System.Text.Json.Serialization.JsonPropertyName("mapping")>]
        Mapping: MappingLimitSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing.slowlog")>]
        IndexingSlowlog: IndexingSlowlogSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing_pressure")>]
        IndexingPressure: IndexingPressure option
        [<System.Text.Json.Serialization.JsonPropertyName("store")>]
        Store: Storage option
    }

    type DataStreamTimestampField = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Field
    }

    type DataStream = {
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: CoreTypes.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_custom_routing")>]
        AllowCustomRouting: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("failure_store")>]
        FailureStore: FailureStore option
        [<System.Text.Json.Serialization.JsonPropertyName("generation")>]
        Generation: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("hidden")>]
        Hidden: bool
        [<System.Text.Json.Serialization.JsonPropertyName("ilm_policy")>]
        IlmPolicy: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("next_generation_managed_by")>]
        NextGenerationManagedBy: ManagedBy
        [<System.Text.Json.Serialization.JsonPropertyName("prefer_ilm")>]
        PreferIlm: bool
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: DataStreamIndex list
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle")>]
        Lifecycle: DataStreamLifecycleWithRollover option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.DataStreamName
        [<System.Text.Json.Serialization.JsonPropertyName("replicated")>]
        Replicated: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("rollover_on_write")>]
        RolloverOnWrite: bool
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: IndexSettings
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: CoreTypes.TypeMapping option
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: CoreTypes.HealthStatus
        [<System.Text.Json.Serialization.JsonPropertyName("system")>]
        System: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("template")>]
        Template: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp_field")>]
        TimestampField: DataStreamTimestampField
        [<System.Text.Json.Serialization.JsonPropertyName("index_mode")>]
        IndexMode: IndexMode option
    }

    /// The failure store lifecycle configures the data stream lifecycle configuration for failure indices.
    type FailureStoreLifecycle = {
        [<System.Text.Json.Serialization.JsonPropertyName("data_retention")>]
        DataRetention: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
    }

    /// Data stream failure store contains the configuration of the failure store for a given data stream.
    type DataStreamFailureStore = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle")>]
        Lifecycle: FailureStoreLifecycle option
    }

    /// Template equivalent of FailureStoreLifecycle that allows nullable values.
    type FailureStoreLifecycleTemplate = {
        [<System.Text.Json.Serialization.JsonPropertyName("data_retention")>]
        DataRetention: CoreTypes.Duration option option
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
    }

    /// Template equivalent of DataStreamFailureStore that allows nullable values.
    type DataStreamFailureStoreTemplate = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option option
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle")>]
        Lifecycle: FailureStoreLifecycleTemplate option option
    }

    /// Data stream options contain the configuration of data stream level features for a given data stream, for example,
    type DataStreamOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("failure_store")>]
        FailureStore: DataStreamFailureStore option
    }

    /// Data stream options template contains the same information as DataStreamOptions but allows them to be set explicitly to null.
    type DataStreamOptionsTemplate = {
        [<System.Text.Json.Serialization.JsonPropertyName("failure_store")>]
        FailureStore: DataStreamFailureStoreTemplate option option
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
        FixedInterval: CoreTypes.DurationLarge
        [<System.Text.Json.Serialization.JsonPropertyName("sampling_method")>]
        SamplingMethod: SamplingMethod option
    }

    type FielddataFrequencyFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("min")>]
        Min: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("min_segment_size")>]
        MinSegmentSize: CoreTypes.Integer
    }

    type IndexState = {
        [<System.Text.Json.Serialization.JsonPropertyName("aliases")>]
        Aliases: Map<CoreTypes.IndexName, Alias> option
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: CoreTypes.TypeMapping option
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: IndexSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("defaults")>]
        Defaults: IndexSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("data_stream")>]
        DataStream: CoreTypes.DataStreamName option
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle")>]
        Lifecycle: DataStreamLifecycle option
    }

    type IndexTemplateSummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("aliases")>]
        Aliases: Map<CoreTypes.IndexName, Alias> option
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: CoreTypes.TypeMapping option
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: IndexSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle")>]
        Lifecycle: DataStreamLifecycle option
        [<System.Text.Json.Serialization.JsonPropertyName("data_stream_options")>]
        DataStreamOptions: DataStreamOptions option
    }

    type IndexTemplateDataStreamConfiguration = {
        [<System.Text.Json.Serialization.JsonPropertyName("hidden")>]
        Hidden: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_custom_routing")>]
        AllowCustomRouting: bool option
    }

    type IndexTemplate = {
        [<System.Text.Json.Serialization.JsonPropertyName("index_patterns")>]
        IndexPatterns: CoreTypes.Names
        [<System.Text.Json.Serialization.JsonPropertyName("composed_of")>]
        ComposedOf: CoreTypes.Name list
        [<System.Text.Json.Serialization.JsonPropertyName("template")>]
        Template: IndexTemplateSummary option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("priority")>]
        Priority: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: CoreTypes.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_auto_create")>]
        AllowAutoCreate: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("data_stream")>]
        DataStream: IndexTemplateDataStreamConfiguration option
        [<System.Text.Json.Serialization.JsonPropertyName("deprecated")>]
        Deprecated: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing_component_templates")>]
        IgnoreMissingComponentTemplates: CoreTypes.Names option
        [<System.Text.Json.Serialization.JsonPropertyName("created_date")>]
        CreatedDate: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("created_date_millis")>]
        CreatedDateMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date")>]
        ModifiedDate: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date_millis")>]
        ModifiedDateMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
    }

    type IndexTemplateSummaryWithRollover = {
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle")>]
        Lifecycle: DataStreamLifecycleWithRollover option
        [<System.Text.Json.Serialization.JsonPropertyName("aliases")>]
        Aliases: Map<CoreTypes.IndexName, Alias> option
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: CoreTypes.TypeMapping option
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: IndexSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("data_stream_options")>]
        DataStreamOptions: DataStreamOptions option
    }

    type IndexTemplateWithRollover = {
        [<System.Text.Json.Serialization.JsonPropertyName("template")>]
        Template: IndexTemplateSummaryWithRollover option
        [<System.Text.Json.Serialization.JsonPropertyName("index_patterns")>]
        IndexPatterns: CoreTypes.Names
        [<System.Text.Json.Serialization.JsonPropertyName("composed_of")>]
        ComposedOf: CoreTypes.Name list
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("priority")>]
        Priority: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: CoreTypes.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_auto_create")>]
        AllowAutoCreate: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("data_stream")>]
        DataStream: IndexTemplateDataStreamConfiguration option
        [<System.Text.Json.Serialization.JsonPropertyName("deprecated")>]
        Deprecated: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing_component_templates")>]
        IgnoreMissingComponentTemplates: CoreTypes.Names option
        [<System.Text.Json.Serialization.JsonPropertyName("created_date")>]
        CreatedDate: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("created_date_millis")>]
        CreatedDateMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date")>]
        ModifiedDate: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date_millis")>]
        ModifiedDateMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
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
        Format: NumericFielddataFormat
    }

    type TemplateMapping = {
        [<System.Text.Json.Serialization.JsonPropertyName("aliases")>]
        Aliases: Map<CoreTypes.IndexName, Alias>
        [<System.Text.Json.Serialization.JsonPropertyName("index_patterns")>]
        IndexPatterns: CoreTypes.Name list
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: CoreTypes.TypeMapping
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: Map<string, System.Text.Json.JsonElement>
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionNumber option
    }


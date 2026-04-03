// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module ClusterStats =

    type RemoteClusterInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_uuid")>]
        ClusterUuid: string
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: string
        [<System.Text.Json.Serialization.JsonPropertyName("skip_unavailable")>]
        SkipUnavailable: bool
        [<System.Text.Json.Serialization.JsonPropertyName("transport.compress")>]
        TransportCompress: string
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: CoreTypes.HealthStatus
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionString list
        [<System.Text.Json.Serialization.JsonPropertyName("nodes_count")>]
        NodesCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("shards_count")>]
        ShardsCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("indices_count")>]
        IndicesCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("indices_total_size_in_bytes")>]
        IndicesTotalSizeInBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("indices_total_size")>]
        IndicesTotalSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_heap_in_bytes")>]
        MaxHeapInBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("max_heap")>]
        MaxHeap: string option
        [<System.Text.Json.Serialization.JsonPropertyName("mem_total_in_bytes")>]
        MemTotalInBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("mem_total")>]
        MemTotal: string option
    }

    type CCSUsageTimeValue = {
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("avg")>]
        Avg: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("p90")>]
        P90: CoreTypes.DurationValue<CoreTypes.UnitMillis>
    }

    type CCSUsageClusterStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("skipped")>]
        Skipped: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("took")>]
        Took: CCSUsageTimeValue
    }

    type CCSUsageStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("success")>]
        Success: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("skipped")>]
        Skipped: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("took")>]
        Took: CCSUsageTimeValue
        [<System.Text.Json.Serialization.JsonPropertyName("took_mrt_true")>]
        TookMrtTrue: CCSUsageTimeValue option
        [<System.Text.Json.Serialization.JsonPropertyName("took_mrt_false")>]
        TookMrtFalse: CCSUsageTimeValue option
        [<System.Text.Json.Serialization.JsonPropertyName("remotes_per_search_max")>]
        RemotesPerSearchMax: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("remotes_per_search_avg")>]
        RemotesPerSearchAvg: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("failure_reasons")>]
        FailureReasons: Map<string, CoreTypes.Integer>
        [<System.Text.Json.Serialization.JsonPropertyName("features")>]
        Features: Map<string, CoreTypes.Integer>
        [<System.Text.Json.Serialization.JsonPropertyName("clients")>]
        Clients: Map<string, CoreTypes.Integer>
        [<System.Text.Json.Serialization.JsonPropertyName("clusters")>]
        Clusters: Map<string, CCSUsageClusterStats>
    }

    type CCSStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("clusters")>]
        Clusters: Map<string, RemoteClusterInfo> option
        [<System.Text.Json.Serialization.JsonPropertyName("_search")>]
        Search: CCSUsageStats
        [<System.Text.Json.Serialization.JsonPropertyName("_esql")>]
        Esql: CCSUsageStats option
    }

    type FieldTypes = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("index_count")>]
        IndexCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("indexed_vector_count")>]
        IndexedVectorCount: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("indexed_vector_dim_max")>]
        IndexedVectorDimMax: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("indexed_vector_dim_min")>]
        IndexedVectorDimMin: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("script_count")>]
        ScriptCount: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("vector_index_type_count")>]
        VectorIndexTypeCount: Map<CoreTypes.Name, CoreTypes.Integer> option
        [<System.Text.Json.Serialization.JsonPropertyName("vector_similarity_type_count")>]
        VectorSimilarityTypeCount: Map<CoreTypes.Name, CoreTypes.Integer> option
        [<System.Text.Json.Serialization.JsonPropertyName("vector_element_type_count")>]
        VectorElementTypeCount: Map<CoreTypes.Name, CoreTypes.Integer> option
    }

    type SynonymsStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("index_count")>]
        IndexCount: CoreTypes.Integer
    }

    type CharFilterTypes = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer_types")>]
        AnalyzerTypes: FieldTypes list
        [<System.Text.Json.Serialization.JsonPropertyName("built_in_analyzers")>]
        BuiltInAnalyzers: FieldTypes list
        [<System.Text.Json.Serialization.JsonPropertyName("built_in_char_filters")>]
        BuiltInCharFilters: FieldTypes list
        [<System.Text.Json.Serialization.JsonPropertyName("built_in_filters")>]
        BuiltInFilters: FieldTypes list
        [<System.Text.Json.Serialization.JsonPropertyName("built_in_tokenizers")>]
        BuiltInTokenizers: FieldTypes list
        [<System.Text.Json.Serialization.JsonPropertyName("char_filter_types")>]
        CharFilterTypes: FieldTypes list
        [<System.Text.Json.Serialization.JsonPropertyName("filter_types")>]
        FilterTypes: FieldTypes list
        [<System.Text.Json.Serialization.JsonPropertyName("tokenizer_types")>]
        TokenizerTypes: FieldTypes list
        [<System.Text.Json.Serialization.JsonPropertyName("synonyms")>]
        Synonyms: Map<CoreTypes.Name, SynonymsStats>
    }

    type ClusterFileSystem = {
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: string option
        [<System.Text.Json.Serialization.JsonPropertyName("mount")>]
        Mount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string option
        [<System.Text.Json.Serialization.JsonPropertyName("available_in_bytes")>]
        AvailableInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("available")>]
        Available: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("free_in_bytes")>]
        FreeInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("free")>]
        Free: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_in_bytes")>]
        TotalInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("low_watermark_free_space")>]
        LowWatermarkFreeSpace: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("low_watermark_free_space_in_bytes")>]
        LowWatermarkFreeSpaceInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("high_watermark_free_space")>]
        HighWatermarkFreeSpace: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("high_watermark_free_space_in_bytes")>]
        HighWatermarkFreeSpaceInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("flood_stage_free_space")>]
        FloodStageFreeSpace: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("flood_stage_free_space_in_bytes")>]
        FloodStageFreeSpaceInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("frozen_flood_stage_free_space")>]
        FrozenFloodStageFreeSpace: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("frozen_flood_stage_free_space_in_bytes")>]
        FrozenFloodStageFreeSpaceInBytes: CoreTypes.Long option
    }

    type ExtendedTextSimilarityRetrieverUsage = {
        [<System.Text.Json.Serialization.JsonPropertyName("chunk_rescorer")>]
        ChunkRescorer: CoreTypes.Long option
    }

    type ExtendedRetrieversSearchUsage = {
        [<System.Text.Json.Serialization.JsonPropertyName("text_similarity_reranker")>]
        TextSimilarityReranker: ExtendedTextSimilarityRetrieverUsage option
    }

    [<RequireQualifiedAccess>]
    type SortType =
        | Doc
        | GeoDistance
        | Score
        | Script
        | FieldSort

    type ExtendedSectionSearchUsage = {
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: Map<SortType, CoreTypes.Long> option
    }

    type ExtendedSearchUsage = {
        [<System.Text.Json.Serialization.JsonPropertyName("retrievers")>]
        Retrievers: ExtendedRetrieversSearchUsage option
        [<System.Text.Json.Serialization.JsonPropertyName("section")>]
        Section: ExtendedSectionSearchUsage option
    }

    type SearchUsageStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("queries")>]
        Queries: Map<CoreTypes.Name, CoreTypes.Long>
        [<System.Text.Json.Serialization.JsonPropertyName("rescorers")>]
        Rescorers: Map<CoreTypes.Name, CoreTypes.Long>
        [<System.Text.Json.Serialization.JsonPropertyName("sections")>]
        Sections: Map<CoreTypes.Name, CoreTypes.Long>
        [<System.Text.Json.Serialization.JsonPropertyName("retrievers")>]
        Retrievers: Map<CoreTypes.Name, CoreTypes.Long>
        [<System.Text.Json.Serialization.JsonPropertyName("extended")>]
        Extended: ExtendedSearchUsage
    }

    type ClusterShardMetrics = {
        [<System.Text.Json.Serialization.JsonPropertyName("avg")>]
        Avg: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("min")>]
        Min: CoreTypes.Double
    }

    type ClusterIndicesShardsIndex = {
        [<System.Text.Json.Serialization.JsonPropertyName("primaries")>]
        Primaries: ClusterShardMetrics
        [<System.Text.Json.Serialization.JsonPropertyName("replication")>]
        Replication: ClusterShardMetrics
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: ClusterShardMetrics
    }

    /// Contains statistics about shards assigned to selected nodes.
    type ClusterIndicesShards = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: ClusterIndicesShardsIndex option
        [<System.Text.Json.Serialization.JsonPropertyName("primaries")>]
        Primaries: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("replication")>]
        Replication: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.Double option
    }

    type RuntimeFieldTypes = {
        [<System.Text.Json.Serialization.JsonPropertyName("chars_max")>]
        CharsMax: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("chars_total")>]
        CharsTotal: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("doc_max")>]
        DocMax: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("doc_total")>]
        DocTotal: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("index_count")>]
        IndexCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("lang")>]
        Lang: string list
        [<System.Text.Json.Serialization.JsonPropertyName("lines_max")>]
        LinesMax: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("lines_total")>]
        LinesTotal: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("scriptless_count")>]
        ScriptlessCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("shadowed_count")>]
        ShadowedCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("source_max")>]
        SourceMax: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("source_total")>]
        SourceTotal: CoreTypes.Integer
    }

    type FieldTypesMappings = {
        [<System.Text.Json.Serialization.JsonPropertyName("field_types")>]
        FieldTypes: FieldTypes list
        [<System.Text.Json.Serialization.JsonPropertyName("runtime_field_types")>]
        RuntimeFieldTypes: RuntimeFieldTypes list
        [<System.Text.Json.Serialization.JsonPropertyName("total_field_count")>]
        TotalFieldCount: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_deduplicated_field_count")>]
        TotalDeduplicatedFieldCount: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_deduplicated_mapping_size")>]
        TotalDeduplicatedMappingSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_deduplicated_mapping_size_in_bytes")>]
        TotalDeduplicatedMappingSizeInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("source_modes")>]
        SourceModes: Map<CoreTypes.Name, CoreTypes.Integer>
    }

    type IndicesVersions = {
        [<System.Text.Json.Serialization.JsonPropertyName("index_count")>]
        IndexCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("primary_shard_count")>]
        PrimaryShardCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("total_primary_bytes")>]
        TotalPrimaryBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_primary_size")>]
        TotalPrimarySize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionString
    }

    type DenseVectorOffHeapStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("total_size_bytes")>]
        TotalSizeBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_size")>]
        TotalSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_veb_size_bytes")>]
        TotalVebSizeBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_veb_size")>]
        TotalVebSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_vec_size_bytes")>]
        TotalVecSizeBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_vec_size")>]
        TotalVecSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_veq_size_bytes")>]
        TotalVeqSizeBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_veq_size")>]
        TotalVeqSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_vex_size_bytes")>]
        TotalVexSizeBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_vex_size")>]
        TotalVexSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_cenif_size_bytes")>]
        TotalCenifSizeBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_cenif_size")>]
        TotalCenifSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_clivf_size_bytes")>]
        TotalClivfSizeBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_clivf_size")>]
        TotalClivfSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("fielddata")>]
        Fielddata: Map<string, Map<string, CoreTypes.Long>> option
    }

    type DenseVectorStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("value_count")>]
        ValueCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("off_heap")>]
        OffHeap: DenseVectorOffHeapStats option
    }

    type SparseVectorStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("value_count")>]
        ValueCount: CoreTypes.Long
    }

    type ClusterIndices = {
        [<System.Text.Json.Serialization.JsonPropertyName("analysis")>]
        Analysis: CharFilterTypes option
        [<System.Text.Json.Serialization.JsonPropertyName("completion")>]
        Completion: CoreTypes.CompletionStats
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("docs")>]
        Docs: CoreTypes.DocStats
        [<System.Text.Json.Serialization.JsonPropertyName("fielddata")>]
        Fielddata: CoreTypes.FielddataStats
        [<System.Text.Json.Serialization.JsonPropertyName("query_cache")>]
        QueryCache: CoreTypes.QueryCacheStats
        [<System.Text.Json.Serialization.JsonPropertyName("search")>]
        Search: SearchUsageStats
        [<System.Text.Json.Serialization.JsonPropertyName("segments")>]
        Segments: CoreTypes.SegmentsStats
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: ClusterIndicesShards
        [<System.Text.Json.Serialization.JsonPropertyName("store")>]
        Store: CoreTypes.StoreStats
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: FieldTypesMappings option
        [<System.Text.Json.Serialization.JsonPropertyName("versions")>]
        Versions: IndicesVersions list option
        [<System.Text.Json.Serialization.JsonPropertyName("dense_vector")>]
        DenseVector: DenseVectorStats
        [<System.Text.Json.Serialization.JsonPropertyName("sparse_vector")>]
        SparseVector: SparseVectorStats
    }

    type ClusterProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("current")>]
        Current: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("failed")>]
        Failed: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("time")>]
        Time: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_millis")>]
        TimeInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
    }

    type ClusterIngest = {
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_pipelines")>]
        NumberOfPipelines: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("processor_stats")>]
        ProcessorStats: Map<string, ClusterProcessor>
    }

    type ClusterJvmMemory = {
        [<System.Text.Json.Serialization.JsonPropertyName("heap_max_in_bytes")>]
        HeapMaxInBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("heap_max")>]
        HeapMax: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("heap_used_in_bytes")>]
        HeapUsedInBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("heap_used")>]
        HeapUsed: CoreTypes.ByteSize option
    }

    type ClusterJvmVersion = {
        [<System.Text.Json.Serialization.JsonPropertyName("bundled_jdk")>]
        BundledJdk: bool
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("using_bundled_jdk")>]
        UsingBundledJdk: bool
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("vm_name")>]
        VmName: string
        [<System.Text.Json.Serialization.JsonPropertyName("vm_vendor")>]
        VmVendor: string
        [<System.Text.Json.Serialization.JsonPropertyName("vm_version")>]
        VmVersion: CoreTypes.VersionString
    }

    type ClusterJvm = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_uptime_in_millis")>]
        MaxUptimeInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("max_uptime")>]
        MaxUptime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("mem")>]
        Mem: ClusterJvmMemory
        [<System.Text.Json.Serialization.JsonPropertyName("threads")>]
        Threads: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("versions")>]
        Versions: ClusterJvmVersion list
    }

    type ClusterNetworkTypes = {
        [<System.Text.Json.Serialization.JsonPropertyName("http_types")>]
        HttpTypes: Map<string, CoreTypes.Integer>
        [<System.Text.Json.Serialization.JsonPropertyName("transport_types")>]
        TransportTypes: Map<string, CoreTypes.Integer>
    }

    type ClusterNodeCount = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("coordinating_only")>]
        CoordinatingOnly: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("data")>]
        Data: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("data_cold")>]
        DataCold: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("data_content")>]
        DataContent: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("data_frozen")>]
        DataFrozen: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("data_hot")>]
        DataHot: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("data_warm")>]
        DataWarm: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("ingest")>]
        Ingest: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("master")>]
        Master: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("ml")>]
        Ml: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("remote_cluster_client")>]
        RemoteClusterClient: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("search")>]
        Search: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("transform")>]
        Transform: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("voting_only")>]
        VotingOnly: CoreTypes.Integer option
    }

    type IndexingPressure = {
        [<System.Text.Json.Serialization.JsonPropertyName("memory")>]
        Memory: NodesTypes.IndexingPressureMemory
    }

    type ClusterOperatingSystemArchitecture = {
        [<System.Text.Json.Serialization.JsonPropertyName("arch")>]
        Arch: string
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Integer
    }

    type OperatingSystemMemoryInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("adjusted_total_in_bytes")>]
        AdjustedTotalInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("adjusted_total")>]
        AdjustedTotal: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("free_in_bytes")>]
        FreeInBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("free")>]
        Free: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("free_percent")>]
        FreePercent: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("total_in_bytes")>]
        TotalInBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("used_in_bytes")>]
        UsedInBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("used")>]
        Used: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("used_percent")>]
        UsedPercent: CoreTypes.Integer
    }

    type ClusterOperatingSystemName = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
    }

    type ClusterOperatingSystemPrettyName = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("pretty_name")>]
        PrettyName: CoreTypes.Name
    }

    type ClusterOperatingSystem = {
        [<System.Text.Json.Serialization.JsonPropertyName("allocated_processors")>]
        AllocatedProcessors: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("architectures")>]
        Architectures: ClusterOperatingSystemArchitecture list option
        [<System.Text.Json.Serialization.JsonPropertyName("available_processors")>]
        AvailableProcessors: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("mem")>]
        Mem: OperatingSystemMemoryInfo
        [<System.Text.Json.Serialization.JsonPropertyName("names")>]
        Names: ClusterOperatingSystemName list
        [<System.Text.Json.Serialization.JsonPropertyName("pretty_names")>]
        PrettyNames: ClusterOperatingSystemPrettyName list
    }

    type NodePackagingType = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("flavor")>]
        Flavor: string
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type ClusterProcessCpu = {
        [<System.Text.Json.Serialization.JsonPropertyName("percent")>]
        Percent: CoreTypes.Integer
    }

    type ClusterProcessOpenFileDescriptors = {
        [<System.Text.Json.Serialization.JsonPropertyName("avg")>]
        Avg: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("min")>]
        Min: CoreTypes.Long
    }

    type ClusterProcess = {
        [<System.Text.Json.Serialization.JsonPropertyName("cpu")>]
        Cpu: ClusterProcessCpu
        [<System.Text.Json.Serialization.JsonPropertyName("open_file_descriptors")>]
        OpenFileDescriptors: ClusterProcessOpenFileDescriptors
    }

    type ClusterNodes = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: ClusterNodeCount
        [<System.Text.Json.Serialization.JsonPropertyName("discovery_types")>]
        DiscoveryTypes: Map<string, CoreTypes.Integer>
        [<System.Text.Json.Serialization.JsonPropertyName("fs")>]
        Fs: ClusterFileSystem
        [<System.Text.Json.Serialization.JsonPropertyName("indexing_pressure")>]
        IndexingPressure: IndexingPressure
        [<System.Text.Json.Serialization.JsonPropertyName("ingest")>]
        Ingest: ClusterIngest
        [<System.Text.Json.Serialization.JsonPropertyName("jvm")>]
        Jvm: ClusterJvm
        [<System.Text.Json.Serialization.JsonPropertyName("network_types")>]
        NetworkTypes: ClusterNetworkTypes
        [<System.Text.Json.Serialization.JsonPropertyName("os")>]
        Os: ClusterOperatingSystem
        [<System.Text.Json.Serialization.JsonPropertyName("packaging_types")>]
        PackagingTypes: NodePackagingType list
        [<System.Text.Json.Serialization.JsonPropertyName("plugins")>]
        Plugins: CoreTypes.PluginStats list
        [<System.Text.Json.Serialization.JsonPropertyName("process")>]
        Process: ClusterProcess
        [<System.Text.Json.Serialization.JsonPropertyName("versions")>]
        Versions: CoreTypes.VersionString list
    }

    type SnapshotCurrentCounts = {
        [<System.Text.Json.Serialization.JsonPropertyName("snapshots")>]
        Snapshots: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("shard_snapshots")>]
        ShardSnapshots: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot_deletions")>]
        SnapshotDeletions: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("concurrent_operations")>]
        ConcurrentOperations: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("cleanups")>]
        Cleanups: CoreTypes.Integer
    }

    [<RequireQualifiedAccess>]
    type ShardState =
        | INIT
        | SUCCESS
        | FAILED
        | ABORTED
        | MISSING
        | WAITING
        | QUEUED
        | PAUSEDFORNODEREMOVAL

    type RepositoryStatsShards = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("complete")>]
        Complete: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("incomplete")>]
        Incomplete: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("states")>]
        States: Map<ShardState, CoreTypes.Integer>
    }

    type RepositoryStatsCurrentCounts = {
        [<System.Text.Json.Serialization.JsonPropertyName("snapshots")>]
        Snapshots: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("clones")>]
        Clones: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("finalizations")>]
        Finalizations: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("deletions")>]
        Deletions: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot_deletions")>]
        SnapshotDeletions: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("active_deletions")>]
        ActiveDeletions: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: RepositoryStatsShards
    }

    type PerRepositoryStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("oldest_start_time_millis")>]
        OldestStartTimeMillis: CoreTypes.UnitMillis
        [<System.Text.Json.Serialization.JsonPropertyName("oldest_start_time")>]
        OldestStartTime: CoreTypes.DateFormat option
        [<System.Text.Json.Serialization.JsonPropertyName("current_counts")>]
        CurrentCounts: RepositoryStatsCurrentCounts
    }

    type ClusterSnapshotStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("current_counts")>]
        CurrentCounts: SnapshotCurrentCounts
        [<System.Text.Json.Serialization.JsonPropertyName("repositories")>]
        Repositories: Map<CoreTypes.Name, PerRepositoryStats>
    }

    type StatsResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_name")>]
        ClusterName: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_uuid")>]
        ClusterUuid: CoreTypes.Uuid
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: ClusterIndices
        [<System.Text.Json.Serialization.JsonPropertyName("nodes")>]
        Nodes: ClusterNodes
        [<System.Text.Json.Serialization.JsonPropertyName("repositories")>]
        Repositories: Map<CoreTypes.Name, Map<CoreTypes.Name, CoreTypes.Long>>
        [<System.Text.Json.Serialization.JsonPropertyName("snapshots")>]
        Snapshots: ClusterSnapshotStats
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: CoreTypes.HealthStatus option
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("ccs")>]
        Ccs: CCSStats
    }


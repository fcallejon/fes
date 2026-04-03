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
        Status: Types.HealthStatus
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString list
        [<System.Text.Json.Serialization.JsonPropertyName("nodes_count")>]
        NodesCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("shards_count")>]
        ShardsCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("indices_count")>]
        IndicesCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("indices_total_size_in_bytes")>]
        IndicesTotalSizeInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("indices_total_size")>]
        IndicesTotalSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_heap_in_bytes")>]
        MaxHeapInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("max_heap")>]
        MaxHeap: string option
        [<System.Text.Json.Serialization.JsonPropertyName("mem_total_in_bytes")>]
        MemTotalInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("mem_total")>]
        MemTotal: string option
    }

    type CCSUsageTimeValue = {
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("avg")>]
        Avg: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("p90")>]
        P90: Types.DurationValue<Types.UnitMillis>
    }

    type CCSUsageClusterStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("skipped")>]
        Skipped: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("took")>]
        Took: ClusterStats.CCSUsageTimeValue
    }

    type CCSUsageStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("success")>]
        Success: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("skipped")>]
        Skipped: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("took")>]
        Took: ClusterStats.CCSUsageTimeValue
        [<System.Text.Json.Serialization.JsonPropertyName("took_mrt_true")>]
        TookMrtTrue: ClusterStats.CCSUsageTimeValue option
        [<System.Text.Json.Serialization.JsonPropertyName("took_mrt_false")>]
        TookMrtFalse: ClusterStats.CCSUsageTimeValue option
        [<System.Text.Json.Serialization.JsonPropertyName("remotes_per_search_max")>]
        RemotesPerSearchMax: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("remotes_per_search_avg")>]
        RemotesPerSearchAvg: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("failure_reasons")>]
        FailureReasons: Map<string, Types.Integer>
        [<System.Text.Json.Serialization.JsonPropertyName("features")>]
        Features: Map<string, Types.Integer>
        [<System.Text.Json.Serialization.JsonPropertyName("clients")>]
        Clients: Map<string, Types.Integer>
        [<System.Text.Json.Serialization.JsonPropertyName("clusters")>]
        Clusters: Map<string, ClusterStats.CCSUsageClusterStats>
    }

    type CCSStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("clusters")>]
        Clusters: Map<string, ClusterStats.RemoteClusterInfo> option
        [<System.Text.Json.Serialization.JsonPropertyName("_search")>]
        Search: ClusterStats.CCSUsageStats
        [<System.Text.Json.Serialization.JsonPropertyName("_esql")>]
        Esql: ClusterStats.CCSUsageStats option
    }

    type FieldTypes = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("index_count")>]
        IndexCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("indexed_vector_count")>]
        IndexedVectorCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("indexed_vector_dim_max")>]
        IndexedVectorDimMax: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("indexed_vector_dim_min")>]
        IndexedVectorDimMin: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("script_count")>]
        ScriptCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("vector_index_type_count")>]
        VectorIndexTypeCount: Map<Types.Name, Types.Integer> option
        [<System.Text.Json.Serialization.JsonPropertyName("vector_similarity_type_count")>]
        VectorSimilarityTypeCount: Map<Types.Name, Types.Integer> option
        [<System.Text.Json.Serialization.JsonPropertyName("vector_element_type_count")>]
        VectorElementTypeCount: Map<Types.Name, Types.Integer> option
    }

    type SynonymsStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("index_count")>]
        IndexCount: Types.Integer
    }

    type CharFilterTypes = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer_types")>]
        AnalyzerTypes: ClusterStats.FieldTypes list
        [<System.Text.Json.Serialization.JsonPropertyName("built_in_analyzers")>]
        BuiltInAnalyzers: ClusterStats.FieldTypes list
        [<System.Text.Json.Serialization.JsonPropertyName("built_in_char_filters")>]
        BuiltInCharFilters: ClusterStats.FieldTypes list
        [<System.Text.Json.Serialization.JsonPropertyName("built_in_filters")>]
        BuiltInFilters: ClusterStats.FieldTypes list
        [<System.Text.Json.Serialization.JsonPropertyName("built_in_tokenizers")>]
        BuiltInTokenizers: ClusterStats.FieldTypes list
        [<System.Text.Json.Serialization.JsonPropertyName("char_filter_types")>]
        CharFilterTypes: ClusterStats.FieldTypes list
        [<System.Text.Json.Serialization.JsonPropertyName("filter_types")>]
        FilterTypes: ClusterStats.FieldTypes list
        [<System.Text.Json.Serialization.JsonPropertyName("tokenizer_types")>]
        TokenizerTypes: ClusterStats.FieldTypes list
        [<System.Text.Json.Serialization.JsonPropertyName("synonyms")>]
        Synonyms: Map<Types.Name, ClusterStats.SynonymsStats>
    }

    type ClusterFileSystem = {
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: string option
        [<System.Text.Json.Serialization.JsonPropertyName("mount")>]
        Mount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string option
        [<System.Text.Json.Serialization.JsonPropertyName("available_in_bytes")>]
        AvailableInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("available")>]
        Available: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("free_in_bytes")>]
        FreeInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("free")>]
        Free: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_in_bytes")>]
        TotalInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("low_watermark_free_space")>]
        LowWatermarkFreeSpace: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("low_watermark_free_space_in_bytes")>]
        LowWatermarkFreeSpaceInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("high_watermark_free_space")>]
        HighWatermarkFreeSpace: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("high_watermark_free_space_in_bytes")>]
        HighWatermarkFreeSpaceInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("flood_stage_free_space")>]
        FloodStageFreeSpace: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("flood_stage_free_space_in_bytes")>]
        FloodStageFreeSpaceInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("frozen_flood_stage_free_space")>]
        FrozenFloodStageFreeSpace: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("frozen_flood_stage_free_space_in_bytes")>]
        FrozenFloodStageFreeSpaceInBytes: Types.Long option
    }

    type ExtendedTextSimilarityRetrieverUsage = {
        [<System.Text.Json.Serialization.JsonPropertyName("chunk_rescorer")>]
        ChunkRescorer: Types.Long option
    }

    type ExtendedRetrieversSearchUsage = {
        [<System.Text.Json.Serialization.JsonPropertyName("text_similarity_reranker")>]
        TextSimilarityReranker: ClusterStats.ExtendedTextSimilarityRetrieverUsage option
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
        Sort: Map<ClusterStats.SortType, Types.Long> option
    }

    type ExtendedSearchUsage = {
        [<System.Text.Json.Serialization.JsonPropertyName("retrievers")>]
        Retrievers: ClusterStats.ExtendedRetrieversSearchUsage option
        [<System.Text.Json.Serialization.JsonPropertyName("section")>]
        Section: ClusterStats.ExtendedSectionSearchUsage option
    }

    type SearchUsageStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("queries")>]
        Queries: Map<Types.Name, Types.Long>
        [<System.Text.Json.Serialization.JsonPropertyName("rescorers")>]
        Rescorers: Map<Types.Name, Types.Long>
        [<System.Text.Json.Serialization.JsonPropertyName("sections")>]
        Sections: Map<Types.Name, Types.Long>
        [<System.Text.Json.Serialization.JsonPropertyName("retrievers")>]
        Retrievers: Map<Types.Name, Types.Long>
        [<System.Text.Json.Serialization.JsonPropertyName("extended")>]
        Extended: ClusterStats.ExtendedSearchUsage
    }

    type ClusterShardMetrics = {
        [<System.Text.Json.Serialization.JsonPropertyName("avg")>]
        Avg: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("min")>]
        Min: Types.Double
    }

    type ClusterIndicesShardsIndex = {
        [<System.Text.Json.Serialization.JsonPropertyName("primaries")>]
        Primaries: ClusterStats.ClusterShardMetrics
        [<System.Text.Json.Serialization.JsonPropertyName("replication")>]
        Replication: ClusterStats.ClusterShardMetrics
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: ClusterStats.ClusterShardMetrics
    }

    /// Contains statistics about shards assigned to selected nodes.
    type ClusterIndicesShards = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: ClusterStats.ClusterIndicesShardsIndex option
        [<System.Text.Json.Serialization.JsonPropertyName("primaries")>]
        Primaries: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("replication")>]
        Replication: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Double option
    }

    type RuntimeFieldTypes = {
        [<System.Text.Json.Serialization.JsonPropertyName("chars_max")>]
        CharsMax: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("chars_total")>]
        CharsTotal: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("doc_max")>]
        DocMax: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("doc_total")>]
        DocTotal: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("index_count")>]
        IndexCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("lang")>]
        Lang: string list
        [<System.Text.Json.Serialization.JsonPropertyName("lines_max")>]
        LinesMax: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("lines_total")>]
        LinesTotal: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("scriptless_count")>]
        ScriptlessCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("shadowed_count")>]
        ShadowedCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("source_max")>]
        SourceMax: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("source_total")>]
        SourceTotal: Types.Integer
    }

    type FieldTypesMappings = {
        [<System.Text.Json.Serialization.JsonPropertyName("field_types")>]
        FieldTypes: ClusterStats.FieldTypes list
        [<System.Text.Json.Serialization.JsonPropertyName("runtime_field_types")>]
        RuntimeFieldTypes: ClusterStats.RuntimeFieldTypes list
        [<System.Text.Json.Serialization.JsonPropertyName("total_field_count")>]
        TotalFieldCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_deduplicated_field_count")>]
        TotalDeduplicatedFieldCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_deduplicated_mapping_size")>]
        TotalDeduplicatedMappingSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_deduplicated_mapping_size_in_bytes")>]
        TotalDeduplicatedMappingSizeInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("source_modes")>]
        SourceModes: Map<Types.Name, Types.Integer>
    }

    type IndicesVersions = {
        [<System.Text.Json.Serialization.JsonPropertyName("index_count")>]
        IndexCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("primary_shard_count")>]
        PrimaryShardCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("total_primary_bytes")>]
        TotalPrimaryBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_primary_size")>]
        TotalPrimarySize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString
    }

    type DenseVectorOffHeapStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("total_size_bytes")>]
        TotalSizeBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_size")>]
        TotalSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_veb_size_bytes")>]
        TotalVebSizeBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_veb_size")>]
        TotalVebSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_vec_size_bytes")>]
        TotalVecSizeBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_vec_size")>]
        TotalVecSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_veq_size_bytes")>]
        TotalVeqSizeBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_veq_size")>]
        TotalVeqSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_vex_size_bytes")>]
        TotalVexSizeBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_vex_size")>]
        TotalVexSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_cenif_size_bytes")>]
        TotalCenifSizeBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_cenif_size")>]
        TotalCenifSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_clivf_size_bytes")>]
        TotalClivfSizeBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_clivf_size")>]
        TotalClivfSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("fielddata")>]
        Fielddata: Map<string, Map<string, Types.Long>> option
    }

    type DenseVectorStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("value_count")>]
        ValueCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("off_heap")>]
        OffHeap: ClusterStats.DenseVectorOffHeapStats option
    }

    type SparseVectorStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("value_count")>]
        ValueCount: Types.Long
    }

    type ClusterIndices = {
        [<System.Text.Json.Serialization.JsonPropertyName("analysis")>]
        Analysis: ClusterStats.CharFilterTypes option
        [<System.Text.Json.Serialization.JsonPropertyName("completion")>]
        Completion: Types.CompletionStats
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("docs")>]
        Docs: Types.DocStats
        [<System.Text.Json.Serialization.JsonPropertyName("fielddata")>]
        Fielddata: Types.FielddataStats
        [<System.Text.Json.Serialization.JsonPropertyName("query_cache")>]
        QueryCache: Types.QueryCacheStats
        [<System.Text.Json.Serialization.JsonPropertyName("search")>]
        Search: ClusterStats.SearchUsageStats
        [<System.Text.Json.Serialization.JsonPropertyName("segments")>]
        Segments: Types.SegmentsStats
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: ClusterStats.ClusterIndicesShards
        [<System.Text.Json.Serialization.JsonPropertyName("store")>]
        Store: Types.StoreStats
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: ClusterStats.FieldTypesMappings option
        [<System.Text.Json.Serialization.JsonPropertyName("versions")>]
        Versions: ClusterStats.IndicesVersions list option
        [<System.Text.Json.Serialization.JsonPropertyName("dense_vector")>]
        DenseVector: ClusterStats.DenseVectorStats
        [<System.Text.Json.Serialization.JsonPropertyName("sparse_vector")>]
        SparseVector: ClusterStats.SparseVectorStats
    }

    type ClusterProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("current")>]
        Current: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("failed")>]
        Failed: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("time")>]
        Time: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_millis")>]
        TimeInMillis: Types.DurationValue<Types.UnitMillis>
    }

    type ClusterIngest = {
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_pipelines")>]
        NumberOfPipelines: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("processor_stats")>]
        ProcessorStats: Map<string, ClusterStats.ClusterProcessor>
    }

    type ClusterJvmMemory = {
        [<System.Text.Json.Serialization.JsonPropertyName("heap_max_in_bytes")>]
        HeapMaxInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("heap_max")>]
        HeapMax: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("heap_used_in_bytes")>]
        HeapUsedInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("heap_used")>]
        HeapUsed: Types.ByteSize option
    }

    type ClusterJvmVersion = {
        [<System.Text.Json.Serialization.JsonPropertyName("bundled_jdk")>]
        BundledJdk: bool
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("using_bundled_jdk")>]
        UsingBundledJdk: bool
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("vm_name")>]
        VmName: string
        [<System.Text.Json.Serialization.JsonPropertyName("vm_vendor")>]
        VmVendor: string
        [<System.Text.Json.Serialization.JsonPropertyName("vm_version")>]
        VmVersion: Types.VersionString
    }

    type ClusterJvm = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_uptime_in_millis")>]
        MaxUptimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("max_uptime")>]
        MaxUptime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("mem")>]
        Mem: ClusterStats.ClusterJvmMemory
        [<System.Text.Json.Serialization.JsonPropertyName("threads")>]
        Threads: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("versions")>]
        Versions: ClusterStats.ClusterJvmVersion list
    }

    type ClusterNetworkTypes = {
        [<System.Text.Json.Serialization.JsonPropertyName("http_types")>]
        HttpTypes: Map<string, Types.Integer>
        [<System.Text.Json.Serialization.JsonPropertyName("transport_types")>]
        TransportTypes: Map<string, Types.Integer>
    }

    type ClusterNodeCount = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("coordinating_only")>]
        CoordinatingOnly: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("data")>]
        Data: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("data_cold")>]
        DataCold: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("data_content")>]
        DataContent: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("data_frozen")>]
        DataFrozen: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("data_hot")>]
        DataHot: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("data_warm")>]
        DataWarm: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("ingest")>]
        Ingest: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("master")>]
        Master: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("ml")>]
        Ml: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("remote_cluster_client")>]
        RemoteClusterClient: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("search")>]
        Search: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("transform")>]
        Transform: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("voting_only")>]
        VotingOnly: Types.Integer option
    }

    type IndexingPressure = {
        [<System.Text.Json.Serialization.JsonPropertyName("memory")>]
        Memory: NodesTypes.IndexingPressureMemory
    }

    type ClusterOperatingSystemArchitecture = {
        [<System.Text.Json.Serialization.JsonPropertyName("arch")>]
        Arch: string
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Integer
    }

    type OperatingSystemMemoryInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("adjusted_total_in_bytes")>]
        AdjustedTotalInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("adjusted_total")>]
        AdjustedTotal: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("free_in_bytes")>]
        FreeInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("free")>]
        Free: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("free_percent")>]
        FreePercent: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("total_in_bytes")>]
        TotalInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("used_in_bytes")>]
        UsedInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("used")>]
        Used: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("used_percent")>]
        UsedPercent: Types.Integer
    }

    type ClusterOperatingSystemName = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
    }

    type ClusterOperatingSystemPrettyName = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("pretty_name")>]
        PrettyName: Types.Name
    }

    type ClusterOperatingSystem = {
        [<System.Text.Json.Serialization.JsonPropertyName("allocated_processors")>]
        AllocatedProcessors: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("architectures")>]
        Architectures: ClusterStats.ClusterOperatingSystemArchitecture list option
        [<System.Text.Json.Serialization.JsonPropertyName("available_processors")>]
        AvailableProcessors: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("mem")>]
        Mem: ClusterStats.OperatingSystemMemoryInfo
        [<System.Text.Json.Serialization.JsonPropertyName("names")>]
        Names: ClusterStats.ClusterOperatingSystemName list
        [<System.Text.Json.Serialization.JsonPropertyName("pretty_names")>]
        PrettyNames: ClusterStats.ClusterOperatingSystemPrettyName list
    }

    type NodePackagingType = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("flavor")>]
        Flavor: string
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type ClusterProcessCpu = {
        [<System.Text.Json.Serialization.JsonPropertyName("percent")>]
        Percent: Types.Integer
    }

    type ClusterProcessOpenFileDescriptors = {
        [<System.Text.Json.Serialization.JsonPropertyName("avg")>]
        Avg: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("min")>]
        Min: Types.Long
    }

    type ClusterProcess = {
        [<System.Text.Json.Serialization.JsonPropertyName("cpu")>]
        Cpu: ClusterStats.ClusterProcessCpu
        [<System.Text.Json.Serialization.JsonPropertyName("open_file_descriptors")>]
        OpenFileDescriptors: ClusterStats.ClusterProcessOpenFileDescriptors
    }

    type ClusterNodes = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: ClusterStats.ClusterNodeCount
        [<System.Text.Json.Serialization.JsonPropertyName("discovery_types")>]
        DiscoveryTypes: Map<string, Types.Integer>
        [<System.Text.Json.Serialization.JsonPropertyName("fs")>]
        Fs: ClusterStats.ClusterFileSystem
        [<System.Text.Json.Serialization.JsonPropertyName("indexing_pressure")>]
        IndexingPressure: ClusterStats.IndexingPressure
        [<System.Text.Json.Serialization.JsonPropertyName("ingest")>]
        Ingest: ClusterStats.ClusterIngest
        [<System.Text.Json.Serialization.JsonPropertyName("jvm")>]
        Jvm: ClusterStats.ClusterJvm
        [<System.Text.Json.Serialization.JsonPropertyName("network_types")>]
        NetworkTypes: ClusterStats.ClusterNetworkTypes
        [<System.Text.Json.Serialization.JsonPropertyName("os")>]
        Os: ClusterStats.ClusterOperatingSystem
        [<System.Text.Json.Serialization.JsonPropertyName("packaging_types")>]
        PackagingTypes: ClusterStats.NodePackagingType list
        [<System.Text.Json.Serialization.JsonPropertyName("plugins")>]
        Plugins: Types.PluginStats list
        [<System.Text.Json.Serialization.JsonPropertyName("process")>]
        Process: ClusterStats.ClusterProcess
        [<System.Text.Json.Serialization.JsonPropertyName("versions")>]
        Versions: Types.VersionString list
    }

    type SnapshotCurrentCounts = {
        [<System.Text.Json.Serialization.JsonPropertyName("snapshots")>]
        Snapshots: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("shard_snapshots")>]
        ShardSnapshots: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot_deletions")>]
        SnapshotDeletions: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("concurrent_operations")>]
        ConcurrentOperations: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("cleanups")>]
        Cleanups: Types.Integer
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
        Total: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("complete")>]
        Complete: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("incomplete")>]
        Incomplete: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("states")>]
        States: Map<ClusterStats.ShardState, Types.Integer>
    }

    type RepositoryStatsCurrentCounts = {
        [<System.Text.Json.Serialization.JsonPropertyName("snapshots")>]
        Snapshots: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("clones")>]
        Clones: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("finalizations")>]
        Finalizations: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("deletions")>]
        Deletions: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot_deletions")>]
        SnapshotDeletions: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("active_deletions")>]
        ActiveDeletions: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: ClusterStats.RepositoryStatsShards
    }

    type PerRepositoryStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("oldest_start_time_millis")>]
        OldestStartTimeMillis: Types.UnitMillis
        [<System.Text.Json.Serialization.JsonPropertyName("oldest_start_time")>]
        OldestStartTime: Types.DateFormat option
        [<System.Text.Json.Serialization.JsonPropertyName("current_counts")>]
        CurrentCounts: ClusterStats.RepositoryStatsCurrentCounts
    }

    type ClusterSnapshotStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("current_counts")>]
        CurrentCounts: ClusterStats.SnapshotCurrentCounts
        [<System.Text.Json.Serialization.JsonPropertyName("repositories")>]
        Repositories: Map<Types.Name, ClusterStats.PerRepositoryStats>
    }

    type StatsResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_name")>]
        ClusterName: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_uuid")>]
        ClusterUuid: Types.Uuid
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: ClusterStats.ClusterIndices
        [<System.Text.Json.Serialization.JsonPropertyName("nodes")>]
        Nodes: ClusterStats.ClusterNodes
        [<System.Text.Json.Serialization.JsonPropertyName("repositories")>]
        Repositories: Map<Types.Name, Map<Types.Name, Types.Long>>
        [<System.Text.Json.Serialization.JsonPropertyName("snapshots")>]
        Snapshots: ClusterStats.ClusterSnapshotStats
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: Types.HealthStatus option
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("ccs")>]
        Ccs: ClusterStats.CCSStats
    }


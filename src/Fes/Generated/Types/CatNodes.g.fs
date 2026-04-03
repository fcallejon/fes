// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatNodes =

    type NodesRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("pid")>]
        Pid: string option
        [<System.Text.Json.Serialization.JsonPropertyName("ip")>]
        Ip: string option
        [<System.Text.Json.Serialization.JsonPropertyName("port")>]
        Port: string option
        [<System.Text.Json.Serialization.JsonPropertyName("http_address")>]
        HttpAddress: string option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("flavor")>]
        Flavor: string option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string option
        [<System.Text.Json.Serialization.JsonPropertyName("build")>]
        Build: string option
        [<System.Text.Json.Serialization.JsonPropertyName("jdk")>]
        Jdk: string option
        [<System.Text.Json.Serialization.JsonPropertyName("disk.total")>]
        DiskTotal: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("disk.used")>]
        DiskUsed: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("disk.avail")>]
        DiskAvail: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("disk.used_percent")>]
        DiskUsedPercent: CoreTypes.Percentage option
        [<System.Text.Json.Serialization.JsonPropertyName("heap.current")>]
        HeapCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("heap.percent")>]
        HeapPercent: CoreTypes.Percentage option
        [<System.Text.Json.Serialization.JsonPropertyName("heap.max")>]
        HeapMax: string option
        [<System.Text.Json.Serialization.JsonPropertyName("ram.current")>]
        RamCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("ram.percent")>]
        RamPercent: CoreTypes.Percentage option
        [<System.Text.Json.Serialization.JsonPropertyName("ram.max")>]
        RamMax: string option
        [<System.Text.Json.Serialization.JsonPropertyName("file_desc.current")>]
        FileDescCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("file_desc.percent")>]
        FileDescPercent: CoreTypes.Percentage option
        [<System.Text.Json.Serialization.JsonPropertyName("file_desc.max")>]
        FileDescMax: string option
        [<System.Text.Json.Serialization.JsonPropertyName("cpu")>]
        Cpu: string option
        [<System.Text.Json.Serialization.JsonPropertyName("load_1m")>]
        Load1m: string option
        [<System.Text.Json.Serialization.JsonPropertyName("load_5m")>]
        Load5m: string option
        [<System.Text.Json.Serialization.JsonPropertyName("load_15m")>]
        Load15m: string option
        [<System.Text.Json.Serialization.JsonPropertyName("available_processors")>]
        AvailableProcessors: string option
        [<System.Text.Json.Serialization.JsonPropertyName("uptime")>]
        Uptime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("node.role")>]
        NodeRole: string option
        [<System.Text.Json.Serialization.JsonPropertyName("master")>]
        Master: string option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("completion.size")>]
        CompletionSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("fielddata.memory_size")>]
        FielddataMemorySize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("fielddata.evictions")>]
        FielddataEvictions: string option
        [<System.Text.Json.Serialization.JsonPropertyName("query_cache.memory_size")>]
        QueryCacheMemorySize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("query_cache.evictions")>]
        QueryCacheEvictions: string option
        [<System.Text.Json.Serialization.JsonPropertyName("query_cache.hit_count")>]
        QueryCacheHitCount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("query_cache.miss_count")>]
        QueryCacheMissCount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("request_cache.memory_size")>]
        RequestCacheMemorySize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("request_cache.evictions")>]
        RequestCacheEvictions: string option
        [<System.Text.Json.Serialization.JsonPropertyName("request_cache.hit_count")>]
        RequestCacheHitCount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("request_cache.miss_count")>]
        RequestCacheMissCount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("flush.total")>]
        FlushTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("flush.total_time")>]
        FlushTotalTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("get.current")>]
        GetCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("get.time")>]
        GetTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("get.total")>]
        GetTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("get.exists_time")>]
        GetExistsTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("get.exists_total")>]
        GetExistsTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("get.missing_time")>]
        GetMissingTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("get.missing_total")>]
        GetMissingTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing.delete_current")>]
        IndexingDeleteCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing.delete_time")>]
        IndexingDeleteTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing.delete_total")>]
        IndexingDeleteTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing.index_current")>]
        IndexingIndexCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing.index_time")>]
        IndexingIndexTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing.index_total")>]
        IndexingIndexTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing.index_failed")>]
        IndexingIndexFailed: string option
        [<System.Text.Json.Serialization.JsonPropertyName("merges.current")>]
        MergesCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("merges.current_docs")>]
        MergesCurrentDocs: string option
        [<System.Text.Json.Serialization.JsonPropertyName("merges.current_size")>]
        MergesCurrentSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("merges.total")>]
        MergesTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("merges.total_docs")>]
        MergesTotalDocs: string option
        [<System.Text.Json.Serialization.JsonPropertyName("merges.total_size")>]
        MergesTotalSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("merges.total_time")>]
        MergesTotalTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("refresh.total")>]
        RefreshTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("refresh.time")>]
        RefreshTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("refresh.external_total")>]
        RefreshExternalTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("refresh.external_time")>]
        RefreshExternalTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("refresh.listeners")>]
        RefreshListeners: string option
        [<System.Text.Json.Serialization.JsonPropertyName("script.compilations")>]
        ScriptCompilations: string option
        [<System.Text.Json.Serialization.JsonPropertyName("script.cache_evictions")>]
        ScriptCacheEvictions: string option
        [<System.Text.Json.Serialization.JsonPropertyName("script.compilation_limit_triggered")>]
        ScriptCompilationLimitTriggered: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.fetch_current")>]
        SearchFetchCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.fetch_time")>]
        SearchFetchTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.fetch_total")>]
        SearchFetchTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.open_contexts")>]
        SearchOpenContexts: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.query_current")>]
        SearchQueryCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.query_time")>]
        SearchQueryTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.query_total")>]
        SearchQueryTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.scroll_current")>]
        SearchScrollCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.scroll_time")>]
        SearchScrollTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.scroll_total")>]
        SearchScrollTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("segments.count")>]
        SegmentsCount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("segments.memory")>]
        SegmentsMemory: string option
        [<System.Text.Json.Serialization.JsonPropertyName("segments.index_writer_memory")>]
        SegmentsIndexWriterMemory: string option
        [<System.Text.Json.Serialization.JsonPropertyName("segments.version_map_memory")>]
        SegmentsVersionMapMemory: string option
        [<System.Text.Json.Serialization.JsonPropertyName("segments.fixed_bitset_memory")>]
        SegmentsFixedBitsetMemory: string option
        [<System.Text.Json.Serialization.JsonPropertyName("suggest.current")>]
        SuggestCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("suggest.time")>]
        SuggestTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("suggest.total")>]
        SuggestTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("bulk.total_operations")>]
        BulkTotalOperations: string option
        [<System.Text.Json.Serialization.JsonPropertyName("bulk.total_time")>]
        BulkTotalTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("bulk.total_size_in_bytes")>]
        BulkTotalSizeInBytes: string option
        [<System.Text.Json.Serialization.JsonPropertyName("bulk.avg_time")>]
        BulkAvgTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("bulk.avg_size_in_bytes")>]
        BulkAvgSizeInBytes: string option
    }


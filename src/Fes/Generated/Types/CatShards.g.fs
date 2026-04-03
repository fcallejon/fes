// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatShards =

    type ShardsRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: string option
        [<System.Text.Json.Serialization.JsonPropertyName("shard")>]
        Shard: string option
        [<System.Text.Json.Serialization.JsonPropertyName("prirep")>]
        Prirep: string option
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: string option
        [<System.Text.Json.Serialization.JsonPropertyName("docs")>]
        Docs: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("store")>]
        Store: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("dataset")>]
        Dataset: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("ip")>]
        Ip: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: string option
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("sync_id")>]
        SyncId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("unassigned.reason")>]
        UnassignedReason: string option
        [<System.Text.Json.Serialization.JsonPropertyName("unassigned.at")>]
        UnassignedAt: string option
        [<System.Text.Json.Serialization.JsonPropertyName("unassigned.for")>]
        UnassignedFor: string option
        [<System.Text.Json.Serialization.JsonPropertyName("unassigned.details")>]
        UnassignedDetails: string option
        [<System.Text.Json.Serialization.JsonPropertyName("recoverysource.type")>]
        RecoverysourceType: string option
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
        [<System.Text.Json.Serialization.JsonPropertyName("seq_no.max")>]
        SeqNoMax: string option
        [<System.Text.Json.Serialization.JsonPropertyName("seq_no.local_checkpoint")>]
        SeqNoLocalCheckpoint: string option
        [<System.Text.Json.Serialization.JsonPropertyName("seq_no.global_checkpoint")>]
        SeqNoGlobalCheckpoint: string option
        [<System.Text.Json.Serialization.JsonPropertyName("warmer.current")>]
        WarmerCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("warmer.total")>]
        WarmerTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("warmer.total_time")>]
        WarmerTotalTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("path.data")>]
        PathData: string option
        [<System.Text.Json.Serialization.JsonPropertyName("path.state")>]
        PathState: string option
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


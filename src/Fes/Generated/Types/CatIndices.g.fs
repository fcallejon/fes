// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatIndices =

    type IndicesRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("health")>]
        Health: string option
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: string option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: string option
        [<System.Text.Json.Serialization.JsonPropertyName("uuid")>]
        Uuid: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri")>]
        Pri: string option
        [<System.Text.Json.Serialization.JsonPropertyName("rep")>]
        Rep: string option
        [<System.Text.Json.Serialization.JsonPropertyName("docs.count")>]
        DocsCount: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("docs.deleted")>]
        DocsDeleted: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("creation.date")>]
        CreationDate: string option
        [<System.Text.Json.Serialization.JsonPropertyName("creation.date.string")>]
        CreationDateString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("store.size")>]
        StoreSize: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.store.size")>]
        PriStoreSize: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("dataset.size")>]
        DatasetSize: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("completion.size")>]
        CompletionSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.completion.size")>]
        PriCompletionSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("fielddata.memory_size")>]
        FielddataMemorySize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.fielddata.memory_size")>]
        PriFielddataMemorySize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("fielddata.evictions")>]
        FielddataEvictions: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.fielddata.evictions")>]
        PriFielddataEvictions: string option
        [<System.Text.Json.Serialization.JsonPropertyName("query_cache.memory_size")>]
        QueryCacheMemorySize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.query_cache.memory_size")>]
        PriQueryCacheMemorySize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("query_cache.evictions")>]
        QueryCacheEvictions: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.query_cache.evictions")>]
        PriQueryCacheEvictions: string option
        [<System.Text.Json.Serialization.JsonPropertyName("request_cache.memory_size")>]
        RequestCacheMemorySize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.request_cache.memory_size")>]
        PriRequestCacheMemorySize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("request_cache.evictions")>]
        RequestCacheEvictions: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.request_cache.evictions")>]
        PriRequestCacheEvictions: string option
        [<System.Text.Json.Serialization.JsonPropertyName("request_cache.hit_count")>]
        RequestCacheHitCount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.request_cache.hit_count")>]
        PriRequestCacheHitCount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("request_cache.miss_count")>]
        RequestCacheMissCount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.request_cache.miss_count")>]
        PriRequestCacheMissCount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("flush.total")>]
        FlushTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.flush.total")>]
        PriFlushTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("flush.total_time")>]
        FlushTotalTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.flush.total_time")>]
        PriFlushTotalTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("get.current")>]
        GetCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.get.current")>]
        PriGetCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("get.time")>]
        GetTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.get.time")>]
        PriGetTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("get.total")>]
        GetTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.get.total")>]
        PriGetTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("get.exists_time")>]
        GetExistsTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.get.exists_time")>]
        PriGetExistsTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("get.exists_total")>]
        GetExistsTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.get.exists_total")>]
        PriGetExistsTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("get.missing_time")>]
        GetMissingTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.get.missing_time")>]
        PriGetMissingTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("get.missing_total")>]
        GetMissingTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.get.missing_total")>]
        PriGetMissingTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing.delete_current")>]
        IndexingDeleteCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.indexing.delete_current")>]
        PriIndexingDeleteCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing.delete_time")>]
        IndexingDeleteTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.indexing.delete_time")>]
        PriIndexingDeleteTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing.delete_total")>]
        IndexingDeleteTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.indexing.delete_total")>]
        PriIndexingDeleteTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing.index_current")>]
        IndexingIndexCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.indexing.index_current")>]
        PriIndexingIndexCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing.index_time")>]
        IndexingIndexTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.indexing.index_time")>]
        PriIndexingIndexTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing.index_total")>]
        IndexingIndexTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.indexing.index_total")>]
        PriIndexingIndexTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing.index_failed")>]
        IndexingIndexFailed: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.indexing.index_failed")>]
        PriIndexingIndexFailed: string option
        [<System.Text.Json.Serialization.JsonPropertyName("merges.current")>]
        MergesCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.merges.current")>]
        PriMergesCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("merges.current_docs")>]
        MergesCurrentDocs: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.merges.current_docs")>]
        PriMergesCurrentDocs: string option
        [<System.Text.Json.Serialization.JsonPropertyName("merges.current_size")>]
        MergesCurrentSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.merges.current_size")>]
        PriMergesCurrentSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("merges.total")>]
        MergesTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.merges.total")>]
        PriMergesTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("merges.total_docs")>]
        MergesTotalDocs: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.merges.total_docs")>]
        PriMergesTotalDocs: string option
        [<System.Text.Json.Serialization.JsonPropertyName("merges.total_size")>]
        MergesTotalSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.merges.total_size")>]
        PriMergesTotalSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("merges.total_time")>]
        MergesTotalTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.merges.total_time")>]
        PriMergesTotalTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("refresh.total")>]
        RefreshTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.refresh.total")>]
        PriRefreshTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("refresh.time")>]
        RefreshTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.refresh.time")>]
        PriRefreshTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("refresh.external_total")>]
        RefreshExternalTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.refresh.external_total")>]
        PriRefreshExternalTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("refresh.external_time")>]
        RefreshExternalTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.refresh.external_time")>]
        PriRefreshExternalTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("refresh.listeners")>]
        RefreshListeners: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.refresh.listeners")>]
        PriRefreshListeners: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.fetch_current")>]
        SearchFetchCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.search.fetch_current")>]
        PriSearchFetchCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.fetch_time")>]
        SearchFetchTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.search.fetch_time")>]
        PriSearchFetchTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.fetch_total")>]
        SearchFetchTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.search.fetch_total")>]
        PriSearchFetchTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.open_contexts")>]
        SearchOpenContexts: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.search.open_contexts")>]
        PriSearchOpenContexts: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.query_current")>]
        SearchQueryCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.search.query_current")>]
        PriSearchQueryCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.query_time")>]
        SearchQueryTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.search.query_time")>]
        PriSearchQueryTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.query_total")>]
        SearchQueryTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.search.query_total")>]
        PriSearchQueryTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.scroll_current")>]
        SearchScrollCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.search.scroll_current")>]
        PriSearchScrollCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.scroll_time")>]
        SearchScrollTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.search.scroll_time")>]
        PriSearchScrollTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.scroll_total")>]
        SearchScrollTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.search.scroll_total")>]
        PriSearchScrollTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("segments.count")>]
        SegmentsCount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.segments.count")>]
        PriSegmentsCount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("segments.memory")>]
        SegmentsMemory: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.segments.memory")>]
        PriSegmentsMemory: string option
        [<System.Text.Json.Serialization.JsonPropertyName("segments.index_writer_memory")>]
        SegmentsIndexWriterMemory: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.segments.index_writer_memory")>]
        PriSegmentsIndexWriterMemory: string option
        [<System.Text.Json.Serialization.JsonPropertyName("segments.version_map_memory")>]
        SegmentsVersionMapMemory: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.segments.version_map_memory")>]
        PriSegmentsVersionMapMemory: string option
        [<System.Text.Json.Serialization.JsonPropertyName("segments.fixed_bitset_memory")>]
        SegmentsFixedBitsetMemory: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.segments.fixed_bitset_memory")>]
        PriSegmentsFixedBitsetMemory: string option
        [<System.Text.Json.Serialization.JsonPropertyName("warmer.current")>]
        WarmerCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.warmer.current")>]
        PriWarmerCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("warmer.total")>]
        WarmerTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.warmer.total")>]
        PriWarmerTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("warmer.total_time")>]
        WarmerTotalTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.warmer.total_time")>]
        PriWarmerTotalTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("suggest.current")>]
        SuggestCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.suggest.current")>]
        PriSuggestCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("suggest.time")>]
        SuggestTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.suggest.time")>]
        PriSuggestTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("suggest.total")>]
        SuggestTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.suggest.total")>]
        PriSuggestTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("memory.total")>]
        MemoryTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.memory.total")>]
        PriMemoryTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.throttled")>]
        SearchThrottled: string option
        [<System.Text.Json.Serialization.JsonPropertyName("bulk.total_operations")>]
        BulkTotalOperations: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.bulk.total_operations")>]
        PriBulkTotalOperations: string option
        [<System.Text.Json.Serialization.JsonPropertyName("bulk.total_time")>]
        BulkTotalTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.bulk.total_time")>]
        PriBulkTotalTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("bulk.total_size_in_bytes")>]
        BulkTotalSizeInBytes: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.bulk.total_size_in_bytes")>]
        PriBulkTotalSizeInBytes: string option
        [<System.Text.Json.Serialization.JsonPropertyName("bulk.avg_time")>]
        BulkAvgTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.bulk.avg_time")>]
        PriBulkAvgTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("bulk.avg_size_in_bytes")>]
        BulkAvgSizeInBytes: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri.bulk.avg_size_in_bytes")>]
        PriBulkAvgSizeInBytes: string option
    }


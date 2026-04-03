// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module CatIndicesBuilders =

    type IndicesRecordBuilder() =
        member _.Yield(_: unit) : IndicesRecord =
            {
                Health = None
                Status = None
                Index = None
                Uuid = None
                Pri = None
                Rep = None
                DocsCount = None
                DocsDeleted = None
                CreationDate = None
                CreationDateString = None
                StoreSize = None
                PriStoreSize = None
                DatasetSize = None
                CompletionSize = None
                PriCompletionSize = None
                FielddataMemorySize = None
                PriFielddataMemorySize = None
                FielddataEvictions = None
                PriFielddataEvictions = None
                QueryCacheMemorySize = None
                PriQueryCacheMemorySize = None
                QueryCacheEvictions = None
                PriQueryCacheEvictions = None
                RequestCacheMemorySize = None
                PriRequestCacheMemorySize = None
                RequestCacheEvictions = None
                PriRequestCacheEvictions = None
                RequestCacheHitCount = None
                PriRequestCacheHitCount = None
                RequestCacheMissCount = None
                PriRequestCacheMissCount = None
                FlushTotal = None
                PriFlushTotal = None
                FlushTotalTime = None
                PriFlushTotalTime = None
                GetCurrent = None
                PriGetCurrent = None
                GetTime = None
                PriGetTime = None
                GetTotal = None
                PriGetTotal = None
                GetExistsTime = None
                PriGetExistsTime = None
                GetExistsTotal = None
                PriGetExistsTotal = None
                GetMissingTime = None
                PriGetMissingTime = None
                GetMissingTotal = None
                PriGetMissingTotal = None
                IndexingDeleteCurrent = None
                PriIndexingDeleteCurrent = None
                IndexingDeleteTime = None
                PriIndexingDeleteTime = None
                IndexingDeleteTotal = None
                PriIndexingDeleteTotal = None
                IndexingIndexCurrent = None
                PriIndexingIndexCurrent = None
                IndexingIndexTime = None
                PriIndexingIndexTime = None
                IndexingIndexTotal = None
                PriIndexingIndexTotal = None
                IndexingIndexFailed = None
                PriIndexingIndexFailed = None
                MergesCurrent = None
                PriMergesCurrent = None
                MergesCurrentDocs = None
                PriMergesCurrentDocs = None
                MergesCurrentSize = None
                PriMergesCurrentSize = None
                MergesTotal = None
                PriMergesTotal = None
                MergesTotalDocs = None
                PriMergesTotalDocs = None
                MergesTotalSize = None
                PriMergesTotalSize = None
                MergesTotalTime = None
                PriMergesTotalTime = None
                RefreshTotal = None
                PriRefreshTotal = None
                RefreshTime = None
                PriRefreshTime = None
                RefreshExternalTotal = None
                PriRefreshExternalTotal = None
                RefreshExternalTime = None
                PriRefreshExternalTime = None
                RefreshListeners = None
                PriRefreshListeners = None
                SearchFetchCurrent = None
                PriSearchFetchCurrent = None
                SearchFetchTime = None
                PriSearchFetchTime = None
                SearchFetchTotal = None
                PriSearchFetchTotal = None
                SearchOpenContexts = None
                PriSearchOpenContexts = None
                SearchQueryCurrent = None
                PriSearchQueryCurrent = None
                SearchQueryTime = None
                PriSearchQueryTime = None
                SearchQueryTotal = None
                PriSearchQueryTotal = None
                SearchScrollCurrent = None
                PriSearchScrollCurrent = None
                SearchScrollTime = None
                PriSearchScrollTime = None
                SearchScrollTotal = None
                PriSearchScrollTotal = None
                SegmentsCount = None
                PriSegmentsCount = None
                SegmentsMemory = None
                PriSegmentsMemory = None
                SegmentsIndexWriterMemory = None
                PriSegmentsIndexWriterMemory = None
                SegmentsVersionMapMemory = None
                PriSegmentsVersionMapMemory = None
                SegmentsFixedBitsetMemory = None
                PriSegmentsFixedBitsetMemory = None
                WarmerCurrent = None
                PriWarmerCurrent = None
                WarmerTotal = None
                PriWarmerTotal = None
                WarmerTotalTime = None
                PriWarmerTotalTime = None
                SuggestCurrent = None
                PriSuggestCurrent = None
                SuggestTime = None
                PriSuggestTime = None
                SuggestTotal = None
                PriSuggestTotal = None
                MemoryTotal = None
                PriMemoryTotal = None
                SearchThrottled = None
                BulkTotalOperations = None
                PriBulkTotalOperations = None
                BulkTotalTime = None
                PriBulkTotalTime = None
                BulkTotalSizeInBytes = None
                PriBulkTotalSizeInBytes = None
                BulkAvgTime = None
                PriBulkAvgTime = None
                BulkAvgSizeInBytes = None
                PriBulkAvgSizeInBytes = None
            }

        [<CustomOperation("health")>]
        member _.Health(state: IndicesRecord, value: string) =
            { state with Health = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: IndicesRecord, value: string) =
            { state with Status = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesRecord, value: string) =
            { state with Index = Some value }

        [<CustomOperation("uuid")>]
        member _.Uuid(state: IndicesRecord, value: string) =
            { state with Uuid = Some value }

        [<CustomOperation("pri")>]
        member _.Pri(state: IndicesRecord, value: string) =
            { state with Pri = Some value }

        [<CustomOperation("rep")>]
        member _.Rep(state: IndicesRecord, value: string) =
            { state with Rep = Some value }

        [<CustomOperation("docsCount")>]
        member _.DocsCount(state: IndicesRecord, value: string option) =
            { state with DocsCount = Some value }

        [<CustomOperation("docsDeleted")>]
        member _.DocsDeleted(state: IndicesRecord, value: string option) =
            { state with DocsDeleted = Some value }

        [<CustomOperation("creationDate")>]
        member _.CreationDate(state: IndicesRecord, value: string) =
            { state with CreationDate = Some value }

        [<CustomOperation("creationDateString")>]
        member _.CreationDateString(state: IndicesRecord, value: string) =
            { state with CreationDateString = Some value }

        [<CustomOperation("storeSize")>]
        member _.StoreSize(state: IndicesRecord, value: string option) =
            { state with StoreSize = Some value }

        [<CustomOperation("priStoreSize")>]
        member _.PriStoreSize(state: IndicesRecord, value: string option) =
            { state with PriStoreSize = Some value }

        [<CustomOperation("datasetSize")>]
        member _.DatasetSize(state: IndicesRecord, value: string option) =
            { state with DatasetSize = Some value }

        [<CustomOperation("completionSize")>]
        member _.CompletionSize(state: IndicesRecord, value: string) =
            { state with CompletionSize = Some value }

        [<CustomOperation("priCompletionSize")>]
        member _.PriCompletionSize(state: IndicesRecord, value: string) =
            { state with PriCompletionSize = Some value }

        [<CustomOperation("fielddataMemorySize")>]
        member _.FielddataMemorySize(state: IndicesRecord, value: string) =
            { state with FielddataMemorySize = Some value }

        [<CustomOperation("priFielddataMemorySize")>]
        member _.PriFielddataMemorySize(state: IndicesRecord, value: string) =
            { state with PriFielddataMemorySize = Some value }

        [<CustomOperation("fielddataEvictions")>]
        member _.FielddataEvictions(state: IndicesRecord, value: string) =
            { state with FielddataEvictions = Some value }

        [<CustomOperation("priFielddataEvictions")>]
        member _.PriFielddataEvictions(state: IndicesRecord, value: string) =
            { state with PriFielddataEvictions = Some value }

        [<CustomOperation("queryCacheMemorySize")>]
        member _.QueryCacheMemorySize(state: IndicesRecord, value: string) =
            { state with QueryCacheMemorySize = Some value }

        [<CustomOperation("priQueryCacheMemorySize")>]
        member _.PriQueryCacheMemorySize(state: IndicesRecord, value: string) =
            { state with PriQueryCacheMemorySize = Some value }

        [<CustomOperation("queryCacheEvictions")>]
        member _.QueryCacheEvictions(state: IndicesRecord, value: string) =
            { state with QueryCacheEvictions = Some value }

        [<CustomOperation("priQueryCacheEvictions")>]
        member _.PriQueryCacheEvictions(state: IndicesRecord, value: string) =
            { state with PriQueryCacheEvictions = Some value }

        [<CustomOperation("requestCacheMemorySize")>]
        member _.RequestCacheMemorySize(state: IndicesRecord, value: string) =
            { state with RequestCacheMemorySize = Some value }

        [<CustomOperation("priRequestCacheMemorySize")>]
        member _.PriRequestCacheMemorySize(state: IndicesRecord, value: string) =
            { state with PriRequestCacheMemorySize = Some value }

        [<CustomOperation("requestCacheEvictions")>]
        member _.RequestCacheEvictions(state: IndicesRecord, value: string) =
            { state with RequestCacheEvictions = Some value }

        [<CustomOperation("priRequestCacheEvictions")>]
        member _.PriRequestCacheEvictions(state: IndicesRecord, value: string) =
            { state with PriRequestCacheEvictions = Some value }

        [<CustomOperation("requestCacheHitCount")>]
        member _.RequestCacheHitCount(state: IndicesRecord, value: string) =
            { state with RequestCacheHitCount = Some value }

        [<CustomOperation("priRequestCacheHitCount")>]
        member _.PriRequestCacheHitCount(state: IndicesRecord, value: string) =
            { state with PriRequestCacheHitCount = Some value }

        [<CustomOperation("requestCacheMissCount")>]
        member _.RequestCacheMissCount(state: IndicesRecord, value: string) =
            { state with RequestCacheMissCount = Some value }

        [<CustomOperation("priRequestCacheMissCount")>]
        member _.PriRequestCacheMissCount(state: IndicesRecord, value: string) =
            { state with PriRequestCacheMissCount = Some value }

        [<CustomOperation("flushTotal")>]
        member _.FlushTotal(state: IndicesRecord, value: string) =
            { state with FlushTotal = Some value }

        [<CustomOperation("priFlushTotal")>]
        member _.PriFlushTotal(state: IndicesRecord, value: string) =
            { state with PriFlushTotal = Some value }

        [<CustomOperation("flushTotalTime")>]
        member _.FlushTotalTime(state: IndicesRecord, value: string) =
            { state with FlushTotalTime = Some value }

        [<CustomOperation("priFlushTotalTime")>]
        member _.PriFlushTotalTime(state: IndicesRecord, value: string) =
            { state with PriFlushTotalTime = Some value }

        [<CustomOperation("getCurrent")>]
        member _.GetCurrent(state: IndicesRecord, value: string) =
            { state with GetCurrent = Some value }

        [<CustomOperation("priGetCurrent")>]
        member _.PriGetCurrent(state: IndicesRecord, value: string) =
            { state with PriGetCurrent = Some value }

        [<CustomOperation("getTime")>]
        member _.GetTime(state: IndicesRecord, value: string) =
            { state with GetTime = Some value }

        [<CustomOperation("priGetTime")>]
        member _.PriGetTime(state: IndicesRecord, value: string) =
            { state with PriGetTime = Some value }

        [<CustomOperation("getTotal")>]
        member _.GetTotal(state: IndicesRecord, value: string) =
            { state with GetTotal = Some value }

        [<CustomOperation("priGetTotal")>]
        member _.PriGetTotal(state: IndicesRecord, value: string) =
            { state with PriGetTotal = Some value }

        [<CustomOperation("getExistsTime")>]
        member _.GetExistsTime(state: IndicesRecord, value: string) =
            { state with GetExistsTime = Some value }

        [<CustomOperation("priGetExistsTime")>]
        member _.PriGetExistsTime(state: IndicesRecord, value: string) =
            { state with PriGetExistsTime = Some value }

        [<CustomOperation("getExistsTotal")>]
        member _.GetExistsTotal(state: IndicesRecord, value: string) =
            { state with GetExistsTotal = Some value }

        [<CustomOperation("priGetExistsTotal")>]
        member _.PriGetExistsTotal(state: IndicesRecord, value: string) =
            { state with PriGetExistsTotal = Some value }

        [<CustomOperation("getMissingTime")>]
        member _.GetMissingTime(state: IndicesRecord, value: string) =
            { state with GetMissingTime = Some value }

        [<CustomOperation("priGetMissingTime")>]
        member _.PriGetMissingTime(state: IndicesRecord, value: string) =
            { state with PriGetMissingTime = Some value }

        [<CustomOperation("getMissingTotal")>]
        member _.GetMissingTotal(state: IndicesRecord, value: string) =
            { state with GetMissingTotal = Some value }

        [<CustomOperation("priGetMissingTotal")>]
        member _.PriGetMissingTotal(state: IndicesRecord, value: string) =
            { state with PriGetMissingTotal = Some value }

        [<CustomOperation("indexingDeleteCurrent")>]
        member _.IndexingDeleteCurrent(state: IndicesRecord, value: string) =
            { state with IndexingDeleteCurrent = Some value }

        [<CustomOperation("priIndexingDeleteCurrent")>]
        member _.PriIndexingDeleteCurrent(state: IndicesRecord, value: string) =
            { state with PriIndexingDeleteCurrent = Some value }

        [<CustomOperation("indexingDeleteTime")>]
        member _.IndexingDeleteTime(state: IndicesRecord, value: string) =
            { state with IndexingDeleteTime = Some value }

        [<CustomOperation("priIndexingDeleteTime")>]
        member _.PriIndexingDeleteTime(state: IndicesRecord, value: string) =
            { state with PriIndexingDeleteTime = Some value }

        [<CustomOperation("indexingDeleteTotal")>]
        member _.IndexingDeleteTotal(state: IndicesRecord, value: string) =
            { state with IndexingDeleteTotal = Some value }

        [<CustomOperation("priIndexingDeleteTotal")>]
        member _.PriIndexingDeleteTotal(state: IndicesRecord, value: string) =
            { state with PriIndexingDeleteTotal = Some value }

        [<CustomOperation("indexingIndexCurrent")>]
        member _.IndexingIndexCurrent(state: IndicesRecord, value: string) =
            { state with IndexingIndexCurrent = Some value }

        [<CustomOperation("priIndexingIndexCurrent")>]
        member _.PriIndexingIndexCurrent(state: IndicesRecord, value: string) =
            { state with PriIndexingIndexCurrent = Some value }

        [<CustomOperation("indexingIndexTime")>]
        member _.IndexingIndexTime(state: IndicesRecord, value: string) =
            { state with IndexingIndexTime = Some value }

        [<CustomOperation("priIndexingIndexTime")>]
        member _.PriIndexingIndexTime(state: IndicesRecord, value: string) =
            { state with PriIndexingIndexTime = Some value }

        [<CustomOperation("indexingIndexTotal")>]
        member _.IndexingIndexTotal(state: IndicesRecord, value: string) =
            { state with IndexingIndexTotal = Some value }

        [<CustomOperation("priIndexingIndexTotal")>]
        member _.PriIndexingIndexTotal(state: IndicesRecord, value: string) =
            { state with PriIndexingIndexTotal = Some value }

        [<CustomOperation("indexingIndexFailed")>]
        member _.IndexingIndexFailed(state: IndicesRecord, value: string) =
            { state with IndexingIndexFailed = Some value }

        [<CustomOperation("priIndexingIndexFailed")>]
        member _.PriIndexingIndexFailed(state: IndicesRecord, value: string) =
            { state with PriIndexingIndexFailed = Some value }

        [<CustomOperation("mergesCurrent")>]
        member _.MergesCurrent(state: IndicesRecord, value: string) =
            { state with MergesCurrent = Some value }

        [<CustomOperation("priMergesCurrent")>]
        member _.PriMergesCurrent(state: IndicesRecord, value: string) =
            { state with PriMergesCurrent = Some value }

        [<CustomOperation("mergesCurrentDocs")>]
        member _.MergesCurrentDocs(state: IndicesRecord, value: string) =
            { state with MergesCurrentDocs = Some value }

        [<CustomOperation("priMergesCurrentDocs")>]
        member _.PriMergesCurrentDocs(state: IndicesRecord, value: string) =
            { state with PriMergesCurrentDocs = Some value }

        [<CustomOperation("mergesCurrentSize")>]
        member _.MergesCurrentSize(state: IndicesRecord, value: string) =
            { state with MergesCurrentSize = Some value }

        [<CustomOperation("priMergesCurrentSize")>]
        member _.PriMergesCurrentSize(state: IndicesRecord, value: string) =
            { state with PriMergesCurrentSize = Some value }

        [<CustomOperation("mergesTotal")>]
        member _.MergesTotal(state: IndicesRecord, value: string) =
            { state with MergesTotal = Some value }

        [<CustomOperation("priMergesTotal")>]
        member _.PriMergesTotal(state: IndicesRecord, value: string) =
            { state with PriMergesTotal = Some value }

        [<CustomOperation("mergesTotalDocs")>]
        member _.MergesTotalDocs(state: IndicesRecord, value: string) =
            { state with MergesTotalDocs = Some value }

        [<CustomOperation("priMergesTotalDocs")>]
        member _.PriMergesTotalDocs(state: IndicesRecord, value: string) =
            { state with PriMergesTotalDocs = Some value }

        [<CustomOperation("mergesTotalSize")>]
        member _.MergesTotalSize(state: IndicesRecord, value: string) =
            { state with MergesTotalSize = Some value }

        [<CustomOperation("priMergesTotalSize")>]
        member _.PriMergesTotalSize(state: IndicesRecord, value: string) =
            { state with PriMergesTotalSize = Some value }

        [<CustomOperation("mergesTotalTime")>]
        member _.MergesTotalTime(state: IndicesRecord, value: string) =
            { state with MergesTotalTime = Some value }

        [<CustomOperation("priMergesTotalTime")>]
        member _.PriMergesTotalTime(state: IndicesRecord, value: string) =
            { state with PriMergesTotalTime = Some value }

        [<CustomOperation("refreshTotal")>]
        member _.RefreshTotal(state: IndicesRecord, value: string) =
            { state with RefreshTotal = Some value }

        [<CustomOperation("priRefreshTotal")>]
        member _.PriRefreshTotal(state: IndicesRecord, value: string) =
            { state with PriRefreshTotal = Some value }

        [<CustomOperation("refreshTime")>]
        member _.RefreshTime(state: IndicesRecord, value: string) =
            { state with RefreshTime = Some value }

        [<CustomOperation("priRefreshTime")>]
        member _.PriRefreshTime(state: IndicesRecord, value: string) =
            { state with PriRefreshTime = Some value }

        [<CustomOperation("refreshExternalTotal")>]
        member _.RefreshExternalTotal(state: IndicesRecord, value: string) =
            { state with RefreshExternalTotal = Some value }

        [<CustomOperation("priRefreshExternalTotal")>]
        member _.PriRefreshExternalTotal(state: IndicesRecord, value: string) =
            { state with PriRefreshExternalTotal = Some value }

        [<CustomOperation("refreshExternalTime")>]
        member _.RefreshExternalTime(state: IndicesRecord, value: string) =
            { state with RefreshExternalTime = Some value }

        [<CustomOperation("priRefreshExternalTime")>]
        member _.PriRefreshExternalTime(state: IndicesRecord, value: string) =
            { state with PriRefreshExternalTime = Some value }

        [<CustomOperation("refreshListeners")>]
        member _.RefreshListeners(state: IndicesRecord, value: string) =
            { state with RefreshListeners = Some value }

        [<CustomOperation("priRefreshListeners")>]
        member _.PriRefreshListeners(state: IndicesRecord, value: string) =
            { state with PriRefreshListeners = Some value }

        [<CustomOperation("searchFetchCurrent")>]
        member _.SearchFetchCurrent(state: IndicesRecord, value: string) =
            { state with SearchFetchCurrent = Some value }

        [<CustomOperation("priSearchFetchCurrent")>]
        member _.PriSearchFetchCurrent(state: IndicesRecord, value: string) =
            { state with PriSearchFetchCurrent = Some value }

        [<CustomOperation("searchFetchTime")>]
        member _.SearchFetchTime(state: IndicesRecord, value: string) =
            { state with SearchFetchTime = Some value }

        [<CustomOperation("priSearchFetchTime")>]
        member _.PriSearchFetchTime(state: IndicesRecord, value: string) =
            { state with PriSearchFetchTime = Some value }

        [<CustomOperation("searchFetchTotal")>]
        member _.SearchFetchTotal(state: IndicesRecord, value: string) =
            { state with SearchFetchTotal = Some value }

        [<CustomOperation("priSearchFetchTotal")>]
        member _.PriSearchFetchTotal(state: IndicesRecord, value: string) =
            { state with PriSearchFetchTotal = Some value }

        [<CustomOperation("searchOpenContexts")>]
        member _.SearchOpenContexts(state: IndicesRecord, value: string) =
            { state with SearchOpenContexts = Some value }

        [<CustomOperation("priSearchOpenContexts")>]
        member _.PriSearchOpenContexts(state: IndicesRecord, value: string) =
            { state with PriSearchOpenContexts = Some value }

        [<CustomOperation("searchQueryCurrent")>]
        member _.SearchQueryCurrent(state: IndicesRecord, value: string) =
            { state with SearchQueryCurrent = Some value }

        [<CustomOperation("priSearchQueryCurrent")>]
        member _.PriSearchQueryCurrent(state: IndicesRecord, value: string) =
            { state with PriSearchQueryCurrent = Some value }

        [<CustomOperation("searchQueryTime")>]
        member _.SearchQueryTime(state: IndicesRecord, value: string) =
            { state with SearchQueryTime = Some value }

        [<CustomOperation("priSearchQueryTime")>]
        member _.PriSearchQueryTime(state: IndicesRecord, value: string) =
            { state with PriSearchQueryTime = Some value }

        [<CustomOperation("searchQueryTotal")>]
        member _.SearchQueryTotal(state: IndicesRecord, value: string) =
            { state with SearchQueryTotal = Some value }

        [<CustomOperation("priSearchQueryTotal")>]
        member _.PriSearchQueryTotal(state: IndicesRecord, value: string) =
            { state with PriSearchQueryTotal = Some value }

        [<CustomOperation("searchScrollCurrent")>]
        member _.SearchScrollCurrent(state: IndicesRecord, value: string) =
            { state with SearchScrollCurrent = Some value }

        [<CustomOperation("priSearchScrollCurrent")>]
        member _.PriSearchScrollCurrent(state: IndicesRecord, value: string) =
            { state with PriSearchScrollCurrent = Some value }

        [<CustomOperation("searchScrollTime")>]
        member _.SearchScrollTime(state: IndicesRecord, value: string) =
            { state with SearchScrollTime = Some value }

        [<CustomOperation("priSearchScrollTime")>]
        member _.PriSearchScrollTime(state: IndicesRecord, value: string) =
            { state with PriSearchScrollTime = Some value }

        [<CustomOperation("searchScrollTotal")>]
        member _.SearchScrollTotal(state: IndicesRecord, value: string) =
            { state with SearchScrollTotal = Some value }

        [<CustomOperation("priSearchScrollTotal")>]
        member _.PriSearchScrollTotal(state: IndicesRecord, value: string) =
            { state with PriSearchScrollTotal = Some value }

        [<CustomOperation("segmentsCount")>]
        member _.SegmentsCount(state: IndicesRecord, value: string) =
            { state with SegmentsCount = Some value }

        [<CustomOperation("priSegmentsCount")>]
        member _.PriSegmentsCount(state: IndicesRecord, value: string) =
            { state with PriSegmentsCount = Some value }

        [<CustomOperation("segmentsMemory")>]
        member _.SegmentsMemory(state: IndicesRecord, value: string) =
            { state with SegmentsMemory = Some value }

        [<CustomOperation("priSegmentsMemory")>]
        member _.PriSegmentsMemory(state: IndicesRecord, value: string) =
            { state with PriSegmentsMemory = Some value }

        [<CustomOperation("segmentsIndexWriterMemory")>]
        member _.SegmentsIndexWriterMemory(state: IndicesRecord, value: string) =
            { state with SegmentsIndexWriterMemory = Some value }

        [<CustomOperation("priSegmentsIndexWriterMemory")>]
        member _.PriSegmentsIndexWriterMemory(state: IndicesRecord, value: string) =
            { state with PriSegmentsIndexWriterMemory = Some value }

        [<CustomOperation("segmentsVersionMapMemory")>]
        member _.SegmentsVersionMapMemory(state: IndicesRecord, value: string) =
            { state with SegmentsVersionMapMemory = Some value }

        [<CustomOperation("priSegmentsVersionMapMemory")>]
        member _.PriSegmentsVersionMapMemory(state: IndicesRecord, value: string) =
            { state with PriSegmentsVersionMapMemory = Some value }

        [<CustomOperation("segmentsFixedBitsetMemory")>]
        member _.SegmentsFixedBitsetMemory(state: IndicesRecord, value: string) =
            { state with SegmentsFixedBitsetMemory = Some value }

        [<CustomOperation("priSegmentsFixedBitsetMemory")>]
        member _.PriSegmentsFixedBitsetMemory(state: IndicesRecord, value: string) =
            { state with PriSegmentsFixedBitsetMemory = Some value }

        [<CustomOperation("warmerCurrent")>]
        member _.WarmerCurrent(state: IndicesRecord, value: string) =
            { state with WarmerCurrent = Some value }

        [<CustomOperation("priWarmerCurrent")>]
        member _.PriWarmerCurrent(state: IndicesRecord, value: string) =
            { state with PriWarmerCurrent = Some value }

        [<CustomOperation("warmerTotal")>]
        member _.WarmerTotal(state: IndicesRecord, value: string) =
            { state with WarmerTotal = Some value }

        [<CustomOperation("priWarmerTotal")>]
        member _.PriWarmerTotal(state: IndicesRecord, value: string) =
            { state with PriWarmerTotal = Some value }

        [<CustomOperation("warmerTotalTime")>]
        member _.WarmerTotalTime(state: IndicesRecord, value: string) =
            { state with WarmerTotalTime = Some value }

        [<CustomOperation("priWarmerTotalTime")>]
        member _.PriWarmerTotalTime(state: IndicesRecord, value: string) =
            { state with PriWarmerTotalTime = Some value }

        [<CustomOperation("suggestCurrent")>]
        member _.SuggestCurrent(state: IndicesRecord, value: string) =
            { state with SuggestCurrent = Some value }

        [<CustomOperation("priSuggestCurrent")>]
        member _.PriSuggestCurrent(state: IndicesRecord, value: string) =
            { state with PriSuggestCurrent = Some value }

        [<CustomOperation("suggestTime")>]
        member _.SuggestTime(state: IndicesRecord, value: string) =
            { state with SuggestTime = Some value }

        [<CustomOperation("priSuggestTime")>]
        member _.PriSuggestTime(state: IndicesRecord, value: string) =
            { state with PriSuggestTime = Some value }

        [<CustomOperation("suggestTotal")>]
        member _.SuggestTotal(state: IndicesRecord, value: string) =
            { state with SuggestTotal = Some value }

        [<CustomOperation("priSuggestTotal")>]
        member _.PriSuggestTotal(state: IndicesRecord, value: string) =
            { state with PriSuggestTotal = Some value }

        [<CustomOperation("memoryTotal")>]
        member _.MemoryTotal(state: IndicesRecord, value: string) =
            { state with MemoryTotal = Some value }

        [<CustomOperation("priMemoryTotal")>]
        member _.PriMemoryTotal(state: IndicesRecord, value: string) =
            { state with PriMemoryTotal = Some value }

        [<CustomOperation("searchThrottled")>]
        member _.SearchThrottled(state: IndicesRecord, value: string) =
            { state with SearchThrottled = Some value }

        [<CustomOperation("bulkTotalOperations")>]
        member _.BulkTotalOperations(state: IndicesRecord, value: string) =
            { state with BulkTotalOperations = Some value }

        [<CustomOperation("priBulkTotalOperations")>]
        member _.PriBulkTotalOperations(state: IndicesRecord, value: string) =
            { state with PriBulkTotalOperations = Some value }

        [<CustomOperation("bulkTotalTime")>]
        member _.BulkTotalTime(state: IndicesRecord, value: string) =
            { state with BulkTotalTime = Some value }

        [<CustomOperation("priBulkTotalTime")>]
        member _.PriBulkTotalTime(state: IndicesRecord, value: string) =
            { state with PriBulkTotalTime = Some value }

        [<CustomOperation("bulkTotalSizeInBytes")>]
        member _.BulkTotalSizeInBytes(state: IndicesRecord, value: string) =
            { state with BulkTotalSizeInBytes = Some value }

        [<CustomOperation("priBulkTotalSizeInBytes")>]
        member _.PriBulkTotalSizeInBytes(state: IndicesRecord, value: string) =
            { state with PriBulkTotalSizeInBytes = Some value }

        [<CustomOperation("bulkAvgTime")>]
        member _.BulkAvgTime(state: IndicesRecord, value: string) =
            { state with BulkAvgTime = Some value }

        [<CustomOperation("priBulkAvgTime")>]
        member _.PriBulkAvgTime(state: IndicesRecord, value: string) =
            { state with PriBulkAvgTime = Some value }

        [<CustomOperation("bulkAvgSizeInBytes")>]
        member _.BulkAvgSizeInBytes(state: IndicesRecord, value: string) =
            { state with BulkAvgSizeInBytes = Some value }

        [<CustomOperation("priBulkAvgSizeInBytes")>]
        member _.PriBulkAvgSizeInBytes(state: IndicesRecord, value: string) =
            { state with PriBulkAvgSizeInBytes = Some value }

    let indicesRecord = IndicesRecordBuilder()


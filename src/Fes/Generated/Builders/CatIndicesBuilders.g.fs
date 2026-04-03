// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module CatIndicesBuilders =

    type IndicesRecordBuilder() =
        member _.Yield(_: unit) : Types.IndicesRecord =
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
        member _.Health(state: Types.IndicesRecord, value: string) =
            { state with Health = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.IndicesRecord, value: string) =
            { state with Status = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.IndicesRecord, value: string) =
            { state with Index = Some value }

        [<CustomOperation("uuid")>]
        member _.Uuid(state: Types.IndicesRecord, value: string) =
            { state with Uuid = Some value }

        [<CustomOperation("pri")>]
        member _.Pri(state: Types.IndicesRecord, value: string) =
            { state with Pri = Some value }

        [<CustomOperation("rep")>]
        member _.Rep(state: Types.IndicesRecord, value: string) =
            { state with Rep = Some value }

        [<CustomOperation("docsCount")>]
        member _.DocsCount(state: Types.IndicesRecord, value: string option) =
            { state with DocsCount = Some value }

        [<CustomOperation("docsDeleted")>]
        member _.DocsDeleted(state: Types.IndicesRecord, value: string option) =
            { state with DocsDeleted = Some value }

        [<CustomOperation("creationDate")>]
        member _.CreationDate(state: Types.IndicesRecord, value: string) =
            { state with CreationDate = Some value }

        [<CustomOperation("creationDateString")>]
        member _.CreationDateString(state: Types.IndicesRecord, value: string) =
            { state with CreationDateString = Some value }

        [<CustomOperation("storeSize")>]
        member _.StoreSize(state: Types.IndicesRecord, value: string option) =
            { state with StoreSize = Some value }

        [<CustomOperation("priStoreSize")>]
        member _.PriStoreSize(state: Types.IndicesRecord, value: string option) =
            { state with PriStoreSize = Some value }

        [<CustomOperation("datasetSize")>]
        member _.DatasetSize(state: Types.IndicesRecord, value: string option) =
            { state with DatasetSize = Some value }

        [<CustomOperation("completionSize")>]
        member _.CompletionSize(state: Types.IndicesRecord, value: string) =
            { state with CompletionSize = Some value }

        [<CustomOperation("priCompletionSize")>]
        member _.PriCompletionSize(state: Types.IndicesRecord, value: string) =
            { state with PriCompletionSize = Some value }

        [<CustomOperation("fielddataMemorySize")>]
        member _.FielddataMemorySize(state: Types.IndicesRecord, value: string) =
            { state with FielddataMemorySize = Some value }

        [<CustomOperation("priFielddataMemorySize")>]
        member _.PriFielddataMemorySize(state: Types.IndicesRecord, value: string) =
            { state with PriFielddataMemorySize = Some value }

        [<CustomOperation("fielddataEvictions")>]
        member _.FielddataEvictions(state: Types.IndicesRecord, value: string) =
            { state with FielddataEvictions = Some value }

        [<CustomOperation("priFielddataEvictions")>]
        member _.PriFielddataEvictions(state: Types.IndicesRecord, value: string) =
            { state with PriFielddataEvictions = Some value }

        [<CustomOperation("queryCacheMemorySize")>]
        member _.QueryCacheMemorySize(state: Types.IndicesRecord, value: string) =
            { state with QueryCacheMemorySize = Some value }

        [<CustomOperation("priQueryCacheMemorySize")>]
        member _.PriQueryCacheMemorySize(state: Types.IndicesRecord, value: string) =
            { state with PriQueryCacheMemorySize = Some value }

        [<CustomOperation("queryCacheEvictions")>]
        member _.QueryCacheEvictions(state: Types.IndicesRecord, value: string) =
            { state with QueryCacheEvictions = Some value }

        [<CustomOperation("priQueryCacheEvictions")>]
        member _.PriQueryCacheEvictions(state: Types.IndicesRecord, value: string) =
            { state with PriQueryCacheEvictions = Some value }

        [<CustomOperation("requestCacheMemorySize")>]
        member _.RequestCacheMemorySize(state: Types.IndicesRecord, value: string) =
            { state with RequestCacheMemorySize = Some value }

        [<CustomOperation("priRequestCacheMemorySize")>]
        member _.PriRequestCacheMemorySize(state: Types.IndicesRecord, value: string) =
            { state with PriRequestCacheMemorySize = Some value }

        [<CustomOperation("requestCacheEvictions")>]
        member _.RequestCacheEvictions(state: Types.IndicesRecord, value: string) =
            { state with RequestCacheEvictions = Some value }

        [<CustomOperation("priRequestCacheEvictions")>]
        member _.PriRequestCacheEvictions(state: Types.IndicesRecord, value: string) =
            { state with PriRequestCacheEvictions = Some value }

        [<CustomOperation("requestCacheHitCount")>]
        member _.RequestCacheHitCount(state: Types.IndicesRecord, value: string) =
            { state with RequestCacheHitCount = Some value }

        [<CustomOperation("priRequestCacheHitCount")>]
        member _.PriRequestCacheHitCount(state: Types.IndicesRecord, value: string) =
            { state with PriRequestCacheHitCount = Some value }

        [<CustomOperation("requestCacheMissCount")>]
        member _.RequestCacheMissCount(state: Types.IndicesRecord, value: string) =
            { state with RequestCacheMissCount = Some value }

        [<CustomOperation("priRequestCacheMissCount")>]
        member _.PriRequestCacheMissCount(state: Types.IndicesRecord, value: string) =
            { state with PriRequestCacheMissCount = Some value }

        [<CustomOperation("flushTotal")>]
        member _.FlushTotal(state: Types.IndicesRecord, value: string) =
            { state with FlushTotal = Some value }

        [<CustomOperation("priFlushTotal")>]
        member _.PriFlushTotal(state: Types.IndicesRecord, value: string) =
            { state with PriFlushTotal = Some value }

        [<CustomOperation("flushTotalTime")>]
        member _.FlushTotalTime(state: Types.IndicesRecord, value: string) =
            { state with FlushTotalTime = Some value }

        [<CustomOperation("priFlushTotalTime")>]
        member _.PriFlushTotalTime(state: Types.IndicesRecord, value: string) =
            { state with PriFlushTotalTime = Some value }

        [<CustomOperation("getCurrent")>]
        member _.GetCurrent(state: Types.IndicesRecord, value: string) =
            { state with GetCurrent = Some value }

        [<CustomOperation("priGetCurrent")>]
        member _.PriGetCurrent(state: Types.IndicesRecord, value: string) =
            { state with PriGetCurrent = Some value }

        [<CustomOperation("getTime")>]
        member _.GetTime(state: Types.IndicesRecord, value: string) =
            { state with GetTime = Some value }

        [<CustomOperation("priGetTime")>]
        member _.PriGetTime(state: Types.IndicesRecord, value: string) =
            { state with PriGetTime = Some value }

        [<CustomOperation("getTotal")>]
        member _.GetTotal(state: Types.IndicesRecord, value: string) =
            { state with GetTotal = Some value }

        [<CustomOperation("priGetTotal")>]
        member _.PriGetTotal(state: Types.IndicesRecord, value: string) =
            { state with PriGetTotal = Some value }

        [<CustomOperation("getExistsTime")>]
        member _.GetExistsTime(state: Types.IndicesRecord, value: string) =
            { state with GetExistsTime = Some value }

        [<CustomOperation("priGetExistsTime")>]
        member _.PriGetExistsTime(state: Types.IndicesRecord, value: string) =
            { state with PriGetExistsTime = Some value }

        [<CustomOperation("getExistsTotal")>]
        member _.GetExistsTotal(state: Types.IndicesRecord, value: string) =
            { state with GetExistsTotal = Some value }

        [<CustomOperation("priGetExistsTotal")>]
        member _.PriGetExistsTotal(state: Types.IndicesRecord, value: string) =
            { state with PriGetExistsTotal = Some value }

        [<CustomOperation("getMissingTime")>]
        member _.GetMissingTime(state: Types.IndicesRecord, value: string) =
            { state with GetMissingTime = Some value }

        [<CustomOperation("priGetMissingTime")>]
        member _.PriGetMissingTime(state: Types.IndicesRecord, value: string) =
            { state with PriGetMissingTime = Some value }

        [<CustomOperation("getMissingTotal")>]
        member _.GetMissingTotal(state: Types.IndicesRecord, value: string) =
            { state with GetMissingTotal = Some value }

        [<CustomOperation("priGetMissingTotal")>]
        member _.PriGetMissingTotal(state: Types.IndicesRecord, value: string) =
            { state with PriGetMissingTotal = Some value }

        [<CustomOperation("indexingDeleteCurrent")>]
        member _.IndexingDeleteCurrent(state: Types.IndicesRecord, value: string) =
            { state with IndexingDeleteCurrent = Some value }

        [<CustomOperation("priIndexingDeleteCurrent")>]
        member _.PriIndexingDeleteCurrent(state: Types.IndicesRecord, value: string) =
            { state with PriIndexingDeleteCurrent = Some value }

        [<CustomOperation("indexingDeleteTime")>]
        member _.IndexingDeleteTime(state: Types.IndicesRecord, value: string) =
            { state with IndexingDeleteTime = Some value }

        [<CustomOperation("priIndexingDeleteTime")>]
        member _.PriIndexingDeleteTime(state: Types.IndicesRecord, value: string) =
            { state with PriIndexingDeleteTime = Some value }

        [<CustomOperation("indexingDeleteTotal")>]
        member _.IndexingDeleteTotal(state: Types.IndicesRecord, value: string) =
            { state with IndexingDeleteTotal = Some value }

        [<CustomOperation("priIndexingDeleteTotal")>]
        member _.PriIndexingDeleteTotal(state: Types.IndicesRecord, value: string) =
            { state with PriIndexingDeleteTotal = Some value }

        [<CustomOperation("indexingIndexCurrent")>]
        member _.IndexingIndexCurrent(state: Types.IndicesRecord, value: string) =
            { state with IndexingIndexCurrent = Some value }

        [<CustomOperation("priIndexingIndexCurrent")>]
        member _.PriIndexingIndexCurrent(state: Types.IndicesRecord, value: string) =
            { state with PriIndexingIndexCurrent = Some value }

        [<CustomOperation("indexingIndexTime")>]
        member _.IndexingIndexTime(state: Types.IndicesRecord, value: string) =
            { state with IndexingIndexTime = Some value }

        [<CustomOperation("priIndexingIndexTime")>]
        member _.PriIndexingIndexTime(state: Types.IndicesRecord, value: string) =
            { state with PriIndexingIndexTime = Some value }

        [<CustomOperation("indexingIndexTotal")>]
        member _.IndexingIndexTotal(state: Types.IndicesRecord, value: string) =
            { state with IndexingIndexTotal = Some value }

        [<CustomOperation("priIndexingIndexTotal")>]
        member _.PriIndexingIndexTotal(state: Types.IndicesRecord, value: string) =
            { state with PriIndexingIndexTotal = Some value }

        [<CustomOperation("indexingIndexFailed")>]
        member _.IndexingIndexFailed(state: Types.IndicesRecord, value: string) =
            { state with IndexingIndexFailed = Some value }

        [<CustomOperation("priIndexingIndexFailed")>]
        member _.PriIndexingIndexFailed(state: Types.IndicesRecord, value: string) =
            { state with PriIndexingIndexFailed = Some value }

        [<CustomOperation("mergesCurrent")>]
        member _.MergesCurrent(state: Types.IndicesRecord, value: string) =
            { state with MergesCurrent = Some value }

        [<CustomOperation("priMergesCurrent")>]
        member _.PriMergesCurrent(state: Types.IndicesRecord, value: string) =
            { state with PriMergesCurrent = Some value }

        [<CustomOperation("mergesCurrentDocs")>]
        member _.MergesCurrentDocs(state: Types.IndicesRecord, value: string) =
            { state with MergesCurrentDocs = Some value }

        [<CustomOperation("priMergesCurrentDocs")>]
        member _.PriMergesCurrentDocs(state: Types.IndicesRecord, value: string) =
            { state with PriMergesCurrentDocs = Some value }

        [<CustomOperation("mergesCurrentSize")>]
        member _.MergesCurrentSize(state: Types.IndicesRecord, value: string) =
            { state with MergesCurrentSize = Some value }

        [<CustomOperation("priMergesCurrentSize")>]
        member _.PriMergesCurrentSize(state: Types.IndicesRecord, value: string) =
            { state with PriMergesCurrentSize = Some value }

        [<CustomOperation("mergesTotal")>]
        member _.MergesTotal(state: Types.IndicesRecord, value: string) =
            { state with MergesTotal = Some value }

        [<CustomOperation("priMergesTotal")>]
        member _.PriMergesTotal(state: Types.IndicesRecord, value: string) =
            { state with PriMergesTotal = Some value }

        [<CustomOperation("mergesTotalDocs")>]
        member _.MergesTotalDocs(state: Types.IndicesRecord, value: string) =
            { state with MergesTotalDocs = Some value }

        [<CustomOperation("priMergesTotalDocs")>]
        member _.PriMergesTotalDocs(state: Types.IndicesRecord, value: string) =
            { state with PriMergesTotalDocs = Some value }

        [<CustomOperation("mergesTotalSize")>]
        member _.MergesTotalSize(state: Types.IndicesRecord, value: string) =
            { state with MergesTotalSize = Some value }

        [<CustomOperation("priMergesTotalSize")>]
        member _.PriMergesTotalSize(state: Types.IndicesRecord, value: string) =
            { state with PriMergesTotalSize = Some value }

        [<CustomOperation("mergesTotalTime")>]
        member _.MergesTotalTime(state: Types.IndicesRecord, value: string) =
            { state with MergesTotalTime = Some value }

        [<CustomOperation("priMergesTotalTime")>]
        member _.PriMergesTotalTime(state: Types.IndicesRecord, value: string) =
            { state with PriMergesTotalTime = Some value }

        [<CustomOperation("refreshTotal")>]
        member _.RefreshTotal(state: Types.IndicesRecord, value: string) =
            { state with RefreshTotal = Some value }

        [<CustomOperation("priRefreshTotal")>]
        member _.PriRefreshTotal(state: Types.IndicesRecord, value: string) =
            { state with PriRefreshTotal = Some value }

        [<CustomOperation("refreshTime")>]
        member _.RefreshTime(state: Types.IndicesRecord, value: string) =
            { state with RefreshTime = Some value }

        [<CustomOperation("priRefreshTime")>]
        member _.PriRefreshTime(state: Types.IndicesRecord, value: string) =
            { state with PriRefreshTime = Some value }

        [<CustomOperation("refreshExternalTotal")>]
        member _.RefreshExternalTotal(state: Types.IndicesRecord, value: string) =
            { state with RefreshExternalTotal = Some value }

        [<CustomOperation("priRefreshExternalTotal")>]
        member _.PriRefreshExternalTotal(state: Types.IndicesRecord, value: string) =
            { state with PriRefreshExternalTotal = Some value }

        [<CustomOperation("refreshExternalTime")>]
        member _.RefreshExternalTime(state: Types.IndicesRecord, value: string) =
            { state with RefreshExternalTime = Some value }

        [<CustomOperation("priRefreshExternalTime")>]
        member _.PriRefreshExternalTime(state: Types.IndicesRecord, value: string) =
            { state with PriRefreshExternalTime = Some value }

        [<CustomOperation("refreshListeners")>]
        member _.RefreshListeners(state: Types.IndicesRecord, value: string) =
            { state with RefreshListeners = Some value }

        [<CustomOperation("priRefreshListeners")>]
        member _.PriRefreshListeners(state: Types.IndicesRecord, value: string) =
            { state with PriRefreshListeners = Some value }

        [<CustomOperation("searchFetchCurrent")>]
        member _.SearchFetchCurrent(state: Types.IndicesRecord, value: string) =
            { state with SearchFetchCurrent = Some value }

        [<CustomOperation("priSearchFetchCurrent")>]
        member _.PriSearchFetchCurrent(state: Types.IndicesRecord, value: string) =
            { state with PriSearchFetchCurrent = Some value }

        [<CustomOperation("searchFetchTime")>]
        member _.SearchFetchTime(state: Types.IndicesRecord, value: string) =
            { state with SearchFetchTime = Some value }

        [<CustomOperation("priSearchFetchTime")>]
        member _.PriSearchFetchTime(state: Types.IndicesRecord, value: string) =
            { state with PriSearchFetchTime = Some value }

        [<CustomOperation("searchFetchTotal")>]
        member _.SearchFetchTotal(state: Types.IndicesRecord, value: string) =
            { state with SearchFetchTotal = Some value }

        [<CustomOperation("priSearchFetchTotal")>]
        member _.PriSearchFetchTotal(state: Types.IndicesRecord, value: string) =
            { state with PriSearchFetchTotal = Some value }

        [<CustomOperation("searchOpenContexts")>]
        member _.SearchOpenContexts(state: Types.IndicesRecord, value: string) =
            { state with SearchOpenContexts = Some value }

        [<CustomOperation("priSearchOpenContexts")>]
        member _.PriSearchOpenContexts(state: Types.IndicesRecord, value: string) =
            { state with PriSearchOpenContexts = Some value }

        [<CustomOperation("searchQueryCurrent")>]
        member _.SearchQueryCurrent(state: Types.IndicesRecord, value: string) =
            { state with SearchQueryCurrent = Some value }

        [<CustomOperation("priSearchQueryCurrent")>]
        member _.PriSearchQueryCurrent(state: Types.IndicesRecord, value: string) =
            { state with PriSearchQueryCurrent = Some value }

        [<CustomOperation("searchQueryTime")>]
        member _.SearchQueryTime(state: Types.IndicesRecord, value: string) =
            { state with SearchQueryTime = Some value }

        [<CustomOperation("priSearchQueryTime")>]
        member _.PriSearchQueryTime(state: Types.IndicesRecord, value: string) =
            { state with PriSearchQueryTime = Some value }

        [<CustomOperation("searchQueryTotal")>]
        member _.SearchQueryTotal(state: Types.IndicesRecord, value: string) =
            { state with SearchQueryTotal = Some value }

        [<CustomOperation("priSearchQueryTotal")>]
        member _.PriSearchQueryTotal(state: Types.IndicesRecord, value: string) =
            { state with PriSearchQueryTotal = Some value }

        [<CustomOperation("searchScrollCurrent")>]
        member _.SearchScrollCurrent(state: Types.IndicesRecord, value: string) =
            { state with SearchScrollCurrent = Some value }

        [<CustomOperation("priSearchScrollCurrent")>]
        member _.PriSearchScrollCurrent(state: Types.IndicesRecord, value: string) =
            { state with PriSearchScrollCurrent = Some value }

        [<CustomOperation("searchScrollTime")>]
        member _.SearchScrollTime(state: Types.IndicesRecord, value: string) =
            { state with SearchScrollTime = Some value }

        [<CustomOperation("priSearchScrollTime")>]
        member _.PriSearchScrollTime(state: Types.IndicesRecord, value: string) =
            { state with PriSearchScrollTime = Some value }

        [<CustomOperation("searchScrollTotal")>]
        member _.SearchScrollTotal(state: Types.IndicesRecord, value: string) =
            { state with SearchScrollTotal = Some value }

        [<CustomOperation("priSearchScrollTotal")>]
        member _.PriSearchScrollTotal(state: Types.IndicesRecord, value: string) =
            { state with PriSearchScrollTotal = Some value }

        [<CustomOperation("segmentsCount")>]
        member _.SegmentsCount(state: Types.IndicesRecord, value: string) =
            { state with SegmentsCount = Some value }

        [<CustomOperation("priSegmentsCount")>]
        member _.PriSegmentsCount(state: Types.IndicesRecord, value: string) =
            { state with PriSegmentsCount = Some value }

        [<CustomOperation("segmentsMemory")>]
        member _.SegmentsMemory(state: Types.IndicesRecord, value: string) =
            { state with SegmentsMemory = Some value }

        [<CustomOperation("priSegmentsMemory")>]
        member _.PriSegmentsMemory(state: Types.IndicesRecord, value: string) =
            { state with PriSegmentsMemory = Some value }

        [<CustomOperation("segmentsIndexWriterMemory")>]
        member _.SegmentsIndexWriterMemory(state: Types.IndicesRecord, value: string) =
            { state with SegmentsIndexWriterMemory = Some value }

        [<CustomOperation("priSegmentsIndexWriterMemory")>]
        member _.PriSegmentsIndexWriterMemory(state: Types.IndicesRecord, value: string) =
            { state with PriSegmentsIndexWriterMemory = Some value }

        [<CustomOperation("segmentsVersionMapMemory")>]
        member _.SegmentsVersionMapMemory(state: Types.IndicesRecord, value: string) =
            { state with SegmentsVersionMapMemory = Some value }

        [<CustomOperation("priSegmentsVersionMapMemory")>]
        member _.PriSegmentsVersionMapMemory(state: Types.IndicesRecord, value: string) =
            { state with PriSegmentsVersionMapMemory = Some value }

        [<CustomOperation("segmentsFixedBitsetMemory")>]
        member _.SegmentsFixedBitsetMemory(state: Types.IndicesRecord, value: string) =
            { state with SegmentsFixedBitsetMemory = Some value }

        [<CustomOperation("priSegmentsFixedBitsetMemory")>]
        member _.PriSegmentsFixedBitsetMemory(state: Types.IndicesRecord, value: string) =
            { state with PriSegmentsFixedBitsetMemory = Some value }

        [<CustomOperation("warmerCurrent")>]
        member _.WarmerCurrent(state: Types.IndicesRecord, value: string) =
            { state with WarmerCurrent = Some value }

        [<CustomOperation("priWarmerCurrent")>]
        member _.PriWarmerCurrent(state: Types.IndicesRecord, value: string) =
            { state with PriWarmerCurrent = Some value }

        [<CustomOperation("warmerTotal")>]
        member _.WarmerTotal(state: Types.IndicesRecord, value: string) =
            { state with WarmerTotal = Some value }

        [<CustomOperation("priWarmerTotal")>]
        member _.PriWarmerTotal(state: Types.IndicesRecord, value: string) =
            { state with PriWarmerTotal = Some value }

        [<CustomOperation("warmerTotalTime")>]
        member _.WarmerTotalTime(state: Types.IndicesRecord, value: string) =
            { state with WarmerTotalTime = Some value }

        [<CustomOperation("priWarmerTotalTime")>]
        member _.PriWarmerTotalTime(state: Types.IndicesRecord, value: string) =
            { state with PriWarmerTotalTime = Some value }

        [<CustomOperation("suggestCurrent")>]
        member _.SuggestCurrent(state: Types.IndicesRecord, value: string) =
            { state with SuggestCurrent = Some value }

        [<CustomOperation("priSuggestCurrent")>]
        member _.PriSuggestCurrent(state: Types.IndicesRecord, value: string) =
            { state with PriSuggestCurrent = Some value }

        [<CustomOperation("suggestTime")>]
        member _.SuggestTime(state: Types.IndicesRecord, value: string) =
            { state with SuggestTime = Some value }

        [<CustomOperation("priSuggestTime")>]
        member _.PriSuggestTime(state: Types.IndicesRecord, value: string) =
            { state with PriSuggestTime = Some value }

        [<CustomOperation("suggestTotal")>]
        member _.SuggestTotal(state: Types.IndicesRecord, value: string) =
            { state with SuggestTotal = Some value }

        [<CustomOperation("priSuggestTotal")>]
        member _.PriSuggestTotal(state: Types.IndicesRecord, value: string) =
            { state with PriSuggestTotal = Some value }

        [<CustomOperation("memoryTotal")>]
        member _.MemoryTotal(state: Types.IndicesRecord, value: string) =
            { state with MemoryTotal = Some value }

        [<CustomOperation("priMemoryTotal")>]
        member _.PriMemoryTotal(state: Types.IndicesRecord, value: string) =
            { state with PriMemoryTotal = Some value }

        [<CustomOperation("searchThrottled")>]
        member _.SearchThrottled(state: Types.IndicesRecord, value: string) =
            { state with SearchThrottled = Some value }

        [<CustomOperation("bulkTotalOperations")>]
        member _.BulkTotalOperations(state: Types.IndicesRecord, value: string) =
            { state with BulkTotalOperations = Some value }

        [<CustomOperation("priBulkTotalOperations")>]
        member _.PriBulkTotalOperations(state: Types.IndicesRecord, value: string) =
            { state with PriBulkTotalOperations = Some value }

        [<CustomOperation("bulkTotalTime")>]
        member _.BulkTotalTime(state: Types.IndicesRecord, value: string) =
            { state with BulkTotalTime = Some value }

        [<CustomOperation("priBulkTotalTime")>]
        member _.PriBulkTotalTime(state: Types.IndicesRecord, value: string) =
            { state with PriBulkTotalTime = Some value }

        [<CustomOperation("bulkTotalSizeInBytes")>]
        member _.BulkTotalSizeInBytes(state: Types.IndicesRecord, value: string) =
            { state with BulkTotalSizeInBytes = Some value }

        [<CustomOperation("priBulkTotalSizeInBytes")>]
        member _.PriBulkTotalSizeInBytes(state: Types.IndicesRecord, value: string) =
            { state with PriBulkTotalSizeInBytes = Some value }

        [<CustomOperation("bulkAvgTime")>]
        member _.BulkAvgTime(state: Types.IndicesRecord, value: string) =
            { state with BulkAvgTime = Some value }

        [<CustomOperation("priBulkAvgTime")>]
        member _.PriBulkAvgTime(state: Types.IndicesRecord, value: string) =
            { state with PriBulkAvgTime = Some value }

        [<CustomOperation("bulkAvgSizeInBytes")>]
        member _.BulkAvgSizeInBytes(state: Types.IndicesRecord, value: string) =
            { state with BulkAvgSizeInBytes = Some value }

        [<CustomOperation("priBulkAvgSizeInBytes")>]
        member _.PriBulkAvgSizeInBytes(state: Types.IndicesRecord, value: string) =
            { state with PriBulkAvgSizeInBytes = Some value }

    let indicesRecord = IndicesRecordBuilder()


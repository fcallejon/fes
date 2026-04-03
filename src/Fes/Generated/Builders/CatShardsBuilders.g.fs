// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module CatShardsBuilders =

    type ShardsRecordBuilder() =
        member _.Yield(_: unit) : Types.ShardsRecord =
            {
                Index = None
                Shard = None
                Prirep = None
                State = None
                Docs = None
                Store = None
                Dataset = None
                Ip = None
                Id = None
                Node = None
                SyncId = None
                UnassignedReason = None
                UnassignedAt = None
                UnassignedFor = None
                UnassignedDetails = None
                RecoverysourceType = None
                CompletionSize = None
                FielddataMemorySize = None
                FielddataEvictions = None
                QueryCacheMemorySize = None
                QueryCacheEvictions = None
                FlushTotal = None
                FlushTotalTime = None
                GetCurrent = None
                GetTime = None
                GetTotal = None
                GetExistsTime = None
                GetExistsTotal = None
                GetMissingTime = None
                GetMissingTotal = None
                IndexingDeleteCurrent = None
                IndexingDeleteTime = None
                IndexingDeleteTotal = None
                IndexingIndexCurrent = None
                IndexingIndexTime = None
                IndexingIndexTotal = None
                IndexingIndexFailed = None
                MergesCurrent = None
                MergesCurrentDocs = None
                MergesCurrentSize = None
                MergesTotal = None
                MergesTotalDocs = None
                MergesTotalSize = None
                MergesTotalTime = None
                RefreshTotal = None
                RefreshTime = None
                RefreshExternalTotal = None
                RefreshExternalTime = None
                RefreshListeners = None
                SearchFetchCurrent = None
                SearchFetchTime = None
                SearchFetchTotal = None
                SearchOpenContexts = None
                SearchQueryCurrent = None
                SearchQueryTime = None
                SearchQueryTotal = None
                SearchScrollCurrent = None
                SearchScrollTime = None
                SearchScrollTotal = None
                SegmentsCount = None
                SegmentsMemory = None
                SegmentsIndexWriterMemory = None
                SegmentsVersionMapMemory = None
                SegmentsFixedBitsetMemory = None
                SeqNoMax = None
                SeqNoLocalCheckpoint = None
                SeqNoGlobalCheckpoint = None
                WarmerCurrent = None
                WarmerTotal = None
                WarmerTotalTime = None
                PathData = None
                PathState = None
                BulkTotalOperations = None
                BulkTotalTime = None
                BulkTotalSizeInBytes = None
                BulkAvgTime = None
                BulkAvgSizeInBytes = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: Types.ShardsRecord, value: string) =
            { state with Index = Some value }

        [<CustomOperation("shard")>]
        member _.Shard(state: Types.ShardsRecord, value: string) =
            { state with Shard = Some value }

        [<CustomOperation("prirep")>]
        member _.Prirep(state: Types.ShardsRecord, value: string) =
            { state with Prirep = Some value }

        [<CustomOperation("state")>]
        member _.State(state: Types.ShardsRecord, value: string) =
            { state with State = Some value }

        [<CustomOperation("docs")>]
        member _.Docs(state: Types.ShardsRecord, value: string option) =
            { state with Docs = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.ShardsRecord, value: string option) =
            { state with Store = Some value }

        [<CustomOperation("dataset")>]
        member _.Dataset(state: Types.ShardsRecord, value: string option) =
            { state with Dataset = Some value }

        [<CustomOperation("ip")>]
        member _.Ip(state: Types.ShardsRecord, value: string option) =
            { state with Ip = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: Types.ShardsRecord, value: string) =
            { state with Id = Some value }

        [<CustomOperation("node")>]
        member _.Node(state: Types.ShardsRecord, value: string option) =
            { state with Node = Some value }

        [<CustomOperation("syncId")>]
        member _.SyncId(state: Types.ShardsRecord, value: string) =
            { state with SyncId = Some value }

        [<CustomOperation("unassignedReason")>]
        member _.UnassignedReason(state: Types.ShardsRecord, value: string) =
            { state with UnassignedReason = Some value }

        [<CustomOperation("unassignedAt")>]
        member _.UnassignedAt(state: Types.ShardsRecord, value: string) =
            { state with UnassignedAt = Some value }

        [<CustomOperation("unassignedFor")>]
        member _.UnassignedFor(state: Types.ShardsRecord, value: string) =
            { state with UnassignedFor = Some value }

        [<CustomOperation("unassignedDetails")>]
        member _.UnassignedDetails(state: Types.ShardsRecord, value: string) =
            { state with UnassignedDetails = Some value }

        [<CustomOperation("recoverysourceType")>]
        member _.RecoverysourceType(state: Types.ShardsRecord, value: string) =
            { state with RecoverysourceType = Some value }

        [<CustomOperation("completionSize")>]
        member _.CompletionSize(state: Types.ShardsRecord, value: string) =
            { state with CompletionSize = Some value }

        [<CustomOperation("fielddataMemorySize")>]
        member _.FielddataMemorySize(state: Types.ShardsRecord, value: string) =
            { state with FielddataMemorySize = Some value }

        [<CustomOperation("fielddataEvictions")>]
        member _.FielddataEvictions(state: Types.ShardsRecord, value: string) =
            { state with FielddataEvictions = Some value }

        [<CustomOperation("queryCacheMemorySize")>]
        member _.QueryCacheMemorySize(state: Types.ShardsRecord, value: string) =
            { state with QueryCacheMemorySize = Some value }

        [<CustomOperation("queryCacheEvictions")>]
        member _.QueryCacheEvictions(state: Types.ShardsRecord, value: string) =
            { state with QueryCacheEvictions = Some value }

        [<CustomOperation("flushTotal")>]
        member _.FlushTotal(state: Types.ShardsRecord, value: string) =
            { state with FlushTotal = Some value }

        [<CustomOperation("flushTotalTime")>]
        member _.FlushTotalTime(state: Types.ShardsRecord, value: string) =
            { state with FlushTotalTime = Some value }

        [<CustomOperation("getCurrent")>]
        member _.GetCurrent(state: Types.ShardsRecord, value: string) =
            { state with GetCurrent = Some value }

        [<CustomOperation("getTime")>]
        member _.GetTime(state: Types.ShardsRecord, value: string) =
            { state with GetTime = Some value }

        [<CustomOperation("getTotal")>]
        member _.GetTotal(state: Types.ShardsRecord, value: string) =
            { state with GetTotal = Some value }

        [<CustomOperation("getExistsTime")>]
        member _.GetExistsTime(state: Types.ShardsRecord, value: string) =
            { state with GetExistsTime = Some value }

        [<CustomOperation("getExistsTotal")>]
        member _.GetExistsTotal(state: Types.ShardsRecord, value: string) =
            { state with GetExistsTotal = Some value }

        [<CustomOperation("getMissingTime")>]
        member _.GetMissingTime(state: Types.ShardsRecord, value: string) =
            { state with GetMissingTime = Some value }

        [<CustomOperation("getMissingTotal")>]
        member _.GetMissingTotal(state: Types.ShardsRecord, value: string) =
            { state with GetMissingTotal = Some value }

        [<CustomOperation("indexingDeleteCurrent")>]
        member _.IndexingDeleteCurrent(state: Types.ShardsRecord, value: string) =
            { state with IndexingDeleteCurrent = Some value }

        [<CustomOperation("indexingDeleteTime")>]
        member _.IndexingDeleteTime(state: Types.ShardsRecord, value: string) =
            { state with IndexingDeleteTime = Some value }

        [<CustomOperation("indexingDeleteTotal")>]
        member _.IndexingDeleteTotal(state: Types.ShardsRecord, value: string) =
            { state with IndexingDeleteTotal = Some value }

        [<CustomOperation("indexingIndexCurrent")>]
        member _.IndexingIndexCurrent(state: Types.ShardsRecord, value: string) =
            { state with IndexingIndexCurrent = Some value }

        [<CustomOperation("indexingIndexTime")>]
        member _.IndexingIndexTime(state: Types.ShardsRecord, value: string) =
            { state with IndexingIndexTime = Some value }

        [<CustomOperation("indexingIndexTotal")>]
        member _.IndexingIndexTotal(state: Types.ShardsRecord, value: string) =
            { state with IndexingIndexTotal = Some value }

        [<CustomOperation("indexingIndexFailed")>]
        member _.IndexingIndexFailed(state: Types.ShardsRecord, value: string) =
            { state with IndexingIndexFailed = Some value }

        [<CustomOperation("mergesCurrent")>]
        member _.MergesCurrent(state: Types.ShardsRecord, value: string) =
            { state with MergesCurrent = Some value }

        [<CustomOperation("mergesCurrentDocs")>]
        member _.MergesCurrentDocs(state: Types.ShardsRecord, value: string) =
            { state with MergesCurrentDocs = Some value }

        [<CustomOperation("mergesCurrentSize")>]
        member _.MergesCurrentSize(state: Types.ShardsRecord, value: string) =
            { state with MergesCurrentSize = Some value }

        [<CustomOperation("mergesTotal")>]
        member _.MergesTotal(state: Types.ShardsRecord, value: string) =
            { state with MergesTotal = Some value }

        [<CustomOperation("mergesTotalDocs")>]
        member _.MergesTotalDocs(state: Types.ShardsRecord, value: string) =
            { state with MergesTotalDocs = Some value }

        [<CustomOperation("mergesTotalSize")>]
        member _.MergesTotalSize(state: Types.ShardsRecord, value: string) =
            { state with MergesTotalSize = Some value }

        [<CustomOperation("mergesTotalTime")>]
        member _.MergesTotalTime(state: Types.ShardsRecord, value: string) =
            { state with MergesTotalTime = Some value }

        [<CustomOperation("refreshTotal")>]
        member _.RefreshTotal(state: Types.ShardsRecord, value: string) =
            { state with RefreshTotal = Some value }

        [<CustomOperation("refreshTime")>]
        member _.RefreshTime(state: Types.ShardsRecord, value: string) =
            { state with RefreshTime = Some value }

        [<CustomOperation("refreshExternalTotal")>]
        member _.RefreshExternalTotal(state: Types.ShardsRecord, value: string) =
            { state with RefreshExternalTotal = Some value }

        [<CustomOperation("refreshExternalTime")>]
        member _.RefreshExternalTime(state: Types.ShardsRecord, value: string) =
            { state with RefreshExternalTime = Some value }

        [<CustomOperation("refreshListeners")>]
        member _.RefreshListeners(state: Types.ShardsRecord, value: string) =
            { state with RefreshListeners = Some value }

        [<CustomOperation("searchFetchCurrent")>]
        member _.SearchFetchCurrent(state: Types.ShardsRecord, value: string) =
            { state with SearchFetchCurrent = Some value }

        [<CustomOperation("searchFetchTime")>]
        member _.SearchFetchTime(state: Types.ShardsRecord, value: string) =
            { state with SearchFetchTime = Some value }

        [<CustomOperation("searchFetchTotal")>]
        member _.SearchFetchTotal(state: Types.ShardsRecord, value: string) =
            { state with SearchFetchTotal = Some value }

        [<CustomOperation("searchOpenContexts")>]
        member _.SearchOpenContexts(state: Types.ShardsRecord, value: string) =
            { state with SearchOpenContexts = Some value }

        [<CustomOperation("searchQueryCurrent")>]
        member _.SearchQueryCurrent(state: Types.ShardsRecord, value: string) =
            { state with SearchQueryCurrent = Some value }

        [<CustomOperation("searchQueryTime")>]
        member _.SearchQueryTime(state: Types.ShardsRecord, value: string) =
            { state with SearchQueryTime = Some value }

        [<CustomOperation("searchQueryTotal")>]
        member _.SearchQueryTotal(state: Types.ShardsRecord, value: string) =
            { state with SearchQueryTotal = Some value }

        [<CustomOperation("searchScrollCurrent")>]
        member _.SearchScrollCurrent(state: Types.ShardsRecord, value: string) =
            { state with SearchScrollCurrent = Some value }

        [<CustomOperation("searchScrollTime")>]
        member _.SearchScrollTime(state: Types.ShardsRecord, value: string) =
            { state with SearchScrollTime = Some value }

        [<CustomOperation("searchScrollTotal")>]
        member _.SearchScrollTotal(state: Types.ShardsRecord, value: string) =
            { state with SearchScrollTotal = Some value }

        [<CustomOperation("segmentsCount")>]
        member _.SegmentsCount(state: Types.ShardsRecord, value: string) =
            { state with SegmentsCount = Some value }

        [<CustomOperation("segmentsMemory")>]
        member _.SegmentsMemory(state: Types.ShardsRecord, value: string) =
            { state with SegmentsMemory = Some value }

        [<CustomOperation("segmentsIndexWriterMemory")>]
        member _.SegmentsIndexWriterMemory(state: Types.ShardsRecord, value: string) =
            { state with SegmentsIndexWriterMemory = Some value }

        [<CustomOperation("segmentsVersionMapMemory")>]
        member _.SegmentsVersionMapMemory(state: Types.ShardsRecord, value: string) =
            { state with SegmentsVersionMapMemory = Some value }

        [<CustomOperation("segmentsFixedBitsetMemory")>]
        member _.SegmentsFixedBitsetMemory(state: Types.ShardsRecord, value: string) =
            { state with SegmentsFixedBitsetMemory = Some value }

        [<CustomOperation("seqNoMax")>]
        member _.SeqNoMax(state: Types.ShardsRecord, value: string) =
            { state with SeqNoMax = Some value }

        [<CustomOperation("seqNoLocalCheckpoint")>]
        member _.SeqNoLocalCheckpoint(state: Types.ShardsRecord, value: string) =
            { state with SeqNoLocalCheckpoint = Some value }

        [<CustomOperation("seqNoGlobalCheckpoint")>]
        member _.SeqNoGlobalCheckpoint(state: Types.ShardsRecord, value: string) =
            { state with SeqNoGlobalCheckpoint = Some value }

        [<CustomOperation("warmerCurrent")>]
        member _.WarmerCurrent(state: Types.ShardsRecord, value: string) =
            { state with WarmerCurrent = Some value }

        [<CustomOperation("warmerTotal")>]
        member _.WarmerTotal(state: Types.ShardsRecord, value: string) =
            { state with WarmerTotal = Some value }

        [<CustomOperation("warmerTotalTime")>]
        member _.WarmerTotalTime(state: Types.ShardsRecord, value: string) =
            { state with WarmerTotalTime = Some value }

        [<CustomOperation("pathData")>]
        member _.PathData(state: Types.ShardsRecord, value: string) =
            { state with PathData = Some value }

        [<CustomOperation("pathState")>]
        member _.PathState(state: Types.ShardsRecord, value: string) =
            { state with PathState = Some value }

        [<CustomOperation("bulkTotalOperations")>]
        member _.BulkTotalOperations(state: Types.ShardsRecord, value: string) =
            { state with BulkTotalOperations = Some value }

        [<CustomOperation("bulkTotalTime")>]
        member _.BulkTotalTime(state: Types.ShardsRecord, value: string) =
            { state with BulkTotalTime = Some value }

        [<CustomOperation("bulkTotalSizeInBytes")>]
        member _.BulkTotalSizeInBytes(state: Types.ShardsRecord, value: string) =
            { state with BulkTotalSizeInBytes = Some value }

        [<CustomOperation("bulkAvgTime")>]
        member _.BulkAvgTime(state: Types.ShardsRecord, value: string) =
            { state with BulkAvgTime = Some value }

        [<CustomOperation("bulkAvgSizeInBytes")>]
        member _.BulkAvgSizeInBytes(state: Types.ShardsRecord, value: string) =
            { state with BulkAvgSizeInBytes = Some value }

    let shardsRecord = ShardsRecordBuilder()


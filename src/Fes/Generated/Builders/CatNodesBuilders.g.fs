// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module CatNodesBuilders =

    type NodesRecordBuilder() =
        member _.Yield(_: unit) : Types.NodesRecord =
            {
                Id = None
                Pid = None
                Ip = None
                Port = None
                HttpAddress = None
                Version = None
                Flavor = None
                Type = None
                Build = None
                Jdk = None
                DiskTotal = None
                DiskUsed = None
                DiskAvail = None
                DiskUsedPercent = None
                HeapCurrent = None
                HeapPercent = None
                HeapMax = None
                RamCurrent = None
                RamPercent = None
                RamMax = None
                FileDescCurrent = None
                FileDescPercent = None
                FileDescMax = None
                Cpu = None
                Load1m = None
                Load5m = None
                Load15m = None
                AvailableProcessors = None
                Uptime = None
                NodeRole = None
                Master = None
                Name = None
                CompletionSize = None
                FielddataMemorySize = None
                FielddataEvictions = None
                QueryCacheMemorySize = None
                QueryCacheEvictions = None
                QueryCacheHitCount = None
                QueryCacheMissCount = None
                RequestCacheMemorySize = None
                RequestCacheEvictions = None
                RequestCacheHitCount = None
                RequestCacheMissCount = None
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
                ScriptCompilations = None
                ScriptCacheEvictions = None
                ScriptCompilationLimitTriggered = None
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
                SuggestCurrent = None
                SuggestTime = None
                SuggestTotal = None
                BulkTotalOperations = None
                BulkTotalTime = None
                BulkTotalSizeInBytes = None
                BulkAvgTime = None
                BulkAvgSizeInBytes = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.NodesRecord, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("pid")>]
        member _.Pid(state: Types.NodesRecord, value: string) =
            { state with Pid = Some value }

        [<CustomOperation("ip")>]
        member _.Ip(state: Types.NodesRecord, value: string) =
            { state with Ip = Some value }

        [<CustomOperation("port")>]
        member _.Port(state: Types.NodesRecord, value: string) =
            { state with Port = Some value }

        [<CustomOperation("httpAddress")>]
        member _.HttpAddress(state: Types.NodesRecord, value: string) =
            { state with HttpAddress = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.NodesRecord, value: Types.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("flavor")>]
        member _.Flavor(state: Types.NodesRecord, value: string) =
            { state with Flavor = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.NodesRecord, value: string) =
            { state with Type = Some value }

        [<CustomOperation("build")>]
        member _.Build(state: Types.NodesRecord, value: string) =
            { state with Build = Some value }

        [<CustomOperation("jdk")>]
        member _.Jdk(state: Types.NodesRecord, value: string) =
            { state with Jdk = Some value }

        [<CustomOperation("diskTotal")>]
        member _.DiskTotal(state: Types.NodesRecord, value: Types.ByteSize) =
            { state with DiskTotal = Some value }

        [<CustomOperation("diskUsed")>]
        member _.DiskUsed(state: Types.NodesRecord, value: Types.ByteSize) =
            { state with DiskUsed = Some value }

        [<CustomOperation("diskAvail")>]
        member _.DiskAvail(state: Types.NodesRecord, value: Types.ByteSize) =
            { state with DiskAvail = Some value }

        [<CustomOperation("diskUsedPercent")>]
        member _.DiskUsedPercent(state: Types.NodesRecord, value: Types.Percentage) =
            { state with DiskUsedPercent = Some value }

        [<CustomOperation("heapCurrent")>]
        member _.HeapCurrent(state: Types.NodesRecord, value: string) =
            { state with HeapCurrent = Some value }

        [<CustomOperation("heapPercent")>]
        member _.HeapPercent(state: Types.NodesRecord, value: Types.Percentage) =
            { state with HeapPercent = Some value }

        [<CustomOperation("heapMax")>]
        member _.HeapMax(state: Types.NodesRecord, value: string) =
            { state with HeapMax = Some value }

        [<CustomOperation("ramCurrent")>]
        member _.RamCurrent(state: Types.NodesRecord, value: string) =
            { state with RamCurrent = Some value }

        [<CustomOperation("ramPercent")>]
        member _.RamPercent(state: Types.NodesRecord, value: Types.Percentage) =
            { state with RamPercent = Some value }

        [<CustomOperation("ramMax")>]
        member _.RamMax(state: Types.NodesRecord, value: string) =
            { state with RamMax = Some value }

        [<CustomOperation("fileDescCurrent")>]
        member _.FileDescCurrent(state: Types.NodesRecord, value: string) =
            { state with FileDescCurrent = Some value }

        [<CustomOperation("fileDescPercent")>]
        member _.FileDescPercent(state: Types.NodesRecord, value: Types.Percentage) =
            { state with FileDescPercent = Some value }

        [<CustomOperation("fileDescMax")>]
        member _.FileDescMax(state: Types.NodesRecord, value: string) =
            { state with FileDescMax = Some value }

        [<CustomOperation("cpu")>]
        member _.Cpu(state: Types.NodesRecord, value: string) =
            { state with Cpu = Some value }

        [<CustomOperation("load1m")>]
        member _.Load1m(state: Types.NodesRecord, value: string) =
            { state with Load1m = Some value }

        [<CustomOperation("load5m")>]
        member _.Load5m(state: Types.NodesRecord, value: string) =
            { state with Load5m = Some value }

        [<CustomOperation("load15m")>]
        member _.Load15m(state: Types.NodesRecord, value: string) =
            { state with Load15m = Some value }

        [<CustomOperation("availableProcessors")>]
        member _.AvailableProcessors(state: Types.NodesRecord, value: string) =
            { state with AvailableProcessors = Some value }

        [<CustomOperation("uptime")>]
        member _.Uptime(state: Types.NodesRecord, value: string) =
            { state with Uptime = Some value }

        [<CustomOperation("nodeRole")>]
        member _.NodeRole(state: Types.NodesRecord, value: string) =
            { state with NodeRole = Some value }

        [<CustomOperation("master")>]
        member _.Master(state: Types.NodesRecord, value: string) =
            { state with Master = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Types.NodesRecord, value: Types.Name) =
            { state with Name = Some value }

        [<CustomOperation("completionSize")>]
        member _.CompletionSize(state: Types.NodesRecord, value: string) =
            { state with CompletionSize = Some value }

        [<CustomOperation("fielddataMemorySize")>]
        member _.FielddataMemorySize(state: Types.NodesRecord, value: string) =
            { state with FielddataMemorySize = Some value }

        [<CustomOperation("fielddataEvictions")>]
        member _.FielddataEvictions(state: Types.NodesRecord, value: string) =
            { state with FielddataEvictions = Some value }

        [<CustomOperation("queryCacheMemorySize")>]
        member _.QueryCacheMemorySize(state: Types.NodesRecord, value: string) =
            { state with QueryCacheMemorySize = Some value }

        [<CustomOperation("queryCacheEvictions")>]
        member _.QueryCacheEvictions(state: Types.NodesRecord, value: string) =
            { state with QueryCacheEvictions = Some value }

        [<CustomOperation("queryCacheHitCount")>]
        member _.QueryCacheHitCount(state: Types.NodesRecord, value: string) =
            { state with QueryCacheHitCount = Some value }

        [<CustomOperation("queryCacheMissCount")>]
        member _.QueryCacheMissCount(state: Types.NodesRecord, value: string) =
            { state with QueryCacheMissCount = Some value }

        [<CustomOperation("requestCacheMemorySize")>]
        member _.RequestCacheMemorySize(state: Types.NodesRecord, value: string) =
            { state with RequestCacheMemorySize = Some value }

        [<CustomOperation("requestCacheEvictions")>]
        member _.RequestCacheEvictions(state: Types.NodesRecord, value: string) =
            { state with RequestCacheEvictions = Some value }

        [<CustomOperation("requestCacheHitCount")>]
        member _.RequestCacheHitCount(state: Types.NodesRecord, value: string) =
            { state with RequestCacheHitCount = Some value }

        [<CustomOperation("requestCacheMissCount")>]
        member _.RequestCacheMissCount(state: Types.NodesRecord, value: string) =
            { state with RequestCacheMissCount = Some value }

        [<CustomOperation("flushTotal")>]
        member _.FlushTotal(state: Types.NodesRecord, value: string) =
            { state with FlushTotal = Some value }

        [<CustomOperation("flushTotalTime")>]
        member _.FlushTotalTime(state: Types.NodesRecord, value: string) =
            { state with FlushTotalTime = Some value }

        [<CustomOperation("getCurrent")>]
        member _.GetCurrent(state: Types.NodesRecord, value: string) =
            { state with GetCurrent = Some value }

        [<CustomOperation("getTime")>]
        member _.GetTime(state: Types.NodesRecord, value: string) =
            { state with GetTime = Some value }

        [<CustomOperation("getTotal")>]
        member _.GetTotal(state: Types.NodesRecord, value: string) =
            { state with GetTotal = Some value }

        [<CustomOperation("getExistsTime")>]
        member _.GetExistsTime(state: Types.NodesRecord, value: string) =
            { state with GetExistsTime = Some value }

        [<CustomOperation("getExistsTotal")>]
        member _.GetExistsTotal(state: Types.NodesRecord, value: string) =
            { state with GetExistsTotal = Some value }

        [<CustomOperation("getMissingTime")>]
        member _.GetMissingTime(state: Types.NodesRecord, value: string) =
            { state with GetMissingTime = Some value }

        [<CustomOperation("getMissingTotal")>]
        member _.GetMissingTotal(state: Types.NodesRecord, value: string) =
            { state with GetMissingTotal = Some value }

        [<CustomOperation("indexingDeleteCurrent")>]
        member _.IndexingDeleteCurrent(state: Types.NodesRecord, value: string) =
            { state with IndexingDeleteCurrent = Some value }

        [<CustomOperation("indexingDeleteTime")>]
        member _.IndexingDeleteTime(state: Types.NodesRecord, value: string) =
            { state with IndexingDeleteTime = Some value }

        [<CustomOperation("indexingDeleteTotal")>]
        member _.IndexingDeleteTotal(state: Types.NodesRecord, value: string) =
            { state with IndexingDeleteTotal = Some value }

        [<CustomOperation("indexingIndexCurrent")>]
        member _.IndexingIndexCurrent(state: Types.NodesRecord, value: string) =
            { state with IndexingIndexCurrent = Some value }

        [<CustomOperation("indexingIndexTime")>]
        member _.IndexingIndexTime(state: Types.NodesRecord, value: string) =
            { state with IndexingIndexTime = Some value }

        [<CustomOperation("indexingIndexTotal")>]
        member _.IndexingIndexTotal(state: Types.NodesRecord, value: string) =
            { state with IndexingIndexTotal = Some value }

        [<CustomOperation("indexingIndexFailed")>]
        member _.IndexingIndexFailed(state: Types.NodesRecord, value: string) =
            { state with IndexingIndexFailed = Some value }

        [<CustomOperation("mergesCurrent")>]
        member _.MergesCurrent(state: Types.NodesRecord, value: string) =
            { state with MergesCurrent = Some value }

        [<CustomOperation("mergesCurrentDocs")>]
        member _.MergesCurrentDocs(state: Types.NodesRecord, value: string) =
            { state with MergesCurrentDocs = Some value }

        [<CustomOperation("mergesCurrentSize")>]
        member _.MergesCurrentSize(state: Types.NodesRecord, value: string) =
            { state with MergesCurrentSize = Some value }

        [<CustomOperation("mergesTotal")>]
        member _.MergesTotal(state: Types.NodesRecord, value: string) =
            { state with MergesTotal = Some value }

        [<CustomOperation("mergesTotalDocs")>]
        member _.MergesTotalDocs(state: Types.NodesRecord, value: string) =
            { state with MergesTotalDocs = Some value }

        [<CustomOperation("mergesTotalSize")>]
        member _.MergesTotalSize(state: Types.NodesRecord, value: string) =
            { state with MergesTotalSize = Some value }

        [<CustomOperation("mergesTotalTime")>]
        member _.MergesTotalTime(state: Types.NodesRecord, value: string) =
            { state with MergesTotalTime = Some value }

        [<CustomOperation("refreshTotal")>]
        member _.RefreshTotal(state: Types.NodesRecord, value: string) =
            { state with RefreshTotal = Some value }

        [<CustomOperation("refreshTime")>]
        member _.RefreshTime(state: Types.NodesRecord, value: string) =
            { state with RefreshTime = Some value }

        [<CustomOperation("refreshExternalTotal")>]
        member _.RefreshExternalTotal(state: Types.NodesRecord, value: string) =
            { state with RefreshExternalTotal = Some value }

        [<CustomOperation("refreshExternalTime")>]
        member _.RefreshExternalTime(state: Types.NodesRecord, value: string) =
            { state with RefreshExternalTime = Some value }

        [<CustomOperation("refreshListeners")>]
        member _.RefreshListeners(state: Types.NodesRecord, value: string) =
            { state with RefreshListeners = Some value }

        [<CustomOperation("scriptCompilations")>]
        member _.ScriptCompilations(state: Types.NodesRecord, value: string) =
            { state with ScriptCompilations = Some value }

        [<CustomOperation("scriptCacheEvictions")>]
        member _.ScriptCacheEvictions(state: Types.NodesRecord, value: string) =
            { state with ScriptCacheEvictions = Some value }

        [<CustomOperation("scriptCompilationLimitTriggered")>]
        member _.ScriptCompilationLimitTriggered(state: Types.NodesRecord, value: string) =
            { state with ScriptCompilationLimitTriggered = Some value }

        [<CustomOperation("searchFetchCurrent")>]
        member _.SearchFetchCurrent(state: Types.NodesRecord, value: string) =
            { state with SearchFetchCurrent = Some value }

        [<CustomOperation("searchFetchTime")>]
        member _.SearchFetchTime(state: Types.NodesRecord, value: string) =
            { state with SearchFetchTime = Some value }

        [<CustomOperation("searchFetchTotal")>]
        member _.SearchFetchTotal(state: Types.NodesRecord, value: string) =
            { state with SearchFetchTotal = Some value }

        [<CustomOperation("searchOpenContexts")>]
        member _.SearchOpenContexts(state: Types.NodesRecord, value: string) =
            { state with SearchOpenContexts = Some value }

        [<CustomOperation("searchQueryCurrent")>]
        member _.SearchQueryCurrent(state: Types.NodesRecord, value: string) =
            { state with SearchQueryCurrent = Some value }

        [<CustomOperation("searchQueryTime")>]
        member _.SearchQueryTime(state: Types.NodesRecord, value: string) =
            { state with SearchQueryTime = Some value }

        [<CustomOperation("searchQueryTotal")>]
        member _.SearchQueryTotal(state: Types.NodesRecord, value: string) =
            { state with SearchQueryTotal = Some value }

        [<CustomOperation("searchScrollCurrent")>]
        member _.SearchScrollCurrent(state: Types.NodesRecord, value: string) =
            { state with SearchScrollCurrent = Some value }

        [<CustomOperation("searchScrollTime")>]
        member _.SearchScrollTime(state: Types.NodesRecord, value: string) =
            { state with SearchScrollTime = Some value }

        [<CustomOperation("searchScrollTotal")>]
        member _.SearchScrollTotal(state: Types.NodesRecord, value: string) =
            { state with SearchScrollTotal = Some value }

        [<CustomOperation("segmentsCount")>]
        member _.SegmentsCount(state: Types.NodesRecord, value: string) =
            { state with SegmentsCount = Some value }

        [<CustomOperation("segmentsMemory")>]
        member _.SegmentsMemory(state: Types.NodesRecord, value: string) =
            { state with SegmentsMemory = Some value }

        [<CustomOperation("segmentsIndexWriterMemory")>]
        member _.SegmentsIndexWriterMemory(state: Types.NodesRecord, value: string) =
            { state with SegmentsIndexWriterMemory = Some value }

        [<CustomOperation("segmentsVersionMapMemory")>]
        member _.SegmentsVersionMapMemory(state: Types.NodesRecord, value: string) =
            { state with SegmentsVersionMapMemory = Some value }

        [<CustomOperation("segmentsFixedBitsetMemory")>]
        member _.SegmentsFixedBitsetMemory(state: Types.NodesRecord, value: string) =
            { state with SegmentsFixedBitsetMemory = Some value }

        [<CustomOperation("suggestCurrent")>]
        member _.SuggestCurrent(state: Types.NodesRecord, value: string) =
            { state with SuggestCurrent = Some value }

        [<CustomOperation("suggestTime")>]
        member _.SuggestTime(state: Types.NodesRecord, value: string) =
            { state with SuggestTime = Some value }

        [<CustomOperation("suggestTotal")>]
        member _.SuggestTotal(state: Types.NodesRecord, value: string) =
            { state with SuggestTotal = Some value }

        [<CustomOperation("bulkTotalOperations")>]
        member _.BulkTotalOperations(state: Types.NodesRecord, value: string) =
            { state with BulkTotalOperations = Some value }

        [<CustomOperation("bulkTotalTime")>]
        member _.BulkTotalTime(state: Types.NodesRecord, value: string) =
            { state with BulkTotalTime = Some value }

        [<CustomOperation("bulkTotalSizeInBytes")>]
        member _.BulkTotalSizeInBytes(state: Types.NodesRecord, value: string) =
            { state with BulkTotalSizeInBytes = Some value }

        [<CustomOperation("bulkAvgTime")>]
        member _.BulkAvgTime(state: Types.NodesRecord, value: string) =
            { state with BulkAvgTime = Some value }

        [<CustomOperation("bulkAvgSizeInBytes")>]
        member _.BulkAvgSizeInBytes(state: Types.NodesRecord, value: string) =
            { state with BulkAvgSizeInBytes = Some value }

    let nodesRecord = NodesRecordBuilder()


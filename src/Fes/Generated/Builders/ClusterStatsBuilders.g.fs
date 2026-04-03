// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module ClusterStatsBuilders =

    type CCSStatsBuilder() =
        member _.Yield(_: unit) : CCSStats =
            {
                Clusters = None
                Search = Unchecked.defaultof<_>
                Esql = None
            }

        [<CustomOperation("clusters")>]
        member _.Clusters(state: CCSStats, value: Map<string, ClusterStats.RemoteClusterInfo>) =
            { state with Clusters = Some value }

        [<CustomOperation("search")>]
        member _.Search(state: CCSStats, value: ClusterStats.CCSUsageStats) =
            { state with Search = value }

        [<CustomOperation("esql")>]
        member _.Esql(state: CCSStats, value: ClusterStats.CCSUsageStats) =
            { state with Esql = Some value }

    let cCSStats = CCSStatsBuilder()

    type CCSUsageStatsBuilder() =
        member _.Yield(_: unit) : CCSUsageStats =
            {
                Total = Unchecked.defaultof<_>
                Success = Unchecked.defaultof<_>
                Skipped = Unchecked.defaultof<_>
                Took = Unchecked.defaultof<_>
                TookMrtTrue = None
                TookMrtFalse = None
                RemotesPerSearchMax = Unchecked.defaultof<_>
                RemotesPerSearchAvg = Unchecked.defaultof<_>
                FailureReasons = Unchecked.defaultof<_>
                Features = Unchecked.defaultof<_>
                Clients = Unchecked.defaultof<_>
                Clusters = Unchecked.defaultof<_>
            }

        [<CustomOperation("total")>]
        member _.Total(state: CCSUsageStats, value: Types.Integer) =
            { state with Total = value }

        [<CustomOperation("success")>]
        member _.Success(state: CCSUsageStats, value: Types.Integer) =
            { state with Success = value }

        [<CustomOperation("skipped")>]
        member _.Skipped(state: CCSUsageStats, value: Types.Integer) =
            { state with Skipped = value }

        [<CustomOperation("took")>]
        member _.Took(state: CCSUsageStats, value: ClusterStats.CCSUsageTimeValue) =
            { state with Took = value }

        [<CustomOperation("tookMrtTrue")>]
        member _.TookMrtTrue(state: CCSUsageStats, value: ClusterStats.CCSUsageTimeValue) =
            { state with TookMrtTrue = Some value }

        [<CustomOperation("tookMrtFalse")>]
        member _.TookMrtFalse(state: CCSUsageStats, value: ClusterStats.CCSUsageTimeValue) =
            { state with TookMrtFalse = Some value }

        [<CustomOperation("remotesPerSearchMax")>]
        member _.RemotesPerSearchMax(state: CCSUsageStats, value: Types.Integer) =
            { state with RemotesPerSearchMax = value }

        [<CustomOperation("remotesPerSearchAvg")>]
        member _.RemotesPerSearchAvg(state: CCSUsageStats, value: Types.Double) =
            { state with RemotesPerSearchAvg = value }

        [<CustomOperation("failureReasons")>]
        member _.FailureReasons(state: CCSUsageStats, value: Map<string, Types.Integer>) =
            { state with FailureReasons = value }

        [<CustomOperation("features")>]
        member _.Features(state: CCSUsageStats, value: Map<string, Types.Integer>) =
            { state with Features = value }

        [<CustomOperation("clients")>]
        member _.Clients(state: CCSUsageStats, value: Map<string, Types.Integer>) =
            { state with Clients = value }

        [<CustomOperation("clusters")>]
        member _.Clusters(state: CCSUsageStats, value: Map<string, ClusterStats.CCSUsageClusterStats>) =
            { state with Clusters = value }

    let cCSUsageStats = CCSUsageStatsBuilder()

    type ClusterFileSystemBuilder() =
        member _.Yield(_: unit) : ClusterFileSystem =
            {
                Path = None
                Mount = None
                Type = None
                AvailableInBytes = None
                Available = None
                FreeInBytes = None
                Free = None
                TotalInBytes = None
                Total = None
                LowWatermarkFreeSpace = None
                LowWatermarkFreeSpaceInBytes = None
                HighWatermarkFreeSpace = None
                HighWatermarkFreeSpaceInBytes = None
                FloodStageFreeSpace = None
                FloodStageFreeSpaceInBytes = None
                FrozenFloodStageFreeSpace = None
                FrozenFloodStageFreeSpaceInBytes = None
            }

        [<CustomOperation("path")>]
        member _.Path(state: ClusterFileSystem, value: string) =
            { state with Path = Some value }

        [<CustomOperation("mount")>]
        member _.Mount(state: ClusterFileSystem, value: string) =
            { state with Mount = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: ClusterFileSystem, value: string) =
            { state with Type = Some value }

        [<CustomOperation("availableInBytes")>]
        member _.AvailableInBytes(state: ClusterFileSystem, value: Types.Long) =
            { state with AvailableInBytes = Some value }

        [<CustomOperation("available")>]
        member _.Available(state: ClusterFileSystem, value: Types.ByteSize) =
            { state with Available = Some value }

        [<CustomOperation("freeInBytes")>]
        member _.FreeInBytes(state: ClusterFileSystem, value: Types.Long) =
            { state with FreeInBytes = Some value }

        [<CustomOperation("free")>]
        member _.Free(state: ClusterFileSystem, value: Types.ByteSize) =
            { state with Free = Some value }

        [<CustomOperation("totalInBytes")>]
        member _.TotalInBytes(state: ClusterFileSystem, value: Types.Long) =
            { state with TotalInBytes = Some value }

        [<CustomOperation("total")>]
        member _.Total(state: ClusterFileSystem, value: Types.ByteSize) =
            { state with Total = Some value }

        [<CustomOperation("lowWatermarkFreeSpace")>]
        member _.LowWatermarkFreeSpace(state: ClusterFileSystem, value: Types.ByteSize) =
            { state with LowWatermarkFreeSpace = Some value }

        [<CustomOperation("lowWatermarkFreeSpaceInBytes")>]
        member _.LowWatermarkFreeSpaceInBytes(state: ClusterFileSystem, value: Types.Long) =
            { state with LowWatermarkFreeSpaceInBytes = Some value }

        [<CustomOperation("highWatermarkFreeSpace")>]
        member _.HighWatermarkFreeSpace(state: ClusterFileSystem, value: Types.ByteSize) =
            { state with HighWatermarkFreeSpace = Some value }

        [<CustomOperation("highWatermarkFreeSpaceInBytes")>]
        member _.HighWatermarkFreeSpaceInBytes(state: ClusterFileSystem, value: Types.Long) =
            { state with HighWatermarkFreeSpaceInBytes = Some value }

        [<CustomOperation("floodStageFreeSpace")>]
        member _.FloodStageFreeSpace(state: ClusterFileSystem, value: Types.ByteSize) =
            { state with FloodStageFreeSpace = Some value }

        [<CustomOperation("floodStageFreeSpaceInBytes")>]
        member _.FloodStageFreeSpaceInBytes(state: ClusterFileSystem, value: Types.Long) =
            { state with FloodStageFreeSpaceInBytes = Some value }

        [<CustomOperation("frozenFloodStageFreeSpace")>]
        member _.FrozenFloodStageFreeSpace(state: ClusterFileSystem, value: Types.ByteSize) =
            { state with FrozenFloodStageFreeSpace = Some value }

        [<CustomOperation("frozenFloodStageFreeSpaceInBytes")>]
        member _.FrozenFloodStageFreeSpaceInBytes(state: ClusterFileSystem, value: Types.Long) =
            { state with FrozenFloodStageFreeSpaceInBytes = Some value }

    let clusterFileSystem = ClusterFileSystemBuilder()

    type ClusterIndicesBuilder() =
        member _.Yield(_: unit) : ClusterIndices =
            {
                Analysis = None
                Completion = Unchecked.defaultof<_>
                Count = Unchecked.defaultof<_>
                Docs = Unchecked.defaultof<_>
                Fielddata = Unchecked.defaultof<_>
                QueryCache = Unchecked.defaultof<_>
                Search = Unchecked.defaultof<_>
                Segments = Unchecked.defaultof<_>
                Shards = Unchecked.defaultof<_>
                Store = Unchecked.defaultof<_>
                Mappings = None
                Versions = None
                DenseVector = Unchecked.defaultof<_>
                SparseVector = Unchecked.defaultof<_>
            }

        [<CustomOperation("analysis")>]
        member _.Analysis(state: ClusterIndices, value: ClusterStats.CharFilterTypes) =
            { state with Analysis = Some value }

        [<CustomOperation("completion")>]
        member _.Completion(state: ClusterIndices, value: Types.CompletionStats) =
            { state with Completion = value }

        [<CustomOperation("count")>]
        member _.Count(state: ClusterIndices, value: Types.Long) =
            { state with Count = value }

        [<CustomOperation("docs")>]
        member _.Docs(state: ClusterIndices, value: Types.DocStats) =
            { state with Docs = value }

        [<CustomOperation("fielddata")>]
        member _.Fielddata(state: ClusterIndices, value: Types.FielddataStats) =
            { state with Fielddata = value }

        [<CustomOperation("queryCache")>]
        member _.QueryCache(state: ClusterIndices, value: Types.QueryCacheStats) =
            { state with QueryCache = value }

        [<CustomOperation("search")>]
        member _.Search(state: ClusterIndices, value: ClusterStats.SearchUsageStats) =
            { state with Search = value }

        [<CustomOperation("segments")>]
        member _.Segments(state: ClusterIndices, value: Types.SegmentsStats) =
            { state with Segments = value }

        [<CustomOperation("shards")>]
        member _.Shards(state: ClusterIndices, value: ClusterStats.ClusterIndicesShards) =
            { state with Shards = value }

        [<CustomOperation("store")>]
        member _.Store(state: ClusterIndices, value: Types.StoreStats) =
            { state with Store = value }

        [<CustomOperation("mappings")>]
        member _.Mappings(state: ClusterIndices, value: ClusterStats.FieldTypesMappings) =
            { state with Mappings = Some value }

        [<CustomOperation("versions")>]
        member _.Versions(state: ClusterIndices, value: ClusterStats.IndicesVersions list) =
            { state with Versions = Some value }

        [<CustomOperation("denseVector")>]
        member _.DenseVector(state: ClusterIndices, value: ClusterStats.DenseVectorStats) =
            { state with DenseVector = value }

        [<CustomOperation("sparseVector")>]
        member _.SparseVector(state: ClusterIndices, value: ClusterStats.SparseVectorStats) =
            { state with SparseVector = value }

    let clusterIndices = ClusterIndicesBuilder()

    type ClusterIndicesShardsBuilder() =
        member _.Yield(_: unit) : ClusterIndicesShards =
            {
                Index = None
                Primaries = None
                Replication = None
                Total = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: ClusterIndicesShards, value: ClusterStats.ClusterIndicesShardsIndex) =
            { state with Index = Some value }

        [<CustomOperation("primaries")>]
        member _.Primaries(state: ClusterIndicesShards, value: Types.Double) =
            { state with Primaries = Some value }

        [<CustomOperation("replication")>]
        member _.Replication(state: ClusterIndicesShards, value: Types.Double) =
            { state with Replication = Some value }

        [<CustomOperation("total")>]
        member _.Total(state: ClusterIndicesShards, value: Types.Double) =
            { state with Total = Some value }

    let clusterIndicesShards = ClusterIndicesShardsBuilder()

    type ClusterJvmMemoryBuilder() =
        member _.Yield(_: unit) : ClusterJvmMemory =
            {
                HeapMaxInBytes = Unchecked.defaultof<_>
                HeapMax = None
                HeapUsedInBytes = Unchecked.defaultof<_>
                HeapUsed = None
            }

        [<CustomOperation("heapMaxInBytes")>]
        member _.HeapMaxInBytes(state: ClusterJvmMemory, value: Types.Long) =
            { state with HeapMaxInBytes = value }

        [<CustomOperation("heapMax")>]
        member _.HeapMax(state: ClusterJvmMemory, value: Types.ByteSize) =
            { state with HeapMax = Some value }

        [<CustomOperation("heapUsedInBytes")>]
        member _.HeapUsedInBytes(state: ClusterJvmMemory, value: Types.Long) =
            { state with HeapUsedInBytes = value }

        [<CustomOperation("heapUsed")>]
        member _.HeapUsed(state: ClusterJvmMemory, value: Types.ByteSize) =
            { state with HeapUsed = Some value }

    let clusterJvmMemory = ClusterJvmMemoryBuilder()

    type ClusterNodeCountBuilder() =
        member _.Yield(_: unit) : ClusterNodeCount =
            {
                Total = Unchecked.defaultof<_>
                CoordinatingOnly = None
                Data = None
                DataCold = None
                DataContent = None
                DataFrozen = None
                DataHot = None
                DataWarm = None
                Index = None
                Ingest = None
                Master = None
                Ml = None
                RemoteClusterClient = None
                Search = None
                Transform = None
                VotingOnly = None
            }

        [<CustomOperation("total")>]
        member _.Total(state: ClusterNodeCount, value: Types.Integer) =
            { state with Total = value }

        [<CustomOperation("coordinatingOnly")>]
        member _.CoordinatingOnly(state: ClusterNodeCount, value: Types.Integer) =
            { state with CoordinatingOnly = Some value }

        [<CustomOperation("data")>]
        member _.Data(state: ClusterNodeCount, value: Types.Integer) =
            { state with Data = Some value }

        [<CustomOperation("dataCold")>]
        member _.DataCold(state: ClusterNodeCount, value: Types.Integer) =
            { state with DataCold = Some value }

        [<CustomOperation("dataContent")>]
        member _.DataContent(state: ClusterNodeCount, value: Types.Integer) =
            { state with DataContent = Some value }

        [<CustomOperation("dataFrozen")>]
        member _.DataFrozen(state: ClusterNodeCount, value: Types.Integer) =
            { state with DataFrozen = Some value }

        [<CustomOperation("dataHot")>]
        member _.DataHot(state: ClusterNodeCount, value: Types.Integer) =
            { state with DataHot = Some value }

        [<CustomOperation("dataWarm")>]
        member _.DataWarm(state: ClusterNodeCount, value: Types.Integer) =
            { state with DataWarm = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: ClusterNodeCount, value: Types.Integer) =
            { state with Index = Some value }

        [<CustomOperation("ingest")>]
        member _.Ingest(state: ClusterNodeCount, value: Types.Integer) =
            { state with Ingest = Some value }

        [<CustomOperation("master")>]
        member _.Master(state: ClusterNodeCount, value: Types.Integer) =
            { state with Master = Some value }

        [<CustomOperation("ml")>]
        member _.Ml(state: ClusterNodeCount, value: Types.Integer) =
            { state with Ml = Some value }

        [<CustomOperation("remoteClusterClient")>]
        member _.RemoteClusterClient(state: ClusterNodeCount, value: Types.Integer) =
            { state with RemoteClusterClient = Some value }

        [<CustomOperation("search")>]
        member _.Search(state: ClusterNodeCount, value: Types.Integer) =
            { state with Search = Some value }

        [<CustomOperation("transform")>]
        member _.Transform(state: ClusterNodeCount, value: Types.Integer) =
            { state with Transform = Some value }

        [<CustomOperation("votingOnly")>]
        member _.VotingOnly(state: ClusterNodeCount, value: Types.Integer) =
            { state with VotingOnly = Some value }

    let clusterNodeCount = ClusterNodeCountBuilder()

    type DenseVectorOffHeapStatsBuilder() =
        member _.Yield(_: unit) : DenseVectorOffHeapStats =
            {
                TotalSizeBytes = Unchecked.defaultof<_>
                TotalSize = None
                TotalVebSizeBytes = Unchecked.defaultof<_>
                TotalVebSize = None
                TotalVecSizeBytes = Unchecked.defaultof<_>
                TotalVecSize = None
                TotalVeqSizeBytes = Unchecked.defaultof<_>
                TotalVeqSize = None
                TotalVexSizeBytes = Unchecked.defaultof<_>
                TotalVexSize = None
                TotalCenifSizeBytes = Unchecked.defaultof<_>
                TotalCenifSize = None
                TotalClivfSizeBytes = Unchecked.defaultof<_>
                TotalClivfSize = None
                Fielddata = None
            }

        [<CustomOperation("totalSizeBytes")>]
        member _.TotalSizeBytes(state: DenseVectorOffHeapStats, value: Types.Long) =
            { state with TotalSizeBytes = value }

        [<CustomOperation("totalSize")>]
        member _.TotalSize(state: DenseVectorOffHeapStats, value: Types.ByteSize) =
            { state with TotalSize = Some value }

        [<CustomOperation("totalVebSizeBytes")>]
        member _.TotalVebSizeBytes(state: DenseVectorOffHeapStats, value: Types.Long) =
            { state with TotalVebSizeBytes = value }

        [<CustomOperation("totalVebSize")>]
        member _.TotalVebSize(state: DenseVectorOffHeapStats, value: Types.ByteSize) =
            { state with TotalVebSize = Some value }

        [<CustomOperation("totalVecSizeBytes")>]
        member _.TotalVecSizeBytes(state: DenseVectorOffHeapStats, value: Types.Long) =
            { state with TotalVecSizeBytes = value }

        [<CustomOperation("totalVecSize")>]
        member _.TotalVecSize(state: DenseVectorOffHeapStats, value: Types.ByteSize) =
            { state with TotalVecSize = Some value }

        [<CustomOperation("totalVeqSizeBytes")>]
        member _.TotalVeqSizeBytes(state: DenseVectorOffHeapStats, value: Types.Long) =
            { state with TotalVeqSizeBytes = value }

        [<CustomOperation("totalVeqSize")>]
        member _.TotalVeqSize(state: DenseVectorOffHeapStats, value: Types.ByteSize) =
            { state with TotalVeqSize = Some value }

        [<CustomOperation("totalVexSizeBytes")>]
        member _.TotalVexSizeBytes(state: DenseVectorOffHeapStats, value: Types.Long) =
            { state with TotalVexSizeBytes = value }

        [<CustomOperation("totalVexSize")>]
        member _.TotalVexSize(state: DenseVectorOffHeapStats, value: Types.ByteSize) =
            { state with TotalVexSize = Some value }

        [<CustomOperation("totalCenifSizeBytes")>]
        member _.TotalCenifSizeBytes(state: DenseVectorOffHeapStats, value: Types.Long) =
            { state with TotalCenifSizeBytes = value }

        [<CustomOperation("totalCenifSize")>]
        member _.TotalCenifSize(state: DenseVectorOffHeapStats, value: Types.ByteSize) =
            { state with TotalCenifSize = Some value }

        [<CustomOperation("totalClivfSizeBytes")>]
        member _.TotalClivfSizeBytes(state: DenseVectorOffHeapStats, value: Types.Long) =
            { state with TotalClivfSizeBytes = value }

        [<CustomOperation("totalClivfSize")>]
        member _.TotalClivfSize(state: DenseVectorOffHeapStats, value: Types.ByteSize) =
            { state with TotalClivfSize = Some value }

        [<CustomOperation("fielddata")>]
        member _.Fielddata(state: DenseVectorOffHeapStats, value: Map<string, Map<string, Types.Long>>) =
            { state with Fielddata = Some value }

    let denseVectorOffHeapStats = DenseVectorOffHeapStatsBuilder()

    type ExtendedSearchUsageBuilder() =
        member _.Yield(_: unit) : ExtendedSearchUsage =
            {
                Retrievers = None
                Section = None
            }

        [<CustomOperation("retrievers")>]
        member _.Retrievers(state: ExtendedSearchUsage, value: ClusterStats.ExtendedRetrieversSearchUsage) =
            { state with Retrievers = Some value }

        [<CustomOperation("section")>]
        member _.Section(state: ExtendedSearchUsage, value: ClusterStats.ExtendedSectionSearchUsage) =
            { state with Section = Some value }

    let extendedSearchUsage = ExtendedSearchUsageBuilder()

    type FieldTypesBuilder() =
        member _.Yield(_: unit) : FieldTypes =
            {
                Name = Unchecked.defaultof<_>
                Count = Unchecked.defaultof<_>
                IndexCount = Unchecked.defaultof<_>
                IndexedVectorCount = None
                IndexedVectorDimMax = None
                IndexedVectorDimMin = None
                ScriptCount = None
                VectorIndexTypeCount = None
                VectorSimilarityTypeCount = None
                VectorElementTypeCount = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: FieldTypes, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("count")>]
        member _.Count(state: FieldTypes, value: Types.Integer) =
            { state with Count = value }

        [<CustomOperation("indexCount")>]
        member _.IndexCount(state: FieldTypes, value: Types.Integer) =
            { state with IndexCount = value }

        [<CustomOperation("indexedVectorCount")>]
        member _.IndexedVectorCount(state: FieldTypes, value: Types.Integer) =
            { state with IndexedVectorCount = Some value }

        [<CustomOperation("indexedVectorDimMax")>]
        member _.IndexedVectorDimMax(state: FieldTypes, value: Types.Integer) =
            { state with IndexedVectorDimMax = Some value }

        [<CustomOperation("indexedVectorDimMin")>]
        member _.IndexedVectorDimMin(state: FieldTypes, value: Types.Integer) =
            { state with IndexedVectorDimMin = Some value }

        [<CustomOperation("scriptCount")>]
        member _.ScriptCount(state: FieldTypes, value: Types.Integer) =
            { state with ScriptCount = Some value }

        [<CustomOperation("vectorIndexTypeCount")>]
        member _.VectorIndexTypeCount(state: FieldTypes, value: Map<Types.Name, Types.Integer>) =
            { state with VectorIndexTypeCount = Some value }

        [<CustomOperation("vectorSimilarityTypeCount")>]
        member _.VectorSimilarityTypeCount(state: FieldTypes, value: Map<Types.Name, Types.Integer>) =
            { state with VectorSimilarityTypeCount = Some value }

        [<CustomOperation("vectorElementTypeCount")>]
        member _.VectorElementTypeCount(state: FieldTypes, value: Map<Types.Name, Types.Integer>) =
            { state with VectorElementTypeCount = Some value }

    let fieldTypes = FieldTypesBuilder()

    type FieldTypesMappingsBuilder() =
        member _.Yield(_: unit) : FieldTypesMappings =
            {
                FieldTypes = Unchecked.defaultof<_>
                RuntimeFieldTypes = Unchecked.defaultof<_>
                TotalFieldCount = None
                TotalDeduplicatedFieldCount = None
                TotalDeduplicatedMappingSize = None
                TotalDeduplicatedMappingSizeInBytes = None
                SourceModes = Unchecked.defaultof<_>
            }

        [<CustomOperation("fieldTypes")>]
        member _.FieldTypes(state: FieldTypesMappings, value: ClusterStats.FieldTypes list) =
            { state with FieldTypes = value }

        [<CustomOperation("runtimeFieldTypes")>]
        member _.RuntimeFieldTypes(state: FieldTypesMappings, value: ClusterStats.RuntimeFieldTypes list) =
            { state with RuntimeFieldTypes = value }

        [<CustomOperation("totalFieldCount")>]
        member _.TotalFieldCount(state: FieldTypesMappings, value: Types.Long) =
            { state with TotalFieldCount = Some value }

        [<CustomOperation("totalDeduplicatedFieldCount")>]
        member _.TotalDeduplicatedFieldCount(state: FieldTypesMappings, value: Types.Long) =
            { state with TotalDeduplicatedFieldCount = Some value }

        [<CustomOperation("totalDeduplicatedMappingSize")>]
        member _.TotalDeduplicatedMappingSize(state: FieldTypesMappings, value: Types.ByteSize) =
            { state with TotalDeduplicatedMappingSize = Some value }

        [<CustomOperation("totalDeduplicatedMappingSizeInBytes")>]
        member _.TotalDeduplicatedMappingSizeInBytes(state: FieldTypesMappings, value: Types.Long) =
            { state with TotalDeduplicatedMappingSizeInBytes = Some value }

        [<CustomOperation("sourceModes")>]
        member _.SourceModes(state: FieldTypesMappings, value: Map<Types.Name, Types.Integer>) =
            { state with SourceModes = value }

    let fieldTypesMappings = FieldTypesMappingsBuilder()

    type OperatingSystemMemoryInfoBuilder() =
        member _.Yield(_: unit) : OperatingSystemMemoryInfo =
            {
                AdjustedTotalInBytes = None
                AdjustedTotal = None
                FreeInBytes = Unchecked.defaultof<_>
                Free = None
                FreePercent = Unchecked.defaultof<_>
                TotalInBytes = Unchecked.defaultof<_>
                Total = None
                UsedInBytes = Unchecked.defaultof<_>
                Used = None
                UsedPercent = Unchecked.defaultof<_>
            }

        [<CustomOperation("adjustedTotalInBytes")>]
        member _.AdjustedTotalInBytes(state: OperatingSystemMemoryInfo, value: Types.Long) =
            { state with AdjustedTotalInBytes = Some value }

        [<CustomOperation("adjustedTotal")>]
        member _.AdjustedTotal(state: OperatingSystemMemoryInfo, value: Types.ByteSize) =
            { state with AdjustedTotal = Some value }

        [<CustomOperation("freeInBytes")>]
        member _.FreeInBytes(state: OperatingSystemMemoryInfo, value: Types.Long) =
            { state with FreeInBytes = value }

        [<CustomOperation("free")>]
        member _.Free(state: OperatingSystemMemoryInfo, value: Types.ByteSize) =
            { state with Free = Some value }

        [<CustomOperation("freePercent")>]
        member _.FreePercent(state: OperatingSystemMemoryInfo, value: Types.Integer) =
            { state with FreePercent = value }

        [<CustomOperation("totalInBytes")>]
        member _.TotalInBytes(state: OperatingSystemMemoryInfo, value: Types.Long) =
            { state with TotalInBytes = value }

        [<CustomOperation("total")>]
        member _.Total(state: OperatingSystemMemoryInfo, value: Types.ByteSize) =
            { state with Total = Some value }

        [<CustomOperation("usedInBytes")>]
        member _.UsedInBytes(state: OperatingSystemMemoryInfo, value: Types.Long) =
            { state with UsedInBytes = value }

        [<CustomOperation("used")>]
        member _.Used(state: OperatingSystemMemoryInfo, value: Types.ByteSize) =
            { state with Used = Some value }

        [<CustomOperation("usedPercent")>]
        member _.UsedPercent(state: OperatingSystemMemoryInfo, value: Types.Integer) =
            { state with UsedPercent = value }

    let operatingSystemMemoryInfo = OperatingSystemMemoryInfoBuilder()

    type RemoteClusterInfoBuilder() =
        member _.Yield(_: unit) : RemoteClusterInfo =
            {
                ClusterUuid = Unchecked.defaultof<_>
                Mode = Unchecked.defaultof<_>
                SkipUnavailable = Unchecked.defaultof<_>
                TransportCompress = Unchecked.defaultof<_>
                Status = Unchecked.defaultof<_>
                Version = Unchecked.defaultof<_>
                NodesCount = Unchecked.defaultof<_>
                ShardsCount = Unchecked.defaultof<_>
                IndicesCount = Unchecked.defaultof<_>
                IndicesTotalSizeInBytes = Unchecked.defaultof<_>
                IndicesTotalSize = None
                MaxHeapInBytes = Unchecked.defaultof<_>
                MaxHeap = None
                MemTotalInBytes = Unchecked.defaultof<_>
                MemTotal = None
            }

        [<CustomOperation("clusterUuid")>]
        member _.ClusterUuid(state: RemoteClusterInfo, value: string) =
            { state with ClusterUuid = value }

        [<CustomOperation("mode")>]
        member _.Mode(state: RemoteClusterInfo, value: string) =
            { state with Mode = value }

        [<CustomOperation("skipUnavailable")>]
        member _.SkipUnavailable(state: RemoteClusterInfo, value: bool) =
            { state with SkipUnavailable = value }

        [<CustomOperation("transportCompress")>]
        member _.TransportCompress(state: RemoteClusterInfo, value: string) =
            { state with TransportCompress = value }

        [<CustomOperation("status")>]
        member _.Status(state: RemoteClusterInfo, value: Types.HealthStatus) =
            { state with Status = value }

        [<CustomOperation("version")>]
        member _.Version(state: RemoteClusterInfo, value: Types.VersionString list) =
            { state with Version = value }

        [<CustomOperation("nodesCount")>]
        member _.NodesCount(state: RemoteClusterInfo, value: Types.Integer) =
            { state with NodesCount = value }

        [<CustomOperation("shardsCount")>]
        member _.ShardsCount(state: RemoteClusterInfo, value: Types.Integer) =
            { state with ShardsCount = value }

        [<CustomOperation("indicesCount")>]
        member _.IndicesCount(state: RemoteClusterInfo, value: Types.Integer) =
            { state with IndicesCount = value }

        [<CustomOperation("indicesTotalSizeInBytes")>]
        member _.IndicesTotalSizeInBytes(state: RemoteClusterInfo, value: Types.Long) =
            { state with IndicesTotalSizeInBytes = value }

        [<CustomOperation("indicesTotalSize")>]
        member _.IndicesTotalSize(state: RemoteClusterInfo, value: string) =
            { state with IndicesTotalSize = Some value }

        [<CustomOperation("maxHeapInBytes")>]
        member _.MaxHeapInBytes(state: RemoteClusterInfo, value: Types.Long) =
            { state with MaxHeapInBytes = value }

        [<CustomOperation("maxHeap")>]
        member _.MaxHeap(state: RemoteClusterInfo, value: string) =
            { state with MaxHeap = Some value }

        [<CustomOperation("memTotalInBytes")>]
        member _.MemTotalInBytes(state: RemoteClusterInfo, value: Types.Long) =
            { state with MemTotalInBytes = value }

        [<CustomOperation("memTotal")>]
        member _.MemTotal(state: RemoteClusterInfo, value: string) =
            { state with MemTotal = Some value }

    let remoteClusterInfo = RemoteClusterInfoBuilder()


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module NodesTypesBuilders =

    type AdaptiveSelectionBuilder() =
        member _.Yield(_: unit) : AdaptiveSelection =
            {
                AvgQueueSize = None
                AvgResponseTime = None
                AvgResponseTimeNs = None
                AvgServiceTime = None
                AvgServiceTimeNs = None
                OutgoingSearches = None
                Rank = None
            }

        [<CustomOperation("avgQueueSize")>]
        member _.AvgQueueSize(state: AdaptiveSelection, value: CoreTypes.Long) =
            { state with AvgQueueSize = Some value }

        [<CustomOperation("avgResponseTime")>]
        member _.AvgResponseTime(state: AdaptiveSelection, value: CoreTypes.Duration) =
            { state with AvgResponseTime = Some value }

        [<CustomOperation("avgResponseTimeNs")>]
        member _.AvgResponseTimeNs(state: AdaptiveSelection, value: CoreTypes.Long) =
            { state with AvgResponseTimeNs = Some value }

        [<CustomOperation("avgServiceTime")>]
        member _.AvgServiceTime(state: AdaptiveSelection, value: CoreTypes.Duration) =
            { state with AvgServiceTime = Some value }

        [<CustomOperation("avgServiceTimeNs")>]
        member _.AvgServiceTimeNs(state: AdaptiveSelection, value: CoreTypes.Long) =
            { state with AvgServiceTimeNs = Some value }

        [<CustomOperation("outgoingSearches")>]
        member _.OutgoingSearches(state: AdaptiveSelection, value: CoreTypes.Long) =
            { state with OutgoingSearches = Some value }

        [<CustomOperation("rank")>]
        member _.Rank(state: AdaptiveSelection, value: string) =
            { state with Rank = Some value }

    let adaptiveSelection = AdaptiveSelectionBuilder()

    type BreakerBuilder() =
        member _.Yield(_: unit) : Breaker =
            {
                EstimatedSize = None
                EstimatedSizeInBytes = None
                LimitSize = None
                LimitSizeInBytes = None
                Overhead = None
                Tripped = None
            }

        [<CustomOperation("estimatedSize")>]
        member _.EstimatedSize(state: Breaker, value: string) =
            { state with EstimatedSize = Some value }

        [<CustomOperation("estimatedSizeInBytes")>]
        member _.EstimatedSizeInBytes(state: Breaker, value: CoreTypes.Long) =
            { state with EstimatedSizeInBytes = Some value }

        [<CustomOperation("limitSize")>]
        member _.LimitSize(state: Breaker, value: string) =
            { state with LimitSize = Some value }

        [<CustomOperation("limitSizeInBytes")>]
        member _.LimitSizeInBytes(state: Breaker, value: CoreTypes.Long) =
            { state with LimitSizeInBytes = Some value }

        [<CustomOperation("overhead")>]
        member _.Overhead(state: Breaker, value: CoreTypes.Float) =
            { state with Overhead = Some value }

        [<CustomOperation("tripped")>]
        member _.Tripped(state: Breaker, value: CoreTypes.Float) =
            { state with Tripped = Some value }

    let breaker = BreakerBuilder()

    type CgroupBuilder() =
        member _.Yield(_: unit) : Cgroup =
            {
                Cpuacct = None
                Cpu = None
                Memory = None
            }

        [<CustomOperation("cpuacct")>]
        member _.Cpuacct(state: Cgroup, value: NodesTypes.CpuAcct) =
            { state with Cpuacct = Some value }

        [<CustomOperation("cpu")>]
        member _.Cpu(state: Cgroup, value: NodesTypes.CgroupCpu) =
            { state with Cpu = Some value }

        [<CustomOperation("memory")>]
        member _.Memory(state: Cgroup, value: NodesTypes.CgroupMemory) =
            { state with Memory = Some value }

    let cgroup = CgroupBuilder()

    type CgroupCpuBuilder() =
        member _.Yield(_: unit) : CgroupCpu =
            {
                ControlGroup = None
                CfsPeriodMicros = None
                CfsQuotaMicros = None
                Stat = None
            }

        [<CustomOperation("controlGroup")>]
        member _.ControlGroup(state: CgroupCpu, value: string) =
            { state with ControlGroup = Some value }

        [<CustomOperation("cfsPeriodMicros")>]
        member _.CfsPeriodMicros(state: CgroupCpu, value: CoreTypes.Integer) =
            { state with CfsPeriodMicros = Some value }

        [<CustomOperation("cfsQuotaMicros")>]
        member _.CfsQuotaMicros(state: CgroupCpu, value: CoreTypes.Integer) =
            { state with CfsQuotaMicros = Some value }

        [<CustomOperation("stat")>]
        member _.Stat(state: CgroupCpu, value: NodesTypes.CgroupCpuStat) =
            { state with Stat = Some value }

    let cgroupCpu = CgroupCpuBuilder()

    type CgroupCpuStatBuilder() =
        member _.Yield(_: unit) : CgroupCpuStat =
            {
                NumberOfElapsedPeriods = None
                NumberOfTimesThrottled = None
                TimeThrottledNanos = None
            }

        [<CustomOperation("numberOfElapsedPeriods")>]
        member _.NumberOfElapsedPeriods(state: CgroupCpuStat, value: CoreTypes.Long) =
            { state with NumberOfElapsedPeriods = Some value }

        [<CustomOperation("numberOfTimesThrottled")>]
        member _.NumberOfTimesThrottled(state: CgroupCpuStat, value: CoreTypes.Long) =
            { state with NumberOfTimesThrottled = Some value }

        [<CustomOperation("timeThrottledNanos")>]
        member _.TimeThrottledNanos(state: CgroupCpuStat, value: CoreTypes.DurationValue<CoreTypes.UnitNanos>) =
            { state with TimeThrottledNanos = Some value }

    let cgroupCpuStat = CgroupCpuStatBuilder()

    type CgroupMemoryBuilder() =
        member _.Yield(_: unit) : CgroupMemory =
            {
                ControlGroup = None
                LimitInBytes = None
                UsageInBytes = None
            }

        [<CustomOperation("controlGroup")>]
        member _.ControlGroup(state: CgroupMemory, value: string) =
            { state with ControlGroup = Some value }

        [<CustomOperation("limitInBytes")>]
        member _.LimitInBytes(state: CgroupMemory, value: string) =
            { state with LimitInBytes = Some value }

        [<CustomOperation("usageInBytes")>]
        member _.UsageInBytes(state: CgroupMemory, value: string) =
            { state with UsageInBytes = Some value }

    let cgroupMemory = CgroupMemoryBuilder()

    type ClientBuilder() =
        member _.Yield(_: unit) : Client =
            {
                Id = None
                Agent = None
                LocalAddress = None
                RemoteAddress = None
                LastUri = None
                OpenedTimeMillis = None
                ClosedTimeMillis = None
                LastRequestTimeMillis = None
                RequestCount = None
                RequestSizeBytes = None
                XOpaqueId = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Client, value: CoreTypes.Long) =
            { state with Id = Some value }

        [<CustomOperation("agent")>]
        member _.Agent(state: Client, value: string) =
            { state with Agent = Some value }

        [<CustomOperation("localAddress")>]
        member _.LocalAddress(state: Client, value: string) =
            { state with LocalAddress = Some value }

        [<CustomOperation("remoteAddress")>]
        member _.RemoteAddress(state: Client, value: string) =
            { state with RemoteAddress = Some value }

        [<CustomOperation("lastUri")>]
        member _.LastUri(state: Client, value: string) =
            { state with LastUri = Some value }

        [<CustomOperation("openedTimeMillis")>]
        member _.OpenedTimeMillis(state: Client, value: CoreTypes.Long) =
            { state with OpenedTimeMillis = Some value }

        [<CustomOperation("closedTimeMillis")>]
        member _.ClosedTimeMillis(state: Client, value: CoreTypes.Long) =
            { state with ClosedTimeMillis = Some value }

        [<CustomOperation("lastRequestTimeMillis")>]
        member _.LastRequestTimeMillis(state: Client, value: CoreTypes.Long) =
            { state with LastRequestTimeMillis = Some value }

        [<CustomOperation("requestCount")>]
        member _.RequestCount(state: Client, value: CoreTypes.Long) =
            { state with RequestCount = Some value }

        [<CustomOperation("requestSizeBytes")>]
        member _.RequestSizeBytes(state: Client, value: CoreTypes.Long) =
            { state with RequestSizeBytes = Some value }

        [<CustomOperation("xOpaqueId")>]
        member _.XOpaqueId(state: Client, value: string) =
            { state with XOpaqueId = Some value }

    let client = ClientBuilder()

    type ClusterStateQueueBuilder() =
        member _.Yield(_: unit) : ClusterStateQueue =
            {
                Total = None
                Pending = None
                Committed = None
            }

        [<CustomOperation("total")>]
        member _.Total(state: ClusterStateQueue, value: CoreTypes.Long) =
            { state with Total = Some value }

        [<CustomOperation("pending")>]
        member _.Pending(state: ClusterStateQueue, value: CoreTypes.Long) =
            { state with Pending = Some value }

        [<CustomOperation("committed")>]
        member _.Committed(state: ClusterStateQueue, value: CoreTypes.Long) =
            { state with Committed = Some value }

    let clusterStateQueue = ClusterStateQueueBuilder()

    type ClusterStateUpdateBuilder() =
        member _.Yield(_: unit) : ClusterStateUpdate =
            {
                Count = Unchecked.defaultof<_>
                ComputationTime = None
                ComputationTimeMillis = None
                PublicationTime = None
                PublicationTimeMillis = None
                ContextConstructionTime = None
                ContextConstructionTimeMillis = None
                CommitTime = None
                CommitTimeMillis = None
                CompletionTime = None
                CompletionTimeMillis = None
                MasterApplyTime = None
                MasterApplyTimeMillis = None
                NotificationTime = None
                NotificationTimeMillis = None
            }

        [<CustomOperation("count")>]
        member _.Count(state: ClusterStateUpdate, value: CoreTypes.Long) =
            { state with Count = value }

        [<CustomOperation("computationTime")>]
        member _.ComputationTime(state: ClusterStateUpdate, value: CoreTypes.Duration) =
            { state with ComputationTime = Some value }

        [<CustomOperation("computationTimeMillis")>]
        member _.ComputationTimeMillis(state: ClusterStateUpdate, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with ComputationTimeMillis = Some value }

        [<CustomOperation("publicationTime")>]
        member _.PublicationTime(state: ClusterStateUpdate, value: CoreTypes.Duration) =
            { state with PublicationTime = Some value }

        [<CustomOperation("publicationTimeMillis")>]
        member _.PublicationTimeMillis(state: ClusterStateUpdate, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with PublicationTimeMillis = Some value }

        [<CustomOperation("contextConstructionTime")>]
        member _.ContextConstructionTime(state: ClusterStateUpdate, value: CoreTypes.Duration) =
            { state with ContextConstructionTime = Some value }

        [<CustomOperation("contextConstructionTimeMillis")>]
        member _.ContextConstructionTimeMillis(state: ClusterStateUpdate, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with ContextConstructionTimeMillis = Some value }

        [<CustomOperation("commitTime")>]
        member _.CommitTime(state: ClusterStateUpdate, value: CoreTypes.Duration) =
            { state with CommitTime = Some value }

        [<CustomOperation("commitTimeMillis")>]
        member _.CommitTimeMillis(state: ClusterStateUpdate, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with CommitTimeMillis = Some value }

        [<CustomOperation("completionTime")>]
        member _.CompletionTime(state: ClusterStateUpdate, value: CoreTypes.Duration) =
            { state with CompletionTime = Some value }

        [<CustomOperation("completionTimeMillis")>]
        member _.CompletionTimeMillis(state: ClusterStateUpdate, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with CompletionTimeMillis = Some value }

        [<CustomOperation("masterApplyTime")>]
        member _.MasterApplyTime(state: ClusterStateUpdate, value: CoreTypes.Duration) =
            { state with MasterApplyTime = Some value }

        [<CustomOperation("masterApplyTimeMillis")>]
        member _.MasterApplyTimeMillis(state: ClusterStateUpdate, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with MasterApplyTimeMillis = Some value }

        [<CustomOperation("notificationTime")>]
        member _.NotificationTime(state: ClusterStateUpdate, value: CoreTypes.Duration) =
            { state with NotificationTime = Some value }

        [<CustomOperation("notificationTimeMillis")>]
        member _.NotificationTimeMillis(state: ClusterStateUpdate, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with NotificationTimeMillis = Some value }

    let clusterStateUpdate = ClusterStateUpdateBuilder()

    type ContextBuilder() =
        member _.Yield(_: unit) : Context =
            {
                Context = None
                Compilations = None
                CacheEvictions = None
                CompilationLimitTriggered = None
            }

        [<CustomOperation("context")>]
        member _.Context(state: Context, value: string) =
            { state with Context = Some value }

        [<CustomOperation("compilations")>]
        member _.Compilations(state: Context, value: CoreTypes.Long) =
            { state with Compilations = Some value }

        [<CustomOperation("cacheEvictions")>]
        member _.CacheEvictions(state: Context, value: CoreTypes.Long) =
            { state with CacheEvictions = Some value }

        [<CustomOperation("compilationLimitTriggered")>]
        member _.CompilationLimitTriggered(state: Context, value: CoreTypes.Long) =
            { state with CompilationLimitTriggered = Some value }

    let context = ContextBuilder()

    type CpuBuilder() =
        member _.Yield(_: unit) : Cpu =
            {
                Percent = None
                Sys = None
                SysInMillis = None
                Total = None
                TotalInMillis = None
                User = None
                UserInMillis = None
                LoadAverage = None
            }

        [<CustomOperation("percent")>]
        member _.Percent(state: Cpu, value: CoreTypes.Integer) =
            { state with Percent = Some value }

        [<CustomOperation("sys")>]
        member _.Sys(state: Cpu, value: CoreTypes.Duration) =
            { state with Sys = Some value }

        [<CustomOperation("sysInMillis")>]
        member _.SysInMillis(state: Cpu, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with SysInMillis = Some value }

        [<CustomOperation("total")>]
        member _.Total(state: Cpu, value: CoreTypes.Duration) =
            { state with Total = Some value }

        [<CustomOperation("totalInMillis")>]
        member _.TotalInMillis(state: Cpu, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with TotalInMillis = Some value }

        [<CustomOperation("user")>]
        member _.User(state: Cpu, value: CoreTypes.Duration) =
            { state with User = Some value }

        [<CustomOperation("userInMillis")>]
        member _.UserInMillis(state: Cpu, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with UserInMillis = Some value }

        [<CustomOperation("loadAverage")>]
        member _.LoadAverage(state: Cpu, value: Map<string, CoreTypes.Double>) =
            { state with LoadAverage = Some value }

    let cpu = CpuBuilder()

    type CpuAcctBuilder() =
        member _.Yield(_: unit) : CpuAcct =
            {
                ControlGroup = None
                UsageNanos = None
            }

        [<CustomOperation("controlGroup")>]
        member _.ControlGroup(state: CpuAcct, value: string) =
            { state with ControlGroup = Some value }

        [<CustomOperation("usageNanos")>]
        member _.UsageNanos(state: CpuAcct, value: CoreTypes.DurationValue<CoreTypes.UnitNanos>) =
            { state with UsageNanos = Some value }

    let cpuAcct = CpuAcctBuilder()

    type DataPathStatsBuilder() =
        member _.Yield(_: unit) : DataPathStats =
            {
                Available = None
                AvailableInBytes = None
                DiskQueue = None
                DiskReads = None
                DiskReadSize = None
                DiskReadSizeInBytes = None
                DiskWrites = None
                DiskWriteSize = None
                DiskWriteSizeInBytes = None
                Free = None
                FreeInBytes = None
                Mount = None
                Path = None
                Total = None
                TotalInBytes = None
                Type = None
            }

        [<CustomOperation("available")>]
        member _.Available(state: DataPathStats, value: string) =
            { state with Available = Some value }

        [<CustomOperation("availableInBytes")>]
        member _.AvailableInBytes(state: DataPathStats, value: CoreTypes.Long) =
            { state with AvailableInBytes = Some value }

        [<CustomOperation("diskQueue")>]
        member _.DiskQueue(state: DataPathStats, value: string) =
            { state with DiskQueue = Some value }

        [<CustomOperation("diskReads")>]
        member _.DiskReads(state: DataPathStats, value: CoreTypes.Long) =
            { state with DiskReads = Some value }

        [<CustomOperation("diskReadSize")>]
        member _.DiskReadSize(state: DataPathStats, value: string) =
            { state with DiskReadSize = Some value }

        [<CustomOperation("diskReadSizeInBytes")>]
        member _.DiskReadSizeInBytes(state: DataPathStats, value: CoreTypes.Long) =
            { state with DiskReadSizeInBytes = Some value }

        [<CustomOperation("diskWrites")>]
        member _.DiskWrites(state: DataPathStats, value: CoreTypes.Long) =
            { state with DiskWrites = Some value }

        [<CustomOperation("diskWriteSize")>]
        member _.DiskWriteSize(state: DataPathStats, value: string) =
            { state with DiskWriteSize = Some value }

        [<CustomOperation("diskWriteSizeInBytes")>]
        member _.DiskWriteSizeInBytes(state: DataPathStats, value: CoreTypes.Long) =
            { state with DiskWriteSizeInBytes = Some value }

        [<CustomOperation("free")>]
        member _.Free(state: DataPathStats, value: string) =
            { state with Free = Some value }

        [<CustomOperation("freeInBytes")>]
        member _.FreeInBytes(state: DataPathStats, value: CoreTypes.Long) =
            { state with FreeInBytes = Some value }

        [<CustomOperation("mount")>]
        member _.Mount(state: DataPathStats, value: string) =
            { state with Mount = Some value }

        [<CustomOperation("path")>]
        member _.Path(state: DataPathStats, value: string) =
            { state with Path = Some value }

        [<CustomOperation("total")>]
        member _.Total(state: DataPathStats, value: string) =
            { state with Total = Some value }

        [<CustomOperation("totalInBytes")>]
        member _.TotalInBytes(state: DataPathStats, value: CoreTypes.Long) =
            { state with TotalInBytes = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: DataPathStats, value: string) =
            { state with Type = Some value }

    let dataPathStats = DataPathStatsBuilder()

    type DiscoveryBuilder() =
        member _.Yield(_: unit) : Discovery =
            {
                ClusterStateQueue = None
                PublishedClusterStates = None
                ClusterStateUpdate = None
                SerializedClusterStates = None
                ClusterApplierStats = None
            }

        [<CustomOperation("clusterStateQueue")>]
        member _.ClusterStateQueue(state: Discovery, value: NodesTypes.ClusterStateQueue) =
            { state with ClusterStateQueue = Some value }

        [<CustomOperation("publishedClusterStates")>]
        member _.PublishedClusterStates(state: Discovery, value: NodesTypes.PublishedClusterStates) =
            { state with PublishedClusterStates = Some value }

        [<CustomOperation("clusterStateUpdate")>]
        member _.ClusterStateUpdate(state: Discovery, value: Map<string, NodesTypes.ClusterStateUpdate>) =
            { state with ClusterStateUpdate = Some value }

        [<CustomOperation("serializedClusterStates")>]
        member _.SerializedClusterStates(state: Discovery, value: NodesTypes.SerializedClusterState) =
            { state with SerializedClusterStates = Some value }

        [<CustomOperation("clusterApplierStats")>]
        member _.ClusterApplierStats(state: Discovery, value: NodesTypes.ClusterAppliedStats) =
            { state with ClusterApplierStats = Some value }

    let discovery = DiscoveryBuilder()

    type ExtendedMemoryStatsBuilder() =
        member _.Yield(_: unit) : ExtendedMemoryStats =
            {
                FreePercent = None
                UsedPercent = None
            }

        [<CustomOperation("freePercent")>]
        member _.FreePercent(state: ExtendedMemoryStats, value: CoreTypes.Integer) =
            { state with FreePercent = Some value }

        [<CustomOperation("usedPercent")>]
        member _.UsedPercent(state: ExtendedMemoryStats, value: CoreTypes.Integer) =
            { state with UsedPercent = Some value }

    let extendedMemoryStats = ExtendedMemoryStatsBuilder()

    type FileSystemBuilder() =
        member _.Yield(_: unit) : FileSystem =
            {
                Data = None
                Timestamp = None
                Total = None
                IoStats = None
            }

        [<CustomOperation("data")>]
        member _.Data(state: FileSystem, value: NodesTypes.DataPathStats list) =
            { state with Data = Some value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: FileSystem, value: CoreTypes.Long) =
            { state with Timestamp = Some value }

        [<CustomOperation("total")>]
        member _.Total(state: FileSystem, value: NodesTypes.FileSystemTotal) =
            { state with Total = Some value }

        [<CustomOperation("ioStats")>]
        member _.IoStats(state: FileSystem, value: NodesTypes.IoStats) =
            { state with IoStats = Some value }

    let fileSystem = FileSystemBuilder()

    type FileSystemTotalBuilder() =
        member _.Yield(_: unit) : FileSystemTotal =
            {
                Available = None
                AvailableInBytes = None
                Free = None
                FreeInBytes = None
                Total = None
                TotalInBytes = None
            }

        [<CustomOperation("available")>]
        member _.Available(state: FileSystemTotal, value: string) =
            { state with Available = Some value }

        [<CustomOperation("availableInBytes")>]
        member _.AvailableInBytes(state: FileSystemTotal, value: CoreTypes.Long) =
            { state with AvailableInBytes = Some value }

        [<CustomOperation("free")>]
        member _.Free(state: FileSystemTotal, value: string) =
            { state with Free = Some value }

        [<CustomOperation("freeInBytes")>]
        member _.FreeInBytes(state: FileSystemTotal, value: CoreTypes.Long) =
            { state with FreeInBytes = Some value }

        [<CustomOperation("total")>]
        member _.Total(state: FileSystemTotal, value: string) =
            { state with Total = Some value }

        [<CustomOperation("totalInBytes")>]
        member _.TotalInBytes(state: FileSystemTotal, value: CoreTypes.Long) =
            { state with TotalInBytes = Some value }

    let fileSystemTotal = FileSystemTotalBuilder()

    type GarbageCollectorTotalBuilder() =
        member _.Yield(_: unit) : GarbageCollectorTotal =
            {
                CollectionCount = None
                CollectionTime = None
                CollectionTimeInMillis = None
            }

        [<CustomOperation("collectionCount")>]
        member _.CollectionCount(state: GarbageCollectorTotal, value: CoreTypes.Long) =
            { state with CollectionCount = Some value }

        [<CustomOperation("collectionTime")>]
        member _.CollectionTime(state: GarbageCollectorTotal, value: string) =
            { state with CollectionTime = Some value }

        [<CustomOperation("collectionTimeInMillis")>]
        member _.CollectionTimeInMillis(state: GarbageCollectorTotal, value: CoreTypes.Long) =
            { state with CollectionTimeInMillis = Some value }

    let garbageCollectorTotal = GarbageCollectorTotalBuilder()

    type HttpBuilder() =
        member _.Yield(_: unit) : Http =
            {
                CurrentOpen = None
                TotalOpened = None
                Clients = None
                Routes = Unchecked.defaultof<_>
            }

        [<CustomOperation("currentOpen")>]
        member _.CurrentOpen(state: Http, value: CoreTypes.Integer) =
            { state with CurrentOpen = Some value }

        [<CustomOperation("totalOpened")>]
        member _.TotalOpened(state: Http, value: CoreTypes.Long) =
            { state with TotalOpened = Some value }

        [<CustomOperation("clients")>]
        member _.Clients(state: Http, value: NodesTypes.Client list) =
            { state with Clients = Some value }

        [<CustomOperation("routes")>]
        member _.Routes(state: Http, value: Map<string, NodesTypes.HttpRoute>) =
            { state with Routes = value }

    let http = HttpBuilder()

    type IndexingPressureMemoryBuilder() =
        member _.Yield(_: unit) : IndexingPressureMemory =
            {
                Limit = None
                LimitInBytes = None
                Current = None
                Total = None
            }

        [<CustomOperation("limit")>]
        member _.Limit(state: IndexingPressureMemory, value: CoreTypes.ByteSize) =
            { state with Limit = Some value }

        [<CustomOperation("limitInBytes")>]
        member _.LimitInBytes(state: IndexingPressureMemory, value: CoreTypes.Long) =
            { state with LimitInBytes = Some value }

        [<CustomOperation("current")>]
        member _.Current(state: IndexingPressureMemory, value: NodesTypes.PressureMemory) =
            { state with Current = Some value }

        [<CustomOperation("total")>]
        member _.Total(state: IndexingPressureMemory, value: NodesTypes.PressureMemory) =
            { state with Total = Some value }

    let indexingPressureMemory = IndexingPressureMemoryBuilder()

    type IngestBuilder() =
        member _.Yield(_: unit) : Ingest =
            {
                Pipelines = None
                Total = None
            }

        [<CustomOperation("pipelines")>]
        member _.Pipelines(state: Ingest, value: Map<string, NodesTypes.IngestStats>) =
            { state with Pipelines = Some value }

        [<CustomOperation("total")>]
        member _.Total(state: Ingest, value: NodesTypes.IngestTotal) =
            { state with Total = Some value }

    let ingest = IngestBuilder()

    type IoStatDeviceBuilder() =
        member _.Yield(_: unit) : IoStatDevice =
            {
                DeviceName = None
                Operations = None
                ReadKilobytes = None
                ReadOperations = None
                WriteKilobytes = None
                WriteOperations = None
            }

        [<CustomOperation("deviceName")>]
        member _.DeviceName(state: IoStatDevice, value: string) =
            { state with DeviceName = Some value }

        [<CustomOperation("operations")>]
        member _.Operations(state: IoStatDevice, value: CoreTypes.Long) =
            { state with Operations = Some value }

        [<CustomOperation("readKilobytes")>]
        member _.ReadKilobytes(state: IoStatDevice, value: CoreTypes.Long) =
            { state with ReadKilobytes = Some value }

        [<CustomOperation("readOperations")>]
        member _.ReadOperations(state: IoStatDevice, value: CoreTypes.Long) =
            { state with ReadOperations = Some value }

        [<CustomOperation("writeKilobytes")>]
        member _.WriteKilobytes(state: IoStatDevice, value: CoreTypes.Long) =
            { state with WriteKilobytes = Some value }

        [<CustomOperation("writeOperations")>]
        member _.WriteOperations(state: IoStatDevice, value: CoreTypes.Long) =
            { state with WriteOperations = Some value }

    let ioStatDevice = IoStatDeviceBuilder()

    type IoStatsBuilder() =
        member _.Yield(_: unit) : IoStats =
            {
                Devices = None
                Total = None
            }

        [<CustomOperation("devices")>]
        member _.Devices(state: IoStats, value: NodesTypes.IoStatDevice list) =
            { state with Devices = Some value }

        [<CustomOperation("total")>]
        member _.Total(state: IoStats, value: NodesTypes.IoStatDevice) =
            { state with Total = Some value }

    let ioStats = IoStatsBuilder()

    type JvmBuilder() =
        member _.Yield(_: unit) : Jvm =
            {
                BufferPools = None
                Classes = None
                Gc = None
                Mem = None
                Threads = None
                Timestamp = None
                Uptime = None
                UptimeInMillis = None
            }

        [<CustomOperation("bufferPools")>]
        member _.BufferPools(state: Jvm, value: Map<string, NodesTypes.NodeBufferPool>) =
            { state with BufferPools = Some value }

        [<CustomOperation("classes")>]
        member _.Classes(state: Jvm, value: NodesTypes.JvmClasses) =
            { state with Classes = Some value }

        [<CustomOperation("gc")>]
        member _.Gc(state: Jvm, value: NodesTypes.GarbageCollector) =
            { state with Gc = Some value }

        [<CustomOperation("mem")>]
        member _.Mem(state: Jvm, value: NodesTypes.JvmMemoryStats) =
            { state with Mem = Some value }

        [<CustomOperation("threads")>]
        member _.Threads(state: Jvm, value: NodesTypes.JvmThreads) =
            { state with Threads = Some value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: Jvm, value: CoreTypes.Long) =
            { state with Timestamp = Some value }

        [<CustomOperation("uptime")>]
        member _.Uptime(state: Jvm, value: string) =
            { state with Uptime = Some value }

        [<CustomOperation("uptimeInMillis")>]
        member _.UptimeInMillis(state: Jvm, value: CoreTypes.Long) =
            { state with UptimeInMillis = Some value }

    let jvm = JvmBuilder()

    type JvmClassesBuilder() =
        member _.Yield(_: unit) : JvmClasses =
            {
                CurrentLoadedCount = None
                TotalLoadedCount = None
                TotalUnloadedCount = None
            }

        [<CustomOperation("currentLoadedCount")>]
        member _.CurrentLoadedCount(state: JvmClasses, value: CoreTypes.Long) =
            { state with CurrentLoadedCount = Some value }

        [<CustomOperation("totalLoadedCount")>]
        member _.TotalLoadedCount(state: JvmClasses, value: CoreTypes.Long) =
            { state with TotalLoadedCount = Some value }

        [<CustomOperation("totalUnloadedCount")>]
        member _.TotalUnloadedCount(state: JvmClasses, value: CoreTypes.Long) =
            { state with TotalUnloadedCount = Some value }

    let jvmClasses = JvmClassesBuilder()

    type JvmMemoryStatsBuilder() =
        member _.Yield(_: unit) : JvmMemoryStats =
            {
                HeapUsedInBytes = None
                HeapUsedPercent = None
                HeapCommittedInBytes = None
                HeapMaxInBytes = None
                HeapMax = None
                NonHeapUsedInBytes = None
                NonHeapCommittedInBytes = None
                Pools = None
            }

        [<CustomOperation("heapUsedInBytes")>]
        member _.HeapUsedInBytes(state: JvmMemoryStats, value: CoreTypes.Long) =
            { state with HeapUsedInBytes = Some value }

        [<CustomOperation("heapUsedPercent")>]
        member _.HeapUsedPercent(state: JvmMemoryStats, value: CoreTypes.Long) =
            { state with HeapUsedPercent = Some value }

        [<CustomOperation("heapCommittedInBytes")>]
        member _.HeapCommittedInBytes(state: JvmMemoryStats, value: CoreTypes.Long) =
            { state with HeapCommittedInBytes = Some value }

        [<CustomOperation("heapMaxInBytes")>]
        member _.HeapMaxInBytes(state: JvmMemoryStats, value: CoreTypes.Long) =
            { state with HeapMaxInBytes = Some value }

        [<CustomOperation("heapMax")>]
        member _.HeapMax(state: JvmMemoryStats, value: CoreTypes.ByteSize) =
            { state with HeapMax = Some value }

        [<CustomOperation("nonHeapUsedInBytes")>]
        member _.NonHeapUsedInBytes(state: JvmMemoryStats, value: CoreTypes.Long) =
            { state with NonHeapUsedInBytes = Some value }

        [<CustomOperation("nonHeapCommittedInBytes")>]
        member _.NonHeapCommittedInBytes(state: JvmMemoryStats, value: CoreTypes.Long) =
            { state with NonHeapCommittedInBytes = Some value }

        [<CustomOperation("pools")>]
        member _.Pools(state: JvmMemoryStats, value: Map<string, NodesTypes.Pool>) =
            { state with Pools = Some value }

    let jvmMemoryStats = JvmMemoryStatsBuilder()

    type JvmThreadsBuilder() =
        member _.Yield(_: unit) : JvmThreads =
            {
                Count = None
                PeakCount = None
            }

        [<CustomOperation("count")>]
        member _.Count(state: JvmThreads, value: CoreTypes.Long) =
            { state with Count = Some value }

        [<CustomOperation("peakCount")>]
        member _.PeakCount(state: JvmThreads, value: CoreTypes.Long) =
            { state with PeakCount = Some value }

    let jvmThreads = JvmThreadsBuilder()

    type KeyedProcessorBuilder() =
        member _.Yield(_: unit) : KeyedProcessor =
            {
                Stats = None
                Type = None
            }

        [<CustomOperation("stats")>]
        member _.Stats(state: KeyedProcessor, value: NodesTypes.Processor) =
            { state with Stats = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: KeyedProcessor, value: string) =
            { state with Type = Some value }

    let keyedProcessor = KeyedProcessorBuilder()

    type MemoryStatsBuilder() =
        member _.Yield(_: unit) : MemoryStats =
            {
                AdjustedTotalInBytes = None
                Resident = None
                ResidentInBytes = None
                Share = None
                ShareInBytes = None
                TotalVirtual = None
                TotalVirtualInBytes = None
                TotalInBytes = None
                FreeInBytes = None
                UsedInBytes = None
            }

        [<CustomOperation("adjustedTotalInBytes")>]
        member _.AdjustedTotalInBytes(state: MemoryStats, value: CoreTypes.Long) =
            { state with AdjustedTotalInBytes = Some value }

        [<CustomOperation("resident")>]
        member _.Resident(state: MemoryStats, value: string) =
            { state with Resident = Some value }

        [<CustomOperation("residentInBytes")>]
        member _.ResidentInBytes(state: MemoryStats, value: CoreTypes.Long) =
            { state with ResidentInBytes = Some value }

        [<CustomOperation("share")>]
        member _.Share(state: MemoryStats, value: string) =
            { state with Share = Some value }

        [<CustomOperation("shareInBytes")>]
        member _.ShareInBytes(state: MemoryStats, value: CoreTypes.Long) =
            { state with ShareInBytes = Some value }

        [<CustomOperation("totalVirtual")>]
        member _.TotalVirtual(state: MemoryStats, value: string) =
            { state with TotalVirtual = Some value }

        [<CustomOperation("totalVirtualInBytes")>]
        member _.TotalVirtualInBytes(state: MemoryStats, value: CoreTypes.Long) =
            { state with TotalVirtualInBytes = Some value }

        [<CustomOperation("totalInBytes")>]
        member _.TotalInBytes(state: MemoryStats, value: CoreTypes.Long) =
            { state with TotalInBytes = Some value }

        [<CustomOperation("freeInBytes")>]
        member _.FreeInBytes(state: MemoryStats, value: CoreTypes.Long) =
            { state with FreeInBytes = Some value }

        [<CustomOperation("usedInBytes")>]
        member _.UsedInBytes(state: MemoryStats, value: CoreTypes.Long) =
            { state with UsedInBytes = Some value }

    let memoryStats = MemoryStatsBuilder()

    type NodeBufferPoolBuilder() =
        member _.Yield(_: unit) : NodeBufferPool =
            {
                Count = None
                TotalCapacity = None
                TotalCapacityInBytes = None
                Used = None
                UsedInBytes = None
            }

        [<CustomOperation("count")>]
        member _.Count(state: NodeBufferPool, value: CoreTypes.Long) =
            { state with Count = Some value }

        [<CustomOperation("totalCapacity")>]
        member _.TotalCapacity(state: NodeBufferPool, value: string) =
            { state with TotalCapacity = Some value }

        [<CustomOperation("totalCapacityInBytes")>]
        member _.TotalCapacityInBytes(state: NodeBufferPool, value: CoreTypes.Long) =
            { state with TotalCapacityInBytes = Some value }

        [<CustomOperation("used")>]
        member _.Used(state: NodeBufferPool, value: string) =
            { state with Used = Some value }

        [<CustomOperation("usedInBytes")>]
        member _.UsedInBytes(state: NodeBufferPool, value: CoreTypes.Long) =
            { state with UsedInBytes = Some value }

    let nodeBufferPool = NodeBufferPoolBuilder()

    type NodeReloadResultBuilder() =
        member _.Yield(_: unit) : NodeReloadResult =
            {
                Name = Unchecked.defaultof<_>
                ReloadException = None
                SecureSettingNames = None
                KeystorePath = None
                KeystoreDigest = None
                KeystoreLastModifiedTime = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: NodeReloadResult, value: CoreTypes.Name) =
            { state with Name = value }

        [<CustomOperation("reloadException")>]
        member _.ReloadException(state: NodeReloadResult, value: CoreTypes.ErrorCause) =
            { state with ReloadException = Some value }

        [<CustomOperation("secureSettingNames")>]
        member _.SecureSettingNames(state: NodeReloadResult, value: string list) =
            { state with SecureSettingNames = Some value }

        [<CustomOperation("keystorePath")>]
        member _.KeystorePath(state: NodeReloadResult, value: string) =
            { state with KeystorePath = Some value }

        [<CustomOperation("keystoreDigest")>]
        member _.KeystoreDigest(state: NodeReloadResult, value: string) =
            { state with KeystoreDigest = Some value }

        [<CustomOperation("keystoreLastModifiedTime")>]
        member _.KeystoreLastModifiedTime(state: NodeReloadResult, value: CoreTypes.DateTime) =
            { state with KeystoreLastModifiedTime = Some value }

    let nodeReloadResult = NodeReloadResultBuilder()

    type OperatingSystemBuilder() =
        member _.Yield(_: unit) : OperatingSystem =
            {
                Cpu = None
                Mem = None
                Swap = None
                Cgroup = None
                Timestamp = None
            }

        [<CustomOperation("cpu")>]
        member _.Cpu(state: OperatingSystem, value: NodesTypes.Cpu) =
            { state with Cpu = Some value }

        [<CustomOperation("mem")>]
        member _.Mem(state: OperatingSystem, value: NodesTypes.ExtendedMemoryStats) =
            { state with Mem = Some value }

        [<CustomOperation("swap")>]
        member _.Swap(state: OperatingSystem, value: NodesTypes.MemoryStats) =
            { state with Swap = Some value }

        [<CustomOperation("cgroup")>]
        member _.Cgroup(state: OperatingSystem, value: NodesTypes.Cgroup) =
            { state with Cgroup = Some value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: OperatingSystem, value: CoreTypes.Long) =
            { state with Timestamp = Some value }

    let operatingSystem = OperatingSystemBuilder()

    type PoolBuilder() =
        member _.Yield(_: unit) : Pool =
            {
                UsedInBytes = None
                MaxInBytes = None
                PeakUsedInBytes = None
                PeakMaxInBytes = None
            }

        [<CustomOperation("usedInBytes")>]
        member _.UsedInBytes(state: Pool, value: CoreTypes.Long) =
            { state with UsedInBytes = Some value }

        [<CustomOperation("maxInBytes")>]
        member _.MaxInBytes(state: Pool, value: CoreTypes.Long) =
            { state with MaxInBytes = Some value }

        [<CustomOperation("peakUsedInBytes")>]
        member _.PeakUsedInBytes(state: Pool, value: CoreTypes.Long) =
            { state with PeakUsedInBytes = Some value }

        [<CustomOperation("peakMaxInBytes")>]
        member _.PeakMaxInBytes(state: Pool, value: CoreTypes.Long) =
            { state with PeakMaxInBytes = Some value }

    let pool = PoolBuilder()

    type PressureMemoryBuilder() =
        member _.Yield(_: unit) : PressureMemory =
            {
                All = None
                AllInBytes = None
                CombinedCoordinatingAndPrimary = None
                CombinedCoordinatingAndPrimaryInBytes = None
                Coordinating = None
                CoordinatingInBytes = None
                Primary = None
                PrimaryInBytes = None
                Replica = None
                ReplicaInBytes = None
                CoordinatingRejections = None
                PrimaryRejections = None
                ReplicaRejections = None
                PrimaryDocumentRejections = None
                LargeOperationRejections = None
            }

        [<CustomOperation("all")>]
        member _.All(state: PressureMemory, value: CoreTypes.ByteSize) =
            { state with All = Some value }

        [<CustomOperation("allInBytes")>]
        member _.AllInBytes(state: PressureMemory, value: CoreTypes.Long) =
            { state with AllInBytes = Some value }

        [<CustomOperation("combinedCoordinatingAndPrimary")>]
        member _.CombinedCoordinatingAndPrimary(state: PressureMemory, value: CoreTypes.ByteSize) =
            { state with CombinedCoordinatingAndPrimary = Some value }

        [<CustomOperation("combinedCoordinatingAndPrimaryInBytes")>]
        member _.CombinedCoordinatingAndPrimaryInBytes(state: PressureMemory, value: CoreTypes.Long) =
            { state with CombinedCoordinatingAndPrimaryInBytes = Some value }

        [<CustomOperation("coordinating")>]
        member _.Coordinating(state: PressureMemory, value: CoreTypes.ByteSize) =
            { state with Coordinating = Some value }

        [<CustomOperation("coordinatingInBytes")>]
        member _.CoordinatingInBytes(state: PressureMemory, value: CoreTypes.Long) =
            { state with CoordinatingInBytes = Some value }

        [<CustomOperation("primary")>]
        member _.Primary(state: PressureMemory, value: CoreTypes.ByteSize) =
            { state with Primary = Some value }

        [<CustomOperation("primaryInBytes")>]
        member _.PrimaryInBytes(state: PressureMemory, value: CoreTypes.Long) =
            { state with PrimaryInBytes = Some value }

        [<CustomOperation("replica")>]
        member _.Replica(state: PressureMemory, value: CoreTypes.ByteSize) =
            { state with Replica = Some value }

        [<CustomOperation("replicaInBytes")>]
        member _.ReplicaInBytes(state: PressureMemory, value: CoreTypes.Long) =
            { state with ReplicaInBytes = Some value }

        [<CustomOperation("coordinatingRejections")>]
        member _.CoordinatingRejections(state: PressureMemory, value: CoreTypes.Long) =
            { state with CoordinatingRejections = Some value }

        [<CustomOperation("primaryRejections")>]
        member _.PrimaryRejections(state: PressureMemory, value: CoreTypes.Long) =
            { state with PrimaryRejections = Some value }

        [<CustomOperation("replicaRejections")>]
        member _.ReplicaRejections(state: PressureMemory, value: CoreTypes.Long) =
            { state with ReplicaRejections = Some value }

        [<CustomOperation("primaryDocumentRejections")>]
        member _.PrimaryDocumentRejections(state: PressureMemory, value: CoreTypes.Long) =
            { state with PrimaryDocumentRejections = Some value }

        [<CustomOperation("largeOperationRejections")>]
        member _.LargeOperationRejections(state: PressureMemory, value: CoreTypes.Long) =
            { state with LargeOperationRejections = Some value }

    let pressureMemory = PressureMemoryBuilder()

    type ProcessBuilder() =
        member _.Yield(_: unit) : Process =
            {
                Cpu = None
                Mem = None
                OpenFileDescriptors = None
                MaxFileDescriptors = None
                Timestamp = None
            }

        [<CustomOperation("cpu")>]
        member _.Cpu(state: Process, value: NodesTypes.Cpu) =
            { state with Cpu = Some value }

        [<CustomOperation("mem")>]
        member _.Mem(state: Process, value: NodesTypes.MemoryStats) =
            { state with Mem = Some value }

        [<CustomOperation("openFileDescriptors")>]
        member _.OpenFileDescriptors(state: Process, value: CoreTypes.Integer) =
            { state with OpenFileDescriptors = Some value }

        [<CustomOperation("maxFileDescriptors")>]
        member _.MaxFileDescriptors(state: Process, value: CoreTypes.Integer) =
            { state with MaxFileDescriptors = Some value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: Process, value: CoreTypes.Long) =
            { state with Timestamp = Some value }

    let process = ProcessBuilder()

    type ProcessorBuilder() =
        member _.Yield(_: unit) : Processor =
            {
                Count = None
                Current = None
                Failed = None
                TimeInMillis = None
            }

        [<CustomOperation("count")>]
        member _.Count(state: Processor, value: CoreTypes.Long) =
            { state with Count = Some value }

        [<CustomOperation("current")>]
        member _.Current(state: Processor, value: CoreTypes.Long) =
            { state with Current = Some value }

        [<CustomOperation("failed")>]
        member _.Failed(state: Processor, value: CoreTypes.Long) =
            { state with Failed = Some value }

        [<CustomOperation("timeInMillis")>]
        member _.TimeInMillis(state: Processor, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with TimeInMillis = Some value }

    let processor = ProcessorBuilder()

    type PublishedClusterStatesBuilder() =
        member _.Yield(_: unit) : PublishedClusterStates =
            {
                FullStates = None
                IncompatibleDiffs = None
                CompatibleDiffs = None
            }

        [<CustomOperation("fullStates")>]
        member _.FullStates(state: PublishedClusterStates, value: CoreTypes.Long) =
            { state with FullStates = Some value }

        [<CustomOperation("incompatibleDiffs")>]
        member _.IncompatibleDiffs(state: PublishedClusterStates, value: CoreTypes.Long) =
            { state with IncompatibleDiffs = Some value }

        [<CustomOperation("compatibleDiffs")>]
        member _.CompatibleDiffs(state: PublishedClusterStates, value: CoreTypes.Long) =
            { state with CompatibleDiffs = Some value }

    let publishedClusterStates = PublishedClusterStatesBuilder()

    type RecordingBuilder() =
        member _.Yield(_: unit) : Recording =
            {
                Name = None
                CumulativeExecutionCount = None
                CumulativeExecutionTime = None
                CumulativeExecutionTimeMillis = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: Recording, value: string) =
            { state with Name = Some value }

        [<CustomOperation("cumulativeExecutionCount")>]
        member _.CumulativeExecutionCount(state: Recording, value: CoreTypes.Long) =
            { state with CumulativeExecutionCount = Some value }

        [<CustomOperation("cumulativeExecutionTime")>]
        member _.CumulativeExecutionTime(state: Recording, value: CoreTypes.Duration) =
            { state with CumulativeExecutionTime = Some value }

        [<CustomOperation("cumulativeExecutionTimeMillis")>]
        member _.CumulativeExecutionTimeMillis(state: Recording, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with CumulativeExecutionTimeMillis = Some value }

    let recording = RecordingBuilder()

    type RepositoryLocationBuilder() =
        member _.Yield(_: unit) : RepositoryLocation =
            {
                BasePath = Unchecked.defaultof<_>
                Container = None
                Bucket = None
            }

        [<CustomOperation("basePath")>]
        member _.BasePath(state: RepositoryLocation, value: string) =
            { state with BasePath = value }

        [<CustomOperation("container")>]
        member _.Container(state: RepositoryLocation, value: string) =
            { state with Container = Some value }

        [<CustomOperation("bucket")>]
        member _.Bucket(state: RepositoryLocation, value: string) =
            { state with Bucket = Some value }

    let repositoryLocation = RepositoryLocationBuilder()

    type RepositoryMeteringInformationBuilder() =
        member _.Yield(_: unit) : RepositoryMeteringInformation =
            {
                RepositoryName = Unchecked.defaultof<_>
                RepositoryType = Unchecked.defaultof<_>
                RepositoryLocation = Unchecked.defaultof<_>
                RepositoryEphemeralId = Unchecked.defaultof<_>
                RepositoryStartedAt = Unchecked.defaultof<_>
                RepositoryStoppedAt = None
                Archived = Unchecked.defaultof<_>
                ClusterVersion = None
                RequestCounts = Unchecked.defaultof<_>
            }

        [<CustomOperation("repositoryName")>]
        member _.RepositoryName(state: RepositoryMeteringInformation, value: CoreTypes.Name) =
            { state with RepositoryName = value }

        [<CustomOperation("repositoryType")>]
        member _.RepositoryType(state: RepositoryMeteringInformation, value: string) =
            { state with RepositoryType = value }

        [<CustomOperation("repositoryLocation")>]
        member _.RepositoryLocation(state: RepositoryMeteringInformation, value: NodesTypes.RepositoryLocation) =
            { state with RepositoryLocation = value }

        [<CustomOperation("repositoryEphemeralId")>]
        member _.RepositoryEphemeralId(state: RepositoryMeteringInformation, value: CoreTypes.Id) =
            { state with RepositoryEphemeralId = value }

        [<CustomOperation("repositoryStartedAt")>]
        member _.RepositoryStartedAt(state: RepositoryMeteringInformation, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with RepositoryStartedAt = value }

        [<CustomOperation("repositoryStoppedAt")>]
        member _.RepositoryStoppedAt(state: RepositoryMeteringInformation, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with RepositoryStoppedAt = Some value }

        [<CustomOperation("archived")>]
        member _.Archived(state: RepositoryMeteringInformation, value: bool) =
            { state with Archived = value }

        [<CustomOperation("clusterVersion")>]
        member _.ClusterVersion(state: RepositoryMeteringInformation, value: CoreTypes.VersionNumber) =
            { state with ClusterVersion = Some value }

        [<CustomOperation("requestCounts")>]
        member _.RequestCounts(state: RepositoryMeteringInformation, value: NodesTypes.RequestCounts) =
            { state with RequestCounts = value }

    let repositoryMeteringInformation = RepositoryMeteringInformationBuilder()

    type RequestCountsBuilder() =
        member _.Yield(_: unit) : RequestCounts =
            {
                GetBlobProperties = None
                GetBlob = None
                ListBlobs = None
                PutBlob = None
                PutBlock = None
                PutBlockList = None
                GetObject = None
                ListObjects = None
                InsertObject = None
                PutObject = None
                PutMultipartObject = None
            }

        [<CustomOperation("getBlobProperties")>]
        member _.GetBlobProperties(state: RequestCounts, value: CoreTypes.Long) =
            { state with GetBlobProperties = Some value }

        [<CustomOperation("getBlob")>]
        member _.GetBlob(state: RequestCounts, value: CoreTypes.Long) =
            { state with GetBlob = Some value }

        [<CustomOperation("listBlobs")>]
        member _.ListBlobs(state: RequestCounts, value: CoreTypes.Long) =
            { state with ListBlobs = Some value }

        [<CustomOperation("putBlob")>]
        member _.PutBlob(state: RequestCounts, value: CoreTypes.Long) =
            { state with PutBlob = Some value }

        [<CustomOperation("putBlock")>]
        member _.PutBlock(state: RequestCounts, value: CoreTypes.Long) =
            { state with PutBlock = Some value }

        [<CustomOperation("putBlockList")>]
        member _.PutBlockList(state: RequestCounts, value: CoreTypes.Long) =
            { state with PutBlockList = Some value }

        [<CustomOperation("getObject")>]
        member _.GetObject(state: RequestCounts, value: CoreTypes.Long) =
            { state with GetObject = Some value }

        [<CustomOperation("listObjects")>]
        member _.ListObjects(state: RequestCounts, value: CoreTypes.Long) =
            { state with ListObjects = Some value }

        [<CustomOperation("insertObject")>]
        member _.InsertObject(state: RequestCounts, value: CoreTypes.Long) =
            { state with InsertObject = Some value }

        [<CustomOperation("putObject")>]
        member _.PutObject(state: RequestCounts, value: CoreTypes.Long) =
            { state with PutObject = Some value }

        [<CustomOperation("putMultipartObject")>]
        member _.PutMultipartObject(state: RequestCounts, value: CoreTypes.Long) =
            { state with PutMultipartObject = Some value }

    let requestCounts = RequestCountsBuilder()

    type ScriptCacheBuilder() =
        member _.Yield(_: unit) : ScriptCache =
            {
                CacheEvictions = None
                CompilationLimitTriggered = None
                Compilations = None
                Context = None
            }

        [<CustomOperation("cacheEvictions")>]
        member _.CacheEvictions(state: ScriptCache, value: CoreTypes.Long) =
            { state with CacheEvictions = Some value }

        [<CustomOperation("compilationLimitTriggered")>]
        member _.CompilationLimitTriggered(state: ScriptCache, value: CoreTypes.Long) =
            { state with CompilationLimitTriggered = Some value }

        [<CustomOperation("compilations")>]
        member _.Compilations(state: ScriptCache, value: CoreTypes.Long) =
            { state with Compilations = Some value }

        [<CustomOperation("context")>]
        member _.Context(state: ScriptCache, value: string) =
            { state with Context = Some value }

    let scriptCache = ScriptCacheBuilder()

    type ScriptingBuilder() =
        member _.Yield(_: unit) : Scripting =
            {
                CacheEvictions = None
                Compilations = None
                CompilationsHistory = None
                CompilationLimitTriggered = None
                Contexts = None
            }

        [<CustomOperation("cacheEvictions")>]
        member _.CacheEvictions(state: Scripting, value: CoreTypes.Long) =
            { state with CacheEvictions = Some value }

        [<CustomOperation("compilations")>]
        member _.Compilations(state: Scripting, value: CoreTypes.Long) =
            { state with Compilations = Some value }

        [<CustomOperation("compilationsHistory")>]
        member _.CompilationsHistory(state: Scripting, value: Map<string, CoreTypes.Long>) =
            { state with CompilationsHistory = Some value }

        [<CustomOperation("compilationLimitTriggered")>]
        member _.CompilationLimitTriggered(state: Scripting, value: CoreTypes.Long) =
            { state with CompilationLimitTriggered = Some value }

        [<CustomOperation("contexts")>]
        member _.Contexts(state: Scripting, value: NodesTypes.Context list) =
            { state with Contexts = Some value }

    let scripting = ScriptingBuilder()

    type SerializedClusterStateBuilder() =
        member _.Yield(_: unit) : SerializedClusterState =
            {
                FullStates = None
                Diffs = None
            }

        [<CustomOperation("fullStates")>]
        member _.FullStates(state: SerializedClusterState, value: NodesTypes.SerializedClusterStateDetail) =
            { state with FullStates = Some value }

        [<CustomOperation("diffs")>]
        member _.Diffs(state: SerializedClusterState, value: NodesTypes.SerializedClusterStateDetail) =
            { state with Diffs = Some value }

    let serializedClusterState = SerializedClusterStateBuilder()

    type SerializedClusterStateDetailBuilder() =
        member _.Yield(_: unit) : SerializedClusterStateDetail =
            {
                Count = None
                UncompressedSize = None
                UncompressedSizeInBytes = None
                CompressedSize = None
                CompressedSizeInBytes = None
            }

        [<CustomOperation("count")>]
        member _.Count(state: SerializedClusterStateDetail, value: CoreTypes.Long) =
            { state with Count = Some value }

        [<CustomOperation("uncompressedSize")>]
        member _.UncompressedSize(state: SerializedClusterStateDetail, value: string) =
            { state with UncompressedSize = Some value }

        [<CustomOperation("uncompressedSizeInBytes")>]
        member _.UncompressedSizeInBytes(state: SerializedClusterStateDetail, value: CoreTypes.Long) =
            { state with UncompressedSizeInBytes = Some value }

        [<CustomOperation("compressedSize")>]
        member _.CompressedSize(state: SerializedClusterStateDetail, value: string) =
            { state with CompressedSize = Some value }

        [<CustomOperation("compressedSizeInBytes")>]
        member _.CompressedSizeInBytes(state: SerializedClusterStateDetail, value: CoreTypes.Long) =
            { state with CompressedSizeInBytes = Some value }

    let serializedClusterStateDetail = SerializedClusterStateDetailBuilder()

    type SizeHttpHistogramBuilder() =
        member _.Yield(_: unit) : SizeHttpHistogram =
            {
                Count = Unchecked.defaultof<_>
                GeBytes = None
                LtBytes = None
            }

        [<CustomOperation("count")>]
        member _.Count(state: SizeHttpHistogram, value: CoreTypes.Long) =
            { state with Count = value }

        [<CustomOperation("geBytes")>]
        member _.GeBytes(state: SizeHttpHistogram, value: CoreTypes.Long) =
            { state with GeBytes = Some value }

        [<CustomOperation("ltBytes")>]
        member _.LtBytes(state: SizeHttpHistogram, value: CoreTypes.Long) =
            { state with LtBytes = Some value }

    let sizeHttpHistogram = SizeHttpHistogramBuilder()

    type StatsBuilder() =
        member _.Yield(_: unit) : Stats =
            {
                AdaptiveSelection = None
                Breakers = None
                Fs = None
                Host = None
                Http = None
                Ingest = None
                Ip = None
                Jvm = None
                Name = None
                Os = None
                Process = None
                Roles = None
                Script = None
                ScriptCache = None
                ThreadPool = None
                Timestamp = None
                Transport = None
                TransportAddress = None
                Attributes = None
                Discovery = None
                IndexingPressure = None
                Indices = None
            }

        [<CustomOperation("adaptiveSelection")>]
        member _.AdaptiveSelection(state: Stats, value: Map<string, NodesTypes.AdaptiveSelection>) =
            { state with AdaptiveSelection = Some value }

        [<CustomOperation("breakers")>]
        member _.Breakers(state: Stats, value: Map<string, NodesTypes.Breaker>) =
            { state with Breakers = Some value }

        [<CustomOperation("fs")>]
        member _.Fs(state: Stats, value: NodesTypes.FileSystem) =
            { state with Fs = Some value }

        [<CustomOperation("host")>]
        member _.Host(state: Stats, value: CoreTypes.Host) =
            { state with Host = Some value }

        [<CustomOperation("http")>]
        member _.Http(state: Stats, value: NodesTypes.Http) =
            { state with Http = Some value }

        [<CustomOperation("ingest")>]
        member _.Ingest(state: Stats, value: NodesTypes.Ingest) =
            { state with Ingest = Some value }

        [<CustomOperation("ip")>]
        member _.Ip(state: Stats, value: System.Text.Json.JsonElement) =
            { state with Ip = Some value }

        [<CustomOperation("jvm")>]
        member _.Jvm(state: Stats, value: NodesTypes.Jvm) =
            { state with Jvm = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Stats, value: CoreTypes.Name) =
            { state with Name = Some value }

        [<CustomOperation("os")>]
        member _.Os(state: Stats, value: NodesTypes.OperatingSystem) =
            { state with Os = Some value }

        [<CustomOperation("process")>]
        member _.Process(state: Stats, value: NodesTypes.Process) =
            { state with Process = Some value }

        [<CustomOperation("roles")>]
        member _.Roles(state: Stats, value: CoreTypes.NodeRoles) =
            { state with Roles = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Stats, value: NodesTypes.Scripting) =
            { state with Script = Some value }

        [<CustomOperation("scriptCache")>]
        member _.ScriptCache(state: Stats, value: Map<string, System.Text.Json.JsonElement>) =
            { state with ScriptCache = Some value }

        [<CustomOperation("threadPool")>]
        member _.ThreadPool(state: Stats, value: Map<string, NodesTypes.ThreadCount>) =
            { state with ThreadPool = Some value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: Stats, value: CoreTypes.Long) =
            { state with Timestamp = Some value }

        [<CustomOperation("transport")>]
        member _.Transport(state: Stats, value: NodesTypes.Transport) =
            { state with Transport = Some value }

        [<CustomOperation("transportAddress")>]
        member _.TransportAddress(state: Stats, value: CoreTypes.TransportAddress) =
            { state with TransportAddress = Some value }

        [<CustomOperation("attributes")>]
        member _.Attributes(state: Stats, value: Map<CoreTypes.Field, string>) =
            { state with Attributes = Some value }

        [<CustomOperation("discovery")>]
        member _.Discovery(state: Stats, value: NodesTypes.Discovery) =
            { state with Discovery = Some value }

        [<CustomOperation("indexingPressure")>]
        member _.IndexingPressure(state: Stats, value: NodesTypes.IndexingPressure) =
            { state with IndexingPressure = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Stats, value: IndicesStats.ShardStats) =
            { state with Indices = Some value }

    let stats = StatsBuilder()

    type ThreadCountBuilder() =
        member _.Yield(_: unit) : ThreadCount =
            {
                Active = None
                Completed = None
                Largest = None
                Queue = None
                Rejected = None
                Threads = None
            }

        [<CustomOperation("active")>]
        member _.Active(state: ThreadCount, value: CoreTypes.Long) =
            { state with Active = Some value }

        [<CustomOperation("completed")>]
        member _.Completed(state: ThreadCount, value: CoreTypes.Long) =
            { state with Completed = Some value }

        [<CustomOperation("largest")>]
        member _.Largest(state: ThreadCount, value: CoreTypes.Long) =
            { state with Largest = Some value }

        [<CustomOperation("queue")>]
        member _.Queue(state: ThreadCount, value: CoreTypes.Long) =
            { state with Queue = Some value }

        [<CustomOperation("rejected")>]
        member _.Rejected(state: ThreadCount, value: CoreTypes.Long) =
            { state with Rejected = Some value }

        [<CustomOperation("threads")>]
        member _.Threads(state: ThreadCount, value: CoreTypes.Long) =
            { state with Threads = Some value }

    let threadCount = ThreadCountBuilder()

    type TimeHttpHistogramBuilder() =
        member _.Yield(_: unit) : TimeHttpHistogram =
            {
                Count = Unchecked.defaultof<_>
                GeMillis = None
                LtMillis = None
            }

        [<CustomOperation("count")>]
        member _.Count(state: TimeHttpHistogram, value: CoreTypes.Long) =
            { state with Count = value }

        [<CustomOperation("geMillis")>]
        member _.GeMillis(state: TimeHttpHistogram, value: CoreTypes.Long) =
            { state with GeMillis = Some value }

        [<CustomOperation("ltMillis")>]
        member _.LtMillis(state: TimeHttpHistogram, value: CoreTypes.Long) =
            { state with LtMillis = Some value }

    let timeHttpHistogram = TimeHttpHistogramBuilder()

    type TransportBuilder() =
        member _.Yield(_: unit) : Transport =
            {
                InboundHandlingTimeHistogram = None
                OutboundHandlingTimeHistogram = None
                RxCount = None
                RxSize = None
                RxSizeInBytes = None
                ServerOpen = None
                TxCount = None
                TxSize = None
                TxSizeInBytes = None
                TotalOutboundConnections = None
            }

        [<CustomOperation("inboundHandlingTimeHistogram")>]
        member _.InboundHandlingTimeHistogram(state: Transport, value: NodesTypes.TransportHistogram list) =
            { state with InboundHandlingTimeHistogram = Some value }

        [<CustomOperation("outboundHandlingTimeHistogram")>]
        member _.OutboundHandlingTimeHistogram(state: Transport, value: NodesTypes.TransportHistogram list) =
            { state with OutboundHandlingTimeHistogram = Some value }

        [<CustomOperation("rxCount")>]
        member _.RxCount(state: Transport, value: CoreTypes.Long) =
            { state with RxCount = Some value }

        [<CustomOperation("rxSize")>]
        member _.RxSize(state: Transport, value: string) =
            { state with RxSize = Some value }

        [<CustomOperation("rxSizeInBytes")>]
        member _.RxSizeInBytes(state: Transport, value: CoreTypes.Long) =
            { state with RxSizeInBytes = Some value }

        [<CustomOperation("serverOpen")>]
        member _.ServerOpen(state: Transport, value: CoreTypes.Integer) =
            { state with ServerOpen = Some value }

        [<CustomOperation("txCount")>]
        member _.TxCount(state: Transport, value: CoreTypes.Long) =
            { state with TxCount = Some value }

        [<CustomOperation("txSize")>]
        member _.TxSize(state: Transport, value: string) =
            { state with TxSize = Some value }

        [<CustomOperation("txSizeInBytes")>]
        member _.TxSizeInBytes(state: Transport, value: CoreTypes.Long) =
            { state with TxSizeInBytes = Some value }

        [<CustomOperation("totalOutboundConnections")>]
        member _.TotalOutboundConnections(state: Transport, value: CoreTypes.Long) =
            { state with TotalOutboundConnections = Some value }

    let transport = TransportBuilder()

    type TransportHistogramBuilder() =
        member _.Yield(_: unit) : TransportHistogram =
            {
                Count = None
                LtMillis = None
                GeMillis = None
            }

        [<CustomOperation("count")>]
        member _.Count(state: TransportHistogram, value: CoreTypes.Long) =
            { state with Count = Some value }

        [<CustomOperation("ltMillis")>]
        member _.LtMillis(state: TransportHistogram, value: CoreTypes.Long) =
            { state with LtMillis = Some value }

        [<CustomOperation("geMillis")>]
        member _.GeMillis(state: TransportHistogram, value: CoreTypes.Long) =
            { state with GeMillis = Some value }

    let transportHistogram = TransportHistogramBuilder()


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module NodesTypesBuilders =

    type AdaptiveSelectionBuilder() =
        member _.Yield(_: unit) : Types.AdaptiveSelection =
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
        member _.AvgQueueSize(state: Types.AdaptiveSelection, value: Types.Long) =
            { state with AvgQueueSize = Some value }

        [<CustomOperation("avgResponseTime")>]
        member _.AvgResponseTime(state: Types.AdaptiveSelection, value: Types.Duration) =
            { state with AvgResponseTime = Some value }

        [<CustomOperation("avgResponseTimeNs")>]
        member _.AvgResponseTimeNs(state: Types.AdaptiveSelection, value: Types.Long) =
            { state with AvgResponseTimeNs = Some value }

        [<CustomOperation("avgServiceTime")>]
        member _.AvgServiceTime(state: Types.AdaptiveSelection, value: Types.Duration) =
            { state with AvgServiceTime = Some value }

        [<CustomOperation("avgServiceTimeNs")>]
        member _.AvgServiceTimeNs(state: Types.AdaptiveSelection, value: Types.Long) =
            { state with AvgServiceTimeNs = Some value }

        [<CustomOperation("outgoingSearches")>]
        member _.OutgoingSearches(state: Types.AdaptiveSelection, value: Types.Long) =
            { state with OutgoingSearches = Some value }

        [<CustomOperation("rank")>]
        member _.Rank(state: Types.AdaptiveSelection, value: string) =
            { state with Rank = Some value }

    let adaptiveSelection = AdaptiveSelectionBuilder()

    type BreakerBuilder() =
        member _.Yield(_: unit) : Types.Breaker =
            {
                EstimatedSize = None
                EstimatedSizeInBytes = None
                LimitSize = None
                LimitSizeInBytes = None
                Overhead = None
                Tripped = None
            }

        [<CustomOperation("estimatedSize")>]
        member _.EstimatedSize(state: Types.Breaker, value: string) =
            { state with EstimatedSize = Some value }

        [<CustomOperation("estimatedSizeInBytes")>]
        member _.EstimatedSizeInBytes(state: Types.Breaker, value: Types.Long) =
            { state with EstimatedSizeInBytes = Some value }

        [<CustomOperation("limitSize")>]
        member _.LimitSize(state: Types.Breaker, value: string) =
            { state with LimitSize = Some value }

        [<CustomOperation("limitSizeInBytes")>]
        member _.LimitSizeInBytes(state: Types.Breaker, value: Types.Long) =
            { state with LimitSizeInBytes = Some value }

        [<CustomOperation("overhead")>]
        member _.Overhead(state: Types.Breaker, value: Types.Float) =
            { state with Overhead = Some value }

        [<CustomOperation("tripped")>]
        member _.Tripped(state: Types.Breaker, value: Types.Float) =
            { state with Tripped = Some value }

    let breaker = BreakerBuilder()

    type CgroupBuilder() =
        member _.Yield(_: unit) : Types.Cgroup =
            {
                Cpuacct = None
                Cpu = None
                Memory = None
            }

        [<CustomOperation("cpuacct")>]
        member _.Cpuacct(state: Types.Cgroup, value: Types.CpuAcct) =
            { state with Cpuacct = Some value }

        [<CustomOperation("cpu")>]
        member _.Cpu(state: Types.Cgroup, value: Types.CgroupCpu) =
            { state with Cpu = Some value }

        [<CustomOperation("memory")>]
        member _.Memory(state: Types.Cgroup, value: Types.CgroupMemory) =
            { state with Memory = Some value }

    let cgroup = CgroupBuilder()

    type CgroupCpuBuilder() =
        member _.Yield(_: unit) : Types.CgroupCpu =
            {
                ControlGroup = None
                CfsPeriodMicros = None
                CfsQuotaMicros = None
                Stat = None
            }

        [<CustomOperation("controlGroup")>]
        member _.ControlGroup(state: Types.CgroupCpu, value: string) =
            { state with ControlGroup = Some value }

        [<CustomOperation("cfsPeriodMicros")>]
        member _.CfsPeriodMicros(state: Types.CgroupCpu, value: Types.Integer) =
            { state with CfsPeriodMicros = Some value }

        [<CustomOperation("cfsQuotaMicros")>]
        member _.CfsQuotaMicros(state: Types.CgroupCpu, value: Types.Integer) =
            { state with CfsQuotaMicros = Some value }

        [<CustomOperation("stat")>]
        member _.Stat(state: Types.CgroupCpu, value: Types.CgroupCpuStat) =
            { state with Stat = Some value }

    let cgroupCpu = CgroupCpuBuilder()

    type CgroupCpuStatBuilder() =
        member _.Yield(_: unit) : Types.CgroupCpuStat =
            {
                NumberOfElapsedPeriods = None
                NumberOfTimesThrottled = None
                TimeThrottledNanos = None
            }

        [<CustomOperation("numberOfElapsedPeriods")>]
        member _.NumberOfElapsedPeriods(state: Types.CgroupCpuStat, value: Types.Long) =
            { state with NumberOfElapsedPeriods = Some value }

        [<CustomOperation("numberOfTimesThrottled")>]
        member _.NumberOfTimesThrottled(state: Types.CgroupCpuStat, value: Types.Long) =
            { state with NumberOfTimesThrottled = Some value }

        [<CustomOperation("timeThrottledNanos")>]
        member _.TimeThrottledNanos(state: Types.CgroupCpuStat, value: Types.DurationValue<Types.UnitNanos>) =
            { state with TimeThrottledNanos = Some value }

    let cgroupCpuStat = CgroupCpuStatBuilder()

    type CgroupMemoryBuilder() =
        member _.Yield(_: unit) : Types.CgroupMemory =
            {
                ControlGroup = None
                LimitInBytes = None
                UsageInBytes = None
            }

        [<CustomOperation("controlGroup")>]
        member _.ControlGroup(state: Types.CgroupMemory, value: string) =
            { state with ControlGroup = Some value }

        [<CustomOperation("limitInBytes")>]
        member _.LimitInBytes(state: Types.CgroupMemory, value: string) =
            { state with LimitInBytes = Some value }

        [<CustomOperation("usageInBytes")>]
        member _.UsageInBytes(state: Types.CgroupMemory, value: string) =
            { state with UsageInBytes = Some value }

    let cgroupMemory = CgroupMemoryBuilder()

    type ClientBuilder() =
        member _.Yield(_: unit) : Types.Client =
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
        member _.Id(state: Types.Client, value: Types.Long) =
            { state with Id = Some value }

        [<CustomOperation("agent")>]
        member _.Agent(state: Types.Client, value: string) =
            { state with Agent = Some value }

        [<CustomOperation("localAddress")>]
        member _.LocalAddress(state: Types.Client, value: string) =
            { state with LocalAddress = Some value }

        [<CustomOperation("remoteAddress")>]
        member _.RemoteAddress(state: Types.Client, value: string) =
            { state with RemoteAddress = Some value }

        [<CustomOperation("lastUri")>]
        member _.LastUri(state: Types.Client, value: string) =
            { state with LastUri = Some value }

        [<CustomOperation("openedTimeMillis")>]
        member _.OpenedTimeMillis(state: Types.Client, value: Types.Long) =
            { state with OpenedTimeMillis = Some value }

        [<CustomOperation("closedTimeMillis")>]
        member _.ClosedTimeMillis(state: Types.Client, value: Types.Long) =
            { state with ClosedTimeMillis = Some value }

        [<CustomOperation("lastRequestTimeMillis")>]
        member _.LastRequestTimeMillis(state: Types.Client, value: Types.Long) =
            { state with LastRequestTimeMillis = Some value }

        [<CustomOperation("requestCount")>]
        member _.RequestCount(state: Types.Client, value: Types.Long) =
            { state with RequestCount = Some value }

        [<CustomOperation("requestSizeBytes")>]
        member _.RequestSizeBytes(state: Types.Client, value: Types.Long) =
            { state with RequestSizeBytes = Some value }

        [<CustomOperation("xOpaqueId")>]
        member _.XOpaqueId(state: Types.Client, value: string) =
            { state with XOpaqueId = Some value }

    let client = ClientBuilder()

    type ClusterStateQueueBuilder() =
        member _.Yield(_: unit) : Types.ClusterStateQueue =
            {
                Total = None
                Pending = None
                Committed = None
            }

        [<CustomOperation("total")>]
        member _.Total(state: Types.ClusterStateQueue, value: Types.Long) =
            { state with Total = Some value }

        [<CustomOperation("pending")>]
        member _.Pending(state: Types.ClusterStateQueue, value: Types.Long) =
            { state with Pending = Some value }

        [<CustomOperation("committed")>]
        member _.Committed(state: Types.ClusterStateQueue, value: Types.Long) =
            { state with Committed = Some value }

    let clusterStateQueue = ClusterStateQueueBuilder()

    type ClusterStateUpdateBuilder() =
        member _.Yield(_: unit) : Types.ClusterStateUpdate =
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
        member _.Count(state: Types.ClusterStateUpdate, value: Types.Long) =
            { state with Count = value }

        [<CustomOperation("computationTime")>]
        member _.ComputationTime(state: Types.ClusterStateUpdate, value: Types.Duration) =
            { state with ComputationTime = Some value }

        [<CustomOperation("computationTimeMillis")>]
        member _.ComputationTimeMillis(state: Types.ClusterStateUpdate, value: Types.DurationValue<Types.UnitMillis>) =
            { state with ComputationTimeMillis = Some value }

        [<CustomOperation("publicationTime")>]
        member _.PublicationTime(state: Types.ClusterStateUpdate, value: Types.Duration) =
            { state with PublicationTime = Some value }

        [<CustomOperation("publicationTimeMillis")>]
        member _.PublicationTimeMillis(state: Types.ClusterStateUpdate, value: Types.DurationValue<Types.UnitMillis>) =
            { state with PublicationTimeMillis = Some value }

        [<CustomOperation("contextConstructionTime")>]
        member _.ContextConstructionTime(state: Types.ClusterStateUpdate, value: Types.Duration) =
            { state with ContextConstructionTime = Some value }

        [<CustomOperation("contextConstructionTimeMillis")>]
        member _.ContextConstructionTimeMillis(state: Types.ClusterStateUpdate, value: Types.DurationValue<Types.UnitMillis>) =
            { state with ContextConstructionTimeMillis = Some value }

        [<CustomOperation("commitTime")>]
        member _.CommitTime(state: Types.ClusterStateUpdate, value: Types.Duration) =
            { state with CommitTime = Some value }

        [<CustomOperation("commitTimeMillis")>]
        member _.CommitTimeMillis(state: Types.ClusterStateUpdate, value: Types.DurationValue<Types.UnitMillis>) =
            { state with CommitTimeMillis = Some value }

        [<CustomOperation("completionTime")>]
        member _.CompletionTime(state: Types.ClusterStateUpdate, value: Types.Duration) =
            { state with CompletionTime = Some value }

        [<CustomOperation("completionTimeMillis")>]
        member _.CompletionTimeMillis(state: Types.ClusterStateUpdate, value: Types.DurationValue<Types.UnitMillis>) =
            { state with CompletionTimeMillis = Some value }

        [<CustomOperation("masterApplyTime")>]
        member _.MasterApplyTime(state: Types.ClusterStateUpdate, value: Types.Duration) =
            { state with MasterApplyTime = Some value }

        [<CustomOperation("masterApplyTimeMillis")>]
        member _.MasterApplyTimeMillis(state: Types.ClusterStateUpdate, value: Types.DurationValue<Types.UnitMillis>) =
            { state with MasterApplyTimeMillis = Some value }

        [<CustomOperation("notificationTime")>]
        member _.NotificationTime(state: Types.ClusterStateUpdate, value: Types.Duration) =
            { state with NotificationTime = Some value }

        [<CustomOperation("notificationTimeMillis")>]
        member _.NotificationTimeMillis(state: Types.ClusterStateUpdate, value: Types.DurationValue<Types.UnitMillis>) =
            { state with NotificationTimeMillis = Some value }

    let clusterStateUpdate = ClusterStateUpdateBuilder()

    type NodesTypesContextBuilder() =
        member _.Yield(_: unit) : Types.NodesTypesContext =
            {
                Context = None
                Compilations = None
                CacheEvictions = None
                CompilationLimitTriggered = None
            }

        [<CustomOperation("context")>]
        member _.Context(state: Types.NodesTypesContext, value: string) =
            { state with Context = Some value }

        [<CustomOperation("compilations")>]
        member _.Compilations(state: Types.NodesTypesContext, value: Types.Long) =
            { state with Compilations = Some value }

        [<CustomOperation("cacheEvictions")>]
        member _.CacheEvictions(state: Types.NodesTypesContext, value: Types.Long) =
            { state with CacheEvictions = Some value }

        [<CustomOperation("compilationLimitTriggered")>]
        member _.CompilationLimitTriggered(state: Types.NodesTypesContext, value: Types.Long) =
            { state with CompilationLimitTriggered = Some value }

    let nodesTypesContext = NodesTypesContextBuilder()

    type CpuBuilder() =
        member _.Yield(_: unit) : Types.Cpu =
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
        member _.Percent(state: Types.Cpu, value: Types.Integer) =
            { state with Percent = Some value }

        [<CustomOperation("sys")>]
        member _.Sys(state: Types.Cpu, value: Types.Duration) =
            { state with Sys = Some value }

        [<CustomOperation("sysInMillis")>]
        member _.SysInMillis(state: Types.Cpu, value: Types.DurationValue<Types.UnitMillis>) =
            { state with SysInMillis = Some value }

        [<CustomOperation("total")>]
        member _.Total(state: Types.Cpu, value: Types.Duration) =
            { state with Total = Some value }

        [<CustomOperation("totalInMillis")>]
        member _.TotalInMillis(state: Types.Cpu, value: Types.DurationValue<Types.UnitMillis>) =
            { state with TotalInMillis = Some value }

        [<CustomOperation("user")>]
        member _.User(state: Types.Cpu, value: Types.Duration) =
            { state with User = Some value }

        [<CustomOperation("userInMillis")>]
        member _.UserInMillis(state: Types.Cpu, value: Types.DurationValue<Types.UnitMillis>) =
            { state with UserInMillis = Some value }

        [<CustomOperation("loadAverage")>]
        member _.LoadAverage(state: Types.Cpu, value: Map<string, Types.Double>) =
            { state with LoadAverage = Some value }

    let cpu = CpuBuilder()

    type CpuAcctBuilder() =
        member _.Yield(_: unit) : Types.CpuAcct =
            {
                ControlGroup = None
                UsageNanos = None
            }

        [<CustomOperation("controlGroup")>]
        member _.ControlGroup(state: Types.CpuAcct, value: string) =
            { state with ControlGroup = Some value }

        [<CustomOperation("usageNanos")>]
        member _.UsageNanos(state: Types.CpuAcct, value: Types.DurationValue<Types.UnitNanos>) =
            { state with UsageNanos = Some value }

    let cpuAcct = CpuAcctBuilder()

    type DataPathStatsBuilder() =
        member _.Yield(_: unit) : Types.DataPathStats =
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
        member _.Available(state: Types.DataPathStats, value: string) =
            { state with Available = Some value }

        [<CustomOperation("availableInBytes")>]
        member _.AvailableInBytes(state: Types.DataPathStats, value: Types.Long) =
            { state with AvailableInBytes = Some value }

        [<CustomOperation("diskQueue")>]
        member _.DiskQueue(state: Types.DataPathStats, value: string) =
            { state with DiskQueue = Some value }

        [<CustomOperation("diskReads")>]
        member _.DiskReads(state: Types.DataPathStats, value: Types.Long) =
            { state with DiskReads = Some value }

        [<CustomOperation("diskReadSize")>]
        member _.DiskReadSize(state: Types.DataPathStats, value: string) =
            { state with DiskReadSize = Some value }

        [<CustomOperation("diskReadSizeInBytes")>]
        member _.DiskReadSizeInBytes(state: Types.DataPathStats, value: Types.Long) =
            { state with DiskReadSizeInBytes = Some value }

        [<CustomOperation("diskWrites")>]
        member _.DiskWrites(state: Types.DataPathStats, value: Types.Long) =
            { state with DiskWrites = Some value }

        [<CustomOperation("diskWriteSize")>]
        member _.DiskWriteSize(state: Types.DataPathStats, value: string) =
            { state with DiskWriteSize = Some value }

        [<CustomOperation("diskWriteSizeInBytes")>]
        member _.DiskWriteSizeInBytes(state: Types.DataPathStats, value: Types.Long) =
            { state with DiskWriteSizeInBytes = Some value }

        [<CustomOperation("free")>]
        member _.Free(state: Types.DataPathStats, value: string) =
            { state with Free = Some value }

        [<CustomOperation("freeInBytes")>]
        member _.FreeInBytes(state: Types.DataPathStats, value: Types.Long) =
            { state with FreeInBytes = Some value }

        [<CustomOperation("mount")>]
        member _.Mount(state: Types.DataPathStats, value: string) =
            { state with Mount = Some value }

        [<CustomOperation("path")>]
        member _.Path(state: Types.DataPathStats, value: string) =
            { state with Path = Some value }

        [<CustomOperation("total")>]
        member _.Total(state: Types.DataPathStats, value: string) =
            { state with Total = Some value }

        [<CustomOperation("totalInBytes")>]
        member _.TotalInBytes(state: Types.DataPathStats, value: Types.Long) =
            { state with TotalInBytes = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.DataPathStats, value: string) =
            { state with Type = Some value }

    let dataPathStats = DataPathStatsBuilder()

    type DiscoveryBuilder() =
        member _.Yield(_: unit) : Types.Discovery =
            {
                ClusterStateQueue = None
                PublishedClusterStates = None
                ClusterStateUpdate = None
                SerializedClusterStates = None
                ClusterApplierStats = None
            }

        [<CustomOperation("clusterStateQueue")>]
        member _.ClusterStateQueue(state: Types.Discovery, value: Types.ClusterStateQueue) =
            { state with ClusterStateQueue = Some value }

        [<CustomOperation("publishedClusterStates")>]
        member _.PublishedClusterStates(state: Types.Discovery, value: Types.PublishedClusterStates) =
            { state with PublishedClusterStates = Some value }

        [<CustomOperation("clusterStateUpdate")>]
        member _.ClusterStateUpdate(state: Types.Discovery, value: Map<string, Types.ClusterStateUpdate>) =
            { state with ClusterStateUpdate = Some value }

        [<CustomOperation("serializedClusterStates")>]
        member _.SerializedClusterStates(state: Types.Discovery, value: Types.SerializedClusterState) =
            { state with SerializedClusterStates = Some value }

        [<CustomOperation("clusterApplierStats")>]
        member _.ClusterApplierStats(state: Types.Discovery, value: Types.ClusterAppliedStats) =
            { state with ClusterApplierStats = Some value }

    let discovery = DiscoveryBuilder()

    type ExtendedMemoryStatsBuilder() =
        member _.Yield(_: unit) : Types.ExtendedMemoryStats =
            {
                FreePercent = None
                UsedPercent = None
            }

        [<CustomOperation("freePercent")>]
        member _.FreePercent(state: Types.ExtendedMemoryStats, value: Types.Integer) =
            { state with FreePercent = Some value }

        [<CustomOperation("usedPercent")>]
        member _.UsedPercent(state: Types.ExtendedMemoryStats, value: Types.Integer) =
            { state with UsedPercent = Some value }

    let extendedMemoryStats = ExtendedMemoryStatsBuilder()

    type FileSystemBuilder() =
        member _.Yield(_: unit) : Types.FileSystem =
            {
                Data = None
                Timestamp = None
                Total = None
                IoStats = None
            }

        [<CustomOperation("data")>]
        member _.Data(state: Types.FileSystem, value: Types.DataPathStats list) =
            { state with Data = Some value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: Types.FileSystem, value: Types.Long) =
            { state with Timestamp = Some value }

        [<CustomOperation("total")>]
        member _.Total(state: Types.FileSystem, value: Types.FileSystemTotal) =
            { state with Total = Some value }

        [<CustomOperation("ioStats")>]
        member _.IoStats(state: Types.FileSystem, value: Types.IoStats) =
            { state with IoStats = Some value }

    let fileSystem = FileSystemBuilder()

    type FileSystemTotalBuilder() =
        member _.Yield(_: unit) : Types.FileSystemTotal =
            {
                Available = None
                AvailableInBytes = None
                Free = None
                FreeInBytes = None
                Total = None
                TotalInBytes = None
            }

        [<CustomOperation("available")>]
        member _.Available(state: Types.FileSystemTotal, value: string) =
            { state with Available = Some value }

        [<CustomOperation("availableInBytes")>]
        member _.AvailableInBytes(state: Types.FileSystemTotal, value: Types.Long) =
            { state with AvailableInBytes = Some value }

        [<CustomOperation("free")>]
        member _.Free(state: Types.FileSystemTotal, value: string) =
            { state with Free = Some value }

        [<CustomOperation("freeInBytes")>]
        member _.FreeInBytes(state: Types.FileSystemTotal, value: Types.Long) =
            { state with FreeInBytes = Some value }

        [<CustomOperation("total")>]
        member _.Total(state: Types.FileSystemTotal, value: string) =
            { state with Total = Some value }

        [<CustomOperation("totalInBytes")>]
        member _.TotalInBytes(state: Types.FileSystemTotal, value: Types.Long) =
            { state with TotalInBytes = Some value }

    let fileSystemTotal = FileSystemTotalBuilder()

    type GarbageCollectorTotalBuilder() =
        member _.Yield(_: unit) : Types.GarbageCollectorTotal =
            {
                CollectionCount = None
                CollectionTime = None
                CollectionTimeInMillis = None
            }

        [<CustomOperation("collectionCount")>]
        member _.CollectionCount(state: Types.GarbageCollectorTotal, value: Types.Long) =
            { state with CollectionCount = Some value }

        [<CustomOperation("collectionTime")>]
        member _.CollectionTime(state: Types.GarbageCollectorTotal, value: string) =
            { state with CollectionTime = Some value }

        [<CustomOperation("collectionTimeInMillis")>]
        member _.CollectionTimeInMillis(state: Types.GarbageCollectorTotal, value: Types.Long) =
            { state with CollectionTimeInMillis = Some value }

    let garbageCollectorTotal = GarbageCollectorTotalBuilder()

    type HttpBuilder() =
        member _.Yield(_: unit) : Types.Http =
            {
                CurrentOpen = None
                TotalOpened = None
                Clients = None
                Routes = Unchecked.defaultof<_>
            }

        [<CustomOperation("currentOpen")>]
        member _.CurrentOpen(state: Types.Http, value: Types.Integer) =
            { state with CurrentOpen = Some value }

        [<CustomOperation("totalOpened")>]
        member _.TotalOpened(state: Types.Http, value: Types.Long) =
            { state with TotalOpened = Some value }

        [<CustomOperation("clients")>]
        member _.Clients(state: Types.Http, value: Types.Client list) =
            { state with Clients = Some value }

        [<CustomOperation("routes")>]
        member _.Routes(state: Types.Http, value: Map<string, Types.HttpRoute>) =
            { state with Routes = value }

    let http = HttpBuilder()

    type NodesTypesIndexingPressureMemoryBuilder() =
        member _.Yield(_: unit) : Types.NodesTypesIndexingPressureMemory =
            {
                Limit = None
                LimitInBytes = None
                Current = None
                Total = None
            }

        [<CustomOperation("limit")>]
        member _.Limit(state: Types.NodesTypesIndexingPressureMemory, value: Types.ByteSize) =
            { state with Limit = Some value }

        [<CustomOperation("limitInBytes")>]
        member _.LimitInBytes(state: Types.NodesTypesIndexingPressureMemory, value: Types.Long) =
            { state with LimitInBytes = Some value }

        [<CustomOperation("current")>]
        member _.Current(state: Types.NodesTypesIndexingPressureMemory, value: Types.PressureMemory) =
            { state with Current = Some value }

        [<CustomOperation("total")>]
        member _.Total(state: Types.NodesTypesIndexingPressureMemory, value: Types.PressureMemory) =
            { state with Total = Some value }

    let nodesTypesIndexingPressureMemory = NodesTypesIndexingPressureMemoryBuilder()

    type NodesTypesIngestBuilder() =
        member _.Yield(_: unit) : Types.NodesTypesIngest =
            {
                Pipelines = None
                Total = None
            }

        [<CustomOperation("pipelines")>]
        member _.Pipelines(state: Types.NodesTypesIngest, value: Map<string, Types.IngestStats>) =
            { state with Pipelines = Some value }

        [<CustomOperation("total")>]
        member _.Total(state: Types.NodesTypesIngest, value: Types.IngestTotal) =
            { state with Total = Some value }

    let nodesTypesIngest = NodesTypesIngestBuilder()

    type IoStatDeviceBuilder() =
        member _.Yield(_: unit) : Types.IoStatDevice =
            {
                DeviceName = None
                Operations = None
                ReadKilobytes = None
                ReadOperations = None
                WriteKilobytes = None
                WriteOperations = None
            }

        [<CustomOperation("deviceName")>]
        member _.DeviceName(state: Types.IoStatDevice, value: string) =
            { state with DeviceName = Some value }

        [<CustomOperation("operations")>]
        member _.Operations(state: Types.IoStatDevice, value: Types.Long) =
            { state with Operations = Some value }

        [<CustomOperation("readKilobytes")>]
        member _.ReadKilobytes(state: Types.IoStatDevice, value: Types.Long) =
            { state with ReadKilobytes = Some value }

        [<CustomOperation("readOperations")>]
        member _.ReadOperations(state: Types.IoStatDevice, value: Types.Long) =
            { state with ReadOperations = Some value }

        [<CustomOperation("writeKilobytes")>]
        member _.WriteKilobytes(state: Types.IoStatDevice, value: Types.Long) =
            { state with WriteKilobytes = Some value }

        [<CustomOperation("writeOperations")>]
        member _.WriteOperations(state: Types.IoStatDevice, value: Types.Long) =
            { state with WriteOperations = Some value }

    let ioStatDevice = IoStatDeviceBuilder()

    type IoStatsBuilder() =
        member _.Yield(_: unit) : Types.IoStats =
            {
                Devices = None
                Total = None
            }

        [<CustomOperation("devices")>]
        member _.Devices(state: Types.IoStats, value: Types.IoStatDevice list) =
            { state with Devices = Some value }

        [<CustomOperation("total")>]
        member _.Total(state: Types.IoStats, value: Types.IoStatDevice) =
            { state with Total = Some value }

    let ioStats = IoStatsBuilder()

    type JvmBuilder() =
        member _.Yield(_: unit) : Types.Jvm =
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
        member _.BufferPools(state: Types.Jvm, value: Map<string, Types.NodeBufferPool>) =
            { state with BufferPools = Some value }

        [<CustomOperation("classes")>]
        member _.Classes(state: Types.Jvm, value: Types.JvmClasses) =
            { state with Classes = Some value }

        [<CustomOperation("gc")>]
        member _.Gc(state: Types.Jvm, value: Types.GarbageCollector) =
            { state with Gc = Some value }

        [<CustomOperation("mem")>]
        member _.Mem(state: Types.Jvm, value: Types.JvmMemoryStats) =
            { state with Mem = Some value }

        [<CustomOperation("threads")>]
        member _.Threads(state: Types.Jvm, value: Types.JvmThreads) =
            { state with Threads = Some value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: Types.Jvm, value: Types.Long) =
            { state with Timestamp = Some value }

        [<CustomOperation("uptime")>]
        member _.Uptime(state: Types.Jvm, value: string) =
            { state with Uptime = Some value }

        [<CustomOperation("uptimeInMillis")>]
        member _.UptimeInMillis(state: Types.Jvm, value: Types.Long) =
            { state with UptimeInMillis = Some value }

    let jvm = JvmBuilder()

    type JvmClassesBuilder() =
        member _.Yield(_: unit) : Types.JvmClasses =
            {
                CurrentLoadedCount = None
                TotalLoadedCount = None
                TotalUnloadedCount = None
            }

        [<CustomOperation("currentLoadedCount")>]
        member _.CurrentLoadedCount(state: Types.JvmClasses, value: Types.Long) =
            { state with CurrentLoadedCount = Some value }

        [<CustomOperation("totalLoadedCount")>]
        member _.TotalLoadedCount(state: Types.JvmClasses, value: Types.Long) =
            { state with TotalLoadedCount = Some value }

        [<CustomOperation("totalUnloadedCount")>]
        member _.TotalUnloadedCount(state: Types.JvmClasses, value: Types.Long) =
            { state with TotalUnloadedCount = Some value }

    let jvmClasses = JvmClassesBuilder()

    type JvmMemoryStatsBuilder() =
        member _.Yield(_: unit) : Types.JvmMemoryStats =
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
        member _.HeapUsedInBytes(state: Types.JvmMemoryStats, value: Types.Long) =
            { state with HeapUsedInBytes = Some value }

        [<CustomOperation("heapUsedPercent")>]
        member _.HeapUsedPercent(state: Types.JvmMemoryStats, value: Types.Long) =
            { state with HeapUsedPercent = Some value }

        [<CustomOperation("heapCommittedInBytes")>]
        member _.HeapCommittedInBytes(state: Types.JvmMemoryStats, value: Types.Long) =
            { state with HeapCommittedInBytes = Some value }

        [<CustomOperation("heapMaxInBytes")>]
        member _.HeapMaxInBytes(state: Types.JvmMemoryStats, value: Types.Long) =
            { state with HeapMaxInBytes = Some value }

        [<CustomOperation("heapMax")>]
        member _.HeapMax(state: Types.JvmMemoryStats, value: Types.ByteSize) =
            { state with HeapMax = Some value }

        [<CustomOperation("nonHeapUsedInBytes")>]
        member _.NonHeapUsedInBytes(state: Types.JvmMemoryStats, value: Types.Long) =
            { state with NonHeapUsedInBytes = Some value }

        [<CustomOperation("nonHeapCommittedInBytes")>]
        member _.NonHeapCommittedInBytes(state: Types.JvmMemoryStats, value: Types.Long) =
            { state with NonHeapCommittedInBytes = Some value }

        [<CustomOperation("pools")>]
        member _.Pools(state: Types.JvmMemoryStats, value: Map<string, Types.Pool>) =
            { state with Pools = Some value }

    let jvmMemoryStats = JvmMemoryStatsBuilder()

    type JvmThreadsBuilder() =
        member _.Yield(_: unit) : Types.JvmThreads =
            {
                Count = None
                PeakCount = None
            }

        [<CustomOperation("count")>]
        member _.Count(state: Types.JvmThreads, value: Types.Long) =
            { state with Count = Some value }

        [<CustomOperation("peakCount")>]
        member _.PeakCount(state: Types.JvmThreads, value: Types.Long) =
            { state with PeakCount = Some value }

    let jvmThreads = JvmThreadsBuilder()

    type KeyedProcessorBuilder() =
        member _.Yield(_: unit) : Types.KeyedProcessor =
            {
                Stats = None
                Type = None
            }

        [<CustomOperation("stats")>]
        member _.Stats(state: Types.KeyedProcessor, value: Types.Processor) =
            { state with Stats = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.KeyedProcessor, value: string) =
            { state with Type = Some value }

    let keyedProcessor = KeyedProcessorBuilder()

    type MemoryStatsBuilder() =
        member _.Yield(_: unit) : Types.MemoryStats =
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
        member _.AdjustedTotalInBytes(state: Types.MemoryStats, value: Types.Long) =
            { state with AdjustedTotalInBytes = Some value }

        [<CustomOperation("resident")>]
        member _.Resident(state: Types.MemoryStats, value: string) =
            { state with Resident = Some value }

        [<CustomOperation("residentInBytes")>]
        member _.ResidentInBytes(state: Types.MemoryStats, value: Types.Long) =
            { state with ResidentInBytes = Some value }

        [<CustomOperation("share")>]
        member _.Share(state: Types.MemoryStats, value: string) =
            { state with Share = Some value }

        [<CustomOperation("shareInBytes")>]
        member _.ShareInBytes(state: Types.MemoryStats, value: Types.Long) =
            { state with ShareInBytes = Some value }

        [<CustomOperation("totalVirtual")>]
        member _.TotalVirtual(state: Types.MemoryStats, value: string) =
            { state with TotalVirtual = Some value }

        [<CustomOperation("totalVirtualInBytes")>]
        member _.TotalVirtualInBytes(state: Types.MemoryStats, value: Types.Long) =
            { state with TotalVirtualInBytes = Some value }

        [<CustomOperation("totalInBytes")>]
        member _.TotalInBytes(state: Types.MemoryStats, value: Types.Long) =
            { state with TotalInBytes = Some value }

        [<CustomOperation("freeInBytes")>]
        member _.FreeInBytes(state: Types.MemoryStats, value: Types.Long) =
            { state with FreeInBytes = Some value }

        [<CustomOperation("usedInBytes")>]
        member _.UsedInBytes(state: Types.MemoryStats, value: Types.Long) =
            { state with UsedInBytes = Some value }

    let memoryStats = MemoryStatsBuilder()

    type NodeBufferPoolBuilder() =
        member _.Yield(_: unit) : Types.NodeBufferPool =
            {
                Count = None
                TotalCapacity = None
                TotalCapacityInBytes = None
                Used = None
                UsedInBytes = None
            }

        [<CustomOperation("count")>]
        member _.Count(state: Types.NodeBufferPool, value: Types.Long) =
            { state with Count = Some value }

        [<CustomOperation("totalCapacity")>]
        member _.TotalCapacity(state: Types.NodeBufferPool, value: string) =
            { state with TotalCapacity = Some value }

        [<CustomOperation("totalCapacityInBytes")>]
        member _.TotalCapacityInBytes(state: Types.NodeBufferPool, value: Types.Long) =
            { state with TotalCapacityInBytes = Some value }

        [<CustomOperation("used")>]
        member _.Used(state: Types.NodeBufferPool, value: string) =
            { state with Used = Some value }

        [<CustomOperation("usedInBytes")>]
        member _.UsedInBytes(state: Types.NodeBufferPool, value: Types.Long) =
            { state with UsedInBytes = Some value }

    let nodeBufferPool = NodeBufferPoolBuilder()

    type NodeReloadResultBuilder() =
        member _.Yield(_: unit) : Types.NodeReloadResult =
            {
                Name = Unchecked.defaultof<_>
                ReloadException = None
                SecureSettingNames = None
                KeystorePath = None
                KeystoreDigest = None
                KeystoreLastModifiedTime = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: Types.NodeReloadResult, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("reloadException")>]
        member _.ReloadException(state: Types.NodeReloadResult, value: Types.ErrorCause) =
            { state with ReloadException = Some value }

        [<CustomOperation("secureSettingNames")>]
        member _.SecureSettingNames(state: Types.NodeReloadResult, value: string list) =
            { state with SecureSettingNames = Some value }

        [<CustomOperation("keystorePath")>]
        member _.KeystorePath(state: Types.NodeReloadResult, value: string) =
            { state with KeystorePath = Some value }

        [<CustomOperation("keystoreDigest")>]
        member _.KeystoreDigest(state: Types.NodeReloadResult, value: string) =
            { state with KeystoreDigest = Some value }

        [<CustomOperation("keystoreLastModifiedTime")>]
        member _.KeystoreLastModifiedTime(state: Types.NodeReloadResult, value: Types.DateTime) =
            { state with KeystoreLastModifiedTime = Some value }

    let nodeReloadResult = NodeReloadResultBuilder()

    type OperatingSystemBuilder() =
        member _.Yield(_: unit) : Types.OperatingSystem =
            {
                Cpu = None
                Mem = None
                Swap = None
                Cgroup = None
                Timestamp = None
            }

        [<CustomOperation("cpu")>]
        member _.Cpu(state: Types.OperatingSystem, value: Types.Cpu) =
            { state with Cpu = Some value }

        [<CustomOperation("mem")>]
        member _.Mem(state: Types.OperatingSystem, value: Types.ExtendedMemoryStats) =
            { state with Mem = Some value }

        [<CustomOperation("swap")>]
        member _.Swap(state: Types.OperatingSystem, value: Types.MemoryStats) =
            { state with Swap = Some value }

        [<CustomOperation("cgroup")>]
        member _.Cgroup(state: Types.OperatingSystem, value: Types.Cgroup) =
            { state with Cgroup = Some value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: Types.OperatingSystem, value: Types.Long) =
            { state with Timestamp = Some value }

    let operatingSystem = OperatingSystemBuilder()

    type PoolBuilder() =
        member _.Yield(_: unit) : Types.Pool =
            {
                UsedInBytes = None
                MaxInBytes = None
                PeakUsedInBytes = None
                PeakMaxInBytes = None
            }

        [<CustomOperation("usedInBytes")>]
        member _.UsedInBytes(state: Types.Pool, value: Types.Long) =
            { state with UsedInBytes = Some value }

        [<CustomOperation("maxInBytes")>]
        member _.MaxInBytes(state: Types.Pool, value: Types.Long) =
            { state with MaxInBytes = Some value }

        [<CustomOperation("peakUsedInBytes")>]
        member _.PeakUsedInBytes(state: Types.Pool, value: Types.Long) =
            { state with PeakUsedInBytes = Some value }

        [<CustomOperation("peakMaxInBytes")>]
        member _.PeakMaxInBytes(state: Types.Pool, value: Types.Long) =
            { state with PeakMaxInBytes = Some value }

    let pool = PoolBuilder()

    type PressureMemoryBuilder() =
        member _.Yield(_: unit) : Types.PressureMemory =
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
        member _.All(state: Types.PressureMemory, value: Types.ByteSize) =
            { state with All = Some value }

        [<CustomOperation("allInBytes")>]
        member _.AllInBytes(state: Types.PressureMemory, value: Types.Long) =
            { state with AllInBytes = Some value }

        [<CustomOperation("combinedCoordinatingAndPrimary")>]
        member _.CombinedCoordinatingAndPrimary(state: Types.PressureMemory, value: Types.ByteSize) =
            { state with CombinedCoordinatingAndPrimary = Some value }

        [<CustomOperation("combinedCoordinatingAndPrimaryInBytes")>]
        member _.CombinedCoordinatingAndPrimaryInBytes(state: Types.PressureMemory, value: Types.Long) =
            { state with CombinedCoordinatingAndPrimaryInBytes = Some value }

        [<CustomOperation("coordinating")>]
        member _.Coordinating(state: Types.PressureMemory, value: Types.ByteSize) =
            { state with Coordinating = Some value }

        [<CustomOperation("coordinatingInBytes")>]
        member _.CoordinatingInBytes(state: Types.PressureMemory, value: Types.Long) =
            { state with CoordinatingInBytes = Some value }

        [<CustomOperation("primary")>]
        member _.Primary(state: Types.PressureMemory, value: Types.ByteSize) =
            { state with Primary = Some value }

        [<CustomOperation("primaryInBytes")>]
        member _.PrimaryInBytes(state: Types.PressureMemory, value: Types.Long) =
            { state with PrimaryInBytes = Some value }

        [<CustomOperation("replica")>]
        member _.Replica(state: Types.PressureMemory, value: Types.ByteSize) =
            { state with Replica = Some value }

        [<CustomOperation("replicaInBytes")>]
        member _.ReplicaInBytes(state: Types.PressureMemory, value: Types.Long) =
            { state with ReplicaInBytes = Some value }

        [<CustomOperation("coordinatingRejections")>]
        member _.CoordinatingRejections(state: Types.PressureMemory, value: Types.Long) =
            { state with CoordinatingRejections = Some value }

        [<CustomOperation("primaryRejections")>]
        member _.PrimaryRejections(state: Types.PressureMemory, value: Types.Long) =
            { state with PrimaryRejections = Some value }

        [<CustomOperation("replicaRejections")>]
        member _.ReplicaRejections(state: Types.PressureMemory, value: Types.Long) =
            { state with ReplicaRejections = Some value }

        [<CustomOperation("primaryDocumentRejections")>]
        member _.PrimaryDocumentRejections(state: Types.PressureMemory, value: Types.Long) =
            { state with PrimaryDocumentRejections = Some value }

        [<CustomOperation("largeOperationRejections")>]
        member _.LargeOperationRejections(state: Types.PressureMemory, value: Types.Long) =
            { state with LargeOperationRejections = Some value }

    let pressureMemory = PressureMemoryBuilder()

    type ProcessBuilder() =
        member _.Yield(_: unit) : Types.Process =
            {
                Cpu = None
                Mem = None
                OpenFileDescriptors = None
                MaxFileDescriptors = None
                Timestamp = None
            }

        [<CustomOperation("cpu")>]
        member _.Cpu(state: Types.Process, value: Types.Cpu) =
            { state with Cpu = Some value }

        [<CustomOperation("mem")>]
        member _.Mem(state: Types.Process, value: Types.MemoryStats) =
            { state with Mem = Some value }

        [<CustomOperation("openFileDescriptors")>]
        member _.OpenFileDescriptors(state: Types.Process, value: Types.Integer) =
            { state with OpenFileDescriptors = Some value }

        [<CustomOperation("maxFileDescriptors")>]
        member _.MaxFileDescriptors(state: Types.Process, value: Types.Integer) =
            { state with MaxFileDescriptors = Some value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: Types.Process, value: Types.Long) =
            { state with Timestamp = Some value }

    let process = ProcessBuilder()

    type ProcessorBuilder() =
        member _.Yield(_: unit) : Types.Processor =
            {
                Count = None
                Current = None
                Failed = None
                TimeInMillis = None
            }

        [<CustomOperation("count")>]
        member _.Count(state: Types.Processor, value: Types.Long) =
            { state with Count = Some value }

        [<CustomOperation("current")>]
        member _.Current(state: Types.Processor, value: Types.Long) =
            { state with Current = Some value }

        [<CustomOperation("failed")>]
        member _.Failed(state: Types.Processor, value: Types.Long) =
            { state with Failed = Some value }

        [<CustomOperation("timeInMillis")>]
        member _.TimeInMillis(state: Types.Processor, value: Types.DurationValue<Types.UnitMillis>) =
            { state with TimeInMillis = Some value }

    let processor = ProcessorBuilder()

    type PublishedClusterStatesBuilder() =
        member _.Yield(_: unit) : Types.PublishedClusterStates =
            {
                FullStates = None
                IncompatibleDiffs = None
                CompatibleDiffs = None
            }

        [<CustomOperation("fullStates")>]
        member _.FullStates(state: Types.PublishedClusterStates, value: Types.Long) =
            { state with FullStates = Some value }

        [<CustomOperation("incompatibleDiffs")>]
        member _.IncompatibleDiffs(state: Types.PublishedClusterStates, value: Types.Long) =
            { state with IncompatibleDiffs = Some value }

        [<CustomOperation("compatibleDiffs")>]
        member _.CompatibleDiffs(state: Types.PublishedClusterStates, value: Types.Long) =
            { state with CompatibleDiffs = Some value }

    let publishedClusterStates = PublishedClusterStatesBuilder()

    type RecordingBuilder() =
        member _.Yield(_: unit) : Types.Recording =
            {
                Name = None
                CumulativeExecutionCount = None
                CumulativeExecutionTime = None
                CumulativeExecutionTimeMillis = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: Types.Recording, value: string) =
            { state with Name = Some value }

        [<CustomOperation("cumulativeExecutionCount")>]
        member _.CumulativeExecutionCount(state: Types.Recording, value: Types.Long) =
            { state with CumulativeExecutionCount = Some value }

        [<CustomOperation("cumulativeExecutionTime")>]
        member _.CumulativeExecutionTime(state: Types.Recording, value: Types.Duration) =
            { state with CumulativeExecutionTime = Some value }

        [<CustomOperation("cumulativeExecutionTimeMillis")>]
        member _.CumulativeExecutionTimeMillis(state: Types.Recording, value: Types.DurationValue<Types.UnitMillis>) =
            { state with CumulativeExecutionTimeMillis = Some value }

    let recording = RecordingBuilder()

    type RepositoryLocationBuilder() =
        member _.Yield(_: unit) : Types.RepositoryLocation =
            {
                BasePath = Unchecked.defaultof<_>
                Container = None
                Bucket = None
            }

        [<CustomOperation("basePath")>]
        member _.BasePath(state: Types.RepositoryLocation, value: string) =
            { state with BasePath = value }

        [<CustomOperation("container")>]
        member _.Container(state: Types.RepositoryLocation, value: string) =
            { state with Container = Some value }

        [<CustomOperation("bucket")>]
        member _.Bucket(state: Types.RepositoryLocation, value: string) =
            { state with Bucket = Some value }

    let repositoryLocation = RepositoryLocationBuilder()

    type RepositoryMeteringInformationBuilder() =
        member _.Yield(_: unit) : Types.RepositoryMeteringInformation =
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
        member _.RepositoryName(state: Types.RepositoryMeteringInformation, value: Types.Name) =
            { state with RepositoryName = value }

        [<CustomOperation("repositoryType")>]
        member _.RepositoryType(state: Types.RepositoryMeteringInformation, value: string) =
            { state with RepositoryType = value }

        [<CustomOperation("repositoryLocation")>]
        member _.RepositoryLocation(state: Types.RepositoryMeteringInformation, value: Types.RepositoryLocation) =
            { state with RepositoryLocation = value }

        [<CustomOperation("repositoryEphemeralId")>]
        member _.RepositoryEphemeralId(state: Types.RepositoryMeteringInformation, value: Types.Id) =
            { state with RepositoryEphemeralId = value }

        [<CustomOperation("repositoryStartedAt")>]
        member _.RepositoryStartedAt(state: Types.RepositoryMeteringInformation, value: Types.EpochTime<Types.UnitMillis>) =
            { state with RepositoryStartedAt = value }

        [<CustomOperation("repositoryStoppedAt")>]
        member _.RepositoryStoppedAt(state: Types.RepositoryMeteringInformation, value: Types.EpochTime<Types.UnitMillis>) =
            { state with RepositoryStoppedAt = Some value }

        [<CustomOperation("archived")>]
        member _.Archived(state: Types.RepositoryMeteringInformation, value: bool) =
            { state with Archived = value }

        [<CustomOperation("clusterVersion")>]
        member _.ClusterVersion(state: Types.RepositoryMeteringInformation, value: Types.VersionNumber) =
            { state with ClusterVersion = Some value }

        [<CustomOperation("requestCounts")>]
        member _.RequestCounts(state: Types.RepositoryMeteringInformation, value: Types.RequestCounts) =
            { state with RequestCounts = value }

    let repositoryMeteringInformation = RepositoryMeteringInformationBuilder()

    type RequestCountsBuilder() =
        member _.Yield(_: unit) : Types.RequestCounts =
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
        member _.GetBlobProperties(state: Types.RequestCounts, value: Types.Long) =
            { state with GetBlobProperties = Some value }

        [<CustomOperation("getBlob")>]
        member _.GetBlob(state: Types.RequestCounts, value: Types.Long) =
            { state with GetBlob = Some value }

        [<CustomOperation("listBlobs")>]
        member _.ListBlobs(state: Types.RequestCounts, value: Types.Long) =
            { state with ListBlobs = Some value }

        [<CustomOperation("putBlob")>]
        member _.PutBlob(state: Types.RequestCounts, value: Types.Long) =
            { state with PutBlob = Some value }

        [<CustomOperation("putBlock")>]
        member _.PutBlock(state: Types.RequestCounts, value: Types.Long) =
            { state with PutBlock = Some value }

        [<CustomOperation("putBlockList")>]
        member _.PutBlockList(state: Types.RequestCounts, value: Types.Long) =
            { state with PutBlockList = Some value }

        [<CustomOperation("getObject")>]
        member _.GetObject(state: Types.RequestCounts, value: Types.Long) =
            { state with GetObject = Some value }

        [<CustomOperation("listObjects")>]
        member _.ListObjects(state: Types.RequestCounts, value: Types.Long) =
            { state with ListObjects = Some value }

        [<CustomOperation("insertObject")>]
        member _.InsertObject(state: Types.RequestCounts, value: Types.Long) =
            { state with InsertObject = Some value }

        [<CustomOperation("putObject")>]
        member _.PutObject(state: Types.RequestCounts, value: Types.Long) =
            { state with PutObject = Some value }

        [<CustomOperation("putMultipartObject")>]
        member _.PutMultipartObject(state: Types.RequestCounts, value: Types.Long) =
            { state with PutMultipartObject = Some value }

    let requestCounts = RequestCountsBuilder()

    type ScriptCacheBuilder() =
        member _.Yield(_: unit) : Types.ScriptCache =
            {
                CacheEvictions = None
                CompilationLimitTriggered = None
                Compilations = None
                Context = None
            }

        [<CustomOperation("cacheEvictions")>]
        member _.CacheEvictions(state: Types.ScriptCache, value: Types.Long) =
            { state with CacheEvictions = Some value }

        [<CustomOperation("compilationLimitTriggered")>]
        member _.CompilationLimitTriggered(state: Types.ScriptCache, value: Types.Long) =
            { state with CompilationLimitTriggered = Some value }

        [<CustomOperation("compilations")>]
        member _.Compilations(state: Types.ScriptCache, value: Types.Long) =
            { state with Compilations = Some value }

        [<CustomOperation("context")>]
        member _.Context(state: Types.ScriptCache, value: string) =
            { state with Context = Some value }

    let scriptCache = ScriptCacheBuilder()

    type ScriptingBuilder() =
        member _.Yield(_: unit) : Types.Scripting =
            {
                CacheEvictions = None
                Compilations = None
                CompilationsHistory = None
                CompilationLimitTriggered = None
                Contexts = None
            }

        [<CustomOperation("cacheEvictions")>]
        member _.CacheEvictions(state: Types.Scripting, value: Types.Long) =
            { state with CacheEvictions = Some value }

        [<CustomOperation("compilations")>]
        member _.Compilations(state: Types.Scripting, value: Types.Long) =
            { state with Compilations = Some value }

        [<CustomOperation("compilationsHistory")>]
        member _.CompilationsHistory(state: Types.Scripting, value: Map<string, Types.Long>) =
            { state with CompilationsHistory = Some value }

        [<CustomOperation("compilationLimitTriggered")>]
        member _.CompilationLimitTriggered(state: Types.Scripting, value: Types.Long) =
            { state with CompilationLimitTriggered = Some value }

        [<CustomOperation("contexts")>]
        member _.Contexts(state: Types.Scripting, value: Types.NodesTypesContext list) =
            { state with Contexts = Some value }

    let scripting = ScriptingBuilder()

    type SerializedClusterStateBuilder() =
        member _.Yield(_: unit) : Types.SerializedClusterState =
            {
                FullStates = None
                Diffs = None
            }

        [<CustomOperation("fullStates")>]
        member _.FullStates(state: Types.SerializedClusterState, value: Types.SerializedClusterStateDetail) =
            { state with FullStates = Some value }

        [<CustomOperation("diffs")>]
        member _.Diffs(state: Types.SerializedClusterState, value: Types.SerializedClusterStateDetail) =
            { state with Diffs = Some value }

    let serializedClusterState = SerializedClusterStateBuilder()

    type SerializedClusterStateDetailBuilder() =
        member _.Yield(_: unit) : Types.SerializedClusterStateDetail =
            {
                Count = None
                UncompressedSize = None
                UncompressedSizeInBytes = None
                CompressedSize = None
                CompressedSizeInBytes = None
            }

        [<CustomOperation("count")>]
        member _.Count(state: Types.SerializedClusterStateDetail, value: Types.Long) =
            { state with Count = Some value }

        [<CustomOperation("uncompressedSize")>]
        member _.UncompressedSize(state: Types.SerializedClusterStateDetail, value: string) =
            { state with UncompressedSize = Some value }

        [<CustomOperation("uncompressedSizeInBytes")>]
        member _.UncompressedSizeInBytes(state: Types.SerializedClusterStateDetail, value: Types.Long) =
            { state with UncompressedSizeInBytes = Some value }

        [<CustomOperation("compressedSize")>]
        member _.CompressedSize(state: Types.SerializedClusterStateDetail, value: string) =
            { state with CompressedSize = Some value }

        [<CustomOperation("compressedSizeInBytes")>]
        member _.CompressedSizeInBytes(state: Types.SerializedClusterStateDetail, value: Types.Long) =
            { state with CompressedSizeInBytes = Some value }

    let serializedClusterStateDetail = SerializedClusterStateDetailBuilder()

    type SizeHttpHistogramBuilder() =
        member _.Yield(_: unit) : Types.SizeHttpHistogram =
            {
                Count = Unchecked.defaultof<_>
                GeBytes = None
                LtBytes = None
            }

        [<CustomOperation("count")>]
        member _.Count(state: Types.SizeHttpHistogram, value: Types.Long) =
            { state with Count = value }

        [<CustomOperation("geBytes")>]
        member _.GeBytes(state: Types.SizeHttpHistogram, value: Types.Long) =
            { state with GeBytes = Some value }

        [<CustomOperation("ltBytes")>]
        member _.LtBytes(state: Types.SizeHttpHistogram, value: Types.Long) =
            { state with LtBytes = Some value }

    let sizeHttpHistogram = SizeHttpHistogramBuilder()

    type StatsBuilder() =
        member _.Yield(_: unit) : Types.Stats =
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
        member _.AdaptiveSelection(state: Types.Stats, value: Map<string, Types.AdaptiveSelection>) =
            { state with AdaptiveSelection = Some value }

        [<CustomOperation("breakers")>]
        member _.Breakers(state: Types.Stats, value: Map<string, Types.Breaker>) =
            { state with Breakers = Some value }

        [<CustomOperation("fs")>]
        member _.Fs(state: Types.Stats, value: Types.FileSystem) =
            { state with Fs = Some value }

        [<CustomOperation("host")>]
        member _.Host(state: Types.Stats, value: Types.Host) =
            { state with Host = Some value }

        [<CustomOperation("http")>]
        member _.Http(state: Types.Stats, value: Types.Http) =
            { state with Http = Some value }

        [<CustomOperation("ingest")>]
        member _.Ingest(state: Types.Stats, value: Types.NodesTypesIngest) =
            { state with Ingest = Some value }

        [<CustomOperation("ip")>]
        member _.Ip(state: Types.Stats, value: System.Text.Json.JsonElement) =
            { state with Ip = Some value }

        [<CustomOperation("jvm")>]
        member _.Jvm(state: Types.Stats, value: Types.Jvm) =
            { state with Jvm = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Types.Stats, value: Types.Name) =
            { state with Name = Some value }

        [<CustomOperation("os")>]
        member _.Os(state: Types.Stats, value: Types.OperatingSystem) =
            { state with Os = Some value }

        [<CustomOperation("process")>]
        member _.Process(state: Types.Stats, value: Types.Process) =
            { state with Process = Some value }

        [<CustomOperation("roles")>]
        member _.Roles(state: Types.Stats, value: Types.NodeRoles) =
            { state with Roles = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.Stats, value: Types.Scripting) =
            { state with Script = Some value }

        [<CustomOperation("scriptCache")>]
        member _.ScriptCache(state: Types.Stats, value: Map<string, System.Text.Json.JsonElement>) =
            { state with ScriptCache = Some value }

        [<CustomOperation("threadPool")>]
        member _.ThreadPool(state: Types.Stats, value: Map<string, Types.ThreadCount>) =
            { state with ThreadPool = Some value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: Types.Stats, value: Types.Long) =
            { state with Timestamp = Some value }

        [<CustomOperation("transport")>]
        member _.Transport(state: Types.Stats, value: Types.Transport) =
            { state with Transport = Some value }

        [<CustomOperation("transportAddress")>]
        member _.TransportAddress(state: Types.Stats, value: Types.TransportAddress) =
            { state with TransportAddress = Some value }

        [<CustomOperation("attributes")>]
        member _.Attributes(state: Types.Stats, value: Map<Types.Field, string>) =
            { state with Attributes = Some value }

        [<CustomOperation("discovery")>]
        member _.Discovery(state: Types.Stats, value: Types.Discovery) =
            { state with Discovery = Some value }

        [<CustomOperation("indexingPressure")>]
        member _.IndexingPressure(state: Types.Stats, value: Types.NodesTypesIndexingPressure) =
            { state with IndexingPressure = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.Stats, value: Types.IndicesStatsShardStats) =
            { state with Indices = Some value }

    let stats = StatsBuilder()

    type ThreadCountBuilder() =
        member _.Yield(_: unit) : Types.ThreadCount =
            {
                Active = None
                Completed = None
                Largest = None
                Queue = None
                Rejected = None
                Threads = None
            }

        [<CustomOperation("active")>]
        member _.Active(state: Types.ThreadCount, value: Types.Long) =
            { state with Active = Some value }

        [<CustomOperation("completed")>]
        member _.Completed(state: Types.ThreadCount, value: Types.Long) =
            { state with Completed = Some value }

        [<CustomOperation("largest")>]
        member _.Largest(state: Types.ThreadCount, value: Types.Long) =
            { state with Largest = Some value }

        [<CustomOperation("queue")>]
        member _.Queue(state: Types.ThreadCount, value: Types.Long) =
            { state with Queue = Some value }

        [<CustomOperation("rejected")>]
        member _.Rejected(state: Types.ThreadCount, value: Types.Long) =
            { state with Rejected = Some value }

        [<CustomOperation("threads")>]
        member _.Threads(state: Types.ThreadCount, value: Types.Long) =
            { state with Threads = Some value }

    let threadCount = ThreadCountBuilder()

    type TimeHttpHistogramBuilder() =
        member _.Yield(_: unit) : Types.TimeHttpHistogram =
            {
                Count = Unchecked.defaultof<_>
                GeMillis = None
                LtMillis = None
            }

        [<CustomOperation("count")>]
        member _.Count(state: Types.TimeHttpHistogram, value: Types.Long) =
            { state with Count = value }

        [<CustomOperation("geMillis")>]
        member _.GeMillis(state: Types.TimeHttpHistogram, value: Types.Long) =
            { state with GeMillis = Some value }

        [<CustomOperation("ltMillis")>]
        member _.LtMillis(state: Types.TimeHttpHistogram, value: Types.Long) =
            { state with LtMillis = Some value }

    let timeHttpHistogram = TimeHttpHistogramBuilder()

    type TransportBuilder() =
        member _.Yield(_: unit) : Types.Transport =
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
        member _.InboundHandlingTimeHistogram(state: Types.Transport, value: Types.TransportHistogram list) =
            { state with InboundHandlingTimeHistogram = Some value }

        [<CustomOperation("outboundHandlingTimeHistogram")>]
        member _.OutboundHandlingTimeHistogram(state: Types.Transport, value: Types.TransportHistogram list) =
            { state with OutboundHandlingTimeHistogram = Some value }

        [<CustomOperation("rxCount")>]
        member _.RxCount(state: Types.Transport, value: Types.Long) =
            { state with RxCount = Some value }

        [<CustomOperation("rxSize")>]
        member _.RxSize(state: Types.Transport, value: string) =
            { state with RxSize = Some value }

        [<CustomOperation("rxSizeInBytes")>]
        member _.RxSizeInBytes(state: Types.Transport, value: Types.Long) =
            { state with RxSizeInBytes = Some value }

        [<CustomOperation("serverOpen")>]
        member _.ServerOpen(state: Types.Transport, value: Types.Integer) =
            { state with ServerOpen = Some value }

        [<CustomOperation("txCount")>]
        member _.TxCount(state: Types.Transport, value: Types.Long) =
            { state with TxCount = Some value }

        [<CustomOperation("txSize")>]
        member _.TxSize(state: Types.Transport, value: string) =
            { state with TxSize = Some value }

        [<CustomOperation("txSizeInBytes")>]
        member _.TxSizeInBytes(state: Types.Transport, value: Types.Long) =
            { state with TxSizeInBytes = Some value }

        [<CustomOperation("totalOutboundConnections")>]
        member _.TotalOutboundConnections(state: Types.Transport, value: Types.Long) =
            { state with TotalOutboundConnections = Some value }

    let transport = TransportBuilder()

    type TransportHistogramBuilder() =
        member _.Yield(_: unit) : Types.TransportHistogram =
            {
                Count = None
                LtMillis = None
                GeMillis = None
            }

        [<CustomOperation("count")>]
        member _.Count(state: Types.TransportHistogram, value: Types.Long) =
            { state with Count = Some value }

        [<CustomOperation("ltMillis")>]
        member _.LtMillis(state: Types.TransportHistogram, value: Types.Long) =
            { state with LtMillis = Some value }

        [<CustomOperation("geMillis")>]
        member _.GeMillis(state: Types.TransportHistogram, value: Types.Long) =
            { state with GeMillis = Some value }

    let transportHistogram = TransportHistogramBuilder()


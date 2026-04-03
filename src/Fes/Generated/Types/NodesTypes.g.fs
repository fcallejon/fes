// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module NodesTypes =

    type AdaptiveSelection = {
        [<System.Text.Json.Serialization.JsonPropertyName("avg_queue_size")>]
        AvgQueueSize: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("avg_response_time")>]
        AvgResponseTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("avg_response_time_ns")>]
        AvgResponseTimeNs: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("avg_service_time")>]
        AvgServiceTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("avg_service_time_ns")>]
        AvgServiceTimeNs: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("outgoing_searches")>]
        OutgoingSearches: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("rank")>]
        Rank: string option
    }

    type Breaker = {
        [<System.Text.Json.Serialization.JsonPropertyName("estimated_size")>]
        EstimatedSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("estimated_size_in_bytes")>]
        EstimatedSizeInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("limit_size")>]
        LimitSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("limit_size_in_bytes")>]
        LimitSizeInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("overhead")>]
        Overhead: CoreTypes.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("tripped")>]
        Tripped: CoreTypes.Float option
    }

    type CpuAcct = {
        [<System.Text.Json.Serialization.JsonPropertyName("control_group")>]
        ControlGroup: string option
        [<System.Text.Json.Serialization.JsonPropertyName("usage_nanos")>]
        UsageNanos: CoreTypes.DurationValue<CoreTypes.UnitNanos> option
    }

    type CgroupCpuStat = {
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_elapsed_periods")>]
        NumberOfElapsedPeriods: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_times_throttled")>]
        NumberOfTimesThrottled: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("time_throttled_nanos")>]
        TimeThrottledNanos: CoreTypes.DurationValue<CoreTypes.UnitNanos> option
    }

    type CgroupCpu = {
        [<System.Text.Json.Serialization.JsonPropertyName("control_group")>]
        ControlGroup: string option
        [<System.Text.Json.Serialization.JsonPropertyName("cfs_period_micros")>]
        CfsPeriodMicros: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("cfs_quota_micros")>]
        CfsQuotaMicros: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("stat")>]
        Stat: CgroupCpuStat option
    }

    type CgroupMemory = {
        [<System.Text.Json.Serialization.JsonPropertyName("control_group")>]
        ControlGroup: string option
        [<System.Text.Json.Serialization.JsonPropertyName("limit_in_bytes")>]
        LimitInBytes: string option
        [<System.Text.Json.Serialization.JsonPropertyName("usage_in_bytes")>]
        UsageInBytes: string option
    }

    type Cgroup = {
        [<System.Text.Json.Serialization.JsonPropertyName("cpuacct")>]
        Cpuacct: CpuAcct option
        [<System.Text.Json.Serialization.JsonPropertyName("cpu")>]
        Cpu: CgroupCpu option
        [<System.Text.Json.Serialization.JsonPropertyName("memory")>]
        Memory: CgroupMemory option
    }

    type Client = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("agent")>]
        Agent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("local_address")>]
        LocalAddress: string option
        [<System.Text.Json.Serialization.JsonPropertyName("remote_address")>]
        RemoteAddress: string option
        [<System.Text.Json.Serialization.JsonPropertyName("last_uri")>]
        LastUri: string option
        [<System.Text.Json.Serialization.JsonPropertyName("opened_time_millis")>]
        OpenedTimeMillis: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("closed_time_millis")>]
        ClosedTimeMillis: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("last_request_time_millis")>]
        LastRequestTimeMillis: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("request_count")>]
        RequestCount: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("request_size_bytes")>]
        RequestSizeBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("x_opaque_id")>]
        XOpaqueId: string option
    }

    type Recording = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string option
        [<System.Text.Json.Serialization.JsonPropertyName("cumulative_execution_count")>]
        CumulativeExecutionCount: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("cumulative_execution_time")>]
        CumulativeExecutionTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("cumulative_execution_time_millis")>]
        CumulativeExecutionTimeMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis> option
    }

    type ClusterAppliedStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("recordings")>]
        Recordings: Recording list option
    }

    type ClusterStateQueue = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("pending")>]
        Pending: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("committed")>]
        Committed: CoreTypes.Long option
    }

    type ClusterStateUpdate = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("computation_time")>]
        ComputationTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("computation_time_millis")>]
        ComputationTimeMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("publication_time")>]
        PublicationTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("publication_time_millis")>]
        PublicationTimeMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("context_construction_time")>]
        ContextConstructionTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("context_construction_time_millis")>]
        ContextConstructionTimeMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("commit_time")>]
        CommitTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("commit_time_millis")>]
        CommitTimeMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("completion_time")>]
        CompletionTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("completion_time_millis")>]
        CompletionTimeMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("master_apply_time")>]
        MasterApplyTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("master_apply_time_millis")>]
        MasterApplyTimeMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("notification_time")>]
        NotificationTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("notification_time_millis")>]
        NotificationTimeMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis> option
    }

    type Context = {
        [<System.Text.Json.Serialization.JsonPropertyName("context")>]
        Context: string option
        [<System.Text.Json.Serialization.JsonPropertyName("compilations")>]
        Compilations: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("cache_evictions")>]
        CacheEvictions: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("compilation_limit_triggered")>]
        CompilationLimitTriggered: CoreTypes.Long option
    }

    type Cpu = {
        [<System.Text.Json.Serialization.JsonPropertyName("percent")>]
        Percent: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("sys")>]
        Sys: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("sys_in_millis")>]
        SysInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_in_millis")>]
        TotalInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("user")>]
        User: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("user_in_millis")>]
        UserInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("load_average")>]
        LoadAverage: Map<string, CoreTypes.Double> option
    }

    type DataPathStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("available")>]
        Available: string option
        [<System.Text.Json.Serialization.JsonPropertyName("available_in_bytes")>]
        AvailableInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("disk_queue")>]
        DiskQueue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("disk_reads")>]
        DiskReads: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("disk_read_size")>]
        DiskReadSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("disk_read_size_in_bytes")>]
        DiskReadSizeInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("disk_writes")>]
        DiskWrites: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("disk_write_size")>]
        DiskWriteSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("disk_write_size_in_bytes")>]
        DiskWriteSizeInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("free")>]
        Free: string option
        [<System.Text.Json.Serialization.JsonPropertyName("free_in_bytes")>]
        FreeInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("mount")>]
        Mount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: string option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: string option
        [<System.Text.Json.Serialization.JsonPropertyName("total_in_bytes")>]
        TotalInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string option
    }

    type PublishedClusterStates = {
        [<System.Text.Json.Serialization.JsonPropertyName("full_states")>]
        FullStates: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("incompatible_diffs")>]
        IncompatibleDiffs: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("compatible_diffs")>]
        CompatibleDiffs: CoreTypes.Long option
    }

    type SerializedClusterStateDetail = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("uncompressed_size")>]
        UncompressedSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("uncompressed_size_in_bytes")>]
        UncompressedSizeInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("compressed_size")>]
        CompressedSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("compressed_size_in_bytes")>]
        CompressedSizeInBytes: CoreTypes.Long option
    }

    type SerializedClusterState = {
        [<System.Text.Json.Serialization.JsonPropertyName("full_states")>]
        FullStates: SerializedClusterStateDetail option
        [<System.Text.Json.Serialization.JsonPropertyName("diffs")>]
        Diffs: SerializedClusterStateDetail option
    }

    type Discovery = {
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_state_queue")>]
        ClusterStateQueue: ClusterStateQueue option
        [<System.Text.Json.Serialization.JsonPropertyName("published_cluster_states")>]
        PublishedClusterStates: PublishedClusterStates option
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_state_update")>]
        ClusterStateUpdate: Map<string, ClusterStateUpdate> option
        [<System.Text.Json.Serialization.JsonPropertyName("serialized_cluster_states")>]
        SerializedClusterStates: SerializedClusterState option
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_applier_stats")>]
        ClusterApplierStats: ClusterAppliedStats option
    }

    type MemoryStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("adjusted_total_in_bytes")>]
        AdjustedTotalInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("resident")>]
        Resident: string option
        [<System.Text.Json.Serialization.JsonPropertyName("resident_in_bytes")>]
        ResidentInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("share")>]
        Share: string option
        [<System.Text.Json.Serialization.JsonPropertyName("share_in_bytes")>]
        ShareInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_virtual")>]
        TotalVirtual: string option
        [<System.Text.Json.Serialization.JsonPropertyName("total_virtual_in_bytes")>]
        TotalVirtualInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_in_bytes")>]
        TotalInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("free_in_bytes")>]
        FreeInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("used_in_bytes")>]
        UsedInBytes: CoreTypes.Long option
    }

    type ExtendedMemoryStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("free_percent")>]
        FreePercent: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("used_percent")>]
        UsedPercent: CoreTypes.Integer option
    }

    type FileSystemTotal = {
        [<System.Text.Json.Serialization.JsonPropertyName("available")>]
        Available: string option
        [<System.Text.Json.Serialization.JsonPropertyName("available_in_bytes")>]
        AvailableInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("free")>]
        Free: string option
        [<System.Text.Json.Serialization.JsonPropertyName("free_in_bytes")>]
        FreeInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: string option
        [<System.Text.Json.Serialization.JsonPropertyName("total_in_bytes")>]
        TotalInBytes: CoreTypes.Long option
    }

    type IoStatDevice = {
        [<System.Text.Json.Serialization.JsonPropertyName("device_name")>]
        DeviceName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("operations")>]
        Operations: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("read_kilobytes")>]
        ReadKilobytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("read_operations")>]
        ReadOperations: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("write_kilobytes")>]
        WriteKilobytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("write_operations")>]
        WriteOperations: CoreTypes.Long option
    }

    type IoStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("devices")>]
        Devices: IoStatDevice list option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: IoStatDevice option
    }

    type FileSystem = {
        [<System.Text.Json.Serialization.JsonPropertyName("data")>]
        Data: DataPathStats list option
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: FileSystemTotal option
        [<System.Text.Json.Serialization.JsonPropertyName("io_stats")>]
        IoStats: IoStats option
    }

    type GarbageCollectorTotal = {
        [<System.Text.Json.Serialization.JsonPropertyName("collection_count")>]
        CollectionCount: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("collection_time")>]
        CollectionTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("collection_time_in_millis")>]
        CollectionTimeInMillis: CoreTypes.Long option
    }

    type GarbageCollector = {
        [<System.Text.Json.Serialization.JsonPropertyName("collectors")>]
        Collectors: Map<string, GarbageCollectorTotal> option
    }

    type SizeHttpHistogram = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("ge_bytes")>]
        GeBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("lt_bytes")>]
        LtBytes: CoreTypes.Long option
    }

    type HttpRouteRequests = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_size_in_bytes")>]
        TotalSizeInBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("size_histogram")>]
        SizeHistogram: SizeHttpHistogram list
    }

    type TimeHttpHistogram = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("ge_millis")>]
        GeMillis: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("lt_millis")>]
        LtMillis: CoreTypes.Long option
    }

    type HttpRouteResponses = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_size_in_bytes")>]
        TotalSizeInBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("handling_time_histogram")>]
        HandlingTimeHistogram: TimeHttpHistogram list
        [<System.Text.Json.Serialization.JsonPropertyName("size_histogram")>]
        SizeHistogram: SizeHttpHistogram list
    }

    type HttpRoute = {
        [<System.Text.Json.Serialization.JsonPropertyName("requests")>]
        Requests: HttpRouteRequests
        [<System.Text.Json.Serialization.JsonPropertyName("responses")>]
        Responses: HttpRouteResponses
    }

    type Http = {
        [<System.Text.Json.Serialization.JsonPropertyName("current_open")>]
        CurrentOpen: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("total_opened")>]
        TotalOpened: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("clients")>]
        Clients: Client list option
        [<System.Text.Json.Serialization.JsonPropertyName("routes")>]
        Routes: Map<string, HttpRoute>
    }

    type PressureMemory = {
        [<System.Text.Json.Serialization.JsonPropertyName("all")>]
        All: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("all_in_bytes")>]
        AllInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("combined_coordinating_and_primary")>]
        CombinedCoordinatingAndPrimary: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("combined_coordinating_and_primary_in_bytes")>]
        CombinedCoordinatingAndPrimaryInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("coordinating")>]
        Coordinating: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("coordinating_in_bytes")>]
        CoordinatingInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("primary")>]
        Primary: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("primary_in_bytes")>]
        PrimaryInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("replica")>]
        Replica: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("replica_in_bytes")>]
        ReplicaInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("coordinating_rejections")>]
        CoordinatingRejections: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("primary_rejections")>]
        PrimaryRejections: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("replica_rejections")>]
        ReplicaRejections: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("primary_document_rejections")>]
        PrimaryDocumentRejections: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("large_operation_rejections")>]
        LargeOperationRejections: CoreTypes.Long option
    }

    type IndexingPressureMemory = {
        [<System.Text.Json.Serialization.JsonPropertyName("limit")>]
        Limit: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("limit_in_bytes")>]
        LimitInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("current")>]
        Current: PressureMemory option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: PressureMemory option
    }

    type IndexingPressure = {
        [<System.Text.Json.Serialization.JsonPropertyName("memory")>]
        Memory: IndexingPressureMemory option
    }

    type Processor = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("current")>]
        Current: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("failed")>]
        Failed: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_millis")>]
        TimeInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis> option
    }

    type KeyedProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("stats")>]
        Stats: Processor option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string option
    }

    type IngestStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("current")>]
        Current: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("failed")>]
        Failed: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("processors")>]
        Processors: Map<string, KeyedProcessor> list
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_millis")>]
        TimeInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("ingested_as_first_pipeline_in_bytes")>]
        IngestedAsFirstPipelineInBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("produced_as_first_pipeline_in_bytes")>]
        ProducedAsFirstPipelineInBytes: CoreTypes.Long
    }

    type IngestTotal = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("current")>]
        Current: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("failed")>]
        Failed: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_millis")>]
        TimeInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
    }

    type Ingest = {
        [<System.Text.Json.Serialization.JsonPropertyName("pipelines")>]
        Pipelines: Map<string, IngestStats> option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: IngestTotal option
    }

    type NodeBufferPool = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_capacity")>]
        TotalCapacity: string option
        [<System.Text.Json.Serialization.JsonPropertyName("total_capacity_in_bytes")>]
        TotalCapacityInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("used")>]
        Used: string option
        [<System.Text.Json.Serialization.JsonPropertyName("used_in_bytes")>]
        UsedInBytes: CoreTypes.Long option
    }

    type JvmClasses = {
        [<System.Text.Json.Serialization.JsonPropertyName("current_loaded_count")>]
        CurrentLoadedCount: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_loaded_count")>]
        TotalLoadedCount: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_unloaded_count")>]
        TotalUnloadedCount: CoreTypes.Long option
    }

    type Pool = {
        [<System.Text.Json.Serialization.JsonPropertyName("used_in_bytes")>]
        UsedInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("max_in_bytes")>]
        MaxInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("peak_used_in_bytes")>]
        PeakUsedInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("peak_max_in_bytes")>]
        PeakMaxInBytes: CoreTypes.Long option
    }

    type JvmMemoryStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("heap_used_in_bytes")>]
        HeapUsedInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("heap_used_percent")>]
        HeapUsedPercent: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("heap_committed_in_bytes")>]
        HeapCommittedInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("heap_max_in_bytes")>]
        HeapMaxInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("heap_max")>]
        HeapMax: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("non_heap_used_in_bytes")>]
        NonHeapUsedInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("non_heap_committed_in_bytes")>]
        NonHeapCommittedInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("pools")>]
        Pools: Map<string, Pool> option
    }

    type JvmThreads = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("peak_count")>]
        PeakCount: CoreTypes.Long option
    }

    type Jvm = {
        [<System.Text.Json.Serialization.JsonPropertyName("buffer_pools")>]
        BufferPools: Map<string, NodeBufferPool> option
        [<System.Text.Json.Serialization.JsonPropertyName("classes")>]
        Classes: JvmClasses option
        [<System.Text.Json.Serialization.JsonPropertyName("gc")>]
        Gc: GarbageCollector option
        [<System.Text.Json.Serialization.JsonPropertyName("mem")>]
        Mem: JvmMemoryStats option
        [<System.Text.Json.Serialization.JsonPropertyName("threads")>]
        Threads: JvmThreads option
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("uptime")>]
        Uptime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("uptime_in_millis")>]
        UptimeInMillis: CoreTypes.Long option
    }

    type NodeReloadResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("reload_exception")>]
        ReloadException: CoreTypes.ErrorCause option
        [<System.Text.Json.Serialization.JsonPropertyName("secure_setting_names")>]
        SecureSettingNames: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("keystore_path")>]
        KeystorePath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("keystore_digest")>]
        KeystoreDigest: string option
        [<System.Text.Json.Serialization.JsonPropertyName("keystore_last_modified_time")>]
        KeystoreLastModifiedTime: CoreTypes.DateTime option
    }

    type NodesResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("_nodes")>]
        Nodes: CoreTypes.NodeStatistics option
    }

    type OperatingSystem = {
        [<System.Text.Json.Serialization.JsonPropertyName("cpu")>]
        Cpu: Cpu option
        [<System.Text.Json.Serialization.JsonPropertyName("mem")>]
        Mem: ExtendedMemoryStats option
        [<System.Text.Json.Serialization.JsonPropertyName("swap")>]
        Swap: MemoryStats option
        [<System.Text.Json.Serialization.JsonPropertyName("cgroup")>]
        Cgroup: Cgroup option
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.Long option
    }

    type Process = {
        [<System.Text.Json.Serialization.JsonPropertyName("cpu")>]
        Cpu: Cpu option
        [<System.Text.Json.Serialization.JsonPropertyName("mem")>]
        Mem: MemoryStats option
        [<System.Text.Json.Serialization.JsonPropertyName("open_file_descriptors")>]
        OpenFileDescriptors: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_file_descriptors")>]
        MaxFileDescriptors: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.Long option
    }

    type RepositoryLocation = {
        [<System.Text.Json.Serialization.JsonPropertyName("base_path")>]
        BasePath: string
        [<System.Text.Json.Serialization.JsonPropertyName("container")>]
        Container: string option
        [<System.Text.Json.Serialization.JsonPropertyName("bucket")>]
        Bucket: string option
    }

    type RequestCounts = {
        GetBlobProperties: CoreTypes.Long option
        GetBlob: CoreTypes.Long option
        ListBlobs: CoreTypes.Long option
        PutBlob: CoreTypes.Long option
        PutBlock: CoreTypes.Long option
        PutBlockList: CoreTypes.Long option
        GetObject: CoreTypes.Long option
        ListObjects: CoreTypes.Long option
        InsertObject: CoreTypes.Long option
        PutObject: CoreTypes.Long option
        PutMultipartObject: CoreTypes.Long option
    }

    type RepositoryMeteringInformation = {
        [<System.Text.Json.Serialization.JsonPropertyName("repository_name")>]
        RepositoryName: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("repository_type")>]
        RepositoryType: string
        [<System.Text.Json.Serialization.JsonPropertyName("repository_location")>]
        RepositoryLocation: RepositoryLocation
        [<System.Text.Json.Serialization.JsonPropertyName("repository_ephemeral_id")>]
        RepositoryEphemeralId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("repository_started_at")>]
        RepositoryStartedAt: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("repository_stopped_at")>]
        RepositoryStoppedAt: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("archived")>]
        Archived: bool
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_version")>]
        ClusterVersion: CoreTypes.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("request_counts")>]
        RequestCounts: RequestCounts
    }

    type ScriptCache = {
        [<System.Text.Json.Serialization.JsonPropertyName("cache_evictions")>]
        CacheEvictions: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("compilation_limit_triggered")>]
        CompilationLimitTriggered: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("compilations")>]
        Compilations: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("context")>]
        Context: string option
    }

    type Scripting = {
        [<System.Text.Json.Serialization.JsonPropertyName("cache_evictions")>]
        CacheEvictions: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("compilations")>]
        Compilations: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("compilations_history")>]
        CompilationsHistory: Map<string, CoreTypes.Long> option
        [<System.Text.Json.Serialization.JsonPropertyName("compilation_limit_triggered")>]
        CompilationLimitTriggered: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("contexts")>]
        Contexts: Context list option
    }

    type ThreadCount = {
        [<System.Text.Json.Serialization.JsonPropertyName("active")>]
        Active: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("completed")>]
        Completed: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("largest")>]
        Largest: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("queue")>]
        Queue: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("rejected")>]
        Rejected: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("threads")>]
        Threads: CoreTypes.Long option
    }

    type TransportHistogram = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("lt_millis")>]
        LtMillis: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("ge_millis")>]
        GeMillis: CoreTypes.Long option
    }

    type Transport = {
        [<System.Text.Json.Serialization.JsonPropertyName("inbound_handling_time_histogram")>]
        InboundHandlingTimeHistogram: TransportHistogram list option
        [<System.Text.Json.Serialization.JsonPropertyName("outbound_handling_time_histogram")>]
        OutboundHandlingTimeHistogram: TransportHistogram list option
        [<System.Text.Json.Serialization.JsonPropertyName("rx_count")>]
        RxCount: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("rx_size")>]
        RxSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("rx_size_in_bytes")>]
        RxSizeInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("server_open")>]
        ServerOpen: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("tx_count")>]
        TxCount: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("tx_size")>]
        TxSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("tx_size_in_bytes")>]
        TxSizeInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_outbound_connections")>]
        TotalOutboundConnections: CoreTypes.Long option
    }

    type Stats = {
        [<System.Text.Json.Serialization.JsonPropertyName("adaptive_selection")>]
        AdaptiveSelection: Map<string, AdaptiveSelection> option
        [<System.Text.Json.Serialization.JsonPropertyName("breakers")>]
        Breakers: Map<string, Breaker> option
        [<System.Text.Json.Serialization.JsonPropertyName("fs")>]
        Fs: FileSystem option
        [<System.Text.Json.Serialization.JsonPropertyName("host")>]
        Host: CoreTypes.Host option
        [<System.Text.Json.Serialization.JsonPropertyName("http")>]
        Http: Http option
        [<System.Text.Json.Serialization.JsonPropertyName("ingest")>]
        Ingest: Ingest option
        [<System.Text.Json.Serialization.JsonPropertyName("ip")>]
        Ip: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("jvm")>]
        Jvm: Jvm option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("os")>]
        Os: OperatingSystem option
        [<System.Text.Json.Serialization.JsonPropertyName("process")>]
        Process: Process option
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: CoreTypes.NodeRoles option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Scripting option
        [<System.Text.Json.Serialization.JsonPropertyName("script_cache")>]
        ScriptCache: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("thread_pool")>]
        ThreadPool: Map<string, ThreadCount> option
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("transport")>]
        Transport: Transport option
        [<System.Text.Json.Serialization.JsonPropertyName("transport_address")>]
        TransportAddress: CoreTypes.TransportAddress option
        [<System.Text.Json.Serialization.JsonPropertyName("attributes")>]
        Attributes: Map<CoreTypes.Field, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("discovery")>]
        Discovery: Discovery option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing_pressure")>]
        IndexingPressure: IndexingPressure option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: IndicesStats.ShardStats option
    }


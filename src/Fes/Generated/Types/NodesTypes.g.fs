// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module NodesTypes =

    type AdaptiveSelection = {
        [<System.Text.Json.Serialization.JsonPropertyName("avg_queue_size")>]
        AvgQueueSize: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("avg_response_time")>]
        AvgResponseTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("avg_response_time_ns")>]
        AvgResponseTimeNs: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("avg_service_time")>]
        AvgServiceTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("avg_service_time_ns")>]
        AvgServiceTimeNs: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("outgoing_searches")>]
        OutgoingSearches: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("rank")>]
        Rank: string option
    }

    type Breaker = {
        [<System.Text.Json.Serialization.JsonPropertyName("estimated_size")>]
        EstimatedSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("estimated_size_in_bytes")>]
        EstimatedSizeInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("limit_size")>]
        LimitSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("limit_size_in_bytes")>]
        LimitSizeInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("overhead")>]
        Overhead: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("tripped")>]
        Tripped: Types.Float option
    }

    type CpuAcct = {
        [<System.Text.Json.Serialization.JsonPropertyName("control_group")>]
        ControlGroup: string option
        [<System.Text.Json.Serialization.JsonPropertyName("usage_nanos")>]
        UsageNanos: Types.DurationValue<Types.UnitNanos> option
    }

    type CgroupCpuStat = {
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_elapsed_periods")>]
        NumberOfElapsedPeriods: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_times_throttled")>]
        NumberOfTimesThrottled: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("time_throttled_nanos")>]
        TimeThrottledNanos: Types.DurationValue<Types.UnitNanos> option
    }

    type CgroupCpu = {
        [<System.Text.Json.Serialization.JsonPropertyName("control_group")>]
        ControlGroup: string option
        [<System.Text.Json.Serialization.JsonPropertyName("cfs_period_micros")>]
        CfsPeriodMicros: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("cfs_quota_micros")>]
        CfsQuotaMicros: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("stat")>]
        Stat: NodesTypes.CgroupCpuStat option
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
        Cpuacct: NodesTypes.CpuAcct option
        [<System.Text.Json.Serialization.JsonPropertyName("cpu")>]
        Cpu: NodesTypes.CgroupCpu option
        [<System.Text.Json.Serialization.JsonPropertyName("memory")>]
        Memory: NodesTypes.CgroupMemory option
    }

    type Client = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("agent")>]
        Agent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("local_address")>]
        LocalAddress: string option
        [<System.Text.Json.Serialization.JsonPropertyName("remote_address")>]
        RemoteAddress: string option
        [<System.Text.Json.Serialization.JsonPropertyName("last_uri")>]
        LastUri: string option
        [<System.Text.Json.Serialization.JsonPropertyName("opened_time_millis")>]
        OpenedTimeMillis: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("closed_time_millis")>]
        ClosedTimeMillis: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("last_request_time_millis")>]
        LastRequestTimeMillis: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("request_count")>]
        RequestCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("request_size_bytes")>]
        RequestSizeBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("x_opaque_id")>]
        XOpaqueId: string option
    }

    type Recording = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string option
        [<System.Text.Json.Serialization.JsonPropertyName("cumulative_execution_count")>]
        CumulativeExecutionCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("cumulative_execution_time")>]
        CumulativeExecutionTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("cumulative_execution_time_millis")>]
        CumulativeExecutionTimeMillis: Types.DurationValue<Types.UnitMillis> option
    }

    type ClusterAppliedStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("recordings")>]
        Recordings: NodesTypes.Recording list option
    }

    type ClusterStateQueue = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("pending")>]
        Pending: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("committed")>]
        Committed: Types.Long option
    }

    type ClusterStateUpdate = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("computation_time")>]
        ComputationTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("computation_time_millis")>]
        ComputationTimeMillis: Types.DurationValue<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("publication_time")>]
        PublicationTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("publication_time_millis")>]
        PublicationTimeMillis: Types.DurationValue<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("context_construction_time")>]
        ContextConstructionTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("context_construction_time_millis")>]
        ContextConstructionTimeMillis: Types.DurationValue<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("commit_time")>]
        CommitTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("commit_time_millis")>]
        CommitTimeMillis: Types.DurationValue<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("completion_time")>]
        CompletionTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("completion_time_millis")>]
        CompletionTimeMillis: Types.DurationValue<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("master_apply_time")>]
        MasterApplyTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("master_apply_time_millis")>]
        MasterApplyTimeMillis: Types.DurationValue<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("notification_time")>]
        NotificationTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("notification_time_millis")>]
        NotificationTimeMillis: Types.DurationValue<Types.UnitMillis> option
    }

    type Context = {
        [<System.Text.Json.Serialization.JsonPropertyName("context")>]
        Context: string option
        [<System.Text.Json.Serialization.JsonPropertyName("compilations")>]
        Compilations: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("cache_evictions")>]
        CacheEvictions: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("compilation_limit_triggered")>]
        CompilationLimitTriggered: Types.Long option
    }

    type Cpu = {
        [<System.Text.Json.Serialization.JsonPropertyName("percent")>]
        Percent: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("sys")>]
        Sys: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("sys_in_millis")>]
        SysInMillis: Types.DurationValue<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_in_millis")>]
        TotalInMillis: Types.DurationValue<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("user")>]
        User: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("user_in_millis")>]
        UserInMillis: Types.DurationValue<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("load_average")>]
        LoadAverage: Map<string, Types.Double> option
    }

    type DataPathStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("available")>]
        Available: string option
        [<System.Text.Json.Serialization.JsonPropertyName("available_in_bytes")>]
        AvailableInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("disk_queue")>]
        DiskQueue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("disk_reads")>]
        DiskReads: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("disk_read_size")>]
        DiskReadSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("disk_read_size_in_bytes")>]
        DiskReadSizeInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("disk_writes")>]
        DiskWrites: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("disk_write_size")>]
        DiskWriteSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("disk_write_size_in_bytes")>]
        DiskWriteSizeInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("free")>]
        Free: string option
        [<System.Text.Json.Serialization.JsonPropertyName("free_in_bytes")>]
        FreeInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("mount")>]
        Mount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: string option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: string option
        [<System.Text.Json.Serialization.JsonPropertyName("total_in_bytes")>]
        TotalInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string option
    }

    type PublishedClusterStates = {
        [<System.Text.Json.Serialization.JsonPropertyName("full_states")>]
        FullStates: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("incompatible_diffs")>]
        IncompatibleDiffs: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("compatible_diffs")>]
        CompatibleDiffs: Types.Long option
    }

    type SerializedClusterStateDetail = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("uncompressed_size")>]
        UncompressedSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("uncompressed_size_in_bytes")>]
        UncompressedSizeInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("compressed_size")>]
        CompressedSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("compressed_size_in_bytes")>]
        CompressedSizeInBytes: Types.Long option
    }

    type SerializedClusterState = {
        [<System.Text.Json.Serialization.JsonPropertyName("full_states")>]
        FullStates: NodesTypes.SerializedClusterStateDetail option
        [<System.Text.Json.Serialization.JsonPropertyName("diffs")>]
        Diffs: NodesTypes.SerializedClusterStateDetail option
    }

    type Discovery = {
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_state_queue")>]
        ClusterStateQueue: NodesTypes.ClusterStateQueue option
        [<System.Text.Json.Serialization.JsonPropertyName("published_cluster_states")>]
        PublishedClusterStates: NodesTypes.PublishedClusterStates option
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_state_update")>]
        ClusterStateUpdate: Map<string, NodesTypes.ClusterStateUpdate> option
        [<System.Text.Json.Serialization.JsonPropertyName("serialized_cluster_states")>]
        SerializedClusterStates: NodesTypes.SerializedClusterState option
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_applier_stats")>]
        ClusterApplierStats: NodesTypes.ClusterAppliedStats option
    }

    type MemoryStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("adjusted_total_in_bytes")>]
        AdjustedTotalInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("resident")>]
        Resident: string option
        [<System.Text.Json.Serialization.JsonPropertyName("resident_in_bytes")>]
        ResidentInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("share")>]
        Share: string option
        [<System.Text.Json.Serialization.JsonPropertyName("share_in_bytes")>]
        ShareInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_virtual")>]
        TotalVirtual: string option
        [<System.Text.Json.Serialization.JsonPropertyName("total_virtual_in_bytes")>]
        TotalVirtualInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_in_bytes")>]
        TotalInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("free_in_bytes")>]
        FreeInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("used_in_bytes")>]
        UsedInBytes: Types.Long option
    }

    type ExtendedMemoryStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("free_percent")>]
        FreePercent: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("used_percent")>]
        UsedPercent: Types.Integer option
    }

    type FileSystemTotal = {
        [<System.Text.Json.Serialization.JsonPropertyName("available")>]
        Available: string option
        [<System.Text.Json.Serialization.JsonPropertyName("available_in_bytes")>]
        AvailableInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("free")>]
        Free: string option
        [<System.Text.Json.Serialization.JsonPropertyName("free_in_bytes")>]
        FreeInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: string option
        [<System.Text.Json.Serialization.JsonPropertyName("total_in_bytes")>]
        TotalInBytes: Types.Long option
    }

    type IoStatDevice = {
        [<System.Text.Json.Serialization.JsonPropertyName("device_name")>]
        DeviceName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("operations")>]
        Operations: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("read_kilobytes")>]
        ReadKilobytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("read_operations")>]
        ReadOperations: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("write_kilobytes")>]
        WriteKilobytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("write_operations")>]
        WriteOperations: Types.Long option
    }

    type IoStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("devices")>]
        Devices: NodesTypes.IoStatDevice list option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: NodesTypes.IoStatDevice option
    }

    type FileSystem = {
        [<System.Text.Json.Serialization.JsonPropertyName("data")>]
        Data: NodesTypes.DataPathStats list option
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: NodesTypes.FileSystemTotal option
        [<System.Text.Json.Serialization.JsonPropertyName("io_stats")>]
        IoStats: NodesTypes.IoStats option
    }

    type GarbageCollectorTotal = {
        [<System.Text.Json.Serialization.JsonPropertyName("collection_count")>]
        CollectionCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("collection_time")>]
        CollectionTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("collection_time_in_millis")>]
        CollectionTimeInMillis: Types.Long option
    }

    type GarbageCollector = {
        [<System.Text.Json.Serialization.JsonPropertyName("collectors")>]
        Collectors: Map<string, NodesTypes.GarbageCollectorTotal> option
    }

    type SizeHttpHistogram = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("ge_bytes")>]
        GeBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("lt_bytes")>]
        LtBytes: Types.Long option
    }

    type HttpRouteRequests = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_size_in_bytes")>]
        TotalSizeInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("size_histogram")>]
        SizeHistogram: NodesTypes.SizeHttpHistogram list
    }

    type TimeHttpHistogram = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("ge_millis")>]
        GeMillis: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("lt_millis")>]
        LtMillis: Types.Long option
    }

    type HttpRouteResponses = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_size_in_bytes")>]
        TotalSizeInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("handling_time_histogram")>]
        HandlingTimeHistogram: NodesTypes.TimeHttpHistogram list
        [<System.Text.Json.Serialization.JsonPropertyName("size_histogram")>]
        SizeHistogram: NodesTypes.SizeHttpHistogram list
    }

    type HttpRoute = {
        [<System.Text.Json.Serialization.JsonPropertyName("requests")>]
        Requests: NodesTypes.HttpRouteRequests
        [<System.Text.Json.Serialization.JsonPropertyName("responses")>]
        Responses: NodesTypes.HttpRouteResponses
    }

    type Http = {
        [<System.Text.Json.Serialization.JsonPropertyName("current_open")>]
        CurrentOpen: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("total_opened")>]
        TotalOpened: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("clients")>]
        Clients: NodesTypes.Client list option
        [<System.Text.Json.Serialization.JsonPropertyName("routes")>]
        Routes: Map<string, NodesTypes.HttpRoute>
    }

    type PressureMemory = {
        [<System.Text.Json.Serialization.JsonPropertyName("all")>]
        All: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("all_in_bytes")>]
        AllInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("combined_coordinating_and_primary")>]
        CombinedCoordinatingAndPrimary: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("combined_coordinating_and_primary_in_bytes")>]
        CombinedCoordinatingAndPrimaryInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("coordinating")>]
        Coordinating: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("coordinating_in_bytes")>]
        CoordinatingInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("primary")>]
        Primary: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("primary_in_bytes")>]
        PrimaryInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("replica")>]
        Replica: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("replica_in_bytes")>]
        ReplicaInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("coordinating_rejections")>]
        CoordinatingRejections: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("primary_rejections")>]
        PrimaryRejections: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("replica_rejections")>]
        ReplicaRejections: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("primary_document_rejections")>]
        PrimaryDocumentRejections: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("large_operation_rejections")>]
        LargeOperationRejections: Types.Long option
    }

    type IndexingPressureMemory = {
        [<System.Text.Json.Serialization.JsonPropertyName("limit")>]
        Limit: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("limit_in_bytes")>]
        LimitInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("current")>]
        Current: NodesTypes.PressureMemory option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: NodesTypes.PressureMemory option
    }

    type IndexingPressure = {
        [<System.Text.Json.Serialization.JsonPropertyName("memory")>]
        Memory: NodesTypes.IndexingPressureMemory option
    }

    type Processor = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("current")>]
        Current: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("failed")>]
        Failed: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_millis")>]
        TimeInMillis: Types.DurationValue<Types.UnitMillis> option
    }

    type KeyedProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("stats")>]
        Stats: NodesTypes.Processor option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string option
    }

    type IngestStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("current")>]
        Current: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("failed")>]
        Failed: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("processors")>]
        Processors: Map<string, NodesTypes.KeyedProcessor> list
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_millis")>]
        TimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("ingested_as_first_pipeline_in_bytes")>]
        IngestedAsFirstPipelineInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("produced_as_first_pipeline_in_bytes")>]
        ProducedAsFirstPipelineInBytes: Types.Long
    }

    type IngestTotal = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("current")>]
        Current: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("failed")>]
        Failed: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_millis")>]
        TimeInMillis: Types.DurationValue<Types.UnitMillis>
    }

    type Ingest = {
        [<System.Text.Json.Serialization.JsonPropertyName("pipelines")>]
        Pipelines: Map<string, NodesTypes.IngestStats> option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: NodesTypes.IngestTotal option
    }

    type NodeBufferPool = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_capacity")>]
        TotalCapacity: string option
        [<System.Text.Json.Serialization.JsonPropertyName("total_capacity_in_bytes")>]
        TotalCapacityInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("used")>]
        Used: string option
        [<System.Text.Json.Serialization.JsonPropertyName("used_in_bytes")>]
        UsedInBytes: Types.Long option
    }

    type JvmClasses = {
        [<System.Text.Json.Serialization.JsonPropertyName("current_loaded_count")>]
        CurrentLoadedCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_loaded_count")>]
        TotalLoadedCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_unloaded_count")>]
        TotalUnloadedCount: Types.Long option
    }

    type Pool = {
        [<System.Text.Json.Serialization.JsonPropertyName("used_in_bytes")>]
        UsedInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("max_in_bytes")>]
        MaxInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("peak_used_in_bytes")>]
        PeakUsedInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("peak_max_in_bytes")>]
        PeakMaxInBytes: Types.Long option
    }

    type JvmMemoryStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("heap_used_in_bytes")>]
        HeapUsedInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("heap_used_percent")>]
        HeapUsedPercent: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("heap_committed_in_bytes")>]
        HeapCommittedInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("heap_max_in_bytes")>]
        HeapMaxInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("heap_max")>]
        HeapMax: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("non_heap_used_in_bytes")>]
        NonHeapUsedInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("non_heap_committed_in_bytes")>]
        NonHeapCommittedInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("pools")>]
        Pools: Map<string, NodesTypes.Pool> option
    }

    type JvmThreads = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("peak_count")>]
        PeakCount: Types.Long option
    }

    type Jvm = {
        [<System.Text.Json.Serialization.JsonPropertyName("buffer_pools")>]
        BufferPools: Map<string, NodesTypes.NodeBufferPool> option
        [<System.Text.Json.Serialization.JsonPropertyName("classes")>]
        Classes: NodesTypes.JvmClasses option
        [<System.Text.Json.Serialization.JsonPropertyName("gc")>]
        Gc: NodesTypes.GarbageCollector option
        [<System.Text.Json.Serialization.JsonPropertyName("mem")>]
        Mem: NodesTypes.JvmMemoryStats option
        [<System.Text.Json.Serialization.JsonPropertyName("threads")>]
        Threads: NodesTypes.JvmThreads option
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("uptime")>]
        Uptime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("uptime_in_millis")>]
        UptimeInMillis: Types.Long option
    }

    type NodeReloadResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("reload_exception")>]
        ReloadException: Types.ErrorCause option
        [<System.Text.Json.Serialization.JsonPropertyName("secure_setting_names")>]
        SecureSettingNames: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("keystore_path")>]
        KeystorePath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("keystore_digest")>]
        KeystoreDigest: string option
        [<System.Text.Json.Serialization.JsonPropertyName("keystore_last_modified_time")>]
        KeystoreLastModifiedTime: Types.DateTime option
    }

    type NodesResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("_nodes")>]
        Nodes: Types.NodeStatistics option
    }

    type OperatingSystem = {
        [<System.Text.Json.Serialization.JsonPropertyName("cpu")>]
        Cpu: NodesTypes.Cpu option
        [<System.Text.Json.Serialization.JsonPropertyName("mem")>]
        Mem: NodesTypes.ExtendedMemoryStats option
        [<System.Text.Json.Serialization.JsonPropertyName("swap")>]
        Swap: NodesTypes.MemoryStats option
        [<System.Text.Json.Serialization.JsonPropertyName("cgroup")>]
        Cgroup: NodesTypes.Cgroup option
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.Long option
    }

    type Process = {
        [<System.Text.Json.Serialization.JsonPropertyName("cpu")>]
        Cpu: NodesTypes.Cpu option
        [<System.Text.Json.Serialization.JsonPropertyName("mem")>]
        Mem: NodesTypes.MemoryStats option
        [<System.Text.Json.Serialization.JsonPropertyName("open_file_descriptors")>]
        OpenFileDescriptors: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_file_descriptors")>]
        MaxFileDescriptors: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.Long option
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
        GetBlobProperties: Types.Long option
        GetBlob: Types.Long option
        ListBlobs: Types.Long option
        PutBlob: Types.Long option
        PutBlock: Types.Long option
        PutBlockList: Types.Long option
        GetObject: Types.Long option
        ListObjects: Types.Long option
        InsertObject: Types.Long option
        PutObject: Types.Long option
        PutMultipartObject: Types.Long option
    }

    type RepositoryMeteringInformation = {
        [<System.Text.Json.Serialization.JsonPropertyName("repository_name")>]
        RepositoryName: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("repository_type")>]
        RepositoryType: string
        [<System.Text.Json.Serialization.JsonPropertyName("repository_location")>]
        RepositoryLocation: NodesTypes.RepositoryLocation
        [<System.Text.Json.Serialization.JsonPropertyName("repository_ephemeral_id")>]
        RepositoryEphemeralId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("repository_started_at")>]
        RepositoryStartedAt: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("repository_stopped_at")>]
        RepositoryStoppedAt: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("archived")>]
        Archived: bool
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_version")>]
        ClusterVersion: Types.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("request_counts")>]
        RequestCounts: NodesTypes.RequestCounts
    }

    type ScriptCache = {
        [<System.Text.Json.Serialization.JsonPropertyName("cache_evictions")>]
        CacheEvictions: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("compilation_limit_triggered")>]
        CompilationLimitTriggered: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("compilations")>]
        Compilations: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("context")>]
        Context: string option
    }

    type Scripting = {
        [<System.Text.Json.Serialization.JsonPropertyName("cache_evictions")>]
        CacheEvictions: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("compilations")>]
        Compilations: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("compilations_history")>]
        CompilationsHistory: Map<string, Types.Long> option
        [<System.Text.Json.Serialization.JsonPropertyName("compilation_limit_triggered")>]
        CompilationLimitTriggered: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("contexts")>]
        Contexts: NodesTypes.Context list option
    }

    type ThreadCount = {
        [<System.Text.Json.Serialization.JsonPropertyName("active")>]
        Active: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("completed")>]
        Completed: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("largest")>]
        Largest: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("queue")>]
        Queue: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("rejected")>]
        Rejected: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("threads")>]
        Threads: Types.Long option
    }

    type TransportHistogram = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("lt_millis")>]
        LtMillis: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("ge_millis")>]
        GeMillis: Types.Long option
    }

    type Transport = {
        [<System.Text.Json.Serialization.JsonPropertyName("inbound_handling_time_histogram")>]
        InboundHandlingTimeHistogram: NodesTypes.TransportHistogram list option
        [<System.Text.Json.Serialization.JsonPropertyName("outbound_handling_time_histogram")>]
        OutboundHandlingTimeHistogram: NodesTypes.TransportHistogram list option
        [<System.Text.Json.Serialization.JsonPropertyName("rx_count")>]
        RxCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("rx_size")>]
        RxSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("rx_size_in_bytes")>]
        RxSizeInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("server_open")>]
        ServerOpen: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("tx_count")>]
        TxCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("tx_size")>]
        TxSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("tx_size_in_bytes")>]
        TxSizeInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_outbound_connections")>]
        TotalOutboundConnections: Types.Long option
    }

    type Stats = {
        [<System.Text.Json.Serialization.JsonPropertyName("adaptive_selection")>]
        AdaptiveSelection: Map<string, NodesTypes.AdaptiveSelection> option
        [<System.Text.Json.Serialization.JsonPropertyName("breakers")>]
        Breakers: Map<string, NodesTypes.Breaker> option
        [<System.Text.Json.Serialization.JsonPropertyName("fs")>]
        Fs: NodesTypes.FileSystem option
        [<System.Text.Json.Serialization.JsonPropertyName("host")>]
        Host: Types.Host option
        [<System.Text.Json.Serialization.JsonPropertyName("http")>]
        Http: NodesTypes.Http option
        [<System.Text.Json.Serialization.JsonPropertyName("ingest")>]
        Ingest: NodesTypes.Ingest option
        [<System.Text.Json.Serialization.JsonPropertyName("ip")>]
        Ip: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("jvm")>]
        Jvm: NodesTypes.Jvm option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("os")>]
        Os: NodesTypes.OperatingSystem option
        [<System.Text.Json.Serialization.JsonPropertyName("process")>]
        Process: NodesTypes.Process option
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: Types.NodeRoles option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: NodesTypes.Scripting option
        [<System.Text.Json.Serialization.JsonPropertyName("script_cache")>]
        ScriptCache: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("thread_pool")>]
        ThreadPool: Map<string, NodesTypes.ThreadCount> option
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("transport")>]
        Transport: NodesTypes.Transport option
        [<System.Text.Json.Serialization.JsonPropertyName("transport_address")>]
        TransportAddress: Types.TransportAddress option
        [<System.Text.Json.Serialization.JsonPropertyName("attributes")>]
        Attributes: Map<Types.Field, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("discovery")>]
        Discovery: NodesTypes.Discovery option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing_pressure")>]
        IndexingPressure: NodesTypes.IndexingPressure option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: IndicesStats.ShardStats option
    }


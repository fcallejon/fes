// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SnapshotTypes =

    type RepositorySettingsBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("chunk_size")>]
        ChunkSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("compress")>]
        Compress: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("max_restore_bytes_per_sec")>]
        MaxRestoreBytesPerSec: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("max_snapshot_bytes_per_sec")>]
        MaxSnapshotBytesPerSec: CoreTypes.ByteSize option
    }

    type AzureRepositorySettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("base_path")>]
        BasePath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("client")>]
        Client: string option
        [<System.Text.Json.Serialization.JsonPropertyName("container")>]
        Container: string option
        [<System.Text.Json.Serialization.JsonPropertyName("delete_objects_max_size")>]
        DeleteObjectsMaxSize: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("location_mode")>]
        LocationMode: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_concurrent_batch_deletes")>]
        MaxConcurrentBatchDeletes: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("readonly")>]
        Readonly: bool option
    }

    type RepositoryBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("uuid")>]
        Uuid: CoreTypes.Uuid option
    }

    type AzureRepository = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: AzureRepositorySettings option
    }

    type FileCountSnapshotStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("file_count")>]
        FileCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("size_in_bytes")>]
        SizeInBytes: CoreTypes.Long
    }

    type GcsRepositorySettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("bucket")>]
        Bucket: string
        [<System.Text.Json.Serialization.JsonPropertyName("application_name")>]
        ApplicationName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("base_path")>]
        BasePath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("client")>]
        Client: string option
        [<System.Text.Json.Serialization.JsonPropertyName("readonly")>]
        Readonly: bool option
    }

    type GcsRepository = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: GcsRepositorySettings
    }

    type IndexDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("shard_count")>]
        ShardCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("size_in_bytes")>]
        SizeInBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("max_segments_per_shard")>]
        MaxSegmentsPerShard: CoreTypes.Long
    }

    type InfoFeatureState = {
        [<System.Text.Json.Serialization.JsonPropertyName("feature_name")>]
        FeatureName: string
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: CoreTypes.Indices
    }

    type ReadOnlyUrlRepositorySettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("http_max_retries")>]
        HttpMaxRetries: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("http_socket_timeout")>]
        HttpSocketTimeout: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("max_number_of_snapshots")>]
        MaxNumberOfSnapshots: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("url")>]
        Url: string
    }

    type ReadOnlyUrlRepository = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: ReadOnlyUrlRepositorySettings
    }

    type S3RepositorySettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("bucket")>]
        Bucket: string
        [<System.Text.Json.Serialization.JsonPropertyName("base_path")>]
        BasePath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("buffer_size")>]
        BufferSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("canned_acl")>]
        CannedAcl: string option
        [<System.Text.Json.Serialization.JsonPropertyName("client")>]
        Client: string option
        [<System.Text.Json.Serialization.JsonPropertyName("delete_objects_max_size")>]
        DeleteObjectsMaxSize: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("get_register_retry_delay")>]
        GetRegisterRetryDelay: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("max_multipart_parts")>]
        MaxMultipartParts: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_multipart_upload_cleanup_size")>]
        MaxMultipartUploadCleanupSize: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("readonly")>]
        Readonly: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("server_side_encryption")>]
        ServerSideEncryption: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("storage_class")>]
        StorageClass: string option
        [<System.Text.Json.Serialization.JsonPropertyName("throttled_delete_retry.delay_increment")>]
        ThrottledDeleteRetryDelayIncrement: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("throttled_delete_retry.maximum_delay")>]
        ThrottledDeleteRetryMaximumDelay: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("throttled_delete_retry.maximum_number_of_retries")>]
        ThrottledDeleteRetryMaximumNumberOfRetries: CoreTypes.Integer option
    }

    type S3Repository = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: S3RepositorySettings
    }

    type SharedFileSystemRepositorySettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("location")>]
        Location: string
        [<System.Text.Json.Serialization.JsonPropertyName("max_number_of_snapshots")>]
        MaxNumberOfSnapshots: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("readonly")>]
        Readonly: bool option
    }

    type SharedFileSystemRepository = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: SharedFileSystemRepositorySettings
    }

    type SourceOnlyRepositorySettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("delegate_type")>]
        DelegateType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_number_of_snapshots")>]
        MaxNumberOfSnapshots: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("read_only")>]
        ReadOnly: bool option
    }

    type SourceOnlyRepository = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: SourceOnlyRepositorySettings
    }

    [<RequireQualifiedAccess>]
    type Repository =
        | AzureRepository of AzureRepository
        | GcsRepository of GcsRepository
        | S3Repository of S3Repository
        | SharedFileSystemRepository of SharedFileSystemRepository
        | ReadOnlyUrlRepository of ReadOnlyUrlRepository
        | SourceOnlyRepository of SourceOnlyRepository
        | Unknown of name: string * System.Text.Json.JsonElement

    type ShardsStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("done")>]
        Done: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("failed")>]
        Failed: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("finalizing")>]
        Finalizing: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("initializing")>]
        Initializing: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("started")>]
        Started: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.Long
    }

    [<RequireQualifiedAccess>]
    type ShardsStatsStage =
        | DONE
        | FAILURE
        | FINALIZE
        | INIT
        | STARTED

    type ShardsStatsSummaryItem = {
        [<System.Text.Json.Serialization.JsonPropertyName("file_count")>]
        FileCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("size_in_bytes")>]
        SizeInBytes: CoreTypes.Long
    }

    type ShardsStatsSummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("incremental")>]
        Incremental: ShardsStatsSummaryItem
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: ShardsStatsSummaryItem
        [<System.Text.Json.Serialization.JsonPropertyName("start_time_in_millis")>]
        StartTimeInMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("time")>]
        Time: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_millis")>]
        TimeInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
    }

    type SnapshotShardsStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("stage")>]
        Stage: ShardsStatsStage
        [<System.Text.Json.Serialization.JsonPropertyName("stats")>]
        Stats: ShardsStatsSummary
    }

    type SnapshotStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("incremental")>]
        Incremental: FileCountSnapshotStats
        [<System.Text.Json.Serialization.JsonPropertyName("start_time_in_millis")>]
        StartTimeInMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("time")>]
        Time: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_millis")>]
        TimeInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: FileCountSnapshotStats
    }

    type SnapshotIndexStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: Map<string, SnapshotShardsStatus>
        [<System.Text.Json.Serialization.JsonPropertyName("shards_stats")>]
        ShardsStats: ShardsStats
        [<System.Text.Json.Serialization.JsonPropertyName("stats")>]
        Stats: SnapshotStats
    }

    type SnapshotShardFailure = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("node_id")>]
        NodeId: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string
        [<System.Text.Json.Serialization.JsonPropertyName("shard_id")>]
        ShardId: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("index_uuid")>]
        IndexUuid: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: string
    }

    type SnapshotInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("data_streams")>]
        DataStreams: string list
        [<System.Text.Json.Serialization.JsonPropertyName("duration")>]
        Duration: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("duration_in_millis")>]
        DurationInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("end_time")>]
        EndTime: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("end_time_in_millis")>]
        EndTimeInMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("failures")>]
        Failures: SnapshotShardFailure list option
        [<System.Text.Json.Serialization.JsonPropertyName("include_global_state")>]
        IncludeGlobalState: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: CoreTypes.IndexName list option
        [<System.Text.Json.Serialization.JsonPropertyName("index_details")>]
        IndexDetails: Map<CoreTypes.IndexName, IndexDetails> option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: CoreTypes.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string option
        [<System.Text.Json.Serialization.JsonPropertyName("repository")>]
        Repository: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot")>]
        Snapshot: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: CoreTypes.ShardStatistics option
        [<System.Text.Json.Serialization.JsonPropertyName("start_time")>]
        StartTime: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("start_time_in_millis")>]
        StartTimeInMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: string option
        [<System.Text.Json.Serialization.JsonPropertyName("uuid")>]
        Uuid: CoreTypes.Uuid
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("version_id")>]
        VersionId: CoreTypes.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_states")>]
        FeatureStates: InfoFeatureState list option
    }

    [<RequireQualifiedAccess>]
    type SnapshotSort =
        | StartTime
        | Duration
        | Name
        | IndexCount
        | Repository
        | ShardCount
        | FailedShardCount

    [<RequireQualifiedAccess>]
    type SnapshotState =
        | INPROGRESS
        | SUCCESS
        | FAILED
        | PARTIAL
        | INCOMPATIBLE

    type Status = {
        [<System.Text.Json.Serialization.JsonPropertyName("include_global_state")>]
        IncludeGlobalState: bool
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: Map<string, SnapshotIndexStats>
        [<System.Text.Json.Serialization.JsonPropertyName("repository")>]
        Repository: string
        [<System.Text.Json.Serialization.JsonPropertyName("shards_stats")>]
        ShardsStats: ShardsStats
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot")>]
        Snapshot: string
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: string
        [<System.Text.Json.Serialization.JsonPropertyName("stats")>]
        Stats: SnapshotStats
        [<System.Text.Json.Serialization.JsonPropertyName("uuid")>]
        Uuid: CoreTypes.Uuid
    }


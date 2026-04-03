// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SnapshotTypes =

    type RepositorySettingsBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("chunk_size")>]
        ChunkSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("compress")>]
        Compress: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("max_restore_bytes_per_sec")>]
        MaxRestoreBytesPerSec: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("max_snapshot_bytes_per_sec")>]
        MaxSnapshotBytesPerSec: Types.ByteSize option
    }

    type AzureRepositorySettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("base_path")>]
        BasePath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("client")>]
        Client: string option
        [<System.Text.Json.Serialization.JsonPropertyName("container")>]
        Container: string option
        [<System.Text.Json.Serialization.JsonPropertyName("delete_objects_max_size")>]
        DeleteObjectsMaxSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("location_mode")>]
        LocationMode: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_concurrent_batch_deletes")>]
        MaxConcurrentBatchDeletes: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("readonly")>]
        Readonly: bool option
    }

    type RepositoryBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("uuid")>]
        Uuid: Types.Uuid option
    }

    type AzureRepository = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: SnapshotTypes.AzureRepositorySettings option
    }

    type FileCountSnapshotStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("file_count")>]
        FileCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("size_in_bytes")>]
        SizeInBytes: Types.Long
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
        Settings: SnapshotTypes.GcsRepositorySettings
    }

    type IndexDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("shard_count")>]
        ShardCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("size_in_bytes")>]
        SizeInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("max_segments_per_shard")>]
        MaxSegmentsPerShard: Types.Long
    }

    type InfoFeatureState = {
        [<System.Text.Json.Serialization.JsonPropertyName("feature_name")>]
        FeatureName: string
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: Types.Indices
    }

    type ReadOnlyUrlRepositorySettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("http_max_retries")>]
        HttpMaxRetries: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("http_socket_timeout")>]
        HttpSocketTimeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("max_number_of_snapshots")>]
        MaxNumberOfSnapshots: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("url")>]
        Url: string
    }

    type ReadOnlyUrlRepository = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: SnapshotTypes.ReadOnlyUrlRepositorySettings
    }

    type S3RepositorySettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("bucket")>]
        Bucket: string
        [<System.Text.Json.Serialization.JsonPropertyName("base_path")>]
        BasePath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("buffer_size")>]
        BufferSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("canned_acl")>]
        CannedAcl: string option
        [<System.Text.Json.Serialization.JsonPropertyName("client")>]
        Client: string option
        [<System.Text.Json.Serialization.JsonPropertyName("delete_objects_max_size")>]
        DeleteObjectsMaxSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("get_register_retry_delay")>]
        GetRegisterRetryDelay: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("max_multipart_parts")>]
        MaxMultipartParts: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_multipart_upload_cleanup_size")>]
        MaxMultipartUploadCleanupSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("readonly")>]
        Readonly: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("server_side_encryption")>]
        ServerSideEncryption: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("storage_class")>]
        StorageClass: string option
        [<System.Text.Json.Serialization.JsonPropertyName("throttled_delete_retry.delay_increment")>]
        ThrottledDeleteRetryDelayIncrement: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("throttled_delete_retry.maximum_delay")>]
        ThrottledDeleteRetryMaximumDelay: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("throttled_delete_retry.maximum_number_of_retries")>]
        ThrottledDeleteRetryMaximumNumberOfRetries: Types.Integer option
    }

    type S3Repository = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: SnapshotTypes.S3RepositorySettings
    }

    type SharedFileSystemRepositorySettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("location")>]
        Location: string
        [<System.Text.Json.Serialization.JsonPropertyName("max_number_of_snapshots")>]
        MaxNumberOfSnapshots: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("readonly")>]
        Readonly: bool option
    }

    type SharedFileSystemRepository = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: SnapshotTypes.SharedFileSystemRepositorySettings
    }

    type SourceOnlyRepositorySettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("delegate_type")>]
        DelegateType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_number_of_snapshots")>]
        MaxNumberOfSnapshots: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("read_only")>]
        ReadOnly: bool option
    }

    type SourceOnlyRepository = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: SnapshotTypes.SourceOnlyRepositorySettings
    }

    [<RequireQualifiedAccess>]
    type Repository =
        | AzureRepository of SnapshotTypes.AzureRepository
        | GcsRepository of SnapshotTypes.GcsRepository
        | S3Repository of SnapshotTypes.S3Repository
        | SharedFileSystemRepository of SnapshotTypes.SharedFileSystemRepository
        | ReadOnlyUrlRepository of SnapshotTypes.ReadOnlyUrlRepository
        | SourceOnlyRepository of SnapshotTypes.SourceOnlyRepository
        | Unknown of name: string * System.Text.Json.JsonElement

    type ShardsStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("done")>]
        Done: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("failed")>]
        Failed: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("finalizing")>]
        Finalizing: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("initializing")>]
        Initializing: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("started")>]
        Started: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Long
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
        FileCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("size_in_bytes")>]
        SizeInBytes: Types.Long
    }

    type ShardsStatsSummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("incremental")>]
        Incremental: SnapshotTypes.ShardsStatsSummaryItem
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: SnapshotTypes.ShardsStatsSummaryItem
        [<System.Text.Json.Serialization.JsonPropertyName("start_time_in_millis")>]
        StartTimeInMillis: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("time")>]
        Time: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_millis")>]
        TimeInMillis: Types.DurationValue<Types.UnitMillis>
    }

    type SnapshotShardsStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("stage")>]
        Stage: SnapshotTypes.ShardsStatsStage
        [<System.Text.Json.Serialization.JsonPropertyName("stats")>]
        Stats: SnapshotTypes.ShardsStatsSummary
    }

    type SnapshotStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("incremental")>]
        Incremental: SnapshotTypes.FileCountSnapshotStats
        [<System.Text.Json.Serialization.JsonPropertyName("start_time_in_millis")>]
        StartTimeInMillis: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("time")>]
        Time: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_millis")>]
        TimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: SnapshotTypes.FileCountSnapshotStats
    }

    type SnapshotIndexStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: Map<string, SnapshotTypes.SnapshotShardsStatus>
        [<System.Text.Json.Serialization.JsonPropertyName("shards_stats")>]
        ShardsStats: SnapshotTypes.ShardsStats
        [<System.Text.Json.Serialization.JsonPropertyName("stats")>]
        Stats: SnapshotTypes.SnapshotStats
    }

    type SnapshotShardFailure = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("node_id")>]
        NodeId: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string
        [<System.Text.Json.Serialization.JsonPropertyName("shard_id")>]
        ShardId: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("index_uuid")>]
        IndexUuid: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: string
    }

    type SnapshotInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("data_streams")>]
        DataStreams: string list
        [<System.Text.Json.Serialization.JsonPropertyName("duration")>]
        Duration: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("duration_in_millis")>]
        DurationInMillis: Types.DurationValue<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("end_time")>]
        EndTime: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("end_time_in_millis")>]
        EndTimeInMillis: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("failures")>]
        Failures: SnapshotTypes.SnapshotShardFailure list option
        [<System.Text.Json.Serialization.JsonPropertyName("include_global_state")>]
        IncludeGlobalState: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: Types.IndexName list option
        [<System.Text.Json.Serialization.JsonPropertyName("index_details")>]
        IndexDetails: Map<Types.IndexName, SnapshotTypes.IndexDetails> option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string option
        [<System.Text.Json.Serialization.JsonPropertyName("repository")>]
        Repository: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot")>]
        Snapshot: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: Types.ShardStatistics option
        [<System.Text.Json.Serialization.JsonPropertyName("start_time")>]
        StartTime: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("start_time_in_millis")>]
        StartTimeInMillis: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: string option
        [<System.Text.Json.Serialization.JsonPropertyName("uuid")>]
        Uuid: Types.Uuid
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("version_id")>]
        VersionId: Types.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_states")>]
        FeatureStates: SnapshotTypes.InfoFeatureState list option
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
        Indices: Map<string, SnapshotTypes.SnapshotIndexStats>
        [<System.Text.Json.Serialization.JsonPropertyName("repository")>]
        Repository: string
        [<System.Text.Json.Serialization.JsonPropertyName("shards_stats")>]
        ShardsStats: SnapshotTypes.ShardsStats
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot")>]
        Snapshot: string
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: string
        [<System.Text.Json.Serialization.JsonPropertyName("stats")>]
        Stats: SnapshotTypes.SnapshotStats
        [<System.Text.Json.Serialization.JsonPropertyName("uuid")>]
        Uuid: Types.Uuid
    }


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CcrTypes =

    type ReadException = {
        [<System.Text.Json.Serialization.JsonPropertyName("exception")>]
        Exception: CoreTypes.ErrorCause
        [<System.Text.Json.Serialization.JsonPropertyName("from_seq_no")>]
        FromSeqNo: CoreTypes.SequenceNumber
        [<System.Text.Json.Serialization.JsonPropertyName("retries")>]
        Retries: CoreTypes.Integer
    }

    type ShardStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("bytes_read")>]
        BytesRead: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("failed_read_requests")>]
        FailedReadRequests: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("failed_write_requests")>]
        FailedWriteRequests: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("fatal_exception")>]
        FatalException: CoreTypes.ErrorCause option
        [<System.Text.Json.Serialization.JsonPropertyName("follower_aliases_version")>]
        FollowerAliasesVersion: CoreTypes.VersionNumber
        [<System.Text.Json.Serialization.JsonPropertyName("follower_global_checkpoint")>]
        FollowerGlobalCheckpoint: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("follower_index")>]
        FollowerIndex: string
        [<System.Text.Json.Serialization.JsonPropertyName("follower_mapping_version")>]
        FollowerMappingVersion: CoreTypes.VersionNumber
        [<System.Text.Json.Serialization.JsonPropertyName("follower_max_seq_no")>]
        FollowerMaxSeqNo: CoreTypes.SequenceNumber
        [<System.Text.Json.Serialization.JsonPropertyName("follower_settings_version")>]
        FollowerSettingsVersion: CoreTypes.VersionNumber
        [<System.Text.Json.Serialization.JsonPropertyName("last_requested_seq_no")>]
        LastRequestedSeqNo: CoreTypes.SequenceNumber
        [<System.Text.Json.Serialization.JsonPropertyName("leader_global_checkpoint")>]
        LeaderGlobalCheckpoint: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("leader_index")>]
        LeaderIndex: string
        [<System.Text.Json.Serialization.JsonPropertyName("leader_max_seq_no")>]
        LeaderMaxSeqNo: CoreTypes.SequenceNumber
        [<System.Text.Json.Serialization.JsonPropertyName("operations_read")>]
        OperationsRead: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("operations_written")>]
        OperationsWritten: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("outstanding_read_requests")>]
        OutstandingReadRequests: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("outstanding_write_requests")>]
        OutstandingWriteRequests: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("read_exceptions")>]
        ReadExceptions: ReadException list
        [<System.Text.Json.Serialization.JsonPropertyName("remote_cluster")>]
        RemoteCluster: string
        [<System.Text.Json.Serialization.JsonPropertyName("shard_id")>]
        ShardId: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("successful_read_requests")>]
        SuccessfulReadRequests: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("successful_write_requests")>]
        SuccessfulWriteRequests: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("time_since_last_read")>]
        TimeSinceLastRead: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("time_since_last_read_millis")>]
        TimeSinceLastReadMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("total_read_remote_exec_time")>]
        TotalReadRemoteExecTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_read_remote_exec_time_millis")>]
        TotalReadRemoteExecTimeMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("total_read_time")>]
        TotalReadTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_read_time_millis")>]
        TotalReadTimeMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("total_write_time")>]
        TotalWriteTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_write_time_millis")>]
        TotalWriteTimeMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("write_buffer_operation_count")>]
        WriteBufferOperationCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("write_buffer_size_in_bytes")>]
        WriteBufferSizeInBytes: CoreTypes.ByteSize
    }

    type FollowIndexStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: ShardStats list
    }


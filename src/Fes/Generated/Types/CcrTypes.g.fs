// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CcrTypes =

    type ReadException = {
        [<System.Text.Json.Serialization.JsonPropertyName("exception")>]
        Exception: Types.ErrorCause
        [<System.Text.Json.Serialization.JsonPropertyName("from_seq_no")>]
        FromSeqNo: Types.SequenceNumber
        [<System.Text.Json.Serialization.JsonPropertyName("retries")>]
        Retries: Types.Integer
    }

    type ShardStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("bytes_read")>]
        BytesRead: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("failed_read_requests")>]
        FailedReadRequests: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("failed_write_requests")>]
        FailedWriteRequests: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("fatal_exception")>]
        FatalException: Types.ErrorCause option
        [<System.Text.Json.Serialization.JsonPropertyName("follower_aliases_version")>]
        FollowerAliasesVersion: Types.VersionNumber
        [<System.Text.Json.Serialization.JsonPropertyName("follower_global_checkpoint")>]
        FollowerGlobalCheckpoint: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("follower_index")>]
        FollowerIndex: string
        [<System.Text.Json.Serialization.JsonPropertyName("follower_mapping_version")>]
        FollowerMappingVersion: Types.VersionNumber
        [<System.Text.Json.Serialization.JsonPropertyName("follower_max_seq_no")>]
        FollowerMaxSeqNo: Types.SequenceNumber
        [<System.Text.Json.Serialization.JsonPropertyName("follower_settings_version")>]
        FollowerSettingsVersion: Types.VersionNumber
        [<System.Text.Json.Serialization.JsonPropertyName("last_requested_seq_no")>]
        LastRequestedSeqNo: Types.SequenceNumber
        [<System.Text.Json.Serialization.JsonPropertyName("leader_global_checkpoint")>]
        LeaderGlobalCheckpoint: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("leader_index")>]
        LeaderIndex: string
        [<System.Text.Json.Serialization.JsonPropertyName("leader_max_seq_no")>]
        LeaderMaxSeqNo: Types.SequenceNumber
        [<System.Text.Json.Serialization.JsonPropertyName("operations_read")>]
        OperationsRead: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("operations_written")>]
        OperationsWritten: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("outstanding_read_requests")>]
        OutstandingReadRequests: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("outstanding_write_requests")>]
        OutstandingWriteRequests: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("read_exceptions")>]
        ReadExceptions: CcrTypes.ReadException list
        [<System.Text.Json.Serialization.JsonPropertyName("remote_cluster")>]
        RemoteCluster: string
        [<System.Text.Json.Serialization.JsonPropertyName("shard_id")>]
        ShardId: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("successful_read_requests")>]
        SuccessfulReadRequests: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("successful_write_requests")>]
        SuccessfulWriteRequests: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("time_since_last_read")>]
        TimeSinceLastRead: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("time_since_last_read_millis")>]
        TimeSinceLastReadMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("total_read_remote_exec_time")>]
        TotalReadRemoteExecTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_read_remote_exec_time_millis")>]
        TotalReadRemoteExecTimeMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("total_read_time")>]
        TotalReadTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_read_time_millis")>]
        TotalReadTimeMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("total_write_time")>]
        TotalWriteTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_write_time_millis")>]
        TotalWriteTimeMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("write_buffer_operation_count")>]
        WriteBufferOperationCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("write_buffer_size_in_bytes")>]
        WriteBufferSizeInBytes: Types.ByteSize
    }

    type FollowIndexStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: CcrTypes.ShardStats list
    }


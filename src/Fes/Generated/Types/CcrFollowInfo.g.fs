// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CcrFollowInfo =

    type FollowerIndexParameters = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_outstanding_read_requests")>]
        MaxOutstandingReadRequests: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("max_outstanding_write_requests")>]
        MaxOutstandingWriteRequests: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_read_request_operation_count")>]
        MaxReadRequestOperationCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_read_request_size")>]
        MaxReadRequestSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("max_retry_delay")>]
        MaxRetryDelay: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("max_write_buffer_count")>]
        MaxWriteBufferCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_write_buffer_size")>]
        MaxWriteBufferSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("max_write_request_operation_count")>]
        MaxWriteRequestOperationCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_write_request_size")>]
        MaxWriteRequestSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("read_poll_timeout")>]
        ReadPollTimeout: Types.Duration option
    }

    [<RequireQualifiedAccess>]
    type FollowerIndexStatus =
        | Active
        | Paused

    type FollowerIndex = {
        [<System.Text.Json.Serialization.JsonPropertyName("follower_index")>]
        FollowerIndex: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("leader_index")>]
        LeaderIndex: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("parameters")>]
        Parameters: CcrFollowInfo.FollowerIndexParameters option
        [<System.Text.Json.Serialization.JsonPropertyName("remote_cluster")>]
        RemoteCluster: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: CcrFollowInfo.FollowerIndexStatus
    }


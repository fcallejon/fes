// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CcrFollowInfo =

    type FollowerIndexParameters = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_outstanding_read_requests")>]
        MaxOutstandingReadRequests: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("max_outstanding_write_requests")>]
        MaxOutstandingWriteRequests: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_read_request_operation_count")>]
        MaxReadRequestOperationCount: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_read_request_size")>]
        MaxReadRequestSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("max_retry_delay")>]
        MaxRetryDelay: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("max_write_buffer_count")>]
        MaxWriteBufferCount: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_write_buffer_size")>]
        MaxWriteBufferSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("max_write_request_operation_count")>]
        MaxWriteRequestOperationCount: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_write_request_size")>]
        MaxWriteRequestSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("read_poll_timeout")>]
        ReadPollTimeout: CoreTypes.Duration option
    }

    [<RequireQualifiedAccess>]
    type FollowerIndexStatus =
        | Active
        | Paused

    type FollowerIndex = {
        [<System.Text.Json.Serialization.JsonPropertyName("follower_index")>]
        FollowerIndex: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("leader_index")>]
        LeaderIndex: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("parameters")>]
        Parameters: FollowerIndexParameters option
        [<System.Text.Json.Serialization.JsonPropertyName("remote_cluster")>]
        RemoteCluster: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: FollowerIndexStatus
    }


// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module CcrOperations =

    type CcrGetAutoFollowPatternRequest = {
        [<JsonPropertyName("name")>]
        Name: Name
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: CcrGetAutoFollowPatternRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ccr/auto_follow/{request.Name}"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module CcrGetAutoFollowPatternRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CcrGetAutoFollowPatternRequest) : Result<Fes.Http.RequestMsg, exn> =
            CcrGetAutoFollowPatternRequest.ToRequest request

    type CcrGetAutoFollowPatternRequestBuilder() =
        member _.Yield(_: unit) : CcrGetAutoFollowPatternRequest =
            {
                CcrGetAutoFollowPatternRequest.Name = Unchecked.defaultof<Name>
                CcrGetAutoFollowPatternRequest.MasterTimeout = Option.None
            } : CcrGetAutoFollowPatternRequest

        [<CustomOperation("name")>]
        member _.Name(state: CcrGetAutoFollowPatternRequest, value: Name) =
            { state with CcrGetAutoFollowPatternRequest.Name = value } : CcrGetAutoFollowPatternRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CcrGetAutoFollowPatternRequest, value: Duration) =
            { state with CcrGetAutoFollowPatternRequest.MasterTimeout = Option.Some value } : CcrGetAutoFollowPatternRequest

    let ccrGetAutoFollowPatternRequest = CcrGetAutoFollowPatternRequestBuilder()

    type CcrPutAutoFollowPatternRequest = {
        [<JsonPropertyName("name")>]
        Name: Name
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
        [<JsonPropertyName("remote_cluster")>]
        RemoteCluster: string
        [<JsonPropertyName("follow_index_pattern")>]
        FollowIndexPattern: IndexPattern option
        [<JsonPropertyName("leader_index_patterns")>]
        LeaderIndexPatterns: IndexPatterns option
        [<JsonPropertyName("leader_index_exclusion_patterns")>]
        LeaderIndexExclusionPatterns: IndexPatterns option
        [<JsonPropertyName("max_outstanding_read_requests")>]
        MaxOutstandingReadRequests: float option
        [<JsonPropertyName("settings")>]
        Settings: Map<string, obj> option
        [<JsonPropertyName("max_outstanding_write_requests")>]
        MaxOutstandingWriteRequests: float option
        [<JsonPropertyName("read_poll_timeout")>]
        ReadPollTimeout: Duration option
        [<JsonPropertyName("max_read_request_operation_count")>]
        MaxReadRequestOperationCount: float option
        [<JsonPropertyName("max_read_request_size")>]
        MaxReadRequestSize: ByteSize option
        [<JsonPropertyName("max_retry_delay")>]
        MaxRetryDelay: Duration option
        [<JsonPropertyName("max_write_buffer_count")>]
        MaxWriteBufferCount: float option
        [<JsonPropertyName("max_write_buffer_size")>]
        MaxWriteBufferSize: ByteSize option
        [<JsonPropertyName("max_write_request_operation_count")>]
        MaxWriteRequestOperationCount: float option
        [<JsonPropertyName("max_write_request_size")>]
        MaxWriteRequestSize: ByteSize option
    } with
        static member ToRequest(request: CcrPutAutoFollowPatternRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ccr/auto_follow/{request.Name}"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module CcrPutAutoFollowPatternRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CcrPutAutoFollowPatternRequest) : Result<Fes.Http.RequestMsg, exn> =
            CcrPutAutoFollowPatternRequest.ToRequest request

    type CcrPutAutoFollowPatternRequestBuilder() =
        member _.Yield(_: unit) : CcrPutAutoFollowPatternRequest =
            {
                CcrPutAutoFollowPatternRequest.Name = Unchecked.defaultof<Name>
                CcrPutAutoFollowPatternRequest.MasterTimeout = Option.None
                CcrPutAutoFollowPatternRequest.RemoteCluster = String.Empty
                CcrPutAutoFollowPatternRequest.FollowIndexPattern = Option.None
                CcrPutAutoFollowPatternRequest.LeaderIndexPatterns = Option.None
                CcrPutAutoFollowPatternRequest.LeaderIndexExclusionPatterns = Option.None
                CcrPutAutoFollowPatternRequest.MaxOutstandingReadRequests = Option.None
                CcrPutAutoFollowPatternRequest.Settings = Option.None
                CcrPutAutoFollowPatternRequest.MaxOutstandingWriteRequests = Option.None
                CcrPutAutoFollowPatternRequest.ReadPollTimeout = Option.None
                CcrPutAutoFollowPatternRequest.MaxReadRequestOperationCount = Option.None
                CcrPutAutoFollowPatternRequest.MaxReadRequestSize = Option.None
                CcrPutAutoFollowPatternRequest.MaxRetryDelay = Option.None
                CcrPutAutoFollowPatternRequest.MaxWriteBufferCount = Option.None
                CcrPutAutoFollowPatternRequest.MaxWriteBufferSize = Option.None
                CcrPutAutoFollowPatternRequest.MaxWriteRequestOperationCount = Option.None
                CcrPutAutoFollowPatternRequest.MaxWriteRequestSize = Option.None
            } : CcrPutAutoFollowPatternRequest

        [<CustomOperation("name")>]
        member _.Name(state: CcrPutAutoFollowPatternRequest, value: Name) =
            { state with CcrPutAutoFollowPatternRequest.Name = value } : CcrPutAutoFollowPatternRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CcrPutAutoFollowPatternRequest, value: Duration) =
            { state with CcrPutAutoFollowPatternRequest.MasterTimeout = Option.Some value } : CcrPutAutoFollowPatternRequest

        [<CustomOperation("remote_cluster")>]
        member _.RemoteCluster(state: CcrPutAutoFollowPatternRequest, value: string) =
            { state with CcrPutAutoFollowPatternRequest.RemoteCluster = value } : CcrPutAutoFollowPatternRequest

        [<CustomOperation("follow_index_pattern")>]
        member _.FollowIndexPattern(state: CcrPutAutoFollowPatternRequest, value: IndexPattern) =
            { state with CcrPutAutoFollowPatternRequest.FollowIndexPattern = Option.Some value } : CcrPutAutoFollowPatternRequest

        [<CustomOperation("leader_index_patterns")>]
        member _.LeaderIndexPatterns(state: CcrPutAutoFollowPatternRequest, value: IndexPatterns) =
            { state with CcrPutAutoFollowPatternRequest.LeaderIndexPatterns = Option.Some value } : CcrPutAutoFollowPatternRequest

        [<CustomOperation("leader_index_exclusion_patterns")>]
        member _.LeaderIndexExclusionPatterns(state: CcrPutAutoFollowPatternRequest, value: IndexPatterns) =
            { state with CcrPutAutoFollowPatternRequest.LeaderIndexExclusionPatterns = Option.Some value } : CcrPutAutoFollowPatternRequest

        [<CustomOperation("max_outstanding_read_requests")>]
        member _.MaxOutstandingReadRequests(state: CcrPutAutoFollowPatternRequest, value: float) =
            { state with CcrPutAutoFollowPatternRequest.MaxOutstandingReadRequests = Option.Some value } : CcrPutAutoFollowPatternRequest

        [<CustomOperation("settings")>]
        member _.Settings(state: CcrPutAutoFollowPatternRequest, value: Map<string, obj>) =
            { state with CcrPutAutoFollowPatternRequest.Settings = Option.Some value } : CcrPutAutoFollowPatternRequest

        [<CustomOperation("max_outstanding_write_requests")>]
        member _.MaxOutstandingWriteRequests(state: CcrPutAutoFollowPatternRequest, value: float) =
            { state with CcrPutAutoFollowPatternRequest.MaxOutstandingWriteRequests = Option.Some value } : CcrPutAutoFollowPatternRequest

        [<CustomOperation("read_poll_timeout")>]
        member _.ReadPollTimeout(state: CcrPutAutoFollowPatternRequest, value: Duration) =
            { state with CcrPutAutoFollowPatternRequest.ReadPollTimeout = Option.Some value } : CcrPutAutoFollowPatternRequest

        [<CustomOperation("max_read_request_operation_count")>]
        member _.MaxReadRequestOperationCount(state: CcrPutAutoFollowPatternRequest, value: float) =
            { state with CcrPutAutoFollowPatternRequest.MaxReadRequestOperationCount = Option.Some value } : CcrPutAutoFollowPatternRequest

        [<CustomOperation("max_read_request_size")>]
        member _.MaxReadRequestSize(state: CcrPutAutoFollowPatternRequest, value: ByteSize) =
            { state with CcrPutAutoFollowPatternRequest.MaxReadRequestSize = Option.Some value } : CcrPutAutoFollowPatternRequest

        [<CustomOperation("max_retry_delay")>]
        member _.MaxRetryDelay(state: CcrPutAutoFollowPatternRequest, value: Duration) =
            { state with CcrPutAutoFollowPatternRequest.MaxRetryDelay = Option.Some value } : CcrPutAutoFollowPatternRequest

        [<CustomOperation("max_write_buffer_count")>]
        member _.MaxWriteBufferCount(state: CcrPutAutoFollowPatternRequest, value: float) =
            { state with CcrPutAutoFollowPatternRequest.MaxWriteBufferCount = Option.Some value } : CcrPutAutoFollowPatternRequest

        [<CustomOperation("max_write_buffer_size")>]
        member _.MaxWriteBufferSize(state: CcrPutAutoFollowPatternRequest, value: ByteSize) =
            { state with CcrPutAutoFollowPatternRequest.MaxWriteBufferSize = Option.Some value } : CcrPutAutoFollowPatternRequest

        [<CustomOperation("max_write_request_operation_count")>]
        member _.MaxWriteRequestOperationCount(state: CcrPutAutoFollowPatternRequest, value: float) =
            { state with CcrPutAutoFollowPatternRequest.MaxWriteRequestOperationCount = Option.Some value } : CcrPutAutoFollowPatternRequest

        [<CustomOperation("max_write_request_size")>]
        member _.MaxWriteRequestSize(state: CcrPutAutoFollowPatternRequest, value: ByteSize) =
            { state with CcrPutAutoFollowPatternRequest.MaxWriteRequestSize = Option.Some value } : CcrPutAutoFollowPatternRequest

    let ccrPutAutoFollowPatternRequest = CcrPutAutoFollowPatternRequestBuilder()

    type CcrPutAutoFollowPatternResponse = AcknowledgedResponseBase

    type CcrDeleteAutoFollowPatternRequest = {
        [<JsonPropertyName("name")>]
        Name: Name
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: CcrDeleteAutoFollowPatternRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ccr/auto_follow/{request.Name}"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module CcrDeleteAutoFollowPatternRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CcrDeleteAutoFollowPatternRequest) : Result<Fes.Http.RequestMsg, exn> =
            CcrDeleteAutoFollowPatternRequest.ToRequest request

    type CcrDeleteAutoFollowPatternRequestBuilder() =
        member _.Yield(_: unit) : CcrDeleteAutoFollowPatternRequest =
            {
                CcrDeleteAutoFollowPatternRequest.Name = Unchecked.defaultof<Name>
                CcrDeleteAutoFollowPatternRequest.MasterTimeout = Option.None
            } : CcrDeleteAutoFollowPatternRequest

        [<CustomOperation("name")>]
        member _.Name(state: CcrDeleteAutoFollowPatternRequest, value: Name) =
            { state with CcrDeleteAutoFollowPatternRequest.Name = value } : CcrDeleteAutoFollowPatternRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CcrDeleteAutoFollowPatternRequest, value: Duration) =
            { state with CcrDeleteAutoFollowPatternRequest.MasterTimeout = Option.Some value } : CcrDeleteAutoFollowPatternRequest

    let ccrDeleteAutoFollowPatternRequest = CcrDeleteAutoFollowPatternRequestBuilder()

    type CcrDeleteAutoFollowPatternResponse = AcknowledgedResponseBase

    type CcrFollowRequest = {
        [<JsonPropertyName("index")>]
        Index: IndexName
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
        [<JsonPropertyName("wait_for_active_shards")>]
        WaitForActiveShards: WaitForActiveShards option
        [<JsonPropertyName("data_stream_name")>]
        DataStreamName: string option
        [<JsonPropertyName("leader_index")>]
        LeaderIndex: IndexName
        [<JsonPropertyName("max_outstanding_read_requests")>]
        MaxOutstandingReadRequests: float option
        [<JsonPropertyName("max_outstanding_write_requests")>]
        MaxOutstandingWriteRequests: float option
        [<JsonPropertyName("max_read_request_operation_count")>]
        MaxReadRequestOperationCount: float option
        [<JsonPropertyName("max_read_request_size")>]
        MaxReadRequestSize: ByteSize option
        [<JsonPropertyName("max_retry_delay")>]
        MaxRetryDelay: Duration option
        [<JsonPropertyName("max_write_buffer_count")>]
        MaxWriteBufferCount: float option
        [<JsonPropertyName("max_write_buffer_size")>]
        MaxWriteBufferSize: ByteSize option
        [<JsonPropertyName("max_write_request_operation_count")>]
        MaxWriteRequestOperationCount: float option
        [<JsonPropertyName("max_write_request_size")>]
        MaxWriteRequestSize: ByteSize option
        [<JsonPropertyName("read_poll_timeout")>]
        ReadPollTimeout: Duration option
        [<JsonPropertyName("remote_cluster")>]
        RemoteCluster: string
        [<JsonPropertyName("settings")>]
        Settings: TypesIndexSettings option
    } with
        static member ToRequest(request: CcrFollowRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_ccr/follow"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                        request.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module CcrFollowRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CcrFollowRequest) : Result<Fes.Http.RequestMsg, exn> =
            CcrFollowRequest.ToRequest request

    type CcrFollowRequestBuilder() =
        member _.Yield(_: unit) : CcrFollowRequest =
            {
                CcrFollowRequest.Index = Unchecked.defaultof<IndexName>
                CcrFollowRequest.MasterTimeout = Option.None
                CcrFollowRequest.WaitForActiveShards = Option.None
                CcrFollowRequest.DataStreamName = Option.None
                CcrFollowRequest.LeaderIndex = Unchecked.defaultof<IndexName>
                CcrFollowRequest.MaxOutstandingReadRequests = Option.None
                CcrFollowRequest.MaxOutstandingWriteRequests = Option.None
                CcrFollowRequest.MaxReadRequestOperationCount = Option.None
                CcrFollowRequest.MaxReadRequestSize = Option.None
                CcrFollowRequest.MaxRetryDelay = Option.None
                CcrFollowRequest.MaxWriteBufferCount = Option.None
                CcrFollowRequest.MaxWriteBufferSize = Option.None
                CcrFollowRequest.MaxWriteRequestOperationCount = Option.None
                CcrFollowRequest.MaxWriteRequestSize = Option.None
                CcrFollowRequest.ReadPollTimeout = Option.None
                CcrFollowRequest.RemoteCluster = String.Empty
                CcrFollowRequest.Settings = Option.None
            } : CcrFollowRequest

        [<CustomOperation("index")>]
        member _.Index(state: CcrFollowRequest, value: IndexName) =
            { state with CcrFollowRequest.Index = value } : CcrFollowRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CcrFollowRequest, value: Duration) =
            { state with CcrFollowRequest.MasterTimeout = Option.Some value } : CcrFollowRequest

        [<CustomOperation("wait_for_active_shards")>]
        member _.WaitForActiveShards(state: CcrFollowRequest, value: WaitForActiveShards) =
            { state with CcrFollowRequest.WaitForActiveShards = Option.Some value } : CcrFollowRequest

        [<CustomOperation("data_stream_name")>]
        member _.DataStreamName(state: CcrFollowRequest, value: string) =
            { state with CcrFollowRequest.DataStreamName = Option.Some value } : CcrFollowRequest

        [<CustomOperation("leader_index")>]
        member _.LeaderIndex(state: CcrFollowRequest, value: IndexName) =
            { state with CcrFollowRequest.LeaderIndex = value } : CcrFollowRequest

        [<CustomOperation("max_outstanding_read_requests")>]
        member _.MaxOutstandingReadRequests(state: CcrFollowRequest, value: float) =
            { state with CcrFollowRequest.MaxOutstandingReadRequests = Option.Some value } : CcrFollowRequest

        [<CustomOperation("max_outstanding_write_requests")>]
        member _.MaxOutstandingWriteRequests(state: CcrFollowRequest, value: float) =
            { state with CcrFollowRequest.MaxOutstandingWriteRequests = Option.Some value } : CcrFollowRequest

        [<CustomOperation("max_read_request_operation_count")>]
        member _.MaxReadRequestOperationCount(state: CcrFollowRequest, value: float) =
            { state with CcrFollowRequest.MaxReadRequestOperationCount = Option.Some value } : CcrFollowRequest

        [<CustomOperation("max_read_request_size")>]
        member _.MaxReadRequestSize(state: CcrFollowRequest, value: ByteSize) =
            { state with CcrFollowRequest.MaxReadRequestSize = Option.Some value } : CcrFollowRequest

        [<CustomOperation("max_retry_delay")>]
        member _.MaxRetryDelay(state: CcrFollowRequest, value: Duration) =
            { state with CcrFollowRequest.MaxRetryDelay = Option.Some value } : CcrFollowRequest

        [<CustomOperation("max_write_buffer_count")>]
        member _.MaxWriteBufferCount(state: CcrFollowRequest, value: float) =
            { state with CcrFollowRequest.MaxWriteBufferCount = Option.Some value } : CcrFollowRequest

        [<CustomOperation("max_write_buffer_size")>]
        member _.MaxWriteBufferSize(state: CcrFollowRequest, value: ByteSize) =
            { state with CcrFollowRequest.MaxWriteBufferSize = Option.Some value } : CcrFollowRequest

        [<CustomOperation("max_write_request_operation_count")>]
        member _.MaxWriteRequestOperationCount(state: CcrFollowRequest, value: float) =
            { state with CcrFollowRequest.MaxWriteRequestOperationCount = Option.Some value } : CcrFollowRequest

        [<CustomOperation("max_write_request_size")>]
        member _.MaxWriteRequestSize(state: CcrFollowRequest, value: ByteSize) =
            { state with CcrFollowRequest.MaxWriteRequestSize = Option.Some value } : CcrFollowRequest

        [<CustomOperation("read_poll_timeout")>]
        member _.ReadPollTimeout(state: CcrFollowRequest, value: Duration) =
            { state with CcrFollowRequest.ReadPollTimeout = Option.Some value } : CcrFollowRequest

        [<CustomOperation("remote_cluster")>]
        member _.RemoteCluster(state: CcrFollowRequest, value: string) =
            { state with CcrFollowRequest.RemoteCluster = value } : CcrFollowRequest

        [<CustomOperation("settings")>]
        member _.Settings(state: CcrFollowRequest, value: TypesIndexSettings) =
            { state with CcrFollowRequest.Settings = Option.Some value } : CcrFollowRequest

    let ccrFollowRequest = CcrFollowRequestBuilder()

    type CcrFollowResponse = {
        [<JsonPropertyName("follow_index_created")>]
        FollowIndexCreated: bool
        [<JsonPropertyName("follow_index_shards_acked")>]
        FollowIndexShardsAcked: bool
        [<JsonPropertyName("index_following_started")>]
        IndexFollowingStarted: bool
    }

    type CcrFollowInfoRequest = {
        [<JsonPropertyName("index")>]
        Index: Indices
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: CcrFollowInfoRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_ccr/info"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module CcrFollowInfoRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CcrFollowInfoRequest) : Result<Fes.Http.RequestMsg, exn> =
            CcrFollowInfoRequest.ToRequest request

    type CcrFollowInfoRequestBuilder() =
        member _.Yield(_: unit) : CcrFollowInfoRequest =
            {
                CcrFollowInfoRequest.Index = Unchecked.defaultof<Indices>
                CcrFollowInfoRequest.MasterTimeout = Option.None
            } : CcrFollowInfoRequest

        [<CustomOperation("index")>]
        member _.Index(state: CcrFollowInfoRequest, value: Indices) =
            { state with CcrFollowInfoRequest.Index = value } : CcrFollowInfoRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CcrFollowInfoRequest, value: Duration) =
            { state with CcrFollowInfoRequest.MasterTimeout = Option.Some value } : CcrFollowInfoRequest

    let ccrFollowInfoRequest = CcrFollowInfoRequestBuilder()

    type CcrFollowInfoResponse = {
        [<JsonPropertyName("follower_indices")>]
        FollowerIndices: FollowInfoFollowerIndex array
    }

    type CcrFollowStatsRequest = {
        [<JsonPropertyName("index")>]
        Index: Indices
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
    } with
        static member ToRequest(request: CcrFollowStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_ccr/stats"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module CcrFollowStatsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CcrFollowStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            CcrFollowStatsRequest.ToRequest request

    type CcrFollowStatsRequestBuilder() =
        member _.Yield(_: unit) : CcrFollowStatsRequest =
            {
                CcrFollowStatsRequest.Index = Unchecked.defaultof<Indices>
                CcrFollowStatsRequest.Timeout = Option.None
            } : CcrFollowStatsRequest

        [<CustomOperation("index")>]
        member _.Index(state: CcrFollowStatsRequest, value: Indices) =
            { state with CcrFollowStatsRequest.Index = value } : CcrFollowStatsRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: CcrFollowStatsRequest, value: Duration) =
            { state with CcrFollowStatsRequest.Timeout = Option.Some value } : CcrFollowStatsRequest

    let ccrFollowStatsRequest = CcrFollowStatsRequestBuilder()

    type CcrFollowStatsResponse = {
        [<JsonPropertyName("indices")>]
        Indices: TypesFollowIndexStats array
    }

    type CcrForgetFollowerRequest = {
        [<JsonPropertyName("index")>]
        Index: IndexName
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
        [<JsonPropertyName("follower_cluster")>]
        FollowerCluster: string option
        [<JsonPropertyName("follower_index")>]
        FollowerIndex: IndexName option
        [<JsonPropertyName("follower_index_uuid")>]
        FollowerIndexUuid: Uuid option
        [<JsonPropertyName("leader_remote_cluster")>]
        LeaderRemoteCluster: string option
    } with
        static member ToRequest(request: CcrForgetFollowerRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_ccr/forget_follower"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module CcrForgetFollowerRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CcrForgetFollowerRequest) : Result<Fes.Http.RequestMsg, exn> =
            CcrForgetFollowerRequest.ToRequest request

    type CcrForgetFollowerRequestBuilder() =
        member _.Yield(_: unit) : CcrForgetFollowerRequest =
            {
                CcrForgetFollowerRequest.Index = Unchecked.defaultof<IndexName>
                CcrForgetFollowerRequest.Timeout = Option.None
                CcrForgetFollowerRequest.FollowerCluster = Option.None
                CcrForgetFollowerRequest.FollowerIndex = Option.None
                CcrForgetFollowerRequest.FollowerIndexUuid = Option.None
                CcrForgetFollowerRequest.LeaderRemoteCluster = Option.None
            } : CcrForgetFollowerRequest

        [<CustomOperation("index")>]
        member _.Index(state: CcrForgetFollowerRequest, value: IndexName) =
            { state with CcrForgetFollowerRequest.Index = value } : CcrForgetFollowerRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: CcrForgetFollowerRequest, value: Duration) =
            { state with CcrForgetFollowerRequest.Timeout = Option.Some value } : CcrForgetFollowerRequest

        [<CustomOperation("follower_cluster")>]
        member _.FollowerCluster(state: CcrForgetFollowerRequest, value: string) =
            { state with CcrForgetFollowerRequest.FollowerCluster = Option.Some value } : CcrForgetFollowerRequest

        [<CustomOperation("follower_index")>]
        member _.FollowerIndex(state: CcrForgetFollowerRequest, value: IndexName) =
            { state with CcrForgetFollowerRequest.FollowerIndex = Option.Some value } : CcrForgetFollowerRequest

        [<CustomOperation("follower_index_uuid")>]
        member _.FollowerIndexUuid(state: CcrForgetFollowerRequest, value: Uuid) =
            { state with CcrForgetFollowerRequest.FollowerIndexUuid = Option.Some value } : CcrForgetFollowerRequest

        [<CustomOperation("leader_remote_cluster")>]
        member _.LeaderRemoteCluster(state: CcrForgetFollowerRequest, value: string) =
            { state with CcrForgetFollowerRequest.LeaderRemoteCluster = Option.Some value } : CcrForgetFollowerRequest

    let ccrForgetFollowerRequest = CcrForgetFollowerRequestBuilder()

    type CcrForgetFollowerResponse = {
        [<JsonPropertyName("_shards")>]
        Shards: ShardStatistics
    }

    type CcrPauseAutoFollowPatternRequest = {
        [<JsonPropertyName("name")>]
        Name: Name
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: CcrPauseAutoFollowPatternRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ccr/auto_follow/{request.Name}/pause"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module CcrPauseAutoFollowPatternRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CcrPauseAutoFollowPatternRequest) : Result<Fes.Http.RequestMsg, exn> =
            CcrPauseAutoFollowPatternRequest.ToRequest request

    type CcrPauseAutoFollowPatternRequestBuilder() =
        member _.Yield(_: unit) : CcrPauseAutoFollowPatternRequest =
            {
                CcrPauseAutoFollowPatternRequest.Name = Unchecked.defaultof<Name>
                CcrPauseAutoFollowPatternRequest.MasterTimeout = Option.None
            } : CcrPauseAutoFollowPatternRequest

        [<CustomOperation("name")>]
        member _.Name(state: CcrPauseAutoFollowPatternRequest, value: Name) =
            { state with CcrPauseAutoFollowPatternRequest.Name = value } : CcrPauseAutoFollowPatternRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CcrPauseAutoFollowPatternRequest, value: Duration) =
            { state with CcrPauseAutoFollowPatternRequest.MasterTimeout = Option.Some value } : CcrPauseAutoFollowPatternRequest

    let ccrPauseAutoFollowPatternRequest = CcrPauseAutoFollowPatternRequestBuilder()

    type CcrPauseAutoFollowPatternResponse = AcknowledgedResponseBase

    type CcrPauseFollowRequest = {
        [<JsonPropertyName("index")>]
        Index: IndexName
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: CcrPauseFollowRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_ccr/pause_follow"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module CcrPauseFollowRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CcrPauseFollowRequest) : Result<Fes.Http.RequestMsg, exn> =
            CcrPauseFollowRequest.ToRequest request

    type CcrPauseFollowRequestBuilder() =
        member _.Yield(_: unit) : CcrPauseFollowRequest =
            {
                CcrPauseFollowRequest.Index = Unchecked.defaultof<IndexName>
                CcrPauseFollowRequest.MasterTimeout = Option.None
            } : CcrPauseFollowRequest

        [<CustomOperation("index")>]
        member _.Index(state: CcrPauseFollowRequest, value: IndexName) =
            { state with CcrPauseFollowRequest.Index = value } : CcrPauseFollowRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CcrPauseFollowRequest, value: Duration) =
            { state with CcrPauseFollowRequest.MasterTimeout = Option.Some value } : CcrPauseFollowRequest

    let ccrPauseFollowRequest = CcrPauseFollowRequestBuilder()

    type CcrPauseFollowResponse = AcknowledgedResponseBase

    type CcrResumeAutoFollowPatternRequest = {
        [<JsonPropertyName("name")>]
        Name: Name
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: CcrResumeAutoFollowPatternRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ccr/auto_follow/{request.Name}/resume"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module CcrResumeAutoFollowPatternRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CcrResumeAutoFollowPatternRequest) : Result<Fes.Http.RequestMsg, exn> =
            CcrResumeAutoFollowPatternRequest.ToRequest request

    type CcrResumeAutoFollowPatternRequestBuilder() =
        member _.Yield(_: unit) : CcrResumeAutoFollowPatternRequest =
            {
                CcrResumeAutoFollowPatternRequest.Name = Unchecked.defaultof<Name>
                CcrResumeAutoFollowPatternRequest.MasterTimeout = Option.None
            } : CcrResumeAutoFollowPatternRequest

        [<CustomOperation("name")>]
        member _.Name(state: CcrResumeAutoFollowPatternRequest, value: Name) =
            { state with CcrResumeAutoFollowPatternRequest.Name = value } : CcrResumeAutoFollowPatternRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CcrResumeAutoFollowPatternRequest, value: Duration) =
            { state with CcrResumeAutoFollowPatternRequest.MasterTimeout = Option.Some value } : CcrResumeAutoFollowPatternRequest

    let ccrResumeAutoFollowPatternRequest = CcrResumeAutoFollowPatternRequestBuilder()

    type CcrResumeAutoFollowPatternResponse = AcknowledgedResponseBase

    type CcrResumeFollowRequest = {
        [<JsonPropertyName("index")>]
        Index: IndexName
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
        [<JsonPropertyName("max_outstanding_read_requests")>]
        MaxOutstandingReadRequests: float option
        [<JsonPropertyName("max_outstanding_write_requests")>]
        MaxOutstandingWriteRequests: float option
        [<JsonPropertyName("max_read_request_operation_count")>]
        MaxReadRequestOperationCount: float option
        [<JsonPropertyName("max_read_request_size")>]
        MaxReadRequestSize: string option
        [<JsonPropertyName("max_retry_delay")>]
        MaxRetryDelay: Duration option
        [<JsonPropertyName("max_write_buffer_count")>]
        MaxWriteBufferCount: float option
        [<JsonPropertyName("max_write_buffer_size")>]
        MaxWriteBufferSize: string option
        [<JsonPropertyName("max_write_request_operation_count")>]
        MaxWriteRequestOperationCount: float option
        [<JsonPropertyName("max_write_request_size")>]
        MaxWriteRequestSize: string option
        [<JsonPropertyName("read_poll_timeout")>]
        ReadPollTimeout: Duration option
    } with
        static member ToRequest(request: CcrResumeFollowRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_ccr/resume_follow"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module CcrResumeFollowRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CcrResumeFollowRequest) : Result<Fes.Http.RequestMsg, exn> =
            CcrResumeFollowRequest.ToRequest request

    type CcrResumeFollowRequestBuilder() =
        member _.Yield(_: unit) : CcrResumeFollowRequest =
            {
                CcrResumeFollowRequest.Index = Unchecked.defaultof<IndexName>
                CcrResumeFollowRequest.MasterTimeout = Option.None
                CcrResumeFollowRequest.MaxOutstandingReadRequests = Option.None
                CcrResumeFollowRequest.MaxOutstandingWriteRequests = Option.None
                CcrResumeFollowRequest.MaxReadRequestOperationCount = Option.None
                CcrResumeFollowRequest.MaxReadRequestSize = Option.None
                CcrResumeFollowRequest.MaxRetryDelay = Option.None
                CcrResumeFollowRequest.MaxWriteBufferCount = Option.None
                CcrResumeFollowRequest.MaxWriteBufferSize = Option.None
                CcrResumeFollowRequest.MaxWriteRequestOperationCount = Option.None
                CcrResumeFollowRequest.MaxWriteRequestSize = Option.None
                CcrResumeFollowRequest.ReadPollTimeout = Option.None
            } : CcrResumeFollowRequest

        [<CustomOperation("index")>]
        member _.Index(state: CcrResumeFollowRequest, value: IndexName) =
            { state with CcrResumeFollowRequest.Index = value } : CcrResumeFollowRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CcrResumeFollowRequest, value: Duration) =
            { state with CcrResumeFollowRequest.MasterTimeout = Option.Some value } : CcrResumeFollowRequest

        [<CustomOperation("max_outstanding_read_requests")>]
        member _.MaxOutstandingReadRequests(state: CcrResumeFollowRequest, value: float) =
            { state with CcrResumeFollowRequest.MaxOutstandingReadRequests = Option.Some value } : CcrResumeFollowRequest

        [<CustomOperation("max_outstanding_write_requests")>]
        member _.MaxOutstandingWriteRequests(state: CcrResumeFollowRequest, value: float) =
            { state with CcrResumeFollowRequest.MaxOutstandingWriteRequests = Option.Some value } : CcrResumeFollowRequest

        [<CustomOperation("max_read_request_operation_count")>]
        member _.MaxReadRequestOperationCount(state: CcrResumeFollowRequest, value: float) =
            { state with CcrResumeFollowRequest.MaxReadRequestOperationCount = Option.Some value } : CcrResumeFollowRequest

        [<CustomOperation("max_read_request_size")>]
        member _.MaxReadRequestSize(state: CcrResumeFollowRequest, value: string) =
            { state with CcrResumeFollowRequest.MaxReadRequestSize = Option.Some value } : CcrResumeFollowRequest

        [<CustomOperation("max_retry_delay")>]
        member _.MaxRetryDelay(state: CcrResumeFollowRequest, value: Duration) =
            { state with CcrResumeFollowRequest.MaxRetryDelay = Option.Some value } : CcrResumeFollowRequest

        [<CustomOperation("max_write_buffer_count")>]
        member _.MaxWriteBufferCount(state: CcrResumeFollowRequest, value: float) =
            { state with CcrResumeFollowRequest.MaxWriteBufferCount = Option.Some value } : CcrResumeFollowRequest

        [<CustomOperation("max_write_buffer_size")>]
        member _.MaxWriteBufferSize(state: CcrResumeFollowRequest, value: string) =
            { state with CcrResumeFollowRequest.MaxWriteBufferSize = Option.Some value } : CcrResumeFollowRequest

        [<CustomOperation("max_write_request_operation_count")>]
        member _.MaxWriteRequestOperationCount(state: CcrResumeFollowRequest, value: float) =
            { state with CcrResumeFollowRequest.MaxWriteRequestOperationCount = Option.Some value } : CcrResumeFollowRequest

        [<CustomOperation("max_write_request_size")>]
        member _.MaxWriteRequestSize(state: CcrResumeFollowRequest, value: string) =
            { state with CcrResumeFollowRequest.MaxWriteRequestSize = Option.Some value } : CcrResumeFollowRequest

        [<CustomOperation("read_poll_timeout")>]
        member _.ReadPollTimeout(state: CcrResumeFollowRequest, value: Duration) =
            { state with CcrResumeFollowRequest.ReadPollTimeout = Option.Some value } : CcrResumeFollowRequest

    let ccrResumeFollowRequest = CcrResumeFollowRequestBuilder()

    type CcrResumeFollowResponse = AcknowledgedResponseBase

    type CcrStatsRequest = {
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
    } with
        static member ToRequest(request: CcrStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_ccr/stats"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module CcrStatsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CcrStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            CcrStatsRequest.ToRequest request

    type CcrStatsRequestBuilder() =
        member _.Yield(_: unit) : CcrStatsRequest =
            {
                CcrStatsRequest.MasterTimeout = Option.None
                CcrStatsRequest.Timeout = Option.None
            } : CcrStatsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CcrStatsRequest, value: Duration) =
            { state with CcrStatsRequest.MasterTimeout = Option.Some value } : CcrStatsRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: CcrStatsRequest, value: Duration) =
            { state with CcrStatsRequest.Timeout = Option.Some value } : CcrStatsRequest

    let ccrStatsRequest = CcrStatsRequestBuilder()

    type CcrStatsResponse = {
        [<JsonPropertyName("auto_follow_stats")>]
        AutoFollowStats: StatsAutoFollowStats
        [<JsonPropertyName("follow_stats")>]
        FollowStats: StatsFollowStats
    }

    type CcrUnfollowRequest = {
        [<JsonPropertyName("index")>]
        Index: IndexName
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: CcrUnfollowRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_ccr/unfollow"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module CcrUnfollowRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: CcrUnfollowRequest) : Result<Fes.Http.RequestMsg, exn> =
            CcrUnfollowRequest.ToRequest request

    type CcrUnfollowRequestBuilder() =
        member _.Yield(_: unit) : CcrUnfollowRequest =
            {
                CcrUnfollowRequest.Index = Unchecked.defaultof<IndexName>
                CcrUnfollowRequest.MasterTimeout = Option.None
            } : CcrUnfollowRequest

        [<CustomOperation("index")>]
        member _.Index(state: CcrUnfollowRequest, value: IndexName) =
            { state with CcrUnfollowRequest.Index = value } : CcrUnfollowRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: CcrUnfollowRequest, value: Duration) =
            { state with CcrUnfollowRequest.MasterTimeout = Option.Some value } : CcrUnfollowRequest

    let ccrUnfollowRequest = CcrUnfollowRequestBuilder()

    type CcrUnfollowResponse = AcknowledgedResponseBase


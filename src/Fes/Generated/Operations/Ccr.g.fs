// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module CcrOperations =

    type CcrDeleteAutoFollowPatternRequest = {
        Name: Types.Name
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: CcrDeleteAutoFollowPatternRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ccr/auto_follow/{req.Name}"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type CcrDeleteAutoFollowPatternResponse = Types.AcknowledgedResponseBase

    type CcrDeleteAutoFollowPatternRequestBuilder() =
        member _.Yield(_: unit) : CcrDeleteAutoFollowPatternRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: CcrDeleteAutoFollowPatternRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CcrDeleteAutoFollowPatternRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let ccrDeleteAutoFollowPatternRequest = CcrDeleteAutoFollowPatternRequestBuilder()

    module DeleteAutoFollowPattern =
        let withMasterTimeout (value: Types.Duration) (req: CcrDeleteAutoFollowPatternRequest) =
            { req with MasterTimeout = Some value }

    type CcrFollowRequest = {
        Index: Types.IndexName
        MasterTimeout: Types.Duration option
        WaitForActiveShards: Types.WaitForActiveShards option
        DataStreamName: string option
        LeaderIndex: Types.IndexName
        MaxOutstandingReadRequests: Types.Long option
        MaxOutstandingWriteRequests: Types.Integer option
        MaxReadRequestOperationCount: Types.Integer option
        MaxReadRequestSize: Types.ByteSize option
        MaxRetryDelay: Types.Duration option
        MaxWriteBufferCount: Types.Integer option
        MaxWriteBufferSize: Types.ByteSize option
        MaxWriteRequestOperationCount: Types.Integer option
        MaxWriteRequestSize: Types.ByteSize option
        ReadPollTimeout: Types.Duration option
        RemoteCluster: string
        Settings: IndicesTypes.IndexSettings option
    }

        with
        static member ToRequest(req: CcrFollowRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_ccr/follow"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type CcrFollowResponse = System.Text.Json.JsonElement

    type CcrFollowRequestBuilder() =
        member _.Yield(_: unit) : CcrFollowRequest =
            {
                Index = Unchecked.defaultof<_>
                MasterTimeout = None
                WaitForActiveShards = None
                DataStreamName = None
                LeaderIndex = Unchecked.defaultof<_>
                MaxOutstandingReadRequests = None
                MaxOutstandingWriteRequests = None
                MaxReadRequestOperationCount = None
                MaxReadRequestSize = None
                MaxRetryDelay = None
                MaxWriteBufferCount = None
                MaxWriteBufferSize = None
                MaxWriteRequestOperationCount = None
                MaxWriteRequestSize = None
                ReadPollTimeout = None
                RemoteCluster = Unchecked.defaultof<_>
                Settings = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: CcrFollowRequest, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CcrFollowRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: CcrFollowRequest, value: Types.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

        [<CustomOperation("dataStreamName")>]
        member _.DataStreamName(state: CcrFollowRequest, value: string) =
            { state with DataStreamName = Some value }

        [<CustomOperation("leaderIndex")>]
        member _.LeaderIndex(state: CcrFollowRequest, value: Types.IndexName) =
            { state with LeaderIndex = value }

        [<CustomOperation("maxOutstandingReadRequests")>]
        member _.MaxOutstandingReadRequests(state: CcrFollowRequest, value: Types.Long) =
            { state with MaxOutstandingReadRequests = Some value }

        [<CustomOperation("maxOutstandingWriteRequests")>]
        member _.MaxOutstandingWriteRequests(state: CcrFollowRequest, value: Types.Integer) =
            { state with MaxOutstandingWriteRequests = Some value }

        [<CustomOperation("maxReadRequestOperationCount")>]
        member _.MaxReadRequestOperationCount(state: CcrFollowRequest, value: Types.Integer) =
            { state with MaxReadRequestOperationCount = Some value }

        [<CustomOperation("maxReadRequestSize")>]
        member _.MaxReadRequestSize(state: CcrFollowRequest, value: Types.ByteSize) =
            { state with MaxReadRequestSize = Some value }

        [<CustomOperation("maxRetryDelay")>]
        member _.MaxRetryDelay(state: CcrFollowRequest, value: Types.Duration) =
            { state with MaxRetryDelay = Some value }

        [<CustomOperation("maxWriteBufferCount")>]
        member _.MaxWriteBufferCount(state: CcrFollowRequest, value: Types.Integer) =
            { state with MaxWriteBufferCount = Some value }

        [<CustomOperation("maxWriteBufferSize")>]
        member _.MaxWriteBufferSize(state: CcrFollowRequest, value: Types.ByteSize) =
            { state with MaxWriteBufferSize = Some value }

        [<CustomOperation("maxWriteRequestOperationCount")>]
        member _.MaxWriteRequestOperationCount(state: CcrFollowRequest, value: Types.Integer) =
            { state with MaxWriteRequestOperationCount = Some value }

        [<CustomOperation("maxWriteRequestSize")>]
        member _.MaxWriteRequestSize(state: CcrFollowRequest, value: Types.ByteSize) =
            { state with MaxWriteRequestSize = Some value }

        [<CustomOperation("readPollTimeout")>]
        member _.ReadPollTimeout(state: CcrFollowRequest, value: Types.Duration) =
            { state with ReadPollTimeout = Some value }

        [<CustomOperation("remoteCluster")>]
        member _.RemoteCluster(state: CcrFollowRequest, value: string) =
            { state with RemoteCluster = value }

        [<CustomOperation("settings")>]
        member _.Settings(state: CcrFollowRequest, value: IndicesTypes.IndexSettings) =
            { state with Settings = Some value }

    let ccrFollowRequest = CcrFollowRequestBuilder()

    module Follow =
        let withMasterTimeout (value: Types.Duration) (req: CcrFollowRequest) =
            { req with MasterTimeout = Some value }
        let withWaitForActiveShards (value: Types.WaitForActiveShards) (req: CcrFollowRequest) =
            { req with WaitForActiveShards = Some value }
        let withDataStreamName (value: string) (req: CcrFollowRequest) =
            { req with DataStreamName = Some value }
        let withLeaderIndex (value: Types.IndexName) (req: CcrFollowRequest) =
            { req with LeaderIndex = value }
        let withMaxOutstandingReadRequests (value: Types.Long) (req: CcrFollowRequest) =
            { req with MaxOutstandingReadRequests = Some value }
        let withMaxOutstandingWriteRequests (value: Types.Integer) (req: CcrFollowRequest) =
            { req with MaxOutstandingWriteRequests = Some value }
        let withMaxReadRequestOperationCount (value: Types.Integer) (req: CcrFollowRequest) =
            { req with MaxReadRequestOperationCount = Some value }
        let withMaxReadRequestSize (value: Types.ByteSize) (req: CcrFollowRequest) =
            { req with MaxReadRequestSize = Some value }
        let withMaxRetryDelay (value: Types.Duration) (req: CcrFollowRequest) =
            { req with MaxRetryDelay = Some value }
        let withMaxWriteBufferCount (value: Types.Integer) (req: CcrFollowRequest) =
            { req with MaxWriteBufferCount = Some value }
        let withMaxWriteBufferSize (value: Types.ByteSize) (req: CcrFollowRequest) =
            { req with MaxWriteBufferSize = Some value }
        let withMaxWriteRequestOperationCount (value: Types.Integer) (req: CcrFollowRequest) =
            { req with MaxWriteRequestOperationCount = Some value }
        let withMaxWriteRequestSize (value: Types.ByteSize) (req: CcrFollowRequest) =
            { req with MaxWriteRequestSize = Some value }
        let withReadPollTimeout (value: Types.Duration) (req: CcrFollowRequest) =
            { req with ReadPollTimeout = Some value }
        let withRemoteCluster (value: string) (req: CcrFollowRequest) =
            { req with RemoteCluster = value }
        let withSettings (value: IndicesTypes.IndexSettings) (req: CcrFollowRequest) =
            { req with Settings = Some value }

    type CcrFollowInfoRequest = {
        Index: Types.Indices
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: CcrFollowInfoRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_ccr/info"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type CcrFollowInfoResponse = System.Text.Json.JsonElement

    type CcrFollowInfoRequestBuilder() =
        member _.Yield(_: unit) : CcrFollowInfoRequest =
            {
                Index = Unchecked.defaultof<_>
                MasterTimeout = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: CcrFollowInfoRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CcrFollowInfoRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let ccrFollowInfoRequest = CcrFollowInfoRequestBuilder()

    module FollowInfo =
        let withMasterTimeout (value: Types.Duration) (req: CcrFollowInfoRequest) =
            { req with MasterTimeout = Some value }

    type CcrFollowStatsRequest = {
        Index: Types.Indices
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: CcrFollowStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_ccr/stats"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type CcrFollowStatsResponse = System.Text.Json.JsonElement

    type CcrFollowStatsRequestBuilder() =
        member _.Yield(_: unit) : CcrFollowStatsRequest =
            {
                Index = Unchecked.defaultof<_>
                Timeout = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: CcrFollowStatsRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: CcrFollowStatsRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let ccrFollowStatsRequest = CcrFollowStatsRequestBuilder()

    module FollowStats =
        let withTimeout (value: Types.Duration) (req: CcrFollowStatsRequest) =
            { req with Timeout = Some value }

    type CcrForgetFollowerRequest = {
        Index: Types.IndexName
        Timeout: Types.Duration option
        FollowerCluster: string option
        FollowerIndex: Types.IndexName option
        FollowerIndexUuid: Types.Uuid option
        LeaderRemoteCluster: string option
    }

        with
        static member ToRequest(req: CcrForgetFollowerRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_ccr/forget_follower"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type CcrForgetFollowerResponse = System.Text.Json.JsonElement

    type CcrForgetFollowerRequestBuilder() =
        member _.Yield(_: unit) : CcrForgetFollowerRequest =
            {
                Index = Unchecked.defaultof<_>
                Timeout = None
                FollowerCluster = None
                FollowerIndex = None
                FollowerIndexUuid = None
                LeaderRemoteCluster = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: CcrForgetFollowerRequest, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: CcrForgetFollowerRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("followerCluster")>]
        member _.FollowerCluster(state: CcrForgetFollowerRequest, value: string) =
            { state with FollowerCluster = Some value }

        [<CustomOperation("followerIndex")>]
        member _.FollowerIndex(state: CcrForgetFollowerRequest, value: Types.IndexName) =
            { state with FollowerIndex = Some value }

        [<CustomOperation("followerIndexUuid")>]
        member _.FollowerIndexUuid(state: CcrForgetFollowerRequest, value: Types.Uuid) =
            { state with FollowerIndexUuid = Some value }

        [<CustomOperation("leaderRemoteCluster")>]
        member _.LeaderRemoteCluster(state: CcrForgetFollowerRequest, value: string) =
            { state with LeaderRemoteCluster = Some value }

    let ccrForgetFollowerRequest = CcrForgetFollowerRequestBuilder()

    module ForgetFollower =
        let withTimeout (value: Types.Duration) (req: CcrForgetFollowerRequest) =
            { req with Timeout = Some value }
        let withFollowerCluster (value: string) (req: CcrForgetFollowerRequest) =
            { req with FollowerCluster = Some value }
        let withFollowerIndex (value: Types.IndexName) (req: CcrForgetFollowerRequest) =
            { req with FollowerIndex = Some value }
        let withFollowerIndexUuid (value: Types.Uuid) (req: CcrForgetFollowerRequest) =
            { req with FollowerIndexUuid = Some value }
        let withLeaderRemoteCluster (value: string) (req: CcrForgetFollowerRequest) =
            { req with LeaderRemoteCluster = Some value }

    type CcrGetAutoFollowPatternRequest = {
        Name: Types.Name
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: CcrGetAutoFollowPatternRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ccr/auto_follow/{req.Name}"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type CcrGetAutoFollowPatternResponse = System.Text.Json.JsonElement

    type CcrGetAutoFollowPatternRequestBuilder() =
        member _.Yield(_: unit) : CcrGetAutoFollowPatternRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: CcrGetAutoFollowPatternRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CcrGetAutoFollowPatternRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let ccrGetAutoFollowPatternRequest = CcrGetAutoFollowPatternRequestBuilder()

    module GetAutoFollowPattern =
        let withMasterTimeout (value: Types.Duration) (req: CcrGetAutoFollowPatternRequest) =
            { req with MasterTimeout = Some value }

    type CcrPauseAutoFollowPatternRequest = {
        Name: Types.Name
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: CcrPauseAutoFollowPatternRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ccr/auto_follow/{req.Name}/pause"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type CcrPauseAutoFollowPatternResponse = Types.AcknowledgedResponseBase

    type CcrPauseAutoFollowPatternRequestBuilder() =
        member _.Yield(_: unit) : CcrPauseAutoFollowPatternRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: CcrPauseAutoFollowPatternRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CcrPauseAutoFollowPatternRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let ccrPauseAutoFollowPatternRequest = CcrPauseAutoFollowPatternRequestBuilder()

    module PauseAutoFollowPattern =
        let withMasterTimeout (value: Types.Duration) (req: CcrPauseAutoFollowPatternRequest) =
            { req with MasterTimeout = Some value }

    type CcrPauseFollowRequest = {
        Index: Types.IndexName
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: CcrPauseFollowRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_ccr/pause_follow"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type CcrPauseFollowResponse = Types.AcknowledgedResponseBase

    type CcrPauseFollowRequestBuilder() =
        member _.Yield(_: unit) : CcrPauseFollowRequest =
            {
                Index = Unchecked.defaultof<_>
                MasterTimeout = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: CcrPauseFollowRequest, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CcrPauseFollowRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let ccrPauseFollowRequest = CcrPauseFollowRequestBuilder()

    module PauseFollow =
        let withMasterTimeout (value: Types.Duration) (req: CcrPauseFollowRequest) =
            { req with MasterTimeout = Some value }

    type CcrPutAutoFollowPatternRequest = {
        Name: Types.Name
        MasterTimeout: Types.Duration option
        RemoteCluster: string
        FollowIndexPattern: Types.IndexPattern option
        LeaderIndexPatterns: Types.IndexPatterns option
        LeaderIndexExclusionPatterns: Types.IndexPatterns option
        MaxOutstandingReadRequests: Types.Integer option
        Settings: Map<string, System.Text.Json.JsonElement> option
        MaxOutstandingWriteRequests: Types.Integer option
        ReadPollTimeout: Types.Duration option
        MaxReadRequestOperationCount: Types.Integer option
        MaxReadRequestSize: Types.ByteSize option
        MaxRetryDelay: Types.Duration option
        MaxWriteBufferCount: Types.Integer option
        MaxWriteBufferSize: Types.ByteSize option
        MaxWriteRequestOperationCount: Types.Integer option
        MaxWriteRequestSize: Types.ByteSize option
    }

        with
        static member ToRequest(req: CcrPutAutoFollowPatternRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ccr/auto_follow/{req.Name}"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type CcrPutAutoFollowPatternResponse = Types.AcknowledgedResponseBase

    type CcrPutAutoFollowPatternRequestBuilder() =
        member _.Yield(_: unit) : CcrPutAutoFollowPatternRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
                RemoteCluster = Unchecked.defaultof<_>
                FollowIndexPattern = None
                LeaderIndexPatterns = None
                LeaderIndexExclusionPatterns = None
                MaxOutstandingReadRequests = None
                Settings = None
                MaxOutstandingWriteRequests = None
                ReadPollTimeout = None
                MaxReadRequestOperationCount = None
                MaxReadRequestSize = None
                MaxRetryDelay = None
                MaxWriteBufferCount = None
                MaxWriteBufferSize = None
                MaxWriteRequestOperationCount = None
                MaxWriteRequestSize = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: CcrPutAutoFollowPatternRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CcrPutAutoFollowPatternRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("remoteCluster")>]
        member _.RemoteCluster(state: CcrPutAutoFollowPatternRequest, value: string) =
            { state with RemoteCluster = value }

        [<CustomOperation("followIndexPattern")>]
        member _.FollowIndexPattern(state: CcrPutAutoFollowPatternRequest, value: Types.IndexPattern) =
            { state with FollowIndexPattern = Some value }

        [<CustomOperation("leaderIndexPatterns")>]
        member _.LeaderIndexPatterns(state: CcrPutAutoFollowPatternRequest, value: Types.IndexPatterns) =
            { state with LeaderIndexPatterns = Some value }

        [<CustomOperation("leaderIndexExclusionPatterns")>]
        member _.LeaderIndexExclusionPatterns(state: CcrPutAutoFollowPatternRequest, value: Types.IndexPatterns) =
            { state with LeaderIndexExclusionPatterns = Some value }

        [<CustomOperation("maxOutstandingReadRequests")>]
        member _.MaxOutstandingReadRequests(state: CcrPutAutoFollowPatternRequest, value: Types.Integer) =
            { state with MaxOutstandingReadRequests = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: CcrPutAutoFollowPatternRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Settings = Some value }

        [<CustomOperation("maxOutstandingWriteRequests")>]
        member _.MaxOutstandingWriteRequests(state: CcrPutAutoFollowPatternRequest, value: Types.Integer) =
            { state with MaxOutstandingWriteRequests = Some value }

        [<CustomOperation("readPollTimeout")>]
        member _.ReadPollTimeout(state: CcrPutAutoFollowPatternRequest, value: Types.Duration) =
            { state with ReadPollTimeout = Some value }

        [<CustomOperation("maxReadRequestOperationCount")>]
        member _.MaxReadRequestOperationCount(state: CcrPutAutoFollowPatternRequest, value: Types.Integer) =
            { state with MaxReadRequestOperationCount = Some value }

        [<CustomOperation("maxReadRequestSize")>]
        member _.MaxReadRequestSize(state: CcrPutAutoFollowPatternRequest, value: Types.ByteSize) =
            { state with MaxReadRequestSize = Some value }

        [<CustomOperation("maxRetryDelay")>]
        member _.MaxRetryDelay(state: CcrPutAutoFollowPatternRequest, value: Types.Duration) =
            { state with MaxRetryDelay = Some value }

        [<CustomOperation("maxWriteBufferCount")>]
        member _.MaxWriteBufferCount(state: CcrPutAutoFollowPatternRequest, value: Types.Integer) =
            { state with MaxWriteBufferCount = Some value }

        [<CustomOperation("maxWriteBufferSize")>]
        member _.MaxWriteBufferSize(state: CcrPutAutoFollowPatternRequest, value: Types.ByteSize) =
            { state with MaxWriteBufferSize = Some value }

        [<CustomOperation("maxWriteRequestOperationCount")>]
        member _.MaxWriteRequestOperationCount(state: CcrPutAutoFollowPatternRequest, value: Types.Integer) =
            { state with MaxWriteRequestOperationCount = Some value }

        [<CustomOperation("maxWriteRequestSize")>]
        member _.MaxWriteRequestSize(state: CcrPutAutoFollowPatternRequest, value: Types.ByteSize) =
            { state with MaxWriteRequestSize = Some value }

    let ccrPutAutoFollowPatternRequest = CcrPutAutoFollowPatternRequestBuilder()

    module PutAutoFollowPattern =
        let withMasterTimeout (value: Types.Duration) (req: CcrPutAutoFollowPatternRequest) =
            { req with MasterTimeout = Some value }
        let withRemoteCluster (value: string) (req: CcrPutAutoFollowPatternRequest) =
            { req with RemoteCluster = value }
        let withFollowIndexPattern (value: Types.IndexPattern) (req: CcrPutAutoFollowPatternRequest) =
            { req with FollowIndexPattern = Some value }
        let withLeaderIndexPatterns (value: Types.IndexPatterns) (req: CcrPutAutoFollowPatternRequest) =
            { req with LeaderIndexPatterns = Some value }
        let withLeaderIndexExclusionPatterns (value: Types.IndexPatterns) (req: CcrPutAutoFollowPatternRequest) =
            { req with LeaderIndexExclusionPatterns = Some value }
        let withMaxOutstandingReadRequests (value: Types.Integer) (req: CcrPutAutoFollowPatternRequest) =
            { req with MaxOutstandingReadRequests = Some value }
        let withSettings (value: Map<string, System.Text.Json.JsonElement>) (req: CcrPutAutoFollowPatternRequest) =
            { req with Settings = Some value }
        let withMaxOutstandingWriteRequests (value: Types.Integer) (req: CcrPutAutoFollowPatternRequest) =
            { req with MaxOutstandingWriteRequests = Some value }
        let withReadPollTimeout (value: Types.Duration) (req: CcrPutAutoFollowPatternRequest) =
            { req with ReadPollTimeout = Some value }
        let withMaxReadRequestOperationCount (value: Types.Integer) (req: CcrPutAutoFollowPatternRequest) =
            { req with MaxReadRequestOperationCount = Some value }
        let withMaxReadRequestSize (value: Types.ByteSize) (req: CcrPutAutoFollowPatternRequest) =
            { req with MaxReadRequestSize = Some value }
        let withMaxRetryDelay (value: Types.Duration) (req: CcrPutAutoFollowPatternRequest) =
            { req with MaxRetryDelay = Some value }
        let withMaxWriteBufferCount (value: Types.Integer) (req: CcrPutAutoFollowPatternRequest) =
            { req with MaxWriteBufferCount = Some value }
        let withMaxWriteBufferSize (value: Types.ByteSize) (req: CcrPutAutoFollowPatternRequest) =
            { req with MaxWriteBufferSize = Some value }
        let withMaxWriteRequestOperationCount (value: Types.Integer) (req: CcrPutAutoFollowPatternRequest) =
            { req with MaxWriteRequestOperationCount = Some value }
        let withMaxWriteRequestSize (value: Types.ByteSize) (req: CcrPutAutoFollowPatternRequest) =
            { req with MaxWriteRequestSize = Some value }

    type CcrResumeAutoFollowPatternRequest = {
        Name: Types.Name
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: CcrResumeAutoFollowPatternRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ccr/auto_follow/{req.Name}/resume"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type CcrResumeAutoFollowPatternResponse = Types.AcknowledgedResponseBase

    type CcrResumeAutoFollowPatternRequestBuilder() =
        member _.Yield(_: unit) : CcrResumeAutoFollowPatternRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: CcrResumeAutoFollowPatternRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CcrResumeAutoFollowPatternRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let ccrResumeAutoFollowPatternRequest = CcrResumeAutoFollowPatternRequestBuilder()

    module ResumeAutoFollowPattern =
        let withMasterTimeout (value: Types.Duration) (req: CcrResumeAutoFollowPatternRequest) =
            { req with MasterTimeout = Some value }

    type CcrResumeFollowRequest = {
        Index: Types.IndexName
        MasterTimeout: Types.Duration option
        MaxOutstandingReadRequests: Types.Long option
        MaxOutstandingWriteRequests: Types.Long option
        MaxReadRequestOperationCount: Types.Long option
        MaxReadRequestSize: string option
        MaxRetryDelay: Types.Duration option
        MaxWriteBufferCount: Types.Long option
        MaxWriteBufferSize: string option
        MaxWriteRequestOperationCount: Types.Long option
        MaxWriteRequestSize: string option
        ReadPollTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: CcrResumeFollowRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_ccr/resume_follow"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type CcrResumeFollowResponse = Types.AcknowledgedResponseBase

    type CcrResumeFollowRequestBuilder() =
        member _.Yield(_: unit) : CcrResumeFollowRequest =
            {
                Index = Unchecked.defaultof<_>
                MasterTimeout = None
                MaxOutstandingReadRequests = None
                MaxOutstandingWriteRequests = None
                MaxReadRequestOperationCount = None
                MaxReadRequestSize = None
                MaxRetryDelay = None
                MaxWriteBufferCount = None
                MaxWriteBufferSize = None
                MaxWriteRequestOperationCount = None
                MaxWriteRequestSize = None
                ReadPollTimeout = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: CcrResumeFollowRequest, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CcrResumeFollowRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("maxOutstandingReadRequests")>]
        member _.MaxOutstandingReadRequests(state: CcrResumeFollowRequest, value: Types.Long) =
            { state with MaxOutstandingReadRequests = Some value }

        [<CustomOperation("maxOutstandingWriteRequests")>]
        member _.MaxOutstandingWriteRequests(state: CcrResumeFollowRequest, value: Types.Long) =
            { state with MaxOutstandingWriteRequests = Some value }

        [<CustomOperation("maxReadRequestOperationCount")>]
        member _.MaxReadRequestOperationCount(state: CcrResumeFollowRequest, value: Types.Long) =
            { state with MaxReadRequestOperationCount = Some value }

        [<CustomOperation("maxReadRequestSize")>]
        member _.MaxReadRequestSize(state: CcrResumeFollowRequest, value: string) =
            { state with MaxReadRequestSize = Some value }

        [<CustomOperation("maxRetryDelay")>]
        member _.MaxRetryDelay(state: CcrResumeFollowRequest, value: Types.Duration) =
            { state with MaxRetryDelay = Some value }

        [<CustomOperation("maxWriteBufferCount")>]
        member _.MaxWriteBufferCount(state: CcrResumeFollowRequest, value: Types.Long) =
            { state with MaxWriteBufferCount = Some value }

        [<CustomOperation("maxWriteBufferSize")>]
        member _.MaxWriteBufferSize(state: CcrResumeFollowRequest, value: string) =
            { state with MaxWriteBufferSize = Some value }

        [<CustomOperation("maxWriteRequestOperationCount")>]
        member _.MaxWriteRequestOperationCount(state: CcrResumeFollowRequest, value: Types.Long) =
            { state with MaxWriteRequestOperationCount = Some value }

        [<CustomOperation("maxWriteRequestSize")>]
        member _.MaxWriteRequestSize(state: CcrResumeFollowRequest, value: string) =
            { state with MaxWriteRequestSize = Some value }

        [<CustomOperation("readPollTimeout")>]
        member _.ReadPollTimeout(state: CcrResumeFollowRequest, value: Types.Duration) =
            { state with ReadPollTimeout = Some value }

    let ccrResumeFollowRequest = CcrResumeFollowRequestBuilder()

    module ResumeFollow =
        let withMasterTimeout (value: Types.Duration) (req: CcrResumeFollowRequest) =
            { req with MasterTimeout = Some value }
        let withMaxOutstandingReadRequests (value: Types.Long) (req: CcrResumeFollowRequest) =
            { req with MaxOutstandingReadRequests = Some value }
        let withMaxOutstandingWriteRequests (value: Types.Long) (req: CcrResumeFollowRequest) =
            { req with MaxOutstandingWriteRequests = Some value }
        let withMaxReadRequestOperationCount (value: Types.Long) (req: CcrResumeFollowRequest) =
            { req with MaxReadRequestOperationCount = Some value }
        let withMaxReadRequestSize (value: string) (req: CcrResumeFollowRequest) =
            { req with MaxReadRequestSize = Some value }
        let withMaxRetryDelay (value: Types.Duration) (req: CcrResumeFollowRequest) =
            { req with MaxRetryDelay = Some value }
        let withMaxWriteBufferCount (value: Types.Long) (req: CcrResumeFollowRequest) =
            { req with MaxWriteBufferCount = Some value }
        let withMaxWriteBufferSize (value: string) (req: CcrResumeFollowRequest) =
            { req with MaxWriteBufferSize = Some value }
        let withMaxWriteRequestOperationCount (value: Types.Long) (req: CcrResumeFollowRequest) =
            { req with MaxWriteRequestOperationCount = Some value }
        let withMaxWriteRequestSize (value: string) (req: CcrResumeFollowRequest) =
            { req with MaxWriteRequestSize = Some value }
        let withReadPollTimeout (value: Types.Duration) (req: CcrResumeFollowRequest) =
            { req with ReadPollTimeout = Some value }

    type CcrStatsRequest = {
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: CcrStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ccr/stats"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type CcrStatsResponse = System.Text.Json.JsonElement

    type CcrStatsRequestBuilder() =
        member _.Yield(_: unit) : CcrStatsRequest =
            {
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CcrStatsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: CcrStatsRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let ccrStatsRequest = CcrStatsRequestBuilder()

    module Stats =
        let withMasterTimeout (value: Types.Duration) (req: CcrStatsRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: CcrStatsRequest) =
            { req with Timeout = Some value }

    type CcrUnfollowRequest = {
        Index: Types.IndexName
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: CcrUnfollowRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_ccr/unfollow"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type CcrUnfollowResponse = Types.AcknowledgedResponseBase

    type CcrUnfollowRequestBuilder() =
        member _.Yield(_: unit) : CcrUnfollowRequest =
            {
                Index = Unchecked.defaultof<_>
                MasterTimeout = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: CcrUnfollowRequest, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CcrUnfollowRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let ccrUnfollowRequest = CcrUnfollowRequestBuilder()

    module Unfollow =
        let withMasterTimeout (value: Types.Duration) (req: CcrUnfollowRequest) =
            { req with MasterTimeout = Some value }


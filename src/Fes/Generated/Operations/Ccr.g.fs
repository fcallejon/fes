// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module CcrOperations =

    type CcrDeleteAutoFollowPatternRequest = {
        Name: CoreTypes.Name
        MasterTimeout: CoreTypes.Duration option
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

    type CcrDeleteAutoFollowPatternResponse = CoreTypes.AcknowledgedResponseBase

    type CcrDeleteAutoFollowPatternRequestBuilder() =
        member _.Yield(_: unit) : CcrDeleteAutoFollowPatternRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: CcrDeleteAutoFollowPatternRequest, value: CoreTypes.Name) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CcrDeleteAutoFollowPatternRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

    let ccrDeleteAutoFollowPatternRequest = CcrDeleteAutoFollowPatternRequestBuilder()

    module DeleteAutoFollowPattern =
        let withMasterTimeout (value: CoreTypes.Duration) (req: CcrDeleteAutoFollowPatternRequest) =
            { req with MasterTimeout = Some value }

    type CcrFollowRequest = {
        Index: CoreTypes.IndexName
        MasterTimeout: CoreTypes.Duration option
        WaitForActiveShards: CoreTypes.WaitForActiveShards option
        DataStreamName: string option
        LeaderIndex: CoreTypes.IndexName
        MaxOutstandingReadRequests: CoreTypes.Long option
        MaxOutstandingWriteRequests: CoreTypes.Integer option
        MaxReadRequestOperationCount: CoreTypes.Integer option
        MaxReadRequestSize: CoreTypes.ByteSize option
        MaxRetryDelay: CoreTypes.Duration option
        MaxWriteBufferCount: CoreTypes.Integer option
        MaxWriteBufferSize: CoreTypes.ByteSize option
        MaxWriteRequestOperationCount: CoreTypes.Integer option
        MaxWriteRequestSize: CoreTypes.ByteSize option
        ReadPollTimeout: CoreTypes.Duration option
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
        member _.Index(state: CcrFollowRequest, value: CoreTypes.IndexName) =
            { state with Index = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CcrFollowRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: CcrFollowRequest, value: CoreTypes.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

        [<CustomOperation("dataStreamName")>]
        member _.DataStreamName(state: CcrFollowRequest, value: string) =
            { state with DataStreamName = Some value }

        [<CustomOperation("leaderIndex")>]
        member _.LeaderIndex(state: CcrFollowRequest, value: CoreTypes.IndexName) =
            { state with LeaderIndex = value }

        [<CustomOperation("maxOutstandingReadRequests")>]
        member _.MaxOutstandingReadRequests(state: CcrFollowRequest, value: CoreTypes.Long) =
            { state with MaxOutstandingReadRequests = Some value }

        [<CustomOperation("maxOutstandingWriteRequests")>]
        member _.MaxOutstandingWriteRequests(state: CcrFollowRequest, value: CoreTypes.Integer) =
            { state with MaxOutstandingWriteRequests = Some value }

        [<CustomOperation("maxReadRequestOperationCount")>]
        member _.MaxReadRequestOperationCount(state: CcrFollowRequest, value: CoreTypes.Integer) =
            { state with MaxReadRequestOperationCount = Some value }

        [<CustomOperation("maxReadRequestSize")>]
        member _.MaxReadRequestSize(state: CcrFollowRequest, value: CoreTypes.ByteSize) =
            { state with MaxReadRequestSize = Some value }

        [<CustomOperation("maxRetryDelay")>]
        member _.MaxRetryDelay(state: CcrFollowRequest, value: CoreTypes.Duration) =
            { state with MaxRetryDelay = Some value }

        [<CustomOperation("maxWriteBufferCount")>]
        member _.MaxWriteBufferCount(state: CcrFollowRequest, value: CoreTypes.Integer) =
            { state with MaxWriteBufferCount = Some value }

        [<CustomOperation("maxWriteBufferSize")>]
        member _.MaxWriteBufferSize(state: CcrFollowRequest, value: CoreTypes.ByteSize) =
            { state with MaxWriteBufferSize = Some value }

        [<CustomOperation("maxWriteRequestOperationCount")>]
        member _.MaxWriteRequestOperationCount(state: CcrFollowRequest, value: CoreTypes.Integer) =
            { state with MaxWriteRequestOperationCount = Some value }

        [<CustomOperation("maxWriteRequestSize")>]
        member _.MaxWriteRequestSize(state: CcrFollowRequest, value: CoreTypes.ByteSize) =
            { state with MaxWriteRequestSize = Some value }

        [<CustomOperation("readPollTimeout")>]
        member _.ReadPollTimeout(state: CcrFollowRequest, value: CoreTypes.Duration) =
            { state with ReadPollTimeout = Some value }

        [<CustomOperation("remoteCluster")>]
        member _.RemoteCluster(state: CcrFollowRequest, value: string) =
            { state with RemoteCluster = value }

        [<CustomOperation("settings")>]
        member _.Settings(state: CcrFollowRequest, value: IndicesTypes.IndexSettings) =
            { state with Settings = Some value }

    let ccrFollowRequest = CcrFollowRequestBuilder()

    module Follow =
        let withMasterTimeout (value: CoreTypes.Duration) (req: CcrFollowRequest) =
            { req with MasterTimeout = Some value }
        let withWaitForActiveShards (value: CoreTypes.WaitForActiveShards) (req: CcrFollowRequest) =
            { req with WaitForActiveShards = Some value }
        let withDataStreamName (value: string) (req: CcrFollowRequest) =
            { req with DataStreamName = Some value }
        let withLeaderIndex (value: CoreTypes.IndexName) (req: CcrFollowRequest) =
            { req with LeaderIndex = value }
        let withMaxOutstandingReadRequests (value: CoreTypes.Long) (req: CcrFollowRequest) =
            { req with MaxOutstandingReadRequests = Some value }
        let withMaxOutstandingWriteRequests (value: CoreTypes.Integer) (req: CcrFollowRequest) =
            { req with MaxOutstandingWriteRequests = Some value }
        let withMaxReadRequestOperationCount (value: CoreTypes.Integer) (req: CcrFollowRequest) =
            { req with MaxReadRequestOperationCount = Some value }
        let withMaxReadRequestSize (value: CoreTypes.ByteSize) (req: CcrFollowRequest) =
            { req with MaxReadRequestSize = Some value }
        let withMaxRetryDelay (value: CoreTypes.Duration) (req: CcrFollowRequest) =
            { req with MaxRetryDelay = Some value }
        let withMaxWriteBufferCount (value: CoreTypes.Integer) (req: CcrFollowRequest) =
            { req with MaxWriteBufferCount = Some value }
        let withMaxWriteBufferSize (value: CoreTypes.ByteSize) (req: CcrFollowRequest) =
            { req with MaxWriteBufferSize = Some value }
        let withMaxWriteRequestOperationCount (value: CoreTypes.Integer) (req: CcrFollowRequest) =
            { req with MaxWriteRequestOperationCount = Some value }
        let withMaxWriteRequestSize (value: CoreTypes.ByteSize) (req: CcrFollowRequest) =
            { req with MaxWriteRequestSize = Some value }
        let withReadPollTimeout (value: CoreTypes.Duration) (req: CcrFollowRequest) =
            { req with ReadPollTimeout = Some value }
        let withRemoteCluster (value: string) (req: CcrFollowRequest) =
            { req with RemoteCluster = value }
        let withSettings (value: IndicesTypes.IndexSettings) (req: CcrFollowRequest) =
            { req with Settings = Some value }

    type CcrFollowInfoRequest = {
        Index: CoreTypes.Indices
        MasterTimeout: CoreTypes.Duration option
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
        member _.Index(state: CcrFollowInfoRequest, value: CoreTypes.Indices) =
            { state with Index = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CcrFollowInfoRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

    let ccrFollowInfoRequest = CcrFollowInfoRequestBuilder()

    module FollowInfo =
        let withMasterTimeout (value: CoreTypes.Duration) (req: CcrFollowInfoRequest) =
            { req with MasterTimeout = Some value }

    type CcrFollowStatsRequest = {
        Index: CoreTypes.Indices
        Timeout: CoreTypes.Duration option
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
        member _.Index(state: CcrFollowStatsRequest, value: CoreTypes.Indices) =
            { state with Index = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: CcrFollowStatsRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let ccrFollowStatsRequest = CcrFollowStatsRequestBuilder()

    module FollowStats =
        let withTimeout (value: CoreTypes.Duration) (req: CcrFollowStatsRequest) =
            { req with Timeout = Some value }

    type CcrForgetFollowerRequest = {
        Index: CoreTypes.IndexName
        Timeout: CoreTypes.Duration option
        FollowerCluster: string option
        FollowerIndex: CoreTypes.IndexName option
        FollowerIndexUuid: CoreTypes.Uuid option
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
        member _.Index(state: CcrForgetFollowerRequest, value: CoreTypes.IndexName) =
            { state with Index = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: CcrForgetFollowerRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("followerCluster")>]
        member _.FollowerCluster(state: CcrForgetFollowerRequest, value: string) =
            { state with FollowerCluster = Some value }

        [<CustomOperation("followerIndex")>]
        member _.FollowerIndex(state: CcrForgetFollowerRequest, value: CoreTypes.IndexName) =
            { state with FollowerIndex = Some value }

        [<CustomOperation("followerIndexUuid")>]
        member _.FollowerIndexUuid(state: CcrForgetFollowerRequest, value: CoreTypes.Uuid) =
            { state with FollowerIndexUuid = Some value }

        [<CustomOperation("leaderRemoteCluster")>]
        member _.LeaderRemoteCluster(state: CcrForgetFollowerRequest, value: string) =
            { state with LeaderRemoteCluster = Some value }

    let ccrForgetFollowerRequest = CcrForgetFollowerRequestBuilder()

    module ForgetFollower =
        let withTimeout (value: CoreTypes.Duration) (req: CcrForgetFollowerRequest) =
            { req with Timeout = Some value }
        let withFollowerCluster (value: string) (req: CcrForgetFollowerRequest) =
            { req with FollowerCluster = Some value }
        let withFollowerIndex (value: CoreTypes.IndexName) (req: CcrForgetFollowerRequest) =
            { req with FollowerIndex = Some value }
        let withFollowerIndexUuid (value: CoreTypes.Uuid) (req: CcrForgetFollowerRequest) =
            { req with FollowerIndexUuid = Some value }
        let withLeaderRemoteCluster (value: string) (req: CcrForgetFollowerRequest) =
            { req with LeaderRemoteCluster = Some value }

    type CcrGetAutoFollowPatternRequest = {
        Name: CoreTypes.Name
        MasterTimeout: CoreTypes.Duration option
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
        member _.Name(state: CcrGetAutoFollowPatternRequest, value: CoreTypes.Name) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CcrGetAutoFollowPatternRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

    let ccrGetAutoFollowPatternRequest = CcrGetAutoFollowPatternRequestBuilder()

    module GetAutoFollowPattern =
        let withMasterTimeout (value: CoreTypes.Duration) (req: CcrGetAutoFollowPatternRequest) =
            { req with MasterTimeout = Some value }

    type CcrPauseAutoFollowPatternRequest = {
        Name: CoreTypes.Name
        MasterTimeout: CoreTypes.Duration option
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

    type CcrPauseAutoFollowPatternResponse = CoreTypes.AcknowledgedResponseBase

    type CcrPauseAutoFollowPatternRequestBuilder() =
        member _.Yield(_: unit) : CcrPauseAutoFollowPatternRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: CcrPauseAutoFollowPatternRequest, value: CoreTypes.Name) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CcrPauseAutoFollowPatternRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

    let ccrPauseAutoFollowPatternRequest = CcrPauseAutoFollowPatternRequestBuilder()

    module PauseAutoFollowPattern =
        let withMasterTimeout (value: CoreTypes.Duration) (req: CcrPauseAutoFollowPatternRequest) =
            { req with MasterTimeout = Some value }

    type CcrPauseFollowRequest = {
        Index: CoreTypes.IndexName
        MasterTimeout: CoreTypes.Duration option
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

    type CcrPauseFollowResponse = CoreTypes.AcknowledgedResponseBase

    type CcrPauseFollowRequestBuilder() =
        member _.Yield(_: unit) : CcrPauseFollowRequest =
            {
                Index = Unchecked.defaultof<_>
                MasterTimeout = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: CcrPauseFollowRequest, value: CoreTypes.IndexName) =
            { state with Index = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CcrPauseFollowRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

    let ccrPauseFollowRequest = CcrPauseFollowRequestBuilder()

    module PauseFollow =
        let withMasterTimeout (value: CoreTypes.Duration) (req: CcrPauseFollowRequest) =
            { req with MasterTimeout = Some value }

    type CcrPutAutoFollowPatternRequest = {
        Name: CoreTypes.Name
        MasterTimeout: CoreTypes.Duration option
        RemoteCluster: string
        FollowIndexPattern: CoreTypes.IndexPattern option
        LeaderIndexPatterns: CoreTypes.IndexPatterns option
        LeaderIndexExclusionPatterns: CoreTypes.IndexPatterns option
        MaxOutstandingReadRequests: CoreTypes.Integer option
        Settings: Map<string, System.Text.Json.JsonElement> option
        MaxOutstandingWriteRequests: CoreTypes.Integer option
        ReadPollTimeout: CoreTypes.Duration option
        MaxReadRequestOperationCount: CoreTypes.Integer option
        MaxReadRequestSize: CoreTypes.ByteSize option
        MaxRetryDelay: CoreTypes.Duration option
        MaxWriteBufferCount: CoreTypes.Integer option
        MaxWriteBufferSize: CoreTypes.ByteSize option
        MaxWriteRequestOperationCount: CoreTypes.Integer option
        MaxWriteRequestSize: CoreTypes.ByteSize option
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

    type CcrPutAutoFollowPatternResponse = CoreTypes.AcknowledgedResponseBase

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
        member _.Name(state: CcrPutAutoFollowPatternRequest, value: CoreTypes.Name) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CcrPutAutoFollowPatternRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("remoteCluster")>]
        member _.RemoteCluster(state: CcrPutAutoFollowPatternRequest, value: string) =
            { state with RemoteCluster = value }

        [<CustomOperation("followIndexPattern")>]
        member _.FollowIndexPattern(state: CcrPutAutoFollowPatternRequest, value: CoreTypes.IndexPattern) =
            { state with FollowIndexPattern = Some value }

        [<CustomOperation("leaderIndexPatterns")>]
        member _.LeaderIndexPatterns(state: CcrPutAutoFollowPatternRequest, value: CoreTypes.IndexPatterns) =
            { state with LeaderIndexPatterns = Some value }

        [<CustomOperation("leaderIndexExclusionPatterns")>]
        member _.LeaderIndexExclusionPatterns(state: CcrPutAutoFollowPatternRequest, value: CoreTypes.IndexPatterns) =
            { state with LeaderIndexExclusionPatterns = Some value }

        [<CustomOperation("maxOutstandingReadRequests")>]
        member _.MaxOutstandingReadRequests(state: CcrPutAutoFollowPatternRequest, value: CoreTypes.Integer) =
            { state with MaxOutstandingReadRequests = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: CcrPutAutoFollowPatternRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Settings = Some value }

        [<CustomOperation("maxOutstandingWriteRequests")>]
        member _.MaxOutstandingWriteRequests(state: CcrPutAutoFollowPatternRequest, value: CoreTypes.Integer) =
            { state with MaxOutstandingWriteRequests = Some value }

        [<CustomOperation("readPollTimeout")>]
        member _.ReadPollTimeout(state: CcrPutAutoFollowPatternRequest, value: CoreTypes.Duration) =
            { state with ReadPollTimeout = Some value }

        [<CustomOperation("maxReadRequestOperationCount")>]
        member _.MaxReadRequestOperationCount(state: CcrPutAutoFollowPatternRequest, value: CoreTypes.Integer) =
            { state with MaxReadRequestOperationCount = Some value }

        [<CustomOperation("maxReadRequestSize")>]
        member _.MaxReadRequestSize(state: CcrPutAutoFollowPatternRequest, value: CoreTypes.ByteSize) =
            { state with MaxReadRequestSize = Some value }

        [<CustomOperation("maxRetryDelay")>]
        member _.MaxRetryDelay(state: CcrPutAutoFollowPatternRequest, value: CoreTypes.Duration) =
            { state with MaxRetryDelay = Some value }

        [<CustomOperation("maxWriteBufferCount")>]
        member _.MaxWriteBufferCount(state: CcrPutAutoFollowPatternRequest, value: CoreTypes.Integer) =
            { state with MaxWriteBufferCount = Some value }

        [<CustomOperation("maxWriteBufferSize")>]
        member _.MaxWriteBufferSize(state: CcrPutAutoFollowPatternRequest, value: CoreTypes.ByteSize) =
            { state with MaxWriteBufferSize = Some value }

        [<CustomOperation("maxWriteRequestOperationCount")>]
        member _.MaxWriteRequestOperationCount(state: CcrPutAutoFollowPatternRequest, value: CoreTypes.Integer) =
            { state with MaxWriteRequestOperationCount = Some value }

        [<CustomOperation("maxWriteRequestSize")>]
        member _.MaxWriteRequestSize(state: CcrPutAutoFollowPatternRequest, value: CoreTypes.ByteSize) =
            { state with MaxWriteRequestSize = Some value }

    let ccrPutAutoFollowPatternRequest = CcrPutAutoFollowPatternRequestBuilder()

    module PutAutoFollowPattern =
        let withMasterTimeout (value: CoreTypes.Duration) (req: CcrPutAutoFollowPatternRequest) =
            { req with MasterTimeout = Some value }
        let withRemoteCluster (value: string) (req: CcrPutAutoFollowPatternRequest) =
            { req with RemoteCluster = value }
        let withFollowIndexPattern (value: CoreTypes.IndexPattern) (req: CcrPutAutoFollowPatternRequest) =
            { req with FollowIndexPattern = Some value }
        let withLeaderIndexPatterns (value: CoreTypes.IndexPatterns) (req: CcrPutAutoFollowPatternRequest) =
            { req with LeaderIndexPatterns = Some value }
        let withLeaderIndexExclusionPatterns (value: CoreTypes.IndexPatterns) (req: CcrPutAutoFollowPatternRequest) =
            { req with LeaderIndexExclusionPatterns = Some value }
        let withMaxOutstandingReadRequests (value: CoreTypes.Integer) (req: CcrPutAutoFollowPatternRequest) =
            { req with MaxOutstandingReadRequests = Some value }
        let withSettings (value: Map<string, System.Text.Json.JsonElement>) (req: CcrPutAutoFollowPatternRequest) =
            { req with Settings = Some value }
        let withMaxOutstandingWriteRequests (value: CoreTypes.Integer) (req: CcrPutAutoFollowPatternRequest) =
            { req with MaxOutstandingWriteRequests = Some value }
        let withReadPollTimeout (value: CoreTypes.Duration) (req: CcrPutAutoFollowPatternRequest) =
            { req with ReadPollTimeout = Some value }
        let withMaxReadRequestOperationCount (value: CoreTypes.Integer) (req: CcrPutAutoFollowPatternRequest) =
            { req with MaxReadRequestOperationCount = Some value }
        let withMaxReadRequestSize (value: CoreTypes.ByteSize) (req: CcrPutAutoFollowPatternRequest) =
            { req with MaxReadRequestSize = Some value }
        let withMaxRetryDelay (value: CoreTypes.Duration) (req: CcrPutAutoFollowPatternRequest) =
            { req with MaxRetryDelay = Some value }
        let withMaxWriteBufferCount (value: CoreTypes.Integer) (req: CcrPutAutoFollowPatternRequest) =
            { req with MaxWriteBufferCount = Some value }
        let withMaxWriteBufferSize (value: CoreTypes.ByteSize) (req: CcrPutAutoFollowPatternRequest) =
            { req with MaxWriteBufferSize = Some value }
        let withMaxWriteRequestOperationCount (value: CoreTypes.Integer) (req: CcrPutAutoFollowPatternRequest) =
            { req with MaxWriteRequestOperationCount = Some value }
        let withMaxWriteRequestSize (value: CoreTypes.ByteSize) (req: CcrPutAutoFollowPatternRequest) =
            { req with MaxWriteRequestSize = Some value }

    type CcrResumeAutoFollowPatternRequest = {
        Name: CoreTypes.Name
        MasterTimeout: CoreTypes.Duration option
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

    type CcrResumeAutoFollowPatternResponse = CoreTypes.AcknowledgedResponseBase

    type CcrResumeAutoFollowPatternRequestBuilder() =
        member _.Yield(_: unit) : CcrResumeAutoFollowPatternRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: CcrResumeAutoFollowPatternRequest, value: CoreTypes.Name) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CcrResumeAutoFollowPatternRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

    let ccrResumeAutoFollowPatternRequest = CcrResumeAutoFollowPatternRequestBuilder()

    module ResumeAutoFollowPattern =
        let withMasterTimeout (value: CoreTypes.Duration) (req: CcrResumeAutoFollowPatternRequest) =
            { req with MasterTimeout = Some value }

    type CcrResumeFollowRequest = {
        Index: CoreTypes.IndexName
        MasterTimeout: CoreTypes.Duration option
        MaxOutstandingReadRequests: CoreTypes.Long option
        MaxOutstandingWriteRequests: CoreTypes.Long option
        MaxReadRequestOperationCount: CoreTypes.Long option
        MaxReadRequestSize: string option
        MaxRetryDelay: CoreTypes.Duration option
        MaxWriteBufferCount: CoreTypes.Long option
        MaxWriteBufferSize: string option
        MaxWriteRequestOperationCount: CoreTypes.Long option
        MaxWriteRequestSize: string option
        ReadPollTimeout: CoreTypes.Duration option
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

    type CcrResumeFollowResponse = CoreTypes.AcknowledgedResponseBase

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
        member _.Index(state: CcrResumeFollowRequest, value: CoreTypes.IndexName) =
            { state with Index = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CcrResumeFollowRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("maxOutstandingReadRequests")>]
        member _.MaxOutstandingReadRequests(state: CcrResumeFollowRequest, value: CoreTypes.Long) =
            { state with MaxOutstandingReadRequests = Some value }

        [<CustomOperation("maxOutstandingWriteRequests")>]
        member _.MaxOutstandingWriteRequests(state: CcrResumeFollowRequest, value: CoreTypes.Long) =
            { state with MaxOutstandingWriteRequests = Some value }

        [<CustomOperation("maxReadRequestOperationCount")>]
        member _.MaxReadRequestOperationCount(state: CcrResumeFollowRequest, value: CoreTypes.Long) =
            { state with MaxReadRequestOperationCount = Some value }

        [<CustomOperation("maxReadRequestSize")>]
        member _.MaxReadRequestSize(state: CcrResumeFollowRequest, value: string) =
            { state with MaxReadRequestSize = Some value }

        [<CustomOperation("maxRetryDelay")>]
        member _.MaxRetryDelay(state: CcrResumeFollowRequest, value: CoreTypes.Duration) =
            { state with MaxRetryDelay = Some value }

        [<CustomOperation("maxWriteBufferCount")>]
        member _.MaxWriteBufferCount(state: CcrResumeFollowRequest, value: CoreTypes.Long) =
            { state with MaxWriteBufferCount = Some value }

        [<CustomOperation("maxWriteBufferSize")>]
        member _.MaxWriteBufferSize(state: CcrResumeFollowRequest, value: string) =
            { state with MaxWriteBufferSize = Some value }

        [<CustomOperation("maxWriteRequestOperationCount")>]
        member _.MaxWriteRequestOperationCount(state: CcrResumeFollowRequest, value: CoreTypes.Long) =
            { state with MaxWriteRequestOperationCount = Some value }

        [<CustomOperation("maxWriteRequestSize")>]
        member _.MaxWriteRequestSize(state: CcrResumeFollowRequest, value: string) =
            { state with MaxWriteRequestSize = Some value }

        [<CustomOperation("readPollTimeout")>]
        member _.ReadPollTimeout(state: CcrResumeFollowRequest, value: CoreTypes.Duration) =
            { state with ReadPollTimeout = Some value }

    let ccrResumeFollowRequest = CcrResumeFollowRequestBuilder()

    module ResumeFollow =
        let withMasterTimeout (value: CoreTypes.Duration) (req: CcrResumeFollowRequest) =
            { req with MasterTimeout = Some value }
        let withMaxOutstandingReadRequests (value: CoreTypes.Long) (req: CcrResumeFollowRequest) =
            { req with MaxOutstandingReadRequests = Some value }
        let withMaxOutstandingWriteRequests (value: CoreTypes.Long) (req: CcrResumeFollowRequest) =
            { req with MaxOutstandingWriteRequests = Some value }
        let withMaxReadRequestOperationCount (value: CoreTypes.Long) (req: CcrResumeFollowRequest) =
            { req with MaxReadRequestOperationCount = Some value }
        let withMaxReadRequestSize (value: string) (req: CcrResumeFollowRequest) =
            { req with MaxReadRequestSize = Some value }
        let withMaxRetryDelay (value: CoreTypes.Duration) (req: CcrResumeFollowRequest) =
            { req with MaxRetryDelay = Some value }
        let withMaxWriteBufferCount (value: CoreTypes.Long) (req: CcrResumeFollowRequest) =
            { req with MaxWriteBufferCount = Some value }
        let withMaxWriteBufferSize (value: string) (req: CcrResumeFollowRequest) =
            { req with MaxWriteBufferSize = Some value }
        let withMaxWriteRequestOperationCount (value: CoreTypes.Long) (req: CcrResumeFollowRequest) =
            { req with MaxWriteRequestOperationCount = Some value }
        let withMaxWriteRequestSize (value: string) (req: CcrResumeFollowRequest) =
            { req with MaxWriteRequestSize = Some value }
        let withReadPollTimeout (value: CoreTypes.Duration) (req: CcrResumeFollowRequest) =
            { req with ReadPollTimeout = Some value }

    type CcrStatsRequest = {
        MasterTimeout: CoreTypes.Duration option
        Timeout: CoreTypes.Duration option
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
        member _.MasterTimeout(state: CcrStatsRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: CcrStatsRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let ccrStatsRequest = CcrStatsRequestBuilder()

    module Stats =
        let withMasterTimeout (value: CoreTypes.Duration) (req: CcrStatsRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: CcrStatsRequest) =
            { req with Timeout = Some value }

    type CcrUnfollowRequest = {
        Index: CoreTypes.IndexName
        MasterTimeout: CoreTypes.Duration option
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

    type CcrUnfollowResponse = CoreTypes.AcknowledgedResponseBase

    type CcrUnfollowRequestBuilder() =
        member _.Yield(_: unit) : CcrUnfollowRequest =
            {
                Index = Unchecked.defaultof<_>
                MasterTimeout = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: CcrUnfollowRequest, value: CoreTypes.IndexName) =
            { state with Index = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: CcrUnfollowRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

    let ccrUnfollowRequest = CcrUnfollowRequestBuilder()

    module Unfollow =
        let withMasterTimeout (value: CoreTypes.Duration) (req: CcrUnfollowRequest) =
            { req with MasterTimeout = Some value }


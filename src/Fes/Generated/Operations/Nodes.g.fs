// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module NodesOperations =

    type NodesClearRepositoriesMeteringArchiveRequest = {
        NodeId: CoreTypes.NodeIds
        MaxArchiveVersion: CoreTypes.Long
    }

        with
        static member ToRequest(req: NodesClearRepositoriesMeteringArchiveRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_nodes/{req.NodeId}/_repositories_metering/{req.MaxArchiveVersion}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type NodesClearRepositoriesMeteringArchiveResponse = NodesClearRepositoriesMeteringArchive.ResponseBase

    type NodesClearRepositoriesMeteringArchiveRequestBuilder() =
        member _.Yield(_: unit) : NodesClearRepositoriesMeteringArchiveRequest =
            {
                NodeId = Unchecked.defaultof<_>
                MaxArchiveVersion = Unchecked.defaultof<_>
            }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: NodesClearRepositoriesMeteringArchiveRequest, value: CoreTypes.NodeIds) =
            { state with NodeId = value }

        [<CustomOperation("maxArchiveVersion")>]
        member _.MaxArchiveVersion(state: NodesClearRepositoriesMeteringArchiveRequest, value: CoreTypes.Long) =
            { state with MaxArchiveVersion = value }

    let nodesClearRepositoriesMeteringArchiveRequest = NodesClearRepositoriesMeteringArchiveRequestBuilder()

    type NodesGetRepositoriesMeteringInfoRequest = {
        NodeId: CoreTypes.NodeIds
    }

        with
        static member ToRequest(req: NodesGetRepositoriesMeteringInfoRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_nodes/{req.NodeId}/_repositories_metering"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type NodesGetRepositoriesMeteringInfoResponse = NodesGetRepositoriesMeteringInfo.ResponseBase

    type NodesGetRepositoriesMeteringInfoRequestBuilder() =
        member _.Yield(_: unit) : NodesGetRepositoriesMeteringInfoRequest =
            {
                NodeId = Unchecked.defaultof<_>
            }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: NodesGetRepositoriesMeteringInfoRequest, value: CoreTypes.NodeIds) =
            { state with NodeId = value }

    let nodesGetRepositoriesMeteringInfoRequest = NodesGetRepositoriesMeteringInfoRequestBuilder()

    type NodesHotThreadsRequest = {
        NodeId: CoreTypes.NodeIds
        IgnoreIdleThreads: bool option
        Interval: CoreTypes.Duration option
        Snapshots: CoreTypes.Long option
        Threads: CoreTypes.Long option
        Timeout: CoreTypes.Duration option
        Type: CoreTypes.ThreadType option
        Sort: CoreTypes.ThreadType option
    }

        with
        static member ToRequest(req: NodesHotThreadsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_nodes/{req.NodeId}/hot_threads"
                let queryParams =
                    [
                        req.IgnoreIdleThreads |> Option.map (fun v -> "ignore_idle_threads", Fes.Http.toQueryValue v)
                        req.Interval |> Option.map (fun v -> "interval", Fes.Http.toQueryValue v)
                        req.Snapshots |> Option.map (fun v -> "snapshots", Fes.Http.toQueryValue v)
                        req.Threads |> Option.map (fun v -> "threads", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        req.Type |> Option.map (fun v -> "type", Fes.Http.toQueryValue v)
                        req.Sort |> Option.map (fun v -> "sort", Fes.Http.toQueryValue v)
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

    type NodesHotThreadsResponse = System.Text.Json.JsonElement

    type NodesHotThreadsRequestBuilder() =
        member _.Yield(_: unit) : NodesHotThreadsRequest =
            {
                NodeId = Unchecked.defaultof<_>
                IgnoreIdleThreads = None
                Interval = None
                Snapshots = None
                Threads = None
                Timeout = None
                Type = None
                Sort = None
            }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: NodesHotThreadsRequest, value: CoreTypes.NodeIds) =
            { state with NodeId = value }

        [<CustomOperation("ignoreIdleThreads")>]
        member _.IgnoreIdleThreads(state: NodesHotThreadsRequest, value: bool) =
            { state with IgnoreIdleThreads = Some value }

        [<CustomOperation("interval")>]
        member _.Interval(state: NodesHotThreadsRequest, value: CoreTypes.Duration) =
            { state with Interval = Some value }

        [<CustomOperation("snapshots")>]
        member _.Snapshots(state: NodesHotThreadsRequest, value: CoreTypes.Long) =
            { state with Snapshots = Some value }

        [<CustomOperation("threads")>]
        member _.Threads(state: NodesHotThreadsRequest, value: CoreTypes.Long) =
            { state with Threads = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: NodesHotThreadsRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: NodesHotThreadsRequest, value: CoreTypes.ThreadType) =
            { state with Type = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: NodesHotThreadsRequest, value: CoreTypes.ThreadType) =
            { state with Sort = Some value }

    let nodesHotThreadsRequest = NodesHotThreadsRequestBuilder()

    module HotThreads =
        let withIgnoreIdleThreads (value: bool) (req: NodesHotThreadsRequest) =
            { req with IgnoreIdleThreads = Some value }
        let withInterval (value: CoreTypes.Duration) (req: NodesHotThreadsRequest) =
            { req with Interval = Some value }
        let withSnapshots (value: CoreTypes.Long) (req: NodesHotThreadsRequest) =
            { req with Snapshots = Some value }
        let withThreads (value: CoreTypes.Long) (req: NodesHotThreadsRequest) =
            { req with Threads = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: NodesHotThreadsRequest) =
            { req with Timeout = Some value }
        let withType (value: CoreTypes.ThreadType) (req: NodesHotThreadsRequest) =
            { req with Type = Some value }
        let withSort (value: CoreTypes.ThreadType) (req: NodesHotThreadsRequest) =
            { req with Sort = Some value }

    type NodesInfoRequest = {
        NodeId: CoreTypes.NodeIds
        Metric: NodesInfo.NodesInfoMetrics
        FlatSettings: bool option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: NodesInfoRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_nodes/{req.NodeId}/{req.Metric}"
                let queryParams =
                    [
                        req.FlatSettings |> Option.map (fun v -> "flat_settings", Fes.Http.toQueryValue v)
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

    type NodesInfoResponse = NodesInfo.ResponseBase

    type NodesInfoRequestBuilder() =
        member _.Yield(_: unit) : NodesInfoRequest =
            {
                NodeId = Unchecked.defaultof<_>
                Metric = Unchecked.defaultof<_>
                FlatSettings = None
                Timeout = None
            }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: NodesInfoRequest, value: CoreTypes.NodeIds) =
            { state with NodeId = value }

        [<CustomOperation("metric")>]
        member _.Metric(state: NodesInfoRequest, value: NodesInfo.NodesInfoMetrics) =
            { state with Metric = value }

        [<CustomOperation("flatSettings")>]
        member _.FlatSettings(state: NodesInfoRequest, value: bool) =
            { state with FlatSettings = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: NodesInfoRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let nodesInfoRequest = NodesInfoRequestBuilder()

    module Info =
        let withFlatSettings (value: bool) (req: NodesInfoRequest) =
            { req with FlatSettings = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: NodesInfoRequest) =
            { req with Timeout = Some value }

    type NodesReloadSecureSettingsRequest = {
        NodeId: CoreTypes.NodeIds
        Timeout: CoreTypes.Duration option
        SecureSettingsPassword: CoreTypes.Password option
    }

        with
        static member ToRequest(req: NodesReloadSecureSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_nodes/{req.NodeId}/reload_secure_settings"
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

    type NodesReloadSecureSettingsResponse = NodesReloadSecureSettings.ResponseBase

    type NodesReloadSecureSettingsRequestBuilder() =
        member _.Yield(_: unit) : NodesReloadSecureSettingsRequest =
            {
                NodeId = Unchecked.defaultof<_>
                Timeout = None
                SecureSettingsPassword = None
            }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: NodesReloadSecureSettingsRequest, value: CoreTypes.NodeIds) =
            { state with NodeId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: NodesReloadSecureSettingsRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("secureSettingsPassword")>]
        member _.SecureSettingsPassword(state: NodesReloadSecureSettingsRequest, value: CoreTypes.Password) =
            { state with SecureSettingsPassword = Some value }

    let nodesReloadSecureSettingsRequest = NodesReloadSecureSettingsRequestBuilder()

    module ReloadSecureSettings =
        let withTimeout (value: CoreTypes.Duration) (req: NodesReloadSecureSettingsRequest) =
            { req with Timeout = Some value }
        let withSecureSettingsPassword (value: CoreTypes.Password) (req: NodesReloadSecureSettingsRequest) =
            { req with SecureSettingsPassword = Some value }

    type NodesStatsRequest = {
        NodeId: CoreTypes.NodeIds
        Metric: NodesStats.NodeStatsMetrics
        IndexMetric: CoreTypes.CommonStatsFlags
        CompletionFields: CoreTypes.Fields option
        FielddataFields: CoreTypes.Fields option
        Fields: CoreTypes.Fields option
        Groups: bool option
        IncludeSegmentFileSizes: bool option
        Level: CoreTypes.NodeStatsLevel option
        Timeout: CoreTypes.Duration option
        Types: string list option
        IncludeUnloadedSegments: bool option
    }

        with
        static member ToRequest(req: NodesStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_nodes/{req.NodeId}/stats/{req.Metric}/{req.IndexMetric}"
                let queryParams =
                    [
                        req.CompletionFields |> Option.map (fun v -> "completion_fields", Fes.Http.toQueryValue v)
                        req.FielddataFields |> Option.map (fun v -> "fielddata_fields", Fes.Http.toQueryValue v)
                        req.Fields |> Option.map (fun v -> "fields", Fes.Http.toQueryValue v)
                        req.Groups |> Option.map (fun v -> "groups", Fes.Http.toQueryValue v)
                        req.IncludeSegmentFileSizes |> Option.map (fun v -> "include_segment_file_sizes", Fes.Http.toQueryValue v)
                        req.Level |> Option.map (fun v -> "level", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        req.Types |> Option.map (fun v -> "types", Fes.Http.toQueryValue v)
                        req.IncludeUnloadedSegments |> Option.map (fun v -> "include_unloaded_segments", Fes.Http.toQueryValue v)
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

    type NodesStatsResponse = NodesStats.ResponseBase

    type NodesStatsRequestBuilder() =
        member _.Yield(_: unit) : NodesStatsRequest =
            {
                NodeId = Unchecked.defaultof<_>
                Metric = Unchecked.defaultof<_>
                IndexMetric = Unchecked.defaultof<_>
                CompletionFields = None
                FielddataFields = None
                Fields = None
                Groups = None
                IncludeSegmentFileSizes = None
                Level = None
                Timeout = None
                Types = None
                IncludeUnloadedSegments = None
            }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: NodesStatsRequest, value: CoreTypes.NodeIds) =
            { state with NodeId = value }

        [<CustomOperation("metric")>]
        member _.Metric(state: NodesStatsRequest, value: NodesStats.NodeStatsMetrics) =
            { state with Metric = value }

        [<CustomOperation("indexMetric")>]
        member _.IndexMetric(state: NodesStatsRequest, value: CoreTypes.CommonStatsFlags) =
            { state with IndexMetric = value }

        [<CustomOperation("completionFields")>]
        member _.CompletionFields(state: NodesStatsRequest, value: CoreTypes.Fields) =
            { state with CompletionFields = Some value }

        [<CustomOperation("fielddataFields")>]
        member _.FielddataFields(state: NodesStatsRequest, value: CoreTypes.Fields) =
            { state with FielddataFields = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: NodesStatsRequest, value: CoreTypes.Fields) =
            { state with Fields = Some value }

        [<CustomOperation("groups")>]
        member _.Groups(state: NodesStatsRequest, value: bool) =
            { state with Groups = Some value }

        [<CustomOperation("includeSegmentFileSizes")>]
        member _.IncludeSegmentFileSizes(state: NodesStatsRequest, value: bool) =
            { state with IncludeSegmentFileSizes = Some value }

        [<CustomOperation("level")>]
        member _.Level(state: NodesStatsRequest, value: CoreTypes.NodeStatsLevel) =
            { state with Level = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: NodesStatsRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("types")>]
        member _.Types(state: NodesStatsRequest, value: string list) =
            { state with Types = Some value }

        [<CustomOperation("includeUnloadedSegments")>]
        member _.IncludeUnloadedSegments(state: NodesStatsRequest, value: bool) =
            { state with IncludeUnloadedSegments = Some value }

    let nodesStatsRequest = NodesStatsRequestBuilder()

    module Stats =
        let withCompletionFields (value: CoreTypes.Fields) (req: NodesStatsRequest) =
            { req with CompletionFields = Some value }
        let withFielddataFields (value: CoreTypes.Fields) (req: NodesStatsRequest) =
            { req with FielddataFields = Some value }
        let withFields (value: CoreTypes.Fields) (req: NodesStatsRequest) =
            { req with Fields = Some value }
        let withGroups (value: bool) (req: NodesStatsRequest) =
            { req with Groups = Some value }
        let withIncludeSegmentFileSizes (value: bool) (req: NodesStatsRequest) =
            { req with IncludeSegmentFileSizes = Some value }
        let withLevel (value: CoreTypes.NodeStatsLevel) (req: NodesStatsRequest) =
            { req with Level = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: NodesStatsRequest) =
            { req with Timeout = Some value }
        let withTypes (value: string list) (req: NodesStatsRequest) =
            { req with Types = Some value }
        let withIncludeUnloadedSegments (value: bool) (req: NodesStatsRequest) =
            { req with IncludeUnloadedSegments = Some value }

    type NodesUsageRequest = {
        NodeId: CoreTypes.NodeIds
        Metric: NodesUsage.NodesUsageMetrics
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: NodesUsageRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_nodes/{req.NodeId}/usage/{req.Metric}"
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

    type NodesUsageResponse = NodesUsage.ResponseBase

    type NodesUsageRequestBuilder() =
        member _.Yield(_: unit) : NodesUsageRequest =
            {
                NodeId = Unchecked.defaultof<_>
                Metric = Unchecked.defaultof<_>
                Timeout = None
            }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: NodesUsageRequest, value: CoreTypes.NodeIds) =
            { state with NodeId = value }

        [<CustomOperation("metric")>]
        member _.Metric(state: NodesUsageRequest, value: NodesUsage.NodesUsageMetrics) =
            { state with Metric = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: NodesUsageRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let nodesUsageRequest = NodesUsageRequestBuilder()

    module Usage =
        let withTimeout (value: CoreTypes.Duration) (req: NodesUsageRequest) =
            { req with Timeout = Some value }


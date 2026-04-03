// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module SearchableSnapshotsOperations =

    type SearchableSnapshotsCacheStatsRequest = {
        NodeId: CoreTypes.NodeIds
    }

        with
        static member ToRequest(req: SearchableSnapshotsCacheStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_searchable_snapshots/{req.NodeId}/cache/stats"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type SearchableSnapshotsCacheStatsResponse = System.Text.Json.JsonElement

    type SearchableSnapshotsCacheStatsRequestBuilder() =
        member _.Yield(_: unit) : SearchableSnapshotsCacheStatsRequest =
            {
                NodeId = Unchecked.defaultof<_>
            }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: SearchableSnapshotsCacheStatsRequest, value: CoreTypes.NodeIds) =
            { state with NodeId = value }

    let searchableSnapshotsCacheStatsRequest = SearchableSnapshotsCacheStatsRequestBuilder()

    type SearchableSnapshotsClearCacheRequest = {
        Index: CoreTypes.Indices
        ExpandWildcards: CoreTypes.ExpandWildcards option
        AllowNoIndices: bool option
        IgnoreUnavailable: bool option
    }

        with
        static member ToRequest(req: SearchableSnapshotsClearCacheRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_searchable_snapshots/cache/clear"
                let queryParams =
                    [
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
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

    type SearchableSnapshotsClearCacheResponse = System.Text.Json.JsonElement

    type SearchableSnapshotsClearCacheRequestBuilder() =
        member _.Yield(_: unit) : SearchableSnapshotsClearCacheRequest =
            {
                Index = Unchecked.defaultof<_>
                ExpandWildcards = None
                AllowNoIndices = None
                IgnoreUnavailable = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: SearchableSnapshotsClearCacheRequest, value: CoreTypes.Indices) =
            { state with Index = value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: SearchableSnapshotsClearCacheRequest, value: CoreTypes.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: SearchableSnapshotsClearCacheRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: SearchableSnapshotsClearCacheRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

    let searchableSnapshotsClearCacheRequest = SearchableSnapshotsClearCacheRequestBuilder()

    module ClearCache =
        let withExpandWildcards (value: CoreTypes.ExpandWildcards) (req: SearchableSnapshotsClearCacheRequest) =
            { req with ExpandWildcards = Some value }
        let withAllowNoIndices (value: bool) (req: SearchableSnapshotsClearCacheRequest) =
            { req with AllowNoIndices = Some value }
        let withIgnoreUnavailable (value: bool) (req: SearchableSnapshotsClearCacheRequest) =
            { req with IgnoreUnavailable = Some value }

    type SearchableSnapshotsMountRequest = {
        Repository: CoreTypes.Name
        Snapshot: CoreTypes.Name
        MasterTimeout: CoreTypes.Duration option
        WaitForCompletion: bool option
        Storage: SearchableSnapshotsMount.StorageOption option
        Index: CoreTypes.IndexName
        RenamedIndex: CoreTypes.IndexName option
        IndexSettings: Map<string, System.Text.Json.JsonElement> option
        IgnoreIndexSettings: string list option
    }

        with
        static member ToRequest(req: SearchableSnapshotsMountRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{req.Repository}/{req.Snapshot}/_mount"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                        req.Storage |> Option.map (fun v -> "storage", Fes.Http.toQueryValue v)
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

    type SearchableSnapshotsMountResponse = System.Text.Json.JsonElement

    type SearchableSnapshotsMountRequestBuilder() =
        member _.Yield(_: unit) : SearchableSnapshotsMountRequest =
            {
                Repository = Unchecked.defaultof<_>
                Snapshot = Unchecked.defaultof<_>
                MasterTimeout = None
                WaitForCompletion = None
                Storage = None
                Index = Unchecked.defaultof<_>
                RenamedIndex = None
                IndexSettings = None
                IgnoreIndexSettings = None
            }

        [<CustomOperation("repository")>]
        member _.Repository(state: SearchableSnapshotsMountRequest, value: CoreTypes.Name) =
            { state with Repository = value }

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: SearchableSnapshotsMountRequest, value: CoreTypes.Name) =
            { state with Snapshot = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SearchableSnapshotsMountRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: SearchableSnapshotsMountRequest, value: bool) =
            { state with WaitForCompletion = Some value }

        [<CustomOperation("storage")>]
        member _.Storage(state: SearchableSnapshotsMountRequest, value: SearchableSnapshotsMount.StorageOption) =
            { state with Storage = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: SearchableSnapshotsMountRequest, value: CoreTypes.IndexName) =
            { state with Index = value }

        [<CustomOperation("renamedIndex")>]
        member _.RenamedIndex(state: SearchableSnapshotsMountRequest, value: CoreTypes.IndexName) =
            { state with RenamedIndex = Some value }

        [<CustomOperation("indexSettings")>]
        member _.IndexSettings(state: SearchableSnapshotsMountRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with IndexSettings = Some value }

        [<CustomOperation("ignoreIndexSettings")>]
        member _.IgnoreIndexSettings(state: SearchableSnapshotsMountRequest, value: string list) =
            { state with IgnoreIndexSettings = Some value }

    let searchableSnapshotsMountRequest = SearchableSnapshotsMountRequestBuilder()

    module Mount =
        let withMasterTimeout (value: CoreTypes.Duration) (req: SearchableSnapshotsMountRequest) =
            { req with MasterTimeout = Some value }
        let withWaitForCompletion (value: bool) (req: SearchableSnapshotsMountRequest) =
            { req with WaitForCompletion = Some value }
        let withStorage (value: SearchableSnapshotsMount.StorageOption) (req: SearchableSnapshotsMountRequest) =
            { req with Storage = Some value }
        let withIndex (value: CoreTypes.IndexName) (req: SearchableSnapshotsMountRequest) =
            { req with Index = value }
        let withRenamedIndex (value: CoreTypes.IndexName) (req: SearchableSnapshotsMountRequest) =
            { req with RenamedIndex = Some value }
        let withIndexSettings (value: Map<string, System.Text.Json.JsonElement>) (req: SearchableSnapshotsMountRequest) =
            { req with IndexSettings = Some value }
        let withIgnoreIndexSettings (value: string list) (req: SearchableSnapshotsMountRequest) =
            { req with IgnoreIndexSettings = Some value }

    type SearchableSnapshotsStatsRequest = {
        Index: CoreTypes.Indices
        Level: SearchableSnapshotsTypes.StatsLevel option
    }

        with
        static member ToRequest(req: SearchableSnapshotsStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_searchable_snapshots/stats"
                let queryParams =
                    [
                        req.Level |> Option.map (fun v -> "level", Fes.Http.toQueryValue v)
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

    type SearchableSnapshotsStatsResponse = System.Text.Json.JsonElement

    type SearchableSnapshotsStatsRequestBuilder() =
        member _.Yield(_: unit) : SearchableSnapshotsStatsRequest =
            {
                Index = Unchecked.defaultof<_>
                Level = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: SearchableSnapshotsStatsRequest, value: CoreTypes.Indices) =
            { state with Index = value }

        [<CustomOperation("level")>]
        member _.Level(state: SearchableSnapshotsStatsRequest, value: SearchableSnapshotsTypes.StatsLevel) =
            { state with Level = Some value }

    let searchableSnapshotsStatsRequest = SearchableSnapshotsStatsRequestBuilder()

    module Stats =
        let withLevel (value: SearchableSnapshotsTypes.StatsLevel) (req: SearchableSnapshotsStatsRequest) =
            { req with Level = Some value }


// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module SearchableSnapshotsOperations =

    type SearchableSnapshotsCacheStatsRequest = {
        NodeId: NodeIds
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: SearchableSnapshotsCacheStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_searchable_snapshots/{request.NodeId}/cache/stats"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
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

    module SearchableSnapshotsCacheStatsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SearchableSnapshotsCacheStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            SearchableSnapshotsCacheStatsRequest.ToRequest request

    type SearchableSnapshotsCacheStatsRequestBuilder() =
        member _.Yield(_: unit) : SearchableSnapshotsCacheStatsRequest =
            {
                SearchableSnapshotsCacheStatsRequest.NodeId = Unchecked.defaultof<NodeIds>
                SearchableSnapshotsCacheStatsRequest.MasterTimeout = Option.None
            } : SearchableSnapshotsCacheStatsRequest

        [<CustomOperation("node_id")>]
        member _.NodeId(state: SearchableSnapshotsCacheStatsRequest, value: NodeIds) =
            { state with SearchableSnapshotsCacheStatsRequest.NodeId = value } : SearchableSnapshotsCacheStatsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SearchableSnapshotsCacheStatsRequest, value: Duration) =
            { state with SearchableSnapshotsCacheStatsRequest.MasterTimeout = Option.Some value } : SearchableSnapshotsCacheStatsRequest

    let searchableSnapshotsCacheStatsRequest = SearchableSnapshotsCacheStatsRequestBuilder()

    type SearchableSnapshotsClearCacheRequest = {
        Index: Indices
        ExpandWildcards: ExpandWildcards option
        AllowNoIndices: bool option
        IgnoreUnavailable: bool option
    } with
        static member ToRequest(request: SearchableSnapshotsClearCacheRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_searchable_snapshots/cache/clear"
                let queryParams =
                    [
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
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

    module SearchableSnapshotsClearCacheRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SearchableSnapshotsClearCacheRequest) : Result<Fes.Http.RequestMsg, exn> =
            SearchableSnapshotsClearCacheRequest.ToRequest request

    type SearchableSnapshotsClearCacheRequestBuilder() =
        member _.Yield(_: unit) : SearchableSnapshotsClearCacheRequest =
            {
                SearchableSnapshotsClearCacheRequest.Index = Unchecked.defaultof<Indices>
                SearchableSnapshotsClearCacheRequest.ExpandWildcards = Option.None
                SearchableSnapshotsClearCacheRequest.AllowNoIndices = Option.None
                SearchableSnapshotsClearCacheRequest.IgnoreUnavailable = Option.None
            } : SearchableSnapshotsClearCacheRequest

        [<CustomOperation("index")>]
        member _.Index(state: SearchableSnapshotsClearCacheRequest, value: Indices) =
            { state with SearchableSnapshotsClearCacheRequest.Index = value } : SearchableSnapshotsClearCacheRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: SearchableSnapshotsClearCacheRequest, value: ExpandWildcards) =
            { state with SearchableSnapshotsClearCacheRequest.ExpandWildcards = Option.Some value } : SearchableSnapshotsClearCacheRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: SearchableSnapshotsClearCacheRequest, value: bool) =
            { state with SearchableSnapshotsClearCacheRequest.AllowNoIndices = Option.Some value } : SearchableSnapshotsClearCacheRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: SearchableSnapshotsClearCacheRequest, value: bool) =
            { state with SearchableSnapshotsClearCacheRequest.IgnoreUnavailable = Option.Some value } : SearchableSnapshotsClearCacheRequest

    let searchableSnapshotsClearCacheRequest = SearchableSnapshotsClearCacheRequestBuilder()

    type SearchableSnapshotsMountRequest = {
        Repository: Name
        Snapshot: Name
        MasterTimeout: Duration option
        WaitForCompletion: bool option
        Storage: string option
        [<JsonPropertyName("index")>]
        Index: IndexName
        [<JsonPropertyName("renamed_index")>]
        RenamedIndex: IndexName option
        [<JsonPropertyName("index_settings")>]
        IndexSettings: Map<string, obj> option
        [<JsonPropertyName("ignore_index_settings")>]
        IgnoreIndexSettings: string array option
    } with
        static member ToRequest(request: SearchableSnapshotsMountRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_snapshot/{request.Repository}/{request.Snapshot}/_mount"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                        request.Storage |> Option.map (fun v -> "storage", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``index`` = request.Index; ``renamed_index`` = request.RenamedIndex; ``index_settings`` = request.IndexSettings; ``ignore_index_settings`` = request.IgnoreIndexSettings |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SearchableSnapshotsMountRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SearchableSnapshotsMountRequest) : Result<Fes.Http.RequestMsg, exn> =
            SearchableSnapshotsMountRequest.ToRequest request

    type SearchableSnapshotsMountRequestBuilder() =
        member _.Yield(_: unit) : SearchableSnapshotsMountRequest =
            {
                SearchableSnapshotsMountRequest.Repository = Unchecked.defaultof<Name>
                SearchableSnapshotsMountRequest.Snapshot = Unchecked.defaultof<Name>
                SearchableSnapshotsMountRequest.MasterTimeout = Option.None
                SearchableSnapshotsMountRequest.WaitForCompletion = Option.None
                SearchableSnapshotsMountRequest.Storage = Option.None
                SearchableSnapshotsMountRequest.Index = Unchecked.defaultof<IndexName>
                SearchableSnapshotsMountRequest.RenamedIndex = Option.None
                SearchableSnapshotsMountRequest.IndexSettings = Option.None
                SearchableSnapshotsMountRequest.IgnoreIndexSettings = Option.None
            } : SearchableSnapshotsMountRequest

        [<CustomOperation("repository")>]
        member _.Repository(state: SearchableSnapshotsMountRequest, value: Name) =
            { state with SearchableSnapshotsMountRequest.Repository = value } : SearchableSnapshotsMountRequest

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: SearchableSnapshotsMountRequest, value: Name) =
            { state with SearchableSnapshotsMountRequest.Snapshot = value } : SearchableSnapshotsMountRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SearchableSnapshotsMountRequest, value: Duration) =
            { state with SearchableSnapshotsMountRequest.MasterTimeout = Option.Some value } : SearchableSnapshotsMountRequest

        [<CustomOperation("wait_for_completion")>]
        member _.WaitForCompletion(state: SearchableSnapshotsMountRequest, value: bool) =
            { state with SearchableSnapshotsMountRequest.WaitForCompletion = Option.Some value } : SearchableSnapshotsMountRequest

        [<CustomOperation("storage")>]
        member _.Storage(state: SearchableSnapshotsMountRequest, value: string) =
            { state with SearchableSnapshotsMountRequest.Storage = Option.Some value } : SearchableSnapshotsMountRequest

        [<CustomOperation("index")>]
        member _.Index(state: SearchableSnapshotsMountRequest, value: IndexName) =
            { state with SearchableSnapshotsMountRequest.Index = value } : SearchableSnapshotsMountRequest

        [<CustomOperation("renamed_index")>]
        member _.RenamedIndex(state: SearchableSnapshotsMountRequest, value: IndexName) =
            { state with SearchableSnapshotsMountRequest.RenamedIndex = Option.Some value } : SearchableSnapshotsMountRequest

        [<CustomOperation("index_settings")>]
        member _.IndexSettings(state: SearchableSnapshotsMountRequest, value: Map<string, obj>) =
            { state with SearchableSnapshotsMountRequest.IndexSettings = Option.Some value } : SearchableSnapshotsMountRequest

        [<CustomOperation("ignore_index_settings")>]
        member _.IgnoreIndexSettings(state: SearchableSnapshotsMountRequest, value: string array) =
            { state with SearchableSnapshotsMountRequest.IgnoreIndexSettings = Option.Some value } : SearchableSnapshotsMountRequest

    let searchableSnapshotsMountRequest = SearchableSnapshotsMountRequestBuilder()

    type SearchableSnapshotsMountResponse = {
        [<JsonPropertyName("snapshot")>]
        Snapshot: MountMountedSnapshot
    }

    type SearchableSnapshotsStatsRequest = {
        Index: Indices
        Level: TypesStatsLevel option
    } with
        static member ToRequest(request: SearchableSnapshotsStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_searchable_snapshots/stats"
                let queryParams =
                    [
                        request.Level |> Option.map (fun v -> "level", Fes.Http.toQueryValue v)
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

    module SearchableSnapshotsStatsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SearchableSnapshotsStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            SearchableSnapshotsStatsRequest.ToRequest request

    type SearchableSnapshotsStatsRequestBuilder() =
        member _.Yield(_: unit) : SearchableSnapshotsStatsRequest =
            {
                SearchableSnapshotsStatsRequest.Index = Unchecked.defaultof<Indices>
                SearchableSnapshotsStatsRequest.Level = Option.None
            } : SearchableSnapshotsStatsRequest

        [<CustomOperation("index")>]
        member _.Index(state: SearchableSnapshotsStatsRequest, value: Indices) =
            { state with SearchableSnapshotsStatsRequest.Index = value } : SearchableSnapshotsStatsRequest

        [<CustomOperation("level")>]
        member _.Level(state: SearchableSnapshotsStatsRequest, value: TypesStatsLevel) =
            { state with SearchableSnapshotsStatsRequest.Level = Option.Some value } : SearchableSnapshotsStatsRequest

    let searchableSnapshotsStatsRequest = SearchableSnapshotsStatsRequestBuilder()


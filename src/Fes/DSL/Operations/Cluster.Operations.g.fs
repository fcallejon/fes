// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module ClusterOperations =

    type ClusterAllocationExplainRequest = {
        [<JsonPropertyName("index")>]
        Index: IndexName option
        [<JsonPropertyName("shard")>]
        Shard: float option
        [<JsonPropertyName("primary")>]
        Primary: bool option
        [<JsonPropertyName("current_node")>]
        CurrentNode: NodeId option
        [<JsonPropertyName("include_disk_info")>]
        IncludeDiskInfo: bool option
        [<JsonPropertyName("include_yes_decisions")>]
        IncludeYesDecisions: bool option
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
        [<JsonPropertyName("index")>]
        Index2: IndexName option
        [<JsonPropertyName("shard")>]
        Shard2: float option
        [<JsonPropertyName("primary")>]
        Primary2: bool option
        [<JsonPropertyName("current_node")>]
        CurrentNode2: NodeId option
    } with
        static member ToRequest(request: ClusterAllocationExplainRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_cluster/allocation/explain"
                let queryParams =
                    [
                        request.Index |> Option.map (fun v -> "index", string v)
                        request.Shard |> Option.map (fun v -> "shard", string v)
                        request.Primary |> Option.map (fun v -> "primary", string v)
                        request.CurrentNode |> Option.map (fun v -> "current_node", string v)
                        request.IncludeDiskInfo |> Option.map (fun v -> "include_disk_info", string v)
                        request.IncludeYesDecisions |> Option.map (fun v -> "include_yes_decisions", string v)
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

    module ClusterAllocationExplainRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ClusterAllocationExplainRequest) : Result<Fes.Http.RequestMsg, exn> =
            ClusterAllocationExplainRequest.ToRequest request

    type ClusterAllocationExplainRequestBuilder() =
        member _.Yield(_: unit) : ClusterAllocationExplainRequest =
            {
                ClusterAllocationExplainRequest.Index = Option.None
                ClusterAllocationExplainRequest.Shard = Option.None
                ClusterAllocationExplainRequest.Primary = Option.None
                ClusterAllocationExplainRequest.CurrentNode = Option.None
                ClusterAllocationExplainRequest.IncludeDiskInfo = Option.None
                ClusterAllocationExplainRequest.IncludeYesDecisions = Option.None
                ClusterAllocationExplainRequest.MasterTimeout = Option.None
                ClusterAllocationExplainRequest.Index2 = Option.None
                ClusterAllocationExplainRequest.Shard2 = Option.None
                ClusterAllocationExplainRequest.Primary2 = Option.None
                ClusterAllocationExplainRequest.CurrentNode2 = Option.None
            } : ClusterAllocationExplainRequest

        [<CustomOperation("index")>]
        member _.Index(state: ClusterAllocationExplainRequest, value: IndexName) =
            { state with ClusterAllocationExplainRequest.Index = Option.Some value } : ClusterAllocationExplainRequest

        [<CustomOperation("shard")>]
        member _.Shard(state: ClusterAllocationExplainRequest, value: float) =
            { state with ClusterAllocationExplainRequest.Shard = Option.Some value } : ClusterAllocationExplainRequest

        [<CustomOperation("primary")>]
        member _.Primary(state: ClusterAllocationExplainRequest, value: bool) =
            { state with ClusterAllocationExplainRequest.Primary = Option.Some value } : ClusterAllocationExplainRequest

        [<CustomOperation("current_node")>]
        member _.CurrentNode(state: ClusterAllocationExplainRequest, value: NodeId) =
            { state with ClusterAllocationExplainRequest.CurrentNode = Option.Some value } : ClusterAllocationExplainRequest

        [<CustomOperation("include_disk_info")>]
        member _.IncludeDiskInfo(state: ClusterAllocationExplainRequest, value: bool) =
            { state with ClusterAllocationExplainRequest.IncludeDiskInfo = Option.Some value } : ClusterAllocationExplainRequest

        [<CustomOperation("include_yes_decisions")>]
        member _.IncludeYesDecisions(state: ClusterAllocationExplainRequest, value: bool) =
            { state with ClusterAllocationExplainRequest.IncludeYesDecisions = Option.Some value } : ClusterAllocationExplainRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: ClusterAllocationExplainRequest, value: Duration) =
            { state with ClusterAllocationExplainRequest.MasterTimeout = Option.Some value } : ClusterAllocationExplainRequest

        [<CustomOperation("index2")>]
        member _.Index2(state: ClusterAllocationExplainRequest, value: IndexName) =
            { state with ClusterAllocationExplainRequest.Index2 = Option.Some value } : ClusterAllocationExplainRequest

        [<CustomOperation("shard2")>]
        member _.Shard2(state: ClusterAllocationExplainRequest, value: float) =
            { state with ClusterAllocationExplainRequest.Shard2 = Option.Some value } : ClusterAllocationExplainRequest

        [<CustomOperation("primary2")>]
        member _.Primary2(state: ClusterAllocationExplainRequest, value: bool) =
            { state with ClusterAllocationExplainRequest.Primary2 = Option.Some value } : ClusterAllocationExplainRequest

        [<CustomOperation("current_node2")>]
        member _.CurrentNode2(state: ClusterAllocationExplainRequest, value: NodeId) =
            { state with ClusterAllocationExplainRequest.CurrentNode2 = Option.Some value } : ClusterAllocationExplainRequest

    let clusterAllocationExplainRequest = ClusterAllocationExplainRequestBuilder()

    type ClusterPostVotingConfigExclusionsRequest = {
        [<JsonPropertyName("node_names")>]
        NodeNames: Names option
        [<JsonPropertyName("node_ids")>]
        NodeIds: Ids option
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
    } with
        static member ToRequest(request: ClusterPostVotingConfigExclusionsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_cluster/voting_config_exclusions"
                let queryParams =
                    [
                        request.NodeNames |> Option.map (fun v -> "node_names", string v)
                        request.NodeIds |> Option.map (fun v -> "node_ids", string v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
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

    module ClusterPostVotingConfigExclusionsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ClusterPostVotingConfigExclusionsRequest) : Result<Fes.Http.RequestMsg, exn> =
            ClusterPostVotingConfigExclusionsRequest.ToRequest request

    type ClusterPostVotingConfigExclusionsRequestBuilder() =
        member _.Yield(_: unit) : ClusterPostVotingConfigExclusionsRequest =
            {
                ClusterPostVotingConfigExclusionsRequest.NodeNames = Option.None
                ClusterPostVotingConfigExclusionsRequest.NodeIds = Option.None
                ClusterPostVotingConfigExclusionsRequest.MasterTimeout = Option.None
                ClusterPostVotingConfigExclusionsRequest.Timeout = Option.None
            } : ClusterPostVotingConfigExclusionsRequest

        [<CustomOperation("node_names")>]
        member _.NodeNames(state: ClusterPostVotingConfigExclusionsRequest, value: Names) =
            { state with ClusterPostVotingConfigExclusionsRequest.NodeNames = Option.Some value } : ClusterPostVotingConfigExclusionsRequest

        [<CustomOperation("node_ids")>]
        member _.NodeIds(state: ClusterPostVotingConfigExclusionsRequest, value: Ids) =
            { state with ClusterPostVotingConfigExclusionsRequest.NodeIds = Option.Some value } : ClusterPostVotingConfigExclusionsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: ClusterPostVotingConfigExclusionsRequest, value: Duration) =
            { state with ClusterPostVotingConfigExclusionsRequest.MasterTimeout = Option.Some value } : ClusterPostVotingConfigExclusionsRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: ClusterPostVotingConfigExclusionsRequest, value: Duration) =
            { state with ClusterPostVotingConfigExclusionsRequest.Timeout = Option.Some value } : ClusterPostVotingConfigExclusionsRequest

    let clusterPostVotingConfigExclusionsRequest = ClusterPostVotingConfigExclusionsRequestBuilder()

    type ClusterDeleteVotingConfigExclusionsRequest = {
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
        [<JsonPropertyName("wait_for_removal")>]
        WaitForRemoval: bool option
    } with
        static member ToRequest(request: ClusterDeleteVotingConfigExclusionsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_cluster/voting_config_exclusions"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                        request.WaitForRemoval |> Option.map (fun v -> "wait_for_removal", string v)
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

    module ClusterDeleteVotingConfigExclusionsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ClusterDeleteVotingConfigExclusionsRequest) : Result<Fes.Http.RequestMsg, exn> =
            ClusterDeleteVotingConfigExclusionsRequest.ToRequest request

    type ClusterDeleteVotingConfigExclusionsRequestBuilder() =
        member _.Yield(_: unit) : ClusterDeleteVotingConfigExclusionsRequest =
            {
                ClusterDeleteVotingConfigExclusionsRequest.MasterTimeout = Option.None
                ClusterDeleteVotingConfigExclusionsRequest.WaitForRemoval = Option.None
            } : ClusterDeleteVotingConfigExclusionsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: ClusterDeleteVotingConfigExclusionsRequest, value: Duration) =
            { state with ClusterDeleteVotingConfigExclusionsRequest.MasterTimeout = Option.Some value } : ClusterDeleteVotingConfigExclusionsRequest

        [<CustomOperation("wait_for_removal")>]
        member _.WaitForRemoval(state: ClusterDeleteVotingConfigExclusionsRequest, value: bool) =
            { state with ClusterDeleteVotingConfigExclusionsRequest.WaitForRemoval = Option.Some value } : ClusterDeleteVotingConfigExclusionsRequest

    let clusterDeleteVotingConfigExclusionsRequest = ClusterDeleteVotingConfigExclusionsRequestBuilder()

    type ClusterGetSettingsRequest = {
        [<JsonPropertyName("flat_settings")>]
        FlatSettings: bool option
        [<JsonPropertyName("include_defaults")>]
        IncludeDefaults: bool option
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
    } with
        static member ToRequest(request: ClusterGetSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_cluster/settings"
                let queryParams =
                    [
                        request.FlatSettings |> Option.map (fun v -> "flat_settings", string v)
                        request.IncludeDefaults |> Option.map (fun v -> "include_defaults", string v)
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

    module ClusterGetSettingsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ClusterGetSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            ClusterGetSettingsRequest.ToRequest request

    type ClusterGetSettingsRequestBuilder() =
        member _.Yield(_: unit) : ClusterGetSettingsRequest =
            {
                ClusterGetSettingsRequest.FlatSettings = Option.None
                ClusterGetSettingsRequest.IncludeDefaults = Option.None
                ClusterGetSettingsRequest.MasterTimeout = Option.None
                ClusterGetSettingsRequest.Timeout = Option.None
            } : ClusterGetSettingsRequest

        [<CustomOperation("flat_settings")>]
        member _.FlatSettings(state: ClusterGetSettingsRequest, value: bool) =
            { state with ClusterGetSettingsRequest.FlatSettings = Option.Some value } : ClusterGetSettingsRequest

        [<CustomOperation("include_defaults")>]
        member _.IncludeDefaults(state: ClusterGetSettingsRequest, value: bool) =
            { state with ClusterGetSettingsRequest.IncludeDefaults = Option.Some value } : ClusterGetSettingsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: ClusterGetSettingsRequest, value: Duration) =
            { state with ClusterGetSettingsRequest.MasterTimeout = Option.Some value } : ClusterGetSettingsRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: ClusterGetSettingsRequest, value: Duration) =
            { state with ClusterGetSettingsRequest.Timeout = Option.Some value } : ClusterGetSettingsRequest

    let clusterGetSettingsRequest = ClusterGetSettingsRequestBuilder()

    type ClusterGetSettingsResponse = {
        [<JsonPropertyName("persistent")>]
        Persistent: Map<string, obj>
        [<JsonPropertyName("transient")>]
        Transient: Map<string, obj>
        [<JsonPropertyName("defaults")>]
        Defaults: Map<string, obj> option
    }

    type ClusterPutSettingsRequest = {
        [<JsonPropertyName("flat_settings")>]
        FlatSettings: bool option
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
        [<JsonPropertyName("persistent")>]
        Persistent: Map<string, obj> option
        [<JsonPropertyName("transient")>]
        Transient: Map<string, obj> option
    } with
        static member ToRequest(request: ClusterPutSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_cluster/settings"
                let queryParams =
                    [
                        request.FlatSettings |> Option.map (fun v -> "flat_settings", string v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
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

    module ClusterPutSettingsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ClusterPutSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            ClusterPutSettingsRequest.ToRequest request

    type ClusterPutSettingsRequestBuilder() =
        member _.Yield(_: unit) : ClusterPutSettingsRequest =
            {
                ClusterPutSettingsRequest.FlatSettings = Option.None
                ClusterPutSettingsRequest.MasterTimeout = Option.None
                ClusterPutSettingsRequest.Timeout = Option.None
                ClusterPutSettingsRequest.Persistent = Option.None
                ClusterPutSettingsRequest.Transient = Option.None
            } : ClusterPutSettingsRequest

        [<CustomOperation("flat_settings")>]
        member _.FlatSettings(state: ClusterPutSettingsRequest, value: bool) =
            { state with ClusterPutSettingsRequest.FlatSettings = Option.Some value } : ClusterPutSettingsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: ClusterPutSettingsRequest, value: Duration) =
            { state with ClusterPutSettingsRequest.MasterTimeout = Option.Some value } : ClusterPutSettingsRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: ClusterPutSettingsRequest, value: Duration) =
            { state with ClusterPutSettingsRequest.Timeout = Option.Some value } : ClusterPutSettingsRequest

        [<CustomOperation("persistent")>]
        member _.Persistent(state: ClusterPutSettingsRequest, value: Map<string, obj>) =
            { state with ClusterPutSettingsRequest.Persistent = Option.Some value } : ClusterPutSettingsRequest

        [<CustomOperation("transient")>]
        member _.Transient(state: ClusterPutSettingsRequest, value: Map<string, obj>) =
            { state with ClusterPutSettingsRequest.Transient = Option.Some value } : ClusterPutSettingsRequest

    let clusterPutSettingsRequest = ClusterPutSettingsRequestBuilder()

    type ClusterPutSettingsResponse = {
        [<JsonPropertyName("acknowledged")>]
        Acknowledged: bool
        [<JsonPropertyName("persistent")>]
        Persistent: Map<string, obj>
        [<JsonPropertyName("transient")>]
        Transient: Map<string, obj>
    }

    type ClusterHealthRequest = {
        [<JsonPropertyName("index")>]
        Index: Indices
        [<JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: ExpandWildcards option
        [<JsonPropertyName("level")>]
        Level: Level option
        [<JsonPropertyName("local")>]
        Local: bool option
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
        [<JsonPropertyName("wait_for_active_shards")>]
        WaitForActiveShards: WaitForActiveShards option
        [<JsonPropertyName("wait_for_events")>]
        WaitForEvents: WaitForEvents option
        [<JsonPropertyName("wait_for_nodes")>]
        WaitForNodes: HealthWaitForNodes option
        [<JsonPropertyName("wait_for_no_initializing_shards")>]
        WaitForNoInitializingShards: bool option
        [<JsonPropertyName("wait_for_no_relocating_shards")>]
        WaitForNoRelocatingShards: bool option
        [<JsonPropertyName("wait_for_status")>]
        WaitForStatus: HealthStatus option
    } with
        static member ToRequest(request: ClusterHealthRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cluster/health/{request.Index}"
                let queryParams =
                    [
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", string v)
                        request.Level |> Option.map (fun v -> "level", string v)
                        request.Local |> Option.map (fun v -> "local", string v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                        request.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", string v)
                        request.WaitForEvents |> Option.map (fun v -> "wait_for_events", string v)
                        request.WaitForNodes |> Option.map (fun v -> "wait_for_nodes", string v)
                        request.WaitForNoInitializingShards |> Option.map (fun v -> "wait_for_no_initializing_shards", string v)
                        request.WaitForNoRelocatingShards |> Option.map (fun v -> "wait_for_no_relocating_shards", string v)
                        request.WaitForStatus |> Option.map (fun v -> "wait_for_status", string v)
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

    module ClusterHealthRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ClusterHealthRequest) : Result<Fes.Http.RequestMsg, exn> =
            ClusterHealthRequest.ToRequest request

    type ClusterHealthRequestBuilder() =
        member _.Yield(_: unit) : ClusterHealthRequest =
            {
                ClusterHealthRequest.Index = Unchecked.defaultof<Indices>
                ClusterHealthRequest.ExpandWildcards = Option.None
                ClusterHealthRequest.Level = Option.None
                ClusterHealthRequest.Local = Option.None
                ClusterHealthRequest.MasterTimeout = Option.None
                ClusterHealthRequest.Timeout = Option.None
                ClusterHealthRequest.WaitForActiveShards = Option.None
                ClusterHealthRequest.WaitForEvents = Option.None
                ClusterHealthRequest.WaitForNodes = Option.None
                ClusterHealthRequest.WaitForNoInitializingShards = Option.None
                ClusterHealthRequest.WaitForNoRelocatingShards = Option.None
                ClusterHealthRequest.WaitForStatus = Option.None
            } : ClusterHealthRequest

        [<CustomOperation("index")>]
        member _.Index(state: ClusterHealthRequest, value: Indices) =
            { state with ClusterHealthRequest.Index = value } : ClusterHealthRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: ClusterHealthRequest, value: ExpandWildcards) =
            { state with ClusterHealthRequest.ExpandWildcards = Option.Some value } : ClusterHealthRequest

        [<CustomOperation("level")>]
        member _.Level(state: ClusterHealthRequest, value: Level) =
            { state with ClusterHealthRequest.Level = Option.Some value } : ClusterHealthRequest

        [<CustomOperation("local")>]
        member _.Local(state: ClusterHealthRequest, value: bool) =
            { state with ClusterHealthRequest.Local = Option.Some value } : ClusterHealthRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: ClusterHealthRequest, value: Duration) =
            { state with ClusterHealthRequest.MasterTimeout = Option.Some value } : ClusterHealthRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: ClusterHealthRequest, value: Duration) =
            { state with ClusterHealthRequest.Timeout = Option.Some value } : ClusterHealthRequest

        [<CustomOperation("wait_for_active_shards")>]
        member _.WaitForActiveShards(state: ClusterHealthRequest, value: WaitForActiveShards) =
            { state with ClusterHealthRequest.WaitForActiveShards = Option.Some value } : ClusterHealthRequest

        [<CustomOperation("wait_for_events")>]
        member _.WaitForEvents(state: ClusterHealthRequest, value: WaitForEvents) =
            { state with ClusterHealthRequest.WaitForEvents = Option.Some value } : ClusterHealthRequest

        [<CustomOperation("wait_for_nodes")>]
        member _.WaitForNodes(state: ClusterHealthRequest, value: HealthWaitForNodes) =
            { state with ClusterHealthRequest.WaitForNodes = Option.Some value } : ClusterHealthRequest

        [<CustomOperation("wait_for_no_initializing_shards")>]
        member _.WaitForNoInitializingShards(state: ClusterHealthRequest, value: bool) =
            { state with ClusterHealthRequest.WaitForNoInitializingShards = Option.Some value } : ClusterHealthRequest

        [<CustomOperation("wait_for_no_relocating_shards")>]
        member _.WaitForNoRelocatingShards(state: ClusterHealthRequest, value: bool) =
            { state with ClusterHealthRequest.WaitForNoRelocatingShards = Option.Some value } : ClusterHealthRequest

        [<CustomOperation("wait_for_status")>]
        member _.WaitForStatus(state: ClusterHealthRequest, value: HealthStatus) =
            { state with ClusterHealthRequest.WaitForStatus = Option.Some value } : ClusterHealthRequest

    let clusterHealthRequest = ClusterHealthRequestBuilder()

    type ClusterInfoRequest = {
        [<JsonPropertyName("target")>]
        Target: ClusterInfoTargets
    } with
        static member ToRequest(request: ClusterInfoRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_info/{request.Target}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module ClusterInfoRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ClusterInfoRequest) : Result<Fes.Http.RequestMsg, exn> =
            ClusterInfoRequest.ToRequest request

    type ClusterInfoRequestBuilder() =
        member _.Yield(_: unit) : ClusterInfoRequest =
            {
                ClusterInfoRequest.Target = Unchecked.defaultof<ClusterInfoTargets>
            } : ClusterInfoRequest

        [<CustomOperation("target")>]
        member _.Target(state: ClusterInfoRequest, value: ClusterInfoTargets) =
            { state with ClusterInfoRequest.Target = value } : ClusterInfoRequest

    let clusterInfoRequest = ClusterInfoRequestBuilder()

    type ClusterInfoResponse = {
        [<JsonPropertyName("cluster_name")>]
        ClusterName: Name
        [<JsonPropertyName("http")>]
        Http: TypesHttp option
        [<JsonPropertyName("ingest")>]
        Ingest: TypesIngest option
        [<JsonPropertyName("thread_pool")>]
        ThreadPool: Map<string, TypesThreadCount> option
        [<JsonPropertyName("script")>]
        Script: TypesScripting option
    }

    type ClusterPendingTasksRequest = {
        [<JsonPropertyName("local")>]
        Local: bool option
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: ClusterPendingTasksRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_cluster/pending_tasks"
                let queryParams =
                    [
                        request.Local |> Option.map (fun v -> "local", string v)
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

    module ClusterPendingTasksRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ClusterPendingTasksRequest) : Result<Fes.Http.RequestMsg, exn> =
            ClusterPendingTasksRequest.ToRequest request

    type ClusterPendingTasksRequestBuilder() =
        member _.Yield(_: unit) : ClusterPendingTasksRequest =
            {
                ClusterPendingTasksRequest.Local = Option.None
                ClusterPendingTasksRequest.MasterTimeout = Option.None
            } : ClusterPendingTasksRequest

        [<CustomOperation("local")>]
        member _.Local(state: ClusterPendingTasksRequest, value: bool) =
            { state with ClusterPendingTasksRequest.Local = Option.Some value } : ClusterPendingTasksRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: ClusterPendingTasksRequest, value: Duration) =
            { state with ClusterPendingTasksRequest.MasterTimeout = Option.Some value } : ClusterPendingTasksRequest

    let clusterPendingTasksRequest = ClusterPendingTasksRequestBuilder()

    type ClusterPendingTasksResponse = {
        [<JsonPropertyName("tasks")>]
        Tasks: PendingTasksPendingTask array
    }

    type ClusterRemoteInfoRequest = unit

    let clusterRemoteInfoRequest = ()

    type ClusterRerouteRequest = {
        [<JsonPropertyName("dry_run")>]
        DryRun: bool option
        [<JsonPropertyName("explain")>]
        Explain: bool option
        [<JsonPropertyName("metric")>]
        Metric: System.Text.Json.JsonElement option
        [<JsonPropertyName("retry_failed")>]
        RetryFailed: bool option
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
        [<JsonPropertyName("commands")>]
        Commands: RerouteCommand array option
    } with
        static member ToRequest(request: ClusterRerouteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_cluster/reroute"
                let queryParams =
                    [
                        request.DryRun |> Option.map (fun v -> "dry_run", string v)
                        request.Explain |> Option.map (fun v -> "explain", string v)
                        request.Metric |> Option.map (fun v -> "metric", string v)
                        request.RetryFailed |> Option.map (fun v -> "retry_failed", string v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
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

    module ClusterRerouteRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ClusterRerouteRequest) : Result<Fes.Http.RequestMsg, exn> =
            ClusterRerouteRequest.ToRequest request

    type ClusterRerouteRequestBuilder() =
        member _.Yield(_: unit) : ClusterRerouteRequest =
            {
                ClusterRerouteRequest.DryRun = Option.None
                ClusterRerouteRequest.Explain = Option.None
                ClusterRerouteRequest.Metric = Option.None
                ClusterRerouteRequest.RetryFailed = Option.None
                ClusterRerouteRequest.MasterTimeout = Option.None
                ClusterRerouteRequest.Timeout = Option.None
                ClusterRerouteRequest.Commands = Option.None
            } : ClusterRerouteRequest

        [<CustomOperation("dry_run")>]
        member _.DryRun(state: ClusterRerouteRequest, value: bool) =
            { state with ClusterRerouteRequest.DryRun = Option.Some value } : ClusterRerouteRequest

        [<CustomOperation("explain")>]
        member _.Explain(state: ClusterRerouteRequest, value: bool) =
            { state with ClusterRerouteRequest.Explain = Option.Some value } : ClusterRerouteRequest

        [<CustomOperation("metric")>]
        member _.Metric(state: ClusterRerouteRequest, value: System.Text.Json.JsonElement) =
            { state with ClusterRerouteRequest.Metric = Option.Some value } : ClusterRerouteRequest

        [<CustomOperation("retry_failed")>]
        member _.RetryFailed(state: ClusterRerouteRequest, value: bool) =
            { state with ClusterRerouteRequest.RetryFailed = Option.Some value } : ClusterRerouteRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: ClusterRerouteRequest, value: Duration) =
            { state with ClusterRerouteRequest.MasterTimeout = Option.Some value } : ClusterRerouteRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: ClusterRerouteRequest, value: Duration) =
            { state with ClusterRerouteRequest.Timeout = Option.Some value } : ClusterRerouteRequest

        [<CustomOperation("commands")>]
        member _.Commands(state: ClusterRerouteRequest, value: RerouteCommand array) =
            { state with ClusterRerouteRequest.Commands = Option.Some value } : ClusterRerouteRequest

    let clusterRerouteRequest = ClusterRerouteRequestBuilder()

    type ClusterRerouteResponse = {
        [<JsonPropertyName("acknowledged")>]
        Acknowledged: bool
        [<JsonPropertyName("explanations")>]
        Explanations: RerouteRerouteExplanation array option
        [<JsonPropertyName("state")>]
        State: obj option
    }

    type ClusterStateRequest = {
        [<JsonPropertyName("metric")>]
        Metric: StateClusterStateMetrics
        [<JsonPropertyName("index")>]
        Index: Indices
        [<JsonPropertyName("allow_no_indices")>]
        AllowNoIndices: bool option
        [<JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: ExpandWildcards option
        [<JsonPropertyName("flat_settings")>]
        FlatSettings: bool option
        [<JsonPropertyName("ignore_unavailable")>]
        IgnoreUnavailable: bool option
        [<JsonPropertyName("local")>]
        Local: bool option
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
        [<JsonPropertyName("wait_for_metadata_version")>]
        WaitForMetadataVersion: VersionNumber option
        [<JsonPropertyName("wait_for_timeout")>]
        WaitForTimeout: Duration option
    } with
        static member ToRequest(request: ClusterStateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cluster/state/{request.Metric}/{request.Index}"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", string v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", string v)
                        request.FlatSettings |> Option.map (fun v -> "flat_settings", string v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", string v)
                        request.Local |> Option.map (fun v -> "local", string v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                        request.WaitForMetadataVersion |> Option.map (fun v -> "wait_for_metadata_version", string v)
                        request.WaitForTimeout |> Option.map (fun v -> "wait_for_timeout", string v)
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

    module ClusterStateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ClusterStateRequest) : Result<Fes.Http.RequestMsg, exn> =
            ClusterStateRequest.ToRequest request

    type ClusterStateRequestBuilder() =
        member _.Yield(_: unit) : ClusterStateRequest =
            {
                ClusterStateRequest.Metric = Unchecked.defaultof<StateClusterStateMetrics>
                ClusterStateRequest.Index = Unchecked.defaultof<Indices>
                ClusterStateRequest.AllowNoIndices = Option.None
                ClusterStateRequest.ExpandWildcards = Option.None
                ClusterStateRequest.FlatSettings = Option.None
                ClusterStateRequest.IgnoreUnavailable = Option.None
                ClusterStateRequest.Local = Option.None
                ClusterStateRequest.MasterTimeout = Option.None
                ClusterStateRequest.WaitForMetadataVersion = Option.None
                ClusterStateRequest.WaitForTimeout = Option.None
            } : ClusterStateRequest

        [<CustomOperation("metric")>]
        member _.Metric(state: ClusterStateRequest, value: StateClusterStateMetrics) =
            { state with ClusterStateRequest.Metric = value } : ClusterStateRequest

        [<CustomOperation("index")>]
        member _.Index(state: ClusterStateRequest, value: Indices) =
            { state with ClusterStateRequest.Index = value } : ClusterStateRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: ClusterStateRequest, value: bool) =
            { state with ClusterStateRequest.AllowNoIndices = Option.Some value } : ClusterStateRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: ClusterStateRequest, value: ExpandWildcards) =
            { state with ClusterStateRequest.ExpandWildcards = Option.Some value } : ClusterStateRequest

        [<CustomOperation("flat_settings")>]
        member _.FlatSettings(state: ClusterStateRequest, value: bool) =
            { state with ClusterStateRequest.FlatSettings = Option.Some value } : ClusterStateRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: ClusterStateRequest, value: bool) =
            { state with ClusterStateRequest.IgnoreUnavailable = Option.Some value } : ClusterStateRequest

        [<CustomOperation("local")>]
        member _.Local(state: ClusterStateRequest, value: bool) =
            { state with ClusterStateRequest.Local = Option.Some value } : ClusterStateRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: ClusterStateRequest, value: Duration) =
            { state with ClusterStateRequest.MasterTimeout = Option.Some value } : ClusterStateRequest

        [<CustomOperation("wait_for_metadata_version")>]
        member _.WaitForMetadataVersion(state: ClusterStateRequest, value: VersionNumber) =
            { state with ClusterStateRequest.WaitForMetadataVersion = Option.Some value } : ClusterStateRequest

        [<CustomOperation("wait_for_timeout")>]
        member _.WaitForTimeout(state: ClusterStateRequest, value: Duration) =
            { state with ClusterStateRequest.WaitForTimeout = Option.Some value } : ClusterStateRequest

    let clusterStateRequest = ClusterStateRequestBuilder()

    type ClusterStatsRequest = {
        [<JsonPropertyName("node_id")>]
        NodeId: NodeIds
        [<JsonPropertyName("include_remotes")>]
        IncludeRemotes: bool option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
    } with
        static member ToRequest(request: ClusterStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cluster/stats/nodes/{request.NodeId}"
                let queryParams =
                    [
                        request.IncludeRemotes |> Option.map (fun v -> "include_remotes", string v)
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

    module ClusterStatsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ClusterStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            ClusterStatsRequest.ToRequest request

    type ClusterStatsRequestBuilder() =
        member _.Yield(_: unit) : ClusterStatsRequest =
            {
                ClusterStatsRequest.NodeId = Unchecked.defaultof<NodeIds>
                ClusterStatsRequest.IncludeRemotes = Option.None
                ClusterStatsRequest.Timeout = Option.None
            } : ClusterStatsRequest

        [<CustomOperation("node_id")>]
        member _.NodeId(state: ClusterStatsRequest, value: NodeIds) =
            { state with ClusterStatsRequest.NodeId = value } : ClusterStatsRequest

        [<CustomOperation("include_remotes")>]
        member _.IncludeRemotes(state: ClusterStatsRequest, value: bool) =
            { state with ClusterStatsRequest.IncludeRemotes = Option.Some value } : ClusterStatsRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: ClusterStatsRequest, value: Duration) =
            { state with ClusterStatsRequest.Timeout = Option.Some value } : ClusterStatsRequest

    let clusterStatsRequest = ClusterStatsRequestBuilder()

    type PingRequest = unit

    let pingRequest = ()

    type NodesClearRepositoriesMeteringArchiveRequest = {
        [<JsonPropertyName("node_id")>]
        NodeId: NodeIds
        [<JsonPropertyName("max_archive_version")>]
        MaxArchiveVersion: float
    } with
        static member ToRequest(request: NodesClearRepositoriesMeteringArchiveRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_nodes/{request.NodeId}/_repositories_metering/{request.MaxArchiveVersion}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module NodesClearRepositoriesMeteringArchiveRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: NodesClearRepositoriesMeteringArchiveRequest) : Result<Fes.Http.RequestMsg, exn> =
            NodesClearRepositoriesMeteringArchiveRequest.ToRequest request

    type NodesClearRepositoriesMeteringArchiveRequestBuilder() =
        member _.Yield(_: unit) : NodesClearRepositoriesMeteringArchiveRequest =
            {
                NodesClearRepositoriesMeteringArchiveRequest.NodeId = Unchecked.defaultof<NodeIds>
                NodesClearRepositoriesMeteringArchiveRequest.MaxArchiveVersion = 0.0
            } : NodesClearRepositoriesMeteringArchiveRequest

        [<CustomOperation("node_id")>]
        member _.NodeId(state: NodesClearRepositoriesMeteringArchiveRequest, value: NodeIds) =
            { state with NodesClearRepositoriesMeteringArchiveRequest.NodeId = value } : NodesClearRepositoriesMeteringArchiveRequest

        [<CustomOperation("max_archive_version")>]
        member _.MaxArchiveVersion(state: NodesClearRepositoriesMeteringArchiveRequest, value: float) =
            { state with NodesClearRepositoriesMeteringArchiveRequest.MaxArchiveVersion = value } : NodesClearRepositoriesMeteringArchiveRequest

    let nodesClearRepositoriesMeteringArchiveRequest = NodesClearRepositoriesMeteringArchiveRequestBuilder()

    type NodesClearRepositoriesMeteringArchiveResponse = ClearRepositoriesMeteringArchiveResponseBase

    type NodesGetRepositoriesMeteringInfoRequest = {
        [<JsonPropertyName("node_id")>]
        NodeId: NodeIds
    } with
        static member ToRequest(request: NodesGetRepositoriesMeteringInfoRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_nodes/{request.NodeId}/_repositories_metering"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module NodesGetRepositoriesMeteringInfoRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: NodesGetRepositoriesMeteringInfoRequest) : Result<Fes.Http.RequestMsg, exn> =
            NodesGetRepositoriesMeteringInfoRequest.ToRequest request

    type NodesGetRepositoriesMeteringInfoRequestBuilder() =
        member _.Yield(_: unit) : NodesGetRepositoriesMeteringInfoRequest =
            {
                NodesGetRepositoriesMeteringInfoRequest.NodeId = Unchecked.defaultof<NodeIds>
            } : NodesGetRepositoriesMeteringInfoRequest

        [<CustomOperation("node_id")>]
        member _.NodeId(state: NodesGetRepositoriesMeteringInfoRequest, value: NodeIds) =
            { state with NodesGetRepositoriesMeteringInfoRequest.NodeId = value } : NodesGetRepositoriesMeteringInfoRequest

    let nodesGetRepositoriesMeteringInfoRequest = NodesGetRepositoriesMeteringInfoRequestBuilder()

    type NodesGetRepositoriesMeteringInfoResponse = GetRepositoriesMeteringInfoResponseBase

    type NodesHotThreadsRequest = {
        [<JsonPropertyName("node_id")>]
        NodeId: NodeIds
        [<JsonPropertyName("ignore_idle_threads")>]
        IgnoreIdleThreads: bool option
        [<JsonPropertyName("interval")>]
        Interval: Duration option
        [<JsonPropertyName("snapshots")>]
        Snapshots: float option
        [<JsonPropertyName("threads")>]
        Threads: float option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
        [<JsonPropertyName("type")>]
        Type: ThreadType option
        [<JsonPropertyName("sort")>]
        Sort: ThreadType option
    } with
        static member ToRequest(request: NodesHotThreadsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_nodes/{request.NodeId}/hot_threads"
                let queryParams =
                    [
                        request.IgnoreIdleThreads |> Option.map (fun v -> "ignore_idle_threads", string v)
                        request.Interval |> Option.map (fun v -> "interval", string v)
                        request.Snapshots |> Option.map (fun v -> "snapshots", string v)
                        request.Threads |> Option.map (fun v -> "threads", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                        request.Type |> Option.map (fun v -> "type", string v)
                        request.Sort |> Option.map (fun v -> "sort", string v)
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

    module NodesHotThreadsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: NodesHotThreadsRequest) : Result<Fes.Http.RequestMsg, exn> =
            NodesHotThreadsRequest.ToRequest request

    type NodesHotThreadsRequestBuilder() =
        member _.Yield(_: unit) : NodesHotThreadsRequest =
            {
                NodesHotThreadsRequest.NodeId = Unchecked.defaultof<NodeIds>
                NodesHotThreadsRequest.IgnoreIdleThreads = Option.None
                NodesHotThreadsRequest.Interval = Option.None
                NodesHotThreadsRequest.Snapshots = Option.None
                NodesHotThreadsRequest.Threads = Option.None
                NodesHotThreadsRequest.Timeout = Option.None
                NodesHotThreadsRequest.Type = Option.None
                NodesHotThreadsRequest.Sort = Option.None
            } : NodesHotThreadsRequest

        [<CustomOperation("node_id")>]
        member _.NodeId(state: NodesHotThreadsRequest, value: NodeIds) =
            { state with NodesHotThreadsRequest.NodeId = value } : NodesHotThreadsRequest

        [<CustomOperation("ignore_idle_threads")>]
        member _.IgnoreIdleThreads(state: NodesHotThreadsRequest, value: bool) =
            { state with NodesHotThreadsRequest.IgnoreIdleThreads = Option.Some value } : NodesHotThreadsRequest

        [<CustomOperation("interval")>]
        member _.Interval(state: NodesHotThreadsRequest, value: Duration) =
            { state with NodesHotThreadsRequest.Interval = Option.Some value } : NodesHotThreadsRequest

        [<CustomOperation("snapshots")>]
        member _.Snapshots(state: NodesHotThreadsRequest, value: float) =
            { state with NodesHotThreadsRequest.Snapshots = Option.Some value } : NodesHotThreadsRequest

        [<CustomOperation("threads")>]
        member _.Threads(state: NodesHotThreadsRequest, value: float) =
            { state with NodesHotThreadsRequest.Threads = Option.Some value } : NodesHotThreadsRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: NodesHotThreadsRequest, value: Duration) =
            { state with NodesHotThreadsRequest.Timeout = Option.Some value } : NodesHotThreadsRequest

        [<CustomOperation("type")>]
        member _.Type(state: NodesHotThreadsRequest, value: ThreadType) =
            { state with NodesHotThreadsRequest.Type = Option.Some value } : NodesHotThreadsRequest

        [<CustomOperation("sort")>]
        member _.Sort(state: NodesHotThreadsRequest, value: ThreadType) =
            { state with NodesHotThreadsRequest.Sort = Option.Some value } : NodesHotThreadsRequest

    let nodesHotThreadsRequest = NodesHotThreadsRequestBuilder()

    type NodesInfoRequest = {
        [<JsonPropertyName("node_id")>]
        NodeId: NodeIds
        [<JsonPropertyName("metric")>]
        Metric: InfoNodesInfoMetrics
        [<JsonPropertyName("flat_settings")>]
        FlatSettings: bool option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
    } with
        static member ToRequest(request: NodesInfoRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_nodes/{request.NodeId}/{request.Metric}"
                let queryParams =
                    [
                        request.FlatSettings |> Option.map (fun v -> "flat_settings", string v)
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

    module NodesInfoRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: NodesInfoRequest) : Result<Fes.Http.RequestMsg, exn> =
            NodesInfoRequest.ToRequest request

    type NodesInfoRequestBuilder() =
        member _.Yield(_: unit) : NodesInfoRequest =
            {
                NodesInfoRequest.NodeId = Unchecked.defaultof<NodeIds>
                NodesInfoRequest.Metric = Unchecked.defaultof<InfoNodesInfoMetrics>
                NodesInfoRequest.FlatSettings = Option.None
                NodesInfoRequest.Timeout = Option.None
            } : NodesInfoRequest

        [<CustomOperation("node_id")>]
        member _.NodeId(state: NodesInfoRequest, value: NodeIds) =
            { state with NodesInfoRequest.NodeId = value } : NodesInfoRequest

        [<CustomOperation("metric")>]
        member _.Metric(state: NodesInfoRequest, value: InfoNodesInfoMetrics) =
            { state with NodesInfoRequest.Metric = value } : NodesInfoRequest

        [<CustomOperation("flat_settings")>]
        member _.FlatSettings(state: NodesInfoRequest, value: bool) =
            { state with NodesInfoRequest.FlatSettings = Option.Some value } : NodesInfoRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: NodesInfoRequest, value: Duration) =
            { state with NodesInfoRequest.Timeout = Option.Some value } : NodesInfoRequest

    let nodesInfoRequest = NodesInfoRequestBuilder()

    type NodesReloadSecureSettingsRequest = {
        [<JsonPropertyName("node_id")>]
        NodeId: NodeIds
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
        [<JsonPropertyName("secure_settings_password")>]
        SecureSettingsPassword: Password option
    } with
        static member ToRequest(request: NodesReloadSecureSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_nodes/{request.NodeId}/reload_secure_settings"
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

    module NodesReloadSecureSettingsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: NodesReloadSecureSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            NodesReloadSecureSettingsRequest.ToRequest request

    type NodesReloadSecureSettingsRequestBuilder() =
        member _.Yield(_: unit) : NodesReloadSecureSettingsRequest =
            {
                NodesReloadSecureSettingsRequest.NodeId = Unchecked.defaultof<NodeIds>
                NodesReloadSecureSettingsRequest.Timeout = Option.None
                NodesReloadSecureSettingsRequest.SecureSettingsPassword = Option.None
            } : NodesReloadSecureSettingsRequest

        [<CustomOperation("node_id")>]
        member _.NodeId(state: NodesReloadSecureSettingsRequest, value: NodeIds) =
            { state with NodesReloadSecureSettingsRequest.NodeId = value } : NodesReloadSecureSettingsRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: NodesReloadSecureSettingsRequest, value: Duration) =
            { state with NodesReloadSecureSettingsRequest.Timeout = Option.Some value } : NodesReloadSecureSettingsRequest

        [<CustomOperation("secure_settings_password")>]
        member _.SecureSettingsPassword(state: NodesReloadSecureSettingsRequest, value: Password) =
            { state with NodesReloadSecureSettingsRequest.SecureSettingsPassword = Option.Some value } : NodesReloadSecureSettingsRequest

    let nodesReloadSecureSettingsRequest = NodesReloadSecureSettingsRequestBuilder()

    type NodesStatsRequest = {
        [<JsonPropertyName("node_id")>]
        NodeId: NodeIds
        [<JsonPropertyName("metric")>]
        Metric: StatsNodeStatsMetrics
        [<JsonPropertyName("index_metric")>]
        IndexMetric: CommonStatsFlags
        [<JsonPropertyName("completion_fields")>]
        CompletionFields: Fields option
        [<JsonPropertyName("fielddata_fields")>]
        FielddataFields: Fields option
        [<JsonPropertyName("fields")>]
        Fields: Fields option
        [<JsonPropertyName("groups")>]
        Groups: bool option
        [<JsonPropertyName("include_segment_file_sizes")>]
        IncludeSegmentFileSizes: bool option
        [<JsonPropertyName("level")>]
        Level: NodeStatsLevel option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
        [<JsonPropertyName("types")>]
        Types: string array option
        [<JsonPropertyName("include_unloaded_segments")>]
        IncludeUnloadedSegments: bool option
    } with
        static member ToRequest(request: NodesStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_nodes/{request.NodeId}/stats/{request.Metric}/{request.IndexMetric}"
                let queryParams =
                    [
                        request.CompletionFields |> Option.map (fun v -> "completion_fields", string v)
                        request.FielddataFields |> Option.map (fun v -> "fielddata_fields", string v)
                        request.Fields |> Option.map (fun v -> "fields", string v)
                        request.Groups |> Option.map (fun v -> "groups", string v)
                        request.IncludeSegmentFileSizes |> Option.map (fun v -> "include_segment_file_sizes", string v)
                        request.Level |> Option.map (fun v -> "level", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                        request.Types |> Option.map (fun v -> "types", string v)
                        request.IncludeUnloadedSegments |> Option.map (fun v -> "include_unloaded_segments", string v)
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

    module NodesStatsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: NodesStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            NodesStatsRequest.ToRequest request

    type NodesStatsRequestBuilder() =
        member _.Yield(_: unit) : NodesStatsRequest =
            {
                NodesStatsRequest.NodeId = Unchecked.defaultof<NodeIds>
                NodesStatsRequest.Metric = Unchecked.defaultof<StatsNodeStatsMetrics>
                NodesStatsRequest.IndexMetric = Unchecked.defaultof<CommonStatsFlags>
                NodesStatsRequest.CompletionFields = Option.None
                NodesStatsRequest.FielddataFields = Option.None
                NodesStatsRequest.Fields = Option.None
                NodesStatsRequest.Groups = Option.None
                NodesStatsRequest.IncludeSegmentFileSizes = Option.None
                NodesStatsRequest.Level = Option.None
                NodesStatsRequest.Timeout = Option.None
                NodesStatsRequest.Types = Option.None
                NodesStatsRequest.IncludeUnloadedSegments = Option.None
            } : NodesStatsRequest

        [<CustomOperation("node_id")>]
        member _.NodeId(state: NodesStatsRequest, value: NodeIds) =
            { state with NodesStatsRequest.NodeId = value } : NodesStatsRequest

        [<CustomOperation("metric")>]
        member _.Metric(state: NodesStatsRequest, value: StatsNodeStatsMetrics) =
            { state with NodesStatsRequest.Metric = value } : NodesStatsRequest

        [<CustomOperation("index_metric")>]
        member _.IndexMetric(state: NodesStatsRequest, value: CommonStatsFlags) =
            { state with NodesStatsRequest.IndexMetric = value } : NodesStatsRequest

        [<CustomOperation("completion_fields")>]
        member _.CompletionFields(state: NodesStatsRequest, value: Fields) =
            { state with NodesStatsRequest.CompletionFields = Option.Some value } : NodesStatsRequest

        [<CustomOperation("fielddata_fields")>]
        member _.FielddataFields(state: NodesStatsRequest, value: Fields) =
            { state with NodesStatsRequest.FielddataFields = Option.Some value } : NodesStatsRequest

        [<CustomOperation("fields")>]
        member _.Fields(state: NodesStatsRequest, value: Fields) =
            { state with NodesStatsRequest.Fields = Option.Some value } : NodesStatsRequest

        [<CustomOperation("groups")>]
        member _.Groups(state: NodesStatsRequest, value: bool) =
            { state with NodesStatsRequest.Groups = Option.Some value } : NodesStatsRequest

        [<CustomOperation("include_segment_file_sizes")>]
        member _.IncludeSegmentFileSizes(state: NodesStatsRequest, value: bool) =
            { state with NodesStatsRequest.IncludeSegmentFileSizes = Option.Some value } : NodesStatsRequest

        [<CustomOperation("level")>]
        member _.Level(state: NodesStatsRequest, value: NodeStatsLevel) =
            { state with NodesStatsRequest.Level = Option.Some value } : NodesStatsRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: NodesStatsRequest, value: Duration) =
            { state with NodesStatsRequest.Timeout = Option.Some value } : NodesStatsRequest

        [<CustomOperation("types")>]
        member _.Types(state: NodesStatsRequest, value: string array) =
            { state with NodesStatsRequest.Types = Option.Some value } : NodesStatsRequest

        [<CustomOperation("include_unloaded_segments")>]
        member _.IncludeUnloadedSegments(state: NodesStatsRequest, value: bool) =
            { state with NodesStatsRequest.IncludeUnloadedSegments = Option.Some value } : NodesStatsRequest

    let nodesStatsRequest = NodesStatsRequestBuilder()

    type NodesUsageRequest = {
        [<JsonPropertyName("node_id")>]
        NodeId: NodeIds
        [<JsonPropertyName("metric")>]
        Metric: UsageNodesUsageMetrics
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
    } with
        static member ToRequest(request: NodesUsageRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_nodes/{request.NodeId}/usage/{request.Metric}"
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

    module NodesUsageRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: NodesUsageRequest) : Result<Fes.Http.RequestMsg, exn> =
            NodesUsageRequest.ToRequest request

    type NodesUsageRequestBuilder() =
        member _.Yield(_: unit) : NodesUsageRequest =
            {
                NodesUsageRequest.NodeId = Unchecked.defaultof<NodeIds>
                NodesUsageRequest.Metric = Unchecked.defaultof<UsageNodesUsageMetrics>
                NodesUsageRequest.Timeout = Option.None
            } : NodesUsageRequest

        [<CustomOperation("node_id")>]
        member _.NodeId(state: NodesUsageRequest, value: NodeIds) =
            { state with NodesUsageRequest.NodeId = value } : NodesUsageRequest

        [<CustomOperation("metric")>]
        member _.Metric(state: NodesUsageRequest, value: UsageNodesUsageMetrics) =
            { state with NodesUsageRequest.Metric = value } : NodesUsageRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: NodesUsageRequest, value: Duration) =
            { state with NodesUsageRequest.Timeout = Option.Some value } : NodesUsageRequest

    let nodesUsageRequest = NodesUsageRequestBuilder()


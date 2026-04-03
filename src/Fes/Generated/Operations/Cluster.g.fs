// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module ClusterOperations =

    type ClusterAllocationExplainRequest = {
        Index: Types.IndexName option
        Shard: Types.Integer option
        Primary: bool option
        CurrentNode: Types.NodeId option
        IncludeDiskInfo: bool option
        IncludeYesDecisions: bool option
        MasterTimeout: Types.Duration option
        Index: Types.IndexName option
        Shard: Types.Integer option
        Primary: bool option
        CurrentNode: Types.NodeId option
    }

        with
        static member ToRequest(req: ClusterAllocationExplainRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cluster/allocation/explain"
                let queryParams =
                    [
                        req.Index |> Option.map (fun v -> "index", Fes.Http.toQueryValue v)
                        req.Shard |> Option.map (fun v -> "shard", Fes.Http.toQueryValue v)
                        req.Primary |> Option.map (fun v -> "primary", Fes.Http.toQueryValue v)
                        req.CurrentNode |> Option.map (fun v -> "current_node", Fes.Http.toQueryValue v)
                        req.IncludeDiskInfo |> Option.map (fun v -> "include_disk_info", Fes.Http.toQueryValue v)
                        req.IncludeYesDecisions |> Option.map (fun v -> "include_yes_decisions", Fes.Http.toQueryValue v)
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

    type ClusterAllocationExplainResponse = System.Text.Json.JsonElement

    type ClusterAllocationExplainRequestBuilder() =
        member _.Yield(_: unit) : ClusterAllocationExplainRequest =
            {
                Index = None
                Shard = None
                Primary = None
                CurrentNode = None
                IncludeDiskInfo = None
                IncludeYesDecisions = None
                MasterTimeout = None
                Index = None
                Shard = None
                Primary = None
                CurrentNode = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: ClusterAllocationExplainRequest, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("shard")>]
        member _.Shard(state: ClusterAllocationExplainRequest, value: Types.Integer) =
            { state with Shard = Some value }

        [<CustomOperation("primary")>]
        member _.Primary(state: ClusterAllocationExplainRequest, value: bool) =
            { state with Primary = Some value }

        [<CustomOperation("currentNode")>]
        member _.CurrentNode(state: ClusterAllocationExplainRequest, value: Types.NodeId) =
            { state with CurrentNode = Some value }

        [<CustomOperation("includeDiskInfo")>]
        member _.IncludeDiskInfo(state: ClusterAllocationExplainRequest, value: bool) =
            { state with IncludeDiskInfo = Some value }

        [<CustomOperation("includeYesDecisions")>]
        member _.IncludeYesDecisions(state: ClusterAllocationExplainRequest, value: bool) =
            { state with IncludeYesDecisions = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: ClusterAllocationExplainRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: ClusterAllocationExplainRequest, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("shard")>]
        member _.Shard(state: ClusterAllocationExplainRequest, value: Types.Integer) =
            { state with Shard = Some value }

        [<CustomOperation("primary")>]
        member _.Primary(state: ClusterAllocationExplainRequest, value: bool) =
            { state with Primary = Some value }

        [<CustomOperation("currentNode")>]
        member _.CurrentNode(state: ClusterAllocationExplainRequest, value: Types.NodeId) =
            { state with CurrentNode = Some value }

    let clusterAllocationExplainRequest = ClusterAllocationExplainRequestBuilder()

    module AllocationExplain =
        let withIndex (value: Types.IndexName) (req: ClusterAllocationExplainRequest) =
            { req with Index = Some value }
        let withShard (value: Types.Integer) (req: ClusterAllocationExplainRequest) =
            { req with Shard = Some value }
        let withPrimary (value: bool) (req: ClusterAllocationExplainRequest) =
            { req with Primary = Some value }
        let withCurrentNode (value: Types.NodeId) (req: ClusterAllocationExplainRequest) =
            { req with CurrentNode = Some value }
        let withIncludeDiskInfo (value: bool) (req: ClusterAllocationExplainRequest) =
            { req with IncludeDiskInfo = Some value }
        let withIncludeYesDecisions (value: bool) (req: ClusterAllocationExplainRequest) =
            { req with IncludeYesDecisions = Some value }
        let withMasterTimeout (value: Types.Duration) (req: ClusterAllocationExplainRequest) =
            { req with MasterTimeout = Some value }
        let withIndex (value: Types.IndexName) (req: ClusterAllocationExplainRequest) =
            { req with Index = Some value }
        let withShard (value: Types.Integer) (req: ClusterAllocationExplainRequest) =
            { req with Shard = Some value }
        let withPrimary (value: bool) (req: ClusterAllocationExplainRequest) =
            { req with Primary = Some value }
        let withCurrentNode (value: Types.NodeId) (req: ClusterAllocationExplainRequest) =
            { req with CurrentNode = Some value }

    type ClusterDeleteComponentTemplateRequest = {
        Name: Types.Names
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: ClusterDeleteComponentTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_component_template/{req.Name}"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type ClusterDeleteComponentTemplateResponse = Types.AcknowledgedResponseBase

    type ClusterDeleteComponentTemplateRequestBuilder() =
        member _.Yield(_: unit) : ClusterDeleteComponentTemplateRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: ClusterDeleteComponentTemplateRequest, value: Types.Names) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: ClusterDeleteComponentTemplateRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: ClusterDeleteComponentTemplateRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let clusterDeleteComponentTemplateRequest = ClusterDeleteComponentTemplateRequestBuilder()

    module DeleteComponentTemplate =
        let withMasterTimeout (value: Types.Duration) (req: ClusterDeleteComponentTemplateRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: ClusterDeleteComponentTemplateRequest) =
            { req with Timeout = Some value }

    type ClusterDeleteVotingConfigExclusionsRequest = {
        MasterTimeout: Types.Duration option
        WaitForRemoval: bool option
    }

        with
        static member ToRequest(req: ClusterDeleteVotingConfigExclusionsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cluster/voting_config_exclusions"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.WaitForRemoval |> Option.map (fun v -> "wait_for_removal", Fes.Http.toQueryValue v)
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

    type ClusterDeleteVotingConfigExclusionsResponse = unit

    type ClusterDeleteVotingConfigExclusionsRequestBuilder() =
        member _.Yield(_: unit) : ClusterDeleteVotingConfigExclusionsRequest =
            {
                MasterTimeout = None
                WaitForRemoval = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: ClusterDeleteVotingConfigExclusionsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("waitForRemoval")>]
        member _.WaitForRemoval(state: ClusterDeleteVotingConfigExclusionsRequest, value: bool) =
            { state with WaitForRemoval = Some value }

    let clusterDeleteVotingConfigExclusionsRequest = ClusterDeleteVotingConfigExclusionsRequestBuilder()

    module DeleteVotingConfigExclusions =
        let withMasterTimeout (value: Types.Duration) (req: ClusterDeleteVotingConfigExclusionsRequest) =
            { req with MasterTimeout = Some value }
        let withWaitForRemoval (value: bool) (req: ClusterDeleteVotingConfigExclusionsRequest) =
            { req with WaitForRemoval = Some value }

    type ClusterExistsComponentTemplateRequest = {
        Name: Types.Names
        MasterTimeout: Types.Duration option
        Local: bool option
    }

        with
        static member ToRequest(req: ClusterExistsComponentTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_component_template/{req.Name}"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Head
                |> Result.Ok
            with ex -> Result.Error ex

    type ClusterExistsComponentTemplateResponse = unit

    type ClusterExistsComponentTemplateRequestBuilder() =
        member _.Yield(_: unit) : ClusterExistsComponentTemplateRequest =
            {
                Name = Unchecked.defaultof<_>
                MasterTimeout = None
                Local = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: ClusterExistsComponentTemplateRequest, value: Types.Names) =
            { state with Name = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: ClusterExistsComponentTemplateRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("local")>]
        member _.Local(state: ClusterExistsComponentTemplateRequest, value: bool) =
            { state with Local = Some value }

    let clusterExistsComponentTemplateRequest = ClusterExistsComponentTemplateRequestBuilder()

    module ExistsComponentTemplate =
        let withMasterTimeout (value: Types.Duration) (req: ClusterExistsComponentTemplateRequest) =
            { req with MasterTimeout = Some value }
        let withLocal (value: bool) (req: ClusterExistsComponentTemplateRequest) =
            { req with Local = Some value }

    type ClusterGetComponentTemplateRequest = {
        Name: Types.Name
        FlatSettings: bool option
        SettingsFilter: System.Text.Json.JsonElement option
        IncludeDefaults: bool option
        Local: bool option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: ClusterGetComponentTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_component_template/{req.Name}"
                let queryParams =
                    [
                        req.FlatSettings |> Option.map (fun v -> "flat_settings", Fes.Http.toQueryValue v)
                        req.SettingsFilter |> Option.map (fun v -> "settings_filter", Fes.Http.toQueryValue v)
                        req.IncludeDefaults |> Option.map (fun v -> "include_defaults", Fes.Http.toQueryValue v)
                        req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
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

    type ClusterGetComponentTemplateResponse = System.Text.Json.JsonElement

    type ClusterGetComponentTemplateRequestBuilder() =
        member _.Yield(_: unit) : ClusterGetComponentTemplateRequest =
            {
                Name = Unchecked.defaultof<_>
                FlatSettings = None
                SettingsFilter = None
                IncludeDefaults = None
                Local = None
                MasterTimeout = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: ClusterGetComponentTemplateRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("flatSettings")>]
        member _.FlatSettings(state: ClusterGetComponentTemplateRequest, value: bool) =
            { state with FlatSettings = Some value }

        [<CustomOperation("settingsFilter")>]
        member _.SettingsFilter(state: ClusterGetComponentTemplateRequest, value: System.Text.Json.JsonElement) =
            { state with SettingsFilter = Some value }

        [<CustomOperation("includeDefaults")>]
        member _.IncludeDefaults(state: ClusterGetComponentTemplateRequest, value: bool) =
            { state with IncludeDefaults = Some value }

        [<CustomOperation("local")>]
        member _.Local(state: ClusterGetComponentTemplateRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: ClusterGetComponentTemplateRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let clusterGetComponentTemplateRequest = ClusterGetComponentTemplateRequestBuilder()

    module GetComponentTemplate =
        let withFlatSettings (value: bool) (req: ClusterGetComponentTemplateRequest) =
            { req with FlatSettings = Some value }
        let withSettingsFilter (value: System.Text.Json.JsonElement) (req: ClusterGetComponentTemplateRequest) =
            { req with SettingsFilter = Some value }
        let withIncludeDefaults (value: bool) (req: ClusterGetComponentTemplateRequest) =
            { req with IncludeDefaults = Some value }
        let withLocal (value: bool) (req: ClusterGetComponentTemplateRequest) =
            { req with Local = Some value }
        let withMasterTimeout (value: Types.Duration) (req: ClusterGetComponentTemplateRequest) =
            { req with MasterTimeout = Some value }

    type ClusterGetSettingsRequest = {
        FlatSettings: bool option
        IncludeDefaults: bool option
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: ClusterGetSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cluster/settings"
                let queryParams =
                    [
                        req.FlatSettings |> Option.map (fun v -> "flat_settings", Fes.Http.toQueryValue v)
                        req.IncludeDefaults |> Option.map (fun v -> "include_defaults", Fes.Http.toQueryValue v)
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

    type ClusterGetSettingsResponse = System.Text.Json.JsonElement

    type ClusterGetSettingsRequestBuilder() =
        member _.Yield(_: unit) : ClusterGetSettingsRequest =
            {
                FlatSettings = None
                IncludeDefaults = None
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("flatSettings")>]
        member _.FlatSettings(state: ClusterGetSettingsRequest, value: bool) =
            { state with FlatSettings = Some value }

        [<CustomOperation("includeDefaults")>]
        member _.IncludeDefaults(state: ClusterGetSettingsRequest, value: bool) =
            { state with IncludeDefaults = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: ClusterGetSettingsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: ClusterGetSettingsRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let clusterGetSettingsRequest = ClusterGetSettingsRequestBuilder()

    module GetSettings =
        let withFlatSettings (value: bool) (req: ClusterGetSettingsRequest) =
            { req with FlatSettings = Some value }
        let withIncludeDefaults (value: bool) (req: ClusterGetSettingsRequest) =
            { req with IncludeDefaults = Some value }
        let withMasterTimeout (value: Types.Duration) (req: ClusterGetSettingsRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: ClusterGetSettingsRequest) =
            { req with Timeout = Some value }

    type ClusterHealthRequest = {
        Index: Types.Indices
        ExpandWildcards: Types.ExpandWildcards option
        Level: Types.Level option
        Local: bool option
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        WaitForActiveShards: Types.WaitForActiveShards option
        WaitForEvents: Types.WaitForEvents option
        WaitForNodes: Types.WaitForNodes option
        WaitForNoInitializingShards: bool option
        WaitForNoRelocatingShards: bool option
        WaitForStatus: Types.HealthStatus option
    }

        with
        static member ToRequest(req: ClusterHealthRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cluster/health/{req.Index}"
                let queryParams =
                    [
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.Level |> Option.map (fun v -> "level", Fes.Http.toQueryValue v)
                        req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        req.WaitForActiveShards |> Option.map (fun v -> "wait_for_active_shards", Fes.Http.toQueryValue v)
                        req.WaitForEvents |> Option.map (fun v -> "wait_for_events", Fes.Http.toQueryValue v)
                        req.WaitForNodes |> Option.map (fun v -> "wait_for_nodes", Fes.Http.toQueryValue v)
                        req.WaitForNoInitializingShards |> Option.map (fun v -> "wait_for_no_initializing_shards", Fes.Http.toQueryValue v)
                        req.WaitForNoRelocatingShards |> Option.map (fun v -> "wait_for_no_relocating_shards", Fes.Http.toQueryValue v)
                        req.WaitForStatus |> Option.map (fun v -> "wait_for_status", Fes.Http.toQueryValue v)
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

    type ClusterHealthResponse = Types.HealthResponseBody

    type ClusterHealthRequestBuilder() =
        member _.Yield(_: unit) : ClusterHealthRequest =
            {
                Index = Unchecked.defaultof<_>
                ExpandWildcards = None
                Level = None
                Local = None
                MasterTimeout = None
                Timeout = None
                WaitForActiveShards = None
                WaitForEvents = None
                WaitForNodes = None
                WaitForNoInitializingShards = None
                WaitForNoRelocatingShards = None
                WaitForStatus = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: ClusterHealthRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: ClusterHealthRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("level")>]
        member _.Level(state: ClusterHealthRequest, value: Types.Level) =
            { state with Level = Some value }

        [<CustomOperation("local")>]
        member _.Local(state: ClusterHealthRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: ClusterHealthRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: ClusterHealthRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("waitForActiveShards")>]
        member _.WaitForActiveShards(state: ClusterHealthRequest, value: Types.WaitForActiveShards) =
            { state with WaitForActiveShards = Some value }

        [<CustomOperation("waitForEvents")>]
        member _.WaitForEvents(state: ClusterHealthRequest, value: Types.WaitForEvents) =
            { state with WaitForEvents = Some value }

        [<CustomOperation("waitForNodes")>]
        member _.WaitForNodes(state: ClusterHealthRequest, value: Types.WaitForNodes) =
            { state with WaitForNodes = Some value }

        [<CustomOperation("waitForNoInitializingShards")>]
        member _.WaitForNoInitializingShards(state: ClusterHealthRequest, value: bool) =
            { state with WaitForNoInitializingShards = Some value }

        [<CustomOperation("waitForNoRelocatingShards")>]
        member _.WaitForNoRelocatingShards(state: ClusterHealthRequest, value: bool) =
            { state with WaitForNoRelocatingShards = Some value }

        [<CustomOperation("waitForStatus")>]
        member _.WaitForStatus(state: ClusterHealthRequest, value: Types.HealthStatus) =
            { state with WaitForStatus = Some value }

    let clusterHealthRequest = ClusterHealthRequestBuilder()

    module Health =
        let withExpandWildcards (value: Types.ExpandWildcards) (req: ClusterHealthRequest) =
            { req with ExpandWildcards = Some value }
        let withLevel (value: Types.Level) (req: ClusterHealthRequest) =
            { req with Level = Some value }
        let withLocal (value: bool) (req: ClusterHealthRequest) =
            { req with Local = Some value }
        let withMasterTimeout (value: Types.Duration) (req: ClusterHealthRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: ClusterHealthRequest) =
            { req with Timeout = Some value }
        let withWaitForActiveShards (value: Types.WaitForActiveShards) (req: ClusterHealthRequest) =
            { req with WaitForActiveShards = Some value }
        let withWaitForEvents (value: Types.WaitForEvents) (req: ClusterHealthRequest) =
            { req with WaitForEvents = Some value }
        let withWaitForNodes (value: Types.WaitForNodes) (req: ClusterHealthRequest) =
            { req with WaitForNodes = Some value }
        let withWaitForNoInitializingShards (value: bool) (req: ClusterHealthRequest) =
            { req with WaitForNoInitializingShards = Some value }
        let withWaitForNoRelocatingShards (value: bool) (req: ClusterHealthRequest) =
            { req with WaitForNoRelocatingShards = Some value }
        let withWaitForStatus (value: Types.HealthStatus) (req: ClusterHealthRequest) =
            { req with WaitForStatus = Some value }

    type ClusterInfoRequest = {
        Target: Types.ClusterInfoTargets
    }

        with
        static member ToRequest(req: ClusterInfoRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_info/{req.Target}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type ClusterInfoResponse = System.Text.Json.JsonElement

    type ClusterInfoRequestBuilder() =
        member _.Yield(_: unit) : ClusterInfoRequest =
            {
                Target = Unchecked.defaultof<_>
            }

        [<CustomOperation("target")>]
        member _.Target(state: ClusterInfoRequest, value: Types.ClusterInfoTargets) =
            { state with Target = value }

    let clusterInfoRequest = ClusterInfoRequestBuilder()

    type ClusterPendingTasksRequest = {
        Local: bool option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: ClusterPendingTasksRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cluster/pending_tasks"
                let queryParams =
                    [
                        req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
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

    type ClusterPendingTasksResponse = System.Text.Json.JsonElement

    type ClusterPendingTasksRequestBuilder() =
        member _.Yield(_: unit) : ClusterPendingTasksRequest =
            {
                Local = None
                MasterTimeout = None
            }

        [<CustomOperation("local")>]
        member _.Local(state: ClusterPendingTasksRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: ClusterPendingTasksRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let clusterPendingTasksRequest = ClusterPendingTasksRequestBuilder()

    module PendingTasks =
        let withLocal (value: bool) (req: ClusterPendingTasksRequest) =
            { req with Local = Some value }
        let withMasterTimeout (value: Types.Duration) (req: ClusterPendingTasksRequest) =
            { req with MasterTimeout = Some value }

    type ClusterPostVotingConfigExclusionsRequest = {
        NodeNames: Types.Names option
        NodeIds: Types.Ids option
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: ClusterPostVotingConfigExclusionsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cluster/voting_config_exclusions"
                let queryParams =
                    [
                        req.NodeNames |> Option.map (fun v -> "node_names", Fes.Http.toQueryValue v)
                        req.NodeIds |> Option.map (fun v -> "node_ids", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
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

    type ClusterPostVotingConfigExclusionsResponse = unit

    type ClusterPostVotingConfigExclusionsRequestBuilder() =
        member _.Yield(_: unit) : ClusterPostVotingConfigExclusionsRequest =
            {
                NodeNames = None
                NodeIds = None
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("nodeNames")>]
        member _.NodeNames(state: ClusterPostVotingConfigExclusionsRequest, value: Types.Names) =
            { state with NodeNames = Some value }

        [<CustomOperation("nodeIds")>]
        member _.NodeIds(state: ClusterPostVotingConfigExclusionsRequest, value: Types.Ids) =
            { state with NodeIds = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: ClusterPostVotingConfigExclusionsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: ClusterPostVotingConfigExclusionsRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let clusterPostVotingConfigExclusionsRequest = ClusterPostVotingConfigExclusionsRequestBuilder()

    module PostVotingConfigExclusions =
        let withNodeNames (value: Types.Names) (req: ClusterPostVotingConfigExclusionsRequest) =
            { req with NodeNames = Some value }
        let withNodeIds (value: Types.Ids) (req: ClusterPostVotingConfigExclusionsRequest) =
            { req with NodeIds = Some value }
        let withMasterTimeout (value: Types.Duration) (req: ClusterPostVotingConfigExclusionsRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: ClusterPostVotingConfigExclusionsRequest) =
            { req with Timeout = Some value }

    type ClusterPutComponentTemplateRequest = {
        Name: Types.Name
        Create: bool option
        Cause: string option
        MasterTimeout: Types.Duration option
        Template: Types.IndexTemplateMapping
        Version: Types.VersionNumber option
        Meta: Types.Metadata option
        Deprecated: bool option
    }

        with
        static member ToRequest(req: ClusterPutComponentTemplateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_component_template/{req.Name}"
                let queryParams =
                    [
                        req.Create |> Option.map (fun v -> "create", Fes.Http.toQueryValue v)
                        req.Cause |> Option.map (fun v -> "cause", Fes.Http.toQueryValue v)
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

    type ClusterPutComponentTemplateResponse = Types.AcknowledgedResponseBase

    type ClusterPutComponentTemplateRequestBuilder() =
        member _.Yield(_: unit) : ClusterPutComponentTemplateRequest =
            {
                Name = Unchecked.defaultof<_>
                Create = None
                Cause = None
                MasterTimeout = None
                Template = Unchecked.defaultof<_>
                Version = None
                Meta = None
                Deprecated = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: ClusterPutComponentTemplateRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("create")>]
        member _.Create(state: ClusterPutComponentTemplateRequest, value: bool) =
            { state with Create = Some value }

        [<CustomOperation("cause")>]
        member _.Cause(state: ClusterPutComponentTemplateRequest, value: string) =
            { state with Cause = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: ClusterPutComponentTemplateRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("template")>]
        member _.Template(state: ClusterPutComponentTemplateRequest, value: Types.IndexTemplateMapping) =
            { state with Template = value }

        [<CustomOperation("version")>]
        member _.Version(state: ClusterPutComponentTemplateRequest, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: ClusterPutComponentTemplateRequest, value: Types.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("deprecated")>]
        member _.Deprecated(state: ClusterPutComponentTemplateRequest, value: bool) =
            { state with Deprecated = Some value }

    let clusterPutComponentTemplateRequest = ClusterPutComponentTemplateRequestBuilder()

    module PutComponentTemplate =
        let withCreate (value: bool) (req: ClusterPutComponentTemplateRequest) =
            { req with Create = Some value }
        let withCause (value: string) (req: ClusterPutComponentTemplateRequest) =
            { req with Cause = Some value }
        let withMasterTimeout (value: Types.Duration) (req: ClusterPutComponentTemplateRequest) =
            { req with MasterTimeout = Some value }
        let withTemplate (value: Types.IndexTemplateMapping) (req: ClusterPutComponentTemplateRequest) =
            { req with Template = value }
        let withVersion (value: Types.VersionNumber) (req: ClusterPutComponentTemplateRequest) =
            { req with Version = Some value }
        let withMeta (value: Types.Metadata) (req: ClusterPutComponentTemplateRequest) =
            { req with Meta = Some value }
        let withDeprecated (value: bool) (req: ClusterPutComponentTemplateRequest) =
            { req with Deprecated = Some value }

    type ClusterPutSettingsRequest = {
        FlatSettings: bool option
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        Persistent: Map<string, System.Text.Json.JsonElement> option
        Transient: Map<string, System.Text.Json.JsonElement> option
    }

        with
        static member ToRequest(req: ClusterPutSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cluster/settings"
                let queryParams =
                    [
                        req.FlatSettings |> Option.map (fun v -> "flat_settings", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
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

    type ClusterPutSettingsResponse = System.Text.Json.JsonElement

    type ClusterPutSettingsRequestBuilder() =
        member _.Yield(_: unit) : ClusterPutSettingsRequest =
            {
                FlatSettings = None
                MasterTimeout = None
                Timeout = None
                Persistent = None
                Transient = None
            }

        [<CustomOperation("flatSettings")>]
        member _.FlatSettings(state: ClusterPutSettingsRequest, value: bool) =
            { state with FlatSettings = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: ClusterPutSettingsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: ClusterPutSettingsRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("persistent")>]
        member _.Persistent(state: ClusterPutSettingsRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Persistent = Some value }

        [<CustomOperation("transient")>]
        member _.Transient(state: ClusterPutSettingsRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Transient = Some value }

    let clusterPutSettingsRequest = ClusterPutSettingsRequestBuilder()

    module PutSettings =
        let withFlatSettings (value: bool) (req: ClusterPutSettingsRequest) =
            { req with FlatSettings = Some value }
        let withMasterTimeout (value: Types.Duration) (req: ClusterPutSettingsRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: ClusterPutSettingsRequest) =
            { req with Timeout = Some value }
        let withPersistent (value: Map<string, System.Text.Json.JsonElement>) (req: ClusterPutSettingsRequest) =
            { req with Persistent = Some value }
        let withTransient (value: Map<string, System.Text.Json.JsonElement>) (req: ClusterPutSettingsRequest) =
            { req with Transient = Some value }

    type ClusterRemoteInfoRequest = | ClusterRemoteInfoRequest

        with
        static member ToRequest(req: ClusterRemoteInfoRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_remote/info"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type ClusterRemoteInfoResponse = Map<string, Types.ClusterRemoteInfo>

    type ClusterRemoteInfoRequestBuilder() =
        member _.Yield(_: unit) : ClusterRemoteInfoRequest =
            {
            }

    let clusterRemoteInfoRequest = ClusterRemoteInfoRequestBuilder()

    type ClusterRerouteRequest = {
        DryRun: bool option
        Explain: bool option
        Metric: System.Text.Json.JsonElement option
        RetryFailed: bool option
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        Commands: Types.Command list option
    }

        with
        static member ToRequest(req: ClusterRerouteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cluster/reroute"
                let queryParams =
                    [
                        req.DryRun |> Option.map (fun v -> "dry_run", Fes.Http.toQueryValue v)
                        req.Explain |> Option.map (fun v -> "explain", Fes.Http.toQueryValue v)
                        req.Metric |> Option.map (fun v -> "metric", Fes.Http.toQueryValue v)
                        req.RetryFailed |> Option.map (fun v -> "retry_failed", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
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

    type ClusterRerouteResponse = System.Text.Json.JsonElement

    type ClusterRerouteRequestBuilder() =
        member _.Yield(_: unit) : ClusterRerouteRequest =
            {
                DryRun = None
                Explain = None
                Metric = None
                RetryFailed = None
                MasterTimeout = None
                Timeout = None
                Commands = None
            }

        [<CustomOperation("dryRun")>]
        member _.DryRun(state: ClusterRerouteRequest, value: bool) =
            { state with DryRun = Some value }

        [<CustomOperation("explain")>]
        member _.Explain(state: ClusterRerouteRequest, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("metric")>]
        member _.Metric(state: ClusterRerouteRequest, value: System.Text.Json.JsonElement) =
            { state with Metric = Some value }

        [<CustomOperation("retryFailed")>]
        member _.RetryFailed(state: ClusterRerouteRequest, value: bool) =
            { state with RetryFailed = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: ClusterRerouteRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: ClusterRerouteRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("commands")>]
        member _.Commands(state: ClusterRerouteRequest, value: Types.Command list) =
            { state with Commands = Some value }

    let clusterRerouteRequest = ClusterRerouteRequestBuilder()

    module Reroute =
        let withDryRun (value: bool) (req: ClusterRerouteRequest) =
            { req with DryRun = Some value }
        let withExplain (value: bool) (req: ClusterRerouteRequest) =
            { req with Explain = Some value }
        let withMetric (value: System.Text.Json.JsonElement) (req: ClusterRerouteRequest) =
            { req with Metric = Some value }
        let withRetryFailed (value: bool) (req: ClusterRerouteRequest) =
            { req with RetryFailed = Some value }
        let withMasterTimeout (value: Types.Duration) (req: ClusterRerouteRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: ClusterRerouteRequest) =
            { req with Timeout = Some value }
        let withCommands (value: Types.Command list) (req: ClusterRerouteRequest) =
            { req with Commands = Some value }

    type ClusterStateRequest = {
        Metric: Types.ClusterStateMetrics
        Index: Types.Indices
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        FlatSettings: bool option
        IgnoreUnavailable: bool option
        Local: bool option
        MasterTimeout: Types.Duration option
        WaitForMetadataVersion: Types.VersionNumber option
        WaitForTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: ClusterStateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cluster/state/{req.Metric}/{req.Index}"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.FlatSettings |> Option.map (fun v -> "flat_settings", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                        req.Local |> Option.map (fun v -> "local", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.WaitForMetadataVersion |> Option.map (fun v -> "wait_for_metadata_version", Fes.Http.toQueryValue v)
                        req.WaitForTimeout |> Option.map (fun v -> "wait_for_timeout", Fes.Http.toQueryValue v)
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

    type ClusterStateResponse = System.Text.Json.JsonElement

    type ClusterStateRequestBuilder() =
        member _.Yield(_: unit) : ClusterStateRequest =
            {
                Metric = Unchecked.defaultof<_>
                Index = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                FlatSettings = None
                IgnoreUnavailable = None
                Local = None
                MasterTimeout = None
                WaitForMetadataVersion = None
                WaitForTimeout = None
            }

        [<CustomOperation("metric")>]
        member _.Metric(state: ClusterStateRequest, value: Types.ClusterStateMetrics) =
            { state with Metric = value }

        [<CustomOperation("index")>]
        member _.Index(state: ClusterStateRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: ClusterStateRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: ClusterStateRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("flatSettings")>]
        member _.FlatSettings(state: ClusterStateRequest, value: bool) =
            { state with FlatSettings = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: ClusterStateRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("local")>]
        member _.Local(state: ClusterStateRequest, value: bool) =
            { state with Local = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: ClusterStateRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("waitForMetadataVersion")>]
        member _.WaitForMetadataVersion(state: ClusterStateRequest, value: Types.VersionNumber) =
            { state with WaitForMetadataVersion = Some value }

        [<CustomOperation("waitForTimeout")>]
        member _.WaitForTimeout(state: ClusterStateRequest, value: Types.Duration) =
            { state with WaitForTimeout = Some value }

    let clusterStateRequest = ClusterStateRequestBuilder()

    module State =
        let withAllowNoIndices (value: bool) (req: ClusterStateRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: ClusterStateRequest) =
            { req with ExpandWildcards = Some value }
        let withFlatSettings (value: bool) (req: ClusterStateRequest) =
            { req with FlatSettings = Some value }
        let withIgnoreUnavailable (value: bool) (req: ClusterStateRequest) =
            { req with IgnoreUnavailable = Some value }
        let withLocal (value: bool) (req: ClusterStateRequest) =
            { req with Local = Some value }
        let withMasterTimeout (value: Types.Duration) (req: ClusterStateRequest) =
            { req with MasterTimeout = Some value }
        let withWaitForMetadataVersion (value: Types.VersionNumber) (req: ClusterStateRequest) =
            { req with WaitForMetadataVersion = Some value }
        let withWaitForTimeout (value: Types.Duration) (req: ClusterStateRequest) =
            { req with WaitForTimeout = Some value }

    type ClusterStatsRequest = {
        NodeId: Types.NodeIds
        IncludeRemotes: bool option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: ClusterStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_cluster/stats/nodes/{req.NodeId}"
                let queryParams =
                    [
                        req.IncludeRemotes |> Option.map (fun v -> "include_remotes", Fes.Http.toQueryValue v)
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

    type ClusterStatsResponse = Types.StatsResponseBase

    type ClusterStatsRequestBuilder() =
        member _.Yield(_: unit) : ClusterStatsRequest =
            {
                NodeId = Unchecked.defaultof<_>
                IncludeRemotes = None
                Timeout = None
            }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: ClusterStatsRequest, value: Types.NodeIds) =
            { state with NodeId = value }

        [<CustomOperation("includeRemotes")>]
        member _.IncludeRemotes(state: ClusterStatsRequest, value: bool) =
            { state with IncludeRemotes = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: ClusterStatsRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let clusterStatsRequest = ClusterStatsRequestBuilder()

    module Stats =
        let withIncludeRemotes (value: bool) (req: ClusterStatsRequest) =
            { req with IncludeRemotes = Some value }
        let withTimeout (value: Types.Duration) (req: ClusterStatsRequest) =
            { req with Timeout = Some value }


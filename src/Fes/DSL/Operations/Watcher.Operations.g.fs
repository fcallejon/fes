// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module WatcherOperations =

    type WatcherAckWatchRequest = {
        WatchId: Name
        ActionId: Names
    } with
        static member ToRequest(request: WatcherAckWatchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_watcher/watch/{request.WatchId}/_ack/{request.ActionId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module WatcherAckWatchRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: WatcherAckWatchRequest) : Result<Fes.Http.RequestMsg, exn> =
            WatcherAckWatchRequest.ToRequest request

    type WatcherAckWatchRequestBuilder() =
        member _.Yield(_: unit) : WatcherAckWatchRequest =
            {
                WatcherAckWatchRequest.WatchId = Unchecked.defaultof<Name>
                WatcherAckWatchRequest.ActionId = Unchecked.defaultof<Names>
            } : WatcherAckWatchRequest

        [<CustomOperation("watch_id")>]
        member _.WatchId(state: WatcherAckWatchRequest, value: Name) =
            { state with WatcherAckWatchRequest.WatchId = value } : WatcherAckWatchRequest

        [<CustomOperation("action_id")>]
        member _.ActionId(state: WatcherAckWatchRequest, value: Names) =
            { state with WatcherAckWatchRequest.ActionId = value } : WatcherAckWatchRequest

    let watcherAckWatchRequest = WatcherAckWatchRequestBuilder()

    type WatcherActivateWatchRequest = {
        WatchId: Name
    } with
        static member ToRequest(request: WatcherActivateWatchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_watcher/watch/{request.WatchId}/_activate"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module WatcherActivateWatchRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: WatcherActivateWatchRequest) : Result<Fes.Http.RequestMsg, exn> =
            WatcherActivateWatchRequest.ToRequest request

    type WatcherActivateWatchRequestBuilder() =
        member _.Yield(_: unit) : WatcherActivateWatchRequest =
            {
                WatcherActivateWatchRequest.WatchId = Unchecked.defaultof<Name>
            } : WatcherActivateWatchRequest

        [<CustomOperation("watch_id")>]
        member _.WatchId(state: WatcherActivateWatchRequest, value: Name) =
            { state with WatcherActivateWatchRequest.WatchId = value } : WatcherActivateWatchRequest

    let watcherActivateWatchRequest = WatcherActivateWatchRequestBuilder()

    type WatcherDeactivateWatchRequest = {
        WatchId: Name
    } with
        static member ToRequest(request: WatcherDeactivateWatchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_watcher/watch/{request.WatchId}/_deactivate"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module WatcherDeactivateWatchRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: WatcherDeactivateWatchRequest) : Result<Fes.Http.RequestMsg, exn> =
            WatcherDeactivateWatchRequest.ToRequest request

    type WatcherDeactivateWatchRequestBuilder() =
        member _.Yield(_: unit) : WatcherDeactivateWatchRequest =
            {
                WatcherDeactivateWatchRequest.WatchId = Unchecked.defaultof<Name>
            } : WatcherDeactivateWatchRequest

        [<CustomOperation("watch_id")>]
        member _.WatchId(state: WatcherDeactivateWatchRequest, value: Name) =
            { state with WatcherDeactivateWatchRequest.WatchId = value } : WatcherDeactivateWatchRequest

    let watcherDeactivateWatchRequest = WatcherDeactivateWatchRequestBuilder()

    type WatcherGetWatchRequest = {
        Id: Name
    } with
        static member ToRequest(request: WatcherGetWatchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_watcher/watch/{request.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module WatcherGetWatchRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: WatcherGetWatchRequest) : Result<Fes.Http.RequestMsg, exn> =
            WatcherGetWatchRequest.ToRequest request

    type WatcherGetWatchRequestBuilder() =
        member _.Yield(_: unit) : WatcherGetWatchRequest =
            {
                WatcherGetWatchRequest.Id = Unchecked.defaultof<Name>
            } : WatcherGetWatchRequest

        [<CustomOperation("id")>]
        member _.Id(state: WatcherGetWatchRequest, value: Name) =
            { state with WatcherGetWatchRequest.Id = value } : WatcherGetWatchRequest

    let watcherGetWatchRequest = WatcherGetWatchRequestBuilder()

    type WatcherGetWatchResponse = {
        [<JsonPropertyName("found")>]
        Found: bool
        [<JsonPropertyName("_id")>]
        Id: Id
        [<JsonPropertyName("status")>]
        Status: TypesWatchStatus option
        [<JsonPropertyName("watch")>]
        Watch: TypesWatch option
        [<JsonPropertyName("_primary_term")>]
        PrimaryTerm: float option
        [<JsonPropertyName("_seq_no")>]
        SeqNo: SequenceNumber option
        [<JsonPropertyName("_version")>]
        Version: VersionNumber option
    }

    type WatcherPutWatchRequest = {
        Id: Id
        Active: bool option
        IfPrimaryTerm: float option
        IfSeqNo: SequenceNumber option
        Version: VersionNumber option
        [<JsonPropertyName("actions")>]
        Actions: Map<string, TypesAction> option
        [<JsonPropertyName("condition")>]
        Condition: TypesConditionContainer option
        [<JsonPropertyName("input")>]
        Input: TypesInputContainer option
        [<JsonPropertyName("metadata")>]
        Metadata: Metadata option
        [<JsonPropertyName("throttle_period")>]
        ThrottlePeriod: Duration option
        [<JsonPropertyName("throttle_period_in_millis")>]
        ThrottlePeriodInMillis: DurationValueUnitMillis option
        [<JsonPropertyName("transform")>]
        Transform: TransformContainer option
        [<JsonPropertyName("trigger")>]
        Trigger: TypesTriggerContainer option
    } with
        static member ToRequest(request: WatcherPutWatchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_watcher/watch/{request.Id}"
                let queryParams =
                    [
                        request.Active |> Option.map (fun v -> "active", Fes.Http.toQueryValue v)
                        request.IfPrimaryTerm |> Option.map (fun v -> "if_primary_term", Fes.Http.toQueryValue v)
                        request.IfSeqNo |> Option.map (fun v -> "if_seq_no", Fes.Http.toQueryValue v)
                        request.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``actions`` = request.Actions; ``condition`` = request.Condition; ``input`` = request.Input; ``metadata`` = request.Metadata; ``throttle_period`` = request.ThrottlePeriod; ``throttle_period_in_millis`` = request.ThrottlePeriodInMillis; ``transform`` = request.Transform; ``trigger`` = request.Trigger |}
                |> Result.Ok
            with ex -> Result.Error ex

    module WatcherPutWatchRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: WatcherPutWatchRequest) : Result<Fes.Http.RequestMsg, exn> =
            WatcherPutWatchRequest.ToRequest request

    type WatcherPutWatchRequestBuilder() =
        member _.Yield(_: unit) : WatcherPutWatchRequest =
            {
                WatcherPutWatchRequest.Id = Unchecked.defaultof<Id>
                WatcherPutWatchRequest.Active = Option.None
                WatcherPutWatchRequest.IfPrimaryTerm = Option.None
                WatcherPutWatchRequest.IfSeqNo = Option.None
                WatcherPutWatchRequest.Version = Option.None
                WatcherPutWatchRequest.Actions = Option.None
                WatcherPutWatchRequest.Condition = Option.None
                WatcherPutWatchRequest.Input = Option.None
                WatcherPutWatchRequest.Metadata = Option.None
                WatcherPutWatchRequest.ThrottlePeriod = Option.None
                WatcherPutWatchRequest.ThrottlePeriodInMillis = Option.None
                WatcherPutWatchRequest.Transform = Option.None
                WatcherPutWatchRequest.Trigger = Option.None
            } : WatcherPutWatchRequest

        [<CustomOperation("id")>]
        member _.Id(state: WatcherPutWatchRequest, value: Id) =
            { state with WatcherPutWatchRequest.Id = value } : WatcherPutWatchRequest

        [<CustomOperation("active")>]
        member _.Active(state: WatcherPutWatchRequest, value: bool) =
            { state with WatcherPutWatchRequest.Active = Option.Some value } : WatcherPutWatchRequest

        [<CustomOperation("if_primary_term")>]
        member _.IfPrimaryTerm(state: WatcherPutWatchRequest, value: float) =
            { state with WatcherPutWatchRequest.IfPrimaryTerm = Option.Some value } : WatcherPutWatchRequest

        [<CustomOperation("if_seq_no")>]
        member _.IfSeqNo(state: WatcherPutWatchRequest, value: SequenceNumber) =
            { state with WatcherPutWatchRequest.IfSeqNo = Option.Some value } : WatcherPutWatchRequest

        [<CustomOperation("version")>]
        member _.Version(state: WatcherPutWatchRequest, value: VersionNumber) =
            { state with WatcherPutWatchRequest.Version = Option.Some value } : WatcherPutWatchRequest

        [<CustomOperation("actions")>]
        member _.Actions(state: WatcherPutWatchRequest, value: Map<string, TypesAction>) =
            { state with WatcherPutWatchRequest.Actions = Option.Some value } : WatcherPutWatchRequest

        [<CustomOperation("condition")>]
        member _.Condition(state: WatcherPutWatchRequest, value: TypesConditionContainer) =
            { state with WatcherPutWatchRequest.Condition = Option.Some value } : WatcherPutWatchRequest

        [<CustomOperation("input")>]
        member _.Input(state: WatcherPutWatchRequest, value: TypesInputContainer) =
            { state with WatcherPutWatchRequest.Input = Option.Some value } : WatcherPutWatchRequest

        [<CustomOperation("metadata")>]
        member _.Metadata(state: WatcherPutWatchRequest, value: Metadata) =
            { state with WatcherPutWatchRequest.Metadata = Option.Some value } : WatcherPutWatchRequest

        [<CustomOperation("throttle_period")>]
        member _.ThrottlePeriod(state: WatcherPutWatchRequest, value: Duration) =
            { state with WatcherPutWatchRequest.ThrottlePeriod = Option.Some value } : WatcherPutWatchRequest

        [<CustomOperation("throttle_period_in_millis")>]
        member _.ThrottlePeriodInMillis(state: WatcherPutWatchRequest, value: DurationValueUnitMillis) =
            { state with WatcherPutWatchRequest.ThrottlePeriodInMillis = Option.Some value } : WatcherPutWatchRequest

        [<CustomOperation("transform")>]
        member _.Transform(state: WatcherPutWatchRequest, value: TransformContainer) =
            { state with WatcherPutWatchRequest.Transform = Option.Some value } : WatcherPutWatchRequest

        [<CustomOperation("trigger")>]
        member _.Trigger(state: WatcherPutWatchRequest, value: TypesTriggerContainer) =
            { state with WatcherPutWatchRequest.Trigger = Option.Some value } : WatcherPutWatchRequest

    let watcherPutWatchRequest = WatcherPutWatchRequestBuilder()

    type WatcherDeleteWatchRequest = {
        Id: Name
    } with
        static member ToRequest(request: WatcherDeleteWatchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_watcher/watch/{request.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module WatcherDeleteWatchRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: WatcherDeleteWatchRequest) : Result<Fes.Http.RequestMsg, exn> =
            WatcherDeleteWatchRequest.ToRequest request

    type WatcherDeleteWatchRequestBuilder() =
        member _.Yield(_: unit) : WatcherDeleteWatchRequest =
            {
                WatcherDeleteWatchRequest.Id = Unchecked.defaultof<Name>
            } : WatcherDeleteWatchRequest

        [<CustomOperation("id")>]
        member _.Id(state: WatcherDeleteWatchRequest, value: Name) =
            { state with WatcherDeleteWatchRequest.Id = value } : WatcherDeleteWatchRequest

    let watcherDeleteWatchRequest = WatcherDeleteWatchRequestBuilder()

    type WatcherDeleteWatchResponse = {
        [<JsonPropertyName("found")>]
        Found: bool
        [<JsonPropertyName("_id")>]
        Id: Id
        [<JsonPropertyName("_version")>]
        Version: VersionNumber
    }

    type WatcherExecuteWatchRequest = {
        Id: Id
        Debug: bool option
        [<JsonPropertyName("action_modes")>]
        ActionModes: Map<string, TypesActionExecutionMode> option
        [<JsonPropertyName("alternative_input")>]
        AlternativeInput: Map<string, obj> option
        [<JsonPropertyName("ignore_condition")>]
        IgnoreCondition: bool option
        [<JsonPropertyName("record_execution")>]
        RecordExecution: bool option
        [<JsonPropertyName("simulated_actions")>]
        SimulatedActions: TypesSimulatedActions option
        [<JsonPropertyName("trigger_data")>]
        TriggerData: TypesScheduleTriggerEvent option
        [<JsonPropertyName("watch")>]
        Watch: TypesWatch option
    } with
        static member ToRequest(request: WatcherExecuteWatchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_watcher/watch/{request.Id}/_execute"
                let queryParams =
                    [
                        request.Debug |> Option.map (fun v -> "debug", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``action_modes`` = request.ActionModes; ``alternative_input`` = request.AlternativeInput; ``ignore_condition`` = request.IgnoreCondition; ``record_execution`` = request.RecordExecution; ``simulated_actions`` = request.SimulatedActions; ``trigger_data`` = request.TriggerData; ``watch`` = request.Watch |}
                |> Result.Ok
            with ex -> Result.Error ex

    module WatcherExecuteWatchRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: WatcherExecuteWatchRequest) : Result<Fes.Http.RequestMsg, exn> =
            WatcherExecuteWatchRequest.ToRequest request

    type WatcherExecuteWatchRequestBuilder() =
        member _.Yield(_: unit) : WatcherExecuteWatchRequest =
            {
                WatcherExecuteWatchRequest.Id = Unchecked.defaultof<Id>
                WatcherExecuteWatchRequest.Debug = Option.None
                WatcherExecuteWatchRequest.ActionModes = Option.None
                WatcherExecuteWatchRequest.AlternativeInput = Option.None
                WatcherExecuteWatchRequest.IgnoreCondition = Option.None
                WatcherExecuteWatchRequest.RecordExecution = Option.None
                WatcherExecuteWatchRequest.SimulatedActions = Option.None
                WatcherExecuteWatchRequest.TriggerData = Option.None
                WatcherExecuteWatchRequest.Watch = Option.None
            } : WatcherExecuteWatchRequest

        [<CustomOperation("id")>]
        member _.Id(state: WatcherExecuteWatchRequest, value: Id) =
            { state with WatcherExecuteWatchRequest.Id = value } : WatcherExecuteWatchRequest

        [<CustomOperation("debug")>]
        member _.Debug(state: WatcherExecuteWatchRequest, value: bool) =
            { state with WatcherExecuteWatchRequest.Debug = Option.Some value } : WatcherExecuteWatchRequest

        [<CustomOperation("action_modes")>]
        member _.ActionModes(state: WatcherExecuteWatchRequest, value: Map<string, TypesActionExecutionMode>) =
            { state with WatcherExecuteWatchRequest.ActionModes = Option.Some value } : WatcherExecuteWatchRequest

        [<CustomOperation("alternative_input")>]
        member _.AlternativeInput(state: WatcherExecuteWatchRequest, value: Map<string, obj>) =
            { state with WatcherExecuteWatchRequest.AlternativeInput = Option.Some value } : WatcherExecuteWatchRequest

        [<CustomOperation("ignore_condition")>]
        member _.IgnoreCondition(state: WatcherExecuteWatchRequest, value: bool) =
            { state with WatcherExecuteWatchRequest.IgnoreCondition = Option.Some value } : WatcherExecuteWatchRequest

        [<CustomOperation("record_execution")>]
        member _.RecordExecution(state: WatcherExecuteWatchRequest, value: bool) =
            { state with WatcherExecuteWatchRequest.RecordExecution = Option.Some value } : WatcherExecuteWatchRequest

        [<CustomOperation("simulated_actions")>]
        member _.SimulatedActions(state: WatcherExecuteWatchRequest, value: TypesSimulatedActions) =
            { state with WatcherExecuteWatchRequest.SimulatedActions = Option.Some value } : WatcherExecuteWatchRequest

        [<CustomOperation("trigger_data")>]
        member _.TriggerData(state: WatcherExecuteWatchRequest, value: TypesScheduleTriggerEvent) =
            { state with WatcherExecuteWatchRequest.TriggerData = Option.Some value } : WatcherExecuteWatchRequest

        [<CustomOperation("watch")>]
        member _.Watch(state: WatcherExecuteWatchRequest, value: TypesWatch) =
            { state with WatcherExecuteWatchRequest.Watch = Option.Some value } : WatcherExecuteWatchRequest

    let watcherExecuteWatchRequest = WatcherExecuteWatchRequestBuilder()

    type WatcherGetSettingsRequest = {
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: WatcherGetSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_watcher/settings"
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

    module WatcherGetSettingsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: WatcherGetSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            WatcherGetSettingsRequest.ToRequest request

    type WatcherGetSettingsRequestBuilder() =
        member _.Yield(_: unit) : WatcherGetSettingsRequest =
            {
                WatcherGetSettingsRequest.MasterTimeout = Option.None
            } : WatcherGetSettingsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: WatcherGetSettingsRequest, value: Duration) =
            { state with WatcherGetSettingsRequest.MasterTimeout = Option.Some value } : WatcherGetSettingsRequest

    let watcherGetSettingsRequest = WatcherGetSettingsRequestBuilder()

    type WatcherGetSettingsResponse = {
        [<JsonPropertyName("index")>]
        Index: TypesIndexSettings
    }

    type WatcherUpdateSettingsRequest = {
        MasterTimeout: Duration option
        Timeout: Duration option
        [<JsonPropertyName("index.auto_expand_replicas")>]
        IndexAutoExpandReplicas: string option
        [<JsonPropertyName("index.number_of_replicas")>]
        IndexNumberOfReplicas: float option
    } with
        static member ToRequest(request: WatcherUpdateSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_watcher/settings"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``index.auto_expand_replicas`` = request.IndexAutoExpandReplicas; ``index.number_of_replicas`` = request.IndexNumberOfReplicas |}
                |> Result.Ok
            with ex -> Result.Error ex

    module WatcherUpdateSettingsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: WatcherUpdateSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            WatcherUpdateSettingsRequest.ToRequest request

    type WatcherUpdateSettingsRequestBuilder() =
        member _.Yield(_: unit) : WatcherUpdateSettingsRequest =
            {
                WatcherUpdateSettingsRequest.MasterTimeout = Option.None
                WatcherUpdateSettingsRequest.Timeout = Option.None
                WatcherUpdateSettingsRequest.IndexAutoExpandReplicas = Option.None
                WatcherUpdateSettingsRequest.IndexNumberOfReplicas = Option.None
            } : WatcherUpdateSettingsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: WatcherUpdateSettingsRequest, value: Duration) =
            { state with WatcherUpdateSettingsRequest.MasterTimeout = Option.Some value } : WatcherUpdateSettingsRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: WatcherUpdateSettingsRequest, value: Duration) =
            { state with WatcherUpdateSettingsRequest.Timeout = Option.Some value } : WatcherUpdateSettingsRequest

        [<CustomOperation("index_auto_expand_replicas")>]
        member _.IndexAutoExpandReplicas(state: WatcherUpdateSettingsRequest, value: string) =
            { state with WatcherUpdateSettingsRequest.IndexAutoExpandReplicas = Option.Some value } : WatcherUpdateSettingsRequest

        [<CustomOperation("index_number_of_replicas")>]
        member _.IndexNumberOfReplicas(state: WatcherUpdateSettingsRequest, value: float) =
            { state with WatcherUpdateSettingsRequest.IndexNumberOfReplicas = Option.Some value } : WatcherUpdateSettingsRequest

    let watcherUpdateSettingsRequest = WatcherUpdateSettingsRequestBuilder()

    type WatcherUpdateSettingsResponse = {
        [<JsonPropertyName("acknowledged")>]
        Acknowledged: bool
    }

    type WatcherQueryWatchesRequest = {
        [<JsonPropertyName("from")>]
        From: float option
        [<JsonPropertyName("size")>]
        Size: float option
        [<JsonPropertyName("query")>]
        Query: QueryDslQueryContainer option
        [<JsonPropertyName("sort")>]
        Sort: Sort option
        [<JsonPropertyName("search_after")>]
        SearchAfter: SortResults option
    } with
        static member ToRequest(request: WatcherQueryWatchesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_watcher/_query/watches"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``from`` = request.From; ``size`` = request.Size; ``query`` = request.Query; ``sort`` = request.Sort; ``search_after`` = request.SearchAfter |}
                |> Result.Ok
            with ex -> Result.Error ex

    module WatcherQueryWatchesRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: WatcherQueryWatchesRequest) : Result<Fes.Http.RequestMsg, exn> =
            WatcherQueryWatchesRequest.ToRequest request

    type WatcherQueryWatchesRequestBuilder() =
        member _.Yield(_: unit) : WatcherQueryWatchesRequest =
            {
                WatcherQueryWatchesRequest.From = Option.None
                WatcherQueryWatchesRequest.Size = Option.None
                WatcherQueryWatchesRequest.Query = Option.None
                WatcherQueryWatchesRequest.Sort = Option.None
                WatcherQueryWatchesRequest.SearchAfter = Option.None
            } : WatcherQueryWatchesRequest

        [<CustomOperation("from")>]
        member _.From(state: WatcherQueryWatchesRequest, value: float) =
            { state with WatcherQueryWatchesRequest.From = Option.Some value } : WatcherQueryWatchesRequest

        [<CustomOperation("size")>]
        member _.Size(state: WatcherQueryWatchesRequest, value: float) =
            { state with WatcherQueryWatchesRequest.Size = Option.Some value } : WatcherQueryWatchesRequest

        [<CustomOperation("query")>]
        member _.Query(state: WatcherQueryWatchesRequest, value: QueryDslQueryContainer) =
            { state with WatcherQueryWatchesRequest.Query = Option.Some value } : WatcherQueryWatchesRequest

        [<CustomOperation("sort")>]
        member _.Sort(state: WatcherQueryWatchesRequest, value: Sort) =
            { state with WatcherQueryWatchesRequest.Sort = Option.Some value } : WatcherQueryWatchesRequest

        [<CustomOperation("search_after")>]
        member _.SearchAfter(state: WatcherQueryWatchesRequest, value: SortResults) =
            { state with WatcherQueryWatchesRequest.SearchAfter = Option.Some value } : WatcherQueryWatchesRequest

    let watcherQueryWatchesRequest = WatcherQueryWatchesRequestBuilder()

    type WatcherStartRequest = {
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: WatcherStartRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_watcher/_start"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module WatcherStartRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: WatcherStartRequest) : Result<Fes.Http.RequestMsg, exn> =
            WatcherStartRequest.ToRequest request

    type WatcherStartRequestBuilder() =
        member _.Yield(_: unit) : WatcherStartRequest =
            {
                WatcherStartRequest.MasterTimeout = Option.None
            } : WatcherStartRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: WatcherStartRequest, value: Duration) =
            { state with WatcherStartRequest.MasterTimeout = Option.Some value } : WatcherStartRequest

    let watcherStartRequest = WatcherStartRequestBuilder()

    type WatcherStartResponse = AcknowledgedResponseBase

    type WatcherStatsRequest = {
        Metric: System.Text.Json.JsonElement
        EmitStacktraces: bool option
        QueryMetric: System.Text.Json.JsonElement option
    } with
        static member ToRequest(request: WatcherStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_watcher/stats/{request.Metric}"
                let queryParams =
                    [
                        request.EmitStacktraces |> Option.map (fun v -> "emit_stacktraces", Fes.Http.toQueryValue v)
                        request.QueryMetric |> Option.map (fun v -> "metric", Fes.Http.toQueryValue v)
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

    module WatcherStatsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: WatcherStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            WatcherStatsRequest.ToRequest request

    type WatcherStatsRequestBuilder() =
        member _.Yield(_: unit) : WatcherStatsRequest =
            {
                WatcherStatsRequest.Metric = Unchecked.defaultof<System.Text.Json.JsonElement>
                WatcherStatsRequest.EmitStacktraces = Option.None
                WatcherStatsRequest.QueryMetric = Option.None
            } : WatcherStatsRequest

        [<CustomOperation("metric")>]
        member _.Metric(state: WatcherStatsRequest, value: System.Text.Json.JsonElement) =
            { state with WatcherStatsRequest.Metric = value } : WatcherStatsRequest

        [<CustomOperation("emit_stacktraces")>]
        member _.EmitStacktraces(state: WatcherStatsRequest, value: bool) =
            { state with WatcherStatsRequest.EmitStacktraces = Option.Some value } : WatcherStatsRequest

        [<CustomOperation("query_metric")>]
        member _.QueryMetric(state: WatcherStatsRequest, value: System.Text.Json.JsonElement) =
            { state with WatcherStatsRequest.QueryMetric = Option.Some value } : WatcherStatsRequest

    let watcherStatsRequest = WatcherStatsRequestBuilder()

    type WatcherStopRequest = {
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: WatcherStopRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_watcher/_stop"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module WatcherStopRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: WatcherStopRequest) : Result<Fes.Http.RequestMsg, exn> =
            WatcherStopRequest.ToRequest request

    type WatcherStopRequestBuilder() =
        member _.Yield(_: unit) : WatcherStopRequest =
            {
                WatcherStopRequest.MasterTimeout = Option.None
            } : WatcherStopRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: WatcherStopRequest, value: Duration) =
            { state with WatcherStopRequest.MasterTimeout = Option.Some value } : WatcherStopRequest

    let watcherStopRequest = WatcherStopRequestBuilder()

    type WatcherStopResponse = AcknowledgedResponseBase


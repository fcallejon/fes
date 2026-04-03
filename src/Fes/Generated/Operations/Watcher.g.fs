// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module WatcherOperations =

    type WatcherAckWatchRequest = {
        WatchId: CoreTypes.Name
        ActionId: CoreTypes.Names
    }

        with
        static member ToRequest(req: WatcherAckWatchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_watcher/watch/{req.WatchId}/_ack/{req.ActionId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type WatcherAckWatchResponse = System.Text.Json.JsonElement

    type WatcherAckWatchRequestBuilder() =
        member _.Yield(_: unit) : WatcherAckWatchRequest =
            {
                WatchId = Unchecked.defaultof<_>
                ActionId = Unchecked.defaultof<_>
            }

        [<CustomOperation("watchId")>]
        member _.WatchId(state: WatcherAckWatchRequest, value: CoreTypes.Name) =
            { state with WatchId = value }

        [<CustomOperation("actionId")>]
        member _.ActionId(state: WatcherAckWatchRequest, value: CoreTypes.Names) =
            { state with ActionId = value }

    let watcherAckWatchRequest = WatcherAckWatchRequestBuilder()

    type WatcherActivateWatchRequest = {
        WatchId: CoreTypes.Name
    }

        with
        static member ToRequest(req: WatcherActivateWatchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_watcher/watch/{req.WatchId}/_activate"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type WatcherActivateWatchResponse = System.Text.Json.JsonElement

    type WatcherActivateWatchRequestBuilder() =
        member _.Yield(_: unit) : WatcherActivateWatchRequest =
            {
                WatchId = Unchecked.defaultof<_>
            }

        [<CustomOperation("watchId")>]
        member _.WatchId(state: WatcherActivateWatchRequest, value: CoreTypes.Name) =
            { state with WatchId = value }

    let watcherActivateWatchRequest = WatcherActivateWatchRequestBuilder()

    type WatcherDeactivateWatchRequest = {
        WatchId: CoreTypes.Name
    }

        with
        static member ToRequest(req: WatcherDeactivateWatchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_watcher/watch/{req.WatchId}/_deactivate"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type WatcherDeactivateWatchResponse = System.Text.Json.JsonElement

    type WatcherDeactivateWatchRequestBuilder() =
        member _.Yield(_: unit) : WatcherDeactivateWatchRequest =
            {
                WatchId = Unchecked.defaultof<_>
            }

        [<CustomOperation("watchId")>]
        member _.WatchId(state: WatcherDeactivateWatchRequest, value: CoreTypes.Name) =
            { state with WatchId = value }

    let watcherDeactivateWatchRequest = WatcherDeactivateWatchRequestBuilder()

    type WatcherDeleteWatchRequest = {
        Id: CoreTypes.Name
    }

        with
        static member ToRequest(req: WatcherDeleteWatchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_watcher/watch/{req.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type WatcherDeleteWatchResponse = System.Text.Json.JsonElement

    type WatcherDeleteWatchRequestBuilder() =
        member _.Yield(_: unit) : WatcherDeleteWatchRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: WatcherDeleteWatchRequest, value: CoreTypes.Name) =
            { state with Id = value }

    let watcherDeleteWatchRequest = WatcherDeleteWatchRequestBuilder()

    type WatcherExecuteWatchRequest = {
        Id: CoreTypes.Id
        Debug: bool option
        ActionModes: Map<string, WatcherTypes.ActionExecutionMode> option
        AlternativeInput: Map<string, System.Text.Json.JsonElement> option
        IgnoreCondition: bool option
        RecordExecution: bool option
        SimulatedActions: WatcherTypes.SimulatedActions option
        TriggerData: WatcherTypes.ScheduleTriggerEvent option
        Watch: WatcherTypes.Watch option
    }

        with
        static member ToRequest(req: WatcherExecuteWatchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_watcher/watch/{req.Id}/_execute"
                let queryParams =
                    [
                        req.Debug |> Option.map (fun v -> "debug", Fes.Http.toQueryValue v)
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

    type WatcherExecuteWatchResponse = System.Text.Json.JsonElement

    type WatcherExecuteWatchRequestBuilder() =
        member _.Yield(_: unit) : WatcherExecuteWatchRequest =
            {
                Id = Unchecked.defaultof<_>
                Debug = None
                ActionModes = None
                AlternativeInput = None
                IgnoreCondition = None
                RecordExecution = None
                SimulatedActions = None
                TriggerData = None
                Watch = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: WatcherExecuteWatchRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("debug")>]
        member _.Debug(state: WatcherExecuteWatchRequest, value: bool) =
            { state with Debug = Some value }

        [<CustomOperation("actionModes")>]
        member _.ActionModes(state: WatcherExecuteWatchRequest, value: Map<string, WatcherTypes.ActionExecutionMode>) =
            { state with ActionModes = Some value }

        [<CustomOperation("alternativeInput")>]
        member _.AlternativeInput(state: WatcherExecuteWatchRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with AlternativeInput = Some value }

        [<CustomOperation("ignoreCondition")>]
        member _.IgnoreCondition(state: WatcherExecuteWatchRequest, value: bool) =
            { state with IgnoreCondition = Some value }

        [<CustomOperation("recordExecution")>]
        member _.RecordExecution(state: WatcherExecuteWatchRequest, value: bool) =
            { state with RecordExecution = Some value }

        [<CustomOperation("simulatedActions")>]
        member _.SimulatedActions(state: WatcherExecuteWatchRequest, value: WatcherTypes.SimulatedActions) =
            { state with SimulatedActions = Some value }

        [<CustomOperation("triggerData")>]
        member _.TriggerData(state: WatcherExecuteWatchRequest, value: WatcherTypes.ScheduleTriggerEvent) =
            { state with TriggerData = Some value }

        [<CustomOperation("watch")>]
        member _.Watch(state: WatcherExecuteWatchRequest, value: WatcherTypes.Watch) =
            { state with Watch = Some value }

    let watcherExecuteWatchRequest = WatcherExecuteWatchRequestBuilder()

    module ExecuteWatch =
        let withDebug (value: bool) (req: WatcherExecuteWatchRequest) =
            { req with Debug = Some value }
        let withActionModes (value: Map<string, WatcherTypes.ActionExecutionMode>) (req: WatcherExecuteWatchRequest) =
            { req with ActionModes = Some value }
        let withAlternativeInput (value: Map<string, System.Text.Json.JsonElement>) (req: WatcherExecuteWatchRequest) =
            { req with AlternativeInput = Some value }
        let withIgnoreCondition (value: bool) (req: WatcherExecuteWatchRequest) =
            { req with IgnoreCondition = Some value }
        let withRecordExecution (value: bool) (req: WatcherExecuteWatchRequest) =
            { req with RecordExecution = Some value }
        let withSimulatedActions (value: WatcherTypes.SimulatedActions) (req: WatcherExecuteWatchRequest) =
            { req with SimulatedActions = Some value }
        let withTriggerData (value: WatcherTypes.ScheduleTriggerEvent) (req: WatcherExecuteWatchRequest) =
            { req with TriggerData = Some value }
        let withWatch (value: WatcherTypes.Watch) (req: WatcherExecuteWatchRequest) =
            { req with Watch = Some value }

    type WatcherGetSettingsRequest = {
        MasterTimeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: WatcherGetSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_watcher/settings"
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

    type WatcherGetSettingsResponse = System.Text.Json.JsonElement

    type WatcherGetSettingsRequestBuilder() =
        member _.Yield(_: unit) : WatcherGetSettingsRequest =
            {
                MasterTimeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: WatcherGetSettingsRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

    let watcherGetSettingsRequest = WatcherGetSettingsRequestBuilder()

    module GetSettings =
        let withMasterTimeout (value: CoreTypes.Duration) (req: WatcherGetSettingsRequest) =
            { req with MasterTimeout = Some value }

    type WatcherGetWatchRequest = {
        Id: CoreTypes.Name
    }

        with
        static member ToRequest(req: WatcherGetWatchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_watcher/watch/{req.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type WatcherGetWatchResponse = System.Text.Json.JsonElement

    type WatcherGetWatchRequestBuilder() =
        member _.Yield(_: unit) : WatcherGetWatchRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: WatcherGetWatchRequest, value: CoreTypes.Name) =
            { state with Id = value }

    let watcherGetWatchRequest = WatcherGetWatchRequestBuilder()

    type WatcherPutWatchRequest = {
        Id: CoreTypes.Id
        Active: bool option
        IfPrimaryTerm: CoreTypes.Long option
        IfSeqNo: CoreTypes.SequenceNumber option
        Version: CoreTypes.VersionNumber option
        Actions: Map<string, WatcherTypes.Action> option
        Condition: WatcherTypes.ConditionContainer option
        Input: WatcherTypes.InputContainer option
        Metadata: CoreTypes.Metadata option
        ThrottlePeriod: CoreTypes.Duration option
        ThrottlePeriodInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis> option
        Transform: CoreTypes.TransformContainer option
        Trigger: WatcherTypes.TriggerContainer option
    }

        with
        static member ToRequest(req: WatcherPutWatchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_watcher/watch/{req.Id}"
                let queryParams =
                    [
                        req.Active |> Option.map (fun v -> "active", Fes.Http.toQueryValue v)
                        req.IfPrimaryTerm |> Option.map (fun v -> "if_primary_term", Fes.Http.toQueryValue v)
                        req.IfSeqNo |> Option.map (fun v -> "if_seq_no", Fes.Http.toQueryValue v)
                        req.Version |> Option.map (fun v -> "version", Fes.Http.toQueryValue v)
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

    type WatcherPutWatchResponse = System.Text.Json.JsonElement

    type WatcherPutWatchRequestBuilder() =
        member _.Yield(_: unit) : WatcherPutWatchRequest =
            {
                Id = Unchecked.defaultof<_>
                Active = None
                IfPrimaryTerm = None
                IfSeqNo = None
                Version = None
                Actions = None
                Condition = None
                Input = None
                Metadata = None
                ThrottlePeriod = None
                ThrottlePeriodInMillis = None
                Transform = None
                Trigger = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: WatcherPutWatchRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("active")>]
        member _.Active(state: WatcherPutWatchRequest, value: bool) =
            { state with Active = Some value }

        [<CustomOperation("ifPrimaryTerm")>]
        member _.IfPrimaryTerm(state: WatcherPutWatchRequest, value: CoreTypes.Long) =
            { state with IfPrimaryTerm = Some value }

        [<CustomOperation("ifSeqNo")>]
        member _.IfSeqNo(state: WatcherPutWatchRequest, value: CoreTypes.SequenceNumber) =
            { state with IfSeqNo = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: WatcherPutWatchRequest, value: CoreTypes.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("actions")>]
        member _.Actions(state: WatcherPutWatchRequest, value: Map<string, WatcherTypes.Action>) =
            { state with Actions = Some value }

        [<CustomOperation("condition")>]
        member _.Condition(state: WatcherPutWatchRequest, value: WatcherTypes.ConditionContainer) =
            { state with Condition = Some value }

        [<CustomOperation("input")>]
        member _.Input(state: WatcherPutWatchRequest, value: WatcherTypes.InputContainer) =
            { state with Input = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: WatcherPutWatchRequest, value: CoreTypes.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("throttlePeriod")>]
        member _.ThrottlePeriod(state: WatcherPutWatchRequest, value: CoreTypes.Duration) =
            { state with ThrottlePeriod = Some value }

        [<CustomOperation("throttlePeriodInMillis")>]
        member _.ThrottlePeriodInMillis(state: WatcherPutWatchRequest, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with ThrottlePeriodInMillis = Some value }

        [<CustomOperation("transform")>]
        member _.Transform(state: WatcherPutWatchRequest, value: CoreTypes.TransformContainer) =
            { state with Transform = Some value }

        [<CustomOperation("trigger")>]
        member _.Trigger(state: WatcherPutWatchRequest, value: WatcherTypes.TriggerContainer) =
            { state with Trigger = Some value }

    let watcherPutWatchRequest = WatcherPutWatchRequestBuilder()

    module PutWatch =
        let withActive (value: bool) (req: WatcherPutWatchRequest) =
            { req with Active = Some value }
        let withIfPrimaryTerm (value: CoreTypes.Long) (req: WatcherPutWatchRequest) =
            { req with IfPrimaryTerm = Some value }
        let withIfSeqNo (value: CoreTypes.SequenceNumber) (req: WatcherPutWatchRequest) =
            { req with IfSeqNo = Some value }
        let withVersion (value: CoreTypes.VersionNumber) (req: WatcherPutWatchRequest) =
            { req with Version = Some value }
        let withActions (value: Map<string, WatcherTypes.Action>) (req: WatcherPutWatchRequest) =
            { req with Actions = Some value }
        let withCondition (value: WatcherTypes.ConditionContainer) (req: WatcherPutWatchRequest) =
            { req with Condition = Some value }
        let withInput (value: WatcherTypes.InputContainer) (req: WatcherPutWatchRequest) =
            { req with Input = Some value }
        let withMetadata (value: CoreTypes.Metadata) (req: WatcherPutWatchRequest) =
            { req with Metadata = Some value }
        let withThrottlePeriod (value: CoreTypes.Duration) (req: WatcherPutWatchRequest) =
            { req with ThrottlePeriod = Some value }
        let withThrottlePeriodInMillis (value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) (req: WatcherPutWatchRequest) =
            { req with ThrottlePeriodInMillis = Some value }
        let withTransform (value: CoreTypes.TransformContainer) (req: WatcherPutWatchRequest) =
            { req with Transform = Some value }
        let withTrigger (value: WatcherTypes.TriggerContainer) (req: WatcherPutWatchRequest) =
            { req with Trigger = Some value }

    type WatcherQueryWatchesRequest = {
        From: CoreTypes.Integer option
        Size: CoreTypes.Integer option
        Query: CoreTypes.QueryContainer option
        Sort: CoreTypes.Sort option
        SearchAfter: CoreTypes.SortResults option
    }

        with
        static member ToRequest(req: WatcherQueryWatchesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_watcher/_query/watches"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type WatcherQueryWatchesResponse = System.Text.Json.JsonElement

    type WatcherQueryWatchesRequestBuilder() =
        member _.Yield(_: unit) : WatcherQueryWatchesRequest =
            {
                From = None
                Size = None
                Query = None
                Sort = None
                SearchAfter = None
            }

        [<CustomOperation("from")>]
        member _.From(state: WatcherQueryWatchesRequest, value: CoreTypes.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: WatcherQueryWatchesRequest, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: WatcherQueryWatchesRequest, value: CoreTypes.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: WatcherQueryWatchesRequest, value: CoreTypes.Sort) =
            { state with Sort = Some value }

        [<CustomOperation("searchAfter")>]
        member _.SearchAfter(state: WatcherQueryWatchesRequest, value: CoreTypes.SortResults) =
            { state with SearchAfter = Some value }

    let watcherQueryWatchesRequest = WatcherQueryWatchesRequestBuilder()

    module QueryWatches =
        let withFrom (value: CoreTypes.Integer) (req: WatcherQueryWatchesRequest) =
            { req with From = Some value }
        let withSize (value: CoreTypes.Integer) (req: WatcherQueryWatchesRequest) =
            { req with Size = Some value }
        let withQuery (value: CoreTypes.QueryContainer) (req: WatcherQueryWatchesRequest) =
            { req with Query = Some value }
        let withSort (value: CoreTypes.Sort) (req: WatcherQueryWatchesRequest) =
            { req with Sort = Some value }
        let withSearchAfter (value: CoreTypes.SortResults) (req: WatcherQueryWatchesRequest) =
            { req with SearchAfter = Some value }

    type WatcherStartRequest = {
        MasterTimeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: WatcherStartRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_watcher/_start"
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

    type WatcherStartResponse = CoreTypes.AcknowledgedResponseBase

    type WatcherStartRequestBuilder() =
        member _.Yield(_: unit) : WatcherStartRequest =
            {
                MasterTimeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: WatcherStartRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

    let watcherStartRequest = WatcherStartRequestBuilder()

    module Start =
        let withMasterTimeout (value: CoreTypes.Duration) (req: WatcherStartRequest) =
            { req with MasterTimeout = Some value }

    type WatcherStatsRequest = {
        Metric: System.Text.Json.JsonElement
        EmitStacktraces: bool option
        Metric: System.Text.Json.JsonElement option
    }

        with
        static member ToRequest(req: WatcherStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_watcher/stats/{req.Metric}"
                let queryParams =
                    [
                        req.EmitStacktraces |> Option.map (fun v -> "emit_stacktraces", Fes.Http.toQueryValue v)
                        req.Metric |> Option.map (fun v -> "metric", Fes.Http.toQueryValue v)
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

    type WatcherStatsResponse = System.Text.Json.JsonElement

    type WatcherStatsRequestBuilder() =
        member _.Yield(_: unit) : WatcherStatsRequest =
            {
                Metric = Unchecked.defaultof<_>
                EmitStacktraces = None
                Metric = None
            }

        [<CustomOperation("metric")>]
        member _.Metric(state: WatcherStatsRequest, value: System.Text.Json.JsonElement) =
            { state with Metric = value }

        [<CustomOperation("emitStacktraces")>]
        member _.EmitStacktraces(state: WatcherStatsRequest, value: bool) =
            { state with EmitStacktraces = Some value }

        [<CustomOperation("metric")>]
        member _.Metric(state: WatcherStatsRequest, value: System.Text.Json.JsonElement) =
            { state with Metric = Some value }

    let watcherStatsRequest = WatcherStatsRequestBuilder()

    module Stats =
        let withEmitStacktraces (value: bool) (req: WatcherStatsRequest) =
            { req with EmitStacktraces = Some value }
        let withMetric (value: System.Text.Json.JsonElement) (req: WatcherStatsRequest) =
            { req with Metric = Some value }

    type WatcherStopRequest = {
        MasterTimeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: WatcherStopRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_watcher/_stop"
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

    type WatcherStopResponse = CoreTypes.AcknowledgedResponseBase

    type WatcherStopRequestBuilder() =
        member _.Yield(_: unit) : WatcherStopRequest =
            {
                MasterTimeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: WatcherStopRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

    let watcherStopRequest = WatcherStopRequestBuilder()

    module Stop =
        let withMasterTimeout (value: CoreTypes.Duration) (req: WatcherStopRequest) =
            { req with MasterTimeout = Some value }

    type WatcherUpdateSettingsRequest = {
        MasterTimeout: CoreTypes.Duration option
        Timeout: CoreTypes.Duration option
        IndexAutoExpandReplicas: string option
        IndexNumberOfReplicas: CoreTypes.Integer option
    }

        with
        static member ToRequest(req: WatcherUpdateSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_watcher/settings"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type WatcherUpdateSettingsResponse = System.Text.Json.JsonElement

    type WatcherUpdateSettingsRequestBuilder() =
        member _.Yield(_: unit) : WatcherUpdateSettingsRequest =
            {
                MasterTimeout = None
                Timeout = None
                IndexAutoExpandReplicas = None
                IndexNumberOfReplicas = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: WatcherUpdateSettingsRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: WatcherUpdateSettingsRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("indexAutoExpandReplicas")>]
        member _.IndexAutoExpandReplicas(state: WatcherUpdateSettingsRequest, value: string) =
            { state with IndexAutoExpandReplicas = Some value }

        [<CustomOperation("indexNumberOfReplicas")>]
        member _.IndexNumberOfReplicas(state: WatcherUpdateSettingsRequest, value: CoreTypes.Integer) =
            { state with IndexNumberOfReplicas = Some value }

    let watcherUpdateSettingsRequest = WatcherUpdateSettingsRequestBuilder()

    module UpdateSettings =
        let withMasterTimeout (value: CoreTypes.Duration) (req: WatcherUpdateSettingsRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: WatcherUpdateSettingsRequest) =
            { req with Timeout = Some value }
        let withIndexAutoExpandReplicas (value: string) (req: WatcherUpdateSettingsRequest) =
            { req with IndexAutoExpandReplicas = Some value }
        let withIndexNumberOfReplicas (value: CoreTypes.Integer) (req: WatcherUpdateSettingsRequest) =
            { req with IndexNumberOfReplicas = Some value }


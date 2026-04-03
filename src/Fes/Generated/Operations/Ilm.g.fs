// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module IlmOperations =

    type IlmDeleteLifecycleRequest = {
        Policy: Types.Name
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: IlmDeleteLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ilm/policy/{req.Policy}"
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

    type IlmDeleteLifecycleResponse = Types.AcknowledgedResponseBase

    type IlmDeleteLifecycleRequestBuilder() =
        member _.Yield(_: unit) : IlmDeleteLifecycleRequest =
            {
                Policy = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("policy")>]
        member _.Policy(state: IlmDeleteLifecycleRequest, value: Types.Name) =
            { state with Policy = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IlmDeleteLifecycleRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IlmDeleteLifecycleRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let ilmDeleteLifecycleRequest = IlmDeleteLifecycleRequestBuilder()

    module DeleteLifecycle =
        let withMasterTimeout (value: Types.Duration) (req: IlmDeleteLifecycleRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IlmDeleteLifecycleRequest) =
            { req with Timeout = Some value }

    type IlmExplainLifecycleRequest = {
        Index: Types.IndexName
        OnlyErrors: bool option
        OnlyManaged: bool option
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: IlmExplainLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_ilm/explain"
                let queryParams =
                    [
                        req.OnlyErrors |> Option.map (fun v -> "only_errors", Fes.Http.toQueryValue v)
                        req.OnlyManaged |> Option.map (fun v -> "only_managed", Fes.Http.toQueryValue v)
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

    type IlmExplainLifecycleResponse = System.Text.Json.JsonElement

    type IlmExplainLifecycleRequestBuilder() =
        member _.Yield(_: unit) : IlmExplainLifecycleRequest =
            {
                Index = Unchecked.defaultof<_>
                OnlyErrors = None
                OnlyManaged = None
                MasterTimeout = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IlmExplainLifecycleRequest, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("onlyErrors")>]
        member _.OnlyErrors(state: IlmExplainLifecycleRequest, value: bool) =
            { state with OnlyErrors = Some value }

        [<CustomOperation("onlyManaged")>]
        member _.OnlyManaged(state: IlmExplainLifecycleRequest, value: bool) =
            { state with OnlyManaged = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IlmExplainLifecycleRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let ilmExplainLifecycleRequest = IlmExplainLifecycleRequestBuilder()

    module ExplainLifecycle =
        let withOnlyErrors (value: bool) (req: IlmExplainLifecycleRequest) =
            { req with OnlyErrors = Some value }
        let withOnlyManaged (value: bool) (req: IlmExplainLifecycleRequest) =
            { req with OnlyManaged = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IlmExplainLifecycleRequest) =
            { req with MasterTimeout = Some value }

    type IlmGetLifecycleRequest = {
        Policy: Types.Name
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: IlmGetLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ilm/policy/{req.Policy}"
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

    type IlmGetLifecycleResponse = Map<string, IlmGetLifecycle.Lifecycle>

    type IlmGetLifecycleRequestBuilder() =
        member _.Yield(_: unit) : IlmGetLifecycleRequest =
            {
                Policy = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("policy")>]
        member _.Policy(state: IlmGetLifecycleRequest, value: Types.Name) =
            { state with Policy = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IlmGetLifecycleRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IlmGetLifecycleRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let ilmGetLifecycleRequest = IlmGetLifecycleRequestBuilder()

    module GetLifecycle =
        let withMasterTimeout (value: Types.Duration) (req: IlmGetLifecycleRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IlmGetLifecycleRequest) =
            { req with Timeout = Some value }

    type IlmGetStatusRequest = | IlmGetStatusRequest

        with
        static member ToRequest(req: IlmGetStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ilm/status"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type IlmGetStatusResponse = System.Text.Json.JsonElement

    type IlmGetStatusRequestBuilder() =
        member _.Yield(_: unit) : IlmGetStatusRequest =
            {
            }

    let ilmGetStatusRequest = IlmGetStatusRequestBuilder()

    type IlmMigrateToDataTiersRequest = {
        DryRun: bool option
        MasterTimeout: Types.Duration option
        LegacyTemplateToDelete: string option
        NodeAttribute: string option
    }

        with
        static member ToRequest(req: IlmMigrateToDataTiersRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ilm/migrate_to_data_tiers"
                let queryParams =
                    [
                        req.DryRun |> Option.map (fun v -> "dry_run", Fes.Http.toQueryValue v)
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

    type IlmMigrateToDataTiersResponse = System.Text.Json.JsonElement

    type IlmMigrateToDataTiersRequestBuilder() =
        member _.Yield(_: unit) : IlmMigrateToDataTiersRequest =
            {
                DryRun = None
                MasterTimeout = None
                LegacyTemplateToDelete = None
                NodeAttribute = None
            }

        [<CustomOperation("dryRun")>]
        member _.DryRun(state: IlmMigrateToDataTiersRequest, value: bool) =
            { state with DryRun = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IlmMigrateToDataTiersRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("legacyTemplateToDelete")>]
        member _.LegacyTemplateToDelete(state: IlmMigrateToDataTiersRequest, value: string) =
            { state with LegacyTemplateToDelete = Some value }

        [<CustomOperation("nodeAttribute")>]
        member _.NodeAttribute(state: IlmMigrateToDataTiersRequest, value: string) =
            { state with NodeAttribute = Some value }

    let ilmMigrateToDataTiersRequest = IlmMigrateToDataTiersRequestBuilder()

    module MigrateToDataTiers =
        let withDryRun (value: bool) (req: IlmMigrateToDataTiersRequest) =
            { req with DryRun = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IlmMigrateToDataTiersRequest) =
            { req with MasterTimeout = Some value }
        let withLegacyTemplateToDelete (value: string) (req: IlmMigrateToDataTiersRequest) =
            { req with LegacyTemplateToDelete = Some value }
        let withNodeAttribute (value: string) (req: IlmMigrateToDataTiersRequest) =
            { req with NodeAttribute = Some value }

    type IlmMoveToStepRequest = {
        Index: Types.IndexName
        CurrentStep: IlmMoveToStep.StepKey
        NextStep: IlmMoveToStep.StepKey
    }

        with
        static member ToRequest(req: IlmMoveToStepRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ilm/move/{req.Index}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type IlmMoveToStepResponse = Types.AcknowledgedResponseBase

    type IlmMoveToStepRequestBuilder() =
        member _.Yield(_: unit) : IlmMoveToStepRequest =
            {
                Index = Unchecked.defaultof<_>
                CurrentStep = Unchecked.defaultof<_>
                NextStep = Unchecked.defaultof<_>
            }

        [<CustomOperation("index")>]
        member _.Index(state: IlmMoveToStepRequest, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("currentStep")>]
        member _.CurrentStep(state: IlmMoveToStepRequest, value: IlmMoveToStep.StepKey) =
            { state with CurrentStep = value }

        [<CustomOperation("nextStep")>]
        member _.NextStep(state: IlmMoveToStepRequest, value: IlmMoveToStep.StepKey) =
            { state with NextStep = value }

    let ilmMoveToStepRequest = IlmMoveToStepRequestBuilder()

    module MoveToStep =
        let withCurrentStep (value: IlmMoveToStep.StepKey) (req: IlmMoveToStepRequest) =
            { req with CurrentStep = value }
        let withNextStep (value: IlmMoveToStep.StepKey) (req: IlmMoveToStepRequest) =
            { req with NextStep = value }

    type IlmPutLifecycleRequest = {
        Policy: Types.Name
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        Policy: IlmTypes.Policy option
    }

        with
        static member ToRequest(req: IlmPutLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ilm/policy/{req.Policy}"
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

    type IlmPutLifecycleResponse = Types.AcknowledgedResponseBase

    type IlmPutLifecycleRequestBuilder() =
        member _.Yield(_: unit) : IlmPutLifecycleRequest =
            {
                Policy = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
                Policy = None
            }

        [<CustomOperation("policy")>]
        member _.Policy(state: IlmPutLifecycleRequest, value: Types.Name) =
            { state with Policy = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IlmPutLifecycleRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IlmPutLifecycleRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("policy")>]
        member _.Policy(state: IlmPutLifecycleRequest, value: IlmTypes.Policy) =
            { state with Policy = Some value }

    let ilmPutLifecycleRequest = IlmPutLifecycleRequestBuilder()

    module PutLifecycle =
        let withMasterTimeout (value: Types.Duration) (req: IlmPutLifecycleRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IlmPutLifecycleRequest) =
            { req with Timeout = Some value }
        let withPolicy (value: IlmTypes.Policy) (req: IlmPutLifecycleRequest) =
            { req with Policy = Some value }

    type IlmRemovePolicyRequest = {
        Index: Types.IndexName
    }

        with
        static member ToRequest(req: IlmRemovePolicyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_ilm/remove"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type IlmRemovePolicyResponse = System.Text.Json.JsonElement

    type IlmRemovePolicyRequestBuilder() =
        member _.Yield(_: unit) : IlmRemovePolicyRequest =
            {
                Index = Unchecked.defaultof<_>
            }

        [<CustomOperation("index")>]
        member _.Index(state: IlmRemovePolicyRequest, value: Types.IndexName) =
            { state with Index = value }

    let ilmRemovePolicyRequest = IlmRemovePolicyRequestBuilder()

    type IlmRetryRequest = {
        Index: Types.IndexName
    }

        with
        static member ToRequest(req: IlmRetryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_ilm/retry"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type IlmRetryResponse = Types.AcknowledgedResponseBase

    type IlmRetryRequestBuilder() =
        member _.Yield(_: unit) : IlmRetryRequest =
            {
                Index = Unchecked.defaultof<_>
            }

        [<CustomOperation("index")>]
        member _.Index(state: IlmRetryRequest, value: Types.IndexName) =
            { state with Index = value }

    let ilmRetryRequest = IlmRetryRequestBuilder()

    type IlmStartRequest = {
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: IlmStartRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ilm/start"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type IlmStartResponse = Types.AcknowledgedResponseBase

    type IlmStartRequestBuilder() =
        member _.Yield(_: unit) : IlmStartRequest =
            {
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IlmStartRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IlmStartRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let ilmStartRequest = IlmStartRequestBuilder()

    module Start =
        let withMasterTimeout (value: Types.Duration) (req: IlmStartRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IlmStartRequest) =
            { req with Timeout = Some value }

    type IlmStopRequest = {
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: IlmStopRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ilm/stop"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type IlmStopResponse = Types.AcknowledgedResponseBase

    type IlmStopRequestBuilder() =
        member _.Yield(_: unit) : IlmStopRequest =
            {
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IlmStopRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IlmStopRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let ilmStopRequest = IlmStopRequestBuilder()

    module Stop =
        let withMasterTimeout (value: Types.Duration) (req: IlmStopRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IlmStopRequest) =
            { req with Timeout = Some value }


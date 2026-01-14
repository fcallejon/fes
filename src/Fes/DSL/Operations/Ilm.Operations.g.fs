// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module IlmOperations =

    type IlmGetLifecycleRequest = {
        Policy: Name
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: IlmGetLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ilm/policy/{request.Policy}"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module IlmGetLifecycleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IlmGetLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            IlmGetLifecycleRequest.ToRequest request

    type IlmGetLifecycleRequestBuilder() =
        member _.Yield(_: unit) : IlmGetLifecycleRequest =
            {
                IlmGetLifecycleRequest.Policy = Unchecked.defaultof<Name>
                IlmGetLifecycleRequest.MasterTimeout = Option.None
                IlmGetLifecycleRequest.Timeout = Option.None
            } : IlmGetLifecycleRequest

        [<CustomOperation("policy")>]
        member _.Policy(state: IlmGetLifecycleRequest, value: Name) =
            { state with IlmGetLifecycleRequest.Policy = value } : IlmGetLifecycleRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IlmGetLifecycleRequest, value: Duration) =
            { state with IlmGetLifecycleRequest.MasterTimeout = Option.Some value } : IlmGetLifecycleRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IlmGetLifecycleRequest, value: Duration) =
            { state with IlmGetLifecycleRequest.Timeout = Option.Some value } : IlmGetLifecycleRequest

    let ilmGetLifecycleRequest = IlmGetLifecycleRequestBuilder()

    type IlmPutLifecycleRequest = {
        Policy: Name
        MasterTimeout: Duration option
        Timeout: Duration option
        [<JsonPropertyName("policy")>]
        BodyPolicy: TypesPolicy option
    } with
        static member ToRequest(request: IlmPutLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ilm/policy/{request.Policy}"
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
                |> Fes.Http.Request.withJsonBody {| ``policy`` = request.BodyPolicy |}
                |> Result.Ok
            with ex -> Result.Error ex

    module IlmPutLifecycleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IlmPutLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            IlmPutLifecycleRequest.ToRequest request

    type IlmPutLifecycleRequestBuilder() =
        member _.Yield(_: unit) : IlmPutLifecycleRequest =
            {
                IlmPutLifecycleRequest.Policy = Unchecked.defaultof<Name>
                IlmPutLifecycleRequest.MasterTimeout = Option.None
                IlmPutLifecycleRequest.Timeout = Option.None
                IlmPutLifecycleRequest.BodyPolicy = Option.None
            } : IlmPutLifecycleRequest

        [<CustomOperation("policy")>]
        member _.Policy(state: IlmPutLifecycleRequest, value: Name) =
            { state with IlmPutLifecycleRequest.Policy = value } : IlmPutLifecycleRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IlmPutLifecycleRequest, value: Duration) =
            { state with IlmPutLifecycleRequest.MasterTimeout = Option.Some value } : IlmPutLifecycleRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IlmPutLifecycleRequest, value: Duration) =
            { state with IlmPutLifecycleRequest.Timeout = Option.Some value } : IlmPutLifecycleRequest

        [<CustomOperation("body_policy")>]
        member _.BodyPolicy(state: IlmPutLifecycleRequest, value: TypesPolicy) =
            { state with IlmPutLifecycleRequest.BodyPolicy = Option.Some value } : IlmPutLifecycleRequest

    let ilmPutLifecycleRequest = IlmPutLifecycleRequestBuilder()

    type IlmPutLifecycleResponse = AcknowledgedResponseBase

    type IlmDeleteLifecycleRequest = {
        Policy: Name
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: IlmDeleteLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ilm/policy/{request.Policy}"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module IlmDeleteLifecycleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IlmDeleteLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            IlmDeleteLifecycleRequest.ToRequest request

    type IlmDeleteLifecycleRequestBuilder() =
        member _.Yield(_: unit) : IlmDeleteLifecycleRequest =
            {
                IlmDeleteLifecycleRequest.Policy = Unchecked.defaultof<Name>
                IlmDeleteLifecycleRequest.MasterTimeout = Option.None
                IlmDeleteLifecycleRequest.Timeout = Option.None
            } : IlmDeleteLifecycleRequest

        [<CustomOperation("policy")>]
        member _.Policy(state: IlmDeleteLifecycleRequest, value: Name) =
            { state with IlmDeleteLifecycleRequest.Policy = value } : IlmDeleteLifecycleRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IlmDeleteLifecycleRequest, value: Duration) =
            { state with IlmDeleteLifecycleRequest.MasterTimeout = Option.Some value } : IlmDeleteLifecycleRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IlmDeleteLifecycleRequest, value: Duration) =
            { state with IlmDeleteLifecycleRequest.Timeout = Option.Some value } : IlmDeleteLifecycleRequest

    let ilmDeleteLifecycleRequest = IlmDeleteLifecycleRequestBuilder()

    type IlmDeleteLifecycleResponse = AcknowledgedResponseBase

    type IlmExplainLifecycleRequest = {
        Index: IndexName
        OnlyErrors: bool option
        OnlyManaged: bool option
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: IlmExplainLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_ilm/explain"
                let queryParams =
                    [
                        request.OnlyErrors |> Option.map (fun v -> "only_errors", Fes.Http.toQueryValue v)
                        request.OnlyManaged |> Option.map (fun v -> "only_managed", Fes.Http.toQueryValue v)
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

    module IlmExplainLifecycleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IlmExplainLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            IlmExplainLifecycleRequest.ToRequest request

    type IlmExplainLifecycleRequestBuilder() =
        member _.Yield(_: unit) : IlmExplainLifecycleRequest =
            {
                IlmExplainLifecycleRequest.Index = Unchecked.defaultof<IndexName>
                IlmExplainLifecycleRequest.OnlyErrors = Option.None
                IlmExplainLifecycleRequest.OnlyManaged = Option.None
                IlmExplainLifecycleRequest.MasterTimeout = Option.None
            } : IlmExplainLifecycleRequest

        [<CustomOperation("index")>]
        member _.Index(state: IlmExplainLifecycleRequest, value: IndexName) =
            { state with IlmExplainLifecycleRequest.Index = value } : IlmExplainLifecycleRequest

        [<CustomOperation("only_errors")>]
        member _.OnlyErrors(state: IlmExplainLifecycleRequest, value: bool) =
            { state with IlmExplainLifecycleRequest.OnlyErrors = Option.Some value } : IlmExplainLifecycleRequest

        [<CustomOperation("only_managed")>]
        member _.OnlyManaged(state: IlmExplainLifecycleRequest, value: bool) =
            { state with IlmExplainLifecycleRequest.OnlyManaged = Option.Some value } : IlmExplainLifecycleRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IlmExplainLifecycleRequest, value: Duration) =
            { state with IlmExplainLifecycleRequest.MasterTimeout = Option.Some value } : IlmExplainLifecycleRequest

    let ilmExplainLifecycleRequest = IlmExplainLifecycleRequestBuilder()

    type IlmExplainLifecycleResponse = {
        [<JsonPropertyName("indices")>]
        Indices: Map<string, ExplainLifecycleLifecycleExplain>
    }

    type IlmGetStatusRequest = unit

    let ilmGetStatusRequest = ()

    type IlmGetStatusResponse = {
        [<JsonPropertyName("operation_mode")>]
        OperationMode: LifecycleOperationMode
    }

    type IlmMigrateToDataTiersRequest = {
        DryRun: bool option
        MasterTimeout: Duration option
        [<JsonPropertyName("legacy_template_to_delete")>]
        LegacyTemplateToDelete: string option
        [<JsonPropertyName("node_attribute")>]
        NodeAttribute: string option
    } with
        static member ToRequest(request: IlmMigrateToDataTiersRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_ilm/migrate_to_data_tiers"
                let queryParams =
                    [
                        request.DryRun |> Option.map (fun v -> "dry_run", Fes.Http.toQueryValue v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``legacy_template_to_delete`` = request.LegacyTemplateToDelete; ``node_attribute`` = request.NodeAttribute |}
                |> Result.Ok
            with ex -> Result.Error ex

    module IlmMigrateToDataTiersRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IlmMigrateToDataTiersRequest) : Result<Fes.Http.RequestMsg, exn> =
            IlmMigrateToDataTiersRequest.ToRequest request

    type IlmMigrateToDataTiersRequestBuilder() =
        member _.Yield(_: unit) : IlmMigrateToDataTiersRequest =
            {
                IlmMigrateToDataTiersRequest.DryRun = Option.None
                IlmMigrateToDataTiersRequest.MasterTimeout = Option.None
                IlmMigrateToDataTiersRequest.LegacyTemplateToDelete = Option.None
                IlmMigrateToDataTiersRequest.NodeAttribute = Option.None
            } : IlmMigrateToDataTiersRequest

        [<CustomOperation("dry_run")>]
        member _.DryRun(state: IlmMigrateToDataTiersRequest, value: bool) =
            { state with IlmMigrateToDataTiersRequest.DryRun = Option.Some value } : IlmMigrateToDataTiersRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IlmMigrateToDataTiersRequest, value: Duration) =
            { state with IlmMigrateToDataTiersRequest.MasterTimeout = Option.Some value } : IlmMigrateToDataTiersRequest

        [<CustomOperation("legacy_template_to_delete")>]
        member _.LegacyTemplateToDelete(state: IlmMigrateToDataTiersRequest, value: string) =
            { state with IlmMigrateToDataTiersRequest.LegacyTemplateToDelete = Option.Some value } : IlmMigrateToDataTiersRequest

        [<CustomOperation("node_attribute")>]
        member _.NodeAttribute(state: IlmMigrateToDataTiersRequest, value: string) =
            { state with IlmMigrateToDataTiersRequest.NodeAttribute = Option.Some value } : IlmMigrateToDataTiersRequest

    let ilmMigrateToDataTiersRequest = IlmMigrateToDataTiersRequestBuilder()

    type IlmMigrateToDataTiersResponse = {
        [<JsonPropertyName("dry_run")>]
        DryRun: bool
        [<JsonPropertyName("removed_legacy_template")>]
        RemovedLegacyTemplate: string
        [<JsonPropertyName("migrated_ilm_policies")>]
        MigratedIlmPolicies: string array
        [<JsonPropertyName("migrated_indices")>]
        MigratedIndices: Indices
        [<JsonPropertyName("migrated_legacy_templates")>]
        MigratedLegacyTemplates: string array
        [<JsonPropertyName("migrated_composable_templates")>]
        MigratedComposableTemplates: string array
        [<JsonPropertyName("migrated_component_templates")>]
        MigratedComponentTemplates: string array
    }

    type IlmMoveToStepRequest = {
        Index: IndexName
        [<JsonPropertyName("current_step")>]
        CurrentStep: MoveToStepStepKey
        [<JsonPropertyName("next_step")>]
        NextStep: MoveToStepStepKey
    } with
        static member ToRequest(request: IlmMoveToStepRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ilm/move/{request.Index}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``current_step`` = request.CurrentStep; ``next_step`` = request.NextStep |}
                |> Result.Ok
            with ex -> Result.Error ex

    module IlmMoveToStepRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IlmMoveToStepRequest) : Result<Fes.Http.RequestMsg, exn> =
            IlmMoveToStepRequest.ToRequest request

    type IlmMoveToStepRequestBuilder() =
        member _.Yield(_: unit) : IlmMoveToStepRequest =
            {
                IlmMoveToStepRequest.Index = Unchecked.defaultof<IndexName>
                IlmMoveToStepRequest.CurrentStep = Unchecked.defaultof<MoveToStepStepKey>
                IlmMoveToStepRequest.NextStep = Unchecked.defaultof<MoveToStepStepKey>
            } : IlmMoveToStepRequest

        [<CustomOperation("index")>]
        member _.Index(state: IlmMoveToStepRequest, value: IndexName) =
            { state with IlmMoveToStepRequest.Index = value } : IlmMoveToStepRequest

        [<CustomOperation("current_step")>]
        member _.CurrentStep(state: IlmMoveToStepRequest, value: MoveToStepStepKey) =
            { state with IlmMoveToStepRequest.CurrentStep = value } : IlmMoveToStepRequest

        [<CustomOperation("next_step")>]
        member _.NextStep(state: IlmMoveToStepRequest, value: MoveToStepStepKey) =
            { state with IlmMoveToStepRequest.NextStep = value } : IlmMoveToStepRequest

    let ilmMoveToStepRequest = IlmMoveToStepRequestBuilder()

    type IlmMoveToStepResponse = AcknowledgedResponseBase

    type IlmRemovePolicyRequest = {
        Index: IndexName
    } with
        static member ToRequest(request: IlmRemovePolicyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_ilm/remove"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module IlmRemovePolicyRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IlmRemovePolicyRequest) : Result<Fes.Http.RequestMsg, exn> =
            IlmRemovePolicyRequest.ToRequest request

    type IlmRemovePolicyRequestBuilder() =
        member _.Yield(_: unit) : IlmRemovePolicyRequest =
            {
                IlmRemovePolicyRequest.Index = Unchecked.defaultof<IndexName>
            } : IlmRemovePolicyRequest

        [<CustomOperation("index")>]
        member _.Index(state: IlmRemovePolicyRequest, value: IndexName) =
            { state with IlmRemovePolicyRequest.Index = value } : IlmRemovePolicyRequest

    let ilmRemovePolicyRequest = IlmRemovePolicyRequestBuilder()

    type IlmRemovePolicyResponse = {
        [<JsonPropertyName("failed_indexes")>]
        FailedIndexes: IndexName array
        [<JsonPropertyName("has_failures")>]
        HasFailures: bool
    }

    type IlmRetryRequest = {
        Index: IndexName
    } with
        static member ToRequest(request: IlmRetryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_ilm/retry"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module IlmRetryRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IlmRetryRequest) : Result<Fes.Http.RequestMsg, exn> =
            IlmRetryRequest.ToRequest request

    type IlmRetryRequestBuilder() =
        member _.Yield(_: unit) : IlmRetryRequest =
            {
                IlmRetryRequest.Index = Unchecked.defaultof<IndexName>
            } : IlmRetryRequest

        [<CustomOperation("index")>]
        member _.Index(state: IlmRetryRequest, value: IndexName) =
            { state with IlmRetryRequest.Index = value } : IlmRetryRequest

    let ilmRetryRequest = IlmRetryRequestBuilder()

    type IlmRetryResponse = AcknowledgedResponseBase

    type IlmStartRequest = {
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: IlmStartRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_ilm/start"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module IlmStartRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IlmStartRequest) : Result<Fes.Http.RequestMsg, exn> =
            IlmStartRequest.ToRequest request

    type IlmStartRequestBuilder() =
        member _.Yield(_: unit) : IlmStartRequest =
            {
                IlmStartRequest.MasterTimeout = Option.None
                IlmStartRequest.Timeout = Option.None
            } : IlmStartRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IlmStartRequest, value: Duration) =
            { state with IlmStartRequest.MasterTimeout = Option.Some value } : IlmStartRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IlmStartRequest, value: Duration) =
            { state with IlmStartRequest.Timeout = Option.Some value } : IlmStartRequest

    let ilmStartRequest = IlmStartRequestBuilder()

    type IlmStartResponse = AcknowledgedResponseBase

    type IlmStopRequest = {
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: IlmStopRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_ilm/stop"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module IlmStopRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IlmStopRequest) : Result<Fes.Http.RequestMsg, exn> =
            IlmStopRequest.ToRequest request

    type IlmStopRequestBuilder() =
        member _.Yield(_: unit) : IlmStopRequest =
            {
                IlmStopRequest.MasterTimeout = Option.None
                IlmStopRequest.Timeout = Option.None
            } : IlmStopRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IlmStopRequest, value: Duration) =
            { state with IlmStopRequest.MasterTimeout = Option.Some value } : IlmStopRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IlmStopRequest, value: Duration) =
            { state with IlmStopRequest.Timeout = Option.Some value } : IlmStopRequest

    let ilmStopRequest = IlmStopRequestBuilder()

    type IlmStopResponse = AcknowledgedResponseBase


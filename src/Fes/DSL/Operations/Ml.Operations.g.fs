// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module MlOperations =

    type MlGetMemoryStatsRequest = {
        [<JsonPropertyName("node_id")>]
        NodeId: Id
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
    } with
        static member ToRequest(request: MlGetMemoryStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/memory/{request.NodeId}/_stats"
                let queryParams =
                    [
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

    module MlGetMemoryStatsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlGetMemoryStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlGetMemoryStatsRequest.ToRequest request

    type MlGetMemoryStatsRequestBuilder() =
        member _.Yield(_: unit) : MlGetMemoryStatsRequest =
            {
                MlGetMemoryStatsRequest.NodeId = Unchecked.defaultof<Id>
                MlGetMemoryStatsRequest.MasterTimeout = Option.None
                MlGetMemoryStatsRequest.Timeout = Option.None
            } : MlGetMemoryStatsRequest

        [<CustomOperation("node_id")>]
        member _.NodeId(state: MlGetMemoryStatsRequest, value: Id) =
            { state with MlGetMemoryStatsRequest.NodeId = value } : MlGetMemoryStatsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: MlGetMemoryStatsRequest, value: Duration) =
            { state with MlGetMemoryStatsRequest.MasterTimeout = Option.Some value } : MlGetMemoryStatsRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlGetMemoryStatsRequest, value: Duration) =
            { state with MlGetMemoryStatsRequest.Timeout = Option.Some value } : MlGetMemoryStatsRequest

    let mlGetMemoryStatsRequest = MlGetMemoryStatsRequestBuilder()

    type MlInfoRequest = unit

    let mlInfoRequest = ()

    type MlInfoResponse = {
        [<JsonPropertyName("defaults")>]
        Defaults: InfoDefaults
        [<JsonPropertyName("limits")>]
        Limits: InfoLimits
        [<JsonPropertyName("upgrade_mode")>]
        UpgradeMode: bool
        [<JsonPropertyName("native_code")>]
        NativeCode: InfoNativeCode
    }

    type MlSetUpgradeModeRequest = {
        [<JsonPropertyName("enabled")>]
        Enabled: bool option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
    } with
        static member ToRequest(request: MlSetUpgradeModeRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_ml/set_upgrade_mode"
                let queryParams =
                    [
                        request.Enabled |> Option.map (fun v -> "enabled", string v)
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

    module MlSetUpgradeModeRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlSetUpgradeModeRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlSetUpgradeModeRequest.ToRequest request

    type MlSetUpgradeModeRequestBuilder() =
        member _.Yield(_: unit) : MlSetUpgradeModeRequest =
            {
                MlSetUpgradeModeRequest.Enabled = Option.None
                MlSetUpgradeModeRequest.Timeout = Option.None
            } : MlSetUpgradeModeRequest

        [<CustomOperation("enabled")>]
        member _.Enabled(state: MlSetUpgradeModeRequest, value: bool) =
            { state with MlSetUpgradeModeRequest.Enabled = Option.Some value } : MlSetUpgradeModeRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlSetUpgradeModeRequest, value: Duration) =
            { state with MlSetUpgradeModeRequest.Timeout = Option.Some value } : MlSetUpgradeModeRequest

    let mlSetUpgradeModeRequest = MlSetUpgradeModeRequestBuilder()

    type MlSetUpgradeModeResponse = AcknowledgedResponseBase


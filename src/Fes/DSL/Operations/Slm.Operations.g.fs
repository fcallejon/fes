// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module SlmOperations =

    type SlmGetLifecycleRequest = {
        PolicyId: Names
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: SlmGetLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_slm/policy/{request.PolicyId}"
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

    module SlmGetLifecycleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SlmGetLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            SlmGetLifecycleRequest.ToRequest request

    type SlmGetLifecycleRequestBuilder() =
        member _.Yield(_: unit) : SlmGetLifecycleRequest =
            {
                SlmGetLifecycleRequest.PolicyId = Unchecked.defaultof<Names>
                SlmGetLifecycleRequest.MasterTimeout = Option.None
                SlmGetLifecycleRequest.Timeout = Option.None
            } : SlmGetLifecycleRequest

        [<CustomOperation("policy_id")>]
        member _.PolicyId(state: SlmGetLifecycleRequest, value: Names) =
            { state with SlmGetLifecycleRequest.PolicyId = value } : SlmGetLifecycleRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SlmGetLifecycleRequest, value: Duration) =
            { state with SlmGetLifecycleRequest.MasterTimeout = Option.Some value } : SlmGetLifecycleRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmGetLifecycleRequest, value: Duration) =
            { state with SlmGetLifecycleRequest.Timeout = Option.Some value } : SlmGetLifecycleRequest

    let slmGetLifecycleRequest = SlmGetLifecycleRequestBuilder()

    type SlmPutLifecycleRequest = {
        PolicyId: Name
        MasterTimeout: Duration option
        Timeout: Duration option
        [<JsonPropertyName("config")>]
        Config: TypesConfiguration option
        [<JsonPropertyName("name")>]
        Name: Name option
        [<JsonPropertyName("repository")>]
        Repository: string option
        [<JsonPropertyName("retention")>]
        Retention: TypesRetention option
        [<JsonPropertyName("schedule")>]
        Schedule: TypesCronExpression option
    } with
        static member ToRequest(request: SlmPutLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_slm/policy/{request.PolicyId}"
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
                |> Fes.Http.Request.withJsonBody {| ``config`` = request.Config; ``name`` = request.Name; ``repository`` = request.Repository; ``retention`` = request.Retention; ``schedule`` = request.Schedule |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SlmPutLifecycleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SlmPutLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            SlmPutLifecycleRequest.ToRequest request

    type SlmPutLifecycleRequestBuilder() =
        member _.Yield(_: unit) : SlmPutLifecycleRequest =
            {
                SlmPutLifecycleRequest.PolicyId = Unchecked.defaultof<Name>
                SlmPutLifecycleRequest.MasterTimeout = Option.None
                SlmPutLifecycleRequest.Timeout = Option.None
                SlmPutLifecycleRequest.Config = Option.None
                SlmPutLifecycleRequest.Name = Option.None
                SlmPutLifecycleRequest.Repository = Option.None
                SlmPutLifecycleRequest.Retention = Option.None
                SlmPutLifecycleRequest.Schedule = Option.None
            } : SlmPutLifecycleRequest

        [<CustomOperation("policy_id")>]
        member _.PolicyId(state: SlmPutLifecycleRequest, value: Name) =
            { state with SlmPutLifecycleRequest.PolicyId = value } : SlmPutLifecycleRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SlmPutLifecycleRequest, value: Duration) =
            { state with SlmPutLifecycleRequest.MasterTimeout = Option.Some value } : SlmPutLifecycleRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmPutLifecycleRequest, value: Duration) =
            { state with SlmPutLifecycleRequest.Timeout = Option.Some value } : SlmPutLifecycleRequest

        [<CustomOperation("config")>]
        member _.Config(state: SlmPutLifecycleRequest, value: TypesConfiguration) =
            { state with SlmPutLifecycleRequest.Config = Option.Some value } : SlmPutLifecycleRequest

        [<CustomOperation("name")>]
        member _.Name(state: SlmPutLifecycleRequest, value: Name) =
            { state with SlmPutLifecycleRequest.Name = Option.Some value } : SlmPutLifecycleRequest

        [<CustomOperation("repository")>]
        member _.Repository(state: SlmPutLifecycleRequest, value: string) =
            { state with SlmPutLifecycleRequest.Repository = Option.Some value } : SlmPutLifecycleRequest

        [<CustomOperation("retention")>]
        member _.Retention(state: SlmPutLifecycleRequest, value: TypesRetention) =
            { state with SlmPutLifecycleRequest.Retention = Option.Some value } : SlmPutLifecycleRequest

        [<CustomOperation("schedule")>]
        member _.Schedule(state: SlmPutLifecycleRequest, value: TypesCronExpression) =
            { state with SlmPutLifecycleRequest.Schedule = Option.Some value } : SlmPutLifecycleRequest

    let slmPutLifecycleRequest = SlmPutLifecycleRequestBuilder()

    type SlmPutLifecycleResponse = AcknowledgedResponseBase

    type SlmDeleteLifecycleRequest = {
        PolicyId: Name
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: SlmDeleteLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_slm/policy/{request.PolicyId}"
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

    module SlmDeleteLifecycleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SlmDeleteLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            SlmDeleteLifecycleRequest.ToRequest request

    type SlmDeleteLifecycleRequestBuilder() =
        member _.Yield(_: unit) : SlmDeleteLifecycleRequest =
            {
                SlmDeleteLifecycleRequest.PolicyId = Unchecked.defaultof<Name>
                SlmDeleteLifecycleRequest.MasterTimeout = Option.None
                SlmDeleteLifecycleRequest.Timeout = Option.None
            } : SlmDeleteLifecycleRequest

        [<CustomOperation("policy_id")>]
        member _.PolicyId(state: SlmDeleteLifecycleRequest, value: Name) =
            { state with SlmDeleteLifecycleRequest.PolicyId = value } : SlmDeleteLifecycleRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SlmDeleteLifecycleRequest, value: Duration) =
            { state with SlmDeleteLifecycleRequest.MasterTimeout = Option.Some value } : SlmDeleteLifecycleRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmDeleteLifecycleRequest, value: Duration) =
            { state with SlmDeleteLifecycleRequest.Timeout = Option.Some value } : SlmDeleteLifecycleRequest

    let slmDeleteLifecycleRequest = SlmDeleteLifecycleRequestBuilder()

    type SlmDeleteLifecycleResponse = AcknowledgedResponseBase

    type SlmExecuteLifecycleRequest = {
        PolicyId: Name
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: SlmExecuteLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_slm/policy/{request.PolicyId}/_execute"
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
                |> Result.Ok
            with ex -> Result.Error ex

    module SlmExecuteLifecycleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SlmExecuteLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            SlmExecuteLifecycleRequest.ToRequest request

    type SlmExecuteLifecycleRequestBuilder() =
        member _.Yield(_: unit) : SlmExecuteLifecycleRequest =
            {
                SlmExecuteLifecycleRequest.PolicyId = Unchecked.defaultof<Name>
                SlmExecuteLifecycleRequest.MasterTimeout = Option.None
                SlmExecuteLifecycleRequest.Timeout = Option.None
            } : SlmExecuteLifecycleRequest

        [<CustomOperation("policy_id")>]
        member _.PolicyId(state: SlmExecuteLifecycleRequest, value: Name) =
            { state with SlmExecuteLifecycleRequest.PolicyId = value } : SlmExecuteLifecycleRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SlmExecuteLifecycleRequest, value: Duration) =
            { state with SlmExecuteLifecycleRequest.MasterTimeout = Option.Some value } : SlmExecuteLifecycleRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmExecuteLifecycleRequest, value: Duration) =
            { state with SlmExecuteLifecycleRequest.Timeout = Option.Some value } : SlmExecuteLifecycleRequest

    let slmExecuteLifecycleRequest = SlmExecuteLifecycleRequestBuilder()

    type SlmExecuteLifecycleResponse = {
        [<JsonPropertyName("snapshot_name")>]
        SnapshotName: Name
    }

    type SlmExecuteRetentionRequest = {
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: SlmExecuteRetentionRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_slm/_execute_retention"
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

    module SlmExecuteRetentionRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SlmExecuteRetentionRequest) : Result<Fes.Http.RequestMsg, exn> =
            SlmExecuteRetentionRequest.ToRequest request

    type SlmExecuteRetentionRequestBuilder() =
        member _.Yield(_: unit) : SlmExecuteRetentionRequest =
            {
                SlmExecuteRetentionRequest.MasterTimeout = Option.None
                SlmExecuteRetentionRequest.Timeout = Option.None
            } : SlmExecuteRetentionRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SlmExecuteRetentionRequest, value: Duration) =
            { state with SlmExecuteRetentionRequest.MasterTimeout = Option.Some value } : SlmExecuteRetentionRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmExecuteRetentionRequest, value: Duration) =
            { state with SlmExecuteRetentionRequest.Timeout = Option.Some value } : SlmExecuteRetentionRequest

    let slmExecuteRetentionRequest = SlmExecuteRetentionRequestBuilder()

    type SlmExecuteRetentionResponse = AcknowledgedResponseBase

    type SlmGetStatsRequest = {
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: SlmGetStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_slm/stats"
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

    module SlmGetStatsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SlmGetStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            SlmGetStatsRequest.ToRequest request

    type SlmGetStatsRequestBuilder() =
        member _.Yield(_: unit) : SlmGetStatsRequest =
            {
                SlmGetStatsRequest.MasterTimeout = Option.None
                SlmGetStatsRequest.Timeout = Option.None
            } : SlmGetStatsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SlmGetStatsRequest, value: Duration) =
            { state with SlmGetStatsRequest.MasterTimeout = Option.Some value } : SlmGetStatsRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmGetStatsRequest, value: Duration) =
            { state with SlmGetStatsRequest.Timeout = Option.Some value } : SlmGetStatsRequest

    let slmGetStatsRequest = SlmGetStatsRequestBuilder()

    type SlmGetStatsResponse = {
        [<JsonPropertyName("retention_deletion_time")>]
        RetentionDeletionTime: Duration
        [<JsonPropertyName("retention_deletion_time_millis")>]
        RetentionDeletionTimeMillis: DurationValueUnitMillis
        [<JsonPropertyName("retention_failed")>]
        RetentionFailed: float
        [<JsonPropertyName("retention_runs")>]
        RetentionRuns: float
        [<JsonPropertyName("retention_timed_out")>]
        RetentionTimedOut: float
        [<JsonPropertyName("total_snapshots_deleted")>]
        TotalSnapshotsDeleted: float
        [<JsonPropertyName("total_snapshot_deletion_failures")>]
        TotalSnapshotDeletionFailures: float
        [<JsonPropertyName("total_snapshots_failed")>]
        TotalSnapshotsFailed: float
        [<JsonPropertyName("total_snapshots_taken")>]
        TotalSnapshotsTaken: float
        [<JsonPropertyName("policy_stats")>]
        PolicyStats: TypesSnapshotPolicyStats array
    }

    type SlmGetStatusRequest = {
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: SlmGetStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_slm/status"
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

    module SlmGetStatusRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SlmGetStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            SlmGetStatusRequest.ToRequest request

    type SlmGetStatusRequestBuilder() =
        member _.Yield(_: unit) : SlmGetStatusRequest =
            {
                SlmGetStatusRequest.MasterTimeout = Option.None
                SlmGetStatusRequest.Timeout = Option.None
            } : SlmGetStatusRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SlmGetStatusRequest, value: Duration) =
            { state with SlmGetStatusRequest.MasterTimeout = Option.Some value } : SlmGetStatusRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmGetStatusRequest, value: Duration) =
            { state with SlmGetStatusRequest.Timeout = Option.Some value } : SlmGetStatusRequest

    let slmGetStatusRequest = SlmGetStatusRequestBuilder()

    type SlmGetStatusResponse = {
        [<JsonPropertyName("operation_mode")>]
        OperationMode: LifecycleOperationMode
    }

    type SlmStartRequest = {
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: SlmStartRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_slm/start"
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

    module SlmStartRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SlmStartRequest) : Result<Fes.Http.RequestMsg, exn> =
            SlmStartRequest.ToRequest request

    type SlmStartRequestBuilder() =
        member _.Yield(_: unit) : SlmStartRequest =
            {
                SlmStartRequest.MasterTimeout = Option.None
                SlmStartRequest.Timeout = Option.None
            } : SlmStartRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SlmStartRequest, value: Duration) =
            { state with SlmStartRequest.MasterTimeout = Option.Some value } : SlmStartRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmStartRequest, value: Duration) =
            { state with SlmStartRequest.Timeout = Option.Some value } : SlmStartRequest

    let slmStartRequest = SlmStartRequestBuilder()

    type SlmStartResponse = AcknowledgedResponseBase

    type SlmStopRequest = {
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: SlmStopRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_slm/stop"
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

    module SlmStopRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SlmStopRequest) : Result<Fes.Http.RequestMsg, exn> =
            SlmStopRequest.ToRequest request

    type SlmStopRequestBuilder() =
        member _.Yield(_: unit) : SlmStopRequest =
            {
                SlmStopRequest.MasterTimeout = Option.None
                SlmStopRequest.Timeout = Option.None
            } : SlmStopRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SlmStopRequest, value: Duration) =
            { state with SlmStopRequest.MasterTimeout = Option.Some value } : SlmStopRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SlmStopRequest, value: Duration) =
            { state with SlmStopRequest.Timeout = Option.Some value } : SlmStopRequest

    let slmStopRequest = SlmStopRequestBuilder()

    type SlmStopResponse = AcknowledgedResponseBase


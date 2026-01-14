// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module TransformOperations =

    type TransformGetTransformRequest = {
        TransformId: Names
        AllowNoMatch: bool option
        From: float option
        Size: float option
        ExcludeGenerated: bool option
    } with
        static member ToRequest(request: TransformGetTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_transform/{request.TransformId}"
                let queryParams =
                    [
                        request.AllowNoMatch |> Option.map (fun v -> "allow_no_match", string v)
                        request.From |> Option.map (fun v -> "from", string v)
                        request.Size |> Option.map (fun v -> "size", string v)
                        request.ExcludeGenerated |> Option.map (fun v -> "exclude_generated", string v)
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

    module TransformGetTransformRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: TransformGetTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            TransformGetTransformRequest.ToRequest request

    type TransformGetTransformRequestBuilder() =
        member _.Yield(_: unit) : TransformGetTransformRequest =
            {
                TransformGetTransformRequest.TransformId = Unchecked.defaultof<Names>
                TransformGetTransformRequest.AllowNoMatch = Option.None
                TransformGetTransformRequest.From = Option.None
                TransformGetTransformRequest.Size = Option.None
                TransformGetTransformRequest.ExcludeGenerated = Option.None
            } : TransformGetTransformRequest

        [<CustomOperation("transform_id")>]
        member _.TransformId(state: TransformGetTransformRequest, value: Names) =
            { state with TransformGetTransformRequest.TransformId = value } : TransformGetTransformRequest

        [<CustomOperation("allow_no_match")>]
        member _.AllowNoMatch(state: TransformGetTransformRequest, value: bool) =
            { state with TransformGetTransformRequest.AllowNoMatch = Option.Some value } : TransformGetTransformRequest

        [<CustomOperation("from")>]
        member _.From(state: TransformGetTransformRequest, value: float) =
            { state with TransformGetTransformRequest.From = Option.Some value } : TransformGetTransformRequest

        [<CustomOperation("size")>]
        member _.Size(state: TransformGetTransformRequest, value: float) =
            { state with TransformGetTransformRequest.Size = Option.Some value } : TransformGetTransformRequest

        [<CustomOperation("exclude_generated")>]
        member _.ExcludeGenerated(state: TransformGetTransformRequest, value: bool) =
            { state with TransformGetTransformRequest.ExcludeGenerated = Option.Some value } : TransformGetTransformRequest

    let transformGetTransformRequest = TransformGetTransformRequestBuilder()

    type TransformPutTransformRequest = {
        TransformId: Id
        DeferValidation: bool option
        Timeout: Duration option
        [<JsonPropertyName("dest")>]
        Dest: TypesDestination
        [<JsonPropertyName("description")>]
        Description: string option
        [<JsonPropertyName("frequency")>]
        Frequency: Duration option
        [<JsonPropertyName("latest")>]
        Latest: TypesLatest option
        [<JsonPropertyName("_meta")>]
        Meta: Metadata option
        [<JsonPropertyName("pivot")>]
        Pivot: TypesPivot option
        [<JsonPropertyName("retention_policy")>]
        RetentionPolicy: TypesRetentionPolicyContainer option
        [<JsonPropertyName("settings")>]
        Settings: TypesSettings option
        [<JsonPropertyName("source")>]
        Source: TypesSource
        [<JsonPropertyName("sync")>]
        Sync: TypesSyncContainer option
    } with
        static member ToRequest(request: TransformPutTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_transform/{request.TransformId}"
                let queryParams =
                    [
                        request.DeferValidation |> Option.map (fun v -> "defer_validation", string v)
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

    module TransformPutTransformRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: TransformPutTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            TransformPutTransformRequest.ToRequest request

    type TransformPutTransformRequestBuilder() =
        member _.Yield(_: unit) : TransformPutTransformRequest =
            {
                TransformPutTransformRequest.TransformId = Unchecked.defaultof<Id>
                TransformPutTransformRequest.DeferValidation = Option.None
                TransformPutTransformRequest.Timeout = Option.None
                TransformPutTransformRequest.Dest = Unchecked.defaultof<TypesDestination>
                TransformPutTransformRequest.Description = Option.None
                TransformPutTransformRequest.Frequency = Option.None
                TransformPutTransformRequest.Latest = Option.None
                TransformPutTransformRequest.Meta = Option.None
                TransformPutTransformRequest.Pivot = Option.None
                TransformPutTransformRequest.RetentionPolicy = Option.None
                TransformPutTransformRequest.Settings = Option.None
                TransformPutTransformRequest.Source = Unchecked.defaultof<TypesSource>
                TransformPutTransformRequest.Sync = Option.None
            } : TransformPutTransformRequest

        [<CustomOperation("transform_id")>]
        member _.TransformId(state: TransformPutTransformRequest, value: Id) =
            { state with TransformPutTransformRequest.TransformId = value } : TransformPutTransformRequest

        [<CustomOperation("defer_validation")>]
        member _.DeferValidation(state: TransformPutTransformRequest, value: bool) =
            { state with TransformPutTransformRequest.DeferValidation = Option.Some value } : TransformPutTransformRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TransformPutTransformRequest, value: Duration) =
            { state with TransformPutTransformRequest.Timeout = Option.Some value } : TransformPutTransformRequest

        [<CustomOperation("dest")>]
        member _.Dest(state: TransformPutTransformRequest, value: TypesDestination) =
            { state with TransformPutTransformRequest.Dest = value } : TransformPutTransformRequest

        [<CustomOperation("description")>]
        member _.Description(state: TransformPutTransformRequest, value: string) =
            { state with TransformPutTransformRequest.Description = Option.Some value } : TransformPutTransformRequest

        [<CustomOperation("frequency")>]
        member _.Frequency(state: TransformPutTransformRequest, value: Duration) =
            { state with TransformPutTransformRequest.Frequency = Option.Some value } : TransformPutTransformRequest

        [<CustomOperation("latest")>]
        member _.Latest(state: TransformPutTransformRequest, value: TypesLatest) =
            { state with TransformPutTransformRequest.Latest = Option.Some value } : TransformPutTransformRequest

        [<CustomOperation("_meta")>]
        member _.Meta(state: TransformPutTransformRequest, value: Metadata) =
            { state with TransformPutTransformRequest.Meta = Option.Some value } : TransformPutTransformRequest

        [<CustomOperation("pivot")>]
        member _.Pivot(state: TransformPutTransformRequest, value: TypesPivot) =
            { state with TransformPutTransformRequest.Pivot = Option.Some value } : TransformPutTransformRequest

        [<CustomOperation("retention_policy")>]
        member _.RetentionPolicy(state: TransformPutTransformRequest, value: TypesRetentionPolicyContainer) =
            { state with TransformPutTransformRequest.RetentionPolicy = Option.Some value } : TransformPutTransformRequest

        [<CustomOperation("settings")>]
        member _.Settings(state: TransformPutTransformRequest, value: TypesSettings) =
            { state with TransformPutTransformRequest.Settings = Option.Some value } : TransformPutTransformRequest

        [<CustomOperation("source")>]
        member _.Source(state: TransformPutTransformRequest, value: TypesSource) =
            { state with TransformPutTransformRequest.Source = value } : TransformPutTransformRequest

        [<CustomOperation("sync")>]
        member _.Sync(state: TransformPutTransformRequest, value: TypesSyncContainer) =
            { state with TransformPutTransformRequest.Sync = Option.Some value } : TransformPutTransformRequest

    let transformPutTransformRequest = TransformPutTransformRequestBuilder()

    type TransformPutTransformResponse = AcknowledgedResponseBase

    type TransformDeleteTransformRequest = {
        TransformId: Id
        Force: bool option
        DeleteDestIndex: bool option
        Timeout: Duration option
    } with
        static member ToRequest(request: TransformDeleteTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_transform/{request.TransformId}"
                let queryParams =
                    [
                        request.Force |> Option.map (fun v -> "force", string v)
                        request.DeleteDestIndex |> Option.map (fun v -> "delete_dest_index", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
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

    module TransformDeleteTransformRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: TransformDeleteTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            TransformDeleteTransformRequest.ToRequest request

    type TransformDeleteTransformRequestBuilder() =
        member _.Yield(_: unit) : TransformDeleteTransformRequest =
            {
                TransformDeleteTransformRequest.TransformId = Unchecked.defaultof<Id>
                TransformDeleteTransformRequest.Force = Option.None
                TransformDeleteTransformRequest.DeleteDestIndex = Option.None
                TransformDeleteTransformRequest.Timeout = Option.None
            } : TransformDeleteTransformRequest

        [<CustomOperation("transform_id")>]
        member _.TransformId(state: TransformDeleteTransformRequest, value: Id) =
            { state with TransformDeleteTransformRequest.TransformId = value } : TransformDeleteTransformRequest

        [<CustomOperation("force")>]
        member _.Force(state: TransformDeleteTransformRequest, value: bool) =
            { state with TransformDeleteTransformRequest.Force = Option.Some value } : TransformDeleteTransformRequest

        [<CustomOperation("delete_dest_index")>]
        member _.DeleteDestIndex(state: TransformDeleteTransformRequest, value: bool) =
            { state with TransformDeleteTransformRequest.DeleteDestIndex = Option.Some value } : TransformDeleteTransformRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TransformDeleteTransformRequest, value: Duration) =
            { state with TransformDeleteTransformRequest.Timeout = Option.Some value } : TransformDeleteTransformRequest

    let transformDeleteTransformRequest = TransformDeleteTransformRequestBuilder()

    type TransformDeleteTransformResponse = AcknowledgedResponseBase

    type TransformGetNodeStatsRequest = unit

    let transformGetNodeStatsRequest = ()

    type TransformGetNodeStatsResponse = GetNodeStatsTransformNodeFullStats

    type TransformGetTransformStatsRequest = {
        TransformId: Names
        AllowNoMatch: bool option
        From: float option
        Size: float option
        Timeout: Duration option
    } with
        static member ToRequest(request: TransformGetTransformStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_transform/{request.TransformId}/_stats"
                let queryParams =
                    [
                        request.AllowNoMatch |> Option.map (fun v -> "allow_no_match", string v)
                        request.From |> Option.map (fun v -> "from", string v)
                        request.Size |> Option.map (fun v -> "size", string v)
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

    module TransformGetTransformStatsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: TransformGetTransformStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            TransformGetTransformStatsRequest.ToRequest request

    type TransformGetTransformStatsRequestBuilder() =
        member _.Yield(_: unit) : TransformGetTransformStatsRequest =
            {
                TransformGetTransformStatsRequest.TransformId = Unchecked.defaultof<Names>
                TransformGetTransformStatsRequest.AllowNoMatch = Option.None
                TransformGetTransformStatsRequest.From = Option.None
                TransformGetTransformStatsRequest.Size = Option.None
                TransformGetTransformStatsRequest.Timeout = Option.None
            } : TransformGetTransformStatsRequest

        [<CustomOperation("transform_id")>]
        member _.TransformId(state: TransformGetTransformStatsRequest, value: Names) =
            { state with TransformGetTransformStatsRequest.TransformId = value } : TransformGetTransformStatsRequest

        [<CustomOperation("allow_no_match")>]
        member _.AllowNoMatch(state: TransformGetTransformStatsRequest, value: bool) =
            { state with TransformGetTransformStatsRequest.AllowNoMatch = Option.Some value } : TransformGetTransformStatsRequest

        [<CustomOperation("from")>]
        member _.From(state: TransformGetTransformStatsRequest, value: float) =
            { state with TransformGetTransformStatsRequest.From = Option.Some value } : TransformGetTransformStatsRequest

        [<CustomOperation("size")>]
        member _.Size(state: TransformGetTransformStatsRequest, value: float) =
            { state with TransformGetTransformStatsRequest.Size = Option.Some value } : TransformGetTransformStatsRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TransformGetTransformStatsRequest, value: Duration) =
            { state with TransformGetTransformStatsRequest.Timeout = Option.Some value } : TransformGetTransformStatsRequest

    let transformGetTransformStatsRequest = TransformGetTransformStatsRequestBuilder()

    type TransformGetTransformStatsResponse = {
        [<JsonPropertyName("count")>]
        Count: float
        [<JsonPropertyName("transforms")>]
        Transforms: GetTransformStatsTransformStats array
    }

    type TransformPreviewTransformRequest = {
        TransformId: Id
        Timeout: Duration option
        [<JsonPropertyName("dest")>]
        Dest: TypesDestination option
        [<JsonPropertyName("description")>]
        Description: string option
        [<JsonPropertyName("frequency")>]
        Frequency: Duration option
        [<JsonPropertyName("pivot")>]
        Pivot: TypesPivot option
        [<JsonPropertyName("source")>]
        Source: TypesSource option
        [<JsonPropertyName("settings")>]
        Settings: TypesSettings option
        [<JsonPropertyName("sync")>]
        Sync: TypesSyncContainer option
        [<JsonPropertyName("retention_policy")>]
        RetentionPolicy: TypesRetentionPolicyContainer option
        [<JsonPropertyName("latest")>]
        Latest: TypesLatest option
    } with
        static member ToRequest(request: TransformPreviewTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_transform/{request.TransformId}/_preview"
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

    module TransformPreviewTransformRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: TransformPreviewTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            TransformPreviewTransformRequest.ToRequest request

    type TransformPreviewTransformRequestBuilder() =
        member _.Yield(_: unit) : TransformPreviewTransformRequest =
            {
                TransformPreviewTransformRequest.TransformId = Unchecked.defaultof<Id>
                TransformPreviewTransformRequest.Timeout = Option.None
                TransformPreviewTransformRequest.Dest = Option.None
                TransformPreviewTransformRequest.Description = Option.None
                TransformPreviewTransformRequest.Frequency = Option.None
                TransformPreviewTransformRequest.Pivot = Option.None
                TransformPreviewTransformRequest.Source = Option.None
                TransformPreviewTransformRequest.Settings = Option.None
                TransformPreviewTransformRequest.Sync = Option.None
                TransformPreviewTransformRequest.RetentionPolicy = Option.None
                TransformPreviewTransformRequest.Latest = Option.None
            } : TransformPreviewTransformRequest

        [<CustomOperation("transform_id")>]
        member _.TransformId(state: TransformPreviewTransformRequest, value: Id) =
            { state with TransformPreviewTransformRequest.TransformId = value } : TransformPreviewTransformRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TransformPreviewTransformRequest, value: Duration) =
            { state with TransformPreviewTransformRequest.Timeout = Option.Some value } : TransformPreviewTransformRequest

        [<CustomOperation("dest")>]
        member _.Dest(state: TransformPreviewTransformRequest, value: TypesDestination) =
            { state with TransformPreviewTransformRequest.Dest = Option.Some value } : TransformPreviewTransformRequest

        [<CustomOperation("description")>]
        member _.Description(state: TransformPreviewTransformRequest, value: string) =
            { state with TransformPreviewTransformRequest.Description = Option.Some value } : TransformPreviewTransformRequest

        [<CustomOperation("frequency")>]
        member _.Frequency(state: TransformPreviewTransformRequest, value: Duration) =
            { state with TransformPreviewTransformRequest.Frequency = Option.Some value } : TransformPreviewTransformRequest

        [<CustomOperation("pivot")>]
        member _.Pivot(state: TransformPreviewTransformRequest, value: TypesPivot) =
            { state with TransformPreviewTransformRequest.Pivot = Option.Some value } : TransformPreviewTransformRequest

        [<CustomOperation("source")>]
        member _.Source(state: TransformPreviewTransformRequest, value: TypesSource) =
            { state with TransformPreviewTransformRequest.Source = Option.Some value } : TransformPreviewTransformRequest

        [<CustomOperation("settings")>]
        member _.Settings(state: TransformPreviewTransformRequest, value: TypesSettings) =
            { state with TransformPreviewTransformRequest.Settings = Option.Some value } : TransformPreviewTransformRequest

        [<CustomOperation("sync")>]
        member _.Sync(state: TransformPreviewTransformRequest, value: TypesSyncContainer) =
            { state with TransformPreviewTransformRequest.Sync = Option.Some value } : TransformPreviewTransformRequest

        [<CustomOperation("retention_policy")>]
        member _.RetentionPolicy(state: TransformPreviewTransformRequest, value: TypesRetentionPolicyContainer) =
            { state with TransformPreviewTransformRequest.RetentionPolicy = Option.Some value } : TransformPreviewTransformRequest

        [<CustomOperation("latest")>]
        member _.Latest(state: TransformPreviewTransformRequest, value: TypesLatest) =
            { state with TransformPreviewTransformRequest.Latest = Option.Some value } : TransformPreviewTransformRequest

    let transformPreviewTransformRequest = TransformPreviewTransformRequestBuilder()

    type TransformResetTransformRequest = {
        TransformId: Id
        Force: bool option
        Timeout: Duration option
    } with
        static member ToRequest(request: TransformResetTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_transform/{request.TransformId}/_reset"
                let queryParams =
                    [
                        request.Force |> Option.map (fun v -> "force", string v)
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

    module TransformResetTransformRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: TransformResetTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            TransformResetTransformRequest.ToRequest request

    type TransformResetTransformRequestBuilder() =
        member _.Yield(_: unit) : TransformResetTransformRequest =
            {
                TransformResetTransformRequest.TransformId = Unchecked.defaultof<Id>
                TransformResetTransformRequest.Force = Option.None
                TransformResetTransformRequest.Timeout = Option.None
            } : TransformResetTransformRequest

        [<CustomOperation("transform_id")>]
        member _.TransformId(state: TransformResetTransformRequest, value: Id) =
            { state with TransformResetTransformRequest.TransformId = value } : TransformResetTransformRequest

        [<CustomOperation("force")>]
        member _.Force(state: TransformResetTransformRequest, value: bool) =
            { state with TransformResetTransformRequest.Force = Option.Some value } : TransformResetTransformRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TransformResetTransformRequest, value: Duration) =
            { state with TransformResetTransformRequest.Timeout = Option.Some value } : TransformResetTransformRequest

    let transformResetTransformRequest = TransformResetTransformRequestBuilder()

    type TransformResetTransformResponse = AcknowledgedResponseBase

    type TransformScheduleNowTransformRequest = {
        TransformId: Id
        Timeout: Duration option
    } with
        static member ToRequest(request: TransformScheduleNowTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_transform/{request.TransformId}/_schedule_now"
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
                |> Result.Ok
            with ex -> Result.Error ex

    module TransformScheduleNowTransformRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: TransformScheduleNowTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            TransformScheduleNowTransformRequest.ToRequest request

    type TransformScheduleNowTransformRequestBuilder() =
        member _.Yield(_: unit) : TransformScheduleNowTransformRequest =
            {
                TransformScheduleNowTransformRequest.TransformId = Unchecked.defaultof<Id>
                TransformScheduleNowTransformRequest.Timeout = Option.None
            } : TransformScheduleNowTransformRequest

        [<CustomOperation("transform_id")>]
        member _.TransformId(state: TransformScheduleNowTransformRequest, value: Id) =
            { state with TransformScheduleNowTransformRequest.TransformId = value } : TransformScheduleNowTransformRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TransformScheduleNowTransformRequest, value: Duration) =
            { state with TransformScheduleNowTransformRequest.Timeout = Option.Some value } : TransformScheduleNowTransformRequest

    let transformScheduleNowTransformRequest = TransformScheduleNowTransformRequestBuilder()

    type TransformScheduleNowTransformResponse = AcknowledgedResponseBase

    type TransformSetUpgradeModeRequest = {
        Enabled: bool option
        Timeout: Duration option
    } with
        static member ToRequest(request: TransformSetUpgradeModeRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_transform/set_upgrade_mode"
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

    module TransformSetUpgradeModeRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: TransformSetUpgradeModeRequest) : Result<Fes.Http.RequestMsg, exn> =
            TransformSetUpgradeModeRequest.ToRequest request

    type TransformSetUpgradeModeRequestBuilder() =
        member _.Yield(_: unit) : TransformSetUpgradeModeRequest =
            {
                TransformSetUpgradeModeRequest.Enabled = Option.None
                TransformSetUpgradeModeRequest.Timeout = Option.None
            } : TransformSetUpgradeModeRequest

        [<CustomOperation("enabled")>]
        member _.Enabled(state: TransformSetUpgradeModeRequest, value: bool) =
            { state with TransformSetUpgradeModeRequest.Enabled = Option.Some value } : TransformSetUpgradeModeRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TransformSetUpgradeModeRequest, value: Duration) =
            { state with TransformSetUpgradeModeRequest.Timeout = Option.Some value } : TransformSetUpgradeModeRequest

    let transformSetUpgradeModeRequest = TransformSetUpgradeModeRequestBuilder()

    type TransformSetUpgradeModeResponse = AcknowledgedResponseBase

    type TransformStartTransformRequest = {
        TransformId: Id
        Timeout: Duration option
        From: string option
    } with
        static member ToRequest(request: TransformStartTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_transform/{request.TransformId}/_start"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                        request.From |> Option.map (fun v -> "from", string v)
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

    module TransformStartTransformRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: TransformStartTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            TransformStartTransformRequest.ToRequest request

    type TransformStartTransformRequestBuilder() =
        member _.Yield(_: unit) : TransformStartTransformRequest =
            {
                TransformStartTransformRequest.TransformId = Unchecked.defaultof<Id>
                TransformStartTransformRequest.Timeout = Option.None
                TransformStartTransformRequest.From = Option.None
            } : TransformStartTransformRequest

        [<CustomOperation("transform_id")>]
        member _.TransformId(state: TransformStartTransformRequest, value: Id) =
            { state with TransformStartTransformRequest.TransformId = value } : TransformStartTransformRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TransformStartTransformRequest, value: Duration) =
            { state with TransformStartTransformRequest.Timeout = Option.Some value } : TransformStartTransformRequest

        [<CustomOperation("from")>]
        member _.From(state: TransformStartTransformRequest, value: string) =
            { state with TransformStartTransformRequest.From = Option.Some value } : TransformStartTransformRequest

    let transformStartTransformRequest = TransformStartTransformRequestBuilder()

    type TransformStartTransformResponse = AcknowledgedResponseBase

    type TransformStopTransformRequest = {
        TransformId: Name
        AllowNoMatch: bool option
        Force: bool option
        Timeout: Duration option
        WaitForCheckpoint: bool option
        WaitForCompletion: bool option
    } with
        static member ToRequest(request: TransformStopTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_transform/{request.TransformId}/_stop"
                let queryParams =
                    [
                        request.AllowNoMatch |> Option.map (fun v -> "allow_no_match", string v)
                        request.Force |> Option.map (fun v -> "force", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                        request.WaitForCheckpoint |> Option.map (fun v -> "wait_for_checkpoint", string v)
                        request.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", string v)
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

    module TransformStopTransformRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: TransformStopTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            TransformStopTransformRequest.ToRequest request

    type TransformStopTransformRequestBuilder() =
        member _.Yield(_: unit) : TransformStopTransformRequest =
            {
                TransformStopTransformRequest.TransformId = Unchecked.defaultof<Name>
                TransformStopTransformRequest.AllowNoMatch = Option.None
                TransformStopTransformRequest.Force = Option.None
                TransformStopTransformRequest.Timeout = Option.None
                TransformStopTransformRequest.WaitForCheckpoint = Option.None
                TransformStopTransformRequest.WaitForCompletion = Option.None
            } : TransformStopTransformRequest

        [<CustomOperation("transform_id")>]
        member _.TransformId(state: TransformStopTransformRequest, value: Name) =
            { state with TransformStopTransformRequest.TransformId = value } : TransformStopTransformRequest

        [<CustomOperation("allow_no_match")>]
        member _.AllowNoMatch(state: TransformStopTransformRequest, value: bool) =
            { state with TransformStopTransformRequest.AllowNoMatch = Option.Some value } : TransformStopTransformRequest

        [<CustomOperation("force")>]
        member _.Force(state: TransformStopTransformRequest, value: bool) =
            { state with TransformStopTransformRequest.Force = Option.Some value } : TransformStopTransformRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TransformStopTransformRequest, value: Duration) =
            { state with TransformStopTransformRequest.Timeout = Option.Some value } : TransformStopTransformRequest

        [<CustomOperation("wait_for_checkpoint")>]
        member _.WaitForCheckpoint(state: TransformStopTransformRequest, value: bool) =
            { state with TransformStopTransformRequest.WaitForCheckpoint = Option.Some value } : TransformStopTransformRequest

        [<CustomOperation("wait_for_completion")>]
        member _.WaitForCompletion(state: TransformStopTransformRequest, value: bool) =
            { state with TransformStopTransformRequest.WaitForCompletion = Option.Some value } : TransformStopTransformRequest

    let transformStopTransformRequest = TransformStopTransformRequestBuilder()

    type TransformStopTransformResponse = AcknowledgedResponseBase

    type TransformUpdateTransformRequest = {
        TransformId: Id
        DeferValidation: bool option
        Timeout: Duration option
        [<JsonPropertyName("dest")>]
        Dest: TypesDestination option
        [<JsonPropertyName("description")>]
        Description: string option
        [<JsonPropertyName("frequency")>]
        Frequency: Duration option
        [<JsonPropertyName("_meta")>]
        Meta: Metadata option
        [<JsonPropertyName("source")>]
        Source: TypesSource option
        [<JsonPropertyName("settings")>]
        Settings: TypesSettings option
        [<JsonPropertyName("sync")>]
        Sync: TypesSyncContainer option
        [<JsonPropertyName("retention_policy")>]
        RetentionPolicy: System.Text.Json.JsonElement option
    } with
        static member ToRequest(request: TransformUpdateTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_transform/{request.TransformId}/_update"
                let queryParams =
                    [
                        request.DeferValidation |> Option.map (fun v -> "defer_validation", string v)
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

    module TransformUpdateTransformRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: TransformUpdateTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            TransformUpdateTransformRequest.ToRequest request

    type TransformUpdateTransformRequestBuilder() =
        member _.Yield(_: unit) : TransformUpdateTransformRequest =
            {
                TransformUpdateTransformRequest.TransformId = Unchecked.defaultof<Id>
                TransformUpdateTransformRequest.DeferValidation = Option.None
                TransformUpdateTransformRequest.Timeout = Option.None
                TransformUpdateTransformRequest.Dest = Option.None
                TransformUpdateTransformRequest.Description = Option.None
                TransformUpdateTransformRequest.Frequency = Option.None
                TransformUpdateTransformRequest.Meta = Option.None
                TransformUpdateTransformRequest.Source = Option.None
                TransformUpdateTransformRequest.Settings = Option.None
                TransformUpdateTransformRequest.Sync = Option.None
                TransformUpdateTransformRequest.RetentionPolicy = Option.None
            } : TransformUpdateTransformRequest

        [<CustomOperation("transform_id")>]
        member _.TransformId(state: TransformUpdateTransformRequest, value: Id) =
            { state with TransformUpdateTransformRequest.TransformId = value } : TransformUpdateTransformRequest

        [<CustomOperation("defer_validation")>]
        member _.DeferValidation(state: TransformUpdateTransformRequest, value: bool) =
            { state with TransformUpdateTransformRequest.DeferValidation = Option.Some value } : TransformUpdateTransformRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TransformUpdateTransformRequest, value: Duration) =
            { state with TransformUpdateTransformRequest.Timeout = Option.Some value } : TransformUpdateTransformRequest

        [<CustomOperation("dest")>]
        member _.Dest(state: TransformUpdateTransformRequest, value: TypesDestination) =
            { state with TransformUpdateTransformRequest.Dest = Option.Some value } : TransformUpdateTransformRequest

        [<CustomOperation("description")>]
        member _.Description(state: TransformUpdateTransformRequest, value: string) =
            { state with TransformUpdateTransformRequest.Description = Option.Some value } : TransformUpdateTransformRequest

        [<CustomOperation("frequency")>]
        member _.Frequency(state: TransformUpdateTransformRequest, value: Duration) =
            { state with TransformUpdateTransformRequest.Frequency = Option.Some value } : TransformUpdateTransformRequest

        [<CustomOperation("_meta")>]
        member _.Meta(state: TransformUpdateTransformRequest, value: Metadata) =
            { state with TransformUpdateTransformRequest.Meta = Option.Some value } : TransformUpdateTransformRequest

        [<CustomOperation("source")>]
        member _.Source(state: TransformUpdateTransformRequest, value: TypesSource) =
            { state with TransformUpdateTransformRequest.Source = Option.Some value } : TransformUpdateTransformRequest

        [<CustomOperation("settings")>]
        member _.Settings(state: TransformUpdateTransformRequest, value: TypesSettings) =
            { state with TransformUpdateTransformRequest.Settings = Option.Some value } : TransformUpdateTransformRequest

        [<CustomOperation("sync")>]
        member _.Sync(state: TransformUpdateTransformRequest, value: TypesSyncContainer) =
            { state with TransformUpdateTransformRequest.Sync = Option.Some value } : TransformUpdateTransformRequest

        [<CustomOperation("retention_policy")>]
        member _.RetentionPolicy(state: TransformUpdateTransformRequest, value: System.Text.Json.JsonElement) =
            { state with TransformUpdateTransformRequest.RetentionPolicy = Option.Some value } : TransformUpdateTransformRequest

    let transformUpdateTransformRequest = TransformUpdateTransformRequestBuilder()

    type TransformUpdateTransformResponse = {
        [<JsonPropertyName("authorization")>]
        Authorization: TypesTransformAuthorization option
        [<JsonPropertyName("create_time")>]
        CreateTime: float
        [<JsonPropertyName("description")>]
        Description: string
        [<JsonPropertyName("dest")>]
        Dest: ReindexDestination
        [<JsonPropertyName("frequency")>]
        Frequency: Duration option
        [<JsonPropertyName("id")>]
        Id: Id
        [<JsonPropertyName("latest")>]
        Latest: TypesLatest option
        [<JsonPropertyName("pivot")>]
        Pivot: TypesPivot option
        [<JsonPropertyName("retention_policy")>]
        RetentionPolicy: TypesRetentionPolicyContainer option
        [<JsonPropertyName("settings")>]
        Settings: TypesSettings
        [<JsonPropertyName("source")>]
        Source: ReindexSource
        [<JsonPropertyName("sync")>]
        Sync: TypesSyncContainer option
        [<JsonPropertyName("version")>]
        Version: VersionString
        [<JsonPropertyName("_meta")>]
        Meta: Metadata option
    }

    type TransformUpgradeTransformsRequest = {
        DryRun: bool option
        Timeout: Duration option
    } with
        static member ToRequest(request: TransformUpgradeTransformsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_transform/_upgrade"
                let queryParams =
                    [
                        request.DryRun |> Option.map (fun v -> "dry_run", string v)
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

    module TransformUpgradeTransformsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: TransformUpgradeTransformsRequest) : Result<Fes.Http.RequestMsg, exn> =
            TransformUpgradeTransformsRequest.ToRequest request

    type TransformUpgradeTransformsRequestBuilder() =
        member _.Yield(_: unit) : TransformUpgradeTransformsRequest =
            {
                TransformUpgradeTransformsRequest.DryRun = Option.None
                TransformUpgradeTransformsRequest.Timeout = Option.None
            } : TransformUpgradeTransformsRequest

        [<CustomOperation("dry_run")>]
        member _.DryRun(state: TransformUpgradeTransformsRequest, value: bool) =
            { state with TransformUpgradeTransformsRequest.DryRun = Option.Some value } : TransformUpgradeTransformsRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TransformUpgradeTransformsRequest, value: Duration) =
            { state with TransformUpgradeTransformsRequest.Timeout = Option.Some value } : TransformUpgradeTransformsRequest

    let transformUpgradeTransformsRequest = TransformUpgradeTransformsRequestBuilder()

    type TransformUpgradeTransformsResponse = {
        [<JsonPropertyName("needs_update")>]
        NeedsUpdate: float
        [<JsonPropertyName("no_action")>]
        NoAction: float
        [<JsonPropertyName("updated")>]
        Updated: float
    }


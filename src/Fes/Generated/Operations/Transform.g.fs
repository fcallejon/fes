// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module TransformOperations =

    type TransformDeleteTransformRequest = {
        TransformId: Types.Id
        Force: bool option
        DeleteDestIndex: bool option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: TransformDeleteTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_transform/{req.TransformId}"
                let queryParams =
                    [
                        req.Force |> Option.map (fun v -> "force", Fes.Http.toQueryValue v)
                        req.DeleteDestIndex |> Option.map (fun v -> "delete_dest_index", Fes.Http.toQueryValue v)
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

    type TransformDeleteTransformResponse = Types.AcknowledgedResponseBase

    type TransformDeleteTransformRequestBuilder() =
        member _.Yield(_: unit) : TransformDeleteTransformRequest =
            {
                TransformId = Unchecked.defaultof<_>
                Force = None
                DeleteDestIndex = None
                Timeout = None
            }

        [<CustomOperation("transformId")>]
        member _.TransformId(state: TransformDeleteTransformRequest, value: Types.Id) =
            { state with TransformId = value }

        [<CustomOperation("force")>]
        member _.Force(state: TransformDeleteTransformRequest, value: bool) =
            { state with Force = Some value }

        [<CustomOperation("deleteDestIndex")>]
        member _.DeleteDestIndex(state: TransformDeleteTransformRequest, value: bool) =
            { state with DeleteDestIndex = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TransformDeleteTransformRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let transformDeleteTransformRequest = TransformDeleteTransformRequestBuilder()

    module DeleteTransform =
        let withForce (value: bool) (req: TransformDeleteTransformRequest) =
            { req with Force = Some value }
        let withDeleteDestIndex (value: bool) (req: TransformDeleteTransformRequest) =
            { req with DeleteDestIndex = Some value }
        let withTimeout (value: Types.Duration) (req: TransformDeleteTransformRequest) =
            { req with Timeout = Some value }

    type TransformGetNodeStatsRequest = | TransformGetNodeStatsRequest

        with
        static member ToRequest(req: TransformGetNodeStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_transform/_node_stats"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type TransformGetNodeStatsResponse = Types.TransformNodeFullStats

    type TransformGetNodeStatsRequestBuilder() =
        member _.Yield(_: unit) : TransformGetNodeStatsRequest =
            {
            }

    let transformGetNodeStatsRequest = TransformGetNodeStatsRequestBuilder()

    type TransformGetTransformRequest = {
        TransformId: Types.Names
        AllowNoMatch: bool option
        From: Types.Integer option
        Size: Types.Integer option
        ExcludeGenerated: bool option
    }

        with
        static member ToRequest(req: TransformGetTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_transform/{req.TransformId}"
                let queryParams =
                    [
                        req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                        req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                        req.ExcludeGenerated |> Option.map (fun v -> "exclude_generated", Fes.Http.toQueryValue v)
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

    type TransformGetTransformResponse = System.Text.Json.JsonElement

    type TransformGetTransformRequestBuilder() =
        member _.Yield(_: unit) : TransformGetTransformRequest =
            {
                TransformId = Unchecked.defaultof<_>
                AllowNoMatch = None
                From = None
                Size = None
                ExcludeGenerated = None
            }

        [<CustomOperation("transformId")>]
        member _.TransformId(state: TransformGetTransformRequest, value: Types.Names) =
            { state with TransformId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: TransformGetTransformRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("from")>]
        member _.From(state: TransformGetTransformRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: TransformGetTransformRequest, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("excludeGenerated")>]
        member _.ExcludeGenerated(state: TransformGetTransformRequest, value: bool) =
            { state with ExcludeGenerated = Some value }

    let transformGetTransformRequest = TransformGetTransformRequestBuilder()

    module GetTransform =
        let withAllowNoMatch (value: bool) (req: TransformGetTransformRequest) =
            { req with AllowNoMatch = Some value }
        let withFrom (value: Types.Integer) (req: TransformGetTransformRequest) =
            { req with From = Some value }
        let withSize (value: Types.Integer) (req: TransformGetTransformRequest) =
            { req with Size = Some value }
        let withExcludeGenerated (value: bool) (req: TransformGetTransformRequest) =
            { req with ExcludeGenerated = Some value }

    type TransformGetTransformStatsRequest = {
        TransformId: Types.Names
        AllowNoMatch: bool option
        From: Types.Long option
        Size: Types.Long option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: TransformGetTransformStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_transform/{req.TransformId}/_stats"
                let queryParams =
                    [
                        req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                        req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
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

    type TransformGetTransformStatsResponse = System.Text.Json.JsonElement

    type TransformGetTransformStatsRequestBuilder() =
        member _.Yield(_: unit) : TransformGetTransformStatsRequest =
            {
                TransformId = Unchecked.defaultof<_>
                AllowNoMatch = None
                From = None
                Size = None
                Timeout = None
            }

        [<CustomOperation("transformId")>]
        member _.TransformId(state: TransformGetTransformStatsRequest, value: Types.Names) =
            { state with TransformId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: TransformGetTransformStatsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("from")>]
        member _.From(state: TransformGetTransformStatsRequest, value: Types.Long) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: TransformGetTransformStatsRequest, value: Types.Long) =
            { state with Size = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TransformGetTransformStatsRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let transformGetTransformStatsRequest = TransformGetTransformStatsRequestBuilder()

    module GetTransformStats =
        let withAllowNoMatch (value: bool) (req: TransformGetTransformStatsRequest) =
            { req with AllowNoMatch = Some value }
        let withFrom (value: Types.Long) (req: TransformGetTransformStatsRequest) =
            { req with From = Some value }
        let withSize (value: Types.Long) (req: TransformGetTransformStatsRequest) =
            { req with Size = Some value }
        let withTimeout (value: Types.Duration) (req: TransformGetTransformStatsRequest) =
            { req with Timeout = Some value }

    type TransformPreviewTransformRequest = {
        TransformId: Types.Id
        Timeout: Types.Duration option
        Dest: Types.TransformTypesDestination option
        Description: string option
        Frequency: Types.Duration option
        Pivot: Types.Pivot option
        Source: Types.TransformTypesSource option
        Settings: Types.Settings option
        Sync: Types.SyncContainer option
        RetentionPolicy: Types.RetentionPolicyContainer option
        Latest: Types.Latest option
    }

        with
        static member ToRequest(req: TransformPreviewTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_transform/{req.TransformId}/_preview"
                let queryParams =
                    [
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

    type TransformPreviewTransformResponse = System.Text.Json.JsonElement

    type TransformPreviewTransformRequestBuilder() =
        member _.Yield(_: unit) : TransformPreviewTransformRequest =
            {
                TransformId = Unchecked.defaultof<_>
                Timeout = None
                Dest = None
                Description = None
                Frequency = None
                Pivot = None
                Source = None
                Settings = None
                Sync = None
                RetentionPolicy = None
                Latest = None
            }

        [<CustomOperation("transformId")>]
        member _.TransformId(state: TransformPreviewTransformRequest, value: Types.Id) =
            { state with TransformId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TransformPreviewTransformRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("dest")>]
        member _.Dest(state: TransformPreviewTransformRequest, value: Types.TransformTypesDestination) =
            { state with Dest = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: TransformPreviewTransformRequest, value: string) =
            { state with Description = Some value }

        [<CustomOperation("frequency")>]
        member _.Frequency(state: TransformPreviewTransformRequest, value: Types.Duration) =
            { state with Frequency = Some value }

        [<CustomOperation("pivot")>]
        member _.Pivot(state: TransformPreviewTransformRequest, value: Types.Pivot) =
            { state with Pivot = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: TransformPreviewTransformRequest, value: Types.TransformTypesSource) =
            { state with Source = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: TransformPreviewTransformRequest, value: Types.Settings) =
            { state with Settings = Some value }

        [<CustomOperation("sync")>]
        member _.Sync(state: TransformPreviewTransformRequest, value: Types.SyncContainer) =
            { state with Sync = Some value }

        [<CustomOperation("retentionPolicy")>]
        member _.RetentionPolicy(state: TransformPreviewTransformRequest, value: Types.RetentionPolicyContainer) =
            { state with RetentionPolicy = Some value }

        [<CustomOperation("latest")>]
        member _.Latest(state: TransformPreviewTransformRequest, value: Types.Latest) =
            { state with Latest = Some value }

    let transformPreviewTransformRequest = TransformPreviewTransformRequestBuilder()

    module PreviewTransform =
        let withTimeout (value: Types.Duration) (req: TransformPreviewTransformRequest) =
            { req with Timeout = Some value }
        let withDest (value: Types.TransformTypesDestination) (req: TransformPreviewTransformRequest) =
            { req with Dest = Some value }
        let withDescription (value: string) (req: TransformPreviewTransformRequest) =
            { req with Description = Some value }
        let withFrequency (value: Types.Duration) (req: TransformPreviewTransformRequest) =
            { req with Frequency = Some value }
        let withPivot (value: Types.Pivot) (req: TransformPreviewTransformRequest) =
            { req with Pivot = Some value }
        let withSource (value: Types.TransformTypesSource) (req: TransformPreviewTransformRequest) =
            { req with Source = Some value }
        let withSettings (value: Types.Settings) (req: TransformPreviewTransformRequest) =
            { req with Settings = Some value }
        let withSync (value: Types.SyncContainer) (req: TransformPreviewTransformRequest) =
            { req with Sync = Some value }
        let withRetentionPolicy (value: Types.RetentionPolicyContainer) (req: TransformPreviewTransformRequest) =
            { req with RetentionPolicy = Some value }
        let withLatest (value: Types.Latest) (req: TransformPreviewTransformRequest) =
            { req with Latest = Some value }

    type TransformPutTransformRequest = {
        TransformId: Types.Id
        DeferValidation: bool option
        Timeout: Types.Duration option
        Dest: Types.TransformTypesDestination
        Description: string option
        Frequency: Types.Duration option
        Latest: Types.Latest option
        Meta: Types.Metadata option
        Pivot: Types.Pivot option
        RetentionPolicy: Types.RetentionPolicyContainer option
        Settings: Types.Settings option
        Source: Types.TransformTypesSource
        Sync: Types.SyncContainer option
    }

        with
        static member ToRequest(req: TransformPutTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_transform/{req.TransformId}"
                let queryParams =
                    [
                        req.DeferValidation |> Option.map (fun v -> "defer_validation", Fes.Http.toQueryValue v)
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

    type TransformPutTransformResponse = Types.AcknowledgedResponseBase

    type TransformPutTransformRequestBuilder() =
        member _.Yield(_: unit) : TransformPutTransformRequest =
            {
                TransformId = Unchecked.defaultof<_>
                DeferValidation = None
                Timeout = None
                Dest = Unchecked.defaultof<_>
                Description = None
                Frequency = None
                Latest = None
                Meta = None
                Pivot = None
                RetentionPolicy = None
                Settings = None
                Source = Unchecked.defaultof<_>
                Sync = None
            }

        [<CustomOperation("transformId")>]
        member _.TransformId(state: TransformPutTransformRequest, value: Types.Id) =
            { state with TransformId = value }

        [<CustomOperation("deferValidation")>]
        member _.DeferValidation(state: TransformPutTransformRequest, value: bool) =
            { state with DeferValidation = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TransformPutTransformRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("dest")>]
        member _.Dest(state: TransformPutTransformRequest, value: Types.TransformTypesDestination) =
            { state with Dest = value }

        [<CustomOperation("description")>]
        member _.Description(state: TransformPutTransformRequest, value: string) =
            { state with Description = Some value }

        [<CustomOperation("frequency")>]
        member _.Frequency(state: TransformPutTransformRequest, value: Types.Duration) =
            { state with Frequency = Some value }

        [<CustomOperation("latest")>]
        member _.Latest(state: TransformPutTransformRequest, value: Types.Latest) =
            { state with Latest = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: TransformPutTransformRequest, value: Types.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("pivot")>]
        member _.Pivot(state: TransformPutTransformRequest, value: Types.Pivot) =
            { state with Pivot = Some value }

        [<CustomOperation("retentionPolicy")>]
        member _.RetentionPolicy(state: TransformPutTransformRequest, value: Types.RetentionPolicyContainer) =
            { state with RetentionPolicy = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: TransformPutTransformRequest, value: Types.Settings) =
            { state with Settings = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: TransformPutTransformRequest, value: Types.TransformTypesSource) =
            { state with Source = value }

        [<CustomOperation("sync")>]
        member _.Sync(state: TransformPutTransformRequest, value: Types.SyncContainer) =
            { state with Sync = Some value }

    let transformPutTransformRequest = TransformPutTransformRequestBuilder()

    module PutTransform =
        let withDeferValidation (value: bool) (req: TransformPutTransformRequest) =
            { req with DeferValidation = Some value }
        let withTimeout (value: Types.Duration) (req: TransformPutTransformRequest) =
            { req with Timeout = Some value }
        let withDest (value: Types.TransformTypesDestination) (req: TransformPutTransformRequest) =
            { req with Dest = value }
        let withDescription (value: string) (req: TransformPutTransformRequest) =
            { req with Description = Some value }
        let withFrequency (value: Types.Duration) (req: TransformPutTransformRequest) =
            { req with Frequency = Some value }
        let withLatest (value: Types.Latest) (req: TransformPutTransformRequest) =
            { req with Latest = Some value }
        let withMeta (value: Types.Metadata) (req: TransformPutTransformRequest) =
            { req with Meta = Some value }
        let withPivot (value: Types.Pivot) (req: TransformPutTransformRequest) =
            { req with Pivot = Some value }
        let withRetentionPolicy (value: Types.RetentionPolicyContainer) (req: TransformPutTransformRequest) =
            { req with RetentionPolicy = Some value }
        let withSettings (value: Types.Settings) (req: TransformPutTransformRequest) =
            { req with Settings = Some value }
        let withSource (value: Types.TransformTypesSource) (req: TransformPutTransformRequest) =
            { req with Source = value }
        let withSync (value: Types.SyncContainer) (req: TransformPutTransformRequest) =
            { req with Sync = Some value }

    type TransformResetTransformRequest = {
        TransformId: Types.Id
        Force: bool option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: TransformResetTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_transform/{req.TransformId}/_reset"
                let queryParams =
                    [
                        req.Force |> Option.map (fun v -> "force", Fes.Http.toQueryValue v)
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

    type TransformResetTransformResponse = Types.AcknowledgedResponseBase

    type TransformResetTransformRequestBuilder() =
        member _.Yield(_: unit) : TransformResetTransformRequest =
            {
                TransformId = Unchecked.defaultof<_>
                Force = None
                Timeout = None
            }

        [<CustomOperation("transformId")>]
        member _.TransformId(state: TransformResetTransformRequest, value: Types.Id) =
            { state with TransformId = value }

        [<CustomOperation("force")>]
        member _.Force(state: TransformResetTransformRequest, value: bool) =
            { state with Force = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TransformResetTransformRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let transformResetTransformRequest = TransformResetTransformRequestBuilder()

    module ResetTransform =
        let withForce (value: bool) (req: TransformResetTransformRequest) =
            { req with Force = Some value }
        let withTimeout (value: Types.Duration) (req: TransformResetTransformRequest) =
            { req with Timeout = Some value }

    type TransformScheduleNowTransformRequest = {
        TransformId: Types.Id
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: TransformScheduleNowTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_transform/{req.TransformId}/_schedule_now"
                let queryParams =
                    [
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

    type TransformScheduleNowTransformResponse = Types.AcknowledgedResponseBase

    type TransformScheduleNowTransformRequestBuilder() =
        member _.Yield(_: unit) : TransformScheduleNowTransformRequest =
            {
                TransformId = Unchecked.defaultof<_>
                Timeout = None
            }

        [<CustomOperation("transformId")>]
        member _.TransformId(state: TransformScheduleNowTransformRequest, value: Types.Id) =
            { state with TransformId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TransformScheduleNowTransformRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let transformScheduleNowTransformRequest = TransformScheduleNowTransformRequestBuilder()

    module ScheduleNowTransform =
        let withTimeout (value: Types.Duration) (req: TransformScheduleNowTransformRequest) =
            { req with Timeout = Some value }

    type TransformSetUpgradeModeRequest = {
        Enabled: bool option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: TransformSetUpgradeModeRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_transform/set_upgrade_mode"
                let queryParams =
                    [
                        req.Enabled |> Option.map (fun v -> "enabled", Fes.Http.toQueryValue v)
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

    type TransformSetUpgradeModeResponse = Types.AcknowledgedResponseBase

    type TransformSetUpgradeModeRequestBuilder() =
        member _.Yield(_: unit) : TransformSetUpgradeModeRequest =
            {
                Enabled = None
                Timeout = None
            }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: TransformSetUpgradeModeRequest, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TransformSetUpgradeModeRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let transformSetUpgradeModeRequest = TransformSetUpgradeModeRequestBuilder()

    module SetUpgradeMode =
        let withEnabled (value: bool) (req: TransformSetUpgradeModeRequest) =
            { req with Enabled = Some value }
        let withTimeout (value: Types.Duration) (req: TransformSetUpgradeModeRequest) =
            { req with Timeout = Some value }

    type TransformStartTransformRequest = {
        TransformId: Types.Id
        Timeout: Types.Duration option
        From: string option
    }

        with
        static member ToRequest(req: TransformStartTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_transform/{req.TransformId}/_start"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
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

    type TransformStartTransformResponse = Types.AcknowledgedResponseBase

    type TransformStartTransformRequestBuilder() =
        member _.Yield(_: unit) : TransformStartTransformRequest =
            {
                TransformId = Unchecked.defaultof<_>
                Timeout = None
                From = None
            }

        [<CustomOperation("transformId")>]
        member _.TransformId(state: TransformStartTransformRequest, value: Types.Id) =
            { state with TransformId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TransformStartTransformRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("from")>]
        member _.From(state: TransformStartTransformRequest, value: string) =
            { state with From = Some value }

    let transformStartTransformRequest = TransformStartTransformRequestBuilder()

    module StartTransform =
        let withTimeout (value: Types.Duration) (req: TransformStartTransformRequest) =
            { req with Timeout = Some value }
        let withFrom (value: string) (req: TransformStartTransformRequest) =
            { req with From = Some value }

    type TransformStopTransformRequest = {
        TransformId: Types.Name
        AllowNoMatch: bool option
        Force: bool option
        Timeout: Types.Duration option
        WaitForCheckpoint: bool option
        WaitForCompletion: bool option
    }

        with
        static member ToRequest(req: TransformStopTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_transform/{req.TransformId}/_stop"
                let queryParams =
                    [
                        req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                        req.Force |> Option.map (fun v -> "force", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        req.WaitForCheckpoint |> Option.map (fun v -> "wait_for_checkpoint", Fes.Http.toQueryValue v)
                        req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
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

    type TransformStopTransformResponse = Types.AcknowledgedResponseBase

    type TransformStopTransformRequestBuilder() =
        member _.Yield(_: unit) : TransformStopTransformRequest =
            {
                TransformId = Unchecked.defaultof<_>
                AllowNoMatch = None
                Force = None
                Timeout = None
                WaitForCheckpoint = None
                WaitForCompletion = None
            }

        [<CustomOperation("transformId")>]
        member _.TransformId(state: TransformStopTransformRequest, value: Types.Name) =
            { state with TransformId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: TransformStopTransformRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("force")>]
        member _.Force(state: TransformStopTransformRequest, value: bool) =
            { state with Force = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TransformStopTransformRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("waitForCheckpoint")>]
        member _.WaitForCheckpoint(state: TransformStopTransformRequest, value: bool) =
            { state with WaitForCheckpoint = Some value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: TransformStopTransformRequest, value: bool) =
            { state with WaitForCompletion = Some value }

    let transformStopTransformRequest = TransformStopTransformRequestBuilder()

    module StopTransform =
        let withAllowNoMatch (value: bool) (req: TransformStopTransformRequest) =
            { req with AllowNoMatch = Some value }
        let withForce (value: bool) (req: TransformStopTransformRequest) =
            { req with Force = Some value }
        let withTimeout (value: Types.Duration) (req: TransformStopTransformRequest) =
            { req with Timeout = Some value }
        let withWaitForCheckpoint (value: bool) (req: TransformStopTransformRequest) =
            { req with WaitForCheckpoint = Some value }
        let withWaitForCompletion (value: bool) (req: TransformStopTransformRequest) =
            { req with WaitForCompletion = Some value }

    type TransformUpdateTransformRequest = {
        TransformId: Types.Id
        DeferValidation: bool option
        Timeout: Types.Duration option
        Dest: Types.TransformTypesDestination option
        Description: string option
        Frequency: Types.Duration option
        Meta: Types.Metadata option
        Source: Types.TransformTypesSource option
        Settings: Types.Settings option
        Sync: Types.SyncContainer option
        RetentionPolicy: Types.RetentionPolicyContainer option option
    }

        with
        static member ToRequest(req: TransformUpdateTransformRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_transform/{req.TransformId}/_update"
                let queryParams =
                    [
                        req.DeferValidation |> Option.map (fun v -> "defer_validation", Fes.Http.toQueryValue v)
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

    type TransformUpdateTransformResponse = System.Text.Json.JsonElement

    type TransformUpdateTransformRequestBuilder() =
        member _.Yield(_: unit) : TransformUpdateTransformRequest =
            {
                TransformId = Unchecked.defaultof<_>
                DeferValidation = None
                Timeout = None
                Dest = None
                Description = None
                Frequency = None
                Meta = None
                Source = None
                Settings = None
                Sync = None
                RetentionPolicy = None
            }

        [<CustomOperation("transformId")>]
        member _.TransformId(state: TransformUpdateTransformRequest, value: Types.Id) =
            { state with TransformId = value }

        [<CustomOperation("deferValidation")>]
        member _.DeferValidation(state: TransformUpdateTransformRequest, value: bool) =
            { state with DeferValidation = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TransformUpdateTransformRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("dest")>]
        member _.Dest(state: TransformUpdateTransformRequest, value: Types.TransformTypesDestination) =
            { state with Dest = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: TransformUpdateTransformRequest, value: string) =
            { state with Description = Some value }

        [<CustomOperation("frequency")>]
        member _.Frequency(state: TransformUpdateTransformRequest, value: Types.Duration) =
            { state with Frequency = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: TransformUpdateTransformRequest, value: Types.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: TransformUpdateTransformRequest, value: Types.TransformTypesSource) =
            { state with Source = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: TransformUpdateTransformRequest, value: Types.Settings) =
            { state with Settings = Some value }

        [<CustomOperation("sync")>]
        member _.Sync(state: TransformUpdateTransformRequest, value: Types.SyncContainer) =
            { state with Sync = Some value }

        [<CustomOperation("retentionPolicy")>]
        member _.RetentionPolicy(state: TransformUpdateTransformRequest, value: Types.RetentionPolicyContainer option) =
            { state with RetentionPolicy = Some value }

    let transformUpdateTransformRequest = TransformUpdateTransformRequestBuilder()

    module UpdateTransform =
        let withDeferValidation (value: bool) (req: TransformUpdateTransformRequest) =
            { req with DeferValidation = Some value }
        let withTimeout (value: Types.Duration) (req: TransformUpdateTransformRequest) =
            { req with Timeout = Some value }
        let withDest (value: Types.TransformTypesDestination) (req: TransformUpdateTransformRequest) =
            { req with Dest = Some value }
        let withDescription (value: string) (req: TransformUpdateTransformRequest) =
            { req with Description = Some value }
        let withFrequency (value: Types.Duration) (req: TransformUpdateTransformRequest) =
            { req with Frequency = Some value }
        let withMeta (value: Types.Metadata) (req: TransformUpdateTransformRequest) =
            { req with Meta = Some value }
        let withSource (value: Types.TransformTypesSource) (req: TransformUpdateTransformRequest) =
            { req with Source = Some value }
        let withSettings (value: Types.Settings) (req: TransformUpdateTransformRequest) =
            { req with Settings = Some value }
        let withSync (value: Types.SyncContainer) (req: TransformUpdateTransformRequest) =
            { req with Sync = Some value }
        let withRetentionPolicy (value: Types.RetentionPolicyContainer option) (req: TransformUpdateTransformRequest) =
            { req with RetentionPolicy = Some value }

    type TransformUpgradeTransformsRequest = {
        DryRun: bool option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: TransformUpgradeTransformsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_transform/_upgrade"
                let queryParams =
                    [
                        req.DryRun |> Option.map (fun v -> "dry_run", Fes.Http.toQueryValue v)
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

    type TransformUpgradeTransformsResponse = System.Text.Json.JsonElement

    type TransformUpgradeTransformsRequestBuilder() =
        member _.Yield(_: unit) : TransformUpgradeTransformsRequest =
            {
                DryRun = None
                Timeout = None
            }

        [<CustomOperation("dryRun")>]
        member _.DryRun(state: TransformUpgradeTransformsRequest, value: bool) =
            { state with DryRun = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TransformUpgradeTransformsRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let transformUpgradeTransformsRequest = TransformUpgradeTransformsRequestBuilder()

    module UpgradeTransforms =
        let withDryRun (value: bool) (req: TransformUpgradeTransformsRequest) =
            { req with DryRun = Some value }
        let withTimeout (value: Types.Duration) (req: TransformUpgradeTransformsRequest) =
            { req with Timeout = Some value }


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module MlOperations =

    type MlClearTrainedModelDeploymentCacheRequest = {
        ModelId: CoreTypes.Id
    }

        with
        static member ToRequest(req: MlClearTrainedModelDeploymentCacheRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{req.ModelId}/deployment/cache/_clear"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type MlClearTrainedModelDeploymentCacheResponse = System.Text.Json.JsonElement

    type MlClearTrainedModelDeploymentCacheRequestBuilder() =
        member _.Yield(_: unit) : MlClearTrainedModelDeploymentCacheRequest =
            {
                ModelId = Unchecked.defaultof<_>
            }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: MlClearTrainedModelDeploymentCacheRequest, value: CoreTypes.Id) =
            { state with ModelId = value }

    let mlClearTrainedModelDeploymentCacheRequest = MlClearTrainedModelDeploymentCacheRequestBuilder()

    type MlCloseJobRequest = {
        JobId: CoreTypes.Id
        AllowNoMatch: bool option
        Force: bool option
        Timeout: CoreTypes.Duration option
        AllowNoMatch: bool option
        Force: bool option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: MlCloseJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{req.JobId}/_close"
                let queryParams =
                    [
                        req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
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
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type MlCloseJobResponse = System.Text.Json.JsonElement

    type MlCloseJobRequestBuilder() =
        member _.Yield(_: unit) : MlCloseJobRequest =
            {
                JobId = Unchecked.defaultof<_>
                AllowNoMatch = None
                Force = None
                Timeout = None
                AllowNoMatch = None
                Force = None
                Timeout = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlCloseJobRequest, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlCloseJobRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("force")>]
        member _.Force(state: MlCloseJobRequest, value: bool) =
            { state with Force = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlCloseJobRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlCloseJobRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("force")>]
        member _.Force(state: MlCloseJobRequest, value: bool) =
            { state with Force = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlCloseJobRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let mlCloseJobRequest = MlCloseJobRequestBuilder()

    module CloseJob =
        let withAllowNoMatch (value: bool) (req: MlCloseJobRequest) =
            { req with AllowNoMatch = Some value }
        let withForce (value: bool) (req: MlCloseJobRequest) =
            { req with Force = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: MlCloseJobRequest) =
            { req with Timeout = Some value }
        let withAllowNoMatch (value: bool) (req: MlCloseJobRequest) =
            { req with AllowNoMatch = Some value }
        let withForce (value: bool) (req: MlCloseJobRequest) =
            { req with Force = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: MlCloseJobRequest) =
            { req with Timeout = Some value }

    type MlDeleteCalendarRequest = {
        CalendarId: CoreTypes.Id
    }

        with
        static member ToRequest(req: MlDeleteCalendarRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/calendars/{req.CalendarId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type MlDeleteCalendarResponse = CoreTypes.AcknowledgedResponseBase

    type MlDeleteCalendarRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteCalendarRequest =
            {
                CalendarId = Unchecked.defaultof<_>
            }

        [<CustomOperation("calendarId")>]
        member _.CalendarId(state: MlDeleteCalendarRequest, value: CoreTypes.Id) =
            { state with CalendarId = value }

    let mlDeleteCalendarRequest = MlDeleteCalendarRequestBuilder()

    type MlDeleteCalendarEventRequest = {
        CalendarId: CoreTypes.Id
        EventId: CoreTypes.Id
    }

        with
        static member ToRequest(req: MlDeleteCalendarEventRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/calendars/{req.CalendarId}/events/{req.EventId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type MlDeleteCalendarEventResponse = CoreTypes.AcknowledgedResponseBase

    type MlDeleteCalendarEventRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteCalendarEventRequest =
            {
                CalendarId = Unchecked.defaultof<_>
                EventId = Unchecked.defaultof<_>
            }

        [<CustomOperation("calendarId")>]
        member _.CalendarId(state: MlDeleteCalendarEventRequest, value: CoreTypes.Id) =
            { state with CalendarId = value }

        [<CustomOperation("eventId")>]
        member _.EventId(state: MlDeleteCalendarEventRequest, value: CoreTypes.Id) =
            { state with EventId = value }

    let mlDeleteCalendarEventRequest = MlDeleteCalendarEventRequestBuilder()

    type MlDeleteCalendarJobRequest = {
        CalendarId: CoreTypes.Id
        JobId: CoreTypes.Ids
    }

        with
        static member ToRequest(req: MlDeleteCalendarJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/calendars/{req.CalendarId}/jobs/{req.JobId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type MlDeleteCalendarJobResponse = System.Text.Json.JsonElement

    type MlDeleteCalendarJobRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteCalendarJobRequest =
            {
                CalendarId = Unchecked.defaultof<_>
                JobId = Unchecked.defaultof<_>
            }

        [<CustomOperation("calendarId")>]
        member _.CalendarId(state: MlDeleteCalendarJobRequest, value: CoreTypes.Id) =
            { state with CalendarId = value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlDeleteCalendarJobRequest, value: CoreTypes.Ids) =
            { state with JobId = value }

    let mlDeleteCalendarJobRequest = MlDeleteCalendarJobRequestBuilder()

    type MlDeleteDataFrameAnalyticsRequest = {
        Id: CoreTypes.Id
        Force: bool option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: MlDeleteDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/data_frame/analytics/{req.Id}"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type MlDeleteDataFrameAnalyticsResponse = CoreTypes.AcknowledgedResponseBase

    type MlDeleteDataFrameAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteDataFrameAnalyticsRequest =
            {
                Id = Unchecked.defaultof<_>
                Force = None
                Timeout = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: MlDeleteDataFrameAnalyticsRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("force")>]
        member _.Force(state: MlDeleteDataFrameAnalyticsRequest, value: bool) =
            { state with Force = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlDeleteDataFrameAnalyticsRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let mlDeleteDataFrameAnalyticsRequest = MlDeleteDataFrameAnalyticsRequestBuilder()

    module DeleteDataFrameAnalytics =
        let withForce (value: bool) (req: MlDeleteDataFrameAnalyticsRequest) =
            { req with Force = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: MlDeleteDataFrameAnalyticsRequest) =
            { req with Timeout = Some value }

    type MlDeleteDatafeedRequest = {
        DatafeedId: CoreTypes.Id
        Force: bool option
    }

        with
        static member ToRequest(req: MlDeleteDatafeedRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/datafeeds/{req.DatafeedId}"
                let queryParams =
                    [
                        req.Force |> Option.map (fun v -> "force", Fes.Http.toQueryValue v)
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

    type MlDeleteDatafeedResponse = CoreTypes.AcknowledgedResponseBase

    type MlDeleteDatafeedRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteDatafeedRequest =
            {
                DatafeedId = Unchecked.defaultof<_>
                Force = None
            }

        [<CustomOperation("datafeedId")>]
        member _.DatafeedId(state: MlDeleteDatafeedRequest, value: CoreTypes.Id) =
            { state with DatafeedId = value }

        [<CustomOperation("force")>]
        member _.Force(state: MlDeleteDatafeedRequest, value: bool) =
            { state with Force = Some value }

    let mlDeleteDatafeedRequest = MlDeleteDatafeedRequestBuilder()

    module DeleteDatafeed =
        let withForce (value: bool) (req: MlDeleteDatafeedRequest) =
            { req with Force = Some value }

    type MlDeleteExpiredDataRequest = {
        JobId: CoreTypes.Id
        RequestsPerSecond: CoreTypes.Float option
        Timeout: CoreTypes.Duration option
        RequestsPerSecond: CoreTypes.Float option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: MlDeleteExpiredDataRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/_delete_expired_data/{req.JobId}"
                let queryParams =
                    [
                        req.RequestsPerSecond |> Option.map (fun v -> "requests_per_second", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type MlDeleteExpiredDataResponse = System.Text.Json.JsonElement

    type MlDeleteExpiredDataRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteExpiredDataRequest =
            {
                JobId = Unchecked.defaultof<_>
                RequestsPerSecond = None
                Timeout = None
                RequestsPerSecond = None
                Timeout = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlDeleteExpiredDataRequest, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("requestsPerSecond")>]
        member _.RequestsPerSecond(state: MlDeleteExpiredDataRequest, value: CoreTypes.Float) =
            { state with RequestsPerSecond = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlDeleteExpiredDataRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("requestsPerSecond")>]
        member _.RequestsPerSecond(state: MlDeleteExpiredDataRequest, value: CoreTypes.Float) =
            { state with RequestsPerSecond = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlDeleteExpiredDataRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let mlDeleteExpiredDataRequest = MlDeleteExpiredDataRequestBuilder()

    module DeleteExpiredData =
        let withRequestsPerSecond (value: CoreTypes.Float) (req: MlDeleteExpiredDataRequest) =
            { req with RequestsPerSecond = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: MlDeleteExpiredDataRequest) =
            { req with Timeout = Some value }
        let withRequestsPerSecond (value: CoreTypes.Float) (req: MlDeleteExpiredDataRequest) =
            { req with RequestsPerSecond = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: MlDeleteExpiredDataRequest) =
            { req with Timeout = Some value }

    type MlDeleteFilterRequest = {
        FilterId: CoreTypes.Id
    }

        with
        static member ToRequest(req: MlDeleteFilterRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/filters/{req.FilterId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type MlDeleteFilterResponse = CoreTypes.AcknowledgedResponseBase

    type MlDeleteFilterRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteFilterRequest =
            {
                FilterId = Unchecked.defaultof<_>
            }

        [<CustomOperation("filterId")>]
        member _.FilterId(state: MlDeleteFilterRequest, value: CoreTypes.Id) =
            { state with FilterId = value }

    let mlDeleteFilterRequest = MlDeleteFilterRequestBuilder()

    type MlDeleteForecastRequest = {
        JobId: CoreTypes.Id
        ForecastId: CoreTypes.Id
        AllowNoForecasts: bool option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: MlDeleteForecastRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{req.JobId}/_forecast/{req.ForecastId}"
                let queryParams =
                    [
                        req.AllowNoForecasts |> Option.map (fun v -> "allow_no_forecasts", Fes.Http.toQueryValue v)
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

    type MlDeleteForecastResponse = CoreTypes.AcknowledgedResponseBase

    type MlDeleteForecastRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteForecastRequest =
            {
                JobId = Unchecked.defaultof<_>
                ForecastId = Unchecked.defaultof<_>
                AllowNoForecasts = None
                Timeout = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlDeleteForecastRequest, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("forecastId")>]
        member _.ForecastId(state: MlDeleteForecastRequest, value: CoreTypes.Id) =
            { state with ForecastId = value }

        [<CustomOperation("allowNoForecasts")>]
        member _.AllowNoForecasts(state: MlDeleteForecastRequest, value: bool) =
            { state with AllowNoForecasts = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlDeleteForecastRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let mlDeleteForecastRequest = MlDeleteForecastRequestBuilder()

    module DeleteForecast =
        let withAllowNoForecasts (value: bool) (req: MlDeleteForecastRequest) =
            { req with AllowNoForecasts = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: MlDeleteForecastRequest) =
            { req with Timeout = Some value }

    type MlDeleteJobRequest = {
        JobId: CoreTypes.Id
        Force: bool option
        DeleteUserAnnotations: bool option
        WaitForCompletion: bool option
    }

        with
        static member ToRequest(req: MlDeleteJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{req.JobId}"
                let queryParams =
                    [
                        req.Force |> Option.map (fun v -> "force", Fes.Http.toQueryValue v)
                        req.DeleteUserAnnotations |> Option.map (fun v -> "delete_user_annotations", Fes.Http.toQueryValue v)
                        req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
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

    type MlDeleteJobResponse = CoreTypes.AcknowledgedResponseBase

    type MlDeleteJobRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteJobRequest =
            {
                JobId = Unchecked.defaultof<_>
                Force = None
                DeleteUserAnnotations = None
                WaitForCompletion = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlDeleteJobRequest, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("force")>]
        member _.Force(state: MlDeleteJobRequest, value: bool) =
            { state with Force = Some value }

        [<CustomOperation("deleteUserAnnotations")>]
        member _.DeleteUserAnnotations(state: MlDeleteJobRequest, value: bool) =
            { state with DeleteUserAnnotations = Some value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: MlDeleteJobRequest, value: bool) =
            { state with WaitForCompletion = Some value }

    let mlDeleteJobRequest = MlDeleteJobRequestBuilder()

    module DeleteJob =
        let withForce (value: bool) (req: MlDeleteJobRequest) =
            { req with Force = Some value }
        let withDeleteUserAnnotations (value: bool) (req: MlDeleteJobRequest) =
            { req with DeleteUserAnnotations = Some value }
        let withWaitForCompletion (value: bool) (req: MlDeleteJobRequest) =
            { req with WaitForCompletion = Some value }

    type MlDeleteModelSnapshotRequest = {
        JobId: CoreTypes.Id
        SnapshotId: CoreTypes.Id
    }

        with
        static member ToRequest(req: MlDeleteModelSnapshotRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{req.JobId}/model_snapshots/{req.SnapshotId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type MlDeleteModelSnapshotResponse = CoreTypes.AcknowledgedResponseBase

    type MlDeleteModelSnapshotRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteModelSnapshotRequest =
            {
                JobId = Unchecked.defaultof<_>
                SnapshotId = Unchecked.defaultof<_>
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlDeleteModelSnapshotRequest, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("snapshotId")>]
        member _.SnapshotId(state: MlDeleteModelSnapshotRequest, value: CoreTypes.Id) =
            { state with SnapshotId = value }

    let mlDeleteModelSnapshotRequest = MlDeleteModelSnapshotRequestBuilder()

    type MlDeleteTrainedModelRequest = {
        ModelId: CoreTypes.Id
        Force: bool option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: MlDeleteTrainedModelRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{req.ModelId}"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type MlDeleteTrainedModelResponse = CoreTypes.AcknowledgedResponseBase

    type MlDeleteTrainedModelRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteTrainedModelRequest =
            {
                ModelId = Unchecked.defaultof<_>
                Force = None
                Timeout = None
            }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: MlDeleteTrainedModelRequest, value: CoreTypes.Id) =
            { state with ModelId = value }

        [<CustomOperation("force")>]
        member _.Force(state: MlDeleteTrainedModelRequest, value: bool) =
            { state with Force = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlDeleteTrainedModelRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let mlDeleteTrainedModelRequest = MlDeleteTrainedModelRequestBuilder()

    module DeleteTrainedModel =
        let withForce (value: bool) (req: MlDeleteTrainedModelRequest) =
            { req with Force = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: MlDeleteTrainedModelRequest) =
            { req with Timeout = Some value }

    type MlDeleteTrainedModelAliasRequest = {
        ModelAlias: CoreTypes.Name
        ModelId: CoreTypes.Id
    }

        with
        static member ToRequest(req: MlDeleteTrainedModelAliasRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{req.ModelId}/model_aliases/{req.ModelAlias}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type MlDeleteTrainedModelAliasResponse = CoreTypes.AcknowledgedResponseBase

    type MlDeleteTrainedModelAliasRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteTrainedModelAliasRequest =
            {
                ModelAlias = Unchecked.defaultof<_>
                ModelId = Unchecked.defaultof<_>
            }

        [<CustomOperation("modelAlias")>]
        member _.ModelAlias(state: MlDeleteTrainedModelAliasRequest, value: CoreTypes.Name) =
            { state with ModelAlias = value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: MlDeleteTrainedModelAliasRequest, value: CoreTypes.Id) =
            { state with ModelId = value }

    let mlDeleteTrainedModelAliasRequest = MlDeleteTrainedModelAliasRequestBuilder()

    type MlEstimateModelMemoryRequest = {
        AnalysisConfig: MlTypes.AnalysisConfig option
        MaxBucketCardinality: Map<CoreTypes.Field, CoreTypes.Long> option
        OverallCardinality: Map<CoreTypes.Field, CoreTypes.Long> option
    }

        with
        static member ToRequest(req: MlEstimateModelMemoryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/_estimate_model_memory"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type MlEstimateModelMemoryResponse = System.Text.Json.JsonElement

    type MlEstimateModelMemoryRequestBuilder() =
        member _.Yield(_: unit) : MlEstimateModelMemoryRequest =
            {
                AnalysisConfig = None
                MaxBucketCardinality = None
                OverallCardinality = None
            }

        [<CustomOperation("analysisConfig")>]
        member _.AnalysisConfig(state: MlEstimateModelMemoryRequest, value: MlTypes.AnalysisConfig) =
            { state with AnalysisConfig = Some value }

        [<CustomOperation("maxBucketCardinality")>]
        member _.MaxBucketCardinality(state: MlEstimateModelMemoryRequest, value: Map<CoreTypes.Field, CoreTypes.Long>) =
            { state with MaxBucketCardinality = Some value }

        [<CustomOperation("overallCardinality")>]
        member _.OverallCardinality(state: MlEstimateModelMemoryRequest, value: Map<CoreTypes.Field, CoreTypes.Long>) =
            { state with OverallCardinality = Some value }

    let mlEstimateModelMemoryRequest = MlEstimateModelMemoryRequestBuilder()

    module EstimateModelMemory =
        let withAnalysisConfig (value: MlTypes.AnalysisConfig) (req: MlEstimateModelMemoryRequest) =
            { req with AnalysisConfig = Some value }
        let withMaxBucketCardinality (value: Map<CoreTypes.Field, CoreTypes.Long>) (req: MlEstimateModelMemoryRequest) =
            { req with MaxBucketCardinality = Some value }
        let withOverallCardinality (value: Map<CoreTypes.Field, CoreTypes.Long>) (req: MlEstimateModelMemoryRequest) =
            { req with OverallCardinality = Some value }

    type MlEvaluateDataFrameRequest = {
        Evaluation: MlTypes.DataframeEvaluationContainer
        Index: CoreTypes.IndexName
        Query: CoreTypes.QueryContainer option
    }

        with
        static member ToRequest(req: MlEvaluateDataFrameRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/data_frame/_evaluate"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type MlEvaluateDataFrameResponse = System.Text.Json.JsonElement

    type MlEvaluateDataFrameRequestBuilder() =
        member _.Yield(_: unit) : MlEvaluateDataFrameRequest =
            {
                Evaluation = Unchecked.defaultof<_>
                Index = Unchecked.defaultof<_>
                Query = None
            }

        [<CustomOperation("evaluation")>]
        member _.Evaluation(state: MlEvaluateDataFrameRequest, value: MlTypes.DataframeEvaluationContainer) =
            { state with Evaluation = value }

        [<CustomOperation("index")>]
        member _.Index(state: MlEvaluateDataFrameRequest, value: CoreTypes.IndexName) =
            { state with Index = value }

        [<CustomOperation("query")>]
        member _.Query(state: MlEvaluateDataFrameRequest, value: CoreTypes.QueryContainer) =
            { state with Query = Some value }

    let mlEvaluateDataFrameRequest = MlEvaluateDataFrameRequestBuilder()

    module EvaluateDataFrame =
        let withEvaluation (value: MlTypes.DataframeEvaluationContainer) (req: MlEvaluateDataFrameRequest) =
            { req with Evaluation = value }
        let withIndex (value: CoreTypes.IndexName) (req: MlEvaluateDataFrameRequest) =
            { req with Index = value }
        let withQuery (value: CoreTypes.QueryContainer) (req: MlEvaluateDataFrameRequest) =
            { req with Query = Some value }

    type MlExplainDataFrameAnalyticsRequest = {
        Id: CoreTypes.Id
        Source: MlTypes.DataframeAnalyticsSource option
        Dest: MlTypes.DataframeAnalyticsDestination option
        Analysis: MlTypes.DataframeAnalysisContainer option
        Description: string option
        ModelMemoryLimit: string option
        MaxNumThreads: CoreTypes.Integer option
        AnalyzedFields: MlTypes.DataframeAnalysisAnalyzedFields option
        AllowLazyStart: bool option
    }

        with
        static member ToRequest(req: MlExplainDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/data_frame/analytics/{req.Id}/_explain"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type MlExplainDataFrameAnalyticsResponse = System.Text.Json.JsonElement

    type MlExplainDataFrameAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : MlExplainDataFrameAnalyticsRequest =
            {
                Id = Unchecked.defaultof<_>
                Source = None
                Dest = None
                Analysis = None
                Description = None
                ModelMemoryLimit = None
                MaxNumThreads = None
                AnalyzedFields = None
                AllowLazyStart = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: MlExplainDataFrameAnalyticsRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("source")>]
        member _.Source(state: MlExplainDataFrameAnalyticsRequest, value: MlTypes.DataframeAnalyticsSource) =
            { state with Source = Some value }

        [<CustomOperation("dest")>]
        member _.Dest(state: MlExplainDataFrameAnalyticsRequest, value: MlTypes.DataframeAnalyticsDestination) =
            { state with Dest = Some value }

        [<CustomOperation("analysis")>]
        member _.Analysis(state: MlExplainDataFrameAnalyticsRequest, value: MlTypes.DataframeAnalysisContainer) =
            { state with Analysis = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: MlExplainDataFrameAnalyticsRequest, value: string) =
            { state with Description = Some value }

        [<CustomOperation("modelMemoryLimit")>]
        member _.ModelMemoryLimit(state: MlExplainDataFrameAnalyticsRequest, value: string) =
            { state with ModelMemoryLimit = Some value }

        [<CustomOperation("maxNumThreads")>]
        member _.MaxNumThreads(state: MlExplainDataFrameAnalyticsRequest, value: CoreTypes.Integer) =
            { state with MaxNumThreads = Some value }

        [<CustomOperation("analyzedFields")>]
        member _.AnalyzedFields(state: MlExplainDataFrameAnalyticsRequest, value: MlTypes.DataframeAnalysisAnalyzedFields) =
            { state with AnalyzedFields = Some value }

        [<CustomOperation("allowLazyStart")>]
        member _.AllowLazyStart(state: MlExplainDataFrameAnalyticsRequest, value: bool) =
            { state with AllowLazyStart = Some value }

    let mlExplainDataFrameAnalyticsRequest = MlExplainDataFrameAnalyticsRequestBuilder()

    module ExplainDataFrameAnalytics =
        let withSource (value: MlTypes.DataframeAnalyticsSource) (req: MlExplainDataFrameAnalyticsRequest) =
            { req with Source = Some value }
        let withDest (value: MlTypes.DataframeAnalyticsDestination) (req: MlExplainDataFrameAnalyticsRequest) =
            { req with Dest = Some value }
        let withAnalysis (value: MlTypes.DataframeAnalysisContainer) (req: MlExplainDataFrameAnalyticsRequest) =
            { req with Analysis = Some value }
        let withDescription (value: string) (req: MlExplainDataFrameAnalyticsRequest) =
            { req with Description = Some value }
        let withModelMemoryLimit (value: string) (req: MlExplainDataFrameAnalyticsRequest) =
            { req with ModelMemoryLimit = Some value }
        let withMaxNumThreads (value: CoreTypes.Integer) (req: MlExplainDataFrameAnalyticsRequest) =
            { req with MaxNumThreads = Some value }
        let withAnalyzedFields (value: MlTypes.DataframeAnalysisAnalyzedFields) (req: MlExplainDataFrameAnalyticsRequest) =
            { req with AnalyzedFields = Some value }
        let withAllowLazyStart (value: bool) (req: MlExplainDataFrameAnalyticsRequest) =
            { req with AllowLazyStart = Some value }

    type MlFlushJobRequest = {
        JobId: CoreTypes.Id
        AdvanceTime: CoreTypes.DateTime option
        CalcInterim: bool option
        End: CoreTypes.DateTime option
        SkipTime: CoreTypes.DateTime option
        Start: CoreTypes.DateTime option
        AdvanceTime: CoreTypes.DateTime option
        CalcInterim: bool option
        End: CoreTypes.DateTime option
        SkipTime: CoreTypes.DateTime option
        Start: CoreTypes.DateTime option
    }

        with
        static member ToRequest(req: MlFlushJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{req.JobId}/_flush"
                let queryParams =
                    [
                        req.AdvanceTime |> Option.map (fun v -> "advance_time", Fes.Http.toQueryValue v)
                        req.CalcInterim |> Option.map (fun v -> "calc_interim", Fes.Http.toQueryValue v)
                        req.End |> Option.map (fun v -> "end", Fes.Http.toQueryValue v)
                        req.SkipTime |> Option.map (fun v -> "skip_time", Fes.Http.toQueryValue v)
                        req.Start |> Option.map (fun v -> "start", Fes.Http.toQueryValue v)
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

    type MlFlushJobResponse = System.Text.Json.JsonElement

    type MlFlushJobRequestBuilder() =
        member _.Yield(_: unit) : MlFlushJobRequest =
            {
                JobId = Unchecked.defaultof<_>
                AdvanceTime = None
                CalcInterim = None
                End = None
                SkipTime = None
                Start = None
                AdvanceTime = None
                CalcInterim = None
                End = None
                SkipTime = None
                Start = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlFlushJobRequest, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("advanceTime")>]
        member _.AdvanceTime(state: MlFlushJobRequest, value: CoreTypes.DateTime) =
            { state with AdvanceTime = Some value }

        [<CustomOperation("calcInterim")>]
        member _.CalcInterim(state: MlFlushJobRequest, value: bool) =
            { state with CalcInterim = Some value }

        [<CustomOperation("end'")>]
        member _.End(state: MlFlushJobRequest, value: CoreTypes.DateTime) =
            { state with End = Some value }

        [<CustomOperation("skipTime")>]
        member _.SkipTime(state: MlFlushJobRequest, value: CoreTypes.DateTime) =
            { state with SkipTime = Some value }

        [<CustomOperation("start")>]
        member _.Start(state: MlFlushJobRequest, value: CoreTypes.DateTime) =
            { state with Start = Some value }

        [<CustomOperation("advanceTime")>]
        member _.AdvanceTime(state: MlFlushJobRequest, value: CoreTypes.DateTime) =
            { state with AdvanceTime = Some value }

        [<CustomOperation("calcInterim")>]
        member _.CalcInterim(state: MlFlushJobRequest, value: bool) =
            { state with CalcInterim = Some value }

        [<CustomOperation("end'")>]
        member _.End(state: MlFlushJobRequest, value: CoreTypes.DateTime) =
            { state with End = Some value }

        [<CustomOperation("skipTime")>]
        member _.SkipTime(state: MlFlushJobRequest, value: CoreTypes.DateTime) =
            { state with SkipTime = Some value }

        [<CustomOperation("start")>]
        member _.Start(state: MlFlushJobRequest, value: CoreTypes.DateTime) =
            { state with Start = Some value }

    let mlFlushJobRequest = MlFlushJobRequestBuilder()

    module FlushJob =
        let withAdvanceTime (value: CoreTypes.DateTime) (req: MlFlushJobRequest) =
            { req with AdvanceTime = Some value }
        let withCalcInterim (value: bool) (req: MlFlushJobRequest) =
            { req with CalcInterim = Some value }
        let withEnd (value: CoreTypes.DateTime) (req: MlFlushJobRequest) =
            { req with End = Some value }
        let withSkipTime (value: CoreTypes.DateTime) (req: MlFlushJobRequest) =
            { req with SkipTime = Some value }
        let withStart (value: CoreTypes.DateTime) (req: MlFlushJobRequest) =
            { req with Start = Some value }
        let withAdvanceTime (value: CoreTypes.DateTime) (req: MlFlushJobRequest) =
            { req with AdvanceTime = Some value }
        let withCalcInterim (value: bool) (req: MlFlushJobRequest) =
            { req with CalcInterim = Some value }
        let withEnd (value: CoreTypes.DateTime) (req: MlFlushJobRequest) =
            { req with End = Some value }
        let withSkipTime (value: CoreTypes.DateTime) (req: MlFlushJobRequest) =
            { req with SkipTime = Some value }
        let withStart (value: CoreTypes.DateTime) (req: MlFlushJobRequest) =
            { req with Start = Some value }

    type MlForecastRequest = {
        JobId: CoreTypes.Id
        Duration: CoreTypes.Duration option
        ExpiresIn: CoreTypes.Duration option
        MaxModelMemory: string option
        Duration: CoreTypes.Duration option
        ExpiresIn: CoreTypes.Duration option
        MaxModelMemory: string option
    }

        with
        static member ToRequest(req: MlForecastRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{req.JobId}/_forecast"
                let queryParams =
                    [
                        req.Duration |> Option.map (fun v -> "duration", Fes.Http.toQueryValue v)
                        req.ExpiresIn |> Option.map (fun v -> "expires_in", Fes.Http.toQueryValue v)
                        req.MaxModelMemory |> Option.map (fun v -> "max_model_memory", Fes.Http.toQueryValue v)
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

    type MlForecastResponse = System.Text.Json.JsonElement

    type MlForecastRequestBuilder() =
        member _.Yield(_: unit) : MlForecastRequest =
            {
                JobId = Unchecked.defaultof<_>
                Duration = None
                ExpiresIn = None
                MaxModelMemory = None
                Duration = None
                ExpiresIn = None
                MaxModelMemory = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlForecastRequest, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("duration")>]
        member _.Duration(state: MlForecastRequest, value: CoreTypes.Duration) =
            { state with Duration = Some value }

        [<CustomOperation("expiresIn")>]
        member _.ExpiresIn(state: MlForecastRequest, value: CoreTypes.Duration) =
            { state with ExpiresIn = Some value }

        [<CustomOperation("maxModelMemory")>]
        member _.MaxModelMemory(state: MlForecastRequest, value: string) =
            { state with MaxModelMemory = Some value }

        [<CustomOperation("duration")>]
        member _.Duration(state: MlForecastRequest, value: CoreTypes.Duration) =
            { state with Duration = Some value }

        [<CustomOperation("expiresIn")>]
        member _.ExpiresIn(state: MlForecastRequest, value: CoreTypes.Duration) =
            { state with ExpiresIn = Some value }

        [<CustomOperation("maxModelMemory")>]
        member _.MaxModelMemory(state: MlForecastRequest, value: string) =
            { state with MaxModelMemory = Some value }

    let mlForecastRequest = MlForecastRequestBuilder()

    module Forecast =
        let withDuration (value: CoreTypes.Duration) (req: MlForecastRequest) =
            { req with Duration = Some value }
        let withExpiresIn (value: CoreTypes.Duration) (req: MlForecastRequest) =
            { req with ExpiresIn = Some value }
        let withMaxModelMemory (value: string) (req: MlForecastRequest) =
            { req with MaxModelMemory = Some value }
        let withDuration (value: CoreTypes.Duration) (req: MlForecastRequest) =
            { req with Duration = Some value }
        let withExpiresIn (value: CoreTypes.Duration) (req: MlForecastRequest) =
            { req with ExpiresIn = Some value }
        let withMaxModelMemory (value: string) (req: MlForecastRequest) =
            { req with MaxModelMemory = Some value }

    type MlGetBucketsRequest = {
        JobId: CoreTypes.Id
        Timestamp: CoreTypes.DateTime
        AnomalyScore: CoreTypes.Double option
        Desc: bool option
        End: CoreTypes.DateTime option
        ExcludeInterim: bool option
        Expand: bool option
        From: CoreTypes.Integer option
        Size: CoreTypes.Integer option
        Sort: CoreTypes.Field option
        Start: CoreTypes.DateTime option
        AnomalyScore: CoreTypes.Double option
        Desc: bool option
        End: CoreTypes.DateTime option
        ExcludeInterim: bool option
        Expand: bool option
        Page: MlTypes.Page option
        Sort: CoreTypes.Field option
        Start: CoreTypes.DateTime option
    }

        with
        static member ToRequest(req: MlGetBucketsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{req.JobId}/results/buckets/{req.Timestamp}"
                let queryParams =
                    [
                        req.AnomalyScore |> Option.map (fun v -> "anomaly_score", Fes.Http.toQueryValue v)
                        req.Desc |> Option.map (fun v -> "desc", Fes.Http.toQueryValue v)
                        req.End |> Option.map (fun v -> "end", Fes.Http.toQueryValue v)
                        req.ExcludeInterim |> Option.map (fun v -> "exclude_interim", Fes.Http.toQueryValue v)
                        req.Expand |> Option.map (fun v -> "expand", Fes.Http.toQueryValue v)
                        req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                        req.Sort |> Option.map (fun v -> "sort", Fes.Http.toQueryValue v)
                        req.Start |> Option.map (fun v -> "start", Fes.Http.toQueryValue v)
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

    type MlGetBucketsResponse = System.Text.Json.JsonElement

    type MlGetBucketsRequestBuilder() =
        member _.Yield(_: unit) : MlGetBucketsRequest =
            {
                JobId = Unchecked.defaultof<_>
                Timestamp = Unchecked.defaultof<_>
                AnomalyScore = None
                Desc = None
                End = None
                ExcludeInterim = None
                Expand = None
                From = None
                Size = None
                Sort = None
                Start = None
                AnomalyScore = None
                Desc = None
                End = None
                ExcludeInterim = None
                Expand = None
                Page = None
                Sort = None
                Start = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlGetBucketsRequest, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: MlGetBucketsRequest, value: CoreTypes.DateTime) =
            { state with Timestamp = value }

        [<CustomOperation("anomalyScore")>]
        member _.AnomalyScore(state: MlGetBucketsRequest, value: CoreTypes.Double) =
            { state with AnomalyScore = Some value }

        [<CustomOperation("desc")>]
        member _.Desc(state: MlGetBucketsRequest, value: bool) =
            { state with Desc = Some value }

        [<CustomOperation("end'")>]
        member _.End(state: MlGetBucketsRequest, value: CoreTypes.DateTime) =
            { state with End = Some value }

        [<CustomOperation("excludeInterim")>]
        member _.ExcludeInterim(state: MlGetBucketsRequest, value: bool) =
            { state with ExcludeInterim = Some value }

        [<CustomOperation("expand")>]
        member _.Expand(state: MlGetBucketsRequest, value: bool) =
            { state with Expand = Some value }

        [<CustomOperation("from")>]
        member _.From(state: MlGetBucketsRequest, value: CoreTypes.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MlGetBucketsRequest, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: MlGetBucketsRequest, value: CoreTypes.Field) =
            { state with Sort = Some value }

        [<CustomOperation("start")>]
        member _.Start(state: MlGetBucketsRequest, value: CoreTypes.DateTime) =
            { state with Start = Some value }

        [<CustomOperation("anomalyScore")>]
        member _.AnomalyScore(state: MlGetBucketsRequest, value: CoreTypes.Double) =
            { state with AnomalyScore = Some value }

        [<CustomOperation("desc")>]
        member _.Desc(state: MlGetBucketsRequest, value: bool) =
            { state with Desc = Some value }

        [<CustomOperation("end'")>]
        member _.End(state: MlGetBucketsRequest, value: CoreTypes.DateTime) =
            { state with End = Some value }

        [<CustomOperation("excludeInterim")>]
        member _.ExcludeInterim(state: MlGetBucketsRequest, value: bool) =
            { state with ExcludeInterim = Some value }

        [<CustomOperation("expand")>]
        member _.Expand(state: MlGetBucketsRequest, value: bool) =
            { state with Expand = Some value }

        [<CustomOperation("page")>]
        member _.Page(state: MlGetBucketsRequest, value: MlTypes.Page) =
            { state with Page = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: MlGetBucketsRequest, value: CoreTypes.Field) =
            { state with Sort = Some value }

        [<CustomOperation("start")>]
        member _.Start(state: MlGetBucketsRequest, value: CoreTypes.DateTime) =
            { state with Start = Some value }

    let mlGetBucketsRequest = MlGetBucketsRequestBuilder()

    module GetBuckets =
        let withAnomalyScore (value: CoreTypes.Double) (req: MlGetBucketsRequest) =
            { req with AnomalyScore = Some value }
        let withDesc (value: bool) (req: MlGetBucketsRequest) =
            { req with Desc = Some value }
        let withEnd (value: CoreTypes.DateTime) (req: MlGetBucketsRequest) =
            { req with End = Some value }
        let withExcludeInterim (value: bool) (req: MlGetBucketsRequest) =
            { req with ExcludeInterim = Some value }
        let withExpand (value: bool) (req: MlGetBucketsRequest) =
            { req with Expand = Some value }
        let withFrom (value: CoreTypes.Integer) (req: MlGetBucketsRequest) =
            { req with From = Some value }
        let withSize (value: CoreTypes.Integer) (req: MlGetBucketsRequest) =
            { req with Size = Some value }
        let withSort (value: CoreTypes.Field) (req: MlGetBucketsRequest) =
            { req with Sort = Some value }
        let withStart (value: CoreTypes.DateTime) (req: MlGetBucketsRequest) =
            { req with Start = Some value }
        let withAnomalyScore (value: CoreTypes.Double) (req: MlGetBucketsRequest) =
            { req with AnomalyScore = Some value }
        let withDesc (value: bool) (req: MlGetBucketsRequest) =
            { req with Desc = Some value }
        let withEnd (value: CoreTypes.DateTime) (req: MlGetBucketsRequest) =
            { req with End = Some value }
        let withExcludeInterim (value: bool) (req: MlGetBucketsRequest) =
            { req with ExcludeInterim = Some value }
        let withExpand (value: bool) (req: MlGetBucketsRequest) =
            { req with Expand = Some value }
        let withPage (value: MlTypes.Page) (req: MlGetBucketsRequest) =
            { req with Page = Some value }
        let withSort (value: CoreTypes.Field) (req: MlGetBucketsRequest) =
            { req with Sort = Some value }
        let withStart (value: CoreTypes.DateTime) (req: MlGetBucketsRequest) =
            { req with Start = Some value }

    type MlGetCalendarEventsRequest = {
        CalendarId: CoreTypes.Id
        End: CoreTypes.DateTime option
        From: CoreTypes.Integer option
        JobId: CoreTypes.Id option
        Size: CoreTypes.Integer option
        Start: CoreTypes.DateTime option
    }

        with
        static member ToRequest(req: MlGetCalendarEventsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/calendars/{req.CalendarId}/events"
                let queryParams =
                    [
                        req.End |> Option.map (fun v -> "end", Fes.Http.toQueryValue v)
                        req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        req.JobId |> Option.map (fun v -> "job_id", Fes.Http.toQueryValue v)
                        req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                        req.Start |> Option.map (fun v -> "start", Fes.Http.toQueryValue v)
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

    type MlGetCalendarEventsResponse = System.Text.Json.JsonElement

    type MlGetCalendarEventsRequestBuilder() =
        member _.Yield(_: unit) : MlGetCalendarEventsRequest =
            {
                CalendarId = Unchecked.defaultof<_>
                End = None
                From = None
                JobId = None
                Size = None
                Start = None
            }

        [<CustomOperation("calendarId")>]
        member _.CalendarId(state: MlGetCalendarEventsRequest, value: CoreTypes.Id) =
            { state with CalendarId = value }

        [<CustomOperation("end'")>]
        member _.End(state: MlGetCalendarEventsRequest, value: CoreTypes.DateTime) =
            { state with End = Some value }

        [<CustomOperation("from")>]
        member _.From(state: MlGetCalendarEventsRequest, value: CoreTypes.Integer) =
            { state with From = Some value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlGetCalendarEventsRequest, value: CoreTypes.Id) =
            { state with JobId = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MlGetCalendarEventsRequest, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("start")>]
        member _.Start(state: MlGetCalendarEventsRequest, value: CoreTypes.DateTime) =
            { state with Start = Some value }

    let mlGetCalendarEventsRequest = MlGetCalendarEventsRequestBuilder()

    module GetCalendarEvents =
        let withEnd (value: CoreTypes.DateTime) (req: MlGetCalendarEventsRequest) =
            { req with End = Some value }
        let withFrom (value: CoreTypes.Integer) (req: MlGetCalendarEventsRequest) =
            { req with From = Some value }
        let withJobId (value: CoreTypes.Id) (req: MlGetCalendarEventsRequest) =
            { req with JobId = Some value }
        let withSize (value: CoreTypes.Integer) (req: MlGetCalendarEventsRequest) =
            { req with Size = Some value }
        let withStart (value: CoreTypes.DateTime) (req: MlGetCalendarEventsRequest) =
            { req with Start = Some value }

    type MlGetCalendarsRequest = {
        CalendarId: CoreTypes.Id
        From: CoreTypes.Integer option
        Size: CoreTypes.Integer option
        Page: MlTypes.Page option
    }

        with
        static member ToRequest(req: MlGetCalendarsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/calendars/{req.CalendarId}"
                let queryParams =
                    [
                        req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
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

    type MlGetCalendarsResponse = System.Text.Json.JsonElement

    type MlGetCalendarsRequestBuilder() =
        member _.Yield(_: unit) : MlGetCalendarsRequest =
            {
                CalendarId = Unchecked.defaultof<_>
                From = None
                Size = None
                Page = None
            }

        [<CustomOperation("calendarId")>]
        member _.CalendarId(state: MlGetCalendarsRequest, value: CoreTypes.Id) =
            { state with CalendarId = value }

        [<CustomOperation("from")>]
        member _.From(state: MlGetCalendarsRequest, value: CoreTypes.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MlGetCalendarsRequest, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("page")>]
        member _.Page(state: MlGetCalendarsRequest, value: MlTypes.Page) =
            { state with Page = Some value }

    let mlGetCalendarsRequest = MlGetCalendarsRequestBuilder()

    module GetCalendars =
        let withFrom (value: CoreTypes.Integer) (req: MlGetCalendarsRequest) =
            { req with From = Some value }
        let withSize (value: CoreTypes.Integer) (req: MlGetCalendarsRequest) =
            { req with Size = Some value }
        let withPage (value: MlTypes.Page) (req: MlGetCalendarsRequest) =
            { req with Page = Some value }

    type MlGetCategoriesRequest = {
        JobId: CoreTypes.Id
        CategoryId: CoreTypes.CategoryId
        From: CoreTypes.Integer option
        PartitionFieldValue: string option
        Size: CoreTypes.Integer option
        Page: MlTypes.Page option
    }

        with
        static member ToRequest(req: MlGetCategoriesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{req.JobId}/results/categories/{req.CategoryId}"
                let queryParams =
                    [
                        req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        req.PartitionFieldValue |> Option.map (fun v -> "partition_field_value", Fes.Http.toQueryValue v)
                        req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
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

    type MlGetCategoriesResponse = System.Text.Json.JsonElement

    type MlGetCategoriesRequestBuilder() =
        member _.Yield(_: unit) : MlGetCategoriesRequest =
            {
                JobId = Unchecked.defaultof<_>
                CategoryId = Unchecked.defaultof<_>
                From = None
                PartitionFieldValue = None
                Size = None
                Page = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlGetCategoriesRequest, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("categoryId")>]
        member _.CategoryId(state: MlGetCategoriesRequest, value: CoreTypes.CategoryId) =
            { state with CategoryId = value }

        [<CustomOperation("from")>]
        member _.From(state: MlGetCategoriesRequest, value: CoreTypes.Integer) =
            { state with From = Some value }

        [<CustomOperation("partitionFieldValue")>]
        member _.PartitionFieldValue(state: MlGetCategoriesRequest, value: string) =
            { state with PartitionFieldValue = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MlGetCategoriesRequest, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("page")>]
        member _.Page(state: MlGetCategoriesRequest, value: MlTypes.Page) =
            { state with Page = Some value }

    let mlGetCategoriesRequest = MlGetCategoriesRequestBuilder()

    module GetCategories =
        let withFrom (value: CoreTypes.Integer) (req: MlGetCategoriesRequest) =
            { req with From = Some value }
        let withPartitionFieldValue (value: string) (req: MlGetCategoriesRequest) =
            { req with PartitionFieldValue = Some value }
        let withSize (value: CoreTypes.Integer) (req: MlGetCategoriesRequest) =
            { req with Size = Some value }
        let withPage (value: MlTypes.Page) (req: MlGetCategoriesRequest) =
            { req with Page = Some value }

    type MlGetDataFrameAnalyticsRequest = {
        Id: CoreTypes.Id
        AllowNoMatch: bool option
        From: CoreTypes.Integer option
        Size: CoreTypes.Integer option
        ExcludeGenerated: bool option
    }

        with
        static member ToRequest(req: MlGetDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/data_frame/analytics/{req.Id}"
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

    type MlGetDataFrameAnalyticsResponse = System.Text.Json.JsonElement

    type MlGetDataFrameAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : MlGetDataFrameAnalyticsRequest =
            {
                Id = Unchecked.defaultof<_>
                AllowNoMatch = None
                From = None
                Size = None
                ExcludeGenerated = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: MlGetDataFrameAnalyticsRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlGetDataFrameAnalyticsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("from")>]
        member _.From(state: MlGetDataFrameAnalyticsRequest, value: CoreTypes.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MlGetDataFrameAnalyticsRequest, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("excludeGenerated")>]
        member _.ExcludeGenerated(state: MlGetDataFrameAnalyticsRequest, value: bool) =
            { state with ExcludeGenerated = Some value }

    let mlGetDataFrameAnalyticsRequest = MlGetDataFrameAnalyticsRequestBuilder()

    module GetDataFrameAnalytics =
        let withAllowNoMatch (value: bool) (req: MlGetDataFrameAnalyticsRequest) =
            { req with AllowNoMatch = Some value }
        let withFrom (value: CoreTypes.Integer) (req: MlGetDataFrameAnalyticsRequest) =
            { req with From = Some value }
        let withSize (value: CoreTypes.Integer) (req: MlGetDataFrameAnalyticsRequest) =
            { req with Size = Some value }
        let withExcludeGenerated (value: bool) (req: MlGetDataFrameAnalyticsRequest) =
            { req with ExcludeGenerated = Some value }

    type MlGetDataFrameAnalyticsStatsRequest = {
        Id: CoreTypes.Id
        AllowNoMatch: bool option
        From: CoreTypes.Integer option
        Size: CoreTypes.Integer option
        Verbose: bool option
    }

        with
        static member ToRequest(req: MlGetDataFrameAnalyticsStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/data_frame/analytics/{req.Id}/_stats"
                let queryParams =
                    [
                        req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                        req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                        req.Verbose |> Option.map (fun v -> "verbose", Fes.Http.toQueryValue v)
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

    type MlGetDataFrameAnalyticsStatsResponse = System.Text.Json.JsonElement

    type MlGetDataFrameAnalyticsStatsRequestBuilder() =
        member _.Yield(_: unit) : MlGetDataFrameAnalyticsStatsRequest =
            {
                Id = Unchecked.defaultof<_>
                AllowNoMatch = None
                From = None
                Size = None
                Verbose = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: MlGetDataFrameAnalyticsStatsRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlGetDataFrameAnalyticsStatsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("from")>]
        member _.From(state: MlGetDataFrameAnalyticsStatsRequest, value: CoreTypes.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MlGetDataFrameAnalyticsStatsRequest, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("verbose")>]
        member _.Verbose(state: MlGetDataFrameAnalyticsStatsRequest, value: bool) =
            { state with Verbose = Some value }

    let mlGetDataFrameAnalyticsStatsRequest = MlGetDataFrameAnalyticsStatsRequestBuilder()

    module GetDataFrameAnalyticsStats =
        let withAllowNoMatch (value: bool) (req: MlGetDataFrameAnalyticsStatsRequest) =
            { req with AllowNoMatch = Some value }
        let withFrom (value: CoreTypes.Integer) (req: MlGetDataFrameAnalyticsStatsRequest) =
            { req with From = Some value }
        let withSize (value: CoreTypes.Integer) (req: MlGetDataFrameAnalyticsStatsRequest) =
            { req with Size = Some value }
        let withVerbose (value: bool) (req: MlGetDataFrameAnalyticsStatsRequest) =
            { req with Verbose = Some value }

    type MlGetDatafeedStatsRequest = {
        DatafeedId: CoreTypes.Ids
        AllowNoMatch: bool option
    }

        with
        static member ToRequest(req: MlGetDatafeedStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/datafeeds/{req.DatafeedId}/_stats"
                let queryParams =
                    [
                        req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
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

    type MlGetDatafeedStatsResponse = System.Text.Json.JsonElement

    type MlGetDatafeedStatsRequestBuilder() =
        member _.Yield(_: unit) : MlGetDatafeedStatsRequest =
            {
                DatafeedId = Unchecked.defaultof<_>
                AllowNoMatch = None
            }

        [<CustomOperation("datafeedId")>]
        member _.DatafeedId(state: MlGetDatafeedStatsRequest, value: CoreTypes.Ids) =
            { state with DatafeedId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlGetDatafeedStatsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

    let mlGetDatafeedStatsRequest = MlGetDatafeedStatsRequestBuilder()

    module GetDatafeedStats =
        let withAllowNoMatch (value: bool) (req: MlGetDatafeedStatsRequest) =
            { req with AllowNoMatch = Some value }

    type MlGetDatafeedsRequest = {
        DatafeedId: CoreTypes.Ids
        AllowNoMatch: bool option
        ExcludeGenerated: bool option
    }

        with
        static member ToRequest(req: MlGetDatafeedsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/datafeeds/{req.DatafeedId}"
                let queryParams =
                    [
                        req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
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

    type MlGetDatafeedsResponse = System.Text.Json.JsonElement

    type MlGetDatafeedsRequestBuilder() =
        member _.Yield(_: unit) : MlGetDatafeedsRequest =
            {
                DatafeedId = Unchecked.defaultof<_>
                AllowNoMatch = None
                ExcludeGenerated = None
            }

        [<CustomOperation("datafeedId")>]
        member _.DatafeedId(state: MlGetDatafeedsRequest, value: CoreTypes.Ids) =
            { state with DatafeedId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlGetDatafeedsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("excludeGenerated")>]
        member _.ExcludeGenerated(state: MlGetDatafeedsRequest, value: bool) =
            { state with ExcludeGenerated = Some value }

    let mlGetDatafeedsRequest = MlGetDatafeedsRequestBuilder()

    module GetDatafeeds =
        let withAllowNoMatch (value: bool) (req: MlGetDatafeedsRequest) =
            { req with AllowNoMatch = Some value }
        let withExcludeGenerated (value: bool) (req: MlGetDatafeedsRequest) =
            { req with ExcludeGenerated = Some value }

    type MlGetFiltersRequest = {
        FilterId: CoreTypes.Ids
        From: CoreTypes.Integer option
        Size: CoreTypes.Integer option
    }

        with
        static member ToRequest(req: MlGetFiltersRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/filters/{req.FilterId}"
                let queryParams =
                    [
                        req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
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

    type MlGetFiltersResponse = System.Text.Json.JsonElement

    type MlGetFiltersRequestBuilder() =
        member _.Yield(_: unit) : MlGetFiltersRequest =
            {
                FilterId = Unchecked.defaultof<_>
                From = None
                Size = None
            }

        [<CustomOperation("filterId")>]
        member _.FilterId(state: MlGetFiltersRequest, value: CoreTypes.Ids) =
            { state with FilterId = value }

        [<CustomOperation("from")>]
        member _.From(state: MlGetFiltersRequest, value: CoreTypes.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MlGetFiltersRequest, value: CoreTypes.Integer) =
            { state with Size = Some value }

    let mlGetFiltersRequest = MlGetFiltersRequestBuilder()

    module GetFilters =
        let withFrom (value: CoreTypes.Integer) (req: MlGetFiltersRequest) =
            { req with From = Some value }
        let withSize (value: CoreTypes.Integer) (req: MlGetFiltersRequest) =
            { req with Size = Some value }

    type MlGetInfluencersRequest = {
        JobId: CoreTypes.Id
        Desc: bool option
        End: CoreTypes.DateTime option
        ExcludeInterim: bool option
        InfluencerScore: CoreTypes.Double option
        From: CoreTypes.Integer option
        Size: CoreTypes.Integer option
        Sort: CoreTypes.Field option
        Start: CoreTypes.DateTime option
        Page: MlTypes.Page option
    }

        with
        static member ToRequest(req: MlGetInfluencersRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{req.JobId}/results/influencers"
                let queryParams =
                    [
                        req.Desc |> Option.map (fun v -> "desc", Fes.Http.toQueryValue v)
                        req.End |> Option.map (fun v -> "end", Fes.Http.toQueryValue v)
                        req.ExcludeInterim |> Option.map (fun v -> "exclude_interim", Fes.Http.toQueryValue v)
                        req.InfluencerScore |> Option.map (fun v -> "influencer_score", Fes.Http.toQueryValue v)
                        req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                        req.Sort |> Option.map (fun v -> "sort", Fes.Http.toQueryValue v)
                        req.Start |> Option.map (fun v -> "start", Fes.Http.toQueryValue v)
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

    type MlGetInfluencersResponse = System.Text.Json.JsonElement

    type MlGetInfluencersRequestBuilder() =
        member _.Yield(_: unit) : MlGetInfluencersRequest =
            {
                JobId = Unchecked.defaultof<_>
                Desc = None
                End = None
                ExcludeInterim = None
                InfluencerScore = None
                From = None
                Size = None
                Sort = None
                Start = None
                Page = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlGetInfluencersRequest, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("desc")>]
        member _.Desc(state: MlGetInfluencersRequest, value: bool) =
            { state with Desc = Some value }

        [<CustomOperation("end'")>]
        member _.End(state: MlGetInfluencersRequest, value: CoreTypes.DateTime) =
            { state with End = Some value }

        [<CustomOperation("excludeInterim")>]
        member _.ExcludeInterim(state: MlGetInfluencersRequest, value: bool) =
            { state with ExcludeInterim = Some value }

        [<CustomOperation("influencerScore")>]
        member _.InfluencerScore(state: MlGetInfluencersRequest, value: CoreTypes.Double) =
            { state with InfluencerScore = Some value }

        [<CustomOperation("from")>]
        member _.From(state: MlGetInfluencersRequest, value: CoreTypes.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MlGetInfluencersRequest, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: MlGetInfluencersRequest, value: CoreTypes.Field) =
            { state with Sort = Some value }

        [<CustomOperation("start")>]
        member _.Start(state: MlGetInfluencersRequest, value: CoreTypes.DateTime) =
            { state with Start = Some value }

        [<CustomOperation("page")>]
        member _.Page(state: MlGetInfluencersRequest, value: MlTypes.Page) =
            { state with Page = Some value }

    let mlGetInfluencersRequest = MlGetInfluencersRequestBuilder()

    module GetInfluencers =
        let withDesc (value: bool) (req: MlGetInfluencersRequest) =
            { req with Desc = Some value }
        let withEnd (value: CoreTypes.DateTime) (req: MlGetInfluencersRequest) =
            { req with End = Some value }
        let withExcludeInterim (value: bool) (req: MlGetInfluencersRequest) =
            { req with ExcludeInterim = Some value }
        let withInfluencerScore (value: CoreTypes.Double) (req: MlGetInfluencersRequest) =
            { req with InfluencerScore = Some value }
        let withFrom (value: CoreTypes.Integer) (req: MlGetInfluencersRequest) =
            { req with From = Some value }
        let withSize (value: CoreTypes.Integer) (req: MlGetInfluencersRequest) =
            { req with Size = Some value }
        let withSort (value: CoreTypes.Field) (req: MlGetInfluencersRequest) =
            { req with Sort = Some value }
        let withStart (value: CoreTypes.DateTime) (req: MlGetInfluencersRequest) =
            { req with Start = Some value }
        let withPage (value: MlTypes.Page) (req: MlGetInfluencersRequest) =
            { req with Page = Some value }

    type MlGetJobStatsRequest = {
        JobId: CoreTypes.Id
        AllowNoMatch: bool option
    }

        with
        static member ToRequest(req: MlGetJobStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{req.JobId}/_stats"
                let queryParams =
                    [
                        req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
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

    type MlGetJobStatsResponse = System.Text.Json.JsonElement

    type MlGetJobStatsRequestBuilder() =
        member _.Yield(_: unit) : MlGetJobStatsRequest =
            {
                JobId = Unchecked.defaultof<_>
                AllowNoMatch = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlGetJobStatsRequest, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlGetJobStatsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

    let mlGetJobStatsRequest = MlGetJobStatsRequestBuilder()

    module GetJobStats =
        let withAllowNoMatch (value: bool) (req: MlGetJobStatsRequest) =
            { req with AllowNoMatch = Some value }

    type MlGetJobsRequest = {
        JobId: CoreTypes.Ids
        AllowNoMatch: bool option
        ExcludeGenerated: bool option
    }

        with
        static member ToRequest(req: MlGetJobsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{req.JobId}"
                let queryParams =
                    [
                        req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
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

    type MlGetJobsResponse = System.Text.Json.JsonElement

    type MlGetJobsRequestBuilder() =
        member _.Yield(_: unit) : MlGetJobsRequest =
            {
                JobId = Unchecked.defaultof<_>
                AllowNoMatch = None
                ExcludeGenerated = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlGetJobsRequest, value: CoreTypes.Ids) =
            { state with JobId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlGetJobsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("excludeGenerated")>]
        member _.ExcludeGenerated(state: MlGetJobsRequest, value: bool) =
            { state with ExcludeGenerated = Some value }

    let mlGetJobsRequest = MlGetJobsRequestBuilder()

    module GetJobs =
        let withAllowNoMatch (value: bool) (req: MlGetJobsRequest) =
            { req with AllowNoMatch = Some value }
        let withExcludeGenerated (value: bool) (req: MlGetJobsRequest) =
            { req with ExcludeGenerated = Some value }

    type MlGetMemoryStatsRequest = {
        NodeId: CoreTypes.Id
        MasterTimeout: CoreTypes.Duration option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: MlGetMemoryStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/memory/{req.NodeId}/_stats"
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

    type MlGetMemoryStatsResponse = System.Text.Json.JsonElement

    type MlGetMemoryStatsRequestBuilder() =
        member _.Yield(_: unit) : MlGetMemoryStatsRequest =
            {
                NodeId = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: MlGetMemoryStatsRequest, value: CoreTypes.Id) =
            { state with NodeId = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: MlGetMemoryStatsRequest, value: CoreTypes.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlGetMemoryStatsRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let mlGetMemoryStatsRequest = MlGetMemoryStatsRequestBuilder()

    module GetMemoryStats =
        let withMasterTimeout (value: CoreTypes.Duration) (req: MlGetMemoryStatsRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: MlGetMemoryStatsRequest) =
            { req with Timeout = Some value }

    type MlGetModelSnapshotUpgradeStatsRequest = {
        JobId: CoreTypes.Id
        SnapshotId: CoreTypes.Id
        AllowNoMatch: bool option
    }

        with
        static member ToRequest(req: MlGetModelSnapshotUpgradeStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{req.JobId}/model_snapshots/{req.SnapshotId}/_upgrade/_stats"
                let queryParams =
                    [
                        req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
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

    type MlGetModelSnapshotUpgradeStatsResponse = System.Text.Json.JsonElement

    type MlGetModelSnapshotUpgradeStatsRequestBuilder() =
        member _.Yield(_: unit) : MlGetModelSnapshotUpgradeStatsRequest =
            {
                JobId = Unchecked.defaultof<_>
                SnapshotId = Unchecked.defaultof<_>
                AllowNoMatch = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlGetModelSnapshotUpgradeStatsRequest, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("snapshotId")>]
        member _.SnapshotId(state: MlGetModelSnapshotUpgradeStatsRequest, value: CoreTypes.Id) =
            { state with SnapshotId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlGetModelSnapshotUpgradeStatsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

    let mlGetModelSnapshotUpgradeStatsRequest = MlGetModelSnapshotUpgradeStatsRequestBuilder()

    module GetModelSnapshotUpgradeStats =
        let withAllowNoMatch (value: bool) (req: MlGetModelSnapshotUpgradeStatsRequest) =
            { req with AllowNoMatch = Some value }

    type MlGetModelSnapshotsRequest = {
        JobId: CoreTypes.Id
        SnapshotId: CoreTypes.Id
        Desc: bool option
        End: CoreTypes.DateTime option
        From: CoreTypes.Integer option
        Size: CoreTypes.Integer option
        Sort: CoreTypes.Field option
        Start: CoreTypes.DateTime option
        Desc: bool option
        End: CoreTypes.DateTime option
        Page: MlTypes.Page option
        Sort: CoreTypes.Field option
        Start: CoreTypes.DateTime option
    }

        with
        static member ToRequest(req: MlGetModelSnapshotsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{req.JobId}/model_snapshots/{req.SnapshotId}"
                let queryParams =
                    [
                        req.Desc |> Option.map (fun v -> "desc", Fes.Http.toQueryValue v)
                        req.End |> Option.map (fun v -> "end", Fes.Http.toQueryValue v)
                        req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                        req.Sort |> Option.map (fun v -> "sort", Fes.Http.toQueryValue v)
                        req.Start |> Option.map (fun v -> "start", Fes.Http.toQueryValue v)
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

    type MlGetModelSnapshotsResponse = System.Text.Json.JsonElement

    type MlGetModelSnapshotsRequestBuilder() =
        member _.Yield(_: unit) : MlGetModelSnapshotsRequest =
            {
                JobId = Unchecked.defaultof<_>
                SnapshotId = Unchecked.defaultof<_>
                Desc = None
                End = None
                From = None
                Size = None
                Sort = None
                Start = None
                Desc = None
                End = None
                Page = None
                Sort = None
                Start = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlGetModelSnapshotsRequest, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("snapshotId")>]
        member _.SnapshotId(state: MlGetModelSnapshotsRequest, value: CoreTypes.Id) =
            { state with SnapshotId = value }

        [<CustomOperation("desc")>]
        member _.Desc(state: MlGetModelSnapshotsRequest, value: bool) =
            { state with Desc = Some value }

        [<CustomOperation("end'")>]
        member _.End(state: MlGetModelSnapshotsRequest, value: CoreTypes.DateTime) =
            { state with End = Some value }

        [<CustomOperation("from")>]
        member _.From(state: MlGetModelSnapshotsRequest, value: CoreTypes.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MlGetModelSnapshotsRequest, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: MlGetModelSnapshotsRequest, value: CoreTypes.Field) =
            { state with Sort = Some value }

        [<CustomOperation("start")>]
        member _.Start(state: MlGetModelSnapshotsRequest, value: CoreTypes.DateTime) =
            { state with Start = Some value }

        [<CustomOperation("desc")>]
        member _.Desc(state: MlGetModelSnapshotsRequest, value: bool) =
            { state with Desc = Some value }

        [<CustomOperation("end'")>]
        member _.End(state: MlGetModelSnapshotsRequest, value: CoreTypes.DateTime) =
            { state with End = Some value }

        [<CustomOperation("page")>]
        member _.Page(state: MlGetModelSnapshotsRequest, value: MlTypes.Page) =
            { state with Page = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: MlGetModelSnapshotsRequest, value: CoreTypes.Field) =
            { state with Sort = Some value }

        [<CustomOperation("start")>]
        member _.Start(state: MlGetModelSnapshotsRequest, value: CoreTypes.DateTime) =
            { state with Start = Some value }

    let mlGetModelSnapshotsRequest = MlGetModelSnapshotsRequestBuilder()

    module GetModelSnapshots =
        let withDesc (value: bool) (req: MlGetModelSnapshotsRequest) =
            { req with Desc = Some value }
        let withEnd (value: CoreTypes.DateTime) (req: MlGetModelSnapshotsRequest) =
            { req with End = Some value }
        let withFrom (value: CoreTypes.Integer) (req: MlGetModelSnapshotsRequest) =
            { req with From = Some value }
        let withSize (value: CoreTypes.Integer) (req: MlGetModelSnapshotsRequest) =
            { req with Size = Some value }
        let withSort (value: CoreTypes.Field) (req: MlGetModelSnapshotsRequest) =
            { req with Sort = Some value }
        let withStart (value: CoreTypes.DateTime) (req: MlGetModelSnapshotsRequest) =
            { req with Start = Some value }
        let withDesc (value: bool) (req: MlGetModelSnapshotsRequest) =
            { req with Desc = Some value }
        let withEnd (value: CoreTypes.DateTime) (req: MlGetModelSnapshotsRequest) =
            { req with End = Some value }
        let withPage (value: MlTypes.Page) (req: MlGetModelSnapshotsRequest) =
            { req with Page = Some value }
        let withSort (value: CoreTypes.Field) (req: MlGetModelSnapshotsRequest) =
            { req with Sort = Some value }
        let withStart (value: CoreTypes.DateTime) (req: MlGetModelSnapshotsRequest) =
            { req with Start = Some value }

    type MlGetOverallBucketsRequest = {
        JobId: CoreTypes.Id
        AllowNoMatch: bool option
        BucketSpan: CoreTypes.Duration option
        End: CoreTypes.DateTime option
        ExcludeInterim: bool option
        OverallScore: CoreTypes.Double option
        Start: CoreTypes.DateTime option
        TopN: CoreTypes.Integer option
        AllowNoMatch: bool option
        BucketSpan: CoreTypes.Duration option
        End: CoreTypes.DateTime option
        ExcludeInterim: bool option
        OverallScore: CoreTypes.Double option
        Start: CoreTypes.DateTime option
        TopN: CoreTypes.Integer option
    }

        with
        static member ToRequest(req: MlGetOverallBucketsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{req.JobId}/results/overall_buckets"
                let queryParams =
                    [
                        req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                        req.BucketSpan |> Option.map (fun v -> "bucket_span", Fes.Http.toQueryValue v)
                        req.End |> Option.map (fun v -> "end", Fes.Http.toQueryValue v)
                        req.ExcludeInterim |> Option.map (fun v -> "exclude_interim", Fes.Http.toQueryValue v)
                        req.OverallScore |> Option.map (fun v -> "overall_score", Fes.Http.toQueryValue v)
                        req.Start |> Option.map (fun v -> "start", Fes.Http.toQueryValue v)
                        req.TopN |> Option.map (fun v -> "top_n", Fes.Http.toQueryValue v)
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

    type MlGetOverallBucketsResponse = System.Text.Json.JsonElement

    type MlGetOverallBucketsRequestBuilder() =
        member _.Yield(_: unit) : MlGetOverallBucketsRequest =
            {
                JobId = Unchecked.defaultof<_>
                AllowNoMatch = None
                BucketSpan = None
                End = None
                ExcludeInterim = None
                OverallScore = None
                Start = None
                TopN = None
                AllowNoMatch = None
                BucketSpan = None
                End = None
                ExcludeInterim = None
                OverallScore = None
                Start = None
                TopN = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlGetOverallBucketsRequest, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlGetOverallBucketsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("bucketSpan")>]
        member _.BucketSpan(state: MlGetOverallBucketsRequest, value: CoreTypes.Duration) =
            { state with BucketSpan = Some value }

        [<CustomOperation("end'")>]
        member _.End(state: MlGetOverallBucketsRequest, value: CoreTypes.DateTime) =
            { state with End = Some value }

        [<CustomOperation("excludeInterim")>]
        member _.ExcludeInterim(state: MlGetOverallBucketsRequest, value: bool) =
            { state with ExcludeInterim = Some value }

        [<CustomOperation("overallScore")>]
        member _.OverallScore(state: MlGetOverallBucketsRequest, value: CoreTypes.Double) =
            { state with OverallScore = Some value }

        [<CustomOperation("start")>]
        member _.Start(state: MlGetOverallBucketsRequest, value: CoreTypes.DateTime) =
            { state with Start = Some value }

        [<CustomOperation("topN")>]
        member _.TopN(state: MlGetOverallBucketsRequest, value: CoreTypes.Integer) =
            { state with TopN = Some value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlGetOverallBucketsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("bucketSpan")>]
        member _.BucketSpan(state: MlGetOverallBucketsRequest, value: CoreTypes.Duration) =
            { state with BucketSpan = Some value }

        [<CustomOperation("end'")>]
        member _.End(state: MlGetOverallBucketsRequest, value: CoreTypes.DateTime) =
            { state with End = Some value }

        [<CustomOperation("excludeInterim")>]
        member _.ExcludeInterim(state: MlGetOverallBucketsRequest, value: bool) =
            { state with ExcludeInterim = Some value }

        [<CustomOperation("overallScore")>]
        member _.OverallScore(state: MlGetOverallBucketsRequest, value: CoreTypes.Double) =
            { state with OverallScore = Some value }

        [<CustomOperation("start")>]
        member _.Start(state: MlGetOverallBucketsRequest, value: CoreTypes.DateTime) =
            { state with Start = Some value }

        [<CustomOperation("topN")>]
        member _.TopN(state: MlGetOverallBucketsRequest, value: CoreTypes.Integer) =
            { state with TopN = Some value }

    let mlGetOverallBucketsRequest = MlGetOverallBucketsRequestBuilder()

    module GetOverallBuckets =
        let withAllowNoMatch (value: bool) (req: MlGetOverallBucketsRequest) =
            { req with AllowNoMatch = Some value }
        let withBucketSpan (value: CoreTypes.Duration) (req: MlGetOverallBucketsRequest) =
            { req with BucketSpan = Some value }
        let withEnd (value: CoreTypes.DateTime) (req: MlGetOverallBucketsRequest) =
            { req with End = Some value }
        let withExcludeInterim (value: bool) (req: MlGetOverallBucketsRequest) =
            { req with ExcludeInterim = Some value }
        let withOverallScore (value: CoreTypes.Double) (req: MlGetOverallBucketsRequest) =
            { req with OverallScore = Some value }
        let withStart (value: CoreTypes.DateTime) (req: MlGetOverallBucketsRequest) =
            { req with Start = Some value }
        let withTopN (value: CoreTypes.Integer) (req: MlGetOverallBucketsRequest) =
            { req with TopN = Some value }
        let withAllowNoMatch (value: bool) (req: MlGetOverallBucketsRequest) =
            { req with AllowNoMatch = Some value }
        let withBucketSpan (value: CoreTypes.Duration) (req: MlGetOverallBucketsRequest) =
            { req with BucketSpan = Some value }
        let withEnd (value: CoreTypes.DateTime) (req: MlGetOverallBucketsRequest) =
            { req with End = Some value }
        let withExcludeInterim (value: bool) (req: MlGetOverallBucketsRequest) =
            { req with ExcludeInterim = Some value }
        let withOverallScore (value: CoreTypes.Double) (req: MlGetOverallBucketsRequest) =
            { req with OverallScore = Some value }
        let withStart (value: CoreTypes.DateTime) (req: MlGetOverallBucketsRequest) =
            { req with Start = Some value }
        let withTopN (value: CoreTypes.Integer) (req: MlGetOverallBucketsRequest) =
            { req with TopN = Some value }

    type MlGetRecordsRequest = {
        JobId: CoreTypes.Id
        Desc: bool option
        End: CoreTypes.DateTime option
        ExcludeInterim: bool option
        From: CoreTypes.Integer option
        RecordScore: CoreTypes.Double option
        Size: CoreTypes.Integer option
        Sort: CoreTypes.Field option
        Start: CoreTypes.DateTime option
        Desc: bool option
        End: CoreTypes.DateTime option
        ExcludeInterim: bool option
        Page: MlTypes.Page option
        RecordScore: CoreTypes.Double option
        Sort: CoreTypes.Field option
        Start: CoreTypes.DateTime option
    }

        with
        static member ToRequest(req: MlGetRecordsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{req.JobId}/results/records"
                let queryParams =
                    [
                        req.Desc |> Option.map (fun v -> "desc", Fes.Http.toQueryValue v)
                        req.End |> Option.map (fun v -> "end", Fes.Http.toQueryValue v)
                        req.ExcludeInterim |> Option.map (fun v -> "exclude_interim", Fes.Http.toQueryValue v)
                        req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        req.RecordScore |> Option.map (fun v -> "record_score", Fes.Http.toQueryValue v)
                        req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                        req.Sort |> Option.map (fun v -> "sort", Fes.Http.toQueryValue v)
                        req.Start |> Option.map (fun v -> "start", Fes.Http.toQueryValue v)
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

    type MlGetRecordsResponse = System.Text.Json.JsonElement

    type MlGetRecordsRequestBuilder() =
        member _.Yield(_: unit) : MlGetRecordsRequest =
            {
                JobId = Unchecked.defaultof<_>
                Desc = None
                End = None
                ExcludeInterim = None
                From = None
                RecordScore = None
                Size = None
                Sort = None
                Start = None
                Desc = None
                End = None
                ExcludeInterim = None
                Page = None
                RecordScore = None
                Sort = None
                Start = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlGetRecordsRequest, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("desc")>]
        member _.Desc(state: MlGetRecordsRequest, value: bool) =
            { state with Desc = Some value }

        [<CustomOperation("end'")>]
        member _.End(state: MlGetRecordsRequest, value: CoreTypes.DateTime) =
            { state with End = Some value }

        [<CustomOperation("excludeInterim")>]
        member _.ExcludeInterim(state: MlGetRecordsRequest, value: bool) =
            { state with ExcludeInterim = Some value }

        [<CustomOperation("from")>]
        member _.From(state: MlGetRecordsRequest, value: CoreTypes.Integer) =
            { state with From = Some value }

        [<CustomOperation("recordScore")>]
        member _.RecordScore(state: MlGetRecordsRequest, value: CoreTypes.Double) =
            { state with RecordScore = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MlGetRecordsRequest, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: MlGetRecordsRequest, value: CoreTypes.Field) =
            { state with Sort = Some value }

        [<CustomOperation("start")>]
        member _.Start(state: MlGetRecordsRequest, value: CoreTypes.DateTime) =
            { state with Start = Some value }

        [<CustomOperation("desc")>]
        member _.Desc(state: MlGetRecordsRequest, value: bool) =
            { state with Desc = Some value }

        [<CustomOperation("end'")>]
        member _.End(state: MlGetRecordsRequest, value: CoreTypes.DateTime) =
            { state with End = Some value }

        [<CustomOperation("excludeInterim")>]
        member _.ExcludeInterim(state: MlGetRecordsRequest, value: bool) =
            { state with ExcludeInterim = Some value }

        [<CustomOperation("page")>]
        member _.Page(state: MlGetRecordsRequest, value: MlTypes.Page) =
            { state with Page = Some value }

        [<CustomOperation("recordScore")>]
        member _.RecordScore(state: MlGetRecordsRequest, value: CoreTypes.Double) =
            { state with RecordScore = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: MlGetRecordsRequest, value: CoreTypes.Field) =
            { state with Sort = Some value }

        [<CustomOperation("start")>]
        member _.Start(state: MlGetRecordsRequest, value: CoreTypes.DateTime) =
            { state with Start = Some value }

    let mlGetRecordsRequest = MlGetRecordsRequestBuilder()

    module GetRecords =
        let withDesc (value: bool) (req: MlGetRecordsRequest) =
            { req with Desc = Some value }
        let withEnd (value: CoreTypes.DateTime) (req: MlGetRecordsRequest) =
            { req with End = Some value }
        let withExcludeInterim (value: bool) (req: MlGetRecordsRequest) =
            { req with ExcludeInterim = Some value }
        let withFrom (value: CoreTypes.Integer) (req: MlGetRecordsRequest) =
            { req with From = Some value }
        let withRecordScore (value: CoreTypes.Double) (req: MlGetRecordsRequest) =
            { req with RecordScore = Some value }
        let withSize (value: CoreTypes.Integer) (req: MlGetRecordsRequest) =
            { req with Size = Some value }
        let withSort (value: CoreTypes.Field) (req: MlGetRecordsRequest) =
            { req with Sort = Some value }
        let withStart (value: CoreTypes.DateTime) (req: MlGetRecordsRequest) =
            { req with Start = Some value }
        let withDesc (value: bool) (req: MlGetRecordsRequest) =
            { req with Desc = Some value }
        let withEnd (value: CoreTypes.DateTime) (req: MlGetRecordsRequest) =
            { req with End = Some value }
        let withExcludeInterim (value: bool) (req: MlGetRecordsRequest) =
            { req with ExcludeInterim = Some value }
        let withPage (value: MlTypes.Page) (req: MlGetRecordsRequest) =
            { req with Page = Some value }
        let withRecordScore (value: CoreTypes.Double) (req: MlGetRecordsRequest) =
            { req with RecordScore = Some value }
        let withSort (value: CoreTypes.Field) (req: MlGetRecordsRequest) =
            { req with Sort = Some value }
        let withStart (value: CoreTypes.DateTime) (req: MlGetRecordsRequest) =
            { req with Start = Some value }

    type MlGetTrainedModelsRequest = {
        ModelId: CoreTypes.Ids
        AllowNoMatch: bool option
        DecompressDefinition: bool option
        ExcludeGenerated: bool option
        From: CoreTypes.Integer option
        Include: MlTypes.Include option
        Size: CoreTypes.Integer option
        Tags: System.Text.Json.JsonElement option
    }

        with
        static member ToRequest(req: MlGetTrainedModelsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{req.ModelId}"
                let queryParams =
                    [
                        req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                        req.DecompressDefinition |> Option.map (fun v -> "decompress_definition", Fes.Http.toQueryValue v)
                        req.ExcludeGenerated |> Option.map (fun v -> "exclude_generated", Fes.Http.toQueryValue v)
                        req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        req.Include |> Option.map (fun v -> "include", Fes.Http.toQueryValue v)
                        req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                        req.Tags |> Option.map (fun v -> "tags", Fes.Http.toQueryValue v)
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

    type MlGetTrainedModelsResponse = System.Text.Json.JsonElement

    type MlGetTrainedModelsRequestBuilder() =
        member _.Yield(_: unit) : MlGetTrainedModelsRequest =
            {
                ModelId = Unchecked.defaultof<_>
                AllowNoMatch = None
                DecompressDefinition = None
                ExcludeGenerated = None
                From = None
                Include = None
                Size = None
                Tags = None
            }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: MlGetTrainedModelsRequest, value: CoreTypes.Ids) =
            { state with ModelId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlGetTrainedModelsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("decompressDefinition")>]
        member _.DecompressDefinition(state: MlGetTrainedModelsRequest, value: bool) =
            { state with DecompressDefinition = Some value }

        [<CustomOperation("excludeGenerated")>]
        member _.ExcludeGenerated(state: MlGetTrainedModelsRequest, value: bool) =
            { state with ExcludeGenerated = Some value }

        [<CustomOperation("from")>]
        member _.From(state: MlGetTrainedModelsRequest, value: CoreTypes.Integer) =
            { state with From = Some value }

        [<CustomOperation("include")>]
        member _.Include(state: MlGetTrainedModelsRequest, value: MlTypes.Include) =
            { state with Include = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MlGetTrainedModelsRequest, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("tags")>]
        member _.Tags(state: MlGetTrainedModelsRequest, value: System.Text.Json.JsonElement) =
            { state with Tags = Some value }

    let mlGetTrainedModelsRequest = MlGetTrainedModelsRequestBuilder()

    module GetTrainedModels =
        let withAllowNoMatch (value: bool) (req: MlGetTrainedModelsRequest) =
            { req with AllowNoMatch = Some value }
        let withDecompressDefinition (value: bool) (req: MlGetTrainedModelsRequest) =
            { req with DecompressDefinition = Some value }
        let withExcludeGenerated (value: bool) (req: MlGetTrainedModelsRequest) =
            { req with ExcludeGenerated = Some value }
        let withFrom (value: CoreTypes.Integer) (req: MlGetTrainedModelsRequest) =
            { req with From = Some value }
        let withInclude (value: MlTypes.Include) (req: MlGetTrainedModelsRequest) =
            { req with Include = Some value }
        let withSize (value: CoreTypes.Integer) (req: MlGetTrainedModelsRequest) =
            { req with Size = Some value }
        let withTags (value: System.Text.Json.JsonElement) (req: MlGetTrainedModelsRequest) =
            { req with Tags = Some value }

    type MlGetTrainedModelsStatsRequest = {
        ModelId: CoreTypes.Ids
        AllowNoMatch: bool option
        From: CoreTypes.Integer option
        Size: CoreTypes.Integer option
    }

        with
        static member ToRequest(req: MlGetTrainedModelsStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{req.ModelId}/_stats"
                let queryParams =
                    [
                        req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                        req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
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

    type MlGetTrainedModelsStatsResponse = System.Text.Json.JsonElement

    type MlGetTrainedModelsStatsRequestBuilder() =
        member _.Yield(_: unit) : MlGetTrainedModelsStatsRequest =
            {
                ModelId = Unchecked.defaultof<_>
                AllowNoMatch = None
                From = None
                Size = None
            }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: MlGetTrainedModelsStatsRequest, value: CoreTypes.Ids) =
            { state with ModelId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlGetTrainedModelsStatsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("from")>]
        member _.From(state: MlGetTrainedModelsStatsRequest, value: CoreTypes.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MlGetTrainedModelsStatsRequest, value: CoreTypes.Integer) =
            { state with Size = Some value }

    let mlGetTrainedModelsStatsRequest = MlGetTrainedModelsStatsRequestBuilder()

    module GetTrainedModelsStats =
        let withAllowNoMatch (value: bool) (req: MlGetTrainedModelsStatsRequest) =
            { req with AllowNoMatch = Some value }
        let withFrom (value: CoreTypes.Integer) (req: MlGetTrainedModelsStatsRequest) =
            { req with From = Some value }
        let withSize (value: CoreTypes.Integer) (req: MlGetTrainedModelsStatsRequest) =
            { req with Size = Some value }

    type MlInferTrainedModelRequest = {
        ModelId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        Docs: Map<string, System.Text.Json.JsonElement> list
        InferenceConfig: MlTypes.InferenceConfigUpdateContainer option
    }

        with
        static member ToRequest(req: MlInferTrainedModelRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{req.ModelId}/_infer"
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

    type MlInferTrainedModelResponse = System.Text.Json.JsonElement

    type MlInferTrainedModelRequestBuilder() =
        member _.Yield(_: unit) : MlInferTrainedModelRequest =
            {
                ModelId = Unchecked.defaultof<_>
                Timeout = None
                Docs = Unchecked.defaultof<_>
                InferenceConfig = None
            }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: MlInferTrainedModelRequest, value: CoreTypes.Id) =
            { state with ModelId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlInferTrainedModelRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("docs")>]
        member _.Docs(state: MlInferTrainedModelRequest, value: Map<string, System.Text.Json.JsonElement> list) =
            { state with Docs = value }

        [<CustomOperation("inferenceConfig")>]
        member _.InferenceConfig(state: MlInferTrainedModelRequest, value: MlTypes.InferenceConfigUpdateContainer) =
            { state with InferenceConfig = Some value }

    let mlInferTrainedModelRequest = MlInferTrainedModelRequestBuilder()

    module InferTrainedModel =
        let withTimeout (value: CoreTypes.Duration) (req: MlInferTrainedModelRequest) =
            { req with Timeout = Some value }
        let withDocs (value: Map<string, System.Text.Json.JsonElement> list) (req: MlInferTrainedModelRequest) =
            { req with Docs = value }
        let withInferenceConfig (value: MlTypes.InferenceConfigUpdateContainer) (req: MlInferTrainedModelRequest) =
            { req with InferenceConfig = Some value }

    type MlInfoRequest = | MlInfoRequest

        with
        static member ToRequest(req: MlInfoRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/info"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type MlInfoResponse = System.Text.Json.JsonElement

    type MlInfoRequestBuilder() =
        member _.Yield(_: unit) : MlInfoRequest =
            {
            }

    let mlInfoRequest = MlInfoRequestBuilder()

    type MlOpenJobRequest = {
        JobId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: MlOpenJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{req.JobId}/_open"
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

    type MlOpenJobResponse = System.Text.Json.JsonElement

    type MlOpenJobRequestBuilder() =
        member _.Yield(_: unit) : MlOpenJobRequest =
            {
                JobId = Unchecked.defaultof<_>
                Timeout = None
                Timeout = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlOpenJobRequest, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlOpenJobRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlOpenJobRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let mlOpenJobRequest = MlOpenJobRequestBuilder()

    module OpenJob =
        let withTimeout (value: CoreTypes.Duration) (req: MlOpenJobRequest) =
            { req with Timeout = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: MlOpenJobRequest) =
            { req with Timeout = Some value }

    type MlPostCalendarEventsRequest = {
        CalendarId: CoreTypes.Id
        Events: MlTypes.CalendarEvent list
    }

        with
        static member ToRequest(req: MlPostCalendarEventsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/calendars/{req.CalendarId}/events"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type MlPostCalendarEventsResponse = System.Text.Json.JsonElement

    type MlPostCalendarEventsRequestBuilder() =
        member _.Yield(_: unit) : MlPostCalendarEventsRequest =
            {
                CalendarId = Unchecked.defaultof<_>
                Events = Unchecked.defaultof<_>
            }

        [<CustomOperation("calendarId")>]
        member _.CalendarId(state: MlPostCalendarEventsRequest, value: CoreTypes.Id) =
            { state with CalendarId = value }

        [<CustomOperation("events")>]
        member _.Events(state: MlPostCalendarEventsRequest, value: MlTypes.CalendarEvent list) =
            { state with Events = value }

    let mlPostCalendarEventsRequest = MlPostCalendarEventsRequestBuilder()

    module PostCalendarEvents =
        let withEvents (value: MlTypes.CalendarEvent list) (req: MlPostCalendarEventsRequest) =
            { req with Events = value }

    type MlPostDataRequest = {
        JobId: CoreTypes.Id
        ResetEnd: CoreTypes.DateTime option
        ResetStart: CoreTypes.DateTime option
        Document: obj
    }

        with
        static member ToRequest(req: MlPostDataRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{req.JobId}/_data"
                let queryParams =
                    [
                        req.ResetEnd |> Option.map (fun v -> "reset_end", Fes.Http.toQueryValue v)
                        req.ResetStart |> Option.map (fun v -> "reset_start", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type MlPostDataResponse = System.Text.Json.JsonElement

    type MlPostDataRequestBuilder() =
        member _.Yield(_: unit) : MlPostDataRequest =
            {
                JobId = Unchecked.defaultof<_>
                ResetEnd = None
                ResetStart = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlPostDataRequest, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("resetEnd")>]
        member _.ResetEnd(state: MlPostDataRequest, value: CoreTypes.DateTime) =
            { state with ResetEnd = Some value }

        [<CustomOperation("resetStart")>]
        member _.ResetStart(state: MlPostDataRequest, value: CoreTypes.DateTime) =
            { state with ResetStart = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: MlPostDataRequest, value) =
            { state with Document = value }

    let mlPostDataRequest = MlPostDataRequestBuilder()

    module PostData =
        let withResetEnd (value: CoreTypes.DateTime) (req: MlPostDataRequest) =
            { req with ResetEnd = Some value }
        let withResetStart (value: CoreTypes.DateTime) (req: MlPostDataRequest) =
            { req with ResetStart = Some value }

    type MlPreviewDataFrameAnalyticsRequest = {
        Id: CoreTypes.Id
        Config: MlPreviewDataFrameAnalytics.DataframePreviewConfig option
    }

        with
        static member ToRequest(req: MlPreviewDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/data_frame/analytics/{req.Id}/_preview"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type MlPreviewDataFrameAnalyticsResponse = System.Text.Json.JsonElement

    type MlPreviewDataFrameAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : MlPreviewDataFrameAnalyticsRequest =
            {
                Id = Unchecked.defaultof<_>
                Config = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: MlPreviewDataFrameAnalyticsRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("config")>]
        member _.Config(state: MlPreviewDataFrameAnalyticsRequest, value: MlPreviewDataFrameAnalytics.DataframePreviewConfig) =
            { state with Config = Some value }

    let mlPreviewDataFrameAnalyticsRequest = MlPreviewDataFrameAnalyticsRequestBuilder()

    module PreviewDataFrameAnalytics =
        let withConfig (value: MlPreviewDataFrameAnalytics.DataframePreviewConfig) (req: MlPreviewDataFrameAnalyticsRequest) =
            { req with Config = Some value }

    type MlPreviewDatafeedRequest = {
        DatafeedId: CoreTypes.Id
        Start: CoreTypes.DateTime option
        End: CoreTypes.DateTime option
        DatafeedConfig: MlTypes.DatafeedConfig option
        JobConfig: MlTypes.JobConfig option
    }

        with
        static member ToRequest(req: MlPreviewDatafeedRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/datafeeds/{req.DatafeedId}/_preview"
                let queryParams =
                    [
                        req.Start |> Option.map (fun v -> "start", Fes.Http.toQueryValue v)
                        req.End |> Option.map (fun v -> "end", Fes.Http.toQueryValue v)
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

    type MlPreviewDatafeedResponse = MlPreviewDatafeedResponse.TDocument list

    type MlPreviewDatafeedRequestBuilder() =
        member _.Yield(_: unit) : MlPreviewDatafeedRequest =
            {
                DatafeedId = Unchecked.defaultof<_>
                Start = None
                End = None
                DatafeedConfig = None
                JobConfig = None
            }

        [<CustomOperation("datafeedId")>]
        member _.DatafeedId(state: MlPreviewDatafeedRequest, value: CoreTypes.Id) =
            { state with DatafeedId = value }

        [<CustomOperation("start")>]
        member _.Start(state: MlPreviewDatafeedRequest, value: CoreTypes.DateTime) =
            { state with Start = Some value }

        [<CustomOperation("end'")>]
        member _.End(state: MlPreviewDatafeedRequest, value: CoreTypes.DateTime) =
            { state with End = Some value }

        [<CustomOperation("datafeedConfig")>]
        member _.DatafeedConfig(state: MlPreviewDatafeedRequest, value: MlTypes.DatafeedConfig) =
            { state with DatafeedConfig = Some value }

        [<CustomOperation("jobConfig")>]
        member _.JobConfig(state: MlPreviewDatafeedRequest, value: MlTypes.JobConfig) =
            { state with JobConfig = Some value }

    let mlPreviewDatafeedRequest = MlPreviewDatafeedRequestBuilder()

    module PreviewDatafeed =
        let withStart (value: CoreTypes.DateTime) (req: MlPreviewDatafeedRequest) =
            { req with Start = Some value }
        let withEnd (value: CoreTypes.DateTime) (req: MlPreviewDatafeedRequest) =
            { req with End = Some value }
        let withDatafeedConfig (value: MlTypes.DatafeedConfig) (req: MlPreviewDatafeedRequest) =
            { req with DatafeedConfig = Some value }
        let withJobConfig (value: MlTypes.JobConfig) (req: MlPreviewDatafeedRequest) =
            { req with JobConfig = Some value }

    type MlPutCalendarRequest = {
        CalendarId: CoreTypes.Id
        JobIds: CoreTypes.Id list option
        Description: string option
    }

        with
        static member ToRequest(req: MlPutCalendarRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/calendars/{req.CalendarId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type MlPutCalendarResponse = System.Text.Json.JsonElement

    type MlPutCalendarRequestBuilder() =
        member _.Yield(_: unit) : MlPutCalendarRequest =
            {
                CalendarId = Unchecked.defaultof<_>
                JobIds = None
                Description = None
            }

        [<CustomOperation("calendarId")>]
        member _.CalendarId(state: MlPutCalendarRequest, value: CoreTypes.Id) =
            { state with CalendarId = value }

        [<CustomOperation("jobIds")>]
        member _.JobIds(state: MlPutCalendarRequest, value: CoreTypes.Id list) =
            { state with JobIds = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: MlPutCalendarRequest, value: string) =
            { state with Description = Some value }

    let mlPutCalendarRequest = MlPutCalendarRequestBuilder()

    module PutCalendar =
        let withJobIds (value: CoreTypes.Id list) (req: MlPutCalendarRequest) =
            { req with JobIds = Some value }
        let withDescription (value: string) (req: MlPutCalendarRequest) =
            { req with Description = Some value }

    type MlPutCalendarJobRequest = {
        CalendarId: CoreTypes.Id
        JobId: CoreTypes.Ids
    }

        with
        static member ToRequest(req: MlPutCalendarJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/calendars/{req.CalendarId}/jobs/{req.JobId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Result.Ok
            with ex -> Result.Error ex

    type MlPutCalendarJobResponse = System.Text.Json.JsonElement

    type MlPutCalendarJobRequestBuilder() =
        member _.Yield(_: unit) : MlPutCalendarJobRequest =
            {
                CalendarId = Unchecked.defaultof<_>
                JobId = Unchecked.defaultof<_>
            }

        [<CustomOperation("calendarId")>]
        member _.CalendarId(state: MlPutCalendarJobRequest, value: CoreTypes.Id) =
            { state with CalendarId = value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlPutCalendarJobRequest, value: CoreTypes.Ids) =
            { state with JobId = value }

    let mlPutCalendarJobRequest = MlPutCalendarJobRequestBuilder()

    type MlPutDataFrameAnalyticsRequest = {
        Id: CoreTypes.Id
        AllowLazyStart: bool option
        Analysis: MlTypes.DataframeAnalysisContainer
        AnalyzedFields: MlTypes.DataframeAnalysisAnalyzedFields option
        Description: string option
        Dest: MlTypes.DataframeAnalyticsDestination
        MaxNumThreads: CoreTypes.Integer option
        Meta: CoreTypes.Metadata option
        ModelMemoryLimit: string option
        Source: MlTypes.DataframeAnalyticsSource
        Headers: CoreTypes.HttpHeaders option
        Version: CoreTypes.VersionString option
    }

        with
        static member ToRequest(req: MlPutDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/data_frame/analytics/{req.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type MlPutDataFrameAnalyticsResponse = System.Text.Json.JsonElement

    type MlPutDataFrameAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : MlPutDataFrameAnalyticsRequest =
            {
                Id = Unchecked.defaultof<_>
                AllowLazyStart = None
                Analysis = Unchecked.defaultof<_>
                AnalyzedFields = None
                Description = None
                Dest = Unchecked.defaultof<_>
                MaxNumThreads = None
                Meta = None
                ModelMemoryLimit = None
                Source = Unchecked.defaultof<_>
                Headers = None
                Version = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: MlPutDataFrameAnalyticsRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("allowLazyStart")>]
        member _.AllowLazyStart(state: MlPutDataFrameAnalyticsRequest, value: bool) =
            { state with AllowLazyStart = Some value }

        [<CustomOperation("analysis")>]
        member _.Analysis(state: MlPutDataFrameAnalyticsRequest, value: MlTypes.DataframeAnalysisContainer) =
            { state with Analysis = value }

        [<CustomOperation("analyzedFields")>]
        member _.AnalyzedFields(state: MlPutDataFrameAnalyticsRequest, value: MlTypes.DataframeAnalysisAnalyzedFields) =
            { state with AnalyzedFields = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: MlPutDataFrameAnalyticsRequest, value: string) =
            { state with Description = Some value }

        [<CustomOperation("dest")>]
        member _.Dest(state: MlPutDataFrameAnalyticsRequest, value: MlTypes.DataframeAnalyticsDestination) =
            { state with Dest = value }

        [<CustomOperation("maxNumThreads")>]
        member _.MaxNumThreads(state: MlPutDataFrameAnalyticsRequest, value: CoreTypes.Integer) =
            { state with MaxNumThreads = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: MlPutDataFrameAnalyticsRequest, value: CoreTypes.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("modelMemoryLimit")>]
        member _.ModelMemoryLimit(state: MlPutDataFrameAnalyticsRequest, value: string) =
            { state with ModelMemoryLimit = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: MlPutDataFrameAnalyticsRequest, value: MlTypes.DataframeAnalyticsSource) =
            { state with Source = value }

        [<CustomOperation("headers")>]
        member _.Headers(state: MlPutDataFrameAnalyticsRequest, value: CoreTypes.HttpHeaders) =
            { state with Headers = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: MlPutDataFrameAnalyticsRequest, value: CoreTypes.VersionString) =
            { state with Version = Some value }

    let mlPutDataFrameAnalyticsRequest = MlPutDataFrameAnalyticsRequestBuilder()

    module PutDataFrameAnalytics =
        let withAllowLazyStart (value: bool) (req: MlPutDataFrameAnalyticsRequest) =
            { req with AllowLazyStart = Some value }
        let withAnalysis (value: MlTypes.DataframeAnalysisContainer) (req: MlPutDataFrameAnalyticsRequest) =
            { req with Analysis = value }
        let withAnalyzedFields (value: MlTypes.DataframeAnalysisAnalyzedFields) (req: MlPutDataFrameAnalyticsRequest) =
            { req with AnalyzedFields = Some value }
        let withDescription (value: string) (req: MlPutDataFrameAnalyticsRequest) =
            { req with Description = Some value }
        let withDest (value: MlTypes.DataframeAnalyticsDestination) (req: MlPutDataFrameAnalyticsRequest) =
            { req with Dest = value }
        let withMaxNumThreads (value: CoreTypes.Integer) (req: MlPutDataFrameAnalyticsRequest) =
            { req with MaxNumThreads = Some value }
        let withMeta (value: CoreTypes.Metadata) (req: MlPutDataFrameAnalyticsRequest) =
            { req with Meta = Some value }
        let withModelMemoryLimit (value: string) (req: MlPutDataFrameAnalyticsRequest) =
            { req with ModelMemoryLimit = Some value }
        let withSource (value: MlTypes.DataframeAnalyticsSource) (req: MlPutDataFrameAnalyticsRequest) =
            { req with Source = value }
        let withHeaders (value: CoreTypes.HttpHeaders) (req: MlPutDataFrameAnalyticsRequest) =
            { req with Headers = Some value }
        let withVersion (value: CoreTypes.VersionString) (req: MlPutDataFrameAnalyticsRequest) =
            { req with Version = Some value }

    type MlPutDatafeedRequest = {
        DatafeedId: CoreTypes.Id
        AllowNoIndices: bool option
        ExpandWildcards: CoreTypes.ExpandWildcards option
        IgnoreThrottled: bool option
        IgnoreUnavailable: bool option
        Aggregations: Map<string, CoreTypes.AggregationContainer> option
        ChunkingConfig: MlTypes.ChunkingConfig option
        DelayedDataCheckConfig: MlTypes.DelayedDataCheckConfig option
        Frequency: CoreTypes.Duration option
        Indices: CoreTypes.Indices option
        IndicesOptions: CoreTypes.IndicesOptions option
        JobId: CoreTypes.Id option
        MaxEmptySearches: CoreTypes.Integer option
        Query: CoreTypes.QueryContainer option
        QueryDelay: CoreTypes.Duration option
        RuntimeMappings: CoreTypes.RuntimeFields option
        ScriptFields: Map<string, CoreTypes.ScriptField> option
        ScrollSize: CoreTypes.Integer option
        Headers: CoreTypes.HttpHeaders option
    }

        with
        static member ToRequest(req: MlPutDatafeedRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/datafeeds/{req.DatafeedId}"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.IgnoreThrottled |> Option.map (fun v -> "ignore_throttled", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
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

    type MlPutDatafeedResponse = System.Text.Json.JsonElement

    type MlPutDatafeedRequestBuilder() =
        member _.Yield(_: unit) : MlPutDatafeedRequest =
            {
                DatafeedId = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreThrottled = None
                IgnoreUnavailable = None
                Aggregations = None
                ChunkingConfig = None
                DelayedDataCheckConfig = None
                Frequency = None
                Indices = None
                IndicesOptions = None
                JobId = None
                MaxEmptySearches = None
                Query = None
                QueryDelay = None
                RuntimeMappings = None
                ScriptFields = None
                ScrollSize = None
                Headers = None
            }

        [<CustomOperation("datafeedId")>]
        member _.DatafeedId(state: MlPutDatafeedRequest, value: CoreTypes.Id) =
            { state with DatafeedId = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: MlPutDatafeedRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: MlPutDatafeedRequest, value: CoreTypes.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreThrottled")>]
        member _.IgnoreThrottled(state: MlPutDatafeedRequest, value: bool) =
            { state with IgnoreThrottled = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: MlPutDatafeedRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: MlPutDatafeedRequest, value: Map<string, CoreTypes.AggregationContainer>) =
            { state with Aggregations = Some value }

        [<CustomOperation("chunkingConfig")>]
        member _.ChunkingConfig(state: MlPutDatafeedRequest, value: MlTypes.ChunkingConfig) =
            { state with ChunkingConfig = Some value }

        [<CustomOperation("delayedDataCheckConfig")>]
        member _.DelayedDataCheckConfig(state: MlPutDatafeedRequest, value: MlTypes.DelayedDataCheckConfig) =
            { state with DelayedDataCheckConfig = Some value }

        [<CustomOperation("frequency")>]
        member _.Frequency(state: MlPutDatafeedRequest, value: CoreTypes.Duration) =
            { state with Frequency = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: MlPutDatafeedRequest, value: CoreTypes.Indices) =
            { state with Indices = Some value }

        [<CustomOperation("indicesOptions")>]
        member _.IndicesOptions(state: MlPutDatafeedRequest, value: CoreTypes.IndicesOptions) =
            { state with IndicesOptions = Some value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlPutDatafeedRequest, value: CoreTypes.Id) =
            { state with JobId = Some value }

        [<CustomOperation("maxEmptySearches")>]
        member _.MaxEmptySearches(state: MlPutDatafeedRequest, value: CoreTypes.Integer) =
            { state with MaxEmptySearches = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: MlPutDatafeedRequest, value: CoreTypes.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("queryDelay")>]
        member _.QueryDelay(state: MlPutDatafeedRequest, value: CoreTypes.Duration) =
            { state with QueryDelay = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: MlPutDatafeedRequest, value: CoreTypes.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("scriptFields")>]
        member _.ScriptFields(state: MlPutDatafeedRequest, value: Map<string, CoreTypes.ScriptField>) =
            { state with ScriptFields = Some value }

        [<CustomOperation("scrollSize")>]
        member _.ScrollSize(state: MlPutDatafeedRequest, value: CoreTypes.Integer) =
            { state with ScrollSize = Some value }

        [<CustomOperation("headers")>]
        member _.Headers(state: MlPutDatafeedRequest, value: CoreTypes.HttpHeaders) =
            { state with Headers = Some value }

    let mlPutDatafeedRequest = MlPutDatafeedRequestBuilder()

    module PutDatafeed =
        let withAllowNoIndices (value: bool) (req: MlPutDatafeedRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: CoreTypes.ExpandWildcards) (req: MlPutDatafeedRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreThrottled (value: bool) (req: MlPutDatafeedRequest) =
            { req with IgnoreThrottled = Some value }
        let withIgnoreUnavailable (value: bool) (req: MlPutDatafeedRequest) =
            { req with IgnoreUnavailable = Some value }
        let withAggregations (value: Map<string, CoreTypes.AggregationContainer>) (req: MlPutDatafeedRequest) =
            { req with Aggregations = Some value }
        let withChunkingConfig (value: MlTypes.ChunkingConfig) (req: MlPutDatafeedRequest) =
            { req with ChunkingConfig = Some value }
        let withDelayedDataCheckConfig (value: MlTypes.DelayedDataCheckConfig) (req: MlPutDatafeedRequest) =
            { req with DelayedDataCheckConfig = Some value }
        let withFrequency (value: CoreTypes.Duration) (req: MlPutDatafeedRequest) =
            { req with Frequency = Some value }
        let withIndices (value: CoreTypes.Indices) (req: MlPutDatafeedRequest) =
            { req with Indices = Some value }
        let withIndicesOptions (value: CoreTypes.IndicesOptions) (req: MlPutDatafeedRequest) =
            { req with IndicesOptions = Some value }
        let withJobId (value: CoreTypes.Id) (req: MlPutDatafeedRequest) =
            { req with JobId = Some value }
        let withMaxEmptySearches (value: CoreTypes.Integer) (req: MlPutDatafeedRequest) =
            { req with MaxEmptySearches = Some value }
        let withQuery (value: CoreTypes.QueryContainer) (req: MlPutDatafeedRequest) =
            { req with Query = Some value }
        let withQueryDelay (value: CoreTypes.Duration) (req: MlPutDatafeedRequest) =
            { req with QueryDelay = Some value }
        let withRuntimeMappings (value: CoreTypes.RuntimeFields) (req: MlPutDatafeedRequest) =
            { req with RuntimeMappings = Some value }
        let withScriptFields (value: Map<string, CoreTypes.ScriptField>) (req: MlPutDatafeedRequest) =
            { req with ScriptFields = Some value }
        let withScrollSize (value: CoreTypes.Integer) (req: MlPutDatafeedRequest) =
            { req with ScrollSize = Some value }
        let withHeaders (value: CoreTypes.HttpHeaders) (req: MlPutDatafeedRequest) =
            { req with Headers = Some value }

    type MlPutFilterRequest = {
        FilterId: CoreTypes.Id
        Description: string option
        Items: string list option
    }

        with
        static member ToRequest(req: MlPutFilterRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/filters/{req.FilterId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type MlPutFilterResponse = System.Text.Json.JsonElement

    type MlPutFilterRequestBuilder() =
        member _.Yield(_: unit) : MlPutFilterRequest =
            {
                FilterId = Unchecked.defaultof<_>
                Description = None
                Items = None
            }

        [<CustomOperation("filterId")>]
        member _.FilterId(state: MlPutFilterRequest, value: CoreTypes.Id) =
            { state with FilterId = value }

        [<CustomOperation("description")>]
        member _.Description(state: MlPutFilterRequest, value: string) =
            { state with Description = Some value }

        [<CustomOperation("items")>]
        member _.Items(state: MlPutFilterRequest, value: string list) =
            { state with Items = Some value }

    let mlPutFilterRequest = MlPutFilterRequestBuilder()

    module PutFilter =
        let withDescription (value: string) (req: MlPutFilterRequest) =
            { req with Description = Some value }
        let withItems (value: string list) (req: MlPutFilterRequest) =
            { req with Items = Some value }

    type MlPutJobRequest = {
        JobId: CoreTypes.Id
        AllowNoIndices: bool option
        ExpandWildcards: CoreTypes.ExpandWildcards option
        IgnoreThrottled: bool option
        IgnoreUnavailable: bool option
        AllowLazyOpen: bool option
        AnalysisConfig: MlTypes.AnalysisConfig
        AnalysisLimits: MlTypes.AnalysisLimits option
        BackgroundPersistInterval: CoreTypes.Duration option
        CustomSettings: MlTypes.CustomSettings option
        DailyModelSnapshotRetentionAfterDays: CoreTypes.Long option
        DataDescription: MlTypes.DataDescription
        DatafeedConfig: MlTypes.DatafeedConfig option
        Description: string option
        JobId: CoreTypes.Id option
        Groups: string list option
        ModelPlotConfig: MlTypes.ModelPlotConfig option
        ModelSnapshotRetentionDays: CoreTypes.Long option
        RenormalizationWindowDays: CoreTypes.Long option
        ResultsIndexName: CoreTypes.IndexName option
        ResultsRetentionDays: CoreTypes.Long option
    }

        with
        static member ToRequest(req: MlPutJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{req.JobId}"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.IgnoreThrottled |> Option.map (fun v -> "ignore_throttled", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
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

    type MlPutJobResponse = System.Text.Json.JsonElement

    type MlPutJobRequestBuilder() =
        member _.Yield(_: unit) : MlPutJobRequest =
            {
                JobId = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreThrottled = None
                IgnoreUnavailable = None
                AllowLazyOpen = None
                AnalysisConfig = Unchecked.defaultof<_>
                AnalysisLimits = None
                BackgroundPersistInterval = None
                CustomSettings = None
                DailyModelSnapshotRetentionAfterDays = None
                DataDescription = Unchecked.defaultof<_>
                DatafeedConfig = None
                Description = None
                JobId = None
                Groups = None
                ModelPlotConfig = None
                ModelSnapshotRetentionDays = None
                RenormalizationWindowDays = None
                ResultsIndexName = None
                ResultsRetentionDays = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlPutJobRequest, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: MlPutJobRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: MlPutJobRequest, value: CoreTypes.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreThrottled")>]
        member _.IgnoreThrottled(state: MlPutJobRequest, value: bool) =
            { state with IgnoreThrottled = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: MlPutJobRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("allowLazyOpen")>]
        member _.AllowLazyOpen(state: MlPutJobRequest, value: bool) =
            { state with AllowLazyOpen = Some value }

        [<CustomOperation("analysisConfig")>]
        member _.AnalysisConfig(state: MlPutJobRequest, value: MlTypes.AnalysisConfig) =
            { state with AnalysisConfig = value }

        [<CustomOperation("analysisLimits")>]
        member _.AnalysisLimits(state: MlPutJobRequest, value: MlTypes.AnalysisLimits) =
            { state with AnalysisLimits = Some value }

        [<CustomOperation("backgroundPersistInterval")>]
        member _.BackgroundPersistInterval(state: MlPutJobRequest, value: CoreTypes.Duration) =
            { state with BackgroundPersistInterval = Some value }

        [<CustomOperation("customSettings")>]
        member _.CustomSettings(state: MlPutJobRequest, value: MlTypes.CustomSettings) =
            { state with CustomSettings = Some value }

        [<CustomOperation("dailyModelSnapshotRetentionAfterDays")>]
        member _.DailyModelSnapshotRetentionAfterDays(state: MlPutJobRequest, value: CoreTypes.Long) =
            { state with DailyModelSnapshotRetentionAfterDays = Some value }

        [<CustomOperation("dataDescription")>]
        member _.DataDescription(state: MlPutJobRequest, value: MlTypes.DataDescription) =
            { state with DataDescription = value }

        [<CustomOperation("datafeedConfig")>]
        member _.DatafeedConfig(state: MlPutJobRequest, value: MlTypes.DatafeedConfig) =
            { state with DatafeedConfig = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: MlPutJobRequest, value: string) =
            { state with Description = Some value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlPutJobRequest, value: CoreTypes.Id) =
            { state with JobId = Some value }

        [<CustomOperation("groups")>]
        member _.Groups(state: MlPutJobRequest, value: string list) =
            { state with Groups = Some value }

        [<CustomOperation("modelPlotConfig")>]
        member _.ModelPlotConfig(state: MlPutJobRequest, value: MlTypes.ModelPlotConfig) =
            { state with ModelPlotConfig = Some value }

        [<CustomOperation("modelSnapshotRetentionDays")>]
        member _.ModelSnapshotRetentionDays(state: MlPutJobRequest, value: CoreTypes.Long) =
            { state with ModelSnapshotRetentionDays = Some value }

        [<CustomOperation("renormalizationWindowDays")>]
        member _.RenormalizationWindowDays(state: MlPutJobRequest, value: CoreTypes.Long) =
            { state with RenormalizationWindowDays = Some value }

        [<CustomOperation("resultsIndexName")>]
        member _.ResultsIndexName(state: MlPutJobRequest, value: CoreTypes.IndexName) =
            { state with ResultsIndexName = Some value }

        [<CustomOperation("resultsRetentionDays")>]
        member _.ResultsRetentionDays(state: MlPutJobRequest, value: CoreTypes.Long) =
            { state with ResultsRetentionDays = Some value }

    let mlPutJobRequest = MlPutJobRequestBuilder()

    module PutJob =
        let withAllowNoIndices (value: bool) (req: MlPutJobRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: CoreTypes.ExpandWildcards) (req: MlPutJobRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreThrottled (value: bool) (req: MlPutJobRequest) =
            { req with IgnoreThrottled = Some value }
        let withIgnoreUnavailable (value: bool) (req: MlPutJobRequest) =
            { req with IgnoreUnavailable = Some value }
        let withAllowLazyOpen (value: bool) (req: MlPutJobRequest) =
            { req with AllowLazyOpen = Some value }
        let withAnalysisConfig (value: MlTypes.AnalysisConfig) (req: MlPutJobRequest) =
            { req with AnalysisConfig = value }
        let withAnalysisLimits (value: MlTypes.AnalysisLimits) (req: MlPutJobRequest) =
            { req with AnalysisLimits = Some value }
        let withBackgroundPersistInterval (value: CoreTypes.Duration) (req: MlPutJobRequest) =
            { req with BackgroundPersistInterval = Some value }
        let withCustomSettings (value: MlTypes.CustomSettings) (req: MlPutJobRequest) =
            { req with CustomSettings = Some value }
        let withDailyModelSnapshotRetentionAfterDays (value: CoreTypes.Long) (req: MlPutJobRequest) =
            { req with DailyModelSnapshotRetentionAfterDays = Some value }
        let withDataDescription (value: MlTypes.DataDescription) (req: MlPutJobRequest) =
            { req with DataDescription = value }
        let withDatafeedConfig (value: MlTypes.DatafeedConfig) (req: MlPutJobRequest) =
            { req with DatafeedConfig = Some value }
        let withDescription (value: string) (req: MlPutJobRequest) =
            { req with Description = Some value }
        let withJobId (value: CoreTypes.Id) (req: MlPutJobRequest) =
            { req with JobId = Some value }
        let withGroups (value: string list) (req: MlPutJobRequest) =
            { req with Groups = Some value }
        let withModelPlotConfig (value: MlTypes.ModelPlotConfig) (req: MlPutJobRequest) =
            { req with ModelPlotConfig = Some value }
        let withModelSnapshotRetentionDays (value: CoreTypes.Long) (req: MlPutJobRequest) =
            { req with ModelSnapshotRetentionDays = Some value }
        let withRenormalizationWindowDays (value: CoreTypes.Long) (req: MlPutJobRequest) =
            { req with RenormalizationWindowDays = Some value }
        let withResultsIndexName (value: CoreTypes.IndexName) (req: MlPutJobRequest) =
            { req with ResultsIndexName = Some value }
        let withResultsRetentionDays (value: CoreTypes.Long) (req: MlPutJobRequest) =
            { req with ResultsRetentionDays = Some value }

    type MlPutTrainedModelRequest = {
        ModelId: CoreTypes.Id
        DeferDefinitionDecompression: bool option
        WaitForCompletion: bool option
        CompressedDefinition: string option
        Definition: MlPutTrainedModel.Definition option
        Description: string option
        InferenceConfig: MlTypes.InferenceConfigCreateContainer option
        Input: MlPutTrainedModel.Input option
        Metadata: System.Text.Json.JsonElement option
        ModelType: MlTypes.TrainedModelType option
        ModelSizeBytes: CoreTypes.Long option
        PlatformArchitecture: string option
        Tags: string list option
        PrefixStrings: MlTypes.TrainedModelPrefixStrings option
    }

        with
        static member ToRequest(req: MlPutTrainedModelRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{req.ModelId}"
                let queryParams =
                    [
                        req.DeferDefinitionDecompression |> Option.map (fun v -> "defer_definition_decompression", Fes.Http.toQueryValue v)
                        req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
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

    type MlPutTrainedModelResponse = MlTypes.TrainedModelConfig

    type MlPutTrainedModelRequestBuilder() =
        member _.Yield(_: unit) : MlPutTrainedModelRequest =
            {
                ModelId = Unchecked.defaultof<_>
                DeferDefinitionDecompression = None
                WaitForCompletion = None
                CompressedDefinition = None
                Definition = None
                Description = None
                InferenceConfig = None
                Input = None
                Metadata = None
                ModelType = None
                ModelSizeBytes = None
                PlatformArchitecture = None
                Tags = None
                PrefixStrings = None
            }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: MlPutTrainedModelRequest, value: CoreTypes.Id) =
            { state with ModelId = value }

        [<CustomOperation("deferDefinitionDecompression")>]
        member _.DeferDefinitionDecompression(state: MlPutTrainedModelRequest, value: bool) =
            { state with DeferDefinitionDecompression = Some value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: MlPutTrainedModelRequest, value: bool) =
            { state with WaitForCompletion = Some value }

        [<CustomOperation("compressedDefinition")>]
        member _.CompressedDefinition(state: MlPutTrainedModelRequest, value: string) =
            { state with CompressedDefinition = Some value }

        [<CustomOperation("definition")>]
        member _.Definition(state: MlPutTrainedModelRequest, value: MlPutTrainedModel.Definition) =
            { state with Definition = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: MlPutTrainedModelRequest, value: string) =
            { state with Description = Some value }

        [<CustomOperation("inferenceConfig")>]
        member _.InferenceConfig(state: MlPutTrainedModelRequest, value: MlTypes.InferenceConfigCreateContainer) =
            { state with InferenceConfig = Some value }

        [<CustomOperation("input")>]
        member _.Input(state: MlPutTrainedModelRequest, value: MlPutTrainedModel.Input) =
            { state with Input = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: MlPutTrainedModelRequest, value: System.Text.Json.JsonElement) =
            { state with Metadata = Some value }

        [<CustomOperation("modelType")>]
        member _.ModelType(state: MlPutTrainedModelRequest, value: MlTypes.TrainedModelType) =
            { state with ModelType = Some value }

        [<CustomOperation("modelSizeBytes")>]
        member _.ModelSizeBytes(state: MlPutTrainedModelRequest, value: CoreTypes.Long) =
            { state with ModelSizeBytes = Some value }

        [<CustomOperation("platformArchitecture")>]
        member _.PlatformArchitecture(state: MlPutTrainedModelRequest, value: string) =
            { state with PlatformArchitecture = Some value }

        [<CustomOperation("tags")>]
        member _.Tags(state: MlPutTrainedModelRequest, value: string list) =
            { state with Tags = Some value }

        [<CustomOperation("prefixStrings")>]
        member _.PrefixStrings(state: MlPutTrainedModelRequest, value: MlTypes.TrainedModelPrefixStrings) =
            { state with PrefixStrings = Some value }

    let mlPutTrainedModelRequest = MlPutTrainedModelRequestBuilder()

    module PutTrainedModel =
        let withDeferDefinitionDecompression (value: bool) (req: MlPutTrainedModelRequest) =
            { req with DeferDefinitionDecompression = Some value }
        let withWaitForCompletion (value: bool) (req: MlPutTrainedModelRequest) =
            { req with WaitForCompletion = Some value }
        let withCompressedDefinition (value: string) (req: MlPutTrainedModelRequest) =
            { req with CompressedDefinition = Some value }
        let withDefinition (value: MlPutTrainedModel.Definition) (req: MlPutTrainedModelRequest) =
            { req with Definition = Some value }
        let withDescription (value: string) (req: MlPutTrainedModelRequest) =
            { req with Description = Some value }
        let withInferenceConfig (value: MlTypes.InferenceConfigCreateContainer) (req: MlPutTrainedModelRequest) =
            { req with InferenceConfig = Some value }
        let withInput (value: MlPutTrainedModel.Input) (req: MlPutTrainedModelRequest) =
            { req with Input = Some value }
        let withMetadata (value: System.Text.Json.JsonElement) (req: MlPutTrainedModelRequest) =
            { req with Metadata = Some value }
        let withModelType (value: MlTypes.TrainedModelType) (req: MlPutTrainedModelRequest) =
            { req with ModelType = Some value }
        let withModelSizeBytes (value: CoreTypes.Long) (req: MlPutTrainedModelRequest) =
            { req with ModelSizeBytes = Some value }
        let withPlatformArchitecture (value: string) (req: MlPutTrainedModelRequest) =
            { req with PlatformArchitecture = Some value }
        let withTags (value: string list) (req: MlPutTrainedModelRequest) =
            { req with Tags = Some value }
        let withPrefixStrings (value: MlTypes.TrainedModelPrefixStrings) (req: MlPutTrainedModelRequest) =
            { req with PrefixStrings = Some value }

    type MlPutTrainedModelAliasRequest = {
        ModelAlias: CoreTypes.Name
        ModelId: CoreTypes.Id
        Reassign: bool option
    }

        with
        static member ToRequest(req: MlPutTrainedModelAliasRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{req.ModelId}/model_aliases/{req.ModelAlias}"
                let queryParams =
                    [
                        req.Reassign |> Option.map (fun v -> "reassign", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Result.Ok
            with ex -> Result.Error ex

    type MlPutTrainedModelAliasResponse = CoreTypes.AcknowledgedResponseBase

    type MlPutTrainedModelAliasRequestBuilder() =
        member _.Yield(_: unit) : MlPutTrainedModelAliasRequest =
            {
                ModelAlias = Unchecked.defaultof<_>
                ModelId = Unchecked.defaultof<_>
                Reassign = None
            }

        [<CustomOperation("modelAlias")>]
        member _.ModelAlias(state: MlPutTrainedModelAliasRequest, value: CoreTypes.Name) =
            { state with ModelAlias = value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: MlPutTrainedModelAliasRequest, value: CoreTypes.Id) =
            { state with ModelId = value }

        [<CustomOperation("reassign")>]
        member _.Reassign(state: MlPutTrainedModelAliasRequest, value: bool) =
            { state with Reassign = Some value }

    let mlPutTrainedModelAliasRequest = MlPutTrainedModelAliasRequestBuilder()

    module PutTrainedModelAlias =
        let withReassign (value: bool) (req: MlPutTrainedModelAliasRequest) =
            { req with Reassign = Some value }

    type MlPutTrainedModelDefinitionPartRequest = {
        ModelId: CoreTypes.Id
        Part: CoreTypes.Integer
        Definition: string
        TotalDefinitionLength: CoreTypes.Long
        TotalParts: CoreTypes.Integer
    }

        with
        static member ToRequest(req: MlPutTrainedModelDefinitionPartRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{req.ModelId}/definition/{req.Part}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type MlPutTrainedModelDefinitionPartResponse = CoreTypes.AcknowledgedResponseBase

    type MlPutTrainedModelDefinitionPartRequestBuilder() =
        member _.Yield(_: unit) : MlPutTrainedModelDefinitionPartRequest =
            {
                ModelId = Unchecked.defaultof<_>
                Part = Unchecked.defaultof<_>
                Definition = Unchecked.defaultof<_>
                TotalDefinitionLength = Unchecked.defaultof<_>
                TotalParts = Unchecked.defaultof<_>
            }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: MlPutTrainedModelDefinitionPartRequest, value: CoreTypes.Id) =
            { state with ModelId = value }

        [<CustomOperation("part")>]
        member _.Part(state: MlPutTrainedModelDefinitionPartRequest, value: CoreTypes.Integer) =
            { state with Part = value }

        [<CustomOperation("definition")>]
        member _.Definition(state: MlPutTrainedModelDefinitionPartRequest, value: string) =
            { state with Definition = value }

        [<CustomOperation("totalDefinitionLength")>]
        member _.TotalDefinitionLength(state: MlPutTrainedModelDefinitionPartRequest, value: CoreTypes.Long) =
            { state with TotalDefinitionLength = value }

        [<CustomOperation("totalParts")>]
        member _.TotalParts(state: MlPutTrainedModelDefinitionPartRequest, value: CoreTypes.Integer) =
            { state with TotalParts = value }

    let mlPutTrainedModelDefinitionPartRequest = MlPutTrainedModelDefinitionPartRequestBuilder()

    module PutTrainedModelDefinitionPart =
        let withDefinition (value: string) (req: MlPutTrainedModelDefinitionPartRequest) =
            { req with Definition = value }
        let withTotalDefinitionLength (value: CoreTypes.Long) (req: MlPutTrainedModelDefinitionPartRequest) =
            { req with TotalDefinitionLength = value }
        let withTotalParts (value: CoreTypes.Integer) (req: MlPutTrainedModelDefinitionPartRequest) =
            { req with TotalParts = value }

    type MlPutTrainedModelVocabularyRequest = {
        ModelId: CoreTypes.Id
        Vocabulary: string list
        Merges: string list option
        Scores: CoreTypes.Double list option
    }

        with
        static member ToRequest(req: MlPutTrainedModelVocabularyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{req.ModelId}/vocabulary"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type MlPutTrainedModelVocabularyResponse = CoreTypes.AcknowledgedResponseBase

    type MlPutTrainedModelVocabularyRequestBuilder() =
        member _.Yield(_: unit) : MlPutTrainedModelVocabularyRequest =
            {
                ModelId = Unchecked.defaultof<_>
                Vocabulary = Unchecked.defaultof<_>
                Merges = None
                Scores = None
            }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: MlPutTrainedModelVocabularyRequest, value: CoreTypes.Id) =
            { state with ModelId = value }

        [<CustomOperation("vocabulary")>]
        member _.Vocabulary(state: MlPutTrainedModelVocabularyRequest, value: string list) =
            { state with Vocabulary = value }

        [<CustomOperation("merges")>]
        member _.Merges(state: MlPutTrainedModelVocabularyRequest, value: string list) =
            { state with Merges = Some value }

        [<CustomOperation("scores")>]
        member _.Scores(state: MlPutTrainedModelVocabularyRequest, value: CoreTypes.Double list) =
            { state with Scores = Some value }

    let mlPutTrainedModelVocabularyRequest = MlPutTrainedModelVocabularyRequestBuilder()

    module PutTrainedModelVocabulary =
        let withVocabulary (value: string list) (req: MlPutTrainedModelVocabularyRequest) =
            { req with Vocabulary = value }
        let withMerges (value: string list) (req: MlPutTrainedModelVocabularyRequest) =
            { req with Merges = Some value }
        let withScores (value: CoreTypes.Double list) (req: MlPutTrainedModelVocabularyRequest) =
            { req with Scores = Some value }

    type MlResetJobRequest = {
        JobId: CoreTypes.Id
        WaitForCompletion: bool option
        DeleteUserAnnotations: bool option
    }

        with
        static member ToRequest(req: MlResetJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{req.JobId}/_reset"
                let queryParams =
                    [
                        req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                        req.DeleteUserAnnotations |> Option.map (fun v -> "delete_user_annotations", Fes.Http.toQueryValue v)
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

    type MlResetJobResponse = CoreTypes.AcknowledgedResponseBase

    type MlResetJobRequestBuilder() =
        member _.Yield(_: unit) : MlResetJobRequest =
            {
                JobId = Unchecked.defaultof<_>
                WaitForCompletion = None
                DeleteUserAnnotations = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlResetJobRequest, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: MlResetJobRequest, value: bool) =
            { state with WaitForCompletion = Some value }

        [<CustomOperation("deleteUserAnnotations")>]
        member _.DeleteUserAnnotations(state: MlResetJobRequest, value: bool) =
            { state with DeleteUserAnnotations = Some value }

    let mlResetJobRequest = MlResetJobRequestBuilder()

    module ResetJob =
        let withWaitForCompletion (value: bool) (req: MlResetJobRequest) =
            { req with WaitForCompletion = Some value }
        let withDeleteUserAnnotations (value: bool) (req: MlResetJobRequest) =
            { req with DeleteUserAnnotations = Some value }

    type MlRevertModelSnapshotRequest = {
        JobId: CoreTypes.Id
        SnapshotId: CoreTypes.Id
        DeleteInterveningResults: bool option
        DeleteInterveningResults: bool option
    }

        with
        static member ToRequest(req: MlRevertModelSnapshotRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{req.JobId}/model_snapshots/{req.SnapshotId}/_revert"
                let queryParams =
                    [
                        req.DeleteInterveningResults |> Option.map (fun v -> "delete_intervening_results", Fes.Http.toQueryValue v)
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

    type MlRevertModelSnapshotResponse = System.Text.Json.JsonElement

    type MlRevertModelSnapshotRequestBuilder() =
        member _.Yield(_: unit) : MlRevertModelSnapshotRequest =
            {
                JobId = Unchecked.defaultof<_>
                SnapshotId = Unchecked.defaultof<_>
                DeleteInterveningResults = None
                DeleteInterveningResults = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlRevertModelSnapshotRequest, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("snapshotId")>]
        member _.SnapshotId(state: MlRevertModelSnapshotRequest, value: CoreTypes.Id) =
            { state with SnapshotId = value }

        [<CustomOperation("deleteInterveningResults")>]
        member _.DeleteInterveningResults(state: MlRevertModelSnapshotRequest, value: bool) =
            { state with DeleteInterveningResults = Some value }

        [<CustomOperation("deleteInterveningResults")>]
        member _.DeleteInterveningResults(state: MlRevertModelSnapshotRequest, value: bool) =
            { state with DeleteInterveningResults = Some value }

    let mlRevertModelSnapshotRequest = MlRevertModelSnapshotRequestBuilder()

    module RevertModelSnapshot =
        let withDeleteInterveningResults (value: bool) (req: MlRevertModelSnapshotRequest) =
            { req with DeleteInterveningResults = Some value }
        let withDeleteInterveningResults (value: bool) (req: MlRevertModelSnapshotRequest) =
            { req with DeleteInterveningResults = Some value }

    type MlSetUpgradeModeRequest = {
        Enabled: bool option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: MlSetUpgradeModeRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/set_upgrade_mode"
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

    type MlSetUpgradeModeResponse = CoreTypes.AcknowledgedResponseBase

    type MlSetUpgradeModeRequestBuilder() =
        member _.Yield(_: unit) : MlSetUpgradeModeRequest =
            {
                Enabled = None
                Timeout = None
            }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: MlSetUpgradeModeRequest, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlSetUpgradeModeRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let mlSetUpgradeModeRequest = MlSetUpgradeModeRequestBuilder()

    module SetUpgradeMode =
        let withEnabled (value: bool) (req: MlSetUpgradeModeRequest) =
            { req with Enabled = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: MlSetUpgradeModeRequest) =
            { req with Timeout = Some value }

    type MlStartDataFrameAnalyticsRequest = {
        Id: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        Id: CoreTypes.Id option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: MlStartDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/data_frame/analytics/{req.Id}/_start"
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

    type MlStartDataFrameAnalyticsResponse = System.Text.Json.JsonElement

    type MlStartDataFrameAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : MlStartDataFrameAnalyticsRequest =
            {
                Id = Unchecked.defaultof<_>
                Timeout = None
                Id = None
                Timeout = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: MlStartDataFrameAnalyticsRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlStartDataFrameAnalyticsRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: MlStartDataFrameAnalyticsRequest, value: CoreTypes.Id) =
            { state with Id = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlStartDataFrameAnalyticsRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let mlStartDataFrameAnalyticsRequest = MlStartDataFrameAnalyticsRequestBuilder()

    module StartDataFrameAnalytics =
        let withTimeout (value: CoreTypes.Duration) (req: MlStartDataFrameAnalyticsRequest) =
            { req with Timeout = Some value }
        let withId (value: CoreTypes.Id) (req: MlStartDataFrameAnalyticsRequest) =
            { req with Id = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: MlStartDataFrameAnalyticsRequest) =
            { req with Timeout = Some value }

    type MlStartDatafeedRequest = {
        DatafeedId: CoreTypes.Id
        End: CoreTypes.DateTime option
        Start: CoreTypes.DateTime option
        Timeout: CoreTypes.Duration option
        End: CoreTypes.DateTime option
        Start: CoreTypes.DateTime option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: MlStartDatafeedRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/datafeeds/{req.DatafeedId}/_start"
                let queryParams =
                    [
                        req.End |> Option.map (fun v -> "end", Fes.Http.toQueryValue v)
                        req.Start |> Option.map (fun v -> "start", Fes.Http.toQueryValue v)
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

    type MlStartDatafeedResponse = System.Text.Json.JsonElement

    type MlStartDatafeedRequestBuilder() =
        member _.Yield(_: unit) : MlStartDatafeedRequest =
            {
                DatafeedId = Unchecked.defaultof<_>
                End = None
                Start = None
                Timeout = None
                End = None
                Start = None
                Timeout = None
            }

        [<CustomOperation("datafeedId")>]
        member _.DatafeedId(state: MlStartDatafeedRequest, value: CoreTypes.Id) =
            { state with DatafeedId = value }

        [<CustomOperation("end'")>]
        member _.End(state: MlStartDatafeedRequest, value: CoreTypes.DateTime) =
            { state with End = Some value }

        [<CustomOperation("start")>]
        member _.Start(state: MlStartDatafeedRequest, value: CoreTypes.DateTime) =
            { state with Start = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlStartDatafeedRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("end'")>]
        member _.End(state: MlStartDatafeedRequest, value: CoreTypes.DateTime) =
            { state with End = Some value }

        [<CustomOperation("start")>]
        member _.Start(state: MlStartDatafeedRequest, value: CoreTypes.DateTime) =
            { state with Start = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlStartDatafeedRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let mlStartDatafeedRequest = MlStartDatafeedRequestBuilder()

    module StartDatafeed =
        let withEnd (value: CoreTypes.DateTime) (req: MlStartDatafeedRequest) =
            { req with End = Some value }
        let withStart (value: CoreTypes.DateTime) (req: MlStartDatafeedRequest) =
            { req with Start = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: MlStartDatafeedRequest) =
            { req with Timeout = Some value }
        let withEnd (value: CoreTypes.DateTime) (req: MlStartDatafeedRequest) =
            { req with End = Some value }
        let withStart (value: CoreTypes.DateTime) (req: MlStartDatafeedRequest) =
            { req with Start = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: MlStartDatafeedRequest) =
            { req with Timeout = Some value }

    type MlStartTrainedModelDeploymentRequest = {
        ModelId: CoreTypes.Id
        CacheSize: CoreTypes.ByteSize option
        DeploymentId: string option
        NumberOfAllocations: CoreTypes.Integer option
        Priority: MlTypes.TrainingPriority option
        QueueCapacity: CoreTypes.Integer option
        ThreadsPerAllocation: CoreTypes.Integer option
        Timeout: CoreTypes.Duration option
        WaitFor: MlTypes.DeploymentAllocationState option
        AdaptiveAllocations: MlTypes.AdaptiveAllocationsSettings option
    }

        with
        static member ToRequest(req: MlStartTrainedModelDeploymentRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{req.ModelId}/deployment/_start"
                let queryParams =
                    [
                        req.CacheSize |> Option.map (fun v -> "cache_size", Fes.Http.toQueryValue v)
                        req.DeploymentId |> Option.map (fun v -> "deployment_id", Fes.Http.toQueryValue v)
                        req.NumberOfAllocations |> Option.map (fun v -> "number_of_allocations", Fes.Http.toQueryValue v)
                        req.Priority |> Option.map (fun v -> "priority", Fes.Http.toQueryValue v)
                        req.QueueCapacity |> Option.map (fun v -> "queue_capacity", Fes.Http.toQueryValue v)
                        req.ThreadsPerAllocation |> Option.map (fun v -> "threads_per_allocation", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        req.WaitFor |> Option.map (fun v -> "wait_for", Fes.Http.toQueryValue v)
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

    type MlStartTrainedModelDeploymentResponse = System.Text.Json.JsonElement

    type MlStartTrainedModelDeploymentRequestBuilder() =
        member _.Yield(_: unit) : MlStartTrainedModelDeploymentRequest =
            {
                ModelId = Unchecked.defaultof<_>
                CacheSize = None
                DeploymentId = None
                NumberOfAllocations = None
                Priority = None
                QueueCapacity = None
                ThreadsPerAllocation = None
                Timeout = None
                WaitFor = None
                AdaptiveAllocations = None
            }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: MlStartTrainedModelDeploymentRequest, value: CoreTypes.Id) =
            { state with ModelId = value }

        [<CustomOperation("cacheSize")>]
        member _.CacheSize(state: MlStartTrainedModelDeploymentRequest, value: CoreTypes.ByteSize) =
            { state with CacheSize = Some value }

        [<CustomOperation("deploymentId")>]
        member _.DeploymentId(state: MlStartTrainedModelDeploymentRequest, value: string) =
            { state with DeploymentId = Some value }

        [<CustomOperation("numberOfAllocations")>]
        member _.NumberOfAllocations(state: MlStartTrainedModelDeploymentRequest, value: CoreTypes.Integer) =
            { state with NumberOfAllocations = Some value }

        [<CustomOperation("priority")>]
        member _.Priority(state: MlStartTrainedModelDeploymentRequest, value: MlTypes.TrainingPriority) =
            { state with Priority = Some value }

        [<CustomOperation("queueCapacity")>]
        member _.QueueCapacity(state: MlStartTrainedModelDeploymentRequest, value: CoreTypes.Integer) =
            { state with QueueCapacity = Some value }

        [<CustomOperation("threadsPerAllocation")>]
        member _.ThreadsPerAllocation(state: MlStartTrainedModelDeploymentRequest, value: CoreTypes.Integer) =
            { state with ThreadsPerAllocation = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlStartTrainedModelDeploymentRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("waitFor")>]
        member _.WaitFor(state: MlStartTrainedModelDeploymentRequest, value: MlTypes.DeploymentAllocationState) =
            { state with WaitFor = Some value }

        [<CustomOperation("adaptiveAllocations")>]
        member _.AdaptiveAllocations(state: MlStartTrainedModelDeploymentRequest, value: MlTypes.AdaptiveAllocationsSettings) =
            { state with AdaptiveAllocations = Some value }

    let mlStartTrainedModelDeploymentRequest = MlStartTrainedModelDeploymentRequestBuilder()

    module StartTrainedModelDeployment =
        let withCacheSize (value: CoreTypes.ByteSize) (req: MlStartTrainedModelDeploymentRequest) =
            { req with CacheSize = Some value }
        let withDeploymentId (value: string) (req: MlStartTrainedModelDeploymentRequest) =
            { req with DeploymentId = Some value }
        let withNumberOfAllocations (value: CoreTypes.Integer) (req: MlStartTrainedModelDeploymentRequest) =
            { req with NumberOfAllocations = Some value }
        let withPriority (value: MlTypes.TrainingPriority) (req: MlStartTrainedModelDeploymentRequest) =
            { req with Priority = Some value }
        let withQueueCapacity (value: CoreTypes.Integer) (req: MlStartTrainedModelDeploymentRequest) =
            { req with QueueCapacity = Some value }
        let withThreadsPerAllocation (value: CoreTypes.Integer) (req: MlStartTrainedModelDeploymentRequest) =
            { req with ThreadsPerAllocation = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: MlStartTrainedModelDeploymentRequest) =
            { req with Timeout = Some value }
        let withWaitFor (value: MlTypes.DeploymentAllocationState) (req: MlStartTrainedModelDeploymentRequest) =
            { req with WaitFor = Some value }
        let withAdaptiveAllocations (value: MlTypes.AdaptiveAllocationsSettings) (req: MlStartTrainedModelDeploymentRequest) =
            { req with AdaptiveAllocations = Some value }

    type MlStopDataFrameAnalyticsRequest = {
        Id: CoreTypes.Id
        AllowNoMatch: bool option
        Force: bool option
        Timeout: CoreTypes.Duration option
        Id: CoreTypes.Id option
        AllowNoMatch: bool option
        Force: bool option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: MlStopDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/data_frame/analytics/{req.Id}/_stop"
                let queryParams =
                    [
                        req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
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
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type MlStopDataFrameAnalyticsResponse = System.Text.Json.JsonElement

    type MlStopDataFrameAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : MlStopDataFrameAnalyticsRequest =
            {
                Id = Unchecked.defaultof<_>
                AllowNoMatch = None
                Force = None
                Timeout = None
                Id = None
                AllowNoMatch = None
                Force = None
                Timeout = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: MlStopDataFrameAnalyticsRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlStopDataFrameAnalyticsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("force")>]
        member _.Force(state: MlStopDataFrameAnalyticsRequest, value: bool) =
            { state with Force = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlStopDataFrameAnalyticsRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: MlStopDataFrameAnalyticsRequest, value: CoreTypes.Id) =
            { state with Id = Some value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlStopDataFrameAnalyticsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("force")>]
        member _.Force(state: MlStopDataFrameAnalyticsRequest, value: bool) =
            { state with Force = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlStopDataFrameAnalyticsRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let mlStopDataFrameAnalyticsRequest = MlStopDataFrameAnalyticsRequestBuilder()

    module StopDataFrameAnalytics =
        let withAllowNoMatch (value: bool) (req: MlStopDataFrameAnalyticsRequest) =
            { req with AllowNoMatch = Some value }
        let withForce (value: bool) (req: MlStopDataFrameAnalyticsRequest) =
            { req with Force = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: MlStopDataFrameAnalyticsRequest) =
            { req with Timeout = Some value }
        let withId (value: CoreTypes.Id) (req: MlStopDataFrameAnalyticsRequest) =
            { req with Id = Some value }
        let withAllowNoMatch (value: bool) (req: MlStopDataFrameAnalyticsRequest) =
            { req with AllowNoMatch = Some value }
        let withForce (value: bool) (req: MlStopDataFrameAnalyticsRequest) =
            { req with Force = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: MlStopDataFrameAnalyticsRequest) =
            { req with Timeout = Some value }

    type MlStopDatafeedRequest = {
        DatafeedId: CoreTypes.Id
        AllowNoMatch: bool option
        Force: bool option
        Timeout: CoreTypes.Duration option
        CloseJob: bool option
        AllowNoMatch: bool option
        Force: bool option
        Timeout: CoreTypes.Duration option
        CloseJob: bool option
    }

        with
        static member ToRequest(req: MlStopDatafeedRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/datafeeds/{req.DatafeedId}/_stop"
                let queryParams =
                    [
                        req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                        req.Force |> Option.map (fun v -> "force", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        req.CloseJob |> Option.map (fun v -> "close_job", Fes.Http.toQueryValue v)
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

    type MlStopDatafeedResponse = System.Text.Json.JsonElement

    type MlStopDatafeedRequestBuilder() =
        member _.Yield(_: unit) : MlStopDatafeedRequest =
            {
                DatafeedId = Unchecked.defaultof<_>
                AllowNoMatch = None
                Force = None
                Timeout = None
                CloseJob = None
                AllowNoMatch = None
                Force = None
                Timeout = None
                CloseJob = None
            }

        [<CustomOperation("datafeedId")>]
        member _.DatafeedId(state: MlStopDatafeedRequest, value: CoreTypes.Id) =
            { state with DatafeedId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlStopDatafeedRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("force")>]
        member _.Force(state: MlStopDatafeedRequest, value: bool) =
            { state with Force = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlStopDatafeedRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("closeJob")>]
        member _.CloseJob(state: MlStopDatafeedRequest, value: bool) =
            { state with CloseJob = Some value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlStopDatafeedRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("force")>]
        member _.Force(state: MlStopDatafeedRequest, value: bool) =
            { state with Force = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlStopDatafeedRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("closeJob")>]
        member _.CloseJob(state: MlStopDatafeedRequest, value: bool) =
            { state with CloseJob = Some value }

    let mlStopDatafeedRequest = MlStopDatafeedRequestBuilder()

    module StopDatafeed =
        let withAllowNoMatch (value: bool) (req: MlStopDatafeedRequest) =
            { req with AllowNoMatch = Some value }
        let withForce (value: bool) (req: MlStopDatafeedRequest) =
            { req with Force = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: MlStopDatafeedRequest) =
            { req with Timeout = Some value }
        let withCloseJob (value: bool) (req: MlStopDatafeedRequest) =
            { req with CloseJob = Some value }
        let withAllowNoMatch (value: bool) (req: MlStopDatafeedRequest) =
            { req with AllowNoMatch = Some value }
        let withForce (value: bool) (req: MlStopDatafeedRequest) =
            { req with Force = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: MlStopDatafeedRequest) =
            { req with Timeout = Some value }
        let withCloseJob (value: bool) (req: MlStopDatafeedRequest) =
            { req with CloseJob = Some value }

    type MlStopTrainedModelDeploymentRequest = {
        ModelId: CoreTypes.Id
        AllowNoMatch: bool option
        Force: bool option
        Id: CoreTypes.Id option
        AllowNoMatch: bool option
        Force: bool option
    }

        with
        static member ToRequest(req: MlStopTrainedModelDeploymentRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{req.ModelId}/deployment/_stop"
                let queryParams =
                    [
                        req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                        req.Force |> Option.map (fun v -> "force", Fes.Http.toQueryValue v)
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

    type MlStopTrainedModelDeploymentResponse = System.Text.Json.JsonElement

    type MlStopTrainedModelDeploymentRequestBuilder() =
        member _.Yield(_: unit) : MlStopTrainedModelDeploymentRequest =
            {
                ModelId = Unchecked.defaultof<_>
                AllowNoMatch = None
                Force = None
                Id = None
                AllowNoMatch = None
                Force = None
            }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: MlStopTrainedModelDeploymentRequest, value: CoreTypes.Id) =
            { state with ModelId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlStopTrainedModelDeploymentRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("force")>]
        member _.Force(state: MlStopTrainedModelDeploymentRequest, value: bool) =
            { state with Force = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: MlStopTrainedModelDeploymentRequest, value: CoreTypes.Id) =
            { state with Id = Some value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlStopTrainedModelDeploymentRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("force")>]
        member _.Force(state: MlStopTrainedModelDeploymentRequest, value: bool) =
            { state with Force = Some value }

    let mlStopTrainedModelDeploymentRequest = MlStopTrainedModelDeploymentRequestBuilder()

    module StopTrainedModelDeployment =
        let withAllowNoMatch (value: bool) (req: MlStopTrainedModelDeploymentRequest) =
            { req with AllowNoMatch = Some value }
        let withForce (value: bool) (req: MlStopTrainedModelDeploymentRequest) =
            { req with Force = Some value }
        let withId (value: CoreTypes.Id) (req: MlStopTrainedModelDeploymentRequest) =
            { req with Id = Some value }
        let withAllowNoMatch (value: bool) (req: MlStopTrainedModelDeploymentRequest) =
            { req with AllowNoMatch = Some value }
        let withForce (value: bool) (req: MlStopTrainedModelDeploymentRequest) =
            { req with Force = Some value }

    type MlUpdateDataFrameAnalyticsRequest = {
        Id: CoreTypes.Id
        Description: string option
        ModelMemoryLimit: string option
        MaxNumThreads: CoreTypes.Integer option
        AllowLazyStart: bool option
    }

        with
        static member ToRequest(req: MlUpdateDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/data_frame/analytics/{req.Id}/_update"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type MlUpdateDataFrameAnalyticsResponse = System.Text.Json.JsonElement

    type MlUpdateDataFrameAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : MlUpdateDataFrameAnalyticsRequest =
            {
                Id = Unchecked.defaultof<_>
                Description = None
                ModelMemoryLimit = None
                MaxNumThreads = None
                AllowLazyStart = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: MlUpdateDataFrameAnalyticsRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("description")>]
        member _.Description(state: MlUpdateDataFrameAnalyticsRequest, value: string) =
            { state with Description = Some value }

        [<CustomOperation("modelMemoryLimit")>]
        member _.ModelMemoryLimit(state: MlUpdateDataFrameAnalyticsRequest, value: string) =
            { state with ModelMemoryLimit = Some value }

        [<CustomOperation("maxNumThreads")>]
        member _.MaxNumThreads(state: MlUpdateDataFrameAnalyticsRequest, value: CoreTypes.Integer) =
            { state with MaxNumThreads = Some value }

        [<CustomOperation("allowLazyStart")>]
        member _.AllowLazyStart(state: MlUpdateDataFrameAnalyticsRequest, value: bool) =
            { state with AllowLazyStart = Some value }

    let mlUpdateDataFrameAnalyticsRequest = MlUpdateDataFrameAnalyticsRequestBuilder()

    module UpdateDataFrameAnalytics =
        let withDescription (value: string) (req: MlUpdateDataFrameAnalyticsRequest) =
            { req with Description = Some value }
        let withModelMemoryLimit (value: string) (req: MlUpdateDataFrameAnalyticsRequest) =
            { req with ModelMemoryLimit = Some value }
        let withMaxNumThreads (value: CoreTypes.Integer) (req: MlUpdateDataFrameAnalyticsRequest) =
            { req with MaxNumThreads = Some value }
        let withAllowLazyStart (value: bool) (req: MlUpdateDataFrameAnalyticsRequest) =
            { req with AllowLazyStart = Some value }

    type MlUpdateDatafeedRequest = {
        DatafeedId: CoreTypes.Id
        AllowNoIndices: bool option
        ExpandWildcards: CoreTypes.ExpandWildcards option
        IgnoreThrottled: bool option
        IgnoreUnavailable: bool option
        Aggregations: Map<string, CoreTypes.AggregationContainer> option
        ChunkingConfig: MlTypes.ChunkingConfig option
        DelayedDataCheckConfig: MlTypes.DelayedDataCheckConfig option
        Frequency: CoreTypes.Duration option
        Indices: string list option
        IndicesOptions: CoreTypes.IndicesOptions option
        JobId: CoreTypes.Id option
        MaxEmptySearches: CoreTypes.Integer option
        Query: CoreTypes.QueryContainer option
        QueryDelay: CoreTypes.Duration option
        RuntimeMappings: CoreTypes.RuntimeFields option
        ScriptFields: Map<string, CoreTypes.ScriptField> option
        ScrollSize: CoreTypes.Integer option
    }

        with
        static member ToRequest(req: MlUpdateDatafeedRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/datafeeds/{req.DatafeedId}/_update"
                let queryParams =
                    [
                        req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        req.IgnoreThrottled |> Option.map (fun v -> "ignore_throttled", Fes.Http.toQueryValue v)
                        req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
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

    type MlUpdateDatafeedResponse = System.Text.Json.JsonElement

    type MlUpdateDatafeedRequestBuilder() =
        member _.Yield(_: unit) : MlUpdateDatafeedRequest =
            {
                DatafeedId = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreThrottled = None
                IgnoreUnavailable = None
                Aggregations = None
                ChunkingConfig = None
                DelayedDataCheckConfig = None
                Frequency = None
                Indices = None
                IndicesOptions = None
                JobId = None
                MaxEmptySearches = None
                Query = None
                QueryDelay = None
                RuntimeMappings = None
                ScriptFields = None
                ScrollSize = None
            }

        [<CustomOperation("datafeedId")>]
        member _.DatafeedId(state: MlUpdateDatafeedRequest, value: CoreTypes.Id) =
            { state with DatafeedId = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: MlUpdateDatafeedRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: MlUpdateDatafeedRequest, value: CoreTypes.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreThrottled")>]
        member _.IgnoreThrottled(state: MlUpdateDatafeedRequest, value: bool) =
            { state with IgnoreThrottled = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: MlUpdateDatafeedRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: MlUpdateDatafeedRequest, value: Map<string, CoreTypes.AggregationContainer>) =
            { state with Aggregations = Some value }

        [<CustomOperation("chunkingConfig")>]
        member _.ChunkingConfig(state: MlUpdateDatafeedRequest, value: MlTypes.ChunkingConfig) =
            { state with ChunkingConfig = Some value }

        [<CustomOperation("delayedDataCheckConfig")>]
        member _.DelayedDataCheckConfig(state: MlUpdateDatafeedRequest, value: MlTypes.DelayedDataCheckConfig) =
            { state with DelayedDataCheckConfig = Some value }

        [<CustomOperation("frequency")>]
        member _.Frequency(state: MlUpdateDatafeedRequest, value: CoreTypes.Duration) =
            { state with Frequency = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: MlUpdateDatafeedRequest, value: string list) =
            { state with Indices = Some value }

        [<CustomOperation("indicesOptions")>]
        member _.IndicesOptions(state: MlUpdateDatafeedRequest, value: CoreTypes.IndicesOptions) =
            { state with IndicesOptions = Some value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlUpdateDatafeedRequest, value: CoreTypes.Id) =
            { state with JobId = Some value }

        [<CustomOperation("maxEmptySearches")>]
        member _.MaxEmptySearches(state: MlUpdateDatafeedRequest, value: CoreTypes.Integer) =
            { state with MaxEmptySearches = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: MlUpdateDatafeedRequest, value: CoreTypes.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("queryDelay")>]
        member _.QueryDelay(state: MlUpdateDatafeedRequest, value: CoreTypes.Duration) =
            { state with QueryDelay = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: MlUpdateDatafeedRequest, value: CoreTypes.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("scriptFields")>]
        member _.ScriptFields(state: MlUpdateDatafeedRequest, value: Map<string, CoreTypes.ScriptField>) =
            { state with ScriptFields = Some value }

        [<CustomOperation("scrollSize")>]
        member _.ScrollSize(state: MlUpdateDatafeedRequest, value: CoreTypes.Integer) =
            { state with ScrollSize = Some value }

    let mlUpdateDatafeedRequest = MlUpdateDatafeedRequestBuilder()

    module UpdateDatafeed =
        let withAllowNoIndices (value: bool) (req: MlUpdateDatafeedRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: CoreTypes.ExpandWildcards) (req: MlUpdateDatafeedRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreThrottled (value: bool) (req: MlUpdateDatafeedRequest) =
            { req with IgnoreThrottled = Some value }
        let withIgnoreUnavailable (value: bool) (req: MlUpdateDatafeedRequest) =
            { req with IgnoreUnavailable = Some value }
        let withAggregations (value: Map<string, CoreTypes.AggregationContainer>) (req: MlUpdateDatafeedRequest) =
            { req with Aggregations = Some value }
        let withChunkingConfig (value: MlTypes.ChunkingConfig) (req: MlUpdateDatafeedRequest) =
            { req with ChunkingConfig = Some value }
        let withDelayedDataCheckConfig (value: MlTypes.DelayedDataCheckConfig) (req: MlUpdateDatafeedRequest) =
            { req with DelayedDataCheckConfig = Some value }
        let withFrequency (value: CoreTypes.Duration) (req: MlUpdateDatafeedRequest) =
            { req with Frequency = Some value }
        let withIndices (value: string list) (req: MlUpdateDatafeedRequest) =
            { req with Indices = Some value }
        let withIndicesOptions (value: CoreTypes.IndicesOptions) (req: MlUpdateDatafeedRequest) =
            { req with IndicesOptions = Some value }
        let withJobId (value: CoreTypes.Id) (req: MlUpdateDatafeedRequest) =
            { req with JobId = Some value }
        let withMaxEmptySearches (value: CoreTypes.Integer) (req: MlUpdateDatafeedRequest) =
            { req with MaxEmptySearches = Some value }
        let withQuery (value: CoreTypes.QueryContainer) (req: MlUpdateDatafeedRequest) =
            { req with Query = Some value }
        let withQueryDelay (value: CoreTypes.Duration) (req: MlUpdateDatafeedRequest) =
            { req with QueryDelay = Some value }
        let withRuntimeMappings (value: CoreTypes.RuntimeFields) (req: MlUpdateDatafeedRequest) =
            { req with RuntimeMappings = Some value }
        let withScriptFields (value: Map<string, CoreTypes.ScriptField>) (req: MlUpdateDatafeedRequest) =
            { req with ScriptFields = Some value }
        let withScrollSize (value: CoreTypes.Integer) (req: MlUpdateDatafeedRequest) =
            { req with ScrollSize = Some value }

    type MlUpdateFilterRequest = {
        FilterId: CoreTypes.Id
        AddItems: string list option
        Description: string option
        RemoveItems: string list option
    }

        with
        static member ToRequest(req: MlUpdateFilterRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/filters/{req.FilterId}/_update"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type MlUpdateFilterResponse = System.Text.Json.JsonElement

    type MlUpdateFilterRequestBuilder() =
        member _.Yield(_: unit) : MlUpdateFilterRequest =
            {
                FilterId = Unchecked.defaultof<_>
                AddItems = None
                Description = None
                RemoveItems = None
            }

        [<CustomOperation("filterId")>]
        member _.FilterId(state: MlUpdateFilterRequest, value: CoreTypes.Id) =
            { state with FilterId = value }

        [<CustomOperation("addItems")>]
        member _.AddItems(state: MlUpdateFilterRequest, value: string list) =
            { state with AddItems = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: MlUpdateFilterRequest, value: string) =
            { state with Description = Some value }

        [<CustomOperation("removeItems")>]
        member _.RemoveItems(state: MlUpdateFilterRequest, value: string list) =
            { state with RemoveItems = Some value }

    let mlUpdateFilterRequest = MlUpdateFilterRequestBuilder()

    module UpdateFilter =
        let withAddItems (value: string list) (req: MlUpdateFilterRequest) =
            { req with AddItems = Some value }
        let withDescription (value: string) (req: MlUpdateFilterRequest) =
            { req with Description = Some value }
        let withRemoveItems (value: string list) (req: MlUpdateFilterRequest) =
            { req with RemoveItems = Some value }

    type MlUpdateJobRequest = {
        JobId: CoreTypes.Id
        AllowLazyOpen: bool option
        AnalysisLimits: MlTypes.AnalysisMemoryLimit option
        BackgroundPersistInterval: CoreTypes.Duration option
        CustomSettings: Map<string, System.Text.Json.JsonElement> option
        CategorizationFilters: string list option
        Description: string option
        ModelPlotConfig: MlTypes.ModelPlotConfig option
        ModelPruneWindow: CoreTypes.Duration option
        DailyModelSnapshotRetentionAfterDays: CoreTypes.Long option
        ModelSnapshotRetentionDays: CoreTypes.Long option
        RenormalizationWindowDays: CoreTypes.Long option
        ResultsRetentionDays: CoreTypes.Long option
        Groups: string list option
        Detectors: MlTypes.DetectorUpdate list option
        PerPartitionCategorization: MlTypes.PerPartitionCategorization option
    }

        with
        static member ToRequest(req: MlUpdateJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{req.JobId}/_update"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type MlUpdateJobResponse = System.Text.Json.JsonElement

    type MlUpdateJobRequestBuilder() =
        member _.Yield(_: unit) : MlUpdateJobRequest =
            {
                JobId = Unchecked.defaultof<_>
                AllowLazyOpen = None
                AnalysisLimits = None
                BackgroundPersistInterval = None
                CustomSettings = None
                CategorizationFilters = None
                Description = None
                ModelPlotConfig = None
                ModelPruneWindow = None
                DailyModelSnapshotRetentionAfterDays = None
                ModelSnapshotRetentionDays = None
                RenormalizationWindowDays = None
                ResultsRetentionDays = None
                Groups = None
                Detectors = None
                PerPartitionCategorization = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlUpdateJobRequest, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("allowLazyOpen")>]
        member _.AllowLazyOpen(state: MlUpdateJobRequest, value: bool) =
            { state with AllowLazyOpen = Some value }

        [<CustomOperation("analysisLimits")>]
        member _.AnalysisLimits(state: MlUpdateJobRequest, value: MlTypes.AnalysisMemoryLimit) =
            { state with AnalysisLimits = Some value }

        [<CustomOperation("backgroundPersistInterval")>]
        member _.BackgroundPersistInterval(state: MlUpdateJobRequest, value: CoreTypes.Duration) =
            { state with BackgroundPersistInterval = Some value }

        [<CustomOperation("customSettings")>]
        member _.CustomSettings(state: MlUpdateJobRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with CustomSettings = Some value }

        [<CustomOperation("categorizationFilters")>]
        member _.CategorizationFilters(state: MlUpdateJobRequest, value: string list) =
            { state with CategorizationFilters = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: MlUpdateJobRequest, value: string) =
            { state with Description = Some value }

        [<CustomOperation("modelPlotConfig")>]
        member _.ModelPlotConfig(state: MlUpdateJobRequest, value: MlTypes.ModelPlotConfig) =
            { state with ModelPlotConfig = Some value }

        [<CustomOperation("modelPruneWindow")>]
        member _.ModelPruneWindow(state: MlUpdateJobRequest, value: CoreTypes.Duration) =
            { state with ModelPruneWindow = Some value }

        [<CustomOperation("dailyModelSnapshotRetentionAfterDays")>]
        member _.DailyModelSnapshotRetentionAfterDays(state: MlUpdateJobRequest, value: CoreTypes.Long) =
            { state with DailyModelSnapshotRetentionAfterDays = Some value }

        [<CustomOperation("modelSnapshotRetentionDays")>]
        member _.ModelSnapshotRetentionDays(state: MlUpdateJobRequest, value: CoreTypes.Long) =
            { state with ModelSnapshotRetentionDays = Some value }

        [<CustomOperation("renormalizationWindowDays")>]
        member _.RenormalizationWindowDays(state: MlUpdateJobRequest, value: CoreTypes.Long) =
            { state with RenormalizationWindowDays = Some value }

        [<CustomOperation("resultsRetentionDays")>]
        member _.ResultsRetentionDays(state: MlUpdateJobRequest, value: CoreTypes.Long) =
            { state with ResultsRetentionDays = Some value }

        [<CustomOperation("groups")>]
        member _.Groups(state: MlUpdateJobRequest, value: string list) =
            { state with Groups = Some value }

        [<CustomOperation("detectors")>]
        member _.Detectors(state: MlUpdateJobRequest, value: MlTypes.DetectorUpdate list) =
            { state with Detectors = Some value }

        [<CustomOperation("perPartitionCategorization")>]
        member _.PerPartitionCategorization(state: MlUpdateJobRequest, value: MlTypes.PerPartitionCategorization) =
            { state with PerPartitionCategorization = Some value }

    let mlUpdateJobRequest = MlUpdateJobRequestBuilder()

    module UpdateJob =
        let withAllowLazyOpen (value: bool) (req: MlUpdateJobRequest) =
            { req with AllowLazyOpen = Some value }
        let withAnalysisLimits (value: MlTypes.AnalysisMemoryLimit) (req: MlUpdateJobRequest) =
            { req with AnalysisLimits = Some value }
        let withBackgroundPersistInterval (value: CoreTypes.Duration) (req: MlUpdateJobRequest) =
            { req with BackgroundPersistInterval = Some value }
        let withCustomSettings (value: Map<string, System.Text.Json.JsonElement>) (req: MlUpdateJobRequest) =
            { req with CustomSettings = Some value }
        let withCategorizationFilters (value: string list) (req: MlUpdateJobRequest) =
            { req with CategorizationFilters = Some value }
        let withDescription (value: string) (req: MlUpdateJobRequest) =
            { req with Description = Some value }
        let withModelPlotConfig (value: MlTypes.ModelPlotConfig) (req: MlUpdateJobRequest) =
            { req with ModelPlotConfig = Some value }
        let withModelPruneWindow (value: CoreTypes.Duration) (req: MlUpdateJobRequest) =
            { req with ModelPruneWindow = Some value }
        let withDailyModelSnapshotRetentionAfterDays (value: CoreTypes.Long) (req: MlUpdateJobRequest) =
            { req with DailyModelSnapshotRetentionAfterDays = Some value }
        let withModelSnapshotRetentionDays (value: CoreTypes.Long) (req: MlUpdateJobRequest) =
            { req with ModelSnapshotRetentionDays = Some value }
        let withRenormalizationWindowDays (value: CoreTypes.Long) (req: MlUpdateJobRequest) =
            { req with RenormalizationWindowDays = Some value }
        let withResultsRetentionDays (value: CoreTypes.Long) (req: MlUpdateJobRequest) =
            { req with ResultsRetentionDays = Some value }
        let withGroups (value: string list) (req: MlUpdateJobRequest) =
            { req with Groups = Some value }
        let withDetectors (value: MlTypes.DetectorUpdate list) (req: MlUpdateJobRequest) =
            { req with Detectors = Some value }
        let withPerPartitionCategorization (value: MlTypes.PerPartitionCategorization) (req: MlUpdateJobRequest) =
            { req with PerPartitionCategorization = Some value }

    type MlUpdateModelSnapshotRequest = {
        JobId: CoreTypes.Id
        SnapshotId: CoreTypes.Id
        Description: string option
        Retain: bool option
    }

        with
        static member ToRequest(req: MlUpdateModelSnapshotRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{req.JobId}/model_snapshots/{req.SnapshotId}/_update"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type MlUpdateModelSnapshotResponse = System.Text.Json.JsonElement

    type MlUpdateModelSnapshotRequestBuilder() =
        member _.Yield(_: unit) : MlUpdateModelSnapshotRequest =
            {
                JobId = Unchecked.defaultof<_>
                SnapshotId = Unchecked.defaultof<_>
                Description = None
                Retain = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlUpdateModelSnapshotRequest, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("snapshotId")>]
        member _.SnapshotId(state: MlUpdateModelSnapshotRequest, value: CoreTypes.Id) =
            { state with SnapshotId = value }

        [<CustomOperation("description")>]
        member _.Description(state: MlUpdateModelSnapshotRequest, value: string) =
            { state with Description = Some value }

        [<CustomOperation("retain")>]
        member _.Retain(state: MlUpdateModelSnapshotRequest, value: bool) =
            { state with Retain = Some value }

    let mlUpdateModelSnapshotRequest = MlUpdateModelSnapshotRequestBuilder()

    module UpdateModelSnapshot =
        let withDescription (value: string) (req: MlUpdateModelSnapshotRequest) =
            { req with Description = Some value }
        let withRetain (value: bool) (req: MlUpdateModelSnapshotRequest) =
            { req with Retain = Some value }

    type MlUpdateTrainedModelDeploymentRequest = {
        ModelId: CoreTypes.Id
        NumberOfAllocations: CoreTypes.Integer option
        NumberOfAllocations: CoreTypes.Integer option
        AdaptiveAllocations: MlTypes.AdaptiveAllocationsSettings option
    }

        with
        static member ToRequest(req: MlUpdateTrainedModelDeploymentRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{req.ModelId}/deployment/_update"
                let queryParams =
                    [
                        req.NumberOfAllocations |> Option.map (fun v -> "number_of_allocations", Fes.Http.toQueryValue v)
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

    type MlUpdateTrainedModelDeploymentResponse = System.Text.Json.JsonElement

    type MlUpdateTrainedModelDeploymentRequestBuilder() =
        member _.Yield(_: unit) : MlUpdateTrainedModelDeploymentRequest =
            {
                ModelId = Unchecked.defaultof<_>
                NumberOfAllocations = None
                NumberOfAllocations = None
                AdaptiveAllocations = None
            }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: MlUpdateTrainedModelDeploymentRequest, value: CoreTypes.Id) =
            { state with ModelId = value }

        [<CustomOperation("numberOfAllocations")>]
        member _.NumberOfAllocations(state: MlUpdateTrainedModelDeploymentRequest, value: CoreTypes.Integer) =
            { state with NumberOfAllocations = Some value }

        [<CustomOperation("numberOfAllocations")>]
        member _.NumberOfAllocations(state: MlUpdateTrainedModelDeploymentRequest, value: CoreTypes.Integer) =
            { state with NumberOfAllocations = Some value }

        [<CustomOperation("adaptiveAllocations")>]
        member _.AdaptiveAllocations(state: MlUpdateTrainedModelDeploymentRequest, value: MlTypes.AdaptiveAllocationsSettings) =
            { state with AdaptiveAllocations = Some value }

    let mlUpdateTrainedModelDeploymentRequest = MlUpdateTrainedModelDeploymentRequestBuilder()

    module UpdateTrainedModelDeployment =
        let withNumberOfAllocations (value: CoreTypes.Integer) (req: MlUpdateTrainedModelDeploymentRequest) =
            { req with NumberOfAllocations = Some value }
        let withNumberOfAllocations (value: CoreTypes.Integer) (req: MlUpdateTrainedModelDeploymentRequest) =
            { req with NumberOfAllocations = Some value }
        let withAdaptiveAllocations (value: MlTypes.AdaptiveAllocationsSettings) (req: MlUpdateTrainedModelDeploymentRequest) =
            { req with AdaptiveAllocations = Some value }

    type MlUpgradeJobSnapshotRequest = {
        JobId: CoreTypes.Id
        SnapshotId: CoreTypes.Id
        WaitForCompletion: bool option
        Timeout: CoreTypes.Duration option
    }

        with
        static member ToRequest(req: MlUpgradeJobSnapshotRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{req.JobId}/model_snapshots/{req.SnapshotId}/_upgrade"
                let queryParams =
                    [
                        req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
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

    type MlUpgradeJobSnapshotResponse = System.Text.Json.JsonElement

    type MlUpgradeJobSnapshotRequestBuilder() =
        member _.Yield(_: unit) : MlUpgradeJobSnapshotRequest =
            {
                JobId = Unchecked.defaultof<_>
                SnapshotId = Unchecked.defaultof<_>
                WaitForCompletion = None
                Timeout = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlUpgradeJobSnapshotRequest, value: CoreTypes.Id) =
            { state with JobId = value }

        [<CustomOperation("snapshotId")>]
        member _.SnapshotId(state: MlUpgradeJobSnapshotRequest, value: CoreTypes.Id) =
            { state with SnapshotId = value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: MlUpgradeJobSnapshotRequest, value: bool) =
            { state with WaitForCompletion = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlUpgradeJobSnapshotRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

    let mlUpgradeJobSnapshotRequest = MlUpgradeJobSnapshotRequestBuilder()

    module UpgradeJobSnapshot =
        let withWaitForCompletion (value: bool) (req: MlUpgradeJobSnapshotRequest) =
            { req with WaitForCompletion = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: MlUpgradeJobSnapshotRequest) =
            { req with Timeout = Some value }

    type MlValidateRequest = {
        JobId: CoreTypes.Id option
        AnalysisConfig: MlTypes.AnalysisConfig option
        AnalysisLimits: MlTypes.AnalysisLimits option
        DataDescription: MlTypes.DataDescription option
        Description: string option
        ModelPlot: MlTypes.ModelPlotConfig option
        ModelSnapshotId: CoreTypes.Id option
        ModelSnapshotRetentionDays: CoreTypes.Long option
        ResultsIndexName: CoreTypes.IndexName option
    }

        with
        static member ToRequest(req: MlValidateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/_validate"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type MlValidateResponse = CoreTypes.AcknowledgedResponseBase

    type MlValidateRequestBuilder() =
        member _.Yield(_: unit) : MlValidateRequest =
            {
                JobId = None
                AnalysisConfig = None
                AnalysisLimits = None
                DataDescription = None
                Description = None
                ModelPlot = None
                ModelSnapshotId = None
                ModelSnapshotRetentionDays = None
                ResultsIndexName = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlValidateRequest, value: CoreTypes.Id) =
            { state with JobId = Some value }

        [<CustomOperation("analysisConfig")>]
        member _.AnalysisConfig(state: MlValidateRequest, value: MlTypes.AnalysisConfig) =
            { state with AnalysisConfig = Some value }

        [<CustomOperation("analysisLimits")>]
        member _.AnalysisLimits(state: MlValidateRequest, value: MlTypes.AnalysisLimits) =
            { state with AnalysisLimits = Some value }

        [<CustomOperation("dataDescription")>]
        member _.DataDescription(state: MlValidateRequest, value: MlTypes.DataDescription) =
            { state with DataDescription = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: MlValidateRequest, value: string) =
            { state with Description = Some value }

        [<CustomOperation("modelPlot")>]
        member _.ModelPlot(state: MlValidateRequest, value: MlTypes.ModelPlotConfig) =
            { state with ModelPlot = Some value }

        [<CustomOperation("modelSnapshotId")>]
        member _.ModelSnapshotId(state: MlValidateRequest, value: CoreTypes.Id) =
            { state with ModelSnapshotId = Some value }

        [<CustomOperation("modelSnapshotRetentionDays")>]
        member _.ModelSnapshotRetentionDays(state: MlValidateRequest, value: CoreTypes.Long) =
            { state with ModelSnapshotRetentionDays = Some value }

        [<CustomOperation("resultsIndexName")>]
        member _.ResultsIndexName(state: MlValidateRequest, value: CoreTypes.IndexName) =
            { state with ResultsIndexName = Some value }

    let mlValidateRequest = MlValidateRequestBuilder()

    module Validate =
        let withJobId (value: CoreTypes.Id) (req: MlValidateRequest) =
            { req with JobId = Some value }
        let withAnalysisConfig (value: MlTypes.AnalysisConfig) (req: MlValidateRequest) =
            { req with AnalysisConfig = Some value }
        let withAnalysisLimits (value: MlTypes.AnalysisLimits) (req: MlValidateRequest) =
            { req with AnalysisLimits = Some value }
        let withDataDescription (value: MlTypes.DataDescription) (req: MlValidateRequest) =
            { req with DataDescription = Some value }
        let withDescription (value: string) (req: MlValidateRequest) =
            { req with Description = Some value }
        let withModelPlot (value: MlTypes.ModelPlotConfig) (req: MlValidateRequest) =
            { req with ModelPlot = Some value }
        let withModelSnapshotId (value: CoreTypes.Id) (req: MlValidateRequest) =
            { req with ModelSnapshotId = Some value }
        let withModelSnapshotRetentionDays (value: CoreTypes.Long) (req: MlValidateRequest) =
            { req with ModelSnapshotRetentionDays = Some value }
        let withResultsIndexName (value: CoreTypes.IndexName) (req: MlValidateRequest) =
            { req with ResultsIndexName = Some value }

    type MlValidateDetectorRequest = {
        Document: obj
    }

        with
        static member ToRequest(req: MlValidateDetectorRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/_validate/detector"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type MlValidateDetectorResponse = CoreTypes.AcknowledgedResponseBase

    type MlValidateDetectorRequestBuilder() =
        member _.Yield(_: unit) : MlValidateDetectorRequest =
            {
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("document")>]
        member _.Document(state: MlValidateDetectorRequest, value) =
            { state with Document = value }

    let mlValidateDetectorRequest = MlValidateDetectorRequestBuilder()


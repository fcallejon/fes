// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module MlOperations =

    type MlClearTrainedModelDeploymentCacheRequest = {
        ModelId: Types.Id
    }

        with
        static member ToEndpoint(req: MlClearTrainedModelDeploymentCacheRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/trained_models/{Fes.Http.toPathSegment req.ModelId}/deployment/cache/_clear"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            endpoint, ValueNone

    type MlClearTrainedModelDeploymentCacheResponse = System.Text.Json.JsonElement

    type MlClearTrainedModelDeploymentCacheRequestBuilder() =
        member _.Yield(_: unit) : MlClearTrainedModelDeploymentCacheRequest =
            {
                ModelId = Unchecked.defaultof<_>
            }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: MlClearTrainedModelDeploymentCacheRequest, value: Types.Id) =
            { state with ModelId = value }

    let mlClearTrainedModelDeploymentCacheRequest = MlClearTrainedModelDeploymentCacheRequestBuilder()

    type MlCloseJobRequest = {
        JobId: Types.Id
        AllowNoMatch: bool option
        Force: bool option
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_no_match")>]
        bodyAllowNoMatch: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("force")>]
        bodyForce: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("timeout")>]
        bodyTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: MlCloseJobRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/{Fes.Http.toPathSegment req.JobId}/_close"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type MlCloseJobResponse = System.Text.Json.JsonElement

    type MlCloseJobRequestBuilder() =
        member _.Yield(_: unit) : MlCloseJobRequest =
            {
                JobId = Unchecked.defaultof<_>
                AllowNoMatch = None
                Force = None
                Timeout = None
                bodyAllowNoMatch = None
                bodyForce = None
                bodyTimeout = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlCloseJobRequest, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlCloseJobRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("force")>]
        member _.Force(state: MlCloseJobRequest, value: bool) =
            { state with Force = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlCloseJobRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("bodyAllowNoMatch")>]
        member _.BodyAllowNoMatch(state: MlCloseJobRequest, value: bool) =
            { state with bodyAllowNoMatch = Some value }

        [<CustomOperation("bodyForce")>]
        member _.BodyForce(state: MlCloseJobRequest, value: bool) =
            { state with bodyForce = Some value }

        [<CustomOperation("bodyTimeout")>]
        member _.BodyTimeout(state: MlCloseJobRequest, value: Types.Duration) =
            { state with bodyTimeout = Some value }

    let mlCloseJobRequest = MlCloseJobRequestBuilder()

    module CloseJob =
        let withAllowNoMatch (value: bool) (req: MlCloseJobRequest) =
            { req with AllowNoMatch = Some value }
        let withForce (value: bool) (req: MlCloseJobRequest) =
            { req with Force = Some value }
        let withTimeout (value: Types.Duration) (req: MlCloseJobRequest) =
            { req with Timeout = Some value }
        let withBodyAllowNoMatch (value: bool) (req: MlCloseJobRequest) =
            { req with bodyAllowNoMatch = Some value }
        let withBodyForce (value: bool) (req: MlCloseJobRequest) =
            { req with bodyForce = Some value }
        let withBodyTimeout (value: Types.Duration) (req: MlCloseJobRequest) =
            { req with bodyTimeout = Some value }

    type MlDeleteCalendarRequest = {
        CalendarId: Types.Id
    }

        with
        static member ToEndpoint(req: MlDeleteCalendarRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/calendars/{Fes.Http.toPathSegment req.CalendarId}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type MlDeleteCalendarResponse = Types.AcknowledgedResponseBase

    type MlDeleteCalendarRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteCalendarRequest =
            {
                CalendarId = Unchecked.defaultof<_>
            }

        [<CustomOperation("calendarId")>]
        member _.CalendarId(state: MlDeleteCalendarRequest, value: Types.Id) =
            { state with CalendarId = value }

    let mlDeleteCalendarRequest = MlDeleteCalendarRequestBuilder()

    type MlDeleteCalendarEventRequest = {
        CalendarId: Types.Id
        EventId: Types.Id
    }

        with
        static member ToEndpoint(req: MlDeleteCalendarEventRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/calendars/{Fes.Http.toPathSegment req.CalendarId}/events/{Fes.Http.toPathSegment req.EventId}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type MlDeleteCalendarEventResponse = Types.AcknowledgedResponseBase

    type MlDeleteCalendarEventRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteCalendarEventRequest =
            {
                CalendarId = Unchecked.defaultof<_>
                EventId = Unchecked.defaultof<_>
            }

        [<CustomOperation("calendarId")>]
        member _.CalendarId(state: MlDeleteCalendarEventRequest, value: Types.Id) =
            { state with CalendarId = value }

        [<CustomOperation("eventId")>]
        member _.EventId(state: MlDeleteCalendarEventRequest, value: Types.Id) =
            { state with EventId = value }

    let mlDeleteCalendarEventRequest = MlDeleteCalendarEventRequestBuilder()

    type MlDeleteCalendarJobRequest = {
        CalendarId: Types.Id
        JobId: Types.Ids
    }

        with
        static member ToEndpoint(req: MlDeleteCalendarJobRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/calendars/{Fes.Http.toPathSegment req.CalendarId}/jobs/{Fes.Http.toPathSegment req.JobId}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type MlDeleteCalendarJobResponse = System.Text.Json.JsonElement

    type MlDeleteCalendarJobRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteCalendarJobRequest =
            {
                CalendarId = Unchecked.defaultof<_>
                JobId = Unchecked.defaultof<_>
            }

        [<CustomOperation("calendarId")>]
        member _.CalendarId(state: MlDeleteCalendarJobRequest, value: Types.Id) =
            { state with CalendarId = value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlDeleteCalendarJobRequest, value: Types.Ids) =
            { state with JobId = value }

    let mlDeleteCalendarJobRequest = MlDeleteCalendarJobRequestBuilder()

    type MlDeleteDataFrameAnalyticsRequest = {
        Id: Types.Id
        Force: bool option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: MlDeleteDataFrameAnalyticsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/data_frame/analytics/{Fes.Http.toPathSegment req.Id}"
            let queryParams =
                [
                    req.Force |> Option.map (fun v -> "force", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type MlDeleteDataFrameAnalyticsResponse = Types.AcknowledgedResponseBase

    type MlDeleteDataFrameAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteDataFrameAnalyticsRequest =
            {
                Id = Unchecked.defaultof<_>
                Force = None
                Timeout = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: MlDeleteDataFrameAnalyticsRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("force")>]
        member _.Force(state: MlDeleteDataFrameAnalyticsRequest, value: bool) =
            { state with Force = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlDeleteDataFrameAnalyticsRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let mlDeleteDataFrameAnalyticsRequest = MlDeleteDataFrameAnalyticsRequestBuilder()

    module DeleteDataFrameAnalytics =
        let withForce (value: bool) (req: MlDeleteDataFrameAnalyticsRequest) =
            { req with Force = Some value }
        let withTimeout (value: Types.Duration) (req: MlDeleteDataFrameAnalyticsRequest) =
            { req with Timeout = Some value }

    type MlDeleteDatafeedRequest = {
        DatafeedId: Types.Id
        Force: bool option
    }

        with
        static member ToEndpoint(req: MlDeleteDatafeedRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/datafeeds/{Fes.Http.toPathSegment req.DatafeedId}"
            let queryParams =
                [
                    req.Force |> Option.map (fun v -> "force", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type MlDeleteDatafeedResponse = Types.AcknowledgedResponseBase

    type MlDeleteDatafeedRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteDatafeedRequest =
            {
                DatafeedId = Unchecked.defaultof<_>
                Force = None
            }

        [<CustomOperation("datafeedId")>]
        member _.DatafeedId(state: MlDeleteDatafeedRequest, value: Types.Id) =
            { state with DatafeedId = value }

        [<CustomOperation("force")>]
        member _.Force(state: MlDeleteDatafeedRequest, value: bool) =
            { state with Force = Some value }

    let mlDeleteDatafeedRequest = MlDeleteDatafeedRequestBuilder()

    module DeleteDatafeed =
        let withForce (value: bool) (req: MlDeleteDatafeedRequest) =
            { req with Force = Some value }

    type MlDeleteExpiredDataRequest = {
        JobId: Types.Id
        RequestsPerSecond: Types.Float option
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("requests_per_second")>]
        bodyRequestsPerSecond: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("timeout")>]
        bodyTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: MlDeleteExpiredDataRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/_delete_expired_data/{Fes.Http.toPathSegment req.JobId}"
            let queryParams =
                [
                    req.RequestsPerSecond |> Option.map (fun v -> "requests_per_second", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type MlDeleteExpiredDataResponse = System.Text.Json.JsonElement

    type MlDeleteExpiredDataRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteExpiredDataRequest =
            {
                JobId = Unchecked.defaultof<_>
                RequestsPerSecond = None
                Timeout = None
                bodyRequestsPerSecond = None
                bodyTimeout = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlDeleteExpiredDataRequest, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("requestsPerSecond")>]
        member _.RequestsPerSecond(state: MlDeleteExpiredDataRequest, value: Types.Float) =
            { state with RequestsPerSecond = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlDeleteExpiredDataRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("bodyRequestsPerSecond")>]
        member _.BodyRequestsPerSecond(state: MlDeleteExpiredDataRequest, value: Types.Float) =
            { state with bodyRequestsPerSecond = Some value }

        [<CustomOperation("bodyTimeout")>]
        member _.BodyTimeout(state: MlDeleteExpiredDataRequest, value: Types.Duration) =
            { state with bodyTimeout = Some value }

    let mlDeleteExpiredDataRequest = MlDeleteExpiredDataRequestBuilder()

    module DeleteExpiredData =
        let withRequestsPerSecond (value: Types.Float) (req: MlDeleteExpiredDataRequest) =
            { req with RequestsPerSecond = Some value }
        let withTimeout (value: Types.Duration) (req: MlDeleteExpiredDataRequest) =
            { req with Timeout = Some value }
        let withBodyRequestsPerSecond (value: Types.Float) (req: MlDeleteExpiredDataRequest) =
            { req with bodyRequestsPerSecond = Some value }
        let withBodyTimeout (value: Types.Duration) (req: MlDeleteExpiredDataRequest) =
            { req with bodyTimeout = Some value }

    type MlDeleteFilterRequest = {
        FilterId: Types.Id
    }

        with
        static member ToEndpoint(req: MlDeleteFilterRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/filters/{Fes.Http.toPathSegment req.FilterId}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type MlDeleteFilterResponse = Types.AcknowledgedResponseBase

    type MlDeleteFilterRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteFilterRequest =
            {
                FilterId = Unchecked.defaultof<_>
            }

        [<CustomOperation("filterId")>]
        member _.FilterId(state: MlDeleteFilterRequest, value: Types.Id) =
            { state with FilterId = value }

    let mlDeleteFilterRequest = MlDeleteFilterRequestBuilder()

    type MlDeleteForecastRequest = {
        JobId: Types.Id
        ForecastId: Types.Id
        AllowNoForecasts: bool option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: MlDeleteForecastRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/{Fes.Http.toPathSegment req.JobId}/_forecast/{Fes.Http.toPathSegment req.ForecastId}"
            let queryParams =
                [
                    req.AllowNoForecasts |> Option.map (fun v -> "allow_no_forecasts", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type MlDeleteForecastResponse = Types.AcknowledgedResponseBase

    type MlDeleteForecastRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteForecastRequest =
            {
                JobId = Unchecked.defaultof<_>
                ForecastId = Unchecked.defaultof<_>
                AllowNoForecasts = None
                Timeout = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlDeleteForecastRequest, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("forecastId")>]
        member _.ForecastId(state: MlDeleteForecastRequest, value: Types.Id) =
            { state with ForecastId = value }

        [<CustomOperation("allowNoForecasts")>]
        member _.AllowNoForecasts(state: MlDeleteForecastRequest, value: bool) =
            { state with AllowNoForecasts = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlDeleteForecastRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let mlDeleteForecastRequest = MlDeleteForecastRequestBuilder()

    module DeleteForecast =
        let withAllowNoForecasts (value: bool) (req: MlDeleteForecastRequest) =
            { req with AllowNoForecasts = Some value }
        let withTimeout (value: Types.Duration) (req: MlDeleteForecastRequest) =
            { req with Timeout = Some value }

    type MlDeleteJobRequest = {
        JobId: Types.Id
        Force: bool option
        DeleteUserAnnotations: bool option
        WaitForCompletion: bool option
    }

        with
        static member ToEndpoint(req: MlDeleteJobRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/{Fes.Http.toPathSegment req.JobId}"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type MlDeleteJobResponse = Types.AcknowledgedResponseBase

    type MlDeleteJobRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteJobRequest =
            {
                JobId = Unchecked.defaultof<_>
                Force = None
                DeleteUserAnnotations = None
                WaitForCompletion = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlDeleteJobRequest, value: Types.Id) =
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
        JobId: Types.Id
        SnapshotId: Types.Id
    }

        with
        static member ToEndpoint(req: MlDeleteModelSnapshotRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/{Fes.Http.toPathSegment req.JobId}/model_snapshots/{Fes.Http.toPathSegment req.SnapshotId}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type MlDeleteModelSnapshotResponse = Types.AcknowledgedResponseBase

    type MlDeleteModelSnapshotRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteModelSnapshotRequest =
            {
                JobId = Unchecked.defaultof<_>
                SnapshotId = Unchecked.defaultof<_>
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlDeleteModelSnapshotRequest, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("snapshotId")>]
        member _.SnapshotId(state: MlDeleteModelSnapshotRequest, value: Types.Id) =
            { state with SnapshotId = value }

    let mlDeleteModelSnapshotRequest = MlDeleteModelSnapshotRequestBuilder()

    type MlDeleteTrainedModelRequest = {
        ModelId: Types.Id
        Force: bool option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: MlDeleteTrainedModelRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/trained_models/{Fes.Http.toPathSegment req.ModelId}"
            let queryParams =
                [
                    req.Force |> Option.map (fun v -> "force", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type MlDeleteTrainedModelResponse = Types.AcknowledgedResponseBase

    type MlDeleteTrainedModelRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteTrainedModelRequest =
            {
                ModelId = Unchecked.defaultof<_>
                Force = None
                Timeout = None
            }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: MlDeleteTrainedModelRequest, value: Types.Id) =
            { state with ModelId = value }

        [<CustomOperation("force")>]
        member _.Force(state: MlDeleteTrainedModelRequest, value: bool) =
            { state with Force = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlDeleteTrainedModelRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let mlDeleteTrainedModelRequest = MlDeleteTrainedModelRequestBuilder()

    module DeleteTrainedModel =
        let withForce (value: bool) (req: MlDeleteTrainedModelRequest) =
            { req with Force = Some value }
        let withTimeout (value: Types.Duration) (req: MlDeleteTrainedModelRequest) =
            { req with Timeout = Some value }

    type MlDeleteTrainedModelAliasRequest = {
        ModelAlias: Types.Name
        ModelId: Types.Id
    }

        with
        static member ToEndpoint(req: MlDeleteTrainedModelAliasRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/trained_models/{Fes.Http.toPathSegment req.ModelId}/model_aliases/{Fes.Http.toPathSegment req.ModelAlias}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type MlDeleteTrainedModelAliasResponse = Types.AcknowledgedResponseBase

    type MlDeleteTrainedModelAliasRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteTrainedModelAliasRequest =
            {
                ModelAlias = Unchecked.defaultof<_>
                ModelId = Unchecked.defaultof<_>
            }

        [<CustomOperation("modelAlias")>]
        member _.ModelAlias(state: MlDeleteTrainedModelAliasRequest, value: Types.Name) =
            { state with ModelAlias = value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: MlDeleteTrainedModelAliasRequest, value: Types.Id) =
            { state with ModelId = value }

    let mlDeleteTrainedModelAliasRequest = MlDeleteTrainedModelAliasRequestBuilder()

    type MlEstimateModelMemoryRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("analysis_config")>]
        AnalysisConfig: Types.AnalysisConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("max_bucket_cardinality")>]
        MaxBucketCardinality: Map<Types.Field, Types.Long> option
        [<System.Text.Json.Serialization.JsonPropertyName("overall_cardinality")>]
        OverallCardinality: Map<Types.Field, Types.Long> option
    }

        with
        static member ToEndpoint(req: MlEstimateModelMemoryRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/_estimate_model_memory"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type MlEstimateModelMemoryResponse = System.Text.Json.JsonElement

    type MlEstimateModelMemoryRequestBuilder() =
        member _.Yield(_: unit) : MlEstimateModelMemoryRequest =
            {
                AnalysisConfig = None
                MaxBucketCardinality = None
                OverallCardinality = None
            }

        [<CustomOperation("analysisConfig")>]
        member _.AnalysisConfig(state: MlEstimateModelMemoryRequest, value: Types.AnalysisConfig) =
            { state with AnalysisConfig = Some value }

        [<CustomOperation("maxBucketCardinality")>]
        member _.MaxBucketCardinality(state: MlEstimateModelMemoryRequest, value: Map<Types.Field, Types.Long>) =
            { state with MaxBucketCardinality = Some value }

        [<CustomOperation("overallCardinality")>]
        member _.OverallCardinality(state: MlEstimateModelMemoryRequest, value: Map<Types.Field, Types.Long>) =
            { state with OverallCardinality = Some value }

    let mlEstimateModelMemoryRequest = MlEstimateModelMemoryRequestBuilder()

    module EstimateModelMemory =
        let withAnalysisConfig (value: Types.AnalysisConfig) (req: MlEstimateModelMemoryRequest) =
            { req with AnalysisConfig = Some value }
        let withMaxBucketCardinality (value: Map<Types.Field, Types.Long>) (req: MlEstimateModelMemoryRequest) =
            { req with MaxBucketCardinality = Some value }
        let withOverallCardinality (value: Map<Types.Field, Types.Long>) (req: MlEstimateModelMemoryRequest) =
            { req with OverallCardinality = Some value }

    type MlEvaluateDataFrameRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("evaluation")>]
        Evaluation: Types.DataframeEvaluationContainer
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: Types.QueryContainer option
    }

        with
        static member ToEndpoint(req: MlEvaluateDataFrameRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/data_frame/_evaluate"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type MlEvaluateDataFrameResponse = System.Text.Json.JsonElement

    type MlEvaluateDataFrameRequestBuilder() =
        member _.Yield(_: unit) : MlEvaluateDataFrameRequest =
            {
                Evaluation = Unchecked.defaultof<_>
                Index = Unchecked.defaultof<_>
                Query = None
            }

        [<CustomOperation("evaluation")>]
        member _.Evaluation(state: MlEvaluateDataFrameRequest, value: Types.DataframeEvaluationContainer) =
            { state with Evaluation = value }

        [<CustomOperation("index")>]
        member _.Index(state: MlEvaluateDataFrameRequest, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("query")>]
        member _.Query(state: MlEvaluateDataFrameRequest, value: Types.QueryContainer) =
            { state with Query = Some value }

    let mlEvaluateDataFrameRequest = MlEvaluateDataFrameRequestBuilder()

    module EvaluateDataFrame =
        let withEvaluation (value: Types.DataframeEvaluationContainer) (req: MlEvaluateDataFrameRequest) =
            { req with Evaluation = value }
        let withIndex (value: Types.IndexName) (req: MlEvaluateDataFrameRequest) =
            { req with Index = value }
        let withQuery (value: Types.QueryContainer) (req: MlEvaluateDataFrameRequest) =
            { req with Query = Some value }

    type MlExplainDataFrameAnalyticsRequest = {
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: Types.DataframeAnalyticsSource option
        [<System.Text.Json.Serialization.JsonPropertyName("dest")>]
        Dest: Types.DataframeAnalyticsDestination option
        [<System.Text.Json.Serialization.JsonPropertyName("analysis")>]
        Analysis: Types.DataframeAnalysisContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model_memory_limit")>]
        ModelMemoryLimit: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_num_threads")>]
        MaxNumThreads: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("analyzed_fields")>]
        AnalyzedFields: Types.DataframeAnalysisAnalyzedFields option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_lazy_start")>]
        AllowLazyStart: bool option
    }

        with
        static member ToEndpoint(req: MlExplainDataFrameAnalyticsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/data_frame/analytics/{Fes.Http.toPathSegment req.Id}/_explain"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.Id(state: MlExplainDataFrameAnalyticsRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("source")>]
        member _.Source(state: MlExplainDataFrameAnalyticsRequest, value: Types.DataframeAnalyticsSource) =
            { state with Source = Some value }

        [<CustomOperation("dest")>]
        member _.Dest(state: MlExplainDataFrameAnalyticsRequest, value: Types.DataframeAnalyticsDestination) =
            { state with Dest = Some value }

        [<CustomOperation("analysis")>]
        member _.Analysis(state: MlExplainDataFrameAnalyticsRequest, value: Types.DataframeAnalysisContainer) =
            { state with Analysis = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: MlExplainDataFrameAnalyticsRequest, value: string) =
            { state with Description = Some value }

        [<CustomOperation("modelMemoryLimit")>]
        member _.ModelMemoryLimit(state: MlExplainDataFrameAnalyticsRequest, value: string) =
            { state with ModelMemoryLimit = Some value }

        [<CustomOperation("maxNumThreads")>]
        member _.MaxNumThreads(state: MlExplainDataFrameAnalyticsRequest, value: Types.Integer) =
            { state with MaxNumThreads = Some value }

        [<CustomOperation("analyzedFields")>]
        member _.AnalyzedFields(state: MlExplainDataFrameAnalyticsRequest, value: Types.DataframeAnalysisAnalyzedFields) =
            { state with AnalyzedFields = Some value }

        [<CustomOperation("allowLazyStart")>]
        member _.AllowLazyStart(state: MlExplainDataFrameAnalyticsRequest, value: bool) =
            { state with AllowLazyStart = Some value }

    let mlExplainDataFrameAnalyticsRequest = MlExplainDataFrameAnalyticsRequestBuilder()

    module ExplainDataFrameAnalytics =
        let withSource (value: Types.DataframeAnalyticsSource) (req: MlExplainDataFrameAnalyticsRequest) =
            { req with Source = Some value }
        let withDest (value: Types.DataframeAnalyticsDestination) (req: MlExplainDataFrameAnalyticsRequest) =
            { req with Dest = Some value }
        let withAnalysis (value: Types.DataframeAnalysisContainer) (req: MlExplainDataFrameAnalyticsRequest) =
            { req with Analysis = Some value }
        let withDescription (value: string) (req: MlExplainDataFrameAnalyticsRequest) =
            { req with Description = Some value }
        let withModelMemoryLimit (value: string) (req: MlExplainDataFrameAnalyticsRequest) =
            { req with ModelMemoryLimit = Some value }
        let withMaxNumThreads (value: Types.Integer) (req: MlExplainDataFrameAnalyticsRequest) =
            { req with MaxNumThreads = Some value }
        let withAnalyzedFields (value: Types.DataframeAnalysisAnalyzedFields) (req: MlExplainDataFrameAnalyticsRequest) =
            { req with AnalyzedFields = Some value }
        let withAllowLazyStart (value: bool) (req: MlExplainDataFrameAnalyticsRequest) =
            { req with AllowLazyStart = Some value }

    type MlFlushJobRequest = {
        JobId: Types.Id
        AdvanceTime: Types.DateTime option
        CalcInterim: bool option
        End: Types.DateTime option
        SkipTime: Types.DateTime option
        Start: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("advance_time")>]
        bodyAdvanceTime: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("calc_interim")>]
        bodyCalcInterim: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("end")>]
        bodyEnd: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("skip_time")>]
        bodySkipTime: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("start")>]
        bodyStart: Types.DateTime option
    }

        with
        static member ToEndpoint(req: MlFlushJobRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/{Fes.Http.toPathSegment req.JobId}/_flush"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
                bodyAdvanceTime = None
                bodyCalcInterim = None
                bodyEnd = None
                bodySkipTime = None
                bodyStart = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlFlushJobRequest, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("advanceTime")>]
        member _.AdvanceTime(state: MlFlushJobRequest, value: Types.DateTime) =
            { state with AdvanceTime = Some value }

        [<CustomOperation("calcInterim")>]
        member _.CalcInterim(state: MlFlushJobRequest, value: bool) =
            { state with CalcInterim = Some value }

        [<CustomOperation("end'")>]
        member _.End(state: MlFlushJobRequest, value: Types.DateTime) =
            { state with End = Some value }

        [<CustomOperation("skipTime")>]
        member _.SkipTime(state: MlFlushJobRequest, value: Types.DateTime) =
            { state with SkipTime = Some value }

        [<CustomOperation("start")>]
        member _.Start(state: MlFlushJobRequest, value: Types.DateTime) =
            { state with Start = Some value }

        [<CustomOperation("bodyAdvanceTime")>]
        member _.BodyAdvanceTime(state: MlFlushJobRequest, value: Types.DateTime) =
            { state with bodyAdvanceTime = Some value }

        [<CustomOperation("bodyCalcInterim")>]
        member _.BodyCalcInterim(state: MlFlushJobRequest, value: bool) =
            { state with bodyCalcInterim = Some value }

        [<CustomOperation("bodyEnd")>]
        member _.BodyEnd(state: MlFlushJobRequest, value: Types.DateTime) =
            { state with bodyEnd = Some value }

        [<CustomOperation("bodySkipTime")>]
        member _.BodySkipTime(state: MlFlushJobRequest, value: Types.DateTime) =
            { state with bodySkipTime = Some value }

        [<CustomOperation("bodyStart")>]
        member _.BodyStart(state: MlFlushJobRequest, value: Types.DateTime) =
            { state with bodyStart = Some value }

    let mlFlushJobRequest = MlFlushJobRequestBuilder()

    module FlushJob =
        let withAdvanceTime (value: Types.DateTime) (req: MlFlushJobRequest) =
            { req with AdvanceTime = Some value }
        let withCalcInterim (value: bool) (req: MlFlushJobRequest) =
            { req with CalcInterim = Some value }
        let withEnd (value: Types.DateTime) (req: MlFlushJobRequest) =
            { req with End = Some value }
        let withSkipTime (value: Types.DateTime) (req: MlFlushJobRequest) =
            { req with SkipTime = Some value }
        let withStart (value: Types.DateTime) (req: MlFlushJobRequest) =
            { req with Start = Some value }
        let withBodyAdvanceTime (value: Types.DateTime) (req: MlFlushJobRequest) =
            { req with bodyAdvanceTime = Some value }
        let withBodyCalcInterim (value: bool) (req: MlFlushJobRequest) =
            { req with bodyCalcInterim = Some value }
        let withBodyEnd (value: Types.DateTime) (req: MlFlushJobRequest) =
            { req with bodyEnd = Some value }
        let withBodySkipTime (value: Types.DateTime) (req: MlFlushJobRequest) =
            { req with bodySkipTime = Some value }
        let withBodyStart (value: Types.DateTime) (req: MlFlushJobRequest) =
            { req with bodyStart = Some value }

    type MlForecastRequest = {
        JobId: Types.Id
        Duration: Types.Duration option
        ExpiresIn: Types.Duration option
        MaxModelMemory: string option
        [<System.Text.Json.Serialization.JsonPropertyName("duration")>]
        bodyDuration: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("expires_in")>]
        bodyExpiresIn: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("max_model_memory")>]
        bodyMaxModelMemory: string option
    }

        with
        static member ToEndpoint(req: MlForecastRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/{Fes.Http.toPathSegment req.JobId}/_forecast"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type MlForecastResponse = System.Text.Json.JsonElement

    type MlForecastRequestBuilder() =
        member _.Yield(_: unit) : MlForecastRequest =
            {
                JobId = Unchecked.defaultof<_>
                Duration = None
                ExpiresIn = None
                MaxModelMemory = None
                bodyDuration = None
                bodyExpiresIn = None
                bodyMaxModelMemory = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlForecastRequest, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("duration")>]
        member _.Duration(state: MlForecastRequest, value: Types.Duration) =
            { state with Duration = Some value }

        [<CustomOperation("expiresIn")>]
        member _.ExpiresIn(state: MlForecastRequest, value: Types.Duration) =
            { state with ExpiresIn = Some value }

        [<CustomOperation("maxModelMemory")>]
        member _.MaxModelMemory(state: MlForecastRequest, value: string) =
            { state with MaxModelMemory = Some value }

        [<CustomOperation("bodyDuration")>]
        member _.BodyDuration(state: MlForecastRequest, value: Types.Duration) =
            { state with bodyDuration = Some value }

        [<CustomOperation("bodyExpiresIn")>]
        member _.BodyExpiresIn(state: MlForecastRequest, value: Types.Duration) =
            { state with bodyExpiresIn = Some value }

        [<CustomOperation("bodyMaxModelMemory")>]
        member _.BodyMaxModelMemory(state: MlForecastRequest, value: string) =
            { state with bodyMaxModelMemory = Some value }

    let mlForecastRequest = MlForecastRequestBuilder()

    module Forecast =
        let withDuration (value: Types.Duration) (req: MlForecastRequest) =
            { req with Duration = Some value }
        let withExpiresIn (value: Types.Duration) (req: MlForecastRequest) =
            { req with ExpiresIn = Some value }
        let withMaxModelMemory (value: string) (req: MlForecastRequest) =
            { req with MaxModelMemory = Some value }
        let withBodyDuration (value: Types.Duration) (req: MlForecastRequest) =
            { req with bodyDuration = Some value }
        let withBodyExpiresIn (value: Types.Duration) (req: MlForecastRequest) =
            { req with bodyExpiresIn = Some value }
        let withBodyMaxModelMemory (value: string) (req: MlForecastRequest) =
            { req with bodyMaxModelMemory = Some value }

    type MlGetBucketsRequest = {
        JobId: Types.Id
        Timestamp: Types.DateTime
        AnomalyScore: Types.Double option
        Desc: bool option
        End: Types.DateTime option
        ExcludeInterim: bool option
        Expand: bool option
        From: Types.Integer option
        Size: Types.Integer option
        Sort: Types.Field option
        Start: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("anomaly_score")>]
        bodyAnomalyScore: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("desc")>]
        bodyDesc: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("end")>]
        bodyEnd: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("exclude_interim")>]
        bodyExcludeInterim: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("expand")>]
        bodyExpand: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("page")>]
        Page: Types.Page option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        bodySort: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("start")>]
        bodyStart: Types.DateTime option
    }

        with
        static member ToEndpoint(req: MlGetBucketsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/{Fes.Http.toPathSegment req.JobId}/results/buckets/{Fes.Http.toPathSegment req.Timestamp}"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
                bodyAnomalyScore = None
                bodyDesc = None
                bodyEnd = None
                bodyExcludeInterim = None
                bodyExpand = None
                Page = None
                bodySort = None
                bodyStart = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlGetBucketsRequest, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: MlGetBucketsRequest, value: Types.DateTime) =
            { state with Timestamp = value }

        [<CustomOperation("anomalyScore")>]
        member _.AnomalyScore(state: MlGetBucketsRequest, value: Types.Double) =
            { state with AnomalyScore = Some value }

        [<CustomOperation("desc")>]
        member _.Desc(state: MlGetBucketsRequest, value: bool) =
            { state with Desc = Some value }

        [<CustomOperation("end'")>]
        member _.End(state: MlGetBucketsRequest, value: Types.DateTime) =
            { state with End = Some value }

        [<CustomOperation("excludeInterim")>]
        member _.ExcludeInterim(state: MlGetBucketsRequest, value: bool) =
            { state with ExcludeInterim = Some value }

        [<CustomOperation("expand")>]
        member _.Expand(state: MlGetBucketsRequest, value: bool) =
            { state with Expand = Some value }

        [<CustomOperation("from")>]
        member _.From(state: MlGetBucketsRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MlGetBucketsRequest, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: MlGetBucketsRequest, value: Types.Field) =
            { state with Sort = Some value }

        [<CustomOperation("start")>]
        member _.Start(state: MlGetBucketsRequest, value: Types.DateTime) =
            { state with Start = Some value }

        [<CustomOperation("bodyAnomalyScore")>]
        member _.BodyAnomalyScore(state: MlGetBucketsRequest, value: Types.Double) =
            { state with bodyAnomalyScore = Some value }

        [<CustomOperation("bodyDesc")>]
        member _.BodyDesc(state: MlGetBucketsRequest, value: bool) =
            { state with bodyDesc = Some value }

        [<CustomOperation("bodyEnd")>]
        member _.BodyEnd(state: MlGetBucketsRequest, value: Types.DateTime) =
            { state with bodyEnd = Some value }

        [<CustomOperation("bodyExcludeInterim")>]
        member _.BodyExcludeInterim(state: MlGetBucketsRequest, value: bool) =
            { state with bodyExcludeInterim = Some value }

        [<CustomOperation("bodyExpand")>]
        member _.BodyExpand(state: MlGetBucketsRequest, value: bool) =
            { state with bodyExpand = Some value }

        [<CustomOperation("page")>]
        member _.Page(state: MlGetBucketsRequest, value: Types.Page) =
            { state with Page = Some value }

        [<CustomOperation("bodySort")>]
        member _.BodySort(state: MlGetBucketsRequest, value: Types.Field) =
            { state with bodySort = Some value }

        [<CustomOperation("bodyStart")>]
        member _.BodyStart(state: MlGetBucketsRequest, value: Types.DateTime) =
            { state with bodyStart = Some value }

    let mlGetBucketsRequest = MlGetBucketsRequestBuilder()

    module GetBuckets =
        let withAnomalyScore (value: Types.Double) (req: MlGetBucketsRequest) =
            { req with AnomalyScore = Some value }
        let withDesc (value: bool) (req: MlGetBucketsRequest) =
            { req with Desc = Some value }
        let withEnd (value: Types.DateTime) (req: MlGetBucketsRequest) =
            { req with End = Some value }
        let withExcludeInterim (value: bool) (req: MlGetBucketsRequest) =
            { req with ExcludeInterim = Some value }
        let withExpand (value: bool) (req: MlGetBucketsRequest) =
            { req with Expand = Some value }
        let withFrom (value: Types.Integer) (req: MlGetBucketsRequest) =
            { req with From = Some value }
        let withSize (value: Types.Integer) (req: MlGetBucketsRequest) =
            { req with Size = Some value }
        let withSort (value: Types.Field) (req: MlGetBucketsRequest) =
            { req with Sort = Some value }
        let withStart (value: Types.DateTime) (req: MlGetBucketsRequest) =
            { req with Start = Some value }
        let withBodyAnomalyScore (value: Types.Double) (req: MlGetBucketsRequest) =
            { req with bodyAnomalyScore = Some value }
        let withBodyDesc (value: bool) (req: MlGetBucketsRequest) =
            { req with bodyDesc = Some value }
        let withBodyEnd (value: Types.DateTime) (req: MlGetBucketsRequest) =
            { req with bodyEnd = Some value }
        let withBodyExcludeInterim (value: bool) (req: MlGetBucketsRequest) =
            { req with bodyExcludeInterim = Some value }
        let withBodyExpand (value: bool) (req: MlGetBucketsRequest) =
            { req with bodyExpand = Some value }
        let withPage (value: Types.Page) (req: MlGetBucketsRequest) =
            { req with Page = Some value }
        let withBodySort (value: Types.Field) (req: MlGetBucketsRequest) =
            { req with bodySort = Some value }
        let withBodyStart (value: Types.DateTime) (req: MlGetBucketsRequest) =
            { req with bodyStart = Some value }

    type MlGetCalendarEventsRequest = {
        CalendarId: Types.Id
        End: Types.DateTime option
        From: Types.Integer option
        JobId: Types.Id option
        Size: Types.Integer option
        Start: Types.DateTime option
    }

        with
        static member ToEndpoint(req: MlGetCalendarEventsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/calendars/{Fes.Http.toPathSegment req.CalendarId}/events"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

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
        member _.CalendarId(state: MlGetCalendarEventsRequest, value: Types.Id) =
            { state with CalendarId = value }

        [<CustomOperation("end'")>]
        member _.End(state: MlGetCalendarEventsRequest, value: Types.DateTime) =
            { state with End = Some value }

        [<CustomOperation("from")>]
        member _.From(state: MlGetCalendarEventsRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlGetCalendarEventsRequest, value: Types.Id) =
            { state with JobId = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MlGetCalendarEventsRequest, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("start")>]
        member _.Start(state: MlGetCalendarEventsRequest, value: Types.DateTime) =
            { state with Start = Some value }

    let mlGetCalendarEventsRequest = MlGetCalendarEventsRequestBuilder()

    module GetCalendarEvents =
        let withEnd (value: Types.DateTime) (req: MlGetCalendarEventsRequest) =
            { req with End = Some value }
        let withFrom (value: Types.Integer) (req: MlGetCalendarEventsRequest) =
            { req with From = Some value }
        let withJobId (value: Types.Id) (req: MlGetCalendarEventsRequest) =
            { req with JobId = Some value }
        let withSize (value: Types.Integer) (req: MlGetCalendarEventsRequest) =
            { req with Size = Some value }
        let withStart (value: Types.DateTime) (req: MlGetCalendarEventsRequest) =
            { req with Start = Some value }

    type MlGetCalendarsRequest = {
        CalendarId: Types.Id
        From: Types.Integer option
        Size: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("page")>]
        Page: Types.Page option
    }

        with
        static member ToEndpoint(req: MlGetCalendarsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/calendars/{Fes.Http.toPathSegment req.CalendarId}"
            let queryParams =
                [
                    req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                    req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.CalendarId(state: MlGetCalendarsRequest, value: Types.Id) =
            { state with CalendarId = value }

        [<CustomOperation("from")>]
        member _.From(state: MlGetCalendarsRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MlGetCalendarsRequest, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("page")>]
        member _.Page(state: MlGetCalendarsRequest, value: Types.Page) =
            { state with Page = Some value }

    let mlGetCalendarsRequest = MlGetCalendarsRequestBuilder()

    module GetCalendars =
        let withFrom (value: Types.Integer) (req: MlGetCalendarsRequest) =
            { req with From = Some value }
        let withSize (value: Types.Integer) (req: MlGetCalendarsRequest) =
            { req with Size = Some value }
        let withPage (value: Types.Page) (req: MlGetCalendarsRequest) =
            { req with Page = Some value }

    type MlGetCategoriesRequest = {
        JobId: Types.Id
        CategoryId: Types.CategoryId
        From: Types.Integer option
        PartitionFieldValue: string option
        Size: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("page")>]
        Page: Types.Page option
    }

        with
        static member ToEndpoint(req: MlGetCategoriesRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/{Fes.Http.toPathSegment req.JobId}/results/categories/{Fes.Http.toPathSegment req.CategoryId}"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.JobId(state: MlGetCategoriesRequest, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("categoryId")>]
        member _.CategoryId(state: MlGetCategoriesRequest, value: Types.CategoryId) =
            { state with CategoryId = value }

        [<CustomOperation("from")>]
        member _.From(state: MlGetCategoriesRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("partitionFieldValue")>]
        member _.PartitionFieldValue(state: MlGetCategoriesRequest, value: string) =
            { state with PartitionFieldValue = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MlGetCategoriesRequest, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("page")>]
        member _.Page(state: MlGetCategoriesRequest, value: Types.Page) =
            { state with Page = Some value }

    let mlGetCategoriesRequest = MlGetCategoriesRequestBuilder()

    module GetCategories =
        let withFrom (value: Types.Integer) (req: MlGetCategoriesRequest) =
            { req with From = Some value }
        let withPartitionFieldValue (value: string) (req: MlGetCategoriesRequest) =
            { req with PartitionFieldValue = Some value }
        let withSize (value: Types.Integer) (req: MlGetCategoriesRequest) =
            { req with Size = Some value }
        let withPage (value: Types.Page) (req: MlGetCategoriesRequest) =
            { req with Page = Some value }

    type MlGetDataFrameAnalyticsRequest = {
        Id: Types.Id
        AllowNoMatch: bool option
        From: Types.Integer option
        Size: Types.Integer option
        ExcludeGenerated: bool option
    }

        with
        static member ToEndpoint(req: MlGetDataFrameAnalyticsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/data_frame/analytics/{Fes.Http.toPathSegment req.Id}"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

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
        member _.Id(state: MlGetDataFrameAnalyticsRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlGetDataFrameAnalyticsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("from")>]
        member _.From(state: MlGetDataFrameAnalyticsRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MlGetDataFrameAnalyticsRequest, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("excludeGenerated")>]
        member _.ExcludeGenerated(state: MlGetDataFrameAnalyticsRequest, value: bool) =
            { state with ExcludeGenerated = Some value }

    let mlGetDataFrameAnalyticsRequest = MlGetDataFrameAnalyticsRequestBuilder()

    module GetDataFrameAnalytics =
        let withAllowNoMatch (value: bool) (req: MlGetDataFrameAnalyticsRequest) =
            { req with AllowNoMatch = Some value }
        let withFrom (value: Types.Integer) (req: MlGetDataFrameAnalyticsRequest) =
            { req with From = Some value }
        let withSize (value: Types.Integer) (req: MlGetDataFrameAnalyticsRequest) =
            { req with Size = Some value }
        let withExcludeGenerated (value: bool) (req: MlGetDataFrameAnalyticsRequest) =
            { req with ExcludeGenerated = Some value }

    type MlGetDataFrameAnalyticsStatsRequest = {
        Id: Types.Id
        AllowNoMatch: bool option
        From: Types.Integer option
        Size: Types.Integer option
        Verbose: bool option
    }

        with
        static member ToEndpoint(req: MlGetDataFrameAnalyticsStatsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/data_frame/analytics/{Fes.Http.toPathSegment req.Id}/_stats"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

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
        member _.Id(state: MlGetDataFrameAnalyticsStatsRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlGetDataFrameAnalyticsStatsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("from")>]
        member _.From(state: MlGetDataFrameAnalyticsStatsRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MlGetDataFrameAnalyticsStatsRequest, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("verbose")>]
        member _.Verbose(state: MlGetDataFrameAnalyticsStatsRequest, value: bool) =
            { state with Verbose = Some value }

    let mlGetDataFrameAnalyticsStatsRequest = MlGetDataFrameAnalyticsStatsRequestBuilder()

    module GetDataFrameAnalyticsStats =
        let withAllowNoMatch (value: bool) (req: MlGetDataFrameAnalyticsStatsRequest) =
            { req with AllowNoMatch = Some value }
        let withFrom (value: Types.Integer) (req: MlGetDataFrameAnalyticsStatsRequest) =
            { req with From = Some value }
        let withSize (value: Types.Integer) (req: MlGetDataFrameAnalyticsStatsRequest) =
            { req with Size = Some value }
        let withVerbose (value: bool) (req: MlGetDataFrameAnalyticsStatsRequest) =
            { req with Verbose = Some value }

    type MlGetDatafeedStatsRequest = {
        DatafeedId: Types.Ids
        AllowNoMatch: bool option
    }

        with
        static member ToEndpoint(req: MlGetDatafeedStatsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/datafeeds/{Fes.Http.toPathSegment req.DatafeedId}/_stats"
            let queryParams =
                [
                    req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type MlGetDatafeedStatsResponse = System.Text.Json.JsonElement

    type MlGetDatafeedStatsRequestBuilder() =
        member _.Yield(_: unit) : MlGetDatafeedStatsRequest =
            {
                DatafeedId = Unchecked.defaultof<_>
                AllowNoMatch = None
            }

        [<CustomOperation("datafeedId")>]
        member _.DatafeedId(state: MlGetDatafeedStatsRequest, value: Types.Ids) =
            { state with DatafeedId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlGetDatafeedStatsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

    let mlGetDatafeedStatsRequest = MlGetDatafeedStatsRequestBuilder()

    module GetDatafeedStats =
        let withAllowNoMatch (value: bool) (req: MlGetDatafeedStatsRequest) =
            { req with AllowNoMatch = Some value }

    type MlGetDatafeedsRequest = {
        DatafeedId: Types.Ids
        AllowNoMatch: bool option
        ExcludeGenerated: bool option
    }

        with
        static member ToEndpoint(req: MlGetDatafeedsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/datafeeds/{Fes.Http.toPathSegment req.DatafeedId}"
            let queryParams =
                [
                    req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                    req.ExcludeGenerated |> Option.map (fun v -> "exclude_generated", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type MlGetDatafeedsResponse = System.Text.Json.JsonElement

    type MlGetDatafeedsRequestBuilder() =
        member _.Yield(_: unit) : MlGetDatafeedsRequest =
            {
                DatafeedId = Unchecked.defaultof<_>
                AllowNoMatch = None
                ExcludeGenerated = None
            }

        [<CustomOperation("datafeedId")>]
        member _.DatafeedId(state: MlGetDatafeedsRequest, value: Types.Ids) =
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
        FilterId: Types.Ids
        From: Types.Integer option
        Size: Types.Integer option
    }

        with
        static member ToEndpoint(req: MlGetFiltersRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/filters/{Fes.Http.toPathSegment req.FilterId}"
            let queryParams =
                [
                    req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                    req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type MlGetFiltersResponse = System.Text.Json.JsonElement

    type MlGetFiltersRequestBuilder() =
        member _.Yield(_: unit) : MlGetFiltersRequest =
            {
                FilterId = Unchecked.defaultof<_>
                From = None
                Size = None
            }

        [<CustomOperation("filterId")>]
        member _.FilterId(state: MlGetFiltersRequest, value: Types.Ids) =
            { state with FilterId = value }

        [<CustomOperation("from")>]
        member _.From(state: MlGetFiltersRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MlGetFiltersRequest, value: Types.Integer) =
            { state with Size = Some value }

    let mlGetFiltersRequest = MlGetFiltersRequestBuilder()

    module GetFilters =
        let withFrom (value: Types.Integer) (req: MlGetFiltersRequest) =
            { req with From = Some value }
        let withSize (value: Types.Integer) (req: MlGetFiltersRequest) =
            { req with Size = Some value }

    type MlGetInfluencersRequest = {
        JobId: Types.Id
        Desc: bool option
        End: Types.DateTime option
        ExcludeInterim: bool option
        InfluencerScore: Types.Double option
        From: Types.Integer option
        Size: Types.Integer option
        Sort: Types.Field option
        Start: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("page")>]
        Page: Types.Page option
    }

        with
        static member ToEndpoint(req: MlGetInfluencersRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/{Fes.Http.toPathSegment req.JobId}/results/influencers"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.JobId(state: MlGetInfluencersRequest, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("desc")>]
        member _.Desc(state: MlGetInfluencersRequest, value: bool) =
            { state with Desc = Some value }

        [<CustomOperation("end'")>]
        member _.End(state: MlGetInfluencersRequest, value: Types.DateTime) =
            { state with End = Some value }

        [<CustomOperation("excludeInterim")>]
        member _.ExcludeInterim(state: MlGetInfluencersRequest, value: bool) =
            { state with ExcludeInterim = Some value }

        [<CustomOperation("influencerScore")>]
        member _.InfluencerScore(state: MlGetInfluencersRequest, value: Types.Double) =
            { state with InfluencerScore = Some value }

        [<CustomOperation("from")>]
        member _.From(state: MlGetInfluencersRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MlGetInfluencersRequest, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: MlGetInfluencersRequest, value: Types.Field) =
            { state with Sort = Some value }

        [<CustomOperation("start")>]
        member _.Start(state: MlGetInfluencersRequest, value: Types.DateTime) =
            { state with Start = Some value }

        [<CustomOperation("page")>]
        member _.Page(state: MlGetInfluencersRequest, value: Types.Page) =
            { state with Page = Some value }

    let mlGetInfluencersRequest = MlGetInfluencersRequestBuilder()

    module GetInfluencers =
        let withDesc (value: bool) (req: MlGetInfluencersRequest) =
            { req with Desc = Some value }
        let withEnd (value: Types.DateTime) (req: MlGetInfluencersRequest) =
            { req with End = Some value }
        let withExcludeInterim (value: bool) (req: MlGetInfluencersRequest) =
            { req with ExcludeInterim = Some value }
        let withInfluencerScore (value: Types.Double) (req: MlGetInfluencersRequest) =
            { req with InfluencerScore = Some value }
        let withFrom (value: Types.Integer) (req: MlGetInfluencersRequest) =
            { req with From = Some value }
        let withSize (value: Types.Integer) (req: MlGetInfluencersRequest) =
            { req with Size = Some value }
        let withSort (value: Types.Field) (req: MlGetInfluencersRequest) =
            { req with Sort = Some value }
        let withStart (value: Types.DateTime) (req: MlGetInfluencersRequest) =
            { req with Start = Some value }
        let withPage (value: Types.Page) (req: MlGetInfluencersRequest) =
            { req with Page = Some value }

    type MlGetJobStatsRequest = {
        JobId: Types.Id
        AllowNoMatch: bool option
    }

        with
        static member ToEndpoint(req: MlGetJobStatsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/{Fes.Http.toPathSegment req.JobId}/_stats"
            let queryParams =
                [
                    req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type MlGetJobStatsResponse = System.Text.Json.JsonElement

    type MlGetJobStatsRequestBuilder() =
        member _.Yield(_: unit) : MlGetJobStatsRequest =
            {
                JobId = Unchecked.defaultof<_>
                AllowNoMatch = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlGetJobStatsRequest, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlGetJobStatsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

    let mlGetJobStatsRequest = MlGetJobStatsRequestBuilder()

    module GetJobStats =
        let withAllowNoMatch (value: bool) (req: MlGetJobStatsRequest) =
            { req with AllowNoMatch = Some value }

    type MlGetJobsRequest = {
        JobId: Types.Ids
        AllowNoMatch: bool option
        ExcludeGenerated: bool option
    }

        with
        static member ToEndpoint(req: MlGetJobsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/{Fes.Http.toPathSegment req.JobId}"
            let queryParams =
                [
                    req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                    req.ExcludeGenerated |> Option.map (fun v -> "exclude_generated", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type MlGetJobsResponse = System.Text.Json.JsonElement

    type MlGetJobsRequestBuilder() =
        member _.Yield(_: unit) : MlGetJobsRequest =
            {
                JobId = Unchecked.defaultof<_>
                AllowNoMatch = None
                ExcludeGenerated = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlGetJobsRequest, value: Types.Ids) =
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
        NodeId: Types.Id
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: MlGetMemoryStatsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/memory/{Fes.Http.toPathSegment req.NodeId}/_stats"
            let queryParams =
                [
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type MlGetMemoryStatsResponse = System.Text.Json.JsonElement

    type MlGetMemoryStatsRequestBuilder() =
        member _.Yield(_: unit) : MlGetMemoryStatsRequest =
            {
                NodeId = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: MlGetMemoryStatsRequest, value: Types.Id) =
            { state with NodeId = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: MlGetMemoryStatsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlGetMemoryStatsRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let mlGetMemoryStatsRequest = MlGetMemoryStatsRequestBuilder()

    module GetMemoryStats =
        let withMasterTimeout (value: Types.Duration) (req: MlGetMemoryStatsRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: MlGetMemoryStatsRequest) =
            { req with Timeout = Some value }

    type MlGetModelSnapshotUpgradeStatsRequest = {
        JobId: Types.Id
        SnapshotId: Types.Id
        AllowNoMatch: bool option
    }

        with
        static member ToEndpoint(req: MlGetModelSnapshotUpgradeStatsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/{Fes.Http.toPathSegment req.JobId}/model_snapshots/{Fes.Http.toPathSegment req.SnapshotId}/_upgrade/_stats"
            let queryParams =
                [
                    req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type MlGetModelSnapshotUpgradeStatsResponse = System.Text.Json.JsonElement

    type MlGetModelSnapshotUpgradeStatsRequestBuilder() =
        member _.Yield(_: unit) : MlGetModelSnapshotUpgradeStatsRequest =
            {
                JobId = Unchecked.defaultof<_>
                SnapshotId = Unchecked.defaultof<_>
                AllowNoMatch = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlGetModelSnapshotUpgradeStatsRequest, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("snapshotId")>]
        member _.SnapshotId(state: MlGetModelSnapshotUpgradeStatsRequest, value: Types.Id) =
            { state with SnapshotId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlGetModelSnapshotUpgradeStatsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

    let mlGetModelSnapshotUpgradeStatsRequest = MlGetModelSnapshotUpgradeStatsRequestBuilder()

    module GetModelSnapshotUpgradeStats =
        let withAllowNoMatch (value: bool) (req: MlGetModelSnapshotUpgradeStatsRequest) =
            { req with AllowNoMatch = Some value }

    type MlGetModelSnapshotsRequest = {
        JobId: Types.Id
        SnapshotId: Types.Id
        Desc: bool option
        End: Types.DateTime option
        From: Types.Integer option
        Size: Types.Integer option
        Sort: Types.Field option
        Start: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("desc")>]
        bodyDesc: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("end")>]
        bodyEnd: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("page")>]
        Page: Types.Page option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        bodySort: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("start")>]
        bodyStart: Types.DateTime option
    }

        with
        static member ToEndpoint(req: MlGetModelSnapshotsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/{Fes.Http.toPathSegment req.JobId}/model_snapshots/{Fes.Http.toPathSegment req.SnapshotId}"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
                bodyDesc = None
                bodyEnd = None
                Page = None
                bodySort = None
                bodyStart = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlGetModelSnapshotsRequest, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("snapshotId")>]
        member _.SnapshotId(state: MlGetModelSnapshotsRequest, value: Types.Id) =
            { state with SnapshotId = value }

        [<CustomOperation("desc")>]
        member _.Desc(state: MlGetModelSnapshotsRequest, value: bool) =
            { state with Desc = Some value }

        [<CustomOperation("end'")>]
        member _.End(state: MlGetModelSnapshotsRequest, value: Types.DateTime) =
            { state with End = Some value }

        [<CustomOperation("from")>]
        member _.From(state: MlGetModelSnapshotsRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MlGetModelSnapshotsRequest, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: MlGetModelSnapshotsRequest, value: Types.Field) =
            { state with Sort = Some value }

        [<CustomOperation("start")>]
        member _.Start(state: MlGetModelSnapshotsRequest, value: Types.DateTime) =
            { state with Start = Some value }

        [<CustomOperation("bodyDesc")>]
        member _.BodyDesc(state: MlGetModelSnapshotsRequest, value: bool) =
            { state with bodyDesc = Some value }

        [<CustomOperation("bodyEnd")>]
        member _.BodyEnd(state: MlGetModelSnapshotsRequest, value: Types.DateTime) =
            { state with bodyEnd = Some value }

        [<CustomOperation("page")>]
        member _.Page(state: MlGetModelSnapshotsRequest, value: Types.Page) =
            { state with Page = Some value }

        [<CustomOperation("bodySort")>]
        member _.BodySort(state: MlGetModelSnapshotsRequest, value: Types.Field) =
            { state with bodySort = Some value }

        [<CustomOperation("bodyStart")>]
        member _.BodyStart(state: MlGetModelSnapshotsRequest, value: Types.DateTime) =
            { state with bodyStart = Some value }

    let mlGetModelSnapshotsRequest = MlGetModelSnapshotsRequestBuilder()

    module GetModelSnapshots =
        let withDesc (value: bool) (req: MlGetModelSnapshotsRequest) =
            { req with Desc = Some value }
        let withEnd (value: Types.DateTime) (req: MlGetModelSnapshotsRequest) =
            { req with End = Some value }
        let withFrom (value: Types.Integer) (req: MlGetModelSnapshotsRequest) =
            { req with From = Some value }
        let withSize (value: Types.Integer) (req: MlGetModelSnapshotsRequest) =
            { req with Size = Some value }
        let withSort (value: Types.Field) (req: MlGetModelSnapshotsRequest) =
            { req with Sort = Some value }
        let withStart (value: Types.DateTime) (req: MlGetModelSnapshotsRequest) =
            { req with Start = Some value }
        let withBodyDesc (value: bool) (req: MlGetModelSnapshotsRequest) =
            { req with bodyDesc = Some value }
        let withBodyEnd (value: Types.DateTime) (req: MlGetModelSnapshotsRequest) =
            { req with bodyEnd = Some value }
        let withPage (value: Types.Page) (req: MlGetModelSnapshotsRequest) =
            { req with Page = Some value }
        let withBodySort (value: Types.Field) (req: MlGetModelSnapshotsRequest) =
            { req with bodySort = Some value }
        let withBodyStart (value: Types.DateTime) (req: MlGetModelSnapshotsRequest) =
            { req with bodyStart = Some value }

    type MlGetOverallBucketsRequest = {
        JobId: Types.Id
        AllowNoMatch: bool option
        BucketSpan: Types.Duration option
        End: Types.DateTime option
        ExcludeInterim: bool option
        OverallScore: Types.Double option
        Start: Types.DateTime option
        TopN: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_no_match")>]
        bodyAllowNoMatch: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_span")>]
        bodyBucketSpan: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("end")>]
        bodyEnd: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("exclude_interim")>]
        bodyExcludeInterim: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("overall_score")>]
        bodyOverallScore: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("start")>]
        bodyStart: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("top_n")>]
        bodyTopN: Types.Integer option
    }

        with
        static member ToEndpoint(req: MlGetOverallBucketsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/{Fes.Http.toPathSegment req.JobId}/results/overall_buckets"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
                bodyAllowNoMatch = None
                bodyBucketSpan = None
                bodyEnd = None
                bodyExcludeInterim = None
                bodyOverallScore = None
                bodyStart = None
                bodyTopN = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlGetOverallBucketsRequest, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlGetOverallBucketsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("bucketSpan")>]
        member _.BucketSpan(state: MlGetOverallBucketsRequest, value: Types.Duration) =
            { state with BucketSpan = Some value }

        [<CustomOperation("end'")>]
        member _.End(state: MlGetOverallBucketsRequest, value: Types.DateTime) =
            { state with End = Some value }

        [<CustomOperation("excludeInterim")>]
        member _.ExcludeInterim(state: MlGetOverallBucketsRequest, value: bool) =
            { state with ExcludeInterim = Some value }

        [<CustomOperation("overallScore")>]
        member _.OverallScore(state: MlGetOverallBucketsRequest, value: Types.Double) =
            { state with OverallScore = Some value }

        [<CustomOperation("start")>]
        member _.Start(state: MlGetOverallBucketsRequest, value: Types.DateTime) =
            { state with Start = Some value }

        [<CustomOperation("topN")>]
        member _.TopN(state: MlGetOverallBucketsRequest, value: Types.Integer) =
            { state with TopN = Some value }

        [<CustomOperation("bodyAllowNoMatch")>]
        member _.BodyAllowNoMatch(state: MlGetOverallBucketsRequest, value: bool) =
            { state with bodyAllowNoMatch = Some value }

        [<CustomOperation("bodyBucketSpan")>]
        member _.BodyBucketSpan(state: MlGetOverallBucketsRequest, value: Types.Duration) =
            { state with bodyBucketSpan = Some value }

        [<CustomOperation("bodyEnd")>]
        member _.BodyEnd(state: MlGetOverallBucketsRequest, value: Types.DateTime) =
            { state with bodyEnd = Some value }

        [<CustomOperation("bodyExcludeInterim")>]
        member _.BodyExcludeInterim(state: MlGetOverallBucketsRequest, value: bool) =
            { state with bodyExcludeInterim = Some value }

        [<CustomOperation("bodyOverallScore")>]
        member _.BodyOverallScore(state: MlGetOverallBucketsRequest, value: Types.Double) =
            { state with bodyOverallScore = Some value }

        [<CustomOperation("bodyStart")>]
        member _.BodyStart(state: MlGetOverallBucketsRequest, value: Types.DateTime) =
            { state with bodyStart = Some value }

        [<CustomOperation("bodyTopN")>]
        member _.BodyTopN(state: MlGetOverallBucketsRequest, value: Types.Integer) =
            { state with bodyTopN = Some value }

    let mlGetOverallBucketsRequest = MlGetOverallBucketsRequestBuilder()

    module GetOverallBuckets =
        let withAllowNoMatch (value: bool) (req: MlGetOverallBucketsRequest) =
            { req with AllowNoMatch = Some value }
        let withBucketSpan (value: Types.Duration) (req: MlGetOverallBucketsRequest) =
            { req with BucketSpan = Some value }
        let withEnd (value: Types.DateTime) (req: MlGetOverallBucketsRequest) =
            { req with End = Some value }
        let withExcludeInterim (value: bool) (req: MlGetOverallBucketsRequest) =
            { req with ExcludeInterim = Some value }
        let withOverallScore (value: Types.Double) (req: MlGetOverallBucketsRequest) =
            { req with OverallScore = Some value }
        let withStart (value: Types.DateTime) (req: MlGetOverallBucketsRequest) =
            { req with Start = Some value }
        let withTopN (value: Types.Integer) (req: MlGetOverallBucketsRequest) =
            { req with TopN = Some value }
        let withBodyAllowNoMatch (value: bool) (req: MlGetOverallBucketsRequest) =
            { req with bodyAllowNoMatch = Some value }
        let withBodyBucketSpan (value: Types.Duration) (req: MlGetOverallBucketsRequest) =
            { req with bodyBucketSpan = Some value }
        let withBodyEnd (value: Types.DateTime) (req: MlGetOverallBucketsRequest) =
            { req with bodyEnd = Some value }
        let withBodyExcludeInterim (value: bool) (req: MlGetOverallBucketsRequest) =
            { req with bodyExcludeInterim = Some value }
        let withBodyOverallScore (value: Types.Double) (req: MlGetOverallBucketsRequest) =
            { req with bodyOverallScore = Some value }
        let withBodyStart (value: Types.DateTime) (req: MlGetOverallBucketsRequest) =
            { req with bodyStart = Some value }
        let withBodyTopN (value: Types.Integer) (req: MlGetOverallBucketsRequest) =
            { req with bodyTopN = Some value }

    type MlGetRecordsRequest = {
        JobId: Types.Id
        Desc: bool option
        End: Types.DateTime option
        ExcludeInterim: bool option
        From: Types.Integer option
        RecordScore: Types.Double option
        Size: Types.Integer option
        Sort: Types.Field option
        Start: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("desc")>]
        bodyDesc: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("end")>]
        bodyEnd: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("exclude_interim")>]
        bodyExcludeInterim: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("page")>]
        Page: Types.Page option
        [<System.Text.Json.Serialization.JsonPropertyName("record_score")>]
        bodyRecordScore: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        bodySort: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("start")>]
        bodyStart: Types.DateTime option
    }

        with
        static member ToEndpoint(req: MlGetRecordsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/{Fes.Http.toPathSegment req.JobId}/results/records"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
                bodyDesc = None
                bodyEnd = None
                bodyExcludeInterim = None
                Page = None
                bodyRecordScore = None
                bodySort = None
                bodyStart = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlGetRecordsRequest, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("desc")>]
        member _.Desc(state: MlGetRecordsRequest, value: bool) =
            { state with Desc = Some value }

        [<CustomOperation("end'")>]
        member _.End(state: MlGetRecordsRequest, value: Types.DateTime) =
            { state with End = Some value }

        [<CustomOperation("excludeInterim")>]
        member _.ExcludeInterim(state: MlGetRecordsRequest, value: bool) =
            { state with ExcludeInterim = Some value }

        [<CustomOperation("from")>]
        member _.From(state: MlGetRecordsRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("recordScore")>]
        member _.RecordScore(state: MlGetRecordsRequest, value: Types.Double) =
            { state with RecordScore = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MlGetRecordsRequest, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: MlGetRecordsRequest, value: Types.Field) =
            { state with Sort = Some value }

        [<CustomOperation("start")>]
        member _.Start(state: MlGetRecordsRequest, value: Types.DateTime) =
            { state with Start = Some value }

        [<CustomOperation("bodyDesc")>]
        member _.BodyDesc(state: MlGetRecordsRequest, value: bool) =
            { state with bodyDesc = Some value }

        [<CustomOperation("bodyEnd")>]
        member _.BodyEnd(state: MlGetRecordsRequest, value: Types.DateTime) =
            { state with bodyEnd = Some value }

        [<CustomOperation("bodyExcludeInterim")>]
        member _.BodyExcludeInterim(state: MlGetRecordsRequest, value: bool) =
            { state with bodyExcludeInterim = Some value }

        [<CustomOperation("page")>]
        member _.Page(state: MlGetRecordsRequest, value: Types.Page) =
            { state with Page = Some value }

        [<CustomOperation("bodyRecordScore")>]
        member _.BodyRecordScore(state: MlGetRecordsRequest, value: Types.Double) =
            { state with bodyRecordScore = Some value }

        [<CustomOperation("bodySort")>]
        member _.BodySort(state: MlGetRecordsRequest, value: Types.Field) =
            { state with bodySort = Some value }

        [<CustomOperation("bodyStart")>]
        member _.BodyStart(state: MlGetRecordsRequest, value: Types.DateTime) =
            { state with bodyStart = Some value }

    let mlGetRecordsRequest = MlGetRecordsRequestBuilder()

    module GetRecords =
        let withDesc (value: bool) (req: MlGetRecordsRequest) =
            { req with Desc = Some value }
        let withEnd (value: Types.DateTime) (req: MlGetRecordsRequest) =
            { req with End = Some value }
        let withExcludeInterim (value: bool) (req: MlGetRecordsRequest) =
            { req with ExcludeInterim = Some value }
        let withFrom (value: Types.Integer) (req: MlGetRecordsRequest) =
            { req with From = Some value }
        let withRecordScore (value: Types.Double) (req: MlGetRecordsRequest) =
            { req with RecordScore = Some value }
        let withSize (value: Types.Integer) (req: MlGetRecordsRequest) =
            { req with Size = Some value }
        let withSort (value: Types.Field) (req: MlGetRecordsRequest) =
            { req with Sort = Some value }
        let withStart (value: Types.DateTime) (req: MlGetRecordsRequest) =
            { req with Start = Some value }
        let withBodyDesc (value: bool) (req: MlGetRecordsRequest) =
            { req with bodyDesc = Some value }
        let withBodyEnd (value: Types.DateTime) (req: MlGetRecordsRequest) =
            { req with bodyEnd = Some value }
        let withBodyExcludeInterim (value: bool) (req: MlGetRecordsRequest) =
            { req with bodyExcludeInterim = Some value }
        let withPage (value: Types.Page) (req: MlGetRecordsRequest) =
            { req with Page = Some value }
        let withBodyRecordScore (value: Types.Double) (req: MlGetRecordsRequest) =
            { req with bodyRecordScore = Some value }
        let withBodySort (value: Types.Field) (req: MlGetRecordsRequest) =
            { req with bodySort = Some value }
        let withBodyStart (value: Types.DateTime) (req: MlGetRecordsRequest) =
            { req with bodyStart = Some value }

    type MlGetTrainedModelsRequest = {
        ModelId: Types.Ids
        AllowNoMatch: bool option
        DecompressDefinition: bool option
        ExcludeGenerated: bool option
        From: Types.Integer option
        Include: Types.Include option
        Size: Types.Integer option
        Tags: System.Text.Json.JsonElement option
    }

        with
        static member ToEndpoint(req: MlGetTrainedModelsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/trained_models/{Fes.Http.toPathSegment req.ModelId}"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

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
        member _.ModelId(state: MlGetTrainedModelsRequest, value: Types.Ids) =
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
        member _.From(state: MlGetTrainedModelsRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("include")>]
        member _.Include(state: MlGetTrainedModelsRequest, value: Types.Include) =
            { state with Include = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MlGetTrainedModelsRequest, value: Types.Integer) =
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
        let withFrom (value: Types.Integer) (req: MlGetTrainedModelsRequest) =
            { req with From = Some value }
        let withInclude (value: Types.Include) (req: MlGetTrainedModelsRequest) =
            { req with Include = Some value }
        let withSize (value: Types.Integer) (req: MlGetTrainedModelsRequest) =
            { req with Size = Some value }
        let withTags (value: System.Text.Json.JsonElement) (req: MlGetTrainedModelsRequest) =
            { req with Tags = Some value }

    type MlGetTrainedModelsStatsRequest = {
        ModelId: Types.Ids
        AllowNoMatch: bool option
        From: Types.Integer option
        Size: Types.Integer option
    }

        with
        static member ToEndpoint(req: MlGetTrainedModelsStatsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/trained_models/{Fes.Http.toPathSegment req.ModelId}/_stats"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

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
        member _.ModelId(state: MlGetTrainedModelsStatsRequest, value: Types.Ids) =
            { state with ModelId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlGetTrainedModelsStatsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("from")>]
        member _.From(state: MlGetTrainedModelsStatsRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MlGetTrainedModelsStatsRequest, value: Types.Integer) =
            { state with Size = Some value }

    let mlGetTrainedModelsStatsRequest = MlGetTrainedModelsStatsRequestBuilder()

    module GetTrainedModelsStats =
        let withAllowNoMatch (value: bool) (req: MlGetTrainedModelsStatsRequest) =
            { req with AllowNoMatch = Some value }
        let withFrom (value: Types.Integer) (req: MlGetTrainedModelsStatsRequest) =
            { req with From = Some value }
        let withSize (value: Types.Integer) (req: MlGetTrainedModelsStatsRequest) =
            { req with Size = Some value }

    type MlInferTrainedModelRequest = {
        ModelId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("docs")>]
        Docs: Map<string, System.Text.Json.JsonElement> list
        [<System.Text.Json.Serialization.JsonPropertyName("inference_config")>]
        InferenceConfig: Types.InferenceConfigUpdateContainer option
    }

        with
        static member ToEndpoint(req: MlInferTrainedModelRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/trained_models/{Fes.Http.toPathSegment req.ModelId}/_infer"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.ModelId(state: MlInferTrainedModelRequest, value: Types.Id) =
            { state with ModelId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlInferTrainedModelRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("docs")>]
        member _.Docs(state: MlInferTrainedModelRequest, value: Map<string, System.Text.Json.JsonElement> list) =
            { state with Docs = value }

        [<CustomOperation("inferenceConfig")>]
        member _.InferenceConfig(state: MlInferTrainedModelRequest, value: Types.InferenceConfigUpdateContainer) =
            { state with InferenceConfig = Some value }

    let mlInferTrainedModelRequest = MlInferTrainedModelRequestBuilder()

    module InferTrainedModel =
        let withTimeout (value: Types.Duration) (req: MlInferTrainedModelRequest) =
            { req with Timeout = Some value }
        let withDocs (value: Map<string, System.Text.Json.JsonElement> list) (req: MlInferTrainedModelRequest) =
            { req with Docs = value }
        let withInferenceConfig (value: Types.InferenceConfigUpdateContainer) (req: MlInferTrainedModelRequest) =
            { req with InferenceConfig = Some value }

    type MlInfoRequest = | MlInfoRequest

        with
        static member ToEndpoint(req: MlInfoRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/info"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type MlInfoResponse = System.Text.Json.JsonElement

    type MlOpenJobRequest = {
        JobId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("timeout")>]
        bodyTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: MlOpenJobRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/{Fes.Http.toPathSegment req.JobId}/_open"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type MlOpenJobResponse = System.Text.Json.JsonElement

    type MlOpenJobRequestBuilder() =
        member _.Yield(_: unit) : MlOpenJobRequest =
            {
                JobId = Unchecked.defaultof<_>
                Timeout = None
                bodyTimeout = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlOpenJobRequest, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlOpenJobRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("bodyTimeout")>]
        member _.BodyTimeout(state: MlOpenJobRequest, value: Types.Duration) =
            { state with bodyTimeout = Some value }

    let mlOpenJobRequest = MlOpenJobRequestBuilder()

    module OpenJob =
        let withTimeout (value: Types.Duration) (req: MlOpenJobRequest) =
            { req with Timeout = Some value }
        let withBodyTimeout (value: Types.Duration) (req: MlOpenJobRequest) =
            { req with bodyTimeout = Some value }

    type MlPostCalendarEventsRequest = {
        CalendarId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("events")>]
        Events: Types.CalendarEvent list
    }

        with
        static member ToEndpoint(req: MlPostCalendarEventsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/calendars/{Fes.Http.toPathSegment req.CalendarId}/events"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type MlPostCalendarEventsResponse = System.Text.Json.JsonElement

    type MlPostCalendarEventsRequestBuilder() =
        member _.Yield(_: unit) : MlPostCalendarEventsRequest =
            {
                CalendarId = Unchecked.defaultof<_>
                Events = Unchecked.defaultof<_>
            }

        [<CustomOperation("calendarId")>]
        member _.CalendarId(state: MlPostCalendarEventsRequest, value: Types.Id) =
            { state with CalendarId = value }

        [<CustomOperation("events")>]
        member _.Events(state: MlPostCalendarEventsRequest, value: Types.CalendarEvent list) =
            { state with Events = value }

    let mlPostCalendarEventsRequest = MlPostCalendarEventsRequestBuilder()

    module PostCalendarEvents =
        let withEvents (value: Types.CalendarEvent list) (req: MlPostCalendarEventsRequest) =
            { req with Events = value }

    type MlPostDataRequest<'TData> = {
        JobId: Types.Id
        ResetEnd: Types.DateTime option
        ResetStart: Types.DateTime option
        Document: 'TData list
    }

        with
        static member ToEndpoint(req: MlPostDataRequest<'TData>) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/{Fes.Http.toPathSegment req.JobId}/_data"
            let queryParams =
                [
                    req.ResetEnd |> Option.map (fun v -> "reset_end", Fes.Http.toQueryValue v)
                    req.ResetStart |> Option.map (fun v -> "reset_start", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req.Document)
            endpoint, ValueSome postData

    type MlPostDataResponse = System.Text.Json.JsonElement

    type MlPostDataRequestBuilder() =
        member _.Yield(_: unit) : MlPostDataRequest<_> =
            {
                JobId = Unchecked.defaultof<_>
                ResetEnd = None
                ResetStart = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlPostDataRequest<_>, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("resetEnd")>]
        member _.ResetEnd(state: MlPostDataRequest<_>, value: Types.DateTime) =
            { state with ResetEnd = Some value }

        [<CustomOperation("resetStart")>]
        member _.ResetStart(state: MlPostDataRequest<_>, value: Types.DateTime) =
            { state with ResetStart = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: MlPostDataRequest<_>, value) =
            { state with Document = value }

    let mlPostDataRequest = MlPostDataRequestBuilder()

    module PostData =
        let withResetEnd (value: Types.DateTime) (req: MlPostDataRequest<_>) =
            { req with ResetEnd = Some value }
        let withResetStart (value: Types.DateTime) (req: MlPostDataRequest<_>) =
            { req with ResetStart = Some value }

    type MlPreviewDataFrameAnalyticsRequest = {
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("config")>]
        Config: Types.DataframePreviewConfig option
    }

        with
        static member ToEndpoint(req: MlPreviewDataFrameAnalyticsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/data_frame/analytics/{Fes.Http.toPathSegment req.Id}/_preview"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type MlPreviewDataFrameAnalyticsResponse = System.Text.Json.JsonElement

    type MlPreviewDataFrameAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : MlPreviewDataFrameAnalyticsRequest =
            {
                Id = Unchecked.defaultof<_>
                Config = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: MlPreviewDataFrameAnalyticsRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("config")>]
        member _.Config(state: MlPreviewDataFrameAnalyticsRequest, value: Types.DataframePreviewConfig) =
            { state with Config = Some value }

    let mlPreviewDataFrameAnalyticsRequest = MlPreviewDataFrameAnalyticsRequestBuilder()

    module PreviewDataFrameAnalytics =
        let withConfig (value: Types.DataframePreviewConfig) (req: MlPreviewDataFrameAnalyticsRequest) =
            { req with Config = Some value }

    type MlPreviewDatafeedRequest = {
        DatafeedId: Types.Id
        Start: Types.DateTime option
        End: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("datafeed_config")>]
        DatafeedConfig: Types.DatafeedConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("job_config")>]
        JobConfig: Types.JobConfig option
    }

        with
        static member ToEndpoint(req: MlPreviewDatafeedRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/datafeeds/{Fes.Http.toPathSegment req.DatafeedId}/_preview"
            let queryParams =
                [
                    req.Start |> Option.map (fun v -> "start", Fes.Http.toQueryValue v)
                    req.End |> Option.map (fun v -> "end", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type MlPreviewDatafeedResponse<'TDocument> = 'TDocument list

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
        member _.DatafeedId(state: MlPreviewDatafeedRequest, value: Types.Id) =
            { state with DatafeedId = value }

        [<CustomOperation("start")>]
        member _.Start(state: MlPreviewDatafeedRequest, value: Types.DateTime) =
            { state with Start = Some value }

        [<CustomOperation("end'")>]
        member _.End(state: MlPreviewDatafeedRequest, value: Types.DateTime) =
            { state with End = Some value }

        [<CustomOperation("datafeedConfig")>]
        member _.DatafeedConfig(state: MlPreviewDatafeedRequest, value: Types.DatafeedConfig) =
            { state with DatafeedConfig = Some value }

        [<CustomOperation("jobConfig")>]
        member _.JobConfig(state: MlPreviewDatafeedRequest, value: Types.JobConfig) =
            { state with JobConfig = Some value }

    let mlPreviewDatafeedRequest = MlPreviewDatafeedRequestBuilder()

    module PreviewDatafeed =
        let withStart (value: Types.DateTime) (req: MlPreviewDatafeedRequest) =
            { req with Start = Some value }
        let withEnd (value: Types.DateTime) (req: MlPreviewDatafeedRequest) =
            { req with End = Some value }
        let withDatafeedConfig (value: Types.DatafeedConfig) (req: MlPreviewDatafeedRequest) =
            { req with DatafeedConfig = Some value }
        let withJobConfig (value: Types.JobConfig) (req: MlPreviewDatafeedRequest) =
            { req with JobConfig = Some value }

    type MlPutCalendarRequest = {
        CalendarId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("job_ids")>]
        JobIds: Types.Id list option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
    }

        with
        static member ToEndpoint(req: MlPutCalendarRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/calendars/{Fes.Http.toPathSegment req.CalendarId}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type MlPutCalendarResponse = System.Text.Json.JsonElement

    type MlPutCalendarRequestBuilder() =
        member _.Yield(_: unit) : MlPutCalendarRequest =
            {
                CalendarId = Unchecked.defaultof<_>
                JobIds = None
                Description = None
            }

        [<CustomOperation("calendarId")>]
        member _.CalendarId(state: MlPutCalendarRequest, value: Types.Id) =
            { state with CalendarId = value }

        [<CustomOperation("jobIds")>]
        member _.JobIds(state: MlPutCalendarRequest, value: Types.Id list) =
            { state with JobIds = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: MlPutCalendarRequest, value: string) =
            { state with Description = Some value }

    let mlPutCalendarRequest = MlPutCalendarRequestBuilder()

    module PutCalendar =
        let withJobIds (value: Types.Id list) (req: MlPutCalendarRequest) =
            { req with JobIds = Some value }
        let withDescription (value: string) (req: MlPutCalendarRequest) =
            { req with Description = Some value }

    type MlPutCalendarJobRequest = {
        CalendarId: Types.Id
        JobId: Types.Ids
    }

        with
        static member ToEndpoint(req: MlPutCalendarJobRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/calendars/{Fes.Http.toPathSegment req.CalendarId}/jobs/{Fes.Http.toPathSegment req.JobId}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            endpoint, ValueNone

    type MlPutCalendarJobResponse = System.Text.Json.JsonElement

    type MlPutCalendarJobRequestBuilder() =
        member _.Yield(_: unit) : MlPutCalendarJobRequest =
            {
                CalendarId = Unchecked.defaultof<_>
                JobId = Unchecked.defaultof<_>
            }

        [<CustomOperation("calendarId")>]
        member _.CalendarId(state: MlPutCalendarJobRequest, value: Types.Id) =
            { state with CalendarId = value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlPutCalendarJobRequest, value: Types.Ids) =
            { state with JobId = value }

    let mlPutCalendarJobRequest = MlPutCalendarJobRequestBuilder()

    type MlPutDataFrameAnalyticsRequest = {
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("allow_lazy_start")>]
        AllowLazyStart: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("analysis")>]
        Analysis: Types.DataframeAnalysisContainer
        [<System.Text.Json.Serialization.JsonPropertyName("analyzed_fields")>]
        AnalyzedFields: Types.DataframeAnalysisAnalyzedFields option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("dest")>]
        Dest: Types.DataframeAnalyticsDestination
        [<System.Text.Json.Serialization.JsonPropertyName("max_num_threads")>]
        MaxNumThreads: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("model_memory_limit")>]
        ModelMemoryLimit: string option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: Types.DataframeAnalyticsSource
        [<System.Text.Json.Serialization.JsonPropertyName("headers")>]
        Headers: Types.HttpHeaders option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString option
    }

        with
        static member ToEndpoint(req: MlPutDataFrameAnalyticsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/data_frame/analytics/{Fes.Http.toPathSegment req.Id}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.Id(state: MlPutDataFrameAnalyticsRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("allowLazyStart")>]
        member _.AllowLazyStart(state: MlPutDataFrameAnalyticsRequest, value: bool) =
            { state with AllowLazyStart = Some value }

        [<CustomOperation("analysis")>]
        member _.Analysis(state: MlPutDataFrameAnalyticsRequest, value: Types.DataframeAnalysisContainer) =
            { state with Analysis = value }

        [<CustomOperation("analyzedFields")>]
        member _.AnalyzedFields(state: MlPutDataFrameAnalyticsRequest, value: Types.DataframeAnalysisAnalyzedFields) =
            { state with AnalyzedFields = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: MlPutDataFrameAnalyticsRequest, value: string) =
            { state with Description = Some value }

        [<CustomOperation("dest")>]
        member _.Dest(state: MlPutDataFrameAnalyticsRequest, value: Types.DataframeAnalyticsDestination) =
            { state with Dest = value }

        [<CustomOperation("maxNumThreads")>]
        member _.MaxNumThreads(state: MlPutDataFrameAnalyticsRequest, value: Types.Integer) =
            { state with MaxNumThreads = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: MlPutDataFrameAnalyticsRequest, value: Types.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("modelMemoryLimit")>]
        member _.ModelMemoryLimit(state: MlPutDataFrameAnalyticsRequest, value: string) =
            { state with ModelMemoryLimit = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: MlPutDataFrameAnalyticsRequest, value: Types.DataframeAnalyticsSource) =
            { state with Source = value }

        [<CustomOperation("headers")>]
        member _.Headers(state: MlPutDataFrameAnalyticsRequest, value: Types.HttpHeaders) =
            { state with Headers = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: MlPutDataFrameAnalyticsRequest, value: Types.VersionString) =
            { state with Version = Some value }

    let mlPutDataFrameAnalyticsRequest = MlPutDataFrameAnalyticsRequestBuilder()

    module PutDataFrameAnalytics =
        let withAllowLazyStart (value: bool) (req: MlPutDataFrameAnalyticsRequest) =
            { req with AllowLazyStart = Some value }
        let withAnalysis (value: Types.DataframeAnalysisContainer) (req: MlPutDataFrameAnalyticsRequest) =
            { req with Analysis = value }
        let withAnalyzedFields (value: Types.DataframeAnalysisAnalyzedFields) (req: MlPutDataFrameAnalyticsRequest) =
            { req with AnalyzedFields = Some value }
        let withDescription (value: string) (req: MlPutDataFrameAnalyticsRequest) =
            { req with Description = Some value }
        let withDest (value: Types.DataframeAnalyticsDestination) (req: MlPutDataFrameAnalyticsRequest) =
            { req with Dest = value }
        let withMaxNumThreads (value: Types.Integer) (req: MlPutDataFrameAnalyticsRequest) =
            { req with MaxNumThreads = Some value }
        let withMeta (value: Types.Metadata) (req: MlPutDataFrameAnalyticsRequest) =
            { req with Meta = Some value }
        let withModelMemoryLimit (value: string) (req: MlPutDataFrameAnalyticsRequest) =
            { req with ModelMemoryLimit = Some value }
        let withSource (value: Types.DataframeAnalyticsSource) (req: MlPutDataFrameAnalyticsRequest) =
            { req with Source = value }
        let withHeaders (value: Types.HttpHeaders) (req: MlPutDataFrameAnalyticsRequest) =
            { req with Headers = Some value }
        let withVersion (value: Types.VersionString) (req: MlPutDataFrameAnalyticsRequest) =
            { req with Version = Some value }

    type MlPutDatafeedRequest = {
        DatafeedId: Types.Id
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreThrottled: bool option
        IgnoreUnavailable: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("aggregations")>]
        Aggregations: Map<string, Types.AggregationContainer> option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_config")>]
        ChunkingConfig: Types.ChunkingConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("delayed_data_check_config")>]
        DelayedDataCheckConfig: Types.DelayedDataCheckConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("frequency")>]
        Frequency: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: Types.Indices option
        [<System.Text.Json.Serialization.JsonPropertyName("indices_options")>]
        IndicesOptions: Types.IndicesOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("max_empty_searches")>]
        MaxEmptySearches: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: Types.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("query_delay")>]
        QueryDelay: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: Types.RuntimeFields option
        [<System.Text.Json.Serialization.JsonPropertyName("script_fields")>]
        ScriptFields: Map<string, Types.ScriptField> option
        [<System.Text.Json.Serialization.JsonPropertyName("scroll_size")>]
        ScrollSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("headers")>]
        Headers: Types.HttpHeaders option
    }

        with
        static member ToEndpoint(req: MlPutDatafeedRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/datafeeds/{Fes.Http.toPathSegment req.DatafeedId}"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.DatafeedId(state: MlPutDatafeedRequest, value: Types.Id) =
            { state with DatafeedId = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: MlPutDatafeedRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: MlPutDatafeedRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreThrottled")>]
        member _.IgnoreThrottled(state: MlPutDatafeedRequest, value: bool) =
            { state with IgnoreThrottled = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: MlPutDatafeedRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: MlPutDatafeedRequest, value: Map<string, Types.AggregationContainer>) =
            { state with Aggregations = Some value }

        [<CustomOperation("chunkingConfig")>]
        member _.ChunkingConfig(state: MlPutDatafeedRequest, value: Types.ChunkingConfig) =
            { state with ChunkingConfig = Some value }

        [<CustomOperation("delayedDataCheckConfig")>]
        member _.DelayedDataCheckConfig(state: MlPutDatafeedRequest, value: Types.DelayedDataCheckConfig) =
            { state with DelayedDataCheckConfig = Some value }

        [<CustomOperation("frequency")>]
        member _.Frequency(state: MlPutDatafeedRequest, value: Types.Duration) =
            { state with Frequency = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: MlPutDatafeedRequest, value: Types.Indices) =
            { state with Indices = Some value }

        [<CustomOperation("indicesOptions")>]
        member _.IndicesOptions(state: MlPutDatafeedRequest, value: Types.IndicesOptions) =
            { state with IndicesOptions = Some value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlPutDatafeedRequest, value: Types.Id) =
            { state with JobId = Some value }

        [<CustomOperation("maxEmptySearches")>]
        member _.MaxEmptySearches(state: MlPutDatafeedRequest, value: Types.Integer) =
            { state with MaxEmptySearches = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: MlPutDatafeedRequest, value: Types.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("queryDelay")>]
        member _.QueryDelay(state: MlPutDatafeedRequest, value: Types.Duration) =
            { state with QueryDelay = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: MlPutDatafeedRequest, value: Types.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("scriptFields")>]
        member _.ScriptFields(state: MlPutDatafeedRequest, value: Map<string, Types.ScriptField>) =
            { state with ScriptFields = Some value }

        [<CustomOperation("scrollSize")>]
        member _.ScrollSize(state: MlPutDatafeedRequest, value: Types.Integer) =
            { state with ScrollSize = Some value }

        [<CustomOperation("headers")>]
        member _.Headers(state: MlPutDatafeedRequest, value: Types.HttpHeaders) =
            { state with Headers = Some value }

    let mlPutDatafeedRequest = MlPutDatafeedRequestBuilder()

    module PutDatafeed =
        let withAllowNoIndices (value: bool) (req: MlPutDatafeedRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: MlPutDatafeedRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreThrottled (value: bool) (req: MlPutDatafeedRequest) =
            { req with IgnoreThrottled = Some value }
        let withIgnoreUnavailable (value: bool) (req: MlPutDatafeedRequest) =
            { req with IgnoreUnavailable = Some value }
        let withAggregations (value: Map<string, Types.AggregationContainer>) (req: MlPutDatafeedRequest) =
            { req with Aggregations = Some value }
        let withChunkingConfig (value: Types.ChunkingConfig) (req: MlPutDatafeedRequest) =
            { req with ChunkingConfig = Some value }
        let withDelayedDataCheckConfig (value: Types.DelayedDataCheckConfig) (req: MlPutDatafeedRequest) =
            { req with DelayedDataCheckConfig = Some value }
        let withFrequency (value: Types.Duration) (req: MlPutDatafeedRequest) =
            { req with Frequency = Some value }
        let withIndices (value: Types.Indices) (req: MlPutDatafeedRequest) =
            { req with Indices = Some value }
        let withIndicesOptions (value: Types.IndicesOptions) (req: MlPutDatafeedRequest) =
            { req with IndicesOptions = Some value }
        let withJobId (value: Types.Id) (req: MlPutDatafeedRequest) =
            { req with JobId = Some value }
        let withMaxEmptySearches (value: Types.Integer) (req: MlPutDatafeedRequest) =
            { req with MaxEmptySearches = Some value }
        let withQuery (value: Types.QueryContainer) (req: MlPutDatafeedRequest) =
            { req with Query = Some value }
        let withQueryDelay (value: Types.Duration) (req: MlPutDatafeedRequest) =
            { req with QueryDelay = Some value }
        let withRuntimeMappings (value: Types.RuntimeFields) (req: MlPutDatafeedRequest) =
            { req with RuntimeMappings = Some value }
        let withScriptFields (value: Map<string, Types.ScriptField>) (req: MlPutDatafeedRequest) =
            { req with ScriptFields = Some value }
        let withScrollSize (value: Types.Integer) (req: MlPutDatafeedRequest) =
            { req with ScrollSize = Some value }
        let withHeaders (value: Types.HttpHeaders) (req: MlPutDatafeedRequest) =
            { req with Headers = Some value }

    type MlPutFilterRequest = {
        FilterId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("items")>]
        Items: string list option
    }

        with
        static member ToEndpoint(req: MlPutFilterRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/filters/{Fes.Http.toPathSegment req.FilterId}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type MlPutFilterResponse = System.Text.Json.JsonElement

    type MlPutFilterRequestBuilder() =
        member _.Yield(_: unit) : MlPutFilterRequest =
            {
                FilterId = Unchecked.defaultof<_>
                Description = None
                Items = None
            }

        [<CustomOperation("filterId")>]
        member _.FilterId(state: MlPutFilterRequest, value: Types.Id) =
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
        JobId: Types.Id
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreThrottled: bool option
        IgnoreUnavailable: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_lazy_open")>]
        AllowLazyOpen: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("analysis_config")>]
        AnalysisConfig: Types.AnalysisConfig
        [<System.Text.Json.Serialization.JsonPropertyName("analysis_limits")>]
        AnalysisLimits: Types.AnalysisLimits option
        [<System.Text.Json.Serialization.JsonPropertyName("background_persist_interval")>]
        BackgroundPersistInterval: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("custom_settings")>]
        CustomSettings: Types.CustomSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("daily_model_snapshot_retention_after_days")>]
        DailyModelSnapshotRetentionAfterDays: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("data_description")>]
        DataDescription: Types.DataDescription
        [<System.Text.Json.Serialization.JsonPropertyName("datafeed_config")>]
        DatafeedConfig: Types.DatafeedConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        bodyJobId: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("groups")>]
        Groups: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("model_plot_config")>]
        ModelPlotConfig: Types.ModelPlotConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("model_snapshot_retention_days")>]
        ModelSnapshotRetentionDays: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("renormalization_window_days")>]
        RenormalizationWindowDays: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("results_index_name")>]
        ResultsIndexName: Types.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("results_retention_days")>]
        ResultsRetentionDays: Types.Long option
    }

        with
        static member ToEndpoint(req: MlPutJobRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/{Fes.Http.toPathSegment req.JobId}"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
                bodyJobId = None
                Groups = None
                ModelPlotConfig = None
                ModelSnapshotRetentionDays = None
                RenormalizationWindowDays = None
                ResultsIndexName = None
                ResultsRetentionDays = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlPutJobRequest, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: MlPutJobRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: MlPutJobRequest, value: Types.ExpandWildcards) =
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
        member _.AnalysisConfig(state: MlPutJobRequest, value: Types.AnalysisConfig) =
            { state with AnalysisConfig = value }

        [<CustomOperation("analysisLimits")>]
        member _.AnalysisLimits(state: MlPutJobRequest, value: Types.AnalysisLimits) =
            { state with AnalysisLimits = Some value }

        [<CustomOperation("backgroundPersistInterval")>]
        member _.BackgroundPersistInterval(state: MlPutJobRequest, value: Types.Duration) =
            { state with BackgroundPersistInterval = Some value }

        [<CustomOperation("customSettings")>]
        member _.CustomSettings(state: MlPutJobRequest, value: Types.CustomSettings) =
            { state with CustomSettings = Some value }

        [<CustomOperation("dailyModelSnapshotRetentionAfterDays")>]
        member _.DailyModelSnapshotRetentionAfterDays(state: MlPutJobRequest, value: Types.Long) =
            { state with DailyModelSnapshotRetentionAfterDays = Some value }

        [<CustomOperation("dataDescription")>]
        member _.DataDescription(state: MlPutJobRequest, value: Types.DataDescription) =
            { state with DataDescription = value }

        [<CustomOperation("datafeedConfig")>]
        member _.DatafeedConfig(state: MlPutJobRequest, value: Types.DatafeedConfig) =
            { state with DatafeedConfig = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: MlPutJobRequest, value: string) =
            { state with Description = Some value }

        [<CustomOperation("jobId")>]
        member _.BodyJobId(state: MlPutJobRequest, value: Types.Id) =
            { state with bodyJobId = Some value }

        [<CustomOperation("groups")>]
        member _.Groups(state: MlPutJobRequest, value: string list) =
            { state with Groups = Some value }

        [<CustomOperation("modelPlotConfig")>]
        member _.ModelPlotConfig(state: MlPutJobRequest, value: Types.ModelPlotConfig) =
            { state with ModelPlotConfig = Some value }

        [<CustomOperation("modelSnapshotRetentionDays")>]
        member _.ModelSnapshotRetentionDays(state: MlPutJobRequest, value: Types.Long) =
            { state with ModelSnapshotRetentionDays = Some value }

        [<CustomOperation("renormalizationWindowDays")>]
        member _.RenormalizationWindowDays(state: MlPutJobRequest, value: Types.Long) =
            { state with RenormalizationWindowDays = Some value }

        [<CustomOperation("resultsIndexName")>]
        member _.ResultsIndexName(state: MlPutJobRequest, value: Types.IndexName) =
            { state with ResultsIndexName = Some value }

        [<CustomOperation("resultsRetentionDays")>]
        member _.ResultsRetentionDays(state: MlPutJobRequest, value: Types.Long) =
            { state with ResultsRetentionDays = Some value }

    let mlPutJobRequest = MlPutJobRequestBuilder()

    module PutJob =
        let withAllowNoIndices (value: bool) (req: MlPutJobRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: MlPutJobRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreThrottled (value: bool) (req: MlPutJobRequest) =
            { req with IgnoreThrottled = Some value }
        let withIgnoreUnavailable (value: bool) (req: MlPutJobRequest) =
            { req with IgnoreUnavailable = Some value }
        let withAllowLazyOpen (value: bool) (req: MlPutJobRequest) =
            { req with AllowLazyOpen = Some value }
        let withAnalysisConfig (value: Types.AnalysisConfig) (req: MlPutJobRequest) =
            { req with AnalysisConfig = value }
        let withAnalysisLimits (value: Types.AnalysisLimits) (req: MlPutJobRequest) =
            { req with AnalysisLimits = Some value }
        let withBackgroundPersistInterval (value: Types.Duration) (req: MlPutJobRequest) =
            { req with BackgroundPersistInterval = Some value }
        let withCustomSettings (value: Types.CustomSettings) (req: MlPutJobRequest) =
            { req with CustomSettings = Some value }
        let withDailyModelSnapshotRetentionAfterDays (value: Types.Long) (req: MlPutJobRequest) =
            { req with DailyModelSnapshotRetentionAfterDays = Some value }
        let withDataDescription (value: Types.DataDescription) (req: MlPutJobRequest) =
            { req with DataDescription = value }
        let withDatafeedConfig (value: Types.DatafeedConfig) (req: MlPutJobRequest) =
            { req with DatafeedConfig = Some value }
        let withDescription (value: string) (req: MlPutJobRequest) =
            { req with Description = Some value }
        let withBodyJobId (value: Types.Id) (req: MlPutJobRequest) =
            { req with bodyJobId = Some value }
        let withGroups (value: string list) (req: MlPutJobRequest) =
            { req with Groups = Some value }
        let withModelPlotConfig (value: Types.ModelPlotConfig) (req: MlPutJobRequest) =
            { req with ModelPlotConfig = Some value }
        let withModelSnapshotRetentionDays (value: Types.Long) (req: MlPutJobRequest) =
            { req with ModelSnapshotRetentionDays = Some value }
        let withRenormalizationWindowDays (value: Types.Long) (req: MlPutJobRequest) =
            { req with RenormalizationWindowDays = Some value }
        let withResultsIndexName (value: Types.IndexName) (req: MlPutJobRequest) =
            { req with ResultsIndexName = Some value }
        let withResultsRetentionDays (value: Types.Long) (req: MlPutJobRequest) =
            { req with ResultsRetentionDays = Some value }

    type MlPutTrainedModelRequest = {
        ModelId: Types.Id
        DeferDefinitionDecompression: bool option
        WaitForCompletion: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("compressed_definition")>]
        CompressedDefinition: string option
        [<System.Text.Json.Serialization.JsonPropertyName("definition")>]
        Definition: Types.Definition option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_config")>]
        InferenceConfig: Types.InferenceConfigCreateContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("input")>]
        Input: Types.Input option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("model_type")>]
        ModelType: Types.TrainedModelType option
        [<System.Text.Json.Serialization.JsonPropertyName("model_size_bytes")>]
        ModelSizeBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("platform_architecture")>]
        PlatformArchitecture: string option
        [<System.Text.Json.Serialization.JsonPropertyName("tags")>]
        Tags: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix_strings")>]
        PrefixStrings: Types.TrainedModelPrefixStrings option
    }

        with
        static member ToEndpoint(req: MlPutTrainedModelRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/trained_models/{Fes.Http.toPathSegment req.ModelId}"
            let queryParams =
                [
                    req.DeferDefinitionDecompression |> Option.map (fun v -> "defer_definition_decompression", Fes.Http.toQueryValue v)
                    req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type MlPutTrainedModelResponse = Types.TrainedModelConfig

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
        member _.ModelId(state: MlPutTrainedModelRequest, value: Types.Id) =
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
        member _.Definition(state: MlPutTrainedModelRequest, value: Types.Definition) =
            { state with Definition = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: MlPutTrainedModelRequest, value: string) =
            { state with Description = Some value }

        [<CustomOperation("inferenceConfig")>]
        member _.InferenceConfig(state: MlPutTrainedModelRequest, value: Types.InferenceConfigCreateContainer) =
            { state with InferenceConfig = Some value }

        [<CustomOperation("input")>]
        member _.Input(state: MlPutTrainedModelRequest, value: Types.Input) =
            { state with Input = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: MlPutTrainedModelRequest, value: System.Text.Json.JsonElement) =
            { state with Metadata = Some value }

        [<CustomOperation("modelType")>]
        member _.ModelType(state: MlPutTrainedModelRequest, value: Types.TrainedModelType) =
            { state with ModelType = Some value }

        [<CustomOperation("modelSizeBytes")>]
        member _.ModelSizeBytes(state: MlPutTrainedModelRequest, value: Types.Long) =
            { state with ModelSizeBytes = Some value }

        [<CustomOperation("platformArchitecture")>]
        member _.PlatformArchitecture(state: MlPutTrainedModelRequest, value: string) =
            { state with PlatformArchitecture = Some value }

        [<CustomOperation("tags")>]
        member _.Tags(state: MlPutTrainedModelRequest, value: string list) =
            { state with Tags = Some value }

        [<CustomOperation("prefixStrings")>]
        member _.PrefixStrings(state: MlPutTrainedModelRequest, value: Types.TrainedModelPrefixStrings) =
            { state with PrefixStrings = Some value }

    let mlPutTrainedModelRequest = MlPutTrainedModelRequestBuilder()

    module PutTrainedModel =
        let withDeferDefinitionDecompression (value: bool) (req: MlPutTrainedModelRequest) =
            { req with DeferDefinitionDecompression = Some value }
        let withWaitForCompletion (value: bool) (req: MlPutTrainedModelRequest) =
            { req with WaitForCompletion = Some value }
        let withCompressedDefinition (value: string) (req: MlPutTrainedModelRequest) =
            { req with CompressedDefinition = Some value }
        let withDefinition (value: Types.Definition) (req: MlPutTrainedModelRequest) =
            { req with Definition = Some value }
        let withDescription (value: string) (req: MlPutTrainedModelRequest) =
            { req with Description = Some value }
        let withInferenceConfig (value: Types.InferenceConfigCreateContainer) (req: MlPutTrainedModelRequest) =
            { req with InferenceConfig = Some value }
        let withInput (value: Types.Input) (req: MlPutTrainedModelRequest) =
            { req with Input = Some value }
        let withMetadata (value: System.Text.Json.JsonElement) (req: MlPutTrainedModelRequest) =
            { req with Metadata = Some value }
        let withModelType (value: Types.TrainedModelType) (req: MlPutTrainedModelRequest) =
            { req with ModelType = Some value }
        let withModelSizeBytes (value: Types.Long) (req: MlPutTrainedModelRequest) =
            { req with ModelSizeBytes = Some value }
        let withPlatformArchitecture (value: string) (req: MlPutTrainedModelRequest) =
            { req with PlatformArchitecture = Some value }
        let withTags (value: string list) (req: MlPutTrainedModelRequest) =
            { req with Tags = Some value }
        let withPrefixStrings (value: Types.TrainedModelPrefixStrings) (req: MlPutTrainedModelRequest) =
            { req with PrefixStrings = Some value }

    type MlPutTrainedModelAliasRequest = {
        ModelAlias: Types.Name
        ModelId: Types.Id
        Reassign: bool option
    }

        with
        static member ToEndpoint(req: MlPutTrainedModelAliasRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/trained_models/{Fes.Http.toPathSegment req.ModelId}/model_aliases/{Fes.Http.toPathSegment req.ModelAlias}"
            let queryParams =
                [
                    req.Reassign |> Option.map (fun v -> "reassign", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            endpoint, ValueNone

    type MlPutTrainedModelAliasResponse = Types.AcknowledgedResponseBase

    type MlPutTrainedModelAliasRequestBuilder() =
        member _.Yield(_: unit) : MlPutTrainedModelAliasRequest =
            {
                ModelAlias = Unchecked.defaultof<_>
                ModelId = Unchecked.defaultof<_>
                Reassign = None
            }

        [<CustomOperation("modelAlias")>]
        member _.ModelAlias(state: MlPutTrainedModelAliasRequest, value: Types.Name) =
            { state with ModelAlias = value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: MlPutTrainedModelAliasRequest, value: Types.Id) =
            { state with ModelId = value }

        [<CustomOperation("reassign")>]
        member _.Reassign(state: MlPutTrainedModelAliasRequest, value: bool) =
            { state with Reassign = Some value }

    let mlPutTrainedModelAliasRequest = MlPutTrainedModelAliasRequestBuilder()

    module PutTrainedModelAlias =
        let withReassign (value: bool) (req: MlPutTrainedModelAliasRequest) =
            { req with Reassign = Some value }

    type MlPutTrainedModelDefinitionPartRequest = {
        ModelId: Types.Id
        Part: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("definition")>]
        Definition: string
        [<System.Text.Json.Serialization.JsonPropertyName("total_definition_length")>]
        TotalDefinitionLength: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_parts")>]
        TotalParts: Types.Integer
    }

        with
        static member ToEndpoint(req: MlPutTrainedModelDefinitionPartRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/trained_models/{Fes.Http.toPathSegment req.ModelId}/definition/{Fes.Http.toPathSegment req.Part}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type MlPutTrainedModelDefinitionPartResponse = Types.AcknowledgedResponseBase

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
        member _.ModelId(state: MlPutTrainedModelDefinitionPartRequest, value: Types.Id) =
            { state with ModelId = value }

        [<CustomOperation("part")>]
        member _.Part(state: MlPutTrainedModelDefinitionPartRequest, value: Types.Integer) =
            { state with Part = value }

        [<CustomOperation("definition")>]
        member _.Definition(state: MlPutTrainedModelDefinitionPartRequest, value: string) =
            { state with Definition = value }

        [<CustomOperation("totalDefinitionLength")>]
        member _.TotalDefinitionLength(state: MlPutTrainedModelDefinitionPartRequest, value: Types.Long) =
            { state with TotalDefinitionLength = value }

        [<CustomOperation("totalParts")>]
        member _.TotalParts(state: MlPutTrainedModelDefinitionPartRequest, value: Types.Integer) =
            { state with TotalParts = value }

    let mlPutTrainedModelDefinitionPartRequest = MlPutTrainedModelDefinitionPartRequestBuilder()

    module PutTrainedModelDefinitionPart =
        let withDefinition (value: string) (req: MlPutTrainedModelDefinitionPartRequest) =
            { req with Definition = value }
        let withTotalDefinitionLength (value: Types.Long) (req: MlPutTrainedModelDefinitionPartRequest) =
            { req with TotalDefinitionLength = value }
        let withTotalParts (value: Types.Integer) (req: MlPutTrainedModelDefinitionPartRequest) =
            { req with TotalParts = value }

    type MlPutTrainedModelVocabularyRequest = {
        ModelId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("vocabulary")>]
        Vocabulary: string list
        [<System.Text.Json.Serialization.JsonPropertyName("merges")>]
        Merges: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("scores")>]
        Scores: Types.Double list option
    }

        with
        static member ToEndpoint(req: MlPutTrainedModelVocabularyRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/trained_models/{Fes.Http.toPathSegment req.ModelId}/vocabulary"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type MlPutTrainedModelVocabularyResponse = Types.AcknowledgedResponseBase

    type MlPutTrainedModelVocabularyRequestBuilder() =
        member _.Yield(_: unit) : MlPutTrainedModelVocabularyRequest =
            {
                ModelId = Unchecked.defaultof<_>
                Vocabulary = Unchecked.defaultof<_>
                Merges = None
                Scores = None
            }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: MlPutTrainedModelVocabularyRequest, value: Types.Id) =
            { state with ModelId = value }

        [<CustomOperation("vocabulary")>]
        member _.Vocabulary(state: MlPutTrainedModelVocabularyRequest, value: string list) =
            { state with Vocabulary = value }

        [<CustomOperation("merges")>]
        member _.Merges(state: MlPutTrainedModelVocabularyRequest, value: string list) =
            { state with Merges = Some value }

        [<CustomOperation("scores")>]
        member _.Scores(state: MlPutTrainedModelVocabularyRequest, value: Types.Double list) =
            { state with Scores = Some value }

    let mlPutTrainedModelVocabularyRequest = MlPutTrainedModelVocabularyRequestBuilder()

    module PutTrainedModelVocabulary =
        let withVocabulary (value: string list) (req: MlPutTrainedModelVocabularyRequest) =
            { req with Vocabulary = value }
        let withMerges (value: string list) (req: MlPutTrainedModelVocabularyRequest) =
            { req with Merges = Some value }
        let withScores (value: Types.Double list) (req: MlPutTrainedModelVocabularyRequest) =
            { req with Scores = Some value }

    type MlResetJobRequest = {
        JobId: Types.Id
        WaitForCompletion: bool option
        DeleteUserAnnotations: bool option
    }

        with
        static member ToEndpoint(req: MlResetJobRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/{Fes.Http.toPathSegment req.JobId}/_reset"
            let queryParams =
                [
                    req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                    req.DeleteUserAnnotations |> Option.map (fun v -> "delete_user_annotations", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            endpoint, ValueNone

    type MlResetJobResponse = Types.AcknowledgedResponseBase

    type MlResetJobRequestBuilder() =
        member _.Yield(_: unit) : MlResetJobRequest =
            {
                JobId = Unchecked.defaultof<_>
                WaitForCompletion = None
                DeleteUserAnnotations = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlResetJobRequest, value: Types.Id) =
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
        JobId: Types.Id
        SnapshotId: Types.Id
        DeleteInterveningResults: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("delete_intervening_results")>]
        bodyDeleteInterveningResults: bool option
    }

        with
        static member ToEndpoint(req: MlRevertModelSnapshotRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/{Fes.Http.toPathSegment req.JobId}/model_snapshots/{Fes.Http.toPathSegment req.SnapshotId}/_revert"
            let queryParams =
                [
                    req.DeleteInterveningResults |> Option.map (fun v -> "delete_intervening_results", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type MlRevertModelSnapshotResponse = System.Text.Json.JsonElement

    type MlRevertModelSnapshotRequestBuilder() =
        member _.Yield(_: unit) : MlRevertModelSnapshotRequest =
            {
                JobId = Unchecked.defaultof<_>
                SnapshotId = Unchecked.defaultof<_>
                DeleteInterveningResults = None
                bodyDeleteInterveningResults = None
            }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlRevertModelSnapshotRequest, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("snapshotId")>]
        member _.SnapshotId(state: MlRevertModelSnapshotRequest, value: Types.Id) =
            { state with SnapshotId = value }

        [<CustomOperation("deleteInterveningResults")>]
        member _.DeleteInterveningResults(state: MlRevertModelSnapshotRequest, value: bool) =
            { state with DeleteInterveningResults = Some value }

        [<CustomOperation("bodyDeleteInterveningResults")>]
        member _.BodyDeleteInterveningResults(state: MlRevertModelSnapshotRequest, value: bool) =
            { state with bodyDeleteInterveningResults = Some value }

    let mlRevertModelSnapshotRequest = MlRevertModelSnapshotRequestBuilder()

    module RevertModelSnapshot =
        let withDeleteInterveningResults (value: bool) (req: MlRevertModelSnapshotRequest) =
            { req with DeleteInterveningResults = Some value }
        let withBodyDeleteInterveningResults (value: bool) (req: MlRevertModelSnapshotRequest) =
            { req with bodyDeleteInterveningResults = Some value }

    type MlSetUpgradeModeRequest = {
        Enabled: bool option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: MlSetUpgradeModeRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            endpoint, ValueNone

    type MlSetUpgradeModeResponse = Types.AcknowledgedResponseBase

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
        member _.Timeout(state: MlSetUpgradeModeRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let mlSetUpgradeModeRequest = MlSetUpgradeModeRequestBuilder()

    module SetUpgradeMode =
        let withEnabled (value: bool) (req: MlSetUpgradeModeRequest) =
            { req with Enabled = Some value }
        let withTimeout (value: Types.Duration) (req: MlSetUpgradeModeRequest) =
            { req with Timeout = Some value }

    type MlStartDataFrameAnalyticsRequest = {
        Id: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        bodyId: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("timeout")>]
        bodyTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: MlStartDataFrameAnalyticsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/data_frame/analytics/{Fes.Http.toPathSegment req.Id}/_start"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type MlStartDataFrameAnalyticsResponse = System.Text.Json.JsonElement

    type MlStartDataFrameAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : MlStartDataFrameAnalyticsRequest =
            {
                Id = Unchecked.defaultof<_>
                Timeout = None
                bodyId = None
                bodyTimeout = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: MlStartDataFrameAnalyticsRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlStartDataFrameAnalyticsRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("id")>]
        member _.BodyId(state: MlStartDataFrameAnalyticsRequest, value: Types.Id) =
            { state with bodyId = Some value }

        [<CustomOperation("bodyTimeout")>]
        member _.BodyTimeout(state: MlStartDataFrameAnalyticsRequest, value: Types.Duration) =
            { state with bodyTimeout = Some value }

    let mlStartDataFrameAnalyticsRequest = MlStartDataFrameAnalyticsRequestBuilder()

    module StartDataFrameAnalytics =
        let withTimeout (value: Types.Duration) (req: MlStartDataFrameAnalyticsRequest) =
            { req with Timeout = Some value }
        let withBodyId (value: Types.Id) (req: MlStartDataFrameAnalyticsRequest) =
            { req with bodyId = Some value }
        let withBodyTimeout (value: Types.Duration) (req: MlStartDataFrameAnalyticsRequest) =
            { req with bodyTimeout = Some value }

    type MlStartDatafeedRequest = {
        DatafeedId: Types.Id
        End: Types.DateTime option
        Start: Types.DateTime option
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("end")>]
        bodyEnd: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("start")>]
        bodyStart: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("timeout")>]
        bodyTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: MlStartDatafeedRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/datafeeds/{Fes.Http.toPathSegment req.DatafeedId}/_start"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type MlStartDatafeedResponse = System.Text.Json.JsonElement

    type MlStartDatafeedRequestBuilder() =
        member _.Yield(_: unit) : MlStartDatafeedRequest =
            {
                DatafeedId = Unchecked.defaultof<_>
                End = None
                Start = None
                Timeout = None
                bodyEnd = None
                bodyStart = None
                bodyTimeout = None
            }

        [<CustomOperation("datafeedId")>]
        member _.DatafeedId(state: MlStartDatafeedRequest, value: Types.Id) =
            { state with DatafeedId = value }

        [<CustomOperation("end'")>]
        member _.End(state: MlStartDatafeedRequest, value: Types.DateTime) =
            { state with End = Some value }

        [<CustomOperation("start")>]
        member _.Start(state: MlStartDatafeedRequest, value: Types.DateTime) =
            { state with Start = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlStartDatafeedRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("bodyEnd")>]
        member _.BodyEnd(state: MlStartDatafeedRequest, value: Types.DateTime) =
            { state with bodyEnd = Some value }

        [<CustomOperation("bodyStart")>]
        member _.BodyStart(state: MlStartDatafeedRequest, value: Types.DateTime) =
            { state with bodyStart = Some value }

        [<CustomOperation("bodyTimeout")>]
        member _.BodyTimeout(state: MlStartDatafeedRequest, value: Types.Duration) =
            { state with bodyTimeout = Some value }

    let mlStartDatafeedRequest = MlStartDatafeedRequestBuilder()

    module StartDatafeed =
        let withEnd (value: Types.DateTime) (req: MlStartDatafeedRequest) =
            { req with End = Some value }
        let withStart (value: Types.DateTime) (req: MlStartDatafeedRequest) =
            { req with Start = Some value }
        let withTimeout (value: Types.Duration) (req: MlStartDatafeedRequest) =
            { req with Timeout = Some value }
        let withBodyEnd (value: Types.DateTime) (req: MlStartDatafeedRequest) =
            { req with bodyEnd = Some value }
        let withBodyStart (value: Types.DateTime) (req: MlStartDatafeedRequest) =
            { req with bodyStart = Some value }
        let withBodyTimeout (value: Types.Duration) (req: MlStartDatafeedRequest) =
            { req with bodyTimeout = Some value }

    type MlStartTrainedModelDeploymentRequest = {
        ModelId: Types.Id
        CacheSize: Types.ByteSize option
        DeploymentId: string option
        NumberOfAllocations: Types.Integer option
        Priority: Types.TrainingPriority option
        QueueCapacity: Types.Integer option
        ThreadsPerAllocation: Types.Integer option
        Timeout: Types.Duration option
        WaitFor: Types.DeploymentAllocationState option
        [<System.Text.Json.Serialization.JsonPropertyName("adaptive_allocations")>]
        AdaptiveAllocations: Types.AdaptiveAllocationsSettings option
    }

        with
        static member ToEndpoint(req: MlStartTrainedModelDeploymentRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/trained_models/{Fes.Http.toPathSegment req.ModelId}/deployment/_start"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.ModelId(state: MlStartTrainedModelDeploymentRequest, value: Types.Id) =
            { state with ModelId = value }

        [<CustomOperation("cacheSize")>]
        member _.CacheSize(state: MlStartTrainedModelDeploymentRequest, value: Types.ByteSize) =
            { state with CacheSize = Some value }

        [<CustomOperation("deploymentId")>]
        member _.DeploymentId(state: MlStartTrainedModelDeploymentRequest, value: string) =
            { state with DeploymentId = Some value }

        [<CustomOperation("numberOfAllocations")>]
        member _.NumberOfAllocations(state: MlStartTrainedModelDeploymentRequest, value: Types.Integer) =
            { state with NumberOfAllocations = Some value }

        [<CustomOperation("priority")>]
        member _.Priority(state: MlStartTrainedModelDeploymentRequest, value: Types.TrainingPriority) =
            { state with Priority = Some value }

        [<CustomOperation("queueCapacity")>]
        member _.QueueCapacity(state: MlStartTrainedModelDeploymentRequest, value: Types.Integer) =
            { state with QueueCapacity = Some value }

        [<CustomOperation("threadsPerAllocation")>]
        member _.ThreadsPerAllocation(state: MlStartTrainedModelDeploymentRequest, value: Types.Integer) =
            { state with ThreadsPerAllocation = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlStartTrainedModelDeploymentRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("waitFor")>]
        member _.WaitFor(state: MlStartTrainedModelDeploymentRequest, value: Types.DeploymentAllocationState) =
            { state with WaitFor = Some value }

        [<CustomOperation("adaptiveAllocations")>]
        member _.AdaptiveAllocations(state: MlStartTrainedModelDeploymentRequest, value: Types.AdaptiveAllocationsSettings) =
            { state with AdaptiveAllocations = Some value }

    let mlStartTrainedModelDeploymentRequest = MlStartTrainedModelDeploymentRequestBuilder()

    module StartTrainedModelDeployment =
        let withCacheSize (value: Types.ByteSize) (req: MlStartTrainedModelDeploymentRequest) =
            { req with CacheSize = Some value }
        let withDeploymentId (value: string) (req: MlStartTrainedModelDeploymentRequest) =
            { req with DeploymentId = Some value }
        let withNumberOfAllocations (value: Types.Integer) (req: MlStartTrainedModelDeploymentRequest) =
            { req with NumberOfAllocations = Some value }
        let withPriority (value: Types.TrainingPriority) (req: MlStartTrainedModelDeploymentRequest) =
            { req with Priority = Some value }
        let withQueueCapacity (value: Types.Integer) (req: MlStartTrainedModelDeploymentRequest) =
            { req with QueueCapacity = Some value }
        let withThreadsPerAllocation (value: Types.Integer) (req: MlStartTrainedModelDeploymentRequest) =
            { req with ThreadsPerAllocation = Some value }
        let withTimeout (value: Types.Duration) (req: MlStartTrainedModelDeploymentRequest) =
            { req with Timeout = Some value }
        let withWaitFor (value: Types.DeploymentAllocationState) (req: MlStartTrainedModelDeploymentRequest) =
            { req with WaitFor = Some value }
        let withAdaptiveAllocations (value: Types.AdaptiveAllocationsSettings) (req: MlStartTrainedModelDeploymentRequest) =
            { req with AdaptiveAllocations = Some value }

    type MlStopDataFrameAnalyticsRequest = {
        Id: Types.Id
        AllowNoMatch: bool option
        Force: bool option
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        bodyId: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_no_match")>]
        bodyAllowNoMatch: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("force")>]
        bodyForce: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("timeout")>]
        bodyTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: MlStopDataFrameAnalyticsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/data_frame/analytics/{Fes.Http.toPathSegment req.Id}/_stop"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type MlStopDataFrameAnalyticsResponse = System.Text.Json.JsonElement

    type MlStopDataFrameAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : MlStopDataFrameAnalyticsRequest =
            {
                Id = Unchecked.defaultof<_>
                AllowNoMatch = None
                Force = None
                Timeout = None
                bodyId = None
                bodyAllowNoMatch = None
                bodyForce = None
                bodyTimeout = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: MlStopDataFrameAnalyticsRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlStopDataFrameAnalyticsRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("force")>]
        member _.Force(state: MlStopDataFrameAnalyticsRequest, value: bool) =
            { state with Force = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlStopDataFrameAnalyticsRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("id")>]
        member _.BodyId(state: MlStopDataFrameAnalyticsRequest, value: Types.Id) =
            { state with bodyId = Some value }

        [<CustomOperation("bodyAllowNoMatch")>]
        member _.BodyAllowNoMatch(state: MlStopDataFrameAnalyticsRequest, value: bool) =
            { state with bodyAllowNoMatch = Some value }

        [<CustomOperation("bodyForce")>]
        member _.BodyForce(state: MlStopDataFrameAnalyticsRequest, value: bool) =
            { state with bodyForce = Some value }

        [<CustomOperation("bodyTimeout")>]
        member _.BodyTimeout(state: MlStopDataFrameAnalyticsRequest, value: Types.Duration) =
            { state with bodyTimeout = Some value }

    let mlStopDataFrameAnalyticsRequest = MlStopDataFrameAnalyticsRequestBuilder()

    module StopDataFrameAnalytics =
        let withAllowNoMatch (value: bool) (req: MlStopDataFrameAnalyticsRequest) =
            { req with AllowNoMatch = Some value }
        let withForce (value: bool) (req: MlStopDataFrameAnalyticsRequest) =
            { req with Force = Some value }
        let withTimeout (value: Types.Duration) (req: MlStopDataFrameAnalyticsRequest) =
            { req with Timeout = Some value }
        let withBodyId (value: Types.Id) (req: MlStopDataFrameAnalyticsRequest) =
            { req with bodyId = Some value }
        let withBodyAllowNoMatch (value: bool) (req: MlStopDataFrameAnalyticsRequest) =
            { req with bodyAllowNoMatch = Some value }
        let withBodyForce (value: bool) (req: MlStopDataFrameAnalyticsRequest) =
            { req with bodyForce = Some value }
        let withBodyTimeout (value: Types.Duration) (req: MlStopDataFrameAnalyticsRequest) =
            { req with bodyTimeout = Some value }

    type MlStopDatafeedRequest = {
        DatafeedId: Types.Id
        AllowNoMatch: bool option
        Force: bool option
        Timeout: Types.Duration option
        CloseJob: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_no_match")>]
        bodyAllowNoMatch: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("force")>]
        bodyForce: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("timeout")>]
        bodyTimeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("close_job")>]
        bodyCloseJob: bool option
    }

        with
        static member ToEndpoint(req: MlStopDatafeedRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/datafeeds/{Fes.Http.toPathSegment req.DatafeedId}/_stop"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type MlStopDatafeedResponse = System.Text.Json.JsonElement

    type MlStopDatafeedRequestBuilder() =
        member _.Yield(_: unit) : MlStopDatafeedRequest =
            {
                DatafeedId = Unchecked.defaultof<_>
                AllowNoMatch = None
                Force = None
                Timeout = None
                CloseJob = None
                bodyAllowNoMatch = None
                bodyForce = None
                bodyTimeout = None
                bodyCloseJob = None
            }

        [<CustomOperation("datafeedId")>]
        member _.DatafeedId(state: MlStopDatafeedRequest, value: Types.Id) =
            { state with DatafeedId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlStopDatafeedRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("force")>]
        member _.Force(state: MlStopDatafeedRequest, value: bool) =
            { state with Force = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlStopDatafeedRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("closeJob")>]
        member _.CloseJob(state: MlStopDatafeedRequest, value: bool) =
            { state with CloseJob = Some value }

        [<CustomOperation("bodyAllowNoMatch")>]
        member _.BodyAllowNoMatch(state: MlStopDatafeedRequest, value: bool) =
            { state with bodyAllowNoMatch = Some value }

        [<CustomOperation("bodyForce")>]
        member _.BodyForce(state: MlStopDatafeedRequest, value: bool) =
            { state with bodyForce = Some value }

        [<CustomOperation("bodyTimeout")>]
        member _.BodyTimeout(state: MlStopDatafeedRequest, value: Types.Duration) =
            { state with bodyTimeout = Some value }

        [<CustomOperation("bodyCloseJob")>]
        member _.BodyCloseJob(state: MlStopDatafeedRequest, value: bool) =
            { state with bodyCloseJob = Some value }

    let mlStopDatafeedRequest = MlStopDatafeedRequestBuilder()

    module StopDatafeed =
        let withAllowNoMatch (value: bool) (req: MlStopDatafeedRequest) =
            { req with AllowNoMatch = Some value }
        let withForce (value: bool) (req: MlStopDatafeedRequest) =
            { req with Force = Some value }
        let withTimeout (value: Types.Duration) (req: MlStopDatafeedRequest) =
            { req with Timeout = Some value }
        let withCloseJob (value: bool) (req: MlStopDatafeedRequest) =
            { req with CloseJob = Some value }
        let withBodyAllowNoMatch (value: bool) (req: MlStopDatafeedRequest) =
            { req with bodyAllowNoMatch = Some value }
        let withBodyForce (value: bool) (req: MlStopDatafeedRequest) =
            { req with bodyForce = Some value }
        let withBodyTimeout (value: Types.Duration) (req: MlStopDatafeedRequest) =
            { req with bodyTimeout = Some value }
        let withBodyCloseJob (value: bool) (req: MlStopDatafeedRequest) =
            { req with bodyCloseJob = Some value }

    type MlStopTrainedModelDeploymentRequest = {
        ModelId: Types.Id
        AllowNoMatch: bool option
        Force: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_no_match")>]
        bodyAllowNoMatch: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("force")>]
        bodyForce: bool option
    }

        with
        static member ToEndpoint(req: MlStopTrainedModelDeploymentRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/trained_models/{Fes.Http.toPathSegment req.ModelId}/deployment/_stop"
            let queryParams =
                [
                    req.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                    req.Force |> Option.map (fun v -> "force", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type MlStopTrainedModelDeploymentResponse = System.Text.Json.JsonElement

    type MlStopTrainedModelDeploymentRequestBuilder() =
        member _.Yield(_: unit) : MlStopTrainedModelDeploymentRequest =
            {
                ModelId = Unchecked.defaultof<_>
                AllowNoMatch = None
                Force = None
                Id = None
                bodyAllowNoMatch = None
                bodyForce = None
            }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: MlStopTrainedModelDeploymentRequest, value: Types.Id) =
            { state with ModelId = value }

        [<CustomOperation("allowNoMatch")>]
        member _.AllowNoMatch(state: MlStopTrainedModelDeploymentRequest, value: bool) =
            { state with AllowNoMatch = Some value }

        [<CustomOperation("force")>]
        member _.Force(state: MlStopTrainedModelDeploymentRequest, value: bool) =
            { state with Force = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: MlStopTrainedModelDeploymentRequest, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("bodyAllowNoMatch")>]
        member _.BodyAllowNoMatch(state: MlStopTrainedModelDeploymentRequest, value: bool) =
            { state with bodyAllowNoMatch = Some value }

        [<CustomOperation("bodyForce")>]
        member _.BodyForce(state: MlStopTrainedModelDeploymentRequest, value: bool) =
            { state with bodyForce = Some value }

    let mlStopTrainedModelDeploymentRequest = MlStopTrainedModelDeploymentRequestBuilder()

    module StopTrainedModelDeployment =
        let withAllowNoMatch (value: bool) (req: MlStopTrainedModelDeploymentRequest) =
            { req with AllowNoMatch = Some value }
        let withForce (value: bool) (req: MlStopTrainedModelDeploymentRequest) =
            { req with Force = Some value }
        let withId (value: Types.Id) (req: MlStopTrainedModelDeploymentRequest) =
            { req with Id = Some value }
        let withBodyAllowNoMatch (value: bool) (req: MlStopTrainedModelDeploymentRequest) =
            { req with bodyAllowNoMatch = Some value }
        let withBodyForce (value: bool) (req: MlStopTrainedModelDeploymentRequest) =
            { req with bodyForce = Some value }

    type MlUpdateDataFrameAnalyticsRequest = {
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model_memory_limit")>]
        ModelMemoryLimit: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_num_threads")>]
        MaxNumThreads: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_lazy_start")>]
        AllowLazyStart: bool option
    }

        with
        static member ToEndpoint(req: MlUpdateDataFrameAnalyticsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/data_frame/analytics/{Fes.Http.toPathSegment req.Id}/_update"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.Id(state: MlUpdateDataFrameAnalyticsRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("description")>]
        member _.Description(state: MlUpdateDataFrameAnalyticsRequest, value: string) =
            { state with Description = Some value }

        [<CustomOperation("modelMemoryLimit")>]
        member _.ModelMemoryLimit(state: MlUpdateDataFrameAnalyticsRequest, value: string) =
            { state with ModelMemoryLimit = Some value }

        [<CustomOperation("maxNumThreads")>]
        member _.MaxNumThreads(state: MlUpdateDataFrameAnalyticsRequest, value: Types.Integer) =
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
        let withMaxNumThreads (value: Types.Integer) (req: MlUpdateDataFrameAnalyticsRequest) =
            { req with MaxNumThreads = Some value }
        let withAllowLazyStart (value: bool) (req: MlUpdateDataFrameAnalyticsRequest) =
            { req with AllowLazyStart = Some value }

    type MlUpdateDatafeedRequest = {
        DatafeedId: Types.Id
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreThrottled: bool option
        IgnoreUnavailable: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("aggregations")>]
        Aggregations: Map<string, Types.AggregationContainer> option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_config")>]
        ChunkingConfig: Types.ChunkingConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("delayed_data_check_config")>]
        DelayedDataCheckConfig: Types.DelayedDataCheckConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("frequency")>]
        Frequency: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("indices_options")>]
        IndicesOptions: Types.IndicesOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("max_empty_searches")>]
        MaxEmptySearches: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: Types.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("query_delay")>]
        QueryDelay: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: Types.RuntimeFields option
        [<System.Text.Json.Serialization.JsonPropertyName("script_fields")>]
        ScriptFields: Map<string, Types.ScriptField> option
        [<System.Text.Json.Serialization.JsonPropertyName("scroll_size")>]
        ScrollSize: Types.Integer option
    }

        with
        static member ToEndpoint(req: MlUpdateDatafeedRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/datafeeds/{Fes.Http.toPathSegment req.DatafeedId}/_update"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.DatafeedId(state: MlUpdateDatafeedRequest, value: Types.Id) =
            { state with DatafeedId = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: MlUpdateDatafeedRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: MlUpdateDatafeedRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreThrottled")>]
        member _.IgnoreThrottled(state: MlUpdateDatafeedRequest, value: bool) =
            { state with IgnoreThrottled = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: MlUpdateDatafeedRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: MlUpdateDatafeedRequest, value: Map<string, Types.AggregationContainer>) =
            { state with Aggregations = Some value }

        [<CustomOperation("chunkingConfig")>]
        member _.ChunkingConfig(state: MlUpdateDatafeedRequest, value: Types.ChunkingConfig) =
            { state with ChunkingConfig = Some value }

        [<CustomOperation("delayedDataCheckConfig")>]
        member _.DelayedDataCheckConfig(state: MlUpdateDatafeedRequest, value: Types.DelayedDataCheckConfig) =
            { state with DelayedDataCheckConfig = Some value }

        [<CustomOperation("frequency")>]
        member _.Frequency(state: MlUpdateDatafeedRequest, value: Types.Duration) =
            { state with Frequency = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: MlUpdateDatafeedRequest, value: string list) =
            { state with Indices = Some value }

        [<CustomOperation("indicesOptions")>]
        member _.IndicesOptions(state: MlUpdateDatafeedRequest, value: Types.IndicesOptions) =
            { state with IndicesOptions = Some value }

        [<CustomOperation("jobId")>]
        member _.JobId(state: MlUpdateDatafeedRequest, value: Types.Id) =
            { state with JobId = Some value }

        [<CustomOperation("maxEmptySearches")>]
        member _.MaxEmptySearches(state: MlUpdateDatafeedRequest, value: Types.Integer) =
            { state with MaxEmptySearches = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: MlUpdateDatafeedRequest, value: Types.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("queryDelay")>]
        member _.QueryDelay(state: MlUpdateDatafeedRequest, value: Types.Duration) =
            { state with QueryDelay = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: MlUpdateDatafeedRequest, value: Types.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("scriptFields")>]
        member _.ScriptFields(state: MlUpdateDatafeedRequest, value: Map<string, Types.ScriptField>) =
            { state with ScriptFields = Some value }

        [<CustomOperation("scrollSize")>]
        member _.ScrollSize(state: MlUpdateDatafeedRequest, value: Types.Integer) =
            { state with ScrollSize = Some value }

    let mlUpdateDatafeedRequest = MlUpdateDatafeedRequestBuilder()

    module UpdateDatafeed =
        let withAllowNoIndices (value: bool) (req: MlUpdateDatafeedRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: MlUpdateDatafeedRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreThrottled (value: bool) (req: MlUpdateDatafeedRequest) =
            { req with IgnoreThrottled = Some value }
        let withIgnoreUnavailable (value: bool) (req: MlUpdateDatafeedRequest) =
            { req with IgnoreUnavailable = Some value }
        let withAggregations (value: Map<string, Types.AggregationContainer>) (req: MlUpdateDatafeedRequest) =
            { req with Aggregations = Some value }
        let withChunkingConfig (value: Types.ChunkingConfig) (req: MlUpdateDatafeedRequest) =
            { req with ChunkingConfig = Some value }
        let withDelayedDataCheckConfig (value: Types.DelayedDataCheckConfig) (req: MlUpdateDatafeedRequest) =
            { req with DelayedDataCheckConfig = Some value }
        let withFrequency (value: Types.Duration) (req: MlUpdateDatafeedRequest) =
            { req with Frequency = Some value }
        let withIndices (value: string list) (req: MlUpdateDatafeedRequest) =
            { req with Indices = Some value }
        let withIndicesOptions (value: Types.IndicesOptions) (req: MlUpdateDatafeedRequest) =
            { req with IndicesOptions = Some value }
        let withJobId (value: Types.Id) (req: MlUpdateDatafeedRequest) =
            { req with JobId = Some value }
        let withMaxEmptySearches (value: Types.Integer) (req: MlUpdateDatafeedRequest) =
            { req with MaxEmptySearches = Some value }
        let withQuery (value: Types.QueryContainer) (req: MlUpdateDatafeedRequest) =
            { req with Query = Some value }
        let withQueryDelay (value: Types.Duration) (req: MlUpdateDatafeedRequest) =
            { req with QueryDelay = Some value }
        let withRuntimeMappings (value: Types.RuntimeFields) (req: MlUpdateDatafeedRequest) =
            { req with RuntimeMappings = Some value }
        let withScriptFields (value: Map<string, Types.ScriptField>) (req: MlUpdateDatafeedRequest) =
            { req with ScriptFields = Some value }
        let withScrollSize (value: Types.Integer) (req: MlUpdateDatafeedRequest) =
            { req with ScrollSize = Some value }

    type MlUpdateFilterRequest = {
        FilterId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("add_items")>]
        AddItems: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("remove_items")>]
        RemoveItems: string list option
    }

        with
        static member ToEndpoint(req: MlUpdateFilterRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/filters/{Fes.Http.toPathSegment req.FilterId}/_update"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.FilterId(state: MlUpdateFilterRequest, value: Types.Id) =
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
        JobId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("allow_lazy_open")>]
        AllowLazyOpen: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("analysis_limits")>]
        AnalysisLimits: Types.AnalysisMemoryLimit option
        [<System.Text.Json.Serialization.JsonPropertyName("background_persist_interval")>]
        BackgroundPersistInterval: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("custom_settings")>]
        CustomSettings: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_filters")>]
        CategorizationFilters: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model_plot_config")>]
        ModelPlotConfig: Types.ModelPlotConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("model_prune_window")>]
        ModelPruneWindow: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("daily_model_snapshot_retention_after_days")>]
        DailyModelSnapshotRetentionAfterDays: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("model_snapshot_retention_days")>]
        ModelSnapshotRetentionDays: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("renormalization_window_days")>]
        RenormalizationWindowDays: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("results_retention_days")>]
        ResultsRetentionDays: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("groups")>]
        Groups: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("detectors")>]
        Detectors: Types.DetectorUpdate list option
        [<System.Text.Json.Serialization.JsonPropertyName("per_partition_categorization")>]
        PerPartitionCategorization: Types.PerPartitionCategorization option
    }

        with
        static member ToEndpoint(req: MlUpdateJobRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/{Fes.Http.toPathSegment req.JobId}/_update"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.JobId(state: MlUpdateJobRequest, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("allowLazyOpen")>]
        member _.AllowLazyOpen(state: MlUpdateJobRequest, value: bool) =
            { state with AllowLazyOpen = Some value }

        [<CustomOperation("analysisLimits")>]
        member _.AnalysisLimits(state: MlUpdateJobRequest, value: Types.AnalysisMemoryLimit) =
            { state with AnalysisLimits = Some value }

        [<CustomOperation("backgroundPersistInterval")>]
        member _.BackgroundPersistInterval(state: MlUpdateJobRequest, value: Types.Duration) =
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
        member _.ModelPlotConfig(state: MlUpdateJobRequest, value: Types.ModelPlotConfig) =
            { state with ModelPlotConfig = Some value }

        [<CustomOperation("modelPruneWindow")>]
        member _.ModelPruneWindow(state: MlUpdateJobRequest, value: Types.Duration) =
            { state with ModelPruneWindow = Some value }

        [<CustomOperation("dailyModelSnapshotRetentionAfterDays")>]
        member _.DailyModelSnapshotRetentionAfterDays(state: MlUpdateJobRequest, value: Types.Long) =
            { state with DailyModelSnapshotRetentionAfterDays = Some value }

        [<CustomOperation("modelSnapshotRetentionDays")>]
        member _.ModelSnapshotRetentionDays(state: MlUpdateJobRequest, value: Types.Long) =
            { state with ModelSnapshotRetentionDays = Some value }

        [<CustomOperation("renormalizationWindowDays")>]
        member _.RenormalizationWindowDays(state: MlUpdateJobRequest, value: Types.Long) =
            { state with RenormalizationWindowDays = Some value }

        [<CustomOperation("resultsRetentionDays")>]
        member _.ResultsRetentionDays(state: MlUpdateJobRequest, value: Types.Long) =
            { state with ResultsRetentionDays = Some value }

        [<CustomOperation("groups")>]
        member _.Groups(state: MlUpdateJobRequest, value: string list) =
            { state with Groups = Some value }

        [<CustomOperation("detectors")>]
        member _.Detectors(state: MlUpdateJobRequest, value: Types.DetectorUpdate list) =
            { state with Detectors = Some value }

        [<CustomOperation("perPartitionCategorization")>]
        member _.PerPartitionCategorization(state: MlUpdateJobRequest, value: Types.PerPartitionCategorization) =
            { state with PerPartitionCategorization = Some value }

    let mlUpdateJobRequest = MlUpdateJobRequestBuilder()

    module UpdateJob =
        let withAllowLazyOpen (value: bool) (req: MlUpdateJobRequest) =
            { req with AllowLazyOpen = Some value }
        let withAnalysisLimits (value: Types.AnalysisMemoryLimit) (req: MlUpdateJobRequest) =
            { req with AnalysisLimits = Some value }
        let withBackgroundPersistInterval (value: Types.Duration) (req: MlUpdateJobRequest) =
            { req with BackgroundPersistInterval = Some value }
        let withCustomSettings (value: Map<string, System.Text.Json.JsonElement>) (req: MlUpdateJobRequest) =
            { req with CustomSettings = Some value }
        let withCategorizationFilters (value: string list) (req: MlUpdateJobRequest) =
            { req with CategorizationFilters = Some value }
        let withDescription (value: string) (req: MlUpdateJobRequest) =
            { req with Description = Some value }
        let withModelPlotConfig (value: Types.ModelPlotConfig) (req: MlUpdateJobRequest) =
            { req with ModelPlotConfig = Some value }
        let withModelPruneWindow (value: Types.Duration) (req: MlUpdateJobRequest) =
            { req with ModelPruneWindow = Some value }
        let withDailyModelSnapshotRetentionAfterDays (value: Types.Long) (req: MlUpdateJobRequest) =
            { req with DailyModelSnapshotRetentionAfterDays = Some value }
        let withModelSnapshotRetentionDays (value: Types.Long) (req: MlUpdateJobRequest) =
            { req with ModelSnapshotRetentionDays = Some value }
        let withRenormalizationWindowDays (value: Types.Long) (req: MlUpdateJobRequest) =
            { req with RenormalizationWindowDays = Some value }
        let withResultsRetentionDays (value: Types.Long) (req: MlUpdateJobRequest) =
            { req with ResultsRetentionDays = Some value }
        let withGroups (value: string list) (req: MlUpdateJobRequest) =
            { req with Groups = Some value }
        let withDetectors (value: Types.DetectorUpdate list) (req: MlUpdateJobRequest) =
            { req with Detectors = Some value }
        let withPerPartitionCategorization (value: Types.PerPartitionCategorization) (req: MlUpdateJobRequest) =
            { req with PerPartitionCategorization = Some value }

    type MlUpdateModelSnapshotRequest = {
        JobId: Types.Id
        SnapshotId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("retain")>]
        Retain: bool option
    }

        with
        static member ToEndpoint(req: MlUpdateModelSnapshotRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/{Fes.Http.toPathSegment req.JobId}/model_snapshots/{Fes.Http.toPathSegment req.SnapshotId}/_update"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.JobId(state: MlUpdateModelSnapshotRequest, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("snapshotId")>]
        member _.SnapshotId(state: MlUpdateModelSnapshotRequest, value: Types.Id) =
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
        ModelId: Types.Id
        NumberOfAllocations: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_allocations")>]
        bodyNumberOfAllocations: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("adaptive_allocations")>]
        AdaptiveAllocations: Types.AdaptiveAllocationsSettings option
    }

        with
        static member ToEndpoint(req: MlUpdateTrainedModelDeploymentRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/trained_models/{Fes.Http.toPathSegment req.ModelId}/deployment/_update"
            let queryParams =
                [
                    req.NumberOfAllocations |> Option.map (fun v -> "number_of_allocations", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type MlUpdateTrainedModelDeploymentResponse = System.Text.Json.JsonElement

    type MlUpdateTrainedModelDeploymentRequestBuilder() =
        member _.Yield(_: unit) : MlUpdateTrainedModelDeploymentRequest =
            {
                ModelId = Unchecked.defaultof<_>
                NumberOfAllocations = None
                bodyNumberOfAllocations = None
                AdaptiveAllocations = None
            }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: MlUpdateTrainedModelDeploymentRequest, value: Types.Id) =
            { state with ModelId = value }

        [<CustomOperation("numberOfAllocations")>]
        member _.NumberOfAllocations(state: MlUpdateTrainedModelDeploymentRequest, value: Types.Integer) =
            { state with NumberOfAllocations = Some value }

        [<CustomOperation("bodyNumberOfAllocations")>]
        member _.BodyNumberOfAllocations(state: MlUpdateTrainedModelDeploymentRequest, value: Types.Integer) =
            { state with bodyNumberOfAllocations = Some value }

        [<CustomOperation("adaptiveAllocations")>]
        member _.AdaptiveAllocations(state: MlUpdateTrainedModelDeploymentRequest, value: Types.AdaptiveAllocationsSettings) =
            { state with AdaptiveAllocations = Some value }

    let mlUpdateTrainedModelDeploymentRequest = MlUpdateTrainedModelDeploymentRequestBuilder()

    module UpdateTrainedModelDeployment =
        let withNumberOfAllocations (value: Types.Integer) (req: MlUpdateTrainedModelDeploymentRequest) =
            { req with NumberOfAllocations = Some value }
        let withBodyNumberOfAllocations (value: Types.Integer) (req: MlUpdateTrainedModelDeploymentRequest) =
            { req with bodyNumberOfAllocations = Some value }
        let withAdaptiveAllocations (value: Types.AdaptiveAllocationsSettings) (req: MlUpdateTrainedModelDeploymentRequest) =
            { req with AdaptiveAllocations = Some value }

    type MlUpgradeJobSnapshotRequest = {
        JobId: Types.Id
        SnapshotId: Types.Id
        WaitForCompletion: bool option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: MlUpgradeJobSnapshotRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/{Fes.Http.toPathSegment req.JobId}/model_snapshots/{Fes.Http.toPathSegment req.SnapshotId}/_upgrade"
            let queryParams =
                [
                    req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            endpoint, ValueNone

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
        member _.JobId(state: MlUpgradeJobSnapshotRequest, value: Types.Id) =
            { state with JobId = value }

        [<CustomOperation("snapshotId")>]
        member _.SnapshotId(state: MlUpgradeJobSnapshotRequest, value: Types.Id) =
            { state with SnapshotId = value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: MlUpgradeJobSnapshotRequest, value: bool) =
            { state with WaitForCompletion = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlUpgradeJobSnapshotRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let mlUpgradeJobSnapshotRequest = MlUpgradeJobSnapshotRequestBuilder()

    module UpgradeJobSnapshot =
        let withWaitForCompletion (value: bool) (req: MlUpgradeJobSnapshotRequest) =
            { req with WaitForCompletion = Some value }
        let withTimeout (value: Types.Duration) (req: MlUpgradeJobSnapshotRequest) =
            { req with Timeout = Some value }

    type MlValidateRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("analysis_config")>]
        AnalysisConfig: Types.AnalysisConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("analysis_limits")>]
        AnalysisLimits: Types.AnalysisLimits option
        [<System.Text.Json.Serialization.JsonPropertyName("data_description")>]
        DataDescription: Types.DataDescription option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model_plot")>]
        ModelPlot: Types.ModelPlotConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("model_snapshot_id")>]
        ModelSnapshotId: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("model_snapshot_retention_days")>]
        ModelSnapshotRetentionDays: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("results_index_name")>]
        ResultsIndexName: Types.IndexName option
    }

        with
        static member ToEndpoint(req: MlValidateRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/_validate"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type MlValidateResponse = Types.AcknowledgedResponseBase

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
        member _.JobId(state: MlValidateRequest, value: Types.Id) =
            { state with JobId = Some value }

        [<CustomOperation("analysisConfig")>]
        member _.AnalysisConfig(state: MlValidateRequest, value: Types.AnalysisConfig) =
            { state with AnalysisConfig = Some value }

        [<CustomOperation("analysisLimits")>]
        member _.AnalysisLimits(state: MlValidateRequest, value: Types.AnalysisLimits) =
            { state with AnalysisLimits = Some value }

        [<CustomOperation("dataDescription")>]
        member _.DataDescription(state: MlValidateRequest, value: Types.DataDescription) =
            { state with DataDescription = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: MlValidateRequest, value: string) =
            { state with Description = Some value }

        [<CustomOperation("modelPlot")>]
        member _.ModelPlot(state: MlValidateRequest, value: Types.ModelPlotConfig) =
            { state with ModelPlot = Some value }

        [<CustomOperation("modelSnapshotId")>]
        member _.ModelSnapshotId(state: MlValidateRequest, value: Types.Id) =
            { state with ModelSnapshotId = Some value }

        [<CustomOperation("modelSnapshotRetentionDays")>]
        member _.ModelSnapshotRetentionDays(state: MlValidateRequest, value: Types.Long) =
            { state with ModelSnapshotRetentionDays = Some value }

        [<CustomOperation("resultsIndexName")>]
        member _.ResultsIndexName(state: MlValidateRequest, value: Types.IndexName) =
            { state with ResultsIndexName = Some value }

    let mlValidateRequest = MlValidateRequestBuilder()

    module Validate =
        let withJobId (value: Types.Id) (req: MlValidateRequest) =
            { req with JobId = Some value }
        let withAnalysisConfig (value: Types.AnalysisConfig) (req: MlValidateRequest) =
            { req with AnalysisConfig = Some value }
        let withAnalysisLimits (value: Types.AnalysisLimits) (req: MlValidateRequest) =
            { req with AnalysisLimits = Some value }
        let withDataDescription (value: Types.DataDescription) (req: MlValidateRequest) =
            { req with DataDescription = Some value }
        let withDescription (value: string) (req: MlValidateRequest) =
            { req with Description = Some value }
        let withModelPlot (value: Types.ModelPlotConfig) (req: MlValidateRequest) =
            { req with ModelPlot = Some value }
        let withModelSnapshotId (value: Types.Id) (req: MlValidateRequest) =
            { req with ModelSnapshotId = Some value }
        let withModelSnapshotRetentionDays (value: Types.Long) (req: MlValidateRequest) =
            { req with ModelSnapshotRetentionDays = Some value }
        let withResultsIndexName (value: Types.IndexName) (req: MlValidateRequest) =
            { req with ResultsIndexName = Some value }

    type MlValidateDetectorRequest = {
        Document: Types.Detector
    }

        with
        static member ToEndpoint(req: MlValidateDetectorRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_ml/anomaly_detectors/_validate/detector"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req.Document)
            endpoint, ValueSome postData

    type MlValidateDetectorResponse = Types.AcknowledgedResponseBase

    type MlValidateDetectorRequestBuilder() =
        member _.Yield(_: unit) : MlValidateDetectorRequest =
            {
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("document")>]
        member _.Document(state: MlValidateDetectorRequest, value) =
            { state with Document = value }

    let mlValidateDetectorRequest = MlValidateDetectorRequestBuilder()


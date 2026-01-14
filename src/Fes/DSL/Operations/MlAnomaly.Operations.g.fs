// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module MlAnomalyOperations =

    type MlCloseJobRequest = {
        JobId: Id
        AllowNoMatch: bool option
        Force: bool option
        Timeout: Duration option
        [<JsonPropertyName("allow_no_match")>]
        AllowNoMatch2: bool option
        [<JsonPropertyName("force")>]
        Force2: bool option
        [<JsonPropertyName("timeout")>]
        Timeout2: Duration option
    } with
        static member ToRequest(request: MlCloseJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{request.JobId}/_close"
                let queryParams =
                    [
                        request.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                        request.Force |> Option.map (fun v -> "force", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``allow_no_match`` = request.AllowNoMatch2; ``force`` = request.Force2; ``timeout`` = request.Timeout2 |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlCloseJobRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlCloseJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlCloseJobRequest.ToRequest request

    type MlCloseJobRequestBuilder() =
        member _.Yield(_: unit) : MlCloseJobRequest =
            {
                MlCloseJobRequest.JobId = Unchecked.defaultof<Id>
                MlCloseJobRequest.AllowNoMatch = Option.None
                MlCloseJobRequest.Force = Option.None
                MlCloseJobRequest.Timeout = Option.None
                MlCloseJobRequest.AllowNoMatch2 = Option.None
                MlCloseJobRequest.Force2 = Option.None
                MlCloseJobRequest.Timeout2 = Option.None
            } : MlCloseJobRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlCloseJobRequest, value: Id) =
            { state with MlCloseJobRequest.JobId = value } : MlCloseJobRequest

        [<CustomOperation("allow_no_match")>]
        member _.AllowNoMatch(state: MlCloseJobRequest, value: bool) =
            { state with MlCloseJobRequest.AllowNoMatch = Option.Some value } : MlCloseJobRequest

        [<CustomOperation("force")>]
        member _.Force(state: MlCloseJobRequest, value: bool) =
            { state with MlCloseJobRequest.Force = Option.Some value } : MlCloseJobRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlCloseJobRequest, value: Duration) =
            { state with MlCloseJobRequest.Timeout = Option.Some value } : MlCloseJobRequest

        [<CustomOperation("allow_no_match2")>]
        member _.AllowNoMatch2(state: MlCloseJobRequest, value: bool) =
            { state with MlCloseJobRequest.AllowNoMatch2 = Option.Some value } : MlCloseJobRequest

        [<CustomOperation("force2")>]
        member _.Force2(state: MlCloseJobRequest, value: bool) =
            { state with MlCloseJobRequest.Force2 = Option.Some value } : MlCloseJobRequest

        [<CustomOperation("timeout2")>]
        member _.Timeout2(state: MlCloseJobRequest, value: Duration) =
            { state with MlCloseJobRequest.Timeout2 = Option.Some value } : MlCloseJobRequest

    let mlCloseJobRequest = MlCloseJobRequestBuilder()

    type MlCloseJobResponse = {
        [<JsonPropertyName("closed")>]
        Closed: bool
    }

    type MlPutCalendarRequest = {
        CalendarId: Id
        [<JsonPropertyName("job_ids")>]
        JobIds: Id array option
        [<JsonPropertyName("description")>]
        Description: string option
    } with
        static member ToRequest(request: MlPutCalendarRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/calendars/{request.CalendarId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``job_ids`` = request.JobIds; ``description`` = request.Description |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlPutCalendarRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlPutCalendarRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlPutCalendarRequest.ToRequest request

    type MlPutCalendarRequestBuilder() =
        member _.Yield(_: unit) : MlPutCalendarRequest =
            {
                MlPutCalendarRequest.CalendarId = Unchecked.defaultof<Id>
                MlPutCalendarRequest.JobIds = Option.None
                MlPutCalendarRequest.Description = Option.None
            } : MlPutCalendarRequest

        [<CustomOperation("calendar_id")>]
        member _.CalendarId(state: MlPutCalendarRequest, value: Id) =
            { state with MlPutCalendarRequest.CalendarId = value } : MlPutCalendarRequest

        [<CustomOperation("job_ids")>]
        member _.JobIds(state: MlPutCalendarRequest, value: Id array) =
            { state with MlPutCalendarRequest.JobIds = Option.Some value } : MlPutCalendarRequest

        [<CustomOperation("description")>]
        member _.Description(state: MlPutCalendarRequest, value: string) =
            { state with MlPutCalendarRequest.Description = Option.Some value } : MlPutCalendarRequest

    let mlPutCalendarRequest = MlPutCalendarRequestBuilder()

    type MlPutCalendarResponse = {
        [<JsonPropertyName("calendar_id")>]
        CalendarId: Id
        [<JsonPropertyName("description")>]
        Description: string option
        [<JsonPropertyName("job_ids")>]
        JobIds: Ids
    }

    type MlGetCalendarsRequest = {
        CalendarId: Id
        From: float option
        Size: float option
        [<JsonPropertyName("page")>]
        Page: TypesPage option
    } with
        static member ToRequest(request: MlGetCalendarsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/calendars/{request.CalendarId}"
                let queryParams =
                    [
                        request.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        request.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``page`` = request.Page |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlGetCalendarsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlGetCalendarsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlGetCalendarsRequest.ToRequest request

    type MlGetCalendarsRequestBuilder() =
        member _.Yield(_: unit) : MlGetCalendarsRequest =
            {
                MlGetCalendarsRequest.CalendarId = Unchecked.defaultof<Id>
                MlGetCalendarsRequest.From = Option.None
                MlGetCalendarsRequest.Size = Option.None
                MlGetCalendarsRequest.Page = Option.None
            } : MlGetCalendarsRequest

        [<CustomOperation("calendar_id")>]
        member _.CalendarId(state: MlGetCalendarsRequest, value: Id) =
            { state with MlGetCalendarsRequest.CalendarId = value } : MlGetCalendarsRequest

        [<CustomOperation("from")>]
        member _.From(state: MlGetCalendarsRequest, value: float) =
            { state with MlGetCalendarsRequest.From = Option.Some value } : MlGetCalendarsRequest

        [<CustomOperation("size")>]
        member _.Size(state: MlGetCalendarsRequest, value: float) =
            { state with MlGetCalendarsRequest.Size = Option.Some value } : MlGetCalendarsRequest

        [<CustomOperation("page")>]
        member _.Page(state: MlGetCalendarsRequest, value: TypesPage) =
            { state with MlGetCalendarsRequest.Page = Option.Some value } : MlGetCalendarsRequest

    let mlGetCalendarsRequest = MlGetCalendarsRequestBuilder()

    type MlDeleteCalendarRequest = {
        CalendarId: Id
    } with
        static member ToRequest(request: MlDeleteCalendarRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/calendars/{request.CalendarId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module MlDeleteCalendarRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlDeleteCalendarRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlDeleteCalendarRequest.ToRequest request

    type MlDeleteCalendarRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteCalendarRequest =
            {
                MlDeleteCalendarRequest.CalendarId = Unchecked.defaultof<Id>
            } : MlDeleteCalendarRequest

        [<CustomOperation("calendar_id")>]
        member _.CalendarId(state: MlDeleteCalendarRequest, value: Id) =
            { state with MlDeleteCalendarRequest.CalendarId = value } : MlDeleteCalendarRequest

    let mlDeleteCalendarRequest = MlDeleteCalendarRequestBuilder()

    type MlDeleteCalendarResponse = AcknowledgedResponseBase

    type MlDeleteCalendarEventRequest = {
        CalendarId: Id
        EventId: Id
    } with
        static member ToRequest(request: MlDeleteCalendarEventRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/calendars/{request.CalendarId}/events/{request.EventId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module MlDeleteCalendarEventRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlDeleteCalendarEventRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlDeleteCalendarEventRequest.ToRequest request

    type MlDeleteCalendarEventRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteCalendarEventRequest =
            {
                MlDeleteCalendarEventRequest.CalendarId = Unchecked.defaultof<Id>
                MlDeleteCalendarEventRequest.EventId = Unchecked.defaultof<Id>
            } : MlDeleteCalendarEventRequest

        [<CustomOperation("calendar_id")>]
        member _.CalendarId(state: MlDeleteCalendarEventRequest, value: Id) =
            { state with MlDeleteCalendarEventRequest.CalendarId = value } : MlDeleteCalendarEventRequest

        [<CustomOperation("event_id")>]
        member _.EventId(state: MlDeleteCalendarEventRequest, value: Id) =
            { state with MlDeleteCalendarEventRequest.EventId = value } : MlDeleteCalendarEventRequest

    let mlDeleteCalendarEventRequest = MlDeleteCalendarEventRequestBuilder()

    type MlDeleteCalendarEventResponse = AcknowledgedResponseBase

    type MlPutCalendarJobRequest = {
        CalendarId: Id
        JobId: Ids
    } with
        static member ToRequest(request: MlPutCalendarJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/calendars/{request.CalendarId}/jobs/{request.JobId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Result.Ok
            with ex -> Result.Error ex

    module MlPutCalendarJobRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlPutCalendarJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlPutCalendarJobRequest.ToRequest request

    type MlPutCalendarJobRequestBuilder() =
        member _.Yield(_: unit) : MlPutCalendarJobRequest =
            {
                MlPutCalendarJobRequest.CalendarId = Unchecked.defaultof<Id>
                MlPutCalendarJobRequest.JobId = Unchecked.defaultof<Ids>
            } : MlPutCalendarJobRequest

        [<CustomOperation("calendar_id")>]
        member _.CalendarId(state: MlPutCalendarJobRequest, value: Id) =
            { state with MlPutCalendarJobRequest.CalendarId = value } : MlPutCalendarJobRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlPutCalendarJobRequest, value: Ids) =
            { state with MlPutCalendarJobRequest.JobId = value } : MlPutCalendarJobRequest

    let mlPutCalendarJobRequest = MlPutCalendarJobRequestBuilder()

    type MlPutCalendarJobResponse = {
        [<JsonPropertyName("calendar_id")>]
        CalendarId: Id
        [<JsonPropertyName("description")>]
        Description: string option
        [<JsonPropertyName("job_ids")>]
        JobIds: Ids
    }

    type MlDeleteCalendarJobRequest = {
        CalendarId: Id
        JobId: Ids
    } with
        static member ToRequest(request: MlDeleteCalendarJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/calendars/{request.CalendarId}/jobs/{request.JobId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module MlDeleteCalendarJobRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlDeleteCalendarJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlDeleteCalendarJobRequest.ToRequest request

    type MlDeleteCalendarJobRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteCalendarJobRequest =
            {
                MlDeleteCalendarJobRequest.CalendarId = Unchecked.defaultof<Id>
                MlDeleteCalendarJobRequest.JobId = Unchecked.defaultof<Ids>
            } : MlDeleteCalendarJobRequest

        [<CustomOperation("calendar_id")>]
        member _.CalendarId(state: MlDeleteCalendarJobRequest, value: Id) =
            { state with MlDeleteCalendarJobRequest.CalendarId = value } : MlDeleteCalendarJobRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlDeleteCalendarJobRequest, value: Ids) =
            { state with MlDeleteCalendarJobRequest.JobId = value } : MlDeleteCalendarJobRequest

    let mlDeleteCalendarJobRequest = MlDeleteCalendarJobRequestBuilder()

    type MlDeleteCalendarJobResponse = {
        [<JsonPropertyName("calendar_id")>]
        CalendarId: Id
        [<JsonPropertyName("description")>]
        Description: string option
        [<JsonPropertyName("job_ids")>]
        JobIds: Ids
    }

    type MlGetDatafeedsRequest = {
        DatafeedId: Ids
        AllowNoMatch: bool option
        ExcludeGenerated: bool option
    } with
        static member ToRequest(request: MlGetDatafeedsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/datafeeds/{request.DatafeedId}"
                let queryParams =
                    [
                        request.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                        request.ExcludeGenerated |> Option.map (fun v -> "exclude_generated", Fes.Http.toQueryValue v)
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

    module MlGetDatafeedsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlGetDatafeedsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlGetDatafeedsRequest.ToRequest request

    type MlGetDatafeedsRequestBuilder() =
        member _.Yield(_: unit) : MlGetDatafeedsRequest =
            {
                MlGetDatafeedsRequest.DatafeedId = Unchecked.defaultof<Ids>
                MlGetDatafeedsRequest.AllowNoMatch = Option.None
                MlGetDatafeedsRequest.ExcludeGenerated = Option.None
            } : MlGetDatafeedsRequest

        [<CustomOperation("datafeed_id")>]
        member _.DatafeedId(state: MlGetDatafeedsRequest, value: Ids) =
            { state with MlGetDatafeedsRequest.DatafeedId = value } : MlGetDatafeedsRequest

        [<CustomOperation("allow_no_match")>]
        member _.AllowNoMatch(state: MlGetDatafeedsRequest, value: bool) =
            { state with MlGetDatafeedsRequest.AllowNoMatch = Option.Some value } : MlGetDatafeedsRequest

        [<CustomOperation("exclude_generated")>]
        member _.ExcludeGenerated(state: MlGetDatafeedsRequest, value: bool) =
            { state with MlGetDatafeedsRequest.ExcludeGenerated = Option.Some value } : MlGetDatafeedsRequest

    let mlGetDatafeedsRequest = MlGetDatafeedsRequestBuilder()

    type MlPutDatafeedRequest = {
        DatafeedId: Id
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        IgnoreThrottled: bool option
        IgnoreUnavailable: bool option
        [<JsonPropertyName("aggregations")>]
        Aggregations: Map<string, AggregationsAggregationContainer> option
        [<JsonPropertyName("chunking_config")>]
        ChunkingConfig: TypesChunkingConfig option
        [<JsonPropertyName("delayed_data_check_config")>]
        DelayedDataCheckConfig: TypesDelayedDataCheckConfig option
        [<JsonPropertyName("frequency")>]
        Frequency: Duration option
        [<JsonPropertyName("indices")>]
        Indices: Indices option
        [<JsonPropertyName("indices_options")>]
        IndicesOptions: IndicesOptions option
        [<JsonPropertyName("job_id")>]
        JobId: Id option
        [<JsonPropertyName("max_empty_searches")>]
        MaxEmptySearches: float option
        [<JsonPropertyName("query")>]
        Query: QueryDslQueryContainer option
        [<JsonPropertyName("query_delay")>]
        QueryDelay: Duration option
        [<JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: MappingRuntimeFields option
        [<JsonPropertyName("script_fields")>]
        ScriptFields: Map<string, ScriptField> option
        [<JsonPropertyName("scroll_size")>]
        ScrollSize: float option
        [<JsonPropertyName("headers")>]
        Headers: HttpHeaders option
    } with
        static member ToRequest(request: MlPutDatafeedRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/datafeeds/{request.DatafeedId}"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.IgnoreThrottled |> Option.map (fun v -> "ignore_throttled", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``aggregations`` = request.Aggregations; ``chunking_config`` = request.ChunkingConfig; ``delayed_data_check_config`` = request.DelayedDataCheckConfig; ``frequency`` = request.Frequency; ``indices`` = request.Indices; ``indices_options`` = request.IndicesOptions; ``job_id`` = request.JobId; ``max_empty_searches`` = request.MaxEmptySearches; ``query`` = request.Query; ``query_delay`` = request.QueryDelay; ``runtime_mappings`` = request.RuntimeMappings; ``script_fields`` = request.ScriptFields; ``scroll_size`` = request.ScrollSize; ``headers`` = request.Headers |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlPutDatafeedRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlPutDatafeedRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlPutDatafeedRequest.ToRequest request

    type MlPutDatafeedRequestBuilder() =
        member _.Yield(_: unit) : MlPutDatafeedRequest =
            {
                MlPutDatafeedRequest.DatafeedId = Unchecked.defaultof<Id>
                MlPutDatafeedRequest.AllowNoIndices = Option.None
                MlPutDatafeedRequest.ExpandWildcards = Option.None
                MlPutDatafeedRequest.IgnoreThrottled = Option.None
                MlPutDatafeedRequest.IgnoreUnavailable = Option.None
                MlPutDatafeedRequest.Aggregations = Option.None
                MlPutDatafeedRequest.ChunkingConfig = Option.None
                MlPutDatafeedRequest.DelayedDataCheckConfig = Option.None
                MlPutDatafeedRequest.Frequency = Option.None
                MlPutDatafeedRequest.Indices = Option.None
                MlPutDatafeedRequest.IndicesOptions = Option.None
                MlPutDatafeedRequest.JobId = Option.None
                MlPutDatafeedRequest.MaxEmptySearches = Option.None
                MlPutDatafeedRequest.Query = Option.None
                MlPutDatafeedRequest.QueryDelay = Option.None
                MlPutDatafeedRequest.RuntimeMappings = Option.None
                MlPutDatafeedRequest.ScriptFields = Option.None
                MlPutDatafeedRequest.ScrollSize = Option.None
                MlPutDatafeedRequest.Headers = Option.None
            } : MlPutDatafeedRequest

        [<CustomOperation("datafeed_id")>]
        member _.DatafeedId(state: MlPutDatafeedRequest, value: Id) =
            { state with MlPutDatafeedRequest.DatafeedId = value } : MlPutDatafeedRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: MlPutDatafeedRequest, value: bool) =
            { state with MlPutDatafeedRequest.AllowNoIndices = Option.Some value } : MlPutDatafeedRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: MlPutDatafeedRequest, value: ExpandWildcards) =
            { state with MlPutDatafeedRequest.ExpandWildcards = Option.Some value } : MlPutDatafeedRequest

        [<CustomOperation("ignore_throttled")>]
        member _.IgnoreThrottled(state: MlPutDatafeedRequest, value: bool) =
            { state with MlPutDatafeedRequest.IgnoreThrottled = Option.Some value } : MlPutDatafeedRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: MlPutDatafeedRequest, value: bool) =
            { state with MlPutDatafeedRequest.IgnoreUnavailable = Option.Some value } : MlPutDatafeedRequest

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: MlPutDatafeedRequest, value: Map<string, AggregationsAggregationContainer>) =
            { state with MlPutDatafeedRequest.Aggregations = Option.Some value } : MlPutDatafeedRequest

        [<CustomOperation("chunking_config")>]
        member _.ChunkingConfig(state: MlPutDatafeedRequest, value: TypesChunkingConfig) =
            { state with MlPutDatafeedRequest.ChunkingConfig = Option.Some value } : MlPutDatafeedRequest

        [<CustomOperation("delayed_data_check_config")>]
        member _.DelayedDataCheckConfig(state: MlPutDatafeedRequest, value: TypesDelayedDataCheckConfig) =
            { state with MlPutDatafeedRequest.DelayedDataCheckConfig = Option.Some value } : MlPutDatafeedRequest

        [<CustomOperation("frequency")>]
        member _.Frequency(state: MlPutDatafeedRequest, value: Duration) =
            { state with MlPutDatafeedRequest.Frequency = Option.Some value } : MlPutDatafeedRequest

        [<CustomOperation("indices")>]
        member _.Indices(state: MlPutDatafeedRequest, value: Indices) =
            { state with MlPutDatafeedRequest.Indices = Option.Some value } : MlPutDatafeedRequest

        [<CustomOperation("indices_options")>]
        member _.IndicesOptions(state: MlPutDatafeedRequest, value: IndicesOptions) =
            { state with MlPutDatafeedRequest.IndicesOptions = Option.Some value } : MlPutDatafeedRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlPutDatafeedRequest, value: Id) =
            { state with MlPutDatafeedRequest.JobId = Option.Some value } : MlPutDatafeedRequest

        [<CustomOperation("max_empty_searches")>]
        member _.MaxEmptySearches(state: MlPutDatafeedRequest, value: float) =
            { state with MlPutDatafeedRequest.MaxEmptySearches = Option.Some value } : MlPutDatafeedRequest

        [<CustomOperation("query")>]
        member _.Query(state: MlPutDatafeedRequest, value: QueryDslQueryContainer) =
            { state with MlPutDatafeedRequest.Query = Option.Some value } : MlPutDatafeedRequest

        [<CustomOperation("query_delay")>]
        member _.QueryDelay(state: MlPutDatafeedRequest, value: Duration) =
            { state with MlPutDatafeedRequest.QueryDelay = Option.Some value } : MlPutDatafeedRequest

        [<CustomOperation("runtime_mappings")>]
        member _.RuntimeMappings(state: MlPutDatafeedRequest, value: MappingRuntimeFields) =
            { state with MlPutDatafeedRequest.RuntimeMappings = Option.Some value } : MlPutDatafeedRequest

        [<CustomOperation("script_fields")>]
        member _.ScriptFields(state: MlPutDatafeedRequest, value: Map<string, ScriptField>) =
            { state with MlPutDatafeedRequest.ScriptFields = Option.Some value } : MlPutDatafeedRequest

        [<CustomOperation("scroll_size")>]
        member _.ScrollSize(state: MlPutDatafeedRequest, value: float) =
            { state with MlPutDatafeedRequest.ScrollSize = Option.Some value } : MlPutDatafeedRequest

        [<CustomOperation("headers")>]
        member _.Headers(state: MlPutDatafeedRequest, value: HttpHeaders) =
            { state with MlPutDatafeedRequest.Headers = Option.Some value } : MlPutDatafeedRequest

    let mlPutDatafeedRequest = MlPutDatafeedRequestBuilder()

    type MlPutDatafeedResponse = {
        [<JsonPropertyName("aggregations")>]
        Aggregations: Map<string, AggregationsAggregationContainer> option
        [<JsonPropertyName("authorization")>]
        Authorization: TypesDatafeedAuthorization option
        [<JsonPropertyName("chunking_config")>]
        ChunkingConfig: TypesChunkingConfig
        [<JsonPropertyName("delayed_data_check_config")>]
        DelayedDataCheckConfig: TypesDelayedDataCheckConfig option
        [<JsonPropertyName("datafeed_id")>]
        DatafeedId: Id
        [<JsonPropertyName("frequency")>]
        Frequency: Duration option
        [<JsonPropertyName("indices")>]
        Indices: string array
        [<JsonPropertyName("job_id")>]
        JobId: Id
        [<JsonPropertyName("indices_options")>]
        IndicesOptions: IndicesOptions option
        [<JsonPropertyName("max_empty_searches")>]
        MaxEmptySearches: float option
        [<JsonPropertyName("query")>]
        Query: QueryDslQueryContainer
        [<JsonPropertyName("query_delay")>]
        QueryDelay: Duration
        [<JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: MappingRuntimeFields option
        [<JsonPropertyName("script_fields")>]
        ScriptFields: Map<string, ScriptField> option
        [<JsonPropertyName("scroll_size")>]
        ScrollSize: float
    }

    type MlDeleteDatafeedRequest = {
        DatafeedId: Id
        Force: bool option
    } with
        static member ToRequest(request: MlDeleteDatafeedRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/datafeeds/{request.DatafeedId}"
                let queryParams =
                    [
                        request.Force |> Option.map (fun v -> "force", Fes.Http.toQueryValue v)
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

    module MlDeleteDatafeedRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlDeleteDatafeedRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlDeleteDatafeedRequest.ToRequest request

    type MlDeleteDatafeedRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteDatafeedRequest =
            {
                MlDeleteDatafeedRequest.DatafeedId = Unchecked.defaultof<Id>
                MlDeleteDatafeedRequest.Force = Option.None
            } : MlDeleteDatafeedRequest

        [<CustomOperation("datafeed_id")>]
        member _.DatafeedId(state: MlDeleteDatafeedRequest, value: Id) =
            { state with MlDeleteDatafeedRequest.DatafeedId = value } : MlDeleteDatafeedRequest

        [<CustomOperation("force")>]
        member _.Force(state: MlDeleteDatafeedRequest, value: bool) =
            { state with MlDeleteDatafeedRequest.Force = Option.Some value } : MlDeleteDatafeedRequest

    let mlDeleteDatafeedRequest = MlDeleteDatafeedRequestBuilder()

    type MlDeleteDatafeedResponse = AcknowledgedResponseBase

    type MlDeleteExpiredDataRequest = {
        JobId: Id
        RequestsPerSecond: float option
        Timeout: Duration option
        [<JsonPropertyName("requests_per_second")>]
        RequestsPerSecond2: float option
        [<JsonPropertyName("timeout")>]
        Timeout2: Duration option
    } with
        static member ToRequest(request: MlDeleteExpiredDataRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/_delete_expired_data/{request.JobId}"
                let queryParams =
                    [
                        request.RequestsPerSecond |> Option.map (fun v -> "requests_per_second", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Fes.Http.Request.withJsonBody {| ``requests_per_second`` = request.RequestsPerSecond2; ``timeout`` = request.Timeout2 |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlDeleteExpiredDataRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlDeleteExpiredDataRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlDeleteExpiredDataRequest.ToRequest request

    type MlDeleteExpiredDataRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteExpiredDataRequest =
            {
                MlDeleteExpiredDataRequest.JobId = Unchecked.defaultof<Id>
                MlDeleteExpiredDataRequest.RequestsPerSecond = Option.None
                MlDeleteExpiredDataRequest.Timeout = Option.None
                MlDeleteExpiredDataRequest.RequestsPerSecond2 = Option.None
                MlDeleteExpiredDataRequest.Timeout2 = Option.None
            } : MlDeleteExpiredDataRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlDeleteExpiredDataRequest, value: Id) =
            { state with MlDeleteExpiredDataRequest.JobId = value } : MlDeleteExpiredDataRequest

        [<CustomOperation("requests_per_second")>]
        member _.RequestsPerSecond(state: MlDeleteExpiredDataRequest, value: float) =
            { state with MlDeleteExpiredDataRequest.RequestsPerSecond = Option.Some value } : MlDeleteExpiredDataRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlDeleteExpiredDataRequest, value: Duration) =
            { state with MlDeleteExpiredDataRequest.Timeout = Option.Some value } : MlDeleteExpiredDataRequest

        [<CustomOperation("requests_per_second2")>]
        member _.RequestsPerSecond2(state: MlDeleteExpiredDataRequest, value: float) =
            { state with MlDeleteExpiredDataRequest.RequestsPerSecond2 = Option.Some value } : MlDeleteExpiredDataRequest

        [<CustomOperation("timeout2")>]
        member _.Timeout2(state: MlDeleteExpiredDataRequest, value: Duration) =
            { state with MlDeleteExpiredDataRequest.Timeout2 = Option.Some value } : MlDeleteExpiredDataRequest

    let mlDeleteExpiredDataRequest = MlDeleteExpiredDataRequestBuilder()

    type MlGetFiltersRequest = {
        FilterId: Ids
        From: float option
        Size: float option
    } with
        static member ToRequest(request: MlGetFiltersRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/filters/{request.FilterId}"
                let queryParams =
                    [
                        request.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        request.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
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

    module MlGetFiltersRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlGetFiltersRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlGetFiltersRequest.ToRequest request

    type MlGetFiltersRequestBuilder() =
        member _.Yield(_: unit) : MlGetFiltersRequest =
            {
                MlGetFiltersRequest.FilterId = Unchecked.defaultof<Ids>
                MlGetFiltersRequest.From = Option.None
                MlGetFiltersRequest.Size = Option.None
            } : MlGetFiltersRequest

        [<CustomOperation("filter_id")>]
        member _.FilterId(state: MlGetFiltersRequest, value: Ids) =
            { state with MlGetFiltersRequest.FilterId = value } : MlGetFiltersRequest

        [<CustomOperation("from")>]
        member _.From(state: MlGetFiltersRequest, value: float) =
            { state with MlGetFiltersRequest.From = Option.Some value } : MlGetFiltersRequest

        [<CustomOperation("size")>]
        member _.Size(state: MlGetFiltersRequest, value: float) =
            { state with MlGetFiltersRequest.Size = Option.Some value } : MlGetFiltersRequest

    let mlGetFiltersRequest = MlGetFiltersRequestBuilder()

    type MlPutFilterRequest = {
        FilterId: Id
        [<JsonPropertyName("description")>]
        Description: string option
        [<JsonPropertyName("items")>]
        Items: string array option
    } with
        static member ToRequest(request: MlPutFilterRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/filters/{request.FilterId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``description`` = request.Description; ``items`` = request.Items |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlPutFilterRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlPutFilterRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlPutFilterRequest.ToRequest request

    type MlPutFilterRequestBuilder() =
        member _.Yield(_: unit) : MlPutFilterRequest =
            {
                MlPutFilterRequest.FilterId = Unchecked.defaultof<Id>
                MlPutFilterRequest.Description = Option.None
                MlPutFilterRequest.Items = Option.None
            } : MlPutFilterRequest

        [<CustomOperation("filter_id")>]
        member _.FilterId(state: MlPutFilterRequest, value: Id) =
            { state with MlPutFilterRequest.FilterId = value } : MlPutFilterRequest

        [<CustomOperation("description")>]
        member _.Description(state: MlPutFilterRequest, value: string) =
            { state with MlPutFilterRequest.Description = Option.Some value } : MlPutFilterRequest

        [<CustomOperation("items")>]
        member _.Items(state: MlPutFilterRequest, value: string array) =
            { state with MlPutFilterRequest.Items = Option.Some value } : MlPutFilterRequest

    let mlPutFilterRequest = MlPutFilterRequestBuilder()

    type MlPutFilterResponse = {
        [<JsonPropertyName("description")>]
        Description: string
        [<JsonPropertyName("filter_id")>]
        FilterId: Id
        [<JsonPropertyName("items")>]
        Items: string array
    }

    type MlDeleteFilterRequest = {
        FilterId: Id
    } with
        static member ToRequest(request: MlDeleteFilterRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/filters/{request.FilterId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module MlDeleteFilterRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlDeleteFilterRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlDeleteFilterRequest.ToRequest request

    type MlDeleteFilterRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteFilterRequest =
            {
                MlDeleteFilterRequest.FilterId = Unchecked.defaultof<Id>
            } : MlDeleteFilterRequest

        [<CustomOperation("filter_id")>]
        member _.FilterId(state: MlDeleteFilterRequest, value: Id) =
            { state with MlDeleteFilterRequest.FilterId = value } : MlDeleteFilterRequest

    let mlDeleteFilterRequest = MlDeleteFilterRequestBuilder()

    type MlDeleteFilterResponse = AcknowledgedResponseBase

    type MlDeleteForecastRequest = {
        JobId: Id
        ForecastId: Id
        AllowNoForecasts: bool option
        Timeout: Duration option
    } with
        static member ToRequest(request: MlDeleteForecastRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{request.JobId}/_forecast/{request.ForecastId}"
                let queryParams =
                    [
                        request.AllowNoForecasts |> Option.map (fun v -> "allow_no_forecasts", Fes.Http.toQueryValue v)
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

    module MlDeleteForecastRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlDeleteForecastRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlDeleteForecastRequest.ToRequest request

    type MlDeleteForecastRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteForecastRequest =
            {
                MlDeleteForecastRequest.JobId = Unchecked.defaultof<Id>
                MlDeleteForecastRequest.ForecastId = Unchecked.defaultof<Id>
                MlDeleteForecastRequest.AllowNoForecasts = Option.None
                MlDeleteForecastRequest.Timeout = Option.None
            } : MlDeleteForecastRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlDeleteForecastRequest, value: Id) =
            { state with MlDeleteForecastRequest.JobId = value } : MlDeleteForecastRequest

        [<CustomOperation("forecast_id")>]
        member _.ForecastId(state: MlDeleteForecastRequest, value: Id) =
            { state with MlDeleteForecastRequest.ForecastId = value } : MlDeleteForecastRequest

        [<CustomOperation("allow_no_forecasts")>]
        member _.AllowNoForecasts(state: MlDeleteForecastRequest, value: bool) =
            { state with MlDeleteForecastRequest.AllowNoForecasts = Option.Some value } : MlDeleteForecastRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlDeleteForecastRequest, value: Duration) =
            { state with MlDeleteForecastRequest.Timeout = Option.Some value } : MlDeleteForecastRequest

    let mlDeleteForecastRequest = MlDeleteForecastRequestBuilder()

    type MlGetJobsRequest = {
        JobId: Ids
        AllowNoMatch: bool option
        ExcludeGenerated: bool option
    } with
        static member ToRequest(request: MlGetJobsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{request.JobId}"
                let queryParams =
                    [
                        request.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                        request.ExcludeGenerated |> Option.map (fun v -> "exclude_generated", Fes.Http.toQueryValue v)
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

    module MlGetJobsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlGetJobsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlGetJobsRequest.ToRequest request

    type MlGetJobsRequestBuilder() =
        member _.Yield(_: unit) : MlGetJobsRequest =
            {
                MlGetJobsRequest.JobId = Unchecked.defaultof<Ids>
                MlGetJobsRequest.AllowNoMatch = Option.None
                MlGetJobsRequest.ExcludeGenerated = Option.None
            } : MlGetJobsRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlGetJobsRequest, value: Ids) =
            { state with MlGetJobsRequest.JobId = value } : MlGetJobsRequest

        [<CustomOperation("allow_no_match")>]
        member _.AllowNoMatch(state: MlGetJobsRequest, value: bool) =
            { state with MlGetJobsRequest.AllowNoMatch = Option.Some value } : MlGetJobsRequest

        [<CustomOperation("exclude_generated")>]
        member _.ExcludeGenerated(state: MlGetJobsRequest, value: bool) =
            { state with MlGetJobsRequest.ExcludeGenerated = Option.Some value } : MlGetJobsRequest

    let mlGetJobsRequest = MlGetJobsRequestBuilder()

    type MlPutJobRequest = {
        JobId: Id
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        IgnoreThrottled: bool option
        IgnoreUnavailable: bool option
        [<JsonPropertyName("allow_lazy_open")>]
        AllowLazyOpen: bool option
        [<JsonPropertyName("analysis_config")>]
        AnalysisConfig: TypesAnalysisConfig
        [<JsonPropertyName("analysis_limits")>]
        AnalysisLimits: TypesAnalysisLimits option
        [<JsonPropertyName("background_persist_interval")>]
        BackgroundPersistInterval: Duration option
        [<JsonPropertyName("custom_settings")>]
        CustomSettings: TypesCustomSettings option
        [<JsonPropertyName("daily_model_snapshot_retention_after_days")>]
        DailyModelSnapshotRetentionAfterDays: float option
        [<JsonPropertyName("data_description")>]
        DataDescription: TypesDataDescription
        [<JsonPropertyName("datafeed_config")>]
        DatafeedConfig: TypesDatafeedConfig option
        [<JsonPropertyName("description")>]
        Description: string option
        [<JsonPropertyName("job_id")>]
        JobId2: Id option
        [<JsonPropertyName("groups")>]
        Groups: string array option
        [<JsonPropertyName("model_plot_config")>]
        ModelPlotConfig: TypesModelPlotConfig option
        [<JsonPropertyName("model_snapshot_retention_days")>]
        ModelSnapshotRetentionDays: float option
        [<JsonPropertyName("renormalization_window_days")>]
        RenormalizationWindowDays: float option
        [<JsonPropertyName("results_index_name")>]
        ResultsIndexName: IndexName option
        [<JsonPropertyName("results_retention_days")>]
        ResultsRetentionDays: float option
    } with
        static member ToRequest(request: MlPutJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{request.JobId}"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.IgnoreThrottled |> Option.map (fun v -> "ignore_throttled", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``allow_lazy_open`` = request.AllowLazyOpen; ``analysis_config`` = request.AnalysisConfig; ``analysis_limits`` = request.AnalysisLimits; ``background_persist_interval`` = request.BackgroundPersistInterval; ``custom_settings`` = request.CustomSettings; ``daily_model_snapshot_retention_after_days`` = request.DailyModelSnapshotRetentionAfterDays; ``data_description`` = request.DataDescription; ``datafeed_config`` = request.DatafeedConfig; ``description`` = request.Description; ``job_id`` = request.JobId2; ``groups`` = request.Groups; ``model_plot_config`` = request.ModelPlotConfig; ``model_snapshot_retention_days`` = request.ModelSnapshotRetentionDays; ``renormalization_window_days`` = request.RenormalizationWindowDays; ``results_index_name`` = request.ResultsIndexName; ``results_retention_days`` = request.ResultsRetentionDays |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlPutJobRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlPutJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlPutJobRequest.ToRequest request

    type MlPutJobRequestBuilder() =
        member _.Yield(_: unit) : MlPutJobRequest =
            {
                MlPutJobRequest.JobId = Unchecked.defaultof<Id>
                MlPutJobRequest.AllowNoIndices = Option.None
                MlPutJobRequest.ExpandWildcards = Option.None
                MlPutJobRequest.IgnoreThrottled = Option.None
                MlPutJobRequest.IgnoreUnavailable = Option.None
                MlPutJobRequest.AllowLazyOpen = Option.None
                MlPutJobRequest.AnalysisConfig = Unchecked.defaultof<TypesAnalysisConfig>
                MlPutJobRequest.AnalysisLimits = Option.None
                MlPutJobRequest.BackgroundPersistInterval = Option.None
                MlPutJobRequest.CustomSettings = Option.None
                MlPutJobRequest.DailyModelSnapshotRetentionAfterDays = Option.None
                MlPutJobRequest.DataDescription = Unchecked.defaultof<TypesDataDescription>
                MlPutJobRequest.DatafeedConfig = Option.None
                MlPutJobRequest.Description = Option.None
                MlPutJobRequest.JobId2 = Option.None
                MlPutJobRequest.Groups = Option.None
                MlPutJobRequest.ModelPlotConfig = Option.None
                MlPutJobRequest.ModelSnapshotRetentionDays = Option.None
                MlPutJobRequest.RenormalizationWindowDays = Option.None
                MlPutJobRequest.ResultsIndexName = Option.None
                MlPutJobRequest.ResultsRetentionDays = Option.None
            } : MlPutJobRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlPutJobRequest, value: Id) =
            { state with MlPutJobRequest.JobId = value } : MlPutJobRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: MlPutJobRequest, value: bool) =
            { state with MlPutJobRequest.AllowNoIndices = Option.Some value } : MlPutJobRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: MlPutJobRequest, value: ExpandWildcards) =
            { state with MlPutJobRequest.ExpandWildcards = Option.Some value } : MlPutJobRequest

        [<CustomOperation("ignore_throttled")>]
        member _.IgnoreThrottled(state: MlPutJobRequest, value: bool) =
            { state with MlPutJobRequest.IgnoreThrottled = Option.Some value } : MlPutJobRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: MlPutJobRequest, value: bool) =
            { state with MlPutJobRequest.IgnoreUnavailable = Option.Some value } : MlPutJobRequest

        [<CustomOperation("allow_lazy_open")>]
        member _.AllowLazyOpen(state: MlPutJobRequest, value: bool) =
            { state with MlPutJobRequest.AllowLazyOpen = Option.Some value } : MlPutJobRequest

        [<CustomOperation("analysis_config")>]
        member _.AnalysisConfig(state: MlPutJobRequest, value: TypesAnalysisConfig) =
            { state with MlPutJobRequest.AnalysisConfig = value } : MlPutJobRequest

        [<CustomOperation("analysis_limits")>]
        member _.AnalysisLimits(state: MlPutJobRequest, value: TypesAnalysisLimits) =
            { state with MlPutJobRequest.AnalysisLimits = Option.Some value } : MlPutJobRequest

        [<CustomOperation("background_persist_interval")>]
        member _.BackgroundPersistInterval(state: MlPutJobRequest, value: Duration) =
            { state with MlPutJobRequest.BackgroundPersistInterval = Option.Some value } : MlPutJobRequest

        [<CustomOperation("custom_settings")>]
        member _.CustomSettings(state: MlPutJobRequest, value: TypesCustomSettings) =
            { state with MlPutJobRequest.CustomSettings = Option.Some value } : MlPutJobRequest

        [<CustomOperation("daily_model_snapshot_retention_after_days")>]
        member _.DailyModelSnapshotRetentionAfterDays(state: MlPutJobRequest, value: float) =
            { state with MlPutJobRequest.DailyModelSnapshotRetentionAfterDays = Option.Some value } : MlPutJobRequest

        [<CustomOperation("data_description")>]
        member _.DataDescription(state: MlPutJobRequest, value: TypesDataDescription) =
            { state with MlPutJobRequest.DataDescription = value } : MlPutJobRequest

        [<CustomOperation("datafeed_config")>]
        member _.DatafeedConfig(state: MlPutJobRequest, value: TypesDatafeedConfig) =
            { state with MlPutJobRequest.DatafeedConfig = Option.Some value } : MlPutJobRequest

        [<CustomOperation("description")>]
        member _.Description(state: MlPutJobRequest, value: string) =
            { state with MlPutJobRequest.Description = Option.Some value } : MlPutJobRequest

        [<CustomOperation("job_id2")>]
        member _.JobId2(state: MlPutJobRequest, value: Id) =
            { state with MlPutJobRequest.JobId2 = Option.Some value } : MlPutJobRequest

        [<CustomOperation("groups")>]
        member _.Groups(state: MlPutJobRequest, value: string array) =
            { state with MlPutJobRequest.Groups = Option.Some value } : MlPutJobRequest

        [<CustomOperation("model_plot_config")>]
        member _.ModelPlotConfig(state: MlPutJobRequest, value: TypesModelPlotConfig) =
            { state with MlPutJobRequest.ModelPlotConfig = Option.Some value } : MlPutJobRequest

        [<CustomOperation("model_snapshot_retention_days")>]
        member _.ModelSnapshotRetentionDays(state: MlPutJobRequest, value: float) =
            { state with MlPutJobRequest.ModelSnapshotRetentionDays = Option.Some value } : MlPutJobRequest

        [<CustomOperation("renormalization_window_days")>]
        member _.RenormalizationWindowDays(state: MlPutJobRequest, value: float) =
            { state with MlPutJobRequest.RenormalizationWindowDays = Option.Some value } : MlPutJobRequest

        [<CustomOperation("results_index_name")>]
        member _.ResultsIndexName(state: MlPutJobRequest, value: IndexName) =
            { state with MlPutJobRequest.ResultsIndexName = Option.Some value } : MlPutJobRequest

        [<CustomOperation("results_retention_days")>]
        member _.ResultsRetentionDays(state: MlPutJobRequest, value: float) =
            { state with MlPutJobRequest.ResultsRetentionDays = Option.Some value } : MlPutJobRequest

    let mlPutJobRequest = MlPutJobRequestBuilder()

    type MlPutJobResponse = {
        [<JsonPropertyName("allow_lazy_open")>]
        AllowLazyOpen: bool
        [<JsonPropertyName("analysis_config")>]
        AnalysisConfig: TypesAnalysisConfigRead
        [<JsonPropertyName("analysis_limits")>]
        AnalysisLimits: TypesAnalysisLimits
        [<JsonPropertyName("background_persist_interval")>]
        BackgroundPersistInterval: Duration option
        [<JsonPropertyName("create_time")>]
        CreateTime: DateTime
        [<JsonPropertyName("custom_settings")>]
        CustomSettings: TypesCustomSettings option
        [<JsonPropertyName("daily_model_snapshot_retention_after_days")>]
        DailyModelSnapshotRetentionAfterDays: float
        [<JsonPropertyName("data_description")>]
        DataDescription: TypesDataDescription
        [<JsonPropertyName("datafeed_config")>]
        DatafeedConfig: TypesDatafeed option
        [<JsonPropertyName("description")>]
        Description: string option
        [<JsonPropertyName("groups")>]
        Groups: string array option
        [<JsonPropertyName("job_id")>]
        JobId: Id
        [<JsonPropertyName("job_type")>]
        JobType: string
        [<JsonPropertyName("job_version")>]
        JobVersion: string
        [<JsonPropertyName("model_plot_config")>]
        ModelPlotConfig: TypesModelPlotConfig option
        [<JsonPropertyName("model_snapshot_id")>]
        ModelSnapshotId: Id option
        [<JsonPropertyName("model_snapshot_retention_days")>]
        ModelSnapshotRetentionDays: float
        [<JsonPropertyName("renormalization_window_days")>]
        RenormalizationWindowDays: float option
        [<JsonPropertyName("results_index_name")>]
        ResultsIndexName: string
        [<JsonPropertyName("results_retention_days")>]
        ResultsRetentionDays: float option
    }

    type MlDeleteJobRequest = {
        JobId: Id
        Force: bool option
        DeleteUserAnnotations: bool option
        WaitForCompletion: bool option
    } with
        static member ToRequest(request: MlDeleteJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{request.JobId}"
                let queryParams =
                    [
                        request.Force |> Option.map (fun v -> "force", Fes.Http.toQueryValue v)
                        request.DeleteUserAnnotations |> Option.map (fun v -> "delete_user_annotations", Fes.Http.toQueryValue v)
                        request.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
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

    module MlDeleteJobRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlDeleteJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlDeleteJobRequest.ToRequest request

    type MlDeleteJobRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteJobRequest =
            {
                MlDeleteJobRequest.JobId = Unchecked.defaultof<Id>
                MlDeleteJobRequest.Force = Option.None
                MlDeleteJobRequest.DeleteUserAnnotations = Option.None
                MlDeleteJobRequest.WaitForCompletion = Option.None
            } : MlDeleteJobRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlDeleteJobRequest, value: Id) =
            { state with MlDeleteJobRequest.JobId = value } : MlDeleteJobRequest

        [<CustomOperation("force")>]
        member _.Force(state: MlDeleteJobRequest, value: bool) =
            { state with MlDeleteJobRequest.Force = Option.Some value } : MlDeleteJobRequest

        [<CustomOperation("delete_user_annotations")>]
        member _.DeleteUserAnnotations(state: MlDeleteJobRequest, value: bool) =
            { state with MlDeleteJobRequest.DeleteUserAnnotations = Option.Some value } : MlDeleteJobRequest

        [<CustomOperation("wait_for_completion")>]
        member _.WaitForCompletion(state: MlDeleteJobRequest, value: bool) =
            { state with MlDeleteJobRequest.WaitForCompletion = Option.Some value } : MlDeleteJobRequest

    let mlDeleteJobRequest = MlDeleteJobRequestBuilder()

    type MlDeleteJobResponse = AcknowledgedResponseBase

    type MlGetModelSnapshotsRequest = {
        JobId: Id
        SnapshotId: Id
        Desc: bool option
        End: DateTime option
        From: float option
        Size: float option
        Sort: Field option
        Start: DateTime option
        [<JsonPropertyName("desc")>]
        Desc2: bool option
        [<JsonPropertyName("end")>]
        End2: DateTime option
        [<JsonPropertyName("page")>]
        Page: TypesPage option
        [<JsonPropertyName("sort")>]
        Sort2: Field option
        [<JsonPropertyName("start")>]
        Start2: DateTime option
    } with
        static member ToRequest(request: MlGetModelSnapshotsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{request.JobId}/model_snapshots/{request.SnapshotId}"
                let queryParams =
                    [
                        request.Desc |> Option.map (fun v -> "desc", Fes.Http.toQueryValue v)
                        request.End |> Option.map (fun v -> "end", Fes.Http.toQueryValue v)
                        request.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        request.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                        request.Sort |> Option.map (fun v -> "sort", Fes.Http.toQueryValue v)
                        request.Start |> Option.map (fun v -> "start", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``desc`` = request.Desc2; ``end`` = request.End2; ``page`` = request.Page; ``sort`` = request.Sort2; ``start`` = request.Start2 |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlGetModelSnapshotsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlGetModelSnapshotsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlGetModelSnapshotsRequest.ToRequest request

    type MlGetModelSnapshotsRequestBuilder() =
        member _.Yield(_: unit) : MlGetModelSnapshotsRequest =
            {
                MlGetModelSnapshotsRequest.JobId = Unchecked.defaultof<Id>
                MlGetModelSnapshotsRequest.SnapshotId = Unchecked.defaultof<Id>
                MlGetModelSnapshotsRequest.Desc = Option.None
                MlGetModelSnapshotsRequest.End = Option.None
                MlGetModelSnapshotsRequest.From = Option.None
                MlGetModelSnapshotsRequest.Size = Option.None
                MlGetModelSnapshotsRequest.Sort = Option.None
                MlGetModelSnapshotsRequest.Start = Option.None
                MlGetModelSnapshotsRequest.Desc2 = Option.None
                MlGetModelSnapshotsRequest.End2 = Option.None
                MlGetModelSnapshotsRequest.Page = Option.None
                MlGetModelSnapshotsRequest.Sort2 = Option.None
                MlGetModelSnapshotsRequest.Start2 = Option.None
            } : MlGetModelSnapshotsRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlGetModelSnapshotsRequest, value: Id) =
            { state with MlGetModelSnapshotsRequest.JobId = value } : MlGetModelSnapshotsRequest

        [<CustomOperation("snapshot_id")>]
        member _.SnapshotId(state: MlGetModelSnapshotsRequest, value: Id) =
            { state with MlGetModelSnapshotsRequest.SnapshotId = value } : MlGetModelSnapshotsRequest

        [<CustomOperation("desc")>]
        member _.Desc(state: MlGetModelSnapshotsRequest, value: bool) =
            { state with MlGetModelSnapshotsRequest.Desc = Option.Some value } : MlGetModelSnapshotsRequest

        [<CustomOperation("end")>]
        member _.End(state: MlGetModelSnapshotsRequest, value: DateTime) =
            { state with MlGetModelSnapshotsRequest.End = Option.Some value } : MlGetModelSnapshotsRequest

        [<CustomOperation("from")>]
        member _.From(state: MlGetModelSnapshotsRequest, value: float) =
            { state with MlGetModelSnapshotsRequest.From = Option.Some value } : MlGetModelSnapshotsRequest

        [<CustomOperation("size")>]
        member _.Size(state: MlGetModelSnapshotsRequest, value: float) =
            { state with MlGetModelSnapshotsRequest.Size = Option.Some value } : MlGetModelSnapshotsRequest

        [<CustomOperation("sort")>]
        member _.Sort(state: MlGetModelSnapshotsRequest, value: Field) =
            { state with MlGetModelSnapshotsRequest.Sort = Option.Some value } : MlGetModelSnapshotsRequest

        [<CustomOperation("start")>]
        member _.Start(state: MlGetModelSnapshotsRequest, value: DateTime) =
            { state with MlGetModelSnapshotsRequest.Start = Option.Some value } : MlGetModelSnapshotsRequest

        [<CustomOperation("desc2")>]
        member _.Desc2(state: MlGetModelSnapshotsRequest, value: bool) =
            { state with MlGetModelSnapshotsRequest.Desc2 = Option.Some value } : MlGetModelSnapshotsRequest

        [<CustomOperation("end2")>]
        member _.End2(state: MlGetModelSnapshotsRequest, value: DateTime) =
            { state with MlGetModelSnapshotsRequest.End2 = Option.Some value } : MlGetModelSnapshotsRequest

        [<CustomOperation("page")>]
        member _.Page(state: MlGetModelSnapshotsRequest, value: TypesPage) =
            { state with MlGetModelSnapshotsRequest.Page = Option.Some value } : MlGetModelSnapshotsRequest

        [<CustomOperation("sort2")>]
        member _.Sort2(state: MlGetModelSnapshotsRequest, value: Field) =
            { state with MlGetModelSnapshotsRequest.Sort2 = Option.Some value } : MlGetModelSnapshotsRequest

        [<CustomOperation("start2")>]
        member _.Start2(state: MlGetModelSnapshotsRequest, value: DateTime) =
            { state with MlGetModelSnapshotsRequest.Start2 = Option.Some value } : MlGetModelSnapshotsRequest

    let mlGetModelSnapshotsRequest = MlGetModelSnapshotsRequestBuilder()

    type MlDeleteModelSnapshotRequest = {
        JobId: Id
        SnapshotId: Id
    } with
        static member ToRequest(request: MlDeleteModelSnapshotRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{request.JobId}/model_snapshots/{request.SnapshotId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module MlDeleteModelSnapshotRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlDeleteModelSnapshotRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlDeleteModelSnapshotRequest.ToRequest request

    type MlDeleteModelSnapshotRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteModelSnapshotRequest =
            {
                MlDeleteModelSnapshotRequest.JobId = Unchecked.defaultof<Id>
                MlDeleteModelSnapshotRequest.SnapshotId = Unchecked.defaultof<Id>
            } : MlDeleteModelSnapshotRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlDeleteModelSnapshotRequest, value: Id) =
            { state with MlDeleteModelSnapshotRequest.JobId = value } : MlDeleteModelSnapshotRequest

        [<CustomOperation("snapshot_id")>]
        member _.SnapshotId(state: MlDeleteModelSnapshotRequest, value: Id) =
            { state with MlDeleteModelSnapshotRequest.SnapshotId = value } : MlDeleteModelSnapshotRequest

    let mlDeleteModelSnapshotRequest = MlDeleteModelSnapshotRequestBuilder()

    type MlDeleteModelSnapshotResponse = AcknowledgedResponseBase

    type MlEstimateModelMemoryRequest = {
        [<JsonPropertyName("analysis_config")>]
        AnalysisConfig: TypesAnalysisConfig option
        [<JsonPropertyName("max_bucket_cardinality")>]
        MaxBucketCardinality: Map<string, float> option
        [<JsonPropertyName("overall_cardinality")>]
        OverallCardinality: Map<string, float> option
    } with
        static member ToRequest(request: MlEstimateModelMemoryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_ml/anomaly_detectors/_estimate_model_memory"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``analysis_config`` = request.AnalysisConfig; ``max_bucket_cardinality`` = request.MaxBucketCardinality; ``overall_cardinality`` = request.OverallCardinality |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlEstimateModelMemoryRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlEstimateModelMemoryRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlEstimateModelMemoryRequest.ToRequest request

    type MlEstimateModelMemoryRequestBuilder() =
        member _.Yield(_: unit) : MlEstimateModelMemoryRequest =
            {
                MlEstimateModelMemoryRequest.AnalysisConfig = Option.None
                MlEstimateModelMemoryRequest.MaxBucketCardinality = Option.None
                MlEstimateModelMemoryRequest.OverallCardinality = Option.None
            } : MlEstimateModelMemoryRequest

        [<CustomOperation("analysis_config")>]
        member _.AnalysisConfig(state: MlEstimateModelMemoryRequest, value: TypesAnalysisConfig) =
            { state with MlEstimateModelMemoryRequest.AnalysisConfig = Option.Some value } : MlEstimateModelMemoryRequest

        [<CustomOperation("max_bucket_cardinality")>]
        member _.MaxBucketCardinality(state: MlEstimateModelMemoryRequest, value: Map<string, float>) =
            { state with MlEstimateModelMemoryRequest.MaxBucketCardinality = Option.Some value } : MlEstimateModelMemoryRequest

        [<CustomOperation("overall_cardinality")>]
        member _.OverallCardinality(state: MlEstimateModelMemoryRequest, value: Map<string, float>) =
            { state with MlEstimateModelMemoryRequest.OverallCardinality = Option.Some value } : MlEstimateModelMemoryRequest

    let mlEstimateModelMemoryRequest = MlEstimateModelMemoryRequestBuilder()

    type MlEstimateModelMemoryResponse = {
        [<JsonPropertyName("model_memory_estimate")>]
        ModelMemoryEstimate: string
    }

    type MlFlushJobRequest = {
        JobId: Id
        AdvanceTime: DateTime option
        CalcInterim: bool option
        End: DateTime option
        SkipTime: DateTime option
        Start: DateTime option
        [<JsonPropertyName("advance_time")>]
        AdvanceTime2: DateTime option
        [<JsonPropertyName("calc_interim")>]
        CalcInterim2: bool option
        [<JsonPropertyName("end")>]
        End2: DateTime option
        [<JsonPropertyName("skip_time")>]
        SkipTime2: DateTime option
        [<JsonPropertyName("start")>]
        Start2: DateTime option
    } with
        static member ToRequest(request: MlFlushJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{request.JobId}/_flush"
                let queryParams =
                    [
                        request.AdvanceTime |> Option.map (fun v -> "advance_time", Fes.Http.toQueryValue v)
                        request.CalcInterim |> Option.map (fun v -> "calc_interim", Fes.Http.toQueryValue v)
                        request.End |> Option.map (fun v -> "end", Fes.Http.toQueryValue v)
                        request.SkipTime |> Option.map (fun v -> "skip_time", Fes.Http.toQueryValue v)
                        request.Start |> Option.map (fun v -> "start", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``advance_time`` = request.AdvanceTime2; ``calc_interim`` = request.CalcInterim2; ``end`` = request.End2; ``skip_time`` = request.SkipTime2; ``start`` = request.Start2 |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlFlushJobRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlFlushJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlFlushJobRequest.ToRequest request

    type MlFlushJobRequestBuilder() =
        member _.Yield(_: unit) : MlFlushJobRequest =
            {
                MlFlushJobRequest.JobId = Unchecked.defaultof<Id>
                MlFlushJobRequest.AdvanceTime = Option.None
                MlFlushJobRequest.CalcInterim = Option.None
                MlFlushJobRequest.End = Option.None
                MlFlushJobRequest.SkipTime = Option.None
                MlFlushJobRequest.Start = Option.None
                MlFlushJobRequest.AdvanceTime2 = Option.None
                MlFlushJobRequest.CalcInterim2 = Option.None
                MlFlushJobRequest.End2 = Option.None
                MlFlushJobRequest.SkipTime2 = Option.None
                MlFlushJobRequest.Start2 = Option.None
            } : MlFlushJobRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlFlushJobRequest, value: Id) =
            { state with MlFlushJobRequest.JobId = value } : MlFlushJobRequest

        [<CustomOperation("advance_time")>]
        member _.AdvanceTime(state: MlFlushJobRequest, value: DateTime) =
            { state with MlFlushJobRequest.AdvanceTime = Option.Some value } : MlFlushJobRequest

        [<CustomOperation("calc_interim")>]
        member _.CalcInterim(state: MlFlushJobRequest, value: bool) =
            { state with MlFlushJobRequest.CalcInterim = Option.Some value } : MlFlushJobRequest

        [<CustomOperation("end")>]
        member _.End(state: MlFlushJobRequest, value: DateTime) =
            { state with MlFlushJobRequest.End = Option.Some value } : MlFlushJobRequest

        [<CustomOperation("skip_time")>]
        member _.SkipTime(state: MlFlushJobRequest, value: DateTime) =
            { state with MlFlushJobRequest.SkipTime = Option.Some value } : MlFlushJobRequest

        [<CustomOperation("start")>]
        member _.Start(state: MlFlushJobRequest, value: DateTime) =
            { state with MlFlushJobRequest.Start = Option.Some value } : MlFlushJobRequest

        [<CustomOperation("advance_time2")>]
        member _.AdvanceTime2(state: MlFlushJobRequest, value: DateTime) =
            { state with MlFlushJobRequest.AdvanceTime2 = Option.Some value } : MlFlushJobRequest

        [<CustomOperation("calc_interim2")>]
        member _.CalcInterim2(state: MlFlushJobRequest, value: bool) =
            { state with MlFlushJobRequest.CalcInterim2 = Option.Some value } : MlFlushJobRequest

        [<CustomOperation("end2")>]
        member _.End2(state: MlFlushJobRequest, value: DateTime) =
            { state with MlFlushJobRequest.End2 = Option.Some value } : MlFlushJobRequest

        [<CustomOperation("skip_time2")>]
        member _.SkipTime2(state: MlFlushJobRequest, value: DateTime) =
            { state with MlFlushJobRequest.SkipTime2 = Option.Some value } : MlFlushJobRequest

        [<CustomOperation("start2")>]
        member _.Start2(state: MlFlushJobRequest, value: DateTime) =
            { state with MlFlushJobRequest.Start2 = Option.Some value } : MlFlushJobRequest

    let mlFlushJobRequest = MlFlushJobRequestBuilder()

    type MlFlushJobResponse = {
        [<JsonPropertyName("flushed")>]
        Flushed: bool
        [<JsonPropertyName("last_finalized_bucket_end")>]
        LastFinalizedBucketEnd: float option
    }

    type MlForecastRequest = {
        JobId: Id
        Duration: Duration option
        ExpiresIn: Duration option
        MaxModelMemory: string option
        [<JsonPropertyName("duration")>]
        Duration2: Duration option
        [<JsonPropertyName("expires_in")>]
        ExpiresIn2: Duration option
        [<JsonPropertyName("max_model_memory")>]
        MaxModelMemory2: string option
    } with
        static member ToRequest(request: MlForecastRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{request.JobId}/_forecast"
                let queryParams =
                    [
                        request.Duration |> Option.map (fun v -> "duration", Fes.Http.toQueryValue v)
                        request.ExpiresIn |> Option.map (fun v -> "expires_in", Fes.Http.toQueryValue v)
                        request.MaxModelMemory |> Option.map (fun v -> "max_model_memory", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``duration`` = request.Duration2; ``expires_in`` = request.ExpiresIn2; ``max_model_memory`` = request.MaxModelMemory2 |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlForecastRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlForecastRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlForecastRequest.ToRequest request

    type MlForecastRequestBuilder() =
        member _.Yield(_: unit) : MlForecastRequest =
            {
                MlForecastRequest.JobId = Unchecked.defaultof<Id>
                MlForecastRequest.Duration = Option.None
                MlForecastRequest.ExpiresIn = Option.None
                MlForecastRequest.MaxModelMemory = Option.None
                MlForecastRequest.Duration2 = Option.None
                MlForecastRequest.ExpiresIn2 = Option.None
                MlForecastRequest.MaxModelMemory2 = Option.None
            } : MlForecastRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlForecastRequest, value: Id) =
            { state with MlForecastRequest.JobId = value } : MlForecastRequest

        [<CustomOperation("duration")>]
        member _.Duration(state: MlForecastRequest, value: Duration) =
            { state with MlForecastRequest.Duration = Option.Some value } : MlForecastRequest

        [<CustomOperation("expires_in")>]
        member _.ExpiresIn(state: MlForecastRequest, value: Duration) =
            { state with MlForecastRequest.ExpiresIn = Option.Some value } : MlForecastRequest

        [<CustomOperation("max_model_memory")>]
        member _.MaxModelMemory(state: MlForecastRequest, value: string) =
            { state with MlForecastRequest.MaxModelMemory = Option.Some value } : MlForecastRequest

        [<CustomOperation("duration2")>]
        member _.Duration2(state: MlForecastRequest, value: Duration) =
            { state with MlForecastRequest.Duration2 = Option.Some value } : MlForecastRequest

        [<CustomOperation("expires_in2")>]
        member _.ExpiresIn2(state: MlForecastRequest, value: Duration) =
            { state with MlForecastRequest.ExpiresIn2 = Option.Some value } : MlForecastRequest

        [<CustomOperation("max_model_memory2")>]
        member _.MaxModelMemory2(state: MlForecastRequest, value: string) =
            { state with MlForecastRequest.MaxModelMemory2 = Option.Some value } : MlForecastRequest

    let mlForecastRequest = MlForecastRequestBuilder()

    type MlForecastResponse = {
        [<JsonPropertyName("acknowledged")>]
        Acknowledged: bool
        [<JsonPropertyName("forecast_id")>]
        ForecastId: Id
    }

    type MlGetBucketsRequest = {
        JobId: Id
        Timestamp: DateTime
        AnomalyScore: float option
        Desc: bool option
        End: DateTime option
        ExcludeInterim: bool option
        Expand: bool option
        From: float option
        Size: float option
        Sort: Field option
        Start: DateTime option
        [<JsonPropertyName("anomaly_score")>]
        AnomalyScore2: float option
        [<JsonPropertyName("desc")>]
        Desc2: bool option
        [<JsonPropertyName("end")>]
        End2: DateTime option
        [<JsonPropertyName("exclude_interim")>]
        ExcludeInterim2: bool option
        [<JsonPropertyName("expand")>]
        Expand2: bool option
        [<JsonPropertyName("page")>]
        Page: TypesPage option
        [<JsonPropertyName("sort")>]
        Sort2: Field option
        [<JsonPropertyName("start")>]
        Start2: DateTime option
    } with
        static member ToRequest(request: MlGetBucketsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{request.JobId}/results/buckets/{request.Timestamp}"
                let queryParams =
                    [
                        request.AnomalyScore |> Option.map (fun v -> "anomaly_score", Fes.Http.toQueryValue v)
                        request.Desc |> Option.map (fun v -> "desc", Fes.Http.toQueryValue v)
                        request.End |> Option.map (fun v -> "end", Fes.Http.toQueryValue v)
                        request.ExcludeInterim |> Option.map (fun v -> "exclude_interim", Fes.Http.toQueryValue v)
                        request.Expand |> Option.map (fun v -> "expand", Fes.Http.toQueryValue v)
                        request.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        request.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                        request.Sort |> Option.map (fun v -> "sort", Fes.Http.toQueryValue v)
                        request.Start |> Option.map (fun v -> "start", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``anomaly_score`` = request.AnomalyScore2; ``desc`` = request.Desc2; ``end`` = request.End2; ``exclude_interim`` = request.ExcludeInterim2; ``expand`` = request.Expand2; ``page`` = request.Page; ``sort`` = request.Sort2; ``start`` = request.Start2 |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlGetBucketsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlGetBucketsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlGetBucketsRequest.ToRequest request

    type MlGetBucketsRequestBuilder() =
        member _.Yield(_: unit) : MlGetBucketsRequest =
            {
                MlGetBucketsRequest.JobId = Unchecked.defaultof<Id>
                MlGetBucketsRequest.Timestamp = Unchecked.defaultof<DateTime>
                MlGetBucketsRequest.AnomalyScore = Option.None
                MlGetBucketsRequest.Desc = Option.None
                MlGetBucketsRequest.End = Option.None
                MlGetBucketsRequest.ExcludeInterim = Option.None
                MlGetBucketsRequest.Expand = Option.None
                MlGetBucketsRequest.From = Option.None
                MlGetBucketsRequest.Size = Option.None
                MlGetBucketsRequest.Sort = Option.None
                MlGetBucketsRequest.Start = Option.None
                MlGetBucketsRequest.AnomalyScore2 = Option.None
                MlGetBucketsRequest.Desc2 = Option.None
                MlGetBucketsRequest.End2 = Option.None
                MlGetBucketsRequest.ExcludeInterim2 = Option.None
                MlGetBucketsRequest.Expand2 = Option.None
                MlGetBucketsRequest.Page = Option.None
                MlGetBucketsRequest.Sort2 = Option.None
                MlGetBucketsRequest.Start2 = Option.None
            } : MlGetBucketsRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlGetBucketsRequest, value: Id) =
            { state with MlGetBucketsRequest.JobId = value } : MlGetBucketsRequest

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: MlGetBucketsRequest, value: DateTime) =
            { state with MlGetBucketsRequest.Timestamp = value } : MlGetBucketsRequest

        [<CustomOperation("anomaly_score")>]
        member _.AnomalyScore(state: MlGetBucketsRequest, value: float) =
            { state with MlGetBucketsRequest.AnomalyScore = Option.Some value } : MlGetBucketsRequest

        [<CustomOperation("desc")>]
        member _.Desc(state: MlGetBucketsRequest, value: bool) =
            { state with MlGetBucketsRequest.Desc = Option.Some value } : MlGetBucketsRequest

        [<CustomOperation("end")>]
        member _.End(state: MlGetBucketsRequest, value: DateTime) =
            { state with MlGetBucketsRequest.End = Option.Some value } : MlGetBucketsRequest

        [<CustomOperation("exclude_interim")>]
        member _.ExcludeInterim(state: MlGetBucketsRequest, value: bool) =
            { state with MlGetBucketsRequest.ExcludeInterim = Option.Some value } : MlGetBucketsRequest

        [<CustomOperation("expand")>]
        member _.Expand(state: MlGetBucketsRequest, value: bool) =
            { state with MlGetBucketsRequest.Expand = Option.Some value } : MlGetBucketsRequest

        [<CustomOperation("from")>]
        member _.From(state: MlGetBucketsRequest, value: float) =
            { state with MlGetBucketsRequest.From = Option.Some value } : MlGetBucketsRequest

        [<CustomOperation("size")>]
        member _.Size(state: MlGetBucketsRequest, value: float) =
            { state with MlGetBucketsRequest.Size = Option.Some value } : MlGetBucketsRequest

        [<CustomOperation("sort")>]
        member _.Sort(state: MlGetBucketsRequest, value: Field) =
            { state with MlGetBucketsRequest.Sort = Option.Some value } : MlGetBucketsRequest

        [<CustomOperation("start")>]
        member _.Start(state: MlGetBucketsRequest, value: DateTime) =
            { state with MlGetBucketsRequest.Start = Option.Some value } : MlGetBucketsRequest

        [<CustomOperation("anomaly_score2")>]
        member _.AnomalyScore2(state: MlGetBucketsRequest, value: float) =
            { state with MlGetBucketsRequest.AnomalyScore2 = Option.Some value } : MlGetBucketsRequest

        [<CustomOperation("desc2")>]
        member _.Desc2(state: MlGetBucketsRequest, value: bool) =
            { state with MlGetBucketsRequest.Desc2 = Option.Some value } : MlGetBucketsRequest

        [<CustomOperation("end2")>]
        member _.End2(state: MlGetBucketsRequest, value: DateTime) =
            { state with MlGetBucketsRequest.End2 = Option.Some value } : MlGetBucketsRequest

        [<CustomOperation("exclude_interim2")>]
        member _.ExcludeInterim2(state: MlGetBucketsRequest, value: bool) =
            { state with MlGetBucketsRequest.ExcludeInterim2 = Option.Some value } : MlGetBucketsRequest

        [<CustomOperation("expand2")>]
        member _.Expand2(state: MlGetBucketsRequest, value: bool) =
            { state with MlGetBucketsRequest.Expand2 = Option.Some value } : MlGetBucketsRequest

        [<CustomOperation("page")>]
        member _.Page(state: MlGetBucketsRequest, value: TypesPage) =
            { state with MlGetBucketsRequest.Page = Option.Some value } : MlGetBucketsRequest

        [<CustomOperation("sort2")>]
        member _.Sort2(state: MlGetBucketsRequest, value: Field) =
            { state with MlGetBucketsRequest.Sort2 = Option.Some value } : MlGetBucketsRequest

        [<CustomOperation("start2")>]
        member _.Start2(state: MlGetBucketsRequest, value: DateTime) =
            { state with MlGetBucketsRequest.Start2 = Option.Some value } : MlGetBucketsRequest

    let mlGetBucketsRequest = MlGetBucketsRequestBuilder()

    type MlGetCalendarEventsRequest = {
        CalendarId: Id
        End: DateTime option
        From: float option
        JobId: Id option
        Size: float option
        Start: DateTime option
    } with
        static member ToRequest(request: MlGetCalendarEventsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/calendars/{request.CalendarId}/events"
                let queryParams =
                    [
                        request.End |> Option.map (fun v -> "end", Fes.Http.toQueryValue v)
                        request.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        request.JobId |> Option.map (fun v -> "job_id", Fes.Http.toQueryValue v)
                        request.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                        request.Start |> Option.map (fun v -> "start", Fes.Http.toQueryValue v)
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

    module MlGetCalendarEventsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlGetCalendarEventsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlGetCalendarEventsRequest.ToRequest request

    type MlGetCalendarEventsRequestBuilder() =
        member _.Yield(_: unit) : MlGetCalendarEventsRequest =
            {
                MlGetCalendarEventsRequest.CalendarId = Unchecked.defaultof<Id>
                MlGetCalendarEventsRequest.End = Option.None
                MlGetCalendarEventsRequest.From = Option.None
                MlGetCalendarEventsRequest.JobId = Option.None
                MlGetCalendarEventsRequest.Size = Option.None
                MlGetCalendarEventsRequest.Start = Option.None
            } : MlGetCalendarEventsRequest

        [<CustomOperation("calendar_id")>]
        member _.CalendarId(state: MlGetCalendarEventsRequest, value: Id) =
            { state with MlGetCalendarEventsRequest.CalendarId = value } : MlGetCalendarEventsRequest

        [<CustomOperation("end")>]
        member _.End(state: MlGetCalendarEventsRequest, value: DateTime) =
            { state with MlGetCalendarEventsRequest.End = Option.Some value } : MlGetCalendarEventsRequest

        [<CustomOperation("from")>]
        member _.From(state: MlGetCalendarEventsRequest, value: float) =
            { state with MlGetCalendarEventsRequest.From = Option.Some value } : MlGetCalendarEventsRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlGetCalendarEventsRequest, value: Id) =
            { state with MlGetCalendarEventsRequest.JobId = Option.Some value } : MlGetCalendarEventsRequest

        [<CustomOperation("size")>]
        member _.Size(state: MlGetCalendarEventsRequest, value: float) =
            { state with MlGetCalendarEventsRequest.Size = Option.Some value } : MlGetCalendarEventsRequest

        [<CustomOperation("start")>]
        member _.Start(state: MlGetCalendarEventsRequest, value: DateTime) =
            { state with MlGetCalendarEventsRequest.Start = Option.Some value } : MlGetCalendarEventsRequest

    let mlGetCalendarEventsRequest = MlGetCalendarEventsRequestBuilder()

    type MlGetCalendarEventsResponse = {
        [<JsonPropertyName("count")>]
        Count: float
        [<JsonPropertyName("events")>]
        Events: TypesCalendarEvent array
    }

    type MlPostCalendarEventsRequest = {
        CalendarId: Id
        [<JsonPropertyName("events")>]
        Events: TypesCalendarEvent array
    } with
        static member ToRequest(request: MlPostCalendarEventsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/calendars/{request.CalendarId}/events"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``events`` = request.Events |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlPostCalendarEventsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlPostCalendarEventsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlPostCalendarEventsRequest.ToRequest request

    type MlPostCalendarEventsRequestBuilder() =
        member _.Yield(_: unit) : MlPostCalendarEventsRequest =
            {
                MlPostCalendarEventsRequest.CalendarId = Unchecked.defaultof<Id>
                MlPostCalendarEventsRequest.Events = [||]
            } : MlPostCalendarEventsRequest

        [<CustomOperation("calendar_id")>]
        member _.CalendarId(state: MlPostCalendarEventsRequest, value: Id) =
            { state with MlPostCalendarEventsRequest.CalendarId = value } : MlPostCalendarEventsRequest

        [<CustomOperation("events")>]
        member _.Events(state: MlPostCalendarEventsRequest, value: TypesCalendarEvent array) =
            { state with MlPostCalendarEventsRequest.Events = value } : MlPostCalendarEventsRequest

    let mlPostCalendarEventsRequest = MlPostCalendarEventsRequestBuilder()

    type MlPostCalendarEventsResponse = {
        [<JsonPropertyName("events")>]
        Events: TypesCalendarEvent array
    }

    type MlGetCategoriesRequest = {
        JobId: Id
        CategoryId: CategoryId
        From: float option
        PartitionFieldValue: string option
        Size: float option
        [<JsonPropertyName("page")>]
        Page: TypesPage option
    } with
        static member ToRequest(request: MlGetCategoriesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{request.JobId}/results/categories/{request.CategoryId}"
                let queryParams =
                    [
                        request.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        request.PartitionFieldValue |> Option.map (fun v -> "partition_field_value", Fes.Http.toQueryValue v)
                        request.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``page`` = request.Page |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlGetCategoriesRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlGetCategoriesRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlGetCategoriesRequest.ToRequest request

    type MlGetCategoriesRequestBuilder() =
        member _.Yield(_: unit) : MlGetCategoriesRequest =
            {
                MlGetCategoriesRequest.JobId = Unchecked.defaultof<Id>
                MlGetCategoriesRequest.CategoryId = Unchecked.defaultof<CategoryId>
                MlGetCategoriesRequest.From = Option.None
                MlGetCategoriesRequest.PartitionFieldValue = Option.None
                MlGetCategoriesRequest.Size = Option.None
                MlGetCategoriesRequest.Page = Option.None
            } : MlGetCategoriesRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlGetCategoriesRequest, value: Id) =
            { state with MlGetCategoriesRequest.JobId = value } : MlGetCategoriesRequest

        [<CustomOperation("category_id")>]
        member _.CategoryId(state: MlGetCategoriesRequest, value: CategoryId) =
            { state with MlGetCategoriesRequest.CategoryId = value } : MlGetCategoriesRequest

        [<CustomOperation("from")>]
        member _.From(state: MlGetCategoriesRequest, value: float) =
            { state with MlGetCategoriesRequest.From = Option.Some value } : MlGetCategoriesRequest

        [<CustomOperation("partition_field_value")>]
        member _.PartitionFieldValue(state: MlGetCategoriesRequest, value: string) =
            { state with MlGetCategoriesRequest.PartitionFieldValue = Option.Some value } : MlGetCategoriesRequest

        [<CustomOperation("size")>]
        member _.Size(state: MlGetCategoriesRequest, value: float) =
            { state with MlGetCategoriesRequest.Size = Option.Some value } : MlGetCategoriesRequest

        [<CustomOperation("page")>]
        member _.Page(state: MlGetCategoriesRequest, value: TypesPage) =
            { state with MlGetCategoriesRequest.Page = Option.Some value } : MlGetCategoriesRequest

    let mlGetCategoriesRequest = MlGetCategoriesRequestBuilder()

    type MlGetDatafeedStatsRequest = {
        DatafeedId: Ids
        AllowNoMatch: bool option
    } with
        static member ToRequest(request: MlGetDatafeedStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/datafeeds/{request.DatafeedId}/_stats"
                let queryParams =
                    [
                        request.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
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

    module MlGetDatafeedStatsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlGetDatafeedStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlGetDatafeedStatsRequest.ToRequest request

    type MlGetDatafeedStatsRequestBuilder() =
        member _.Yield(_: unit) : MlGetDatafeedStatsRequest =
            {
                MlGetDatafeedStatsRequest.DatafeedId = Unchecked.defaultof<Ids>
                MlGetDatafeedStatsRequest.AllowNoMatch = Option.None
            } : MlGetDatafeedStatsRequest

        [<CustomOperation("datafeed_id")>]
        member _.DatafeedId(state: MlGetDatafeedStatsRequest, value: Ids) =
            { state with MlGetDatafeedStatsRequest.DatafeedId = value } : MlGetDatafeedStatsRequest

        [<CustomOperation("allow_no_match")>]
        member _.AllowNoMatch(state: MlGetDatafeedStatsRequest, value: bool) =
            { state with MlGetDatafeedStatsRequest.AllowNoMatch = Option.Some value } : MlGetDatafeedStatsRequest

    let mlGetDatafeedStatsRequest = MlGetDatafeedStatsRequestBuilder()

    type MlGetInfluencersRequest = {
        JobId: Id
        Desc: bool option
        End: DateTime option
        ExcludeInterim: bool option
        InfluencerScore: float option
        From: float option
        Size: float option
        Sort: Field option
        Start: DateTime option
        [<JsonPropertyName("page")>]
        Page: TypesPage option
    } with
        static member ToRequest(request: MlGetInfluencersRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{request.JobId}/results/influencers"
                let queryParams =
                    [
                        request.Desc |> Option.map (fun v -> "desc", Fes.Http.toQueryValue v)
                        request.End |> Option.map (fun v -> "end", Fes.Http.toQueryValue v)
                        request.ExcludeInterim |> Option.map (fun v -> "exclude_interim", Fes.Http.toQueryValue v)
                        request.InfluencerScore |> Option.map (fun v -> "influencer_score", Fes.Http.toQueryValue v)
                        request.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        request.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                        request.Sort |> Option.map (fun v -> "sort", Fes.Http.toQueryValue v)
                        request.Start |> Option.map (fun v -> "start", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``page`` = request.Page |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlGetInfluencersRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlGetInfluencersRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlGetInfluencersRequest.ToRequest request

    type MlGetInfluencersRequestBuilder() =
        member _.Yield(_: unit) : MlGetInfluencersRequest =
            {
                MlGetInfluencersRequest.JobId = Unchecked.defaultof<Id>
                MlGetInfluencersRequest.Desc = Option.None
                MlGetInfluencersRequest.End = Option.None
                MlGetInfluencersRequest.ExcludeInterim = Option.None
                MlGetInfluencersRequest.InfluencerScore = Option.None
                MlGetInfluencersRequest.From = Option.None
                MlGetInfluencersRequest.Size = Option.None
                MlGetInfluencersRequest.Sort = Option.None
                MlGetInfluencersRequest.Start = Option.None
                MlGetInfluencersRequest.Page = Option.None
            } : MlGetInfluencersRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlGetInfluencersRequest, value: Id) =
            { state with MlGetInfluencersRequest.JobId = value } : MlGetInfluencersRequest

        [<CustomOperation("desc")>]
        member _.Desc(state: MlGetInfluencersRequest, value: bool) =
            { state with MlGetInfluencersRequest.Desc = Option.Some value } : MlGetInfluencersRequest

        [<CustomOperation("end")>]
        member _.End(state: MlGetInfluencersRequest, value: DateTime) =
            { state with MlGetInfluencersRequest.End = Option.Some value } : MlGetInfluencersRequest

        [<CustomOperation("exclude_interim")>]
        member _.ExcludeInterim(state: MlGetInfluencersRequest, value: bool) =
            { state with MlGetInfluencersRequest.ExcludeInterim = Option.Some value } : MlGetInfluencersRequest

        [<CustomOperation("influencer_score")>]
        member _.InfluencerScore(state: MlGetInfluencersRequest, value: float) =
            { state with MlGetInfluencersRequest.InfluencerScore = Option.Some value } : MlGetInfluencersRequest

        [<CustomOperation("from")>]
        member _.From(state: MlGetInfluencersRequest, value: float) =
            { state with MlGetInfluencersRequest.From = Option.Some value } : MlGetInfluencersRequest

        [<CustomOperation("size")>]
        member _.Size(state: MlGetInfluencersRequest, value: float) =
            { state with MlGetInfluencersRequest.Size = Option.Some value } : MlGetInfluencersRequest

        [<CustomOperation("sort")>]
        member _.Sort(state: MlGetInfluencersRequest, value: Field) =
            { state with MlGetInfluencersRequest.Sort = Option.Some value } : MlGetInfluencersRequest

        [<CustomOperation("start")>]
        member _.Start(state: MlGetInfluencersRequest, value: DateTime) =
            { state with MlGetInfluencersRequest.Start = Option.Some value } : MlGetInfluencersRequest

        [<CustomOperation("page")>]
        member _.Page(state: MlGetInfluencersRequest, value: TypesPage) =
            { state with MlGetInfluencersRequest.Page = Option.Some value } : MlGetInfluencersRequest

    let mlGetInfluencersRequest = MlGetInfluencersRequestBuilder()

    type MlGetJobStatsRequest = {
        JobId: Id
        AllowNoMatch: bool option
    } with
        static member ToRequest(request: MlGetJobStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{request.JobId}/_stats"
                let queryParams =
                    [
                        request.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
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

    module MlGetJobStatsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlGetJobStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlGetJobStatsRequest.ToRequest request

    type MlGetJobStatsRequestBuilder() =
        member _.Yield(_: unit) : MlGetJobStatsRequest =
            {
                MlGetJobStatsRequest.JobId = Unchecked.defaultof<Id>
                MlGetJobStatsRequest.AllowNoMatch = Option.None
            } : MlGetJobStatsRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlGetJobStatsRequest, value: Id) =
            { state with MlGetJobStatsRequest.JobId = value } : MlGetJobStatsRequest

        [<CustomOperation("allow_no_match")>]
        member _.AllowNoMatch(state: MlGetJobStatsRequest, value: bool) =
            { state with MlGetJobStatsRequest.AllowNoMatch = Option.Some value } : MlGetJobStatsRequest

    let mlGetJobStatsRequest = MlGetJobStatsRequestBuilder()

    type MlGetModelSnapshotUpgradeStatsRequest = {
        JobId: Id
        SnapshotId: Id
        AllowNoMatch: bool option
    } with
        static member ToRequest(request: MlGetModelSnapshotUpgradeStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{request.JobId}/model_snapshots/{request.SnapshotId}/_upgrade/_stats"
                let queryParams =
                    [
                        request.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
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

    module MlGetModelSnapshotUpgradeStatsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlGetModelSnapshotUpgradeStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlGetModelSnapshotUpgradeStatsRequest.ToRequest request

    type MlGetModelSnapshotUpgradeStatsRequestBuilder() =
        member _.Yield(_: unit) : MlGetModelSnapshotUpgradeStatsRequest =
            {
                MlGetModelSnapshotUpgradeStatsRequest.JobId = Unchecked.defaultof<Id>
                MlGetModelSnapshotUpgradeStatsRequest.SnapshotId = Unchecked.defaultof<Id>
                MlGetModelSnapshotUpgradeStatsRequest.AllowNoMatch = Option.None
            } : MlGetModelSnapshotUpgradeStatsRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlGetModelSnapshotUpgradeStatsRequest, value: Id) =
            { state with MlGetModelSnapshotUpgradeStatsRequest.JobId = value } : MlGetModelSnapshotUpgradeStatsRequest

        [<CustomOperation("snapshot_id")>]
        member _.SnapshotId(state: MlGetModelSnapshotUpgradeStatsRequest, value: Id) =
            { state with MlGetModelSnapshotUpgradeStatsRequest.SnapshotId = value } : MlGetModelSnapshotUpgradeStatsRequest

        [<CustomOperation("allow_no_match")>]
        member _.AllowNoMatch(state: MlGetModelSnapshotUpgradeStatsRequest, value: bool) =
            { state with MlGetModelSnapshotUpgradeStatsRequest.AllowNoMatch = Option.Some value } : MlGetModelSnapshotUpgradeStatsRequest

    let mlGetModelSnapshotUpgradeStatsRequest = MlGetModelSnapshotUpgradeStatsRequestBuilder()

    type MlGetModelSnapshotUpgradeStatsResponse = {
        [<JsonPropertyName("count")>]
        Count: float
        [<JsonPropertyName("model_snapshot_upgrades")>]
        ModelSnapshotUpgrades: TypesModelSnapshotUpgrade array
    }

    type MlGetOverallBucketsRequest = {
        JobId: Id
        AllowNoMatch: bool option
        BucketSpan: Duration option
        End: DateTime option
        ExcludeInterim: bool option
        OverallScore: float option
        Start: DateTime option
        TopN: float option
        [<JsonPropertyName("allow_no_match")>]
        AllowNoMatch2: bool option
        [<JsonPropertyName("bucket_span")>]
        BucketSpan2: Duration option
        [<JsonPropertyName("end")>]
        End2: DateTime option
        [<JsonPropertyName("exclude_interim")>]
        ExcludeInterim2: bool option
        [<JsonPropertyName("overall_score")>]
        OverallScore2: float option
        [<JsonPropertyName("start")>]
        Start2: DateTime option
        [<JsonPropertyName("top_n")>]
        TopN2: float option
    } with
        static member ToRequest(request: MlGetOverallBucketsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{request.JobId}/results/overall_buckets"
                let queryParams =
                    [
                        request.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                        request.BucketSpan |> Option.map (fun v -> "bucket_span", Fes.Http.toQueryValue v)
                        request.End |> Option.map (fun v -> "end", Fes.Http.toQueryValue v)
                        request.ExcludeInterim |> Option.map (fun v -> "exclude_interim", Fes.Http.toQueryValue v)
                        request.OverallScore |> Option.map (fun v -> "overall_score", Fes.Http.toQueryValue v)
                        request.Start |> Option.map (fun v -> "start", Fes.Http.toQueryValue v)
                        request.TopN |> Option.map (fun v -> "top_n", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``allow_no_match`` = request.AllowNoMatch2; ``bucket_span`` = request.BucketSpan2; ``end`` = request.End2; ``exclude_interim`` = request.ExcludeInterim2; ``overall_score`` = request.OverallScore2; ``start`` = request.Start2; ``top_n`` = request.TopN2 |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlGetOverallBucketsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlGetOverallBucketsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlGetOverallBucketsRequest.ToRequest request

    type MlGetOverallBucketsRequestBuilder() =
        member _.Yield(_: unit) : MlGetOverallBucketsRequest =
            {
                MlGetOverallBucketsRequest.JobId = Unchecked.defaultof<Id>
                MlGetOverallBucketsRequest.AllowNoMatch = Option.None
                MlGetOverallBucketsRequest.BucketSpan = Option.None
                MlGetOverallBucketsRequest.End = Option.None
                MlGetOverallBucketsRequest.ExcludeInterim = Option.None
                MlGetOverallBucketsRequest.OverallScore = Option.None
                MlGetOverallBucketsRequest.Start = Option.None
                MlGetOverallBucketsRequest.TopN = Option.None
                MlGetOverallBucketsRequest.AllowNoMatch2 = Option.None
                MlGetOverallBucketsRequest.BucketSpan2 = Option.None
                MlGetOverallBucketsRequest.End2 = Option.None
                MlGetOverallBucketsRequest.ExcludeInterim2 = Option.None
                MlGetOverallBucketsRequest.OverallScore2 = Option.None
                MlGetOverallBucketsRequest.Start2 = Option.None
                MlGetOverallBucketsRequest.TopN2 = Option.None
            } : MlGetOverallBucketsRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlGetOverallBucketsRequest, value: Id) =
            { state with MlGetOverallBucketsRequest.JobId = value } : MlGetOverallBucketsRequest

        [<CustomOperation("allow_no_match")>]
        member _.AllowNoMatch(state: MlGetOverallBucketsRequest, value: bool) =
            { state with MlGetOverallBucketsRequest.AllowNoMatch = Option.Some value } : MlGetOverallBucketsRequest

        [<CustomOperation("bucket_span")>]
        member _.BucketSpan(state: MlGetOverallBucketsRequest, value: Duration) =
            { state with MlGetOverallBucketsRequest.BucketSpan = Option.Some value } : MlGetOverallBucketsRequest

        [<CustomOperation("end")>]
        member _.End(state: MlGetOverallBucketsRequest, value: DateTime) =
            { state with MlGetOverallBucketsRequest.End = Option.Some value } : MlGetOverallBucketsRequest

        [<CustomOperation("exclude_interim")>]
        member _.ExcludeInterim(state: MlGetOverallBucketsRequest, value: bool) =
            { state with MlGetOverallBucketsRequest.ExcludeInterim = Option.Some value } : MlGetOverallBucketsRequest

        [<CustomOperation("overall_score")>]
        member _.OverallScore(state: MlGetOverallBucketsRequest, value: float) =
            { state with MlGetOverallBucketsRequest.OverallScore = Option.Some value } : MlGetOverallBucketsRequest

        [<CustomOperation("start")>]
        member _.Start(state: MlGetOverallBucketsRequest, value: DateTime) =
            { state with MlGetOverallBucketsRequest.Start = Option.Some value } : MlGetOverallBucketsRequest

        [<CustomOperation("top_n")>]
        member _.TopN(state: MlGetOverallBucketsRequest, value: float) =
            { state with MlGetOverallBucketsRequest.TopN = Option.Some value } : MlGetOverallBucketsRequest

        [<CustomOperation("allow_no_match2")>]
        member _.AllowNoMatch2(state: MlGetOverallBucketsRequest, value: bool) =
            { state with MlGetOverallBucketsRequest.AllowNoMatch2 = Option.Some value } : MlGetOverallBucketsRequest

        [<CustomOperation("bucket_span2")>]
        member _.BucketSpan2(state: MlGetOverallBucketsRequest, value: Duration) =
            { state with MlGetOverallBucketsRequest.BucketSpan2 = Option.Some value } : MlGetOverallBucketsRequest

        [<CustomOperation("end2")>]
        member _.End2(state: MlGetOverallBucketsRequest, value: DateTime) =
            { state with MlGetOverallBucketsRequest.End2 = Option.Some value } : MlGetOverallBucketsRequest

        [<CustomOperation("exclude_interim2")>]
        member _.ExcludeInterim2(state: MlGetOverallBucketsRequest, value: bool) =
            { state with MlGetOverallBucketsRequest.ExcludeInterim2 = Option.Some value } : MlGetOverallBucketsRequest

        [<CustomOperation("overall_score2")>]
        member _.OverallScore2(state: MlGetOverallBucketsRequest, value: float) =
            { state with MlGetOverallBucketsRequest.OverallScore2 = Option.Some value } : MlGetOverallBucketsRequest

        [<CustomOperation("start2")>]
        member _.Start2(state: MlGetOverallBucketsRequest, value: DateTime) =
            { state with MlGetOverallBucketsRequest.Start2 = Option.Some value } : MlGetOverallBucketsRequest

        [<CustomOperation("top_n2")>]
        member _.TopN2(state: MlGetOverallBucketsRequest, value: float) =
            { state with MlGetOverallBucketsRequest.TopN2 = Option.Some value } : MlGetOverallBucketsRequest

    let mlGetOverallBucketsRequest = MlGetOverallBucketsRequestBuilder()

    type MlGetRecordsRequest = {
        JobId: Id
        Desc: bool option
        End: DateTime option
        ExcludeInterim: bool option
        From: float option
        RecordScore: float option
        Size: float option
        Sort: Field option
        Start: DateTime option
        [<JsonPropertyName("desc")>]
        Desc2: bool option
        [<JsonPropertyName("end")>]
        End2: DateTime option
        [<JsonPropertyName("exclude_interim")>]
        ExcludeInterim2: bool option
        [<JsonPropertyName("page")>]
        Page: TypesPage option
        [<JsonPropertyName("record_score")>]
        RecordScore2: float option
        [<JsonPropertyName("sort")>]
        Sort2: Field option
        [<JsonPropertyName("start")>]
        Start2: DateTime option
    } with
        static member ToRequest(request: MlGetRecordsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{request.JobId}/results/records"
                let queryParams =
                    [
                        request.Desc |> Option.map (fun v -> "desc", Fes.Http.toQueryValue v)
                        request.End |> Option.map (fun v -> "end", Fes.Http.toQueryValue v)
                        request.ExcludeInterim |> Option.map (fun v -> "exclude_interim", Fes.Http.toQueryValue v)
                        request.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        request.RecordScore |> Option.map (fun v -> "record_score", Fes.Http.toQueryValue v)
                        request.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                        request.Sort |> Option.map (fun v -> "sort", Fes.Http.toQueryValue v)
                        request.Start |> Option.map (fun v -> "start", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``desc`` = request.Desc2; ``end`` = request.End2; ``exclude_interim`` = request.ExcludeInterim2; ``page`` = request.Page; ``record_score`` = request.RecordScore2; ``sort`` = request.Sort2; ``start`` = request.Start2 |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlGetRecordsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlGetRecordsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlGetRecordsRequest.ToRequest request

    type MlGetRecordsRequestBuilder() =
        member _.Yield(_: unit) : MlGetRecordsRequest =
            {
                MlGetRecordsRequest.JobId = Unchecked.defaultof<Id>
                MlGetRecordsRequest.Desc = Option.None
                MlGetRecordsRequest.End = Option.None
                MlGetRecordsRequest.ExcludeInterim = Option.None
                MlGetRecordsRequest.From = Option.None
                MlGetRecordsRequest.RecordScore = Option.None
                MlGetRecordsRequest.Size = Option.None
                MlGetRecordsRequest.Sort = Option.None
                MlGetRecordsRequest.Start = Option.None
                MlGetRecordsRequest.Desc2 = Option.None
                MlGetRecordsRequest.End2 = Option.None
                MlGetRecordsRequest.ExcludeInterim2 = Option.None
                MlGetRecordsRequest.Page = Option.None
                MlGetRecordsRequest.RecordScore2 = Option.None
                MlGetRecordsRequest.Sort2 = Option.None
                MlGetRecordsRequest.Start2 = Option.None
            } : MlGetRecordsRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlGetRecordsRequest, value: Id) =
            { state with MlGetRecordsRequest.JobId = value } : MlGetRecordsRequest

        [<CustomOperation("desc")>]
        member _.Desc(state: MlGetRecordsRequest, value: bool) =
            { state with MlGetRecordsRequest.Desc = Option.Some value } : MlGetRecordsRequest

        [<CustomOperation("end")>]
        member _.End(state: MlGetRecordsRequest, value: DateTime) =
            { state with MlGetRecordsRequest.End = Option.Some value } : MlGetRecordsRequest

        [<CustomOperation("exclude_interim")>]
        member _.ExcludeInterim(state: MlGetRecordsRequest, value: bool) =
            { state with MlGetRecordsRequest.ExcludeInterim = Option.Some value } : MlGetRecordsRequest

        [<CustomOperation("from")>]
        member _.From(state: MlGetRecordsRequest, value: float) =
            { state with MlGetRecordsRequest.From = Option.Some value } : MlGetRecordsRequest

        [<CustomOperation("record_score")>]
        member _.RecordScore(state: MlGetRecordsRequest, value: float) =
            { state with MlGetRecordsRequest.RecordScore = Option.Some value } : MlGetRecordsRequest

        [<CustomOperation("size")>]
        member _.Size(state: MlGetRecordsRequest, value: float) =
            { state with MlGetRecordsRequest.Size = Option.Some value } : MlGetRecordsRequest

        [<CustomOperation("sort")>]
        member _.Sort(state: MlGetRecordsRequest, value: Field) =
            { state with MlGetRecordsRequest.Sort = Option.Some value } : MlGetRecordsRequest

        [<CustomOperation("start")>]
        member _.Start(state: MlGetRecordsRequest, value: DateTime) =
            { state with MlGetRecordsRequest.Start = Option.Some value } : MlGetRecordsRequest

        [<CustomOperation("desc2")>]
        member _.Desc2(state: MlGetRecordsRequest, value: bool) =
            { state with MlGetRecordsRequest.Desc2 = Option.Some value } : MlGetRecordsRequest

        [<CustomOperation("end2")>]
        member _.End2(state: MlGetRecordsRequest, value: DateTime) =
            { state with MlGetRecordsRequest.End2 = Option.Some value } : MlGetRecordsRequest

        [<CustomOperation("exclude_interim2")>]
        member _.ExcludeInterim2(state: MlGetRecordsRequest, value: bool) =
            { state with MlGetRecordsRequest.ExcludeInterim2 = Option.Some value } : MlGetRecordsRequest

        [<CustomOperation("page")>]
        member _.Page(state: MlGetRecordsRequest, value: TypesPage) =
            { state with MlGetRecordsRequest.Page = Option.Some value } : MlGetRecordsRequest

        [<CustomOperation("record_score2")>]
        member _.RecordScore2(state: MlGetRecordsRequest, value: float) =
            { state with MlGetRecordsRequest.RecordScore2 = Option.Some value } : MlGetRecordsRequest

        [<CustomOperation("sort2")>]
        member _.Sort2(state: MlGetRecordsRequest, value: Field) =
            { state with MlGetRecordsRequest.Sort2 = Option.Some value } : MlGetRecordsRequest

        [<CustomOperation("start2")>]
        member _.Start2(state: MlGetRecordsRequest, value: DateTime) =
            { state with MlGetRecordsRequest.Start2 = Option.Some value } : MlGetRecordsRequest

    let mlGetRecordsRequest = MlGetRecordsRequestBuilder()

    type MlOpenJobRequest = {
        JobId: Id
        Timeout: Duration option
        [<JsonPropertyName("timeout")>]
        Timeout2: Duration option
    } with
        static member ToRequest(request: MlOpenJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{request.JobId}/_open"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``timeout`` = request.Timeout2 |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlOpenJobRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlOpenJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlOpenJobRequest.ToRequest request

    type MlOpenJobRequestBuilder() =
        member _.Yield(_: unit) : MlOpenJobRequest =
            {
                MlOpenJobRequest.JobId = Unchecked.defaultof<Id>
                MlOpenJobRequest.Timeout = Option.None
                MlOpenJobRequest.Timeout2 = Option.None
            } : MlOpenJobRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlOpenJobRequest, value: Id) =
            { state with MlOpenJobRequest.JobId = value } : MlOpenJobRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlOpenJobRequest, value: Duration) =
            { state with MlOpenJobRequest.Timeout = Option.Some value } : MlOpenJobRequest

        [<CustomOperation("timeout2")>]
        member _.Timeout2(state: MlOpenJobRequest, value: Duration) =
            { state with MlOpenJobRequest.Timeout2 = Option.Some value } : MlOpenJobRequest

    let mlOpenJobRequest = MlOpenJobRequestBuilder()

    type MlOpenJobResponse = {
        [<JsonPropertyName("opened")>]
        Opened: bool
        [<JsonPropertyName("node")>]
        Node: NodeId
    }

    type MlPostDataRequest = {
        JobId: Id
        ResetEnd: DateTime option
        ResetStart: DateTime option
    } with
        static member ToRequest(request: MlPostDataRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{request.JobId}/_data"
                let queryParams =
                    [
                        request.ResetEnd |> Option.map (fun v -> "reset_end", Fes.Http.toQueryValue v)
                        request.ResetStart |> Option.map (fun v -> "reset_start", Fes.Http.toQueryValue v)
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

    module MlPostDataRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlPostDataRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlPostDataRequest.ToRequest request

    type MlPostDataRequestBuilder() =
        member _.Yield(_: unit) : MlPostDataRequest =
            {
                MlPostDataRequest.JobId = Unchecked.defaultof<Id>
                MlPostDataRequest.ResetEnd = Option.None
                MlPostDataRequest.ResetStart = Option.None
            } : MlPostDataRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlPostDataRequest, value: Id) =
            { state with MlPostDataRequest.JobId = value } : MlPostDataRequest

        [<CustomOperation("reset_end")>]
        member _.ResetEnd(state: MlPostDataRequest, value: DateTime) =
            { state with MlPostDataRequest.ResetEnd = Option.Some value } : MlPostDataRequest

        [<CustomOperation("reset_start")>]
        member _.ResetStart(state: MlPostDataRequest, value: DateTime) =
            { state with MlPostDataRequest.ResetStart = Option.Some value } : MlPostDataRequest

    let mlPostDataRequest = MlPostDataRequestBuilder()

    type MlPostDataResponse = {
        [<JsonPropertyName("job_id")>]
        JobId: Id
        [<JsonPropertyName("processed_record_count")>]
        ProcessedRecordCount: float
        [<JsonPropertyName("processed_field_count")>]
        ProcessedFieldCount: float
        [<JsonPropertyName("input_bytes")>]
        InputBytes: float
        [<JsonPropertyName("input_field_count")>]
        InputFieldCount: float
        [<JsonPropertyName("invalid_date_count")>]
        InvalidDateCount: float
        [<JsonPropertyName("missing_field_count")>]
        MissingFieldCount: float
        [<JsonPropertyName("out_of_order_timestamp_count")>]
        OutOfOrderTimestampCount: float
        [<JsonPropertyName("empty_bucket_count")>]
        EmptyBucketCount: float
        [<JsonPropertyName("sparse_bucket_count")>]
        SparseBucketCount: float
        [<JsonPropertyName("bucket_count")>]
        BucketCount: float
        [<JsonPropertyName("earliest_record_timestamp")>]
        EarliestRecordTimestamp: EpochTimeUnitMillis option
        [<JsonPropertyName("latest_record_timestamp")>]
        LatestRecordTimestamp: EpochTimeUnitMillis option
        [<JsonPropertyName("last_data_time")>]
        LastDataTime: EpochTimeUnitMillis option
        [<JsonPropertyName("latest_empty_bucket_timestamp")>]
        LatestEmptyBucketTimestamp: EpochTimeUnitMillis option
        [<JsonPropertyName("latest_sparse_bucket_timestamp")>]
        LatestSparseBucketTimestamp: EpochTimeUnitMillis option
        [<JsonPropertyName("input_record_count")>]
        InputRecordCount: float
        [<JsonPropertyName("log_time")>]
        LogTime: EpochTimeUnitMillis option
    }

    type MlPreviewDatafeedRequest = {
        DatafeedId: Id
        Start: DateTime option
        End: DateTime option
        [<JsonPropertyName("datafeed_config")>]
        DatafeedConfig: TypesDatafeedConfig option
        [<JsonPropertyName("job_config")>]
        JobConfig: TypesJobConfig option
    } with
        static member ToRequest(request: MlPreviewDatafeedRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/datafeeds/{request.DatafeedId}/_preview"
                let queryParams =
                    [
                        request.Start |> Option.map (fun v -> "start", Fes.Http.toQueryValue v)
                        request.End |> Option.map (fun v -> "end", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``datafeed_config`` = request.DatafeedConfig; ``job_config`` = request.JobConfig |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlPreviewDatafeedRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlPreviewDatafeedRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlPreviewDatafeedRequest.ToRequest request

    type MlPreviewDatafeedRequestBuilder() =
        member _.Yield(_: unit) : MlPreviewDatafeedRequest =
            {
                MlPreviewDatafeedRequest.DatafeedId = Unchecked.defaultof<Id>
                MlPreviewDatafeedRequest.Start = Option.None
                MlPreviewDatafeedRequest.End = Option.None
                MlPreviewDatafeedRequest.DatafeedConfig = Option.None
                MlPreviewDatafeedRequest.JobConfig = Option.None
            } : MlPreviewDatafeedRequest

        [<CustomOperation("datafeed_id")>]
        member _.DatafeedId(state: MlPreviewDatafeedRequest, value: Id) =
            { state with MlPreviewDatafeedRequest.DatafeedId = value } : MlPreviewDatafeedRequest

        [<CustomOperation("start")>]
        member _.Start(state: MlPreviewDatafeedRequest, value: DateTime) =
            { state with MlPreviewDatafeedRequest.Start = Option.Some value } : MlPreviewDatafeedRequest

        [<CustomOperation("end")>]
        member _.End(state: MlPreviewDatafeedRequest, value: DateTime) =
            { state with MlPreviewDatafeedRequest.End = Option.Some value } : MlPreviewDatafeedRequest

        [<CustomOperation("datafeed_config")>]
        member _.DatafeedConfig(state: MlPreviewDatafeedRequest, value: TypesDatafeedConfig) =
            { state with MlPreviewDatafeedRequest.DatafeedConfig = Option.Some value } : MlPreviewDatafeedRequest

        [<CustomOperation("job_config")>]
        member _.JobConfig(state: MlPreviewDatafeedRequest, value: TypesJobConfig) =
            { state with MlPreviewDatafeedRequest.JobConfig = Option.Some value } : MlPreviewDatafeedRequest

    let mlPreviewDatafeedRequest = MlPreviewDatafeedRequestBuilder()

    type MlResetJobRequest = {
        JobId: Id
        WaitForCompletion: bool option
        DeleteUserAnnotations: bool option
    } with
        static member ToRequest(request: MlResetJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{request.JobId}/_reset"
                let queryParams =
                    [
                        request.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                        request.DeleteUserAnnotations |> Option.map (fun v -> "delete_user_annotations", Fes.Http.toQueryValue v)
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

    module MlResetJobRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlResetJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlResetJobRequest.ToRequest request

    type MlResetJobRequestBuilder() =
        member _.Yield(_: unit) : MlResetJobRequest =
            {
                MlResetJobRequest.JobId = Unchecked.defaultof<Id>
                MlResetJobRequest.WaitForCompletion = Option.None
                MlResetJobRequest.DeleteUserAnnotations = Option.None
            } : MlResetJobRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlResetJobRequest, value: Id) =
            { state with MlResetJobRequest.JobId = value } : MlResetJobRequest

        [<CustomOperation("wait_for_completion")>]
        member _.WaitForCompletion(state: MlResetJobRequest, value: bool) =
            { state with MlResetJobRequest.WaitForCompletion = Option.Some value } : MlResetJobRequest

        [<CustomOperation("delete_user_annotations")>]
        member _.DeleteUserAnnotations(state: MlResetJobRequest, value: bool) =
            { state with MlResetJobRequest.DeleteUserAnnotations = Option.Some value } : MlResetJobRequest

    let mlResetJobRequest = MlResetJobRequestBuilder()

    type MlResetJobResponse = AcknowledgedResponseBase

    type MlRevertModelSnapshotRequest = {
        JobId: Id
        SnapshotId: Id
        DeleteInterveningResults: bool option
        [<JsonPropertyName("delete_intervening_results")>]
        DeleteInterveningResults2: bool option
    } with
        static member ToRequest(request: MlRevertModelSnapshotRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{request.JobId}/model_snapshots/{request.SnapshotId}/_revert"
                let queryParams =
                    [
                        request.DeleteInterveningResults |> Option.map (fun v -> "delete_intervening_results", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``delete_intervening_results`` = request.DeleteInterveningResults2 |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlRevertModelSnapshotRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlRevertModelSnapshotRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlRevertModelSnapshotRequest.ToRequest request

    type MlRevertModelSnapshotRequestBuilder() =
        member _.Yield(_: unit) : MlRevertModelSnapshotRequest =
            {
                MlRevertModelSnapshotRequest.JobId = Unchecked.defaultof<Id>
                MlRevertModelSnapshotRequest.SnapshotId = Unchecked.defaultof<Id>
                MlRevertModelSnapshotRequest.DeleteInterveningResults = Option.None
                MlRevertModelSnapshotRequest.DeleteInterveningResults2 = Option.None
            } : MlRevertModelSnapshotRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlRevertModelSnapshotRequest, value: Id) =
            { state with MlRevertModelSnapshotRequest.JobId = value } : MlRevertModelSnapshotRequest

        [<CustomOperation("snapshot_id")>]
        member _.SnapshotId(state: MlRevertModelSnapshotRequest, value: Id) =
            { state with MlRevertModelSnapshotRequest.SnapshotId = value } : MlRevertModelSnapshotRequest

        [<CustomOperation("delete_intervening_results")>]
        member _.DeleteInterveningResults(state: MlRevertModelSnapshotRequest, value: bool) =
            { state with MlRevertModelSnapshotRequest.DeleteInterveningResults = Option.Some value } : MlRevertModelSnapshotRequest

        [<CustomOperation("delete_intervening_results2")>]
        member _.DeleteInterveningResults2(state: MlRevertModelSnapshotRequest, value: bool) =
            { state with MlRevertModelSnapshotRequest.DeleteInterveningResults2 = Option.Some value } : MlRevertModelSnapshotRequest

    let mlRevertModelSnapshotRequest = MlRevertModelSnapshotRequestBuilder()

    type MlRevertModelSnapshotResponse = {
        [<JsonPropertyName("model")>]
        Model: TypesModelSnapshot
    }

    type MlStartDatafeedRequest = {
        DatafeedId: Id
        End: DateTime option
        Start: DateTime option
        Timeout: Duration option
        [<JsonPropertyName("end")>]
        End2: DateTime option
        [<JsonPropertyName("start")>]
        Start2: DateTime option
        [<JsonPropertyName("timeout")>]
        Timeout2: Duration option
    } with
        static member ToRequest(request: MlStartDatafeedRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/datafeeds/{request.DatafeedId}/_start"
                let queryParams =
                    [
                        request.End |> Option.map (fun v -> "end", Fes.Http.toQueryValue v)
                        request.Start |> Option.map (fun v -> "start", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``end`` = request.End2; ``start`` = request.Start2; ``timeout`` = request.Timeout2 |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlStartDatafeedRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlStartDatafeedRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlStartDatafeedRequest.ToRequest request

    type MlStartDatafeedRequestBuilder() =
        member _.Yield(_: unit) : MlStartDatafeedRequest =
            {
                MlStartDatafeedRequest.DatafeedId = Unchecked.defaultof<Id>
                MlStartDatafeedRequest.End = Option.None
                MlStartDatafeedRequest.Start = Option.None
                MlStartDatafeedRequest.Timeout = Option.None
                MlStartDatafeedRequest.End2 = Option.None
                MlStartDatafeedRequest.Start2 = Option.None
                MlStartDatafeedRequest.Timeout2 = Option.None
            } : MlStartDatafeedRequest

        [<CustomOperation("datafeed_id")>]
        member _.DatafeedId(state: MlStartDatafeedRequest, value: Id) =
            { state with MlStartDatafeedRequest.DatafeedId = value } : MlStartDatafeedRequest

        [<CustomOperation("end")>]
        member _.End(state: MlStartDatafeedRequest, value: DateTime) =
            { state with MlStartDatafeedRequest.End = Option.Some value } : MlStartDatafeedRequest

        [<CustomOperation("start")>]
        member _.Start(state: MlStartDatafeedRequest, value: DateTime) =
            { state with MlStartDatafeedRequest.Start = Option.Some value } : MlStartDatafeedRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlStartDatafeedRequest, value: Duration) =
            { state with MlStartDatafeedRequest.Timeout = Option.Some value } : MlStartDatafeedRequest

        [<CustomOperation("end2")>]
        member _.End2(state: MlStartDatafeedRequest, value: DateTime) =
            { state with MlStartDatafeedRequest.End2 = Option.Some value } : MlStartDatafeedRequest

        [<CustomOperation("start2")>]
        member _.Start2(state: MlStartDatafeedRequest, value: DateTime) =
            { state with MlStartDatafeedRequest.Start2 = Option.Some value } : MlStartDatafeedRequest

        [<CustomOperation("timeout2")>]
        member _.Timeout2(state: MlStartDatafeedRequest, value: Duration) =
            { state with MlStartDatafeedRequest.Timeout2 = Option.Some value } : MlStartDatafeedRequest

    let mlStartDatafeedRequest = MlStartDatafeedRequestBuilder()

    type MlStartDatafeedResponse = {
        [<JsonPropertyName("node")>]
        Node: NodeIds
        [<JsonPropertyName("started")>]
        Started: bool
    }

    type MlStopDatafeedRequest = {
        DatafeedId: Id
        AllowNoMatch: bool option
        Force: bool option
        Timeout: Duration option
        CloseJob: bool option
        [<JsonPropertyName("allow_no_match")>]
        AllowNoMatch2: bool option
        [<JsonPropertyName("force")>]
        Force2: bool option
        [<JsonPropertyName("timeout")>]
        Timeout2: Duration option
        [<JsonPropertyName("close_job")>]
        CloseJob2: bool option
    } with
        static member ToRequest(request: MlStopDatafeedRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/datafeeds/{request.DatafeedId}/_stop"
                let queryParams =
                    [
                        request.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                        request.Force |> Option.map (fun v -> "force", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        request.CloseJob |> Option.map (fun v -> "close_job", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``allow_no_match`` = request.AllowNoMatch2; ``force`` = request.Force2; ``timeout`` = request.Timeout2; ``close_job`` = request.CloseJob2 |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlStopDatafeedRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlStopDatafeedRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlStopDatafeedRequest.ToRequest request

    type MlStopDatafeedRequestBuilder() =
        member _.Yield(_: unit) : MlStopDatafeedRequest =
            {
                MlStopDatafeedRequest.DatafeedId = Unchecked.defaultof<Id>
                MlStopDatafeedRequest.AllowNoMatch = Option.None
                MlStopDatafeedRequest.Force = Option.None
                MlStopDatafeedRequest.Timeout = Option.None
                MlStopDatafeedRequest.CloseJob = Option.None
                MlStopDatafeedRequest.AllowNoMatch2 = Option.None
                MlStopDatafeedRequest.Force2 = Option.None
                MlStopDatafeedRequest.Timeout2 = Option.None
                MlStopDatafeedRequest.CloseJob2 = Option.None
            } : MlStopDatafeedRequest

        [<CustomOperation("datafeed_id")>]
        member _.DatafeedId(state: MlStopDatafeedRequest, value: Id) =
            { state with MlStopDatafeedRequest.DatafeedId = value } : MlStopDatafeedRequest

        [<CustomOperation("allow_no_match")>]
        member _.AllowNoMatch(state: MlStopDatafeedRequest, value: bool) =
            { state with MlStopDatafeedRequest.AllowNoMatch = Option.Some value } : MlStopDatafeedRequest

        [<CustomOperation("force")>]
        member _.Force(state: MlStopDatafeedRequest, value: bool) =
            { state with MlStopDatafeedRequest.Force = Option.Some value } : MlStopDatafeedRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlStopDatafeedRequest, value: Duration) =
            { state with MlStopDatafeedRequest.Timeout = Option.Some value } : MlStopDatafeedRequest

        [<CustomOperation("close_job")>]
        member _.CloseJob(state: MlStopDatafeedRequest, value: bool) =
            { state with MlStopDatafeedRequest.CloseJob = Option.Some value } : MlStopDatafeedRequest

        [<CustomOperation("allow_no_match2")>]
        member _.AllowNoMatch2(state: MlStopDatafeedRequest, value: bool) =
            { state with MlStopDatafeedRequest.AllowNoMatch2 = Option.Some value } : MlStopDatafeedRequest

        [<CustomOperation("force2")>]
        member _.Force2(state: MlStopDatafeedRequest, value: bool) =
            { state with MlStopDatafeedRequest.Force2 = Option.Some value } : MlStopDatafeedRequest

        [<CustomOperation("timeout2")>]
        member _.Timeout2(state: MlStopDatafeedRequest, value: Duration) =
            { state with MlStopDatafeedRequest.Timeout2 = Option.Some value } : MlStopDatafeedRequest

        [<CustomOperation("close_job2")>]
        member _.CloseJob2(state: MlStopDatafeedRequest, value: bool) =
            { state with MlStopDatafeedRequest.CloseJob2 = Option.Some value } : MlStopDatafeedRequest

    let mlStopDatafeedRequest = MlStopDatafeedRequestBuilder()

    type MlStopDatafeedResponse = {
        [<JsonPropertyName("stopped")>]
        Stopped: bool
    }

    type MlUpdateDatafeedRequest = {
        DatafeedId: Id
        AllowNoIndices: bool option
        ExpandWildcards: ExpandWildcards option
        IgnoreThrottled: bool option
        IgnoreUnavailable: bool option
        [<JsonPropertyName("aggregations")>]
        Aggregations: Map<string, AggregationsAggregationContainer> option
        [<JsonPropertyName("chunking_config")>]
        ChunkingConfig: TypesChunkingConfig option
        [<JsonPropertyName("delayed_data_check_config")>]
        DelayedDataCheckConfig: TypesDelayedDataCheckConfig option
        [<JsonPropertyName("frequency")>]
        Frequency: Duration option
        [<JsonPropertyName("indices")>]
        Indices: string array option
        [<JsonPropertyName("indices_options")>]
        IndicesOptions: IndicesOptions option
        [<JsonPropertyName("job_id")>]
        JobId: Id option
        [<JsonPropertyName("max_empty_searches")>]
        MaxEmptySearches: float option
        [<JsonPropertyName("query")>]
        Query: QueryDslQueryContainer option
        [<JsonPropertyName("query_delay")>]
        QueryDelay: Duration option
        [<JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: MappingRuntimeFields option
        [<JsonPropertyName("script_fields")>]
        ScriptFields: Map<string, ScriptField> option
        [<JsonPropertyName("scroll_size")>]
        ScrollSize: float option
    } with
        static member ToRequest(request: MlUpdateDatafeedRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/datafeeds/{request.DatafeedId}/_update"
                let queryParams =
                    [
                        request.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                        request.IgnoreThrottled |> Option.map (fun v -> "ignore_throttled", Fes.Http.toQueryValue v)
                        request.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``aggregations`` = request.Aggregations; ``chunking_config`` = request.ChunkingConfig; ``delayed_data_check_config`` = request.DelayedDataCheckConfig; ``frequency`` = request.Frequency; ``indices`` = request.Indices; ``indices_options`` = request.IndicesOptions; ``job_id`` = request.JobId; ``max_empty_searches`` = request.MaxEmptySearches; ``query`` = request.Query; ``query_delay`` = request.QueryDelay; ``runtime_mappings`` = request.RuntimeMappings; ``script_fields`` = request.ScriptFields; ``scroll_size`` = request.ScrollSize |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlUpdateDatafeedRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlUpdateDatafeedRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlUpdateDatafeedRequest.ToRequest request

    type MlUpdateDatafeedRequestBuilder() =
        member _.Yield(_: unit) : MlUpdateDatafeedRequest =
            {
                MlUpdateDatafeedRequest.DatafeedId = Unchecked.defaultof<Id>
                MlUpdateDatafeedRequest.AllowNoIndices = Option.None
                MlUpdateDatafeedRequest.ExpandWildcards = Option.None
                MlUpdateDatafeedRequest.IgnoreThrottled = Option.None
                MlUpdateDatafeedRequest.IgnoreUnavailable = Option.None
                MlUpdateDatafeedRequest.Aggregations = Option.None
                MlUpdateDatafeedRequest.ChunkingConfig = Option.None
                MlUpdateDatafeedRequest.DelayedDataCheckConfig = Option.None
                MlUpdateDatafeedRequest.Frequency = Option.None
                MlUpdateDatafeedRequest.Indices = Option.None
                MlUpdateDatafeedRequest.IndicesOptions = Option.None
                MlUpdateDatafeedRequest.JobId = Option.None
                MlUpdateDatafeedRequest.MaxEmptySearches = Option.None
                MlUpdateDatafeedRequest.Query = Option.None
                MlUpdateDatafeedRequest.QueryDelay = Option.None
                MlUpdateDatafeedRequest.RuntimeMappings = Option.None
                MlUpdateDatafeedRequest.ScriptFields = Option.None
                MlUpdateDatafeedRequest.ScrollSize = Option.None
            } : MlUpdateDatafeedRequest

        [<CustomOperation("datafeed_id")>]
        member _.DatafeedId(state: MlUpdateDatafeedRequest, value: Id) =
            { state with MlUpdateDatafeedRequest.DatafeedId = value } : MlUpdateDatafeedRequest

        [<CustomOperation("allow_no_indices")>]
        member _.AllowNoIndices(state: MlUpdateDatafeedRequest, value: bool) =
            { state with MlUpdateDatafeedRequest.AllowNoIndices = Option.Some value } : MlUpdateDatafeedRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: MlUpdateDatafeedRequest, value: ExpandWildcards) =
            { state with MlUpdateDatafeedRequest.ExpandWildcards = Option.Some value } : MlUpdateDatafeedRequest

        [<CustomOperation("ignore_throttled")>]
        member _.IgnoreThrottled(state: MlUpdateDatafeedRequest, value: bool) =
            { state with MlUpdateDatafeedRequest.IgnoreThrottled = Option.Some value } : MlUpdateDatafeedRequest

        [<CustomOperation("ignore_unavailable")>]
        member _.IgnoreUnavailable(state: MlUpdateDatafeedRequest, value: bool) =
            { state with MlUpdateDatafeedRequest.IgnoreUnavailable = Option.Some value } : MlUpdateDatafeedRequest

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: MlUpdateDatafeedRequest, value: Map<string, AggregationsAggregationContainer>) =
            { state with MlUpdateDatafeedRequest.Aggregations = Option.Some value } : MlUpdateDatafeedRequest

        [<CustomOperation("chunking_config")>]
        member _.ChunkingConfig(state: MlUpdateDatafeedRequest, value: TypesChunkingConfig) =
            { state with MlUpdateDatafeedRequest.ChunkingConfig = Option.Some value } : MlUpdateDatafeedRequest

        [<CustomOperation("delayed_data_check_config")>]
        member _.DelayedDataCheckConfig(state: MlUpdateDatafeedRequest, value: TypesDelayedDataCheckConfig) =
            { state with MlUpdateDatafeedRequest.DelayedDataCheckConfig = Option.Some value } : MlUpdateDatafeedRequest

        [<CustomOperation("frequency")>]
        member _.Frequency(state: MlUpdateDatafeedRequest, value: Duration) =
            { state with MlUpdateDatafeedRequest.Frequency = Option.Some value } : MlUpdateDatafeedRequest

        [<CustomOperation("indices")>]
        member _.Indices(state: MlUpdateDatafeedRequest, value: string array) =
            { state with MlUpdateDatafeedRequest.Indices = Option.Some value } : MlUpdateDatafeedRequest

        [<CustomOperation("indices_options")>]
        member _.IndicesOptions(state: MlUpdateDatafeedRequest, value: IndicesOptions) =
            { state with MlUpdateDatafeedRequest.IndicesOptions = Option.Some value } : MlUpdateDatafeedRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlUpdateDatafeedRequest, value: Id) =
            { state with MlUpdateDatafeedRequest.JobId = Option.Some value } : MlUpdateDatafeedRequest

        [<CustomOperation("max_empty_searches")>]
        member _.MaxEmptySearches(state: MlUpdateDatafeedRequest, value: float) =
            { state with MlUpdateDatafeedRequest.MaxEmptySearches = Option.Some value } : MlUpdateDatafeedRequest

        [<CustomOperation("query")>]
        member _.Query(state: MlUpdateDatafeedRequest, value: QueryDslQueryContainer) =
            { state with MlUpdateDatafeedRequest.Query = Option.Some value } : MlUpdateDatafeedRequest

        [<CustomOperation("query_delay")>]
        member _.QueryDelay(state: MlUpdateDatafeedRequest, value: Duration) =
            { state with MlUpdateDatafeedRequest.QueryDelay = Option.Some value } : MlUpdateDatafeedRequest

        [<CustomOperation("runtime_mappings")>]
        member _.RuntimeMappings(state: MlUpdateDatafeedRequest, value: MappingRuntimeFields) =
            { state with MlUpdateDatafeedRequest.RuntimeMappings = Option.Some value } : MlUpdateDatafeedRequest

        [<CustomOperation("script_fields")>]
        member _.ScriptFields(state: MlUpdateDatafeedRequest, value: Map<string, ScriptField>) =
            { state with MlUpdateDatafeedRequest.ScriptFields = Option.Some value } : MlUpdateDatafeedRequest

        [<CustomOperation("scroll_size")>]
        member _.ScrollSize(state: MlUpdateDatafeedRequest, value: float) =
            { state with MlUpdateDatafeedRequest.ScrollSize = Option.Some value } : MlUpdateDatafeedRequest

    let mlUpdateDatafeedRequest = MlUpdateDatafeedRequestBuilder()

    type MlUpdateDatafeedResponse = {
        [<JsonPropertyName("authorization")>]
        Authorization: TypesDatafeedAuthorization option
        [<JsonPropertyName("aggregations")>]
        Aggregations: Map<string, AggregationsAggregationContainer> option
        [<JsonPropertyName("chunking_config")>]
        ChunkingConfig: TypesChunkingConfig
        [<JsonPropertyName("delayed_data_check_config")>]
        DelayedDataCheckConfig: TypesDelayedDataCheckConfig option
        [<JsonPropertyName("datafeed_id")>]
        DatafeedId: Id
        [<JsonPropertyName("frequency")>]
        Frequency: Duration option
        [<JsonPropertyName("indices")>]
        Indices: string array
        [<JsonPropertyName("indices_options")>]
        IndicesOptions: IndicesOptions option
        [<JsonPropertyName("job_id")>]
        JobId: Id
        [<JsonPropertyName("max_empty_searches")>]
        MaxEmptySearches: float option
        [<JsonPropertyName("query")>]
        Query: QueryDslQueryContainer
        [<JsonPropertyName("query_delay")>]
        QueryDelay: Duration
        [<JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: MappingRuntimeFields option
        [<JsonPropertyName("script_fields")>]
        ScriptFields: Map<string, ScriptField> option
        [<JsonPropertyName("scroll_size")>]
        ScrollSize: float
    }

    type MlUpdateFilterRequest = {
        FilterId: Id
        [<JsonPropertyName("add_items")>]
        AddItems: string array option
        [<JsonPropertyName("description")>]
        Description: string option
        [<JsonPropertyName("remove_items")>]
        RemoveItems: string array option
    } with
        static member ToRequest(request: MlUpdateFilterRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/filters/{request.FilterId}/_update"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``add_items`` = request.AddItems; ``description`` = request.Description; ``remove_items`` = request.RemoveItems |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlUpdateFilterRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlUpdateFilterRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlUpdateFilterRequest.ToRequest request

    type MlUpdateFilterRequestBuilder() =
        member _.Yield(_: unit) : MlUpdateFilterRequest =
            {
                MlUpdateFilterRequest.FilterId = Unchecked.defaultof<Id>
                MlUpdateFilterRequest.AddItems = Option.None
                MlUpdateFilterRequest.Description = Option.None
                MlUpdateFilterRequest.RemoveItems = Option.None
            } : MlUpdateFilterRequest

        [<CustomOperation("filter_id")>]
        member _.FilterId(state: MlUpdateFilterRequest, value: Id) =
            { state with MlUpdateFilterRequest.FilterId = value } : MlUpdateFilterRequest

        [<CustomOperation("add_items")>]
        member _.AddItems(state: MlUpdateFilterRequest, value: string array) =
            { state with MlUpdateFilterRequest.AddItems = Option.Some value } : MlUpdateFilterRequest

        [<CustomOperation("description")>]
        member _.Description(state: MlUpdateFilterRequest, value: string) =
            { state with MlUpdateFilterRequest.Description = Option.Some value } : MlUpdateFilterRequest

        [<CustomOperation("remove_items")>]
        member _.RemoveItems(state: MlUpdateFilterRequest, value: string array) =
            { state with MlUpdateFilterRequest.RemoveItems = Option.Some value } : MlUpdateFilterRequest

    let mlUpdateFilterRequest = MlUpdateFilterRequestBuilder()

    type MlUpdateFilterResponse = {
        [<JsonPropertyName("description")>]
        Description: string
        [<JsonPropertyName("filter_id")>]
        FilterId: Id
        [<JsonPropertyName("items")>]
        Items: string array
    }

    type MlUpdateJobRequest = {
        JobId: Id
        [<JsonPropertyName("allow_lazy_open")>]
        AllowLazyOpen: bool option
        [<JsonPropertyName("analysis_limits")>]
        AnalysisLimits: TypesAnalysisMemoryLimit option
        [<JsonPropertyName("background_persist_interval")>]
        BackgroundPersistInterval: Duration option
        [<JsonPropertyName("custom_settings")>]
        CustomSettings: Map<string, obj> option
        [<JsonPropertyName("categorization_filters")>]
        CategorizationFilters: string array option
        [<JsonPropertyName("description")>]
        Description: string option
        [<JsonPropertyName("model_plot_config")>]
        ModelPlotConfig: TypesModelPlotConfig option
        [<JsonPropertyName("model_prune_window")>]
        ModelPruneWindow: Duration option
        [<JsonPropertyName("daily_model_snapshot_retention_after_days")>]
        DailyModelSnapshotRetentionAfterDays: float option
        [<JsonPropertyName("model_snapshot_retention_days")>]
        ModelSnapshotRetentionDays: float option
        [<JsonPropertyName("renormalization_window_days")>]
        RenormalizationWindowDays: float option
        [<JsonPropertyName("results_retention_days")>]
        ResultsRetentionDays: float option
        [<JsonPropertyName("groups")>]
        Groups: string array option
        [<JsonPropertyName("detectors")>]
        Detectors: TypesDetectorUpdate array option
        [<JsonPropertyName("per_partition_categorization")>]
        PerPartitionCategorization: TypesPerPartitionCategorization option
    } with
        static member ToRequest(request: MlUpdateJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{request.JobId}/_update"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``allow_lazy_open`` = request.AllowLazyOpen; ``analysis_limits`` = request.AnalysisLimits; ``background_persist_interval`` = request.BackgroundPersistInterval; ``custom_settings`` = request.CustomSettings; ``categorization_filters`` = request.CategorizationFilters; ``description`` = request.Description; ``model_plot_config`` = request.ModelPlotConfig; ``model_prune_window`` = request.ModelPruneWindow; ``daily_model_snapshot_retention_after_days`` = request.DailyModelSnapshotRetentionAfterDays; ``model_snapshot_retention_days`` = request.ModelSnapshotRetentionDays; ``renormalization_window_days`` = request.RenormalizationWindowDays; ``results_retention_days`` = request.ResultsRetentionDays; ``groups`` = request.Groups; ``detectors`` = request.Detectors; ``per_partition_categorization`` = request.PerPartitionCategorization |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlUpdateJobRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlUpdateJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlUpdateJobRequest.ToRequest request

    type MlUpdateJobRequestBuilder() =
        member _.Yield(_: unit) : MlUpdateJobRequest =
            {
                MlUpdateJobRequest.JobId = Unchecked.defaultof<Id>
                MlUpdateJobRequest.AllowLazyOpen = Option.None
                MlUpdateJobRequest.AnalysisLimits = Option.None
                MlUpdateJobRequest.BackgroundPersistInterval = Option.None
                MlUpdateJobRequest.CustomSettings = Option.None
                MlUpdateJobRequest.CategorizationFilters = Option.None
                MlUpdateJobRequest.Description = Option.None
                MlUpdateJobRequest.ModelPlotConfig = Option.None
                MlUpdateJobRequest.ModelPruneWindow = Option.None
                MlUpdateJobRequest.DailyModelSnapshotRetentionAfterDays = Option.None
                MlUpdateJobRequest.ModelSnapshotRetentionDays = Option.None
                MlUpdateJobRequest.RenormalizationWindowDays = Option.None
                MlUpdateJobRequest.ResultsRetentionDays = Option.None
                MlUpdateJobRequest.Groups = Option.None
                MlUpdateJobRequest.Detectors = Option.None
                MlUpdateJobRequest.PerPartitionCategorization = Option.None
            } : MlUpdateJobRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlUpdateJobRequest, value: Id) =
            { state with MlUpdateJobRequest.JobId = value } : MlUpdateJobRequest

        [<CustomOperation("allow_lazy_open")>]
        member _.AllowLazyOpen(state: MlUpdateJobRequest, value: bool) =
            { state with MlUpdateJobRequest.AllowLazyOpen = Option.Some value } : MlUpdateJobRequest

        [<CustomOperation("analysis_limits")>]
        member _.AnalysisLimits(state: MlUpdateJobRequest, value: TypesAnalysisMemoryLimit) =
            { state with MlUpdateJobRequest.AnalysisLimits = Option.Some value } : MlUpdateJobRequest

        [<CustomOperation("background_persist_interval")>]
        member _.BackgroundPersistInterval(state: MlUpdateJobRequest, value: Duration) =
            { state with MlUpdateJobRequest.BackgroundPersistInterval = Option.Some value } : MlUpdateJobRequest

        [<CustomOperation("custom_settings")>]
        member _.CustomSettings(state: MlUpdateJobRequest, value: Map<string, obj>) =
            { state with MlUpdateJobRequest.CustomSettings = Option.Some value } : MlUpdateJobRequest

        [<CustomOperation("categorization_filters")>]
        member _.CategorizationFilters(state: MlUpdateJobRequest, value: string array) =
            { state with MlUpdateJobRequest.CategorizationFilters = Option.Some value } : MlUpdateJobRequest

        [<CustomOperation("description")>]
        member _.Description(state: MlUpdateJobRequest, value: string) =
            { state with MlUpdateJobRequest.Description = Option.Some value } : MlUpdateJobRequest

        [<CustomOperation("model_plot_config")>]
        member _.ModelPlotConfig(state: MlUpdateJobRequest, value: TypesModelPlotConfig) =
            { state with MlUpdateJobRequest.ModelPlotConfig = Option.Some value } : MlUpdateJobRequest

        [<CustomOperation("model_prune_window")>]
        member _.ModelPruneWindow(state: MlUpdateJobRequest, value: Duration) =
            { state with MlUpdateJobRequest.ModelPruneWindow = Option.Some value } : MlUpdateJobRequest

        [<CustomOperation("daily_model_snapshot_retention_after_days")>]
        member _.DailyModelSnapshotRetentionAfterDays(state: MlUpdateJobRequest, value: float) =
            { state with MlUpdateJobRequest.DailyModelSnapshotRetentionAfterDays = Option.Some value } : MlUpdateJobRequest

        [<CustomOperation("model_snapshot_retention_days")>]
        member _.ModelSnapshotRetentionDays(state: MlUpdateJobRequest, value: float) =
            { state with MlUpdateJobRequest.ModelSnapshotRetentionDays = Option.Some value } : MlUpdateJobRequest

        [<CustomOperation("renormalization_window_days")>]
        member _.RenormalizationWindowDays(state: MlUpdateJobRequest, value: float) =
            { state with MlUpdateJobRequest.RenormalizationWindowDays = Option.Some value } : MlUpdateJobRequest

        [<CustomOperation("results_retention_days")>]
        member _.ResultsRetentionDays(state: MlUpdateJobRequest, value: float) =
            { state with MlUpdateJobRequest.ResultsRetentionDays = Option.Some value } : MlUpdateJobRequest

        [<CustomOperation("groups")>]
        member _.Groups(state: MlUpdateJobRequest, value: string array) =
            { state with MlUpdateJobRequest.Groups = Option.Some value } : MlUpdateJobRequest

        [<CustomOperation("detectors")>]
        member _.Detectors(state: MlUpdateJobRequest, value: TypesDetectorUpdate array) =
            { state with MlUpdateJobRequest.Detectors = Option.Some value } : MlUpdateJobRequest

        [<CustomOperation("per_partition_categorization")>]
        member _.PerPartitionCategorization(state: MlUpdateJobRequest, value: TypesPerPartitionCategorization) =
            { state with MlUpdateJobRequest.PerPartitionCategorization = Option.Some value } : MlUpdateJobRequest

    let mlUpdateJobRequest = MlUpdateJobRequestBuilder()

    type MlUpdateJobResponse = {
        [<JsonPropertyName("allow_lazy_open")>]
        AllowLazyOpen: bool
        [<JsonPropertyName("analysis_config")>]
        AnalysisConfig: TypesAnalysisConfigRead
        [<JsonPropertyName("analysis_limits")>]
        AnalysisLimits: TypesAnalysisLimits
        [<JsonPropertyName("background_persist_interval")>]
        BackgroundPersistInterval: Duration option
        [<JsonPropertyName("create_time")>]
        CreateTime: EpochTimeUnitMillis
        [<JsonPropertyName("finished_time")>]
        FinishedTime: EpochTimeUnitMillis option
        [<JsonPropertyName("custom_settings")>]
        CustomSettings: Map<string, string> option
        [<JsonPropertyName("daily_model_snapshot_retention_after_days")>]
        DailyModelSnapshotRetentionAfterDays: float
        [<JsonPropertyName("data_description")>]
        DataDescription: TypesDataDescription
        [<JsonPropertyName("datafeed_config")>]
        DatafeedConfig: TypesDatafeed option
        [<JsonPropertyName("description")>]
        Description: string option
        [<JsonPropertyName("groups")>]
        Groups: string array option
        [<JsonPropertyName("job_id")>]
        JobId: Id
        [<JsonPropertyName("job_type")>]
        JobType: string
        [<JsonPropertyName("job_version")>]
        JobVersion: VersionString
        [<JsonPropertyName("model_plot_config")>]
        ModelPlotConfig: TypesModelPlotConfig option
        [<JsonPropertyName("model_snapshot_id")>]
        ModelSnapshotId: Id option
        [<JsonPropertyName("model_snapshot_retention_days")>]
        ModelSnapshotRetentionDays: float
        [<JsonPropertyName("renormalization_window_days")>]
        RenormalizationWindowDays: float option
        [<JsonPropertyName("results_index_name")>]
        ResultsIndexName: IndexName
        [<JsonPropertyName("results_retention_days")>]
        ResultsRetentionDays: float option
    }

    type MlUpdateModelSnapshotRequest = {
        JobId: Id
        SnapshotId: Id
        [<JsonPropertyName("description")>]
        Description: string option
        [<JsonPropertyName("retain")>]
        Retain: bool option
    } with
        static member ToRequest(request: MlUpdateModelSnapshotRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{request.JobId}/model_snapshots/{request.SnapshotId}/_update"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``description`` = request.Description; ``retain`` = request.Retain |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlUpdateModelSnapshotRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlUpdateModelSnapshotRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlUpdateModelSnapshotRequest.ToRequest request

    type MlUpdateModelSnapshotRequestBuilder() =
        member _.Yield(_: unit) : MlUpdateModelSnapshotRequest =
            {
                MlUpdateModelSnapshotRequest.JobId = Unchecked.defaultof<Id>
                MlUpdateModelSnapshotRequest.SnapshotId = Unchecked.defaultof<Id>
                MlUpdateModelSnapshotRequest.Description = Option.None
                MlUpdateModelSnapshotRequest.Retain = Option.None
            } : MlUpdateModelSnapshotRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlUpdateModelSnapshotRequest, value: Id) =
            { state with MlUpdateModelSnapshotRequest.JobId = value } : MlUpdateModelSnapshotRequest

        [<CustomOperation("snapshot_id")>]
        member _.SnapshotId(state: MlUpdateModelSnapshotRequest, value: Id) =
            { state with MlUpdateModelSnapshotRequest.SnapshotId = value } : MlUpdateModelSnapshotRequest

        [<CustomOperation("description")>]
        member _.Description(state: MlUpdateModelSnapshotRequest, value: string) =
            { state with MlUpdateModelSnapshotRequest.Description = Option.Some value } : MlUpdateModelSnapshotRequest

        [<CustomOperation("retain")>]
        member _.Retain(state: MlUpdateModelSnapshotRequest, value: bool) =
            { state with MlUpdateModelSnapshotRequest.Retain = Option.Some value } : MlUpdateModelSnapshotRequest

    let mlUpdateModelSnapshotRequest = MlUpdateModelSnapshotRequestBuilder()

    type MlUpdateModelSnapshotResponse = {
        [<JsonPropertyName("acknowledged")>]
        Acknowledged: bool
        [<JsonPropertyName("model")>]
        Model: TypesModelSnapshot
    }

    type MlUpgradeJobSnapshotRequest = {
        JobId: Id
        SnapshotId: Id
        WaitForCompletion: bool option
        Timeout: Duration option
    } with
        static member ToRequest(request: MlUpgradeJobSnapshotRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/anomaly_detectors/{request.JobId}/model_snapshots/{request.SnapshotId}/_upgrade"
                let queryParams =
                    [
                        request.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
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

    module MlUpgradeJobSnapshotRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlUpgradeJobSnapshotRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlUpgradeJobSnapshotRequest.ToRequest request

    type MlUpgradeJobSnapshotRequestBuilder() =
        member _.Yield(_: unit) : MlUpgradeJobSnapshotRequest =
            {
                MlUpgradeJobSnapshotRequest.JobId = Unchecked.defaultof<Id>
                MlUpgradeJobSnapshotRequest.SnapshotId = Unchecked.defaultof<Id>
                MlUpgradeJobSnapshotRequest.WaitForCompletion = Option.None
                MlUpgradeJobSnapshotRequest.Timeout = Option.None
            } : MlUpgradeJobSnapshotRequest

        [<CustomOperation("job_id")>]
        member _.JobId(state: MlUpgradeJobSnapshotRequest, value: Id) =
            { state with MlUpgradeJobSnapshotRequest.JobId = value } : MlUpgradeJobSnapshotRequest

        [<CustomOperation("snapshot_id")>]
        member _.SnapshotId(state: MlUpgradeJobSnapshotRequest, value: Id) =
            { state with MlUpgradeJobSnapshotRequest.SnapshotId = value } : MlUpgradeJobSnapshotRequest

        [<CustomOperation("wait_for_completion")>]
        member _.WaitForCompletion(state: MlUpgradeJobSnapshotRequest, value: bool) =
            { state with MlUpgradeJobSnapshotRequest.WaitForCompletion = Option.Some value } : MlUpgradeJobSnapshotRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlUpgradeJobSnapshotRequest, value: Duration) =
            { state with MlUpgradeJobSnapshotRequest.Timeout = Option.Some value } : MlUpgradeJobSnapshotRequest

    let mlUpgradeJobSnapshotRequest = MlUpgradeJobSnapshotRequestBuilder()

    type MlUpgradeJobSnapshotResponse = {
        [<JsonPropertyName("node")>]
        Node: NodeId
        [<JsonPropertyName("completed")>]
        Completed: bool
    }


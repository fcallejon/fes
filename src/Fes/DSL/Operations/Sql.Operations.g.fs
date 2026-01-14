// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module SqlOperations =

    type SqlClearCursorRequest = {
        [<JsonPropertyName("cursor")>]
        Cursor: string
    } with
        static member ToRequest(request: SqlClearCursorRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_sql/close"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module SqlClearCursorRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SqlClearCursorRequest) : Result<Fes.Http.RequestMsg, exn> =
            SqlClearCursorRequest.ToRequest request

    type SqlClearCursorRequestBuilder() =
        member _.Yield(_: unit) : SqlClearCursorRequest =
            {
                SqlClearCursorRequest.Cursor = String.Empty
            } : SqlClearCursorRequest

        [<CustomOperation("cursor")>]
        member _.Cursor(state: SqlClearCursorRequest, value: string) =
            { state with SqlClearCursorRequest.Cursor = value } : SqlClearCursorRequest

    let sqlClearCursorRequest = SqlClearCursorRequestBuilder()

    type SqlClearCursorResponse = {
        [<JsonPropertyName("succeeded")>]
        Succeeded: bool
    }

    type SqlDeleteAsyncRequest = {
        Id: Id
    } with
        static member ToRequest(request: SqlDeleteAsyncRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_sql/async/delete/{request.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module SqlDeleteAsyncRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SqlDeleteAsyncRequest) : Result<Fes.Http.RequestMsg, exn> =
            SqlDeleteAsyncRequest.ToRequest request

    type SqlDeleteAsyncRequestBuilder() =
        member _.Yield(_: unit) : SqlDeleteAsyncRequest =
            {
                SqlDeleteAsyncRequest.Id = Unchecked.defaultof<Id>
            } : SqlDeleteAsyncRequest

        [<CustomOperation("id")>]
        member _.Id(state: SqlDeleteAsyncRequest, value: Id) =
            { state with SqlDeleteAsyncRequest.Id = value } : SqlDeleteAsyncRequest

    let sqlDeleteAsyncRequest = SqlDeleteAsyncRequestBuilder()

    type SqlDeleteAsyncResponse = AcknowledgedResponseBase

    type SqlGetAsyncRequest = {
        Id: Id
        Delimiter: string option
        Format: string option
        KeepAlive: Duration option
        WaitForCompletionTimeout: Duration option
    } with
        static member ToRequest(request: SqlGetAsyncRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_sql/async/{request.Id}"
                let queryParams =
                    [
                        request.Delimiter |> Option.map (fun v -> "delimiter", string v)
                        request.Format |> Option.map (fun v -> "format", string v)
                        request.KeepAlive |> Option.map (fun v -> "keep_alive", string v)
                        request.WaitForCompletionTimeout |> Option.map (fun v -> "wait_for_completion_timeout", string v)
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

    module SqlGetAsyncRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SqlGetAsyncRequest) : Result<Fes.Http.RequestMsg, exn> =
            SqlGetAsyncRequest.ToRequest request

    type SqlGetAsyncRequestBuilder() =
        member _.Yield(_: unit) : SqlGetAsyncRequest =
            {
                SqlGetAsyncRequest.Id = Unchecked.defaultof<Id>
                SqlGetAsyncRequest.Delimiter = Option.None
                SqlGetAsyncRequest.Format = Option.None
                SqlGetAsyncRequest.KeepAlive = Option.None
                SqlGetAsyncRequest.WaitForCompletionTimeout = Option.None
            } : SqlGetAsyncRequest

        [<CustomOperation("id")>]
        member _.Id(state: SqlGetAsyncRequest, value: Id) =
            { state with SqlGetAsyncRequest.Id = value } : SqlGetAsyncRequest

        [<CustomOperation("delimiter")>]
        member _.Delimiter(state: SqlGetAsyncRequest, value: string) =
            { state with SqlGetAsyncRequest.Delimiter = Option.Some value } : SqlGetAsyncRequest

        [<CustomOperation("format")>]
        member _.Format(state: SqlGetAsyncRequest, value: string) =
            { state with SqlGetAsyncRequest.Format = Option.Some value } : SqlGetAsyncRequest

        [<CustomOperation("keep_alive")>]
        member _.KeepAlive(state: SqlGetAsyncRequest, value: Duration) =
            { state with SqlGetAsyncRequest.KeepAlive = Option.Some value } : SqlGetAsyncRequest

        [<CustomOperation("wait_for_completion_timeout")>]
        member _.WaitForCompletionTimeout(state: SqlGetAsyncRequest, value: Duration) =
            { state with SqlGetAsyncRequest.WaitForCompletionTimeout = Option.Some value } : SqlGetAsyncRequest

    let sqlGetAsyncRequest = SqlGetAsyncRequestBuilder()

    type SqlGetAsyncResponse = {
        [<JsonPropertyName("id")>]
        Id: Id
        [<JsonPropertyName("is_running")>]
        IsRunning: bool
        [<JsonPropertyName("is_partial")>]
        IsPartial: bool
        [<JsonPropertyName("columns")>]
        Columns: TypesColumn array option
        [<JsonPropertyName("cursor")>]
        Cursor: string option
        [<JsonPropertyName("rows")>]
        Rows: TypesRow array
    }

    type SqlGetAsyncStatusRequest = {
        Id: Id
    } with
        static member ToRequest(request: SqlGetAsyncStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_sql/async/status/{request.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module SqlGetAsyncStatusRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SqlGetAsyncStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            SqlGetAsyncStatusRequest.ToRequest request

    type SqlGetAsyncStatusRequestBuilder() =
        member _.Yield(_: unit) : SqlGetAsyncStatusRequest =
            {
                SqlGetAsyncStatusRequest.Id = Unchecked.defaultof<Id>
            } : SqlGetAsyncStatusRequest

        [<CustomOperation("id")>]
        member _.Id(state: SqlGetAsyncStatusRequest, value: Id) =
            { state with SqlGetAsyncStatusRequest.Id = value } : SqlGetAsyncStatusRequest

    let sqlGetAsyncStatusRequest = SqlGetAsyncStatusRequestBuilder()

    type SqlGetAsyncStatusResponse = {
        [<JsonPropertyName("expiration_time_in_millis")>]
        ExpirationTimeInMillis: EpochTimeUnitMillis
        [<JsonPropertyName("id")>]
        Id: string
        [<JsonPropertyName("is_running")>]
        IsRunning: bool
        [<JsonPropertyName("is_partial")>]
        IsPartial: bool
        [<JsonPropertyName("start_time_in_millis")>]
        StartTimeInMillis: EpochTimeUnitMillis
        [<JsonPropertyName("completion_status")>]
        CompletionStatus: Uint option
    }

    type SqlQueryRequest = {
        Format: QuerySqlFormat option
        [<JsonPropertyName("allow_partial_search_results")>]
        AllowPartialSearchResults: bool option
        [<JsonPropertyName("catalog")>]
        Catalog: string option
        [<JsonPropertyName("columnar")>]
        Columnar: bool option
        [<JsonPropertyName("cursor")>]
        Cursor: string option
        [<JsonPropertyName("fetch_size")>]
        FetchSize: float option
        [<JsonPropertyName("field_multi_value_leniency")>]
        FieldMultiValueLeniency: bool option
        [<JsonPropertyName("filter")>]
        Filter: QueryDslQueryContainer option
        [<JsonPropertyName("index_using_frozen")>]
        IndexUsingFrozen: bool option
        [<JsonPropertyName("keep_alive")>]
        KeepAlive: Duration option
        [<JsonPropertyName("keep_on_completion")>]
        KeepOnCompletion: bool option
        [<JsonPropertyName("page_timeout")>]
        PageTimeout: Duration option
        [<JsonPropertyName("params")>]
        Params: obj array option
        [<JsonPropertyName("query")>]
        Query: string option
        [<JsonPropertyName("request_timeout")>]
        RequestTimeout: Duration option
        [<JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: MappingRuntimeFields option
        [<JsonPropertyName("time_zone")>]
        TimeZone: TimeZone option
        [<JsonPropertyName("wait_for_completion_timeout")>]
        WaitForCompletionTimeout: Duration option
    } with
        static member ToRequest(request: SqlQueryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_sql"
                let queryParams =
                    [
                        request.Format |> Option.map (fun v -> "format", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module SqlQueryRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SqlQueryRequest) : Result<Fes.Http.RequestMsg, exn> =
            SqlQueryRequest.ToRequest request

    type SqlQueryRequestBuilder() =
        member _.Yield(_: unit) : SqlQueryRequest =
            {
                SqlQueryRequest.Format = Option.None
                SqlQueryRequest.AllowPartialSearchResults = Option.None
                SqlQueryRequest.Catalog = Option.None
                SqlQueryRequest.Columnar = Option.None
                SqlQueryRequest.Cursor = Option.None
                SqlQueryRequest.FetchSize = Option.None
                SqlQueryRequest.FieldMultiValueLeniency = Option.None
                SqlQueryRequest.Filter = Option.None
                SqlQueryRequest.IndexUsingFrozen = Option.None
                SqlQueryRequest.KeepAlive = Option.None
                SqlQueryRequest.KeepOnCompletion = Option.None
                SqlQueryRequest.PageTimeout = Option.None
                SqlQueryRequest.Params = Option.None
                SqlQueryRequest.Query = Option.None
                SqlQueryRequest.RequestTimeout = Option.None
                SqlQueryRequest.RuntimeMappings = Option.None
                SqlQueryRequest.TimeZone = Option.None
                SqlQueryRequest.WaitForCompletionTimeout = Option.None
            } : SqlQueryRequest

        [<CustomOperation("format")>]
        member _.Format(state: SqlQueryRequest, value: QuerySqlFormat) =
            { state with SqlQueryRequest.Format = Option.Some value } : SqlQueryRequest

        [<CustomOperation("allow_partial_search_results")>]
        member _.AllowPartialSearchResults(state: SqlQueryRequest, value: bool) =
            { state with SqlQueryRequest.AllowPartialSearchResults = Option.Some value } : SqlQueryRequest

        [<CustomOperation("catalog")>]
        member _.Catalog(state: SqlQueryRequest, value: string) =
            { state with SqlQueryRequest.Catalog = Option.Some value } : SqlQueryRequest

        [<CustomOperation("columnar")>]
        member _.Columnar(state: SqlQueryRequest, value: bool) =
            { state with SqlQueryRequest.Columnar = Option.Some value } : SqlQueryRequest

        [<CustomOperation("cursor")>]
        member _.Cursor(state: SqlQueryRequest, value: string) =
            { state with SqlQueryRequest.Cursor = Option.Some value } : SqlQueryRequest

        [<CustomOperation("fetch_size")>]
        member _.FetchSize(state: SqlQueryRequest, value: float) =
            { state with SqlQueryRequest.FetchSize = Option.Some value } : SqlQueryRequest

        [<CustomOperation("field_multi_value_leniency")>]
        member _.FieldMultiValueLeniency(state: SqlQueryRequest, value: bool) =
            { state with SqlQueryRequest.FieldMultiValueLeniency = Option.Some value } : SqlQueryRequest

        [<CustomOperation("filter")>]
        member _.Filter(state: SqlQueryRequest, value: QueryDslQueryContainer) =
            { state with SqlQueryRequest.Filter = Option.Some value } : SqlQueryRequest

        [<CustomOperation("index_using_frozen")>]
        member _.IndexUsingFrozen(state: SqlQueryRequest, value: bool) =
            { state with SqlQueryRequest.IndexUsingFrozen = Option.Some value } : SqlQueryRequest

        [<CustomOperation("keep_alive")>]
        member _.KeepAlive(state: SqlQueryRequest, value: Duration) =
            { state with SqlQueryRequest.KeepAlive = Option.Some value } : SqlQueryRequest

        [<CustomOperation("keep_on_completion")>]
        member _.KeepOnCompletion(state: SqlQueryRequest, value: bool) =
            { state with SqlQueryRequest.KeepOnCompletion = Option.Some value } : SqlQueryRequest

        [<CustomOperation("page_timeout")>]
        member _.PageTimeout(state: SqlQueryRequest, value: Duration) =
            { state with SqlQueryRequest.PageTimeout = Option.Some value } : SqlQueryRequest

        [<CustomOperation("params")>]
        member _.Params(state: SqlQueryRequest, value: obj array) =
            { state with SqlQueryRequest.Params = Option.Some value } : SqlQueryRequest

        [<CustomOperation("query")>]
        member _.Query(state: SqlQueryRequest, value: string) =
            { state with SqlQueryRequest.Query = Option.Some value } : SqlQueryRequest

        [<CustomOperation("request_timeout")>]
        member _.RequestTimeout(state: SqlQueryRequest, value: Duration) =
            { state with SqlQueryRequest.RequestTimeout = Option.Some value } : SqlQueryRequest

        [<CustomOperation("runtime_mappings")>]
        member _.RuntimeMappings(state: SqlQueryRequest, value: MappingRuntimeFields) =
            { state with SqlQueryRequest.RuntimeMappings = Option.Some value } : SqlQueryRequest

        [<CustomOperation("time_zone")>]
        member _.TimeZone(state: SqlQueryRequest, value: TimeZone) =
            { state with SqlQueryRequest.TimeZone = Option.Some value } : SqlQueryRequest

        [<CustomOperation("wait_for_completion_timeout")>]
        member _.WaitForCompletionTimeout(state: SqlQueryRequest, value: Duration) =
            { state with SqlQueryRequest.WaitForCompletionTimeout = Option.Some value } : SqlQueryRequest

    let sqlQueryRequest = SqlQueryRequestBuilder()

    type SqlTranslateRequest = {
        [<JsonPropertyName("fetch_size")>]
        FetchSize: float option
        [<JsonPropertyName("filter")>]
        Filter: QueryDslQueryContainer option
        [<JsonPropertyName("query")>]
        Query: string
        [<JsonPropertyName("time_zone")>]
        TimeZone: TimeZone option
    } with
        static member ToRequest(request: SqlTranslateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_sql/translate"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module SqlTranslateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SqlTranslateRequest) : Result<Fes.Http.RequestMsg, exn> =
            SqlTranslateRequest.ToRequest request

    type SqlTranslateRequestBuilder() =
        member _.Yield(_: unit) : SqlTranslateRequest =
            {
                SqlTranslateRequest.FetchSize = Option.None
                SqlTranslateRequest.Filter = Option.None
                SqlTranslateRequest.Query = String.Empty
                SqlTranslateRequest.TimeZone = Option.None
            } : SqlTranslateRequest

        [<CustomOperation("fetch_size")>]
        member _.FetchSize(state: SqlTranslateRequest, value: float) =
            { state with SqlTranslateRequest.FetchSize = Option.Some value } : SqlTranslateRequest

        [<CustomOperation("filter")>]
        member _.Filter(state: SqlTranslateRequest, value: QueryDslQueryContainer) =
            { state with SqlTranslateRequest.Filter = Option.Some value } : SqlTranslateRequest

        [<CustomOperation("query")>]
        member _.Query(state: SqlTranslateRequest, value: string) =
            { state with SqlTranslateRequest.Query = value } : SqlTranslateRequest

        [<CustomOperation("time_zone")>]
        member _.TimeZone(state: SqlTranslateRequest, value: TimeZone) =
            { state with SqlTranslateRequest.TimeZone = Option.Some value } : SqlTranslateRequest

    let sqlTranslateRequest = SqlTranslateRequestBuilder()


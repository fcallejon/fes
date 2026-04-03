// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module SqlOperations =

    type SqlClearCursorRequest = {
        Cursor: string
    }

        with
        static member ToRequest(req: SqlClearCursorRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_sql/close"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SqlClearCursorResponse = System.Text.Json.JsonElement

    type SqlClearCursorRequestBuilder() =
        member _.Yield(_: unit) : SqlClearCursorRequest =
            {
                Cursor = Unchecked.defaultof<_>
            }

        [<CustomOperation("cursor")>]
        member _.Cursor(state: SqlClearCursorRequest, value: string) =
            { state with Cursor = value }

    let sqlClearCursorRequest = SqlClearCursorRequestBuilder()

    module ClearCursor =
        let withCursor (value: string) (req: SqlClearCursorRequest) =
            { req with Cursor = value }

    type SqlDeleteAsyncRequest = {
        Id: Types.Id
    }

        with
        static member ToRequest(req: SqlDeleteAsyncRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_sql/async/delete/{req.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type SqlDeleteAsyncResponse = Types.AcknowledgedResponseBase

    type SqlDeleteAsyncRequestBuilder() =
        member _.Yield(_: unit) : SqlDeleteAsyncRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: SqlDeleteAsyncRequest, value: Types.Id) =
            { state with Id = value }

    let sqlDeleteAsyncRequest = SqlDeleteAsyncRequestBuilder()

    type SqlGetAsyncRequest = {
        Id: Types.Id
        Delimiter: string option
        Format: string option
        KeepAlive: Types.Duration option
        WaitForCompletionTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: SqlGetAsyncRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_sql/async/{req.Id}"
                let queryParams =
                    [
                        req.Delimiter |> Option.map (fun v -> "delimiter", Fes.Http.toQueryValue v)
                        req.Format |> Option.map (fun v -> "format", Fes.Http.toQueryValue v)
                        req.KeepAlive |> Option.map (fun v -> "keep_alive", Fes.Http.toQueryValue v)
                        req.WaitForCompletionTimeout |> Option.map (fun v -> "wait_for_completion_timeout", Fes.Http.toQueryValue v)
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

    type SqlGetAsyncResponse = System.Text.Json.JsonElement

    type SqlGetAsyncRequestBuilder() =
        member _.Yield(_: unit) : SqlGetAsyncRequest =
            {
                Id = Unchecked.defaultof<_>
                Delimiter = None
                Format = None
                KeepAlive = None
                WaitForCompletionTimeout = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: SqlGetAsyncRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("delimiter")>]
        member _.Delimiter(state: SqlGetAsyncRequest, value: string) =
            { state with Delimiter = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: SqlGetAsyncRequest, value: string) =
            { state with Format = Some value }

        [<CustomOperation("keepAlive")>]
        member _.KeepAlive(state: SqlGetAsyncRequest, value: Types.Duration) =
            { state with KeepAlive = Some value }

        [<CustomOperation("waitForCompletionTimeout")>]
        member _.WaitForCompletionTimeout(state: SqlGetAsyncRequest, value: Types.Duration) =
            { state with WaitForCompletionTimeout = Some value }

    let sqlGetAsyncRequest = SqlGetAsyncRequestBuilder()

    module GetAsync =
        let withDelimiter (value: string) (req: SqlGetAsyncRequest) =
            { req with Delimiter = Some value }
        let withFormat (value: string) (req: SqlGetAsyncRequest) =
            { req with Format = Some value }
        let withKeepAlive (value: Types.Duration) (req: SqlGetAsyncRequest) =
            { req with KeepAlive = Some value }
        let withWaitForCompletionTimeout (value: Types.Duration) (req: SqlGetAsyncRequest) =
            { req with WaitForCompletionTimeout = Some value }

    type SqlGetAsyncStatusRequest = {
        Id: Types.Id
    }

        with
        static member ToRequest(req: SqlGetAsyncStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_sql/async/status/{req.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type SqlGetAsyncStatusResponse = System.Text.Json.JsonElement

    type SqlGetAsyncStatusRequestBuilder() =
        member _.Yield(_: unit) : SqlGetAsyncStatusRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: SqlGetAsyncStatusRequest, value: Types.Id) =
            { state with Id = value }

    let sqlGetAsyncStatusRequest = SqlGetAsyncStatusRequestBuilder()

    type SqlQueryRequest = {
        Format: SqlQuery.SqlFormat option
        AllowPartialSearchResults: bool option
        Catalog: string option
        Columnar: bool option
        Cursor: string option
        FetchSize: Types.Integer option
        FieldMultiValueLeniency: bool option
        Filter: TypesQueryDsl.QueryContainer option
        IndexUsingFrozen: bool option
        KeepAlive: Types.Duration option
        KeepOnCompletion: bool option
        PageTimeout: Types.Duration option
        Params: System.Text.Json.JsonElement list option
        Query: string option
        ProjectRouting: Types.ProjectRouting option
        RequestTimeout: Types.Duration option
        RuntimeMappings: TypesMapping.RuntimeFields option
        TimeZone: Types.TimeZone option
        WaitForCompletionTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: SqlQueryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_sql"
                let queryParams =
                    [
                        req.Format |> Option.map (fun v -> "format", Fes.Http.toQueryValue v)
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

    type SqlQueryResponse = System.Text.Json.JsonElement

    type SqlQueryRequestBuilder() =
        member _.Yield(_: unit) : SqlQueryRequest =
            {
                Format = None
                AllowPartialSearchResults = None
                Catalog = None
                Columnar = None
                Cursor = None
                FetchSize = None
                FieldMultiValueLeniency = None
                Filter = None
                IndexUsingFrozen = None
                KeepAlive = None
                KeepOnCompletion = None
                PageTimeout = None
                Params = None
                Query = None
                ProjectRouting = None
                RequestTimeout = None
                RuntimeMappings = None
                TimeZone = None
                WaitForCompletionTimeout = None
            }

        [<CustomOperation("format")>]
        member _.Format(state: SqlQueryRequest, value: SqlQuery.SqlFormat) =
            { state with Format = Some value }

        [<CustomOperation("allowPartialSearchResults")>]
        member _.AllowPartialSearchResults(state: SqlQueryRequest, value: bool) =
            { state with AllowPartialSearchResults = Some value }

        [<CustomOperation("catalog")>]
        member _.Catalog(state: SqlQueryRequest, value: string) =
            { state with Catalog = Some value }

        [<CustomOperation("columnar")>]
        member _.Columnar(state: SqlQueryRequest, value: bool) =
            { state with Columnar = Some value }

        [<CustomOperation("cursor")>]
        member _.Cursor(state: SqlQueryRequest, value: string) =
            { state with Cursor = Some value }

        [<CustomOperation("fetchSize")>]
        member _.FetchSize(state: SqlQueryRequest, value: Types.Integer) =
            { state with FetchSize = Some value }

        [<CustomOperation("fieldMultiValueLeniency")>]
        member _.FieldMultiValueLeniency(state: SqlQueryRequest, value: bool) =
            { state with FieldMultiValueLeniency = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: SqlQueryRequest, value: TypesQueryDsl.QueryContainer) =
            { state with Filter = Some value }

        [<CustomOperation("indexUsingFrozen")>]
        member _.IndexUsingFrozen(state: SqlQueryRequest, value: bool) =
            { state with IndexUsingFrozen = Some value }

        [<CustomOperation("keepAlive")>]
        member _.KeepAlive(state: SqlQueryRequest, value: Types.Duration) =
            { state with KeepAlive = Some value }

        [<CustomOperation("keepOnCompletion")>]
        member _.KeepOnCompletion(state: SqlQueryRequest, value: bool) =
            { state with KeepOnCompletion = Some value }

        [<CustomOperation("pageTimeout")>]
        member _.PageTimeout(state: SqlQueryRequest, value: Types.Duration) =
            { state with PageTimeout = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: SqlQueryRequest, value: System.Text.Json.JsonElement list) =
            { state with Params = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: SqlQueryRequest, value: string) =
            { state with Query = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: SqlQueryRequest, value: Types.ProjectRouting) =
            { state with ProjectRouting = Some value }

        [<CustomOperation("requestTimeout")>]
        member _.RequestTimeout(state: SqlQueryRequest, value: Types.Duration) =
            { state with RequestTimeout = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: SqlQueryRequest, value: TypesMapping.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: SqlQueryRequest, value: Types.TimeZone) =
            { state with TimeZone = Some value }

        [<CustomOperation("waitForCompletionTimeout")>]
        member _.WaitForCompletionTimeout(state: SqlQueryRequest, value: Types.Duration) =
            { state with WaitForCompletionTimeout = Some value }

    let sqlQueryRequest = SqlQueryRequestBuilder()

    module Query =
        let withFormat (value: SqlQuery.SqlFormat) (req: SqlQueryRequest) =
            { req with Format = Some value }
        let withAllowPartialSearchResults (value: bool) (req: SqlQueryRequest) =
            { req with AllowPartialSearchResults = Some value }
        let withCatalog (value: string) (req: SqlQueryRequest) =
            { req with Catalog = Some value }
        let withColumnar (value: bool) (req: SqlQueryRequest) =
            { req with Columnar = Some value }
        let withCursor (value: string) (req: SqlQueryRequest) =
            { req with Cursor = Some value }
        let withFetchSize (value: Types.Integer) (req: SqlQueryRequest) =
            { req with FetchSize = Some value }
        let withFieldMultiValueLeniency (value: bool) (req: SqlQueryRequest) =
            { req with FieldMultiValueLeniency = Some value }
        let withFilter (value: TypesQueryDsl.QueryContainer) (req: SqlQueryRequest) =
            { req with Filter = Some value }
        let withIndexUsingFrozen (value: bool) (req: SqlQueryRequest) =
            { req with IndexUsingFrozen = Some value }
        let withKeepAlive (value: Types.Duration) (req: SqlQueryRequest) =
            { req with KeepAlive = Some value }
        let withKeepOnCompletion (value: bool) (req: SqlQueryRequest) =
            { req with KeepOnCompletion = Some value }
        let withPageTimeout (value: Types.Duration) (req: SqlQueryRequest) =
            { req with PageTimeout = Some value }
        let withParams (value: System.Text.Json.JsonElement list) (req: SqlQueryRequest) =
            { req with Params = Some value }
        let withQuery (value: string) (req: SqlQueryRequest) =
            { req with Query = Some value }
        let withProjectRouting (value: Types.ProjectRouting) (req: SqlQueryRequest) =
            { req with ProjectRouting = Some value }
        let withRequestTimeout (value: Types.Duration) (req: SqlQueryRequest) =
            { req with RequestTimeout = Some value }
        let withRuntimeMappings (value: TypesMapping.RuntimeFields) (req: SqlQueryRequest) =
            { req with RuntimeMappings = Some value }
        let withTimeZone (value: Types.TimeZone) (req: SqlQueryRequest) =
            { req with TimeZone = Some value }
        let withWaitForCompletionTimeout (value: Types.Duration) (req: SqlQueryRequest) =
            { req with WaitForCompletionTimeout = Some value }

    type SqlTranslateRequest = {
        FetchSize: Types.Integer option
        Filter: TypesQueryDsl.QueryContainer option
        Query: string
        TimeZone: Types.TimeZone option
    }

        with
        static member ToRequest(req: SqlTranslateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_sql/translate"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SqlTranslateResponse = System.Text.Json.JsonElement

    type SqlTranslateRequestBuilder() =
        member _.Yield(_: unit) : SqlTranslateRequest =
            {
                FetchSize = None
                Filter = None
                Query = Unchecked.defaultof<_>
                TimeZone = None
            }

        [<CustomOperation("fetchSize")>]
        member _.FetchSize(state: SqlTranslateRequest, value: Types.Integer) =
            { state with FetchSize = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: SqlTranslateRequest, value: TypesQueryDsl.QueryContainer) =
            { state with Filter = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: SqlTranslateRequest, value: string) =
            { state with Query = value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: SqlTranslateRequest, value: Types.TimeZone) =
            { state with TimeZone = Some value }

    let sqlTranslateRequest = SqlTranslateRequestBuilder()

    module Translate =
        let withFetchSize (value: Types.Integer) (req: SqlTranslateRequest) =
            { req with FetchSize = Some value }
        let withFilter (value: TypesQueryDsl.QueryContainer) (req: SqlTranslateRequest) =
            { req with Filter = Some value }
        let withQuery (value: string) (req: SqlTranslateRequest) =
            { req with Query = value }
        let withTimeZone (value: Types.TimeZone) (req: SqlTranslateRequest) =
            { req with TimeZone = Some value }


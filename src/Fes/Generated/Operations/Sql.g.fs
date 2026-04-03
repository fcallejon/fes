// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module SqlOperations =

    type SqlClearCursorRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("cursor")>]
        Cursor: string
    }

        with
        static member ToEndpoint(req: SqlClearCursorRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_sql/close"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        static member ToEndpoint(req: SqlDeleteAsyncRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_sql/async/delete/{Fes.Http.toPathSegment req.Id}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

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
        static member ToEndpoint(req: SqlGetAsyncRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_sql/async/{Fes.Http.toPathSegment req.Id}"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

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
        static member ToEndpoint(req: SqlGetAsyncStatusRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_sql/async/status/{Fes.Http.toPathSegment req.Id}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

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
        Format: Types.SqlFormat option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_partial_search_results")>]
        AllowPartialSearchResults: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("catalog")>]
        Catalog: string option
        [<System.Text.Json.Serialization.JsonPropertyName("columnar")>]
        Columnar: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("cursor")>]
        Cursor: string option
        [<System.Text.Json.Serialization.JsonPropertyName("fetch_size")>]
        FetchSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("field_multi_value_leniency")>]
        FieldMultiValueLeniency: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: Types.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("index_using_frozen")>]
        IndexUsingFrozen: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("keep_alive")>]
        KeepAlive: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("keep_on_completion")>]
        KeepOnCompletion: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("page_timeout")>]
        PageTimeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: System.Text.Json.JsonElement list option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string option
        [<System.Text.Json.Serialization.JsonPropertyName("project_routing")>]
        ProjectRouting: Types.ProjectRouting option
        [<System.Text.Json.Serialization.JsonPropertyName("request_timeout")>]
        RequestTimeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: Types.RuntimeFields option
        [<System.Text.Json.Serialization.JsonPropertyName("time_zone")>]
        TimeZone: Types.TimeZone option
        [<System.Text.Json.Serialization.JsonPropertyName("wait_for_completion_timeout")>]
        WaitForCompletionTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: SqlQueryRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_sql"
            let queryParams =
                [
                    req.Format |> Option.map (fun v -> "format", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.Format(state: SqlQueryRequest, value: Types.SqlFormat) =
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
        member _.Filter(state: SqlQueryRequest, value: Types.QueryContainer) =
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
        member _.RuntimeMappings(state: SqlQueryRequest, value: Types.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: SqlQueryRequest, value: Types.TimeZone) =
            { state with TimeZone = Some value }

        [<CustomOperation("waitForCompletionTimeout")>]
        member _.WaitForCompletionTimeout(state: SqlQueryRequest, value: Types.Duration) =
            { state with WaitForCompletionTimeout = Some value }

    let sqlQueryRequest = SqlQueryRequestBuilder()

    module Query =
        let withFormat (value: Types.SqlFormat) (req: SqlQueryRequest) =
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
        let withFilter (value: Types.QueryContainer) (req: SqlQueryRequest) =
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
        let withRuntimeMappings (value: Types.RuntimeFields) (req: SqlQueryRequest) =
            { req with RuntimeMappings = Some value }
        let withTimeZone (value: Types.TimeZone) (req: SqlQueryRequest) =
            { req with TimeZone = Some value }
        let withWaitForCompletionTimeout (value: Types.Duration) (req: SqlQueryRequest) =
            { req with WaitForCompletionTimeout = Some value }

    type SqlTranslateRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("fetch_size")>]
        FetchSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: Types.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
        [<System.Text.Json.Serialization.JsonPropertyName("time_zone")>]
        TimeZone: Types.TimeZone option
    }

        with
        static member ToEndpoint(req: SqlTranslateRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_sql/translate"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.Filter(state: SqlTranslateRequest, value: Types.QueryContainer) =
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
        let withFilter (value: Types.QueryContainer) (req: SqlTranslateRequest) =
            { req with Filter = Some value }
        let withQuery (value: string) (req: SqlTranslateRequest) =
            { req with Query = value }
        let withTimeZone (value: Types.TimeZone) (req: SqlTranslateRequest) =
            { req with TimeZone = Some value }


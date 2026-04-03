// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module EsqlOperations =

    type EsqlAsyncQueryRequest = {
        AllowPartialResults: bool option
        Delimiter: string option
        DropNullColumns: bool option
        Format: EsqlTypes.EsqlFormat option
        Columnar: bool option
        Filter: TypesQueryDsl.QueryContainer option
        TimeZone: string option
        Locale: string option
        Params: EsqlTypes.ESQLParams option
        Profile: bool option
        Query: string
        Tables: Map<string, Map<string, EsqlTypes.TableValuesContainer>> option
        IncludeCcsMetadata: bool option
        IncludeExecutionMetadata: bool option
        WaitForCompletionTimeout: Types.Duration option
        KeepAlive: Types.Duration option
        KeepOnCompletion: bool option
        ProjectRouting: Types.ProjectRouting option
    }

        with
        static member ToRequest(req: EsqlAsyncQueryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_query/async"
                let queryParams =
                    [
                        req.AllowPartialResults |> Option.map (fun v -> "allow_partial_results", Fes.Http.toQueryValue v)
                        req.Delimiter |> Option.map (fun v -> "delimiter", Fes.Http.toQueryValue v)
                        req.DropNullColumns |> Option.map (fun v -> "drop_null_columns", Fes.Http.toQueryValue v)
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

    type EsqlAsyncQueryResponse = EsqlTypes.AsyncEsqlResult

    type EsqlAsyncQueryRequestBuilder() =
        member _.Yield(_: unit) : EsqlAsyncQueryRequest =
            {
                AllowPartialResults = None
                Delimiter = None
                DropNullColumns = None
                Format = None
                Columnar = None
                Filter = None
                TimeZone = None
                Locale = None
                Params = None
                Profile = None
                Query = Unchecked.defaultof<_>
                Tables = None
                IncludeCcsMetadata = None
                IncludeExecutionMetadata = None
                WaitForCompletionTimeout = None
                KeepAlive = None
                KeepOnCompletion = None
                ProjectRouting = None
            }

        [<CustomOperation("allowPartialResults")>]
        member _.AllowPartialResults(state: EsqlAsyncQueryRequest, value: bool) =
            { state with AllowPartialResults = Some value }

        [<CustomOperation("delimiter")>]
        member _.Delimiter(state: EsqlAsyncQueryRequest, value: string) =
            { state with Delimiter = Some value }

        [<CustomOperation("dropNullColumns")>]
        member _.DropNullColumns(state: EsqlAsyncQueryRequest, value: bool) =
            { state with DropNullColumns = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: EsqlAsyncQueryRequest, value: EsqlTypes.EsqlFormat) =
            { state with Format = Some value }

        [<CustomOperation("columnar")>]
        member _.Columnar(state: EsqlAsyncQueryRequest, value: bool) =
            { state with Columnar = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: EsqlAsyncQueryRequest, value: TypesQueryDsl.QueryContainer) =
            { state with Filter = Some value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: EsqlAsyncQueryRequest, value: string) =
            { state with TimeZone = Some value }

        [<CustomOperation("locale")>]
        member _.Locale(state: EsqlAsyncQueryRequest, value: string) =
            { state with Locale = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: EsqlAsyncQueryRequest, value: EsqlTypes.ESQLParams) =
            { state with Params = Some value }

        [<CustomOperation("profile")>]
        member _.Profile(state: EsqlAsyncQueryRequest, value: bool) =
            { state with Profile = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: EsqlAsyncQueryRequest, value: string) =
            { state with Query = value }

        [<CustomOperation("tables")>]
        member _.Tables(state: EsqlAsyncQueryRequest, value: Map<string, Map<string, EsqlTypes.TableValuesContainer>>) =
            { state with Tables = Some value }

        [<CustomOperation("includeCcsMetadata")>]
        member _.IncludeCcsMetadata(state: EsqlAsyncQueryRequest, value: bool) =
            { state with IncludeCcsMetadata = Some value }

        [<CustomOperation("includeExecutionMetadata")>]
        member _.IncludeExecutionMetadata(state: EsqlAsyncQueryRequest, value: bool) =
            { state with IncludeExecutionMetadata = Some value }

        [<CustomOperation("waitForCompletionTimeout")>]
        member _.WaitForCompletionTimeout(state: EsqlAsyncQueryRequest, value: Types.Duration) =
            { state with WaitForCompletionTimeout = Some value }

        [<CustomOperation("keepAlive")>]
        member _.KeepAlive(state: EsqlAsyncQueryRequest, value: Types.Duration) =
            { state with KeepAlive = Some value }

        [<CustomOperation("keepOnCompletion")>]
        member _.KeepOnCompletion(state: EsqlAsyncQueryRequest, value: bool) =
            { state with KeepOnCompletion = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: EsqlAsyncQueryRequest, value: Types.ProjectRouting) =
            { state with ProjectRouting = Some value }

    let esqlAsyncQueryRequest = EsqlAsyncQueryRequestBuilder()

    module AsyncQuery =
        let withAllowPartialResults (value: bool) (req: EsqlAsyncQueryRequest) =
            { req with AllowPartialResults = Some value }
        let withDelimiter (value: string) (req: EsqlAsyncQueryRequest) =
            { req with Delimiter = Some value }
        let withDropNullColumns (value: bool) (req: EsqlAsyncQueryRequest) =
            { req with DropNullColumns = Some value }
        let withFormat (value: EsqlTypes.EsqlFormat) (req: EsqlAsyncQueryRequest) =
            { req with Format = Some value }
        let withColumnar (value: bool) (req: EsqlAsyncQueryRequest) =
            { req with Columnar = Some value }
        let withFilter (value: TypesQueryDsl.QueryContainer) (req: EsqlAsyncQueryRequest) =
            { req with Filter = Some value }
        let withTimeZone (value: string) (req: EsqlAsyncQueryRequest) =
            { req with TimeZone = Some value }
        let withLocale (value: string) (req: EsqlAsyncQueryRequest) =
            { req with Locale = Some value }
        let withParams (value: EsqlTypes.ESQLParams) (req: EsqlAsyncQueryRequest) =
            { req with Params = Some value }
        let withProfile (value: bool) (req: EsqlAsyncQueryRequest) =
            { req with Profile = Some value }
        let withQuery (value: string) (req: EsqlAsyncQueryRequest) =
            { req with Query = value }
        let withTables (value: Map<string, Map<string, EsqlTypes.TableValuesContainer>>) (req: EsqlAsyncQueryRequest) =
            { req with Tables = Some value }
        let withIncludeCcsMetadata (value: bool) (req: EsqlAsyncQueryRequest) =
            { req with IncludeCcsMetadata = Some value }
        let withIncludeExecutionMetadata (value: bool) (req: EsqlAsyncQueryRequest) =
            { req with IncludeExecutionMetadata = Some value }
        let withWaitForCompletionTimeout (value: Types.Duration) (req: EsqlAsyncQueryRequest) =
            { req with WaitForCompletionTimeout = Some value }
        let withKeepAlive (value: Types.Duration) (req: EsqlAsyncQueryRequest) =
            { req with KeepAlive = Some value }
        let withKeepOnCompletion (value: bool) (req: EsqlAsyncQueryRequest) =
            { req with KeepOnCompletion = Some value }
        let withProjectRouting (value: Types.ProjectRouting) (req: EsqlAsyncQueryRequest) =
            { req with ProjectRouting = Some value }

    type EsqlAsyncQueryDeleteRequest = {
        Id: Types.Id
    }

        with
        static member ToRequest(req: EsqlAsyncQueryDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_query/async/{req.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type EsqlAsyncQueryDeleteResponse = Types.AcknowledgedResponseBase

    type EsqlAsyncQueryDeleteRequestBuilder() =
        member _.Yield(_: unit) : EsqlAsyncQueryDeleteRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: EsqlAsyncQueryDeleteRequest, value: Types.Id) =
            { state with Id = value }

    let esqlAsyncQueryDeleteRequest = EsqlAsyncQueryDeleteRequestBuilder()

    type EsqlAsyncQueryGetRequest = {
        Id: Types.Id
        DropNullColumns: bool option
        Format: EsqlTypes.EsqlFormat option
        KeepAlive: Types.Duration option
        WaitForCompletionTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: EsqlAsyncQueryGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_query/async/{req.Id}"
                let queryParams =
                    [
                        req.DropNullColumns |> Option.map (fun v -> "drop_null_columns", Fes.Http.toQueryValue v)
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

    type EsqlAsyncQueryGetResponse = EsqlTypes.AsyncEsqlResult

    type EsqlAsyncQueryGetRequestBuilder() =
        member _.Yield(_: unit) : EsqlAsyncQueryGetRequest =
            {
                Id = Unchecked.defaultof<_>
                DropNullColumns = None
                Format = None
                KeepAlive = None
                WaitForCompletionTimeout = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: EsqlAsyncQueryGetRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("dropNullColumns")>]
        member _.DropNullColumns(state: EsqlAsyncQueryGetRequest, value: bool) =
            { state with DropNullColumns = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: EsqlAsyncQueryGetRequest, value: EsqlTypes.EsqlFormat) =
            { state with Format = Some value }

        [<CustomOperation("keepAlive")>]
        member _.KeepAlive(state: EsqlAsyncQueryGetRequest, value: Types.Duration) =
            { state with KeepAlive = Some value }

        [<CustomOperation("waitForCompletionTimeout")>]
        member _.WaitForCompletionTimeout(state: EsqlAsyncQueryGetRequest, value: Types.Duration) =
            { state with WaitForCompletionTimeout = Some value }

    let esqlAsyncQueryGetRequest = EsqlAsyncQueryGetRequestBuilder()

    module AsyncQueryGet =
        let withDropNullColumns (value: bool) (req: EsqlAsyncQueryGetRequest) =
            { req with DropNullColumns = Some value }
        let withFormat (value: EsqlTypes.EsqlFormat) (req: EsqlAsyncQueryGetRequest) =
            { req with Format = Some value }
        let withKeepAlive (value: Types.Duration) (req: EsqlAsyncQueryGetRequest) =
            { req with KeepAlive = Some value }
        let withWaitForCompletionTimeout (value: Types.Duration) (req: EsqlAsyncQueryGetRequest) =
            { req with WaitForCompletionTimeout = Some value }

    type EsqlAsyncQueryStopRequest = {
        Id: Types.Id
        DropNullColumns: bool option
    }

        with
        static member ToRequest(req: EsqlAsyncQueryStopRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_query/async/{req.Id}/stop"
                let queryParams =
                    [
                        req.DropNullColumns |> Option.map (fun v -> "drop_null_columns", Fes.Http.toQueryValue v)
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

    type EsqlAsyncQueryStopResponse = EsqlTypes.EsqlResult

    type EsqlAsyncQueryStopRequestBuilder() =
        member _.Yield(_: unit) : EsqlAsyncQueryStopRequest =
            {
                Id = Unchecked.defaultof<_>
                DropNullColumns = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: EsqlAsyncQueryStopRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("dropNullColumns")>]
        member _.DropNullColumns(state: EsqlAsyncQueryStopRequest, value: bool) =
            { state with DropNullColumns = Some value }

    let esqlAsyncQueryStopRequest = EsqlAsyncQueryStopRequestBuilder()

    module AsyncQueryStop =
        let withDropNullColumns (value: bool) (req: EsqlAsyncQueryStopRequest) =
            { req with DropNullColumns = Some value }

    type EsqlDeleteViewRequest = {
        Name: Types.Id
    }

        with
        static member ToRequest(req: EsqlDeleteViewRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_query/view/{req.Name}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type EsqlDeleteViewResponse = Types.AcknowledgedResponseBase

    type EsqlDeleteViewRequestBuilder() =
        member _.Yield(_: unit) : EsqlDeleteViewRequest =
            {
                Name = Unchecked.defaultof<_>
            }

        [<CustomOperation("name")>]
        member _.Name(state: EsqlDeleteViewRequest, value: Types.Id) =
            { state with Name = value }

    let esqlDeleteViewRequest = EsqlDeleteViewRequestBuilder()

    type EsqlGetQueryRequest = {
        Id: Types.Id
    }

        with
        static member ToRequest(req: EsqlGetQueryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_query/queries/{req.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type EsqlGetQueryResponse = System.Text.Json.JsonElement

    type EsqlGetQueryRequestBuilder() =
        member _.Yield(_: unit) : EsqlGetQueryRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: EsqlGetQueryRequest, value: Types.Id) =
            { state with Id = value }

    let esqlGetQueryRequest = EsqlGetQueryRequestBuilder()

    type EsqlGetViewRequest = {
        Name: Types.Id
    }

        with
        static member ToRequest(req: EsqlGetViewRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_query/view/{req.Name}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type EsqlGetViewResponse = System.Text.Json.JsonElement

    type EsqlGetViewRequestBuilder() =
        member _.Yield(_: unit) : EsqlGetViewRequest =
            {
                Name = Unchecked.defaultof<_>
            }

        [<CustomOperation("name")>]
        member _.Name(state: EsqlGetViewRequest, value: Types.Id) =
            { state with Name = value }

    let esqlGetViewRequest = EsqlGetViewRequestBuilder()

    type EsqlListQueriesRequest = {
    }

        with
        static member ToRequest(req: EsqlListQueriesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_query/queries"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type EsqlListQueriesResponse = System.Text.Json.JsonElement

    type EsqlListQueriesRequestBuilder() =
        member _.Yield(_: unit) : EsqlListQueriesRequest =
            {
            }

    let esqlListQueriesRequest = EsqlListQueriesRequestBuilder()

    type EsqlPutViewRequest = {
        Name: Types.Id
        Query: string
    }

        with
        static member ToRequest(req: EsqlPutViewRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_query/view/{req.Name}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type EsqlPutViewResponse = Types.AcknowledgedResponseBase

    type EsqlPutViewRequestBuilder() =
        member _.Yield(_: unit) : EsqlPutViewRequest =
            {
                Name = Unchecked.defaultof<_>
                Query = Unchecked.defaultof<_>
            }

        [<CustomOperation("name")>]
        member _.Name(state: EsqlPutViewRequest, value: Types.Id) =
            { state with Name = value }

        [<CustomOperation("query")>]
        member _.Query(state: EsqlPutViewRequest, value: string) =
            { state with Query = value }

    let esqlPutViewRequest = EsqlPutViewRequestBuilder()

    module PutView =
        let withQuery (value: string) (req: EsqlPutViewRequest) =
            { req with Query = value }

    type EsqlQueryRequest = {
        Format: EsqlTypes.EsqlFormat option
        Delimiter: string option
        DropNullColumns: bool option
        AllowPartialResults: bool option
        Columnar: bool option
        Filter: TypesQueryDsl.QueryContainer option
        TimeZone: string option
        Locale: string option
        Params: EsqlTypes.ESQLParams option
        Profile: bool option
        Query: string
        Tables: Map<string, Map<string, EsqlTypes.TableValuesContainer>> option
        IncludeCcsMetadata: bool option
        IncludeExecutionMetadata: bool option
        ProjectRouting: Types.ProjectRouting option
    }

        with
        static member ToRequest(req: EsqlQueryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_query"
                let queryParams =
                    [
                        req.Format |> Option.map (fun v -> "format", Fes.Http.toQueryValue v)
                        req.Delimiter |> Option.map (fun v -> "delimiter", Fes.Http.toQueryValue v)
                        req.DropNullColumns |> Option.map (fun v -> "drop_null_columns", Fes.Http.toQueryValue v)
                        req.AllowPartialResults |> Option.map (fun v -> "allow_partial_results", Fes.Http.toQueryValue v)
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

    type EsqlQueryResponse = EsqlTypes.EsqlResult

    type EsqlQueryRequestBuilder() =
        member _.Yield(_: unit) : EsqlQueryRequest =
            {
                Format = None
                Delimiter = None
                DropNullColumns = None
                AllowPartialResults = None
                Columnar = None
                Filter = None
                TimeZone = None
                Locale = None
                Params = None
                Profile = None
                Query = Unchecked.defaultof<_>
                Tables = None
                IncludeCcsMetadata = None
                IncludeExecutionMetadata = None
                ProjectRouting = None
            }

        [<CustomOperation("format")>]
        member _.Format(state: EsqlQueryRequest, value: EsqlTypes.EsqlFormat) =
            { state with Format = Some value }

        [<CustomOperation("delimiter")>]
        member _.Delimiter(state: EsqlQueryRequest, value: string) =
            { state with Delimiter = Some value }

        [<CustomOperation("dropNullColumns")>]
        member _.DropNullColumns(state: EsqlQueryRequest, value: bool) =
            { state with DropNullColumns = Some value }

        [<CustomOperation("allowPartialResults")>]
        member _.AllowPartialResults(state: EsqlQueryRequest, value: bool) =
            { state with AllowPartialResults = Some value }

        [<CustomOperation("columnar")>]
        member _.Columnar(state: EsqlQueryRequest, value: bool) =
            { state with Columnar = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: EsqlQueryRequest, value: TypesQueryDsl.QueryContainer) =
            { state with Filter = Some value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: EsqlQueryRequest, value: string) =
            { state with TimeZone = Some value }

        [<CustomOperation("locale")>]
        member _.Locale(state: EsqlQueryRequest, value: string) =
            { state with Locale = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: EsqlQueryRequest, value: EsqlTypes.ESQLParams) =
            { state with Params = Some value }

        [<CustomOperation("profile")>]
        member _.Profile(state: EsqlQueryRequest, value: bool) =
            { state with Profile = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: EsqlQueryRequest, value: string) =
            { state with Query = value }

        [<CustomOperation("tables")>]
        member _.Tables(state: EsqlQueryRequest, value: Map<string, Map<string, EsqlTypes.TableValuesContainer>>) =
            { state with Tables = Some value }

        [<CustomOperation("includeCcsMetadata")>]
        member _.IncludeCcsMetadata(state: EsqlQueryRequest, value: bool) =
            { state with IncludeCcsMetadata = Some value }

        [<CustomOperation("includeExecutionMetadata")>]
        member _.IncludeExecutionMetadata(state: EsqlQueryRequest, value: bool) =
            { state with IncludeExecutionMetadata = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: EsqlQueryRequest, value: Types.ProjectRouting) =
            { state with ProjectRouting = Some value }

    let esqlQueryRequest = EsqlQueryRequestBuilder()

    module Query =
        let withFormat (value: EsqlTypes.EsqlFormat) (req: EsqlQueryRequest) =
            { req with Format = Some value }
        let withDelimiter (value: string) (req: EsqlQueryRequest) =
            { req with Delimiter = Some value }
        let withDropNullColumns (value: bool) (req: EsqlQueryRequest) =
            { req with DropNullColumns = Some value }
        let withAllowPartialResults (value: bool) (req: EsqlQueryRequest) =
            { req with AllowPartialResults = Some value }
        let withColumnar (value: bool) (req: EsqlQueryRequest) =
            { req with Columnar = Some value }
        let withFilter (value: TypesQueryDsl.QueryContainer) (req: EsqlQueryRequest) =
            { req with Filter = Some value }
        let withTimeZone (value: string) (req: EsqlQueryRequest) =
            { req with TimeZone = Some value }
        let withLocale (value: string) (req: EsqlQueryRequest) =
            { req with Locale = Some value }
        let withParams (value: EsqlTypes.ESQLParams) (req: EsqlQueryRequest) =
            { req with Params = Some value }
        let withProfile (value: bool) (req: EsqlQueryRequest) =
            { req with Profile = Some value }
        let withQuery (value: string) (req: EsqlQueryRequest) =
            { req with Query = value }
        let withTables (value: Map<string, Map<string, EsqlTypes.TableValuesContainer>>) (req: EsqlQueryRequest) =
            { req with Tables = Some value }
        let withIncludeCcsMetadata (value: bool) (req: EsqlQueryRequest) =
            { req with IncludeCcsMetadata = Some value }
        let withIncludeExecutionMetadata (value: bool) (req: EsqlQueryRequest) =
            { req with IncludeExecutionMetadata = Some value }
        let withProjectRouting (value: Types.ProjectRouting) (req: EsqlQueryRequest) =
            { req with ProjectRouting = Some value }


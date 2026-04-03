// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module EsqlOperations =

    type EsqlAsyncQueryRequest = {
        AllowPartialResults: bool option
        Delimiter: string option
        DropNullColumns: bool option
        Format: Types.EsqlFormat option
        [<System.Text.Json.Serialization.JsonPropertyName("columnar")>]
        Columnar: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: Types.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("time_zone")>]
        TimeZone: string option
        [<System.Text.Json.Serialization.JsonPropertyName("locale")>]
        Locale: string option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Types.ESQLParams option
        [<System.Text.Json.Serialization.JsonPropertyName("profile")>]
        Profile: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
        [<System.Text.Json.Serialization.JsonPropertyName("tables")>]
        Tables: Map<string, Map<string, Types.TableValuesContainer>> option
        [<System.Text.Json.Serialization.JsonPropertyName("include_ccs_metadata")>]
        IncludeCcsMetadata: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("include_execution_metadata")>]
        IncludeExecutionMetadata: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("wait_for_completion_timeout")>]
        WaitForCompletionTimeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("keep_alive")>]
        KeepAlive: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("keep_on_completion")>]
        KeepOnCompletion: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("project_routing")>]
        ProjectRouting: Types.ProjectRouting option
    }

        with
        static member ToEndpoint(req: EsqlAsyncQueryRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type EsqlAsyncQueryResponse = Types.AsyncEsqlResult

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
        member _.Format(state: EsqlAsyncQueryRequest, value: Types.EsqlFormat) =
            { state with Format = Some value }

        [<CustomOperation("columnar")>]
        member _.Columnar(state: EsqlAsyncQueryRequest, value: bool) =
            { state with Columnar = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: EsqlAsyncQueryRequest, value: Types.QueryContainer) =
            { state with Filter = Some value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: EsqlAsyncQueryRequest, value: string) =
            { state with TimeZone = Some value }

        [<CustomOperation("locale")>]
        member _.Locale(state: EsqlAsyncQueryRequest, value: string) =
            { state with Locale = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: EsqlAsyncQueryRequest, value: Types.ESQLParams) =
            { state with Params = Some value }

        [<CustomOperation("profile")>]
        member _.Profile(state: EsqlAsyncQueryRequest, value: bool) =
            { state with Profile = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: EsqlAsyncQueryRequest, value: string) =
            { state with Query = value }

        [<CustomOperation("tables")>]
        member _.Tables(state: EsqlAsyncQueryRequest, value: Map<string, Map<string, Types.TableValuesContainer>>) =
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
        let withFormat (value: Types.EsqlFormat) (req: EsqlAsyncQueryRequest) =
            { req with Format = Some value }
        let withColumnar (value: bool) (req: EsqlAsyncQueryRequest) =
            { req with Columnar = Some value }
        let withFilter (value: Types.QueryContainer) (req: EsqlAsyncQueryRequest) =
            { req with Filter = Some value }
        let withTimeZone (value: string) (req: EsqlAsyncQueryRequest) =
            { req with TimeZone = Some value }
        let withLocale (value: string) (req: EsqlAsyncQueryRequest) =
            { req with Locale = Some value }
        let withParams (value: Types.ESQLParams) (req: EsqlAsyncQueryRequest) =
            { req with Params = Some value }
        let withProfile (value: bool) (req: EsqlAsyncQueryRequest) =
            { req with Profile = Some value }
        let withQuery (value: string) (req: EsqlAsyncQueryRequest) =
            { req with Query = value }
        let withTables (value: Map<string, Map<string, Types.TableValuesContainer>>) (req: EsqlAsyncQueryRequest) =
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
        static member ToEndpoint(req: EsqlAsyncQueryDeleteRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_query/async/{Fes.Http.toPathSegment req.Id}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

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
        Format: Types.EsqlFormat option
        KeepAlive: Types.Duration option
        WaitForCompletionTimeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: EsqlAsyncQueryGetRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_query/async/{Fes.Http.toPathSegment req.Id}"
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type EsqlAsyncQueryGetResponse = Types.AsyncEsqlResult

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
        member _.Format(state: EsqlAsyncQueryGetRequest, value: Types.EsqlFormat) =
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
        let withFormat (value: Types.EsqlFormat) (req: EsqlAsyncQueryGetRequest) =
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
        static member ToEndpoint(req: EsqlAsyncQueryStopRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_query/async/{Fes.Http.toPathSegment req.Id}/stop"
            let queryParams =
                [
                    req.DropNullColumns |> Option.map (fun v -> "drop_null_columns", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            endpoint, ValueNone

    type EsqlAsyncQueryStopResponse = Types.EsqlResult

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
        static member ToEndpoint(req: EsqlDeleteViewRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_query/view/{Fes.Http.toPathSegment req.Name}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

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
        static member ToEndpoint(req: EsqlGetQueryRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_query/queries/{Fes.Http.toPathSegment req.Id}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

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
        static member ToEndpoint(req: EsqlGetViewRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_query/view/{Fes.Http.toPathSegment req.Name}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

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

    type EsqlListQueriesRequest = | EsqlListQueriesRequest

        with
        static member ToEndpoint(req: EsqlListQueriesRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_query/queries"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type EsqlListQueriesResponse = System.Text.Json.JsonElement

    type EsqlPutViewRequest = {
        Name: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
    }

        with
        static member ToEndpoint(req: EsqlPutViewRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_query/view/{Fes.Http.toPathSegment req.Name}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        Format: Types.EsqlFormat option
        Delimiter: string option
        DropNullColumns: bool option
        AllowPartialResults: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("columnar")>]
        Columnar: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: Types.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("time_zone")>]
        TimeZone: string option
        [<System.Text.Json.Serialization.JsonPropertyName("locale")>]
        Locale: string option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Types.ESQLParams option
        [<System.Text.Json.Serialization.JsonPropertyName("profile")>]
        Profile: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
        [<System.Text.Json.Serialization.JsonPropertyName("tables")>]
        Tables: Map<string, Map<string, Types.TableValuesContainer>> option
        [<System.Text.Json.Serialization.JsonPropertyName("include_ccs_metadata")>]
        IncludeCcsMetadata: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("include_execution_metadata")>]
        IncludeExecutionMetadata: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("project_routing")>]
        ProjectRouting: Types.ProjectRouting option
    }

        with
        static member ToEndpoint(req: EsqlQueryRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type EsqlQueryResponse = Types.EsqlResult

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
        member _.Format(state: EsqlQueryRequest, value: Types.EsqlFormat) =
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
        member _.Filter(state: EsqlQueryRequest, value: Types.QueryContainer) =
            { state with Filter = Some value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: EsqlQueryRequest, value: string) =
            { state with TimeZone = Some value }

        [<CustomOperation("locale")>]
        member _.Locale(state: EsqlQueryRequest, value: string) =
            { state with Locale = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: EsqlQueryRequest, value: Types.ESQLParams) =
            { state with Params = Some value }

        [<CustomOperation("profile")>]
        member _.Profile(state: EsqlQueryRequest, value: bool) =
            { state with Profile = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: EsqlQueryRequest, value: string) =
            { state with Query = value }

        [<CustomOperation("tables")>]
        member _.Tables(state: EsqlQueryRequest, value: Map<string, Map<string, Types.TableValuesContainer>>) =
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
        let withFormat (value: Types.EsqlFormat) (req: EsqlQueryRequest) =
            { req with Format = Some value }
        let withDelimiter (value: string) (req: EsqlQueryRequest) =
            { req with Delimiter = Some value }
        let withDropNullColumns (value: bool) (req: EsqlQueryRequest) =
            { req with DropNullColumns = Some value }
        let withAllowPartialResults (value: bool) (req: EsqlQueryRequest) =
            { req with AllowPartialResults = Some value }
        let withColumnar (value: bool) (req: EsqlQueryRequest) =
            { req with Columnar = Some value }
        let withFilter (value: Types.QueryContainer) (req: EsqlQueryRequest) =
            { req with Filter = Some value }
        let withTimeZone (value: string) (req: EsqlQueryRequest) =
            { req with TimeZone = Some value }
        let withLocale (value: string) (req: EsqlQueryRequest) =
            { req with Locale = Some value }
        let withParams (value: Types.ESQLParams) (req: EsqlQueryRequest) =
            { req with Params = Some value }
        let withProfile (value: bool) (req: EsqlQueryRequest) =
            { req with Profile = Some value }
        let withQuery (value: string) (req: EsqlQueryRequest) =
            { req with Query = value }
        let withTables (value: Map<string, Map<string, Types.TableValuesContainer>>) (req: EsqlQueryRequest) =
            { req with Tables = Some value }
        let withIncludeCcsMetadata (value: bool) (req: EsqlQueryRequest) =
            { req with IncludeCcsMetadata = Some value }
        let withIncludeExecutionMetadata (value: bool) (req: EsqlQueryRequest) =
            { req with IncludeExecutionMetadata = Some value }
        let withProjectRouting (value: Types.ProjectRouting) (req: EsqlQueryRequest) =
            { req with ProjectRouting = Some value }


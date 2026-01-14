// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module EsqlOperations =

    type EsqlAsyncQueryRequest = {
        AllowPartialResults: bool option
        Delimiter: string option
        DropNullColumns: bool option
        Format: TypesEsqlFormat option
        [<JsonPropertyName("columnar")>]
        Columnar: bool option
        [<JsonPropertyName("filter")>]
        Filter: QueryDslQueryContainer option
        [<JsonPropertyName("locale")>]
        Locale: string option
        [<JsonPropertyName("params")>]
        Params: FieldValue array option
        [<JsonPropertyName("profile")>]
        Profile: bool option
        [<JsonPropertyName("query")>]
        Query: string
        [<JsonPropertyName("tables")>]
        Tables: Map<string, Map<string, TypesTableValuesContainer>> option
        [<JsonPropertyName("include_ccs_metadata")>]
        IncludeCcsMetadata: bool option
        [<JsonPropertyName("include_execution_metadata")>]
        IncludeExecutionMetadata: bool option
        [<JsonPropertyName("wait_for_completion_timeout")>]
        WaitForCompletionTimeout: Duration option
        [<JsonPropertyName("keep_alive")>]
        KeepAlive: Duration option
        [<JsonPropertyName("keep_on_completion")>]
        KeepOnCompletion: bool option
    } with
        static member ToRequest(request: EsqlAsyncQueryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_query/async"
                let queryParams =
                    [
                        request.AllowPartialResults |> Option.map (fun v -> "allow_partial_results", Fes.Http.toQueryValue v)
                        request.Delimiter |> Option.map (fun v -> "delimiter", Fes.Http.toQueryValue v)
                        request.DropNullColumns |> Option.map (fun v -> "drop_null_columns", Fes.Http.toQueryValue v)
                        request.Format |> Option.map (fun v -> "format", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``columnar`` = request.Columnar; ``filter`` = request.Filter; ``locale`` = request.Locale; ``params`` = request.Params; ``profile`` = request.Profile; ``query`` = request.Query; ``tables`` = request.Tables; ``include_ccs_metadata`` = request.IncludeCcsMetadata; ``include_execution_metadata`` = request.IncludeExecutionMetadata; ``wait_for_completion_timeout`` = request.WaitForCompletionTimeout; ``keep_alive`` = request.KeepAlive; ``keep_on_completion`` = request.KeepOnCompletion |}
                |> Result.Ok
            with ex -> Result.Error ex

    module EsqlAsyncQueryRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: EsqlAsyncQueryRequest) : Result<Fes.Http.RequestMsg, exn> =
            EsqlAsyncQueryRequest.ToRequest request

    type EsqlAsyncQueryRequestBuilder() =
        member _.Yield(_: unit) : EsqlAsyncQueryRequest =
            {
                EsqlAsyncQueryRequest.AllowPartialResults = Option.None
                EsqlAsyncQueryRequest.Delimiter = Option.None
                EsqlAsyncQueryRequest.DropNullColumns = Option.None
                EsqlAsyncQueryRequest.Format = Option.None
                EsqlAsyncQueryRequest.Columnar = Option.None
                EsqlAsyncQueryRequest.Filter = Option.None
                EsqlAsyncQueryRequest.Locale = Option.None
                EsqlAsyncQueryRequest.Params = Option.None
                EsqlAsyncQueryRequest.Profile = Option.None
                EsqlAsyncQueryRequest.Query = String.Empty
                EsqlAsyncQueryRequest.Tables = Option.None
                EsqlAsyncQueryRequest.IncludeCcsMetadata = Option.None
                EsqlAsyncQueryRequest.IncludeExecutionMetadata = Option.None
                EsqlAsyncQueryRequest.WaitForCompletionTimeout = Option.None
                EsqlAsyncQueryRequest.KeepAlive = Option.None
                EsqlAsyncQueryRequest.KeepOnCompletion = Option.None
            } : EsqlAsyncQueryRequest

        [<CustomOperation("allow_partial_results")>]
        member _.AllowPartialResults(state: EsqlAsyncQueryRequest, value: bool) =
            { state with EsqlAsyncQueryRequest.AllowPartialResults = Option.Some value } : EsqlAsyncQueryRequest

        [<CustomOperation("delimiter")>]
        member _.Delimiter(state: EsqlAsyncQueryRequest, value: string) =
            { state with EsqlAsyncQueryRequest.Delimiter = Option.Some value } : EsqlAsyncQueryRequest

        [<CustomOperation("drop_null_columns")>]
        member _.DropNullColumns(state: EsqlAsyncQueryRequest, value: bool) =
            { state with EsqlAsyncQueryRequest.DropNullColumns = Option.Some value } : EsqlAsyncQueryRequest

        [<CustomOperation("format")>]
        member _.Format(state: EsqlAsyncQueryRequest, value: TypesEsqlFormat) =
            { state with EsqlAsyncQueryRequest.Format = Option.Some value } : EsqlAsyncQueryRequest

        [<CustomOperation("columnar")>]
        member _.Columnar(state: EsqlAsyncQueryRequest, value: bool) =
            { state with EsqlAsyncQueryRequest.Columnar = Option.Some value } : EsqlAsyncQueryRequest

        [<CustomOperation("filter")>]
        member _.Filter(state: EsqlAsyncQueryRequest, value: QueryDslQueryContainer) =
            { state with EsqlAsyncQueryRequest.Filter = Option.Some value } : EsqlAsyncQueryRequest

        [<CustomOperation("locale")>]
        member _.Locale(state: EsqlAsyncQueryRequest, value: string) =
            { state with EsqlAsyncQueryRequest.Locale = Option.Some value } : EsqlAsyncQueryRequest

        [<CustomOperation("params")>]
        member _.Params(state: EsqlAsyncQueryRequest, value: FieldValue array) =
            { state with EsqlAsyncQueryRequest.Params = Option.Some value } : EsqlAsyncQueryRequest

        [<CustomOperation("profile")>]
        member _.Profile(state: EsqlAsyncQueryRequest, value: bool) =
            { state with EsqlAsyncQueryRequest.Profile = Option.Some value } : EsqlAsyncQueryRequest

        [<CustomOperation("query")>]
        member _.Query(state: EsqlAsyncQueryRequest, value: string) =
            { state with EsqlAsyncQueryRequest.Query = value } : EsqlAsyncQueryRequest

        [<CustomOperation("tables")>]
        member _.Tables(state: EsqlAsyncQueryRequest, value: Map<string, Map<string, TypesTableValuesContainer>>) =
            { state with EsqlAsyncQueryRequest.Tables = Option.Some value } : EsqlAsyncQueryRequest

        [<CustomOperation("include_ccs_metadata")>]
        member _.IncludeCcsMetadata(state: EsqlAsyncQueryRequest, value: bool) =
            { state with EsqlAsyncQueryRequest.IncludeCcsMetadata = Option.Some value } : EsqlAsyncQueryRequest

        [<CustomOperation("include_execution_metadata")>]
        member _.IncludeExecutionMetadata(state: EsqlAsyncQueryRequest, value: bool) =
            { state with EsqlAsyncQueryRequest.IncludeExecutionMetadata = Option.Some value } : EsqlAsyncQueryRequest

        [<CustomOperation("wait_for_completion_timeout")>]
        member _.WaitForCompletionTimeout(state: EsqlAsyncQueryRequest, value: Duration) =
            { state with EsqlAsyncQueryRequest.WaitForCompletionTimeout = Option.Some value } : EsqlAsyncQueryRequest

        [<CustomOperation("keep_alive")>]
        member _.KeepAlive(state: EsqlAsyncQueryRequest, value: Duration) =
            { state with EsqlAsyncQueryRequest.KeepAlive = Option.Some value } : EsqlAsyncQueryRequest

        [<CustomOperation("keep_on_completion")>]
        member _.KeepOnCompletion(state: EsqlAsyncQueryRequest, value: bool) =
            { state with EsqlAsyncQueryRequest.KeepOnCompletion = Option.Some value } : EsqlAsyncQueryRequest

    let esqlAsyncQueryRequest = EsqlAsyncQueryRequestBuilder()

    type EsqlAsyncQueryResponse = TypesAsyncEsqlResult

    type EsqlAsyncQueryGetRequest = {
        Id: Id
        DropNullColumns: bool option
        Format: TypesEsqlFormat option
        KeepAlive: Duration option
        WaitForCompletionTimeout: Duration option
    } with
        static member ToRequest(request: EsqlAsyncQueryGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_query/async/{request.Id}"
                let queryParams =
                    [
                        request.DropNullColumns |> Option.map (fun v -> "drop_null_columns", Fes.Http.toQueryValue v)
                        request.Format |> Option.map (fun v -> "format", Fes.Http.toQueryValue v)
                        request.KeepAlive |> Option.map (fun v -> "keep_alive", Fes.Http.toQueryValue v)
                        request.WaitForCompletionTimeout |> Option.map (fun v -> "wait_for_completion_timeout", Fes.Http.toQueryValue v)
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

    module EsqlAsyncQueryGetRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: EsqlAsyncQueryGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            EsqlAsyncQueryGetRequest.ToRequest request

    type EsqlAsyncQueryGetRequestBuilder() =
        member _.Yield(_: unit) : EsqlAsyncQueryGetRequest =
            {
                EsqlAsyncQueryGetRequest.Id = Unchecked.defaultof<Id>
                EsqlAsyncQueryGetRequest.DropNullColumns = Option.None
                EsqlAsyncQueryGetRequest.Format = Option.None
                EsqlAsyncQueryGetRequest.KeepAlive = Option.None
                EsqlAsyncQueryGetRequest.WaitForCompletionTimeout = Option.None
            } : EsqlAsyncQueryGetRequest

        [<CustomOperation("id")>]
        member _.Id(state: EsqlAsyncQueryGetRequest, value: Id) =
            { state with EsqlAsyncQueryGetRequest.Id = value } : EsqlAsyncQueryGetRequest

        [<CustomOperation("drop_null_columns")>]
        member _.DropNullColumns(state: EsqlAsyncQueryGetRequest, value: bool) =
            { state with EsqlAsyncQueryGetRequest.DropNullColumns = Option.Some value } : EsqlAsyncQueryGetRequest

        [<CustomOperation("format")>]
        member _.Format(state: EsqlAsyncQueryGetRequest, value: TypesEsqlFormat) =
            { state with EsqlAsyncQueryGetRequest.Format = Option.Some value } : EsqlAsyncQueryGetRequest

        [<CustomOperation("keep_alive")>]
        member _.KeepAlive(state: EsqlAsyncQueryGetRequest, value: Duration) =
            { state with EsqlAsyncQueryGetRequest.KeepAlive = Option.Some value } : EsqlAsyncQueryGetRequest

        [<CustomOperation("wait_for_completion_timeout")>]
        member _.WaitForCompletionTimeout(state: EsqlAsyncQueryGetRequest, value: Duration) =
            { state with EsqlAsyncQueryGetRequest.WaitForCompletionTimeout = Option.Some value } : EsqlAsyncQueryGetRequest

    let esqlAsyncQueryGetRequest = EsqlAsyncQueryGetRequestBuilder()

    type EsqlAsyncQueryGetResponse = TypesAsyncEsqlResult

    type EsqlAsyncQueryDeleteRequest = {
        Id: Id
    } with
        static member ToRequest(request: EsqlAsyncQueryDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_query/async/{request.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module EsqlAsyncQueryDeleteRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: EsqlAsyncQueryDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            EsqlAsyncQueryDeleteRequest.ToRequest request

    type EsqlAsyncQueryDeleteRequestBuilder() =
        member _.Yield(_: unit) : EsqlAsyncQueryDeleteRequest =
            {
                EsqlAsyncQueryDeleteRequest.Id = Unchecked.defaultof<Id>
            } : EsqlAsyncQueryDeleteRequest

        [<CustomOperation("id")>]
        member _.Id(state: EsqlAsyncQueryDeleteRequest, value: Id) =
            { state with EsqlAsyncQueryDeleteRequest.Id = value } : EsqlAsyncQueryDeleteRequest

    let esqlAsyncQueryDeleteRequest = EsqlAsyncQueryDeleteRequestBuilder()

    type EsqlAsyncQueryDeleteResponse = AcknowledgedResponseBase

    type EsqlAsyncQueryStopRequest = {
        Id: Id
        DropNullColumns: bool option
    } with
        static member ToRequest(request: EsqlAsyncQueryStopRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_query/async/{request.Id}/stop"
                let queryParams =
                    [
                        request.DropNullColumns |> Option.map (fun v -> "drop_null_columns", Fes.Http.toQueryValue v)
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

    module EsqlAsyncQueryStopRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: EsqlAsyncQueryStopRequest) : Result<Fes.Http.RequestMsg, exn> =
            EsqlAsyncQueryStopRequest.ToRequest request

    type EsqlAsyncQueryStopRequestBuilder() =
        member _.Yield(_: unit) : EsqlAsyncQueryStopRequest =
            {
                EsqlAsyncQueryStopRequest.Id = Unchecked.defaultof<Id>
                EsqlAsyncQueryStopRequest.DropNullColumns = Option.None
            } : EsqlAsyncQueryStopRequest

        [<CustomOperation("id")>]
        member _.Id(state: EsqlAsyncQueryStopRequest, value: Id) =
            { state with EsqlAsyncQueryStopRequest.Id = value } : EsqlAsyncQueryStopRequest

        [<CustomOperation("drop_null_columns")>]
        member _.DropNullColumns(state: EsqlAsyncQueryStopRequest, value: bool) =
            { state with EsqlAsyncQueryStopRequest.DropNullColumns = Option.Some value } : EsqlAsyncQueryStopRequest

    let esqlAsyncQueryStopRequest = EsqlAsyncQueryStopRequestBuilder()

    type EsqlAsyncQueryStopResponse = TypesEsqlResult

    type EsqlGetQueryRequest = {
        Id: Id
    } with
        static member ToRequest(request: EsqlGetQueryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_query/queries/{request.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module EsqlGetQueryRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: EsqlGetQueryRequest) : Result<Fes.Http.RequestMsg, exn> =
            EsqlGetQueryRequest.ToRequest request

    type EsqlGetQueryRequestBuilder() =
        member _.Yield(_: unit) : EsqlGetQueryRequest =
            {
                EsqlGetQueryRequest.Id = Unchecked.defaultof<Id>
            } : EsqlGetQueryRequest

        [<CustomOperation("id")>]
        member _.Id(state: EsqlGetQueryRequest, value: Id) =
            { state with EsqlGetQueryRequest.Id = value } : EsqlGetQueryRequest

    let esqlGetQueryRequest = EsqlGetQueryRequestBuilder()

    type EsqlGetQueryResponse = {
        [<JsonPropertyName("id")>]
        Id: float
        [<JsonPropertyName("node")>]
        Node: NodeId
        [<JsonPropertyName("start_time_millis")>]
        StartTimeMillis: float
        [<JsonPropertyName("running_time_nanos")>]
        RunningTimeNanos: float
        [<JsonPropertyName("query")>]
        Query: string
        [<JsonPropertyName("coordinating_node")>]
        CoordinatingNode: NodeId
        [<JsonPropertyName("data_nodes")>]
        DataNodes: NodeId array
    }

    type EsqlListQueriesRequest = unit

    let esqlListQueriesRequest = ()

    type EsqlListQueriesResponse = {
        [<JsonPropertyName("queries")>]
        Queries: Map<string, ListQueriesBody>
    }

    type EsqlQueryRequest = {
        Format: TypesEsqlFormat option
        Delimiter: string option
        DropNullColumns: bool option
        AllowPartialResults: bool option
        [<JsonPropertyName("columnar")>]
        Columnar: bool option
        [<JsonPropertyName("filter")>]
        Filter: QueryDslQueryContainer option
        [<JsonPropertyName("locale")>]
        Locale: string option
        [<JsonPropertyName("params")>]
        Params: TypesESQLParam array option
        [<JsonPropertyName("profile")>]
        Profile: bool option
        [<JsonPropertyName("query")>]
        Query: string
        [<JsonPropertyName("tables")>]
        Tables: Map<string, Map<string, TypesTableValuesContainer>> option
        [<JsonPropertyName("include_ccs_metadata")>]
        IncludeCcsMetadata: bool option
        [<JsonPropertyName("include_execution_metadata")>]
        IncludeExecutionMetadata: bool option
    } with
        static member ToRequest(request: EsqlQueryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_query"
                let queryParams =
                    [
                        request.Format |> Option.map (fun v -> "format", Fes.Http.toQueryValue v)
                        request.Delimiter |> Option.map (fun v -> "delimiter", Fes.Http.toQueryValue v)
                        request.DropNullColumns |> Option.map (fun v -> "drop_null_columns", Fes.Http.toQueryValue v)
                        request.AllowPartialResults |> Option.map (fun v -> "allow_partial_results", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``columnar`` = request.Columnar; ``filter`` = request.Filter; ``locale`` = request.Locale; ``params`` = request.Params; ``profile`` = request.Profile; ``query`` = request.Query; ``tables`` = request.Tables; ``include_ccs_metadata`` = request.IncludeCcsMetadata; ``include_execution_metadata`` = request.IncludeExecutionMetadata |}
                |> Result.Ok
            with ex -> Result.Error ex

    module EsqlQueryRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: EsqlQueryRequest) : Result<Fes.Http.RequestMsg, exn> =
            EsqlQueryRequest.ToRequest request

    type EsqlQueryRequestBuilder() =
        member _.Yield(_: unit) : EsqlQueryRequest =
            {
                EsqlQueryRequest.Format = Option.None
                EsqlQueryRequest.Delimiter = Option.None
                EsqlQueryRequest.DropNullColumns = Option.None
                EsqlQueryRequest.AllowPartialResults = Option.None
                EsqlQueryRequest.Columnar = Option.None
                EsqlQueryRequest.Filter = Option.None
                EsqlQueryRequest.Locale = Option.None
                EsqlQueryRequest.Params = Option.None
                EsqlQueryRequest.Profile = Option.None
                EsqlQueryRequest.Query = String.Empty
                EsqlQueryRequest.Tables = Option.None
                EsqlQueryRequest.IncludeCcsMetadata = Option.None
                EsqlQueryRequest.IncludeExecutionMetadata = Option.None
            } : EsqlQueryRequest

        [<CustomOperation("format")>]
        member _.Format(state: EsqlQueryRequest, value: TypesEsqlFormat) =
            { state with EsqlQueryRequest.Format = Option.Some value } : EsqlQueryRequest

        [<CustomOperation("delimiter")>]
        member _.Delimiter(state: EsqlQueryRequest, value: string) =
            { state with EsqlQueryRequest.Delimiter = Option.Some value } : EsqlQueryRequest

        [<CustomOperation("drop_null_columns")>]
        member _.DropNullColumns(state: EsqlQueryRequest, value: bool) =
            { state with EsqlQueryRequest.DropNullColumns = Option.Some value } : EsqlQueryRequest

        [<CustomOperation("allow_partial_results")>]
        member _.AllowPartialResults(state: EsqlQueryRequest, value: bool) =
            { state with EsqlQueryRequest.AllowPartialResults = Option.Some value } : EsqlQueryRequest

        [<CustomOperation("columnar")>]
        member _.Columnar(state: EsqlQueryRequest, value: bool) =
            { state with EsqlQueryRequest.Columnar = Option.Some value } : EsqlQueryRequest

        [<CustomOperation("filter")>]
        member _.Filter(state: EsqlQueryRequest, value: QueryDslQueryContainer) =
            { state with EsqlQueryRequest.Filter = Option.Some value } : EsqlQueryRequest

        [<CustomOperation("locale")>]
        member _.Locale(state: EsqlQueryRequest, value: string) =
            { state with EsqlQueryRequest.Locale = Option.Some value } : EsqlQueryRequest

        [<CustomOperation("params")>]
        member _.Params(state: EsqlQueryRequest, value: TypesESQLParam array) =
            { state with EsqlQueryRequest.Params = Option.Some value } : EsqlQueryRequest

        [<CustomOperation("profile")>]
        member _.Profile(state: EsqlQueryRequest, value: bool) =
            { state with EsqlQueryRequest.Profile = Option.Some value } : EsqlQueryRequest

        [<CustomOperation("query")>]
        member _.Query(state: EsqlQueryRequest, value: string) =
            { state with EsqlQueryRequest.Query = value } : EsqlQueryRequest

        [<CustomOperation("tables")>]
        member _.Tables(state: EsqlQueryRequest, value: Map<string, Map<string, TypesTableValuesContainer>>) =
            { state with EsqlQueryRequest.Tables = Option.Some value } : EsqlQueryRequest

        [<CustomOperation("include_ccs_metadata")>]
        member _.IncludeCcsMetadata(state: EsqlQueryRequest, value: bool) =
            { state with EsqlQueryRequest.IncludeCcsMetadata = Option.Some value } : EsqlQueryRequest

        [<CustomOperation("include_execution_metadata")>]
        member _.IncludeExecutionMetadata(state: EsqlQueryRequest, value: bool) =
            { state with EsqlQueryRequest.IncludeExecutionMetadata = Option.Some value } : EsqlQueryRequest

    let esqlQueryRequest = EsqlQueryRequestBuilder()

    type EsqlQueryResponse = TypesEsqlResult


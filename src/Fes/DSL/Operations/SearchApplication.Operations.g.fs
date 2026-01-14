// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module SearchApplicationOperations =

    type SearchApplicationGetRequest = {
        Name: Name
    } with
        static member ToRequest(request: SearchApplicationGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_application/search_application/{request.Name}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module SearchApplicationGetRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SearchApplicationGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            SearchApplicationGetRequest.ToRequest request

    type SearchApplicationGetRequestBuilder() =
        member _.Yield(_: unit) : SearchApplicationGetRequest =
            {
                SearchApplicationGetRequest.Name = Unchecked.defaultof<Name>
            } : SearchApplicationGetRequest

        [<CustomOperation("name")>]
        member _.Name(state: SearchApplicationGetRequest, value: Name) =
            { state with SearchApplicationGetRequest.Name = value } : SearchApplicationGetRequest

    let searchApplicationGetRequest = SearchApplicationGetRequestBuilder()

    type SearchApplicationGetResponse = TypesSearchApplication

    type SearchApplicationPutRequest = {
        Name: Name
        Create: bool option
        [<JsonPropertyName("body")>]
        Body: TypesSearchApplicationParameters
    } with
        static member ToRequest(request: SearchApplicationPutRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_application/search_application/{request.Name}"
                let queryParams =
                    [
                        request.Create |> Option.map (fun v -> "create", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request.Body
                |> Result.Ok
            with ex -> Result.Error ex

    module SearchApplicationPutRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SearchApplicationPutRequest) : Result<Fes.Http.RequestMsg, exn> =
            SearchApplicationPutRequest.ToRequest request

    type SearchApplicationPutRequestBuilder() =
        member _.Yield(_: unit) : SearchApplicationPutRequest =
            {
                SearchApplicationPutRequest.Name = Unchecked.defaultof<Name>
                SearchApplicationPutRequest.Create = Option.None
                SearchApplicationPutRequest.Body = Unchecked.defaultof<TypesSearchApplicationParameters>
            } : SearchApplicationPutRequest

        [<CustomOperation("name")>]
        member _.Name(state: SearchApplicationPutRequest, value: Name) =
            { state with SearchApplicationPutRequest.Name = value } : SearchApplicationPutRequest

        [<CustomOperation("create")>]
        member _.Create(state: SearchApplicationPutRequest, value: bool) =
            { state with SearchApplicationPutRequest.Create = Option.Some value } : SearchApplicationPutRequest

        [<CustomOperation("body")>]
        member _.Body(state: SearchApplicationPutRequest, value: TypesSearchApplicationParameters) =
            { state with SearchApplicationPutRequest.Body = value } : SearchApplicationPutRequest

    let searchApplicationPutRequest = SearchApplicationPutRequestBuilder()

    type SearchApplicationPutResponse = {
        [<JsonPropertyName("result")>]
        Result: Result
    }

    type SearchApplicationDeleteRequest = {
        Name: Name
    } with
        static member ToRequest(request: SearchApplicationDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_application/search_application/{request.Name}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module SearchApplicationDeleteRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SearchApplicationDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            SearchApplicationDeleteRequest.ToRequest request

    type SearchApplicationDeleteRequestBuilder() =
        member _.Yield(_: unit) : SearchApplicationDeleteRequest =
            {
                SearchApplicationDeleteRequest.Name = Unchecked.defaultof<Name>
            } : SearchApplicationDeleteRequest

        [<CustomOperation("name")>]
        member _.Name(state: SearchApplicationDeleteRequest, value: Name) =
            { state with SearchApplicationDeleteRequest.Name = value } : SearchApplicationDeleteRequest

    let searchApplicationDeleteRequest = SearchApplicationDeleteRequestBuilder()

    type SearchApplicationDeleteResponse = AcknowledgedResponseBase

    type SearchApplicationListRequest = {
        Q: string option
        From: float option
        Size: float option
    } with
        static member ToRequest(request: SearchApplicationListRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_application/search_application"
                let queryParams =
                    [
                        request.Q |> Option.map (fun v -> "q", Fes.Http.toQueryValue v)
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

    module SearchApplicationListRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SearchApplicationListRequest) : Result<Fes.Http.RequestMsg, exn> =
            SearchApplicationListRequest.ToRequest request

    type SearchApplicationListRequestBuilder() =
        member _.Yield(_: unit) : SearchApplicationListRequest =
            {
                SearchApplicationListRequest.Q = Option.None
                SearchApplicationListRequest.From = Option.None
                SearchApplicationListRequest.Size = Option.None
            } : SearchApplicationListRequest

        [<CustomOperation("q")>]
        member _.Q(state: SearchApplicationListRequest, value: string) =
            { state with SearchApplicationListRequest.Q = Option.Some value } : SearchApplicationListRequest

        [<CustomOperation("from")>]
        member _.From(state: SearchApplicationListRequest, value: float) =
            { state with SearchApplicationListRequest.From = Option.Some value } : SearchApplicationListRequest

        [<CustomOperation("size")>]
        member _.Size(state: SearchApplicationListRequest, value: float) =
            { state with SearchApplicationListRequest.Size = Option.Some value } : SearchApplicationListRequest

    let searchApplicationListRequest = SearchApplicationListRequestBuilder()

    type SearchApplicationListResponse = {
        [<JsonPropertyName("count")>]
        Count: float
        [<JsonPropertyName("results")>]
        Results: TypesSearchApplication array
    }

    type SearchApplicationRenderQueryRequest = {
        Name: Name
        [<JsonPropertyName("params")>]
        Params: Map<string, obj> option
    } with
        static member ToRequest(request: SearchApplicationRenderQueryRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_application/search_application/{request.Name}/_render_query"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``params`` = request.Params |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SearchApplicationRenderQueryRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SearchApplicationRenderQueryRequest) : Result<Fes.Http.RequestMsg, exn> =
            SearchApplicationRenderQueryRequest.ToRequest request

    type SearchApplicationRenderQueryRequestBuilder() =
        member _.Yield(_: unit) : SearchApplicationRenderQueryRequest =
            {
                SearchApplicationRenderQueryRequest.Name = Unchecked.defaultof<Name>
                SearchApplicationRenderQueryRequest.Params = Option.None
            } : SearchApplicationRenderQueryRequest

        [<CustomOperation("name")>]
        member _.Name(state: SearchApplicationRenderQueryRequest, value: Name) =
            { state with SearchApplicationRenderQueryRequest.Name = value } : SearchApplicationRenderQueryRequest

        [<CustomOperation("params")>]
        member _.Params(state: SearchApplicationRenderQueryRequest, value: Map<string, obj>) =
            { state with SearchApplicationRenderQueryRequest.Params = Option.Some value } : SearchApplicationRenderQueryRequest

    let searchApplicationRenderQueryRequest = SearchApplicationRenderQueryRequestBuilder()

    type SearchApplicationSearchRequest = {
        Name: Name
        TypedKeys: bool option
        [<JsonPropertyName("params")>]
        Params: Map<string, obj> option
    } with
        static member ToRequest(request: SearchApplicationSearchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_application/search_application/{request.Name}/_search"
                let queryParams =
                    [
                        request.TypedKeys |> Option.map (fun v -> "typed_keys", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``params`` = request.Params |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SearchApplicationSearchRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SearchApplicationSearchRequest) : Result<Fes.Http.RequestMsg, exn> =
            SearchApplicationSearchRequest.ToRequest request

    type SearchApplicationSearchRequestBuilder() =
        member _.Yield(_: unit) : SearchApplicationSearchRequest =
            {
                SearchApplicationSearchRequest.Name = Unchecked.defaultof<Name>
                SearchApplicationSearchRequest.TypedKeys = Option.None
                SearchApplicationSearchRequest.Params = Option.None
            } : SearchApplicationSearchRequest

        [<CustomOperation("name")>]
        member _.Name(state: SearchApplicationSearchRequest, value: Name) =
            { state with SearchApplicationSearchRequest.Name = value } : SearchApplicationSearchRequest

        [<CustomOperation("typed_keys")>]
        member _.TypedKeys(state: SearchApplicationSearchRequest, value: bool) =
            { state with SearchApplicationSearchRequest.TypedKeys = Option.Some value } : SearchApplicationSearchRequest

        [<CustomOperation("params")>]
        member _.Params(state: SearchApplicationSearchRequest, value: Map<string, obj>) =
            { state with SearchApplicationSearchRequest.Params = Option.Some value } : SearchApplicationSearchRequest

    let searchApplicationSearchRequest = SearchApplicationSearchRequestBuilder()


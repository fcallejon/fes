// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module SearchApplicationOperations =

    type SearchApplicationDeleteRequest = {
        Name: Types.Name
    }

        with
        static member ToEndpoint(req: SearchApplicationDeleteRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_application/search_application/{Fes.Http.toPathSegment req.Name}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type SearchApplicationDeleteResponse = Types.AcknowledgedResponseBase

    type SearchApplicationDeleteRequestBuilder() =
        member _.Yield(_: unit) : SearchApplicationDeleteRequest =
            {
                Name = Unchecked.defaultof<_>
            }

        [<CustomOperation("name")>]
        member _.Name(state: SearchApplicationDeleteRequest, value: Types.Name) =
            { state with Name = value }

    let searchApplicationDeleteRequest = SearchApplicationDeleteRequestBuilder()

    type SearchApplicationDeleteBehavioralAnalyticsRequest = {
        Name: Types.Name
    }

        with
        static member ToEndpoint(req: SearchApplicationDeleteBehavioralAnalyticsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_application/analytics/{Fes.Http.toPathSegment req.Name}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type SearchApplicationDeleteBehavioralAnalyticsResponse = Types.AcknowledgedResponseBase

    type SearchApplicationDeleteBehavioralAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : SearchApplicationDeleteBehavioralAnalyticsRequest =
            {
                Name = Unchecked.defaultof<_>
            }

        [<CustomOperation("name")>]
        member _.Name(state: SearchApplicationDeleteBehavioralAnalyticsRequest, value: Types.Name) =
            { state with Name = value }

    let searchApplicationDeleteBehavioralAnalyticsRequest = SearchApplicationDeleteBehavioralAnalyticsRequestBuilder()

    type SearchApplicationGetRequest = {
        Name: Types.Name
    }

        with
        static member ToEndpoint(req: SearchApplicationGetRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_application/search_application/{Fes.Http.toPathSegment req.Name}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type SearchApplicationGetResponse = Types.SearchApplication

    type SearchApplicationGetRequestBuilder() =
        member _.Yield(_: unit) : SearchApplicationGetRequest =
            {
                Name = Unchecked.defaultof<_>
            }

        [<CustomOperation("name")>]
        member _.Name(state: SearchApplicationGetRequest, value: Types.Name) =
            { state with Name = value }

    let searchApplicationGetRequest = SearchApplicationGetRequestBuilder()

    type SearchApplicationGetBehavioralAnalyticsRequest = {
        Name: Types.Name list
    }

        with
        static member ToEndpoint(req: SearchApplicationGetBehavioralAnalyticsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_application/analytics/{Fes.Http.toPathSegment req.Name}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type SearchApplicationGetBehavioralAnalyticsResponse = Map<Types.Name, Types.AnalyticsCollection>

    type SearchApplicationGetBehavioralAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : SearchApplicationGetBehavioralAnalyticsRequest =
            {
                Name = Unchecked.defaultof<_>
            }

        [<CustomOperation("name")>]
        member _.Name(state: SearchApplicationGetBehavioralAnalyticsRequest, value: Types.Name list) =
            { state with Name = value }

    let searchApplicationGetBehavioralAnalyticsRequest = SearchApplicationGetBehavioralAnalyticsRequestBuilder()

    type SearchApplicationListRequest = {
        Q: string option
        From: Types.Integer option
        Size: Types.Integer option
    }

        with
        static member ToEndpoint(req: SearchApplicationListRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_application/search_application"
            let queryParams =
                [
                    req.Q |> Option.map (fun v -> "q", Fes.Http.toQueryValue v)
                    req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                    req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type SearchApplicationListResponse = System.Text.Json.JsonElement

    type SearchApplicationListRequestBuilder() =
        member _.Yield(_: unit) : SearchApplicationListRequest =
            {
                Q = None
                From = None
                Size = None
            }

        [<CustomOperation("q")>]
        member _.Q(state: SearchApplicationListRequest, value: string) =
            { state with Q = Some value }

        [<CustomOperation("from")>]
        member _.From(state: SearchApplicationListRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: SearchApplicationListRequest, value: Types.Integer) =
            { state with Size = Some value }

    let searchApplicationListRequest = SearchApplicationListRequestBuilder()

    module List =
        let withQ (value: string) (req: SearchApplicationListRequest) =
            { req with Q = Some value }
        let withFrom (value: Types.Integer) (req: SearchApplicationListRequest) =
            { req with From = Some value }
        let withSize (value: Types.Integer) (req: SearchApplicationListRequest) =
            { req with Size = Some value }

    type SearchApplicationPostBehavioralAnalyticsEventRequest = {
        CollectionName: Types.Name
        EventType: Types.EventType
        Debug: bool option
        Document: System.Text.Json.JsonElement
    }

        with
        static member ToEndpoint(req: SearchApplicationPostBehavioralAnalyticsEventRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_application/analytics/{Fes.Http.toPathSegment req.CollectionName}/event/{Fes.Http.toPathSegment req.EventType}"
            let queryParams =
                [
                    req.Debug |> Option.map (fun v -> "debug", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req.Document)
            endpoint, ValueSome postData

    type SearchApplicationPostBehavioralAnalyticsEventResponse = System.Text.Json.JsonElement

    type SearchApplicationPostBehavioralAnalyticsEventRequestBuilder() =
        member _.Yield(_: unit) : SearchApplicationPostBehavioralAnalyticsEventRequest =
            {
                CollectionName = Unchecked.defaultof<_>
                EventType = Unchecked.defaultof<_>
                Debug = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("collectionName")>]
        member _.CollectionName(state: SearchApplicationPostBehavioralAnalyticsEventRequest, value: Types.Name) =
            { state with CollectionName = value }

        [<CustomOperation("eventType")>]
        member _.EventType(state: SearchApplicationPostBehavioralAnalyticsEventRequest, value: Types.EventType) =
            { state with EventType = value }

        [<CustomOperation("debug")>]
        member _.Debug(state: SearchApplicationPostBehavioralAnalyticsEventRequest, value: bool) =
            { state with Debug = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: SearchApplicationPostBehavioralAnalyticsEventRequest, value) =
            { state with Document = value }

    let searchApplicationPostBehavioralAnalyticsEventRequest = SearchApplicationPostBehavioralAnalyticsEventRequestBuilder()

    module PostBehavioralAnalyticsEvent =
        let withDebug (value: bool) (req: SearchApplicationPostBehavioralAnalyticsEventRequest) =
            { req with Debug = Some value }

    type SearchApplicationPutRequest = {
        Name: Types.Name
        Create: bool option
        Document: Types.SearchApplicationParameters
    }

        with
        static member ToEndpoint(req: SearchApplicationPutRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_application/search_application/{Fes.Http.toPathSegment req.Name}"
            let queryParams =
                [
                    req.Create |> Option.map (fun v -> "create", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req.Document)
            endpoint, ValueSome postData

    type SearchApplicationPutResponse = System.Text.Json.JsonElement

    type SearchApplicationPutRequestBuilder() =
        member _.Yield(_: unit) : SearchApplicationPutRequest =
            {
                Name = Unchecked.defaultof<_>
                Create = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("name")>]
        member _.Name(state: SearchApplicationPutRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("create")>]
        member _.Create(state: SearchApplicationPutRequest, value: bool) =
            { state with Create = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: SearchApplicationPutRequest, value) =
            { state with Document = value }

    let searchApplicationPutRequest = SearchApplicationPutRequestBuilder()

    module Put =
        let withCreate (value: bool) (req: SearchApplicationPutRequest) =
            { req with Create = Some value }

    type SearchApplicationPutBehavioralAnalyticsRequest = {
        Name: Types.Name
    }

        with
        static member ToEndpoint(req: SearchApplicationPutBehavioralAnalyticsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_application/analytics/{Fes.Http.toPathSegment req.Name}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            endpoint, ValueNone

    type SearchApplicationPutBehavioralAnalyticsResponse = Types.AnalyticsAcknowledgeResponseBase

    type SearchApplicationPutBehavioralAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : SearchApplicationPutBehavioralAnalyticsRequest =
            {
                Name = Unchecked.defaultof<_>
            }

        [<CustomOperation("name")>]
        member _.Name(state: SearchApplicationPutBehavioralAnalyticsRequest, value: Types.Name) =
            { state with Name = value }

    let searchApplicationPutBehavioralAnalyticsRequest = SearchApplicationPutBehavioralAnalyticsRequestBuilder()

    type SearchApplicationRenderQueryRequest = {
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
    }

        with
        static member ToEndpoint(req: SearchApplicationRenderQueryRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_application/search_application/{Fes.Http.toPathSegment req.Name}/_render_query"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type SearchApplicationRenderQueryResponse = System.Text.Json.JsonElement

    type SearchApplicationRenderQueryRequestBuilder() =
        member _.Yield(_: unit) : SearchApplicationRenderQueryRequest =
            {
                Name = Unchecked.defaultof<_>
                Params = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: SearchApplicationRenderQueryRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("params")>]
        member _.Params(state: SearchApplicationRenderQueryRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

    let searchApplicationRenderQueryRequest = SearchApplicationRenderQueryRequestBuilder()

    module RenderQuery =
        let withParams (value: Map<string, System.Text.Json.JsonElement>) (req: SearchApplicationRenderQueryRequest) =
            { req with Params = Some value }

    type SearchApplicationSearchRequest = {
        Name: Types.Name
        TypedKeys: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
    }

        with
        static member ToEndpoint(req: SearchApplicationSearchRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_application/search_application/{Fes.Http.toPathSegment req.Name}/_search"
            let queryParams =
                [
                    req.TypedKeys |> Option.map (fun v -> "typed_keys", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type SearchApplicationSearchResponse<'TDocument> = Types.ResponseBody<'TDocument>

    type SearchApplicationSearchRequestBuilder() =
        member _.Yield(_: unit) : SearchApplicationSearchRequest =
            {
                Name = Unchecked.defaultof<_>
                TypedKeys = None
                Params = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: SearchApplicationSearchRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("typedKeys")>]
        member _.TypedKeys(state: SearchApplicationSearchRequest, value: bool) =
            { state with TypedKeys = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: SearchApplicationSearchRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

    let searchApplicationSearchRequest = SearchApplicationSearchRequestBuilder()

    module Search =
        let withTypedKeys (value: bool) (req: SearchApplicationSearchRequest) =
            { req with TypedKeys = Some value }
        let withParams (value: Map<string, System.Text.Json.JsonElement>) (req: SearchApplicationSearchRequest) =
            { req with Params = Some value }


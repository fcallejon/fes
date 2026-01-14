// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module AnalyticsOperations =

    type SearchApplicationGetBehavioralAnalyticsRequest = {
        Name: Name array
    } with
        static member ToRequest(request: SearchApplicationGetBehavioralAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_application/analytics/{request.Name}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module SearchApplicationGetBehavioralAnalyticsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SearchApplicationGetBehavioralAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            SearchApplicationGetBehavioralAnalyticsRequest.ToRequest request

    type SearchApplicationGetBehavioralAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : SearchApplicationGetBehavioralAnalyticsRequest =
            {
                SearchApplicationGetBehavioralAnalyticsRequest.Name = [||]
            } : SearchApplicationGetBehavioralAnalyticsRequest

        [<CustomOperation("name")>]
        member _.Name(state: SearchApplicationGetBehavioralAnalyticsRequest, value: Name array) =
            { state with SearchApplicationGetBehavioralAnalyticsRequest.Name = value } : SearchApplicationGetBehavioralAnalyticsRequest

    let searchApplicationGetBehavioralAnalyticsRequest = SearchApplicationGetBehavioralAnalyticsRequestBuilder()

    type SearchApplicationPutBehavioralAnalyticsRequest = {
        Name: Name
    } with
        static member ToRequest(request: SearchApplicationPutBehavioralAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_application/analytics/{request.Name}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Result.Ok
            with ex -> Result.Error ex

    module SearchApplicationPutBehavioralAnalyticsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SearchApplicationPutBehavioralAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            SearchApplicationPutBehavioralAnalyticsRequest.ToRequest request

    type SearchApplicationPutBehavioralAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : SearchApplicationPutBehavioralAnalyticsRequest =
            {
                SearchApplicationPutBehavioralAnalyticsRequest.Name = Unchecked.defaultof<Name>
            } : SearchApplicationPutBehavioralAnalyticsRequest

        [<CustomOperation("name")>]
        member _.Name(state: SearchApplicationPutBehavioralAnalyticsRequest, value: Name) =
            { state with SearchApplicationPutBehavioralAnalyticsRequest.Name = value } : SearchApplicationPutBehavioralAnalyticsRequest

    let searchApplicationPutBehavioralAnalyticsRequest = SearchApplicationPutBehavioralAnalyticsRequestBuilder()

    type SearchApplicationPutBehavioralAnalyticsResponse = PutBehavioralAnalyticsAnalyticsAcknowledgeResponseBase

    type SearchApplicationDeleteBehavioralAnalyticsRequest = {
        Name: Name
    } with
        static member ToRequest(request: SearchApplicationDeleteBehavioralAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_application/analytics/{request.Name}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module SearchApplicationDeleteBehavioralAnalyticsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SearchApplicationDeleteBehavioralAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            SearchApplicationDeleteBehavioralAnalyticsRequest.ToRequest request

    type SearchApplicationDeleteBehavioralAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : SearchApplicationDeleteBehavioralAnalyticsRequest =
            {
                SearchApplicationDeleteBehavioralAnalyticsRequest.Name = Unchecked.defaultof<Name>
            } : SearchApplicationDeleteBehavioralAnalyticsRequest

        [<CustomOperation("name")>]
        member _.Name(state: SearchApplicationDeleteBehavioralAnalyticsRequest, value: Name) =
            { state with SearchApplicationDeleteBehavioralAnalyticsRequest.Name = value } : SearchApplicationDeleteBehavioralAnalyticsRequest

    let searchApplicationDeleteBehavioralAnalyticsRequest = SearchApplicationDeleteBehavioralAnalyticsRequestBuilder()

    type SearchApplicationDeleteBehavioralAnalyticsResponse = AcknowledgedResponseBase

    type SearchApplicationPostBehavioralAnalyticsEventRequest = {
        CollectionName: Name
        EventType: TypesEventType
        Debug: bool option
    } with
        static member ToRequest(request: SearchApplicationPostBehavioralAnalyticsEventRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_application/analytics/{request.CollectionName}/event/{request.EventType}"
                let queryParams =
                    [
                        request.Debug |> Option.map (fun v -> "debug", string v)
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

    module SearchApplicationPostBehavioralAnalyticsEventRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SearchApplicationPostBehavioralAnalyticsEventRequest) : Result<Fes.Http.RequestMsg, exn> =
            SearchApplicationPostBehavioralAnalyticsEventRequest.ToRequest request

    type SearchApplicationPostBehavioralAnalyticsEventRequestBuilder() =
        member _.Yield(_: unit) : SearchApplicationPostBehavioralAnalyticsEventRequest =
            {
                SearchApplicationPostBehavioralAnalyticsEventRequest.CollectionName = Unchecked.defaultof<Name>
                SearchApplicationPostBehavioralAnalyticsEventRequest.EventType = Unchecked.defaultof<TypesEventType>
                SearchApplicationPostBehavioralAnalyticsEventRequest.Debug = Option.None
            } : SearchApplicationPostBehavioralAnalyticsEventRequest

        [<CustomOperation("collection_name")>]
        member _.CollectionName(state: SearchApplicationPostBehavioralAnalyticsEventRequest, value: Name) =
            { state with SearchApplicationPostBehavioralAnalyticsEventRequest.CollectionName = value } : SearchApplicationPostBehavioralAnalyticsEventRequest

        [<CustomOperation("event_type")>]
        member _.EventType(state: SearchApplicationPostBehavioralAnalyticsEventRequest, value: TypesEventType) =
            { state with SearchApplicationPostBehavioralAnalyticsEventRequest.EventType = value } : SearchApplicationPostBehavioralAnalyticsEventRequest

        [<CustomOperation("debug")>]
        member _.Debug(state: SearchApplicationPostBehavioralAnalyticsEventRequest, value: bool) =
            { state with SearchApplicationPostBehavioralAnalyticsEventRequest.Debug = Option.Some value } : SearchApplicationPostBehavioralAnalyticsEventRequest

    let searchApplicationPostBehavioralAnalyticsEventRequest = SearchApplicationPostBehavioralAnalyticsEventRequestBuilder()

    type SearchApplicationPostBehavioralAnalyticsEventResponse = {
        [<JsonPropertyName("accepted")>]
        Accepted: bool
        [<JsonPropertyName("event")>]
        Event: obj option
    }


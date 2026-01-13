// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module GraphOperations =

    type GraphExploreRequest = {
        [<JsonPropertyName("index")>]
        Index: Indices
        [<JsonPropertyName("routing")>]
        Routing: Routing option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
        [<JsonPropertyName("connections")>]
        Connections: TypesHop option
        [<JsonPropertyName("controls")>]
        Controls: TypesExploreControls option
        [<JsonPropertyName("query")>]
        Query: QueryDslQueryContainer option
        [<JsonPropertyName("vertices")>]
        Vertices: TypesVertexDefinition array option
    } with
        static member ToRequest(request: GraphExploreRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_graph/explore"
                let queryParams =
                    [
                        request.Routing |> Option.map (fun v -> "routing", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module GraphExploreRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: GraphExploreRequest) : Result<Fes.Http.RequestMsg, exn> =
            GraphExploreRequest.ToRequest request

    type GraphExploreRequestBuilder() =
        member _.Yield(_: unit) : GraphExploreRequest =
            {
                GraphExploreRequest.Index = Unchecked.defaultof<Indices>
                GraphExploreRequest.Routing = Option.None
                GraphExploreRequest.Timeout = Option.None
                GraphExploreRequest.Connections = Option.None
                GraphExploreRequest.Controls = Option.None
                GraphExploreRequest.Query = Option.None
                GraphExploreRequest.Vertices = Option.None
            } : GraphExploreRequest

        [<CustomOperation("index")>]
        member _.Index(state: GraphExploreRequest, value: Indices) =
            { state with GraphExploreRequest.Index = value } : GraphExploreRequest

        [<CustomOperation("routing")>]
        member _.Routing(state: GraphExploreRequest, value: Routing) =
            { state with GraphExploreRequest.Routing = Option.Some value } : GraphExploreRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: GraphExploreRequest, value: Duration) =
            { state with GraphExploreRequest.Timeout = Option.Some value } : GraphExploreRequest

        [<CustomOperation("connections")>]
        member _.Connections(state: GraphExploreRequest, value: TypesHop) =
            { state with GraphExploreRequest.Connections = Option.Some value } : GraphExploreRequest

        [<CustomOperation("controls")>]
        member _.Controls(state: GraphExploreRequest, value: TypesExploreControls) =
            { state with GraphExploreRequest.Controls = Option.Some value } : GraphExploreRequest

        [<CustomOperation("query")>]
        member _.Query(state: GraphExploreRequest, value: QueryDslQueryContainer) =
            { state with GraphExploreRequest.Query = Option.Some value } : GraphExploreRequest

        [<CustomOperation("vertices")>]
        member _.Vertices(state: GraphExploreRequest, value: TypesVertexDefinition array) =
            { state with GraphExploreRequest.Vertices = Option.Some value } : GraphExploreRequest

    let graphExploreRequest = GraphExploreRequestBuilder()


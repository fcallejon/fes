// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module GraphOperations =

    type GraphExploreRequest = {
        Index: CoreTypes.Indices
        Routing: CoreTypes.Routing option
        Timeout: CoreTypes.Duration option
        Connections: GraphTypes.Hop option
        Controls: GraphTypes.ExploreControls option
        Query: CoreTypes.QueryContainer option
        Vertices: GraphTypes.VertexDefinition list option
    }

        with
        static member ToRequest(req: GraphExploreRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_graph/explore"
                let queryParams =
                    [
                        req.Routing |> Option.map (fun v -> "routing", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
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

    type GraphExploreResponse = System.Text.Json.JsonElement

    type GraphExploreRequestBuilder() =
        member _.Yield(_: unit) : GraphExploreRequest =
            {
                Index = Unchecked.defaultof<_>
                Routing = None
                Timeout = None
                Connections = None
                Controls = None
                Query = None
                Vertices = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: GraphExploreRequest, value: CoreTypes.Indices) =
            { state with Index = value }

        [<CustomOperation("routing")>]
        member _.Routing(state: GraphExploreRequest, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: GraphExploreRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("connections")>]
        member _.Connections(state: GraphExploreRequest, value: GraphTypes.Hop) =
            { state with Connections = Some value }

        [<CustomOperation("controls")>]
        member _.Controls(state: GraphExploreRequest, value: GraphTypes.ExploreControls) =
            { state with Controls = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: GraphExploreRequest, value: CoreTypes.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("vertices")>]
        member _.Vertices(state: GraphExploreRequest, value: GraphTypes.VertexDefinition list) =
            { state with Vertices = Some value }

    let graphExploreRequest = GraphExploreRequestBuilder()

    module Explore =
        let withRouting (value: CoreTypes.Routing) (req: GraphExploreRequest) =
            { req with Routing = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: GraphExploreRequest) =
            { req with Timeout = Some value }
        let withConnections (value: GraphTypes.Hop) (req: GraphExploreRequest) =
            { req with Connections = Some value }
        let withControls (value: GraphTypes.ExploreControls) (req: GraphExploreRequest) =
            { req with Controls = Some value }
        let withQuery (value: CoreTypes.QueryContainer) (req: GraphExploreRequest) =
            { req with Query = Some value }
        let withVertices (value: GraphTypes.VertexDefinition list) (req: GraphExploreRequest) =
            { req with Vertices = Some value }


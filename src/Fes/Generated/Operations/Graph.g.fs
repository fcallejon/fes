// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module GraphOperations =

    type GraphExploreRequest = {
        Index: Types.Indices
        Routing: Types.Routing option
        Timeout: Types.Duration option
        Connections: Types.Hop option
        Controls: Types.ExploreControls option
        Query: Types.QueryContainer option
        Vertices: Types.VertexDefinition list option
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
        member _.Index(state: GraphExploreRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("routing")>]
        member _.Routing(state: GraphExploreRequest, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: GraphExploreRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("connections")>]
        member _.Connections(state: GraphExploreRequest, value: Types.Hop) =
            { state with Connections = Some value }

        [<CustomOperation("controls")>]
        member _.Controls(state: GraphExploreRequest, value: Types.ExploreControls) =
            { state with Controls = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: GraphExploreRequest, value: Types.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("vertices")>]
        member _.Vertices(state: GraphExploreRequest, value: Types.VertexDefinition list) =
            { state with Vertices = Some value }

    let graphExploreRequest = GraphExploreRequestBuilder()

    module Explore =
        let withRouting (value: Types.Routing) (req: GraphExploreRequest) =
            { req with Routing = Some value }
        let withTimeout (value: Types.Duration) (req: GraphExploreRequest) =
            { req with Timeout = Some value }
        let withConnections (value: Types.Hop) (req: GraphExploreRequest) =
            { req with Connections = Some value }
        let withControls (value: Types.ExploreControls) (req: GraphExploreRequest) =
            { req with Controls = Some value }
        let withQuery (value: Types.QueryContainer) (req: GraphExploreRequest) =
            { req with Query = Some value }
        let withVertices (value: Types.VertexDefinition list) (req: GraphExploreRequest) =
            { req with Vertices = Some value }


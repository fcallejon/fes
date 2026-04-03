// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module GraphTypesBuilders =

    type ExploreControlsBuilder() =
        member _.Yield(_: unit) : ExploreControls =
            {
                SampleDiversity = None
                SampleSize = None
                Timeout = None
                UseSignificance = Unchecked.defaultof<_>
            }

        [<CustomOperation("sampleDiversity")>]
        member _.SampleDiversity(state: ExploreControls, value: GraphTypes.SampleDiversity) =
            { state with SampleDiversity = Some value }

        [<CustomOperation("sampleSize")>]
        member _.SampleSize(state: ExploreControls, value: CoreTypes.Integer) =
            { state with SampleSize = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: ExploreControls, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("useSignificance")>]
        member _.UseSignificance(state: ExploreControls, value: bool) =
            { state with UseSignificance = value }

    let exploreControls = ExploreControlsBuilder()

    type HopBuilder() =
        member _.Yield(_: unit) : Hop =
            {
                Connections = None
                Query = None
                Vertices = Unchecked.defaultof<_>
            }

        [<CustomOperation("connections")>]
        member _.Connections(state: Hop, value: GraphTypes.Hop) =
            { state with Connections = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: Hop, value: CoreTypes.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("vertices")>]
        member _.Vertices(state: Hop, value: GraphTypes.VertexDefinition list) =
            { state with Vertices = value }

    let hop = HopBuilder()

    type VertexDefinitionBuilder() =
        member _.Yield(_: unit) : VertexDefinition =
            {
                Exclude = None
                Field = Unchecked.defaultof<_>
                Include = None
                MinDocCount = None
                ShardMinDocCount = None
                Size = None
            }

        [<CustomOperation("exclude")>]
        member _.Exclude(state: VertexDefinition, value: string list) =
            { state with Exclude = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: VertexDefinition, value: CoreTypes.Field) =
            { state with Field = value }

        [<CustomOperation("include")>]
        member _.Include(state: VertexDefinition, value: GraphTypes.VertexInclude list) =
            { state with Include = Some value }

        [<CustomOperation("minDocCount")>]
        member _.MinDocCount(state: VertexDefinition, value: CoreTypes.Long) =
            { state with MinDocCount = Some value }

        [<CustomOperation("shardMinDocCount")>]
        member _.ShardMinDocCount(state: VertexDefinition, value: CoreTypes.Long) =
            { state with ShardMinDocCount = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: VertexDefinition, value: CoreTypes.Integer) =
            { state with Size = Some value }

    let vertexDefinition = VertexDefinitionBuilder()


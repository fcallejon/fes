// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module GraphTypesBuilders =

    type ExploreControlsBuilder() =
        member _.Yield(_: unit) : Types.ExploreControls =
            {
                SampleDiversity = None
                SampleSize = None
                Timeout = None
                UseSignificance = Unchecked.defaultof<_>
            }

        [<CustomOperation("sampleDiversity")>]
        member _.SampleDiversity(state: Types.ExploreControls, value: Types.SampleDiversity) =
            { state with SampleDiversity = Some value }

        [<CustomOperation("sampleSize")>]
        member _.SampleSize(state: Types.ExploreControls, value: Types.Integer) =
            { state with SampleSize = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: Types.ExploreControls, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("useSignificance")>]
        member _.UseSignificance(state: Types.ExploreControls, value: bool) =
            { state with UseSignificance = value }

    let exploreControls = ExploreControlsBuilder()

    type HopBuilder() =
        member _.Yield(_: unit) : Types.Hop =
            {
                Connections = None
                Query = None
                Vertices = Unchecked.defaultof<_>
            }

        [<CustomOperation("connections")>]
        member _.Connections(state: Types.Hop, value: Types.Hop) =
            { state with Connections = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.Hop, value: Types.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("vertices")>]
        member _.Vertices(state: Types.Hop, value: Types.VertexDefinition list) =
            { state with Vertices = value }

    let hop = HopBuilder()

    type VertexDefinitionBuilder() =
        member _.Yield(_: unit) : Types.VertexDefinition =
            {
                Exclude = None
                Field = Unchecked.defaultof<_>
                Include = None
                MinDocCount = None
                ShardMinDocCount = None
                Size = None
            }

        [<CustomOperation("exclude")>]
        member _.Exclude(state: Types.VertexDefinition, value: string list) =
            { state with Exclude = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.VertexDefinition, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("include")>]
        member _.Include(state: Types.VertexDefinition, value: Types.VertexInclude list) =
            { state with Include = Some value }

        [<CustomOperation("minDocCount")>]
        member _.MinDocCount(state: Types.VertexDefinition, value: Types.Long) =
            { state with MinDocCount = Some value }

        [<CustomOperation("shardMinDocCount")>]
        member _.ShardMinDocCount(state: Types.VertexDefinition, value: Types.Long) =
            { state with ShardMinDocCount = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.VertexDefinition, value: Types.Integer) =
            { state with Size = Some value }

    let vertexDefinition = VertexDefinitionBuilder()


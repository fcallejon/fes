// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module AsyncSearchStatusBuilders =

    type StatusResponseBaseBuilder() =
        member _.Yield(_: unit) : Types.StatusResponseBase =
            {
                Shards = Unchecked.defaultof<_>
                Clusters = None
                CompletionStatus = None
            }

        [<CustomOperation("shards")>]
        member _.Shards(state: Types.StatusResponseBase, value: Types.ShardStatistics) =
            { state with Shards = value }

        [<CustomOperation("clusters")>]
        member _.Clusters(state: Types.StatusResponseBase, value: Types.ClusterStatistics) =
            { state with Clusters = Some value }

        [<CustomOperation("completionStatus")>]
        member _.CompletionStatus(state: Types.StatusResponseBase, value: Types.Integer) =
            { state with CompletionStatus = Some value }

    let statusResponseBase = StatusResponseBaseBuilder()


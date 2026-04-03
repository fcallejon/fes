// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module AsyncSearchStatusBuilders =

    type StatusResponseBaseBuilder() =
        member _.Yield(_: unit) : StatusResponseBase =
            {
                Shards = Unchecked.defaultof<_>
                Clusters = None
                CompletionStatus = None
            }

        [<CustomOperation("shards")>]
        member _.Shards(state: StatusResponseBase, value: CoreTypes.ShardStatistics) =
            { state with Shards = value }

        [<CustomOperation("clusters")>]
        member _.Clusters(state: StatusResponseBase, value: CoreTypes.ClusterStatistics) =
            { state with Clusters = Some value }

        [<CustomOperation("completionStatus")>]
        member _.CompletionStatus(state: StatusResponseBase, value: CoreTypes.Integer) =
            { state with CompletionStatus = Some value }

    let statusResponseBase = StatusResponseBaseBuilder()


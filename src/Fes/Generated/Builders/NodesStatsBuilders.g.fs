// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module NodesStatsBuilders =

    type NodesStatsResponseBaseBuilder() =
        member _.Yield(_: unit) : Types.NodesStatsResponseBase =
            {
                ClusterName = None
                Nodes = Unchecked.defaultof<_>
                NodesField = None
            }

        [<CustomOperation("clusterName")>]
        member _.ClusterName(state: Types.NodesStatsResponseBase, value: Types.Name) =
            { state with ClusterName = Some value }

        [<CustomOperation("nodes")>]
        member _.Nodes(state: Types.NodesStatsResponseBase, value: Map<string, Types.Stats>) =
            { state with Nodes = value }

        [<CustomOperation("nodesField")>]
        member _.NodesField(state: Types.NodesStatsResponseBase, value: Types.NodeStatistics) =
            { state with NodesField = Some value }

    let nodesStatsResponseBase = NodesStatsResponseBaseBuilder()


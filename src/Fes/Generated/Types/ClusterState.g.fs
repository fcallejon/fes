// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module ClusterState =

    [<RequireQualifiedAccess>]
    type ClusterStateMetric =
        | All
        | Version
        | MasterNode
        | Blocks
        | Nodes
        | Metadata
        | RoutingTable
        | RoutingNodes
        | Customs

    [<RequireQualifiedAccess>]
    type ClusterStateMetrics =
        | ClusterStateMetric of ClusterStateMetric
        | Array of ClusterStateMetric list


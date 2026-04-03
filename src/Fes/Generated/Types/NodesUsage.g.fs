// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module NodesUsage =

    type NodeUsage = {
        [<System.Text.Json.Serialization.JsonPropertyName("rest_actions")>]
        RestActions: Map<string, CoreTypes.Integer>
        [<System.Text.Json.Serialization.JsonPropertyName("since")>]
        Since: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("aggregations")>]
        Aggregations: Map<string, System.Text.Json.JsonElement>
    }

    [<RequireQualifiedAccess>]
    type NodesUsageMetric =
        | All
        | RestActions
        | Aggregations

    [<RequireQualifiedAccess>]
    type NodesUsageMetrics =
        | NodesUsageMetric of NodesUsageMetric
        | Array of NodesUsageMetric list

    type ResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_name")>]
        ClusterName: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("nodes")>]
        Nodes: Map<string, NodeUsage>
    }


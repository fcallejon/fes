// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module NodesUsage =

    type NodeUsage = {
        [<System.Text.Json.Serialization.JsonPropertyName("rest_actions")>]
        RestActions: Map<string, Types.Integer>
        [<System.Text.Json.Serialization.JsonPropertyName("since")>]
        Since: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.EpochTime<Types.UnitMillis>
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
        | NodesUsageMetric of NodesUsage.NodesUsageMetric
        | Array of NodesUsage.NodesUsageMetric list

    type ResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_name")>]
        ClusterName: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("nodes")>]
        Nodes: Map<string, NodesUsage.NodeUsage>
    }


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module NodesStats =

    [<RequireQualifiedAccess>]
    type NodeStatsMetric =
        | All
        | None
        | Indices
        | Os
        | Process
        | Jvm
        | ThreadPool
        | Fs
        | Transport
        | Http
        | Breaker
        | Script
        | Discovery
        | Ingest
        | AdaptiveSelection
        | ScriptCache
        | IndexingPressure
        | Repositories
        | Allocations

    [<RequireQualifiedAccess>]
    type NodeStatsMetrics =
        | NodeStatsMetric of NodeStatsMetric
        | Array of NodeStatsMetric list

    type ResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_name")>]
        ClusterName: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("nodes")>]
        Nodes: Map<string, NodesTypes.Stats>
    }


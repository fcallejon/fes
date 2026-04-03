// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module AsyncSearchStatus =

    type StatusResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("_shards")>]
        Shards: CoreTypes.ShardStatistics
        [<System.Text.Json.Serialization.JsonPropertyName("_clusters")>]
        Clusters: CoreTypes.ClusterStatistics option
        [<System.Text.Json.Serialization.JsonPropertyName("completion_status")>]
        CompletionStatus: CoreTypes.Integer option
    }


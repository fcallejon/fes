// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module AsyncSearchStatus =

    type StatusResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("_shards")>]
        Shards: Types.ShardStatistics
        [<System.Text.Json.Serialization.JsonPropertyName("_clusters")>]
        Clusters: Types.ClusterStatistics option
        [<System.Text.Json.Serialization.JsonPropertyName("completion_status")>]
        CompletionStatus: Types.Integer option
    }


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesReloadSearchAnalyzers =

    type ReloadDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: string
        [<System.Text.Json.Serialization.JsonPropertyName("reloaded_analyzers")>]
        ReloadedAnalyzers: string list
        [<System.Text.Json.Serialization.JsonPropertyName("reloaded_node_ids")>]
        ReloadedNodeIds: string list
    }

    type ReloadResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("reload_details")>]
        ReloadDetails: IndicesReloadSearchAnalyzers.ReloadDetails list
        [<System.Text.Json.Serialization.JsonPropertyName("_shards")>]
        Shards: Types.ShardStatistics
    }


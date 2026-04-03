// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesClose =

    type CloseShardResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("failures")>]
        Failures: CoreTypes.ShardFailure list
    }

    type CloseIndexResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("closed")>]
        Closed: bool
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: Map<string, CloseShardResult> option
    }


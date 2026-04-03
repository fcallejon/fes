// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SnapshotRestore =

    type SnapshotRestore = {
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: Types.IndexName list
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot")>]
        Snapshot: string
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: Types.ShardStatistics
    }


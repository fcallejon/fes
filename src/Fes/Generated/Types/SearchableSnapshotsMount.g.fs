// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SearchableSnapshotsMount =

    type MountedSnapshot = {
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot")>]
        Snapshot: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: CoreTypes.Indices
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: CoreTypes.ShardStatistics
    }

    [<RequireQualifiedAccess>]
    type StorageOption =
        | FullCopy
        | SharedCache


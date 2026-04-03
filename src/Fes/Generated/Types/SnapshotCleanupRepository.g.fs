// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SnapshotCleanupRepository =

    type CleanupRepositoryResults = {
        [<System.Text.Json.Serialization.JsonPropertyName("deleted_blobs")>]
        DeletedBlobs: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("deleted_bytes")>]
        DeletedBytes: Types.Long
    }


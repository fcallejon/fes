// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SnapshotGet =

    type SnapshotResponseItem = {
        [<System.Text.Json.Serialization.JsonPropertyName("repository")>]
        Repository: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("snapshots")>]
        Snapshots: SnapshotTypes.SnapshotInfo list option
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: Types.ErrorCause option
    }


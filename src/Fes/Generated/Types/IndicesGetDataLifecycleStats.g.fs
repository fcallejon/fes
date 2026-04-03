// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesGetDataLifecycleStats =

    type DataStreamStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("backing_indices_in_error")>]
        BackingIndicesInError: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("backing_indices_in_total")>]
        BackingIndicesInTotal: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.DataStreamName
    }


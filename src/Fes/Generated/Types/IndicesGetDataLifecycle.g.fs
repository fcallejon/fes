// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesGetDataLifecycle =

    type DataStreamWithLifecycle = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.DataStreamName
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle")>]
        Lifecycle: IndicesTypes.DataStreamLifecycleWithRollover option
    }


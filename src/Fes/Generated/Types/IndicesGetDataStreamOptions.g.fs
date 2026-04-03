// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesGetDataStreamOptions =

    type DataStreamWithOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.DataStreamName
        [<System.Text.Json.Serialization.JsonPropertyName("options")>]
        Options: IndicesTypes.DataStreamOptions option
    }


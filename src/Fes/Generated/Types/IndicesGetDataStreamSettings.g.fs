// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesGetDataStreamSettings =

    type DataStreamSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: IndicesTypes.IndexSettings
        [<System.Text.Json.Serialization.JsonPropertyName("effective_settings")>]
        EffectiveSettings: IndicesTypes.IndexSettings
    }


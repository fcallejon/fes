// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesPutDataStreamMappings =

    type UpdatedDataStreamMappings = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("applied_to_data_stream")>]
        AppliedToDataStream: bool
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: string option
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: CoreTypes.TypeMapping option
        [<System.Text.Json.Serialization.JsonPropertyName("effective_mappings")>]
        EffectiveMappings: CoreTypes.TypeMapping option
    }


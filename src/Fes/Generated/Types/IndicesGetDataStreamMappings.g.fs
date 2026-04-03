// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesGetDataStreamMappings =

    type DataStreamMappings = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: TypesMapping.TypeMapping
        [<System.Text.Json.Serialization.JsonPropertyName("effective_mappings")>]
        EffectiveMappings: TypesMapping.TypeMapping
    }


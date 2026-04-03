// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesGetMapping =

    type IndexMappingRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("item")>]
        Item: TypesMapping.TypeMapping option
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: TypesMapping.TypeMapping
    }


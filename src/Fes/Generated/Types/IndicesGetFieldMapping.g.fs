// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesGetFieldMapping =

    type TypeFieldMappings = {
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: Map<Types.Field, TypesMapping.FieldMapping>
    }


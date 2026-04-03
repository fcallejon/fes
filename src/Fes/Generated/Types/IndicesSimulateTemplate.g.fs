// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesSimulateTemplate =

    type Overlapping = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("index_patterns")>]
        IndexPatterns: string list
    }

    type Template = {
        [<System.Text.Json.Serialization.JsonPropertyName("aliases")>]
        Aliases: Map<Types.IndexName, IndicesTypes.Alias>
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: TypesMapping.TypeMapping
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: IndicesTypes.IndexSettings
    }


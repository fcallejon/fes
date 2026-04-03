// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatTemplates =

    type TemplatesRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("index_patterns")>]
        IndexPatterns: string option
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: string option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionString option option
        [<System.Text.Json.Serialization.JsonPropertyName("composed_of")>]
        ComposedOf: string option
    }


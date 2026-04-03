// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesGetIndexTemplate =

    type IndexTemplateItem = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("index_template")>]
        IndexTemplate: IndicesTypes.IndexTemplateWithRollover
    }


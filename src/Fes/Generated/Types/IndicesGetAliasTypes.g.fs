// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesGetAliasTypes =

    type IndexAliases = {
        [<System.Text.Json.Serialization.JsonPropertyName("aliases")>]
        Aliases: Map<string, IndicesTypes.AliasDefinition>
    }

    type NotFoundAliases = {
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: string
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: CoreTypes.Integer
    }


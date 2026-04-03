// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesValidateQuery =

    type IndicesValidationExplanation = {
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: string option
        [<System.Text.Json.Serialization.JsonPropertyName("explanation")>]
        Explanation: string option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("shard")>]
        Shard: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("valid")>]
        Valid: bool
    }


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalExplain =

    type ExplanationDetail = {
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: ExplanationDetail list option
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: CoreTypes.Float
    }

    type Explanation = {
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: ExplanationDetail list
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: CoreTypes.Float
    }


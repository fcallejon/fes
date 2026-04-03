// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module TextStructureTestGrokPattern =

    type MatchedField = {
        [<System.Text.Json.Serialization.JsonPropertyName("match")>]
        Match: string
        [<System.Text.Json.Serialization.JsonPropertyName("offset")>]
        Offset: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("length")>]
        Length: CoreTypes.Integer
    }

    type MatchedText = {
        [<System.Text.Json.Serialization.JsonPropertyName("matched")>]
        Matched: bool
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<string, MatchedField list> option
    }


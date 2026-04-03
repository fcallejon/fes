// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesAddBlock =

    type AddIndicesBlockStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("blocked")>]
        Blocked: bool
    }


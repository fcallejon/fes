// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalKnnSearchTypes =

    type KnnSearchQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("query_vector")>]
        QueryVector: Types.QueryVector
        [<System.Text.Json.Serialization.JsonPropertyName("k")>]
        K: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("num_candidates")>]
        NumCandidates: Types.Integer
    }


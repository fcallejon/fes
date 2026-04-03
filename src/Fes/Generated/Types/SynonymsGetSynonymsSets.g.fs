// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SynonymsGetSynonymsSets =

    type SynonymsSetItem = {
        [<System.Text.Json.Serialization.JsonPropertyName("synonyms_set")>]
        SynonymsSet: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Integer
    }


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SynonymsTypes =

    type SynonymString = string

    type SynonymRule = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("synonyms")>]
        Synonyms: SynonymsTypes.SynonymString
    }

    type SynonymRuleRead = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("synonyms")>]
        Synonyms: SynonymsTypes.SynonymString
    }

    type SynonymsUpdateResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("result")>]
        Result: Types.Result
        [<System.Text.Json.Serialization.JsonPropertyName("reload_analyzers_details")>]
        ReloadAnalyzersDetails: IndicesReloadSearchAnalyzers.ReloadResult option
    }


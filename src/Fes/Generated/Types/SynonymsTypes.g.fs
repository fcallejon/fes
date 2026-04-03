// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SynonymsTypes =

    type SynonymString = string

    type SynonymRule = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("synonyms")>]
        Synonyms: SynonymString
    }

    type SynonymRuleRead = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("synonyms")>]
        Synonyms: SynonymString
    }

    type SynonymsUpdateResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("result")>]
        Result: CoreTypes.Result
        [<System.Text.Json.Serialization.JsonPropertyName("reload_analyzers_details")>]
        ReloadAnalyzersDetails: IndicesReloadSearchAnalyzers.ReloadResult option
    }


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalGetScriptLanguages =

    type LanguageContext = {
        [<System.Text.Json.Serialization.JsonPropertyName("contexts")>]
        Contexts: string list
        [<System.Text.Json.Serialization.JsonPropertyName("language")>]
        Language: CoreTypes.ScriptLanguage
    }


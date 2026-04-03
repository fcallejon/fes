// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalMsearchTemplate =

    type TemplateConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("explain")>]
        Explain: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("profile")>]
        Profile: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: Types.ScriptSource option
    }

    [<RequireQualifiedAccess>]
    type RequestItem =
        | MultisearchHeader of GlobalMsearch.MultisearchHeader
        | TemplateConfig of GlobalMsearchTemplate.TemplateConfig


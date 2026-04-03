// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalGetScriptContext =

    type ContextMethodParam = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type ContextMethod = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("return_type")>]
        ReturnType: string
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: ContextMethodParam list
    }

    type Context = {
        [<System.Text.Json.Serialization.JsonPropertyName("methods")>]
        Methods: ContextMethod list
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
    }


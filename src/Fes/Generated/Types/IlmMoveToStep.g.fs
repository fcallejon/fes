// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IlmMoveToStep =

    type StepKey = {
        [<System.Text.Json.Serialization.JsonPropertyName("action")>]
        Action: string option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string option
        [<System.Text.Json.Serialization.JsonPropertyName("phase")>]
        Phase: string
    }


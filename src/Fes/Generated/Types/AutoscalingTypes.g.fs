// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module AutoscalingTypes =

    type AutoscalingPolicy = {
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: string list
        [<System.Text.Json.Serialization.JsonPropertyName("deciders")>]
        Deciders: Map<string, System.Text.Json.JsonElement>
    }


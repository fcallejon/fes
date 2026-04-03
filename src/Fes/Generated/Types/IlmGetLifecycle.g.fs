// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IlmGetLifecycle =

    type Lifecycle = {
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date")>]
        ModifiedDate: Types.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("policy")>]
        Policy: IlmTypes.Policy
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionNumber
    }


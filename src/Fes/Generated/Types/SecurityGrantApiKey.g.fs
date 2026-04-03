// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SecurityGrantApiKey =

    [<RequireQualifiedAccess>]
    type ApiKeyGrantType =
        | AccessToken
        | Password

    type GrantApiKey = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("expiration")>]
        Expiration: Types.DurationLarge option
        [<System.Text.Json.Serialization.JsonPropertyName("role_descriptors")>]
        RoleDescriptors: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: Types.Metadata option
    }


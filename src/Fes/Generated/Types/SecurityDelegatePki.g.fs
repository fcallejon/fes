// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SecurityDelegatePki =

    type AuthenticationRealm = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("domain")>]
        Domain: string option
    }

    type Authentication = {
        [<System.Text.Json.Serialization.JsonPropertyName("username")>]
        Username: string
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: string list
        [<System.Text.Json.Serialization.JsonPropertyName("full_name")>]
        FullName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("email")>]
        Email: string option
        [<System.Text.Json.Serialization.JsonPropertyName("token")>]
        Token: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: CoreTypes.Metadata
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
        [<System.Text.Json.Serialization.JsonPropertyName("authentication_realm")>]
        AuthenticationRealm: AuthenticationRealm
        [<System.Text.Json.Serialization.JsonPropertyName("lookup_realm")>]
        LookupRealm: AuthenticationRealm
        [<System.Text.Json.Serialization.JsonPropertyName("authentication_type")>]
        AuthenticationType: string
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: Map<string, string> option
    }


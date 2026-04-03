// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SecurityGetToken =

    [<RequireQualifiedAccess>]
    type AccessTokenGrantType =
        | Password
        | ClientCredentials
        | Kerberos
        | RefreshToken

    type UserRealm = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type AuthenticationProvider = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
    }

    type AuthenticatedUser = {
        [<System.Text.Json.Serialization.JsonPropertyName("authentication_realm")>]
        AuthenticationRealm: UserRealm
        [<System.Text.Json.Serialization.JsonPropertyName("lookup_realm")>]
        LookupRealm: UserRealm
        [<System.Text.Json.Serialization.JsonPropertyName("authentication_provider")>]
        AuthenticationProvider: AuthenticationProvider option
        [<System.Text.Json.Serialization.JsonPropertyName("authentication_type")>]
        AuthenticationType: string
    }


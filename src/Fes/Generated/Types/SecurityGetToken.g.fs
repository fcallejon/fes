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
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type AuthenticationProvider = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
    }

    type AuthenticatedUser = {
        [<System.Text.Json.Serialization.JsonPropertyName("authentication_realm")>]
        AuthenticationRealm: SecurityGetToken.UserRealm
        [<System.Text.Json.Serialization.JsonPropertyName("lookup_realm")>]
        LookupRealm: SecurityGetToken.UserRealm
        [<System.Text.Json.Serialization.JsonPropertyName("authentication_provider")>]
        AuthenticationProvider: SecurityGetToken.AuthenticationProvider option
        [<System.Text.Json.Serialization.JsonPropertyName("authentication_type")>]
        AuthenticationType: string
    }


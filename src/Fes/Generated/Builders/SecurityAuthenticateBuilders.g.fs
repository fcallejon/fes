// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module SecurityAuthenticateBuilders =

    type AuthenticateApiKeyBuilder() =
        member _.Yield(_: unit) : AuthenticateApiKey =
            {
                Id = Unchecked.defaultof<_>
                Name = None
                ManagedBy = Unchecked.defaultof<_>
                Internal = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: AuthenticateApiKey, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("name")>]
        member _.Name(state: AuthenticateApiKey, value: Types.Name) =
            { state with Name = Some value }

        [<CustomOperation("managedBy")>]
        member _.ManagedBy(state: AuthenticateApiKey, value: SecurityTypes.ApiKeyManagedBy) =
            { state with ManagedBy = value }

        [<CustomOperation("internal'")>]
        member _.Internal(state: AuthenticateApiKey, value: bool) =
            { state with Internal = Some value }

    let authenticateApiKey = AuthenticateApiKeyBuilder()


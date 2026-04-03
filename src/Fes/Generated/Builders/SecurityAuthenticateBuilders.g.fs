// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module SecurityAuthenticateBuilders =

    type AuthenticateApiKeyBuilder() =
        member _.Yield(_: unit) : Types.AuthenticateApiKey =
            {
                Id = Unchecked.defaultof<_>
                Name = None
                ManagedBy = Unchecked.defaultof<_>
                Internal = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.AuthenticateApiKey, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("name")>]
        member _.Name(state: Types.AuthenticateApiKey, value: Types.Name) =
            { state with Name = Some value }

        [<CustomOperation("managedBy")>]
        member _.ManagedBy(state: Types.AuthenticateApiKey, value: Types.ApiKeyManagedBy) =
            { state with ManagedBy = value }

        [<CustomOperation("internal'")>]
        member _.Internal(state: Types.AuthenticateApiKey, value: bool) =
            { state with Internal = Some value }

    let authenticateApiKey = AuthenticateApiKeyBuilder()


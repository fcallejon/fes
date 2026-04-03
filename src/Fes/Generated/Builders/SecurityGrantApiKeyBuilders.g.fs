// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module SecurityGrantApiKeyBuilders =

    type GrantApiKeyBuilder() =
        member _.Yield(_: unit) : GrantApiKey =
            {
                Name = Unchecked.defaultof<_>
                Expiration = None
                RoleDescriptors = None
                Metadata = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: GrantApiKey, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("expiration")>]
        member _.Expiration(state: GrantApiKey, value: Types.DurationLarge) =
            { state with Expiration = Some value }

        [<CustomOperation("roleDescriptors")>]
        member _.RoleDescriptors(state: GrantApiKey, value: System.Text.Json.JsonElement) =
            { state with RoleDescriptors = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: GrantApiKey, value: Types.Metadata) =
            { state with Metadata = Some value }

    let grantApiKey = GrantApiKeyBuilder()


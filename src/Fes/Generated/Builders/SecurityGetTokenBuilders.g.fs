// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module SecurityGetTokenBuilders =

    type AuthenticatedUserBuilder() =
        member _.Yield(_: unit) : Types.AuthenticatedUser =
            {
                AuthenticationRealm = Unchecked.defaultof<_>
                LookupRealm = Unchecked.defaultof<_>
                AuthenticationProvider = None
                AuthenticationType = Unchecked.defaultof<_>
                Email = None
                FullName = None
                Metadata = Unchecked.defaultof<_>
                Roles = Unchecked.defaultof<_>
                Username = Unchecked.defaultof<_>
                Enabled = Unchecked.defaultof<_>
                ProfileUid = None
            }

        [<CustomOperation("authenticationRealm")>]
        member _.AuthenticationRealm(state: Types.AuthenticatedUser, value: Types.UserRealm) =
            { state with AuthenticationRealm = value }

        [<CustomOperation("lookupRealm")>]
        member _.LookupRealm(state: Types.AuthenticatedUser, value: Types.UserRealm) =
            { state with LookupRealm = value }

        [<CustomOperation("authenticationProvider")>]
        member _.AuthenticationProvider(state: Types.AuthenticatedUser, value: Types.AuthenticationProvider) =
            { state with AuthenticationProvider = Some value }

        [<CustomOperation("authenticationType")>]
        member _.AuthenticationType(state: Types.AuthenticatedUser, value: string) =
            { state with AuthenticationType = value }

        [<CustomOperation("email")>]
        member _.Email(state: Types.AuthenticatedUser, value: string option) =
            { state with Email = Some value }

        [<CustomOperation("fullName")>]
        member _.FullName(state: Types.AuthenticatedUser, value: Types.Name option) =
            { state with FullName = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: Types.AuthenticatedUser, value: Types.Metadata) =
            { state with Metadata = value }

        [<CustomOperation("roles")>]
        member _.Roles(state: Types.AuthenticatedUser, value: string list) =
            { state with Roles = value }

        [<CustomOperation("username")>]
        member _.Username(state: Types.AuthenticatedUser, value: Types.Username) =
            { state with Username = value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.AuthenticatedUser, value: bool) =
            { state with Enabled = value }

        [<CustomOperation("profileUid")>]
        member _.ProfileUid(state: Types.AuthenticatedUser, value: Types.UserProfileId) =
            { state with ProfileUid = Some value }

    let authenticatedUser = AuthenticatedUserBuilder()


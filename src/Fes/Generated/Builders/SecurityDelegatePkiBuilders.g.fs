// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module SecurityDelegatePkiBuilders =

    type AuthenticationBuilder() =
        member _.Yield(_: unit) : Authentication =
            {
                Username = Unchecked.defaultof<_>
                Roles = Unchecked.defaultof<_>
                FullName = Unchecked.defaultof<_>
                Email = Unchecked.defaultof<_>
                Token = None
                Metadata = Unchecked.defaultof<_>
                Enabled = Unchecked.defaultof<_>
                AuthenticationRealm = Unchecked.defaultof<_>
                LookupRealm = Unchecked.defaultof<_>
                AuthenticationType = Unchecked.defaultof<_>
                ApiKey = None
            }

        [<CustomOperation("username")>]
        member _.Username(state: Authentication, value: string) =
            { state with Username = value }

        [<CustomOperation("roles")>]
        member _.Roles(state: Authentication, value: string list) =
            { state with Roles = value }

        [<CustomOperation("fullName")>]
        member _.FullName(state: Authentication, value: string option) =
            { state with FullName = value }

        [<CustomOperation("email")>]
        member _.Email(state: Authentication, value: string option) =
            { state with Email = value }

        [<CustomOperation("token")>]
        member _.Token(state: Authentication, value: Map<string, string>) =
            { state with Token = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: Authentication, value: Types.Metadata) =
            { state with Metadata = value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Authentication, value: bool) =
            { state with Enabled = value }

        [<CustomOperation("authenticationRealm")>]
        member _.AuthenticationRealm(state: Authentication, value: SecurityDelegatePki.AuthenticationRealm) =
            { state with AuthenticationRealm = value }

        [<CustomOperation("lookupRealm")>]
        member _.LookupRealm(state: Authentication, value: SecurityDelegatePki.AuthenticationRealm) =
            { state with LookupRealm = value }

        [<CustomOperation("authenticationType")>]
        member _.AuthenticationType(state: Authentication, value: string) =
            { state with AuthenticationType = value }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: Authentication, value: Map<string, string>) =
            { state with ApiKey = Some value }

    let authentication = AuthenticationBuilder()


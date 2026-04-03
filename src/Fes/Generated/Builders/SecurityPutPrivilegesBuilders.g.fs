// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module SecurityPutPrivilegesBuilders =

    type SecurityPutPrivilegesActionsBuilder() =
        member _.Yield(_: unit) : Types.SecurityPutPrivilegesActions =
            {
                Actions = Unchecked.defaultof<_>
                Application = None
                Name = None
                Metadata = None
            }

        [<CustomOperation("actions")>]
        member _.Actions(state: Types.SecurityPutPrivilegesActions, value: string list) =
            { state with Actions = value }

        [<CustomOperation("application")>]
        member _.Application(state: Types.SecurityPutPrivilegesActions, value: string) =
            { state with Application = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Types.SecurityPutPrivilegesActions, value: Types.Name) =
            { state with Name = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: Types.SecurityPutPrivilegesActions, value: Types.Metadata) =
            { state with Metadata = Some value }

    let securityPutPrivilegesActions = SecurityPutPrivilegesActionsBuilder()


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module SecurityPutPrivilegesBuilders =

    type ActionsBuilder() =
        member _.Yield(_: unit) : Actions =
            {
                Actions = Unchecked.defaultof<_>
                Application = None
                Name = None
                Metadata = None
            }

        [<CustomOperation("actions")>]
        member _.Actions(state: Actions, value: string list) =
            { state with Actions = value }

        [<CustomOperation("application")>]
        member _.Application(state: Actions, value: string) =
            { state with Application = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Actions, value: CoreTypes.Name) =
            { state with Name = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: Actions, value: CoreTypes.Metadata) =
            { state with Metadata = Some value }

    let actions = ActionsBuilder()


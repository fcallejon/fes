// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module SnapshotGetBuilders =

    type SnapshotResponseItemBuilder() =
        member _.Yield(_: unit) : SnapshotResponseItem =
            {
                Repository = Unchecked.defaultof<_>
                Snapshots = None
                Error = None
            }

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotResponseItem, value: CoreTypes.Name) =
            { state with Repository = value }

        [<CustomOperation("snapshots")>]
        member _.Snapshots(state: SnapshotResponseItem, value: SnapshotTypes.SnapshotInfo list) =
            { state with Snapshots = Some value }

        [<CustomOperation("error")>]
        member _.Error(state: SnapshotResponseItem, value: CoreTypes.ErrorCause) =
            { state with Error = Some value }

    let snapshotResponseItem = SnapshotResponseItemBuilder()


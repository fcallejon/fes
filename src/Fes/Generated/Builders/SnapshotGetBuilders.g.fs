// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module SnapshotGetBuilders =

    type SnapshotResponseItemBuilder() =
        member _.Yield(_: unit) : Types.SnapshotResponseItem =
            {
                Repository = Unchecked.defaultof<_>
                Snapshots = None
                Error = None
            }

        [<CustomOperation("repository")>]
        member _.Repository(state: Types.SnapshotResponseItem, value: Types.Name) =
            { state with Repository = value }

        [<CustomOperation("snapshots")>]
        member _.Snapshots(state: Types.SnapshotResponseItem, value: Types.SnapshotInfo list) =
            { state with Snapshots = Some value }

        [<CustomOperation("error")>]
        member _.Error(state: Types.SnapshotResponseItem, value: Types.ErrorCause) =
            { state with Error = Some value }

    let snapshotResponseItem = SnapshotResponseItemBuilder()


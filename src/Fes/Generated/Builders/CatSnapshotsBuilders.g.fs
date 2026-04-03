// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module CatSnapshotsBuilders =

    type SnapshotsRecordBuilder() =
        member _.Yield(_: unit) : SnapshotsRecord =
            {
                Id = None
                Repository = None
                Status = None
                StartEpoch = None
                StartTime = None
                EndEpoch = None
                EndTime = None
                Duration = None
                Indices = None
                SuccessfulShards = None
                FailedShards = None
                TotalShards = None
                Reason = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: SnapshotsRecord, value: string) =
            { state with Id = Some value }

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotsRecord, value: string) =
            { state with Repository = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: SnapshotsRecord, value: string) =
            { state with Status = Some value }

        [<CustomOperation("startEpoch")>]
        member _.StartEpoch(state: SnapshotsRecord, value: CoreTypes.Stringified<CoreTypes.EpochTime<CoreTypes.UnitSeconds>>) =
            { state with StartEpoch = Some value }

        [<CustomOperation("startTime")>]
        member _.StartTime(state: SnapshotsRecord, value: WatcherTypes.ScheduleTimeOfDay) =
            { state with StartTime = Some value }

        [<CustomOperation("endEpoch")>]
        member _.EndEpoch(state: SnapshotsRecord, value: CoreTypes.Stringified<CoreTypes.EpochTime<CoreTypes.UnitSeconds>>) =
            { state with EndEpoch = Some value }

        [<CustomOperation("endTime")>]
        member _.EndTime(state: SnapshotsRecord, value: CoreTypes.TimeOfDay) =
            { state with EndTime = Some value }

        [<CustomOperation("duration")>]
        member _.Duration(state: SnapshotsRecord, value: CoreTypes.Duration) =
            { state with Duration = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: SnapshotsRecord, value: string) =
            { state with Indices = Some value }

        [<CustomOperation("successfulShards")>]
        member _.SuccessfulShards(state: SnapshotsRecord, value: string) =
            { state with SuccessfulShards = Some value }

        [<CustomOperation("failedShards")>]
        member _.FailedShards(state: SnapshotsRecord, value: string) =
            { state with FailedShards = Some value }

        [<CustomOperation("totalShards")>]
        member _.TotalShards(state: SnapshotsRecord, value: string) =
            { state with TotalShards = Some value }

        [<CustomOperation("reason")>]
        member _.Reason(state: SnapshotsRecord, value: string) =
            { state with Reason = Some value }

    let snapshotsRecord = SnapshotsRecordBuilder()


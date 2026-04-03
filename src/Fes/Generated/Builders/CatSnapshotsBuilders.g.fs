// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module CatSnapshotsBuilders =

    type SnapshotsRecordBuilder() =
        member _.Yield(_: unit) : Types.SnapshotsRecord =
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
        member _.Id(state: Types.SnapshotsRecord, value: string) =
            { state with Id = Some value }

        [<CustomOperation("repository")>]
        member _.Repository(state: Types.SnapshotsRecord, value: string) =
            { state with Repository = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.SnapshotsRecord, value: string) =
            { state with Status = Some value }

        [<CustomOperation("startEpoch")>]
        member _.StartEpoch(state: Types.SnapshotsRecord, value: Types.Stringified<Types.EpochTime<Types.UnitSeconds>>) =
            { state with StartEpoch = Some value }

        [<CustomOperation("startTime")>]
        member _.StartTime(state: Types.SnapshotsRecord, value: Types.ScheduleTimeOfDay) =
            { state with StartTime = Some value }

        [<CustomOperation("endEpoch")>]
        member _.EndEpoch(state: Types.SnapshotsRecord, value: Types.Stringified<Types.EpochTime<Types.UnitSeconds>>) =
            { state with EndEpoch = Some value }

        [<CustomOperation("endTime")>]
        member _.EndTime(state: Types.SnapshotsRecord, value: Types.TimeOfDay) =
            { state with EndTime = Some value }

        [<CustomOperation("duration")>]
        member _.Duration(state: Types.SnapshotsRecord, value: Types.Duration) =
            { state with Duration = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.SnapshotsRecord, value: string) =
            { state with Indices = Some value }

        [<CustomOperation("successfulShards")>]
        member _.SuccessfulShards(state: Types.SnapshotsRecord, value: string) =
            { state with SuccessfulShards = Some value }

        [<CustomOperation("failedShards")>]
        member _.FailedShards(state: Types.SnapshotsRecord, value: string) =
            { state with FailedShards = Some value }

        [<CustomOperation("totalShards")>]
        member _.TotalShards(state: Types.SnapshotsRecord, value: string) =
            { state with TotalShards = Some value }

        [<CustomOperation("reason")>]
        member _.Reason(state: Types.SnapshotsRecord, value: string) =
            { state with Reason = Some value }

    let snapshotsRecord = SnapshotsRecordBuilder()


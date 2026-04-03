// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module CatRecoveryBuilders =

    type RecoveryRecordBuilder() =
        member _.Yield(_: unit) : Types.RecoveryRecord =
            {
                Index = None
                Shard = None
                StartTime = None
                StartTimeMillis = None
                StopTime = None
                StopTimeMillis = None
                Time = None
                Type = None
                Stage = None
                SourceHost = None
                SourceNode = None
                TargetHost = None
                TargetNode = None
                Repository = None
                Snapshot = None
                Files = None
                FilesRecovered = None
                FilesPercent = None
                FilesTotal = None
                Bytes = None
                BytesRecovered = None
                BytesPercent = None
                BytesTotal = None
                TranslogOps = None
                TranslogOpsRecovered = None
                TranslogOpsPercent = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: Types.RecoveryRecord, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("shard")>]
        member _.Shard(state: Types.RecoveryRecord, value: string) =
            { state with Shard = Some value }

        [<CustomOperation("startTime")>]
        member _.StartTime(state: Types.RecoveryRecord, value: Types.DateTime) =
            { state with StartTime = Some value }

        [<CustomOperation("startTimeMillis")>]
        member _.StartTimeMillis(state: Types.RecoveryRecord, value: Types.EpochTime<Types.UnitMillis>) =
            { state with StartTimeMillis = Some value }

        [<CustomOperation("stopTime")>]
        member _.StopTime(state: Types.RecoveryRecord, value: Types.DateTime) =
            { state with StopTime = Some value }

        [<CustomOperation("stopTimeMillis")>]
        member _.StopTimeMillis(state: Types.RecoveryRecord, value: Types.EpochTime<Types.UnitMillis>) =
            { state with StopTimeMillis = Some value }

        [<CustomOperation("time")>]
        member _.Time(state: Types.RecoveryRecord, value: Types.Duration) =
            { state with Time = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.RecoveryRecord, value: string) =
            { state with Type = Some value }

        [<CustomOperation("stage")>]
        member _.Stage(state: Types.RecoveryRecord, value: string) =
            { state with Stage = Some value }

        [<CustomOperation("sourceHost")>]
        member _.SourceHost(state: Types.RecoveryRecord, value: string) =
            { state with SourceHost = Some value }

        [<CustomOperation("sourceNode")>]
        member _.SourceNode(state: Types.RecoveryRecord, value: string) =
            { state with SourceNode = Some value }

        [<CustomOperation("targetHost")>]
        member _.TargetHost(state: Types.RecoveryRecord, value: string) =
            { state with TargetHost = Some value }

        [<CustomOperation("targetNode")>]
        member _.TargetNode(state: Types.RecoveryRecord, value: string) =
            { state with TargetNode = Some value }

        [<CustomOperation("repository")>]
        member _.Repository(state: Types.RecoveryRecord, value: string) =
            { state with Repository = Some value }

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: Types.RecoveryRecord, value: string) =
            { state with Snapshot = Some value }

        [<CustomOperation("files")>]
        member _.Files(state: Types.RecoveryRecord, value: string) =
            { state with Files = Some value }

        [<CustomOperation("filesRecovered")>]
        member _.FilesRecovered(state: Types.RecoveryRecord, value: string) =
            { state with FilesRecovered = Some value }

        [<CustomOperation("filesPercent")>]
        member _.FilesPercent(state: Types.RecoveryRecord, value: Types.Percentage) =
            { state with FilesPercent = Some value }

        [<CustomOperation("filesTotal")>]
        member _.FilesTotal(state: Types.RecoveryRecord, value: string) =
            { state with FilesTotal = Some value }

        [<CustomOperation("bytes")>]
        member _.Bytes(state: Types.RecoveryRecord, value: string) =
            { state with Bytes = Some value }

        [<CustomOperation("bytesRecovered")>]
        member _.BytesRecovered(state: Types.RecoveryRecord, value: string) =
            { state with BytesRecovered = Some value }

        [<CustomOperation("bytesPercent")>]
        member _.BytesPercent(state: Types.RecoveryRecord, value: Types.Percentage) =
            { state with BytesPercent = Some value }

        [<CustomOperation("bytesTotal")>]
        member _.BytesTotal(state: Types.RecoveryRecord, value: string) =
            { state with BytesTotal = Some value }

        [<CustomOperation("translogOps")>]
        member _.TranslogOps(state: Types.RecoveryRecord, value: string) =
            { state with TranslogOps = Some value }

        [<CustomOperation("translogOpsRecovered")>]
        member _.TranslogOpsRecovered(state: Types.RecoveryRecord, value: string) =
            { state with TranslogOpsRecovered = Some value }

        [<CustomOperation("translogOpsPercent")>]
        member _.TranslogOpsPercent(state: Types.RecoveryRecord, value: Types.Percentage) =
            { state with TranslogOpsPercent = Some value }

    let recoveryRecord = RecoveryRecordBuilder()


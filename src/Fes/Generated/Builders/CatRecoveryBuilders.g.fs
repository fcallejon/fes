// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module CatRecoveryBuilders =

    type RecoveryRecordBuilder() =
        member _.Yield(_: unit) : RecoveryRecord =
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
        member _.Index(state: RecoveryRecord, value: CoreTypes.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("shard")>]
        member _.Shard(state: RecoveryRecord, value: string) =
            { state with Shard = Some value }

        [<CustomOperation("startTime")>]
        member _.StartTime(state: RecoveryRecord, value: CoreTypes.DateTime) =
            { state with StartTime = Some value }

        [<CustomOperation("startTimeMillis")>]
        member _.StartTimeMillis(state: RecoveryRecord, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with StartTimeMillis = Some value }

        [<CustomOperation("stopTime")>]
        member _.StopTime(state: RecoveryRecord, value: CoreTypes.DateTime) =
            { state with StopTime = Some value }

        [<CustomOperation("stopTimeMillis")>]
        member _.StopTimeMillis(state: RecoveryRecord, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with StopTimeMillis = Some value }

        [<CustomOperation("time")>]
        member _.Time(state: RecoveryRecord, value: CoreTypes.Duration) =
            { state with Time = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: RecoveryRecord, value: string) =
            { state with Type = Some value }

        [<CustomOperation("stage")>]
        member _.Stage(state: RecoveryRecord, value: string) =
            { state with Stage = Some value }

        [<CustomOperation("sourceHost")>]
        member _.SourceHost(state: RecoveryRecord, value: string) =
            { state with SourceHost = Some value }

        [<CustomOperation("sourceNode")>]
        member _.SourceNode(state: RecoveryRecord, value: string) =
            { state with SourceNode = Some value }

        [<CustomOperation("targetHost")>]
        member _.TargetHost(state: RecoveryRecord, value: string) =
            { state with TargetHost = Some value }

        [<CustomOperation("targetNode")>]
        member _.TargetNode(state: RecoveryRecord, value: string) =
            { state with TargetNode = Some value }

        [<CustomOperation("repository")>]
        member _.Repository(state: RecoveryRecord, value: string) =
            { state with Repository = Some value }

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: RecoveryRecord, value: string) =
            { state with Snapshot = Some value }

        [<CustomOperation("files")>]
        member _.Files(state: RecoveryRecord, value: string) =
            { state with Files = Some value }

        [<CustomOperation("filesRecovered")>]
        member _.FilesRecovered(state: RecoveryRecord, value: string) =
            { state with FilesRecovered = Some value }

        [<CustomOperation("filesPercent")>]
        member _.FilesPercent(state: RecoveryRecord, value: CoreTypes.Percentage) =
            { state with FilesPercent = Some value }

        [<CustomOperation("filesTotal")>]
        member _.FilesTotal(state: RecoveryRecord, value: string) =
            { state with FilesTotal = Some value }

        [<CustomOperation("bytes")>]
        member _.Bytes(state: RecoveryRecord, value: string) =
            { state with Bytes = Some value }

        [<CustomOperation("bytesRecovered")>]
        member _.BytesRecovered(state: RecoveryRecord, value: string) =
            { state with BytesRecovered = Some value }

        [<CustomOperation("bytesPercent")>]
        member _.BytesPercent(state: RecoveryRecord, value: CoreTypes.Percentage) =
            { state with BytesPercent = Some value }

        [<CustomOperation("bytesTotal")>]
        member _.BytesTotal(state: RecoveryRecord, value: string) =
            { state with BytesTotal = Some value }

        [<CustomOperation("translogOps")>]
        member _.TranslogOps(state: RecoveryRecord, value: string) =
            { state with TranslogOps = Some value }

        [<CustomOperation("translogOpsRecovered")>]
        member _.TranslogOpsRecovered(state: RecoveryRecord, value: string) =
            { state with TranslogOpsRecovered = Some value }

        [<CustomOperation("translogOpsPercent")>]
        member _.TranslogOpsPercent(state: RecoveryRecord, value: CoreTypes.Percentage) =
            { state with TranslogOpsPercent = Some value }

    let recoveryRecord = RecoveryRecordBuilder()


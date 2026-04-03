// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module IndicesRecoveryBuilders =

    type RecoveryBytesBuilder() =
        member _.Yield(_: unit) : RecoveryBytes =
            {
                Percent = Unchecked.defaultof<_>
                Recovered = None
                RecoveredInBytes = Unchecked.defaultof<_>
                RecoveredFromSnapshot = None
                RecoveredFromSnapshotInBytes = None
                Reused = None
                ReusedInBytes = Unchecked.defaultof<_>
                Total = None
                TotalInBytes = Unchecked.defaultof<_>
            }

        [<CustomOperation("percent")>]
        member _.Percent(state: RecoveryBytes, value: CoreTypes.Percentage) =
            { state with Percent = value }

        [<CustomOperation("recovered")>]
        member _.Recovered(state: RecoveryBytes, value: CoreTypes.ByteSize) =
            { state with Recovered = Some value }

        [<CustomOperation("recoveredInBytes")>]
        member _.RecoveredInBytes(state: RecoveryBytes, value: CoreTypes.ByteSize) =
            { state with RecoveredInBytes = value }

        [<CustomOperation("recoveredFromSnapshot")>]
        member _.RecoveredFromSnapshot(state: RecoveryBytes, value: CoreTypes.ByteSize) =
            { state with RecoveredFromSnapshot = Some value }

        [<CustomOperation("recoveredFromSnapshotInBytes")>]
        member _.RecoveredFromSnapshotInBytes(state: RecoveryBytes, value: CoreTypes.ByteSize) =
            { state with RecoveredFromSnapshotInBytes = Some value }

        [<CustomOperation("reused")>]
        member _.Reused(state: RecoveryBytes, value: CoreTypes.ByteSize) =
            { state with Reused = Some value }

        [<CustomOperation("reusedInBytes")>]
        member _.ReusedInBytes(state: RecoveryBytes, value: CoreTypes.ByteSize) =
            { state with ReusedInBytes = value }

        [<CustomOperation("total")>]
        member _.Total(state: RecoveryBytes, value: CoreTypes.ByteSize) =
            { state with Total = Some value }

        [<CustomOperation("totalInBytes")>]
        member _.TotalInBytes(state: RecoveryBytes, value: CoreTypes.ByteSize) =
            { state with TotalInBytes = value }

    let recoveryBytes = RecoveryBytesBuilder()

    type RecoveryIndexStatusBuilder() =
        member _.Yield(_: unit) : RecoveryIndexStatus =
            {
                Bytes = None
                Files = Unchecked.defaultof<_>
                Size = Unchecked.defaultof<_>
                SourceThrottleTime = None
                SourceThrottleTimeInMillis = Unchecked.defaultof<_>
                TargetThrottleTime = None
                TargetThrottleTimeInMillis = Unchecked.defaultof<_>
                TotalTime = None
                TotalTimeInMillis = Unchecked.defaultof<_>
            }

        [<CustomOperation("bytes")>]
        member _.Bytes(state: RecoveryIndexStatus, value: IndicesRecovery.RecoveryBytes) =
            { state with Bytes = Some value }

        [<CustomOperation("files")>]
        member _.Files(state: RecoveryIndexStatus, value: IndicesRecovery.RecoveryFiles) =
            { state with Files = value }

        [<CustomOperation("size")>]
        member _.Size(state: RecoveryIndexStatus, value: IndicesRecovery.RecoveryBytes) =
            { state with Size = value }

        [<CustomOperation("sourceThrottleTime")>]
        member _.SourceThrottleTime(state: RecoveryIndexStatus, value: CoreTypes.Duration) =
            { state with SourceThrottleTime = Some value }

        [<CustomOperation("sourceThrottleTimeInMillis")>]
        member _.SourceThrottleTimeInMillis(state: RecoveryIndexStatus, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with SourceThrottleTimeInMillis = value }

        [<CustomOperation("targetThrottleTime")>]
        member _.TargetThrottleTime(state: RecoveryIndexStatus, value: CoreTypes.Duration) =
            { state with TargetThrottleTime = Some value }

        [<CustomOperation("targetThrottleTimeInMillis")>]
        member _.TargetThrottleTimeInMillis(state: RecoveryIndexStatus, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with TargetThrottleTimeInMillis = value }

        [<CustomOperation("totalTime")>]
        member _.TotalTime(state: RecoveryIndexStatus, value: CoreTypes.Duration) =
            { state with TotalTime = Some value }

        [<CustomOperation("totalTimeInMillis")>]
        member _.TotalTimeInMillis(state: RecoveryIndexStatus, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with TotalTimeInMillis = value }

    let recoveryIndexStatus = RecoveryIndexStatusBuilder()

    type RecoveryOriginBuilder() =
        member _.Yield(_: unit) : RecoveryOrigin =
            {
                Hostname = None
                Host = None
                TransportAddress = None
                Id = None
                Ip = None
                Name = None
                BootstrapNewHistoryUuid = None
                Repository = None
                Snapshot = None
                Version = None
                RestoreUUID = None
                Index = None
            }

        [<CustomOperation("hostname")>]
        member _.Hostname(state: RecoveryOrigin, value: string) =
            { state with Hostname = Some value }

        [<CustomOperation("host")>]
        member _.Host(state: RecoveryOrigin, value: CoreTypes.Host) =
            { state with Host = Some value }

        [<CustomOperation("transportAddress")>]
        member _.TransportAddress(state: RecoveryOrigin, value: CoreTypes.TransportAddress) =
            { state with TransportAddress = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: RecoveryOrigin, value: CoreTypes.Id) =
            { state with Id = Some value }

        [<CustomOperation("ip")>]
        member _.Ip(state: RecoveryOrigin, value: CoreTypes.Ip) =
            { state with Ip = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: RecoveryOrigin, value: CoreTypes.Name) =
            { state with Name = Some value }

        [<CustomOperation("bootstrapNewHistoryUuid")>]
        member _.BootstrapNewHistoryUuid(state: RecoveryOrigin, value: bool) =
            { state with BootstrapNewHistoryUuid = Some value }

        [<CustomOperation("repository")>]
        member _.Repository(state: RecoveryOrigin, value: CoreTypes.Name) =
            { state with Repository = Some value }

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: RecoveryOrigin, value: CoreTypes.Name) =
            { state with Snapshot = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: RecoveryOrigin, value: CoreTypes.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("restoreUUID")>]
        member _.RestoreUUID(state: RecoveryOrigin, value: CoreTypes.Uuid) =
            { state with RestoreUUID = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: RecoveryOrigin, value: CoreTypes.IndexName) =
            { state with Index = Some value }

    let recoveryOrigin = RecoveryOriginBuilder()

    type RecoveryStartStatusBuilder() =
        member _.Yield(_: unit) : RecoveryStartStatus =
            {
                CheckIndexTime = None
                CheckIndexTimeInMillis = Unchecked.defaultof<_>
                TotalTime = None
                TotalTimeInMillis = Unchecked.defaultof<_>
            }

        [<CustomOperation("checkIndexTime")>]
        member _.CheckIndexTime(state: RecoveryStartStatus, value: CoreTypes.Duration) =
            { state with CheckIndexTime = Some value }

        [<CustomOperation("checkIndexTimeInMillis")>]
        member _.CheckIndexTimeInMillis(state: RecoveryStartStatus, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with CheckIndexTimeInMillis = value }

        [<CustomOperation("totalTime")>]
        member _.TotalTime(state: RecoveryStartStatus, value: CoreTypes.Duration) =
            { state with TotalTime = Some value }

        [<CustomOperation("totalTimeInMillis")>]
        member _.TotalTimeInMillis(state: RecoveryStartStatus, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with TotalTimeInMillis = value }

    let recoveryStartStatus = RecoveryStartStatusBuilder()

    type ShardRecoveryBuilder() =
        member _.Yield(_: unit) : ShardRecovery =
            {
                Id = Unchecked.defaultof<_>
                Index = Unchecked.defaultof<_>
                Primary = Unchecked.defaultof<_>
                Source = Unchecked.defaultof<_>
                Stage = Unchecked.defaultof<_>
                Start = None
                StartTime = None
                StartTimeInMillis = Unchecked.defaultof<_>
                StopTime = None
                StopTimeInMillis = None
                Target = Unchecked.defaultof<_>
                TotalTime = None
                TotalTimeInMillis = Unchecked.defaultof<_>
                Translog = Unchecked.defaultof<_>
                Type = Unchecked.defaultof<_>
                VerifyIndex = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: ShardRecovery, value: CoreTypes.Long) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: ShardRecovery, value: IndicesRecovery.RecoveryIndexStatus) =
            { state with Index = value }

        [<CustomOperation("primary")>]
        member _.Primary(state: ShardRecovery, value: bool) =
            { state with Primary = value }

        [<CustomOperation("source")>]
        member _.Source(state: ShardRecovery, value: IndicesRecovery.RecoveryOrigin) =
            { state with Source = value }

        [<CustomOperation("stage")>]
        member _.Stage(state: ShardRecovery, value: IndicesRecovery.RecoveryStage) =
            { state with Stage = value }

        [<CustomOperation("start")>]
        member _.Start(state: ShardRecovery, value: IndicesRecovery.RecoveryStartStatus) =
            { state with Start = Some value }

        [<CustomOperation("startTime")>]
        member _.StartTime(state: ShardRecovery, value: CoreTypes.DateTime) =
            { state with StartTime = Some value }

        [<CustomOperation("startTimeInMillis")>]
        member _.StartTimeInMillis(state: ShardRecovery, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with StartTimeInMillis = value }

        [<CustomOperation("stopTime")>]
        member _.StopTime(state: ShardRecovery, value: CoreTypes.DateTime) =
            { state with StopTime = Some value }

        [<CustomOperation("stopTimeInMillis")>]
        member _.StopTimeInMillis(state: ShardRecovery, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with StopTimeInMillis = Some value }

        [<CustomOperation("target")>]
        member _.Target(state: ShardRecovery, value: IndicesRecovery.RecoveryOrigin) =
            { state with Target = value }

        [<CustomOperation("totalTime")>]
        member _.TotalTime(state: ShardRecovery, value: CoreTypes.Duration) =
            { state with TotalTime = Some value }

        [<CustomOperation("totalTimeInMillis")>]
        member _.TotalTimeInMillis(state: ShardRecovery, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with TotalTimeInMillis = value }

        [<CustomOperation("translog")>]
        member _.Translog(state: ShardRecovery, value: IndicesRecovery.TranslogStatus) =
            { state with Translog = value }

        [<CustomOperation("type'")>]
        member _.Type(state: ShardRecovery, value: IndicesRecovery.RecoveryType) =
            { state with Type = value }

        [<CustomOperation("verifyIndex")>]
        member _.VerifyIndex(state: ShardRecovery, value: IndicesRecovery.VerifyIndex) =
            { state with VerifyIndex = value }

    let shardRecovery = ShardRecoveryBuilder()

    type VerifyIndexBuilder() =
        member _.Yield(_: unit) : VerifyIndex =
            {
                CheckIndexTime = None
                CheckIndexTimeInMillis = Unchecked.defaultof<_>
                TotalTime = None
                TotalTimeInMillis = Unchecked.defaultof<_>
            }

        [<CustomOperation("checkIndexTime")>]
        member _.CheckIndexTime(state: VerifyIndex, value: CoreTypes.Duration) =
            { state with CheckIndexTime = Some value }

        [<CustomOperation("checkIndexTimeInMillis")>]
        member _.CheckIndexTimeInMillis(state: VerifyIndex, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with CheckIndexTimeInMillis = value }

        [<CustomOperation("totalTime")>]
        member _.TotalTime(state: VerifyIndex, value: CoreTypes.Duration) =
            { state with TotalTime = Some value }

        [<CustomOperation("totalTimeInMillis")>]
        member _.TotalTimeInMillis(state: VerifyIndex, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with TotalTimeInMillis = value }

    let verifyIndex = VerifyIndexBuilder()


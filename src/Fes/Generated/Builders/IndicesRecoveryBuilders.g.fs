// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module IndicesRecoveryBuilders =

    type RecoveryBytesBuilder() =
        member _.Yield(_: unit) : Types.RecoveryBytes =
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
        member _.Percent(state: Types.RecoveryBytes, value: Types.Percentage) =
            { state with Percent = value }

        [<CustomOperation("recovered")>]
        member _.Recovered(state: Types.RecoveryBytes, value: Types.ByteSize) =
            { state with Recovered = Some value }

        [<CustomOperation("recoveredInBytes")>]
        member _.RecoveredInBytes(state: Types.RecoveryBytes, value: Types.ByteSize) =
            { state with RecoveredInBytes = value }

        [<CustomOperation("recoveredFromSnapshot")>]
        member _.RecoveredFromSnapshot(state: Types.RecoveryBytes, value: Types.ByteSize) =
            { state with RecoveredFromSnapshot = Some value }

        [<CustomOperation("recoveredFromSnapshotInBytes")>]
        member _.RecoveredFromSnapshotInBytes(state: Types.RecoveryBytes, value: Types.ByteSize) =
            { state with RecoveredFromSnapshotInBytes = Some value }

        [<CustomOperation("reused")>]
        member _.Reused(state: Types.RecoveryBytes, value: Types.ByteSize) =
            { state with Reused = Some value }

        [<CustomOperation("reusedInBytes")>]
        member _.ReusedInBytes(state: Types.RecoveryBytes, value: Types.ByteSize) =
            { state with ReusedInBytes = value }

        [<CustomOperation("total")>]
        member _.Total(state: Types.RecoveryBytes, value: Types.ByteSize) =
            { state with Total = Some value }

        [<CustomOperation("totalInBytes")>]
        member _.TotalInBytes(state: Types.RecoveryBytes, value: Types.ByteSize) =
            { state with TotalInBytes = value }

    let recoveryBytes = RecoveryBytesBuilder()

    type RecoveryIndexStatusBuilder() =
        member _.Yield(_: unit) : Types.RecoveryIndexStatus =
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
        member _.Bytes(state: Types.RecoveryIndexStatus, value: Types.RecoveryBytes) =
            { state with Bytes = Some value }

        [<CustomOperation("files")>]
        member _.Files(state: Types.RecoveryIndexStatus, value: Types.RecoveryFiles) =
            { state with Files = value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.RecoveryIndexStatus, value: Types.RecoveryBytes) =
            { state with Size = value }

        [<CustomOperation("sourceThrottleTime")>]
        member _.SourceThrottleTime(state: Types.RecoveryIndexStatus, value: Types.Duration) =
            { state with SourceThrottleTime = Some value }

        [<CustomOperation("sourceThrottleTimeInMillis")>]
        member _.SourceThrottleTimeInMillis(state: Types.RecoveryIndexStatus, value: Types.DurationValue<Types.UnitMillis>) =
            { state with SourceThrottleTimeInMillis = value }

        [<CustomOperation("targetThrottleTime")>]
        member _.TargetThrottleTime(state: Types.RecoveryIndexStatus, value: Types.Duration) =
            { state with TargetThrottleTime = Some value }

        [<CustomOperation("targetThrottleTimeInMillis")>]
        member _.TargetThrottleTimeInMillis(state: Types.RecoveryIndexStatus, value: Types.DurationValue<Types.UnitMillis>) =
            { state with TargetThrottleTimeInMillis = value }

        [<CustomOperation("totalTime")>]
        member _.TotalTime(state: Types.RecoveryIndexStatus, value: Types.Duration) =
            { state with TotalTime = Some value }

        [<CustomOperation("totalTimeInMillis")>]
        member _.TotalTimeInMillis(state: Types.RecoveryIndexStatus, value: Types.DurationValue<Types.UnitMillis>) =
            { state with TotalTimeInMillis = value }

    let recoveryIndexStatus = RecoveryIndexStatusBuilder()

    type RecoveryOriginBuilder() =
        member _.Yield(_: unit) : Types.RecoveryOrigin =
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
        member _.Hostname(state: Types.RecoveryOrigin, value: string) =
            { state with Hostname = Some value }

        [<CustomOperation("host")>]
        member _.Host(state: Types.RecoveryOrigin, value: Types.Host) =
            { state with Host = Some value }

        [<CustomOperation("transportAddress")>]
        member _.TransportAddress(state: Types.RecoveryOrigin, value: Types.TransportAddress) =
            { state with TransportAddress = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: Types.RecoveryOrigin, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("ip")>]
        member _.Ip(state: Types.RecoveryOrigin, value: Types.Ip) =
            { state with Ip = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Types.RecoveryOrigin, value: Types.Name) =
            { state with Name = Some value }

        [<CustomOperation("bootstrapNewHistoryUuid")>]
        member _.BootstrapNewHistoryUuid(state: Types.RecoveryOrigin, value: bool) =
            { state with BootstrapNewHistoryUuid = Some value }

        [<CustomOperation("repository")>]
        member _.Repository(state: Types.RecoveryOrigin, value: Types.Name) =
            { state with Repository = Some value }

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: Types.RecoveryOrigin, value: Types.Name) =
            { state with Snapshot = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.RecoveryOrigin, value: Types.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("restoreUUID")>]
        member _.RestoreUUID(state: Types.RecoveryOrigin, value: Types.Uuid) =
            { state with RestoreUUID = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.RecoveryOrigin, value: Types.IndexName) =
            { state with Index = Some value }

    let recoveryOrigin = RecoveryOriginBuilder()

    type RecoveryStartStatusBuilder() =
        member _.Yield(_: unit) : Types.RecoveryStartStatus =
            {
                CheckIndexTime = None
                CheckIndexTimeInMillis = Unchecked.defaultof<_>
                TotalTime = None
                TotalTimeInMillis = Unchecked.defaultof<_>
            }

        [<CustomOperation("checkIndexTime")>]
        member _.CheckIndexTime(state: Types.RecoveryStartStatus, value: Types.Duration) =
            { state with CheckIndexTime = Some value }

        [<CustomOperation("checkIndexTimeInMillis")>]
        member _.CheckIndexTimeInMillis(state: Types.RecoveryStartStatus, value: Types.DurationValue<Types.UnitMillis>) =
            { state with CheckIndexTimeInMillis = value }

        [<CustomOperation("totalTime")>]
        member _.TotalTime(state: Types.RecoveryStartStatus, value: Types.Duration) =
            { state with TotalTime = Some value }

        [<CustomOperation("totalTimeInMillis")>]
        member _.TotalTimeInMillis(state: Types.RecoveryStartStatus, value: Types.DurationValue<Types.UnitMillis>) =
            { state with TotalTimeInMillis = value }

    let recoveryStartStatus = RecoveryStartStatusBuilder()

    type ShardRecoveryBuilder() =
        member _.Yield(_: unit) : Types.ShardRecovery =
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
        member _.Id(state: Types.ShardRecovery, value: Types.Long) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.ShardRecovery, value: Types.RecoveryIndexStatus) =
            { state with Index = value }

        [<CustomOperation("primary")>]
        member _.Primary(state: Types.ShardRecovery, value: bool) =
            { state with Primary = value }

        [<CustomOperation("source")>]
        member _.Source(state: Types.ShardRecovery, value: Types.RecoveryOrigin) =
            { state with Source = value }

        [<CustomOperation("stage")>]
        member _.Stage(state: Types.ShardRecovery, value: Types.RecoveryStage) =
            { state with Stage = value }

        [<CustomOperation("start")>]
        member _.Start(state: Types.ShardRecovery, value: Types.RecoveryStartStatus) =
            { state with Start = Some value }

        [<CustomOperation("startTime")>]
        member _.StartTime(state: Types.ShardRecovery, value: Types.DateTime) =
            { state with StartTime = Some value }

        [<CustomOperation("startTimeInMillis")>]
        member _.StartTimeInMillis(state: Types.ShardRecovery, value: Types.EpochTime<Types.UnitMillis>) =
            { state with StartTimeInMillis = value }

        [<CustomOperation("stopTime")>]
        member _.StopTime(state: Types.ShardRecovery, value: Types.DateTime) =
            { state with StopTime = Some value }

        [<CustomOperation("stopTimeInMillis")>]
        member _.StopTimeInMillis(state: Types.ShardRecovery, value: Types.EpochTime<Types.UnitMillis>) =
            { state with StopTimeInMillis = Some value }

        [<CustomOperation("target")>]
        member _.Target(state: Types.ShardRecovery, value: Types.RecoveryOrigin) =
            { state with Target = value }

        [<CustomOperation("totalTime")>]
        member _.TotalTime(state: Types.ShardRecovery, value: Types.Duration) =
            { state with TotalTime = Some value }

        [<CustomOperation("totalTimeInMillis")>]
        member _.TotalTimeInMillis(state: Types.ShardRecovery, value: Types.DurationValue<Types.UnitMillis>) =
            { state with TotalTimeInMillis = value }

        [<CustomOperation("translog")>]
        member _.Translog(state: Types.ShardRecovery, value: Types.TranslogStatus) =
            { state with Translog = value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.ShardRecovery, value: Types.RecoveryType) =
            { state with Type = value }

        [<CustomOperation("verifyIndex")>]
        member _.VerifyIndex(state: Types.ShardRecovery, value: Types.VerifyIndex) =
            { state with VerifyIndex = value }

    let shardRecovery = ShardRecoveryBuilder()

    type VerifyIndexBuilder() =
        member _.Yield(_: unit) : Types.VerifyIndex =
            {
                CheckIndexTime = None
                CheckIndexTimeInMillis = Unchecked.defaultof<_>
                TotalTime = None
                TotalTimeInMillis = Unchecked.defaultof<_>
            }

        [<CustomOperation("checkIndexTime")>]
        member _.CheckIndexTime(state: Types.VerifyIndex, value: Types.Duration) =
            { state with CheckIndexTime = Some value }

        [<CustomOperation("checkIndexTimeInMillis")>]
        member _.CheckIndexTimeInMillis(state: Types.VerifyIndex, value: Types.DurationValue<Types.UnitMillis>) =
            { state with CheckIndexTimeInMillis = value }

        [<CustomOperation("totalTime")>]
        member _.TotalTime(state: Types.VerifyIndex, value: Types.Duration) =
            { state with TotalTime = Some value }

        [<CustomOperation("totalTimeInMillis")>]
        member _.TotalTimeInMillis(state: Types.VerifyIndex, value: Types.DurationValue<Types.UnitMillis>) =
            { state with TotalTimeInMillis = value }

    let verifyIndex = VerifyIndexBuilder()


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module CcrTypesBuilders =

    type CcrTypesShardStatsBuilder() =
        member _.Yield(_: unit) : Types.CcrTypesShardStats =
            {
                BytesRead = Unchecked.defaultof<_>
                FailedReadRequests = Unchecked.defaultof<_>
                FailedWriteRequests = Unchecked.defaultof<_>
                FatalException = None
                FollowerAliasesVersion = Unchecked.defaultof<_>
                FollowerGlobalCheckpoint = Unchecked.defaultof<_>
                FollowerIndex = Unchecked.defaultof<_>
                FollowerMappingVersion = Unchecked.defaultof<_>
                FollowerMaxSeqNo = Unchecked.defaultof<_>
                FollowerSettingsVersion = Unchecked.defaultof<_>
                LastRequestedSeqNo = Unchecked.defaultof<_>
                LeaderGlobalCheckpoint = Unchecked.defaultof<_>
                LeaderIndex = Unchecked.defaultof<_>
                LeaderMaxSeqNo = Unchecked.defaultof<_>
                OperationsRead = Unchecked.defaultof<_>
                OperationsWritten = Unchecked.defaultof<_>
                OutstandingReadRequests = Unchecked.defaultof<_>
                OutstandingWriteRequests = Unchecked.defaultof<_>
                ReadExceptions = Unchecked.defaultof<_>
                RemoteCluster = Unchecked.defaultof<_>
                ShardId = Unchecked.defaultof<_>
                SuccessfulReadRequests = Unchecked.defaultof<_>
                SuccessfulWriteRequests = Unchecked.defaultof<_>
                TimeSinceLastRead = None
                TimeSinceLastReadMillis = Unchecked.defaultof<_>
                TotalReadRemoteExecTime = None
                TotalReadRemoteExecTimeMillis = Unchecked.defaultof<_>
                TotalReadTime = None
                TotalReadTimeMillis = Unchecked.defaultof<_>
                TotalWriteTime = None
                TotalWriteTimeMillis = Unchecked.defaultof<_>
                WriteBufferOperationCount = Unchecked.defaultof<_>
                WriteBufferSizeInBytes = Unchecked.defaultof<_>
            }

        [<CustomOperation("bytesRead")>]
        member _.BytesRead(state: Types.CcrTypesShardStats, value: Types.Long) =
            { state with BytesRead = value }

        [<CustomOperation("failedReadRequests")>]
        member _.FailedReadRequests(state: Types.CcrTypesShardStats, value: Types.Long) =
            { state with FailedReadRequests = value }

        [<CustomOperation("failedWriteRequests")>]
        member _.FailedWriteRequests(state: Types.CcrTypesShardStats, value: Types.Long) =
            { state with FailedWriteRequests = value }

        [<CustomOperation("fatalException")>]
        member _.FatalException(state: Types.CcrTypesShardStats, value: Types.ErrorCause) =
            { state with FatalException = Some value }

        [<CustomOperation("followerAliasesVersion")>]
        member _.FollowerAliasesVersion(state: Types.CcrTypesShardStats, value: Types.VersionNumber) =
            { state with FollowerAliasesVersion = value }

        [<CustomOperation("followerGlobalCheckpoint")>]
        member _.FollowerGlobalCheckpoint(state: Types.CcrTypesShardStats, value: Types.Long) =
            { state with FollowerGlobalCheckpoint = value }

        [<CustomOperation("followerIndex")>]
        member _.FollowerIndex(state: Types.CcrTypesShardStats, value: string) =
            { state with FollowerIndex = value }

        [<CustomOperation("followerMappingVersion")>]
        member _.FollowerMappingVersion(state: Types.CcrTypesShardStats, value: Types.VersionNumber) =
            { state with FollowerMappingVersion = value }

        [<CustomOperation("followerMaxSeqNo")>]
        member _.FollowerMaxSeqNo(state: Types.CcrTypesShardStats, value: Types.SequenceNumber) =
            { state with FollowerMaxSeqNo = value }

        [<CustomOperation("followerSettingsVersion")>]
        member _.FollowerSettingsVersion(state: Types.CcrTypesShardStats, value: Types.VersionNumber) =
            { state with FollowerSettingsVersion = value }

        [<CustomOperation("lastRequestedSeqNo")>]
        member _.LastRequestedSeqNo(state: Types.CcrTypesShardStats, value: Types.SequenceNumber) =
            { state with LastRequestedSeqNo = value }

        [<CustomOperation("leaderGlobalCheckpoint")>]
        member _.LeaderGlobalCheckpoint(state: Types.CcrTypesShardStats, value: Types.Long) =
            { state with LeaderGlobalCheckpoint = value }

        [<CustomOperation("leaderIndex")>]
        member _.LeaderIndex(state: Types.CcrTypesShardStats, value: string) =
            { state with LeaderIndex = value }

        [<CustomOperation("leaderMaxSeqNo")>]
        member _.LeaderMaxSeqNo(state: Types.CcrTypesShardStats, value: Types.SequenceNumber) =
            { state with LeaderMaxSeqNo = value }

        [<CustomOperation("operationsRead")>]
        member _.OperationsRead(state: Types.CcrTypesShardStats, value: Types.Long) =
            { state with OperationsRead = value }

        [<CustomOperation("operationsWritten")>]
        member _.OperationsWritten(state: Types.CcrTypesShardStats, value: Types.Long) =
            { state with OperationsWritten = value }

        [<CustomOperation("outstandingReadRequests")>]
        member _.OutstandingReadRequests(state: Types.CcrTypesShardStats, value: Types.Integer) =
            { state with OutstandingReadRequests = value }

        [<CustomOperation("outstandingWriteRequests")>]
        member _.OutstandingWriteRequests(state: Types.CcrTypesShardStats, value: Types.Integer) =
            { state with OutstandingWriteRequests = value }

        [<CustomOperation("readExceptions")>]
        member _.ReadExceptions(state: Types.CcrTypesShardStats, value: Types.ReadException list) =
            { state with ReadExceptions = value }

        [<CustomOperation("remoteCluster")>]
        member _.RemoteCluster(state: Types.CcrTypesShardStats, value: string) =
            { state with RemoteCluster = value }

        [<CustomOperation("shardId")>]
        member _.ShardId(state: Types.CcrTypesShardStats, value: Types.Integer) =
            { state with ShardId = value }

        [<CustomOperation("successfulReadRequests")>]
        member _.SuccessfulReadRequests(state: Types.CcrTypesShardStats, value: Types.Long) =
            { state with SuccessfulReadRequests = value }

        [<CustomOperation("successfulWriteRequests")>]
        member _.SuccessfulWriteRequests(state: Types.CcrTypesShardStats, value: Types.Long) =
            { state with SuccessfulWriteRequests = value }

        [<CustomOperation("timeSinceLastRead")>]
        member _.TimeSinceLastRead(state: Types.CcrTypesShardStats, value: Types.Duration) =
            { state with TimeSinceLastRead = Some value }

        [<CustomOperation("timeSinceLastReadMillis")>]
        member _.TimeSinceLastReadMillis(state: Types.CcrTypesShardStats, value: Types.DurationValue<Types.UnitMillis>) =
            { state with TimeSinceLastReadMillis = value }

        [<CustomOperation("totalReadRemoteExecTime")>]
        member _.TotalReadRemoteExecTime(state: Types.CcrTypesShardStats, value: Types.Duration) =
            { state with TotalReadRemoteExecTime = Some value }

        [<CustomOperation("totalReadRemoteExecTimeMillis")>]
        member _.TotalReadRemoteExecTimeMillis(state: Types.CcrTypesShardStats, value: Types.DurationValue<Types.UnitMillis>) =
            { state with TotalReadRemoteExecTimeMillis = value }

        [<CustomOperation("totalReadTime")>]
        member _.TotalReadTime(state: Types.CcrTypesShardStats, value: Types.Duration) =
            { state with TotalReadTime = Some value }

        [<CustomOperation("totalReadTimeMillis")>]
        member _.TotalReadTimeMillis(state: Types.CcrTypesShardStats, value: Types.DurationValue<Types.UnitMillis>) =
            { state with TotalReadTimeMillis = value }

        [<CustomOperation("totalWriteTime")>]
        member _.TotalWriteTime(state: Types.CcrTypesShardStats, value: Types.Duration) =
            { state with TotalWriteTime = Some value }

        [<CustomOperation("totalWriteTimeMillis")>]
        member _.TotalWriteTimeMillis(state: Types.CcrTypesShardStats, value: Types.DurationValue<Types.UnitMillis>) =
            { state with TotalWriteTimeMillis = value }

        [<CustomOperation("writeBufferOperationCount")>]
        member _.WriteBufferOperationCount(state: Types.CcrTypesShardStats, value: Types.Long) =
            { state with WriteBufferOperationCount = value }

        [<CustomOperation("writeBufferSizeInBytes")>]
        member _.WriteBufferSizeInBytes(state: Types.CcrTypesShardStats, value: Types.ByteSize) =
            { state with WriteBufferSizeInBytes = value }

    let ccrTypesShardStats = CcrTypesShardStatsBuilder()


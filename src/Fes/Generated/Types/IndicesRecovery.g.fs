// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesRecovery =

    type FileDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("length")>]
        Length: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
        [<System.Text.Json.Serialization.JsonPropertyName("recovered")>]
        Recovered: CoreTypes.Long
    }

    type RecoveryBytes = {
        [<System.Text.Json.Serialization.JsonPropertyName("percent")>]
        Percent: CoreTypes.Percentage
        [<System.Text.Json.Serialization.JsonPropertyName("recovered")>]
        Recovered: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("recovered_in_bytes")>]
        RecoveredInBytes: CoreTypes.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("recovered_from_snapshot")>]
        RecoveredFromSnapshot: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("recovered_from_snapshot_in_bytes")>]
        RecoveredFromSnapshotInBytes: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("reused")>]
        Reused: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("reused_in_bytes")>]
        ReusedInBytes: CoreTypes.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_in_bytes")>]
        TotalInBytes: CoreTypes.ByteSize
    }

    type RecoveryFiles = {
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: FileDetails list option
        [<System.Text.Json.Serialization.JsonPropertyName("percent")>]
        Percent: CoreTypes.Percentage
        [<System.Text.Json.Serialization.JsonPropertyName("recovered")>]
        Recovered: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("reused")>]
        Reused: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.Long
    }

    type RecoveryIndexStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("bytes")>]
        Bytes: RecoveryBytes option
        [<System.Text.Json.Serialization.JsonPropertyName("files")>]
        Files: RecoveryFiles
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: RecoveryBytes
        [<System.Text.Json.Serialization.JsonPropertyName("source_throttle_time")>]
        SourceThrottleTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("source_throttle_time_in_millis")>]
        SourceThrottleTimeInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("target_throttle_time")>]
        TargetThrottleTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("target_throttle_time_in_millis")>]
        TargetThrottleTimeInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("total_time")>]
        TotalTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_time_in_millis")>]
        TotalTimeInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
    }

    type RecoveryOrigin = {
        [<System.Text.Json.Serialization.JsonPropertyName("hostname")>]
        Hostname: string option
        [<System.Text.Json.Serialization.JsonPropertyName("host")>]
        Host: CoreTypes.Host option
        [<System.Text.Json.Serialization.JsonPropertyName("transport_address")>]
        TransportAddress: CoreTypes.TransportAddress option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("ip")>]
        Ip: CoreTypes.Ip option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("bootstrap_new_history_uuid")>]
        BootstrapNewHistoryUuid: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("repository")>]
        Repository: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot")>]
        Snapshot: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("restoreUUID")>]
        RestoreUUID: CoreTypes.Uuid option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName option
    }

    [<RequireQualifiedAccess>]
    type RecoveryStage =
        | INIT
        | INDEX
        | VERIFYINDEX
        | TRANSLOG
        | FINALIZE
        | DONE

    type RecoveryStartStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("check_index_time")>]
        CheckIndexTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("check_index_time_in_millis")>]
        CheckIndexTimeInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("total_time")>]
        TotalTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_time_in_millis")>]
        TotalTimeInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
    }

    type TranslogStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("percent")>]
        Percent: CoreTypes.Percentage
        [<System.Text.Json.Serialization.JsonPropertyName("recovered")>]
        Recovered: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_on_start")>]
        TotalOnStart: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_time")>]
        TotalTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_time_in_millis")>]
        TotalTimeInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
    }

    [<RequireQualifiedAccess>]
    type RecoveryType =
        | EMPTYSTORE
        | EXISTINGSTORE
        | LOCALSHARDS
        | PEER
        | SNAPSHOT

    type VerifyIndex = {
        [<System.Text.Json.Serialization.JsonPropertyName("check_index_time")>]
        CheckIndexTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("check_index_time_in_millis")>]
        CheckIndexTimeInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("total_time")>]
        TotalTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_time_in_millis")>]
        TotalTimeInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
    }

    type ShardRecovery = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: RecoveryIndexStatus
        [<System.Text.Json.Serialization.JsonPropertyName("primary")>]
        Primary: bool
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: RecoveryOrigin
        [<System.Text.Json.Serialization.JsonPropertyName("stage")>]
        Stage: RecoveryStage
        [<System.Text.Json.Serialization.JsonPropertyName("start")>]
        Start: RecoveryStartStatus option
        [<System.Text.Json.Serialization.JsonPropertyName("start_time")>]
        StartTime: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("start_time_in_millis")>]
        StartTimeInMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("stop_time")>]
        StopTime: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("stop_time_in_millis")>]
        StopTimeInMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("target")>]
        Target: RecoveryOrigin
        [<System.Text.Json.Serialization.JsonPropertyName("total_time")>]
        TotalTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_time_in_millis")>]
        TotalTimeInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("translog")>]
        Translog: TranslogStatus
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: RecoveryType
        [<System.Text.Json.Serialization.JsonPropertyName("verify_index")>]
        VerifyIndex: VerifyIndex
    }

    type RecoveryStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: ShardRecovery list
    }


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesRecovery =

    type FileDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("length")>]
        Length: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
        [<System.Text.Json.Serialization.JsonPropertyName("recovered")>]
        Recovered: Types.Long
    }

    type RecoveryBytes = {
        [<System.Text.Json.Serialization.JsonPropertyName("percent")>]
        Percent: Types.Percentage
        [<System.Text.Json.Serialization.JsonPropertyName("recovered")>]
        Recovered: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("recovered_in_bytes")>]
        RecoveredInBytes: Types.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("recovered_from_snapshot")>]
        RecoveredFromSnapshot: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("recovered_from_snapshot_in_bytes")>]
        RecoveredFromSnapshotInBytes: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("reused")>]
        Reused: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("reused_in_bytes")>]
        ReusedInBytes: Types.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_in_bytes")>]
        TotalInBytes: Types.ByteSize
    }

    type RecoveryFiles = {
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: IndicesRecovery.FileDetails list option
        [<System.Text.Json.Serialization.JsonPropertyName("percent")>]
        Percent: Types.Percentage
        [<System.Text.Json.Serialization.JsonPropertyName("recovered")>]
        Recovered: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("reused")>]
        Reused: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Long
    }

    type RecoveryIndexStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("bytes")>]
        Bytes: IndicesRecovery.RecoveryBytes option
        [<System.Text.Json.Serialization.JsonPropertyName("files")>]
        Files: IndicesRecovery.RecoveryFiles
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: IndicesRecovery.RecoveryBytes
        [<System.Text.Json.Serialization.JsonPropertyName("source_throttle_time")>]
        SourceThrottleTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("source_throttle_time_in_millis")>]
        SourceThrottleTimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("target_throttle_time")>]
        TargetThrottleTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("target_throttle_time_in_millis")>]
        TargetThrottleTimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("total_time")>]
        TotalTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_time_in_millis")>]
        TotalTimeInMillis: Types.DurationValue<Types.UnitMillis>
    }

    type RecoveryOrigin = {
        [<System.Text.Json.Serialization.JsonPropertyName("hostname")>]
        Hostname: string option
        [<System.Text.Json.Serialization.JsonPropertyName("host")>]
        Host: Types.Host option
        [<System.Text.Json.Serialization.JsonPropertyName("transport_address")>]
        TransportAddress: Types.TransportAddress option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("ip")>]
        Ip: Types.Ip option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("bootstrap_new_history_uuid")>]
        BootstrapNewHistoryUuid: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("repository")>]
        Repository: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot")>]
        Snapshot: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("restoreUUID")>]
        RestoreUUID: Types.Uuid option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName option
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
        CheckIndexTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("check_index_time_in_millis")>]
        CheckIndexTimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("total_time")>]
        TotalTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_time_in_millis")>]
        TotalTimeInMillis: Types.DurationValue<Types.UnitMillis>
    }

    type TranslogStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("percent")>]
        Percent: Types.Percentage
        [<System.Text.Json.Serialization.JsonPropertyName("recovered")>]
        Recovered: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_on_start")>]
        TotalOnStart: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_time")>]
        TotalTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_time_in_millis")>]
        TotalTimeInMillis: Types.DurationValue<Types.UnitMillis>
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
        CheckIndexTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("check_index_time_in_millis")>]
        CheckIndexTimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("total_time")>]
        TotalTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_time_in_millis")>]
        TotalTimeInMillis: Types.DurationValue<Types.UnitMillis>
    }

    type ShardRecovery = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: IndicesRecovery.RecoveryIndexStatus
        [<System.Text.Json.Serialization.JsonPropertyName("primary")>]
        Primary: bool
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: IndicesRecovery.RecoveryOrigin
        [<System.Text.Json.Serialization.JsonPropertyName("stage")>]
        Stage: IndicesRecovery.RecoveryStage
        [<System.Text.Json.Serialization.JsonPropertyName("start")>]
        Start: IndicesRecovery.RecoveryStartStatus option
        [<System.Text.Json.Serialization.JsonPropertyName("start_time")>]
        StartTime: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("start_time_in_millis")>]
        StartTimeInMillis: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("stop_time")>]
        StopTime: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("stop_time_in_millis")>]
        StopTimeInMillis: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("target")>]
        Target: IndicesRecovery.RecoveryOrigin
        [<System.Text.Json.Serialization.JsonPropertyName("total_time")>]
        TotalTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_time_in_millis")>]
        TotalTimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("translog")>]
        Translog: IndicesRecovery.TranslogStatus
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: IndicesRecovery.RecoveryType
        [<System.Text.Json.Serialization.JsonPropertyName("verify_index")>]
        VerifyIndex: IndicesRecovery.VerifyIndex
    }

    type RecoveryStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: IndicesRecovery.ShardRecovery list
    }


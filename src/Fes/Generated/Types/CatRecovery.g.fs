// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatRecovery =

    type RecoveryRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("shard")>]
        Shard: string option
        [<System.Text.Json.Serialization.JsonPropertyName("start_time")>]
        StartTime: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("start_time_millis")>]
        StartTimeMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("stop_time")>]
        StopTime: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("stop_time_millis")>]
        StopTimeMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("time")>]
        Time: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stage")>]
        Stage: string option
        [<System.Text.Json.Serialization.JsonPropertyName("source_host")>]
        SourceHost: string option
        [<System.Text.Json.Serialization.JsonPropertyName("source_node")>]
        SourceNode: string option
        [<System.Text.Json.Serialization.JsonPropertyName("target_host")>]
        TargetHost: string option
        [<System.Text.Json.Serialization.JsonPropertyName("target_node")>]
        TargetNode: string option
        [<System.Text.Json.Serialization.JsonPropertyName("repository")>]
        Repository: string option
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot")>]
        Snapshot: string option
        [<System.Text.Json.Serialization.JsonPropertyName("files")>]
        Files: string option
        [<System.Text.Json.Serialization.JsonPropertyName("files_recovered")>]
        FilesRecovered: string option
        [<System.Text.Json.Serialization.JsonPropertyName("files_percent")>]
        FilesPercent: CoreTypes.Percentage option
        [<System.Text.Json.Serialization.JsonPropertyName("files_total")>]
        FilesTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("bytes")>]
        Bytes: string option
        [<System.Text.Json.Serialization.JsonPropertyName("bytes_recovered")>]
        BytesRecovered: string option
        [<System.Text.Json.Serialization.JsonPropertyName("bytes_percent")>]
        BytesPercent: CoreTypes.Percentage option
        [<System.Text.Json.Serialization.JsonPropertyName("bytes_total")>]
        BytesTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("translog_ops")>]
        TranslogOps: string option
        [<System.Text.Json.Serialization.JsonPropertyName("translog_ops_recovered")>]
        TranslogOpsRecovered: string option
        [<System.Text.Json.Serialization.JsonPropertyName("translog_ops_percent")>]
        TranslogOpsPercent: CoreTypes.Percentage option
    }


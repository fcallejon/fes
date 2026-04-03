// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module TransformGetTransformStats =

    type TransformProgress = {
        [<System.Text.Json.Serialization.JsonPropertyName("docs_indexed")>]
        DocsIndexed: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("docs_processed")>]
        DocsProcessed: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("docs_remaining")>]
        DocsRemaining: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("percent_complete")>]
        PercentComplete: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("total_docs")>]
        TotalDocs: Types.Long option
    }

    type CheckpointStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("checkpoint")>]
        Checkpoint: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("checkpoint_progress")>]
        CheckpointProgress: TransformGetTransformStats.TransformProgress option
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp_millis")>]
        TimestampMillis: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("time_upper_bound")>]
        TimeUpperBound: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("time_upper_bound_millis")>]
        TimeUpperBoundMillis: Types.EpochTime<Types.UnitMillis> option
    }

    type Checkpointing = {
        [<System.Text.Json.Serialization.JsonPropertyName("changes_last_detected_at")>]
        ChangesLastDetectedAt: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("changes_last_detected_at_string")>]
        ChangesLastDetectedAtString: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("last")>]
        Last: TransformGetTransformStats.CheckpointStats
        [<System.Text.Json.Serialization.JsonPropertyName("next")>]
        Next: TransformGetTransformStats.CheckpointStats option
        [<System.Text.Json.Serialization.JsonPropertyName("operations_behind")>]
        OperationsBehind: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("last_search_time")>]
        LastSearchTime: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("last_search_time_string")>]
        LastSearchTimeString: Types.DateTime option
    }

    type TransformHealthIssue = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("issue")>]
        Issue: string
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: string option
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("first_occurrence")>]
        FirstOccurrence: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("first_occurence_string")>]
        FirstOccurenceString: Types.DateTime option
    }

    type TransformIndexerStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("delete_time_in_ms")>]
        DeleteTimeInMs: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("documents_indexed")>]
        DocumentsIndexed: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("documents_deleted")>]
        DocumentsDeleted: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("documents_processed")>]
        DocumentsProcessed: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("exponential_avg_checkpoint_duration_ms")>]
        ExponentialAvgCheckpointDurationMs: Types.DurationValue<Types.UnitFloatMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("exponential_avg_documents_indexed")>]
        ExponentialAvgDocumentsIndexed: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("exponential_avg_documents_processed")>]
        ExponentialAvgDocumentsProcessed: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("index_failures")>]
        IndexFailures: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("index_time_in_ms")>]
        IndexTimeInMs: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("index_total")>]
        IndexTotal: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("pages_processed")>]
        PagesProcessed: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("processing_time_in_ms")>]
        ProcessingTimeInMs: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("processing_total")>]
        ProcessingTotal: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("search_failures")>]
        SearchFailures: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("search_time_in_ms")>]
        SearchTimeInMs: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("search_total")>]
        SearchTotal: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("trigger_count")>]
        TriggerCount: Types.Long
    }

    type TransformStatsHealth = {
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: Types.HealthStatus
        [<System.Text.Json.Serialization.JsonPropertyName("issues")>]
        Issues: TransformGetTransformStats.TransformHealthIssue list option
    }

    type TransformStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("checkpointing")>]
        Checkpointing: TransformGetTransformStats.Checkpointing
        [<System.Text.Json.Serialization.JsonPropertyName("health")>]
        Health: TransformGetTransformStats.TransformStatsHealth option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: Types.NodeAttributes option
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string option
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: string
        [<System.Text.Json.Serialization.JsonPropertyName("stats")>]
        Stats: TransformGetTransformStats.TransformIndexerStats
    }


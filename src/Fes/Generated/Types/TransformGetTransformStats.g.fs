// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module TransformGetTransformStats =

    type TransformProgress = {
        [<System.Text.Json.Serialization.JsonPropertyName("docs_indexed")>]
        DocsIndexed: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("docs_processed")>]
        DocsProcessed: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("docs_remaining")>]
        DocsRemaining: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("percent_complete")>]
        PercentComplete: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("total_docs")>]
        TotalDocs: CoreTypes.Long option
    }

    type CheckpointStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("checkpoint")>]
        Checkpoint: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("checkpoint_progress")>]
        CheckpointProgress: TransformProgress option
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp_millis")>]
        TimestampMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("time_upper_bound")>]
        TimeUpperBound: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("time_upper_bound_millis")>]
        TimeUpperBoundMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
    }

    type Checkpointing = {
        [<System.Text.Json.Serialization.JsonPropertyName("changes_last_detected_at")>]
        ChangesLastDetectedAt: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("changes_last_detected_at_string")>]
        ChangesLastDetectedAtString: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("last")>]
        Last: CheckpointStats
        [<System.Text.Json.Serialization.JsonPropertyName("next")>]
        Next: CheckpointStats option
        [<System.Text.Json.Serialization.JsonPropertyName("operations_behind")>]
        OperationsBehind: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("last_search_time")>]
        LastSearchTime: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("last_search_time_string")>]
        LastSearchTimeString: CoreTypes.DateTime option
    }

    type TransformHealthIssue = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("issue")>]
        Issue: string
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: string option
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("first_occurrence")>]
        FirstOccurrence: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("first_occurence_string")>]
        FirstOccurenceString: CoreTypes.DateTime option
    }

    type TransformIndexerStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("delete_time_in_ms")>]
        DeleteTimeInMs: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("documents_indexed")>]
        DocumentsIndexed: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("documents_deleted")>]
        DocumentsDeleted: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("documents_processed")>]
        DocumentsProcessed: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("exponential_avg_checkpoint_duration_ms")>]
        ExponentialAvgCheckpointDurationMs: CoreTypes.DurationValue<CoreTypes.UnitFloatMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("exponential_avg_documents_indexed")>]
        ExponentialAvgDocumentsIndexed: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("exponential_avg_documents_processed")>]
        ExponentialAvgDocumentsProcessed: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("index_failures")>]
        IndexFailures: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("index_time_in_ms")>]
        IndexTimeInMs: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("index_total")>]
        IndexTotal: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("pages_processed")>]
        PagesProcessed: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("processing_time_in_ms")>]
        ProcessingTimeInMs: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("processing_total")>]
        ProcessingTotal: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("search_failures")>]
        SearchFailures: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("search_time_in_ms")>]
        SearchTimeInMs: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("search_total")>]
        SearchTotal: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("trigger_count")>]
        TriggerCount: CoreTypes.Long
    }

    type TransformStatsHealth = {
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: CoreTypes.HealthStatus
        [<System.Text.Json.Serialization.JsonPropertyName("issues")>]
        Issues: TransformHealthIssue list option
    }

    type TransformStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("checkpointing")>]
        Checkpointing: Checkpointing
        [<System.Text.Json.Serialization.JsonPropertyName("health")>]
        Health: TransformStatsHealth option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: CoreTypes.NodeAttributes option
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string option
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: string
        [<System.Text.Json.Serialization.JsonPropertyName("stats")>]
        Stats: TransformIndexerStats
    }


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module RollupGetJobs =

    [<RequireQualifiedAccess>]
    type IndexingJobState =
        | Started
        | Indexing
        | Stopping
        | Stopped
        | Aborting

    type RollupJobConfiguration = {
        [<System.Text.Json.Serialization.JsonPropertyName("cron")>]
        Cron: string
        [<System.Text.Json.Serialization.JsonPropertyName("groups")>]
        Groups: RollupTypes.Groupings
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("index_pattern")>]
        IndexPattern: string
        [<System.Text.Json.Serialization.JsonPropertyName("metrics")>]
        Metrics: RollupTypes.FieldMetric list
        [<System.Text.Json.Serialization.JsonPropertyName("page_size")>]
        PageSize: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("rollup_index")>]
        RollupIndex: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("timeout")>]
        Timeout: CoreTypes.Duration
    }

    type RollupJobStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("documents_processed")>]
        DocumentsProcessed: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("index_failures")>]
        IndexFailures: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("index_time_in_ms")>]
        IndexTimeInMs: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("index_total")>]
        IndexTotal: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("pages_processed")>]
        PagesProcessed: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("rollups_indexed")>]
        RollupsIndexed: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("search_failures")>]
        SearchFailures: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("search_time_in_ms")>]
        SearchTimeInMs: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("search_total")>]
        SearchTotal: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("trigger_count")>]
        TriggerCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("processing_time_in_ms")>]
        ProcessingTimeInMs: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("processing_total")>]
        ProcessingTotal: CoreTypes.Long
    }

    type RollupJobStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("current_position")>]
        CurrentPosition: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("job_state")>]
        JobState: IndexingJobState
        [<System.Text.Json.Serialization.JsonPropertyName("upgraded_doc_id")>]
        UpgradedDocId: bool option
    }

    type RollupJob = {
        [<System.Text.Json.Serialization.JsonPropertyName("config")>]
        Config: RollupJobConfiguration
        [<System.Text.Json.Serialization.JsonPropertyName("stats")>]
        Stats: RollupJobStats
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: RollupJobStatus
    }


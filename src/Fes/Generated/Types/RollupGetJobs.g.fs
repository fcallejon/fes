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
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("index_pattern")>]
        IndexPattern: string
        [<System.Text.Json.Serialization.JsonPropertyName("metrics")>]
        Metrics: RollupTypes.FieldMetric list
        [<System.Text.Json.Serialization.JsonPropertyName("page_size")>]
        PageSize: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("rollup_index")>]
        RollupIndex: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("timeout")>]
        Timeout: Types.Duration
    }

    type RollupJobStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("documents_processed")>]
        DocumentsProcessed: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("index_failures")>]
        IndexFailures: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("index_time_in_ms")>]
        IndexTimeInMs: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("index_total")>]
        IndexTotal: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("pages_processed")>]
        PagesProcessed: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("rollups_indexed")>]
        RollupsIndexed: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("search_failures")>]
        SearchFailures: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("search_time_in_ms")>]
        SearchTimeInMs: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("search_total")>]
        SearchTotal: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("trigger_count")>]
        TriggerCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("processing_time_in_ms")>]
        ProcessingTimeInMs: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("processing_total")>]
        ProcessingTotal: Types.Long
    }

    type RollupJobStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("current_position")>]
        CurrentPosition: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("job_state")>]
        JobState: RollupGetJobs.IndexingJobState
        [<System.Text.Json.Serialization.JsonPropertyName("upgraded_doc_id")>]
        UpgradedDocId: bool option
    }

    type RollupJob = {
        [<System.Text.Json.Serialization.JsonPropertyName("config")>]
        Config: RollupGetJobs.RollupJobConfiguration
        [<System.Text.Json.Serialization.JsonPropertyName("stats")>]
        Stats: RollupGetJobs.RollupJobStats
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: RollupGetJobs.RollupJobStatus
    }


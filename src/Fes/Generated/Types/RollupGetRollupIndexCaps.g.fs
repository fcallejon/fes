// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module RollupGetRollupIndexCaps =

    type RollupJobSummaryField = {
        [<System.Text.Json.Serialization.JsonPropertyName("agg")>]
        Agg: string
        [<System.Text.Json.Serialization.JsonPropertyName("time_zone")>]
        TimeZone: CoreTypes.TimeZone option
        [<System.Text.Json.Serialization.JsonPropertyName("calendar_interval")>]
        CalendarInterval: CoreTypes.Duration option
    }

    type RollupJobSummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<CoreTypes.Field, RollupJobSummaryField list>
        [<System.Text.Json.Serialization.JsonPropertyName("index_pattern")>]
        IndexPattern: string
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("rollup_index")>]
        RollupIndex: CoreTypes.IndexName
    }

    type IndexCapabilities = {
        [<System.Text.Json.Serialization.JsonPropertyName("rollup_jobs")>]
        RollupJobs: RollupJobSummary list
    }


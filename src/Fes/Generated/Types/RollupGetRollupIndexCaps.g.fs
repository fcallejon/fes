// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module RollupGetRollupIndexCaps =

    type RollupJobSummaryField = {
        [<System.Text.Json.Serialization.JsonPropertyName("agg")>]
        Agg: string
        [<System.Text.Json.Serialization.JsonPropertyName("time_zone")>]
        TimeZone: Types.TimeZone option
        [<System.Text.Json.Serialization.JsonPropertyName("calendar_interval")>]
        CalendarInterval: Types.Duration option
    }

    type RollupJobSummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<Types.Field, RollupGetRollupIndexCaps.RollupJobSummaryField list>
        [<System.Text.Json.Serialization.JsonPropertyName("index_pattern")>]
        IndexPattern: string
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("rollup_index")>]
        RollupIndex: Types.IndexName
    }

    type IndexCapabilities = {
        [<System.Text.Json.Serialization.JsonPropertyName("rollup_jobs")>]
        RollupJobs: RollupGetRollupIndexCaps.RollupJobSummary list
    }


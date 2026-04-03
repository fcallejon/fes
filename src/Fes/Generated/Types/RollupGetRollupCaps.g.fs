// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module RollupGetRollupCaps =

    type RollupFieldSummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("agg")>]
        Agg: string
        [<System.Text.Json.Serialization.JsonPropertyName("calendar_interval")>]
        CalendarInterval: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("time_zone")>]
        TimeZone: Types.TimeZone option
    }

    type RollupCapabilitySummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<Types.Field, RollupGetRollupCaps.RollupFieldSummary list>
        [<System.Text.Json.Serialization.JsonPropertyName("index_pattern")>]
        IndexPattern: string
        [<System.Text.Json.Serialization.JsonPropertyName("job_id")>]
        JobId: string
        [<System.Text.Json.Serialization.JsonPropertyName("rollup_index")>]
        RollupIndex: string
    }

    type RollupCapabilities = {
        [<System.Text.Json.Serialization.JsonPropertyName("rollup_jobs")>]
        RollupJobs: RollupGetRollupCaps.RollupCapabilitySummary list
    }


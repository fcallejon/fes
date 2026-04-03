// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module RollupTypes =

    type DateHistogramGrouping = {
        [<System.Text.Json.Serialization.JsonPropertyName("delay")>]
        Delay: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("interval")>]
        Interval: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("calendar_interval")>]
        CalendarInterval: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("fixed_interval")>]
        FixedInterval: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("time_zone")>]
        TimeZone: Types.TimeZone option
    }

    [<RequireQualifiedAccess>]
    type Metric =
        | Min
        | Max
        | Sum
        | Avg
        | ValueCount

    type FieldMetric = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("metrics")>]
        Metrics: RollupTypes.Metric list
    }

    type HistogramGrouping = {
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Types.Fields
        [<System.Text.Json.Serialization.JsonPropertyName("interval")>]
        Interval: Types.Long
    }

    type TermsGrouping = {
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Types.Fields
    }

    type Groupings = {
        [<System.Text.Json.Serialization.JsonPropertyName("date_histogram")>]
        DateHistogram: RollupTypes.DateHistogramGrouping option
        [<System.Text.Json.Serialization.JsonPropertyName("histogram")>]
        Histogram: RollupTypes.HistogramGrouping option
        [<System.Text.Json.Serialization.JsonPropertyName("terms")>]
        Terms: RollupTypes.TermsGrouping option
    }


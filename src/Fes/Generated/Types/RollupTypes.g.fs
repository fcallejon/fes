// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module RollupTypes =

    type DateHistogramGrouping = {
        [<System.Text.Json.Serialization.JsonPropertyName("delay")>]
        Delay: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("interval")>]
        Interval: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("calendar_interval")>]
        CalendarInterval: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("fixed_interval")>]
        FixedInterval: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("time_zone")>]
        TimeZone: CoreTypes.TimeZone option
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
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("metrics")>]
        Metrics: Metric list
    }

    type HistogramGrouping = {
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: CoreTypes.Fields
        [<System.Text.Json.Serialization.JsonPropertyName("interval")>]
        Interval: CoreTypes.Long
    }

    type TermsGrouping = {
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: CoreTypes.Fields
    }

    type Groupings = {
        [<System.Text.Json.Serialization.JsonPropertyName("date_histogram")>]
        DateHistogram: DateHistogramGrouping option
        [<System.Text.Json.Serialization.JsonPropertyName("histogram")>]
        Histogram: HistogramGrouping option
        [<System.Text.Json.Serialization.JsonPropertyName("terms")>]
        Terms: TermsGrouping option
    }


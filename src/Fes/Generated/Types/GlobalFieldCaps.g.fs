// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalFieldCaps =

    type FieldCapability = {
        [<System.Text.Json.Serialization.JsonPropertyName("aggregatable")>]
        Aggregatable: bool
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: CoreTypes.Indices option
        [<System.Text.Json.Serialization.JsonPropertyName("meta")>]
        Meta: CoreTypes.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("non_aggregatable_indices")>]
        NonAggregatableIndices: CoreTypes.Indices option
        [<System.Text.Json.Serialization.JsonPropertyName("non_searchable_indices")>]
        NonSearchableIndices: CoreTypes.Indices option
        [<System.Text.Json.Serialization.JsonPropertyName("searchable")>]
        Searchable: bool
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("metadata_field")>]
        MetadataField: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("time_series_dimension")>]
        TimeSeriesDimension: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("time_series_metric")>]
        TimeSeriesMetric: CoreTypes.TimeSeriesMetricType option
        [<System.Text.Json.Serialization.JsonPropertyName("non_dimension_indices")>]
        NonDimensionIndices: CoreTypes.IndexName list option
        [<System.Text.Json.Serialization.JsonPropertyName("metric_conflicts_indices")>]
        MetricConflictsIndices: CoreTypes.IndexName list option
    }


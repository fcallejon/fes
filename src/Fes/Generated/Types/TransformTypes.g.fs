// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module TransformTypes =

    type Destination = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("pipeline")>]
        Pipeline: string option
    }

    type Latest = {
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("unique_key")>]
        UniqueKey: Types.Field list
    }

    [<RequireQualifiedAccess>]
    type PivotGroupByContainer =
        | DateHistogram of TypesAggregations.DateHistogramAggregation
        | GeotileGrid of TypesAggregations.GeoTileGridAggregation
        | Histogram of TypesAggregations.HistogramAggregation
        | Terms of TypesAggregations.TermsAggregation

    type Pivot = {
        [<System.Text.Json.Serialization.JsonPropertyName("aggregations")>]
        Aggregations: Map<string, TypesAggregations.AggregationContainer> option
        [<System.Text.Json.Serialization.JsonPropertyName("group_by")>]
        GroupBy: Map<string, TransformTypes.PivotGroupByContainer> option
    }

    type RetentionPolicy = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("max_age")>]
        MaxAge: Types.Duration
    }

    [<RequireQualifiedAccess>]
    type RetentionPolicyContainer =
        | Time of TransformTypes.RetentionPolicy

    /// The source of the data for the transform.
    type Settings = {
        [<System.Text.Json.Serialization.JsonPropertyName("align_checkpoints")>]
        AlignCheckpoints: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("dates_as_epoch_millis")>]
        DatesAsEpochMillis: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("deduce_mappings")>]
        DeduceMappings: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("docs_per_second")>]
        DocsPerSecond: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("max_page_search_size")>]
        MaxPageSearchSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("use_point_in_time")>]
        UsePointInTime: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("num_failure_retries")>]
        NumFailureRetries: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("unattended")>]
        Unattended: bool option
    }

    type Source = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.Indices
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: TypesQueryDsl.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: TypesMapping.RuntimeFields option
        [<System.Text.Json.Serialization.JsonPropertyName("project_routing")>]
        ProjectRouting: Types.ProjectRouting option
    }

    type TimeSync = {
        [<System.Text.Json.Serialization.JsonPropertyName("delay")>]
        Delay: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
    }

    [<RequireQualifiedAccess>]
    type SyncContainer =
        | Time of TransformTypes.TimeSync


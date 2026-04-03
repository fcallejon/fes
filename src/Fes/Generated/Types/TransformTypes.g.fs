// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module TransformTypes =

    type Destination = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("pipeline")>]
        Pipeline: string option
    }

    type Latest = {
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("unique_key")>]
        UniqueKey: CoreTypes.Field list
    }

    [<RequireQualifiedAccess>]
    type PivotGroupByContainer =
        | DateHistogram of CoreTypes.DateHistogramAggregation
        | GeotileGrid of CoreTypes.GeoTileGridAggregation
        | Histogram of CoreTypes.HistogramAggregation
        | Terms of CoreTypes.TermsAggregation

    type Pivot = {
        [<System.Text.Json.Serialization.JsonPropertyName("aggregations")>]
        Aggregations: Map<string, CoreTypes.AggregationContainer> option
        [<System.Text.Json.Serialization.JsonPropertyName("group_by")>]
        GroupBy: Map<string, PivotGroupByContainer> option
    }

    type RetentionPolicy = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("max_age")>]
        MaxAge: CoreTypes.Duration
    }

    [<RequireQualifiedAccess>]
    type RetentionPolicyContainer =
        | Time of RetentionPolicy

    /// The source of the data for the transform.
    type Settings = {
        [<System.Text.Json.Serialization.JsonPropertyName("align_checkpoints")>]
        AlignCheckpoints: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("dates_as_epoch_millis")>]
        DatesAsEpochMillis: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("deduce_mappings")>]
        DeduceMappings: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("docs_per_second")>]
        DocsPerSecond: CoreTypes.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("max_page_search_size")>]
        MaxPageSearchSize: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("use_point_in_time")>]
        UsePointInTime: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("num_failure_retries")>]
        NumFailureRetries: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("unattended")>]
        Unattended: bool option
    }

    type Source = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.Indices
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: CoreTypes.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("runtime_mappings")>]
        RuntimeMappings: CoreTypes.RuntimeFields option
        [<System.Text.Json.Serialization.JsonPropertyName("project_routing")>]
        ProjectRouting: CoreTypes.ProjectRouting option
    }

    type TimeSync = {
        [<System.Text.Json.Serialization.JsonPropertyName("delay")>]
        Delay: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
    }

    [<RequireQualifiedAccess>]
    type SyncContainer =
        | Time of TimeSync


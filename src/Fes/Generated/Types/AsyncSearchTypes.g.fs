// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module AsyncSearchTypes =

    type AsyncSearch<'tDocument> = {
        [<System.Text.Json.Serialization.JsonPropertyName("aggregations")>]
        Aggregations: Map<CoreTypes.AggregateName, CoreTypes.Aggregate> option
        [<System.Text.Json.Serialization.JsonPropertyName("_clusters")>]
        Clusters: CoreTypes.ClusterStatistics option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("hits")>]
        Hits: GlobalSearchTypes.HitsMetadata<'tDocument>
        [<System.Text.Json.Serialization.JsonPropertyName("max_score")>]
        MaxScore: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("num_reduce_phases")>]
        NumReducePhases: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("profile")>]
        Profile: GlobalSearchTypes.Profile option
        [<System.Text.Json.Serialization.JsonPropertyName("pit_id")>]
        PitId: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("_scroll_id")>]
        ScrollId: CoreTypes.ScrollId option
        [<System.Text.Json.Serialization.JsonPropertyName("_shards")>]
        Shards: CoreTypes.ShardStatistics
        [<System.Text.Json.Serialization.JsonPropertyName("suggest")>]
        Suggest: Map<CoreTypes.SuggestionName, GlobalSearchTypes.Suggest<'tDocument> list> option
        [<System.Text.Json.Serialization.JsonPropertyName("terminated_early")>]
        TerminatedEarly: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("timed_out")>]
        TimedOut: bool
        [<System.Text.Json.Serialization.JsonPropertyName("took")>]
        Took: CoreTypes.Long
    }

    type AsyncSearchResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("is_partial")>]
        IsPartial: bool
        [<System.Text.Json.Serialization.JsonPropertyName("is_running")>]
        IsRunning: bool
        [<System.Text.Json.Serialization.JsonPropertyName("expiration_time")>]
        ExpirationTime: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("expiration_time_in_millis")>]
        ExpirationTimeInMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("start_time")>]
        StartTime: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("start_time_in_millis")>]
        StartTimeInMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("completion_time")>]
        CompletionTime: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("completion_time_in_millis")>]
        CompletionTimeInMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: CoreTypes.ErrorCause option
    }

    type AsyncSearchDocumentResponseBase<'tDocument> = {
        [<System.Text.Json.Serialization.JsonPropertyName("response")>]
        Response: AsyncSearch<'tDocument>
    }

    type AsyncSearchResponseException<'tDocument> = {
        [<System.Text.Json.Serialization.JsonPropertyName("is_partial")>]
        IsPartial: bool
        [<System.Text.Json.Serialization.JsonPropertyName("is_running")>]
        IsRunning: bool
        [<System.Text.Json.Serialization.JsonPropertyName("expiration_time")>]
        ExpirationTime: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("expiration_time_in_millis")>]
        ExpirationTimeInMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("start_time")>]
        StartTime: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("start_time_in_millis")>]
        StartTimeInMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("completion_time")>]
        CompletionTime: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("completion_time_in_millis")>]
        CompletionTimeInMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: CoreTypes.ErrorCause option
        [<System.Text.Json.Serialization.JsonPropertyName("response")>]
        Response: AsyncSearch<'tDocument> option
    }


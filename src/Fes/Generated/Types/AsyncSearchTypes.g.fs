// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module AsyncSearchTypes =

    type AsyncSearch<'tDocument> = {
        [<System.Text.Json.Serialization.JsonPropertyName("aggregations")>]
        Aggregations: Map<Types.AggregateName, TypesAggregations.Aggregate> option
        [<System.Text.Json.Serialization.JsonPropertyName("_clusters")>]
        Clusters: Types.ClusterStatistics option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("hits")>]
        Hits: GlobalSearchTypes.HitsMetadata<'tDocument>
        [<System.Text.Json.Serialization.JsonPropertyName("max_score")>]
        MaxScore: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("num_reduce_phases")>]
        NumReducePhases: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("profile")>]
        Profile: GlobalSearchTypes.Profile option
        [<System.Text.Json.Serialization.JsonPropertyName("pit_id")>]
        PitId: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("_scroll_id")>]
        ScrollId: Types.ScrollId option
        [<System.Text.Json.Serialization.JsonPropertyName("_shards")>]
        Shards: Types.ShardStatistics
        [<System.Text.Json.Serialization.JsonPropertyName("suggest")>]
        Suggest: Map<Types.SuggestionName, GlobalSearchTypes.Suggest<'tDocument> list> option
        [<System.Text.Json.Serialization.JsonPropertyName("terminated_early")>]
        TerminatedEarly: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("timed_out")>]
        TimedOut: bool
        [<System.Text.Json.Serialization.JsonPropertyName("took")>]
        Took: Types.Long
    }

    type AsyncSearchResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("is_partial")>]
        IsPartial: bool
        [<System.Text.Json.Serialization.JsonPropertyName("is_running")>]
        IsRunning: bool
        [<System.Text.Json.Serialization.JsonPropertyName("expiration_time")>]
        ExpirationTime: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("expiration_time_in_millis")>]
        ExpirationTimeInMillis: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("start_time")>]
        StartTime: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("start_time_in_millis")>]
        StartTimeInMillis: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("completion_time")>]
        CompletionTime: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("completion_time_in_millis")>]
        CompletionTimeInMillis: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: Types.ErrorCause option
    }

    type AsyncSearchDocumentResponseBase<'tDocument> = {
        [<System.Text.Json.Serialization.JsonPropertyName("response")>]
        Response: AsyncSearchTypes.AsyncSearch<'tDocument>
    }

    type AsyncSearchResponseException<'tDocument> = {
        [<System.Text.Json.Serialization.JsonPropertyName("is_partial")>]
        IsPartial: bool
        [<System.Text.Json.Serialization.JsonPropertyName("is_running")>]
        IsRunning: bool
        [<System.Text.Json.Serialization.JsonPropertyName("expiration_time")>]
        ExpirationTime: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("expiration_time_in_millis")>]
        ExpirationTimeInMillis: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("start_time")>]
        StartTime: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("start_time_in_millis")>]
        StartTimeInMillis: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("completion_time")>]
        CompletionTime: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("completion_time_in_millis")>]
        CompletionTimeInMillis: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: Types.ErrorCause option
        [<System.Text.Json.Serialization.JsonPropertyName("response")>]
        Response: AsyncSearchTypes.AsyncSearch<'tDocument> option
    }


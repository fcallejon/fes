// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module EqlTypes =

    type HitsEvent<'tEvent> = {
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: 'tEvent
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<Types.Field, System.Text.Json.JsonElement list> option
    }

    type HitsSequence<'tEvent> = {
        [<System.Text.Json.Serialization.JsonPropertyName("events")>]
        Events: EqlTypes.HitsEvent<'tEvent> list
        [<System.Text.Json.Serialization.JsonPropertyName("join_keys")>]
        JoinKeys: System.Text.Json.JsonElement list option
    }

    type EqlHits<'tEvent> = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: GlobalSearchTypes.TotalHits option
        [<System.Text.Json.Serialization.JsonPropertyName("events")>]
        Events: EqlTypes.HitsEvent<'tEvent> list option
        [<System.Text.Json.Serialization.JsonPropertyName("sequences")>]
        Sequences: EqlTypes.HitsSequence<'tEvent> list option
    }

    type EqlSearchResponseBase<'tEvent> = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("is_partial")>]
        IsPartial: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("is_running")>]
        IsRunning: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("took")>]
        Took: Types.DurationValue<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("timed_out")>]
        TimedOut: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("hits")>]
        Hits: EqlTypes.EqlHits<'tEvent>
        [<System.Text.Json.Serialization.JsonPropertyName("shard_failures")>]
        ShardFailures: Types.ShardFailure list option
    }


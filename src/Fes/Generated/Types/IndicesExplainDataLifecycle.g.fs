// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesExplainDataLifecycle =

    type DataStreamLifecycleExplain = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("managed_by_lifecycle")>]
        ManagedByLifecycle: bool
        [<System.Text.Json.Serialization.JsonPropertyName("index_creation_date_millis")>]
        IndexCreationDateMillis: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("time_since_index_creation")>]
        TimeSinceIndexCreation: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("rollover_date_millis")>]
        RolloverDateMillis: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("time_since_rollover")>]
        TimeSinceRollover: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle")>]
        Lifecycle: IndicesTypes.DataStreamLifecycleWithRollover option
        [<System.Text.Json.Serialization.JsonPropertyName("generation_time")>]
        GenerationTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: string option
    }


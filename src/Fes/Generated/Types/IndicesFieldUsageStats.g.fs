// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesFieldUsageStats =

    type InvertedIndex = {
        [<System.Text.Json.Serialization.JsonPropertyName("terms")>]
        Terms: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("postings")>]
        Postings: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("proximity")>]
        Proximity: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("positions")>]
        Positions: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("term_frequencies")>]
        TermFrequencies: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("offsets")>]
        Offsets: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("payloads")>]
        Payloads: CoreTypes.Uint
    }

    type FieldSummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("any")>]
        Any: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("stored_fields")>]
        StoredFields: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("doc_values")>]
        DocValues: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("points")>]
        Points: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("norms")>]
        Norms: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("term_vectors")>]
        TermVectors: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("knn_vectors")>]
        KnnVectors: CoreTypes.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("inverted_index")>]
        InvertedIndex: InvertedIndex
    }

    type FieldsUsageBody = {
        [<System.Text.Json.Serialization.JsonPropertyName("_shards")>]
        Shards: CoreTypes.ShardStatistics
    }

    type ShardsStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("all_fields")>]
        AllFields: FieldSummary
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<CoreTypes.Field, FieldSummary>
    }

    type UsageStatsShards = {
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: IndicesStats.ShardRouting
        [<System.Text.Json.Serialization.JsonPropertyName("stats")>]
        Stats: ShardsStats
        [<System.Text.Json.Serialization.JsonPropertyName("tracking_id")>]
        TrackingId: string
        [<System.Text.Json.Serialization.JsonPropertyName("tracking_started_at_millis")>]
        TrackingStartedAtMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis>
    }

    type UsageStatsIndex = {
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: UsageStatsShards list
    }


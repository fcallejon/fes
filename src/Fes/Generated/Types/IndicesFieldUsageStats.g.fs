// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesFieldUsageStats =

    type InvertedIndex = {
        [<System.Text.Json.Serialization.JsonPropertyName("terms")>]
        Terms: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("postings")>]
        Postings: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("proximity")>]
        Proximity: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("positions")>]
        Positions: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("term_frequencies")>]
        TermFrequencies: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("offsets")>]
        Offsets: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("payloads")>]
        Payloads: Types.Uint
    }

    type FieldSummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("any")>]
        Any: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("stored_fields")>]
        StoredFields: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("doc_values")>]
        DocValues: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("points")>]
        Points: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("norms")>]
        Norms: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("term_vectors")>]
        TermVectors: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("knn_vectors")>]
        KnnVectors: Types.Uint
        [<System.Text.Json.Serialization.JsonPropertyName("inverted_index")>]
        InvertedIndex: IndicesFieldUsageStats.InvertedIndex
    }

    type FieldsUsageBody = {
        [<System.Text.Json.Serialization.JsonPropertyName("_shards")>]
        Shards: Types.ShardStatistics
    }

    type ShardsStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("all_fields")>]
        AllFields: IndicesFieldUsageStats.FieldSummary
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<Types.Field, IndicesFieldUsageStats.FieldSummary>
    }

    type UsageStatsShards = {
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: IndicesStats.ShardRouting
        [<System.Text.Json.Serialization.JsonPropertyName("stats")>]
        Stats: IndicesFieldUsageStats.ShardsStats
        [<System.Text.Json.Serialization.JsonPropertyName("tracking_id")>]
        TrackingId: string
        [<System.Text.Json.Serialization.JsonPropertyName("tracking_started_at_millis")>]
        TrackingStartedAtMillis: Types.EpochTime<Types.UnitMillis>
    }

    type UsageStatsIndex = {
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: IndicesFieldUsageStats.UsageStatsShards list
    }


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesRollover =

    type RolloverConditions = {
        [<System.Text.Json.Serialization.JsonPropertyName("min_age")>]
        MinAge: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("max_age")>]
        MaxAge: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("max_age_millis")>]
        MaxAgeMillis: Types.DurationValue<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("min_docs")>]
        MinDocs: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("max_docs")>]
        MaxDocs: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("max_size")>]
        MaxSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("max_size_bytes")>]
        MaxSizeBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("min_size")>]
        MinSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("min_size_bytes")>]
        MinSizeBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("max_primary_shard_size")>]
        MaxPrimaryShardSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("max_primary_shard_size_bytes")>]
        MaxPrimaryShardSizeBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("min_primary_shard_size")>]
        MinPrimaryShardSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("min_primary_shard_size_bytes")>]
        MinPrimaryShardSizeBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("max_primary_shard_docs")>]
        MaxPrimaryShardDocs: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("min_primary_shard_docs")>]
        MinPrimaryShardDocs: Types.Long option
    }


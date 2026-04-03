// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesRollover =

    type RolloverConditions = {
        [<System.Text.Json.Serialization.JsonPropertyName("min_age")>]
        MinAge: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("max_age")>]
        MaxAge: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("max_age_millis")>]
        MaxAgeMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("min_docs")>]
        MinDocs: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("max_docs")>]
        MaxDocs: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("max_size")>]
        MaxSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("max_size_bytes")>]
        MaxSizeBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("min_size")>]
        MinSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("min_size_bytes")>]
        MinSizeBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("max_primary_shard_size")>]
        MaxPrimaryShardSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("max_primary_shard_size_bytes")>]
        MaxPrimaryShardSizeBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("min_primary_shard_size")>]
        MinPrimaryShardSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("min_primary_shard_size_bytes")>]
        MinPrimaryShardSizeBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("max_primary_shard_docs")>]
        MaxPrimaryShardDocs: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("min_primary_shard_docs")>]
        MinPrimaryShardDocs: CoreTypes.Long option
    }


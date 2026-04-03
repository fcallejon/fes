// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SearchableSnapshotsCacheStats =

    type Shared = {
        [<System.Text.Json.Serialization.JsonPropertyName("reads")>]
        Reads: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("bytes_read_in_bytes")>]
        BytesReadInBytes: Types.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("writes")>]
        Writes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("bytes_written_in_bytes")>]
        BytesWrittenInBytes: Types.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("evictions")>]
        Evictions: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("num_regions")>]
        NumRegions: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("size_in_bytes")>]
        SizeInBytes: Types.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("region_size_in_bytes")>]
        RegionSizeInBytes: Types.ByteSize
    }

    type Node = {
        [<System.Text.Json.Serialization.JsonPropertyName("shared_cache")>]
        SharedCache: SearchableSnapshotsCacheStats.Shared
    }


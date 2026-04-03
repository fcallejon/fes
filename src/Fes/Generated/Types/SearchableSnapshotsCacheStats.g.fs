// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SearchableSnapshotsCacheStats =

    type Shared = {
        [<System.Text.Json.Serialization.JsonPropertyName("reads")>]
        Reads: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("bytes_read_in_bytes")>]
        BytesReadInBytes: CoreTypes.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("writes")>]
        Writes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("bytes_written_in_bytes")>]
        BytesWrittenInBytes: CoreTypes.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("evictions")>]
        Evictions: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("num_regions")>]
        NumRegions: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("size_in_bytes")>]
        SizeInBytes: CoreTypes.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("region_size_in_bytes")>]
        RegionSizeInBytes: CoreTypes.ByteSize
    }

    type Node = {
        [<System.Text.Json.Serialization.JsonPropertyName("shared_cache")>]
        SharedCache: Shared
    }


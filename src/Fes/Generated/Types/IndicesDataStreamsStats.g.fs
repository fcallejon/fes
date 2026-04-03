// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesDataStreamsStats =

    type DataStreamsStatsItem = {
        [<System.Text.Json.Serialization.JsonPropertyName("backing_indices")>]
        BackingIndices: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("data_stream")>]
        DataStream: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("maximum_timestamp")>]
        MaximumTimestamp: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("store_size")>]
        StoreSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("store_size_bytes")>]
        StoreSizeBytes: CoreTypes.Long
    }


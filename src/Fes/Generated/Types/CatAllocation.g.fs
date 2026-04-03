// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatAllocation =

    type AllocationRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: string option
        [<System.Text.Json.Serialization.JsonPropertyName("shards.undesired")>]
        ShardsUndesired: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("write_load.forecast")>]
        WriteLoadForecast: CoreTypes.Stringified<CoreTypes.Double> option option
        [<System.Text.Json.Serialization.JsonPropertyName("disk.indices.forecast")>]
        DiskIndicesForecast: CoreTypes.ByteSize option option
        [<System.Text.Json.Serialization.JsonPropertyName("disk.indices")>]
        DiskIndices: CoreTypes.ByteSize option option
        [<System.Text.Json.Serialization.JsonPropertyName("disk.used")>]
        DiskUsed: CoreTypes.ByteSize option option
        [<System.Text.Json.Serialization.JsonPropertyName("disk.avail")>]
        DiskAvail: CoreTypes.ByteSize option option
        [<System.Text.Json.Serialization.JsonPropertyName("disk.total")>]
        DiskTotal: CoreTypes.ByteSize option option
        [<System.Text.Json.Serialization.JsonPropertyName("disk.percent")>]
        DiskPercent: CoreTypes.Percentage option option
        [<System.Text.Json.Serialization.JsonPropertyName("host")>]
        Host: CoreTypes.Host option option
        [<System.Text.Json.Serialization.JsonPropertyName("ip")>]
        Ip: CoreTypes.Ip option option
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: string option
        [<System.Text.Json.Serialization.JsonPropertyName("node.role")>]
        NodeRole: string option option
    }


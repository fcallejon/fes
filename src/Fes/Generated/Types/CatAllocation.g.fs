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
        WriteLoadForecast: SpecUtils.Stringified<Types.Double> option option
        [<System.Text.Json.Serialization.JsonPropertyName("disk.indices.forecast")>]
        DiskIndicesForecast: Types.ByteSize option option
        [<System.Text.Json.Serialization.JsonPropertyName("disk.indices")>]
        DiskIndices: Types.ByteSize option option
        [<System.Text.Json.Serialization.JsonPropertyName("disk.used")>]
        DiskUsed: Types.ByteSize option option
        [<System.Text.Json.Serialization.JsonPropertyName("disk.avail")>]
        DiskAvail: Types.ByteSize option option
        [<System.Text.Json.Serialization.JsonPropertyName("disk.total")>]
        DiskTotal: Types.ByteSize option option
        [<System.Text.Json.Serialization.JsonPropertyName("disk.percent")>]
        DiskPercent: Types.Percentage option option
        [<System.Text.Json.Serialization.JsonPropertyName("host")>]
        Host: Types.Host option option
        [<System.Text.Json.Serialization.JsonPropertyName("ip")>]
        Ip: Types.Ip option option
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: string option
        [<System.Text.Json.Serialization.JsonPropertyName("node.role")>]
        NodeRole: string option option
    }


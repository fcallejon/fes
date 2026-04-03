// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatHealth =

    type HealthRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("epoch")>]
        Epoch: SpecUtils.Stringified<Types.EpochTime<Types.UnitSeconds>> option
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.TimeOfDay option
        [<System.Text.Json.Serialization.JsonPropertyName("cluster")>]
        Cluster: string option
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: string option
        [<System.Text.Json.Serialization.JsonPropertyName("node.total")>]
        NodeTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("node.data")>]
        NodeData: string option
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pri")>]
        Pri: string option
        [<System.Text.Json.Serialization.JsonPropertyName("relo")>]
        Relo: string option
        [<System.Text.Json.Serialization.JsonPropertyName("init")>]
        Init: string option
        [<System.Text.Json.Serialization.JsonPropertyName("unassign.pri")>]
        UnassignPri: string option
        [<System.Text.Json.Serialization.JsonPropertyName("unassign")>]
        Unassign: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pending_tasks")>]
        PendingTasks: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_task_wait_time")>]
        MaxTaskWaitTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("active_shards_percent")>]
        ActiveShardsPercent: string option
    }


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module ClusterPendingTasks =

    type PendingTask = {
        [<System.Text.Json.Serialization.JsonPropertyName("executing")>]
        Executing: bool
        [<System.Text.Json.Serialization.JsonPropertyName("insert_order")>]
        InsertOrder: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("priority")>]
        Priority: string
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: string
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_queue")>]
        TimeInQueue: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_queue_millis")>]
        TimeInQueueMillis: Types.DurationValue<Types.UnitMillis>
    }


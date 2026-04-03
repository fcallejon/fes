// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatPendingTasks =

    type PendingTasksRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("insertOrder")>]
        InsertOrder: string option
        [<System.Text.Json.Serialization.JsonPropertyName("timeInQueue")>]
        TimeInQueue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("priority")>]
        Priority: string option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: string option
    }


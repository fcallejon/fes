// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalUpdateByQueryRethrottle =

    type UpdateByQueryRethrottleNode = {
        [<System.Text.Json.Serialization.JsonPropertyName("tasks")>]
        Tasks: Map<CoreTypes.TaskId, TasksTypes.TaskInfo>
    }


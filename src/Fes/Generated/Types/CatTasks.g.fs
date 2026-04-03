// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatTasks =

    type TasksRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("action")>]
        Action: string option
        [<System.Text.Json.Serialization.JsonPropertyName("task_id")>]
        TaskId: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("parent_task_id")>]
        ParentTaskId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string option
        [<System.Text.Json.Serialization.JsonPropertyName("start_time")>]
        StartTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: string option
        [<System.Text.Json.Serialization.JsonPropertyName("running_time_ns")>]
        RunningTimeNs: string option
        [<System.Text.Json.Serialization.JsonPropertyName("running_time")>]
        RunningTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("node_id")>]
        NodeId: CoreTypes.NodeId option
        [<System.Text.Json.Serialization.JsonPropertyName("ip")>]
        Ip: string option
        [<System.Text.Json.Serialization.JsonPropertyName("port")>]
        Port: string option
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: string option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("x_opaque_id")>]
        XOpaqueId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
    }


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module TasksTypes =

    [<RequireQualifiedAccess>]
    type GroupBy =
        | Nodes
        | Parents
        | None

    type TaskInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("action")>]
        Action: string
        [<System.Text.Json.Serialization.JsonPropertyName("cancelled")>]
        Cancelled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("cancellable")>]
        Cancellable: bool
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("headers")>]
        Headers: Map<string, string>
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: Types.NodeId
        [<System.Text.Json.Serialization.JsonPropertyName("running_time")>]
        RunningTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("running_time_in_nanos")>]
        RunningTimeInNanos: Types.DurationValue<Types.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("start_time_in_millis")>]
        StartTimeInMillis: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("parent_task_id")>]
        ParentTaskId: Types.TaskId option
    }

    type NodeTasks = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.NodeId option
        [<System.Text.Json.Serialization.JsonPropertyName("transport_address")>]
        TransportAddress: Types.TransportAddress option
        [<System.Text.Json.Serialization.JsonPropertyName("host")>]
        Host: Types.Host option
        [<System.Text.Json.Serialization.JsonPropertyName("ip")>]
        Ip: Types.Ip option
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("attributes")>]
        Attributes: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("tasks")>]
        Tasks: Map<Types.TaskId, TasksTypes.TaskInfo>
    }

    type ParentTaskInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("children")>]
        Children: TasksTypes.TaskInfo list option
    }

    [<RequireQualifiedAccess>]
    type TaskInfos =
        | Array of TasksTypes.TaskInfo list
        | Dictionary of Map<string, TasksTypes.ParentTaskInfo>

    type TaskListResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("node_failures")>]
        NodeFailures: Types.ErrorCause list option
        [<System.Text.Json.Serialization.JsonPropertyName("task_failures")>]
        TaskFailures: Types.TaskFailure list option
        [<System.Text.Json.Serialization.JsonPropertyName("nodes")>]
        Nodes: Map<string, TasksTypes.NodeTasks> option
        [<System.Text.Json.Serialization.JsonPropertyName("tasks")>]
        Tasks: TasksTypes.TaskInfos option
    }


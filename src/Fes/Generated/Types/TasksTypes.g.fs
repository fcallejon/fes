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
        Id: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: CoreTypes.NodeId
        [<System.Text.Json.Serialization.JsonPropertyName("running_time")>]
        RunningTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("running_time_in_nanos")>]
        RunningTimeInNanos: CoreTypes.DurationValue<CoreTypes.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("start_time_in_millis")>]
        StartTimeInMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("parent_task_id")>]
        ParentTaskId: CoreTypes.TaskId option
    }

    type NodeTasks = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.NodeId option
        [<System.Text.Json.Serialization.JsonPropertyName("transport_address")>]
        TransportAddress: CoreTypes.TransportAddress option
        [<System.Text.Json.Serialization.JsonPropertyName("host")>]
        Host: CoreTypes.Host option
        [<System.Text.Json.Serialization.JsonPropertyName("ip")>]
        Ip: CoreTypes.Ip option
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("attributes")>]
        Attributes: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("tasks")>]
        Tasks: Map<CoreTypes.TaskId, TaskInfo>
    }

    type ParentTaskInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("children")>]
        Children: TaskInfo list option
    }

    [<RequireQualifiedAccess>]
    type TaskInfos =
        | Array of TaskInfo list
        | Dictionary of Map<string, ParentTaskInfo>

    type TaskListResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("node_failures")>]
        NodeFailures: CoreTypes.ErrorCause list option
        [<System.Text.Json.Serialization.JsonPropertyName("task_failures")>]
        TaskFailures: CoreTypes.TaskFailure list option
        [<System.Text.Json.Serialization.JsonPropertyName("nodes")>]
        Nodes: Map<string, NodeTasks> option
        [<System.Text.Json.Serialization.JsonPropertyName("tasks")>]
        Tasks: TaskInfos option
    }


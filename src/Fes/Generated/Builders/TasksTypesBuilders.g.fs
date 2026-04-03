// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module TasksTypesBuilders =

    type NodeTasksBuilder() =
        member _.Yield(_: unit) : Types.NodeTasks =
            {
                Name = None
                TransportAddress = None
                Host = None
                Ip = None
                Roles = None
                Attributes = None
                Tasks = Unchecked.defaultof<_>
            }

        [<CustomOperation("name")>]
        member _.Name(state: Types.NodeTasks, value: Types.NodeId) =
            { state with Name = Some value }

        [<CustomOperation("transportAddress")>]
        member _.TransportAddress(state: Types.NodeTasks, value: Types.TransportAddress) =
            { state with TransportAddress = Some value }

        [<CustomOperation("host")>]
        member _.Host(state: Types.NodeTasks, value: Types.Host) =
            { state with Host = Some value }

        [<CustomOperation("ip")>]
        member _.Ip(state: Types.NodeTasks, value: Types.Ip) =
            { state with Ip = Some value }

        [<CustomOperation("roles")>]
        member _.Roles(state: Types.NodeTasks, value: string list) =
            { state with Roles = Some value }

        [<CustomOperation("attributes")>]
        member _.Attributes(state: Types.NodeTasks, value: Map<string, string>) =
            { state with Attributes = Some value }

        [<CustomOperation("tasks")>]
        member _.Tasks(state: Types.NodeTasks, value: Map<Types.TaskId, Types.TaskInfo>) =
            { state with Tasks = value }

    let nodeTasks = NodeTasksBuilder()

    type TaskInfoBuilder() =
        member _.Yield(_: unit) : Types.TaskInfo =
            {
                Action = Unchecked.defaultof<_>
                Cancelled = None
                Cancellable = Unchecked.defaultof<_>
                Description = None
                Headers = Unchecked.defaultof<_>
                Id = Unchecked.defaultof<_>
                Node = Unchecked.defaultof<_>
                RunningTime = None
                RunningTimeInNanos = Unchecked.defaultof<_>
                StartTimeInMillis = Unchecked.defaultof<_>
                Status = None
                Type = Unchecked.defaultof<_>
                ParentTaskId = None
            }

        [<CustomOperation("action")>]
        member _.Action(state: Types.TaskInfo, value: string) =
            { state with Action = value }

        [<CustomOperation("cancelled")>]
        member _.Cancelled(state: Types.TaskInfo, value: bool) =
            { state with Cancelled = Some value }

        [<CustomOperation("cancellable")>]
        member _.Cancellable(state: Types.TaskInfo, value: bool) =
            { state with Cancellable = value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.TaskInfo, value: string) =
            { state with Description = Some value }

        [<CustomOperation("headers")>]
        member _.Headers(state: Types.TaskInfo, value: Map<string, string>) =
            { state with Headers = value }

        [<CustomOperation("id")>]
        member _.Id(state: Types.TaskInfo, value: Types.Long) =
            { state with Id = value }

        [<CustomOperation("node")>]
        member _.Node(state: Types.TaskInfo, value: Types.NodeId) =
            { state with Node = value }

        [<CustomOperation("runningTime")>]
        member _.RunningTime(state: Types.TaskInfo, value: Types.Duration) =
            { state with RunningTime = Some value }

        [<CustomOperation("runningTimeInNanos")>]
        member _.RunningTimeInNanos(state: Types.TaskInfo, value: Types.DurationValue<Types.UnitNanos>) =
            { state with RunningTimeInNanos = value }

        [<CustomOperation("startTimeInMillis")>]
        member _.StartTimeInMillis(state: Types.TaskInfo, value: Types.EpochTime<Types.UnitMillis>) =
            { state with StartTimeInMillis = value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.TaskInfo, value: System.Text.Json.JsonElement) =
            { state with Status = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.TaskInfo, value: string) =
            { state with Type = value }

        [<CustomOperation("parentTaskId")>]
        member _.ParentTaskId(state: Types.TaskInfo, value: Types.TaskId) =
            { state with ParentTaskId = Some value }

    let taskInfo = TaskInfoBuilder()

    type TaskListResponseBaseBuilder() =
        member _.Yield(_: unit) : Types.TaskListResponseBase =
            {
                NodeFailures = None
                TaskFailures = None
                Nodes = None
                Tasks = None
            }

        [<CustomOperation("nodeFailures")>]
        member _.NodeFailures(state: Types.TaskListResponseBase, value: Types.ErrorCause list) =
            { state with NodeFailures = Some value }

        [<CustomOperation("taskFailures")>]
        member _.TaskFailures(state: Types.TaskListResponseBase, value: Types.TaskFailure list) =
            { state with TaskFailures = Some value }

        [<CustomOperation("nodes")>]
        member _.Nodes(state: Types.TaskListResponseBase, value: Map<string, Types.NodeTasks>) =
            { state with Nodes = Some value }

        [<CustomOperation("tasks")>]
        member _.Tasks(state: Types.TaskListResponseBase, value: Types.TaskInfos) =
            { state with Tasks = Some value }

    let taskListResponseBase = TaskListResponseBaseBuilder()


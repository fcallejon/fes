// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module CatTasksBuilders =

    type TasksRecordBuilder() =
        member _.Yield(_: unit) : Types.TasksRecord =
            {
                Id = None
                Action = None
                TaskId = None
                ParentTaskId = None
                Type = None
                StartTime = None
                Timestamp = None
                RunningTimeNs = None
                RunningTime = None
                NodeId = None
                Ip = None
                Port = None
                Node = None
                Version = None
                XOpaqueId = None
                Description = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.TasksRecord, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("action")>]
        member _.Action(state: Types.TasksRecord, value: string) =
            { state with Action = Some value }

        [<CustomOperation("taskId")>]
        member _.TaskId(state: Types.TasksRecord, value: Types.Id) =
            { state with TaskId = Some value }

        [<CustomOperation("parentTaskId")>]
        member _.ParentTaskId(state: Types.TasksRecord, value: string) =
            { state with ParentTaskId = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.TasksRecord, value: string) =
            { state with Type = Some value }

        [<CustomOperation("startTime")>]
        member _.StartTime(state: Types.TasksRecord, value: string) =
            { state with StartTime = Some value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: Types.TasksRecord, value: string) =
            { state with Timestamp = Some value }

        [<CustomOperation("runningTimeNs")>]
        member _.RunningTimeNs(state: Types.TasksRecord, value: string) =
            { state with RunningTimeNs = Some value }

        [<CustomOperation("runningTime")>]
        member _.RunningTime(state: Types.TasksRecord, value: string) =
            { state with RunningTime = Some value }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: Types.TasksRecord, value: Types.NodeId) =
            { state with NodeId = Some value }

        [<CustomOperation("ip")>]
        member _.Ip(state: Types.TasksRecord, value: string) =
            { state with Ip = Some value }

        [<CustomOperation("port")>]
        member _.Port(state: Types.TasksRecord, value: string) =
            { state with Port = Some value }

        [<CustomOperation("node")>]
        member _.Node(state: Types.TasksRecord, value: string) =
            { state with Node = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.TasksRecord, value: Types.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("xOpaqueId")>]
        member _.XOpaqueId(state: Types.TasksRecord, value: string) =
            { state with XOpaqueId = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.TasksRecord, value: string) =
            { state with Description = Some value }

    let tasksRecord = TasksRecordBuilder()


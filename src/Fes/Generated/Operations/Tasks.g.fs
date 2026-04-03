// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module TasksOperations =

    type TasksCancelRequest = {
        TaskId: CoreTypes.TaskId
        Actions: System.Text.Json.JsonElement option
        Nodes: string list option
        ParentTaskId: string option
        WaitForCompletion: bool option
    }

        with
        static member ToRequest(req: TasksCancelRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_tasks/{req.TaskId}/_cancel"
                let queryParams =
                    [
                        req.Actions |> Option.map (fun v -> "actions", Fes.Http.toQueryValue v)
                        req.Nodes |> Option.map (fun v -> "nodes", Fes.Http.toQueryValue v)
                        req.ParentTaskId |> Option.map (fun v -> "parent_task_id", Fes.Http.toQueryValue v)
                        req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type TasksCancelResponse = TasksTypes.TaskListResponseBase

    type TasksCancelRequestBuilder() =
        member _.Yield(_: unit) : TasksCancelRequest =
            {
                TaskId = Unchecked.defaultof<_>
                Actions = None
                Nodes = None
                ParentTaskId = None
                WaitForCompletion = None
            }

        [<CustomOperation("taskId")>]
        member _.TaskId(state: TasksCancelRequest, value: CoreTypes.TaskId) =
            { state with TaskId = value }

        [<CustomOperation("actions")>]
        member _.Actions(state: TasksCancelRequest, value: System.Text.Json.JsonElement) =
            { state with Actions = Some value }

        [<CustomOperation("nodes")>]
        member _.Nodes(state: TasksCancelRequest, value: string list) =
            { state with Nodes = Some value }

        [<CustomOperation("parentTaskId")>]
        member _.ParentTaskId(state: TasksCancelRequest, value: string) =
            { state with ParentTaskId = Some value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: TasksCancelRequest, value: bool) =
            { state with WaitForCompletion = Some value }

    let tasksCancelRequest = TasksCancelRequestBuilder()

    module Cancel =
        let withActions (value: System.Text.Json.JsonElement) (req: TasksCancelRequest) =
            { req with Actions = Some value }
        let withNodes (value: string list) (req: TasksCancelRequest) =
            { req with Nodes = Some value }
        let withParentTaskId (value: string) (req: TasksCancelRequest) =
            { req with ParentTaskId = Some value }
        let withWaitForCompletion (value: bool) (req: TasksCancelRequest) =
            { req with WaitForCompletion = Some value }

    type TasksGetRequest = {
        TaskId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        WaitForCompletion: bool option
    }

        with
        static member ToRequest(req: TasksGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_tasks/{req.TaskId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type TasksGetResponse = System.Text.Json.JsonElement

    type TasksGetRequestBuilder() =
        member _.Yield(_: unit) : TasksGetRequest =
            {
                TaskId = Unchecked.defaultof<_>
                Timeout = None
                WaitForCompletion = None
            }

        [<CustomOperation("taskId")>]
        member _.TaskId(state: TasksGetRequest, value: CoreTypes.Id) =
            { state with TaskId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TasksGetRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: TasksGetRequest, value: bool) =
            { state with WaitForCompletion = Some value }

    let tasksGetRequest = TasksGetRequestBuilder()

    module Get =
        let withTimeout (value: CoreTypes.Duration) (req: TasksGetRequest) =
            { req with Timeout = Some value }
        let withWaitForCompletion (value: bool) (req: TasksGetRequest) =
            { req with WaitForCompletion = Some value }

    type TasksListRequest = {
        Actions: System.Text.Json.JsonElement option
        Detailed: bool option
        GroupBy: TasksTypes.GroupBy option
        Nodes: CoreTypes.NodeIds option
        ParentTaskId: CoreTypes.Id option
        Timeout: CoreTypes.Duration option
        WaitForCompletion: bool option
    }

        with
        static member ToRequest(req: TasksListRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_tasks"
                let queryParams =
                    [
                        req.Actions |> Option.map (fun v -> "actions", Fes.Http.toQueryValue v)
                        req.Detailed |> Option.map (fun v -> "detailed", Fes.Http.toQueryValue v)
                        req.GroupBy |> Option.map (fun v -> "group_by", Fes.Http.toQueryValue v)
                        req.Nodes |> Option.map (fun v -> "nodes", Fes.Http.toQueryValue v)
                        req.ParentTaskId |> Option.map (fun v -> "parent_task_id", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type TasksListResponse = TasksTypes.TaskListResponseBase

    type TasksListRequestBuilder() =
        member _.Yield(_: unit) : TasksListRequest =
            {
                Actions = None
                Detailed = None
                GroupBy = None
                Nodes = None
                ParentTaskId = None
                Timeout = None
                WaitForCompletion = None
            }

        [<CustomOperation("actions")>]
        member _.Actions(state: TasksListRequest, value: System.Text.Json.JsonElement) =
            { state with Actions = Some value }

        [<CustomOperation("detailed")>]
        member _.Detailed(state: TasksListRequest, value: bool) =
            { state with Detailed = Some value }

        [<CustomOperation("groupBy")>]
        member _.GroupBy(state: TasksListRequest, value: TasksTypes.GroupBy) =
            { state with GroupBy = Some value }

        [<CustomOperation("nodes")>]
        member _.Nodes(state: TasksListRequest, value: CoreTypes.NodeIds) =
            { state with Nodes = Some value }

        [<CustomOperation("parentTaskId")>]
        member _.ParentTaskId(state: TasksListRequest, value: CoreTypes.Id) =
            { state with ParentTaskId = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TasksListRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: TasksListRequest, value: bool) =
            { state with WaitForCompletion = Some value }

    let tasksListRequest = TasksListRequestBuilder()

    module List =
        let withActions (value: System.Text.Json.JsonElement) (req: TasksListRequest) =
            { req with Actions = Some value }
        let withDetailed (value: bool) (req: TasksListRequest) =
            { req with Detailed = Some value }
        let withGroupBy (value: TasksTypes.GroupBy) (req: TasksListRequest) =
            { req with GroupBy = Some value }
        let withNodes (value: CoreTypes.NodeIds) (req: TasksListRequest) =
            { req with Nodes = Some value }
        let withParentTaskId (value: CoreTypes.Id) (req: TasksListRequest) =
            { req with ParentTaskId = Some value }
        let withTimeout (value: CoreTypes.Duration) (req: TasksListRequest) =
            { req with Timeout = Some value }
        let withWaitForCompletion (value: bool) (req: TasksListRequest) =
            { req with WaitForCompletion = Some value }


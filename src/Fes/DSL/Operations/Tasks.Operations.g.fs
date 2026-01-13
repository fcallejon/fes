// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module TasksOperations =

    type TasksCancelRequest = {
        [<JsonPropertyName("task_id")>]
        TaskId: TaskId
        [<JsonPropertyName("actions")>]
        Actions: System.Text.Json.JsonElement option
        [<JsonPropertyName("nodes")>]
        Nodes: string array option
        [<JsonPropertyName("parent_task_id")>]
        ParentTaskId: string option
        [<JsonPropertyName("wait_for_completion")>]
        WaitForCompletion: bool option
    } with
        static member ToRequest(request: TasksCancelRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_tasks/{request.TaskId}/_cancel"
                let queryParams =
                    [
                        request.Actions |> Option.map (fun v -> "actions", string v)
                        request.Nodes |> Option.map (fun v -> "nodes", string v)
                        request.ParentTaskId |> Option.map (fun v -> "parent_task_id", string v)
                        request.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module TasksCancelRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: TasksCancelRequest) : Result<Fes.Http.RequestMsg, exn> =
            TasksCancelRequest.ToRequest request

    type TasksCancelRequestBuilder() =
        member _.Yield(_: unit) : TasksCancelRequest =
            {
                TasksCancelRequest.TaskId = Unchecked.defaultof<TaskId>
                TasksCancelRequest.Actions = Option.None
                TasksCancelRequest.Nodes = Option.None
                TasksCancelRequest.ParentTaskId = Option.None
                TasksCancelRequest.WaitForCompletion = Option.None
            } : TasksCancelRequest

        [<CustomOperation("task_id")>]
        member _.TaskId(state: TasksCancelRequest, value: TaskId) =
            { state with TasksCancelRequest.TaskId = value } : TasksCancelRequest

        [<CustomOperation("actions")>]
        member _.Actions(state: TasksCancelRequest, value: System.Text.Json.JsonElement) =
            { state with TasksCancelRequest.Actions = Option.Some value } : TasksCancelRequest

        [<CustomOperation("nodes")>]
        member _.Nodes(state: TasksCancelRequest, value: string array) =
            { state with TasksCancelRequest.Nodes = Option.Some value } : TasksCancelRequest

        [<CustomOperation("parent_task_id")>]
        member _.ParentTaskId(state: TasksCancelRequest, value: string) =
            { state with TasksCancelRequest.ParentTaskId = Option.Some value } : TasksCancelRequest

        [<CustomOperation("wait_for_completion")>]
        member _.WaitForCompletion(state: TasksCancelRequest, value: bool) =
            { state with TasksCancelRequest.WaitForCompletion = Option.Some value } : TasksCancelRequest

    let tasksCancelRequest = TasksCancelRequestBuilder()

    type TasksGetRequest = {
        [<JsonPropertyName("task_id")>]
        TaskId: Id
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
        [<JsonPropertyName("wait_for_completion")>]
        WaitForCompletion: bool option
    } with
        static member ToRequest(request: TasksGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_tasks/{request.TaskId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                        request.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module TasksGetRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: TasksGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            TasksGetRequest.ToRequest request

    type TasksGetRequestBuilder() =
        member _.Yield(_: unit) : TasksGetRequest =
            {
                TasksGetRequest.TaskId = Unchecked.defaultof<Id>
                TasksGetRequest.Timeout = Option.None
                TasksGetRequest.WaitForCompletion = Option.None
            } : TasksGetRequest

        [<CustomOperation("task_id")>]
        member _.TaskId(state: TasksGetRequest, value: Id) =
            { state with TasksGetRequest.TaskId = value } : TasksGetRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TasksGetRequest, value: Duration) =
            { state with TasksGetRequest.Timeout = Option.Some value } : TasksGetRequest

        [<CustomOperation("wait_for_completion")>]
        member _.WaitForCompletion(state: TasksGetRequest, value: bool) =
            { state with TasksGetRequest.WaitForCompletion = Option.Some value } : TasksGetRequest

    let tasksGetRequest = TasksGetRequestBuilder()

    type TasksGetResponse = {
        [<JsonPropertyName("completed")>]
        Completed: bool
        [<JsonPropertyName("task")>]
        Task: TypesTaskInfo
        [<JsonPropertyName("response")>]
        Response: obj option
        [<JsonPropertyName("error")>]
        Error: ErrorCause option
    }

    type TasksListRequest = {
        [<JsonPropertyName("actions")>]
        Actions: System.Text.Json.JsonElement option
        [<JsonPropertyName("detailed")>]
        Detailed: bool option
        [<JsonPropertyName("group_by")>]
        GroupBy: TypesGroupBy option
        [<JsonPropertyName("nodes")>]
        Nodes: NodeIds option
        [<JsonPropertyName("parent_task_id")>]
        ParentTaskId: Id option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
        [<JsonPropertyName("wait_for_completion")>]
        WaitForCompletion: bool option
    } with
        static member ToRequest(request: TasksListRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_tasks"
                let queryParams =
                    [
                        request.Actions |> Option.map (fun v -> "actions", string v)
                        request.Detailed |> Option.map (fun v -> "detailed", string v)
                        request.GroupBy |> Option.map (fun v -> "group_by", string v)
                        request.Nodes |> Option.map (fun v -> "nodes", string v)
                        request.ParentTaskId |> Option.map (fun v -> "parent_task_id", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                        request.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module TasksListRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: TasksListRequest) : Result<Fes.Http.RequestMsg, exn> =
            TasksListRequest.ToRequest request

    type TasksListRequestBuilder() =
        member _.Yield(_: unit) : TasksListRequest =
            {
                TasksListRequest.Actions = Option.None
                TasksListRequest.Detailed = Option.None
                TasksListRequest.GroupBy = Option.None
                TasksListRequest.Nodes = Option.None
                TasksListRequest.ParentTaskId = Option.None
                TasksListRequest.Timeout = Option.None
                TasksListRequest.WaitForCompletion = Option.None
            } : TasksListRequest

        [<CustomOperation("actions")>]
        member _.Actions(state: TasksListRequest, value: System.Text.Json.JsonElement) =
            { state with TasksListRequest.Actions = Option.Some value } : TasksListRequest

        [<CustomOperation("detailed")>]
        member _.Detailed(state: TasksListRequest, value: bool) =
            { state with TasksListRequest.Detailed = Option.Some value } : TasksListRequest

        [<CustomOperation("group_by")>]
        member _.GroupBy(state: TasksListRequest, value: TypesGroupBy) =
            { state with TasksListRequest.GroupBy = Option.Some value } : TasksListRequest

        [<CustomOperation("nodes")>]
        member _.Nodes(state: TasksListRequest, value: NodeIds) =
            { state with TasksListRequest.Nodes = Option.Some value } : TasksListRequest

        [<CustomOperation("parent_task_id")>]
        member _.ParentTaskId(state: TasksListRequest, value: Id) =
            { state with TasksListRequest.ParentTaskId = Option.Some value } : TasksListRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: TasksListRequest, value: Duration) =
            { state with TasksListRequest.Timeout = Option.Some value } : TasksListRequest

        [<CustomOperation("wait_for_completion")>]
        member _.WaitForCompletion(state: TasksListRequest, value: bool) =
            { state with TasksListRequest.WaitForCompletion = Option.Some value } : TasksListRequest

    let tasksListRequest = TasksListRequestBuilder()

    type TasksListResponse = TypesTaskListResponseBase


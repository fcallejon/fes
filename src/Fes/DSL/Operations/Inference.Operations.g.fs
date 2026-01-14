// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module InferenceOperations =

    type InferenceChatCompletionUnifiedRequest = {
        InferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("body")>]
        Body: TypesRequestChatCompletion
    } with
        static member ToRequest(request: InferenceChatCompletionUnifiedRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/chat_completion/{request.InferenceId}/_stream"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request.Body
                |> Result.Ok
            with ex -> Result.Error ex

    module InferenceChatCompletionUnifiedRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferenceChatCompletionUnifiedRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferenceChatCompletionUnifiedRequest.ToRequest request

    type InferenceChatCompletionUnifiedRequestBuilder() =
        member _.Yield(_: unit) : InferenceChatCompletionUnifiedRequest =
            {
                InferenceChatCompletionUnifiedRequest.InferenceId = Unchecked.defaultof<Id>
                InferenceChatCompletionUnifiedRequest.Timeout = Option.None
                InferenceChatCompletionUnifiedRequest.Body = Unchecked.defaultof<TypesRequestChatCompletion>
            } : InferenceChatCompletionUnifiedRequest

        [<CustomOperation("inference_id")>]
        member _.InferenceId(state: InferenceChatCompletionUnifiedRequest, value: Id) =
            { state with InferenceChatCompletionUnifiedRequest.InferenceId = value } : InferenceChatCompletionUnifiedRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferenceChatCompletionUnifiedRequest, value: Duration) =
            { state with InferenceChatCompletionUnifiedRequest.Timeout = Option.Some value } : InferenceChatCompletionUnifiedRequest

        [<CustomOperation("body")>]
        member _.Body(state: InferenceChatCompletionUnifiedRequest, value: TypesRequestChatCompletion) =
            { state with InferenceChatCompletionUnifiedRequest.Body = value } : InferenceChatCompletionUnifiedRequest

    let inferenceChatCompletionUnifiedRequest = InferenceChatCompletionUnifiedRequestBuilder()

    type InferenceChatCompletionUnifiedResponse = StreamResult

    type InferenceCompletionRequest = {
        InferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("input")>]
        Input: System.Text.Json.JsonElement
        [<JsonPropertyName("task_settings")>]
        TaskSettings: TypesTaskSettings option
    } with
        static member ToRequest(request: InferenceCompletionRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/completion/{request.InferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferenceCompletionRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferenceCompletionRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferenceCompletionRequest.ToRequest request

    type InferenceCompletionRequestBuilder() =
        member _.Yield(_: unit) : InferenceCompletionRequest =
            {
                InferenceCompletionRequest.InferenceId = Unchecked.defaultof<Id>
                InferenceCompletionRequest.Timeout = Option.None
                InferenceCompletionRequest.Input = Unchecked.defaultof<System.Text.Json.JsonElement>
                InferenceCompletionRequest.TaskSettings = Option.None
            } : InferenceCompletionRequest

        [<CustomOperation("inference_id")>]
        member _.InferenceId(state: InferenceCompletionRequest, value: Id) =
            { state with InferenceCompletionRequest.InferenceId = value } : InferenceCompletionRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferenceCompletionRequest, value: Duration) =
            { state with InferenceCompletionRequest.Timeout = Option.Some value } : InferenceCompletionRequest

        [<CustomOperation("input")>]
        member _.Input(state: InferenceCompletionRequest, value: System.Text.Json.JsonElement) =
            { state with InferenceCompletionRequest.Input = value } : InferenceCompletionRequest

        [<CustomOperation("task_settings")>]
        member _.TaskSettings(state: InferenceCompletionRequest, value: TypesTaskSettings) =
            { state with InferenceCompletionRequest.TaskSettings = Option.Some value } : InferenceCompletionRequest

    let inferenceCompletionRequest = InferenceCompletionRequestBuilder()

    type InferenceCompletionResponse = TypesCompletionInferenceResult

    type InferenceGetRequest = {
        TaskType: TypesTaskType
        InferenceId: Id
    } with
        static member ToRequest(request: InferenceGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.InferenceId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module InferenceGetRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferenceGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferenceGetRequest.ToRequest request

    type InferenceGetRequestBuilder() =
        member _.Yield(_: unit) : InferenceGetRequest =
            {
                InferenceGetRequest.TaskType = Unchecked.defaultof<TypesTaskType>
                InferenceGetRequest.InferenceId = Unchecked.defaultof<Id>
            } : InferenceGetRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferenceGetRequest, value: TypesTaskType) =
            { state with InferenceGetRequest.TaskType = value } : InferenceGetRequest

        [<CustomOperation("inference_id")>]
        member _.InferenceId(state: InferenceGetRequest, value: Id) =
            { state with InferenceGetRequest.InferenceId = value } : InferenceGetRequest

    let inferenceGetRequest = InferenceGetRequestBuilder()

    type InferencePutRequest = {
        TaskType: TypesTaskType
        InferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("body")>]
        Body: TypesInferenceEndpoint
    } with
        static member ToRequest(request: InferencePutRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.InferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request.Body
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutRequest.ToRequest request

    type InferencePutRequestBuilder() =
        member _.Yield(_: unit) : InferencePutRequest =
            {
                InferencePutRequest.TaskType = Unchecked.defaultof<TypesTaskType>
                InferencePutRequest.InferenceId = Unchecked.defaultof<Id>
                InferencePutRequest.Timeout = Option.None
                InferencePutRequest.Body = Unchecked.defaultof<TypesInferenceEndpoint>
            } : InferencePutRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutRequest, value: TypesTaskType) =
            { state with InferencePutRequest.TaskType = value } : InferencePutRequest

        [<CustomOperation("inference_id")>]
        member _.InferenceId(state: InferencePutRequest, value: Id) =
            { state with InferencePutRequest.InferenceId = value } : InferencePutRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutRequest, value: Duration) =
            { state with InferencePutRequest.Timeout = Option.Some value } : InferencePutRequest

        [<CustomOperation("body")>]
        member _.Body(state: InferencePutRequest, value: TypesInferenceEndpoint) =
            { state with InferencePutRequest.Body = value } : InferencePutRequest

    let inferencePutRequest = InferencePutRequestBuilder()

    type InferenceInferenceRequest = {
        TaskType: TypesTaskType
        InferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("query")>]
        Query: string option
        [<JsonPropertyName("input")>]
        Input: System.Text.Json.JsonElement
        [<JsonPropertyName("input_type")>]
        InputType: string option
        [<JsonPropertyName("task_settings")>]
        TaskSettings: TypesTaskSettings option
    } with
        static member ToRequest(request: InferenceInferenceRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.InferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferenceInferenceRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferenceInferenceRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferenceInferenceRequest.ToRequest request

    type InferenceInferenceRequestBuilder() =
        member _.Yield(_: unit) : InferenceInferenceRequest =
            {
                InferenceInferenceRequest.TaskType = Unchecked.defaultof<TypesTaskType>
                InferenceInferenceRequest.InferenceId = Unchecked.defaultof<Id>
                InferenceInferenceRequest.Timeout = Option.None
                InferenceInferenceRequest.Query = Option.None
                InferenceInferenceRequest.Input = Unchecked.defaultof<System.Text.Json.JsonElement>
                InferenceInferenceRequest.InputType = Option.None
                InferenceInferenceRequest.TaskSettings = Option.None
            } : InferenceInferenceRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferenceInferenceRequest, value: TypesTaskType) =
            { state with InferenceInferenceRequest.TaskType = value } : InferenceInferenceRequest

        [<CustomOperation("inference_id")>]
        member _.InferenceId(state: InferenceInferenceRequest, value: Id) =
            { state with InferenceInferenceRequest.InferenceId = value } : InferenceInferenceRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferenceInferenceRequest, value: Duration) =
            { state with InferenceInferenceRequest.Timeout = Option.Some value } : InferenceInferenceRequest

        [<CustomOperation("query")>]
        member _.Query(state: InferenceInferenceRequest, value: string) =
            { state with InferenceInferenceRequest.Query = Option.Some value } : InferenceInferenceRequest

        [<CustomOperation("input")>]
        member _.Input(state: InferenceInferenceRequest, value: System.Text.Json.JsonElement) =
            { state with InferenceInferenceRequest.Input = value } : InferenceInferenceRequest

        [<CustomOperation("input_type")>]
        member _.InputType(state: InferenceInferenceRequest, value: string) =
            { state with InferenceInferenceRequest.InputType = Option.Some value } : InferenceInferenceRequest

        [<CustomOperation("task_settings")>]
        member _.TaskSettings(state: InferenceInferenceRequest, value: TypesTaskSettings) =
            { state with InferenceInferenceRequest.TaskSettings = Option.Some value } : InferenceInferenceRequest

    let inferenceInferenceRequest = InferenceInferenceRequestBuilder()

    type InferenceDeleteRequest = {
        TaskType: TypesTaskType
        InferenceId: Id
        DryRun: bool option
        Force: bool option
    } with
        static member ToRequest(request: InferenceDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.InferenceId}"
                let queryParams =
                    [
                        request.DryRun |> Option.map (fun v -> "dry_run", string v)
                        request.Force |> Option.map (fun v -> "force", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module InferenceDeleteRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferenceDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferenceDeleteRequest.ToRequest request

    type InferenceDeleteRequestBuilder() =
        member _.Yield(_: unit) : InferenceDeleteRequest =
            {
                InferenceDeleteRequest.TaskType = Unchecked.defaultof<TypesTaskType>
                InferenceDeleteRequest.InferenceId = Unchecked.defaultof<Id>
                InferenceDeleteRequest.DryRun = Option.None
                InferenceDeleteRequest.Force = Option.None
            } : InferenceDeleteRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferenceDeleteRequest, value: TypesTaskType) =
            { state with InferenceDeleteRequest.TaskType = value } : InferenceDeleteRequest

        [<CustomOperation("inference_id")>]
        member _.InferenceId(state: InferenceDeleteRequest, value: Id) =
            { state with InferenceDeleteRequest.InferenceId = value } : InferenceDeleteRequest

        [<CustomOperation("dry_run")>]
        member _.DryRun(state: InferenceDeleteRequest, value: bool) =
            { state with InferenceDeleteRequest.DryRun = Option.Some value } : InferenceDeleteRequest

        [<CustomOperation("force")>]
        member _.Force(state: InferenceDeleteRequest, value: bool) =
            { state with InferenceDeleteRequest.Force = Option.Some value } : InferenceDeleteRequest

    let inferenceDeleteRequest = InferenceDeleteRequestBuilder()

    type InferencePutAi21Request = {
        TaskType: TypesAi21TaskType
        Ai21InferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("service")>]
        Service: TypesAi21ServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesAi21ServiceSettings
    } with
        static member ToRequest(request: InferencePutAi21Request) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.Ai21InferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutAi21RequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutAi21Request) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutAi21Request.ToRequest request

    type InferencePutAi21RequestBuilder() =
        member _.Yield(_: unit) : InferencePutAi21Request =
            {
                InferencePutAi21Request.TaskType = Unchecked.defaultof<TypesAi21TaskType>
                InferencePutAi21Request.Ai21InferenceId = Unchecked.defaultof<Id>
                InferencePutAi21Request.Timeout = Option.None
                InferencePutAi21Request.Service = Unchecked.defaultof<TypesAi21ServiceType>
                InferencePutAi21Request.ServiceSettings = Unchecked.defaultof<TypesAi21ServiceSettings>
            } : InferencePutAi21Request

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutAi21Request, value: TypesAi21TaskType) =
            { state with InferencePutAi21Request.TaskType = value } : InferencePutAi21Request

        [<CustomOperation("ai21_inference_id")>]
        member _.Ai21InferenceId(state: InferencePutAi21Request, value: Id) =
            { state with InferencePutAi21Request.Ai21InferenceId = value } : InferencePutAi21Request

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutAi21Request, value: Duration) =
            { state with InferencePutAi21Request.Timeout = Option.Some value } : InferencePutAi21Request

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutAi21Request, value: TypesAi21ServiceType) =
            { state with InferencePutAi21Request.Service = value } : InferencePutAi21Request

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutAi21Request, value: TypesAi21ServiceSettings) =
            { state with InferencePutAi21Request.ServiceSettings = value } : InferencePutAi21Request

    let inferencePutAi21Request = InferencePutAi21RequestBuilder()

    type InferencePutAi21Response = TypesInferenceEndpointInfoAi21

    type InferencePutAlibabacloudRequest = {
        TaskType: TypesAlibabaCloudTaskType
        AlibabacloudInferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("chunking_settings")>]
        ChunkingSettings: TypesInferenceChunkingSettings option
        [<JsonPropertyName("service")>]
        Service: TypesAlibabaCloudServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesAlibabaCloudServiceSettings
        [<JsonPropertyName("task_settings")>]
        TaskSettings: TypesAlibabaCloudTaskSettings option
    } with
        static member ToRequest(request: InferencePutAlibabacloudRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.AlibabacloudInferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutAlibabacloudRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutAlibabacloudRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutAlibabacloudRequest.ToRequest request

    type InferencePutAlibabacloudRequestBuilder() =
        member _.Yield(_: unit) : InferencePutAlibabacloudRequest =
            {
                InferencePutAlibabacloudRequest.TaskType = Unchecked.defaultof<TypesAlibabaCloudTaskType>
                InferencePutAlibabacloudRequest.AlibabacloudInferenceId = Unchecked.defaultof<Id>
                InferencePutAlibabacloudRequest.Timeout = Option.None
                InferencePutAlibabacloudRequest.ChunkingSettings = Option.None
                InferencePutAlibabacloudRequest.Service = Unchecked.defaultof<TypesAlibabaCloudServiceType>
                InferencePutAlibabacloudRequest.ServiceSettings = Unchecked.defaultof<TypesAlibabaCloudServiceSettings>
                InferencePutAlibabacloudRequest.TaskSettings = Option.None
            } : InferencePutAlibabacloudRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutAlibabacloudRequest, value: TypesAlibabaCloudTaskType) =
            { state with InferencePutAlibabacloudRequest.TaskType = value } : InferencePutAlibabacloudRequest

        [<CustomOperation("alibabacloud_inference_id")>]
        member _.AlibabacloudInferenceId(state: InferencePutAlibabacloudRequest, value: Id) =
            { state with InferencePutAlibabacloudRequest.AlibabacloudInferenceId = value } : InferencePutAlibabacloudRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutAlibabacloudRequest, value: Duration) =
            { state with InferencePutAlibabacloudRequest.Timeout = Option.Some value } : InferencePutAlibabacloudRequest

        [<CustomOperation("chunking_settings")>]
        member _.ChunkingSettings(state: InferencePutAlibabacloudRequest, value: TypesInferenceChunkingSettings) =
            { state with InferencePutAlibabacloudRequest.ChunkingSettings = Option.Some value } : InferencePutAlibabacloudRequest

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutAlibabacloudRequest, value: TypesAlibabaCloudServiceType) =
            { state with InferencePutAlibabacloudRequest.Service = value } : InferencePutAlibabacloudRequest

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutAlibabacloudRequest, value: TypesAlibabaCloudServiceSettings) =
            { state with InferencePutAlibabacloudRequest.ServiceSettings = value } : InferencePutAlibabacloudRequest

        [<CustomOperation("task_settings")>]
        member _.TaskSettings(state: InferencePutAlibabacloudRequest, value: TypesAlibabaCloudTaskSettings) =
            { state with InferencePutAlibabacloudRequest.TaskSettings = Option.Some value } : InferencePutAlibabacloudRequest

    let inferencePutAlibabacloudRequest = InferencePutAlibabacloudRequestBuilder()

    type InferencePutAlibabacloudResponse = TypesInferenceEndpointInfoAlibabaCloudAI

    type InferencePutAmazonbedrockRequest = {
        TaskType: TypesAmazonBedrockTaskType
        AmazonbedrockInferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("chunking_settings")>]
        ChunkingSettings: TypesInferenceChunkingSettings option
        [<JsonPropertyName("service")>]
        Service: TypesAmazonBedrockServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesAmazonBedrockServiceSettings
        [<JsonPropertyName("task_settings")>]
        TaskSettings: TypesAmazonBedrockTaskSettings option
    } with
        static member ToRequest(request: InferencePutAmazonbedrockRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.AmazonbedrockInferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutAmazonbedrockRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutAmazonbedrockRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutAmazonbedrockRequest.ToRequest request

    type InferencePutAmazonbedrockRequestBuilder() =
        member _.Yield(_: unit) : InferencePutAmazonbedrockRequest =
            {
                InferencePutAmazonbedrockRequest.TaskType = Unchecked.defaultof<TypesAmazonBedrockTaskType>
                InferencePutAmazonbedrockRequest.AmazonbedrockInferenceId = Unchecked.defaultof<Id>
                InferencePutAmazonbedrockRequest.Timeout = Option.None
                InferencePutAmazonbedrockRequest.ChunkingSettings = Option.None
                InferencePutAmazonbedrockRequest.Service = Unchecked.defaultof<TypesAmazonBedrockServiceType>
                InferencePutAmazonbedrockRequest.ServiceSettings = Unchecked.defaultof<TypesAmazonBedrockServiceSettings>
                InferencePutAmazonbedrockRequest.TaskSettings = Option.None
            } : InferencePutAmazonbedrockRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutAmazonbedrockRequest, value: TypesAmazonBedrockTaskType) =
            { state with InferencePutAmazonbedrockRequest.TaskType = value } : InferencePutAmazonbedrockRequest

        [<CustomOperation("amazonbedrock_inference_id")>]
        member _.AmazonbedrockInferenceId(state: InferencePutAmazonbedrockRequest, value: Id) =
            { state with InferencePutAmazonbedrockRequest.AmazonbedrockInferenceId = value } : InferencePutAmazonbedrockRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutAmazonbedrockRequest, value: Duration) =
            { state with InferencePutAmazonbedrockRequest.Timeout = Option.Some value } : InferencePutAmazonbedrockRequest

        [<CustomOperation("chunking_settings")>]
        member _.ChunkingSettings(state: InferencePutAmazonbedrockRequest, value: TypesInferenceChunkingSettings) =
            { state with InferencePutAmazonbedrockRequest.ChunkingSettings = Option.Some value } : InferencePutAmazonbedrockRequest

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutAmazonbedrockRequest, value: TypesAmazonBedrockServiceType) =
            { state with InferencePutAmazonbedrockRequest.Service = value } : InferencePutAmazonbedrockRequest

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutAmazonbedrockRequest, value: TypesAmazonBedrockServiceSettings) =
            { state with InferencePutAmazonbedrockRequest.ServiceSettings = value } : InferencePutAmazonbedrockRequest

        [<CustomOperation("task_settings")>]
        member _.TaskSettings(state: InferencePutAmazonbedrockRequest, value: TypesAmazonBedrockTaskSettings) =
            { state with InferencePutAmazonbedrockRequest.TaskSettings = Option.Some value } : InferencePutAmazonbedrockRequest

    let inferencePutAmazonbedrockRequest = InferencePutAmazonbedrockRequestBuilder()

    type InferencePutAmazonbedrockResponse = TypesInferenceEndpointInfoAmazonBedrock

    type InferencePutAmazonsagemakerRequest = {
        TaskType: TypesTaskTypeAmazonSageMaker
        AmazonsagemakerInferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("chunking_settings")>]
        ChunkingSettings: TypesInferenceChunkingSettings option
        [<JsonPropertyName("service")>]
        Service: TypesAmazonSageMakerServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesAmazonSageMakerServiceSettings
        [<JsonPropertyName("task_settings")>]
        TaskSettings: TypesAmazonSageMakerTaskSettings option
    } with
        static member ToRequest(request: InferencePutAmazonsagemakerRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.AmazonsagemakerInferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutAmazonsagemakerRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutAmazonsagemakerRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutAmazonsagemakerRequest.ToRequest request

    type InferencePutAmazonsagemakerRequestBuilder() =
        member _.Yield(_: unit) : InferencePutAmazonsagemakerRequest =
            {
                InferencePutAmazonsagemakerRequest.TaskType = Unchecked.defaultof<TypesTaskTypeAmazonSageMaker>
                InferencePutAmazonsagemakerRequest.AmazonsagemakerInferenceId = Unchecked.defaultof<Id>
                InferencePutAmazonsagemakerRequest.Timeout = Option.None
                InferencePutAmazonsagemakerRequest.ChunkingSettings = Option.None
                InferencePutAmazonsagemakerRequest.Service = Unchecked.defaultof<TypesAmazonSageMakerServiceType>
                InferencePutAmazonsagemakerRequest.ServiceSettings = Unchecked.defaultof<TypesAmazonSageMakerServiceSettings>
                InferencePutAmazonsagemakerRequest.TaskSettings = Option.None
            } : InferencePutAmazonsagemakerRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutAmazonsagemakerRequest, value: TypesTaskTypeAmazonSageMaker) =
            { state with InferencePutAmazonsagemakerRequest.TaskType = value } : InferencePutAmazonsagemakerRequest

        [<CustomOperation("amazonsagemaker_inference_id")>]
        member _.AmazonsagemakerInferenceId(state: InferencePutAmazonsagemakerRequest, value: Id) =
            { state with InferencePutAmazonsagemakerRequest.AmazonsagemakerInferenceId = value } : InferencePutAmazonsagemakerRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutAmazonsagemakerRequest, value: Duration) =
            { state with InferencePutAmazonsagemakerRequest.Timeout = Option.Some value } : InferencePutAmazonsagemakerRequest

        [<CustomOperation("chunking_settings")>]
        member _.ChunkingSettings(state: InferencePutAmazonsagemakerRequest, value: TypesInferenceChunkingSettings) =
            { state with InferencePutAmazonsagemakerRequest.ChunkingSettings = Option.Some value } : InferencePutAmazonsagemakerRequest

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutAmazonsagemakerRequest, value: TypesAmazonSageMakerServiceType) =
            { state with InferencePutAmazonsagemakerRequest.Service = value } : InferencePutAmazonsagemakerRequest

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutAmazonsagemakerRequest, value: TypesAmazonSageMakerServiceSettings) =
            { state with InferencePutAmazonsagemakerRequest.ServiceSettings = value } : InferencePutAmazonsagemakerRequest

        [<CustomOperation("task_settings")>]
        member _.TaskSettings(state: InferencePutAmazonsagemakerRequest, value: TypesAmazonSageMakerTaskSettings) =
            { state with InferencePutAmazonsagemakerRequest.TaskSettings = Option.Some value } : InferencePutAmazonsagemakerRequest

    let inferencePutAmazonsagemakerRequest = InferencePutAmazonsagemakerRequestBuilder()

    type InferencePutAmazonsagemakerResponse = TypesInferenceEndpointInfoAmazonSageMaker

    type InferencePutAnthropicRequest = {
        TaskType: TypesAnthropicTaskType
        AnthropicInferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("service")>]
        Service: TypesAnthropicServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesAnthropicServiceSettings
        [<JsonPropertyName("task_settings")>]
        TaskSettings: TypesAnthropicTaskSettings option
    } with
        static member ToRequest(request: InferencePutAnthropicRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.AnthropicInferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutAnthropicRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutAnthropicRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutAnthropicRequest.ToRequest request

    type InferencePutAnthropicRequestBuilder() =
        member _.Yield(_: unit) : InferencePutAnthropicRequest =
            {
                InferencePutAnthropicRequest.TaskType = Unchecked.defaultof<TypesAnthropicTaskType>
                InferencePutAnthropicRequest.AnthropicInferenceId = Unchecked.defaultof<Id>
                InferencePutAnthropicRequest.Timeout = Option.None
                InferencePutAnthropicRequest.Service = Unchecked.defaultof<TypesAnthropicServiceType>
                InferencePutAnthropicRequest.ServiceSettings = Unchecked.defaultof<TypesAnthropicServiceSettings>
                InferencePutAnthropicRequest.TaskSettings = Option.None
            } : InferencePutAnthropicRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutAnthropicRequest, value: TypesAnthropicTaskType) =
            { state with InferencePutAnthropicRequest.TaskType = value } : InferencePutAnthropicRequest

        [<CustomOperation("anthropic_inference_id")>]
        member _.AnthropicInferenceId(state: InferencePutAnthropicRequest, value: Id) =
            { state with InferencePutAnthropicRequest.AnthropicInferenceId = value } : InferencePutAnthropicRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutAnthropicRequest, value: Duration) =
            { state with InferencePutAnthropicRequest.Timeout = Option.Some value } : InferencePutAnthropicRequest

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutAnthropicRequest, value: TypesAnthropicServiceType) =
            { state with InferencePutAnthropicRequest.Service = value } : InferencePutAnthropicRequest

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutAnthropicRequest, value: TypesAnthropicServiceSettings) =
            { state with InferencePutAnthropicRequest.ServiceSettings = value } : InferencePutAnthropicRequest

        [<CustomOperation("task_settings")>]
        member _.TaskSettings(state: InferencePutAnthropicRequest, value: TypesAnthropicTaskSettings) =
            { state with InferencePutAnthropicRequest.TaskSettings = Option.Some value } : InferencePutAnthropicRequest

    let inferencePutAnthropicRequest = InferencePutAnthropicRequestBuilder()

    type InferencePutAnthropicResponse = TypesInferenceEndpointInfoAnthropic

    type InferencePutAzureaistudioRequest = {
        TaskType: TypesAzureAiStudioTaskType
        AzureaistudioInferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("chunking_settings")>]
        ChunkingSettings: TypesInferenceChunkingSettings option
        [<JsonPropertyName("service")>]
        Service: TypesAzureAiStudioServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesAzureAiStudioServiceSettings
        [<JsonPropertyName("task_settings")>]
        TaskSettings: TypesAzureAiStudioTaskSettings option
    } with
        static member ToRequest(request: InferencePutAzureaistudioRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.AzureaistudioInferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutAzureaistudioRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutAzureaistudioRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutAzureaistudioRequest.ToRequest request

    type InferencePutAzureaistudioRequestBuilder() =
        member _.Yield(_: unit) : InferencePutAzureaistudioRequest =
            {
                InferencePutAzureaistudioRequest.TaskType = Unchecked.defaultof<TypesAzureAiStudioTaskType>
                InferencePutAzureaistudioRequest.AzureaistudioInferenceId = Unchecked.defaultof<Id>
                InferencePutAzureaistudioRequest.Timeout = Option.None
                InferencePutAzureaistudioRequest.ChunkingSettings = Option.None
                InferencePutAzureaistudioRequest.Service = Unchecked.defaultof<TypesAzureAiStudioServiceType>
                InferencePutAzureaistudioRequest.ServiceSettings = Unchecked.defaultof<TypesAzureAiStudioServiceSettings>
                InferencePutAzureaistudioRequest.TaskSettings = Option.None
            } : InferencePutAzureaistudioRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutAzureaistudioRequest, value: TypesAzureAiStudioTaskType) =
            { state with InferencePutAzureaistudioRequest.TaskType = value } : InferencePutAzureaistudioRequest

        [<CustomOperation("azureaistudio_inference_id")>]
        member _.AzureaistudioInferenceId(state: InferencePutAzureaistudioRequest, value: Id) =
            { state with InferencePutAzureaistudioRequest.AzureaistudioInferenceId = value } : InferencePutAzureaistudioRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutAzureaistudioRequest, value: Duration) =
            { state with InferencePutAzureaistudioRequest.Timeout = Option.Some value } : InferencePutAzureaistudioRequest

        [<CustomOperation("chunking_settings")>]
        member _.ChunkingSettings(state: InferencePutAzureaistudioRequest, value: TypesInferenceChunkingSettings) =
            { state with InferencePutAzureaistudioRequest.ChunkingSettings = Option.Some value } : InferencePutAzureaistudioRequest

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutAzureaistudioRequest, value: TypesAzureAiStudioServiceType) =
            { state with InferencePutAzureaistudioRequest.Service = value } : InferencePutAzureaistudioRequest

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutAzureaistudioRequest, value: TypesAzureAiStudioServiceSettings) =
            { state with InferencePutAzureaistudioRequest.ServiceSettings = value } : InferencePutAzureaistudioRequest

        [<CustomOperation("task_settings")>]
        member _.TaskSettings(state: InferencePutAzureaistudioRequest, value: TypesAzureAiStudioTaskSettings) =
            { state with InferencePutAzureaistudioRequest.TaskSettings = Option.Some value } : InferencePutAzureaistudioRequest

    let inferencePutAzureaistudioRequest = InferencePutAzureaistudioRequestBuilder()

    type InferencePutAzureaistudioResponse = TypesInferenceEndpointInfoAzureAIStudio

    type InferencePutAzureopenaiRequest = {
        TaskType: TypesAzureOpenAITaskType
        AzureopenaiInferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("chunking_settings")>]
        ChunkingSettings: TypesInferenceChunkingSettings option
        [<JsonPropertyName("service")>]
        Service: TypesAzureOpenAIServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesAzureOpenAIServiceSettings
        [<JsonPropertyName("task_settings")>]
        TaskSettings: TypesAzureOpenAITaskSettings option
    } with
        static member ToRequest(request: InferencePutAzureopenaiRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.AzureopenaiInferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutAzureopenaiRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutAzureopenaiRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutAzureopenaiRequest.ToRequest request

    type InferencePutAzureopenaiRequestBuilder() =
        member _.Yield(_: unit) : InferencePutAzureopenaiRequest =
            {
                InferencePutAzureopenaiRequest.TaskType = Unchecked.defaultof<TypesAzureOpenAITaskType>
                InferencePutAzureopenaiRequest.AzureopenaiInferenceId = Unchecked.defaultof<Id>
                InferencePutAzureopenaiRequest.Timeout = Option.None
                InferencePutAzureopenaiRequest.ChunkingSettings = Option.None
                InferencePutAzureopenaiRequest.Service = Unchecked.defaultof<TypesAzureOpenAIServiceType>
                InferencePutAzureopenaiRequest.ServiceSettings = Unchecked.defaultof<TypesAzureOpenAIServiceSettings>
                InferencePutAzureopenaiRequest.TaskSettings = Option.None
            } : InferencePutAzureopenaiRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutAzureopenaiRequest, value: TypesAzureOpenAITaskType) =
            { state with InferencePutAzureopenaiRequest.TaskType = value } : InferencePutAzureopenaiRequest

        [<CustomOperation("azureopenai_inference_id")>]
        member _.AzureopenaiInferenceId(state: InferencePutAzureopenaiRequest, value: Id) =
            { state with InferencePutAzureopenaiRequest.AzureopenaiInferenceId = value } : InferencePutAzureopenaiRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutAzureopenaiRequest, value: Duration) =
            { state with InferencePutAzureopenaiRequest.Timeout = Option.Some value } : InferencePutAzureopenaiRequest

        [<CustomOperation("chunking_settings")>]
        member _.ChunkingSettings(state: InferencePutAzureopenaiRequest, value: TypesInferenceChunkingSettings) =
            { state with InferencePutAzureopenaiRequest.ChunkingSettings = Option.Some value } : InferencePutAzureopenaiRequest

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutAzureopenaiRequest, value: TypesAzureOpenAIServiceType) =
            { state with InferencePutAzureopenaiRequest.Service = value } : InferencePutAzureopenaiRequest

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutAzureopenaiRequest, value: TypesAzureOpenAIServiceSettings) =
            { state with InferencePutAzureopenaiRequest.ServiceSettings = value } : InferencePutAzureopenaiRequest

        [<CustomOperation("task_settings")>]
        member _.TaskSettings(state: InferencePutAzureopenaiRequest, value: TypesAzureOpenAITaskSettings) =
            { state with InferencePutAzureopenaiRequest.TaskSettings = Option.Some value } : InferencePutAzureopenaiRequest

    let inferencePutAzureopenaiRequest = InferencePutAzureopenaiRequestBuilder()

    type InferencePutAzureopenaiResponse = TypesInferenceEndpointInfoAzureOpenAI

    type InferencePutCohereRequest = {
        TaskType: TypesCohereTaskType
        CohereInferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("chunking_settings")>]
        ChunkingSettings: TypesInferenceChunkingSettings option
        [<JsonPropertyName("service")>]
        Service: TypesCohereServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesCohereServiceSettings
        [<JsonPropertyName("task_settings")>]
        TaskSettings: TypesCohereTaskSettings option
    } with
        static member ToRequest(request: InferencePutCohereRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.CohereInferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutCohereRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutCohereRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutCohereRequest.ToRequest request

    type InferencePutCohereRequestBuilder() =
        member _.Yield(_: unit) : InferencePutCohereRequest =
            {
                InferencePutCohereRequest.TaskType = Unchecked.defaultof<TypesCohereTaskType>
                InferencePutCohereRequest.CohereInferenceId = Unchecked.defaultof<Id>
                InferencePutCohereRequest.Timeout = Option.None
                InferencePutCohereRequest.ChunkingSettings = Option.None
                InferencePutCohereRequest.Service = Unchecked.defaultof<TypesCohereServiceType>
                InferencePutCohereRequest.ServiceSettings = Unchecked.defaultof<TypesCohereServiceSettings>
                InferencePutCohereRequest.TaskSettings = Option.None
            } : InferencePutCohereRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutCohereRequest, value: TypesCohereTaskType) =
            { state with InferencePutCohereRequest.TaskType = value } : InferencePutCohereRequest

        [<CustomOperation("cohere_inference_id")>]
        member _.CohereInferenceId(state: InferencePutCohereRequest, value: Id) =
            { state with InferencePutCohereRequest.CohereInferenceId = value } : InferencePutCohereRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutCohereRequest, value: Duration) =
            { state with InferencePutCohereRequest.Timeout = Option.Some value } : InferencePutCohereRequest

        [<CustomOperation("chunking_settings")>]
        member _.ChunkingSettings(state: InferencePutCohereRequest, value: TypesInferenceChunkingSettings) =
            { state with InferencePutCohereRequest.ChunkingSettings = Option.Some value } : InferencePutCohereRequest

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutCohereRequest, value: TypesCohereServiceType) =
            { state with InferencePutCohereRequest.Service = value } : InferencePutCohereRequest

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutCohereRequest, value: TypesCohereServiceSettings) =
            { state with InferencePutCohereRequest.ServiceSettings = value } : InferencePutCohereRequest

        [<CustomOperation("task_settings")>]
        member _.TaskSettings(state: InferencePutCohereRequest, value: TypesCohereTaskSettings) =
            { state with InferencePutCohereRequest.TaskSettings = Option.Some value } : InferencePutCohereRequest

    let inferencePutCohereRequest = InferencePutCohereRequestBuilder()

    type InferencePutCohereResponse = TypesInferenceEndpointInfoCohere

    type InferencePutContextualaiRequest = {
        TaskType: TypesTaskTypeContextualAI
        ContextualaiInferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("service")>]
        Service: TypesContextualAIServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesContextualAIServiceSettings
        [<JsonPropertyName("task_settings")>]
        TaskSettings: TypesContextualAITaskSettings option
    } with
        static member ToRequest(request: InferencePutContextualaiRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.ContextualaiInferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutContextualaiRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutContextualaiRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutContextualaiRequest.ToRequest request

    type InferencePutContextualaiRequestBuilder() =
        member _.Yield(_: unit) : InferencePutContextualaiRequest =
            {
                InferencePutContextualaiRequest.TaskType = Unchecked.defaultof<TypesTaskTypeContextualAI>
                InferencePutContextualaiRequest.ContextualaiInferenceId = Unchecked.defaultof<Id>
                InferencePutContextualaiRequest.Timeout = Option.None
                InferencePutContextualaiRequest.Service = Unchecked.defaultof<TypesContextualAIServiceType>
                InferencePutContextualaiRequest.ServiceSettings = Unchecked.defaultof<TypesContextualAIServiceSettings>
                InferencePutContextualaiRequest.TaskSettings = Option.None
            } : InferencePutContextualaiRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutContextualaiRequest, value: TypesTaskTypeContextualAI) =
            { state with InferencePutContextualaiRequest.TaskType = value } : InferencePutContextualaiRequest

        [<CustomOperation("contextualai_inference_id")>]
        member _.ContextualaiInferenceId(state: InferencePutContextualaiRequest, value: Id) =
            { state with InferencePutContextualaiRequest.ContextualaiInferenceId = value } : InferencePutContextualaiRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutContextualaiRequest, value: Duration) =
            { state with InferencePutContextualaiRequest.Timeout = Option.Some value } : InferencePutContextualaiRequest

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutContextualaiRequest, value: TypesContextualAIServiceType) =
            { state with InferencePutContextualaiRequest.Service = value } : InferencePutContextualaiRequest

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutContextualaiRequest, value: TypesContextualAIServiceSettings) =
            { state with InferencePutContextualaiRequest.ServiceSettings = value } : InferencePutContextualaiRequest

        [<CustomOperation("task_settings")>]
        member _.TaskSettings(state: InferencePutContextualaiRequest, value: TypesContextualAITaskSettings) =
            { state with InferencePutContextualaiRequest.TaskSettings = Option.Some value } : InferencePutContextualaiRequest

    let inferencePutContextualaiRequest = InferencePutContextualaiRequestBuilder()

    type InferencePutContextualaiResponse = TypesInferenceEndpointInfoContextualAi

    type InferencePutCustomRequest = {
        TaskType: TypesCustomTaskType
        CustomInferenceId: Id
        [<JsonPropertyName("chunking_settings")>]
        ChunkingSettings: TypesInferenceChunkingSettings option
        [<JsonPropertyName("service")>]
        Service: TypesCustomServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesCustomServiceSettings
        [<JsonPropertyName("task_settings")>]
        TaskSettings: TypesCustomTaskSettings option
    } with
        static member ToRequest(request: InferencePutCustomRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.CustomInferenceId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutCustomRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutCustomRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutCustomRequest.ToRequest request

    type InferencePutCustomRequestBuilder() =
        member _.Yield(_: unit) : InferencePutCustomRequest =
            {
                InferencePutCustomRequest.TaskType = Unchecked.defaultof<TypesCustomTaskType>
                InferencePutCustomRequest.CustomInferenceId = Unchecked.defaultof<Id>
                InferencePutCustomRequest.ChunkingSettings = Option.None
                InferencePutCustomRequest.Service = Unchecked.defaultof<TypesCustomServiceType>
                InferencePutCustomRequest.ServiceSettings = Unchecked.defaultof<TypesCustomServiceSettings>
                InferencePutCustomRequest.TaskSettings = Option.None
            } : InferencePutCustomRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutCustomRequest, value: TypesCustomTaskType) =
            { state with InferencePutCustomRequest.TaskType = value } : InferencePutCustomRequest

        [<CustomOperation("custom_inference_id")>]
        member _.CustomInferenceId(state: InferencePutCustomRequest, value: Id) =
            { state with InferencePutCustomRequest.CustomInferenceId = value } : InferencePutCustomRequest

        [<CustomOperation("chunking_settings")>]
        member _.ChunkingSettings(state: InferencePutCustomRequest, value: TypesInferenceChunkingSettings) =
            { state with InferencePutCustomRequest.ChunkingSettings = Option.Some value } : InferencePutCustomRequest

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutCustomRequest, value: TypesCustomServiceType) =
            { state with InferencePutCustomRequest.Service = value } : InferencePutCustomRequest

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutCustomRequest, value: TypesCustomServiceSettings) =
            { state with InferencePutCustomRequest.ServiceSettings = value } : InferencePutCustomRequest

        [<CustomOperation("task_settings")>]
        member _.TaskSettings(state: InferencePutCustomRequest, value: TypesCustomTaskSettings) =
            { state with InferencePutCustomRequest.TaskSettings = Option.Some value } : InferencePutCustomRequest

    let inferencePutCustomRequest = InferencePutCustomRequestBuilder()

    type InferencePutCustomResponse = TypesInferenceEndpointInfoCustom

    type InferencePutDeepseekRequest = {
        TaskType: TypesTaskTypeDeepSeek
        DeepseekInferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("service")>]
        Service: TypesDeepSeekServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesDeepSeekServiceSettings
    } with
        static member ToRequest(request: InferencePutDeepseekRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.DeepseekInferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutDeepseekRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutDeepseekRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutDeepseekRequest.ToRequest request

    type InferencePutDeepseekRequestBuilder() =
        member _.Yield(_: unit) : InferencePutDeepseekRequest =
            {
                InferencePutDeepseekRequest.TaskType = Unchecked.defaultof<TypesTaskTypeDeepSeek>
                InferencePutDeepseekRequest.DeepseekInferenceId = Unchecked.defaultof<Id>
                InferencePutDeepseekRequest.Timeout = Option.None
                InferencePutDeepseekRequest.Service = Unchecked.defaultof<TypesDeepSeekServiceType>
                InferencePutDeepseekRequest.ServiceSettings = Unchecked.defaultof<TypesDeepSeekServiceSettings>
            } : InferencePutDeepseekRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutDeepseekRequest, value: TypesTaskTypeDeepSeek) =
            { state with InferencePutDeepseekRequest.TaskType = value } : InferencePutDeepseekRequest

        [<CustomOperation("deepseek_inference_id")>]
        member _.DeepseekInferenceId(state: InferencePutDeepseekRequest, value: Id) =
            { state with InferencePutDeepseekRequest.DeepseekInferenceId = value } : InferencePutDeepseekRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutDeepseekRequest, value: Duration) =
            { state with InferencePutDeepseekRequest.Timeout = Option.Some value } : InferencePutDeepseekRequest

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutDeepseekRequest, value: TypesDeepSeekServiceType) =
            { state with InferencePutDeepseekRequest.Service = value } : InferencePutDeepseekRequest

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutDeepseekRequest, value: TypesDeepSeekServiceSettings) =
            { state with InferencePutDeepseekRequest.ServiceSettings = value } : InferencePutDeepseekRequest

    let inferencePutDeepseekRequest = InferencePutDeepseekRequestBuilder()

    type InferencePutDeepseekResponse = TypesInferenceEndpointInfoDeepSeek

    type InferencePutElasticsearchRequest = {
        TaskType: TypesElasticsearchTaskType
        ElasticsearchInferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("chunking_settings")>]
        ChunkingSettings: TypesInferenceChunkingSettings option
        [<JsonPropertyName("service")>]
        Service: TypesElasticsearchServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesElasticsearchServiceSettings
        [<JsonPropertyName("task_settings")>]
        TaskSettings: TypesElasticsearchTaskSettings option
    } with
        static member ToRequest(request: InferencePutElasticsearchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.ElasticsearchInferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutElasticsearchRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutElasticsearchRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutElasticsearchRequest.ToRequest request

    type InferencePutElasticsearchRequestBuilder() =
        member _.Yield(_: unit) : InferencePutElasticsearchRequest =
            {
                InferencePutElasticsearchRequest.TaskType = Unchecked.defaultof<TypesElasticsearchTaskType>
                InferencePutElasticsearchRequest.ElasticsearchInferenceId = Unchecked.defaultof<Id>
                InferencePutElasticsearchRequest.Timeout = Option.None
                InferencePutElasticsearchRequest.ChunkingSettings = Option.None
                InferencePutElasticsearchRequest.Service = Unchecked.defaultof<TypesElasticsearchServiceType>
                InferencePutElasticsearchRequest.ServiceSettings = Unchecked.defaultof<TypesElasticsearchServiceSettings>
                InferencePutElasticsearchRequest.TaskSettings = Option.None
            } : InferencePutElasticsearchRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutElasticsearchRequest, value: TypesElasticsearchTaskType) =
            { state with InferencePutElasticsearchRequest.TaskType = value } : InferencePutElasticsearchRequest

        [<CustomOperation("elasticsearch_inference_id")>]
        member _.ElasticsearchInferenceId(state: InferencePutElasticsearchRequest, value: Id) =
            { state with InferencePutElasticsearchRequest.ElasticsearchInferenceId = value } : InferencePutElasticsearchRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutElasticsearchRequest, value: Duration) =
            { state with InferencePutElasticsearchRequest.Timeout = Option.Some value } : InferencePutElasticsearchRequest

        [<CustomOperation("chunking_settings")>]
        member _.ChunkingSettings(state: InferencePutElasticsearchRequest, value: TypesInferenceChunkingSettings) =
            { state with InferencePutElasticsearchRequest.ChunkingSettings = Option.Some value } : InferencePutElasticsearchRequest

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutElasticsearchRequest, value: TypesElasticsearchServiceType) =
            { state with InferencePutElasticsearchRequest.Service = value } : InferencePutElasticsearchRequest

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutElasticsearchRequest, value: TypesElasticsearchServiceSettings) =
            { state with InferencePutElasticsearchRequest.ServiceSettings = value } : InferencePutElasticsearchRequest

        [<CustomOperation("task_settings")>]
        member _.TaskSettings(state: InferencePutElasticsearchRequest, value: TypesElasticsearchTaskSettings) =
            { state with InferencePutElasticsearchRequest.TaskSettings = Option.Some value } : InferencePutElasticsearchRequest

    let inferencePutElasticsearchRequest = InferencePutElasticsearchRequestBuilder()

    type InferencePutElasticsearchResponse = TypesInferenceEndpointInfoElasticsearch

    type InferencePutElserRequest = {
        TaskType: TypesElserTaskType
        ElserInferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("chunking_settings")>]
        ChunkingSettings: TypesInferenceChunkingSettings option
        [<JsonPropertyName("service")>]
        Service: TypesElserServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesElserServiceSettings
    } with
        static member ToRequest(request: InferencePutElserRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.ElserInferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutElserRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutElserRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutElserRequest.ToRequest request

    type InferencePutElserRequestBuilder() =
        member _.Yield(_: unit) : InferencePutElserRequest =
            {
                InferencePutElserRequest.TaskType = Unchecked.defaultof<TypesElserTaskType>
                InferencePutElserRequest.ElserInferenceId = Unchecked.defaultof<Id>
                InferencePutElserRequest.Timeout = Option.None
                InferencePutElserRequest.ChunkingSettings = Option.None
                InferencePutElserRequest.Service = Unchecked.defaultof<TypesElserServiceType>
                InferencePutElserRequest.ServiceSettings = Unchecked.defaultof<TypesElserServiceSettings>
            } : InferencePutElserRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutElserRequest, value: TypesElserTaskType) =
            { state with InferencePutElserRequest.TaskType = value } : InferencePutElserRequest

        [<CustomOperation("elser_inference_id")>]
        member _.ElserInferenceId(state: InferencePutElserRequest, value: Id) =
            { state with InferencePutElserRequest.ElserInferenceId = value } : InferencePutElserRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutElserRequest, value: Duration) =
            { state with InferencePutElserRequest.Timeout = Option.Some value } : InferencePutElserRequest

        [<CustomOperation("chunking_settings")>]
        member _.ChunkingSettings(state: InferencePutElserRequest, value: TypesInferenceChunkingSettings) =
            { state with InferencePutElserRequest.ChunkingSettings = Option.Some value } : InferencePutElserRequest

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutElserRequest, value: TypesElserServiceType) =
            { state with InferencePutElserRequest.Service = value } : InferencePutElserRequest

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutElserRequest, value: TypesElserServiceSettings) =
            { state with InferencePutElserRequest.ServiceSettings = value } : InferencePutElserRequest

    let inferencePutElserRequest = InferencePutElserRequestBuilder()

    type InferencePutElserResponse = TypesInferenceEndpointInfoELSER

    type InferencePutGoogleaistudioRequest = {
        TaskType: TypesGoogleAiStudioTaskType
        GoogleaistudioInferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("chunking_settings")>]
        ChunkingSettings: TypesInferenceChunkingSettings option
        [<JsonPropertyName("service")>]
        Service: TypesGoogleAiServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesGoogleAiStudioServiceSettings
    } with
        static member ToRequest(request: InferencePutGoogleaistudioRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.GoogleaistudioInferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutGoogleaistudioRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutGoogleaistudioRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutGoogleaistudioRequest.ToRequest request

    type InferencePutGoogleaistudioRequestBuilder() =
        member _.Yield(_: unit) : InferencePutGoogleaistudioRequest =
            {
                InferencePutGoogleaistudioRequest.TaskType = Unchecked.defaultof<TypesGoogleAiStudioTaskType>
                InferencePutGoogleaistudioRequest.GoogleaistudioInferenceId = Unchecked.defaultof<Id>
                InferencePutGoogleaistudioRequest.Timeout = Option.None
                InferencePutGoogleaistudioRequest.ChunkingSettings = Option.None
                InferencePutGoogleaistudioRequest.Service = Unchecked.defaultof<TypesGoogleAiServiceType>
                InferencePutGoogleaistudioRequest.ServiceSettings = Unchecked.defaultof<TypesGoogleAiStudioServiceSettings>
            } : InferencePutGoogleaistudioRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutGoogleaistudioRequest, value: TypesGoogleAiStudioTaskType) =
            { state with InferencePutGoogleaistudioRequest.TaskType = value } : InferencePutGoogleaistudioRequest

        [<CustomOperation("googleaistudio_inference_id")>]
        member _.GoogleaistudioInferenceId(state: InferencePutGoogleaistudioRequest, value: Id) =
            { state with InferencePutGoogleaistudioRequest.GoogleaistudioInferenceId = value } : InferencePutGoogleaistudioRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutGoogleaistudioRequest, value: Duration) =
            { state with InferencePutGoogleaistudioRequest.Timeout = Option.Some value } : InferencePutGoogleaistudioRequest

        [<CustomOperation("chunking_settings")>]
        member _.ChunkingSettings(state: InferencePutGoogleaistudioRequest, value: TypesInferenceChunkingSettings) =
            { state with InferencePutGoogleaistudioRequest.ChunkingSettings = Option.Some value } : InferencePutGoogleaistudioRequest

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutGoogleaistudioRequest, value: TypesGoogleAiServiceType) =
            { state with InferencePutGoogleaistudioRequest.Service = value } : InferencePutGoogleaistudioRequest

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutGoogleaistudioRequest, value: TypesGoogleAiStudioServiceSettings) =
            { state with InferencePutGoogleaistudioRequest.ServiceSettings = value } : InferencePutGoogleaistudioRequest

    let inferencePutGoogleaistudioRequest = InferencePutGoogleaistudioRequestBuilder()

    type InferencePutGoogleaistudioResponse = TypesInferenceEndpointInfoGoogleAIStudio

    type InferencePutGooglevertexaiRequest = {
        TaskType: TypesGoogleVertexAITaskType
        GooglevertexaiInferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("chunking_settings")>]
        ChunkingSettings: TypesInferenceChunkingSettings option
        [<JsonPropertyName("service")>]
        Service: TypesGoogleVertexAIServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesGoogleVertexAIServiceSettings
        [<JsonPropertyName("task_settings")>]
        TaskSettings: TypesGoogleVertexAITaskSettings option
    } with
        static member ToRequest(request: InferencePutGooglevertexaiRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.GooglevertexaiInferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutGooglevertexaiRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutGooglevertexaiRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutGooglevertexaiRequest.ToRequest request

    type InferencePutGooglevertexaiRequestBuilder() =
        member _.Yield(_: unit) : InferencePutGooglevertexaiRequest =
            {
                InferencePutGooglevertexaiRequest.TaskType = Unchecked.defaultof<TypesGoogleVertexAITaskType>
                InferencePutGooglevertexaiRequest.GooglevertexaiInferenceId = Unchecked.defaultof<Id>
                InferencePutGooglevertexaiRequest.Timeout = Option.None
                InferencePutGooglevertexaiRequest.ChunkingSettings = Option.None
                InferencePutGooglevertexaiRequest.Service = Unchecked.defaultof<TypesGoogleVertexAIServiceType>
                InferencePutGooglevertexaiRequest.ServiceSettings = Unchecked.defaultof<TypesGoogleVertexAIServiceSettings>
                InferencePutGooglevertexaiRequest.TaskSettings = Option.None
            } : InferencePutGooglevertexaiRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutGooglevertexaiRequest, value: TypesGoogleVertexAITaskType) =
            { state with InferencePutGooglevertexaiRequest.TaskType = value } : InferencePutGooglevertexaiRequest

        [<CustomOperation("googlevertexai_inference_id")>]
        member _.GooglevertexaiInferenceId(state: InferencePutGooglevertexaiRequest, value: Id) =
            { state with InferencePutGooglevertexaiRequest.GooglevertexaiInferenceId = value } : InferencePutGooglevertexaiRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutGooglevertexaiRequest, value: Duration) =
            { state with InferencePutGooglevertexaiRequest.Timeout = Option.Some value } : InferencePutGooglevertexaiRequest

        [<CustomOperation("chunking_settings")>]
        member _.ChunkingSettings(state: InferencePutGooglevertexaiRequest, value: TypesInferenceChunkingSettings) =
            { state with InferencePutGooglevertexaiRequest.ChunkingSettings = Option.Some value } : InferencePutGooglevertexaiRequest

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutGooglevertexaiRequest, value: TypesGoogleVertexAIServiceType) =
            { state with InferencePutGooglevertexaiRequest.Service = value } : InferencePutGooglevertexaiRequest

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutGooglevertexaiRequest, value: TypesGoogleVertexAIServiceSettings) =
            { state with InferencePutGooglevertexaiRequest.ServiceSettings = value } : InferencePutGooglevertexaiRequest

        [<CustomOperation("task_settings")>]
        member _.TaskSettings(state: InferencePutGooglevertexaiRequest, value: TypesGoogleVertexAITaskSettings) =
            { state with InferencePutGooglevertexaiRequest.TaskSettings = Option.Some value } : InferencePutGooglevertexaiRequest

    let inferencePutGooglevertexaiRequest = InferencePutGooglevertexaiRequestBuilder()

    type InferencePutGooglevertexaiResponse = TypesInferenceEndpointInfoGoogleVertexAI

    type InferencePutGroqRequest = {
        TaskType: TypesGroqTaskType
        GroqInferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("service")>]
        Service: TypesGroqServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesGroqServiceSettings
    } with
        static member ToRequest(request: InferencePutGroqRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.GroqInferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutGroqRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutGroqRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutGroqRequest.ToRequest request

    type InferencePutGroqRequestBuilder() =
        member _.Yield(_: unit) : InferencePutGroqRequest =
            {
                InferencePutGroqRequest.TaskType = Unchecked.defaultof<TypesGroqTaskType>
                InferencePutGroqRequest.GroqInferenceId = Unchecked.defaultof<Id>
                InferencePutGroqRequest.Timeout = Option.None
                InferencePutGroqRequest.Service = Unchecked.defaultof<TypesGroqServiceType>
                InferencePutGroqRequest.ServiceSettings = Unchecked.defaultof<TypesGroqServiceSettings>
            } : InferencePutGroqRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutGroqRequest, value: TypesGroqTaskType) =
            { state with InferencePutGroqRequest.TaskType = value } : InferencePutGroqRequest

        [<CustomOperation("groq_inference_id")>]
        member _.GroqInferenceId(state: InferencePutGroqRequest, value: Id) =
            { state with InferencePutGroqRequest.GroqInferenceId = value } : InferencePutGroqRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutGroqRequest, value: Duration) =
            { state with InferencePutGroqRequest.Timeout = Option.Some value } : InferencePutGroqRequest

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutGroqRequest, value: TypesGroqServiceType) =
            { state with InferencePutGroqRequest.Service = value } : InferencePutGroqRequest

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutGroqRequest, value: TypesGroqServiceSettings) =
            { state with InferencePutGroqRequest.ServiceSettings = value } : InferencePutGroqRequest

    let inferencePutGroqRequest = InferencePutGroqRequestBuilder()

    type InferencePutGroqResponse = TypesInferenceEndpointInfoGroq

    type InferencePutHuggingFaceRequest = {
        TaskType: TypesHuggingFaceTaskType
        HuggingfaceInferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("chunking_settings")>]
        ChunkingSettings: TypesInferenceChunkingSettings option
        [<JsonPropertyName("service")>]
        Service: TypesHuggingFaceServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesHuggingFaceServiceSettings
        [<JsonPropertyName("task_settings")>]
        TaskSettings: TypesHuggingFaceTaskSettings option
    } with
        static member ToRequest(request: InferencePutHuggingFaceRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.HuggingfaceInferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutHuggingFaceRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutHuggingFaceRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutHuggingFaceRequest.ToRequest request

    type InferencePutHuggingFaceRequestBuilder() =
        member _.Yield(_: unit) : InferencePutHuggingFaceRequest =
            {
                InferencePutHuggingFaceRequest.TaskType = Unchecked.defaultof<TypesHuggingFaceTaskType>
                InferencePutHuggingFaceRequest.HuggingfaceInferenceId = Unchecked.defaultof<Id>
                InferencePutHuggingFaceRequest.Timeout = Option.None
                InferencePutHuggingFaceRequest.ChunkingSettings = Option.None
                InferencePutHuggingFaceRequest.Service = Unchecked.defaultof<TypesHuggingFaceServiceType>
                InferencePutHuggingFaceRequest.ServiceSettings = Unchecked.defaultof<TypesHuggingFaceServiceSettings>
                InferencePutHuggingFaceRequest.TaskSettings = Option.None
            } : InferencePutHuggingFaceRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutHuggingFaceRequest, value: TypesHuggingFaceTaskType) =
            { state with InferencePutHuggingFaceRequest.TaskType = value } : InferencePutHuggingFaceRequest

        [<CustomOperation("huggingface_inference_id")>]
        member _.HuggingfaceInferenceId(state: InferencePutHuggingFaceRequest, value: Id) =
            { state with InferencePutHuggingFaceRequest.HuggingfaceInferenceId = value } : InferencePutHuggingFaceRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutHuggingFaceRequest, value: Duration) =
            { state with InferencePutHuggingFaceRequest.Timeout = Option.Some value } : InferencePutHuggingFaceRequest

        [<CustomOperation("chunking_settings")>]
        member _.ChunkingSettings(state: InferencePutHuggingFaceRequest, value: TypesInferenceChunkingSettings) =
            { state with InferencePutHuggingFaceRequest.ChunkingSettings = Option.Some value } : InferencePutHuggingFaceRequest

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutHuggingFaceRequest, value: TypesHuggingFaceServiceType) =
            { state with InferencePutHuggingFaceRequest.Service = value } : InferencePutHuggingFaceRequest

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutHuggingFaceRequest, value: TypesHuggingFaceServiceSettings) =
            { state with InferencePutHuggingFaceRequest.ServiceSettings = value } : InferencePutHuggingFaceRequest

        [<CustomOperation("task_settings")>]
        member _.TaskSettings(state: InferencePutHuggingFaceRequest, value: TypesHuggingFaceTaskSettings) =
            { state with InferencePutHuggingFaceRequest.TaskSettings = Option.Some value } : InferencePutHuggingFaceRequest

    let inferencePutHuggingFaceRequest = InferencePutHuggingFaceRequestBuilder()

    type InferencePutHuggingFaceResponse = TypesInferenceEndpointInfoHuggingFace

    type InferencePutJinaaiRequest = {
        TaskType: TypesJinaAITaskType
        JinaaiInferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("chunking_settings")>]
        ChunkingSettings: TypesInferenceChunkingSettings option
        [<JsonPropertyName("service")>]
        Service: TypesJinaAIServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesJinaAIServiceSettings
        [<JsonPropertyName("task_settings")>]
        TaskSettings: TypesJinaAITaskSettings option
    } with
        static member ToRequest(request: InferencePutJinaaiRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.JinaaiInferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutJinaaiRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutJinaaiRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutJinaaiRequest.ToRequest request

    type InferencePutJinaaiRequestBuilder() =
        member _.Yield(_: unit) : InferencePutJinaaiRequest =
            {
                InferencePutJinaaiRequest.TaskType = Unchecked.defaultof<TypesJinaAITaskType>
                InferencePutJinaaiRequest.JinaaiInferenceId = Unchecked.defaultof<Id>
                InferencePutJinaaiRequest.Timeout = Option.None
                InferencePutJinaaiRequest.ChunkingSettings = Option.None
                InferencePutJinaaiRequest.Service = Unchecked.defaultof<TypesJinaAIServiceType>
                InferencePutJinaaiRequest.ServiceSettings = Unchecked.defaultof<TypesJinaAIServiceSettings>
                InferencePutJinaaiRequest.TaskSettings = Option.None
            } : InferencePutJinaaiRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutJinaaiRequest, value: TypesJinaAITaskType) =
            { state with InferencePutJinaaiRequest.TaskType = value } : InferencePutJinaaiRequest

        [<CustomOperation("jinaai_inference_id")>]
        member _.JinaaiInferenceId(state: InferencePutJinaaiRequest, value: Id) =
            { state with InferencePutJinaaiRequest.JinaaiInferenceId = value } : InferencePutJinaaiRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutJinaaiRequest, value: Duration) =
            { state with InferencePutJinaaiRequest.Timeout = Option.Some value } : InferencePutJinaaiRequest

        [<CustomOperation("chunking_settings")>]
        member _.ChunkingSettings(state: InferencePutJinaaiRequest, value: TypesInferenceChunkingSettings) =
            { state with InferencePutJinaaiRequest.ChunkingSettings = Option.Some value } : InferencePutJinaaiRequest

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutJinaaiRequest, value: TypesJinaAIServiceType) =
            { state with InferencePutJinaaiRequest.Service = value } : InferencePutJinaaiRequest

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutJinaaiRequest, value: TypesJinaAIServiceSettings) =
            { state with InferencePutJinaaiRequest.ServiceSettings = value } : InferencePutJinaaiRequest

        [<CustomOperation("task_settings")>]
        member _.TaskSettings(state: InferencePutJinaaiRequest, value: TypesJinaAITaskSettings) =
            { state with InferencePutJinaaiRequest.TaskSettings = Option.Some value } : InferencePutJinaaiRequest

    let inferencePutJinaaiRequest = InferencePutJinaaiRequestBuilder()

    type InferencePutJinaaiResponse = TypesInferenceEndpointInfoJinaAi

    type InferencePutLlamaRequest = {
        TaskType: TypesLlamaTaskType
        LlamaInferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("chunking_settings")>]
        ChunkingSettings: TypesInferenceChunkingSettings option
        [<JsonPropertyName("service")>]
        Service: TypesLlamaServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesLlamaServiceSettings
    } with
        static member ToRequest(request: InferencePutLlamaRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.LlamaInferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutLlamaRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutLlamaRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutLlamaRequest.ToRequest request

    type InferencePutLlamaRequestBuilder() =
        member _.Yield(_: unit) : InferencePutLlamaRequest =
            {
                InferencePutLlamaRequest.TaskType = Unchecked.defaultof<TypesLlamaTaskType>
                InferencePutLlamaRequest.LlamaInferenceId = Unchecked.defaultof<Id>
                InferencePutLlamaRequest.Timeout = Option.None
                InferencePutLlamaRequest.ChunkingSettings = Option.None
                InferencePutLlamaRequest.Service = Unchecked.defaultof<TypesLlamaServiceType>
                InferencePutLlamaRequest.ServiceSettings = Unchecked.defaultof<TypesLlamaServiceSettings>
            } : InferencePutLlamaRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutLlamaRequest, value: TypesLlamaTaskType) =
            { state with InferencePutLlamaRequest.TaskType = value } : InferencePutLlamaRequest

        [<CustomOperation("llama_inference_id")>]
        member _.LlamaInferenceId(state: InferencePutLlamaRequest, value: Id) =
            { state with InferencePutLlamaRequest.LlamaInferenceId = value } : InferencePutLlamaRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutLlamaRequest, value: Duration) =
            { state with InferencePutLlamaRequest.Timeout = Option.Some value } : InferencePutLlamaRequest

        [<CustomOperation("chunking_settings")>]
        member _.ChunkingSettings(state: InferencePutLlamaRequest, value: TypesInferenceChunkingSettings) =
            { state with InferencePutLlamaRequest.ChunkingSettings = Option.Some value } : InferencePutLlamaRequest

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutLlamaRequest, value: TypesLlamaServiceType) =
            { state with InferencePutLlamaRequest.Service = value } : InferencePutLlamaRequest

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutLlamaRequest, value: TypesLlamaServiceSettings) =
            { state with InferencePutLlamaRequest.ServiceSettings = value } : InferencePutLlamaRequest

    let inferencePutLlamaRequest = InferencePutLlamaRequestBuilder()

    type InferencePutLlamaResponse = TypesInferenceEndpointInfoLlama

    type InferencePutMistralRequest = {
        TaskType: TypesMistralTaskType
        MistralInferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("chunking_settings")>]
        ChunkingSettings: TypesInferenceChunkingSettings option
        [<JsonPropertyName("service")>]
        Service: TypesMistralServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesMistralServiceSettings
    } with
        static member ToRequest(request: InferencePutMistralRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.MistralInferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutMistralRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutMistralRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutMistralRequest.ToRequest request

    type InferencePutMistralRequestBuilder() =
        member _.Yield(_: unit) : InferencePutMistralRequest =
            {
                InferencePutMistralRequest.TaskType = Unchecked.defaultof<TypesMistralTaskType>
                InferencePutMistralRequest.MistralInferenceId = Unchecked.defaultof<Id>
                InferencePutMistralRequest.Timeout = Option.None
                InferencePutMistralRequest.ChunkingSettings = Option.None
                InferencePutMistralRequest.Service = Unchecked.defaultof<TypesMistralServiceType>
                InferencePutMistralRequest.ServiceSettings = Unchecked.defaultof<TypesMistralServiceSettings>
            } : InferencePutMistralRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutMistralRequest, value: TypesMistralTaskType) =
            { state with InferencePutMistralRequest.TaskType = value } : InferencePutMistralRequest

        [<CustomOperation("mistral_inference_id")>]
        member _.MistralInferenceId(state: InferencePutMistralRequest, value: Id) =
            { state with InferencePutMistralRequest.MistralInferenceId = value } : InferencePutMistralRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutMistralRequest, value: Duration) =
            { state with InferencePutMistralRequest.Timeout = Option.Some value } : InferencePutMistralRequest

        [<CustomOperation("chunking_settings")>]
        member _.ChunkingSettings(state: InferencePutMistralRequest, value: TypesInferenceChunkingSettings) =
            { state with InferencePutMistralRequest.ChunkingSettings = Option.Some value } : InferencePutMistralRequest

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutMistralRequest, value: TypesMistralServiceType) =
            { state with InferencePutMistralRequest.Service = value } : InferencePutMistralRequest

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutMistralRequest, value: TypesMistralServiceSettings) =
            { state with InferencePutMistralRequest.ServiceSettings = value } : InferencePutMistralRequest

    let inferencePutMistralRequest = InferencePutMistralRequestBuilder()

    type InferencePutMistralResponse = TypesInferenceEndpointInfoMistral

    type InferencePutNvidiaRequest = {
        TaskType: TypesNvidiaTaskType
        NvidiaInferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("chunking_settings")>]
        ChunkingSettings: TypesInferenceChunkingSettings option
        [<JsonPropertyName("service")>]
        Service: TypesNvidiaServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesNvidiaServiceSettings
        [<JsonPropertyName("task_settings")>]
        TaskSettings: TypesNvidiaTaskSettings option
    } with
        static member ToRequest(request: InferencePutNvidiaRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.NvidiaInferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutNvidiaRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutNvidiaRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutNvidiaRequest.ToRequest request

    type InferencePutNvidiaRequestBuilder() =
        member _.Yield(_: unit) : InferencePutNvidiaRequest =
            {
                InferencePutNvidiaRequest.TaskType = Unchecked.defaultof<TypesNvidiaTaskType>
                InferencePutNvidiaRequest.NvidiaInferenceId = Unchecked.defaultof<Id>
                InferencePutNvidiaRequest.Timeout = Option.None
                InferencePutNvidiaRequest.ChunkingSettings = Option.None
                InferencePutNvidiaRequest.Service = Unchecked.defaultof<TypesNvidiaServiceType>
                InferencePutNvidiaRequest.ServiceSettings = Unchecked.defaultof<TypesNvidiaServiceSettings>
                InferencePutNvidiaRequest.TaskSettings = Option.None
            } : InferencePutNvidiaRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutNvidiaRequest, value: TypesNvidiaTaskType) =
            { state with InferencePutNvidiaRequest.TaskType = value } : InferencePutNvidiaRequest

        [<CustomOperation("nvidia_inference_id")>]
        member _.NvidiaInferenceId(state: InferencePutNvidiaRequest, value: Id) =
            { state with InferencePutNvidiaRequest.NvidiaInferenceId = value } : InferencePutNvidiaRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutNvidiaRequest, value: Duration) =
            { state with InferencePutNvidiaRequest.Timeout = Option.Some value } : InferencePutNvidiaRequest

        [<CustomOperation("chunking_settings")>]
        member _.ChunkingSettings(state: InferencePutNvidiaRequest, value: TypesInferenceChunkingSettings) =
            { state with InferencePutNvidiaRequest.ChunkingSettings = Option.Some value } : InferencePutNvidiaRequest

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutNvidiaRequest, value: TypesNvidiaServiceType) =
            { state with InferencePutNvidiaRequest.Service = value } : InferencePutNvidiaRequest

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutNvidiaRequest, value: TypesNvidiaServiceSettings) =
            { state with InferencePutNvidiaRequest.ServiceSettings = value } : InferencePutNvidiaRequest

        [<CustomOperation("task_settings")>]
        member _.TaskSettings(state: InferencePutNvidiaRequest, value: TypesNvidiaTaskSettings) =
            { state with InferencePutNvidiaRequest.TaskSettings = Option.Some value } : InferencePutNvidiaRequest

    let inferencePutNvidiaRequest = InferencePutNvidiaRequestBuilder()

    type InferencePutNvidiaResponse = TypesInferenceEndpointInfoNvidia

    type InferencePutOpenaiRequest = {
        TaskType: TypesOpenAITaskType
        OpenaiInferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("chunking_settings")>]
        ChunkingSettings: TypesInferenceChunkingSettings option
        [<JsonPropertyName("service")>]
        Service: TypesOpenAIServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesOpenAIServiceSettings
        [<JsonPropertyName("task_settings")>]
        TaskSettings: TypesOpenAITaskSettings option
    } with
        static member ToRequest(request: InferencePutOpenaiRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.OpenaiInferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutOpenaiRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutOpenaiRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutOpenaiRequest.ToRequest request

    type InferencePutOpenaiRequestBuilder() =
        member _.Yield(_: unit) : InferencePutOpenaiRequest =
            {
                InferencePutOpenaiRequest.TaskType = Unchecked.defaultof<TypesOpenAITaskType>
                InferencePutOpenaiRequest.OpenaiInferenceId = Unchecked.defaultof<Id>
                InferencePutOpenaiRequest.Timeout = Option.None
                InferencePutOpenaiRequest.ChunkingSettings = Option.None
                InferencePutOpenaiRequest.Service = Unchecked.defaultof<TypesOpenAIServiceType>
                InferencePutOpenaiRequest.ServiceSettings = Unchecked.defaultof<TypesOpenAIServiceSettings>
                InferencePutOpenaiRequest.TaskSettings = Option.None
            } : InferencePutOpenaiRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutOpenaiRequest, value: TypesOpenAITaskType) =
            { state with InferencePutOpenaiRequest.TaskType = value } : InferencePutOpenaiRequest

        [<CustomOperation("openai_inference_id")>]
        member _.OpenaiInferenceId(state: InferencePutOpenaiRequest, value: Id) =
            { state with InferencePutOpenaiRequest.OpenaiInferenceId = value } : InferencePutOpenaiRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutOpenaiRequest, value: Duration) =
            { state with InferencePutOpenaiRequest.Timeout = Option.Some value } : InferencePutOpenaiRequest

        [<CustomOperation("chunking_settings")>]
        member _.ChunkingSettings(state: InferencePutOpenaiRequest, value: TypesInferenceChunkingSettings) =
            { state with InferencePutOpenaiRequest.ChunkingSettings = Option.Some value } : InferencePutOpenaiRequest

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutOpenaiRequest, value: TypesOpenAIServiceType) =
            { state with InferencePutOpenaiRequest.Service = value } : InferencePutOpenaiRequest

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutOpenaiRequest, value: TypesOpenAIServiceSettings) =
            { state with InferencePutOpenaiRequest.ServiceSettings = value } : InferencePutOpenaiRequest

        [<CustomOperation("task_settings")>]
        member _.TaskSettings(state: InferencePutOpenaiRequest, value: TypesOpenAITaskSettings) =
            { state with InferencePutOpenaiRequest.TaskSettings = Option.Some value } : InferencePutOpenaiRequest

    let inferencePutOpenaiRequest = InferencePutOpenaiRequestBuilder()

    type InferencePutOpenaiResponse = TypesInferenceEndpointInfoOpenAI

    type InferencePutOpenshiftAiRequest = {
        TaskType: TypesOpenShiftAiTaskType
        OpenshiftaiInferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("chunking_settings")>]
        ChunkingSettings: TypesInferenceChunkingSettings option
        [<JsonPropertyName("service")>]
        Service: TypesOpenShiftAiServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesOpenShiftAiServiceSettings
        [<JsonPropertyName("task_settings")>]
        TaskSettings: TypesOpenShiftAiTaskSettings option
    } with
        static member ToRequest(request: InferencePutOpenshiftAiRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.OpenshiftaiInferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutOpenshiftAiRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutOpenshiftAiRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutOpenshiftAiRequest.ToRequest request

    type InferencePutOpenshiftAiRequestBuilder() =
        member _.Yield(_: unit) : InferencePutOpenshiftAiRequest =
            {
                InferencePutOpenshiftAiRequest.TaskType = Unchecked.defaultof<TypesOpenShiftAiTaskType>
                InferencePutOpenshiftAiRequest.OpenshiftaiInferenceId = Unchecked.defaultof<Id>
                InferencePutOpenshiftAiRequest.Timeout = Option.None
                InferencePutOpenshiftAiRequest.ChunkingSettings = Option.None
                InferencePutOpenshiftAiRequest.Service = Unchecked.defaultof<TypesOpenShiftAiServiceType>
                InferencePutOpenshiftAiRequest.ServiceSettings = Unchecked.defaultof<TypesOpenShiftAiServiceSettings>
                InferencePutOpenshiftAiRequest.TaskSettings = Option.None
            } : InferencePutOpenshiftAiRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutOpenshiftAiRequest, value: TypesOpenShiftAiTaskType) =
            { state with InferencePutOpenshiftAiRequest.TaskType = value } : InferencePutOpenshiftAiRequest

        [<CustomOperation("openshiftai_inference_id")>]
        member _.OpenshiftaiInferenceId(state: InferencePutOpenshiftAiRequest, value: Id) =
            { state with InferencePutOpenshiftAiRequest.OpenshiftaiInferenceId = value } : InferencePutOpenshiftAiRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutOpenshiftAiRequest, value: Duration) =
            { state with InferencePutOpenshiftAiRequest.Timeout = Option.Some value } : InferencePutOpenshiftAiRequest

        [<CustomOperation("chunking_settings")>]
        member _.ChunkingSettings(state: InferencePutOpenshiftAiRequest, value: TypesInferenceChunkingSettings) =
            { state with InferencePutOpenshiftAiRequest.ChunkingSettings = Option.Some value } : InferencePutOpenshiftAiRequest

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutOpenshiftAiRequest, value: TypesOpenShiftAiServiceType) =
            { state with InferencePutOpenshiftAiRequest.Service = value } : InferencePutOpenshiftAiRequest

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutOpenshiftAiRequest, value: TypesOpenShiftAiServiceSettings) =
            { state with InferencePutOpenshiftAiRequest.ServiceSettings = value } : InferencePutOpenshiftAiRequest

        [<CustomOperation("task_settings")>]
        member _.TaskSettings(state: InferencePutOpenshiftAiRequest, value: TypesOpenShiftAiTaskSettings) =
            { state with InferencePutOpenshiftAiRequest.TaskSettings = Option.Some value } : InferencePutOpenshiftAiRequest

    let inferencePutOpenshiftAiRequest = InferencePutOpenshiftAiRequestBuilder()

    type InferencePutOpenshiftAiResponse = TypesInferenceEndpointInfoOpenShiftAi

    type InferencePutVoyageaiRequest = {
        TaskType: TypesVoyageAITaskType
        VoyageaiInferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("chunking_settings")>]
        ChunkingSettings: TypesInferenceChunkingSettings option
        [<JsonPropertyName("service")>]
        Service: TypesVoyageAIServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesVoyageAIServiceSettings
        [<JsonPropertyName("task_settings")>]
        TaskSettings: TypesVoyageAITaskSettings option
    } with
        static member ToRequest(request: InferencePutVoyageaiRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.VoyageaiInferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutVoyageaiRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutVoyageaiRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutVoyageaiRequest.ToRequest request

    type InferencePutVoyageaiRequestBuilder() =
        member _.Yield(_: unit) : InferencePutVoyageaiRequest =
            {
                InferencePutVoyageaiRequest.TaskType = Unchecked.defaultof<TypesVoyageAITaskType>
                InferencePutVoyageaiRequest.VoyageaiInferenceId = Unchecked.defaultof<Id>
                InferencePutVoyageaiRequest.Timeout = Option.None
                InferencePutVoyageaiRequest.ChunkingSettings = Option.None
                InferencePutVoyageaiRequest.Service = Unchecked.defaultof<TypesVoyageAIServiceType>
                InferencePutVoyageaiRequest.ServiceSettings = Unchecked.defaultof<TypesVoyageAIServiceSettings>
                InferencePutVoyageaiRequest.TaskSettings = Option.None
            } : InferencePutVoyageaiRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutVoyageaiRequest, value: TypesVoyageAITaskType) =
            { state with InferencePutVoyageaiRequest.TaskType = value } : InferencePutVoyageaiRequest

        [<CustomOperation("voyageai_inference_id")>]
        member _.VoyageaiInferenceId(state: InferencePutVoyageaiRequest, value: Id) =
            { state with InferencePutVoyageaiRequest.VoyageaiInferenceId = value } : InferencePutVoyageaiRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutVoyageaiRequest, value: Duration) =
            { state with InferencePutVoyageaiRequest.Timeout = Option.Some value } : InferencePutVoyageaiRequest

        [<CustomOperation("chunking_settings")>]
        member _.ChunkingSettings(state: InferencePutVoyageaiRequest, value: TypesInferenceChunkingSettings) =
            { state with InferencePutVoyageaiRequest.ChunkingSettings = Option.Some value } : InferencePutVoyageaiRequest

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutVoyageaiRequest, value: TypesVoyageAIServiceType) =
            { state with InferencePutVoyageaiRequest.Service = value } : InferencePutVoyageaiRequest

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutVoyageaiRequest, value: TypesVoyageAIServiceSettings) =
            { state with InferencePutVoyageaiRequest.ServiceSettings = value } : InferencePutVoyageaiRequest

        [<CustomOperation("task_settings")>]
        member _.TaskSettings(state: InferencePutVoyageaiRequest, value: TypesVoyageAITaskSettings) =
            { state with InferencePutVoyageaiRequest.TaskSettings = Option.Some value } : InferencePutVoyageaiRequest

    let inferencePutVoyageaiRequest = InferencePutVoyageaiRequestBuilder()

    type InferencePutVoyageaiResponse = TypesInferenceEndpointInfoVoyageAI

    type InferencePutWatsonxRequest = {
        TaskType: TypesWatsonxTaskType
        WatsonxInferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("chunking_settings")>]
        ChunkingSettings: TypesInferenceChunkingSettings option
        [<JsonPropertyName("service")>]
        Service: TypesWatsonxServiceType
        [<JsonPropertyName("service_settings")>]
        ServiceSettings: TypesWatsonxServiceSettings
    } with
        static member ToRequest(request: InferencePutWatsonxRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.WatsonxInferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferencePutWatsonxRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferencePutWatsonxRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferencePutWatsonxRequest.ToRequest request

    type InferencePutWatsonxRequestBuilder() =
        member _.Yield(_: unit) : InferencePutWatsonxRequest =
            {
                InferencePutWatsonxRequest.TaskType = Unchecked.defaultof<TypesWatsonxTaskType>
                InferencePutWatsonxRequest.WatsonxInferenceId = Unchecked.defaultof<Id>
                InferencePutWatsonxRequest.Timeout = Option.None
                InferencePutWatsonxRequest.ChunkingSettings = Option.None
                InferencePutWatsonxRequest.Service = Unchecked.defaultof<TypesWatsonxServiceType>
                InferencePutWatsonxRequest.ServiceSettings = Unchecked.defaultof<TypesWatsonxServiceSettings>
            } : InferencePutWatsonxRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferencePutWatsonxRequest, value: TypesWatsonxTaskType) =
            { state with InferencePutWatsonxRequest.TaskType = value } : InferencePutWatsonxRequest

        [<CustomOperation("watsonx_inference_id")>]
        member _.WatsonxInferenceId(state: InferencePutWatsonxRequest, value: Id) =
            { state with InferencePutWatsonxRequest.WatsonxInferenceId = value } : InferencePutWatsonxRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutWatsonxRequest, value: Duration) =
            { state with InferencePutWatsonxRequest.Timeout = Option.Some value } : InferencePutWatsonxRequest

        [<CustomOperation("chunking_settings")>]
        member _.ChunkingSettings(state: InferencePutWatsonxRequest, value: TypesInferenceChunkingSettings) =
            { state with InferencePutWatsonxRequest.ChunkingSettings = Option.Some value } : InferencePutWatsonxRequest

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutWatsonxRequest, value: TypesWatsonxServiceType) =
            { state with InferencePutWatsonxRequest.Service = value } : InferencePutWatsonxRequest

        [<CustomOperation("service_settings")>]
        member _.ServiceSettings(state: InferencePutWatsonxRequest, value: TypesWatsonxServiceSettings) =
            { state with InferencePutWatsonxRequest.ServiceSettings = value } : InferencePutWatsonxRequest

    let inferencePutWatsonxRequest = InferencePutWatsonxRequestBuilder()

    type InferencePutWatsonxResponse = TypesInferenceEndpointInfoWatsonx

    type InferenceRerankRequest = {
        InferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("query")>]
        Query: string
        [<JsonPropertyName("input")>]
        Input: string array
        [<JsonPropertyName("return_documents")>]
        ReturnDocuments: bool option
        [<JsonPropertyName("top_n")>]
        TopN: float option
        [<JsonPropertyName("task_settings")>]
        TaskSettings: TypesTaskSettings option
    } with
        static member ToRequest(request: InferenceRerankRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/rerank/{request.InferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferenceRerankRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferenceRerankRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferenceRerankRequest.ToRequest request

    type InferenceRerankRequestBuilder() =
        member _.Yield(_: unit) : InferenceRerankRequest =
            {
                InferenceRerankRequest.InferenceId = Unchecked.defaultof<Id>
                InferenceRerankRequest.Timeout = Option.None
                InferenceRerankRequest.Query = String.Empty
                InferenceRerankRequest.Input = [||]
                InferenceRerankRequest.ReturnDocuments = Option.None
                InferenceRerankRequest.TopN = Option.None
                InferenceRerankRequest.TaskSettings = Option.None
            } : InferenceRerankRequest

        [<CustomOperation("inference_id")>]
        member _.InferenceId(state: InferenceRerankRequest, value: Id) =
            { state with InferenceRerankRequest.InferenceId = value } : InferenceRerankRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferenceRerankRequest, value: Duration) =
            { state with InferenceRerankRequest.Timeout = Option.Some value } : InferenceRerankRequest

        [<CustomOperation("query")>]
        member _.Query(state: InferenceRerankRequest, value: string) =
            { state with InferenceRerankRequest.Query = value } : InferenceRerankRequest

        [<CustomOperation("input")>]
        member _.Input(state: InferenceRerankRequest, value: string array) =
            { state with InferenceRerankRequest.Input = value } : InferenceRerankRequest

        [<CustomOperation("return_documents")>]
        member _.ReturnDocuments(state: InferenceRerankRequest, value: bool) =
            { state with InferenceRerankRequest.ReturnDocuments = Option.Some value } : InferenceRerankRequest

        [<CustomOperation("top_n")>]
        member _.TopN(state: InferenceRerankRequest, value: float) =
            { state with InferenceRerankRequest.TopN = Option.Some value } : InferenceRerankRequest

        [<CustomOperation("task_settings")>]
        member _.TaskSettings(state: InferenceRerankRequest, value: TypesTaskSettings) =
            { state with InferenceRerankRequest.TaskSettings = Option.Some value } : InferenceRerankRequest

    let inferenceRerankRequest = InferenceRerankRequestBuilder()

    type InferenceRerankResponse = TypesRerankedInferenceResult

    type InferenceSparseEmbeddingRequest = {
        InferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("input")>]
        Input: System.Text.Json.JsonElement
        [<JsonPropertyName("task_settings")>]
        TaskSettings: TypesTaskSettings option
    } with
        static member ToRequest(request: InferenceSparseEmbeddingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/sparse_embedding/{request.InferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferenceSparseEmbeddingRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferenceSparseEmbeddingRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferenceSparseEmbeddingRequest.ToRequest request

    type InferenceSparseEmbeddingRequestBuilder() =
        member _.Yield(_: unit) : InferenceSparseEmbeddingRequest =
            {
                InferenceSparseEmbeddingRequest.InferenceId = Unchecked.defaultof<Id>
                InferenceSparseEmbeddingRequest.Timeout = Option.None
                InferenceSparseEmbeddingRequest.Input = Unchecked.defaultof<System.Text.Json.JsonElement>
                InferenceSparseEmbeddingRequest.TaskSettings = Option.None
            } : InferenceSparseEmbeddingRequest

        [<CustomOperation("inference_id")>]
        member _.InferenceId(state: InferenceSparseEmbeddingRequest, value: Id) =
            { state with InferenceSparseEmbeddingRequest.InferenceId = value } : InferenceSparseEmbeddingRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferenceSparseEmbeddingRequest, value: Duration) =
            { state with InferenceSparseEmbeddingRequest.Timeout = Option.Some value } : InferenceSparseEmbeddingRequest

        [<CustomOperation("input")>]
        member _.Input(state: InferenceSparseEmbeddingRequest, value: System.Text.Json.JsonElement) =
            { state with InferenceSparseEmbeddingRequest.Input = value } : InferenceSparseEmbeddingRequest

        [<CustomOperation("task_settings")>]
        member _.TaskSettings(state: InferenceSparseEmbeddingRequest, value: TypesTaskSettings) =
            { state with InferenceSparseEmbeddingRequest.TaskSettings = Option.Some value } : InferenceSparseEmbeddingRequest

    let inferenceSparseEmbeddingRequest = InferenceSparseEmbeddingRequestBuilder()

    type InferenceSparseEmbeddingResponse = TypesSparseEmbeddingInferenceResult

    type InferenceStreamCompletionRequest = {
        InferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("input")>]
        Input: System.Text.Json.JsonElement
        [<JsonPropertyName("task_settings")>]
        TaskSettings: TypesTaskSettings option
    } with
        static member ToRequest(request: InferenceStreamCompletionRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/completion/{request.InferenceId}/_stream"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferenceStreamCompletionRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferenceStreamCompletionRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferenceStreamCompletionRequest.ToRequest request

    type InferenceStreamCompletionRequestBuilder() =
        member _.Yield(_: unit) : InferenceStreamCompletionRequest =
            {
                InferenceStreamCompletionRequest.InferenceId = Unchecked.defaultof<Id>
                InferenceStreamCompletionRequest.Timeout = Option.None
                InferenceStreamCompletionRequest.Input = Unchecked.defaultof<System.Text.Json.JsonElement>
                InferenceStreamCompletionRequest.TaskSettings = Option.None
            } : InferenceStreamCompletionRequest

        [<CustomOperation("inference_id")>]
        member _.InferenceId(state: InferenceStreamCompletionRequest, value: Id) =
            { state with InferenceStreamCompletionRequest.InferenceId = value } : InferenceStreamCompletionRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferenceStreamCompletionRequest, value: Duration) =
            { state with InferenceStreamCompletionRequest.Timeout = Option.Some value } : InferenceStreamCompletionRequest

        [<CustomOperation("input")>]
        member _.Input(state: InferenceStreamCompletionRequest, value: System.Text.Json.JsonElement) =
            { state with InferenceStreamCompletionRequest.Input = value } : InferenceStreamCompletionRequest

        [<CustomOperation("task_settings")>]
        member _.TaskSettings(state: InferenceStreamCompletionRequest, value: TypesTaskSettings) =
            { state with InferenceStreamCompletionRequest.TaskSettings = Option.Some value } : InferenceStreamCompletionRequest

    let inferenceStreamCompletionRequest = InferenceStreamCompletionRequestBuilder()

    type InferenceStreamCompletionResponse = StreamResult

    type InferenceTextEmbeddingRequest = {
        InferenceId: Id
        Timeout: Duration option
        [<JsonPropertyName("input")>]
        Input: System.Text.Json.JsonElement
        [<JsonPropertyName("input_type")>]
        InputType: string option
        [<JsonPropertyName("task_settings")>]
        TaskSettings: TypesTaskSettings option
    } with
        static member ToRequest(request: InferenceTextEmbeddingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/text_embedding/{request.InferenceId}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module InferenceTextEmbeddingRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferenceTextEmbeddingRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferenceTextEmbeddingRequest.ToRequest request

    type InferenceTextEmbeddingRequestBuilder() =
        member _.Yield(_: unit) : InferenceTextEmbeddingRequest =
            {
                InferenceTextEmbeddingRequest.InferenceId = Unchecked.defaultof<Id>
                InferenceTextEmbeddingRequest.Timeout = Option.None
                InferenceTextEmbeddingRequest.Input = Unchecked.defaultof<System.Text.Json.JsonElement>
                InferenceTextEmbeddingRequest.InputType = Option.None
                InferenceTextEmbeddingRequest.TaskSettings = Option.None
            } : InferenceTextEmbeddingRequest

        [<CustomOperation("inference_id")>]
        member _.InferenceId(state: InferenceTextEmbeddingRequest, value: Id) =
            { state with InferenceTextEmbeddingRequest.InferenceId = value } : InferenceTextEmbeddingRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferenceTextEmbeddingRequest, value: Duration) =
            { state with InferenceTextEmbeddingRequest.Timeout = Option.Some value } : InferenceTextEmbeddingRequest

        [<CustomOperation("input")>]
        member _.Input(state: InferenceTextEmbeddingRequest, value: System.Text.Json.JsonElement) =
            { state with InferenceTextEmbeddingRequest.Input = value } : InferenceTextEmbeddingRequest

        [<CustomOperation("input_type")>]
        member _.InputType(state: InferenceTextEmbeddingRequest, value: string) =
            { state with InferenceTextEmbeddingRequest.InputType = Option.Some value } : InferenceTextEmbeddingRequest

        [<CustomOperation("task_settings")>]
        member _.TaskSettings(state: InferenceTextEmbeddingRequest, value: TypesTaskSettings) =
            { state with InferenceTextEmbeddingRequest.TaskSettings = Option.Some value } : InferenceTextEmbeddingRequest

    let inferenceTextEmbeddingRequest = InferenceTextEmbeddingRequestBuilder()

    type InferenceTextEmbeddingResponse = TypesTextEmbeddingInferenceResult

    type InferenceUpdateRequest = {
        TaskType: TypesTaskType
        InferenceId: Id
        [<JsonPropertyName("body")>]
        Body: TypesInferenceEndpoint
    } with
        static member ToRequest(request: InferenceUpdateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{request.TaskType}/{request.InferenceId}/_update"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request.Body
                |> Result.Ok
            with ex -> Result.Error ex

    module InferenceUpdateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: InferenceUpdateRequest) : Result<Fes.Http.RequestMsg, exn> =
            InferenceUpdateRequest.ToRequest request

    type InferenceUpdateRequestBuilder() =
        member _.Yield(_: unit) : InferenceUpdateRequest =
            {
                InferenceUpdateRequest.TaskType = Unchecked.defaultof<TypesTaskType>
                InferenceUpdateRequest.InferenceId = Unchecked.defaultof<Id>
                InferenceUpdateRequest.Body = Unchecked.defaultof<TypesInferenceEndpoint>
            } : InferenceUpdateRequest

        [<CustomOperation("task_type")>]
        member _.TaskType(state: InferenceUpdateRequest, value: TypesTaskType) =
            { state with InferenceUpdateRequest.TaskType = value } : InferenceUpdateRequest

        [<CustomOperation("inference_id")>]
        member _.InferenceId(state: InferenceUpdateRequest, value: Id) =
            { state with InferenceUpdateRequest.InferenceId = value } : InferenceUpdateRequest

        [<CustomOperation("body")>]
        member _.Body(state: InferenceUpdateRequest, value: TypesInferenceEndpoint) =
            { state with InferenceUpdateRequest.Body = value } : InferenceUpdateRequest

    let inferenceUpdateRequest = InferenceUpdateRequestBuilder()


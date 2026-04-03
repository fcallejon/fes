// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module InferenceOperations =

    type InferenceChatCompletionUnifiedRequest = {
        InferenceId: Types.Id
        Timeout: Types.Duration option
        Document: obj
    }

        with
        static member ToEndpoint(req: InferenceChatCompletionUnifiedRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/chat_completion/{req.InferenceId}/_stream"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req.Document)
            endpoint, ValueSome postData

    type InferenceChatCompletionUnifiedResponse = Types.StreamResult

    type InferenceChatCompletionUnifiedRequestBuilder() =
        member _.Yield(_: unit) : InferenceChatCompletionUnifiedRequest =
            {
                InferenceId = Unchecked.defaultof<_>
                Timeout = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: InferenceChatCompletionUnifiedRequest, value: Types.Id) =
            { state with InferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferenceChatCompletionUnifiedRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: InferenceChatCompletionUnifiedRequest, value) =
            { state with Document = value }

    let inferenceChatCompletionUnifiedRequest = InferenceChatCompletionUnifiedRequestBuilder()

    module ChatCompletionUnified =
        let withTimeout (value: Types.Duration) (req: InferenceChatCompletionUnifiedRequest) =
            { req with Timeout = Some value }

    type InferenceCompletionRequest = {
        InferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("input")>]
        Input: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: Types.TaskSettings option
    }

        with
        static member ToEndpoint(req: InferenceCompletionRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/completion/{req.InferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferenceCompletionResponse = Types.CompletionInferenceResult

    type InferenceCompletionRequestBuilder() =
        member _.Yield(_: unit) : InferenceCompletionRequest =
            {
                InferenceId = Unchecked.defaultof<_>
                Timeout = None
                Input = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: InferenceCompletionRequest, value: Types.Id) =
            { state with InferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferenceCompletionRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("input")>]
        member _.Input(state: InferenceCompletionRequest, value: System.Text.Json.JsonElement) =
            { state with Input = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferenceCompletionRequest, value: Types.TaskSettings) =
            { state with TaskSettings = Some value }

    let inferenceCompletionRequest = InferenceCompletionRequestBuilder()

    module Completion =
        let withTimeout (value: Types.Duration) (req: InferenceCompletionRequest) =
            { req with Timeout = Some value }
        let withInput (value: System.Text.Json.JsonElement) (req: InferenceCompletionRequest) =
            { req with Input = value }
        let withTaskSettings (value: Types.TaskSettings) (req: InferenceCompletionRequest) =
            { req with TaskSettings = Some value }

    type InferenceDeleteRequest = {
        TaskType: Types.TaskType
        InferenceId: Types.Id
        DryRun: bool option
        Force: bool option
    }

        with
        static member ToEndpoint(req: InferenceDeleteRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.InferenceId}"
            let queryParams =
                [
                    req.DryRun |> Option.map (fun v -> "dry_run", Fes.Http.toQueryValue v)
                    req.Force |> Option.map (fun v -> "force", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type InferenceDeleteResponse = Types.DeleteInferenceEndpointResult

    type InferenceDeleteRequestBuilder() =
        member _.Yield(_: unit) : InferenceDeleteRequest =
            {
                TaskType = Unchecked.defaultof<_>
                InferenceId = Unchecked.defaultof<_>
                DryRun = None
                Force = None
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferenceDeleteRequest, value: Types.TaskType) =
            { state with TaskType = value }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: InferenceDeleteRequest, value: Types.Id) =
            { state with InferenceId = value }

        [<CustomOperation("dryRun")>]
        member _.DryRun(state: InferenceDeleteRequest, value: bool) =
            { state with DryRun = Some value }

        [<CustomOperation("force")>]
        member _.Force(state: InferenceDeleteRequest, value: bool) =
            { state with Force = Some value }

    let inferenceDeleteRequest = InferenceDeleteRequestBuilder()

    module Delete =
        let withDryRun (value: bool) (req: InferenceDeleteRequest) =
            { req with DryRun = Some value }
        let withForce (value: bool) (req: InferenceDeleteRequest) =
            { req with Force = Some value }

    type InferenceEmbeddingRequest = {
        InferenceId: Types.Id
        Timeout: Types.Duration option
        Document: obj
    }

        with
        static member ToEndpoint(req: InferenceEmbeddingRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/embedding/{req.InferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req.Document)
            endpoint, ValueSome postData

    type InferenceEmbeddingResponse = Types.EmbeddingInferenceResult

    type InferenceEmbeddingRequestBuilder() =
        member _.Yield(_: unit) : InferenceEmbeddingRequest =
            {
                InferenceId = Unchecked.defaultof<_>
                Timeout = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: InferenceEmbeddingRequest, value: Types.Id) =
            { state with InferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferenceEmbeddingRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: InferenceEmbeddingRequest, value) =
            { state with Document = value }

    let inferenceEmbeddingRequest = InferenceEmbeddingRequestBuilder()

    module Embedding =
        let withTimeout (value: Types.Duration) (req: InferenceEmbeddingRequest) =
            { req with Timeout = Some value }

    type InferenceGetRequest = {
        TaskType: Types.TaskType
        InferenceId: Types.Id
    }

        with
        static member ToEndpoint(req: InferenceGetRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.InferenceId}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type InferenceGetResponse = System.Text.Json.JsonElement

    type InferenceGetRequestBuilder() =
        member _.Yield(_: unit) : InferenceGetRequest =
            {
                TaskType = Unchecked.defaultof<_>
                InferenceId = Unchecked.defaultof<_>
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferenceGetRequest, value: Types.TaskType) =
            { state with TaskType = value }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: InferenceGetRequest, value: Types.Id) =
            { state with InferenceId = value }

    let inferenceGetRequest = InferenceGetRequestBuilder()

    type InferenceInferenceRequest = {
        TaskType: Types.TaskType
        InferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string option
        [<System.Text.Json.Serialization.JsonPropertyName("input")>]
        Input: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("input_type")>]
        InputType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: Types.TaskSettings option
    }

        with
        static member ToEndpoint(req: InferenceInferenceRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.InferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferenceInferenceResponse = Types.InferenceResult

    type InferenceInferenceRequestBuilder() =
        member _.Yield(_: unit) : InferenceInferenceRequest =
            {
                TaskType = Unchecked.defaultof<_>
                InferenceId = Unchecked.defaultof<_>
                Timeout = None
                Query = None
                Input = Unchecked.defaultof<_>
                InputType = None
                TaskSettings = None
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferenceInferenceRequest, value: Types.TaskType) =
            { state with TaskType = value }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: InferenceInferenceRequest, value: Types.Id) =
            { state with InferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferenceInferenceRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: InferenceInferenceRequest, value: string) =
            { state with Query = Some value }

        [<CustomOperation("input")>]
        member _.Input(state: InferenceInferenceRequest, value: System.Text.Json.JsonElement) =
            { state with Input = value }

        [<CustomOperation("inputType")>]
        member _.InputType(state: InferenceInferenceRequest, value: string) =
            { state with InputType = Some value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferenceInferenceRequest, value: Types.TaskSettings) =
            { state with TaskSettings = Some value }

    let inferenceInferenceRequest = InferenceInferenceRequestBuilder()

    module Inference =
        let withTimeout (value: Types.Duration) (req: InferenceInferenceRequest) =
            { req with Timeout = Some value }
        let withQuery (value: string) (req: InferenceInferenceRequest) =
            { req with Query = Some value }
        let withInput (value: System.Text.Json.JsonElement) (req: InferenceInferenceRequest) =
            { req with Input = value }
        let withInputType (value: string) (req: InferenceInferenceRequest) =
            { req with InputType = Some value }
        let withTaskSettings (value: Types.TaskSettings) (req: InferenceInferenceRequest) =
            { req with TaskSettings = Some value }

    type InferencePutRequest = {
        TaskType: Types.TaskType
        InferenceId: Types.Id
        Timeout: Types.Duration option
        Document: obj
    }

        with
        static member ToEndpoint(req: InferencePutRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.InferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req.Document)
            endpoint, ValueSome postData

    type InferencePutResponse = Types.InferenceEndpointInfo

    type InferencePutRequestBuilder() =
        member _.Yield(_: unit) : InferencePutRequest =
            {
                TaskType = Unchecked.defaultof<_>
                InferenceId = Unchecked.defaultof<_>
                Timeout = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutRequest, value: Types.TaskType) =
            { state with TaskType = value }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: InferencePutRequest, value: Types.Id) =
            { state with InferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: InferencePutRequest, value) =
            { state with Document = value }

    let inferencePutRequest = InferencePutRequestBuilder()

    module Put =
        let withTimeout (value: Types.Duration) (req: InferencePutRequest) =
            { req with Timeout = Some value }

    type InferencePutAi21Request = {
        TaskType: Types.Ai21TaskType
        Ai21InferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.Ai21ServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.Ai21ServiceSettings
    }

        with
        static member ToEndpoint(req: InferencePutAi21Request) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.Ai21InferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutAi21Response = Types.InferenceEndpointInfoAi21

    type InferencePutAi21RequestBuilder() =
        member _.Yield(_: unit) : InferencePutAi21Request =
            {
                TaskType = Unchecked.defaultof<_>
                Ai21InferenceId = Unchecked.defaultof<_>
                Timeout = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutAi21Request, value: Types.Ai21TaskType) =
            { state with TaskType = value }

        [<CustomOperation("ai21InferenceId")>]
        member _.Ai21InferenceId(state: InferencePutAi21Request, value: Types.Id) =
            { state with Ai21InferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutAi21Request, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutAi21Request, value: Types.Ai21ServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutAi21Request, value: Types.Ai21ServiceSettings) =
            { state with ServiceSettings = value }

    let inferencePutAi21Request = InferencePutAi21RequestBuilder()

    module PutAi21 =
        let withTimeout (value: Types.Duration) (req: InferencePutAi21Request) =
            { req with Timeout = Some value }
        let withService (value: Types.Ai21ServiceType) (req: InferencePutAi21Request) =
            { req with Service = value }
        let withServiceSettings (value: Types.Ai21ServiceSettings) (req: InferencePutAi21Request) =
            { req with ServiceSettings = value }

    type InferencePutAlibabacloudRequest = {
        TaskType: Types.AlibabaCloudTaskType
        AlibabacloudInferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: Types.InferenceChunkingSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.AlibabaCloudServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.AlibabaCloudServiceSettings
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: Types.AlibabaCloudTaskSettings option
    }

        with
        static member ToEndpoint(req: InferencePutAlibabacloudRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.AlibabacloudInferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutAlibabacloudResponse = Types.InferenceEndpointInfoAlibabaCloudAI

    type InferencePutAlibabacloudRequestBuilder() =
        member _.Yield(_: unit) : InferencePutAlibabacloudRequest =
            {
                TaskType = Unchecked.defaultof<_>
                AlibabacloudInferenceId = Unchecked.defaultof<_>
                Timeout = None
                ChunkingSettings = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutAlibabacloudRequest, value: Types.AlibabaCloudTaskType) =
            { state with TaskType = value }

        [<CustomOperation("alibabacloudInferenceId")>]
        member _.AlibabacloudInferenceId(state: InferencePutAlibabacloudRequest, value: Types.Id) =
            { state with AlibabacloudInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutAlibabacloudRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutAlibabacloudRequest, value: Types.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutAlibabacloudRequest, value: Types.AlibabaCloudServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutAlibabacloudRequest, value: Types.AlibabaCloudServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutAlibabacloudRequest, value: Types.AlibabaCloudTaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutAlibabacloudRequest = InferencePutAlibabacloudRequestBuilder()

    module PutAlibabacloud =
        let withTimeout (value: Types.Duration) (req: InferencePutAlibabacloudRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: Types.InferenceChunkingSettings) (req: InferencePutAlibabacloudRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: Types.AlibabaCloudServiceType) (req: InferencePutAlibabacloudRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.AlibabaCloudServiceSettings) (req: InferencePutAlibabacloudRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: Types.AlibabaCloudTaskSettings) (req: InferencePutAlibabacloudRequest) =
            { req with TaskSettings = Some value }

    type InferencePutAmazonbedrockRequest = {
        TaskType: Types.AmazonBedrockTaskType
        AmazonbedrockInferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: Types.InferenceChunkingSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.AmazonBedrockServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.AmazonBedrockServiceSettings
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: Types.AmazonBedrockTaskSettings option
    }

        with
        static member ToEndpoint(req: InferencePutAmazonbedrockRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.AmazonbedrockInferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutAmazonbedrockResponse = Types.InferenceEndpointInfoAmazonBedrock

    type InferencePutAmazonbedrockRequestBuilder() =
        member _.Yield(_: unit) : InferencePutAmazonbedrockRequest =
            {
                TaskType = Unchecked.defaultof<_>
                AmazonbedrockInferenceId = Unchecked.defaultof<_>
                Timeout = None
                ChunkingSettings = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutAmazonbedrockRequest, value: Types.AmazonBedrockTaskType) =
            { state with TaskType = value }

        [<CustomOperation("amazonbedrockInferenceId")>]
        member _.AmazonbedrockInferenceId(state: InferencePutAmazonbedrockRequest, value: Types.Id) =
            { state with AmazonbedrockInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutAmazonbedrockRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutAmazonbedrockRequest, value: Types.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutAmazonbedrockRequest, value: Types.AmazonBedrockServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutAmazonbedrockRequest, value: Types.AmazonBedrockServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutAmazonbedrockRequest, value: Types.AmazonBedrockTaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutAmazonbedrockRequest = InferencePutAmazonbedrockRequestBuilder()

    module PutAmazonbedrock =
        let withTimeout (value: Types.Duration) (req: InferencePutAmazonbedrockRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: Types.InferenceChunkingSettings) (req: InferencePutAmazonbedrockRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: Types.AmazonBedrockServiceType) (req: InferencePutAmazonbedrockRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.AmazonBedrockServiceSettings) (req: InferencePutAmazonbedrockRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: Types.AmazonBedrockTaskSettings) (req: InferencePutAmazonbedrockRequest) =
            { req with TaskSettings = Some value }

    type InferencePutAmazonsagemakerRequest = {
        TaskType: Types.TaskTypeAmazonSageMaker
        AmazonsagemakerInferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: Types.InferenceChunkingSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.AmazonSageMakerServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.AmazonSageMakerServiceSettings
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: Types.AmazonSageMakerTaskSettings option
    }

        with
        static member ToEndpoint(req: InferencePutAmazonsagemakerRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.AmazonsagemakerInferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutAmazonsagemakerResponse = Types.InferenceEndpointInfoAmazonSageMaker

    type InferencePutAmazonsagemakerRequestBuilder() =
        member _.Yield(_: unit) : InferencePutAmazonsagemakerRequest =
            {
                TaskType = Unchecked.defaultof<_>
                AmazonsagemakerInferenceId = Unchecked.defaultof<_>
                Timeout = None
                ChunkingSettings = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutAmazonsagemakerRequest, value: Types.TaskTypeAmazonSageMaker) =
            { state with TaskType = value }

        [<CustomOperation("amazonsagemakerInferenceId")>]
        member _.AmazonsagemakerInferenceId(state: InferencePutAmazonsagemakerRequest, value: Types.Id) =
            { state with AmazonsagemakerInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutAmazonsagemakerRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutAmazonsagemakerRequest, value: Types.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutAmazonsagemakerRequest, value: Types.AmazonSageMakerServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutAmazonsagemakerRequest, value: Types.AmazonSageMakerServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutAmazonsagemakerRequest, value: Types.AmazonSageMakerTaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutAmazonsagemakerRequest = InferencePutAmazonsagemakerRequestBuilder()

    module PutAmazonsagemaker =
        let withTimeout (value: Types.Duration) (req: InferencePutAmazonsagemakerRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: Types.InferenceChunkingSettings) (req: InferencePutAmazonsagemakerRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: Types.AmazonSageMakerServiceType) (req: InferencePutAmazonsagemakerRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.AmazonSageMakerServiceSettings) (req: InferencePutAmazonsagemakerRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: Types.AmazonSageMakerTaskSettings) (req: InferencePutAmazonsagemakerRequest) =
            { req with TaskSettings = Some value }

    type InferencePutAnthropicRequest = {
        TaskType: Types.AnthropicTaskType
        AnthropicInferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.AnthropicServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.AnthropicServiceSettings
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: Types.AnthropicTaskSettings option
    }

        with
        static member ToEndpoint(req: InferencePutAnthropicRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.AnthropicInferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutAnthropicResponse = Types.InferenceEndpointInfoAnthropic

    type InferencePutAnthropicRequestBuilder() =
        member _.Yield(_: unit) : InferencePutAnthropicRequest =
            {
                TaskType = Unchecked.defaultof<_>
                AnthropicInferenceId = Unchecked.defaultof<_>
                Timeout = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutAnthropicRequest, value: Types.AnthropicTaskType) =
            { state with TaskType = value }

        [<CustomOperation("anthropicInferenceId")>]
        member _.AnthropicInferenceId(state: InferencePutAnthropicRequest, value: Types.Id) =
            { state with AnthropicInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutAnthropicRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutAnthropicRequest, value: Types.AnthropicServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutAnthropicRequest, value: Types.AnthropicServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutAnthropicRequest, value: Types.AnthropicTaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutAnthropicRequest = InferencePutAnthropicRequestBuilder()

    module PutAnthropic =
        let withTimeout (value: Types.Duration) (req: InferencePutAnthropicRequest) =
            { req with Timeout = Some value }
        let withService (value: Types.AnthropicServiceType) (req: InferencePutAnthropicRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.AnthropicServiceSettings) (req: InferencePutAnthropicRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: Types.AnthropicTaskSettings) (req: InferencePutAnthropicRequest) =
            { req with TaskSettings = Some value }

    type InferencePutAzureaistudioRequest = {
        TaskType: Types.AzureAiStudioTaskType
        AzureaistudioInferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: Types.InferenceChunkingSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.AzureAiStudioServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.AzureAiStudioServiceSettings
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: Types.AzureAiStudioTaskSettings option
    }

        with
        static member ToEndpoint(req: InferencePutAzureaistudioRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.AzureaistudioInferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutAzureaistudioResponse = Types.InferenceEndpointInfoAzureAIStudio

    type InferencePutAzureaistudioRequestBuilder() =
        member _.Yield(_: unit) : InferencePutAzureaistudioRequest =
            {
                TaskType = Unchecked.defaultof<_>
                AzureaistudioInferenceId = Unchecked.defaultof<_>
                Timeout = None
                ChunkingSettings = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutAzureaistudioRequest, value: Types.AzureAiStudioTaskType) =
            { state with TaskType = value }

        [<CustomOperation("azureaistudioInferenceId")>]
        member _.AzureaistudioInferenceId(state: InferencePutAzureaistudioRequest, value: Types.Id) =
            { state with AzureaistudioInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutAzureaistudioRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutAzureaistudioRequest, value: Types.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutAzureaistudioRequest, value: Types.AzureAiStudioServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutAzureaistudioRequest, value: Types.AzureAiStudioServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutAzureaistudioRequest, value: Types.AzureAiStudioTaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutAzureaistudioRequest = InferencePutAzureaistudioRequestBuilder()

    module PutAzureaistudio =
        let withTimeout (value: Types.Duration) (req: InferencePutAzureaistudioRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: Types.InferenceChunkingSettings) (req: InferencePutAzureaistudioRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: Types.AzureAiStudioServiceType) (req: InferencePutAzureaistudioRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.AzureAiStudioServiceSettings) (req: InferencePutAzureaistudioRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: Types.AzureAiStudioTaskSettings) (req: InferencePutAzureaistudioRequest) =
            { req with TaskSettings = Some value }

    type InferencePutAzureopenaiRequest = {
        TaskType: Types.AzureOpenAITaskType
        AzureopenaiInferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: Types.InferenceChunkingSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.AzureOpenAIServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.AzureOpenAIServiceSettings
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: Types.AzureOpenAITaskSettings option
    }

        with
        static member ToEndpoint(req: InferencePutAzureopenaiRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.AzureopenaiInferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutAzureopenaiResponse = Types.InferenceEndpointInfoAzureOpenAI

    type InferencePutAzureopenaiRequestBuilder() =
        member _.Yield(_: unit) : InferencePutAzureopenaiRequest =
            {
                TaskType = Unchecked.defaultof<_>
                AzureopenaiInferenceId = Unchecked.defaultof<_>
                Timeout = None
                ChunkingSettings = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutAzureopenaiRequest, value: Types.AzureOpenAITaskType) =
            { state with TaskType = value }

        [<CustomOperation("azureopenaiInferenceId")>]
        member _.AzureopenaiInferenceId(state: InferencePutAzureopenaiRequest, value: Types.Id) =
            { state with AzureopenaiInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutAzureopenaiRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutAzureopenaiRequest, value: Types.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutAzureopenaiRequest, value: Types.AzureOpenAIServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutAzureopenaiRequest, value: Types.AzureOpenAIServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutAzureopenaiRequest, value: Types.AzureOpenAITaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutAzureopenaiRequest = InferencePutAzureopenaiRequestBuilder()

    module PutAzureopenai =
        let withTimeout (value: Types.Duration) (req: InferencePutAzureopenaiRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: Types.InferenceChunkingSettings) (req: InferencePutAzureopenaiRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: Types.AzureOpenAIServiceType) (req: InferencePutAzureopenaiRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.AzureOpenAIServiceSettings) (req: InferencePutAzureopenaiRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: Types.AzureOpenAITaskSettings) (req: InferencePutAzureopenaiRequest) =
            { req with TaskSettings = Some value }

    type InferencePutCohereRequest = {
        TaskType: Types.CohereTaskType
        CohereInferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: Types.InferenceChunkingSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.CohereServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.CohereServiceSettings
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: Types.CohereTaskSettings option
    }

        with
        static member ToEndpoint(req: InferencePutCohereRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.CohereInferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutCohereResponse = Types.InferenceEndpointInfoCohere

    type InferencePutCohereRequestBuilder() =
        member _.Yield(_: unit) : InferencePutCohereRequest =
            {
                TaskType = Unchecked.defaultof<_>
                CohereInferenceId = Unchecked.defaultof<_>
                Timeout = None
                ChunkingSettings = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutCohereRequest, value: Types.CohereTaskType) =
            { state with TaskType = value }

        [<CustomOperation("cohereInferenceId")>]
        member _.CohereInferenceId(state: InferencePutCohereRequest, value: Types.Id) =
            { state with CohereInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutCohereRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutCohereRequest, value: Types.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutCohereRequest, value: Types.CohereServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutCohereRequest, value: Types.CohereServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutCohereRequest, value: Types.CohereTaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutCohereRequest = InferencePutCohereRequestBuilder()

    module PutCohere =
        let withTimeout (value: Types.Duration) (req: InferencePutCohereRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: Types.InferenceChunkingSettings) (req: InferencePutCohereRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: Types.CohereServiceType) (req: InferencePutCohereRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.CohereServiceSettings) (req: InferencePutCohereRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: Types.CohereTaskSettings) (req: InferencePutCohereRequest) =
            { req with TaskSettings = Some value }

    type InferencePutContextualaiRequest = {
        TaskType: Types.TaskTypeContextualAI
        ContextualaiInferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.ContextualAIServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.ContextualAIServiceSettings
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: Types.ContextualAITaskSettings option
    }

        with
        static member ToEndpoint(req: InferencePutContextualaiRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.ContextualaiInferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutContextualaiResponse = Types.InferenceEndpointInfoContextualAi

    type InferencePutContextualaiRequestBuilder() =
        member _.Yield(_: unit) : InferencePutContextualaiRequest =
            {
                TaskType = Unchecked.defaultof<_>
                ContextualaiInferenceId = Unchecked.defaultof<_>
                Timeout = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutContextualaiRequest, value: Types.TaskTypeContextualAI) =
            { state with TaskType = value }

        [<CustomOperation("contextualaiInferenceId")>]
        member _.ContextualaiInferenceId(state: InferencePutContextualaiRequest, value: Types.Id) =
            { state with ContextualaiInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutContextualaiRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutContextualaiRequest, value: Types.ContextualAIServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutContextualaiRequest, value: Types.ContextualAIServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutContextualaiRequest, value: Types.ContextualAITaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutContextualaiRequest = InferencePutContextualaiRequestBuilder()

    module PutContextualai =
        let withTimeout (value: Types.Duration) (req: InferencePutContextualaiRequest) =
            { req with Timeout = Some value }
        let withService (value: Types.ContextualAIServiceType) (req: InferencePutContextualaiRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.ContextualAIServiceSettings) (req: InferencePutContextualaiRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: Types.ContextualAITaskSettings) (req: InferencePutContextualaiRequest) =
            { req with TaskSettings = Some value }

    type InferencePutCustomRequest = {
        TaskType: Types.CustomTaskType
        CustomInferenceId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: Types.InferenceChunkingSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.CustomServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.CustomServiceSettings
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: Types.CustomTaskSettings option
    }

        with
        static member ToEndpoint(req: InferencePutCustomRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.CustomInferenceId}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutCustomResponse = Types.InferenceEndpointInfoCustom

    type InferencePutCustomRequestBuilder() =
        member _.Yield(_: unit) : InferencePutCustomRequest =
            {
                TaskType = Unchecked.defaultof<_>
                CustomInferenceId = Unchecked.defaultof<_>
                ChunkingSettings = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutCustomRequest, value: Types.CustomTaskType) =
            { state with TaskType = value }

        [<CustomOperation("customInferenceId")>]
        member _.CustomInferenceId(state: InferencePutCustomRequest, value: Types.Id) =
            { state with CustomInferenceId = value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutCustomRequest, value: Types.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutCustomRequest, value: Types.CustomServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutCustomRequest, value: Types.CustomServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutCustomRequest, value: Types.CustomTaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutCustomRequest = InferencePutCustomRequestBuilder()

    module PutCustom =
        let withChunkingSettings (value: Types.InferenceChunkingSettings) (req: InferencePutCustomRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: Types.CustomServiceType) (req: InferencePutCustomRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.CustomServiceSettings) (req: InferencePutCustomRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: Types.CustomTaskSettings) (req: InferencePutCustomRequest) =
            { req with TaskSettings = Some value }

    type InferencePutDeepseekRequest = {
        TaskType: Types.TaskTypeDeepSeek
        DeepseekInferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.DeepSeekServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.DeepSeekServiceSettings
    }

        with
        static member ToEndpoint(req: InferencePutDeepseekRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.DeepseekInferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutDeepseekResponse = Types.InferenceEndpointInfoDeepSeek

    type InferencePutDeepseekRequestBuilder() =
        member _.Yield(_: unit) : InferencePutDeepseekRequest =
            {
                TaskType = Unchecked.defaultof<_>
                DeepseekInferenceId = Unchecked.defaultof<_>
                Timeout = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutDeepseekRequest, value: Types.TaskTypeDeepSeek) =
            { state with TaskType = value }

        [<CustomOperation("deepseekInferenceId")>]
        member _.DeepseekInferenceId(state: InferencePutDeepseekRequest, value: Types.Id) =
            { state with DeepseekInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutDeepseekRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutDeepseekRequest, value: Types.DeepSeekServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutDeepseekRequest, value: Types.DeepSeekServiceSettings) =
            { state with ServiceSettings = value }

    let inferencePutDeepseekRequest = InferencePutDeepseekRequestBuilder()

    module PutDeepseek =
        let withTimeout (value: Types.Duration) (req: InferencePutDeepseekRequest) =
            { req with Timeout = Some value }
        let withService (value: Types.DeepSeekServiceType) (req: InferencePutDeepseekRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.DeepSeekServiceSettings) (req: InferencePutDeepseekRequest) =
            { req with ServiceSettings = value }

    type InferencePutElasticsearchRequest = {
        TaskType: Types.ElasticsearchTaskType
        ElasticsearchInferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: Types.InferenceChunkingSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.ElasticsearchServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.ElasticsearchServiceSettings
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: Types.ElasticsearchTaskSettings option
    }

        with
        static member ToEndpoint(req: InferencePutElasticsearchRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.ElasticsearchInferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutElasticsearchResponse = Types.InferenceEndpointInfoElasticsearch

    type InferencePutElasticsearchRequestBuilder() =
        member _.Yield(_: unit) : InferencePutElasticsearchRequest =
            {
                TaskType = Unchecked.defaultof<_>
                ElasticsearchInferenceId = Unchecked.defaultof<_>
                Timeout = None
                ChunkingSettings = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutElasticsearchRequest, value: Types.ElasticsearchTaskType) =
            { state with TaskType = value }

        [<CustomOperation("elasticsearchInferenceId")>]
        member _.ElasticsearchInferenceId(state: InferencePutElasticsearchRequest, value: Types.Id) =
            { state with ElasticsearchInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutElasticsearchRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutElasticsearchRequest, value: Types.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutElasticsearchRequest, value: Types.ElasticsearchServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutElasticsearchRequest, value: Types.ElasticsearchServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutElasticsearchRequest, value: Types.ElasticsearchTaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutElasticsearchRequest = InferencePutElasticsearchRequestBuilder()

    module PutElasticsearch =
        let withTimeout (value: Types.Duration) (req: InferencePutElasticsearchRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: Types.InferenceChunkingSettings) (req: InferencePutElasticsearchRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: Types.ElasticsearchServiceType) (req: InferencePutElasticsearchRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.ElasticsearchServiceSettings) (req: InferencePutElasticsearchRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: Types.ElasticsearchTaskSettings) (req: InferencePutElasticsearchRequest) =
            { req with TaskSettings = Some value }

    type InferencePutElserRequest = {
        TaskType: Types.ElserTaskType
        ElserInferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: Types.InferenceChunkingSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.ElserServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.ElserServiceSettings
    }

        with
        static member ToEndpoint(req: InferencePutElserRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.ElserInferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutElserResponse = Types.InferenceEndpointInfoELSER

    type InferencePutElserRequestBuilder() =
        member _.Yield(_: unit) : InferencePutElserRequest =
            {
                TaskType = Unchecked.defaultof<_>
                ElserInferenceId = Unchecked.defaultof<_>
                Timeout = None
                ChunkingSettings = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutElserRequest, value: Types.ElserTaskType) =
            { state with TaskType = value }

        [<CustomOperation("elserInferenceId")>]
        member _.ElserInferenceId(state: InferencePutElserRequest, value: Types.Id) =
            { state with ElserInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutElserRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutElserRequest, value: Types.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutElserRequest, value: Types.ElserServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutElserRequest, value: Types.ElserServiceSettings) =
            { state with ServiceSettings = value }

    let inferencePutElserRequest = InferencePutElserRequestBuilder()

    module PutElser =
        let withTimeout (value: Types.Duration) (req: InferencePutElserRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: Types.InferenceChunkingSettings) (req: InferencePutElserRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: Types.ElserServiceType) (req: InferencePutElserRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.ElserServiceSettings) (req: InferencePutElserRequest) =
            { req with ServiceSettings = value }

    type InferencePutFireworksaiRequest = {
        TaskType: Types.FireworksAITaskType
        FireworksaiInferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: Types.InferenceChunkingSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.FireworksAIServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.FireworksAIServiceSettings
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: Types.FireworksAITaskSettings option
    }

        with
        static member ToEndpoint(req: InferencePutFireworksaiRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.FireworksaiInferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutFireworksaiResponse = Types.InferenceEndpointInfoFireworksAI

    type InferencePutFireworksaiRequestBuilder() =
        member _.Yield(_: unit) : InferencePutFireworksaiRequest =
            {
                TaskType = Unchecked.defaultof<_>
                FireworksaiInferenceId = Unchecked.defaultof<_>
                Timeout = None
                ChunkingSettings = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutFireworksaiRequest, value: Types.FireworksAITaskType) =
            { state with TaskType = value }

        [<CustomOperation("fireworksaiInferenceId")>]
        member _.FireworksaiInferenceId(state: InferencePutFireworksaiRequest, value: Types.Id) =
            { state with FireworksaiInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutFireworksaiRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutFireworksaiRequest, value: Types.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutFireworksaiRequest, value: Types.FireworksAIServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutFireworksaiRequest, value: Types.FireworksAIServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutFireworksaiRequest, value: Types.FireworksAITaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutFireworksaiRequest = InferencePutFireworksaiRequestBuilder()

    module PutFireworksai =
        let withTimeout (value: Types.Duration) (req: InferencePutFireworksaiRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: Types.InferenceChunkingSettings) (req: InferencePutFireworksaiRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: Types.FireworksAIServiceType) (req: InferencePutFireworksaiRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.FireworksAIServiceSettings) (req: InferencePutFireworksaiRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: Types.FireworksAITaskSettings) (req: InferencePutFireworksaiRequest) =
            { req with TaskSettings = Some value }

    type InferencePutGoogleaistudioRequest = {
        TaskType: Types.GoogleAiStudioTaskType
        GoogleaistudioInferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: Types.InferenceChunkingSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.GoogleAiServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.GoogleAiStudioServiceSettings
    }

        with
        static member ToEndpoint(req: InferencePutGoogleaistudioRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.GoogleaistudioInferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutGoogleaistudioResponse = Types.InferenceEndpointInfoGoogleAIStudio

    type InferencePutGoogleaistudioRequestBuilder() =
        member _.Yield(_: unit) : InferencePutGoogleaistudioRequest =
            {
                TaskType = Unchecked.defaultof<_>
                GoogleaistudioInferenceId = Unchecked.defaultof<_>
                Timeout = None
                ChunkingSettings = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutGoogleaistudioRequest, value: Types.GoogleAiStudioTaskType) =
            { state with TaskType = value }

        [<CustomOperation("googleaistudioInferenceId")>]
        member _.GoogleaistudioInferenceId(state: InferencePutGoogleaistudioRequest, value: Types.Id) =
            { state with GoogleaistudioInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutGoogleaistudioRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutGoogleaistudioRequest, value: Types.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutGoogleaistudioRequest, value: Types.GoogleAiServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutGoogleaistudioRequest, value: Types.GoogleAiStudioServiceSettings) =
            { state with ServiceSettings = value }

    let inferencePutGoogleaistudioRequest = InferencePutGoogleaistudioRequestBuilder()

    module PutGoogleaistudio =
        let withTimeout (value: Types.Duration) (req: InferencePutGoogleaistudioRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: Types.InferenceChunkingSettings) (req: InferencePutGoogleaistudioRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: Types.GoogleAiServiceType) (req: InferencePutGoogleaistudioRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.GoogleAiStudioServiceSettings) (req: InferencePutGoogleaistudioRequest) =
            { req with ServiceSettings = value }

    type InferencePutGooglevertexaiRequest = {
        TaskType: Types.GoogleVertexAITaskType
        GooglevertexaiInferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: Types.InferenceChunkingSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.GoogleVertexAIServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.GoogleVertexAIServiceSettings
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: Types.GoogleVertexAITaskSettings option
    }

        with
        static member ToEndpoint(req: InferencePutGooglevertexaiRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.GooglevertexaiInferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutGooglevertexaiResponse = Types.InferenceEndpointInfoGoogleVertexAI

    type InferencePutGooglevertexaiRequestBuilder() =
        member _.Yield(_: unit) : InferencePutGooglevertexaiRequest =
            {
                TaskType = Unchecked.defaultof<_>
                GooglevertexaiInferenceId = Unchecked.defaultof<_>
                Timeout = None
                ChunkingSettings = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutGooglevertexaiRequest, value: Types.GoogleVertexAITaskType) =
            { state with TaskType = value }

        [<CustomOperation("googlevertexaiInferenceId")>]
        member _.GooglevertexaiInferenceId(state: InferencePutGooglevertexaiRequest, value: Types.Id) =
            { state with GooglevertexaiInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutGooglevertexaiRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutGooglevertexaiRequest, value: Types.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutGooglevertexaiRequest, value: Types.GoogleVertexAIServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutGooglevertexaiRequest, value: Types.GoogleVertexAIServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutGooglevertexaiRequest, value: Types.GoogleVertexAITaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutGooglevertexaiRequest = InferencePutGooglevertexaiRequestBuilder()

    module PutGooglevertexai =
        let withTimeout (value: Types.Duration) (req: InferencePutGooglevertexaiRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: Types.InferenceChunkingSettings) (req: InferencePutGooglevertexaiRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: Types.GoogleVertexAIServiceType) (req: InferencePutGooglevertexaiRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.GoogleVertexAIServiceSettings) (req: InferencePutGooglevertexaiRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: Types.GoogleVertexAITaskSettings) (req: InferencePutGooglevertexaiRequest) =
            { req with TaskSettings = Some value }

    type InferencePutGroqRequest = {
        TaskType: Types.GroqTaskType
        GroqInferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.GroqServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.GroqServiceSettings
    }

        with
        static member ToEndpoint(req: InferencePutGroqRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.GroqInferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutGroqResponse = Types.InferenceEndpointInfoGroq

    type InferencePutGroqRequestBuilder() =
        member _.Yield(_: unit) : InferencePutGroqRequest =
            {
                TaskType = Unchecked.defaultof<_>
                GroqInferenceId = Unchecked.defaultof<_>
                Timeout = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutGroqRequest, value: Types.GroqTaskType) =
            { state with TaskType = value }

        [<CustomOperation("groqInferenceId")>]
        member _.GroqInferenceId(state: InferencePutGroqRequest, value: Types.Id) =
            { state with GroqInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutGroqRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutGroqRequest, value: Types.GroqServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutGroqRequest, value: Types.GroqServiceSettings) =
            { state with ServiceSettings = value }

    let inferencePutGroqRequest = InferencePutGroqRequestBuilder()

    module PutGroq =
        let withTimeout (value: Types.Duration) (req: InferencePutGroqRequest) =
            { req with Timeout = Some value }
        let withService (value: Types.GroqServiceType) (req: InferencePutGroqRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.GroqServiceSettings) (req: InferencePutGroqRequest) =
            { req with ServiceSettings = value }

    type InferencePutHuggingFaceRequest = {
        TaskType: Types.HuggingFaceTaskType
        HuggingfaceInferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: Types.InferenceChunkingSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.HuggingFaceServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.HuggingFaceServiceSettings
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: Types.HuggingFaceTaskSettings option
    }

        with
        static member ToEndpoint(req: InferencePutHuggingFaceRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.HuggingfaceInferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutHuggingFaceResponse = Types.InferenceEndpointInfoHuggingFace

    type InferencePutHuggingFaceRequestBuilder() =
        member _.Yield(_: unit) : InferencePutHuggingFaceRequest =
            {
                TaskType = Unchecked.defaultof<_>
                HuggingfaceInferenceId = Unchecked.defaultof<_>
                Timeout = None
                ChunkingSettings = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutHuggingFaceRequest, value: Types.HuggingFaceTaskType) =
            { state with TaskType = value }

        [<CustomOperation("huggingfaceInferenceId")>]
        member _.HuggingfaceInferenceId(state: InferencePutHuggingFaceRequest, value: Types.Id) =
            { state with HuggingfaceInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutHuggingFaceRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutHuggingFaceRequest, value: Types.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutHuggingFaceRequest, value: Types.HuggingFaceServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutHuggingFaceRequest, value: Types.HuggingFaceServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutHuggingFaceRequest, value: Types.HuggingFaceTaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutHuggingFaceRequest = InferencePutHuggingFaceRequestBuilder()

    module PutHuggingFace =
        let withTimeout (value: Types.Duration) (req: InferencePutHuggingFaceRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: Types.InferenceChunkingSettings) (req: InferencePutHuggingFaceRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: Types.HuggingFaceServiceType) (req: InferencePutHuggingFaceRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.HuggingFaceServiceSettings) (req: InferencePutHuggingFaceRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: Types.HuggingFaceTaskSettings) (req: InferencePutHuggingFaceRequest) =
            { req with TaskSettings = Some value }

    type InferencePutJinaaiRequest = {
        TaskType: Types.JinaAITaskType
        JinaaiInferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: Types.InferenceChunkingSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.JinaAIServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.JinaAIServiceSettings
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: Types.JinaAITaskSettings option
    }

        with
        static member ToEndpoint(req: InferencePutJinaaiRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.JinaaiInferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutJinaaiResponse = Types.InferenceEndpointInfoJinaAi

    type InferencePutJinaaiRequestBuilder() =
        member _.Yield(_: unit) : InferencePutJinaaiRequest =
            {
                TaskType = Unchecked.defaultof<_>
                JinaaiInferenceId = Unchecked.defaultof<_>
                Timeout = None
                ChunkingSettings = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutJinaaiRequest, value: Types.JinaAITaskType) =
            { state with TaskType = value }

        [<CustomOperation("jinaaiInferenceId")>]
        member _.JinaaiInferenceId(state: InferencePutJinaaiRequest, value: Types.Id) =
            { state with JinaaiInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutJinaaiRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutJinaaiRequest, value: Types.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutJinaaiRequest, value: Types.JinaAIServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutJinaaiRequest, value: Types.JinaAIServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutJinaaiRequest, value: Types.JinaAITaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutJinaaiRequest = InferencePutJinaaiRequestBuilder()

    module PutJinaai =
        let withTimeout (value: Types.Duration) (req: InferencePutJinaaiRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: Types.InferenceChunkingSettings) (req: InferencePutJinaaiRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: Types.JinaAIServiceType) (req: InferencePutJinaaiRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.JinaAIServiceSettings) (req: InferencePutJinaaiRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: Types.JinaAITaskSettings) (req: InferencePutJinaaiRequest) =
            { req with TaskSettings = Some value }

    type InferencePutLlamaRequest = {
        TaskType: Types.LlamaTaskType
        LlamaInferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: Types.InferenceChunkingSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.LlamaServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.LlamaServiceSettings
    }

        with
        static member ToEndpoint(req: InferencePutLlamaRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.LlamaInferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutLlamaResponse = Types.InferenceEndpointInfoLlama

    type InferencePutLlamaRequestBuilder() =
        member _.Yield(_: unit) : InferencePutLlamaRequest =
            {
                TaskType = Unchecked.defaultof<_>
                LlamaInferenceId = Unchecked.defaultof<_>
                Timeout = None
                ChunkingSettings = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutLlamaRequest, value: Types.LlamaTaskType) =
            { state with TaskType = value }

        [<CustomOperation("llamaInferenceId")>]
        member _.LlamaInferenceId(state: InferencePutLlamaRequest, value: Types.Id) =
            { state with LlamaInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutLlamaRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutLlamaRequest, value: Types.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutLlamaRequest, value: Types.LlamaServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutLlamaRequest, value: Types.LlamaServiceSettings) =
            { state with ServiceSettings = value }

    let inferencePutLlamaRequest = InferencePutLlamaRequestBuilder()

    module PutLlama =
        let withTimeout (value: Types.Duration) (req: InferencePutLlamaRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: Types.InferenceChunkingSettings) (req: InferencePutLlamaRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: Types.LlamaServiceType) (req: InferencePutLlamaRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.LlamaServiceSettings) (req: InferencePutLlamaRequest) =
            { req with ServiceSettings = value }

    type InferencePutMistralRequest = {
        TaskType: Types.MistralTaskType
        MistralInferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: Types.InferenceChunkingSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.MistralServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.MistralServiceSettings
    }

        with
        static member ToEndpoint(req: InferencePutMistralRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.MistralInferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutMistralResponse = Types.InferenceEndpointInfoMistral

    type InferencePutMistralRequestBuilder() =
        member _.Yield(_: unit) : InferencePutMistralRequest =
            {
                TaskType = Unchecked.defaultof<_>
                MistralInferenceId = Unchecked.defaultof<_>
                Timeout = None
                ChunkingSettings = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutMistralRequest, value: Types.MistralTaskType) =
            { state with TaskType = value }

        [<CustomOperation("mistralInferenceId")>]
        member _.MistralInferenceId(state: InferencePutMistralRequest, value: Types.Id) =
            { state with MistralInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutMistralRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutMistralRequest, value: Types.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutMistralRequest, value: Types.MistralServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutMistralRequest, value: Types.MistralServiceSettings) =
            { state with ServiceSettings = value }

    let inferencePutMistralRequest = InferencePutMistralRequestBuilder()

    module PutMistral =
        let withTimeout (value: Types.Duration) (req: InferencePutMistralRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: Types.InferenceChunkingSettings) (req: InferencePutMistralRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: Types.MistralServiceType) (req: InferencePutMistralRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.MistralServiceSettings) (req: InferencePutMistralRequest) =
            { req with ServiceSettings = value }

    type InferencePutNvidiaRequest = {
        TaskType: Types.NvidiaTaskType
        NvidiaInferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: Types.InferenceChunkingSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.NvidiaServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.NvidiaServiceSettings
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: Types.NvidiaTaskSettings option
    }

        with
        static member ToEndpoint(req: InferencePutNvidiaRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.NvidiaInferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutNvidiaResponse = Types.InferenceEndpointInfoNvidia

    type InferencePutNvidiaRequestBuilder() =
        member _.Yield(_: unit) : InferencePutNvidiaRequest =
            {
                TaskType = Unchecked.defaultof<_>
                NvidiaInferenceId = Unchecked.defaultof<_>
                Timeout = None
                ChunkingSettings = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutNvidiaRequest, value: Types.NvidiaTaskType) =
            { state with TaskType = value }

        [<CustomOperation("nvidiaInferenceId")>]
        member _.NvidiaInferenceId(state: InferencePutNvidiaRequest, value: Types.Id) =
            { state with NvidiaInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutNvidiaRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutNvidiaRequest, value: Types.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutNvidiaRequest, value: Types.NvidiaServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutNvidiaRequest, value: Types.NvidiaServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutNvidiaRequest, value: Types.NvidiaTaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutNvidiaRequest = InferencePutNvidiaRequestBuilder()

    module PutNvidia =
        let withTimeout (value: Types.Duration) (req: InferencePutNvidiaRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: Types.InferenceChunkingSettings) (req: InferencePutNvidiaRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: Types.NvidiaServiceType) (req: InferencePutNvidiaRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.NvidiaServiceSettings) (req: InferencePutNvidiaRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: Types.NvidiaTaskSettings) (req: InferencePutNvidiaRequest) =
            { req with TaskSettings = Some value }

    type InferencePutOpenaiRequest = {
        TaskType: Types.OpenAITaskType
        OpenaiInferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: Types.InferenceChunkingSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.OpenAIServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.OpenAIServiceSettings
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: Types.OpenAITaskSettings option
    }

        with
        static member ToEndpoint(req: InferencePutOpenaiRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.OpenaiInferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutOpenaiResponse = Types.InferenceEndpointInfoOpenAI

    type InferencePutOpenaiRequestBuilder() =
        member _.Yield(_: unit) : InferencePutOpenaiRequest =
            {
                TaskType = Unchecked.defaultof<_>
                OpenaiInferenceId = Unchecked.defaultof<_>
                Timeout = None
                ChunkingSettings = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutOpenaiRequest, value: Types.OpenAITaskType) =
            { state with TaskType = value }

        [<CustomOperation("openaiInferenceId")>]
        member _.OpenaiInferenceId(state: InferencePutOpenaiRequest, value: Types.Id) =
            { state with OpenaiInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutOpenaiRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutOpenaiRequest, value: Types.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutOpenaiRequest, value: Types.OpenAIServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutOpenaiRequest, value: Types.OpenAIServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutOpenaiRequest, value: Types.OpenAITaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutOpenaiRequest = InferencePutOpenaiRequestBuilder()

    module PutOpenai =
        let withTimeout (value: Types.Duration) (req: InferencePutOpenaiRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: Types.InferenceChunkingSettings) (req: InferencePutOpenaiRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: Types.OpenAIServiceType) (req: InferencePutOpenaiRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.OpenAIServiceSettings) (req: InferencePutOpenaiRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: Types.OpenAITaskSettings) (req: InferencePutOpenaiRequest) =
            { req with TaskSettings = Some value }

    type InferencePutOpenshiftAiRequest = {
        TaskType: Types.OpenShiftAiTaskType
        OpenshiftaiInferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: Types.InferenceChunkingSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.OpenShiftAiServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.OpenShiftAiServiceSettings
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: Types.OpenShiftAiTaskSettings option
    }

        with
        static member ToEndpoint(req: InferencePutOpenshiftAiRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.OpenshiftaiInferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutOpenshiftAiResponse = Types.InferenceEndpointInfoOpenShiftAi

    type InferencePutOpenshiftAiRequestBuilder() =
        member _.Yield(_: unit) : InferencePutOpenshiftAiRequest =
            {
                TaskType = Unchecked.defaultof<_>
                OpenshiftaiInferenceId = Unchecked.defaultof<_>
                Timeout = None
                ChunkingSettings = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutOpenshiftAiRequest, value: Types.OpenShiftAiTaskType) =
            { state with TaskType = value }

        [<CustomOperation("openshiftaiInferenceId")>]
        member _.OpenshiftaiInferenceId(state: InferencePutOpenshiftAiRequest, value: Types.Id) =
            { state with OpenshiftaiInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutOpenshiftAiRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutOpenshiftAiRequest, value: Types.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutOpenshiftAiRequest, value: Types.OpenShiftAiServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutOpenshiftAiRequest, value: Types.OpenShiftAiServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutOpenshiftAiRequest, value: Types.OpenShiftAiTaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutOpenshiftAiRequest = InferencePutOpenshiftAiRequestBuilder()

    module PutOpenshiftAi =
        let withTimeout (value: Types.Duration) (req: InferencePutOpenshiftAiRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: Types.InferenceChunkingSettings) (req: InferencePutOpenshiftAiRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: Types.OpenShiftAiServiceType) (req: InferencePutOpenshiftAiRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.OpenShiftAiServiceSettings) (req: InferencePutOpenshiftAiRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: Types.OpenShiftAiTaskSettings) (req: InferencePutOpenshiftAiRequest) =
            { req with TaskSettings = Some value }

    type InferencePutVoyageaiRequest = {
        TaskType: Types.VoyageAITaskType
        VoyageaiInferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: Types.InferenceChunkingSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.VoyageAIServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.VoyageAIServiceSettings
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: Types.VoyageAITaskSettings option
    }

        with
        static member ToEndpoint(req: InferencePutVoyageaiRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.VoyageaiInferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutVoyageaiResponse = Types.InferenceEndpointInfoVoyageAI

    type InferencePutVoyageaiRequestBuilder() =
        member _.Yield(_: unit) : InferencePutVoyageaiRequest =
            {
                TaskType = Unchecked.defaultof<_>
                VoyageaiInferenceId = Unchecked.defaultof<_>
                Timeout = None
                ChunkingSettings = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutVoyageaiRequest, value: Types.VoyageAITaskType) =
            { state with TaskType = value }

        [<CustomOperation("voyageaiInferenceId")>]
        member _.VoyageaiInferenceId(state: InferencePutVoyageaiRequest, value: Types.Id) =
            { state with VoyageaiInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutVoyageaiRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutVoyageaiRequest, value: Types.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutVoyageaiRequest, value: Types.VoyageAIServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutVoyageaiRequest, value: Types.VoyageAIServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutVoyageaiRequest, value: Types.VoyageAITaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutVoyageaiRequest = InferencePutVoyageaiRequestBuilder()

    module PutVoyageai =
        let withTimeout (value: Types.Duration) (req: InferencePutVoyageaiRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: Types.InferenceChunkingSettings) (req: InferencePutVoyageaiRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: Types.VoyageAIServiceType) (req: InferencePutVoyageaiRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.VoyageAIServiceSettings) (req: InferencePutVoyageaiRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: Types.VoyageAITaskSettings) (req: InferencePutVoyageaiRequest) =
            { req with TaskSettings = Some value }

    type InferencePutWatsonxRequest = {
        TaskType: Types.WatsonxTaskType
        WatsonxInferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: Types.InferenceChunkingSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: Types.WatsonxServiceType
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: Types.WatsonxServiceSettings
    }

        with
        static member ToEndpoint(req: InferencePutWatsonxRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.WatsonxInferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferencePutWatsonxResponse = Types.InferenceEndpointInfoWatsonx

    type InferencePutWatsonxRequestBuilder() =
        member _.Yield(_: unit) : InferencePutWatsonxRequest =
            {
                TaskType = Unchecked.defaultof<_>
                WatsonxInferenceId = Unchecked.defaultof<_>
                Timeout = None
                ChunkingSettings = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutWatsonxRequest, value: Types.WatsonxTaskType) =
            { state with TaskType = value }

        [<CustomOperation("watsonxInferenceId")>]
        member _.WatsonxInferenceId(state: InferencePutWatsonxRequest, value: Types.Id) =
            { state with WatsonxInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutWatsonxRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutWatsonxRequest, value: Types.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutWatsonxRequest, value: Types.WatsonxServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutWatsonxRequest, value: Types.WatsonxServiceSettings) =
            { state with ServiceSettings = value }

    let inferencePutWatsonxRequest = InferencePutWatsonxRequestBuilder()

    module PutWatsonx =
        let withTimeout (value: Types.Duration) (req: InferencePutWatsonxRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: Types.InferenceChunkingSettings) (req: InferencePutWatsonxRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: Types.WatsonxServiceType) (req: InferencePutWatsonxRequest) =
            { req with Service = value }
        let withServiceSettings (value: Types.WatsonxServiceSettings) (req: InferencePutWatsonxRequest) =
            { req with ServiceSettings = value }

    type InferenceRerankRequest = {
        InferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
        [<System.Text.Json.Serialization.JsonPropertyName("input")>]
        Input: string list
        [<System.Text.Json.Serialization.JsonPropertyName("return_documents")>]
        ReturnDocuments: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("top_n")>]
        TopN: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: Types.TaskSettings option
    }

        with
        static member ToEndpoint(req: InferenceRerankRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/rerank/{req.InferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferenceRerankResponse = Types.RerankedInferenceResult

    type InferenceRerankRequestBuilder() =
        member _.Yield(_: unit) : InferenceRerankRequest =
            {
                InferenceId = Unchecked.defaultof<_>
                Timeout = None
                Query = Unchecked.defaultof<_>
                Input = Unchecked.defaultof<_>
                ReturnDocuments = None
                TopN = None
                TaskSettings = None
            }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: InferenceRerankRequest, value: Types.Id) =
            { state with InferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferenceRerankRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: InferenceRerankRequest, value: string) =
            { state with Query = value }

        [<CustomOperation("input")>]
        member _.Input(state: InferenceRerankRequest, value: string list) =
            { state with Input = value }

        [<CustomOperation("returnDocuments")>]
        member _.ReturnDocuments(state: InferenceRerankRequest, value: bool) =
            { state with ReturnDocuments = Some value }

        [<CustomOperation("topN")>]
        member _.TopN(state: InferenceRerankRequest, value: Types.Integer) =
            { state with TopN = Some value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferenceRerankRequest, value: Types.TaskSettings) =
            { state with TaskSettings = Some value }

    let inferenceRerankRequest = InferenceRerankRequestBuilder()

    module Rerank =
        let withTimeout (value: Types.Duration) (req: InferenceRerankRequest) =
            { req with Timeout = Some value }
        let withQuery (value: string) (req: InferenceRerankRequest) =
            { req with Query = value }
        let withInput (value: string list) (req: InferenceRerankRequest) =
            { req with Input = value }
        let withReturnDocuments (value: bool) (req: InferenceRerankRequest) =
            { req with ReturnDocuments = Some value }
        let withTopN (value: Types.Integer) (req: InferenceRerankRequest) =
            { req with TopN = Some value }
        let withTaskSettings (value: Types.TaskSettings) (req: InferenceRerankRequest) =
            { req with TaskSettings = Some value }

    type InferenceSparseEmbeddingRequest = {
        InferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("input")>]
        Input: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: Types.TaskSettings option
    }

        with
        static member ToEndpoint(req: InferenceSparseEmbeddingRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/sparse_embedding/{req.InferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferenceSparseEmbeddingResponse = Types.SparseEmbeddingInferenceResult

    type InferenceSparseEmbeddingRequestBuilder() =
        member _.Yield(_: unit) : InferenceSparseEmbeddingRequest =
            {
                InferenceId = Unchecked.defaultof<_>
                Timeout = None
                Input = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: InferenceSparseEmbeddingRequest, value: Types.Id) =
            { state with InferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferenceSparseEmbeddingRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("input")>]
        member _.Input(state: InferenceSparseEmbeddingRequest, value: System.Text.Json.JsonElement) =
            { state with Input = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferenceSparseEmbeddingRequest, value: Types.TaskSettings) =
            { state with TaskSettings = Some value }

    let inferenceSparseEmbeddingRequest = InferenceSparseEmbeddingRequestBuilder()

    module SparseEmbedding =
        let withTimeout (value: Types.Duration) (req: InferenceSparseEmbeddingRequest) =
            { req with Timeout = Some value }
        let withInput (value: System.Text.Json.JsonElement) (req: InferenceSparseEmbeddingRequest) =
            { req with Input = value }
        let withTaskSettings (value: Types.TaskSettings) (req: InferenceSparseEmbeddingRequest) =
            { req with TaskSettings = Some value }

    type InferenceStreamCompletionRequest = {
        InferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("input")>]
        Input: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: Types.TaskSettings option
    }

        with
        static member ToEndpoint(req: InferenceStreamCompletionRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/completion/{req.InferenceId}/_stream"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferenceStreamCompletionResponse = Types.StreamResult

    type InferenceStreamCompletionRequestBuilder() =
        member _.Yield(_: unit) : InferenceStreamCompletionRequest =
            {
                InferenceId = Unchecked.defaultof<_>
                Timeout = None
                Input = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: InferenceStreamCompletionRequest, value: Types.Id) =
            { state with InferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferenceStreamCompletionRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("input")>]
        member _.Input(state: InferenceStreamCompletionRequest, value: System.Text.Json.JsonElement) =
            { state with Input = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferenceStreamCompletionRequest, value: Types.TaskSettings) =
            { state with TaskSettings = Some value }

    let inferenceStreamCompletionRequest = InferenceStreamCompletionRequestBuilder()

    module StreamCompletion =
        let withTimeout (value: Types.Duration) (req: InferenceStreamCompletionRequest) =
            { req with Timeout = Some value }
        let withInput (value: System.Text.Json.JsonElement) (req: InferenceStreamCompletionRequest) =
            { req with Input = value }
        let withTaskSettings (value: Types.TaskSettings) (req: InferenceStreamCompletionRequest) =
            { req with TaskSettings = Some value }

    type InferenceTextEmbeddingRequest = {
        InferenceId: Types.Id
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("input")>]
        Input: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("input_type")>]
        InputType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: Types.TaskSettings option
    }

        with
        static member ToEndpoint(req: InferenceTextEmbeddingRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/text_embedding/{req.InferenceId}"
            let queryParams =
                [
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type InferenceTextEmbeddingResponse = Types.TextEmbeddingInferenceResult

    type InferenceTextEmbeddingRequestBuilder() =
        member _.Yield(_: unit) : InferenceTextEmbeddingRequest =
            {
                InferenceId = Unchecked.defaultof<_>
                Timeout = None
                Input = Unchecked.defaultof<_>
                InputType = None
                TaskSettings = None
            }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: InferenceTextEmbeddingRequest, value: Types.Id) =
            { state with InferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferenceTextEmbeddingRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("input")>]
        member _.Input(state: InferenceTextEmbeddingRequest, value: System.Text.Json.JsonElement) =
            { state with Input = value }

        [<CustomOperation("inputType")>]
        member _.InputType(state: InferenceTextEmbeddingRequest, value: string) =
            { state with InputType = Some value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferenceTextEmbeddingRequest, value: Types.TaskSettings) =
            { state with TaskSettings = Some value }

    let inferenceTextEmbeddingRequest = InferenceTextEmbeddingRequestBuilder()

    module TextEmbedding =
        let withTimeout (value: Types.Duration) (req: InferenceTextEmbeddingRequest) =
            { req with Timeout = Some value }
        let withInput (value: System.Text.Json.JsonElement) (req: InferenceTextEmbeddingRequest) =
            { req with Input = value }
        let withInputType (value: string) (req: InferenceTextEmbeddingRequest) =
            { req with InputType = Some value }
        let withTaskSettings (value: Types.TaskSettings) (req: InferenceTextEmbeddingRequest) =
            { req with TaskSettings = Some value }

    type InferenceUpdateRequest = {
        InferenceId: Types.Id
        TaskType: Types.TaskType
        Document: obj
    }

        with
        static member ToEndpoint(req: InferenceUpdateRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_inference/{req.TaskType}/{req.InferenceId}/_update"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req.Document)
            endpoint, ValueSome postData

    type InferenceUpdateResponse = Types.InferenceEndpointInfo

    type InferenceUpdateRequestBuilder() =
        member _.Yield(_: unit) : InferenceUpdateRequest =
            {
                InferenceId = Unchecked.defaultof<_>
                TaskType = Unchecked.defaultof<_>
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: InferenceUpdateRequest, value: Types.Id) =
            { state with InferenceId = value }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferenceUpdateRequest, value: Types.TaskType) =
            { state with TaskType = value }

        [<CustomOperation("document")>]
        member _.Document(state: InferenceUpdateRequest, value) =
            { state with Document = value }

    let inferenceUpdateRequest = InferenceUpdateRequestBuilder()


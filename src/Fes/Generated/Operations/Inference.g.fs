// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module InferenceOperations =

    type InferenceChatCompletionUnifiedRequest = {
        InferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        Document: obj
    }

        with
        static member ToRequest(req: InferenceChatCompletionUnifiedRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/chat_completion/{req.InferenceId}/_stream"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type InferenceChatCompletionUnifiedResponse = CoreTypes.StreamResult

    type InferenceChatCompletionUnifiedRequestBuilder() =
        member _.Yield(_: unit) : InferenceChatCompletionUnifiedRequest =
            {
                InferenceId = Unchecked.defaultof<_>
                Timeout = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: InferenceChatCompletionUnifiedRequest, value: CoreTypes.Id) =
            { state with InferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferenceChatCompletionUnifiedRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: InferenceChatCompletionUnifiedRequest, value) =
            { state with Document = value }

    let inferenceChatCompletionUnifiedRequest = InferenceChatCompletionUnifiedRequestBuilder()

    module ChatCompletionUnified =
        let withTimeout (value: CoreTypes.Duration) (req: InferenceChatCompletionUnifiedRequest) =
            { req with Timeout = Some value }

    type InferenceCompletionRequest = {
        InferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        Input: System.Text.Json.JsonElement
        TaskSettings: InferenceTypes.TaskSettings option
    }

        with
        static member ToRequest(req: InferenceCompletionRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/completion/{req.InferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferenceCompletionResponse = InferenceTypes.CompletionInferenceResult

    type InferenceCompletionRequestBuilder() =
        member _.Yield(_: unit) : InferenceCompletionRequest =
            {
                InferenceId = Unchecked.defaultof<_>
                Timeout = None
                Input = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: InferenceCompletionRequest, value: CoreTypes.Id) =
            { state with InferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferenceCompletionRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("input")>]
        member _.Input(state: InferenceCompletionRequest, value: System.Text.Json.JsonElement) =
            { state with Input = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferenceCompletionRequest, value: InferenceTypes.TaskSettings) =
            { state with TaskSettings = Some value }

    let inferenceCompletionRequest = InferenceCompletionRequestBuilder()

    module Completion =
        let withTimeout (value: CoreTypes.Duration) (req: InferenceCompletionRequest) =
            { req with Timeout = Some value }
        let withInput (value: System.Text.Json.JsonElement) (req: InferenceCompletionRequest) =
            { req with Input = value }
        let withTaskSettings (value: InferenceTypes.TaskSettings) (req: InferenceCompletionRequest) =
            { req with TaskSettings = Some value }

    type InferenceDeleteRequest = {
        TaskType: InferenceTypes.TaskType
        InferenceId: CoreTypes.Id
        DryRun: bool option
        Force: bool option
    }

        with
        static member ToRequest(req: InferenceDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
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
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type InferenceDeleteResponse = InferenceTypes.DeleteInferenceEndpointResult

    type InferenceDeleteRequestBuilder() =
        member _.Yield(_: unit) : InferenceDeleteRequest =
            {
                TaskType = Unchecked.defaultof<_>
                InferenceId = Unchecked.defaultof<_>
                DryRun = None
                Force = None
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferenceDeleteRequest, value: InferenceTypes.TaskType) =
            { state with TaskType = value }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: InferenceDeleteRequest, value: CoreTypes.Id) =
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
        InferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        Document: obj
    }

        with
        static member ToRequest(req: InferenceEmbeddingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/embedding/{req.InferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type InferenceEmbeddingResponse = InferenceTypes.EmbeddingInferenceResult

    type InferenceEmbeddingRequestBuilder() =
        member _.Yield(_: unit) : InferenceEmbeddingRequest =
            {
                InferenceId = Unchecked.defaultof<_>
                Timeout = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: InferenceEmbeddingRequest, value: CoreTypes.Id) =
            { state with InferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferenceEmbeddingRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: InferenceEmbeddingRequest, value) =
            { state with Document = value }

    let inferenceEmbeddingRequest = InferenceEmbeddingRequestBuilder()

    module Embedding =
        let withTimeout (value: CoreTypes.Duration) (req: InferenceEmbeddingRequest) =
            { req with Timeout = Some value }

    type InferenceGetRequest = {
        TaskType: InferenceTypes.TaskType
        InferenceId: CoreTypes.Id
    }

        with
        static member ToRequest(req: InferenceGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.InferenceId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type InferenceGetResponse = System.Text.Json.JsonElement

    type InferenceGetRequestBuilder() =
        member _.Yield(_: unit) : InferenceGetRequest =
            {
                TaskType = Unchecked.defaultof<_>
                InferenceId = Unchecked.defaultof<_>
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferenceGetRequest, value: InferenceTypes.TaskType) =
            { state with TaskType = value }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: InferenceGetRequest, value: CoreTypes.Id) =
            { state with InferenceId = value }

    let inferenceGetRequest = InferenceGetRequestBuilder()

    type InferenceInferenceRequest = {
        TaskType: InferenceTypes.TaskType
        InferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        Query: string option
        Input: System.Text.Json.JsonElement
        InputType: string option
        TaskSettings: InferenceTypes.TaskSettings option
    }

        with
        static member ToRequest(req: InferenceInferenceRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.InferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferenceInferenceResponse = InferenceTypes.InferenceResult

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
        member _.TaskType(state: InferenceInferenceRequest, value: InferenceTypes.TaskType) =
            { state with TaskType = value }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: InferenceInferenceRequest, value: CoreTypes.Id) =
            { state with InferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferenceInferenceRequest, value: CoreTypes.Duration) =
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
        member _.TaskSettings(state: InferenceInferenceRequest, value: InferenceTypes.TaskSettings) =
            { state with TaskSettings = Some value }

    let inferenceInferenceRequest = InferenceInferenceRequestBuilder()

    module Inference =
        let withTimeout (value: CoreTypes.Duration) (req: InferenceInferenceRequest) =
            { req with Timeout = Some value }
        let withQuery (value: string) (req: InferenceInferenceRequest) =
            { req with Query = Some value }
        let withInput (value: System.Text.Json.JsonElement) (req: InferenceInferenceRequest) =
            { req with Input = value }
        let withInputType (value: string) (req: InferenceInferenceRequest) =
            { req with InputType = Some value }
        let withTaskSettings (value: InferenceTypes.TaskSettings) (req: InferenceInferenceRequest) =
            { req with TaskSettings = Some value }

    type InferencePutRequest = {
        TaskType: InferenceTypes.TaskType
        InferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        Document: obj
    }

        with
        static member ToRequest(req: InferencePutRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.InferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutResponse = InferenceTypes.InferenceEndpointInfo

    type InferencePutRequestBuilder() =
        member _.Yield(_: unit) : InferencePutRequest =
            {
                TaskType = Unchecked.defaultof<_>
                InferenceId = Unchecked.defaultof<_>
                Timeout = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferencePutRequest, value: InferenceTypes.TaskType) =
            { state with TaskType = value }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: InferencePutRequest, value: CoreTypes.Id) =
            { state with InferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: InferencePutRequest, value) =
            { state with Document = value }

    let inferencePutRequest = InferencePutRequestBuilder()

    module Put =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutRequest) =
            { req with Timeout = Some value }

    type InferencePutAi21Request = {
        TaskType: InferenceTypes.Ai21TaskType
        Ai21InferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        Service: InferenceTypes.Ai21ServiceType
        ServiceSettings: InferenceTypes.Ai21ServiceSettings
    }

        with
        static member ToRequest(req: InferencePutAi21Request) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.Ai21InferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutAi21Response = InferenceTypes.InferenceEndpointInfoAi21

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
        member _.TaskType(state: InferencePutAi21Request, value: InferenceTypes.Ai21TaskType) =
            { state with TaskType = value }

        [<CustomOperation("ai21InferenceId")>]
        member _.Ai21InferenceId(state: InferencePutAi21Request, value: CoreTypes.Id) =
            { state with Ai21InferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutAi21Request, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutAi21Request, value: InferenceTypes.Ai21ServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutAi21Request, value: InferenceTypes.Ai21ServiceSettings) =
            { state with ServiceSettings = value }

    let inferencePutAi21Request = InferencePutAi21RequestBuilder()

    module PutAi21 =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutAi21Request) =
            { req with Timeout = Some value }
        let withService (value: InferenceTypes.Ai21ServiceType) (req: InferencePutAi21Request) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.Ai21ServiceSettings) (req: InferencePutAi21Request) =
            { req with ServiceSettings = value }

    type InferencePutAlibabacloudRequest = {
        TaskType: InferenceTypes.AlibabaCloudTaskType
        AlibabacloudInferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        ChunkingSettings: InferenceTypes.InferenceChunkingSettings option
        Service: InferenceTypes.AlibabaCloudServiceType
        ServiceSettings: InferenceTypes.AlibabaCloudServiceSettings
        TaskSettings: InferenceTypes.AlibabaCloudTaskSettings option
    }

        with
        static member ToRequest(req: InferencePutAlibabacloudRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.AlibabacloudInferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutAlibabacloudResponse = InferenceTypes.InferenceEndpointInfoAlibabaCloudAI

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
        member _.TaskType(state: InferencePutAlibabacloudRequest, value: InferenceTypes.AlibabaCloudTaskType) =
            { state with TaskType = value }

        [<CustomOperation("alibabacloudInferenceId")>]
        member _.AlibabacloudInferenceId(state: InferencePutAlibabacloudRequest, value: CoreTypes.Id) =
            { state with AlibabacloudInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutAlibabacloudRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutAlibabacloudRequest, value: InferenceTypes.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutAlibabacloudRequest, value: InferenceTypes.AlibabaCloudServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutAlibabacloudRequest, value: InferenceTypes.AlibabaCloudServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutAlibabacloudRequest, value: InferenceTypes.AlibabaCloudTaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutAlibabacloudRequest = InferencePutAlibabacloudRequestBuilder()

    module PutAlibabacloud =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutAlibabacloudRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: InferenceTypes.InferenceChunkingSettings) (req: InferencePutAlibabacloudRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: InferenceTypes.AlibabaCloudServiceType) (req: InferencePutAlibabacloudRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.AlibabaCloudServiceSettings) (req: InferencePutAlibabacloudRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: InferenceTypes.AlibabaCloudTaskSettings) (req: InferencePutAlibabacloudRequest) =
            { req with TaskSettings = Some value }

    type InferencePutAmazonbedrockRequest = {
        TaskType: InferenceTypes.AmazonBedrockTaskType
        AmazonbedrockInferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        ChunkingSettings: InferenceTypes.InferenceChunkingSettings option
        Service: InferenceTypes.AmazonBedrockServiceType
        ServiceSettings: InferenceTypes.AmazonBedrockServiceSettings
        TaskSettings: InferenceTypes.AmazonBedrockTaskSettings option
    }

        with
        static member ToRequest(req: InferencePutAmazonbedrockRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.AmazonbedrockInferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutAmazonbedrockResponse = InferenceTypes.InferenceEndpointInfoAmazonBedrock

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
        member _.TaskType(state: InferencePutAmazonbedrockRequest, value: InferenceTypes.AmazonBedrockTaskType) =
            { state with TaskType = value }

        [<CustomOperation("amazonbedrockInferenceId")>]
        member _.AmazonbedrockInferenceId(state: InferencePutAmazonbedrockRequest, value: CoreTypes.Id) =
            { state with AmazonbedrockInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutAmazonbedrockRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutAmazonbedrockRequest, value: InferenceTypes.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutAmazonbedrockRequest, value: InferenceTypes.AmazonBedrockServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutAmazonbedrockRequest, value: InferenceTypes.AmazonBedrockServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutAmazonbedrockRequest, value: InferenceTypes.AmazonBedrockTaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutAmazonbedrockRequest = InferencePutAmazonbedrockRequestBuilder()

    module PutAmazonbedrock =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutAmazonbedrockRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: InferenceTypes.InferenceChunkingSettings) (req: InferencePutAmazonbedrockRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: InferenceTypes.AmazonBedrockServiceType) (req: InferencePutAmazonbedrockRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.AmazonBedrockServiceSettings) (req: InferencePutAmazonbedrockRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: InferenceTypes.AmazonBedrockTaskSettings) (req: InferencePutAmazonbedrockRequest) =
            { req with TaskSettings = Some value }

    type InferencePutAmazonsagemakerRequest = {
        TaskType: InferenceTypes.TaskTypeAmazonSageMaker
        AmazonsagemakerInferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        ChunkingSettings: InferenceTypes.InferenceChunkingSettings option
        Service: InferenceTypes.AmazonSageMakerServiceType
        ServiceSettings: InferenceTypes.AmazonSageMakerServiceSettings
        TaskSettings: InferenceTypes.AmazonSageMakerTaskSettings option
    }

        with
        static member ToRequest(req: InferencePutAmazonsagemakerRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.AmazonsagemakerInferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutAmazonsagemakerResponse = InferenceTypes.InferenceEndpointInfoAmazonSageMaker

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
        member _.TaskType(state: InferencePutAmazonsagemakerRequest, value: InferenceTypes.TaskTypeAmazonSageMaker) =
            { state with TaskType = value }

        [<CustomOperation("amazonsagemakerInferenceId")>]
        member _.AmazonsagemakerInferenceId(state: InferencePutAmazonsagemakerRequest, value: CoreTypes.Id) =
            { state with AmazonsagemakerInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutAmazonsagemakerRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutAmazonsagemakerRequest, value: InferenceTypes.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutAmazonsagemakerRequest, value: InferenceTypes.AmazonSageMakerServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutAmazonsagemakerRequest, value: InferenceTypes.AmazonSageMakerServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutAmazonsagemakerRequest, value: InferenceTypes.AmazonSageMakerTaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutAmazonsagemakerRequest = InferencePutAmazonsagemakerRequestBuilder()

    module PutAmazonsagemaker =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutAmazonsagemakerRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: InferenceTypes.InferenceChunkingSettings) (req: InferencePutAmazonsagemakerRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: InferenceTypes.AmazonSageMakerServiceType) (req: InferencePutAmazonsagemakerRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.AmazonSageMakerServiceSettings) (req: InferencePutAmazonsagemakerRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: InferenceTypes.AmazonSageMakerTaskSettings) (req: InferencePutAmazonsagemakerRequest) =
            { req with TaskSettings = Some value }

    type InferencePutAnthropicRequest = {
        TaskType: InferenceTypes.AnthropicTaskType
        AnthropicInferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        Service: InferenceTypes.AnthropicServiceType
        ServiceSettings: InferenceTypes.AnthropicServiceSettings
        TaskSettings: InferenceTypes.AnthropicTaskSettings option
    }

        with
        static member ToRequest(req: InferencePutAnthropicRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.AnthropicInferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutAnthropicResponse = InferenceTypes.InferenceEndpointInfoAnthropic

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
        member _.TaskType(state: InferencePutAnthropicRequest, value: InferenceTypes.AnthropicTaskType) =
            { state with TaskType = value }

        [<CustomOperation("anthropicInferenceId")>]
        member _.AnthropicInferenceId(state: InferencePutAnthropicRequest, value: CoreTypes.Id) =
            { state with AnthropicInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutAnthropicRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutAnthropicRequest, value: InferenceTypes.AnthropicServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutAnthropicRequest, value: InferenceTypes.AnthropicServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutAnthropicRequest, value: InferenceTypes.AnthropicTaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutAnthropicRequest = InferencePutAnthropicRequestBuilder()

    module PutAnthropic =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutAnthropicRequest) =
            { req with Timeout = Some value }
        let withService (value: InferenceTypes.AnthropicServiceType) (req: InferencePutAnthropicRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.AnthropicServiceSettings) (req: InferencePutAnthropicRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: InferenceTypes.AnthropicTaskSettings) (req: InferencePutAnthropicRequest) =
            { req with TaskSettings = Some value }

    type InferencePutAzureaistudioRequest = {
        TaskType: InferenceTypes.AzureAiStudioTaskType
        AzureaistudioInferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        ChunkingSettings: InferenceTypes.InferenceChunkingSettings option
        Service: InferenceTypes.AzureAiStudioServiceType
        ServiceSettings: InferenceTypes.AzureAiStudioServiceSettings
        TaskSettings: InferenceTypes.AzureAiStudioTaskSettings option
    }

        with
        static member ToRequest(req: InferencePutAzureaistudioRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.AzureaistudioInferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutAzureaistudioResponse = InferenceTypes.InferenceEndpointInfoAzureAIStudio

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
        member _.TaskType(state: InferencePutAzureaistudioRequest, value: InferenceTypes.AzureAiStudioTaskType) =
            { state with TaskType = value }

        [<CustomOperation("azureaistudioInferenceId")>]
        member _.AzureaistudioInferenceId(state: InferencePutAzureaistudioRequest, value: CoreTypes.Id) =
            { state with AzureaistudioInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutAzureaistudioRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutAzureaistudioRequest, value: InferenceTypes.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutAzureaistudioRequest, value: InferenceTypes.AzureAiStudioServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutAzureaistudioRequest, value: InferenceTypes.AzureAiStudioServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutAzureaistudioRequest, value: InferenceTypes.AzureAiStudioTaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutAzureaistudioRequest = InferencePutAzureaistudioRequestBuilder()

    module PutAzureaistudio =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutAzureaistudioRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: InferenceTypes.InferenceChunkingSettings) (req: InferencePutAzureaistudioRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: InferenceTypes.AzureAiStudioServiceType) (req: InferencePutAzureaistudioRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.AzureAiStudioServiceSettings) (req: InferencePutAzureaistudioRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: InferenceTypes.AzureAiStudioTaskSettings) (req: InferencePutAzureaistudioRequest) =
            { req with TaskSettings = Some value }

    type InferencePutAzureopenaiRequest = {
        TaskType: InferenceTypes.AzureOpenAITaskType
        AzureopenaiInferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        ChunkingSettings: InferenceTypes.InferenceChunkingSettings option
        Service: InferenceTypes.AzureOpenAIServiceType
        ServiceSettings: InferenceTypes.AzureOpenAIServiceSettings
        TaskSettings: InferenceTypes.AzureOpenAITaskSettings option
    }

        with
        static member ToRequest(req: InferencePutAzureopenaiRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.AzureopenaiInferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutAzureopenaiResponse = InferenceTypes.InferenceEndpointInfoAzureOpenAI

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
        member _.TaskType(state: InferencePutAzureopenaiRequest, value: InferenceTypes.AzureOpenAITaskType) =
            { state with TaskType = value }

        [<CustomOperation("azureopenaiInferenceId")>]
        member _.AzureopenaiInferenceId(state: InferencePutAzureopenaiRequest, value: CoreTypes.Id) =
            { state with AzureopenaiInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutAzureopenaiRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutAzureopenaiRequest, value: InferenceTypes.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutAzureopenaiRequest, value: InferenceTypes.AzureOpenAIServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutAzureopenaiRequest, value: InferenceTypes.AzureOpenAIServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutAzureopenaiRequest, value: InferenceTypes.AzureOpenAITaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutAzureopenaiRequest = InferencePutAzureopenaiRequestBuilder()

    module PutAzureopenai =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutAzureopenaiRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: InferenceTypes.InferenceChunkingSettings) (req: InferencePutAzureopenaiRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: InferenceTypes.AzureOpenAIServiceType) (req: InferencePutAzureopenaiRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.AzureOpenAIServiceSettings) (req: InferencePutAzureopenaiRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: InferenceTypes.AzureOpenAITaskSettings) (req: InferencePutAzureopenaiRequest) =
            { req with TaskSettings = Some value }

    type InferencePutCohereRequest = {
        TaskType: InferenceTypes.CohereTaskType
        CohereInferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        ChunkingSettings: InferenceTypes.InferenceChunkingSettings option
        Service: InferenceTypes.CohereServiceType
        ServiceSettings: InferenceTypes.CohereServiceSettings
        TaskSettings: InferenceTypes.CohereTaskSettings option
    }

        with
        static member ToRequest(req: InferencePutCohereRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.CohereInferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutCohereResponse = InferenceTypes.InferenceEndpointInfoCohere

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
        member _.TaskType(state: InferencePutCohereRequest, value: InferenceTypes.CohereTaskType) =
            { state with TaskType = value }

        [<CustomOperation("cohereInferenceId")>]
        member _.CohereInferenceId(state: InferencePutCohereRequest, value: CoreTypes.Id) =
            { state with CohereInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutCohereRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutCohereRequest, value: InferenceTypes.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutCohereRequest, value: InferenceTypes.CohereServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutCohereRequest, value: InferenceTypes.CohereServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutCohereRequest, value: InferenceTypes.CohereTaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutCohereRequest = InferencePutCohereRequestBuilder()

    module PutCohere =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutCohereRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: InferenceTypes.InferenceChunkingSettings) (req: InferencePutCohereRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: InferenceTypes.CohereServiceType) (req: InferencePutCohereRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.CohereServiceSettings) (req: InferencePutCohereRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: InferenceTypes.CohereTaskSettings) (req: InferencePutCohereRequest) =
            { req with TaskSettings = Some value }

    type InferencePutContextualaiRequest = {
        TaskType: InferenceTypes.TaskTypeContextualAI
        ContextualaiInferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        Service: InferenceTypes.ContextualAIServiceType
        ServiceSettings: InferenceTypes.ContextualAIServiceSettings
        TaskSettings: InferenceTypes.ContextualAITaskSettings option
    }

        with
        static member ToRequest(req: InferencePutContextualaiRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.ContextualaiInferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutContextualaiResponse = InferenceTypes.InferenceEndpointInfoContextualAi

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
        member _.TaskType(state: InferencePutContextualaiRequest, value: InferenceTypes.TaskTypeContextualAI) =
            { state with TaskType = value }

        [<CustomOperation("contextualaiInferenceId")>]
        member _.ContextualaiInferenceId(state: InferencePutContextualaiRequest, value: CoreTypes.Id) =
            { state with ContextualaiInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutContextualaiRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutContextualaiRequest, value: InferenceTypes.ContextualAIServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutContextualaiRequest, value: InferenceTypes.ContextualAIServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutContextualaiRequest, value: InferenceTypes.ContextualAITaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutContextualaiRequest = InferencePutContextualaiRequestBuilder()

    module PutContextualai =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutContextualaiRequest) =
            { req with Timeout = Some value }
        let withService (value: InferenceTypes.ContextualAIServiceType) (req: InferencePutContextualaiRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.ContextualAIServiceSettings) (req: InferencePutContextualaiRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: InferenceTypes.ContextualAITaskSettings) (req: InferencePutContextualaiRequest) =
            { req with TaskSettings = Some value }

    type InferencePutCustomRequest = {
        TaskType: InferenceTypes.CustomTaskType
        CustomInferenceId: CoreTypes.Id
        ChunkingSettings: InferenceTypes.InferenceChunkingSettings option
        Service: InferenceTypes.CustomServiceType
        ServiceSettings: InferenceTypes.CustomServiceSettings
        TaskSettings: InferenceTypes.CustomTaskSettings option
    }

        with
        static member ToRequest(req: InferencePutCustomRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.CustomInferenceId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutCustomResponse = InferenceTypes.InferenceEndpointInfoCustom

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
        member _.TaskType(state: InferencePutCustomRequest, value: InferenceTypes.CustomTaskType) =
            { state with TaskType = value }

        [<CustomOperation("customInferenceId")>]
        member _.CustomInferenceId(state: InferencePutCustomRequest, value: CoreTypes.Id) =
            { state with CustomInferenceId = value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutCustomRequest, value: InferenceTypes.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutCustomRequest, value: InferenceTypes.CustomServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutCustomRequest, value: InferenceTypes.CustomServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutCustomRequest, value: InferenceTypes.CustomTaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutCustomRequest = InferencePutCustomRequestBuilder()

    module PutCustom =
        let withChunkingSettings (value: InferenceTypes.InferenceChunkingSettings) (req: InferencePutCustomRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: InferenceTypes.CustomServiceType) (req: InferencePutCustomRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.CustomServiceSettings) (req: InferencePutCustomRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: InferenceTypes.CustomTaskSettings) (req: InferencePutCustomRequest) =
            { req with TaskSettings = Some value }

    type InferencePutDeepseekRequest = {
        TaskType: InferenceTypes.TaskTypeDeepSeek
        DeepseekInferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        Service: InferenceTypes.DeepSeekServiceType
        ServiceSettings: InferenceTypes.DeepSeekServiceSettings
    }

        with
        static member ToRequest(req: InferencePutDeepseekRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.DeepseekInferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutDeepseekResponse = InferenceTypes.InferenceEndpointInfoDeepSeek

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
        member _.TaskType(state: InferencePutDeepseekRequest, value: InferenceTypes.TaskTypeDeepSeek) =
            { state with TaskType = value }

        [<CustomOperation("deepseekInferenceId")>]
        member _.DeepseekInferenceId(state: InferencePutDeepseekRequest, value: CoreTypes.Id) =
            { state with DeepseekInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutDeepseekRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutDeepseekRequest, value: InferenceTypes.DeepSeekServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutDeepseekRequest, value: InferenceTypes.DeepSeekServiceSettings) =
            { state with ServiceSettings = value }

    let inferencePutDeepseekRequest = InferencePutDeepseekRequestBuilder()

    module PutDeepseek =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutDeepseekRequest) =
            { req with Timeout = Some value }
        let withService (value: InferenceTypes.DeepSeekServiceType) (req: InferencePutDeepseekRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.DeepSeekServiceSettings) (req: InferencePutDeepseekRequest) =
            { req with ServiceSettings = value }

    type InferencePutElasticsearchRequest = {
        TaskType: InferenceTypes.ElasticsearchTaskType
        ElasticsearchInferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        ChunkingSettings: InferenceTypes.InferenceChunkingSettings option
        Service: InferenceTypes.ElasticsearchServiceType
        ServiceSettings: InferenceTypes.ElasticsearchServiceSettings
        TaskSettings: InferenceTypes.ElasticsearchTaskSettings option
    }

        with
        static member ToRequest(req: InferencePutElasticsearchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.ElasticsearchInferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutElasticsearchResponse = InferenceTypes.InferenceEndpointInfoElasticsearch

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
        member _.TaskType(state: InferencePutElasticsearchRequest, value: InferenceTypes.ElasticsearchTaskType) =
            { state with TaskType = value }

        [<CustomOperation("elasticsearchInferenceId")>]
        member _.ElasticsearchInferenceId(state: InferencePutElasticsearchRequest, value: CoreTypes.Id) =
            { state with ElasticsearchInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutElasticsearchRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutElasticsearchRequest, value: InferenceTypes.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutElasticsearchRequest, value: InferenceTypes.ElasticsearchServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutElasticsearchRequest, value: InferenceTypes.ElasticsearchServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutElasticsearchRequest, value: InferenceTypes.ElasticsearchTaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutElasticsearchRequest = InferencePutElasticsearchRequestBuilder()

    module PutElasticsearch =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutElasticsearchRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: InferenceTypes.InferenceChunkingSettings) (req: InferencePutElasticsearchRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: InferenceTypes.ElasticsearchServiceType) (req: InferencePutElasticsearchRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.ElasticsearchServiceSettings) (req: InferencePutElasticsearchRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: InferenceTypes.ElasticsearchTaskSettings) (req: InferencePutElasticsearchRequest) =
            { req with TaskSettings = Some value }

    type InferencePutElserRequest = {
        TaskType: InferenceTypes.ElserTaskType
        ElserInferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        ChunkingSettings: InferenceTypes.InferenceChunkingSettings option
        Service: InferenceTypes.ElserServiceType
        ServiceSettings: InferenceTypes.ElserServiceSettings
    }

        with
        static member ToRequest(req: InferencePutElserRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.ElserInferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutElserResponse = InferenceTypes.InferenceEndpointInfoELSER

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
        member _.TaskType(state: InferencePutElserRequest, value: InferenceTypes.ElserTaskType) =
            { state with TaskType = value }

        [<CustomOperation("elserInferenceId")>]
        member _.ElserInferenceId(state: InferencePutElserRequest, value: CoreTypes.Id) =
            { state with ElserInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutElserRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutElserRequest, value: InferenceTypes.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutElserRequest, value: InferenceTypes.ElserServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutElserRequest, value: InferenceTypes.ElserServiceSettings) =
            { state with ServiceSettings = value }

    let inferencePutElserRequest = InferencePutElserRequestBuilder()

    module PutElser =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutElserRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: InferenceTypes.InferenceChunkingSettings) (req: InferencePutElserRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: InferenceTypes.ElserServiceType) (req: InferencePutElserRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.ElserServiceSettings) (req: InferencePutElserRequest) =
            { req with ServiceSettings = value }

    type InferencePutFireworksaiRequest = {
        TaskType: InferenceTypes.FireworksAITaskType
        FireworksaiInferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        ChunkingSettings: InferenceTypes.InferenceChunkingSettings option
        Service: InferenceTypes.FireworksAIServiceType
        ServiceSettings: InferenceTypes.FireworksAIServiceSettings
        TaskSettings: InferenceTypes.FireworksAITaskSettings option
    }

        with
        static member ToRequest(req: InferencePutFireworksaiRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.FireworksaiInferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutFireworksaiResponse = InferenceTypes.InferenceEndpointInfoFireworksAI

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
        member _.TaskType(state: InferencePutFireworksaiRequest, value: InferenceTypes.FireworksAITaskType) =
            { state with TaskType = value }

        [<CustomOperation("fireworksaiInferenceId")>]
        member _.FireworksaiInferenceId(state: InferencePutFireworksaiRequest, value: CoreTypes.Id) =
            { state with FireworksaiInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutFireworksaiRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutFireworksaiRequest, value: InferenceTypes.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutFireworksaiRequest, value: InferenceTypes.FireworksAIServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutFireworksaiRequest, value: InferenceTypes.FireworksAIServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutFireworksaiRequest, value: InferenceTypes.FireworksAITaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutFireworksaiRequest = InferencePutFireworksaiRequestBuilder()

    module PutFireworksai =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutFireworksaiRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: InferenceTypes.InferenceChunkingSettings) (req: InferencePutFireworksaiRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: InferenceTypes.FireworksAIServiceType) (req: InferencePutFireworksaiRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.FireworksAIServiceSettings) (req: InferencePutFireworksaiRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: InferenceTypes.FireworksAITaskSettings) (req: InferencePutFireworksaiRequest) =
            { req with TaskSettings = Some value }

    type InferencePutGoogleaistudioRequest = {
        TaskType: InferenceTypes.GoogleAiStudioTaskType
        GoogleaistudioInferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        ChunkingSettings: InferenceTypes.InferenceChunkingSettings option
        Service: InferenceTypes.GoogleAiServiceType
        ServiceSettings: InferenceTypes.GoogleAiStudioServiceSettings
    }

        with
        static member ToRequest(req: InferencePutGoogleaistudioRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.GoogleaistudioInferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutGoogleaistudioResponse = InferenceTypes.InferenceEndpointInfoGoogleAIStudio

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
        member _.TaskType(state: InferencePutGoogleaistudioRequest, value: InferenceTypes.GoogleAiStudioTaskType) =
            { state with TaskType = value }

        [<CustomOperation("googleaistudioInferenceId")>]
        member _.GoogleaistudioInferenceId(state: InferencePutGoogleaistudioRequest, value: CoreTypes.Id) =
            { state with GoogleaistudioInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutGoogleaistudioRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutGoogleaistudioRequest, value: InferenceTypes.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutGoogleaistudioRequest, value: InferenceTypes.GoogleAiServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutGoogleaistudioRequest, value: InferenceTypes.GoogleAiStudioServiceSettings) =
            { state with ServiceSettings = value }

    let inferencePutGoogleaistudioRequest = InferencePutGoogleaistudioRequestBuilder()

    module PutGoogleaistudio =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutGoogleaistudioRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: InferenceTypes.InferenceChunkingSettings) (req: InferencePutGoogleaistudioRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: InferenceTypes.GoogleAiServiceType) (req: InferencePutGoogleaistudioRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.GoogleAiStudioServiceSettings) (req: InferencePutGoogleaistudioRequest) =
            { req with ServiceSettings = value }

    type InferencePutGooglevertexaiRequest = {
        TaskType: InferenceTypes.GoogleVertexAITaskType
        GooglevertexaiInferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        ChunkingSettings: InferenceTypes.InferenceChunkingSettings option
        Service: InferenceTypes.GoogleVertexAIServiceType
        ServiceSettings: InferenceTypes.GoogleVertexAIServiceSettings
        TaskSettings: InferenceTypes.GoogleVertexAITaskSettings option
    }

        with
        static member ToRequest(req: InferencePutGooglevertexaiRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.GooglevertexaiInferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutGooglevertexaiResponse = InferenceTypes.InferenceEndpointInfoGoogleVertexAI

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
        member _.TaskType(state: InferencePutGooglevertexaiRequest, value: InferenceTypes.GoogleVertexAITaskType) =
            { state with TaskType = value }

        [<CustomOperation("googlevertexaiInferenceId")>]
        member _.GooglevertexaiInferenceId(state: InferencePutGooglevertexaiRequest, value: CoreTypes.Id) =
            { state with GooglevertexaiInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutGooglevertexaiRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutGooglevertexaiRequest, value: InferenceTypes.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutGooglevertexaiRequest, value: InferenceTypes.GoogleVertexAIServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutGooglevertexaiRequest, value: InferenceTypes.GoogleVertexAIServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutGooglevertexaiRequest, value: InferenceTypes.GoogleVertexAITaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutGooglevertexaiRequest = InferencePutGooglevertexaiRequestBuilder()

    module PutGooglevertexai =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutGooglevertexaiRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: InferenceTypes.InferenceChunkingSettings) (req: InferencePutGooglevertexaiRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: InferenceTypes.GoogleVertexAIServiceType) (req: InferencePutGooglevertexaiRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.GoogleVertexAIServiceSettings) (req: InferencePutGooglevertexaiRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: InferenceTypes.GoogleVertexAITaskSettings) (req: InferencePutGooglevertexaiRequest) =
            { req with TaskSettings = Some value }

    type InferencePutGroqRequest = {
        TaskType: InferenceTypes.GroqTaskType
        GroqInferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        Service: InferenceTypes.GroqServiceType
        ServiceSettings: InferenceTypes.GroqServiceSettings
    }

        with
        static member ToRequest(req: InferencePutGroqRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.GroqInferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutGroqResponse = InferenceTypes.InferenceEndpointInfoGroq

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
        member _.TaskType(state: InferencePutGroqRequest, value: InferenceTypes.GroqTaskType) =
            { state with TaskType = value }

        [<CustomOperation("groqInferenceId")>]
        member _.GroqInferenceId(state: InferencePutGroqRequest, value: CoreTypes.Id) =
            { state with GroqInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutGroqRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutGroqRequest, value: InferenceTypes.GroqServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutGroqRequest, value: InferenceTypes.GroqServiceSettings) =
            { state with ServiceSettings = value }

    let inferencePutGroqRequest = InferencePutGroqRequestBuilder()

    module PutGroq =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutGroqRequest) =
            { req with Timeout = Some value }
        let withService (value: InferenceTypes.GroqServiceType) (req: InferencePutGroqRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.GroqServiceSettings) (req: InferencePutGroqRequest) =
            { req with ServiceSettings = value }

    type InferencePutHuggingFaceRequest = {
        TaskType: InferenceTypes.HuggingFaceTaskType
        HuggingfaceInferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        ChunkingSettings: InferenceTypes.InferenceChunkingSettings option
        Service: InferenceTypes.HuggingFaceServiceType
        ServiceSettings: InferenceTypes.HuggingFaceServiceSettings
        TaskSettings: InferenceTypes.HuggingFaceTaskSettings option
    }

        with
        static member ToRequest(req: InferencePutHuggingFaceRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.HuggingfaceInferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutHuggingFaceResponse = InferenceTypes.InferenceEndpointInfoHuggingFace

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
        member _.TaskType(state: InferencePutHuggingFaceRequest, value: InferenceTypes.HuggingFaceTaskType) =
            { state with TaskType = value }

        [<CustomOperation("huggingfaceInferenceId")>]
        member _.HuggingfaceInferenceId(state: InferencePutHuggingFaceRequest, value: CoreTypes.Id) =
            { state with HuggingfaceInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutHuggingFaceRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutHuggingFaceRequest, value: InferenceTypes.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutHuggingFaceRequest, value: InferenceTypes.HuggingFaceServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutHuggingFaceRequest, value: InferenceTypes.HuggingFaceServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutHuggingFaceRequest, value: InferenceTypes.HuggingFaceTaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutHuggingFaceRequest = InferencePutHuggingFaceRequestBuilder()

    module PutHuggingFace =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutHuggingFaceRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: InferenceTypes.InferenceChunkingSettings) (req: InferencePutHuggingFaceRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: InferenceTypes.HuggingFaceServiceType) (req: InferencePutHuggingFaceRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.HuggingFaceServiceSettings) (req: InferencePutHuggingFaceRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: InferenceTypes.HuggingFaceTaskSettings) (req: InferencePutHuggingFaceRequest) =
            { req with TaskSettings = Some value }

    type InferencePutJinaaiRequest = {
        TaskType: InferenceTypes.JinaAITaskType
        JinaaiInferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        ChunkingSettings: InferenceTypes.InferenceChunkingSettings option
        Service: InferenceTypes.JinaAIServiceType
        ServiceSettings: InferenceTypes.JinaAIServiceSettings
        TaskSettings: InferenceTypes.JinaAITaskSettings option
    }

        with
        static member ToRequest(req: InferencePutJinaaiRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.JinaaiInferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutJinaaiResponse = InferenceTypes.InferenceEndpointInfoJinaAi

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
        member _.TaskType(state: InferencePutJinaaiRequest, value: InferenceTypes.JinaAITaskType) =
            { state with TaskType = value }

        [<CustomOperation("jinaaiInferenceId")>]
        member _.JinaaiInferenceId(state: InferencePutJinaaiRequest, value: CoreTypes.Id) =
            { state with JinaaiInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutJinaaiRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutJinaaiRequest, value: InferenceTypes.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutJinaaiRequest, value: InferenceTypes.JinaAIServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutJinaaiRequest, value: InferenceTypes.JinaAIServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutJinaaiRequest, value: InferenceTypes.JinaAITaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutJinaaiRequest = InferencePutJinaaiRequestBuilder()

    module PutJinaai =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutJinaaiRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: InferenceTypes.InferenceChunkingSettings) (req: InferencePutJinaaiRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: InferenceTypes.JinaAIServiceType) (req: InferencePutJinaaiRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.JinaAIServiceSettings) (req: InferencePutJinaaiRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: InferenceTypes.JinaAITaskSettings) (req: InferencePutJinaaiRequest) =
            { req with TaskSettings = Some value }

    type InferencePutLlamaRequest = {
        TaskType: InferenceTypes.LlamaTaskType
        LlamaInferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        ChunkingSettings: InferenceTypes.InferenceChunkingSettings option
        Service: InferenceTypes.LlamaServiceType
        ServiceSettings: InferenceTypes.LlamaServiceSettings
    }

        with
        static member ToRequest(req: InferencePutLlamaRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.LlamaInferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutLlamaResponse = InferenceTypes.InferenceEndpointInfoLlama

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
        member _.TaskType(state: InferencePutLlamaRequest, value: InferenceTypes.LlamaTaskType) =
            { state with TaskType = value }

        [<CustomOperation("llamaInferenceId")>]
        member _.LlamaInferenceId(state: InferencePutLlamaRequest, value: CoreTypes.Id) =
            { state with LlamaInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutLlamaRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutLlamaRequest, value: InferenceTypes.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutLlamaRequest, value: InferenceTypes.LlamaServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutLlamaRequest, value: InferenceTypes.LlamaServiceSettings) =
            { state with ServiceSettings = value }

    let inferencePutLlamaRequest = InferencePutLlamaRequestBuilder()

    module PutLlama =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutLlamaRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: InferenceTypes.InferenceChunkingSettings) (req: InferencePutLlamaRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: InferenceTypes.LlamaServiceType) (req: InferencePutLlamaRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.LlamaServiceSettings) (req: InferencePutLlamaRequest) =
            { req with ServiceSettings = value }

    type InferencePutMistralRequest = {
        TaskType: InferenceTypes.MistralTaskType
        MistralInferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        ChunkingSettings: InferenceTypes.InferenceChunkingSettings option
        Service: InferenceTypes.MistralServiceType
        ServiceSettings: InferenceTypes.MistralServiceSettings
    }

        with
        static member ToRequest(req: InferencePutMistralRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.MistralInferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutMistralResponse = InferenceTypes.InferenceEndpointInfoMistral

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
        member _.TaskType(state: InferencePutMistralRequest, value: InferenceTypes.MistralTaskType) =
            { state with TaskType = value }

        [<CustomOperation("mistralInferenceId")>]
        member _.MistralInferenceId(state: InferencePutMistralRequest, value: CoreTypes.Id) =
            { state with MistralInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutMistralRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutMistralRequest, value: InferenceTypes.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutMistralRequest, value: InferenceTypes.MistralServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutMistralRequest, value: InferenceTypes.MistralServiceSettings) =
            { state with ServiceSettings = value }

    let inferencePutMistralRequest = InferencePutMistralRequestBuilder()

    module PutMistral =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutMistralRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: InferenceTypes.InferenceChunkingSettings) (req: InferencePutMistralRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: InferenceTypes.MistralServiceType) (req: InferencePutMistralRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.MistralServiceSettings) (req: InferencePutMistralRequest) =
            { req with ServiceSettings = value }

    type InferencePutNvidiaRequest = {
        TaskType: InferenceTypes.NvidiaTaskType
        NvidiaInferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        ChunkingSettings: InferenceTypes.InferenceChunkingSettings option
        Service: InferenceTypes.NvidiaServiceType
        ServiceSettings: InferenceTypes.NvidiaServiceSettings
        TaskSettings: InferenceTypes.NvidiaTaskSettings option
    }

        with
        static member ToRequest(req: InferencePutNvidiaRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.NvidiaInferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutNvidiaResponse = InferenceTypes.InferenceEndpointInfoNvidia

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
        member _.TaskType(state: InferencePutNvidiaRequest, value: InferenceTypes.NvidiaTaskType) =
            { state with TaskType = value }

        [<CustomOperation("nvidiaInferenceId")>]
        member _.NvidiaInferenceId(state: InferencePutNvidiaRequest, value: CoreTypes.Id) =
            { state with NvidiaInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutNvidiaRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutNvidiaRequest, value: InferenceTypes.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutNvidiaRequest, value: InferenceTypes.NvidiaServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutNvidiaRequest, value: InferenceTypes.NvidiaServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutNvidiaRequest, value: InferenceTypes.NvidiaTaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutNvidiaRequest = InferencePutNvidiaRequestBuilder()

    module PutNvidia =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutNvidiaRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: InferenceTypes.InferenceChunkingSettings) (req: InferencePutNvidiaRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: InferenceTypes.NvidiaServiceType) (req: InferencePutNvidiaRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.NvidiaServiceSettings) (req: InferencePutNvidiaRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: InferenceTypes.NvidiaTaskSettings) (req: InferencePutNvidiaRequest) =
            { req with TaskSettings = Some value }

    type InferencePutOpenaiRequest = {
        TaskType: InferenceTypes.OpenAITaskType
        OpenaiInferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        ChunkingSettings: InferenceTypes.InferenceChunkingSettings option
        Service: InferenceTypes.OpenAIServiceType
        ServiceSettings: InferenceTypes.OpenAIServiceSettings
        TaskSettings: InferenceTypes.OpenAITaskSettings option
    }

        with
        static member ToRequest(req: InferencePutOpenaiRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.OpenaiInferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutOpenaiResponse = InferenceTypes.InferenceEndpointInfoOpenAI

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
        member _.TaskType(state: InferencePutOpenaiRequest, value: InferenceTypes.OpenAITaskType) =
            { state with TaskType = value }

        [<CustomOperation("openaiInferenceId")>]
        member _.OpenaiInferenceId(state: InferencePutOpenaiRequest, value: CoreTypes.Id) =
            { state with OpenaiInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutOpenaiRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutOpenaiRequest, value: InferenceTypes.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutOpenaiRequest, value: InferenceTypes.OpenAIServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutOpenaiRequest, value: InferenceTypes.OpenAIServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutOpenaiRequest, value: InferenceTypes.OpenAITaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutOpenaiRequest = InferencePutOpenaiRequestBuilder()

    module PutOpenai =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutOpenaiRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: InferenceTypes.InferenceChunkingSettings) (req: InferencePutOpenaiRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: InferenceTypes.OpenAIServiceType) (req: InferencePutOpenaiRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.OpenAIServiceSettings) (req: InferencePutOpenaiRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: InferenceTypes.OpenAITaskSettings) (req: InferencePutOpenaiRequest) =
            { req with TaskSettings = Some value }

    type InferencePutOpenshiftAiRequest = {
        TaskType: InferenceTypes.OpenShiftAiTaskType
        OpenshiftaiInferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        ChunkingSettings: InferenceTypes.InferenceChunkingSettings option
        Service: InferenceTypes.OpenShiftAiServiceType
        ServiceSettings: InferenceTypes.OpenShiftAiServiceSettings
        TaskSettings: InferenceTypes.OpenShiftAiTaskSettings option
    }

        with
        static member ToRequest(req: InferencePutOpenshiftAiRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.OpenshiftaiInferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutOpenshiftAiResponse = InferenceTypes.InferenceEndpointInfoOpenShiftAi

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
        member _.TaskType(state: InferencePutOpenshiftAiRequest, value: InferenceTypes.OpenShiftAiTaskType) =
            { state with TaskType = value }

        [<CustomOperation("openshiftaiInferenceId")>]
        member _.OpenshiftaiInferenceId(state: InferencePutOpenshiftAiRequest, value: CoreTypes.Id) =
            { state with OpenshiftaiInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutOpenshiftAiRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutOpenshiftAiRequest, value: InferenceTypes.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutOpenshiftAiRequest, value: InferenceTypes.OpenShiftAiServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutOpenshiftAiRequest, value: InferenceTypes.OpenShiftAiServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutOpenshiftAiRequest, value: InferenceTypes.OpenShiftAiTaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutOpenshiftAiRequest = InferencePutOpenshiftAiRequestBuilder()

    module PutOpenshiftAi =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutOpenshiftAiRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: InferenceTypes.InferenceChunkingSettings) (req: InferencePutOpenshiftAiRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: InferenceTypes.OpenShiftAiServiceType) (req: InferencePutOpenshiftAiRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.OpenShiftAiServiceSettings) (req: InferencePutOpenshiftAiRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: InferenceTypes.OpenShiftAiTaskSettings) (req: InferencePutOpenshiftAiRequest) =
            { req with TaskSettings = Some value }

    type InferencePutVoyageaiRequest = {
        TaskType: InferenceTypes.VoyageAITaskType
        VoyageaiInferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        ChunkingSettings: InferenceTypes.InferenceChunkingSettings option
        Service: InferenceTypes.VoyageAIServiceType
        ServiceSettings: InferenceTypes.VoyageAIServiceSettings
        TaskSettings: InferenceTypes.VoyageAITaskSettings option
    }

        with
        static member ToRequest(req: InferencePutVoyageaiRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.VoyageaiInferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutVoyageaiResponse = InferenceTypes.InferenceEndpointInfoVoyageAI

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
        member _.TaskType(state: InferencePutVoyageaiRequest, value: InferenceTypes.VoyageAITaskType) =
            { state with TaskType = value }

        [<CustomOperation("voyageaiInferenceId")>]
        member _.VoyageaiInferenceId(state: InferencePutVoyageaiRequest, value: CoreTypes.Id) =
            { state with VoyageaiInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutVoyageaiRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutVoyageaiRequest, value: InferenceTypes.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutVoyageaiRequest, value: InferenceTypes.VoyageAIServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutVoyageaiRequest, value: InferenceTypes.VoyageAIServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferencePutVoyageaiRequest, value: InferenceTypes.VoyageAITaskSettings) =
            { state with TaskSettings = Some value }

    let inferencePutVoyageaiRequest = InferencePutVoyageaiRequestBuilder()

    module PutVoyageai =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutVoyageaiRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: InferenceTypes.InferenceChunkingSettings) (req: InferencePutVoyageaiRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: InferenceTypes.VoyageAIServiceType) (req: InferencePutVoyageaiRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.VoyageAIServiceSettings) (req: InferencePutVoyageaiRequest) =
            { req with ServiceSettings = value }
        let withTaskSettings (value: InferenceTypes.VoyageAITaskSettings) (req: InferencePutVoyageaiRequest) =
            { req with TaskSettings = Some value }

    type InferencePutWatsonxRequest = {
        TaskType: InferenceTypes.WatsonxTaskType
        WatsonxInferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        ChunkingSettings: InferenceTypes.InferenceChunkingSettings option
        Service: InferenceTypes.WatsonxServiceType
        ServiceSettings: InferenceTypes.WatsonxServiceSettings
    }

        with
        static member ToRequest(req: InferencePutWatsonxRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.WatsonxInferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferencePutWatsonxResponse = InferenceTypes.InferenceEndpointInfoWatsonx

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
        member _.TaskType(state: InferencePutWatsonxRequest, value: InferenceTypes.WatsonxTaskType) =
            { state with TaskType = value }

        [<CustomOperation("watsonxInferenceId")>]
        member _.WatsonxInferenceId(state: InferencePutWatsonxRequest, value: CoreTypes.Id) =
            { state with WatsonxInferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferencePutWatsonxRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferencePutWatsonxRequest, value: InferenceTypes.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferencePutWatsonxRequest, value: InferenceTypes.WatsonxServiceType) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferencePutWatsonxRequest, value: InferenceTypes.WatsonxServiceSettings) =
            { state with ServiceSettings = value }

    let inferencePutWatsonxRequest = InferencePutWatsonxRequestBuilder()

    module PutWatsonx =
        let withTimeout (value: CoreTypes.Duration) (req: InferencePutWatsonxRequest) =
            { req with Timeout = Some value }
        let withChunkingSettings (value: InferenceTypes.InferenceChunkingSettings) (req: InferencePutWatsonxRequest) =
            { req with ChunkingSettings = Some value }
        let withService (value: InferenceTypes.WatsonxServiceType) (req: InferencePutWatsonxRequest) =
            { req with Service = value }
        let withServiceSettings (value: InferenceTypes.WatsonxServiceSettings) (req: InferencePutWatsonxRequest) =
            { req with ServiceSettings = value }

    type InferenceRerankRequest = {
        InferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        Query: string
        Input: string list
        ReturnDocuments: bool option
        TopN: CoreTypes.Integer option
        TaskSettings: InferenceTypes.TaskSettings option
    }

        with
        static member ToRequest(req: InferenceRerankRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/rerank/{req.InferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferenceRerankResponse = InferenceTypes.RerankedInferenceResult

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
        member _.InferenceId(state: InferenceRerankRequest, value: CoreTypes.Id) =
            { state with InferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferenceRerankRequest, value: CoreTypes.Duration) =
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
        member _.TopN(state: InferenceRerankRequest, value: CoreTypes.Integer) =
            { state with TopN = Some value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferenceRerankRequest, value: InferenceTypes.TaskSettings) =
            { state with TaskSettings = Some value }

    let inferenceRerankRequest = InferenceRerankRequestBuilder()

    module Rerank =
        let withTimeout (value: CoreTypes.Duration) (req: InferenceRerankRequest) =
            { req with Timeout = Some value }
        let withQuery (value: string) (req: InferenceRerankRequest) =
            { req with Query = value }
        let withInput (value: string list) (req: InferenceRerankRequest) =
            { req with Input = value }
        let withReturnDocuments (value: bool) (req: InferenceRerankRequest) =
            { req with ReturnDocuments = Some value }
        let withTopN (value: CoreTypes.Integer) (req: InferenceRerankRequest) =
            { req with TopN = Some value }
        let withTaskSettings (value: InferenceTypes.TaskSettings) (req: InferenceRerankRequest) =
            { req with TaskSettings = Some value }

    type InferenceSparseEmbeddingRequest = {
        InferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        Input: System.Text.Json.JsonElement
        TaskSettings: InferenceTypes.TaskSettings option
    }

        with
        static member ToRequest(req: InferenceSparseEmbeddingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/sparse_embedding/{req.InferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferenceSparseEmbeddingResponse = InferenceTypes.SparseEmbeddingInferenceResult

    type InferenceSparseEmbeddingRequestBuilder() =
        member _.Yield(_: unit) : InferenceSparseEmbeddingRequest =
            {
                InferenceId = Unchecked.defaultof<_>
                Timeout = None
                Input = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: InferenceSparseEmbeddingRequest, value: CoreTypes.Id) =
            { state with InferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferenceSparseEmbeddingRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("input")>]
        member _.Input(state: InferenceSparseEmbeddingRequest, value: System.Text.Json.JsonElement) =
            { state with Input = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferenceSparseEmbeddingRequest, value: InferenceTypes.TaskSettings) =
            { state with TaskSettings = Some value }

    let inferenceSparseEmbeddingRequest = InferenceSparseEmbeddingRequestBuilder()

    module SparseEmbedding =
        let withTimeout (value: CoreTypes.Duration) (req: InferenceSparseEmbeddingRequest) =
            { req with Timeout = Some value }
        let withInput (value: System.Text.Json.JsonElement) (req: InferenceSparseEmbeddingRequest) =
            { req with Input = value }
        let withTaskSettings (value: InferenceTypes.TaskSettings) (req: InferenceSparseEmbeddingRequest) =
            { req with TaskSettings = Some value }

    type InferenceStreamCompletionRequest = {
        InferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        Input: System.Text.Json.JsonElement
        TaskSettings: InferenceTypes.TaskSettings option
    }

        with
        static member ToRequest(req: InferenceStreamCompletionRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/completion/{req.InferenceId}/_stream"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferenceStreamCompletionResponse = CoreTypes.StreamResult

    type InferenceStreamCompletionRequestBuilder() =
        member _.Yield(_: unit) : InferenceStreamCompletionRequest =
            {
                InferenceId = Unchecked.defaultof<_>
                Timeout = None
                Input = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: InferenceStreamCompletionRequest, value: CoreTypes.Id) =
            { state with InferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferenceStreamCompletionRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("input")>]
        member _.Input(state: InferenceStreamCompletionRequest, value: System.Text.Json.JsonElement) =
            { state with Input = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferenceStreamCompletionRequest, value: InferenceTypes.TaskSettings) =
            { state with TaskSettings = Some value }

    let inferenceStreamCompletionRequest = InferenceStreamCompletionRequestBuilder()

    module StreamCompletion =
        let withTimeout (value: CoreTypes.Duration) (req: InferenceStreamCompletionRequest) =
            { req with Timeout = Some value }
        let withInput (value: System.Text.Json.JsonElement) (req: InferenceStreamCompletionRequest) =
            { req with Input = value }
        let withTaskSettings (value: InferenceTypes.TaskSettings) (req: InferenceStreamCompletionRequest) =
            { req with TaskSettings = Some value }

    type InferenceTextEmbeddingRequest = {
        InferenceId: CoreTypes.Id
        Timeout: CoreTypes.Duration option
        Input: System.Text.Json.JsonElement
        InputType: string option
        TaskSettings: InferenceTypes.TaskSettings option
    }

        with
        static member ToRequest(req: InferenceTextEmbeddingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/text_embedding/{req.InferenceId}"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type InferenceTextEmbeddingResponse = InferenceTypes.TextEmbeddingInferenceResult

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
        member _.InferenceId(state: InferenceTextEmbeddingRequest, value: CoreTypes.Id) =
            { state with InferenceId = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: InferenceTextEmbeddingRequest, value: CoreTypes.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("input")>]
        member _.Input(state: InferenceTextEmbeddingRequest, value: System.Text.Json.JsonElement) =
            { state with Input = value }

        [<CustomOperation("inputType")>]
        member _.InputType(state: InferenceTextEmbeddingRequest, value: string) =
            { state with InputType = Some value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferenceTextEmbeddingRequest, value: InferenceTypes.TaskSettings) =
            { state with TaskSettings = Some value }

    let inferenceTextEmbeddingRequest = InferenceTextEmbeddingRequestBuilder()

    module TextEmbedding =
        let withTimeout (value: CoreTypes.Duration) (req: InferenceTextEmbeddingRequest) =
            { req with Timeout = Some value }
        let withInput (value: System.Text.Json.JsonElement) (req: InferenceTextEmbeddingRequest) =
            { req with Input = value }
        let withInputType (value: string) (req: InferenceTextEmbeddingRequest) =
            { req with InputType = Some value }
        let withTaskSettings (value: InferenceTypes.TaskSettings) (req: InferenceTextEmbeddingRequest) =
            { req with TaskSettings = Some value }

    type InferenceUpdateRequest = {
        InferenceId: CoreTypes.Id
        TaskType: InferenceTypes.TaskType
        Document: obj
    }

        with
        static member ToRequest(req: InferenceUpdateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_inference/{req.TaskType}/{req.InferenceId}/_update"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type InferenceUpdateResponse = InferenceTypes.InferenceEndpointInfo

    type InferenceUpdateRequestBuilder() =
        member _.Yield(_: unit) : InferenceUpdateRequest =
            {
                InferenceId = Unchecked.defaultof<_>
                TaskType = Unchecked.defaultof<_>
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: InferenceUpdateRequest, value: CoreTypes.Id) =
            { state with InferenceId = value }

        [<CustomOperation("taskType")>]
        member _.TaskType(state: InferenceUpdateRequest, value: InferenceTypes.TaskType) =
            { state with TaskType = value }

        [<CustomOperation("document")>]
        member _.Document(state: InferenceUpdateRequest, value) =
            { state with Document = value }

    let inferenceUpdateRequest = InferenceUpdateRequestBuilder()


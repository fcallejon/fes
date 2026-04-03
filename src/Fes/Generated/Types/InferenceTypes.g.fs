// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module InferenceTypes =

    type AdaptiveAllocations = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("max_number_of_allocations")>]
        MaxNumberOfAllocations: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_number_of_allocations")>]
        MinNumberOfAllocations: CoreTypes.Integer option
    }

    /// This setting helps to minimize the number of rate limit errors returned from the service.
    type RateLimitSetting = {
        [<System.Text.Json.Serialization.JsonPropertyName("requests_per_minute")>]
        RequestsPerMinute: CoreTypes.Integer option
    }

    type Ai21ServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: string
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: string option
        [<System.Text.Json.Serialization.JsonPropertyName("rate_limit")>]
        RateLimit: RateLimitSetting option
    }

    [<RequireQualifiedAccess>]
    type Ai21ServiceType =
        | Ai21

    [<RequireQualifiedAccess>]
    type Ai21TaskType =
        | Completion
        | ChatCompletion

    type AlibabaCloudServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: string
        [<System.Text.Json.Serialization.JsonPropertyName("host")>]
        Host: string
        [<System.Text.Json.Serialization.JsonPropertyName("rate_limit")>]
        RateLimit: RateLimitSetting option
        [<System.Text.Json.Serialization.JsonPropertyName("service_id")>]
        ServiceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("workspace")>]
        Workspace: string
    }

    [<RequireQualifiedAccess>]
    type AlibabaCloudServiceType =
        | AlibabacloudAiSearch

    type AlibabaCloudTaskSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("input_type")>]
        InputType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("return_token")>]
        ReturnToken: bool option
    }

    [<RequireQualifiedAccess>]
    type AlibabaCloudTaskType =
        | Completion
        | Rerank
        | SparseEmbedding
        | TextEmbedding

    type AmazonBedrockServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("access_key")>]
        AccessKey: string
        [<System.Text.Json.Serialization.JsonPropertyName("model")>]
        Model: string
        [<System.Text.Json.Serialization.JsonPropertyName("provider")>]
        Provider: string option
        [<System.Text.Json.Serialization.JsonPropertyName("region")>]
        Region: string
        [<System.Text.Json.Serialization.JsonPropertyName("rate_limit")>]
        RateLimit: RateLimitSetting option
        [<System.Text.Json.Serialization.JsonPropertyName("secret_key")>]
        SecretKey: string
    }

    [<RequireQualifiedAccess>]
    type AmazonBedrockServiceType =
        | Amazonbedrock

    type AmazonBedrockTaskSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_new_tokens")>]
        MaxNewTokens: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("temperature")>]
        Temperature: CoreTypes.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("top_k")>]
        TopK: CoreTypes.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("top_p")>]
        TopP: CoreTypes.Float option
    }

    [<RequireQualifiedAccess>]
    type AmazonBedrockTaskType =
        | ChatCompletion
        | Completion
        | TextEmbedding

    [<RequireQualifiedAccess>]
    type AmazonSageMakerApi =
        | Openai
        | Elastic

    type AmazonSageMakerServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("access_key")>]
        AccessKey: string
        [<System.Text.Json.Serialization.JsonPropertyName("endpoint_name")>]
        EndpointName: string
        [<System.Text.Json.Serialization.JsonPropertyName("api")>]
        Api: AmazonSageMakerApi
        [<System.Text.Json.Serialization.JsonPropertyName("region")>]
        Region: string
        [<System.Text.Json.Serialization.JsonPropertyName("secret_key")>]
        SecretKey: string
        [<System.Text.Json.Serialization.JsonPropertyName("target_model")>]
        TargetModel: string option
        [<System.Text.Json.Serialization.JsonPropertyName("target_container_hostname")>]
        TargetContainerHostname: string option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_component_name")>]
        InferenceComponentName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("batch_size")>]
        BatchSize: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("dimensions")>]
        Dimensions: CoreTypes.Integer option
    }

    [<RequireQualifiedAccess>]
    type AmazonSageMakerServiceType =
        | AmazonSagemaker

    type AmazonSageMakerTaskSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("custom_attributes")>]
        CustomAttributes: string option
        [<System.Text.Json.Serialization.JsonPropertyName("enable_explanations")>]
        EnableExplanations: string option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("session_id")>]
        SessionId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("target_variant")>]
        TargetVariant: string option
    }

    type AnthropicServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: string
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: string
        [<System.Text.Json.Serialization.JsonPropertyName("rate_limit")>]
        RateLimit: RateLimitSetting option
    }

    [<RequireQualifiedAccess>]
    type AnthropicServiceType =
        | Anthropic

    type AnthropicTaskSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_tokens")>]
        MaxTokens: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("temperature")>]
        Temperature: CoreTypes.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("top_k")>]
        TopK: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("top_p")>]
        TopP: CoreTypes.Float option
    }

    [<RequireQualifiedAccess>]
    type AnthropicTaskType =
        | Completion

    type AzureAiStudioServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: string
        [<System.Text.Json.Serialization.JsonPropertyName("endpoint_type")>]
        EndpointType: string
        [<System.Text.Json.Serialization.JsonPropertyName("target")>]
        Target: string
        [<System.Text.Json.Serialization.JsonPropertyName("provider")>]
        Provider: string
        [<System.Text.Json.Serialization.JsonPropertyName("rate_limit")>]
        RateLimit: RateLimitSetting option
    }

    [<RequireQualifiedAccess>]
    type AzureAiStudioServiceType =
        | Azureaistudio

    type AzureAiStudioTaskSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("do_sample")>]
        DoSample: CoreTypes.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("max_new_tokens")>]
        MaxNewTokens: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("temperature")>]
        Temperature: CoreTypes.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("top_p")>]
        TopP: CoreTypes.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("user")>]
        User: string option
        [<System.Text.Json.Serialization.JsonPropertyName("return_documents")>]
        ReturnDocuments: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("top_n")>]
        TopN: CoreTypes.Integer option
    }

    [<RequireQualifiedAccess>]
    type AzureAiStudioTaskType =
        | Completion
        | Rerank
        | TextEmbedding

    type AzureOpenAIServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: string option
        [<System.Text.Json.Serialization.JsonPropertyName("api_version")>]
        ApiVersion: string
        [<System.Text.Json.Serialization.JsonPropertyName("client_id")>]
        ClientId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("client_secret")>]
        ClientSecret: string option
        [<System.Text.Json.Serialization.JsonPropertyName("deployment_id")>]
        DeploymentId: string
        [<System.Text.Json.Serialization.JsonPropertyName("entra_id")>]
        EntraId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("rate_limit")>]
        RateLimit: RateLimitSetting option
        [<System.Text.Json.Serialization.JsonPropertyName("resource_name")>]
        ResourceName: string
        [<System.Text.Json.Serialization.JsonPropertyName("scopes")>]
        Scopes: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("tenant_id")>]
        TenantId: string option
    }

    [<RequireQualifiedAccess>]
    type AzureOpenAIServiceType =
        | Azureopenai

    type AzureOpenAITaskSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("user")>]
        User: string option
        [<System.Text.Json.Serialization.JsonPropertyName("headers")>]
        Headers: Map<string, string> option
    }

    [<RequireQualifiedAccess>]
    type AzureOpenAITaskType =
        | Completion
        | ChatCompletion
        | TextEmbedding

    /// The base reasoning detail that includes common fields across different types of reasoning details.
    type BaseReasoningDetail = {
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: string option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.Integer option
    }

    [<RequireQualifiedAccess>]
    type CohereEmbeddingType =
        | Binary
        | Bit
        | Byte
        | Float
        | Int8

    [<RequireQualifiedAccess>]
    type CohereInputType =
        | Classification
        | Clustering
        | Ingest
        | Search

    [<RequireQualifiedAccess>]
    type CohereSimilarityType =
        | Cosine
        | DotProduct
        | L2Norm

    type CohereServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: string
        [<System.Text.Json.Serialization.JsonPropertyName("embedding_type")>]
        EmbeddingType: CohereEmbeddingType option
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: string
        [<System.Text.Json.Serialization.JsonPropertyName("rate_limit")>]
        RateLimit: RateLimitSetting option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity")>]
        Similarity: CohereSimilarityType option
    }

    [<RequireQualifiedAccess>]
    type CohereServiceType =
        | Cohere

    [<RequireQualifiedAccess>]
    type CohereTruncateType =
        | END
        | NONE
        | START

    type CohereTaskSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("input_type")>]
        InputType: CohereInputType
        [<System.Text.Json.Serialization.JsonPropertyName("return_documents")>]
        ReturnDocuments: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("top_n")>]
        TopN: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("truncate")>]
        Truncate: CohereTruncateType option
    }

    [<RequireQualifiedAccess>]
    type CohereTaskType =
        | Completion
        | Rerank
        | TextEmbedding

    /// The completion result object
    type CompletionResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("result")>]
        Result: string
    }

    /// Defines the completion result.
    type CompletionInferenceResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("completion")>]
        Completion: CompletionResult list
    }

    /// The completion tool function definition.
    type CompletionToolFunction = {
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
        [<System.Text.Json.Serialization.JsonPropertyName("parameters")>]
        Parameters: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("strict")>]
        Strict: bool option
    }

    /// A list of tools that the model can call.
    type CompletionTool = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("function")>]
        Function: CompletionToolFunction
    }

    /// The tool choice function.
    type CompletionToolChoiceFunction = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
    }

    /// Controls which tool is called by the model.
    type CompletionToolChoice = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("function")>]
        Function: CompletionToolChoiceFunction
    }

    [<RequireQualifiedAccess>]
    type CompletionToolType =
        | String of string
        | CompletionToolChoice of CompletionToolChoice

    [<RequireQualifiedAccess>]
    type ContentType =
        | Text
        | ImageUrl
        | File

    [<RequireQualifiedAccess>]
    type ImageUrlDetail =
        | Auto
        | Low
        | High

    type ImageUrl = {
        [<System.Text.Json.Serialization.JsonPropertyName("url")>]
        Url: string
        [<System.Text.Json.Serialization.JsonPropertyName("detail")>]
        Detail: ImageUrlDetail option
    }

    type FileContent = {
        [<System.Text.Json.Serialization.JsonPropertyName("file_data")>]
        FileData: string
        [<System.Text.Json.Serialization.JsonPropertyName("filename")>]
        Filename: string
    }

    /// An object style representation of a single portion of a conversation.
    type ContentObject = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: ContentType
        [<System.Text.Json.Serialization.JsonPropertyName("text")>]
        Text: string
        [<System.Text.Json.Serialization.JsonPropertyName("image_url")>]
        ImageUrl: ImageUrl
        [<System.Text.Json.Serialization.JsonPropertyName("file")>]
        File: FileContent
    }

    type ContextualAIServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: string
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: string
        [<System.Text.Json.Serialization.JsonPropertyName("rate_limit")>]
        RateLimit: RateLimitSetting option
    }

    [<RequireQualifiedAccess>]
    type ContextualAIServiceType =
        | Contextualai

    type ContextualAITaskSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("instruction")>]
        Instruction: string option
        [<System.Text.Json.Serialization.JsonPropertyName("return_documents")>]
        ReturnDocuments: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("top_k")>]
        TopK: CoreTypes.Integer option
    }

    type CustomRequestParams = {
        [<System.Text.Json.Serialization.JsonPropertyName("content")>]
        Content: string
    }

    type CustomResponseParams = {
        [<System.Text.Json.Serialization.JsonPropertyName("json_parser")>]
        JsonParser: Map<string, string>
    }

    [<RequireQualifiedAccess>]
    type CustomServiceInputType =
        | Classification
        | Clustering
        | Ingest
        | Search

    type CustomServiceQueryParameter = string list

    type CustomServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("batch_size")>]
        BatchSize: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("headers")>]
        Headers: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("input_type")>]
        InputType: Map<CustomServiceInputType, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("query_parameters")>]
        QueryParameters: CustomServiceQueryParameter list option
        [<System.Text.Json.Serialization.JsonPropertyName("request")>]
        Request: CustomRequestParams
        [<System.Text.Json.Serialization.JsonPropertyName("response")>]
        Response: CustomResponseParams
        [<System.Text.Json.Serialization.JsonPropertyName("secret_parameters")>]
        SecretParameters: Map<string, string>
        [<System.Text.Json.Serialization.JsonPropertyName("url")>]
        Url: string option
    }

    [<RequireQualifiedAccess>]
    type CustomServiceType =
        | Custom

    [<RequireQualifiedAccess>]
    type CustomTaskParameter =
        | String of string
        | Integer of CoreTypes.Integer
        | Double of CoreTypes.Double
        | Float of CoreTypes.Float
        | Boolean of bool

    type CustomTaskSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("parameters")>]
        Parameters: Map<string, CustomTaskParameter> option
    }

    [<RequireQualifiedAccess>]
    type CustomTaskType =
        | TextEmbedding
        | SparseEmbedding
        | Rerank
        | Completion

    type DeepSeekServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: string
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: string
        [<System.Text.Json.Serialization.JsonPropertyName("url")>]
        Url: string option
    }

    [<RequireQualifiedAccess>]
    type DeepSeekServiceType =
        | Deepseek

    /// Acknowledged response. For dry_run, contains the list of pipelines which reference the inference endpoint
    type DeleteInferenceEndpointResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("pipelines")>]
        Pipelines: string list
    }

    /// Dense Embedding results containing bytes are represented as Dense
    type DenseByteVector = CoreTypes.Byte list

    /// The dense embedding result object for byte representation
    type DenseEmbeddingByteResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("embedding")>]
        Embedding: DenseByteVector
    }

    /// Dense Embedding results are represented as Dense Vectors
    type DenseVector = CoreTypes.Float list

    /// The dense embedding result object for float representation
    type DenseEmbeddingResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("embedding")>]
        Embedding: DenseVector
    }

    type ElasticsearchServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("adaptive_allocations")>]
        AdaptiveAllocations: AdaptiveAllocations option
        [<System.Text.Json.Serialization.JsonPropertyName("deployment_id")>]
        DeploymentId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: string
        [<System.Text.Json.Serialization.JsonPropertyName("num_allocations")>]
        NumAllocations: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("num_threads")>]
        NumThreads: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("long_document_strategy")>]
        LongDocumentStrategy: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_chunks_per_doc")>]
        MaxChunksPerDoc: CoreTypes.Integer option
    }

    [<RequireQualifiedAccess>]
    type ElasticsearchServiceType =
        | Elasticsearch

    type ElasticsearchTaskSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("return_documents")>]
        ReturnDocuments: bool option
    }

    [<RequireQualifiedAccess>]
    type ElasticsearchTaskType =
        | Rerank
        | SparseEmbedding
        | TextEmbedding

    type ElserServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("adaptive_allocations")>]
        AdaptiveAllocations: AdaptiveAllocations option
        [<System.Text.Json.Serialization.JsonPropertyName("num_allocations")>]
        NumAllocations: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("num_threads")>]
        NumThreads: CoreTypes.Integer
    }

    [<RequireQualifiedAccess>]
    type ElserServiceType =
        | Elser

    [<RequireQualifiedAccess>]
    type ElserTaskType =
        | SparseEmbedding

    [<RequireQualifiedAccess>]
    type EmbeddingContentFormat =
        | Text
        | Base64

    [<RequireQualifiedAccess>]
    type EmbeddingContentType =
        | Text
        | Image

    /// An object containing the input data for the model to embed.
    type EmbeddingContentObjectContents = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: EmbeddingContentType
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: EmbeddingContentFormat option
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: string
    }

    /// A wrapper object which contains the fields required to specify multimodal inputs
    type EmbeddingContentObject = {
        [<System.Text.Json.Serialization.JsonPropertyName("content")>]
        Content: EmbeddingContentObjectContents
    }

    /// Allows specifying multimodal inputs for the `embedding` task.
    [<RequireQualifiedAccess>]
    type EmbeddingContentInput =
        | EmbeddingContentObject of EmbeddingContentObject
        | Array of EmbeddingContentObject list

    /// EmbeddingInferenceResult is an aggregation of mutually exclusive embeddings variants
    [<RequireQualifiedAccess>]
    type EmbeddingInferenceResult =
        | EmbeddingsBytes of DenseEmbeddingByteResult list
        | EmbeddingsBits of DenseEmbeddingByteResult list
        | Embeddings of DenseEmbeddingResult list

    /// Allows specifying text-only inputs for the `embedding` task.
    [<RequireQualifiedAccess>]
    type EmbeddingStringInput =
        | String of string
        | Array of string list

    /// Inference input.
    [<RequireQualifiedAccess>]
    type EmbeddingInput =
        | EmbeddingStringInput of EmbeddingStringInput
        | EmbeddingContentInput of EmbeddingContentInput

    /// The reasoning detail with encrypted reasoning data that may be redacted or protected.
    type EncryptedReasoningDetail = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("data")>]
        Data: string
    }

    [<RequireQualifiedAccess>]
    type FireworksAISimilarityType =
        | Cosine
        | DotProduct
        | L2Norm

    type FireworksAIServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: string
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: string
        [<System.Text.Json.Serialization.JsonPropertyName("url")>]
        Url: string option
        [<System.Text.Json.Serialization.JsonPropertyName("dimensions")>]
        Dimensions: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity")>]
        Similarity: FireworksAISimilarityType option
        [<System.Text.Json.Serialization.JsonPropertyName("rate_limit")>]
        RateLimit: RateLimitSetting option
    }

    [<RequireQualifiedAccess>]
    type FireworksAIServiceType =
        | Fireworksai

    type FireworksAITaskSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("user")>]
        User: string option
        [<System.Text.Json.Serialization.JsonPropertyName("headers")>]
        Headers: Map<string, string> option
    }

    [<RequireQualifiedAccess>]
    type FireworksAITaskType =
        | ChatCompletion
        | Completion
        | TextEmbedding

    [<RequireQualifiedAccess>]
    type GoogleAiServiceType =
        | Googleaistudio

    type GoogleAiStudioServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: string
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: string
        [<System.Text.Json.Serialization.JsonPropertyName("rate_limit")>]
        RateLimit: RateLimitSetting option
    }

    [<RequireQualifiedAccess>]
    type GoogleAiStudioTaskType =
        | Completion
        | TextEmbedding

    [<RequireQualifiedAccess>]
    type GoogleModelGardenProvider =
        | Google
        | Anthropic
        | Meta
        | HuggingFace
        | Mistral
        | Ai21

    type GoogleVertexAIServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("provider")>]
        Provider: GoogleModelGardenProvider option
        [<System.Text.Json.Serialization.JsonPropertyName("url")>]
        Url: string option
        [<System.Text.Json.Serialization.JsonPropertyName("streaming_url")>]
        StreamingUrl: string option
        [<System.Text.Json.Serialization.JsonPropertyName("location")>]
        Location: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("project_id")>]
        ProjectId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("rate_limit")>]
        RateLimit: RateLimitSetting option
        [<System.Text.Json.Serialization.JsonPropertyName("service_account_json")>]
        ServiceAccountJson: string
        [<System.Text.Json.Serialization.JsonPropertyName("dimensions")>]
        Dimensions: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_batch_size")>]
        MaxBatchSize: CoreTypes.Integer option
    }

    [<RequireQualifiedAccess>]
    type GoogleVertexAIServiceType =
        | Googlevertexai

    type ThinkingConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("thinking_budget")>]
        ThinkingBudget: CoreTypes.Integer option
    }

    type GoogleVertexAITaskSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("auto_truncate")>]
        AutoTruncate: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("top_n")>]
        TopN: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("thinking_config")>]
        ThinkingConfig: ThinkingConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("max_tokens")>]
        MaxTokens: CoreTypes.Integer option
    }

    [<RequireQualifiedAccess>]
    type GoogleVertexAITaskType =
        | Rerank
        | TextEmbedding
        | Completion
        | ChatCompletion

    type GroqServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: string
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: string option
        [<System.Text.Json.Serialization.JsonPropertyName("rate_limit")>]
        RateLimit: RateLimitSetting option
    }

    [<RequireQualifiedAccess>]
    type GroqServiceType =
        | Groq

    [<RequireQualifiedAccess>]
    type GroqTaskType =
        | ChatCompletion

    type HuggingFaceServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: string
        [<System.Text.Json.Serialization.JsonPropertyName("rate_limit")>]
        RateLimit: RateLimitSetting option
        [<System.Text.Json.Serialization.JsonPropertyName("url")>]
        Url: string
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: string option
    }

    [<RequireQualifiedAccess>]
    type HuggingFaceServiceType =
        | HuggingFace

    type HuggingFaceTaskSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("return_documents")>]
        ReturnDocuments: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("top_n")>]
        TopN: CoreTypes.Integer option
    }

    [<RequireQualifiedAccess>]
    type HuggingFaceTaskType =
        | ChatCompletion
        | Completion
        | Rerank
        | TextEmbedding

    /// Chunking configuration object
    type InferenceChunkingSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_chunk_size")>]
        MaxChunkSize: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("overlap")>]
        Overlap: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("sentence_overlap")>]
        SentenceOverlap: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("separator_group")>]
        SeparatorGroup: string option
        [<System.Text.Json.Serialization.JsonPropertyName("separators")>]
        Separators: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("strategy")>]
        Strategy: string option
    }

    type ServiceSettings = System.Text.Json.JsonElement

    type TaskSettings = System.Text.Json.JsonElement

    /// Configuration options when storing the inference endpoint
    type InferenceEndpoint = {
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: InferenceChunkingSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("service")>]
        Service: string
        [<System.Text.Json.Serialization.JsonPropertyName("service_settings")>]
        ServiceSettings: ServiceSettings
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: TaskSettings option
    }

    [<RequireQualifiedAccess>]
    type TaskType =
        | SparseEmbedding
        | TextEmbedding
        | Rerank
        | Completion
        | ChatCompletion
        | Embedding

    /// Represents an inference endpoint as returned by the GET API
    type InferenceEndpointInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskType
    }

    [<RequireQualifiedAccess>]
    type TaskTypeAi21 =
        | Completion
        | ChatCompletion

    type InferenceEndpointInfoAi21 = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeAi21
    }

    [<RequireQualifiedAccess>]
    type TaskTypeAlibabaCloudAI =
        | TextEmbedding
        | Rerank
        | Completion
        | SparseEmbedding

    type InferenceEndpointInfoAlibabaCloudAI = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeAlibabaCloudAI
    }

    [<RequireQualifiedAccess>]
    type TaskTypeAmazonBedrock =
        | ChatCompletion
        | Completion
        | TextEmbedding

    type InferenceEndpointInfoAmazonBedrock = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeAmazonBedrock
    }

    [<RequireQualifiedAccess>]
    type TaskTypeAmazonSageMaker =
        | TextEmbedding
        | Completion
        | ChatCompletion
        | SparseEmbedding
        | Rerank

    type InferenceEndpointInfoAmazonSageMaker = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeAmazonSageMaker
    }

    [<RequireQualifiedAccess>]
    type TaskTypeAnthropic =
        | Completion

    type InferenceEndpointInfoAnthropic = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeAnthropic
    }

    [<RequireQualifiedAccess>]
    type TaskTypeAzureAIStudio =
        | TextEmbedding
        | Completion
        | Rerank

    type InferenceEndpointInfoAzureAIStudio = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeAzureAIStudio
    }

    [<RequireQualifiedAccess>]
    type TaskTypeAzureOpenAI =
        | TextEmbedding
        | Completion
        | ChatCompletion

    type InferenceEndpointInfoAzureOpenAI = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeAzureOpenAI
    }

    [<RequireQualifiedAccess>]
    type TaskTypeCohere =
        | TextEmbedding
        | Rerank
        | Completion

    type InferenceEndpointInfoCohere = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeCohere
    }

    [<RequireQualifiedAccess>]
    type TaskTypeContextualAI =
        | Rerank

    type InferenceEndpointInfoContextualAi = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeContextualAI
    }

    [<RequireQualifiedAccess>]
    type TaskTypeCustom =
        | TextEmbedding
        | SparseEmbedding
        | Rerank
        | Completion

    type InferenceEndpointInfoCustom = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeCustom
    }

    [<RequireQualifiedAccess>]
    type TaskTypeDeepSeek =
        | Completion
        | ChatCompletion

    type InferenceEndpointInfoDeepSeek = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeDeepSeek
    }

    [<RequireQualifiedAccess>]
    type TaskTypeELSER =
        | SparseEmbedding

    type InferenceEndpointInfoELSER = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeELSER
    }

    [<RequireQualifiedAccess>]
    type TaskTypeElasticsearch =
        | SparseEmbedding
        | TextEmbedding
        | Rerank

    type InferenceEndpointInfoElasticsearch = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeElasticsearch
    }

    [<RequireQualifiedAccess>]
    type TaskTypeFireworksAI =
        | ChatCompletion
        | Completion
        | TextEmbedding

    type InferenceEndpointInfoFireworksAI = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeFireworksAI
    }

    [<RequireQualifiedAccess>]
    type TaskTypeGoogleAIStudio =
        | TextEmbedding
        | Completion

    type InferenceEndpointInfoGoogleAIStudio = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeGoogleAIStudio
    }

    [<RequireQualifiedAccess>]
    type TaskTypeGoogleVertexAI =
        | ChatCompletion
        | Completion
        | TextEmbedding
        | Rerank

    type InferenceEndpointInfoGoogleVertexAI = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeGoogleVertexAI
    }

    [<RequireQualifiedAccess>]
    type TaskTypeGroq =
        | ChatCompletion

    type InferenceEndpointInfoGroq = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeGroq
    }

    [<RequireQualifiedAccess>]
    type TaskTypeHuggingFace =
        | ChatCompletion
        | Completion
        | Rerank
        | TextEmbedding

    type InferenceEndpointInfoHuggingFace = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeHuggingFace
    }

    [<RequireQualifiedAccess>]
    type TaskTypeJinaAi =
        | Embedding
        | TextEmbedding
        | Rerank

    type InferenceEndpointInfoJinaAi = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeJinaAi
    }

    [<RequireQualifiedAccess>]
    type TaskTypeLlama =
        | TextEmbedding
        | ChatCompletion
        | Completion

    type InferenceEndpointInfoLlama = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeLlama
    }

    [<RequireQualifiedAccess>]
    type TaskTypeMistral =
        | TextEmbedding
        | ChatCompletion
        | Completion

    type InferenceEndpointInfoMistral = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeMistral
    }

    [<RequireQualifiedAccess>]
    type TaskTypeNvidia =
        | ChatCompletion
        | Completion
        | Rerank
        | TextEmbedding

    type InferenceEndpointInfoNvidia = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeNvidia
    }

    [<RequireQualifiedAccess>]
    type TaskTypeOpenAI =
        | TextEmbedding
        | ChatCompletion
        | Completion

    type InferenceEndpointInfoOpenAI = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeOpenAI
    }

    [<RequireQualifiedAccess>]
    type TaskTypeOpenShiftAi =
        | TextEmbedding
        | ChatCompletion
        | Completion
        | Rerank

    type InferenceEndpointInfoOpenShiftAi = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeOpenShiftAi
    }

    [<RequireQualifiedAccess>]
    type TaskTypeVoyageAI =
        | TextEmbedding
        | Rerank

    type InferenceEndpointInfoVoyageAI = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeVoyageAI
    }

    [<RequireQualifiedAccess>]
    type TaskTypeWatsonx =
        | TextEmbedding
        | ChatCompletion
        | Completion

    type InferenceEndpointInfoWatsonx = {
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string
        [<System.Text.Json.Serialization.JsonPropertyName("task_type")>]
        TaskType: TaskTypeWatsonx
    }

    /// Sparse Embedding tokens are represented as a dictionary
    type SparseVector = Map<string, CoreTypes.Float>

    type SparseEmbeddingResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("is_truncated")>]
        IsTruncated: bool
        [<System.Text.Json.Serialization.JsonPropertyName("embedding")>]
        Embedding: SparseVector
    }

    /// The rerank result object representing a single ranked document
    type RankedDocument = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("relevance_score")>]
        RelevanceScore: CoreTypes.Float
        [<System.Text.Json.Serialization.JsonPropertyName("text")>]
        Text: string option
    }

    /// InferenceResult is an aggregation of mutually exclusive variants
    [<RequireQualifiedAccess>]
    type InferenceResult =
        | EmbeddingsBytes of DenseEmbeddingByteResult list
        | EmbeddingsBits of DenseEmbeddingByteResult list
        | Embeddings of DenseEmbeddingResult list
        | TextEmbeddingBytes of DenseEmbeddingByteResult list
        | TextEmbeddingBits of DenseEmbeddingByteResult list
        | TextEmbedding of DenseEmbeddingResult list
        | SparseEmbedding of SparseEmbeddingResult list
        | Completion of CompletionResult list
        | Rerank of RankedDocument list

    [<RequireQualifiedAccess>]
    type JinaAIElementType =
        | Binary
        | Bit
        | Float

    [<RequireQualifiedAccess>]
    type JinaAISimilarityType =
        | Cosine
        | DotProduct
        | L2Norm

    type JinaAIServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: string
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: string
        [<System.Text.Json.Serialization.JsonPropertyName("rate_limit")>]
        RateLimit: RateLimitSetting option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity")>]
        Similarity: JinaAISimilarityType option
        [<System.Text.Json.Serialization.JsonPropertyName("dimensions")>]
        Dimensions: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("element_type")>]
        ElementType: JinaAIElementType option
        [<System.Text.Json.Serialization.JsonPropertyName("multimodal_model")>]
        MultimodalModel: bool option
    }

    [<RequireQualifiedAccess>]
    type JinaAIServiceType =
        | Jinaai

    [<RequireQualifiedAccess>]
    type JinaAITextEmbeddingTask =
        | Classification
        | Clustering
        | Ingest
        | Search

    type JinaAITaskSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("return_documents")>]
        ReturnDocuments: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("input_type")>]
        InputType: JinaAITextEmbeddingTask option
        [<System.Text.Json.Serialization.JsonPropertyName("late_chunking")>]
        LateChunking: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("top_n")>]
        TopN: CoreTypes.Integer option
    }

    [<RequireQualifiedAccess>]
    type JinaAITaskType =
        | Embedding
        | Rerank
        | TextEmbedding

    [<RequireQualifiedAccess>]
    type LlamaSimilarityType =
        | Cosine
        | DotProduct
        | L2Norm

    type LlamaServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("url")>]
        Url: string
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: string
        [<System.Text.Json.Serialization.JsonPropertyName("max_input_tokens")>]
        MaxInputTokens: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity")>]
        Similarity: LlamaSimilarityType option
        [<System.Text.Json.Serialization.JsonPropertyName("rate_limit")>]
        RateLimit: RateLimitSetting option
    }

    [<RequireQualifiedAccess>]
    type LlamaServiceType =
        | Llama

    [<RequireQualifiedAccess>]
    type LlamaTaskType =
        | TextEmbedding
        | Completion
        | ChatCompletion

    [<RequireQualifiedAccess>]
    type MessageContent =
        | String of string
        | Array of ContentObject list

    /// The function that the model called.
    type ToolCallFunction = {
        [<System.Text.Json.Serialization.JsonPropertyName("arguments")>]
        Arguments: string
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
    }

    /// A tool call generated by the model.
    type ToolCall = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("function")>]
        Function: ToolCallFunction
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    /// The reasoning summary detail includes a high-level summary of the model's reasoning process.
    type SummaryReasoningDetail = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("summary")>]
        Summary: string
    }

    /// The reasoning text detail includes plaintext reasoning with optional signature verification.
    type TextReasoningDetail = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("signature")>]
        Signature: string option
        [<System.Text.Json.Serialization.JsonPropertyName("text")>]
        Text: string option
    }

    /// Type representing the different types of reasoning details that can be included in the response from the model.
    [<RequireQualifiedAccess>]
    type ReasoningDetail =
        | EncryptedReasoningDetail of EncryptedReasoningDetail
        | SummaryReasoningDetail of SummaryReasoningDetail
        | TextReasoningDetail of TextReasoningDetail

    /// An object representing part of the conversation.
    type Message = {
        [<System.Text.Json.Serialization.JsonPropertyName("content")>]
        Content: MessageContent option
        [<System.Text.Json.Serialization.JsonPropertyName("role")>]
        Role: string
        [<System.Text.Json.Serialization.JsonPropertyName("tool_call_id")>]
        ToolCallId: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("tool_calls")>]
        ToolCalls: ToolCall list option
        [<System.Text.Json.Serialization.JsonPropertyName("reasoning")>]
        Reasoning: string option
        [<System.Text.Json.Serialization.JsonPropertyName("reasoning_details")>]
        ReasoningDetails: ReasoningDetail list option
    }

    type MistralServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: string
        [<System.Text.Json.Serialization.JsonPropertyName("max_input_tokens")>]
        MaxInputTokens: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("model")>]
        Model: string
        [<System.Text.Json.Serialization.JsonPropertyName("rate_limit")>]
        RateLimit: RateLimitSetting option
    }

    [<RequireQualifiedAccess>]
    type MistralServiceType =
        | Mistral

    [<RequireQualifiedAccess>]
    type MistralTaskType =
        | TextEmbedding
        | Completion
        | ChatCompletion

    [<RequireQualifiedAccess>]
    type NvidiaInputType =
        | Ingest
        | Search

    [<RequireQualifiedAccess>]
    type NvidiaSimilarityType =
        | Cosine
        | DotProduct
        | L2Norm

    type NvidiaServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: string
        [<System.Text.Json.Serialization.JsonPropertyName("url")>]
        Url: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: string
        [<System.Text.Json.Serialization.JsonPropertyName("max_input_tokens")>]
        MaxInputTokens: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity")>]
        Similarity: NvidiaSimilarityType option
        [<System.Text.Json.Serialization.JsonPropertyName("rate_limit")>]
        RateLimit: RateLimitSetting option
    }

    [<RequireQualifiedAccess>]
    type NvidiaServiceType =
        | Nvidia

    type NvidiaTaskSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("input_type")>]
        InputType: NvidiaInputType option
        [<System.Text.Json.Serialization.JsonPropertyName("truncate")>]
        Truncate: CohereTruncateType option
    }

    [<RequireQualifiedAccess>]
    type NvidiaTaskType =
        | ChatCompletion
        | Completion
        | Rerank
        | TextEmbedding

    [<RequireQualifiedAccess>]
    type OpenAISimilarityType =
        | Cosine
        | DotProduct
        | L2Norm

    type OpenAIServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: string
        [<System.Text.Json.Serialization.JsonPropertyName("dimensions")>]
        Dimensions: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: string
        [<System.Text.Json.Serialization.JsonPropertyName("organization_id")>]
        OrganizationId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("rate_limit")>]
        RateLimit: RateLimitSetting option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity")>]
        Similarity: OpenAISimilarityType option
        [<System.Text.Json.Serialization.JsonPropertyName("url")>]
        Url: string option
    }

    [<RequireQualifiedAccess>]
    type OpenAIServiceType =
        | Openai

    type OpenAITaskSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("user")>]
        User: string option
        [<System.Text.Json.Serialization.JsonPropertyName("headers")>]
        Headers: Map<string, string> option
    }

    [<RequireQualifiedAccess>]
    type OpenAITaskType =
        | ChatCompletion
        | Completion
        | TextEmbedding

    [<RequireQualifiedAccess>]
    type OpenShiftAiSimilarityType =
        | Cosine
        | DotProduct
        | L2Norm

    type OpenShiftAiServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: string
        [<System.Text.Json.Serialization.JsonPropertyName("url")>]
        Url: string
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_input_tokens")>]
        MaxInputTokens: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity")>]
        Similarity: OpenShiftAiSimilarityType option
        [<System.Text.Json.Serialization.JsonPropertyName("rate_limit")>]
        RateLimit: RateLimitSetting option
    }

    [<RequireQualifiedAccess>]
    type OpenShiftAiServiceType =
        | OpenshiftAi

    type OpenShiftAiTaskSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("return_documents")>]
        ReturnDocuments: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("top_n")>]
        TopN: CoreTypes.Integer option
    }

    [<RequireQualifiedAccess>]
    type OpenShiftAiTaskType =
        | TextEmbedding
        | Completion
        | ChatCompletion
        | Rerank

    [<RequireQualifiedAccess>]
    type ReasoningEffort =
        | Xhigh
        | High
        | Medium
        | Low
        | Minimal
        | None

    [<RequireQualifiedAccess>]
    type ReasoningSummary =
        | Auto
        | Concise
        | Detailed

    /// The reasoning configuration to use for the completion request.
    type Reasoning = {
        [<System.Text.Json.Serialization.JsonPropertyName("effort")>]
        Effort: ReasoningEffort option
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("exclude")>]
        Exclude: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("summary")>]
        Summary: ReasoningSummary option
    }

    type RequestChatCompletion = {
        [<System.Text.Json.Serialization.JsonPropertyName("messages")>]
        Messages: Message list
        [<System.Text.Json.Serialization.JsonPropertyName("model")>]
        Model: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")>]
        MaxCompletionTokens: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("reasoning")>]
        Reasoning: Reasoning option
        [<System.Text.Json.Serialization.JsonPropertyName("stop")>]
        Stop: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("temperature")>]
        Temperature: CoreTypes.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("tool_choice")>]
        ToolChoice: CompletionToolType option
        [<System.Text.Json.Serialization.JsonPropertyName("tools")>]
        Tools: CompletionTool list option
        [<System.Text.Json.Serialization.JsonPropertyName("top_p")>]
        TopP: CoreTypes.Float option
    }

    type RequestEmbedding = {
        [<System.Text.Json.Serialization.JsonPropertyName("input")>]
        Input: EmbeddingInput
        [<System.Text.Json.Serialization.JsonPropertyName("input_type")>]
        InputType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("task_settings")>]
        TaskSettings: TaskSettings option
    }

    /// Defines the response for a rerank request.
    type RerankedInferenceResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("rerank")>]
        Rerank: RankedDocument list
    }

    /// The response format for the sparse embedding request.
    type SparseEmbeddingInferenceResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("sparse_embedding")>]
        SparseEmbedding: SparseEmbeddingResult list
    }

    /// TextEmbeddingInferenceResult is an aggregation of mutually exclusive text_embedding variants
    [<RequireQualifiedAccess>]
    type TextEmbeddingInferenceResult =
        | TextEmbeddingBytes of DenseEmbeddingByteResult list
        | TextEmbeddingBits of DenseEmbeddingByteResult list
        | TextEmbedding of DenseEmbeddingResult list

    type VoyageAIServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("dimensions")>]
        Dimensions: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: string
        [<System.Text.Json.Serialization.JsonPropertyName("rate_limit")>]
        RateLimit: RateLimitSetting option
        [<System.Text.Json.Serialization.JsonPropertyName("embedding_type")>]
        EmbeddingType: CoreTypes.Float option
    }

    [<RequireQualifiedAccess>]
    type VoyageAIServiceType =
        | Voyageai

    type VoyageAITaskSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("input_type")>]
        InputType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("return_documents")>]
        ReturnDocuments: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("top_k")>]
        TopK: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("truncation")>]
        Truncation: bool option
    }

    [<RequireQualifiedAccess>]
    type VoyageAITaskType =
        | TextEmbedding
        | Rerank

    type WatsonxServiceSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: string
        [<System.Text.Json.Serialization.JsonPropertyName("api_version")>]
        ApiVersion: string
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: string
        [<System.Text.Json.Serialization.JsonPropertyName("project_id")>]
        ProjectId: string
        [<System.Text.Json.Serialization.JsonPropertyName("rate_limit")>]
        RateLimit: RateLimitSetting option
        [<System.Text.Json.Serialization.JsonPropertyName("url")>]
        Url: string
    }

    [<RequireQualifiedAccess>]
    type WatsonxServiceType =
        | Watsonxai

    [<RequireQualifiedAccess>]
    type WatsonxTaskType =
        | TextEmbedding
        | Rerank
        | ChatCompletion
        | Completion


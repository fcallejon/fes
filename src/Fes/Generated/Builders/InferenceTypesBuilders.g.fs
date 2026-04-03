// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module InferenceTypesBuilders =

    type AdaptiveAllocationsBuilder() =
        member _.Yield(_: unit) : AdaptiveAllocations =
            {
                Enabled = None
                MaxNumberOfAllocations = None
                MinNumberOfAllocations = None
            }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: AdaptiveAllocations, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("maxNumberOfAllocations")>]
        member _.MaxNumberOfAllocations(state: AdaptiveAllocations, value: CoreTypes.Integer) =
            { state with MaxNumberOfAllocations = Some value }

        [<CustomOperation("minNumberOfAllocations")>]
        member _.MinNumberOfAllocations(state: AdaptiveAllocations, value: CoreTypes.Integer) =
            { state with MinNumberOfAllocations = Some value }

    let adaptiveAllocations = AdaptiveAllocationsBuilder()

    type Ai21ServiceSettingsBuilder() =
        member _.Yield(_: unit) : Ai21ServiceSettings =
            {
                ModelId = Unchecked.defaultof<_>
                ApiKey = None
                RateLimit = None
            }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: Ai21ServiceSettings, value: string) =
            { state with ModelId = value }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: Ai21ServiceSettings, value: string) =
            { state with ApiKey = Some value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: Ai21ServiceSettings, value: InferenceTypes.RateLimitSetting) =
            { state with RateLimit = Some value }

    let ai21ServiceSettings = Ai21ServiceSettingsBuilder()

    type AlibabaCloudTaskSettingsBuilder() =
        member _.Yield(_: unit) : AlibabaCloudTaskSettings =
            {
                InputType = None
                ReturnToken = None
            }

        [<CustomOperation("inputType")>]
        member _.InputType(state: AlibabaCloudTaskSettings, value: string) =
            { state with InputType = Some value }

        [<CustomOperation("returnToken")>]
        member _.ReturnToken(state: AlibabaCloudTaskSettings, value: bool) =
            { state with ReturnToken = Some value }

    let alibabaCloudTaskSettings = AlibabaCloudTaskSettingsBuilder()

    type AmazonBedrockServiceSettingsBuilder() =
        member _.Yield(_: unit) : AmazonBedrockServiceSettings =
            {
                AccessKey = Unchecked.defaultof<_>
                Model = Unchecked.defaultof<_>
                Provider = None
                Region = Unchecked.defaultof<_>
                RateLimit = None
                SecretKey = Unchecked.defaultof<_>
            }

        [<CustomOperation("accessKey")>]
        member _.AccessKey(state: AmazonBedrockServiceSettings, value: string) =
            { state with AccessKey = value }

        [<CustomOperation("model")>]
        member _.Model(state: AmazonBedrockServiceSettings, value: string) =
            { state with Model = value }

        [<CustomOperation("provider")>]
        member _.Provider(state: AmazonBedrockServiceSettings, value: string) =
            { state with Provider = Some value }

        [<CustomOperation("region")>]
        member _.Region(state: AmazonBedrockServiceSettings, value: string) =
            { state with Region = value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: AmazonBedrockServiceSettings, value: InferenceTypes.RateLimitSetting) =
            { state with RateLimit = Some value }

        [<CustomOperation("secretKey")>]
        member _.SecretKey(state: AmazonBedrockServiceSettings, value: string) =
            { state with SecretKey = value }

    let amazonBedrockServiceSettings = AmazonBedrockServiceSettingsBuilder()

    type AmazonBedrockTaskSettingsBuilder() =
        member _.Yield(_: unit) : AmazonBedrockTaskSettings =
            {
                MaxNewTokens = None
                Temperature = None
                TopK = None
                TopP = None
            }

        [<CustomOperation("maxNewTokens")>]
        member _.MaxNewTokens(state: AmazonBedrockTaskSettings, value: CoreTypes.Integer) =
            { state with MaxNewTokens = Some value }

        [<CustomOperation("temperature")>]
        member _.Temperature(state: AmazonBedrockTaskSettings, value: CoreTypes.Float) =
            { state with Temperature = Some value }

        [<CustomOperation("topK")>]
        member _.TopK(state: AmazonBedrockTaskSettings, value: CoreTypes.Float) =
            { state with TopK = Some value }

        [<CustomOperation("topP")>]
        member _.TopP(state: AmazonBedrockTaskSettings, value: CoreTypes.Float) =
            { state with TopP = Some value }

    let amazonBedrockTaskSettings = AmazonBedrockTaskSettingsBuilder()

    type AmazonSageMakerServiceSettingsBuilder() =
        member _.Yield(_: unit) : AmazonSageMakerServiceSettings =
            {
                AccessKey = Unchecked.defaultof<_>
                EndpointName = Unchecked.defaultof<_>
                Api = Unchecked.defaultof<_>
                Region = Unchecked.defaultof<_>
                SecretKey = Unchecked.defaultof<_>
                TargetModel = None
                TargetContainerHostname = None
                InferenceComponentName = None
                BatchSize = None
                Dimensions = None
            }

        [<CustomOperation("accessKey")>]
        member _.AccessKey(state: AmazonSageMakerServiceSettings, value: string) =
            { state with AccessKey = value }

        [<CustomOperation("endpointName")>]
        member _.EndpointName(state: AmazonSageMakerServiceSettings, value: string) =
            { state with EndpointName = value }

        [<CustomOperation("api")>]
        member _.Api(state: AmazonSageMakerServiceSettings, value: InferenceTypes.AmazonSageMakerApi) =
            { state with Api = value }

        [<CustomOperation("region")>]
        member _.Region(state: AmazonSageMakerServiceSettings, value: string) =
            { state with Region = value }

        [<CustomOperation("secretKey")>]
        member _.SecretKey(state: AmazonSageMakerServiceSettings, value: string) =
            { state with SecretKey = value }

        [<CustomOperation("targetModel")>]
        member _.TargetModel(state: AmazonSageMakerServiceSettings, value: string) =
            { state with TargetModel = Some value }

        [<CustomOperation("targetContainerHostname")>]
        member _.TargetContainerHostname(state: AmazonSageMakerServiceSettings, value: string) =
            { state with TargetContainerHostname = Some value }

        [<CustomOperation("inferenceComponentName")>]
        member _.InferenceComponentName(state: AmazonSageMakerServiceSettings, value: string) =
            { state with InferenceComponentName = Some value }

        [<CustomOperation("batchSize")>]
        member _.BatchSize(state: AmazonSageMakerServiceSettings, value: CoreTypes.Integer) =
            { state with BatchSize = Some value }

        [<CustomOperation("dimensions")>]
        member _.Dimensions(state: AmazonSageMakerServiceSettings, value: CoreTypes.Integer) =
            { state with Dimensions = Some value }

    let amazonSageMakerServiceSettings = AmazonSageMakerServiceSettingsBuilder()

    type AmazonSageMakerTaskSettingsBuilder() =
        member _.Yield(_: unit) : AmazonSageMakerTaskSettings =
            {
                CustomAttributes = None
                EnableExplanations = None
                InferenceId = None
                SessionId = None
                TargetVariant = None
            }

        [<CustomOperation("customAttributes")>]
        member _.CustomAttributes(state: AmazonSageMakerTaskSettings, value: string) =
            { state with CustomAttributes = Some value }

        [<CustomOperation("enableExplanations")>]
        member _.EnableExplanations(state: AmazonSageMakerTaskSettings, value: string) =
            { state with EnableExplanations = Some value }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: AmazonSageMakerTaskSettings, value: string) =
            { state with InferenceId = Some value }

        [<CustomOperation("sessionId")>]
        member _.SessionId(state: AmazonSageMakerTaskSettings, value: string) =
            { state with SessionId = Some value }

        [<CustomOperation("targetVariant")>]
        member _.TargetVariant(state: AmazonSageMakerTaskSettings, value: string) =
            { state with TargetVariant = Some value }

    let amazonSageMakerTaskSettings = AmazonSageMakerTaskSettingsBuilder()

    type AnthropicTaskSettingsBuilder() =
        member _.Yield(_: unit) : AnthropicTaskSettings =
            {
                MaxTokens = Unchecked.defaultof<_>
                Temperature = None
                TopK = None
                TopP = None
            }

        [<CustomOperation("maxTokens")>]
        member _.MaxTokens(state: AnthropicTaskSettings, value: CoreTypes.Integer) =
            { state with MaxTokens = value }

        [<CustomOperation("temperature")>]
        member _.Temperature(state: AnthropicTaskSettings, value: CoreTypes.Float) =
            { state with Temperature = Some value }

        [<CustomOperation("topK")>]
        member _.TopK(state: AnthropicTaskSettings, value: CoreTypes.Integer) =
            { state with TopK = Some value }

        [<CustomOperation("topP")>]
        member _.TopP(state: AnthropicTaskSettings, value: CoreTypes.Float) =
            { state with TopP = Some value }

    let anthropicTaskSettings = AnthropicTaskSettingsBuilder()

    type AzureAiStudioTaskSettingsBuilder() =
        member _.Yield(_: unit) : AzureAiStudioTaskSettings =
            {
                DoSample = None
                MaxNewTokens = None
                Temperature = None
                TopP = None
                User = None
                ReturnDocuments = None
                TopN = None
            }

        [<CustomOperation("doSample")>]
        member _.DoSample(state: AzureAiStudioTaskSettings, value: CoreTypes.Float) =
            { state with DoSample = Some value }

        [<CustomOperation("maxNewTokens")>]
        member _.MaxNewTokens(state: AzureAiStudioTaskSettings, value: CoreTypes.Integer) =
            { state with MaxNewTokens = Some value }

        [<CustomOperation("temperature")>]
        member _.Temperature(state: AzureAiStudioTaskSettings, value: CoreTypes.Float) =
            { state with Temperature = Some value }

        [<CustomOperation("topP")>]
        member _.TopP(state: AzureAiStudioTaskSettings, value: CoreTypes.Float) =
            { state with TopP = Some value }

        [<CustomOperation("user")>]
        member _.User(state: AzureAiStudioTaskSettings, value: string) =
            { state with User = Some value }

        [<CustomOperation("returnDocuments")>]
        member _.ReturnDocuments(state: AzureAiStudioTaskSettings, value: bool) =
            { state with ReturnDocuments = Some value }

        [<CustomOperation("topN")>]
        member _.TopN(state: AzureAiStudioTaskSettings, value: CoreTypes.Integer) =
            { state with TopN = Some value }

    let azureAiStudioTaskSettings = AzureAiStudioTaskSettingsBuilder()

    type AzureOpenAIServiceSettingsBuilder() =
        member _.Yield(_: unit) : AzureOpenAIServiceSettings =
            {
                ApiKey = None
                ApiVersion = Unchecked.defaultof<_>
                ClientId = None
                ClientSecret = None
                DeploymentId = Unchecked.defaultof<_>
                EntraId = None
                RateLimit = None
                ResourceName = Unchecked.defaultof<_>
                Scopes = None
                TenantId = None
            }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: AzureOpenAIServiceSettings, value: string) =
            { state with ApiKey = Some value }

        [<CustomOperation("apiVersion")>]
        member _.ApiVersion(state: AzureOpenAIServiceSettings, value: string) =
            { state with ApiVersion = value }

        [<CustomOperation("clientId")>]
        member _.ClientId(state: AzureOpenAIServiceSettings, value: string) =
            { state with ClientId = Some value }

        [<CustomOperation("clientSecret")>]
        member _.ClientSecret(state: AzureOpenAIServiceSettings, value: string) =
            { state with ClientSecret = Some value }

        [<CustomOperation("deploymentId")>]
        member _.DeploymentId(state: AzureOpenAIServiceSettings, value: string) =
            { state with DeploymentId = value }

        [<CustomOperation("entraId")>]
        member _.EntraId(state: AzureOpenAIServiceSettings, value: string) =
            { state with EntraId = Some value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: AzureOpenAIServiceSettings, value: InferenceTypes.RateLimitSetting) =
            { state with RateLimit = Some value }

        [<CustomOperation("resourceName")>]
        member _.ResourceName(state: AzureOpenAIServiceSettings, value: string) =
            { state with ResourceName = value }

        [<CustomOperation("scopes")>]
        member _.Scopes(state: AzureOpenAIServiceSettings, value: string list) =
            { state with Scopes = Some value }

        [<CustomOperation("tenantId")>]
        member _.TenantId(state: AzureOpenAIServiceSettings, value: string) =
            { state with TenantId = Some value }

    let azureOpenAIServiceSettings = AzureOpenAIServiceSettingsBuilder()

    type AzureOpenAITaskSettingsBuilder() =
        member _.Yield(_: unit) : AzureOpenAITaskSettings =
            {
                User = None
                Headers = None
            }

        [<CustomOperation("user")>]
        member _.User(state: AzureOpenAITaskSettings, value: string) =
            { state with User = Some value }

        [<CustomOperation("headers")>]
        member _.Headers(state: AzureOpenAITaskSettings, value: Map<string, string>) =
            { state with Headers = Some value }

    let azureOpenAITaskSettings = AzureOpenAITaskSettingsBuilder()

    type BaseReasoningDetailBuilder() =
        member _.Yield(_: unit) : BaseReasoningDetail =
            {
                Format = None
                Id = None
                Index = None
            }

        [<CustomOperation("format")>]
        member _.Format(state: BaseReasoningDetail, value: string) =
            { state with Format = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: BaseReasoningDetail, value: string) =
            { state with Id = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: BaseReasoningDetail, value: CoreTypes.Integer) =
            { state with Index = Some value }

    let baseReasoningDetail = BaseReasoningDetailBuilder()

    type CohereServiceSettingsBuilder() =
        member _.Yield(_: unit) : CohereServiceSettings =
            {
                ApiKey = Unchecked.defaultof<_>
                EmbeddingType = None
                ModelId = Unchecked.defaultof<_>
                RateLimit = None
                Similarity = None
            }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: CohereServiceSettings, value: string) =
            { state with ApiKey = value }

        [<CustomOperation("embeddingType")>]
        member _.EmbeddingType(state: CohereServiceSettings, value: InferenceTypes.CohereEmbeddingType) =
            { state with EmbeddingType = Some value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: CohereServiceSettings, value: string) =
            { state with ModelId = value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: CohereServiceSettings, value: InferenceTypes.RateLimitSetting) =
            { state with RateLimit = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: CohereServiceSettings, value: InferenceTypes.CohereSimilarityType) =
            { state with Similarity = Some value }

    let cohereServiceSettings = CohereServiceSettingsBuilder()

    type CohereTaskSettingsBuilder() =
        member _.Yield(_: unit) : CohereTaskSettings =
            {
                InputType = Unchecked.defaultof<_>
                ReturnDocuments = None
                TopN = None
                Truncate = None
            }

        [<CustomOperation("inputType")>]
        member _.InputType(state: CohereTaskSettings, value: InferenceTypes.CohereInputType) =
            { state with InputType = value }

        [<CustomOperation("returnDocuments")>]
        member _.ReturnDocuments(state: CohereTaskSettings, value: bool) =
            { state with ReturnDocuments = Some value }

        [<CustomOperation("topN")>]
        member _.TopN(state: CohereTaskSettings, value: CoreTypes.Integer) =
            { state with TopN = Some value }

        [<CustomOperation("truncate")>]
        member _.Truncate(state: CohereTaskSettings, value: InferenceTypes.CohereTruncateType) =
            { state with Truncate = Some value }

    let cohereTaskSettings = CohereTaskSettingsBuilder()

    type CompletionToolFunctionBuilder() =
        member _.Yield(_: unit) : CompletionToolFunction =
            {
                Description = None
                Name = Unchecked.defaultof<_>
                Parameters = None
                Strict = None
            }

        [<CustomOperation("description")>]
        member _.Description(state: CompletionToolFunction, value: string) =
            { state with Description = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: CompletionToolFunction, value: string) =
            { state with Name = value }

        [<CustomOperation("parameters")>]
        member _.Parameters(state: CompletionToolFunction, value: System.Text.Json.JsonElement) =
            { state with Parameters = Some value }

        [<CustomOperation("strict")>]
        member _.Strict(state: CompletionToolFunction, value: bool) =
            { state with Strict = Some value }

    let completionToolFunction = CompletionToolFunctionBuilder()

    type ContextualAITaskSettingsBuilder() =
        member _.Yield(_: unit) : ContextualAITaskSettings =
            {
                Instruction = None
                ReturnDocuments = None
                TopK = None
            }

        [<CustomOperation("instruction")>]
        member _.Instruction(state: ContextualAITaskSettings, value: string) =
            { state with Instruction = Some value }

        [<CustomOperation("returnDocuments")>]
        member _.ReturnDocuments(state: ContextualAITaskSettings, value: bool) =
            { state with ReturnDocuments = Some value }

        [<CustomOperation("topK")>]
        member _.TopK(state: ContextualAITaskSettings, value: CoreTypes.Integer) =
            { state with TopK = Some value }

    let contextualAITaskSettings = ContextualAITaskSettingsBuilder()

    type CustomServiceSettingsBuilder() =
        member _.Yield(_: unit) : CustomServiceSettings =
            {
                BatchSize = None
                Headers = None
                InputType = None
                QueryParameters = None
                Request = Unchecked.defaultof<_>
                Response = Unchecked.defaultof<_>
                SecretParameters = Unchecked.defaultof<_>
                Url = None
            }

        [<CustomOperation("batchSize")>]
        member _.BatchSize(state: CustomServiceSettings, value: CoreTypes.Integer) =
            { state with BatchSize = Some value }

        [<CustomOperation("headers")>]
        member _.Headers(state: CustomServiceSettings, value: Map<string, string>) =
            { state with Headers = Some value }

        [<CustomOperation("inputType")>]
        member _.InputType(state: CustomServiceSettings, value: Map<InferenceTypes.CustomServiceInputType, string>) =
            { state with InputType = Some value }

        [<CustomOperation("queryParameters")>]
        member _.QueryParameters(state: CustomServiceSettings, value: InferenceTypes.CustomServiceQueryParameter list) =
            { state with QueryParameters = Some value }

        [<CustomOperation("request")>]
        member _.Request(state: CustomServiceSettings, value: InferenceTypes.CustomRequestParams) =
            { state with Request = value }

        [<CustomOperation("response")>]
        member _.Response(state: CustomServiceSettings, value: InferenceTypes.CustomResponseParams) =
            { state with Response = value }

        [<CustomOperation("secretParameters")>]
        member _.SecretParameters(state: CustomServiceSettings, value: Map<string, string>) =
            { state with SecretParameters = value }

        [<CustomOperation("url")>]
        member _.Url(state: CustomServiceSettings, value: string) =
            { state with Url = Some value }

    let customServiceSettings = CustomServiceSettingsBuilder()

    type ElasticsearchServiceSettingsBuilder() =
        member _.Yield(_: unit) : ElasticsearchServiceSettings =
            {
                AdaptiveAllocations = None
                DeploymentId = None
                ModelId = Unchecked.defaultof<_>
                NumAllocations = None
                NumThreads = Unchecked.defaultof<_>
                LongDocumentStrategy = None
                MaxChunksPerDoc = None
            }

        [<CustomOperation("adaptiveAllocations")>]
        member _.AdaptiveAllocations(state: ElasticsearchServiceSettings, value: InferenceTypes.AdaptiveAllocations) =
            { state with AdaptiveAllocations = Some value }

        [<CustomOperation("deploymentId")>]
        member _.DeploymentId(state: ElasticsearchServiceSettings, value: string) =
            { state with DeploymentId = Some value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: ElasticsearchServiceSettings, value: string) =
            { state with ModelId = value }

        [<CustomOperation("numAllocations")>]
        member _.NumAllocations(state: ElasticsearchServiceSettings, value: CoreTypes.Integer) =
            { state with NumAllocations = Some value }

        [<CustomOperation("numThreads")>]
        member _.NumThreads(state: ElasticsearchServiceSettings, value: CoreTypes.Integer) =
            { state with NumThreads = value }

        [<CustomOperation("longDocumentStrategy")>]
        member _.LongDocumentStrategy(state: ElasticsearchServiceSettings, value: string) =
            { state with LongDocumentStrategy = Some value }

        [<CustomOperation("maxChunksPerDoc")>]
        member _.MaxChunksPerDoc(state: ElasticsearchServiceSettings, value: CoreTypes.Integer) =
            { state with MaxChunksPerDoc = Some value }

    let elasticsearchServiceSettings = ElasticsearchServiceSettingsBuilder()

    module EmbeddingInferenceResult =

        let embeddingsBytes (value: InferenceTypes.DenseEmbeddingByteResult list) =
            EmbeddingInferenceResult.EmbeddingsBytes value

        let embeddingsBits (value: InferenceTypes.DenseEmbeddingByteResult list) =
            EmbeddingInferenceResult.EmbeddingsBits value

        let embeddings (value: InferenceTypes.DenseEmbeddingResult list) =
            EmbeddingInferenceResult.Embeddings value

    type FireworksAIServiceSettingsBuilder() =
        member _.Yield(_: unit) : FireworksAIServiceSettings =
            {
                ApiKey = Unchecked.defaultof<_>
                ModelId = Unchecked.defaultof<_>
                Url = None
                Dimensions = None
                Similarity = None
                RateLimit = None
            }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: FireworksAIServiceSettings, value: string) =
            { state with ApiKey = value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: FireworksAIServiceSettings, value: string) =
            { state with ModelId = value }

        [<CustomOperation("url")>]
        member _.Url(state: FireworksAIServiceSettings, value: string) =
            { state with Url = Some value }

        [<CustomOperation("dimensions")>]
        member _.Dimensions(state: FireworksAIServiceSettings, value: CoreTypes.Integer) =
            { state with Dimensions = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: FireworksAIServiceSettings, value: InferenceTypes.FireworksAISimilarityType) =
            { state with Similarity = Some value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: FireworksAIServiceSettings, value: InferenceTypes.RateLimitSetting) =
            { state with RateLimit = Some value }

    let fireworksAIServiceSettings = FireworksAIServiceSettingsBuilder()

    type FireworksAITaskSettingsBuilder() =
        member _.Yield(_: unit) : FireworksAITaskSettings =
            {
                User = None
                Headers = None
            }

        [<CustomOperation("user")>]
        member _.User(state: FireworksAITaskSettings, value: string) =
            { state with User = Some value }

        [<CustomOperation("headers")>]
        member _.Headers(state: FireworksAITaskSettings, value: Map<string, string>) =
            { state with Headers = Some value }

    let fireworksAITaskSettings = FireworksAITaskSettingsBuilder()

    type GoogleVertexAIServiceSettingsBuilder() =
        member _.Yield(_: unit) : GoogleVertexAIServiceSettings =
            {
                Provider = None
                Url = None
                StreamingUrl = None
                Location = None
                ModelId = None
                ProjectId = None
                RateLimit = None
                ServiceAccountJson = Unchecked.defaultof<_>
                Dimensions = None
                MaxBatchSize = None
            }

        [<CustomOperation("provider")>]
        member _.Provider(state: GoogleVertexAIServiceSettings, value: InferenceTypes.GoogleModelGardenProvider) =
            { state with Provider = Some value }

        [<CustomOperation("url")>]
        member _.Url(state: GoogleVertexAIServiceSettings, value: string) =
            { state with Url = Some value }

        [<CustomOperation("streamingUrl")>]
        member _.StreamingUrl(state: GoogleVertexAIServiceSettings, value: string) =
            { state with StreamingUrl = Some value }

        [<CustomOperation("location")>]
        member _.Location(state: GoogleVertexAIServiceSettings, value: string) =
            { state with Location = Some value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: GoogleVertexAIServiceSettings, value: string) =
            { state with ModelId = Some value }

        [<CustomOperation("projectId")>]
        member _.ProjectId(state: GoogleVertexAIServiceSettings, value: string) =
            { state with ProjectId = Some value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: GoogleVertexAIServiceSettings, value: InferenceTypes.RateLimitSetting) =
            { state with RateLimit = Some value }

        [<CustomOperation("serviceAccountJson")>]
        member _.ServiceAccountJson(state: GoogleVertexAIServiceSettings, value: string) =
            { state with ServiceAccountJson = value }

        [<CustomOperation("dimensions")>]
        member _.Dimensions(state: GoogleVertexAIServiceSettings, value: CoreTypes.Integer) =
            { state with Dimensions = Some value }

        [<CustomOperation("maxBatchSize")>]
        member _.MaxBatchSize(state: GoogleVertexAIServiceSettings, value: CoreTypes.Integer) =
            { state with MaxBatchSize = Some value }

    let googleVertexAIServiceSettings = GoogleVertexAIServiceSettingsBuilder()

    type GoogleVertexAITaskSettingsBuilder() =
        member _.Yield(_: unit) : GoogleVertexAITaskSettings =
            {
                AutoTruncate = None
                TopN = None
                ThinkingConfig = None
                MaxTokens = None
            }

        [<CustomOperation("autoTruncate")>]
        member _.AutoTruncate(state: GoogleVertexAITaskSettings, value: bool) =
            { state with AutoTruncate = Some value }

        [<CustomOperation("topN")>]
        member _.TopN(state: GoogleVertexAITaskSettings, value: CoreTypes.Integer) =
            { state with TopN = Some value }

        [<CustomOperation("thinkingConfig")>]
        member _.ThinkingConfig(state: GoogleVertexAITaskSettings, value: InferenceTypes.ThinkingConfig) =
            { state with ThinkingConfig = Some value }

        [<CustomOperation("maxTokens")>]
        member _.MaxTokens(state: GoogleVertexAITaskSettings, value: CoreTypes.Integer) =
            { state with MaxTokens = Some value }

    let googleVertexAITaskSettings = GoogleVertexAITaskSettingsBuilder()

    type GroqServiceSettingsBuilder() =
        member _.Yield(_: unit) : GroqServiceSettings =
            {
                ModelId = Unchecked.defaultof<_>
                ApiKey = None
                RateLimit = None
            }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: GroqServiceSettings, value: string) =
            { state with ModelId = value }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: GroqServiceSettings, value: string) =
            { state with ApiKey = Some value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: GroqServiceSettings, value: InferenceTypes.RateLimitSetting) =
            { state with RateLimit = Some value }

    let groqServiceSettings = GroqServiceSettingsBuilder()

    type HuggingFaceServiceSettingsBuilder() =
        member _.Yield(_: unit) : HuggingFaceServiceSettings =
            {
                ApiKey = Unchecked.defaultof<_>
                RateLimit = None
                Url = Unchecked.defaultof<_>
                ModelId = None
            }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: HuggingFaceServiceSettings, value: string) =
            { state with ApiKey = value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: HuggingFaceServiceSettings, value: InferenceTypes.RateLimitSetting) =
            { state with RateLimit = Some value }

        [<CustomOperation("url")>]
        member _.Url(state: HuggingFaceServiceSettings, value: string) =
            { state with Url = value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: HuggingFaceServiceSettings, value: string) =
            { state with ModelId = Some value }

    let huggingFaceServiceSettings = HuggingFaceServiceSettingsBuilder()

    type HuggingFaceTaskSettingsBuilder() =
        member _.Yield(_: unit) : HuggingFaceTaskSettings =
            {
                ReturnDocuments = None
                TopN = None
            }

        [<CustomOperation("returnDocuments")>]
        member _.ReturnDocuments(state: HuggingFaceTaskSettings, value: bool) =
            { state with ReturnDocuments = Some value }

        [<CustomOperation("topN")>]
        member _.TopN(state: HuggingFaceTaskSettings, value: CoreTypes.Integer) =
            { state with TopN = Some value }

    let huggingFaceTaskSettings = HuggingFaceTaskSettingsBuilder()

    type InferenceChunkingSettingsBuilder() =
        member _.Yield(_: unit) : InferenceChunkingSettings =
            {
                MaxChunkSize = None
                Overlap = None
                SentenceOverlap = None
                SeparatorGroup = None
                Separators = None
                Strategy = None
            }

        [<CustomOperation("maxChunkSize")>]
        member _.MaxChunkSize(state: InferenceChunkingSettings, value: CoreTypes.Integer) =
            { state with MaxChunkSize = Some value }

        [<CustomOperation("overlap")>]
        member _.Overlap(state: InferenceChunkingSettings, value: CoreTypes.Integer) =
            { state with Overlap = Some value }

        [<CustomOperation("sentenceOverlap")>]
        member _.SentenceOverlap(state: InferenceChunkingSettings, value: CoreTypes.Integer) =
            { state with SentenceOverlap = Some value }

        [<CustomOperation("separatorGroup")>]
        member _.SeparatorGroup(state: InferenceChunkingSettings, value: string) =
            { state with SeparatorGroup = Some value }

        [<CustomOperation("separators")>]
        member _.Separators(state: InferenceChunkingSettings, value: string list) =
            { state with Separators = Some value }

        [<CustomOperation("strategy")>]
        member _.Strategy(state: InferenceChunkingSettings, value: string) =
            { state with Strategy = Some value }

    let inferenceChunkingSettings = InferenceChunkingSettingsBuilder()

    type InferenceEndpointBuilder() =
        member _.Yield(_: unit) : InferenceEndpoint =
            {
                ChunkingSettings = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: InferenceEndpoint, value: InferenceTypes.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: InferenceEndpoint, value: string) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: InferenceEndpoint, value: InferenceTypes.ServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: InferenceEndpoint, value: InferenceTypes.TaskSettings) =
            { state with TaskSettings = Some value }

    let inferenceEndpoint = InferenceEndpointBuilder()

    module InferenceResult =

        let embeddingsBytes (value: InferenceTypes.DenseEmbeddingByteResult list) =
            InferenceResult.EmbeddingsBytes value

        let embeddingsBits (value: InferenceTypes.DenseEmbeddingByteResult list) =
            InferenceResult.EmbeddingsBits value

        let embeddings (value: InferenceTypes.DenseEmbeddingResult list) =
            InferenceResult.Embeddings value

        let textEmbeddingBytes (value: InferenceTypes.DenseEmbeddingByteResult list) =
            InferenceResult.TextEmbeddingBytes value

        let textEmbeddingBits (value: InferenceTypes.DenseEmbeddingByteResult list) =
            InferenceResult.TextEmbeddingBits value

        let textEmbedding (value: InferenceTypes.DenseEmbeddingResult list) =
            InferenceResult.TextEmbedding value

        let sparseEmbedding (value: InferenceTypes.SparseEmbeddingResult list) =
            InferenceResult.SparseEmbedding value

        let completion (value: InferenceTypes.CompletionResult list) =
            InferenceResult.Completion value

        let rerank (value: InferenceTypes.RankedDocument list) =
            InferenceResult.Rerank value

    type JinaAIServiceSettingsBuilder() =
        member _.Yield(_: unit) : JinaAIServiceSettings =
            {
                ApiKey = Unchecked.defaultof<_>
                ModelId = Unchecked.defaultof<_>
                RateLimit = None
                Similarity = None
                Dimensions = None
                ElementType = None
                MultimodalModel = None
            }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: JinaAIServiceSettings, value: string) =
            { state with ApiKey = value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: JinaAIServiceSettings, value: string) =
            { state with ModelId = value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: JinaAIServiceSettings, value: InferenceTypes.RateLimitSetting) =
            { state with RateLimit = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: JinaAIServiceSettings, value: InferenceTypes.JinaAISimilarityType) =
            { state with Similarity = Some value }

        [<CustomOperation("dimensions")>]
        member _.Dimensions(state: JinaAIServiceSettings, value: CoreTypes.Integer) =
            { state with Dimensions = Some value }

        [<CustomOperation("elementType")>]
        member _.ElementType(state: JinaAIServiceSettings, value: InferenceTypes.JinaAIElementType) =
            { state with ElementType = Some value }

        [<CustomOperation("multimodalModel")>]
        member _.MultimodalModel(state: JinaAIServiceSettings, value: bool) =
            { state with MultimodalModel = Some value }

    let jinaAIServiceSettings = JinaAIServiceSettingsBuilder()

    type JinaAITaskSettingsBuilder() =
        member _.Yield(_: unit) : JinaAITaskSettings =
            {
                ReturnDocuments = None
                InputType = None
                LateChunking = None
                TopN = None
            }

        [<CustomOperation("returnDocuments")>]
        member _.ReturnDocuments(state: JinaAITaskSettings, value: bool) =
            { state with ReturnDocuments = Some value }

        [<CustomOperation("inputType")>]
        member _.InputType(state: JinaAITaskSettings, value: InferenceTypes.JinaAITextEmbeddingTask) =
            { state with InputType = Some value }

        [<CustomOperation("lateChunking")>]
        member _.LateChunking(state: JinaAITaskSettings, value: bool) =
            { state with LateChunking = Some value }

        [<CustomOperation("topN")>]
        member _.TopN(state: JinaAITaskSettings, value: CoreTypes.Integer) =
            { state with TopN = Some value }

    let jinaAITaskSettings = JinaAITaskSettingsBuilder()

    type LlamaServiceSettingsBuilder() =
        member _.Yield(_: unit) : LlamaServiceSettings =
            {
                Url = Unchecked.defaultof<_>
                ModelId = Unchecked.defaultof<_>
                MaxInputTokens = None
                Similarity = None
                RateLimit = None
            }

        [<CustomOperation("url")>]
        member _.Url(state: LlamaServiceSettings, value: string) =
            { state with Url = value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: LlamaServiceSettings, value: string) =
            { state with ModelId = value }

        [<CustomOperation("maxInputTokens")>]
        member _.MaxInputTokens(state: LlamaServiceSettings, value: CoreTypes.Integer) =
            { state with MaxInputTokens = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: LlamaServiceSettings, value: InferenceTypes.LlamaSimilarityType) =
            { state with Similarity = Some value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: LlamaServiceSettings, value: InferenceTypes.RateLimitSetting) =
            { state with RateLimit = Some value }

    let llamaServiceSettings = LlamaServiceSettingsBuilder()

    type MessageBuilder() =
        member _.Yield(_: unit) : Message =
            {
                Content = None
                Role = Unchecked.defaultof<_>
                ToolCallId = None
                ToolCalls = None
                Reasoning = None
                ReasoningDetails = None
            }

        [<CustomOperation("content")>]
        member _.Content(state: Message, value: InferenceTypes.MessageContent) =
            { state with Content = Some value }

        [<CustomOperation("role")>]
        member _.Role(state: Message, value: string) =
            { state with Role = value }

        [<CustomOperation("toolCallId")>]
        member _.ToolCallId(state: Message, value: CoreTypes.Id) =
            { state with ToolCallId = Some value }

        [<CustomOperation("toolCalls")>]
        member _.ToolCalls(state: Message, value: InferenceTypes.ToolCall list) =
            { state with ToolCalls = Some value }

        [<CustomOperation("reasoning")>]
        member _.Reasoning(state: Message, value: string) =
            { state with Reasoning = Some value }

        [<CustomOperation("reasoningDetails")>]
        member _.ReasoningDetails(state: Message, value: InferenceTypes.ReasoningDetail list) =
            { state with ReasoningDetails = Some value }

    let message = MessageBuilder()

    type MistralServiceSettingsBuilder() =
        member _.Yield(_: unit) : MistralServiceSettings =
            {
                ApiKey = Unchecked.defaultof<_>
                MaxInputTokens = None
                Model = Unchecked.defaultof<_>
                RateLimit = None
            }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: MistralServiceSettings, value: string) =
            { state with ApiKey = value }

        [<CustomOperation("maxInputTokens")>]
        member _.MaxInputTokens(state: MistralServiceSettings, value: CoreTypes.Integer) =
            { state with MaxInputTokens = Some value }

        [<CustomOperation("model")>]
        member _.Model(state: MistralServiceSettings, value: string) =
            { state with Model = value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: MistralServiceSettings, value: InferenceTypes.RateLimitSetting) =
            { state with RateLimit = Some value }

    let mistralServiceSettings = MistralServiceSettingsBuilder()

    type NvidiaServiceSettingsBuilder() =
        member _.Yield(_: unit) : NvidiaServiceSettings =
            {
                ApiKey = Unchecked.defaultof<_>
                Url = None
                ModelId = Unchecked.defaultof<_>
                MaxInputTokens = None
                Similarity = None
                RateLimit = None
            }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: NvidiaServiceSettings, value: string) =
            { state with ApiKey = value }

        [<CustomOperation("url")>]
        member _.Url(state: NvidiaServiceSettings, value: string) =
            { state with Url = Some value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: NvidiaServiceSettings, value: string) =
            { state with ModelId = value }

        [<CustomOperation("maxInputTokens")>]
        member _.MaxInputTokens(state: NvidiaServiceSettings, value: CoreTypes.Integer) =
            { state with MaxInputTokens = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: NvidiaServiceSettings, value: InferenceTypes.NvidiaSimilarityType) =
            { state with Similarity = Some value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: NvidiaServiceSettings, value: InferenceTypes.RateLimitSetting) =
            { state with RateLimit = Some value }

    let nvidiaServiceSettings = NvidiaServiceSettingsBuilder()

    type NvidiaTaskSettingsBuilder() =
        member _.Yield(_: unit) : NvidiaTaskSettings =
            {
                InputType = None
                Truncate = None
            }

        [<CustomOperation("inputType")>]
        member _.InputType(state: NvidiaTaskSettings, value: InferenceTypes.NvidiaInputType) =
            { state with InputType = Some value }

        [<CustomOperation("truncate")>]
        member _.Truncate(state: NvidiaTaskSettings, value: InferenceTypes.CohereTruncateType) =
            { state with Truncate = Some value }

    let nvidiaTaskSettings = NvidiaTaskSettingsBuilder()

    type OpenAIServiceSettingsBuilder() =
        member _.Yield(_: unit) : OpenAIServiceSettings =
            {
                ApiKey = Unchecked.defaultof<_>
                Dimensions = None
                ModelId = Unchecked.defaultof<_>
                OrganizationId = None
                RateLimit = None
                Similarity = None
                Url = None
            }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: OpenAIServiceSettings, value: string) =
            { state with ApiKey = value }

        [<CustomOperation("dimensions")>]
        member _.Dimensions(state: OpenAIServiceSettings, value: CoreTypes.Integer) =
            { state with Dimensions = Some value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: OpenAIServiceSettings, value: string) =
            { state with ModelId = value }

        [<CustomOperation("organizationId")>]
        member _.OrganizationId(state: OpenAIServiceSettings, value: string) =
            { state with OrganizationId = Some value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: OpenAIServiceSettings, value: InferenceTypes.RateLimitSetting) =
            { state with RateLimit = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: OpenAIServiceSettings, value: InferenceTypes.OpenAISimilarityType) =
            { state with Similarity = Some value }

        [<CustomOperation("url")>]
        member _.Url(state: OpenAIServiceSettings, value: string) =
            { state with Url = Some value }

    let openAIServiceSettings = OpenAIServiceSettingsBuilder()

    type OpenAITaskSettingsBuilder() =
        member _.Yield(_: unit) : OpenAITaskSettings =
            {
                User = None
                Headers = None
            }

        [<CustomOperation("user")>]
        member _.User(state: OpenAITaskSettings, value: string) =
            { state with User = Some value }

        [<CustomOperation("headers")>]
        member _.Headers(state: OpenAITaskSettings, value: Map<string, string>) =
            { state with Headers = Some value }

    let openAITaskSettings = OpenAITaskSettingsBuilder()

    type OpenShiftAiServiceSettingsBuilder() =
        member _.Yield(_: unit) : OpenShiftAiServiceSettings =
            {
                ApiKey = Unchecked.defaultof<_>
                Url = Unchecked.defaultof<_>
                ModelId = None
                MaxInputTokens = None
                Similarity = None
                RateLimit = None
            }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: OpenShiftAiServiceSettings, value: string) =
            { state with ApiKey = value }

        [<CustomOperation("url")>]
        member _.Url(state: OpenShiftAiServiceSettings, value: string) =
            { state with Url = value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: OpenShiftAiServiceSettings, value: string) =
            { state with ModelId = Some value }

        [<CustomOperation("maxInputTokens")>]
        member _.MaxInputTokens(state: OpenShiftAiServiceSettings, value: CoreTypes.Integer) =
            { state with MaxInputTokens = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: OpenShiftAiServiceSettings, value: InferenceTypes.OpenShiftAiSimilarityType) =
            { state with Similarity = Some value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: OpenShiftAiServiceSettings, value: InferenceTypes.RateLimitSetting) =
            { state with RateLimit = Some value }

    let openShiftAiServiceSettings = OpenShiftAiServiceSettingsBuilder()

    type OpenShiftAiTaskSettingsBuilder() =
        member _.Yield(_: unit) : OpenShiftAiTaskSettings =
            {
                ReturnDocuments = None
                TopN = None
            }

        [<CustomOperation("returnDocuments")>]
        member _.ReturnDocuments(state: OpenShiftAiTaskSettings, value: bool) =
            { state with ReturnDocuments = Some value }

        [<CustomOperation("topN")>]
        member _.TopN(state: OpenShiftAiTaskSettings, value: CoreTypes.Integer) =
            { state with TopN = Some value }

    let openShiftAiTaskSettings = OpenShiftAiTaskSettingsBuilder()

    type ReasoningBuilder() =
        member _.Yield(_: unit) : Reasoning =
            {
                Effort = None
                Enabled = None
                Exclude = None
                Summary = None
            }

        [<CustomOperation("effort")>]
        member _.Effort(state: Reasoning, value: InferenceTypes.ReasoningEffort) =
            { state with Effort = Some value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Reasoning, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("exclude")>]
        member _.Exclude(state: Reasoning, value: bool) =
            { state with Exclude = Some value }

        [<CustomOperation("summary")>]
        member _.Summary(state: Reasoning, value: InferenceTypes.ReasoningSummary) =
            { state with Summary = Some value }

    let reasoning = ReasoningBuilder()

    type RequestChatCompletionBuilder() =
        member _.Yield(_: unit) : RequestChatCompletion =
            {
                Messages = Unchecked.defaultof<_>
                Model = None
                MaxCompletionTokens = None
                Reasoning = None
                Stop = None
                Temperature = None
                ToolChoice = None
                Tools = None
                TopP = None
            }

        [<CustomOperation("messages")>]
        member _.Messages(state: RequestChatCompletion, value: InferenceTypes.Message list) =
            { state with Messages = value }

        [<CustomOperation("model")>]
        member _.Model(state: RequestChatCompletion, value: string) =
            { state with Model = Some value }

        [<CustomOperation("maxCompletionTokens")>]
        member _.MaxCompletionTokens(state: RequestChatCompletion, value: CoreTypes.Long) =
            { state with MaxCompletionTokens = Some value }

        [<CustomOperation("reasoning")>]
        member _.Reasoning(state: RequestChatCompletion, value: InferenceTypes.Reasoning) =
            { state with Reasoning = Some value }

        [<CustomOperation("stop")>]
        member _.Stop(state: RequestChatCompletion, value: string list) =
            { state with Stop = Some value }

        [<CustomOperation("temperature")>]
        member _.Temperature(state: RequestChatCompletion, value: CoreTypes.Float) =
            { state with Temperature = Some value }

        [<CustomOperation("toolChoice")>]
        member _.ToolChoice(state: RequestChatCompletion, value: InferenceTypes.CompletionToolType) =
            { state with ToolChoice = Some value }

        [<CustomOperation("tools")>]
        member _.Tools(state: RequestChatCompletion, value: InferenceTypes.CompletionTool list) =
            { state with Tools = Some value }

        [<CustomOperation("topP")>]
        member _.TopP(state: RequestChatCompletion, value: CoreTypes.Float) =
            { state with TopP = Some value }

    let requestChatCompletion = RequestChatCompletionBuilder()

    type RequestEmbeddingBuilder() =
        member _.Yield(_: unit) : RequestEmbedding =
            {
                Input = Unchecked.defaultof<_>
                InputType = None
                TaskSettings = None
            }

        [<CustomOperation("input")>]
        member _.Input(state: RequestEmbedding, value: InferenceTypes.EmbeddingInput) =
            { state with Input = value }

        [<CustomOperation("inputType")>]
        member _.InputType(state: RequestEmbedding, value: string) =
            { state with InputType = Some value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: RequestEmbedding, value: InferenceTypes.TaskSettings) =
            { state with TaskSettings = Some value }

    let requestEmbedding = RequestEmbeddingBuilder()

    module TextEmbeddingInferenceResult =

        let textEmbeddingBytes (value: InferenceTypes.DenseEmbeddingByteResult list) =
            TextEmbeddingInferenceResult.TextEmbeddingBytes value

        let textEmbeddingBits (value: InferenceTypes.DenseEmbeddingByteResult list) =
            TextEmbeddingInferenceResult.TextEmbeddingBits value

        let textEmbedding (value: InferenceTypes.DenseEmbeddingResult list) =
            TextEmbeddingInferenceResult.TextEmbedding value

    type TextReasoningDetailBuilder() =
        member _.Yield(_: unit) : TextReasoningDetail =
            {
                Type = Unchecked.defaultof<_>
                Signature = None
                Text = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: TextReasoningDetail, value: string) =
            { state with Type = value }

        [<CustomOperation("signature")>]
        member _.Signature(state: TextReasoningDetail, value: string) =
            { state with Signature = Some value }

        [<CustomOperation("text")>]
        member _.Text(state: TextReasoningDetail, value: string) =
            { state with Text = Some value }

    let textReasoningDetail = TextReasoningDetailBuilder()

    type VoyageAIServiceSettingsBuilder() =
        member _.Yield(_: unit) : VoyageAIServiceSettings =
            {
                Dimensions = None
                ModelId = Unchecked.defaultof<_>
                RateLimit = None
                EmbeddingType = None
            }

        [<CustomOperation("dimensions")>]
        member _.Dimensions(state: VoyageAIServiceSettings, value: CoreTypes.Integer) =
            { state with Dimensions = Some value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: VoyageAIServiceSettings, value: string) =
            { state with ModelId = value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: VoyageAIServiceSettings, value: InferenceTypes.RateLimitSetting) =
            { state with RateLimit = Some value }

        [<CustomOperation("embeddingType")>]
        member _.EmbeddingType(state: VoyageAIServiceSettings, value: CoreTypes.Float) =
            { state with EmbeddingType = Some value }

    let voyageAIServiceSettings = VoyageAIServiceSettingsBuilder()

    type VoyageAITaskSettingsBuilder() =
        member _.Yield(_: unit) : VoyageAITaskSettings =
            {
                InputType = None
                ReturnDocuments = None
                TopK = None
                Truncation = None
            }

        [<CustomOperation("inputType")>]
        member _.InputType(state: VoyageAITaskSettings, value: string) =
            { state with InputType = Some value }

        [<CustomOperation("returnDocuments")>]
        member _.ReturnDocuments(state: VoyageAITaskSettings, value: bool) =
            { state with ReturnDocuments = Some value }

        [<CustomOperation("topK")>]
        member _.TopK(state: VoyageAITaskSettings, value: CoreTypes.Integer) =
            { state with TopK = Some value }

        [<CustomOperation("truncation")>]
        member _.Truncation(state: VoyageAITaskSettings, value: bool) =
            { state with Truncation = Some value }

    let voyageAITaskSettings = VoyageAITaskSettingsBuilder()


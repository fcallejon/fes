// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module InferenceTypesBuilders =

    type AdaptiveAllocationsBuilder() =
        member _.Yield(_: unit) : Types.AdaptiveAllocations =
            {
                Enabled = None
                MaxNumberOfAllocations = None
                MinNumberOfAllocations = None
            }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.AdaptiveAllocations, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("maxNumberOfAllocations")>]
        member _.MaxNumberOfAllocations(state: Types.AdaptiveAllocations, value: Types.Integer) =
            { state with MaxNumberOfAllocations = Some value }

        [<CustomOperation("minNumberOfAllocations")>]
        member _.MinNumberOfAllocations(state: Types.AdaptiveAllocations, value: Types.Integer) =
            { state with MinNumberOfAllocations = Some value }

    let adaptiveAllocations = AdaptiveAllocationsBuilder()

    type Ai21ServiceSettingsBuilder() =
        member _.Yield(_: unit) : Types.Ai21ServiceSettings =
            {
                ModelId = Unchecked.defaultof<_>
                ApiKey = None
                RateLimit = None
            }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: Types.Ai21ServiceSettings, value: string) =
            { state with ModelId = value }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: Types.Ai21ServiceSettings, value: string) =
            { state with ApiKey = Some value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: Types.Ai21ServiceSettings, value: Types.RateLimitSetting) =
            { state with RateLimit = Some value }

    let ai21ServiceSettings = Ai21ServiceSettingsBuilder()

    type AlibabaCloudTaskSettingsBuilder() =
        member _.Yield(_: unit) : Types.AlibabaCloudTaskSettings =
            {
                InputType = None
                ReturnToken = None
            }

        [<CustomOperation("inputType")>]
        member _.InputType(state: Types.AlibabaCloudTaskSettings, value: string) =
            { state with InputType = Some value }

        [<CustomOperation("returnToken")>]
        member _.ReturnToken(state: Types.AlibabaCloudTaskSettings, value: bool) =
            { state with ReturnToken = Some value }

    let alibabaCloudTaskSettings = AlibabaCloudTaskSettingsBuilder()

    type AmazonBedrockServiceSettingsBuilder() =
        member _.Yield(_: unit) : Types.AmazonBedrockServiceSettings =
            {
                AccessKey = Unchecked.defaultof<_>
                Model = Unchecked.defaultof<_>
                Provider = None
                Region = Unchecked.defaultof<_>
                RateLimit = None
                SecretKey = Unchecked.defaultof<_>
            }

        [<CustomOperation("accessKey")>]
        member _.AccessKey(state: Types.AmazonBedrockServiceSettings, value: string) =
            { state with AccessKey = value }

        [<CustomOperation("model")>]
        member _.Model(state: Types.AmazonBedrockServiceSettings, value: string) =
            { state with Model = value }

        [<CustomOperation("provider")>]
        member _.Provider(state: Types.AmazonBedrockServiceSettings, value: string) =
            { state with Provider = Some value }

        [<CustomOperation("region")>]
        member _.Region(state: Types.AmazonBedrockServiceSettings, value: string) =
            { state with Region = value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: Types.AmazonBedrockServiceSettings, value: Types.RateLimitSetting) =
            { state with RateLimit = Some value }

        [<CustomOperation("secretKey")>]
        member _.SecretKey(state: Types.AmazonBedrockServiceSettings, value: string) =
            { state with SecretKey = value }

    let amazonBedrockServiceSettings = AmazonBedrockServiceSettingsBuilder()

    type AmazonBedrockTaskSettingsBuilder() =
        member _.Yield(_: unit) : Types.AmazonBedrockTaskSettings =
            {
                MaxNewTokens = None
                Temperature = None
                TopK = None
                TopP = None
            }

        [<CustomOperation("maxNewTokens")>]
        member _.MaxNewTokens(state: Types.AmazonBedrockTaskSettings, value: Types.Integer) =
            { state with MaxNewTokens = Some value }

        [<CustomOperation("temperature")>]
        member _.Temperature(state: Types.AmazonBedrockTaskSettings, value: Types.Float) =
            { state with Temperature = Some value }

        [<CustomOperation("topK")>]
        member _.TopK(state: Types.AmazonBedrockTaskSettings, value: Types.Float) =
            { state with TopK = Some value }

        [<CustomOperation("topP")>]
        member _.TopP(state: Types.AmazonBedrockTaskSettings, value: Types.Float) =
            { state with TopP = Some value }

    let amazonBedrockTaskSettings = AmazonBedrockTaskSettingsBuilder()

    type AmazonSageMakerServiceSettingsBuilder() =
        member _.Yield(_: unit) : Types.AmazonSageMakerServiceSettings =
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
        member _.AccessKey(state: Types.AmazonSageMakerServiceSettings, value: string) =
            { state with AccessKey = value }

        [<CustomOperation("endpointName")>]
        member _.EndpointName(state: Types.AmazonSageMakerServiceSettings, value: string) =
            { state with EndpointName = value }

        [<CustomOperation("api")>]
        member _.Api(state: Types.AmazonSageMakerServiceSettings, value: Types.AmazonSageMakerApi) =
            { state with Api = value }

        [<CustomOperation("region")>]
        member _.Region(state: Types.AmazonSageMakerServiceSettings, value: string) =
            { state with Region = value }

        [<CustomOperation("secretKey")>]
        member _.SecretKey(state: Types.AmazonSageMakerServiceSettings, value: string) =
            { state with SecretKey = value }

        [<CustomOperation("targetModel")>]
        member _.TargetModel(state: Types.AmazonSageMakerServiceSettings, value: string) =
            { state with TargetModel = Some value }

        [<CustomOperation("targetContainerHostname")>]
        member _.TargetContainerHostname(state: Types.AmazonSageMakerServiceSettings, value: string) =
            { state with TargetContainerHostname = Some value }

        [<CustomOperation("inferenceComponentName")>]
        member _.InferenceComponentName(state: Types.AmazonSageMakerServiceSettings, value: string) =
            { state with InferenceComponentName = Some value }

        [<CustomOperation("batchSize")>]
        member _.BatchSize(state: Types.AmazonSageMakerServiceSettings, value: Types.Integer) =
            { state with BatchSize = Some value }

        [<CustomOperation("dimensions")>]
        member _.Dimensions(state: Types.AmazonSageMakerServiceSettings, value: Types.Integer) =
            { state with Dimensions = Some value }

    let amazonSageMakerServiceSettings = AmazonSageMakerServiceSettingsBuilder()

    type AmazonSageMakerTaskSettingsBuilder() =
        member _.Yield(_: unit) : Types.AmazonSageMakerTaskSettings =
            {
                CustomAttributes = None
                EnableExplanations = None
                InferenceId = None
                SessionId = None
                TargetVariant = None
            }

        [<CustomOperation("customAttributes")>]
        member _.CustomAttributes(state: Types.AmazonSageMakerTaskSettings, value: string) =
            { state with CustomAttributes = Some value }

        [<CustomOperation("enableExplanations")>]
        member _.EnableExplanations(state: Types.AmazonSageMakerTaskSettings, value: string) =
            { state with EnableExplanations = Some value }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: Types.AmazonSageMakerTaskSettings, value: string) =
            { state with InferenceId = Some value }

        [<CustomOperation("sessionId")>]
        member _.SessionId(state: Types.AmazonSageMakerTaskSettings, value: string) =
            { state with SessionId = Some value }

        [<CustomOperation("targetVariant")>]
        member _.TargetVariant(state: Types.AmazonSageMakerTaskSettings, value: string) =
            { state with TargetVariant = Some value }

    let amazonSageMakerTaskSettings = AmazonSageMakerTaskSettingsBuilder()

    type AnthropicTaskSettingsBuilder() =
        member _.Yield(_: unit) : Types.AnthropicTaskSettings =
            {
                MaxTokens = Unchecked.defaultof<_>
                Temperature = None
                TopK = None
                TopP = None
            }

        [<CustomOperation("maxTokens")>]
        member _.MaxTokens(state: Types.AnthropicTaskSettings, value: Types.Integer) =
            { state with MaxTokens = value }

        [<CustomOperation("temperature")>]
        member _.Temperature(state: Types.AnthropicTaskSettings, value: Types.Float) =
            { state with Temperature = Some value }

        [<CustomOperation("topK")>]
        member _.TopK(state: Types.AnthropicTaskSettings, value: Types.Integer) =
            { state with TopK = Some value }

        [<CustomOperation("topP")>]
        member _.TopP(state: Types.AnthropicTaskSettings, value: Types.Float) =
            { state with TopP = Some value }

    let anthropicTaskSettings = AnthropicTaskSettingsBuilder()

    type AzureAiStudioTaskSettingsBuilder() =
        member _.Yield(_: unit) : Types.AzureAiStudioTaskSettings =
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
        member _.DoSample(state: Types.AzureAiStudioTaskSettings, value: Types.Float) =
            { state with DoSample = Some value }

        [<CustomOperation("maxNewTokens")>]
        member _.MaxNewTokens(state: Types.AzureAiStudioTaskSettings, value: Types.Integer) =
            { state with MaxNewTokens = Some value }

        [<CustomOperation("temperature")>]
        member _.Temperature(state: Types.AzureAiStudioTaskSettings, value: Types.Float) =
            { state with Temperature = Some value }

        [<CustomOperation("topP")>]
        member _.TopP(state: Types.AzureAiStudioTaskSettings, value: Types.Float) =
            { state with TopP = Some value }

        [<CustomOperation("user")>]
        member _.User(state: Types.AzureAiStudioTaskSettings, value: string) =
            { state with User = Some value }

        [<CustomOperation("returnDocuments")>]
        member _.ReturnDocuments(state: Types.AzureAiStudioTaskSettings, value: bool) =
            { state with ReturnDocuments = Some value }

        [<CustomOperation("topN")>]
        member _.TopN(state: Types.AzureAiStudioTaskSettings, value: Types.Integer) =
            { state with TopN = Some value }

    let azureAiStudioTaskSettings = AzureAiStudioTaskSettingsBuilder()

    type AzureOpenAIServiceSettingsBuilder() =
        member _.Yield(_: unit) : Types.AzureOpenAIServiceSettings =
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
        member _.ApiKey(state: Types.AzureOpenAIServiceSettings, value: string) =
            { state with ApiKey = Some value }

        [<CustomOperation("apiVersion")>]
        member _.ApiVersion(state: Types.AzureOpenAIServiceSettings, value: string) =
            { state with ApiVersion = value }

        [<CustomOperation("clientId")>]
        member _.ClientId(state: Types.AzureOpenAIServiceSettings, value: string) =
            { state with ClientId = Some value }

        [<CustomOperation("clientSecret")>]
        member _.ClientSecret(state: Types.AzureOpenAIServiceSettings, value: string) =
            { state with ClientSecret = Some value }

        [<CustomOperation("deploymentId")>]
        member _.DeploymentId(state: Types.AzureOpenAIServiceSettings, value: string) =
            { state with DeploymentId = value }

        [<CustomOperation("entraId")>]
        member _.EntraId(state: Types.AzureOpenAIServiceSettings, value: string) =
            { state with EntraId = Some value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: Types.AzureOpenAIServiceSettings, value: Types.RateLimitSetting) =
            { state with RateLimit = Some value }

        [<CustomOperation("resourceName")>]
        member _.ResourceName(state: Types.AzureOpenAIServiceSettings, value: string) =
            { state with ResourceName = value }

        [<CustomOperation("scopes")>]
        member _.Scopes(state: Types.AzureOpenAIServiceSettings, value: string list) =
            { state with Scopes = Some value }

        [<CustomOperation("tenantId")>]
        member _.TenantId(state: Types.AzureOpenAIServiceSettings, value: string) =
            { state with TenantId = Some value }

    let azureOpenAIServiceSettings = AzureOpenAIServiceSettingsBuilder()

    type AzureOpenAITaskSettingsBuilder() =
        member _.Yield(_: unit) : Types.AzureOpenAITaskSettings =
            {
                User = None
                Headers = None
            }

        [<CustomOperation("user")>]
        member _.User(state: Types.AzureOpenAITaskSettings, value: string) =
            { state with User = Some value }

        [<CustomOperation("headers")>]
        member _.Headers(state: Types.AzureOpenAITaskSettings, value: Map<string, string>) =
            { state with Headers = Some value }

    let azureOpenAITaskSettings = AzureOpenAITaskSettingsBuilder()

    type BaseReasoningDetailBuilder() =
        member _.Yield(_: unit) : Types.BaseReasoningDetail =
            {
                Format = None
                Id = None
                Index = None
            }

        [<CustomOperation("format")>]
        member _.Format(state: Types.BaseReasoningDetail, value: string) =
            { state with Format = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: Types.BaseReasoningDetail, value: string) =
            { state with Id = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.BaseReasoningDetail, value: Types.Integer) =
            { state with Index = Some value }

    let baseReasoningDetail = BaseReasoningDetailBuilder()

    type CohereServiceSettingsBuilder() =
        member _.Yield(_: unit) : Types.CohereServiceSettings =
            {
                ApiKey = Unchecked.defaultof<_>
                EmbeddingType = None
                ModelId = Unchecked.defaultof<_>
                RateLimit = None
                Similarity = None
            }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: Types.CohereServiceSettings, value: string) =
            { state with ApiKey = value }

        [<CustomOperation("embeddingType")>]
        member _.EmbeddingType(state: Types.CohereServiceSettings, value: Types.CohereEmbeddingType) =
            { state with EmbeddingType = Some value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: Types.CohereServiceSettings, value: string) =
            { state with ModelId = value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: Types.CohereServiceSettings, value: Types.RateLimitSetting) =
            { state with RateLimit = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: Types.CohereServiceSettings, value: Types.CohereSimilarityType) =
            { state with Similarity = Some value }

    let cohereServiceSettings = CohereServiceSettingsBuilder()

    type CohereTaskSettingsBuilder() =
        member _.Yield(_: unit) : Types.CohereTaskSettings =
            {
                InputType = Unchecked.defaultof<_>
                ReturnDocuments = None
                TopN = None
                Truncate = None
            }

        [<CustomOperation("inputType")>]
        member _.InputType(state: Types.CohereTaskSettings, value: Types.CohereInputType) =
            { state with InputType = value }

        [<CustomOperation("returnDocuments")>]
        member _.ReturnDocuments(state: Types.CohereTaskSettings, value: bool) =
            { state with ReturnDocuments = Some value }

        [<CustomOperation("topN")>]
        member _.TopN(state: Types.CohereTaskSettings, value: Types.Integer) =
            { state with TopN = Some value }

        [<CustomOperation("truncate")>]
        member _.Truncate(state: Types.CohereTaskSettings, value: Types.CohereTruncateType) =
            { state with Truncate = Some value }

    let cohereTaskSettings = CohereTaskSettingsBuilder()

    type CompletionToolFunctionBuilder() =
        member _.Yield(_: unit) : Types.CompletionToolFunction =
            {
                Description = None
                Name = Unchecked.defaultof<_>
                Parameters = None
                Strict = None
            }

        [<CustomOperation("description")>]
        member _.Description(state: Types.CompletionToolFunction, value: string) =
            { state with Description = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Types.CompletionToolFunction, value: string) =
            { state with Name = value }

        [<CustomOperation("parameters")>]
        member _.Parameters(state: Types.CompletionToolFunction, value: System.Text.Json.JsonElement) =
            { state with Parameters = Some value }

        [<CustomOperation("strict")>]
        member _.Strict(state: Types.CompletionToolFunction, value: bool) =
            { state with Strict = Some value }

    let completionToolFunction = CompletionToolFunctionBuilder()

    type ContextualAITaskSettingsBuilder() =
        member _.Yield(_: unit) : Types.ContextualAITaskSettings =
            {
                Instruction = None
                ReturnDocuments = None
                TopK = None
            }

        [<CustomOperation("instruction")>]
        member _.Instruction(state: Types.ContextualAITaskSettings, value: string) =
            { state with Instruction = Some value }

        [<CustomOperation("returnDocuments")>]
        member _.ReturnDocuments(state: Types.ContextualAITaskSettings, value: bool) =
            { state with ReturnDocuments = Some value }

        [<CustomOperation("topK")>]
        member _.TopK(state: Types.ContextualAITaskSettings, value: Types.Integer) =
            { state with TopK = Some value }

    let contextualAITaskSettings = ContextualAITaskSettingsBuilder()

    type CustomServiceSettingsBuilder() =
        member _.Yield(_: unit) : Types.CustomServiceSettings =
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
        member _.BatchSize(state: Types.CustomServiceSettings, value: Types.Integer) =
            { state with BatchSize = Some value }

        [<CustomOperation("headers")>]
        member _.Headers(state: Types.CustomServiceSettings, value: Map<string, string>) =
            { state with Headers = Some value }

        [<CustomOperation("inputType")>]
        member _.InputType(state: Types.CustomServiceSettings, value: Map<Types.CustomServiceInputType, string>) =
            { state with InputType = Some value }

        [<CustomOperation("queryParameters")>]
        member _.QueryParameters(state: Types.CustomServiceSettings, value: Types.CustomServiceQueryParameter list) =
            { state with QueryParameters = Some value }

        [<CustomOperation("request")>]
        member _.Request(state: Types.CustomServiceSettings, value: Types.CustomRequestParams) =
            { state with Request = value }

        [<CustomOperation("response")>]
        member _.Response(state: Types.CustomServiceSettings, value: Types.CustomResponseParams) =
            { state with Response = value }

        [<CustomOperation("secretParameters")>]
        member _.SecretParameters(state: Types.CustomServiceSettings, value: Map<string, string>) =
            { state with SecretParameters = value }

        [<CustomOperation("url")>]
        member _.Url(state: Types.CustomServiceSettings, value: string) =
            { state with Url = Some value }

    let customServiceSettings = CustomServiceSettingsBuilder()

    type ElasticsearchServiceSettingsBuilder() =
        member _.Yield(_: unit) : Types.ElasticsearchServiceSettings =
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
        member _.AdaptiveAllocations(state: Types.ElasticsearchServiceSettings, value: Types.AdaptiveAllocations) =
            { state with AdaptiveAllocations = Some value }

        [<CustomOperation("deploymentId")>]
        member _.DeploymentId(state: Types.ElasticsearchServiceSettings, value: string) =
            { state with DeploymentId = Some value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: Types.ElasticsearchServiceSettings, value: string) =
            { state with ModelId = value }

        [<CustomOperation("numAllocations")>]
        member _.NumAllocations(state: Types.ElasticsearchServiceSettings, value: Types.Integer) =
            { state with NumAllocations = Some value }

        [<CustomOperation("numThreads")>]
        member _.NumThreads(state: Types.ElasticsearchServiceSettings, value: Types.Integer) =
            { state with NumThreads = value }

        [<CustomOperation("longDocumentStrategy")>]
        member _.LongDocumentStrategy(state: Types.ElasticsearchServiceSettings, value: string) =
            { state with LongDocumentStrategy = Some value }

        [<CustomOperation("maxChunksPerDoc")>]
        member _.MaxChunksPerDoc(state: Types.ElasticsearchServiceSettings, value: Types.Integer) =
            { state with MaxChunksPerDoc = Some value }

    let elasticsearchServiceSettings = ElasticsearchServiceSettingsBuilder()

    module EmbeddingInferenceResult =

        let embeddingsBytes (value: Types.DenseEmbeddingByteResult list) =
            Types.EmbeddingInferenceResult.EmbeddingsBytes value

        let embeddingsBits (value: Types.DenseEmbeddingByteResult list) =
            Types.EmbeddingInferenceResult.EmbeddingsBits value

        let embeddings (value: Types.DenseEmbeddingResult list) =
            Types.EmbeddingInferenceResult.Embeddings value

    type FireworksAIServiceSettingsBuilder() =
        member _.Yield(_: unit) : Types.FireworksAIServiceSettings =
            {
                ApiKey = Unchecked.defaultof<_>
                ModelId = Unchecked.defaultof<_>
                Url = None
                Dimensions = None
                Similarity = None
                RateLimit = None
            }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: Types.FireworksAIServiceSettings, value: string) =
            { state with ApiKey = value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: Types.FireworksAIServiceSettings, value: string) =
            { state with ModelId = value }

        [<CustomOperation("url")>]
        member _.Url(state: Types.FireworksAIServiceSettings, value: string) =
            { state with Url = Some value }

        [<CustomOperation("dimensions")>]
        member _.Dimensions(state: Types.FireworksAIServiceSettings, value: Types.Integer) =
            { state with Dimensions = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: Types.FireworksAIServiceSettings, value: Types.FireworksAISimilarityType) =
            { state with Similarity = Some value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: Types.FireworksAIServiceSettings, value: Types.RateLimitSetting) =
            { state with RateLimit = Some value }

    let fireworksAIServiceSettings = FireworksAIServiceSettingsBuilder()

    type FireworksAITaskSettingsBuilder() =
        member _.Yield(_: unit) : Types.FireworksAITaskSettings =
            {
                User = None
                Headers = None
            }

        [<CustomOperation("user")>]
        member _.User(state: Types.FireworksAITaskSettings, value: string) =
            { state with User = Some value }

        [<CustomOperation("headers")>]
        member _.Headers(state: Types.FireworksAITaskSettings, value: Map<string, string>) =
            { state with Headers = Some value }

    let fireworksAITaskSettings = FireworksAITaskSettingsBuilder()

    type GoogleVertexAIServiceSettingsBuilder() =
        member _.Yield(_: unit) : Types.GoogleVertexAIServiceSettings =
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
        member _.Provider(state: Types.GoogleVertexAIServiceSettings, value: Types.GoogleModelGardenProvider) =
            { state with Provider = Some value }

        [<CustomOperation("url")>]
        member _.Url(state: Types.GoogleVertexAIServiceSettings, value: string) =
            { state with Url = Some value }

        [<CustomOperation("streamingUrl")>]
        member _.StreamingUrl(state: Types.GoogleVertexAIServiceSettings, value: string) =
            { state with StreamingUrl = Some value }

        [<CustomOperation("location")>]
        member _.Location(state: Types.GoogleVertexAIServiceSettings, value: string) =
            { state with Location = Some value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: Types.GoogleVertexAIServiceSettings, value: string) =
            { state with ModelId = Some value }

        [<CustomOperation("projectId")>]
        member _.ProjectId(state: Types.GoogleVertexAIServiceSettings, value: string) =
            { state with ProjectId = Some value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: Types.GoogleVertexAIServiceSettings, value: Types.RateLimitSetting) =
            { state with RateLimit = Some value }

        [<CustomOperation("serviceAccountJson")>]
        member _.ServiceAccountJson(state: Types.GoogleVertexAIServiceSettings, value: string) =
            { state with ServiceAccountJson = value }

        [<CustomOperation("dimensions")>]
        member _.Dimensions(state: Types.GoogleVertexAIServiceSettings, value: Types.Integer) =
            { state with Dimensions = Some value }

        [<CustomOperation("maxBatchSize")>]
        member _.MaxBatchSize(state: Types.GoogleVertexAIServiceSettings, value: Types.Integer) =
            { state with MaxBatchSize = Some value }

    let googleVertexAIServiceSettings = GoogleVertexAIServiceSettingsBuilder()

    type GoogleVertexAITaskSettingsBuilder() =
        member _.Yield(_: unit) : Types.GoogleVertexAITaskSettings =
            {
                AutoTruncate = None
                TopN = None
                ThinkingConfig = None
                MaxTokens = None
            }

        [<CustomOperation("autoTruncate")>]
        member _.AutoTruncate(state: Types.GoogleVertexAITaskSettings, value: bool) =
            { state with AutoTruncate = Some value }

        [<CustomOperation("topN")>]
        member _.TopN(state: Types.GoogleVertexAITaskSettings, value: Types.Integer) =
            { state with TopN = Some value }

        [<CustomOperation("thinkingConfig")>]
        member _.ThinkingConfig(state: Types.GoogleVertexAITaskSettings, value: Types.ThinkingConfig) =
            { state with ThinkingConfig = Some value }

        [<CustomOperation("maxTokens")>]
        member _.MaxTokens(state: Types.GoogleVertexAITaskSettings, value: Types.Integer) =
            { state with MaxTokens = Some value }

    let googleVertexAITaskSettings = GoogleVertexAITaskSettingsBuilder()

    type GroqServiceSettingsBuilder() =
        member _.Yield(_: unit) : Types.GroqServiceSettings =
            {
                ModelId = Unchecked.defaultof<_>
                ApiKey = None
                RateLimit = None
            }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: Types.GroqServiceSettings, value: string) =
            { state with ModelId = value }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: Types.GroqServiceSettings, value: string) =
            { state with ApiKey = Some value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: Types.GroqServiceSettings, value: Types.RateLimitSetting) =
            { state with RateLimit = Some value }

    let groqServiceSettings = GroqServiceSettingsBuilder()

    type HuggingFaceServiceSettingsBuilder() =
        member _.Yield(_: unit) : Types.HuggingFaceServiceSettings =
            {
                ApiKey = Unchecked.defaultof<_>
                RateLimit = None
                Url = Unchecked.defaultof<_>
                ModelId = None
            }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: Types.HuggingFaceServiceSettings, value: string) =
            { state with ApiKey = value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: Types.HuggingFaceServiceSettings, value: Types.RateLimitSetting) =
            { state with RateLimit = Some value }

        [<CustomOperation("url")>]
        member _.Url(state: Types.HuggingFaceServiceSettings, value: string) =
            { state with Url = value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: Types.HuggingFaceServiceSettings, value: string) =
            { state with ModelId = Some value }

    let huggingFaceServiceSettings = HuggingFaceServiceSettingsBuilder()

    type HuggingFaceTaskSettingsBuilder() =
        member _.Yield(_: unit) : Types.HuggingFaceTaskSettings =
            {
                ReturnDocuments = None
                TopN = None
            }

        [<CustomOperation("returnDocuments")>]
        member _.ReturnDocuments(state: Types.HuggingFaceTaskSettings, value: bool) =
            { state with ReturnDocuments = Some value }

        [<CustomOperation("topN")>]
        member _.TopN(state: Types.HuggingFaceTaskSettings, value: Types.Integer) =
            { state with TopN = Some value }

    let huggingFaceTaskSettings = HuggingFaceTaskSettingsBuilder()

    type InferenceChunkingSettingsBuilder() =
        member _.Yield(_: unit) : Types.InferenceChunkingSettings =
            {
                MaxChunkSize = None
                Overlap = None
                SentenceOverlap = None
                SeparatorGroup = None
                Separators = None
                Strategy = None
            }

        [<CustomOperation("maxChunkSize")>]
        member _.MaxChunkSize(state: Types.InferenceChunkingSettings, value: Types.Integer) =
            { state with MaxChunkSize = Some value }

        [<CustomOperation("overlap")>]
        member _.Overlap(state: Types.InferenceChunkingSettings, value: Types.Integer) =
            { state with Overlap = Some value }

        [<CustomOperation("sentenceOverlap")>]
        member _.SentenceOverlap(state: Types.InferenceChunkingSettings, value: Types.Integer) =
            { state with SentenceOverlap = Some value }

        [<CustomOperation("separatorGroup")>]
        member _.SeparatorGroup(state: Types.InferenceChunkingSettings, value: string) =
            { state with SeparatorGroup = Some value }

        [<CustomOperation("separators")>]
        member _.Separators(state: Types.InferenceChunkingSettings, value: string list) =
            { state with Separators = Some value }

        [<CustomOperation("strategy")>]
        member _.Strategy(state: Types.InferenceChunkingSettings, value: string) =
            { state with Strategy = Some value }

    let inferenceChunkingSettings = InferenceChunkingSettingsBuilder()

    type InferenceEndpointBuilder() =
        member _.Yield(_: unit) : Types.InferenceEndpoint =
            {
                ChunkingSettings = None
                Service = Unchecked.defaultof<_>
                ServiceSettings = Unchecked.defaultof<_>
                TaskSettings = None
            }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: Types.InferenceEndpoint, value: Types.InferenceChunkingSettings) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("service")>]
        member _.Service(state: Types.InferenceEndpoint, value: string) =
            { state with Service = value }

        [<CustomOperation("serviceSettings")>]
        member _.ServiceSettings(state: Types.InferenceEndpoint, value: Types.ServiceSettings) =
            { state with ServiceSettings = value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: Types.InferenceEndpoint, value: Types.TaskSettings) =
            { state with TaskSettings = Some value }

    let inferenceEndpoint = InferenceEndpointBuilder()

    module InferenceResult =

        let embeddingsBytes (value: Types.DenseEmbeddingByteResult list) =
            Types.InferenceResult.EmbeddingsBytes value

        let embeddingsBits (value: Types.DenseEmbeddingByteResult list) =
            Types.InferenceResult.EmbeddingsBits value

        let embeddings (value: Types.DenseEmbeddingResult list) =
            Types.InferenceResult.Embeddings value

        let textEmbeddingBytes (value: Types.DenseEmbeddingByteResult list) =
            Types.InferenceResult.TextEmbeddingBytes value

        let textEmbeddingBits (value: Types.DenseEmbeddingByteResult list) =
            Types.InferenceResult.TextEmbeddingBits value

        let textEmbedding (value: Types.DenseEmbeddingResult list) =
            Types.InferenceResult.TextEmbedding value

        let sparseEmbedding (value: Types.SparseEmbeddingResult list) =
            Types.InferenceResult.SparseEmbedding value

        let completion (value: Types.CompletionResult list) =
            Types.InferenceResult.Completion value

        let rerank (value: Types.RankedDocument list) =
            Types.InferenceResult.Rerank value

    type JinaAIServiceSettingsBuilder() =
        member _.Yield(_: unit) : Types.JinaAIServiceSettings =
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
        member _.ApiKey(state: Types.JinaAIServiceSettings, value: string) =
            { state with ApiKey = value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: Types.JinaAIServiceSettings, value: string) =
            { state with ModelId = value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: Types.JinaAIServiceSettings, value: Types.RateLimitSetting) =
            { state with RateLimit = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: Types.JinaAIServiceSettings, value: Types.JinaAISimilarityType) =
            { state with Similarity = Some value }

        [<CustomOperation("dimensions")>]
        member _.Dimensions(state: Types.JinaAIServiceSettings, value: Types.Integer) =
            { state with Dimensions = Some value }

        [<CustomOperation("elementType")>]
        member _.ElementType(state: Types.JinaAIServiceSettings, value: Types.JinaAIElementType) =
            { state with ElementType = Some value }

        [<CustomOperation("multimodalModel")>]
        member _.MultimodalModel(state: Types.JinaAIServiceSettings, value: bool) =
            { state with MultimodalModel = Some value }

    let jinaAIServiceSettings = JinaAIServiceSettingsBuilder()

    type JinaAITaskSettingsBuilder() =
        member _.Yield(_: unit) : Types.JinaAITaskSettings =
            {
                ReturnDocuments = None
                InputType = None
                LateChunking = None
                TopN = None
            }

        [<CustomOperation("returnDocuments")>]
        member _.ReturnDocuments(state: Types.JinaAITaskSettings, value: bool) =
            { state with ReturnDocuments = Some value }

        [<CustomOperation("inputType")>]
        member _.InputType(state: Types.JinaAITaskSettings, value: Types.JinaAITextEmbeddingTask) =
            { state with InputType = Some value }

        [<CustomOperation("lateChunking")>]
        member _.LateChunking(state: Types.JinaAITaskSettings, value: bool) =
            { state with LateChunking = Some value }

        [<CustomOperation("topN")>]
        member _.TopN(state: Types.JinaAITaskSettings, value: Types.Integer) =
            { state with TopN = Some value }

    let jinaAITaskSettings = JinaAITaskSettingsBuilder()

    type LlamaServiceSettingsBuilder() =
        member _.Yield(_: unit) : Types.LlamaServiceSettings =
            {
                Url = Unchecked.defaultof<_>
                ModelId = Unchecked.defaultof<_>
                MaxInputTokens = None
                Similarity = None
                RateLimit = None
            }

        [<CustomOperation("url")>]
        member _.Url(state: Types.LlamaServiceSettings, value: string) =
            { state with Url = value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: Types.LlamaServiceSettings, value: string) =
            { state with ModelId = value }

        [<CustomOperation("maxInputTokens")>]
        member _.MaxInputTokens(state: Types.LlamaServiceSettings, value: Types.Integer) =
            { state with MaxInputTokens = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: Types.LlamaServiceSettings, value: Types.LlamaSimilarityType) =
            { state with Similarity = Some value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: Types.LlamaServiceSettings, value: Types.RateLimitSetting) =
            { state with RateLimit = Some value }

    let llamaServiceSettings = LlamaServiceSettingsBuilder()

    type MessageBuilder() =
        member _.Yield(_: unit) : Types.Message =
            {
                Content = None
                Role = Unchecked.defaultof<_>
                ToolCallId = None
                ToolCalls = None
                Reasoning = None
                ReasoningDetails = None
            }

        [<CustomOperation("content")>]
        member _.Content(state: Types.Message, value: Types.MessageContent) =
            { state with Content = Some value }

        [<CustomOperation("role")>]
        member _.Role(state: Types.Message, value: string) =
            { state with Role = value }

        [<CustomOperation("toolCallId")>]
        member _.ToolCallId(state: Types.Message, value: Types.Id) =
            { state with ToolCallId = Some value }

        [<CustomOperation("toolCalls")>]
        member _.ToolCalls(state: Types.Message, value: Types.ToolCall list) =
            { state with ToolCalls = Some value }

        [<CustomOperation("reasoning")>]
        member _.Reasoning(state: Types.Message, value: string) =
            { state with Reasoning = Some value }

        [<CustomOperation("reasoningDetails")>]
        member _.ReasoningDetails(state: Types.Message, value: Types.ReasoningDetail list) =
            { state with ReasoningDetails = Some value }

    let message = MessageBuilder()

    type MistralServiceSettingsBuilder() =
        member _.Yield(_: unit) : Types.MistralServiceSettings =
            {
                ApiKey = Unchecked.defaultof<_>
                MaxInputTokens = None
                Model = Unchecked.defaultof<_>
                RateLimit = None
            }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: Types.MistralServiceSettings, value: string) =
            { state with ApiKey = value }

        [<CustomOperation("maxInputTokens")>]
        member _.MaxInputTokens(state: Types.MistralServiceSettings, value: Types.Integer) =
            { state with MaxInputTokens = Some value }

        [<CustomOperation("model")>]
        member _.Model(state: Types.MistralServiceSettings, value: string) =
            { state with Model = value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: Types.MistralServiceSettings, value: Types.RateLimitSetting) =
            { state with RateLimit = Some value }

    let mistralServiceSettings = MistralServiceSettingsBuilder()

    type NvidiaServiceSettingsBuilder() =
        member _.Yield(_: unit) : Types.NvidiaServiceSettings =
            {
                ApiKey = Unchecked.defaultof<_>
                Url = None
                ModelId = Unchecked.defaultof<_>
                MaxInputTokens = None
                Similarity = None
                RateLimit = None
            }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: Types.NvidiaServiceSettings, value: string) =
            { state with ApiKey = value }

        [<CustomOperation("url")>]
        member _.Url(state: Types.NvidiaServiceSettings, value: string) =
            { state with Url = Some value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: Types.NvidiaServiceSettings, value: string) =
            { state with ModelId = value }

        [<CustomOperation("maxInputTokens")>]
        member _.MaxInputTokens(state: Types.NvidiaServiceSettings, value: Types.Integer) =
            { state with MaxInputTokens = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: Types.NvidiaServiceSettings, value: Types.NvidiaSimilarityType) =
            { state with Similarity = Some value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: Types.NvidiaServiceSettings, value: Types.RateLimitSetting) =
            { state with RateLimit = Some value }

    let nvidiaServiceSettings = NvidiaServiceSettingsBuilder()

    type NvidiaTaskSettingsBuilder() =
        member _.Yield(_: unit) : Types.NvidiaTaskSettings =
            {
                InputType = None
                Truncate = None
            }

        [<CustomOperation("inputType")>]
        member _.InputType(state: Types.NvidiaTaskSettings, value: Types.NvidiaInputType) =
            { state with InputType = Some value }

        [<CustomOperation("truncate")>]
        member _.Truncate(state: Types.NvidiaTaskSettings, value: Types.CohereTruncateType) =
            { state with Truncate = Some value }

    let nvidiaTaskSettings = NvidiaTaskSettingsBuilder()

    type OpenAIServiceSettingsBuilder() =
        member _.Yield(_: unit) : Types.OpenAIServiceSettings =
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
        member _.ApiKey(state: Types.OpenAIServiceSettings, value: string) =
            { state with ApiKey = value }

        [<CustomOperation("dimensions")>]
        member _.Dimensions(state: Types.OpenAIServiceSettings, value: Types.Integer) =
            { state with Dimensions = Some value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: Types.OpenAIServiceSettings, value: string) =
            { state with ModelId = value }

        [<CustomOperation("organizationId")>]
        member _.OrganizationId(state: Types.OpenAIServiceSettings, value: string) =
            { state with OrganizationId = Some value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: Types.OpenAIServiceSettings, value: Types.RateLimitSetting) =
            { state with RateLimit = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: Types.OpenAIServiceSettings, value: Types.OpenAISimilarityType) =
            { state with Similarity = Some value }

        [<CustomOperation("url")>]
        member _.Url(state: Types.OpenAIServiceSettings, value: string) =
            { state with Url = Some value }

    let openAIServiceSettings = OpenAIServiceSettingsBuilder()

    type OpenAITaskSettingsBuilder() =
        member _.Yield(_: unit) : Types.OpenAITaskSettings =
            {
                User = None
                Headers = None
            }

        [<CustomOperation("user")>]
        member _.User(state: Types.OpenAITaskSettings, value: string) =
            { state with User = Some value }

        [<CustomOperation("headers")>]
        member _.Headers(state: Types.OpenAITaskSettings, value: Map<string, string>) =
            { state with Headers = Some value }

    let openAITaskSettings = OpenAITaskSettingsBuilder()

    type OpenShiftAiServiceSettingsBuilder() =
        member _.Yield(_: unit) : Types.OpenShiftAiServiceSettings =
            {
                ApiKey = Unchecked.defaultof<_>
                Url = Unchecked.defaultof<_>
                ModelId = None
                MaxInputTokens = None
                Similarity = None
                RateLimit = None
            }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: Types.OpenShiftAiServiceSettings, value: string) =
            { state with ApiKey = value }

        [<CustomOperation("url")>]
        member _.Url(state: Types.OpenShiftAiServiceSettings, value: string) =
            { state with Url = value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: Types.OpenShiftAiServiceSettings, value: string) =
            { state with ModelId = Some value }

        [<CustomOperation("maxInputTokens")>]
        member _.MaxInputTokens(state: Types.OpenShiftAiServiceSettings, value: Types.Integer) =
            { state with MaxInputTokens = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: Types.OpenShiftAiServiceSettings, value: Types.OpenShiftAiSimilarityType) =
            { state with Similarity = Some value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: Types.OpenShiftAiServiceSettings, value: Types.RateLimitSetting) =
            { state with RateLimit = Some value }

    let openShiftAiServiceSettings = OpenShiftAiServiceSettingsBuilder()

    type OpenShiftAiTaskSettingsBuilder() =
        member _.Yield(_: unit) : Types.OpenShiftAiTaskSettings =
            {
                ReturnDocuments = None
                TopN = None
            }

        [<CustomOperation("returnDocuments")>]
        member _.ReturnDocuments(state: Types.OpenShiftAiTaskSettings, value: bool) =
            { state with ReturnDocuments = Some value }

        [<CustomOperation("topN")>]
        member _.TopN(state: Types.OpenShiftAiTaskSettings, value: Types.Integer) =
            { state with TopN = Some value }

    let openShiftAiTaskSettings = OpenShiftAiTaskSettingsBuilder()

    type ReasoningBuilder() =
        member _.Yield(_: unit) : Types.Reasoning =
            {
                Effort = None
                Enabled = None
                Exclude = None
                Summary = None
            }

        [<CustomOperation("effort")>]
        member _.Effort(state: Types.Reasoning, value: Types.ReasoningEffort) =
            { state with Effort = Some value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.Reasoning, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("exclude")>]
        member _.Exclude(state: Types.Reasoning, value: bool) =
            { state with Exclude = Some value }

        [<CustomOperation("summary")>]
        member _.Summary(state: Types.Reasoning, value: Types.ReasoningSummary) =
            { state with Summary = Some value }

    let reasoning = ReasoningBuilder()

    type RequestChatCompletionBuilder() =
        member _.Yield(_: unit) : Types.RequestChatCompletion =
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
        member _.Messages(state: Types.RequestChatCompletion, value: Types.Message list) =
            { state with Messages = value }

        [<CustomOperation("model")>]
        member _.Model(state: Types.RequestChatCompletion, value: string) =
            { state with Model = Some value }

        [<CustomOperation("maxCompletionTokens")>]
        member _.MaxCompletionTokens(state: Types.RequestChatCompletion, value: Types.Long) =
            { state with MaxCompletionTokens = Some value }

        [<CustomOperation("reasoning")>]
        member _.Reasoning(state: Types.RequestChatCompletion, value: Types.Reasoning) =
            { state with Reasoning = Some value }

        [<CustomOperation("stop")>]
        member _.Stop(state: Types.RequestChatCompletion, value: string list) =
            { state with Stop = Some value }

        [<CustomOperation("temperature")>]
        member _.Temperature(state: Types.RequestChatCompletion, value: Types.Float) =
            { state with Temperature = Some value }

        [<CustomOperation("toolChoice")>]
        member _.ToolChoice(state: Types.RequestChatCompletion, value: Types.CompletionToolType) =
            { state with ToolChoice = Some value }

        [<CustomOperation("tools")>]
        member _.Tools(state: Types.RequestChatCompletion, value: Types.CompletionTool list) =
            { state with Tools = Some value }

        [<CustomOperation("topP")>]
        member _.TopP(state: Types.RequestChatCompletion, value: Types.Float) =
            { state with TopP = Some value }

    let requestChatCompletion = RequestChatCompletionBuilder()

    type RequestEmbeddingBuilder() =
        member _.Yield(_: unit) : Types.RequestEmbedding =
            {
                Input = Unchecked.defaultof<_>
                InputType = None
                TaskSettings = None
            }

        [<CustomOperation("input")>]
        member _.Input(state: Types.RequestEmbedding, value: Types.EmbeddingInput) =
            { state with Input = value }

        [<CustomOperation("inputType")>]
        member _.InputType(state: Types.RequestEmbedding, value: string) =
            { state with InputType = Some value }

        [<CustomOperation("taskSettings")>]
        member _.TaskSettings(state: Types.RequestEmbedding, value: Types.TaskSettings) =
            { state with TaskSettings = Some value }

    let requestEmbedding = RequestEmbeddingBuilder()

    module TextEmbeddingInferenceResult =

        let textEmbeddingBytes (value: Types.DenseEmbeddingByteResult list) =
            Types.TextEmbeddingInferenceResult.TextEmbeddingBytes value

        let textEmbeddingBits (value: Types.DenseEmbeddingByteResult list) =
            Types.TextEmbeddingInferenceResult.TextEmbeddingBits value

        let textEmbedding (value: Types.DenseEmbeddingResult list) =
            Types.TextEmbeddingInferenceResult.TextEmbedding value

    type TextReasoningDetailBuilder() =
        member _.Yield(_: unit) : Types.TextReasoningDetail =
            {
                Type = Unchecked.defaultof<_>
                Signature = None
                Text = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.TextReasoningDetail, value: string) =
            { state with Type = value }

        [<CustomOperation("signature")>]
        member _.Signature(state: Types.TextReasoningDetail, value: string) =
            { state with Signature = Some value }

        [<CustomOperation("text")>]
        member _.Text(state: Types.TextReasoningDetail, value: string) =
            { state with Text = Some value }

    let textReasoningDetail = TextReasoningDetailBuilder()

    type VoyageAIServiceSettingsBuilder() =
        member _.Yield(_: unit) : Types.VoyageAIServiceSettings =
            {
                Dimensions = None
                ModelId = Unchecked.defaultof<_>
                RateLimit = None
                EmbeddingType = None
            }

        [<CustomOperation("dimensions")>]
        member _.Dimensions(state: Types.VoyageAIServiceSettings, value: Types.Integer) =
            { state with Dimensions = Some value }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: Types.VoyageAIServiceSettings, value: string) =
            { state with ModelId = value }

        [<CustomOperation("rateLimit")>]
        member _.RateLimit(state: Types.VoyageAIServiceSettings, value: Types.RateLimitSetting) =
            { state with RateLimit = Some value }

        [<CustomOperation("embeddingType")>]
        member _.EmbeddingType(state: Types.VoyageAIServiceSettings, value: Types.Float) =
            { state with EmbeddingType = Some value }

    let voyageAIServiceSettings = VoyageAIServiceSettingsBuilder()

    type VoyageAITaskSettingsBuilder() =
        member _.Yield(_: unit) : Types.VoyageAITaskSettings =
            {
                InputType = None
                ReturnDocuments = None
                TopK = None
                Truncation = None
            }

        [<CustomOperation("inputType")>]
        member _.InputType(state: Types.VoyageAITaskSettings, value: string) =
            { state with InputType = Some value }

        [<CustomOperation("returnDocuments")>]
        member _.ReturnDocuments(state: Types.VoyageAITaskSettings, value: bool) =
            { state with ReturnDocuments = Some value }

        [<CustomOperation("topK")>]
        member _.TopK(state: Types.VoyageAITaskSettings, value: Types.Integer) =
            { state with TopK = Some value }

        [<CustomOperation("truncation")>]
        member _.Truncation(state: Types.VoyageAITaskSettings, value: bool) =
            { state with Truncation = Some value }

    let voyageAITaskSettings = VoyageAITaskSettingsBuilder()


// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module MlTrainedModelOperations =

    type MlClearTrainedModelDeploymentCacheRequest = {
        [<JsonPropertyName("model_id")>]
        ModelId: Id
    } with
        static member ToRequest(request: MlClearTrainedModelDeploymentCacheRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{request.ModelId}/deployment/cache/_clear"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module MlClearTrainedModelDeploymentCacheRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlClearTrainedModelDeploymentCacheRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlClearTrainedModelDeploymentCacheRequest.ToRequest request

    type MlClearTrainedModelDeploymentCacheRequestBuilder() =
        member _.Yield(_: unit) : MlClearTrainedModelDeploymentCacheRequest =
            {
                MlClearTrainedModelDeploymentCacheRequest.ModelId = Unchecked.defaultof<Id>
            } : MlClearTrainedModelDeploymentCacheRequest

        [<CustomOperation("model_id")>]
        member _.ModelId(state: MlClearTrainedModelDeploymentCacheRequest, value: Id) =
            { state with MlClearTrainedModelDeploymentCacheRequest.ModelId = value } : MlClearTrainedModelDeploymentCacheRequest

    let mlClearTrainedModelDeploymentCacheRequest = MlClearTrainedModelDeploymentCacheRequestBuilder()

    type MlClearTrainedModelDeploymentCacheResponse = {
        [<JsonPropertyName("cleared")>]
        Cleared: bool
    }

    type MlGetTrainedModelsRequest = {
        [<JsonPropertyName("model_id")>]
        ModelId: Ids
        [<JsonPropertyName("allow_no_match")>]
        AllowNoMatch: bool option
        [<JsonPropertyName("decompress_definition")>]
        DecompressDefinition: bool option
        [<JsonPropertyName("exclude_generated")>]
        ExcludeGenerated: bool option
        [<JsonPropertyName("from")>]
        From: float option
        [<JsonPropertyName("include")>]
        Include: TypesInclude option
        [<JsonPropertyName("size")>]
        Size: float option
        [<JsonPropertyName("tags")>]
        Tags: System.Text.Json.JsonElement option
    } with
        static member ToRequest(request: MlGetTrainedModelsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{request.ModelId}"
                let queryParams =
                    [
                        request.AllowNoMatch |> Option.map (fun v -> "allow_no_match", string v)
                        request.DecompressDefinition |> Option.map (fun v -> "decompress_definition", string v)
                        request.ExcludeGenerated |> Option.map (fun v -> "exclude_generated", string v)
                        request.From |> Option.map (fun v -> "from", string v)
                        request.Include |> Option.map (fun v -> "include", string v)
                        request.Size |> Option.map (fun v -> "size", string v)
                        request.Tags |> Option.map (fun v -> "tags", string v)
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

    module MlGetTrainedModelsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlGetTrainedModelsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlGetTrainedModelsRequest.ToRequest request

    type MlGetTrainedModelsRequestBuilder() =
        member _.Yield(_: unit) : MlGetTrainedModelsRequest =
            {
                MlGetTrainedModelsRequest.ModelId = Unchecked.defaultof<Ids>
                MlGetTrainedModelsRequest.AllowNoMatch = Option.None
                MlGetTrainedModelsRequest.DecompressDefinition = Option.None
                MlGetTrainedModelsRequest.ExcludeGenerated = Option.None
                MlGetTrainedModelsRequest.From = Option.None
                MlGetTrainedModelsRequest.Include = Option.None
                MlGetTrainedModelsRequest.Size = Option.None
                MlGetTrainedModelsRequest.Tags = Option.None
            } : MlGetTrainedModelsRequest

        [<CustomOperation("model_id")>]
        member _.ModelId(state: MlGetTrainedModelsRequest, value: Ids) =
            { state with MlGetTrainedModelsRequest.ModelId = value } : MlGetTrainedModelsRequest

        [<CustomOperation("allow_no_match")>]
        member _.AllowNoMatch(state: MlGetTrainedModelsRequest, value: bool) =
            { state with MlGetTrainedModelsRequest.AllowNoMatch = Option.Some value } : MlGetTrainedModelsRequest

        [<CustomOperation("decompress_definition")>]
        member _.DecompressDefinition(state: MlGetTrainedModelsRequest, value: bool) =
            { state with MlGetTrainedModelsRequest.DecompressDefinition = Option.Some value } : MlGetTrainedModelsRequest

        [<CustomOperation("exclude_generated")>]
        member _.ExcludeGenerated(state: MlGetTrainedModelsRequest, value: bool) =
            { state with MlGetTrainedModelsRequest.ExcludeGenerated = Option.Some value } : MlGetTrainedModelsRequest

        [<CustomOperation("from")>]
        member _.From(state: MlGetTrainedModelsRequest, value: float) =
            { state with MlGetTrainedModelsRequest.From = Option.Some value } : MlGetTrainedModelsRequest

        [<CustomOperation("include")>]
        member _.Include(state: MlGetTrainedModelsRequest, value: TypesInclude) =
            { state with MlGetTrainedModelsRequest.Include = Option.Some value } : MlGetTrainedModelsRequest

        [<CustomOperation("size")>]
        member _.Size(state: MlGetTrainedModelsRequest, value: float) =
            { state with MlGetTrainedModelsRequest.Size = Option.Some value } : MlGetTrainedModelsRequest

        [<CustomOperation("tags")>]
        member _.Tags(state: MlGetTrainedModelsRequest, value: System.Text.Json.JsonElement) =
            { state with MlGetTrainedModelsRequest.Tags = Option.Some value } : MlGetTrainedModelsRequest

    let mlGetTrainedModelsRequest = MlGetTrainedModelsRequestBuilder()

    type MlPutTrainedModelRequest = {
        [<JsonPropertyName("model_id")>]
        ModelId: Id
        [<JsonPropertyName("defer_definition_decompression")>]
        DeferDefinitionDecompression: bool option
        [<JsonPropertyName("wait_for_completion")>]
        WaitForCompletion: bool option
        [<JsonPropertyName("compressed_definition")>]
        CompressedDefinition: string option
        [<JsonPropertyName("definition")>]
        Definition: PutTrainedModelDefinition option
        [<JsonPropertyName("description")>]
        Description: string option
        [<JsonPropertyName("inference_config")>]
        InferenceConfig: TypesInferenceConfigCreateContainer option
        [<JsonPropertyName("input")>]
        Input: PutTrainedModelInput option
        [<JsonPropertyName("metadata")>]
        Metadata: obj option
        [<JsonPropertyName("model_type")>]
        ModelType: TypesTrainedModelType option
        [<JsonPropertyName("model_size_bytes")>]
        ModelSizeBytes: float option
        [<JsonPropertyName("platform_architecture")>]
        PlatformArchitecture: string option
        [<JsonPropertyName("tags")>]
        Tags: string array option
        [<JsonPropertyName("prefix_strings")>]
        PrefixStrings: TypesTrainedModelPrefixStrings option
    } with
        static member ToRequest(request: MlPutTrainedModelRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{request.ModelId}"
                let queryParams =
                    [
                        request.DeferDefinitionDecompression |> Option.map (fun v -> "defer_definition_decompression", string v)
                        request.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", string v)
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

    module MlPutTrainedModelRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlPutTrainedModelRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlPutTrainedModelRequest.ToRequest request

    type MlPutTrainedModelRequestBuilder() =
        member _.Yield(_: unit) : MlPutTrainedModelRequest =
            {
                MlPutTrainedModelRequest.ModelId = Unchecked.defaultof<Id>
                MlPutTrainedModelRequest.DeferDefinitionDecompression = Option.None
                MlPutTrainedModelRequest.WaitForCompletion = Option.None
                MlPutTrainedModelRequest.CompressedDefinition = Option.None
                MlPutTrainedModelRequest.Definition = Option.None
                MlPutTrainedModelRequest.Description = Option.None
                MlPutTrainedModelRequest.InferenceConfig = Option.None
                MlPutTrainedModelRequest.Input = Option.None
                MlPutTrainedModelRequest.Metadata = Option.None
                MlPutTrainedModelRequest.ModelType = Option.None
                MlPutTrainedModelRequest.ModelSizeBytes = Option.None
                MlPutTrainedModelRequest.PlatformArchitecture = Option.None
                MlPutTrainedModelRequest.Tags = Option.None
                MlPutTrainedModelRequest.PrefixStrings = Option.None
            } : MlPutTrainedModelRequest

        [<CustomOperation("model_id")>]
        member _.ModelId(state: MlPutTrainedModelRequest, value: Id) =
            { state with MlPutTrainedModelRequest.ModelId = value } : MlPutTrainedModelRequest

        [<CustomOperation("defer_definition_decompression")>]
        member _.DeferDefinitionDecompression(state: MlPutTrainedModelRequest, value: bool) =
            { state with MlPutTrainedModelRequest.DeferDefinitionDecompression = Option.Some value } : MlPutTrainedModelRequest

        [<CustomOperation("wait_for_completion")>]
        member _.WaitForCompletion(state: MlPutTrainedModelRequest, value: bool) =
            { state with MlPutTrainedModelRequest.WaitForCompletion = Option.Some value } : MlPutTrainedModelRequest

        [<CustomOperation("compressed_definition")>]
        member _.CompressedDefinition(state: MlPutTrainedModelRequest, value: string) =
            { state with MlPutTrainedModelRequest.CompressedDefinition = Option.Some value } : MlPutTrainedModelRequest

        [<CustomOperation("definition")>]
        member _.Definition(state: MlPutTrainedModelRequest, value: PutTrainedModelDefinition) =
            { state with MlPutTrainedModelRequest.Definition = Option.Some value } : MlPutTrainedModelRequest

        [<CustomOperation("description")>]
        member _.Description(state: MlPutTrainedModelRequest, value: string) =
            { state with MlPutTrainedModelRequest.Description = Option.Some value } : MlPutTrainedModelRequest

        [<CustomOperation("inference_config")>]
        member _.InferenceConfig(state: MlPutTrainedModelRequest, value: TypesInferenceConfigCreateContainer) =
            { state with MlPutTrainedModelRequest.InferenceConfig = Option.Some value } : MlPutTrainedModelRequest

        [<CustomOperation("input")>]
        member _.Input(state: MlPutTrainedModelRequest, value: PutTrainedModelInput) =
            { state with MlPutTrainedModelRequest.Input = Option.Some value } : MlPutTrainedModelRequest

        [<CustomOperation("metadata")>]
        member _.Metadata(state: MlPutTrainedModelRequest, value: obj) =
            { state with MlPutTrainedModelRequest.Metadata = Option.Some value } : MlPutTrainedModelRequest

        [<CustomOperation("model_type")>]
        member _.ModelType(state: MlPutTrainedModelRequest, value: TypesTrainedModelType) =
            { state with MlPutTrainedModelRequest.ModelType = Option.Some value } : MlPutTrainedModelRequest

        [<CustomOperation("model_size_bytes")>]
        member _.ModelSizeBytes(state: MlPutTrainedModelRequest, value: float) =
            { state with MlPutTrainedModelRequest.ModelSizeBytes = Option.Some value } : MlPutTrainedModelRequest

        [<CustomOperation("platform_architecture")>]
        member _.PlatformArchitecture(state: MlPutTrainedModelRequest, value: string) =
            { state with MlPutTrainedModelRequest.PlatformArchitecture = Option.Some value } : MlPutTrainedModelRequest

        [<CustomOperation("tags")>]
        member _.Tags(state: MlPutTrainedModelRequest, value: string array) =
            { state with MlPutTrainedModelRequest.Tags = Option.Some value } : MlPutTrainedModelRequest

        [<CustomOperation("prefix_strings")>]
        member _.PrefixStrings(state: MlPutTrainedModelRequest, value: TypesTrainedModelPrefixStrings) =
            { state with MlPutTrainedModelRequest.PrefixStrings = Option.Some value } : MlPutTrainedModelRequest

    let mlPutTrainedModelRequest = MlPutTrainedModelRequestBuilder()

    type MlPutTrainedModelResponse = TypesTrainedModelConfig

    type MlDeleteTrainedModelRequest = {
        [<JsonPropertyName("model_id")>]
        ModelId: Id
        [<JsonPropertyName("force")>]
        Force: bool option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
    } with
        static member ToRequest(request: MlDeleteTrainedModelRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{request.ModelId}"
                let queryParams =
                    [
                        request.Force |> Option.map (fun v -> "force", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
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

    module MlDeleteTrainedModelRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlDeleteTrainedModelRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlDeleteTrainedModelRequest.ToRequest request

    type MlDeleteTrainedModelRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteTrainedModelRequest =
            {
                MlDeleteTrainedModelRequest.ModelId = Unchecked.defaultof<Id>
                MlDeleteTrainedModelRequest.Force = Option.None
                MlDeleteTrainedModelRequest.Timeout = Option.None
            } : MlDeleteTrainedModelRequest

        [<CustomOperation("model_id")>]
        member _.ModelId(state: MlDeleteTrainedModelRequest, value: Id) =
            { state with MlDeleteTrainedModelRequest.ModelId = value } : MlDeleteTrainedModelRequest

        [<CustomOperation("force")>]
        member _.Force(state: MlDeleteTrainedModelRequest, value: bool) =
            { state with MlDeleteTrainedModelRequest.Force = Option.Some value } : MlDeleteTrainedModelRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlDeleteTrainedModelRequest, value: Duration) =
            { state with MlDeleteTrainedModelRequest.Timeout = Option.Some value } : MlDeleteTrainedModelRequest

    let mlDeleteTrainedModelRequest = MlDeleteTrainedModelRequestBuilder()

    type MlDeleteTrainedModelResponse = AcknowledgedResponseBase

    type MlPutTrainedModelAliasRequest = {
        [<JsonPropertyName("model_id")>]
        ModelId: Id
        [<JsonPropertyName("model_alias")>]
        ModelAlias: Name
        [<JsonPropertyName("reassign")>]
        Reassign: bool option
    } with
        static member ToRequest(request: MlPutTrainedModelAliasRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{request.ModelId}/model_aliases/{request.ModelAlias}"
                let queryParams =
                    [
                        request.Reassign |> Option.map (fun v -> "reassign", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Result.Ok
            with ex -> Result.Error ex

    module MlPutTrainedModelAliasRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlPutTrainedModelAliasRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlPutTrainedModelAliasRequest.ToRequest request

    type MlPutTrainedModelAliasRequestBuilder() =
        member _.Yield(_: unit) : MlPutTrainedModelAliasRequest =
            {
                MlPutTrainedModelAliasRequest.ModelId = Unchecked.defaultof<Id>
                MlPutTrainedModelAliasRequest.ModelAlias = Unchecked.defaultof<Name>
                MlPutTrainedModelAliasRequest.Reassign = Option.None
            } : MlPutTrainedModelAliasRequest

        [<CustomOperation("model_id")>]
        member _.ModelId(state: MlPutTrainedModelAliasRequest, value: Id) =
            { state with MlPutTrainedModelAliasRequest.ModelId = value } : MlPutTrainedModelAliasRequest

        [<CustomOperation("model_alias")>]
        member _.ModelAlias(state: MlPutTrainedModelAliasRequest, value: Name) =
            { state with MlPutTrainedModelAliasRequest.ModelAlias = value } : MlPutTrainedModelAliasRequest

        [<CustomOperation("reassign")>]
        member _.Reassign(state: MlPutTrainedModelAliasRequest, value: bool) =
            { state with MlPutTrainedModelAliasRequest.Reassign = Option.Some value } : MlPutTrainedModelAliasRequest

    let mlPutTrainedModelAliasRequest = MlPutTrainedModelAliasRequestBuilder()

    type MlPutTrainedModelAliasResponse = AcknowledgedResponseBase

    type MlDeleteTrainedModelAliasRequest = {
        [<JsonPropertyName("model_id")>]
        ModelId: Id
        [<JsonPropertyName("model_alias")>]
        ModelAlias: Name
    } with
        static member ToRequest(request: MlDeleteTrainedModelAliasRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{request.ModelId}/model_aliases/{request.ModelAlias}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module MlDeleteTrainedModelAliasRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlDeleteTrainedModelAliasRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlDeleteTrainedModelAliasRequest.ToRequest request

    type MlDeleteTrainedModelAliasRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteTrainedModelAliasRequest =
            {
                MlDeleteTrainedModelAliasRequest.ModelId = Unchecked.defaultof<Id>
                MlDeleteTrainedModelAliasRequest.ModelAlias = Unchecked.defaultof<Name>
            } : MlDeleteTrainedModelAliasRequest

        [<CustomOperation("model_id")>]
        member _.ModelId(state: MlDeleteTrainedModelAliasRequest, value: Id) =
            { state with MlDeleteTrainedModelAliasRequest.ModelId = value } : MlDeleteTrainedModelAliasRequest

        [<CustomOperation("model_alias")>]
        member _.ModelAlias(state: MlDeleteTrainedModelAliasRequest, value: Name) =
            { state with MlDeleteTrainedModelAliasRequest.ModelAlias = value } : MlDeleteTrainedModelAliasRequest

    let mlDeleteTrainedModelAliasRequest = MlDeleteTrainedModelAliasRequestBuilder()

    type MlDeleteTrainedModelAliasResponse = AcknowledgedResponseBase

    type MlGetTrainedModelsStatsRequest = {
        [<JsonPropertyName("model_id")>]
        ModelId: Ids
        [<JsonPropertyName("allow_no_match")>]
        AllowNoMatch: bool option
        [<JsonPropertyName("from")>]
        From: float option
        [<JsonPropertyName("size")>]
        Size: float option
    } with
        static member ToRequest(request: MlGetTrainedModelsStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{request.ModelId}/_stats"
                let queryParams =
                    [
                        request.AllowNoMatch |> Option.map (fun v -> "allow_no_match", string v)
                        request.From |> Option.map (fun v -> "from", string v)
                        request.Size |> Option.map (fun v -> "size", string v)
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

    module MlGetTrainedModelsStatsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlGetTrainedModelsStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlGetTrainedModelsStatsRequest.ToRequest request

    type MlGetTrainedModelsStatsRequestBuilder() =
        member _.Yield(_: unit) : MlGetTrainedModelsStatsRequest =
            {
                MlGetTrainedModelsStatsRequest.ModelId = Unchecked.defaultof<Ids>
                MlGetTrainedModelsStatsRequest.AllowNoMatch = Option.None
                MlGetTrainedModelsStatsRequest.From = Option.None
                MlGetTrainedModelsStatsRequest.Size = Option.None
            } : MlGetTrainedModelsStatsRequest

        [<CustomOperation("model_id")>]
        member _.ModelId(state: MlGetTrainedModelsStatsRequest, value: Ids) =
            { state with MlGetTrainedModelsStatsRequest.ModelId = value } : MlGetTrainedModelsStatsRequest

        [<CustomOperation("allow_no_match")>]
        member _.AllowNoMatch(state: MlGetTrainedModelsStatsRequest, value: bool) =
            { state with MlGetTrainedModelsStatsRequest.AllowNoMatch = Option.Some value } : MlGetTrainedModelsStatsRequest

        [<CustomOperation("from")>]
        member _.From(state: MlGetTrainedModelsStatsRequest, value: float) =
            { state with MlGetTrainedModelsStatsRequest.From = Option.Some value } : MlGetTrainedModelsStatsRequest

        [<CustomOperation("size")>]
        member _.Size(state: MlGetTrainedModelsStatsRequest, value: float) =
            { state with MlGetTrainedModelsStatsRequest.Size = Option.Some value } : MlGetTrainedModelsStatsRequest

    let mlGetTrainedModelsStatsRequest = MlGetTrainedModelsStatsRequestBuilder()

    type MlInferTrainedModelRequest = {
        [<JsonPropertyName("model_id")>]
        ModelId: Id
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
        [<JsonPropertyName("docs")>]
        Docs: Map<string, obj> array
        [<JsonPropertyName("inference_config")>]
        InferenceConfig: TypesInferenceConfigUpdateContainer option
    } with
        static member ToRequest(request: MlInferTrainedModelRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{request.ModelId}/_infer"
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

    module MlInferTrainedModelRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlInferTrainedModelRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlInferTrainedModelRequest.ToRequest request

    type MlInferTrainedModelRequestBuilder() =
        member _.Yield(_: unit) : MlInferTrainedModelRequest =
            {
                MlInferTrainedModelRequest.ModelId = Unchecked.defaultof<Id>
                MlInferTrainedModelRequest.Timeout = Option.None
                MlInferTrainedModelRequest.Docs = [||]
                MlInferTrainedModelRequest.InferenceConfig = Option.None
            } : MlInferTrainedModelRequest

        [<CustomOperation("model_id")>]
        member _.ModelId(state: MlInferTrainedModelRequest, value: Id) =
            { state with MlInferTrainedModelRequest.ModelId = value } : MlInferTrainedModelRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlInferTrainedModelRequest, value: Duration) =
            { state with MlInferTrainedModelRequest.Timeout = Option.Some value } : MlInferTrainedModelRequest

        [<CustomOperation("docs")>]
        member _.Docs(state: MlInferTrainedModelRequest, value: Map<string, obj> array) =
            { state with MlInferTrainedModelRequest.Docs = value } : MlInferTrainedModelRequest

        [<CustomOperation("inference_config")>]
        member _.InferenceConfig(state: MlInferTrainedModelRequest, value: TypesInferenceConfigUpdateContainer) =
            { state with MlInferTrainedModelRequest.InferenceConfig = Option.Some value } : MlInferTrainedModelRequest

    let mlInferTrainedModelRequest = MlInferTrainedModelRequestBuilder()

    type MlInferTrainedModelResponse = {
        [<JsonPropertyName("inference_results")>]
        InferenceResults: TypesInferenceResponseResult array
    }

    type MlPutTrainedModelDefinitionPartRequest = {
        [<JsonPropertyName("model_id")>]
        ModelId: Id
        [<JsonPropertyName("part")>]
        Part: float
        [<JsonPropertyName("definition")>]
        Definition: string
        [<JsonPropertyName("total_definition_length")>]
        TotalDefinitionLength: float
        [<JsonPropertyName("total_parts")>]
        TotalParts: float
    } with
        static member ToRequest(request: MlPutTrainedModelDefinitionPartRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{request.ModelId}/definition/{request.Part}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module MlPutTrainedModelDefinitionPartRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlPutTrainedModelDefinitionPartRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlPutTrainedModelDefinitionPartRequest.ToRequest request

    type MlPutTrainedModelDefinitionPartRequestBuilder() =
        member _.Yield(_: unit) : MlPutTrainedModelDefinitionPartRequest =
            {
                MlPutTrainedModelDefinitionPartRequest.ModelId = Unchecked.defaultof<Id>
                MlPutTrainedModelDefinitionPartRequest.Part = 0.0
                MlPutTrainedModelDefinitionPartRequest.Definition = String.Empty
                MlPutTrainedModelDefinitionPartRequest.TotalDefinitionLength = 0.0
                MlPutTrainedModelDefinitionPartRequest.TotalParts = 0.0
            } : MlPutTrainedModelDefinitionPartRequest

        [<CustomOperation("model_id")>]
        member _.ModelId(state: MlPutTrainedModelDefinitionPartRequest, value: Id) =
            { state with MlPutTrainedModelDefinitionPartRequest.ModelId = value } : MlPutTrainedModelDefinitionPartRequest

        [<CustomOperation("part")>]
        member _.Part(state: MlPutTrainedModelDefinitionPartRequest, value: float) =
            { state with MlPutTrainedModelDefinitionPartRequest.Part = value } : MlPutTrainedModelDefinitionPartRequest

        [<CustomOperation("definition")>]
        member _.Definition(state: MlPutTrainedModelDefinitionPartRequest, value: string) =
            { state with MlPutTrainedModelDefinitionPartRequest.Definition = value } : MlPutTrainedModelDefinitionPartRequest

        [<CustomOperation("total_definition_length")>]
        member _.TotalDefinitionLength(state: MlPutTrainedModelDefinitionPartRequest, value: float) =
            { state with MlPutTrainedModelDefinitionPartRequest.TotalDefinitionLength = value } : MlPutTrainedModelDefinitionPartRequest

        [<CustomOperation("total_parts")>]
        member _.TotalParts(state: MlPutTrainedModelDefinitionPartRequest, value: float) =
            { state with MlPutTrainedModelDefinitionPartRequest.TotalParts = value } : MlPutTrainedModelDefinitionPartRequest

    let mlPutTrainedModelDefinitionPartRequest = MlPutTrainedModelDefinitionPartRequestBuilder()

    type MlPutTrainedModelDefinitionPartResponse = AcknowledgedResponseBase

    type MlPutTrainedModelVocabularyRequest = {
        [<JsonPropertyName("model_id")>]
        ModelId: Id
        [<JsonPropertyName("vocabulary")>]
        Vocabulary: string array
        [<JsonPropertyName("merges")>]
        Merges: string array option
        [<JsonPropertyName("scores")>]
        Scores: float array option
    } with
        static member ToRequest(request: MlPutTrainedModelVocabularyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{request.ModelId}/vocabulary"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module MlPutTrainedModelVocabularyRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlPutTrainedModelVocabularyRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlPutTrainedModelVocabularyRequest.ToRequest request

    type MlPutTrainedModelVocabularyRequestBuilder() =
        member _.Yield(_: unit) : MlPutTrainedModelVocabularyRequest =
            {
                MlPutTrainedModelVocabularyRequest.ModelId = Unchecked.defaultof<Id>
                MlPutTrainedModelVocabularyRequest.Vocabulary = [||]
                MlPutTrainedModelVocabularyRequest.Merges = Option.None
                MlPutTrainedModelVocabularyRequest.Scores = Option.None
            } : MlPutTrainedModelVocabularyRequest

        [<CustomOperation("model_id")>]
        member _.ModelId(state: MlPutTrainedModelVocabularyRequest, value: Id) =
            { state with MlPutTrainedModelVocabularyRequest.ModelId = value } : MlPutTrainedModelVocabularyRequest

        [<CustomOperation("vocabulary")>]
        member _.Vocabulary(state: MlPutTrainedModelVocabularyRequest, value: string array) =
            { state with MlPutTrainedModelVocabularyRequest.Vocabulary = value } : MlPutTrainedModelVocabularyRequest

        [<CustomOperation("merges")>]
        member _.Merges(state: MlPutTrainedModelVocabularyRequest, value: string array) =
            { state with MlPutTrainedModelVocabularyRequest.Merges = Option.Some value } : MlPutTrainedModelVocabularyRequest

        [<CustomOperation("scores")>]
        member _.Scores(state: MlPutTrainedModelVocabularyRequest, value: float array) =
            { state with MlPutTrainedModelVocabularyRequest.Scores = Option.Some value } : MlPutTrainedModelVocabularyRequest

    let mlPutTrainedModelVocabularyRequest = MlPutTrainedModelVocabularyRequestBuilder()

    type MlPutTrainedModelVocabularyResponse = AcknowledgedResponseBase

    type MlStartTrainedModelDeploymentRequest = {
        [<JsonPropertyName("model_id")>]
        ModelId: Id
        [<JsonPropertyName("cache_size")>]
        CacheSize: ByteSize option
        [<JsonPropertyName("deployment_id")>]
        DeploymentId: string option
        [<JsonPropertyName("number_of_allocations")>]
        NumberOfAllocations: float option
        [<JsonPropertyName("priority")>]
        Priority: TypesTrainingPriority option
        [<JsonPropertyName("queue_capacity")>]
        QueueCapacity: float option
        [<JsonPropertyName("threads_per_allocation")>]
        ThreadsPerAllocation: float option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
        [<JsonPropertyName("wait_for")>]
        WaitFor: TypesDeploymentAllocationState option
        [<JsonPropertyName("adaptive_allocations")>]
        AdaptiveAllocations: TypesAdaptiveAllocationsSettings option
    } with
        static member ToRequest(request: MlStartTrainedModelDeploymentRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{request.ModelId}/deployment/_start"
                let queryParams =
                    [
                        request.CacheSize |> Option.map (fun v -> "cache_size", string v)
                        request.DeploymentId |> Option.map (fun v -> "deployment_id", string v)
                        request.NumberOfAllocations |> Option.map (fun v -> "number_of_allocations", string v)
                        request.Priority |> Option.map (fun v -> "priority", string v)
                        request.QueueCapacity |> Option.map (fun v -> "queue_capacity", string v)
                        request.ThreadsPerAllocation |> Option.map (fun v -> "threads_per_allocation", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                        request.WaitFor |> Option.map (fun v -> "wait_for", string v)
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

    module MlStartTrainedModelDeploymentRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlStartTrainedModelDeploymentRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlStartTrainedModelDeploymentRequest.ToRequest request

    type MlStartTrainedModelDeploymentRequestBuilder() =
        member _.Yield(_: unit) : MlStartTrainedModelDeploymentRequest =
            {
                MlStartTrainedModelDeploymentRequest.ModelId = Unchecked.defaultof<Id>
                MlStartTrainedModelDeploymentRequest.CacheSize = Option.None
                MlStartTrainedModelDeploymentRequest.DeploymentId = Option.None
                MlStartTrainedModelDeploymentRequest.NumberOfAllocations = Option.None
                MlStartTrainedModelDeploymentRequest.Priority = Option.None
                MlStartTrainedModelDeploymentRequest.QueueCapacity = Option.None
                MlStartTrainedModelDeploymentRequest.ThreadsPerAllocation = Option.None
                MlStartTrainedModelDeploymentRequest.Timeout = Option.None
                MlStartTrainedModelDeploymentRequest.WaitFor = Option.None
                MlStartTrainedModelDeploymentRequest.AdaptiveAllocations = Option.None
            } : MlStartTrainedModelDeploymentRequest

        [<CustomOperation("model_id")>]
        member _.ModelId(state: MlStartTrainedModelDeploymentRequest, value: Id) =
            { state with MlStartTrainedModelDeploymentRequest.ModelId = value } : MlStartTrainedModelDeploymentRequest

        [<CustomOperation("cache_size")>]
        member _.CacheSize(state: MlStartTrainedModelDeploymentRequest, value: ByteSize) =
            { state with MlStartTrainedModelDeploymentRequest.CacheSize = Option.Some value } : MlStartTrainedModelDeploymentRequest

        [<CustomOperation("deployment_id")>]
        member _.DeploymentId(state: MlStartTrainedModelDeploymentRequest, value: string) =
            { state with MlStartTrainedModelDeploymentRequest.DeploymentId = Option.Some value } : MlStartTrainedModelDeploymentRequest

        [<CustomOperation("number_of_allocations")>]
        member _.NumberOfAllocations(state: MlStartTrainedModelDeploymentRequest, value: float) =
            { state with MlStartTrainedModelDeploymentRequest.NumberOfAllocations = Option.Some value } : MlStartTrainedModelDeploymentRequest

        [<CustomOperation("priority")>]
        member _.Priority(state: MlStartTrainedModelDeploymentRequest, value: TypesTrainingPriority) =
            { state with MlStartTrainedModelDeploymentRequest.Priority = Option.Some value } : MlStartTrainedModelDeploymentRequest

        [<CustomOperation("queue_capacity")>]
        member _.QueueCapacity(state: MlStartTrainedModelDeploymentRequest, value: float) =
            { state with MlStartTrainedModelDeploymentRequest.QueueCapacity = Option.Some value } : MlStartTrainedModelDeploymentRequest

        [<CustomOperation("threads_per_allocation")>]
        member _.ThreadsPerAllocation(state: MlStartTrainedModelDeploymentRequest, value: float) =
            { state with MlStartTrainedModelDeploymentRequest.ThreadsPerAllocation = Option.Some value } : MlStartTrainedModelDeploymentRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlStartTrainedModelDeploymentRequest, value: Duration) =
            { state with MlStartTrainedModelDeploymentRequest.Timeout = Option.Some value } : MlStartTrainedModelDeploymentRequest

        [<CustomOperation("wait_for")>]
        member _.WaitFor(state: MlStartTrainedModelDeploymentRequest, value: TypesDeploymentAllocationState) =
            { state with MlStartTrainedModelDeploymentRequest.WaitFor = Option.Some value } : MlStartTrainedModelDeploymentRequest

        [<CustomOperation("adaptive_allocations")>]
        member _.AdaptiveAllocations(state: MlStartTrainedModelDeploymentRequest, value: TypesAdaptiveAllocationsSettings) =
            { state with MlStartTrainedModelDeploymentRequest.AdaptiveAllocations = Option.Some value } : MlStartTrainedModelDeploymentRequest

    let mlStartTrainedModelDeploymentRequest = MlStartTrainedModelDeploymentRequestBuilder()

    type MlStartTrainedModelDeploymentResponse = {
        [<JsonPropertyName("assignment")>]
        Assignment: TypesTrainedModelAssignment
    }

    type MlStopTrainedModelDeploymentRequest = {
        [<JsonPropertyName("model_id")>]
        ModelId: Id
        [<JsonPropertyName("allow_no_match")>]
        AllowNoMatch: bool option
        [<JsonPropertyName("force")>]
        Force: bool option
        [<JsonPropertyName("id")>]
        Id: Id option
        [<JsonPropertyName("allow_no_match")>]
        AllowNoMatch2: bool option
        [<JsonPropertyName("force")>]
        Force2: bool option
    } with
        static member ToRequest(request: MlStopTrainedModelDeploymentRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{request.ModelId}/deployment/_stop"
                let queryParams =
                    [
                        request.AllowNoMatch |> Option.map (fun v -> "allow_no_match", string v)
                        request.Force |> Option.map (fun v -> "force", string v)
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

    module MlStopTrainedModelDeploymentRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlStopTrainedModelDeploymentRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlStopTrainedModelDeploymentRequest.ToRequest request

    type MlStopTrainedModelDeploymentRequestBuilder() =
        member _.Yield(_: unit) : MlStopTrainedModelDeploymentRequest =
            {
                MlStopTrainedModelDeploymentRequest.ModelId = Unchecked.defaultof<Id>
                MlStopTrainedModelDeploymentRequest.AllowNoMatch = Option.None
                MlStopTrainedModelDeploymentRequest.Force = Option.None
                MlStopTrainedModelDeploymentRequest.Id = Option.None
                MlStopTrainedModelDeploymentRequest.AllowNoMatch2 = Option.None
                MlStopTrainedModelDeploymentRequest.Force2 = Option.None
            } : MlStopTrainedModelDeploymentRequest

        [<CustomOperation("model_id")>]
        member _.ModelId(state: MlStopTrainedModelDeploymentRequest, value: Id) =
            { state with MlStopTrainedModelDeploymentRequest.ModelId = value } : MlStopTrainedModelDeploymentRequest

        [<CustomOperation("allow_no_match")>]
        member _.AllowNoMatch(state: MlStopTrainedModelDeploymentRequest, value: bool) =
            { state with MlStopTrainedModelDeploymentRequest.AllowNoMatch = Option.Some value } : MlStopTrainedModelDeploymentRequest

        [<CustomOperation("force")>]
        member _.Force(state: MlStopTrainedModelDeploymentRequest, value: bool) =
            { state with MlStopTrainedModelDeploymentRequest.Force = Option.Some value } : MlStopTrainedModelDeploymentRequest

        [<CustomOperation("id")>]
        member _.Id(state: MlStopTrainedModelDeploymentRequest, value: Id) =
            { state with MlStopTrainedModelDeploymentRequest.Id = Option.Some value } : MlStopTrainedModelDeploymentRequest

        [<CustomOperation("allow_no_match2")>]
        member _.AllowNoMatch2(state: MlStopTrainedModelDeploymentRequest, value: bool) =
            { state with MlStopTrainedModelDeploymentRequest.AllowNoMatch2 = Option.Some value } : MlStopTrainedModelDeploymentRequest

        [<CustomOperation("force2")>]
        member _.Force2(state: MlStopTrainedModelDeploymentRequest, value: bool) =
            { state with MlStopTrainedModelDeploymentRequest.Force2 = Option.Some value } : MlStopTrainedModelDeploymentRequest

    let mlStopTrainedModelDeploymentRequest = MlStopTrainedModelDeploymentRequestBuilder()

    type MlStopTrainedModelDeploymentResponse = {
        [<JsonPropertyName("stopped")>]
        Stopped: bool
    }

    type MlUpdateTrainedModelDeploymentRequest = {
        [<JsonPropertyName("model_id")>]
        ModelId: Id
        [<JsonPropertyName("number_of_allocations")>]
        NumberOfAllocations: float option
        [<JsonPropertyName("number_of_allocations")>]
        NumberOfAllocations2: float option
        [<JsonPropertyName("adaptive_allocations")>]
        AdaptiveAllocations: TypesAdaptiveAllocationsSettings option
    } with
        static member ToRequest(request: MlUpdateTrainedModelDeploymentRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/trained_models/{request.ModelId}/deployment/_update"
                let queryParams =
                    [
                        request.NumberOfAllocations |> Option.map (fun v -> "number_of_allocations", string v)
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

    module MlUpdateTrainedModelDeploymentRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlUpdateTrainedModelDeploymentRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlUpdateTrainedModelDeploymentRequest.ToRequest request

    type MlUpdateTrainedModelDeploymentRequestBuilder() =
        member _.Yield(_: unit) : MlUpdateTrainedModelDeploymentRequest =
            {
                MlUpdateTrainedModelDeploymentRequest.ModelId = Unchecked.defaultof<Id>
                MlUpdateTrainedModelDeploymentRequest.NumberOfAllocations = Option.None
                MlUpdateTrainedModelDeploymentRequest.NumberOfAllocations2 = Option.None
                MlUpdateTrainedModelDeploymentRequest.AdaptiveAllocations = Option.None
            } : MlUpdateTrainedModelDeploymentRequest

        [<CustomOperation("model_id")>]
        member _.ModelId(state: MlUpdateTrainedModelDeploymentRequest, value: Id) =
            { state with MlUpdateTrainedModelDeploymentRequest.ModelId = value } : MlUpdateTrainedModelDeploymentRequest

        [<CustomOperation("number_of_allocations")>]
        member _.NumberOfAllocations(state: MlUpdateTrainedModelDeploymentRequest, value: float) =
            { state with MlUpdateTrainedModelDeploymentRequest.NumberOfAllocations = Option.Some value } : MlUpdateTrainedModelDeploymentRequest

        [<CustomOperation("number_of_allocations2")>]
        member _.NumberOfAllocations2(state: MlUpdateTrainedModelDeploymentRequest, value: float) =
            { state with MlUpdateTrainedModelDeploymentRequest.NumberOfAllocations2 = Option.Some value } : MlUpdateTrainedModelDeploymentRequest

        [<CustomOperation("adaptive_allocations")>]
        member _.AdaptiveAllocations(state: MlUpdateTrainedModelDeploymentRequest, value: TypesAdaptiveAllocationsSettings) =
            { state with MlUpdateTrainedModelDeploymentRequest.AdaptiveAllocations = Option.Some value } : MlUpdateTrainedModelDeploymentRequest

    let mlUpdateTrainedModelDeploymentRequest = MlUpdateTrainedModelDeploymentRequestBuilder()

    type MlUpdateTrainedModelDeploymentResponse = {
        [<JsonPropertyName("assignment")>]
        Assignment: TypesTrainedModelAssignment
    }


// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module MlDataFrameOperations =

    type MlGetDataFrameAnalyticsRequest = {
        Id: Id
        AllowNoMatch: bool option
        From: float option
        Size: float option
        ExcludeGenerated: bool option
    } with
        static member ToRequest(request: MlGetDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/data_frame/analytics/{request.Id}"
                let queryParams =
                    [
                        request.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                        request.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        request.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                        request.ExcludeGenerated |> Option.map (fun v -> "exclude_generated", Fes.Http.toQueryValue v)
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

    module MlGetDataFrameAnalyticsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlGetDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlGetDataFrameAnalyticsRequest.ToRequest request

    type MlGetDataFrameAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : MlGetDataFrameAnalyticsRequest =
            {
                MlGetDataFrameAnalyticsRequest.Id = Unchecked.defaultof<Id>
                MlGetDataFrameAnalyticsRequest.AllowNoMatch = Option.None
                MlGetDataFrameAnalyticsRequest.From = Option.None
                MlGetDataFrameAnalyticsRequest.Size = Option.None
                MlGetDataFrameAnalyticsRequest.ExcludeGenerated = Option.None
            } : MlGetDataFrameAnalyticsRequest

        [<CustomOperation("id")>]
        member _.Id(state: MlGetDataFrameAnalyticsRequest, value: Id) =
            { state with MlGetDataFrameAnalyticsRequest.Id = value } : MlGetDataFrameAnalyticsRequest

        [<CustomOperation("allow_no_match")>]
        member _.AllowNoMatch(state: MlGetDataFrameAnalyticsRequest, value: bool) =
            { state with MlGetDataFrameAnalyticsRequest.AllowNoMatch = Option.Some value } : MlGetDataFrameAnalyticsRequest

        [<CustomOperation("from")>]
        member _.From(state: MlGetDataFrameAnalyticsRequest, value: float) =
            { state with MlGetDataFrameAnalyticsRequest.From = Option.Some value } : MlGetDataFrameAnalyticsRequest

        [<CustomOperation("size")>]
        member _.Size(state: MlGetDataFrameAnalyticsRequest, value: float) =
            { state with MlGetDataFrameAnalyticsRequest.Size = Option.Some value } : MlGetDataFrameAnalyticsRequest

        [<CustomOperation("exclude_generated")>]
        member _.ExcludeGenerated(state: MlGetDataFrameAnalyticsRequest, value: bool) =
            { state with MlGetDataFrameAnalyticsRequest.ExcludeGenerated = Option.Some value } : MlGetDataFrameAnalyticsRequest

    let mlGetDataFrameAnalyticsRequest = MlGetDataFrameAnalyticsRequestBuilder()

    type MlPutDataFrameAnalyticsRequest = {
        Id: Id
        [<JsonPropertyName("allow_lazy_start")>]
        AllowLazyStart: bool option
        [<JsonPropertyName("analysis")>]
        Analysis: TypesDataframeAnalysisContainer
        [<JsonPropertyName("analyzed_fields")>]
        AnalyzedFields: TypesDataframeAnalysisAnalyzedFields option
        [<JsonPropertyName("description")>]
        Description: string option
        [<JsonPropertyName("dest")>]
        Dest: TypesDataframeAnalyticsDestination
        [<JsonPropertyName("max_num_threads")>]
        MaxNumThreads: float option
        [<JsonPropertyName("_meta")>]
        Meta: Metadata option
        [<JsonPropertyName("model_memory_limit")>]
        ModelMemoryLimit: string option
        [<JsonPropertyName("source")>]
        Source: TypesDataframeAnalyticsSource
        [<JsonPropertyName("headers")>]
        Headers: HttpHeaders option
        [<JsonPropertyName("version")>]
        Version: VersionString option
    } with
        static member ToRequest(request: MlPutDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/data_frame/analytics/{request.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``allow_lazy_start`` = request.AllowLazyStart; ``analysis`` = request.Analysis; ``analyzed_fields`` = request.AnalyzedFields; ``description`` = request.Description; ``dest`` = request.Dest; ``max_num_threads`` = request.MaxNumThreads; ``_meta`` = request.Meta; ``model_memory_limit`` = request.ModelMemoryLimit; ``source`` = request.Source; ``headers`` = request.Headers; ``version`` = request.Version |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlPutDataFrameAnalyticsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlPutDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlPutDataFrameAnalyticsRequest.ToRequest request

    type MlPutDataFrameAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : MlPutDataFrameAnalyticsRequest =
            {
                MlPutDataFrameAnalyticsRequest.Id = Unchecked.defaultof<Id>
                MlPutDataFrameAnalyticsRequest.AllowLazyStart = Option.None
                MlPutDataFrameAnalyticsRequest.Analysis = Unchecked.defaultof<TypesDataframeAnalysisContainer>
                MlPutDataFrameAnalyticsRequest.AnalyzedFields = Option.None
                MlPutDataFrameAnalyticsRequest.Description = Option.None
                MlPutDataFrameAnalyticsRequest.Dest = Unchecked.defaultof<TypesDataframeAnalyticsDestination>
                MlPutDataFrameAnalyticsRequest.MaxNumThreads = Option.None
                MlPutDataFrameAnalyticsRequest.Meta = Option.None
                MlPutDataFrameAnalyticsRequest.ModelMemoryLimit = Option.None
                MlPutDataFrameAnalyticsRequest.Source = Unchecked.defaultof<TypesDataframeAnalyticsSource>
                MlPutDataFrameAnalyticsRequest.Headers = Option.None
                MlPutDataFrameAnalyticsRequest.Version = Option.None
            } : MlPutDataFrameAnalyticsRequest

        [<CustomOperation("id")>]
        member _.Id(state: MlPutDataFrameAnalyticsRequest, value: Id) =
            { state with MlPutDataFrameAnalyticsRequest.Id = value } : MlPutDataFrameAnalyticsRequest

        [<CustomOperation("allow_lazy_start")>]
        member _.AllowLazyStart(state: MlPutDataFrameAnalyticsRequest, value: bool) =
            { state with MlPutDataFrameAnalyticsRequest.AllowLazyStart = Option.Some value } : MlPutDataFrameAnalyticsRequest

        [<CustomOperation("analysis")>]
        member _.Analysis(state: MlPutDataFrameAnalyticsRequest, value: TypesDataframeAnalysisContainer) =
            { state with MlPutDataFrameAnalyticsRequest.Analysis = value } : MlPutDataFrameAnalyticsRequest

        [<CustomOperation("analyzed_fields")>]
        member _.AnalyzedFields(state: MlPutDataFrameAnalyticsRequest, value: TypesDataframeAnalysisAnalyzedFields) =
            { state with MlPutDataFrameAnalyticsRequest.AnalyzedFields = Option.Some value } : MlPutDataFrameAnalyticsRequest

        [<CustomOperation("description")>]
        member _.Description(state: MlPutDataFrameAnalyticsRequest, value: string) =
            { state with MlPutDataFrameAnalyticsRequest.Description = Option.Some value } : MlPutDataFrameAnalyticsRequest

        [<CustomOperation("dest")>]
        member _.Dest(state: MlPutDataFrameAnalyticsRequest, value: TypesDataframeAnalyticsDestination) =
            { state with MlPutDataFrameAnalyticsRequest.Dest = value } : MlPutDataFrameAnalyticsRequest

        [<CustomOperation("max_num_threads")>]
        member _.MaxNumThreads(state: MlPutDataFrameAnalyticsRequest, value: float) =
            { state with MlPutDataFrameAnalyticsRequest.MaxNumThreads = Option.Some value } : MlPutDataFrameAnalyticsRequest

        [<CustomOperation("_meta")>]
        member _.Meta(state: MlPutDataFrameAnalyticsRequest, value: Metadata) =
            { state with MlPutDataFrameAnalyticsRequest.Meta = Option.Some value } : MlPutDataFrameAnalyticsRequest

        [<CustomOperation("model_memory_limit")>]
        member _.ModelMemoryLimit(state: MlPutDataFrameAnalyticsRequest, value: string) =
            { state with MlPutDataFrameAnalyticsRequest.ModelMemoryLimit = Option.Some value } : MlPutDataFrameAnalyticsRequest

        [<CustomOperation("source")>]
        member _.Source(state: MlPutDataFrameAnalyticsRequest, value: TypesDataframeAnalyticsSource) =
            { state with MlPutDataFrameAnalyticsRequest.Source = value } : MlPutDataFrameAnalyticsRequest

        [<CustomOperation("headers")>]
        member _.Headers(state: MlPutDataFrameAnalyticsRequest, value: HttpHeaders) =
            { state with MlPutDataFrameAnalyticsRequest.Headers = Option.Some value } : MlPutDataFrameAnalyticsRequest

        [<CustomOperation("version")>]
        member _.Version(state: MlPutDataFrameAnalyticsRequest, value: VersionString) =
            { state with MlPutDataFrameAnalyticsRequest.Version = Option.Some value } : MlPutDataFrameAnalyticsRequest

    let mlPutDataFrameAnalyticsRequest = MlPutDataFrameAnalyticsRequestBuilder()

    type MlPutDataFrameAnalyticsResponse = {
        [<JsonPropertyName("authorization")>]
        Authorization: TypesDataframeAnalyticsAuthorization option
        [<JsonPropertyName("allow_lazy_start")>]
        AllowLazyStart: bool
        [<JsonPropertyName("analysis")>]
        Analysis: TypesDataframeAnalysisContainer
        [<JsonPropertyName("analyzed_fields")>]
        AnalyzedFields: TypesDataframeAnalysisAnalyzedFields option
        [<JsonPropertyName("create_time")>]
        CreateTime: EpochTimeUnitMillis
        [<JsonPropertyName("description")>]
        Description: string option
        [<JsonPropertyName("dest")>]
        Dest: TypesDataframeAnalyticsDestination
        [<JsonPropertyName("id")>]
        Id: Id
        [<JsonPropertyName("max_num_threads")>]
        MaxNumThreads: float
        [<JsonPropertyName("_meta")>]
        Meta: Metadata option
        [<JsonPropertyName("model_memory_limit")>]
        ModelMemoryLimit: string
        [<JsonPropertyName("source")>]
        Source: TypesDataframeAnalyticsSource
        [<JsonPropertyName("version")>]
        Version: VersionString
    }

    type MlDeleteDataFrameAnalyticsRequest = {
        Id: Id
        Force: bool option
        Timeout: Duration option
    } with
        static member ToRequest(request: MlDeleteDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/data_frame/analytics/{request.Id}"
                let queryParams =
                    [
                        request.Force |> Option.map (fun v -> "force", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
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

    module MlDeleteDataFrameAnalyticsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlDeleteDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlDeleteDataFrameAnalyticsRequest.ToRequest request

    type MlDeleteDataFrameAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : MlDeleteDataFrameAnalyticsRequest =
            {
                MlDeleteDataFrameAnalyticsRequest.Id = Unchecked.defaultof<Id>
                MlDeleteDataFrameAnalyticsRequest.Force = Option.None
                MlDeleteDataFrameAnalyticsRequest.Timeout = Option.None
            } : MlDeleteDataFrameAnalyticsRequest

        [<CustomOperation("id")>]
        member _.Id(state: MlDeleteDataFrameAnalyticsRequest, value: Id) =
            { state with MlDeleteDataFrameAnalyticsRequest.Id = value } : MlDeleteDataFrameAnalyticsRequest

        [<CustomOperation("force")>]
        member _.Force(state: MlDeleteDataFrameAnalyticsRequest, value: bool) =
            { state with MlDeleteDataFrameAnalyticsRequest.Force = Option.Some value } : MlDeleteDataFrameAnalyticsRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlDeleteDataFrameAnalyticsRequest, value: Duration) =
            { state with MlDeleteDataFrameAnalyticsRequest.Timeout = Option.Some value } : MlDeleteDataFrameAnalyticsRequest

    let mlDeleteDataFrameAnalyticsRequest = MlDeleteDataFrameAnalyticsRequestBuilder()

    type MlDeleteDataFrameAnalyticsResponse = AcknowledgedResponseBase

    type MlEvaluateDataFrameRequest = {
        [<JsonPropertyName("evaluation")>]
        Evaluation: TypesDataframeEvaluationContainer
        [<JsonPropertyName("index")>]
        Index: IndexName
        [<JsonPropertyName("query")>]
        Query: QueryDslQueryContainer option
    } with
        static member ToRequest(request: MlEvaluateDataFrameRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_ml/data_frame/_evaluate"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``evaluation`` = request.Evaluation; ``index`` = request.Index; ``query`` = request.Query |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlEvaluateDataFrameRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlEvaluateDataFrameRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlEvaluateDataFrameRequest.ToRequest request

    type MlEvaluateDataFrameRequestBuilder() =
        member _.Yield(_: unit) : MlEvaluateDataFrameRequest =
            {
                MlEvaluateDataFrameRequest.Evaluation = Unchecked.defaultof<TypesDataframeEvaluationContainer>
                MlEvaluateDataFrameRequest.Index = Unchecked.defaultof<IndexName>
                MlEvaluateDataFrameRequest.Query = Option.None
            } : MlEvaluateDataFrameRequest

        [<CustomOperation("evaluation")>]
        member _.Evaluation(state: MlEvaluateDataFrameRequest, value: TypesDataframeEvaluationContainer) =
            { state with MlEvaluateDataFrameRequest.Evaluation = value } : MlEvaluateDataFrameRequest

        [<CustomOperation("index")>]
        member _.Index(state: MlEvaluateDataFrameRequest, value: IndexName) =
            { state with MlEvaluateDataFrameRequest.Index = value } : MlEvaluateDataFrameRequest

        [<CustomOperation("query")>]
        member _.Query(state: MlEvaluateDataFrameRequest, value: QueryDslQueryContainer) =
            { state with MlEvaluateDataFrameRequest.Query = Option.Some value } : MlEvaluateDataFrameRequest

    let mlEvaluateDataFrameRequest = MlEvaluateDataFrameRequestBuilder()

    type MlEvaluateDataFrameResponse = {
        [<JsonPropertyName("classification")>]
        Classification: EvaluateDataFrameDataframeClassificationSummary option
        [<JsonPropertyName("outlier_detection")>]
        OutlierDetection: EvaluateDataFrameDataframeOutlierDetectionSummary option
        [<JsonPropertyName("regression")>]
        Regression: EvaluateDataFrameDataframeRegressionSummary option
    }

    type MlExplainDataFrameAnalyticsRequest = {
        Id: Id
        [<JsonPropertyName("source")>]
        Source: TypesDataframeAnalyticsSource option
        [<JsonPropertyName("dest")>]
        Dest: TypesDataframeAnalyticsDestination option
        [<JsonPropertyName("analysis")>]
        Analysis: TypesDataframeAnalysisContainer option
        [<JsonPropertyName("description")>]
        Description: string option
        [<JsonPropertyName("model_memory_limit")>]
        ModelMemoryLimit: string option
        [<JsonPropertyName("max_num_threads")>]
        MaxNumThreads: float option
        [<JsonPropertyName("analyzed_fields")>]
        AnalyzedFields: TypesDataframeAnalysisAnalyzedFields option
        [<JsonPropertyName("allow_lazy_start")>]
        AllowLazyStart: bool option
    } with
        static member ToRequest(request: MlExplainDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/data_frame/analytics/{request.Id}/_explain"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``source`` = request.Source; ``dest`` = request.Dest; ``analysis`` = request.Analysis; ``description`` = request.Description; ``model_memory_limit`` = request.ModelMemoryLimit; ``max_num_threads`` = request.MaxNumThreads; ``analyzed_fields`` = request.AnalyzedFields; ``allow_lazy_start`` = request.AllowLazyStart |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlExplainDataFrameAnalyticsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlExplainDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlExplainDataFrameAnalyticsRequest.ToRequest request

    type MlExplainDataFrameAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : MlExplainDataFrameAnalyticsRequest =
            {
                MlExplainDataFrameAnalyticsRequest.Id = Unchecked.defaultof<Id>
                MlExplainDataFrameAnalyticsRequest.Source = Option.None
                MlExplainDataFrameAnalyticsRequest.Dest = Option.None
                MlExplainDataFrameAnalyticsRequest.Analysis = Option.None
                MlExplainDataFrameAnalyticsRequest.Description = Option.None
                MlExplainDataFrameAnalyticsRequest.ModelMemoryLimit = Option.None
                MlExplainDataFrameAnalyticsRequest.MaxNumThreads = Option.None
                MlExplainDataFrameAnalyticsRequest.AnalyzedFields = Option.None
                MlExplainDataFrameAnalyticsRequest.AllowLazyStart = Option.None
            } : MlExplainDataFrameAnalyticsRequest

        [<CustomOperation("id")>]
        member _.Id(state: MlExplainDataFrameAnalyticsRequest, value: Id) =
            { state with MlExplainDataFrameAnalyticsRequest.Id = value } : MlExplainDataFrameAnalyticsRequest

        [<CustomOperation("source")>]
        member _.Source(state: MlExplainDataFrameAnalyticsRequest, value: TypesDataframeAnalyticsSource) =
            { state with MlExplainDataFrameAnalyticsRequest.Source = Option.Some value } : MlExplainDataFrameAnalyticsRequest

        [<CustomOperation("dest")>]
        member _.Dest(state: MlExplainDataFrameAnalyticsRequest, value: TypesDataframeAnalyticsDestination) =
            { state with MlExplainDataFrameAnalyticsRequest.Dest = Option.Some value } : MlExplainDataFrameAnalyticsRequest

        [<CustomOperation("analysis")>]
        member _.Analysis(state: MlExplainDataFrameAnalyticsRequest, value: TypesDataframeAnalysisContainer) =
            { state with MlExplainDataFrameAnalyticsRequest.Analysis = Option.Some value } : MlExplainDataFrameAnalyticsRequest

        [<CustomOperation("description")>]
        member _.Description(state: MlExplainDataFrameAnalyticsRequest, value: string) =
            { state with MlExplainDataFrameAnalyticsRequest.Description = Option.Some value } : MlExplainDataFrameAnalyticsRequest

        [<CustomOperation("model_memory_limit")>]
        member _.ModelMemoryLimit(state: MlExplainDataFrameAnalyticsRequest, value: string) =
            { state with MlExplainDataFrameAnalyticsRequest.ModelMemoryLimit = Option.Some value } : MlExplainDataFrameAnalyticsRequest

        [<CustomOperation("max_num_threads")>]
        member _.MaxNumThreads(state: MlExplainDataFrameAnalyticsRequest, value: float) =
            { state with MlExplainDataFrameAnalyticsRequest.MaxNumThreads = Option.Some value } : MlExplainDataFrameAnalyticsRequest

        [<CustomOperation("analyzed_fields")>]
        member _.AnalyzedFields(state: MlExplainDataFrameAnalyticsRequest, value: TypesDataframeAnalysisAnalyzedFields) =
            { state with MlExplainDataFrameAnalyticsRequest.AnalyzedFields = Option.Some value } : MlExplainDataFrameAnalyticsRequest

        [<CustomOperation("allow_lazy_start")>]
        member _.AllowLazyStart(state: MlExplainDataFrameAnalyticsRequest, value: bool) =
            { state with MlExplainDataFrameAnalyticsRequest.AllowLazyStart = Option.Some value } : MlExplainDataFrameAnalyticsRequest

    let mlExplainDataFrameAnalyticsRequest = MlExplainDataFrameAnalyticsRequestBuilder()

    type MlGetDataFrameAnalyticsStatsRequest = {
        Id: Id
        AllowNoMatch: bool option
        From: float option
        Size: float option
        Verbose: bool option
    } with
        static member ToRequest(request: MlGetDataFrameAnalyticsStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/data_frame/analytics/{request.Id}/_stats"
                let queryParams =
                    [
                        request.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                        request.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        request.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                        request.Verbose |> Option.map (fun v -> "verbose", Fes.Http.toQueryValue v)
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

    module MlGetDataFrameAnalyticsStatsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlGetDataFrameAnalyticsStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlGetDataFrameAnalyticsStatsRequest.ToRequest request

    type MlGetDataFrameAnalyticsStatsRequestBuilder() =
        member _.Yield(_: unit) : MlGetDataFrameAnalyticsStatsRequest =
            {
                MlGetDataFrameAnalyticsStatsRequest.Id = Unchecked.defaultof<Id>
                MlGetDataFrameAnalyticsStatsRequest.AllowNoMatch = Option.None
                MlGetDataFrameAnalyticsStatsRequest.From = Option.None
                MlGetDataFrameAnalyticsStatsRequest.Size = Option.None
                MlGetDataFrameAnalyticsStatsRequest.Verbose = Option.None
            } : MlGetDataFrameAnalyticsStatsRequest

        [<CustomOperation("id")>]
        member _.Id(state: MlGetDataFrameAnalyticsStatsRequest, value: Id) =
            { state with MlGetDataFrameAnalyticsStatsRequest.Id = value } : MlGetDataFrameAnalyticsStatsRequest

        [<CustomOperation("allow_no_match")>]
        member _.AllowNoMatch(state: MlGetDataFrameAnalyticsStatsRequest, value: bool) =
            { state with MlGetDataFrameAnalyticsStatsRequest.AllowNoMatch = Option.Some value } : MlGetDataFrameAnalyticsStatsRequest

        [<CustomOperation("from")>]
        member _.From(state: MlGetDataFrameAnalyticsStatsRequest, value: float) =
            { state with MlGetDataFrameAnalyticsStatsRequest.From = Option.Some value } : MlGetDataFrameAnalyticsStatsRequest

        [<CustomOperation("size")>]
        member _.Size(state: MlGetDataFrameAnalyticsStatsRequest, value: float) =
            { state with MlGetDataFrameAnalyticsStatsRequest.Size = Option.Some value } : MlGetDataFrameAnalyticsStatsRequest

        [<CustomOperation("verbose")>]
        member _.Verbose(state: MlGetDataFrameAnalyticsStatsRequest, value: bool) =
            { state with MlGetDataFrameAnalyticsStatsRequest.Verbose = Option.Some value } : MlGetDataFrameAnalyticsStatsRequest

    let mlGetDataFrameAnalyticsStatsRequest = MlGetDataFrameAnalyticsStatsRequestBuilder()

    type MlPreviewDataFrameAnalyticsRequest = {
        Id: Id
        [<JsonPropertyName("config")>]
        Config: PreviewDataFrameAnalyticsDataframePreviewConfig option
    } with
        static member ToRequest(request: MlPreviewDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/data_frame/analytics/{request.Id}/_preview"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``config`` = request.Config |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlPreviewDataFrameAnalyticsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlPreviewDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlPreviewDataFrameAnalyticsRequest.ToRequest request

    type MlPreviewDataFrameAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : MlPreviewDataFrameAnalyticsRequest =
            {
                MlPreviewDataFrameAnalyticsRequest.Id = Unchecked.defaultof<Id>
                MlPreviewDataFrameAnalyticsRequest.Config = Option.None
            } : MlPreviewDataFrameAnalyticsRequest

        [<CustomOperation("id")>]
        member _.Id(state: MlPreviewDataFrameAnalyticsRequest, value: Id) =
            { state with MlPreviewDataFrameAnalyticsRequest.Id = value } : MlPreviewDataFrameAnalyticsRequest

        [<CustomOperation("config")>]
        member _.Config(state: MlPreviewDataFrameAnalyticsRequest, value: PreviewDataFrameAnalyticsDataframePreviewConfig) =
            { state with MlPreviewDataFrameAnalyticsRequest.Config = Option.Some value } : MlPreviewDataFrameAnalyticsRequest

    let mlPreviewDataFrameAnalyticsRequest = MlPreviewDataFrameAnalyticsRequestBuilder()

    type MlStartDataFrameAnalyticsRequest = {
        Id: Id
        Timeout: Duration option
        [<JsonPropertyName("id")>]
        BodyId: Id option
        [<JsonPropertyName("timeout")>]
        BodyTimeout: Duration option
    } with
        static member ToRequest(request: MlStartDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/data_frame/analytics/{request.Id}/_start"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``id`` = request.BodyId; ``timeout`` = request.BodyTimeout |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlStartDataFrameAnalyticsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlStartDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlStartDataFrameAnalyticsRequest.ToRequest request

    type MlStartDataFrameAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : MlStartDataFrameAnalyticsRequest =
            {
                MlStartDataFrameAnalyticsRequest.Id = Unchecked.defaultof<Id>
                MlStartDataFrameAnalyticsRequest.Timeout = Option.None
                MlStartDataFrameAnalyticsRequest.BodyId = Option.None
                MlStartDataFrameAnalyticsRequest.BodyTimeout = Option.None
            } : MlStartDataFrameAnalyticsRequest

        [<CustomOperation("id")>]
        member _.Id(state: MlStartDataFrameAnalyticsRequest, value: Id) =
            { state with MlStartDataFrameAnalyticsRequest.Id = value } : MlStartDataFrameAnalyticsRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlStartDataFrameAnalyticsRequest, value: Duration) =
            { state with MlStartDataFrameAnalyticsRequest.Timeout = Option.Some value } : MlStartDataFrameAnalyticsRequest

        [<CustomOperation("body_id")>]
        member _.BodyId(state: MlStartDataFrameAnalyticsRequest, value: Id) =
            { state with MlStartDataFrameAnalyticsRequest.BodyId = Option.Some value } : MlStartDataFrameAnalyticsRequest

        [<CustomOperation("body_timeout")>]
        member _.BodyTimeout(state: MlStartDataFrameAnalyticsRequest, value: Duration) =
            { state with MlStartDataFrameAnalyticsRequest.BodyTimeout = Option.Some value } : MlStartDataFrameAnalyticsRequest

    let mlStartDataFrameAnalyticsRequest = MlStartDataFrameAnalyticsRequestBuilder()

    type MlStartDataFrameAnalyticsResponse = {
        [<JsonPropertyName("acknowledged")>]
        Acknowledged: bool
        [<JsonPropertyName("node")>]
        Node: NodeId
    }

    type MlStopDataFrameAnalyticsRequest = {
        Id: Id
        AllowNoMatch: bool option
        Force: bool option
        Timeout: Duration option
        [<JsonPropertyName("id")>]
        BodyId: Id option
        [<JsonPropertyName("allow_no_match")>]
        BodyAllowNoMatch: bool option
        [<JsonPropertyName("force")>]
        BodyForce: bool option
        [<JsonPropertyName("timeout")>]
        BodyTimeout: Duration option
    } with
        static member ToRequest(request: MlStopDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/data_frame/analytics/{request.Id}/_stop"
                let queryParams =
                    [
                        request.AllowNoMatch |> Option.map (fun v -> "allow_no_match", Fes.Http.toQueryValue v)
                        request.Force |> Option.map (fun v -> "force", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``id`` = request.BodyId; ``allow_no_match`` = request.BodyAllowNoMatch; ``force`` = request.BodyForce; ``timeout`` = request.BodyTimeout |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlStopDataFrameAnalyticsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlStopDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlStopDataFrameAnalyticsRequest.ToRequest request

    type MlStopDataFrameAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : MlStopDataFrameAnalyticsRequest =
            {
                MlStopDataFrameAnalyticsRequest.Id = Unchecked.defaultof<Id>
                MlStopDataFrameAnalyticsRequest.AllowNoMatch = Option.None
                MlStopDataFrameAnalyticsRequest.Force = Option.None
                MlStopDataFrameAnalyticsRequest.Timeout = Option.None
                MlStopDataFrameAnalyticsRequest.BodyId = Option.None
                MlStopDataFrameAnalyticsRequest.BodyAllowNoMatch = Option.None
                MlStopDataFrameAnalyticsRequest.BodyForce = Option.None
                MlStopDataFrameAnalyticsRequest.BodyTimeout = Option.None
            } : MlStopDataFrameAnalyticsRequest

        [<CustomOperation("id")>]
        member _.Id(state: MlStopDataFrameAnalyticsRequest, value: Id) =
            { state with MlStopDataFrameAnalyticsRequest.Id = value } : MlStopDataFrameAnalyticsRequest

        [<CustomOperation("allow_no_match")>]
        member _.AllowNoMatch(state: MlStopDataFrameAnalyticsRequest, value: bool) =
            { state with MlStopDataFrameAnalyticsRequest.AllowNoMatch = Option.Some value } : MlStopDataFrameAnalyticsRequest

        [<CustomOperation("force")>]
        member _.Force(state: MlStopDataFrameAnalyticsRequest, value: bool) =
            { state with MlStopDataFrameAnalyticsRequest.Force = Option.Some value } : MlStopDataFrameAnalyticsRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: MlStopDataFrameAnalyticsRequest, value: Duration) =
            { state with MlStopDataFrameAnalyticsRequest.Timeout = Option.Some value } : MlStopDataFrameAnalyticsRequest

        [<CustomOperation("body_id")>]
        member _.BodyId(state: MlStopDataFrameAnalyticsRequest, value: Id) =
            { state with MlStopDataFrameAnalyticsRequest.BodyId = Option.Some value } : MlStopDataFrameAnalyticsRequest

        [<CustomOperation("body_allow_no_match")>]
        member _.BodyAllowNoMatch(state: MlStopDataFrameAnalyticsRequest, value: bool) =
            { state with MlStopDataFrameAnalyticsRequest.BodyAllowNoMatch = Option.Some value } : MlStopDataFrameAnalyticsRequest

        [<CustomOperation("body_force")>]
        member _.BodyForce(state: MlStopDataFrameAnalyticsRequest, value: bool) =
            { state with MlStopDataFrameAnalyticsRequest.BodyForce = Option.Some value } : MlStopDataFrameAnalyticsRequest

        [<CustomOperation("body_timeout")>]
        member _.BodyTimeout(state: MlStopDataFrameAnalyticsRequest, value: Duration) =
            { state with MlStopDataFrameAnalyticsRequest.BodyTimeout = Option.Some value } : MlStopDataFrameAnalyticsRequest

    let mlStopDataFrameAnalyticsRequest = MlStopDataFrameAnalyticsRequestBuilder()

    type MlStopDataFrameAnalyticsResponse = {
        [<JsonPropertyName("stopped")>]
        Stopped: bool
    }

    type MlUpdateDataFrameAnalyticsRequest = {
        Id: Id
        [<JsonPropertyName("description")>]
        Description: string option
        [<JsonPropertyName("model_memory_limit")>]
        ModelMemoryLimit: string option
        [<JsonPropertyName("max_num_threads")>]
        MaxNumThreads: float option
        [<JsonPropertyName("allow_lazy_start")>]
        AllowLazyStart: bool option
    } with
        static member ToRequest(request: MlUpdateDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ml/data_frame/analytics/{request.Id}/_update"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``description`` = request.Description; ``model_memory_limit`` = request.ModelMemoryLimit; ``max_num_threads`` = request.MaxNumThreads; ``allow_lazy_start`` = request.AllowLazyStart |}
                |> Result.Ok
            with ex -> Result.Error ex

    module MlUpdateDataFrameAnalyticsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MlUpdateDataFrameAnalyticsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MlUpdateDataFrameAnalyticsRequest.ToRequest request

    type MlUpdateDataFrameAnalyticsRequestBuilder() =
        member _.Yield(_: unit) : MlUpdateDataFrameAnalyticsRequest =
            {
                MlUpdateDataFrameAnalyticsRequest.Id = Unchecked.defaultof<Id>
                MlUpdateDataFrameAnalyticsRequest.Description = Option.None
                MlUpdateDataFrameAnalyticsRequest.ModelMemoryLimit = Option.None
                MlUpdateDataFrameAnalyticsRequest.MaxNumThreads = Option.None
                MlUpdateDataFrameAnalyticsRequest.AllowLazyStart = Option.None
            } : MlUpdateDataFrameAnalyticsRequest

        [<CustomOperation("id")>]
        member _.Id(state: MlUpdateDataFrameAnalyticsRequest, value: Id) =
            { state with MlUpdateDataFrameAnalyticsRequest.Id = value } : MlUpdateDataFrameAnalyticsRequest

        [<CustomOperation("description")>]
        member _.Description(state: MlUpdateDataFrameAnalyticsRequest, value: string) =
            { state with MlUpdateDataFrameAnalyticsRequest.Description = Option.Some value } : MlUpdateDataFrameAnalyticsRequest

        [<CustomOperation("model_memory_limit")>]
        member _.ModelMemoryLimit(state: MlUpdateDataFrameAnalyticsRequest, value: string) =
            { state with MlUpdateDataFrameAnalyticsRequest.ModelMemoryLimit = Option.Some value } : MlUpdateDataFrameAnalyticsRequest

        [<CustomOperation("max_num_threads")>]
        member _.MaxNumThreads(state: MlUpdateDataFrameAnalyticsRequest, value: float) =
            { state with MlUpdateDataFrameAnalyticsRequest.MaxNumThreads = Option.Some value } : MlUpdateDataFrameAnalyticsRequest

        [<CustomOperation("allow_lazy_start")>]
        member _.AllowLazyStart(state: MlUpdateDataFrameAnalyticsRequest, value: bool) =
            { state with MlUpdateDataFrameAnalyticsRequest.AllowLazyStart = Option.Some value } : MlUpdateDataFrameAnalyticsRequest

    let mlUpdateDataFrameAnalyticsRequest = MlUpdateDataFrameAnalyticsRequestBuilder()

    type MlUpdateDataFrameAnalyticsResponse = {
        [<JsonPropertyName("authorization")>]
        Authorization: TypesDataframeAnalyticsAuthorization option
        [<JsonPropertyName("allow_lazy_start")>]
        AllowLazyStart: bool
        [<JsonPropertyName("analysis")>]
        Analysis: TypesDataframeAnalysisContainer
        [<JsonPropertyName("analyzed_fields")>]
        AnalyzedFields: TypesDataframeAnalysisAnalyzedFields option
        [<JsonPropertyName("create_time")>]
        CreateTime: float
        [<JsonPropertyName("description")>]
        Description: string option
        [<JsonPropertyName("dest")>]
        Dest: TypesDataframeAnalyticsDestination
        [<JsonPropertyName("id")>]
        Id: Id
        [<JsonPropertyName("max_num_threads")>]
        MaxNumThreads: float
        [<JsonPropertyName("model_memory_limit")>]
        ModelMemoryLimit: string
        [<JsonPropertyName("source")>]
        Source: TypesDataframeAnalyticsSource
        [<JsonPropertyName("version")>]
        Version: VersionString
    }


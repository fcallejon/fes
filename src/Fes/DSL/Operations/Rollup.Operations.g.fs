// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module RollupOperations =

    type RollupGetJobsRequest = {
        [<JsonPropertyName("id")>]
        Id: Id
    } with
        static member ToRequest(request: RollupGetJobsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_rollup/job/{request.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module RollupGetJobsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: RollupGetJobsRequest) : Result<Fes.Http.RequestMsg, exn> =
            RollupGetJobsRequest.ToRequest request

    type RollupGetJobsRequestBuilder() =
        member _.Yield(_: unit) : RollupGetJobsRequest =
            {
                RollupGetJobsRequest.Id = Unchecked.defaultof<Id>
            } : RollupGetJobsRequest

        [<CustomOperation("id")>]
        member _.Id(state: RollupGetJobsRequest, value: Id) =
            { state with RollupGetJobsRequest.Id = value } : RollupGetJobsRequest

    let rollupGetJobsRequest = RollupGetJobsRequestBuilder()

    type RollupPutJobRequest = {
        [<JsonPropertyName("id")>]
        Id: Id
        [<JsonPropertyName("cron")>]
        Cron: string
        [<JsonPropertyName("groups")>]
        Groups: TypesGroupings
        [<JsonPropertyName("index_pattern")>]
        IndexPattern: string
        [<JsonPropertyName("metrics")>]
        Metrics: TypesFieldMetric array option
        [<JsonPropertyName("page_size")>]
        PageSize: float
        [<JsonPropertyName("rollup_index")>]
        RollupIndex: IndexName
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
        [<JsonPropertyName("headers")>]
        Headers: HttpHeaders option
    } with
        static member ToRequest(request: RollupPutJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_rollup/job/{request.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module RollupPutJobRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: RollupPutJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            RollupPutJobRequest.ToRequest request

    type RollupPutJobRequestBuilder() =
        member _.Yield(_: unit) : RollupPutJobRequest =
            {
                RollupPutJobRequest.Id = Unchecked.defaultof<Id>
                RollupPutJobRequest.Cron = String.Empty
                RollupPutJobRequest.Groups = Unchecked.defaultof<TypesGroupings>
                RollupPutJobRequest.IndexPattern = String.Empty
                RollupPutJobRequest.Metrics = Option.None
                RollupPutJobRequest.PageSize = 0.0
                RollupPutJobRequest.RollupIndex = Unchecked.defaultof<IndexName>
                RollupPutJobRequest.Timeout = Option.None
                RollupPutJobRequest.Headers = Option.None
            } : RollupPutJobRequest

        [<CustomOperation("id")>]
        member _.Id(state: RollupPutJobRequest, value: Id) =
            { state with RollupPutJobRequest.Id = value } : RollupPutJobRequest

        [<CustomOperation("cron")>]
        member _.Cron(state: RollupPutJobRequest, value: string) =
            { state with RollupPutJobRequest.Cron = value } : RollupPutJobRequest

        [<CustomOperation("groups")>]
        member _.Groups(state: RollupPutJobRequest, value: TypesGroupings) =
            { state with RollupPutJobRequest.Groups = value } : RollupPutJobRequest

        [<CustomOperation("index_pattern")>]
        member _.IndexPattern(state: RollupPutJobRequest, value: string) =
            { state with RollupPutJobRequest.IndexPattern = value } : RollupPutJobRequest

        [<CustomOperation("metrics")>]
        member _.Metrics(state: RollupPutJobRequest, value: TypesFieldMetric array) =
            { state with RollupPutJobRequest.Metrics = Option.Some value } : RollupPutJobRequest

        [<CustomOperation("page_size")>]
        member _.PageSize(state: RollupPutJobRequest, value: float) =
            { state with RollupPutJobRequest.PageSize = value } : RollupPutJobRequest

        [<CustomOperation("rollup_index")>]
        member _.RollupIndex(state: RollupPutJobRequest, value: IndexName) =
            { state with RollupPutJobRequest.RollupIndex = value } : RollupPutJobRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: RollupPutJobRequest, value: Duration) =
            { state with RollupPutJobRequest.Timeout = Option.Some value } : RollupPutJobRequest

        [<CustomOperation("headers")>]
        member _.Headers(state: RollupPutJobRequest, value: HttpHeaders) =
            { state with RollupPutJobRequest.Headers = Option.Some value } : RollupPutJobRequest

    let rollupPutJobRequest = RollupPutJobRequestBuilder()

    type RollupPutJobResponse = AcknowledgedResponseBase

    type RollupDeleteJobRequest = {
        [<JsonPropertyName("id")>]
        Id: Id
    } with
        static member ToRequest(request: RollupDeleteJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_rollup/job/{request.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module RollupDeleteJobRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: RollupDeleteJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            RollupDeleteJobRequest.ToRequest request

    type RollupDeleteJobRequestBuilder() =
        member _.Yield(_: unit) : RollupDeleteJobRequest =
            {
                RollupDeleteJobRequest.Id = Unchecked.defaultof<Id>
            } : RollupDeleteJobRequest

        [<CustomOperation("id")>]
        member _.Id(state: RollupDeleteJobRequest, value: Id) =
            { state with RollupDeleteJobRequest.Id = value } : RollupDeleteJobRequest

    let rollupDeleteJobRequest = RollupDeleteJobRequestBuilder()

    type RollupDeleteJobResponse = {
        [<JsonPropertyName("acknowledged")>]
        Acknowledged: bool
        [<JsonPropertyName("task_failures")>]
        TaskFailures: TaskFailure array option
    }

    type RollupGetRollupCapsRequest = {
        [<JsonPropertyName("id")>]
        Id: Id
    } with
        static member ToRequest(request: RollupGetRollupCapsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_rollup/data/{request.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module RollupGetRollupCapsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: RollupGetRollupCapsRequest) : Result<Fes.Http.RequestMsg, exn> =
            RollupGetRollupCapsRequest.ToRequest request

    type RollupGetRollupCapsRequestBuilder() =
        member _.Yield(_: unit) : RollupGetRollupCapsRequest =
            {
                RollupGetRollupCapsRequest.Id = Unchecked.defaultof<Id>
            } : RollupGetRollupCapsRequest

        [<CustomOperation("id")>]
        member _.Id(state: RollupGetRollupCapsRequest, value: Id) =
            { state with RollupGetRollupCapsRequest.Id = value } : RollupGetRollupCapsRequest

    let rollupGetRollupCapsRequest = RollupGetRollupCapsRequestBuilder()

    type RollupGetRollupIndexCapsRequest = {
        [<JsonPropertyName("index")>]
        Index: Ids
    } with
        static member ToRequest(request: RollupGetRollupIndexCapsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_rollup/data"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module RollupGetRollupIndexCapsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: RollupGetRollupIndexCapsRequest) : Result<Fes.Http.RequestMsg, exn> =
            RollupGetRollupIndexCapsRequest.ToRequest request

    type RollupGetRollupIndexCapsRequestBuilder() =
        member _.Yield(_: unit) : RollupGetRollupIndexCapsRequest =
            {
                RollupGetRollupIndexCapsRequest.Index = Unchecked.defaultof<Ids>
            } : RollupGetRollupIndexCapsRequest

        [<CustomOperation("index")>]
        member _.Index(state: RollupGetRollupIndexCapsRequest, value: Ids) =
            { state with RollupGetRollupIndexCapsRequest.Index = value } : RollupGetRollupIndexCapsRequest

    let rollupGetRollupIndexCapsRequest = RollupGetRollupIndexCapsRequestBuilder()

    type RollupRollupSearchRequest = {
        [<JsonPropertyName("index")>]
        Index: Indices
        [<JsonPropertyName("rest_total_hits_as_int")>]
        RestTotalHitsAsInt: bool option
        [<JsonPropertyName("typed_keys")>]
        TypedKeys: bool option
        [<JsonPropertyName("aggregations")>]
        Aggregations: Map<string, AggregationsAggregationContainer> option
        [<JsonPropertyName("query")>]
        Query: QueryDslQueryContainer option
        [<JsonPropertyName("size")>]
        Size: float option
    } with
        static member ToRequest(request: RollupRollupSearchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_rollup_search"
                let queryParams =
                    [
                        request.RestTotalHitsAsInt |> Option.map (fun v -> "rest_total_hits_as_int", string v)
                        request.TypedKeys |> Option.map (fun v -> "typed_keys", string v)
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

    module RollupRollupSearchRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: RollupRollupSearchRequest) : Result<Fes.Http.RequestMsg, exn> =
            RollupRollupSearchRequest.ToRequest request

    type RollupRollupSearchRequestBuilder() =
        member _.Yield(_: unit) : RollupRollupSearchRequest =
            {
                RollupRollupSearchRequest.Index = Unchecked.defaultof<Indices>
                RollupRollupSearchRequest.RestTotalHitsAsInt = Option.None
                RollupRollupSearchRequest.TypedKeys = Option.None
                RollupRollupSearchRequest.Aggregations = Option.None
                RollupRollupSearchRequest.Query = Option.None
                RollupRollupSearchRequest.Size = Option.None
            } : RollupRollupSearchRequest

        [<CustomOperation("index")>]
        member _.Index(state: RollupRollupSearchRequest, value: Indices) =
            { state with RollupRollupSearchRequest.Index = value } : RollupRollupSearchRequest

        [<CustomOperation("rest_total_hits_as_int")>]
        member _.RestTotalHitsAsInt(state: RollupRollupSearchRequest, value: bool) =
            { state with RollupRollupSearchRequest.RestTotalHitsAsInt = Option.Some value } : RollupRollupSearchRequest

        [<CustomOperation("typed_keys")>]
        member _.TypedKeys(state: RollupRollupSearchRequest, value: bool) =
            { state with RollupRollupSearchRequest.TypedKeys = Option.Some value } : RollupRollupSearchRequest

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: RollupRollupSearchRequest, value: Map<string, AggregationsAggregationContainer>) =
            { state with RollupRollupSearchRequest.Aggregations = Option.Some value } : RollupRollupSearchRequest

        [<CustomOperation("query")>]
        member _.Query(state: RollupRollupSearchRequest, value: QueryDslQueryContainer) =
            { state with RollupRollupSearchRequest.Query = Option.Some value } : RollupRollupSearchRequest

        [<CustomOperation("size")>]
        member _.Size(state: RollupRollupSearchRequest, value: float) =
            { state with RollupRollupSearchRequest.Size = Option.Some value } : RollupRollupSearchRequest

    let rollupRollupSearchRequest = RollupRollupSearchRequestBuilder()

    type RollupStartJobRequest = {
        [<JsonPropertyName("id")>]
        Id: Id
    } with
        static member ToRequest(request: RollupStartJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_rollup/job/{request.Id}/_start"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module RollupStartJobRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: RollupStartJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            RollupStartJobRequest.ToRequest request

    type RollupStartJobRequestBuilder() =
        member _.Yield(_: unit) : RollupStartJobRequest =
            {
                RollupStartJobRequest.Id = Unchecked.defaultof<Id>
            } : RollupStartJobRequest

        [<CustomOperation("id")>]
        member _.Id(state: RollupStartJobRequest, value: Id) =
            { state with RollupStartJobRequest.Id = value } : RollupStartJobRequest

    let rollupStartJobRequest = RollupStartJobRequestBuilder()

    type RollupStartJobResponse = {
        [<JsonPropertyName("started")>]
        Started: bool
    }

    type RollupStopJobRequest = {
        [<JsonPropertyName("id")>]
        Id: Id
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
        [<JsonPropertyName("wait_for_completion")>]
        WaitForCompletion: bool option
    } with
        static member ToRequest(request: RollupStopJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_rollup/job/{request.Id}/_stop"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module RollupStopJobRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: RollupStopJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            RollupStopJobRequest.ToRequest request

    type RollupStopJobRequestBuilder() =
        member _.Yield(_: unit) : RollupStopJobRequest =
            {
                RollupStopJobRequest.Id = Unchecked.defaultof<Id>
                RollupStopJobRequest.Timeout = Option.None
                RollupStopJobRequest.WaitForCompletion = Option.None
            } : RollupStopJobRequest

        [<CustomOperation("id")>]
        member _.Id(state: RollupStopJobRequest, value: Id) =
            { state with RollupStopJobRequest.Id = value } : RollupStopJobRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: RollupStopJobRequest, value: Duration) =
            { state with RollupStopJobRequest.Timeout = Option.Some value } : RollupStopJobRequest

        [<CustomOperation("wait_for_completion")>]
        member _.WaitForCompletion(state: RollupStopJobRequest, value: bool) =
            { state with RollupStopJobRequest.WaitForCompletion = Option.Some value } : RollupStopJobRequest

    let rollupStopJobRequest = RollupStopJobRequestBuilder()

    type RollupStopJobResponse = {
        [<JsonPropertyName("stopped")>]
        Stopped: bool
    }


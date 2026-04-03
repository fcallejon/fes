// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module RollupOperations =

    type RollupDeleteJobRequest = {
        Id: Types.Id
    }

        with
        static member ToRequest(req: RollupDeleteJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_rollup/job/{req.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type RollupDeleteJobResponse = System.Text.Json.JsonElement

    type RollupDeleteJobRequestBuilder() =
        member _.Yield(_: unit) : RollupDeleteJobRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: RollupDeleteJobRequest, value: Types.Id) =
            { state with Id = value }

    let rollupDeleteJobRequest = RollupDeleteJobRequestBuilder()

    type RollupGetJobsRequest = {
        Id: Types.Id
    }

        with
        static member ToRequest(req: RollupGetJobsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_rollup/job/{req.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type RollupGetJobsResponse = System.Text.Json.JsonElement

    type RollupGetJobsRequestBuilder() =
        member _.Yield(_: unit) : RollupGetJobsRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: RollupGetJobsRequest, value: Types.Id) =
            { state with Id = value }

    let rollupGetJobsRequest = RollupGetJobsRequestBuilder()

    type RollupGetRollupCapsRequest = {
        Id: Types.Id
    }

        with
        static member ToRequest(req: RollupGetRollupCapsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_rollup/data/{req.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type RollupGetRollupCapsResponse = Map<Types.IndexName, Types.RollupCapabilities>

    type RollupGetRollupCapsRequestBuilder() =
        member _.Yield(_: unit) : RollupGetRollupCapsRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: RollupGetRollupCapsRequest, value: Types.Id) =
            { state with Id = value }

    let rollupGetRollupCapsRequest = RollupGetRollupCapsRequestBuilder()

    type RollupGetRollupIndexCapsRequest = {
        Index: Types.Ids
    }

        with
        static member ToRequest(req: RollupGetRollupIndexCapsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_rollup/data"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type RollupGetRollupIndexCapsResponse = Map<Types.IndexName, Types.IndexCapabilities>

    type RollupGetRollupIndexCapsRequestBuilder() =
        member _.Yield(_: unit) : RollupGetRollupIndexCapsRequest =
            {
                Index = Unchecked.defaultof<_>
            }

        [<CustomOperation("index")>]
        member _.Index(state: RollupGetRollupIndexCapsRequest, value: Types.Ids) =
            { state with Index = value }

    let rollupGetRollupIndexCapsRequest = RollupGetRollupIndexCapsRequestBuilder()

    type RollupPutJobRequest = {
        Id: Types.Id
        Cron: string
        Groups: Types.Groupings
        IndexPattern: string
        Metrics: Types.FieldMetric list option
        PageSize: Types.Integer
        RollupIndex: Types.IndexName
        Timeout: Types.Duration option
        Headers: Types.HttpHeaders option
    }

        with
        static member ToRequest(req: RollupPutJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_rollup/job/{req.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type RollupPutJobResponse = Types.AcknowledgedResponseBase

    type RollupPutJobRequestBuilder() =
        member _.Yield(_: unit) : RollupPutJobRequest =
            {
                Id = Unchecked.defaultof<_>
                Cron = Unchecked.defaultof<_>
                Groups = Unchecked.defaultof<_>
                IndexPattern = Unchecked.defaultof<_>
                Metrics = None
                PageSize = Unchecked.defaultof<_>
                RollupIndex = Unchecked.defaultof<_>
                Timeout = None
                Headers = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: RollupPutJobRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("cron")>]
        member _.Cron(state: RollupPutJobRequest, value: string) =
            { state with Cron = value }

        [<CustomOperation("groups")>]
        member _.Groups(state: RollupPutJobRequest, value: Types.Groupings) =
            { state with Groups = value }

        [<CustomOperation("indexPattern")>]
        member _.IndexPattern(state: RollupPutJobRequest, value: string) =
            { state with IndexPattern = value }

        [<CustomOperation("metrics")>]
        member _.Metrics(state: RollupPutJobRequest, value: Types.FieldMetric list) =
            { state with Metrics = Some value }

        [<CustomOperation("pageSize")>]
        member _.PageSize(state: RollupPutJobRequest, value: Types.Integer) =
            { state with PageSize = value }

        [<CustomOperation("rollupIndex")>]
        member _.RollupIndex(state: RollupPutJobRequest, value: Types.IndexName) =
            { state with RollupIndex = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: RollupPutJobRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("headers")>]
        member _.Headers(state: RollupPutJobRequest, value: Types.HttpHeaders) =
            { state with Headers = Some value }

    let rollupPutJobRequest = RollupPutJobRequestBuilder()

    module PutJob =
        let withCron (value: string) (req: RollupPutJobRequest) =
            { req with Cron = value }
        let withGroups (value: Types.Groupings) (req: RollupPutJobRequest) =
            { req with Groups = value }
        let withIndexPattern (value: string) (req: RollupPutJobRequest) =
            { req with IndexPattern = value }
        let withMetrics (value: Types.FieldMetric list) (req: RollupPutJobRequest) =
            { req with Metrics = Some value }
        let withPageSize (value: Types.Integer) (req: RollupPutJobRequest) =
            { req with PageSize = value }
        let withRollupIndex (value: Types.IndexName) (req: RollupPutJobRequest) =
            { req with RollupIndex = value }
        let withTimeout (value: Types.Duration) (req: RollupPutJobRequest) =
            { req with Timeout = Some value }
        let withHeaders (value: Types.HttpHeaders) (req: RollupPutJobRequest) =
            { req with Headers = Some value }

    type RollupRollupSearchRequest = {
        Index: Types.Indices
        RestTotalHitsAsInt: bool option
        TypedKeys: bool option
        Aggregations: Map<string, Types.AggregationContainer> option
        Query: Types.QueryContainer option
        Size: Types.Integer option
    }

        with
        static member ToRequest(req: RollupRollupSearchRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_rollup_search"
                let queryParams =
                    [
                        req.RestTotalHitsAsInt |> Option.map (fun v -> "rest_total_hits_as_int", Fes.Http.toQueryValue v)
                        req.TypedKeys |> Option.map (fun v -> "typed_keys", Fes.Http.toQueryValue v)
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

    type RollupRollupSearchResponse = System.Text.Json.JsonElement

    type RollupRollupSearchRequestBuilder() =
        member _.Yield(_: unit) : RollupRollupSearchRequest =
            {
                Index = Unchecked.defaultof<_>
                RestTotalHitsAsInt = None
                TypedKeys = None
                Aggregations = None
                Query = None
                Size = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: RollupRollupSearchRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("restTotalHitsAsInt")>]
        member _.RestTotalHitsAsInt(state: RollupRollupSearchRequest, value: bool) =
            { state with RestTotalHitsAsInt = Some value }

        [<CustomOperation("typedKeys")>]
        member _.TypedKeys(state: RollupRollupSearchRequest, value: bool) =
            { state with TypedKeys = Some value }

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: RollupRollupSearchRequest, value: Map<string, Types.AggregationContainer>) =
            { state with Aggregations = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: RollupRollupSearchRequest, value: Types.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: RollupRollupSearchRequest, value: Types.Integer) =
            { state with Size = Some value }

    let rollupRollupSearchRequest = RollupRollupSearchRequestBuilder()

    module RollupSearch =
        let withRestTotalHitsAsInt (value: bool) (req: RollupRollupSearchRequest) =
            { req with RestTotalHitsAsInt = Some value }
        let withTypedKeys (value: bool) (req: RollupRollupSearchRequest) =
            { req with TypedKeys = Some value }
        let withAggregations (value: Map<string, Types.AggregationContainer>) (req: RollupRollupSearchRequest) =
            { req with Aggregations = Some value }
        let withQuery (value: Types.QueryContainer) (req: RollupRollupSearchRequest) =
            { req with Query = Some value }
        let withSize (value: Types.Integer) (req: RollupRollupSearchRequest) =
            { req with Size = Some value }

    type RollupStartJobRequest = {
        Id: Types.Id
    }

        with
        static member ToRequest(req: RollupStartJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_rollup/job/{req.Id}/_start"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type RollupStartJobResponse = System.Text.Json.JsonElement

    type RollupStartJobRequestBuilder() =
        member _.Yield(_: unit) : RollupStartJobRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: RollupStartJobRequest, value: Types.Id) =
            { state with Id = value }

    let rollupStartJobRequest = RollupStartJobRequestBuilder()

    type RollupStopJobRequest = {
        Id: Types.Id
        Timeout: Types.Duration option
        WaitForCompletion: bool option
    }

        with
        static member ToRequest(req: RollupStopJobRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_rollup/job/{req.Id}/_stop"
                let queryParams =
                    [
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        req.WaitForCompletion |> Option.map (fun v -> "wait_for_completion", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type RollupStopJobResponse = System.Text.Json.JsonElement

    type RollupStopJobRequestBuilder() =
        member _.Yield(_: unit) : RollupStopJobRequest =
            {
                Id = Unchecked.defaultof<_>
                Timeout = None
                WaitForCompletion = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: RollupStopJobRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: RollupStopJobRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("waitForCompletion")>]
        member _.WaitForCompletion(state: RollupStopJobRequest, value: bool) =
            { state with WaitForCompletion = Some value }

    let rollupStopJobRequest = RollupStopJobRequestBuilder()

    module StopJob =
        let withTimeout (value: Types.Duration) (req: RollupStopJobRequest) =
            { req with Timeout = Some value }
        let withWaitForCompletion (value: bool) (req: RollupStopJobRequest) =
            { req with WaitForCompletion = Some value }


// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module LogstashOperations =

    type LogstashGetPipelineRequest = {
        Id: Ids
    } with
        static member ToRequest(request: LogstashGetPipelineRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_logstash/pipeline/{request.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module LogstashGetPipelineRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: LogstashGetPipelineRequest) : Result<Fes.Http.RequestMsg, exn> =
            LogstashGetPipelineRequest.ToRequest request

    type LogstashGetPipelineRequestBuilder() =
        member _.Yield(_: unit) : LogstashGetPipelineRequest =
            {
                LogstashGetPipelineRequest.Id = Unchecked.defaultof<Ids>
            } : LogstashGetPipelineRequest

        [<CustomOperation("id")>]
        member _.Id(state: LogstashGetPipelineRequest, value: Ids) =
            { state with LogstashGetPipelineRequest.Id = value } : LogstashGetPipelineRequest

    let logstashGetPipelineRequest = LogstashGetPipelineRequestBuilder()

    type LogstashPutPipelineRequest = {
        Id: Id
        [<JsonPropertyName("body")>]
        Body: TypesPipeline
    } with
        static member ToRequest(request: LogstashPutPipelineRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_logstash/pipeline/{request.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request.Body
                |> Result.Ok
            with ex -> Result.Error ex

    module LogstashPutPipelineRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: LogstashPutPipelineRequest) : Result<Fes.Http.RequestMsg, exn> =
            LogstashPutPipelineRequest.ToRequest request

    type LogstashPutPipelineRequestBuilder() =
        member _.Yield(_: unit) : LogstashPutPipelineRequest =
            {
                LogstashPutPipelineRequest.Id = Unchecked.defaultof<Id>
                LogstashPutPipelineRequest.Body = Unchecked.defaultof<TypesPipeline>
            } : LogstashPutPipelineRequest

        [<CustomOperation("id")>]
        member _.Id(state: LogstashPutPipelineRequest, value: Id) =
            { state with LogstashPutPipelineRequest.Id = value } : LogstashPutPipelineRequest

        [<CustomOperation("body")>]
        member _.Body(state: LogstashPutPipelineRequest, value: TypesPipeline) =
            { state with LogstashPutPipelineRequest.Body = value } : LogstashPutPipelineRequest

    let logstashPutPipelineRequest = LogstashPutPipelineRequestBuilder()

    type LogstashDeletePipelineRequest = {
        Id: Id
    } with
        static member ToRequest(request: LogstashDeletePipelineRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_logstash/pipeline/{request.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module LogstashDeletePipelineRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: LogstashDeletePipelineRequest) : Result<Fes.Http.RequestMsg, exn> =
            LogstashDeletePipelineRequest.ToRequest request

    type LogstashDeletePipelineRequestBuilder() =
        member _.Yield(_: unit) : LogstashDeletePipelineRequest =
            {
                LogstashDeletePipelineRequest.Id = Unchecked.defaultof<Id>
            } : LogstashDeletePipelineRequest

        [<CustomOperation("id")>]
        member _.Id(state: LogstashDeletePipelineRequest, value: Id) =
            { state with LogstashDeletePipelineRequest.Id = value } : LogstashDeletePipelineRequest

    let logstashDeletePipelineRequest = LogstashDeletePipelineRequestBuilder()


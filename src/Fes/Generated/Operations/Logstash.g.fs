// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module LogstashOperations =

    type LogstashDeletePipelineRequest = {
        Id: Types.Id
    }

        with
        static member ToRequest(req: LogstashDeletePipelineRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_logstash/pipeline/{req.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type LogstashDeletePipelineResponse = unit

    type LogstashDeletePipelineRequestBuilder() =
        member _.Yield(_: unit) : LogstashDeletePipelineRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: LogstashDeletePipelineRequest, value: Types.Id) =
            { state with Id = value }

    let logstashDeletePipelineRequest = LogstashDeletePipelineRequestBuilder()

    type LogstashGetPipelineRequest = {
        Id: Types.Ids
    }

        with
        static member ToRequest(req: LogstashGetPipelineRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_logstash/pipeline/{req.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type LogstashGetPipelineResponse = Map<Types.Id, Types.LogstashTypesPipeline>

    type LogstashGetPipelineRequestBuilder() =
        member _.Yield(_: unit) : LogstashGetPipelineRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: LogstashGetPipelineRequest, value: Types.Ids) =
            { state with Id = value }

    let logstashGetPipelineRequest = LogstashGetPipelineRequestBuilder()

    type LogstashPutPipelineRequest = {
        Id: Types.Id
        Document: obj
    }

        with
        static member ToRequest(req: LogstashPutPipelineRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_logstash/pipeline/{req.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type LogstashPutPipelineResponse = unit

    type LogstashPutPipelineRequestBuilder() =
        member _.Yield(_: unit) : LogstashPutPipelineRequest =
            {
                Id = Unchecked.defaultof<_>
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: LogstashPutPipelineRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("document")>]
        member _.Document(state: LogstashPutPipelineRequest, value) =
            { state with Document = value }

    let logstashPutPipelineRequest = LogstashPutPipelineRequestBuilder()


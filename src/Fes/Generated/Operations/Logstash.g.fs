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
        static member ToEndpoint(req: LogstashDeletePipelineRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_logstash/pipeline/{Fes.Http.toPathSegment req.Id}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

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
        static member ToEndpoint(req: LogstashGetPipelineRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_logstash/pipeline/{Fes.Http.toPathSegment req.Id}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

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
        Document: Types.LogstashTypesPipeline
    }

        with
        static member ToEndpoint(req: LogstashPutPipelineRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_logstash/pipeline/{Fes.Http.toPathSegment req.Id}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req.Document)
            endpoint, ValueSome postData

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


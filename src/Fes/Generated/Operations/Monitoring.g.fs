// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module MonitoringOperations =

    type MonitoringBulkRequest<'TDocument, 'TPartialDocument> = {
        SystemId: string
        SystemApiVersion: string
        Interval: Types.Duration
        Document: System.Text.Json.JsonElement list
    }

        with
        static member ToEndpoint(req: MonitoringBulkRequest<'TDocument, 'TPartialDocument>) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_monitoring/bulk"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req.Document)
            endpoint, ValueSome postData

    type MonitoringBulkResponse = System.Text.Json.JsonElement

    type MonitoringBulkRequestBuilder() =
        member _.Yield(_: unit) : MonitoringBulkRequest<_, _> =
            {
                SystemId = Unchecked.defaultof<_>
                SystemApiVersion = Unchecked.defaultof<_>
                Interval = Unchecked.defaultof<_>
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("systemId")>]
        member _.SystemId(state: MonitoringBulkRequest<_, _>, value: string) =
            { state with SystemId = value }

        [<CustomOperation("systemApiVersion")>]
        member _.SystemApiVersion(state: MonitoringBulkRequest<_, _>, value: string) =
            { state with SystemApiVersion = value }

        [<CustomOperation("interval")>]
        member _.Interval(state: MonitoringBulkRequest<_, _>, value: Types.Duration) =
            { state with Interval = value }

        [<CustomOperation("document")>]
        member _.Document(state: MonitoringBulkRequest<_, _>, value) =
            { state with Document = value }

    let monitoringBulkRequest = MonitoringBulkRequestBuilder()

    module Bulk =
        let withSystemId (value: string) (req: MonitoringBulkRequest<_, _>) =
            { req with SystemId = value }
        let withSystemApiVersion (value: string) (req: MonitoringBulkRequest<_, _>) =
            { req with SystemApiVersion = value }
        let withInterval (value: Types.Duration) (req: MonitoringBulkRequest<_, _>) =
            { req with Interval = value }

// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module MonitoringOperations =

    type MonitoringBulkRequest = {
        SystemId: string
        SystemApiVersion: string
        Interval: CoreTypes.Duration
        Document: obj
    }

        with
        static member ToRequest(req: MonitoringBulkRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_monitoring/bulk"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type MonitoringBulkResponse = System.Text.Json.JsonElement

    type MonitoringBulkRequestBuilder() =
        member _.Yield(_: unit) : MonitoringBulkRequest =
            {
                SystemId = Unchecked.defaultof<_>
                SystemApiVersion = Unchecked.defaultof<_>
                Interval = Unchecked.defaultof<_>
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("systemId")>]
        member _.SystemId(state: MonitoringBulkRequest, value: string) =
            { state with SystemId = value }

        [<CustomOperation("systemApiVersion")>]
        member _.SystemApiVersion(state: MonitoringBulkRequest, value: string) =
            { state with SystemApiVersion = value }

        [<CustomOperation("interval")>]
        member _.Interval(state: MonitoringBulkRequest, value: CoreTypes.Duration) =
            { state with Interval = value }

        [<CustomOperation("document")>]
        member _.Document(state: MonitoringBulkRequest, value) =
            { state with Document = value }

    let monitoringBulkRequest = MonitoringBulkRequestBuilder()

    module Bulk =
        let withSystemId (value: string) (req: MonitoringBulkRequest) =
            { req with SystemId = value }
        let withSystemApiVersion (value: string) (req: MonitoringBulkRequest) =
            { req with SystemApiVersion = value }
        let withInterval (value: CoreTypes.Duration) (req: MonitoringBulkRequest) =
            { req with Interval = value }


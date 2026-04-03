// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module MonitoringOperations =

    type MonitoringBulkRequest<'tDocument, 'tPartialDocument> = {
        SystemId: string
        SystemApiVersion: string
        Interval: Types.Duration
        Document: obj
    }

    type MonitoringBulkResponse = System.Text.Json.JsonElement


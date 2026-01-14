// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module HealthReportOperations =

    type HealthReportRequest = {
        Feature: System.Text.Json.JsonElement
        Timeout: Duration option
        Verbose: bool option
        Size: float option
    } with
        static member ToRequest(request: HealthReportRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_health_report/{request.Feature}"
                let queryParams =
                    [
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                        request.Verbose |> Option.map (fun v -> "verbose", Fes.Http.toQueryValue v)
                        request.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
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

    module HealthReportRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: HealthReportRequest) : Result<Fes.Http.RequestMsg, exn> =
            HealthReportRequest.ToRequest request

    type HealthReportRequestBuilder() =
        member _.Yield(_: unit) : HealthReportRequest =
            {
                HealthReportRequest.Feature = Unchecked.defaultof<System.Text.Json.JsonElement>
                HealthReportRequest.Timeout = Option.None
                HealthReportRequest.Verbose = Option.None
                HealthReportRequest.Size = Option.None
            } : HealthReportRequest

        [<CustomOperation("feature")>]
        member _.Feature(state: HealthReportRequest, value: System.Text.Json.JsonElement) =
            { state with HealthReportRequest.Feature = value } : HealthReportRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: HealthReportRequest, value: Duration) =
            { state with HealthReportRequest.Timeout = Option.Some value } : HealthReportRequest

        [<CustomOperation("verbose")>]
        member _.Verbose(state: HealthReportRequest, value: bool) =
            { state with HealthReportRequest.Verbose = Option.Some value } : HealthReportRequest

        [<CustomOperation("size")>]
        member _.Size(state: HealthReportRequest, value: float) =
            { state with HealthReportRequest.Size = Option.Some value } : HealthReportRequest

    let healthReportRequest = HealthReportRequestBuilder()


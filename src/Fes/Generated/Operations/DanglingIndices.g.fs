// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module DanglingIndicesOperations =

    type DanglingIndicesDeleteDanglingIndexRequest = {
        IndexUuid: Types.Uuid
        AcceptDataLoss: bool option
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: DanglingIndicesDeleteDanglingIndexRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_dangling/{req.IndexUuid}"
                let queryParams =
                    [
                        req.AcceptDataLoss |> Option.map (fun v -> "accept_data_loss", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type DanglingIndicesDeleteDanglingIndexResponse = Types.AcknowledgedResponseBase

    type DanglingIndicesDeleteDanglingIndexRequestBuilder() =
        member _.Yield(_: unit) : DanglingIndicesDeleteDanglingIndexRequest =
            {
                IndexUuid = Unchecked.defaultof<_>
                AcceptDataLoss = None
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("indexUuid")>]
        member _.IndexUuid(state: DanglingIndicesDeleteDanglingIndexRequest, value: Types.Uuid) =
            { state with IndexUuid = value }

        [<CustomOperation("acceptDataLoss")>]
        member _.AcceptDataLoss(state: DanglingIndicesDeleteDanglingIndexRequest, value: bool) =
            { state with AcceptDataLoss = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: DanglingIndicesDeleteDanglingIndexRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: DanglingIndicesDeleteDanglingIndexRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let danglingIndicesDeleteDanglingIndexRequest = DanglingIndicesDeleteDanglingIndexRequestBuilder()

    module DeleteDanglingIndex =
        let withAcceptDataLoss (value: bool) (req: DanglingIndicesDeleteDanglingIndexRequest) =
            { req with AcceptDataLoss = Some value }
        let withMasterTimeout (value: Types.Duration) (req: DanglingIndicesDeleteDanglingIndexRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: DanglingIndicesDeleteDanglingIndexRequest) =
            { req with Timeout = Some value }

    type DanglingIndicesImportDanglingIndexRequest = {
        IndexUuid: Types.Uuid
        AcceptDataLoss: bool option
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: DanglingIndicesImportDanglingIndexRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_dangling/{req.IndexUuid}"
                let queryParams =
                    [
                        req.AcceptDataLoss |> Option.map (fun v -> "accept_data_loss", Fes.Http.toQueryValue v)
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
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

    type DanglingIndicesImportDanglingIndexResponse = Types.AcknowledgedResponseBase

    type DanglingIndicesImportDanglingIndexRequestBuilder() =
        member _.Yield(_: unit) : DanglingIndicesImportDanglingIndexRequest =
            {
                IndexUuid = Unchecked.defaultof<_>
                AcceptDataLoss = None
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("indexUuid")>]
        member _.IndexUuid(state: DanglingIndicesImportDanglingIndexRequest, value: Types.Uuid) =
            { state with IndexUuid = value }

        [<CustomOperation("acceptDataLoss")>]
        member _.AcceptDataLoss(state: DanglingIndicesImportDanglingIndexRequest, value: bool) =
            { state with AcceptDataLoss = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: DanglingIndicesImportDanglingIndexRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: DanglingIndicesImportDanglingIndexRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let danglingIndicesImportDanglingIndexRequest = DanglingIndicesImportDanglingIndexRequestBuilder()

    module ImportDanglingIndex =
        let withAcceptDataLoss (value: bool) (req: DanglingIndicesImportDanglingIndexRequest) =
            { req with AcceptDataLoss = Some value }
        let withMasterTimeout (value: Types.Duration) (req: DanglingIndicesImportDanglingIndexRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: DanglingIndicesImportDanglingIndexRequest) =
            { req with Timeout = Some value }

    type DanglingIndicesListDanglingIndicesRequest = | DanglingIndicesListDanglingIndicesRequest

        with
        static member ToRequest(req: DanglingIndicesListDanglingIndicesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_dangling"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type DanglingIndicesListDanglingIndicesResponse = System.Text.Json.JsonElement

    type DanglingIndicesListDanglingIndicesRequestBuilder() =
        member _.Yield(_: unit) : DanglingIndicesListDanglingIndicesRequest =
            {
            }

    let danglingIndicesListDanglingIndicesRequest = DanglingIndicesListDanglingIndicesRequestBuilder()


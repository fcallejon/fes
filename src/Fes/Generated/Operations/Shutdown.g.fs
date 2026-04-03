// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module ShutdownOperations =

    type ShutdownDeleteNodeRequest = {
        NodeId: Types.NodeId
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToRequest(req: ShutdownDeleteNodeRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_nodes/{req.NodeId}/shutdown"
                let queryParams =
                    [
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

    type ShutdownDeleteNodeResponse = Types.AcknowledgedResponseBase

    type ShutdownDeleteNodeRequestBuilder() =
        member _.Yield(_: unit) : ShutdownDeleteNodeRequest =
            {
                NodeId = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: ShutdownDeleteNodeRequest, value: Types.NodeId) =
            { state with NodeId = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: ShutdownDeleteNodeRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: ShutdownDeleteNodeRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let shutdownDeleteNodeRequest = ShutdownDeleteNodeRequestBuilder()

    module DeleteNode =
        let withMasterTimeout (value: Types.Duration) (req: ShutdownDeleteNodeRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: ShutdownDeleteNodeRequest) =
            { req with Timeout = Some value }

    type ShutdownGetNodeRequest = {
        NodeId: Types.NodeIds
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: ShutdownGetNodeRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_nodes/{req.NodeId}/shutdown"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type ShutdownGetNodeResponse = System.Text.Json.JsonElement

    type ShutdownGetNodeRequestBuilder() =
        member _.Yield(_: unit) : ShutdownGetNodeRequest =
            {
                NodeId = Unchecked.defaultof<_>
                MasterTimeout = None
            }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: ShutdownGetNodeRequest, value: Types.NodeIds) =
            { state with NodeId = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: ShutdownGetNodeRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let shutdownGetNodeRequest = ShutdownGetNodeRequestBuilder()

    module GetNode =
        let withMasterTimeout (value: Types.Duration) (req: ShutdownGetNodeRequest) =
            { req with MasterTimeout = Some value }

    type ShutdownPutNodeRequest = {
        NodeId: Types.NodeId
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        Type: ShutdownTypes.Type
        Reason: string
        AllocationDelay: string option
        TargetNodeName: string option
    }

        with
        static member ToRequest(req: ShutdownPutNodeRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_nodes/{req.NodeId}/shutdown"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ShutdownPutNodeResponse = Types.AcknowledgedResponseBase

    type ShutdownPutNodeRequestBuilder() =
        member _.Yield(_: unit) : ShutdownPutNodeRequest =
            {
                NodeId = Unchecked.defaultof<_>
                MasterTimeout = None
                Timeout = None
                Type = Unchecked.defaultof<_>
                Reason = Unchecked.defaultof<_>
                AllocationDelay = None
                TargetNodeName = None
            }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: ShutdownPutNodeRequest, value: Types.NodeId) =
            { state with NodeId = value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: ShutdownPutNodeRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: ShutdownPutNodeRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: ShutdownPutNodeRequest, value: ShutdownTypes.Type) =
            { state with Type = value }

        [<CustomOperation("reason")>]
        member _.Reason(state: ShutdownPutNodeRequest, value: string) =
            { state with Reason = value }

        [<CustomOperation("allocationDelay")>]
        member _.AllocationDelay(state: ShutdownPutNodeRequest, value: string) =
            { state with AllocationDelay = Some value }

        [<CustomOperation("targetNodeName")>]
        member _.TargetNodeName(state: ShutdownPutNodeRequest, value: string) =
            { state with TargetNodeName = Some value }

    let shutdownPutNodeRequest = ShutdownPutNodeRequestBuilder()

    module PutNode =
        let withMasterTimeout (value: Types.Duration) (req: ShutdownPutNodeRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: ShutdownPutNodeRequest) =
            { req with Timeout = Some value }
        let withType (value: ShutdownTypes.Type) (req: ShutdownPutNodeRequest) =
            { req with Type = value }
        let withReason (value: string) (req: ShutdownPutNodeRequest) =
            { req with Reason = value }
        let withAllocationDelay (value: string) (req: ShutdownPutNodeRequest) =
            { req with AllocationDelay = Some value }
        let withTargetNodeName (value: string) (req: ShutdownPutNodeRequest) =
            { req with TargetNodeName = Some value }


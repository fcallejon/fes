// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module IndicesOperations =

    type IndicesAddBlockRequest = {
        Index: Types.Indices
        Block: Types.IndicesBlockOptions
        AllowNoIndices: bool option
        ExpandWildcards: Types.ExpandWildcards option
        IgnoreUnavailable: bool option
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
    }

        with
        static member ToEndpoint(req: IndicesAddBlockRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_block/{Fes.Http.toPathSegment req.Block}"
            let queryParams =
                [
                    req.AllowNoIndices |> Option.map (fun v -> "allow_no_indices", Fes.Http.toQueryValue v)
                    req.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", Fes.Http.toQueryValue v)
                    req.IgnoreUnavailable |> Option.map (fun v -> "ignore_unavailable", Fes.Http.toQueryValue v)
                    req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                    req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            endpoint, ValueNone

    type IndicesAddBlockResponse = System.Text.Json.JsonElement

    type IndicesAddBlockRequestBuilder() =
        member _.Yield(_: unit) : IndicesAddBlockRequest =
            {
                Index = Unchecked.defaultof<_>
                Block = Unchecked.defaultof<_>
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreUnavailable = None
                MasterTimeout = None
                Timeout = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesAddBlockRequest, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("block")>]
        member _.Block(state: IndicesAddBlockRequest, value: Types.IndicesBlockOptions) =
            { state with Block = value }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesAddBlockRequest, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesAddBlockRequest, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesAddBlockRequest, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: IndicesAddBlockRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesAddBlockRequest, value: Types.Duration) =
            { state with Timeout = Some value }

    let indicesAddBlockRequest = IndicesAddBlockRequestBuilder()

    module AddBlock =
        let withAllowNoIndices (value: bool) (req: IndicesAddBlockRequest) =
            { req with AllowNoIndices = Some value }
        let withExpandWildcards (value: Types.ExpandWildcards) (req: IndicesAddBlockRequest) =
            { req with ExpandWildcards = Some value }
        let withIgnoreUnavailable (value: bool) (req: IndicesAddBlockRequest) =
            { req with IgnoreUnavailable = Some value }
        let withMasterTimeout (value: Types.Duration) (req: IndicesAddBlockRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: IndicesAddBlockRequest) =
            { req with Timeout = Some value }
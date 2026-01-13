// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module DataStreamOperations =

    type IndicesGetDataStreamRequest = {
        [<JsonPropertyName("name")>]
        Name: DataStreamNames
        [<JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: ExpandWildcards option
        [<JsonPropertyName("include_defaults")>]
        IncludeDefaults: bool option
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
        [<JsonPropertyName("verbose")>]
        Verbose: bool option
    } with
        static member ToRequest(request: IndicesGetDataStreamRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{request.Name}"
                let queryParams =
                    [
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", string v)
                        request.IncludeDefaults |> Option.map (fun v -> "include_defaults", string v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                        request.Verbose |> Option.map (fun v -> "verbose", string v)
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

    module IndicesGetDataStreamRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesGetDataStreamRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesGetDataStreamRequest.ToRequest request

    type IndicesGetDataStreamRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetDataStreamRequest =
            {
                IndicesGetDataStreamRequest.Name = Unchecked.defaultof<DataStreamNames>
                IndicesGetDataStreamRequest.ExpandWildcards = Option.None
                IndicesGetDataStreamRequest.IncludeDefaults = Option.None
                IndicesGetDataStreamRequest.MasterTimeout = Option.None
                IndicesGetDataStreamRequest.Verbose = Option.None
            } : IndicesGetDataStreamRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesGetDataStreamRequest, value: DataStreamNames) =
            { state with IndicesGetDataStreamRequest.Name = value } : IndicesGetDataStreamRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesGetDataStreamRequest, value: ExpandWildcards) =
            { state with IndicesGetDataStreamRequest.ExpandWildcards = Option.Some value } : IndicesGetDataStreamRequest

        [<CustomOperation("include_defaults")>]
        member _.IncludeDefaults(state: IndicesGetDataStreamRequest, value: bool) =
            { state with IndicesGetDataStreamRequest.IncludeDefaults = Option.Some value } : IndicesGetDataStreamRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesGetDataStreamRequest, value: Duration) =
            { state with IndicesGetDataStreamRequest.MasterTimeout = Option.Some value } : IndicesGetDataStreamRequest

        [<CustomOperation("verbose")>]
        member _.Verbose(state: IndicesGetDataStreamRequest, value: bool) =
            { state with IndicesGetDataStreamRequest.Verbose = Option.Some value } : IndicesGetDataStreamRequest

    let indicesGetDataStreamRequest = IndicesGetDataStreamRequestBuilder()

    type IndicesCreateDataStreamRequest = {
        [<JsonPropertyName("name")>]
        Name: DataStreamName
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
    } with
        static member ToRequest(request: IndicesCreateDataStreamRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{request.Name}"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesCreateDataStreamRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesCreateDataStreamRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesCreateDataStreamRequest.ToRequest request

    type IndicesCreateDataStreamRequestBuilder() =
        member _.Yield(_: unit) : IndicesCreateDataStreamRequest =
            {
                IndicesCreateDataStreamRequest.Name = Unchecked.defaultof<DataStreamName>
                IndicesCreateDataStreamRequest.MasterTimeout = Option.None
                IndicesCreateDataStreamRequest.Timeout = Option.None
            } : IndicesCreateDataStreamRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesCreateDataStreamRequest, value: DataStreamName) =
            { state with IndicesCreateDataStreamRequest.Name = value } : IndicesCreateDataStreamRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesCreateDataStreamRequest, value: Duration) =
            { state with IndicesCreateDataStreamRequest.MasterTimeout = Option.Some value } : IndicesCreateDataStreamRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesCreateDataStreamRequest, value: Duration) =
            { state with IndicesCreateDataStreamRequest.Timeout = Option.Some value } : IndicesCreateDataStreamRequest

    let indicesCreateDataStreamRequest = IndicesCreateDataStreamRequestBuilder()

    type IndicesCreateDataStreamResponse = AcknowledgedResponseBase

    type IndicesDeleteDataStreamRequest = {
        [<JsonPropertyName("name")>]
        Name: DataStreamNames
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
        [<JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: ExpandWildcards option
    } with
        static member ToRequest(request: IndicesDeleteDataStreamRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{request.Name}"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesDeleteDataStreamRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesDeleteDataStreamRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesDeleteDataStreamRequest.ToRequest request

    type IndicesDeleteDataStreamRequestBuilder() =
        member _.Yield(_: unit) : IndicesDeleteDataStreamRequest =
            {
                IndicesDeleteDataStreamRequest.Name = Unchecked.defaultof<DataStreamNames>
                IndicesDeleteDataStreamRequest.MasterTimeout = Option.None
                IndicesDeleteDataStreamRequest.ExpandWildcards = Option.None
            } : IndicesDeleteDataStreamRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesDeleteDataStreamRequest, value: DataStreamNames) =
            { state with IndicesDeleteDataStreamRequest.Name = value } : IndicesDeleteDataStreamRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesDeleteDataStreamRequest, value: Duration) =
            { state with IndicesDeleteDataStreamRequest.MasterTimeout = Option.Some value } : IndicesDeleteDataStreamRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesDeleteDataStreamRequest, value: ExpandWildcards) =
            { state with IndicesDeleteDataStreamRequest.ExpandWildcards = Option.Some value } : IndicesDeleteDataStreamRequest

    let indicesDeleteDataStreamRequest = IndicesDeleteDataStreamRequestBuilder()

    type IndicesDeleteDataStreamResponse = AcknowledgedResponseBase

    type IndicesDataStreamsStatsRequest = {
        [<JsonPropertyName("name")>]
        Name: Indices
        [<JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: ExpandWildcards option
    } with
        static member ToRequest(request: IndicesDataStreamsStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{request.Name}/_stats"
                let queryParams =
                    [
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", string v)
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

    module IndicesDataStreamsStatsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesDataStreamsStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesDataStreamsStatsRequest.ToRequest request

    type IndicesDataStreamsStatsRequestBuilder() =
        member _.Yield(_: unit) : IndicesDataStreamsStatsRequest =
            {
                IndicesDataStreamsStatsRequest.Name = Unchecked.defaultof<Indices>
                IndicesDataStreamsStatsRequest.ExpandWildcards = Option.None
            } : IndicesDataStreamsStatsRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesDataStreamsStatsRequest, value: Indices) =
            { state with IndicesDataStreamsStatsRequest.Name = value } : IndicesDataStreamsStatsRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesDataStreamsStatsRequest, value: ExpandWildcards) =
            { state with IndicesDataStreamsStatsRequest.ExpandWildcards = Option.Some value } : IndicesDataStreamsStatsRequest

    let indicesDataStreamsStatsRequest = IndicesDataStreamsStatsRequestBuilder()

    type IndicesGetDataLifecycleRequest = {
        [<JsonPropertyName("name")>]
        Name: DataStreamNames
        [<JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: ExpandWildcards option
        [<JsonPropertyName("include_defaults")>]
        IncludeDefaults: bool option
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: IndicesGetDataLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{request.Name}/_lifecycle"
                let queryParams =
                    [
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", string v)
                        request.IncludeDefaults |> Option.map (fun v -> "include_defaults", string v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
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

    module IndicesGetDataLifecycleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesGetDataLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesGetDataLifecycleRequest.ToRequest request

    type IndicesGetDataLifecycleRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetDataLifecycleRequest =
            {
                IndicesGetDataLifecycleRequest.Name = Unchecked.defaultof<DataStreamNames>
                IndicesGetDataLifecycleRequest.ExpandWildcards = Option.None
                IndicesGetDataLifecycleRequest.IncludeDefaults = Option.None
                IndicesGetDataLifecycleRequest.MasterTimeout = Option.None
            } : IndicesGetDataLifecycleRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesGetDataLifecycleRequest, value: DataStreamNames) =
            { state with IndicesGetDataLifecycleRequest.Name = value } : IndicesGetDataLifecycleRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesGetDataLifecycleRequest, value: ExpandWildcards) =
            { state with IndicesGetDataLifecycleRequest.ExpandWildcards = Option.Some value } : IndicesGetDataLifecycleRequest

        [<CustomOperation("include_defaults")>]
        member _.IncludeDefaults(state: IndicesGetDataLifecycleRequest, value: bool) =
            { state with IndicesGetDataLifecycleRequest.IncludeDefaults = Option.Some value } : IndicesGetDataLifecycleRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesGetDataLifecycleRequest, value: Duration) =
            { state with IndicesGetDataLifecycleRequest.MasterTimeout = Option.Some value } : IndicesGetDataLifecycleRequest

    let indicesGetDataLifecycleRequest = IndicesGetDataLifecycleRequestBuilder()

    type IndicesGetDataLifecycleResponse = {
        [<JsonPropertyName("data_streams")>]
        DataStreams: GetDataLifecycleDataStreamWithLifecycle array
    }

    type IndicesPutDataLifecycleRequest = {
        [<JsonPropertyName("name")>]
        Name: DataStreamNames
        [<JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: ExpandWildcards option
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
        [<JsonPropertyName("data_retention")>]
        DataRetention: Duration option
        [<JsonPropertyName("downsampling")>]
        Downsampling: TypesDownsamplingRound array option
        [<JsonPropertyName("downsampling_method")>]
        DownsamplingMethod: TypesSamplingMethod option
        [<JsonPropertyName("enabled")>]
        Enabled: bool option
    } with
        static member ToRequest(request: IndicesPutDataLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{request.Name}/_lifecycle"
                let queryParams =
                    [
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", string v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesPutDataLifecycleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesPutDataLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesPutDataLifecycleRequest.ToRequest request

    type IndicesPutDataLifecycleRequestBuilder() =
        member _.Yield(_: unit) : IndicesPutDataLifecycleRequest =
            {
                IndicesPutDataLifecycleRequest.Name = Unchecked.defaultof<DataStreamNames>
                IndicesPutDataLifecycleRequest.ExpandWildcards = Option.None
                IndicesPutDataLifecycleRequest.MasterTimeout = Option.None
                IndicesPutDataLifecycleRequest.Timeout = Option.None
                IndicesPutDataLifecycleRequest.DataRetention = Option.None
                IndicesPutDataLifecycleRequest.Downsampling = Option.None
                IndicesPutDataLifecycleRequest.DownsamplingMethod = Option.None
                IndicesPutDataLifecycleRequest.Enabled = Option.None
            } : IndicesPutDataLifecycleRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesPutDataLifecycleRequest, value: DataStreamNames) =
            { state with IndicesPutDataLifecycleRequest.Name = value } : IndicesPutDataLifecycleRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesPutDataLifecycleRequest, value: ExpandWildcards) =
            { state with IndicesPutDataLifecycleRequest.ExpandWildcards = Option.Some value } : IndicesPutDataLifecycleRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesPutDataLifecycleRequest, value: Duration) =
            { state with IndicesPutDataLifecycleRequest.MasterTimeout = Option.Some value } : IndicesPutDataLifecycleRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesPutDataLifecycleRequest, value: Duration) =
            { state with IndicesPutDataLifecycleRequest.Timeout = Option.Some value } : IndicesPutDataLifecycleRequest

        [<CustomOperation("data_retention")>]
        member _.DataRetention(state: IndicesPutDataLifecycleRequest, value: Duration) =
            { state with IndicesPutDataLifecycleRequest.DataRetention = Option.Some value } : IndicesPutDataLifecycleRequest

        [<CustomOperation("downsampling")>]
        member _.Downsampling(state: IndicesPutDataLifecycleRequest, value: TypesDownsamplingRound array) =
            { state with IndicesPutDataLifecycleRequest.Downsampling = Option.Some value } : IndicesPutDataLifecycleRequest

        [<CustomOperation("downsampling_method")>]
        member _.DownsamplingMethod(state: IndicesPutDataLifecycleRequest, value: TypesSamplingMethod) =
            { state with IndicesPutDataLifecycleRequest.DownsamplingMethod = Option.Some value } : IndicesPutDataLifecycleRequest

        [<CustomOperation("enabled")>]
        member _.Enabled(state: IndicesPutDataLifecycleRequest, value: bool) =
            { state with IndicesPutDataLifecycleRequest.Enabled = Option.Some value } : IndicesPutDataLifecycleRequest

    let indicesPutDataLifecycleRequest = IndicesPutDataLifecycleRequestBuilder()

    type IndicesPutDataLifecycleResponse = AcknowledgedResponseBase

    type IndicesGetDataStreamOptionsRequest = {
        [<JsonPropertyName("name")>]
        Name: DataStreamNames
        [<JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: ExpandWildcards option
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: IndicesGetDataStreamOptionsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{request.Name}/_options"
                let queryParams =
                    [
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", string v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
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

    module IndicesGetDataStreamOptionsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesGetDataStreamOptionsRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesGetDataStreamOptionsRequest.ToRequest request

    type IndicesGetDataStreamOptionsRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetDataStreamOptionsRequest =
            {
                IndicesGetDataStreamOptionsRequest.Name = Unchecked.defaultof<DataStreamNames>
                IndicesGetDataStreamOptionsRequest.ExpandWildcards = Option.None
                IndicesGetDataStreamOptionsRequest.MasterTimeout = Option.None
            } : IndicesGetDataStreamOptionsRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesGetDataStreamOptionsRequest, value: DataStreamNames) =
            { state with IndicesGetDataStreamOptionsRequest.Name = value } : IndicesGetDataStreamOptionsRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesGetDataStreamOptionsRequest, value: ExpandWildcards) =
            { state with IndicesGetDataStreamOptionsRequest.ExpandWildcards = Option.Some value } : IndicesGetDataStreamOptionsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesGetDataStreamOptionsRequest, value: Duration) =
            { state with IndicesGetDataStreamOptionsRequest.MasterTimeout = Option.Some value } : IndicesGetDataStreamOptionsRequest

    let indicesGetDataStreamOptionsRequest = IndicesGetDataStreamOptionsRequestBuilder()

    type IndicesGetDataStreamOptionsResponse = {
        [<JsonPropertyName("data_streams")>]
        DataStreams: GetDataStreamOptionsDataStreamWithOptions array
    }

    type IndicesPutDataStreamOptionsRequest = {
        [<JsonPropertyName("name")>]
        Name: DataStreamNames
        [<JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: ExpandWildcards option
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
        [<JsonPropertyName("failure_store")>]
        FailureStore: TypesDataStreamFailureStore option
    } with
        static member ToRequest(request: IndicesPutDataStreamOptionsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{request.Name}/_options"
                let queryParams =
                    [
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", string v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesPutDataStreamOptionsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesPutDataStreamOptionsRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesPutDataStreamOptionsRequest.ToRequest request

    type IndicesPutDataStreamOptionsRequestBuilder() =
        member _.Yield(_: unit) : IndicesPutDataStreamOptionsRequest =
            {
                IndicesPutDataStreamOptionsRequest.Name = Unchecked.defaultof<DataStreamNames>
                IndicesPutDataStreamOptionsRequest.ExpandWildcards = Option.None
                IndicesPutDataStreamOptionsRequest.MasterTimeout = Option.None
                IndicesPutDataStreamOptionsRequest.Timeout = Option.None
                IndicesPutDataStreamOptionsRequest.FailureStore = Option.None
            } : IndicesPutDataStreamOptionsRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesPutDataStreamOptionsRequest, value: DataStreamNames) =
            { state with IndicesPutDataStreamOptionsRequest.Name = value } : IndicesPutDataStreamOptionsRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesPutDataStreamOptionsRequest, value: ExpandWildcards) =
            { state with IndicesPutDataStreamOptionsRequest.ExpandWildcards = Option.Some value } : IndicesPutDataStreamOptionsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesPutDataStreamOptionsRequest, value: Duration) =
            { state with IndicesPutDataStreamOptionsRequest.MasterTimeout = Option.Some value } : IndicesPutDataStreamOptionsRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesPutDataStreamOptionsRequest, value: Duration) =
            { state with IndicesPutDataStreamOptionsRequest.Timeout = Option.Some value } : IndicesPutDataStreamOptionsRequest

        [<CustomOperation("failure_store")>]
        member _.FailureStore(state: IndicesPutDataStreamOptionsRequest, value: TypesDataStreamFailureStore) =
            { state with IndicesPutDataStreamOptionsRequest.FailureStore = Option.Some value } : IndicesPutDataStreamOptionsRequest

    let indicesPutDataStreamOptionsRequest = IndicesPutDataStreamOptionsRequestBuilder()

    type IndicesPutDataStreamOptionsResponse = AcknowledgedResponseBase

    type IndicesDeleteDataStreamOptionsRequest = {
        [<JsonPropertyName("name")>]
        Name: DataStreamNames
        [<JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: ExpandWildcards option
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
    } with
        static member ToRequest(request: IndicesDeleteDataStreamOptionsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{request.Name}/_options"
                let queryParams =
                    [
                        request.ExpandWildcards |> Option.map (fun v -> "expand_wildcards", string v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesDeleteDataStreamOptionsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesDeleteDataStreamOptionsRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesDeleteDataStreamOptionsRequest.ToRequest request

    type IndicesDeleteDataStreamOptionsRequestBuilder() =
        member _.Yield(_: unit) : IndicesDeleteDataStreamOptionsRequest =
            {
                IndicesDeleteDataStreamOptionsRequest.Name = Unchecked.defaultof<DataStreamNames>
                IndicesDeleteDataStreamOptionsRequest.ExpandWildcards = Option.None
                IndicesDeleteDataStreamOptionsRequest.MasterTimeout = Option.None
                IndicesDeleteDataStreamOptionsRequest.Timeout = Option.None
            } : IndicesDeleteDataStreamOptionsRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesDeleteDataStreamOptionsRequest, value: DataStreamNames) =
            { state with IndicesDeleteDataStreamOptionsRequest.Name = value } : IndicesDeleteDataStreamOptionsRequest

        [<CustomOperation("expand_wildcards")>]
        member _.ExpandWildcards(state: IndicesDeleteDataStreamOptionsRequest, value: ExpandWildcards) =
            { state with IndicesDeleteDataStreamOptionsRequest.ExpandWildcards = Option.Some value } : IndicesDeleteDataStreamOptionsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesDeleteDataStreamOptionsRequest, value: Duration) =
            { state with IndicesDeleteDataStreamOptionsRequest.MasterTimeout = Option.Some value } : IndicesDeleteDataStreamOptionsRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesDeleteDataStreamOptionsRequest, value: Duration) =
            { state with IndicesDeleteDataStreamOptionsRequest.Timeout = Option.Some value } : IndicesDeleteDataStreamOptionsRequest

    let indicesDeleteDataStreamOptionsRequest = IndicesDeleteDataStreamOptionsRequestBuilder()

    type IndicesDeleteDataStreamOptionsResponse = AcknowledgedResponseBase

    type IndicesDownsampleRequest = {
        [<JsonPropertyName("index")>]
        Index: IndexName
        [<JsonPropertyName("target_index")>]
        TargetIndex: IndexName
        [<JsonPropertyName("body")>]
        Body: TypesDownsampleConfig
    } with
        static member ToRequest(request: IndicesDownsampleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_downsample/{request.TargetIndex}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request.Body
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesDownsampleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesDownsampleRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesDownsampleRequest.ToRequest request

    type IndicesDownsampleRequestBuilder() =
        member _.Yield(_: unit) : IndicesDownsampleRequest =
            {
                IndicesDownsampleRequest.Index = Unchecked.defaultof<IndexName>
                IndicesDownsampleRequest.TargetIndex = Unchecked.defaultof<IndexName>
                IndicesDownsampleRequest.Body = Unchecked.defaultof<TypesDownsampleConfig>
            } : IndicesDownsampleRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesDownsampleRequest, value: IndexName) =
            { state with IndicesDownsampleRequest.Index = value } : IndicesDownsampleRequest

        [<CustomOperation("target_index")>]
        member _.TargetIndex(state: IndicesDownsampleRequest, value: IndexName) =
            { state with IndicesDownsampleRequest.TargetIndex = value } : IndicesDownsampleRequest

        [<CustomOperation("body")>]
        member _.Body(state: IndicesDownsampleRequest, value: TypesDownsampleConfig) =
            { state with IndicesDownsampleRequest.Body = value } : IndicesDownsampleRequest

    let indicesDownsampleRequest = IndicesDownsampleRequestBuilder()

    type IndicesExplainDataLifecycleRequest = {
        [<JsonPropertyName("index")>]
        Index: Indices
        [<JsonPropertyName("include_defaults")>]
        IncludeDefaults: bool option
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: IndicesExplainDataLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_lifecycle/explain"
                let queryParams =
                    [
                        request.IncludeDefaults |> Option.map (fun v -> "include_defaults", string v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
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

    module IndicesExplainDataLifecycleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesExplainDataLifecycleRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesExplainDataLifecycleRequest.ToRequest request

    type IndicesExplainDataLifecycleRequestBuilder() =
        member _.Yield(_: unit) : IndicesExplainDataLifecycleRequest =
            {
                IndicesExplainDataLifecycleRequest.Index = Unchecked.defaultof<Indices>
                IndicesExplainDataLifecycleRequest.IncludeDefaults = Option.None
                IndicesExplainDataLifecycleRequest.MasterTimeout = Option.None
            } : IndicesExplainDataLifecycleRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesExplainDataLifecycleRequest, value: Indices) =
            { state with IndicesExplainDataLifecycleRequest.Index = value } : IndicesExplainDataLifecycleRequest

        [<CustomOperation("include_defaults")>]
        member _.IncludeDefaults(state: IndicesExplainDataLifecycleRequest, value: bool) =
            { state with IndicesExplainDataLifecycleRequest.IncludeDefaults = Option.Some value } : IndicesExplainDataLifecycleRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesExplainDataLifecycleRequest, value: Duration) =
            { state with IndicesExplainDataLifecycleRequest.MasterTimeout = Option.Some value } : IndicesExplainDataLifecycleRequest

    let indicesExplainDataLifecycleRequest = IndicesExplainDataLifecycleRequestBuilder()

    type IndicesExplainDataLifecycleResponse = {
        [<JsonPropertyName("indices")>]
        Indices: Map<string, ExplainDataLifecycleDataStreamLifecycleExplain>
    }

    type IndicesGetDataLifecycleStatsRequest = unit

    let indicesGetDataLifecycleStatsRequest = ()

    type IndicesGetDataLifecycleStatsResponse = {
        [<JsonPropertyName("data_stream_count")>]
        DataStreamCount: float
        [<JsonPropertyName("data_streams")>]
        DataStreams: GetDataLifecycleStatsDataStreamStats array
        [<JsonPropertyName("last_run_duration_in_millis")>]
        LastRunDurationInMillis: DurationValueUnitMillis option
        [<JsonPropertyName("time_between_starts_in_millis")>]
        TimeBetweenStartsInMillis: DurationValueUnitMillis option
    }

    type IndicesGetDataStreamMappingsRequest = {
        [<JsonPropertyName("name")>]
        Name: Indices
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: IndicesGetDataStreamMappingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{request.Name}/_mappings"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
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

    module IndicesGetDataStreamMappingsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesGetDataStreamMappingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesGetDataStreamMappingsRequest.ToRequest request

    type IndicesGetDataStreamMappingsRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetDataStreamMappingsRequest =
            {
                IndicesGetDataStreamMappingsRequest.Name = Unchecked.defaultof<Indices>
                IndicesGetDataStreamMappingsRequest.MasterTimeout = Option.None
            } : IndicesGetDataStreamMappingsRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesGetDataStreamMappingsRequest, value: Indices) =
            { state with IndicesGetDataStreamMappingsRequest.Name = value } : IndicesGetDataStreamMappingsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesGetDataStreamMappingsRequest, value: Duration) =
            { state with IndicesGetDataStreamMappingsRequest.MasterTimeout = Option.Some value } : IndicesGetDataStreamMappingsRequest

    let indicesGetDataStreamMappingsRequest = IndicesGetDataStreamMappingsRequestBuilder()

    type IndicesGetDataStreamMappingsResponse = {
        [<JsonPropertyName("data_streams")>]
        DataStreams: GetDataStreamMappingsDataStreamMappings array
    }

    type IndicesPutDataStreamMappingsRequest = {
        [<JsonPropertyName("name")>]
        Name: Indices
        [<JsonPropertyName("dry_run")>]
        DryRun: bool option
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
        [<JsonPropertyName("body")>]
        Body: MappingTypeMapping
    } with
        static member ToRequest(request: IndicesPutDataStreamMappingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{request.Name}/_mappings"
                let queryParams =
                    [
                        request.DryRun |> Option.map (fun v -> "dry_run", string v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request.Body
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesPutDataStreamMappingsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesPutDataStreamMappingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesPutDataStreamMappingsRequest.ToRequest request

    type IndicesPutDataStreamMappingsRequestBuilder() =
        member _.Yield(_: unit) : IndicesPutDataStreamMappingsRequest =
            {
                IndicesPutDataStreamMappingsRequest.Name = Unchecked.defaultof<Indices>
                IndicesPutDataStreamMappingsRequest.DryRun = Option.None
                IndicesPutDataStreamMappingsRequest.MasterTimeout = Option.None
                IndicesPutDataStreamMappingsRequest.Timeout = Option.None
                IndicesPutDataStreamMappingsRequest.Body = Unchecked.defaultof<MappingTypeMapping>
            } : IndicesPutDataStreamMappingsRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesPutDataStreamMappingsRequest, value: Indices) =
            { state with IndicesPutDataStreamMappingsRequest.Name = value } : IndicesPutDataStreamMappingsRequest

        [<CustomOperation("dry_run")>]
        member _.DryRun(state: IndicesPutDataStreamMappingsRequest, value: bool) =
            { state with IndicesPutDataStreamMappingsRequest.DryRun = Option.Some value } : IndicesPutDataStreamMappingsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesPutDataStreamMappingsRequest, value: Duration) =
            { state with IndicesPutDataStreamMappingsRequest.MasterTimeout = Option.Some value } : IndicesPutDataStreamMappingsRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesPutDataStreamMappingsRequest, value: Duration) =
            { state with IndicesPutDataStreamMappingsRequest.Timeout = Option.Some value } : IndicesPutDataStreamMappingsRequest

        [<CustomOperation("body")>]
        member _.Body(state: IndicesPutDataStreamMappingsRequest, value: MappingTypeMapping) =
            { state with IndicesPutDataStreamMappingsRequest.Body = value } : IndicesPutDataStreamMappingsRequest

    let indicesPutDataStreamMappingsRequest = IndicesPutDataStreamMappingsRequestBuilder()

    type IndicesPutDataStreamMappingsResponse = {
        [<JsonPropertyName("data_streams")>]
        DataStreams: PutDataStreamMappingsUpdatedDataStreamMappings array
    }

    type IndicesGetDataStreamSettingsRequest = {
        [<JsonPropertyName("name")>]
        Name: Indices
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: IndicesGetDataStreamSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{request.Name}/_settings"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
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

    module IndicesGetDataStreamSettingsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesGetDataStreamSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesGetDataStreamSettingsRequest.ToRequest request

    type IndicesGetDataStreamSettingsRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetDataStreamSettingsRequest =
            {
                IndicesGetDataStreamSettingsRequest.Name = Unchecked.defaultof<Indices>
                IndicesGetDataStreamSettingsRequest.MasterTimeout = Option.None
            } : IndicesGetDataStreamSettingsRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesGetDataStreamSettingsRequest, value: Indices) =
            { state with IndicesGetDataStreamSettingsRequest.Name = value } : IndicesGetDataStreamSettingsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesGetDataStreamSettingsRequest, value: Duration) =
            { state with IndicesGetDataStreamSettingsRequest.MasterTimeout = Option.Some value } : IndicesGetDataStreamSettingsRequest

    let indicesGetDataStreamSettingsRequest = IndicesGetDataStreamSettingsRequestBuilder()

    type IndicesGetDataStreamSettingsResponse = {
        [<JsonPropertyName("data_streams")>]
        DataStreams: GetDataStreamSettingsDataStreamSettings array
    }

    type IndicesPutDataStreamSettingsRequest = {
        [<JsonPropertyName("name")>]
        Name: Indices
        [<JsonPropertyName("dry_run")>]
        DryRun: bool option
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
        [<JsonPropertyName("body")>]
        Body: TypesIndexSettings
    } with
        static member ToRequest(request: IndicesPutDataStreamSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/{request.Name}/_settings"
                let queryParams =
                    [
                        request.DryRun |> Option.map (fun v -> "dry_run", string v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request.Body
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesPutDataStreamSettingsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesPutDataStreamSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesPutDataStreamSettingsRequest.ToRequest request

    type IndicesPutDataStreamSettingsRequestBuilder() =
        member _.Yield(_: unit) : IndicesPutDataStreamSettingsRequest =
            {
                IndicesPutDataStreamSettingsRequest.Name = Unchecked.defaultof<Indices>
                IndicesPutDataStreamSettingsRequest.DryRun = Option.None
                IndicesPutDataStreamSettingsRequest.MasterTimeout = Option.None
                IndicesPutDataStreamSettingsRequest.Timeout = Option.None
                IndicesPutDataStreamSettingsRequest.Body = Unchecked.defaultof<TypesIndexSettings>
            } : IndicesPutDataStreamSettingsRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesPutDataStreamSettingsRequest, value: Indices) =
            { state with IndicesPutDataStreamSettingsRequest.Name = value } : IndicesPutDataStreamSettingsRequest

        [<CustomOperation("dry_run")>]
        member _.DryRun(state: IndicesPutDataStreamSettingsRequest, value: bool) =
            { state with IndicesPutDataStreamSettingsRequest.DryRun = Option.Some value } : IndicesPutDataStreamSettingsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesPutDataStreamSettingsRequest, value: Duration) =
            { state with IndicesPutDataStreamSettingsRequest.MasterTimeout = Option.Some value } : IndicesPutDataStreamSettingsRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesPutDataStreamSettingsRequest, value: Duration) =
            { state with IndicesPutDataStreamSettingsRequest.Timeout = Option.Some value } : IndicesPutDataStreamSettingsRequest

        [<CustomOperation("body")>]
        member _.Body(state: IndicesPutDataStreamSettingsRequest, value: TypesIndexSettings) =
            { state with IndicesPutDataStreamSettingsRequest.Body = value } : IndicesPutDataStreamSettingsRequest

    let indicesPutDataStreamSettingsRequest = IndicesPutDataStreamSettingsRequestBuilder()

    type IndicesPutDataStreamSettingsResponse = {
        [<JsonPropertyName("data_streams")>]
        DataStreams: PutDataStreamSettingsUpdatedDataStreamSettings array
    }

    type IndicesMigrateToDataStreamRequest = {
        [<JsonPropertyName("name")>]
        Name: IndexName
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
        [<JsonPropertyName("timeout")>]
        Timeout: Duration option
    } with
        static member ToRequest(request: IndicesMigrateToDataStreamRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/_migrate/{request.Name}"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                        request.Timeout |> Option.map (fun v -> "timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesMigrateToDataStreamRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesMigrateToDataStreamRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesMigrateToDataStreamRequest.ToRequest request

    type IndicesMigrateToDataStreamRequestBuilder() =
        member _.Yield(_: unit) : IndicesMigrateToDataStreamRequest =
            {
                IndicesMigrateToDataStreamRequest.Name = Unchecked.defaultof<IndexName>
                IndicesMigrateToDataStreamRequest.MasterTimeout = Option.None
                IndicesMigrateToDataStreamRequest.Timeout = Option.None
            } : IndicesMigrateToDataStreamRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesMigrateToDataStreamRequest, value: IndexName) =
            { state with IndicesMigrateToDataStreamRequest.Name = value } : IndicesMigrateToDataStreamRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesMigrateToDataStreamRequest, value: Duration) =
            { state with IndicesMigrateToDataStreamRequest.MasterTimeout = Option.Some value } : IndicesMigrateToDataStreamRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndicesMigrateToDataStreamRequest, value: Duration) =
            { state with IndicesMigrateToDataStreamRequest.Timeout = Option.Some value } : IndicesMigrateToDataStreamRequest

    let indicesMigrateToDataStreamRequest = IndicesMigrateToDataStreamRequestBuilder()

    type IndicesMigrateToDataStreamResponse = AcknowledgedResponseBase

    type IndicesModifyDataStreamRequest = {
        [<JsonPropertyName("actions")>]
        Actions: ModifyDataStreamAction array
    } with
        static member ToRequest(request: IndicesModifyDataStreamRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_data_stream/_modify"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesModifyDataStreamRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesModifyDataStreamRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesModifyDataStreamRequest.ToRequest request

    type IndicesModifyDataStreamRequestBuilder() =
        member _.Yield(_: unit) : IndicesModifyDataStreamRequest =
            {
                IndicesModifyDataStreamRequest.Actions = [||]
            } : IndicesModifyDataStreamRequest

        [<CustomOperation("actions")>]
        member _.Actions(state: IndicesModifyDataStreamRequest, value: ModifyDataStreamAction array) =
            { state with IndicesModifyDataStreamRequest.Actions = value } : IndicesModifyDataStreamRequest

    let indicesModifyDataStreamRequest = IndicesModifyDataStreamRequestBuilder()

    type IndicesModifyDataStreamResponse = AcknowledgedResponseBase

    type IndicesPromoteDataStreamRequest = {
        [<JsonPropertyName("name")>]
        Name: IndexName
        [<JsonPropertyName("master_timeout")>]
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: IndicesPromoteDataStreamRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_data_stream/_promote/{request.Name}"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesPromoteDataStreamRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesPromoteDataStreamRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesPromoteDataStreamRequest.ToRequest request

    type IndicesPromoteDataStreamRequestBuilder() =
        member _.Yield(_: unit) : IndicesPromoteDataStreamRequest =
            {
                IndicesPromoteDataStreamRequest.Name = Unchecked.defaultof<IndexName>
                IndicesPromoteDataStreamRequest.MasterTimeout = Option.None
            } : IndicesPromoteDataStreamRequest

        [<CustomOperation("name")>]
        member _.Name(state: IndicesPromoteDataStreamRequest, value: IndexName) =
            { state with IndicesPromoteDataStreamRequest.Name = value } : IndicesPromoteDataStreamRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: IndicesPromoteDataStreamRequest, value: Duration) =
            { state with IndicesPromoteDataStreamRequest.MasterTimeout = Option.Some value } : IndicesPromoteDataStreamRequest

    let indicesPromoteDataStreamRequest = IndicesPromoteDataStreamRequestBuilder()


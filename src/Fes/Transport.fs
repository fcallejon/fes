namespace Fes

open System
open Elastic.Transport

// ============================================================================
// Transport configuration CE
// ============================================================================

type TransportConfig = {
    Uri: Uri option
    Authentication: AuthorizationHeader option
    RequestTimeout: TimeSpan option
    MaxRetries: int option
    Compression: bool option
    DisablePings: bool option
    ThrowExceptions: bool option
    CloudId: string option
}

[<AutoOpen>]
module TransportHelpers =

    module TransportConfig =
        let empty = {
            Uri = None
            Authentication = None
            RequestTimeout = None
            MaxRetries = None
            Compression = None
            DisablePings = None
            ThrowExceptions = None
            CloudId = None
        }

        let build (config: TransportConfig) : ITransport =
            let serialiser = FesSerializer()

            let desc =
                match config.CloudId, config.Authentication with
                | Some cloudId, Some auth ->
                    let np = CloudNodePool(cloudId, auth)
                    TransportConfigurationDescriptor(np, serializer = serialiser)
                | _ ->
                    let uri = config.Uri |> Option.defaultValue (Uri "http://localhost:9200")
                    let np = SingleNodePool(uri)
                    TransportConfigurationDescriptor(np, serializer = serialiser)

            config.Authentication |> Option.iter (fun auth -> desc.Authentication(auth) |> ignore)
            config.RequestTimeout |> Option.iter (fun t -> desc.RequestTimeout(t) |> ignore)
            config.MaxRetries |> Option.iter (fun r -> desc.MaximumRetries(r) |> ignore)
            config.Compression |> Option.iter (fun c -> desc.EnableHttpCompression(c) |> ignore)
            config.DisablePings |> Option.iter (fun d -> desc.DisablePing(d) |> ignore)
            config.ThrowExceptions |> Option.iter (fun t -> desc.ThrowExceptions(t) |> ignore)

            DistributedTransport(desc) :> ITransport

    type EsTransportBuilder() =
        member _.Yield(_: unit) = TransportConfig.empty

        [<CustomOperation("uri")>]
        member _.Uri(state, value: string) =
            { state with Uri = Some (Uri value) }

        [<CustomOperation("cloudId")>]
        member _.CloudId(state, value: string) =
            { state with CloudId = Some value }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state, value: string) =
            { state with Authentication = Some (Elastic.Transport.ApiKey(value) :> AuthorizationHeader) }

        [<CustomOperation("basicAuth")>]
        member _.BasicAuth(state, username: string, password: string) =
            { state with Authentication = Some (BasicAuthentication(username, password) :> AuthorizationHeader) }

        [<CustomOperation("requestTimeout")>]
        member _.RequestTimeout(state, seconds: float) =
            { state with RequestTimeout = Some (TimeSpan.FromSeconds seconds) }

        [<CustomOperation("maxRetries")>]
        member _.MaxRetries(state, value: int) =
            { state with MaxRetries = Some value }

        [<CustomOperation("compression")>]
        member _.Compression(state, value: bool) =
            { state with Compression = Some value }

        [<CustomOperation("disablePings")>]
        member _.DisablePings(state, value: bool) =
            { state with DisablePings = Some value }

        [<CustomOperation("throwExceptions")>]
        member _.ThrowExceptions(state, value: bool) =
            { state with ThrowExceptions = Some value }

        member _.Run(state) = TransportConfig.build state

    let esTransport = EsTransportBuilder()

// ============================================================================
// ES module — connect + send
// ============================================================================

[<RequireQualifiedAccess>]
module ES =

    /// Connect to a single Elasticsearch node
    let connect (uri: string) : ITransport =
        TransportConfig.build { TransportConfig.empty with Uri = Some (Uri uri) }

    /// Connect with API key authentication
    let connectWithApiKey (uri: string) (apiKey: string) : ITransport =
        TransportConfig.build {
            TransportConfig.empty with
                Uri = Some (Uri uri)
                Authentication = Some (Elastic.Transport.ApiKey(apiKey) :> AuthorizationHeader)
        }

    /// Connect to Elastic Cloud
    let connectCloud (cloudId: string) (apiKey: string) : ITransport =
        TransportConfig.build {
            TransportConfig.empty with
                CloudId = Some cloudId
                Authentication = Some (Elastic.Transport.ApiKey(apiKey) :> AuthorizationHeader)
                Compression = Some true
        }

    /// Convert a request to an EndpointPath + optional PostData
    let inline toEndpoint (request: ^T) : EndpointPath * PostData voption =
        (^T : (static member ToEndpoint: ^T -> EndpointPath * PostData voption) request)

    /// Send a request and deserialise the response
    let inline sendAsync<'TResponse, ^TRequest when ^TRequest : (static member ToEndpoint: ^TRequest -> EndpointPath * PostData voption)> (transport: ITransport) (request: ^TRequest) : TaskResult<'TResponse, exn> =
        let (endpoint, postData) = toEndpoint request
        let mutable ep = endpoint
        let pd = match postData with ValueSome p -> p | ValueNone -> null
        task {
            let! response = transport.RequestAsync<StringResponse>(&ep, pd)
            if response.ApiCallDetails.HasSuccessfulStatusCode then
                match response.Body with
                | null | "" -> return Error (exn "Empty response body")
                | body -> return Json.tryDeserialize<'TResponse> body
            else
                let ex =
                    match response.ApiCallDetails.OriginalException with
                    | null -> TransportException(response.ApiCallDetails.DebugInformation) :> exn
                    | e -> e
                return Error ex
        }

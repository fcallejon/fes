module Fes.Tests.TestTransport

open System
open System.Text
open Elastic.Transport
open Fes

/// Create an in-memory ITransport that returns a fixed response for every request.
/// DisableDirectStreaming is enabled so RequestBodyInBytes and ResponseBodyInBytes are captured.
let withResponse (responseJson: string) (statusCode: int) : ITransport =
    let responseBytes = Encoding.UTF8.GetBytes(responseJson)
    let invoker = InMemoryRequestInvoker(responseBytes, statusCode)
    let serialiser = FesSerializer()
    let pool = SingleNodePool(Uri "http://localhost:9200")
    let desc = TransportConfigurationDescriptor(pool, invoker = invoker, serializer = serialiser)
    desc.DisableDirectStreaming(true) |> ignore
    DistributedTransport(desc) :> ITransport

/// Create an in-memory ITransport returning 200 with the given JSON.
let withOkResponse (responseJson: string) : ITransport =
    withResponse responseJson 200

/// Extract the request body as a string from ApiCallDetails.
let requestBodyString (details: ApiCallDetails) : string option =
    match details.RequestBodyInBytes with
    | null -> None
    | bytes -> Some (Encoding.UTF8.GetString(bytes))

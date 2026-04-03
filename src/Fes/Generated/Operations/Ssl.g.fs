// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module SslOperations =

    type SslCertificatesRequest = | SslCertificatesRequest

        with
        static member ToRequest(req: SslCertificatesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_ssl/certificates"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type SslCertificatesResponse = SslCertificates.CertificateInformation list

    type SslCertificatesRequestBuilder() =
        member _.Yield(_: unit) : SslCertificatesRequest =
            {
            }

    let sslCertificatesRequest = SslCertificatesRequestBuilder()


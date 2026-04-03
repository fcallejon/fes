// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SslCertificates =

    type CertificateInformation = {
        [<System.Text.Json.Serialization.JsonPropertyName("alias")>]
        Alias: string option
        [<System.Text.Json.Serialization.JsonPropertyName("expiry")>]
        Expiry: CoreTypes.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string
        [<System.Text.Json.Serialization.JsonPropertyName("has_private_key")>]
        HasPrivateKey: bool
        [<System.Text.Json.Serialization.JsonPropertyName("issuer")>]
        Issuer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: string
        [<System.Text.Json.Serialization.JsonPropertyName("serial_number")>]
        SerialNumber: string
        [<System.Text.Json.Serialization.JsonPropertyName("subject_dn")>]
        SubjectDn: string
    }


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module LicensePost =

    type Acknowledgement = {
        [<System.Text.Json.Serialization.JsonPropertyName("license")>]
        License: string list
        [<System.Text.Json.Serialization.JsonPropertyName("message")>]
        Message: string
    }


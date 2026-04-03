// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatMaster =

    type MasterRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: string option
        [<System.Text.Json.Serialization.JsonPropertyName("host")>]
        Host: string option
        [<System.Text.Json.Serialization.JsonPropertyName("ip")>]
        Ip: string option
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: string option
    }


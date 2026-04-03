// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalCapabilities =

    type FailedNodeException = {
        [<System.Text.Json.Serialization.JsonPropertyName("node_id")>]
        NodeId: Types.Id
    }

    [<RequireQualifiedAccess>]
    type RestMethod =
        | GET
        | HEAD
        | POST
        | PUT
        | DELETE


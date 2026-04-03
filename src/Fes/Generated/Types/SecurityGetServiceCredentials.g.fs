// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SecurityGetServiceCredentials =

    type NodesCredentialsFileToken = {
        [<System.Text.Json.Serialization.JsonPropertyName("nodes")>]
        Nodes: string list
    }

    type NodesCredentials = {
        [<System.Text.Json.Serialization.JsonPropertyName("_nodes")>]
        Nodes: Types.NodeStatistics
        [<System.Text.Json.Serialization.JsonPropertyName("file_tokens")>]
        FileTokens: Map<string, SecurityGetServiceCredentials.NodesCredentialsFileToken>
    }


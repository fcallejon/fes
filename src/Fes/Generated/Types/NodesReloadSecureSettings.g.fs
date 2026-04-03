// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module NodesReloadSecureSettings =

    type ResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_name")>]
        ClusterName: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("nodes")>]
        Nodes: Map<string, NodesTypes.NodeReloadResult>
    }


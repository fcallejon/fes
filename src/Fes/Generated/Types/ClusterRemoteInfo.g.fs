// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module ClusterRemoteInfo =

    type ClusterRemoteSniffInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: string
        [<System.Text.Json.Serialization.JsonPropertyName("connected")>]
        Connected: bool
        [<System.Text.Json.Serialization.JsonPropertyName("max_connections_per_cluster")>]
        MaxConnectionsPerCluster: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("num_nodes_connected")>]
        NumNodesConnected: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("initial_connect_timeout")>]
        InitialConnectTimeout: CoreTypes.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("skip_unavailable")>]
        SkipUnavailable: bool
        [<System.Text.Json.Serialization.JsonPropertyName("seeds")>]
        Seeds: string list
    }

    type ClusterRemoteProxyInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: string
        [<System.Text.Json.Serialization.JsonPropertyName("connected")>]
        Connected: bool
        [<System.Text.Json.Serialization.JsonPropertyName("initial_connect_timeout")>]
        InitialConnectTimeout: CoreTypes.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("skip_unavailable")>]
        SkipUnavailable: bool
        [<System.Text.Json.Serialization.JsonPropertyName("proxy_address")>]
        ProxyAddress: string
        [<System.Text.Json.Serialization.JsonPropertyName("server_name")>]
        ServerName: string
        [<System.Text.Json.Serialization.JsonPropertyName("num_proxy_sockets_connected")>]
        NumProxySocketsConnected: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("max_proxy_socket_connections")>]
        MaxProxySocketConnections: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_credentials")>]
        ClusterCredentials: string option
    }

    [<RequireQualifiedAccess>]
    type ClusterRemoteInfo =
        | ClusterRemoteSniffInfo of ClusterRemoteSniffInfo
        | ClusterRemoteProxyInfo of ClusterRemoteProxyInfo


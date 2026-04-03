// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatThreadPool =

    type ThreadPoolRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("node_name")>]
        NodeName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("node_id")>]
        NodeId: Types.NodeId option
        [<System.Text.Json.Serialization.JsonPropertyName("ephemeral_node_id")>]
        EphemeralNodeId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pid")>]
        Pid: string option
        [<System.Text.Json.Serialization.JsonPropertyName("host")>]
        Host: string option
        [<System.Text.Json.Serialization.JsonPropertyName("ip")>]
        Ip: string option
        [<System.Text.Json.Serialization.JsonPropertyName("port")>]
        Port: string option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string option
        [<System.Text.Json.Serialization.JsonPropertyName("active")>]
        Active: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pool_size")>]
        PoolSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("queue")>]
        Queue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("queue_size")>]
        QueueSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("rejected")>]
        Rejected: string option
        [<System.Text.Json.Serialization.JsonPropertyName("largest")>]
        Largest: string option
        [<System.Text.Json.Serialization.JsonPropertyName("completed")>]
        Completed: string option
        [<System.Text.Json.Serialization.JsonPropertyName("core")>]
        Core: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("keep_alive")>]
        KeepAlive: string option option
    }


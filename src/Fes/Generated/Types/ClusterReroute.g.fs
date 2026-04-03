// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module ClusterReroute =

    type CommandCancelAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("shard")>]
        Shard: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: string
        [<System.Text.Json.Serialization.JsonPropertyName("allow_primary")>]
        AllowPrimary: bool option
    }

    type CommandMoveAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("shard")>]
        Shard: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("from_node")>]
        FromNode: string
        [<System.Text.Json.Serialization.JsonPropertyName("to_node")>]
        ToNode: string
    }

    type CommandAllocateReplicaAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("shard")>]
        Shard: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: string
    }

    type CommandAllocatePrimaryAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("shard")>]
        Shard: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: string
        [<System.Text.Json.Serialization.JsonPropertyName("accept_data_loss")>]
        AcceptDataLoss: bool
    }

    type Command = {
        [<System.Text.Json.Serialization.JsonPropertyName("cancel")>]
        Cancel: ClusterReroute.CommandCancelAction option
        [<System.Text.Json.Serialization.JsonPropertyName("move")>]
        Move: ClusterReroute.CommandMoveAction option
        [<System.Text.Json.Serialization.JsonPropertyName("allocate_replica")>]
        AllocateReplica: ClusterReroute.CommandAllocateReplicaAction option
        [<System.Text.Json.Serialization.JsonPropertyName("allocate_stale_primary")>]
        AllocateStalePrimary: ClusterReroute.CommandAllocatePrimaryAction option
        [<System.Text.Json.Serialization.JsonPropertyName("allocate_empty_primary")>]
        AllocateEmptyPrimary: ClusterReroute.CommandAllocatePrimaryAction option
    }

    type RerouteDecision = {
        [<System.Text.Json.Serialization.JsonPropertyName("decider")>]
        Decider: string
        [<System.Text.Json.Serialization.JsonPropertyName("decision")>]
        Decision: string
        [<System.Text.Json.Serialization.JsonPropertyName("explanation")>]
        Explanation: string
    }

    type RerouteParameters = {
        [<System.Text.Json.Serialization.JsonPropertyName("allow_primary")>]
        AllowPrimary: bool
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: Types.NodeName
        [<System.Text.Json.Serialization.JsonPropertyName("shard")>]
        Shard: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("from_node")>]
        FromNode: Types.NodeName option
        [<System.Text.Json.Serialization.JsonPropertyName("to_node")>]
        ToNode: Types.NodeName option
    }

    type RerouteExplanation = {
        [<System.Text.Json.Serialization.JsonPropertyName("command")>]
        Command: string
        [<System.Text.Json.Serialization.JsonPropertyName("decisions")>]
        Decisions: ClusterReroute.RerouteDecision list
        [<System.Text.Json.Serialization.JsonPropertyName("parameters")>]
        Parameters: ClusterReroute.RerouteParameters
    }


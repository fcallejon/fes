// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module ClusterReroute =

    type CommandCancelAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("shard")>]
        Shard: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: string
        [<System.Text.Json.Serialization.JsonPropertyName("allow_primary")>]
        AllowPrimary: bool option
    }

    type CommandMoveAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("shard")>]
        Shard: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("from_node")>]
        FromNode: string
        [<System.Text.Json.Serialization.JsonPropertyName("to_node")>]
        ToNode: string
    }

    type CommandAllocateReplicaAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("shard")>]
        Shard: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: string
    }

    type CommandAllocatePrimaryAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("shard")>]
        Shard: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: string
        [<System.Text.Json.Serialization.JsonPropertyName("accept_data_loss")>]
        AcceptDataLoss: bool
    }

    type Command = {
        [<System.Text.Json.Serialization.JsonPropertyName("cancel")>]
        Cancel: CommandCancelAction option
        [<System.Text.Json.Serialization.JsonPropertyName("move")>]
        Move: CommandMoveAction option
        [<System.Text.Json.Serialization.JsonPropertyName("allocate_replica")>]
        AllocateReplica: CommandAllocateReplicaAction option
        [<System.Text.Json.Serialization.JsonPropertyName("allocate_stale_primary")>]
        AllocateStalePrimary: CommandAllocatePrimaryAction option
        [<System.Text.Json.Serialization.JsonPropertyName("allocate_empty_primary")>]
        AllocateEmptyPrimary: CommandAllocatePrimaryAction option
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
        Index: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: CoreTypes.NodeName
        [<System.Text.Json.Serialization.JsonPropertyName("shard")>]
        Shard: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("from_node")>]
        FromNode: CoreTypes.NodeName option
        [<System.Text.Json.Serialization.JsonPropertyName("to_node")>]
        ToNode: CoreTypes.NodeName option
    }

    type RerouteExplanation = {
        [<System.Text.Json.Serialization.JsonPropertyName("command")>]
        Command: string
        [<System.Text.Json.Serialization.JsonPropertyName("decisions")>]
        Decisions: RerouteDecision list
        [<System.Text.Json.Serialization.JsonPropertyName("parameters")>]
        Parameters: RerouteParameters
    }


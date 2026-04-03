// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module ShutdownGetNode =

    [<RequireQualifiedAccess>]
    type ShutdownType =
        | Remove
        | Restart

    [<RequireQualifiedAccess>]
    type ShutdownStatus =
        | NotStarted
        | InProgress
        | Stalled
        | Complete

    type ShardMigrationStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: ShutdownGetNode.ShutdownStatus
    }

    type PersistentTaskStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: ShutdownGetNode.ShutdownStatus
    }

    type PluginsStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: ShutdownGetNode.ShutdownStatus
    }

    type NodeShutdownStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("node_id")>]
        NodeId: Types.NodeId
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: ShutdownGetNode.ShutdownType
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string
        [<System.Text.Json.Serialization.JsonPropertyName("shutdown_startedmillis")>]
        ShutdownStartedmillis: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: ShutdownGetNode.ShutdownStatus
        [<System.Text.Json.Serialization.JsonPropertyName("shard_migration")>]
        ShardMigration: ShutdownGetNode.ShardMigrationStatus
        [<System.Text.Json.Serialization.JsonPropertyName("persistent_tasks")>]
        PersistentTasks: ShutdownGetNode.PersistentTaskStatus
        [<System.Text.Json.Serialization.JsonPropertyName("plugins")>]
        Plugins: ShutdownGetNode.PluginsStatus
    }


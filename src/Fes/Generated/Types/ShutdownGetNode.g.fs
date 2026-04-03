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
        Status: ShutdownStatus
    }

    type PersistentTaskStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: ShutdownStatus
    }

    type PluginsStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: ShutdownStatus
    }

    type NodeShutdownStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("node_id")>]
        NodeId: CoreTypes.NodeId
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: ShutdownType
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string
        [<System.Text.Json.Serialization.JsonPropertyName("shutdown_startedmillis")>]
        ShutdownStartedmillis: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: ShutdownStatus
        [<System.Text.Json.Serialization.JsonPropertyName("shard_migration")>]
        ShardMigration: ShardMigrationStatus
        [<System.Text.Json.Serialization.JsonPropertyName("persistent_tasks")>]
        PersistentTasks: PersistentTaskStatus
        [<System.Text.Json.Serialization.JsonPropertyName("plugins")>]
        Plugins: PluginsStatus
    }


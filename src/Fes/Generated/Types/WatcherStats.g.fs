// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module WatcherStats =

    type WatchRecordQueuedStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("execution_time")>]
        ExecutionTime: Types.DateTime
    }

    type WatchRecordStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("execution_phase")>]
        ExecutionPhase: WatcherTypes.ExecutionPhase
        [<System.Text.Json.Serialization.JsonPropertyName("triggered_time")>]
        TriggeredTime: Types.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("executed_actions")>]
        ExecutedActions: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("watch_id")>]
        WatchId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("watch_record_id")>]
        WatchRecordId: Types.Id
    }

    [<RequireQualifiedAccess>]
    type WatcherMetric =
        | All
        | QueuedWatches
        | CurrentWatches
        | PendingWatches

    [<RequireQualifiedAccess>]
    type WatcherState =
        | Stopped
        | Starting
        | Started
        | Stopping

    type WatcherNodeStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("current_watches")>]
        CurrentWatches: WatcherStats.WatchRecordStats list option
        [<System.Text.Json.Serialization.JsonPropertyName("execution_thread_pool")>]
        ExecutionThreadPool: WatcherTypes.ExecutionThreadPool
        [<System.Text.Json.Serialization.JsonPropertyName("queued_watches")>]
        QueuedWatches: WatcherStats.WatchRecordQueuedStats list option
        [<System.Text.Json.Serialization.JsonPropertyName("watch_count")>]
        WatchCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("watcher_state")>]
        WatcherState: WatcherStats.WatcherState
        [<System.Text.Json.Serialization.JsonPropertyName("node_id")>]
        NodeId: Types.Id
    }


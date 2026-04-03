// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module WatcherStats =

    type WatchRecordQueuedStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("execution_time")>]
        ExecutionTime: CoreTypes.DateTime
    }

    type WatchRecordStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("execution_phase")>]
        ExecutionPhase: WatcherTypes.ExecutionPhase
        [<System.Text.Json.Serialization.JsonPropertyName("triggered_time")>]
        TriggeredTime: CoreTypes.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("executed_actions")>]
        ExecutedActions: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("watch_id")>]
        WatchId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("watch_record_id")>]
        WatchRecordId: CoreTypes.Id
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
        CurrentWatches: WatchRecordStats list option
        [<System.Text.Json.Serialization.JsonPropertyName("execution_thread_pool")>]
        ExecutionThreadPool: WatcherTypes.ExecutionThreadPool
        [<System.Text.Json.Serialization.JsonPropertyName("queued_watches")>]
        QueuedWatches: WatchRecordQueuedStats list option
        [<System.Text.Json.Serialization.JsonPropertyName("watch_count")>]
        WatchCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("watcher_state")>]
        WatcherState: WatcherState
        [<System.Text.Json.Serialization.JsonPropertyName("node_id")>]
        NodeId: CoreTypes.Id
    }


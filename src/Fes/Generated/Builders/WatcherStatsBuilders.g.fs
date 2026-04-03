// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module WatcherStatsBuilders =

    type WatcherNodeStatsBuilder() =
        member _.Yield(_: unit) : WatcherNodeStats =
            {
                CurrentWatches = None
                ExecutionThreadPool = Unchecked.defaultof<_>
                QueuedWatches = None
                WatchCount = Unchecked.defaultof<_>
                WatcherState = Unchecked.defaultof<_>
                NodeId = Unchecked.defaultof<_>
            }

        [<CustomOperation("currentWatches")>]
        member _.CurrentWatches(state: WatcherNodeStats, value: WatcherStats.WatchRecordStats list) =
            { state with CurrentWatches = Some value }

        [<CustomOperation("executionThreadPool")>]
        member _.ExecutionThreadPool(state: WatcherNodeStats, value: WatcherTypes.ExecutionThreadPool) =
            { state with ExecutionThreadPool = value }

        [<CustomOperation("queuedWatches")>]
        member _.QueuedWatches(state: WatcherNodeStats, value: WatcherStats.WatchRecordQueuedStats list) =
            { state with QueuedWatches = Some value }

        [<CustomOperation("watchCount")>]
        member _.WatchCount(state: WatcherNodeStats, value: CoreTypes.Long) =
            { state with WatchCount = value }

        [<CustomOperation("watcherState")>]
        member _.WatcherState(state: WatcherNodeStats, value: WatcherStats.WatcherState) =
            { state with WatcherState = value }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: WatcherNodeStats, value: CoreTypes.Id) =
            { state with NodeId = value }

    let watcherNodeStats = WatcherNodeStatsBuilder()


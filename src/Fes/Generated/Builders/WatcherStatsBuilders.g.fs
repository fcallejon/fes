// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module WatcherStatsBuilders =

    type WatcherNodeStatsBuilder() =
        member _.Yield(_: unit) : Types.WatcherNodeStats =
            {
                CurrentWatches = None
                ExecutionThreadPool = Unchecked.defaultof<_>
                QueuedWatches = None
                WatchCount = Unchecked.defaultof<_>
                WatcherState = Unchecked.defaultof<_>
                NodeId = Unchecked.defaultof<_>
            }

        [<CustomOperation("currentWatches")>]
        member _.CurrentWatches(state: Types.WatcherNodeStats, value: Types.WatchRecordStats list) =
            { state with CurrentWatches = Some value }

        [<CustomOperation("executionThreadPool")>]
        member _.ExecutionThreadPool(state: Types.WatcherNodeStats, value: Types.ExecutionThreadPool) =
            { state with ExecutionThreadPool = value }

        [<CustomOperation("queuedWatches")>]
        member _.QueuedWatches(state: Types.WatcherNodeStats, value: Types.WatchRecordQueuedStats list) =
            { state with QueuedWatches = Some value }

        [<CustomOperation("watchCount")>]
        member _.WatchCount(state: Types.WatcherNodeStats, value: Types.Long) =
            { state with WatchCount = value }

        [<CustomOperation("watcherState")>]
        member _.WatcherState(state: Types.WatcherNodeStats, value: Types.WatcherState) =
            { state with WatcherState = value }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: Types.WatcherNodeStats, value: Types.Id) =
            { state with NodeId = value }

    let watcherNodeStats = WatcherNodeStatsBuilder()


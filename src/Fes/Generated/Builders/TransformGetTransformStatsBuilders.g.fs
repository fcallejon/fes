// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module TransformGetTransformStatsBuilders =

    type CheckpointStatsBuilder() =
        member _.Yield(_: unit) : Types.CheckpointStats =
            {
                Checkpoint = Unchecked.defaultof<_>
                CheckpointProgress = None
                Timestamp = None
                TimestampMillis = None
                TimeUpperBound = None
                TimeUpperBoundMillis = None
            }

        [<CustomOperation("checkpoint")>]
        member _.Checkpoint(state: Types.CheckpointStats, value: Types.Long) =
            { state with Checkpoint = value }

        [<CustomOperation("checkpointProgress")>]
        member _.CheckpointProgress(state: Types.CheckpointStats, value: Types.TransformProgress) =
            { state with CheckpointProgress = Some value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: Types.CheckpointStats, value: Types.DateTime) =
            { state with Timestamp = Some value }

        [<CustomOperation("timestampMillis")>]
        member _.TimestampMillis(state: Types.CheckpointStats, value: Types.EpochTime<Types.UnitMillis>) =
            { state with TimestampMillis = Some value }

        [<CustomOperation("timeUpperBound")>]
        member _.TimeUpperBound(state: Types.CheckpointStats, value: Types.DateTime) =
            { state with TimeUpperBound = Some value }

        [<CustomOperation("timeUpperBoundMillis")>]
        member _.TimeUpperBoundMillis(state: Types.CheckpointStats, value: Types.EpochTime<Types.UnitMillis>) =
            { state with TimeUpperBoundMillis = Some value }

    let checkpointStats = CheckpointStatsBuilder()

    type CheckpointingBuilder() =
        member _.Yield(_: unit) : Types.Checkpointing =
            {
                ChangesLastDetectedAt = None
                ChangesLastDetectedAtString = None
                Last = Unchecked.defaultof<_>
                Next = None
                OperationsBehind = None
                LastSearchTime = None
                LastSearchTimeString = None
            }

        [<CustomOperation("changesLastDetectedAt")>]
        member _.ChangesLastDetectedAt(state: Types.Checkpointing, value: Types.Long) =
            { state with ChangesLastDetectedAt = Some value }

        [<CustomOperation("changesLastDetectedAtString")>]
        member _.ChangesLastDetectedAtString(state: Types.Checkpointing, value: Types.DateTime) =
            { state with ChangesLastDetectedAtString = Some value }

        [<CustomOperation("last")>]
        member _.Last(state: Types.Checkpointing, value: Types.CheckpointStats) =
            { state with Last = value }

        [<CustomOperation("next")>]
        member _.Next(state: Types.Checkpointing, value: Types.CheckpointStats) =
            { state with Next = Some value }

        [<CustomOperation("operationsBehind")>]
        member _.OperationsBehind(state: Types.Checkpointing, value: Types.Long) =
            { state with OperationsBehind = Some value }

        [<CustomOperation("lastSearchTime")>]
        member _.LastSearchTime(state: Types.Checkpointing, value: Types.Long) =
            { state with LastSearchTime = Some value }

        [<CustomOperation("lastSearchTimeString")>]
        member _.LastSearchTimeString(state: Types.Checkpointing, value: Types.DateTime) =
            { state with LastSearchTimeString = Some value }

    let checkpointing = CheckpointingBuilder()

    type TransformHealthIssueBuilder() =
        member _.Yield(_: unit) : Types.TransformHealthIssue =
            {
                Type = Unchecked.defaultof<_>
                Issue = Unchecked.defaultof<_>
                Details = None
                Count = Unchecked.defaultof<_>
                FirstOccurrence = None
                FirstOccurenceString = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.TransformHealthIssue, value: string) =
            { state with Type = value }

        [<CustomOperation("issue")>]
        member _.Issue(state: Types.TransformHealthIssue, value: string) =
            { state with Issue = value }

        [<CustomOperation("details")>]
        member _.Details(state: Types.TransformHealthIssue, value: string) =
            { state with Details = Some value }

        [<CustomOperation("count")>]
        member _.Count(state: Types.TransformHealthIssue, value: Types.Integer) =
            { state with Count = value }

        [<CustomOperation("firstOccurrence")>]
        member _.FirstOccurrence(state: Types.TransformHealthIssue, value: Types.EpochTime<Types.UnitMillis>) =
            { state with FirstOccurrence = Some value }

        [<CustomOperation("firstOccurenceString")>]
        member _.FirstOccurenceString(state: Types.TransformHealthIssue, value: Types.DateTime) =
            { state with FirstOccurenceString = Some value }

    let transformHealthIssue = TransformHealthIssueBuilder()

    type TransformIndexerStatsBuilder() =
        member _.Yield(_: unit) : Types.TransformIndexerStats =
            {
                DeleteTimeInMs = None
                DocumentsIndexed = Unchecked.defaultof<_>
                DocumentsDeleted = None
                DocumentsProcessed = Unchecked.defaultof<_>
                ExponentialAvgCheckpointDurationMs = Unchecked.defaultof<_>
                ExponentialAvgDocumentsIndexed = Unchecked.defaultof<_>
                ExponentialAvgDocumentsProcessed = Unchecked.defaultof<_>
                IndexFailures = Unchecked.defaultof<_>
                IndexTimeInMs = Unchecked.defaultof<_>
                IndexTotal = Unchecked.defaultof<_>
                PagesProcessed = Unchecked.defaultof<_>
                ProcessingTimeInMs = Unchecked.defaultof<_>
                ProcessingTotal = Unchecked.defaultof<_>
                SearchFailures = Unchecked.defaultof<_>
                SearchTimeInMs = Unchecked.defaultof<_>
                SearchTotal = Unchecked.defaultof<_>
                TriggerCount = Unchecked.defaultof<_>
            }

        [<CustomOperation("deleteTimeInMs")>]
        member _.DeleteTimeInMs(state: Types.TransformIndexerStats, value: Types.EpochTime<Types.UnitMillis>) =
            { state with DeleteTimeInMs = Some value }

        [<CustomOperation("documentsIndexed")>]
        member _.DocumentsIndexed(state: Types.TransformIndexerStats, value: Types.Long) =
            { state with DocumentsIndexed = value }

        [<CustomOperation("documentsDeleted")>]
        member _.DocumentsDeleted(state: Types.TransformIndexerStats, value: Types.Long) =
            { state with DocumentsDeleted = Some value }

        [<CustomOperation("documentsProcessed")>]
        member _.DocumentsProcessed(state: Types.TransformIndexerStats, value: Types.Long) =
            { state with DocumentsProcessed = value }

        [<CustomOperation("exponentialAvgCheckpointDurationMs")>]
        member _.ExponentialAvgCheckpointDurationMs(state: Types.TransformIndexerStats, value: Types.DurationValue<Types.UnitFloatMillis>) =
            { state with ExponentialAvgCheckpointDurationMs = value }

        [<CustomOperation("exponentialAvgDocumentsIndexed")>]
        member _.ExponentialAvgDocumentsIndexed(state: Types.TransformIndexerStats, value: Types.Double) =
            { state with ExponentialAvgDocumentsIndexed = value }

        [<CustomOperation("exponentialAvgDocumentsProcessed")>]
        member _.ExponentialAvgDocumentsProcessed(state: Types.TransformIndexerStats, value: Types.Double) =
            { state with ExponentialAvgDocumentsProcessed = value }

        [<CustomOperation("indexFailures")>]
        member _.IndexFailures(state: Types.TransformIndexerStats, value: Types.Long) =
            { state with IndexFailures = value }

        [<CustomOperation("indexTimeInMs")>]
        member _.IndexTimeInMs(state: Types.TransformIndexerStats, value: Types.DurationValue<Types.UnitMillis>) =
            { state with IndexTimeInMs = value }

        [<CustomOperation("indexTotal")>]
        member _.IndexTotal(state: Types.TransformIndexerStats, value: Types.Long) =
            { state with IndexTotal = value }

        [<CustomOperation("pagesProcessed")>]
        member _.PagesProcessed(state: Types.TransformIndexerStats, value: Types.Long) =
            { state with PagesProcessed = value }

        [<CustomOperation("processingTimeInMs")>]
        member _.ProcessingTimeInMs(state: Types.TransformIndexerStats, value: Types.DurationValue<Types.UnitMillis>) =
            { state with ProcessingTimeInMs = value }

        [<CustomOperation("processingTotal")>]
        member _.ProcessingTotal(state: Types.TransformIndexerStats, value: Types.Long) =
            { state with ProcessingTotal = value }

        [<CustomOperation("searchFailures")>]
        member _.SearchFailures(state: Types.TransformIndexerStats, value: Types.Long) =
            { state with SearchFailures = value }

        [<CustomOperation("searchTimeInMs")>]
        member _.SearchTimeInMs(state: Types.TransformIndexerStats, value: Types.DurationValue<Types.UnitMillis>) =
            { state with SearchTimeInMs = value }

        [<CustomOperation("searchTotal")>]
        member _.SearchTotal(state: Types.TransformIndexerStats, value: Types.Long) =
            { state with SearchTotal = value }

        [<CustomOperation("triggerCount")>]
        member _.TriggerCount(state: Types.TransformIndexerStats, value: Types.Long) =
            { state with TriggerCount = value }

    let transformIndexerStats = TransformIndexerStatsBuilder()

    type TransformProgressBuilder() =
        member _.Yield(_: unit) : Types.TransformProgress =
            {
                DocsIndexed = Unchecked.defaultof<_>
                DocsProcessed = Unchecked.defaultof<_>
                DocsRemaining = None
                PercentComplete = None
                TotalDocs = None
            }

        [<CustomOperation("docsIndexed")>]
        member _.DocsIndexed(state: Types.TransformProgress, value: Types.Long) =
            { state with DocsIndexed = value }

        [<CustomOperation("docsProcessed")>]
        member _.DocsProcessed(state: Types.TransformProgress, value: Types.Long) =
            { state with DocsProcessed = value }

        [<CustomOperation("docsRemaining")>]
        member _.DocsRemaining(state: Types.TransformProgress, value: Types.Long) =
            { state with DocsRemaining = Some value }

        [<CustomOperation("percentComplete")>]
        member _.PercentComplete(state: Types.TransformProgress, value: Types.Double) =
            { state with PercentComplete = Some value }

        [<CustomOperation("totalDocs")>]
        member _.TotalDocs(state: Types.TransformProgress, value: Types.Long) =
            { state with TotalDocs = Some value }

    let transformProgress = TransformProgressBuilder()

    type TransformStatsBuilder() =
        member _.Yield(_: unit) : Types.TransformStats =
            {
                Checkpointing = Unchecked.defaultof<_>
                Health = None
                Id = Unchecked.defaultof<_>
                Node = None
                Reason = None
                State = Unchecked.defaultof<_>
                Stats = Unchecked.defaultof<_>
            }

        [<CustomOperation("checkpointing")>]
        member _.Checkpointing(state: Types.TransformStats, value: Types.Checkpointing) =
            { state with Checkpointing = value }

        [<CustomOperation("health")>]
        member _.Health(state: Types.TransformStats, value: Types.TransformStatsHealth) =
            { state with Health = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: Types.TransformStats, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("node")>]
        member _.Node(state: Types.TransformStats, value: Types.NodeAttributes) =
            { state with Node = Some value }

        [<CustomOperation("reason")>]
        member _.Reason(state: Types.TransformStats, value: string) =
            { state with Reason = Some value }

        [<CustomOperation("state")>]
        member _.State(state: Types.TransformStats, value: string) =
            { state with State = value }

        [<CustomOperation("stats")>]
        member _.Stats(state: Types.TransformStats, value: Types.TransformIndexerStats) =
            { state with Stats = value }

    let transformStats = TransformStatsBuilder()


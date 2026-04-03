// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module SlmTypesBuilders =

    type ConfigurationBuilder() =
        member _.Yield(_: unit) : Configuration =
            {
                IgnoreUnavailable = None
                Indices = None
                IncludeGlobalState = None
                FeatureStates = None
                Metadata = None
                Partial = None
            }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: Configuration, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Configuration, value: CoreTypes.Indices) =
            { state with Indices = Some value }

        [<CustomOperation("includeGlobalState")>]
        member _.IncludeGlobalState(state: Configuration, value: bool) =
            { state with IncludeGlobalState = Some value }

        [<CustomOperation("featureStates")>]
        member _.FeatureStates(state: Configuration, value: string list) =
            { state with FeatureStates = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: Configuration, value: CoreTypes.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("partial")>]
        member _.Partial(state: Configuration, value: bool) =
            { state with Partial = Some value }

    let configuration = ConfigurationBuilder()

    type PolicyBuilder() =
        member _.Yield(_: unit) : Policy =
            {
                Config = None
                Name = Unchecked.defaultof<_>
                Repository = Unchecked.defaultof<_>
                Retention = None
                Schedule = Unchecked.defaultof<_>
            }

        [<CustomOperation("config")>]
        member _.Config(state: Policy, value: SlmTypes.Configuration) =
            { state with Config = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Policy, value: CoreTypes.Name) =
            { state with Name = value }

        [<CustomOperation("repository")>]
        member _.Repository(state: Policy, value: string) =
            { state with Repository = value }

        [<CustomOperation("retention")>]
        member _.Retention(state: Policy, value: SlmTypes.Retention) =
            { state with Retention = Some value }

        [<CustomOperation("schedule")>]
        member _.Schedule(state: Policy, value: WatcherTypes.CronExpression) =
            { state with Schedule = value }

    let policy = PolicyBuilder()

    type SnapshotLifecycleBuilder() =
        member _.Yield(_: unit) : SnapshotLifecycle =
            {
                InProgress = None
                LastFailure = None
                LastSuccess = None
                ModifiedDate = None
                ModifiedDateMillis = Unchecked.defaultof<_>
                NextExecution = None
                NextExecutionMillis = Unchecked.defaultof<_>
                Policy = Unchecked.defaultof<_>
                Version = Unchecked.defaultof<_>
                Stats = Unchecked.defaultof<_>
            }

        [<CustomOperation("inProgress")>]
        member _.InProgress(state: SnapshotLifecycle, value: SlmTypes.InProgress) =
            { state with InProgress = Some value }

        [<CustomOperation("lastFailure")>]
        member _.LastFailure(state: SnapshotLifecycle, value: SlmTypes.Invocation) =
            { state with LastFailure = Some value }

        [<CustomOperation("lastSuccess")>]
        member _.LastSuccess(state: SnapshotLifecycle, value: SlmTypes.Invocation) =
            { state with LastSuccess = Some value }

        [<CustomOperation("modifiedDate")>]
        member _.ModifiedDate(state: SnapshotLifecycle, value: CoreTypes.DateTime) =
            { state with ModifiedDate = Some value }

        [<CustomOperation("modifiedDateMillis")>]
        member _.ModifiedDateMillis(state: SnapshotLifecycle, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with ModifiedDateMillis = value }

        [<CustomOperation("nextExecution")>]
        member _.NextExecution(state: SnapshotLifecycle, value: CoreTypes.DateTime) =
            { state with NextExecution = Some value }

        [<CustomOperation("nextExecutionMillis")>]
        member _.NextExecutionMillis(state: SnapshotLifecycle, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with NextExecutionMillis = value }

        [<CustomOperation("policy")>]
        member _.Policy(state: SnapshotLifecycle, value: SlmTypes.Policy) =
            { state with Policy = value }

        [<CustomOperation("version")>]
        member _.Version(state: SnapshotLifecycle, value: CoreTypes.VersionNumber) =
            { state with Version = value }

        [<CustomOperation("stats")>]
        member _.Stats(state: SnapshotLifecycle, value: SlmTypes.Statistics) =
            { state with Stats = value }

    let snapshotLifecycle = SnapshotLifecycleBuilder()

    type StatisticsBuilder() =
        member _.Yield(_: unit) : Statistics =
            {
                RetentionDeletionTime = None
                RetentionDeletionTimeMillis = None
                RetentionFailed = None
                RetentionRuns = None
                RetentionTimedOut = None
                Policy = None
                TotalSnapshotsDeleted = None
                TotalSnapshotDeletionFailures = None
                TotalSnapshotsFailed = None
                TotalSnapshotsTaken = None
            }

        [<CustomOperation("retentionDeletionTime")>]
        member _.RetentionDeletionTime(state: Statistics, value: CoreTypes.Duration) =
            { state with RetentionDeletionTime = Some value }

        [<CustomOperation("retentionDeletionTimeMillis")>]
        member _.RetentionDeletionTimeMillis(state: Statistics, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with RetentionDeletionTimeMillis = Some value }

        [<CustomOperation("retentionFailed")>]
        member _.RetentionFailed(state: Statistics, value: CoreTypes.Long) =
            { state with RetentionFailed = Some value }

        [<CustomOperation("retentionRuns")>]
        member _.RetentionRuns(state: Statistics, value: CoreTypes.Long) =
            { state with RetentionRuns = Some value }

        [<CustomOperation("retentionTimedOut")>]
        member _.RetentionTimedOut(state: Statistics, value: CoreTypes.Long) =
            { state with RetentionTimedOut = Some value }

        [<CustomOperation("policy")>]
        member _.Policy(state: Statistics, value: CoreTypes.Id) =
            { state with Policy = Some value }

        [<CustomOperation("totalSnapshotsDeleted")>]
        member _.TotalSnapshotsDeleted(state: Statistics, value: CoreTypes.Long) =
            { state with TotalSnapshotsDeleted = Some value }

        [<CustomOperation("totalSnapshotDeletionFailures")>]
        member _.TotalSnapshotDeletionFailures(state: Statistics, value: CoreTypes.Long) =
            { state with TotalSnapshotDeletionFailures = Some value }

        [<CustomOperation("totalSnapshotsFailed")>]
        member _.TotalSnapshotsFailed(state: Statistics, value: CoreTypes.Long) =
            { state with TotalSnapshotsFailed = Some value }

        [<CustomOperation("totalSnapshotsTaken")>]
        member _.TotalSnapshotsTaken(state: Statistics, value: CoreTypes.Long) =
            { state with TotalSnapshotsTaken = Some value }

    let statistics = StatisticsBuilder()


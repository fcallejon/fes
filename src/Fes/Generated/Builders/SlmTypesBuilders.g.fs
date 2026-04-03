// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module SlmTypesBuilders =

    type ConfigurationBuilder() =
        member _.Yield(_: unit) : Types.Configuration =
            {
                IgnoreUnavailable = None
                Indices = None
                IncludeGlobalState = None
                FeatureStates = None
                Metadata = None
                Partial = None
            }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: Types.Configuration, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.Configuration, value: Types.Indices) =
            { state with Indices = Some value }

        [<CustomOperation("includeGlobalState")>]
        member _.IncludeGlobalState(state: Types.Configuration, value: bool) =
            { state with IncludeGlobalState = Some value }

        [<CustomOperation("featureStates")>]
        member _.FeatureStates(state: Types.Configuration, value: string list) =
            { state with FeatureStates = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: Types.Configuration, value: Types.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("partial")>]
        member _.Partial(state: Types.Configuration, value: bool) =
            { state with Partial = Some value }

    let configuration = ConfigurationBuilder()

    type SlmTypesPolicyBuilder() =
        member _.Yield(_: unit) : Types.SlmTypesPolicy =
            {
                Config = None
                Name = Unchecked.defaultof<_>
                Repository = Unchecked.defaultof<_>
                Retention = None
                Schedule = Unchecked.defaultof<_>
            }

        [<CustomOperation("config")>]
        member _.Config(state: Types.SlmTypesPolicy, value: Types.Configuration) =
            { state with Config = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Types.SlmTypesPolicy, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("repository")>]
        member _.Repository(state: Types.SlmTypesPolicy, value: string) =
            { state with Repository = value }

        [<CustomOperation("retention")>]
        member _.Retention(state: Types.SlmTypesPolicy, value: Types.Retention) =
            { state with Retention = Some value }

        [<CustomOperation("schedule")>]
        member _.Schedule(state: Types.SlmTypesPolicy, value: Types.CronExpression) =
            { state with Schedule = value }

    let slmTypesPolicy = SlmTypesPolicyBuilder()

    type SnapshotLifecycleBuilder() =
        member _.Yield(_: unit) : Types.SnapshotLifecycle =
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
        member _.InProgress(state: Types.SnapshotLifecycle, value: Types.InProgress) =
            { state with InProgress = Some value }

        [<CustomOperation("lastFailure")>]
        member _.LastFailure(state: Types.SnapshotLifecycle, value: Types.Invocation) =
            { state with LastFailure = Some value }

        [<CustomOperation("lastSuccess")>]
        member _.LastSuccess(state: Types.SnapshotLifecycle, value: Types.Invocation) =
            { state with LastSuccess = Some value }

        [<CustomOperation("modifiedDate")>]
        member _.ModifiedDate(state: Types.SnapshotLifecycle, value: Types.DateTime) =
            { state with ModifiedDate = Some value }

        [<CustomOperation("modifiedDateMillis")>]
        member _.ModifiedDateMillis(state: Types.SnapshotLifecycle, value: Types.EpochTime<Types.UnitMillis>) =
            { state with ModifiedDateMillis = value }

        [<CustomOperation("nextExecution")>]
        member _.NextExecution(state: Types.SnapshotLifecycle, value: Types.DateTime) =
            { state with NextExecution = Some value }

        [<CustomOperation("nextExecutionMillis")>]
        member _.NextExecutionMillis(state: Types.SnapshotLifecycle, value: Types.EpochTime<Types.UnitMillis>) =
            { state with NextExecutionMillis = value }

        [<CustomOperation("policy")>]
        member _.Policy(state: Types.SnapshotLifecycle, value: Types.SlmTypesPolicy) =
            { state with Policy = value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.SnapshotLifecycle, value: Types.VersionNumber) =
            { state with Version = value }

        [<CustomOperation("stats")>]
        member _.Stats(state: Types.SnapshotLifecycle, value: Types.Statistics) =
            { state with Stats = value }

    let snapshotLifecycle = SnapshotLifecycleBuilder()

    type StatisticsBuilder() =
        member _.Yield(_: unit) : Types.Statistics =
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
        member _.RetentionDeletionTime(state: Types.Statistics, value: Types.Duration) =
            { state with RetentionDeletionTime = Some value }

        [<CustomOperation("retentionDeletionTimeMillis")>]
        member _.RetentionDeletionTimeMillis(state: Types.Statistics, value: Types.DurationValue<Types.UnitMillis>) =
            { state with RetentionDeletionTimeMillis = Some value }

        [<CustomOperation("retentionFailed")>]
        member _.RetentionFailed(state: Types.Statistics, value: Types.Long) =
            { state with RetentionFailed = Some value }

        [<CustomOperation("retentionRuns")>]
        member _.RetentionRuns(state: Types.Statistics, value: Types.Long) =
            { state with RetentionRuns = Some value }

        [<CustomOperation("retentionTimedOut")>]
        member _.RetentionTimedOut(state: Types.Statistics, value: Types.Long) =
            { state with RetentionTimedOut = Some value }

        [<CustomOperation("policy")>]
        member _.Policy(state: Types.Statistics, value: Types.Id) =
            { state with Policy = Some value }

        [<CustomOperation("totalSnapshotsDeleted")>]
        member _.TotalSnapshotsDeleted(state: Types.Statistics, value: Types.Long) =
            { state with TotalSnapshotsDeleted = Some value }

        [<CustomOperation("totalSnapshotDeletionFailures")>]
        member _.TotalSnapshotDeletionFailures(state: Types.Statistics, value: Types.Long) =
            { state with TotalSnapshotDeletionFailures = Some value }

        [<CustomOperation("totalSnapshotsFailed")>]
        member _.TotalSnapshotsFailed(state: Types.Statistics, value: Types.Long) =
            { state with TotalSnapshotsFailed = Some value }

        [<CustomOperation("totalSnapshotsTaken")>]
        member _.TotalSnapshotsTaken(state: Types.Statistics, value: Types.Long) =
            { state with TotalSnapshotsTaken = Some value }

    let statistics = StatisticsBuilder()


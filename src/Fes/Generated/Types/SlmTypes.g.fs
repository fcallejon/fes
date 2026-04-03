// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SlmTypes =

    type Configuration = {
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unavailable")>]
        IgnoreUnavailable: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: CoreTypes.Indices option
        [<System.Text.Json.Serialization.JsonPropertyName("include_global_state")>]
        IncludeGlobalState: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_states")>]
        FeatureStates: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: CoreTypes.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("partial")>]
        Partial: bool option
    }

    type InProgress = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("start_time_millis")>]
        StartTimeMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: string
        [<System.Text.Json.Serialization.JsonPropertyName("uuid")>]
        Uuid: CoreTypes.Uuid
    }

    type Invocation = {
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot_name")>]
        SnapshotName: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("time")>]
        Time: CoreTypes.DateTime
    }

    type Retention = {
        [<System.Text.Json.Serialization.JsonPropertyName("expire_after")>]
        ExpireAfter: CoreTypes.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("max_count")>]
        MaxCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("min_count")>]
        MinCount: CoreTypes.Integer
    }

    type Policy = {
        [<System.Text.Json.Serialization.JsonPropertyName("config")>]
        Config: Configuration option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("repository")>]
        Repository: string
        [<System.Text.Json.Serialization.JsonPropertyName("retention")>]
        Retention: Retention option
        [<System.Text.Json.Serialization.JsonPropertyName("schedule")>]
        Schedule: WatcherTypes.CronExpression
    }

    type Statistics = {
        [<System.Text.Json.Serialization.JsonPropertyName("retention_deletion_time")>]
        RetentionDeletionTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("retention_deletion_time_millis")>]
        RetentionDeletionTimeMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("retention_failed")>]
        RetentionFailed: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("retention_runs")>]
        RetentionRuns: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("retention_timed_out")>]
        RetentionTimedOut: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("policy")>]
        Policy: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("total_snapshots_deleted")>]
        TotalSnapshotsDeleted: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_snapshot_deletion_failures")>]
        TotalSnapshotDeletionFailures: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_snapshots_failed")>]
        TotalSnapshotsFailed: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_snapshots_taken")>]
        TotalSnapshotsTaken: CoreTypes.Long option
    }

    type SnapshotLifecycle = {
        [<System.Text.Json.Serialization.JsonPropertyName("in_progress")>]
        InProgress: InProgress option
        [<System.Text.Json.Serialization.JsonPropertyName("last_failure")>]
        LastFailure: Invocation option
        [<System.Text.Json.Serialization.JsonPropertyName("last_success")>]
        LastSuccess: Invocation option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date")>]
        ModifiedDate: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date_millis")>]
        ModifiedDateMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("next_execution")>]
        NextExecution: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("next_execution_millis")>]
        NextExecutionMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("policy")>]
        Policy: Policy
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionNumber
        [<System.Text.Json.Serialization.JsonPropertyName("stats")>]
        Stats: Statistics
    }

    type SnapshotPolicyStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("policy")>]
        Policy: string
        [<System.Text.Json.Serialization.JsonPropertyName("snapshots_taken")>]
        SnapshotsTaken: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("snapshots_failed")>]
        SnapshotsFailed: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("snapshots_deleted")>]
        SnapshotsDeleted: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot_deletion_failures")>]
        SnapshotDeletionFailures: CoreTypes.Long
    }


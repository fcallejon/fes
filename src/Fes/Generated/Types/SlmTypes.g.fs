// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SlmTypes =

    type Configuration = {
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unavailable")>]
        IgnoreUnavailable: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: Types.Indices option
        [<System.Text.Json.Serialization.JsonPropertyName("include_global_state")>]
        IncludeGlobalState: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_states")>]
        FeatureStates: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("partial")>]
        Partial: bool option
    }

    type InProgress = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("start_time_millis")>]
        StartTimeMillis: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: string
        [<System.Text.Json.Serialization.JsonPropertyName("uuid")>]
        Uuid: Types.Uuid
    }

    type Invocation = {
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot_name")>]
        SnapshotName: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("time")>]
        Time: Types.DateTime
    }

    type Retention = {
        [<System.Text.Json.Serialization.JsonPropertyName("expire_after")>]
        ExpireAfter: Types.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("max_count")>]
        MaxCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("min_count")>]
        MinCount: Types.Integer
    }

    type Policy = {
        [<System.Text.Json.Serialization.JsonPropertyName("config")>]
        Config: SlmTypes.Configuration option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("repository")>]
        Repository: string
        [<System.Text.Json.Serialization.JsonPropertyName("retention")>]
        Retention: SlmTypes.Retention option
        [<System.Text.Json.Serialization.JsonPropertyName("schedule")>]
        Schedule: WatcherTypes.CronExpression
    }

    type Statistics = {
        [<System.Text.Json.Serialization.JsonPropertyName("retention_deletion_time")>]
        RetentionDeletionTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("retention_deletion_time_millis")>]
        RetentionDeletionTimeMillis: Types.DurationValue<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("retention_failed")>]
        RetentionFailed: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("retention_runs")>]
        RetentionRuns: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("retention_timed_out")>]
        RetentionTimedOut: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("policy")>]
        Policy: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("total_snapshots_deleted")>]
        TotalSnapshotsDeleted: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_snapshot_deletion_failures")>]
        TotalSnapshotDeletionFailures: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_snapshots_failed")>]
        TotalSnapshotsFailed: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_snapshots_taken")>]
        TotalSnapshotsTaken: Types.Long option
    }

    type SnapshotLifecycle = {
        [<System.Text.Json.Serialization.JsonPropertyName("in_progress")>]
        InProgress: SlmTypes.InProgress option
        [<System.Text.Json.Serialization.JsonPropertyName("last_failure")>]
        LastFailure: SlmTypes.Invocation option
        [<System.Text.Json.Serialization.JsonPropertyName("last_success")>]
        LastSuccess: SlmTypes.Invocation option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date")>]
        ModifiedDate: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date_millis")>]
        ModifiedDateMillis: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("next_execution")>]
        NextExecution: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("next_execution_millis")>]
        NextExecutionMillis: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("policy")>]
        Policy: SlmTypes.Policy
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionNumber
        [<System.Text.Json.Serialization.JsonPropertyName("stats")>]
        Stats: SlmTypes.Statistics
    }

    type SnapshotPolicyStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("policy")>]
        Policy: string
        [<System.Text.Json.Serialization.JsonPropertyName("snapshots_taken")>]
        SnapshotsTaken: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("snapshots_failed")>]
        SnapshotsFailed: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("snapshots_deleted")>]
        SnapshotsDeleted: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot_deletion_failures")>]
        SnapshotDeletionFailures: Types.Long
    }


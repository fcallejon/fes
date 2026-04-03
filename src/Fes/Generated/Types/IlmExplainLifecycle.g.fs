// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IlmExplainLifecycle =

    type LifecycleExplainPhaseExecution = {
        [<System.Text.Json.Serialization.JsonPropertyName("phase_definition")>]
        PhaseDefinition: IlmTypes.Phase option
        [<System.Text.Json.Serialization.JsonPropertyName("policy")>]
        Policy: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionNumber
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date_in_millis")>]
        ModifiedDateInMillis: Types.EpochTime<Types.UnitMillis>
    }

    type LifecycleExplainManaged = {
        [<System.Text.Json.Serialization.JsonPropertyName("action")>]
        Action: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("action_time")>]
        ActionTime: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("action_time_millis")>]
        ActionTimeMillis: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("age")>]
        Age: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("age_in_millis")>]
        AgeInMillis: Types.DurationValue<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("failed_step")>]
        FailedStep: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("failed_step_retry_count")>]
        FailedStepRetryCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("index_creation_date")>]
        IndexCreationDate: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("index_creation_date_millis")>]
        IndexCreationDateMillis: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("is_auto_retryable_error")>]
        IsAutoRetryableError: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle_date")>]
        LifecycleDate: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle_date_millis")>]
        LifecycleDateMillis: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("managed")>]
        Managed: string
        [<System.Text.Json.Serialization.JsonPropertyName("phase")>]
        Phase: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("phase_time")>]
        PhaseTime: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("phase_time_millis")>]
        PhaseTimeMillis: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("policy")>]
        Policy: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("previous_step_info")>]
        PreviousStepInfo: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("repository_name")>]
        RepositoryName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot_name")>]
        SnapshotName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("shrink_index_name")>]
        ShrinkIndexName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("step")>]
        Step: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("step_info")>]
        StepInfo: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("step_time")>]
        StepTime: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("step_time_millis")>]
        StepTimeMillis: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("phase_execution")>]
        PhaseExecution: IlmExplainLifecycle.LifecycleExplainPhaseExecution option
        [<System.Text.Json.Serialization.JsonPropertyName("time_since_index_creation")>]
        TimeSinceIndexCreation: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("skip")>]
        Skip: bool
    }

    type LifecycleExplainUnmanaged = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("managed")>]
        Managed: string
    }

    [<RequireQualifiedAccess>]
    type LifecycleExplain =
        | LifecycleExplainManaged of IlmExplainLifecycle.LifecycleExplainManaged
        | LifecycleExplainUnmanaged of IlmExplainLifecycle.LifecycleExplainUnmanaged


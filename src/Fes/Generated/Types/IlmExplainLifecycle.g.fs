// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IlmExplainLifecycle =

    type LifecycleExplainPhaseExecution = {
        [<System.Text.Json.Serialization.JsonPropertyName("phase_definition")>]
        PhaseDefinition: IlmTypes.Phase option
        [<System.Text.Json.Serialization.JsonPropertyName("policy")>]
        Policy: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionNumber
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date_in_millis")>]
        ModifiedDateInMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis>
    }

    type LifecycleExplainManaged = {
        [<System.Text.Json.Serialization.JsonPropertyName("action")>]
        Action: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("action_time")>]
        ActionTime: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("action_time_millis")>]
        ActionTimeMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("age")>]
        Age: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("age_in_millis")>]
        AgeInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("failed_step")>]
        FailedStep: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("failed_step_retry_count")>]
        FailedStepRetryCount: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("index_creation_date")>]
        IndexCreationDate: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("index_creation_date_millis")>]
        IndexCreationDateMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("is_auto_retryable_error")>]
        IsAutoRetryableError: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle_date")>]
        LifecycleDate: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle_date_millis")>]
        LifecycleDateMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("managed")>]
        Managed: string
        [<System.Text.Json.Serialization.JsonPropertyName("phase")>]
        Phase: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("phase_time")>]
        PhaseTime: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("phase_time_millis")>]
        PhaseTimeMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("policy")>]
        Policy: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("previous_step_info")>]
        PreviousStepInfo: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("repository_name")>]
        RepositoryName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot_name")>]
        SnapshotName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("shrink_index_name")>]
        ShrinkIndexName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("step")>]
        Step: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("step_info")>]
        StepInfo: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("step_time")>]
        StepTime: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("step_time_millis")>]
        StepTimeMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("phase_execution")>]
        PhaseExecution: LifecycleExplainPhaseExecution option
        [<System.Text.Json.Serialization.JsonPropertyName("time_since_index_creation")>]
        TimeSinceIndexCreation: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("skip")>]
        Skip: bool
    }

    type LifecycleExplainUnmanaged = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("managed")>]
        Managed: string
    }

    [<RequireQualifiedAccess>]
    type LifecycleExplain =
        | LifecycleExplainManaged of LifecycleExplainManaged
        | LifecycleExplainUnmanaged of LifecycleExplainUnmanaged


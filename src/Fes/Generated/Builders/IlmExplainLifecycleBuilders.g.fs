// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module IlmExplainLifecycleBuilders =

    type LifecycleExplainManagedBuilder() =
        member _.Yield(_: unit) : LifecycleExplainManaged =
            {
                Action = None
                ActionTime = None
                ActionTimeMillis = None
                Age = None
                AgeInMillis = None
                FailedStep = None
                FailedStepRetryCount = None
                Index = Unchecked.defaultof<_>
                IndexCreationDate = None
                IndexCreationDateMillis = None
                IsAutoRetryableError = None
                LifecycleDate = None
                LifecycleDateMillis = None
                Managed = Unchecked.defaultof<_>
                Phase = None
                PhaseTime = None
                PhaseTimeMillis = None
                Policy = None
                PreviousStepInfo = None
                RepositoryName = None
                SnapshotName = None
                ShrinkIndexName = None
                Step = None
                StepInfo = None
                StepTime = None
                StepTimeMillis = None
                PhaseExecution = None
                TimeSinceIndexCreation = None
                Skip = Unchecked.defaultof<_>
            }

        [<CustomOperation("action")>]
        member _.Action(state: LifecycleExplainManaged, value: CoreTypes.Name) =
            { state with Action = Some value }

        [<CustomOperation("actionTime")>]
        member _.ActionTime(state: LifecycleExplainManaged, value: CoreTypes.DateTime) =
            { state with ActionTime = Some value }

        [<CustomOperation("actionTimeMillis")>]
        member _.ActionTimeMillis(state: LifecycleExplainManaged, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with ActionTimeMillis = Some value }

        [<CustomOperation("age")>]
        member _.Age(state: LifecycleExplainManaged, value: CoreTypes.Duration) =
            { state with Age = Some value }

        [<CustomOperation("ageInMillis")>]
        member _.AgeInMillis(state: LifecycleExplainManaged, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with AgeInMillis = Some value }

        [<CustomOperation("failedStep")>]
        member _.FailedStep(state: LifecycleExplainManaged, value: CoreTypes.Name) =
            { state with FailedStep = Some value }

        [<CustomOperation("failedStepRetryCount")>]
        member _.FailedStepRetryCount(state: LifecycleExplainManaged, value: CoreTypes.Integer) =
            { state with FailedStepRetryCount = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: LifecycleExplainManaged, value: CoreTypes.IndexName) =
            { state with Index = value }

        [<CustomOperation("indexCreationDate")>]
        member _.IndexCreationDate(state: LifecycleExplainManaged, value: CoreTypes.DateTime) =
            { state with IndexCreationDate = Some value }

        [<CustomOperation("indexCreationDateMillis")>]
        member _.IndexCreationDateMillis(state: LifecycleExplainManaged, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with IndexCreationDateMillis = Some value }

        [<CustomOperation("isAutoRetryableError")>]
        member _.IsAutoRetryableError(state: LifecycleExplainManaged, value: bool) =
            { state with IsAutoRetryableError = Some value }

        [<CustomOperation("lifecycleDate")>]
        member _.LifecycleDate(state: LifecycleExplainManaged, value: CoreTypes.DateTime) =
            { state with LifecycleDate = Some value }

        [<CustomOperation("lifecycleDateMillis")>]
        member _.LifecycleDateMillis(state: LifecycleExplainManaged, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with LifecycleDateMillis = Some value }

        [<CustomOperation("managed")>]
        member _.Managed(state: LifecycleExplainManaged, value: string) =
            { state with Managed = value }

        [<CustomOperation("phase")>]
        member _.Phase(state: LifecycleExplainManaged, value: CoreTypes.Name) =
            { state with Phase = Some value }

        [<CustomOperation("phaseTime")>]
        member _.PhaseTime(state: LifecycleExplainManaged, value: CoreTypes.DateTime) =
            { state with PhaseTime = Some value }

        [<CustomOperation("phaseTimeMillis")>]
        member _.PhaseTimeMillis(state: LifecycleExplainManaged, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with PhaseTimeMillis = Some value }

        [<CustomOperation("policy")>]
        member _.Policy(state: LifecycleExplainManaged, value: CoreTypes.Name) =
            { state with Policy = Some value }

        [<CustomOperation("previousStepInfo")>]
        member _.PreviousStepInfo(state: LifecycleExplainManaged, value: Map<string, System.Text.Json.JsonElement>) =
            { state with PreviousStepInfo = Some value }

        [<CustomOperation("repositoryName")>]
        member _.RepositoryName(state: LifecycleExplainManaged, value: string) =
            { state with RepositoryName = Some value }

        [<CustomOperation("snapshotName")>]
        member _.SnapshotName(state: LifecycleExplainManaged, value: string) =
            { state with SnapshotName = Some value }

        [<CustomOperation("shrinkIndexName")>]
        member _.ShrinkIndexName(state: LifecycleExplainManaged, value: string) =
            { state with ShrinkIndexName = Some value }

        [<CustomOperation("step")>]
        member _.Step(state: LifecycleExplainManaged, value: CoreTypes.Name) =
            { state with Step = Some value }

        [<CustomOperation("stepInfo")>]
        member _.StepInfo(state: LifecycleExplainManaged, value: Map<string, System.Text.Json.JsonElement>) =
            { state with StepInfo = Some value }

        [<CustomOperation("stepTime")>]
        member _.StepTime(state: LifecycleExplainManaged, value: CoreTypes.DateTime) =
            { state with StepTime = Some value }

        [<CustomOperation("stepTimeMillis")>]
        member _.StepTimeMillis(state: LifecycleExplainManaged, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with StepTimeMillis = Some value }

        [<CustomOperation("phaseExecution")>]
        member _.PhaseExecution(state: LifecycleExplainManaged, value: IlmExplainLifecycle.LifecycleExplainPhaseExecution) =
            { state with PhaseExecution = Some value }

        [<CustomOperation("timeSinceIndexCreation")>]
        member _.TimeSinceIndexCreation(state: LifecycleExplainManaged, value: CoreTypes.Duration) =
            { state with TimeSinceIndexCreation = Some value }

        [<CustomOperation("skip")>]
        member _.Skip(state: LifecycleExplainManaged, value: bool) =
            { state with Skip = value }

    let lifecycleExplainManaged = LifecycleExplainManagedBuilder()


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module IlmTypesBuilders =

    type ActionsBuilder() =
        member _.Yield(_: unit) : Actions =
            {
                Allocate = None
                Delete = None
                Downsample = None
                Freeze = None
                Forcemerge = None
                Migrate = None
                Readonly = None
                Rollover = None
                SetPriority = None
                SearchableSnapshot = None
                Shrink = None
                Unfollow = None
                WaitForSnapshot = None
            }

        [<CustomOperation("allocate")>]
        member _.Allocate(state: Actions, value: IlmTypes.AllocateAction) =
            { state with Allocate = Some value }

        [<CustomOperation("delete")>]
        member _.Delete(state: Actions, value: IlmTypes.DeleteAction) =
            { state with Delete = Some value }

        [<CustomOperation("downsample")>]
        member _.Downsample(state: Actions, value: IlmTypes.DownsampleAction) =
            { state with Downsample = Some value }

        [<CustomOperation("freeze")>]
        member _.Freeze(state: Actions, value: CoreTypes.EmptyObject) =
            { state with Freeze = Some value }

        [<CustomOperation("forcemerge")>]
        member _.Forcemerge(state: Actions, value: IlmTypes.ForceMergeAction) =
            { state with Forcemerge = Some value }

        [<CustomOperation("migrate")>]
        member _.Migrate(state: Actions, value: IlmTypes.MigrateAction) =
            { state with Migrate = Some value }

        [<CustomOperation("readonly")>]
        member _.Readonly(state: Actions, value: CoreTypes.EmptyObject) =
            { state with Readonly = Some value }

        [<CustomOperation("rollover")>]
        member _.Rollover(state: Actions, value: IlmTypes.RolloverAction) =
            { state with Rollover = Some value }

        [<CustomOperation("setPriority")>]
        member _.SetPriority(state: Actions, value: IlmTypes.SetPriorityAction) =
            { state with SetPriority = Some value }

        [<CustomOperation("searchableSnapshot")>]
        member _.SearchableSnapshot(state: Actions, value: IlmTypes.SearchableSnapshotAction) =
            { state with SearchableSnapshot = Some value }

        [<CustomOperation("shrink")>]
        member _.Shrink(state: Actions, value: IlmTypes.ShrinkAction) =
            { state with Shrink = Some value }

        [<CustomOperation("unfollow")>]
        member _.Unfollow(state: Actions, value: CoreTypes.EmptyObject) =
            { state with Unfollow = Some value }

        [<CustomOperation("waitForSnapshot")>]
        member _.WaitForSnapshot(state: Actions, value: IlmTypes.WaitForSnapshotAction) =
            { state with WaitForSnapshot = Some value }

    let actions = ActionsBuilder()

    type AllocateActionBuilder() =
        member _.Yield(_: unit) : AllocateAction =
            {
                NumberOfReplicas = None
                TotalShardsPerNode = None
                Include = None
                Exclude = None
                Require = None
            }

        [<CustomOperation("numberOfReplicas")>]
        member _.NumberOfReplicas(state: AllocateAction, value: CoreTypes.Integer) =
            { state with NumberOfReplicas = Some value }

        [<CustomOperation("totalShardsPerNode")>]
        member _.TotalShardsPerNode(state: AllocateAction, value: CoreTypes.Integer) =
            { state with TotalShardsPerNode = Some value }

        [<CustomOperation("include")>]
        member _.Include(state: AllocateAction, value: Map<string, string>) =
            { state with Include = Some value }

        [<CustomOperation("exclude")>]
        member _.Exclude(state: AllocateAction, value: Map<string, string>) =
            { state with Exclude = Some value }

        [<CustomOperation("require")>]
        member _.Require(state: AllocateAction, value: Map<string, string>) =
            { state with Require = Some value }

    let allocateAction = AllocateActionBuilder()

    type PhaseBuilder() =
        member _.Yield(_: unit) : Phase =
            {
                Actions = None
                MinAge = None
            }

        [<CustomOperation("actions")>]
        member _.Actions(state: Phase, value: IlmTypes.Actions) =
            { state with Actions = Some value }

        [<CustomOperation("minAge")>]
        member _.MinAge(state: Phase, value: CoreTypes.Duration) =
            { state with MinAge = Some value }

    let phase = PhaseBuilder()

    type PhasesBuilder() =
        member _.Yield(_: unit) : Phases =
            {
                Cold = None
                Delete = None
                Frozen = None
                Hot = None
                Warm = None
            }

        [<CustomOperation("cold")>]
        member _.Cold(state: Phases, value: IlmTypes.Phase) =
            { state with Cold = Some value }

        [<CustomOperation("delete")>]
        member _.Delete(state: Phases, value: IlmTypes.Phase) =
            { state with Delete = Some value }

        [<CustomOperation("frozen")>]
        member _.Frozen(state: Phases, value: IlmTypes.Phase) =
            { state with Frozen = Some value }

        [<CustomOperation("hot")>]
        member _.Hot(state: Phases, value: IlmTypes.Phase) =
            { state with Hot = Some value }

        [<CustomOperation("warm")>]
        member _.Warm(state: Phases, value: IlmTypes.Phase) =
            { state with Warm = Some value }

    let phases = PhasesBuilder()

    type RolloverActionBuilder() =
        member _.Yield(_: unit) : RolloverAction =
            {
                MaxSize = None
                MaxPrimaryShardSize = None
                MaxAge = None
                MaxDocs = None
                MaxPrimaryShardDocs = None
                MinSize = None
                MinPrimaryShardSize = None
                MinAge = None
                MinDocs = None
                MinPrimaryShardDocs = None
            }

        [<CustomOperation("maxSize")>]
        member _.MaxSize(state: RolloverAction, value: CoreTypes.ByteSize) =
            { state with MaxSize = Some value }

        [<CustomOperation("maxPrimaryShardSize")>]
        member _.MaxPrimaryShardSize(state: RolloverAction, value: CoreTypes.ByteSize) =
            { state with MaxPrimaryShardSize = Some value }

        [<CustomOperation("maxAge")>]
        member _.MaxAge(state: RolloverAction, value: CoreTypes.Duration) =
            { state with MaxAge = Some value }

        [<CustomOperation("maxDocs")>]
        member _.MaxDocs(state: RolloverAction, value: CoreTypes.Long) =
            { state with MaxDocs = Some value }

        [<CustomOperation("maxPrimaryShardDocs")>]
        member _.MaxPrimaryShardDocs(state: RolloverAction, value: CoreTypes.Long) =
            { state with MaxPrimaryShardDocs = Some value }

        [<CustomOperation("minSize")>]
        member _.MinSize(state: RolloverAction, value: CoreTypes.ByteSize) =
            { state with MinSize = Some value }

        [<CustomOperation("minPrimaryShardSize")>]
        member _.MinPrimaryShardSize(state: RolloverAction, value: CoreTypes.ByteSize) =
            { state with MinPrimaryShardSize = Some value }

        [<CustomOperation("minAge")>]
        member _.MinAge(state: RolloverAction, value: CoreTypes.Duration) =
            { state with MinAge = Some value }

        [<CustomOperation("minDocs")>]
        member _.MinDocs(state: RolloverAction, value: CoreTypes.Long) =
            { state with MinDocs = Some value }

        [<CustomOperation("minPrimaryShardDocs")>]
        member _.MinPrimaryShardDocs(state: RolloverAction, value: CoreTypes.Long) =
            { state with MinPrimaryShardDocs = Some value }

    let rolloverAction = RolloverActionBuilder()

    type ShrinkActionBuilder() =
        member _.Yield(_: unit) : ShrinkAction =
            {
                NumberOfShards = None
                MaxPrimaryShardSize = None
                AllowWriteAfterShrink = None
            }

        [<CustomOperation("numberOfShards")>]
        member _.NumberOfShards(state: ShrinkAction, value: CoreTypes.Integer) =
            { state with NumberOfShards = Some value }

        [<CustomOperation("maxPrimaryShardSize")>]
        member _.MaxPrimaryShardSize(state: ShrinkAction, value: CoreTypes.ByteSize) =
            { state with MaxPrimaryShardSize = Some value }

        [<CustomOperation("allowWriteAfterShrink")>]
        member _.AllowWriteAfterShrink(state: ShrinkAction, value: bool) =
            { state with AllowWriteAfterShrink = Some value }

    let shrinkAction = ShrinkActionBuilder()


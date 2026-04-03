// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module IlmTypesBuilders =

    type IlmTypesActionsBuilder() =
        member _.Yield(_: unit) : Types.IlmTypesActions =
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
        member _.Allocate(state: Types.IlmTypesActions, value: Types.AllocateAction) =
            { state with Allocate = Some value }

        [<CustomOperation("delete")>]
        member _.Delete(state: Types.IlmTypesActions, value: Types.DeleteAction) =
            { state with Delete = Some value }

        [<CustomOperation("downsample")>]
        member _.Downsample(state: Types.IlmTypesActions, value: Types.DownsampleAction) =
            { state with Downsample = Some value }

        [<CustomOperation("freeze")>]
        member _.Freeze(state: Types.IlmTypesActions, value: Types.EmptyObject) =
            { state with Freeze = Some value }

        [<CustomOperation("forcemerge")>]
        member _.Forcemerge(state: Types.IlmTypesActions, value: Types.ForceMergeAction) =
            { state with Forcemerge = Some value }

        [<CustomOperation("migrate")>]
        member _.Migrate(state: Types.IlmTypesActions, value: Types.MigrateAction) =
            { state with Migrate = Some value }

        [<CustomOperation("readonly")>]
        member _.Readonly(state: Types.IlmTypesActions, value: Types.EmptyObject) =
            { state with Readonly = Some value }

        [<CustomOperation("rollover")>]
        member _.Rollover(state: Types.IlmTypesActions, value: Types.RolloverAction) =
            { state with Rollover = Some value }

        [<CustomOperation("setPriority")>]
        member _.SetPriority(state: Types.IlmTypesActions, value: Types.SetPriorityAction) =
            { state with SetPriority = Some value }

        [<CustomOperation("searchableSnapshot")>]
        member _.SearchableSnapshot(state: Types.IlmTypesActions, value: Types.SearchableSnapshotAction) =
            { state with SearchableSnapshot = Some value }

        [<CustomOperation("shrink")>]
        member _.Shrink(state: Types.IlmTypesActions, value: Types.ShrinkAction) =
            { state with Shrink = Some value }

        [<CustomOperation("unfollow")>]
        member _.Unfollow(state: Types.IlmTypesActions, value: Types.EmptyObject) =
            { state with Unfollow = Some value }

        [<CustomOperation("waitForSnapshot")>]
        member _.WaitForSnapshot(state: Types.IlmTypesActions, value: Types.WaitForSnapshotAction) =
            { state with WaitForSnapshot = Some value }

    let ilmTypesActions = IlmTypesActionsBuilder()

    type AllocateActionBuilder() =
        member _.Yield(_: unit) : Types.AllocateAction =
            {
                NumberOfReplicas = None
                TotalShardsPerNode = None
                Include = None
                Exclude = None
                Require = None
            }

        [<CustomOperation("numberOfReplicas")>]
        member _.NumberOfReplicas(state: Types.AllocateAction, value: Types.Integer) =
            { state with NumberOfReplicas = Some value }

        [<CustomOperation("totalShardsPerNode")>]
        member _.TotalShardsPerNode(state: Types.AllocateAction, value: Types.Integer) =
            { state with TotalShardsPerNode = Some value }

        [<CustomOperation("include")>]
        member _.Include(state: Types.AllocateAction, value: Map<string, string>) =
            { state with Include = Some value }

        [<CustomOperation("exclude")>]
        member _.Exclude(state: Types.AllocateAction, value: Map<string, string>) =
            { state with Exclude = Some value }

        [<CustomOperation("require")>]
        member _.Require(state: Types.AllocateAction, value: Map<string, string>) =
            { state with Require = Some value }

    let allocateAction = AllocateActionBuilder()

    type IlmTypesPhaseBuilder() =
        member _.Yield(_: unit) : Types.IlmTypesPhase =
            {
                Actions = None
                MinAge = None
            }

        [<CustomOperation("actions")>]
        member _.Actions(state: Types.IlmTypesPhase, value: Types.IlmTypesActions) =
            { state with Actions = Some value }

        [<CustomOperation("minAge")>]
        member _.MinAge(state: Types.IlmTypesPhase, value: Types.Duration) =
            { state with MinAge = Some value }

    let ilmTypesPhase = IlmTypesPhaseBuilder()

    type IlmTypesPhasesBuilder() =
        member _.Yield(_: unit) : Types.IlmTypesPhases =
            {
                Cold = None
                Delete = None
                Frozen = None
                Hot = None
                Warm = None
            }

        [<CustomOperation("cold")>]
        member _.Cold(state: Types.IlmTypesPhases, value: Types.IlmTypesPhase) =
            { state with Cold = Some value }

        [<CustomOperation("delete")>]
        member _.Delete(state: Types.IlmTypesPhases, value: Types.IlmTypesPhase) =
            { state with Delete = Some value }

        [<CustomOperation("frozen")>]
        member _.Frozen(state: Types.IlmTypesPhases, value: Types.IlmTypesPhase) =
            { state with Frozen = Some value }

        [<CustomOperation("hot")>]
        member _.Hot(state: Types.IlmTypesPhases, value: Types.IlmTypesPhase) =
            { state with Hot = Some value }

        [<CustomOperation("warm")>]
        member _.Warm(state: Types.IlmTypesPhases, value: Types.IlmTypesPhase) =
            { state with Warm = Some value }

    let ilmTypesPhases = IlmTypesPhasesBuilder()

    type RolloverActionBuilder() =
        member _.Yield(_: unit) : Types.RolloverAction =
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
        member _.MaxSize(state: Types.RolloverAction, value: Types.ByteSize) =
            { state with MaxSize = Some value }

        [<CustomOperation("maxPrimaryShardSize")>]
        member _.MaxPrimaryShardSize(state: Types.RolloverAction, value: Types.ByteSize) =
            { state with MaxPrimaryShardSize = Some value }

        [<CustomOperation("maxAge")>]
        member _.MaxAge(state: Types.RolloverAction, value: Types.Duration) =
            { state with MaxAge = Some value }

        [<CustomOperation("maxDocs")>]
        member _.MaxDocs(state: Types.RolloverAction, value: Types.Long) =
            { state with MaxDocs = Some value }

        [<CustomOperation("maxPrimaryShardDocs")>]
        member _.MaxPrimaryShardDocs(state: Types.RolloverAction, value: Types.Long) =
            { state with MaxPrimaryShardDocs = Some value }

        [<CustomOperation("minSize")>]
        member _.MinSize(state: Types.RolloverAction, value: Types.ByteSize) =
            { state with MinSize = Some value }

        [<CustomOperation("minPrimaryShardSize")>]
        member _.MinPrimaryShardSize(state: Types.RolloverAction, value: Types.ByteSize) =
            { state with MinPrimaryShardSize = Some value }

        [<CustomOperation("minAge")>]
        member _.MinAge(state: Types.RolloverAction, value: Types.Duration) =
            { state with MinAge = Some value }

        [<CustomOperation("minDocs")>]
        member _.MinDocs(state: Types.RolloverAction, value: Types.Long) =
            { state with MinDocs = Some value }

        [<CustomOperation("minPrimaryShardDocs")>]
        member _.MinPrimaryShardDocs(state: Types.RolloverAction, value: Types.Long) =
            { state with MinPrimaryShardDocs = Some value }

    let rolloverAction = RolloverActionBuilder()

    type ShrinkActionBuilder() =
        member _.Yield(_: unit) : Types.ShrinkAction =
            {
                NumberOfShards = None
                MaxPrimaryShardSize = None
                AllowWriteAfterShrink = None
            }

        [<CustomOperation("numberOfShards")>]
        member _.NumberOfShards(state: Types.ShrinkAction, value: Types.Integer) =
            { state with NumberOfShards = Some value }

        [<CustomOperation("maxPrimaryShardSize")>]
        member _.MaxPrimaryShardSize(state: Types.ShrinkAction, value: Types.ByteSize) =
            { state with MaxPrimaryShardSize = Some value }

        [<CustomOperation("allowWriteAfterShrink")>]
        member _.AllowWriteAfterShrink(state: Types.ShrinkAction, value: bool) =
            { state with AllowWriteAfterShrink = Some value }

    let shrinkAction = ShrinkActionBuilder()


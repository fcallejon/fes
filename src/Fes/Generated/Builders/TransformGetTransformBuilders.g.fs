// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module TransformGetTransformBuilders =

    type TransformSummaryBuilder() =
        member _.Yield(_: unit) : TransformSummary =
            {
                Authorization = None
                CreateTime = None
                CreateTimeString = None
                Description = None
                Dest = Unchecked.defaultof<_>
                Frequency = None
                Id = Unchecked.defaultof<_>
                Latest = None
                Pivot = None
                RetentionPolicy = None
                Settings = None
                Source = Unchecked.defaultof<_>
                Sync = None
                Version = None
                Meta = None
            }

        [<CustomOperation("authorization")>]
        member _.Authorization(state: TransformSummary, value: MlTypes.TransformAuthorization) =
            { state with Authorization = Some value }

        [<CustomOperation("createTime")>]
        member _.CreateTime(state: TransformSummary, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with CreateTime = Some value }

        [<CustomOperation("createTimeString")>]
        member _.CreateTimeString(state: TransformSummary, value: CoreTypes.DateTime) =
            { state with CreateTimeString = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: TransformSummary, value: string) =
            { state with Description = Some value }

        [<CustomOperation("dest")>]
        member _.Dest(state: TransformSummary, value: GlobalReindex.Destination) =
            { state with Dest = value }

        [<CustomOperation("frequency")>]
        member _.Frequency(state: TransformSummary, value: CoreTypes.Duration) =
            { state with Frequency = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: TransformSummary, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("latest")>]
        member _.Latest(state: TransformSummary, value: TransformTypes.Latest) =
            { state with Latest = Some value }

        [<CustomOperation("pivot")>]
        member _.Pivot(state: TransformSummary, value: TransformTypes.Pivot) =
            { state with Pivot = Some value }

        [<CustomOperation("retentionPolicy")>]
        member _.RetentionPolicy(state: TransformSummary, value: TransformTypes.RetentionPolicyContainer) =
            { state with RetentionPolicy = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: TransformSummary, value: TransformTypes.Settings) =
            { state with Settings = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: TransformSummary, value: TransformTypes.Source) =
            { state with Source = value }

        [<CustomOperation("sync")>]
        member _.Sync(state: TransformSummary, value: TransformTypes.SyncContainer) =
            { state with Sync = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: TransformSummary, value: CoreTypes.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: TransformSummary, value: CoreTypes.Metadata) =
            { state with Meta = Some value }

    let transformSummary = TransformSummaryBuilder()


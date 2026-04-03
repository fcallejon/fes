// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module TransformGetTransformBuilders =

    type TransformSummaryBuilder() =
        member _.Yield(_: unit) : Types.TransformSummary =
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
        member _.Authorization(state: Types.TransformSummary, value: Types.TransformAuthorization) =
            { state with Authorization = Some value }

        [<CustomOperation("createTime")>]
        member _.CreateTime(state: Types.TransformSummary, value: Types.EpochTime<Types.UnitMillis>) =
            { state with CreateTime = Some value }

        [<CustomOperation("createTimeString")>]
        member _.CreateTimeString(state: Types.TransformSummary, value: Types.DateTime) =
            { state with CreateTimeString = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.TransformSummary, value: string) =
            { state with Description = Some value }

        [<CustomOperation("dest")>]
        member _.Dest(state: Types.TransformSummary, value: Types.GlobalReindexDestination) =
            { state with Dest = value }

        [<CustomOperation("frequency")>]
        member _.Frequency(state: Types.TransformSummary, value: Types.Duration) =
            { state with Frequency = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: Types.TransformSummary, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("latest")>]
        member _.Latest(state: Types.TransformSummary, value: Types.Latest) =
            { state with Latest = Some value }

        [<CustomOperation("pivot")>]
        member _.Pivot(state: Types.TransformSummary, value: Types.Pivot) =
            { state with Pivot = Some value }

        [<CustomOperation("retentionPolicy")>]
        member _.RetentionPolicy(state: Types.TransformSummary, value: Types.RetentionPolicyContainer) =
            { state with RetentionPolicy = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: Types.TransformSummary, value: Types.Settings) =
            { state with Settings = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: Types.TransformSummary, value: Types.TransformTypesSource) =
            { state with Source = value }

        [<CustomOperation("sync")>]
        member _.Sync(state: Types.TransformSummary, value: Types.SyncContainer) =
            { state with Sync = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.TransformSummary, value: Types.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.TransformSummary, value: Types.Metadata) =
            { state with Meta = Some value }

    let transformSummary = TransformSummaryBuilder()


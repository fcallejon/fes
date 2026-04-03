// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module IndicesRolloverBuilders =

    type RolloverConditionsBuilder() =
        member _.Yield(_: unit) : Types.RolloverConditions =
            {
                MinAge = None
                MaxAge = None
                MaxAgeMillis = None
                MinDocs = None
                MaxDocs = None
                MaxSize = None
                MaxSizeBytes = None
                MinSize = None
                MinSizeBytes = None
                MaxPrimaryShardSize = None
                MaxPrimaryShardSizeBytes = None
                MinPrimaryShardSize = None
                MinPrimaryShardSizeBytes = None
                MaxPrimaryShardDocs = None
                MinPrimaryShardDocs = None
            }

        [<CustomOperation("minAge")>]
        member _.MinAge(state: Types.RolloverConditions, value: Types.Duration) =
            { state with MinAge = Some value }

        [<CustomOperation("maxAge")>]
        member _.MaxAge(state: Types.RolloverConditions, value: Types.Duration) =
            { state with MaxAge = Some value }

        [<CustomOperation("maxAgeMillis")>]
        member _.MaxAgeMillis(state: Types.RolloverConditions, value: Types.DurationValue<Types.UnitMillis>) =
            { state with MaxAgeMillis = Some value }

        [<CustomOperation("minDocs")>]
        member _.MinDocs(state: Types.RolloverConditions, value: Types.Long) =
            { state with MinDocs = Some value }

        [<CustomOperation("maxDocs")>]
        member _.MaxDocs(state: Types.RolloverConditions, value: Types.Long) =
            { state with MaxDocs = Some value }

        [<CustomOperation("maxSize")>]
        member _.MaxSize(state: Types.RolloverConditions, value: Types.ByteSize) =
            { state with MaxSize = Some value }

        [<CustomOperation("maxSizeBytes")>]
        member _.MaxSizeBytes(state: Types.RolloverConditions, value: Types.Long) =
            { state with MaxSizeBytes = Some value }

        [<CustomOperation("minSize")>]
        member _.MinSize(state: Types.RolloverConditions, value: Types.ByteSize) =
            { state with MinSize = Some value }

        [<CustomOperation("minSizeBytes")>]
        member _.MinSizeBytes(state: Types.RolloverConditions, value: Types.Long) =
            { state with MinSizeBytes = Some value }

        [<CustomOperation("maxPrimaryShardSize")>]
        member _.MaxPrimaryShardSize(state: Types.RolloverConditions, value: Types.ByteSize) =
            { state with MaxPrimaryShardSize = Some value }

        [<CustomOperation("maxPrimaryShardSizeBytes")>]
        member _.MaxPrimaryShardSizeBytes(state: Types.RolloverConditions, value: Types.Long) =
            { state with MaxPrimaryShardSizeBytes = Some value }

        [<CustomOperation("minPrimaryShardSize")>]
        member _.MinPrimaryShardSize(state: Types.RolloverConditions, value: Types.ByteSize) =
            { state with MinPrimaryShardSize = Some value }

        [<CustomOperation("minPrimaryShardSizeBytes")>]
        member _.MinPrimaryShardSizeBytes(state: Types.RolloverConditions, value: Types.Long) =
            { state with MinPrimaryShardSizeBytes = Some value }

        [<CustomOperation("maxPrimaryShardDocs")>]
        member _.MaxPrimaryShardDocs(state: Types.RolloverConditions, value: Types.Long) =
            { state with MaxPrimaryShardDocs = Some value }

        [<CustomOperation("minPrimaryShardDocs")>]
        member _.MinPrimaryShardDocs(state: Types.RolloverConditions, value: Types.Long) =
            { state with MinPrimaryShardDocs = Some value }

    let rolloverConditions = RolloverConditionsBuilder()


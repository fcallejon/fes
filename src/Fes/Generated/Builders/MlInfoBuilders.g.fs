// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module MlInfoBuilders =

    type LimitsBuilder() =
        member _.Yield(_: unit) : Types.Limits =
            {
                MaxSingleMlNodeProcessors = None
                TotalMlProcessors = None
                MaxModelMemoryLimit = None
                EffectiveMaxModelMemoryLimit = None
                TotalMlMemory = Unchecked.defaultof<_>
            }

        [<CustomOperation("maxSingleMlNodeProcessors")>]
        member _.MaxSingleMlNodeProcessors(state: Types.Limits, value: Types.Integer) =
            { state with MaxSingleMlNodeProcessors = Some value }

        [<CustomOperation("totalMlProcessors")>]
        member _.TotalMlProcessors(state: Types.Limits, value: Types.Integer) =
            { state with TotalMlProcessors = Some value }

        [<CustomOperation("maxModelMemoryLimit")>]
        member _.MaxModelMemoryLimit(state: Types.Limits, value: Types.ByteSize) =
            { state with MaxModelMemoryLimit = Some value }

        [<CustomOperation("effectiveMaxModelMemoryLimit")>]
        member _.EffectiveMaxModelMemoryLimit(state: Types.Limits, value: Types.ByteSize) =
            { state with EffectiveMaxModelMemoryLimit = Some value }

        [<CustomOperation("totalMlMemory")>]
        member _.TotalMlMemory(state: Types.Limits, value: Types.ByteSize) =
            { state with TotalMlMemory = value }

    let limits = LimitsBuilder()


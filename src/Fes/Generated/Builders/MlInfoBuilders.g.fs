// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module MlInfoBuilders =

    type LimitsBuilder() =
        member _.Yield(_: unit) : Limits =
            {
                MaxSingleMlNodeProcessors = None
                TotalMlProcessors = None
                MaxModelMemoryLimit = None
                EffectiveMaxModelMemoryLimit = None
                TotalMlMemory = Unchecked.defaultof<_>
            }

        [<CustomOperation("maxSingleMlNodeProcessors")>]
        member _.MaxSingleMlNodeProcessors(state: Limits, value: CoreTypes.Integer) =
            { state with MaxSingleMlNodeProcessors = Some value }

        [<CustomOperation("totalMlProcessors")>]
        member _.TotalMlProcessors(state: Limits, value: CoreTypes.Integer) =
            { state with TotalMlProcessors = Some value }

        [<CustomOperation("maxModelMemoryLimit")>]
        member _.MaxModelMemoryLimit(state: Limits, value: CoreTypes.ByteSize) =
            { state with MaxModelMemoryLimit = Some value }

        [<CustomOperation("effectiveMaxModelMemoryLimit")>]
        member _.EffectiveMaxModelMemoryLimit(state: Limits, value: CoreTypes.ByteSize) =
            { state with EffectiveMaxModelMemoryLimit = Some value }

        [<CustomOperation("totalMlMemory")>]
        member _.TotalMlMemory(state: Limits, value: CoreTypes.ByteSize) =
            { state with TotalMlMemory = value }

    let limits = LimitsBuilder()


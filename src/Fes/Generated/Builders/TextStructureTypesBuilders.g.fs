// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module TextStructureTypesBuilders =

    type FieldStatBuilder() =
        member _.Yield(_: unit) : FieldStat =
            {
                Count = Unchecked.defaultof<_>
                Cardinality = Unchecked.defaultof<_>
                TopHits = Unchecked.defaultof<_>
                MeanValue = None
                MedianValue = None
                MaxValue = None
                MinValue = None
                Earliest = None
                Latest = None
            }

        [<CustomOperation("count")>]
        member _.Count(state: FieldStat, value: CoreTypes.Integer) =
            { state with Count = value }

        [<CustomOperation("cardinality")>]
        member _.Cardinality(state: FieldStat, value: CoreTypes.Integer) =
            { state with Cardinality = value }

        [<CustomOperation("topHits")>]
        member _.TopHits(state: FieldStat, value: TextStructureTypes.TopHit list) =
            { state with TopHits = value }

        [<CustomOperation("meanValue")>]
        member _.MeanValue(state: FieldStat, value: CoreTypes.Integer) =
            { state with MeanValue = Some value }

        [<CustomOperation("medianValue")>]
        member _.MedianValue(state: FieldStat, value: CoreTypes.Integer) =
            { state with MedianValue = Some value }

        [<CustomOperation("maxValue")>]
        member _.MaxValue(state: FieldStat, value: CoreTypes.Integer) =
            { state with MaxValue = Some value }

        [<CustomOperation("minValue")>]
        member _.MinValue(state: FieldStat, value: CoreTypes.Integer) =
            { state with MinValue = Some value }

        [<CustomOperation("earliest")>]
        member _.Earliest(state: FieldStat, value: string) =
            { state with Earliest = Some value }

        [<CustomOperation("latest")>]
        member _.Latest(state: FieldStat, value: string) =
            { state with Latest = Some value }

    let fieldStat = FieldStatBuilder()


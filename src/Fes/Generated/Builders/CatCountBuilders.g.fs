// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module CatCountBuilders =

    type CountRecordBuilder() =
        member _.Yield(_: unit) : Types.CountRecord =
            {
                Epoch = None
                Timestamp = None
                Count = None
            }

        [<CustomOperation("epoch")>]
        member _.Epoch(state: Types.CountRecord, value: Types.Stringified<Types.EpochTime<Types.UnitSeconds>>) =
            { state with Epoch = Some value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: Types.CountRecord, value: Types.TimeOfDay) =
            { state with Timestamp = Some value }

        [<CustomOperation("count")>]
        member _.Count(state: Types.CountRecord, value: string) =
            { state with Count = Some value }

    let countRecord = CountRecordBuilder()


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module RollupGetRollupCapsBuilders =

    type RollupFieldSummaryBuilder() =
        member _.Yield(_: unit) : Types.RollupFieldSummary =
            {
                Agg = Unchecked.defaultof<_>
                CalendarInterval = None
                TimeZone = None
            }

        [<CustomOperation("agg")>]
        member _.Agg(state: Types.RollupFieldSummary, value: string) =
            { state with Agg = value }

        [<CustomOperation("calendarInterval")>]
        member _.CalendarInterval(state: Types.RollupFieldSummary, value: Types.Duration) =
            { state with CalendarInterval = Some value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: Types.RollupFieldSummary, value: Types.TimeZone) =
            { state with TimeZone = Some value }

    let rollupFieldSummary = RollupFieldSummaryBuilder()


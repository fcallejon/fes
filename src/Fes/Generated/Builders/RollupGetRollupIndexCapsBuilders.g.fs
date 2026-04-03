// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module RollupGetRollupIndexCapsBuilders =

    type RollupJobSummaryFieldBuilder() =
        member _.Yield(_: unit) : Types.RollupJobSummaryField =
            {
                Agg = Unchecked.defaultof<_>
                TimeZone = None
                CalendarInterval = None
            }

        [<CustomOperation("agg")>]
        member _.Agg(state: Types.RollupJobSummaryField, value: string) =
            { state with Agg = value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: Types.RollupJobSummaryField, value: Types.TimeZone) =
            { state with TimeZone = Some value }

        [<CustomOperation("calendarInterval")>]
        member _.CalendarInterval(state: Types.RollupJobSummaryField, value: Types.Duration) =
            { state with CalendarInterval = Some value }

    let rollupJobSummaryField = RollupJobSummaryFieldBuilder()


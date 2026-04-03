// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module RollupTypesBuilders =

    type DateHistogramGroupingBuilder() =
        member _.Yield(_: unit) : Types.DateHistogramGrouping =
            {
                Delay = None
                Field = Unchecked.defaultof<_>
                Format = None
                Interval = None
                CalendarInterval = None
                FixedInterval = None
                TimeZone = None
            }

        [<CustomOperation("delay")>]
        member _.Delay(state: Types.DateHistogramGrouping, value: Types.Duration) =
            { state with Delay = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.DateHistogramGrouping, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("format")>]
        member _.Format(state: Types.DateHistogramGrouping, value: string) =
            { state with Format = Some value }

        [<CustomOperation("interval")>]
        member _.Interval(state: Types.DateHistogramGrouping, value: Types.Duration) =
            { state with Interval = Some value }

        [<CustomOperation("calendarInterval")>]
        member _.CalendarInterval(state: Types.DateHistogramGrouping, value: Types.Duration) =
            { state with CalendarInterval = Some value }

        [<CustomOperation("fixedInterval")>]
        member _.FixedInterval(state: Types.DateHistogramGrouping, value: Types.Duration) =
            { state with FixedInterval = Some value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: Types.DateHistogramGrouping, value: Types.TimeZone) =
            { state with TimeZone = Some value }

    let dateHistogramGrouping = DateHistogramGroupingBuilder()

    type GroupingsBuilder() =
        member _.Yield(_: unit) : Types.Groupings =
            {
                DateHistogram = None
                Histogram = None
                Terms = None
            }

        [<CustomOperation("dateHistogram")>]
        member _.DateHistogram(state: Types.Groupings, value: Types.DateHistogramGrouping) =
            { state with DateHistogram = Some value }

        [<CustomOperation("histogram")>]
        member _.Histogram(state: Types.Groupings, value: Types.HistogramGrouping) =
            { state with Histogram = Some value }

        [<CustomOperation("terms")>]
        member _.Terms(state: Types.Groupings, value: Types.TermsGrouping) =
            { state with Terms = Some value }

    let groupings = GroupingsBuilder()


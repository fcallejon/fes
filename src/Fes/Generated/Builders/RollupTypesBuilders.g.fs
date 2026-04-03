// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module RollupTypesBuilders =

    type DateHistogramGroupingBuilder() =
        member _.Yield(_: unit) : DateHistogramGrouping =
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
        member _.Delay(state: DateHistogramGrouping, value: Types.Duration) =
            { state with Delay = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: DateHistogramGrouping, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("format")>]
        member _.Format(state: DateHistogramGrouping, value: string) =
            { state with Format = Some value }

        [<CustomOperation("interval")>]
        member _.Interval(state: DateHistogramGrouping, value: Types.Duration) =
            { state with Interval = Some value }

        [<CustomOperation("calendarInterval")>]
        member _.CalendarInterval(state: DateHistogramGrouping, value: Types.Duration) =
            { state with CalendarInterval = Some value }

        [<CustomOperation("fixedInterval")>]
        member _.FixedInterval(state: DateHistogramGrouping, value: Types.Duration) =
            { state with FixedInterval = Some value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: DateHistogramGrouping, value: Types.TimeZone) =
            { state with TimeZone = Some value }

    let dateHistogramGrouping = DateHistogramGroupingBuilder()

    type GroupingsBuilder() =
        member _.Yield(_: unit) : Groupings =
            {
                DateHistogram = None
                Histogram = None
                Terms = None
            }

        [<CustomOperation("dateHistogram")>]
        member _.DateHistogram(state: Groupings, value: RollupTypes.DateHistogramGrouping) =
            { state with DateHistogram = Some value }

        [<CustomOperation("histogram")>]
        member _.Histogram(state: Groupings, value: RollupTypes.HistogramGrouping) =
            { state with Histogram = Some value }

        [<CustomOperation("terms")>]
        member _.Terms(state: Groupings, value: RollupTypes.TermsGrouping) =
            { state with Terms = Some value }

    let groupings = GroupingsBuilder()


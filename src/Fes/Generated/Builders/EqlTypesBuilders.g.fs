// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module EqlTypesBuilders =

    type EqlHitsBuilder() =
        member _.Yield(_: unit) : EqlHits =
            {
                Total = None
                Events = None
                Sequences = None
            }

        [<CustomOperation("total")>]
        member _.Total(state: EqlHits, value: GlobalSearchTypes.TotalHits) =
            { state with Total = Some value }

        [<CustomOperation("events")>]
        member _.Events(state: EqlHits, value: EqlTypes.HitsEvent<'tEvent> list) =
            { state with Events = Some value }

        [<CustomOperation("sequences")>]
        member _.Sequences(state: EqlHits, value: EqlTypes.HitsSequence<'tEvent> list) =
            { state with Sequences = Some value }

    let eqlHits = EqlHitsBuilder()

    type EqlSearchResponseBaseBuilder() =
        member _.Yield(_: unit) : EqlSearchResponseBase =
            {
                Id = None
                IsPartial = None
                IsRunning = None
                Took = None
                TimedOut = None
                Hits = Unchecked.defaultof<_>
                ShardFailures = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: EqlSearchResponseBase, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("isPartial")>]
        member _.IsPartial(state: EqlSearchResponseBase, value: bool) =
            { state with IsPartial = Some value }

        [<CustomOperation("isRunning")>]
        member _.IsRunning(state: EqlSearchResponseBase, value: bool) =
            { state with IsRunning = Some value }

        [<CustomOperation("took")>]
        member _.Took(state: EqlSearchResponseBase, value: Types.DurationValue<Types.UnitMillis>) =
            { state with Took = Some value }

        [<CustomOperation("timedOut")>]
        member _.TimedOut(state: EqlSearchResponseBase, value: bool) =
            { state with TimedOut = Some value }

        [<CustomOperation("hits")>]
        member _.Hits(state: EqlSearchResponseBase, value: EqlTypes.EqlHits<'tEvent>) =
            { state with Hits = value }

        [<CustomOperation("shardFailures")>]
        member _.ShardFailures(state: EqlSearchResponseBase, value: Types.ShardFailure list) =
            { state with ShardFailures = Some value }

    let eqlSearchResponseBase = EqlSearchResponseBaseBuilder()

    type HitsEventBuilder() =
        member _.Yield(_: unit) : HitsEvent =
            {
                Index = Unchecked.defaultof<_>
                Id = Unchecked.defaultof<_>
                Source = Unchecked.defaultof<_>
                Missing = None
                Fields = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: HitsEvent, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("id")>]
        member _.Id(state: HitsEvent, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("source")>]
        member _.Source(state: HitsEvent, value: 'tEvent) =
            { state with Source = value }

        [<CustomOperation("missing")>]
        member _.Missing(state: HitsEvent, value: bool) =
            { state with Missing = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: HitsEvent, value: Map<Types.Field, System.Text.Json.JsonElement list>) =
            { state with Fields = Some value }

    let hitsEvent = HitsEventBuilder()


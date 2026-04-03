// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module AsyncSearchTypesBuilders =

    type AsyncSearchBuilder() =
        member _.Yield(_: unit) : AsyncSearch =
            {
                Aggregations = None
                Clusters = None
                Fields = None
                Hits = Unchecked.defaultof<_>
                MaxScore = None
                NumReducePhases = None
                Profile = None
                PitId = None
                ScrollId = None
                Shards = Unchecked.defaultof<_>
                Suggest = None
                TerminatedEarly = None
                TimedOut = Unchecked.defaultof<_>
                Took = Unchecked.defaultof<_>
            }

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: AsyncSearch, value: Map<CoreTypes.AggregateName, CoreTypes.Aggregate>) =
            { state with Aggregations = Some value }

        [<CustomOperation("clusters")>]
        member _.Clusters(state: AsyncSearch, value: CoreTypes.ClusterStatistics) =
            { state with Clusters = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: AsyncSearch, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Fields = Some value }

        [<CustomOperation("hits")>]
        member _.Hits(state: AsyncSearch, value: GlobalSearchTypes.HitsMetadata<'tDocument>) =
            { state with Hits = value }

        [<CustomOperation("maxScore")>]
        member _.MaxScore(state: AsyncSearch, value: CoreTypes.Double) =
            { state with MaxScore = Some value }

        [<CustomOperation("numReducePhases")>]
        member _.NumReducePhases(state: AsyncSearch, value: CoreTypes.Long) =
            { state with NumReducePhases = Some value }

        [<CustomOperation("profile")>]
        member _.Profile(state: AsyncSearch, value: GlobalSearchTypes.Profile) =
            { state with Profile = Some value }

        [<CustomOperation("pitId")>]
        member _.PitId(state: AsyncSearch, value: CoreTypes.Id) =
            { state with PitId = Some value }

        [<CustomOperation("scrollId")>]
        member _.ScrollId(state: AsyncSearch, value: CoreTypes.ScrollId) =
            { state with ScrollId = Some value }

        [<CustomOperation("shards")>]
        member _.Shards(state: AsyncSearch, value: CoreTypes.ShardStatistics) =
            { state with Shards = value }

        [<CustomOperation("suggest")>]
        member _.Suggest(state: AsyncSearch, value: Map<CoreTypes.SuggestionName, GlobalSearchTypes.Suggest<'tDocument> list>) =
            { state with Suggest = Some value }

        [<CustomOperation("terminatedEarly")>]
        member _.TerminatedEarly(state: AsyncSearch, value: bool) =
            { state with TerminatedEarly = Some value }

        [<CustomOperation("timedOut")>]
        member _.TimedOut(state: AsyncSearch, value: bool) =
            { state with TimedOut = value }

        [<CustomOperation("took")>]
        member _.Took(state: AsyncSearch, value: CoreTypes.Long) =
            { state with Took = value }

    let asyncSearch = AsyncSearchBuilder()

    type AsyncSearchResponseBaseBuilder() =
        member _.Yield(_: unit) : AsyncSearchResponseBase =
            {
                Id = None
                IsPartial = Unchecked.defaultof<_>
                IsRunning = Unchecked.defaultof<_>
                ExpirationTime = None
                ExpirationTimeInMillis = Unchecked.defaultof<_>
                StartTime = None
                StartTimeInMillis = Unchecked.defaultof<_>
                CompletionTime = None
                CompletionTimeInMillis = None
                Error = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: AsyncSearchResponseBase, value: CoreTypes.Id) =
            { state with Id = Some value }

        [<CustomOperation("isPartial")>]
        member _.IsPartial(state: AsyncSearchResponseBase, value: bool) =
            { state with IsPartial = value }

        [<CustomOperation("isRunning")>]
        member _.IsRunning(state: AsyncSearchResponseBase, value: bool) =
            { state with IsRunning = value }

        [<CustomOperation("expirationTime")>]
        member _.ExpirationTime(state: AsyncSearchResponseBase, value: CoreTypes.DateTime) =
            { state with ExpirationTime = Some value }

        [<CustomOperation("expirationTimeInMillis")>]
        member _.ExpirationTimeInMillis(state: AsyncSearchResponseBase, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with ExpirationTimeInMillis = value }

        [<CustomOperation("startTime")>]
        member _.StartTime(state: AsyncSearchResponseBase, value: CoreTypes.DateTime) =
            { state with StartTime = Some value }

        [<CustomOperation("startTimeInMillis")>]
        member _.StartTimeInMillis(state: AsyncSearchResponseBase, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with StartTimeInMillis = value }

        [<CustomOperation("completionTime")>]
        member _.CompletionTime(state: AsyncSearchResponseBase, value: CoreTypes.DateTime) =
            { state with CompletionTime = Some value }

        [<CustomOperation("completionTimeInMillis")>]
        member _.CompletionTimeInMillis(state: AsyncSearchResponseBase, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with CompletionTimeInMillis = Some value }

        [<CustomOperation("error")>]
        member _.Error(state: AsyncSearchResponseBase, value: CoreTypes.ErrorCause) =
            { state with Error = Some value }

    let asyncSearchResponseBase = AsyncSearchResponseBaseBuilder()

    type AsyncSearchResponseExceptionBuilder() =
        member _.Yield(_: unit) : AsyncSearchResponseException =
            {
                IsPartial = Unchecked.defaultof<_>
                IsRunning = Unchecked.defaultof<_>
                ExpirationTime = None
                ExpirationTimeInMillis = Unchecked.defaultof<_>
                StartTime = None
                StartTimeInMillis = Unchecked.defaultof<_>
                CompletionTime = None
                CompletionTimeInMillis = None
                Error = None
                Response = None
            }

        [<CustomOperation("isPartial")>]
        member _.IsPartial(state: AsyncSearchResponseException, value: bool) =
            { state with IsPartial = value }

        [<CustomOperation("isRunning")>]
        member _.IsRunning(state: AsyncSearchResponseException, value: bool) =
            { state with IsRunning = value }

        [<CustomOperation("expirationTime")>]
        member _.ExpirationTime(state: AsyncSearchResponseException, value: CoreTypes.DateTime) =
            { state with ExpirationTime = Some value }

        [<CustomOperation("expirationTimeInMillis")>]
        member _.ExpirationTimeInMillis(state: AsyncSearchResponseException, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with ExpirationTimeInMillis = value }

        [<CustomOperation("startTime")>]
        member _.StartTime(state: AsyncSearchResponseException, value: CoreTypes.DateTime) =
            { state with StartTime = Some value }

        [<CustomOperation("startTimeInMillis")>]
        member _.StartTimeInMillis(state: AsyncSearchResponseException, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with StartTimeInMillis = value }

        [<CustomOperation("completionTime")>]
        member _.CompletionTime(state: AsyncSearchResponseException, value: CoreTypes.DateTime) =
            { state with CompletionTime = Some value }

        [<CustomOperation("completionTimeInMillis")>]
        member _.CompletionTimeInMillis(state: AsyncSearchResponseException, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with CompletionTimeInMillis = Some value }

        [<CustomOperation("error")>]
        member _.Error(state: AsyncSearchResponseException, value: CoreTypes.ErrorCause) =
            { state with Error = Some value }

        [<CustomOperation("response")>]
        member _.Response(state: AsyncSearchResponseException, value: AsyncSearchTypes.AsyncSearch<'tDocument>) =
            { state with Response = Some value }

    let asyncSearchResponseException = AsyncSearchResponseExceptionBuilder()


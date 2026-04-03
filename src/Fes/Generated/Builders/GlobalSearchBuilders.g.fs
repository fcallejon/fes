// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module GlobalSearchBuilders =

    type ResponseBodyBuilder() =
        member _.Yield(_: unit) : ResponseBody =
            {
                Took = Unchecked.defaultof<_>
                TimedOut = Unchecked.defaultof<_>
                Shards = Unchecked.defaultof<_>
                Hits = Unchecked.defaultof<_>
                Aggregations = None
                Clusters = None
                Fields = None
                MaxScore = None
                NumReducePhases = None
                Profile = None
                PitId = None
                ScrollId = None
                Suggest = None
                TerminatedEarly = None
            }

        [<CustomOperation("took")>]
        member _.Took(state: ResponseBody, value: Types.Long) =
            { state with Took = value }

        [<CustomOperation("timedOut")>]
        member _.TimedOut(state: ResponseBody, value: bool) =
            { state with TimedOut = value }

        [<CustomOperation("shards")>]
        member _.Shards(state: ResponseBody, value: Types.ShardStatistics) =
            { state with Shards = value }

        [<CustomOperation("hits")>]
        member _.Hits(state: ResponseBody, value: GlobalSearchTypes.HitsMetadata<'tDocument>) =
            { state with Hits = value }

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: ResponseBody, value: Map<Types.AggregateName, TypesAggregations.Aggregate>) =
            { state with Aggregations = Some value }

        [<CustomOperation("clusters")>]
        member _.Clusters(state: ResponseBody, value: Types.ClusterStatistics) =
            { state with Clusters = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: ResponseBody, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Fields = Some value }

        [<CustomOperation("maxScore")>]
        member _.MaxScore(state: ResponseBody, value: Types.Double) =
            { state with MaxScore = Some value }

        [<CustomOperation("numReducePhases")>]
        member _.NumReducePhases(state: ResponseBody, value: Types.Long) =
            { state with NumReducePhases = Some value }

        [<CustomOperation("profile")>]
        member _.Profile(state: ResponseBody, value: GlobalSearchTypes.Profile) =
            { state with Profile = Some value }

        [<CustomOperation("pitId")>]
        member _.PitId(state: ResponseBody, value: Types.Id) =
            { state with PitId = Some value }

        [<CustomOperation("scrollId")>]
        member _.ScrollId(state: ResponseBody, value: Types.ScrollId) =
            { state with ScrollId = Some value }

        [<CustomOperation("suggest")>]
        member _.Suggest(state: ResponseBody, value: Map<Types.SuggestionName, GlobalSearchTypes.Suggest<'tDocument> list>) =
            { state with Suggest = Some value }

        [<CustomOperation("terminatedEarly")>]
        member _.TerminatedEarly(state: ResponseBody, value: bool) =
            { state with TerminatedEarly = Some value }

    let responseBody = ResponseBodyBuilder()


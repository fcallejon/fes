// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module IndicesForcemergeTypesBuilders =

    type ForceMergeResponseBodyBuilder() =
        member _.Yield(_: unit) : Types.ForceMergeResponseBody =
            {
                Task = None
                Shards = None
            }

        [<CustomOperation("task")>]
        member _.Task(state: Types.ForceMergeResponseBody, value: string) =
            { state with Task = Some value }

        [<CustomOperation("shards")>]
        member _.Shards(state: Types.ForceMergeResponseBody, value: Types.ShardStatistics) =
            { state with Shards = Some value }

    let forceMergeResponseBody = ForceMergeResponseBodyBuilder()


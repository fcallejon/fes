// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module GlobalSearchShardsBuilders =

    type ShardStoreIndexBuilder() =
        member _.Yield(_: unit) : Types.ShardStoreIndex =
            {
                Aliases = None
                Filter = None
            }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: Types.ShardStoreIndex, value: Types.Name list) =
            { state with Aliases = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: Types.ShardStoreIndex, value: Types.QueryContainer) =
            { state with Filter = Some value }

    let shardStoreIndex = ShardStoreIndexBuilder()


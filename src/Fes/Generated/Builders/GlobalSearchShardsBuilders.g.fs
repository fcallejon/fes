// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module GlobalSearchShardsBuilders =

    type ShardStoreIndexBuilder() =
        member _.Yield(_: unit) : ShardStoreIndex =
            {
                Aliases = None
                Filter = None
            }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: ShardStoreIndex, value: Types.Name list) =
            { state with Aliases = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: ShardStoreIndex, value: TypesQueryDsl.QueryContainer) =
            { state with Filter = Some value }

    let shardStoreIndex = ShardStoreIndexBuilder()


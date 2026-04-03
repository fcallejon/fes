// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module IndicesShardStoresBuilders =

    type ShardStoreBuilder() =
        member _.Yield(_: unit) : ShardStore =
            {
                Allocation = Unchecked.defaultof<_>
                AllocationId = None
                StoreException = None
            }

        [<CustomOperation("allocation")>]
        member _.Allocation(state: ShardStore, value: IndicesShardStores.ShardStoreAllocation) =
            { state with Allocation = value }

        [<CustomOperation("allocationId")>]
        member _.AllocationId(state: ShardStore, value: Types.Id) =
            { state with AllocationId = Some value }

        [<CustomOperation("storeException")>]
        member _.StoreException(state: ShardStore, value: IndicesShardStores.ShardStoreException) =
            { state with StoreException = Some value }

    let shardStore = ShardStoreBuilder()

    type ShardStoreNodeBuilder() =
        member _.Yield(_: unit) : ShardStoreNode =
            {
                Attributes = Unchecked.defaultof<_>
                EphemeralId = None
                ExternalId = None
                Name = Unchecked.defaultof<_>
                Roles = Unchecked.defaultof<_>
                TransportAddress = Unchecked.defaultof<_>
            }

        [<CustomOperation("attributes")>]
        member _.Attributes(state: ShardStoreNode, value: Map<string, string>) =
            { state with Attributes = value }

        [<CustomOperation("ephemeralId")>]
        member _.EphemeralId(state: ShardStoreNode, value: string) =
            { state with EphemeralId = Some value }

        [<CustomOperation("externalId")>]
        member _.ExternalId(state: ShardStoreNode, value: string) =
            { state with ExternalId = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: ShardStoreNode, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("roles")>]
        member _.Roles(state: ShardStoreNode, value: string list) =
            { state with Roles = value }

        [<CustomOperation("transportAddress")>]
        member _.TransportAddress(state: ShardStoreNode, value: Types.TransportAddress) =
            { state with TransportAddress = value }

    let shardStoreNode = ShardStoreNodeBuilder()


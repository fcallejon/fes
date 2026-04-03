// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module IndicesShardStoresBuilders =

    type ShardStoreBuilder() =
        member _.Yield(_: unit) : Types.ShardStore =
            {
                Allocation = Unchecked.defaultof<_>
                AllocationId = None
                StoreException = None
            }

        [<CustomOperation("allocation")>]
        member _.Allocation(state: Types.ShardStore, value: Types.ShardStoreAllocation) =
            { state with Allocation = value }

        [<CustomOperation("allocationId")>]
        member _.AllocationId(state: Types.ShardStore, value: Types.Id) =
            { state with AllocationId = Some value }

        [<CustomOperation("storeException")>]
        member _.StoreException(state: Types.ShardStore, value: Types.ShardStoreException) =
            { state with StoreException = Some value }

    let shardStore = ShardStoreBuilder()

    type ShardStoreNodeBuilder() =
        member _.Yield(_: unit) : Types.ShardStoreNode =
            {
                Attributes = Unchecked.defaultof<_>
                EphemeralId = None
                ExternalId = None
                Name = Unchecked.defaultof<_>
                Roles = Unchecked.defaultof<_>
                TransportAddress = Unchecked.defaultof<_>
            }

        [<CustomOperation("attributes")>]
        member _.Attributes(state: Types.ShardStoreNode, value: Map<string, string>) =
            { state with Attributes = value }

        [<CustomOperation("ephemeralId")>]
        member _.EphemeralId(state: Types.ShardStoreNode, value: string) =
            { state with EphemeralId = Some value }

        [<CustomOperation("externalId")>]
        member _.ExternalId(state: Types.ShardStoreNode, value: string) =
            { state with ExternalId = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Types.ShardStoreNode, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("roles")>]
        member _.Roles(state: Types.ShardStoreNode, value: string list) =
            { state with Roles = value }

        [<CustomOperation("transportAddress")>]
        member _.TransportAddress(state: Types.ShardStoreNode, value: Types.TransportAddress) =
            { state with TransportAddress = value }

    let shardStoreNode = ShardStoreNodeBuilder()


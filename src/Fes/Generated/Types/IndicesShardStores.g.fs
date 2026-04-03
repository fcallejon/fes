// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesShardStores =

    [<RequireQualifiedAccess>]
    type ShardStoreAllocation =
        | Primary
        | Replica
        | Unused

    type ShardStoreException = {
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type ShardStore = {
        [<System.Text.Json.Serialization.JsonPropertyName("allocation")>]
        Allocation: ShardStoreAllocation
        [<System.Text.Json.Serialization.JsonPropertyName("allocation_id")>]
        AllocationId: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("store_exception")>]
        StoreException: ShardStoreException option
    }

    type ShardStoreWrapper = {
        [<System.Text.Json.Serialization.JsonPropertyName("stores")>]
        Stores: ShardStore list
    }

    type IndicesShardStores = {
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: Map<string, ShardStoreWrapper>
    }

    type ShardStoreNode = {
        [<System.Text.Json.Serialization.JsonPropertyName("attributes")>]
        Attributes: Map<string, string>
        [<System.Text.Json.Serialization.JsonPropertyName("ephemeral_id")>]
        EphemeralId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("external_id")>]
        ExternalId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: string list
        [<System.Text.Json.Serialization.JsonPropertyName("transport_address")>]
        TransportAddress: CoreTypes.TransportAddress
    }

    [<RequireQualifiedAccess>]
    type ShardStoreStatus =
        | Green
        | Yellow
        | Red
        | All


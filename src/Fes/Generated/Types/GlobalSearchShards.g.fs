// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalSearchShards =

    type SearchShardsNodeAttributes = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.NodeName
        [<System.Text.Json.Serialization.JsonPropertyName("ephemeral_id")>]
        EphemeralId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("transport_address")>]
        TransportAddress: CoreTypes.TransportAddress
        [<System.Text.Json.Serialization.JsonPropertyName("external_id")>]
        ExternalId: string
        [<System.Text.Json.Serialization.JsonPropertyName("attributes")>]
        Attributes: Map<string, string>
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: CoreTypes.NodeRoles
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("min_index_version")>]
        MinIndexVersion: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("max_index_version")>]
        MaxIndexVersion: CoreTypes.Integer
    }

    type ShardStoreIndex = {
        [<System.Text.Json.Serialization.JsonPropertyName("aliases")>]
        Aliases: CoreTypes.Name list option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: CoreTypes.QueryContainer option
    }


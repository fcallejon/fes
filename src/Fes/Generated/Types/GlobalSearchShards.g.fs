// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalSearchShards =

    type SearchShardsNodeAttributes = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.NodeName
        [<System.Text.Json.Serialization.JsonPropertyName("ephemeral_id")>]
        EphemeralId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("transport_address")>]
        TransportAddress: Types.TransportAddress
        [<System.Text.Json.Serialization.JsonPropertyName("external_id")>]
        ExternalId: string
        [<System.Text.Json.Serialization.JsonPropertyName("attributes")>]
        Attributes: Map<string, string>
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: Types.NodeRoles
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("min_index_version")>]
        MinIndexVersion: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("max_index_version")>]
        MaxIndexVersion: Types.Integer
    }

    type ShardStoreIndex = {
        [<System.Text.Json.Serialization.JsonPropertyName("aliases")>]
        Aliases: Types.Name list option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: TypesQueryDsl.QueryContainer option
    }


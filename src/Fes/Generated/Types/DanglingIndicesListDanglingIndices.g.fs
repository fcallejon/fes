// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module DanglingIndicesListDanglingIndices =

    type DanglingIndex = {
        [<System.Text.Json.Serialization.JsonPropertyName("index_name")>]
        IndexName: string
        [<System.Text.Json.Serialization.JsonPropertyName("index_uuid")>]
        IndexUuid: string
        [<System.Text.Json.Serialization.JsonPropertyName("creation_date_millis")>]
        CreationDateMillis: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("node_ids")>]
        NodeIds: Types.Ids
    }


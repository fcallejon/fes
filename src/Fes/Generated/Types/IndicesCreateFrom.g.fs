// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesCreateFrom =

    type CreateFrom = {
        [<System.Text.Json.Serialization.JsonPropertyName("mappings_override")>]
        MappingsOverride: CoreTypes.TypeMapping option
        [<System.Text.Json.Serialization.JsonPropertyName("settings_override")>]
        SettingsOverride: IndicesTypes.IndexSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("remove_index_blocks")>]
        RemoveIndexBlocks: bool option
    }


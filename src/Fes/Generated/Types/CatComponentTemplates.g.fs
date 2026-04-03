// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatComponentTemplates =

    type ComponentTemplate = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: string option
        [<System.Text.Json.Serialization.JsonPropertyName("alias_count")>]
        AliasCount: string
        [<System.Text.Json.Serialization.JsonPropertyName("mapping_count")>]
        MappingCount: string
        [<System.Text.Json.Serialization.JsonPropertyName("settings_count")>]
        SettingsCount: string
        [<System.Text.Json.Serialization.JsonPropertyName("metadata_count")>]
        MetadataCount: string
        [<System.Text.Json.Serialization.JsonPropertyName("included_in")>]
        IncludedIn: string
    }


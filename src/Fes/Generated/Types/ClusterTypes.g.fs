// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module ClusterTypes =

    type ComponentTemplateSummaryRes = {
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle")>]
        Lifecycle: IndicesTypes.DataStreamLifecycleWithRollover option
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: Map<Types.IndexName, IndicesTypes.IndexSettings> option
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: TypesMapping.TypeMapping option
        [<System.Text.Json.Serialization.JsonPropertyName("aliases")>]
        Aliases: Map<string, IndicesTypes.AliasDefinition> option
        [<System.Text.Json.Serialization.JsonPropertyName("data_stream_options")>]
        DataStreamOptions: IndicesTypes.DataStreamOptions option
    }

    type ComponentTemplateNodeWithRollover = {
        [<System.Text.Json.Serialization.JsonPropertyName("template")>]
        Template: ClusterTypes.ComponentTemplateSummaryRes
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("deprecated")>]
        Deprecated: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("created_date")>]
        CreatedDate: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("created_date_millis")>]
        CreatedDateMillis: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date")>]
        ModifiedDate: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date_millis")>]
        ModifiedDateMillis: Types.EpochTime<Types.UnitMillis> option
    }

    type ComponentTemplate = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("component_template")>]
        ComponentTemplate: ClusterTypes.ComponentTemplateNodeWithRollover
    }

    type ComponentTemplateSummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: Map<Types.IndexName, IndicesTypes.IndexSettings> option
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: TypesMapping.TypeMapping option
        [<System.Text.Json.Serialization.JsonPropertyName("aliases")>]
        Aliases: Map<string, IndicesTypes.AliasDefinition> option
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle")>]
        Lifecycle: IndicesTypes.DataStreamLifecycle option
        [<System.Text.Json.Serialization.JsonPropertyName("data_stream_options")>]
        DataStreamOptions: IndicesTypes.DataStreamOptions option
    }

    type ComponentTemplateNode = {
        [<System.Text.Json.Serialization.JsonPropertyName("template")>]
        Template: ClusterTypes.ComponentTemplateSummary
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("deprecated")>]
        Deprecated: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("created_date")>]
        CreatedDate: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("created_date_millis")>]
        CreatedDateMillis: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date")>]
        ModifiedDate: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date_millis")>]
        ModifiedDateMillis: Types.EpochTime<Types.UnitMillis> option
    }


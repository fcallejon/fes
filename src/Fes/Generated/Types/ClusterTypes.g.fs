// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module ClusterTypes =

    type ComponentTemplateSummaryRes = {
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle")>]
        Lifecycle: IndicesTypes.DataStreamLifecycleWithRollover option
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: CoreTypes.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: Map<CoreTypes.IndexName, IndicesTypes.IndexSettings> option
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: CoreTypes.TypeMapping option
        [<System.Text.Json.Serialization.JsonPropertyName("aliases")>]
        Aliases: Map<string, IndicesTypes.AliasDefinition> option
        [<System.Text.Json.Serialization.JsonPropertyName("data_stream_options")>]
        DataStreamOptions: IndicesTypes.DataStreamOptions option
    }

    type ComponentTemplateNodeWithRollover = {
        [<System.Text.Json.Serialization.JsonPropertyName("template")>]
        Template: ComponentTemplateSummaryRes
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: CoreTypes.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("deprecated")>]
        Deprecated: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("created_date")>]
        CreatedDate: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("created_date_millis")>]
        CreatedDateMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date")>]
        ModifiedDate: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date_millis")>]
        ModifiedDateMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
    }

    type ComponentTemplate = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("component_template")>]
        ComponentTemplate: ComponentTemplateNodeWithRollover
    }

    type ComponentTemplateSummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: CoreTypes.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: Map<CoreTypes.IndexName, IndicesTypes.IndexSettings> option
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: CoreTypes.TypeMapping option
        [<System.Text.Json.Serialization.JsonPropertyName("aliases")>]
        Aliases: Map<string, IndicesTypes.AliasDefinition> option
        [<System.Text.Json.Serialization.JsonPropertyName("lifecycle")>]
        Lifecycle: IndicesTypes.DataStreamLifecycle option
        [<System.Text.Json.Serialization.JsonPropertyName("data_stream_options")>]
        DataStreamOptions: IndicesTypes.DataStreamOptions option
    }

    type ComponentTemplateNode = {
        [<System.Text.Json.Serialization.JsonPropertyName("template")>]
        Template: ComponentTemplateSummary
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: CoreTypes.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("deprecated")>]
        Deprecated: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("created_date")>]
        CreatedDate: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("created_date_millis")>]
        CreatedDateMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date")>]
        ModifiedDate: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date_millis")>]
        ModifiedDateMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
    }


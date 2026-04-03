// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesPutDataStreamSettings =

    type DataStreamSettingsError = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: string
    }

    type IndexSettingResults = {
        [<System.Text.Json.Serialization.JsonPropertyName("applied_to_data_stream_only")>]
        AppliedToDataStreamOnly: string list
        [<System.Text.Json.Serialization.JsonPropertyName("applied_to_data_stream_and_backing_indices")>]
        AppliedToDataStreamAndBackingIndices: string list
        [<System.Text.Json.Serialization.JsonPropertyName("errors")>]
        Errors: DataStreamSettingsError list option
    }

    type UpdatedDataStreamSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("applied_to_data_stream")>]
        AppliedToDataStream: bool
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: string option
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: IndicesTypes.IndexSettings
        [<System.Text.Json.Serialization.JsonPropertyName("effective_settings")>]
        EffectiveSettings: IndicesTypes.IndexSettings
        [<System.Text.Json.Serialization.JsonPropertyName("index_settings_results")>]
        IndexSettingsResults: IndexSettingResults
    }


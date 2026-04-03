// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SearchApplicationTypes =

    type EventDataStream = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.IndexName
    }

    type AnalyticsCollection = {
        [<System.Text.Json.Serialization.JsonPropertyName("event_data_stream")>]
        EventDataStream: SearchApplicationTypes.EventDataStream
    }

    [<RequireQualifiedAccess>]
    type EventType =
        | PageView
        | Search
        | SearchClick

    type SearchApplicationTemplate = {
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script
    }

    type SearchApplicationParameters = {
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: Types.IndexName list
        [<System.Text.Json.Serialization.JsonPropertyName("analytics_collection_name")>]
        AnalyticsCollectionName: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("template")>]
        Template: SearchApplicationTypes.SearchApplicationTemplate option
    }

    type SearchApplication = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("updated_at_millis")>]
        UpdatedAtMillis: Types.EpochTime<Types.UnitMillis>
    }


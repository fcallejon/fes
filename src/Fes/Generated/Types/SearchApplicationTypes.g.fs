// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SearchApplicationTypes =

    type EventDataStream = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.IndexName
    }

    type AnalyticsCollection = {
        [<System.Text.Json.Serialization.JsonPropertyName("event_data_stream")>]
        EventDataStream: EventDataStream
    }

    [<RequireQualifiedAccess>]
    type EventType =
        | PageView
        | Search
        | SearchClick

    type SearchApplicationTemplate = {
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: CoreTypes.Script
    }

    type SearchApplicationParameters = {
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: CoreTypes.IndexName list
        [<System.Text.Json.Serialization.JsonPropertyName("analytics_collection_name")>]
        AnalyticsCollectionName: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("template")>]
        Template: SearchApplicationTemplate option
    }

    type SearchApplication = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("updated_at_millis")>]
        UpdatedAtMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis>
    }


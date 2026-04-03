// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatMlDataFrameAnalytics =

    type DataFrameAnalyticsRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string option
        [<System.Text.Json.Serialization.JsonPropertyName("create_time")>]
        CreateTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("source_index")>]
        SourceIndex: CoreTypes.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("dest_index")>]
        DestIndex: CoreTypes.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model_memory_limit")>]
        ModelMemoryLimit: string option
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: string option
        [<System.Text.Json.Serialization.JsonPropertyName("failure_reason")>]
        FailureReason: string option
        [<System.Text.Json.Serialization.JsonPropertyName("progress")>]
        Progress: string option
        [<System.Text.Json.Serialization.JsonPropertyName("assignment_explanation")>]
        AssignmentExplanation: string option
        [<System.Text.Json.Serialization.JsonPropertyName("node.id")>]
        NodeId: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("node.name")>]
        NodeName: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("node.ephemeral_id")>]
        NodeEphemeralId: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("node.address")>]
        NodeAddress: string option
    }


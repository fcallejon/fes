// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module WatcherExecuteWatch =

    type WatchRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("condition")>]
        Condition: WatcherTypes.ConditionContainer
        [<System.Text.Json.Serialization.JsonPropertyName("input")>]
        Input: WatcherTypes.InputContainer
        [<System.Text.Json.Serialization.JsonPropertyName("messages")>]
        Messages: string list
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: string
        [<System.Text.Json.Serialization.JsonPropertyName("result")>]
        Result: WatcherTypes.ExecutionResult
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: WatcherTypes.ExecutionStatus
        [<System.Text.Json.Serialization.JsonPropertyName("trigger_event")>]
        TriggerEvent: WatcherTypes.TriggerEventResult
        [<System.Text.Json.Serialization.JsonPropertyName("user")>]
        User: Types.Username
        [<System.Text.Json.Serialization.JsonPropertyName("watch_id")>]
        WatchId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: WatcherTypes.WatchStatus option
    }


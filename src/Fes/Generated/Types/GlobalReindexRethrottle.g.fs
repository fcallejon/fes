// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalReindexRethrottle =

    type ReindexTask = {
        [<System.Text.Json.Serialization.JsonPropertyName("action")>]
        Action: string
        [<System.Text.Json.Serialization.JsonPropertyName("cancellable")>]
        Cancellable: bool
        [<System.Text.Json.Serialization.JsonPropertyName("cancelled")>]
        Cancelled: bool
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("running_time_in_nanos")>]
        RunningTimeInNanos: Types.DurationValue<Types.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("start_time_in_millis")>]
        StartTimeInMillis: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: Types.ReindexStatus
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("headers")>]
        Headers: Types.HttpHeaders
    }

    type ParentReindexTask = {
        [<System.Text.Json.Serialization.JsonPropertyName("children")>]
        Children: GlobalReindexRethrottle.ReindexTask list option
    }

    type ReindexNode = {
        [<System.Text.Json.Serialization.JsonPropertyName("tasks")>]
        Tasks: Map<Types.TaskId, GlobalReindexRethrottle.ReindexTask>
    }

    [<RequireQualifiedAccess>]
    type ReindexTasks =
        | Array of GlobalReindexRethrottle.ReindexTask list
        | Dictionary of Map<string, GlobalReindexRethrottle.ParentReindexTask>


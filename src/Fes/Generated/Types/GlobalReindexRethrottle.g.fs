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
        Id: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("running_time_in_nanos")>]
        RunningTimeInNanos: CoreTypes.DurationValue<CoreTypes.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("start_time_in_millis")>]
        StartTimeInMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: CoreTypes.ReindexStatus
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("headers")>]
        Headers: CoreTypes.HttpHeaders
    }

    type ParentReindexTask = {
        [<System.Text.Json.Serialization.JsonPropertyName("children")>]
        Children: ReindexTask list option
    }

    type ReindexNode = {
        [<System.Text.Json.Serialization.JsonPropertyName("tasks")>]
        Tasks: Map<CoreTypes.TaskId, ReindexTask>
    }

    [<RequireQualifiedAccess>]
    type ReindexTasks =
        | Array of ReindexTask list
        | Dictionary of Map<string, ParentReindexTask>


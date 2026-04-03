// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module EnrichStats =

    type CacheStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("node_id")>]
        NodeId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("hits")>]
        Hits: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("hits_time_in_millis")>]
        HitsTimeInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("misses")>]
        Misses: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("misses_time_in_millis")>]
        MissesTimeInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("evictions")>]
        Evictions: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("size_in_bytes")>]
        SizeInBytes: CoreTypes.Long
    }

    type CoordinatorStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("executed_searches_total")>]
        ExecutedSearchesTotal: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("node_id")>]
        NodeId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("queue_size")>]
        QueueSize: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("remote_requests_current")>]
        RemoteRequestsCurrent: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("remote_requests_total")>]
        RemoteRequestsTotal: CoreTypes.Long
    }

    type ExecutingPolicy = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("task")>]
        Task: TasksTypes.TaskInfo
    }


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module EnrichStats =

    type CacheStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("node_id")>]
        NodeId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("hits")>]
        Hits: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("hits_time_in_millis")>]
        HitsTimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("misses")>]
        Misses: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("misses_time_in_millis")>]
        MissesTimeInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("evictions")>]
        Evictions: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("size_in_bytes")>]
        SizeInBytes: Types.Long
    }

    type CoordinatorStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("executed_searches_total")>]
        ExecutedSearchesTotal: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("node_id")>]
        NodeId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("queue_size")>]
        QueueSize: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("remote_requests_current")>]
        RemoteRequestsCurrent: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("remote_requests_total")>]
        RemoteRequestsTotal: Types.Long
    }

    type ExecutingPolicy = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("task")>]
        Task: TasksTypes.TaskInfo
    }


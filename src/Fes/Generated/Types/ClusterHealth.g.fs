// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module ClusterHealth =

    type ShardHealthStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("active_shards")>]
        ActiveShards: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("initializing_shards")>]
        InitializingShards: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("primary_active")>]
        PrimaryActive: bool
        [<System.Text.Json.Serialization.JsonPropertyName("relocating_shards")>]
        RelocatingShards: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: CoreTypes.HealthStatus
        [<System.Text.Json.Serialization.JsonPropertyName("unassigned_shards")>]
        UnassignedShards: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("unassigned_primary_shards")>]
        UnassignedPrimaryShards: CoreTypes.Integer
    }

    type IndexHealthStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("active_primary_shards")>]
        ActivePrimaryShards: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("active_shards")>]
        ActiveShards: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("initializing_shards")>]
        InitializingShards: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_replicas")>]
        NumberOfReplicas: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_shards")>]
        NumberOfShards: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("relocating_shards")>]
        RelocatingShards: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: Map<string, ShardHealthStats> option
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: CoreTypes.HealthStatus
        [<System.Text.Json.Serialization.JsonPropertyName("unassigned_shards")>]
        UnassignedShards: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("unassigned_primary_shards")>]
        UnassignedPrimaryShards: CoreTypes.Integer
    }

    type HealthResponseBody = {
        [<System.Text.Json.Serialization.JsonPropertyName("active_primary_shards")>]
        ActivePrimaryShards: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("active_shards")>]
        ActiveShards: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("active_shards_percent")>]
        ActiveShardsPercent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("active_shards_percent_as_number")>]
        ActiveShardsPercentAsNumber: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_name")>]
        ClusterName: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("delayed_unassigned_shards")>]
        DelayedUnassignedShards: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: Map<CoreTypes.IndexName, IndexHealthStats> option
        [<System.Text.Json.Serialization.JsonPropertyName("initializing_shards")>]
        InitializingShards: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_data_nodes")>]
        NumberOfDataNodes: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_in_flight_fetch")>]
        NumberOfInFlightFetch: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_nodes")>]
        NumberOfNodes: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_pending_tasks")>]
        NumberOfPendingTasks: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("relocating_shards")>]
        RelocatingShards: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: CoreTypes.HealthStatus
        [<System.Text.Json.Serialization.JsonPropertyName("task_max_waiting_in_queue")>]
        TaskMaxWaitingInQueue: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("task_max_waiting_in_queue_millis")>]
        TaskMaxWaitingInQueueMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("timed_out")>]
        TimedOut: bool
        [<System.Text.Json.Serialization.JsonPropertyName("unassigned_primary_shards")>]
        UnassignedPrimaryShards: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("unassigned_shards")>]
        UnassignedShards: CoreTypes.Integer
    }

    [<RequireQualifiedAccess>]
    type WaitForNodes =
        | String of string
        | Integer of CoreTypes.Integer


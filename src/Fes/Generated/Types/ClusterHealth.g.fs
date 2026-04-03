// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module ClusterHealth =

    type ShardHealthStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("active_shards")>]
        ActiveShards: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("initializing_shards")>]
        InitializingShards: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("primary_active")>]
        PrimaryActive: bool
        [<System.Text.Json.Serialization.JsonPropertyName("relocating_shards")>]
        RelocatingShards: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: Types.HealthStatus
        [<System.Text.Json.Serialization.JsonPropertyName("unassigned_shards")>]
        UnassignedShards: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("unassigned_primary_shards")>]
        UnassignedPrimaryShards: Types.Integer
    }

    type IndexHealthStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("active_primary_shards")>]
        ActivePrimaryShards: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("active_shards")>]
        ActiveShards: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("initializing_shards")>]
        InitializingShards: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_replicas")>]
        NumberOfReplicas: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_shards")>]
        NumberOfShards: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("relocating_shards")>]
        RelocatingShards: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: Map<string, ClusterHealth.ShardHealthStats> option
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: Types.HealthStatus
        [<System.Text.Json.Serialization.JsonPropertyName("unassigned_shards")>]
        UnassignedShards: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("unassigned_primary_shards")>]
        UnassignedPrimaryShards: Types.Integer
    }

    type HealthResponseBody = {
        [<System.Text.Json.Serialization.JsonPropertyName("active_primary_shards")>]
        ActivePrimaryShards: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("active_shards")>]
        ActiveShards: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("active_shards_percent")>]
        ActiveShardsPercent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("active_shards_percent_as_number")>]
        ActiveShardsPercentAsNumber: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_name")>]
        ClusterName: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("delayed_unassigned_shards")>]
        DelayedUnassignedShards: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: Map<Types.IndexName, ClusterHealth.IndexHealthStats> option
        [<System.Text.Json.Serialization.JsonPropertyName("initializing_shards")>]
        InitializingShards: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_data_nodes")>]
        NumberOfDataNodes: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_in_flight_fetch")>]
        NumberOfInFlightFetch: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_nodes")>]
        NumberOfNodes: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_pending_tasks")>]
        NumberOfPendingTasks: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("relocating_shards")>]
        RelocatingShards: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: Types.HealthStatus
        [<System.Text.Json.Serialization.JsonPropertyName("task_max_waiting_in_queue")>]
        TaskMaxWaitingInQueue: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("task_max_waiting_in_queue_millis")>]
        TaskMaxWaitingInQueueMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("timed_out")>]
        TimedOut: bool
        [<System.Text.Json.Serialization.JsonPropertyName("unassigned_primary_shards")>]
        UnassignedPrimaryShards: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("unassigned_shards")>]
        UnassignedShards: Types.Integer
    }

    [<RequireQualifiedAccess>]
    type WaitForNodes =
        | String of string
        | Integer of Types.Integer


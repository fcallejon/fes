// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatSnapshots =

    type SnapshotsRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: string option
        [<System.Text.Json.Serialization.JsonPropertyName("repository")>]
        Repository: string option
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: string option
        [<System.Text.Json.Serialization.JsonPropertyName("start_epoch")>]
        StartEpoch: CoreTypes.Stringified<CoreTypes.EpochTime<CoreTypes.UnitSeconds>> option
        [<System.Text.Json.Serialization.JsonPropertyName("start_time")>]
        StartTime: WatcherTypes.ScheduleTimeOfDay option
        [<System.Text.Json.Serialization.JsonPropertyName("end_epoch")>]
        EndEpoch: CoreTypes.Stringified<CoreTypes.EpochTime<CoreTypes.UnitSeconds>> option
        [<System.Text.Json.Serialization.JsonPropertyName("end_time")>]
        EndTime: CoreTypes.TimeOfDay option
        [<System.Text.Json.Serialization.JsonPropertyName("duration")>]
        Duration: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: string option
        [<System.Text.Json.Serialization.JsonPropertyName("successful_shards")>]
        SuccessfulShards: string option
        [<System.Text.Json.Serialization.JsonPropertyName("failed_shards")>]
        FailedShards: string option
        [<System.Text.Json.Serialization.JsonPropertyName("total_shards")>]
        TotalShards: string option
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string option
    }


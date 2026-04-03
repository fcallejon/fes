// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module CatHealthBuilders =

    type HealthRecordBuilder() =
        member _.Yield(_: unit) : Types.HealthRecord =
            {
                Epoch = None
                Timestamp = None
                Cluster = None
                Status = None
                NodeTotal = None
                NodeData = None
                Shards = None
                Pri = None
                Relo = None
                Init = None
                UnassignPri = None
                Unassign = None
                PendingTasks = None
                MaxTaskWaitTime = None
                ActiveShardsPercent = None
            }

        [<CustomOperation("epoch")>]
        member _.Epoch(state: Types.HealthRecord, value: Types.Stringified<Types.EpochTime<Types.UnitSeconds>>) =
            { state with Epoch = Some value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: Types.HealthRecord, value: Types.TimeOfDay) =
            { state with Timestamp = Some value }

        [<CustomOperation("cluster")>]
        member _.Cluster(state: Types.HealthRecord, value: string) =
            { state with Cluster = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.HealthRecord, value: string) =
            { state with Status = Some value }

        [<CustomOperation("nodeTotal")>]
        member _.NodeTotal(state: Types.HealthRecord, value: string) =
            { state with NodeTotal = Some value }

        [<CustomOperation("nodeData")>]
        member _.NodeData(state: Types.HealthRecord, value: string) =
            { state with NodeData = Some value }

        [<CustomOperation("shards")>]
        member _.Shards(state: Types.HealthRecord, value: string) =
            { state with Shards = Some value }

        [<CustomOperation("pri")>]
        member _.Pri(state: Types.HealthRecord, value: string) =
            { state with Pri = Some value }

        [<CustomOperation("relo")>]
        member _.Relo(state: Types.HealthRecord, value: string) =
            { state with Relo = Some value }

        [<CustomOperation("init")>]
        member _.Init(state: Types.HealthRecord, value: string) =
            { state with Init = Some value }

        [<CustomOperation("unassignPri")>]
        member _.UnassignPri(state: Types.HealthRecord, value: string) =
            { state with UnassignPri = Some value }

        [<CustomOperation("unassign")>]
        member _.Unassign(state: Types.HealthRecord, value: string) =
            { state with Unassign = Some value }

        [<CustomOperation("pendingTasks")>]
        member _.PendingTasks(state: Types.HealthRecord, value: string) =
            { state with PendingTasks = Some value }

        [<CustomOperation("maxTaskWaitTime")>]
        member _.MaxTaskWaitTime(state: Types.HealthRecord, value: string) =
            { state with MaxTaskWaitTime = Some value }

        [<CustomOperation("activeShardsPercent")>]
        member _.ActiveShardsPercent(state: Types.HealthRecord, value: string) =
            { state with ActiveShardsPercent = Some value }

    let healthRecord = HealthRecordBuilder()


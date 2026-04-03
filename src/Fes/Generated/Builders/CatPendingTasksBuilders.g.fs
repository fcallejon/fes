// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module CatPendingTasksBuilders =

    type PendingTasksRecordBuilder() =
        member _.Yield(_: unit) : Types.PendingTasksRecord =
            {
                InsertOrder = None
                TimeInQueue = None
                Priority = None
                Source = None
            }

        [<CustomOperation("insertOrder")>]
        member _.InsertOrder(state: Types.PendingTasksRecord, value: string) =
            { state with InsertOrder = Some value }

        [<CustomOperation("timeInQueue")>]
        member _.TimeInQueue(state: Types.PendingTasksRecord, value: string) =
            { state with TimeInQueue = Some value }

        [<CustomOperation("priority")>]
        member _.Priority(state: Types.PendingTasksRecord, value: string) =
            { state with Priority = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: Types.PendingTasksRecord, value: string) =
            { state with Source = Some value }

    let pendingTasksRecord = PendingTasksRecordBuilder()


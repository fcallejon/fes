// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module WatcherExecuteWatchBuilders =

    type WatchRecordBuilder() =
        member _.Yield(_: unit) : Types.WatchRecord =
            {
                Condition = Unchecked.defaultof<_>
                Input = Unchecked.defaultof<_>
                Messages = Unchecked.defaultof<_>
                Metadata = None
                Node = Unchecked.defaultof<_>
                Result = Unchecked.defaultof<_>
                State = Unchecked.defaultof<_>
                TriggerEvent = Unchecked.defaultof<_>
                User = Unchecked.defaultof<_>
                WatchId = Unchecked.defaultof<_>
                Status = None
            }

        [<CustomOperation("condition")>]
        member _.Condition(state: Types.WatchRecord, value: Types.ConditionContainer) =
            { state with Condition = value }

        [<CustomOperation("input")>]
        member _.Input(state: Types.WatchRecord, value: Types.InputContainer) =
            { state with Input = value }

        [<CustomOperation("messages")>]
        member _.Messages(state: Types.WatchRecord, value: string list) =
            { state with Messages = value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: Types.WatchRecord, value: Types.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("node")>]
        member _.Node(state: Types.WatchRecord, value: string) =
            { state with Node = value }

        [<CustomOperation("result")>]
        member _.Result(state: Types.WatchRecord, value: Types.ExecutionResult) =
            { state with Result = value }

        [<CustomOperation("state")>]
        member _.State(state: Types.WatchRecord, value: Types.ExecutionStatus) =
            { state with State = value }

        [<CustomOperation("triggerEvent")>]
        member _.TriggerEvent(state: Types.WatchRecord, value: Types.TriggerEventResult) =
            { state with TriggerEvent = value }

        [<CustomOperation("user")>]
        member _.User(state: Types.WatchRecord, value: Types.Username) =
            { state with User = value }

        [<CustomOperation("watchId")>]
        member _.WatchId(state: Types.WatchRecord, value: Types.Id) =
            { state with WatchId = value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.WatchRecord, value: Types.WatchStatus) =
            { state with Status = Some value }

    let watchRecord = WatchRecordBuilder()


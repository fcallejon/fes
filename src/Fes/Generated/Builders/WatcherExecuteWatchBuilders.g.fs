// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module WatcherExecuteWatchBuilders =

    type WatchRecordBuilder() =
        member _.Yield(_: unit) : WatchRecord =
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
        member _.Condition(state: WatchRecord, value: WatcherTypes.ConditionContainer) =
            { state with Condition = value }

        [<CustomOperation("input")>]
        member _.Input(state: WatchRecord, value: WatcherTypes.InputContainer) =
            { state with Input = value }

        [<CustomOperation("messages")>]
        member _.Messages(state: WatchRecord, value: string list) =
            { state with Messages = value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: WatchRecord, value: CoreTypes.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("node")>]
        member _.Node(state: WatchRecord, value: string) =
            { state with Node = value }

        [<CustomOperation("result")>]
        member _.Result(state: WatchRecord, value: WatcherTypes.ExecutionResult) =
            { state with Result = value }

        [<CustomOperation("state")>]
        member _.State(state: WatchRecord, value: WatcherTypes.ExecutionStatus) =
            { state with State = value }

        [<CustomOperation("triggerEvent")>]
        member _.TriggerEvent(state: WatchRecord, value: WatcherTypes.TriggerEventResult) =
            { state with TriggerEvent = value }

        [<CustomOperation("user")>]
        member _.User(state: WatchRecord, value: CoreTypes.Username) =
            { state with User = value }

        [<CustomOperation("watchId")>]
        member _.WatchId(state: WatchRecord, value: CoreTypes.Id) =
            { state with WatchId = value }

        [<CustomOperation("status")>]
        member _.Status(state: WatchRecord, value: WatcherTypes.WatchStatus) =
            { state with Status = Some value }

    let watchRecord = WatchRecordBuilder()


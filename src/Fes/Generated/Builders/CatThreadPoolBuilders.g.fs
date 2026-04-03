// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module CatThreadPoolBuilders =

    type ThreadPoolRecordBuilder() =
        member _.Yield(_: unit) : ThreadPoolRecord =
            {
                NodeName = None
                NodeId = None
                EphemeralNodeId = None
                Pid = None
                Host = None
                Ip = None
                Port = None
                Name = None
                Type = None
                Active = None
                PoolSize = None
                Queue = None
                QueueSize = None
                Rejected = None
                Largest = None
                Completed = None
                Core = None
                Max = None
                Size = None
                KeepAlive = None
            }

        [<CustomOperation("nodeName")>]
        member _.NodeName(state: ThreadPoolRecord, value: string) =
            { state with NodeName = Some value }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: ThreadPoolRecord, value: CoreTypes.NodeId) =
            { state with NodeId = Some value }

        [<CustomOperation("ephemeralNodeId")>]
        member _.EphemeralNodeId(state: ThreadPoolRecord, value: string) =
            { state with EphemeralNodeId = Some value }

        [<CustomOperation("pid")>]
        member _.Pid(state: ThreadPoolRecord, value: string) =
            { state with Pid = Some value }

        [<CustomOperation("host")>]
        member _.Host(state: ThreadPoolRecord, value: string) =
            { state with Host = Some value }

        [<CustomOperation("ip")>]
        member _.Ip(state: ThreadPoolRecord, value: string) =
            { state with Ip = Some value }

        [<CustomOperation("port")>]
        member _.Port(state: ThreadPoolRecord, value: string) =
            { state with Port = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: ThreadPoolRecord, value: string) =
            { state with Name = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: ThreadPoolRecord, value: string) =
            { state with Type = Some value }

        [<CustomOperation("active")>]
        member _.Active(state: ThreadPoolRecord, value: string) =
            { state with Active = Some value }

        [<CustomOperation("poolSize")>]
        member _.PoolSize(state: ThreadPoolRecord, value: string) =
            { state with PoolSize = Some value }

        [<CustomOperation("queue")>]
        member _.Queue(state: ThreadPoolRecord, value: string) =
            { state with Queue = Some value }

        [<CustomOperation("queueSize")>]
        member _.QueueSize(state: ThreadPoolRecord, value: string) =
            { state with QueueSize = Some value }

        [<CustomOperation("rejected")>]
        member _.Rejected(state: ThreadPoolRecord, value: string) =
            { state with Rejected = Some value }

        [<CustomOperation("largest")>]
        member _.Largest(state: ThreadPoolRecord, value: string) =
            { state with Largest = Some value }

        [<CustomOperation("completed")>]
        member _.Completed(state: ThreadPoolRecord, value: string) =
            { state with Completed = Some value }

        [<CustomOperation("core")>]
        member _.Core(state: ThreadPoolRecord, value: string option) =
            { state with Core = Some value }

        [<CustomOperation("max")>]
        member _.Max(state: ThreadPoolRecord, value: string option) =
            { state with Max = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: ThreadPoolRecord, value: string option) =
            { state with Size = Some value }

        [<CustomOperation("keepAlive")>]
        member _.KeepAlive(state: ThreadPoolRecord, value: string option) =
            { state with KeepAlive = Some value }

    let threadPoolRecord = ThreadPoolRecordBuilder()


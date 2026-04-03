// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module CatNodeattrsBuilders =

    type NodeAttributesRecordBuilder() =
        member _.Yield(_: unit) : NodeAttributesRecord =
            {
                Node = None
                Id = None
                Pid = None
                Host = None
                Ip = None
                Port = None
                Attr = None
                Value = None
            }

        [<CustomOperation("node")>]
        member _.Node(state: NodeAttributesRecord, value: string) =
            { state with Node = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: NodeAttributesRecord, value: string) =
            { state with Id = Some value }

        [<CustomOperation("pid")>]
        member _.Pid(state: NodeAttributesRecord, value: string) =
            { state with Pid = Some value }

        [<CustomOperation("host")>]
        member _.Host(state: NodeAttributesRecord, value: string) =
            { state with Host = Some value }

        [<CustomOperation("ip")>]
        member _.Ip(state: NodeAttributesRecord, value: string) =
            { state with Ip = Some value }

        [<CustomOperation("port")>]
        member _.Port(state: NodeAttributesRecord, value: string) =
            { state with Port = Some value }

        [<CustomOperation("attr")>]
        member _.Attr(state: NodeAttributesRecord, value: string) =
            { state with Attr = Some value }

        [<CustomOperation("value")>]
        member _.Value(state: NodeAttributesRecord, value: string) =
            { state with Value = Some value }

    let nodeAttributesRecord = NodeAttributesRecordBuilder()


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module CatMasterBuilders =

    type MasterRecordBuilder() =
        member _.Yield(_: unit) : Types.MasterRecord =
            {
                Id = None
                Host = None
                Ip = None
                Node = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.MasterRecord, value: string) =
            { state with Id = Some value }

        [<CustomOperation("host")>]
        member _.Host(state: Types.MasterRecord, value: string) =
            { state with Host = Some value }

        [<CustomOperation("ip")>]
        member _.Ip(state: Types.MasterRecord, value: string) =
            { state with Ip = Some value }

        [<CustomOperation("node")>]
        member _.Node(state: Types.MasterRecord, value: string) =
            { state with Node = Some value }

    let masterRecord = MasterRecordBuilder()


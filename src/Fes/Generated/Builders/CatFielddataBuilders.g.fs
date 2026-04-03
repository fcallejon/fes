// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module CatFielddataBuilders =

    type FielddataRecordBuilder() =
        member _.Yield(_: unit) : Types.FielddataRecord =
            {
                Id = None
                Host = None
                Ip = None
                Node = None
                Field = None
                Size = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.FielddataRecord, value: string) =
            { state with Id = Some value }

        [<CustomOperation("host")>]
        member _.Host(state: Types.FielddataRecord, value: string) =
            { state with Host = Some value }

        [<CustomOperation("ip")>]
        member _.Ip(state: Types.FielddataRecord, value: string) =
            { state with Ip = Some value }

        [<CustomOperation("node")>]
        member _.Node(state: Types.FielddataRecord, value: string) =
            { state with Node = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.FielddataRecord, value: string) =
            { state with Field = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.FielddataRecord, value: string) =
            { state with Size = Some value }

    let fielddataRecord = FielddataRecordBuilder()


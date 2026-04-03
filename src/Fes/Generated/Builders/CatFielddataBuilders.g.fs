// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module CatFielddataBuilders =

    type FielddataRecordBuilder() =
        member _.Yield(_: unit) : FielddataRecord =
            {
                Id = None
                Host = None
                Ip = None
                Node = None
                Field = None
                Size = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: FielddataRecord, value: string) =
            { state with Id = Some value }

        [<CustomOperation("host")>]
        member _.Host(state: FielddataRecord, value: string) =
            { state with Host = Some value }

        [<CustomOperation("ip")>]
        member _.Ip(state: FielddataRecord, value: string) =
            { state with Ip = Some value }

        [<CustomOperation("node")>]
        member _.Node(state: FielddataRecord, value: string) =
            { state with Node = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: FielddataRecord, value: string) =
            { state with Field = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: FielddataRecord, value: string) =
            { state with Size = Some value }

    let fielddataRecord = FielddataRecordBuilder()


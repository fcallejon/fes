// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module GlobalMtermvectorsBuilders =

    type GlobalMtermvectorsOperationBuilder() =
        member _.Yield(_: unit) : Types.GlobalMtermvectorsOperation =
            {
                Id = None
                Index = None
                Doc = None
                Fields = None
                FieldStatistics = None
                Filter = None
                Offsets = None
                Payloads = None
                Positions = None
                Routing = None
                TermStatistics = None
                Version = None
                VersionType = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.GlobalMtermvectorsOperation, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.GlobalMtermvectorsOperation, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("doc")>]
        member _.Doc(state: Types.GlobalMtermvectorsOperation, value: System.Text.Json.JsonElement) =
            { state with Doc = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.GlobalMtermvectorsOperation, value: Types.Fields) =
            { state with Fields = Some value }

        [<CustomOperation("fieldStatistics")>]
        member _.FieldStatistics(state: Types.GlobalMtermvectorsOperation, value: bool) =
            { state with FieldStatistics = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: Types.GlobalMtermvectorsOperation, value: Types.GlobalTermvectorsFilter) =
            { state with Filter = Some value }

        [<CustomOperation("offsets")>]
        member _.Offsets(state: Types.GlobalMtermvectorsOperation, value: bool) =
            { state with Offsets = Some value }

        [<CustomOperation("payloads")>]
        member _.Payloads(state: Types.GlobalMtermvectorsOperation, value: bool) =
            { state with Payloads = Some value }

        [<CustomOperation("positions")>]
        member _.Positions(state: Types.GlobalMtermvectorsOperation, value: bool) =
            { state with Positions = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: Types.GlobalMtermvectorsOperation, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("termStatistics")>]
        member _.TermStatistics(state: Types.GlobalMtermvectorsOperation, value: bool) =
            { state with TermStatistics = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.GlobalMtermvectorsOperation, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: Types.GlobalMtermvectorsOperation, value: Types.VersionType) =
            { state with VersionType = Some value }

    let globalMtermvectorsOperation = GlobalMtermvectorsOperationBuilder()

    type TermVectorsResultBuilder() =
        member _.Yield(_: unit) : Types.TermVectorsResult =
            {
                Id = None
                Index = Unchecked.defaultof<_>
                Version = None
                Took = None
                Found = None
                TermVectors = None
                Error = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.TermVectorsResult, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.TermVectorsResult, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.TermVectorsResult, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("took")>]
        member _.Took(state: Types.TermVectorsResult, value: Types.Long) =
            { state with Took = Some value }

        [<CustomOperation("found")>]
        member _.Found(state: Types.TermVectorsResult, value: bool) =
            { state with Found = Some value }

        [<CustomOperation("termVectors")>]
        member _.TermVectors(state: Types.TermVectorsResult, value: Map<Types.Field, Types.TermVector>) =
            { state with TermVectors = Some value }

        [<CustomOperation("error")>]
        member _.Error(state: Types.TermVectorsResult, value: Types.ErrorCause) =
            { state with Error = Some value }

    let termVectorsResult = TermVectorsResultBuilder()


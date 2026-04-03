// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module GlobalMtermvectorsBuilders =

    type OperationBuilder() =
        member _.Yield(_: unit) : Operation =
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
        member _.Id(state: Operation, value: CoreTypes.Id) =
            { state with Id = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Operation, value: CoreTypes.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("doc")>]
        member _.Doc(state: Operation, value: System.Text.Json.JsonElement) =
            { state with Doc = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Operation, value: CoreTypes.Fields) =
            { state with Fields = Some value }

        [<CustomOperation("fieldStatistics")>]
        member _.FieldStatistics(state: Operation, value: bool) =
            { state with FieldStatistics = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: Operation, value: GlobalTermvectors.Filter) =
            { state with Filter = Some value }

        [<CustomOperation("offsets")>]
        member _.Offsets(state: Operation, value: bool) =
            { state with Offsets = Some value }

        [<CustomOperation("payloads")>]
        member _.Payloads(state: Operation, value: bool) =
            { state with Payloads = Some value }

        [<CustomOperation("positions")>]
        member _.Positions(state: Operation, value: bool) =
            { state with Positions = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: Operation, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("termStatistics")>]
        member _.TermStatistics(state: Operation, value: bool) =
            { state with TermStatistics = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Operation, value: CoreTypes.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: Operation, value: CoreTypes.VersionType) =
            { state with VersionType = Some value }

    let operation = OperationBuilder()

    type TermVectorsResultBuilder() =
        member _.Yield(_: unit) : TermVectorsResult =
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
        member _.Id(state: TermVectorsResult, value: CoreTypes.Id) =
            { state with Id = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: TermVectorsResult, value: CoreTypes.IndexName) =
            { state with Index = value }

        [<CustomOperation("version")>]
        member _.Version(state: TermVectorsResult, value: CoreTypes.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("took")>]
        member _.Took(state: TermVectorsResult, value: CoreTypes.Long) =
            { state with Took = Some value }

        [<CustomOperation("found")>]
        member _.Found(state: TermVectorsResult, value: bool) =
            { state with Found = Some value }

        [<CustomOperation("termVectors")>]
        member _.TermVectors(state: TermVectorsResult, value: Map<CoreTypes.Field, GlobalTermvectors.TermVector>) =
            { state with TermVectors = Some value }

        [<CustomOperation("error")>]
        member _.Error(state: TermVectorsResult, value: CoreTypes.ErrorCause) =
            { state with Error = Some value }

    let termVectorsResult = TermVectorsResultBuilder()


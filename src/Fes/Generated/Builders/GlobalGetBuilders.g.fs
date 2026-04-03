// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module GlobalGetBuilders =

    type GetResultBuilder() =
        member _.Yield(_: unit) : GetResult =
            {
                Index = Unchecked.defaultof<_>
                Fields = None
                Ignored = None
                Found = Unchecked.defaultof<_>
                Id = Unchecked.defaultof<_>
                PrimaryTerm = None
                Routing = None
                SeqNo = None
                Source = None
                Version = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: GetResult, value: CoreTypes.IndexName) =
            { state with Index = value }

        [<CustomOperation("fields")>]
        member _.Fields(state: GetResult, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Fields = Some value }

        [<CustomOperation("ignored")>]
        member _.Ignored(state: GetResult, value: string list) =
            { state with Ignored = Some value }

        [<CustomOperation("found")>]
        member _.Found(state: GetResult, value: bool) =
            { state with Found = value }

        [<CustomOperation("id")>]
        member _.Id(state: GetResult, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("primaryTerm")>]
        member _.PrimaryTerm(state: GetResult, value: CoreTypes.Long) =
            { state with PrimaryTerm = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: GetResult, value: string) =
            { state with Routing = Some value }

        [<CustomOperation("seqNo")>]
        member _.SeqNo(state: GetResult, value: CoreTypes.SequenceNumber) =
            { state with SeqNo = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: GetResult, value: 'tDocument) =
            { state with Source = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: GetResult, value: CoreTypes.VersionNumber) =
            { state with Version = Some value }

    let getResult = GetResultBuilder()


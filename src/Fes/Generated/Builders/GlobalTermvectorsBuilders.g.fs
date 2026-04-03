// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module GlobalTermvectorsBuilders =

    type GlobalTermvectorsFilterBuilder() =
        member _.Yield(_: unit) : Types.GlobalTermvectorsFilter =
            {
                MaxDocFreq = None
                MaxNumTerms = None
                MaxTermFreq = None
                MaxWordLength = None
                MinDocFreq = None
                MinTermFreq = None
                MinWordLength = None
            }

        [<CustomOperation("maxDocFreq")>]
        member _.MaxDocFreq(state: Types.GlobalTermvectorsFilter, value: Types.Integer) =
            { state with MaxDocFreq = Some value }

        [<CustomOperation("maxNumTerms")>]
        member _.MaxNumTerms(state: Types.GlobalTermvectorsFilter, value: Types.Integer) =
            { state with MaxNumTerms = Some value }

        [<CustomOperation("maxTermFreq")>]
        member _.MaxTermFreq(state: Types.GlobalTermvectorsFilter, value: Types.Integer) =
            { state with MaxTermFreq = Some value }

        [<CustomOperation("maxWordLength")>]
        member _.MaxWordLength(state: Types.GlobalTermvectorsFilter, value: Types.Integer) =
            { state with MaxWordLength = Some value }

        [<CustomOperation("minDocFreq")>]
        member _.MinDocFreq(state: Types.GlobalTermvectorsFilter, value: Types.Integer) =
            { state with MinDocFreq = Some value }

        [<CustomOperation("minTermFreq")>]
        member _.MinTermFreq(state: Types.GlobalTermvectorsFilter, value: Types.Integer) =
            { state with MinTermFreq = Some value }

        [<CustomOperation("minWordLength")>]
        member _.MinWordLength(state: Types.GlobalTermvectorsFilter, value: Types.Integer) =
            { state with MinWordLength = Some value }

    let globalTermvectorsFilter = GlobalTermvectorsFilterBuilder()

    type TermBuilder() =
        member _.Yield(_: unit) : Types.Term =
            {
                DocFreq = None
                Score = None
                TermFreq = Unchecked.defaultof<_>
                Tokens = None
                Ttf = None
            }

        [<CustomOperation("docFreq")>]
        member _.DocFreq(state: Types.Term, value: Types.Integer) =
            { state with DocFreq = Some value }

        [<CustomOperation("score")>]
        member _.Score(state: Types.Term, value: Types.Double) =
            { state with Score = Some value }

        [<CustomOperation("termFreq")>]
        member _.TermFreq(state: Types.Term, value: Types.Integer) =
            { state with TermFreq = value }

        [<CustomOperation("tokens")>]
        member _.Tokens(state: Types.Term, value: Types.GlobalTermvectorsToken list) =
            { state with Tokens = Some value }

        [<CustomOperation("ttf")>]
        member _.Ttf(state: Types.Term, value: Types.Integer) =
            { state with Ttf = Some value }

    let term = TermBuilder()

    type GlobalTermvectorsTokenBuilder() =
        member _.Yield(_: unit) : Types.GlobalTermvectorsToken =
            {
                EndOffset = None
                Payload = None
                Position = Unchecked.defaultof<_>
                StartOffset = None
            }

        [<CustomOperation("endOffset")>]
        member _.EndOffset(state: Types.GlobalTermvectorsToken, value: Types.Integer) =
            { state with EndOffset = Some value }

        [<CustomOperation("payload")>]
        member _.Payload(state: Types.GlobalTermvectorsToken, value: string) =
            { state with Payload = Some value }

        [<CustomOperation("position")>]
        member _.Position(state: Types.GlobalTermvectorsToken, value: Types.Integer) =
            { state with Position = value }

        [<CustomOperation("startOffset")>]
        member _.StartOffset(state: Types.GlobalTermvectorsToken, value: Types.Integer) =
            { state with StartOffset = Some value }

    let globalTermvectorsToken = GlobalTermvectorsTokenBuilder()


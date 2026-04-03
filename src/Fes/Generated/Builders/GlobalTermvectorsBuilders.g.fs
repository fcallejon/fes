// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module GlobalTermvectorsBuilders =

    type FilterBuilder() =
        member _.Yield(_: unit) : Filter =
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
        member _.MaxDocFreq(state: Filter, value: Types.Integer) =
            { state with MaxDocFreq = Some value }

        [<CustomOperation("maxNumTerms")>]
        member _.MaxNumTerms(state: Filter, value: Types.Integer) =
            { state with MaxNumTerms = Some value }

        [<CustomOperation("maxTermFreq")>]
        member _.MaxTermFreq(state: Filter, value: Types.Integer) =
            { state with MaxTermFreq = Some value }

        [<CustomOperation("maxWordLength")>]
        member _.MaxWordLength(state: Filter, value: Types.Integer) =
            { state with MaxWordLength = Some value }

        [<CustomOperation("minDocFreq")>]
        member _.MinDocFreq(state: Filter, value: Types.Integer) =
            { state with MinDocFreq = Some value }

        [<CustomOperation("minTermFreq")>]
        member _.MinTermFreq(state: Filter, value: Types.Integer) =
            { state with MinTermFreq = Some value }

        [<CustomOperation("minWordLength")>]
        member _.MinWordLength(state: Filter, value: Types.Integer) =
            { state with MinWordLength = Some value }

    let filter = FilterBuilder()

    type TermBuilder() =
        member _.Yield(_: unit) : Term =
            {
                DocFreq = None
                Score = None
                TermFreq = Unchecked.defaultof<_>
                Tokens = None
                Ttf = None
            }

        [<CustomOperation("docFreq")>]
        member _.DocFreq(state: Term, value: Types.Integer) =
            { state with DocFreq = Some value }

        [<CustomOperation("score")>]
        member _.Score(state: Term, value: Types.Double) =
            { state with Score = Some value }

        [<CustomOperation("termFreq")>]
        member _.TermFreq(state: Term, value: Types.Integer) =
            { state with TermFreq = value }

        [<CustomOperation("tokens")>]
        member _.Tokens(state: Term, value: GlobalTermvectors.Token list) =
            { state with Tokens = Some value }

        [<CustomOperation("ttf")>]
        member _.Ttf(state: Term, value: Types.Integer) =
            { state with Ttf = Some value }

    let term = TermBuilder()

    type TokenBuilder() =
        member _.Yield(_: unit) : Token =
            {
                EndOffset = None
                Payload = None
                Position = Unchecked.defaultof<_>
                StartOffset = None
            }

        [<CustomOperation("endOffset")>]
        member _.EndOffset(state: Token, value: Types.Integer) =
            { state with EndOffset = Some value }

        [<CustomOperation("payload")>]
        member _.Payload(state: Token, value: string) =
            { state with Payload = Some value }

        [<CustomOperation("position")>]
        member _.Position(state: Token, value: Types.Integer) =
            { state with Position = value }

        [<CustomOperation("startOffset")>]
        member _.StartOffset(state: Token, value: Types.Integer) =
            { state with StartOffset = Some value }

    let token = TokenBuilder()


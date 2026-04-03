// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module IndicesAnalyzeBuilders =

    type AnalyzeDetailBuilder() =
        member _.Yield(_: unit) : Types.AnalyzeDetail =
            {
                Analyzer = None
                Charfilters = None
                CustomAnalyzer = Unchecked.defaultof<_>
                Tokenfilters = None
                Tokenizer = None
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: Types.AnalyzeDetail, value: Types.AnalyzerDetail) =
            { state with Analyzer = Some value }

        [<CustomOperation("charfilters")>]
        member _.Charfilters(state: Types.AnalyzeDetail, value: Types.CharFilterDetail list) =
            { state with Charfilters = Some value }

        [<CustomOperation("customAnalyzer")>]
        member _.CustomAnalyzer(state: Types.AnalyzeDetail, value: bool) =
            { state with CustomAnalyzer = value }

        [<CustomOperation("tokenfilters")>]
        member _.Tokenfilters(state: Types.AnalyzeDetail, value: Types.TokenDetail list) =
            { state with Tokenfilters = Some value }

        [<CustomOperation("tokenizer")>]
        member _.Tokenizer(state: Types.AnalyzeDetail, value: Types.TokenDetail) =
            { state with Tokenizer = Some value }

    let analyzeDetail = AnalyzeDetailBuilder()


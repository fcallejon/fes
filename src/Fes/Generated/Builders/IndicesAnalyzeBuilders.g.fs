// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module IndicesAnalyzeBuilders =

    type AnalyzeDetailBuilder() =
        member _.Yield(_: unit) : AnalyzeDetail =
            {
                Analyzer = None
                Charfilters = None
                CustomAnalyzer = Unchecked.defaultof<_>
                Tokenfilters = None
                Tokenizer = None
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: AnalyzeDetail, value: IndicesAnalyze.AnalyzerDetail) =
            { state with Analyzer = Some value }

        [<CustomOperation("charfilters")>]
        member _.Charfilters(state: AnalyzeDetail, value: IndicesAnalyze.CharFilterDetail list) =
            { state with Charfilters = Some value }

        [<CustomOperation("customAnalyzer")>]
        member _.CustomAnalyzer(state: AnalyzeDetail, value: bool) =
            { state with CustomAnalyzer = value }

        [<CustomOperation("tokenfilters")>]
        member _.Tokenfilters(state: AnalyzeDetail, value: IndicesAnalyze.TokenDetail list) =
            { state with Tokenfilters = Some value }

        [<CustomOperation("tokenizer")>]
        member _.Tokenizer(state: AnalyzeDetail, value: IndicesAnalyze.TokenDetail) =
            { state with Tokenizer = Some value }

    let analyzeDetail = AnalyzeDetailBuilder()


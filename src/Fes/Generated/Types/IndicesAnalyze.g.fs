// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesAnalyze =

    type ExplainAnalyzeToken = {
        [<System.Text.Json.Serialization.JsonPropertyName("bytes")>]
        Bytes: string
        [<System.Text.Json.Serialization.JsonPropertyName("end_offset")>]
        EndOffset: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("keyword")>]
        Keyword: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("position")>]
        Position: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("positionLength")>]
        PositionLength: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("start_offset")>]
        StartOffset: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("termFrequency")>]
        TermFrequency: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("token")>]
        Token: string
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type AnalyzerDetail = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
        [<System.Text.Json.Serialization.JsonPropertyName("tokens")>]
        Tokens: ExplainAnalyzeToken list
    }

    type CharFilterDetail = {
        [<System.Text.Json.Serialization.JsonPropertyName("filtered_text")>]
        FilteredText: string list
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
    }

    type TokenDetail = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
        [<System.Text.Json.Serialization.JsonPropertyName("tokens")>]
        Tokens: ExplainAnalyzeToken list
    }

    type AnalyzeDetail = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: AnalyzerDetail option
        [<System.Text.Json.Serialization.JsonPropertyName("charfilters")>]
        Charfilters: CharFilterDetail list option
        [<System.Text.Json.Serialization.JsonPropertyName("custom_analyzer")>]
        CustomAnalyzer: bool
        [<System.Text.Json.Serialization.JsonPropertyName("tokenfilters")>]
        Tokenfilters: TokenDetail list option
        [<System.Text.Json.Serialization.JsonPropertyName("tokenizer")>]
        Tokenizer: TokenDetail option
    }

    type AnalyzeToken = {
        [<System.Text.Json.Serialization.JsonPropertyName("end_offset")>]
        EndOffset: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("position")>]
        Position: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("positionLength")>]
        PositionLength: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("start_offset")>]
        StartOffset: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("token")>]
        Token: string
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    [<RequireQualifiedAccess>]
    type TextToAnalyze =
        | String of string
        | Array of string list


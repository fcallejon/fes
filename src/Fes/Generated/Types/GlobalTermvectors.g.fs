// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalTermvectors =

    type FieldStatistics = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc_count")>]
        DocCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("sum_doc_freq")>]
        SumDocFreq: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("sum_ttf")>]
        SumTtf: CoreTypes.Long
    }

    type Filter = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_doc_freq")>]
        MaxDocFreq: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_num_terms")>]
        MaxNumTerms: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_term_freq")>]
        MaxTermFreq: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_word_length")>]
        MaxWordLength: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_freq")>]
        MinDocFreq: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_term_freq")>]
        MinTermFreq: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_word_length")>]
        MinWordLength: CoreTypes.Integer option
    }

    type Token = {
        [<System.Text.Json.Serialization.JsonPropertyName("end_offset")>]
        EndOffset: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("payload")>]
        Payload: string option
        [<System.Text.Json.Serialization.JsonPropertyName("position")>]
        Position: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("start_offset")>]
        StartOffset: CoreTypes.Integer option
    }

    type Term = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc_freq")>]
        DocFreq: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("score")>]
        Score: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("term_freq")>]
        TermFreq: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("tokens")>]
        Tokens: Token list option
        [<System.Text.Json.Serialization.JsonPropertyName("ttf")>]
        Ttf: CoreTypes.Integer option
    }

    type TermVector = {
        [<System.Text.Json.Serialization.JsonPropertyName("field_statistics")>]
        FieldStatistics: FieldStatistics option
        [<System.Text.Json.Serialization.JsonPropertyName("terms")>]
        Terms: Map<string, Term>
    }


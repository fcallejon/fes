// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalTermvectors =

    type FieldStatistics = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc_count")>]
        DocCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("sum_doc_freq")>]
        SumDocFreq: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("sum_ttf")>]
        SumTtf: Types.Long
    }

    type Filter = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_doc_freq")>]
        MaxDocFreq: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_num_terms")>]
        MaxNumTerms: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_term_freq")>]
        MaxTermFreq: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_word_length")>]
        MaxWordLength: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_freq")>]
        MinDocFreq: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_term_freq")>]
        MinTermFreq: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_word_length")>]
        MinWordLength: Types.Integer option
    }

    type Token = {
        [<System.Text.Json.Serialization.JsonPropertyName("end_offset")>]
        EndOffset: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("payload")>]
        Payload: string option
        [<System.Text.Json.Serialization.JsonPropertyName("position")>]
        Position: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("start_offset")>]
        StartOffset: Types.Integer option
    }

    type Term = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc_freq")>]
        DocFreq: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("score")>]
        Score: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("term_freq")>]
        TermFreq: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("tokens")>]
        Tokens: GlobalTermvectors.Token list option
        [<System.Text.Json.Serialization.JsonPropertyName("ttf")>]
        Ttf: Types.Integer option
    }

    type TermVector = {
        [<System.Text.Json.Serialization.JsonPropertyName("field_statistics")>]
        FieldStatistics: GlobalTermvectors.FieldStatistics option
        [<System.Text.Json.Serialization.JsonPropertyName("terms")>]
        Terms: Map<string, GlobalTermvectors.Term>
    }


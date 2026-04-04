// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module TypesAnalysisBuilders =

    type ArabicAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.ArabicAnalyzer =
            {
                Type = "arabic"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.ArabicAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.ArabicAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.ArabicAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.ArabicAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let arabicAnalyzer = ArabicAnalyzerBuilder()

    type ArmenianAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.ArmenianAnalyzer =
            {
                Type = "armenian"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.ArmenianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.ArmenianAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.ArmenianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.ArmenianAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let armenianAnalyzer = ArmenianAnalyzerBuilder()

    type BasqueAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.BasqueAnalyzer =
            {
                Type = "basque"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.BasqueAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.BasqueAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.BasqueAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.BasqueAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let basqueAnalyzer = BasqueAnalyzerBuilder()

    type BengaliAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.BengaliAnalyzer =
            {
                Type = "bengali"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.BengaliAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.BengaliAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.BengaliAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.BengaliAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let bengaliAnalyzer = BengaliAnalyzerBuilder()

    type BrazilianAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.BrazilianAnalyzer =
            {
                Type = "brazilian"
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.BrazilianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.BrazilianAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.BrazilianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

    let brazilianAnalyzer = BrazilianAnalyzerBuilder()

    type BulgarianAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.BulgarianAnalyzer =
            {
                Type = "bulgarian"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.BulgarianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.BulgarianAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.BulgarianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.BulgarianAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let bulgarianAnalyzer = BulgarianAnalyzerBuilder()

    type CatalanAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.CatalanAnalyzer =
            {
                Type = "catalan"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.CatalanAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.CatalanAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.CatalanAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.CatalanAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let catalanAnalyzer = CatalanAnalyzerBuilder()

    type ChineseAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.ChineseAnalyzer =
            {
                Type = "chinese"
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.ChineseAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.ChineseAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.ChineseAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

    let chineseAnalyzer = ChineseAnalyzerBuilder()

    type CjkAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.CjkAnalyzer =
            {
                Type = "cjk"
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.CjkAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.CjkAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.CjkAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

    let cjkAnalyzer = CjkAnalyzerBuilder()

    type CjkBigramTokenFilterBuilder() =
        member _.Yield(_: unit) : Types.CjkBigramTokenFilter =
            {
                Type = "cjk_bigram"
                IgnoredScripts = None
                OutputUnigrams = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.CjkBigramTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("ignoredScripts")>]
        member _.IgnoredScripts(state: Types.CjkBigramTokenFilter, value: Types.CjkBigramIgnoredScript list) =
            { state with IgnoredScripts = Some value }

        [<CustomOperation("outputUnigrams")>]
        member _.OutputUnigrams(state: Types.CjkBigramTokenFilter, value: bool) =
            { state with OutputUnigrams = Some value }

    let cjkBigramTokenFilter = CjkBigramTokenFilterBuilder()

    type CommonGramsTokenFilterBuilder() =
        member _.Yield(_: unit) : Types.CommonGramsTokenFilter =
            {
                Type = "common_grams"
                CommonWords = None
                CommonWordsPath = None
                IgnoreCase = None
                QueryMode = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.CommonGramsTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("commonWords")>]
        member _.CommonWords(state: Types.CommonGramsTokenFilter, value: string list) =
            { state with CommonWords = Some value }

        [<CustomOperation("commonWordsPath")>]
        member _.CommonWordsPath(state: Types.CommonGramsTokenFilter, value: string) =
            { state with CommonWordsPath = Some value }

        [<CustomOperation("ignoreCase")>]
        member _.IgnoreCase(state: Types.CommonGramsTokenFilter, value: bool) =
            { state with IgnoreCase = Some value }

        [<CustomOperation("queryMode")>]
        member _.QueryMode(state: Types.CommonGramsTokenFilter, value: bool) =
            { state with QueryMode = Some value }

    let commonGramsTokenFilter = CommonGramsTokenFilterBuilder()

    type CompoundWordTokenFilterBaseBuilder() =
        member _.Yield(_: unit) : Types.CompoundWordTokenFilterBase =
            {
                MaxSubwordSize = None
                MinSubwordSize = None
                MinWordSize = None
                OnlyLongestMatch = None
                WordList = None
                WordListPath = None
            }

        [<CustomOperation("maxSubwordSize")>]
        member _.MaxSubwordSize(state: Types.CompoundWordTokenFilterBase, value: Types.Integer) =
            { state with MaxSubwordSize = Some value }

        [<CustomOperation("minSubwordSize")>]
        member _.MinSubwordSize(state: Types.CompoundWordTokenFilterBase, value: Types.Integer) =
            { state with MinSubwordSize = Some value }

        [<CustomOperation("minWordSize")>]
        member _.MinWordSize(state: Types.CompoundWordTokenFilterBase, value: Types.Integer) =
            { state with MinWordSize = Some value }

        [<CustomOperation("onlyLongestMatch")>]
        member _.OnlyLongestMatch(state: Types.CompoundWordTokenFilterBase, value: bool) =
            { state with OnlyLongestMatch = Some value }

        [<CustomOperation("wordList")>]
        member _.WordList(state: Types.CompoundWordTokenFilterBase, value: string list) =
            { state with WordList = Some value }

        [<CustomOperation("wordListPath")>]
        member _.WordListPath(state: Types.CompoundWordTokenFilterBase, value: string) =
            { state with WordListPath = Some value }

    let compoundWordTokenFilterBase = CompoundWordTokenFilterBaseBuilder()

    type CustomAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.CustomAnalyzer =
            {
                Type = "custom"
                CharFilter = None
                Filter = None
                PositionIncrementGap = None
                PositionOffsetGap = None
                Tokenizer = Unchecked.defaultof<_>
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.CustomAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("charFilter")>]
        member _.CharFilter(state: Types.CustomAnalyzer, value: System.Text.Json.JsonElement) =
            { state with CharFilter = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: Types.CustomAnalyzer, value: System.Text.Json.JsonElement) =
            { state with Filter = Some value }

        [<CustomOperation("positionIncrementGap")>]
        member _.PositionIncrementGap(state: Types.CustomAnalyzer, value: Types.Integer) =
            { state with PositionIncrementGap = Some value }

        [<CustomOperation("positionOffsetGap")>]
        member _.PositionOffsetGap(state: Types.CustomAnalyzer, value: Types.Integer) =
            { state with PositionOffsetGap = Some value }

        [<CustomOperation("tokenizer")>]
        member _.Tokenizer(state: Types.CustomAnalyzer, value: string) =
            { state with Tokenizer = value }

    let customAnalyzer = CustomAnalyzerBuilder()

    type CustomNormalizerBuilder() =
        member _.Yield(_: unit) : Types.CustomNormalizer =
            {
                Type = "custom"
                CharFilter = None
                Filter = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.CustomNormalizer, value: string) =
            { state with Type = value }

        [<CustomOperation("charFilter")>]
        member _.CharFilter(state: Types.CustomNormalizer, value: string list) =
            { state with CharFilter = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: Types.CustomNormalizer, value: string list) =
            { state with Filter = Some value }

    let customNormalizer = CustomNormalizerBuilder()

    type CzechAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.CzechAnalyzer =
            {
                Type = "czech"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.CzechAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.CzechAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.CzechAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.CzechAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let czechAnalyzer = CzechAnalyzerBuilder()

    type DanishAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.DanishAnalyzer =
            {
                Type = "danish"
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.DanishAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.DanishAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.DanishAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

    let danishAnalyzer = DanishAnalyzerBuilder()

    type DelimitedPayloadTokenFilterBuilder() =
        member _.Yield(_: unit) : Types.DelimitedPayloadTokenFilter =
            {
                Type = "delimited_payload"
                Delimiter = None
                Encoding = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.DelimitedPayloadTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("delimiter")>]
        member _.Delimiter(state: Types.DelimitedPayloadTokenFilter, value: string) =
            { state with Delimiter = Some value }

        [<CustomOperation("encoding")>]
        member _.Encoding(state: Types.DelimitedPayloadTokenFilter, value: Types.DelimitedPayloadEncoding) =
            { state with Encoding = Some value }

    let delimitedPayloadTokenFilter = DelimitedPayloadTokenFilterBuilder()

    type DutchAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.DutchAnalyzer =
            {
                Type = "dutch"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.DutchAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.DutchAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.DutchAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.DutchAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let dutchAnalyzer = DutchAnalyzerBuilder()

    type EdgeNGramTokenFilterBuilder() =
        member _.Yield(_: unit) : Types.EdgeNGramTokenFilter =
            {
                Type = "edge_ngram"
                MaxGram = None
                MinGram = None
                Side = None
                PreserveOriginal = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.EdgeNGramTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("maxGram")>]
        member _.MaxGram(state: Types.EdgeNGramTokenFilter, value: Types.Integer) =
            { state with MaxGram = Some value }

        [<CustomOperation("minGram")>]
        member _.MinGram(state: Types.EdgeNGramTokenFilter, value: Types.Integer) =
            { state with MinGram = Some value }

        [<CustomOperation("side")>]
        member _.Side(state: Types.EdgeNGramTokenFilter, value: Types.EdgeNGramSide) =
            { state with Side = Some value }

        [<CustomOperation("preserveOriginal")>]
        member _.PreserveOriginal(state: Types.EdgeNGramTokenFilter, value: Types.Stringified<bool>) =
            { state with PreserveOriginal = Some value }

    let edgeNGramTokenFilter = EdgeNGramTokenFilterBuilder()

    type EdgeNGramTokenizerBuilder() =
        member _.Yield(_: unit) : Types.EdgeNGramTokenizer =
            {
                Type = "edge_ngram"
                CustomTokenChars = None
                MaxGram = None
                MinGram = None
                TokenChars = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.EdgeNGramTokenizer, value: string) =
            { state with Type = value }

        [<CustomOperation("customTokenChars")>]
        member _.CustomTokenChars(state: Types.EdgeNGramTokenizer, value: string) =
            { state with CustomTokenChars = Some value }

        [<CustomOperation("maxGram")>]
        member _.MaxGram(state: Types.EdgeNGramTokenizer, value: Types.Integer) =
            { state with MaxGram = Some value }

        [<CustomOperation("minGram")>]
        member _.MinGram(state: Types.EdgeNGramTokenizer, value: Types.Integer) =
            { state with MinGram = Some value }

        [<CustomOperation("tokenChars")>]
        member _.TokenChars(state: Types.EdgeNGramTokenizer, value: Types.TokenChar list) =
            { state with TokenChars = Some value }

    let edgeNGramTokenizer = EdgeNGramTokenizerBuilder()

    type ElisionTokenFilterBuilder() =
        member _.Yield(_: unit) : Types.ElisionTokenFilter =
            {
                Type = "elision"
                Articles = None
                ArticlesPath = None
                ArticlesCase = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.ElisionTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("articles")>]
        member _.Articles(state: Types.ElisionTokenFilter, value: string list) =
            { state with Articles = Some value }

        [<CustomOperation("articlesPath")>]
        member _.ArticlesPath(state: Types.ElisionTokenFilter, value: string) =
            { state with ArticlesPath = Some value }

        [<CustomOperation("articlesCase")>]
        member _.ArticlesCase(state: Types.ElisionTokenFilter, value: Types.Stringified<bool>) =
            { state with ArticlesCase = Some value }

    let elisionTokenFilter = ElisionTokenFilterBuilder()

    type EnglishAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.EnglishAnalyzer =
            {
                Type = "english"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.EnglishAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.EnglishAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.EnglishAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.EnglishAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let englishAnalyzer = EnglishAnalyzerBuilder()

    type EstonianAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.EstonianAnalyzer =
            {
                Type = "estonian"
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.EstonianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.EstonianAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.EstonianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

    let estonianAnalyzer = EstonianAnalyzerBuilder()

    type FingerprintAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.FingerprintAnalyzer =
            {
                Type = "fingerprint"
                Version = None
                MaxOutputSize = None
                Separator = None
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.FingerprintAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.FingerprintAnalyzer, value: Types.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("maxOutputSize")>]
        member _.MaxOutputSize(state: Types.FingerprintAnalyzer, value: Types.Integer) =
            { state with MaxOutputSize = Some value }

        [<CustomOperation("separator")>]
        member _.Separator(state: Types.FingerprintAnalyzer, value: string) =
            { state with Separator = Some value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.FingerprintAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.FingerprintAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

    let fingerprintAnalyzer = FingerprintAnalyzerBuilder()

    type FingerprintTokenFilterBuilder() =
        member _.Yield(_: unit) : Types.FingerprintTokenFilter =
            {
                Type = "fingerprint"
                MaxOutputSize = None
                Separator = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.FingerprintTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("maxOutputSize")>]
        member _.MaxOutputSize(state: Types.FingerprintTokenFilter, value: Types.Integer) =
            { state with MaxOutputSize = Some value }

        [<CustomOperation("separator")>]
        member _.Separator(state: Types.FingerprintTokenFilter, value: string) =
            { state with Separator = Some value }

    let fingerprintTokenFilter = FingerprintTokenFilterBuilder()

    type FinnishAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.FinnishAnalyzer =
            {
                Type = "finnish"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.FinnishAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.FinnishAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.FinnishAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.FinnishAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let finnishAnalyzer = FinnishAnalyzerBuilder()

    type FrenchAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.FrenchAnalyzer =
            {
                Type = "french"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.FrenchAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.FrenchAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.FrenchAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.FrenchAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let frenchAnalyzer = FrenchAnalyzerBuilder()

    type GalicianAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.GalicianAnalyzer =
            {
                Type = "galician"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.GalicianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.GalicianAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.GalicianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.GalicianAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let galicianAnalyzer = GalicianAnalyzerBuilder()

    type GermanAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.GermanAnalyzer =
            {
                Type = "german"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.GermanAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.GermanAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.GermanAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.GermanAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let germanAnalyzer = GermanAnalyzerBuilder()

    type GreekAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.GreekAnalyzer =
            {
                Type = "greek"
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.GreekAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.GreekAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.GreekAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

    let greekAnalyzer = GreekAnalyzerBuilder()

    type HindiAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.HindiAnalyzer =
            {
                Type = "hindi"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.HindiAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.HindiAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.HindiAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.HindiAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let hindiAnalyzer = HindiAnalyzerBuilder()

    type HungarianAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.HungarianAnalyzer =
            {
                Type = "hungarian"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.HungarianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.HungarianAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.HungarianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.HungarianAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let hungarianAnalyzer = HungarianAnalyzerBuilder()

    type HunspellTokenFilterBuilder() =
        member _.Yield(_: unit) : Types.HunspellTokenFilter =
            {
                Type = "hunspell"
                Dedup = None
                Dictionary = None
                Locale = Unchecked.defaultof<_>
                LongestOnly = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.HunspellTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("dedup")>]
        member _.Dedup(state: Types.HunspellTokenFilter, value: bool) =
            { state with Dedup = Some value }

        [<CustomOperation("dictionary")>]
        member _.Dictionary(state: Types.HunspellTokenFilter, value: string) =
            { state with Dictionary = Some value }

        [<CustomOperation("locale")>]
        member _.Locale(state: Types.HunspellTokenFilter, value: string) =
            { state with Locale = value }

        [<CustomOperation("longestOnly")>]
        member _.LongestOnly(state: Types.HunspellTokenFilter, value: bool) =
            { state with LongestOnly = Some value }

    let hunspellTokenFilter = HunspellTokenFilterBuilder()

    type HyphenationDecompounderTokenFilterBuilder() =
        member _.Yield(_: unit) : Types.HyphenationDecompounderTokenFilter =
            {
                Type = "hyphenation_decompounder"
                HyphenationPatternsPath = Unchecked.defaultof<_>
                NoSubMatches = None
                NoOverlappingMatches = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.HyphenationDecompounderTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("hyphenationPatternsPath")>]
        member _.HyphenationPatternsPath(state: Types.HyphenationDecompounderTokenFilter, value: string) =
            { state with HyphenationPatternsPath = value }

        [<CustomOperation("noSubMatches")>]
        member _.NoSubMatches(state: Types.HyphenationDecompounderTokenFilter, value: bool) =
            { state with NoSubMatches = Some value }

        [<CustomOperation("noOverlappingMatches")>]
        member _.NoOverlappingMatches(state: Types.HyphenationDecompounderTokenFilter, value: bool) =
            { state with NoOverlappingMatches = Some value }

    let hyphenationDecompounderTokenFilter = HyphenationDecompounderTokenFilterBuilder()

    type IcuCollationTokenFilterBuilder() =
        member _.Yield(_: unit) : Types.IcuCollationTokenFilter =
            {
                Type = "icu_collation"
                Alternate = None
                CaseFirst = None
                CaseLevel = None
                Country = None
                Decomposition = None
                HiraganaQuaternaryMode = None
                Language = None
                Numeric = None
                Rules = None
                Strength = None
                VariableTop = None
                Variant = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.IcuCollationTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("alternate")>]
        member _.Alternate(state: Types.IcuCollationTokenFilter, value: Types.IcuCollationAlternate) =
            { state with Alternate = Some value }

        [<CustomOperation("caseFirst")>]
        member _.CaseFirst(state: Types.IcuCollationTokenFilter, value: Types.IcuCollationCaseFirst) =
            { state with CaseFirst = Some value }

        [<CustomOperation("caseLevel")>]
        member _.CaseLevel(state: Types.IcuCollationTokenFilter, value: bool) =
            { state with CaseLevel = Some value }

        [<CustomOperation("country")>]
        member _.Country(state: Types.IcuCollationTokenFilter, value: string) =
            { state with Country = Some value }

        [<CustomOperation("decomposition")>]
        member _.Decomposition(state: Types.IcuCollationTokenFilter, value: Types.IcuCollationDecomposition) =
            { state with Decomposition = Some value }

        [<CustomOperation("hiraganaQuaternaryMode")>]
        member _.HiraganaQuaternaryMode(state: Types.IcuCollationTokenFilter, value: bool) =
            { state with HiraganaQuaternaryMode = Some value }

        [<CustomOperation("language")>]
        member _.Language(state: Types.IcuCollationTokenFilter, value: string) =
            { state with Language = Some value }

        [<CustomOperation("numeric")>]
        member _.Numeric(state: Types.IcuCollationTokenFilter, value: bool) =
            { state with Numeric = Some value }

        [<CustomOperation("rules")>]
        member _.Rules(state: Types.IcuCollationTokenFilter, value: string) =
            { state with Rules = Some value }

        [<CustomOperation("strength")>]
        member _.Strength(state: Types.IcuCollationTokenFilter, value: Types.IcuCollationStrength) =
            { state with Strength = Some value }

        [<CustomOperation("variableTop")>]
        member _.VariableTop(state: Types.IcuCollationTokenFilter, value: string) =
            { state with VariableTop = Some value }

        [<CustomOperation("variant")>]
        member _.Variant(state: Types.IcuCollationTokenFilter, value: string) =
            { state with Variant = Some value }

    let icuCollationTokenFilter = IcuCollationTokenFilterBuilder()

    type IcuNormalizationCharFilterBuilder() =
        member _.Yield(_: unit) : Types.IcuNormalizationCharFilter =
            {
                Type = "icu_normalizer"
                Mode = None
                Name = None
                UnicodeSetFilter = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.IcuNormalizationCharFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("mode")>]
        member _.Mode(state: Types.IcuNormalizationCharFilter, value: Types.IcuNormalizationMode) =
            { state with Mode = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Types.IcuNormalizationCharFilter, value: Types.IcuNormalizationType) =
            { state with Name = Some value }

        [<CustomOperation("unicodeSetFilter")>]
        member _.UnicodeSetFilter(state: Types.IcuNormalizationCharFilter, value: string) =
            { state with UnicodeSetFilter = Some value }

    let icuNormalizationCharFilter = IcuNormalizationCharFilterBuilder()

    type IndonesianAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.IndonesianAnalyzer =
            {
                Type = "indonesian"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.IndonesianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.IndonesianAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.IndonesianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.IndonesianAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let indonesianAnalyzer = IndonesianAnalyzerBuilder()

    type IrishAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.IrishAnalyzer =
            {
                Type = "irish"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.IrishAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.IrishAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.IrishAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.IrishAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let irishAnalyzer = IrishAnalyzerBuilder()

    type ItalianAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.ItalianAnalyzer =
            {
                Type = "italian"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.ItalianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.ItalianAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.ItalianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.ItalianAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let italianAnalyzer = ItalianAnalyzerBuilder()

    type KeepWordsTokenFilterBuilder() =
        member _.Yield(_: unit) : Types.KeepWordsTokenFilter =
            {
                Type = "keep"
                KeepWords = None
                KeepWordsCase = None
                KeepWordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.KeepWordsTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("keepWords")>]
        member _.KeepWords(state: Types.KeepWordsTokenFilter, value: string list) =
            { state with KeepWords = Some value }

        [<CustomOperation("keepWordsCase")>]
        member _.KeepWordsCase(state: Types.KeepWordsTokenFilter, value: bool) =
            { state with KeepWordsCase = Some value }

        [<CustomOperation("keepWordsPath")>]
        member _.KeepWordsPath(state: Types.KeepWordsTokenFilter, value: string) =
            { state with KeepWordsPath = Some value }

    let keepWordsTokenFilter = KeepWordsTokenFilterBuilder()

    type KeywordMarkerTokenFilterBuilder() =
        member _.Yield(_: unit) : Types.KeywordMarkerTokenFilter =
            {
                Type = "keyword_marker"
                IgnoreCase = None
                Keywords = None
                KeywordsPath = None
                KeywordsPattern = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.KeywordMarkerTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("ignoreCase")>]
        member _.IgnoreCase(state: Types.KeywordMarkerTokenFilter, value: bool) =
            { state with IgnoreCase = Some value }

        [<CustomOperation("keywords")>]
        member _.Keywords(state: Types.KeywordMarkerTokenFilter, value: System.Text.Json.JsonElement) =
            { state with Keywords = Some value }

        [<CustomOperation("keywordsPath")>]
        member _.KeywordsPath(state: Types.KeywordMarkerTokenFilter, value: string) =
            { state with KeywordsPath = Some value }

        [<CustomOperation("keywordsPattern")>]
        member _.KeywordsPattern(state: Types.KeywordMarkerTokenFilter, value: string) =
            { state with KeywordsPattern = Some value }

    let keywordMarkerTokenFilter = KeywordMarkerTokenFilterBuilder()

    type KuromojiAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.KuromojiAnalyzer =
            {
                Type = "kuromoji"
                Mode = None
                UserDictionary = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.KuromojiAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("mode")>]
        member _.Mode(state: Types.KuromojiAnalyzer, value: Types.KuromojiTokenizationMode) =
            { state with Mode = Some value }

        [<CustomOperation("userDictionary")>]
        member _.UserDictionary(state: Types.KuromojiAnalyzer, value: string) =
            { state with UserDictionary = Some value }

    let kuromojiAnalyzer = KuromojiAnalyzerBuilder()

    type KuromojiTokenizerBuilder() =
        member _.Yield(_: unit) : Types.KuromojiTokenizer =
            {
                Type = "kuromoji_tokenizer"
                DiscardPunctuation = None
                Mode = Unchecked.defaultof<_>
                NbestCost = None
                NbestExamples = None
                UserDictionary = None
                UserDictionaryRules = None
                DiscardCompoundToken = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.KuromojiTokenizer, value: string) =
            { state with Type = value }

        [<CustomOperation("discardPunctuation")>]
        member _.DiscardPunctuation(state: Types.KuromojiTokenizer, value: bool) =
            { state with DiscardPunctuation = Some value }

        [<CustomOperation("mode")>]
        member _.Mode(state: Types.KuromojiTokenizer, value: Types.KuromojiTokenizationMode) =
            { state with Mode = value }

        [<CustomOperation("nbestCost")>]
        member _.NbestCost(state: Types.KuromojiTokenizer, value: Types.Integer) =
            { state with NbestCost = Some value }

        [<CustomOperation("nbestExamples")>]
        member _.NbestExamples(state: Types.KuromojiTokenizer, value: string) =
            { state with NbestExamples = Some value }

        [<CustomOperation("userDictionary")>]
        member _.UserDictionary(state: Types.KuromojiTokenizer, value: string) =
            { state with UserDictionary = Some value }

        [<CustomOperation("userDictionaryRules")>]
        member _.UserDictionaryRules(state: Types.KuromojiTokenizer, value: string list) =
            { state with UserDictionaryRules = Some value }

        [<CustomOperation("discardCompoundToken")>]
        member _.DiscardCompoundToken(state: Types.KuromojiTokenizer, value: bool) =
            { state with DiscardCompoundToken = Some value }

    let kuromojiTokenizer = KuromojiTokenizerBuilder()

    type LatvianAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.LatvianAnalyzer =
            {
                Type = "latvian"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.LatvianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.LatvianAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.LatvianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.LatvianAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let latvianAnalyzer = LatvianAnalyzerBuilder()

    type LengthTokenFilterBuilder() =
        member _.Yield(_: unit) : Types.LengthTokenFilter =
            {
                Type = "length"
                Max = None
                Min = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.LengthTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("max")>]
        member _.Max(state: Types.LengthTokenFilter, value: Types.Integer) =
            { state with Max = Some value }

        [<CustomOperation("min")>]
        member _.Min(state: Types.LengthTokenFilter, value: Types.Integer) =
            { state with Min = Some value }

    let lengthTokenFilter = LengthTokenFilterBuilder()

    type LimitTokenCountTokenFilterBuilder() =
        member _.Yield(_: unit) : Types.LimitTokenCountTokenFilter =
            {
                Type = "limit"
                ConsumeAllTokens = None
                MaxTokenCount = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.LimitTokenCountTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("consumeAllTokens")>]
        member _.ConsumeAllTokens(state: Types.LimitTokenCountTokenFilter, value: bool) =
            { state with ConsumeAllTokens = Some value }

        [<CustomOperation("maxTokenCount")>]
        member _.MaxTokenCount(state: Types.LimitTokenCountTokenFilter, value: Types.Stringified<Types.Integer>) =
            { state with MaxTokenCount = Some value }

    let limitTokenCountTokenFilter = LimitTokenCountTokenFilterBuilder()

    type LithuanianAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.LithuanianAnalyzer =
            {
                Type = "lithuanian"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.LithuanianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.LithuanianAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.LithuanianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.LithuanianAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let lithuanianAnalyzer = LithuanianAnalyzerBuilder()

    type MappingCharFilterBuilder() =
        member _.Yield(_: unit) : Types.MappingCharFilter =
            {
                Type = "mapping"
                Mappings = None
                MappingsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.MappingCharFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("mappings")>]
        member _.Mappings(state: Types.MappingCharFilter, value: string list) =
            { state with Mappings = Some value }

        [<CustomOperation("mappingsPath")>]
        member _.MappingsPath(state: Types.MappingCharFilter, value: string) =
            { state with MappingsPath = Some value }

    let mappingCharFilter = MappingCharFilterBuilder()

    type MinHashTokenFilterBuilder() =
        member _.Yield(_: unit) : Types.MinHashTokenFilter =
            {
                Type = "min_hash"
                BucketCount = None
                HashCount = None
                HashSetSize = None
                WithRotation = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.MinHashTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("bucketCount")>]
        member _.BucketCount(state: Types.MinHashTokenFilter, value: Types.Integer) =
            { state with BucketCount = Some value }

        [<CustomOperation("hashCount")>]
        member _.HashCount(state: Types.MinHashTokenFilter, value: Types.Integer) =
            { state with HashCount = Some value }

        [<CustomOperation("hashSetSize")>]
        member _.HashSetSize(state: Types.MinHashTokenFilter, value: Types.Integer) =
            { state with HashSetSize = Some value }

        [<CustomOperation("withRotation")>]
        member _.WithRotation(state: Types.MinHashTokenFilter, value: bool) =
            { state with WithRotation = Some value }

    let minHashTokenFilter = MinHashTokenFilterBuilder()

    type NGramTokenFilterBuilder() =
        member _.Yield(_: unit) : Types.NGramTokenFilter =
            {
                Type = "ngram"
                MaxGram = None
                MinGram = None
                PreserveOriginal = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.NGramTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("maxGram")>]
        member _.MaxGram(state: Types.NGramTokenFilter, value: Types.Integer) =
            { state with MaxGram = Some value }

        [<CustomOperation("minGram")>]
        member _.MinGram(state: Types.NGramTokenFilter, value: Types.Integer) =
            { state with MinGram = Some value }

        [<CustomOperation("preserveOriginal")>]
        member _.PreserveOriginal(state: Types.NGramTokenFilter, value: Types.Stringified<bool>) =
            { state with PreserveOriginal = Some value }

    let nGramTokenFilter = NGramTokenFilterBuilder()

    type NGramTokenizerBuilder() =
        member _.Yield(_: unit) : Types.NGramTokenizer =
            {
                Type = "ngram"
                CustomTokenChars = None
                MaxGram = None
                MinGram = None
                TokenChars = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.NGramTokenizer, value: string) =
            { state with Type = value }

        [<CustomOperation("customTokenChars")>]
        member _.CustomTokenChars(state: Types.NGramTokenizer, value: string) =
            { state with CustomTokenChars = Some value }

        [<CustomOperation("maxGram")>]
        member _.MaxGram(state: Types.NGramTokenizer, value: Types.Integer) =
            { state with MaxGram = Some value }

        [<CustomOperation("minGram")>]
        member _.MinGram(state: Types.NGramTokenizer, value: Types.Integer) =
            { state with MinGram = Some value }

        [<CustomOperation("tokenChars")>]
        member _.TokenChars(state: Types.NGramTokenizer, value: Types.TokenChar list) =
            { state with TokenChars = Some value }

    let nGramTokenizer = NGramTokenizerBuilder()

    type NoriAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.NoriAnalyzer =
            {
                Type = "nori"
                Version = None
                DecompoundMode = None
                Stoptags = None
                UserDictionary = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.NoriAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.NoriAnalyzer, value: Types.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("decompoundMode")>]
        member _.DecompoundMode(state: Types.NoriAnalyzer, value: Types.NoriDecompoundMode) =
            { state with DecompoundMode = Some value }

        [<CustomOperation("stoptags")>]
        member _.Stoptags(state: Types.NoriAnalyzer, value: string list) =
            { state with Stoptags = Some value }

        [<CustomOperation("userDictionary")>]
        member _.UserDictionary(state: Types.NoriAnalyzer, value: string) =
            { state with UserDictionary = Some value }

    let noriAnalyzer = NoriAnalyzerBuilder()

    type NoriTokenizerBuilder() =
        member _.Yield(_: unit) : Types.NoriTokenizer =
            {
                Type = "nori_tokenizer"
                DecompoundMode = None
                DiscardPunctuation = None
                UserDictionary = None
                UserDictionaryRules = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.NoriTokenizer, value: string) =
            { state with Type = value }

        [<CustomOperation("decompoundMode")>]
        member _.DecompoundMode(state: Types.NoriTokenizer, value: Types.NoriDecompoundMode) =
            { state with DecompoundMode = Some value }

        [<CustomOperation("discardPunctuation")>]
        member _.DiscardPunctuation(state: Types.NoriTokenizer, value: bool) =
            { state with DiscardPunctuation = Some value }

        [<CustomOperation("userDictionary")>]
        member _.UserDictionary(state: Types.NoriTokenizer, value: string) =
            { state with UserDictionary = Some value }

        [<CustomOperation("userDictionaryRules")>]
        member _.UserDictionaryRules(state: Types.NoriTokenizer, value: string list) =
            { state with UserDictionaryRules = Some value }

    let noriTokenizer = NoriTokenizerBuilder()

    type NorwegianAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.NorwegianAnalyzer =
            {
                Type = "norwegian"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.NorwegianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.NorwegianAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.NorwegianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.NorwegianAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let norwegianAnalyzer = NorwegianAnalyzerBuilder()

    type PathHierarchyTokenizerBuilder() =
        member _.Yield(_: unit) : Types.PathHierarchyTokenizer =
            {
                Type = "path_hierarchy"
                BufferSize = None
                Delimiter = None
                Replacement = None
                Reverse = None
                Skip = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.PathHierarchyTokenizer, value: string) =
            { state with Type = value }

        [<CustomOperation("bufferSize")>]
        member _.BufferSize(state: Types.PathHierarchyTokenizer, value: Types.Stringified<Types.Integer>) =
            { state with BufferSize = Some value }

        [<CustomOperation("delimiter")>]
        member _.Delimiter(state: Types.PathHierarchyTokenizer, value: string) =
            { state with Delimiter = Some value }

        [<CustomOperation("replacement")>]
        member _.Replacement(state: Types.PathHierarchyTokenizer, value: string) =
            { state with Replacement = Some value }

        [<CustomOperation("reverse")>]
        member _.Reverse(state: Types.PathHierarchyTokenizer, value: Types.Stringified<bool>) =
            { state with Reverse = Some value }

        [<CustomOperation("skip")>]
        member _.Skip(state: Types.PathHierarchyTokenizer, value: Types.Stringified<Types.Integer>) =
            { state with Skip = Some value }

    let pathHierarchyTokenizer = PathHierarchyTokenizerBuilder()

    type PatternAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.PatternAnalyzer =
            {
                Type = "pattern"
                Version = None
                Flags = None
                Lowercase = None
                Pattern = None
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.PatternAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.PatternAnalyzer, value: Types.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("flags")>]
        member _.Flags(state: Types.PatternAnalyzer, value: string) =
            { state with Flags = Some value }

        [<CustomOperation("lowercase")>]
        member _.Lowercase(state: Types.PatternAnalyzer, value: bool) =
            { state with Lowercase = Some value }

        [<CustomOperation("pattern")>]
        member _.Pattern(state: Types.PatternAnalyzer, value: string) =
            { state with Pattern = Some value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.PatternAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.PatternAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

    let patternAnalyzer = PatternAnalyzerBuilder()

    type PatternReplaceCharFilterBuilder() =
        member _.Yield(_: unit) : Types.PatternReplaceCharFilter =
            {
                Type = "pattern_replace"
                Flags = None
                Pattern = Unchecked.defaultof<_>
                Replacement = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.PatternReplaceCharFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("flags")>]
        member _.Flags(state: Types.PatternReplaceCharFilter, value: string) =
            { state with Flags = Some value }

        [<CustomOperation("pattern")>]
        member _.Pattern(state: Types.PatternReplaceCharFilter, value: string) =
            { state with Pattern = value }

        [<CustomOperation("replacement")>]
        member _.Replacement(state: Types.PatternReplaceCharFilter, value: string) =
            { state with Replacement = Some value }

    let patternReplaceCharFilter = PatternReplaceCharFilterBuilder()

    type PatternReplaceTokenFilterBuilder() =
        member _.Yield(_: unit) : Types.PatternReplaceTokenFilter =
            {
                Type = "pattern_replace"
                All = None
                Flags = None
                Pattern = Unchecked.defaultof<_>
                Replacement = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.PatternReplaceTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("all")>]
        member _.All(state: Types.PatternReplaceTokenFilter, value: bool) =
            { state with All = Some value }

        [<CustomOperation("flags")>]
        member _.Flags(state: Types.PatternReplaceTokenFilter, value: string) =
            { state with Flags = Some value }

        [<CustomOperation("pattern")>]
        member _.Pattern(state: Types.PatternReplaceTokenFilter, value: string) =
            { state with Pattern = value }

        [<CustomOperation("replacement")>]
        member _.Replacement(state: Types.PatternReplaceTokenFilter, value: string) =
            { state with Replacement = Some value }

    let patternReplaceTokenFilter = PatternReplaceTokenFilterBuilder()

    type PatternTokenizerBuilder() =
        member _.Yield(_: unit) : Types.PatternTokenizer =
            {
                Type = "pattern"
                Flags = None
                Group = None
                Pattern = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.PatternTokenizer, value: string) =
            { state with Type = value }

        [<CustomOperation("flags")>]
        member _.Flags(state: Types.PatternTokenizer, value: string) =
            { state with Flags = Some value }

        [<CustomOperation("group")>]
        member _.Group(state: Types.PatternTokenizer, value: Types.Integer) =
            { state with Group = Some value }

        [<CustomOperation("pattern")>]
        member _.Pattern(state: Types.PatternTokenizer, value: string) =
            { state with Pattern = Some value }

    let patternTokenizer = PatternTokenizerBuilder()

    type PersianAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.PersianAnalyzer =
            {
                Type = "persian"
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.PersianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.PersianAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.PersianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

    let persianAnalyzer = PersianAnalyzerBuilder()

    type PhoneticTokenFilterBuilder() =
        member _.Yield(_: unit) : Types.PhoneticTokenFilter =
            {
                Type = "phonetic"
                Encoder = Unchecked.defaultof<_>
                Languageset = None
                MaxCodeLen = None
                NameType = None
                Replace = None
                RuleType = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.PhoneticTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("encoder")>]
        member _.Encoder(state: Types.PhoneticTokenFilter, value: Types.PhoneticEncoder) =
            { state with Encoder = value }

        [<CustomOperation("languageset")>]
        member _.Languageset(state: Types.PhoneticTokenFilter, value: System.Text.Json.JsonElement) =
            { state with Languageset = Some value }

        [<CustomOperation("maxCodeLen")>]
        member _.MaxCodeLen(state: Types.PhoneticTokenFilter, value: Types.Integer) =
            { state with MaxCodeLen = Some value }

        [<CustomOperation("nameType")>]
        member _.NameType(state: Types.PhoneticTokenFilter, value: Types.PhoneticNameType) =
            { state with NameType = Some value }

        [<CustomOperation("replace")>]
        member _.Replace(state: Types.PhoneticTokenFilter, value: bool) =
            { state with Replace = Some value }

        [<CustomOperation("ruleType")>]
        member _.RuleType(state: Types.PhoneticTokenFilter, value: Types.PhoneticRuleType) =
            { state with RuleType = Some value }

    let phoneticTokenFilter = PhoneticTokenFilterBuilder()

    type PortugueseAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.PortugueseAnalyzer =
            {
                Type = "portuguese"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.PortugueseAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.PortugueseAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.PortugueseAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.PortugueseAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let portugueseAnalyzer = PortugueseAnalyzerBuilder()

    type RomanianAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.RomanianAnalyzer =
            {
                Type = "romanian"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.RomanianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.RomanianAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.RomanianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.RomanianAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let romanianAnalyzer = RomanianAnalyzerBuilder()

    type RussianAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.RussianAnalyzer =
            {
                Type = "russian"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.RussianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.RussianAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.RussianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.RussianAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let russianAnalyzer = RussianAnalyzerBuilder()

    type SerbianAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.SerbianAnalyzer =
            {
                Type = "serbian"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.SerbianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.SerbianAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.SerbianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.SerbianAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let serbianAnalyzer = SerbianAnalyzerBuilder()

    type ShingleTokenFilterBuilder() =
        member _.Yield(_: unit) : Types.ShingleTokenFilter =
            {
                Type = "shingle"
                FillerToken = None
                MaxShingleSize = None
                MinShingleSize = None
                OutputUnigrams = None
                OutputUnigramsIfNoShingles = None
                TokenSeparator = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.ShingleTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("fillerToken")>]
        member _.FillerToken(state: Types.ShingleTokenFilter, value: string) =
            { state with FillerToken = Some value }

        [<CustomOperation("maxShingleSize")>]
        member _.MaxShingleSize(state: Types.ShingleTokenFilter, value: Types.Stringified<Types.Integer>) =
            { state with MaxShingleSize = Some value }

        [<CustomOperation("minShingleSize")>]
        member _.MinShingleSize(state: Types.ShingleTokenFilter, value: Types.Stringified<Types.Integer>) =
            { state with MinShingleSize = Some value }

        [<CustomOperation("outputUnigrams")>]
        member _.OutputUnigrams(state: Types.ShingleTokenFilter, value: bool) =
            { state with OutputUnigrams = Some value }

        [<CustomOperation("outputUnigramsIfNoShingles")>]
        member _.OutputUnigramsIfNoShingles(state: Types.ShingleTokenFilter, value: bool) =
            { state with OutputUnigramsIfNoShingles = Some value }

        [<CustomOperation("tokenSeparator")>]
        member _.TokenSeparator(state: Types.ShingleTokenFilter, value: string) =
            { state with TokenSeparator = Some value }

    let shingleTokenFilter = ShingleTokenFilterBuilder()

    type SnowballAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.SnowballAnalyzer =
            {
                Type = "snowball"
                Version = None
                Language = Unchecked.defaultof<_>
                Stopwords = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.SnowballAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.SnowballAnalyzer, value: Types.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("language")>]
        member _.Language(state: Types.SnowballAnalyzer, value: Types.SnowballLanguage) =
            { state with Language = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.SnowballAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

    let snowballAnalyzer = SnowballAnalyzerBuilder()

    type SoraniAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.SoraniAnalyzer =
            {
                Type = "sorani"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.SoraniAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.SoraniAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.SoraniAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.SoraniAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let soraniAnalyzer = SoraniAnalyzerBuilder()

    type SpanishAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.SpanishAnalyzer =
            {
                Type = "spanish"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.SpanishAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.SpanishAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.SpanishAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.SpanishAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let spanishAnalyzer = SpanishAnalyzerBuilder()

    type StandardAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.StandardAnalyzer =
            {
                Type = "standard"
                MaxTokenLength = None
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.StandardAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("maxTokenLength")>]
        member _.MaxTokenLength(state: Types.StandardAnalyzer, value: Types.Integer) =
            { state with MaxTokenLength = Some value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.StandardAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.StandardAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

    let standardAnalyzer = StandardAnalyzerBuilder()

    type StemmerOverrideTokenFilterBuilder() =
        member _.Yield(_: unit) : Types.StemmerOverrideTokenFilter =
            {
                Type = "stemmer_override"
                Rules = None
                RulesPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.StemmerOverrideTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("rules")>]
        member _.Rules(state: Types.StemmerOverrideTokenFilter, value: string list) =
            { state with Rules = Some value }

        [<CustomOperation("rulesPath")>]
        member _.RulesPath(state: Types.StemmerOverrideTokenFilter, value: string) =
            { state with RulesPath = Some value }

    let stemmerOverrideTokenFilter = StemmerOverrideTokenFilterBuilder()

    type StopAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.StopAnalyzer =
            {
                Type = "stop"
                Version = None
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.StopAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.StopAnalyzer, value: Types.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.StopAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.StopAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

    let stopAnalyzer = StopAnalyzerBuilder()

    type StopTokenFilterBuilder() =
        member _.Yield(_: unit) : Types.StopTokenFilter =
            {
                Type = "stop"
                IgnoreCase = None
                RemoveTrailing = None
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.StopTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("ignoreCase")>]
        member _.IgnoreCase(state: Types.StopTokenFilter, value: bool) =
            { state with IgnoreCase = Some value }

        [<CustomOperation("removeTrailing")>]
        member _.RemoveTrailing(state: Types.StopTokenFilter, value: bool) =
            { state with RemoveTrailing = Some value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.StopTokenFilter, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.StopTokenFilter, value: string) =
            { state with StopwordsPath = Some value }

    let stopTokenFilter = StopTokenFilterBuilder()

    type SwedishAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.SwedishAnalyzer =
            {
                Type = "swedish"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.SwedishAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.SwedishAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.SwedishAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.SwedishAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let swedishAnalyzer = SwedishAnalyzerBuilder()

    type SynonymTokenFilterBaseBuilder() =
        member _.Yield(_: unit) : Types.SynonymTokenFilterBase =
            {
                Expand = None
                Format = None
                Lenient = None
                Synonyms = None
                SynonymsPath = None
                SynonymsSet = None
                Tokenizer = None
                Updateable = None
            }

        [<CustomOperation("expand")>]
        member _.Expand(state: Types.SynonymTokenFilterBase, value: bool) =
            { state with Expand = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: Types.SynonymTokenFilterBase, value: Types.SynonymFormat) =
            { state with Format = Some value }

        [<CustomOperation("lenient")>]
        member _.Lenient(state: Types.SynonymTokenFilterBase, value: bool) =
            { state with Lenient = Some value }

        [<CustomOperation("synonyms")>]
        member _.Synonyms(state: Types.SynonymTokenFilterBase, value: string list) =
            { state with Synonyms = Some value }

        [<CustomOperation("synonymsPath")>]
        member _.SynonymsPath(state: Types.SynonymTokenFilterBase, value: string) =
            { state with SynonymsPath = Some value }

        [<CustomOperation("synonymsSet")>]
        member _.SynonymsSet(state: Types.SynonymTokenFilterBase, value: string) =
            { state with SynonymsSet = Some value }

        [<CustomOperation("tokenizer")>]
        member _.Tokenizer(state: Types.SynonymTokenFilterBase, value: string) =
            { state with Tokenizer = Some value }

        [<CustomOperation("updateable")>]
        member _.Updateable(state: Types.SynonymTokenFilterBase, value: bool) =
            { state with Updateable = Some value }

    let synonymTokenFilterBase = SynonymTokenFilterBaseBuilder()

    type ThaiAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.ThaiAnalyzer =
            {
                Type = "thai"
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.ThaiAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.ThaiAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.ThaiAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

    let thaiAnalyzer = ThaiAnalyzerBuilder()

    type TurkishAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.TurkishAnalyzer =
            {
                Type = "turkish"
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.TurkishAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: Types.TurkishAnalyzer, value: Types.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: Types.TurkishAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: Types.TurkishAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let turkishAnalyzer = TurkishAnalyzerBuilder()

    type WordDelimiterGraphTokenFilterBuilder() =
        member _.Yield(_: unit) : Types.WordDelimiterGraphTokenFilter =
            {
                Type = "word_delimiter_graph"
                AdjustOffsets = None
                IgnoreKeywords = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.WordDelimiterGraphTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("adjustOffsets")>]
        member _.AdjustOffsets(state: Types.WordDelimiterGraphTokenFilter, value: bool) =
            { state with AdjustOffsets = Some value }

        [<CustomOperation("ignoreKeywords")>]
        member _.IgnoreKeywords(state: Types.WordDelimiterGraphTokenFilter, value: bool) =
            { state with IgnoreKeywords = Some value }

    let wordDelimiterGraphTokenFilter = WordDelimiterGraphTokenFilterBuilder()

    type WordDelimiterTokenFilterBaseBuilder() =
        member _.Yield(_: unit) : Types.WordDelimiterTokenFilterBase =
            {
                CatenateAll = None
                CatenateNumbers = None
                CatenateWords = None
                GenerateNumberParts = None
                GenerateWordParts = None
                PreserveOriginal = None
                ProtectedWords = None
                ProtectedWordsPath = None
                SplitOnCaseChange = None
                SplitOnNumerics = None
                StemEnglishPossessive = None
                TypeTable = None
                TypeTablePath = None
            }

        [<CustomOperation("catenateAll")>]
        member _.CatenateAll(state: Types.WordDelimiterTokenFilterBase, value: bool) =
            { state with CatenateAll = Some value }

        [<CustomOperation("catenateNumbers")>]
        member _.CatenateNumbers(state: Types.WordDelimiterTokenFilterBase, value: bool) =
            { state with CatenateNumbers = Some value }

        [<CustomOperation("catenateWords")>]
        member _.CatenateWords(state: Types.WordDelimiterTokenFilterBase, value: bool) =
            { state with CatenateWords = Some value }

        [<CustomOperation("generateNumberParts")>]
        member _.GenerateNumberParts(state: Types.WordDelimiterTokenFilterBase, value: bool) =
            { state with GenerateNumberParts = Some value }

        [<CustomOperation("generateWordParts")>]
        member _.GenerateWordParts(state: Types.WordDelimiterTokenFilterBase, value: bool) =
            { state with GenerateWordParts = Some value }

        [<CustomOperation("preserveOriginal")>]
        member _.PreserveOriginal(state: Types.WordDelimiterTokenFilterBase, value: Types.Stringified<bool>) =
            { state with PreserveOriginal = Some value }

        [<CustomOperation("protectedWords")>]
        member _.ProtectedWords(state: Types.WordDelimiterTokenFilterBase, value: string list) =
            { state with ProtectedWords = Some value }

        [<CustomOperation("protectedWordsPath")>]
        member _.ProtectedWordsPath(state: Types.WordDelimiterTokenFilterBase, value: string) =
            { state with ProtectedWordsPath = Some value }

        [<CustomOperation("splitOnCaseChange")>]
        member _.SplitOnCaseChange(state: Types.WordDelimiterTokenFilterBase, value: bool) =
            { state with SplitOnCaseChange = Some value }

        [<CustomOperation("splitOnNumerics")>]
        member _.SplitOnNumerics(state: Types.WordDelimiterTokenFilterBase, value: bool) =
            { state with SplitOnNumerics = Some value }

        [<CustomOperation("stemEnglishPossessive")>]
        member _.StemEnglishPossessive(state: Types.WordDelimiterTokenFilterBase, value: bool) =
            { state with StemEnglishPossessive = Some value }

        [<CustomOperation("typeTable")>]
        member _.TypeTable(state: Types.WordDelimiterTokenFilterBase, value: string list) =
            { state with TypeTable = Some value }

        [<CustomOperation("typeTablePath")>]
        member _.TypeTablePath(state: Types.WordDelimiterTokenFilterBase, value: string) =
            { state with TypeTablePath = Some value }

    let wordDelimiterTokenFilterBase = WordDelimiterTokenFilterBaseBuilder()


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module TypesAnalysisBuilders =

    type ArabicAnalyzerBuilder() =
        member _.Yield(_: unit) : ArabicAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: ArabicAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: ArabicAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: ArabicAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: ArabicAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let arabicAnalyzer = ArabicAnalyzerBuilder()

    type ArmenianAnalyzerBuilder() =
        member _.Yield(_: unit) : ArmenianAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: ArmenianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: ArmenianAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: ArmenianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: ArmenianAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let armenianAnalyzer = ArmenianAnalyzerBuilder()

    type BasqueAnalyzerBuilder() =
        member _.Yield(_: unit) : BasqueAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: BasqueAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: BasqueAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: BasqueAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: BasqueAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let basqueAnalyzer = BasqueAnalyzerBuilder()

    type BengaliAnalyzerBuilder() =
        member _.Yield(_: unit) : BengaliAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: BengaliAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: BengaliAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: BengaliAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: BengaliAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let bengaliAnalyzer = BengaliAnalyzerBuilder()

    type BrazilianAnalyzerBuilder() =
        member _.Yield(_: unit) : BrazilianAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: BrazilianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: BrazilianAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: BrazilianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

    let brazilianAnalyzer = BrazilianAnalyzerBuilder()

    type BulgarianAnalyzerBuilder() =
        member _.Yield(_: unit) : BulgarianAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: BulgarianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: BulgarianAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: BulgarianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: BulgarianAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let bulgarianAnalyzer = BulgarianAnalyzerBuilder()

    type CatalanAnalyzerBuilder() =
        member _.Yield(_: unit) : CatalanAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: CatalanAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: CatalanAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: CatalanAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: CatalanAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let catalanAnalyzer = CatalanAnalyzerBuilder()

    type ChineseAnalyzerBuilder() =
        member _.Yield(_: unit) : ChineseAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: ChineseAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: ChineseAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: ChineseAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

    let chineseAnalyzer = ChineseAnalyzerBuilder()

    type CjkAnalyzerBuilder() =
        member _.Yield(_: unit) : CjkAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: CjkAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: CjkAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: CjkAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

    let cjkAnalyzer = CjkAnalyzerBuilder()

    type CjkBigramTokenFilterBuilder() =
        member _.Yield(_: unit) : CjkBigramTokenFilter =
            {
                Type = Unchecked.defaultof<_>
                IgnoredScripts = None
                OutputUnigrams = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: CjkBigramTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("ignoredScripts")>]
        member _.IgnoredScripts(state: CjkBigramTokenFilter, value: CoreTypes.CjkBigramIgnoredScript list) =
            { state with IgnoredScripts = Some value }

        [<CustomOperation("outputUnigrams")>]
        member _.OutputUnigrams(state: CjkBigramTokenFilter, value: bool) =
            { state with OutputUnigrams = Some value }

    let cjkBigramTokenFilter = CjkBigramTokenFilterBuilder()

    type CommonGramsTokenFilterBuilder() =
        member _.Yield(_: unit) : CommonGramsTokenFilter =
            {
                Type = Unchecked.defaultof<_>
                CommonWords = None
                CommonWordsPath = None
                IgnoreCase = None
                QueryMode = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: CommonGramsTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("commonWords")>]
        member _.CommonWords(state: CommonGramsTokenFilter, value: string list) =
            { state with CommonWords = Some value }

        [<CustomOperation("commonWordsPath")>]
        member _.CommonWordsPath(state: CommonGramsTokenFilter, value: string) =
            { state with CommonWordsPath = Some value }

        [<CustomOperation("ignoreCase")>]
        member _.IgnoreCase(state: CommonGramsTokenFilter, value: bool) =
            { state with IgnoreCase = Some value }

        [<CustomOperation("queryMode")>]
        member _.QueryMode(state: CommonGramsTokenFilter, value: bool) =
            { state with QueryMode = Some value }

    let commonGramsTokenFilter = CommonGramsTokenFilterBuilder()

    type CompoundWordTokenFilterBaseBuilder() =
        member _.Yield(_: unit) : CompoundWordTokenFilterBase =
            {
                MaxSubwordSize = None
                MinSubwordSize = None
                MinWordSize = None
                OnlyLongestMatch = None
                WordList = None
                WordListPath = None
            }

        [<CustomOperation("maxSubwordSize")>]
        member _.MaxSubwordSize(state: CompoundWordTokenFilterBase, value: CoreTypes.Integer) =
            { state with MaxSubwordSize = Some value }

        [<CustomOperation("minSubwordSize")>]
        member _.MinSubwordSize(state: CompoundWordTokenFilterBase, value: CoreTypes.Integer) =
            { state with MinSubwordSize = Some value }

        [<CustomOperation("minWordSize")>]
        member _.MinWordSize(state: CompoundWordTokenFilterBase, value: CoreTypes.Integer) =
            { state with MinWordSize = Some value }

        [<CustomOperation("onlyLongestMatch")>]
        member _.OnlyLongestMatch(state: CompoundWordTokenFilterBase, value: bool) =
            { state with OnlyLongestMatch = Some value }

        [<CustomOperation("wordList")>]
        member _.WordList(state: CompoundWordTokenFilterBase, value: string list) =
            { state with WordList = Some value }

        [<CustomOperation("wordListPath")>]
        member _.WordListPath(state: CompoundWordTokenFilterBase, value: string) =
            { state with WordListPath = Some value }

    let compoundWordTokenFilterBase = CompoundWordTokenFilterBaseBuilder()

    type CustomAnalyzerBuilder() =
        member _.Yield(_: unit) : CustomAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                CharFilter = None
                Filter = None
                PositionIncrementGap = None
                PositionOffsetGap = None
                Tokenizer = Unchecked.defaultof<_>
            }

        [<CustomOperation("type'")>]
        member _.Type(state: CustomAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("charFilter")>]
        member _.CharFilter(state: CustomAnalyzer, value: System.Text.Json.JsonElement) =
            { state with CharFilter = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: CustomAnalyzer, value: System.Text.Json.JsonElement) =
            { state with Filter = Some value }

        [<CustomOperation("positionIncrementGap")>]
        member _.PositionIncrementGap(state: CustomAnalyzer, value: CoreTypes.Integer) =
            { state with PositionIncrementGap = Some value }

        [<CustomOperation("positionOffsetGap")>]
        member _.PositionOffsetGap(state: CustomAnalyzer, value: CoreTypes.Integer) =
            { state with PositionOffsetGap = Some value }

        [<CustomOperation("tokenizer")>]
        member _.Tokenizer(state: CustomAnalyzer, value: string) =
            { state with Tokenizer = value }

    let customAnalyzer = CustomAnalyzerBuilder()

    type CustomNormalizerBuilder() =
        member _.Yield(_: unit) : CustomNormalizer =
            {
                Type = Unchecked.defaultof<_>
                CharFilter = None
                Filter = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: CustomNormalizer, value: string) =
            { state with Type = value }

        [<CustomOperation("charFilter")>]
        member _.CharFilter(state: CustomNormalizer, value: string list) =
            { state with CharFilter = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: CustomNormalizer, value: string list) =
            { state with Filter = Some value }

    let customNormalizer = CustomNormalizerBuilder()

    type CzechAnalyzerBuilder() =
        member _.Yield(_: unit) : CzechAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: CzechAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: CzechAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: CzechAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: CzechAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let czechAnalyzer = CzechAnalyzerBuilder()

    type DanishAnalyzerBuilder() =
        member _.Yield(_: unit) : DanishAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: DanishAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: DanishAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: DanishAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

    let danishAnalyzer = DanishAnalyzerBuilder()

    type DelimitedPayloadTokenFilterBuilder() =
        member _.Yield(_: unit) : DelimitedPayloadTokenFilter =
            {
                Type = Unchecked.defaultof<_>
                Delimiter = None
                Encoding = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: DelimitedPayloadTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("delimiter")>]
        member _.Delimiter(state: DelimitedPayloadTokenFilter, value: string) =
            { state with Delimiter = Some value }

        [<CustomOperation("encoding")>]
        member _.Encoding(state: DelimitedPayloadTokenFilter, value: CoreTypes.DelimitedPayloadEncoding) =
            { state with Encoding = Some value }

    let delimitedPayloadTokenFilter = DelimitedPayloadTokenFilterBuilder()

    type DutchAnalyzerBuilder() =
        member _.Yield(_: unit) : DutchAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: DutchAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: DutchAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: DutchAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: DutchAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let dutchAnalyzer = DutchAnalyzerBuilder()

    type EdgeNGramTokenFilterBuilder() =
        member _.Yield(_: unit) : EdgeNGramTokenFilter =
            {
                Type = Unchecked.defaultof<_>
                MaxGram = None
                MinGram = None
                Side = None
                PreserveOriginal = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: EdgeNGramTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("maxGram")>]
        member _.MaxGram(state: EdgeNGramTokenFilter, value: CoreTypes.Integer) =
            { state with MaxGram = Some value }

        [<CustomOperation("minGram")>]
        member _.MinGram(state: EdgeNGramTokenFilter, value: CoreTypes.Integer) =
            { state with MinGram = Some value }

        [<CustomOperation("side")>]
        member _.Side(state: EdgeNGramTokenFilter, value: CoreTypes.EdgeNGramSide) =
            { state with Side = Some value }

        [<CustomOperation("preserveOriginal")>]
        member _.PreserveOriginal(state: EdgeNGramTokenFilter, value: CoreTypes.Stringified<bool>) =
            { state with PreserveOriginal = Some value }

    let edgeNGramTokenFilter = EdgeNGramTokenFilterBuilder()

    type EdgeNGramTokenizerBuilder() =
        member _.Yield(_: unit) : EdgeNGramTokenizer =
            {
                Type = Unchecked.defaultof<_>
                CustomTokenChars = None
                MaxGram = None
                MinGram = None
                TokenChars = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: EdgeNGramTokenizer, value: string) =
            { state with Type = value }

        [<CustomOperation("customTokenChars")>]
        member _.CustomTokenChars(state: EdgeNGramTokenizer, value: string) =
            { state with CustomTokenChars = Some value }

        [<CustomOperation("maxGram")>]
        member _.MaxGram(state: EdgeNGramTokenizer, value: CoreTypes.Integer) =
            { state with MaxGram = Some value }

        [<CustomOperation("minGram")>]
        member _.MinGram(state: EdgeNGramTokenizer, value: CoreTypes.Integer) =
            { state with MinGram = Some value }

        [<CustomOperation("tokenChars")>]
        member _.TokenChars(state: EdgeNGramTokenizer, value: CoreTypes.TokenChar list) =
            { state with TokenChars = Some value }

    let edgeNGramTokenizer = EdgeNGramTokenizerBuilder()

    type ElisionTokenFilterBuilder() =
        member _.Yield(_: unit) : ElisionTokenFilter =
            {
                Type = Unchecked.defaultof<_>
                Articles = None
                ArticlesPath = None
                ArticlesCase = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: ElisionTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("articles")>]
        member _.Articles(state: ElisionTokenFilter, value: string list) =
            { state with Articles = Some value }

        [<CustomOperation("articlesPath")>]
        member _.ArticlesPath(state: ElisionTokenFilter, value: string) =
            { state with ArticlesPath = Some value }

        [<CustomOperation("articlesCase")>]
        member _.ArticlesCase(state: ElisionTokenFilter, value: CoreTypes.Stringified<bool>) =
            { state with ArticlesCase = Some value }

    let elisionTokenFilter = ElisionTokenFilterBuilder()

    type EnglishAnalyzerBuilder() =
        member _.Yield(_: unit) : EnglishAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: EnglishAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: EnglishAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: EnglishAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: EnglishAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let englishAnalyzer = EnglishAnalyzerBuilder()

    type EstonianAnalyzerBuilder() =
        member _.Yield(_: unit) : EstonianAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: EstonianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: EstonianAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: EstonianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

    let estonianAnalyzer = EstonianAnalyzerBuilder()

    type FingerprintAnalyzerBuilder() =
        member _.Yield(_: unit) : FingerprintAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Version = None
                MaxOutputSize = None
                Separator = None
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: FingerprintAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("version")>]
        member _.Version(state: FingerprintAnalyzer, value: CoreTypes.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("maxOutputSize")>]
        member _.MaxOutputSize(state: FingerprintAnalyzer, value: CoreTypes.Integer) =
            { state with MaxOutputSize = Some value }

        [<CustomOperation("separator")>]
        member _.Separator(state: FingerprintAnalyzer, value: string) =
            { state with Separator = Some value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: FingerprintAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: FingerprintAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

    let fingerprintAnalyzer = FingerprintAnalyzerBuilder()

    type FingerprintTokenFilterBuilder() =
        member _.Yield(_: unit) : FingerprintTokenFilter =
            {
                Type = Unchecked.defaultof<_>
                MaxOutputSize = None
                Separator = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: FingerprintTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("maxOutputSize")>]
        member _.MaxOutputSize(state: FingerprintTokenFilter, value: CoreTypes.Integer) =
            { state with MaxOutputSize = Some value }

        [<CustomOperation("separator")>]
        member _.Separator(state: FingerprintTokenFilter, value: string) =
            { state with Separator = Some value }

    let fingerprintTokenFilter = FingerprintTokenFilterBuilder()

    type FinnishAnalyzerBuilder() =
        member _.Yield(_: unit) : FinnishAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: FinnishAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: FinnishAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: FinnishAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: FinnishAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let finnishAnalyzer = FinnishAnalyzerBuilder()

    type FrenchAnalyzerBuilder() =
        member _.Yield(_: unit) : FrenchAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: FrenchAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: FrenchAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: FrenchAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: FrenchAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let frenchAnalyzer = FrenchAnalyzerBuilder()

    type GalicianAnalyzerBuilder() =
        member _.Yield(_: unit) : GalicianAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: GalicianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: GalicianAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: GalicianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: GalicianAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let galicianAnalyzer = GalicianAnalyzerBuilder()

    type GermanAnalyzerBuilder() =
        member _.Yield(_: unit) : GermanAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: GermanAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: GermanAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: GermanAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: GermanAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let germanAnalyzer = GermanAnalyzerBuilder()

    type GreekAnalyzerBuilder() =
        member _.Yield(_: unit) : GreekAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: GreekAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: GreekAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: GreekAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

    let greekAnalyzer = GreekAnalyzerBuilder()

    type HindiAnalyzerBuilder() =
        member _.Yield(_: unit) : HindiAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: HindiAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: HindiAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: HindiAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: HindiAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let hindiAnalyzer = HindiAnalyzerBuilder()

    type HungarianAnalyzerBuilder() =
        member _.Yield(_: unit) : HungarianAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: HungarianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: HungarianAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: HungarianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: HungarianAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let hungarianAnalyzer = HungarianAnalyzerBuilder()

    type HunspellTokenFilterBuilder() =
        member _.Yield(_: unit) : HunspellTokenFilter =
            {
                Type = Unchecked.defaultof<_>
                Dedup = None
                Dictionary = None
                Locale = Unchecked.defaultof<_>
                LongestOnly = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: HunspellTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("dedup")>]
        member _.Dedup(state: HunspellTokenFilter, value: bool) =
            { state with Dedup = Some value }

        [<CustomOperation("dictionary")>]
        member _.Dictionary(state: HunspellTokenFilter, value: string) =
            { state with Dictionary = Some value }

        [<CustomOperation("locale")>]
        member _.Locale(state: HunspellTokenFilter, value: string) =
            { state with Locale = value }

        [<CustomOperation("longestOnly")>]
        member _.LongestOnly(state: HunspellTokenFilter, value: bool) =
            { state with LongestOnly = Some value }

    let hunspellTokenFilter = HunspellTokenFilterBuilder()

    type HyphenationDecompounderTokenFilterBuilder() =
        member _.Yield(_: unit) : HyphenationDecompounderTokenFilter =
            {
                Type = Unchecked.defaultof<_>
                HyphenationPatternsPath = Unchecked.defaultof<_>
                NoSubMatches = None
                NoOverlappingMatches = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: HyphenationDecompounderTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("hyphenationPatternsPath")>]
        member _.HyphenationPatternsPath(state: HyphenationDecompounderTokenFilter, value: string) =
            { state with HyphenationPatternsPath = value }

        [<CustomOperation("noSubMatches")>]
        member _.NoSubMatches(state: HyphenationDecompounderTokenFilter, value: bool) =
            { state with NoSubMatches = Some value }

        [<CustomOperation("noOverlappingMatches")>]
        member _.NoOverlappingMatches(state: HyphenationDecompounderTokenFilter, value: bool) =
            { state with NoOverlappingMatches = Some value }

    let hyphenationDecompounderTokenFilter = HyphenationDecompounderTokenFilterBuilder()

    type IcuCollationTokenFilterBuilder() =
        member _.Yield(_: unit) : IcuCollationTokenFilter =
            {
                Type = Unchecked.defaultof<_>
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
        member _.Type(state: IcuCollationTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("alternate")>]
        member _.Alternate(state: IcuCollationTokenFilter, value: CoreTypes.IcuCollationAlternate) =
            { state with Alternate = Some value }

        [<CustomOperation("caseFirst")>]
        member _.CaseFirst(state: IcuCollationTokenFilter, value: CoreTypes.IcuCollationCaseFirst) =
            { state with CaseFirst = Some value }

        [<CustomOperation("caseLevel")>]
        member _.CaseLevel(state: IcuCollationTokenFilter, value: bool) =
            { state with CaseLevel = Some value }

        [<CustomOperation("country")>]
        member _.Country(state: IcuCollationTokenFilter, value: string) =
            { state with Country = Some value }

        [<CustomOperation("decomposition")>]
        member _.Decomposition(state: IcuCollationTokenFilter, value: CoreTypes.IcuCollationDecomposition) =
            { state with Decomposition = Some value }

        [<CustomOperation("hiraganaQuaternaryMode")>]
        member _.HiraganaQuaternaryMode(state: IcuCollationTokenFilter, value: bool) =
            { state with HiraganaQuaternaryMode = Some value }

        [<CustomOperation("language")>]
        member _.Language(state: IcuCollationTokenFilter, value: string) =
            { state with Language = Some value }

        [<CustomOperation("numeric")>]
        member _.Numeric(state: IcuCollationTokenFilter, value: bool) =
            { state with Numeric = Some value }

        [<CustomOperation("rules")>]
        member _.Rules(state: IcuCollationTokenFilter, value: string) =
            { state with Rules = Some value }

        [<CustomOperation("strength")>]
        member _.Strength(state: IcuCollationTokenFilter, value: CoreTypes.IcuCollationStrength) =
            { state with Strength = Some value }

        [<CustomOperation("variableTop")>]
        member _.VariableTop(state: IcuCollationTokenFilter, value: string) =
            { state with VariableTop = Some value }

        [<CustomOperation("variant")>]
        member _.Variant(state: IcuCollationTokenFilter, value: string) =
            { state with Variant = Some value }

    let icuCollationTokenFilter = IcuCollationTokenFilterBuilder()

    type IcuNormalizationCharFilterBuilder() =
        member _.Yield(_: unit) : IcuNormalizationCharFilter =
            {
                Type = Unchecked.defaultof<_>
                Mode = None
                Name = None
                UnicodeSetFilter = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: IcuNormalizationCharFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("mode")>]
        member _.Mode(state: IcuNormalizationCharFilter, value: CoreTypes.IcuNormalizationMode) =
            { state with Mode = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: IcuNormalizationCharFilter, value: CoreTypes.IcuNormalizationType) =
            { state with Name = Some value }

        [<CustomOperation("unicodeSetFilter")>]
        member _.UnicodeSetFilter(state: IcuNormalizationCharFilter, value: string) =
            { state with UnicodeSetFilter = Some value }

    let icuNormalizationCharFilter = IcuNormalizationCharFilterBuilder()

    type IndonesianAnalyzerBuilder() =
        member _.Yield(_: unit) : IndonesianAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: IndonesianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: IndonesianAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: IndonesianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: IndonesianAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let indonesianAnalyzer = IndonesianAnalyzerBuilder()

    type IrishAnalyzerBuilder() =
        member _.Yield(_: unit) : IrishAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: IrishAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: IrishAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: IrishAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: IrishAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let irishAnalyzer = IrishAnalyzerBuilder()

    type ItalianAnalyzerBuilder() =
        member _.Yield(_: unit) : ItalianAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: ItalianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: ItalianAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: ItalianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: ItalianAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let italianAnalyzer = ItalianAnalyzerBuilder()

    type KeepWordsTokenFilterBuilder() =
        member _.Yield(_: unit) : KeepWordsTokenFilter =
            {
                Type = Unchecked.defaultof<_>
                KeepWords = None
                KeepWordsCase = None
                KeepWordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: KeepWordsTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("keepWords")>]
        member _.KeepWords(state: KeepWordsTokenFilter, value: string list) =
            { state with KeepWords = Some value }

        [<CustomOperation("keepWordsCase")>]
        member _.KeepWordsCase(state: KeepWordsTokenFilter, value: bool) =
            { state with KeepWordsCase = Some value }

        [<CustomOperation("keepWordsPath")>]
        member _.KeepWordsPath(state: KeepWordsTokenFilter, value: string) =
            { state with KeepWordsPath = Some value }

    let keepWordsTokenFilter = KeepWordsTokenFilterBuilder()

    type KeywordMarkerTokenFilterBuilder() =
        member _.Yield(_: unit) : KeywordMarkerTokenFilter =
            {
                Type = Unchecked.defaultof<_>
                IgnoreCase = None
                Keywords = None
                KeywordsPath = None
                KeywordsPattern = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: KeywordMarkerTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("ignoreCase")>]
        member _.IgnoreCase(state: KeywordMarkerTokenFilter, value: bool) =
            { state with IgnoreCase = Some value }

        [<CustomOperation("keywords")>]
        member _.Keywords(state: KeywordMarkerTokenFilter, value: System.Text.Json.JsonElement) =
            { state with Keywords = Some value }

        [<CustomOperation("keywordsPath")>]
        member _.KeywordsPath(state: KeywordMarkerTokenFilter, value: string) =
            { state with KeywordsPath = Some value }

        [<CustomOperation("keywordsPattern")>]
        member _.KeywordsPattern(state: KeywordMarkerTokenFilter, value: string) =
            { state with KeywordsPattern = Some value }

    let keywordMarkerTokenFilter = KeywordMarkerTokenFilterBuilder()

    type KuromojiAnalyzerBuilder() =
        member _.Yield(_: unit) : KuromojiAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Mode = None
                UserDictionary = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: KuromojiAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("mode")>]
        member _.Mode(state: KuromojiAnalyzer, value: CoreTypes.KuromojiTokenizationMode) =
            { state with Mode = Some value }

        [<CustomOperation("userDictionary")>]
        member _.UserDictionary(state: KuromojiAnalyzer, value: string) =
            { state with UserDictionary = Some value }

    let kuromojiAnalyzer = KuromojiAnalyzerBuilder()

    type KuromojiTokenizerBuilder() =
        member _.Yield(_: unit) : KuromojiTokenizer =
            {
                Type = Unchecked.defaultof<_>
                DiscardPunctuation = None
                Mode = Unchecked.defaultof<_>
                NbestCost = None
                NbestExamples = None
                UserDictionary = None
                UserDictionaryRules = None
                DiscardCompoundToken = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: KuromojiTokenizer, value: string) =
            { state with Type = value }

        [<CustomOperation("discardPunctuation")>]
        member _.DiscardPunctuation(state: KuromojiTokenizer, value: bool) =
            { state with DiscardPunctuation = Some value }

        [<CustomOperation("mode")>]
        member _.Mode(state: KuromojiTokenizer, value: CoreTypes.KuromojiTokenizationMode) =
            { state with Mode = value }

        [<CustomOperation("nbestCost")>]
        member _.NbestCost(state: KuromojiTokenizer, value: CoreTypes.Integer) =
            { state with NbestCost = Some value }

        [<CustomOperation("nbestExamples")>]
        member _.NbestExamples(state: KuromojiTokenizer, value: string) =
            { state with NbestExamples = Some value }

        [<CustomOperation("userDictionary")>]
        member _.UserDictionary(state: KuromojiTokenizer, value: string) =
            { state with UserDictionary = Some value }

        [<CustomOperation("userDictionaryRules")>]
        member _.UserDictionaryRules(state: KuromojiTokenizer, value: string list) =
            { state with UserDictionaryRules = Some value }

        [<CustomOperation("discardCompoundToken")>]
        member _.DiscardCompoundToken(state: KuromojiTokenizer, value: bool) =
            { state with DiscardCompoundToken = Some value }

    let kuromojiTokenizer = KuromojiTokenizerBuilder()

    type LatvianAnalyzerBuilder() =
        member _.Yield(_: unit) : LatvianAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: LatvianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: LatvianAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: LatvianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: LatvianAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let latvianAnalyzer = LatvianAnalyzerBuilder()

    type LengthTokenFilterBuilder() =
        member _.Yield(_: unit) : LengthTokenFilter =
            {
                Type = Unchecked.defaultof<_>
                Max = None
                Min = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: LengthTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("max")>]
        member _.Max(state: LengthTokenFilter, value: CoreTypes.Integer) =
            { state with Max = Some value }

        [<CustomOperation("min")>]
        member _.Min(state: LengthTokenFilter, value: CoreTypes.Integer) =
            { state with Min = Some value }

    let lengthTokenFilter = LengthTokenFilterBuilder()

    type LimitTokenCountTokenFilterBuilder() =
        member _.Yield(_: unit) : LimitTokenCountTokenFilter =
            {
                Type = Unchecked.defaultof<_>
                ConsumeAllTokens = None
                MaxTokenCount = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: LimitTokenCountTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("consumeAllTokens")>]
        member _.ConsumeAllTokens(state: LimitTokenCountTokenFilter, value: bool) =
            { state with ConsumeAllTokens = Some value }

        [<CustomOperation("maxTokenCount")>]
        member _.MaxTokenCount(state: LimitTokenCountTokenFilter, value: CoreTypes.Stringified<CoreTypes.Integer>) =
            { state with MaxTokenCount = Some value }

    let limitTokenCountTokenFilter = LimitTokenCountTokenFilterBuilder()

    type LithuanianAnalyzerBuilder() =
        member _.Yield(_: unit) : LithuanianAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: LithuanianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: LithuanianAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: LithuanianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: LithuanianAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let lithuanianAnalyzer = LithuanianAnalyzerBuilder()

    type MappingCharFilterBuilder() =
        member _.Yield(_: unit) : MappingCharFilter =
            {
                Type = Unchecked.defaultof<_>
                Mappings = None
                MappingsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: MappingCharFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("mappings")>]
        member _.Mappings(state: MappingCharFilter, value: string list) =
            { state with Mappings = Some value }

        [<CustomOperation("mappingsPath")>]
        member _.MappingsPath(state: MappingCharFilter, value: string) =
            { state with MappingsPath = Some value }

    let mappingCharFilter = MappingCharFilterBuilder()

    type MinHashTokenFilterBuilder() =
        member _.Yield(_: unit) : MinHashTokenFilter =
            {
                Type = Unchecked.defaultof<_>
                BucketCount = None
                HashCount = None
                HashSetSize = None
                WithRotation = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: MinHashTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("bucketCount")>]
        member _.BucketCount(state: MinHashTokenFilter, value: CoreTypes.Integer) =
            { state with BucketCount = Some value }

        [<CustomOperation("hashCount")>]
        member _.HashCount(state: MinHashTokenFilter, value: CoreTypes.Integer) =
            { state with HashCount = Some value }

        [<CustomOperation("hashSetSize")>]
        member _.HashSetSize(state: MinHashTokenFilter, value: CoreTypes.Integer) =
            { state with HashSetSize = Some value }

        [<CustomOperation("withRotation")>]
        member _.WithRotation(state: MinHashTokenFilter, value: bool) =
            { state with WithRotation = Some value }

    let minHashTokenFilter = MinHashTokenFilterBuilder()

    type NGramTokenFilterBuilder() =
        member _.Yield(_: unit) : NGramTokenFilter =
            {
                Type = Unchecked.defaultof<_>
                MaxGram = None
                MinGram = None
                PreserveOriginal = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: NGramTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("maxGram")>]
        member _.MaxGram(state: NGramTokenFilter, value: CoreTypes.Integer) =
            { state with MaxGram = Some value }

        [<CustomOperation("minGram")>]
        member _.MinGram(state: NGramTokenFilter, value: CoreTypes.Integer) =
            { state with MinGram = Some value }

        [<CustomOperation("preserveOriginal")>]
        member _.PreserveOriginal(state: NGramTokenFilter, value: CoreTypes.Stringified<bool>) =
            { state with PreserveOriginal = Some value }

    let nGramTokenFilter = NGramTokenFilterBuilder()

    type NGramTokenizerBuilder() =
        member _.Yield(_: unit) : NGramTokenizer =
            {
                Type = Unchecked.defaultof<_>
                CustomTokenChars = None
                MaxGram = None
                MinGram = None
                TokenChars = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: NGramTokenizer, value: string) =
            { state with Type = value }

        [<CustomOperation("customTokenChars")>]
        member _.CustomTokenChars(state: NGramTokenizer, value: string) =
            { state with CustomTokenChars = Some value }

        [<CustomOperation("maxGram")>]
        member _.MaxGram(state: NGramTokenizer, value: CoreTypes.Integer) =
            { state with MaxGram = Some value }

        [<CustomOperation("minGram")>]
        member _.MinGram(state: NGramTokenizer, value: CoreTypes.Integer) =
            { state with MinGram = Some value }

        [<CustomOperation("tokenChars")>]
        member _.TokenChars(state: NGramTokenizer, value: CoreTypes.TokenChar list) =
            { state with TokenChars = Some value }

    let nGramTokenizer = NGramTokenizerBuilder()

    type NoriAnalyzerBuilder() =
        member _.Yield(_: unit) : NoriAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Version = None
                DecompoundMode = None
                Stoptags = None
                UserDictionary = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: NoriAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("version")>]
        member _.Version(state: NoriAnalyzer, value: CoreTypes.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("decompoundMode")>]
        member _.DecompoundMode(state: NoriAnalyzer, value: CoreTypes.NoriDecompoundMode) =
            { state with DecompoundMode = Some value }

        [<CustomOperation("stoptags")>]
        member _.Stoptags(state: NoriAnalyzer, value: string list) =
            { state with Stoptags = Some value }

        [<CustomOperation("userDictionary")>]
        member _.UserDictionary(state: NoriAnalyzer, value: string) =
            { state with UserDictionary = Some value }

    let noriAnalyzer = NoriAnalyzerBuilder()

    type NoriTokenizerBuilder() =
        member _.Yield(_: unit) : NoriTokenizer =
            {
                Type = Unchecked.defaultof<_>
                DecompoundMode = None
                DiscardPunctuation = None
                UserDictionary = None
                UserDictionaryRules = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: NoriTokenizer, value: string) =
            { state with Type = value }

        [<CustomOperation("decompoundMode")>]
        member _.DecompoundMode(state: NoriTokenizer, value: CoreTypes.NoriDecompoundMode) =
            { state with DecompoundMode = Some value }

        [<CustomOperation("discardPunctuation")>]
        member _.DiscardPunctuation(state: NoriTokenizer, value: bool) =
            { state with DiscardPunctuation = Some value }

        [<CustomOperation("userDictionary")>]
        member _.UserDictionary(state: NoriTokenizer, value: string) =
            { state with UserDictionary = Some value }

        [<CustomOperation("userDictionaryRules")>]
        member _.UserDictionaryRules(state: NoriTokenizer, value: string list) =
            { state with UserDictionaryRules = Some value }

    let noriTokenizer = NoriTokenizerBuilder()

    type NorwegianAnalyzerBuilder() =
        member _.Yield(_: unit) : NorwegianAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: NorwegianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: NorwegianAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: NorwegianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: NorwegianAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let norwegianAnalyzer = NorwegianAnalyzerBuilder()

    type PathHierarchyTokenizerBuilder() =
        member _.Yield(_: unit) : PathHierarchyTokenizer =
            {
                Type = Unchecked.defaultof<_>
                BufferSize = None
                Delimiter = None
                Replacement = None
                Reverse = None
                Skip = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: PathHierarchyTokenizer, value: string) =
            { state with Type = value }

        [<CustomOperation("bufferSize")>]
        member _.BufferSize(state: PathHierarchyTokenizer, value: CoreTypes.Stringified<CoreTypes.Integer>) =
            { state with BufferSize = Some value }

        [<CustomOperation("delimiter")>]
        member _.Delimiter(state: PathHierarchyTokenizer, value: string) =
            { state with Delimiter = Some value }

        [<CustomOperation("replacement")>]
        member _.Replacement(state: PathHierarchyTokenizer, value: string) =
            { state with Replacement = Some value }

        [<CustomOperation("reverse")>]
        member _.Reverse(state: PathHierarchyTokenizer, value: CoreTypes.Stringified<bool>) =
            { state with Reverse = Some value }

        [<CustomOperation("skip")>]
        member _.Skip(state: PathHierarchyTokenizer, value: CoreTypes.Stringified<CoreTypes.Integer>) =
            { state with Skip = Some value }

    let pathHierarchyTokenizer = PathHierarchyTokenizerBuilder()

    type PatternAnalyzerBuilder() =
        member _.Yield(_: unit) : PatternAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Version = None
                Flags = None
                Lowercase = None
                Pattern = None
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: PatternAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("version")>]
        member _.Version(state: PatternAnalyzer, value: CoreTypes.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("flags")>]
        member _.Flags(state: PatternAnalyzer, value: string) =
            { state with Flags = Some value }

        [<CustomOperation("lowercase")>]
        member _.Lowercase(state: PatternAnalyzer, value: bool) =
            { state with Lowercase = Some value }

        [<CustomOperation("pattern")>]
        member _.Pattern(state: PatternAnalyzer, value: string) =
            { state with Pattern = Some value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: PatternAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: PatternAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

    let patternAnalyzer = PatternAnalyzerBuilder()

    type PatternReplaceCharFilterBuilder() =
        member _.Yield(_: unit) : PatternReplaceCharFilter =
            {
                Type = Unchecked.defaultof<_>
                Flags = None
                Pattern = Unchecked.defaultof<_>
                Replacement = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: PatternReplaceCharFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("flags")>]
        member _.Flags(state: PatternReplaceCharFilter, value: string) =
            { state with Flags = Some value }

        [<CustomOperation("pattern")>]
        member _.Pattern(state: PatternReplaceCharFilter, value: string) =
            { state with Pattern = value }

        [<CustomOperation("replacement")>]
        member _.Replacement(state: PatternReplaceCharFilter, value: string) =
            { state with Replacement = Some value }

    let patternReplaceCharFilter = PatternReplaceCharFilterBuilder()

    type PatternReplaceTokenFilterBuilder() =
        member _.Yield(_: unit) : PatternReplaceTokenFilter =
            {
                Type = Unchecked.defaultof<_>
                All = None
                Flags = None
                Pattern = Unchecked.defaultof<_>
                Replacement = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: PatternReplaceTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("all")>]
        member _.All(state: PatternReplaceTokenFilter, value: bool) =
            { state with All = Some value }

        [<CustomOperation("flags")>]
        member _.Flags(state: PatternReplaceTokenFilter, value: string) =
            { state with Flags = Some value }

        [<CustomOperation("pattern")>]
        member _.Pattern(state: PatternReplaceTokenFilter, value: string) =
            { state with Pattern = value }

        [<CustomOperation("replacement")>]
        member _.Replacement(state: PatternReplaceTokenFilter, value: string) =
            { state with Replacement = Some value }

    let patternReplaceTokenFilter = PatternReplaceTokenFilterBuilder()

    type PatternTokenizerBuilder() =
        member _.Yield(_: unit) : PatternTokenizer =
            {
                Type = Unchecked.defaultof<_>
                Flags = None
                Group = None
                Pattern = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: PatternTokenizer, value: string) =
            { state with Type = value }

        [<CustomOperation("flags")>]
        member _.Flags(state: PatternTokenizer, value: string) =
            { state with Flags = Some value }

        [<CustomOperation("group")>]
        member _.Group(state: PatternTokenizer, value: CoreTypes.Integer) =
            { state with Group = Some value }

        [<CustomOperation("pattern")>]
        member _.Pattern(state: PatternTokenizer, value: string) =
            { state with Pattern = Some value }

    let patternTokenizer = PatternTokenizerBuilder()

    type PersianAnalyzerBuilder() =
        member _.Yield(_: unit) : PersianAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: PersianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: PersianAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: PersianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

    let persianAnalyzer = PersianAnalyzerBuilder()

    type PhoneticTokenFilterBuilder() =
        member _.Yield(_: unit) : PhoneticTokenFilter =
            {
                Type = Unchecked.defaultof<_>
                Encoder = Unchecked.defaultof<_>
                Languageset = None
                MaxCodeLen = None
                NameType = None
                Replace = None
                RuleType = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: PhoneticTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("encoder")>]
        member _.Encoder(state: PhoneticTokenFilter, value: CoreTypes.PhoneticEncoder) =
            { state with Encoder = value }

        [<CustomOperation("languageset")>]
        member _.Languageset(state: PhoneticTokenFilter, value: System.Text.Json.JsonElement) =
            { state with Languageset = Some value }

        [<CustomOperation("maxCodeLen")>]
        member _.MaxCodeLen(state: PhoneticTokenFilter, value: CoreTypes.Integer) =
            { state with MaxCodeLen = Some value }

        [<CustomOperation("nameType")>]
        member _.NameType(state: PhoneticTokenFilter, value: CoreTypes.PhoneticNameType) =
            { state with NameType = Some value }

        [<CustomOperation("replace")>]
        member _.Replace(state: PhoneticTokenFilter, value: bool) =
            { state with Replace = Some value }

        [<CustomOperation("ruleType")>]
        member _.RuleType(state: PhoneticTokenFilter, value: CoreTypes.PhoneticRuleType) =
            { state with RuleType = Some value }

    let phoneticTokenFilter = PhoneticTokenFilterBuilder()

    type PortugueseAnalyzerBuilder() =
        member _.Yield(_: unit) : PortugueseAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: PortugueseAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: PortugueseAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: PortugueseAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: PortugueseAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let portugueseAnalyzer = PortugueseAnalyzerBuilder()

    type RomanianAnalyzerBuilder() =
        member _.Yield(_: unit) : RomanianAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: RomanianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: RomanianAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: RomanianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: RomanianAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let romanianAnalyzer = RomanianAnalyzerBuilder()

    type RussianAnalyzerBuilder() =
        member _.Yield(_: unit) : RussianAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: RussianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: RussianAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: RussianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: RussianAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let russianAnalyzer = RussianAnalyzerBuilder()

    type SerbianAnalyzerBuilder() =
        member _.Yield(_: unit) : SerbianAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: SerbianAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: SerbianAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: SerbianAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: SerbianAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let serbianAnalyzer = SerbianAnalyzerBuilder()

    type ShingleTokenFilterBuilder() =
        member _.Yield(_: unit) : ShingleTokenFilter =
            {
                Type = Unchecked.defaultof<_>
                FillerToken = None
                MaxShingleSize = None
                MinShingleSize = None
                OutputUnigrams = None
                OutputUnigramsIfNoShingles = None
                TokenSeparator = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: ShingleTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("fillerToken")>]
        member _.FillerToken(state: ShingleTokenFilter, value: string) =
            { state with FillerToken = Some value }

        [<CustomOperation("maxShingleSize")>]
        member _.MaxShingleSize(state: ShingleTokenFilter, value: CoreTypes.Stringified<CoreTypes.Integer>) =
            { state with MaxShingleSize = Some value }

        [<CustomOperation("minShingleSize")>]
        member _.MinShingleSize(state: ShingleTokenFilter, value: CoreTypes.Stringified<CoreTypes.Integer>) =
            { state with MinShingleSize = Some value }

        [<CustomOperation("outputUnigrams")>]
        member _.OutputUnigrams(state: ShingleTokenFilter, value: bool) =
            { state with OutputUnigrams = Some value }

        [<CustomOperation("outputUnigramsIfNoShingles")>]
        member _.OutputUnigramsIfNoShingles(state: ShingleTokenFilter, value: bool) =
            { state with OutputUnigramsIfNoShingles = Some value }

        [<CustomOperation("tokenSeparator")>]
        member _.TokenSeparator(state: ShingleTokenFilter, value: string) =
            { state with TokenSeparator = Some value }

    let shingleTokenFilter = ShingleTokenFilterBuilder()

    type SnowballAnalyzerBuilder() =
        member _.Yield(_: unit) : SnowballAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Version = None
                Language = Unchecked.defaultof<_>
                Stopwords = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: SnowballAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("version")>]
        member _.Version(state: SnowballAnalyzer, value: CoreTypes.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("language")>]
        member _.Language(state: SnowballAnalyzer, value: CoreTypes.SnowballLanguage) =
            { state with Language = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: SnowballAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

    let snowballAnalyzer = SnowballAnalyzerBuilder()

    type SoraniAnalyzerBuilder() =
        member _.Yield(_: unit) : SoraniAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: SoraniAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: SoraniAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: SoraniAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: SoraniAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let soraniAnalyzer = SoraniAnalyzerBuilder()

    type SpanishAnalyzerBuilder() =
        member _.Yield(_: unit) : SpanishAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: SpanishAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: SpanishAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: SpanishAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: SpanishAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let spanishAnalyzer = SpanishAnalyzerBuilder()

    type StandardAnalyzerBuilder() =
        member _.Yield(_: unit) : StandardAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                MaxTokenLength = None
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: StandardAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("maxTokenLength")>]
        member _.MaxTokenLength(state: StandardAnalyzer, value: CoreTypes.Integer) =
            { state with MaxTokenLength = Some value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: StandardAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: StandardAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

    let standardAnalyzer = StandardAnalyzerBuilder()

    type StemmerOverrideTokenFilterBuilder() =
        member _.Yield(_: unit) : StemmerOverrideTokenFilter =
            {
                Type = Unchecked.defaultof<_>
                Rules = None
                RulesPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: StemmerOverrideTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("rules")>]
        member _.Rules(state: StemmerOverrideTokenFilter, value: string list) =
            { state with Rules = Some value }

        [<CustomOperation("rulesPath")>]
        member _.RulesPath(state: StemmerOverrideTokenFilter, value: string) =
            { state with RulesPath = Some value }

    let stemmerOverrideTokenFilter = StemmerOverrideTokenFilterBuilder()

    type StopAnalyzerBuilder() =
        member _.Yield(_: unit) : StopAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Version = None
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: StopAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("version")>]
        member _.Version(state: StopAnalyzer, value: CoreTypes.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: StopAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: StopAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

    let stopAnalyzer = StopAnalyzerBuilder()

    type StopTokenFilterBuilder() =
        member _.Yield(_: unit) : StopTokenFilter =
            {
                Type = Unchecked.defaultof<_>
                IgnoreCase = None
                RemoveTrailing = None
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: StopTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("ignoreCase")>]
        member _.IgnoreCase(state: StopTokenFilter, value: bool) =
            { state with IgnoreCase = Some value }

        [<CustomOperation("removeTrailing")>]
        member _.RemoveTrailing(state: StopTokenFilter, value: bool) =
            { state with RemoveTrailing = Some value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: StopTokenFilter, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: StopTokenFilter, value: string) =
            { state with StopwordsPath = Some value }

    let stopTokenFilter = StopTokenFilterBuilder()

    type SwedishAnalyzerBuilder() =
        member _.Yield(_: unit) : SwedishAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: SwedishAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: SwedishAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: SwedishAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: SwedishAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let swedishAnalyzer = SwedishAnalyzerBuilder()

    type SynonymTokenFilterBaseBuilder() =
        member _.Yield(_: unit) : SynonymTokenFilterBase =
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
        member _.Expand(state: SynonymTokenFilterBase, value: bool) =
            { state with Expand = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: SynonymTokenFilterBase, value: CoreTypes.SynonymFormat) =
            { state with Format = Some value }

        [<CustomOperation("lenient")>]
        member _.Lenient(state: SynonymTokenFilterBase, value: bool) =
            { state with Lenient = Some value }

        [<CustomOperation("synonyms")>]
        member _.Synonyms(state: SynonymTokenFilterBase, value: string list) =
            { state with Synonyms = Some value }

        [<CustomOperation("synonymsPath")>]
        member _.SynonymsPath(state: SynonymTokenFilterBase, value: string) =
            { state with SynonymsPath = Some value }

        [<CustomOperation("synonymsSet")>]
        member _.SynonymsSet(state: SynonymTokenFilterBase, value: string) =
            { state with SynonymsSet = Some value }

        [<CustomOperation("tokenizer")>]
        member _.Tokenizer(state: SynonymTokenFilterBase, value: string) =
            { state with Tokenizer = Some value }

        [<CustomOperation("updateable")>]
        member _.Updateable(state: SynonymTokenFilterBase, value: bool) =
            { state with Updateable = Some value }

    let synonymTokenFilterBase = SynonymTokenFilterBaseBuilder()

    type ThaiAnalyzerBuilder() =
        member _.Yield(_: unit) : ThaiAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: ThaiAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: ThaiAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: ThaiAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

    let thaiAnalyzer = ThaiAnalyzerBuilder()

    type TurkishAnalyzerBuilder() =
        member _.Yield(_: unit) : TurkishAnalyzer =
            {
                Type = Unchecked.defaultof<_>
                Stopwords = None
                StopwordsPath = None
                StemExclusion = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: TurkishAnalyzer, value: string) =
            { state with Type = value }

        [<CustomOperation("stopwords")>]
        member _.Stopwords(state: TurkishAnalyzer, value: CoreTypes.StopWords) =
            { state with Stopwords = Some value }

        [<CustomOperation("stopwordsPath")>]
        member _.StopwordsPath(state: TurkishAnalyzer, value: string) =
            { state with StopwordsPath = Some value }

        [<CustomOperation("stemExclusion")>]
        member _.StemExclusion(state: TurkishAnalyzer, value: string list) =
            { state with StemExclusion = Some value }

    let turkishAnalyzer = TurkishAnalyzerBuilder()

    type WordDelimiterGraphTokenFilterBuilder() =
        member _.Yield(_: unit) : WordDelimiterGraphTokenFilter =
            {
                Type = Unchecked.defaultof<_>
                AdjustOffsets = None
                IgnoreKeywords = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: WordDelimiterGraphTokenFilter, value: string) =
            { state with Type = value }

        [<CustomOperation("adjustOffsets")>]
        member _.AdjustOffsets(state: WordDelimiterGraphTokenFilter, value: bool) =
            { state with AdjustOffsets = Some value }

        [<CustomOperation("ignoreKeywords")>]
        member _.IgnoreKeywords(state: WordDelimiterGraphTokenFilter, value: bool) =
            { state with IgnoreKeywords = Some value }

    let wordDelimiterGraphTokenFilter = WordDelimiterGraphTokenFilterBuilder()

    type WordDelimiterTokenFilterBaseBuilder() =
        member _.Yield(_: unit) : WordDelimiterTokenFilterBase =
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
        member _.CatenateAll(state: WordDelimiterTokenFilterBase, value: bool) =
            { state with CatenateAll = Some value }

        [<CustomOperation("catenateNumbers")>]
        member _.CatenateNumbers(state: WordDelimiterTokenFilterBase, value: bool) =
            { state with CatenateNumbers = Some value }

        [<CustomOperation("catenateWords")>]
        member _.CatenateWords(state: WordDelimiterTokenFilterBase, value: bool) =
            { state with CatenateWords = Some value }

        [<CustomOperation("generateNumberParts")>]
        member _.GenerateNumberParts(state: WordDelimiterTokenFilterBase, value: bool) =
            { state with GenerateNumberParts = Some value }

        [<CustomOperation("generateWordParts")>]
        member _.GenerateWordParts(state: WordDelimiterTokenFilterBase, value: bool) =
            { state with GenerateWordParts = Some value }

        [<CustomOperation("preserveOriginal")>]
        member _.PreserveOriginal(state: WordDelimiterTokenFilterBase, value: CoreTypes.Stringified<bool>) =
            { state with PreserveOriginal = Some value }

        [<CustomOperation("protectedWords")>]
        member _.ProtectedWords(state: WordDelimiterTokenFilterBase, value: string list) =
            { state with ProtectedWords = Some value }

        [<CustomOperation("protectedWordsPath")>]
        member _.ProtectedWordsPath(state: WordDelimiterTokenFilterBase, value: string) =
            { state with ProtectedWordsPath = Some value }

        [<CustomOperation("splitOnCaseChange")>]
        member _.SplitOnCaseChange(state: WordDelimiterTokenFilterBase, value: bool) =
            { state with SplitOnCaseChange = Some value }

        [<CustomOperation("splitOnNumerics")>]
        member _.SplitOnNumerics(state: WordDelimiterTokenFilterBase, value: bool) =
            { state with SplitOnNumerics = Some value }

        [<CustomOperation("stemEnglishPossessive")>]
        member _.StemEnglishPossessive(state: WordDelimiterTokenFilterBase, value: bool) =
            { state with StemEnglishPossessive = Some value }

        [<CustomOperation("typeTable")>]
        member _.TypeTable(state: WordDelimiterTokenFilterBase, value: string list) =
            { state with TypeTable = Some value }

        [<CustomOperation("typeTablePath")>]
        member _.TypeTablePath(state: WordDelimiterTokenFilterBase, value: string) =
            { state with TypeTablePath = Some value }

    let wordDelimiterTokenFilterBase = WordDelimiterTokenFilterBaseBuilder()


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module TypesAnalysis =

    type CustomAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("char_filter")>]
        CharFilter: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("position_increment_gap")>]
        PositionIncrementGap: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("position_offset_gap")>]
        PositionOffsetGap: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("tokenizer")>]
        Tokenizer: string
    }

    [<RequireQualifiedAccess>]
    type StopWordLanguage =
        | Arabic
        | Armenian
        | Basque
        | Bengali
        | Brazilian
        | Bulgarian
        | Catalan
        | Cjk
        | Czech
        | Danish
        | Dutch
        | English
        | Estonian
        | Finnish
        | French
        | Galician
        | German
        | Greek
        | Hindi
        | Hungarian
        | Indonesian
        | Irish
        | Italian
        | Latvian
        | Lithuanian
        | Norwegian
        | Persian
        | Portuguese
        | Romanian
        | Russian
        | Serbian
        | Sorani
        | Spanish
        | Swedish
        | Thai
        | Turkish
        | None

    /// Language value, such as _arabic_ or _thai_. Defaults to _english_.
    [<RequireQualifiedAccess>]
    type StopWords =
        | StopWordLanguage of TypesAnalysis.StopWordLanguage
        | Array of string list

    type FingerprintAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("max_output_size")>]
        MaxOutputSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("separator")>]
        Separator: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    type KeywordAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString option
    }

    [<RequireQualifiedAccess>]
    type NoriDecompoundMode =
        | Discard
        | None
        | Mixed

    type NoriAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("decompound_mode")>]
        DecompoundMode: TypesAnalysis.NoriDecompoundMode option
        [<System.Text.Json.Serialization.JsonPropertyName("stoptags")>]
        Stoptags: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("user_dictionary")>]
        UserDictionary: string option
    }

    type PatternAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("flags")>]
        Flags: string option
        [<System.Text.Json.Serialization.JsonPropertyName("lowercase")>]
        Lowercase: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("pattern")>]
        Pattern: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    type SimpleAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString option
    }

    type StandardAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("max_token_length")>]
        MaxTokenLength: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    type StopAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    type WhitespaceAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString option
    }

    [<RequireQualifiedAccess>]
    type IcuNormalizationType =
        | Nfc
        | Nfkc
        | NfkcCf

    [<RequireQualifiedAccess>]
    type IcuNormalizationMode =
        | Decompose
        | Compose

    type IcuAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("method")>]
        Method: TypesAnalysis.IcuNormalizationType
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: TypesAnalysis.IcuNormalizationMode
    }

    [<RequireQualifiedAccess>]
    type KuromojiTokenizationMode =
        | Normal
        | Search
        | Extended

    type KuromojiAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: TypesAnalysis.KuromojiTokenizationMode option
        [<System.Text.Json.Serialization.JsonPropertyName("user_dictionary")>]
        UserDictionary: string option
    }

    [<RequireQualifiedAccess>]
    type SnowballLanguage =
        | Arabic
        | Armenian
        | Basque
        | Catalan
        | Danish
        | Dutch
        | English
        | Estonian
        | Finnish
        | French
        | German
        | German2
        | Hungarian
        | Italian
        | Irish
        | Kp
        | Lithuanian
        | Lovins
        | Norwegian
        | Porter
        | Portuguese
        | Romanian
        | Russian
        | Serbian
        | Spanish
        | Swedish
        | Turkish

    type SnowballAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("language")>]
        Language: TypesAnalysis.SnowballLanguage
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
    }

    type ArabicAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type ArmenianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type BasqueAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type BengaliAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type BrazilianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    type BulgarianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type CatalanAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type ChineseAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    type CjkAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    type CzechAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type DanishAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    type DutchAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type EnglishAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type EstonianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    type FinnishAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type FrenchAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type GalicianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type GermanAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type GreekAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    type HindiAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type HungarianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type IndonesianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type IrishAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type ItalianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type LatvianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type LithuanianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type NorwegianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type PersianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    type PortugueseAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type RomanianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type RussianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type SerbianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type SoraniAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type SpanishAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type SwedishAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type TurkishAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type ThaiAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    [<RequireQualifiedAccess>]
    type Analyzer =
        | CustomAnalyzer of TypesAnalysis.CustomAnalyzer
        | FingerprintAnalyzer of TypesAnalysis.FingerprintAnalyzer
        | KeywordAnalyzer of TypesAnalysis.KeywordAnalyzer
        | NoriAnalyzer of TypesAnalysis.NoriAnalyzer
        | PatternAnalyzer of TypesAnalysis.PatternAnalyzer
        | SimpleAnalyzer of TypesAnalysis.SimpleAnalyzer
        | StandardAnalyzer of TypesAnalysis.StandardAnalyzer
        | StopAnalyzer of TypesAnalysis.StopAnalyzer
        | WhitespaceAnalyzer of TypesAnalysis.WhitespaceAnalyzer
        | IcuAnalyzer of TypesAnalysis.IcuAnalyzer
        | KuromojiAnalyzer of TypesAnalysis.KuromojiAnalyzer
        | SnowballAnalyzer of TypesAnalysis.SnowballAnalyzer
        | ArabicAnalyzer of TypesAnalysis.ArabicAnalyzer
        | ArmenianAnalyzer of TypesAnalysis.ArmenianAnalyzer
        | BasqueAnalyzer of TypesAnalysis.BasqueAnalyzer
        | BengaliAnalyzer of TypesAnalysis.BengaliAnalyzer
        | BrazilianAnalyzer of TypesAnalysis.BrazilianAnalyzer
        | BulgarianAnalyzer of TypesAnalysis.BulgarianAnalyzer
        | CatalanAnalyzer of TypesAnalysis.CatalanAnalyzer
        | ChineseAnalyzer of TypesAnalysis.ChineseAnalyzer
        | CjkAnalyzer of TypesAnalysis.CjkAnalyzer
        | CzechAnalyzer of TypesAnalysis.CzechAnalyzer
        | DanishAnalyzer of TypesAnalysis.DanishAnalyzer
        | DutchAnalyzer of TypesAnalysis.DutchAnalyzer
        | EnglishAnalyzer of TypesAnalysis.EnglishAnalyzer
        | EstonianAnalyzer of TypesAnalysis.EstonianAnalyzer
        | FinnishAnalyzer of TypesAnalysis.FinnishAnalyzer
        | FrenchAnalyzer of TypesAnalysis.FrenchAnalyzer
        | GalicianAnalyzer of TypesAnalysis.GalicianAnalyzer
        | GermanAnalyzer of TypesAnalysis.GermanAnalyzer
        | GreekAnalyzer of TypesAnalysis.GreekAnalyzer
        | HindiAnalyzer of TypesAnalysis.HindiAnalyzer
        | HungarianAnalyzer of TypesAnalysis.HungarianAnalyzer
        | IndonesianAnalyzer of TypesAnalysis.IndonesianAnalyzer
        | IrishAnalyzer of TypesAnalysis.IrishAnalyzer
        | ItalianAnalyzer of TypesAnalysis.ItalianAnalyzer
        | LatvianAnalyzer of TypesAnalysis.LatvianAnalyzer
        | LithuanianAnalyzer of TypesAnalysis.LithuanianAnalyzer
        | NorwegianAnalyzer of TypesAnalysis.NorwegianAnalyzer
        | PersianAnalyzer of TypesAnalysis.PersianAnalyzer
        | PortugueseAnalyzer of TypesAnalysis.PortugueseAnalyzer
        | RomanianAnalyzer of TypesAnalysis.RomanianAnalyzer
        | RussianAnalyzer of TypesAnalysis.RussianAnalyzer
        | SerbianAnalyzer of TypesAnalysis.SerbianAnalyzer
        | SoraniAnalyzer of TypesAnalysis.SoraniAnalyzer
        | SpanishAnalyzer of TypesAnalysis.SpanishAnalyzer
        | SwedishAnalyzer of TypesAnalysis.SwedishAnalyzer
        | TurkishAnalyzer of TypesAnalysis.TurkishAnalyzer
        | ThaiAnalyzer of TypesAnalysis.ThaiAnalyzer
        | Unknown of name: string * System.Text.Json.JsonElement

    type TokenFilterBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString option
    }

    type ApostropheTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type ArabicNormalizationTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type ArabicStemTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type AsciiFoldingTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("preserve_original")>]
        PreserveOriginal: SpecUtils.Stringified<bool> option
    }

    type BengaliNormalizationTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type BrazilianStemTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type CharFilterBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString option
    }

    type HtmlStripCharFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("escaped_tags")>]
        EscapedTags: string list option
    }

    type MappingCharFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("mappings_path")>]
        MappingsPath: string option
    }

    type PatternReplaceCharFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("flags")>]
        Flags: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pattern")>]
        Pattern: string
        [<System.Text.Json.Serialization.JsonPropertyName("replacement")>]
        Replacement: string option
    }

    type IcuNormalizationCharFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: TypesAnalysis.IcuNormalizationMode option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: TypesAnalysis.IcuNormalizationType option
        [<System.Text.Json.Serialization.JsonPropertyName("unicode_set_filter")>]
        UnicodeSetFilter: string option
    }

    type KuromojiIterationMarkCharFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("normalize_kana")>]
        NormalizeKana: bool
        [<System.Text.Json.Serialization.JsonPropertyName("normalize_kanji")>]
        NormalizeKanji: bool
    }

    [<RequireQualifiedAccess>]
    type CharFilterDefinition =
        | HtmlStripCharFilter of TypesAnalysis.HtmlStripCharFilter
        | MappingCharFilter of TypesAnalysis.MappingCharFilter
        | PatternReplaceCharFilter of TypesAnalysis.PatternReplaceCharFilter
        | IcuNormalizationCharFilter of TypesAnalysis.IcuNormalizationCharFilter
        | KuromojiIterationMarkCharFilter of TypesAnalysis.KuromojiIterationMarkCharFilter
        | Unknown of name: string * System.Text.Json.JsonElement

    [<RequireQualifiedAccess>]
    type CharFilter =
        | String of string
        | CharFilterDefinition of TypesAnalysis.CharFilterDefinition

    type TokenizerBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString option
    }

    type CharGroupTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("tokenize_on_chars")>]
        TokenizeOnChars: string list
        [<System.Text.Json.Serialization.JsonPropertyName("max_token_length")>]
        MaxTokenLength: Types.Integer option
    }

    [<RequireQualifiedAccess>]
    type CjkBigramIgnoredScript =
        | Han
        | Hangul
        | Hiragana
        | Katakana

    type CjkBigramTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("ignored_scripts")>]
        IgnoredScripts: TypesAnalysis.CjkBigramIgnoredScript list option
        [<System.Text.Json.Serialization.JsonPropertyName("output_unigrams")>]
        OutputUnigrams: bool option
    }

    type CjkWidthTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type ClassicTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type ClassicTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("max_token_length")>]
        MaxTokenLength: Types.Integer option
    }

    type CommonGramsTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("common_words")>]
        CommonWords: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("common_words_path")>]
        CommonWordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_case")>]
        IgnoreCase: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("query_mode")>]
        QueryMode: bool option
    }

    type CompoundWordTokenFilterBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_subword_size")>]
        MaxSubwordSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_subword_size")>]
        MinSubwordSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_word_size")>]
        MinWordSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("only_longest_match")>]
        OnlyLongestMatch: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("word_list")>]
        WordList: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("word_list_path")>]
        WordListPath: string option
    }

    type ConditionTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: string list
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script
    }

    type CustomNormalizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("char_filter")>]
        CharFilter: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: string list option
    }

    type CzechStemTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type DecimalDigitTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    [<RequireQualifiedAccess>]
    type DelimitedPayloadEncoding =
        | Int
        | Float
        | Identity

    type DelimitedPayloadTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("delimiter")>]
        Delimiter: string option
        [<System.Text.Json.Serialization.JsonPropertyName("encoding")>]
        Encoding: TypesAnalysis.DelimitedPayloadEncoding option
    }

    type DictionaryDecompounderTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type DutchStemTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    [<RequireQualifiedAccess>]
    type EdgeNGramSide =
        | Front
        | Back

    type EdgeNGramTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("max_gram")>]
        MaxGram: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_gram")>]
        MinGram: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("side")>]
        Side: TypesAnalysis.EdgeNGramSide option
        [<System.Text.Json.Serialization.JsonPropertyName("preserve_original")>]
        PreserveOriginal: SpecUtils.Stringified<bool> option
    }

    [<RequireQualifiedAccess>]
    type TokenChar =
        | Letter
        | Digit
        | Whitespace
        | Punctuation
        | Symbol
        | Custom

    type EdgeNGramTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("custom_token_chars")>]
        CustomTokenChars: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_gram")>]
        MaxGram: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_gram")>]
        MinGram: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("token_chars")>]
        TokenChars: TypesAnalysis.TokenChar list option
    }

    type ElisionTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("articles")>]
        Articles: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("articles_path")>]
        ArticlesPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("articles_case")>]
        ArticlesCase: SpecUtils.Stringified<bool> option
    }

    type FingerprintTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("max_output_size")>]
        MaxOutputSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("separator")>]
        Separator: string option
    }

    type FlattenGraphTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type FrenchStemTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type GermanNormalizationTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type GermanStemTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type HindiNormalizationTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type HunspellTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("dedup")>]
        Dedup: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("dictionary")>]
        Dictionary: string option
        [<System.Text.Json.Serialization.JsonPropertyName("locale")>]
        Locale: string
        [<System.Text.Json.Serialization.JsonPropertyName("longest_only")>]
        LongestOnly: bool option
    }

    type HyphenationDecompounderTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("hyphenation_patterns_path")>]
        HyphenationPatternsPath: string
        [<System.Text.Json.Serialization.JsonPropertyName("no_sub_matches")>]
        NoSubMatches: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("no_overlapping_matches")>]
        NoOverlappingMatches: bool option
    }

    [<RequireQualifiedAccess>]
    type IcuCollationAlternate =
        | Shifted
        | NonIgnorable

    [<RequireQualifiedAccess>]
    type IcuCollationCaseFirst =
        | Lower
        | Upper

    [<RequireQualifiedAccess>]
    type IcuCollationDecomposition =
        | No
        | Identical

    [<RequireQualifiedAccess>]
    type IcuCollationStrength =
        | Primary
        | Secondary
        | Tertiary
        | Quaternary
        | Identical

    type IcuCollationTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("alternate")>]
        Alternate: TypesAnalysis.IcuCollationAlternate option
        [<System.Text.Json.Serialization.JsonPropertyName("caseFirst")>]
        CaseFirst: TypesAnalysis.IcuCollationCaseFirst option
        [<System.Text.Json.Serialization.JsonPropertyName("caseLevel")>]
        CaseLevel: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("country")>]
        Country: string option
        [<System.Text.Json.Serialization.JsonPropertyName("decomposition")>]
        Decomposition: TypesAnalysis.IcuCollationDecomposition option
        [<System.Text.Json.Serialization.JsonPropertyName("hiraganaQuaternaryMode")>]
        HiraganaQuaternaryMode: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("language")>]
        Language: string option
        [<System.Text.Json.Serialization.JsonPropertyName("numeric")>]
        Numeric: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("rules")>]
        Rules: string option
        [<System.Text.Json.Serialization.JsonPropertyName("strength")>]
        Strength: TypesAnalysis.IcuCollationStrength option
        [<System.Text.Json.Serialization.JsonPropertyName("variableTop")>]
        VariableTop: string option
        [<System.Text.Json.Serialization.JsonPropertyName("variant")>]
        Variant: string option
    }

    type IcuFoldingTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("unicode_set_filter")>]
        UnicodeSetFilter: string
    }

    type IcuNormalizationTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: TypesAnalysis.IcuNormalizationType
    }

    type IcuTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("rule_files")>]
        RuleFiles: string
    }

    [<RequireQualifiedAccess>]
    type IcuTransformDirection =
        | Forward
        | Reverse

    type IcuTransformTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("dir")>]
        Dir: TypesAnalysis.IcuTransformDirection option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: string
    }

    type IndicNormalizationTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type JaStopTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
    }

    type KStemTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    [<RequireQualifiedAccess>]
    type KeepTypesMode =
        | Include
        | Exclude

    type KeepTypesTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: TypesAnalysis.KeepTypesMode option
        [<System.Text.Json.Serialization.JsonPropertyName("types")>]
        Types: string list
    }

    type KeepWordsTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("keep_words")>]
        KeepWords: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("keep_words_case")>]
        KeepWordsCase: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("keep_words_path")>]
        KeepWordsPath: string option
    }

    type KeywordMarkerTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_case")>]
        IgnoreCase: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("keywords")>]
        Keywords: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("keywords_path")>]
        KeywordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("keywords_pattern")>]
        KeywordsPattern: string option
    }

    type KeywordRepeatTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type KeywordTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("buffer_size")>]
        BufferSize: Types.Integer option
    }

    type KuromojiPartOfSpeechTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stoptags")>]
        Stoptags: string list
    }

    type KuromojiReadingFormTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("use_romaji")>]
        UseRomaji: bool
    }

    type KuromojiStemmerTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_length")>]
        MinimumLength: Types.Integer
    }

    type KuromojiTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("discard_punctuation")>]
        DiscardPunctuation: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: TypesAnalysis.KuromojiTokenizationMode
        [<System.Text.Json.Serialization.JsonPropertyName("nbest_cost")>]
        NbestCost: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("nbest_examples")>]
        NbestExamples: string option
        [<System.Text.Json.Serialization.JsonPropertyName("user_dictionary")>]
        UserDictionary: string option
        [<System.Text.Json.Serialization.JsonPropertyName("user_dictionary_rules")>]
        UserDictionaryRules: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("discard_compound_token")>]
        DiscardCompoundToken: bool option
    }

    type LengthTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min")>]
        Min: Types.Integer option
    }

    type LetterTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type LimitTokenCountTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("consume_all_tokens")>]
        ConsumeAllTokens: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("max_token_count")>]
        MaxTokenCount: SpecUtils.Stringified<Types.Integer> option
    }

    type LowercaseNormalizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    [<RequireQualifiedAccess>]
    type LowercaseTokenFilterLanguages =
        | Greek
        | Irish
        | Turkish

    type LowercaseTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("language")>]
        Language: TypesAnalysis.LowercaseTokenFilterLanguages option
    }

    type LowercaseTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type MinHashTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_count")>]
        BucketCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("hash_count")>]
        HashCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("hash_set_size")>]
        HashSetSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("with_rotation")>]
        WithRotation: bool option
    }

    type MultiplexerTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("filters")>]
        Filters: string list
        [<System.Text.Json.Serialization.JsonPropertyName("preserve_original")>]
        PreserveOriginal: SpecUtils.Stringified<bool> option
    }

    type NGramTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("max_gram")>]
        MaxGram: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_gram")>]
        MinGram: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("preserve_original")>]
        PreserveOriginal: SpecUtils.Stringified<bool> option
    }

    type NGramTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("custom_token_chars")>]
        CustomTokenChars: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_gram")>]
        MaxGram: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_gram")>]
        MinGram: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("token_chars")>]
        TokenChars: TypesAnalysis.TokenChar list option
    }

    type NoriPartOfSpeechTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stoptags")>]
        Stoptags: string list option
    }

    type NoriTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("decompound_mode")>]
        DecompoundMode: TypesAnalysis.NoriDecompoundMode option
        [<System.Text.Json.Serialization.JsonPropertyName("discard_punctuation")>]
        DiscardPunctuation: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("user_dictionary")>]
        UserDictionary: string option
        [<System.Text.Json.Serialization.JsonPropertyName("user_dictionary_rules")>]
        UserDictionaryRules: string list option
    }

    [<RequireQualifiedAccess>]
    type Normalizer =
        | LowercaseNormalizer of TypesAnalysis.LowercaseNormalizer
        | CustomNormalizer of TypesAnalysis.CustomNormalizer

    type PathHierarchyTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("buffer_size")>]
        BufferSize: SpecUtils.Stringified<Types.Integer> option
        [<System.Text.Json.Serialization.JsonPropertyName("delimiter")>]
        Delimiter: string option
        [<System.Text.Json.Serialization.JsonPropertyName("replacement")>]
        Replacement: string option
        [<System.Text.Json.Serialization.JsonPropertyName("reverse")>]
        Reverse: SpecUtils.Stringified<bool> option
        [<System.Text.Json.Serialization.JsonPropertyName("skip")>]
        Skip: SpecUtils.Stringified<Types.Integer> option
    }

    type PatternCaptureTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("patterns")>]
        Patterns: string list
        [<System.Text.Json.Serialization.JsonPropertyName("preserve_original")>]
        PreserveOriginal: SpecUtils.Stringified<bool> option
    }

    type PatternReplaceTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("all")>]
        All: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("flags")>]
        Flags: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pattern")>]
        Pattern: string
        [<System.Text.Json.Serialization.JsonPropertyName("replacement")>]
        Replacement: string option
    }

    type PatternTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("flags")>]
        Flags: string option
        [<System.Text.Json.Serialization.JsonPropertyName("group")>]
        Group: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("pattern")>]
        Pattern: string option
    }

    type PersianNormalizationTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type PersianStemTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    [<RequireQualifiedAccess>]
    type PhoneticEncoder =
        | Metaphone
        | DoubleMetaphone
        | Soundex
        | RefinedSoundex
        | Caverphone1
        | Caverphone2
        | Cologne
        | Nysiis
        | Koelnerphonetik
        | Haasephonetik
        | BeiderMorse
        | DaitchMokotoff

    [<RequireQualifiedAccess>]
    type PhoneticLanguage =
        | Any
        | Common
        | Cyrillic
        | English
        | French
        | German
        | Hebrew
        | Hungarian
        | Polish
        | Romanian
        | Russian
        | Spanish

    [<RequireQualifiedAccess>]
    type PhoneticNameType =
        | Generic
        | Ashkenazi
        | Sephardic

    [<RequireQualifiedAccess>]
    type PhoneticRuleType =
        | Approx
        | Exact

    type PhoneticTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("encoder")>]
        Encoder: TypesAnalysis.PhoneticEncoder
        [<System.Text.Json.Serialization.JsonPropertyName("languageset")>]
        Languageset: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("max_code_len")>]
        MaxCodeLen: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("name_type")>]
        NameType: TypesAnalysis.PhoneticNameType option
        [<System.Text.Json.Serialization.JsonPropertyName("replace")>]
        Replace: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("rule_type")>]
        RuleType: TypesAnalysis.PhoneticRuleType option
    }

    type PorterStemTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type PredicateTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script
    }

    type RemoveDuplicatesTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type ReverseTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type RussianStemTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type ScandinavianFoldingTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type ScandinavianNormalizationTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type SerbianNormalizationTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type ShingleTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("filler_token")>]
        FillerToken: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_shingle_size")>]
        MaxShingleSize: SpecUtils.Stringified<Types.Integer> option
        [<System.Text.Json.Serialization.JsonPropertyName("min_shingle_size")>]
        MinShingleSize: SpecUtils.Stringified<Types.Integer> option
        [<System.Text.Json.Serialization.JsonPropertyName("output_unigrams")>]
        OutputUnigrams: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("output_unigrams_if_no_shingles")>]
        OutputUnigramsIfNoShingles: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("token_separator")>]
        TokenSeparator: string option
    }

    type SimplePatternSplitTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("pattern")>]
        Pattern: string option
    }

    type SimplePatternTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("pattern")>]
        Pattern: string option
    }

    type SnowballTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("language")>]
        Language: TypesAnalysis.SnowballLanguage option
    }

    type SoraniNormalizationTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type StandardTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("max_token_length")>]
        MaxTokenLength: Types.Integer option
    }

    type StemmerOverrideTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("rules")>]
        Rules: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("rules_path")>]
        RulesPath: string option
    }

    type StemmerTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("language")>]
        Language: string option
    }

    type StopTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_case")>]
        IgnoreCase: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("remove_trailing")>]
        RemoveTrailing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    [<RequireQualifiedAccess>]
    type SynonymFormat =
        | Solr
        | Wordnet

    type SynonymTokenFilterBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("expand")>]
        Expand: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: TypesAnalysis.SynonymFormat option
        [<System.Text.Json.Serialization.JsonPropertyName("lenient")>]
        Lenient: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("synonyms")>]
        Synonyms: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("synonyms_path")>]
        SynonymsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("synonyms_set")>]
        SynonymsSet: string option
        [<System.Text.Json.Serialization.JsonPropertyName("tokenizer")>]
        Tokenizer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("updateable")>]
        Updateable: bool option
    }

    type SynonymGraphTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type SynonymTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type ThaiTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type TrimTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type TruncateTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("length")>]
        Length: Types.Integer option
    }

    type UniqueTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("only_on_same_position")>]
        OnlyOnSamePosition: bool option
    }

    type UppercaseTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type WordDelimiterTokenFilterBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("catenate_all")>]
        CatenateAll: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("catenate_numbers")>]
        CatenateNumbers: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("catenate_words")>]
        CatenateWords: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("generate_number_parts")>]
        GenerateNumberParts: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("generate_word_parts")>]
        GenerateWordParts: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("preserve_original")>]
        PreserveOriginal: SpecUtils.Stringified<bool> option
        [<System.Text.Json.Serialization.JsonPropertyName("protected_words")>]
        ProtectedWords: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("protected_words_path")>]
        ProtectedWordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("split_on_case_change")>]
        SplitOnCaseChange: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("split_on_numerics")>]
        SplitOnNumerics: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_english_possessive")>]
        StemEnglishPossessive: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("type_table")>]
        TypeTable: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("type_table_path")>]
        TypeTablePath: string option
    }

    type WordDelimiterGraphTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("adjust_offsets")>]
        AdjustOffsets: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_keywords")>]
        IgnoreKeywords: bool option
    }

    type WordDelimiterTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    [<RequireQualifiedAccess>]
    type TokenFilterDefinition =
        | ApostropheTokenFilter of TypesAnalysis.ApostropheTokenFilter
        | ArabicStemTokenFilter of TypesAnalysis.ArabicStemTokenFilter
        | ArabicNormalizationTokenFilter of TypesAnalysis.ArabicNormalizationTokenFilter
        | AsciiFoldingTokenFilter of TypesAnalysis.AsciiFoldingTokenFilter
        | BengaliNormalizationTokenFilter of TypesAnalysis.BengaliNormalizationTokenFilter
        | BrazilianStemTokenFilter of TypesAnalysis.BrazilianStemTokenFilter
        | CjkBigramTokenFilter of TypesAnalysis.CjkBigramTokenFilter
        | CjkWidthTokenFilter of TypesAnalysis.CjkWidthTokenFilter
        | ClassicTokenFilter of TypesAnalysis.ClassicTokenFilter
        | CommonGramsTokenFilter of TypesAnalysis.CommonGramsTokenFilter
        | ConditionTokenFilter of TypesAnalysis.ConditionTokenFilter
        | CzechStemTokenFilter of TypesAnalysis.CzechStemTokenFilter
        | DecimalDigitTokenFilter of TypesAnalysis.DecimalDigitTokenFilter
        | DelimitedPayloadTokenFilter of TypesAnalysis.DelimitedPayloadTokenFilter
        | DutchStemTokenFilter of TypesAnalysis.DutchStemTokenFilter
        | EdgeNGramTokenFilter of TypesAnalysis.EdgeNGramTokenFilter
        | ElisionTokenFilter of TypesAnalysis.ElisionTokenFilter
        | FingerprintTokenFilter of TypesAnalysis.FingerprintTokenFilter
        | FlattenGraphTokenFilter of TypesAnalysis.FlattenGraphTokenFilter
        | FrenchStemTokenFilter of TypesAnalysis.FrenchStemTokenFilter
        | GermanNormalizationTokenFilter of TypesAnalysis.GermanNormalizationTokenFilter
        | GermanStemTokenFilter of TypesAnalysis.GermanStemTokenFilter
        | HindiNormalizationTokenFilter of TypesAnalysis.HindiNormalizationTokenFilter
        | HunspellTokenFilter of TypesAnalysis.HunspellTokenFilter
        | HyphenationDecompounderTokenFilter of TypesAnalysis.HyphenationDecompounderTokenFilter
        | IndicNormalizationTokenFilter of TypesAnalysis.IndicNormalizationTokenFilter
        | KeepTypesTokenFilter of TypesAnalysis.KeepTypesTokenFilter
        | KeepWordsTokenFilter of TypesAnalysis.KeepWordsTokenFilter
        | KeywordMarkerTokenFilter of TypesAnalysis.KeywordMarkerTokenFilter
        | KeywordRepeatTokenFilter of TypesAnalysis.KeywordRepeatTokenFilter
        | KStemTokenFilter of TypesAnalysis.KStemTokenFilter
        | LengthTokenFilter of TypesAnalysis.LengthTokenFilter
        | LimitTokenCountTokenFilter of TypesAnalysis.LimitTokenCountTokenFilter
        | LowercaseTokenFilter of TypesAnalysis.LowercaseTokenFilter
        | MinHashTokenFilter of TypesAnalysis.MinHashTokenFilter
        | MultiplexerTokenFilter of TypesAnalysis.MultiplexerTokenFilter
        | NGramTokenFilter of TypesAnalysis.NGramTokenFilter
        | NoriPartOfSpeechTokenFilter of TypesAnalysis.NoriPartOfSpeechTokenFilter
        | PatternCaptureTokenFilter of TypesAnalysis.PatternCaptureTokenFilter
        | PatternReplaceTokenFilter of TypesAnalysis.PatternReplaceTokenFilter
        | PersianNormalizationTokenFilter of TypesAnalysis.PersianNormalizationTokenFilter
        | PersianStemTokenFilter of TypesAnalysis.PersianStemTokenFilter
        | PorterStemTokenFilter of TypesAnalysis.PorterStemTokenFilter
        | PredicateTokenFilter of TypesAnalysis.PredicateTokenFilter
        | RemoveDuplicatesTokenFilter of TypesAnalysis.RemoveDuplicatesTokenFilter
        | ReverseTokenFilter of TypesAnalysis.ReverseTokenFilter
        | RussianStemTokenFilter of TypesAnalysis.RussianStemTokenFilter
        | ScandinavianFoldingTokenFilter of TypesAnalysis.ScandinavianFoldingTokenFilter
        | ScandinavianNormalizationTokenFilter of TypesAnalysis.ScandinavianNormalizationTokenFilter
        | SerbianNormalizationTokenFilter of TypesAnalysis.SerbianNormalizationTokenFilter
        | ShingleTokenFilter of TypesAnalysis.ShingleTokenFilter
        | SnowballTokenFilter of TypesAnalysis.SnowballTokenFilter
        | SoraniNormalizationTokenFilter of TypesAnalysis.SoraniNormalizationTokenFilter
        | StemmerOverrideTokenFilter of TypesAnalysis.StemmerOverrideTokenFilter
        | StemmerTokenFilter of TypesAnalysis.StemmerTokenFilter
        | StopTokenFilter of TypesAnalysis.StopTokenFilter
        | SynonymGraphTokenFilter of TypesAnalysis.SynonymGraphTokenFilter
        | SynonymTokenFilter of TypesAnalysis.SynonymTokenFilter
        | TrimTokenFilter of TypesAnalysis.TrimTokenFilter
        | TruncateTokenFilter of TypesAnalysis.TruncateTokenFilter
        | UniqueTokenFilter of TypesAnalysis.UniqueTokenFilter
        | UppercaseTokenFilter of TypesAnalysis.UppercaseTokenFilter
        | WordDelimiterGraphTokenFilter of TypesAnalysis.WordDelimiterGraphTokenFilter
        | WordDelimiterTokenFilter of TypesAnalysis.WordDelimiterTokenFilter
        | JaStopTokenFilter of TypesAnalysis.JaStopTokenFilter
        | KuromojiStemmerTokenFilter of TypesAnalysis.KuromojiStemmerTokenFilter
        | KuromojiReadingFormTokenFilter of TypesAnalysis.KuromojiReadingFormTokenFilter
        | KuromojiPartOfSpeechTokenFilter of TypesAnalysis.KuromojiPartOfSpeechTokenFilter
        | IcuCollationTokenFilter of TypesAnalysis.IcuCollationTokenFilter
        | IcuFoldingTokenFilter of TypesAnalysis.IcuFoldingTokenFilter
        | IcuNormalizationTokenFilter of TypesAnalysis.IcuNormalizationTokenFilter
        | IcuTransformTokenFilter of TypesAnalysis.IcuTransformTokenFilter
        | PhoneticTokenFilter of TypesAnalysis.PhoneticTokenFilter
        | DictionaryDecompounderTokenFilter of TypesAnalysis.DictionaryDecompounderTokenFilter
        | Unknown of name: string * System.Text.Json.JsonElement

    [<RequireQualifiedAccess>]
    type TokenFilter =
        | String of string
        | TokenFilterDefinition of TypesAnalysis.TokenFilterDefinition

    type UaxEmailUrlTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("max_token_length")>]
        MaxTokenLength: Types.Integer option
    }

    type WhitespaceTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("max_token_length")>]
        MaxTokenLength: Types.Integer option
    }

    [<RequireQualifiedAccess>]
    type TokenizerDefinition =
        | CharGroupTokenizer of TypesAnalysis.CharGroupTokenizer
        | ClassicTokenizer of TypesAnalysis.ClassicTokenizer
        | EdgeNGramTokenizer of TypesAnalysis.EdgeNGramTokenizer
        | KeywordTokenizer of TypesAnalysis.KeywordTokenizer
        | LetterTokenizer of TypesAnalysis.LetterTokenizer
        | LowercaseTokenizer of TypesAnalysis.LowercaseTokenizer
        | NGramTokenizer of TypesAnalysis.NGramTokenizer
        | PathHierarchyTokenizer of TypesAnalysis.PathHierarchyTokenizer
        | PatternTokenizer of TypesAnalysis.PatternTokenizer
        | SimplePatternTokenizer of TypesAnalysis.SimplePatternTokenizer
        | SimplePatternSplitTokenizer of TypesAnalysis.SimplePatternSplitTokenizer
        | StandardTokenizer of TypesAnalysis.StandardTokenizer
        | ThaiTokenizer of TypesAnalysis.ThaiTokenizer
        | UaxEmailUrlTokenizer of TypesAnalysis.UaxEmailUrlTokenizer
        | WhitespaceTokenizer of TypesAnalysis.WhitespaceTokenizer
        | IcuTokenizer of TypesAnalysis.IcuTokenizer
        | KuromojiTokenizer of TypesAnalysis.KuromojiTokenizer
        | NoriTokenizer of TypesAnalysis.NoriTokenizer
        | Unknown of name: string * System.Text.Json.JsonElement

    [<RequireQualifiedAccess>]
    type Tokenizer =
        | String of string
        | TokenizerDefinition of TypesAnalysis.TokenizerDefinition


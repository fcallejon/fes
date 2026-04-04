namespace Fes

open Fes.Generated

/// Convenience functions for building IndexSettingsAnalysis without verbose DU wrapping.
///
/// Example:
///   let settings = Analysis.analysis [
///       Analysis.withStandard "default" Types.StandardAnalyzer.empty
///       Analysis.withCustom "my_custom" (customAnalyzer {
///           tokenizer "standard"
///           filter [ "lowercase"; "my_edge_ngram" ]
///       })
///       Analysis.withEdgeNGramFilter "my_edge_ngram" (edgeNGramTokenFilter { minGram 1; maxGram 20 })
///   ]
[<RequireQualifiedAccess>]
module Analysis =

    // ── Entry type ───────────────────────────────────────────────────────────
    // A single named component to add to IndexSettingsAnalysis.

    type Entry =
        | Analyzer  of name: string * Types.Analyzer
        | Filter    of name: string * Types.TokenFilter
        | CharFilter of name: string * Types.CharFilter
        | Tokenizer of name: string * Types.Tokenizer
        | Normalizer of name: string * Types.Normalizer

    // ── Build IndexSettingsAnalysis from a mixed Entry list ──────────────────

    /// Build an IndexSettingsAnalysis from a list of Analysis.Entry values.
    let analysis (entries: Entry list) : Types.IndexSettingsAnalysis =
        let fold (acc: Types.IndexSettingsAnalysis) entry =
            match entry with
            | Analyzer  (n, v) ->
                { acc with Analyzer  = acc.Analyzer  |> Option.defaultValue Map.empty |> Map.add n v |> Some }
            | Filter    (n, v) ->
                { acc with Filter    = acc.Filter    |> Option.defaultValue Map.empty |> Map.add n v |> Some }
            | CharFilter (n, v) ->
                { acc with CharFilter = acc.CharFilter |> Option.defaultValue Map.empty |> Map.add n v |> Some }
            | Tokenizer (n, v) ->
                { acc with Tokenizer = acc.Tokenizer |> Option.defaultValue Map.empty |> Map.add n v |> Some }
            | Normalizer (n, v) ->
                { acc with Normalizer = acc.Normalizer |> Option.defaultValue Map.empty |> Map.add n v |> Some }
        entries |> List.fold fold Types.IndexSettingsAnalysis.empty

    // ── Built-in analyzer entries: withXxx ──────────────────────────────────
    // Each function wraps the concrete config type into the Analyzer DU case.

    /// Custom (fully-configurable) analyzer.
    let withCustom name (cfg: Types.CustomAnalyzer) =
        Analyzer (name, Types.Analyzer.CustomAnalyzer cfg)

    /// Standard analyzer (word-splitting + lowercase).
    let withStandard name (cfg: Types.StandardAnalyzer) =
        Analyzer (name, Types.Analyzer.StandardAnalyzer cfg)

    /// Simple analyzer (lowercase, letter tokenizer).
    let withSimple name (cfg: Types.SimpleAnalyzer) =
        Analyzer (name, Types.Analyzer.SimpleAnalyzer cfg)

    /// Stop analyzer (removes stop words).
    let withStop name (cfg: Types.StopAnalyzer) =
        Analyzer (name, Types.Analyzer.StopAnalyzer cfg)

    /// Whitespace analyzer.
    let withWhitespace name (cfg: Types.WhitespaceAnalyzer) =
        Analyzer (name, Types.Analyzer.WhitespaceAnalyzer cfg)

    /// Keyword analyzer (treats the whole field as one token).
    let withKeyword name (cfg: Types.KeywordAnalyzer) =
        Analyzer (name, Types.Analyzer.KeywordAnalyzer cfg)

    /// Pattern analyzer (splits on a regex).
    let withPattern name (cfg: Types.PatternAnalyzer) =
        Analyzer (name, Types.Analyzer.PatternAnalyzer cfg)

    /// Fingerprint analyzer.
    let withFingerprint name (cfg: Types.FingerprintAnalyzer) =
        Analyzer (name, Types.Analyzer.FingerprintAnalyzer cfg)

    /// Snowball stemming analyzer.
    let withSnowball name (cfg: Types.SnowballAnalyzer) =
        Analyzer (name, Types.Analyzer.SnowballAnalyzer cfg)

    /// ICU (Unicode) analyzer.
    let withIcu name (cfg: Types.IcuAnalyzer) =
        Analyzer (name, Types.Analyzer.IcuAnalyzer cfg)

    /// Kuromoji (Japanese) analyzer.
    let withKuromoji name (cfg: Types.KuromojiAnalyzer) =
        Analyzer (name, Types.Analyzer.KuromojiAnalyzer cfg)

    /// Nori (Korean) analyzer.
    let withNori name (cfg: Types.NoriAnalyzer) =
        Analyzer (name, Types.Analyzer.NoriAnalyzer cfg)

    // ── Language analyzers ───────────────────────────────────────────────────

    let withArabic    name (cfg: Types.ArabicAnalyzer)    = Analyzer (name, Types.Analyzer.ArabicAnalyzer cfg)
    let withArmenian  name (cfg: Types.ArmenianAnalyzer)  = Analyzer (name, Types.Analyzer.ArmenianAnalyzer cfg)
    let withBasque    name (cfg: Types.BasqueAnalyzer)    = Analyzer (name, Types.Analyzer.BasqueAnalyzer cfg)
    let withBengali   name (cfg: Types.BengaliAnalyzer)   = Analyzer (name, Types.Analyzer.BengaliAnalyzer cfg)
    let withBrazilian name (cfg: Types.BrazilianAnalyzer) = Analyzer (name, Types.Analyzer.BrazilianAnalyzer cfg)
    let withBulgarian name (cfg: Types.BulgarianAnalyzer) = Analyzer (name, Types.Analyzer.BulgarianAnalyzer cfg)
    let withCatalan   name (cfg: Types.CatalanAnalyzer)   = Analyzer (name, Types.Analyzer.CatalanAnalyzer cfg)
    let withChinese   name (cfg: Types.ChineseAnalyzer)   = Analyzer (name, Types.Analyzer.ChineseAnalyzer cfg)
    let withCjk       name (cfg: Types.CjkAnalyzer)       = Analyzer (name, Types.Analyzer.CjkAnalyzer cfg)
    let withCzech     name (cfg: Types.CzechAnalyzer)     = Analyzer (name, Types.Analyzer.CzechAnalyzer cfg)
    let withDanish    name (cfg: Types.DanishAnalyzer)    = Analyzer (name, Types.Analyzer.DanishAnalyzer cfg)
    let withDutch     name (cfg: Types.DutchAnalyzer)     = Analyzer (name, Types.Analyzer.DutchAnalyzer cfg)
    let withEnglish   name (cfg: Types.EnglishAnalyzer)   = Analyzer (name, Types.Analyzer.EnglishAnalyzer cfg)
    let withEstonian  name (cfg: Types.EstonianAnalyzer)  = Analyzer (name, Types.Analyzer.EstonianAnalyzer cfg)
    let withFinnish   name (cfg: Types.FinnishAnalyzer)   = Analyzer (name, Types.Analyzer.FinnishAnalyzer cfg)
    let withFrench    name (cfg: Types.FrenchAnalyzer)    = Analyzer (name, Types.Analyzer.FrenchAnalyzer cfg)
    let withGalician  name (cfg: Types.GalicianAnalyzer)  = Analyzer (name, Types.Analyzer.GalicianAnalyzer cfg)
    let withGerman    name (cfg: Types.GermanAnalyzer)    = Analyzer (name, Types.Analyzer.GermanAnalyzer cfg)
    let withGreek     name (cfg: Types.GreekAnalyzer)     = Analyzer (name, Types.Analyzer.GreekAnalyzer cfg)
    let withHindi     name (cfg: Types.HindiAnalyzer)     = Analyzer (name, Types.Analyzer.HindiAnalyzer cfg)
    let withHungarian name (cfg: Types.HungarianAnalyzer) = Analyzer (name, Types.Analyzer.HungarianAnalyzer cfg)
    let withIndonesian name (cfg: Types.IndonesianAnalyzer) = Analyzer (name, Types.Analyzer.IndonesianAnalyzer cfg)
    let withIrish     name (cfg: Types.IrishAnalyzer)     = Analyzer (name, Types.Analyzer.IrishAnalyzer cfg)
    let withItalian   name (cfg: Types.ItalianAnalyzer)   = Analyzer (name, Types.Analyzer.ItalianAnalyzer cfg)
    let withLatvian   name (cfg: Types.LatvianAnalyzer)   = Analyzer (name, Types.Analyzer.LatvianAnalyzer cfg)
    let withLithuanian name (cfg: Types.LithuanianAnalyzer) = Analyzer (name, Types.Analyzer.LithuanianAnalyzer cfg)
    let withNorwegian name (cfg: Types.NorwegianAnalyzer) = Analyzer (name, Types.Analyzer.NorwegianAnalyzer cfg)
    let withPersian   name (cfg: Types.PersianAnalyzer)   = Analyzer (name, Types.Analyzer.PersianAnalyzer cfg)
    let withPortuguese name (cfg: Types.PortugueseAnalyzer) = Analyzer (name, Types.Analyzer.PortugueseAnalyzer cfg)
    let withRomanian  name (cfg: Types.RomanianAnalyzer)  = Analyzer (name, Types.Analyzer.RomanianAnalyzer cfg)
    let withRussian   name (cfg: Types.RussianAnalyzer)   = Analyzer (name, Types.Analyzer.RussianAnalyzer cfg)
    let withSerbian   name (cfg: Types.SerbianAnalyzer)   = Analyzer (name, Types.Analyzer.SerbianAnalyzer cfg)
    let withSorani    name (cfg: Types.SoraniAnalyzer)    = Analyzer (name, Types.Analyzer.SoraniAnalyzer cfg)
    let withSpanish   name (cfg: Types.SpanishAnalyzer)   = Analyzer (name, Types.Analyzer.SpanishAnalyzer cfg)
    let withSwedish   name (cfg: Types.SwedishAnalyzer)   = Analyzer (name, Types.Analyzer.SwedishAnalyzer cfg)
    let withThai      name (cfg: Types.ThaiAnalyzer)      = Analyzer (name, Types.Analyzer.ThaiAnalyzer cfg)
    let withTurkish   name (cfg: Types.TurkishAnalyzer)   = Analyzer (name, Types.Analyzer.TurkishAnalyzer cfg)

    // ── Token filter entries ─────────────────────────────────────────────────
    // Generic wrapper for any fully-constructed Types.TokenFilter value.

    /// Add any token filter to the analysis settings.
    let withFilter name (filter: Types.TokenFilter) = Filter (name, filter)

    // Convenience wrappers for common token filter definitions.
    // The named `withXxxFilter` helpers build the TokenFilter DU automatically.

    let withEdgeNGramFilter name (cfg: Types.EdgeNGramTokenFilter) =
        Filter (name, Types.TokenFilter.TokenFilterDefinition (Types.TokenFilterDefinition.EdgeNGramTokenFilter cfg))

    let withNGramFilter name (cfg: Types.NGramTokenFilter) =
        Filter (name, Types.TokenFilter.TokenFilterDefinition (Types.TokenFilterDefinition.NGramTokenFilter cfg))

    let withStopFilter name (cfg: Types.StopTokenFilter) =
        Filter (name, Types.TokenFilter.TokenFilterDefinition (Types.TokenFilterDefinition.StopTokenFilter cfg))

    let withSynonymFilter name (cfg: Types.SynonymTokenFilter) =
        Filter (name, Types.TokenFilter.TokenFilterDefinition (Types.TokenFilterDefinition.SynonymTokenFilter cfg))

    let withSynonymGraphFilter name (cfg: Types.SynonymGraphTokenFilter) =
        Filter (name, Types.TokenFilter.TokenFilterDefinition (Types.TokenFilterDefinition.SynonymGraphTokenFilter cfg))

    let withStemmerFilter name (cfg: Types.StemmerTokenFilter) =
        Filter (name, Types.TokenFilter.TokenFilterDefinition (Types.TokenFilterDefinition.StemmerTokenFilter cfg))

    let withPatternReplaceFilter name (cfg: Types.PatternReplaceTokenFilter) =
        Filter (name, Types.TokenFilter.TokenFilterDefinition (Types.TokenFilterDefinition.PatternReplaceTokenFilter cfg))

    let withShingleFilter name (cfg: Types.ShingleTokenFilter) =
        Filter (name, Types.TokenFilter.TokenFilterDefinition (Types.TokenFilterDefinition.ShingleTokenFilter cfg))

    let withLengthFilter name (cfg: Types.LengthTokenFilter) =
        Filter (name, Types.TokenFilter.TokenFilterDefinition (Types.TokenFilterDefinition.LengthTokenFilter cfg))

    let withLimitTokenCountFilter name (cfg: Types.LimitTokenCountTokenFilter) =
        Filter (name, Types.TokenFilter.TokenFilterDefinition (Types.TokenFilterDefinition.LimitTokenCountTokenFilter cfg))

    let withTruncateFilter name (cfg: Types.TruncateTokenFilter) =
        Filter (name, Types.TokenFilter.TokenFilterDefinition (Types.TokenFilterDefinition.TruncateTokenFilter cfg))

    let withHunspellFilter name (cfg: Types.HunspellTokenFilter) =
        Filter (name, Types.TokenFilter.TokenFilterDefinition (Types.TokenFilterDefinition.HunspellTokenFilter cfg))

    let withIcuCollationFilter name (cfg: Types.IcuCollationTokenFilter) =
        Filter (name, Types.TokenFilter.TokenFilterDefinition (Types.TokenFilterDefinition.IcuCollationTokenFilter cfg))

    let withKuromojiReadingFormFilter name (cfg: Types.KuromojiReadingFormTokenFilter) =
        Filter (name, Types.TokenFilter.TokenFilterDefinition (Types.TokenFilterDefinition.KuromojiReadingFormTokenFilter cfg))

    // ── Char filter entries ──────────────────────────────────────────────────

    /// Add any char filter to the analysis settings.
    let withCharFilter name (cf: Types.CharFilter) = CharFilter (name, cf)

    let withHtmlStripCharFilter name (cfg: Types.HtmlStripCharFilter) =
        CharFilter (name, Types.CharFilter.CharFilterDefinition (Types.CharFilterDefinition.HtmlStripCharFilter cfg))

    let withMappingCharFilter name (cfg: Types.MappingCharFilter) =
        CharFilter (name, Types.CharFilter.CharFilterDefinition (Types.CharFilterDefinition.MappingCharFilter cfg))

    let withPatternReplaceCharFilter name (cfg: Types.PatternReplaceCharFilter) =
        CharFilter (name, Types.CharFilter.CharFilterDefinition (Types.CharFilterDefinition.PatternReplaceCharFilter cfg))

    let withIcuNormalizationCharFilter name (cfg: Types.IcuNormalizationCharFilter) =
        CharFilter (name, Types.CharFilter.CharFilterDefinition (Types.CharFilterDefinition.IcuNormalizationCharFilter cfg))

    // ── Tokenizer entries ────────────────────────────────────────────────────

    /// Add any tokenizer to the analysis settings.
    let withTokenizer name (t: Types.Tokenizer) = Tokenizer (name, t)

    let withEdgeNGramTokenizer name (cfg: Types.EdgeNGramTokenizer) =
        Tokenizer (name, Types.Tokenizer.TokenizerDefinition (Types.TokenizerDefinition.EdgeNGramTokenizer cfg))

    let withNGramTokenizer name (cfg: Types.NGramTokenizer) =
        Tokenizer (name, Types.Tokenizer.TokenizerDefinition (Types.TokenizerDefinition.NGramTokenizer cfg))

    let withPatternTokenizer name (cfg: Types.PatternTokenizer) =
        Tokenizer (name, Types.Tokenizer.TokenizerDefinition (Types.TokenizerDefinition.PatternTokenizer cfg))

    let withStandardTokenizer name (cfg: Types.StandardTokenizer) =
        Tokenizer (name, Types.Tokenizer.TokenizerDefinition (Types.TokenizerDefinition.StandardTokenizer cfg))

    let withWhitespaceTokenizer name (cfg: Types.WhitespaceTokenizer) =
        Tokenizer (name, Types.Tokenizer.TokenizerDefinition (Types.TokenizerDefinition.WhitespaceTokenizer cfg))

    let withNoriTokenizer name (cfg: Types.NoriTokenizer) =
        Tokenizer (name, Types.Tokenizer.TokenizerDefinition (Types.TokenizerDefinition.NoriTokenizer cfg))

    let withKuromojiTokenizer name (cfg: Types.KuromojiTokenizer) =
        Tokenizer (name, Types.Tokenizer.TokenizerDefinition (Types.TokenizerDefinition.KuromojiTokenizer cfg))

    // ── Normalizer entries ───────────────────────────────────────────────────

    /// Add any normalizer to the analysis settings.
    let withNormalizer name (n: Types.Normalizer) = Normalizer (name, n)

    let withCustomNormalizer name (cfg: Types.CustomNormalizer) =
        Normalizer (name, Types.Normalizer.CustomNormalizer cfg)

    let withLowercaseNormalizer name (cfg: Types.LowercaseNormalizer) =
        Normalizer (name, Types.Normalizer.LowercaseNormalizer cfg)

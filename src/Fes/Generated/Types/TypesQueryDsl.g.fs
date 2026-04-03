// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module TypesQueryDsl =

    type QueryBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("_name")>]
        Name: string option
    }

    [<RequireQualifiedAccess>]
    type Operator =
        | And
        | Or

    type CommonTermsQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("cutoff_frequency")>]
        CutoffFrequency: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("high_freq_operator")>]
        HighFreqOperator: TypesQueryDsl.Operator option
        [<System.Text.Json.Serialization.JsonPropertyName("low_freq_operator")>]
        LowFreqOperator: TypesQueryDsl.Operator option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_should_match")>]
        MinimumShouldMatch: Types.MinimumShouldMatch option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
    }

    [<RequireQualifiedAccess>]
    type CombinedFieldsOperator =
        | Or
        | And

    [<RequireQualifiedAccess>]
    type CombinedFieldsZeroTerms =
        | None
        | All

    type CombinedFieldsQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Types.Field list
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
        [<System.Text.Json.Serialization.JsonPropertyName("auto_generate_synonyms_phrase_query")>]
        AutoGenerateSynonymsPhraseQuery: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("operator")>]
        Operator: TypesQueryDsl.CombinedFieldsOperator option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_should_match")>]
        MinimumShouldMatch: Types.MinimumShouldMatch option
        [<System.Text.Json.Serialization.JsonPropertyName("zero_terms_query")>]
        ZeroTermsQuery: TypesQueryDsl.CombinedFieldsZeroTerms option
    }

    type DistanceFeatureQueryBase<'tOrigin, 'tDistance> = {
        [<System.Text.Json.Serialization.JsonPropertyName("origin")>]
        Origin: 'tOrigin
        [<System.Text.Json.Serialization.JsonPropertyName("pivot")>]
        Pivot: 'tDistance
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
    }

    type UntypedDistanceFeatureQuery = {
    }

    type GeoDistanceFeatureQuery = {
    }

    type DateDistanceFeatureQuery = {
    }

    [<RequireQualifiedAccess>]
    type DistanceFeatureQuery =
        | UntypedDistanceFeatureQuery of TypesQueryDsl.UntypedDistanceFeatureQuery
        | GeoDistanceFeatureQuery of TypesQueryDsl.GeoDistanceFeatureQuery
        | DateDistanceFeatureQuery of TypesQueryDsl.DateDistanceFeatureQuery

    type ExistsQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
    }

    [<RequireQualifiedAccess>]
    type FunctionBoostMode =
        | Multiply
        | Replace
        | Sum
        | Avg
        | Max
        | Min

    [<RequireQualifiedAccess>]
    type MultiValueMode =
        | Min
        | Max
        | Avg
        | Sum

    type DecayFunctionBase<'tOrigin, 'tScale> = {
        [<System.Text.Json.Serialization.JsonPropertyName("multi_value_mode")>]
        MultiValueMode: TypesQueryDsl.MultiValueMode option
    }

    type UntypedDecayFunction = {
    }

    type DateDecayFunction = {
    }

    type NumericDecayFunction = {
    }

    type GeoDecayFunction = {
    }

    [<RequireQualifiedAccess>]
    type DecayFunction =
        | UntypedDecayFunction of TypesQueryDsl.UntypedDecayFunction
        | DateDecayFunction of TypesQueryDsl.DateDecayFunction
        | NumericDecayFunction of TypesQueryDsl.NumericDecayFunction
        | GeoDecayFunction of TypesQueryDsl.GeoDecayFunction

    [<RequireQualifiedAccess>]
    type FieldValueFactorModifier =
        | None
        | Log
        | Log1p
        | Log2p
        | Ln
        | Ln1p
        | Ln2p
        | Square
        | Sqrt
        | Reciprocal

    type FieldValueFactorScoreFunction = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("factor")>]
        Factor: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("modifier")>]
        Modifier: TypesQueryDsl.FieldValueFactorModifier option
    }

    type RandomScoreFunction = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("seed")>]
        Seed: System.Text.Json.JsonElement option
    }

    type ScriptScoreFunction = {
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script
    }

    [<RequireQualifiedAccess>]
    type FunctionScoreMode =
        | Multiply
        | Sum
        | Avg
        | First
        | Max
        | Min

    type FuzzyQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_expansions")>]
        MaxExpansions: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix_length")>]
        PrefixLength: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("rewrite")>]
        Rewrite: Types.MultiTermQueryRewrite option
        [<System.Text.Json.Serialization.JsonPropertyName("transpositions")>]
        Transpositions: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzziness")>]
        Fuzziness: Types.Fuzziness option
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: System.Text.Json.JsonElement
    }

    [<RequireQualifiedAccess>]
    type GeoExecution =
        | Memory
        | Indexed

    [<RequireQualifiedAccess>]
    type GeoValidationMethod =
        | Coerce
        | IgnoreMalformed
        | Strict

    type GeoBoundingBoxQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: TypesQueryDsl.GeoExecution option
        [<System.Text.Json.Serialization.JsonPropertyName("validation_method")>]
        ValidationMethod: TypesQueryDsl.GeoValidationMethod option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unmapped")>]
        IgnoreUnmapped: bool option
    }

    type GeoDistanceQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("distance")>]
        Distance: Types.Distance
        [<System.Text.Json.Serialization.JsonPropertyName("distance_type")>]
        DistanceType: Types.GeoDistanceType option
        [<System.Text.Json.Serialization.JsonPropertyName("validation_method")>]
        ValidationMethod: TypesQueryDsl.GeoValidationMethod option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unmapped")>]
        IgnoreUnmapped: bool option
    }

    [<RequireQualifiedAccess>]
    type GeoGridQuery =
        | Geotile of Types.GeoTile
        | Geohash of Types.GeoHash
        | Geohex of Types.GeoHexCell

    type GeoPolygonQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("validation_method")>]
        ValidationMethod: TypesQueryDsl.GeoValidationMethod option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unmapped")>]
        IgnoreUnmapped: bool option
    }

    type GeoShapeQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unmapped")>]
        IgnoreUnmapped: bool option
    }

    [<RequireQualifiedAccess>]
    type ChildScoreMode =
        | None
        | Avg
        | Sum
        | Max
        | Min

    type IdsQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("values")>]
        Values: Types.Ids option
    }

    type IntervalsFuzzy = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzziness")>]
        Fuzziness: Types.Fuzziness option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix_length")>]
        PrefixLength: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("term")>]
        Term: string
        [<System.Text.Json.Serialization.JsonPropertyName("transpositions")>]
        Transpositions: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("use_field")>]
        UseField: Types.Field option
    }

    type IntervalsPrefix = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix")>]
        Prefix: string
        [<System.Text.Json.Serialization.JsonPropertyName("use_field")>]
        UseField: Types.Field option
    }

    type IntervalsRange = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("gte")>]
        Gte: string option
        [<System.Text.Json.Serialization.JsonPropertyName("gt")>]
        Gt: string option
        [<System.Text.Json.Serialization.JsonPropertyName("lte")>]
        Lte: string option
        [<System.Text.Json.Serialization.JsonPropertyName("lt")>]
        Lt: string option
        [<System.Text.Json.Serialization.JsonPropertyName("use_field")>]
        UseField: Types.Field option
    }

    type IntervalsRegexp = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pattern")>]
        Pattern: string
        [<System.Text.Json.Serialization.JsonPropertyName("use_field")>]
        UseField: Types.Field option
    }

    type IntervalsWildcard = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pattern")>]
        Pattern: string
        [<System.Text.Json.Serialization.JsonPropertyName("use_field")>]
        UseField: Types.Field option
    }

    type IntervalsAllOf = {
        [<System.Text.Json.Serialization.JsonPropertyName("intervals")>]
        Intervals: TypesQueryDsl.IntervalsContainer list
        [<System.Text.Json.Serialization.JsonPropertyName("max_gaps")>]
        MaxGaps: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("ordered")>]
        Ordered: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: TypesQueryDsl.IntervalsFilter option
    }

    [<RequireQualifiedAccess>]
    and IntervalsContainer =
        | AllOf of TypesQueryDsl.IntervalsAllOf
        | AnyOf of TypesQueryDsl.IntervalsAnyOf
        | Fuzzy of TypesQueryDsl.IntervalsFuzzy
        | Match of TypesQueryDsl.IntervalsMatch
        | Prefix of TypesQueryDsl.IntervalsPrefix
        | Range of TypesQueryDsl.IntervalsRange
        | Regexp of TypesQueryDsl.IntervalsRegexp
        | Wildcard of TypesQueryDsl.IntervalsWildcard

    and IntervalsAnyOf = {
        [<System.Text.Json.Serialization.JsonPropertyName("intervals")>]
        Intervals: TypesQueryDsl.IntervalsContainer list
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: TypesQueryDsl.IntervalsFilter option
    }

    [<RequireQualifiedAccess>]
    and IntervalsFilter =
        | After of TypesQueryDsl.IntervalsContainer
        | Before of TypesQueryDsl.IntervalsContainer
        | ContainedBy of TypesQueryDsl.IntervalsContainer
        | Containing of TypesQueryDsl.IntervalsContainer
        | NotContainedBy of TypesQueryDsl.IntervalsContainer
        | NotContaining of TypesQueryDsl.IntervalsContainer
        | NotOverlapping of TypesQueryDsl.IntervalsContainer
        | Overlapping of TypesQueryDsl.IntervalsContainer
        | Script of Types.Script

    and IntervalsMatch = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_gaps")>]
        MaxGaps: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("ordered")>]
        Ordered: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
        [<System.Text.Json.Serialization.JsonPropertyName("use_field")>]
        UseField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: TypesQueryDsl.IntervalsFilter option
    }

    [<RequireQualifiedAccess>]
    type IntervalsQuery =
        | AllOf of TypesQueryDsl.IntervalsAllOf
        | AnyOf of TypesQueryDsl.IntervalsAnyOf
        | Fuzzy of TypesQueryDsl.IntervalsFuzzy
        | Match of TypesQueryDsl.IntervalsMatch
        | Prefix of TypesQueryDsl.IntervalsPrefix
        | Range of TypesQueryDsl.IntervalsRange
        | Regexp of TypesQueryDsl.IntervalsRegexp
        | Wildcard of TypesQueryDsl.IntervalsWildcard

    [<RequireQualifiedAccess>]
    type ZeroTermsQuery =
        | All
        | None

    type MatchQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("auto_generate_synonyms_phrase_query")>]
        AutoGenerateSynonymsPhraseQuery: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("cutoff_frequency")>]
        CutoffFrequency: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzziness")>]
        Fuzziness: Types.Fuzziness option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_rewrite")>]
        FuzzyRewrite: Types.MultiTermQueryRewrite option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_transpositions")>]
        FuzzyTranspositions: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("lenient")>]
        Lenient: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("max_expansions")>]
        MaxExpansions: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_should_match")>]
        MinimumShouldMatch: Types.MinimumShouldMatch option
        [<System.Text.Json.Serialization.JsonPropertyName("operator")>]
        Operator: TypesQueryDsl.Operator option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix_length")>]
        PrefixLength: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("zero_terms_query")>]
        ZeroTermsQuery: TypesQueryDsl.ZeroTermsQuery option
    }

    type MatchAllQuery = {
    }

    type MatchBoolPrefixQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzziness")>]
        Fuzziness: Types.Fuzziness option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_rewrite")>]
        FuzzyRewrite: Types.MultiTermQueryRewrite option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_transpositions")>]
        FuzzyTranspositions: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("max_expansions")>]
        MaxExpansions: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_should_match")>]
        MinimumShouldMatch: Types.MinimumShouldMatch option
        [<System.Text.Json.Serialization.JsonPropertyName("operator")>]
        Operator: TypesQueryDsl.Operator option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix_length")>]
        PrefixLength: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
    }

    type MatchNoneQuery = {
    }

    type MatchPhraseQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
        [<System.Text.Json.Serialization.JsonPropertyName("slop")>]
        Slop: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("zero_terms_query")>]
        ZeroTermsQuery: TypesQueryDsl.ZeroTermsQuery option
    }

    type MatchPhrasePrefixQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_expansions")>]
        MaxExpansions: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
        [<System.Text.Json.Serialization.JsonPropertyName("slop")>]
        Slop: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("zero_terms_query")>]
        ZeroTermsQuery: TypesQueryDsl.ZeroTermsQuery option
    }

    type LikeDocument = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc")>]
        Doc: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Types.Field list option
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: Types.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("per_field_analyzer")>]
        PerFieldAnalyzer: Map<Types.Field, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: Types.Routing option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("version_type")>]
        VersionType: Types.VersionType option
    }

    /// Text that we want similar documents for or a lookup to a document's field for the text.
    [<RequireQualifiedAccess>]
    type Like =
        | String of string
        | LikeDocument of TypesQueryDsl.LikeDocument

    type MoreLikeThisQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("boost_terms")>]
        BoostTerms: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("fail_on_unsupported_field")>]
        FailOnUnsupportedField: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Types.Field list option
        [<System.Text.Json.Serialization.JsonPropertyName("include")>]
        Include: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("like")>]
        Like: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("max_doc_freq")>]
        MaxDocFreq: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_query_terms")>]
        MaxQueryTerms: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_word_length")>]
        MaxWordLength: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_freq")>]
        MinDocFreq: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_should_match")>]
        MinimumShouldMatch: Types.MinimumShouldMatch option
        [<System.Text.Json.Serialization.JsonPropertyName("min_term_freq")>]
        MinTermFreq: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_word_length")>]
        MinWordLength: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stop_words")>]
        StopWords: TypesAnalysis.StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("unlike")>]
        Unlike: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("version_type")>]
        VersionType: Types.VersionType option
    }

    [<RequireQualifiedAccess>]
    type TextQueryType =
        | BestFields
        | MostFields
        | CrossFields
        | Phrase
        | PhrasePrefix
        | BoolPrefix

    type MultiMatchQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("auto_generate_synonyms_phrase_query")>]
        AutoGenerateSynonymsPhraseQuery: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("cutoff_frequency")>]
        CutoffFrequency: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Types.Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzziness")>]
        Fuzziness: Types.Fuzziness option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_rewrite")>]
        FuzzyRewrite: Types.MultiTermQueryRewrite option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_transpositions")>]
        FuzzyTranspositions: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("lenient")>]
        Lenient: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("max_expansions")>]
        MaxExpansions: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_should_match")>]
        MinimumShouldMatch: Types.MinimumShouldMatch option
        [<System.Text.Json.Serialization.JsonPropertyName("operator")>]
        Operator: TypesQueryDsl.Operator option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix_length")>]
        PrefixLength: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
        [<System.Text.Json.Serialization.JsonPropertyName("slop")>]
        Slop: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("tie_breaker")>]
        TieBreaker: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: TypesQueryDsl.TextQueryType option
        [<System.Text.Json.Serialization.JsonPropertyName("zero_terms_query")>]
        ZeroTermsQuery: TypesQueryDsl.ZeroTermsQuery option
    }

    type ParentIdQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unmapped")>]
        IgnoreUnmapped: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: Types.RelationName option
    }

    type PercolateQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("document")>]
        Document: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("documents")>]
        Documents: System.Text.Json.JsonElement list option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string option
        [<System.Text.Json.Serialization.JsonPropertyName("preference")>]
        Preference: string option
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: string option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionNumber option
    }

    type PinnedDoc = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: Types.IndexName option
    }

    type PrefixQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("rewrite")>]
        Rewrite: Types.MultiTermQueryRewrite option
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: string
        [<System.Text.Json.Serialization.JsonPropertyName("case_insensitive")>]
        CaseInsensitive: bool option
    }

    type QueryStringQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("allow_leading_wildcard")>]
        AllowLeadingWildcard: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("analyze_wildcard")>]
        AnalyzeWildcard: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("auto_generate_synonyms_phrase_query")>]
        AutoGenerateSynonymsPhraseQuery: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("default_field")>]
        DefaultField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("default_operator")>]
        DefaultOperator: TypesQueryDsl.Operator option
        [<System.Text.Json.Serialization.JsonPropertyName("enable_position_increments")>]
        EnablePositionIncrements: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("escape")>]
        Escape: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Types.Field list option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzziness")>]
        Fuzziness: Types.Fuzziness option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_max_expansions")>]
        FuzzyMaxExpansions: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_prefix_length")>]
        FuzzyPrefixLength: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_rewrite")>]
        FuzzyRewrite: Types.MultiTermQueryRewrite option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_transpositions")>]
        FuzzyTranspositions: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("lenient")>]
        Lenient: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("max_determinized_states")>]
        MaxDeterminizedStates: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_should_match")>]
        MinimumShouldMatch: Types.MinimumShouldMatch option
        [<System.Text.Json.Serialization.JsonPropertyName("phrase_slop")>]
        PhraseSlop: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
        [<System.Text.Json.Serialization.JsonPropertyName("quote_analyzer")>]
        QuoteAnalyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("quote_field_suffix")>]
        QuoteFieldSuffix: string option
        [<System.Text.Json.Serialization.JsonPropertyName("rewrite")>]
        Rewrite: Types.MultiTermQueryRewrite option
        [<System.Text.Json.Serialization.JsonPropertyName("tie_breaker")>]
        TieBreaker: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("time_zone")>]
        TimeZone: Types.TimeZone option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: TypesQueryDsl.TextQueryType option
    }

    [<RequireQualifiedAccess>]
    type RangeRelation =
        | Within
        | Contains
        | Intersects

    type RangeQueryBase<'t> = {
        [<System.Text.Json.Serialization.JsonPropertyName("relation")>]
        Relation: TypesQueryDsl.RangeRelation option
        [<System.Text.Json.Serialization.JsonPropertyName("gt")>]
        Gt: 't option
        [<System.Text.Json.Serialization.JsonPropertyName("gte")>]
        Gte: 't option
        [<System.Text.Json.Serialization.JsonPropertyName("lt")>]
        Lt: 't option
        [<System.Text.Json.Serialization.JsonPropertyName("lte")>]
        Lte: 't option
    }

    type UntypedRangeQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: Types.DateFormat option
        [<System.Text.Json.Serialization.JsonPropertyName("time_zone")>]
        TimeZone: Types.TimeZone option
    }

    type DateRangeQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: Types.DateFormat option
        [<System.Text.Json.Serialization.JsonPropertyName("time_zone")>]
        TimeZone: Types.TimeZone option
    }

    type NumberRangeQuery = {
    }

    type TermRangeQuery = {
    }

    [<RequireQualifiedAccess>]
    type RangeQuery =
        | UntypedRangeQuery of TypesQueryDsl.UntypedRangeQuery
        | DateRangeQuery of TypesQueryDsl.DateRangeQuery
        | NumberRangeQuery of TypesQueryDsl.NumberRangeQuery
        | TermRangeQuery of TypesQueryDsl.TermRangeQuery

    type RankFeatureFunction = {
    }

    type RankFeatureFunctionSaturation = {
        [<System.Text.Json.Serialization.JsonPropertyName("pivot")>]
        Pivot: Types.Float option
    }

    type RankFeatureFunctionLogarithm = {
        [<System.Text.Json.Serialization.JsonPropertyName("scaling_factor")>]
        ScalingFactor: Types.Float
    }

    type RankFeatureFunctionLinear = {
    }

    type RankFeatureFunctionSigmoid = {
        [<System.Text.Json.Serialization.JsonPropertyName("pivot")>]
        Pivot: Types.Float
        [<System.Text.Json.Serialization.JsonPropertyName("exponent")>]
        Exponent: Types.Float
    }

    type RankFeatureQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("saturation")>]
        Saturation: TypesQueryDsl.RankFeatureFunctionSaturation option
        [<System.Text.Json.Serialization.JsonPropertyName("log")>]
        Log: TypesQueryDsl.RankFeatureFunctionLogarithm option
        [<System.Text.Json.Serialization.JsonPropertyName("linear")>]
        Linear: TypesQueryDsl.RankFeatureFunctionLinear option
        [<System.Text.Json.Serialization.JsonPropertyName("sigmoid")>]
        Sigmoid: TypesQueryDsl.RankFeatureFunctionSigmoid option
    }

    type RegexpQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("case_insensitive")>]
        CaseInsensitive: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("flags")>]
        Flags: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_determinized_states")>]
        MaxDeterminizedStates: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("rewrite")>]
        Rewrite: Types.MultiTermQueryRewrite option
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: string
    }

    type ScriptQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script
    }

    type SemanticQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: string
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
    }

    type ShapeQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unmapped")>]
        IgnoreUnmapped: bool option
    }

    [<RequireQualifiedAccess>]
    type SimpleQueryStringFlag =
        | NONE
        | AND
        | NOT
        | OR
        | PREFIX
        | PHRASE
        | PRECEDENCE
        | ESCAPE
        | WHITESPACE
        | FUZZY
        | NEAR
        | SLOP
        | ALL

    /// Query flags can be either a single flag or a combination of flags, e.g. `OR|AND|PREFIX`
    type SimpleQueryStringFlags = SpecUtils.PipeSeparatedFlags<TypesQueryDsl.SimpleQueryStringFlag>

    type SimpleQueryStringQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("analyze_wildcard")>]
        AnalyzeWildcard: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("auto_generate_synonyms_phrase_query")>]
        AutoGenerateSynonymsPhraseQuery: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("default_operator")>]
        DefaultOperator: TypesQueryDsl.Operator option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Types.Field list option
        [<System.Text.Json.Serialization.JsonPropertyName("flags")>]
        Flags: TypesQueryDsl.SimpleQueryStringFlags option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_max_expansions")>]
        FuzzyMaxExpansions: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_prefix_length")>]
        FuzzyPrefixLength: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_transpositions")>]
        FuzzyTranspositions: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("lenient")>]
        Lenient: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_should_match")>]
        MinimumShouldMatch: Types.MinimumShouldMatch option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
        [<System.Text.Json.Serialization.JsonPropertyName("quote_field_suffix")>]
        QuoteFieldSuffix: string option
    }

    /// Can only be used as a clause in a span_near query.
    type SpanGapQuery = Map<Types.Field, Types.Integer>

    type SpanTermQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: Types.FieldValue
    }

    [<RequireQualifiedAccess>]
    type SparseVectorQuery =
        | QueryVector of Map<string, Types.Float>
        | InferenceId of Types.Id

    and SparseVectorQueryMeta = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string option
        [<System.Text.Json.Serialization.JsonPropertyName("prune")>]
        Prune: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("pruning_config")>]
        PruningConfig: Types.TokenPruningConfig option
    }

    type TermQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: Types.FieldValue
        [<System.Text.Json.Serialization.JsonPropertyName("case_insensitive")>]
        CaseInsensitive: bool option
    }

    type TermsQuery = {
    }

    type TermsSetQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_should_match")>]
        MinimumShouldMatch: Types.MinimumShouldMatch option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_should_match_field")>]
        MinimumShouldMatchField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_should_match_script")>]
        MinimumShouldMatchScript: Types.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("terms")>]
        Terms: Types.FieldValue list
    }

    type TextExpansionQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: string
        [<System.Text.Json.Serialization.JsonPropertyName("model_text")>]
        ModelText: string
        [<System.Text.Json.Serialization.JsonPropertyName("pruning_config")>]
        PruningConfig: Types.TokenPruningConfig option
    }

    type WeightedTokensQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("tokens")>]
        Tokens: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("pruning_config")>]
        PruningConfig: Types.TokenPruningConfig option
    }

    type WildcardQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("case_insensitive")>]
        CaseInsensitive: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("rewrite")>]
        Rewrite: Types.MultiTermQueryRewrite option
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: string option
        [<System.Text.Json.Serialization.JsonPropertyName("wildcard")>]
        Wildcard: string option
    }

    type WrapperQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
    }

    type TypeQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: string
    }

    type BoolQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_should_match")>]
        MinimumShouldMatch: Types.MinimumShouldMatch option
        [<System.Text.Json.Serialization.JsonPropertyName("must")>]
        Must: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("must_not")>]
        MustNot: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("should")>]
        Should: System.Text.Json.JsonElement option
    }

    /// An Elasticsearch Query DSL (Domain Specific Language) object that defines a query.
    [<RequireQualifiedAccess>]
    and QueryContainer =
        | Bool of TypesQueryDsl.BoolQuery
        | Boosting of TypesQueryDsl.BoostingQuery
        | Common of field: string * TypesQueryDsl.CommonTermsQuery
        | CombinedFields of TypesQueryDsl.CombinedFieldsQuery
        | ConstantScore of TypesQueryDsl.ConstantScoreQuery
        | DisMax of TypesQueryDsl.DisMaxQuery
        | DistanceFeature of TypesQueryDsl.DistanceFeatureQuery
        | Exists of TypesQueryDsl.ExistsQuery
        | FunctionScore of TypesQueryDsl.FunctionScoreQuery
        | Fuzzy of field: string * TypesQueryDsl.FuzzyQuery
        | GeoBoundingBox of TypesQueryDsl.GeoBoundingBoxQuery
        | GeoDistance of TypesQueryDsl.GeoDistanceQuery
        | GeoGrid of field: string * TypesQueryDsl.GeoGridQuery
        | GeoPolygon of TypesQueryDsl.GeoPolygonQuery
        | GeoShape of TypesQueryDsl.GeoShapeQuery
        | HasChild of TypesQueryDsl.HasChildQuery
        | HasParent of TypesQueryDsl.HasParentQuery
        | Ids of TypesQueryDsl.IdsQuery
        | Intervals of field: string * TypesQueryDsl.IntervalsQuery
        | Knn of Types.KnnQuery
        | Match of field: string * TypesQueryDsl.MatchQuery
        | MatchAll of TypesQueryDsl.MatchAllQuery
        | MatchBoolPrefix of field: string * TypesQueryDsl.MatchBoolPrefixQuery
        | MatchNone of TypesQueryDsl.MatchNoneQuery
        | MatchPhrase of field: string * TypesQueryDsl.MatchPhraseQuery
        | MatchPhrasePrefix of field: string * TypesQueryDsl.MatchPhrasePrefixQuery
        | MoreLikeThis of TypesQueryDsl.MoreLikeThisQuery
        | MultiMatch of TypesQueryDsl.MultiMatchQuery
        | Nested of TypesQueryDsl.NestedQuery
        | ParentId of TypesQueryDsl.ParentIdQuery
        | Percolate of TypesQueryDsl.PercolateQuery
        | Pinned of TypesQueryDsl.PinnedQuery
        | Prefix of field: string * TypesQueryDsl.PrefixQuery
        | QueryString of TypesQueryDsl.QueryStringQuery
        | Range of field: string * TypesQueryDsl.RangeQuery
        | RankFeature of TypesQueryDsl.RankFeatureQuery
        | Regexp of field: string * TypesQueryDsl.RegexpQuery
        | Rule of TypesQueryDsl.RuleQuery
        | Script of TypesQueryDsl.ScriptQuery
        | ScriptScore of TypesQueryDsl.ScriptScoreQuery
        | Semantic of TypesQueryDsl.SemanticQuery
        | Shape of TypesQueryDsl.ShapeQuery
        | SimpleQueryString of TypesQueryDsl.SimpleQueryStringQuery
        | SpanContaining of TypesQueryDsl.SpanContainingQuery
        | SpanFieldMasking of TypesQueryDsl.SpanFieldMaskingQuery
        | SpanFirst of TypesQueryDsl.SpanFirstQuery
        | SpanMulti of TypesQueryDsl.SpanMultiTermQuery
        | SpanNear of TypesQueryDsl.SpanNearQuery
        | SpanNot of TypesQueryDsl.SpanNotQuery
        | SpanOr of TypesQueryDsl.SpanOrQuery
        | SpanTerm of field: string * TypesQueryDsl.SpanTermQuery
        | SpanWithin of TypesQueryDsl.SpanWithinQuery
        | SparseVector of TypesQueryDsl.SparseVectorQuery
        | Term of field: string * TypesQueryDsl.TermQuery
        | Terms of TypesQueryDsl.TermsQuery
        | TermsSet of field: string * TypesQueryDsl.TermsSetQuery
        | TextExpansion of field: string * TypesQueryDsl.TextExpansionQuery
        | WeightedTokens of field: string * TypesQueryDsl.WeightedTokensQuery
        | Wildcard of field: string * TypesQueryDsl.WildcardQuery
        | Wrapper of TypesQueryDsl.WrapperQuery
        | Type of TypesQueryDsl.TypeQuery
        | Unknown of name: string * System.Text.Json.JsonElement

    and BoostingQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("negative_boost")>]
        NegativeBoost: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("negative")>]
        Negative: TypesQueryDsl.QueryContainer
        [<System.Text.Json.Serialization.JsonPropertyName("positive")>]
        Positive: TypesQueryDsl.QueryContainer
    }

    and ConstantScoreQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: TypesQueryDsl.QueryContainer
    }

    and DisMaxQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("queries")>]
        Queries: TypesQueryDsl.QueryContainer list
        [<System.Text.Json.Serialization.JsonPropertyName("tie_breaker")>]
        TieBreaker: Types.Double option
    }

    and FunctionScoreQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("boost_mode")>]
        BoostMode: TypesQueryDsl.FunctionBoostMode option
        [<System.Text.Json.Serialization.JsonPropertyName("functions")>]
        Functions: TypesQueryDsl.FunctionScoreContainer list option
        [<System.Text.Json.Serialization.JsonPropertyName("max_boost")>]
        MaxBoost: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("min_score")>]
        MinScore: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: TypesQueryDsl.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("score_mode")>]
        ScoreMode: TypesQueryDsl.FunctionScoreMode option
    }

    [<RequireQualifiedAccess>]
    and FunctionScoreContainer =
        | Exp of TypesQueryDsl.DecayFunction
        | Gauss of TypesQueryDsl.DecayFunction
        | Linear of TypesQueryDsl.DecayFunction
        | FieldValueFactor of TypesQueryDsl.FieldValueFactorScoreFunction
        | RandomScore of TypesQueryDsl.RandomScoreFunction
        | ScriptScore of TypesQueryDsl.ScriptScoreFunction

    and FunctionScoreContainerMeta = {
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: TypesQueryDsl.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("weight")>]
        Weight: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("_name")>]
        Name: string option
    }

    and HasChildQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unmapped")>]
        IgnoreUnmapped: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("inner_hits")>]
        InnerHits: GlobalSearchTypes.InnerHits option
        [<System.Text.Json.Serialization.JsonPropertyName("max_children")>]
        MaxChildren: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_children")>]
        MinChildren: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: TypesQueryDsl.QueryContainer
        [<System.Text.Json.Serialization.JsonPropertyName("score_mode")>]
        ScoreMode: TypesQueryDsl.ChildScoreMode option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: Types.RelationName
    }

    and HasParentQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unmapped")>]
        IgnoreUnmapped: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("inner_hits")>]
        InnerHits: GlobalSearchTypes.InnerHits option
        [<System.Text.Json.Serialization.JsonPropertyName("parent_type")>]
        ParentType: Types.RelationName
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: TypesQueryDsl.QueryContainer
        [<System.Text.Json.Serialization.JsonPropertyName("score")>]
        Score: bool option
    }

    and NestedQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unmapped")>]
        IgnoreUnmapped: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("inner_hits")>]
        InnerHits: GlobalSearchTypes.InnerHits option
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: TypesQueryDsl.QueryContainer
        [<System.Text.Json.Serialization.JsonPropertyName("score_mode")>]
        ScoreMode: TypesQueryDsl.ChildScoreMode option
    }

    [<RequireQualifiedAccess>]
    and PinnedQuery =
        | Ids of Types.Id list
        | Docs of TypesQueryDsl.PinnedDoc list

    and PinnedQueryMeta = {
        [<System.Text.Json.Serialization.JsonPropertyName("organic")>]
        Organic: TypesQueryDsl.QueryContainer
    }

    and RuleQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("organic")>]
        Organic: TypesQueryDsl.QueryContainer
        [<System.Text.Json.Serialization.JsonPropertyName("ruleset_ids")>]
        RulesetIds: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("ruleset_id")>]
        RulesetId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("match_criteria")>]
        MatchCriteria: System.Text.Json.JsonElement
    }

    and ScriptScoreQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("min_score")>]
        MinScore: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: TypesQueryDsl.QueryContainer
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script
    }

    and SpanContainingQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("big")>]
        Big: TypesQueryDsl.SpanQuery
        [<System.Text.Json.Serialization.JsonPropertyName("little")>]
        Little: TypesQueryDsl.SpanQuery
    }

    [<RequireQualifiedAccess>]
    and SpanQuery =
        | SpanContaining of TypesQueryDsl.SpanContainingQuery
        | SpanFieldMasking of TypesQueryDsl.SpanFieldMaskingQuery
        | SpanFirst of TypesQueryDsl.SpanFirstQuery
        | SpanGap of TypesQueryDsl.SpanGapQuery
        | SpanMulti of TypesQueryDsl.SpanMultiTermQuery
        | SpanNear of TypesQueryDsl.SpanNearQuery
        | SpanNot of TypesQueryDsl.SpanNotQuery
        | SpanOr of TypesQueryDsl.SpanOrQuery
        | SpanTerm of field: string * TypesQueryDsl.SpanTermQuery
        | SpanWithin of TypesQueryDsl.SpanWithinQuery
        | Unknown of name: string * System.Text.Json.JsonElement

    and SpanFieldMaskingQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: TypesQueryDsl.SpanQuery
    }

    and SpanFirstQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("end")>]
        End: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("match")>]
        Match: TypesQueryDsl.SpanQuery
    }

    and SpanMultiTermQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("match")>]
        Match: TypesQueryDsl.QueryContainer
    }

    and SpanNearQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("clauses")>]
        Clauses: TypesQueryDsl.SpanQuery list
        [<System.Text.Json.Serialization.JsonPropertyName("in_order")>]
        InOrder: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("slop")>]
        Slop: Types.Integer option
    }

    and SpanNotQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("dist")>]
        Dist: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("exclude")>]
        Exclude: TypesQueryDsl.SpanQuery
        [<System.Text.Json.Serialization.JsonPropertyName("include")>]
        Include: TypesQueryDsl.SpanQuery
        [<System.Text.Json.Serialization.JsonPropertyName("post")>]
        Post: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("pre")>]
        Pre: Types.Integer option
    }

    and SpanOrQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("clauses")>]
        Clauses: TypesQueryDsl.SpanQuery list
    }

    and SpanWithinQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("big")>]
        Big: TypesQueryDsl.SpanQuery
        [<System.Text.Json.Serialization.JsonPropertyName("little")>]
        Little: TypesQueryDsl.SpanQuery
    }

    type DecayPlacement<'tOrigin, 'tScale> = {
        [<System.Text.Json.Serialization.JsonPropertyName("decay")>]
        Decay: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("offset")>]
        Offset: 'tScale option
        [<System.Text.Json.Serialization.JsonPropertyName("scale")>]
        Scale: 'tScale option
        [<System.Text.Json.Serialization.JsonPropertyName("origin")>]
        Origin: 'tOrigin option
    }

    /// A reference to a field with formatting instructions on how to return the value
    type FieldAndFormat = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("include_unmapped")>]
        IncludeUnmapped: bool option
    }

    type FieldLookup = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: string option
    }

    type GeoPolygonPoints = {
        [<System.Text.Json.Serialization.JsonPropertyName("points")>]
        Points: Types.GeoLocation list
    }

    type GeoShapeFieldQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("shape")>]
        Shape: Types.GeoShape option
        [<System.Text.Json.Serialization.JsonPropertyName("indexed_shape")>]
        IndexedShape: TypesQueryDsl.FieldLookup option
        [<System.Text.Json.Serialization.JsonPropertyName("relation")>]
        Relation: Types.GeoShapeRelation option
    }

    type ShapeFieldQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("indexed_shape")>]
        IndexedShape: TypesQueryDsl.FieldLookup option
        [<System.Text.Json.Serialization.JsonPropertyName("relation")>]
        Relation: Types.GeoShapeRelation option
        [<System.Text.Json.Serialization.JsonPropertyName("shape")>]
        Shape: Types.GeoShape option
    }

    type TermsLookup = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: string option
    }

    [<RequireQualifiedAccess>]
    type TermsQueryField =
        | Array of Types.FieldValue list
        | TermsLookup of TypesQueryDsl.TermsLookup


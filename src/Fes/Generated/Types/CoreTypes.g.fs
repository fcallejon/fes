// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CoreTypes =

    type Double = float

    type Integer = float

    type AbstractChangePoint = {
        [<System.Text.Json.Serialization.JsonPropertyName("p_value")>]
        PValue: Double
        [<System.Text.Json.Serialization.JsonPropertyName("change_point")>]
        ChangePoint: Integer
    }

    type AcknowledgedResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("acknowledged")>]
        Acknowledged: bool
    }

    /// In some places in the specification an object consists of the union of a set of known properties
    type AdditionalProperties<'tKey, 'tValue> = System.Text.Json.JsonElement

    /// In some places in the specification an object consists of a static set of properties and a single additional property
    type AdditionalProperty<'tKey, 'tValue> = System.Text.Json.JsonElement

    /// Aggregation buckets. By default they are returned as an array, but if the aggregation has keys configured for
    [<RequireQualifiedAccess>]
    type Buckets<'tBucket> =
        | Dictionary of Map<string, 'tBucket>
        | Array of 'tBucket list

    type Metadata = Map<string, System.Text.Json.JsonElement>

    type AggregateBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("meta")>]
        Meta: Metadata option
    }

    type MultiBucketAggregateBase<'tBucket> = {
        [<System.Text.Json.Serialization.JsonPropertyName("buckets")>]
        Buckets: Buckets<'tBucket>
    }

    type Long = float

    /// Base type for multi-bucket aggregation results that can hold sub-aggregations results.
    type MultiBucketBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc_count")>]
        DocCount: Long
    }

    type AdjacencyMatrixBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: string
    }

    type AdjacencyMatrixAggregate = System.Text.Json.JsonElement

    /// The minimum number of terms that should match as integer, percentage or range
    [<RequireQualifiedAccess>]
    type MinimumShouldMatch =
        | Integer of Integer
        | String of string

    type Float = float

    type QueryBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Float option
        [<System.Text.Json.Serialization.JsonPropertyName("_name")>]
        Name: string option
    }

    /// Path to field or array of paths. Some API's support wildcards in the path to select multiple fields.
    type Field = string

    [<RequireQualifiedAccess>]
    type Operator =
        | And
        | Or

    type CommonTermsQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("cutoff_frequency")>]
        CutoffFrequency: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("high_freq_operator")>]
        HighFreqOperator: Operator option
        [<System.Text.Json.Serialization.JsonPropertyName("low_freq_operator")>]
        LowFreqOperator: Operator option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_should_match")>]
        MinimumShouldMatch: MinimumShouldMatch option
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
        Fields: Field list
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
        [<System.Text.Json.Serialization.JsonPropertyName("auto_generate_synonyms_phrase_query")>]
        AutoGenerateSynonymsPhraseQuery: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("operator")>]
        Operator: CombinedFieldsOperator option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_should_match")>]
        MinimumShouldMatch: MinimumShouldMatch option
        [<System.Text.Json.Serialization.JsonPropertyName("zero_terms_query")>]
        ZeroTermsQuery: CombinedFieldsZeroTerms option
    }

    type DistanceFeatureQueryBase<'tOrigin, 'tDistance> = {
        [<System.Text.Json.Serialization.JsonPropertyName("origin")>]
        Origin: 'tOrigin
        [<System.Text.Json.Serialization.JsonPropertyName("pivot")>]
        Pivot: 'tDistance
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field
    }

    type UntypedDistanceFeatureQuery = System.Text.Json.JsonElement

    type LatLonGeoLocation = {
        [<System.Text.Json.Serialization.JsonPropertyName("lat")>]
        Lat: Double
        [<System.Text.Json.Serialization.JsonPropertyName("lon")>]
        Lon: Double
    }

    type GeoHash = string

    type GeoHashLocation = {
        [<System.Text.Json.Serialization.JsonPropertyName("geohash")>]
        Geohash: GeoHash
    }

    /// A latitude/longitude as a 2 dimensional point. It can be represented in various ways:
    [<RequireQualifiedAccess>]
    type GeoLocation =
        | LatLonGeoLocation of LatLonGeoLocation
        | GeoHashLocation of GeoHashLocation
        | Array of Double list
        | String of string

    type Distance = string

    type GeoDistanceFeatureQuery = System.Text.Json.JsonElement

    type DateMath = string

    /// A duration. Units can be `nanos`, `micros`, `ms` (milliseconds), `s` (seconds), `m` (minutes), `h` (hours) and
    [<RequireQualifiedAccess>]
    type Duration =
        | String of string
        | Case1 of string
        | Case2 of string

    type DateDistanceFeatureQuery = System.Text.Json.JsonElement

    [<RequireQualifiedAccess>]
    type DistanceFeatureQuery =
        | UntypedDistanceFeatureQuery of UntypedDistanceFeatureQuery
        | GeoDistanceFeatureQuery of GeoDistanceFeatureQuery
        | DateDistanceFeatureQuery of DateDistanceFeatureQuery

    type ExistsQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field
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
        MultiValueMode: MultiValueMode option
    }

    type UntypedDecayFunction = System.Text.Json.JsonElement

    type DateDecayFunction = System.Text.Json.JsonElement

    type NumericDecayFunction = System.Text.Json.JsonElement

    type GeoDecayFunction = System.Text.Json.JsonElement

    [<RequireQualifiedAccess>]
    type DecayFunction =
        | UntypedDecayFunction of UntypedDecayFunction
        | DateDecayFunction of DateDecayFunction
        | NumericDecayFunction of NumericDecayFunction
        | GeoDecayFunction of GeoDecayFunction

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
        Field: Field
        [<System.Text.Json.Serialization.JsonPropertyName("factor")>]
        Factor: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("modifier")>]
        Modifier: FieldValueFactorModifier option
    }

    type RandomScoreFunction = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("seed")>]
        Seed: System.Text.Json.JsonElement option
    }

    [<RequireQualifiedAccess>]
    type ScriptSource =
        | String of string
        | SearchRequestBody of GlobalSearchTypes.SearchRequestBody

    type Id = string

    [<RequireQualifiedAccess>]
    type ScriptLanguage =
        | Painless
        | Expression
        | Mustache
        | Java
        | Custom of string

    type Script = {
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: ScriptSource option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Id option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("lang")>]
        Lang: ScriptLanguage option
        [<System.Text.Json.Serialization.JsonPropertyName("options")>]
        Options: Map<string, string> option
    }

    type ScriptScoreFunction = {
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script
    }

    [<RequireQualifiedAccess>]
    type FunctionScoreMode =
        | Multiply
        | Sum
        | Avg
        | First
        | Max
        | Min

    type MultiTermQueryRewrite = string

    [<RequireQualifiedAccess>]
    type Fuzziness =
        | String of string
        | Integer of Integer

    type FuzzyQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_expansions")>]
        MaxExpansions: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix_length")>]
        PrefixLength: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("rewrite")>]
        Rewrite: MultiTermQueryRewrite option
        [<System.Text.Json.Serialization.JsonPropertyName("transpositions")>]
        Transpositions: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzziness")>]
        Fuzziness: Fuzziness option
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
        Type: GeoExecution option
        [<System.Text.Json.Serialization.JsonPropertyName("validation_method")>]
        ValidationMethod: GeoValidationMethod option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unmapped")>]
        IgnoreUnmapped: bool option
    }

    [<RequireQualifiedAccess>]
    type GeoDistanceType =
        | Arc
        | Plane

    type GeoDistanceQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("distance")>]
        Distance: Distance
        [<System.Text.Json.Serialization.JsonPropertyName("distance_type")>]
        DistanceType: GeoDistanceType option
        [<System.Text.Json.Serialization.JsonPropertyName("validation_method")>]
        ValidationMethod: GeoValidationMethod option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unmapped")>]
        IgnoreUnmapped: bool option
    }

    /// A map tile reference, represented as `{zoom}/{x}/{y}`
    type GeoTile = string

    /// A map hex cell (H3) reference
    type GeoHexCell = string

    [<RequireQualifiedAccess>]
    type GeoGridQuery =
        | Geotile of GeoTile
        | Geohash of GeoHash
        | Geohex of GeoHexCell

    type GeoPolygonQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("validation_method")>]
        ValidationMethod: GeoValidationMethod option
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

    type RelationName = string

    [<RequireQualifiedAccess>]
    type Ids =
        | Id of Id
        | Array of Id list

    type IdsQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("values")>]
        Values: Ids option
    }

    type IntervalsFuzzy = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzziness")>]
        Fuzziness: Fuzziness option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix_length")>]
        PrefixLength: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("term")>]
        Term: string
        [<System.Text.Json.Serialization.JsonPropertyName("transpositions")>]
        Transpositions: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("use_field")>]
        UseField: Field option
    }

    type IntervalsPrefix = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix")>]
        Prefix: string
        [<System.Text.Json.Serialization.JsonPropertyName("use_field")>]
        UseField: Field option
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
        UseField: Field option
    }

    type IntervalsRegexp = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pattern")>]
        Pattern: string
        [<System.Text.Json.Serialization.JsonPropertyName("use_field")>]
        UseField: Field option
    }

    type IntervalsWildcard = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pattern")>]
        Pattern: string
        [<System.Text.Json.Serialization.JsonPropertyName("use_field")>]
        UseField: Field option
    }

    type IntervalsAllOf = {
        [<System.Text.Json.Serialization.JsonPropertyName("intervals")>]
        Intervals: IntervalsContainer list
        [<System.Text.Json.Serialization.JsonPropertyName("max_gaps")>]
        MaxGaps: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("ordered")>]
        Ordered: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: IntervalsFilter option
    }

    and [<RequireQualifiedAccess>] IntervalsContainer =
        | AllOf of IntervalsAllOf
        | AnyOf of IntervalsAnyOf
        | Fuzzy of IntervalsFuzzy
        | Match of IntervalsMatch
        | Prefix of IntervalsPrefix
        | Range of IntervalsRange
        | Regexp of IntervalsRegexp
        | Wildcard of IntervalsWildcard

    and IntervalsAnyOf = {
        [<System.Text.Json.Serialization.JsonPropertyName("intervals")>]
        Intervals: IntervalsContainer list
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: IntervalsFilter option
    }

    and [<RequireQualifiedAccess>] IntervalsFilter =
        | After of IntervalsContainer
        | Before of IntervalsContainer
        | ContainedBy of IntervalsContainer
        | Containing of IntervalsContainer
        | NotContainedBy of IntervalsContainer
        | NotContaining of IntervalsContainer
        | NotOverlapping of IntervalsContainer
        | Overlapping of IntervalsContainer
        | Script of Script

    and IntervalsMatch = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_gaps")>]
        MaxGaps: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("ordered")>]
        Ordered: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
        [<System.Text.Json.Serialization.JsonPropertyName("use_field")>]
        UseField: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: IntervalsFilter option
    }

    [<RequireQualifiedAccess>]
    type IntervalsQuery =
        | AllOf of IntervalsAllOf
        | AnyOf of IntervalsAnyOf
        | Fuzzy of IntervalsFuzzy
        | Match of IntervalsMatch
        | Prefix of IntervalsPrefix
        | Range of IntervalsRange
        | Regexp of IntervalsRegexp
        | Wildcard of IntervalsWildcard

    type QueryVector = Float list

    type TextEmbedding = {
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model_text")>]
        ModelText: string
    }

    type LookupQueryVectorBuilder = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: string
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: string
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: string
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: string option
    }

    [<RequireQualifiedAccess>]
    type QueryVectorBuilder =
        | TextEmbedding of TextEmbedding
        | Lookup of LookupQueryVectorBuilder

    type RescoreVector = {
        [<System.Text.Json.Serialization.JsonPropertyName("oversample")>]
        Oversample: Float
    }

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
        CutoffFrequency: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzziness")>]
        Fuzziness: Fuzziness option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_rewrite")>]
        FuzzyRewrite: MultiTermQueryRewrite option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_transpositions")>]
        FuzzyTranspositions: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("lenient")>]
        Lenient: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("max_expansions")>]
        MaxExpansions: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_should_match")>]
        MinimumShouldMatch: MinimumShouldMatch option
        [<System.Text.Json.Serialization.JsonPropertyName("operator")>]
        Operator: Operator option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix_length")>]
        PrefixLength: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("zero_terms_query")>]
        ZeroTermsQuery: ZeroTermsQuery option
    }

    type MatchAllQuery = System.Text.Json.JsonElement

    type MatchBoolPrefixQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzziness")>]
        Fuzziness: Fuzziness option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_rewrite")>]
        FuzzyRewrite: MultiTermQueryRewrite option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_transpositions")>]
        FuzzyTranspositions: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("max_expansions")>]
        MaxExpansions: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_should_match")>]
        MinimumShouldMatch: MinimumShouldMatch option
        [<System.Text.Json.Serialization.JsonPropertyName("operator")>]
        Operator: Operator option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix_length")>]
        PrefixLength: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
    }

    type MatchNoneQuery = System.Text.Json.JsonElement

    type MatchPhraseQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
        [<System.Text.Json.Serialization.JsonPropertyName("slop")>]
        Slop: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("zero_terms_query")>]
        ZeroTermsQuery: ZeroTermsQuery option
    }

    type MatchPhrasePrefixQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_expansions")>]
        MaxExpansions: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
        [<System.Text.Json.Serialization.JsonPropertyName("slop")>]
        Slop: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("zero_terms_query")>]
        ZeroTermsQuery: ZeroTermsQuery option
    }

    type IndexName = string

    /// Only to be used in query and path parameters, as the array form is actually a csv
    [<RequireQualifiedAccess>]
    type Routing =
        | String of string
        | Array of string list

    type VersionNumber = Long

    [<RequireQualifiedAccess>]
    type VersionType =
        | Internal
        | External
        | ExternalGte

    type LikeDocument = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc")>]
        Doc: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Field list option
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: Id option
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("per_field_analyzer")>]
        PerFieldAnalyzer: Map<Field, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: Routing option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("version_type")>]
        VersionType: VersionType option
    }

    /// Text that we want similar documents for or a lookup to a document's field for the text.
    [<RequireQualifiedAccess>]
    type Like =
        | String of string
        | LikeDocument of LikeDocument

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
        | StopWordLanguage of StopWordLanguage
        | Array of string list

    type MoreLikeThisQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("boost_terms")>]
        BoostTerms: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("fail_on_unsupported_field")>]
        FailOnUnsupportedField: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Field list option
        [<System.Text.Json.Serialization.JsonPropertyName("include")>]
        Include: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("like")>]
        Like: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("max_doc_freq")>]
        MaxDocFreq: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_query_terms")>]
        MaxQueryTerms: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_word_length")>]
        MaxWordLength: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_freq")>]
        MinDocFreq: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_should_match")>]
        MinimumShouldMatch: MinimumShouldMatch option
        [<System.Text.Json.Serialization.JsonPropertyName("min_term_freq")>]
        MinTermFreq: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_word_length")>]
        MinWordLength: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stop_words")>]
        StopWords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("unlike")>]
        Unlike: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("version_type")>]
        VersionType: VersionType option
    }

    [<RequireQualifiedAccess>]
    type Fields =
        | Field of Field
        | Array of Field list

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
        CutoffFrequency: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzziness")>]
        Fuzziness: Fuzziness option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_rewrite")>]
        FuzzyRewrite: MultiTermQueryRewrite option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_transpositions")>]
        FuzzyTranspositions: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("lenient")>]
        Lenient: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("max_expansions")>]
        MaxExpansions: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_should_match")>]
        MinimumShouldMatch: MinimumShouldMatch option
        [<System.Text.Json.Serialization.JsonPropertyName("operator")>]
        Operator: Operator option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix_length")>]
        PrefixLength: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
        [<System.Text.Json.Serialization.JsonPropertyName("slop")>]
        Slop: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("tie_breaker")>]
        TieBreaker: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: TextQueryType option
        [<System.Text.Json.Serialization.JsonPropertyName("zero_terms_query")>]
        ZeroTermsQuery: ZeroTermsQuery option
    }

    type ParentIdQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Id option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unmapped")>]
        IgnoreUnmapped: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: RelationName option
    }

    type PercolateQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("document")>]
        Document: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("documents")>]
        Documents: System.Text.Json.JsonElement list option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Id option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string option
        [<System.Text.Json.Serialization.JsonPropertyName("preference")>]
        Preference: string option
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: string option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: VersionNumber option
    }

    type PinnedDoc = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: Id
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: IndexName option
    }

    type PrefixQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("rewrite")>]
        Rewrite: MultiTermQueryRewrite option
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: string
        [<System.Text.Json.Serialization.JsonPropertyName("case_insensitive")>]
        CaseInsensitive: bool option
    }

    type TimeZone = string

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
        DefaultField: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("default_operator")>]
        DefaultOperator: Operator option
        [<System.Text.Json.Serialization.JsonPropertyName("enable_position_increments")>]
        EnablePositionIncrements: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("escape")>]
        Escape: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Field list option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzziness")>]
        Fuzziness: Fuzziness option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_max_expansions")>]
        FuzzyMaxExpansions: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_prefix_length")>]
        FuzzyPrefixLength: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_rewrite")>]
        FuzzyRewrite: MultiTermQueryRewrite option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_transpositions")>]
        FuzzyTranspositions: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("lenient")>]
        Lenient: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("max_determinized_states")>]
        MaxDeterminizedStates: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_should_match")>]
        MinimumShouldMatch: MinimumShouldMatch option
        [<System.Text.Json.Serialization.JsonPropertyName("phrase_slop")>]
        PhraseSlop: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
        [<System.Text.Json.Serialization.JsonPropertyName("quote_analyzer")>]
        QuoteAnalyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("quote_field_suffix")>]
        QuoteFieldSuffix: string option
        [<System.Text.Json.Serialization.JsonPropertyName("rewrite")>]
        Rewrite: MultiTermQueryRewrite option
        [<System.Text.Json.Serialization.JsonPropertyName("tie_breaker")>]
        TieBreaker: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("time_zone")>]
        TimeZone: TimeZone option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: TextQueryType option
    }

    type DateFormat = string

    [<RequireQualifiedAccess>]
    type RangeRelation =
        | Within
        | Contains
        | Intersects

    type RangeQueryBase<'t> = {
        [<System.Text.Json.Serialization.JsonPropertyName("relation")>]
        Relation: RangeRelation option
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
        Format: DateFormat option
        [<System.Text.Json.Serialization.JsonPropertyName("time_zone")>]
        TimeZone: TimeZone option
    }

    type DateRangeQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: DateFormat option
        [<System.Text.Json.Serialization.JsonPropertyName("time_zone")>]
        TimeZone: TimeZone option
    }

    type NumberRangeQuery = System.Text.Json.JsonElement

    type TermRangeQuery = System.Text.Json.JsonElement

    [<RequireQualifiedAccess>]
    type RangeQuery =
        | UntypedRangeQuery of UntypedRangeQuery
        | DateRangeQuery of DateRangeQuery
        | NumberRangeQuery of NumberRangeQuery
        | TermRangeQuery of TermRangeQuery

    type RankFeatureFunction = System.Text.Json.JsonElement

    type RankFeatureFunctionSaturation = {
        [<System.Text.Json.Serialization.JsonPropertyName("pivot")>]
        Pivot: Float option
    }

    type RankFeatureFunctionLogarithm = {
        [<System.Text.Json.Serialization.JsonPropertyName("scaling_factor")>]
        ScalingFactor: Float
    }

    type RankFeatureFunctionLinear = System.Text.Json.JsonElement

    type RankFeatureFunctionSigmoid = {
        [<System.Text.Json.Serialization.JsonPropertyName("pivot")>]
        Pivot: Float
        [<System.Text.Json.Serialization.JsonPropertyName("exponent")>]
        Exponent: Float
    }

    type RankFeatureQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field
        [<System.Text.Json.Serialization.JsonPropertyName("saturation")>]
        Saturation: RankFeatureFunctionSaturation option
        [<System.Text.Json.Serialization.JsonPropertyName("log")>]
        Log: RankFeatureFunctionLogarithm option
        [<System.Text.Json.Serialization.JsonPropertyName("linear")>]
        Linear: RankFeatureFunctionLinear option
        [<System.Text.Json.Serialization.JsonPropertyName("sigmoid")>]
        Sigmoid: RankFeatureFunctionSigmoid option
    }

    type RegexpQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("case_insensitive")>]
        CaseInsensitive: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("flags")>]
        Flags: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_determinized_states")>]
        MaxDeterminizedStates: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("rewrite")>]
        Rewrite: MultiTermQueryRewrite option
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: string
    }

    type ScriptQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script
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

    /// A set of flags that can be represented as a single enum value or a set of values that are encoded
    [<RequireQualifiedAccess>]
    type PipeSeparatedFlags<'t> =
        | T of 't
        | String of string

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
    type SimpleQueryStringFlags = PipeSeparatedFlags<SimpleQueryStringFlag>

    type SimpleQueryStringQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("analyze_wildcard")>]
        AnalyzeWildcard: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("auto_generate_synonyms_phrase_query")>]
        AutoGenerateSynonymsPhraseQuery: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("default_operator")>]
        DefaultOperator: Operator option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Field list option
        [<System.Text.Json.Serialization.JsonPropertyName("flags")>]
        Flags: SimpleQueryStringFlags option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_max_expansions")>]
        FuzzyMaxExpansions: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_prefix_length")>]
        FuzzyPrefixLength: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("fuzzy_transpositions")>]
        FuzzyTranspositions: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("lenient")>]
        Lenient: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_should_match")>]
        MinimumShouldMatch: MinimumShouldMatch option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
        [<System.Text.Json.Serialization.JsonPropertyName("quote_field_suffix")>]
        QuoteFieldSuffix: string option
    }

    /// Can only be used as a clause in a span_near query.
    type SpanGapQuery = Map<Field, Integer>

    /// A field value.
    [<RequireQualifiedAccess>]
    type FieldValue =
        | Long of Long
        | Double of Double
        | String of string
        | Boolean of bool
        | Null of unit

    type SpanTermQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: FieldValue
    }

    type TokenPruningConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("tokens_freq_ratio_threshold")>]
        TokensFreqRatioThreshold: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("tokens_weight_threshold")>]
        TokensWeightThreshold: Float option
        [<System.Text.Json.Serialization.JsonPropertyName("only_score_pruned_tokens")>]
        OnlyScorePrunedTokens: bool option
    }

    [<RequireQualifiedAccess>]
    type SparseVectorQuery =
        | QueryVector of Map<string, Float>
        | InferenceId of Id

    and SparseVectorQueryMeta = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string option
        [<System.Text.Json.Serialization.JsonPropertyName("prune")>]
        Prune: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("pruning_config")>]
        PruningConfig: TokenPruningConfig option
    }

    type TermQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: FieldValue
        [<System.Text.Json.Serialization.JsonPropertyName("case_insensitive")>]
        CaseInsensitive: bool option
    }

    type TermsQuery = System.Text.Json.JsonElement

    type TermsSetQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_should_match")>]
        MinimumShouldMatch: MinimumShouldMatch option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_should_match_field")>]
        MinimumShouldMatchField: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_should_match_script")>]
        MinimumShouldMatchScript: Script option
        [<System.Text.Json.Serialization.JsonPropertyName("terms")>]
        Terms: FieldValue list
    }

    type TextExpansionQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: string
        [<System.Text.Json.Serialization.JsonPropertyName("model_text")>]
        ModelText: string
        [<System.Text.Json.Serialization.JsonPropertyName("pruning_config")>]
        PruningConfig: TokenPruningConfig option
    }

    type WeightedTokensQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("tokens")>]
        Tokens: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("pruning_config")>]
        PruningConfig: TokenPruningConfig option
    }

    type WildcardQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("case_insensitive")>]
        CaseInsensitive: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("rewrite")>]
        Rewrite: MultiTermQueryRewrite option
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

    /// An Elasticsearch Query DSL (Domain Specific Language) object that defines a query.
    [<RequireQualifiedAccess>]
    type QueryContainer =
        | Bool of BoolQuery
        | Boosting of BoostingQuery
        | Common of field: string * CommonTermsQuery
        | CombinedFields of CombinedFieldsQuery
        | ConstantScore of ConstantScoreQuery
        | DisMax of DisMaxQuery
        | DistanceFeature of DistanceFeatureQuery
        | Exists of ExistsQuery
        | FunctionScore of FunctionScoreQuery
        | Fuzzy of field: string * FuzzyQuery
        | GeoBoundingBox of GeoBoundingBoxQuery
        | GeoDistance of GeoDistanceQuery
        | GeoGrid of field: string * GeoGridQuery
        | GeoPolygon of GeoPolygonQuery
        | GeoShape of GeoShapeQuery
        | HasChild of HasChildQuery
        | HasParent of HasParentQuery
        | Ids of IdsQuery
        | Intervals of field: string * IntervalsQuery
        | Knn of KnnQuery
        | Match of field: string * MatchQuery
        | MatchAll of MatchAllQuery
        | MatchBoolPrefix of field: string * MatchBoolPrefixQuery
        | MatchNone of MatchNoneQuery
        | MatchPhrase of field: string * MatchPhraseQuery
        | MatchPhrasePrefix of field: string * MatchPhrasePrefixQuery
        | MoreLikeThis of MoreLikeThisQuery
        | MultiMatch of MultiMatchQuery
        | Nested of NestedQuery
        | ParentId of ParentIdQuery
        | Percolate of PercolateQuery
        | Pinned of PinnedQuery
        | Prefix of field: string * PrefixQuery
        | QueryString of QueryStringQuery
        | Range of field: string * RangeQuery
        | RankFeature of RankFeatureQuery
        | Regexp of field: string * RegexpQuery
        | Rule of RuleQuery
        | Script of ScriptQuery
        | ScriptScore of ScriptScoreQuery
        | Semantic of SemanticQuery
        | Shape of ShapeQuery
        | SimpleQueryString of SimpleQueryStringQuery
        | SpanContaining of SpanContainingQuery
        | SpanFieldMasking of SpanFieldMaskingQuery
        | SpanFirst of SpanFirstQuery
        | SpanMulti of SpanMultiTermQuery
        | SpanNear of SpanNearQuery
        | SpanNot of SpanNotQuery
        | SpanOr of SpanOrQuery
        | SpanTerm of field: string * SpanTermQuery
        | SpanWithin of SpanWithinQuery
        | SparseVector of SparseVectorQuery
        | Term of field: string * TermQuery
        | Terms of TermsQuery
        | TermsSet of field: string * TermsSetQuery
        | TextExpansion of field: string * TextExpansionQuery
        | WeightedTokens of field: string * WeightedTokensQuery
        | Wildcard of field: string * WildcardQuery
        | Wrapper of WrapperQuery
        | Type of TypeQuery
        | Unknown of name: string * System.Text.Json.JsonElement

    and BoolQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_should_match")>]
        MinimumShouldMatch: MinimumShouldMatch option
        [<System.Text.Json.Serialization.JsonPropertyName("must")>]
        Must: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("must_not")>]
        MustNot: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("should")>]
        Should: System.Text.Json.JsonElement option
    }

    and BoostingQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("negative_boost")>]
        NegativeBoost: Double
        [<System.Text.Json.Serialization.JsonPropertyName("negative")>]
        Negative: QueryContainer
        [<System.Text.Json.Serialization.JsonPropertyName("positive")>]
        Positive: QueryContainer
    }

    and ConstantScoreQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: QueryContainer
    }

    and DisMaxQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("queries")>]
        Queries: QueryContainer list
        [<System.Text.Json.Serialization.JsonPropertyName("tie_breaker")>]
        TieBreaker: Double option
    }

    and FunctionScoreQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("boost_mode")>]
        BoostMode: FunctionBoostMode option
        [<System.Text.Json.Serialization.JsonPropertyName("functions")>]
        Functions: FunctionScoreContainer list option
        [<System.Text.Json.Serialization.JsonPropertyName("max_boost")>]
        MaxBoost: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("min_score")>]
        MinScore: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("score_mode")>]
        ScoreMode: FunctionScoreMode option
    }

    and [<RequireQualifiedAccess>] FunctionScoreContainer =
        | Exp of DecayFunction
        | Gauss of DecayFunction
        | Linear of DecayFunction
        | FieldValueFactor of FieldValueFactorScoreFunction
        | RandomScore of RandomScoreFunction
        | ScriptScore of ScriptScoreFunction

    and FunctionScoreContainerMeta = {
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("weight")>]
        Weight: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("_name")>]
        Name: string option
    }

    and HasChildQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unmapped")>]
        IgnoreUnmapped: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("inner_hits")>]
        InnerHits: GlobalSearchTypes.InnerHits option
        [<System.Text.Json.Serialization.JsonPropertyName("max_children")>]
        MaxChildren: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_children")>]
        MinChildren: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: QueryContainer
        [<System.Text.Json.Serialization.JsonPropertyName("score_mode")>]
        ScoreMode: ChildScoreMode option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: RelationName
    }

    and HasParentQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unmapped")>]
        IgnoreUnmapped: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("inner_hits")>]
        InnerHits: GlobalSearchTypes.InnerHits option
        [<System.Text.Json.Serialization.JsonPropertyName("parent_type")>]
        ParentType: RelationName
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: QueryContainer
        [<System.Text.Json.Serialization.JsonPropertyName("score")>]
        Score: bool option
    }

    and KnnQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field
        [<System.Text.Json.Serialization.JsonPropertyName("query_vector")>]
        QueryVector: QueryVector option
        [<System.Text.Json.Serialization.JsonPropertyName("query_vector_builder")>]
        QueryVectorBuilder: QueryVectorBuilder option
        [<System.Text.Json.Serialization.JsonPropertyName("num_candidates")>]
        NumCandidates: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("visit_percentage")>]
        VisitPercentage: Float option
        [<System.Text.Json.Serialization.JsonPropertyName("k")>]
        K: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity")>]
        Similarity: Float option
        [<System.Text.Json.Serialization.JsonPropertyName("rescore_vector")>]
        RescoreVector: RescoreVector option
    }

    and NestedQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unmapped")>]
        IgnoreUnmapped: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("inner_hits")>]
        InnerHits: GlobalSearchTypes.InnerHits option
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: Field
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: QueryContainer
        [<System.Text.Json.Serialization.JsonPropertyName("score_mode")>]
        ScoreMode: ChildScoreMode option
    }

    and [<RequireQualifiedAccess>] PinnedQuery =
        | Ids of Id list
        | Docs of PinnedDoc list

    and PinnedQueryMeta = {
        [<System.Text.Json.Serialization.JsonPropertyName("organic")>]
        Organic: QueryContainer
    }

    and RuleQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("organic")>]
        Organic: QueryContainer
        [<System.Text.Json.Serialization.JsonPropertyName("ruleset_ids")>]
        RulesetIds: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("ruleset_id")>]
        RulesetId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("match_criteria")>]
        MatchCriteria: System.Text.Json.JsonElement
    }

    and ScriptScoreQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("min_score")>]
        MinScore: Float option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: QueryContainer
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script
    }

    and SpanContainingQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("big")>]
        Big: SpanQuery
        [<System.Text.Json.Serialization.JsonPropertyName("little")>]
        Little: SpanQuery
    }

    and [<RequireQualifiedAccess>] SpanQuery =
        | SpanContaining of SpanContainingQuery
        | SpanFieldMasking of SpanFieldMaskingQuery
        | SpanFirst of SpanFirstQuery
        | SpanGap of SpanGapQuery
        | SpanMulti of SpanMultiTermQuery
        | SpanNear of SpanNearQuery
        | SpanNot of SpanNotQuery
        | SpanOr of SpanOrQuery
        | SpanTerm of field: string * SpanTermQuery
        | SpanWithin of SpanWithinQuery
        | Unknown of name: string * System.Text.Json.JsonElement

    and SpanFieldMaskingQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: SpanQuery
    }

    and SpanFirstQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("end")>]
        End: Integer
        [<System.Text.Json.Serialization.JsonPropertyName("match")>]
        Match: SpanQuery
    }

    and SpanMultiTermQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("match")>]
        Match: QueryContainer
    }

    and SpanNearQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("clauses")>]
        Clauses: SpanQuery list
        [<System.Text.Json.Serialization.JsonPropertyName("in_order")>]
        InOrder: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("slop")>]
        Slop: Integer option
    }

    and SpanNotQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("dist")>]
        Dist: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("exclude")>]
        Exclude: SpanQuery
        [<System.Text.Json.Serialization.JsonPropertyName("include")>]
        Include: SpanQuery
        [<System.Text.Json.Serialization.JsonPropertyName("post")>]
        Post: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("pre")>]
        Pre: Integer option
    }

    and SpanOrQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("clauses")>]
        Clauses: SpanQuery list
    }

    and SpanWithinQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("big")>]
        Big: SpanQuery
        [<System.Text.Json.Serialization.JsonPropertyName("little")>]
        Little: SpanQuery
    }

    type Aggregation = System.Text.Json.JsonElement

    /// Base type for bucket aggregations. These aggregations also accept sub-aggregations.
    type BucketAggregationBase = System.Text.Json.JsonElement

    type AdjacencyMatrixAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("filters")>]
        Filters: Map<string, QueryContainer> option
        [<System.Text.Json.Serialization.JsonPropertyName("separator")>]
        Separator: string option
    }

    type CardinalityAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: Long
    }

    type KeyedPercentiles = Map<string, System.Text.Json.JsonElement>

    type ArrayPercentilesItem = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: Double
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("value_as_string")>]
        ValueAsString: string option
    }

    [<RequireQualifiedAccess>]
    type Percentiles =
        | KeyedPercentiles of KeyedPercentiles
        | Array of ArrayPercentilesItem list

    type PercentilesAggregateBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("values")>]
        Values: Percentiles
    }

    type HdrPercentilesAggregate = System.Text.Json.JsonElement

    type HdrPercentileRanksAggregate = System.Text.Json.JsonElement

    type TDigestPercentilesAggregate = System.Text.Json.JsonElement

    type TDigestPercentileRanksAggregate = System.Text.Json.JsonElement

    type PercentilesBucketAggregate = System.Text.Json.JsonElement

    type SingleMetricAggregateBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("value_as_string")>]
        ValueAsString: string option
    }

    type MedianAbsoluteDeviationAggregate = System.Text.Json.JsonElement

    type MinAggregate = System.Text.Json.JsonElement

    type MaxAggregate = System.Text.Json.JsonElement

    /// Sum aggregation result. `value` is always present and is zero if there were no values to process.
    type SumAggregate = System.Text.Json.JsonElement

    type AvgAggregate = System.Text.Json.JsonElement

    /// Weighted average aggregation result. `value` is missing if the weight was set to zero.
    type WeightedAvgAggregate = System.Text.Json.JsonElement

    /// Value count aggregation result. `value` is always present.
    type ValueCountAggregate = System.Text.Json.JsonElement

    type SimpleValueAggregate = System.Text.Json.JsonElement

    type DerivativeAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("normalized_value")>]
        NormalizedValue: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("normalized_value_as_string")>]
        NormalizedValueAsString: string option
    }

    type BucketMetricValueAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("keys")>]
        Keys: string list
    }

    type Dip = System.Text.Json.JsonElement

    type DistributionChange = System.Text.Json.JsonElement

    type Indeterminable = {
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string
    }

    type NonStationary = {
        [<System.Text.Json.Serialization.JsonPropertyName("p_value")>]
        PValue: Double
        [<System.Text.Json.Serialization.JsonPropertyName("r_value")>]
        RValue: Double
        [<System.Text.Json.Serialization.JsonPropertyName("trend")>]
        Trend: string
    }

    type Spike = System.Text.Json.JsonElement

    type Stationary = System.Text.Json.JsonElement

    type StepChange = System.Text.Json.JsonElement

    type TrendChange = {
        [<System.Text.Json.Serialization.JsonPropertyName("p_value")>]
        PValue: Double
        [<System.Text.Json.Serialization.JsonPropertyName("r_value")>]
        RValue: Double
        [<System.Text.Json.Serialization.JsonPropertyName("change_point")>]
        ChangePoint: Integer
    }

    [<RequireQualifiedAccess>]
    type ChangeType =
        | Dip of Dip
        | DistributionChange of DistributionChange
        | Indeterminable of Indeterminable
        | NonStationary of NonStationary
        | Spike of Spike
        | Stationary of Stationary
        | StepChange of StepChange
        | TrendChange of TrendChange

    type ChangePointBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: FieldValue
    }

    type ChangePointAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: ChangeType
        [<System.Text.Json.Serialization.JsonPropertyName("bucket")>]
        Bucket: ChangePointBucket option
    }

    /// Statistics aggregation result. `min`, `max` and `avg` are missing if there were no values to process
    type StatsAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Long
        [<System.Text.Json.Serialization.JsonPropertyName("min")>]
        Min: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("avg")>]
        Avg: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("sum")>]
        Sum: Double
        [<System.Text.Json.Serialization.JsonPropertyName("min_as_string")>]
        MinAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_as_string")>]
        MaxAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("avg_as_string")>]
        AvgAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("sum_as_string")>]
        SumAsString: string option
    }

    type StatsBucketAggregate = System.Text.Json.JsonElement

    type StandardDeviationBounds = {
        [<System.Text.Json.Serialization.JsonPropertyName("upper")>]
        Upper: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("lower")>]
        Lower: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("upper_population")>]
        UpperPopulation: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("lower_population")>]
        LowerPopulation: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("upper_sampling")>]
        UpperSampling: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("lower_sampling")>]
        LowerSampling: Double option
    }

    type StandardDeviationBoundsAsString = {
        [<System.Text.Json.Serialization.JsonPropertyName("upper")>]
        Upper: string
        [<System.Text.Json.Serialization.JsonPropertyName("lower")>]
        Lower: string
        [<System.Text.Json.Serialization.JsonPropertyName("upper_population")>]
        UpperPopulation: string
        [<System.Text.Json.Serialization.JsonPropertyName("lower_population")>]
        LowerPopulation: string
        [<System.Text.Json.Serialization.JsonPropertyName("upper_sampling")>]
        UpperSampling: string
        [<System.Text.Json.Serialization.JsonPropertyName("lower_sampling")>]
        LowerSampling: string
    }

    type ExtendedStatsAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("sum_of_squares")>]
        SumOfSquares: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("variance")>]
        Variance: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("variance_population")>]
        VariancePopulation: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("variance_sampling")>]
        VarianceSampling: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("std_deviation")>]
        StdDeviation: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("std_deviation_population")>]
        StdDeviationPopulation: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("std_deviation_sampling")>]
        StdDeviationSampling: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("std_deviation_bounds")>]
        StdDeviationBounds: StandardDeviationBounds option
        [<System.Text.Json.Serialization.JsonPropertyName("sum_of_squares_as_string")>]
        SumOfSquaresAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("variance_as_string")>]
        VarianceAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("variance_population_as_string")>]
        VariancePopulationAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("variance_sampling_as_string")>]
        VarianceSamplingAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("std_deviation_as_string")>]
        StdDeviationAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("std_deviation_bounds_as_string")>]
        StdDeviationBoundsAsString: StandardDeviationBoundsAsString option
    }

    type ExtendedStatsBucketAggregate = System.Text.Json.JsonElement

    type TopLeftBottomRightGeoBounds = {
        [<System.Text.Json.Serialization.JsonPropertyName("top_left")>]
        TopLeft: GeoLocation
        [<System.Text.Json.Serialization.JsonPropertyName("bottom_right")>]
        BottomRight: GeoLocation
    }

    type CartesianBoundsAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("bounds")>]
        Bounds: TopLeftBottomRightGeoBounds option
    }

    type CartesianPoint = {
        [<System.Text.Json.Serialization.JsonPropertyName("x")>]
        X: Double
        [<System.Text.Json.Serialization.JsonPropertyName("y")>]
        Y: Double
    }

    type CartesianCentroidAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Long
        [<System.Text.Json.Serialization.JsonPropertyName("location")>]
        Location: CartesianPoint option
    }

    type CoordsGeoBounds = {
        [<System.Text.Json.Serialization.JsonPropertyName("top")>]
        Top: Double
        [<System.Text.Json.Serialization.JsonPropertyName("bottom")>]
        Bottom: Double
        [<System.Text.Json.Serialization.JsonPropertyName("left")>]
        Left: Double
        [<System.Text.Json.Serialization.JsonPropertyName("right")>]
        Right: Double
    }

    type TopRightBottomLeftGeoBounds = {
        [<System.Text.Json.Serialization.JsonPropertyName("top_right")>]
        TopRight: GeoLocation
        [<System.Text.Json.Serialization.JsonPropertyName("bottom_left")>]
        BottomLeft: GeoLocation
    }

    type WktGeoBounds = {
        [<System.Text.Json.Serialization.JsonPropertyName("wkt")>]
        Wkt: string
    }

    /// A geo bounding box. It can be represented in various ways:
    [<RequireQualifiedAccess>]
    type GeoBounds =
        | CoordsGeoBounds of CoordsGeoBounds
        | TopLeftBottomRightGeoBounds of TopLeftBottomRightGeoBounds
        | TopRightBottomLeftGeoBounds of TopRightBottomLeftGeoBounds
        | WktGeoBounds of WktGeoBounds

    type GeoBoundsAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("bounds")>]
        Bounds: GeoBounds option
    }

    type GeoCentroidAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Long
        [<System.Text.Json.Serialization.JsonPropertyName("location")>]
        Location: GeoLocation option
    }

    type HistogramBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key_as_string")>]
        KeyAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: Double
    }

    type HistogramAggregate = System.Text.Json.JsonElement

    type EpochTime<'unit> = 'unit

    /// Time unit for milliseconds
    type UnitMillis = Long

    type DateHistogramBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key_as_string")>]
        KeyAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: EpochTime<UnitMillis>
    }

    type DateHistogramAggregate = System.Text.Json.JsonElement

    /// A date histogram interval. Similar to `Duration` with additional units: `w` (week), `M` (month), `q` (quarter) and
    type DurationLarge = string

    type AutoDateHistogramAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("interval")>]
        Interval: DurationLarge
    }

    type VariableWidthHistogramBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("min")>]
        Min: Double
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: Double
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: Double
        [<System.Text.Json.Serialization.JsonPropertyName("min_as_string")>]
        MinAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("key_as_string")>]
        KeyAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_as_string")>]
        MaxAsString: string option
    }

    type VariableWidthHistogramAggregate = System.Text.Json.JsonElement

    type TermsAggregateBase<'tBucket> = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc_count_error_upper_bound")>]
        DocCountErrorUpperBound: Long option
        [<System.Text.Json.Serialization.JsonPropertyName("sum_other_doc_count")>]
        SumOtherDocCount: Long option
    }

    type TermsBucketBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc_count_error_upper_bound")>]
        DocCountErrorUpperBound: Long option
    }

    type StringTermsBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: FieldValue
    }

    /// Result of a `terms` aggregation when the field is a string.
    type StringTermsAggregate = System.Text.Json.JsonElement

    type LongTermsBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: Long
        [<System.Text.Json.Serialization.JsonPropertyName("key_as_string")>]
        KeyAsString: string option
    }

    /// Result of a `terms` aggregation when the field is some kind of whole number like a integer, long, or a date.
    type LongTermsAggregate = System.Text.Json.JsonElement

    type DoubleTermsBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: Double
        [<System.Text.Json.Serialization.JsonPropertyName("key_as_string")>]
        KeyAsString: string option
    }

    /// Result of a `terms` aggregation when the field is some kind of decimal number like a float, double, or distance.
    type DoubleTermsAggregate = System.Text.Json.JsonElement

    /// The absence of any type. This is commonly used in APIs that don't return a body.
    type Void = unit

    /// Result of a `terms` aggregation when the field is unmapped. `buckets` is always empty.
    type UnmappedTermsAggregate = System.Text.Json.JsonElement

    type LongRareTermsBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: Long
        [<System.Text.Json.Serialization.JsonPropertyName("key_as_string")>]
        KeyAsString: string option
    }

    /// Result of the `rare_terms` aggregation when the field is some kind of whole number like a integer, long, or a date.
    type LongRareTermsAggregate = System.Text.Json.JsonElement

    type StringRareTermsBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: string
    }

    /// Result of the `rare_terms` aggregation when the field is a string.
    type StringRareTermsAggregate = System.Text.Json.JsonElement

    /// Result of a `rare_terms` aggregation when the field is unmapped. `buckets` is always empty.
    type UnmappedRareTermsAggregate = System.Text.Json.JsonElement

    type MultiTermsBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: FieldValue list
        [<System.Text.Json.Serialization.JsonPropertyName("key_as_string")>]
        KeyAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("doc_count_error_upper_bound")>]
        DocCountErrorUpperBound: Long option
    }

    type MultiTermsAggregate = System.Text.Json.JsonElement

    /// Base type for single-bucket aggregation results that can hold sub-aggregations results.
    type SingleBucketAggregateBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc_count")>]
        DocCount: Long
    }

    type MissingAggregate = System.Text.Json.JsonElement

    type NestedAggregate = System.Text.Json.JsonElement

    type ReverseNestedAggregate = System.Text.Json.JsonElement

    type GlobalAggregate = System.Text.Json.JsonElement

    type FilterAggregate = System.Text.Json.JsonElement

    type ChildrenAggregate = System.Text.Json.JsonElement

    type ParentAggregate = System.Text.Json.JsonElement

    type SamplerAggregate = System.Text.Json.JsonElement

    type UnmappedSamplerAggregate = System.Text.Json.JsonElement

    type GeoHashGridBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: GeoHash
    }

    type GeoHashGridAggregate = System.Text.Json.JsonElement

    type GeoTileGridBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: GeoTile
    }

    type GeoTileGridAggregate = System.Text.Json.JsonElement

    type GeoHexGridBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: GeoHexCell
    }

    type GeoHexGridAggregate = System.Text.Json.JsonElement

    type RangeBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        From: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("to")>]
        To: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("from_as_string")>]
        FromAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("to_as_string")>]
        ToAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: string option
    }

    type RangeAggregate = System.Text.Json.JsonElement

    /// Result of a `date_range` aggregation. Same format as a for a `range` aggregation: `from` and `to`
    type DateRangeAggregate = System.Text.Json.JsonElement

    /// Result of a `geo_distance` aggregation. The unit for `from` and `to` is meters by default.
    type GeoDistanceAggregate = System.Text.Json.JsonElement

    type IpRangeBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: string option
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        From: string option
        [<System.Text.Json.Serialization.JsonPropertyName("to")>]
        To: string option
    }

    type IpRangeAggregate = System.Text.Json.JsonElement

    type IpPrefixBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("is_ipv6")>]
        IsIpv6: bool
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: string
        [<System.Text.Json.Serialization.JsonPropertyName("prefix_length")>]
        PrefixLength: Integer
        [<System.Text.Json.Serialization.JsonPropertyName("netmask")>]
        Netmask: string option
    }

    type IpPrefixAggregate = System.Text.Json.JsonElement

    type FiltersBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: string option
    }

    type FiltersAggregate = System.Text.Json.JsonElement

    type SignificantTermsAggregateBase<'t> = {
        [<System.Text.Json.Serialization.JsonPropertyName("bg_count")>]
        BgCount: Long option
        [<System.Text.Json.Serialization.JsonPropertyName("doc_count")>]
        DocCount: Long option
    }

    type SignificantTermsBucketBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("score")>]
        Score: Double
        [<System.Text.Json.Serialization.JsonPropertyName("bg_count")>]
        BgCount: Long
    }

    type SignificantLongTermsBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: Long
        [<System.Text.Json.Serialization.JsonPropertyName("key_as_string")>]
        KeyAsString: string option
    }

    type SignificantLongTermsAggregate = System.Text.Json.JsonElement

    type SignificantStringTermsBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: string
    }

    type SignificantStringTermsAggregate = System.Text.Json.JsonElement

    /// Result of the `significant_terms` aggregation on an unmapped field. `buckets` is always empty.
    type UnmappedSignificantTermsAggregate = System.Text.Json.JsonElement

    type CompositeAggregateKey = Map<Field, FieldValue>

    type CompositeBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: CompositeAggregateKey
    }

    type CompositeAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("after_key")>]
        AfterKey: CompositeAggregateKey option
    }

    type FrequentItemSetsBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: Map<Field, string list>
        [<System.Text.Json.Serialization.JsonPropertyName("support")>]
        Support: Double
    }

    type FrequentItemSetsAggregate = System.Text.Json.JsonElement

    type TimeSeriesBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: Map<Field, FieldValue>
    }

    type TimeSeriesAggregate = System.Text.Json.JsonElement

    type ScriptedMetricAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: System.Text.Json.JsonElement
    }

    type TopHitsAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("hits")>]
        Hits: GlobalSearchTypes.HitsMetadata<System.Text.Json.JsonElement>
    }

    type InferenceClassImportance = {
        [<System.Text.Json.Serialization.JsonPropertyName("class_name")>]
        ClassName: string
        [<System.Text.Json.Serialization.JsonPropertyName("importance")>]
        Importance: Double
    }

    type InferenceFeatureImportance = {
        [<System.Text.Json.Serialization.JsonPropertyName("feature_name")>]
        FeatureName: string
        [<System.Text.Json.Serialization.JsonPropertyName("importance")>]
        Importance: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("classes")>]
        Classes: InferenceClassImportance list option
    }

    type InferenceTopClassEntry = {
        [<System.Text.Json.Serialization.JsonPropertyName("class_name")>]
        ClassName: FieldValue
        [<System.Text.Json.Serialization.JsonPropertyName("class_probability")>]
        ClassProbability: Double
        [<System.Text.Json.Serialization.JsonPropertyName("class_score")>]
        ClassScore: Double
    }

    type InferenceAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: FieldValue option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_importance")>]
        FeatureImportance: InferenceFeatureImportance list option
        [<System.Text.Json.Serialization.JsonPropertyName("top_classes")>]
        TopClasses: InferenceTopClassEntry list option
        [<System.Text.Json.Serialization.JsonPropertyName("warning")>]
        Warning: string option
    }

    type StringStatsAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Long
        [<System.Text.Json.Serialization.JsonPropertyName("min_length")>]
        MinLength: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_length")>]
        MaxLength: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("avg_length")>]
        AvgLength: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("entropy")>]
        Entropy: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("distribution")>]
        Distribution: Map<string, Double> option option
        [<System.Text.Json.Serialization.JsonPropertyName("min_length_as_string")>]
        MinLengthAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_length_as_string")>]
        MaxLengthAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("avg_length_as_string")>]
        AvgLengthAsString: string option
    }

    type BoxPlotAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("min")>]
        Min: Double
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: Double
        [<System.Text.Json.Serialization.JsonPropertyName("q1")>]
        Q1: Double
        [<System.Text.Json.Serialization.JsonPropertyName("q2")>]
        Q2: Double
        [<System.Text.Json.Serialization.JsonPropertyName("q3")>]
        Q3: Double
        [<System.Text.Json.Serialization.JsonPropertyName("lower")>]
        Lower: Double
        [<System.Text.Json.Serialization.JsonPropertyName("upper")>]
        Upper: Double
        [<System.Text.Json.Serialization.JsonPropertyName("min_as_string")>]
        MinAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_as_string")>]
        MaxAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("q1_as_string")>]
        Q1AsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("q2_as_string")>]
        Q2AsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("q3_as_string")>]
        Q3AsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("lower_as_string")>]
        LowerAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("upper_as_string")>]
        UpperAsString: string option
    }

    type TopMetrics = {
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: FieldValue option list
        [<System.Text.Json.Serialization.JsonPropertyName("metrics")>]
        Metrics: Map<string, FieldValue option>
    }

    type TopMetricsAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("top")>]
        Top: TopMetrics list
    }

    type TTestAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("value_as_string")>]
        ValueAsString: string option
    }

    type RateAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: Double
        [<System.Text.Json.Serialization.JsonPropertyName("value_as_string")>]
        ValueAsString: string option
    }

    /// Result of the `cumulative_cardinality` aggregation
    type CumulativeCardinalityAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: Long
        [<System.Text.Json.Serialization.JsonPropertyName("value_as_string")>]
        ValueAsString: string option
    }

    type MatrixStatsFields = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Field
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Long
        [<System.Text.Json.Serialization.JsonPropertyName("mean")>]
        Mean: Double
        [<System.Text.Json.Serialization.JsonPropertyName("variance")>]
        Variance: Double
        [<System.Text.Json.Serialization.JsonPropertyName("skewness")>]
        Skewness: Double
        [<System.Text.Json.Serialization.JsonPropertyName("kurtosis")>]
        Kurtosis: Double
        [<System.Text.Json.Serialization.JsonPropertyName("covariance")>]
        Covariance: Map<Field, Double>
        [<System.Text.Json.Serialization.JsonPropertyName("correlation")>]
        Correlation: Map<Field, Double>
    }

    type MatrixStatsAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc_count")>]
        DocCount: Long
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: MatrixStatsFields list option
    }

    /// A GeoJson GeoLine.
    type GeoLine = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("coordinates")>]
        Coordinates: Double list list
    }

    type GeoLineAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("geometry")>]
        Geometry: GeoLine
        [<System.Text.Json.Serialization.JsonPropertyName("properties")>]
        Properties: System.Text.Json.JsonElement
    }

    [<RequireQualifiedAccess>]
    type Aggregate =
        | CardinalityAggregate of CardinalityAggregate
        | HdrPercentilesAggregate of HdrPercentilesAggregate
        | HdrPercentileRanksAggregate of HdrPercentileRanksAggregate
        | TDigestPercentilesAggregate of TDigestPercentilesAggregate
        | TDigestPercentileRanksAggregate of TDigestPercentileRanksAggregate
        | PercentilesBucketAggregate of PercentilesBucketAggregate
        | MedianAbsoluteDeviationAggregate of MedianAbsoluteDeviationAggregate
        | MinAggregate of MinAggregate
        | MaxAggregate of MaxAggregate
        | SumAggregate of SumAggregate
        | AvgAggregate of AvgAggregate
        | WeightedAvgAggregate of WeightedAvgAggregate
        | ValueCountAggregate of ValueCountAggregate
        | SimpleValueAggregate of SimpleValueAggregate
        | DerivativeAggregate of DerivativeAggregate
        | BucketMetricValueAggregate of BucketMetricValueAggregate
        | ChangePointAggregate of ChangePointAggregate
        | StatsAggregate of StatsAggregate
        | StatsBucketAggregate of StatsBucketAggregate
        | ExtendedStatsAggregate of ExtendedStatsAggregate
        | ExtendedStatsBucketAggregate of ExtendedStatsBucketAggregate
        | CartesianBoundsAggregate of CartesianBoundsAggregate
        | CartesianCentroidAggregate of CartesianCentroidAggregate
        | GeoBoundsAggregate of GeoBoundsAggregate
        | GeoCentroidAggregate of GeoCentroidAggregate
        | HistogramAggregate of HistogramAggregate
        | DateHistogramAggregate of DateHistogramAggregate
        | AutoDateHistogramAggregate of AutoDateHistogramAggregate
        | VariableWidthHistogramAggregate of VariableWidthHistogramAggregate
        | StringTermsAggregate of StringTermsAggregate
        | LongTermsAggregate of LongTermsAggregate
        | DoubleTermsAggregate of DoubleTermsAggregate
        | UnmappedTermsAggregate of UnmappedTermsAggregate
        | LongRareTermsAggregate of LongRareTermsAggregate
        | StringRareTermsAggregate of StringRareTermsAggregate
        | UnmappedRareTermsAggregate of UnmappedRareTermsAggregate
        | MultiTermsAggregate of MultiTermsAggregate
        | MissingAggregate of MissingAggregate
        | NestedAggregate of NestedAggregate
        | ReverseNestedAggregate of ReverseNestedAggregate
        | GlobalAggregate of GlobalAggregate
        | FilterAggregate of FilterAggregate
        | ChildrenAggregate of ChildrenAggregate
        | ParentAggregate of ParentAggregate
        | SamplerAggregate of SamplerAggregate
        | UnmappedSamplerAggregate of UnmappedSamplerAggregate
        | GeoHashGridAggregate of GeoHashGridAggregate
        | GeoTileGridAggregate of GeoTileGridAggregate
        | GeoHexGridAggregate of GeoHexGridAggregate
        | RangeAggregate of RangeAggregate
        | DateRangeAggregate of DateRangeAggregate
        | GeoDistanceAggregate of GeoDistanceAggregate
        | IpRangeAggregate of IpRangeAggregate
        | IpPrefixAggregate of IpPrefixAggregate
        | FiltersAggregate of FiltersAggregate
        | AdjacencyMatrixAggregate of AdjacencyMatrixAggregate
        | SignificantLongTermsAggregate of SignificantLongTermsAggregate
        | SignificantStringTermsAggregate of SignificantStringTermsAggregate
        | UnmappedSignificantTermsAggregate of UnmappedSignificantTermsAggregate
        | CompositeAggregate of CompositeAggregate
        | FrequentItemSetsAggregate of FrequentItemSetsAggregate
        | TimeSeriesAggregate of TimeSeriesAggregate
        | ScriptedMetricAggregate of ScriptedMetricAggregate
        | TopHitsAggregate of TopHitsAggregate
        | InferenceAggregate of InferenceAggregate
        | StringStatsAggregate of StringStatsAggregate
        | BoxPlotAggregate of BoxPlotAggregate
        | TopMetricsAggregate of TopMetricsAggregate
        | TTestAggregate of TTestAggregate
        | RateAggregate of RateAggregate
        | CumulativeCardinalityAggregate of CumulativeCardinalityAggregate
        | MatrixStatsAggregate of MatrixStatsAggregate
        | GeoLineAggregate of GeoLineAggregate

    [<RequireQualifiedAccess>]
    type TimeSeriesMetricType =
        | Gauge
        | Counter
        | Summary
        | Histogram
        | Position

    type PropertyName = string

    [<RequireQualifiedAccess>]
    type OnScriptError =
        | Fail
        | Continue

    [<RequireQualifiedAccess>]
    type IndexOptions =
        | Docs
        | Freqs
        | Positions
        | Offsets

    type TextIndexPrefixes = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_chars")>]
        MaxChars: Integer
        [<System.Text.Json.Serialization.JsonPropertyName("min_chars")>]
        MinChars: Integer
    }

    [<RequireQualifiedAccess>]
    type TermVectorOption =
        | No
        | Yes
        | WithOffsets
        | WithPositions
        | WithPositionsOffsets
        | WithPositionsOffsetsPayloads
        | WithPositionsPayloads

    /// A date and time, either as a string whose format can depend on the context (defaulting to ISO 8601), or a
    [<RequireQualifiedAccess>]
    type DateTime =
        | String of string
        | EpochTime of EpochTime<UnitMillis>

    [<RequireQualifiedAccess>]
    type DenseVectorElementType =
        | Bit
        | Byte
        | Float
        | Bfloat16

    [<RequireQualifiedAccess>]
    type DenseVectorIndexOptionsType =
        | BbqFlat
        | BbqHnsw
        | BbqDisk
        | Flat
        | Hnsw
        | Int4Flat
        | Int4Hnsw
        | Int8Flat
        | Int8Hnsw

    type DenseVectorIndexOptionsRescoreVector = {
        [<System.Text.Json.Serialization.JsonPropertyName("oversample")>]
        Oversample: Float
    }

    type DenseVectorIndexOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("confidence_interval")>]
        ConfidenceInterval: Float option
        [<System.Text.Json.Serialization.JsonPropertyName("ef_construction")>]
        EfConstruction: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("m")>]
        M: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: DenseVectorIndexOptionsType
        [<System.Text.Json.Serialization.JsonPropertyName("rescore_vector")>]
        RescoreVector: DenseVectorIndexOptionsRescoreVector option
        [<System.Text.Json.Serialization.JsonPropertyName("on_disk_rescore")>]
        OnDiskRescore: bool option
    }

    [<RequireQualifiedAccess>]
    type DenseVectorSimilarity =
        | Cosine
        | DotProduct
        | L2Norm
        | MaxInnerProduct

    [<RequireQualifiedAccess>]
    type Subobjects =
        | True
        | False
        | Auto

    [<RequireQualifiedAccess>]
    type RankVectorElementType =
        | Byte
        | Float
        | Bit

    type SparseVectorIndexOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("prune")>]
        Prune: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("pruning_config")>]
        PruningConfig: TokenPruningConfig option
    }

    type SemanticTextIndexOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("dense_vector")>]
        DenseVector: DenseVectorIndexOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("sparse_vector")>]
        SparseVector: SparseVectorIndexOptions option
    }

    type ChunkingSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("strategy")>]
        Strategy: string
        [<System.Text.Json.Serialization.JsonPropertyName("max_chunk_size")>]
        MaxChunkSize: Integer
        [<System.Text.Json.Serialization.JsonPropertyName("overlap")>]
        Overlap: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("sentence_overlap")>]
        SentenceOverlap: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("separator_group")>]
        SeparatorGroup: string option
        [<System.Text.Json.Serialization.JsonPropertyName("separators")>]
        Separators: string list option
    }

    type Name = string

    type SuggestContext = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Name
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("precision")>]
        Precision: System.Text.Json.JsonElement option
    }

    [<RequireQualifiedAccess>]
    type GeoPointMetricType =
        | Gauge
        | Counter
        | Position

    [<RequireQualifiedAccess>]
    type GeoOrientation =
        | Right
        | Left

    [<RequireQualifiedAccess>]
    type GeoStrategy =
        | Recursive
        | Term

    type Byte = float

    type Short = float

    type Ulong = float

    [<RequireQualifiedAccess>]
    type IcuCollationStrength =
        | Primary
        | Secondary
        | Tertiary
        | Quaternary
        | Identical

    [<RequireQualifiedAccess>]
    type IcuCollationDecomposition =
        | No
        | Identical

    [<RequireQualifiedAccess>]
    type IcuCollationAlternate =
        | Shifted
        | NonIgnorable

    [<RequireQualifiedAccess>]
    type IcuCollationCaseFirst =
        | Lower
        | Upper

    [<RequireQualifiedAccess>]
    type DynamicMapping =
        | Strict
        | Runtime
        | True
        | False

    [<RequireQualifiedAccess>]
    type SyntheticSourceKeepEnum =
        | None
        | Arrays
        | All

    type AggregateMetricDoubleProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("default_metric")>]
        DefaultMetric: string
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_malformed")>]
        IgnoreMalformed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("metrics")>]
        Metrics: string list
        [<System.Text.Json.Serialization.JsonPropertyName("time_series_metric")>]
        TimeSeriesMetric: TimeSeriesMetricType option
    }

    and PropertyBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("meta")>]
        Meta: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("properties")>]
        Properties: Map<PropertyName, Property> option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_above")>]
        IgnoreAbove: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("dynamic")>]
        Dynamic: DynamicMapping option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<PropertyName, Property> option
        [<System.Text.Json.Serialization.JsonPropertyName("synthetic_source_keep")>]
        SyntheticSourceKeep: SyntheticSourceKeepEnum option
    }

    and [<RequireQualifiedAccess>] Property =
        | BinaryProperty of BinaryProperty
        | BooleanProperty of BooleanProperty
        | DynamicProperty of DynamicProperty
        | JoinProperty of JoinProperty
        | KeywordProperty of KeywordProperty
        | MatchOnlyTextProperty of MatchOnlyTextProperty
        | PercolatorProperty of PercolatorProperty
        | RankFeatureProperty of RankFeatureProperty
        | RankFeaturesProperty of RankFeaturesProperty
        | SearchAsYouTypeProperty of SearchAsYouTypeProperty
        | TextProperty of TextProperty
        | VersionProperty of VersionProperty
        | WildcardProperty of WildcardProperty
        | DateNanosProperty of DateNanosProperty
        | DateProperty of DateProperty
        | AggregateMetricDoubleProperty of AggregateMetricDoubleProperty
        | DenseVectorProperty of DenseVectorProperty
        | FlattenedProperty of FlattenedProperty
        | NestedProperty of NestedProperty
        | ObjectProperty of ObjectProperty
        | PassthroughObjectProperty of PassthroughObjectProperty
        | RankVectorProperty of RankVectorProperty
        | SemanticTextProperty of SemanticTextProperty
        | SparseVectorProperty of SparseVectorProperty
        | CompletionProperty of CompletionProperty
        | ConstantKeywordProperty of ConstantKeywordProperty
        | CountedKeywordProperty of CountedKeywordProperty
        | FieldAliasProperty of FieldAliasProperty
        | HistogramProperty of HistogramProperty
        | ExponentialHistogramProperty of ExponentialHistogramProperty
        | IpProperty of IpProperty
        | Murmur3HashProperty of Murmur3HashProperty
        | TokenCountProperty of TokenCountProperty
        | GeoPointProperty of GeoPointProperty
        | GeoShapeProperty of GeoShapeProperty
        | PointProperty of PointProperty
        | ShapeProperty of ShapeProperty
        | ByteNumberProperty of ByteNumberProperty
        | DoubleNumberProperty of DoubleNumberProperty
        | FloatNumberProperty of FloatNumberProperty
        | HalfFloatNumberProperty of HalfFloatNumberProperty
        | IntegerNumberProperty of IntegerNumberProperty
        | LongNumberProperty of LongNumberProperty
        | ScaledFloatNumberProperty of ScaledFloatNumberProperty
        | ShortNumberProperty of ShortNumberProperty
        | UnsignedLongNumberProperty of UnsignedLongNumberProperty
        | DateRangeProperty of DateRangeProperty
        | DoubleRangeProperty of DoubleRangeProperty
        | FloatRangeProperty of FloatRangeProperty
        | IntegerRangeProperty of IntegerRangeProperty
        | IpRangeProperty of IpRangeProperty
        | LongRangeProperty of LongRangeProperty
        | IcuCollationProperty of IcuCollationProperty
        | Unknown of name: string * System.Text.Json.JsonElement

    and BinaryProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and DocValuesPropertyBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc_values")>]
        DocValues: bool option
    }

    and CorePropertyBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("copy_to")>]
        CopyTo: Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("store")>]
        Store: bool option
    }

    and BooleanProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("fielddata")>]
        Fielddata: IndicesTypes.NumericFielddata option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_malformed")>]
        IgnoreMalformed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script option
        [<System.Text.Json.Serialization.JsonPropertyName("on_script_error")>]
        OnScriptError: OnScriptError option
        [<System.Text.Json.Serialization.JsonPropertyName("time_series_dimension")>]
        TimeSeriesDimension: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and DynamicProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: FieldValue option
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("coerce")>]
        Coerce: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script option
        [<System.Text.Json.Serialization.JsonPropertyName("on_script_error")>]
        OnScriptError: OnScriptError option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_malformed")>]
        IgnoreMalformed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("time_series_metric")>]
        TimeSeriesMetric: TimeSeriesMetricType option
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("eager_global_ordinals")>]
        EagerGlobalOrdinals: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index_options")>]
        IndexOptions: IndexOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("index_phrases")>]
        IndexPhrases: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index_prefixes")>]
        IndexPrefixes: TextIndexPrefixes option option
        [<System.Text.Json.Serialization.JsonPropertyName("norms")>]
        Norms: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("position_increment_gap")>]
        PositionIncrementGap: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("search_analyzer")>]
        SearchAnalyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search_quote_analyzer")>]
        SearchQuoteAnalyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("term_vector")>]
        TermVector: TermVectorOption option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("precision_step")>]
        PrecisionStep: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("locale")>]
        Locale: string option
    }

    and JoinProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("relations")>]
        Relations: Map<RelationName, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("eager_global_ordinals")>]
        EagerGlobalOrdinals: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and KeywordProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("eager_global_ordinals")>]
        EagerGlobalOrdinals: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index_options")>]
        IndexOptions: IndexOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script option
        [<System.Text.Json.Serialization.JsonPropertyName("on_script_error")>]
        OnScriptError: OnScriptError option
        [<System.Text.Json.Serialization.JsonPropertyName("normalizer")>]
        Normalizer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("norms")>]
        Norms: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity")>]
        Similarity: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("split_queries_on_whitespace")>]
        SplitQueriesOnWhitespace: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("time_series_dimension")>]
        TimeSeriesDimension: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    /// A variant of text that trades scoring and efficiency of positional queries for space efficiency. This field
    and MatchOnlyTextProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<PropertyName, Property> option
        [<System.Text.Json.Serialization.JsonPropertyName("meta")>]
        Meta: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("copy_to")>]
        CopyTo: Fields option
    }

    and PercolatorProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and RankFeatureProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("positive_score_impact")>]
        PositiveScoreImpact: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and RankFeaturesProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("positive_score_impact")>]
        PositiveScoreImpact: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and SearchAsYouTypeProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index_options")>]
        IndexOptions: IndexOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("max_shingle_size")>]
        MaxShingleSize: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("norms")>]
        Norms: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("search_analyzer")>]
        SearchAnalyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search_quote_analyzer")>]
        SearchQuoteAnalyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity")>]
        Similarity: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("term_vector")>]
        TermVector: TermVectorOption option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and TextProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("eager_global_ordinals")>]
        EagerGlobalOrdinals: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("fielddata")>]
        Fielddata: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("fielddata_frequency_filter")>]
        FielddataFrequencyFilter: IndicesTypes.FielddataFrequencyFilter option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index_options")>]
        IndexOptions: IndexOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("index_phrases")>]
        IndexPhrases: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index_prefixes")>]
        IndexPrefixes: TextIndexPrefixes option option
        [<System.Text.Json.Serialization.JsonPropertyName("norms")>]
        Norms: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("position_increment_gap")>]
        PositionIncrementGap: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("search_analyzer")>]
        SearchAnalyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search_quote_analyzer")>]
        SearchQuoteAnalyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity")>]
        Similarity: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("term_vector")>]
        TermVector: TermVectorOption option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and VersionProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and WildcardProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: string option
    }

    and DateNanosProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_malformed")>]
        IgnoreMalformed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script option
        [<System.Text.Json.Serialization.JsonPropertyName("on_script_error")>]
        OnScriptError: OnScriptError option
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("precision_step")>]
        PrecisionStep: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and DateProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("fielddata")>]
        Fielddata: IndicesTypes.NumericFielddata option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_malformed")>]
        IgnoreMalformed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script option
        [<System.Text.Json.Serialization.JsonPropertyName("on_script_error")>]
        OnScriptError: OnScriptError option
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("precision_step")>]
        PrecisionStep: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("locale")>]
        Locale: string option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and DenseVectorProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("dims")>]
        Dims: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("element_type")>]
        ElementType: DenseVectorElementType option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index_options")>]
        IndexOptions: DenseVectorIndexOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity")>]
        Similarity: DenseVectorSimilarity option
    }

    and FlattenedProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("depth_limit")>]
        DepthLimit: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("doc_values")>]
        DocValues: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("eager_global_ordinals")>]
        EagerGlobalOrdinals: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index_options")>]
        IndexOptions: IndexOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity")>]
        Similarity: string option
        [<System.Text.Json.Serialization.JsonPropertyName("split_queries_on_whitespace")>]
        SplitQueriesOnWhitespace: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("time_series_dimensions")>]
        TimeSeriesDimensions: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and NestedProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("include_in_parent")>]
        IncludeInParent: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("include_in_root")>]
        IncludeInRoot: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and ObjectProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("subobjects")>]
        Subobjects: Subobjects option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string option
    }

    and PassthroughObjectProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string option
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("priority")>]
        Priority: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("time_series_dimension")>]
        TimeSeriesDimension: bool option
    }

    /// Technical preview
    and RankVectorProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("element_type")>]
        ElementType: RankVectorElementType option
        [<System.Text.Json.Serialization.JsonPropertyName("dims")>]
        Dims: Integer option
    }

    and SemanticTextProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("meta")>]
        Meta: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: Id option
        [<System.Text.Json.Serialization.JsonPropertyName("search_inference_id")>]
        SearchInferenceId: Id option
        [<System.Text.Json.Serialization.JsonPropertyName("index_options")>]
        IndexOptions: SemanticTextIndexOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: ChunkingSettings option option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<PropertyName, Property> option
    }

    and SparseVectorProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("store")>]
        Store: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("index_options")>]
        IndexOptions: SparseVectorIndexOptions option
    }

    and CompletionProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("contexts")>]
        Contexts: SuggestContext list option
        [<System.Text.Json.Serialization.JsonPropertyName("max_input_length")>]
        MaxInputLength: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("preserve_position_increments")>]
        PreservePositionIncrements: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("preserve_separators")>]
        PreserveSeparators: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("search_analyzer")>]
        SearchAnalyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and ConstantKeywordProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and CountedKeywordProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
    }

    and FieldAliasProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and HistogramProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_malformed")>]
        IgnoreMalformed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("time_series_metric")>]
        TimeSeriesMetric: TimeSeriesMetricType option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and ExponentialHistogramProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("time_series_metric")>]
        TimeSeriesMetric: TimeSeriesMetricType option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and IpProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_malformed")>]
        IgnoreMalformed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("on_script_error")>]
        OnScriptError: OnScriptError option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script option
        [<System.Text.Json.Serialization.JsonPropertyName("time_series_dimension")>]
        TimeSeriesDimension: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and Murmur3HashProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and TokenCountProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("enable_position_increments")>]
        EnablePositionIncrements: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and GeoPointProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_malformed")>]
        IgnoreMalformed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_z_value")>]
        IgnoreZValue: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: GeoLocation option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("on_script_error")>]
        OnScriptError: OnScriptError option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("time_series_metric")>]
        TimeSeriesMetric: GeoPointMetricType option
    }

    /// The `geo_shape` data type facilitates the indexing of and searching with arbitrary geo shapes such as rectangles
    and GeoShapeProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("coerce")>]
        Coerce: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_malformed")>]
        IgnoreMalformed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_z_value")>]
        IgnoreZValue: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("orientation")>]
        Orientation: GeoOrientation option
        [<System.Text.Json.Serialization.JsonPropertyName("strategy")>]
        Strategy: GeoStrategy option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and PointProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_malformed")>]
        IgnoreMalformed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_z_value")>]
        IgnoreZValue: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    /// The `shape` data type facilitates the indexing of and searching with arbitrary `x, y` cartesian shapes such as
    and ShapeProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("coerce")>]
        Coerce: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_malformed")>]
        IgnoreMalformed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_z_value")>]
        IgnoreZValue: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("orientation")>]
        Orientation: GeoOrientation option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and ByteNumberProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: Byte option
    }

    and NumberPropertyBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("coerce")>]
        Coerce: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_malformed")>]
        IgnoreMalformed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("on_script_error")>]
        OnScriptError: OnScriptError option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script option
        [<System.Text.Json.Serialization.JsonPropertyName("time_series_metric")>]
        TimeSeriesMetric: TimeSeriesMetricType option
        [<System.Text.Json.Serialization.JsonPropertyName("time_series_dimension")>]
        TimeSeriesDimension: bool option
    }

    and DoubleNumberProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: Double option
    }

    and FloatNumberProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: Float option
    }

    and HalfFloatNumberProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: Float option
    }

    and IntegerNumberProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: Integer option
    }

    and LongNumberProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: Long option
    }

    and ScaledFloatNumberProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("scaling_factor")>]
        ScalingFactor: Double option
    }

    and ShortNumberProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: Short option
    }

    and UnsignedLongNumberProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: Ulong option
    }

    and DateRangeProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and RangePropertyBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("coerce")>]
        Coerce: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
    }

    and DoubleRangeProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and FloatRangeProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and IntegerRangeProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and IpRangeProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and LongRangeProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and IcuCollationProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("norms")>]
        Norms: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index_options")>]
        IndexOptions: IndexOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("rules")>]
        Rules: string option
        [<System.Text.Json.Serialization.JsonPropertyName("language")>]
        Language: string option
        [<System.Text.Json.Serialization.JsonPropertyName("country")>]
        Country: string option
        [<System.Text.Json.Serialization.JsonPropertyName("variant")>]
        Variant: string option
        [<System.Text.Json.Serialization.JsonPropertyName("strength")>]
        Strength: IcuCollationStrength option
        [<System.Text.Json.Serialization.JsonPropertyName("decomposition")>]
        Decomposition: IcuCollationDecomposition option
        [<System.Text.Json.Serialization.JsonPropertyName("alternate")>]
        Alternate: IcuCollationAlternate option
        [<System.Text.Json.Serialization.JsonPropertyName("case_level")>]
        CaseLevel: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("case_first")>]
        CaseFirst: IcuCollationCaseFirst option
        [<System.Text.Json.Serialization.JsonPropertyName("numeric")>]
        Numeric: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("variable_top")>]
        VariableTop: string option
        [<System.Text.Json.Serialization.JsonPropertyName("hiragana_quaternary_mode")>]
        HiraganaQuaternaryMode: bool option
    }

    /// The aggregation name as returned from the server. Depending whether typed_keys is specified this could come back
    type AggregateName = string

    [<RequireQualifiedAccess>]
    type SortOrder =
        | Asc
        | Desc

    [<RequireQualifiedAccess>]
    type AggregateOrder =
        | Dictionary of Map<Field, SortOrder>
        | Array of Map<Field, SortOrder> list

    [<RequireQualifiedAccess>]
    type MinimumInterval =
        | Second
        | Minute
        | Hour
        | Day
        | Month
        | Year

    type AutoDateHistogramAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("buckets")>]
        Buckets: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_interval")>]
        MinimumInterval: MinimumInterval option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("offset")>]
        Offset: string option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script option
        [<System.Text.Json.Serialization.JsonPropertyName("time_zone")>]
        TimeZone: TimeZone option
    }

    [<RequireQualifiedAccess>]
    type Missing =
        | String of string
        | Integer of Integer
        | Double of Double
        | Boolean of bool

    type MetricAggregationBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: Missing option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script option
    }

    type FormatMetricAggregationBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
    }

    type AverageAggregation = System.Text.Json.JsonElement

    [<RequireQualifiedAccess>]
    type GapPolicy =
        | Skip
        | InsertZeros
        | KeepValues

    /// Buckets path can be expressed in different ways, and an aggregation may accept some or all of these
    [<RequireQualifiedAccess>]
    type BucketsPath =
        | String of string
        | Array of string list
        | Dictionary of Map<string, string>

    type BucketPathAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("buckets_path")>]
        BucketsPath: BucketsPath option
    }

    type PipelineAggregationBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("gap_policy")>]
        GapPolicy: GapPolicy option
    }

    type AverageBucketAggregation = System.Text.Json.JsonElement

    [<RequireQualifiedAccess>]
    type TDigestExecutionHint =
        | Default
        | HighAccuracy

    type BoxplotAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("compression")>]
        Compression: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("execution_hint")>]
        ExecutionHint: TDigestExecutionHint option
    }

    type BucketScriptAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script option
    }

    type BucketSelectorAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script option
    }

    type ScoreSort = {
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: SortOrder option
    }

    [<RequireQualifiedAccess>]
    type SortMode =
        | Min
        | Max
        | Sum
        | Avg
        | Median

    [<RequireQualifiedAccess>]
    type DistanceUnit =
        | In
        | Ft
        | Yd
        | Mi
        | Nmi
        | Km
        | M
        | Cm
        | Mm

    type NestedSortValue = {
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_children")>]
        MaxChildren: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("nested")>]
        Nested: NestedSortValue option
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: Field
    }

    type GeoDistanceSort = {
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: SortMode option
        [<System.Text.Json.Serialization.JsonPropertyName("distance_type")>]
        DistanceType: GeoDistanceType option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unmapped")>]
        IgnoreUnmapped: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: SortOrder option
        [<System.Text.Json.Serialization.JsonPropertyName("unit")>]
        Unit: DistanceUnit option
        [<System.Text.Json.Serialization.JsonPropertyName("nested")>]
        Nested: NestedSortValue option
    }

    [<RequireQualifiedAccess>]
    type ScriptSortType =
        | String
        | Number
        | Version

    type ScriptSort = {
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: SortOrder option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: ScriptSortType option
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: SortMode option
        [<System.Text.Json.Serialization.JsonPropertyName("nested")>]
        Nested: NestedSortValue option
    }

    [<RequireQualifiedAccess>]
    type SortOptions =
        | Score of ScoreSort
        | Doc of ScoreSort
        | GeoDistance of GeoDistanceSort
        | Script of ScriptSort

    [<RequireQualifiedAccess>]
    type SortCombinations =
        | Field of Field
        | SortOptions of SortOptions

    [<RequireQualifiedAccess>]
    type Sort =
        | SortCombinations of SortCombinations
        | Array of SortCombinations list

    type BucketSortAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        From: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("gap_policy")>]
        GapPolicy: GapPolicy option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: Sort option
    }

    /// A sibling pipeline aggregation which executes a two sample Kolmogorov–Smirnov test (referred
    type BucketKsAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("alternative")>]
        Alternative: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("fractions")>]
        Fractions: Double list option
        [<System.Text.Json.Serialization.JsonPropertyName("sampling_method")>]
        SamplingMethod: string option
    }

    type BucketCorrelationFunctionCountCorrelationIndicator = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc_count")>]
        DocCount: Integer
        [<System.Text.Json.Serialization.JsonPropertyName("expectations")>]
        Expectations: Double list
        [<System.Text.Json.Serialization.JsonPropertyName("fractions")>]
        Fractions: Double list option
    }

    type BucketCorrelationFunctionCountCorrelation = {
        [<System.Text.Json.Serialization.JsonPropertyName("indicator")>]
        Indicator: BucketCorrelationFunctionCountCorrelationIndicator
    }

    type BucketCorrelationFunction = {
        [<System.Text.Json.Serialization.JsonPropertyName("count_correlation")>]
        CountCorrelation: BucketCorrelationFunctionCountCorrelation
    }

    /// A sibling pipeline aggregation which executes a correlation function on the configured sibling multi-bucket aggregation.
    type BucketCorrelationAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("function")>]
        Function: BucketCorrelationFunction
    }

    [<RequireQualifiedAccess>]
    type CardinalityExecutionMode =
        | GlobalOrdinals
        | SegmentOrdinals
        | Direct
        | SaveMemoryHeuristic
        | SaveTimeHeuristic

    type CardinalityAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("precision_threshold")>]
        PrecisionThreshold: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("rehash")>]
        Rehash: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("execution_hint")>]
        ExecutionHint: CardinalityExecutionMode option
    }

    type CartesianBoundsAggregation = System.Text.Json.JsonElement

    type CartesianCentroidAggregation = System.Text.Json.JsonElement

    type CustomCategorizeTextAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("char_filter")>]
        CharFilter: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("tokenizer")>]
        Tokenizer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: string list option
    }

    [<RequireQualifiedAccess>]
    type CategorizeTextAnalyzer =
        | String of string
        | CustomCategorizeTextAnalyzer of CustomCategorizeTextAnalyzer

    /// A multi-bucket aggregation that groups semi-structured text into buckets. Each text
    type CategorizeTextAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field
        [<System.Text.Json.Serialization.JsonPropertyName("max_unique_tokens")>]
        MaxUniqueTokens: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_matched_tokens")>]
        MaxMatchedTokens: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity_threshold")>]
        SimilarityThreshold: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_filters")>]
        CategorizationFilters: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_analyzer")>]
        CategorizationAnalyzer: CategorizeTextAnalyzer option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_count")>]
        MinDocCount: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_min_doc_count")>]
        ShardMinDocCount: Integer option
    }

    type ChangePointAggregation = System.Text.Json.JsonElement

    type ChildrenAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: RelationName option
    }

    [<RequireQualifiedAccess>]
    type MissingOrder =
        | First
        | Last
        | Default

    [<RequireQualifiedAccess>]
    type ValueType =
        | String
        | Long
        | Double
        | Number
        | Date
        | DateNanos
        | Ip
        | Numeric
        | GeoPoint
        | Boolean

    type CompositeAggregationBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("missing_bucket")>]
        MissingBucket: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("missing_order")>]
        MissingOrder: MissingOrder option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script option
        [<System.Text.Json.Serialization.JsonPropertyName("value_type")>]
        ValueType: ValueType option
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: SortOrder option
    }

    type CompositeTermsAggregation = System.Text.Json.JsonElement

    type CompositeHistogramAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("interval")>]
        Interval: Double
    }

    type CompositeDateHistogramAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("calendar_interval")>]
        CalendarInterval: DurationLarge option
        [<System.Text.Json.Serialization.JsonPropertyName("fixed_interval")>]
        FixedInterval: DurationLarge option
        [<System.Text.Json.Serialization.JsonPropertyName("offset")>]
        Offset: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("time_zone")>]
        TimeZone: TimeZone option
    }

    type CompositeGeoTileGridAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("precision")>]
        Precision: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("bounds")>]
        Bounds: GeoBounds option
    }

    [<RequireQualifiedAccess>]
    type CompositeAggregationSource =
        | Terms of CompositeTermsAggregation
        | Histogram of CompositeHistogramAggregation
        | DateHistogram of CompositeDateHistogramAggregation
        | GeotileGrid of CompositeGeoTileGridAggregation

    type CompositeAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("after")>]
        After: CompositeAggregateKey option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("sources")>]
        Sources: Map<string, CompositeAggregationSource> list option
    }

    type CumulativeCardinalityAggregation = System.Text.Json.JsonElement

    type CumulativeSumAggregation = System.Text.Json.JsonElement

    [<RequireQualifiedAccess>]
    type CalendarInterval =
        | Second
        | Minute
        | Hour
        | Day
        | Week
        | Month
        | Quarter
        | Year

    type ExtendedBounds<'t> = {
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: 't option
        [<System.Text.Json.Serialization.JsonPropertyName("min")>]
        Min: 't option
    }

    /// A date range limit, represented either as a DateMath expression or a number expressed
    [<RequireQualifiedAccess>]
    type FieldDateMath =
        | DateMath of DateMath
        | Double of Double

    type DateHistogramAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("calendar_interval")>]
        CalendarInterval: CalendarInterval option
        [<System.Text.Json.Serialization.JsonPropertyName("extended_bounds")>]
        ExtendedBounds: ExtendedBounds<FieldDateMath> option
        [<System.Text.Json.Serialization.JsonPropertyName("hard_bounds")>]
        HardBounds: ExtendedBounds<FieldDateMath> option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("fixed_interval")>]
        FixedInterval: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("interval")>]
        Interval: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_count")>]
        MinDocCount: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("offset")>]
        Offset: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: AggregateOrder option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script option
        [<System.Text.Json.Serialization.JsonPropertyName("time_zone")>]
        TimeZone: TimeZone option
        [<System.Text.Json.Serialization.JsonPropertyName("keyed")>]
        Keyed: bool option
    }

    type DateRangeExpression = {
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        From: FieldDateMath option
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: string option
        [<System.Text.Json.Serialization.JsonPropertyName("to")>]
        To: FieldDateMath option
    }

    type DateRangeAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: Missing option
        [<System.Text.Json.Serialization.JsonPropertyName("ranges")>]
        Ranges: DateRangeExpression list option
        [<System.Text.Json.Serialization.JsonPropertyName("time_zone")>]
        TimeZone: TimeZone option
        [<System.Text.Json.Serialization.JsonPropertyName("keyed")>]
        Keyed: bool option
    }

    type DerivativeAggregation = System.Text.Json.JsonElement

    [<RequireQualifiedAccess>]
    type SamplerAggregationExecutionHint =
        | Map
        | GlobalOrdinals
        | BytesHash

    type DiversifiedSamplerAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("execution_hint")>]
        ExecutionHint: SamplerAggregationExecutionHint option
        [<System.Text.Json.Serialization.JsonPropertyName("max_docs_per_value")>]
        MaxDocsPerValue: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field option
    }

    type ExtendedStatsAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("sigma")>]
        Sigma: Double option
    }

    type ExtendedStatsBucketAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("sigma")>]
        Sigma: Double option
    }

    [<RequireQualifiedAccess>]
    type TermsExclude =
        | String of string
        | Array of string list

    type TermsPartition = {
        [<System.Text.Json.Serialization.JsonPropertyName("num_partitions")>]
        NumPartitions: Long
        [<System.Text.Json.Serialization.JsonPropertyName("partition")>]
        Partition: Long
    }

    [<RequireQualifiedAccess>]
    type TermsInclude =
        | String of string
        | Array of string list
        | TermsPartition of TermsPartition

    type FrequentItemSetsField = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field
        [<System.Text.Json.Serialization.JsonPropertyName("exclude")>]
        Exclude: TermsExclude option
        [<System.Text.Json.Serialization.JsonPropertyName("include")>]
        Include: TermsInclude option
    }

    type FrequentItemSetsAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: FrequentItemSetsField list
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_set_size")>]
        MinimumSetSize: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_support")>]
        MinimumSupport: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: QueryContainer option
    }

    type FiltersAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("filters")>]
        Filters: Buckets<QueryContainer> option
        [<System.Text.Json.Serialization.JsonPropertyName("other_bucket")>]
        OtherBucket: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("other_bucket_key")>]
        OtherBucketKey: string option
        [<System.Text.Json.Serialization.JsonPropertyName("keyed")>]
        Keyed: bool option
    }

    type GeoBoundsAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("wrap_longitude")>]
        WrapLongitude: bool option
    }

    type GeoCentroidAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Long option
        [<System.Text.Json.Serialization.JsonPropertyName("location")>]
        Location: GeoLocation option
    }

    type AggregationRange = {
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        From: Double option option
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: string option
        [<System.Text.Json.Serialization.JsonPropertyName("to")>]
        To: Double option option
    }

    type GeoDistanceAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("distance_type")>]
        DistanceType: GeoDistanceType option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("origin")>]
        Origin: GeoLocation option
        [<System.Text.Json.Serialization.JsonPropertyName("ranges")>]
        Ranges: AggregationRange list option
        [<System.Text.Json.Serialization.JsonPropertyName("unit")>]
        Unit: DistanceUnit option
    }

    /// A precision that can be expressed as a geohash length between 1 and 12, or a distance measure like "1km", "10m".
    [<RequireQualifiedAccess>]
    type GeoHashPrecision =
        | Integer of Integer
        | String of string

    type GeoHashGridAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("bounds")>]
        Bounds: GeoBounds option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("precision")>]
        Precision: GeoHashPrecision option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Integer option
    }

    type GeoLinePoint = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field
    }

    type GeoLineSort = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field
    }

    type GeoLineAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("point")>]
        Point: GeoLinePoint
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: GeoLineSort option
        [<System.Text.Json.Serialization.JsonPropertyName("include_sort")>]
        IncludeSort: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("sort_order")>]
        SortOrder: SortOrder option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Integer option
    }

    type GeoTilePrecision = Integer

    type GeoTileGridAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("precision")>]
        Precision: GeoTilePrecision option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("bounds")>]
        Bounds: GeoBounds option
    }

    type GeohexGridAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field
        [<System.Text.Json.Serialization.JsonPropertyName("precision")>]
        Precision: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("bounds")>]
        Bounds: GeoBounds option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: Integer option
    }

    type GlobalAggregation = System.Text.Json.JsonElement

    type HistogramAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("extended_bounds")>]
        ExtendedBounds: ExtendedBounds<Double> option
        [<System.Text.Json.Serialization.JsonPropertyName("hard_bounds")>]
        HardBounds: ExtendedBounds<Double> option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("interval")>]
        Interval: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_count")>]
        MinDocCount: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("offset")>]
        Offset: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: AggregateOrder option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("keyed")>]
        Keyed: bool option
    }

    type IpRangeAggregationRange = {
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        From: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("mask")>]
        Mask: string option
        [<System.Text.Json.Serialization.JsonPropertyName("to")>]
        To: string option option
    }

    type IpRangeAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("ranges")>]
        Ranges: IpRangeAggregationRange list option
    }

    type IpPrefixAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field
        [<System.Text.Json.Serialization.JsonPropertyName("prefix_length")>]
        PrefixLength: Integer
        [<System.Text.Json.Serialization.JsonPropertyName("is_ipv6")>]
        IsIpv6: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("append_prefix_length")>]
        AppendPrefixLength: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("keyed")>]
        Keyed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_count")>]
        MinDocCount: Long option
    }

    [<RequireQualifiedAccess>]
    type InferenceConfigContainer =
        | Regression of MlTypes.RegressionInferenceOptions
        | Classification of MlTypes.ClassificationInferenceOptions

    type InferenceAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: Name
        [<System.Text.Json.Serialization.JsonPropertyName("inference_config")>]
        InferenceConfig: InferenceConfigContainer option
    }

    type MatrixAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: Map<Field, Double> option
    }

    type MatrixStatsAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: SortMode option
    }

    type MaxAggregation = System.Text.Json.JsonElement

    type MaxBucketAggregation = System.Text.Json.JsonElement

    type MedianAbsoluteDeviationAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("compression")>]
        Compression: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("execution_hint")>]
        ExecutionHint: TDigestExecutionHint option
    }

    type MinAggregation = System.Text.Json.JsonElement

    type MinBucketAggregation = System.Text.Json.JsonElement

    type MissingAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: Missing option
    }

    /// For empty Class assignments
    type EmptyObject = System.Text.Json.JsonElement

    type MovingAverageAggregationBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("minimize")>]
        Minimize: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("predict")>]
        Predict: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("window")>]
        Window: Integer option
    }

    type LinearMovingAverageAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("model")>]
        Model: string
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: EmptyObject
    }

    type SimpleMovingAverageAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("model")>]
        Model: string
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: EmptyObject
    }

    type EwmaModelSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("alpha")>]
        Alpha: Float option
    }

    type EwmaMovingAverageAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("model")>]
        Model: string
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: EwmaModelSettings
    }

    type HoltLinearModelSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("alpha")>]
        Alpha: Float option
        [<System.Text.Json.Serialization.JsonPropertyName("beta")>]
        Beta: Float option
    }

    type HoltMovingAverageAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("model")>]
        Model: string
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: HoltLinearModelSettings
    }

    [<RequireQualifiedAccess>]
    type HoltWintersType =
        | Add
        | Mult

    type HoltWintersModelSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("alpha")>]
        Alpha: Float option
        [<System.Text.Json.Serialization.JsonPropertyName("beta")>]
        Beta: Float option
        [<System.Text.Json.Serialization.JsonPropertyName("gamma")>]
        Gamma: Float option
        [<System.Text.Json.Serialization.JsonPropertyName("pad")>]
        Pad: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("period")>]
        Period: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: HoltWintersType option
    }

    type HoltWintersMovingAverageAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("model")>]
        Model: string
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: HoltWintersModelSettings
    }

    [<RequireQualifiedAccess>]
    type MovingAverageAggregation =
        | LinearMovingAverageAggregation of LinearMovingAverageAggregation
        | SimpleMovingAverageAggregation of SimpleMovingAverageAggregation
        | EwmaMovingAverageAggregation of EwmaMovingAverageAggregation
        | HoltMovingAverageAggregation of HoltMovingAverageAggregation
        | HoltWintersMovingAverageAggregation of HoltWintersMovingAverageAggregation

    type MovingPercentilesAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("window")>]
        Window: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("shift")>]
        Shift: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("keyed")>]
        Keyed: bool option
    }

    type MovingFunctionAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: string option
        [<System.Text.Json.Serialization.JsonPropertyName("shift")>]
        Shift: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("window")>]
        Window: Integer option
    }

    [<RequireQualifiedAccess>]
    type TermsAggregationCollectMode =
        | DepthFirst
        | BreadthFirst

    [<RequireQualifiedAccess>]
    type MultiTermLookup =
        | Field of Field
        | Script of Script

    and MultiTermLookupMeta = {
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: Missing option
    }

    type MultiTermsAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("collect_mode")>]
        CollectMode: TermsAggregationCollectMode option
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: AggregateOrder option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_count")>]
        MinDocCount: Long option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_min_doc_count")>]
        ShardMinDocCount: Long option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("show_term_doc_count_error")>]
        ShowTermDocCountError: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("terms")>]
        Terms: MultiTermLookup list
    }

    type NestedAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: Field option
    }

    [<RequireQualifiedAccess>]
    type NormalizeMethod =
        | Rescale01
        | Rescale0100
        | PercentOfSum
        | Mean
        | ZScore
        | Softmax

    type NormalizeAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("method")>]
        Method: NormalizeMethod option
    }

    type ParentAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: RelationName option
    }

    type HdrMethod = {
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_significant_value_digits")>]
        NumberOfSignificantValueDigits: Integer option
    }

    type TDigest = {
        [<System.Text.Json.Serialization.JsonPropertyName("compression")>]
        Compression: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("execution_hint")>]
        ExecutionHint: TDigestExecutionHint option
    }

    type PercentileRanksAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("keyed")>]
        Keyed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("values")>]
        Values: Double list option option
        [<System.Text.Json.Serialization.JsonPropertyName("hdr")>]
        Hdr: HdrMethod option
        [<System.Text.Json.Serialization.JsonPropertyName("tdigest")>]
        Tdigest: TDigest option
    }

    type PercentilesAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("keyed")>]
        Keyed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("percents")>]
        Percents: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("hdr")>]
        Hdr: HdrMethod option
        [<System.Text.Json.Serialization.JsonPropertyName("tdigest")>]
        Tdigest: TDigest option
    }

    type PercentilesBucketAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("percents")>]
        Percents: Double list option
    }

    type RangeAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("ranges")>]
        Ranges: AggregationRange list option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script option
        [<System.Text.Json.Serialization.JsonPropertyName("keyed")>]
        Keyed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
    }

    type RareTermsAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("exclude")>]
        Exclude: TermsExclude option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("include")>]
        Include: TermsInclude option
        [<System.Text.Json.Serialization.JsonPropertyName("max_doc_count")>]
        MaxDocCount: Long option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: Missing option
        [<System.Text.Json.Serialization.JsonPropertyName("precision")>]
        Precision: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("value_type")>]
        ValueType: string option
    }

    [<RequireQualifiedAccess>]
    type RateMode =
        | Sum
        | ValueCount

    type RateAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("unit")>]
        Unit: CalendarInterval option
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: RateMode option
    }

    type ReverseNestedAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: Field option
    }

    type RandomSamplerAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("probability")>]
        Probability: Double
        [<System.Text.Json.Serialization.JsonPropertyName("seed")>]
        Seed: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_seed")>]
        ShardSeed: Integer option
    }

    type SamplerAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: Integer option
    }

    type ScriptedMetricAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("combine_script")>]
        CombineScript: Script option
        [<System.Text.Json.Serialization.JsonPropertyName("init_script")>]
        InitScript: Script option
        [<System.Text.Json.Serialization.JsonPropertyName("map_script")>]
        MapScript: Script option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("reduce_script")>]
        ReduceScript: Script option
    }

    type SerialDifferencingAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("lag")>]
        Lag: Integer option
    }

    type ChiSquareHeuristic = {
        [<System.Text.Json.Serialization.JsonPropertyName("background_is_superset")>]
        BackgroundIsSuperset: bool
        [<System.Text.Json.Serialization.JsonPropertyName("include_negatives")>]
        IncludeNegatives: bool
    }

    [<RequireQualifiedAccess>]
    type TermsAggregationExecutionHint =
        | Map
        | GlobalOrdinals
        | GlobalOrdinalsHash
        | GlobalOrdinalsLowCardinality

    type GoogleNormalizedDistanceHeuristic = {
        [<System.Text.Json.Serialization.JsonPropertyName("background_is_superset")>]
        BackgroundIsSuperset: bool option
    }

    type MutualInformationHeuristic = {
        [<System.Text.Json.Serialization.JsonPropertyName("background_is_superset")>]
        BackgroundIsSuperset: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("include_negatives")>]
        IncludeNegatives: bool option
    }

    type PercentageScoreHeuristic = System.Text.Json.JsonElement

    type ScriptedHeuristic = {
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script
    }

    type PValueHeuristic = {
        [<System.Text.Json.Serialization.JsonPropertyName("background_is_superset")>]
        BackgroundIsSuperset: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("normalize_above")>]
        NormalizeAbove: Long option
    }

    type SignificantTermsAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("background_filter")>]
        BackgroundFilter: QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("chi_square")>]
        ChiSquare: ChiSquareHeuristic option
        [<System.Text.Json.Serialization.JsonPropertyName("exclude")>]
        Exclude: TermsExclude option
        [<System.Text.Json.Serialization.JsonPropertyName("execution_hint")>]
        ExecutionHint: TermsAggregationExecutionHint option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("gnd")>]
        Gnd: GoogleNormalizedDistanceHeuristic option
        [<System.Text.Json.Serialization.JsonPropertyName("include")>]
        Include: TermsInclude option
        [<System.Text.Json.Serialization.JsonPropertyName("jlh")>]
        Jlh: EmptyObject option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_count")>]
        MinDocCount: Long option
        [<System.Text.Json.Serialization.JsonPropertyName("mutual_information")>]
        MutualInformation: MutualInformationHeuristic option
        [<System.Text.Json.Serialization.JsonPropertyName("percentage")>]
        Percentage: PercentageScoreHeuristic option
        [<System.Text.Json.Serialization.JsonPropertyName("script_heuristic")>]
        ScriptHeuristic: ScriptedHeuristic option
        [<System.Text.Json.Serialization.JsonPropertyName("p_value")>]
        PValue: PValueHeuristic option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_min_doc_count")>]
        ShardMinDocCount: Long option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Integer option
    }

    type SignificantTextAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("background_filter")>]
        BackgroundFilter: QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("chi_square")>]
        ChiSquare: ChiSquareHeuristic option
        [<System.Text.Json.Serialization.JsonPropertyName("exclude")>]
        Exclude: TermsExclude option
        [<System.Text.Json.Serialization.JsonPropertyName("execution_hint")>]
        ExecutionHint: TermsAggregationExecutionHint option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("filter_duplicate_text")>]
        FilterDuplicateText: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("gnd")>]
        Gnd: GoogleNormalizedDistanceHeuristic option
        [<System.Text.Json.Serialization.JsonPropertyName("include")>]
        Include: TermsInclude option
        [<System.Text.Json.Serialization.JsonPropertyName("jlh")>]
        Jlh: EmptyObject option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_count")>]
        MinDocCount: Long option
        [<System.Text.Json.Serialization.JsonPropertyName("mutual_information")>]
        MutualInformation: MutualInformationHeuristic option
        [<System.Text.Json.Serialization.JsonPropertyName("percentage")>]
        Percentage: PercentageScoreHeuristic option
        [<System.Text.Json.Serialization.JsonPropertyName("script_heuristic")>]
        ScriptHeuristic: ScriptedHeuristic option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_min_doc_count")>]
        ShardMinDocCount: Long option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("source_fields")>]
        SourceFields: Fields option
    }

    type StatsAggregation = System.Text.Json.JsonElement

    type StatsBucketAggregation = System.Text.Json.JsonElement

    type StringStatsAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("show_distribution")>]
        ShowDistribution: bool option
    }

    type SumAggregation = System.Text.Json.JsonElement

    type SumBucketAggregation = System.Text.Json.JsonElement

    type TermsAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("collect_mode")>]
        CollectMode: TermsAggregationCollectMode option
        [<System.Text.Json.Serialization.JsonPropertyName("exclude")>]
        Exclude: TermsExclude option
        [<System.Text.Json.Serialization.JsonPropertyName("execution_hint")>]
        ExecutionHint: TermsAggregationExecutionHint option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("include")>]
        Include: TermsInclude option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_count")>]
        MinDocCount: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: Missing option
        [<System.Text.Json.Serialization.JsonPropertyName("missing_order")>]
        MissingOrder: MissingOrder option
        [<System.Text.Json.Serialization.JsonPropertyName("missing_bucket")>]
        MissingBucket: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("value_type")>]
        ValueType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: AggregateOrder option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_min_doc_count")>]
        ShardMinDocCount: Long option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("show_term_doc_count_error")>]
        ShowTermDocCountError: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
    }

    type TimeSeriesAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("keyed")>]
        Keyed: bool option
    }

    /// A reference to a field with formatting instructions on how to return the value
    type FieldAndFormat = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("include_unmapped")>]
        IncludeUnmapped: bool option
    }

    type ScriptField = {
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_failure")>]
        IgnoreFailure: bool option
    }

    type TopHitsAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("docvalue_fields")>]
        DocvalueFields: FieldAndFormat list option
        [<System.Text.Json.Serialization.JsonPropertyName("explain")>]
        Explain: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: FieldAndFormat list option
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        From: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("highlight")>]
        Highlight: GlobalSearchTypes.Highlight option
        [<System.Text.Json.Serialization.JsonPropertyName("script_fields")>]
        ScriptFields: Map<string, ScriptField> option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: Sort option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: GlobalSearchTypes.SourceConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("stored_fields")>]
        StoredFields: Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("track_scores")>]
        TrackScores: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("seq_no_primary_term")>]
        SeqNoPrimaryTerm: bool option
    }

    type TestPopulation = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: QueryContainer option
    }

    [<RequireQualifiedAccess>]
    type TTestType =
        | Paired
        | Homoscedastic
        | Heteroscedastic

    type TTestAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("a")>]
        A: TestPopulation option
        [<System.Text.Json.Serialization.JsonPropertyName("b")>]
        B: TestPopulation option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: TTestType option
    }

    type TopMetricsValue = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field
    }

    type TopMetricsAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("metrics")>]
        Metrics: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: Sort option
    }

    type FormattableMetricAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
    }

    type ValueCountAggregation = System.Text.Json.JsonElement

    type WeightedAverageValue = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script option
    }

    type WeightedAverageAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: WeightedAverageValue option
        [<System.Text.Json.Serialization.JsonPropertyName("value_type")>]
        ValueType: ValueType option
        [<System.Text.Json.Serialization.JsonPropertyName("weight")>]
        Weight: WeightedAverageValue option
    }

    type VariableWidthHistogramAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("buckets")>]
        Buckets: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("initial_buffer")>]
        InitialBuffer: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script option
    }

    [<RequireQualifiedAccess>]
    type AggregationContainer =
        | AdjacencyMatrix of AdjacencyMatrixAggregation
        | AutoDateHistogram of AutoDateHistogramAggregation
        | Avg of AverageAggregation
        | AvgBucket of AverageBucketAggregation
        | Boxplot of BoxplotAggregation
        | BucketScript of BucketScriptAggregation
        | BucketSelector of BucketSelectorAggregation
        | BucketSort of BucketSortAggregation
        | BucketCountKsTest of BucketKsAggregation
        | BucketCorrelation of BucketCorrelationAggregation
        | Cardinality of CardinalityAggregation
        | CartesianBounds of CartesianBoundsAggregation
        | CartesianCentroid of CartesianCentroidAggregation
        | CategorizeText of CategorizeTextAggregation
        | ChangePoint of ChangePointAggregation
        | Children of ChildrenAggregation
        | Composite of CompositeAggregation
        | CumulativeCardinality of CumulativeCardinalityAggregation
        | CumulativeSum of CumulativeSumAggregation
        | DateHistogram of DateHistogramAggregation
        | DateRange of DateRangeAggregation
        | Derivative of DerivativeAggregation
        | DiversifiedSampler of DiversifiedSamplerAggregation
        | ExtendedStats of ExtendedStatsAggregation
        | ExtendedStatsBucket of ExtendedStatsBucketAggregation
        | FrequentItemSets of FrequentItemSetsAggregation
        | Filter of QueryContainer
        | Filters of FiltersAggregation
        | GeoBounds of GeoBoundsAggregation
        | GeoCentroid of GeoCentroidAggregation
        | GeoDistance of GeoDistanceAggregation
        | GeohashGrid of GeoHashGridAggregation
        | GeoLine of GeoLineAggregation
        | GeotileGrid of GeoTileGridAggregation
        | GeohexGrid of GeohexGridAggregation
        | Global of GlobalAggregation
        | Histogram of HistogramAggregation
        | IpRange of IpRangeAggregation
        | IpPrefix of IpPrefixAggregation
        | Inference of InferenceAggregation
        | Line of GeoLineAggregation
        | MatrixStats of MatrixStatsAggregation
        | Max of MaxAggregation
        | MaxBucket of MaxBucketAggregation
        | MedianAbsoluteDeviation of MedianAbsoluteDeviationAggregation
        | Min of MinAggregation
        | MinBucket of MinBucketAggregation
        | Missing of MissingAggregation
        | MovingAvg of MovingAverageAggregation
        | MovingPercentiles of MovingPercentilesAggregation
        | MovingFn of MovingFunctionAggregation
        | MultiTerms of MultiTermsAggregation
        | Nested of NestedAggregation
        | Normalize of NormalizeAggregation
        | Parent of ParentAggregation
        | PercentileRanks of PercentileRanksAggregation
        | Percentiles of PercentilesAggregation
        | PercentilesBucket of PercentilesBucketAggregation
        | Range of RangeAggregation
        | RareTerms of RareTermsAggregation
        | Rate of RateAggregation
        | ReverseNested of ReverseNestedAggregation
        | RandomSampler of RandomSamplerAggregation
        | Sampler of SamplerAggregation
        | ScriptedMetric of ScriptedMetricAggregation
        | SerialDiff of SerialDifferencingAggregation
        | SignificantTerms of SignificantTermsAggregation
        | SignificantText of SignificantTextAggregation
        | Stats of StatsAggregation
        | StatsBucket of StatsBucketAggregation
        | StringStats of StringStatsAggregation
        | Sum of SumAggregation
        | SumBucket of SumBucketAggregation
        | Terms of TermsAggregation
        | TimeSeries of TimeSeriesAggregation
        | TopHits of TopHitsAggregation
        | TTest of TTestAggregation
        | TopMetrics of TopMetricsAggregation
        | ValueCount of ValueCountAggregation
        | WeightedAvg of WeightedAverageAggregation
        | VariableWidthHistogram of VariableWidthHistogramAggregation
        | Unknown of name: string * System.Text.Json.JsonElement

    and AggregationContainerMeta = {
        [<System.Text.Json.Serialization.JsonPropertyName("aggregations")>]
        Aggregations: Map<string, AggregationContainer> option
        [<System.Text.Json.Serialization.JsonPropertyName("meta")>]
        Meta: Metadata option
    }

    type AllField = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
        [<System.Text.Json.Serialization.JsonPropertyName("omit_norms")>]
        OmitNorms: bool
        [<System.Text.Json.Serialization.JsonPropertyName("search_analyzer")>]
        SearchAnalyzer: string
        [<System.Text.Json.Serialization.JsonPropertyName("similarity")>]
        Similarity: string
        [<System.Text.Json.Serialization.JsonPropertyName("store")>]
        Store: bool
        [<System.Text.Json.Serialization.JsonPropertyName("store_term_vector_offsets")>]
        StoreTermVectorOffsets: bool
        [<System.Text.Json.Serialization.JsonPropertyName("store_term_vector_payloads")>]
        StoreTermVectorPayloads: bool
        [<System.Text.Json.Serialization.JsonPropertyName("store_term_vector_positions")>]
        StoreTermVectorPositions: bool
        [<System.Text.Json.Serialization.JsonPropertyName("store_term_vectors")>]
        StoreTermVectors: bool
    }

    type CustomAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("char_filter")>]
        CharFilter: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("position_increment_gap")>]
        PositionIncrementGap: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("position_offset_gap")>]
        PositionOffsetGap: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("tokenizer")>]
        Tokenizer: string
    }

    type VersionString = string

    type FingerprintAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("max_output_size")>]
        MaxOutputSize: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("separator")>]
        Separator: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    type KeywordAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: VersionString option
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
        Version: VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("decompound_mode")>]
        DecompoundMode: NoriDecompoundMode option
        [<System.Text.Json.Serialization.JsonPropertyName("stoptags")>]
        Stoptags: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("user_dictionary")>]
        UserDictionary: string option
    }

    type PatternAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("flags")>]
        Flags: string option
        [<System.Text.Json.Serialization.JsonPropertyName("lowercase")>]
        Lowercase: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("pattern")>]
        Pattern: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    type SimpleAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: VersionString option
    }

    type StandardAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("max_token_length")>]
        MaxTokenLength: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    type StopAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    type WhitespaceAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: VersionString option
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
        Method: IcuNormalizationType
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: IcuNormalizationMode
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
        Mode: KuromojiTokenizationMode option
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
        Version: VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("language")>]
        Language: SnowballLanguage
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
    }

    type ArabicAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type ArmenianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type BasqueAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type BengaliAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type BrazilianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    type BulgarianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type CatalanAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type ChineseAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    type CjkAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    type CzechAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type DanishAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    type DutchAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type EnglishAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type EstonianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    type FinnishAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type FrenchAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type GalicianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type GermanAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type GreekAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    type HindiAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type HungarianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type IndonesianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type IrishAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type ItalianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type LatvianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type LithuanianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type NorwegianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type PersianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    type PortugueseAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type RomanianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type RussianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type SerbianAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type SoraniAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type SpanishAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type SwedishAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type TurkishAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("stem_exclusion")>]
        StemExclusion: string list option
    }

    type ThaiAnalyzer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    [<RequireQualifiedAccess>]
    type Analyzer =
        | CustomAnalyzer of CustomAnalyzer
        | FingerprintAnalyzer of FingerprintAnalyzer
        | KeywordAnalyzer of KeywordAnalyzer
        | NoriAnalyzer of NoriAnalyzer
        | PatternAnalyzer of PatternAnalyzer
        | SimpleAnalyzer of SimpleAnalyzer
        | StandardAnalyzer of StandardAnalyzer
        | StopAnalyzer of StopAnalyzer
        | WhitespaceAnalyzer of WhitespaceAnalyzer
        | IcuAnalyzer of IcuAnalyzer
        | KuromojiAnalyzer of KuromojiAnalyzer
        | SnowballAnalyzer of SnowballAnalyzer
        | ArabicAnalyzer of ArabicAnalyzer
        | ArmenianAnalyzer of ArmenianAnalyzer
        | BasqueAnalyzer of BasqueAnalyzer
        | BengaliAnalyzer of BengaliAnalyzer
        | BrazilianAnalyzer of BrazilianAnalyzer
        | BulgarianAnalyzer of BulgarianAnalyzer
        | CatalanAnalyzer of CatalanAnalyzer
        | ChineseAnalyzer of ChineseAnalyzer
        | CjkAnalyzer of CjkAnalyzer
        | CzechAnalyzer of CzechAnalyzer
        | DanishAnalyzer of DanishAnalyzer
        | DutchAnalyzer of DutchAnalyzer
        | EnglishAnalyzer of EnglishAnalyzer
        | EstonianAnalyzer of EstonianAnalyzer
        | FinnishAnalyzer of FinnishAnalyzer
        | FrenchAnalyzer of FrenchAnalyzer
        | GalicianAnalyzer of GalicianAnalyzer
        | GermanAnalyzer of GermanAnalyzer
        | GreekAnalyzer of GreekAnalyzer
        | HindiAnalyzer of HindiAnalyzer
        | HungarianAnalyzer of HungarianAnalyzer
        | IndonesianAnalyzer of IndonesianAnalyzer
        | IrishAnalyzer of IrishAnalyzer
        | ItalianAnalyzer of ItalianAnalyzer
        | LatvianAnalyzer of LatvianAnalyzer
        | LithuanianAnalyzer of LithuanianAnalyzer
        | NorwegianAnalyzer of NorwegianAnalyzer
        | PersianAnalyzer of PersianAnalyzer
        | PortugueseAnalyzer of PortugueseAnalyzer
        | RomanianAnalyzer of RomanianAnalyzer
        | RussianAnalyzer of RussianAnalyzer
        | SerbianAnalyzer of SerbianAnalyzer
        | SoraniAnalyzer of SoraniAnalyzer
        | SpanishAnalyzer of SpanishAnalyzer
        | SwedishAnalyzer of SwedishAnalyzer
        | TurkishAnalyzer of TurkishAnalyzer
        | ThaiAnalyzer of ThaiAnalyzer
        | Unknown of name: string * System.Text.Json.JsonElement

    type TokenFilterBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: VersionString option
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

    /// Some APIs will return values such as numbers also as a string (notably epoch timestamps). This behavior
    [<RequireQualifiedAccess>]
    type Stringified<'t> =
        | T of 't
        | String of string

    type AsciiFoldingTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("preserve_original")>]
        PreserveOriginal: Stringified<bool> option
    }

    type Host = string

    type Ip = string

    [<RequireQualifiedAccess>]
    type NodeRole =
        | Master
        | Data
        | DataCold
        | DataContent
        | DataFrozen
        | DataHot
        | DataWarm
        | Client
        | Ingest
        | Ml
        | VotingOnly
        | Transform
        | RemoteClusterClient
        | CoordinatingOnly

    type NodeRoles = NodeRole list

    type TransportAddress = string

    type BaseNode = {
        [<System.Text.Json.Serialization.JsonPropertyName("attributes")>]
        Attributes: Map<string, string>
        [<System.Text.Json.Serialization.JsonPropertyName("host")>]
        Host: Host
        [<System.Text.Json.Serialization.JsonPropertyName("ip")>]
        Ip: Ip
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Name
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: NodeRoles option
        [<System.Text.Json.Serialization.JsonPropertyName("transport_address")>]
        TransportAddress: TransportAddress
    }

    type BengaliNormalizationTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type BrazilianStemTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    /// Cause and details about a request failure. This class defines the properties common to all error types.
    type ErrorCause = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("stack_trace")>]
        StackTrace: string option
        [<System.Text.Json.Serialization.JsonPropertyName("caused_by")>]
        CausedBy: ErrorCause option
        [<System.Text.Json.Serialization.JsonPropertyName("root_cause")>]
        RootCause: ErrorCause list option
        [<System.Text.Json.Serialization.JsonPropertyName("suppressed")>]
        Suppressed: ErrorCause list option
    }

    type BulkIndexByScrollFailure = {
        [<System.Text.Json.Serialization.JsonPropertyName("cause")>]
        Cause: ErrorCause
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Id
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: Integer
    }

    type DurationValue<'unit> = 'unit

    [<RequireQualifiedAccess>]
    type ByteSize =
        | Long of Long
        | String of string

    type BulkStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("total_operations")>]
        TotalOperations: Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_time")>]
        TotalTime: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_time_in_millis")>]
        TotalTimeInMillis: DurationValue<UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("total_size")>]
        TotalSize: ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_size_in_bytes")>]
        TotalSizeInBytes: Long
        [<System.Text.Json.Serialization.JsonPropertyName("avg_time")>]
        AvgTime: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("avg_time_in_millis")>]
        AvgTimeInMillis: DurationValue<UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("avg_size")>]
        AvgSize: ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("avg_size_in_bytes")>]
        AvgSizeInBytes: Long
    }

    [<RequireQualifiedAccess>]
    type Bytes =
        | B
        | Kb
        | Mb
        | Gb
        | Tb
        | Pb

    type CategoryId = Long

    type CharFilterBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: VersionString option
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
        Mode: IcuNormalizationMode option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: IcuNormalizationType option
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
        | HtmlStripCharFilter of HtmlStripCharFilter
        | MappingCharFilter of MappingCharFilter
        | PatternReplaceCharFilter of PatternReplaceCharFilter
        | IcuNormalizationCharFilter of IcuNormalizationCharFilter
        | KuromojiIterationMarkCharFilter of KuromojiIterationMarkCharFilter
        | Unknown of name: string * System.Text.Json.JsonElement

    [<RequireQualifiedAccess>]
    type CharFilter =
        | String of string
        | CharFilterDefinition of CharFilterDefinition

    type TokenizerBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: VersionString option
    }

    type CharGroupTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("tokenize_on_chars")>]
        TokenizeOnChars: string list
        [<System.Text.Json.Serialization.JsonPropertyName("max_token_length")>]
        MaxTokenLength: Integer option
    }

    type ChunkRescorerChunkingSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_chunk_size")>]
        MaxChunkSize: Integer
        [<System.Text.Json.Serialization.JsonPropertyName("overlap")>]
        Overlap: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("sentence_overlap")>]
        SentenceOverlap: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("separator_group")>]
        SeparatorGroup: string option
        [<System.Text.Json.Serialization.JsonPropertyName("separators")>]
        Separators: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("strategy")>]
        Strategy: string option
    }

    type ChunkRescorer = {
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: ChunkRescorerChunkingSettings option
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
        IgnoredScripts: CjkBigramIgnoredScript list option
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
        MaxTokenLength: Integer option
    }

    type ClusterAlias = string

    [<RequireQualifiedAccess>]
    type ClusterSearchStatus =
        | Running
        | Successful
        | Partial
        | Skipped
        | Failed

    type Uint = float

    type ShardFailure = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: string option
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: ErrorCause
        [<System.Text.Json.Serialization.JsonPropertyName("shard")>]
        Shard: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: string option
        [<System.Text.Json.Serialization.JsonPropertyName("primary")>]
        Primary: bool option
    }

    type ShardStatistics = {
        [<System.Text.Json.Serialization.JsonPropertyName("failed")>]
        Failed: Uint
        [<System.Text.Json.Serialization.JsonPropertyName("successful")>]
        Successful: Uint
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Uint
        [<System.Text.Json.Serialization.JsonPropertyName("failures")>]
        Failures: ShardFailure list option
        [<System.Text.Json.Serialization.JsonPropertyName("skipped")>]
        Skipped: Uint option
    }

    type ClusterDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: ClusterSearchStatus
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: string
        [<System.Text.Json.Serialization.JsonPropertyName("took")>]
        Took: DurationValue<UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("timed_out")>]
        TimedOut: bool
        [<System.Text.Json.Serialization.JsonPropertyName("_shards")>]
        Shards: ShardStatistics option
        [<System.Text.Json.Serialization.JsonPropertyName("failures")>]
        Failures: ShardFailure list option
    }

    [<RequireQualifiedAccess>]
    type ClusterInfoTarget =
        | All
        | Http
        | Ingest
        | ThreadPool
        | Script

    [<RequireQualifiedAccess>]
    type ClusterInfoTargets =
        | ClusterInfoTarget of ClusterInfoTarget
        | Array of ClusterInfoTarget list

    type ClusterStatistics = {
        [<System.Text.Json.Serialization.JsonPropertyName("skipped")>]
        Skipped: Integer
        [<System.Text.Json.Serialization.JsonPropertyName("successful")>]
        Successful: Integer
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Integer
        [<System.Text.Json.Serialization.JsonPropertyName("running")>]
        Running: Integer
        [<System.Text.Json.Serialization.JsonPropertyName("partial")>]
        Partial: Integer
        [<System.Text.Json.Serialization.JsonPropertyName("failed")>]
        Failed: Integer
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: Map<ClusterAlias, ClusterDetails> option
    }

    [<RequireQualifiedAccess>]
    type TimeUnit =
        | Nanos
        | Micros
        | Ms
        | S
        | M
        | H
        | D

    /// Implements a set of common query parameters all Cat API's support.
    type CommonCatQueryParameters = {
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("help")>]
        Help: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("v")>]
        V: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("bytes")>]
        Bytes: Bytes option
        [<System.Text.Json.Serialization.JsonPropertyName("time")>]
        Time: TimeUnit option
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

    /// Implements a set of common query parameters all API's support.
    type CommonQueryParameters = {
        [<System.Text.Json.Serialization.JsonPropertyName("error_trace")>]
        ErrorTrace: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("filter_path")>]
        FilterPath: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("human")>]
        Human: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("pretty")>]
        Pretty: bool option
    }

    [<RequireQualifiedAccess>]
    type CommonStatsFlag =
        | All
        | Store
        | Indexing
        | Get
        | Search
        | Merge
        | Flush
        | Refresh
        | QueryCache
        | Fielddata
        | Docs
        | Warmer
        | Completion
        | Segments
        | Translog
        | RequestCache
        | Recovery
        | Bulk
        | ShardStats
        | Mappings
        | DenseVector
        | SparseVector

    [<RequireQualifiedAccess>]
    type CommonStatsFlags =
        | CommonStatsFlag of CommonStatsFlag
        | Array of CommonStatsFlag list

    type FieldSizeUsage = {
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("size_in_bytes")>]
        SizeInBytes: Long
    }

    type CompletionStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("size_in_bytes")>]
        SizeInBytes: Long
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<Field, FieldSizeUsage> option
    }

    [<RequireQualifiedAccess>]
    type RuntimeFieldType =
        | Boolean
        | Composite
        | Date
        | Double
        | GeoPoint
        | GeoShape
        | Ip
        | Keyword
        | Long
        | Lookup

    type CompositeSubField = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: RuntimeFieldType
    }

    type CompoundWordTokenFilterBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_subword_size")>]
        MaxSubwordSize: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_subword_size")>]
        MinSubwordSize: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_word_size")>]
        MinWordSize: Integer option
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
        Script: Script
    }

    [<RequireQualifiedAccess>]
    type Conflicts =
        | Abort
        | Proceed

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

    [<RequireQualifiedAccess>]
    type DFIIndependenceMeasure =
        | Standardized
        | Saturated
        | Chisquared

    [<RequireQualifiedAccess>]
    type DFRAfterEffect =
        | No
        | B
        | L

    [<RequireQualifiedAccess>]
    type DFRBasicModel =
        | Be
        | D
        | G
        | If
        | In
        | Ine
        | P

    type DataStreamName = string

    [<RequireQualifiedAccess>]
    type DataStreamNames =
        | DataStreamName of DataStreamName
        | Array of DataStreamName list

    type DataStreamTimestamp = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
    }

    type DecayPlacement<'tOrigin, 'tScale> = {
        [<System.Text.Json.Serialization.JsonPropertyName("decay")>]
        Decay: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("offset")>]
        Offset: 'tScale option
        [<System.Text.Json.Serialization.JsonPropertyName("scale")>]
        Scale: 'tScale option
        [<System.Text.Json.Serialization.JsonPropertyName("origin")>]
        Origin: 'tOrigin option
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
        Encoding: DelimitedPayloadEncoding option
    }

    type DictionaryDecompounderTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    [<RequireQualifiedAccess>]
    type DiversifyRetrieverTypes =
        | Mmr

    type SortResults = FieldValue list

    type RetrieverBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("min_score")>]
        MinScore: Float option
        [<System.Text.Json.Serialization.JsonPropertyName("_name")>]
        Name: string option
    }

    type StandardRetriever = {
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("search_after")>]
        SearchAfter: SortResults option
        [<System.Text.Json.Serialization.JsonPropertyName("terminate_after")>]
        TerminateAfter: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: Sort option
        [<System.Text.Json.Serialization.JsonPropertyName("collapse")>]
        Collapse: GlobalSearchTypes.FieldCollapse option
    }

    type KnnRetriever = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: string
        [<System.Text.Json.Serialization.JsonPropertyName("query_vector")>]
        QueryVector: QueryVector option
        [<System.Text.Json.Serialization.JsonPropertyName("query_vector_builder")>]
        QueryVectorBuilder: QueryVectorBuilder option
        [<System.Text.Json.Serialization.JsonPropertyName("k")>]
        K: Integer
        [<System.Text.Json.Serialization.JsonPropertyName("num_candidates")>]
        NumCandidates: Integer
        [<System.Text.Json.Serialization.JsonPropertyName("visit_percentage")>]
        VisitPercentage: Float option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity")>]
        Similarity: Float option
        [<System.Text.Json.Serialization.JsonPropertyName("rescore_vector")>]
        RescoreVector: RescoreVector option
    }

    [<RequireQualifiedAccess>]
    type ScoreNormalizer =
        | None
        | Minmax
        | L2Norm

    type SpecifiedDocument = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Id
    }

    type DiversifyRetriever = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: DiversifyRetrieverTypes
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: string
        [<System.Text.Json.Serialization.JsonPropertyName("retriever")>]
        Retriever: RetrieverContainer
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("rank_window_size")>]
        RankWindowSize: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("query_vector")>]
        QueryVector: QueryVector option
        [<System.Text.Json.Serialization.JsonPropertyName("query_vector_builder")>]
        QueryVectorBuilder: QueryVectorBuilder option
        [<System.Text.Json.Serialization.JsonPropertyName("lambda")>]
        Lambda: Float option
    }

    and [<RequireQualifiedAccess>] RetrieverContainer =
        | Standard of StandardRetriever
        | Knn of KnnRetriever
        | Rrf of RRFRetriever
        | TextSimilarityReranker of TextSimilarityReranker
        | Rule of RuleRetriever
        | Rescorer of RescorerRetriever
        | Linear of LinearRetriever
        | Pinned of PinnedRetriever
        | Diversify of DiversifyRetriever

    and RRFRetriever = {
        [<System.Text.Json.Serialization.JsonPropertyName("retrievers")>]
        Retrievers: RRFRetrieverEntry list
        [<System.Text.Json.Serialization.JsonPropertyName("rank_constant")>]
        RankConstant: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("rank_window_size")>]
        RankWindowSize: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: string list option
    }

    /// Either a direct RetrieverContainer (backward compatible) or an RRFRetrieverComponent with weight.
    and [<RequireQualifiedAccess>] RRFRetrieverEntry =
        | RetrieverContainer of RetrieverContainer
        | RRFRetrieverComponent of RRFRetrieverComponent

    /// Wraps a retriever with an optional weight for RRF scoring.
    and RRFRetrieverComponent = {
        [<System.Text.Json.Serialization.JsonPropertyName("retriever")>]
        Retriever: RetrieverContainer
        [<System.Text.Json.Serialization.JsonPropertyName("weight")>]
        Weight: Float option
    }

    and TextSimilarityReranker = {
        [<System.Text.Json.Serialization.JsonPropertyName("retriever")>]
        Retriever: RetrieverContainer
        [<System.Text.Json.Serialization.JsonPropertyName("rank_window_size")>]
        RankWindowSize: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_text")>]
        InferenceText: string
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: string
        [<System.Text.Json.Serialization.JsonPropertyName("chunk_rescorer")>]
        ChunkRescorer: ChunkRescorer option
    }

    and RuleRetriever = {
        [<System.Text.Json.Serialization.JsonPropertyName("ruleset_ids")>]
        RulesetIds: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("match_criteria")>]
        MatchCriteria: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("retriever")>]
        Retriever: RetrieverContainer
        [<System.Text.Json.Serialization.JsonPropertyName("rank_window_size")>]
        RankWindowSize: Integer option
    }

    and RescorerRetriever = {
        [<System.Text.Json.Serialization.JsonPropertyName("retriever")>]
        Retriever: RetrieverContainer
        [<System.Text.Json.Serialization.JsonPropertyName("rescore")>]
        Rescore: System.Text.Json.JsonElement
    }

    and LinearRetriever = {
        [<System.Text.Json.Serialization.JsonPropertyName("retrievers")>]
        Retrievers: InnerRetriever list option
        [<System.Text.Json.Serialization.JsonPropertyName("rank_window_size")>]
        RankWindowSize: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("normalizer")>]
        Normalizer: ScoreNormalizer option
    }

    and InnerRetriever = {
        [<System.Text.Json.Serialization.JsonPropertyName("retriever")>]
        Retriever: RetrieverContainer
        [<System.Text.Json.Serialization.JsonPropertyName("weight")>]
        Weight: Float
        [<System.Text.Json.Serialization.JsonPropertyName("normalizer")>]
        Normalizer: ScoreNormalizer
    }

    and PinnedRetriever = {
        [<System.Text.Json.Serialization.JsonPropertyName("retriever")>]
        Retriever: RetrieverContainer
        [<System.Text.Json.Serialization.JsonPropertyName("ids")>]
        Ids: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("docs")>]
        Docs: SpecifiedDocument list option
        [<System.Text.Json.Serialization.JsonPropertyName("rank_window_size")>]
        RankWindowSize: Integer option
    }

    type DocStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Long
        [<System.Text.Json.Serialization.JsonPropertyName("deleted")>]
        Deleted: Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_size_in_bytes")>]
        TotalSizeInBytes: Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_size")>]
        TotalSize: ByteSize option
    }

    type DutchStemTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type RuntimeFieldFetchFields = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
    }

    type RuntimeField = {
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<string, CompositeSubField> option
        [<System.Text.Json.Serialization.JsonPropertyName("fetch_fields")>]
        FetchFields: RuntimeFieldFetchFields list option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("input_field")>]
        InputField: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("target_index")>]
        TargetIndex: IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: RuntimeFieldType
    }

    [<RequireQualifiedAccess>]
    type MatchType =
        | Simple
        | Regex

    [<RequireQualifiedAccess>]
    type DynamicTemplate =
        | Mapping of Property
        | Runtime of RuntimeField

    and DynamicTemplateMeta = {
        [<System.Text.Json.Serialization.JsonPropertyName("match")>]
        Match: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("path_match")>]
        PathMatch: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("unmatch")>]
        Unmatch: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("path_unmatch")>]
        PathUnmatch: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("match_mapping_type")>]
        MatchMappingType: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("unmatch_mapping_type")>]
        UnmatchMappingType: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("match_pattern")>]
        MatchPattern: MatchType option
    }

    [<RequireQualifiedAccess>]
    type EdgeNGramSide =
        | Front
        | Back

    type EdgeNGramTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("max_gram")>]
        MaxGram: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_gram")>]
        MinGram: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("side")>]
        Side: EdgeNGramSide option
        [<System.Text.Json.Serialization.JsonPropertyName("preserve_original")>]
        PreserveOriginal: Stringified<bool> option
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
        MaxGram: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_gram")>]
        MinGram: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("token_chars")>]
        TokenChars: TokenChar list option
    }

    type ElasticsearchVersionInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("build_date")>]
        BuildDate: DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("build_flavor")>]
        BuildFlavor: string
        [<System.Text.Json.Serialization.JsonPropertyName("build_hash")>]
        BuildHash: string
        [<System.Text.Json.Serialization.JsonPropertyName("build_snapshot")>]
        BuildSnapshot: bool
        [<System.Text.Json.Serialization.JsonPropertyName("build_type")>]
        BuildType: string
        [<System.Text.Json.Serialization.JsonPropertyName("lucene_version")>]
        LuceneVersion: VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_index_compatibility_version")>]
        MinimumIndexCompatibilityVersion: VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_wire_compatibility_version")>]
        MinimumWireCompatibilityVersion: VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("number")>]
        Number: string
    }

    /// Reduced (minimal) info ElasticsearchVersion
    type ElasticsearchVersionMinInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("build_flavor")>]
        BuildFlavor: string
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_index_compatibility_version")>]
        MinimumIndexCompatibilityVersion: VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_wire_compatibility_version")>]
        MinimumWireCompatibilityVersion: VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("number")>]
        Number: string
    }

    type ElisionTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("articles")>]
        Articles: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("articles_path")>]
        ArticlesPath: string option
        [<System.Text.Json.Serialization.JsonPropertyName("articles_case")>]
        ArticlesCase: Stringified<bool> option
    }

    /// The response returned by Elasticsearch when request execution did not succeed.
    type ErrorResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: ErrorCause
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: Integer
    }

    [<RequireQualifiedAccess>]
    type ExpandWildcard =
        | All
        | Open
        | Closed
        | Hidden
        | None

    [<RequireQualifiedAccess>]
    type ExpandWildcards =
        | ExpandWildcard of ExpandWildcard
        | Array of ExpandWildcard list

    type FieldLookup = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Id
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: string option
    }

    type FieldMapping = {
        [<System.Text.Json.Serialization.JsonPropertyName("full_name")>]
        FullName: string
        [<System.Text.Json.Serialization.JsonPropertyName("mapping")>]
        Mapping: Map<Field, Property>
    }

    type FieldMemoryUsage = {
        [<System.Text.Json.Serialization.JsonPropertyName("memory_size")>]
        MemorySize: ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("memory_size_in_bytes")>]
        MemorySizeInBytes: Long
    }

    type FieldNamesField = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
    }

    [<RequireQualifiedAccess>]
    type FieldType =
        | None
        | GeoPoint
        | GeoShape
        | Ip
        | Binary
        | Keyword
        | Text
        | SearchAsYouType
        | Date
        | DateNanos
        | Boolean
        | Completion
        | Nested
        | Object
        | Passthrough
        | Version
        | Murmur3
        | TokenCount
        | Percolator
        | Integer
        | Long
        | Short
        | Byte
        | Float
        | HalfFloat
        | ScaledFloat
        | Double
        | IntegerRange
        | FloatRange
        | LongRange
        | DoubleRange
        | DateRange
        | IpRange
        | Alias
        | Join
        | RankFeature
        | RankFeatures
        | Flattened
        | Shape
        | Histogram
        | ConstantKeyword
        | CountedKeyword
        | AggregateMetricDouble
        | DenseVector
        | SemanticText
        | SparseVector
        | MatchOnlyText
        | IcuCollationKeyword

    [<RequireQualifiedAccess>]
    type FieldSortNumericType =
        | Long
        | Double
        | Date
        | DateNanos

    type FieldSort = {
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: Missing option
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: SortMode option
        [<System.Text.Json.Serialization.JsonPropertyName("nested")>]
        Nested: NestedSortValue option
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: SortOrder option
        [<System.Text.Json.Serialization.JsonPropertyName("unmapped_type")>]
        UnmappedType: FieldType option
        [<System.Text.Json.Serialization.JsonPropertyName("numeric_type")>]
        NumericType: FieldSortNumericType option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
    }

    type GlobalOrdinalFieldStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("build_time_in_millis")>]
        BuildTimeInMillis: UnitMillis
        [<System.Text.Json.Serialization.JsonPropertyName("build_time")>]
        BuildTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_max_value_count")>]
        ShardMaxValueCount: Long
    }

    type GlobalOrdinalsStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("build_time_in_millis")>]
        BuildTimeInMillis: UnitMillis
        [<System.Text.Json.Serialization.JsonPropertyName("build_time")>]
        BuildTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<Name, GlobalOrdinalFieldStats> option
    }

    type FielddataStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("evictions")>]
        Evictions: Long option
        [<System.Text.Json.Serialization.JsonPropertyName("memory_size")>]
        MemorySize: ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("memory_size_in_bytes")>]
        MemorySizeInBytes: Long
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<Field, FieldMemoryUsage> option
        [<System.Text.Json.Serialization.JsonPropertyName("global_ordinals")>]
        GlobalOrdinals: GlobalOrdinalsStats
    }

    type FingerprintTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("max_output_size")>]
        MaxOutputSize: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("separator")>]
        Separator: string option
    }

    type FlattenGraphTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type FlushStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("periodic")>]
        Periodic: Long
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_time")>]
        TotalTime: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_time_in_millis")>]
        TotalTimeInMillis: DurationValue<UnitMillis>
    }

    type FrenchStemTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type GeoPolygonPoints = {
        [<System.Text.Json.Serialization.JsonPropertyName("points")>]
        Points: GeoLocation list
    }

    /// A GeoJson shape, that can also use Elasticsearch's `envelope` extension.
    type GeoShape = System.Text.Json.JsonElement

    [<RequireQualifiedAccess>]
    type GeoShapeRelation =
        | Intersects
        | Disjoint
        | Within
        | Contains

    type GeoShapeFieldQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("shape")>]
        Shape: GeoShape option
        [<System.Text.Json.Serialization.JsonPropertyName("indexed_shape")>]
        IndexedShape: FieldLookup option
        [<System.Text.Json.Serialization.JsonPropertyName("relation")>]
        Relation: GeoShapeRelation option
    }

    type GermanNormalizationTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type GermanStemTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type GetStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("current")>]
        Current: Long
        [<System.Text.Json.Serialization.JsonPropertyName("exists_time")>]
        ExistsTime: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("exists_time_in_millis")>]
        ExistsTimeInMillis: DurationValue<UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("exists_total")>]
        ExistsTotal: Long
        [<System.Text.Json.Serialization.JsonPropertyName("missing_time")>]
        MissingTime: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("missing_time_in_millis")>]
        MissingTimeInMillis: DurationValue<UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("missing_total")>]
        MissingTotal: Long
        [<System.Text.Json.Serialization.JsonPropertyName("time")>]
        Time: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("time_in_millis")>]
        TimeInMillis: DurationValue<UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Long
    }

    type GrokPattern = string

    [<RequireQualifiedAccess>]
    type HealthStatus =
        | Green
        | Yellow
        | Red
        | Unknown
        | Unavailable

    type HindiNormalizationTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type HttpHeaders = Map<string, System.Text.Json.JsonElement>

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
    type IBDistribution =
        | Ll
        | Spl

    [<RequireQualifiedAccess>]
    type IBLambda =
        | Df
        | Ttf

    type IcuCollationTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("alternate")>]
        Alternate: IcuCollationAlternate option
        [<System.Text.Json.Serialization.JsonPropertyName("caseFirst")>]
        CaseFirst: IcuCollationCaseFirst option
        [<System.Text.Json.Serialization.JsonPropertyName("caseLevel")>]
        CaseLevel: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("country")>]
        Country: string option
        [<System.Text.Json.Serialization.JsonPropertyName("decomposition")>]
        Decomposition: IcuCollationDecomposition option
        [<System.Text.Json.Serialization.JsonPropertyName("hiraganaQuaternaryMode")>]
        HiraganaQuaternaryMode: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("language")>]
        Language: string option
        [<System.Text.Json.Serialization.JsonPropertyName("numeric")>]
        Numeric: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("rules")>]
        Rules: string option
        [<System.Text.Json.Serialization.JsonPropertyName("strength")>]
        Strength: IcuCollationStrength option
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
        Name: IcuNormalizationType
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
        Dir: IcuTransformDirection option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: string
    }

    type IndexAlias = string

    type IndexField = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
    }

    type IndexPattern = string

    type IndexPatterns = IndexPattern list

    type IndexingStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("index_current")>]
        IndexCurrent: Long
        [<System.Text.Json.Serialization.JsonPropertyName("delete_current")>]
        DeleteCurrent: Long
        [<System.Text.Json.Serialization.JsonPropertyName("delete_time")>]
        DeleteTime: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("delete_time_in_millis")>]
        DeleteTimeInMillis: DurationValue<UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("delete_total")>]
        DeleteTotal: Long
        [<System.Text.Json.Serialization.JsonPropertyName("is_throttled")>]
        IsThrottled: bool
        [<System.Text.Json.Serialization.JsonPropertyName("noop_update_total")>]
        NoopUpdateTotal: Long
        [<System.Text.Json.Serialization.JsonPropertyName("throttle_time")>]
        ThrottleTime: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("throttle_time_in_millis")>]
        ThrottleTimeInMillis: DurationValue<UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("index_time")>]
        IndexTime: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("index_time_in_millis")>]
        IndexTimeInMillis: DurationValue<UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("index_total")>]
        IndexTotal: Long
        [<System.Text.Json.Serialization.JsonPropertyName("index_failed")>]
        IndexFailed: Long
        [<System.Text.Json.Serialization.JsonPropertyName("types")>]
        Types: Map<string, IndexingStats> option
        [<System.Text.Json.Serialization.JsonPropertyName("write_load")>]
        WriteLoad: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("recent_write_load")>]
        RecentWriteLoad: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("peak_write_load")>]
        PeakWriteLoad: Double option
    }

    type IndicNormalizationTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    [<RequireQualifiedAccess>]
    type Indices =
        | IndexName of IndexName
        | Array of IndexName list

    /// Controls how to deal with unavailable concrete indices (closed or missing), how wildcard expressions are expanded
    type IndicesOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("allow_no_indices")>]
        AllowNoIndices: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: ExpandWildcards option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unavailable")>]
        IgnoreUnavailable: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_throttled")>]
        IgnoreThrottled: bool option
    }

    type IndicesResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("_shards")>]
        Shards: ShardStatistics option
    }

    type SequenceNumber = Long

    type InlineGet<'tDocument> = {
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("found")>]
        Found: bool
        [<System.Text.Json.Serialization.JsonPropertyName("_seq_no")>]
        SeqNo: SequenceNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("_primary_term")>]
        PrimaryTerm: Long option
        [<System.Text.Json.Serialization.JsonPropertyName("_routing")>]
        Routing: Routing option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: 'tDocument option
    }

    type JaStopTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords")>]
        Stopwords: StopWords option
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
        Mode: KeepTypesMode option
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
        BufferSize: Integer option
    }

    type KnnSearch = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field
        [<System.Text.Json.Serialization.JsonPropertyName("query_vector")>]
        QueryVector: QueryVector option
        [<System.Text.Json.Serialization.JsonPropertyName("query_vector_builder")>]
        QueryVectorBuilder: QueryVectorBuilder option
        [<System.Text.Json.Serialization.JsonPropertyName("k")>]
        K: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("num_candidates")>]
        NumCandidates: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("visit_percentage")>]
        VisitPercentage: Float option
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Float option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity")>]
        Similarity: Float option
        [<System.Text.Json.Serialization.JsonPropertyName("inner_hits")>]
        InnerHits: GlobalSearchTypes.InnerHits option
        [<System.Text.Json.Serialization.JsonPropertyName("rescore_vector")>]
        RescoreVector: RescoreVector option
        [<System.Text.Json.Serialization.JsonPropertyName("_name")>]
        Name: string option
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
        MinimumLength: Integer
    }

    type KuromojiTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("discard_punctuation")>]
        DiscardPunctuation: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: KuromojiTokenizationMode
        [<System.Text.Json.Serialization.JsonPropertyName("nbest_cost")>]
        NbestCost: Integer option
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
        Max: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min")>]
        Min: Integer option
    }

    type LetterTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    [<RequireQualifiedAccess>]
    type Level =
        | Cluster
        | Indices
        | Shards

    [<RequireQualifiedAccess>]
    type LifecycleOperationMode =
        | RUNNING
        | STOPPING
        | STOPPED

    type LimitTokenCountTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("consume_all_tokens")>]
        ConsumeAllTokens: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("max_token_count")>]
        MaxTokenCount: Stringified<Integer> option
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
        Language: LowercaseTokenFilterLanguages option
    }

    type LowercaseTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type MapboxVectorTiles = byte array

    type MergesStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("current")>]
        Current: Long
        [<System.Text.Json.Serialization.JsonPropertyName("current_docs")>]
        CurrentDocs: Long
        [<System.Text.Json.Serialization.JsonPropertyName("current_size")>]
        CurrentSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("current_size_in_bytes")>]
        CurrentSizeInBytes: Long
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_auto_throttle")>]
        TotalAutoThrottle: string option
        [<System.Text.Json.Serialization.JsonPropertyName("total_auto_throttle_in_bytes")>]
        TotalAutoThrottleInBytes: Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_docs")>]
        TotalDocs: Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_size")>]
        TotalSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("total_size_in_bytes")>]
        TotalSizeInBytes: Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_stopped_time")>]
        TotalStoppedTime: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_stopped_time_in_millis")>]
        TotalStoppedTimeInMillis: DurationValue<UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("total_throttled_time")>]
        TotalThrottledTime: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_throttled_time_in_millis")>]
        TotalThrottledTimeInMillis: DurationValue<UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("total_time")>]
        TotalTime: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_time_in_millis")>]
        TotalTimeInMillis: DurationValue<UnitMillis>
    }

    type MinHashTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("bucket_count")>]
        BucketCount: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("hash_count")>]
        HashCount: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("hash_set_size")>]
        HashSetSize: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("with_rotation")>]
        WithRotation: bool option
    }

    type MultiplexerTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("filters")>]
        Filters: string list
        [<System.Text.Json.Serialization.JsonPropertyName("preserve_original")>]
        PreserveOriginal: Stringified<bool> option
    }

    type NGramTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("max_gram")>]
        MaxGram: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_gram")>]
        MinGram: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("preserve_original")>]
        PreserveOriginal: Stringified<bool> option
    }

    type NGramTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("custom_token_chars")>]
        CustomTokenChars: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_gram")>]
        MaxGram: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_gram")>]
        MinGram: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("token_chars")>]
        TokenChars: TokenChar list option
    }

    [<RequireQualifiedAccess>]
    type Names =
        | Name of Name
        | Array of Name list

    type Namespace = string

    type NodeId = string

    type NodeName = string

    type NodeAttributes = {
        [<System.Text.Json.Serialization.JsonPropertyName("attributes")>]
        Attributes: Map<string, string>
        [<System.Text.Json.Serialization.JsonPropertyName("ephemeral_id")>]
        EphemeralId: Id
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: NodeId option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: NodeName
        [<System.Text.Json.Serialization.JsonPropertyName("transport_address")>]
        TransportAddress: TransportAddress
    }

    [<RequireQualifiedAccess>]
    type NodeIds =
        | NodeId of NodeId
        | Array of NodeId list

    type RelocationFailureInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("failed_attempts")>]
        FailedAttempts: Integer
    }

    type NodeShard = {
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: IndicesStats.ShardRoutingState
        [<System.Text.Json.Serialization.JsonPropertyName("primary")>]
        Primary: bool
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: NodeName option
        [<System.Text.Json.Serialization.JsonPropertyName("shard")>]
        Shard: Integer
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("allocation_id")>]
        AllocationId: Map<string, Id> option
        [<System.Text.Json.Serialization.JsonPropertyName("recovery_source")>]
        RecoverySource: Map<string, Id> option
        [<System.Text.Json.Serialization.JsonPropertyName("unassigned_info")>]
        UnassignedInfo: ClusterAllocationExplain.UnassignedInformation option
        [<System.Text.Json.Serialization.JsonPropertyName("relocating_node")>]
        RelocatingNode: NodeId option option
        [<System.Text.Json.Serialization.JsonPropertyName("relocation_failure_info")>]
        RelocationFailureInfo: RelocationFailureInfo option
    }

    /// Contains statistics about the number of nodes selected by the request.
    type NodeStatistics = {
        [<System.Text.Json.Serialization.JsonPropertyName("failures")>]
        Failures: ErrorCause list option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Integer
        [<System.Text.Json.Serialization.JsonPropertyName("successful")>]
        Successful: Integer
        [<System.Text.Json.Serialization.JsonPropertyName("failed")>]
        Failed: Integer
    }

    [<RequireQualifiedAccess>]
    type NodeStatsLevel =
        | Node
        | Indices
        | Shards

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
        DecompoundMode: NoriDecompoundMode option
        [<System.Text.Json.Serialization.JsonPropertyName("discard_punctuation")>]
        DiscardPunctuation: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("user_dictionary")>]
        UserDictionary: string option
        [<System.Text.Json.Serialization.JsonPropertyName("user_dictionary_rules")>]
        UserDictionaryRules: string list option
    }

    [<RequireQualifiedAccess>]
    type Normalization =
        | No
        | H1
        | H2
        | H3
        | Z

    [<RequireQualifiedAccess>]
    type Normalizer =
        | LowercaseNormalizer of LowercaseNormalizer
        | CustomNormalizer of CustomNormalizer

    /// A `null` value that is to be interpreted as an actual value, unless other uses of `null` that are equivalent
    type NullValue = unit

    [<RequireQualifiedAccess>]
    type OpType =
        | Index
        | Create

    /// A class that implements `OverloadOf` only needs to declare properties that differ from the parent.
    type OverloadOf<'tDefinition> = System.Text.Json.JsonElement

    type Password = string

    type PathHierarchyTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("buffer_size")>]
        BufferSize: Stringified<Integer> option
        [<System.Text.Json.Serialization.JsonPropertyName("delimiter")>]
        Delimiter: string option
        [<System.Text.Json.Serialization.JsonPropertyName("replacement")>]
        Replacement: string option
        [<System.Text.Json.Serialization.JsonPropertyName("reverse")>]
        Reverse: Stringified<bool> option
        [<System.Text.Json.Serialization.JsonPropertyName("skip")>]
        Skip: Stringified<Integer> option
    }

    type PatternCaptureTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("patterns")>]
        Patterns: string list
        [<System.Text.Json.Serialization.JsonPropertyName("preserve_original")>]
        PreserveOriginal: Stringified<bool> option
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
        Group: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("pattern")>]
        Pattern: string option
    }

    [<RequireQualifiedAccess>]
    type Percentage =
        | String of string
        | Float of Float

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
        Encoder: PhoneticEncoder
        [<System.Text.Json.Serialization.JsonPropertyName("languageset")>]
        Languageset: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("max_code_len")>]
        MaxCodeLen: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("name_type")>]
        NameType: PhoneticNameType option
        [<System.Text.Json.Serialization.JsonPropertyName("replace")>]
        Replace: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("rule_type")>]
        RuleType: PhoneticRuleType option
    }

    type PipelineName = string

    type PluginStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("classname")>]
        Classname: string
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string
        [<System.Text.Json.Serialization.JsonPropertyName("elasticsearch_version")>]
        ElasticsearchVersion: VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("extended_plugins")>]
        ExtendedPlugins: string list
        [<System.Text.Json.Serialization.JsonPropertyName("has_native_controller")>]
        HasNativeController: bool
        [<System.Text.Json.Serialization.JsonPropertyName("java_version")>]
        JavaVersion: VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Name
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("licensed")>]
        Licensed: bool
    }

    type PorterStemTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type PredicateTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Script
    }

    type ProjectRouting = string

    type QueryCacheStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("cache_count")>]
        CacheCount: Long
        [<System.Text.Json.Serialization.JsonPropertyName("cache_size")>]
        CacheSize: Long
        [<System.Text.Json.Serialization.JsonPropertyName("evictions")>]
        Evictions: Long
        [<System.Text.Json.Serialization.JsonPropertyName("hit_count")>]
        HitCount: Long
        [<System.Text.Json.Serialization.JsonPropertyName("memory_size")>]
        MemorySize: ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("memory_size_in_bytes")>]
        MemorySizeInBytes: Long
        [<System.Text.Json.Serialization.JsonPropertyName("miss_count")>]
        MissCount: Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_count")>]
        TotalCount: Long
    }

    type RankBase = System.Text.Json.JsonElement

    type RrfRank = {
        [<System.Text.Json.Serialization.JsonPropertyName("rank_constant")>]
        RankConstant: Long option
        [<System.Text.Json.Serialization.JsonPropertyName("rank_window_size")>]
        RankWindowSize: Long option
    }

    [<RequireQualifiedAccess>]
    type RankContainer =
        | Rrf of RrfRank

    type RecoveryStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("current_as_source")>]
        CurrentAsSource: Long
        [<System.Text.Json.Serialization.JsonPropertyName("current_as_target")>]
        CurrentAsTarget: Long
        [<System.Text.Json.Serialization.JsonPropertyName("throttle_time")>]
        ThrottleTime: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("throttle_time_in_millis")>]
        ThrottleTimeInMillis: DurationValue<UnitMillis>
    }

    [<RequireQualifiedAccess>]
    type Refresh =
        | True
        | False
        | WaitFor

    type RefreshStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("external_total")>]
        ExternalTotal: Long
        [<System.Text.Json.Serialization.JsonPropertyName("external_total_time_in_millis")>]
        ExternalTotalTimeInMillis: DurationValue<UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("listeners")>]
        Listeners: Long
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_time")>]
        TotalTime: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_time_in_millis")>]
        TotalTimeInMillis: DurationValue<UnitMillis>
    }

    type Retries = {
        [<System.Text.Json.Serialization.JsonPropertyName("bulk")>]
        Bulk: Long
        [<System.Text.Json.Serialization.JsonPropertyName("search")>]
        Search: Long
    }

    type ReindexStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("slice_id")>]
        SliceId: Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("batches")>]
        Batches: Long
        [<System.Text.Json.Serialization.JsonPropertyName("created")>]
        Created: Long option
        [<System.Text.Json.Serialization.JsonPropertyName("deleted")>]
        Deleted: Long
        [<System.Text.Json.Serialization.JsonPropertyName("noops")>]
        Noops: Long
        [<System.Text.Json.Serialization.JsonPropertyName("requests_per_second")>]
        RequestsPerSecond: Float
        [<System.Text.Json.Serialization.JsonPropertyName("retries")>]
        Retries: Retries
        [<System.Text.Json.Serialization.JsonPropertyName("throttled")>]
        Throttled: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("throttled_millis")>]
        ThrottledMillis: DurationValue<UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("throttled_until")>]
        ThrottledUntil: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("throttled_until_millis")>]
        ThrottledUntilMillis: DurationValue<UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Long
        [<System.Text.Json.Serialization.JsonPropertyName("updated")>]
        Updated: Long option
        [<System.Text.Json.Serialization.JsonPropertyName("version_conflicts")>]
        VersionConflicts: Long
        [<System.Text.Json.Serialization.JsonPropertyName("cancelled")>]
        Cancelled: string option
    }

    type RemoveDuplicatesTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type RequestBase = System.Text.Json.JsonElement

    type RequestCacheStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("evictions")>]
        Evictions: Long
        [<System.Text.Json.Serialization.JsonPropertyName("hit_count")>]
        HitCount: Long
        [<System.Text.Json.Serialization.JsonPropertyName("memory_size")>]
        MemorySize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("memory_size_in_bytes")>]
        MemorySizeInBytes: Long
        [<System.Text.Json.Serialization.JsonPropertyName("miss_count")>]
        MissCount: Long
    }

    [<RequireQualifiedAccess>]
    type Result =
        | Created
        | Updated
        | Deleted
        | NotFound
        | Noop

    type ReverseTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type RoutingField = {
        [<System.Text.Json.Serialization.JsonPropertyName("required")>]
        Required: bool
    }

    type RuntimeFields = Map<Field, RuntimeField>

    type RussianStemTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    /// A scalar value.
    [<RequireQualifiedAccess>]
    type ScalarValue =
        | Long of Long
        | Double of Double
        | String of string
        | Boolean of bool
        | Null of unit

    type ScandinavianFoldingTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type ScandinavianNormalizationTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type ScriptTransform = {
        [<System.Text.Json.Serialization.JsonPropertyName("lang")>]
        Lang: string option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: ScriptSource option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: string option
    }

    type ScrollId = string

    [<RequireQualifiedAccess>]
    type ScrollIds =
        | ScrollId of ScrollId
        | Array of ScrollId list

    type SearchStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("fetch_current")>]
        FetchCurrent: Long
        [<System.Text.Json.Serialization.JsonPropertyName("fetch_time")>]
        FetchTime: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("fetch_time_in_millis")>]
        FetchTimeInMillis: DurationValue<UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("fetch_total")>]
        FetchTotal: Long
        [<System.Text.Json.Serialization.JsonPropertyName("open_contexts")>]
        OpenContexts: Long option
        [<System.Text.Json.Serialization.JsonPropertyName("query_current")>]
        QueryCurrent: Long
        [<System.Text.Json.Serialization.JsonPropertyName("query_time")>]
        QueryTime: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("query_time_in_millis")>]
        QueryTimeInMillis: DurationValue<UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("query_total")>]
        QueryTotal: Long
        [<System.Text.Json.Serialization.JsonPropertyName("scroll_current")>]
        ScrollCurrent: Long
        [<System.Text.Json.Serialization.JsonPropertyName("scroll_time")>]
        ScrollTime: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("scroll_time_in_millis")>]
        ScrollTimeInMillis: DurationValue<UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("scroll_total")>]
        ScrollTotal: Long
        [<System.Text.Json.Serialization.JsonPropertyName("suggest_current")>]
        SuggestCurrent: Long
        [<System.Text.Json.Serialization.JsonPropertyName("suggest_time")>]
        SuggestTime: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("suggest_time_in_millis")>]
        SuggestTimeInMillis: DurationValue<UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("suggest_total")>]
        SuggestTotal: Long
        [<System.Text.Json.Serialization.JsonPropertyName("recent_search_load")>]
        RecentSearchLoad: Double option
        [<System.Text.Json.Serialization.JsonPropertyName("groups")>]
        Groups: Map<string, SearchStats> option
    }

    type SearchTransform = {
        [<System.Text.Json.Serialization.JsonPropertyName("request")>]
        Request: WatcherTypes.SearchInputRequestDefinition
        [<System.Text.Json.Serialization.JsonPropertyName("timeout")>]
        Timeout: Duration
    }

    [<RequireQualifiedAccess>]
    type SearchType =
        | QueryThenFetch
        | DfsQueryThenFetch

    type SegmentsStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Integer
        [<System.Text.Json.Serialization.JsonPropertyName("doc_values_memory")>]
        DocValuesMemory: ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("doc_values_memory_in_bytes")>]
        DocValuesMemoryInBytes: Long
        [<System.Text.Json.Serialization.JsonPropertyName("file_sizes")>]
        FileSizes: Map<string, IndicesStats.ShardFileSizeInfo>
        [<System.Text.Json.Serialization.JsonPropertyName("fixed_bit_set")>]
        FixedBitSet: ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("fixed_bit_set_memory_in_bytes")>]
        FixedBitSetMemoryInBytes: Long
        [<System.Text.Json.Serialization.JsonPropertyName("index_writer_memory")>]
        IndexWriterMemory: ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("index_writer_memory_in_bytes")>]
        IndexWriterMemoryInBytes: Long
        [<System.Text.Json.Serialization.JsonPropertyName("max_unsafe_auto_id_timestamp")>]
        MaxUnsafeAutoIdTimestamp: Long
        [<System.Text.Json.Serialization.JsonPropertyName("memory")>]
        Memory: ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("memory_in_bytes")>]
        MemoryInBytes: Long
        [<System.Text.Json.Serialization.JsonPropertyName("norms_memory")>]
        NormsMemory: ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("norms_memory_in_bytes")>]
        NormsMemoryInBytes: Long
        [<System.Text.Json.Serialization.JsonPropertyName("points_memory")>]
        PointsMemory: ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("points_memory_in_bytes")>]
        PointsMemoryInBytes: Long
        [<System.Text.Json.Serialization.JsonPropertyName("stored_fields_memory_in_bytes")>]
        StoredFieldsMemoryInBytes: Long
        [<System.Text.Json.Serialization.JsonPropertyName("stored_fields_memory")>]
        StoredFieldsMemory: ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("terms_memory_in_bytes")>]
        TermsMemoryInBytes: Long
        [<System.Text.Json.Serialization.JsonPropertyName("terms_memory")>]
        TermsMemory: ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("term_vectors_memory")>]
        TermVectorsMemory: ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("term_vectors_memory_in_bytes")>]
        TermVectorsMemoryInBytes: Long
        [<System.Text.Json.Serialization.JsonPropertyName("version_map_memory")>]
        VersionMapMemory: ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("version_map_memory_in_bytes")>]
        VersionMapMemoryInBytes: Long
    }

    type SerbianNormalizationTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type Service = string

    type ShapeFieldQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("indexed_shape")>]
        IndexedShape: FieldLookup option
        [<System.Text.Json.Serialization.JsonPropertyName("relation")>]
        Relation: GeoShapeRelation option
        [<System.Text.Json.Serialization.JsonPropertyName("shape")>]
        Shape: GeoShape option
    }

    type ShardsOperationResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("_shards")>]
        Shards: ShardStatistics option
    }

    type ShingleTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("filler_token")>]
        FillerToken: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_shingle_size")>]
        MaxShingleSize: Stringified<Integer> option
        [<System.Text.Json.Serialization.JsonPropertyName("min_shingle_size")>]
        MinShingleSize: Stringified<Integer> option
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

    type SizeField = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
    }

    type SlicedScroll = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Field option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Id
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: Integer
    }

    [<RequireQualifiedAccess>]
    type SlicesCalculation =
        | Auto

    /// Slices configuration used to parallelize a process.
    [<RequireQualifiedAccess>]
    type Slices =
        | Integer of Integer
        | SlicesCalculation of SlicesCalculation

    type SnowballTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("language")>]
        Language: SnowballLanguage option
    }

    type SoraniNormalizationTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    [<RequireQualifiedAccess>]
    type SourceFieldMode =
        | Disabled
        | Stored
        | Synthetic

    type SourceField = {
        [<System.Text.Json.Serialization.JsonPropertyName("compress")>]
        Compress: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("compress_threshold")>]
        CompressThreshold: string option
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("excludes")>]
        Excludes: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("includes")>]
        Includes: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: SourceFieldMode option
    }

    type StandardTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("max_token_length")>]
        MaxTokenLength: Integer option
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
        Stopwords: StopWords option
        [<System.Text.Json.Serialization.JsonPropertyName("stopwords_path")>]
        StopwordsPath: string option
    }

    type StoreStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("size_in_bytes")>]
        SizeInBytes: Long
        [<System.Text.Json.Serialization.JsonPropertyName("reserved")>]
        Reserved: ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("reserved_in_bytes")>]
        ReservedInBytes: Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_data_set_size")>]
        TotalDataSetSize: ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_data_set_size_in_bytes")>]
        TotalDataSetSizeInBytes: Long option
    }

    type StoredScript = {
        [<System.Text.Json.Serialization.JsonPropertyName("lang")>]
        Lang: ScriptLanguage
        [<System.Text.Json.Serialization.JsonPropertyName("options")>]
        Options: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: ScriptSource
    }

    type StreamResult = byte array

    [<RequireQualifiedAccess>]
    type SuggestMode =
        | Missing
        | Popular
        | Always

    /// The suggestion name as returned from the server. Depending whether typed_keys is specified this could come back
    type SuggestionName = string

    [<RequireQualifiedAccess>]
    type SynonymFormat =
        | Solr
        | Wordnet

    type SynonymTokenFilterBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("expand")>]
        Expand: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: SynonymFormat option
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

    type TaskFailure = {
        [<System.Text.Json.Serialization.JsonPropertyName("task_id")>]
        TaskId: Long
        [<System.Text.Json.Serialization.JsonPropertyName("node_id")>]
        NodeId: NodeId
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: string
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: ErrorCause
    }

    type TaskId = string

    type TermsLookup = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Id
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: Field
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: string option
    }

    [<RequireQualifiedAccess>]
    type TermsQueryField =
        | Array of FieldValue list
        | TermsLookup of TermsLookup

    type ThaiTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    [<RequireQualifiedAccess>]
    type ThreadType =
        | Cpu
        | Wait
        | Block
        | Gpu
        | Mem

    /// Time of day, expressed as HH:MM:SS
    type TimeOfDay = string

    type TrimTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type TruncateTokenFilter = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("length")>]
        Length: Integer option
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
        PreserveOriginal: Stringified<bool> option
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
        | ApostropheTokenFilter of ApostropheTokenFilter
        | ArabicStemTokenFilter of ArabicStemTokenFilter
        | ArabicNormalizationTokenFilter of ArabicNormalizationTokenFilter
        | AsciiFoldingTokenFilter of AsciiFoldingTokenFilter
        | BengaliNormalizationTokenFilter of BengaliNormalizationTokenFilter
        | BrazilianStemTokenFilter of BrazilianStemTokenFilter
        | CjkBigramTokenFilter of CjkBigramTokenFilter
        | CjkWidthTokenFilter of CjkWidthTokenFilter
        | ClassicTokenFilter of ClassicTokenFilter
        | CommonGramsTokenFilter of CommonGramsTokenFilter
        | ConditionTokenFilter of ConditionTokenFilter
        | CzechStemTokenFilter of CzechStemTokenFilter
        | DecimalDigitTokenFilter of DecimalDigitTokenFilter
        | DelimitedPayloadTokenFilter of DelimitedPayloadTokenFilter
        | DutchStemTokenFilter of DutchStemTokenFilter
        | EdgeNGramTokenFilter of EdgeNGramTokenFilter
        | ElisionTokenFilter of ElisionTokenFilter
        | FingerprintTokenFilter of FingerprintTokenFilter
        | FlattenGraphTokenFilter of FlattenGraphTokenFilter
        | FrenchStemTokenFilter of FrenchStemTokenFilter
        | GermanNormalizationTokenFilter of GermanNormalizationTokenFilter
        | GermanStemTokenFilter of GermanStemTokenFilter
        | HindiNormalizationTokenFilter of HindiNormalizationTokenFilter
        | HunspellTokenFilter of HunspellTokenFilter
        | HyphenationDecompounderTokenFilter of HyphenationDecompounderTokenFilter
        | IndicNormalizationTokenFilter of IndicNormalizationTokenFilter
        | KeepTypesTokenFilter of KeepTypesTokenFilter
        | KeepWordsTokenFilter of KeepWordsTokenFilter
        | KeywordMarkerTokenFilter of KeywordMarkerTokenFilter
        | KeywordRepeatTokenFilter of KeywordRepeatTokenFilter
        | KStemTokenFilter of KStemTokenFilter
        | LengthTokenFilter of LengthTokenFilter
        | LimitTokenCountTokenFilter of LimitTokenCountTokenFilter
        | LowercaseTokenFilter of LowercaseTokenFilter
        | MinHashTokenFilter of MinHashTokenFilter
        | MultiplexerTokenFilter of MultiplexerTokenFilter
        | NGramTokenFilter of NGramTokenFilter
        | NoriPartOfSpeechTokenFilter of NoriPartOfSpeechTokenFilter
        | PatternCaptureTokenFilter of PatternCaptureTokenFilter
        | PatternReplaceTokenFilter of PatternReplaceTokenFilter
        | PersianNormalizationTokenFilter of PersianNormalizationTokenFilter
        | PersianStemTokenFilter of PersianStemTokenFilter
        | PorterStemTokenFilter of PorterStemTokenFilter
        | PredicateTokenFilter of PredicateTokenFilter
        | RemoveDuplicatesTokenFilter of RemoveDuplicatesTokenFilter
        | ReverseTokenFilter of ReverseTokenFilter
        | RussianStemTokenFilter of RussianStemTokenFilter
        | ScandinavianFoldingTokenFilter of ScandinavianFoldingTokenFilter
        | ScandinavianNormalizationTokenFilter of ScandinavianNormalizationTokenFilter
        | SerbianNormalizationTokenFilter of SerbianNormalizationTokenFilter
        | ShingleTokenFilter of ShingleTokenFilter
        | SnowballTokenFilter of SnowballTokenFilter
        | SoraniNormalizationTokenFilter of SoraniNormalizationTokenFilter
        | StemmerOverrideTokenFilter of StemmerOverrideTokenFilter
        | StemmerTokenFilter of StemmerTokenFilter
        | StopTokenFilter of StopTokenFilter
        | SynonymGraphTokenFilter of SynonymGraphTokenFilter
        | SynonymTokenFilter of SynonymTokenFilter
        | TrimTokenFilter of TrimTokenFilter
        | TruncateTokenFilter of TruncateTokenFilter
        | UniqueTokenFilter of UniqueTokenFilter
        | UppercaseTokenFilter of UppercaseTokenFilter
        | WordDelimiterGraphTokenFilter of WordDelimiterGraphTokenFilter
        | WordDelimiterTokenFilter of WordDelimiterTokenFilter
        | JaStopTokenFilter of JaStopTokenFilter
        | KuromojiStemmerTokenFilter of KuromojiStemmerTokenFilter
        | KuromojiReadingFormTokenFilter of KuromojiReadingFormTokenFilter
        | KuromojiPartOfSpeechTokenFilter of KuromojiPartOfSpeechTokenFilter
        | IcuCollationTokenFilter of IcuCollationTokenFilter
        | IcuFoldingTokenFilter of IcuFoldingTokenFilter
        | IcuNormalizationTokenFilter of IcuNormalizationTokenFilter
        | IcuTransformTokenFilter of IcuTransformTokenFilter
        | PhoneticTokenFilter of PhoneticTokenFilter
        | DictionaryDecompounderTokenFilter of DictionaryDecompounderTokenFilter
        | Unknown of name: string * System.Text.Json.JsonElement

    [<RequireQualifiedAccess>]
    type TokenFilter =
        | String of string
        | TokenFilterDefinition of TokenFilterDefinition

    type UaxEmailUrlTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("max_token_length")>]
        MaxTokenLength: Integer option
    }

    type WhitespaceTokenizer = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("max_token_length")>]
        MaxTokenLength: Integer option
    }

    [<RequireQualifiedAccess>]
    type TokenizerDefinition =
        | CharGroupTokenizer of CharGroupTokenizer
        | ClassicTokenizer of ClassicTokenizer
        | EdgeNGramTokenizer of EdgeNGramTokenizer
        | KeywordTokenizer of KeywordTokenizer
        | LetterTokenizer of LetterTokenizer
        | LowercaseTokenizer of LowercaseTokenizer
        | NGramTokenizer of NGramTokenizer
        | PathHierarchyTokenizer of PathHierarchyTokenizer
        | PatternTokenizer of PatternTokenizer
        | SimplePatternTokenizer of SimplePatternTokenizer
        | SimplePatternSplitTokenizer of SimplePatternSplitTokenizer
        | StandardTokenizer of StandardTokenizer
        | ThaiTokenizer of ThaiTokenizer
        | UaxEmailUrlTokenizer of UaxEmailUrlTokenizer
        | WhitespaceTokenizer of WhitespaceTokenizer
        | IcuTokenizer of IcuTokenizer
        | KuromojiTokenizer of KuromojiTokenizer
        | NoriTokenizer of NoriTokenizer
        | Unknown of name: string * System.Text.Json.JsonElement

    [<RequireQualifiedAccess>]
    type Tokenizer =
        | String of string
        | TokenizerDefinition of TokenizerDefinition

    [<RequireQualifiedAccess>]
    type TransformContainer =
        | Chain of TransformContainer list
        | Script of ScriptTransform
        | Search of SearchTransform

    type TranslogStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("earliest_last_modified_age")>]
        EarliestLastModifiedAge: Long
        [<System.Text.Json.Serialization.JsonPropertyName("operations")>]
        Operations: Long
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: string option
        [<System.Text.Json.Serialization.JsonPropertyName("size_in_bytes")>]
        SizeInBytes: Long
        [<System.Text.Json.Serialization.JsonPropertyName("uncommitted_operations")>]
        UncommittedOperations: Integer
        [<System.Text.Json.Serialization.JsonPropertyName("uncommitted_size")>]
        UncommittedSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("uncommitted_size_in_bytes")>]
        UncommittedSizeInBytes: Long
    }

    type TypeMapping = {
        [<System.Text.Json.Serialization.JsonPropertyName("all_field")>]
        AllField: AllField option
        [<System.Text.Json.Serialization.JsonPropertyName("date_detection")>]
        DateDetection: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("dynamic")>]
        Dynamic: DynamicMapping option
        [<System.Text.Json.Serialization.JsonPropertyName("dynamic_date_formats")>]
        DynamicDateFormats: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("dynamic_templates")>]
        DynamicTemplates: Map<string, DynamicTemplate> list option
        [<System.Text.Json.Serialization.JsonPropertyName("_field_names")>]
        FieldNames: FieldNamesField option
        [<System.Text.Json.Serialization.JsonPropertyName("index_field")>]
        IndexField: IndexField option
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("numeric_detection")>]
        NumericDetection: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("properties")>]
        Properties: Map<PropertyName, Property> option
        [<System.Text.Json.Serialization.JsonPropertyName("_routing")>]
        Routing: RoutingField option
        [<System.Text.Json.Serialization.JsonPropertyName("_size")>]
        Size: SizeField option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: SourceField option
        [<System.Text.Json.Serialization.JsonPropertyName("runtime")>]
        Runtime: Map<string, RuntimeField> option
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("subobjects")>]
        Subobjects: Subobjects option
        [<System.Text.Json.Serialization.JsonPropertyName("_data_stream_timestamp")>]
        DataStreamTimestamp: DataStreamTimestamp option
    }

    /// Time unit for fractional milliseconds
    type UnitFloatMillis = Double

    /// Time unit for nanoseconds
    type UnitNanos = Long

    /// Time unit for seconds
    type UnitSeconds = Long

    type Username = string

    type Uuid = string

    [<RequireQualifiedAccess>]
    type WaitForActiveShardOptions =
        | All
        | IndexSetting

    [<RequireQualifiedAccess>]
    type WaitForActiveShards =
        | Integer of Integer
        | WaitForActiveShardOptions of WaitForActiveShardOptions

    [<RequireQualifiedAccess>]
    type WaitForEvents =
        | Immediate
        | Urgent
        | High
        | Normal
        | Low
        | Languid

    type WarmerStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("current")>]
        Current: Long
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_time")>]
        TotalTime: Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("total_time_in_millis")>]
        TotalTimeInMillis: DurationValue<UnitMillis>
    }

    /// `WithNullValue&lt;T&gt;` allows for explicit null assignments in contexts where `null` should be interpreted as an
    [<RequireQualifiedAccess>]
    type WithNullValue<'t> =
        | T of 't
        | NullValue of NullValue

    type WriteResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: Id
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("_primary_term")>]
        PrimaryTerm: Long option
        [<System.Text.Json.Serialization.JsonPropertyName("result")>]
        Result: Result
        [<System.Text.Json.Serialization.JsonPropertyName("_seq_no")>]
        SeqNo: SequenceNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("_shards")>]
        Shards: ShardStatistics
        [<System.Text.Json.Serialization.JsonPropertyName("_version")>]
        Version: VersionNumber
        [<System.Text.Json.Serialization.JsonPropertyName("failure_store")>]
        FailureStore: GlobalBulk.FailureStoreStatus option
        [<System.Text.Json.Serialization.JsonPropertyName("forced_refresh")>]
        ForcedRefresh: bool option
    }


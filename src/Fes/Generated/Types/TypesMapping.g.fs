// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module TypesMapping =

    [<RequireQualifiedAccess>]
    type TimeSeriesMetricType =
        | Gauge
        | Counter
        | Summary
        | Histogram
        | Position

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
        MaxChars: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("min_chars")>]
        MinChars: Types.Integer
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
        Oversample: Types.Float
    }

    type DenseVectorIndexOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("confidence_interval")>]
        ConfidenceInterval: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("ef_construction")>]
        EfConstruction: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("m")>]
        M: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: TypesMapping.DenseVectorIndexOptionsType
        [<System.Text.Json.Serialization.JsonPropertyName("rescore_vector")>]
        RescoreVector: TypesMapping.DenseVectorIndexOptionsRescoreVector option
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
        PruningConfig: Types.TokenPruningConfig option
    }

    type SemanticTextIndexOptions = {
        [<System.Text.Json.Serialization.JsonPropertyName("dense_vector")>]
        DenseVector: TypesMapping.DenseVectorIndexOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("sparse_vector")>]
        SparseVector: TypesMapping.SparseVectorIndexOptions option
    }

    type ChunkingSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("strategy")>]
        Strategy: string
        [<System.Text.Json.Serialization.JsonPropertyName("max_chunk_size")>]
        MaxChunkSize: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("overlap")>]
        Overlap: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("sentence_overlap")>]
        SentenceOverlap: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("separator_group")>]
        SeparatorGroup: string option
        [<System.Text.Json.Serialization.JsonPropertyName("separators")>]
        Separators: string list option
    }

    type SuggestContext = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: Types.Field option
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
        TimeSeriesMetric: TypesMapping.TimeSeriesMetricType option
    }

    and PropertyBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("meta")>]
        Meta: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("properties")>]
        Properties: Map<Types.PropertyName, TypesMapping.Property> option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_above")>]
        IgnoreAbove: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("dynamic")>]
        Dynamic: TypesMapping.DynamicMapping option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<Types.PropertyName, TypesMapping.Property> option
        [<System.Text.Json.Serialization.JsonPropertyName("synthetic_source_keep")>]
        SyntheticSourceKeep: TypesMapping.SyntheticSourceKeepEnum option
    }

    [<RequireQualifiedAccess>]
    and Property =
        | BinaryProperty of TypesMapping.BinaryProperty
        | BooleanProperty of TypesMapping.BooleanProperty
        | DynamicProperty of TypesMapping.DynamicProperty
        | JoinProperty of TypesMapping.JoinProperty
        | KeywordProperty of TypesMapping.KeywordProperty
        | MatchOnlyTextProperty of TypesMapping.MatchOnlyTextProperty
        | PercolatorProperty of TypesMapping.PercolatorProperty
        | RankFeatureProperty of TypesMapping.RankFeatureProperty
        | RankFeaturesProperty of TypesMapping.RankFeaturesProperty
        | SearchAsYouTypeProperty of TypesMapping.SearchAsYouTypeProperty
        | TextProperty of TypesMapping.TextProperty
        | VersionProperty of TypesMapping.VersionProperty
        | WildcardProperty of TypesMapping.WildcardProperty
        | DateNanosProperty of TypesMapping.DateNanosProperty
        | DateProperty of TypesMapping.DateProperty
        | AggregateMetricDoubleProperty of TypesMapping.AggregateMetricDoubleProperty
        | DenseVectorProperty of TypesMapping.DenseVectorProperty
        | FlattenedProperty of TypesMapping.FlattenedProperty
        | NestedProperty of TypesMapping.NestedProperty
        | ObjectProperty of TypesMapping.ObjectProperty
        | PassthroughObjectProperty of TypesMapping.PassthroughObjectProperty
        | RankVectorProperty of TypesMapping.RankVectorProperty
        | SemanticTextProperty of TypesMapping.SemanticTextProperty
        | SparseVectorProperty of TypesMapping.SparseVectorProperty
        | CompletionProperty of TypesMapping.CompletionProperty
        | ConstantKeywordProperty of TypesMapping.ConstantKeywordProperty
        | CountedKeywordProperty of TypesMapping.CountedKeywordProperty
        | FieldAliasProperty of TypesMapping.FieldAliasProperty
        | HistogramProperty of TypesMapping.HistogramProperty
        | ExponentialHistogramProperty of TypesMapping.ExponentialHistogramProperty
        | IpProperty of TypesMapping.IpProperty
        | Murmur3HashProperty of TypesMapping.Murmur3HashProperty
        | TokenCountProperty of TypesMapping.TokenCountProperty
        | GeoPointProperty of TypesMapping.GeoPointProperty
        | GeoShapeProperty of TypesMapping.GeoShapeProperty
        | PointProperty of TypesMapping.PointProperty
        | ShapeProperty of TypesMapping.ShapeProperty
        | ByteNumberProperty of TypesMapping.ByteNumberProperty
        | DoubleNumberProperty of TypesMapping.DoubleNumberProperty
        | FloatNumberProperty of TypesMapping.FloatNumberProperty
        | HalfFloatNumberProperty of TypesMapping.HalfFloatNumberProperty
        | IntegerNumberProperty of TypesMapping.IntegerNumberProperty
        | LongNumberProperty of TypesMapping.LongNumberProperty
        | ScaledFloatNumberProperty of TypesMapping.ScaledFloatNumberProperty
        | ShortNumberProperty of TypesMapping.ShortNumberProperty
        | UnsignedLongNumberProperty of TypesMapping.UnsignedLongNumberProperty
        | DateRangeProperty of TypesMapping.DateRangeProperty
        | DoubleRangeProperty of TypesMapping.DoubleRangeProperty
        | FloatRangeProperty of TypesMapping.FloatRangeProperty
        | IntegerRangeProperty of TypesMapping.IntegerRangeProperty
        | IpRangeProperty of TypesMapping.IpRangeProperty
        | LongRangeProperty of TypesMapping.LongRangeProperty
        | IcuCollationProperty of TypesMapping.IcuCollationProperty
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
        CopyTo: Types.Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("store")>]
        Store: bool option
    }

    and BooleanProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("fielddata")>]
        Fielddata: IndicesTypes.NumericFielddata option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_malformed")>]
        IgnoreMalformed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("on_script_error")>]
        OnScriptError: TypesMapping.OnScriptError option
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
        NullValue: Types.FieldValue option
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("coerce")>]
        Coerce: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("on_script_error")>]
        OnScriptError: TypesMapping.OnScriptError option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_malformed")>]
        IgnoreMalformed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("time_series_metric")>]
        TimeSeriesMetric: TypesMapping.TimeSeriesMetricType option
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("eager_global_ordinals")>]
        EagerGlobalOrdinals: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index_options")>]
        IndexOptions: TypesMapping.IndexOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("index_phrases")>]
        IndexPhrases: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index_prefixes")>]
        IndexPrefixes: TypesMapping.TextIndexPrefixes option option
        [<System.Text.Json.Serialization.JsonPropertyName("norms")>]
        Norms: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("position_increment_gap")>]
        PositionIncrementGap: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("search_analyzer")>]
        SearchAnalyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search_quote_analyzer")>]
        SearchQuoteAnalyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("term_vector")>]
        TermVector: TypesMapping.TermVectorOption option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("precision_step")>]
        PrecisionStep: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("locale")>]
        Locale: string option
    }

    and JoinProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("relations")>]
        Relations: Map<Types.RelationName, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("eager_global_ordinals")>]
        EagerGlobalOrdinals: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and KeywordProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("eager_global_ordinals")>]
        EagerGlobalOrdinals: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index_options")>]
        IndexOptions: TypesMapping.IndexOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("on_script_error")>]
        OnScriptError: TypesMapping.OnScriptError option
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
effectively stores data the same way as a text field that only indexes documents (index_opti...
    and MatchOnlyTextProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<Types.PropertyName, TypesMapping.Property> option
        [<System.Text.Json.Serialization.JsonPropertyName("meta")>]
        Meta: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("copy_to")>]
        CopyTo: Types.Fields option
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
        IndexOptions: TypesMapping.IndexOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("max_shingle_size")>]
        MaxShingleSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("norms")>]
        Norms: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("search_analyzer")>]
        SearchAnalyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search_quote_analyzer")>]
        SearchQuoteAnalyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity")>]
        Similarity: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("term_vector")>]
        TermVector: TypesMapping.TermVectorOption option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and TextProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("eager_global_ordinals")>]
        EagerGlobalOrdinals: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("fielddata")>]
        Fielddata: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("fielddata_frequency_filter")>]
        FielddataFrequencyFilter: IndicesTypes.FielddataFrequencyFilter option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index_options")>]
        IndexOptions: TypesMapping.IndexOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("index_phrases")>]
        IndexPhrases: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index_prefixes")>]
        IndexPrefixes: TypesMapping.TextIndexPrefixes option option
        [<System.Text.Json.Serialization.JsonPropertyName("norms")>]
        Norms: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("position_increment_gap")>]
        PositionIncrementGap: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("search_analyzer")>]
        SearchAnalyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search_quote_analyzer")>]
        SearchQuoteAnalyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity")>]
        Similarity: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("term_vector")>]
        TermVector: TypesMapping.TermVectorOption option
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
        Boost: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_malformed")>]
        IgnoreMalformed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("on_script_error")>]
        OnScriptError: TypesMapping.OnScriptError option
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("precision_step")>]
        PrecisionStep: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and DateProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("fielddata")>]
        Fielddata: IndicesTypes.NumericFielddata option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_malformed")>]
        IgnoreMalformed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("on_script_error")>]
        OnScriptError: TypesMapping.OnScriptError option
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("precision_step")>]
        PrecisionStep: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("locale")>]
        Locale: string option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and DenseVectorProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("dims")>]
        Dims: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("element_type")>]
        ElementType: TypesMapping.DenseVectorElementType option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index_options")>]
        IndexOptions: TypesMapping.DenseVectorIndexOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity")>]
        Similarity: TypesMapping.DenseVectorSimilarity option
    }

    and FlattenedProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("depth_limit")>]
        DepthLimit: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("doc_values")>]
        DocValues: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("eager_global_ordinals")>]
        EagerGlobalOrdinals: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index_options")>]
        IndexOptions: TypesMapping.IndexOptions option
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
        Subobjects: TypesMapping.Subobjects option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string option
    }

    and PassthroughObjectProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string option
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("priority")>]
        Priority: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("time_series_dimension")>]
        TimeSeriesDimension: bool option
    }

    /// Technical preview
    and RankVectorProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("element_type")>]
        ElementType: TypesMapping.RankVectorElementType option
        [<System.Text.Json.Serialization.JsonPropertyName("dims")>]
        Dims: Types.Integer option
    }

    and SemanticTextProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("meta")>]
        Meta: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_id")>]
        InferenceId: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("search_inference_id")>]
        SearchInferenceId: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("index_options")>]
        IndexOptions: TypesMapping.SemanticTextIndexOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("chunking_settings")>]
        ChunkingSettings: TypesMapping.ChunkingSettings option option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<Types.PropertyName, TypesMapping.Property> option
    }

    and SparseVectorProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("store")>]
        Store: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("index_options")>]
        IndexOptions: TypesMapping.SparseVectorIndexOptions option
    }

    and CompletionProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("analyzer")>]
        Analyzer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("contexts")>]
        Contexts: TypesMapping.SuggestContext list option
        [<System.Text.Json.Serialization.JsonPropertyName("max_input_length")>]
        MaxInputLength: Types.Integer option
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
        Path: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and HistogramProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_malformed")>]
        IgnoreMalformed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("time_series_metric")>]
        TimeSeriesMetric: TypesMapping.TimeSeriesMetricType option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and ExponentialHistogramProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("time_series_metric")>]
        TimeSeriesMetric: TypesMapping.TimeSeriesMetricType option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and IpProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_malformed")>]
        IgnoreMalformed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("on_script_error")>]
        OnScriptError: TypesMapping.OnScriptError option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
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
        Boost: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: Types.Double option
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
        NullValue: Types.GeoLocation option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("on_script_error")>]
        OnScriptError: TypesMapping.OnScriptError option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("time_series_metric")>]
        TimeSeriesMetric: TypesMapping.GeoPointMetricType option
    }

    /// The `geo_shape` data type facilitates the indexing of and searching with arbitrary geo shapes such as rectangles
and polygons.
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
        Orientation: TypesMapping.GeoOrientation option
        [<System.Text.Json.Serialization.JsonPropertyName("strategy")>]
        Strategy: TypesMapping.GeoStrategy option
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
rectangles and polygons.
    and ShapeProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("coerce")>]
        Coerce: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_malformed")>]
        IgnoreMalformed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_z_value")>]
        IgnoreZValue: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("orientation")>]
        Orientation: TypesMapping.GeoOrientation option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and ByteNumberProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: Types.Byte option
    }

    and NumberPropertyBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("coerce")>]
        Coerce: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_malformed")>]
        IgnoreMalformed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("on_script_error")>]
        OnScriptError: TypesMapping.OnScriptError option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("time_series_metric")>]
        TimeSeriesMetric: TypesMapping.TimeSeriesMetricType option
        [<System.Text.Json.Serialization.JsonPropertyName("time_series_dimension")>]
        TimeSeriesDimension: bool option
    }

    and DoubleNumberProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: Types.Double option
    }

    and FloatNumberProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: Types.Float option
    }

    and HalfFloatNumberProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: Types.Float option
    }

    and IntegerNumberProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: Types.Integer option
    }

    and LongNumberProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: Types.Long option
    }

    and ScaledFloatNumberProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("scaling_factor")>]
        ScalingFactor: Types.Double option
    }

    and ShortNumberProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: Types.Short option
    }

    and UnsignedLongNumberProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("null_value")>]
        NullValue: Types.Ulong option
    }

    and DateRangeProperty = {
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    and RangePropertyBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("boost")>]
        Boost: Types.Double option
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
        IndexOptions: TypesMapping.IndexOptions option
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
        Strength: TypesAnalysis.IcuCollationStrength option
        [<System.Text.Json.Serialization.JsonPropertyName("decomposition")>]
        Decomposition: TypesAnalysis.IcuCollationDecomposition option
        [<System.Text.Json.Serialization.JsonPropertyName("alternate")>]
        Alternate: TypesAnalysis.IcuCollationAlternate option
        [<System.Text.Json.Serialization.JsonPropertyName("case_level")>]
        CaseLevel: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("case_first")>]
        CaseFirst: TypesAnalysis.IcuCollationCaseFirst option
        [<System.Text.Json.Serialization.JsonPropertyName("numeric")>]
        Numeric: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("variable_top")>]
        VariableTop: string option
        [<System.Text.Json.Serialization.JsonPropertyName("hiragana_quaternary_mode")>]
        HiraganaQuaternaryMode: bool option
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

    type ChunkRescorerChunkingSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_chunk_size")>]
        MaxChunkSize: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("overlap")>]
        Overlap: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("sentence_overlap")>]
        SentenceOverlap: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("separator_group")>]
        SeparatorGroup: string option
        [<System.Text.Json.Serialization.JsonPropertyName("separators")>]
        Separators: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("strategy")>]
        Strategy: string option
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
        Type: TypesMapping.RuntimeFieldType
    }

    type DataStreamTimestamp = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
    }

    type RuntimeFieldFetchFields = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
    }

    type RuntimeField = {
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<string, TypesMapping.CompositeSubField> option
        [<System.Text.Json.Serialization.JsonPropertyName("fetch_fields")>]
        FetchFields: TypesMapping.RuntimeFieldFetchFields list option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("input_field")>]
        InputField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("target_index")>]
        TargetIndex: Types.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: TypesMapping.RuntimeFieldType
    }

    [<RequireQualifiedAccess>]
    type MatchType =
        | Simple
        | Regex

    [<RequireQualifiedAccess>]
    type DynamicTemplate =
        | Mapping of TypesMapping.Property
        | Runtime of TypesMapping.RuntimeField

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
        MatchPattern: TypesMapping.MatchType option
    }

    type FieldMapping = {
        [<System.Text.Json.Serialization.JsonPropertyName("full_name")>]
        FullName: string
        [<System.Text.Json.Serialization.JsonPropertyName("mapping")>]
        Mapping: Map<Types.Field, TypesMapping.Property>
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

    type IndexField = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
    }

    type RoutingField = {
        [<System.Text.Json.Serialization.JsonPropertyName("required")>]
        Required: bool
    }

    type RuntimeFields = Map<Types.Field, TypesMapping.RuntimeField>

    type SizeField = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
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
        Mode: TypesMapping.SourceFieldMode option
    }

    type TypeMapping = {
        [<System.Text.Json.Serialization.JsonPropertyName("all_field")>]
        AllField: TypesMapping.AllField option
        [<System.Text.Json.Serialization.JsonPropertyName("date_detection")>]
        DateDetection: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("dynamic")>]
        Dynamic: TypesMapping.DynamicMapping option
        [<System.Text.Json.Serialization.JsonPropertyName("dynamic_date_formats")>]
        DynamicDateFormats: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("dynamic_templates")>]
        DynamicTemplates: Map<string, TypesMapping.DynamicTemplate> list option
        [<System.Text.Json.Serialization.JsonPropertyName("_field_names")>]
        FieldNames: TypesMapping.FieldNamesField option
        [<System.Text.Json.Serialization.JsonPropertyName("index_field")>]
        IndexField: TypesMapping.IndexField option
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("numeric_detection")>]
        NumericDetection: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("properties")>]
        Properties: Map<Types.PropertyName, TypesMapping.Property> option
        [<System.Text.Json.Serialization.JsonPropertyName("_routing")>]
        Routing: TypesMapping.RoutingField option
        [<System.Text.Json.Serialization.JsonPropertyName("_size")>]
        Size: TypesMapping.SizeField option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: TypesMapping.SourceField option
        [<System.Text.Json.Serialization.JsonPropertyName("runtime")>]
        Runtime: Map<string, TypesMapping.RuntimeField> option
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("subobjects")>]
        Subobjects: TypesMapping.Subobjects option
        [<System.Text.Json.Serialization.JsonPropertyName("_data_stream_timestamp")>]
        DataStreamTimestamp: TypesMapping.DataStreamTimestamp option
    }


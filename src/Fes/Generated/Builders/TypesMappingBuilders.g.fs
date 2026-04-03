// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module TypesMappingBuilders =

    type AggregateMetricDoublePropertyBuilder() =
        member _.Yield(_: unit) : Types.AggregateMetricDoubleProperty =
            {
                Type = Unchecked.defaultof<_>
                DefaultMetric = Unchecked.defaultof<_>
                IgnoreMalformed = None
                Metrics = Unchecked.defaultof<_>
                TimeSeriesMetric = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.AggregateMetricDoubleProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("defaultMetric")>]
        member _.DefaultMetric(state: Types.AggregateMetricDoubleProperty, value: string) =
            { state with DefaultMetric = value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: Types.AggregateMetricDoubleProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("metrics")>]
        member _.Metrics(state: Types.AggregateMetricDoubleProperty, value: string list) =
            { state with Metrics = value }

        [<CustomOperation("timeSeriesMetric")>]
        member _.TimeSeriesMetric(state: Types.AggregateMetricDoubleProperty, value: Types.TimeSeriesMetricType) =
            { state with TimeSeriesMetric = Some value }

    let aggregateMetricDoubleProperty = AggregateMetricDoublePropertyBuilder()

    type BooleanPropertyBuilder() =
        member _.Yield(_: unit) : Types.BooleanProperty =
            {
                Boost = None
                Fielddata = None
                Index = None
                NullValue = None
                IgnoreMalformed = None
                Script = None
                OnScriptError = None
                TimeSeriesDimension = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.BooleanProperty, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("fielddata")>]
        member _.Fielddata(state: Types.BooleanProperty, value: Types.NumericFielddata) =
            { state with Fielddata = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.BooleanProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: Types.BooleanProperty, value: bool) =
            { state with NullValue = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: Types.BooleanProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.BooleanProperty, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: Types.BooleanProperty, value: Types.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("timeSeriesDimension")>]
        member _.TimeSeriesDimension(state: Types.BooleanProperty, value: bool) =
            { state with TimeSeriesDimension = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.BooleanProperty, value: string) =
            { state with Type = value }

    let booleanProperty = BooleanPropertyBuilder()

    type ChunkRescorerChunkingSettingsBuilder() =
        member _.Yield(_: unit) : Types.ChunkRescorerChunkingSettings =
            {
                MaxChunkSize = Unchecked.defaultof<_>
                Overlap = None
                SentenceOverlap = None
                SeparatorGroup = None
                Separators = None
                Strategy = None
            }

        [<CustomOperation("maxChunkSize")>]
        member _.MaxChunkSize(state: Types.ChunkRescorerChunkingSettings, value: Types.Integer) =
            { state with MaxChunkSize = value }

        [<CustomOperation("overlap")>]
        member _.Overlap(state: Types.ChunkRescorerChunkingSettings, value: Types.Integer) =
            { state with Overlap = Some value }

        [<CustomOperation("sentenceOverlap")>]
        member _.SentenceOverlap(state: Types.ChunkRescorerChunkingSettings, value: Types.Integer) =
            { state with SentenceOverlap = Some value }

        [<CustomOperation("separatorGroup")>]
        member _.SeparatorGroup(state: Types.ChunkRescorerChunkingSettings, value: string) =
            { state with SeparatorGroup = Some value }

        [<CustomOperation("separators")>]
        member _.Separators(state: Types.ChunkRescorerChunkingSettings, value: string list) =
            { state with Separators = Some value }

        [<CustomOperation("strategy")>]
        member _.Strategy(state: Types.ChunkRescorerChunkingSettings, value: string) =
            { state with Strategy = Some value }

    let chunkRescorerChunkingSettings = ChunkRescorerChunkingSettingsBuilder()

    type ChunkingSettingsBuilder() =
        member _.Yield(_: unit) : Types.ChunkingSettings =
            {
                Strategy = Unchecked.defaultof<_>
                MaxChunkSize = Unchecked.defaultof<_>
                Overlap = None
                SentenceOverlap = None
                SeparatorGroup = None
                Separators = None
            }

        [<CustomOperation("strategy")>]
        member _.Strategy(state: Types.ChunkingSettings, value: string) =
            { state with Strategy = value }

        [<CustomOperation("maxChunkSize")>]
        member _.MaxChunkSize(state: Types.ChunkingSettings, value: Types.Integer) =
            { state with MaxChunkSize = value }

        [<CustomOperation("overlap")>]
        member _.Overlap(state: Types.ChunkingSettings, value: Types.Integer) =
            { state with Overlap = Some value }

        [<CustomOperation("sentenceOverlap")>]
        member _.SentenceOverlap(state: Types.ChunkingSettings, value: Types.Integer) =
            { state with SentenceOverlap = Some value }

        [<CustomOperation("separatorGroup")>]
        member _.SeparatorGroup(state: Types.ChunkingSettings, value: string) =
            { state with SeparatorGroup = Some value }

        [<CustomOperation("separators")>]
        member _.Separators(state: Types.ChunkingSettings, value: string list) =
            { state with Separators = Some value }

    let chunkingSettings = ChunkingSettingsBuilder()

    type CompletionPropertyBuilder() =
        member _.Yield(_: unit) : Types.CompletionProperty =
            {
                Analyzer = None
                Contexts = None
                MaxInputLength = None
                PreservePositionIncrements = None
                PreserveSeparators = None
                SearchAnalyzer = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: Types.CompletionProperty, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("contexts")>]
        member _.Contexts(state: Types.CompletionProperty, value: Types.SuggestContext list) =
            { state with Contexts = Some value }

        [<CustomOperation("maxInputLength")>]
        member _.MaxInputLength(state: Types.CompletionProperty, value: Types.Integer) =
            { state with MaxInputLength = Some value }

        [<CustomOperation("preservePositionIncrements")>]
        member _.PreservePositionIncrements(state: Types.CompletionProperty, value: bool) =
            { state with PreservePositionIncrements = Some value }

        [<CustomOperation("preserveSeparators")>]
        member _.PreserveSeparators(state: Types.CompletionProperty, value: bool) =
            { state with PreserveSeparators = Some value }

        [<CustomOperation("searchAnalyzer")>]
        member _.SearchAnalyzer(state: Types.CompletionProperty, value: string) =
            { state with SearchAnalyzer = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.CompletionProperty, value: string) =
            { state with Type = value }

    let completionProperty = CompletionPropertyBuilder()

    type CorePropertyBaseBuilder() =
        member _.Yield(_: unit) : Types.CorePropertyBase =
            {
                CopyTo = None
                Store = None
            }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.CorePropertyBase, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.CorePropertyBase, value: bool) =
            { state with Store = Some value }

    let corePropertyBase = CorePropertyBaseBuilder()

    type DateNanosPropertyBuilder() =
        member _.Yield(_: unit) : Types.DateNanosProperty =
            {
                Boost = None
                Format = None
                IgnoreMalformed = None
                Index = None
                Script = None
                OnScriptError = None
                NullValue = None
                PrecisionStep = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.DateNanosProperty, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: Types.DateNanosProperty, value: string) =
            { state with Format = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: Types.DateNanosProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.DateNanosProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.DateNanosProperty, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: Types.DateNanosProperty, value: Types.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: Types.DateNanosProperty, value: Types.DateTime) =
            { state with NullValue = Some value }

        [<CustomOperation("precisionStep")>]
        member _.PrecisionStep(state: Types.DateNanosProperty, value: Types.Integer) =
            { state with PrecisionStep = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.DateNanosProperty, value: string) =
            { state with Type = value }

    let dateNanosProperty = DateNanosPropertyBuilder()

    type DatePropertyBuilder() =
        member _.Yield(_: unit) : Types.DateProperty =
            {
                Boost = None
                Fielddata = None
                Format = None
                IgnoreMalformed = None
                Index = None
                Script = None
                OnScriptError = None
                NullValue = None
                PrecisionStep = None
                Locale = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.DateProperty, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("fielddata")>]
        member _.Fielddata(state: Types.DateProperty, value: Types.NumericFielddata) =
            { state with Fielddata = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: Types.DateProperty, value: string) =
            { state with Format = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: Types.DateProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.DateProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.DateProperty, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: Types.DateProperty, value: Types.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: Types.DateProperty, value: Types.DateTime) =
            { state with NullValue = Some value }

        [<CustomOperation("precisionStep")>]
        member _.PrecisionStep(state: Types.DateProperty, value: Types.Integer) =
            { state with PrecisionStep = Some value }

        [<CustomOperation("locale")>]
        member _.Locale(state: Types.DateProperty, value: string) =
            { state with Locale = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.DateProperty, value: string) =
            { state with Type = value }

    let dateProperty = DatePropertyBuilder()

    type DenseVectorIndexOptionsBuilder() =
        member _.Yield(_: unit) : Types.DenseVectorIndexOptions =
            {
                ConfidenceInterval = None
                EfConstruction = None
                M = None
                Type = Unchecked.defaultof<_>
                RescoreVector = None
                OnDiskRescore = None
            }

        [<CustomOperation("confidenceInterval")>]
        member _.ConfidenceInterval(state: Types.DenseVectorIndexOptions, value: Types.Float) =
            { state with ConfidenceInterval = Some value }

        [<CustomOperation("efConstruction")>]
        member _.EfConstruction(state: Types.DenseVectorIndexOptions, value: Types.Integer) =
            { state with EfConstruction = Some value }

        [<CustomOperation("m")>]
        member _.M(state: Types.DenseVectorIndexOptions, value: Types.Integer) =
            { state with M = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.DenseVectorIndexOptions, value: Types.DenseVectorIndexOptionsType) =
            { state with Type = value }

        [<CustomOperation("rescoreVector")>]
        member _.RescoreVector(state: Types.DenseVectorIndexOptions, value: Types.DenseVectorIndexOptionsRescoreVector) =
            { state with RescoreVector = Some value }

        [<CustomOperation("onDiskRescore")>]
        member _.OnDiskRescore(state: Types.DenseVectorIndexOptions, value: bool) =
            { state with OnDiskRescore = Some value }

    let denseVectorIndexOptions = DenseVectorIndexOptionsBuilder()

    type DenseVectorPropertyBuilder() =
        member _.Yield(_: unit) : Types.DenseVectorProperty =
            {
                Type = Unchecked.defaultof<_>
                Dims = None
                ElementType = None
                Index = None
                IndexOptions = None
                Similarity = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.DenseVectorProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("dims")>]
        member _.Dims(state: Types.DenseVectorProperty, value: Types.Integer) =
            { state with Dims = Some value }

        [<CustomOperation("elementType")>]
        member _.ElementType(state: Types.DenseVectorProperty, value: Types.DenseVectorElementType) =
            { state with ElementType = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.DenseVectorProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("indexOptions")>]
        member _.IndexOptions(state: Types.DenseVectorProperty, value: Types.DenseVectorIndexOptions) =
            { state with IndexOptions = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: Types.DenseVectorProperty, value: Types.DenseVectorSimilarity) =
            { state with Similarity = Some value }

    let denseVectorProperty = DenseVectorPropertyBuilder()

    type DynamicPropertyBuilder() =
        member _.Yield(_: unit) : Types.DynamicProperty =
            {
                Type = Unchecked.defaultof<_>
                Enabled = None
                NullValue = None
                Boost = None
                Coerce = None
                Script = None
                OnScriptError = None
                IgnoreMalformed = None
                TimeSeriesMetric = None
                Analyzer = None
                EagerGlobalOrdinals = None
                Index = None
                IndexOptions = None
                IndexPhrases = None
                IndexPrefixes = None
                Norms = None
                PositionIncrementGap = None
                SearchAnalyzer = None
                SearchQuoteAnalyzer = None
                TermVector = None
                Format = None
                PrecisionStep = None
                Locale = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.DynamicProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.DynamicProperty, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: Types.DynamicProperty, value: Types.FieldValue) =
            { state with NullValue = Some value }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.DynamicProperty, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: Types.DynamicProperty, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.DynamicProperty, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: Types.DynamicProperty, value: Types.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: Types.DynamicProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("timeSeriesMetric")>]
        member _.TimeSeriesMetric(state: Types.DynamicProperty, value: Types.TimeSeriesMetricType) =
            { state with TimeSeriesMetric = Some value }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: Types.DynamicProperty, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("eagerGlobalOrdinals")>]
        member _.EagerGlobalOrdinals(state: Types.DynamicProperty, value: bool) =
            { state with EagerGlobalOrdinals = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.DynamicProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("indexOptions")>]
        member _.IndexOptions(state: Types.DynamicProperty, value: Types.IndexOptions) =
            { state with IndexOptions = Some value }

        [<CustomOperation("indexPhrases")>]
        member _.IndexPhrases(state: Types.DynamicProperty, value: bool) =
            { state with IndexPhrases = Some value }

        [<CustomOperation("indexPrefixes")>]
        member _.IndexPrefixes(state: Types.DynamicProperty, value: Types.TextIndexPrefixes option) =
            { state with IndexPrefixes = Some value }

        [<CustomOperation("norms")>]
        member _.Norms(state: Types.DynamicProperty, value: bool) =
            { state with Norms = Some value }

        [<CustomOperation("positionIncrementGap")>]
        member _.PositionIncrementGap(state: Types.DynamicProperty, value: Types.Integer) =
            { state with PositionIncrementGap = Some value }

        [<CustomOperation("searchAnalyzer")>]
        member _.SearchAnalyzer(state: Types.DynamicProperty, value: string) =
            { state with SearchAnalyzer = Some value }

        [<CustomOperation("searchQuoteAnalyzer")>]
        member _.SearchQuoteAnalyzer(state: Types.DynamicProperty, value: string) =
            { state with SearchQuoteAnalyzer = Some value }

        [<CustomOperation("termVector")>]
        member _.TermVector(state: Types.DynamicProperty, value: Types.TermVectorOption) =
            { state with TermVector = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: Types.DynamicProperty, value: string) =
            { state with Format = Some value }

        [<CustomOperation("precisionStep")>]
        member _.PrecisionStep(state: Types.DynamicProperty, value: Types.Integer) =
            { state with PrecisionStep = Some value }

        [<CustomOperation("locale")>]
        member _.Locale(state: Types.DynamicProperty, value: string) =
            { state with Locale = Some value }

    let dynamicProperty = DynamicPropertyBuilder()

    module DynamicTemplate =

        let mapping (value: Types.Property) =
            Types.DynamicTemplate.Mapping value

        let runtime (value: Types.RuntimeField) =
            Types.DynamicTemplate.Runtime value

    type FlattenedPropertyBuilder() =
        member _.Yield(_: unit) : Types.FlattenedProperty =
            {
                Boost = None
                DepthLimit = None
                DocValues = None
                EagerGlobalOrdinals = None
                Index = None
                IndexOptions = None
                NullValue = None
                Similarity = None
                SplitQueriesOnWhitespace = None
                TimeSeriesDimensions = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.FlattenedProperty, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("depthLimit")>]
        member _.DepthLimit(state: Types.FlattenedProperty, value: Types.Integer) =
            { state with DepthLimit = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.FlattenedProperty, value: bool) =
            { state with DocValues = Some value }

        [<CustomOperation("eagerGlobalOrdinals")>]
        member _.EagerGlobalOrdinals(state: Types.FlattenedProperty, value: bool) =
            { state with EagerGlobalOrdinals = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.FlattenedProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("indexOptions")>]
        member _.IndexOptions(state: Types.FlattenedProperty, value: Types.IndexOptions) =
            { state with IndexOptions = Some value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: Types.FlattenedProperty, value: string) =
            { state with NullValue = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: Types.FlattenedProperty, value: string) =
            { state with Similarity = Some value }

        [<CustomOperation("splitQueriesOnWhitespace")>]
        member _.SplitQueriesOnWhitespace(state: Types.FlattenedProperty, value: bool) =
            { state with SplitQueriesOnWhitespace = Some value }

        [<CustomOperation("timeSeriesDimensions")>]
        member _.TimeSeriesDimensions(state: Types.FlattenedProperty, value: string list) =
            { state with TimeSeriesDimensions = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.FlattenedProperty, value: string) =
            { state with Type = value }

    let flattenedProperty = FlattenedPropertyBuilder()

    type GeoPointPropertyBuilder() =
        member _.Yield(_: unit) : Types.GeoPointProperty =
            {
                IgnoreMalformed = None
                IgnoreZValue = None
                NullValue = None
                Index = None
                OnScriptError = None
                Script = None
                Type = Unchecked.defaultof<_>
                TimeSeriesMetric = None
            }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: Types.GeoPointProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("ignoreZValue")>]
        member _.IgnoreZValue(state: Types.GeoPointProperty, value: bool) =
            { state with IgnoreZValue = Some value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: Types.GeoPointProperty, value: Types.GeoLocation) =
            { state with NullValue = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.GeoPointProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: Types.GeoPointProperty, value: Types.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.GeoPointProperty, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.GeoPointProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("timeSeriesMetric")>]
        member _.TimeSeriesMetric(state: Types.GeoPointProperty, value: Types.GeoPointMetricType) =
            { state with TimeSeriesMetric = Some value }

    let geoPointProperty = GeoPointPropertyBuilder()

    type GeoShapePropertyBuilder() =
        member _.Yield(_: unit) : Types.GeoShapeProperty =
            {
                Coerce = None
                IgnoreMalformed = None
                IgnoreZValue = None
                Index = None
                Orientation = None
                Strategy = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: Types.GeoShapeProperty, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: Types.GeoShapeProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("ignoreZValue")>]
        member _.IgnoreZValue(state: Types.GeoShapeProperty, value: bool) =
            { state with IgnoreZValue = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.GeoShapeProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("orientation")>]
        member _.Orientation(state: Types.GeoShapeProperty, value: Types.GeoOrientation) =
            { state with Orientation = Some value }

        [<CustomOperation("strategy")>]
        member _.Strategy(state: Types.GeoShapeProperty, value: Types.GeoStrategy) =
            { state with Strategy = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.GeoShapeProperty, value: string) =
            { state with Type = value }

    let geoShapeProperty = GeoShapePropertyBuilder()

    type HistogramPropertyBuilder() =
        member _.Yield(_: unit) : Types.HistogramProperty =
            {
                IgnoreMalformed = None
                TimeSeriesMetric = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: Types.HistogramProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("timeSeriesMetric")>]
        member _.TimeSeriesMetric(state: Types.HistogramProperty, value: Types.TimeSeriesMetricType) =
            { state with TimeSeriesMetric = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.HistogramProperty, value: string) =
            { state with Type = value }

    let histogramProperty = HistogramPropertyBuilder()

    type IcuCollationPropertyBuilder() =
        member _.Yield(_: unit) : Types.IcuCollationProperty =
            {
                Type = Unchecked.defaultof<_>
                Norms = None
                IndexOptions = None
                Index = None
                NullValue = None
                Rules = None
                Language = None
                Country = None
                Variant = None
                Strength = None
                Decomposition = None
                Alternate = None
                CaseLevel = None
                CaseFirst = None
                Numeric = None
                VariableTop = None
                HiraganaQuaternaryMode = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.IcuCollationProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("norms")>]
        member _.Norms(state: Types.IcuCollationProperty, value: bool) =
            { state with Norms = Some value }

        [<CustomOperation("indexOptions")>]
        member _.IndexOptions(state: Types.IcuCollationProperty, value: Types.IndexOptions) =
            { state with IndexOptions = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.IcuCollationProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: Types.IcuCollationProperty, value: string) =
            { state with NullValue = Some value }

        [<CustomOperation("rules")>]
        member _.Rules(state: Types.IcuCollationProperty, value: string) =
            { state with Rules = Some value }

        [<CustomOperation("language")>]
        member _.Language(state: Types.IcuCollationProperty, value: string) =
            { state with Language = Some value }

        [<CustomOperation("country")>]
        member _.Country(state: Types.IcuCollationProperty, value: string) =
            { state with Country = Some value }

        [<CustomOperation("variant")>]
        member _.Variant(state: Types.IcuCollationProperty, value: string) =
            { state with Variant = Some value }

        [<CustomOperation("strength")>]
        member _.Strength(state: Types.IcuCollationProperty, value: Types.IcuCollationStrength) =
            { state with Strength = Some value }

        [<CustomOperation("decomposition")>]
        member _.Decomposition(state: Types.IcuCollationProperty, value: Types.IcuCollationDecomposition) =
            { state with Decomposition = Some value }

        [<CustomOperation("alternate")>]
        member _.Alternate(state: Types.IcuCollationProperty, value: Types.IcuCollationAlternate) =
            { state with Alternate = Some value }

        [<CustomOperation("caseLevel")>]
        member _.CaseLevel(state: Types.IcuCollationProperty, value: bool) =
            { state with CaseLevel = Some value }

        [<CustomOperation("caseFirst")>]
        member _.CaseFirst(state: Types.IcuCollationProperty, value: Types.IcuCollationCaseFirst) =
            { state with CaseFirst = Some value }

        [<CustomOperation("numeric")>]
        member _.Numeric(state: Types.IcuCollationProperty, value: bool) =
            { state with Numeric = Some value }

        [<CustomOperation("variableTop")>]
        member _.VariableTop(state: Types.IcuCollationProperty, value: string) =
            { state with VariableTop = Some value }

        [<CustomOperation("hiraganaQuaternaryMode")>]
        member _.HiraganaQuaternaryMode(state: Types.IcuCollationProperty, value: bool) =
            { state with HiraganaQuaternaryMode = Some value }

    let icuCollationProperty = IcuCollationPropertyBuilder()

    type IpPropertyBuilder() =
        member _.Yield(_: unit) : Types.IpProperty =
            {
                Boost = None
                Index = None
                IgnoreMalformed = None
                NullValue = None
                OnScriptError = None
                Script = None
                TimeSeriesDimension = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.IpProperty, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.IpProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: Types.IpProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: Types.IpProperty, value: string) =
            { state with NullValue = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: Types.IpProperty, value: Types.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.IpProperty, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("timeSeriesDimension")>]
        member _.TimeSeriesDimension(state: Types.IpProperty, value: bool) =
            { state with TimeSeriesDimension = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.IpProperty, value: string) =
            { state with Type = value }

    let ipProperty = IpPropertyBuilder()

    type JoinPropertyBuilder() =
        member _.Yield(_: unit) : Types.JoinProperty =
            {
                Relations = None
                EagerGlobalOrdinals = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("relations")>]
        member _.Relations(state: Types.JoinProperty, value: Map<Types.RelationName, System.Text.Json.JsonElement>) =
            { state with Relations = Some value }

        [<CustomOperation("eagerGlobalOrdinals")>]
        member _.EagerGlobalOrdinals(state: Types.JoinProperty, value: bool) =
            { state with EagerGlobalOrdinals = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.JoinProperty, value: string) =
            { state with Type = value }

    let joinProperty = JoinPropertyBuilder()

    type KeywordPropertyBuilder() =
        member _.Yield(_: unit) : Types.KeywordProperty =
            {
                Boost = None
                EagerGlobalOrdinals = None
                Index = None
                IndexOptions = None
                Script = None
                OnScriptError = None
                Normalizer = None
                Norms = None
                NullValue = None
                Similarity = None
                SplitQueriesOnWhitespace = None
                TimeSeriesDimension = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.KeywordProperty, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("eagerGlobalOrdinals")>]
        member _.EagerGlobalOrdinals(state: Types.KeywordProperty, value: bool) =
            { state with EagerGlobalOrdinals = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.KeywordProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("indexOptions")>]
        member _.IndexOptions(state: Types.KeywordProperty, value: Types.IndexOptions) =
            { state with IndexOptions = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.KeywordProperty, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: Types.KeywordProperty, value: Types.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("normalizer")>]
        member _.Normalizer(state: Types.KeywordProperty, value: string) =
            { state with Normalizer = Some value }

        [<CustomOperation("norms")>]
        member _.Norms(state: Types.KeywordProperty, value: bool) =
            { state with Norms = Some value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: Types.KeywordProperty, value: string) =
            { state with NullValue = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: Types.KeywordProperty, value: string option) =
            { state with Similarity = Some value }

        [<CustomOperation("splitQueriesOnWhitespace")>]
        member _.SplitQueriesOnWhitespace(state: Types.KeywordProperty, value: bool) =
            { state with SplitQueriesOnWhitespace = Some value }

        [<CustomOperation("timeSeriesDimension")>]
        member _.TimeSeriesDimension(state: Types.KeywordProperty, value: bool) =
            { state with TimeSeriesDimension = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.KeywordProperty, value: string) =
            { state with Type = value }

    let keywordProperty = KeywordPropertyBuilder()

    type MatchOnlyTextPropertyBuilder() =
        member _.Yield(_: unit) : Types.MatchOnlyTextProperty =
            {
                Type = Unchecked.defaultof<_>
                Fields = None
                Meta = None
                CopyTo = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.MatchOnlyTextProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.MatchOnlyTextProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.MatchOnlyTextProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.MatchOnlyTextProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

    let matchOnlyTextProperty = MatchOnlyTextPropertyBuilder()

    type NestedPropertyBuilder() =
        member _.Yield(_: unit) : Types.NestedProperty =
            {
                Enabled = None
                IncludeInParent = None
                IncludeInRoot = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.NestedProperty, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("includeInParent")>]
        member _.IncludeInParent(state: Types.NestedProperty, value: bool) =
            { state with IncludeInParent = Some value }

        [<CustomOperation("includeInRoot")>]
        member _.IncludeInRoot(state: Types.NestedProperty, value: bool) =
            { state with IncludeInRoot = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.NestedProperty, value: string) =
            { state with Type = value }

    let nestedProperty = NestedPropertyBuilder()

    type NumberPropertyBaseBuilder() =
        member _.Yield(_: unit) : Types.NumberPropertyBase =
            {
                Boost = None
                Coerce = None
                IgnoreMalformed = None
                Index = None
                OnScriptError = None
                Script = None
                TimeSeriesMetric = None
                TimeSeriesDimension = None
            }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.NumberPropertyBase, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: Types.NumberPropertyBase, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: Types.NumberPropertyBase, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.NumberPropertyBase, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: Types.NumberPropertyBase, value: Types.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.NumberPropertyBase, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("timeSeriesMetric")>]
        member _.TimeSeriesMetric(state: Types.NumberPropertyBase, value: Types.TimeSeriesMetricType) =
            { state with TimeSeriesMetric = Some value }

        [<CustomOperation("timeSeriesDimension")>]
        member _.TimeSeriesDimension(state: Types.NumberPropertyBase, value: bool) =
            { state with TimeSeriesDimension = Some value }

    let numberPropertyBase = NumberPropertyBaseBuilder()

    type ObjectPropertyBuilder() =
        member _.Yield(_: unit) : Types.ObjectProperty =
            {
                Enabled = None
                Subobjects = None
                Type = None
            }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.ObjectProperty, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("subobjects")>]
        member _.Subobjects(state: Types.ObjectProperty, value: Types.Subobjects) =
            { state with Subobjects = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.ObjectProperty, value: string) =
            { state with Type = Some value }

    let objectProperty = ObjectPropertyBuilder()

    type PassthroughObjectPropertyBuilder() =
        member _.Yield(_: unit) : Types.PassthroughObjectProperty =
            {
                Type = None
                Enabled = None
                Priority = None
                TimeSeriesDimension = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.PassthroughObjectProperty, value: string) =
            { state with Type = Some value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.PassthroughObjectProperty, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("priority")>]
        member _.Priority(state: Types.PassthroughObjectProperty, value: Types.Integer) =
            { state with Priority = Some value }

        [<CustomOperation("timeSeriesDimension")>]
        member _.TimeSeriesDimension(state: Types.PassthroughObjectProperty, value: bool) =
            { state with TimeSeriesDimension = Some value }

    let passthroughObjectProperty = PassthroughObjectPropertyBuilder()

    type PointPropertyBuilder() =
        member _.Yield(_: unit) : Types.PointProperty =
            {
                IgnoreMalformed = None
                IgnoreZValue = None
                NullValue = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: Types.PointProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("ignoreZValue")>]
        member _.IgnoreZValue(state: Types.PointProperty, value: bool) =
            { state with IgnoreZValue = Some value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: Types.PointProperty, value: string) =
            { state with NullValue = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.PointProperty, value: string) =
            { state with Type = value }

    let pointProperty = PointPropertyBuilder()

    type PropertyBaseBuilder() =
        member _.Yield(_: unit) : Types.PropertyBase =
            {
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
            }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.PropertyBase, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.PropertyBase, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.PropertyBase, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.PropertyBase, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.PropertyBase, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.PropertyBase, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

    let propertyBase = PropertyBaseBuilder()

    type RangePropertyBaseBuilder() =
        member _.Yield(_: unit) : Types.RangePropertyBase =
            {
                Boost = None
                Coerce = None
                Index = None
            }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.RangePropertyBase, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: Types.RangePropertyBase, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.RangePropertyBase, value: bool) =
            { state with Index = Some value }

    let rangePropertyBase = RangePropertyBaseBuilder()

    type RankVectorPropertyBuilder() =
        member _.Yield(_: unit) : Types.RankVectorProperty =
            {
                Type = Unchecked.defaultof<_>
                ElementType = None
                Dims = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.RankVectorProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("elementType")>]
        member _.ElementType(state: Types.RankVectorProperty, value: Types.RankVectorElementType) =
            { state with ElementType = Some value }

        [<CustomOperation("dims")>]
        member _.Dims(state: Types.RankVectorProperty, value: Types.Integer) =
            { state with Dims = Some value }

    let rankVectorProperty = RankVectorPropertyBuilder()

    type RuntimeFieldBuilder() =
        member _.Yield(_: unit) : Types.RuntimeField =
            {
                Fields = None
                FetchFields = None
                Format = None
                InputField = None
                TargetField = None
                TargetIndex = None
                Script = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.RuntimeField, value: Map<string, Types.CompositeSubField>) =
            { state with Fields = Some value }

        [<CustomOperation("fetchFields")>]
        member _.FetchFields(state: Types.RuntimeField, value: Types.RuntimeFieldFetchFields list) =
            { state with FetchFields = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: Types.RuntimeField, value: string) =
            { state with Format = Some value }

        [<CustomOperation("inputField")>]
        member _.InputField(state: Types.RuntimeField, value: Types.Field) =
            { state with InputField = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.RuntimeField, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("targetIndex")>]
        member _.TargetIndex(state: Types.RuntimeField, value: Types.IndexName) =
            { state with TargetIndex = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.RuntimeField, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.RuntimeField, value: Types.RuntimeFieldType) =
            { state with Type = value }

    let runtimeField = RuntimeFieldBuilder()

    type ScaledFloatNumberPropertyBuilder() =
        member _.Yield(_: unit) : Types.ScaledFloatNumberProperty =
            {
                Type = Unchecked.defaultof<_>
                NullValue = None
                ScalingFactor = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.ScaledFloatNumberProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: Types.ScaledFloatNumberProperty, value: Types.Double) =
            { state with NullValue = Some value }

        [<CustomOperation("scalingFactor")>]
        member _.ScalingFactor(state: Types.ScaledFloatNumberProperty, value: Types.Double) =
            { state with ScalingFactor = Some value }

    let scaledFloatNumberProperty = ScaledFloatNumberPropertyBuilder()

    type SearchAsYouTypePropertyBuilder() =
        member _.Yield(_: unit) : Types.SearchAsYouTypeProperty =
            {
                Analyzer = None
                Index = None
                IndexOptions = None
                MaxShingleSize = None
                Norms = None
                SearchAnalyzer = None
                SearchQuoteAnalyzer = None
                Similarity = None
                TermVector = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: Types.SearchAsYouTypeProperty, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.SearchAsYouTypeProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("indexOptions")>]
        member _.IndexOptions(state: Types.SearchAsYouTypeProperty, value: Types.IndexOptions) =
            { state with IndexOptions = Some value }

        [<CustomOperation("maxShingleSize")>]
        member _.MaxShingleSize(state: Types.SearchAsYouTypeProperty, value: Types.Integer) =
            { state with MaxShingleSize = Some value }

        [<CustomOperation("norms")>]
        member _.Norms(state: Types.SearchAsYouTypeProperty, value: bool) =
            { state with Norms = Some value }

        [<CustomOperation("searchAnalyzer")>]
        member _.SearchAnalyzer(state: Types.SearchAsYouTypeProperty, value: string) =
            { state with SearchAnalyzer = Some value }

        [<CustomOperation("searchQuoteAnalyzer")>]
        member _.SearchQuoteAnalyzer(state: Types.SearchAsYouTypeProperty, value: string) =
            { state with SearchQuoteAnalyzer = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: Types.SearchAsYouTypeProperty, value: string option) =
            { state with Similarity = Some value }

        [<CustomOperation("termVector")>]
        member _.TermVector(state: Types.SearchAsYouTypeProperty, value: Types.TermVectorOption) =
            { state with TermVector = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.SearchAsYouTypeProperty, value: string) =
            { state with Type = value }

    let searchAsYouTypeProperty = SearchAsYouTypePropertyBuilder()

    type SemanticTextIndexOptionsBuilder() =
        member _.Yield(_: unit) : Types.SemanticTextIndexOptions =
            {
                DenseVector = None
                SparseVector = None
            }

        [<CustomOperation("denseVector")>]
        member _.DenseVector(state: Types.SemanticTextIndexOptions, value: Types.DenseVectorIndexOptions) =
            { state with DenseVector = Some value }

        [<CustomOperation("sparseVector")>]
        member _.SparseVector(state: Types.SemanticTextIndexOptions, value: Types.SparseVectorIndexOptions) =
            { state with SparseVector = Some value }

    let semanticTextIndexOptions = SemanticTextIndexOptionsBuilder()

    type SemanticTextPropertyBuilder() =
        member _.Yield(_: unit) : Types.SemanticTextProperty =
            {
                Type = Unchecked.defaultof<_>
                Meta = None
                InferenceId = None
                SearchInferenceId = None
                IndexOptions = None
                ChunkingSettings = None
                Fields = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.SemanticTextProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.SemanticTextProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: Types.SemanticTextProperty, value: Types.Id) =
            { state with InferenceId = Some value }

        [<CustomOperation("searchInferenceId")>]
        member _.SearchInferenceId(state: Types.SemanticTextProperty, value: Types.Id) =
            { state with SearchInferenceId = Some value }

        [<CustomOperation("indexOptions")>]
        member _.IndexOptions(state: Types.SemanticTextProperty, value: Types.SemanticTextIndexOptions) =
            { state with IndexOptions = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: Types.SemanticTextProperty, value: Types.ChunkingSettings option) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.SemanticTextProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

    let semanticTextProperty = SemanticTextPropertyBuilder()

    type ShapePropertyBuilder() =
        member _.Yield(_: unit) : Types.ShapeProperty =
            {
                Coerce = None
                IgnoreMalformed = None
                IgnoreZValue = None
                Orientation = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: Types.ShapeProperty, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: Types.ShapeProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("ignoreZValue")>]
        member _.IgnoreZValue(state: Types.ShapeProperty, value: bool) =
            { state with IgnoreZValue = Some value }

        [<CustomOperation("orientation")>]
        member _.Orientation(state: Types.ShapeProperty, value: Types.GeoOrientation) =
            { state with Orientation = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.ShapeProperty, value: string) =
            { state with Type = value }

    let shapeProperty = ShapePropertyBuilder()

    type SourceFieldBuilder() =
        member _.Yield(_: unit) : Types.SourceField =
            {
                Compress = None
                CompressThreshold = None
                Enabled = None
                Excludes = None
                Includes = None
                Mode = None
            }

        [<CustomOperation("compress")>]
        member _.Compress(state: Types.SourceField, value: bool) =
            { state with Compress = Some value }

        [<CustomOperation("compressThreshold")>]
        member _.CompressThreshold(state: Types.SourceField, value: string) =
            { state with CompressThreshold = Some value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.SourceField, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("excludes")>]
        member _.Excludes(state: Types.SourceField, value: string list) =
            { state with Excludes = Some value }

        [<CustomOperation("includes")>]
        member _.Includes(state: Types.SourceField, value: string list) =
            { state with Includes = Some value }

        [<CustomOperation("mode")>]
        member _.Mode(state: Types.SourceField, value: Types.SourceFieldMode) =
            { state with Mode = Some value }

    let sourceField = SourceFieldBuilder()

    type SparseVectorIndexOptionsBuilder() =
        member _.Yield(_: unit) : Types.SparseVectorIndexOptions =
            {
                Prune = None
                PruningConfig = None
            }

        [<CustomOperation("prune")>]
        member _.Prune(state: Types.SparseVectorIndexOptions, value: bool) =
            { state with Prune = Some value }

        [<CustomOperation("pruningConfig")>]
        member _.PruningConfig(state: Types.SparseVectorIndexOptions, value: Types.TokenPruningConfig) =
            { state with PruningConfig = Some value }

    let sparseVectorIndexOptions = SparseVectorIndexOptionsBuilder()

    type SparseVectorPropertyBuilder() =
        member _.Yield(_: unit) : Types.SparseVectorProperty =
            {
                Store = None
                Type = Unchecked.defaultof<_>
                IndexOptions = None
            }

        [<CustomOperation("store")>]
        member _.Store(state: Types.SparseVectorProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.SparseVectorProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("indexOptions")>]
        member _.IndexOptions(state: Types.SparseVectorProperty, value: Types.SparseVectorIndexOptions) =
            { state with IndexOptions = Some value }

    let sparseVectorProperty = SparseVectorPropertyBuilder()

    type SuggestContextBuilder() =
        member _.Yield(_: unit) : Types.SuggestContext =
            {
                Name = Unchecked.defaultof<_>
                Path = None
                Type = Unchecked.defaultof<_>
                Precision = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: Types.SuggestContext, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("path")>]
        member _.Path(state: Types.SuggestContext, value: Types.Field) =
            { state with Path = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.SuggestContext, value: string) =
            { state with Type = value }

        [<CustomOperation("precision")>]
        member _.Precision(state: Types.SuggestContext, value: System.Text.Json.JsonElement) =
            { state with Precision = Some value }

    let suggestContext = SuggestContextBuilder()

    type TextPropertyBuilder() =
        member _.Yield(_: unit) : Types.TextProperty =
            {
                Analyzer = None
                Boost = None
                EagerGlobalOrdinals = None
                Fielddata = None
                FielddataFrequencyFilter = None
                Index = None
                IndexOptions = None
                IndexPhrases = None
                IndexPrefixes = None
                Norms = None
                PositionIncrementGap = None
                SearchAnalyzer = None
                SearchQuoteAnalyzer = None
                Similarity = None
                TermVector = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: Types.TextProperty, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.TextProperty, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("eagerGlobalOrdinals")>]
        member _.EagerGlobalOrdinals(state: Types.TextProperty, value: bool) =
            { state with EagerGlobalOrdinals = Some value }

        [<CustomOperation("fielddata")>]
        member _.Fielddata(state: Types.TextProperty, value: bool) =
            { state with Fielddata = Some value }

        [<CustomOperation("fielddataFrequencyFilter")>]
        member _.FielddataFrequencyFilter(state: Types.TextProperty, value: Types.FielddataFrequencyFilter) =
            { state with FielddataFrequencyFilter = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.TextProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("indexOptions")>]
        member _.IndexOptions(state: Types.TextProperty, value: Types.IndexOptions) =
            { state with IndexOptions = Some value }

        [<CustomOperation("indexPhrases")>]
        member _.IndexPhrases(state: Types.TextProperty, value: bool) =
            { state with IndexPhrases = Some value }

        [<CustomOperation("indexPrefixes")>]
        member _.IndexPrefixes(state: Types.TextProperty, value: Types.TextIndexPrefixes option) =
            { state with IndexPrefixes = Some value }

        [<CustomOperation("norms")>]
        member _.Norms(state: Types.TextProperty, value: bool) =
            { state with Norms = Some value }

        [<CustomOperation("positionIncrementGap")>]
        member _.PositionIncrementGap(state: Types.TextProperty, value: Types.Integer) =
            { state with PositionIncrementGap = Some value }

        [<CustomOperation("searchAnalyzer")>]
        member _.SearchAnalyzer(state: Types.TextProperty, value: string) =
            { state with SearchAnalyzer = Some value }

        [<CustomOperation("searchQuoteAnalyzer")>]
        member _.SearchQuoteAnalyzer(state: Types.TextProperty, value: string) =
            { state with SearchQuoteAnalyzer = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: Types.TextProperty, value: string option) =
            { state with Similarity = Some value }

        [<CustomOperation("termVector")>]
        member _.TermVector(state: Types.TextProperty, value: Types.TermVectorOption) =
            { state with TermVector = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.TextProperty, value: string) =
            { state with Type = value }

    let textProperty = TextPropertyBuilder()

    type TokenCountPropertyBuilder() =
        member _.Yield(_: unit) : Types.TokenCountProperty =
            {
                Analyzer = None
                Boost = None
                Index = None
                NullValue = None
                EnablePositionIncrements = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: Types.TokenCountProperty, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.TokenCountProperty, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.TokenCountProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: Types.TokenCountProperty, value: Types.Double) =
            { state with NullValue = Some value }

        [<CustomOperation("enablePositionIncrements")>]
        member _.EnablePositionIncrements(state: Types.TokenCountProperty, value: bool) =
            { state with EnablePositionIncrements = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.TokenCountProperty, value: string) =
            { state with Type = value }

    let tokenCountProperty = TokenCountPropertyBuilder()

    type TypeMappingBuilder() =
        member _.Yield(_: unit) : Types.TypeMapping =
            {
                AllField = None
                DateDetection = None
                Dynamic = None
                DynamicDateFormats = None
                DynamicTemplates = None
                FieldNames = None
                IndexField = None
                Meta = None
                NumericDetection = None
                Properties = None
                Routing = None
                Size = None
                Source = None
                Runtime = None
                Enabled = None
                Subobjects = None
                DataStreamTimestamp = None
            }

        [<CustomOperation("allField")>]
        member _.AllField(state: Types.TypeMapping, value: Types.AllField) =
            { state with AllField = Some value }

        [<CustomOperation("dateDetection")>]
        member _.DateDetection(state: Types.TypeMapping, value: bool) =
            { state with DateDetection = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.TypeMapping, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("dynamicDateFormats")>]
        member _.DynamicDateFormats(state: Types.TypeMapping, value: string list) =
            { state with DynamicDateFormats = Some value }

        [<CustomOperation("dynamicTemplates")>]
        member _.DynamicTemplates(state: Types.TypeMapping, value: Map<string, Types.DynamicTemplate> list) =
            { state with DynamicTemplates = Some value }

        [<CustomOperation("fieldNames")>]
        member _.FieldNames(state: Types.TypeMapping, value: Types.FieldNamesField) =
            { state with FieldNames = Some value }

        [<CustomOperation("indexField")>]
        member _.IndexField(state: Types.TypeMapping, value: Types.IndexField) =
            { state with IndexField = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.TypeMapping, value: Types.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("numericDetection")>]
        member _.NumericDetection(state: Types.TypeMapping, value: bool) =
            { state with NumericDetection = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.TypeMapping, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: Types.TypeMapping, value: Types.RoutingField) =
            { state with Routing = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.TypeMapping, value: Types.SizeField) =
            { state with Size = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: Types.TypeMapping, value: Types.SourceField) =
            { state with Source = Some value }

        [<CustomOperation("runtime")>]
        member _.Runtime(state: Types.TypeMapping, value: Map<string, Types.RuntimeField>) =
            { state with Runtime = Some value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.TypeMapping, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("subobjects")>]
        member _.Subobjects(state: Types.TypeMapping, value: Types.Subobjects) =
            { state with Subobjects = Some value }

        [<CustomOperation("dataStreamTimestamp")>]
        member _.DataStreamTimestamp(state: Types.TypeMapping, value: Types.DataStreamTimestamp) =
            { state with DataStreamTimestamp = Some value }

    let typeMapping = TypeMappingBuilder()


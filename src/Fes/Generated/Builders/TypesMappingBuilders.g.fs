// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module TypesMappingBuilders =

    type AggregateMetricDoublePropertyBuilder() =
        member _.Yield(_: unit) : AggregateMetricDoubleProperty =
            {
                Type = Unchecked.defaultof<_>
                DefaultMetric = Unchecked.defaultof<_>
                IgnoreMalformed = None
                Metrics = Unchecked.defaultof<_>
                TimeSeriesMetric = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: AggregateMetricDoubleProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("defaultMetric")>]
        member _.DefaultMetric(state: AggregateMetricDoubleProperty, value: string) =
            { state with DefaultMetric = value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: AggregateMetricDoubleProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("metrics")>]
        member _.Metrics(state: AggregateMetricDoubleProperty, value: string list) =
            { state with Metrics = value }

        [<CustomOperation("timeSeriesMetric")>]
        member _.TimeSeriesMetric(state: AggregateMetricDoubleProperty, value: CoreTypes.TimeSeriesMetricType) =
            { state with TimeSeriesMetric = Some value }

    let aggregateMetricDoubleProperty = AggregateMetricDoublePropertyBuilder()

    type BooleanPropertyBuilder() =
        member _.Yield(_: unit) : BooleanProperty =
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
        member _.Boost(state: BooleanProperty, value: CoreTypes.Double) =
            { state with Boost = Some value }

        [<CustomOperation("fielddata")>]
        member _.Fielddata(state: BooleanProperty, value: IndicesTypes.NumericFielddata) =
            { state with Fielddata = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: BooleanProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: BooleanProperty, value: bool) =
            { state with NullValue = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: BooleanProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: BooleanProperty, value: CoreTypes.Script) =
            { state with Script = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: BooleanProperty, value: CoreTypes.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("timeSeriesDimension")>]
        member _.TimeSeriesDimension(state: BooleanProperty, value: bool) =
            { state with TimeSeriesDimension = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: BooleanProperty, value: string) =
            { state with Type = value }

    let booleanProperty = BooleanPropertyBuilder()

    type ChunkRescorerChunkingSettingsBuilder() =
        member _.Yield(_: unit) : ChunkRescorerChunkingSettings =
            {
                MaxChunkSize = Unchecked.defaultof<_>
                Overlap = None
                SentenceOverlap = None
                SeparatorGroup = None
                Separators = None
                Strategy = None
            }

        [<CustomOperation("maxChunkSize")>]
        member _.MaxChunkSize(state: ChunkRescorerChunkingSettings, value: CoreTypes.Integer) =
            { state with MaxChunkSize = value }

        [<CustomOperation("overlap")>]
        member _.Overlap(state: ChunkRescorerChunkingSettings, value: CoreTypes.Integer) =
            { state with Overlap = Some value }

        [<CustomOperation("sentenceOverlap")>]
        member _.SentenceOverlap(state: ChunkRescorerChunkingSettings, value: CoreTypes.Integer) =
            { state with SentenceOverlap = Some value }

        [<CustomOperation("separatorGroup")>]
        member _.SeparatorGroup(state: ChunkRescorerChunkingSettings, value: string) =
            { state with SeparatorGroup = Some value }

        [<CustomOperation("separators")>]
        member _.Separators(state: ChunkRescorerChunkingSettings, value: string list) =
            { state with Separators = Some value }

        [<CustomOperation("strategy")>]
        member _.Strategy(state: ChunkRescorerChunkingSettings, value: string) =
            { state with Strategy = Some value }

    let chunkRescorerChunkingSettings = ChunkRescorerChunkingSettingsBuilder()

    type ChunkingSettingsBuilder() =
        member _.Yield(_: unit) : ChunkingSettings =
            {
                Strategy = Unchecked.defaultof<_>
                MaxChunkSize = Unchecked.defaultof<_>
                Overlap = None
                SentenceOverlap = None
                SeparatorGroup = None
                Separators = None
            }

        [<CustomOperation("strategy")>]
        member _.Strategy(state: ChunkingSettings, value: string) =
            { state with Strategy = value }

        [<CustomOperation("maxChunkSize")>]
        member _.MaxChunkSize(state: ChunkingSettings, value: CoreTypes.Integer) =
            { state with MaxChunkSize = value }

        [<CustomOperation("overlap")>]
        member _.Overlap(state: ChunkingSettings, value: CoreTypes.Integer) =
            { state with Overlap = Some value }

        [<CustomOperation("sentenceOverlap")>]
        member _.SentenceOverlap(state: ChunkingSettings, value: CoreTypes.Integer) =
            { state with SentenceOverlap = Some value }

        [<CustomOperation("separatorGroup")>]
        member _.SeparatorGroup(state: ChunkingSettings, value: string) =
            { state with SeparatorGroup = Some value }

        [<CustomOperation("separators")>]
        member _.Separators(state: ChunkingSettings, value: string list) =
            { state with Separators = Some value }

    let chunkingSettings = ChunkingSettingsBuilder()

    type CompletionPropertyBuilder() =
        member _.Yield(_: unit) : CompletionProperty =
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
        member _.Analyzer(state: CompletionProperty, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("contexts")>]
        member _.Contexts(state: CompletionProperty, value: CoreTypes.SuggestContext list) =
            { state with Contexts = Some value }

        [<CustomOperation("maxInputLength")>]
        member _.MaxInputLength(state: CompletionProperty, value: CoreTypes.Integer) =
            { state with MaxInputLength = Some value }

        [<CustomOperation("preservePositionIncrements")>]
        member _.PreservePositionIncrements(state: CompletionProperty, value: bool) =
            { state with PreservePositionIncrements = Some value }

        [<CustomOperation("preserveSeparators")>]
        member _.PreserveSeparators(state: CompletionProperty, value: bool) =
            { state with PreserveSeparators = Some value }

        [<CustomOperation("searchAnalyzer")>]
        member _.SearchAnalyzer(state: CompletionProperty, value: string) =
            { state with SearchAnalyzer = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: CompletionProperty, value: string) =
            { state with Type = value }

    let completionProperty = CompletionPropertyBuilder()

    type CorePropertyBaseBuilder() =
        member _.Yield(_: unit) : CorePropertyBase =
            {
                CopyTo = None
                Store = None
            }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: CorePropertyBase, value: CoreTypes.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: CorePropertyBase, value: bool) =
            { state with Store = Some value }

    let corePropertyBase = CorePropertyBaseBuilder()

    type DateNanosPropertyBuilder() =
        member _.Yield(_: unit) : DateNanosProperty =
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
        member _.Boost(state: DateNanosProperty, value: CoreTypes.Double) =
            { state with Boost = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: DateNanosProperty, value: string) =
            { state with Format = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: DateNanosProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: DateNanosProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: DateNanosProperty, value: CoreTypes.Script) =
            { state with Script = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: DateNanosProperty, value: CoreTypes.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: DateNanosProperty, value: CoreTypes.DateTime) =
            { state with NullValue = Some value }

        [<CustomOperation("precisionStep")>]
        member _.PrecisionStep(state: DateNanosProperty, value: CoreTypes.Integer) =
            { state with PrecisionStep = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: DateNanosProperty, value: string) =
            { state with Type = value }

    let dateNanosProperty = DateNanosPropertyBuilder()

    type DatePropertyBuilder() =
        member _.Yield(_: unit) : DateProperty =
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
        member _.Boost(state: DateProperty, value: CoreTypes.Double) =
            { state with Boost = Some value }

        [<CustomOperation("fielddata")>]
        member _.Fielddata(state: DateProperty, value: IndicesTypes.NumericFielddata) =
            { state with Fielddata = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: DateProperty, value: string) =
            { state with Format = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: DateProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: DateProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: DateProperty, value: CoreTypes.Script) =
            { state with Script = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: DateProperty, value: CoreTypes.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: DateProperty, value: CoreTypes.DateTime) =
            { state with NullValue = Some value }

        [<CustomOperation("precisionStep")>]
        member _.PrecisionStep(state: DateProperty, value: CoreTypes.Integer) =
            { state with PrecisionStep = Some value }

        [<CustomOperation("locale")>]
        member _.Locale(state: DateProperty, value: string) =
            { state with Locale = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: DateProperty, value: string) =
            { state with Type = value }

    let dateProperty = DatePropertyBuilder()

    type DenseVectorIndexOptionsBuilder() =
        member _.Yield(_: unit) : DenseVectorIndexOptions =
            {
                ConfidenceInterval = None
                EfConstruction = None
                M = None
                Type = Unchecked.defaultof<_>
                RescoreVector = None
                OnDiskRescore = None
            }

        [<CustomOperation("confidenceInterval")>]
        member _.ConfidenceInterval(state: DenseVectorIndexOptions, value: CoreTypes.Float) =
            { state with ConfidenceInterval = Some value }

        [<CustomOperation("efConstruction")>]
        member _.EfConstruction(state: DenseVectorIndexOptions, value: CoreTypes.Integer) =
            { state with EfConstruction = Some value }

        [<CustomOperation("m")>]
        member _.M(state: DenseVectorIndexOptions, value: CoreTypes.Integer) =
            { state with M = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: DenseVectorIndexOptions, value: CoreTypes.DenseVectorIndexOptionsType) =
            { state with Type = value }

        [<CustomOperation("rescoreVector")>]
        member _.RescoreVector(state: DenseVectorIndexOptions, value: CoreTypes.DenseVectorIndexOptionsRescoreVector) =
            { state with RescoreVector = Some value }

        [<CustomOperation("onDiskRescore")>]
        member _.OnDiskRescore(state: DenseVectorIndexOptions, value: bool) =
            { state with OnDiskRescore = Some value }

    let denseVectorIndexOptions = DenseVectorIndexOptionsBuilder()

    type DenseVectorPropertyBuilder() =
        member _.Yield(_: unit) : DenseVectorProperty =
            {
                Type = Unchecked.defaultof<_>
                Dims = None
                ElementType = None
                Index = None
                IndexOptions = None
                Similarity = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: DenseVectorProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("dims")>]
        member _.Dims(state: DenseVectorProperty, value: CoreTypes.Integer) =
            { state with Dims = Some value }

        [<CustomOperation("elementType")>]
        member _.ElementType(state: DenseVectorProperty, value: CoreTypes.DenseVectorElementType) =
            { state with ElementType = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: DenseVectorProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("indexOptions")>]
        member _.IndexOptions(state: DenseVectorProperty, value: CoreTypes.DenseVectorIndexOptions) =
            { state with IndexOptions = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: DenseVectorProperty, value: CoreTypes.DenseVectorSimilarity) =
            { state with Similarity = Some value }

    let denseVectorProperty = DenseVectorPropertyBuilder()

    type DynamicPropertyBuilder() =
        member _.Yield(_: unit) : DynamicProperty =
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
        member _.Type(state: DynamicProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: DynamicProperty, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: DynamicProperty, value: CoreTypes.FieldValue) =
            { state with NullValue = Some value }

        [<CustomOperation("boost")>]
        member _.Boost(state: DynamicProperty, value: CoreTypes.Double) =
            { state with Boost = Some value }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: DynamicProperty, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: DynamicProperty, value: CoreTypes.Script) =
            { state with Script = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: DynamicProperty, value: CoreTypes.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: DynamicProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("timeSeriesMetric")>]
        member _.TimeSeriesMetric(state: DynamicProperty, value: CoreTypes.TimeSeriesMetricType) =
            { state with TimeSeriesMetric = Some value }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: DynamicProperty, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("eagerGlobalOrdinals")>]
        member _.EagerGlobalOrdinals(state: DynamicProperty, value: bool) =
            { state with EagerGlobalOrdinals = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: DynamicProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("indexOptions")>]
        member _.IndexOptions(state: DynamicProperty, value: CoreTypes.IndexOptions) =
            { state with IndexOptions = Some value }

        [<CustomOperation("indexPhrases")>]
        member _.IndexPhrases(state: DynamicProperty, value: bool) =
            { state with IndexPhrases = Some value }

        [<CustomOperation("indexPrefixes")>]
        member _.IndexPrefixes(state: DynamicProperty, value: CoreTypes.TextIndexPrefixes option) =
            { state with IndexPrefixes = Some value }

        [<CustomOperation("norms")>]
        member _.Norms(state: DynamicProperty, value: bool) =
            { state with Norms = Some value }

        [<CustomOperation("positionIncrementGap")>]
        member _.PositionIncrementGap(state: DynamicProperty, value: CoreTypes.Integer) =
            { state with PositionIncrementGap = Some value }

        [<CustomOperation("searchAnalyzer")>]
        member _.SearchAnalyzer(state: DynamicProperty, value: string) =
            { state with SearchAnalyzer = Some value }

        [<CustomOperation("searchQuoteAnalyzer")>]
        member _.SearchQuoteAnalyzer(state: DynamicProperty, value: string) =
            { state with SearchQuoteAnalyzer = Some value }

        [<CustomOperation("termVector")>]
        member _.TermVector(state: DynamicProperty, value: CoreTypes.TermVectorOption) =
            { state with TermVector = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: DynamicProperty, value: string) =
            { state with Format = Some value }

        [<CustomOperation("precisionStep")>]
        member _.PrecisionStep(state: DynamicProperty, value: CoreTypes.Integer) =
            { state with PrecisionStep = Some value }

        [<CustomOperation("locale")>]
        member _.Locale(state: DynamicProperty, value: string) =
            { state with Locale = Some value }

    let dynamicProperty = DynamicPropertyBuilder()

    module DynamicTemplate =

        let mapping (value: CoreTypes.Property) =
            DynamicTemplate.Mapping value

        let runtime (value: CoreTypes.RuntimeField) =
            DynamicTemplate.Runtime value

    type FlattenedPropertyBuilder() =
        member _.Yield(_: unit) : FlattenedProperty =
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
        member _.Boost(state: FlattenedProperty, value: CoreTypes.Double) =
            { state with Boost = Some value }

        [<CustomOperation("depthLimit")>]
        member _.DepthLimit(state: FlattenedProperty, value: CoreTypes.Integer) =
            { state with DepthLimit = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: FlattenedProperty, value: bool) =
            { state with DocValues = Some value }

        [<CustomOperation("eagerGlobalOrdinals")>]
        member _.EagerGlobalOrdinals(state: FlattenedProperty, value: bool) =
            { state with EagerGlobalOrdinals = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: FlattenedProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("indexOptions")>]
        member _.IndexOptions(state: FlattenedProperty, value: CoreTypes.IndexOptions) =
            { state with IndexOptions = Some value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: FlattenedProperty, value: string) =
            { state with NullValue = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: FlattenedProperty, value: string) =
            { state with Similarity = Some value }

        [<CustomOperation("splitQueriesOnWhitespace")>]
        member _.SplitQueriesOnWhitespace(state: FlattenedProperty, value: bool) =
            { state with SplitQueriesOnWhitespace = Some value }

        [<CustomOperation("timeSeriesDimensions")>]
        member _.TimeSeriesDimensions(state: FlattenedProperty, value: string list) =
            { state with TimeSeriesDimensions = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: FlattenedProperty, value: string) =
            { state with Type = value }

    let flattenedProperty = FlattenedPropertyBuilder()

    type GeoPointPropertyBuilder() =
        member _.Yield(_: unit) : GeoPointProperty =
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
        member _.IgnoreMalformed(state: GeoPointProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("ignoreZValue")>]
        member _.IgnoreZValue(state: GeoPointProperty, value: bool) =
            { state with IgnoreZValue = Some value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: GeoPointProperty, value: CoreTypes.GeoLocation) =
            { state with NullValue = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: GeoPointProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: GeoPointProperty, value: CoreTypes.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: GeoPointProperty, value: CoreTypes.Script) =
            { state with Script = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: GeoPointProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("timeSeriesMetric")>]
        member _.TimeSeriesMetric(state: GeoPointProperty, value: CoreTypes.GeoPointMetricType) =
            { state with TimeSeriesMetric = Some value }

    let geoPointProperty = GeoPointPropertyBuilder()

    type GeoShapePropertyBuilder() =
        member _.Yield(_: unit) : GeoShapeProperty =
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
        member _.Coerce(state: GeoShapeProperty, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: GeoShapeProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("ignoreZValue")>]
        member _.IgnoreZValue(state: GeoShapeProperty, value: bool) =
            { state with IgnoreZValue = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: GeoShapeProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("orientation")>]
        member _.Orientation(state: GeoShapeProperty, value: CoreTypes.GeoOrientation) =
            { state with Orientation = Some value }

        [<CustomOperation("strategy")>]
        member _.Strategy(state: GeoShapeProperty, value: CoreTypes.GeoStrategy) =
            { state with Strategy = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: GeoShapeProperty, value: string) =
            { state with Type = value }

    let geoShapeProperty = GeoShapePropertyBuilder()

    type HistogramPropertyBuilder() =
        member _.Yield(_: unit) : HistogramProperty =
            {
                IgnoreMalformed = None
                TimeSeriesMetric = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: HistogramProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("timeSeriesMetric")>]
        member _.TimeSeriesMetric(state: HistogramProperty, value: CoreTypes.TimeSeriesMetricType) =
            { state with TimeSeriesMetric = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: HistogramProperty, value: string) =
            { state with Type = value }

    let histogramProperty = HistogramPropertyBuilder()

    type IcuCollationPropertyBuilder() =
        member _.Yield(_: unit) : IcuCollationProperty =
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
        member _.Type(state: IcuCollationProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("norms")>]
        member _.Norms(state: IcuCollationProperty, value: bool) =
            { state with Norms = Some value }

        [<CustomOperation("indexOptions")>]
        member _.IndexOptions(state: IcuCollationProperty, value: CoreTypes.IndexOptions) =
            { state with IndexOptions = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: IcuCollationProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: IcuCollationProperty, value: string) =
            { state with NullValue = Some value }

        [<CustomOperation("rules")>]
        member _.Rules(state: IcuCollationProperty, value: string) =
            { state with Rules = Some value }

        [<CustomOperation("language")>]
        member _.Language(state: IcuCollationProperty, value: string) =
            { state with Language = Some value }

        [<CustomOperation("country")>]
        member _.Country(state: IcuCollationProperty, value: string) =
            { state with Country = Some value }

        [<CustomOperation("variant")>]
        member _.Variant(state: IcuCollationProperty, value: string) =
            { state with Variant = Some value }

        [<CustomOperation("strength")>]
        member _.Strength(state: IcuCollationProperty, value: CoreTypes.IcuCollationStrength) =
            { state with Strength = Some value }

        [<CustomOperation("decomposition")>]
        member _.Decomposition(state: IcuCollationProperty, value: CoreTypes.IcuCollationDecomposition) =
            { state with Decomposition = Some value }

        [<CustomOperation("alternate")>]
        member _.Alternate(state: IcuCollationProperty, value: CoreTypes.IcuCollationAlternate) =
            { state with Alternate = Some value }

        [<CustomOperation("caseLevel")>]
        member _.CaseLevel(state: IcuCollationProperty, value: bool) =
            { state with CaseLevel = Some value }

        [<CustomOperation("caseFirst")>]
        member _.CaseFirst(state: IcuCollationProperty, value: CoreTypes.IcuCollationCaseFirst) =
            { state with CaseFirst = Some value }

        [<CustomOperation("numeric")>]
        member _.Numeric(state: IcuCollationProperty, value: bool) =
            { state with Numeric = Some value }

        [<CustomOperation("variableTop")>]
        member _.VariableTop(state: IcuCollationProperty, value: string) =
            { state with VariableTop = Some value }

        [<CustomOperation("hiraganaQuaternaryMode")>]
        member _.HiraganaQuaternaryMode(state: IcuCollationProperty, value: bool) =
            { state with HiraganaQuaternaryMode = Some value }

    let icuCollationProperty = IcuCollationPropertyBuilder()

    type IpPropertyBuilder() =
        member _.Yield(_: unit) : IpProperty =
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
        member _.Boost(state: IpProperty, value: CoreTypes.Double) =
            { state with Boost = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: IpProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: IpProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: IpProperty, value: string) =
            { state with NullValue = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: IpProperty, value: CoreTypes.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: IpProperty, value: CoreTypes.Script) =
            { state with Script = Some value }

        [<CustomOperation("timeSeriesDimension")>]
        member _.TimeSeriesDimension(state: IpProperty, value: bool) =
            { state with TimeSeriesDimension = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: IpProperty, value: string) =
            { state with Type = value }

    let ipProperty = IpPropertyBuilder()

    type JoinPropertyBuilder() =
        member _.Yield(_: unit) : JoinProperty =
            {
                Relations = None
                EagerGlobalOrdinals = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("relations")>]
        member _.Relations(state: JoinProperty, value: Map<CoreTypes.RelationName, System.Text.Json.JsonElement>) =
            { state with Relations = Some value }

        [<CustomOperation("eagerGlobalOrdinals")>]
        member _.EagerGlobalOrdinals(state: JoinProperty, value: bool) =
            { state with EagerGlobalOrdinals = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: JoinProperty, value: string) =
            { state with Type = value }

    let joinProperty = JoinPropertyBuilder()

    type KeywordPropertyBuilder() =
        member _.Yield(_: unit) : KeywordProperty =
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
        member _.Boost(state: KeywordProperty, value: CoreTypes.Double) =
            { state with Boost = Some value }

        [<CustomOperation("eagerGlobalOrdinals")>]
        member _.EagerGlobalOrdinals(state: KeywordProperty, value: bool) =
            { state with EagerGlobalOrdinals = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: KeywordProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("indexOptions")>]
        member _.IndexOptions(state: KeywordProperty, value: CoreTypes.IndexOptions) =
            { state with IndexOptions = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: KeywordProperty, value: CoreTypes.Script) =
            { state with Script = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: KeywordProperty, value: CoreTypes.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("normalizer")>]
        member _.Normalizer(state: KeywordProperty, value: string) =
            { state with Normalizer = Some value }

        [<CustomOperation("norms")>]
        member _.Norms(state: KeywordProperty, value: bool) =
            { state with Norms = Some value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: KeywordProperty, value: string) =
            { state with NullValue = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: KeywordProperty, value: string option) =
            { state with Similarity = Some value }

        [<CustomOperation("splitQueriesOnWhitespace")>]
        member _.SplitQueriesOnWhitespace(state: KeywordProperty, value: bool) =
            { state with SplitQueriesOnWhitespace = Some value }

        [<CustomOperation("timeSeriesDimension")>]
        member _.TimeSeriesDimension(state: KeywordProperty, value: bool) =
            { state with TimeSeriesDimension = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: KeywordProperty, value: string) =
            { state with Type = value }

    let keywordProperty = KeywordPropertyBuilder()

    type MatchOnlyTextPropertyBuilder() =
        member _.Yield(_: unit) : MatchOnlyTextProperty =
            {
                Type = Unchecked.defaultof<_>
                Fields = None
                Meta = None
                CopyTo = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: MatchOnlyTextProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("fields")>]
        member _.Fields(state: MatchOnlyTextProperty, value: Map<CoreTypes.PropertyName, CoreTypes.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: MatchOnlyTextProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: MatchOnlyTextProperty, value: CoreTypes.Fields) =
            { state with CopyTo = Some value }

    let matchOnlyTextProperty = MatchOnlyTextPropertyBuilder()

    type NestedPropertyBuilder() =
        member _.Yield(_: unit) : NestedProperty =
            {
                Enabled = None
                IncludeInParent = None
                IncludeInRoot = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: NestedProperty, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("includeInParent")>]
        member _.IncludeInParent(state: NestedProperty, value: bool) =
            { state with IncludeInParent = Some value }

        [<CustomOperation("includeInRoot")>]
        member _.IncludeInRoot(state: NestedProperty, value: bool) =
            { state with IncludeInRoot = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: NestedProperty, value: string) =
            { state with Type = value }

    let nestedProperty = NestedPropertyBuilder()

    type NumberPropertyBaseBuilder() =
        member _.Yield(_: unit) : NumberPropertyBase =
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
        member _.Boost(state: NumberPropertyBase, value: CoreTypes.Double) =
            { state with Boost = Some value }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: NumberPropertyBase, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: NumberPropertyBase, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: NumberPropertyBase, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: NumberPropertyBase, value: CoreTypes.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: NumberPropertyBase, value: CoreTypes.Script) =
            { state with Script = Some value }

        [<CustomOperation("timeSeriesMetric")>]
        member _.TimeSeriesMetric(state: NumberPropertyBase, value: CoreTypes.TimeSeriesMetricType) =
            { state with TimeSeriesMetric = Some value }

        [<CustomOperation("timeSeriesDimension")>]
        member _.TimeSeriesDimension(state: NumberPropertyBase, value: bool) =
            { state with TimeSeriesDimension = Some value }

    let numberPropertyBase = NumberPropertyBaseBuilder()

    type ObjectPropertyBuilder() =
        member _.Yield(_: unit) : ObjectProperty =
            {
                Enabled = None
                Subobjects = None
                Type = None
            }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: ObjectProperty, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("subobjects")>]
        member _.Subobjects(state: ObjectProperty, value: CoreTypes.Subobjects) =
            { state with Subobjects = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: ObjectProperty, value: string) =
            { state with Type = Some value }

    let objectProperty = ObjectPropertyBuilder()

    type PassthroughObjectPropertyBuilder() =
        member _.Yield(_: unit) : PassthroughObjectProperty =
            {
                Type = None
                Enabled = None
                Priority = None
                TimeSeriesDimension = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: PassthroughObjectProperty, value: string) =
            { state with Type = Some value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: PassthroughObjectProperty, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("priority")>]
        member _.Priority(state: PassthroughObjectProperty, value: CoreTypes.Integer) =
            { state with Priority = Some value }

        [<CustomOperation("timeSeriesDimension")>]
        member _.TimeSeriesDimension(state: PassthroughObjectProperty, value: bool) =
            { state with TimeSeriesDimension = Some value }

    let passthroughObjectProperty = PassthroughObjectPropertyBuilder()

    type PointPropertyBuilder() =
        member _.Yield(_: unit) : PointProperty =
            {
                IgnoreMalformed = None
                IgnoreZValue = None
                NullValue = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: PointProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("ignoreZValue")>]
        member _.IgnoreZValue(state: PointProperty, value: bool) =
            { state with IgnoreZValue = Some value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: PointProperty, value: string) =
            { state with NullValue = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: PointProperty, value: string) =
            { state with Type = value }

    let pointProperty = PointPropertyBuilder()

    type PropertyBaseBuilder() =
        member _.Yield(_: unit) : PropertyBase =
            {
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
            }

        [<CustomOperation("meta")>]
        member _.Meta(state: PropertyBase, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: PropertyBase, value: Map<CoreTypes.PropertyName, CoreTypes.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: PropertyBase, value: CoreTypes.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: PropertyBase, value: CoreTypes.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: PropertyBase, value: Map<CoreTypes.PropertyName, CoreTypes.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: PropertyBase, value: CoreTypes.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

    let propertyBase = PropertyBaseBuilder()

    type RangePropertyBaseBuilder() =
        member _.Yield(_: unit) : RangePropertyBase =
            {
                Boost = None
                Coerce = None
                Index = None
            }

        [<CustomOperation("boost")>]
        member _.Boost(state: RangePropertyBase, value: CoreTypes.Double) =
            { state with Boost = Some value }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: RangePropertyBase, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: RangePropertyBase, value: bool) =
            { state with Index = Some value }

    let rangePropertyBase = RangePropertyBaseBuilder()

    type RankVectorPropertyBuilder() =
        member _.Yield(_: unit) : RankVectorProperty =
            {
                Type = Unchecked.defaultof<_>
                ElementType = None
                Dims = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: RankVectorProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("elementType")>]
        member _.ElementType(state: RankVectorProperty, value: CoreTypes.RankVectorElementType) =
            { state with ElementType = Some value }

        [<CustomOperation("dims")>]
        member _.Dims(state: RankVectorProperty, value: CoreTypes.Integer) =
            { state with Dims = Some value }

    let rankVectorProperty = RankVectorPropertyBuilder()

    type RuntimeFieldBuilder() =
        member _.Yield(_: unit) : RuntimeField =
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
        member _.Fields(state: RuntimeField, value: Map<string, CoreTypes.CompositeSubField>) =
            { state with Fields = Some value }

        [<CustomOperation("fetchFields")>]
        member _.FetchFields(state: RuntimeField, value: CoreTypes.RuntimeFieldFetchFields list) =
            { state with FetchFields = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: RuntimeField, value: string) =
            { state with Format = Some value }

        [<CustomOperation("inputField")>]
        member _.InputField(state: RuntimeField, value: CoreTypes.Field) =
            { state with InputField = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: RuntimeField, value: CoreTypes.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("targetIndex")>]
        member _.TargetIndex(state: RuntimeField, value: CoreTypes.IndexName) =
            { state with TargetIndex = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: RuntimeField, value: CoreTypes.Script) =
            { state with Script = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: RuntimeField, value: CoreTypes.RuntimeFieldType) =
            { state with Type = value }

    let runtimeField = RuntimeFieldBuilder()

    type ScaledFloatNumberPropertyBuilder() =
        member _.Yield(_: unit) : ScaledFloatNumberProperty =
            {
                Type = Unchecked.defaultof<_>
                NullValue = None
                ScalingFactor = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: ScaledFloatNumberProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: ScaledFloatNumberProperty, value: CoreTypes.Double) =
            { state with NullValue = Some value }

        [<CustomOperation("scalingFactor")>]
        member _.ScalingFactor(state: ScaledFloatNumberProperty, value: CoreTypes.Double) =
            { state with ScalingFactor = Some value }

    let scaledFloatNumberProperty = ScaledFloatNumberPropertyBuilder()

    type SearchAsYouTypePropertyBuilder() =
        member _.Yield(_: unit) : SearchAsYouTypeProperty =
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
        member _.Analyzer(state: SearchAsYouTypeProperty, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: SearchAsYouTypeProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("indexOptions")>]
        member _.IndexOptions(state: SearchAsYouTypeProperty, value: CoreTypes.IndexOptions) =
            { state with IndexOptions = Some value }

        [<CustomOperation("maxShingleSize")>]
        member _.MaxShingleSize(state: SearchAsYouTypeProperty, value: CoreTypes.Integer) =
            { state with MaxShingleSize = Some value }

        [<CustomOperation("norms")>]
        member _.Norms(state: SearchAsYouTypeProperty, value: bool) =
            { state with Norms = Some value }

        [<CustomOperation("searchAnalyzer")>]
        member _.SearchAnalyzer(state: SearchAsYouTypeProperty, value: string) =
            { state with SearchAnalyzer = Some value }

        [<CustomOperation("searchQuoteAnalyzer")>]
        member _.SearchQuoteAnalyzer(state: SearchAsYouTypeProperty, value: string) =
            { state with SearchQuoteAnalyzer = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: SearchAsYouTypeProperty, value: string option) =
            { state with Similarity = Some value }

        [<CustomOperation("termVector")>]
        member _.TermVector(state: SearchAsYouTypeProperty, value: CoreTypes.TermVectorOption) =
            { state with TermVector = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: SearchAsYouTypeProperty, value: string) =
            { state with Type = value }

    let searchAsYouTypeProperty = SearchAsYouTypePropertyBuilder()

    type SemanticTextIndexOptionsBuilder() =
        member _.Yield(_: unit) : SemanticTextIndexOptions =
            {
                DenseVector = None
                SparseVector = None
            }

        [<CustomOperation("denseVector")>]
        member _.DenseVector(state: SemanticTextIndexOptions, value: CoreTypes.DenseVectorIndexOptions) =
            { state with DenseVector = Some value }

        [<CustomOperation("sparseVector")>]
        member _.SparseVector(state: SemanticTextIndexOptions, value: CoreTypes.SparseVectorIndexOptions) =
            { state with SparseVector = Some value }

    let semanticTextIndexOptions = SemanticTextIndexOptionsBuilder()

    type SemanticTextPropertyBuilder() =
        member _.Yield(_: unit) : SemanticTextProperty =
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
        member _.Type(state: SemanticTextProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("meta")>]
        member _.Meta(state: SemanticTextProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: SemanticTextProperty, value: CoreTypes.Id) =
            { state with InferenceId = Some value }

        [<CustomOperation("searchInferenceId")>]
        member _.SearchInferenceId(state: SemanticTextProperty, value: CoreTypes.Id) =
            { state with SearchInferenceId = Some value }

        [<CustomOperation("indexOptions")>]
        member _.IndexOptions(state: SemanticTextProperty, value: CoreTypes.SemanticTextIndexOptions) =
            { state with IndexOptions = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: SemanticTextProperty, value: CoreTypes.ChunkingSettings option) =
            { state with ChunkingSettings = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: SemanticTextProperty, value: Map<CoreTypes.PropertyName, CoreTypes.Property>) =
            { state with Fields = Some value }

    let semanticTextProperty = SemanticTextPropertyBuilder()

    type ShapePropertyBuilder() =
        member _.Yield(_: unit) : ShapeProperty =
            {
                Coerce = None
                IgnoreMalformed = None
                IgnoreZValue = None
                Orientation = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: ShapeProperty, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: ShapeProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("ignoreZValue")>]
        member _.IgnoreZValue(state: ShapeProperty, value: bool) =
            { state with IgnoreZValue = Some value }

        [<CustomOperation("orientation")>]
        member _.Orientation(state: ShapeProperty, value: CoreTypes.GeoOrientation) =
            { state with Orientation = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: ShapeProperty, value: string) =
            { state with Type = value }

    let shapeProperty = ShapePropertyBuilder()

    type SourceFieldBuilder() =
        member _.Yield(_: unit) : SourceField =
            {
                Compress = None
                CompressThreshold = None
                Enabled = None
                Excludes = None
                Includes = None
                Mode = None
            }

        [<CustomOperation("compress")>]
        member _.Compress(state: SourceField, value: bool) =
            { state with Compress = Some value }

        [<CustomOperation("compressThreshold")>]
        member _.CompressThreshold(state: SourceField, value: string) =
            { state with CompressThreshold = Some value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: SourceField, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("excludes")>]
        member _.Excludes(state: SourceField, value: string list) =
            { state with Excludes = Some value }

        [<CustomOperation("includes")>]
        member _.Includes(state: SourceField, value: string list) =
            { state with Includes = Some value }

        [<CustomOperation("mode")>]
        member _.Mode(state: SourceField, value: CoreTypes.SourceFieldMode) =
            { state with Mode = Some value }

    let sourceField = SourceFieldBuilder()

    type SparseVectorIndexOptionsBuilder() =
        member _.Yield(_: unit) : SparseVectorIndexOptions =
            {
                Prune = None
                PruningConfig = None
            }

        [<CustomOperation("prune")>]
        member _.Prune(state: SparseVectorIndexOptions, value: bool) =
            { state with Prune = Some value }

        [<CustomOperation("pruningConfig")>]
        member _.PruningConfig(state: SparseVectorIndexOptions, value: CoreTypes.TokenPruningConfig) =
            { state with PruningConfig = Some value }

    let sparseVectorIndexOptions = SparseVectorIndexOptionsBuilder()

    type SparseVectorPropertyBuilder() =
        member _.Yield(_: unit) : SparseVectorProperty =
            {
                Store = None
                Type = Unchecked.defaultof<_>
                IndexOptions = None
            }

        [<CustomOperation("store")>]
        member _.Store(state: SparseVectorProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: SparseVectorProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("indexOptions")>]
        member _.IndexOptions(state: SparseVectorProperty, value: CoreTypes.SparseVectorIndexOptions) =
            { state with IndexOptions = Some value }

    let sparseVectorProperty = SparseVectorPropertyBuilder()

    type SuggestContextBuilder() =
        member _.Yield(_: unit) : SuggestContext =
            {
                Name = Unchecked.defaultof<_>
                Path = None
                Type = Unchecked.defaultof<_>
                Precision = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: SuggestContext, value: CoreTypes.Name) =
            { state with Name = value }

        [<CustomOperation("path")>]
        member _.Path(state: SuggestContext, value: CoreTypes.Field) =
            { state with Path = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: SuggestContext, value: string) =
            { state with Type = value }

        [<CustomOperation("precision")>]
        member _.Precision(state: SuggestContext, value: System.Text.Json.JsonElement) =
            { state with Precision = Some value }

    let suggestContext = SuggestContextBuilder()

    type TextPropertyBuilder() =
        member _.Yield(_: unit) : TextProperty =
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
        member _.Analyzer(state: TextProperty, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("boost")>]
        member _.Boost(state: TextProperty, value: CoreTypes.Double) =
            { state with Boost = Some value }

        [<CustomOperation("eagerGlobalOrdinals")>]
        member _.EagerGlobalOrdinals(state: TextProperty, value: bool) =
            { state with EagerGlobalOrdinals = Some value }

        [<CustomOperation("fielddata")>]
        member _.Fielddata(state: TextProperty, value: bool) =
            { state with Fielddata = Some value }

        [<CustomOperation("fielddataFrequencyFilter")>]
        member _.FielddataFrequencyFilter(state: TextProperty, value: IndicesTypes.FielddataFrequencyFilter) =
            { state with FielddataFrequencyFilter = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: TextProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("indexOptions")>]
        member _.IndexOptions(state: TextProperty, value: CoreTypes.IndexOptions) =
            { state with IndexOptions = Some value }

        [<CustomOperation("indexPhrases")>]
        member _.IndexPhrases(state: TextProperty, value: bool) =
            { state with IndexPhrases = Some value }

        [<CustomOperation("indexPrefixes")>]
        member _.IndexPrefixes(state: TextProperty, value: CoreTypes.TextIndexPrefixes option) =
            { state with IndexPrefixes = Some value }

        [<CustomOperation("norms")>]
        member _.Norms(state: TextProperty, value: bool) =
            { state with Norms = Some value }

        [<CustomOperation("positionIncrementGap")>]
        member _.PositionIncrementGap(state: TextProperty, value: CoreTypes.Integer) =
            { state with PositionIncrementGap = Some value }

        [<CustomOperation("searchAnalyzer")>]
        member _.SearchAnalyzer(state: TextProperty, value: string) =
            { state with SearchAnalyzer = Some value }

        [<CustomOperation("searchQuoteAnalyzer")>]
        member _.SearchQuoteAnalyzer(state: TextProperty, value: string) =
            { state with SearchQuoteAnalyzer = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: TextProperty, value: string option) =
            { state with Similarity = Some value }

        [<CustomOperation("termVector")>]
        member _.TermVector(state: TextProperty, value: CoreTypes.TermVectorOption) =
            { state with TermVector = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: TextProperty, value: string) =
            { state with Type = value }

    let textProperty = TextPropertyBuilder()

    type TokenCountPropertyBuilder() =
        member _.Yield(_: unit) : TokenCountProperty =
            {
                Analyzer = None
                Boost = None
                Index = None
                NullValue = None
                EnablePositionIncrements = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: TokenCountProperty, value: string) =
            { state with Analyzer = Some value }

        [<CustomOperation("boost")>]
        member _.Boost(state: TokenCountProperty, value: CoreTypes.Double) =
            { state with Boost = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: TokenCountProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: TokenCountProperty, value: CoreTypes.Double) =
            { state with NullValue = Some value }

        [<CustomOperation("enablePositionIncrements")>]
        member _.EnablePositionIncrements(state: TokenCountProperty, value: bool) =
            { state with EnablePositionIncrements = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: TokenCountProperty, value: string) =
            { state with Type = value }

    let tokenCountProperty = TokenCountPropertyBuilder()

    type TypeMappingBuilder() =
        member _.Yield(_: unit) : TypeMapping =
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
        member _.AllField(state: TypeMapping, value: CoreTypes.AllField) =
            { state with AllField = Some value }

        [<CustomOperation("dateDetection")>]
        member _.DateDetection(state: TypeMapping, value: bool) =
            { state with DateDetection = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: TypeMapping, value: CoreTypes.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("dynamicDateFormats")>]
        member _.DynamicDateFormats(state: TypeMapping, value: string list) =
            { state with DynamicDateFormats = Some value }

        [<CustomOperation("dynamicTemplates")>]
        member _.DynamicTemplates(state: TypeMapping, value: Map<string, CoreTypes.DynamicTemplate> list) =
            { state with DynamicTemplates = Some value }

        [<CustomOperation("fieldNames")>]
        member _.FieldNames(state: TypeMapping, value: CoreTypes.FieldNamesField) =
            { state with FieldNames = Some value }

        [<CustomOperation("indexField")>]
        member _.IndexField(state: TypeMapping, value: CoreTypes.IndexField) =
            { state with IndexField = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: TypeMapping, value: CoreTypes.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("numericDetection")>]
        member _.NumericDetection(state: TypeMapping, value: bool) =
            { state with NumericDetection = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: TypeMapping, value: Map<CoreTypes.PropertyName, CoreTypes.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: TypeMapping, value: CoreTypes.RoutingField) =
            { state with Routing = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: TypeMapping, value: CoreTypes.SizeField) =
            { state with Size = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: TypeMapping, value: CoreTypes.SourceField) =
            { state with Source = Some value }

        [<CustomOperation("runtime")>]
        member _.Runtime(state: TypeMapping, value: Map<string, CoreTypes.RuntimeField>) =
            { state with Runtime = Some value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: TypeMapping, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("subobjects")>]
        member _.Subobjects(state: TypeMapping, value: CoreTypes.Subobjects) =
            { state with Subobjects = Some value }

        [<CustomOperation("dataStreamTimestamp")>]
        member _.DataStreamTimestamp(state: TypeMapping, value: CoreTypes.DataStreamTimestamp) =
            { state with DataStreamTimestamp = Some value }

    let typeMapping = TypeMappingBuilder()


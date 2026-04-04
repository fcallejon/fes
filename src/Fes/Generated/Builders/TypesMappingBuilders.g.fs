// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module TypesMappingBuilders =

    type AggregateMetricDoublePropertyBuilder() =
        member _.Yield(_: unit) : Types.AggregateMetricDoubleProperty =
            {
                Type = "aggregate_metric_double"
                DefaultMetric = Unchecked.defaultof<_>
                IgnoreMalformed = None
                Metrics = Unchecked.defaultof<_>
                TimeSeriesMetric = None
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.AggregateMetricDoubleProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.AggregateMetricDoubleProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.AggregateMetricDoubleProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.AggregateMetricDoubleProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.AggregateMetricDoubleProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.AggregateMetricDoubleProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

    let aggregateMetricDoubleProperty = AggregateMetricDoublePropertyBuilder()

    type BinaryPropertyBuilder() =
        member _.Yield(_: unit) : Types.BinaryProperty =
            {
                Type = "binary"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.BinaryProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.BinaryProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.BinaryProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.BinaryProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.BinaryProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.BinaryProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.BinaryProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.BinaryProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.BinaryProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.BinaryProperty, value: bool) =
            { state with DocValues = Some value }

    let binaryProperty = BinaryPropertyBuilder()

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
                Type = "boolean"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.BooleanProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.BooleanProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.BooleanProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.BooleanProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.BooleanProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.BooleanProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.BooleanProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.BooleanProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.BooleanProperty, value: bool) =
            { state with DocValues = Some value }

    let booleanProperty = BooleanPropertyBuilder()

    type ByteNumberPropertyBuilder() =
        member _.Yield(_: unit) : Types.ByteNumberProperty =
            {
                Type = "byte"
                NullValue = None
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
                Boost = None
                Coerce = None
                IgnoreMalformed = None
                Index = None
                OnScriptError = None
                Script = None
                TimeSeriesMetric = None
                TimeSeriesDimension = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.ByteNumberProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: Types.ByteNumberProperty, value: Types.Byte) =
            { state with NullValue = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.ByteNumberProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.ByteNumberProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.ByteNumberProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.ByteNumberProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.ByteNumberProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.ByteNumberProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.ByteNumberProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.ByteNumberProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.ByteNumberProperty, value: bool) =
            { state with DocValues = Some value }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.ByteNumberProperty, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: Types.ByteNumberProperty, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: Types.ByteNumberProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.ByteNumberProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: Types.ByteNumberProperty, value: Types.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.ByteNumberProperty, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("timeSeriesMetric")>]
        member _.TimeSeriesMetric(state: Types.ByteNumberProperty, value: Types.TimeSeriesMetricType) =
            { state with TimeSeriesMetric = Some value }

        [<CustomOperation("timeSeriesDimension")>]
        member _.TimeSeriesDimension(state: Types.ByteNumberProperty, value: bool) =
            { state with TimeSeriesDimension = Some value }

    let byteNumberProperty = ByteNumberPropertyBuilder()

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
                Type = "completion"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.CompletionProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.CompletionProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.CompletionProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.CompletionProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.CompletionProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.CompletionProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.CompletionProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.CompletionProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.CompletionProperty, value: bool) =
            { state with DocValues = Some value }

    let completionProperty = CompletionPropertyBuilder()

    type ConstantKeywordPropertyBuilder() =
        member _.Yield(_: unit) : Types.ConstantKeywordProperty =
            {
                Value = None
                Type = "constant_keyword"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
            }

        [<CustomOperation("value")>]
        member _.Value(state: Types.ConstantKeywordProperty, value: System.Text.Json.JsonElement) =
            { state with Value = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.ConstantKeywordProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.ConstantKeywordProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.ConstantKeywordProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.ConstantKeywordProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.ConstantKeywordProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.ConstantKeywordProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.ConstantKeywordProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

    let constantKeywordProperty = ConstantKeywordPropertyBuilder()

    type CorePropertyBaseBuilder() =
        member _.Yield(_: unit) : Types.CorePropertyBase =
            {
                CopyTo = None
                Store = None
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
            }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.CorePropertyBase, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.CorePropertyBase, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.CorePropertyBase, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.CorePropertyBase, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.CorePropertyBase, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.CorePropertyBase, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.CorePropertyBase, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.CorePropertyBase, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

    let corePropertyBase = CorePropertyBaseBuilder()

    type CountedKeywordPropertyBuilder() =
        member _.Yield(_: unit) : Types.CountedKeywordProperty =
            {
                Type = "counted_keyword"
                Index = None
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.CountedKeywordProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.CountedKeywordProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.CountedKeywordProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.CountedKeywordProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.CountedKeywordProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.CountedKeywordProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.CountedKeywordProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.CountedKeywordProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

    let countedKeywordProperty = CountedKeywordPropertyBuilder()

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
                Type = "date_nanos"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.DateNanosProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.DateNanosProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.DateNanosProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.DateNanosProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.DateNanosProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.DateNanosProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.DateNanosProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.DateNanosProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.DateNanosProperty, value: bool) =
            { state with DocValues = Some value }

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
                Type = "date"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.DateProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.DateProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.DateProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.DateProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.DateProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.DateProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.DateProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.DateProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.DateProperty, value: bool) =
            { state with DocValues = Some value }

    let dateProperty = DatePropertyBuilder()

    type DateRangePropertyBuilder() =
        member _.Yield(_: unit) : Types.DateRangeProperty =
            {
                Format = None
                Type = "date_range"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
                Boost = None
                Coerce = None
                Index = None
            }

        [<CustomOperation("format")>]
        member _.Format(state: Types.DateRangeProperty, value: string) =
            { state with Format = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.DateRangeProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.DateRangeProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.DateRangeProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.DateRangeProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.DateRangeProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.DateRangeProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.DateRangeProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.DateRangeProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.DateRangeProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.DateRangeProperty, value: bool) =
            { state with DocValues = Some value }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.DateRangeProperty, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: Types.DateRangeProperty, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.DateRangeProperty, value: bool) =
            { state with Index = Some value }

    let dateRangeProperty = DateRangePropertyBuilder()

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
                Type = "dense_vector"
                Dims = None
                ElementType = None
                Index = None
                IndexOptions = None
                Similarity = None
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.DenseVectorProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.DenseVectorProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.DenseVectorProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.DenseVectorProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.DenseVectorProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.DenseVectorProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

    let denseVectorProperty = DenseVectorPropertyBuilder()

    type DocValuesPropertyBaseBuilder() =
        member _.Yield(_: unit) : Types.DocValuesPropertyBase =
            {
                DocValues = None
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
            }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.DocValuesPropertyBase, value: bool) =
            { state with DocValues = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.DocValuesPropertyBase, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.DocValuesPropertyBase, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.DocValuesPropertyBase, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.DocValuesPropertyBase, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.DocValuesPropertyBase, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.DocValuesPropertyBase, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.DocValuesPropertyBase, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.DocValuesPropertyBase, value: bool) =
            { state with Store = Some value }

    let docValuesPropertyBase = DocValuesPropertyBaseBuilder()

    type DoubleNumberPropertyBuilder() =
        member _.Yield(_: unit) : Types.DoubleNumberProperty =
            {
                Type = "double"
                NullValue = None
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
                Boost = None
                Coerce = None
                IgnoreMalformed = None
                Index = None
                OnScriptError = None
                Script = None
                TimeSeriesMetric = None
                TimeSeriesDimension = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.DoubleNumberProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: Types.DoubleNumberProperty, value: Types.Double) =
            { state with NullValue = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.DoubleNumberProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.DoubleNumberProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.DoubleNumberProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.DoubleNumberProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.DoubleNumberProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.DoubleNumberProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.DoubleNumberProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.DoubleNumberProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.DoubleNumberProperty, value: bool) =
            { state with DocValues = Some value }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.DoubleNumberProperty, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: Types.DoubleNumberProperty, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: Types.DoubleNumberProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.DoubleNumberProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: Types.DoubleNumberProperty, value: Types.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.DoubleNumberProperty, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("timeSeriesMetric")>]
        member _.TimeSeriesMetric(state: Types.DoubleNumberProperty, value: Types.TimeSeriesMetricType) =
            { state with TimeSeriesMetric = Some value }

        [<CustomOperation("timeSeriesDimension")>]
        member _.TimeSeriesDimension(state: Types.DoubleNumberProperty, value: bool) =
            { state with TimeSeriesDimension = Some value }

    let doubleNumberProperty = DoubleNumberPropertyBuilder()

    type DoubleRangePropertyBuilder() =
        member _.Yield(_: unit) : Types.DoubleRangeProperty =
            {
                Type = "double_range"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
                Boost = None
                Coerce = None
                Index = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.DoubleRangeProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.DoubleRangeProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.DoubleRangeProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.DoubleRangeProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.DoubleRangeProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.DoubleRangeProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.DoubleRangeProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.DoubleRangeProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.DoubleRangeProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.DoubleRangeProperty, value: bool) =
            { state with DocValues = Some value }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.DoubleRangeProperty, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: Types.DoubleRangeProperty, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.DoubleRangeProperty, value: bool) =
            { state with Index = Some value }

    let doubleRangeProperty = DoubleRangePropertyBuilder()

    type DynamicPropertyBuilder() =
        member _.Yield(_: unit) : Types.DynamicProperty =
            {
                Type = "{dynamic_type}"
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
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.DynamicProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.DynamicProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.DynamicProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.DynamicProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.DynamicProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.DynamicProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.DynamicProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.DynamicProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.DynamicProperty, value: bool) =
            { state with DocValues = Some value }

    let dynamicProperty = DynamicPropertyBuilder()

    module DynamicTemplate =

        let mapping (value: Types.Property) =
            Types.DynamicTemplate.Mapping value

        let runtime (value: Types.RuntimeField) =
            Types.DynamicTemplate.Runtime value

    type ExponentialHistogramPropertyBuilder() =
        member _.Yield(_: unit) : Types.ExponentialHistogramProperty =
            {
                TimeSeriesMetric = None
                Type = "exponential_histogram"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
            }

        [<CustomOperation("timeSeriesMetric")>]
        member _.TimeSeriesMetric(state: Types.ExponentialHistogramProperty, value: Types.TimeSeriesMetricType) =
            { state with TimeSeriesMetric = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.ExponentialHistogramProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.ExponentialHistogramProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.ExponentialHistogramProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.ExponentialHistogramProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.ExponentialHistogramProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.ExponentialHistogramProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.ExponentialHistogramProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

    let exponentialHistogramProperty = ExponentialHistogramPropertyBuilder()

    type FieldAliasPropertyBuilder() =
        member _.Yield(_: unit) : Types.FieldAliasProperty =
            {
                Path = None
                Type = "alias"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
            }

        [<CustomOperation("path")>]
        member _.Path(state: Types.FieldAliasProperty, value: Types.Field) =
            { state with Path = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.FieldAliasProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.FieldAliasProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.FieldAliasProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.FieldAliasProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.FieldAliasProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.FieldAliasProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.FieldAliasProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

    let fieldAliasProperty = FieldAliasPropertyBuilder()

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
                Type = "flattened"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.FlattenedProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.FlattenedProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.FlattenedProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.FlattenedProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.FlattenedProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.FlattenedProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

    let flattenedProperty = FlattenedPropertyBuilder()

    type FloatNumberPropertyBuilder() =
        member _.Yield(_: unit) : Types.FloatNumberProperty =
            {
                Type = "float"
                NullValue = None
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
                Boost = None
                Coerce = None
                IgnoreMalformed = None
                Index = None
                OnScriptError = None
                Script = None
                TimeSeriesMetric = None
                TimeSeriesDimension = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.FloatNumberProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: Types.FloatNumberProperty, value: Types.Float) =
            { state with NullValue = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.FloatNumberProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.FloatNumberProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.FloatNumberProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.FloatNumberProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.FloatNumberProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.FloatNumberProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.FloatNumberProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.FloatNumberProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.FloatNumberProperty, value: bool) =
            { state with DocValues = Some value }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.FloatNumberProperty, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: Types.FloatNumberProperty, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: Types.FloatNumberProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.FloatNumberProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: Types.FloatNumberProperty, value: Types.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.FloatNumberProperty, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("timeSeriesMetric")>]
        member _.TimeSeriesMetric(state: Types.FloatNumberProperty, value: Types.TimeSeriesMetricType) =
            { state with TimeSeriesMetric = Some value }

        [<CustomOperation("timeSeriesDimension")>]
        member _.TimeSeriesDimension(state: Types.FloatNumberProperty, value: bool) =
            { state with TimeSeriesDimension = Some value }

    let floatNumberProperty = FloatNumberPropertyBuilder()

    type FloatRangePropertyBuilder() =
        member _.Yield(_: unit) : Types.FloatRangeProperty =
            {
                Type = "float_range"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
                Boost = None
                Coerce = None
                Index = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.FloatRangeProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.FloatRangeProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.FloatRangeProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.FloatRangeProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.FloatRangeProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.FloatRangeProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.FloatRangeProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.FloatRangeProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.FloatRangeProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.FloatRangeProperty, value: bool) =
            { state with DocValues = Some value }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.FloatRangeProperty, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: Types.FloatRangeProperty, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.FloatRangeProperty, value: bool) =
            { state with Index = Some value }

    let floatRangeProperty = FloatRangePropertyBuilder()

    type GeoPointPropertyBuilder() =
        member _.Yield(_: unit) : Types.GeoPointProperty =
            {
                IgnoreMalformed = None
                IgnoreZValue = None
                NullValue = None
                Index = None
                OnScriptError = None
                Script = None
                Type = "geo_point"
                TimeSeriesMetric = None
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.GeoPointProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.GeoPointProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.GeoPointProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.GeoPointProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.GeoPointProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.GeoPointProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.GeoPointProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.GeoPointProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.GeoPointProperty, value: bool) =
            { state with DocValues = Some value }

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
                Type = "geo_shape"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.GeoShapeProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.GeoShapeProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.GeoShapeProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.GeoShapeProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.GeoShapeProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.GeoShapeProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.GeoShapeProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.GeoShapeProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.GeoShapeProperty, value: bool) =
            { state with DocValues = Some value }

    let geoShapeProperty = GeoShapePropertyBuilder()

    type HalfFloatNumberPropertyBuilder() =
        member _.Yield(_: unit) : Types.HalfFloatNumberProperty =
            {
                Type = "half_float"
                NullValue = None
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
                Boost = None
                Coerce = None
                IgnoreMalformed = None
                Index = None
                OnScriptError = None
                Script = None
                TimeSeriesMetric = None
                TimeSeriesDimension = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.HalfFloatNumberProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: Types.HalfFloatNumberProperty, value: Types.Float) =
            { state with NullValue = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.HalfFloatNumberProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.HalfFloatNumberProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.HalfFloatNumberProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.HalfFloatNumberProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.HalfFloatNumberProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.HalfFloatNumberProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.HalfFloatNumberProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.HalfFloatNumberProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.HalfFloatNumberProperty, value: bool) =
            { state with DocValues = Some value }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.HalfFloatNumberProperty, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: Types.HalfFloatNumberProperty, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: Types.HalfFloatNumberProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.HalfFloatNumberProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: Types.HalfFloatNumberProperty, value: Types.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.HalfFloatNumberProperty, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("timeSeriesMetric")>]
        member _.TimeSeriesMetric(state: Types.HalfFloatNumberProperty, value: Types.TimeSeriesMetricType) =
            { state with TimeSeriesMetric = Some value }

        [<CustomOperation("timeSeriesDimension")>]
        member _.TimeSeriesDimension(state: Types.HalfFloatNumberProperty, value: bool) =
            { state with TimeSeriesDimension = Some value }

    let halfFloatNumberProperty = HalfFloatNumberPropertyBuilder()

    type HistogramPropertyBuilder() =
        member _.Yield(_: unit) : Types.HistogramProperty =
            {
                IgnoreMalformed = None
                TimeSeriesMetric = None
                Type = "histogram"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.HistogramProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.HistogramProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.HistogramProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.HistogramProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.HistogramProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.HistogramProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

    let histogramProperty = HistogramPropertyBuilder()

    type IcuCollationPropertyBuilder() =
        member _.Yield(_: unit) : Types.IcuCollationProperty =
            {
                Type = "icu_collation_keyword"
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
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.IcuCollationProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.IcuCollationProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.IcuCollationProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.IcuCollationProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.IcuCollationProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.IcuCollationProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.IcuCollationProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.IcuCollationProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.IcuCollationProperty, value: bool) =
            { state with DocValues = Some value }

    let icuCollationProperty = IcuCollationPropertyBuilder()

    type IntegerNumberPropertyBuilder() =
        member _.Yield(_: unit) : Types.IntegerNumberProperty =
            {
                Type = "integer"
                NullValue = None
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
                Boost = None
                Coerce = None
                IgnoreMalformed = None
                Index = None
                OnScriptError = None
                Script = None
                TimeSeriesMetric = None
                TimeSeriesDimension = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.IntegerNumberProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: Types.IntegerNumberProperty, value: Types.Integer) =
            { state with NullValue = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.IntegerNumberProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.IntegerNumberProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.IntegerNumberProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.IntegerNumberProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.IntegerNumberProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.IntegerNumberProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.IntegerNumberProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.IntegerNumberProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.IntegerNumberProperty, value: bool) =
            { state with DocValues = Some value }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.IntegerNumberProperty, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: Types.IntegerNumberProperty, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: Types.IntegerNumberProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.IntegerNumberProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: Types.IntegerNumberProperty, value: Types.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.IntegerNumberProperty, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("timeSeriesMetric")>]
        member _.TimeSeriesMetric(state: Types.IntegerNumberProperty, value: Types.TimeSeriesMetricType) =
            { state with TimeSeriesMetric = Some value }

        [<CustomOperation("timeSeriesDimension")>]
        member _.TimeSeriesDimension(state: Types.IntegerNumberProperty, value: bool) =
            { state with TimeSeriesDimension = Some value }

    let integerNumberProperty = IntegerNumberPropertyBuilder()

    type IntegerRangePropertyBuilder() =
        member _.Yield(_: unit) : Types.IntegerRangeProperty =
            {
                Type = "integer_range"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
                Boost = None
                Coerce = None
                Index = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.IntegerRangeProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.IntegerRangeProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.IntegerRangeProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.IntegerRangeProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.IntegerRangeProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.IntegerRangeProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.IntegerRangeProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.IntegerRangeProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.IntegerRangeProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.IntegerRangeProperty, value: bool) =
            { state with DocValues = Some value }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.IntegerRangeProperty, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: Types.IntegerRangeProperty, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.IntegerRangeProperty, value: bool) =
            { state with Index = Some value }

    let integerRangeProperty = IntegerRangePropertyBuilder()

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
                Type = "ip"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.IpProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.IpProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.IpProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.IpProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.IpProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.IpProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.IpProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.IpProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.IpProperty, value: bool) =
            { state with DocValues = Some value }

    let ipProperty = IpPropertyBuilder()

    type IpRangePropertyBuilder() =
        member _.Yield(_: unit) : Types.IpRangeProperty =
            {
                Type = "ip_range"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
                Boost = None
                Coerce = None
                Index = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.IpRangeProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.IpRangeProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.IpRangeProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.IpRangeProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.IpRangeProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.IpRangeProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.IpRangeProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.IpRangeProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.IpRangeProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.IpRangeProperty, value: bool) =
            { state with DocValues = Some value }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.IpRangeProperty, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: Types.IpRangeProperty, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.IpRangeProperty, value: bool) =
            { state with Index = Some value }

    let ipRangeProperty = IpRangePropertyBuilder()

    type JoinPropertyBuilder() =
        member _.Yield(_: unit) : Types.JoinProperty =
            {
                Relations = None
                EagerGlobalOrdinals = None
                Type = "join"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
            }

        [<CustomOperation("relations")>]
        member _.Relations(state: Types.JoinProperty, value: Map<Types.RelationName, Types.RelationName list>) =
            { state with Relations = Some value }

        [<CustomOperation("eagerGlobalOrdinals")>]
        member _.EagerGlobalOrdinals(state: Types.JoinProperty, value: bool) =
            { state with EagerGlobalOrdinals = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.JoinProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.JoinProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.JoinProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.JoinProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.JoinProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.JoinProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.JoinProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

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
                Type = "keyword"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.KeywordProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.KeywordProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.KeywordProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.KeywordProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.KeywordProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.KeywordProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.KeywordProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.KeywordProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.KeywordProperty, value: bool) =
            { state with DocValues = Some value }

    let keywordProperty = KeywordPropertyBuilder()

    type LongNumberPropertyBuilder() =
        member _.Yield(_: unit) : Types.LongNumberProperty =
            {
                Type = "long"
                NullValue = None
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
                Boost = None
                Coerce = None
                IgnoreMalformed = None
                Index = None
                OnScriptError = None
                Script = None
                TimeSeriesMetric = None
                TimeSeriesDimension = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.LongNumberProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: Types.LongNumberProperty, value: Types.Long) =
            { state with NullValue = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.LongNumberProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.LongNumberProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.LongNumberProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.LongNumberProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.LongNumberProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.LongNumberProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.LongNumberProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.LongNumberProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.LongNumberProperty, value: bool) =
            { state with DocValues = Some value }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.LongNumberProperty, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: Types.LongNumberProperty, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: Types.LongNumberProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.LongNumberProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: Types.LongNumberProperty, value: Types.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.LongNumberProperty, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("timeSeriesMetric")>]
        member _.TimeSeriesMetric(state: Types.LongNumberProperty, value: Types.TimeSeriesMetricType) =
            { state with TimeSeriesMetric = Some value }

        [<CustomOperation("timeSeriesDimension")>]
        member _.TimeSeriesDimension(state: Types.LongNumberProperty, value: bool) =
            { state with TimeSeriesDimension = Some value }

    let longNumberProperty = LongNumberPropertyBuilder()

    type LongRangePropertyBuilder() =
        member _.Yield(_: unit) : Types.LongRangeProperty =
            {
                Type = "long_range"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
                Boost = None
                Coerce = None
                Index = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.LongRangeProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.LongRangeProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.LongRangeProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.LongRangeProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.LongRangeProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.LongRangeProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.LongRangeProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.LongRangeProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.LongRangeProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.LongRangeProperty, value: bool) =
            { state with DocValues = Some value }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.LongRangeProperty, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: Types.LongRangeProperty, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.LongRangeProperty, value: bool) =
            { state with Index = Some value }

    let longRangeProperty = LongRangePropertyBuilder()

    type MatchOnlyTextPropertyBuilder() =
        member _.Yield(_: unit) : Types.MatchOnlyTextProperty =
            {
                Type = "match_only_text"
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

    type Murmur3HashPropertyBuilder() =
        member _.Yield(_: unit) : Types.Murmur3HashProperty =
            {
                Type = "murmur3"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.Murmur3HashProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.Murmur3HashProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.Murmur3HashProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.Murmur3HashProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.Murmur3HashProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.Murmur3HashProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.Murmur3HashProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.Murmur3HashProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.Murmur3HashProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.Murmur3HashProperty, value: bool) =
            { state with DocValues = Some value }

    let murmur3HashProperty = Murmur3HashPropertyBuilder()

    type NestedPropertyBuilder() =
        member _.Yield(_: unit) : Types.NestedProperty =
            {
                Enabled = None
                IncludeInParent = None
                IncludeInRoot = None
                Type = "nested"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.NestedProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.NestedProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.NestedProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.NestedProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.NestedProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.NestedProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.NestedProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.NestedProperty, value: bool) =
            { state with Store = Some value }

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
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.NumberPropertyBase, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.NumberPropertyBase, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.NumberPropertyBase, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.NumberPropertyBase, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.NumberPropertyBase, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.NumberPropertyBase, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.NumberPropertyBase, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.NumberPropertyBase, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.NumberPropertyBase, value: bool) =
            { state with DocValues = Some value }

    let numberPropertyBase = NumberPropertyBaseBuilder()

    type ObjectPropertyBuilder() =
        member _.Yield(_: unit) : Types.ObjectProperty =
            {
                Enabled = None
                Subobjects = None
                Type = None
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.ObjectProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.ObjectProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.ObjectProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.ObjectProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.ObjectProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.ObjectProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.ObjectProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.ObjectProperty, value: bool) =
            { state with Store = Some value }

    let objectProperty = ObjectPropertyBuilder()

    type PassthroughObjectPropertyBuilder() =
        member _.Yield(_: unit) : Types.PassthroughObjectProperty =
            {
                Type = None
                Enabled = None
                Priority = None
                TimeSeriesDimension = None
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.PassthroughObjectProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.PassthroughObjectProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.PassthroughObjectProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.PassthroughObjectProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.PassthroughObjectProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.PassthroughObjectProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.PassthroughObjectProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.PassthroughObjectProperty, value: bool) =
            { state with Store = Some value }

    let passthroughObjectProperty = PassthroughObjectPropertyBuilder()

    type PercolatorPropertyBuilder() =
        member _.Yield(_: unit) : Types.PercolatorProperty =
            {
                Type = "percolator"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.PercolatorProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.PercolatorProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.PercolatorProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.PercolatorProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.PercolatorProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.PercolatorProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.PercolatorProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

    let percolatorProperty = PercolatorPropertyBuilder()

    type PointPropertyBuilder() =
        member _.Yield(_: unit) : Types.PointProperty =
            {
                IgnoreMalformed = None
                IgnoreZValue = None
                NullValue = None
                Type = "point"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.PointProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.PointProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.PointProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.PointProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.PointProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.PointProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.PointProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.PointProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.PointProperty, value: bool) =
            { state with DocValues = Some value }

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
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.RangePropertyBase, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.RangePropertyBase, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.RangePropertyBase, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.RangePropertyBase, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.RangePropertyBase, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.RangePropertyBase, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.RangePropertyBase, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.RangePropertyBase, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.RangePropertyBase, value: bool) =
            { state with DocValues = Some value }

    let rangePropertyBase = RangePropertyBaseBuilder()

    type RankFeaturePropertyBuilder() =
        member _.Yield(_: unit) : Types.RankFeatureProperty =
            {
                PositiveScoreImpact = None
                Type = "rank_feature"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
            }

        [<CustomOperation("positiveScoreImpact")>]
        member _.PositiveScoreImpact(state: Types.RankFeatureProperty, value: bool) =
            { state with PositiveScoreImpact = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.RankFeatureProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.RankFeatureProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.RankFeatureProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.RankFeatureProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.RankFeatureProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.RankFeatureProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.RankFeatureProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

    let rankFeatureProperty = RankFeaturePropertyBuilder()

    type RankFeaturesPropertyBuilder() =
        member _.Yield(_: unit) : Types.RankFeaturesProperty =
            {
                PositiveScoreImpact = None
                Type = "rank_features"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
            }

        [<CustomOperation("positiveScoreImpact")>]
        member _.PositiveScoreImpact(state: Types.RankFeaturesProperty, value: bool) =
            { state with PositiveScoreImpact = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.RankFeaturesProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.RankFeaturesProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.RankFeaturesProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.RankFeaturesProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.RankFeaturesProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.RankFeaturesProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.RankFeaturesProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

    let rankFeaturesProperty = RankFeaturesPropertyBuilder()

    type RankVectorPropertyBuilder() =
        member _.Yield(_: unit) : Types.RankVectorProperty =
            {
                Type = "rank_vectors"
                ElementType = None
                Dims = None
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.RankVectorProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.RankVectorProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.RankVectorProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.RankVectorProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.RankVectorProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.RankVectorProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

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
                Type = "scaled_float"
                NullValue = None
                ScalingFactor = None
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
                Boost = None
                Coerce = None
                IgnoreMalformed = None
                Index = None
                OnScriptError = None
                Script = None
                TimeSeriesMetric = None
                TimeSeriesDimension = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.ScaledFloatNumberProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.ScaledFloatNumberProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.ScaledFloatNumberProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.ScaledFloatNumberProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.ScaledFloatNumberProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.ScaledFloatNumberProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.ScaledFloatNumberProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.ScaledFloatNumberProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.ScaledFloatNumberProperty, value: bool) =
            { state with DocValues = Some value }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.ScaledFloatNumberProperty, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: Types.ScaledFloatNumberProperty, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: Types.ScaledFloatNumberProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.ScaledFloatNumberProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: Types.ScaledFloatNumberProperty, value: Types.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.ScaledFloatNumberProperty, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("timeSeriesMetric")>]
        member _.TimeSeriesMetric(state: Types.ScaledFloatNumberProperty, value: Types.TimeSeriesMetricType) =
            { state with TimeSeriesMetric = Some value }

        [<CustomOperation("timeSeriesDimension")>]
        member _.TimeSeriesDimension(state: Types.ScaledFloatNumberProperty, value: bool) =
            { state with TimeSeriesDimension = Some value }

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
                Type = "search_as_you_type"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.SearchAsYouTypeProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.SearchAsYouTypeProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.SearchAsYouTypeProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.SearchAsYouTypeProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.SearchAsYouTypeProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.SearchAsYouTypeProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.SearchAsYouTypeProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.SearchAsYouTypeProperty, value: bool) =
            { state with Store = Some value }

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
                Type = "semantic_text"
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
                Type = "shape"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.ShapeProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.ShapeProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.ShapeProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.ShapeProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.ShapeProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.ShapeProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.ShapeProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.ShapeProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.ShapeProperty, value: bool) =
            { state with DocValues = Some value }

    let shapeProperty = ShapePropertyBuilder()

    type ShortNumberPropertyBuilder() =
        member _.Yield(_: unit) : Types.ShortNumberProperty =
            {
                Type = "short"
                NullValue = None
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
                Boost = None
                Coerce = None
                IgnoreMalformed = None
                Index = None
                OnScriptError = None
                Script = None
                TimeSeriesMetric = None
                TimeSeriesDimension = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.ShortNumberProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: Types.ShortNumberProperty, value: Types.Short) =
            { state with NullValue = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.ShortNumberProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.ShortNumberProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.ShortNumberProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.ShortNumberProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.ShortNumberProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.ShortNumberProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.ShortNumberProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.ShortNumberProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.ShortNumberProperty, value: bool) =
            { state with DocValues = Some value }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.ShortNumberProperty, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: Types.ShortNumberProperty, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: Types.ShortNumberProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.ShortNumberProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: Types.ShortNumberProperty, value: Types.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.ShortNumberProperty, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("timeSeriesMetric")>]
        member _.TimeSeriesMetric(state: Types.ShortNumberProperty, value: Types.TimeSeriesMetricType) =
            { state with TimeSeriesMetric = Some value }

        [<CustomOperation("timeSeriesDimension")>]
        member _.TimeSeriesDimension(state: Types.ShortNumberProperty, value: bool) =
            { state with TimeSeriesDimension = Some value }

    let shortNumberProperty = ShortNumberPropertyBuilder()

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
                Type = "sparse_vector"
                IndexOptions = None
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.SparseVectorProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.SparseVectorProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.SparseVectorProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.SparseVectorProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.SparseVectorProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.SparseVectorProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

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
                Type = "text"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.TextProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.TextProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.TextProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.TextProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.TextProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.TextProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.TextProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.TextProperty, value: bool) =
            { state with Store = Some value }

    let textProperty = TextPropertyBuilder()

    type TokenCountPropertyBuilder() =
        member _.Yield(_: unit) : Types.TokenCountProperty =
            {
                Analyzer = None
                Boost = None
                Index = None
                NullValue = None
                EnablePositionIncrements = None
                Type = "token_count"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
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

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.TokenCountProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.TokenCountProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.TokenCountProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.TokenCountProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.TokenCountProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.TokenCountProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.TokenCountProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.TokenCountProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.TokenCountProperty, value: bool) =
            { state with DocValues = Some value }

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

    type UnsignedLongNumberPropertyBuilder() =
        member _.Yield(_: unit) : Types.UnsignedLongNumberProperty =
            {
                Type = "unsigned_long"
                NullValue = None
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
                Boost = None
                Coerce = None
                IgnoreMalformed = None
                Index = None
                OnScriptError = None
                Script = None
                TimeSeriesMetric = None
                TimeSeriesDimension = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.UnsignedLongNumberProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: Types.UnsignedLongNumberProperty, value: Types.Ulong) =
            { state with NullValue = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.UnsignedLongNumberProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.UnsignedLongNumberProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.UnsignedLongNumberProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.UnsignedLongNumberProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.UnsignedLongNumberProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.UnsignedLongNumberProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.UnsignedLongNumberProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.UnsignedLongNumberProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.UnsignedLongNumberProperty, value: bool) =
            { state with DocValues = Some value }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.UnsignedLongNumberProperty, value: Types.Double) =
            { state with Boost = Some value }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: Types.UnsignedLongNumberProperty, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: Types.UnsignedLongNumberProperty, value: bool) =
            { state with IgnoreMalformed = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.UnsignedLongNumberProperty, value: bool) =
            { state with Index = Some value }

        [<CustomOperation("onScriptError")>]
        member _.OnScriptError(state: Types.UnsignedLongNumberProperty, value: Types.OnScriptError) =
            { state with OnScriptError = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.UnsignedLongNumberProperty, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("timeSeriesMetric")>]
        member _.TimeSeriesMetric(state: Types.UnsignedLongNumberProperty, value: Types.TimeSeriesMetricType) =
            { state with TimeSeriesMetric = Some value }

        [<CustomOperation("timeSeriesDimension")>]
        member _.TimeSeriesDimension(state: Types.UnsignedLongNumberProperty, value: bool) =
            { state with TimeSeriesDimension = Some value }

    let unsignedLongNumberProperty = UnsignedLongNumberPropertyBuilder()

    type VersionPropertyBuilder() =
        member _.Yield(_: unit) : Types.VersionProperty =
            {
                Type = "version"
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.VersionProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.VersionProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.VersionProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.VersionProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.VersionProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.VersionProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.VersionProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.VersionProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.VersionProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.VersionProperty, value: bool) =
            { state with DocValues = Some value }

    let versionProperty = VersionPropertyBuilder()

    type WildcardPropertyBuilder() =
        member _.Yield(_: unit) : Types.WildcardProperty =
            {
                Type = "wildcard"
                NullValue = None
                Meta = None
                Properties = None
                IgnoreAbove = None
                Dynamic = None
                Fields = None
                SyntheticSourceKeep = None
                CopyTo = None
                Store = None
                DocValues = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.WildcardProperty, value: string) =
            { state with Type = value }

        [<CustomOperation("nullValue")>]
        member _.NullValue(state: Types.WildcardProperty, value: string) =
            { state with NullValue = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.WildcardProperty, value: Map<string, string>) =
            { state with Meta = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.WildcardProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Properties = Some value }

        [<CustomOperation("ignoreAbove")>]
        member _.IgnoreAbove(state: Types.WildcardProperty, value: Types.Integer) =
            { state with IgnoreAbove = Some value }

        [<CustomOperation("dynamic")>]
        member _.Dynamic(state: Types.WildcardProperty, value: Types.DynamicMapping) =
            { state with Dynamic = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.WildcardProperty, value: Map<Types.PropertyName, Types.Property>) =
            { state with Fields = Some value }

        [<CustomOperation("syntheticSourceKeep")>]
        member _.SyntheticSourceKeep(state: Types.WildcardProperty, value: Types.SyntheticSourceKeepEnum) =
            { state with SyntheticSourceKeep = Some value }

        [<CustomOperation("copyTo")>]
        member _.CopyTo(state: Types.WildcardProperty, value: Types.Fields) =
            { state with CopyTo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.WildcardProperty, value: bool) =
            { state with Store = Some value }

        [<CustomOperation("docValues")>]
        member _.DocValues(state: Types.WildcardProperty, value: bool) =
            { state with DocValues = Some value }

    let wildcardProperty = WildcardPropertyBuilder()


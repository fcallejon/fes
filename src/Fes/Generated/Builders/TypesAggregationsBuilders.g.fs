// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module TypesAggregationsBuilders =

    type AdjacencyMatrixAggregationBuilder() =
        member _.Yield(_: unit) : AdjacencyMatrixAggregation =
            {
                Filters = None
                Separator = None
            }

        [<CustomOperation("filters")>]
        member _.Filters(state: AdjacencyMatrixAggregation, value: Map<string, CoreTypes.QueryContainer>) =
            { state with Filters = Some value }

        [<CustomOperation("separator")>]
        member _.Separator(state: AdjacencyMatrixAggregation, value: string) =
            { state with Separator = Some value }

    let adjacencyMatrixAggregation = AdjacencyMatrixAggregationBuilder()

    module Aggregation =

        let adjacencyMatrix (value: CoreTypes.AdjacencyMatrixAggregation) =
            AggregationContainer.AdjacencyMatrix value

        let autoDateHistogram (value: CoreTypes.AutoDateHistogramAggregation) =
            AggregationContainer.AutoDateHistogram value

        let avg (value: CoreTypes.AverageAggregation) =
            AggregationContainer.Avg value

        let avgBucket (value: CoreTypes.AverageBucketAggregation) =
            AggregationContainer.AvgBucket value

        let boxplot (value: CoreTypes.BoxplotAggregation) =
            AggregationContainer.Boxplot value

        let bucketScript (value: CoreTypes.BucketScriptAggregation) =
            AggregationContainer.BucketScript value

        let bucketSelector (value: CoreTypes.BucketSelectorAggregation) =
            AggregationContainer.BucketSelector value

        let bucketSort (value: CoreTypes.BucketSortAggregation) =
            AggregationContainer.BucketSort value

        let bucketCountKsTest (value: CoreTypes.BucketKsAggregation) =
            AggregationContainer.BucketCountKsTest value

        let bucketCorrelation (value: CoreTypes.BucketCorrelationAggregation) =
            AggregationContainer.BucketCorrelation value

        let cardinality (value: CoreTypes.CardinalityAggregation) =
            AggregationContainer.Cardinality value

        let cartesianBounds (value: CoreTypes.CartesianBoundsAggregation) =
            AggregationContainer.CartesianBounds value

        let cartesianCentroid (value: CoreTypes.CartesianCentroidAggregation) =
            AggregationContainer.CartesianCentroid value

        let categorizeText (value: CoreTypes.CategorizeTextAggregation) =
            AggregationContainer.CategorizeText value

        let changePoint (value: CoreTypes.ChangePointAggregation) =
            AggregationContainer.ChangePoint value

        let children (value: CoreTypes.ChildrenAggregation) =
            AggregationContainer.Children value

        let composite (value: CoreTypes.CompositeAggregation) =
            AggregationContainer.Composite value

        let cumulativeCardinality (value: CoreTypes.CumulativeCardinalityAggregation) =
            AggregationContainer.CumulativeCardinality value

        let cumulativeSum (value: CoreTypes.CumulativeSumAggregation) =
            AggregationContainer.CumulativeSum value

        let dateHistogram (value: CoreTypes.DateHistogramAggregation) =
            AggregationContainer.DateHistogram value

        let dateRange (value: CoreTypes.DateRangeAggregation) =
            AggregationContainer.DateRange value

        let derivative (value: CoreTypes.DerivativeAggregation) =
            AggregationContainer.Derivative value

        let diversifiedSampler (value: CoreTypes.DiversifiedSamplerAggregation) =
            AggregationContainer.DiversifiedSampler value

        let extendedStats (value: CoreTypes.ExtendedStatsAggregation) =
            AggregationContainer.ExtendedStats value

        let extendedStatsBucket (value: CoreTypes.ExtendedStatsBucketAggregation) =
            AggregationContainer.ExtendedStatsBucket value

        let frequentItemSets (value: CoreTypes.FrequentItemSetsAggregation) =
            AggregationContainer.FrequentItemSets value

        let filter (value: CoreTypes.QueryContainer) =
            AggregationContainer.Filter value

        let filters (value: CoreTypes.FiltersAggregation) =
            AggregationContainer.Filters value

        let geoBounds (value: CoreTypes.GeoBoundsAggregation) =
            AggregationContainer.GeoBounds value

        let geoCentroid (value: CoreTypes.GeoCentroidAggregation) =
            AggregationContainer.GeoCentroid value

        let geoDistance (value: CoreTypes.GeoDistanceAggregation) =
            AggregationContainer.GeoDistance value

        let geohashGrid (value: CoreTypes.GeoHashGridAggregation) =
            AggregationContainer.GeohashGrid value

        let geoLine (value: CoreTypes.GeoLineAggregation) =
            AggregationContainer.GeoLine value

        let geotileGrid (value: CoreTypes.GeoTileGridAggregation) =
            AggregationContainer.GeotileGrid value

        let geohexGrid (value: CoreTypes.GeohexGridAggregation) =
            AggregationContainer.GeohexGrid value

        let global' (value: CoreTypes.GlobalAggregation) =
            AggregationContainer.Global value

        let histogram (value: CoreTypes.HistogramAggregation) =
            AggregationContainer.Histogram value

        let ipRange (value: CoreTypes.IpRangeAggregation) =
            AggregationContainer.IpRange value

        let ipPrefix (value: CoreTypes.IpPrefixAggregation) =
            AggregationContainer.IpPrefix value

        let inference (value: CoreTypes.InferenceAggregation) =
            AggregationContainer.Inference value

        let line (value: CoreTypes.GeoLineAggregation) =
            AggregationContainer.Line value

        let matrixStats (value: CoreTypes.MatrixStatsAggregation) =
            AggregationContainer.MatrixStats value

        let max (value: CoreTypes.MaxAggregation) =
            AggregationContainer.Max value

        let maxBucket (value: CoreTypes.MaxBucketAggregation) =
            AggregationContainer.MaxBucket value

        let medianAbsoluteDeviation (value: CoreTypes.MedianAbsoluteDeviationAggregation) =
            AggregationContainer.MedianAbsoluteDeviation value

        let min (value: CoreTypes.MinAggregation) =
            AggregationContainer.Min value

        let minBucket (value: CoreTypes.MinBucketAggregation) =
            AggregationContainer.MinBucket value

        let missing (value: CoreTypes.MissingAggregation) =
            AggregationContainer.Missing value

        let movingAvg (value: CoreTypes.MovingAverageAggregation) =
            AggregationContainer.MovingAvg value

        let movingPercentiles (value: CoreTypes.MovingPercentilesAggregation) =
            AggregationContainer.MovingPercentiles value

        let movingFn (value: CoreTypes.MovingFunctionAggregation) =
            AggregationContainer.MovingFn value

        let multiTerms (value: CoreTypes.MultiTermsAggregation) =
            AggregationContainer.MultiTerms value

        let nested (value: CoreTypes.NestedAggregation) =
            AggregationContainer.Nested value

        let normalize (value: CoreTypes.NormalizeAggregation) =
            AggregationContainer.Normalize value

        let parent (value: CoreTypes.ParentAggregation) =
            AggregationContainer.Parent value

        let percentileRanks (value: CoreTypes.PercentileRanksAggregation) =
            AggregationContainer.PercentileRanks value

        let percentiles (value: CoreTypes.PercentilesAggregation) =
            AggregationContainer.Percentiles value

        let percentilesBucket (value: CoreTypes.PercentilesBucketAggregation) =
            AggregationContainer.PercentilesBucket value

        let range (value: CoreTypes.RangeAggregation) =
            AggregationContainer.Range value

        let rareTerms (value: CoreTypes.RareTermsAggregation) =
            AggregationContainer.RareTerms value

        let rate (value: CoreTypes.RateAggregation) =
            AggregationContainer.Rate value

        let reverseNested (value: CoreTypes.ReverseNestedAggregation) =
            AggregationContainer.ReverseNested value

        let randomSampler (value: CoreTypes.RandomSamplerAggregation) =
            AggregationContainer.RandomSampler value

        let sampler (value: CoreTypes.SamplerAggregation) =
            AggregationContainer.Sampler value

        let scriptedMetric (value: CoreTypes.ScriptedMetricAggregation) =
            AggregationContainer.ScriptedMetric value

        let serialDiff (value: CoreTypes.SerialDifferencingAggregation) =
            AggregationContainer.SerialDiff value

        let significantTerms (value: CoreTypes.SignificantTermsAggregation) =
            AggregationContainer.SignificantTerms value

        let significantText (value: CoreTypes.SignificantTextAggregation) =
            AggregationContainer.SignificantText value

        let stats (value: CoreTypes.StatsAggregation) =
            AggregationContainer.Stats value

        let statsBucket (value: CoreTypes.StatsBucketAggregation) =
            AggregationContainer.StatsBucket value

        let stringStats (value: CoreTypes.StringStatsAggregation) =
            AggregationContainer.StringStats value

        let sum (value: CoreTypes.SumAggregation) =
            AggregationContainer.Sum value

        let sumBucket (value: CoreTypes.SumBucketAggregation) =
            AggregationContainer.SumBucket value

        let terms (value: CoreTypes.TermsAggregation) =
            AggregationContainer.Terms value

        let timeSeries (value: CoreTypes.TimeSeriesAggregation) =
            AggregationContainer.TimeSeries value

        let topHits (value: CoreTypes.TopHitsAggregation) =
            AggregationContainer.TopHits value

        let tTest (value: CoreTypes.TTestAggregation) =
            AggregationContainer.TTest value

        let topMetrics (value: CoreTypes.TopMetricsAggregation) =
            AggregationContainer.TopMetrics value

        let valueCount (value: CoreTypes.ValueCountAggregation) =
            AggregationContainer.ValueCount value

        let weightedAvg (value: CoreTypes.WeightedAverageAggregation) =
            AggregationContainer.WeightedAvg value

        let variableWidthHistogram (value: CoreTypes.VariableWidthHistogramAggregation) =
            AggregationContainer.VariableWidthHistogram value

    type AggregationRangeBuilder() =
        member _.Yield(_: unit) : AggregationRange =
            {
                From = None
                Key = None
                To = None
            }

        [<CustomOperation("from")>]
        member _.From(state: AggregationRange, value: CoreTypes.Double option) =
            { state with From = Some value }

        [<CustomOperation("key")>]
        member _.Key(state: AggregationRange, value: string) =
            { state with Key = Some value }

        [<CustomOperation("to'")>]
        member _.To(state: AggregationRange, value: CoreTypes.Double option) =
            { state with To = Some value }

    let aggregationRange = AggregationRangeBuilder()

    type AutoDateHistogramAggregationBuilder() =
        member _.Yield(_: unit) : AutoDateHistogramAggregation =
            {
                Buckets = None
                Field = None
                Format = None
                MinimumInterval = None
                Missing = None
                Offset = None
                Params = None
                Script = None
                TimeZone = None
            }

        [<CustomOperation("buckets")>]
        member _.Buckets(state: AutoDateHistogramAggregation, value: CoreTypes.Integer) =
            { state with Buckets = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: AutoDateHistogramAggregation, value: CoreTypes.Field) =
            { state with Field = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: AutoDateHistogramAggregation, value: string) =
            { state with Format = Some value }

        [<CustomOperation("minimumInterval")>]
        member _.MinimumInterval(state: AutoDateHistogramAggregation, value: CoreTypes.MinimumInterval) =
            { state with MinimumInterval = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: AutoDateHistogramAggregation, value: CoreTypes.DateTime) =
            { state with Missing = Some value }

        [<CustomOperation("offset")>]
        member _.Offset(state: AutoDateHistogramAggregation, value: string) =
            { state with Offset = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: AutoDateHistogramAggregation, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: AutoDateHistogramAggregation, value: CoreTypes.Script) =
            { state with Script = Some value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: AutoDateHistogramAggregation, value: CoreTypes.TimeZone) =
            { state with TimeZone = Some value }

    let autoDateHistogramAggregation = AutoDateHistogramAggregationBuilder()

    type BoxPlotAggregateBuilder() =
        member _.Yield(_: unit) : BoxPlotAggregate =
            {
                Min = Unchecked.defaultof<_>
                Max = Unchecked.defaultof<_>
                Q1 = Unchecked.defaultof<_>
                Q2 = Unchecked.defaultof<_>
                Q3 = Unchecked.defaultof<_>
                Lower = Unchecked.defaultof<_>
                Upper = Unchecked.defaultof<_>
                MinAsString = None
                MaxAsString = None
                Q1AsString = None
                Q2AsString = None
                Q3AsString = None
                LowerAsString = None
                UpperAsString = None
            }

        [<CustomOperation("min")>]
        member _.Min(state: BoxPlotAggregate, value: CoreTypes.Double) =
            { state with Min = value }

        [<CustomOperation("max")>]
        member _.Max(state: BoxPlotAggregate, value: CoreTypes.Double) =
            { state with Max = value }

        [<CustomOperation("q1")>]
        member _.Q1(state: BoxPlotAggregate, value: CoreTypes.Double) =
            { state with Q1 = value }

        [<CustomOperation("q2")>]
        member _.Q2(state: BoxPlotAggregate, value: CoreTypes.Double) =
            { state with Q2 = value }

        [<CustomOperation("q3")>]
        member _.Q3(state: BoxPlotAggregate, value: CoreTypes.Double) =
            { state with Q3 = value }

        [<CustomOperation("lower")>]
        member _.Lower(state: BoxPlotAggregate, value: CoreTypes.Double) =
            { state with Lower = value }

        [<CustomOperation("upper")>]
        member _.Upper(state: BoxPlotAggregate, value: CoreTypes.Double) =
            { state with Upper = value }

        [<CustomOperation("minAsString")>]
        member _.MinAsString(state: BoxPlotAggregate, value: string) =
            { state with MinAsString = Some value }

        [<CustomOperation("maxAsString")>]
        member _.MaxAsString(state: BoxPlotAggregate, value: string) =
            { state with MaxAsString = Some value }

        [<CustomOperation("q1AsString")>]
        member _.Q1AsString(state: BoxPlotAggregate, value: string) =
            { state with Q1AsString = Some value }

        [<CustomOperation("q2AsString")>]
        member _.Q2AsString(state: BoxPlotAggregate, value: string) =
            { state with Q2AsString = Some value }

        [<CustomOperation("q3AsString")>]
        member _.Q3AsString(state: BoxPlotAggregate, value: string) =
            { state with Q3AsString = Some value }

        [<CustomOperation("lowerAsString")>]
        member _.LowerAsString(state: BoxPlotAggregate, value: string) =
            { state with LowerAsString = Some value }

        [<CustomOperation("upperAsString")>]
        member _.UpperAsString(state: BoxPlotAggregate, value: string) =
            { state with UpperAsString = Some value }

    let boxPlotAggregate = BoxPlotAggregateBuilder()

    type BoxplotAggregationBuilder() =
        member _.Yield(_: unit) : BoxplotAggregation =
            {
                Compression = None
                ExecutionHint = None
            }

        [<CustomOperation("compression")>]
        member _.Compression(state: BoxplotAggregation, value: CoreTypes.Double) =
            { state with Compression = Some value }

        [<CustomOperation("executionHint")>]
        member _.ExecutionHint(state: BoxplotAggregation, value: CoreTypes.TDigestExecutionHint) =
            { state with ExecutionHint = Some value }

    let boxplotAggregation = BoxplotAggregationBuilder()

    type BucketKsAggregationBuilder() =
        member _.Yield(_: unit) : BucketKsAggregation =
            {
                Alternative = None
                Fractions = None
                SamplingMethod = None
            }

        [<CustomOperation("alternative")>]
        member _.Alternative(state: BucketKsAggregation, value: string list) =
            { state with Alternative = Some value }

        [<CustomOperation("fractions")>]
        member _.Fractions(state: BucketKsAggregation, value: CoreTypes.Double list) =
            { state with Fractions = Some value }

        [<CustomOperation("samplingMethod")>]
        member _.SamplingMethod(state: BucketKsAggregation, value: string) =
            { state with SamplingMethod = Some value }

    let bucketKsAggregation = BucketKsAggregationBuilder()

    type BucketSortAggregationBuilder() =
        member _.Yield(_: unit) : BucketSortAggregation =
            {
                From = None
                GapPolicy = None
                Size = None
                Sort = None
            }

        [<CustomOperation("from")>]
        member _.From(state: BucketSortAggregation, value: CoreTypes.Integer) =
            { state with From = Some value }

        [<CustomOperation("gapPolicy")>]
        member _.GapPolicy(state: BucketSortAggregation, value: CoreTypes.GapPolicy) =
            { state with GapPolicy = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: BucketSortAggregation, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: BucketSortAggregation, value: CoreTypes.Sort) =
            { state with Sort = Some value }

    let bucketSortAggregation = BucketSortAggregationBuilder()

    type CardinalityAggregationBuilder() =
        member _.Yield(_: unit) : CardinalityAggregation =
            {
                PrecisionThreshold = None
                Rehash = None
                ExecutionHint = None
            }

        [<CustomOperation("precisionThreshold")>]
        member _.PrecisionThreshold(state: CardinalityAggregation, value: CoreTypes.Integer) =
            { state with PrecisionThreshold = Some value }

        [<CustomOperation("rehash")>]
        member _.Rehash(state: CardinalityAggregation, value: bool) =
            { state with Rehash = Some value }

        [<CustomOperation("executionHint")>]
        member _.ExecutionHint(state: CardinalityAggregation, value: CoreTypes.CardinalityExecutionMode) =
            { state with ExecutionHint = Some value }

    let cardinalityAggregation = CardinalityAggregationBuilder()

    type CategorizeTextAggregationBuilder() =
        member _.Yield(_: unit) : CategorizeTextAggregation =
            {
                Field = Unchecked.defaultof<_>
                MaxUniqueTokens = None
                MaxMatchedTokens = None
                SimilarityThreshold = None
                CategorizationFilters = None
                CategorizationAnalyzer = None
                ShardSize = None
                Size = None
                MinDocCount = None
                ShardMinDocCount = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: CategorizeTextAggregation, value: CoreTypes.Field) =
            { state with Field = value }

        [<CustomOperation("maxUniqueTokens")>]
        member _.MaxUniqueTokens(state: CategorizeTextAggregation, value: CoreTypes.Integer) =
            { state with MaxUniqueTokens = Some value }

        [<CustomOperation("maxMatchedTokens")>]
        member _.MaxMatchedTokens(state: CategorizeTextAggregation, value: CoreTypes.Integer) =
            { state with MaxMatchedTokens = Some value }

        [<CustomOperation("similarityThreshold")>]
        member _.SimilarityThreshold(state: CategorizeTextAggregation, value: CoreTypes.Integer) =
            { state with SimilarityThreshold = Some value }

        [<CustomOperation("categorizationFilters")>]
        member _.CategorizationFilters(state: CategorizeTextAggregation, value: string list) =
            { state with CategorizationFilters = Some value }

        [<CustomOperation("categorizationAnalyzer")>]
        member _.CategorizationAnalyzer(state: CategorizeTextAggregation, value: CoreTypes.CategorizeTextAnalyzer) =
            { state with CategorizationAnalyzer = Some value }

        [<CustomOperation("shardSize")>]
        member _.ShardSize(state: CategorizeTextAggregation, value: CoreTypes.Integer) =
            { state with ShardSize = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: CategorizeTextAggregation, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("minDocCount")>]
        member _.MinDocCount(state: CategorizeTextAggregation, value: CoreTypes.Integer) =
            { state with MinDocCount = Some value }

        [<CustomOperation("shardMinDocCount")>]
        member _.ShardMinDocCount(state: CategorizeTextAggregation, value: CoreTypes.Integer) =
            { state with ShardMinDocCount = Some value }

    let categorizeTextAggregation = CategorizeTextAggregationBuilder()

    module ChangeType =

        let dip (value: CoreTypes.Dip) =
            ChangeType.Dip value

        let distributionChange (value: CoreTypes.DistributionChange) =
            ChangeType.DistributionChange value

        let indeterminable (value: CoreTypes.Indeterminable) =
            ChangeType.Indeterminable value

        let nonStationary (value: CoreTypes.NonStationary) =
            ChangeType.NonStationary value

        let spike (value: CoreTypes.Spike) =
            ChangeType.Spike value

        let stationary (value: CoreTypes.Stationary) =
            ChangeType.Stationary value

        let stepChange (value: CoreTypes.StepChange) =
            ChangeType.StepChange value

        let trendChange (value: CoreTypes.TrendChange) =
            ChangeType.TrendChange value

    type CompositeAggregationBuilder() =
        member _.Yield(_: unit) : CompositeAggregation =
            {
                After = None
                Size = None
                Sources = None
            }

        [<CustomOperation("after")>]
        member _.After(state: CompositeAggregation, value: CoreTypes.CompositeAggregateKey) =
            { state with After = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: CompositeAggregation, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("sources")>]
        member _.Sources(state: CompositeAggregation, value: Map<string, CoreTypes.CompositeAggregationSource> list) =
            { state with Sources = Some value }

    let compositeAggregation = CompositeAggregationBuilder()

    type CompositeAggregationBaseBuilder() =
        member _.Yield(_: unit) : CompositeAggregationBase =
            {
                Field = None
                MissingBucket = None
                MissingOrder = None
                Script = None
                ValueType = None
                Order = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: CompositeAggregationBase, value: CoreTypes.Field) =
            { state with Field = Some value }

        [<CustomOperation("missingBucket")>]
        member _.MissingBucket(state: CompositeAggregationBase, value: bool) =
            { state with MissingBucket = Some value }

        [<CustomOperation("missingOrder")>]
        member _.MissingOrder(state: CompositeAggregationBase, value: CoreTypes.MissingOrder) =
            { state with MissingOrder = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: CompositeAggregationBase, value: CoreTypes.Script) =
            { state with Script = Some value }

        [<CustomOperation("valueType")>]
        member _.ValueType(state: CompositeAggregationBase, value: CoreTypes.ValueType) =
            { state with ValueType = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: CompositeAggregationBase, value: CoreTypes.SortOrder) =
            { state with Order = Some value }

    let compositeAggregationBase = CompositeAggregationBaseBuilder()

    module CompositeAggregationSource =

        let terms (value: CoreTypes.CompositeTermsAggregation) =
            CompositeAggregationSource.Terms value

        let histogram (value: CoreTypes.CompositeHistogramAggregation) =
            CompositeAggregationSource.Histogram value

        let dateHistogram (value: CoreTypes.CompositeDateHistogramAggregation) =
            CompositeAggregationSource.DateHistogram value

        let geotileGrid (value: CoreTypes.CompositeGeoTileGridAggregation) =
            CompositeAggregationSource.GeotileGrid value

    type CompositeDateHistogramAggregationBuilder() =
        member _.Yield(_: unit) : CompositeDateHistogramAggregation =
            {
                Format = None
                CalendarInterval = None
                FixedInterval = None
                Offset = None
                TimeZone = None
            }

        [<CustomOperation("format")>]
        member _.Format(state: CompositeDateHistogramAggregation, value: string) =
            { state with Format = Some value }

        [<CustomOperation("calendarInterval")>]
        member _.CalendarInterval(state: CompositeDateHistogramAggregation, value: CoreTypes.DurationLarge) =
            { state with CalendarInterval = Some value }

        [<CustomOperation("fixedInterval")>]
        member _.FixedInterval(state: CompositeDateHistogramAggregation, value: CoreTypes.DurationLarge) =
            { state with FixedInterval = Some value }

        [<CustomOperation("offset")>]
        member _.Offset(state: CompositeDateHistogramAggregation, value: CoreTypes.Duration) =
            { state with Offset = Some value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: CompositeDateHistogramAggregation, value: CoreTypes.TimeZone) =
            { state with TimeZone = Some value }

    let compositeDateHistogramAggregation = CompositeDateHistogramAggregationBuilder()

    type CompositeGeoTileGridAggregationBuilder() =
        member _.Yield(_: unit) : CompositeGeoTileGridAggregation =
            {
                Precision = None
                Bounds = None
            }

        [<CustomOperation("precision")>]
        member _.Precision(state: CompositeGeoTileGridAggregation, value: CoreTypes.Integer) =
            { state with Precision = Some value }

        [<CustomOperation("bounds")>]
        member _.Bounds(state: CompositeGeoTileGridAggregation, value: CoreTypes.GeoBounds) =
            { state with Bounds = Some value }

    let compositeGeoTileGridAggregation = CompositeGeoTileGridAggregationBuilder()

    type CustomCategorizeTextAnalyzerBuilder() =
        member _.Yield(_: unit) : CustomCategorizeTextAnalyzer =
            {
                CharFilter = None
                Tokenizer = None
                Filter = None
            }

        [<CustomOperation("charFilter")>]
        member _.CharFilter(state: CustomCategorizeTextAnalyzer, value: string list) =
            { state with CharFilter = Some value }

        [<CustomOperation("tokenizer")>]
        member _.Tokenizer(state: CustomCategorizeTextAnalyzer, value: string) =
            { state with Tokenizer = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: CustomCategorizeTextAnalyzer, value: string list) =
            { state with Filter = Some value }

    let customCategorizeTextAnalyzer = CustomCategorizeTextAnalyzerBuilder()

    type DateHistogramAggregationBuilder() =
        member _.Yield(_: unit) : DateHistogramAggregation =
            {
                CalendarInterval = None
                ExtendedBounds = None
                HardBounds = None
                Field = None
                FixedInterval = None
                Format = None
                Interval = None
                MinDocCount = None
                Missing = None
                Offset = None
                Order = None
                Params = None
                Script = None
                TimeZone = None
                Keyed = None
            }

        [<CustomOperation("calendarInterval")>]
        member _.CalendarInterval(state: DateHistogramAggregation, value: CoreTypes.CalendarInterval) =
            { state with CalendarInterval = Some value }

        [<CustomOperation("extendedBounds")>]
        member _.ExtendedBounds(state: DateHistogramAggregation, value: CoreTypes.ExtendedBounds<CoreTypes.FieldDateMath>) =
            { state with ExtendedBounds = Some value }

        [<CustomOperation("hardBounds")>]
        member _.HardBounds(state: DateHistogramAggregation, value: CoreTypes.ExtendedBounds<CoreTypes.FieldDateMath>) =
            { state with HardBounds = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: DateHistogramAggregation, value: CoreTypes.Field) =
            { state with Field = Some value }

        [<CustomOperation("fixedInterval")>]
        member _.FixedInterval(state: DateHistogramAggregation, value: CoreTypes.Duration) =
            { state with FixedInterval = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: DateHistogramAggregation, value: string) =
            { state with Format = Some value }

        [<CustomOperation("interval")>]
        member _.Interval(state: DateHistogramAggregation, value: CoreTypes.Duration) =
            { state with Interval = Some value }

        [<CustomOperation("minDocCount")>]
        member _.MinDocCount(state: DateHistogramAggregation, value: CoreTypes.Integer) =
            { state with MinDocCount = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: DateHistogramAggregation, value: CoreTypes.DateTime) =
            { state with Missing = Some value }

        [<CustomOperation("offset")>]
        member _.Offset(state: DateHistogramAggregation, value: CoreTypes.Duration) =
            { state with Offset = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: DateHistogramAggregation, value: CoreTypes.AggregateOrder) =
            { state with Order = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: DateHistogramAggregation, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: DateHistogramAggregation, value: CoreTypes.Script) =
            { state with Script = Some value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: DateHistogramAggregation, value: CoreTypes.TimeZone) =
            { state with TimeZone = Some value }

        [<CustomOperation("keyed")>]
        member _.Keyed(state: DateHistogramAggregation, value: bool) =
            { state with Keyed = Some value }

    let dateHistogramAggregation = DateHistogramAggregationBuilder()

    type DateRangeAggregationBuilder() =
        member _.Yield(_: unit) : DateRangeAggregation =
            {
                Field = None
                Format = None
                Missing = None
                Ranges = None
                TimeZone = None
                Keyed = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: DateRangeAggregation, value: CoreTypes.Field) =
            { state with Field = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: DateRangeAggregation, value: string) =
            { state with Format = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: DateRangeAggregation, value: CoreTypes.Missing) =
            { state with Missing = Some value }

        [<CustomOperation("ranges")>]
        member _.Ranges(state: DateRangeAggregation, value: CoreTypes.DateRangeExpression list) =
            { state with Ranges = Some value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: DateRangeAggregation, value: CoreTypes.TimeZone) =
            { state with TimeZone = Some value }

        [<CustomOperation("keyed")>]
        member _.Keyed(state: DateRangeAggregation, value: bool) =
            { state with Keyed = Some value }

    let dateRangeAggregation = DateRangeAggregationBuilder()

    type DateRangeExpressionBuilder() =
        member _.Yield(_: unit) : DateRangeExpression =
            {
                From = None
                Key = None
                To = None
            }

        [<CustomOperation("from")>]
        member _.From(state: DateRangeExpression, value: CoreTypes.FieldDateMath) =
            { state with From = Some value }

        [<CustomOperation("key")>]
        member _.Key(state: DateRangeExpression, value: string) =
            { state with Key = Some value }

        [<CustomOperation("to'")>]
        member _.To(state: DateRangeExpression, value: CoreTypes.FieldDateMath) =
            { state with To = Some value }

    let dateRangeExpression = DateRangeExpressionBuilder()

    type DerivativeAggregateBuilder() =
        member _.Yield(_: unit) : DerivativeAggregate =
            {
                NormalizedValue = None
                NormalizedValueAsString = None
            }

        [<CustomOperation("normalizedValue")>]
        member _.NormalizedValue(state: DerivativeAggregate, value: CoreTypes.Double) =
            { state with NormalizedValue = Some value }

        [<CustomOperation("normalizedValueAsString")>]
        member _.NormalizedValueAsString(state: DerivativeAggregate, value: string) =
            { state with NormalizedValueAsString = Some value }

    let derivativeAggregate = DerivativeAggregateBuilder()

    type DiversifiedSamplerAggregationBuilder() =
        member _.Yield(_: unit) : DiversifiedSamplerAggregation =
            {
                ExecutionHint = None
                MaxDocsPerValue = None
                Script = None
                ShardSize = None
                Field = None
            }

        [<CustomOperation("executionHint")>]
        member _.ExecutionHint(state: DiversifiedSamplerAggregation, value: CoreTypes.SamplerAggregationExecutionHint) =
            { state with ExecutionHint = Some value }

        [<CustomOperation("maxDocsPerValue")>]
        member _.MaxDocsPerValue(state: DiversifiedSamplerAggregation, value: CoreTypes.Integer) =
            { state with MaxDocsPerValue = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: DiversifiedSamplerAggregation, value: CoreTypes.Script) =
            { state with Script = Some value }

        [<CustomOperation("shardSize")>]
        member _.ShardSize(state: DiversifiedSamplerAggregation, value: CoreTypes.Integer) =
            { state with ShardSize = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: DiversifiedSamplerAggregation, value: CoreTypes.Field) =
            { state with Field = Some value }

    let diversifiedSamplerAggregation = DiversifiedSamplerAggregationBuilder()

    type ExtendedBoundsBuilder() =
        member _.Yield(_: unit) : ExtendedBounds =
            {
                Max = None
                Min = None
            }

        [<CustomOperation("max")>]
        member _.Max(state: ExtendedBounds, value: 't) =
            { state with Max = Some value }

        [<CustomOperation("min")>]
        member _.Min(state: ExtendedBounds, value: 't) =
            { state with Min = Some value }

    let extendedBounds = ExtendedBoundsBuilder()

    type ExtendedStatsAggregateBuilder() =
        member _.Yield(_: unit) : ExtendedStatsAggregate =
            {
                SumOfSquares = Unchecked.defaultof<_>
                Variance = Unchecked.defaultof<_>
                VariancePopulation = Unchecked.defaultof<_>
                VarianceSampling = Unchecked.defaultof<_>
                StdDeviation = Unchecked.defaultof<_>
                StdDeviationPopulation = Unchecked.defaultof<_>
                StdDeviationSampling = Unchecked.defaultof<_>
                StdDeviationBounds = None
                SumOfSquaresAsString = None
                VarianceAsString = None
                VariancePopulationAsString = None
                VarianceSamplingAsString = None
                StdDeviationAsString = None
                StdDeviationBoundsAsString = None
            }

        [<CustomOperation("sumOfSquares")>]
        member _.SumOfSquares(state: ExtendedStatsAggregate, value: CoreTypes.Double option) =
            { state with SumOfSquares = value }

        [<CustomOperation("variance")>]
        member _.Variance(state: ExtendedStatsAggregate, value: CoreTypes.Double option) =
            { state with Variance = value }

        [<CustomOperation("variancePopulation")>]
        member _.VariancePopulation(state: ExtendedStatsAggregate, value: CoreTypes.Double option) =
            { state with VariancePopulation = value }

        [<CustomOperation("varianceSampling")>]
        member _.VarianceSampling(state: ExtendedStatsAggregate, value: CoreTypes.Double option) =
            { state with VarianceSampling = value }

        [<CustomOperation("stdDeviation")>]
        member _.StdDeviation(state: ExtendedStatsAggregate, value: CoreTypes.Double option) =
            { state with StdDeviation = value }

        [<CustomOperation("stdDeviationPopulation")>]
        member _.StdDeviationPopulation(state: ExtendedStatsAggregate, value: CoreTypes.Double option) =
            { state with StdDeviationPopulation = value }

        [<CustomOperation("stdDeviationSampling")>]
        member _.StdDeviationSampling(state: ExtendedStatsAggregate, value: CoreTypes.Double option) =
            { state with StdDeviationSampling = value }

        [<CustomOperation("stdDeviationBounds")>]
        member _.StdDeviationBounds(state: ExtendedStatsAggregate, value: CoreTypes.StandardDeviationBounds) =
            { state with StdDeviationBounds = Some value }

        [<CustomOperation("sumOfSquaresAsString")>]
        member _.SumOfSquaresAsString(state: ExtendedStatsAggregate, value: string) =
            { state with SumOfSquaresAsString = Some value }

        [<CustomOperation("varianceAsString")>]
        member _.VarianceAsString(state: ExtendedStatsAggregate, value: string) =
            { state with VarianceAsString = Some value }

        [<CustomOperation("variancePopulationAsString")>]
        member _.VariancePopulationAsString(state: ExtendedStatsAggregate, value: string) =
            { state with VariancePopulationAsString = Some value }

        [<CustomOperation("varianceSamplingAsString")>]
        member _.VarianceSamplingAsString(state: ExtendedStatsAggregate, value: string) =
            { state with VarianceSamplingAsString = Some value }

        [<CustomOperation("stdDeviationAsString")>]
        member _.StdDeviationAsString(state: ExtendedStatsAggregate, value: string) =
            { state with StdDeviationAsString = Some value }

        [<CustomOperation("stdDeviationBoundsAsString")>]
        member _.StdDeviationBoundsAsString(state: ExtendedStatsAggregate, value: CoreTypes.StandardDeviationBoundsAsString) =
            { state with StdDeviationBoundsAsString = Some value }

    let extendedStatsAggregate = ExtendedStatsAggregateBuilder()

    type FiltersAggregationBuilder() =
        member _.Yield(_: unit) : FiltersAggregation =
            {
                Filters = None
                OtherBucket = None
                OtherBucketKey = None
                Keyed = None
            }

        [<CustomOperation("filters")>]
        member _.Filters(state: FiltersAggregation, value: CoreTypes.Buckets<CoreTypes.QueryContainer>) =
            { state with Filters = Some value }

        [<CustomOperation("otherBucket")>]
        member _.OtherBucket(state: FiltersAggregation, value: bool) =
            { state with OtherBucket = Some value }

        [<CustomOperation("otherBucketKey")>]
        member _.OtherBucketKey(state: FiltersAggregation, value: string) =
            { state with OtherBucketKey = Some value }

        [<CustomOperation("keyed")>]
        member _.Keyed(state: FiltersAggregation, value: bool) =
            { state with Keyed = Some value }

    let filtersAggregation = FiltersAggregationBuilder()

    type FrequentItemSetsAggregationBuilder() =
        member _.Yield(_: unit) : FrequentItemSetsAggregation =
            {
                Fields = Unchecked.defaultof<_>
                MinimumSetSize = None
                MinimumSupport = None
                Size = None
                Filter = None
            }

        [<CustomOperation("fields")>]
        member _.Fields(state: FrequentItemSetsAggregation, value: CoreTypes.FrequentItemSetsField list) =
            { state with Fields = value }

        [<CustomOperation("minimumSetSize")>]
        member _.MinimumSetSize(state: FrequentItemSetsAggregation, value: CoreTypes.Integer) =
            { state with MinimumSetSize = Some value }

        [<CustomOperation("minimumSupport")>]
        member _.MinimumSupport(state: FrequentItemSetsAggregation, value: CoreTypes.Double) =
            { state with MinimumSupport = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: FrequentItemSetsAggregation, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: FrequentItemSetsAggregation, value: CoreTypes.QueryContainer) =
            { state with Filter = Some value }

    let frequentItemSetsAggregation = FrequentItemSetsAggregationBuilder()

    type FrequentItemSetsFieldBuilder() =
        member _.Yield(_: unit) : FrequentItemSetsField =
            {
                Field = Unchecked.defaultof<_>
                Exclude = None
                Include = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: FrequentItemSetsField, value: CoreTypes.Field) =
            { state with Field = value }

        [<CustomOperation("exclude")>]
        member _.Exclude(state: FrequentItemSetsField, value: CoreTypes.TermsExclude) =
            { state with Exclude = Some value }

        [<CustomOperation("include")>]
        member _.Include(state: FrequentItemSetsField, value: CoreTypes.TermsInclude) =
            { state with Include = Some value }

    let frequentItemSetsField = FrequentItemSetsFieldBuilder()

    type GeoCentroidAggregationBuilder() =
        member _.Yield(_: unit) : GeoCentroidAggregation =
            {
                Count = None
                Location = None
            }

        [<CustomOperation("count")>]
        member _.Count(state: GeoCentroidAggregation, value: CoreTypes.Long) =
            { state with Count = Some value }

        [<CustomOperation("location")>]
        member _.Location(state: GeoCentroidAggregation, value: CoreTypes.GeoLocation) =
            { state with Location = Some value }

    let geoCentroidAggregation = GeoCentroidAggregationBuilder()

    type GeoDistanceAggregationBuilder() =
        member _.Yield(_: unit) : GeoDistanceAggregation =
            {
                DistanceType = None
                Field = None
                Origin = None
                Ranges = None
                Unit = None
            }

        [<CustomOperation("distanceType")>]
        member _.DistanceType(state: GeoDistanceAggregation, value: CoreTypes.GeoDistanceType) =
            { state with DistanceType = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: GeoDistanceAggregation, value: CoreTypes.Field) =
            { state with Field = Some value }

        [<CustomOperation("origin")>]
        member _.Origin(state: GeoDistanceAggregation, value: CoreTypes.GeoLocation) =
            { state with Origin = Some value }

        [<CustomOperation("ranges")>]
        member _.Ranges(state: GeoDistanceAggregation, value: CoreTypes.AggregationRange list) =
            { state with Ranges = Some value }

        [<CustomOperation("unit")>]
        member _.Unit(state: GeoDistanceAggregation, value: CoreTypes.DistanceUnit) =
            { state with Unit = Some value }

    let geoDistanceAggregation = GeoDistanceAggregationBuilder()

    type GeoHashGridAggregationBuilder() =
        member _.Yield(_: unit) : GeoHashGridAggregation =
            {
                Bounds = None
                Field = None
                Precision = None
                ShardSize = None
                Size = None
            }

        [<CustomOperation("bounds")>]
        member _.Bounds(state: GeoHashGridAggregation, value: CoreTypes.GeoBounds) =
            { state with Bounds = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: GeoHashGridAggregation, value: CoreTypes.Field) =
            { state with Field = Some value }

        [<CustomOperation("precision")>]
        member _.Precision(state: GeoHashGridAggregation, value: CoreTypes.GeoHashPrecision) =
            { state with Precision = Some value }

        [<CustomOperation("shardSize")>]
        member _.ShardSize(state: GeoHashGridAggregation, value: CoreTypes.Integer) =
            { state with ShardSize = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: GeoHashGridAggregation, value: CoreTypes.Integer) =
            { state with Size = Some value }

    let geoHashGridAggregation = GeoHashGridAggregationBuilder()

    type GeoLineAggregationBuilder() =
        member _.Yield(_: unit) : GeoLineAggregation =
            {
                Point = Unchecked.defaultof<_>
                Sort = None
                IncludeSort = None
                SortOrder = None
                Size = None
            }

        [<CustomOperation("point")>]
        member _.Point(state: GeoLineAggregation, value: CoreTypes.GeoLinePoint) =
            { state with Point = value }

        [<CustomOperation("sort")>]
        member _.Sort(state: GeoLineAggregation, value: CoreTypes.GeoLineSort) =
            { state with Sort = Some value }

        [<CustomOperation("includeSort")>]
        member _.IncludeSort(state: GeoLineAggregation, value: bool) =
            { state with IncludeSort = Some value }

        [<CustomOperation("sortOrder")>]
        member _.SortOrder(state: GeoLineAggregation, value: CoreTypes.SortOrder) =
            { state with SortOrder = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: GeoLineAggregation, value: CoreTypes.Integer) =
            { state with Size = Some value }

    let geoLineAggregation = GeoLineAggregationBuilder()

    type GeoTileGridAggregationBuilder() =
        member _.Yield(_: unit) : GeoTileGridAggregation =
            {
                Field = None
                Precision = None
                ShardSize = None
                Size = None
                Bounds = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: GeoTileGridAggregation, value: CoreTypes.Field) =
            { state with Field = Some value }

        [<CustomOperation("precision")>]
        member _.Precision(state: GeoTileGridAggregation, value: CoreTypes.GeoTilePrecision) =
            { state with Precision = Some value }

        [<CustomOperation("shardSize")>]
        member _.ShardSize(state: GeoTileGridAggregation, value: CoreTypes.Integer) =
            { state with ShardSize = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: GeoTileGridAggregation, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("bounds")>]
        member _.Bounds(state: GeoTileGridAggregation, value: CoreTypes.GeoBounds) =
            { state with Bounds = Some value }

    let geoTileGridAggregation = GeoTileGridAggregationBuilder()

    type GeohexGridAggregationBuilder() =
        member _.Yield(_: unit) : GeohexGridAggregation =
            {
                Field = Unchecked.defaultof<_>
                Precision = None
                Bounds = None
                Size = None
                ShardSize = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: GeohexGridAggregation, value: CoreTypes.Field) =
            { state with Field = value }

        [<CustomOperation("precision")>]
        member _.Precision(state: GeohexGridAggregation, value: CoreTypes.Integer) =
            { state with Precision = Some value }

        [<CustomOperation("bounds")>]
        member _.Bounds(state: GeohexGridAggregation, value: CoreTypes.GeoBounds) =
            { state with Bounds = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: GeohexGridAggregation, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("shardSize")>]
        member _.ShardSize(state: GeohexGridAggregation, value: CoreTypes.Integer) =
            { state with ShardSize = Some value }

    let geohexGridAggregation = GeohexGridAggregationBuilder()

    type HistogramAggregationBuilder() =
        member _.Yield(_: unit) : HistogramAggregation =
            {
                ExtendedBounds = None
                HardBounds = None
                Field = None
                Interval = None
                MinDocCount = None
                Missing = None
                Offset = None
                Order = None
                Script = None
                Format = None
                Keyed = None
            }

        [<CustomOperation("extendedBounds")>]
        member _.ExtendedBounds(state: HistogramAggregation, value: CoreTypes.ExtendedBounds<CoreTypes.Double>) =
            { state with ExtendedBounds = Some value }

        [<CustomOperation("hardBounds")>]
        member _.HardBounds(state: HistogramAggregation, value: CoreTypes.ExtendedBounds<CoreTypes.Double>) =
            { state with HardBounds = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: HistogramAggregation, value: CoreTypes.Field) =
            { state with Field = Some value }

        [<CustomOperation("interval")>]
        member _.Interval(state: HistogramAggregation, value: CoreTypes.Double) =
            { state with Interval = Some value }

        [<CustomOperation("minDocCount")>]
        member _.MinDocCount(state: HistogramAggregation, value: CoreTypes.Integer) =
            { state with MinDocCount = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: HistogramAggregation, value: CoreTypes.Double) =
            { state with Missing = Some value }

        [<CustomOperation("offset")>]
        member _.Offset(state: HistogramAggregation, value: CoreTypes.Double) =
            { state with Offset = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: HistogramAggregation, value: CoreTypes.AggregateOrder) =
            { state with Order = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: HistogramAggregation, value: CoreTypes.Script) =
            { state with Script = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: HistogramAggregation, value: string) =
            { state with Format = Some value }

        [<CustomOperation("keyed")>]
        member _.Keyed(state: HistogramAggregation, value: bool) =
            { state with Keyed = Some value }

    let histogramAggregation = HistogramAggregationBuilder()

    type HoltLinearModelSettingsBuilder() =
        member _.Yield(_: unit) : HoltLinearModelSettings =
            {
                Alpha = None
                Beta = None
            }

        [<CustomOperation("alpha")>]
        member _.Alpha(state: HoltLinearModelSettings, value: CoreTypes.Float) =
            { state with Alpha = Some value }

        [<CustomOperation("beta")>]
        member _.Beta(state: HoltLinearModelSettings, value: CoreTypes.Float) =
            { state with Beta = Some value }

    let holtLinearModelSettings = HoltLinearModelSettingsBuilder()

    type HoltWintersModelSettingsBuilder() =
        member _.Yield(_: unit) : HoltWintersModelSettings =
            {
                Alpha = None
                Beta = None
                Gamma = None
                Pad = None
                Period = None
                Type = None
            }

        [<CustomOperation("alpha")>]
        member _.Alpha(state: HoltWintersModelSettings, value: CoreTypes.Float) =
            { state with Alpha = Some value }

        [<CustomOperation("beta")>]
        member _.Beta(state: HoltWintersModelSettings, value: CoreTypes.Float) =
            { state with Beta = Some value }

        [<CustomOperation("gamma")>]
        member _.Gamma(state: HoltWintersModelSettings, value: CoreTypes.Float) =
            { state with Gamma = Some value }

        [<CustomOperation("pad")>]
        member _.Pad(state: HoltWintersModelSettings, value: bool) =
            { state with Pad = Some value }

        [<CustomOperation("period")>]
        member _.Period(state: HoltWintersModelSettings, value: CoreTypes.Integer) =
            { state with Period = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: HoltWintersModelSettings, value: CoreTypes.HoltWintersType) =
            { state with Type = Some value }

    let holtWintersModelSettings = HoltWintersModelSettingsBuilder()

    type InferenceAggregateBuilder() =
        member _.Yield(_: unit) : InferenceAggregate =
            {
                Value = None
                FeatureImportance = None
                TopClasses = None
                Warning = None
            }

        [<CustomOperation("value")>]
        member _.Value(state: InferenceAggregate, value: CoreTypes.FieldValue) =
            { state with Value = Some value }

        [<CustomOperation("featureImportance")>]
        member _.FeatureImportance(state: InferenceAggregate, value: CoreTypes.InferenceFeatureImportance list) =
            { state with FeatureImportance = Some value }

        [<CustomOperation("topClasses")>]
        member _.TopClasses(state: InferenceAggregate, value: CoreTypes.InferenceTopClassEntry list) =
            { state with TopClasses = Some value }

        [<CustomOperation("warning")>]
        member _.Warning(state: InferenceAggregate, value: string) =
            { state with Warning = Some value }

    let inferenceAggregate = InferenceAggregateBuilder()

    module InferenceConfig =

        let regression (value: MlTypes.RegressionInferenceOptions) =
            InferenceConfigContainer.Regression value

        let classification (value: MlTypes.ClassificationInferenceOptions) =
            InferenceConfigContainer.Classification value

    type InferenceFeatureImportanceBuilder() =
        member _.Yield(_: unit) : InferenceFeatureImportance =
            {
                FeatureName = Unchecked.defaultof<_>
                Importance = None
                Classes = None
            }

        [<CustomOperation("featureName")>]
        member _.FeatureName(state: InferenceFeatureImportance, value: string) =
            { state with FeatureName = value }

        [<CustomOperation("importance")>]
        member _.Importance(state: InferenceFeatureImportance, value: CoreTypes.Double) =
            { state with Importance = Some value }

        [<CustomOperation("classes")>]
        member _.Classes(state: InferenceFeatureImportance, value: CoreTypes.InferenceClassImportance list) =
            { state with Classes = Some value }

    let inferenceFeatureImportance = InferenceFeatureImportanceBuilder()

    type IpPrefixAggregationBuilder() =
        member _.Yield(_: unit) : IpPrefixAggregation =
            {
                Field = Unchecked.defaultof<_>
                PrefixLength = Unchecked.defaultof<_>
                IsIpv6 = None
                AppendPrefixLength = None
                Keyed = None
                MinDocCount = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: IpPrefixAggregation, value: CoreTypes.Field) =
            { state with Field = value }

        [<CustomOperation("prefixLength")>]
        member _.PrefixLength(state: IpPrefixAggregation, value: CoreTypes.Integer) =
            { state with PrefixLength = value }

        [<CustomOperation("isIpv6")>]
        member _.IsIpv6(state: IpPrefixAggregation, value: bool) =
            { state with IsIpv6 = Some value }

        [<CustomOperation("appendPrefixLength")>]
        member _.AppendPrefixLength(state: IpPrefixAggregation, value: bool) =
            { state with AppendPrefixLength = Some value }

        [<CustomOperation("keyed")>]
        member _.Keyed(state: IpPrefixAggregation, value: bool) =
            { state with Keyed = Some value }

        [<CustomOperation("minDocCount")>]
        member _.MinDocCount(state: IpPrefixAggregation, value: CoreTypes.Long) =
            { state with MinDocCount = Some value }

    let ipPrefixAggregation = IpPrefixAggregationBuilder()

    type IpRangeAggregationBuilder() =
        member _.Yield(_: unit) : IpRangeAggregation =
            {
                Field = None
                Ranges = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: IpRangeAggregation, value: CoreTypes.Field) =
            { state with Field = Some value }

        [<CustomOperation("ranges")>]
        member _.Ranges(state: IpRangeAggregation, value: CoreTypes.IpRangeAggregationRange list) =
            { state with Ranges = Some value }

    let ipRangeAggregation = IpRangeAggregationBuilder()

    type IpRangeAggregationRangeBuilder() =
        member _.Yield(_: unit) : IpRangeAggregationRange =
            {
                From = None
                Mask = None
                To = None
            }

        [<CustomOperation("from")>]
        member _.From(state: IpRangeAggregationRange, value: string option) =
            { state with From = Some value }

        [<CustomOperation("mask")>]
        member _.Mask(state: IpRangeAggregationRange, value: string) =
            { state with Mask = Some value }

        [<CustomOperation("to'")>]
        member _.To(state: IpRangeAggregationRange, value: string option) =
            { state with To = Some value }

    let ipRangeAggregationRange = IpRangeAggregationRangeBuilder()

    type IpRangeBucketBuilder() =
        member _.Yield(_: unit) : IpRangeBucket =
            {
                Key = None
                From = None
                To = None
            }

        [<CustomOperation("key")>]
        member _.Key(state: IpRangeBucket, value: string) =
            { state with Key = Some value }

        [<CustomOperation("from")>]
        member _.From(state: IpRangeBucket, value: string) =
            { state with From = Some value }

        [<CustomOperation("to'")>]
        member _.To(state: IpRangeBucket, value: string) =
            { state with To = Some value }

    let ipRangeBucket = IpRangeBucketBuilder()

    type MatrixAggregationBuilder() =
        member _.Yield(_: unit) : MatrixAggregation =
            {
                Fields = None
                Missing = None
            }

        [<CustomOperation("fields")>]
        member _.Fields(state: MatrixAggregation, value: CoreTypes.Fields) =
            { state with Fields = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: MatrixAggregation, value: Map<CoreTypes.Field, CoreTypes.Double>) =
            { state with Missing = Some value }

    let matrixAggregation = MatrixAggregationBuilder()

    type MedianAbsoluteDeviationAggregationBuilder() =
        member _.Yield(_: unit) : MedianAbsoluteDeviationAggregation =
            {
                Compression = None
                ExecutionHint = None
            }

        [<CustomOperation("compression")>]
        member _.Compression(state: MedianAbsoluteDeviationAggregation, value: CoreTypes.Double) =
            { state with Compression = Some value }

        [<CustomOperation("executionHint")>]
        member _.ExecutionHint(state: MedianAbsoluteDeviationAggregation, value: CoreTypes.TDigestExecutionHint) =
            { state with ExecutionHint = Some value }

    let medianAbsoluteDeviationAggregation = MedianAbsoluteDeviationAggregationBuilder()

    type MetricAggregationBaseBuilder() =
        member _.Yield(_: unit) : MetricAggregationBase =
            {
                Field = None
                Missing = None
                Script = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: MetricAggregationBase, value: CoreTypes.Field) =
            { state with Field = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: MetricAggregationBase, value: CoreTypes.Missing) =
            { state with Missing = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: MetricAggregationBase, value: CoreTypes.Script) =
            { state with Script = Some value }

    let metricAggregationBase = MetricAggregationBaseBuilder()

    type MissingAggregationBuilder() =
        member _.Yield(_: unit) : MissingAggregation =
            {
                Field = None
                Missing = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: MissingAggregation, value: CoreTypes.Field) =
            { state with Field = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: MissingAggregation, value: CoreTypes.Missing) =
            { state with Missing = Some value }

    let missingAggregation = MissingAggregationBuilder()

    type MovingAverageAggregationBaseBuilder() =
        member _.Yield(_: unit) : MovingAverageAggregationBase =
            {
                Minimize = None
                Predict = None
                Window = None
            }

        [<CustomOperation("minimize")>]
        member _.Minimize(state: MovingAverageAggregationBase, value: bool) =
            { state with Minimize = Some value }

        [<CustomOperation("predict")>]
        member _.Predict(state: MovingAverageAggregationBase, value: CoreTypes.Integer) =
            { state with Predict = Some value }

        [<CustomOperation("window")>]
        member _.Window(state: MovingAverageAggregationBase, value: CoreTypes.Integer) =
            { state with Window = Some value }

    let movingAverageAggregationBase = MovingAverageAggregationBaseBuilder()

    type MovingFunctionAggregationBuilder() =
        member _.Yield(_: unit) : MovingFunctionAggregation =
            {
                Script = None
                Shift = None
                Window = None
            }

        [<CustomOperation("script")>]
        member _.Script(state: MovingFunctionAggregation, value: string) =
            { state with Script = Some value }

        [<CustomOperation("shift")>]
        member _.Shift(state: MovingFunctionAggregation, value: CoreTypes.Integer) =
            { state with Shift = Some value }

        [<CustomOperation("window")>]
        member _.Window(state: MovingFunctionAggregation, value: CoreTypes.Integer) =
            { state with Window = Some value }

    let movingFunctionAggregation = MovingFunctionAggregationBuilder()

    type MovingPercentilesAggregationBuilder() =
        member _.Yield(_: unit) : MovingPercentilesAggregation =
            {
                Window = None
                Shift = None
                Keyed = None
            }

        [<CustomOperation("window")>]
        member _.Window(state: MovingPercentilesAggregation, value: CoreTypes.Integer) =
            { state with Window = Some value }

        [<CustomOperation("shift")>]
        member _.Shift(state: MovingPercentilesAggregation, value: CoreTypes.Integer) =
            { state with Shift = Some value }

        [<CustomOperation("keyed")>]
        member _.Keyed(state: MovingPercentilesAggregation, value: bool) =
            { state with Keyed = Some value }

    let movingPercentilesAggregation = MovingPercentilesAggregationBuilder()

    module MultiTermLookup =

        let field (value: CoreTypes.Field) =
            MultiTermLookup.Field value

        let script (value: CoreTypes.Script) =
            MultiTermLookup.Script value

    type MultiTermsAggregationBuilder() =
        member _.Yield(_: unit) : MultiTermsAggregation =
            {
                CollectMode = None
                Order = None
                MinDocCount = None
                ShardMinDocCount = None
                ShardSize = None
                ShowTermDocCountError = None
                Size = None
                Terms = Unchecked.defaultof<_>
            }

        [<CustomOperation("collectMode")>]
        member _.CollectMode(state: MultiTermsAggregation, value: CoreTypes.TermsAggregationCollectMode) =
            { state with CollectMode = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: MultiTermsAggregation, value: CoreTypes.AggregateOrder) =
            { state with Order = Some value }

        [<CustomOperation("minDocCount")>]
        member _.MinDocCount(state: MultiTermsAggregation, value: CoreTypes.Long) =
            { state with MinDocCount = Some value }

        [<CustomOperation("shardMinDocCount")>]
        member _.ShardMinDocCount(state: MultiTermsAggregation, value: CoreTypes.Long) =
            { state with ShardMinDocCount = Some value }

        [<CustomOperation("shardSize")>]
        member _.ShardSize(state: MultiTermsAggregation, value: CoreTypes.Integer) =
            { state with ShardSize = Some value }

        [<CustomOperation("showTermDocCountError")>]
        member _.ShowTermDocCountError(state: MultiTermsAggregation, value: bool) =
            { state with ShowTermDocCountError = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: MultiTermsAggregation, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("terms")>]
        member _.Terms(state: MultiTermsAggregation, value: CoreTypes.MultiTermLookup list) =
            { state with Terms = value }

    let multiTermsAggregation = MultiTermsAggregationBuilder()

    type MultiTermsBucketBuilder() =
        member _.Yield(_: unit) : MultiTermsBucket =
            {
                Key = Unchecked.defaultof<_>
                KeyAsString = None
                DocCountErrorUpperBound = None
            }

        [<CustomOperation("key")>]
        member _.Key(state: MultiTermsBucket, value: CoreTypes.FieldValue list) =
            { state with Key = value }

        [<CustomOperation("keyAsString")>]
        member _.KeyAsString(state: MultiTermsBucket, value: string) =
            { state with KeyAsString = Some value }

        [<CustomOperation("docCountErrorUpperBound")>]
        member _.DocCountErrorUpperBound(state: MultiTermsBucket, value: CoreTypes.Long) =
            { state with DocCountErrorUpperBound = Some value }

    let multiTermsBucket = MultiTermsBucketBuilder()

    type MutualInformationHeuristicBuilder() =
        member _.Yield(_: unit) : MutualInformationHeuristic =
            {
                BackgroundIsSuperset = None
                IncludeNegatives = None
            }

        [<CustomOperation("backgroundIsSuperset")>]
        member _.BackgroundIsSuperset(state: MutualInformationHeuristic, value: bool) =
            { state with BackgroundIsSuperset = Some value }

        [<CustomOperation("includeNegatives")>]
        member _.IncludeNegatives(state: MutualInformationHeuristic, value: bool) =
            { state with IncludeNegatives = Some value }

    let mutualInformationHeuristic = MutualInformationHeuristicBuilder()

    type PValueHeuristicBuilder() =
        member _.Yield(_: unit) : PValueHeuristic =
            {
                BackgroundIsSuperset = None
                NormalizeAbove = None
            }

        [<CustomOperation("backgroundIsSuperset")>]
        member _.BackgroundIsSuperset(state: PValueHeuristic, value: bool) =
            { state with BackgroundIsSuperset = Some value }

        [<CustomOperation("normalizeAbove")>]
        member _.NormalizeAbove(state: PValueHeuristic, value: CoreTypes.Long) =
            { state with NormalizeAbove = Some value }

    let pValueHeuristic = PValueHeuristicBuilder()

    type PercentileRanksAggregationBuilder() =
        member _.Yield(_: unit) : PercentileRanksAggregation =
            {
                Keyed = None
                Values = None
                Hdr = None
                Tdigest = None
            }

        [<CustomOperation("keyed")>]
        member _.Keyed(state: PercentileRanksAggregation, value: bool) =
            { state with Keyed = Some value }

        [<CustomOperation("values")>]
        member _.Values(state: PercentileRanksAggregation, value: CoreTypes.Double list option) =
            { state with Values = Some value }

        [<CustomOperation("hdr")>]
        member _.Hdr(state: PercentileRanksAggregation, value: CoreTypes.HdrMethod) =
            { state with Hdr = Some value }

        [<CustomOperation("tdigest")>]
        member _.Tdigest(state: PercentileRanksAggregation, value: CoreTypes.TDigest) =
            { state with Tdigest = Some value }

    let percentileRanksAggregation = PercentileRanksAggregationBuilder()

    type PercentilesAggregationBuilder() =
        member _.Yield(_: unit) : PercentilesAggregation =
            {
                Keyed = None
                Percents = None
                Hdr = None
                Tdigest = None
            }

        [<CustomOperation("keyed")>]
        member _.Keyed(state: PercentilesAggregation, value: bool) =
            { state with Keyed = Some value }

        [<CustomOperation("percents")>]
        member _.Percents(state: PercentilesAggregation, value: System.Text.Json.JsonElement) =
            { state with Percents = Some value }

        [<CustomOperation("hdr")>]
        member _.Hdr(state: PercentilesAggregation, value: CoreTypes.HdrMethod) =
            { state with Hdr = Some value }

        [<CustomOperation("tdigest")>]
        member _.Tdigest(state: PercentilesAggregation, value: CoreTypes.TDigest) =
            { state with Tdigest = Some value }

    let percentilesAggregation = PercentilesAggregationBuilder()

    type PipelineAggregationBaseBuilder() =
        member _.Yield(_: unit) : PipelineAggregationBase =
            {
                Format = None
                GapPolicy = None
            }

        [<CustomOperation("format")>]
        member _.Format(state: PipelineAggregationBase, value: string) =
            { state with Format = Some value }

        [<CustomOperation("gapPolicy")>]
        member _.GapPolicy(state: PipelineAggregationBase, value: CoreTypes.GapPolicy) =
            { state with GapPolicy = Some value }

    let pipelineAggregationBase = PipelineAggregationBaseBuilder()

    type RandomSamplerAggregationBuilder() =
        member _.Yield(_: unit) : RandomSamplerAggregation =
            {
                Probability = Unchecked.defaultof<_>
                Seed = None
                ShardSeed = None
            }

        [<CustomOperation("probability")>]
        member _.Probability(state: RandomSamplerAggregation, value: CoreTypes.Double) =
            { state with Probability = value }

        [<CustomOperation("seed")>]
        member _.Seed(state: RandomSamplerAggregation, value: CoreTypes.Integer) =
            { state with Seed = Some value }

        [<CustomOperation("shardSeed")>]
        member _.ShardSeed(state: RandomSamplerAggregation, value: CoreTypes.Integer) =
            { state with ShardSeed = Some value }

    let randomSamplerAggregation = RandomSamplerAggregationBuilder()

    type RangeAggregationBuilder() =
        member _.Yield(_: unit) : RangeAggregation =
            {
                Field = None
                Missing = None
                Ranges = None
                Script = None
                Keyed = None
                Format = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: RangeAggregation, value: CoreTypes.Field) =
            { state with Field = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: RangeAggregation, value: CoreTypes.Integer) =
            { state with Missing = Some value }

        [<CustomOperation("ranges")>]
        member _.Ranges(state: RangeAggregation, value: CoreTypes.AggregationRange list) =
            { state with Ranges = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: RangeAggregation, value: CoreTypes.Script) =
            { state with Script = Some value }

        [<CustomOperation("keyed")>]
        member _.Keyed(state: RangeAggregation, value: bool) =
            { state with Keyed = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: RangeAggregation, value: string) =
            { state with Format = Some value }

    let rangeAggregation = RangeAggregationBuilder()

    type RangeBucketBuilder() =
        member _.Yield(_: unit) : RangeBucket =
            {
                From = None
                To = None
                FromAsString = None
                ToAsString = None
                Key = None
            }

        [<CustomOperation("from")>]
        member _.From(state: RangeBucket, value: CoreTypes.Double) =
            { state with From = Some value }

        [<CustomOperation("to'")>]
        member _.To(state: RangeBucket, value: CoreTypes.Double) =
            { state with To = Some value }

        [<CustomOperation("fromAsString")>]
        member _.FromAsString(state: RangeBucket, value: string) =
            { state with FromAsString = Some value }

        [<CustomOperation("toAsString")>]
        member _.ToAsString(state: RangeBucket, value: string) =
            { state with ToAsString = Some value }

        [<CustomOperation("key")>]
        member _.Key(state: RangeBucket, value: string) =
            { state with Key = Some value }

    let rangeBucket = RangeBucketBuilder()

    type RareTermsAggregationBuilder() =
        member _.Yield(_: unit) : RareTermsAggregation =
            {
                Exclude = None
                Field = None
                Include = None
                MaxDocCount = None
                Missing = None
                Precision = None
                ValueType = None
            }

        [<CustomOperation("exclude")>]
        member _.Exclude(state: RareTermsAggregation, value: CoreTypes.TermsExclude) =
            { state with Exclude = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: RareTermsAggregation, value: CoreTypes.Field) =
            { state with Field = Some value }

        [<CustomOperation("include")>]
        member _.Include(state: RareTermsAggregation, value: CoreTypes.TermsInclude) =
            { state with Include = Some value }

        [<CustomOperation("maxDocCount")>]
        member _.MaxDocCount(state: RareTermsAggregation, value: CoreTypes.Long) =
            { state with MaxDocCount = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: RareTermsAggregation, value: CoreTypes.Missing) =
            { state with Missing = Some value }

        [<CustomOperation("precision")>]
        member _.Precision(state: RareTermsAggregation, value: CoreTypes.Double) =
            { state with Precision = Some value }

        [<CustomOperation("valueType")>]
        member _.ValueType(state: RareTermsAggregation, value: string) =
            { state with ValueType = Some value }

    let rareTermsAggregation = RareTermsAggregationBuilder()

    type RateAggregationBuilder() =
        member _.Yield(_: unit) : RateAggregation =
            {
                Unit = None
                Mode = None
            }

        [<CustomOperation("unit")>]
        member _.Unit(state: RateAggregation, value: CoreTypes.CalendarInterval) =
            { state with Unit = Some value }

        [<CustomOperation("mode")>]
        member _.Mode(state: RateAggregation, value: CoreTypes.RateMode) =
            { state with Mode = Some value }

    let rateAggregation = RateAggregationBuilder()

    type ScriptedMetricAggregationBuilder() =
        member _.Yield(_: unit) : ScriptedMetricAggregation =
            {
                CombineScript = None
                InitScript = None
                MapScript = None
                Params = None
                ReduceScript = None
            }

        [<CustomOperation("combineScript")>]
        member _.CombineScript(state: ScriptedMetricAggregation, value: CoreTypes.Script) =
            { state with CombineScript = Some value }

        [<CustomOperation("initScript")>]
        member _.InitScript(state: ScriptedMetricAggregation, value: CoreTypes.Script) =
            { state with InitScript = Some value }

        [<CustomOperation("mapScript")>]
        member _.MapScript(state: ScriptedMetricAggregation, value: CoreTypes.Script) =
            { state with MapScript = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: ScriptedMetricAggregation, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("reduceScript")>]
        member _.ReduceScript(state: ScriptedMetricAggregation, value: CoreTypes.Script) =
            { state with ReduceScript = Some value }

    let scriptedMetricAggregation = ScriptedMetricAggregationBuilder()

    type SignificantTermsAggregateBaseBuilder() =
        member _.Yield(_: unit) : SignificantTermsAggregateBase =
            {
                BgCount = None
                DocCount = None
            }

        [<CustomOperation("bgCount")>]
        member _.BgCount(state: SignificantTermsAggregateBase, value: CoreTypes.Long) =
            { state with BgCount = Some value }

        [<CustomOperation("docCount")>]
        member _.DocCount(state: SignificantTermsAggregateBase, value: CoreTypes.Long) =
            { state with DocCount = Some value }

    let significantTermsAggregateBase = SignificantTermsAggregateBaseBuilder()

    type SignificantTermsAggregationBuilder() =
        member _.Yield(_: unit) : SignificantTermsAggregation =
            {
                BackgroundFilter = None
                ChiSquare = None
                Exclude = None
                ExecutionHint = None
                Field = None
                Gnd = None
                Include = None
                Jlh = None
                MinDocCount = None
                MutualInformation = None
                Percentage = None
                ScriptHeuristic = None
                PValue = None
                ShardMinDocCount = None
                ShardSize = None
                Size = None
            }

        [<CustomOperation("backgroundFilter")>]
        member _.BackgroundFilter(state: SignificantTermsAggregation, value: CoreTypes.QueryContainer) =
            { state with BackgroundFilter = Some value }

        [<CustomOperation("chiSquare")>]
        member _.ChiSquare(state: SignificantTermsAggregation, value: CoreTypes.ChiSquareHeuristic) =
            { state with ChiSquare = Some value }

        [<CustomOperation("exclude")>]
        member _.Exclude(state: SignificantTermsAggregation, value: CoreTypes.TermsExclude) =
            { state with Exclude = Some value }

        [<CustomOperation("executionHint")>]
        member _.ExecutionHint(state: SignificantTermsAggregation, value: CoreTypes.TermsAggregationExecutionHint) =
            { state with ExecutionHint = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: SignificantTermsAggregation, value: CoreTypes.Field) =
            { state with Field = Some value }

        [<CustomOperation("gnd")>]
        member _.Gnd(state: SignificantTermsAggregation, value: CoreTypes.GoogleNormalizedDistanceHeuristic) =
            { state with Gnd = Some value }

        [<CustomOperation("include")>]
        member _.Include(state: SignificantTermsAggregation, value: CoreTypes.TermsInclude) =
            { state with Include = Some value }

        [<CustomOperation("jlh")>]
        member _.Jlh(state: SignificantTermsAggregation, value: CoreTypes.EmptyObject) =
            { state with Jlh = Some value }

        [<CustomOperation("minDocCount")>]
        member _.MinDocCount(state: SignificantTermsAggregation, value: CoreTypes.Long) =
            { state with MinDocCount = Some value }

        [<CustomOperation("mutualInformation")>]
        member _.MutualInformation(state: SignificantTermsAggregation, value: CoreTypes.MutualInformationHeuristic) =
            { state with MutualInformation = Some value }

        [<CustomOperation("percentage")>]
        member _.Percentage(state: SignificantTermsAggregation, value: CoreTypes.PercentageScoreHeuristic) =
            { state with Percentage = Some value }

        [<CustomOperation("scriptHeuristic")>]
        member _.ScriptHeuristic(state: SignificantTermsAggregation, value: CoreTypes.ScriptedHeuristic) =
            { state with ScriptHeuristic = Some value }

        [<CustomOperation("pValue")>]
        member _.PValue(state: SignificantTermsAggregation, value: CoreTypes.PValueHeuristic) =
            { state with PValue = Some value }

        [<CustomOperation("shardMinDocCount")>]
        member _.ShardMinDocCount(state: SignificantTermsAggregation, value: CoreTypes.Long) =
            { state with ShardMinDocCount = Some value }

        [<CustomOperation("shardSize")>]
        member _.ShardSize(state: SignificantTermsAggregation, value: CoreTypes.Integer) =
            { state with ShardSize = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: SignificantTermsAggregation, value: CoreTypes.Integer) =
            { state with Size = Some value }

    let significantTermsAggregation = SignificantTermsAggregationBuilder()

    type SignificantTextAggregationBuilder() =
        member _.Yield(_: unit) : SignificantTextAggregation =
            {
                BackgroundFilter = None
                ChiSquare = None
                Exclude = None
                ExecutionHint = None
                Field = None
                FilterDuplicateText = None
                Gnd = None
                Include = None
                Jlh = None
                MinDocCount = None
                MutualInformation = None
                Percentage = None
                ScriptHeuristic = None
                ShardMinDocCount = None
                ShardSize = None
                Size = None
                SourceFields = None
            }

        [<CustomOperation("backgroundFilter")>]
        member _.BackgroundFilter(state: SignificantTextAggregation, value: CoreTypes.QueryContainer) =
            { state with BackgroundFilter = Some value }

        [<CustomOperation("chiSquare")>]
        member _.ChiSquare(state: SignificantTextAggregation, value: CoreTypes.ChiSquareHeuristic) =
            { state with ChiSquare = Some value }

        [<CustomOperation("exclude")>]
        member _.Exclude(state: SignificantTextAggregation, value: CoreTypes.TermsExclude) =
            { state with Exclude = Some value }

        [<CustomOperation("executionHint")>]
        member _.ExecutionHint(state: SignificantTextAggregation, value: CoreTypes.TermsAggregationExecutionHint) =
            { state with ExecutionHint = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: SignificantTextAggregation, value: CoreTypes.Field) =
            { state with Field = Some value }

        [<CustomOperation("filterDuplicateText")>]
        member _.FilterDuplicateText(state: SignificantTextAggregation, value: bool) =
            { state with FilterDuplicateText = Some value }

        [<CustomOperation("gnd")>]
        member _.Gnd(state: SignificantTextAggregation, value: CoreTypes.GoogleNormalizedDistanceHeuristic) =
            { state with Gnd = Some value }

        [<CustomOperation("include")>]
        member _.Include(state: SignificantTextAggregation, value: CoreTypes.TermsInclude) =
            { state with Include = Some value }

        [<CustomOperation("jlh")>]
        member _.Jlh(state: SignificantTextAggregation, value: CoreTypes.EmptyObject) =
            { state with Jlh = Some value }

        [<CustomOperation("minDocCount")>]
        member _.MinDocCount(state: SignificantTextAggregation, value: CoreTypes.Long) =
            { state with MinDocCount = Some value }

        [<CustomOperation("mutualInformation")>]
        member _.MutualInformation(state: SignificantTextAggregation, value: CoreTypes.MutualInformationHeuristic) =
            { state with MutualInformation = Some value }

        [<CustomOperation("percentage")>]
        member _.Percentage(state: SignificantTextAggregation, value: CoreTypes.PercentageScoreHeuristic) =
            { state with Percentage = Some value }

        [<CustomOperation("scriptHeuristic")>]
        member _.ScriptHeuristic(state: SignificantTextAggregation, value: CoreTypes.ScriptedHeuristic) =
            { state with ScriptHeuristic = Some value }

        [<CustomOperation("shardMinDocCount")>]
        member _.ShardMinDocCount(state: SignificantTextAggregation, value: CoreTypes.Long) =
            { state with ShardMinDocCount = Some value }

        [<CustomOperation("shardSize")>]
        member _.ShardSize(state: SignificantTextAggregation, value: CoreTypes.Integer) =
            { state with ShardSize = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: SignificantTextAggregation, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("sourceFields")>]
        member _.SourceFields(state: SignificantTextAggregation, value: CoreTypes.Fields) =
            { state with SourceFields = Some value }

    let significantTextAggregation = SignificantTextAggregationBuilder()

    type StatsAggregateBuilder() =
        member _.Yield(_: unit) : StatsAggregate =
            {
                Count = Unchecked.defaultof<_>
                Min = Unchecked.defaultof<_>
                Max = Unchecked.defaultof<_>
                Avg = Unchecked.defaultof<_>
                Sum = Unchecked.defaultof<_>
                MinAsString = None
                MaxAsString = None
                AvgAsString = None
                SumAsString = None
            }

        [<CustomOperation("count")>]
        member _.Count(state: StatsAggregate, value: CoreTypes.Long) =
            { state with Count = value }

        [<CustomOperation("min")>]
        member _.Min(state: StatsAggregate, value: CoreTypes.Double option) =
            { state with Min = value }

        [<CustomOperation("max")>]
        member _.Max(state: StatsAggregate, value: CoreTypes.Double option) =
            { state with Max = value }

        [<CustomOperation("avg")>]
        member _.Avg(state: StatsAggregate, value: CoreTypes.Double option) =
            { state with Avg = value }

        [<CustomOperation("sum")>]
        member _.Sum(state: StatsAggregate, value: CoreTypes.Double) =
            { state with Sum = value }

        [<CustomOperation("minAsString")>]
        member _.MinAsString(state: StatsAggregate, value: string) =
            { state with MinAsString = Some value }

        [<CustomOperation("maxAsString")>]
        member _.MaxAsString(state: StatsAggregate, value: string) =
            { state with MaxAsString = Some value }

        [<CustomOperation("avgAsString")>]
        member _.AvgAsString(state: StatsAggregate, value: string) =
            { state with AvgAsString = Some value }

        [<CustomOperation("sumAsString")>]
        member _.SumAsString(state: StatsAggregate, value: string) =
            { state with SumAsString = Some value }

    let statsAggregate = StatsAggregateBuilder()

    type StringStatsAggregateBuilder() =
        member _.Yield(_: unit) : StringStatsAggregate =
            {
                Count = Unchecked.defaultof<_>
                MinLength = Unchecked.defaultof<_>
                MaxLength = Unchecked.defaultof<_>
                AvgLength = Unchecked.defaultof<_>
                Entropy = Unchecked.defaultof<_>
                Distribution = None
                MinLengthAsString = None
                MaxLengthAsString = None
                AvgLengthAsString = None
            }

        [<CustomOperation("count")>]
        member _.Count(state: StringStatsAggregate, value: CoreTypes.Long) =
            { state with Count = value }

        [<CustomOperation("minLength")>]
        member _.MinLength(state: StringStatsAggregate, value: CoreTypes.Integer option) =
            { state with MinLength = value }

        [<CustomOperation("maxLength")>]
        member _.MaxLength(state: StringStatsAggregate, value: CoreTypes.Integer option) =
            { state with MaxLength = value }

        [<CustomOperation("avgLength")>]
        member _.AvgLength(state: StringStatsAggregate, value: CoreTypes.Double option) =
            { state with AvgLength = value }

        [<CustomOperation("entropy")>]
        member _.Entropy(state: StringStatsAggregate, value: CoreTypes.Double option) =
            { state with Entropy = value }

        [<CustomOperation("distribution")>]
        member _.Distribution(state: StringStatsAggregate, value: Map<string, CoreTypes.Double> option) =
            { state with Distribution = Some value }

        [<CustomOperation("minLengthAsString")>]
        member _.MinLengthAsString(state: StringStatsAggregate, value: string) =
            { state with MinLengthAsString = Some value }

        [<CustomOperation("maxLengthAsString")>]
        member _.MaxLengthAsString(state: StringStatsAggregate, value: string) =
            { state with MaxLengthAsString = Some value }

        [<CustomOperation("avgLengthAsString")>]
        member _.AvgLengthAsString(state: StringStatsAggregate, value: string) =
            { state with AvgLengthAsString = Some value }

    let stringStatsAggregate = StringStatsAggregateBuilder()

    type TDigestBuilder() =
        member _.Yield(_: unit) : TDigest =
            {
                Compression = None
                ExecutionHint = None
            }

        [<CustomOperation("compression")>]
        member _.Compression(state: TDigest, value: CoreTypes.Integer) =
            { state with Compression = Some value }

        [<CustomOperation("executionHint")>]
        member _.ExecutionHint(state: TDigest, value: CoreTypes.TDigestExecutionHint) =
            { state with ExecutionHint = Some value }

    let tDigest = TDigestBuilder()

    type TTestAggregationBuilder() =
        member _.Yield(_: unit) : TTestAggregation =
            {
                A = None
                B = None
                Type = None
            }

        [<CustomOperation("a")>]
        member _.A(state: TTestAggregation, value: CoreTypes.TestPopulation) =
            { state with A = Some value }

        [<CustomOperation("b")>]
        member _.B(state: TTestAggregation, value: CoreTypes.TestPopulation) =
            { state with B = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: TTestAggregation, value: CoreTypes.TTestType) =
            { state with Type = Some value }

    let tTestAggregation = TTestAggregationBuilder()

    type TermsAggregateBaseBuilder() =
        member _.Yield(_: unit) : TermsAggregateBase =
            {
                DocCountErrorUpperBound = None
                SumOtherDocCount = None
            }

        [<CustomOperation("docCountErrorUpperBound")>]
        member _.DocCountErrorUpperBound(state: TermsAggregateBase, value: CoreTypes.Long) =
            { state with DocCountErrorUpperBound = Some value }

        [<CustomOperation("sumOtherDocCount")>]
        member _.SumOtherDocCount(state: TermsAggregateBase, value: CoreTypes.Long) =
            { state with SumOtherDocCount = Some value }

    let termsAggregateBase = TermsAggregateBaseBuilder()

    type TermsAggregationBuilder() =
        member _.Yield(_: unit) : TermsAggregation =
            {
                CollectMode = None
                Exclude = None
                ExecutionHint = None
                Field = None
                Include = None
                MinDocCount = None
                Missing = None
                MissingOrder = None
                MissingBucket = None
                ValueType = None
                Order = None
                Script = None
                ShardMinDocCount = None
                ShardSize = None
                ShowTermDocCountError = None
                Size = None
                Format = None
            }

        [<CustomOperation("collectMode")>]
        member _.CollectMode(state: TermsAggregation, value: CoreTypes.TermsAggregationCollectMode) =
            { state with CollectMode = Some value }

        [<CustomOperation("exclude")>]
        member _.Exclude(state: TermsAggregation, value: CoreTypes.TermsExclude) =
            { state with Exclude = Some value }

        [<CustomOperation("executionHint")>]
        member _.ExecutionHint(state: TermsAggregation, value: CoreTypes.TermsAggregationExecutionHint) =
            { state with ExecutionHint = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: TermsAggregation, value: CoreTypes.Field) =
            { state with Field = Some value }

        [<CustomOperation("include")>]
        member _.Include(state: TermsAggregation, value: CoreTypes.TermsInclude) =
            { state with Include = Some value }

        [<CustomOperation("minDocCount")>]
        member _.MinDocCount(state: TermsAggregation, value: CoreTypes.Integer) =
            { state with MinDocCount = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: TermsAggregation, value: CoreTypes.Missing) =
            { state with Missing = Some value }

        [<CustomOperation("missingOrder")>]
        member _.MissingOrder(state: TermsAggregation, value: CoreTypes.MissingOrder) =
            { state with MissingOrder = Some value }

        [<CustomOperation("missingBucket")>]
        member _.MissingBucket(state: TermsAggregation, value: bool) =
            { state with MissingBucket = Some value }

        [<CustomOperation("valueType")>]
        member _.ValueType(state: TermsAggregation, value: string) =
            { state with ValueType = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: TermsAggregation, value: CoreTypes.AggregateOrder) =
            { state with Order = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: TermsAggregation, value: CoreTypes.Script) =
            { state with Script = Some value }

        [<CustomOperation("shardMinDocCount")>]
        member _.ShardMinDocCount(state: TermsAggregation, value: CoreTypes.Long) =
            { state with ShardMinDocCount = Some value }

        [<CustomOperation("shardSize")>]
        member _.ShardSize(state: TermsAggregation, value: CoreTypes.Integer) =
            { state with ShardSize = Some value }

        [<CustomOperation("showTermDocCountError")>]
        member _.ShowTermDocCountError(state: TermsAggregation, value: bool) =
            { state with ShowTermDocCountError = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: TermsAggregation, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: TermsAggregation, value: string) =
            { state with Format = Some value }

    let termsAggregation = TermsAggregationBuilder()

    type TestPopulationBuilder() =
        member _.Yield(_: unit) : TestPopulation =
            {
                Field = Unchecked.defaultof<_>
                Script = None
                Filter = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: TestPopulation, value: CoreTypes.Field) =
            { state with Field = value }

        [<CustomOperation("script")>]
        member _.Script(state: TestPopulation, value: CoreTypes.Script) =
            { state with Script = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: TestPopulation, value: CoreTypes.QueryContainer) =
            { state with Filter = Some value }

    let testPopulation = TestPopulationBuilder()

    type TimeSeriesAggregationBuilder() =
        member _.Yield(_: unit) : TimeSeriesAggregation =
            {
                Size = None
                Keyed = None
            }

        [<CustomOperation("size")>]
        member _.Size(state: TimeSeriesAggregation, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("keyed")>]
        member _.Keyed(state: TimeSeriesAggregation, value: bool) =
            { state with Keyed = Some value }

    let timeSeriesAggregation = TimeSeriesAggregationBuilder()

    type TopHitsAggregationBuilder() =
        member _.Yield(_: unit) : TopHitsAggregation =
            {
                DocvalueFields = None
                Explain = None
                Fields = None
                From = None
                Highlight = None
                ScriptFields = None
                Size = None
                Sort = None
                Source = None
                StoredFields = None
                TrackScores = None
                Version = None
                SeqNoPrimaryTerm = None
            }

        [<CustomOperation("docvalueFields")>]
        member _.DocvalueFields(state: TopHitsAggregation, value: CoreTypes.FieldAndFormat list) =
            { state with DocvalueFields = Some value }

        [<CustomOperation("explain")>]
        member _.Explain(state: TopHitsAggregation, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: TopHitsAggregation, value: CoreTypes.FieldAndFormat list) =
            { state with Fields = Some value }

        [<CustomOperation("from")>]
        member _.From(state: TopHitsAggregation, value: CoreTypes.Integer) =
            { state with From = Some value }

        [<CustomOperation("highlight")>]
        member _.Highlight(state: TopHitsAggregation, value: GlobalSearchTypes.Highlight) =
            { state with Highlight = Some value }

        [<CustomOperation("scriptFields")>]
        member _.ScriptFields(state: TopHitsAggregation, value: Map<string, CoreTypes.ScriptField>) =
            { state with ScriptFields = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: TopHitsAggregation, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: TopHitsAggregation, value: CoreTypes.Sort) =
            { state with Sort = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: TopHitsAggregation, value: GlobalSearchTypes.SourceConfig) =
            { state with Source = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: TopHitsAggregation, value: CoreTypes.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("trackScores")>]
        member _.TrackScores(state: TopHitsAggregation, value: bool) =
            { state with TrackScores = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: TopHitsAggregation, value: bool) =
            { state with Version = Some value }

        [<CustomOperation("seqNoPrimaryTerm")>]
        member _.SeqNoPrimaryTerm(state: TopHitsAggregation, value: bool) =
            { state with SeqNoPrimaryTerm = Some value }

    let topHitsAggregation = TopHitsAggregationBuilder()

    type TopMetricsAggregationBuilder() =
        member _.Yield(_: unit) : TopMetricsAggregation =
            {
                Metrics = None
                Size = None
                Sort = None
            }

        [<CustomOperation("metrics")>]
        member _.Metrics(state: TopMetricsAggregation, value: System.Text.Json.JsonElement) =
            { state with Metrics = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: TopMetricsAggregation, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: TopMetricsAggregation, value: CoreTypes.Sort) =
            { state with Sort = Some value }

    let topMetricsAggregation = TopMetricsAggregationBuilder()

    type VariableWidthHistogramAggregationBuilder() =
        member _.Yield(_: unit) : VariableWidthHistogramAggregation =
            {
                Field = None
                Buckets = None
                ShardSize = None
                InitialBuffer = None
                Script = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: VariableWidthHistogramAggregation, value: CoreTypes.Field) =
            { state with Field = Some value }

        [<CustomOperation("buckets")>]
        member _.Buckets(state: VariableWidthHistogramAggregation, value: CoreTypes.Integer) =
            { state with Buckets = Some value }

        [<CustomOperation("shardSize")>]
        member _.ShardSize(state: VariableWidthHistogramAggregation, value: CoreTypes.Integer) =
            { state with ShardSize = Some value }

        [<CustomOperation("initialBuffer")>]
        member _.InitialBuffer(state: VariableWidthHistogramAggregation, value: CoreTypes.Integer) =
            { state with InitialBuffer = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: VariableWidthHistogramAggregation, value: CoreTypes.Script) =
            { state with Script = Some value }

    let variableWidthHistogramAggregation = VariableWidthHistogramAggregationBuilder()

    type VariableWidthHistogramBucketBuilder() =
        member _.Yield(_: unit) : VariableWidthHistogramBucket =
            {
                Min = Unchecked.defaultof<_>
                Key = Unchecked.defaultof<_>
                Max = Unchecked.defaultof<_>
                MinAsString = None
                KeyAsString = None
                MaxAsString = None
            }

        [<CustomOperation("min")>]
        member _.Min(state: VariableWidthHistogramBucket, value: CoreTypes.Double) =
            { state with Min = value }

        [<CustomOperation("key")>]
        member _.Key(state: VariableWidthHistogramBucket, value: CoreTypes.Double) =
            { state with Key = value }

        [<CustomOperation("max")>]
        member _.Max(state: VariableWidthHistogramBucket, value: CoreTypes.Double) =
            { state with Max = value }

        [<CustomOperation("minAsString")>]
        member _.MinAsString(state: VariableWidthHistogramBucket, value: string) =
            { state with MinAsString = Some value }

        [<CustomOperation("keyAsString")>]
        member _.KeyAsString(state: VariableWidthHistogramBucket, value: string) =
            { state with KeyAsString = Some value }

        [<CustomOperation("maxAsString")>]
        member _.MaxAsString(state: VariableWidthHistogramBucket, value: string) =
            { state with MaxAsString = Some value }

    let variableWidthHistogramBucket = VariableWidthHistogramBucketBuilder()

    type WeightedAverageAggregationBuilder() =
        member _.Yield(_: unit) : WeightedAverageAggregation =
            {
                Format = None
                Value = None
                ValueType = None
                Weight = None
            }

        [<CustomOperation("format")>]
        member _.Format(state: WeightedAverageAggregation, value: string) =
            { state with Format = Some value }

        [<CustomOperation("value")>]
        member _.Value(state: WeightedAverageAggregation, value: CoreTypes.WeightedAverageValue) =
            { state with Value = Some value }

        [<CustomOperation("valueType")>]
        member _.ValueType(state: WeightedAverageAggregation, value: CoreTypes.ValueType) =
            { state with ValueType = Some value }

        [<CustomOperation("weight")>]
        member _.Weight(state: WeightedAverageAggregation, value: CoreTypes.WeightedAverageValue) =
            { state with Weight = Some value }

    let weightedAverageAggregation = WeightedAverageAggregationBuilder()

    type WeightedAverageValueBuilder() =
        member _.Yield(_: unit) : WeightedAverageValue =
            {
                Field = None
                Missing = None
                Script = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: WeightedAverageValue, value: CoreTypes.Field) =
            { state with Field = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: WeightedAverageValue, value: CoreTypes.Double) =
            { state with Missing = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: WeightedAverageValue, value: CoreTypes.Script) =
            { state with Script = Some value }

    let weightedAverageValue = WeightedAverageValueBuilder()


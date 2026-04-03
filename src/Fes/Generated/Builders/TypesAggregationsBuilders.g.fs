// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module TypesAggregationsBuilders =

    type AdjacencyMatrixAggregationBuilder() =
        member _.Yield(_: unit) : Types.AdjacencyMatrixAggregation =
            {
                Filters = None
                Separator = None
            }

        [<CustomOperation("filters")>]
        member _.Filters(state: Types.AdjacencyMatrixAggregation, value: Map<string, Types.QueryContainer>) =
            { state with Filters = Some value }

        [<CustomOperation("separator")>]
        member _.Separator(state: Types.AdjacencyMatrixAggregation, value: string) =
            { state with Separator = Some value }

    let adjacencyMatrixAggregation = AdjacencyMatrixAggregationBuilder()

    module Aggregation =

        let adjacencyMatrix (value: Types.AdjacencyMatrixAggregation) =
            Types.AggregationContainer.AdjacencyMatrix value

        let autoDateHistogram (value: Types.AutoDateHistogramAggregation) =
            Types.AggregationContainer.AutoDateHistogram value

        let avg (value: Types.AverageAggregation) =
            Types.AggregationContainer.Avg value

        let avgBucket (value: Types.AverageBucketAggregation) =
            Types.AggregationContainer.AvgBucket value

        let boxplot (value: Types.BoxplotAggregation) =
            Types.AggregationContainer.Boxplot value

        let bucketScript (value: Types.BucketScriptAggregation) =
            Types.AggregationContainer.BucketScript value

        let bucketSelector (value: Types.BucketSelectorAggregation) =
            Types.AggregationContainer.BucketSelector value

        let bucketSort (value: Types.BucketSortAggregation) =
            Types.AggregationContainer.BucketSort value

        let bucketCountKsTest (value: Types.BucketKsAggregation) =
            Types.AggregationContainer.BucketCountKsTest value

        let bucketCorrelation (value: Types.BucketCorrelationAggregation) =
            Types.AggregationContainer.BucketCorrelation value

        let cardinality (value: Types.CardinalityAggregation) =
            Types.AggregationContainer.Cardinality value

        let cartesianBounds (value: Types.CartesianBoundsAggregation) =
            Types.AggregationContainer.CartesianBounds value

        let cartesianCentroid (value: Types.CartesianCentroidAggregation) =
            Types.AggregationContainer.CartesianCentroid value

        let categorizeText (value: Types.CategorizeTextAggregation) =
            Types.AggregationContainer.CategorizeText value

        let changePoint (value: Types.ChangePointAggregation) =
            Types.AggregationContainer.ChangePoint value

        let children (value: Types.ChildrenAggregation) =
            Types.AggregationContainer.Children value

        let composite (value: Types.CompositeAggregation) =
            Types.AggregationContainer.Composite value

        let cumulativeCardinality (value: Types.CumulativeCardinalityAggregation) =
            Types.AggregationContainer.CumulativeCardinality value

        let cumulativeSum (value: Types.CumulativeSumAggregation) =
            Types.AggregationContainer.CumulativeSum value

        let dateHistogram (value: Types.DateHistogramAggregation) =
            Types.AggregationContainer.DateHistogram value

        let dateRange (value: Types.DateRangeAggregation) =
            Types.AggregationContainer.DateRange value

        let derivative (value: Types.DerivativeAggregation) =
            Types.AggregationContainer.Derivative value

        let diversifiedSampler (value: Types.DiversifiedSamplerAggregation) =
            Types.AggregationContainer.DiversifiedSampler value

        let extendedStats (value: Types.ExtendedStatsAggregation) =
            Types.AggregationContainer.ExtendedStats value

        let extendedStatsBucket (value: Types.ExtendedStatsBucketAggregation) =
            Types.AggregationContainer.ExtendedStatsBucket value

        let frequentItemSets (value: Types.FrequentItemSetsAggregation) =
            Types.AggregationContainer.FrequentItemSets value

        let filter (value: Types.QueryContainer) =
            Types.AggregationContainer.Filter value

        let filters (value: Types.FiltersAggregation) =
            Types.AggregationContainer.Filters value

        let geoBounds (value: Types.GeoBoundsAggregation) =
            Types.AggregationContainer.GeoBounds value

        let geoCentroid (value: Types.GeoCentroidAggregation) =
            Types.AggregationContainer.GeoCentroid value

        let geoDistance (value: Types.GeoDistanceAggregation) =
            Types.AggregationContainer.GeoDistance value

        let geohashGrid (value: Types.GeoHashGridAggregation) =
            Types.AggregationContainer.GeohashGrid value

        let geoLine (value: Types.GeoLineAggregation) =
            Types.AggregationContainer.GeoLine value

        let geotileGrid (value: Types.GeoTileGridAggregation) =
            Types.AggregationContainer.GeotileGrid value

        let geohexGrid (value: Types.GeohexGridAggregation) =
            Types.AggregationContainer.GeohexGrid value

        let global' (value: Types.GlobalAggregation) =
            Types.AggregationContainer.Global value

        let histogram (value: Types.HistogramAggregation) =
            Types.AggregationContainer.Histogram value

        let ipRange (value: Types.IpRangeAggregation) =
            Types.AggregationContainer.IpRange value

        let ipPrefix (value: Types.IpPrefixAggregation) =
            Types.AggregationContainer.IpPrefix value

        let inference (value: Types.InferenceAggregation) =
            Types.AggregationContainer.Inference value

        let line (value: Types.GeoLineAggregation) =
            Types.AggregationContainer.Line value

        let matrixStats (value: Types.MatrixStatsAggregation) =
            Types.AggregationContainer.MatrixStats value

        let max (value: Types.MaxAggregation) =
            Types.AggregationContainer.Max value

        let maxBucket (value: Types.MaxBucketAggregation) =
            Types.AggregationContainer.MaxBucket value

        let medianAbsoluteDeviation (value: Types.MedianAbsoluteDeviationAggregation) =
            Types.AggregationContainer.MedianAbsoluteDeviation value

        let min (value: Types.MinAggregation) =
            Types.AggregationContainer.Min value

        let minBucket (value: Types.MinBucketAggregation) =
            Types.AggregationContainer.MinBucket value

        let missing (value: Types.MissingAggregation) =
            Types.AggregationContainer.Missing value

        let movingAvg (value: Types.MovingAverageAggregation) =
            Types.AggregationContainer.MovingAvg value

        let movingPercentiles (value: Types.MovingPercentilesAggregation) =
            Types.AggregationContainer.MovingPercentiles value

        let movingFn (value: Types.MovingFunctionAggregation) =
            Types.AggregationContainer.MovingFn value

        let multiTerms (value: Types.MultiTermsAggregation) =
            Types.AggregationContainer.MultiTerms value

        let nested (value: Types.NestedAggregation) =
            Types.AggregationContainer.Nested value

        let normalize (value: Types.NormalizeAggregation) =
            Types.AggregationContainer.Normalize value

        let parent (value: Types.ParentAggregation) =
            Types.AggregationContainer.Parent value

        let percentileRanks (value: Types.PercentileRanksAggregation) =
            Types.AggregationContainer.PercentileRanks value

        let percentiles (value: Types.PercentilesAggregation) =
            Types.AggregationContainer.Percentiles value

        let percentilesBucket (value: Types.PercentilesBucketAggregation) =
            Types.AggregationContainer.PercentilesBucket value

        let range (value: Types.RangeAggregation) =
            Types.AggregationContainer.Range value

        let rareTerms (value: Types.RareTermsAggregation) =
            Types.AggregationContainer.RareTerms value

        let rate (value: Types.RateAggregation) =
            Types.AggregationContainer.Rate value

        let reverseNested (value: Types.ReverseNestedAggregation) =
            Types.AggregationContainer.ReverseNested value

        let randomSampler (value: Types.RandomSamplerAggregation) =
            Types.AggregationContainer.RandomSampler value

        let sampler (value: Types.SamplerAggregation) =
            Types.AggregationContainer.Sampler value

        let scriptedMetric (value: Types.ScriptedMetricAggregation) =
            Types.AggregationContainer.ScriptedMetric value

        let serialDiff (value: Types.SerialDifferencingAggregation) =
            Types.AggregationContainer.SerialDiff value

        let significantTerms (value: Types.SignificantTermsAggregation) =
            Types.AggregationContainer.SignificantTerms value

        let significantText (value: Types.SignificantTextAggregation) =
            Types.AggregationContainer.SignificantText value

        let stats (value: Types.StatsAggregation) =
            Types.AggregationContainer.Stats value

        let statsBucket (value: Types.StatsBucketAggregation) =
            Types.AggregationContainer.StatsBucket value

        let stringStats (value: Types.StringStatsAggregation) =
            Types.AggregationContainer.StringStats value

        let sum (value: Types.SumAggregation) =
            Types.AggregationContainer.Sum value

        let sumBucket (value: Types.SumBucketAggregation) =
            Types.AggregationContainer.SumBucket value

        let terms (value: Types.TermsAggregation) =
            Types.AggregationContainer.Terms value

        let timeSeries (value: Types.TimeSeriesAggregation) =
            Types.AggregationContainer.TimeSeries value

        let topHits (value: Types.TopHitsAggregation) =
            Types.AggregationContainer.TopHits value

        let tTest (value: Types.TTestAggregation) =
            Types.AggregationContainer.TTest value

        let topMetrics (value: Types.TopMetricsAggregation) =
            Types.AggregationContainer.TopMetrics value

        let valueCount (value: Types.ValueCountAggregation) =
            Types.AggregationContainer.ValueCount value

        let weightedAvg (value: Types.WeightedAverageAggregation) =
            Types.AggregationContainer.WeightedAvg value

        let variableWidthHistogram (value: Types.VariableWidthHistogramAggregation) =
            Types.AggregationContainer.VariableWidthHistogram value

    type AggregationRangeBuilder() =
        member _.Yield(_: unit) : Types.AggregationRange =
            {
                From = None
                Key = None
                To = None
            }

        [<CustomOperation("from")>]
        member _.From(state: Types.AggregationRange, value: Types.Double option) =
            { state with From = Some value }

        [<CustomOperation("key")>]
        member _.Key(state: Types.AggregationRange, value: string) =
            { state with Key = Some value }

        [<CustomOperation("to'")>]
        member _.To(state: Types.AggregationRange, value: Types.Double option) =
            { state with To = Some value }

    let aggregationRange = AggregationRangeBuilder()

    type AutoDateHistogramAggregationBuilder() =
        member _.Yield(_: unit) : Types.AutoDateHistogramAggregation =
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
        member _.Buckets(state: Types.AutoDateHistogramAggregation, value: Types.Integer) =
            { state with Buckets = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.AutoDateHistogramAggregation, value: Types.Field) =
            { state with Field = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: Types.AutoDateHistogramAggregation, value: string) =
            { state with Format = Some value }

        [<CustomOperation("minimumInterval")>]
        member _.MinimumInterval(state: Types.AutoDateHistogramAggregation, value: Types.MinimumInterval) =
            { state with MinimumInterval = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: Types.AutoDateHistogramAggregation, value: Types.DateTime) =
            { state with Missing = Some value }

        [<CustomOperation("offset")>]
        member _.Offset(state: Types.AutoDateHistogramAggregation, value: string) =
            { state with Offset = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: Types.AutoDateHistogramAggregation, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.AutoDateHistogramAggregation, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: Types.AutoDateHistogramAggregation, value: Types.TimeZone) =
            { state with TimeZone = Some value }

    let autoDateHistogramAggregation = AutoDateHistogramAggregationBuilder()

    type BoxPlotAggregateBuilder() =
        member _.Yield(_: unit) : Types.BoxPlotAggregate =
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
        member _.Min(state: Types.BoxPlotAggregate, value: Types.Double) =
            { state with Min = value }

        [<CustomOperation("max")>]
        member _.Max(state: Types.BoxPlotAggregate, value: Types.Double) =
            { state with Max = value }

        [<CustomOperation("q1")>]
        member _.Q1(state: Types.BoxPlotAggregate, value: Types.Double) =
            { state with Q1 = value }

        [<CustomOperation("q2")>]
        member _.Q2(state: Types.BoxPlotAggregate, value: Types.Double) =
            { state with Q2 = value }

        [<CustomOperation("q3")>]
        member _.Q3(state: Types.BoxPlotAggregate, value: Types.Double) =
            { state with Q3 = value }

        [<CustomOperation("lower")>]
        member _.Lower(state: Types.BoxPlotAggregate, value: Types.Double) =
            { state with Lower = value }

        [<CustomOperation("upper")>]
        member _.Upper(state: Types.BoxPlotAggregate, value: Types.Double) =
            { state with Upper = value }

        [<CustomOperation("minAsString")>]
        member _.MinAsString(state: Types.BoxPlotAggregate, value: string) =
            { state with MinAsString = Some value }

        [<CustomOperation("maxAsString")>]
        member _.MaxAsString(state: Types.BoxPlotAggregate, value: string) =
            { state with MaxAsString = Some value }

        [<CustomOperation("q1AsString")>]
        member _.Q1AsString(state: Types.BoxPlotAggregate, value: string) =
            { state with Q1AsString = Some value }

        [<CustomOperation("q2AsString")>]
        member _.Q2AsString(state: Types.BoxPlotAggregate, value: string) =
            { state with Q2AsString = Some value }

        [<CustomOperation("q3AsString")>]
        member _.Q3AsString(state: Types.BoxPlotAggregate, value: string) =
            { state with Q3AsString = Some value }

        [<CustomOperation("lowerAsString")>]
        member _.LowerAsString(state: Types.BoxPlotAggregate, value: string) =
            { state with LowerAsString = Some value }

        [<CustomOperation("upperAsString")>]
        member _.UpperAsString(state: Types.BoxPlotAggregate, value: string) =
            { state with UpperAsString = Some value }

    let boxPlotAggregate = BoxPlotAggregateBuilder()

    type BoxplotAggregationBuilder() =
        member _.Yield(_: unit) : Types.BoxplotAggregation =
            {
                Compression = None
                ExecutionHint = None
            }

        [<CustomOperation("compression")>]
        member _.Compression(state: Types.BoxplotAggregation, value: Types.Double) =
            { state with Compression = Some value }

        [<CustomOperation("executionHint")>]
        member _.ExecutionHint(state: Types.BoxplotAggregation, value: Types.TDigestExecutionHint) =
            { state with ExecutionHint = Some value }

    let boxplotAggregation = BoxplotAggregationBuilder()

    type BucketKsAggregationBuilder() =
        member _.Yield(_: unit) : Types.BucketKsAggregation =
            {
                Alternative = None
                Fractions = None
                SamplingMethod = None
            }

        [<CustomOperation("alternative")>]
        member _.Alternative(state: Types.BucketKsAggregation, value: string list) =
            { state with Alternative = Some value }

        [<CustomOperation("fractions")>]
        member _.Fractions(state: Types.BucketKsAggregation, value: Types.Double list) =
            { state with Fractions = Some value }

        [<CustomOperation("samplingMethod")>]
        member _.SamplingMethod(state: Types.BucketKsAggregation, value: string) =
            { state with SamplingMethod = Some value }

    let bucketKsAggregation = BucketKsAggregationBuilder()

    type BucketSortAggregationBuilder() =
        member _.Yield(_: unit) : Types.BucketSortAggregation =
            {
                From = None
                GapPolicy = None
                Size = None
                Sort = None
            }

        [<CustomOperation("from")>]
        member _.From(state: Types.BucketSortAggregation, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("gapPolicy")>]
        member _.GapPolicy(state: Types.BucketSortAggregation, value: Types.GapPolicy) =
            { state with GapPolicy = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.BucketSortAggregation, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: Types.BucketSortAggregation, value: Types.Sort) =
            { state with Sort = Some value }

    let bucketSortAggregation = BucketSortAggregationBuilder()

    type CardinalityAggregationBuilder() =
        member _.Yield(_: unit) : Types.CardinalityAggregation =
            {
                PrecisionThreshold = None
                Rehash = None
                ExecutionHint = None
            }

        [<CustomOperation("precisionThreshold")>]
        member _.PrecisionThreshold(state: Types.CardinalityAggregation, value: Types.Integer) =
            { state with PrecisionThreshold = Some value }

        [<CustomOperation("rehash")>]
        member _.Rehash(state: Types.CardinalityAggregation, value: bool) =
            { state with Rehash = Some value }

        [<CustomOperation("executionHint")>]
        member _.ExecutionHint(state: Types.CardinalityAggregation, value: Types.CardinalityExecutionMode) =
            { state with ExecutionHint = Some value }

    let cardinalityAggregation = CardinalityAggregationBuilder()

    type CategorizeTextAggregationBuilder() =
        member _.Yield(_: unit) : Types.CategorizeTextAggregation =
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
        member _.Field(state: Types.CategorizeTextAggregation, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("maxUniqueTokens")>]
        member _.MaxUniqueTokens(state: Types.CategorizeTextAggregation, value: Types.Integer) =
            { state with MaxUniqueTokens = Some value }

        [<CustomOperation("maxMatchedTokens")>]
        member _.MaxMatchedTokens(state: Types.CategorizeTextAggregation, value: Types.Integer) =
            { state with MaxMatchedTokens = Some value }

        [<CustomOperation("similarityThreshold")>]
        member _.SimilarityThreshold(state: Types.CategorizeTextAggregation, value: Types.Integer) =
            { state with SimilarityThreshold = Some value }

        [<CustomOperation("categorizationFilters")>]
        member _.CategorizationFilters(state: Types.CategorizeTextAggregation, value: string list) =
            { state with CategorizationFilters = Some value }

        [<CustomOperation("categorizationAnalyzer")>]
        member _.CategorizationAnalyzer(state: Types.CategorizeTextAggregation, value: Types.CategorizeTextAnalyzer) =
            { state with CategorizationAnalyzer = Some value }

        [<CustomOperation("shardSize")>]
        member _.ShardSize(state: Types.CategorizeTextAggregation, value: Types.Integer) =
            { state with ShardSize = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.CategorizeTextAggregation, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("minDocCount")>]
        member _.MinDocCount(state: Types.CategorizeTextAggregation, value: Types.Integer) =
            { state with MinDocCount = Some value }

        [<CustomOperation("shardMinDocCount")>]
        member _.ShardMinDocCount(state: Types.CategorizeTextAggregation, value: Types.Integer) =
            { state with ShardMinDocCount = Some value }

    let categorizeTextAggregation = CategorizeTextAggregationBuilder()

    module ChangeType =

        let dip (value: Types.Dip) =
            Types.ChangeType.Dip value

        let distributionChange (value: Types.DistributionChange) =
            Types.ChangeType.DistributionChange value

        let indeterminable (value: Types.Indeterminable) =
            Types.ChangeType.Indeterminable value

        let nonStationary (value: Types.NonStationary) =
            Types.ChangeType.NonStationary value

        let spike (value: Types.Spike) =
            Types.ChangeType.Spike value

        let stationary (value: Types.Stationary) =
            Types.ChangeType.Stationary value

        let stepChange (value: Types.StepChange) =
            Types.ChangeType.StepChange value

        let trendChange (value: Types.TrendChange) =
            Types.ChangeType.TrendChange value

    type CompositeAggregationBuilder() =
        member _.Yield(_: unit) : Types.CompositeAggregation =
            {
                After = None
                Size = None
                Sources = None
            }

        [<CustomOperation("after")>]
        member _.After(state: Types.CompositeAggregation, value: Types.CompositeAggregateKey) =
            { state with After = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.CompositeAggregation, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("sources")>]
        member _.Sources(state: Types.CompositeAggregation, value: Map<string, Types.CompositeAggregationSource> list) =
            { state with Sources = Some value }

    let compositeAggregation = CompositeAggregationBuilder()

    type CompositeAggregationBaseBuilder() =
        member _.Yield(_: unit) : Types.CompositeAggregationBase =
            {
                Field = None
                MissingBucket = None
                MissingOrder = None
                Script = None
                ValueType = None
                Order = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.CompositeAggregationBase, value: Types.Field) =
            { state with Field = Some value }

        [<CustomOperation("missingBucket")>]
        member _.MissingBucket(state: Types.CompositeAggregationBase, value: bool) =
            { state with MissingBucket = Some value }

        [<CustomOperation("missingOrder")>]
        member _.MissingOrder(state: Types.CompositeAggregationBase, value: Types.MissingOrder) =
            { state with MissingOrder = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.CompositeAggregationBase, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("valueType")>]
        member _.ValueType(state: Types.CompositeAggregationBase, value: Types.ValueType) =
            { state with ValueType = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: Types.CompositeAggregationBase, value: Types.SortOrder) =
            { state with Order = Some value }

    let compositeAggregationBase = CompositeAggregationBaseBuilder()

    module CompositeAggregationSource =

        let terms (value: Types.CompositeTermsAggregation) =
            Types.CompositeAggregationSource.Terms value

        let histogram (value: Types.CompositeHistogramAggregation) =
            Types.CompositeAggregationSource.Histogram value

        let dateHistogram (value: Types.CompositeDateHistogramAggregation) =
            Types.CompositeAggregationSource.DateHistogram value

        let geotileGrid (value: Types.CompositeGeoTileGridAggregation) =
            Types.CompositeAggregationSource.GeotileGrid value

    type CompositeDateHistogramAggregationBuilder() =
        member _.Yield(_: unit) : Types.CompositeDateHistogramAggregation =
            {
                Format = None
                CalendarInterval = None
                FixedInterval = None
                Offset = None
                TimeZone = None
            }

        [<CustomOperation("format")>]
        member _.Format(state: Types.CompositeDateHistogramAggregation, value: string) =
            { state with Format = Some value }

        [<CustomOperation("calendarInterval")>]
        member _.CalendarInterval(state: Types.CompositeDateHistogramAggregation, value: Types.DurationLarge) =
            { state with CalendarInterval = Some value }

        [<CustomOperation("fixedInterval")>]
        member _.FixedInterval(state: Types.CompositeDateHistogramAggregation, value: Types.DurationLarge) =
            { state with FixedInterval = Some value }

        [<CustomOperation("offset")>]
        member _.Offset(state: Types.CompositeDateHistogramAggregation, value: Types.Duration) =
            { state with Offset = Some value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: Types.CompositeDateHistogramAggregation, value: Types.TimeZone) =
            { state with TimeZone = Some value }

    let compositeDateHistogramAggregation = CompositeDateHistogramAggregationBuilder()

    type CompositeGeoTileGridAggregationBuilder() =
        member _.Yield(_: unit) : Types.CompositeGeoTileGridAggregation =
            {
                Precision = None
                Bounds = None
            }

        [<CustomOperation("precision")>]
        member _.Precision(state: Types.CompositeGeoTileGridAggregation, value: Types.Integer) =
            { state with Precision = Some value }

        [<CustomOperation("bounds")>]
        member _.Bounds(state: Types.CompositeGeoTileGridAggregation, value: Types.GeoBounds) =
            { state with Bounds = Some value }

    let compositeGeoTileGridAggregation = CompositeGeoTileGridAggregationBuilder()

    type CustomCategorizeTextAnalyzerBuilder() =
        member _.Yield(_: unit) : Types.CustomCategorizeTextAnalyzer =
            {
                CharFilter = None
                Tokenizer = None
                Filter = None
            }

        [<CustomOperation("charFilter")>]
        member _.CharFilter(state: Types.CustomCategorizeTextAnalyzer, value: string list) =
            { state with CharFilter = Some value }

        [<CustomOperation("tokenizer")>]
        member _.Tokenizer(state: Types.CustomCategorizeTextAnalyzer, value: string) =
            { state with Tokenizer = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: Types.CustomCategorizeTextAnalyzer, value: string list) =
            { state with Filter = Some value }

    let customCategorizeTextAnalyzer = CustomCategorizeTextAnalyzerBuilder()

    type DateHistogramAggregationBuilder() =
        member _.Yield(_: unit) : Types.DateHistogramAggregation =
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
        member _.CalendarInterval(state: Types.DateHistogramAggregation, value: Types.CalendarInterval) =
            { state with CalendarInterval = Some value }

        [<CustomOperation("extendedBounds")>]
        member _.ExtendedBounds(state: Types.DateHistogramAggregation, value: Types.ExtendedBounds<Types.FieldDateMath>) =
            { state with ExtendedBounds = Some value }

        [<CustomOperation("hardBounds")>]
        member _.HardBounds(state: Types.DateHistogramAggregation, value: Types.ExtendedBounds<Types.FieldDateMath>) =
            { state with HardBounds = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.DateHistogramAggregation, value: Types.Field) =
            { state with Field = Some value }

        [<CustomOperation("fixedInterval")>]
        member _.FixedInterval(state: Types.DateHistogramAggregation, value: Types.Duration) =
            { state with FixedInterval = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: Types.DateHistogramAggregation, value: string) =
            { state with Format = Some value }

        [<CustomOperation("interval")>]
        member _.Interval(state: Types.DateHistogramAggregation, value: Types.Duration) =
            { state with Interval = Some value }

        [<CustomOperation("minDocCount")>]
        member _.MinDocCount(state: Types.DateHistogramAggregation, value: Types.Integer) =
            { state with MinDocCount = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: Types.DateHistogramAggregation, value: Types.DateTime) =
            { state with Missing = Some value }

        [<CustomOperation("offset")>]
        member _.Offset(state: Types.DateHistogramAggregation, value: Types.Duration) =
            { state with Offset = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: Types.DateHistogramAggregation, value: Types.AggregateOrder) =
            { state with Order = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: Types.DateHistogramAggregation, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.DateHistogramAggregation, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: Types.DateHistogramAggregation, value: Types.TimeZone) =
            { state with TimeZone = Some value }

        [<CustomOperation("keyed")>]
        member _.Keyed(state: Types.DateHistogramAggregation, value: bool) =
            { state with Keyed = Some value }

    let dateHistogramAggregation = DateHistogramAggregationBuilder()

    type DateRangeAggregationBuilder() =
        member _.Yield(_: unit) : Types.DateRangeAggregation =
            {
                Field = None
                Format = None
                Missing = None
                Ranges = None
                TimeZone = None
                Keyed = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.DateRangeAggregation, value: Types.Field) =
            { state with Field = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: Types.DateRangeAggregation, value: string) =
            { state with Format = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: Types.DateRangeAggregation, value: Types.Missing) =
            { state with Missing = Some value }

        [<CustomOperation("ranges")>]
        member _.Ranges(state: Types.DateRangeAggregation, value: Types.DateRangeExpression list) =
            { state with Ranges = Some value }

        [<CustomOperation("timeZone")>]
        member _.TimeZone(state: Types.DateRangeAggregation, value: Types.TimeZone) =
            { state with TimeZone = Some value }

        [<CustomOperation("keyed")>]
        member _.Keyed(state: Types.DateRangeAggregation, value: bool) =
            { state with Keyed = Some value }

    let dateRangeAggregation = DateRangeAggregationBuilder()

    type DateRangeExpressionBuilder() =
        member _.Yield(_: unit) : Types.DateRangeExpression =
            {
                From = None
                Key = None
                To = None
            }

        [<CustomOperation("from")>]
        member _.From(state: Types.DateRangeExpression, value: Types.FieldDateMath) =
            { state with From = Some value }

        [<CustomOperation("key")>]
        member _.Key(state: Types.DateRangeExpression, value: string) =
            { state with Key = Some value }

        [<CustomOperation("to'")>]
        member _.To(state: Types.DateRangeExpression, value: Types.FieldDateMath) =
            { state with To = Some value }

    let dateRangeExpression = DateRangeExpressionBuilder()

    type DerivativeAggregateBuilder() =
        member _.Yield(_: unit) : Types.DerivativeAggregate =
            {
                NormalizedValue = None
                NormalizedValueAsString = None
            }

        [<CustomOperation("normalizedValue")>]
        member _.NormalizedValue(state: Types.DerivativeAggregate, value: Types.Double) =
            { state with NormalizedValue = Some value }

        [<CustomOperation("normalizedValueAsString")>]
        member _.NormalizedValueAsString(state: Types.DerivativeAggregate, value: string) =
            { state with NormalizedValueAsString = Some value }

    let derivativeAggregate = DerivativeAggregateBuilder()

    type DiversifiedSamplerAggregationBuilder() =
        member _.Yield(_: unit) : Types.DiversifiedSamplerAggregation =
            {
                ExecutionHint = None
                MaxDocsPerValue = None
                Script = None
                ShardSize = None
                Field = None
            }

        [<CustomOperation("executionHint")>]
        member _.ExecutionHint(state: Types.DiversifiedSamplerAggregation, value: Types.SamplerAggregationExecutionHint) =
            { state with ExecutionHint = Some value }

        [<CustomOperation("maxDocsPerValue")>]
        member _.MaxDocsPerValue(state: Types.DiversifiedSamplerAggregation, value: Types.Integer) =
            { state with MaxDocsPerValue = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.DiversifiedSamplerAggregation, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("shardSize")>]
        member _.ShardSize(state: Types.DiversifiedSamplerAggregation, value: Types.Integer) =
            { state with ShardSize = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.DiversifiedSamplerAggregation, value: Types.Field) =
            { state with Field = Some value }

    let diversifiedSamplerAggregation = DiversifiedSamplerAggregationBuilder()

    type ExtendedStatsAggregateBuilder() =
        member _.Yield(_: unit) : Types.ExtendedStatsAggregate =
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
        member _.SumOfSquares(state: Types.ExtendedStatsAggregate, value: Types.Double option) =
            { state with SumOfSquares = value }

        [<CustomOperation("variance")>]
        member _.Variance(state: Types.ExtendedStatsAggregate, value: Types.Double option) =
            { state with Variance = value }

        [<CustomOperation("variancePopulation")>]
        member _.VariancePopulation(state: Types.ExtendedStatsAggregate, value: Types.Double option) =
            { state with VariancePopulation = value }

        [<CustomOperation("varianceSampling")>]
        member _.VarianceSampling(state: Types.ExtendedStatsAggregate, value: Types.Double option) =
            { state with VarianceSampling = value }

        [<CustomOperation("stdDeviation")>]
        member _.StdDeviation(state: Types.ExtendedStatsAggregate, value: Types.Double option) =
            { state with StdDeviation = value }

        [<CustomOperation("stdDeviationPopulation")>]
        member _.StdDeviationPopulation(state: Types.ExtendedStatsAggregate, value: Types.Double option) =
            { state with StdDeviationPopulation = value }

        [<CustomOperation("stdDeviationSampling")>]
        member _.StdDeviationSampling(state: Types.ExtendedStatsAggregate, value: Types.Double option) =
            { state with StdDeviationSampling = value }

        [<CustomOperation("stdDeviationBounds")>]
        member _.StdDeviationBounds(state: Types.ExtendedStatsAggregate, value: Types.StandardDeviationBounds) =
            { state with StdDeviationBounds = Some value }

        [<CustomOperation("sumOfSquaresAsString")>]
        member _.SumOfSquaresAsString(state: Types.ExtendedStatsAggregate, value: string) =
            { state with SumOfSquaresAsString = Some value }

        [<CustomOperation("varianceAsString")>]
        member _.VarianceAsString(state: Types.ExtendedStatsAggregate, value: string) =
            { state with VarianceAsString = Some value }

        [<CustomOperation("variancePopulationAsString")>]
        member _.VariancePopulationAsString(state: Types.ExtendedStatsAggregate, value: string) =
            { state with VariancePopulationAsString = Some value }

        [<CustomOperation("varianceSamplingAsString")>]
        member _.VarianceSamplingAsString(state: Types.ExtendedStatsAggregate, value: string) =
            { state with VarianceSamplingAsString = Some value }

        [<CustomOperation("stdDeviationAsString")>]
        member _.StdDeviationAsString(state: Types.ExtendedStatsAggregate, value: string) =
            { state with StdDeviationAsString = Some value }

        [<CustomOperation("stdDeviationBoundsAsString")>]
        member _.StdDeviationBoundsAsString(state: Types.ExtendedStatsAggregate, value: Types.StandardDeviationBoundsAsString) =
            { state with StdDeviationBoundsAsString = Some value }

    let extendedStatsAggregate = ExtendedStatsAggregateBuilder()

    type FiltersAggregationBuilder() =
        member _.Yield(_: unit) : Types.FiltersAggregation =
            {
                Filters = None
                OtherBucket = None
                OtherBucketKey = None
                Keyed = None
            }

        [<CustomOperation("filters")>]
        member _.Filters(state: Types.FiltersAggregation, value: Types.Buckets<Types.QueryContainer>) =
            { state with Filters = Some value }

        [<CustomOperation("otherBucket")>]
        member _.OtherBucket(state: Types.FiltersAggregation, value: bool) =
            { state with OtherBucket = Some value }

        [<CustomOperation("otherBucketKey")>]
        member _.OtherBucketKey(state: Types.FiltersAggregation, value: string) =
            { state with OtherBucketKey = Some value }

        [<CustomOperation("keyed")>]
        member _.Keyed(state: Types.FiltersAggregation, value: bool) =
            { state with Keyed = Some value }

    let filtersAggregation = FiltersAggregationBuilder()

    type FrequentItemSetsAggregationBuilder() =
        member _.Yield(_: unit) : Types.FrequentItemSetsAggregation =
            {
                Fields = Unchecked.defaultof<_>
                MinimumSetSize = None
                MinimumSupport = None
                Size = None
                Filter = None
            }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.FrequentItemSetsAggregation, value: Types.FrequentItemSetsField list) =
            { state with Fields = value }

        [<CustomOperation("minimumSetSize")>]
        member _.MinimumSetSize(state: Types.FrequentItemSetsAggregation, value: Types.Integer) =
            { state with MinimumSetSize = Some value }

        [<CustomOperation("minimumSupport")>]
        member _.MinimumSupport(state: Types.FrequentItemSetsAggregation, value: Types.Double) =
            { state with MinimumSupport = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.FrequentItemSetsAggregation, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: Types.FrequentItemSetsAggregation, value: Types.QueryContainer) =
            { state with Filter = Some value }

    let frequentItemSetsAggregation = FrequentItemSetsAggregationBuilder()

    type FrequentItemSetsFieldBuilder() =
        member _.Yield(_: unit) : Types.FrequentItemSetsField =
            {
                Field = Unchecked.defaultof<_>
                Exclude = None
                Include = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.FrequentItemSetsField, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("exclude")>]
        member _.Exclude(state: Types.FrequentItemSetsField, value: Types.TermsExclude) =
            { state with Exclude = Some value }

        [<CustomOperation("include")>]
        member _.Include(state: Types.FrequentItemSetsField, value: Types.TermsInclude) =
            { state with Include = Some value }

    let frequentItemSetsField = FrequentItemSetsFieldBuilder()

    type GeoCentroidAggregationBuilder() =
        member _.Yield(_: unit) : Types.GeoCentroidAggregation =
            {
                Count = None
                Location = None
            }

        [<CustomOperation("count")>]
        member _.Count(state: Types.GeoCentroidAggregation, value: Types.Long) =
            { state with Count = Some value }

        [<CustomOperation("location")>]
        member _.Location(state: Types.GeoCentroidAggregation, value: Types.GeoLocation) =
            { state with Location = Some value }

    let geoCentroidAggregation = GeoCentroidAggregationBuilder()

    type GeoDistanceAggregationBuilder() =
        member _.Yield(_: unit) : Types.GeoDistanceAggregation =
            {
                DistanceType = None
                Field = None
                Origin = None
                Ranges = None
                Unit = None
            }

        [<CustomOperation("distanceType")>]
        member _.DistanceType(state: Types.GeoDistanceAggregation, value: Types.GeoDistanceType) =
            { state with DistanceType = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.GeoDistanceAggregation, value: Types.Field) =
            { state with Field = Some value }

        [<CustomOperation("origin")>]
        member _.Origin(state: Types.GeoDistanceAggregation, value: Types.GeoLocation) =
            { state with Origin = Some value }

        [<CustomOperation("ranges")>]
        member _.Ranges(state: Types.GeoDistanceAggregation, value: Types.AggregationRange list) =
            { state with Ranges = Some value }

        [<CustomOperation("unit")>]
        member _.Unit(state: Types.GeoDistanceAggregation, value: Types.DistanceUnit) =
            { state with Unit = Some value }

    let geoDistanceAggregation = GeoDistanceAggregationBuilder()

    type GeoHashGridAggregationBuilder() =
        member _.Yield(_: unit) : Types.GeoHashGridAggregation =
            {
                Bounds = None
                Field = None
                Precision = None
                ShardSize = None
                Size = None
            }

        [<CustomOperation("bounds")>]
        member _.Bounds(state: Types.GeoHashGridAggregation, value: Types.GeoBounds) =
            { state with Bounds = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.GeoHashGridAggregation, value: Types.Field) =
            { state with Field = Some value }

        [<CustomOperation("precision")>]
        member _.Precision(state: Types.GeoHashGridAggregation, value: Types.GeoHashPrecision) =
            { state with Precision = Some value }

        [<CustomOperation("shardSize")>]
        member _.ShardSize(state: Types.GeoHashGridAggregation, value: Types.Integer) =
            { state with ShardSize = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.GeoHashGridAggregation, value: Types.Integer) =
            { state with Size = Some value }

    let geoHashGridAggregation = GeoHashGridAggregationBuilder()

    type GeoLineAggregationBuilder() =
        member _.Yield(_: unit) : Types.GeoLineAggregation =
            {
                Point = Unchecked.defaultof<_>
                Sort = None
                IncludeSort = None
                SortOrder = None
                Size = None
            }

        [<CustomOperation("point")>]
        member _.Point(state: Types.GeoLineAggregation, value: Types.GeoLinePoint) =
            { state with Point = value }

        [<CustomOperation("sort")>]
        member _.Sort(state: Types.GeoLineAggregation, value: Types.GeoLineSort) =
            { state with Sort = Some value }

        [<CustomOperation("includeSort")>]
        member _.IncludeSort(state: Types.GeoLineAggregation, value: bool) =
            { state with IncludeSort = Some value }

        [<CustomOperation("sortOrder")>]
        member _.SortOrder(state: Types.GeoLineAggregation, value: Types.SortOrder) =
            { state with SortOrder = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.GeoLineAggregation, value: Types.Integer) =
            { state with Size = Some value }

    let geoLineAggregation = GeoLineAggregationBuilder()

    type GeoTileGridAggregationBuilder() =
        member _.Yield(_: unit) : Types.GeoTileGridAggregation =
            {
                Field = None
                Precision = None
                ShardSize = None
                Size = None
                Bounds = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.GeoTileGridAggregation, value: Types.Field) =
            { state with Field = Some value }

        [<CustomOperation("precision")>]
        member _.Precision(state: Types.GeoTileGridAggregation, value: Types.GeoTilePrecision) =
            { state with Precision = Some value }

        [<CustomOperation("shardSize")>]
        member _.ShardSize(state: Types.GeoTileGridAggregation, value: Types.Integer) =
            { state with ShardSize = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.GeoTileGridAggregation, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("bounds")>]
        member _.Bounds(state: Types.GeoTileGridAggregation, value: Types.GeoBounds) =
            { state with Bounds = Some value }

    let geoTileGridAggregation = GeoTileGridAggregationBuilder()

    type GeohexGridAggregationBuilder() =
        member _.Yield(_: unit) : Types.GeohexGridAggregation =
            {
                Field = Unchecked.defaultof<_>
                Precision = None
                Bounds = None
                Size = None
                ShardSize = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.GeohexGridAggregation, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("precision")>]
        member _.Precision(state: Types.GeohexGridAggregation, value: Types.Integer) =
            { state with Precision = Some value }

        [<CustomOperation("bounds")>]
        member _.Bounds(state: Types.GeohexGridAggregation, value: Types.GeoBounds) =
            { state with Bounds = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.GeohexGridAggregation, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("shardSize")>]
        member _.ShardSize(state: Types.GeohexGridAggregation, value: Types.Integer) =
            { state with ShardSize = Some value }

    let geohexGridAggregation = GeohexGridAggregationBuilder()

    type HistogramAggregationBuilder() =
        member _.Yield(_: unit) : Types.HistogramAggregation =
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
        member _.ExtendedBounds(state: Types.HistogramAggregation, value: Types.ExtendedBounds<Types.Double>) =
            { state with ExtendedBounds = Some value }

        [<CustomOperation("hardBounds")>]
        member _.HardBounds(state: Types.HistogramAggregation, value: Types.ExtendedBounds<Types.Double>) =
            { state with HardBounds = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.HistogramAggregation, value: Types.Field) =
            { state with Field = Some value }

        [<CustomOperation("interval")>]
        member _.Interval(state: Types.HistogramAggregation, value: Types.Double) =
            { state with Interval = Some value }

        [<CustomOperation("minDocCount")>]
        member _.MinDocCount(state: Types.HistogramAggregation, value: Types.Integer) =
            { state with MinDocCount = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: Types.HistogramAggregation, value: Types.Double) =
            { state with Missing = Some value }

        [<CustomOperation("offset")>]
        member _.Offset(state: Types.HistogramAggregation, value: Types.Double) =
            { state with Offset = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: Types.HistogramAggregation, value: Types.AggregateOrder) =
            { state with Order = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.HistogramAggregation, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: Types.HistogramAggregation, value: string) =
            { state with Format = Some value }

        [<CustomOperation("keyed")>]
        member _.Keyed(state: Types.HistogramAggregation, value: bool) =
            { state with Keyed = Some value }

    let histogramAggregation = HistogramAggregationBuilder()

    type HoltLinearModelSettingsBuilder() =
        member _.Yield(_: unit) : Types.HoltLinearModelSettings =
            {
                Alpha = None
                Beta = None
            }

        [<CustomOperation("alpha")>]
        member _.Alpha(state: Types.HoltLinearModelSettings, value: Types.Float) =
            { state with Alpha = Some value }

        [<CustomOperation("beta")>]
        member _.Beta(state: Types.HoltLinearModelSettings, value: Types.Float) =
            { state with Beta = Some value }

    let holtLinearModelSettings = HoltLinearModelSettingsBuilder()

    type HoltWintersModelSettingsBuilder() =
        member _.Yield(_: unit) : Types.HoltWintersModelSettings =
            {
                Alpha = None
                Beta = None
                Gamma = None
                Pad = None
                Period = None
                Type = None
            }

        [<CustomOperation("alpha")>]
        member _.Alpha(state: Types.HoltWintersModelSettings, value: Types.Float) =
            { state with Alpha = Some value }

        [<CustomOperation("beta")>]
        member _.Beta(state: Types.HoltWintersModelSettings, value: Types.Float) =
            { state with Beta = Some value }

        [<CustomOperation("gamma")>]
        member _.Gamma(state: Types.HoltWintersModelSettings, value: Types.Float) =
            { state with Gamma = Some value }

        [<CustomOperation("pad")>]
        member _.Pad(state: Types.HoltWintersModelSettings, value: bool) =
            { state with Pad = Some value }

        [<CustomOperation("period")>]
        member _.Period(state: Types.HoltWintersModelSettings, value: Types.Integer) =
            { state with Period = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.HoltWintersModelSettings, value: Types.HoltWintersType) =
            { state with Type = Some value }

    let holtWintersModelSettings = HoltWintersModelSettingsBuilder()

    type InferenceAggregateBuilder() =
        member _.Yield(_: unit) : Types.InferenceAggregate =
            {
                Value = None
                FeatureImportance = None
                TopClasses = None
                Warning = None
            }

        [<CustomOperation("value")>]
        member _.Value(state: Types.InferenceAggregate, value: Types.FieldValue) =
            { state with Value = Some value }

        [<CustomOperation("featureImportance")>]
        member _.FeatureImportance(state: Types.InferenceAggregate, value: Types.InferenceFeatureImportance list) =
            { state with FeatureImportance = Some value }

        [<CustomOperation("topClasses")>]
        member _.TopClasses(state: Types.InferenceAggregate, value: Types.InferenceTopClassEntry list) =
            { state with TopClasses = Some value }

        [<CustomOperation("warning")>]
        member _.Warning(state: Types.InferenceAggregate, value: string) =
            { state with Warning = Some value }

    let inferenceAggregate = InferenceAggregateBuilder()

    module InferenceConfig =

        let regression (value: Types.RegressionInferenceOptions) =
            Types.InferenceConfigContainer.Regression value

        let classification (value: Types.ClassificationInferenceOptions) =
            Types.InferenceConfigContainer.Classification value

    type InferenceFeatureImportanceBuilder() =
        member _.Yield(_: unit) : Types.InferenceFeatureImportance =
            {
                FeatureName = Unchecked.defaultof<_>
                Importance = None
                Classes = None
            }

        [<CustomOperation("featureName")>]
        member _.FeatureName(state: Types.InferenceFeatureImportance, value: string) =
            { state with FeatureName = value }

        [<CustomOperation("importance")>]
        member _.Importance(state: Types.InferenceFeatureImportance, value: Types.Double) =
            { state with Importance = Some value }

        [<CustomOperation("classes")>]
        member _.Classes(state: Types.InferenceFeatureImportance, value: Types.InferenceClassImportance list) =
            { state with Classes = Some value }

    let inferenceFeatureImportance = InferenceFeatureImportanceBuilder()

    type IpPrefixAggregationBuilder() =
        member _.Yield(_: unit) : Types.IpPrefixAggregation =
            {
                Field = Unchecked.defaultof<_>
                PrefixLength = Unchecked.defaultof<_>
                IsIpv6 = None
                AppendPrefixLength = None
                Keyed = None
                MinDocCount = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.IpPrefixAggregation, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("prefixLength")>]
        member _.PrefixLength(state: Types.IpPrefixAggregation, value: Types.Integer) =
            { state with PrefixLength = value }

        [<CustomOperation("isIpv6")>]
        member _.IsIpv6(state: Types.IpPrefixAggregation, value: bool) =
            { state with IsIpv6 = Some value }

        [<CustomOperation("appendPrefixLength")>]
        member _.AppendPrefixLength(state: Types.IpPrefixAggregation, value: bool) =
            { state with AppendPrefixLength = Some value }

        [<CustomOperation("keyed")>]
        member _.Keyed(state: Types.IpPrefixAggregation, value: bool) =
            { state with Keyed = Some value }

        [<CustomOperation("minDocCount")>]
        member _.MinDocCount(state: Types.IpPrefixAggregation, value: Types.Long) =
            { state with MinDocCount = Some value }

    let ipPrefixAggregation = IpPrefixAggregationBuilder()

    type IpRangeAggregationBuilder() =
        member _.Yield(_: unit) : Types.IpRangeAggregation =
            {
                Field = None
                Ranges = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.IpRangeAggregation, value: Types.Field) =
            { state with Field = Some value }

        [<CustomOperation("ranges")>]
        member _.Ranges(state: Types.IpRangeAggregation, value: Types.IpRangeAggregationRange list) =
            { state with Ranges = Some value }

    let ipRangeAggregation = IpRangeAggregationBuilder()

    type IpRangeAggregationRangeBuilder() =
        member _.Yield(_: unit) : Types.IpRangeAggregationRange =
            {
                From = None
                Mask = None
                To = None
            }

        [<CustomOperation("from")>]
        member _.From(state: Types.IpRangeAggregationRange, value: string option) =
            { state with From = Some value }

        [<CustomOperation("mask")>]
        member _.Mask(state: Types.IpRangeAggregationRange, value: string) =
            { state with Mask = Some value }

        [<CustomOperation("to'")>]
        member _.To(state: Types.IpRangeAggregationRange, value: string option) =
            { state with To = Some value }

    let ipRangeAggregationRange = IpRangeAggregationRangeBuilder()

    type IpRangeBucketBuilder() =
        member _.Yield(_: unit) : Types.IpRangeBucket =
            {
                Key = None
                From = None
                To = None
            }

        [<CustomOperation("key")>]
        member _.Key(state: Types.IpRangeBucket, value: string) =
            { state with Key = Some value }

        [<CustomOperation("from")>]
        member _.From(state: Types.IpRangeBucket, value: string) =
            { state with From = Some value }

        [<CustomOperation("to'")>]
        member _.To(state: Types.IpRangeBucket, value: string) =
            { state with To = Some value }

    let ipRangeBucket = IpRangeBucketBuilder()

    type MatrixAggregationBuilder() =
        member _.Yield(_: unit) : Types.MatrixAggregation =
            {
                Fields = None
                Missing = None
            }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.MatrixAggregation, value: Types.Fields) =
            { state with Fields = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: Types.MatrixAggregation, value: Map<Types.Field, Types.Double>) =
            { state with Missing = Some value }

    let matrixAggregation = MatrixAggregationBuilder()

    type MedianAbsoluteDeviationAggregationBuilder() =
        member _.Yield(_: unit) : Types.MedianAbsoluteDeviationAggregation =
            {
                Compression = None
                ExecutionHint = None
            }

        [<CustomOperation("compression")>]
        member _.Compression(state: Types.MedianAbsoluteDeviationAggregation, value: Types.Double) =
            { state with Compression = Some value }

        [<CustomOperation("executionHint")>]
        member _.ExecutionHint(state: Types.MedianAbsoluteDeviationAggregation, value: Types.TDigestExecutionHint) =
            { state with ExecutionHint = Some value }

    let medianAbsoluteDeviationAggregation = MedianAbsoluteDeviationAggregationBuilder()

    type MetricAggregationBaseBuilder() =
        member _.Yield(_: unit) : Types.MetricAggregationBase =
            {
                Field = None
                Missing = None
                Script = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.MetricAggregationBase, value: Types.Field) =
            { state with Field = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: Types.MetricAggregationBase, value: Types.Missing) =
            { state with Missing = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.MetricAggregationBase, value: Types.Script) =
            { state with Script = Some value }

    let metricAggregationBase = MetricAggregationBaseBuilder()

    type MissingAggregationBuilder() =
        member _.Yield(_: unit) : Types.MissingAggregation =
            {
                Field = None
                Missing = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.MissingAggregation, value: Types.Field) =
            { state with Field = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: Types.MissingAggregation, value: Types.Missing) =
            { state with Missing = Some value }

    let missingAggregation = MissingAggregationBuilder()

    type MovingAverageAggregationBaseBuilder() =
        member _.Yield(_: unit) : Types.MovingAverageAggregationBase =
            {
                Minimize = None
                Predict = None
                Window = None
            }

        [<CustomOperation("minimize")>]
        member _.Minimize(state: Types.MovingAverageAggregationBase, value: bool) =
            { state with Minimize = Some value }

        [<CustomOperation("predict")>]
        member _.Predict(state: Types.MovingAverageAggregationBase, value: Types.Integer) =
            { state with Predict = Some value }

        [<CustomOperation("window")>]
        member _.Window(state: Types.MovingAverageAggregationBase, value: Types.Integer) =
            { state with Window = Some value }

    let movingAverageAggregationBase = MovingAverageAggregationBaseBuilder()

    type MovingFunctionAggregationBuilder() =
        member _.Yield(_: unit) : Types.MovingFunctionAggregation =
            {
                Script = None
                Shift = None
                Window = None
            }

        [<CustomOperation("script")>]
        member _.Script(state: Types.MovingFunctionAggregation, value: string) =
            { state with Script = Some value }

        [<CustomOperation("shift")>]
        member _.Shift(state: Types.MovingFunctionAggregation, value: Types.Integer) =
            { state with Shift = Some value }

        [<CustomOperation("window")>]
        member _.Window(state: Types.MovingFunctionAggregation, value: Types.Integer) =
            { state with Window = Some value }

    let movingFunctionAggregation = MovingFunctionAggregationBuilder()

    type MovingPercentilesAggregationBuilder() =
        member _.Yield(_: unit) : Types.MovingPercentilesAggregation =
            {
                Window = None
                Shift = None
                Keyed = None
            }

        [<CustomOperation("window")>]
        member _.Window(state: Types.MovingPercentilesAggregation, value: Types.Integer) =
            { state with Window = Some value }

        [<CustomOperation("shift")>]
        member _.Shift(state: Types.MovingPercentilesAggregation, value: Types.Integer) =
            { state with Shift = Some value }

        [<CustomOperation("keyed")>]
        member _.Keyed(state: Types.MovingPercentilesAggregation, value: bool) =
            { state with Keyed = Some value }

    let movingPercentilesAggregation = MovingPercentilesAggregationBuilder()

    module MultiTermLookup =

        let field (value: Types.Field) =
            Types.MultiTermLookup.Field value

        let script (value: Types.Script) =
            Types.MultiTermLookup.Script value

    type MultiTermsAggregationBuilder() =
        member _.Yield(_: unit) : Types.MultiTermsAggregation =
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
        member _.CollectMode(state: Types.MultiTermsAggregation, value: Types.TermsAggregationCollectMode) =
            { state with CollectMode = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: Types.MultiTermsAggregation, value: Types.AggregateOrder) =
            { state with Order = Some value }

        [<CustomOperation("minDocCount")>]
        member _.MinDocCount(state: Types.MultiTermsAggregation, value: Types.Long) =
            { state with MinDocCount = Some value }

        [<CustomOperation("shardMinDocCount")>]
        member _.ShardMinDocCount(state: Types.MultiTermsAggregation, value: Types.Long) =
            { state with ShardMinDocCount = Some value }

        [<CustomOperation("shardSize")>]
        member _.ShardSize(state: Types.MultiTermsAggregation, value: Types.Integer) =
            { state with ShardSize = Some value }

        [<CustomOperation("showTermDocCountError")>]
        member _.ShowTermDocCountError(state: Types.MultiTermsAggregation, value: bool) =
            { state with ShowTermDocCountError = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.MultiTermsAggregation, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("terms")>]
        member _.Terms(state: Types.MultiTermsAggregation, value: Types.MultiTermLookup list) =
            { state with Terms = value }

    let multiTermsAggregation = MultiTermsAggregationBuilder()

    type MultiTermsBucketBuilder() =
        member _.Yield(_: unit) : Types.MultiTermsBucket =
            {
                Key = Unchecked.defaultof<_>
                KeyAsString = None
                DocCountErrorUpperBound = None
            }

        [<CustomOperation("key")>]
        member _.Key(state: Types.MultiTermsBucket, value: Types.FieldValue list) =
            { state with Key = value }

        [<CustomOperation("keyAsString")>]
        member _.KeyAsString(state: Types.MultiTermsBucket, value: string) =
            { state with KeyAsString = Some value }

        [<CustomOperation("docCountErrorUpperBound")>]
        member _.DocCountErrorUpperBound(state: Types.MultiTermsBucket, value: Types.Long) =
            { state with DocCountErrorUpperBound = Some value }

    let multiTermsBucket = MultiTermsBucketBuilder()

    type MutualInformationHeuristicBuilder() =
        member _.Yield(_: unit) : Types.MutualInformationHeuristic =
            {
                BackgroundIsSuperset = None
                IncludeNegatives = None
            }

        [<CustomOperation("backgroundIsSuperset")>]
        member _.BackgroundIsSuperset(state: Types.MutualInformationHeuristic, value: bool) =
            { state with BackgroundIsSuperset = Some value }

        [<CustomOperation("includeNegatives")>]
        member _.IncludeNegatives(state: Types.MutualInformationHeuristic, value: bool) =
            { state with IncludeNegatives = Some value }

    let mutualInformationHeuristic = MutualInformationHeuristicBuilder()

    type PValueHeuristicBuilder() =
        member _.Yield(_: unit) : Types.PValueHeuristic =
            {
                BackgroundIsSuperset = None
                NormalizeAbove = None
            }

        [<CustomOperation("backgroundIsSuperset")>]
        member _.BackgroundIsSuperset(state: Types.PValueHeuristic, value: bool) =
            { state with BackgroundIsSuperset = Some value }

        [<CustomOperation("normalizeAbove")>]
        member _.NormalizeAbove(state: Types.PValueHeuristic, value: Types.Long) =
            { state with NormalizeAbove = Some value }

    let pValueHeuristic = PValueHeuristicBuilder()

    type PercentileRanksAggregationBuilder() =
        member _.Yield(_: unit) : Types.PercentileRanksAggregation =
            {
                Keyed = None
                Values = None
                Hdr = None
                Tdigest = None
            }

        [<CustomOperation("keyed")>]
        member _.Keyed(state: Types.PercentileRanksAggregation, value: bool) =
            { state with Keyed = Some value }

        [<CustomOperation("values")>]
        member _.Values(state: Types.PercentileRanksAggregation, value: Types.Double list option) =
            { state with Values = Some value }

        [<CustomOperation("hdr")>]
        member _.Hdr(state: Types.PercentileRanksAggregation, value: Types.HdrMethod) =
            { state with Hdr = Some value }

        [<CustomOperation("tdigest")>]
        member _.Tdigest(state: Types.PercentileRanksAggregation, value: Types.TDigest) =
            { state with Tdigest = Some value }

    let percentileRanksAggregation = PercentileRanksAggregationBuilder()

    type PercentilesAggregationBuilder() =
        member _.Yield(_: unit) : Types.PercentilesAggregation =
            {
                Keyed = None
                Percents = None
                Hdr = None
                Tdigest = None
            }

        [<CustomOperation("keyed")>]
        member _.Keyed(state: Types.PercentilesAggregation, value: bool) =
            { state with Keyed = Some value }

        [<CustomOperation("percents")>]
        member _.Percents(state: Types.PercentilesAggregation, value: System.Text.Json.JsonElement) =
            { state with Percents = Some value }

        [<CustomOperation("hdr")>]
        member _.Hdr(state: Types.PercentilesAggregation, value: Types.HdrMethod) =
            { state with Hdr = Some value }

        [<CustomOperation("tdigest")>]
        member _.Tdigest(state: Types.PercentilesAggregation, value: Types.TDigest) =
            { state with Tdigest = Some value }

    let percentilesAggregation = PercentilesAggregationBuilder()

    type PipelineAggregationBaseBuilder() =
        member _.Yield(_: unit) : Types.PipelineAggregationBase =
            {
                Format = None
                GapPolicy = None
            }

        [<CustomOperation("format")>]
        member _.Format(state: Types.PipelineAggregationBase, value: string) =
            { state with Format = Some value }

        [<CustomOperation("gapPolicy")>]
        member _.GapPolicy(state: Types.PipelineAggregationBase, value: Types.GapPolicy) =
            { state with GapPolicy = Some value }

    let pipelineAggregationBase = PipelineAggregationBaseBuilder()

    type RandomSamplerAggregationBuilder() =
        member _.Yield(_: unit) : Types.RandomSamplerAggregation =
            {
                Probability = Unchecked.defaultof<_>
                Seed = None
                ShardSeed = None
            }

        [<CustomOperation("probability")>]
        member _.Probability(state: Types.RandomSamplerAggregation, value: Types.Double) =
            { state with Probability = value }

        [<CustomOperation("seed")>]
        member _.Seed(state: Types.RandomSamplerAggregation, value: Types.Integer) =
            { state with Seed = Some value }

        [<CustomOperation("shardSeed")>]
        member _.ShardSeed(state: Types.RandomSamplerAggregation, value: Types.Integer) =
            { state with ShardSeed = Some value }

    let randomSamplerAggregation = RandomSamplerAggregationBuilder()

    type RangeAggregationBuilder() =
        member _.Yield(_: unit) : Types.RangeAggregation =
            {
                Field = None
                Missing = None
                Ranges = None
                Script = None
                Keyed = None
                Format = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.RangeAggregation, value: Types.Field) =
            { state with Field = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: Types.RangeAggregation, value: Types.Integer) =
            { state with Missing = Some value }

        [<CustomOperation("ranges")>]
        member _.Ranges(state: Types.RangeAggregation, value: Types.AggregationRange list) =
            { state with Ranges = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.RangeAggregation, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("keyed")>]
        member _.Keyed(state: Types.RangeAggregation, value: bool) =
            { state with Keyed = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: Types.RangeAggregation, value: string) =
            { state with Format = Some value }

    let rangeAggregation = RangeAggregationBuilder()

    type RangeBucketBuilder() =
        member _.Yield(_: unit) : Types.RangeBucket =
            {
                From = None
                To = None
                FromAsString = None
                ToAsString = None
                Key = None
            }

        [<CustomOperation("from")>]
        member _.From(state: Types.RangeBucket, value: Types.Double) =
            { state with From = Some value }

        [<CustomOperation("to'")>]
        member _.To(state: Types.RangeBucket, value: Types.Double) =
            { state with To = Some value }

        [<CustomOperation("fromAsString")>]
        member _.FromAsString(state: Types.RangeBucket, value: string) =
            { state with FromAsString = Some value }

        [<CustomOperation("toAsString")>]
        member _.ToAsString(state: Types.RangeBucket, value: string) =
            { state with ToAsString = Some value }

        [<CustomOperation("key")>]
        member _.Key(state: Types.RangeBucket, value: string) =
            { state with Key = Some value }

    let rangeBucket = RangeBucketBuilder()

    type RareTermsAggregationBuilder() =
        member _.Yield(_: unit) : Types.RareTermsAggregation =
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
        member _.Exclude(state: Types.RareTermsAggregation, value: Types.TermsExclude) =
            { state with Exclude = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.RareTermsAggregation, value: Types.Field) =
            { state with Field = Some value }

        [<CustomOperation("include")>]
        member _.Include(state: Types.RareTermsAggregation, value: Types.TermsInclude) =
            { state with Include = Some value }

        [<CustomOperation("maxDocCount")>]
        member _.MaxDocCount(state: Types.RareTermsAggregation, value: Types.Long) =
            { state with MaxDocCount = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: Types.RareTermsAggregation, value: Types.Missing) =
            { state with Missing = Some value }

        [<CustomOperation("precision")>]
        member _.Precision(state: Types.RareTermsAggregation, value: Types.Double) =
            { state with Precision = Some value }

        [<CustomOperation("valueType")>]
        member _.ValueType(state: Types.RareTermsAggregation, value: string) =
            { state with ValueType = Some value }

    let rareTermsAggregation = RareTermsAggregationBuilder()

    type RateAggregationBuilder() =
        member _.Yield(_: unit) : Types.RateAggregation =
            {
                Unit = None
                Mode = None
            }

        [<CustomOperation("unit")>]
        member _.Unit(state: Types.RateAggregation, value: Types.CalendarInterval) =
            { state with Unit = Some value }

        [<CustomOperation("mode")>]
        member _.Mode(state: Types.RateAggregation, value: Types.RateMode) =
            { state with Mode = Some value }

    let rateAggregation = RateAggregationBuilder()

    type ScriptedMetricAggregationBuilder() =
        member _.Yield(_: unit) : Types.ScriptedMetricAggregation =
            {
                CombineScript = None
                InitScript = None
                MapScript = None
                Params = None
                ReduceScript = None
            }

        [<CustomOperation("combineScript")>]
        member _.CombineScript(state: Types.ScriptedMetricAggregation, value: Types.Script) =
            { state with CombineScript = Some value }

        [<CustomOperation("initScript")>]
        member _.InitScript(state: Types.ScriptedMetricAggregation, value: Types.Script) =
            { state with InitScript = Some value }

        [<CustomOperation("mapScript")>]
        member _.MapScript(state: Types.ScriptedMetricAggregation, value: Types.Script) =
            { state with MapScript = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: Types.ScriptedMetricAggregation, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("reduceScript")>]
        member _.ReduceScript(state: Types.ScriptedMetricAggregation, value: Types.Script) =
            { state with ReduceScript = Some value }

    let scriptedMetricAggregation = ScriptedMetricAggregationBuilder()

    type SignificantTermsAggregationBuilder() =
        member _.Yield(_: unit) : Types.SignificantTermsAggregation =
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
        member _.BackgroundFilter(state: Types.SignificantTermsAggregation, value: Types.QueryContainer) =
            { state with BackgroundFilter = Some value }

        [<CustomOperation("chiSquare")>]
        member _.ChiSquare(state: Types.SignificantTermsAggregation, value: Types.ChiSquareHeuristic) =
            { state with ChiSquare = Some value }

        [<CustomOperation("exclude")>]
        member _.Exclude(state: Types.SignificantTermsAggregation, value: Types.TermsExclude) =
            { state with Exclude = Some value }

        [<CustomOperation("executionHint")>]
        member _.ExecutionHint(state: Types.SignificantTermsAggregation, value: Types.TermsAggregationExecutionHint) =
            { state with ExecutionHint = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.SignificantTermsAggregation, value: Types.Field) =
            { state with Field = Some value }

        [<CustomOperation("gnd")>]
        member _.Gnd(state: Types.SignificantTermsAggregation, value: Types.GoogleNormalizedDistanceHeuristic) =
            { state with Gnd = Some value }

        [<CustomOperation("include")>]
        member _.Include(state: Types.SignificantTermsAggregation, value: Types.TermsInclude) =
            { state with Include = Some value }

        [<CustomOperation("jlh")>]
        member _.Jlh(state: Types.SignificantTermsAggregation, value: Types.EmptyObject) =
            { state with Jlh = Some value }

        [<CustomOperation("minDocCount")>]
        member _.MinDocCount(state: Types.SignificantTermsAggregation, value: Types.Long) =
            { state with MinDocCount = Some value }

        [<CustomOperation("mutualInformation")>]
        member _.MutualInformation(state: Types.SignificantTermsAggregation, value: Types.MutualInformationHeuristic) =
            { state with MutualInformation = Some value }

        [<CustomOperation("percentage")>]
        member _.Percentage(state: Types.SignificantTermsAggregation, value: Types.PercentageScoreHeuristic) =
            { state with Percentage = Some value }

        [<CustomOperation("scriptHeuristic")>]
        member _.ScriptHeuristic(state: Types.SignificantTermsAggregation, value: Types.ScriptedHeuristic) =
            { state with ScriptHeuristic = Some value }

        [<CustomOperation("pValue")>]
        member _.PValue(state: Types.SignificantTermsAggregation, value: Types.PValueHeuristic) =
            { state with PValue = Some value }

        [<CustomOperation("shardMinDocCount")>]
        member _.ShardMinDocCount(state: Types.SignificantTermsAggregation, value: Types.Long) =
            { state with ShardMinDocCount = Some value }

        [<CustomOperation("shardSize")>]
        member _.ShardSize(state: Types.SignificantTermsAggregation, value: Types.Integer) =
            { state with ShardSize = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.SignificantTermsAggregation, value: Types.Integer) =
            { state with Size = Some value }

    let significantTermsAggregation = SignificantTermsAggregationBuilder()

    type SignificantTextAggregationBuilder() =
        member _.Yield(_: unit) : Types.SignificantTextAggregation =
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
        member _.BackgroundFilter(state: Types.SignificantTextAggregation, value: Types.QueryContainer) =
            { state with BackgroundFilter = Some value }

        [<CustomOperation("chiSquare")>]
        member _.ChiSquare(state: Types.SignificantTextAggregation, value: Types.ChiSquareHeuristic) =
            { state with ChiSquare = Some value }

        [<CustomOperation("exclude")>]
        member _.Exclude(state: Types.SignificantTextAggregation, value: Types.TermsExclude) =
            { state with Exclude = Some value }

        [<CustomOperation("executionHint")>]
        member _.ExecutionHint(state: Types.SignificantTextAggregation, value: Types.TermsAggregationExecutionHint) =
            { state with ExecutionHint = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.SignificantTextAggregation, value: Types.Field) =
            { state with Field = Some value }

        [<CustomOperation("filterDuplicateText")>]
        member _.FilterDuplicateText(state: Types.SignificantTextAggregation, value: bool) =
            { state with FilterDuplicateText = Some value }

        [<CustomOperation("gnd")>]
        member _.Gnd(state: Types.SignificantTextAggregation, value: Types.GoogleNormalizedDistanceHeuristic) =
            { state with Gnd = Some value }

        [<CustomOperation("include")>]
        member _.Include(state: Types.SignificantTextAggregation, value: Types.TermsInclude) =
            { state with Include = Some value }

        [<CustomOperation("jlh")>]
        member _.Jlh(state: Types.SignificantTextAggregation, value: Types.EmptyObject) =
            { state with Jlh = Some value }

        [<CustomOperation("minDocCount")>]
        member _.MinDocCount(state: Types.SignificantTextAggregation, value: Types.Long) =
            { state with MinDocCount = Some value }

        [<CustomOperation("mutualInformation")>]
        member _.MutualInformation(state: Types.SignificantTextAggregation, value: Types.MutualInformationHeuristic) =
            { state with MutualInformation = Some value }

        [<CustomOperation("percentage")>]
        member _.Percentage(state: Types.SignificantTextAggregation, value: Types.PercentageScoreHeuristic) =
            { state with Percentage = Some value }

        [<CustomOperation("scriptHeuristic")>]
        member _.ScriptHeuristic(state: Types.SignificantTextAggregation, value: Types.ScriptedHeuristic) =
            { state with ScriptHeuristic = Some value }

        [<CustomOperation("shardMinDocCount")>]
        member _.ShardMinDocCount(state: Types.SignificantTextAggregation, value: Types.Long) =
            { state with ShardMinDocCount = Some value }

        [<CustomOperation("shardSize")>]
        member _.ShardSize(state: Types.SignificantTextAggregation, value: Types.Integer) =
            { state with ShardSize = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.SignificantTextAggregation, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("sourceFields")>]
        member _.SourceFields(state: Types.SignificantTextAggregation, value: Types.Fields) =
            { state with SourceFields = Some value }

    let significantTextAggregation = SignificantTextAggregationBuilder()

    type StatsAggregateBuilder() =
        member _.Yield(_: unit) : Types.StatsAggregate =
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
        member _.Count(state: Types.StatsAggregate, value: Types.Long) =
            { state with Count = value }

        [<CustomOperation("min")>]
        member _.Min(state: Types.StatsAggregate, value: Types.Double option) =
            { state with Min = value }

        [<CustomOperation("max")>]
        member _.Max(state: Types.StatsAggregate, value: Types.Double option) =
            { state with Max = value }

        [<CustomOperation("avg")>]
        member _.Avg(state: Types.StatsAggregate, value: Types.Double option) =
            { state with Avg = value }

        [<CustomOperation("sum")>]
        member _.Sum(state: Types.StatsAggregate, value: Types.Double) =
            { state with Sum = value }

        [<CustomOperation("minAsString")>]
        member _.MinAsString(state: Types.StatsAggregate, value: string) =
            { state with MinAsString = Some value }

        [<CustomOperation("maxAsString")>]
        member _.MaxAsString(state: Types.StatsAggregate, value: string) =
            { state with MaxAsString = Some value }

        [<CustomOperation("avgAsString")>]
        member _.AvgAsString(state: Types.StatsAggregate, value: string) =
            { state with AvgAsString = Some value }

        [<CustomOperation("sumAsString")>]
        member _.SumAsString(state: Types.StatsAggregate, value: string) =
            { state with SumAsString = Some value }

    let statsAggregate = StatsAggregateBuilder()

    type StringStatsAggregateBuilder() =
        member _.Yield(_: unit) : Types.StringStatsAggregate =
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
        member _.Count(state: Types.StringStatsAggregate, value: Types.Long) =
            { state with Count = value }

        [<CustomOperation("minLength")>]
        member _.MinLength(state: Types.StringStatsAggregate, value: Types.Integer option) =
            { state with MinLength = value }

        [<CustomOperation("maxLength")>]
        member _.MaxLength(state: Types.StringStatsAggregate, value: Types.Integer option) =
            { state with MaxLength = value }

        [<CustomOperation("avgLength")>]
        member _.AvgLength(state: Types.StringStatsAggregate, value: Types.Double option) =
            { state with AvgLength = value }

        [<CustomOperation("entropy")>]
        member _.Entropy(state: Types.StringStatsAggregate, value: Types.Double option) =
            { state with Entropy = value }

        [<CustomOperation("distribution")>]
        member _.Distribution(state: Types.StringStatsAggregate, value: Map<string, Types.Double> option) =
            { state with Distribution = Some value }

        [<CustomOperation("minLengthAsString")>]
        member _.MinLengthAsString(state: Types.StringStatsAggregate, value: string) =
            { state with MinLengthAsString = Some value }

        [<CustomOperation("maxLengthAsString")>]
        member _.MaxLengthAsString(state: Types.StringStatsAggregate, value: string) =
            { state with MaxLengthAsString = Some value }

        [<CustomOperation("avgLengthAsString")>]
        member _.AvgLengthAsString(state: Types.StringStatsAggregate, value: string) =
            { state with AvgLengthAsString = Some value }

    let stringStatsAggregate = StringStatsAggregateBuilder()

    type TDigestBuilder() =
        member _.Yield(_: unit) : Types.TDigest =
            {
                Compression = None
                ExecutionHint = None
            }

        [<CustomOperation("compression")>]
        member _.Compression(state: Types.TDigest, value: Types.Integer) =
            { state with Compression = Some value }

        [<CustomOperation("executionHint")>]
        member _.ExecutionHint(state: Types.TDigest, value: Types.TDigestExecutionHint) =
            { state with ExecutionHint = Some value }

    let tDigest = TDigestBuilder()

    type TTestAggregationBuilder() =
        member _.Yield(_: unit) : Types.TTestAggregation =
            {
                A = None
                B = None
                Type = None
            }

        [<CustomOperation("a")>]
        member _.A(state: Types.TTestAggregation, value: Types.TestPopulation) =
            { state with A = Some value }

        [<CustomOperation("b")>]
        member _.B(state: Types.TTestAggregation, value: Types.TestPopulation) =
            { state with B = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.TTestAggregation, value: Types.TTestType) =
            { state with Type = Some value }

    let tTestAggregation = TTestAggregationBuilder()

    type TermsAggregationBuilder() =
        member _.Yield(_: unit) : Types.TermsAggregation =
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
        member _.CollectMode(state: Types.TermsAggregation, value: Types.TermsAggregationCollectMode) =
            { state with CollectMode = Some value }

        [<CustomOperation("exclude")>]
        member _.Exclude(state: Types.TermsAggregation, value: Types.TermsExclude) =
            { state with Exclude = Some value }

        [<CustomOperation("executionHint")>]
        member _.ExecutionHint(state: Types.TermsAggregation, value: Types.TermsAggregationExecutionHint) =
            { state with ExecutionHint = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.TermsAggregation, value: Types.Field) =
            { state with Field = Some value }

        [<CustomOperation("include")>]
        member _.Include(state: Types.TermsAggregation, value: Types.TermsInclude) =
            { state with Include = Some value }

        [<CustomOperation("minDocCount")>]
        member _.MinDocCount(state: Types.TermsAggregation, value: Types.Integer) =
            { state with MinDocCount = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: Types.TermsAggregation, value: Types.Missing) =
            { state with Missing = Some value }

        [<CustomOperation("missingOrder")>]
        member _.MissingOrder(state: Types.TermsAggregation, value: Types.MissingOrder) =
            { state with MissingOrder = Some value }

        [<CustomOperation("missingBucket")>]
        member _.MissingBucket(state: Types.TermsAggregation, value: bool) =
            { state with MissingBucket = Some value }

        [<CustomOperation("valueType")>]
        member _.ValueType(state: Types.TermsAggregation, value: string) =
            { state with ValueType = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: Types.TermsAggregation, value: Types.AggregateOrder) =
            { state with Order = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.TermsAggregation, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("shardMinDocCount")>]
        member _.ShardMinDocCount(state: Types.TermsAggregation, value: Types.Long) =
            { state with ShardMinDocCount = Some value }

        [<CustomOperation("shardSize")>]
        member _.ShardSize(state: Types.TermsAggregation, value: Types.Integer) =
            { state with ShardSize = Some value }

        [<CustomOperation("showTermDocCountError")>]
        member _.ShowTermDocCountError(state: Types.TermsAggregation, value: bool) =
            { state with ShowTermDocCountError = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.TermsAggregation, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: Types.TermsAggregation, value: string) =
            { state with Format = Some value }

    let termsAggregation = TermsAggregationBuilder()

    type TestPopulationBuilder() =
        member _.Yield(_: unit) : Types.TestPopulation =
            {
                Field = Unchecked.defaultof<_>
                Script = None
                Filter = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.TestPopulation, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.TestPopulation, value: Types.Script) =
            { state with Script = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: Types.TestPopulation, value: Types.QueryContainer) =
            { state with Filter = Some value }

    let testPopulation = TestPopulationBuilder()

    type TimeSeriesAggregationBuilder() =
        member _.Yield(_: unit) : Types.TimeSeriesAggregation =
            {
                Size = None
                Keyed = None
            }

        [<CustomOperation("size")>]
        member _.Size(state: Types.TimeSeriesAggregation, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("keyed")>]
        member _.Keyed(state: Types.TimeSeriesAggregation, value: bool) =
            { state with Keyed = Some value }

    let timeSeriesAggregation = TimeSeriesAggregationBuilder()

    type TopHitsAggregationBuilder() =
        member _.Yield(_: unit) : Types.TopHitsAggregation =
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
        member _.DocvalueFields(state: Types.TopHitsAggregation, value: Types.FieldAndFormat list) =
            { state with DocvalueFields = Some value }

        [<CustomOperation("explain")>]
        member _.Explain(state: Types.TopHitsAggregation, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.TopHitsAggregation, value: Types.FieldAndFormat list) =
            { state with Fields = Some value }

        [<CustomOperation("from")>]
        member _.From(state: Types.TopHitsAggregation, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("highlight")>]
        member _.Highlight(state: Types.TopHitsAggregation, value: Types.Highlight) =
            { state with Highlight = Some value }

        [<CustomOperation("scriptFields")>]
        member _.ScriptFields(state: Types.TopHitsAggregation, value: Map<string, Types.ScriptField>) =
            { state with ScriptFields = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.TopHitsAggregation, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: Types.TopHitsAggregation, value: Types.Sort) =
            { state with Sort = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: Types.TopHitsAggregation, value: Types.SourceConfig) =
            { state with Source = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: Types.TopHitsAggregation, value: Types.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("trackScores")>]
        member _.TrackScores(state: Types.TopHitsAggregation, value: bool) =
            { state with TrackScores = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.TopHitsAggregation, value: bool) =
            { state with Version = Some value }

        [<CustomOperation("seqNoPrimaryTerm")>]
        member _.SeqNoPrimaryTerm(state: Types.TopHitsAggregation, value: bool) =
            { state with SeqNoPrimaryTerm = Some value }

    let topHitsAggregation = TopHitsAggregationBuilder()

    type TopMetricsAggregationBuilder() =
        member _.Yield(_: unit) : Types.TopMetricsAggregation =
            {
                Metrics = None
                Size = None
                Sort = None
            }

        [<CustomOperation("metrics")>]
        member _.Metrics(state: Types.TopMetricsAggregation, value: System.Text.Json.JsonElement) =
            { state with Metrics = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.TopMetricsAggregation, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: Types.TopMetricsAggregation, value: Types.Sort) =
            { state with Sort = Some value }

    let topMetricsAggregation = TopMetricsAggregationBuilder()

    type VariableWidthHistogramAggregationBuilder() =
        member _.Yield(_: unit) : Types.VariableWidthHistogramAggregation =
            {
                Field = None
                Buckets = None
                ShardSize = None
                InitialBuffer = None
                Script = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.VariableWidthHistogramAggregation, value: Types.Field) =
            { state with Field = Some value }

        [<CustomOperation("buckets")>]
        member _.Buckets(state: Types.VariableWidthHistogramAggregation, value: Types.Integer) =
            { state with Buckets = Some value }

        [<CustomOperation("shardSize")>]
        member _.ShardSize(state: Types.VariableWidthHistogramAggregation, value: Types.Integer) =
            { state with ShardSize = Some value }

        [<CustomOperation("initialBuffer")>]
        member _.InitialBuffer(state: Types.VariableWidthHistogramAggregation, value: Types.Integer) =
            { state with InitialBuffer = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.VariableWidthHistogramAggregation, value: Types.Script) =
            { state with Script = Some value }

    let variableWidthHistogramAggregation = VariableWidthHistogramAggregationBuilder()

    type VariableWidthHistogramBucketBuilder() =
        member _.Yield(_: unit) : Types.VariableWidthHistogramBucket =
            {
                Min = Unchecked.defaultof<_>
                Key = Unchecked.defaultof<_>
                Max = Unchecked.defaultof<_>
                MinAsString = None
                KeyAsString = None
                MaxAsString = None
            }

        [<CustomOperation("min")>]
        member _.Min(state: Types.VariableWidthHistogramBucket, value: Types.Double) =
            { state with Min = value }

        [<CustomOperation("key")>]
        member _.Key(state: Types.VariableWidthHistogramBucket, value: Types.Double) =
            { state with Key = value }

        [<CustomOperation("max")>]
        member _.Max(state: Types.VariableWidthHistogramBucket, value: Types.Double) =
            { state with Max = value }

        [<CustomOperation("minAsString")>]
        member _.MinAsString(state: Types.VariableWidthHistogramBucket, value: string) =
            { state with MinAsString = Some value }

        [<CustomOperation("keyAsString")>]
        member _.KeyAsString(state: Types.VariableWidthHistogramBucket, value: string) =
            { state with KeyAsString = Some value }

        [<CustomOperation("maxAsString")>]
        member _.MaxAsString(state: Types.VariableWidthHistogramBucket, value: string) =
            { state with MaxAsString = Some value }

    let variableWidthHistogramBucket = VariableWidthHistogramBucketBuilder()

    type WeightedAverageAggregationBuilder() =
        member _.Yield(_: unit) : Types.WeightedAverageAggregation =
            {
                Format = None
                Value = None
                ValueType = None
                Weight = None
            }

        [<CustomOperation("format")>]
        member _.Format(state: Types.WeightedAverageAggregation, value: string) =
            { state with Format = Some value }

        [<CustomOperation("value")>]
        member _.Value(state: Types.WeightedAverageAggregation, value: Types.WeightedAverageValue) =
            { state with Value = Some value }

        [<CustomOperation("valueType")>]
        member _.ValueType(state: Types.WeightedAverageAggregation, value: Types.ValueType) =
            { state with ValueType = Some value }

        [<CustomOperation("weight")>]
        member _.Weight(state: Types.WeightedAverageAggregation, value: Types.WeightedAverageValue) =
            { state with Weight = Some value }

    let weightedAverageAggregation = WeightedAverageAggregationBuilder()

    type WeightedAverageValueBuilder() =
        member _.Yield(_: unit) : Types.WeightedAverageValue =
            {
                Field = None
                Missing = None
                Script = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.WeightedAverageValue, value: Types.Field) =
            { state with Field = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: Types.WeightedAverageValue, value: Types.Double) =
            { state with Missing = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.WeightedAverageValue, value: Types.Script) =
            { state with Script = Some value }

    let weightedAverageValue = WeightedAverageValueBuilder()


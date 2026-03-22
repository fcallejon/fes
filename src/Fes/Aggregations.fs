namespace Fes

open Fes.DSL.Models.Types

/// Builder helpers for <see cref="AggregationsAggregationContainer"/>.
/// Since every field is optional, this module provides an <c>empty</c> baseline
/// value and named constructors so callers only need to specify the one
/// aggregation type they actually want.
///
/// Example (before):
/// <code>
///   let aggContainer : AggregationsAggregationContainer = {
///       Aggregations = None; Meta = None; AdjacencyMatrix = None; ...
///       Terms = Some termsAgg; ... (* 75+ more None fields *)
///   }
/// </code>
///
/// Example (after):
/// <code>
///   let aggContainer = AggregationContainer.terms termsAgg
/// </code>
[<RequireQualifiedAccess>]
module AggregationContainer =

    /// An <see cref="AggregationsAggregationContainer"/> with every field set to <c>None</c>.
    /// Use this as the base for record-update expressions when no named constructor
    /// covers your use-case.
    let empty: AggregationsAggregationContainer = {
        Aggregations = Option.None; Meta = Option.None; AdjacencyMatrix = Option.None
        AutoDateHistogram = Option.None; Avg = Option.None; AvgBucket = Option.None
        Boxplot = Option.None; BucketScript = Option.None; BucketSelector = Option.None
        BucketSort = Option.None; BucketCountKsTest = Option.None; BucketCorrelation = Option.None
        Cardinality = Option.None; CartesianBounds = Option.None; CartesianCentroid = Option.None
        CategorizeText = Option.None; ChangePoint = Option.None; Children = Option.None
        Composite = Option.None; CumulativeCardinality = Option.None; CumulativeSum = Option.None
        DateHistogram = Option.None; DateRange = Option.None; Derivative = Option.None
        DiversifiedSampler = Option.None; ExtendedStats = Option.None; ExtendedStatsBucket = Option.None
        FrequentItemSets = Option.None; Filter = Option.None; Filters = Option.None
        GeoBounds = Option.None; GeoCentroid = Option.None; GeoDistance = Option.None
        GeohashGrid = Option.None; GeoLine = Option.None; GeotileGrid = Option.None
        GeohexGrid = Option.None; Global = Option.None; Histogram = Option.None
        IpRange = Option.None; IpPrefix = Option.None; Inference = Option.None
        Line = Option.None; MatrixStats = Option.None; Max = Option.None; MaxBucket = Option.None
        MedianAbsoluteDeviation = Option.None; Min = Option.None; MinBucket = Option.None
        Missing = Option.None; MovingAvg = Option.None; MovingPercentiles = Option.None
        MovingFn = Option.None; MultiTerms = Option.None; Nested = Option.None; Normalize = Option.None
        Parent = Option.None; PercentileRanks = Option.None; Percentiles = Option.None
        PercentilesBucket = Option.None; RandomSampler = Option.None; Range = Option.None
        RareTerms = Option.None; Rate = Option.None; ReverseNested = Option.None
        Sampler = Option.None; ScriptedMetric = Option.None; SerialDiff = Option.None
        SignificantTerms = Option.None; SignificantText = Option.None; Stats = Option.None
        StatsBucket = Option.None; StringStats = Option.None; Sum = Option.None; SumBucket = Option.None
        Terms = Option.None; TimeSeries = Option.None; TopHits = Option.None; TTest = Option.None
        TopMetrics = Option.None; ValueCount = Option.None; WeightedAvg = Option.None
        VariableWidthHistogram = Option.None
    }

    // -------------------------------------------------------------------------
    // Named constructors — one per aggregation type
    // -------------------------------------------------------------------------

    let adjacencyMatrix agg  = { empty with AdjacencyMatrix = Some agg }
    let autoDateHistogram agg = { empty with AutoDateHistogram = Some agg }
    let avg agg              = { empty with Avg = Some agg }
    let avgBucket agg        = { empty with AvgBucket = Some agg }
    let boxplot agg          = { empty with Boxplot = Some agg }
    let bucketScript agg     = { empty with BucketScript = Some agg }
    let bucketSelector agg   = { empty with BucketSelector = Some agg }
    let bucketSort agg       = { empty with BucketSort = Some agg }
    let bucketCountKsTest agg = { empty with BucketCountKsTest = Some agg }
    let bucketCorrelation agg = { empty with BucketCorrelation = Some agg }
    let cardinality agg      = { empty with Cardinality = Some agg }
    let cartesianBounds agg  = { empty with CartesianBounds = Some agg }
    let cartesianCentroid agg = { empty with CartesianCentroid = Some agg }
    let categorizeText agg   = { empty with CategorizeText = Some agg }
    let changePoint agg      = { empty with ChangePoint = Some agg }
    let children agg         = { empty with Children = Some agg }
    let composite agg        = { empty with Composite = Some agg }
    let cumulativeCardinality agg = { empty with CumulativeCardinality = Some agg }
    let cumulativeSum agg    = { empty with CumulativeSum = Some agg }
    let dateHistogram agg    = { empty with DateHistogram = Some agg }
    let dateRange agg        = { empty with DateRange = Some agg }
    let derivative agg       = { empty with Derivative = Some agg }
    let diversifiedSampler agg = { empty with DiversifiedSampler = Some agg }
    let extendedStats agg    = { empty with ExtendedStats = Some agg }
    let extendedStatsBucket agg = { empty with ExtendedStatsBucket = Some agg }
    let frequentItemSets agg = { empty with FrequentItemSets = Some agg }
    let filter agg           = { empty with Filter = Some agg }
    let filters agg          = { empty with Filters = Some agg }
    let geoBounds agg        = { empty with GeoBounds = Some agg }
    let geoCentroid agg      = { empty with GeoCentroid = Some agg }
    let geoDistance agg      = { empty with GeoDistance = Some agg }
    let geohashGrid agg      = { empty with GeohashGrid = Some agg }
    let geoLine agg          = { empty with GeoLine = Some agg }
    let geotileGrid agg      = { empty with GeotileGrid = Some agg }
    let geohexGrid agg       = { empty with GeohexGrid = Some agg }
    let ``global`` agg       = { empty with Global = Some agg }
    let histogram agg        = { empty with Histogram = Some agg }
    let ipRange agg          = { empty with IpRange = Some agg }
    let ipPrefix agg         = { empty with IpPrefix = Some agg }
    let inference agg        = { empty with Inference = Some agg }
    let line agg             = { empty with Line = Some agg }
    let matrixStats agg      = { empty with MatrixStats = Some agg }
    let max agg              = { empty with Max = Some agg }
    let maxBucket agg        = { empty with MaxBucket = Some agg }
    let medianAbsoluteDeviation agg = { empty with MedianAbsoluteDeviation = Some agg }
    let min agg              = { empty with Min = Some agg }
    let minBucket agg        = { empty with MinBucket = Some agg }
    let missing agg          = { empty with Missing = Some agg }
    let movingAvg agg        = { empty with MovingAvg = Some agg }
    let movingPercentiles agg = { empty with MovingPercentiles = Some agg }
    let movingFn agg         = { empty with MovingFn = Some agg }
    let multiTerms agg       = { empty with MultiTerms = Some agg }
    let nested agg           = { empty with Nested = Some agg }
    let normalize agg        = { empty with Normalize = Some agg }
    let parent agg           = { empty with Parent = Some agg }
    let percentileRanks agg  = { empty with PercentileRanks = Some agg }
    let percentiles agg      = { empty with Percentiles = Some agg }
    let percentilesBucket agg = { empty with PercentilesBucket = Some agg }
    let range agg            = { empty with Range = Some agg }
    let rareTerms agg        = { empty with RareTerms = Some agg }
    let rate agg             = { empty with Rate = Some agg }
    let reverseNested agg    = { empty with ReverseNested = Some agg }
    let randomSampler agg    = { empty with RandomSampler = Some agg }
    let sampler agg          = { empty with Sampler = Some agg }
    let scriptedMetric agg   = { empty with ScriptedMetric = Some agg }
    let serialDiff agg       = { empty with SerialDiff = Some agg }
    let significantTerms agg = { empty with SignificantTerms = Some agg }
    let significantText agg  = { empty with SignificantText = Some agg }
    let stats agg            = { empty with Stats = Some agg }
    let statsBucket agg      = { empty with StatsBucket = Some agg }
    let stringStats agg      = { empty with StringStats = Some agg }
    let sum agg              = { empty with Sum = Some agg }
    let sumBucket agg        = { empty with SumBucket = Some agg }
    let terms agg            = { empty with Terms = Some agg }
    let timeSeries agg       = { empty with TimeSeries = Some agg }
    let topHits agg          = { empty with TopHits = Some agg }
    let tTest agg            = { empty with TTest = Some agg }
    let topMetrics agg       = { empty with TopMetrics = Some agg }
    let valueCount agg       = { empty with ValueCount = Some agg }
    let weightedAvg agg      = { empty with WeightedAvg = Some agg }
    let variableWidthHistogram agg = { empty with VariableWidthHistogram = Some agg }

    // -------------------------------------------------------------------------
    // Combinators
    // -------------------------------------------------------------------------

    /// Attaches sub-aggregations to an existing container.
    let withSubAggs (aggs: Map<string, AggregationsAggregationContainer>) (container: AggregationsAggregationContainer) =
        { container with Aggregations = Some aggs }

    /// Attaches metadata to an existing container.
    let withMeta (meta: Metadata) (container: AggregationsAggregationContainer) =
        { container with Meta = Some meta }

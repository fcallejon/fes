// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module TypesAggregations =

    type AbstractChangePoint = {
        [<System.Text.Json.Serialization.JsonPropertyName("p_value")>]
        PValue: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("change_point")>]
        ChangePoint: Types.Integer
    }

    /// Aggregation buckets. By default they are returned as an array, but if the aggregation has keys configured for
    [<RequireQualifiedAccess>]
    type Buckets<'tBucket> =
        | Dictionary of Map<string, 'tBucket>
        | Array of 'tBucket list

    type AggregateBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("meta")>]
        Meta: Types.Metadata option
    }

    type MultiBucketAggregateBase<'tBucket> = {
        [<System.Text.Json.Serialization.JsonPropertyName("buckets")>]
        Buckets: TypesAggregations.Buckets<'tBucket>
    }

    /// Base type for multi-bucket aggregation results that can hold sub-aggregations results.
    type MultiBucketBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc_count")>]
        DocCount: Types.Long
    }

    type AdjacencyMatrixBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: string
    }

    type AdjacencyMatrixAggregate = System.Text.Json.JsonElement

    type Aggregation = System.Text.Json.JsonElement

    /// Base type for bucket aggregations. These aggregations also accept sub-aggregations.
    type BucketAggregationBase = System.Text.Json.JsonElement

    type AdjacencyMatrixAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("filters")>]
        Filters: Map<string, TypesQueryDsl.QueryContainer> option
        [<System.Text.Json.Serialization.JsonPropertyName("separator")>]
        Separator: string option
    }

    type CardinalityAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: Types.Long
    }

    type KeyedPercentiles = Map<string, System.Text.Json.JsonElement>

    type ArrayPercentilesItem = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("value_as_string")>]
        ValueAsString: string option
    }

    [<RequireQualifiedAccess>]
    type Percentiles =
        | KeyedPercentiles of TypesAggregations.KeyedPercentiles
        | Array of TypesAggregations.ArrayPercentilesItem list

    type PercentilesAggregateBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("values")>]
        Values: TypesAggregations.Percentiles
    }

    type HdrPercentilesAggregate = System.Text.Json.JsonElement

    type HdrPercentileRanksAggregate = System.Text.Json.JsonElement

    type TDigestPercentilesAggregate = System.Text.Json.JsonElement

    type TDigestPercentileRanksAggregate = System.Text.Json.JsonElement

    type PercentilesBucketAggregate = System.Text.Json.JsonElement

    type SingleMetricAggregateBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: Types.Double option
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
        NormalizedValue: Types.Double option
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
        PValue: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("r_value")>]
        RValue: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("trend")>]
        Trend: string
    }

    type Spike = System.Text.Json.JsonElement

    type Stationary = System.Text.Json.JsonElement

    type StepChange = System.Text.Json.JsonElement

    type TrendChange = {
        [<System.Text.Json.Serialization.JsonPropertyName("p_value")>]
        PValue: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("r_value")>]
        RValue: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("change_point")>]
        ChangePoint: Types.Integer
    }

    [<RequireQualifiedAccess>]
    type ChangeType =
        | Dip of TypesAggregations.Dip
        | DistributionChange of TypesAggregations.DistributionChange
        | Indeterminable of TypesAggregations.Indeterminable
        | NonStationary of TypesAggregations.NonStationary
        | Spike of TypesAggregations.Spike
        | Stationary of TypesAggregations.Stationary
        | StepChange of TypesAggregations.StepChange
        | TrendChange of TypesAggregations.TrendChange

    type ChangePointBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: Types.FieldValue
    }

    type ChangePointAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: TypesAggregations.ChangeType
        [<System.Text.Json.Serialization.JsonPropertyName("bucket")>]
        Bucket: TypesAggregations.ChangePointBucket option
    }

    /// Statistics aggregation result. `min`, `max` and `avg` are missing if there were no values to process
    type StatsAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("min")>]
        Min: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("avg")>]
        Avg: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("sum")>]
        Sum: Types.Double
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
        Upper: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("lower")>]
        Lower: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("upper_population")>]
        UpperPopulation: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("lower_population")>]
        LowerPopulation: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("upper_sampling")>]
        UpperSampling: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("lower_sampling")>]
        LowerSampling: Types.Double option
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
        SumOfSquares: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("variance")>]
        Variance: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("variance_population")>]
        VariancePopulation: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("variance_sampling")>]
        VarianceSampling: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("std_deviation")>]
        StdDeviation: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("std_deviation_population")>]
        StdDeviationPopulation: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("std_deviation_sampling")>]
        StdDeviationSampling: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("std_deviation_bounds")>]
        StdDeviationBounds: TypesAggregations.StandardDeviationBounds option
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
        StdDeviationBoundsAsString: TypesAggregations.StandardDeviationBoundsAsString option
    }

    type ExtendedStatsBucketAggregate = System.Text.Json.JsonElement

    type CartesianBoundsAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("bounds")>]
        Bounds: Types.TopLeftBottomRightGeoBounds option
    }

    type CartesianCentroidAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("location")>]
        Location: Types.CartesianPoint option
    }

    type GeoBoundsAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("bounds")>]
        Bounds: Types.GeoBounds option
    }

    type GeoCentroidAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("location")>]
        Location: Types.GeoLocation option
    }

    type HistogramBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key_as_string")>]
        KeyAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: Types.Double
    }

    type HistogramAggregate = System.Text.Json.JsonElement

    type DateHistogramBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key_as_string")>]
        KeyAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: Types.EpochTime<Types.UnitMillis>
    }

    type DateHistogramAggregate = System.Text.Json.JsonElement

    type AutoDateHistogramAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("interval")>]
        Interval: Types.DurationLarge
    }

    type VariableWidthHistogramBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("min")>]
        Min: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: Types.Double
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
        DocCountErrorUpperBound: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("sum_other_doc_count")>]
        SumOtherDocCount: Types.Long option
    }

    type TermsBucketBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc_count_error_upper_bound")>]
        DocCountErrorUpperBound: Types.Long option
    }

    type StringTermsBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: Types.FieldValue
    }

    /// Result of a `terms` aggregation when the field is a string.
    type StringTermsAggregate = System.Text.Json.JsonElement

    type LongTermsBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("key_as_string")>]
        KeyAsString: string option
    }

    /// Result of a `terms` aggregation when the field is some kind of whole number like a integer, long, or a date.
    type LongTermsAggregate = System.Text.Json.JsonElement

    type DoubleTermsBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("key_as_string")>]
        KeyAsString: string option
    }

    /// Result of a `terms` aggregation when the field is some kind of decimal number like a float, double, or distance.
    type DoubleTermsAggregate = System.Text.Json.JsonElement

    /// Result of a `terms` aggregation when the field is unmapped. `buckets` is always empty.
    type UnmappedTermsAggregate = System.Text.Json.JsonElement

    type LongRareTermsBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: Types.Long
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
        Key: Types.FieldValue list
        [<System.Text.Json.Serialization.JsonPropertyName("key_as_string")>]
        KeyAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("doc_count_error_upper_bound")>]
        DocCountErrorUpperBound: Types.Long option
    }

    type MultiTermsAggregate = System.Text.Json.JsonElement

    /// Base type for single-bucket aggregation results that can hold sub-aggregations results.
    type SingleBucketAggregateBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc_count")>]
        DocCount: Types.Long
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
        Key: Types.GeoHash
    }

    type GeoHashGridAggregate = System.Text.Json.JsonElement

    type GeoTileGridBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: Types.GeoTile
    }

    type GeoTileGridAggregate = System.Text.Json.JsonElement

    type GeoHexGridBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: Types.GeoHexCell
    }

    type GeoHexGridAggregate = System.Text.Json.JsonElement

    type RangeBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        From: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("to")>]
        To: Types.Double option
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
        PrefixLength: Types.Integer
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
        BgCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("doc_count")>]
        DocCount: Types.Long option
    }

    type SignificantTermsBucketBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("score")>]
        Score: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("bg_count")>]
        BgCount: Types.Long
    }

    type SignificantLongTermsBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: Types.Long
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

    type CompositeAggregateKey = Map<Types.Field, Types.FieldValue>

    type CompositeBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: TypesAggregations.CompositeAggregateKey
    }

    type CompositeAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("after_key")>]
        AfterKey: TypesAggregations.CompositeAggregateKey option
    }

    type FrequentItemSetsBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: Map<Types.Field, string list>
        [<System.Text.Json.Serialization.JsonPropertyName("support")>]
        Support: Types.Double
    }

    type FrequentItemSetsAggregate = System.Text.Json.JsonElement

    type TimeSeriesBucket = {
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: Map<Types.Field, Types.FieldValue>
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
        Importance: Types.Double
    }

    type InferenceFeatureImportance = {
        [<System.Text.Json.Serialization.JsonPropertyName("feature_name")>]
        FeatureName: string
        [<System.Text.Json.Serialization.JsonPropertyName("importance")>]
        Importance: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("classes")>]
        Classes: TypesAggregations.InferenceClassImportance list option
    }

    type InferenceTopClassEntry = {
        [<System.Text.Json.Serialization.JsonPropertyName("class_name")>]
        ClassName: Types.FieldValue
        [<System.Text.Json.Serialization.JsonPropertyName("class_probability")>]
        ClassProbability: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("class_score")>]
        ClassScore: Types.Double
    }

    type InferenceAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: Types.FieldValue option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_importance")>]
        FeatureImportance: TypesAggregations.InferenceFeatureImportance list option
        [<System.Text.Json.Serialization.JsonPropertyName("top_classes")>]
        TopClasses: TypesAggregations.InferenceTopClassEntry list option
        [<System.Text.Json.Serialization.JsonPropertyName("warning")>]
        Warning: string option
    }

    type StringStatsAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("min_length")>]
        MinLength: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_length")>]
        MaxLength: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("avg_length")>]
        AvgLength: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("entropy")>]
        Entropy: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("distribution")>]
        Distribution: Map<string, Types.Double> option option
        [<System.Text.Json.Serialization.JsonPropertyName("min_length_as_string")>]
        MinLengthAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_length_as_string")>]
        MaxLengthAsString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("avg_length_as_string")>]
        AvgLengthAsString: string option
    }

    type BoxPlotAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("min")>]
        Min: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("q1")>]
        Q1: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("q2")>]
        Q2: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("q3")>]
        Q3: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("lower")>]
        Lower: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("upper")>]
        Upper: Types.Double
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
        Sort: Types.FieldValue option list
        [<System.Text.Json.Serialization.JsonPropertyName("metrics")>]
        Metrics: Map<string, Types.FieldValue option>
    }

    type TopMetricsAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("top")>]
        Top: TypesAggregations.TopMetrics list
    }

    type TTestAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("value_as_string")>]
        ValueAsString: string option
    }

    type RateAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("value_as_string")>]
        ValueAsString: string option
    }

    /// Result of the `cumulative_cardinality` aggregation
    type CumulativeCardinalityAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("value_as_string")>]
        ValueAsString: string option
    }

    type MatrixStatsFields = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("mean")>]
        Mean: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("variance")>]
        Variance: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("skewness")>]
        Skewness: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("kurtosis")>]
        Kurtosis: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("covariance")>]
        Covariance: Map<Types.Field, Types.Double>
        [<System.Text.Json.Serialization.JsonPropertyName("correlation")>]
        Correlation: Map<Types.Field, Types.Double>
    }

    type MatrixStatsAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc_count")>]
        DocCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: TypesAggregations.MatrixStatsFields list option
    }

    type GeoLineAggregate = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("geometry")>]
        Geometry: Types.GeoLine
        [<System.Text.Json.Serialization.JsonPropertyName("properties")>]
        Properties: System.Text.Json.JsonElement
    }

    [<RequireQualifiedAccess>]
    type Aggregate =
        | CardinalityAggregate of TypesAggregations.CardinalityAggregate
        | HdrPercentilesAggregate of TypesAggregations.HdrPercentilesAggregate
        | HdrPercentileRanksAggregate of TypesAggregations.HdrPercentileRanksAggregate
        | TDigestPercentilesAggregate of TypesAggregations.TDigestPercentilesAggregate
        | TDigestPercentileRanksAggregate of TypesAggregations.TDigestPercentileRanksAggregate
        | PercentilesBucketAggregate of TypesAggregations.PercentilesBucketAggregate
        | MedianAbsoluteDeviationAggregate of TypesAggregations.MedianAbsoluteDeviationAggregate
        | MinAggregate of TypesAggregations.MinAggregate
        | MaxAggregate of TypesAggregations.MaxAggregate
        | SumAggregate of TypesAggregations.SumAggregate
        | AvgAggregate of TypesAggregations.AvgAggregate
        | WeightedAvgAggregate of TypesAggregations.WeightedAvgAggregate
        | ValueCountAggregate of TypesAggregations.ValueCountAggregate
        | SimpleValueAggregate of TypesAggregations.SimpleValueAggregate
        | DerivativeAggregate of TypesAggregations.DerivativeAggregate
        | BucketMetricValueAggregate of TypesAggregations.BucketMetricValueAggregate
        | ChangePointAggregate of TypesAggregations.ChangePointAggregate
        | StatsAggregate of TypesAggregations.StatsAggregate
        | StatsBucketAggregate of TypesAggregations.StatsBucketAggregate
        | ExtendedStatsAggregate of TypesAggregations.ExtendedStatsAggregate
        | ExtendedStatsBucketAggregate of TypesAggregations.ExtendedStatsBucketAggregate
        | CartesianBoundsAggregate of TypesAggregations.CartesianBoundsAggregate
        | CartesianCentroidAggregate of TypesAggregations.CartesianCentroidAggregate
        | GeoBoundsAggregate of TypesAggregations.GeoBoundsAggregate
        | GeoCentroidAggregate of TypesAggregations.GeoCentroidAggregate
        | HistogramAggregate of TypesAggregations.HistogramAggregate
        | DateHistogramAggregate of TypesAggregations.DateHistogramAggregate
        | AutoDateHistogramAggregate of TypesAggregations.AutoDateHistogramAggregate
        | VariableWidthHistogramAggregate of TypesAggregations.VariableWidthHistogramAggregate
        | StringTermsAggregate of TypesAggregations.StringTermsAggregate
        | LongTermsAggregate of TypesAggregations.LongTermsAggregate
        | DoubleTermsAggregate of TypesAggregations.DoubleTermsAggregate
        | UnmappedTermsAggregate of TypesAggregations.UnmappedTermsAggregate
        | LongRareTermsAggregate of TypesAggregations.LongRareTermsAggregate
        | StringRareTermsAggregate of TypesAggregations.StringRareTermsAggregate
        | UnmappedRareTermsAggregate of TypesAggregations.UnmappedRareTermsAggregate
        | MultiTermsAggregate of TypesAggregations.MultiTermsAggregate
        | MissingAggregate of TypesAggregations.MissingAggregate
        | NestedAggregate of TypesAggregations.NestedAggregate
        | ReverseNestedAggregate of TypesAggregations.ReverseNestedAggregate
        | GlobalAggregate of TypesAggregations.GlobalAggregate
        | FilterAggregate of TypesAggregations.FilterAggregate
        | ChildrenAggregate of TypesAggregations.ChildrenAggregate
        | ParentAggregate of TypesAggregations.ParentAggregate
        | SamplerAggregate of TypesAggregations.SamplerAggregate
        | UnmappedSamplerAggregate of TypesAggregations.UnmappedSamplerAggregate
        | GeoHashGridAggregate of TypesAggregations.GeoHashGridAggregate
        | GeoTileGridAggregate of TypesAggregations.GeoTileGridAggregate
        | GeoHexGridAggregate of TypesAggregations.GeoHexGridAggregate
        | RangeAggregate of TypesAggregations.RangeAggregate
        | DateRangeAggregate of TypesAggregations.DateRangeAggregate
        | GeoDistanceAggregate of TypesAggregations.GeoDistanceAggregate
        | IpRangeAggregate of TypesAggregations.IpRangeAggregate
        | IpPrefixAggregate of TypesAggregations.IpPrefixAggregate
        | FiltersAggregate of TypesAggregations.FiltersAggregate
        | AdjacencyMatrixAggregate of TypesAggregations.AdjacencyMatrixAggregate
        | SignificantLongTermsAggregate of TypesAggregations.SignificantLongTermsAggregate
        | SignificantStringTermsAggregate of TypesAggregations.SignificantStringTermsAggregate
        | UnmappedSignificantTermsAggregate of TypesAggregations.UnmappedSignificantTermsAggregate
        | CompositeAggregate of TypesAggregations.CompositeAggregate
        | FrequentItemSetsAggregate of TypesAggregations.FrequentItemSetsAggregate
        | TimeSeriesAggregate of TypesAggregations.TimeSeriesAggregate
        | ScriptedMetricAggregate of TypesAggregations.ScriptedMetricAggregate
        | TopHitsAggregate of TypesAggregations.TopHitsAggregate
        | InferenceAggregate of TypesAggregations.InferenceAggregate
        | StringStatsAggregate of TypesAggregations.StringStatsAggregate
        | BoxPlotAggregate of TypesAggregations.BoxPlotAggregate
        | TopMetricsAggregate of TypesAggregations.TopMetricsAggregate
        | TTestAggregate of TypesAggregations.TTestAggregate
        | RateAggregate of TypesAggregations.RateAggregate
        | CumulativeCardinalityAggregate of TypesAggregations.CumulativeCardinalityAggregate
        | MatrixStatsAggregate of TypesAggregations.MatrixStatsAggregate
        | GeoLineAggregate of TypesAggregations.GeoLineAggregate

    [<RequireQualifiedAccess>]
    type AggregateOrder =
        | Dictionary of Map<Types.Field, Types.SortOrder>
        | Array of Map<Types.Field, Types.SortOrder> list

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
        Buckets: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_interval")>]
        MinimumInterval: TypesAggregations.MinimumInterval option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("offset")>]
        Offset: string option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("time_zone")>]
        TimeZone: Types.TimeZone option
    }

    [<RequireQualifiedAccess>]
    type Missing =
        | String of string
        | Integer of Types.Integer
        | Double of Types.Double
        | Boolean of bool

    type MetricAggregationBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: TypesAggregations.Missing option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
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
        BucketsPath: TypesAggregations.BucketsPath option
    }

    type PipelineAggregationBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("gap_policy")>]
        GapPolicy: TypesAggregations.GapPolicy option
    }

    type AverageBucketAggregation = System.Text.Json.JsonElement

    [<RequireQualifiedAccess>]
    type TDigestExecutionHint =
        | Default
        | HighAccuracy

    type BoxplotAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("compression")>]
        Compression: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("execution_hint")>]
        ExecutionHint: TypesAggregations.TDigestExecutionHint option
    }

    type BucketScriptAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
    }

    type BucketSelectorAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
    }

    type BucketSortAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        From: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("gap_policy")>]
        GapPolicy: TypesAggregations.GapPolicy option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: Types.Sort option
    }

    /// A sibling pipeline aggregation which executes a two sample Kolmogorov–Smirnov test (referred
    type BucketKsAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("alternative")>]
        Alternative: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("fractions")>]
        Fractions: Types.Double list option
        [<System.Text.Json.Serialization.JsonPropertyName("sampling_method")>]
        SamplingMethod: string option
    }

    type BucketCorrelationFunctionCountCorrelationIndicator = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc_count")>]
        DocCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("expectations")>]
        Expectations: Types.Double list
        [<System.Text.Json.Serialization.JsonPropertyName("fractions")>]
        Fractions: Types.Double list option
    }

    type BucketCorrelationFunctionCountCorrelation = {
        [<System.Text.Json.Serialization.JsonPropertyName("indicator")>]
        Indicator: TypesAggregations.BucketCorrelationFunctionCountCorrelationIndicator
    }

    type BucketCorrelationFunction = {
        [<System.Text.Json.Serialization.JsonPropertyName("count_correlation")>]
        CountCorrelation: TypesAggregations.BucketCorrelationFunctionCountCorrelation
    }

    /// A sibling pipeline aggregation which executes a correlation function on the configured sibling multi-bucket aggregation.
    type BucketCorrelationAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("function")>]
        Function: TypesAggregations.BucketCorrelationFunction
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
        PrecisionThreshold: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("rehash")>]
        Rehash: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("execution_hint")>]
        ExecutionHint: TypesAggregations.CardinalityExecutionMode option
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
        | CustomCategorizeTextAnalyzer of TypesAggregations.CustomCategorizeTextAnalyzer

    /// A multi-bucket aggregation that groups semi-structured text into buckets. Each text
    type CategorizeTextAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("max_unique_tokens")>]
        MaxUniqueTokens: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_matched_tokens")>]
        MaxMatchedTokens: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("similarity_threshold")>]
        SimilarityThreshold: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_filters")>]
        CategorizationFilters: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_analyzer")>]
        CategorizationAnalyzer: TypesAggregations.CategorizeTextAnalyzer option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_count")>]
        MinDocCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_min_doc_count")>]
        ShardMinDocCount: Types.Integer option
    }

    type ChangePointAggregation = System.Text.Json.JsonElement

    type ChildrenAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: Types.RelationName option
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
        Field: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("missing_bucket")>]
        MissingBucket: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("missing_order")>]
        MissingOrder: TypesAggregations.MissingOrder option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("value_type")>]
        ValueType: TypesAggregations.ValueType option
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: Types.SortOrder option
    }

    type CompositeTermsAggregation = System.Text.Json.JsonElement

    type CompositeHistogramAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("interval")>]
        Interval: Types.Double
    }

    type CompositeDateHistogramAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("calendar_interval")>]
        CalendarInterval: Types.DurationLarge option
        [<System.Text.Json.Serialization.JsonPropertyName("fixed_interval")>]
        FixedInterval: Types.DurationLarge option
        [<System.Text.Json.Serialization.JsonPropertyName("offset")>]
        Offset: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("time_zone")>]
        TimeZone: Types.TimeZone option
    }

    type CompositeGeoTileGridAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("precision")>]
        Precision: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("bounds")>]
        Bounds: Types.GeoBounds option
    }

    [<RequireQualifiedAccess>]
    type CompositeAggregationSource =
        | Terms of TypesAggregations.CompositeTermsAggregation
        | Histogram of TypesAggregations.CompositeHistogramAggregation
        | DateHistogram of TypesAggregations.CompositeDateHistogramAggregation
        | GeotileGrid of TypesAggregations.CompositeGeoTileGridAggregation

    type CompositeAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("after")>]
        After: TypesAggregations.CompositeAggregateKey option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("sources")>]
        Sources: Map<string, TypesAggregations.CompositeAggregationSource> list option
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
        | DateMath of Types.DateMath
        | Double of Types.Double

    type DateHistogramAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("calendar_interval")>]
        CalendarInterval: TypesAggregations.CalendarInterval option
        [<System.Text.Json.Serialization.JsonPropertyName("extended_bounds")>]
        ExtendedBounds: TypesAggregations.ExtendedBounds<TypesAggregations.FieldDateMath> option
        [<System.Text.Json.Serialization.JsonPropertyName("hard_bounds")>]
        HardBounds: TypesAggregations.ExtendedBounds<TypesAggregations.FieldDateMath> option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("fixed_interval")>]
        FixedInterval: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("interval")>]
        Interval: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_count")>]
        MinDocCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("offset")>]
        Offset: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: TypesAggregations.AggregateOrder option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("time_zone")>]
        TimeZone: Types.TimeZone option
        [<System.Text.Json.Serialization.JsonPropertyName("keyed")>]
        Keyed: bool option
    }

    type DateRangeExpression = {
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        From: TypesAggregations.FieldDateMath option
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: string option
        [<System.Text.Json.Serialization.JsonPropertyName("to")>]
        To: TypesAggregations.FieldDateMath option
    }

    type DateRangeAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: TypesAggregations.Missing option
        [<System.Text.Json.Serialization.JsonPropertyName("ranges")>]
        Ranges: TypesAggregations.DateRangeExpression list option
        [<System.Text.Json.Serialization.JsonPropertyName("time_zone")>]
        TimeZone: Types.TimeZone option
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
        ExecutionHint: TypesAggregations.SamplerAggregationExecutionHint option
        [<System.Text.Json.Serialization.JsonPropertyName("max_docs_per_value")>]
        MaxDocsPerValue: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field option
    }

    type ExtendedStatsAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("sigma")>]
        Sigma: Types.Double option
    }

    type ExtendedStatsBucketAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("sigma")>]
        Sigma: Types.Double option
    }

    [<RequireQualifiedAccess>]
    type TermsExclude =
        | String of string
        | Array of string list

    type TermsPartition = {
        [<System.Text.Json.Serialization.JsonPropertyName("num_partitions")>]
        NumPartitions: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("partition")>]
        Partition: Types.Long
    }

    [<RequireQualifiedAccess>]
    type TermsInclude =
        | String of string
        | Array of string list
        | TermsPartition of TypesAggregations.TermsPartition

    type FrequentItemSetsField = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("exclude")>]
        Exclude: TypesAggregations.TermsExclude option
        [<System.Text.Json.Serialization.JsonPropertyName("include")>]
        Include: TypesAggregations.TermsInclude option
    }

    type FrequentItemSetsAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: TypesAggregations.FrequentItemSetsField list
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_set_size")>]
        MinimumSetSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_support")>]
        MinimumSupport: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: TypesQueryDsl.QueryContainer option
    }

    type FiltersAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("filters")>]
        Filters: TypesAggregations.Buckets<TypesQueryDsl.QueryContainer> option
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
        Count: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("location")>]
        Location: Types.GeoLocation option
    }

    type AggregationRange = {
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        From: Types.Double option option
        [<System.Text.Json.Serialization.JsonPropertyName("key")>]
        Key: string option
        [<System.Text.Json.Serialization.JsonPropertyName("to")>]
        To: Types.Double option option
    }

    type GeoDistanceAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("distance_type")>]
        DistanceType: Types.GeoDistanceType option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("origin")>]
        Origin: Types.GeoLocation option
        [<System.Text.Json.Serialization.JsonPropertyName("ranges")>]
        Ranges: TypesAggregations.AggregationRange list option
        [<System.Text.Json.Serialization.JsonPropertyName("unit")>]
        Unit: Types.DistanceUnit option
    }

    type GeoHashGridAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("bounds")>]
        Bounds: Types.GeoBounds option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("precision")>]
        Precision: Types.GeoHashPrecision option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
    }

    type GeoLinePoint = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
    }

    type GeoLineSort = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
    }

    type GeoLineAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("point")>]
        Point: TypesAggregations.GeoLinePoint
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: TypesAggregations.GeoLineSort option
        [<System.Text.Json.Serialization.JsonPropertyName("include_sort")>]
        IncludeSort: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("sort_order")>]
        SortOrder: Types.SortOrder option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
    }

    type GeoTileGridAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("precision")>]
        Precision: Types.GeoTilePrecision option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("bounds")>]
        Bounds: Types.GeoBounds option
    }

    type GeohexGridAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("precision")>]
        Precision: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("bounds")>]
        Bounds: Types.GeoBounds option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: Types.Integer option
    }

    type GlobalAggregation = System.Text.Json.JsonElement

    type HistogramAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("extended_bounds")>]
        ExtendedBounds: TypesAggregations.ExtendedBounds<Types.Double> option
        [<System.Text.Json.Serialization.JsonPropertyName("hard_bounds")>]
        HardBounds: TypesAggregations.ExtendedBounds<Types.Double> option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("interval")>]
        Interval: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_count")>]
        MinDocCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("offset")>]
        Offset: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: TypesAggregations.AggregateOrder option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
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
        Field: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("ranges")>]
        Ranges: TypesAggregations.IpRangeAggregationRange list option
    }

    type IpPrefixAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("prefix_length")>]
        PrefixLength: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("is_ipv6")>]
        IsIpv6: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("append_prefix_length")>]
        AppendPrefixLength: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("keyed")>]
        Keyed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_count")>]
        MinDocCount: Types.Long option
    }

    [<RequireQualifiedAccess>]
    type InferenceConfigContainer =
        | Regression of MlTypes.RegressionInferenceOptions
        | Classification of MlTypes.ClassificationInferenceOptions

    type InferenceAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("inference_config")>]
        InferenceConfig: TypesAggregations.InferenceConfigContainer option
    }

    type MatrixAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Types.Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: Map<Types.Field, Types.Double> option
    }

    type MatrixStatsAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: Types.SortMode option
    }

    type MaxAggregation = System.Text.Json.JsonElement

    type MaxBucketAggregation = System.Text.Json.JsonElement

    type MedianAbsoluteDeviationAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("compression")>]
        Compression: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("execution_hint")>]
        ExecutionHint: TypesAggregations.TDigestExecutionHint option
    }

    type MinAggregation = System.Text.Json.JsonElement

    type MinBucketAggregation = System.Text.Json.JsonElement

    type MissingAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: TypesAggregations.Missing option
    }

    type MovingAverageAggregationBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("minimize")>]
        Minimize: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("predict")>]
        Predict: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("window")>]
        Window: Types.Integer option
    }

    type LinearMovingAverageAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("model")>]
        Model: string
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: Types.EmptyObject
    }

    type SimpleMovingAverageAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("model")>]
        Model: string
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: Types.EmptyObject
    }

    type EwmaModelSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("alpha")>]
        Alpha: Types.Float option
    }

    type EwmaMovingAverageAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("model")>]
        Model: string
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: TypesAggregations.EwmaModelSettings
    }

    type HoltLinearModelSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("alpha")>]
        Alpha: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("beta")>]
        Beta: Types.Float option
    }

    type HoltMovingAverageAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("model")>]
        Model: string
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: TypesAggregations.HoltLinearModelSettings
    }

    [<RequireQualifiedAccess>]
    type HoltWintersType =
        | Add
        | Mult

    type HoltWintersModelSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("alpha")>]
        Alpha: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("beta")>]
        Beta: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("gamma")>]
        Gamma: Types.Float option
        [<System.Text.Json.Serialization.JsonPropertyName("pad")>]
        Pad: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("period")>]
        Period: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: TypesAggregations.HoltWintersType option
    }

    type HoltWintersMovingAverageAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("model")>]
        Model: string
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: TypesAggregations.HoltWintersModelSettings
    }

    [<RequireQualifiedAccess>]
    type MovingAverageAggregation =
        | LinearMovingAverageAggregation of TypesAggregations.LinearMovingAverageAggregation
        | SimpleMovingAverageAggregation of TypesAggregations.SimpleMovingAverageAggregation
        | EwmaMovingAverageAggregation of TypesAggregations.EwmaMovingAverageAggregation
        | HoltMovingAverageAggregation of TypesAggregations.HoltMovingAverageAggregation
        | HoltWintersMovingAverageAggregation of TypesAggregations.HoltWintersMovingAverageAggregation

    type MovingPercentilesAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("window")>]
        Window: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("shift")>]
        Shift: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("keyed")>]
        Keyed: bool option
    }

    type MovingFunctionAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: string option
        [<System.Text.Json.Serialization.JsonPropertyName("shift")>]
        Shift: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("window")>]
        Window: Types.Integer option
    }

    [<RequireQualifiedAccess>]
    type TermsAggregationCollectMode =
        | DepthFirst
        | BreadthFirst

    [<RequireQualifiedAccess>]
    type MultiTermLookup =
        | Field of Types.Field
        | Script of Types.Script

    and MultiTermLookupMeta = {
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: TypesAggregations.Missing option
    }

    type MultiTermsAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("collect_mode")>]
        CollectMode: TypesAggregations.TermsAggregationCollectMode option
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: TypesAggregations.AggregateOrder option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_count")>]
        MinDocCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_min_doc_count")>]
        ShardMinDocCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("show_term_doc_count_error")>]
        ShowTermDocCountError: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("terms")>]
        Terms: TypesAggregations.MultiTermLookup list
    }

    type NestedAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: Types.Field option
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
        Method: TypesAggregations.NormalizeMethod option
    }

    type ParentAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: Types.RelationName option
    }

    type HdrMethod = {
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_significant_value_digits")>]
        NumberOfSignificantValueDigits: Types.Integer option
    }

    type TDigest = {
        [<System.Text.Json.Serialization.JsonPropertyName("compression")>]
        Compression: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("execution_hint")>]
        ExecutionHint: TypesAggregations.TDigestExecutionHint option
    }

    type PercentileRanksAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("keyed")>]
        Keyed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("values")>]
        Values: Types.Double list option option
        [<System.Text.Json.Serialization.JsonPropertyName("hdr")>]
        Hdr: TypesAggregations.HdrMethod option
        [<System.Text.Json.Serialization.JsonPropertyName("tdigest")>]
        Tdigest: TypesAggregations.TDigest option
    }

    type PercentilesAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("keyed")>]
        Keyed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("percents")>]
        Percents: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("hdr")>]
        Hdr: TypesAggregations.HdrMethod option
        [<System.Text.Json.Serialization.JsonPropertyName("tdigest")>]
        Tdigest: TypesAggregations.TDigest option
    }

    type PercentilesBucketAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("percents")>]
        Percents: Types.Double list option
    }

    type RangeAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("ranges")>]
        Ranges: TypesAggregations.AggregationRange list option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("keyed")>]
        Keyed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
    }

    type RareTermsAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("exclude")>]
        Exclude: TypesAggregations.TermsExclude option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("include")>]
        Include: TypesAggregations.TermsInclude option
        [<System.Text.Json.Serialization.JsonPropertyName("max_doc_count")>]
        MaxDocCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: TypesAggregations.Missing option
        [<System.Text.Json.Serialization.JsonPropertyName("precision")>]
        Precision: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("value_type")>]
        ValueType: string option
    }

    [<RequireQualifiedAccess>]
    type RateMode =
        | Sum
        | ValueCount

    type RateAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("unit")>]
        Unit: TypesAggregations.CalendarInterval option
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: TypesAggregations.RateMode option
    }

    type ReverseNestedAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: Types.Field option
    }

    type RandomSamplerAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("probability")>]
        Probability: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("seed")>]
        Seed: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_seed")>]
        ShardSeed: Types.Integer option
    }

    type SamplerAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: Types.Integer option
    }

    type ScriptedMetricAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("combine_script")>]
        CombineScript: Types.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("init_script")>]
        InitScript: Types.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("map_script")>]
        MapScript: Types.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("reduce_script")>]
        ReduceScript: Types.Script option
    }

    type SerialDifferencingAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("lag")>]
        Lag: Types.Integer option
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
        Script: Types.Script
    }

    type PValueHeuristic = {
        [<System.Text.Json.Serialization.JsonPropertyName("background_is_superset")>]
        BackgroundIsSuperset: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("normalize_above")>]
        NormalizeAbove: Types.Long option
    }

    type SignificantTermsAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("background_filter")>]
        BackgroundFilter: TypesQueryDsl.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("chi_square")>]
        ChiSquare: TypesAggregations.ChiSquareHeuristic option
        [<System.Text.Json.Serialization.JsonPropertyName("exclude")>]
        Exclude: TypesAggregations.TermsExclude option
        [<System.Text.Json.Serialization.JsonPropertyName("execution_hint")>]
        ExecutionHint: TypesAggregations.TermsAggregationExecutionHint option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("gnd")>]
        Gnd: TypesAggregations.GoogleNormalizedDistanceHeuristic option
        [<System.Text.Json.Serialization.JsonPropertyName("include")>]
        Include: TypesAggregations.TermsInclude option
        [<System.Text.Json.Serialization.JsonPropertyName("jlh")>]
        Jlh: Types.EmptyObject option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_count")>]
        MinDocCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("mutual_information")>]
        MutualInformation: TypesAggregations.MutualInformationHeuristic option
        [<System.Text.Json.Serialization.JsonPropertyName("percentage")>]
        Percentage: TypesAggregations.PercentageScoreHeuristic option
        [<System.Text.Json.Serialization.JsonPropertyName("script_heuristic")>]
        ScriptHeuristic: TypesAggregations.ScriptedHeuristic option
        [<System.Text.Json.Serialization.JsonPropertyName("p_value")>]
        PValue: TypesAggregations.PValueHeuristic option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_min_doc_count")>]
        ShardMinDocCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
    }

    type SignificantTextAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("background_filter")>]
        BackgroundFilter: TypesQueryDsl.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("chi_square")>]
        ChiSquare: TypesAggregations.ChiSquareHeuristic option
        [<System.Text.Json.Serialization.JsonPropertyName("exclude")>]
        Exclude: TypesAggregations.TermsExclude option
        [<System.Text.Json.Serialization.JsonPropertyName("execution_hint")>]
        ExecutionHint: TypesAggregations.TermsAggregationExecutionHint option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("filter_duplicate_text")>]
        FilterDuplicateText: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("gnd")>]
        Gnd: TypesAggregations.GoogleNormalizedDistanceHeuristic option
        [<System.Text.Json.Serialization.JsonPropertyName("include")>]
        Include: TypesAggregations.TermsInclude option
        [<System.Text.Json.Serialization.JsonPropertyName("jlh")>]
        Jlh: Types.EmptyObject option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_count")>]
        MinDocCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("mutual_information")>]
        MutualInformation: TypesAggregations.MutualInformationHeuristic option
        [<System.Text.Json.Serialization.JsonPropertyName("percentage")>]
        Percentage: TypesAggregations.PercentageScoreHeuristic option
        [<System.Text.Json.Serialization.JsonPropertyName("script_heuristic")>]
        ScriptHeuristic: TypesAggregations.ScriptedHeuristic option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_min_doc_count")>]
        ShardMinDocCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("source_fields")>]
        SourceFields: Types.Fields option
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
        CollectMode: TypesAggregations.TermsAggregationCollectMode option
        [<System.Text.Json.Serialization.JsonPropertyName("exclude")>]
        Exclude: TypesAggregations.TermsExclude option
        [<System.Text.Json.Serialization.JsonPropertyName("execution_hint")>]
        ExecutionHint: TypesAggregations.TermsAggregationExecutionHint option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("include")>]
        Include: TypesAggregations.TermsInclude option
        [<System.Text.Json.Serialization.JsonPropertyName("min_doc_count")>]
        MinDocCount: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: TypesAggregations.Missing option
        [<System.Text.Json.Serialization.JsonPropertyName("missing_order")>]
        MissingOrder: TypesAggregations.MissingOrder option
        [<System.Text.Json.Serialization.JsonPropertyName("missing_bucket")>]
        MissingBucket: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("value_type")>]
        ValueType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: TypesAggregations.AggregateOrder option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_min_doc_count")>]
        ShardMinDocCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("show_term_doc_count_error")>]
        ShowTermDocCountError: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
    }

    type TimeSeriesAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("keyed")>]
        Keyed: bool option
    }

    type TopHitsAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("docvalue_fields")>]
        DocvalueFields: TypesQueryDsl.FieldAndFormat list option
        [<System.Text.Json.Serialization.JsonPropertyName("explain")>]
        Explain: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: TypesQueryDsl.FieldAndFormat list option
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        From: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("highlight")>]
        Highlight: GlobalSearchTypes.Highlight option
        [<System.Text.Json.Serialization.JsonPropertyName("script_fields")>]
        ScriptFields: Map<string, Types.ScriptField> option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: Types.Sort option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: GlobalSearchTypes.SourceConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("stored_fields")>]
        StoredFields: Types.Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("track_scores")>]
        TrackScores: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("seq_no_primary_term")>]
        SeqNoPrimaryTerm: bool option
    }

    type TestPopulation = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: TypesQueryDsl.QueryContainer option
    }

    [<RequireQualifiedAccess>]
    type TTestType =
        | Paired
        | Homoscedastic
        | Heteroscedastic

    type TTestAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("a")>]
        A: TypesAggregations.TestPopulation option
        [<System.Text.Json.Serialization.JsonPropertyName("b")>]
        B: TypesAggregations.TestPopulation option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: TypesAggregations.TTestType option
    }

    type TopMetricsValue = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
    }

    type TopMetricsAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("metrics")>]
        Metrics: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: Types.Sort option
    }

    type FormattableMetricAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
    }

    type ValueCountAggregation = System.Text.Json.JsonElement

    type WeightedAverageValue = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("missing")>]
        Missing: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
    }

    type WeightedAverageAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: TypesAggregations.WeightedAverageValue option
        [<System.Text.Json.Serialization.JsonPropertyName("value_type")>]
        ValueType: TypesAggregations.ValueType option
        [<System.Text.Json.Serialization.JsonPropertyName("weight")>]
        Weight: TypesAggregations.WeightedAverageValue option
    }

    type VariableWidthHistogramAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("buckets")>]
        Buckets: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_size")>]
        ShardSize: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("initial_buffer")>]
        InitialBuffer: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: Types.Script option
    }

    [<RequireQualifiedAccess>]
    type AggregationContainer =
        | AdjacencyMatrix of TypesAggregations.AdjacencyMatrixAggregation
        | AutoDateHistogram of TypesAggregations.AutoDateHistogramAggregation
        | Avg of TypesAggregations.AverageAggregation
        | AvgBucket of TypesAggregations.AverageBucketAggregation
        | Boxplot of TypesAggregations.BoxplotAggregation
        | BucketScript of TypesAggregations.BucketScriptAggregation
        | BucketSelector of TypesAggregations.BucketSelectorAggregation
        | BucketSort of TypesAggregations.BucketSortAggregation
        | BucketCountKsTest of TypesAggregations.BucketKsAggregation
        | BucketCorrelation of TypesAggregations.BucketCorrelationAggregation
        | Cardinality of TypesAggregations.CardinalityAggregation
        | CartesianBounds of TypesAggregations.CartesianBoundsAggregation
        | CartesianCentroid of TypesAggregations.CartesianCentroidAggregation
        | CategorizeText of TypesAggregations.CategorizeTextAggregation
        | ChangePoint of TypesAggregations.ChangePointAggregation
        | Children of TypesAggregations.ChildrenAggregation
        | Composite of TypesAggregations.CompositeAggregation
        | CumulativeCardinality of TypesAggregations.CumulativeCardinalityAggregation
        | CumulativeSum of TypesAggregations.CumulativeSumAggregation
        | DateHistogram of TypesAggregations.DateHistogramAggregation
        | DateRange of TypesAggregations.DateRangeAggregation
        | Derivative of TypesAggregations.DerivativeAggregation
        | DiversifiedSampler of TypesAggregations.DiversifiedSamplerAggregation
        | ExtendedStats of TypesAggregations.ExtendedStatsAggregation
        | ExtendedStatsBucket of TypesAggregations.ExtendedStatsBucketAggregation
        | FrequentItemSets of TypesAggregations.FrequentItemSetsAggregation
        | Filter of TypesQueryDsl.QueryContainer
        | Filters of TypesAggregations.FiltersAggregation
        | GeoBounds of TypesAggregations.GeoBoundsAggregation
        | GeoCentroid of TypesAggregations.GeoCentroidAggregation
        | GeoDistance of TypesAggregations.GeoDistanceAggregation
        | GeohashGrid of TypesAggregations.GeoHashGridAggregation
        | GeoLine of TypesAggregations.GeoLineAggregation
        | GeotileGrid of TypesAggregations.GeoTileGridAggregation
        | GeohexGrid of TypesAggregations.GeohexGridAggregation
        | Global of TypesAggregations.GlobalAggregation
        | Histogram of TypesAggregations.HistogramAggregation
        | IpRange of TypesAggregations.IpRangeAggregation
        | IpPrefix of TypesAggregations.IpPrefixAggregation
        | Inference of TypesAggregations.InferenceAggregation
        | Line of TypesAggregations.GeoLineAggregation
        | MatrixStats of TypesAggregations.MatrixStatsAggregation
        | Max of TypesAggregations.MaxAggregation
        | MaxBucket of TypesAggregations.MaxBucketAggregation
        | MedianAbsoluteDeviation of TypesAggregations.MedianAbsoluteDeviationAggregation
        | Min of TypesAggregations.MinAggregation
        | MinBucket of TypesAggregations.MinBucketAggregation
        | Missing of TypesAggregations.MissingAggregation
        | MovingAvg of TypesAggregations.MovingAverageAggregation
        | MovingPercentiles of TypesAggregations.MovingPercentilesAggregation
        | MovingFn of TypesAggregations.MovingFunctionAggregation
        | MultiTerms of TypesAggregations.MultiTermsAggregation
        | Nested of TypesAggregations.NestedAggregation
        | Normalize of TypesAggregations.NormalizeAggregation
        | Parent of TypesAggregations.ParentAggregation
        | PercentileRanks of TypesAggregations.PercentileRanksAggregation
        | Percentiles of TypesAggregations.PercentilesAggregation
        | PercentilesBucket of TypesAggregations.PercentilesBucketAggregation
        | Range of TypesAggregations.RangeAggregation
        | RareTerms of TypesAggregations.RareTermsAggregation
        | Rate of TypesAggregations.RateAggregation
        | ReverseNested of TypesAggregations.ReverseNestedAggregation
        | RandomSampler of TypesAggregations.RandomSamplerAggregation
        | Sampler of TypesAggregations.SamplerAggregation
        | ScriptedMetric of TypesAggregations.ScriptedMetricAggregation
        | SerialDiff of TypesAggregations.SerialDifferencingAggregation
        | SignificantTerms of TypesAggregations.SignificantTermsAggregation
        | SignificantText of TypesAggregations.SignificantTextAggregation
        | Stats of TypesAggregations.StatsAggregation
        | StatsBucket of TypesAggregations.StatsBucketAggregation
        | StringStats of TypesAggregations.StringStatsAggregation
        | Sum of TypesAggregations.SumAggregation
        | SumBucket of TypesAggregations.SumBucketAggregation
        | Terms of TypesAggregations.TermsAggregation
        | TimeSeries of TypesAggregations.TimeSeriesAggregation
        | TopHits of TypesAggregations.TopHitsAggregation
        | TTest of TypesAggregations.TTestAggregation
        | TopMetrics of TypesAggregations.TopMetricsAggregation
        | ValueCount of TypesAggregations.ValueCountAggregation
        | WeightedAvg of TypesAggregations.WeightedAverageAggregation
        | VariableWidthHistogram of TypesAggregations.VariableWidthHistogramAggregation
        | Unknown of name: string * System.Text.Json.JsonElement

    and AggregationContainerMeta = {
        [<System.Text.Json.Serialization.JsonPropertyName("aggregations")>]
        Aggregations: Map<string, TypesAggregations.AggregationContainer> option
        [<System.Text.Json.Serialization.JsonPropertyName("meta")>]
        Meta: Types.Metadata option
    }


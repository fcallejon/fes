// Auto-generated container variant tests — do not edit manually

module Fes.Tests.Generated.VariantTests

open Xunit
open FsUnit.Xunit
open Fes
open Fes.Generated

[<Fact>]
let ``OperationContainer.Index serialises with index key`` () =
    let value = Types.OperationContainer.Index Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"index\""

[<Fact>]
let ``OperationContainer.Create serialises with create key`` () =
    let value = Types.OperationContainer.Create Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"create\""

[<Fact>]
let ``OperationContainer.Update serialises with update key`` () =
    let value = Types.OperationContainer.Update Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"update\""

[<Fact>]
let ``OperationContainer.Delete serialises with delete key`` () =
    let value = Types.OperationContainer.Delete Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"delete\""

[<Fact>]
let ``FieldSuggester.Completion serialises with completion key`` () =
    let value = Types.FieldSuggester.Completion Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"completion\""

[<Fact>]
let ``FieldSuggester.Phrase serialises with phrase key`` () =
    let value = Types.FieldSuggester.Phrase Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"phrase\""

[<Fact>]
let ``FieldSuggester.Term serialises with term key`` () =
    let value = Types.FieldSuggester.Term Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"term\""

[<Fact>]
let ``Rescore.Query serialises with query key`` () =
    let value = Types.Rescore.Query Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"query\""

[<Fact>]
let ``Rescore.LearningToRank serialises with learning_to_rank key`` () =
    let value = Types.Rescore.LearningToRank Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"learning_to_rank\""

[<Fact>]
let ``Rescore.Script serialises with script key`` () =
    let value = Types.Rescore.Script Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"script\""

[<Fact>]
let ``SmoothingModelContainer.Laplace serialises with laplace key`` () =
    let value = Types.SmoothingModelContainer.Laplace Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"laplace\""

[<Fact>]
let ``SmoothingModelContainer.LinearInterpolation serialises with linear_interpolation key`` () =
    let value = Types.SmoothingModelContainer.LinearInterpolation Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"linear_interpolation\""

[<Fact>]
let ``SmoothingModelContainer.StupidBackoff serialises with stupid_backoff key`` () =
    let value = Types.SmoothingModelContainer.StupidBackoff Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"stupid_backoff\""

[<Fact>]
let ``QueryVectorBuilder.TextEmbedding serialises with text_embedding key`` () =
    let value = Types.QueryVectorBuilder.TextEmbedding Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"text_embedding\""

[<Fact>]
let ``QueryVectorBuilder.Lookup serialises with lookup key`` () =
    let value = Types.QueryVectorBuilder.Lookup Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"lookup\""

[<Fact>]
let ``RankContainer.Rrf serialises with rrf key`` () =
    let value = Types.RankContainer.Rrf Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"rrf\""

[<Fact>]
let ``RetrieverContainer.Standard serialises with standard key`` () =
    let value = Types.RetrieverContainer.Standard Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"standard\""

[<Fact>]
let ``RetrieverContainer.Knn serialises with knn key`` () =
    let value = Types.RetrieverContainer.Knn Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"knn\""

[<Fact>]
let ``RetrieverContainer.Rrf serialises with rrf key`` () =
    let value = Types.RetrieverContainer.Rrf Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"rrf\""

[<Fact>]
let ``RetrieverContainer.TextSimilarityReranker serialises with text_similarity_reranker key`` () =
    let value = Types.RetrieverContainer.TextSimilarityReranker Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"text_similarity_reranker\""

[<Fact>]
let ``RetrieverContainer.Rule serialises with rule key`` () =
    let value = Types.RetrieverContainer.Rule Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"rule\""

[<Fact>]
let ``RetrieverContainer.Rescorer serialises with rescorer key`` () =
    let value = Types.RetrieverContainer.Rescorer Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"rescorer\""

[<Fact>]
let ``RetrieverContainer.Linear serialises with linear key`` () =
    let value = Types.RetrieverContainer.Linear Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"linear\""

[<Fact>]
let ``RetrieverContainer.Pinned serialises with pinned key`` () =
    let value = Types.RetrieverContainer.Pinned Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"pinned\""

[<Fact>]
let ``RetrieverContainer.Diversify serialises with diversify key`` () =
    let value = Types.RetrieverContainer.Diversify Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"diversify\""

[<Fact>]
let ``SortOptions.Score serialises with _score key`` () =
    let value = Types.SortOptions.Score Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"_score\""

[<Fact>]
let ``SortOptions.Doc serialises with _doc key`` () =
    let value = Types.SortOptions.Doc Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"_doc\""

[<Fact>]
let ``SortOptions.GeoDistance serialises with _geo_distance key`` () =
    let value = Types.SortOptions.GeoDistance Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"_geo_distance\""

[<Fact>]
let ``SortOptions.Script serialises with _script key`` () =
    let value = Types.SortOptions.Script Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"_script\""

[<Fact>]
let ``TransformContainer.Chain serialises with chain key`` () =
    let value = Types.TransformContainer.Chain Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"chain\""

[<Fact>]
let ``TransformContainer.Script serialises with script key`` () =
    let value = Types.TransformContainer.Script Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"script\""

[<Fact>]
let ``TransformContainer.Search serialises with search key`` () =
    let value = Types.TransformContainer.Search Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"search\""

[<Fact>]
let ``AggregationContainer.AdjacencyMatrix serialises with adjacency_matrix key`` () =
    let value = Types.AggregationContainer.AdjacencyMatrix Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"adjacency_matrix\""

[<Fact>]
let ``AggregationContainer.AutoDateHistogram serialises with auto_date_histogram key`` () =
    let value = Types.AggregationContainer.AutoDateHistogram Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"auto_date_histogram\""

[<Fact>]
let ``AggregationContainer.Avg serialises with avg key`` () =
    let value = Types.AggregationContainer.Avg Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"avg\""

[<Fact>]
let ``AggregationContainer.AvgBucket serialises with avg_bucket key`` () =
    let value = Types.AggregationContainer.AvgBucket Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"avg_bucket\""

[<Fact>]
let ``AggregationContainer.Boxplot serialises with boxplot key`` () =
    let value = Types.AggregationContainer.Boxplot Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"boxplot\""

[<Fact>]
let ``AggregationContainer.BucketScript serialises with bucket_script key`` () =
    let value = Types.AggregationContainer.BucketScript Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"bucket_script\""

[<Fact>]
let ``AggregationContainer.BucketSelector serialises with bucket_selector key`` () =
    let value = Types.AggregationContainer.BucketSelector Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"bucket_selector\""

[<Fact>]
let ``AggregationContainer.BucketSort serialises with bucket_sort key`` () =
    let value = Types.AggregationContainer.BucketSort Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"bucket_sort\""

[<Fact>]
let ``AggregationContainer.BucketCountKsTest serialises with bucket_count_ks_test key`` () =
    let value = Types.AggregationContainer.BucketCountKsTest Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"bucket_count_ks_test\""

[<Fact>]
let ``AggregationContainer.BucketCorrelation serialises with bucket_correlation key`` () =
    let value = Types.AggregationContainer.BucketCorrelation Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"bucket_correlation\""

[<Fact>]
let ``AggregationContainer.Cardinality serialises with cardinality key`` () =
    let value = Types.AggregationContainer.Cardinality Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"cardinality\""

[<Fact>]
let ``AggregationContainer.CartesianBounds serialises with cartesian_bounds key`` () =
    let value = Types.AggregationContainer.CartesianBounds Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"cartesian_bounds\""

[<Fact>]
let ``AggregationContainer.CartesianCentroid serialises with cartesian_centroid key`` () =
    let value = Types.AggregationContainer.CartesianCentroid Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"cartesian_centroid\""

[<Fact>]
let ``AggregationContainer.CategorizeText serialises with categorize_text key`` () =
    let value = Types.AggregationContainer.CategorizeText Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"categorize_text\""

[<Fact>]
let ``AggregationContainer.ChangePoint serialises with change_point key`` () =
    let value = Types.AggregationContainer.ChangePoint Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"change_point\""

[<Fact>]
let ``AggregationContainer.Children serialises with children key`` () =
    let value = Types.AggregationContainer.Children Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"children\""

[<Fact>]
let ``AggregationContainer.Composite serialises with composite key`` () =
    let value = Types.AggregationContainer.Composite Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"composite\""

[<Fact>]
let ``AggregationContainer.CumulativeCardinality serialises with cumulative_cardinality key`` () =
    let value = Types.AggregationContainer.CumulativeCardinality Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"cumulative_cardinality\""

[<Fact>]
let ``AggregationContainer.CumulativeSum serialises with cumulative_sum key`` () =
    let value = Types.AggregationContainer.CumulativeSum Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"cumulative_sum\""

[<Fact>]
let ``AggregationContainer.DateHistogram serialises with date_histogram key`` () =
    let value = Types.AggregationContainer.DateHistogram Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"date_histogram\""

[<Fact>]
let ``AggregationContainer.DateRange serialises with date_range key`` () =
    let value = Types.AggregationContainer.DateRange Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"date_range\""

[<Fact>]
let ``AggregationContainer.Derivative serialises with derivative key`` () =
    let value = Types.AggregationContainer.Derivative Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"derivative\""

[<Fact>]
let ``AggregationContainer.DiversifiedSampler serialises with diversified_sampler key`` () =
    let value = Types.AggregationContainer.DiversifiedSampler Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"diversified_sampler\""

[<Fact>]
let ``AggregationContainer.ExtendedStats serialises with extended_stats key`` () =
    let value = Types.AggregationContainer.ExtendedStats Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"extended_stats\""

[<Fact>]
let ``AggregationContainer.ExtendedStatsBucket serialises with extended_stats_bucket key`` () =
    let value = Types.AggregationContainer.ExtendedStatsBucket Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"extended_stats_bucket\""

[<Fact>]
let ``AggregationContainer.FrequentItemSets serialises with frequent_item_sets key`` () =
    let value = Types.AggregationContainer.FrequentItemSets Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"frequent_item_sets\""

[<Fact>]
let ``AggregationContainer.Filter serialises with filter key`` () =
    let value = Types.AggregationContainer.Filter Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"filter\""

[<Fact>]
let ``AggregationContainer.Filters serialises with filters key`` () =
    let value = Types.AggregationContainer.Filters Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"filters\""

[<Fact>]
let ``AggregationContainer.GeoBounds serialises with geo_bounds key`` () =
    let value = Types.AggregationContainer.GeoBounds Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"geo_bounds\""

[<Fact>]
let ``AggregationContainer.GeoCentroid serialises with geo_centroid key`` () =
    let value = Types.AggregationContainer.GeoCentroid Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"geo_centroid\""

[<Fact>]
let ``AggregationContainer.GeoDistance serialises with geo_distance key`` () =
    let value = Types.AggregationContainer.GeoDistance Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"geo_distance\""

[<Fact>]
let ``AggregationContainer.GeohashGrid serialises with geohash_grid key`` () =
    let value = Types.AggregationContainer.GeohashGrid Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"geohash_grid\""

[<Fact>]
let ``AggregationContainer.GeoLine serialises with geo_line key`` () =
    let value = Types.AggregationContainer.GeoLine Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"geo_line\""

[<Fact>]
let ``AggregationContainer.GeotileGrid serialises with geotile_grid key`` () =
    let value = Types.AggregationContainer.GeotileGrid Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"geotile_grid\""

[<Fact>]
let ``AggregationContainer.GeohexGrid serialises with geohex_grid key`` () =
    let value = Types.AggregationContainer.GeohexGrid Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"geohex_grid\""

[<Fact>]
let ``AggregationContainer.Global serialises with global key`` () =
    let value = Types.AggregationContainer.Global Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"global\""

[<Fact>]
let ``AggregationContainer.Histogram serialises with histogram key`` () =
    let value = Types.AggregationContainer.Histogram Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"histogram\""

[<Fact>]
let ``AggregationContainer.IpRange serialises with ip_range key`` () =
    let value = Types.AggregationContainer.IpRange Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"ip_range\""

[<Fact>]
let ``AggregationContainer.IpPrefix serialises with ip_prefix key`` () =
    let value = Types.AggregationContainer.IpPrefix Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"ip_prefix\""

[<Fact>]
let ``AggregationContainer.Inference serialises with inference key`` () =
    let value = Types.AggregationContainer.Inference Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"inference\""

[<Fact>]
let ``AggregationContainer.Line serialises with line key`` () =
    let value = Types.AggregationContainer.Line Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"line\""

[<Fact>]
let ``AggregationContainer.MatrixStats serialises with matrix_stats key`` () =
    let value = Types.AggregationContainer.MatrixStats Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"matrix_stats\""

[<Fact>]
let ``AggregationContainer.Max serialises with max key`` () =
    let value = Types.AggregationContainer.Max Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"max\""

[<Fact>]
let ``AggregationContainer.MaxBucket serialises with max_bucket key`` () =
    let value = Types.AggregationContainer.MaxBucket Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"max_bucket\""

[<Fact>]
let ``AggregationContainer.MedianAbsoluteDeviation serialises with median_absolute_deviation key`` () =
    let value = Types.AggregationContainer.MedianAbsoluteDeviation Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"median_absolute_deviation\""

[<Fact>]
let ``AggregationContainer.Min serialises with min key`` () =
    let value = Types.AggregationContainer.Min Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"min\""

[<Fact>]
let ``AggregationContainer.MinBucket serialises with min_bucket key`` () =
    let value = Types.AggregationContainer.MinBucket Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"min_bucket\""

[<Fact>]
let ``AggregationContainer.Missing serialises with missing key`` () =
    let value = Types.AggregationContainer.Missing Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"missing\""

[<Fact>]
let ``AggregationContainer.MovingAvg serialises with moving_avg key`` () =
    let value = Types.AggregationContainer.MovingAvg Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"moving_avg\""

[<Fact>]
let ``AggregationContainer.MovingPercentiles serialises with moving_percentiles key`` () =
    let value = Types.AggregationContainer.MovingPercentiles Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"moving_percentiles\""

[<Fact>]
let ``AggregationContainer.MovingFn serialises with moving_fn key`` () =
    let value = Types.AggregationContainer.MovingFn Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"moving_fn\""

[<Fact>]
let ``AggregationContainer.MultiTerms serialises with multi_terms key`` () =
    let value = Types.AggregationContainer.MultiTerms Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"multi_terms\""

[<Fact>]
let ``AggregationContainer.Nested serialises with nested key`` () =
    let value = Types.AggregationContainer.Nested Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"nested\""

[<Fact>]
let ``AggregationContainer.Normalize serialises with normalize key`` () =
    let value = Types.AggregationContainer.Normalize Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"normalize\""

[<Fact>]
let ``AggregationContainer.Parent serialises with parent key`` () =
    let value = Types.AggregationContainer.Parent Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"parent\""

[<Fact>]
let ``AggregationContainer.PercentileRanks serialises with percentile_ranks key`` () =
    let value = Types.AggregationContainer.PercentileRanks Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"percentile_ranks\""

[<Fact>]
let ``AggregationContainer.Percentiles serialises with percentiles key`` () =
    let value = Types.AggregationContainer.Percentiles Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"percentiles\""

[<Fact>]
let ``AggregationContainer.PercentilesBucket serialises with percentiles_bucket key`` () =
    let value = Types.AggregationContainer.PercentilesBucket Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"percentiles_bucket\""

[<Fact>]
let ``AggregationContainer.Range serialises with range key`` () =
    let value = Types.AggregationContainer.Range Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"range\""

[<Fact>]
let ``AggregationContainer.RareTerms serialises with rare_terms key`` () =
    let value = Types.AggregationContainer.RareTerms Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"rare_terms\""

[<Fact>]
let ``AggregationContainer.Rate serialises with rate key`` () =
    let value = Types.AggregationContainer.Rate Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"rate\""

[<Fact>]
let ``AggregationContainer.ReverseNested serialises with reverse_nested key`` () =
    let value = Types.AggregationContainer.ReverseNested Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"reverse_nested\""

[<Fact>]
let ``AggregationContainer.RandomSampler serialises with random_sampler key`` () =
    let value = Types.AggregationContainer.RandomSampler Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"random_sampler\""

[<Fact>]
let ``AggregationContainer.Sampler serialises with sampler key`` () =
    let value = Types.AggregationContainer.Sampler Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"sampler\""

[<Fact>]
let ``AggregationContainer.ScriptedMetric serialises with scripted_metric key`` () =
    let value = Types.AggregationContainer.ScriptedMetric Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"scripted_metric\""

[<Fact>]
let ``AggregationContainer.SerialDiff serialises with serial_diff key`` () =
    let value = Types.AggregationContainer.SerialDiff Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"serial_diff\""

[<Fact>]
let ``AggregationContainer.SignificantTerms serialises with significant_terms key`` () =
    let value = Types.AggregationContainer.SignificantTerms Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"significant_terms\""

[<Fact>]
let ``AggregationContainer.SignificantText serialises with significant_text key`` () =
    let value = Types.AggregationContainer.SignificantText Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"significant_text\""

[<Fact>]
let ``AggregationContainer.Stats serialises with stats key`` () =
    let value = Types.AggregationContainer.Stats Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"stats\""

[<Fact>]
let ``AggregationContainer.StatsBucket serialises with stats_bucket key`` () =
    let value = Types.AggregationContainer.StatsBucket Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"stats_bucket\""

[<Fact>]
let ``AggregationContainer.StringStats serialises with string_stats key`` () =
    let value = Types.AggregationContainer.StringStats Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"string_stats\""

[<Fact>]
let ``AggregationContainer.Sum serialises with sum key`` () =
    let value = Types.AggregationContainer.Sum Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"sum\""

[<Fact>]
let ``AggregationContainer.SumBucket serialises with sum_bucket key`` () =
    let value = Types.AggregationContainer.SumBucket Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"sum_bucket\""

[<Fact>]
let ``AggregationContainer.Terms serialises with terms key`` () =
    let value = Types.AggregationContainer.Terms Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"terms\""

[<Fact>]
let ``AggregationContainer.TimeSeries serialises with time_series key`` () =
    let value = Types.AggregationContainer.TimeSeries Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"time_series\""

[<Fact>]
let ``AggregationContainer.TopHits serialises with top_hits key`` () =
    let value = Types.AggregationContainer.TopHits Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"top_hits\""

[<Fact>]
let ``AggregationContainer.TTest serialises with t_test key`` () =
    let value = Types.AggregationContainer.TTest Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"t_test\""

[<Fact>]
let ``AggregationContainer.TopMetrics serialises with top_metrics key`` () =
    let value = Types.AggregationContainer.TopMetrics Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"top_metrics\""

[<Fact>]
let ``AggregationContainer.ValueCount serialises with value_count key`` () =
    let value = Types.AggregationContainer.ValueCount Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"value_count\""

[<Fact>]
let ``AggregationContainer.WeightedAvg serialises with weighted_avg key`` () =
    let value = Types.AggregationContainer.WeightedAvg Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"weighted_avg\""

[<Fact>]
let ``AggregationContainer.VariableWidthHistogram serialises with variable_width_histogram key`` () =
    let value = Types.AggregationContainer.VariableWidthHistogram Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"variable_width_histogram\""

[<Fact>]
let ``ChangeType.Dip serialises with dip key`` () =
    let value = Types.ChangeType.Dip Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"dip\""

[<Fact>]
let ``ChangeType.DistributionChange serialises with distribution_change key`` () =
    let value = Types.ChangeType.DistributionChange Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"distribution_change\""

[<Fact>]
let ``ChangeType.Indeterminable serialises with indeterminable key`` () =
    let value = Types.ChangeType.Indeterminable Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"indeterminable\""

[<Fact>]
let ``ChangeType.NonStationary serialises with non_stationary key`` () =
    let value = Types.ChangeType.NonStationary Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"non_stationary\""

[<Fact>]
let ``ChangeType.Spike serialises with spike key`` () =
    let value = Types.ChangeType.Spike Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"spike\""

[<Fact>]
let ``ChangeType.Stationary serialises with stationary key`` () =
    let value = Types.ChangeType.Stationary Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"stationary\""

[<Fact>]
let ``ChangeType.StepChange serialises with step_change key`` () =
    let value = Types.ChangeType.StepChange Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"step_change\""

[<Fact>]
let ``ChangeType.TrendChange serialises with trend_change key`` () =
    let value = Types.ChangeType.TrendChange Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"trend_change\""

[<Fact>]
let ``CompositeAggregationSource.Terms serialises with terms key`` () =
    let value = Types.CompositeAggregationSource.Terms Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"terms\""

[<Fact>]
let ``CompositeAggregationSource.Histogram serialises with histogram key`` () =
    let value = Types.CompositeAggregationSource.Histogram Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"histogram\""

[<Fact>]
let ``CompositeAggregationSource.DateHistogram serialises with date_histogram key`` () =
    let value = Types.CompositeAggregationSource.DateHistogram Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"date_histogram\""

[<Fact>]
let ``CompositeAggregationSource.GeotileGrid serialises with geotile_grid key`` () =
    let value = Types.CompositeAggregationSource.GeotileGrid Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"geotile_grid\""

[<Fact>]
let ``InferenceConfigContainer.Regression serialises with regression key`` () =
    let value = Types.InferenceConfigContainer.Regression Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"regression\""

[<Fact>]
let ``InferenceConfigContainer.Classification serialises with classification key`` () =
    let value = Types.InferenceConfigContainer.Classification Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"classification\""

[<Fact>]
let ``MultiTermLookup.Field serialises with field key`` () =
    let value = Types.MultiTermLookup.Field Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"field\""

[<Fact>]
let ``MultiTermLookup.Script serialises with script key`` () =
    let value = Types.MultiTermLookup.Script Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"script\""

[<Fact>]
let ``DynamicTemplate.Mapping serialises with mapping key`` () =
    let value = Types.DynamicTemplate.Mapping Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"mapping\""

[<Fact>]
let ``DynamicTemplate.Runtime serialises with runtime key`` () =
    let value = Types.DynamicTemplate.Runtime Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"runtime\""

[<Fact>]
let ``FunctionScoreContainer.Exp serialises with exp key`` () =
    let value = Types.FunctionScoreContainer.Exp Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"exp\""

[<Fact>]
let ``FunctionScoreContainer.Gauss serialises with gauss key`` () =
    let value = Types.FunctionScoreContainer.Gauss Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"gauss\""

[<Fact>]
let ``FunctionScoreContainer.Linear serialises with linear key`` () =
    let value = Types.FunctionScoreContainer.Linear Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"linear\""

[<Fact>]
let ``FunctionScoreContainer.FieldValueFactor serialises with field_value_factor key`` () =
    let value = Types.FunctionScoreContainer.FieldValueFactor Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"field_value_factor\""

[<Fact>]
let ``FunctionScoreContainer.RandomScore serialises with random_score key`` () =
    let value = Types.FunctionScoreContainer.RandomScore Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"random_score\""

[<Fact>]
let ``FunctionScoreContainer.ScriptScore serialises with script_score key`` () =
    let value = Types.FunctionScoreContainer.ScriptScore Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"script_score\""

[<Fact>]
let ``GeoGridQuery.Geotile serialises with geotile key`` () =
    let value = Types.GeoGridQuery.Geotile Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"geotile\""

[<Fact>]
let ``GeoGridQuery.Geohash serialises with geohash key`` () =
    let value = Types.GeoGridQuery.Geohash Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"geohash\""

[<Fact>]
let ``GeoGridQuery.Geohex serialises with geohex key`` () =
    let value = Types.GeoGridQuery.Geohex Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"geohex\""

[<Fact>]
let ``IntervalsContainer.AllOf serialises with all_of key`` () =
    let value = Types.IntervalsContainer.AllOf Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"all_of\""

[<Fact>]
let ``IntervalsContainer.AnyOf serialises with any_of key`` () =
    let value = Types.IntervalsContainer.AnyOf Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"any_of\""

[<Fact>]
let ``IntervalsContainer.Fuzzy serialises with fuzzy key`` () =
    let value = Types.IntervalsContainer.Fuzzy Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"fuzzy\""

[<Fact>]
let ``IntervalsContainer.Match serialises with match key`` () =
    let value = Types.IntervalsContainer.Match Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"match\""

[<Fact>]
let ``IntervalsContainer.Prefix serialises with prefix key`` () =
    let value = Types.IntervalsContainer.Prefix Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"prefix\""

[<Fact>]
let ``IntervalsContainer.Range serialises with range key`` () =
    let value = Types.IntervalsContainer.Range Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"range\""

[<Fact>]
let ``IntervalsContainer.Regexp serialises with regexp key`` () =
    let value = Types.IntervalsContainer.Regexp Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"regexp\""

[<Fact>]
let ``IntervalsContainer.Wildcard serialises with wildcard key`` () =
    let value = Types.IntervalsContainer.Wildcard Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"wildcard\""

[<Fact>]
let ``IntervalsFilter.After serialises with after key`` () =
    let value = Types.IntervalsFilter.After Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"after\""

[<Fact>]
let ``IntervalsFilter.Before serialises with before key`` () =
    let value = Types.IntervalsFilter.Before Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"before\""

[<Fact>]
let ``IntervalsFilter.ContainedBy serialises with contained_by key`` () =
    let value = Types.IntervalsFilter.ContainedBy Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"contained_by\""

[<Fact>]
let ``IntervalsFilter.Containing serialises with containing key`` () =
    let value = Types.IntervalsFilter.Containing Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"containing\""

[<Fact>]
let ``IntervalsFilter.NotContainedBy serialises with not_contained_by key`` () =
    let value = Types.IntervalsFilter.NotContainedBy Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"not_contained_by\""

[<Fact>]
let ``IntervalsFilter.NotContaining serialises with not_containing key`` () =
    let value = Types.IntervalsFilter.NotContaining Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"not_containing\""

[<Fact>]
let ``IntervalsFilter.NotOverlapping serialises with not_overlapping key`` () =
    let value = Types.IntervalsFilter.NotOverlapping Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"not_overlapping\""

[<Fact>]
let ``IntervalsFilter.Overlapping serialises with overlapping key`` () =
    let value = Types.IntervalsFilter.Overlapping Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"overlapping\""

[<Fact>]
let ``IntervalsFilter.Script serialises with script key`` () =
    let value = Types.IntervalsFilter.Script Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"script\""

[<Fact>]
let ``IntervalsQuery.AllOf serialises with all_of key`` () =
    let value = Types.IntervalsQuery.AllOf Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"all_of\""

[<Fact>]
let ``IntervalsQuery.AnyOf serialises with any_of key`` () =
    let value = Types.IntervalsQuery.AnyOf Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"any_of\""

[<Fact>]
let ``IntervalsQuery.Fuzzy serialises with fuzzy key`` () =
    let value = Types.IntervalsQuery.Fuzzy Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"fuzzy\""

[<Fact>]
let ``IntervalsQuery.Match serialises with match key`` () =
    let value = Types.IntervalsQuery.Match Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"match\""

[<Fact>]
let ``IntervalsQuery.Prefix serialises with prefix key`` () =
    let value = Types.IntervalsQuery.Prefix Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"prefix\""

[<Fact>]
let ``IntervalsQuery.Range serialises with range key`` () =
    let value = Types.IntervalsQuery.Range Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"range\""

[<Fact>]
let ``IntervalsQuery.Regexp serialises with regexp key`` () =
    let value = Types.IntervalsQuery.Regexp Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"regexp\""

[<Fact>]
let ``IntervalsQuery.Wildcard serialises with wildcard key`` () =
    let value = Types.IntervalsQuery.Wildcard Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"wildcard\""

[<Fact>]
let ``PinnedQuery.Ids serialises with ids key`` () =
    let value = Types.PinnedQuery.Ids Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"ids\""

[<Fact>]
let ``PinnedQuery.Docs serialises with docs key`` () =
    let value = Types.PinnedQuery.Docs Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"docs\""

[<Fact>]
let ``QueryContainer.Bool serialises with bool key`` () =
    let value = Types.QueryContainer.Bool Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"bool\""

[<Fact>]
let ``QueryContainer.Boosting serialises with boosting key`` () =
    let value = Types.QueryContainer.Boosting Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"boosting\""

[<Fact>]
let ``QueryContainer.Common serialises with common key`` () =
    let value = Types.QueryContainer.Common Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"common\""

[<Fact>]
let ``QueryContainer.CombinedFields serialises with combined_fields key`` () =
    let value = Types.QueryContainer.CombinedFields Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"combined_fields\""

[<Fact>]
let ``QueryContainer.ConstantScore serialises with constant_score key`` () =
    let value = Types.QueryContainer.ConstantScore Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"constant_score\""

[<Fact>]
let ``QueryContainer.DisMax serialises with dis_max key`` () =
    let value = Types.QueryContainer.DisMax Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"dis_max\""

[<Fact>]
let ``QueryContainer.DistanceFeature serialises with distance_feature key`` () =
    let value = Types.QueryContainer.DistanceFeature Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"distance_feature\""

[<Fact>]
let ``QueryContainer.Exists serialises with exists key`` () =
    let value = Types.QueryContainer.Exists Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"exists\""

[<Fact>]
let ``QueryContainer.FunctionScore serialises with function_score key`` () =
    let value = Types.QueryContainer.FunctionScore Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"function_score\""

[<Fact>]
let ``QueryContainer.Fuzzy serialises with fuzzy key`` () =
    let value = Types.QueryContainer.Fuzzy Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"fuzzy\""

[<Fact>]
let ``QueryContainer.GeoBoundingBox serialises with geo_bounding_box key`` () =
    let value = Types.QueryContainer.GeoBoundingBox Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"geo_bounding_box\""

[<Fact>]
let ``QueryContainer.GeoDistance serialises with geo_distance key`` () =
    let value = Types.QueryContainer.GeoDistance Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"geo_distance\""

[<Fact>]
let ``QueryContainer.GeoGrid serialises with geo_grid key`` () =
    let value = Types.QueryContainer.GeoGrid Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"geo_grid\""

[<Fact>]
let ``QueryContainer.GeoPolygon serialises with geo_polygon key`` () =
    let value = Types.QueryContainer.GeoPolygon Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"geo_polygon\""

[<Fact>]
let ``QueryContainer.GeoShape serialises with geo_shape key`` () =
    let value = Types.QueryContainer.GeoShape Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"geo_shape\""

[<Fact>]
let ``QueryContainer.HasChild serialises with has_child key`` () =
    let value = Types.QueryContainer.HasChild Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"has_child\""

[<Fact>]
let ``QueryContainer.HasParent serialises with has_parent key`` () =
    let value = Types.QueryContainer.HasParent Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"has_parent\""

[<Fact>]
let ``QueryContainer.Ids serialises with ids key`` () =
    let value = Types.QueryContainer.Ids Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"ids\""

[<Fact>]
let ``QueryContainer.Intervals serialises with intervals key`` () =
    let value = Types.QueryContainer.Intervals Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"intervals\""

[<Fact>]
let ``QueryContainer.Knn serialises with knn key`` () =
    let value = Types.QueryContainer.Knn Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"knn\""

[<Fact>]
let ``QueryContainer.Match serialises with match key`` () =
    let value = Types.QueryContainer.Match Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"match\""

[<Fact>]
let ``QueryContainer.MatchAll serialises with match_all key`` () =
    let value = Types.QueryContainer.MatchAll Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"match_all\""

[<Fact>]
let ``QueryContainer.MatchBoolPrefix serialises with match_bool_prefix key`` () =
    let value = Types.QueryContainer.MatchBoolPrefix Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"match_bool_prefix\""

[<Fact>]
let ``QueryContainer.MatchNone serialises with match_none key`` () =
    let value = Types.QueryContainer.MatchNone Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"match_none\""

[<Fact>]
let ``QueryContainer.MatchPhrase serialises with match_phrase key`` () =
    let value = Types.QueryContainer.MatchPhrase Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"match_phrase\""

[<Fact>]
let ``QueryContainer.MatchPhrasePrefix serialises with match_phrase_prefix key`` () =
    let value = Types.QueryContainer.MatchPhrasePrefix Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"match_phrase_prefix\""

[<Fact>]
let ``QueryContainer.MoreLikeThis serialises with more_like_this key`` () =
    let value = Types.QueryContainer.MoreLikeThis Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"more_like_this\""

[<Fact>]
let ``QueryContainer.MultiMatch serialises with multi_match key`` () =
    let value = Types.QueryContainer.MultiMatch Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"multi_match\""

[<Fact>]
let ``QueryContainer.Nested serialises with nested key`` () =
    let value = Types.QueryContainer.Nested Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"nested\""

[<Fact>]
let ``QueryContainer.ParentId serialises with parent_id key`` () =
    let value = Types.QueryContainer.ParentId Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"parent_id\""

[<Fact>]
let ``QueryContainer.Percolate serialises with percolate key`` () =
    let value = Types.QueryContainer.Percolate Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"percolate\""

[<Fact>]
let ``QueryContainer.Pinned serialises with pinned key`` () =
    let value = Types.QueryContainer.Pinned Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"pinned\""

[<Fact>]
let ``QueryContainer.Prefix serialises with prefix key`` () =
    let value = Types.QueryContainer.Prefix Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"prefix\""

[<Fact>]
let ``QueryContainer.QueryString serialises with query_string key`` () =
    let value = Types.QueryContainer.QueryString Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"query_string\""

[<Fact>]
let ``QueryContainer.Range serialises with range key`` () =
    let value = Types.QueryContainer.Range Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"range\""

[<Fact>]
let ``QueryContainer.RankFeature serialises with rank_feature key`` () =
    let value = Types.QueryContainer.RankFeature Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"rank_feature\""

[<Fact>]
let ``QueryContainer.Regexp serialises with regexp key`` () =
    let value = Types.QueryContainer.Regexp Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"regexp\""

[<Fact>]
let ``QueryContainer.Rule serialises with rule key`` () =
    let value = Types.QueryContainer.Rule Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"rule\""

[<Fact>]
let ``QueryContainer.Script serialises with script key`` () =
    let value = Types.QueryContainer.Script Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"script\""

[<Fact>]
let ``QueryContainer.ScriptScore serialises with script_score key`` () =
    let value = Types.QueryContainer.ScriptScore Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"script_score\""

[<Fact>]
let ``QueryContainer.Semantic serialises with semantic key`` () =
    let value = Types.QueryContainer.Semantic Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"semantic\""

[<Fact>]
let ``QueryContainer.Shape serialises with shape key`` () =
    let value = Types.QueryContainer.Shape Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"shape\""

[<Fact>]
let ``QueryContainer.SimpleQueryString serialises with simple_query_string key`` () =
    let value = Types.QueryContainer.SimpleQueryString Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"simple_query_string\""

[<Fact>]
let ``QueryContainer.SpanContaining serialises with span_containing key`` () =
    let value = Types.QueryContainer.SpanContaining Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"span_containing\""

[<Fact>]
let ``QueryContainer.SpanFieldMasking serialises with span_field_masking key`` () =
    let value = Types.QueryContainer.SpanFieldMasking Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"span_field_masking\""

[<Fact>]
let ``QueryContainer.SpanFirst serialises with span_first key`` () =
    let value = Types.QueryContainer.SpanFirst Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"span_first\""

[<Fact>]
let ``QueryContainer.SpanMulti serialises with span_multi key`` () =
    let value = Types.QueryContainer.SpanMulti Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"span_multi\""

[<Fact>]
let ``QueryContainer.SpanNear serialises with span_near key`` () =
    let value = Types.QueryContainer.SpanNear Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"span_near\""

[<Fact>]
let ``QueryContainer.SpanNot serialises with span_not key`` () =
    let value = Types.QueryContainer.SpanNot Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"span_not\""

[<Fact>]
let ``QueryContainer.SpanOr serialises with span_or key`` () =
    let value = Types.QueryContainer.SpanOr Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"span_or\""

[<Fact>]
let ``QueryContainer.SpanTerm serialises with span_term key`` () =
    let value = Types.QueryContainer.SpanTerm Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"span_term\""

[<Fact>]
let ``QueryContainer.SpanWithin serialises with span_within key`` () =
    let value = Types.QueryContainer.SpanWithin Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"span_within\""

[<Fact>]
let ``QueryContainer.SparseVector serialises with sparse_vector key`` () =
    let value = Types.QueryContainer.SparseVector Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"sparse_vector\""

[<Fact>]
let ``QueryContainer.Term serialises with term key`` () =
    let value = Types.QueryContainer.Term Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"term\""

[<Fact>]
let ``QueryContainer.Terms serialises with terms key`` () =
    let value = Types.QueryContainer.Terms Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"terms\""

[<Fact>]
let ``QueryContainer.TermsSet serialises with terms_set key`` () =
    let value = Types.QueryContainer.TermsSet Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"terms_set\""

[<Fact>]
let ``QueryContainer.TextExpansion serialises with text_expansion key`` () =
    let value = Types.QueryContainer.TextExpansion Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"text_expansion\""

[<Fact>]
let ``QueryContainer.WeightedTokens serialises with weighted_tokens key`` () =
    let value = Types.QueryContainer.WeightedTokens Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"weighted_tokens\""

[<Fact>]
let ``QueryContainer.Wildcard serialises with wildcard key`` () =
    let value = Types.QueryContainer.Wildcard Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"wildcard\""

[<Fact>]
let ``QueryContainer.Wrapper serialises with wrapper key`` () =
    let value = Types.QueryContainer.Wrapper Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"wrapper\""

[<Fact>]
let ``QueryContainer.Type serialises with type key`` () =
    let value = Types.QueryContainer.Type Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"type\""

[<Fact>]
let ``SpanQuery.SpanContaining serialises with span_containing key`` () =
    let value = Types.SpanQuery.SpanContaining Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"span_containing\""

[<Fact>]
let ``SpanQuery.SpanFieldMasking serialises with span_field_masking key`` () =
    let value = Types.SpanQuery.SpanFieldMasking Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"span_field_masking\""

[<Fact>]
let ``SpanQuery.SpanFirst serialises with span_first key`` () =
    let value = Types.SpanQuery.SpanFirst Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"span_first\""

[<Fact>]
let ``SpanQuery.SpanGap serialises with span_gap key`` () =
    let value = Types.SpanQuery.SpanGap Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"span_gap\""

[<Fact>]
let ``SpanQuery.SpanMulti serialises with span_multi key`` () =
    let value = Types.SpanQuery.SpanMulti Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"span_multi\""

[<Fact>]
let ``SpanQuery.SpanNear serialises with span_near key`` () =
    let value = Types.SpanQuery.SpanNear Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"span_near\""

[<Fact>]
let ``SpanQuery.SpanNot serialises with span_not key`` () =
    let value = Types.SpanQuery.SpanNot Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"span_not\""

[<Fact>]
let ``SpanQuery.SpanOr serialises with span_or key`` () =
    let value = Types.SpanQuery.SpanOr Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"span_or\""

[<Fact>]
let ``SpanQuery.SpanTerm serialises with span_term key`` () =
    let value = Types.SpanQuery.SpanTerm Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"span_term\""

[<Fact>]
let ``SpanQuery.SpanWithin serialises with span_within key`` () =
    let value = Types.SpanQuery.SpanWithin Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"span_within\""

[<Fact>]
let ``SparseVectorQuery.QueryVector serialises with query_vector key`` () =
    let value = Types.SparseVectorQuery.QueryVector Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"query_vector\""

[<Fact>]
let ``SparseVectorQuery.InferenceId serialises with inference_id key`` () =
    let value = Types.SparseVectorQuery.InferenceId Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"inference_id\""

[<Fact>]
let ``TableValuesContainer.Integer serialises with integer key`` () =
    let value = Types.TableValuesContainer.Integer Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"integer\""

[<Fact>]
let ``TableValuesContainer.Keyword serialises with keyword key`` () =
    let value = Types.TableValuesContainer.Keyword Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"keyword\""

[<Fact>]
let ``TableValuesContainer.Long serialises with long key`` () =
    let value = Types.TableValuesContainer.Long Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"long\""

[<Fact>]
let ``TableValuesContainer.Double serialises with double key`` () =
    let value = Types.TableValuesContainer.Double Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"double\""

[<Fact>]
let ``IndicesModifyDataStreamAction.AddBackingIndex serialises with add_backing_index key`` () =
    let value = Types.IndicesModifyDataStreamAction.AddBackingIndex Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"add_backing_index\""

[<Fact>]
let ``IndicesModifyDataStreamAction.RemoveBackingIndex serialises with remove_backing_index key`` () =
    let value = Types.IndicesModifyDataStreamAction.RemoveBackingIndex Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"remove_backing_index\""

[<Fact>]
let ``IndicesUpdateAliasesAction.Add serialises with add key`` () =
    let value = Types.IndicesUpdateAliasesAction.Add Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"add\""

[<Fact>]
let ``IndicesUpdateAliasesAction.Remove serialises with remove key`` () =
    let value = Types.IndicesUpdateAliasesAction.Remove Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"remove\""

[<Fact>]
let ``IndicesUpdateAliasesAction.RemoveIndex serialises with remove_index key`` () =
    let value = Types.IndicesUpdateAliasesAction.RemoveIndex Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"remove_index\""

[<Fact>]
let ``EmbeddingInferenceResult.EmbeddingsBytes serialises with embeddings_bytes key`` () =
    let value = Types.EmbeddingInferenceResult.EmbeddingsBytes Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"embeddings_bytes\""

[<Fact>]
let ``EmbeddingInferenceResult.EmbeddingsBits serialises with embeddings_bits key`` () =
    let value = Types.EmbeddingInferenceResult.EmbeddingsBits Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"embeddings_bits\""

[<Fact>]
let ``EmbeddingInferenceResult.Embeddings serialises with embeddings key`` () =
    let value = Types.EmbeddingInferenceResult.Embeddings Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"embeddings\""

[<Fact>]
let ``InferenceResult.EmbeddingsBytes serialises with embeddings_bytes key`` () =
    let value = Types.InferenceResult.EmbeddingsBytes Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"embeddings_bytes\""

[<Fact>]
let ``InferenceResult.EmbeddingsBits serialises with embeddings_bits key`` () =
    let value = Types.InferenceResult.EmbeddingsBits Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"embeddings_bits\""

[<Fact>]
let ``InferenceResult.Embeddings serialises with embeddings key`` () =
    let value = Types.InferenceResult.Embeddings Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"embeddings\""

[<Fact>]
let ``InferenceResult.TextEmbeddingBytes serialises with text_embedding_bytes key`` () =
    let value = Types.InferenceResult.TextEmbeddingBytes Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"text_embedding_bytes\""

[<Fact>]
let ``InferenceResult.TextEmbeddingBits serialises with text_embedding_bits key`` () =
    let value = Types.InferenceResult.TextEmbeddingBits Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"text_embedding_bits\""

[<Fact>]
let ``InferenceResult.TextEmbedding serialises with text_embedding key`` () =
    let value = Types.InferenceResult.TextEmbedding Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"text_embedding\""

[<Fact>]
let ``InferenceResult.SparseEmbedding serialises with sparse_embedding key`` () =
    let value = Types.InferenceResult.SparseEmbedding Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"sparse_embedding\""

[<Fact>]
let ``InferenceResult.Completion serialises with completion key`` () =
    let value = Types.InferenceResult.Completion Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"completion\""

[<Fact>]
let ``InferenceResult.Rerank serialises with rerank key`` () =
    let value = Types.InferenceResult.Rerank Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"rerank\""

[<Fact>]
let ``TextEmbeddingInferenceResult.TextEmbeddingBytes serialises with text_embedding_bytes key`` () =
    let value = Types.TextEmbeddingInferenceResult.TextEmbeddingBytes Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"text_embedding_bytes\""

[<Fact>]
let ``TextEmbeddingInferenceResult.TextEmbeddingBits serialises with text_embedding_bits key`` () =
    let value = Types.TextEmbeddingInferenceResult.TextEmbeddingBits Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"text_embedding_bits\""

[<Fact>]
let ``TextEmbeddingInferenceResult.TextEmbedding serialises with text_embedding key`` () =
    let value = Types.TextEmbeddingInferenceResult.TextEmbedding Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"text_embedding\""

[<Fact>]
let ``DatabaseConfiguration.Maxmind serialises with maxmind key`` () =
    let value = Types.DatabaseConfiguration.Maxmind Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"maxmind\""

[<Fact>]
let ``DatabaseConfiguration.Ipinfo serialises with ipinfo key`` () =
    let value = Types.DatabaseConfiguration.Ipinfo Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"ipinfo\""

[<Fact>]
let ``DatabaseConfigurationFull.Web serialises with web key`` () =
    let value = Types.DatabaseConfigurationFull.Web Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"web\""

[<Fact>]
let ``DatabaseConfigurationFull.Local serialises with local key`` () =
    let value = Types.DatabaseConfigurationFull.Local Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"local\""

[<Fact>]
let ``DatabaseConfigurationFull.Maxmind serialises with maxmind key`` () =
    let value = Types.DatabaseConfigurationFull.Maxmind Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"maxmind\""

[<Fact>]
let ``DatabaseConfigurationFull.Ipinfo serialises with ipinfo key`` () =
    let value = Types.DatabaseConfigurationFull.Ipinfo Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"ipinfo\""

[<Fact>]
let ``InferenceConfig.Regression serialises with regression key`` () =
    let value = Types.InferenceConfig.Regression Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"regression\""

[<Fact>]
let ``InferenceConfig.Classification serialises with classification key`` () =
    let value = Types.InferenceConfig.Classification Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"classification\""

[<Fact>]
let ``ProcessorContainer.Append serialises with append key`` () =
    let value = Types.ProcessorContainer.Append Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"append\""

[<Fact>]
let ``ProcessorContainer.Attachment serialises with attachment key`` () =
    let value = Types.ProcessorContainer.Attachment Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"attachment\""

[<Fact>]
let ``ProcessorContainer.Bytes serialises with bytes key`` () =
    let value = Types.ProcessorContainer.Bytes Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"bytes\""

[<Fact>]
let ``ProcessorContainer.Cef serialises with cef key`` () =
    let value = Types.ProcessorContainer.Cef Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"cef\""

[<Fact>]
let ``ProcessorContainer.Circle serialises with circle key`` () =
    let value = Types.ProcessorContainer.Circle Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"circle\""

[<Fact>]
let ``ProcessorContainer.CommunityId serialises with community_id key`` () =
    let value = Types.ProcessorContainer.CommunityId Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"community_id\""

[<Fact>]
let ``ProcessorContainer.Convert serialises with convert key`` () =
    let value = Types.ProcessorContainer.Convert Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"convert\""

[<Fact>]
let ``ProcessorContainer.Csv serialises with csv key`` () =
    let value = Types.ProcessorContainer.Csv Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"csv\""

[<Fact>]
let ``ProcessorContainer.Date serialises with date key`` () =
    let value = Types.ProcessorContainer.Date Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"date\""

[<Fact>]
let ``ProcessorContainer.DateIndexName serialises with date_index_name key`` () =
    let value = Types.ProcessorContainer.DateIndexName Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"date_index_name\""

[<Fact>]
let ``ProcessorContainer.Dissect serialises with dissect key`` () =
    let value = Types.ProcessorContainer.Dissect Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"dissect\""

[<Fact>]
let ``ProcessorContainer.DotExpander serialises with dot_expander key`` () =
    let value = Types.ProcessorContainer.DotExpander Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"dot_expander\""

[<Fact>]
let ``ProcessorContainer.Drop serialises with drop key`` () =
    let value = Types.ProcessorContainer.Drop Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"drop\""

[<Fact>]
let ``ProcessorContainer.Enrich serialises with enrich key`` () =
    let value = Types.ProcessorContainer.Enrich Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"enrich\""

[<Fact>]
let ``ProcessorContainer.Fail serialises with fail key`` () =
    let value = Types.ProcessorContainer.Fail Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"fail\""

[<Fact>]
let ``ProcessorContainer.Fingerprint serialises with fingerprint key`` () =
    let value = Types.ProcessorContainer.Fingerprint Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"fingerprint\""

[<Fact>]
let ``ProcessorContainer.Foreach serialises with foreach key`` () =
    let value = Types.ProcessorContainer.Foreach Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"foreach\""

[<Fact>]
let ``ProcessorContainer.IpLocation serialises with ip_location key`` () =
    let value = Types.ProcessorContainer.IpLocation Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"ip_location\""

[<Fact>]
let ``ProcessorContainer.GeoGrid serialises with geo_grid key`` () =
    let value = Types.ProcessorContainer.GeoGrid Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"geo_grid\""

[<Fact>]
let ``ProcessorContainer.Geoip serialises with geoip key`` () =
    let value = Types.ProcessorContainer.Geoip Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"geoip\""

[<Fact>]
let ``ProcessorContainer.Grok serialises with grok key`` () =
    let value = Types.ProcessorContainer.Grok Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"grok\""

[<Fact>]
let ``ProcessorContainer.Gsub serialises with gsub key`` () =
    let value = Types.ProcessorContainer.Gsub Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"gsub\""

[<Fact>]
let ``ProcessorContainer.HtmlStrip serialises with html_strip key`` () =
    let value = Types.ProcessorContainer.HtmlStrip Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"html_strip\""

[<Fact>]
let ``ProcessorContainer.Inference serialises with inference key`` () =
    let value = Types.ProcessorContainer.Inference Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"inference\""

[<Fact>]
let ``ProcessorContainer.Join serialises with join key`` () =
    let value = Types.ProcessorContainer.Join Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"join\""

[<Fact>]
let ``ProcessorContainer.Json serialises with json key`` () =
    let value = Types.ProcessorContainer.Json Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"json\""

[<Fact>]
let ``ProcessorContainer.Kv serialises with kv key`` () =
    let value = Types.ProcessorContainer.Kv Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"kv\""

[<Fact>]
let ``ProcessorContainer.Lowercase serialises with lowercase key`` () =
    let value = Types.ProcessorContainer.Lowercase Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"lowercase\""

[<Fact>]
let ``ProcessorContainer.NetworkDirection serialises with network_direction key`` () =
    let value = Types.ProcessorContainer.NetworkDirection Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"network_direction\""

[<Fact>]
let ``ProcessorContainer.Pipeline serialises with pipeline key`` () =
    let value = Types.ProcessorContainer.Pipeline Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"pipeline\""

[<Fact>]
let ``ProcessorContainer.Redact serialises with redact key`` () =
    let value = Types.ProcessorContainer.Redact Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"redact\""

[<Fact>]
let ``ProcessorContainer.RegisteredDomain serialises with registered_domain key`` () =
    let value = Types.ProcessorContainer.RegisteredDomain Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"registered_domain\""

[<Fact>]
let ``ProcessorContainer.Remove serialises with remove key`` () =
    let value = Types.ProcessorContainer.Remove Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"remove\""

[<Fact>]
let ``ProcessorContainer.Rename serialises with rename key`` () =
    let value = Types.ProcessorContainer.Rename Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"rename\""

[<Fact>]
let ``ProcessorContainer.Reroute serialises with reroute key`` () =
    let value = Types.ProcessorContainer.Reroute Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"reroute\""

[<Fact>]
let ``ProcessorContainer.Script serialises with script key`` () =
    let value = Types.ProcessorContainer.Script Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"script\""

[<Fact>]
let ``ProcessorContainer.Set serialises with set key`` () =
    let value = Types.ProcessorContainer.Set Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"set\""

[<Fact>]
let ``ProcessorContainer.SetSecurityUser serialises with set_security_user key`` () =
    let value = Types.ProcessorContainer.SetSecurityUser Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"set_security_user\""

[<Fact>]
let ``ProcessorContainer.Sort serialises with sort key`` () =
    let value = Types.ProcessorContainer.Sort Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"sort\""

[<Fact>]
let ``ProcessorContainer.Split serialises with split key`` () =
    let value = Types.ProcessorContainer.Split Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"split\""

[<Fact>]
let ``ProcessorContainer.Terminate serialises with terminate key`` () =
    let value = Types.ProcessorContainer.Terminate Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"terminate\""

[<Fact>]
let ``ProcessorContainer.Trim serialises with trim key`` () =
    let value = Types.ProcessorContainer.Trim Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"trim\""

[<Fact>]
let ``ProcessorContainer.Uppercase serialises with uppercase key`` () =
    let value = Types.ProcessorContainer.Uppercase Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"uppercase\""

[<Fact>]
let ``ProcessorContainer.Urldecode serialises with urldecode key`` () =
    let value = Types.ProcessorContainer.Urldecode Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"urldecode\""

[<Fact>]
let ``ProcessorContainer.UriParts serialises with uri_parts key`` () =
    let value = Types.ProcessorContainer.UriParts Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"uri_parts\""

[<Fact>]
let ``ProcessorContainer.UserAgent serialises with user_agent key`` () =
    let value = Types.ProcessorContainer.UserAgent Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"user_agent\""

[<Fact>]
let ``DataframeAnalysisContainer.Classification serialises with classification key`` () =
    let value = Types.DataframeAnalysisContainer.Classification Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"classification\""

[<Fact>]
let ``DataframeAnalysisContainer.OutlierDetection serialises with outlier_detection key`` () =
    let value = Types.DataframeAnalysisContainer.OutlierDetection Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"outlier_detection\""

[<Fact>]
let ``DataframeAnalysisContainer.Regression serialises with regression key`` () =
    let value = Types.DataframeAnalysisContainer.Regression Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"regression\""

[<Fact>]
let ``DataframeAnalysisFeatureProcessor.FrequencyEncoding serialises with frequency_encoding key`` () =
    let value = Types.DataframeAnalysisFeatureProcessor.FrequencyEncoding Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"frequency_encoding\""

[<Fact>]
let ``DataframeAnalysisFeatureProcessor.MultiEncoding serialises with multi_encoding key`` () =
    let value = Types.DataframeAnalysisFeatureProcessor.MultiEncoding Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"multi_encoding\""

[<Fact>]
let ``DataframeAnalysisFeatureProcessor.NGramEncoding serialises with n_gram_encoding key`` () =
    let value = Types.DataframeAnalysisFeatureProcessor.NGramEncoding Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"n_gram_encoding\""

[<Fact>]
let ``DataframeAnalysisFeatureProcessor.OneHotEncoding serialises with one_hot_encoding key`` () =
    let value = Types.DataframeAnalysisFeatureProcessor.OneHotEncoding Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"one_hot_encoding\""

[<Fact>]
let ``DataframeAnalysisFeatureProcessor.TargetMeanEncoding serialises with target_mean_encoding key`` () =
    let value = Types.DataframeAnalysisFeatureProcessor.TargetMeanEncoding Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"target_mean_encoding\""

[<Fact>]
let ``DataframeAnalyticsStatsContainer.ClassificationStats serialises with classification_stats key`` () =
    let value = Types.DataframeAnalyticsStatsContainer.ClassificationStats Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"classification_stats\""

[<Fact>]
let ``DataframeAnalyticsStatsContainer.OutlierDetectionStats serialises with outlier_detection_stats key`` () =
    let value = Types.DataframeAnalyticsStatsContainer.OutlierDetectionStats Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"outlier_detection_stats\""

[<Fact>]
let ``DataframeAnalyticsStatsContainer.RegressionStats serialises with regression_stats key`` () =
    let value = Types.DataframeAnalyticsStatsContainer.RegressionStats Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"regression_stats\""

[<Fact>]
let ``DataframeEvaluationContainer.Classification serialises with classification key`` () =
    let value = Types.DataframeEvaluationContainer.Classification Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"classification\""

[<Fact>]
let ``DataframeEvaluationContainer.OutlierDetection serialises with outlier_detection key`` () =
    let value = Types.DataframeEvaluationContainer.OutlierDetection Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"outlier_detection\""

[<Fact>]
let ``DataframeEvaluationContainer.Regression serialises with regression key`` () =
    let value = Types.DataframeEvaluationContainer.Regression Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"regression\""

[<Fact>]
let ``InferenceConfigCreateContainer.Regression serialises with regression key`` () =
    let value = Types.InferenceConfigCreateContainer.Regression Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"regression\""

[<Fact>]
let ``InferenceConfigCreateContainer.Classification serialises with classification key`` () =
    let value = Types.InferenceConfigCreateContainer.Classification Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"classification\""

[<Fact>]
let ``InferenceConfigCreateContainer.TextClassification serialises with text_classification key`` () =
    let value = Types.InferenceConfigCreateContainer.TextClassification Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"text_classification\""

[<Fact>]
let ``InferenceConfigCreateContainer.ZeroShotClassification serialises with zero_shot_classification key`` () =
    let value = Types.InferenceConfigCreateContainer.ZeroShotClassification Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"zero_shot_classification\""

[<Fact>]
let ``InferenceConfigCreateContainer.FillMask serialises with fill_mask key`` () =
    let value = Types.InferenceConfigCreateContainer.FillMask Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"fill_mask\""

[<Fact>]
let ``InferenceConfigCreateContainer.LearningToRank serialises with learning_to_rank key`` () =
    let value = Types.InferenceConfigCreateContainer.LearningToRank Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"learning_to_rank\""

[<Fact>]
let ``InferenceConfigCreateContainer.Ner serialises with ner key`` () =
    let value = Types.InferenceConfigCreateContainer.Ner Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"ner\""

[<Fact>]
let ``InferenceConfigCreateContainer.PassThrough serialises with pass_through key`` () =
    let value = Types.InferenceConfigCreateContainer.PassThrough Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"pass_through\""

[<Fact>]
let ``InferenceConfigCreateContainer.TextEmbedding serialises with text_embedding key`` () =
    let value = Types.InferenceConfigCreateContainer.TextEmbedding Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"text_embedding\""

[<Fact>]
let ``InferenceConfigCreateContainer.TextExpansion serialises with text_expansion key`` () =
    let value = Types.InferenceConfigCreateContainer.TextExpansion Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"text_expansion\""

[<Fact>]
let ``InferenceConfigCreateContainer.QuestionAnswering serialises with question_answering key`` () =
    let value = Types.InferenceConfigCreateContainer.QuestionAnswering Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"question_answering\""

[<Fact>]
let ``InferenceConfigUpdateContainer.Regression serialises with regression key`` () =
    let value = Types.InferenceConfigUpdateContainer.Regression Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"regression\""

[<Fact>]
let ``InferenceConfigUpdateContainer.Classification serialises with classification key`` () =
    let value = Types.InferenceConfigUpdateContainer.Classification Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"classification\""

[<Fact>]
let ``InferenceConfigUpdateContainer.TextClassification serialises with text_classification key`` () =
    let value = Types.InferenceConfigUpdateContainer.TextClassification Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"text_classification\""

[<Fact>]
let ``InferenceConfigUpdateContainer.ZeroShotClassification serialises with zero_shot_classification key`` () =
    let value = Types.InferenceConfigUpdateContainer.ZeroShotClassification Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"zero_shot_classification\""

[<Fact>]
let ``InferenceConfigUpdateContainer.FillMask serialises with fill_mask key`` () =
    let value = Types.InferenceConfigUpdateContainer.FillMask Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"fill_mask\""

[<Fact>]
let ``InferenceConfigUpdateContainer.Ner serialises with ner key`` () =
    let value = Types.InferenceConfigUpdateContainer.Ner Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"ner\""

[<Fact>]
let ``InferenceConfigUpdateContainer.PassThrough serialises with pass_through key`` () =
    let value = Types.InferenceConfigUpdateContainer.PassThrough Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"pass_through\""

[<Fact>]
let ``InferenceConfigUpdateContainer.TextEmbedding serialises with text_embedding key`` () =
    let value = Types.InferenceConfigUpdateContainer.TextEmbedding Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"text_embedding\""

[<Fact>]
let ``InferenceConfigUpdateContainer.TextExpansion serialises with text_expansion key`` () =
    let value = Types.InferenceConfigUpdateContainer.TextExpansion Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"text_expansion\""

[<Fact>]
let ``InferenceConfigUpdateContainer.QuestionAnswering serialises with question_answering key`` () =
    let value = Types.InferenceConfigUpdateContainer.QuestionAnswering Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"question_answering\""

[<Fact>]
let ``TokenizationConfigContainer.Bert serialises with bert key`` () =
    let value = Types.TokenizationConfigContainer.Bert Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"bert\""

[<Fact>]
let ``TokenizationConfigContainer.BertJa serialises with bert_ja key`` () =
    let value = Types.TokenizationConfigContainer.BertJa Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"bert_ja\""

[<Fact>]
let ``TokenizationConfigContainer.Mpnet serialises with mpnet key`` () =
    let value = Types.TokenizationConfigContainer.Mpnet Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"mpnet\""

[<Fact>]
let ``TokenizationConfigContainer.Roberta serialises with roberta key`` () =
    let value = Types.TokenizationConfigContainer.Roberta Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"roberta\""

[<Fact>]
let ``TokenizationConfigContainer.XlmRoberta serialises with xlm_roberta key`` () =
    let value = Types.TokenizationConfigContainer.XlmRoberta Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"xlm_roberta\""

[<Fact>]
let ``Preprocessor.FrequencyEncoding serialises with frequency_encoding key`` () =
    let value = Types.Preprocessor.FrequencyEncoding Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"frequency_encoding\""

[<Fact>]
let ``Preprocessor.OneHotEncoding serialises with one_hot_encoding key`` () =
    let value = Types.Preprocessor.OneHotEncoding Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"one_hot_encoding\""

[<Fact>]
let ``Preprocessor.TargetMeanEncoding serialises with target_mean_encoding key`` () =
    let value = Types.Preprocessor.TargetMeanEncoding Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"target_mean_encoding\""

[<Fact>]
let ``RoleMappingRule.Any serialises with any key`` () =
    let value = Types.RoleMappingRule.Any Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"any\""

[<Fact>]
let ``RoleMappingRule.All serialises with all key`` () =
    let value = Types.RoleMappingRule.All Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"all\""

[<Fact>]
let ``RoleMappingRule.Field serialises with field key`` () =
    let value = Types.RoleMappingRule.Field Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"field\""

[<Fact>]
let ``RoleMappingRule.Except serialises with except key`` () =
    let value = Types.RoleMappingRule.Except Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"except\""

[<Fact>]
let ``ApiKeyAggregationContainer.Cardinality serialises with cardinality key`` () =
    let value = Types.ApiKeyAggregationContainer.Cardinality Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"cardinality\""

[<Fact>]
let ``ApiKeyAggregationContainer.Composite serialises with composite key`` () =
    let value = Types.ApiKeyAggregationContainer.Composite Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"composite\""

[<Fact>]
let ``ApiKeyAggregationContainer.DateRange serialises with date_range key`` () =
    let value = Types.ApiKeyAggregationContainer.DateRange Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"date_range\""

[<Fact>]
let ``ApiKeyAggregationContainer.Filter serialises with filter key`` () =
    let value = Types.ApiKeyAggregationContainer.Filter Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"filter\""

[<Fact>]
let ``ApiKeyAggregationContainer.Filters serialises with filters key`` () =
    let value = Types.ApiKeyAggregationContainer.Filters Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"filters\""

[<Fact>]
let ``ApiKeyAggregationContainer.Missing serialises with missing key`` () =
    let value = Types.ApiKeyAggregationContainer.Missing Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"missing\""

[<Fact>]
let ``ApiKeyAggregationContainer.Range serialises with range key`` () =
    let value = Types.ApiKeyAggregationContainer.Range Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"range\""

[<Fact>]
let ``ApiKeyAggregationContainer.Terms serialises with terms key`` () =
    let value = Types.ApiKeyAggregationContainer.Terms Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"terms\""

[<Fact>]
let ``ApiKeyAggregationContainer.ValueCount serialises with value_count key`` () =
    let value = Types.ApiKeyAggregationContainer.ValueCount Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"value_count\""

[<Fact>]
let ``ApiKeyQueryContainer.Bool serialises with bool key`` () =
    let value = Types.ApiKeyQueryContainer.Bool Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"bool\""

[<Fact>]
let ``ApiKeyQueryContainer.Exists serialises with exists key`` () =
    let value = Types.ApiKeyQueryContainer.Exists Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"exists\""

[<Fact>]
let ``ApiKeyQueryContainer.Ids serialises with ids key`` () =
    let value = Types.ApiKeyQueryContainer.Ids Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"ids\""

[<Fact>]
let ``ApiKeyQueryContainer.Match serialises with match key`` () =
    let value = Types.ApiKeyQueryContainer.Match Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"match\""

[<Fact>]
let ``ApiKeyQueryContainer.MatchAll serialises with match_all key`` () =
    let value = Types.ApiKeyQueryContainer.MatchAll Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"match_all\""

[<Fact>]
let ``ApiKeyQueryContainer.Prefix serialises with prefix key`` () =
    let value = Types.ApiKeyQueryContainer.Prefix Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"prefix\""

[<Fact>]
let ``ApiKeyQueryContainer.Range serialises with range key`` () =
    let value = Types.ApiKeyQueryContainer.Range Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"range\""

[<Fact>]
let ``ApiKeyQueryContainer.SimpleQueryString serialises with simple_query_string key`` () =
    let value = Types.ApiKeyQueryContainer.SimpleQueryString Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"simple_query_string\""

[<Fact>]
let ``ApiKeyQueryContainer.Term serialises with term key`` () =
    let value = Types.ApiKeyQueryContainer.Term Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"term\""

[<Fact>]
let ``ApiKeyQueryContainer.Terms serialises with terms key`` () =
    let value = Types.ApiKeyQueryContainer.Terms Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"terms\""

[<Fact>]
let ``ApiKeyQueryContainer.Wildcard serialises with wildcard key`` () =
    let value = Types.ApiKeyQueryContainer.Wildcard Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"wildcard\""

[<Fact>]
let ``RoleQueryContainer.Bool serialises with bool key`` () =
    let value = Types.RoleQueryContainer.Bool Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"bool\""

[<Fact>]
let ``RoleQueryContainer.Exists serialises with exists key`` () =
    let value = Types.RoleQueryContainer.Exists Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"exists\""

[<Fact>]
let ``RoleQueryContainer.Ids serialises with ids key`` () =
    let value = Types.RoleQueryContainer.Ids Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"ids\""

[<Fact>]
let ``RoleQueryContainer.Match serialises with match key`` () =
    let value = Types.RoleQueryContainer.Match Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"match\""

[<Fact>]
let ``RoleQueryContainer.MatchAll serialises with match_all key`` () =
    let value = Types.RoleQueryContainer.MatchAll Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"match_all\""

[<Fact>]
let ``RoleQueryContainer.Prefix serialises with prefix key`` () =
    let value = Types.RoleQueryContainer.Prefix Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"prefix\""

[<Fact>]
let ``RoleQueryContainer.Range serialises with range key`` () =
    let value = Types.RoleQueryContainer.Range Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"range\""

[<Fact>]
let ``RoleQueryContainer.SimpleQueryString serialises with simple_query_string key`` () =
    let value = Types.RoleQueryContainer.SimpleQueryString Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"simple_query_string\""

[<Fact>]
let ``RoleQueryContainer.Term serialises with term key`` () =
    let value = Types.RoleQueryContainer.Term Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"term\""

[<Fact>]
let ``RoleQueryContainer.Terms serialises with terms key`` () =
    let value = Types.RoleQueryContainer.Terms Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"terms\""

[<Fact>]
let ``RoleQueryContainer.Wildcard serialises with wildcard key`` () =
    let value = Types.RoleQueryContainer.Wildcard Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"wildcard\""

[<Fact>]
let ``UserQueryContainer.Ids serialises with ids key`` () =
    let value = Types.UserQueryContainer.Ids Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"ids\""

[<Fact>]
let ``UserQueryContainer.Bool serialises with bool key`` () =
    let value = Types.UserQueryContainer.Bool Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"bool\""

[<Fact>]
let ``UserQueryContainer.Exists serialises with exists key`` () =
    let value = Types.UserQueryContainer.Exists Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"exists\""

[<Fact>]
let ``UserQueryContainer.Match serialises with match key`` () =
    let value = Types.UserQueryContainer.Match Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"match\""

[<Fact>]
let ``UserQueryContainer.MatchAll serialises with match_all key`` () =
    let value = Types.UserQueryContainer.MatchAll Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"match_all\""

[<Fact>]
let ``UserQueryContainer.Prefix serialises with prefix key`` () =
    let value = Types.UserQueryContainer.Prefix Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"prefix\""

[<Fact>]
let ``UserQueryContainer.Range serialises with range key`` () =
    let value = Types.UserQueryContainer.Range Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"range\""

[<Fact>]
let ``UserQueryContainer.SimpleQueryString serialises with simple_query_string key`` () =
    let value = Types.UserQueryContainer.SimpleQueryString Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"simple_query_string\""

[<Fact>]
let ``UserQueryContainer.Term serialises with term key`` () =
    let value = Types.UserQueryContainer.Term Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"term\""

[<Fact>]
let ``UserQueryContainer.Terms serialises with terms key`` () =
    let value = Types.UserQueryContainer.Terms Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"terms\""

[<Fact>]
let ``UserQueryContainer.Wildcard serialises with wildcard key`` () =
    let value = Types.UserQueryContainer.Wildcard Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"wildcard\""

[<Fact>]
let ``PivotGroupByContainer.DateHistogram serialises with date_histogram key`` () =
    let value = Types.PivotGroupByContainer.DateHistogram Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"date_histogram\""

[<Fact>]
let ``PivotGroupByContainer.GeotileGrid serialises with geotile_grid key`` () =
    let value = Types.PivotGroupByContainer.GeotileGrid Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"geotile_grid\""

[<Fact>]
let ``PivotGroupByContainer.Histogram serialises with histogram key`` () =
    let value = Types.PivotGroupByContainer.Histogram Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"histogram\""

[<Fact>]
let ``PivotGroupByContainer.Terms serialises with terms key`` () =
    let value = Types.PivotGroupByContainer.Terms Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"terms\""

[<Fact>]
let ``RetentionPolicyContainer.Time serialises with time key`` () =
    let value = Types.RetentionPolicyContainer.Time Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"time\""

[<Fact>]
let ``SyncContainer.Time serialises with time key`` () =
    let value = Types.SyncContainer.Time Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"time\""

[<Fact>]
let ``ConditionContainer.Always serialises with always key`` () =
    let value = Types.ConditionContainer.Always Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"always\""

[<Fact>]
let ``ConditionContainer.ArrayCompare serialises with array_compare key`` () =
    let value = Types.ConditionContainer.ArrayCompare Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"array_compare\""

[<Fact>]
let ``ConditionContainer.Compare serialises with compare key`` () =
    let value = Types.ConditionContainer.Compare Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"compare\""

[<Fact>]
let ``ConditionContainer.Never serialises with never key`` () =
    let value = Types.ConditionContainer.Never Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"never\""

[<Fact>]
let ``ConditionContainer.Script serialises with script key`` () =
    let value = Types.ConditionContainer.Script Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"script\""

[<Fact>]
let ``EmailAttachmentContainer.Http serialises with http key`` () =
    let value = Types.EmailAttachmentContainer.Http Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"http\""

[<Fact>]
let ``EmailAttachmentContainer.Reporting serialises with reporting key`` () =
    let value = Types.EmailAttachmentContainer.Reporting Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"reporting\""

[<Fact>]
let ``EmailAttachmentContainer.Data serialises with data key`` () =
    let value = Types.EmailAttachmentContainer.Data Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"data\""

[<Fact>]
let ``InputContainer.Chain serialises with chain key`` () =
    let value = Types.InputContainer.Chain Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"chain\""

[<Fact>]
let ``InputContainer.Http serialises with http key`` () =
    let value = Types.InputContainer.Http Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"http\""

[<Fact>]
let ``InputContainer.Search serialises with search key`` () =
    let value = Types.InputContainer.Search Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"search\""

[<Fact>]
let ``InputContainer.Simple serialises with simple key`` () =
    let value = Types.InputContainer.Simple Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"simple\""

[<Fact>]
let ``ScheduleContainer.Timezone serialises with timezone key`` () =
    let value = Types.ScheduleContainer.Timezone Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"timezone\""

[<Fact>]
let ``ScheduleContainer.Cron serialises with cron key`` () =
    let value = Types.ScheduleContainer.Cron Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"cron\""

[<Fact>]
let ``ScheduleContainer.Daily serialises with daily key`` () =
    let value = Types.ScheduleContainer.Daily Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"daily\""

[<Fact>]
let ``ScheduleContainer.Hourly serialises with hourly key`` () =
    let value = Types.ScheduleContainer.Hourly Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"hourly\""

[<Fact>]
let ``ScheduleContainer.Interval serialises with interval key`` () =
    let value = Types.ScheduleContainer.Interval Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"interval\""

[<Fact>]
let ``ScheduleContainer.Monthly serialises with monthly key`` () =
    let value = Types.ScheduleContainer.Monthly Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"monthly\""

[<Fact>]
let ``ScheduleContainer.Weekly serialises with weekly key`` () =
    let value = Types.ScheduleContainer.Weekly Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"weekly\""

[<Fact>]
let ``ScheduleContainer.Yearly serialises with yearly key`` () =
    let value = Types.ScheduleContainer.Yearly Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"yearly\""

[<Fact>]
let ``TriggerContainer.Schedule serialises with schedule key`` () =
    let value = Types.TriggerContainer.Schedule Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"schedule\""

[<Fact>]
let ``TriggerEventContainer.Schedule serialises with schedule key`` () =
    let value = Types.TriggerEventContainer.Schedule Unchecked.defaultof<_>
    let json = Json.serialize value
    json |> should haveSubstring "\"schedule\""


// Auto-generated container variant tests — do not edit manually

module Fes.Tests.Generated.VariantTests

open Xunit
open FsUnit.Xunit
open Fes
open Fes.Generated

[<Fact>]
let ``OperationContainer.Index serialises with index key`` () =
    let value = Types.OperationContainer.Index (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"index\""

[<Fact>]
let ``OperationContainer.Create serialises with create key`` () =
    let value = Types.OperationContainer.Create (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"create\""

[<Fact>]
let ``OperationContainer.Delete serialises with delete key`` () =
    let value = Types.OperationContainer.Delete (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"delete\""

[<Fact>]
let ``TransformContainer.Chain serialises with chain key`` () =
    let value = Types.TransformContainer.Chain []
    let json = Json.serialize value
    json |> should haveSubstring "\"chain\""

[<Fact>]
let ``AggregationContainer.Avg serialises with avg key`` () =
    let value = Types.AggregationContainer.Avg (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"avg\""

[<Fact>]
let ``AggregationContainer.AvgBucket serialises with avg_bucket key`` () =
    let value = Types.AggregationContainer.AvgBucket (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"avg_bucket\""

[<Fact>]
let ``AggregationContainer.CartesianBounds serialises with cartesian_bounds key`` () =
    let value = Types.AggregationContainer.CartesianBounds (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"cartesian_bounds\""

[<Fact>]
let ``AggregationContainer.CartesianCentroid serialises with cartesian_centroid key`` () =
    let value = Types.AggregationContainer.CartesianCentroid (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"cartesian_centroid\""

[<Fact>]
let ``AggregationContainer.ChangePoint serialises with change_point key`` () =
    let value = Types.AggregationContainer.ChangePoint (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"change_point\""

[<Fact>]
let ``AggregationContainer.CumulativeCardinality serialises with cumulative_cardinality key`` () =
    let value = Types.AggregationContainer.CumulativeCardinality (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"cumulative_cardinality\""

[<Fact>]
let ``AggregationContainer.CumulativeSum serialises with cumulative_sum key`` () =
    let value = Types.AggregationContainer.CumulativeSum (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"cumulative_sum\""

[<Fact>]
let ``AggregationContainer.Derivative serialises with derivative key`` () =
    let value = Types.AggregationContainer.Derivative (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"derivative\""

[<Fact>]
let ``AggregationContainer.Global serialises with global key`` () =
    let value = Types.AggregationContainer.Global (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"global\""

[<Fact>]
let ``AggregationContainer.Max serialises with max key`` () =
    let value = Types.AggregationContainer.Max (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"max\""

[<Fact>]
let ``AggregationContainer.MaxBucket serialises with max_bucket key`` () =
    let value = Types.AggregationContainer.MaxBucket (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"max_bucket\""

[<Fact>]
let ``AggregationContainer.Min serialises with min key`` () =
    let value = Types.AggregationContainer.Min (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"min\""

[<Fact>]
let ``AggregationContainer.MinBucket serialises with min_bucket key`` () =
    let value = Types.AggregationContainer.MinBucket (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"min_bucket\""

[<Fact>]
let ``AggregationContainer.Stats serialises with stats key`` () =
    let value = Types.AggregationContainer.Stats (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"stats\""

[<Fact>]
let ``AggregationContainer.StatsBucket serialises with stats_bucket key`` () =
    let value = Types.AggregationContainer.StatsBucket (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"stats_bucket\""

[<Fact>]
let ``AggregationContainer.Sum serialises with sum key`` () =
    let value = Types.AggregationContainer.Sum (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"sum\""

[<Fact>]
let ``AggregationContainer.SumBucket serialises with sum_bucket key`` () =
    let value = Types.AggregationContainer.SumBucket (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"sum_bucket\""

[<Fact>]
let ``AggregationContainer.ValueCount serialises with value_count key`` () =
    let value = Types.AggregationContainer.ValueCount (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"value_count\""

[<Fact>]
let ``ChangeType.Dip serialises with dip key`` () =
    let value = Types.ChangeType.Dip (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"dip\""

[<Fact>]
let ``ChangeType.DistributionChange serialises with distribution_change key`` () =
    let value = Types.ChangeType.DistributionChange (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"distribution_change\""

[<Fact>]
let ``ChangeType.Spike serialises with spike key`` () =
    let value = Types.ChangeType.Spike (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"spike\""

[<Fact>]
let ``ChangeType.Stationary serialises with stationary key`` () =
    let value = Types.ChangeType.Stationary (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"stationary\""

[<Fact>]
let ``ChangeType.StepChange serialises with step_change key`` () =
    let value = Types.ChangeType.StepChange (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"step_change\""

[<Fact>]
let ``CompositeAggregationSource.Terms serialises with terms key`` () =
    let value = Types.CompositeAggregationSource.Terms (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"terms\""

[<Fact>]
let ``MultiTermLookup.Field serialises with field key`` () =
    let value = Types.MultiTermLookup.Field "test"
    let json = Json.serialize value
    json |> should haveSubstring "\"field\""

[<Fact>]
let ``GeoGridQuery.Geotile serialises with geotile key`` () =
    let value = Types.GeoGridQuery.Geotile "test"
    let json = Json.serialize value
    json |> should haveSubstring "\"geotile\""

[<Fact>]
let ``GeoGridQuery.Geohash serialises with geohash key`` () =
    let value = Types.GeoGridQuery.Geohash "test"
    let json = Json.serialize value
    json |> should haveSubstring "\"geohash\""

[<Fact>]
let ``GeoGridQuery.Geohex serialises with geohex key`` () =
    let value = Types.GeoGridQuery.Geohex "test"
    let json = Json.serialize value
    json |> should haveSubstring "\"geohex\""

[<Fact>]
let ``PinnedQuery.Ids serialises with ids key`` () =
    let value = Types.PinnedQuery.Ids []
    let json = Json.serialize value
    json |> should haveSubstring "\"ids\""

[<Fact>]
let ``PinnedQuery.Docs serialises with docs key`` () =
    let value = Types.PinnedQuery.Docs []
    let json = Json.serialize value
    json |> should haveSubstring "\"docs\""

[<Fact>]
let ``QueryContainer.MatchAll serialises with match_all key`` () =
    let value = Types.QueryContainer.MatchAll (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"match_all\""

[<Fact>]
let ``QueryContainer.MatchNone serialises with match_none key`` () =
    let value = Types.QueryContainer.MatchNone (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"match_none\""

[<Fact>]
let ``QueryContainer.Terms serialises with terms key`` () =
    let value = Types.QueryContainer.Terms (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"terms\""

[<Fact>]
let ``SparseVectorQuery.QueryVector serialises with query_vector key`` () =
    let value = Types.SparseVectorQuery.QueryVector Map.empty
    let json = Json.serialize value
    json |> should haveSubstring "\"query_vector\""

[<Fact>]
let ``SparseVectorQuery.InferenceId serialises with inference_id key`` () =
    let value = Types.SparseVectorQuery.InferenceId "test"
    let json = Json.serialize value
    json |> should haveSubstring "\"inference_id\""

[<Fact>]
let ``TableValuesContainer.Integer serialises with integer key`` () =
    let value = Types.TableValuesContainer.Integer []
    let json = Json.serialize value
    json |> should haveSubstring "\"integer\""

[<Fact>]
let ``TableValuesContainer.Keyword serialises with keyword key`` () =
    let value = Types.TableValuesContainer.Keyword []
    let json = Json.serialize value
    json |> should haveSubstring "\"keyword\""

[<Fact>]
let ``TableValuesContainer.Long serialises with long key`` () =
    let value = Types.TableValuesContainer.Long []
    let json = Json.serialize value
    json |> should haveSubstring "\"long\""

[<Fact>]
let ``TableValuesContainer.Double serialises with double key`` () =
    let value = Types.TableValuesContainer.Double []
    let json = Json.serialize value
    json |> should haveSubstring "\"double\""

[<Fact>]
let ``EmbeddingInferenceResult.EmbeddingsBytes serialises with embeddings_bytes key`` () =
    let value = Types.EmbeddingInferenceResult.EmbeddingsBytes []
    let json = Json.serialize value
    json |> should haveSubstring "\"embeddings_bytes\""

[<Fact>]
let ``EmbeddingInferenceResult.EmbeddingsBits serialises with embeddings_bits key`` () =
    let value = Types.EmbeddingInferenceResult.EmbeddingsBits []
    let json = Json.serialize value
    json |> should haveSubstring "\"embeddings_bits\""

[<Fact>]
let ``EmbeddingInferenceResult.Embeddings serialises with embeddings key`` () =
    let value = Types.EmbeddingInferenceResult.Embeddings []
    let json = Json.serialize value
    json |> should haveSubstring "\"embeddings\""

[<Fact>]
let ``InferenceResult.EmbeddingsBytes serialises with embeddings_bytes key`` () =
    let value = Types.InferenceResult.EmbeddingsBytes []
    let json = Json.serialize value
    json |> should haveSubstring "\"embeddings_bytes\""

[<Fact>]
let ``InferenceResult.EmbeddingsBits serialises with embeddings_bits key`` () =
    let value = Types.InferenceResult.EmbeddingsBits []
    let json = Json.serialize value
    json |> should haveSubstring "\"embeddings_bits\""

[<Fact>]
let ``InferenceResult.Embeddings serialises with embeddings key`` () =
    let value = Types.InferenceResult.Embeddings []
    let json = Json.serialize value
    json |> should haveSubstring "\"embeddings\""

[<Fact>]
let ``InferenceResult.TextEmbeddingBytes serialises with text_embedding_bytes key`` () =
    let value = Types.InferenceResult.TextEmbeddingBytes []
    let json = Json.serialize value
    json |> should haveSubstring "\"text_embedding_bytes\""

[<Fact>]
let ``InferenceResult.TextEmbeddingBits serialises with text_embedding_bits key`` () =
    let value = Types.InferenceResult.TextEmbeddingBits []
    let json = Json.serialize value
    json |> should haveSubstring "\"text_embedding_bits\""

[<Fact>]
let ``InferenceResult.TextEmbedding serialises with text_embedding key`` () =
    let value = Types.InferenceResult.TextEmbedding []
    let json = Json.serialize value
    json |> should haveSubstring "\"text_embedding\""

[<Fact>]
let ``InferenceResult.SparseEmbedding serialises with sparse_embedding key`` () =
    let value = Types.InferenceResult.SparseEmbedding []
    let json = Json.serialize value
    json |> should haveSubstring "\"sparse_embedding\""

[<Fact>]
let ``InferenceResult.Completion serialises with completion key`` () =
    let value = Types.InferenceResult.Completion []
    let json = Json.serialize value
    json |> should haveSubstring "\"completion\""

[<Fact>]
let ``InferenceResult.Rerank serialises with rerank key`` () =
    let value = Types.InferenceResult.Rerank []
    let json = Json.serialize value
    json |> should haveSubstring "\"rerank\""

[<Fact>]
let ``TextEmbeddingInferenceResult.TextEmbeddingBytes serialises with text_embedding_bytes key`` () =
    let value = Types.TextEmbeddingInferenceResult.TextEmbeddingBytes []
    let json = Json.serialize value
    json |> should haveSubstring "\"text_embedding_bytes\""

[<Fact>]
let ``TextEmbeddingInferenceResult.TextEmbeddingBits serialises with text_embedding_bits key`` () =
    let value = Types.TextEmbeddingInferenceResult.TextEmbeddingBits []
    let json = Json.serialize value
    json |> should haveSubstring "\"text_embedding_bits\""

[<Fact>]
let ``TextEmbeddingInferenceResult.TextEmbedding serialises with text_embedding key`` () =
    let value = Types.TextEmbeddingInferenceResult.TextEmbedding []
    let json = Json.serialize value
    json |> should haveSubstring "\"text_embedding\""

[<Fact>]
let ``DatabaseConfiguration.Ipinfo serialises with ipinfo key`` () =
    let value = Types.DatabaseConfiguration.Ipinfo (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"ipinfo\""

[<Fact>]
let ``DatabaseConfigurationFull.Web serialises with web key`` () =
    let value = Types.DatabaseConfigurationFull.Web (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"web\""

[<Fact>]
let ``DatabaseConfigurationFull.Ipinfo serialises with ipinfo key`` () =
    let value = Types.DatabaseConfigurationFull.Ipinfo (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"ipinfo\""

[<Fact>]
let ``ProcessorContainer.Drop serialises with drop key`` () =
    let value = Types.ProcessorContainer.Drop (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"drop\""

[<Fact>]
let ``ProcessorContainer.Terminate serialises with terminate key`` () =
    let value = Types.ProcessorContainer.Terminate (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"terminate\""

[<Fact>]
let ``TokenizationConfigContainer.Bert serialises with bert key`` () =
    let value = Types.TokenizationConfigContainer.Bert (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"bert\""

[<Fact>]
let ``TokenizationConfigContainer.BertJa serialises with bert_ja key`` () =
    let value = Types.TokenizationConfigContainer.BertJa (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"bert_ja\""

[<Fact>]
let ``TokenizationConfigContainer.Mpnet serialises with mpnet key`` () =
    let value = Types.TokenizationConfigContainer.Mpnet (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"mpnet\""

[<Fact>]
let ``TokenizationConfigContainer.XlmRoberta serialises with xlm_roberta key`` () =
    let value = Types.TokenizationConfigContainer.XlmRoberta (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"xlm_roberta\""

[<Fact>]
let ``RoleMappingRule.Any serialises with any key`` () =
    let value = Types.RoleMappingRule.Any []
    let json = Json.serialize value
    json |> should haveSubstring "\"any\""

[<Fact>]
let ``RoleMappingRule.All serialises with all key`` () =
    let value = Types.RoleMappingRule.All []
    let json = Json.serialize value
    json |> should haveSubstring "\"all\""

[<Fact>]
let ``ApiKeyAggregationContainer.ValueCount serialises with value_count key`` () =
    let value = Types.ApiKeyAggregationContainer.ValueCount (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"value_count\""

[<Fact>]
let ``ApiKeyQueryContainer.MatchAll serialises with match_all key`` () =
    let value = Types.ApiKeyQueryContainer.MatchAll (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"match_all\""

[<Fact>]
let ``ApiKeyQueryContainer.Terms serialises with terms key`` () =
    let value = Types.ApiKeyQueryContainer.Terms (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"terms\""

[<Fact>]
let ``RoleQueryContainer.MatchAll serialises with match_all key`` () =
    let value = Types.RoleQueryContainer.MatchAll (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"match_all\""

[<Fact>]
let ``RoleQueryContainer.Terms serialises with terms key`` () =
    let value = Types.RoleQueryContainer.Terms (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"terms\""

[<Fact>]
let ``UserQueryContainer.MatchAll serialises with match_all key`` () =
    let value = Types.UserQueryContainer.MatchAll (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"match_all\""

[<Fact>]
let ``UserQueryContainer.Terms serialises with terms key`` () =
    let value = Types.UserQueryContainer.Terms (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"terms\""

[<Fact>]
let ``ConditionContainer.Always serialises with always key`` () =
    let value = Types.ConditionContainer.Always (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"always\""

[<Fact>]
let ``ConditionContainer.Never serialises with never key`` () =
    let value = Types.ConditionContainer.Never (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"never\""

[<Fact>]
let ``InputContainer.Simple serialises with simple key`` () =
    let value = Types.InputContainer.Simple Map.empty
    let json = Json.serialize value
    json |> should haveSubstring "\"simple\""

[<Fact>]
let ``ScheduleContainer.Timezone serialises with timezone key`` () =
    let value = Types.ScheduleContainer.Timezone "test"
    let json = Json.serialize value
    json |> should haveSubstring "\"timezone\""

[<Fact>]
let ``ScheduleContainer.Cron serialises with cron key`` () =
    let value = Types.ScheduleContainer.Cron "test"
    let json = Json.serialize value
    json |> should haveSubstring "\"cron\""


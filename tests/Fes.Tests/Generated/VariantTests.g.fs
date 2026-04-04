// Auto-generated container variant tests — do not edit manually

module Fes.Tests.Generated.VariantTests

open Xunit
open FsUnit.Xunit
open Fes
open Fes.Generated

[<Fact>]
let ``TransformContainer.Chain serialises with chain key`` () =
    let value = Types.TransformContainer.Chain []
    let json = Json.serialize value
    json |> should haveSubstring "\"chain\""

[<Fact>]
let ``AggregationContainer.Global serialises with global key`` () =
    let value = Types.AggregationContainer.Global (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"global\""

[<Fact>]
let ``ChangeType.Stationary serialises with stationary key`` () =
    let value = Types.ChangeType.Stationary (System.Text.Json.JsonDocument.Parse("{}").RootElement)
    let json = Json.serialize value
    json |> should haveSubstring "\"stationary\""

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


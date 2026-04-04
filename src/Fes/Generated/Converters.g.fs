// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated


open Fes.Generated
open Fes.Generated.Types

module Converters =

    type FailureStoreStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<FailureStoreStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | FailureStoreStatus.NotApplicableOrUnknown -> "not_applicable_or_unknown"
                | FailureStoreStatus.Used -> "used"
                | FailureStoreStatus.NotEnabled -> "not_enabled"
                | FailureStoreStatus.Failed -> "failed"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "not_applicable_or_unknown" -> FailureStoreStatus.NotApplicableOrUnknown
            | "used" -> FailureStoreStatus.Used
            | "not_enabled" -> FailureStoreStatus.NotEnabled
            | "failed" -> FailureStoreStatus.Failed
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FailureStoreStatus"))

    type OperationContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<OperationContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | OperationContainer.Index v ->
                writer.WritePropertyName("index")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | OperationContainer.Create v ->
                writer.WritePropertyName("create")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | OperationContainer.Update v ->
                writer.WritePropertyName("update")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | OperationContainer.Delete v ->
                writer.WritePropertyName("delete")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for OperationContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for OperationContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "index" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IndexOperation>(&reader, options)
                    OperationContainer.Index v
                | "create" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.CreateOperation>(&reader, options)
                    OperationContainer.Create v
                | "update" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.UpdateOperation>(&reader, options)
                    OperationContainer.Update v
                | "delete" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DeleteOperation>(&reader, options)
                    OperationContainer.Delete v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for OperationContainer"))
            reader.Read() |> ignore // EndObject
            result

    type OperationTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<OperationType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | OperationType.Index -> "index"
                | OperationType.Create -> "create"
                | OperationType.Update -> "update"
                | OperationType.Delete -> "delete"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "index" -> OperationType.Index
            | "create" -> OperationType.Create
            | "update" -> OperationType.Update
            | "delete" -> OperationType.Delete
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for OperationType"))

    type RestMethodConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<RestMethod>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | RestMethod.GET -> "GET"
                | RestMethod.HEAD -> "HEAD"
                | RestMethod.POST -> "POST"
                | RestMethod.PUT -> "PUT"
                | RestMethod.DELETE -> "DELETE"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "GET" -> RestMethod.GET
            | "HEAD" -> RestMethod.HEAD
            | "POST" -> RestMethod.POST
            | "PUT" -> RestMethod.PUT
            | "DELETE" -> RestMethod.DELETE
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for RestMethod"))

    type ImpactAreaConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ImpactArea>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ImpactArea.Search -> "search"
                | ImpactArea.Ingest -> "ingest"
                | ImpactArea.Backup -> "backup"
                | ImpactArea.DeploymentManagement -> "deployment_management"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "search" -> ImpactArea.Search
            | "ingest" -> ImpactArea.Ingest
            | "backup" -> ImpactArea.Backup
            | "deployment_management" -> ImpactArea.DeploymentManagement
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ImpactArea"))

    type IndicatorHealthStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicatorHealthStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicatorHealthStatus.Green -> "green"
                | IndicatorHealthStatus.Yellow -> "yellow"
                | IndicatorHealthStatus.Red -> "red"
                | IndicatorHealthStatus.Unknown -> "unknown"
                | IndicatorHealthStatus.Unavailable -> "unavailable"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "green" -> IndicatorHealthStatus.Green
            | "yellow" -> IndicatorHealthStatus.Yellow
            | "red" -> IndicatorHealthStatus.Red
            | "unknown" -> IndicatorHealthStatus.Unknown
            | "unavailable" -> IndicatorHealthStatus.Unavailable
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IndicatorHealthStatus"))

    type PainlessContextConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<PainlessContext>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | PainlessContext.PainlessTest -> "painless_test"
                | PainlessContext.Filter -> "filter"
                | PainlessContext.Score -> "score"
                | PainlessContext.BooleanField -> "boolean_field"
                | PainlessContext.DateField -> "date_field"
                | PainlessContext.DoubleField -> "double_field"
                | PainlessContext.GeoPointField -> "geo_point_field"
                | PainlessContext.IpField -> "ip_field"
                | PainlessContext.KeywordField -> "keyword_field"
                | PainlessContext.LongField -> "long_field"
                | PainlessContext.CompositeField -> "composite_field"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "painless_test" -> PainlessContext.PainlessTest
            | "filter" -> PainlessContext.Filter
            | "score" -> PainlessContext.Score
            | "boolean_field" -> PainlessContext.BooleanField
            | "date_field" -> PainlessContext.DateField
            | "double_field" -> PainlessContext.DoubleField
            | "geo_point_field" -> PainlessContext.GeoPointField
            | "ip_field" -> PainlessContext.IpField
            | "keyword_field" -> PainlessContext.KeywordField
            | "long_field" -> PainlessContext.LongField
            | "composite_field" -> PainlessContext.CompositeField
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for PainlessContext"))

    type BoundaryScannerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<BoundaryScanner>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | BoundaryScanner.Chars -> "chars"
                | BoundaryScanner.Sentence -> "sentence"
                | BoundaryScanner.Word -> "word"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chars" -> BoundaryScanner.Chars
            | "sentence" -> BoundaryScanner.Sentence
            | "word" -> BoundaryScanner.Word
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for BoundaryScanner"))

    type FieldSuggesterConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<FieldSuggester>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | FieldSuggester.Completion v ->
                writer.WritePropertyName("completion")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | FieldSuggester.Phrase v ->
                writer.WritePropertyName("phrase")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | FieldSuggester.Term v ->
                writer.WritePropertyName("term")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | FieldSuggester.Unknown (name, el) ->
                writer.WritePropertyName(name)
                el.WriteTo(writer)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for FieldSuggester"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for FieldSuggester"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "completion" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.CompletionSuggester>(&reader, options)
                    FieldSuggester.Completion v
                | "phrase" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.PhraseSuggester>(&reader, options)
                    FieldSuggester.Phrase v
                | "term" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TermSuggester>(&reader, options)
                    FieldSuggester.Term v
                | other ->
                    let el = System.Text.Json.JsonElement.ParseValue(&reader)
                    FieldSuggester.Unknown (other, el)
            reader.Read() |> ignore // EndObject
            result

    type HighlighterEncoderConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<HighlighterEncoder>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | HighlighterEncoder.Default -> "default"
                | HighlighterEncoder.Html -> "html"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "default" -> HighlighterEncoder.Default
            | "html" -> HighlighterEncoder.Html
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for HighlighterEncoder"))

    type HighlighterFragmenterConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<HighlighterFragmenter>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | HighlighterFragmenter.Simple -> "simple"
                | HighlighterFragmenter.Span -> "span"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "simple" -> HighlighterFragmenter.Simple
            | "span" -> HighlighterFragmenter.Span
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for HighlighterFragmenter"))

    type HighlighterOrderConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<HighlighterOrder>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | HighlighterOrder.Score -> "score"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "score" -> HighlighterOrder.Score
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for HighlighterOrder"))

    type HighlighterTagsSchemaConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<HighlighterTagsSchema>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | HighlighterTagsSchema.Styled -> "styled"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "styled" -> HighlighterTagsSchema.Styled
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for HighlighterTagsSchema"))

    type HighlighterTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<HighlighterType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | HighlighterType.Plain -> "plain"
                | HighlighterType.Fvh -> "fvh"
                | HighlighterType.Unified -> "unified"
                | HighlighterType.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "plain" -> HighlighterType.Plain
            | "fvh" -> HighlighterType.Fvh
            | "unified" -> HighlighterType.Unified
            | other -> HighlighterType.Custom other

    type RescoreConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Rescore>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | Rescore.Query v ->
                writer.WritePropertyName("query")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Rescore.LearningToRank v ->
                writer.WritePropertyName("learning_to_rank")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Rescore.Script v ->
                writer.WritePropertyName("script")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Rescore.Unknown (name, el) ->
                writer.WritePropertyName(name)
                el.WriteTo(writer)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for Rescore"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for Rescore"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "query" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RescoreQuery>(&reader, options)
                    Rescore.Query v
                | "learning_to_rank" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.LearningToRank>(&reader, options)
                    Rescore.LearningToRank v
                | "script" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ScriptRescore>(&reader, options)
                    Rescore.Script v
                | other ->
                    let el = System.Text.Json.JsonElement.ParseValue(&reader)
                    Rescore.Unknown (other, el)
            reader.Read() |> ignore // EndObject
            result

    type ScoreModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ScoreMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ScoreMode.Avg -> "avg"
                | ScoreMode.Max -> "max"
                | ScoreMode.Min -> "min"
                | ScoreMode.Multiply -> "multiply"
                | ScoreMode.Total -> "total"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "avg" -> ScoreMode.Avg
            | "max" -> ScoreMode.Max
            | "min" -> ScoreMode.Min
            | "multiply" -> ScoreMode.Multiply
            | "total" -> ScoreMode.Total
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ScoreMode"))

    type SmoothingModelContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SmoothingModelContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | SmoothingModelContainer.Laplace v ->
                writer.WritePropertyName("laplace")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SmoothingModelContainer.LinearInterpolation v ->
                writer.WritePropertyName("linear_interpolation")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SmoothingModelContainer.StupidBackoff v ->
                writer.WritePropertyName("stupid_backoff")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for SmoothingModelContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for SmoothingModelContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "laplace" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.LaplaceSmoothingModel>(&reader, options)
                    SmoothingModelContainer.Laplace v
                | "linear_interpolation" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.LinearInterpolationSmoothingModel>(&reader, options)
                    SmoothingModelContainer.LinearInterpolation v
                | "stupid_backoff" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.StupidBackoffSmoothingModel>(&reader, options)
                    SmoothingModelContainer.StupidBackoff v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for SmoothingModelContainer"))
            reader.Read() |> ignore // EndObject
            result

    type StringDistanceConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<StringDistance>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | StringDistance.Internal -> "internal"
                | StringDistance.DamerauLevenshtein -> "damerau_levenshtein"
                | StringDistance.Levenshtein -> "levenshtein"
                | StringDistance.JaroWinkler -> "jaro_winkler"
                | StringDistance.Ngram -> "ngram"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "internal" -> StringDistance.Internal
            | "damerau_levenshtein" -> StringDistance.DamerauLevenshtein
            | "levenshtein" -> StringDistance.Levenshtein
            | "jaro_winkler" -> StringDistance.JaroWinkler
            | "ngram" -> StringDistance.Ngram
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for StringDistance"))

    type SuggestSortConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SuggestSort>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SuggestSort.Score -> "score"
                | SuggestSort.Frequency -> "frequency"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "score" -> SuggestSort.Score
            | "frequency" -> SuggestSort.Frequency
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SuggestSort"))

    type TotalHitsRelationConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TotalHitsRelation>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TotalHitsRelation.Eq -> "eq"
                | TotalHitsRelation.Gte -> "gte"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "eq" -> TotalHitsRelation.Eq
            | "gte" -> TotalHitsRelation.Gte
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TotalHitsRelation"))

    type GridAggregationTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GridAggregationType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GridAggregationType.Geotile -> "geotile"
                | GridAggregationType.Geohex -> "geohex"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "geotile" -> GridAggregationType.Geotile
            | "geohex" -> GridAggregationType.Geohex
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GridAggregationType"))

    type GridTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GridType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GridType.Grid -> "grid"
                | GridType.Point -> "point"
                | GridType.Centroid -> "centroid"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "grid" -> GridType.Grid
            | "point" -> GridType.Point
            | "centroid" -> GridType.Centroid
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GridType"))

    type BytesConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Bytes>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Bytes.B -> "b"
                | Bytes.Kb -> "kb"
                | Bytes.Mb -> "mb"
                | Bytes.Gb -> "gb"
                | Bytes.Tb -> "tb"
                | Bytes.Pb -> "pb"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "b" -> Bytes.B
            | "kb" -> Bytes.Kb
            | "mb" -> Bytes.Mb
            | "gb" -> Bytes.Gb
            | "tb" -> Bytes.Tb
            | "pb" -> Bytes.Pb
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Bytes"))

    type ClusterInfoTargetConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ClusterInfoTarget>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ClusterInfoTarget.All -> "_all"
                | ClusterInfoTarget.Http -> "http"
                | ClusterInfoTarget.Ingest -> "ingest"
                | ClusterInfoTarget.ThreadPool -> "thread_pool"
                | ClusterInfoTarget.Script -> "script"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "_all" -> ClusterInfoTarget.All
            | "http" -> ClusterInfoTarget.Http
            | "ingest" -> ClusterInfoTarget.Ingest
            | "thread_pool" -> ClusterInfoTarget.ThreadPool
            | "script" -> ClusterInfoTarget.Script
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ClusterInfoTarget"))

    type ClusterSearchStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ClusterSearchStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ClusterSearchStatus.Running -> "running"
                | ClusterSearchStatus.Successful -> "successful"
                | ClusterSearchStatus.Partial -> "partial"
                | ClusterSearchStatus.Skipped -> "skipped"
                | ClusterSearchStatus.Failed -> "failed"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "running" -> ClusterSearchStatus.Running
            | "successful" -> ClusterSearchStatus.Successful
            | "partial" -> ClusterSearchStatus.Partial
            | "skipped" -> ClusterSearchStatus.Skipped
            | "failed" -> ClusterSearchStatus.Failed
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ClusterSearchStatus"))

    type CommonStatsFlagConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CommonStatsFlag>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CommonStatsFlag.All -> "_all"
                | CommonStatsFlag.Store -> "store"
                | CommonStatsFlag.Indexing -> "indexing"
                | CommonStatsFlag.Get -> "get"
                | CommonStatsFlag.Search -> "search"
                | CommonStatsFlag.Merge -> "merge"
                | CommonStatsFlag.Flush -> "flush"
                | CommonStatsFlag.Refresh -> "refresh"
                | CommonStatsFlag.QueryCache -> "query_cache"
                | CommonStatsFlag.Fielddata -> "fielddata"
                | CommonStatsFlag.Docs -> "docs"
                | CommonStatsFlag.Warmer -> "warmer"
                | CommonStatsFlag.Completion -> "completion"
                | CommonStatsFlag.Segments -> "segments"
                | CommonStatsFlag.Translog -> "translog"
                | CommonStatsFlag.RequestCache -> "request_cache"
                | CommonStatsFlag.Recovery -> "recovery"
                | CommonStatsFlag.Bulk -> "bulk"
                | CommonStatsFlag.ShardStats -> "shard_stats"
                | CommonStatsFlag.Mappings -> "mappings"
                | CommonStatsFlag.DenseVector -> "dense_vector"
                | CommonStatsFlag.SparseVector -> "sparse_vector"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "_all" -> CommonStatsFlag.All
            | "store" -> CommonStatsFlag.Store
            | "indexing" -> CommonStatsFlag.Indexing
            | "get" -> CommonStatsFlag.Get
            | "search" -> CommonStatsFlag.Search
            | "merge" -> CommonStatsFlag.Merge
            | "flush" -> CommonStatsFlag.Flush
            | "refresh" -> CommonStatsFlag.Refresh
            | "query_cache" -> CommonStatsFlag.QueryCache
            | "fielddata" -> CommonStatsFlag.Fielddata
            | "docs" -> CommonStatsFlag.Docs
            | "warmer" -> CommonStatsFlag.Warmer
            | "completion" -> CommonStatsFlag.Completion
            | "segments" -> CommonStatsFlag.Segments
            | "translog" -> CommonStatsFlag.Translog
            | "request_cache" -> CommonStatsFlag.RequestCache
            | "recovery" -> CommonStatsFlag.Recovery
            | "bulk" -> CommonStatsFlag.Bulk
            | "shard_stats" -> CommonStatsFlag.ShardStats
            | "mappings" -> CommonStatsFlag.Mappings
            | "dense_vector" -> CommonStatsFlag.DenseVector
            | "sparse_vector" -> CommonStatsFlag.SparseVector
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CommonStatsFlag"))

    type ConflictsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Conflicts>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Conflicts.Abort -> "abort"
                | Conflicts.Proceed -> "proceed"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "abort" -> Conflicts.Abort
            | "proceed" -> Conflicts.Proceed
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Conflicts"))

    type DFIIndependenceMeasureConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DFIIndependenceMeasure>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | DFIIndependenceMeasure.Standardized -> "standardized"
                | DFIIndependenceMeasure.Saturated -> "saturated"
                | DFIIndependenceMeasure.Chisquared -> "chisquared"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "standardized" -> DFIIndependenceMeasure.Standardized
            | "saturated" -> DFIIndependenceMeasure.Saturated
            | "chisquared" -> DFIIndependenceMeasure.Chisquared
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DFIIndependenceMeasure"))

    type DFRAfterEffectConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DFRAfterEffect>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | DFRAfterEffect.No -> "no"
                | DFRAfterEffect.B -> "b"
                | DFRAfterEffect.L -> "l"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "no" -> DFRAfterEffect.No
            | "b" -> DFRAfterEffect.B
            | "l" -> DFRAfterEffect.L
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DFRAfterEffect"))

    type DFRBasicModelConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DFRBasicModel>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | DFRBasicModel.Be -> "be"
                | DFRBasicModel.D -> "d"
                | DFRBasicModel.G -> "g"
                | DFRBasicModel.If -> "if"
                | DFRBasicModel.In -> "in"
                | DFRBasicModel.Ine -> "ine"
                | DFRBasicModel.P -> "p"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "be" -> DFRBasicModel.Be
            | "d" -> DFRBasicModel.D
            | "g" -> DFRBasicModel.G
            | "if" -> DFRBasicModel.If
            | "in" -> DFRBasicModel.In
            | "ine" -> DFRBasicModel.Ine
            | "p" -> DFRBasicModel.P
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DFRBasicModel"))

    type DistanceUnitConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DistanceUnit>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | DistanceUnit.In -> "in"
                | DistanceUnit.Ft -> "ft"
                | DistanceUnit.Yd -> "yd"
                | DistanceUnit.Mi -> "mi"
                | DistanceUnit.Nmi -> "nmi"
                | DistanceUnit.Km -> "km"
                | DistanceUnit.M -> "m"
                | DistanceUnit.Cm -> "cm"
                | DistanceUnit.Mm -> "mm"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "in" -> DistanceUnit.In
            | "ft" -> DistanceUnit.Ft
            | "yd" -> DistanceUnit.Yd
            | "mi" -> DistanceUnit.Mi
            | "nmi" -> DistanceUnit.Nmi
            | "km" -> DistanceUnit.Km
            | "m" -> DistanceUnit.M
            | "cm" -> DistanceUnit.Cm
            | "mm" -> DistanceUnit.Mm
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DistanceUnit"))

    type DiversifyRetrieverTypesConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DiversifyRetrieverTypes>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | DiversifyRetrieverTypes.Mmr -> "mmr"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "mmr" -> DiversifyRetrieverTypes.Mmr
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DiversifyRetrieverTypes"))

    type ExpandWildcardConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ExpandWildcard>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ExpandWildcard.All -> "all"
                | ExpandWildcard.Open -> "open"
                | ExpandWildcard.Closed -> "closed"
                | ExpandWildcard.Hidden -> "hidden"
                | ExpandWildcard.None -> "none"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "all" -> ExpandWildcard.All
            | "open" -> ExpandWildcard.Open
            | "closed" -> ExpandWildcard.Closed
            | "hidden" -> ExpandWildcard.Hidden
            | "none" -> ExpandWildcard.None
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ExpandWildcard"))

    type FieldSortNumericTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<FieldSortNumericType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | FieldSortNumericType.Long -> "long"
                | FieldSortNumericType.Double -> "double"
                | FieldSortNumericType.Date -> "date"
                | FieldSortNumericType.DateNanos -> "date_nanos"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "long" -> FieldSortNumericType.Long
            | "double" -> FieldSortNumericType.Double
            | "date" -> FieldSortNumericType.Date
            | "date_nanos" -> FieldSortNumericType.DateNanos
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FieldSortNumericType"))

    type GeoDistanceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GeoDistanceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GeoDistanceType.Arc -> "arc"
                | GeoDistanceType.Plane -> "plane"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "arc" -> GeoDistanceType.Arc
            | "plane" -> GeoDistanceType.Plane
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GeoDistanceType"))

    type GeoShapeRelationConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GeoShapeRelation>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GeoShapeRelation.Intersects -> "intersects"
                | GeoShapeRelation.Disjoint -> "disjoint"
                | GeoShapeRelation.Within -> "within"
                | GeoShapeRelation.Contains -> "contains"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "intersects" -> GeoShapeRelation.Intersects
            | "disjoint" -> GeoShapeRelation.Disjoint
            | "within" -> GeoShapeRelation.Within
            | "contains" -> GeoShapeRelation.Contains
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GeoShapeRelation"))

    type HealthStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<HealthStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | HealthStatus.Green -> "green"
                | HealthStatus.Yellow -> "yellow"
                | HealthStatus.Red -> "red"
                | HealthStatus.Unknown -> "unknown"
                | HealthStatus.Unavailable -> "unavailable"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "green" -> HealthStatus.Green
            | "yellow" -> HealthStatus.Yellow
            | "red" -> HealthStatus.Red
            | "unknown" -> HealthStatus.Unknown
            | "unavailable" -> HealthStatus.Unavailable
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for HealthStatus"))

    type IBDistributionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IBDistribution>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IBDistribution.Ll -> "ll"
                | IBDistribution.Spl -> "spl"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "ll" -> IBDistribution.Ll
            | "spl" -> IBDistribution.Spl
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IBDistribution"))

    type IBLambdaConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IBLambda>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IBLambda.Df -> "df"
                | IBLambda.Ttf -> "ttf"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "df" -> IBLambda.Df
            | "ttf" -> IBLambda.Ttf
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IBLambda"))

    type LevelConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Level>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Level.Cluster -> "cluster"
                | Level.Indices -> "indices"
                | Level.Shards -> "shards"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cluster" -> Level.Cluster
            | "indices" -> Level.Indices
            | "shards" -> Level.Shards
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Level"))

    type LifecycleOperationModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<LifecycleOperationMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | LifecycleOperationMode.RUNNING -> "RUNNING"
                | LifecycleOperationMode.STOPPING -> "STOPPING"
                | LifecycleOperationMode.STOPPED -> "STOPPED"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "RUNNING" -> LifecycleOperationMode.RUNNING
            | "STOPPING" -> LifecycleOperationMode.STOPPING
            | "STOPPED" -> LifecycleOperationMode.STOPPED
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for LifecycleOperationMode"))

    type NodeRoleConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<NodeRole>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | NodeRole.Master -> "master"
                | NodeRole.Data -> "data"
                | NodeRole.DataCold -> "data_cold"
                | NodeRole.DataContent -> "data_content"
                | NodeRole.DataFrozen -> "data_frozen"
                | NodeRole.DataHot -> "data_hot"
                | NodeRole.DataWarm -> "data_warm"
                | NodeRole.Client -> "client"
                | NodeRole.Ingest -> "ingest"
                | NodeRole.Ml -> "ml"
                | NodeRole.VotingOnly -> "voting_only"
                | NodeRole.Transform -> "transform"
                | NodeRole.RemoteClusterClient -> "remote_cluster_client"
                | NodeRole.CoordinatingOnly -> "coordinating_only"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "master" -> NodeRole.Master
            | "data" -> NodeRole.Data
            | "data_cold" -> NodeRole.DataCold
            | "data_content" -> NodeRole.DataContent
            | "data_frozen" -> NodeRole.DataFrozen
            | "data_hot" -> NodeRole.DataHot
            | "data_warm" -> NodeRole.DataWarm
            | "client" -> NodeRole.Client
            | "ingest" -> NodeRole.Ingest
            | "ml" -> NodeRole.Ml
            | "voting_only" -> NodeRole.VotingOnly
            | "transform" -> NodeRole.Transform
            | "remote_cluster_client" -> NodeRole.RemoteClusterClient
            | "coordinating_only" -> NodeRole.CoordinatingOnly
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for NodeRole"))

    type NodeStatsLevelConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<NodeStatsLevel>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | NodeStatsLevel.Node -> "node"
                | NodeStatsLevel.Indices -> "indices"
                | NodeStatsLevel.Shards -> "shards"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "node" -> NodeStatsLevel.Node
            | "indices" -> NodeStatsLevel.Indices
            | "shards" -> NodeStatsLevel.Shards
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for NodeStatsLevel"))

    type NormalizationConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Normalization>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Normalization.No -> "no"
                | Normalization.H1 -> "h1"
                | Normalization.H2 -> "h2"
                | Normalization.H3 -> "h3"
                | Normalization.Z -> "z"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "no" -> Normalization.No
            | "h1" -> Normalization.H1
            | "h2" -> Normalization.H2
            | "h3" -> Normalization.H3
            | "z" -> Normalization.Z
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Normalization"))

    type OpTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<OpType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | OpType.Index -> "index"
                | OpType.Create -> "create"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "index" -> OpType.Index
            | "create" -> OpType.Create
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for OpType"))

    type QueryVectorBuilderConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<QueryVectorBuilder>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | QueryVectorBuilder.TextEmbedding v ->
                writer.WritePropertyName("text_embedding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryVectorBuilder.Lookup v ->
                writer.WritePropertyName("lookup")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for QueryVectorBuilder"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for QueryVectorBuilder"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "text_embedding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TextEmbedding>(&reader, options)
                    QueryVectorBuilder.TextEmbedding v
                | "lookup" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.LookupQueryVectorBuilder>(&reader, options)
                    QueryVectorBuilder.Lookup v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for QueryVectorBuilder"))
            reader.Read() |> ignore // EndObject
            result

    type RankContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<RankContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | RankContainer.Rrf v ->
                writer.WritePropertyName("rrf")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for RankContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for RankContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "rrf" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RrfRank>(&reader, options)
                    RankContainer.Rrf v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for RankContainer"))
            reader.Read() |> ignore // EndObject
            result

    type RefreshConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Refresh>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Refresh.True -> "true"
                | Refresh.False -> "false"
                | Refresh.WaitFor -> "wait_for"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "true" -> Refresh.True
            | "false" -> Refresh.False
            | "wait_for" -> Refresh.WaitFor
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Refresh"))

    type ResultConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Result>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Result.Created -> "created"
                | Result.Updated -> "updated"
                | Result.Deleted -> "deleted"
                | Result.NotFound -> "not_found"
                | Result.Noop -> "noop"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "created" -> Result.Created
            | "updated" -> Result.Updated
            | "deleted" -> Result.Deleted
            | "not_found" -> Result.NotFound
            | "noop" -> Result.Noop
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Result"))

    type RetrieverContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<RetrieverContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | RetrieverContainer.Standard v ->
                writer.WritePropertyName("standard")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | RetrieverContainer.Knn v ->
                writer.WritePropertyName("knn")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | RetrieverContainer.Rrf v ->
                writer.WritePropertyName("rrf")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | RetrieverContainer.TextSimilarityReranker v ->
                writer.WritePropertyName("text_similarity_reranker")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | RetrieverContainer.Rule v ->
                writer.WritePropertyName("rule")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | RetrieverContainer.Rescorer v ->
                writer.WritePropertyName("rescorer")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | RetrieverContainer.Linear v ->
                writer.WritePropertyName("linear")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | RetrieverContainer.Pinned v ->
                writer.WritePropertyName("pinned")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | RetrieverContainer.Diversify v ->
                writer.WritePropertyName("diversify")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for RetrieverContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for RetrieverContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "standard" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.StandardRetriever>(&reader, options)
                    RetrieverContainer.Standard v
                | "knn" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.KnnRetriever>(&reader, options)
                    RetrieverContainer.Knn v
                | "rrf" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RRFRetriever>(&reader, options)
                    RetrieverContainer.Rrf v
                | "text_similarity_reranker" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TextSimilarityReranker>(&reader, options)
                    RetrieverContainer.TextSimilarityReranker v
                | "rule" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RuleRetriever>(&reader, options)
                    RetrieverContainer.Rule v
                | "rescorer" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RescorerRetriever>(&reader, options)
                    RetrieverContainer.Rescorer v
                | "linear" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.LinearRetriever>(&reader, options)
                    RetrieverContainer.Linear v
                | "pinned" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.PinnedRetriever>(&reader, options)
                    RetrieverContainer.Pinned v
                | "diversify" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DiversifyRetriever>(&reader, options)
                    RetrieverContainer.Diversify v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for RetrieverContainer"))
            reader.Read() |> ignore // EndObject
            result

    type ScoreNormalizerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ScoreNormalizer>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ScoreNormalizer.None -> "none"
                | ScoreNormalizer.Minmax -> "minmax"
                | ScoreNormalizer.L2Norm -> "l2_norm"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "none" -> ScoreNormalizer.None
            | "minmax" -> ScoreNormalizer.Minmax
            | "l2_norm" -> ScoreNormalizer.L2Norm
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ScoreNormalizer"))

    type ScriptLanguageConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ScriptLanguage>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ScriptLanguage.Painless -> "painless"
                | ScriptLanguage.Expression -> "expression"
                | ScriptLanguage.Mustache -> "mustache"
                | ScriptLanguage.Java -> "java"
                | ScriptLanguage.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "painless" -> ScriptLanguage.Painless
            | "expression" -> ScriptLanguage.Expression
            | "mustache" -> ScriptLanguage.Mustache
            | "java" -> ScriptLanguage.Java
            | other -> ScriptLanguage.Custom other

    type ScriptSortTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ScriptSortType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ScriptSortType.String -> "string"
                | ScriptSortType.Number -> "number"
                | ScriptSortType.Version -> "version"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "string" -> ScriptSortType.String
            | "number" -> ScriptSortType.Number
            | "version" -> ScriptSortType.Version
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ScriptSortType"))

    type SearchTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SearchType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SearchType.QueryThenFetch -> "query_then_fetch"
                | SearchType.DfsQueryThenFetch -> "dfs_query_then_fetch"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "query_then_fetch" -> SearchType.QueryThenFetch
            | "dfs_query_then_fetch" -> SearchType.DfsQueryThenFetch
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SearchType"))

    type SlicesCalculationConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SlicesCalculation>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SlicesCalculation.Auto -> "auto"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "auto" -> SlicesCalculation.Auto
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SlicesCalculation"))

    type SortModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SortMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SortMode.Min -> "min"
                | SortMode.Max -> "max"
                | SortMode.Sum -> "sum"
                | SortMode.Avg -> "avg"
                | SortMode.Median -> "median"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "min" -> SortMode.Min
            | "max" -> SortMode.Max
            | "sum" -> SortMode.Sum
            | "avg" -> SortMode.Avg
            | "median" -> SortMode.Median
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SortMode"))

    type SortOptionsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SortOptions>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | SortOptions.Score v ->
                writer.WritePropertyName("_score")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SortOptions.Doc v ->
                writer.WritePropertyName("_doc")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SortOptions.GeoDistance v ->
                writer.WritePropertyName("_geo_distance")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SortOptions.Script v ->
                writer.WritePropertyName("_script")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for SortOptions"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for SortOptions"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "_score" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ScoreSort>(&reader, options)
                    SortOptions.Score v
                | "_doc" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ScoreSort>(&reader, options)
                    SortOptions.Doc v
                | "_geo_distance" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoDistanceSort>(&reader, options)
                    SortOptions.GeoDistance v
                | "_script" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ScriptSort>(&reader, options)
                    SortOptions.Script v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for SortOptions"))
            reader.Read() |> ignore // EndObject
            result

    type SortOrderConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SortOrder>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SortOrder.Asc -> "asc"
                | SortOrder.Desc -> "desc"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "asc" -> SortOrder.Asc
            | "desc" -> SortOrder.Desc
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SortOrder"))

    type SuggestModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SuggestMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SuggestMode.Missing -> "missing"
                | SuggestMode.Popular -> "popular"
                | SuggestMode.Always -> "always"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "missing" -> SuggestMode.Missing
            | "popular" -> SuggestMode.Popular
            | "always" -> SuggestMode.Always
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SuggestMode"))

    type ThreadTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ThreadType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ThreadType.Cpu -> "cpu"
                | ThreadType.Wait -> "wait"
                | ThreadType.Block -> "block"
                | ThreadType.Gpu -> "gpu"
                | ThreadType.Mem -> "mem"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cpu" -> ThreadType.Cpu
            | "wait" -> ThreadType.Wait
            | "block" -> ThreadType.Block
            | "gpu" -> ThreadType.Gpu
            | "mem" -> ThreadType.Mem
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ThreadType"))

    type TimeUnitConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TimeUnit>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TimeUnit.Nanos -> "nanos"
                | TimeUnit.Micros -> "micros"
                | TimeUnit.Ms -> "ms"
                | TimeUnit.S -> "s"
                | TimeUnit.M -> "m"
                | TimeUnit.H -> "h"
                | TimeUnit.D -> "d"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "nanos" -> TimeUnit.Nanos
            | "micros" -> TimeUnit.Micros
            | "ms" -> TimeUnit.Ms
            | "s" -> TimeUnit.S
            | "m" -> TimeUnit.M
            | "h" -> TimeUnit.H
            | "d" -> TimeUnit.D
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TimeUnit"))

    type TransformContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TransformContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | TransformContainer.Chain v ->
                writer.WritePropertyName("chain")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TransformContainer.Script v ->
                writer.WritePropertyName("script")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TransformContainer.Search v ->
                writer.WritePropertyName("search")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for TransformContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for TransformContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "chain" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TransformContainer list>(&reader, options)
                    TransformContainer.Chain v
                | "script" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ScriptTransform>(&reader, options)
                    TransformContainer.Script v
                | "search" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SearchTransform>(&reader, options)
                    TransformContainer.Search v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for TransformContainer"))
            reader.Read() |> ignore // EndObject
            result

    type VersionTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<VersionType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | VersionType.Internal -> "internal"
                | VersionType.External -> "external"
                | VersionType.ExternalGte -> "external_gte"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "internal" -> VersionType.Internal
            | "external" -> VersionType.External
            | "external_gte" -> VersionType.ExternalGte
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for VersionType"))

    type WaitForActiveShardOptionsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WaitForActiveShardOptions>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WaitForActiveShardOptions.All -> "all"
                | WaitForActiveShardOptions.IndexSetting -> "index-setting"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "all" -> WaitForActiveShardOptions.All
            | "index-setting" -> WaitForActiveShardOptions.IndexSetting
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for WaitForActiveShardOptions"))

    type WaitForEventsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WaitForEvents>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WaitForEvents.Immediate -> "immediate"
                | WaitForEvents.Urgent -> "urgent"
                | WaitForEvents.High -> "high"
                | WaitForEvents.Normal -> "normal"
                | WaitForEvents.Low -> "low"
                | WaitForEvents.Languid -> "languid"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "immediate" -> WaitForEvents.Immediate
            | "urgent" -> WaitForEvents.Urgent
            | "high" -> WaitForEvents.High
            | "normal" -> WaitForEvents.Normal
            | "low" -> WaitForEvents.Low
            | "languid" -> WaitForEvents.Languid
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for WaitForEvents"))

    type AggregationContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<AggregationContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | AggregationContainer.AdjacencyMatrix v ->
                writer.WritePropertyName("adjacency_matrix")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.AutoDateHistogram v ->
                writer.WritePropertyName("auto_date_histogram")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Avg v ->
                writer.WritePropertyName("avg")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.AvgBucket v ->
                writer.WritePropertyName("avg_bucket")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Boxplot v ->
                writer.WritePropertyName("boxplot")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.BucketScript v ->
                writer.WritePropertyName("bucket_script")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.BucketSelector v ->
                writer.WritePropertyName("bucket_selector")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.BucketSort v ->
                writer.WritePropertyName("bucket_sort")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.BucketCountKsTest v ->
                writer.WritePropertyName("bucket_count_ks_test")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.BucketCorrelation v ->
                writer.WritePropertyName("bucket_correlation")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Cardinality v ->
                writer.WritePropertyName("cardinality")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.CartesianBounds v ->
                writer.WritePropertyName("cartesian_bounds")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.CartesianCentroid v ->
                writer.WritePropertyName("cartesian_centroid")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.CategorizeText v ->
                writer.WritePropertyName("categorize_text")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.ChangePoint v ->
                writer.WritePropertyName("change_point")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Children v ->
                writer.WritePropertyName("children")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Composite v ->
                writer.WritePropertyName("composite")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.CumulativeCardinality v ->
                writer.WritePropertyName("cumulative_cardinality")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.CumulativeSum v ->
                writer.WritePropertyName("cumulative_sum")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.DateHistogram v ->
                writer.WritePropertyName("date_histogram")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.DateRange v ->
                writer.WritePropertyName("date_range")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Derivative v ->
                writer.WritePropertyName("derivative")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.DiversifiedSampler v ->
                writer.WritePropertyName("diversified_sampler")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.ExtendedStats v ->
                writer.WritePropertyName("extended_stats")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.ExtendedStatsBucket v ->
                writer.WritePropertyName("extended_stats_bucket")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.FrequentItemSets v ->
                writer.WritePropertyName("frequent_item_sets")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Filter v ->
                writer.WritePropertyName("filter")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Filters v ->
                writer.WritePropertyName("filters")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.GeoBounds v ->
                writer.WritePropertyName("geo_bounds")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.GeoCentroid v ->
                writer.WritePropertyName("geo_centroid")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.GeoDistance v ->
                writer.WritePropertyName("geo_distance")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.GeohashGrid v ->
                writer.WritePropertyName("geohash_grid")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.GeoLine v ->
                writer.WritePropertyName("geo_line")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.GeotileGrid v ->
                writer.WritePropertyName("geotile_grid")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.GeohexGrid v ->
                writer.WritePropertyName("geohex_grid")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Global v ->
                writer.WritePropertyName("global")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Histogram v ->
                writer.WritePropertyName("histogram")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.IpRange v ->
                writer.WritePropertyName("ip_range")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.IpPrefix v ->
                writer.WritePropertyName("ip_prefix")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Inference v ->
                writer.WritePropertyName("inference")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Line v ->
                writer.WritePropertyName("line")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.MatrixStats v ->
                writer.WritePropertyName("matrix_stats")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Max v ->
                writer.WritePropertyName("max")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.MaxBucket v ->
                writer.WritePropertyName("max_bucket")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.MedianAbsoluteDeviation v ->
                writer.WritePropertyName("median_absolute_deviation")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Min v ->
                writer.WritePropertyName("min")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.MinBucket v ->
                writer.WritePropertyName("min_bucket")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Missing v ->
                writer.WritePropertyName("missing")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.MovingAvg v ->
                writer.WritePropertyName("moving_avg")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.MovingPercentiles v ->
                writer.WritePropertyName("moving_percentiles")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.MovingFn v ->
                writer.WritePropertyName("moving_fn")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.MultiTerms v ->
                writer.WritePropertyName("multi_terms")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Nested v ->
                writer.WritePropertyName("nested")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Normalize v ->
                writer.WritePropertyName("normalize")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Parent v ->
                writer.WritePropertyName("parent")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.PercentileRanks v ->
                writer.WritePropertyName("percentile_ranks")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Percentiles v ->
                writer.WritePropertyName("percentiles")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.PercentilesBucket v ->
                writer.WritePropertyName("percentiles_bucket")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Range v ->
                writer.WritePropertyName("range")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.RareTerms v ->
                writer.WritePropertyName("rare_terms")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Rate v ->
                writer.WritePropertyName("rate")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.ReverseNested v ->
                writer.WritePropertyName("reverse_nested")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.RandomSampler v ->
                writer.WritePropertyName("random_sampler")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Sampler v ->
                writer.WritePropertyName("sampler")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.ScriptedMetric v ->
                writer.WritePropertyName("scripted_metric")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.SerialDiff v ->
                writer.WritePropertyName("serial_diff")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.SignificantTerms v ->
                writer.WritePropertyName("significant_terms")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.SignificantText v ->
                writer.WritePropertyName("significant_text")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Stats v ->
                writer.WritePropertyName("stats")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.StatsBucket v ->
                writer.WritePropertyName("stats_bucket")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.StringStats v ->
                writer.WritePropertyName("string_stats")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Sum v ->
                writer.WritePropertyName("sum")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.SumBucket v ->
                writer.WritePropertyName("sum_bucket")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Terms v ->
                writer.WritePropertyName("terms")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.TimeSeries v ->
                writer.WritePropertyName("time_series")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.TopHits v ->
                writer.WritePropertyName("top_hits")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.TTest v ->
                writer.WritePropertyName("t_test")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.TopMetrics v ->
                writer.WritePropertyName("top_metrics")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.ValueCount v ->
                writer.WritePropertyName("value_count")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.WeightedAvg v ->
                writer.WritePropertyName("weighted_avg")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.VariableWidthHistogram v ->
                writer.WritePropertyName("variable_width_histogram")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | AggregationContainer.Unknown (name, el) ->
                writer.WritePropertyName(name)
                el.WriteTo(writer)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for AggregationContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for AggregationContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "adjacency_matrix" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.AdjacencyMatrixAggregation>(&reader, options)
                    AggregationContainer.AdjacencyMatrix v
                | "auto_date_histogram" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.AutoDateHistogramAggregation>(&reader, options)
                    AggregationContainer.AutoDateHistogram v
                | "avg" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.AverageAggregation>(&reader, options)
                    AggregationContainer.Avg v
                | "avg_bucket" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.AverageBucketAggregation>(&reader, options)
                    AggregationContainer.AvgBucket v
                | "boxplot" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.BoxplotAggregation>(&reader, options)
                    AggregationContainer.Boxplot v
                | "bucket_script" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.BucketScriptAggregation>(&reader, options)
                    AggregationContainer.BucketScript v
                | "bucket_selector" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.BucketSelectorAggregation>(&reader, options)
                    AggregationContainer.BucketSelector v
                | "bucket_sort" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.BucketSortAggregation>(&reader, options)
                    AggregationContainer.BucketSort v
                | "bucket_count_ks_test" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.BucketKsAggregation>(&reader, options)
                    AggregationContainer.BucketCountKsTest v
                | "bucket_correlation" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.BucketCorrelationAggregation>(&reader, options)
                    AggregationContainer.BucketCorrelation v
                | "cardinality" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.CardinalityAggregation>(&reader, options)
                    AggregationContainer.Cardinality v
                | "cartesian_bounds" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.CartesianBoundsAggregation>(&reader, options)
                    AggregationContainer.CartesianBounds v
                | "cartesian_centroid" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.CartesianCentroidAggregation>(&reader, options)
                    AggregationContainer.CartesianCentroid v
                | "categorize_text" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.CategorizeTextAggregation>(&reader, options)
                    AggregationContainer.CategorizeText v
                | "change_point" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ChangePointAggregation>(&reader, options)
                    AggregationContainer.ChangePoint v
                | "children" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ChildrenAggregation>(&reader, options)
                    AggregationContainer.Children v
                | "composite" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.CompositeAggregation>(&reader, options)
                    AggregationContainer.Composite v
                | "cumulative_cardinality" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.CumulativeCardinalityAggregation>(&reader, options)
                    AggregationContainer.CumulativeCardinality v
                | "cumulative_sum" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.CumulativeSumAggregation>(&reader, options)
                    AggregationContainer.CumulativeSum v
                | "date_histogram" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DateHistogramAggregation>(&reader, options)
                    AggregationContainer.DateHistogram v
                | "date_range" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DateRangeAggregation>(&reader, options)
                    AggregationContainer.DateRange v
                | "derivative" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DerivativeAggregation>(&reader, options)
                    AggregationContainer.Derivative v
                | "diversified_sampler" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DiversifiedSamplerAggregation>(&reader, options)
                    AggregationContainer.DiversifiedSampler v
                | "extended_stats" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ExtendedStatsAggregation>(&reader, options)
                    AggregationContainer.ExtendedStats v
                | "extended_stats_bucket" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ExtendedStatsBucketAggregation>(&reader, options)
                    AggregationContainer.ExtendedStatsBucket v
                | "frequent_item_sets" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.FrequentItemSetsAggregation>(&reader, options)
                    AggregationContainer.FrequentItemSets v
                | "filter" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.QueryContainer>(&reader, options)
                    AggregationContainer.Filter v
                | "filters" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.FiltersAggregation>(&reader, options)
                    AggregationContainer.Filters v
                | "geo_bounds" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoBoundsAggregation>(&reader, options)
                    AggregationContainer.GeoBounds v
                | "geo_centroid" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoCentroidAggregation>(&reader, options)
                    AggregationContainer.GeoCentroid v
                | "geo_distance" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoDistanceAggregation>(&reader, options)
                    AggregationContainer.GeoDistance v
                | "geohash_grid" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoHashGridAggregation>(&reader, options)
                    AggregationContainer.GeohashGrid v
                | "geo_line" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoLineAggregation>(&reader, options)
                    AggregationContainer.GeoLine v
                | "geotile_grid" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoTileGridAggregation>(&reader, options)
                    AggregationContainer.GeotileGrid v
                | "geohex_grid" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeohexGridAggregation>(&reader, options)
                    AggregationContainer.GeohexGrid v
                | "global" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GlobalAggregation>(&reader, options)
                    AggregationContainer.Global v
                | "histogram" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.HistogramAggregation>(&reader, options)
                    AggregationContainer.Histogram v
                | "ip_range" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IpRangeAggregation>(&reader, options)
                    AggregationContainer.IpRange v
                | "ip_prefix" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IpPrefixAggregation>(&reader, options)
                    AggregationContainer.IpPrefix v
                | "inference" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.InferenceAggregation>(&reader, options)
                    AggregationContainer.Inference v
                | "line" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoLineAggregation>(&reader, options)
                    AggregationContainer.Line v
                | "matrix_stats" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MatrixStatsAggregation>(&reader, options)
                    AggregationContainer.MatrixStats v
                | "max" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MaxAggregation>(&reader, options)
                    AggregationContainer.Max v
                | "max_bucket" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MaxBucketAggregation>(&reader, options)
                    AggregationContainer.MaxBucket v
                | "median_absolute_deviation" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MedianAbsoluteDeviationAggregation>(&reader, options)
                    AggregationContainer.MedianAbsoluteDeviation v
                | "min" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MinAggregation>(&reader, options)
                    AggregationContainer.Min v
                | "min_bucket" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MinBucketAggregation>(&reader, options)
                    AggregationContainer.MinBucket v
                | "missing" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MissingAggregation>(&reader, options)
                    AggregationContainer.Missing v
                | "moving_avg" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MovingAverageAggregation>(&reader, options)
                    AggregationContainer.MovingAvg v
                | "moving_percentiles" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MovingPercentilesAggregation>(&reader, options)
                    AggregationContainer.MovingPercentiles v
                | "moving_fn" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MovingFunctionAggregation>(&reader, options)
                    AggregationContainer.MovingFn v
                | "multi_terms" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MultiTermsAggregation>(&reader, options)
                    AggregationContainer.MultiTerms v
                | "nested" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.NestedAggregation>(&reader, options)
                    AggregationContainer.Nested v
                | "normalize" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.NormalizeAggregation>(&reader, options)
                    AggregationContainer.Normalize v
                | "parent" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ParentAggregation>(&reader, options)
                    AggregationContainer.Parent v
                | "percentile_ranks" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.PercentileRanksAggregation>(&reader, options)
                    AggregationContainer.PercentileRanks v
                | "percentiles" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.PercentilesAggregation>(&reader, options)
                    AggregationContainer.Percentiles v
                | "percentiles_bucket" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.PercentilesBucketAggregation>(&reader, options)
                    AggregationContainer.PercentilesBucket v
                | "range" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RangeAggregation>(&reader, options)
                    AggregationContainer.Range v
                | "rare_terms" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RareTermsAggregation>(&reader, options)
                    AggregationContainer.RareTerms v
                | "rate" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RateAggregation>(&reader, options)
                    AggregationContainer.Rate v
                | "reverse_nested" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ReverseNestedAggregation>(&reader, options)
                    AggregationContainer.ReverseNested v
                | "random_sampler" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RandomSamplerAggregation>(&reader, options)
                    AggregationContainer.RandomSampler v
                | "sampler" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SamplerAggregation>(&reader, options)
                    AggregationContainer.Sampler v
                | "scripted_metric" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ScriptedMetricAggregation>(&reader, options)
                    AggregationContainer.ScriptedMetric v
                | "serial_diff" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SerialDifferencingAggregation>(&reader, options)
                    AggregationContainer.SerialDiff v
                | "significant_terms" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SignificantTermsAggregation>(&reader, options)
                    AggregationContainer.SignificantTerms v
                | "significant_text" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SignificantTextAggregation>(&reader, options)
                    AggregationContainer.SignificantText v
                | "stats" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.StatsAggregation>(&reader, options)
                    AggregationContainer.Stats v
                | "stats_bucket" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.StatsBucketAggregation>(&reader, options)
                    AggregationContainer.StatsBucket v
                | "string_stats" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.StringStatsAggregation>(&reader, options)
                    AggregationContainer.StringStats v
                | "sum" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SumAggregation>(&reader, options)
                    AggregationContainer.Sum v
                | "sum_bucket" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SumBucketAggregation>(&reader, options)
                    AggregationContainer.SumBucket v
                | "terms" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TermsAggregation>(&reader, options)
                    AggregationContainer.Terms v
                | "time_series" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TimeSeriesAggregation>(&reader, options)
                    AggregationContainer.TimeSeries v
                | "top_hits" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TopHitsAggregation>(&reader, options)
                    AggregationContainer.TopHits v
                | "t_test" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TTestAggregation>(&reader, options)
                    AggregationContainer.TTest v
                | "top_metrics" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TopMetricsAggregation>(&reader, options)
                    AggregationContainer.TopMetrics v
                | "value_count" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ValueCountAggregation>(&reader, options)
                    AggregationContainer.ValueCount v
                | "weighted_avg" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.WeightedAverageAggregation>(&reader, options)
                    AggregationContainer.WeightedAvg v
                | "variable_width_histogram" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.VariableWidthHistogramAggregation>(&reader, options)
                    AggregationContainer.VariableWidthHistogram v
                | other ->
                    let el = System.Text.Json.JsonElement.ParseValue(&reader)
                    AggregationContainer.Unknown (other, el)
            reader.Read() |> ignore // EndObject
            result

    type CalendarIntervalConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CalendarInterval>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CalendarInterval.Second -> "second"
                | CalendarInterval.Minute -> "minute"
                | CalendarInterval.Hour -> "hour"
                | CalendarInterval.Day -> "day"
                | CalendarInterval.Week -> "week"
                | CalendarInterval.Month -> "month"
                | CalendarInterval.Quarter -> "quarter"
                | CalendarInterval.Year -> "year"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "second" -> CalendarInterval.Second
            | "minute" -> CalendarInterval.Minute
            | "hour" -> CalendarInterval.Hour
            | "day" -> CalendarInterval.Day
            | "week" -> CalendarInterval.Week
            | "month" -> CalendarInterval.Month
            | "quarter" -> CalendarInterval.Quarter
            | "year" -> CalendarInterval.Year
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CalendarInterval"))

    type CardinalityExecutionModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CardinalityExecutionMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CardinalityExecutionMode.GlobalOrdinals -> "global_ordinals"
                | CardinalityExecutionMode.SegmentOrdinals -> "segment_ordinals"
                | CardinalityExecutionMode.Direct -> "direct"
                | CardinalityExecutionMode.SaveMemoryHeuristic -> "save_memory_heuristic"
                | CardinalityExecutionMode.SaveTimeHeuristic -> "save_time_heuristic"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "global_ordinals" -> CardinalityExecutionMode.GlobalOrdinals
            | "segment_ordinals" -> CardinalityExecutionMode.SegmentOrdinals
            | "direct" -> CardinalityExecutionMode.Direct
            | "save_memory_heuristic" -> CardinalityExecutionMode.SaveMemoryHeuristic
            | "save_time_heuristic" -> CardinalityExecutionMode.SaveTimeHeuristic
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CardinalityExecutionMode"))

    type ChangeTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ChangeType>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | ChangeType.Dip v ->
                writer.WritePropertyName("dip")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ChangeType.DistributionChange v ->
                writer.WritePropertyName("distribution_change")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ChangeType.Indeterminable v ->
                writer.WritePropertyName("indeterminable")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ChangeType.NonStationary v ->
                writer.WritePropertyName("non_stationary")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ChangeType.Spike v ->
                writer.WritePropertyName("spike")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ChangeType.Stationary v ->
                writer.WritePropertyName("stationary")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ChangeType.StepChange v ->
                writer.WritePropertyName("step_change")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ChangeType.TrendChange v ->
                writer.WritePropertyName("trend_change")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for ChangeType"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for ChangeType"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "dip" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.Dip>(&reader, options)
                    ChangeType.Dip v
                | "distribution_change" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DistributionChange>(&reader, options)
                    ChangeType.DistributionChange v
                | "indeterminable" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.Indeterminable>(&reader, options)
                    ChangeType.Indeterminable v
                | "non_stationary" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.NonStationary>(&reader, options)
                    ChangeType.NonStationary v
                | "spike" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.Spike>(&reader, options)
                    ChangeType.Spike v
                | "stationary" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.Stationary>(&reader, options)
                    ChangeType.Stationary v
                | "step_change" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.StepChange>(&reader, options)
                    ChangeType.StepChange v
                | "trend_change" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TrendChange>(&reader, options)
                    ChangeType.TrendChange v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for ChangeType"))
            reader.Read() |> ignore // EndObject
            result

    type CompositeAggregationSourceConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CompositeAggregationSource>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | CompositeAggregationSource.Terms v ->
                writer.WritePropertyName("terms")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | CompositeAggregationSource.Histogram v ->
                writer.WritePropertyName("histogram")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | CompositeAggregationSource.DateHistogram v ->
                writer.WritePropertyName("date_histogram")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | CompositeAggregationSource.GeotileGrid v ->
                writer.WritePropertyName("geotile_grid")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for CompositeAggregationSource"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for CompositeAggregationSource"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "terms" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.CompositeTermsAggregation>(&reader, options)
                    CompositeAggregationSource.Terms v
                | "histogram" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.CompositeHistogramAggregation>(&reader, options)
                    CompositeAggregationSource.Histogram v
                | "date_histogram" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.CompositeDateHistogramAggregation>(&reader, options)
                    CompositeAggregationSource.DateHistogram v
                | "geotile_grid" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.CompositeGeoTileGridAggregation>(&reader, options)
                    CompositeAggregationSource.GeotileGrid v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for CompositeAggregationSource"))
            reader.Read() |> ignore // EndObject
            result

    type GapPolicyConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GapPolicy>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GapPolicy.Skip -> "skip"
                | GapPolicy.InsertZeros -> "insert_zeros"
                | GapPolicy.KeepValues -> "keep_values"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "skip" -> GapPolicy.Skip
            | "insert_zeros" -> GapPolicy.InsertZeros
            | "keep_values" -> GapPolicy.KeepValues
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GapPolicy"))

    type HoltWintersTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<HoltWintersType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | HoltWintersType.Add -> "add"
                | HoltWintersType.Mult -> "mult"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "add" -> HoltWintersType.Add
            | "mult" -> HoltWintersType.Mult
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for HoltWintersType"))

    type InferenceConfigContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceConfigContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | InferenceConfigContainer.Regression v ->
                writer.WritePropertyName("regression")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceConfigContainer.Classification v ->
                writer.WritePropertyName("classification")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for InferenceConfigContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for InferenceConfigContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "regression" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RegressionInferenceOptions>(&reader, options)
                    InferenceConfigContainer.Regression v
                | "classification" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ClassificationInferenceOptions>(&reader, options)
                    InferenceConfigContainer.Classification v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for InferenceConfigContainer"))
            reader.Read() |> ignore // EndObject
            result

    type MinimumIntervalConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MinimumInterval>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MinimumInterval.Second -> "second"
                | MinimumInterval.Minute -> "minute"
                | MinimumInterval.Hour -> "hour"
                | MinimumInterval.Day -> "day"
                | MinimumInterval.Month -> "month"
                | MinimumInterval.Year -> "year"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "second" -> MinimumInterval.Second
            | "minute" -> MinimumInterval.Minute
            | "hour" -> MinimumInterval.Hour
            | "day" -> MinimumInterval.Day
            | "month" -> MinimumInterval.Month
            | "year" -> MinimumInterval.Year
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for MinimumInterval"))

    type MissingOrderConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MissingOrder>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MissingOrder.First -> "first"
                | MissingOrder.Last -> "last"
                | MissingOrder.Default -> "default"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "first" -> MissingOrder.First
            | "last" -> MissingOrder.Last
            | "default" -> MissingOrder.Default
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for MissingOrder"))

    type MovingAverageAggregationConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MovingAverageAggregation>()

        override _.Write(writer, value, options) =
            match value with
            | MovingAverageAggregation.LinearMovingAverageAggregation v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MovingAverageAggregation.SimpleMovingAverageAggregation v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MovingAverageAggregation.EwmaMovingAverageAggregation v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MovingAverageAggregation.HoltMovingAverageAggregation v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MovingAverageAggregation.HoltWintersMovingAverageAggregation v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(&reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("model") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "linearmovingaverageaggregation" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.LinearMovingAverageAggregation>(doc.RootElement.GetRawText(), options)
                MovingAverageAggregation.LinearMovingAverageAggregation v
            | "simplemovingaverageaggregation" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SimpleMovingAverageAggregation>(doc.RootElement.GetRawText(), options)
                MovingAverageAggregation.SimpleMovingAverageAggregation v
            | "ewmamovingaverageaggregation" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.EwmaMovingAverageAggregation>(doc.RootElement.GetRawText(), options)
                MovingAverageAggregation.EwmaMovingAverageAggregation v
            | "holtmovingaverageaggregation" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.HoltMovingAverageAggregation>(doc.RootElement.GetRawText(), options)
                MovingAverageAggregation.HoltMovingAverageAggregation v
            | "holtwintersmovingaverageaggregation" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.HoltWintersMovingAverageAggregation>(doc.RootElement.GetRawText(), options)
                MovingAverageAggregation.HoltWintersMovingAverageAggregation v
            | other -> raise (System.Text.Json.JsonException($"Unknown tag value '{other}' for MovingAverageAggregation"))

    type MultiTermLookupConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MultiTermLookup>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | MultiTermLookup.Field v ->
                writer.WritePropertyName("field")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MultiTermLookup.Script v ->
                writer.WritePropertyName("script")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for MultiTermLookup"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for MultiTermLookup"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "field" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.Field>(&reader, options)
                    MultiTermLookup.Field v
                | "script" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.Script>(&reader, options)
                    MultiTermLookup.Script v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for MultiTermLookup"))
            reader.Read() |> ignore // EndObject
            result

    type NormalizeMethodConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<NormalizeMethod>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | NormalizeMethod.Rescale01 -> "rescale_0_1"
                | NormalizeMethod.Rescale0100 -> "rescale_0_100"
                | NormalizeMethod.PercentOfSum -> "percent_of_sum"
                | NormalizeMethod.Mean -> "mean"
                | NormalizeMethod.ZScore -> "z-score"
                | NormalizeMethod.Softmax -> "softmax"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "rescale_0_1" -> NormalizeMethod.Rescale01
            | "rescale_0_100" -> NormalizeMethod.Rescale0100
            | "percent_of_sum" -> NormalizeMethod.PercentOfSum
            | "mean" -> NormalizeMethod.Mean
            | "z-score" -> NormalizeMethod.ZScore
            | "softmax" -> NormalizeMethod.Softmax
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for NormalizeMethod"))

    type RateModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<RateMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | RateMode.Sum -> "sum"
                | RateMode.ValueCount -> "value_count"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "sum" -> RateMode.Sum
            | "value_count" -> RateMode.ValueCount
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for RateMode"))

    type SamplerAggregationExecutionHintConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SamplerAggregationExecutionHint>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SamplerAggregationExecutionHint.Map -> "map"
                | SamplerAggregationExecutionHint.GlobalOrdinals -> "global_ordinals"
                | SamplerAggregationExecutionHint.BytesHash -> "bytes_hash"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "map" -> SamplerAggregationExecutionHint.Map
            | "global_ordinals" -> SamplerAggregationExecutionHint.GlobalOrdinals
            | "bytes_hash" -> SamplerAggregationExecutionHint.BytesHash
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SamplerAggregationExecutionHint"))

    type TDigestExecutionHintConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TDigestExecutionHint>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TDigestExecutionHint.Default -> "default"
                | TDigestExecutionHint.HighAccuracy -> "high_accuracy"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "default" -> TDigestExecutionHint.Default
            | "high_accuracy" -> TDigestExecutionHint.HighAccuracy
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TDigestExecutionHint"))

    type TTestTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TTestType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TTestType.Paired -> "paired"
                | TTestType.Homoscedastic -> "homoscedastic"
                | TTestType.Heteroscedastic -> "heteroscedastic"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "paired" -> TTestType.Paired
            | "homoscedastic" -> TTestType.Homoscedastic
            | "heteroscedastic" -> TTestType.Heteroscedastic
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TTestType"))

    type TermsAggregationCollectModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TermsAggregationCollectMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TermsAggregationCollectMode.DepthFirst -> "depth_first"
                | TermsAggregationCollectMode.BreadthFirst -> "breadth_first"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "depth_first" -> TermsAggregationCollectMode.DepthFirst
            | "breadth_first" -> TermsAggregationCollectMode.BreadthFirst
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TermsAggregationCollectMode"))

    type TermsAggregationExecutionHintConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TermsAggregationExecutionHint>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TermsAggregationExecutionHint.Map -> "map"
                | TermsAggregationExecutionHint.GlobalOrdinals -> "global_ordinals"
                | TermsAggregationExecutionHint.GlobalOrdinalsHash -> "global_ordinals_hash"
                | TermsAggregationExecutionHint.GlobalOrdinalsLowCardinality -> "global_ordinals_low_cardinality"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "map" -> TermsAggregationExecutionHint.Map
            | "global_ordinals" -> TermsAggregationExecutionHint.GlobalOrdinals
            | "global_ordinals_hash" -> TermsAggregationExecutionHint.GlobalOrdinalsHash
            | "global_ordinals_low_cardinality" -> TermsAggregationExecutionHint.GlobalOrdinalsLowCardinality
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TermsAggregationExecutionHint"))

    type ValueTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ValueType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ValueType.String -> "string"
                | ValueType.Long -> "long"
                | ValueType.Double -> "double"
                | ValueType.Number -> "number"
                | ValueType.Date -> "date"
                | ValueType.DateNanos -> "date_nanos"
                | ValueType.Ip -> "ip"
                | ValueType.Numeric -> "numeric"
                | ValueType.GeoPoint -> "geo_point"
                | ValueType.Boolean -> "boolean"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "string" -> ValueType.String
            | "long" -> ValueType.Long
            | "double" -> ValueType.Double
            | "number" -> ValueType.Number
            | "date" -> ValueType.Date
            | "date_nanos" -> ValueType.DateNanos
            | "ip" -> ValueType.Ip
            | "numeric" -> ValueType.Numeric
            | "geo_point" -> ValueType.GeoPoint
            | "boolean" -> ValueType.Boolean
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ValueType"))

    type AnalyzerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Analyzer>()

        override _.Write(writer, value, options) =
            match value with
            | Analyzer.CustomAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.FingerprintAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.KeywordAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.NoriAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.PatternAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.SimpleAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.StandardAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.StopAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.WhitespaceAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.IcuAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.KuromojiAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.SnowballAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.ArabicAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.ArmenianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.BasqueAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.BengaliAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.BrazilianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.BulgarianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.CatalanAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.ChineseAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.CjkAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.CzechAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.DanishAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.DutchAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.EnglishAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.EstonianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.FinnishAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.FrenchAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.GalicianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.GermanAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.GreekAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.HindiAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.HungarianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.IndonesianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.IrishAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.ItalianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.LatvianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.LithuanianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.NorwegianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.PersianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.PortugueseAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.RomanianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.RussianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.SerbianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.SoraniAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.SpanishAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.SwedishAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.TurkishAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.ThaiAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Analyzer.Unknown (_, el) -> el.WriteTo(writer)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(&reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("type") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "customanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.CustomAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.CustomAnalyzer v
            | "fingerprintanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.FingerprintAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.FingerprintAnalyzer v
            | "keywordanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.KeywordAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.KeywordAnalyzer v
            | "norianalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.NoriAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.NoriAnalyzer v
            | "patternanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.PatternAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.PatternAnalyzer v
            | "simpleanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SimpleAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.SimpleAnalyzer v
            | "standardanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.StandardAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.StandardAnalyzer v
            | "stopanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.StopAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.StopAnalyzer v
            | "whitespaceanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.WhitespaceAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.WhitespaceAnalyzer v
            | "icuanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.IcuAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.IcuAnalyzer v
            | "kuromojianalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.KuromojiAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.KuromojiAnalyzer v
            | "snowballanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SnowballAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.SnowballAnalyzer v
            | "arabicanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ArabicAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.ArabicAnalyzer v
            | "armeniananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ArmenianAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.ArmenianAnalyzer v
            | "basqueanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.BasqueAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.BasqueAnalyzer v
            | "bengalianalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.BengaliAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.BengaliAnalyzer v
            | "braziliananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.BrazilianAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.BrazilianAnalyzer v
            | "bulgariananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.BulgarianAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.BulgarianAnalyzer v
            | "catalananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.CatalanAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.CatalanAnalyzer v
            | "chineseanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ChineseAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.ChineseAnalyzer v
            | "cjkanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.CjkAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.CjkAnalyzer v
            | "czechanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.CzechAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.CzechAnalyzer v
            | "danishanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.DanishAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.DanishAnalyzer v
            | "dutchanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.DutchAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.DutchAnalyzer v
            | "englishanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.EnglishAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.EnglishAnalyzer v
            | "estoniananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.EstonianAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.EstonianAnalyzer v
            | "finnishanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.FinnishAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.FinnishAnalyzer v
            | "frenchanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.FrenchAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.FrenchAnalyzer v
            | "galiciananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.GalicianAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.GalicianAnalyzer v
            | "germananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.GermanAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.GermanAnalyzer v
            | "greekanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.GreekAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.GreekAnalyzer v
            | "hindianalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.HindiAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.HindiAnalyzer v
            | "hungariananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.HungarianAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.HungarianAnalyzer v
            | "indonesiananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.IndonesianAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.IndonesianAnalyzer v
            | "irishanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.IrishAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.IrishAnalyzer v
            | "italiananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ItalianAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.ItalianAnalyzer v
            | "latviananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.LatvianAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.LatvianAnalyzer v
            | "lithuaniananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.LithuanianAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.LithuanianAnalyzer v
            | "norwegiananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.NorwegianAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.NorwegianAnalyzer v
            | "persiananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.PersianAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.PersianAnalyzer v
            | "portugueseanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.PortugueseAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.PortugueseAnalyzer v
            | "romaniananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.RomanianAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.RomanianAnalyzer v
            | "russiananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.RussianAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.RussianAnalyzer v
            | "serbiananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SerbianAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.SerbianAnalyzer v
            | "soranianalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SoraniAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.SoraniAnalyzer v
            | "spanishanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SpanishAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.SpanishAnalyzer v
            | "swedishanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SwedishAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.SwedishAnalyzer v
            | "turkishanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.TurkishAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.TurkishAnalyzer v
            | "thaianalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ThaiAnalyzer>(doc.RootElement.GetRawText(), options)
                Analyzer.ThaiAnalyzer v
            | _ -> Analyzer.Unknown (tagValue, doc.RootElement.Clone())

    type CharFilterDefinitionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CharFilterDefinition>()

        override _.Write(writer, value, options) =
            match value with
            | CharFilterDefinition.HtmlStripCharFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | CharFilterDefinition.MappingCharFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | CharFilterDefinition.PatternReplaceCharFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | CharFilterDefinition.IcuNormalizationCharFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | CharFilterDefinition.KuromojiIterationMarkCharFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | CharFilterDefinition.Unknown (_, el) -> el.WriteTo(writer)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(&reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("type") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "htmlstripcharfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.HtmlStripCharFilter>(doc.RootElement.GetRawText(), options)
                CharFilterDefinition.HtmlStripCharFilter v
            | "mappingcharfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.MappingCharFilter>(doc.RootElement.GetRawText(), options)
                CharFilterDefinition.MappingCharFilter v
            | "patternreplacecharfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.PatternReplaceCharFilter>(doc.RootElement.GetRawText(), options)
                CharFilterDefinition.PatternReplaceCharFilter v
            | "icunormalizationcharfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.IcuNormalizationCharFilter>(doc.RootElement.GetRawText(), options)
                CharFilterDefinition.IcuNormalizationCharFilter v
            | "kuromojiiterationmarkcharfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.KuromojiIterationMarkCharFilter>(doc.RootElement.GetRawText(), options)
                CharFilterDefinition.KuromojiIterationMarkCharFilter v
            | _ -> CharFilterDefinition.Unknown (tagValue, doc.RootElement.Clone())

    type CjkBigramIgnoredScriptConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CjkBigramIgnoredScript>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CjkBigramIgnoredScript.Han -> "han"
                | CjkBigramIgnoredScript.Hangul -> "hangul"
                | CjkBigramIgnoredScript.Hiragana -> "hiragana"
                | CjkBigramIgnoredScript.Katakana -> "katakana"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "han" -> CjkBigramIgnoredScript.Han
            | "hangul" -> CjkBigramIgnoredScript.Hangul
            | "hiragana" -> CjkBigramIgnoredScript.Hiragana
            | "katakana" -> CjkBigramIgnoredScript.Katakana
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CjkBigramIgnoredScript"))

    type DelimitedPayloadEncodingConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DelimitedPayloadEncoding>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | DelimitedPayloadEncoding.Int -> "int"
                | DelimitedPayloadEncoding.Float -> "float"
                | DelimitedPayloadEncoding.Identity -> "identity"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "int" -> DelimitedPayloadEncoding.Int
            | "float" -> DelimitedPayloadEncoding.Float
            | "identity" -> DelimitedPayloadEncoding.Identity
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DelimitedPayloadEncoding"))

    type EdgeNGramSideConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<EdgeNGramSide>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | EdgeNGramSide.Front -> "front"
                | EdgeNGramSide.Back -> "back"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "front" -> EdgeNGramSide.Front
            | "back" -> EdgeNGramSide.Back
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for EdgeNGramSide"))

    type IcuCollationAlternateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IcuCollationAlternate>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IcuCollationAlternate.Shifted -> "shifted"
                | IcuCollationAlternate.NonIgnorable -> "non-ignorable"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "shifted" -> IcuCollationAlternate.Shifted
            | "non-ignorable" -> IcuCollationAlternate.NonIgnorable
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IcuCollationAlternate"))

    type IcuCollationCaseFirstConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IcuCollationCaseFirst>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IcuCollationCaseFirst.Lower -> "lower"
                | IcuCollationCaseFirst.Upper -> "upper"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "lower" -> IcuCollationCaseFirst.Lower
            | "upper" -> IcuCollationCaseFirst.Upper
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IcuCollationCaseFirst"))

    type IcuCollationDecompositionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IcuCollationDecomposition>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IcuCollationDecomposition.No -> "no"
                | IcuCollationDecomposition.Identical -> "identical"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "no" -> IcuCollationDecomposition.No
            | "identical" -> IcuCollationDecomposition.Identical
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IcuCollationDecomposition"))

    type IcuCollationStrengthConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IcuCollationStrength>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IcuCollationStrength.Primary -> "primary"
                | IcuCollationStrength.Secondary -> "secondary"
                | IcuCollationStrength.Tertiary -> "tertiary"
                | IcuCollationStrength.Quaternary -> "quaternary"
                | IcuCollationStrength.Identical -> "identical"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "primary" -> IcuCollationStrength.Primary
            | "secondary" -> IcuCollationStrength.Secondary
            | "tertiary" -> IcuCollationStrength.Tertiary
            | "quaternary" -> IcuCollationStrength.Quaternary
            | "identical" -> IcuCollationStrength.Identical
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IcuCollationStrength"))

    type IcuNormalizationModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IcuNormalizationMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IcuNormalizationMode.Decompose -> "decompose"
                | IcuNormalizationMode.Compose -> "compose"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "decompose" -> IcuNormalizationMode.Decompose
            | "compose" -> IcuNormalizationMode.Compose
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IcuNormalizationMode"))

    type IcuNormalizationTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IcuNormalizationType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IcuNormalizationType.Nfc -> "nfc"
                | IcuNormalizationType.Nfkc -> "nfkc"
                | IcuNormalizationType.NfkcCf -> "nfkc_cf"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "nfc" -> IcuNormalizationType.Nfc
            | "nfkc" -> IcuNormalizationType.Nfkc
            | "nfkc_cf" -> IcuNormalizationType.NfkcCf
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IcuNormalizationType"))

    type IcuTransformDirectionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IcuTransformDirection>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IcuTransformDirection.Forward -> "forward"
                | IcuTransformDirection.Reverse -> "reverse"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "forward" -> IcuTransformDirection.Forward
            | "reverse" -> IcuTransformDirection.Reverse
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IcuTransformDirection"))

    type KeepTypesModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<KeepTypesMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | KeepTypesMode.Include -> "include"
                | KeepTypesMode.Exclude -> "exclude"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "include" -> KeepTypesMode.Include
            | "exclude" -> KeepTypesMode.Exclude
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for KeepTypesMode"))

    type KuromojiTokenizationModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<KuromojiTokenizationMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | KuromojiTokenizationMode.Normal -> "normal"
                | KuromojiTokenizationMode.Search -> "search"
                | KuromojiTokenizationMode.Extended -> "extended"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "normal" -> KuromojiTokenizationMode.Normal
            | "search" -> KuromojiTokenizationMode.Search
            | "extended" -> KuromojiTokenizationMode.Extended
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for KuromojiTokenizationMode"))

    type LowercaseTokenFilterLanguagesConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<LowercaseTokenFilterLanguages>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | LowercaseTokenFilterLanguages.Greek -> "greek"
                | LowercaseTokenFilterLanguages.Irish -> "irish"
                | LowercaseTokenFilterLanguages.Turkish -> "turkish"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "greek" -> LowercaseTokenFilterLanguages.Greek
            | "irish" -> LowercaseTokenFilterLanguages.Irish
            | "turkish" -> LowercaseTokenFilterLanguages.Turkish
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for LowercaseTokenFilterLanguages"))

    type NoriDecompoundModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<NoriDecompoundMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | NoriDecompoundMode.Discard -> "discard"
                | NoriDecompoundMode.None -> "none"
                | NoriDecompoundMode.Mixed -> "mixed"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "discard" -> NoriDecompoundMode.Discard
            | "none" -> NoriDecompoundMode.None
            | "mixed" -> NoriDecompoundMode.Mixed
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for NoriDecompoundMode"))

    type NormalizerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Normalizer>()

        override _.Write(writer, value, options) =
            match value with
            | Normalizer.LowercaseNormalizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Normalizer.CustomNormalizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(&reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("type") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "lowercasenormalizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.LowercaseNormalizer>(doc.RootElement.GetRawText(), options)
                Normalizer.LowercaseNormalizer v
            | "customnormalizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.CustomNormalizer>(doc.RootElement.GetRawText(), options)
                Normalizer.CustomNormalizer v
            | other -> raise (System.Text.Json.JsonException($"Unknown tag value '{other}' for Normalizer"))

    type PhoneticEncoderConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<PhoneticEncoder>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | PhoneticEncoder.Metaphone -> "metaphone"
                | PhoneticEncoder.DoubleMetaphone -> "double_metaphone"
                | PhoneticEncoder.Soundex -> "soundex"
                | PhoneticEncoder.RefinedSoundex -> "refined_soundex"
                | PhoneticEncoder.Caverphone1 -> "caverphone1"
                | PhoneticEncoder.Caverphone2 -> "caverphone2"
                | PhoneticEncoder.Cologne -> "cologne"
                | PhoneticEncoder.Nysiis -> "nysiis"
                | PhoneticEncoder.Koelnerphonetik -> "koelnerphonetik"
                | PhoneticEncoder.Haasephonetik -> "haasephonetik"
                | PhoneticEncoder.BeiderMorse -> "beider_morse"
                | PhoneticEncoder.DaitchMokotoff -> "daitch_mokotoff"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "metaphone" -> PhoneticEncoder.Metaphone
            | "double_metaphone" -> PhoneticEncoder.DoubleMetaphone
            | "soundex" -> PhoneticEncoder.Soundex
            | "refined_soundex" -> PhoneticEncoder.RefinedSoundex
            | "caverphone1" -> PhoneticEncoder.Caverphone1
            | "caverphone2" -> PhoneticEncoder.Caverphone2
            | "cologne" -> PhoneticEncoder.Cologne
            | "nysiis" -> PhoneticEncoder.Nysiis
            | "koelnerphonetik" -> PhoneticEncoder.Koelnerphonetik
            | "haasephonetik" -> PhoneticEncoder.Haasephonetik
            | "beider_morse" -> PhoneticEncoder.BeiderMorse
            | "daitch_mokotoff" -> PhoneticEncoder.DaitchMokotoff
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for PhoneticEncoder"))

    type PhoneticLanguageConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<PhoneticLanguage>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | PhoneticLanguage.Any -> "any"
                | PhoneticLanguage.Common -> "common"
                | PhoneticLanguage.Cyrillic -> "cyrillic"
                | PhoneticLanguage.English -> "english"
                | PhoneticLanguage.French -> "french"
                | PhoneticLanguage.German -> "german"
                | PhoneticLanguage.Hebrew -> "hebrew"
                | PhoneticLanguage.Hungarian -> "hungarian"
                | PhoneticLanguage.Polish -> "polish"
                | PhoneticLanguage.Romanian -> "romanian"
                | PhoneticLanguage.Russian -> "russian"
                | PhoneticLanguage.Spanish -> "spanish"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "any" -> PhoneticLanguage.Any
            | "common" -> PhoneticLanguage.Common
            | "cyrillic" -> PhoneticLanguage.Cyrillic
            | "english" -> PhoneticLanguage.English
            | "french" -> PhoneticLanguage.French
            | "german" -> PhoneticLanguage.German
            | "hebrew" -> PhoneticLanguage.Hebrew
            | "hungarian" -> PhoneticLanguage.Hungarian
            | "polish" -> PhoneticLanguage.Polish
            | "romanian" -> PhoneticLanguage.Romanian
            | "russian" -> PhoneticLanguage.Russian
            | "spanish" -> PhoneticLanguage.Spanish
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for PhoneticLanguage"))

    type PhoneticNameTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<PhoneticNameType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | PhoneticNameType.Generic -> "generic"
                | PhoneticNameType.Ashkenazi -> "ashkenazi"
                | PhoneticNameType.Sephardic -> "sephardic"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "generic" -> PhoneticNameType.Generic
            | "ashkenazi" -> PhoneticNameType.Ashkenazi
            | "sephardic" -> PhoneticNameType.Sephardic
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for PhoneticNameType"))

    type PhoneticRuleTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<PhoneticRuleType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | PhoneticRuleType.Approx -> "approx"
                | PhoneticRuleType.Exact -> "exact"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "approx" -> PhoneticRuleType.Approx
            | "exact" -> PhoneticRuleType.Exact
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for PhoneticRuleType"))

    type SnowballLanguageConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SnowballLanguage>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SnowballLanguage.Arabic -> "Arabic"
                | SnowballLanguage.Armenian -> "Armenian"
                | SnowballLanguage.Basque -> "Basque"
                | SnowballLanguage.Catalan -> "Catalan"
                | SnowballLanguage.Danish -> "Danish"
                | SnowballLanguage.Dutch -> "Dutch"
                | SnowballLanguage.English -> "English"
                | SnowballLanguage.Estonian -> "Estonian"
                | SnowballLanguage.Finnish -> "Finnish"
                | SnowballLanguage.French -> "French"
                | SnowballLanguage.German -> "German"
                | SnowballLanguage.German2 -> "German2"
                | SnowballLanguage.Hungarian -> "Hungarian"
                | SnowballLanguage.Italian -> "Italian"
                | SnowballLanguage.Irish -> "Irish"
                | SnowballLanguage.Kp -> "Kp"
                | SnowballLanguage.Lithuanian -> "Lithuanian"
                | SnowballLanguage.Lovins -> "Lovins"
                | SnowballLanguage.Norwegian -> "Norwegian"
                | SnowballLanguage.Porter -> "Porter"
                | SnowballLanguage.Portuguese -> "Portuguese"
                | SnowballLanguage.Romanian -> "Romanian"
                | SnowballLanguage.Russian -> "Russian"
                | SnowballLanguage.Serbian -> "Serbian"
                | SnowballLanguage.Spanish -> "Spanish"
                | SnowballLanguage.Swedish -> "Swedish"
                | SnowballLanguage.Turkish -> "Turkish"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "Arabic" -> SnowballLanguage.Arabic
            | "Armenian" -> SnowballLanguage.Armenian
            | "Basque" -> SnowballLanguage.Basque
            | "Catalan" -> SnowballLanguage.Catalan
            | "Danish" -> SnowballLanguage.Danish
            | "Dutch" -> SnowballLanguage.Dutch
            | "English" -> SnowballLanguage.English
            | "Estonian" -> SnowballLanguage.Estonian
            | "Finnish" -> SnowballLanguage.Finnish
            | "French" -> SnowballLanguage.French
            | "German" -> SnowballLanguage.German
            | "German2" -> SnowballLanguage.German2
            | "Hungarian" -> SnowballLanguage.Hungarian
            | "Italian" -> SnowballLanguage.Italian
            | "Irish" -> SnowballLanguage.Irish
            | "Kp" -> SnowballLanguage.Kp
            | "Lithuanian" -> SnowballLanguage.Lithuanian
            | "Lovins" -> SnowballLanguage.Lovins
            | "Norwegian" -> SnowballLanguage.Norwegian
            | "Porter" -> SnowballLanguage.Porter
            | "Portuguese" -> SnowballLanguage.Portuguese
            | "Romanian" -> SnowballLanguage.Romanian
            | "Russian" -> SnowballLanguage.Russian
            | "Serbian" -> SnowballLanguage.Serbian
            | "Spanish" -> SnowballLanguage.Spanish
            | "Swedish" -> SnowballLanguage.Swedish
            | "Turkish" -> SnowballLanguage.Turkish
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SnowballLanguage"))

    type StopWordLanguageConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<StopWordLanguage>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | StopWordLanguage.Arabic -> "_arabic_"
                | StopWordLanguage.Armenian -> "_armenian_"
                | StopWordLanguage.Basque -> "_basque_"
                | StopWordLanguage.Bengali -> "_bengali_"
                | StopWordLanguage.Brazilian -> "_brazilian_"
                | StopWordLanguage.Bulgarian -> "_bulgarian_"
                | StopWordLanguage.Catalan -> "_catalan_"
                | StopWordLanguage.Cjk -> "_cjk_"
                | StopWordLanguage.Czech -> "_czech_"
                | StopWordLanguage.Danish -> "_danish_"
                | StopWordLanguage.Dutch -> "_dutch_"
                | StopWordLanguage.English -> "_english_"
                | StopWordLanguage.Estonian -> "_estonian_"
                | StopWordLanguage.Finnish -> "_finnish_"
                | StopWordLanguage.French -> "_french_"
                | StopWordLanguage.Galician -> "_galician_"
                | StopWordLanguage.German -> "_german_"
                | StopWordLanguage.Greek -> "_greek_"
                | StopWordLanguage.Hindi -> "_hindi_"
                | StopWordLanguage.Hungarian -> "_hungarian_"
                | StopWordLanguage.Indonesian -> "_indonesian_"
                | StopWordLanguage.Irish -> "_irish_"
                | StopWordLanguage.Italian -> "_italian_"
                | StopWordLanguage.Latvian -> "_latvian_"
                | StopWordLanguage.Lithuanian -> "_lithuanian_"
                | StopWordLanguage.Norwegian -> "_norwegian_"
                | StopWordLanguage.Persian -> "_persian_"
                | StopWordLanguage.Portuguese -> "_portuguese_"
                | StopWordLanguage.Romanian -> "_romanian_"
                | StopWordLanguage.Russian -> "_russian_"
                | StopWordLanguage.Serbian -> "_serbian_"
                | StopWordLanguage.Sorani -> "_sorani_"
                | StopWordLanguage.Spanish -> "_spanish_"
                | StopWordLanguage.Swedish -> "_swedish_"
                | StopWordLanguage.Thai -> "_thai_"
                | StopWordLanguage.Turkish -> "_turkish_"
                | StopWordLanguage.None -> "_none_"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "_arabic_" -> StopWordLanguage.Arabic
            | "_armenian_" -> StopWordLanguage.Armenian
            | "_basque_" -> StopWordLanguage.Basque
            | "_bengali_" -> StopWordLanguage.Bengali
            | "_brazilian_" -> StopWordLanguage.Brazilian
            | "_bulgarian_" -> StopWordLanguage.Bulgarian
            | "_catalan_" -> StopWordLanguage.Catalan
            | "_cjk_" -> StopWordLanguage.Cjk
            | "_czech_" -> StopWordLanguage.Czech
            | "_danish_" -> StopWordLanguage.Danish
            | "_dutch_" -> StopWordLanguage.Dutch
            | "_english_" -> StopWordLanguage.English
            | "_estonian_" -> StopWordLanguage.Estonian
            | "_finnish_" -> StopWordLanguage.Finnish
            | "_french_" -> StopWordLanguage.French
            | "_galician_" -> StopWordLanguage.Galician
            | "_german_" -> StopWordLanguage.German
            | "_greek_" -> StopWordLanguage.Greek
            | "_hindi_" -> StopWordLanguage.Hindi
            | "_hungarian_" -> StopWordLanguage.Hungarian
            | "_indonesian_" -> StopWordLanguage.Indonesian
            | "_irish_" -> StopWordLanguage.Irish
            | "_italian_" -> StopWordLanguage.Italian
            | "_latvian_" -> StopWordLanguage.Latvian
            | "_lithuanian_" -> StopWordLanguage.Lithuanian
            | "_norwegian_" -> StopWordLanguage.Norwegian
            | "_persian_" -> StopWordLanguage.Persian
            | "_portuguese_" -> StopWordLanguage.Portuguese
            | "_romanian_" -> StopWordLanguage.Romanian
            | "_russian_" -> StopWordLanguage.Russian
            | "_serbian_" -> StopWordLanguage.Serbian
            | "_sorani_" -> StopWordLanguage.Sorani
            | "_spanish_" -> StopWordLanguage.Spanish
            | "_swedish_" -> StopWordLanguage.Swedish
            | "_thai_" -> StopWordLanguage.Thai
            | "_turkish_" -> StopWordLanguage.Turkish
            | "_none_" -> StopWordLanguage.None
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for StopWordLanguage"))

    type SynonymFormatConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SynonymFormat>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SynonymFormat.Solr -> "solr"
                | SynonymFormat.Wordnet -> "wordnet"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "solr" -> SynonymFormat.Solr
            | "wordnet" -> SynonymFormat.Wordnet
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SynonymFormat"))

    type TokenCharConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TokenChar>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TokenChar.Letter -> "letter"
                | TokenChar.Digit -> "digit"
                | TokenChar.Whitespace -> "whitespace"
                | TokenChar.Punctuation -> "punctuation"
                | TokenChar.Symbol -> "symbol"
                | TokenChar.Custom -> "custom"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "letter" -> TokenChar.Letter
            | "digit" -> TokenChar.Digit
            | "whitespace" -> TokenChar.Whitespace
            | "punctuation" -> TokenChar.Punctuation
            | "symbol" -> TokenChar.Symbol
            | "custom" -> TokenChar.Custom
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TokenChar"))

    type TokenFilterDefinitionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TokenFilterDefinition>()

        override _.Write(writer, value, options) =
            match value with
            | TokenFilterDefinition.ApostropheTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.ArabicStemTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.ArabicNormalizationTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.AsciiFoldingTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.BengaliNormalizationTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.BrazilianStemTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.CjkBigramTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.CjkWidthTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.ClassicTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.CommonGramsTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.ConditionTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.CzechStemTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.DecimalDigitTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.DelimitedPayloadTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.DutchStemTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.EdgeNGramTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.ElisionTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.FingerprintTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.FlattenGraphTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.FrenchStemTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.GermanNormalizationTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.GermanStemTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.HindiNormalizationTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.HunspellTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.HyphenationDecompounderTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.IndicNormalizationTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.KeepTypesTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.KeepWordsTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.KeywordMarkerTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.KeywordRepeatTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.KStemTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.LengthTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.LimitTokenCountTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.LowercaseTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.MinHashTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.MultiplexerTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.NGramTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.NoriPartOfSpeechTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.PatternCaptureTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.PatternReplaceTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.PersianNormalizationTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.PersianStemTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.PorterStemTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.PredicateTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.RemoveDuplicatesTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.ReverseTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.RussianStemTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.ScandinavianFoldingTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.ScandinavianNormalizationTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.SerbianNormalizationTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.ShingleTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.SnowballTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.SoraniNormalizationTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.StemmerOverrideTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.StemmerTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.StopTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.SynonymGraphTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.SynonymTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.TrimTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.TruncateTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.UniqueTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.UppercaseTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.WordDelimiterGraphTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.WordDelimiterTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.JaStopTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.KuromojiStemmerTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.KuromojiReadingFormTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.KuromojiPartOfSpeechTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.IcuCollationTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.IcuFoldingTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.IcuNormalizationTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.IcuTransformTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.PhoneticTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.DictionaryDecompounderTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenFilterDefinition.Unknown (_, el) -> el.WriteTo(writer)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(&reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("type") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "apostrophetokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ApostropheTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.ApostropheTokenFilter v
            | "arabicstemtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ArabicStemTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.ArabicStemTokenFilter v
            | "arabicnormalizationtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ArabicNormalizationTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.ArabicNormalizationTokenFilter v
            | "asciifoldingtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.AsciiFoldingTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.AsciiFoldingTokenFilter v
            | "bengalinormalizationtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.BengaliNormalizationTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.BengaliNormalizationTokenFilter v
            | "brazilianstemtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.BrazilianStemTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.BrazilianStemTokenFilter v
            | "cjkbigramtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.CjkBigramTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.CjkBigramTokenFilter v
            | "cjkwidthtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.CjkWidthTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.CjkWidthTokenFilter v
            | "classictokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ClassicTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.ClassicTokenFilter v
            | "commongramstokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.CommonGramsTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.CommonGramsTokenFilter v
            | "conditiontokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ConditionTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.ConditionTokenFilter v
            | "czechstemtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.CzechStemTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.CzechStemTokenFilter v
            | "decimaldigittokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.DecimalDigitTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.DecimalDigitTokenFilter v
            | "delimitedpayloadtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.DelimitedPayloadTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.DelimitedPayloadTokenFilter v
            | "dutchstemtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.DutchStemTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.DutchStemTokenFilter v
            | "edgengramtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.EdgeNGramTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.EdgeNGramTokenFilter v
            | "elisiontokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ElisionTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.ElisionTokenFilter v
            | "fingerprinttokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.FingerprintTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.FingerprintTokenFilter v
            | "flattengraphtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.FlattenGraphTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.FlattenGraphTokenFilter v
            | "frenchstemtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.FrenchStemTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.FrenchStemTokenFilter v
            | "germannormalizationtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.GermanNormalizationTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.GermanNormalizationTokenFilter v
            | "germanstemtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.GermanStemTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.GermanStemTokenFilter v
            | "hindinormalizationtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.HindiNormalizationTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.HindiNormalizationTokenFilter v
            | "hunspelltokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.HunspellTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.HunspellTokenFilter v
            | "hyphenationdecompoundertokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.HyphenationDecompounderTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.HyphenationDecompounderTokenFilter v
            | "indicnormalizationtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.IndicNormalizationTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.IndicNormalizationTokenFilter v
            | "keeptypestokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.KeepTypesTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.KeepTypesTokenFilter v
            | "keepwordstokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.KeepWordsTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.KeepWordsTokenFilter v
            | "keywordmarkertokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.KeywordMarkerTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.KeywordMarkerTokenFilter v
            | "keywordrepeattokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.KeywordRepeatTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.KeywordRepeatTokenFilter v
            | "kstemtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.KStemTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.KStemTokenFilter v
            | "lengthtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.LengthTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.LengthTokenFilter v
            | "limittokencounttokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.LimitTokenCountTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.LimitTokenCountTokenFilter v
            | "lowercasetokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.LowercaseTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.LowercaseTokenFilter v
            | "minhashtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.MinHashTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.MinHashTokenFilter v
            | "multiplexertokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.MultiplexerTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.MultiplexerTokenFilter v
            | "ngramtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.NGramTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.NGramTokenFilter v
            | "noripartofspeechtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.NoriPartOfSpeechTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.NoriPartOfSpeechTokenFilter v
            | "patterncapturetokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.PatternCaptureTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.PatternCaptureTokenFilter v
            | "patternreplacetokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.PatternReplaceTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.PatternReplaceTokenFilter v
            | "persiannormalizationtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.PersianNormalizationTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.PersianNormalizationTokenFilter v
            | "persianstemtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.PersianStemTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.PersianStemTokenFilter v
            | "porterstemtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.PorterStemTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.PorterStemTokenFilter v
            | "predicatetokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.PredicateTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.PredicateTokenFilter v
            | "removeduplicatestokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.RemoveDuplicatesTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.RemoveDuplicatesTokenFilter v
            | "reversetokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ReverseTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.ReverseTokenFilter v
            | "russianstemtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.RussianStemTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.RussianStemTokenFilter v
            | "scandinavianfoldingtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ScandinavianFoldingTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.ScandinavianFoldingTokenFilter v
            | "scandinaviannormalizationtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ScandinavianNormalizationTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.ScandinavianNormalizationTokenFilter v
            | "serbiannormalizationtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SerbianNormalizationTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.SerbianNormalizationTokenFilter v
            | "shingletokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ShingleTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.ShingleTokenFilter v
            | "snowballtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SnowballTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.SnowballTokenFilter v
            | "soraninormalizationtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SoraniNormalizationTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.SoraniNormalizationTokenFilter v
            | "stemmeroverridetokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.StemmerOverrideTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.StemmerOverrideTokenFilter v
            | "stemmertokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.StemmerTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.StemmerTokenFilter v
            | "stoptokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.StopTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.StopTokenFilter v
            | "synonymgraphtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SynonymGraphTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.SynonymGraphTokenFilter v
            | "synonymtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SynonymTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.SynonymTokenFilter v
            | "trimtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.TrimTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.TrimTokenFilter v
            | "truncatetokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.TruncateTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.TruncateTokenFilter v
            | "uniquetokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.UniqueTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.UniqueTokenFilter v
            | "uppercasetokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.UppercaseTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.UppercaseTokenFilter v
            | "worddelimitergraphtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.WordDelimiterGraphTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.WordDelimiterGraphTokenFilter v
            | "worddelimitertokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.WordDelimiterTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.WordDelimiterTokenFilter v
            | "jastoptokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.JaStopTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.JaStopTokenFilter v
            | "kuromojistemmertokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.KuromojiStemmerTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.KuromojiStemmerTokenFilter v
            | "kuromojireadingformtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.KuromojiReadingFormTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.KuromojiReadingFormTokenFilter v
            | "kuromojipartofspeechtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.KuromojiPartOfSpeechTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.KuromojiPartOfSpeechTokenFilter v
            | "icucollationtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.IcuCollationTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.IcuCollationTokenFilter v
            | "icufoldingtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.IcuFoldingTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.IcuFoldingTokenFilter v
            | "icunormalizationtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.IcuNormalizationTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.IcuNormalizationTokenFilter v
            | "icutransformtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.IcuTransformTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.IcuTransformTokenFilter v
            | "phonetictokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.PhoneticTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.PhoneticTokenFilter v
            | "dictionarydecompoundertokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.DictionaryDecompounderTokenFilter>(doc.RootElement.GetRawText(), options)
                TokenFilterDefinition.DictionaryDecompounderTokenFilter v
            | _ -> TokenFilterDefinition.Unknown (tagValue, doc.RootElement.Clone())

    type TokenizerDefinitionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TokenizerDefinition>()

        override _.Write(writer, value, options) =
            match value with
            | TokenizerDefinition.CharGroupTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenizerDefinition.ClassicTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenizerDefinition.EdgeNGramTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenizerDefinition.KeywordTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenizerDefinition.LetterTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenizerDefinition.LowercaseTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenizerDefinition.NGramTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenizerDefinition.PathHierarchyTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenizerDefinition.PatternTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenizerDefinition.SimplePatternTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenizerDefinition.SimplePatternSplitTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenizerDefinition.StandardTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenizerDefinition.ThaiTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenizerDefinition.UaxEmailUrlTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenizerDefinition.WhitespaceTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenizerDefinition.IcuTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenizerDefinition.KuromojiTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenizerDefinition.NoriTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenizerDefinition.Unknown (_, el) -> el.WriteTo(writer)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(&reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("type") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "chargrouptokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.CharGroupTokenizer>(doc.RootElement.GetRawText(), options)
                TokenizerDefinition.CharGroupTokenizer v
            | "classictokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ClassicTokenizer>(doc.RootElement.GetRawText(), options)
                TokenizerDefinition.ClassicTokenizer v
            | "edgengramtokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.EdgeNGramTokenizer>(doc.RootElement.GetRawText(), options)
                TokenizerDefinition.EdgeNGramTokenizer v
            | "keywordtokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.KeywordTokenizer>(doc.RootElement.GetRawText(), options)
                TokenizerDefinition.KeywordTokenizer v
            | "lettertokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.LetterTokenizer>(doc.RootElement.GetRawText(), options)
                TokenizerDefinition.LetterTokenizer v
            | "lowercasetokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.LowercaseTokenizer>(doc.RootElement.GetRawText(), options)
                TokenizerDefinition.LowercaseTokenizer v
            | "ngramtokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.NGramTokenizer>(doc.RootElement.GetRawText(), options)
                TokenizerDefinition.NGramTokenizer v
            | "pathhierarchytokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.PathHierarchyTokenizer>(doc.RootElement.GetRawText(), options)
                TokenizerDefinition.PathHierarchyTokenizer v
            | "patterntokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.PatternTokenizer>(doc.RootElement.GetRawText(), options)
                TokenizerDefinition.PatternTokenizer v
            | "simplepatterntokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SimplePatternTokenizer>(doc.RootElement.GetRawText(), options)
                TokenizerDefinition.SimplePatternTokenizer v
            | "simplepatternsplittokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SimplePatternSplitTokenizer>(doc.RootElement.GetRawText(), options)
                TokenizerDefinition.SimplePatternSplitTokenizer v
            | "standardtokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.StandardTokenizer>(doc.RootElement.GetRawText(), options)
                TokenizerDefinition.StandardTokenizer v
            | "thaitokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ThaiTokenizer>(doc.RootElement.GetRawText(), options)
                TokenizerDefinition.ThaiTokenizer v
            | "uaxemailurltokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.UaxEmailUrlTokenizer>(doc.RootElement.GetRawText(), options)
                TokenizerDefinition.UaxEmailUrlTokenizer v
            | "whitespacetokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.WhitespaceTokenizer>(doc.RootElement.GetRawText(), options)
                TokenizerDefinition.WhitespaceTokenizer v
            | "icutokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.IcuTokenizer>(doc.RootElement.GetRawText(), options)
                TokenizerDefinition.IcuTokenizer v
            | "kuromojitokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.KuromojiTokenizer>(doc.RootElement.GetRawText(), options)
                TokenizerDefinition.KuromojiTokenizer v
            | "noritokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.NoriTokenizer>(doc.RootElement.GetRawText(), options)
                TokenizerDefinition.NoriTokenizer v
            | _ -> TokenizerDefinition.Unknown (tagValue, doc.RootElement.Clone())

    type DenseVectorElementTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DenseVectorElementType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | DenseVectorElementType.Bit -> "bit"
                | DenseVectorElementType.Byte -> "byte"
                | DenseVectorElementType.Float -> "float"
                | DenseVectorElementType.Bfloat16 -> "bfloat16"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "bit" -> DenseVectorElementType.Bit
            | "byte" -> DenseVectorElementType.Byte
            | "float" -> DenseVectorElementType.Float
            | "bfloat16" -> DenseVectorElementType.Bfloat16
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DenseVectorElementType"))

    type DenseVectorIndexOptionsTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DenseVectorIndexOptionsType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | DenseVectorIndexOptionsType.BbqFlat -> "bbq_flat"
                | DenseVectorIndexOptionsType.BbqHnsw -> "bbq_hnsw"
                | DenseVectorIndexOptionsType.BbqDisk -> "bbq_disk"
                | DenseVectorIndexOptionsType.Flat -> "flat"
                | DenseVectorIndexOptionsType.Hnsw -> "hnsw"
                | DenseVectorIndexOptionsType.Int4Flat -> "int4_flat"
                | DenseVectorIndexOptionsType.Int4Hnsw -> "int4_hnsw"
                | DenseVectorIndexOptionsType.Int8Flat -> "int8_flat"
                | DenseVectorIndexOptionsType.Int8Hnsw -> "int8_hnsw"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "bbq_flat" -> DenseVectorIndexOptionsType.BbqFlat
            | "bbq_hnsw" -> DenseVectorIndexOptionsType.BbqHnsw
            | "bbq_disk" -> DenseVectorIndexOptionsType.BbqDisk
            | "flat" -> DenseVectorIndexOptionsType.Flat
            | "hnsw" -> DenseVectorIndexOptionsType.Hnsw
            | "int4_flat" -> DenseVectorIndexOptionsType.Int4Flat
            | "int4_hnsw" -> DenseVectorIndexOptionsType.Int4Hnsw
            | "int8_flat" -> DenseVectorIndexOptionsType.Int8Flat
            | "int8_hnsw" -> DenseVectorIndexOptionsType.Int8Hnsw
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DenseVectorIndexOptionsType"))

    type DenseVectorSimilarityConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DenseVectorSimilarity>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | DenseVectorSimilarity.Cosine -> "cosine"
                | DenseVectorSimilarity.DotProduct -> "dot_product"
                | DenseVectorSimilarity.L2Norm -> "l2_norm"
                | DenseVectorSimilarity.MaxInnerProduct -> "max_inner_product"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cosine" -> DenseVectorSimilarity.Cosine
            | "dot_product" -> DenseVectorSimilarity.DotProduct
            | "l2_norm" -> DenseVectorSimilarity.L2Norm
            | "max_inner_product" -> DenseVectorSimilarity.MaxInnerProduct
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DenseVectorSimilarity"))

    type DynamicMappingConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DynamicMapping>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | DynamicMapping.Strict -> "strict"
                | DynamicMapping.Runtime -> "runtime"
                | DynamicMapping.True -> "true"
                | DynamicMapping.False -> "false"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "strict" -> DynamicMapping.Strict
            | "runtime" -> DynamicMapping.Runtime
            | "true" -> DynamicMapping.True
            | "false" -> DynamicMapping.False
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DynamicMapping"))

    type DynamicTemplateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DynamicTemplate>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | DynamicTemplate.Mapping v ->
                writer.WritePropertyName("mapping")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | DynamicTemplate.Runtime v ->
                writer.WritePropertyName("runtime")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for DynamicTemplate"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for DynamicTemplate"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "mapping" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.Property>(&reader, options)
                    DynamicTemplate.Mapping v
                | "runtime" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RuntimeField>(&reader, options)
                    DynamicTemplate.Runtime v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for DynamicTemplate"))
            reader.Read() |> ignore // EndObject
            result

    type FieldTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<FieldType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | FieldType.None -> "none"
                | FieldType.GeoPoint -> "geo_point"
                | FieldType.GeoShape -> "geo_shape"
                | FieldType.Ip -> "ip"
                | FieldType.Binary -> "binary"
                | FieldType.Keyword -> "keyword"
                | FieldType.Text -> "text"
                | FieldType.SearchAsYouType -> "search_as_you_type"
                | FieldType.Date -> "date"
                | FieldType.DateNanos -> "date_nanos"
                | FieldType.Boolean -> "boolean"
                | FieldType.Completion -> "completion"
                | FieldType.Nested -> "nested"
                | FieldType.Object -> "object"
                | FieldType.Passthrough -> "passthrough"
                | FieldType.Version -> "version"
                | FieldType.Murmur3 -> "murmur3"
                | FieldType.TokenCount -> "token_count"
                | FieldType.Percolator -> "percolator"
                | FieldType.Integer -> "integer"
                | FieldType.Long -> "long"
                | FieldType.Short -> "short"
                | FieldType.Byte -> "byte"
                | FieldType.Float -> "float"
                | FieldType.HalfFloat -> "half_float"
                | FieldType.ScaledFloat -> "scaled_float"
                | FieldType.Double -> "double"
                | FieldType.IntegerRange -> "integer_range"
                | FieldType.FloatRange -> "float_range"
                | FieldType.LongRange -> "long_range"
                | FieldType.DoubleRange -> "double_range"
                | FieldType.DateRange -> "date_range"
                | FieldType.IpRange -> "ip_range"
                | FieldType.Alias -> "alias"
                | FieldType.Join -> "join"
                | FieldType.RankFeature -> "rank_feature"
                | FieldType.RankFeatures -> "rank_features"
                | FieldType.Flattened -> "flattened"
                | FieldType.Shape -> "shape"
                | FieldType.Histogram -> "histogram"
                | FieldType.ConstantKeyword -> "constant_keyword"
                | FieldType.CountedKeyword -> "counted_keyword"
                | FieldType.AggregateMetricDouble -> "aggregate_metric_double"
                | FieldType.DenseVector -> "dense_vector"
                | FieldType.SemanticText -> "semantic_text"
                | FieldType.SparseVector -> "sparse_vector"
                | FieldType.MatchOnlyText -> "match_only_text"
                | FieldType.IcuCollationKeyword -> "icu_collation_keyword"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "none" -> FieldType.None
            | "geo_point" -> FieldType.GeoPoint
            | "geo_shape" -> FieldType.GeoShape
            | "ip" -> FieldType.Ip
            | "binary" -> FieldType.Binary
            | "keyword" -> FieldType.Keyword
            | "text" -> FieldType.Text
            | "search_as_you_type" -> FieldType.SearchAsYouType
            | "date" -> FieldType.Date
            | "date_nanos" -> FieldType.DateNanos
            | "boolean" -> FieldType.Boolean
            | "completion" -> FieldType.Completion
            | "nested" -> FieldType.Nested
            | "object" -> FieldType.Object
            | "passthrough" -> FieldType.Passthrough
            | "version" -> FieldType.Version
            | "murmur3" -> FieldType.Murmur3
            | "token_count" -> FieldType.TokenCount
            | "percolator" -> FieldType.Percolator
            | "integer" -> FieldType.Integer
            | "long" -> FieldType.Long
            | "short" -> FieldType.Short
            | "byte" -> FieldType.Byte
            | "float" -> FieldType.Float
            | "half_float" -> FieldType.HalfFloat
            | "scaled_float" -> FieldType.ScaledFloat
            | "double" -> FieldType.Double
            | "integer_range" -> FieldType.IntegerRange
            | "float_range" -> FieldType.FloatRange
            | "long_range" -> FieldType.LongRange
            | "double_range" -> FieldType.DoubleRange
            | "date_range" -> FieldType.DateRange
            | "ip_range" -> FieldType.IpRange
            | "alias" -> FieldType.Alias
            | "join" -> FieldType.Join
            | "rank_feature" -> FieldType.RankFeature
            | "rank_features" -> FieldType.RankFeatures
            | "flattened" -> FieldType.Flattened
            | "shape" -> FieldType.Shape
            | "histogram" -> FieldType.Histogram
            | "constant_keyword" -> FieldType.ConstantKeyword
            | "counted_keyword" -> FieldType.CountedKeyword
            | "aggregate_metric_double" -> FieldType.AggregateMetricDouble
            | "dense_vector" -> FieldType.DenseVector
            | "semantic_text" -> FieldType.SemanticText
            | "sparse_vector" -> FieldType.SparseVector
            | "match_only_text" -> FieldType.MatchOnlyText
            | "icu_collation_keyword" -> FieldType.IcuCollationKeyword
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FieldType"))

    type GeoOrientationConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GeoOrientation>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GeoOrientation.Right -> "right"
                | GeoOrientation.Left -> "left"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "right" -> GeoOrientation.Right
            | "left" -> GeoOrientation.Left
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GeoOrientation"))

    type GeoPointMetricTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GeoPointMetricType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GeoPointMetricType.Gauge -> "gauge"
                | GeoPointMetricType.Counter -> "counter"
                | GeoPointMetricType.Position -> "position"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "gauge" -> GeoPointMetricType.Gauge
            | "counter" -> GeoPointMetricType.Counter
            | "position" -> GeoPointMetricType.Position
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GeoPointMetricType"))

    type GeoStrategyConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GeoStrategy>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GeoStrategy.Recursive -> "recursive"
                | GeoStrategy.Term -> "term"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "recursive" -> GeoStrategy.Recursive
            | "term" -> GeoStrategy.Term
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GeoStrategy"))

    type IndexOptionsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndexOptions>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndexOptions.Docs -> "docs"
                | IndexOptions.Freqs -> "freqs"
                | IndexOptions.Positions -> "positions"
                | IndexOptions.Offsets -> "offsets"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "docs" -> IndexOptions.Docs
            | "freqs" -> IndexOptions.Freqs
            | "positions" -> IndexOptions.Positions
            | "offsets" -> IndexOptions.Offsets
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IndexOptions"))

    type MatchTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MatchType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MatchType.Simple -> "simple"
                | MatchType.Regex -> "regex"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "simple" -> MatchType.Simple
            | "regex" -> MatchType.Regex
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for MatchType"))

    type OnScriptErrorConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<OnScriptError>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | OnScriptError.Fail -> "fail"
                | OnScriptError.Continue -> "continue"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "fail" -> OnScriptError.Fail
            | "continue" -> OnScriptError.Continue
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for OnScriptError"))

    type PropertyConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Property>()

        override _.Write(writer, value, options) =
            match value with
            | Property.BinaryProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.BooleanProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.DynamicProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.JoinProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.KeywordProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.MatchOnlyTextProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.PercolatorProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.RankFeatureProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.RankFeaturesProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.SearchAsYouTypeProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.TextProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.VersionProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.WildcardProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.DateNanosProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.DateProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.AggregateMetricDoubleProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.DenseVectorProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.FlattenedProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.NestedProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.ObjectProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.PassthroughObjectProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.RankVectorProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.SemanticTextProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.SparseVectorProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.CompletionProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.ConstantKeywordProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.CountedKeywordProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.FieldAliasProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.HistogramProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.ExponentialHistogramProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.IpProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.Murmur3HashProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.TokenCountProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.GeoPointProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.GeoShapeProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.PointProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.ShapeProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.ByteNumberProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.DoubleNumberProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.FloatNumberProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.HalfFloatNumberProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.IntegerNumberProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.LongNumberProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.ScaledFloatNumberProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.ShortNumberProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.UnsignedLongNumberProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.DateRangeProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.DoubleRangeProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.FloatRangeProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.IntegerRangeProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.IpRangeProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.LongRangeProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.IcuCollationProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Property.Unknown (_, el) -> el.WriteTo(writer)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(&reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("type") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "binary" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.BinaryProperty>(doc.RootElement.GetRawText(), options)
                Property.BinaryProperty v
            | "boolean" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.BooleanProperty>(doc.RootElement.GetRawText(), options)
                Property.BooleanProperty v
            | "dynamic" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.DynamicProperty>(doc.RootElement.GetRawText(), options)
                Property.DynamicProperty v
            | "join" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.JoinProperty>(doc.RootElement.GetRawText(), options)
                Property.JoinProperty v
            | "keyword" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.KeywordProperty>(doc.RootElement.GetRawText(), options)
                Property.KeywordProperty v
            | "matchonlytext" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.MatchOnlyTextProperty>(doc.RootElement.GetRawText(), options)
                Property.MatchOnlyTextProperty v
            | "percolator" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.PercolatorProperty>(doc.RootElement.GetRawText(), options)
                Property.PercolatorProperty v
            | "rankfeature" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.RankFeatureProperty>(doc.RootElement.GetRawText(), options)
                Property.RankFeatureProperty v
            | "rankfeatures" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.RankFeaturesProperty>(doc.RootElement.GetRawText(), options)
                Property.RankFeaturesProperty v
            | "searchasyoutype" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SearchAsYouTypeProperty>(doc.RootElement.GetRawText(), options)
                Property.SearchAsYouTypeProperty v
            | "text" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.TextProperty>(doc.RootElement.GetRawText(), options)
                Property.TextProperty v
            | "version" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.VersionProperty>(doc.RootElement.GetRawText(), options)
                Property.VersionProperty v
            | "wildcard" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.WildcardProperty>(doc.RootElement.GetRawText(), options)
                Property.WildcardProperty v
            | "datenanos" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.DateNanosProperty>(doc.RootElement.GetRawText(), options)
                Property.DateNanosProperty v
            | "date" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.DateProperty>(doc.RootElement.GetRawText(), options)
                Property.DateProperty v
            | "aggregatemetricdouble" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.AggregateMetricDoubleProperty>(doc.RootElement.GetRawText(), options)
                Property.AggregateMetricDoubleProperty v
            | "densevector" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.DenseVectorProperty>(doc.RootElement.GetRawText(), options)
                Property.DenseVectorProperty v
            | "flattened" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.FlattenedProperty>(doc.RootElement.GetRawText(), options)
                Property.FlattenedProperty v
            | "nested" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.NestedProperty>(doc.RootElement.GetRawText(), options)
                Property.NestedProperty v
            | "object" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ObjectProperty>(doc.RootElement.GetRawText(), options)
                Property.ObjectProperty v
            | "passthroughobject" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.PassthroughObjectProperty>(doc.RootElement.GetRawText(), options)
                Property.PassthroughObjectProperty v
            | "rankvector" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.RankVectorProperty>(doc.RootElement.GetRawText(), options)
                Property.RankVectorProperty v
            | "semantictext" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SemanticTextProperty>(doc.RootElement.GetRawText(), options)
                Property.SemanticTextProperty v
            | "sparsevector" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SparseVectorProperty>(doc.RootElement.GetRawText(), options)
                Property.SparseVectorProperty v
            | "completion" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.CompletionProperty>(doc.RootElement.GetRawText(), options)
                Property.CompletionProperty v
            | "constantkeyword" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ConstantKeywordProperty>(doc.RootElement.GetRawText(), options)
                Property.ConstantKeywordProperty v
            | "countedkeyword" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.CountedKeywordProperty>(doc.RootElement.GetRawText(), options)
                Property.CountedKeywordProperty v
            | "fieldalias" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.FieldAliasProperty>(doc.RootElement.GetRawText(), options)
                Property.FieldAliasProperty v
            | "histogram" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.HistogramProperty>(doc.RootElement.GetRawText(), options)
                Property.HistogramProperty v
            | "exponentialhistogram" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ExponentialHistogramProperty>(doc.RootElement.GetRawText(), options)
                Property.ExponentialHistogramProperty v
            | "ip" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.IpProperty>(doc.RootElement.GetRawText(), options)
                Property.IpProperty v
            | "murmur3hash" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.Murmur3HashProperty>(doc.RootElement.GetRawText(), options)
                Property.Murmur3HashProperty v
            | "tokencount" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.TokenCountProperty>(doc.RootElement.GetRawText(), options)
                Property.TokenCountProperty v
            | "geopoint" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoPointProperty>(doc.RootElement.GetRawText(), options)
                Property.GeoPointProperty v
            | "geoshape" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoShapeProperty>(doc.RootElement.GetRawText(), options)
                Property.GeoShapeProperty v
            | "point" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.PointProperty>(doc.RootElement.GetRawText(), options)
                Property.PointProperty v
            | "shape" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ShapeProperty>(doc.RootElement.GetRawText(), options)
                Property.ShapeProperty v
            | "bytenumber" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ByteNumberProperty>(doc.RootElement.GetRawText(), options)
                Property.ByteNumberProperty v
            | "doublenumber" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.DoubleNumberProperty>(doc.RootElement.GetRawText(), options)
                Property.DoubleNumberProperty v
            | "floatnumber" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.FloatNumberProperty>(doc.RootElement.GetRawText(), options)
                Property.FloatNumberProperty v
            | "halffloatnumber" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.HalfFloatNumberProperty>(doc.RootElement.GetRawText(), options)
                Property.HalfFloatNumberProperty v
            | "integernumber" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntegerNumberProperty>(doc.RootElement.GetRawText(), options)
                Property.IntegerNumberProperty v
            | "longnumber" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.LongNumberProperty>(doc.RootElement.GetRawText(), options)
                Property.LongNumberProperty v
            | "scaledfloatnumber" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ScaledFloatNumberProperty>(doc.RootElement.GetRawText(), options)
                Property.ScaledFloatNumberProperty v
            | "shortnumber" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ShortNumberProperty>(doc.RootElement.GetRawText(), options)
                Property.ShortNumberProperty v
            | "unsignedlongnumber" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.UnsignedLongNumberProperty>(doc.RootElement.GetRawText(), options)
                Property.UnsignedLongNumberProperty v
            | "daterange" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.DateRangeProperty>(doc.RootElement.GetRawText(), options)
                Property.DateRangeProperty v
            | "doublerange" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.DoubleRangeProperty>(doc.RootElement.GetRawText(), options)
                Property.DoubleRangeProperty v
            | "floatrange" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.FloatRangeProperty>(doc.RootElement.GetRawText(), options)
                Property.FloatRangeProperty v
            | "integerrange" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntegerRangeProperty>(doc.RootElement.GetRawText(), options)
                Property.IntegerRangeProperty v
            | "iprange" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.IpRangeProperty>(doc.RootElement.GetRawText(), options)
                Property.IpRangeProperty v
            | "longrange" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.LongRangeProperty>(doc.RootElement.GetRawText(), options)
                Property.LongRangeProperty v
            | "icucollation" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.IcuCollationProperty>(doc.RootElement.GetRawText(), options)
                Property.IcuCollationProperty v
            | _ -> Property.Unknown (tagValue, doc.RootElement.Clone())

    type RankVectorElementTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<RankVectorElementType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | RankVectorElementType.Byte -> "byte"
                | RankVectorElementType.Float -> "float"
                | RankVectorElementType.Bit -> "bit"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "byte" -> RankVectorElementType.Byte
            | "float" -> RankVectorElementType.Float
            | "bit" -> RankVectorElementType.Bit
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for RankVectorElementType"))

    type RuntimeFieldTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<RuntimeFieldType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | RuntimeFieldType.Boolean -> "boolean"
                | RuntimeFieldType.Composite -> "composite"
                | RuntimeFieldType.Date -> "date"
                | RuntimeFieldType.Double -> "double"
                | RuntimeFieldType.GeoPoint -> "geo_point"
                | RuntimeFieldType.GeoShape -> "geo_shape"
                | RuntimeFieldType.Ip -> "ip"
                | RuntimeFieldType.Keyword -> "keyword"
                | RuntimeFieldType.Long -> "long"
                | RuntimeFieldType.Lookup -> "lookup"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "boolean" -> RuntimeFieldType.Boolean
            | "composite" -> RuntimeFieldType.Composite
            | "date" -> RuntimeFieldType.Date
            | "double" -> RuntimeFieldType.Double
            | "geo_point" -> RuntimeFieldType.GeoPoint
            | "geo_shape" -> RuntimeFieldType.GeoShape
            | "ip" -> RuntimeFieldType.Ip
            | "keyword" -> RuntimeFieldType.Keyword
            | "long" -> RuntimeFieldType.Long
            | "lookup" -> RuntimeFieldType.Lookup
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for RuntimeFieldType"))

    type SourceFieldModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SourceFieldMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SourceFieldMode.Disabled -> "disabled"
                | SourceFieldMode.Stored -> "stored"
                | SourceFieldMode.Synthetic -> "synthetic"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "disabled" -> SourceFieldMode.Disabled
            | "stored" -> SourceFieldMode.Stored
            | "synthetic" -> SourceFieldMode.Synthetic
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SourceFieldMode"))

    type SubobjectsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Subobjects>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Subobjects.True -> "true"
                | Subobjects.False -> "false"
                | Subobjects.Auto -> "auto"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "true" -> Subobjects.True
            | "false" -> Subobjects.False
            | "auto" -> Subobjects.Auto
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Subobjects"))

    type SyntheticSourceKeepEnumConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SyntheticSourceKeepEnum>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SyntheticSourceKeepEnum.None -> "none"
                | SyntheticSourceKeepEnum.Arrays -> "arrays"
                | SyntheticSourceKeepEnum.All -> "all"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "none" -> SyntheticSourceKeepEnum.None
            | "arrays" -> SyntheticSourceKeepEnum.Arrays
            | "all" -> SyntheticSourceKeepEnum.All
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SyntheticSourceKeepEnum"))

    type TermVectorOptionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TermVectorOption>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TermVectorOption.No -> "no"
                | TermVectorOption.Yes -> "yes"
                | TermVectorOption.WithOffsets -> "with_offsets"
                | TermVectorOption.WithPositions -> "with_positions"
                | TermVectorOption.WithPositionsOffsets -> "with_positions_offsets"
                | TermVectorOption.WithPositionsOffsetsPayloads -> "with_positions_offsets_payloads"
                | TermVectorOption.WithPositionsPayloads -> "with_positions_payloads"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "no" -> TermVectorOption.No
            | "yes" -> TermVectorOption.Yes
            | "with_offsets" -> TermVectorOption.WithOffsets
            | "with_positions" -> TermVectorOption.WithPositions
            | "with_positions_offsets" -> TermVectorOption.WithPositionsOffsets
            | "with_positions_offsets_payloads" -> TermVectorOption.WithPositionsOffsetsPayloads
            | "with_positions_payloads" -> TermVectorOption.WithPositionsPayloads
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TermVectorOption"))

    type TimeSeriesMetricTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TimeSeriesMetricType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TimeSeriesMetricType.Gauge -> "gauge"
                | TimeSeriesMetricType.Counter -> "counter"
                | TimeSeriesMetricType.Summary -> "summary"
                | TimeSeriesMetricType.Histogram -> "histogram"
                | TimeSeriesMetricType.Position -> "position"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "gauge" -> TimeSeriesMetricType.Gauge
            | "counter" -> TimeSeriesMetricType.Counter
            | "summary" -> TimeSeriesMetricType.Summary
            | "histogram" -> TimeSeriesMetricType.Histogram
            | "position" -> TimeSeriesMetricType.Position
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TimeSeriesMetricType"))

    type ChildScoreModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ChildScoreMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ChildScoreMode.None -> "none"
                | ChildScoreMode.Avg -> "avg"
                | ChildScoreMode.Sum -> "sum"
                | ChildScoreMode.Max -> "max"
                | ChildScoreMode.Min -> "min"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "none" -> ChildScoreMode.None
            | "avg" -> ChildScoreMode.Avg
            | "sum" -> ChildScoreMode.Sum
            | "max" -> ChildScoreMode.Max
            | "min" -> ChildScoreMode.Min
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ChildScoreMode"))

    type CombinedFieldsOperatorConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CombinedFieldsOperator>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CombinedFieldsOperator.Or -> "or"
                | CombinedFieldsOperator.And -> "and"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "or" -> CombinedFieldsOperator.Or
            | "and" -> CombinedFieldsOperator.And
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CombinedFieldsOperator"))

    type CombinedFieldsZeroTermsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CombinedFieldsZeroTerms>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CombinedFieldsZeroTerms.None -> "none"
                | CombinedFieldsZeroTerms.All -> "all"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "none" -> CombinedFieldsZeroTerms.None
            | "all" -> CombinedFieldsZeroTerms.All
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CombinedFieldsZeroTerms"))

    type FieldValueFactorModifierConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<FieldValueFactorModifier>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | FieldValueFactorModifier.None -> "none"
                | FieldValueFactorModifier.Log -> "log"
                | FieldValueFactorModifier.Log1p -> "log1p"
                | FieldValueFactorModifier.Log2p -> "log2p"
                | FieldValueFactorModifier.Ln -> "ln"
                | FieldValueFactorModifier.Ln1p -> "ln1p"
                | FieldValueFactorModifier.Ln2p -> "ln2p"
                | FieldValueFactorModifier.Square -> "square"
                | FieldValueFactorModifier.Sqrt -> "sqrt"
                | FieldValueFactorModifier.Reciprocal -> "reciprocal"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "none" -> FieldValueFactorModifier.None
            | "log" -> FieldValueFactorModifier.Log
            | "log1p" -> FieldValueFactorModifier.Log1p
            | "log2p" -> FieldValueFactorModifier.Log2p
            | "ln" -> FieldValueFactorModifier.Ln
            | "ln1p" -> FieldValueFactorModifier.Ln1p
            | "ln2p" -> FieldValueFactorModifier.Ln2p
            | "square" -> FieldValueFactorModifier.Square
            | "sqrt" -> FieldValueFactorModifier.Sqrt
            | "reciprocal" -> FieldValueFactorModifier.Reciprocal
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FieldValueFactorModifier"))

    type FunctionBoostModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<FunctionBoostMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | FunctionBoostMode.Multiply -> "multiply"
                | FunctionBoostMode.Replace -> "replace"
                | FunctionBoostMode.Sum -> "sum"
                | FunctionBoostMode.Avg -> "avg"
                | FunctionBoostMode.Max -> "max"
                | FunctionBoostMode.Min -> "min"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "multiply" -> FunctionBoostMode.Multiply
            | "replace" -> FunctionBoostMode.Replace
            | "sum" -> FunctionBoostMode.Sum
            | "avg" -> FunctionBoostMode.Avg
            | "max" -> FunctionBoostMode.Max
            | "min" -> FunctionBoostMode.Min
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FunctionBoostMode"))

    type FunctionScoreContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<FunctionScoreContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | FunctionScoreContainer.Exp v ->
                writer.WritePropertyName("exp")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | FunctionScoreContainer.Gauss v ->
                writer.WritePropertyName("gauss")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | FunctionScoreContainer.Linear v ->
                writer.WritePropertyName("linear")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | FunctionScoreContainer.FieldValueFactor v ->
                writer.WritePropertyName("field_value_factor")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | FunctionScoreContainer.RandomScore v ->
                writer.WritePropertyName("random_score")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | FunctionScoreContainer.ScriptScore v ->
                writer.WritePropertyName("script_score")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for FunctionScoreContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for FunctionScoreContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "exp" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DecayFunction>(&reader, options)
                    FunctionScoreContainer.Exp v
                | "gauss" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DecayFunction>(&reader, options)
                    FunctionScoreContainer.Gauss v
                | "linear" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DecayFunction>(&reader, options)
                    FunctionScoreContainer.Linear v
                | "field_value_factor" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.FieldValueFactorScoreFunction>(&reader, options)
                    FunctionScoreContainer.FieldValueFactor v
                | "random_score" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RandomScoreFunction>(&reader, options)
                    FunctionScoreContainer.RandomScore v
                | "script_score" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ScriptScoreFunction>(&reader, options)
                    FunctionScoreContainer.ScriptScore v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for FunctionScoreContainer"))
            reader.Read() |> ignore // EndObject
            result

    type FunctionScoreModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<FunctionScoreMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | FunctionScoreMode.Multiply -> "multiply"
                | FunctionScoreMode.Sum -> "sum"
                | FunctionScoreMode.Avg -> "avg"
                | FunctionScoreMode.First -> "first"
                | FunctionScoreMode.Max -> "max"
                | FunctionScoreMode.Min -> "min"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "multiply" -> FunctionScoreMode.Multiply
            | "sum" -> FunctionScoreMode.Sum
            | "avg" -> FunctionScoreMode.Avg
            | "first" -> FunctionScoreMode.First
            | "max" -> FunctionScoreMode.Max
            | "min" -> FunctionScoreMode.Min
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FunctionScoreMode"))

    type GeoExecutionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GeoExecution>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GeoExecution.Memory -> "memory"
                | GeoExecution.Indexed -> "indexed"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "memory" -> GeoExecution.Memory
            | "indexed" -> GeoExecution.Indexed
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GeoExecution"))

    type GeoGridQueryConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GeoGridQuery>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | GeoGridQuery.Geotile v ->
                writer.WritePropertyName("geotile")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | GeoGridQuery.Geohash v ->
                writer.WritePropertyName("geohash")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | GeoGridQuery.Geohex v ->
                writer.WritePropertyName("geohex")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for GeoGridQuery"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for GeoGridQuery"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "geotile" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoTile>(&reader, options)
                    GeoGridQuery.Geotile v
                | "geohash" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoHash>(&reader, options)
                    GeoGridQuery.Geohash v
                | "geohex" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoHexCell>(&reader, options)
                    GeoGridQuery.Geohex v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for GeoGridQuery"))
            reader.Read() |> ignore // EndObject
            result

    type GeoValidationMethodConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GeoValidationMethod>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GeoValidationMethod.Coerce -> "coerce"
                | GeoValidationMethod.IgnoreMalformed -> "ignore_malformed"
                | GeoValidationMethod.Strict -> "strict"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "coerce" -> GeoValidationMethod.Coerce
            | "ignore_malformed" -> GeoValidationMethod.IgnoreMalformed
            | "strict" -> GeoValidationMethod.Strict
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GeoValidationMethod"))

    type IntervalsContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IntervalsContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | IntervalsContainer.AllOf v ->
                writer.WritePropertyName("all_of")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IntervalsContainer.AnyOf v ->
                writer.WritePropertyName("any_of")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IntervalsContainer.Fuzzy v ->
                writer.WritePropertyName("fuzzy")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IntervalsContainer.Match v ->
                writer.WritePropertyName("match")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IntervalsContainer.Prefix v ->
                writer.WritePropertyName("prefix")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IntervalsContainer.Range v ->
                writer.WritePropertyName("range")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IntervalsContainer.Regexp v ->
                writer.WritePropertyName("regexp")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IntervalsContainer.Wildcard v ->
                writer.WritePropertyName("wildcard")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for IntervalsContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for IntervalsContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "all_of" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsAllOf>(&reader, options)
                    IntervalsContainer.AllOf v
                | "any_of" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsAnyOf>(&reader, options)
                    IntervalsContainer.AnyOf v
                | "fuzzy" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsFuzzy>(&reader, options)
                    IntervalsContainer.Fuzzy v
                | "match" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsMatch>(&reader, options)
                    IntervalsContainer.Match v
                | "prefix" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsPrefix>(&reader, options)
                    IntervalsContainer.Prefix v
                | "range" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsRange>(&reader, options)
                    IntervalsContainer.Range v
                | "regexp" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsRegexp>(&reader, options)
                    IntervalsContainer.Regexp v
                | "wildcard" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsWildcard>(&reader, options)
                    IntervalsContainer.Wildcard v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for IntervalsContainer"))
            reader.Read() |> ignore // EndObject
            result

    type IntervalsFilterConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IntervalsFilter>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | IntervalsFilter.After v ->
                writer.WritePropertyName("after")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IntervalsFilter.Before v ->
                writer.WritePropertyName("before")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IntervalsFilter.ContainedBy v ->
                writer.WritePropertyName("contained_by")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IntervalsFilter.Containing v ->
                writer.WritePropertyName("containing")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IntervalsFilter.NotContainedBy v ->
                writer.WritePropertyName("not_contained_by")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IntervalsFilter.NotContaining v ->
                writer.WritePropertyName("not_containing")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IntervalsFilter.NotOverlapping v ->
                writer.WritePropertyName("not_overlapping")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IntervalsFilter.Overlapping v ->
                writer.WritePropertyName("overlapping")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IntervalsFilter.Script v ->
                writer.WritePropertyName("script")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for IntervalsFilter"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for IntervalsFilter"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "after" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsContainer>(&reader, options)
                    IntervalsFilter.After v
                | "before" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsContainer>(&reader, options)
                    IntervalsFilter.Before v
                | "contained_by" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsContainer>(&reader, options)
                    IntervalsFilter.ContainedBy v
                | "containing" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsContainer>(&reader, options)
                    IntervalsFilter.Containing v
                | "not_contained_by" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsContainer>(&reader, options)
                    IntervalsFilter.NotContainedBy v
                | "not_containing" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsContainer>(&reader, options)
                    IntervalsFilter.NotContaining v
                | "not_overlapping" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsContainer>(&reader, options)
                    IntervalsFilter.NotOverlapping v
                | "overlapping" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsContainer>(&reader, options)
                    IntervalsFilter.Overlapping v
                | "script" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.Script>(&reader, options)
                    IntervalsFilter.Script v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for IntervalsFilter"))
            reader.Read() |> ignore // EndObject
            result

    type IntervalsQueryConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IntervalsQuery>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | IntervalsQuery.AllOf v ->
                writer.WritePropertyName("all_of")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IntervalsQuery.AnyOf v ->
                writer.WritePropertyName("any_of")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IntervalsQuery.Fuzzy v ->
                writer.WritePropertyName("fuzzy")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IntervalsQuery.Match v ->
                writer.WritePropertyName("match")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IntervalsQuery.Prefix v ->
                writer.WritePropertyName("prefix")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IntervalsQuery.Range v ->
                writer.WritePropertyName("range")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IntervalsQuery.Regexp v ->
                writer.WritePropertyName("regexp")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IntervalsQuery.Wildcard v ->
                writer.WritePropertyName("wildcard")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for IntervalsQuery"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for IntervalsQuery"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "all_of" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsAllOf>(&reader, options)
                    IntervalsQuery.AllOf v
                | "any_of" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsAnyOf>(&reader, options)
                    IntervalsQuery.AnyOf v
                | "fuzzy" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsFuzzy>(&reader, options)
                    IntervalsQuery.Fuzzy v
                | "match" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsMatch>(&reader, options)
                    IntervalsQuery.Match v
                | "prefix" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsPrefix>(&reader, options)
                    IntervalsQuery.Prefix v
                | "range" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsRange>(&reader, options)
                    IntervalsQuery.Range v
                | "regexp" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsRegexp>(&reader, options)
                    IntervalsQuery.Regexp v
                | "wildcard" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsWildcard>(&reader, options)
                    IntervalsQuery.Wildcard v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for IntervalsQuery"))
            reader.Read() |> ignore // EndObject
            result

    type MultiValueModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MultiValueMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MultiValueMode.Min -> "min"
                | MultiValueMode.Max -> "max"
                | MultiValueMode.Avg -> "avg"
                | MultiValueMode.Sum -> "sum"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "min" -> MultiValueMode.Min
            | "max" -> MultiValueMode.Max
            | "avg" -> MultiValueMode.Avg
            | "sum" -> MultiValueMode.Sum
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for MultiValueMode"))

    type OperatorConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Operator>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Operator.And -> "and"
                | Operator.Or -> "or"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "and" -> Operator.And
            | "or" -> Operator.Or
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Operator"))

    type PinnedQueryConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<PinnedQuery>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | PinnedQuery.Ids v ->
                writer.WritePropertyName("ids")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | PinnedQuery.Docs v ->
                writer.WritePropertyName("docs")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for PinnedQuery"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for PinnedQuery"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "ids" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.Id list>(&reader, options)
                    PinnedQuery.Ids v
                | "docs" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.PinnedDoc list>(&reader, options)
                    PinnedQuery.Docs v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for PinnedQuery"))
            reader.Read() |> ignore // EndObject
            result

    type QueryContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<QueryContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | QueryContainer.Bool v ->
                writer.WritePropertyName("bool")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.Boosting v ->
                writer.WritePropertyName("boosting")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.Common (field, v) ->
                writer.WritePropertyName("common")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | QueryContainer.CombinedFields v ->
                writer.WritePropertyName("combined_fields")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.ConstantScore v ->
                writer.WritePropertyName("constant_score")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.DisMax v ->
                writer.WritePropertyName("dis_max")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.DistanceFeature v ->
                writer.WritePropertyName("distance_feature")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.Exists v ->
                writer.WritePropertyName("exists")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.FunctionScore v ->
                writer.WritePropertyName("function_score")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.Fuzzy (field, v) ->
                writer.WritePropertyName("fuzzy")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | QueryContainer.GeoBoundingBox v ->
                writer.WritePropertyName("geo_bounding_box")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.GeoDistance v ->
                writer.WritePropertyName("geo_distance")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.GeoGrid (field, v) ->
                writer.WritePropertyName("geo_grid")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | QueryContainer.GeoPolygon v ->
                writer.WritePropertyName("geo_polygon")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.GeoShape v ->
                writer.WritePropertyName("geo_shape")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.HasChild v ->
                writer.WritePropertyName("has_child")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.HasParent v ->
                writer.WritePropertyName("has_parent")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.Ids v ->
                writer.WritePropertyName("ids")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.Intervals (field, v) ->
                writer.WritePropertyName("intervals")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | QueryContainer.Knn v ->
                writer.WritePropertyName("knn")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.Match (field, v) ->
                writer.WritePropertyName("match")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | QueryContainer.MatchAll v ->
                writer.WritePropertyName("match_all")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.MatchBoolPrefix (field, v) ->
                writer.WritePropertyName("match_bool_prefix")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | QueryContainer.MatchNone v ->
                writer.WritePropertyName("match_none")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.MatchPhrase (field, v) ->
                writer.WritePropertyName("match_phrase")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | QueryContainer.MatchPhrasePrefix (field, v) ->
                writer.WritePropertyName("match_phrase_prefix")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | QueryContainer.MoreLikeThis v ->
                writer.WritePropertyName("more_like_this")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.MultiMatch v ->
                writer.WritePropertyName("multi_match")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.Nested v ->
                writer.WritePropertyName("nested")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.ParentId v ->
                writer.WritePropertyName("parent_id")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.Percolate v ->
                writer.WritePropertyName("percolate")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.Pinned v ->
                writer.WritePropertyName("pinned")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.Prefix (field, v) ->
                writer.WritePropertyName("prefix")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | QueryContainer.QueryString v ->
                writer.WritePropertyName("query_string")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.Range (field, v) ->
                writer.WritePropertyName("range")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | QueryContainer.RankFeature v ->
                writer.WritePropertyName("rank_feature")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.Regexp (field, v) ->
                writer.WritePropertyName("regexp")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | QueryContainer.Rule v ->
                writer.WritePropertyName("rule")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.Script v ->
                writer.WritePropertyName("script")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.ScriptScore v ->
                writer.WritePropertyName("script_score")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.Semantic v ->
                writer.WritePropertyName("semantic")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.Shape v ->
                writer.WritePropertyName("shape")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.SimpleQueryString v ->
                writer.WritePropertyName("simple_query_string")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.SpanContaining v ->
                writer.WritePropertyName("span_containing")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.SpanFieldMasking v ->
                writer.WritePropertyName("span_field_masking")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.SpanFirst v ->
                writer.WritePropertyName("span_first")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.SpanMulti v ->
                writer.WritePropertyName("span_multi")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.SpanNear v ->
                writer.WritePropertyName("span_near")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.SpanNot v ->
                writer.WritePropertyName("span_not")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.SpanOr v ->
                writer.WritePropertyName("span_or")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.SpanTerm (field, v) ->
                writer.WritePropertyName("span_term")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | QueryContainer.SpanWithin v ->
                writer.WritePropertyName("span_within")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.SparseVector v ->
                writer.WritePropertyName("sparse_vector")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.Term (field, v) ->
                writer.WritePropertyName("term")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | QueryContainer.Terms v ->
                writer.WritePropertyName("terms")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.TermsSet (field, v) ->
                writer.WritePropertyName("terms_set")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | QueryContainer.TextExpansion (field, v) ->
                writer.WritePropertyName("text_expansion")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | QueryContainer.WeightedTokens (field, v) ->
                writer.WritePropertyName("weighted_tokens")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | QueryContainer.Wildcard (field, v) ->
                writer.WritePropertyName("wildcard")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | QueryContainer.Wrapper v ->
                writer.WritePropertyName("wrapper")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.Type v ->
                writer.WritePropertyName("type")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | QueryContainer.Unknown (name, el) ->
                writer.WritePropertyName(name)
                el.WriteTo(writer)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for QueryContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for QueryContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "bool" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.BoolQuery>(&reader, options)
                    QueryContainer.Bool v
                | "boosting" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.BoostingQuery>(&reader, options)
                    QueryContainer.Boosting v
                | "common" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.CommonTermsQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    QueryContainer.Common (field, v)
                | "combined_fields" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.CombinedFieldsQuery>(&reader, options)
                    QueryContainer.CombinedFields v
                | "constant_score" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ConstantScoreQuery>(&reader, options)
                    QueryContainer.ConstantScore v
                | "dis_max" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DisMaxQuery>(&reader, options)
                    QueryContainer.DisMax v
                | "distance_feature" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DistanceFeatureQuery>(&reader, options)
                    QueryContainer.DistanceFeature v
                | "exists" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ExistsQuery>(&reader, options)
                    QueryContainer.Exists v
                | "function_score" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.FunctionScoreQuery>(&reader, options)
                    QueryContainer.FunctionScore v
                | "fuzzy" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.FuzzyQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    QueryContainer.Fuzzy (field, v)
                | "geo_bounding_box" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoBoundingBoxQuery>(&reader, options)
                    QueryContainer.GeoBoundingBox v
                | "geo_distance" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoDistanceQuery>(&reader, options)
                    QueryContainer.GeoDistance v
                | "geo_grid" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoGridQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    QueryContainer.GeoGrid (field, v)
                | "geo_polygon" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoPolygonQuery>(&reader, options)
                    QueryContainer.GeoPolygon v
                | "geo_shape" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoShapeQuery>(&reader, options)
                    QueryContainer.GeoShape v
                | "has_child" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.HasChildQuery>(&reader, options)
                    QueryContainer.HasChild v
                | "has_parent" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.HasParentQuery>(&reader, options)
                    QueryContainer.HasParent v
                | "ids" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IdsQuery>(&reader, options)
                    QueryContainer.Ids v
                | "intervals" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IntervalsQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    QueryContainer.Intervals (field, v)
                | "knn" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.KnnQuery>(&reader, options)
                    QueryContainer.Knn v
                | "match" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MatchQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    QueryContainer.Match (field, v)
                | "match_all" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MatchAllQuery>(&reader, options)
                    QueryContainer.MatchAll v
                | "match_bool_prefix" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MatchBoolPrefixQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    QueryContainer.MatchBoolPrefix (field, v)
                | "match_none" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MatchNoneQuery>(&reader, options)
                    QueryContainer.MatchNone v
                | "match_phrase" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MatchPhraseQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    QueryContainer.MatchPhrase (field, v)
                | "match_phrase_prefix" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MatchPhrasePrefixQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    QueryContainer.MatchPhrasePrefix (field, v)
                | "more_like_this" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MoreLikeThisQuery>(&reader, options)
                    QueryContainer.MoreLikeThis v
                | "multi_match" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MultiMatchQuery>(&reader, options)
                    QueryContainer.MultiMatch v
                | "nested" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.NestedQuery>(&reader, options)
                    QueryContainer.Nested v
                | "parent_id" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ParentIdQuery>(&reader, options)
                    QueryContainer.ParentId v
                | "percolate" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.PercolateQuery>(&reader, options)
                    QueryContainer.Percolate v
                | "pinned" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.PinnedQuery>(&reader, options)
                    QueryContainer.Pinned v
                | "prefix" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.PrefixQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    QueryContainer.Prefix (field, v)
                | "query_string" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.QueryStringQuery>(&reader, options)
                    QueryContainer.QueryString v
                | "range" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RangeQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    QueryContainer.Range (field, v)
                | "rank_feature" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RankFeatureQuery>(&reader, options)
                    QueryContainer.RankFeature v
                | "regexp" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RegexpQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    QueryContainer.Regexp (field, v)
                | "rule" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RuleQuery>(&reader, options)
                    QueryContainer.Rule v
                | "script" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ScriptQuery>(&reader, options)
                    QueryContainer.Script v
                | "script_score" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ScriptScoreQuery>(&reader, options)
                    QueryContainer.ScriptScore v
                | "semantic" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SemanticQuery>(&reader, options)
                    QueryContainer.Semantic v
                | "shape" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ShapeQuery>(&reader, options)
                    QueryContainer.Shape v
                | "simple_query_string" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SimpleQueryStringQuery>(&reader, options)
                    QueryContainer.SimpleQueryString v
                | "span_containing" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SpanContainingQuery>(&reader, options)
                    QueryContainer.SpanContaining v
                | "span_field_masking" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SpanFieldMaskingQuery>(&reader, options)
                    QueryContainer.SpanFieldMasking v
                | "span_first" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SpanFirstQuery>(&reader, options)
                    QueryContainer.SpanFirst v
                | "span_multi" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SpanMultiTermQuery>(&reader, options)
                    QueryContainer.SpanMulti v
                | "span_near" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SpanNearQuery>(&reader, options)
                    QueryContainer.SpanNear v
                | "span_not" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SpanNotQuery>(&reader, options)
                    QueryContainer.SpanNot v
                | "span_or" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SpanOrQuery>(&reader, options)
                    QueryContainer.SpanOr v
                | "span_term" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SpanTermQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    QueryContainer.SpanTerm (field, v)
                | "span_within" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SpanWithinQuery>(&reader, options)
                    QueryContainer.SpanWithin v
                | "sparse_vector" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SparseVectorQuery>(&reader, options)
                    QueryContainer.SparseVector v
                | "term" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TermQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    QueryContainer.Term (field, v)
                | "terms" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TermsQuery>(&reader, options)
                    QueryContainer.Terms v
                | "terms_set" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TermsSetQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    QueryContainer.TermsSet (field, v)
                | "text_expansion" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TextExpansionQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    QueryContainer.TextExpansion (field, v)
                | "weighted_tokens" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.WeightedTokensQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    QueryContainer.WeightedTokens (field, v)
                | "wildcard" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.WildcardQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    QueryContainer.Wildcard (field, v)
                | "wrapper" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.WrapperQuery>(&reader, options)
                    QueryContainer.Wrapper v
                | "type" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TypeQuery>(&reader, options)
                    QueryContainer.Type v
                | other ->
                    let el = System.Text.Json.JsonElement.ParseValue(&reader)
                    QueryContainer.Unknown (other, el)
            reader.Read() |> ignore // EndObject
            result

    type RangeRelationConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<RangeRelation>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | RangeRelation.Within -> "within"
                | RangeRelation.Contains -> "contains"
                | RangeRelation.Intersects -> "intersects"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "within" -> RangeRelation.Within
            | "contains" -> RangeRelation.Contains
            | "intersects" -> RangeRelation.Intersects
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for RangeRelation"))

    type SimpleQueryStringFlagConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SimpleQueryStringFlag>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SimpleQueryStringFlag.NONE -> "NONE"
                | SimpleQueryStringFlag.AND -> "AND"
                | SimpleQueryStringFlag.NOT -> "NOT"
                | SimpleQueryStringFlag.OR -> "OR"
                | SimpleQueryStringFlag.PREFIX -> "PREFIX"
                | SimpleQueryStringFlag.PHRASE -> "PHRASE"
                | SimpleQueryStringFlag.PRECEDENCE -> "PRECEDENCE"
                | SimpleQueryStringFlag.ESCAPE -> "ESCAPE"
                | SimpleQueryStringFlag.WHITESPACE -> "WHITESPACE"
                | SimpleQueryStringFlag.FUZZY -> "FUZZY"
                | SimpleQueryStringFlag.NEAR -> "NEAR"
                | SimpleQueryStringFlag.SLOP -> "SLOP"
                | SimpleQueryStringFlag.ALL -> "ALL"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "NONE" -> SimpleQueryStringFlag.NONE
            | "AND" -> SimpleQueryStringFlag.AND
            | "NOT" -> SimpleQueryStringFlag.NOT
            | "OR" -> SimpleQueryStringFlag.OR
            | "PREFIX" -> SimpleQueryStringFlag.PREFIX
            | "PHRASE" -> SimpleQueryStringFlag.PHRASE
            | "PRECEDENCE" -> SimpleQueryStringFlag.PRECEDENCE
            | "ESCAPE" -> SimpleQueryStringFlag.ESCAPE
            | "WHITESPACE" -> SimpleQueryStringFlag.WHITESPACE
            | "FUZZY" -> SimpleQueryStringFlag.FUZZY
            | "NEAR" -> SimpleQueryStringFlag.NEAR
            | "SLOP" -> SimpleQueryStringFlag.SLOP
            | "ALL" -> SimpleQueryStringFlag.ALL
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SimpleQueryStringFlag"))

    type SpanQueryConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SpanQuery>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | SpanQuery.SpanContaining v ->
                writer.WritePropertyName("span_containing")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SpanQuery.SpanFieldMasking v ->
                writer.WritePropertyName("span_field_masking")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SpanQuery.SpanFirst v ->
                writer.WritePropertyName("span_first")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SpanQuery.SpanGap v ->
                writer.WritePropertyName("span_gap")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SpanQuery.SpanMulti v ->
                writer.WritePropertyName("span_multi")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SpanQuery.SpanNear v ->
                writer.WritePropertyName("span_near")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SpanQuery.SpanNot v ->
                writer.WritePropertyName("span_not")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SpanQuery.SpanOr v ->
                writer.WritePropertyName("span_or")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SpanQuery.SpanTerm (field, v) ->
                writer.WritePropertyName("span_term")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | SpanQuery.SpanWithin v ->
                writer.WritePropertyName("span_within")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SpanQuery.Unknown (name, el) ->
                writer.WritePropertyName(name)
                el.WriteTo(writer)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for SpanQuery"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for SpanQuery"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "span_containing" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SpanContainingQuery>(&reader, options)
                    SpanQuery.SpanContaining v
                | "span_field_masking" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SpanFieldMaskingQuery>(&reader, options)
                    SpanQuery.SpanFieldMasking v
                | "span_first" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SpanFirstQuery>(&reader, options)
                    SpanQuery.SpanFirst v
                | "span_gap" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SpanGapQuery>(&reader, options)
                    SpanQuery.SpanGap v
                | "span_multi" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SpanMultiTermQuery>(&reader, options)
                    SpanQuery.SpanMulti v
                | "span_near" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SpanNearQuery>(&reader, options)
                    SpanQuery.SpanNear v
                | "span_not" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SpanNotQuery>(&reader, options)
                    SpanQuery.SpanNot v
                | "span_or" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SpanOrQuery>(&reader, options)
                    SpanQuery.SpanOr v
                | "span_term" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SpanTermQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    SpanQuery.SpanTerm (field, v)
                | "span_within" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SpanWithinQuery>(&reader, options)
                    SpanQuery.SpanWithin v
                | other ->
                    let el = System.Text.Json.JsonElement.ParseValue(&reader)
                    SpanQuery.Unknown (other, el)
            reader.Read() |> ignore // EndObject
            result

    type SparseVectorQueryConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SparseVectorQuery>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | SparseVectorQuery.QueryVector v ->
                writer.WritePropertyName("query_vector")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SparseVectorQuery.InferenceId v ->
                writer.WritePropertyName("inference_id")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for SparseVectorQuery"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for SparseVectorQuery"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "query_vector" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Map<string, Types.Float>>(&reader, options)
                    SparseVectorQuery.QueryVector v
                | "inference_id" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.Id>(&reader, options)
                    SparseVectorQuery.InferenceId v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for SparseVectorQuery"))
            reader.Read() |> ignore // EndObject
            result

    type TextQueryTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TextQueryType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TextQueryType.BestFields -> "best_fields"
                | TextQueryType.MostFields -> "most_fields"
                | TextQueryType.CrossFields -> "cross_fields"
                | TextQueryType.Phrase -> "phrase"
                | TextQueryType.PhrasePrefix -> "phrase_prefix"
                | TextQueryType.BoolPrefix -> "bool_prefix"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "best_fields" -> TextQueryType.BestFields
            | "most_fields" -> TextQueryType.MostFields
            | "cross_fields" -> TextQueryType.CrossFields
            | "phrase" -> TextQueryType.Phrase
            | "phrase_prefix" -> TextQueryType.PhrasePrefix
            | "bool_prefix" -> TextQueryType.BoolPrefix
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TextQueryType"))

    type ZeroTermsQueryConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ZeroTermsQuery>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ZeroTermsQuery.All -> "all"
                | ZeroTermsQuery.None -> "none"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "all" -> ZeroTermsQuery.All
            | "none" -> ZeroTermsQuery.None
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ZeroTermsQuery"))

    type CatAliasesColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatAliasesColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatAliasesColumn.Alias -> "alias"
                | CatAliasesColumn.Index -> "index"
                | CatAliasesColumn.Filter -> "filter"
                | CatAliasesColumn.RoutingIndex -> "routing.index"
                | CatAliasesColumn.RoutingSearch -> "routing.search"
                | CatAliasesColumn.IsWriteIndex -> "is_write_index"
                | CatAliasesColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "alias" -> CatAliasesColumn.Alias
            | "index" -> CatAliasesColumn.Index
            | "filter" -> CatAliasesColumn.Filter
            | "routing.index" -> CatAliasesColumn.RoutingIndex
            | "routing.search" -> CatAliasesColumn.RoutingSearch
            | "is_write_index" -> CatAliasesColumn.IsWriteIndex
            | other -> CatAliasesColumn.Custom other

    type CatAllocationColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatAllocationColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatAllocationColumn.Shards -> "shards"
                | CatAllocationColumn.ShardsUndesired -> "shards.undesired"
                | CatAllocationColumn.WriteLoadForecast -> "write_load.forecast"
                | CatAllocationColumn.DiskIndicesForecast -> "disk.indices.forecast"
                | CatAllocationColumn.DiskIndices -> "disk.indices"
                | CatAllocationColumn.DiskUsed -> "disk.used"
                | CatAllocationColumn.DiskAvail -> "disk.avail"
                | CatAllocationColumn.DiskTotal -> "disk.total"
                | CatAllocationColumn.DiskPercent -> "disk.percent"
                | CatAllocationColumn.Host -> "host"
                | CatAllocationColumn.Ip -> "ip"
                | CatAllocationColumn.Node -> "node"
                | CatAllocationColumn.NodeRole -> "node.role"
                | CatAllocationColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "shards" -> CatAllocationColumn.Shards
            | "shards.undesired" -> CatAllocationColumn.ShardsUndesired
            | "write_load.forecast" -> CatAllocationColumn.WriteLoadForecast
            | "disk.indices.forecast" -> CatAllocationColumn.DiskIndicesForecast
            | "disk.indices" -> CatAllocationColumn.DiskIndices
            | "disk.used" -> CatAllocationColumn.DiskUsed
            | "disk.avail" -> CatAllocationColumn.DiskAvail
            | "disk.total" -> CatAllocationColumn.DiskTotal
            | "disk.percent" -> CatAllocationColumn.DiskPercent
            | "host" -> CatAllocationColumn.Host
            | "ip" -> CatAllocationColumn.Ip
            | "node" -> CatAllocationColumn.Node
            | "node.role" -> CatAllocationColumn.NodeRole
            | other -> CatAllocationColumn.Custom other

    type CatAnomalyDetectorColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatAnomalyDetectorColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatAnomalyDetectorColumn.AssignmentExplanation -> "assignment_explanation"
                | CatAnomalyDetectorColumn.BucketsCount -> "buckets.count"
                | CatAnomalyDetectorColumn.BucketsTimeExpAvg -> "buckets.time.exp_avg"
                | CatAnomalyDetectorColumn.BucketsTimeExpAvgHour -> "buckets.time.exp_avg_hour"
                | CatAnomalyDetectorColumn.BucketsTimeMax -> "buckets.time.max"
                | CatAnomalyDetectorColumn.BucketsTimeMin -> "buckets.time.min"
                | CatAnomalyDetectorColumn.BucketsTimeTotal -> "buckets.time.total"
                | CatAnomalyDetectorColumn.DataBuckets -> "data.buckets"
                | CatAnomalyDetectorColumn.DataEarliestRecord -> "data.earliest_record"
                | CatAnomalyDetectorColumn.DataEmptyBuckets -> "data.empty_buckets"
                | CatAnomalyDetectorColumn.DataInputBytes -> "data.input_bytes"
                | CatAnomalyDetectorColumn.DataInputFields -> "data.input_fields"
                | CatAnomalyDetectorColumn.DataInputRecords -> "data.input_records"
                | CatAnomalyDetectorColumn.DataInvalidDates -> "data.invalid_dates"
                | CatAnomalyDetectorColumn.DataLast -> "data.last"
                | CatAnomalyDetectorColumn.DataLastEmptyBucket -> "data.last_empty_bucket"
                | CatAnomalyDetectorColumn.DataLastSparseBucket -> "data.last_sparse_bucket"
                | CatAnomalyDetectorColumn.DataLatestRecord -> "data.latest_record"
                | CatAnomalyDetectorColumn.DataMissingFields -> "data.missing_fields"
                | CatAnomalyDetectorColumn.DataOutOfOrderTimestamps -> "data.out_of_order_timestamps"
                | CatAnomalyDetectorColumn.DataProcessedFields -> "data.processed_fields"
                | CatAnomalyDetectorColumn.DataProcessedRecords -> "data.processed_records"
                | CatAnomalyDetectorColumn.DataSparseBuckets -> "data.sparse_buckets"
                | CatAnomalyDetectorColumn.ForecastsMemoryAvg -> "forecasts.memory.avg"
                | CatAnomalyDetectorColumn.ForecastsMemoryMax -> "forecasts.memory.max"
                | CatAnomalyDetectorColumn.ForecastsMemoryMin -> "forecasts.memory.min"
                | CatAnomalyDetectorColumn.ForecastsMemoryTotal -> "forecasts.memory.total"
                | CatAnomalyDetectorColumn.ForecastsRecordsAvg -> "forecasts.records.avg"
                | CatAnomalyDetectorColumn.ForecastsRecordsMax -> "forecasts.records.max"
                | CatAnomalyDetectorColumn.ForecastsRecordsMin -> "forecasts.records.min"
                | CatAnomalyDetectorColumn.ForecastsRecordsTotal -> "forecasts.records.total"
                | CatAnomalyDetectorColumn.ForecastsTimeAvg -> "forecasts.time.avg"
                | CatAnomalyDetectorColumn.ForecastsTimeMax -> "forecasts.time.max"
                | CatAnomalyDetectorColumn.ForecastsTimeMin -> "forecasts.time.min"
                | CatAnomalyDetectorColumn.ForecastsTimeTotal -> "forecasts.time.total"
                | CatAnomalyDetectorColumn.ForecastsTotal -> "forecasts.total"
                | CatAnomalyDetectorColumn.Id -> "id"
                | CatAnomalyDetectorColumn.ModelBucketAllocationFailures -> "model.bucket_allocation_failures"
                | CatAnomalyDetectorColumn.ModelByFields -> "model.by_fields"
                | CatAnomalyDetectorColumn.ModelBytes -> "model.bytes"
                | CatAnomalyDetectorColumn.ModelBytesExceeded -> "model.bytes_exceeded"
                | CatAnomalyDetectorColumn.ModelCategorizationStatus -> "model.categorization_status"
                | CatAnomalyDetectorColumn.ModelCategorizedDocCount -> "model.categorized_doc_count"
                | CatAnomalyDetectorColumn.ModelDeadCategoryCount -> "model.dead_category_count"
                | CatAnomalyDetectorColumn.ModelFailedCategoryCount -> "model.failed_category_count"
                | CatAnomalyDetectorColumn.ModelFrequentCategoryCount -> "model.frequent_category_count"
                | CatAnomalyDetectorColumn.ModelLogTime -> "model.log_time"
                | CatAnomalyDetectorColumn.ModelMemoryLimit -> "model.memory_limit"
                | CatAnomalyDetectorColumn.ModelMemoryStatus -> "model.memory_status"
                | CatAnomalyDetectorColumn.ModelOverFields -> "model.over_fields"
                | CatAnomalyDetectorColumn.ModelPartitionFields -> "model.partition_fields"
                | CatAnomalyDetectorColumn.ModelRareCategoryCount -> "model.rare_category_count"
                | CatAnomalyDetectorColumn.ModelTimestamp -> "model.timestamp"
                | CatAnomalyDetectorColumn.ModelTotalCategoryCount -> "model.total_category_count"
                | CatAnomalyDetectorColumn.NodeAddress -> "node.address"
                | CatAnomalyDetectorColumn.NodeEphemeralId -> "node.ephemeral_id"
                | CatAnomalyDetectorColumn.NodeId -> "node.id"
                | CatAnomalyDetectorColumn.NodeName -> "node.name"
                | CatAnomalyDetectorColumn.OpenedTime -> "opened_time"
                | CatAnomalyDetectorColumn.State -> "state"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "assignment_explanation" -> CatAnomalyDetectorColumn.AssignmentExplanation
            | "buckets.count" -> CatAnomalyDetectorColumn.BucketsCount
            | "buckets.time.exp_avg" -> CatAnomalyDetectorColumn.BucketsTimeExpAvg
            | "buckets.time.exp_avg_hour" -> CatAnomalyDetectorColumn.BucketsTimeExpAvgHour
            | "buckets.time.max" -> CatAnomalyDetectorColumn.BucketsTimeMax
            | "buckets.time.min" -> CatAnomalyDetectorColumn.BucketsTimeMin
            | "buckets.time.total" -> CatAnomalyDetectorColumn.BucketsTimeTotal
            | "data.buckets" -> CatAnomalyDetectorColumn.DataBuckets
            | "data.earliest_record" -> CatAnomalyDetectorColumn.DataEarliestRecord
            | "data.empty_buckets" -> CatAnomalyDetectorColumn.DataEmptyBuckets
            | "data.input_bytes" -> CatAnomalyDetectorColumn.DataInputBytes
            | "data.input_fields" -> CatAnomalyDetectorColumn.DataInputFields
            | "data.input_records" -> CatAnomalyDetectorColumn.DataInputRecords
            | "data.invalid_dates" -> CatAnomalyDetectorColumn.DataInvalidDates
            | "data.last" -> CatAnomalyDetectorColumn.DataLast
            | "data.last_empty_bucket" -> CatAnomalyDetectorColumn.DataLastEmptyBucket
            | "data.last_sparse_bucket" -> CatAnomalyDetectorColumn.DataLastSparseBucket
            | "data.latest_record" -> CatAnomalyDetectorColumn.DataLatestRecord
            | "data.missing_fields" -> CatAnomalyDetectorColumn.DataMissingFields
            | "data.out_of_order_timestamps" -> CatAnomalyDetectorColumn.DataOutOfOrderTimestamps
            | "data.processed_fields" -> CatAnomalyDetectorColumn.DataProcessedFields
            | "data.processed_records" -> CatAnomalyDetectorColumn.DataProcessedRecords
            | "data.sparse_buckets" -> CatAnomalyDetectorColumn.DataSparseBuckets
            | "forecasts.memory.avg" -> CatAnomalyDetectorColumn.ForecastsMemoryAvg
            | "forecasts.memory.max" -> CatAnomalyDetectorColumn.ForecastsMemoryMax
            | "forecasts.memory.min" -> CatAnomalyDetectorColumn.ForecastsMemoryMin
            | "forecasts.memory.total" -> CatAnomalyDetectorColumn.ForecastsMemoryTotal
            | "forecasts.records.avg" -> CatAnomalyDetectorColumn.ForecastsRecordsAvg
            | "forecasts.records.max" -> CatAnomalyDetectorColumn.ForecastsRecordsMax
            | "forecasts.records.min" -> CatAnomalyDetectorColumn.ForecastsRecordsMin
            | "forecasts.records.total" -> CatAnomalyDetectorColumn.ForecastsRecordsTotal
            | "forecasts.time.avg" -> CatAnomalyDetectorColumn.ForecastsTimeAvg
            | "forecasts.time.max" -> CatAnomalyDetectorColumn.ForecastsTimeMax
            | "forecasts.time.min" -> CatAnomalyDetectorColumn.ForecastsTimeMin
            | "forecasts.time.total" -> CatAnomalyDetectorColumn.ForecastsTimeTotal
            | "forecasts.total" -> CatAnomalyDetectorColumn.ForecastsTotal
            | "id" -> CatAnomalyDetectorColumn.Id
            | "model.bucket_allocation_failures" -> CatAnomalyDetectorColumn.ModelBucketAllocationFailures
            | "model.by_fields" -> CatAnomalyDetectorColumn.ModelByFields
            | "model.bytes" -> CatAnomalyDetectorColumn.ModelBytes
            | "model.bytes_exceeded" -> CatAnomalyDetectorColumn.ModelBytesExceeded
            | "model.categorization_status" -> CatAnomalyDetectorColumn.ModelCategorizationStatus
            | "model.categorized_doc_count" -> CatAnomalyDetectorColumn.ModelCategorizedDocCount
            | "model.dead_category_count" -> CatAnomalyDetectorColumn.ModelDeadCategoryCount
            | "model.failed_category_count" -> CatAnomalyDetectorColumn.ModelFailedCategoryCount
            | "model.frequent_category_count" -> CatAnomalyDetectorColumn.ModelFrequentCategoryCount
            | "model.log_time" -> CatAnomalyDetectorColumn.ModelLogTime
            | "model.memory_limit" -> CatAnomalyDetectorColumn.ModelMemoryLimit
            | "model.memory_status" -> CatAnomalyDetectorColumn.ModelMemoryStatus
            | "model.over_fields" -> CatAnomalyDetectorColumn.ModelOverFields
            | "model.partition_fields" -> CatAnomalyDetectorColumn.ModelPartitionFields
            | "model.rare_category_count" -> CatAnomalyDetectorColumn.ModelRareCategoryCount
            | "model.timestamp" -> CatAnomalyDetectorColumn.ModelTimestamp
            | "model.total_category_count" -> CatAnomalyDetectorColumn.ModelTotalCategoryCount
            | "node.address" -> CatAnomalyDetectorColumn.NodeAddress
            | "node.ephemeral_id" -> CatAnomalyDetectorColumn.NodeEphemeralId
            | "node.id" -> CatAnomalyDetectorColumn.NodeId
            | "node.name" -> CatAnomalyDetectorColumn.NodeName
            | "opened_time" -> CatAnomalyDetectorColumn.OpenedTime
            | "state" -> CatAnomalyDetectorColumn.State
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CatAnomalyDetectorColumn"))

    type CatCircuitBreakerColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatCircuitBreakerColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatCircuitBreakerColumn.NodeId -> "node_id"
                | CatCircuitBreakerColumn.NodeName -> "node_name"
                | CatCircuitBreakerColumn.Breaker -> "breaker"
                | CatCircuitBreakerColumn.Limit -> "limit"
                | CatCircuitBreakerColumn.LimitBytes -> "limit_bytes"
                | CatCircuitBreakerColumn.Estimated -> "estimated"
                | CatCircuitBreakerColumn.EstimatedBytes -> "estimated_bytes"
                | CatCircuitBreakerColumn.Tripped -> "tripped"
                | CatCircuitBreakerColumn.Overhead -> "overhead"
                | CatCircuitBreakerColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "node_id" -> CatCircuitBreakerColumn.NodeId
            | "node_name" -> CatCircuitBreakerColumn.NodeName
            | "breaker" -> CatCircuitBreakerColumn.Breaker
            | "limit" -> CatCircuitBreakerColumn.Limit
            | "limit_bytes" -> CatCircuitBreakerColumn.LimitBytes
            | "estimated" -> CatCircuitBreakerColumn.Estimated
            | "estimated_bytes" -> CatCircuitBreakerColumn.EstimatedBytes
            | "tripped" -> CatCircuitBreakerColumn.Tripped
            | "overhead" -> CatCircuitBreakerColumn.Overhead
            | other -> CatCircuitBreakerColumn.Custom other

    type CatComponentColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatComponentColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatComponentColumn.Name -> "name"
                | CatComponentColumn.Version -> "version"
                | CatComponentColumn.AliasCount -> "alias_count"
                | CatComponentColumn.MappingCount -> "mapping_count"
                | CatComponentColumn.SettingsCount -> "settings_count"
                | CatComponentColumn.MetadataCount -> "metadata_count"
                | CatComponentColumn.IncludedIn -> "included_in"
                | CatComponentColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "name" -> CatComponentColumn.Name
            | "version" -> CatComponentColumn.Version
            | "alias_count" -> CatComponentColumn.AliasCount
            | "mapping_count" -> CatComponentColumn.MappingCount
            | "settings_count" -> CatComponentColumn.SettingsCount
            | "metadata_count" -> CatComponentColumn.MetadataCount
            | "included_in" -> CatComponentColumn.IncludedIn
            | other -> CatComponentColumn.Custom other

    type CatCountColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatCountColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatCountColumn.Epoch -> "epoch"
                | CatCountColumn.Timestamp -> "timestamp"
                | CatCountColumn.Count -> "count"
                | CatCountColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "epoch" -> CatCountColumn.Epoch
            | "timestamp" -> CatCountColumn.Timestamp
            | "count" -> CatCountColumn.Count
            | other -> CatCountColumn.Custom other

    type CatDatafeedColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatDatafeedColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatDatafeedColumn.Ae -> "ae"
                | CatDatafeedColumn.Bc -> "bc"
                | CatDatafeedColumn.Id -> "id"
                | CatDatafeedColumn.Na -> "na"
                | CatDatafeedColumn.Ne -> "ne"
                | CatDatafeedColumn.Ni -> "ni"
                | CatDatafeedColumn.Nn -> "nn"
                | CatDatafeedColumn.Sba -> "sba"
                | CatDatafeedColumn.Sc -> "sc"
                | CatDatafeedColumn.Seah -> "seah"
                | CatDatafeedColumn.St -> "st"
                | CatDatafeedColumn.S -> "s"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "ae" -> CatDatafeedColumn.Ae
            | "bc" -> CatDatafeedColumn.Bc
            | "id" -> CatDatafeedColumn.Id
            | "na" -> CatDatafeedColumn.Na
            | "ne" -> CatDatafeedColumn.Ne
            | "ni" -> CatDatafeedColumn.Ni
            | "nn" -> CatDatafeedColumn.Nn
            | "sba" -> CatDatafeedColumn.Sba
            | "sc" -> CatDatafeedColumn.Sc
            | "seah" -> CatDatafeedColumn.Seah
            | "st" -> CatDatafeedColumn.St
            | "s" -> CatDatafeedColumn.S
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CatDatafeedColumn"))

    type CatDfaColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatDfaColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatDfaColumn.AssignmentExplanation -> "assignment_explanation"
                | CatDfaColumn.CreateTime -> "create_time"
                | CatDfaColumn.Description -> "description"
                | CatDfaColumn.DestIndex -> "dest_index"
                | CatDfaColumn.FailureReason -> "failure_reason"
                | CatDfaColumn.Id -> "id"
                | CatDfaColumn.ModelMemoryLimit -> "model_memory_limit"
                | CatDfaColumn.NodeAddress -> "node.address"
                | CatDfaColumn.NodeEphemeralId -> "node.ephemeral_id"
                | CatDfaColumn.NodeId -> "node.id"
                | CatDfaColumn.NodeName -> "node.name"
                | CatDfaColumn.Progress -> "progress"
                | CatDfaColumn.SourceIndex -> "source_index"
                | CatDfaColumn.State -> "state"
                | CatDfaColumn.Type -> "type"
                | CatDfaColumn.Version -> "version"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "assignment_explanation" -> CatDfaColumn.AssignmentExplanation
            | "create_time" -> CatDfaColumn.CreateTime
            | "description" -> CatDfaColumn.Description
            | "dest_index" -> CatDfaColumn.DestIndex
            | "failure_reason" -> CatDfaColumn.FailureReason
            | "id" -> CatDfaColumn.Id
            | "model_memory_limit" -> CatDfaColumn.ModelMemoryLimit
            | "node.address" -> CatDfaColumn.NodeAddress
            | "node.ephemeral_id" -> CatDfaColumn.NodeEphemeralId
            | "node.id" -> CatDfaColumn.NodeId
            | "node.name" -> CatDfaColumn.NodeName
            | "progress" -> CatDfaColumn.Progress
            | "source_index" -> CatDfaColumn.SourceIndex
            | "state" -> CatDfaColumn.State
            | "type" -> CatDfaColumn.Type
            | "version" -> CatDfaColumn.Version
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CatDfaColumn"))

    type CatFieldDataColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatFieldDataColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatFieldDataColumn.Id -> "id"
                | CatFieldDataColumn.Host -> "host"
                | CatFieldDataColumn.Ip -> "ip"
                | CatFieldDataColumn.Node -> "node"
                | CatFieldDataColumn.Field -> "field"
                | CatFieldDataColumn.Size -> "size"
                | CatFieldDataColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "id" -> CatFieldDataColumn.Id
            | "host" -> CatFieldDataColumn.Host
            | "ip" -> CatFieldDataColumn.Ip
            | "node" -> CatFieldDataColumn.Node
            | "field" -> CatFieldDataColumn.Field
            | "size" -> CatFieldDataColumn.Size
            | other -> CatFieldDataColumn.Custom other

    type CatHealthColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatHealthColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatHealthColumn.Epoch -> "epoch"
                | CatHealthColumn.Timestamp -> "timestamp"
                | CatHealthColumn.Cluster -> "cluster"
                | CatHealthColumn.Status -> "status"
                | CatHealthColumn.NodeTotal -> "node.total"
                | CatHealthColumn.NodeData -> "node.data"
                | CatHealthColumn.Shards -> "shards"
                | CatHealthColumn.Pri -> "pri"
                | CatHealthColumn.Relo -> "relo"
                | CatHealthColumn.Init -> "init"
                | CatHealthColumn.Unassign -> "unassign"
                | CatHealthColumn.UnassignPri -> "unassign.pri"
                | CatHealthColumn.PendingTasks -> "pending_tasks"
                | CatHealthColumn.MaxTaskWaitTime -> "max_task_wait_time"
                | CatHealthColumn.ActiveShardsPercent -> "active_shards_percent"
                | CatHealthColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "epoch" -> CatHealthColumn.Epoch
            | "timestamp" -> CatHealthColumn.Timestamp
            | "cluster" -> CatHealthColumn.Cluster
            | "status" -> CatHealthColumn.Status
            | "node.total" -> CatHealthColumn.NodeTotal
            | "node.data" -> CatHealthColumn.NodeData
            | "shards" -> CatHealthColumn.Shards
            | "pri" -> CatHealthColumn.Pri
            | "relo" -> CatHealthColumn.Relo
            | "init" -> CatHealthColumn.Init
            | "unassign" -> CatHealthColumn.Unassign
            | "unassign.pri" -> CatHealthColumn.UnassignPri
            | "pending_tasks" -> CatHealthColumn.PendingTasks
            | "max_task_wait_time" -> CatHealthColumn.MaxTaskWaitTime
            | "active_shards_percent" -> CatHealthColumn.ActiveShardsPercent
            | other -> CatHealthColumn.Custom other

    type CatIndicesColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatIndicesColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatIndicesColumn.Health -> "health"
                | CatIndicesColumn.Status -> "status"
                | CatIndicesColumn.Index -> "index"
                | CatIndicesColumn.Uuid -> "uuid"
                | CatIndicesColumn.Pri -> "pri"
                | CatIndicesColumn.Rep -> "rep"
                | CatIndicesColumn.DocsCount -> "docs.count"
                | CatIndicesColumn.DocsDeleted -> "docs.deleted"
                | CatIndicesColumn.CreationDate -> "creation.date"
                | CatIndicesColumn.CreationDateString -> "creation.date.string"
                | CatIndicesColumn.StoreSize -> "store.size"
                | CatIndicesColumn.PriStoreSize -> "pri.store.size"
                | CatIndicesColumn.DatasetSize -> "dataset.size"
                | CatIndicesColumn.CompletionSize -> "completion.size"
                | CatIndicesColumn.PriCompletionSize -> "pri.completion.size"
                | CatIndicesColumn.FielddataMemorySize -> "fielddata.memory_size"
                | CatIndicesColumn.PriFielddataMemorySize -> "pri.fielddata.memory_size"
                | CatIndicesColumn.FielddataEvictions -> "fielddata.evictions"
                | CatIndicesColumn.PriFielddataEvictions -> "pri.fielddata.evictions"
                | CatIndicesColumn.QueryCacheMemorySize -> "query_cache.memory_size"
                | CatIndicesColumn.PriQueryCacheMemorySize -> "pri.query_cache.memory_size"
                | CatIndicesColumn.QueryCacheEvictions -> "query_cache.evictions"
                | CatIndicesColumn.PriQueryCacheEvictions -> "pri.query_cache.evictions"
                | CatIndicesColumn.RequestCacheMemorySize -> "request_cache.memory_size"
                | CatIndicesColumn.PriRequestCacheMemorySize -> "pri.request_cache.memory_size"
                | CatIndicesColumn.RequestCacheEvictions -> "request_cache.evictions"
                | CatIndicesColumn.PriRequestCacheEvictions -> "pri.request_cache.evictions"
                | CatIndicesColumn.RequestCacheHitCount -> "request_cache.hit_count"
                | CatIndicesColumn.PriRequestCacheHitCount -> "pri.request_cache.hit_count"
                | CatIndicesColumn.RequestCacheMissCount -> "request_cache.miss_count"
                | CatIndicesColumn.PriRequestCacheMissCount -> "pri.request_cache.miss_count"
                | CatIndicesColumn.FlushTotal -> "flush.total"
                | CatIndicesColumn.PriFlushTotal -> "pri.flush.total"
                | CatIndicesColumn.FlushTotalTime -> "flush.total_time"
                | CatIndicesColumn.PriFlushTotalTime -> "pri.flush.total_time"
                | CatIndicesColumn.GetCurrent -> "get.current"
                | CatIndicesColumn.PriGetCurrent -> "pri.get.current"
                | CatIndicesColumn.GetTime -> "get.time"
                | CatIndicesColumn.PriGetTime -> "pri.get.time"
                | CatIndicesColumn.GetTotal -> "get.total"
                | CatIndicesColumn.PriGetTotal -> "pri.get.total"
                | CatIndicesColumn.GetExistsTime -> "get.exists_time"
                | CatIndicesColumn.PriGetExistsTime -> "pri.get.exists_time"
                | CatIndicesColumn.GetExistsTotal -> "get.exists_total"
                | CatIndicesColumn.PriGetExistsTotal -> "pri.get.exists_total"
                | CatIndicesColumn.GetMissingTime -> "get.missing_time"
                | CatIndicesColumn.PriGetMissingTime -> "pri.get.missing_time"
                | CatIndicesColumn.GetMissingTotal -> "get.missing_total"
                | CatIndicesColumn.PriGetMissingTotal -> "pri.get.missing_total"
                | CatIndicesColumn.IndexingDeleteCurrent -> "indexing.delete_current"
                | CatIndicesColumn.PriIndexingDeleteCurrent -> "pri.indexing.delete_current"
                | CatIndicesColumn.IndexingDeleteTime -> "indexing.delete_time"
                | CatIndicesColumn.PriIndexingDeleteTime -> "pri.indexing.delete_time"
                | CatIndicesColumn.IndexingDeleteTotal -> "indexing.delete_total"
                | CatIndicesColumn.PriIndexingDeleteTotal -> "pri.indexing.delete_total"
                | CatIndicesColumn.IndexingIndexCurrent -> "indexing.index_current"
                | CatIndicesColumn.PriIndexingIndexCurrent -> "pri.indexing.index_current"
                | CatIndicesColumn.IndexingIndexTime -> "indexing.index_time"
                | CatIndicesColumn.PriIndexingIndexTime -> "pri.indexing.index_time"
                | CatIndicesColumn.IndexingIndexTotal -> "indexing.index_total"
                | CatIndicesColumn.PriIndexingIndexTotal -> "pri.indexing.index_total"
                | CatIndicesColumn.IndexingIndexFailed -> "indexing.index_failed"
                | CatIndicesColumn.PriIndexingIndexFailed -> "pri.indexing.index_failed"
                | CatIndicesColumn.IndexingIndexFailedDueToVersionConflict -> "indexing.index_failed_due_to_version_conflict"
                | CatIndicesColumn.PriIndexingIndexFailedDueToVersionConflict -> "pri.indexing.index_failed_due_to_version_conflict"
                | CatIndicesColumn.MergesCurrent -> "merges.current"
                | CatIndicesColumn.PriMergesCurrent -> "pri.merges.current"
                | CatIndicesColumn.MergesCurrentDocs -> "merges.current_docs"
                | CatIndicesColumn.PriMergesCurrentDocs -> "pri.merges.current_docs"
                | CatIndicesColumn.MergesCurrentSize -> "merges.current_size"
                | CatIndicesColumn.PriMergesCurrentSize -> "pri.merges.current_size"
                | CatIndicesColumn.MergesTotal -> "merges.total"
                | CatIndicesColumn.PriMergesTotal -> "pri.merges.total"
                | CatIndicesColumn.MergesTotalDocs -> "merges.total_docs"
                | CatIndicesColumn.PriMergesTotalDocs -> "pri.merges.total_docs"
                | CatIndicesColumn.MergesTotalSize -> "merges.total_size"
                | CatIndicesColumn.PriMergesTotalSize -> "pri.merges.total_size"
                | CatIndicesColumn.MergesTotalTime -> "merges.total_time"
                | CatIndicesColumn.PriMergesTotalTime -> "pri.merges.total_time"
                | CatIndicesColumn.RefreshTotal -> "refresh.total"
                | CatIndicesColumn.PriRefreshTotal -> "pri.refresh.total"
                | CatIndicesColumn.RefreshTime -> "refresh.time"
                | CatIndicesColumn.PriRefreshTime -> "pri.refresh.time"
                | CatIndicesColumn.RefreshExternalTotal -> "refresh.external_total"
                | CatIndicesColumn.PriRefreshExternalTotal -> "pri.refresh.external_total"
                | CatIndicesColumn.RefreshExternalTime -> "refresh.external_time"
                | CatIndicesColumn.PriRefreshExternalTime -> "pri.refresh.external_time"
                | CatIndicesColumn.RefreshListeners -> "refresh.listeners"
                | CatIndicesColumn.PriRefreshListeners -> "pri.refresh.listeners"
                | CatIndicesColumn.SearchFetchCurrent -> "search.fetch_current"
                | CatIndicesColumn.PriSearchFetchCurrent -> "pri.search.fetch_current"
                | CatIndicesColumn.SearchFetchTime -> "search.fetch_time"
                | CatIndicesColumn.PriSearchFetchTime -> "pri.search.fetch_time"
                | CatIndicesColumn.SearchFetchTotal -> "search.fetch_total"
                | CatIndicesColumn.PriSearchFetchTotal -> "pri.search.fetch_total"
                | CatIndicesColumn.SearchOpenContexts -> "search.open_contexts"
                | CatIndicesColumn.PriSearchOpenContexts -> "pri.search.open_contexts"
                | CatIndicesColumn.SearchQueryCurrent -> "search.query_current"
                | CatIndicesColumn.PriSearchQueryCurrent -> "pri.search.query_current"
                | CatIndicesColumn.SearchQueryTime -> "search.query_time"
                | CatIndicesColumn.PriSearchQueryTime -> "pri.search.query_time"
                | CatIndicesColumn.SearchQueryTotal -> "search.query_total"
                | CatIndicesColumn.PriSearchQueryTotal -> "pri.search.query_total"
                | CatIndicesColumn.SearchScrollCurrent -> "search.scroll_current"
                | CatIndicesColumn.PriSearchScrollCurrent -> "pri.search.scroll_current"
                | CatIndicesColumn.SearchScrollTime -> "search.scroll_time"
                | CatIndicesColumn.PriSearchScrollTime -> "pri.search.scroll_time"
                | CatIndicesColumn.SearchScrollTotal -> "search.scroll_total"
                | CatIndicesColumn.PriSearchScrollTotal -> "pri.search.scroll_total"
                | CatIndicesColumn.SegmentsCount -> "segments.count"
                | CatIndicesColumn.PriSegmentsCount -> "pri.segments.count"
                | CatIndicesColumn.SegmentsMemory -> "segments.memory"
                | CatIndicesColumn.PriSegmentsMemory -> "pri.segments.memory"
                | CatIndicesColumn.SegmentsIndexWriterMemory -> "segments.index_writer_memory"
                | CatIndicesColumn.PriSegmentsIndexWriterMemory -> "pri.segments.index_writer_memory"
                | CatIndicesColumn.SegmentsVersionMapMemory -> "segments.version_map_memory"
                | CatIndicesColumn.PriSegmentsVersionMapMemory -> "pri.segments.version_map_memory"
                | CatIndicesColumn.SegmentsFixedBitsetMemory -> "segments.fixed_bitset_memory"
                | CatIndicesColumn.PriSegmentsFixedBitsetMemory -> "pri.segments.fixed_bitset_memory"
                | CatIndicesColumn.WarmerCurrent -> "warmer.current"
                | CatIndicesColumn.PriWarmerCurrent -> "pri.warmer.current"
                | CatIndicesColumn.WarmerTotal -> "warmer.total"
                | CatIndicesColumn.PriWarmerTotal -> "pri.warmer.total"
                | CatIndicesColumn.WarmerTotalTime -> "warmer.total_time"
                | CatIndicesColumn.PriWarmerTotalTime -> "pri.warmer.total_time"
                | CatIndicesColumn.SuggestCurrent -> "suggest.current"
                | CatIndicesColumn.PriSuggestCurrent -> "pri.suggest.current"
                | CatIndicesColumn.SuggestTime -> "suggest.time"
                | CatIndicesColumn.PriSuggestTime -> "pri.suggest.time"
                | CatIndicesColumn.SuggestTotal -> "suggest.total"
                | CatIndicesColumn.PriSuggestTotal -> "pri.suggest.total"
                | CatIndicesColumn.MemoryTotal -> "memory.total"
                | CatIndicesColumn.PriMemoryTotal -> "pri.memory.total"
                | CatIndicesColumn.BulkTotalOperations -> "bulk.total_operations"
                | CatIndicesColumn.PriBulkTotalOperations -> "pri.bulk.total_operations"
                | CatIndicesColumn.BulkTotalTime -> "bulk.total_time"
                | CatIndicesColumn.PriBulkTotalTime -> "pri.bulk.total_time"
                | CatIndicesColumn.BulkTotalSizeInBytes -> "bulk.total_size_in_bytes"
                | CatIndicesColumn.PriBulkTotalSizeInBytes -> "pri.bulk.total_size_in_bytes"
                | CatIndicesColumn.BulkAvgTime -> "bulk.avg_time"
                | CatIndicesColumn.PriBulkAvgTime -> "pri.bulk.avg_time"
                | CatIndicesColumn.BulkAvgSizeInBytes -> "bulk.avg_size_in_bytes"
                | CatIndicesColumn.PriBulkAvgSizeInBytes -> "pri.bulk.avg_size_in_bytes"
                | CatIndicesColumn.DenseVectorValueCount -> "dense_vector.value_count"
                | CatIndicesColumn.PriDenseVectorValueCount -> "pri.dense_vector.value_count"
                | CatIndicesColumn.SparseVectorValueCount -> "sparse_vector.value_count"
                | CatIndicesColumn.PriSparseVectorValueCount -> "pri.sparse_vector.value_count"
                | CatIndicesColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "health" -> CatIndicesColumn.Health
            | "status" -> CatIndicesColumn.Status
            | "index" -> CatIndicesColumn.Index
            | "uuid" -> CatIndicesColumn.Uuid
            | "pri" -> CatIndicesColumn.Pri
            | "rep" -> CatIndicesColumn.Rep
            | "docs.count" -> CatIndicesColumn.DocsCount
            | "docs.deleted" -> CatIndicesColumn.DocsDeleted
            | "creation.date" -> CatIndicesColumn.CreationDate
            | "creation.date.string" -> CatIndicesColumn.CreationDateString
            | "store.size" -> CatIndicesColumn.StoreSize
            | "pri.store.size" -> CatIndicesColumn.PriStoreSize
            | "dataset.size" -> CatIndicesColumn.DatasetSize
            | "completion.size" -> CatIndicesColumn.CompletionSize
            | "pri.completion.size" -> CatIndicesColumn.PriCompletionSize
            | "fielddata.memory_size" -> CatIndicesColumn.FielddataMemorySize
            | "pri.fielddata.memory_size" -> CatIndicesColumn.PriFielddataMemorySize
            | "fielddata.evictions" -> CatIndicesColumn.FielddataEvictions
            | "pri.fielddata.evictions" -> CatIndicesColumn.PriFielddataEvictions
            | "query_cache.memory_size" -> CatIndicesColumn.QueryCacheMemorySize
            | "pri.query_cache.memory_size" -> CatIndicesColumn.PriQueryCacheMemorySize
            | "query_cache.evictions" -> CatIndicesColumn.QueryCacheEvictions
            | "pri.query_cache.evictions" -> CatIndicesColumn.PriQueryCacheEvictions
            | "request_cache.memory_size" -> CatIndicesColumn.RequestCacheMemorySize
            | "pri.request_cache.memory_size" -> CatIndicesColumn.PriRequestCacheMemorySize
            | "request_cache.evictions" -> CatIndicesColumn.RequestCacheEvictions
            | "pri.request_cache.evictions" -> CatIndicesColumn.PriRequestCacheEvictions
            | "request_cache.hit_count" -> CatIndicesColumn.RequestCacheHitCount
            | "pri.request_cache.hit_count" -> CatIndicesColumn.PriRequestCacheHitCount
            | "request_cache.miss_count" -> CatIndicesColumn.RequestCacheMissCount
            | "pri.request_cache.miss_count" -> CatIndicesColumn.PriRequestCacheMissCount
            | "flush.total" -> CatIndicesColumn.FlushTotal
            | "pri.flush.total" -> CatIndicesColumn.PriFlushTotal
            | "flush.total_time" -> CatIndicesColumn.FlushTotalTime
            | "pri.flush.total_time" -> CatIndicesColumn.PriFlushTotalTime
            | "get.current" -> CatIndicesColumn.GetCurrent
            | "pri.get.current" -> CatIndicesColumn.PriGetCurrent
            | "get.time" -> CatIndicesColumn.GetTime
            | "pri.get.time" -> CatIndicesColumn.PriGetTime
            | "get.total" -> CatIndicesColumn.GetTotal
            | "pri.get.total" -> CatIndicesColumn.PriGetTotal
            | "get.exists_time" -> CatIndicesColumn.GetExistsTime
            | "pri.get.exists_time" -> CatIndicesColumn.PriGetExistsTime
            | "get.exists_total" -> CatIndicesColumn.GetExistsTotal
            | "pri.get.exists_total" -> CatIndicesColumn.PriGetExistsTotal
            | "get.missing_time" -> CatIndicesColumn.GetMissingTime
            | "pri.get.missing_time" -> CatIndicesColumn.PriGetMissingTime
            | "get.missing_total" -> CatIndicesColumn.GetMissingTotal
            | "pri.get.missing_total" -> CatIndicesColumn.PriGetMissingTotal
            | "indexing.delete_current" -> CatIndicesColumn.IndexingDeleteCurrent
            | "pri.indexing.delete_current" -> CatIndicesColumn.PriIndexingDeleteCurrent
            | "indexing.delete_time" -> CatIndicesColumn.IndexingDeleteTime
            | "pri.indexing.delete_time" -> CatIndicesColumn.PriIndexingDeleteTime
            | "indexing.delete_total" -> CatIndicesColumn.IndexingDeleteTotal
            | "pri.indexing.delete_total" -> CatIndicesColumn.PriIndexingDeleteTotal
            | "indexing.index_current" -> CatIndicesColumn.IndexingIndexCurrent
            | "pri.indexing.index_current" -> CatIndicesColumn.PriIndexingIndexCurrent
            | "indexing.index_time" -> CatIndicesColumn.IndexingIndexTime
            | "pri.indexing.index_time" -> CatIndicesColumn.PriIndexingIndexTime
            | "indexing.index_total" -> CatIndicesColumn.IndexingIndexTotal
            | "pri.indexing.index_total" -> CatIndicesColumn.PriIndexingIndexTotal
            | "indexing.index_failed" -> CatIndicesColumn.IndexingIndexFailed
            | "pri.indexing.index_failed" -> CatIndicesColumn.PriIndexingIndexFailed
            | "indexing.index_failed_due_to_version_conflict" -> CatIndicesColumn.IndexingIndexFailedDueToVersionConflict
            | "pri.indexing.index_failed_due_to_version_conflict" -> CatIndicesColumn.PriIndexingIndexFailedDueToVersionConflict
            | "merges.current" -> CatIndicesColumn.MergesCurrent
            | "pri.merges.current" -> CatIndicesColumn.PriMergesCurrent
            | "merges.current_docs" -> CatIndicesColumn.MergesCurrentDocs
            | "pri.merges.current_docs" -> CatIndicesColumn.PriMergesCurrentDocs
            | "merges.current_size" -> CatIndicesColumn.MergesCurrentSize
            | "pri.merges.current_size" -> CatIndicesColumn.PriMergesCurrentSize
            | "merges.total" -> CatIndicesColumn.MergesTotal
            | "pri.merges.total" -> CatIndicesColumn.PriMergesTotal
            | "merges.total_docs" -> CatIndicesColumn.MergesTotalDocs
            | "pri.merges.total_docs" -> CatIndicesColumn.PriMergesTotalDocs
            | "merges.total_size" -> CatIndicesColumn.MergesTotalSize
            | "pri.merges.total_size" -> CatIndicesColumn.PriMergesTotalSize
            | "merges.total_time" -> CatIndicesColumn.MergesTotalTime
            | "pri.merges.total_time" -> CatIndicesColumn.PriMergesTotalTime
            | "refresh.total" -> CatIndicesColumn.RefreshTotal
            | "pri.refresh.total" -> CatIndicesColumn.PriRefreshTotal
            | "refresh.time" -> CatIndicesColumn.RefreshTime
            | "pri.refresh.time" -> CatIndicesColumn.PriRefreshTime
            | "refresh.external_total" -> CatIndicesColumn.RefreshExternalTotal
            | "pri.refresh.external_total" -> CatIndicesColumn.PriRefreshExternalTotal
            | "refresh.external_time" -> CatIndicesColumn.RefreshExternalTime
            | "pri.refresh.external_time" -> CatIndicesColumn.PriRefreshExternalTime
            | "refresh.listeners" -> CatIndicesColumn.RefreshListeners
            | "pri.refresh.listeners" -> CatIndicesColumn.PriRefreshListeners
            | "search.fetch_current" -> CatIndicesColumn.SearchFetchCurrent
            | "pri.search.fetch_current" -> CatIndicesColumn.PriSearchFetchCurrent
            | "search.fetch_time" -> CatIndicesColumn.SearchFetchTime
            | "pri.search.fetch_time" -> CatIndicesColumn.PriSearchFetchTime
            | "search.fetch_total" -> CatIndicesColumn.SearchFetchTotal
            | "pri.search.fetch_total" -> CatIndicesColumn.PriSearchFetchTotal
            | "search.open_contexts" -> CatIndicesColumn.SearchOpenContexts
            | "pri.search.open_contexts" -> CatIndicesColumn.PriSearchOpenContexts
            | "search.query_current" -> CatIndicesColumn.SearchQueryCurrent
            | "pri.search.query_current" -> CatIndicesColumn.PriSearchQueryCurrent
            | "search.query_time" -> CatIndicesColumn.SearchQueryTime
            | "pri.search.query_time" -> CatIndicesColumn.PriSearchQueryTime
            | "search.query_total" -> CatIndicesColumn.SearchQueryTotal
            | "pri.search.query_total" -> CatIndicesColumn.PriSearchQueryTotal
            | "search.scroll_current" -> CatIndicesColumn.SearchScrollCurrent
            | "pri.search.scroll_current" -> CatIndicesColumn.PriSearchScrollCurrent
            | "search.scroll_time" -> CatIndicesColumn.SearchScrollTime
            | "pri.search.scroll_time" -> CatIndicesColumn.PriSearchScrollTime
            | "search.scroll_total" -> CatIndicesColumn.SearchScrollTotal
            | "pri.search.scroll_total" -> CatIndicesColumn.PriSearchScrollTotal
            | "segments.count" -> CatIndicesColumn.SegmentsCount
            | "pri.segments.count" -> CatIndicesColumn.PriSegmentsCount
            | "segments.memory" -> CatIndicesColumn.SegmentsMemory
            | "pri.segments.memory" -> CatIndicesColumn.PriSegmentsMemory
            | "segments.index_writer_memory" -> CatIndicesColumn.SegmentsIndexWriterMemory
            | "pri.segments.index_writer_memory" -> CatIndicesColumn.PriSegmentsIndexWriterMemory
            | "segments.version_map_memory" -> CatIndicesColumn.SegmentsVersionMapMemory
            | "pri.segments.version_map_memory" -> CatIndicesColumn.PriSegmentsVersionMapMemory
            | "segments.fixed_bitset_memory" -> CatIndicesColumn.SegmentsFixedBitsetMemory
            | "pri.segments.fixed_bitset_memory" -> CatIndicesColumn.PriSegmentsFixedBitsetMemory
            | "warmer.current" -> CatIndicesColumn.WarmerCurrent
            | "pri.warmer.current" -> CatIndicesColumn.PriWarmerCurrent
            | "warmer.total" -> CatIndicesColumn.WarmerTotal
            | "pri.warmer.total" -> CatIndicesColumn.PriWarmerTotal
            | "warmer.total_time" -> CatIndicesColumn.WarmerTotalTime
            | "pri.warmer.total_time" -> CatIndicesColumn.PriWarmerTotalTime
            | "suggest.current" -> CatIndicesColumn.SuggestCurrent
            | "pri.suggest.current" -> CatIndicesColumn.PriSuggestCurrent
            | "suggest.time" -> CatIndicesColumn.SuggestTime
            | "pri.suggest.time" -> CatIndicesColumn.PriSuggestTime
            | "suggest.total" -> CatIndicesColumn.SuggestTotal
            | "pri.suggest.total" -> CatIndicesColumn.PriSuggestTotal
            | "memory.total" -> CatIndicesColumn.MemoryTotal
            | "pri.memory.total" -> CatIndicesColumn.PriMemoryTotal
            | "bulk.total_operations" -> CatIndicesColumn.BulkTotalOperations
            | "pri.bulk.total_operations" -> CatIndicesColumn.PriBulkTotalOperations
            | "bulk.total_time" -> CatIndicesColumn.BulkTotalTime
            | "pri.bulk.total_time" -> CatIndicesColumn.PriBulkTotalTime
            | "bulk.total_size_in_bytes" -> CatIndicesColumn.BulkTotalSizeInBytes
            | "pri.bulk.total_size_in_bytes" -> CatIndicesColumn.PriBulkTotalSizeInBytes
            | "bulk.avg_time" -> CatIndicesColumn.BulkAvgTime
            | "pri.bulk.avg_time" -> CatIndicesColumn.PriBulkAvgTime
            | "bulk.avg_size_in_bytes" -> CatIndicesColumn.BulkAvgSizeInBytes
            | "pri.bulk.avg_size_in_bytes" -> CatIndicesColumn.PriBulkAvgSizeInBytes
            | "dense_vector.value_count" -> CatIndicesColumn.DenseVectorValueCount
            | "pri.dense_vector.value_count" -> CatIndicesColumn.PriDenseVectorValueCount
            | "sparse_vector.value_count" -> CatIndicesColumn.SparseVectorValueCount
            | "pri.sparse_vector.value_count" -> CatIndicesColumn.PriSparseVectorValueCount
            | other -> CatIndicesColumn.Custom other

    type CatMasterColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatMasterColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatMasterColumn.Id -> "id"
                | CatMasterColumn.Host -> "host"
                | CatMasterColumn.Ip -> "ip"
                | CatMasterColumn.Node -> "node"
                | CatMasterColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "id" -> CatMasterColumn.Id
            | "host" -> CatMasterColumn.Host
            | "ip" -> CatMasterColumn.Ip
            | "node" -> CatMasterColumn.Node
            | other -> CatMasterColumn.Custom other

    type CatNodeColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatNodeColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatNodeColumn.Build -> "build"
                | CatNodeColumn.CompletionSize -> "completion.size"
                | CatNodeColumn.Cpu -> "cpu"
                | CatNodeColumn.DiskAvail -> "disk.avail"
                | CatNodeColumn.DiskTotal -> "disk.total"
                | CatNodeColumn.DiskUsed -> "disk.used"
                | CatNodeColumn.DiskUsedPercent -> "disk.used_percent"
                | CatNodeColumn.FielddataEvictions -> "fielddata.evictions"
                | CatNodeColumn.FielddataMemorySize -> "fielddata.memory_size"
                | CatNodeColumn.FileDescCurrent -> "file_desc.current"
                | CatNodeColumn.FileDescMax -> "file_desc.max"
                | CatNodeColumn.FileDescPercent -> "file_desc.percent"
                | CatNodeColumn.FlushTotal -> "flush.total"
                | CatNodeColumn.FlushTotalTime -> "flush.total_time"
                | CatNodeColumn.GetCurrent -> "get.current"
                | CatNodeColumn.GetExistsTime -> "get.exists_time"
                | CatNodeColumn.GetExistsTotal -> "get.exists_total"
                | CatNodeColumn.GetMissingTime -> "get.missing_time"
                | CatNodeColumn.GetMissingTotal -> "get.missing_total"
                | CatNodeColumn.GetTime -> "get.time"
                | CatNodeColumn.GetTotal -> "get.total"
                | CatNodeColumn.HeapCurrent -> "heap.current"
                | CatNodeColumn.HeapMax -> "heap.max"
                | CatNodeColumn.HeapPercent -> "heap.percent"
                | CatNodeColumn.HttpAddress -> "http_address"
                | CatNodeColumn.Id -> "id"
                | CatNodeColumn.IndexingDeleteCurrent -> "indexing.delete_current"
                | CatNodeColumn.IndexingDeleteTime -> "indexing.delete_time"
                | CatNodeColumn.IndexingDeleteTotal -> "indexing.delete_total"
                | CatNodeColumn.IndexingIndexCurrent -> "indexing.index_current"
                | CatNodeColumn.IndexingIndexFailed -> "indexing.index_failed"
                | CatNodeColumn.IndexingIndexFailedDueToVersionConflict -> "indexing.index_failed_due_to_version_conflict"
                | CatNodeColumn.IndexingIndexTime -> "indexing.index_time"
                | CatNodeColumn.IndexingIndexTotal -> "indexing.index_total"
                | CatNodeColumn.Ip -> "ip"
                | CatNodeColumn.Jdk -> "jdk"
                | CatNodeColumn.Load1m -> "load_1m"
                | CatNodeColumn.Load5m -> "load_5m"
                | CatNodeColumn.Load15m -> "load_15m"
                | CatNodeColumn.AvailableProcessors -> "available_processors"
                | CatNodeColumn.MappingsTotalCount -> "mappings.total_count"
                | CatNodeColumn.MappingsTotalEstimatedOverheadInBytes -> "mappings.total_estimated_overhead_in_bytes"
                | CatNodeColumn.Master -> "master"
                | CatNodeColumn.MergesCurrent -> "merges.current"
                | CatNodeColumn.MergesCurrentDocs -> "merges.current_docs"
                | CatNodeColumn.MergesCurrentSize -> "merges.current_size"
                | CatNodeColumn.MergesTotal -> "merges.total"
                | CatNodeColumn.MergesTotalDocs -> "merges.total_docs"
                | CatNodeColumn.MergesTotalSize -> "merges.total_size"
                | CatNodeColumn.MergesTotalTime -> "merges.total_time"
                | CatNodeColumn.Name -> "name"
                | CatNodeColumn.NodeRole -> "node.role"
                | CatNodeColumn.Pid -> "pid"
                | CatNodeColumn.Port -> "port"
                | CatNodeColumn.QueryCacheMemorySize -> "query_cache.memory_size"
                | CatNodeColumn.QueryCacheEvictions -> "query_cache.evictions"
                | CatNodeColumn.QueryCacheHitCount -> "query_cache.hit_count"
                | CatNodeColumn.QueryCacheMissCount -> "query_cache.miss_count"
                | CatNodeColumn.RamCurrent -> "ram.current"
                | CatNodeColumn.RamMax -> "ram.max"
                | CatNodeColumn.RamPercent -> "ram.percent"
                | CatNodeColumn.RefreshTotal -> "refresh.total"
                | CatNodeColumn.RefreshTime -> "refresh.time"
                | CatNodeColumn.RequestCacheMemorySize -> "request_cache.memory_size"
                | CatNodeColumn.RequestCacheEvictions -> "request_cache.evictions"
                | CatNodeColumn.RequestCacheHitCount -> "request_cache.hit_count"
                | CatNodeColumn.RequestCacheMissCount -> "request_cache.miss_count"
                | CatNodeColumn.ScriptCompilations -> "script.compilations"
                | CatNodeColumn.ScriptCacheEvictions -> "script.cache_evictions"
                | CatNodeColumn.SearchFetchCurrent -> "search.fetch_current"
                | CatNodeColumn.SearchFetchTime -> "search.fetch_time"
                | CatNodeColumn.SearchFetchTotal -> "search.fetch_total"
                | CatNodeColumn.SearchOpenContexts -> "search.open_contexts"
                | CatNodeColumn.SearchQueryCurrent -> "search.query_current"
                | CatNodeColumn.SearchQueryTime -> "search.query_time"
                | CatNodeColumn.SearchQueryTotal -> "search.query_total"
                | CatNodeColumn.SearchScrollCurrent -> "search.scroll_current"
                | CatNodeColumn.SearchScrollTime -> "search.scroll_time"
                | CatNodeColumn.SearchScrollTotal -> "search.scroll_total"
                | CatNodeColumn.SegmentsCount -> "segments.count"
                | CatNodeColumn.SegmentsFixedBitsetMemory -> "segments.fixed_bitset_memory"
                | CatNodeColumn.SegmentsIndexWriterMemory -> "segments.index_writer_memory"
                | CatNodeColumn.SegmentsMemory -> "segments.memory"
                | CatNodeColumn.SegmentsVersionMapMemory -> "segments.version_map_memory"
                | CatNodeColumn.ShardStatsTotalCount -> "shard_stats.total_count"
                | CatNodeColumn.SuggestCurrent -> "suggest.current"
                | CatNodeColumn.SuggestTime -> "suggest.time"
                | CatNodeColumn.SuggestTotal -> "suggest.total"
                | CatNodeColumn.Uptime -> "uptime"
                | CatNodeColumn.Version -> "version"
                | CatNodeColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "build" -> CatNodeColumn.Build
            | "completion.size" -> CatNodeColumn.CompletionSize
            | "cpu" -> CatNodeColumn.Cpu
            | "disk.avail" -> CatNodeColumn.DiskAvail
            | "disk.total" -> CatNodeColumn.DiskTotal
            | "disk.used" -> CatNodeColumn.DiskUsed
            | "disk.used_percent" -> CatNodeColumn.DiskUsedPercent
            | "fielddata.evictions" -> CatNodeColumn.FielddataEvictions
            | "fielddata.memory_size" -> CatNodeColumn.FielddataMemorySize
            | "file_desc.current" -> CatNodeColumn.FileDescCurrent
            | "file_desc.max" -> CatNodeColumn.FileDescMax
            | "file_desc.percent" -> CatNodeColumn.FileDescPercent
            | "flush.total" -> CatNodeColumn.FlushTotal
            | "flush.total_time" -> CatNodeColumn.FlushTotalTime
            | "get.current" -> CatNodeColumn.GetCurrent
            | "get.exists_time" -> CatNodeColumn.GetExistsTime
            | "get.exists_total" -> CatNodeColumn.GetExistsTotal
            | "get.missing_time" -> CatNodeColumn.GetMissingTime
            | "get.missing_total" -> CatNodeColumn.GetMissingTotal
            | "get.time" -> CatNodeColumn.GetTime
            | "get.total" -> CatNodeColumn.GetTotal
            | "heap.current" -> CatNodeColumn.HeapCurrent
            | "heap.max" -> CatNodeColumn.HeapMax
            | "heap.percent" -> CatNodeColumn.HeapPercent
            | "http_address" -> CatNodeColumn.HttpAddress
            | "id" -> CatNodeColumn.Id
            | "indexing.delete_current" -> CatNodeColumn.IndexingDeleteCurrent
            | "indexing.delete_time" -> CatNodeColumn.IndexingDeleteTime
            | "indexing.delete_total" -> CatNodeColumn.IndexingDeleteTotal
            | "indexing.index_current" -> CatNodeColumn.IndexingIndexCurrent
            | "indexing.index_failed" -> CatNodeColumn.IndexingIndexFailed
            | "indexing.index_failed_due_to_version_conflict" -> CatNodeColumn.IndexingIndexFailedDueToVersionConflict
            | "indexing.index_time" -> CatNodeColumn.IndexingIndexTime
            | "indexing.index_total" -> CatNodeColumn.IndexingIndexTotal
            | "ip" -> CatNodeColumn.Ip
            | "jdk" -> CatNodeColumn.Jdk
            | "load_1m" -> CatNodeColumn.Load1m
            | "load_5m" -> CatNodeColumn.Load5m
            | "load_15m" -> CatNodeColumn.Load15m
            | "available_processors" -> CatNodeColumn.AvailableProcessors
            | "mappings.total_count" -> CatNodeColumn.MappingsTotalCount
            | "mappings.total_estimated_overhead_in_bytes" -> CatNodeColumn.MappingsTotalEstimatedOverheadInBytes
            | "master" -> CatNodeColumn.Master
            | "merges.current" -> CatNodeColumn.MergesCurrent
            | "merges.current_docs" -> CatNodeColumn.MergesCurrentDocs
            | "merges.current_size" -> CatNodeColumn.MergesCurrentSize
            | "merges.total" -> CatNodeColumn.MergesTotal
            | "merges.total_docs" -> CatNodeColumn.MergesTotalDocs
            | "merges.total_size" -> CatNodeColumn.MergesTotalSize
            | "merges.total_time" -> CatNodeColumn.MergesTotalTime
            | "name" -> CatNodeColumn.Name
            | "node.role" -> CatNodeColumn.NodeRole
            | "pid" -> CatNodeColumn.Pid
            | "port" -> CatNodeColumn.Port
            | "query_cache.memory_size" -> CatNodeColumn.QueryCacheMemorySize
            | "query_cache.evictions" -> CatNodeColumn.QueryCacheEvictions
            | "query_cache.hit_count" -> CatNodeColumn.QueryCacheHitCount
            | "query_cache.miss_count" -> CatNodeColumn.QueryCacheMissCount
            | "ram.current" -> CatNodeColumn.RamCurrent
            | "ram.max" -> CatNodeColumn.RamMax
            | "ram.percent" -> CatNodeColumn.RamPercent
            | "refresh.total" -> CatNodeColumn.RefreshTotal
            | "refresh.time" -> CatNodeColumn.RefreshTime
            | "request_cache.memory_size" -> CatNodeColumn.RequestCacheMemorySize
            | "request_cache.evictions" -> CatNodeColumn.RequestCacheEvictions
            | "request_cache.hit_count" -> CatNodeColumn.RequestCacheHitCount
            | "request_cache.miss_count" -> CatNodeColumn.RequestCacheMissCount
            | "script.compilations" -> CatNodeColumn.ScriptCompilations
            | "script.cache_evictions" -> CatNodeColumn.ScriptCacheEvictions
            | "search.fetch_current" -> CatNodeColumn.SearchFetchCurrent
            | "search.fetch_time" -> CatNodeColumn.SearchFetchTime
            | "search.fetch_total" -> CatNodeColumn.SearchFetchTotal
            | "search.open_contexts" -> CatNodeColumn.SearchOpenContexts
            | "search.query_current" -> CatNodeColumn.SearchQueryCurrent
            | "search.query_time" -> CatNodeColumn.SearchQueryTime
            | "search.query_total" -> CatNodeColumn.SearchQueryTotal
            | "search.scroll_current" -> CatNodeColumn.SearchScrollCurrent
            | "search.scroll_time" -> CatNodeColumn.SearchScrollTime
            | "search.scroll_total" -> CatNodeColumn.SearchScrollTotal
            | "segments.count" -> CatNodeColumn.SegmentsCount
            | "segments.fixed_bitset_memory" -> CatNodeColumn.SegmentsFixedBitsetMemory
            | "segments.index_writer_memory" -> CatNodeColumn.SegmentsIndexWriterMemory
            | "segments.memory" -> CatNodeColumn.SegmentsMemory
            | "segments.version_map_memory" -> CatNodeColumn.SegmentsVersionMapMemory
            | "shard_stats.total_count" -> CatNodeColumn.ShardStatsTotalCount
            | "suggest.current" -> CatNodeColumn.SuggestCurrent
            | "suggest.time" -> CatNodeColumn.SuggestTime
            | "suggest.total" -> CatNodeColumn.SuggestTotal
            | "uptime" -> CatNodeColumn.Uptime
            | "version" -> CatNodeColumn.Version
            | other -> CatNodeColumn.Custom other

    type CatNodeattrsColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatNodeattrsColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatNodeattrsColumn.Node -> "node"
                | CatNodeattrsColumn.Id -> "id"
                | CatNodeattrsColumn.Pid -> "pid"
                | CatNodeattrsColumn.Host -> "host"
                | CatNodeattrsColumn.Ip -> "ip"
                | CatNodeattrsColumn.Port -> "port"
                | CatNodeattrsColumn.Attr -> "attr"
                | CatNodeattrsColumn.Value -> "value"
                | CatNodeattrsColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "node" -> CatNodeattrsColumn.Node
            | "id" -> CatNodeattrsColumn.Id
            | "pid" -> CatNodeattrsColumn.Pid
            | "host" -> CatNodeattrsColumn.Host
            | "ip" -> CatNodeattrsColumn.Ip
            | "port" -> CatNodeattrsColumn.Port
            | "attr" -> CatNodeattrsColumn.Attr
            | "value" -> CatNodeattrsColumn.Value
            | other -> CatNodeattrsColumn.Custom other

    type CatPendingTasksColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatPendingTasksColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatPendingTasksColumn.InsertOrder -> "insertOrder"
                | CatPendingTasksColumn.TimeInQueue -> "timeInQueue"
                | CatPendingTasksColumn.Priority -> "priority"
                | CatPendingTasksColumn.Source -> "source"
                | CatPendingTasksColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "insertOrder" -> CatPendingTasksColumn.InsertOrder
            | "timeInQueue" -> CatPendingTasksColumn.TimeInQueue
            | "priority" -> CatPendingTasksColumn.Priority
            | "source" -> CatPendingTasksColumn.Source
            | other -> CatPendingTasksColumn.Custom other

    type CatPluginsColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatPluginsColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatPluginsColumn.Id -> "id"
                | CatPluginsColumn.Name -> "name"
                | CatPluginsColumn.Component -> "component"
                | CatPluginsColumn.Version -> "version"
                | CatPluginsColumn.Description -> "description"
                | CatPluginsColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "id" -> CatPluginsColumn.Id
            | "name" -> CatPluginsColumn.Name
            | "component" -> CatPluginsColumn.Component
            | "version" -> CatPluginsColumn.Version
            | "description" -> CatPluginsColumn.Description
            | other -> CatPluginsColumn.Custom other

    type CatRecoveryColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatRecoveryColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatRecoveryColumn.Index -> "index"
                | CatRecoveryColumn.Shard -> "shard"
                | CatRecoveryColumn.StartTime -> "start_time"
                | CatRecoveryColumn.StartTimeMillis -> "start_time_millis"
                | CatRecoveryColumn.StopTime -> "stop_time"
                | CatRecoveryColumn.StopTimeMillis -> "stop_time_millis"
                | CatRecoveryColumn.Time -> "time"
                | CatRecoveryColumn.Type -> "type"
                | CatRecoveryColumn.Stage -> "stage"
                | CatRecoveryColumn.SourceHost -> "source_host"
                | CatRecoveryColumn.SourceNode -> "source_node"
                | CatRecoveryColumn.TargetHost -> "target_host"
                | CatRecoveryColumn.TargetNode -> "target_node"
                | CatRecoveryColumn.Repository -> "repository"
                | CatRecoveryColumn.Snapshot -> "snapshot"
                | CatRecoveryColumn.Files -> "files"
                | CatRecoveryColumn.FilesRecovered -> "files_recovered"
                | CatRecoveryColumn.FilesPercent -> "files_percent"
                | CatRecoveryColumn.FilesTotal -> "files_total"
                | CatRecoveryColumn.Bytes -> "bytes"
                | CatRecoveryColumn.BytesRecovered -> "bytes_recovered"
                | CatRecoveryColumn.BytesPercent -> "bytes_percent"
                | CatRecoveryColumn.BytesTotal -> "bytes_total"
                | CatRecoveryColumn.TranslogOps -> "translog_ops"
                | CatRecoveryColumn.TranslogOpsRecovered -> "translog_ops_recovered"
                | CatRecoveryColumn.TranslogOpsPercent -> "translog_ops_percent"
                | CatRecoveryColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "index" -> CatRecoveryColumn.Index
            | "shard" -> CatRecoveryColumn.Shard
            | "start_time" -> CatRecoveryColumn.StartTime
            | "start_time_millis" -> CatRecoveryColumn.StartTimeMillis
            | "stop_time" -> CatRecoveryColumn.StopTime
            | "stop_time_millis" -> CatRecoveryColumn.StopTimeMillis
            | "time" -> CatRecoveryColumn.Time
            | "type" -> CatRecoveryColumn.Type
            | "stage" -> CatRecoveryColumn.Stage
            | "source_host" -> CatRecoveryColumn.SourceHost
            | "source_node" -> CatRecoveryColumn.SourceNode
            | "target_host" -> CatRecoveryColumn.TargetHost
            | "target_node" -> CatRecoveryColumn.TargetNode
            | "repository" -> CatRecoveryColumn.Repository
            | "snapshot" -> CatRecoveryColumn.Snapshot
            | "files" -> CatRecoveryColumn.Files
            | "files_recovered" -> CatRecoveryColumn.FilesRecovered
            | "files_percent" -> CatRecoveryColumn.FilesPercent
            | "files_total" -> CatRecoveryColumn.FilesTotal
            | "bytes" -> CatRecoveryColumn.Bytes
            | "bytes_recovered" -> CatRecoveryColumn.BytesRecovered
            | "bytes_percent" -> CatRecoveryColumn.BytesPercent
            | "bytes_total" -> CatRecoveryColumn.BytesTotal
            | "translog_ops" -> CatRecoveryColumn.TranslogOps
            | "translog_ops_recovered" -> CatRecoveryColumn.TranslogOpsRecovered
            | "translog_ops_percent" -> CatRecoveryColumn.TranslogOpsPercent
            | other -> CatRecoveryColumn.Custom other

    type CatSegmentsColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatSegmentsColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatSegmentsColumn.Index -> "index"
                | CatSegmentsColumn.Shard -> "shard"
                | CatSegmentsColumn.Prirep -> "prirep"
                | CatSegmentsColumn.Ip -> "ip"
                | CatSegmentsColumn.Segment -> "segment"
                | CatSegmentsColumn.Generation -> "generation"
                | CatSegmentsColumn.DocsCount -> "docs.count"
                | CatSegmentsColumn.DocsDeleted -> "docs.deleted"
                | CatSegmentsColumn.Size -> "size"
                | CatSegmentsColumn.SizeMemory -> "size.memory"
                | CatSegmentsColumn.Committed -> "committed"
                | CatSegmentsColumn.Searchable -> "searchable"
                | CatSegmentsColumn.Version -> "version"
                | CatSegmentsColumn.Compound -> "compound"
                | CatSegmentsColumn.Id -> "id"
                | CatSegmentsColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "index" -> CatSegmentsColumn.Index
            | "shard" -> CatSegmentsColumn.Shard
            | "prirep" -> CatSegmentsColumn.Prirep
            | "ip" -> CatSegmentsColumn.Ip
            | "segment" -> CatSegmentsColumn.Segment
            | "generation" -> CatSegmentsColumn.Generation
            | "docs.count" -> CatSegmentsColumn.DocsCount
            | "docs.deleted" -> CatSegmentsColumn.DocsDeleted
            | "size" -> CatSegmentsColumn.Size
            | "size.memory" -> CatSegmentsColumn.SizeMemory
            | "committed" -> CatSegmentsColumn.Committed
            | "searchable" -> CatSegmentsColumn.Searchable
            | "version" -> CatSegmentsColumn.Version
            | "compound" -> CatSegmentsColumn.Compound
            | "id" -> CatSegmentsColumn.Id
            | other -> CatSegmentsColumn.Custom other

    type CatShardColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatShardColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatShardColumn.CompletionSize -> "completion.size"
                | CatShardColumn.DatasetSize -> "dataset.size"
                | CatShardColumn.DenseVectorValueCount -> "dense_vector.value_count"
                | CatShardColumn.Docs -> "docs"
                | CatShardColumn.FielddataEvictions -> "fielddata.evictions"
                | CatShardColumn.FielddataMemorySize -> "fielddata.memory_size"
                | CatShardColumn.FlushTotal -> "flush.total"
                | CatShardColumn.FlushTotalTime -> "flush.total_time"
                | CatShardColumn.GetCurrent -> "get.current"
                | CatShardColumn.GetExistsTime -> "get.exists_time"
                | CatShardColumn.GetExistsTotal -> "get.exists_total"
                | CatShardColumn.GetMissingTime -> "get.missing_time"
                | CatShardColumn.GetMissingTotal -> "get.missing_total"
                | CatShardColumn.GetTime -> "get.time"
                | CatShardColumn.GetTotal -> "get.total"
                | CatShardColumn.Id -> "id"
                | CatShardColumn.Index -> "index"
                | CatShardColumn.IndexingDeleteCurrent -> "indexing.delete_current"
                | CatShardColumn.IndexingDeleteTime -> "indexing.delete_time"
                | CatShardColumn.IndexingDeleteTotal -> "indexing.delete_total"
                | CatShardColumn.IndexingIndexCurrent -> "indexing.index_current"
                | CatShardColumn.IndexingIndexFailedDueToVersionConflict -> "indexing.index_failed_due_to_version_conflict"
                | CatShardColumn.IndexingIndexFailed -> "indexing.index_failed"
                | CatShardColumn.IndexingIndexTime -> "indexing.index_time"
                | CatShardColumn.IndexingIndexTotal -> "indexing.index_total"
                | CatShardColumn.Ip -> "ip"
                | CatShardColumn.MergesCurrent -> "merges.current"
                | CatShardColumn.MergesCurrentDocs -> "merges.current_docs"
                | CatShardColumn.MergesCurrentSize -> "merges.current_size"
                | CatShardColumn.MergesTotal -> "merges.total"
                | CatShardColumn.MergesTotalDocs -> "merges.total_docs"
                | CatShardColumn.MergesTotalSize -> "merges.total_size"
                | CatShardColumn.MergesTotalTime -> "merges.total_time"
                | CatShardColumn.Node -> "node"
                | CatShardColumn.Prirep -> "prirep"
                | CatShardColumn.QueryCacheEvictions -> "query_cache.evictions"
                | CatShardColumn.QueryCacheMemorySize -> "query_cache.memory_size"
                | CatShardColumn.RecoverysourceType -> "recoverysource.type"
                | CatShardColumn.RefreshTime -> "refresh.time"
                | CatShardColumn.RefreshTotal -> "refresh.total"
                | CatShardColumn.SearchFetchCurrent -> "search.fetch_current"
                | CatShardColumn.SearchFetchTime -> "search.fetch_time"
                | CatShardColumn.SearchFetchTotal -> "search.fetch_total"
                | CatShardColumn.SearchOpenContexts -> "search.open_contexts"
                | CatShardColumn.SearchQueryCurrent -> "search.query_current"
                | CatShardColumn.SearchQueryTime -> "search.query_time"
                | CatShardColumn.SearchQueryTotal -> "search.query_total"
                | CatShardColumn.SearchScrollCurrent -> "search.scroll_current"
                | CatShardColumn.SearchScrollTime -> "search.scroll_time"
                | CatShardColumn.SearchScrollTotal -> "search.scroll_total"
                | CatShardColumn.SegmentsCount -> "segments.count"
                | CatShardColumn.SegmentsFixedBitsetMemory -> "segments.fixed_bitset_memory"
                | CatShardColumn.SegmentsIndexWriterMemory -> "segments.index_writer_memory"
                | CatShardColumn.SegmentsMemory -> "segments.memory"
                | CatShardColumn.SegmentsVersionMapMemory -> "segments.version_map_memory"
                | CatShardColumn.SeqNoGlobalCheckpoint -> "seq_no.global_checkpoint"
                | CatShardColumn.SeqNoLocalCheckpoint -> "seq_no.local_checkpoint"
                | CatShardColumn.SeqNoMax -> "seq_no.max"
                | CatShardColumn.Shard -> "shard"
                | CatShardColumn.DsparseVectorValueCount -> "dsparse_vector.value_count"
                | CatShardColumn.State -> "state"
                | CatShardColumn.Store -> "store"
                | CatShardColumn.SuggestCurrent -> "suggest.current"
                | CatShardColumn.SuggestTime -> "suggest.time"
                | CatShardColumn.SuggestTotal -> "suggest.total"
                | CatShardColumn.SyncId -> "sync_id"
                | CatShardColumn.UnassignedAt -> "unassigned.at"
                | CatShardColumn.UnassignedDetails -> "unassigned.details"
                | CatShardColumn.UnassignedFor -> "unassigned.for"
                | CatShardColumn.UnassignedReason -> "unassigned.reason"
                | CatShardColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "completion.size" -> CatShardColumn.CompletionSize
            | "dataset.size" -> CatShardColumn.DatasetSize
            | "dense_vector.value_count" -> CatShardColumn.DenseVectorValueCount
            | "docs" -> CatShardColumn.Docs
            | "fielddata.evictions" -> CatShardColumn.FielddataEvictions
            | "fielddata.memory_size" -> CatShardColumn.FielddataMemorySize
            | "flush.total" -> CatShardColumn.FlushTotal
            | "flush.total_time" -> CatShardColumn.FlushTotalTime
            | "get.current" -> CatShardColumn.GetCurrent
            | "get.exists_time" -> CatShardColumn.GetExistsTime
            | "get.exists_total" -> CatShardColumn.GetExistsTotal
            | "get.missing_time" -> CatShardColumn.GetMissingTime
            | "get.missing_total" -> CatShardColumn.GetMissingTotal
            | "get.time" -> CatShardColumn.GetTime
            | "get.total" -> CatShardColumn.GetTotal
            | "id" -> CatShardColumn.Id
            | "index" -> CatShardColumn.Index
            | "indexing.delete_current" -> CatShardColumn.IndexingDeleteCurrent
            | "indexing.delete_time" -> CatShardColumn.IndexingDeleteTime
            | "indexing.delete_total" -> CatShardColumn.IndexingDeleteTotal
            | "indexing.index_current" -> CatShardColumn.IndexingIndexCurrent
            | "indexing.index_failed_due_to_version_conflict" -> CatShardColumn.IndexingIndexFailedDueToVersionConflict
            | "indexing.index_failed" -> CatShardColumn.IndexingIndexFailed
            | "indexing.index_time" -> CatShardColumn.IndexingIndexTime
            | "indexing.index_total" -> CatShardColumn.IndexingIndexTotal
            | "ip" -> CatShardColumn.Ip
            | "merges.current" -> CatShardColumn.MergesCurrent
            | "merges.current_docs" -> CatShardColumn.MergesCurrentDocs
            | "merges.current_size" -> CatShardColumn.MergesCurrentSize
            | "merges.total" -> CatShardColumn.MergesTotal
            | "merges.total_docs" -> CatShardColumn.MergesTotalDocs
            | "merges.total_size" -> CatShardColumn.MergesTotalSize
            | "merges.total_time" -> CatShardColumn.MergesTotalTime
            | "node" -> CatShardColumn.Node
            | "prirep" -> CatShardColumn.Prirep
            | "query_cache.evictions" -> CatShardColumn.QueryCacheEvictions
            | "query_cache.memory_size" -> CatShardColumn.QueryCacheMemorySize
            | "recoverysource.type" -> CatShardColumn.RecoverysourceType
            | "refresh.time" -> CatShardColumn.RefreshTime
            | "refresh.total" -> CatShardColumn.RefreshTotal
            | "search.fetch_current" -> CatShardColumn.SearchFetchCurrent
            | "search.fetch_time" -> CatShardColumn.SearchFetchTime
            | "search.fetch_total" -> CatShardColumn.SearchFetchTotal
            | "search.open_contexts" -> CatShardColumn.SearchOpenContexts
            | "search.query_current" -> CatShardColumn.SearchQueryCurrent
            | "search.query_time" -> CatShardColumn.SearchQueryTime
            | "search.query_total" -> CatShardColumn.SearchQueryTotal
            | "search.scroll_current" -> CatShardColumn.SearchScrollCurrent
            | "search.scroll_time" -> CatShardColumn.SearchScrollTime
            | "search.scroll_total" -> CatShardColumn.SearchScrollTotal
            | "segments.count" -> CatShardColumn.SegmentsCount
            | "segments.fixed_bitset_memory" -> CatShardColumn.SegmentsFixedBitsetMemory
            | "segments.index_writer_memory" -> CatShardColumn.SegmentsIndexWriterMemory
            | "segments.memory" -> CatShardColumn.SegmentsMemory
            | "segments.version_map_memory" -> CatShardColumn.SegmentsVersionMapMemory
            | "seq_no.global_checkpoint" -> CatShardColumn.SeqNoGlobalCheckpoint
            | "seq_no.local_checkpoint" -> CatShardColumn.SeqNoLocalCheckpoint
            | "seq_no.max" -> CatShardColumn.SeqNoMax
            | "shard" -> CatShardColumn.Shard
            | "dsparse_vector.value_count" -> CatShardColumn.DsparseVectorValueCount
            | "state" -> CatShardColumn.State
            | "store" -> CatShardColumn.Store
            | "suggest.current" -> CatShardColumn.SuggestCurrent
            | "suggest.time" -> CatShardColumn.SuggestTime
            | "suggest.total" -> CatShardColumn.SuggestTotal
            | "sync_id" -> CatShardColumn.SyncId
            | "unassigned.at" -> CatShardColumn.UnassignedAt
            | "unassigned.details" -> CatShardColumn.UnassignedDetails
            | "unassigned.for" -> CatShardColumn.UnassignedFor
            | "unassigned.reason" -> CatShardColumn.UnassignedReason
            | other -> CatShardColumn.Custom other

    type CatSnapshotsColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatSnapshotsColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatSnapshotsColumn.Id -> "id"
                | CatSnapshotsColumn.Repository -> "repository"
                | CatSnapshotsColumn.Status -> "status"
                | CatSnapshotsColumn.StartEpoch -> "start_epoch"
                | CatSnapshotsColumn.StartTime -> "start_time"
                | CatSnapshotsColumn.EndEpoch -> "end_epoch"
                | CatSnapshotsColumn.EndTime -> "end_time"
                | CatSnapshotsColumn.Duration -> "duration"
                | CatSnapshotsColumn.Indices -> "indices"
                | CatSnapshotsColumn.SuccessfulShards -> "successful_shards"
                | CatSnapshotsColumn.FailedShards -> "failed_shards"
                | CatSnapshotsColumn.TotalShards -> "total_shards"
                | CatSnapshotsColumn.Reason -> "reason"
                | CatSnapshotsColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "id" -> CatSnapshotsColumn.Id
            | "repository" -> CatSnapshotsColumn.Repository
            | "status" -> CatSnapshotsColumn.Status
            | "start_epoch" -> CatSnapshotsColumn.StartEpoch
            | "start_time" -> CatSnapshotsColumn.StartTime
            | "end_epoch" -> CatSnapshotsColumn.EndEpoch
            | "end_time" -> CatSnapshotsColumn.EndTime
            | "duration" -> CatSnapshotsColumn.Duration
            | "indices" -> CatSnapshotsColumn.Indices
            | "successful_shards" -> CatSnapshotsColumn.SuccessfulShards
            | "failed_shards" -> CatSnapshotsColumn.FailedShards
            | "total_shards" -> CatSnapshotsColumn.TotalShards
            | "reason" -> CatSnapshotsColumn.Reason
            | other -> CatSnapshotsColumn.Custom other

    type CatTasksColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTasksColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTasksColumn.Id -> "id"
                | CatTasksColumn.Action -> "action"
                | CatTasksColumn.TaskId -> "task_id"
                | CatTasksColumn.ParentTaskId -> "parent_task_id"
                | CatTasksColumn.Type -> "type"
                | CatTasksColumn.StartTime -> "start_time"
                | CatTasksColumn.Timestamp -> "timestamp"
                | CatTasksColumn.RunningTimeNs -> "running_time_ns"
                | CatTasksColumn.RunningTime -> "running_time"
                | CatTasksColumn.NodeId -> "node_id"
                | CatTasksColumn.Ip -> "ip"
                | CatTasksColumn.Port -> "port"
                | CatTasksColumn.Node -> "node"
                | CatTasksColumn.Version -> "version"
                | CatTasksColumn.XOpaqueId -> "x_opaque_id"
                | CatTasksColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "id" -> CatTasksColumn.Id
            | "action" -> CatTasksColumn.Action
            | "task_id" -> CatTasksColumn.TaskId
            | "parent_task_id" -> CatTasksColumn.ParentTaskId
            | "type" -> CatTasksColumn.Type
            | "start_time" -> CatTasksColumn.StartTime
            | "timestamp" -> CatTasksColumn.Timestamp
            | "running_time_ns" -> CatTasksColumn.RunningTimeNs
            | "running_time" -> CatTasksColumn.RunningTime
            | "node_id" -> CatTasksColumn.NodeId
            | "ip" -> CatTasksColumn.Ip
            | "port" -> CatTasksColumn.Port
            | "node" -> CatTasksColumn.Node
            | "version" -> CatTasksColumn.Version
            | "x_opaque_id" -> CatTasksColumn.XOpaqueId
            | other -> CatTasksColumn.Custom other

    type CatTemplatesColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTemplatesColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTemplatesColumn.Name -> "name"
                | CatTemplatesColumn.IndexPatterns -> "index_patterns"
                | CatTemplatesColumn.Order -> "order"
                | CatTemplatesColumn.Version -> "version"
                | CatTemplatesColumn.ComposedOf -> "composed_of"
                | CatTemplatesColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "name" -> CatTemplatesColumn.Name
            | "index_patterns" -> CatTemplatesColumn.IndexPatterns
            | "order" -> CatTemplatesColumn.Order
            | "version" -> CatTemplatesColumn.Version
            | "composed_of" -> CatTemplatesColumn.ComposedOf
            | other -> CatTemplatesColumn.Custom other

    type CatThreadPoolColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatThreadPoolColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatThreadPoolColumn.Active -> "active"
                | CatThreadPoolColumn.Completed -> "completed"
                | CatThreadPoolColumn.Core -> "core"
                | CatThreadPoolColumn.EphemeralId -> "ephemeral_id"
                | CatThreadPoolColumn.Host -> "host"
                | CatThreadPoolColumn.Ip -> "ip"
                | CatThreadPoolColumn.KeepAlive -> "keep_alive"
                | CatThreadPoolColumn.Largest -> "largest"
                | CatThreadPoolColumn.Max -> "max"
                | CatThreadPoolColumn.Name -> "name"
                | CatThreadPoolColumn.NodeId -> "node_id"
                | CatThreadPoolColumn.NodeName -> "node_name"
                | CatThreadPoolColumn.Pid -> "pid"
                | CatThreadPoolColumn.PoolSize -> "pool_size"
                | CatThreadPoolColumn.Port -> "port"
                | CatThreadPoolColumn.Queue -> "queue"
                | CatThreadPoolColumn.QueueSize -> "queue_size"
                | CatThreadPoolColumn.Rejected -> "rejected"
                | CatThreadPoolColumn.Size -> "size"
                | CatThreadPoolColumn.Type -> "type"
                | CatThreadPoolColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "active" -> CatThreadPoolColumn.Active
            | "completed" -> CatThreadPoolColumn.Completed
            | "core" -> CatThreadPoolColumn.Core
            | "ephemeral_id" -> CatThreadPoolColumn.EphemeralId
            | "host" -> CatThreadPoolColumn.Host
            | "ip" -> CatThreadPoolColumn.Ip
            | "keep_alive" -> CatThreadPoolColumn.KeepAlive
            | "largest" -> CatThreadPoolColumn.Largest
            | "max" -> CatThreadPoolColumn.Max
            | "name" -> CatThreadPoolColumn.Name
            | "node_id" -> CatThreadPoolColumn.NodeId
            | "node_name" -> CatThreadPoolColumn.NodeName
            | "pid" -> CatThreadPoolColumn.Pid
            | "pool_size" -> CatThreadPoolColumn.PoolSize
            | "port" -> CatThreadPoolColumn.Port
            | "queue" -> CatThreadPoolColumn.Queue
            | "queue_size" -> CatThreadPoolColumn.QueueSize
            | "rejected" -> CatThreadPoolColumn.Rejected
            | "size" -> CatThreadPoolColumn.Size
            | "type" -> CatThreadPoolColumn.Type
            | other -> CatThreadPoolColumn.Custom other

    type CatTrainedModelsColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTrainedModelsColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTrainedModelsColumn.CreateTime -> "create_time"
                | CatTrainedModelsColumn.CreatedBy -> "created_by"
                | CatTrainedModelsColumn.DataFrameAnalyticsId -> "data_frame_analytics_id"
                | CatTrainedModelsColumn.Description -> "description"
                | CatTrainedModelsColumn.HeapSize -> "heap_size"
                | CatTrainedModelsColumn.Id -> "id"
                | CatTrainedModelsColumn.IngestCount -> "ingest.count"
                | CatTrainedModelsColumn.IngestCurrent -> "ingest.current"
                | CatTrainedModelsColumn.IngestFailed -> "ingest.failed"
                | CatTrainedModelsColumn.IngestPipelines -> "ingest.pipelines"
                | CatTrainedModelsColumn.IngestTime -> "ingest.time"
                | CatTrainedModelsColumn.License -> "license"
                | CatTrainedModelsColumn.Operations -> "operations"
                | CatTrainedModelsColumn.Version -> "version"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "create_time" -> CatTrainedModelsColumn.CreateTime
            | "created_by" -> CatTrainedModelsColumn.CreatedBy
            | "data_frame_analytics_id" -> CatTrainedModelsColumn.DataFrameAnalyticsId
            | "description" -> CatTrainedModelsColumn.Description
            | "heap_size" -> CatTrainedModelsColumn.HeapSize
            | "id" -> CatTrainedModelsColumn.Id
            | "ingest.count" -> CatTrainedModelsColumn.IngestCount
            | "ingest.current" -> CatTrainedModelsColumn.IngestCurrent
            | "ingest.failed" -> CatTrainedModelsColumn.IngestFailed
            | "ingest.pipelines" -> CatTrainedModelsColumn.IngestPipelines
            | "ingest.time" -> CatTrainedModelsColumn.IngestTime
            | "license" -> CatTrainedModelsColumn.License
            | "operations" -> CatTrainedModelsColumn.Operations
            | "version" -> CatTrainedModelsColumn.Version
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CatTrainedModelsColumn"))

    type CatTransformColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTransformColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTransformColumn.ChangesLastDetectionTime -> "changes_last_detection_time"
                | CatTransformColumn.Checkpoint -> "checkpoint"
                | CatTransformColumn.CheckpointDurationTimeExpAvg -> "checkpoint_duration_time_exp_avg"
                | CatTransformColumn.CheckpointProgress -> "checkpoint_progress"
                | CatTransformColumn.CreateTime -> "create_time"
                | CatTransformColumn.DeleteTime -> "delete_time"
                | CatTransformColumn.Description -> "description"
                | CatTransformColumn.DestIndex -> "dest_index"
                | CatTransformColumn.DocumentsDeleted -> "documents_deleted"
                | CatTransformColumn.DocumentsIndexed -> "documents_indexed"
                | CatTransformColumn.DocsPerSecond -> "docs_per_second"
                | CatTransformColumn.DocumentsProcessed -> "documents_processed"
                | CatTransformColumn.Frequency -> "frequency"
                | CatTransformColumn.Id -> "id"
                | CatTransformColumn.IndexFailure -> "index_failure"
                | CatTransformColumn.IndexTime -> "index_time"
                | CatTransformColumn.IndexTotal -> "index_total"
                | CatTransformColumn.IndexedDocumentsExpAvg -> "indexed_documents_exp_avg"
                | CatTransformColumn.LastSearchTime -> "last_search_time"
                | CatTransformColumn.MaxPageSearchSize -> "max_page_search_size"
                | CatTransformColumn.PagesProcessed -> "pages_processed"
                | CatTransformColumn.Pipeline -> "pipeline"
                | CatTransformColumn.ProcessedDocumentsExpAvg -> "processed_documents_exp_avg"
                | CatTransformColumn.ProcessingTime -> "processing_time"
                | CatTransformColumn.Reason -> "reason"
                | CatTransformColumn.SearchFailure -> "search_failure"
                | CatTransformColumn.SearchTime -> "search_time"
                | CatTransformColumn.SearchTotal -> "search_total"
                | CatTransformColumn.SourceIndex -> "source_index"
                | CatTransformColumn.State -> "state"
                | CatTransformColumn.TransformType -> "transform_type"
                | CatTransformColumn.TriggerCount -> "trigger_count"
                | CatTransformColumn.Version -> "version"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "changes_last_detection_time" -> CatTransformColumn.ChangesLastDetectionTime
            | "checkpoint" -> CatTransformColumn.Checkpoint
            | "checkpoint_duration_time_exp_avg" -> CatTransformColumn.CheckpointDurationTimeExpAvg
            | "checkpoint_progress" -> CatTransformColumn.CheckpointProgress
            | "create_time" -> CatTransformColumn.CreateTime
            | "delete_time" -> CatTransformColumn.DeleteTime
            | "description" -> CatTransformColumn.Description
            | "dest_index" -> CatTransformColumn.DestIndex
            | "documents_deleted" -> CatTransformColumn.DocumentsDeleted
            | "documents_indexed" -> CatTransformColumn.DocumentsIndexed
            | "docs_per_second" -> CatTransformColumn.DocsPerSecond
            | "documents_processed" -> CatTransformColumn.DocumentsProcessed
            | "frequency" -> CatTransformColumn.Frequency
            | "id" -> CatTransformColumn.Id
            | "index_failure" -> CatTransformColumn.IndexFailure
            | "index_time" -> CatTransformColumn.IndexTime
            | "index_total" -> CatTransformColumn.IndexTotal
            | "indexed_documents_exp_avg" -> CatTransformColumn.IndexedDocumentsExpAvg
            | "last_search_time" -> CatTransformColumn.LastSearchTime
            | "max_page_search_size" -> CatTransformColumn.MaxPageSearchSize
            | "pages_processed" -> CatTransformColumn.PagesProcessed
            | "pipeline" -> CatTransformColumn.Pipeline
            | "processed_documents_exp_avg" -> CatTransformColumn.ProcessedDocumentsExpAvg
            | "processing_time" -> CatTransformColumn.ProcessingTime
            | "reason" -> CatTransformColumn.Reason
            | "search_failure" -> CatTransformColumn.SearchFailure
            | "search_time" -> CatTransformColumn.SearchTime
            | "search_total" -> CatTransformColumn.SearchTotal
            | "source_index" -> CatTransformColumn.SourceIndex
            | "state" -> CatTransformColumn.State
            | "transform_type" -> CatTransformColumn.TransformType
            | "trigger_count" -> CatTransformColumn.TriggerCount
            | "version" -> CatTransformColumn.Version
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CatTransformColumn"))

    type FollowerIndexStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<FollowerIndexStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | FollowerIndexStatus.Active -> "active"
                | FollowerIndexStatus.Paused -> "paused"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "active" -> FollowerIndexStatus.Active
            | "paused" -> FollowerIndexStatus.Paused
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FollowerIndexStatus"))

    type AllocationExplainDecisionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<AllocationExplainDecision>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | AllocationExplainDecision.NO -> "NO"
                | AllocationExplainDecision.YES -> "YES"
                | AllocationExplainDecision.THROTTLE -> "THROTTLE"
                | AllocationExplainDecision.ALWAYS -> "ALWAYS"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "NO" -> AllocationExplainDecision.NO
            | "YES" -> AllocationExplainDecision.YES
            | "THROTTLE" -> AllocationExplainDecision.THROTTLE
            | "ALWAYS" -> AllocationExplainDecision.ALWAYS
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AllocationExplainDecision"))

    type DecisionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Decision>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Decision.Yes -> "yes"
                | Decision.No -> "no"
                | Decision.WorseBalance -> "worse_balance"
                | Decision.Throttled -> "throttled"
                | Decision.AwaitingInfo -> "awaiting_info"
                | Decision.AllocationDelayed -> "allocation_delayed"
                | Decision.NoValidShardCopy -> "no_valid_shard_copy"
                | Decision.NoAttempt -> "no_attempt"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "yes" -> Decision.Yes
            | "no" -> Decision.No
            | "worse_balance" -> Decision.WorseBalance
            | "throttled" -> Decision.Throttled
            | "awaiting_info" -> Decision.AwaitingInfo
            | "allocation_delayed" -> Decision.AllocationDelayed
            | "no_valid_shard_copy" -> Decision.NoValidShardCopy
            | "no_attempt" -> Decision.NoAttempt
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Decision"))

    type UnassignedInformationReasonConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<UnassignedInformationReason>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | UnassignedInformationReason.INDEXCREATED -> "INDEX_CREATED"
                | UnassignedInformationReason.CLUSTERRECOVERED -> "CLUSTER_RECOVERED"
                | UnassignedInformationReason.INDEXREOPENED -> "INDEX_REOPENED"
                | UnassignedInformationReason.DANGLINGINDEXIMPORTED -> "DANGLING_INDEX_IMPORTED"
                | UnassignedInformationReason.NEWINDEXRESTORED -> "NEW_INDEX_RESTORED"
                | UnassignedInformationReason.EXISTINGINDEXRESTORED -> "EXISTING_INDEX_RESTORED"
                | UnassignedInformationReason.REPLICAADDED -> "REPLICA_ADDED"
                | UnassignedInformationReason.ALLOCATIONFAILED -> "ALLOCATION_FAILED"
                | UnassignedInformationReason.NODELEFT -> "NODE_LEFT"
                | UnassignedInformationReason.REROUTECANCELLED -> "REROUTE_CANCELLED"
                | UnassignedInformationReason.REINITIALIZED -> "REINITIALIZED"
                | UnassignedInformationReason.REALLOCATEDREPLICA -> "REALLOCATED_REPLICA"
                | UnassignedInformationReason.PRIMARYFAILED -> "PRIMARY_FAILED"
                | UnassignedInformationReason.FORCEDEMPTYPRIMARY -> "FORCED_EMPTY_PRIMARY"
                | UnassignedInformationReason.MANUALALLOCATION -> "MANUAL_ALLOCATION"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "INDEX_CREATED" -> UnassignedInformationReason.INDEXCREATED
            | "CLUSTER_RECOVERED" -> UnassignedInformationReason.CLUSTERRECOVERED
            | "INDEX_REOPENED" -> UnassignedInformationReason.INDEXREOPENED
            | "DANGLING_INDEX_IMPORTED" -> UnassignedInformationReason.DANGLINGINDEXIMPORTED
            | "NEW_INDEX_RESTORED" -> UnassignedInformationReason.NEWINDEXRESTORED
            | "EXISTING_INDEX_RESTORED" -> UnassignedInformationReason.EXISTINGINDEXRESTORED
            | "REPLICA_ADDED" -> UnassignedInformationReason.REPLICAADDED
            | "ALLOCATION_FAILED" -> UnassignedInformationReason.ALLOCATIONFAILED
            | "NODE_LEFT" -> UnassignedInformationReason.NODELEFT
            | "REROUTE_CANCELLED" -> UnassignedInformationReason.REROUTECANCELLED
            | "REINITIALIZED" -> UnassignedInformationReason.REINITIALIZED
            | "REALLOCATED_REPLICA" -> UnassignedInformationReason.REALLOCATEDREPLICA
            | "PRIMARY_FAILED" -> UnassignedInformationReason.PRIMARYFAILED
            | "FORCED_EMPTY_PRIMARY" -> UnassignedInformationReason.FORCEDEMPTYPRIMARY
            | "MANUAL_ALLOCATION" -> UnassignedInformationReason.MANUALALLOCATION
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for UnassignedInformationReason"))

    type ClusterRemoteInfoConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ClusterRemoteInfo>()

        override _.Write(writer, value, options) =
            match value with
            | ClusterRemoteInfo.ClusterRemoteSniffInfo v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ClusterRemoteInfo.ClusterRemoteProxyInfo v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(&reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("mode") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "clusterremotesniffinfo" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ClusterRemoteSniffInfo>(doc.RootElement.GetRawText(), options)
                ClusterRemoteInfo.ClusterRemoteSniffInfo v
            | "clusterremoteproxyinfo" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ClusterRemoteProxyInfo>(doc.RootElement.GetRawText(), options)
                ClusterRemoteInfo.ClusterRemoteProxyInfo v
            | other -> raise (System.Text.Json.JsonException($"Unknown tag value '{other}' for ClusterRemoteInfo"))

    type ClusterStateMetricConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ClusterStateMetric>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ClusterStateMetric.All -> "_all"
                | ClusterStateMetric.Version -> "version"
                | ClusterStateMetric.MasterNode -> "master_node"
                | ClusterStateMetric.Blocks -> "blocks"
                | ClusterStateMetric.Nodes -> "nodes"
                | ClusterStateMetric.Metadata -> "metadata"
                | ClusterStateMetric.RoutingTable -> "routing_table"
                | ClusterStateMetric.RoutingNodes -> "routing_nodes"
                | ClusterStateMetric.Customs -> "customs"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "_all" -> ClusterStateMetric.All
            | "version" -> ClusterStateMetric.Version
            | "master_node" -> ClusterStateMetric.MasterNode
            | "blocks" -> ClusterStateMetric.Blocks
            | "nodes" -> ClusterStateMetric.Nodes
            | "metadata" -> ClusterStateMetric.Metadata
            | "routing_table" -> ClusterStateMetric.RoutingTable
            | "routing_nodes" -> ClusterStateMetric.RoutingNodes
            | "customs" -> ClusterStateMetric.Customs
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ClusterStateMetric"))

    type ShardStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ShardState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ShardState.INIT -> "INIT"
                | ShardState.SUCCESS -> "SUCCESS"
                | ShardState.FAILED -> "FAILED"
                | ShardState.ABORTED -> "ABORTED"
                | ShardState.MISSING -> "MISSING"
                | ShardState.WAITING -> "WAITING"
                | ShardState.QUEUED -> "QUEUED"
                | ShardState.PAUSEDFORNODEREMOVAL -> "PAUSED_FOR_NODE_REMOVAL"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "INIT" -> ShardState.INIT
            | "SUCCESS" -> ShardState.SUCCESS
            | "FAILED" -> ShardState.FAILED
            | "ABORTED" -> ShardState.ABORTED
            | "MISSING" -> ShardState.MISSING
            | "WAITING" -> ShardState.WAITING
            | "QUEUED" -> ShardState.QUEUED
            | "PAUSED_FOR_NODE_REMOVAL" -> ShardState.PAUSEDFORNODEREMOVAL
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ShardState"))

    type SortTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SortType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SortType.Doc -> "_doc"
                | SortType.GeoDistance -> "_geo_distance"
                | SortType.Score -> "_score"
                | SortType.Script -> "_script"
                | SortType.FieldSort -> "field_sort"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "_doc" -> SortType.Doc
            | "_geo_distance" -> SortType.GeoDistance
            | "_score" -> SortType.Score
            | "_script" -> SortType.Script
            | "field_sort" -> SortType.FieldSort
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SortType"))

    type ConnectorFieldTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ConnectorFieldType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ConnectorFieldType.Str -> "str"
                | ConnectorFieldType.Int -> "int"
                | ConnectorFieldType.List -> "list"
                | ConnectorFieldType.Bool -> "bool"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "str" -> ConnectorFieldType.Str
            | "int" -> ConnectorFieldType.Int
            | "list" -> ConnectorFieldType.List
            | "bool" -> ConnectorFieldType.Bool
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ConnectorFieldType"))

    type ConnectorStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ConnectorStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ConnectorStatus.Created -> "created"
                | ConnectorStatus.NeedsConfiguration -> "needs_configuration"
                | ConnectorStatus.Configured -> "configured"
                | ConnectorStatus.Connected -> "connected"
                | ConnectorStatus.Error -> "error"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "created" -> ConnectorStatus.Created
            | "needs_configuration" -> ConnectorStatus.NeedsConfiguration
            | "configured" -> ConnectorStatus.Configured
            | "connected" -> ConnectorStatus.Connected
            | "error" -> ConnectorStatus.Error
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ConnectorStatus"))

    type DisplayTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DisplayType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | DisplayType.Textbox -> "textbox"
                | DisplayType.Textarea -> "textarea"
                | DisplayType.Numeric -> "numeric"
                | DisplayType.Toggle -> "toggle"
                | DisplayType.Dropdown -> "dropdown"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "textbox" -> DisplayType.Textbox
            | "textarea" -> DisplayType.Textarea
            | "numeric" -> DisplayType.Numeric
            | "toggle" -> DisplayType.Toggle
            | "dropdown" -> DisplayType.Dropdown
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DisplayType"))

    type FilteringPolicyConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<FilteringPolicy>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | FilteringPolicy.Exclude -> "exclude"
                | FilteringPolicy.Include -> "include"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "exclude" -> FilteringPolicy.Exclude
            | "include" -> FilteringPolicy.Include
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FilteringPolicy"))

    type FilteringRuleRuleConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<FilteringRuleRule>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | FilteringRuleRule.Contains -> "contains"
                | FilteringRuleRule.EndsWith -> "ends_with"
                | FilteringRuleRule.Equals -> "equals"
                | FilteringRuleRule.Regex -> "regex"
                | FilteringRuleRule.StartsWith -> "starts_with"
                | FilteringRuleRule.Gt -> ">"
                | FilteringRuleRule.Lt -> "<"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "contains" -> FilteringRuleRule.Contains
            | "ends_with" -> FilteringRuleRule.EndsWith
            | "equals" -> FilteringRuleRule.Equals
            | "regex" -> FilteringRuleRule.Regex
            | "starts_with" -> FilteringRuleRule.StartsWith
            | ">" -> FilteringRuleRule.Gt
            | "<" -> FilteringRuleRule.Lt
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FilteringRuleRule"))

    type FilteringValidationStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<FilteringValidationState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | FilteringValidationState.Edited -> "edited"
                | FilteringValidationState.Invalid -> "invalid"
                | FilteringValidationState.Valid -> "valid"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "edited" -> FilteringValidationState.Edited
            | "invalid" -> FilteringValidationState.Invalid
            | "valid" -> FilteringValidationState.Valid
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FilteringValidationState"))

    type SyncJobTriggerMethodConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SyncJobTriggerMethod>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SyncJobTriggerMethod.OnDemand -> "on_demand"
                | SyncJobTriggerMethod.Scheduled -> "scheduled"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "on_demand" -> SyncJobTriggerMethod.OnDemand
            | "scheduled" -> SyncJobTriggerMethod.Scheduled
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SyncJobTriggerMethod"))

    type SyncJobTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SyncJobType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SyncJobType.Full -> "full"
                | SyncJobType.Incremental -> "incremental"
                | SyncJobType.AccessControl -> "access_control"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "full" -> SyncJobType.Full
            | "incremental" -> SyncJobType.Incremental
            | "access_control" -> SyncJobType.AccessControl
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SyncJobType"))

    type SyncStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SyncStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SyncStatus.Canceling -> "canceling"
                | SyncStatus.Canceled -> "canceled"
                | SyncStatus.Completed -> "completed"
                | SyncStatus.Error -> "error"
                | SyncStatus.InProgress -> "in_progress"
                | SyncStatus.Pending -> "pending"
                | SyncStatus.Suspended -> "suspended"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "canceling" -> SyncStatus.Canceling
            | "canceled" -> SyncStatus.Canceled
            | "completed" -> SyncStatus.Completed
            | "error" -> SyncStatus.Error
            | "in_progress" -> SyncStatus.InProgress
            | "pending" -> SyncStatus.Pending
            | "suspended" -> SyncStatus.Suspended
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SyncStatus"))

    type ValidationConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Validation>()

        override _.Write(writer, value, options) =
            match value with
            | Validation.LessThanValidation v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Validation.GreaterThanValidation v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Validation.ListTypeValidation v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Validation.IncludedInValidation v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Validation.RegexValidation v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(&reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("type") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "lessthanvalidation" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.LessThanValidation>(doc.RootElement.GetRawText(), options)
                Validation.LessThanValidation v
            | "greaterthanvalidation" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.GreaterThanValidation>(doc.RootElement.GetRawText(), options)
                Validation.GreaterThanValidation v
            | "listtypevalidation" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ListTypeValidation>(doc.RootElement.GetRawText(), options)
                Validation.ListTypeValidation v
            | "includedinvalidation" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.IncludedInValidation>(doc.RootElement.GetRawText(), options)
                Validation.IncludedInValidation v
            | "regexvalidation" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.RegexValidation>(doc.RootElement.GetRawText(), options)
                Validation.RegexValidation v
            | other -> raise (System.Text.Json.JsonException($"Unknown tag value '{other}' for Validation"))

    type PolicyTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<PolicyType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | PolicyType.GeoMatch -> "geo_match"
                | PolicyType.Match -> "match"
                | PolicyType.Range -> "range"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "geo_match" -> PolicyType.GeoMatch
            | "match" -> PolicyType.Match
            | "range" -> PolicyType.Range
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for PolicyType"))

    type EnrichPolicyPhaseConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<EnrichPolicyPhase>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | EnrichPolicyPhase.SCHEDULED -> "SCHEDULED"
                | EnrichPolicyPhase.RUNNING -> "RUNNING"
                | EnrichPolicyPhase.COMPLETE -> "COMPLETE"
                | EnrichPolicyPhase.FAILED -> "FAILED"
                | EnrichPolicyPhase.CANCELLED -> "CANCELLED"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "SCHEDULED" -> EnrichPolicyPhase.SCHEDULED
            | "RUNNING" -> EnrichPolicyPhase.RUNNING
            | "COMPLETE" -> EnrichPolicyPhase.COMPLETE
            | "FAILED" -> EnrichPolicyPhase.FAILED
            | "CANCELLED" -> EnrichPolicyPhase.CANCELLED
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for EnrichPolicyPhase"))

    type ResultPositionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ResultPosition>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ResultPosition.Tail -> "tail"
                | ResultPosition.Head -> "head"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "tail" -> ResultPosition.Tail
            | "head" -> ResultPosition.Head
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ResultPosition"))

    type EsqlClusterStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<EsqlClusterStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | EsqlClusterStatus.Running -> "running"
                | EsqlClusterStatus.Successful -> "successful"
                | EsqlClusterStatus.Partial -> "partial"
                | EsqlClusterStatus.Skipped -> "skipped"
                | EsqlClusterStatus.Failed -> "failed"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "running" -> EsqlClusterStatus.Running
            | "successful" -> EsqlClusterStatus.Successful
            | "partial" -> EsqlClusterStatus.Partial
            | "skipped" -> EsqlClusterStatus.Skipped
            | "failed" -> EsqlClusterStatus.Failed
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for EsqlClusterStatus"))

    type EsqlFormatConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<EsqlFormat>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | EsqlFormat.Csv -> "csv"
                | EsqlFormat.Json -> "json"
                | EsqlFormat.Tsv -> "tsv"
                | EsqlFormat.Txt -> "txt"
                | EsqlFormat.Yaml -> "yaml"
                | EsqlFormat.Cbor -> "cbor"
                | EsqlFormat.Smile -> "smile"
                | EsqlFormat.Arrow -> "arrow"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "csv" -> EsqlFormat.Csv
            | "json" -> EsqlFormat.Json
            | "tsv" -> EsqlFormat.Tsv
            | "txt" -> EsqlFormat.Txt
            | "yaml" -> EsqlFormat.Yaml
            | "cbor" -> EsqlFormat.Cbor
            | "smile" -> EsqlFormat.Smile
            | "arrow" -> EsqlFormat.Arrow
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for EsqlFormat"))

    type TableValuesContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TableValuesContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | TableValuesContainer.Integer v ->
                writer.WritePropertyName("integer")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TableValuesContainer.Keyword v ->
                writer.WritePropertyName("keyword")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TableValuesContainer.Long v ->
                writer.WritePropertyName("long")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TableValuesContainer.Double v ->
                writer.WritePropertyName("double")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for TableValuesContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for TableValuesContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "integer" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TableValuesIntegerValue list>(&reader, options)
                    TableValuesContainer.Integer v
                | "keyword" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TableValuesKeywordValue list>(&reader, options)
                    TableValuesContainer.Keyword v
                | "long" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TableValuesLongValue list>(&reader, options)
                    TableValuesContainer.Long v
                | "double" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TableValuesLongDouble list>(&reader, options)
                    TableValuesContainer.Double v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for TableValuesContainer"))
            reader.Read() |> ignore // EndObject
            result

    type LifecycleExplainConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<LifecycleExplain>()

        override _.Write(writer, value, options) =
            match value with
            | LifecycleExplain.LifecycleExplainManaged v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | LifecycleExplain.LifecycleExplainUnmanaged v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(&reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("managed") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "lifecycleexplainmanaged" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.LifecycleExplainManaged>(doc.RootElement.GetRawText(), options)
                LifecycleExplain.LifecycleExplainManaged v
            | "lifecycleexplainunmanaged" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.LifecycleExplainUnmanaged>(doc.RootElement.GetRawText(), options)
                LifecycleExplain.LifecycleExplainUnmanaged v
            | other -> raise (System.Text.Json.JsonException($"Unknown tag value '{other}' for LifecycleExplain"))

    type IndexCheckOnStartupConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndexCheckOnStartup>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndexCheckOnStartup.True -> "true"
                | IndexCheckOnStartup.False -> "false"
                | IndexCheckOnStartup.Checksum -> "checksum"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "true" -> IndexCheckOnStartup.True
            | "false" -> IndexCheckOnStartup.False
            | "checksum" -> IndexCheckOnStartup.Checksum
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IndexCheckOnStartup"))

    type IndexModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndexMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndexMode.Standard -> "standard"
                | IndexMode.TimeSeries -> "time_series"
                | IndexMode.Logsdb -> "logsdb"
                | IndexMode.Lookup -> "lookup"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "standard" -> IndexMode.Standard
            | "time_series" -> IndexMode.TimeSeries
            | "logsdb" -> IndexMode.Logsdb
            | "lookup" -> IndexMode.Lookup
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IndexMode"))

    type IndexRoutingAllocationOptionsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndexRoutingAllocationOptions>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndexRoutingAllocationOptions.All -> "all"
                | IndexRoutingAllocationOptions.Primaries -> "primaries"
                | IndexRoutingAllocationOptions.NewPrimaries -> "new_primaries"
                | IndexRoutingAllocationOptions.None -> "none"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "all" -> IndexRoutingAllocationOptions.All
            | "primaries" -> IndexRoutingAllocationOptions.Primaries
            | "new_primaries" -> IndexRoutingAllocationOptions.NewPrimaries
            | "none" -> IndexRoutingAllocationOptions.None
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IndexRoutingAllocationOptions"))

    type IndexRoutingRebalanceOptionsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndexRoutingRebalanceOptions>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndexRoutingRebalanceOptions.All -> "all"
                | IndexRoutingRebalanceOptions.Primaries -> "primaries"
                | IndexRoutingRebalanceOptions.Replicas -> "replicas"
                | IndexRoutingRebalanceOptions.None -> "none"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "all" -> IndexRoutingRebalanceOptions.All
            | "primaries" -> IndexRoutingRebalanceOptions.Primaries
            | "replicas" -> IndexRoutingRebalanceOptions.Replicas
            | "none" -> IndexRoutingRebalanceOptions.None
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IndexRoutingRebalanceOptions"))

    type IndicesBlockOptionsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesBlockOptions>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicesBlockOptions.Metadata -> "metadata"
                | IndicesBlockOptions.Read -> "read"
                | IndicesBlockOptions.ReadOnly -> "read_only"
                | IndicesBlockOptions.Write -> "write"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "metadata" -> IndicesBlockOptions.Metadata
            | "read" -> IndicesBlockOptions.Read
            | "read_only" -> IndicesBlockOptions.ReadOnly
            | "write" -> IndicesBlockOptions.Write
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IndicesBlockOptions"))

    type ManagedByConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ManagedBy>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ManagedBy.IndexLifecycleManagement -> "Index Lifecycle Management"
                | ManagedBy.DataStreamLifecycle -> "Data stream lifecycle"
                | ManagedBy.Unmanaged -> "Unmanaged"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "Index Lifecycle Management" -> ManagedBy.IndexLifecycleManagement
            | "Data stream lifecycle" -> ManagedBy.DataStreamLifecycle
            | "Unmanaged" -> ManagedBy.Unmanaged
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ManagedBy"))

    type NumericFielddataFormatConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<NumericFielddataFormat>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | NumericFielddataFormat.Array -> "array"
                | NumericFielddataFormat.Disabled -> "disabled"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "array" -> NumericFielddataFormat.Array
            | "disabled" -> NumericFielddataFormat.Disabled
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for NumericFielddataFormat"))

    type SamplingMethodConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SamplingMethod>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SamplingMethod.Aggregate -> "aggregate"
                | SamplingMethod.LastValue -> "last_value"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "aggregate" -> SamplingMethod.Aggregate
            | "last_value" -> SamplingMethod.LastValue
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SamplingMethod"))

    type SegmentSortMissingConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SegmentSortMissing>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SegmentSortMissing.Last -> "_last"
                | SegmentSortMissing.First -> "_first"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "_last" -> SegmentSortMissing.Last
            | "_first" -> SegmentSortMissing.First
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SegmentSortMissing"))

    type SegmentSortModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SegmentSortMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SegmentSortMode.Min -> "min"
                | SegmentSortMode.Max -> "max"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "min" -> SegmentSortMode.Min
            | "max" -> SegmentSortMode.Max
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SegmentSortMode"))

    type SegmentSortOrderConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SegmentSortOrder>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SegmentSortOrder.Asc -> "asc"
                | SegmentSortOrder.Desc -> "desc"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "asc" -> SegmentSortOrder.Asc
            | "desc" -> SegmentSortOrder.Desc
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SegmentSortOrder"))

    type SettingsSimilarityConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SettingsSimilarity>()

        override _.Write(writer, value, options) =
            match value with
            | SettingsSimilarity.SettingsSimilarityBm25 v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SettingsSimilarity.SettingsSimilarityBoolean v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SettingsSimilarity.SettingsSimilarityDfi v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SettingsSimilarity.SettingsSimilarityDfr v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SettingsSimilarity.SettingsSimilarityIb v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SettingsSimilarity.SettingsSimilarityLmd v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SettingsSimilarity.SettingsSimilarityLmj v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SettingsSimilarity.SettingsSimilarityScripted v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SettingsSimilarity.Unknown (_, el) -> el.WriteTo(writer)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(&reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("type") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "settingssimilaritybm25" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SettingsSimilarityBm25>(doc.RootElement.GetRawText(), options)
                SettingsSimilarity.SettingsSimilarityBm25 v
            | "settingssimilarityboolean" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SettingsSimilarityBoolean>(doc.RootElement.GetRawText(), options)
                SettingsSimilarity.SettingsSimilarityBoolean v
            | "settingssimilaritydfi" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SettingsSimilarityDfi>(doc.RootElement.GetRawText(), options)
                SettingsSimilarity.SettingsSimilarityDfi v
            | "settingssimilaritydfr" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SettingsSimilarityDfr>(doc.RootElement.GetRawText(), options)
                SettingsSimilarity.SettingsSimilarityDfr v
            | "settingssimilarityib" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SettingsSimilarityIb>(doc.RootElement.GetRawText(), options)
                SettingsSimilarity.SettingsSimilarityIb v
            | "settingssimilaritylmd" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SettingsSimilarityLmd>(doc.RootElement.GetRawText(), options)
                SettingsSimilarity.SettingsSimilarityLmd v
            | "settingssimilaritylmj" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SettingsSimilarityLmj>(doc.RootElement.GetRawText(), options)
                SettingsSimilarity.SettingsSimilarityLmj v
            | "settingssimilarityscripted" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SettingsSimilarityScripted>(doc.RootElement.GetRawText(), options)
                SettingsSimilarity.SettingsSimilarityScripted v
            | _ -> SettingsSimilarity.Unknown (tagValue, doc.RootElement.Clone())

    type SourceModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SourceMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SourceMode.Disabled -> "disabled"
                | SourceMode.Stored -> "stored"
                | SourceMode.Synthetic -> "synthetic"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "disabled" -> SourceMode.Disabled
            | "stored" -> SourceMode.Stored
            | "synthetic" -> SourceMode.Synthetic
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SourceMode"))

    type StorageTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<StorageType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | StorageType.Fs -> "fs"
                | StorageType.Niofs -> "niofs"
                | StorageType.Mmapfs -> "mmapfs"
                | StorageType.Hybridfs -> "hybridfs"
                | StorageType.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "fs" -> StorageType.Fs
            | "niofs" -> StorageType.Niofs
            | "mmapfs" -> StorageType.Mmapfs
            | "hybridfs" -> StorageType.Hybridfs
            | other -> StorageType.Custom other

    type TranslogDurabilityConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TranslogDurability>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TranslogDurability.Request -> "request"
                | TranslogDurability.Async -> "async"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "request" -> TranslogDurability.Request
            | "async" -> TranslogDurability.Async
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TranslogDurability"))

    type IndicesGetFeatureConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesGetFeature>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicesGetFeature.Aliases -> "aliases"
                | IndicesGetFeature.Mappings -> "mappings"
                | IndicesGetFeature.Settings -> "settings"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "aliases" -> IndicesGetFeature.Aliases
            | "mappings" -> IndicesGetFeature.Mappings
            | "settings" -> IndicesGetFeature.Settings
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IndicesGetFeature"))

    type ModeEnumConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ModeEnum>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ModeEnum.Upgrade -> "upgrade"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "upgrade" -> ModeEnum.Upgrade
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ModeEnum"))

    type IndicesModifyDataStreamActionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesModifyDataStreamAction>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | IndicesModifyDataStreamAction.AddBackingIndex v ->
                writer.WritePropertyName("add_backing_index")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IndicesModifyDataStreamAction.RemoveBackingIndex v ->
                writer.WritePropertyName("remove_backing_index")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for IndicesModifyDataStreamAction"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for IndicesModifyDataStreamAction"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "add_backing_index" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IndexAndDataStreamAction>(&reader, options)
                    IndicesModifyDataStreamAction.AddBackingIndex v
                | "remove_backing_index" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IndexAndDataStreamAction>(&reader, options)
                    IndicesModifyDataStreamAction.RemoveBackingIndex v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for IndicesModifyDataStreamAction"))
            reader.Read() |> ignore // EndObject
            result

    type RecoveryStageConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<RecoveryStage>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | RecoveryStage.INIT -> "INIT"
                | RecoveryStage.INDEX -> "INDEX"
                | RecoveryStage.VERIFYINDEX -> "VERIFY_INDEX"
                | RecoveryStage.TRANSLOG -> "TRANSLOG"
                | RecoveryStage.FINALIZE -> "FINALIZE"
                | RecoveryStage.DONE -> "DONE"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "INIT" -> RecoveryStage.INIT
            | "INDEX" -> RecoveryStage.INDEX
            | "VERIFY_INDEX" -> RecoveryStage.VERIFYINDEX
            | "TRANSLOG" -> RecoveryStage.TRANSLOG
            | "FINALIZE" -> RecoveryStage.FINALIZE
            | "DONE" -> RecoveryStage.DONE
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for RecoveryStage"))

    type RecoveryTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<RecoveryType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | RecoveryType.EMPTYSTORE -> "EMPTY_STORE"
                | RecoveryType.EXISTINGSTORE -> "EXISTING_STORE"
                | RecoveryType.LOCALSHARDS -> "LOCAL_SHARDS"
                | RecoveryType.PEER -> "PEER"
                | RecoveryType.SNAPSHOT -> "SNAPSHOT"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "EMPTY_STORE" -> RecoveryType.EMPTYSTORE
            | "EXISTING_STORE" -> RecoveryType.EXISTINGSTORE
            | "LOCAL_SHARDS" -> RecoveryType.LOCALSHARDS
            | "PEER" -> RecoveryType.PEER
            | "SNAPSHOT" -> RecoveryType.SNAPSHOT
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for RecoveryType"))

    type ShardStoreAllocationConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ShardStoreAllocation>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ShardStoreAllocation.Primary -> "primary"
                | ShardStoreAllocation.Replica -> "replica"
                | ShardStoreAllocation.Unused -> "unused"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "primary" -> ShardStoreAllocation.Primary
            | "replica" -> ShardStoreAllocation.Replica
            | "unused" -> ShardStoreAllocation.Unused
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ShardStoreAllocation"))

    type ShardStoreStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ShardStoreStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ShardStoreStatus.Green -> "green"
                | ShardStoreStatus.Yellow -> "yellow"
                | ShardStoreStatus.Red -> "red"
                | ShardStoreStatus.All -> "all"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "green" -> ShardStoreStatus.Green
            | "yellow" -> ShardStoreStatus.Yellow
            | "red" -> ShardStoreStatus.Red
            | "all" -> ShardStoreStatus.All
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ShardStoreStatus"))

    type IndexMetadataStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndexMetadataState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndexMetadataState.Open -> "open"
                | IndexMetadataState.Close -> "close"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "open" -> IndexMetadataState.Open
            | "close" -> IndexMetadataState.Close
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IndexMetadataState"))

    type ShardRoutingStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ShardRoutingState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ShardRoutingState.UNASSIGNED -> "UNASSIGNED"
                | ShardRoutingState.INITIALIZING -> "INITIALIZING"
                | ShardRoutingState.STARTED -> "STARTED"
                | ShardRoutingState.RELOCATING -> "RELOCATING"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "UNASSIGNED" -> ShardRoutingState.UNASSIGNED
            | "INITIALIZING" -> ShardRoutingState.INITIALIZING
            | "STARTED" -> ShardRoutingState.STARTED
            | "RELOCATING" -> ShardRoutingState.RELOCATING
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ShardRoutingState"))

    type IndicesUpdateAliasesActionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesUpdateAliasesAction>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | IndicesUpdateAliasesAction.Add v ->
                writer.WritePropertyName("add")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IndicesUpdateAliasesAction.Remove v ->
                writer.WritePropertyName("remove")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IndicesUpdateAliasesAction.RemoveIndex v ->
                writer.WritePropertyName("remove_index")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for IndicesUpdateAliasesAction"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for IndicesUpdateAliasesAction"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "add" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.AddAction>(&reader, options)
                    IndicesUpdateAliasesAction.Add v
                | "remove" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RemoveAction>(&reader, options)
                    IndicesUpdateAliasesAction.Remove v
                | "remove_index" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RemoveIndexAction>(&reader, options)
                    IndicesUpdateAliasesAction.RemoveIndex v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for IndicesUpdateAliasesAction"))
            reader.Read() |> ignore // EndObject
            result

    type Ai21ServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Ai21ServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Ai21ServiceType.Ai21 -> "ai21"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "ai21" -> Ai21ServiceType.Ai21
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Ai21ServiceType"))

    type Ai21TaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Ai21TaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Ai21TaskType.Completion -> "completion"
                | Ai21TaskType.ChatCompletion -> "chat_completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "completion" -> Ai21TaskType.Completion
            | "chat_completion" -> Ai21TaskType.ChatCompletion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Ai21TaskType"))

    type AlibabaCloudServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<AlibabaCloudServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | AlibabaCloudServiceType.AlibabacloudAiSearch -> "alibabacloud-ai-search"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "alibabacloud-ai-search" -> AlibabaCloudServiceType.AlibabacloudAiSearch
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AlibabaCloudServiceType"))

    type AlibabaCloudTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<AlibabaCloudTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | AlibabaCloudTaskType.Completion -> "completion"
                | AlibabaCloudTaskType.Rerank -> "rerank"
                | AlibabaCloudTaskType.SparseEmbedding -> "sparse_embedding"
                | AlibabaCloudTaskType.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "completion" -> AlibabaCloudTaskType.Completion
            | "rerank" -> AlibabaCloudTaskType.Rerank
            | "sparse_embedding" -> AlibabaCloudTaskType.SparseEmbedding
            | "text_embedding" -> AlibabaCloudTaskType.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AlibabaCloudTaskType"))

    type AmazonBedrockServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<AmazonBedrockServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | AmazonBedrockServiceType.Amazonbedrock -> "amazonbedrock"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "amazonbedrock" -> AmazonBedrockServiceType.Amazonbedrock
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AmazonBedrockServiceType"))

    type AmazonBedrockTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<AmazonBedrockTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | AmazonBedrockTaskType.ChatCompletion -> "chat_completion"
                | AmazonBedrockTaskType.Completion -> "completion"
                | AmazonBedrockTaskType.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chat_completion" -> AmazonBedrockTaskType.ChatCompletion
            | "completion" -> AmazonBedrockTaskType.Completion
            | "text_embedding" -> AmazonBedrockTaskType.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AmazonBedrockTaskType"))

    type AmazonSageMakerApiConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<AmazonSageMakerApi>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | AmazonSageMakerApi.Openai -> "openai"
                | AmazonSageMakerApi.Elastic -> "elastic"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "openai" -> AmazonSageMakerApi.Openai
            | "elastic" -> AmazonSageMakerApi.Elastic
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AmazonSageMakerApi"))

    type AmazonSageMakerServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<AmazonSageMakerServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | AmazonSageMakerServiceType.AmazonSagemaker -> "amazon_sagemaker"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "amazon_sagemaker" -> AmazonSageMakerServiceType.AmazonSagemaker
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AmazonSageMakerServiceType"))

    type AnthropicServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<AnthropicServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | AnthropicServiceType.Anthropic -> "anthropic"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "anthropic" -> AnthropicServiceType.Anthropic
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AnthropicServiceType"))

    type AnthropicTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<AnthropicTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | AnthropicTaskType.Completion -> "completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "completion" -> AnthropicTaskType.Completion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AnthropicTaskType"))

    type AzureAiStudioServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<AzureAiStudioServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | AzureAiStudioServiceType.Azureaistudio -> "azureaistudio"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "azureaistudio" -> AzureAiStudioServiceType.Azureaistudio
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AzureAiStudioServiceType"))

    type AzureAiStudioTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<AzureAiStudioTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | AzureAiStudioTaskType.Completion -> "completion"
                | AzureAiStudioTaskType.Rerank -> "rerank"
                | AzureAiStudioTaskType.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "completion" -> AzureAiStudioTaskType.Completion
            | "rerank" -> AzureAiStudioTaskType.Rerank
            | "text_embedding" -> AzureAiStudioTaskType.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AzureAiStudioTaskType"))

    type AzureOpenAIServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<AzureOpenAIServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | AzureOpenAIServiceType.Azureopenai -> "azureopenai"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "azureopenai" -> AzureOpenAIServiceType.Azureopenai
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AzureOpenAIServiceType"))

    type AzureOpenAITaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<AzureOpenAITaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | AzureOpenAITaskType.Completion -> "completion"
                | AzureOpenAITaskType.ChatCompletion -> "chat_completion"
                | AzureOpenAITaskType.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "completion" -> AzureOpenAITaskType.Completion
            | "chat_completion" -> AzureOpenAITaskType.ChatCompletion
            | "text_embedding" -> AzureOpenAITaskType.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AzureOpenAITaskType"))

    type CohereEmbeddingTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CohereEmbeddingType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CohereEmbeddingType.Binary -> "binary"
                | CohereEmbeddingType.Bit -> "bit"
                | CohereEmbeddingType.Byte -> "byte"
                | CohereEmbeddingType.Float -> "float"
                | CohereEmbeddingType.Int8 -> "int8"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "binary" -> CohereEmbeddingType.Binary
            | "bit" -> CohereEmbeddingType.Bit
            | "byte" -> CohereEmbeddingType.Byte
            | "float" -> CohereEmbeddingType.Float
            | "int8" -> CohereEmbeddingType.Int8
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CohereEmbeddingType"))

    type CohereInputTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CohereInputType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CohereInputType.Classification -> "classification"
                | CohereInputType.Clustering -> "clustering"
                | CohereInputType.Ingest -> "ingest"
                | CohereInputType.Search -> "search"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "classification" -> CohereInputType.Classification
            | "clustering" -> CohereInputType.Clustering
            | "ingest" -> CohereInputType.Ingest
            | "search" -> CohereInputType.Search
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CohereInputType"))

    type CohereServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CohereServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CohereServiceType.Cohere -> "cohere"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cohere" -> CohereServiceType.Cohere
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CohereServiceType"))

    type CohereSimilarityTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CohereSimilarityType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CohereSimilarityType.Cosine -> "cosine"
                | CohereSimilarityType.DotProduct -> "dot_product"
                | CohereSimilarityType.L2Norm -> "l2_norm"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cosine" -> CohereSimilarityType.Cosine
            | "dot_product" -> CohereSimilarityType.DotProduct
            | "l2_norm" -> CohereSimilarityType.L2Norm
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CohereSimilarityType"))

    type CohereTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CohereTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CohereTaskType.Completion -> "completion"
                | CohereTaskType.Rerank -> "rerank"
                | CohereTaskType.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "completion" -> CohereTaskType.Completion
            | "rerank" -> CohereTaskType.Rerank
            | "text_embedding" -> CohereTaskType.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CohereTaskType"))

    type CohereTruncateTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CohereTruncateType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CohereTruncateType.END -> "END"
                | CohereTruncateType.NONE -> "NONE"
                | CohereTruncateType.START -> "START"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "END" -> CohereTruncateType.END
            | "NONE" -> CohereTruncateType.NONE
            | "START" -> CohereTruncateType.START
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CohereTruncateType"))

    type ContentTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ContentType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ContentType.Text -> "text"
                | ContentType.ImageUrl -> "image_url"
                | ContentType.File -> "file"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text" -> ContentType.Text
            | "image_url" -> ContentType.ImageUrl
            | "file" -> ContentType.File
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ContentType"))

    type ContextualAIServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ContextualAIServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ContextualAIServiceType.Contextualai -> "contextualai"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "contextualai" -> ContextualAIServiceType.Contextualai
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ContextualAIServiceType"))

    type CustomServiceInputTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CustomServiceInputType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CustomServiceInputType.Classification -> "classification"
                | CustomServiceInputType.Clustering -> "clustering"
                | CustomServiceInputType.Ingest -> "ingest"
                | CustomServiceInputType.Search -> "search"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "classification" -> CustomServiceInputType.Classification
            | "clustering" -> CustomServiceInputType.Clustering
            | "ingest" -> CustomServiceInputType.Ingest
            | "search" -> CustomServiceInputType.Search
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CustomServiceInputType"))

    type CustomServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CustomServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CustomServiceType.Custom -> "custom"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "custom" -> CustomServiceType.Custom
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CustomServiceType"))

    type CustomTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CustomTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CustomTaskType.TextEmbedding -> "text_embedding"
                | CustomTaskType.SparseEmbedding -> "sparse_embedding"
                | CustomTaskType.Rerank -> "rerank"
                | CustomTaskType.Completion -> "completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> CustomTaskType.TextEmbedding
            | "sparse_embedding" -> CustomTaskType.SparseEmbedding
            | "rerank" -> CustomTaskType.Rerank
            | "completion" -> CustomTaskType.Completion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CustomTaskType"))

    type DeepSeekServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DeepSeekServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | DeepSeekServiceType.Deepseek -> "deepseek"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "deepseek" -> DeepSeekServiceType.Deepseek
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DeepSeekServiceType"))

    type ElasticsearchServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ElasticsearchServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ElasticsearchServiceType.Elasticsearch -> "elasticsearch"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "elasticsearch" -> ElasticsearchServiceType.Elasticsearch
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ElasticsearchServiceType"))

    type ElasticsearchTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ElasticsearchTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ElasticsearchTaskType.Rerank -> "rerank"
                | ElasticsearchTaskType.SparseEmbedding -> "sparse_embedding"
                | ElasticsearchTaskType.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "rerank" -> ElasticsearchTaskType.Rerank
            | "sparse_embedding" -> ElasticsearchTaskType.SparseEmbedding
            | "text_embedding" -> ElasticsearchTaskType.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ElasticsearchTaskType"))

    type ElserServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ElserServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ElserServiceType.Elser -> "elser"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "elser" -> ElserServiceType.Elser
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ElserServiceType"))

    type ElserTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ElserTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ElserTaskType.SparseEmbedding -> "sparse_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "sparse_embedding" -> ElserTaskType.SparseEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ElserTaskType"))

    type EmbeddingContentFormatConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<EmbeddingContentFormat>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | EmbeddingContentFormat.Text -> "text"
                | EmbeddingContentFormat.Base64 -> "base64"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text" -> EmbeddingContentFormat.Text
            | "base64" -> EmbeddingContentFormat.Base64
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for EmbeddingContentFormat"))

    type EmbeddingContentTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<EmbeddingContentType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | EmbeddingContentType.Text -> "text"
                | EmbeddingContentType.Image -> "image"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text" -> EmbeddingContentType.Text
            | "image" -> EmbeddingContentType.Image
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for EmbeddingContentType"))

    type EmbeddingInferenceResultConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<EmbeddingInferenceResult>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | EmbeddingInferenceResult.EmbeddingsBytes v ->
                writer.WritePropertyName("embeddings_bytes")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | EmbeddingInferenceResult.EmbeddingsBits v ->
                writer.WritePropertyName("embeddings_bits")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | EmbeddingInferenceResult.Embeddings v ->
                writer.WritePropertyName("embeddings")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for EmbeddingInferenceResult"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for EmbeddingInferenceResult"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "embeddings_bytes" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DenseEmbeddingByteResult list>(&reader, options)
                    EmbeddingInferenceResult.EmbeddingsBytes v
                | "embeddings_bits" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DenseEmbeddingByteResult list>(&reader, options)
                    EmbeddingInferenceResult.EmbeddingsBits v
                | "embeddings" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DenseEmbeddingResult list>(&reader, options)
                    EmbeddingInferenceResult.Embeddings v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for EmbeddingInferenceResult"))
            reader.Read() |> ignore // EndObject
            result

    type FireworksAIServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<FireworksAIServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | FireworksAIServiceType.Fireworksai -> "fireworksai"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "fireworksai" -> FireworksAIServiceType.Fireworksai
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FireworksAIServiceType"))

    type FireworksAISimilarityTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<FireworksAISimilarityType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | FireworksAISimilarityType.Cosine -> "cosine"
                | FireworksAISimilarityType.DotProduct -> "dot_product"
                | FireworksAISimilarityType.L2Norm -> "l2_norm"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cosine" -> FireworksAISimilarityType.Cosine
            | "dot_product" -> FireworksAISimilarityType.DotProduct
            | "l2_norm" -> FireworksAISimilarityType.L2Norm
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FireworksAISimilarityType"))

    type FireworksAITaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<FireworksAITaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | FireworksAITaskType.ChatCompletion -> "chat_completion"
                | FireworksAITaskType.Completion -> "completion"
                | FireworksAITaskType.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chat_completion" -> FireworksAITaskType.ChatCompletion
            | "completion" -> FireworksAITaskType.Completion
            | "text_embedding" -> FireworksAITaskType.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FireworksAITaskType"))

    type GoogleAiServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GoogleAiServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GoogleAiServiceType.Googleaistudio -> "googleaistudio"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "googleaistudio" -> GoogleAiServiceType.Googleaistudio
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GoogleAiServiceType"))

    type GoogleAiStudioTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GoogleAiStudioTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GoogleAiStudioTaskType.Completion -> "completion"
                | GoogleAiStudioTaskType.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "completion" -> GoogleAiStudioTaskType.Completion
            | "text_embedding" -> GoogleAiStudioTaskType.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GoogleAiStudioTaskType"))

    type GoogleModelGardenProviderConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GoogleModelGardenProvider>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GoogleModelGardenProvider.Google -> "google"
                | GoogleModelGardenProvider.Anthropic -> "anthropic"
                | GoogleModelGardenProvider.Meta -> "meta"
                | GoogleModelGardenProvider.HuggingFace -> "hugging_face"
                | GoogleModelGardenProvider.Mistral -> "mistral"
                | GoogleModelGardenProvider.Ai21 -> "ai21"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "google" -> GoogleModelGardenProvider.Google
            | "anthropic" -> GoogleModelGardenProvider.Anthropic
            | "meta" -> GoogleModelGardenProvider.Meta
            | "hugging_face" -> GoogleModelGardenProvider.HuggingFace
            | "mistral" -> GoogleModelGardenProvider.Mistral
            | "ai21" -> GoogleModelGardenProvider.Ai21
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GoogleModelGardenProvider"))

    type GoogleVertexAIServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GoogleVertexAIServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GoogleVertexAIServiceType.Googlevertexai -> "googlevertexai"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "googlevertexai" -> GoogleVertexAIServiceType.Googlevertexai
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GoogleVertexAIServiceType"))

    type GoogleVertexAITaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GoogleVertexAITaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GoogleVertexAITaskType.Rerank -> "rerank"
                | GoogleVertexAITaskType.TextEmbedding -> "text_embedding"
                | GoogleVertexAITaskType.Completion -> "completion"
                | GoogleVertexAITaskType.ChatCompletion -> "chat_completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "rerank" -> GoogleVertexAITaskType.Rerank
            | "text_embedding" -> GoogleVertexAITaskType.TextEmbedding
            | "completion" -> GoogleVertexAITaskType.Completion
            | "chat_completion" -> GoogleVertexAITaskType.ChatCompletion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GoogleVertexAITaskType"))

    type GroqServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GroqServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GroqServiceType.Groq -> "groq"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "groq" -> GroqServiceType.Groq
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GroqServiceType"))

    type GroqTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GroqTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GroqTaskType.ChatCompletion -> "chat_completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chat_completion" -> GroqTaskType.ChatCompletion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GroqTaskType"))

    type HuggingFaceServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<HuggingFaceServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | HuggingFaceServiceType.HuggingFace -> "hugging_face"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "hugging_face" -> HuggingFaceServiceType.HuggingFace
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for HuggingFaceServiceType"))

    type HuggingFaceTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<HuggingFaceTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | HuggingFaceTaskType.ChatCompletion -> "chat_completion"
                | HuggingFaceTaskType.Completion -> "completion"
                | HuggingFaceTaskType.Rerank -> "rerank"
                | HuggingFaceTaskType.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chat_completion" -> HuggingFaceTaskType.ChatCompletion
            | "completion" -> HuggingFaceTaskType.Completion
            | "rerank" -> HuggingFaceTaskType.Rerank
            | "text_embedding" -> HuggingFaceTaskType.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for HuggingFaceTaskType"))

    type ImageUrlDetailConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ImageUrlDetail>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ImageUrlDetail.Auto -> "auto"
                | ImageUrlDetail.Low -> "low"
                | ImageUrlDetail.High -> "high"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "auto" -> ImageUrlDetail.Auto
            | "low" -> ImageUrlDetail.Low
            | "high" -> ImageUrlDetail.High
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ImageUrlDetail"))

    type InferenceResultConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceResult>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | InferenceResult.EmbeddingsBytes v ->
                writer.WritePropertyName("embeddings_bytes")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceResult.EmbeddingsBits v ->
                writer.WritePropertyName("embeddings_bits")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceResult.Embeddings v ->
                writer.WritePropertyName("embeddings")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceResult.TextEmbeddingBytes v ->
                writer.WritePropertyName("text_embedding_bytes")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceResult.TextEmbeddingBits v ->
                writer.WritePropertyName("text_embedding_bits")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceResult.TextEmbedding v ->
                writer.WritePropertyName("text_embedding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceResult.SparseEmbedding v ->
                writer.WritePropertyName("sparse_embedding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceResult.Completion v ->
                writer.WritePropertyName("completion")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceResult.Rerank v ->
                writer.WritePropertyName("rerank")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for InferenceResult"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for InferenceResult"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "embeddings_bytes" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DenseEmbeddingByteResult list>(&reader, options)
                    InferenceResult.EmbeddingsBytes v
                | "embeddings_bits" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DenseEmbeddingByteResult list>(&reader, options)
                    InferenceResult.EmbeddingsBits v
                | "embeddings" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DenseEmbeddingResult list>(&reader, options)
                    InferenceResult.Embeddings v
                | "text_embedding_bytes" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DenseEmbeddingByteResult list>(&reader, options)
                    InferenceResult.TextEmbeddingBytes v
                | "text_embedding_bits" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DenseEmbeddingByteResult list>(&reader, options)
                    InferenceResult.TextEmbeddingBits v
                | "text_embedding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DenseEmbeddingResult list>(&reader, options)
                    InferenceResult.TextEmbedding v
                | "sparse_embedding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SparseEmbeddingResult list>(&reader, options)
                    InferenceResult.SparseEmbedding v
                | "completion" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.CompletionResult list>(&reader, options)
                    InferenceResult.Completion v
                | "rerank" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RankedDocument list>(&reader, options)
                    InferenceResult.Rerank v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for InferenceResult"))
            reader.Read() |> ignore // EndObject
            result

    type JinaAIElementTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<JinaAIElementType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | JinaAIElementType.Binary -> "binary"
                | JinaAIElementType.Bit -> "bit"
                | JinaAIElementType.Float -> "float"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "binary" -> JinaAIElementType.Binary
            | "bit" -> JinaAIElementType.Bit
            | "float" -> JinaAIElementType.Float
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for JinaAIElementType"))

    type JinaAIServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<JinaAIServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | JinaAIServiceType.Jinaai -> "jinaai"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "jinaai" -> JinaAIServiceType.Jinaai
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for JinaAIServiceType"))

    type JinaAISimilarityTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<JinaAISimilarityType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | JinaAISimilarityType.Cosine -> "cosine"
                | JinaAISimilarityType.DotProduct -> "dot_product"
                | JinaAISimilarityType.L2Norm -> "l2_norm"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cosine" -> JinaAISimilarityType.Cosine
            | "dot_product" -> JinaAISimilarityType.DotProduct
            | "l2_norm" -> JinaAISimilarityType.L2Norm
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for JinaAISimilarityType"))

    type JinaAITaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<JinaAITaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | JinaAITaskType.Embedding -> "embedding"
                | JinaAITaskType.Rerank -> "rerank"
                | JinaAITaskType.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "embedding" -> JinaAITaskType.Embedding
            | "rerank" -> JinaAITaskType.Rerank
            | "text_embedding" -> JinaAITaskType.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for JinaAITaskType"))

    type JinaAITextEmbeddingTaskConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<JinaAITextEmbeddingTask>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | JinaAITextEmbeddingTask.Classification -> "classification"
                | JinaAITextEmbeddingTask.Clustering -> "clustering"
                | JinaAITextEmbeddingTask.Ingest -> "ingest"
                | JinaAITextEmbeddingTask.Search -> "search"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "classification" -> JinaAITextEmbeddingTask.Classification
            | "clustering" -> JinaAITextEmbeddingTask.Clustering
            | "ingest" -> JinaAITextEmbeddingTask.Ingest
            | "search" -> JinaAITextEmbeddingTask.Search
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for JinaAITextEmbeddingTask"))

    type LlamaServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<LlamaServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | LlamaServiceType.Llama -> "llama"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "llama" -> LlamaServiceType.Llama
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for LlamaServiceType"))

    type LlamaSimilarityTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<LlamaSimilarityType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | LlamaSimilarityType.Cosine -> "cosine"
                | LlamaSimilarityType.DotProduct -> "dot_product"
                | LlamaSimilarityType.L2Norm -> "l2_norm"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cosine" -> LlamaSimilarityType.Cosine
            | "dot_product" -> LlamaSimilarityType.DotProduct
            | "l2_norm" -> LlamaSimilarityType.L2Norm
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for LlamaSimilarityType"))

    type LlamaTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<LlamaTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | LlamaTaskType.TextEmbedding -> "text_embedding"
                | LlamaTaskType.Completion -> "completion"
                | LlamaTaskType.ChatCompletion -> "chat_completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> LlamaTaskType.TextEmbedding
            | "completion" -> LlamaTaskType.Completion
            | "chat_completion" -> LlamaTaskType.ChatCompletion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for LlamaTaskType"))

    type MistralServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MistralServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MistralServiceType.Mistral -> "mistral"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "mistral" -> MistralServiceType.Mistral
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for MistralServiceType"))

    type MistralTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MistralTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MistralTaskType.TextEmbedding -> "text_embedding"
                | MistralTaskType.Completion -> "completion"
                | MistralTaskType.ChatCompletion -> "chat_completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> MistralTaskType.TextEmbedding
            | "completion" -> MistralTaskType.Completion
            | "chat_completion" -> MistralTaskType.ChatCompletion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for MistralTaskType"))

    type NvidiaInputTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<NvidiaInputType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | NvidiaInputType.Ingest -> "ingest"
                | NvidiaInputType.Search -> "search"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "ingest" -> NvidiaInputType.Ingest
            | "search" -> NvidiaInputType.Search
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for NvidiaInputType"))

    type NvidiaServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<NvidiaServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | NvidiaServiceType.Nvidia -> "nvidia"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "nvidia" -> NvidiaServiceType.Nvidia
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for NvidiaServiceType"))

    type NvidiaSimilarityTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<NvidiaSimilarityType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | NvidiaSimilarityType.Cosine -> "cosine"
                | NvidiaSimilarityType.DotProduct -> "dot_product"
                | NvidiaSimilarityType.L2Norm -> "l2_norm"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cosine" -> NvidiaSimilarityType.Cosine
            | "dot_product" -> NvidiaSimilarityType.DotProduct
            | "l2_norm" -> NvidiaSimilarityType.L2Norm
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for NvidiaSimilarityType"))

    type NvidiaTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<NvidiaTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | NvidiaTaskType.ChatCompletion -> "chat_completion"
                | NvidiaTaskType.Completion -> "completion"
                | NvidiaTaskType.Rerank -> "rerank"
                | NvidiaTaskType.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chat_completion" -> NvidiaTaskType.ChatCompletion
            | "completion" -> NvidiaTaskType.Completion
            | "rerank" -> NvidiaTaskType.Rerank
            | "text_embedding" -> NvidiaTaskType.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for NvidiaTaskType"))

    type OpenAIServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<OpenAIServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | OpenAIServiceType.Openai -> "openai"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "openai" -> OpenAIServiceType.Openai
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for OpenAIServiceType"))

    type OpenAISimilarityTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<OpenAISimilarityType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | OpenAISimilarityType.Cosine -> "cosine"
                | OpenAISimilarityType.DotProduct -> "dot_product"
                | OpenAISimilarityType.L2Norm -> "l2_norm"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cosine" -> OpenAISimilarityType.Cosine
            | "dot_product" -> OpenAISimilarityType.DotProduct
            | "l2_norm" -> OpenAISimilarityType.L2Norm
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for OpenAISimilarityType"))

    type OpenAITaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<OpenAITaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | OpenAITaskType.ChatCompletion -> "chat_completion"
                | OpenAITaskType.Completion -> "completion"
                | OpenAITaskType.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chat_completion" -> OpenAITaskType.ChatCompletion
            | "completion" -> OpenAITaskType.Completion
            | "text_embedding" -> OpenAITaskType.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for OpenAITaskType"))

    type OpenShiftAiServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<OpenShiftAiServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | OpenShiftAiServiceType.OpenshiftAi -> "openshift_ai"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "openshift_ai" -> OpenShiftAiServiceType.OpenshiftAi
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for OpenShiftAiServiceType"))

    type OpenShiftAiSimilarityTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<OpenShiftAiSimilarityType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | OpenShiftAiSimilarityType.Cosine -> "cosine"
                | OpenShiftAiSimilarityType.DotProduct -> "dot_product"
                | OpenShiftAiSimilarityType.L2Norm -> "l2_norm"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cosine" -> OpenShiftAiSimilarityType.Cosine
            | "dot_product" -> OpenShiftAiSimilarityType.DotProduct
            | "l2_norm" -> OpenShiftAiSimilarityType.L2Norm
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for OpenShiftAiSimilarityType"))

    type OpenShiftAiTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<OpenShiftAiTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | OpenShiftAiTaskType.TextEmbedding -> "text_embedding"
                | OpenShiftAiTaskType.Completion -> "completion"
                | OpenShiftAiTaskType.ChatCompletion -> "chat_completion"
                | OpenShiftAiTaskType.Rerank -> "rerank"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> OpenShiftAiTaskType.TextEmbedding
            | "completion" -> OpenShiftAiTaskType.Completion
            | "chat_completion" -> OpenShiftAiTaskType.ChatCompletion
            | "rerank" -> OpenShiftAiTaskType.Rerank
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for OpenShiftAiTaskType"))

    type ReasoningDetailConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ReasoningDetail>()

        override _.Write(writer, value, options) =
            match value with
            | ReasoningDetail.EncryptedReasoningDetail v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ReasoningDetail.SummaryReasoningDetail v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ReasoningDetail.TextReasoningDetail v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(&reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("type") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "encryptedreasoningdetail" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.EncryptedReasoningDetail>(doc.RootElement.GetRawText(), options)
                ReasoningDetail.EncryptedReasoningDetail v
            | "summaryreasoningdetail" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SummaryReasoningDetail>(doc.RootElement.GetRawText(), options)
                ReasoningDetail.SummaryReasoningDetail v
            | "textreasoningdetail" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.TextReasoningDetail>(doc.RootElement.GetRawText(), options)
                ReasoningDetail.TextReasoningDetail v
            | other -> raise (System.Text.Json.JsonException($"Unknown tag value '{other}' for ReasoningDetail"))

    type ReasoningEffortConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ReasoningEffort>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ReasoningEffort.Xhigh -> "xhigh"
                | ReasoningEffort.High -> "high"
                | ReasoningEffort.Medium -> "medium"
                | ReasoningEffort.Low -> "low"
                | ReasoningEffort.Minimal -> "minimal"
                | ReasoningEffort.None -> "none"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "xhigh" -> ReasoningEffort.Xhigh
            | "high" -> ReasoningEffort.High
            | "medium" -> ReasoningEffort.Medium
            | "low" -> ReasoningEffort.Low
            | "minimal" -> ReasoningEffort.Minimal
            | "none" -> ReasoningEffort.None
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ReasoningEffort"))

    type ReasoningSummaryConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ReasoningSummary>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ReasoningSummary.Auto -> "auto"
                | ReasoningSummary.Concise -> "concise"
                | ReasoningSummary.Detailed -> "detailed"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "auto" -> ReasoningSummary.Auto
            | "concise" -> ReasoningSummary.Concise
            | "detailed" -> ReasoningSummary.Detailed
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ReasoningSummary"))

    type TaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskType.SparseEmbedding -> "sparse_embedding"
                | TaskType.TextEmbedding -> "text_embedding"
                | TaskType.Rerank -> "rerank"
                | TaskType.Completion -> "completion"
                | TaskType.ChatCompletion -> "chat_completion"
                | TaskType.Embedding -> "embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "sparse_embedding" -> TaskType.SparseEmbedding
            | "text_embedding" -> TaskType.TextEmbedding
            | "rerank" -> TaskType.Rerank
            | "completion" -> TaskType.Completion
            | "chat_completion" -> TaskType.ChatCompletion
            | "embedding" -> TaskType.Embedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskType"))

    type TaskTypeAi21Converter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeAi21>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeAi21.Completion -> "completion"
                | TaskTypeAi21.ChatCompletion -> "chat_completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "completion" -> TaskTypeAi21.Completion
            | "chat_completion" -> TaskTypeAi21.ChatCompletion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeAi21"))

    type TaskTypeAlibabaCloudAIConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeAlibabaCloudAI>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeAlibabaCloudAI.TextEmbedding -> "text_embedding"
                | TaskTypeAlibabaCloudAI.Rerank -> "rerank"
                | TaskTypeAlibabaCloudAI.Completion -> "completion"
                | TaskTypeAlibabaCloudAI.SparseEmbedding -> "sparse_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> TaskTypeAlibabaCloudAI.TextEmbedding
            | "rerank" -> TaskTypeAlibabaCloudAI.Rerank
            | "completion" -> TaskTypeAlibabaCloudAI.Completion
            | "sparse_embedding" -> TaskTypeAlibabaCloudAI.SparseEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeAlibabaCloudAI"))

    type TaskTypeAmazonBedrockConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeAmazonBedrock>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeAmazonBedrock.ChatCompletion -> "chat_completion"
                | TaskTypeAmazonBedrock.Completion -> "completion"
                | TaskTypeAmazonBedrock.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chat_completion" -> TaskTypeAmazonBedrock.ChatCompletion
            | "completion" -> TaskTypeAmazonBedrock.Completion
            | "text_embedding" -> TaskTypeAmazonBedrock.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeAmazonBedrock"))

    type TaskTypeAmazonSageMakerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeAmazonSageMaker>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeAmazonSageMaker.TextEmbedding -> "text_embedding"
                | TaskTypeAmazonSageMaker.Completion -> "completion"
                | TaskTypeAmazonSageMaker.ChatCompletion -> "chat_completion"
                | TaskTypeAmazonSageMaker.SparseEmbedding -> "sparse_embedding"
                | TaskTypeAmazonSageMaker.Rerank -> "rerank"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> TaskTypeAmazonSageMaker.TextEmbedding
            | "completion" -> TaskTypeAmazonSageMaker.Completion
            | "chat_completion" -> TaskTypeAmazonSageMaker.ChatCompletion
            | "sparse_embedding" -> TaskTypeAmazonSageMaker.SparseEmbedding
            | "rerank" -> TaskTypeAmazonSageMaker.Rerank
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeAmazonSageMaker"))

    type TaskTypeAnthropicConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeAnthropic>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeAnthropic.Completion -> "completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "completion" -> TaskTypeAnthropic.Completion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeAnthropic"))

    type TaskTypeAzureAIStudioConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeAzureAIStudio>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeAzureAIStudio.TextEmbedding -> "text_embedding"
                | TaskTypeAzureAIStudio.Completion -> "completion"
                | TaskTypeAzureAIStudio.Rerank -> "rerank"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> TaskTypeAzureAIStudio.TextEmbedding
            | "completion" -> TaskTypeAzureAIStudio.Completion
            | "rerank" -> TaskTypeAzureAIStudio.Rerank
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeAzureAIStudio"))

    type TaskTypeAzureOpenAIConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeAzureOpenAI>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeAzureOpenAI.TextEmbedding -> "text_embedding"
                | TaskTypeAzureOpenAI.Completion -> "completion"
                | TaskTypeAzureOpenAI.ChatCompletion -> "chat_completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> TaskTypeAzureOpenAI.TextEmbedding
            | "completion" -> TaskTypeAzureOpenAI.Completion
            | "chat_completion" -> TaskTypeAzureOpenAI.ChatCompletion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeAzureOpenAI"))

    type TaskTypeCohereConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeCohere>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeCohere.TextEmbedding -> "text_embedding"
                | TaskTypeCohere.Rerank -> "rerank"
                | TaskTypeCohere.Completion -> "completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> TaskTypeCohere.TextEmbedding
            | "rerank" -> TaskTypeCohere.Rerank
            | "completion" -> TaskTypeCohere.Completion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeCohere"))

    type TaskTypeContextualAIConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeContextualAI>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeContextualAI.Rerank -> "rerank"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "rerank" -> TaskTypeContextualAI.Rerank
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeContextualAI"))

    type TaskTypeCustomConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeCustom>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeCustom.TextEmbedding -> "text_embedding"
                | TaskTypeCustom.SparseEmbedding -> "sparse_embedding"
                | TaskTypeCustom.Rerank -> "rerank"
                | TaskTypeCustom.Completion -> "completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> TaskTypeCustom.TextEmbedding
            | "sparse_embedding" -> TaskTypeCustom.SparseEmbedding
            | "rerank" -> TaskTypeCustom.Rerank
            | "completion" -> TaskTypeCustom.Completion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeCustom"))

    type TaskTypeDeepSeekConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeDeepSeek>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeDeepSeek.Completion -> "completion"
                | TaskTypeDeepSeek.ChatCompletion -> "chat_completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "completion" -> TaskTypeDeepSeek.Completion
            | "chat_completion" -> TaskTypeDeepSeek.ChatCompletion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeDeepSeek"))

    type TaskTypeELSERConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeELSER>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeELSER.SparseEmbedding -> "sparse_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "sparse_embedding" -> TaskTypeELSER.SparseEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeELSER"))

    type TaskTypeElasticsearchConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeElasticsearch>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeElasticsearch.SparseEmbedding -> "sparse_embedding"
                | TaskTypeElasticsearch.TextEmbedding -> "text_embedding"
                | TaskTypeElasticsearch.Rerank -> "rerank"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "sparse_embedding" -> TaskTypeElasticsearch.SparseEmbedding
            | "text_embedding" -> TaskTypeElasticsearch.TextEmbedding
            | "rerank" -> TaskTypeElasticsearch.Rerank
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeElasticsearch"))

    type TaskTypeFireworksAIConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeFireworksAI>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeFireworksAI.ChatCompletion -> "chat_completion"
                | TaskTypeFireworksAI.Completion -> "completion"
                | TaskTypeFireworksAI.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chat_completion" -> TaskTypeFireworksAI.ChatCompletion
            | "completion" -> TaskTypeFireworksAI.Completion
            | "text_embedding" -> TaskTypeFireworksAI.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeFireworksAI"))

    type TaskTypeGoogleAIStudioConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeGoogleAIStudio>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeGoogleAIStudio.TextEmbedding -> "text_embedding"
                | TaskTypeGoogleAIStudio.Completion -> "completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> TaskTypeGoogleAIStudio.TextEmbedding
            | "completion" -> TaskTypeGoogleAIStudio.Completion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeGoogleAIStudio"))

    type TaskTypeGoogleVertexAIConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeGoogleVertexAI>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeGoogleVertexAI.ChatCompletion -> "chat_completion"
                | TaskTypeGoogleVertexAI.Completion -> "completion"
                | TaskTypeGoogleVertexAI.TextEmbedding -> "text_embedding"
                | TaskTypeGoogleVertexAI.Rerank -> "rerank"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chat_completion" -> TaskTypeGoogleVertexAI.ChatCompletion
            | "completion" -> TaskTypeGoogleVertexAI.Completion
            | "text_embedding" -> TaskTypeGoogleVertexAI.TextEmbedding
            | "rerank" -> TaskTypeGoogleVertexAI.Rerank
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeGoogleVertexAI"))

    type TaskTypeGroqConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeGroq>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeGroq.ChatCompletion -> "chat_completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chat_completion" -> TaskTypeGroq.ChatCompletion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeGroq"))

    type TaskTypeHuggingFaceConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeHuggingFace>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeHuggingFace.ChatCompletion -> "chat_completion"
                | TaskTypeHuggingFace.Completion -> "completion"
                | TaskTypeHuggingFace.Rerank -> "rerank"
                | TaskTypeHuggingFace.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chat_completion" -> TaskTypeHuggingFace.ChatCompletion
            | "completion" -> TaskTypeHuggingFace.Completion
            | "rerank" -> TaskTypeHuggingFace.Rerank
            | "text_embedding" -> TaskTypeHuggingFace.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeHuggingFace"))

    type TaskTypeJinaAiConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeJinaAi>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeJinaAi.Embedding -> "embedding"
                | TaskTypeJinaAi.TextEmbedding -> "text_embedding"
                | TaskTypeJinaAi.Rerank -> "rerank"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "embedding" -> TaskTypeJinaAi.Embedding
            | "text_embedding" -> TaskTypeJinaAi.TextEmbedding
            | "rerank" -> TaskTypeJinaAi.Rerank
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeJinaAi"))

    type TaskTypeLlamaConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeLlama>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeLlama.TextEmbedding -> "text_embedding"
                | TaskTypeLlama.ChatCompletion -> "chat_completion"
                | TaskTypeLlama.Completion -> "completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> TaskTypeLlama.TextEmbedding
            | "chat_completion" -> TaskTypeLlama.ChatCompletion
            | "completion" -> TaskTypeLlama.Completion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeLlama"))

    type TaskTypeMistralConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeMistral>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeMistral.TextEmbedding -> "text_embedding"
                | TaskTypeMistral.ChatCompletion -> "chat_completion"
                | TaskTypeMistral.Completion -> "completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> TaskTypeMistral.TextEmbedding
            | "chat_completion" -> TaskTypeMistral.ChatCompletion
            | "completion" -> TaskTypeMistral.Completion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeMistral"))

    type TaskTypeNvidiaConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeNvidia>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeNvidia.ChatCompletion -> "chat_completion"
                | TaskTypeNvidia.Completion -> "completion"
                | TaskTypeNvidia.Rerank -> "rerank"
                | TaskTypeNvidia.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chat_completion" -> TaskTypeNvidia.ChatCompletion
            | "completion" -> TaskTypeNvidia.Completion
            | "rerank" -> TaskTypeNvidia.Rerank
            | "text_embedding" -> TaskTypeNvidia.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeNvidia"))

    type TaskTypeOpenAIConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeOpenAI>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeOpenAI.TextEmbedding -> "text_embedding"
                | TaskTypeOpenAI.ChatCompletion -> "chat_completion"
                | TaskTypeOpenAI.Completion -> "completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> TaskTypeOpenAI.TextEmbedding
            | "chat_completion" -> TaskTypeOpenAI.ChatCompletion
            | "completion" -> TaskTypeOpenAI.Completion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeOpenAI"))

    type TaskTypeOpenShiftAiConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeOpenShiftAi>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeOpenShiftAi.TextEmbedding -> "text_embedding"
                | TaskTypeOpenShiftAi.ChatCompletion -> "chat_completion"
                | TaskTypeOpenShiftAi.Completion -> "completion"
                | TaskTypeOpenShiftAi.Rerank -> "rerank"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> TaskTypeOpenShiftAi.TextEmbedding
            | "chat_completion" -> TaskTypeOpenShiftAi.ChatCompletion
            | "completion" -> TaskTypeOpenShiftAi.Completion
            | "rerank" -> TaskTypeOpenShiftAi.Rerank
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeOpenShiftAi"))

    type TaskTypeVoyageAIConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeVoyageAI>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeVoyageAI.TextEmbedding -> "text_embedding"
                | TaskTypeVoyageAI.Rerank -> "rerank"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> TaskTypeVoyageAI.TextEmbedding
            | "rerank" -> TaskTypeVoyageAI.Rerank
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeVoyageAI"))

    type TaskTypeWatsonxConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TaskTypeWatsonx>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TaskTypeWatsonx.TextEmbedding -> "text_embedding"
                | TaskTypeWatsonx.ChatCompletion -> "chat_completion"
                | TaskTypeWatsonx.Completion -> "completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> TaskTypeWatsonx.TextEmbedding
            | "chat_completion" -> TaskTypeWatsonx.ChatCompletion
            | "completion" -> TaskTypeWatsonx.Completion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeWatsonx"))

    type TextEmbeddingInferenceResultConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TextEmbeddingInferenceResult>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | TextEmbeddingInferenceResult.TextEmbeddingBytes v ->
                writer.WritePropertyName("text_embedding_bytes")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TextEmbeddingInferenceResult.TextEmbeddingBits v ->
                writer.WritePropertyName("text_embedding_bits")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TextEmbeddingInferenceResult.TextEmbedding v ->
                writer.WritePropertyName("text_embedding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for TextEmbeddingInferenceResult"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for TextEmbeddingInferenceResult"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "text_embedding_bytes" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DenseEmbeddingByteResult list>(&reader, options)
                    TextEmbeddingInferenceResult.TextEmbeddingBytes v
                | "text_embedding_bits" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DenseEmbeddingByteResult list>(&reader, options)
                    TextEmbeddingInferenceResult.TextEmbeddingBits v
                | "text_embedding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DenseEmbeddingResult list>(&reader, options)
                    TextEmbeddingInferenceResult.TextEmbedding v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for TextEmbeddingInferenceResult"))
            reader.Read() |> ignore // EndObject
            result

    type VoyageAIServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<VoyageAIServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | VoyageAIServiceType.Voyageai -> "voyageai"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "voyageai" -> VoyageAIServiceType.Voyageai
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for VoyageAIServiceType"))

    type VoyageAITaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<VoyageAITaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | VoyageAITaskType.TextEmbedding -> "text_embedding"
                | VoyageAITaskType.Rerank -> "rerank"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> VoyageAITaskType.TextEmbedding
            | "rerank" -> VoyageAITaskType.Rerank
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for VoyageAITaskType"))

    type WatsonxServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatsonxServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatsonxServiceType.Watsonxai -> "watsonxai"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "watsonxai" -> WatsonxServiceType.Watsonxai
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for WatsonxServiceType"))

    type WatsonxTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatsonxTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatsonxTaskType.TextEmbedding -> "text_embedding"
                | WatsonxTaskType.Rerank -> "rerank"
                | WatsonxTaskType.ChatCompletion -> "chat_completion"
                | WatsonxTaskType.Completion -> "completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> WatsonxTaskType.TextEmbedding
            | "rerank" -> WatsonxTaskType.Rerank
            | "chat_completion" -> WatsonxTaskType.ChatCompletion
            | "completion" -> WatsonxTaskType.Completion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for WatsonxTaskType"))

    type ConvertTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ConvertType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ConvertType.Integer -> "integer"
                | ConvertType.Long -> "long"
                | ConvertType.Double -> "double"
                | ConvertType.Float -> "float"
                | ConvertType.Boolean -> "boolean"
                | ConvertType.Ip -> "ip"
                | ConvertType.String -> "string"
                | ConvertType.Auto -> "auto"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "integer" -> ConvertType.Integer
            | "long" -> ConvertType.Long
            | "double" -> ConvertType.Double
            | "float" -> ConvertType.Float
            | "boolean" -> ConvertType.Boolean
            | "ip" -> ConvertType.Ip
            | "string" -> ConvertType.String
            | "auto" -> ConvertType.Auto
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ConvertType"))

    type DatabaseConfigurationConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DatabaseConfiguration>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | DatabaseConfiguration.Maxmind v ->
                writer.WritePropertyName("maxmind")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | DatabaseConfiguration.Ipinfo v ->
                writer.WritePropertyName("ipinfo")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for DatabaseConfiguration"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for DatabaseConfiguration"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "maxmind" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.Maxmind>(&reader, options)
                    DatabaseConfiguration.Maxmind v
                | "ipinfo" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.Ipinfo>(&reader, options)
                    DatabaseConfiguration.Ipinfo v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for DatabaseConfiguration"))
            reader.Read() |> ignore // EndObject
            result

    type DatabaseConfigurationFullConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DatabaseConfigurationFull>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | DatabaseConfigurationFull.Web v ->
                writer.WritePropertyName("web")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | DatabaseConfigurationFull.Local v ->
                writer.WritePropertyName("local")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | DatabaseConfigurationFull.Maxmind v ->
                writer.WritePropertyName("maxmind")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | DatabaseConfigurationFull.Ipinfo v ->
                writer.WritePropertyName("ipinfo")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for DatabaseConfigurationFull"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for DatabaseConfigurationFull"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "web" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.Web>(&reader, options)
                    DatabaseConfigurationFull.Web v
                | "local" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.Local>(&reader, options)
                    DatabaseConfigurationFull.Local v
                | "maxmind" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.Maxmind>(&reader, options)
                    DatabaseConfigurationFull.Maxmind v
                | "ipinfo" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.Ipinfo>(&reader, options)
                    DatabaseConfigurationFull.Ipinfo v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for DatabaseConfigurationFull"))
            reader.Read() |> ignore // EndObject
            result

    type FieldAccessPatternConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<FieldAccessPattern>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | FieldAccessPattern.Classic -> "classic"
                | FieldAccessPattern.Flexible -> "flexible"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "classic" -> FieldAccessPattern.Classic
            | "flexible" -> FieldAccessPattern.Flexible
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FieldAccessPattern"))

    type FingerprintDigestConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<FingerprintDigest>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | FingerprintDigest.MD5 -> "MD5"
                | FingerprintDigest.SHA1 -> "SHA-1"
                | FingerprintDigest.SHA256 -> "SHA-256"
                | FingerprintDigest.SHA512 -> "SHA-512"
                | FingerprintDigest.MurmurHash3 -> "MurmurHash3"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "MD5" -> FingerprintDigest.MD5
            | "SHA-1" -> FingerprintDigest.SHA1
            | "SHA-256" -> FingerprintDigest.SHA256
            | "SHA-512" -> FingerprintDigest.SHA512
            | "MurmurHash3" -> FingerprintDigest.MurmurHash3
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FingerprintDigest"))

    type GeoGridTargetFormatConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GeoGridTargetFormat>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GeoGridTargetFormat.Geojson -> "geojson"
                | GeoGridTargetFormat.Wkt -> "wkt"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "geojson" -> GeoGridTargetFormat.Geojson
            | "wkt" -> GeoGridTargetFormat.Wkt
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GeoGridTargetFormat"))

    type GeoGridTileTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GeoGridTileType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GeoGridTileType.Geotile -> "geotile"
                | GeoGridTileType.Geohex -> "geohex"
                | GeoGridTileType.Geohash -> "geohash"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "geotile" -> GeoGridTileType.Geotile
            | "geohex" -> GeoGridTileType.Geohex
            | "geohash" -> GeoGridTileType.Geohash
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GeoGridTileType"))

    type InferenceConfigConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceConfig>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | InferenceConfig.Regression v ->
                writer.WritePropertyName("regression")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceConfig.Classification v ->
                writer.WritePropertyName("classification")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for InferenceConfig"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for InferenceConfig"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "regression" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.InferenceConfigRegression>(&reader, options)
                    InferenceConfig.Regression v
                | "classification" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.InferenceConfigClassification>(&reader, options)
                    InferenceConfig.Classification v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for InferenceConfig"))
            reader.Read() |> ignore // EndObject
            result

    type JsonProcessorConflictStrategyConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<JsonProcessorConflictStrategy>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | JsonProcessorConflictStrategy.Replace -> "replace"
                | JsonProcessorConflictStrategy.Merge -> "merge"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "replace" -> JsonProcessorConflictStrategy.Replace
            | "merge" -> JsonProcessorConflictStrategy.Merge
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for JsonProcessorConflictStrategy"))

    type PipelineSimulationStatusOptionsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<PipelineSimulationStatusOptions>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | PipelineSimulationStatusOptions.Success -> "success"
                | PipelineSimulationStatusOptions.Error -> "error"
                | PipelineSimulationStatusOptions.ErrorIgnored -> "error_ignored"
                | PipelineSimulationStatusOptions.Skipped -> "skipped"
                | PipelineSimulationStatusOptions.Dropped -> "dropped"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "success" -> PipelineSimulationStatusOptions.Success
            | "error" -> PipelineSimulationStatusOptions.Error
            | "error_ignored" -> PipelineSimulationStatusOptions.ErrorIgnored
            | "skipped" -> PipelineSimulationStatusOptions.Skipped
            | "dropped" -> PipelineSimulationStatusOptions.Dropped
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for PipelineSimulationStatusOptions"))

    type ProcessorContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ProcessorContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | ProcessorContainer.Append v ->
                writer.WritePropertyName("append")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Attachment v ->
                writer.WritePropertyName("attachment")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Bytes v ->
                writer.WritePropertyName("bytes")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Cef v ->
                writer.WritePropertyName("cef")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Circle v ->
                writer.WritePropertyName("circle")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.CommunityId v ->
                writer.WritePropertyName("community_id")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Convert v ->
                writer.WritePropertyName("convert")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Csv v ->
                writer.WritePropertyName("csv")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Date v ->
                writer.WritePropertyName("date")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.DateIndexName v ->
                writer.WritePropertyName("date_index_name")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Dissect v ->
                writer.WritePropertyName("dissect")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.DotExpander v ->
                writer.WritePropertyName("dot_expander")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Drop v ->
                writer.WritePropertyName("drop")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Enrich v ->
                writer.WritePropertyName("enrich")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Fail v ->
                writer.WritePropertyName("fail")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Fingerprint v ->
                writer.WritePropertyName("fingerprint")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Foreach v ->
                writer.WritePropertyName("foreach")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.IpLocation v ->
                writer.WritePropertyName("ip_location")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.GeoGrid v ->
                writer.WritePropertyName("geo_grid")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Geoip v ->
                writer.WritePropertyName("geoip")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Grok v ->
                writer.WritePropertyName("grok")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Gsub v ->
                writer.WritePropertyName("gsub")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.HtmlStrip v ->
                writer.WritePropertyName("html_strip")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Inference v ->
                writer.WritePropertyName("inference")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Join v ->
                writer.WritePropertyName("join")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Json v ->
                writer.WritePropertyName("json")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Kv v ->
                writer.WritePropertyName("kv")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Lowercase v ->
                writer.WritePropertyName("lowercase")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.NetworkDirection v ->
                writer.WritePropertyName("network_direction")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Pipeline v ->
                writer.WritePropertyName("pipeline")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Redact v ->
                writer.WritePropertyName("redact")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.RegisteredDomain v ->
                writer.WritePropertyName("registered_domain")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Remove v ->
                writer.WritePropertyName("remove")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Rename v ->
                writer.WritePropertyName("rename")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Reroute v ->
                writer.WritePropertyName("reroute")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Script v ->
                writer.WritePropertyName("script")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Set v ->
                writer.WritePropertyName("set")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.SetSecurityUser v ->
                writer.WritePropertyName("set_security_user")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Sort v ->
                writer.WritePropertyName("sort")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Split v ->
                writer.WritePropertyName("split")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Terminate v ->
                writer.WritePropertyName("terminate")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Trim v ->
                writer.WritePropertyName("trim")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Uppercase v ->
                writer.WritePropertyName("uppercase")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Urldecode v ->
                writer.WritePropertyName("urldecode")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.UriParts v ->
                writer.WritePropertyName("uri_parts")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.UserAgent v ->
                writer.WritePropertyName("user_agent")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ProcessorContainer.Unknown (name, el) ->
                writer.WritePropertyName(name)
                el.WriteTo(writer)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for ProcessorContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for ProcessorContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "append" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.AppendProcessor>(&reader, options)
                    ProcessorContainer.Append v
                | "attachment" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.AttachmentProcessor>(&reader, options)
                    ProcessorContainer.Attachment v
                | "bytes" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.BytesProcessor>(&reader, options)
                    ProcessorContainer.Bytes v
                | "cef" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.CefProcessor>(&reader, options)
                    ProcessorContainer.Cef v
                | "circle" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.CircleProcessor>(&reader, options)
                    ProcessorContainer.Circle v
                | "community_id" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.CommunityIDProcessor>(&reader, options)
                    ProcessorContainer.CommunityId v
                | "convert" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ConvertProcessor>(&reader, options)
                    ProcessorContainer.Convert v
                | "csv" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.CsvProcessor>(&reader, options)
                    ProcessorContainer.Csv v
                | "date" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DateProcessor>(&reader, options)
                    ProcessorContainer.Date v
                | "date_index_name" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DateIndexNameProcessor>(&reader, options)
                    ProcessorContainer.DateIndexName v
                | "dissect" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DissectProcessor>(&reader, options)
                    ProcessorContainer.Dissect v
                | "dot_expander" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DotExpanderProcessor>(&reader, options)
                    ProcessorContainer.DotExpander v
                | "drop" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DropProcessor>(&reader, options)
                    ProcessorContainer.Drop v
                | "enrich" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.EnrichProcessor>(&reader, options)
                    ProcessorContainer.Enrich v
                | "fail" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.FailProcessor>(&reader, options)
                    ProcessorContainer.Fail v
                | "fingerprint" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.FingerprintProcessor>(&reader, options)
                    ProcessorContainer.Fingerprint v
                | "foreach" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ForeachProcessor>(&reader, options)
                    ProcessorContainer.Foreach v
                | "ip_location" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IpLocationProcessor>(&reader, options)
                    ProcessorContainer.IpLocation v
                | "geo_grid" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoGridProcessor>(&reader, options)
                    ProcessorContainer.GeoGrid v
                | "geoip" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoIpProcessor>(&reader, options)
                    ProcessorContainer.Geoip v
                | "grok" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GrokProcessor>(&reader, options)
                    ProcessorContainer.Grok v
                | "gsub" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GsubProcessor>(&reader, options)
                    ProcessorContainer.Gsub v
                | "html_strip" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.HtmlStripProcessor>(&reader, options)
                    ProcessorContainer.HtmlStrip v
                | "inference" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.InferenceProcessor>(&reader, options)
                    ProcessorContainer.Inference v
                | "join" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.JoinProcessor>(&reader, options)
                    ProcessorContainer.Join v
                | "json" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.JsonProcessor>(&reader, options)
                    ProcessorContainer.Json v
                | "kv" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.KeyValueProcessor>(&reader, options)
                    ProcessorContainer.Kv v
                | "lowercase" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.LowercaseProcessor>(&reader, options)
                    ProcessorContainer.Lowercase v
                | "network_direction" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.NetworkDirectionProcessor>(&reader, options)
                    ProcessorContainer.NetworkDirection v
                | "pipeline" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.PipelineProcessor>(&reader, options)
                    ProcessorContainer.Pipeline v
                | "redact" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RedactProcessor>(&reader, options)
                    ProcessorContainer.Redact v
                | "registered_domain" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RegisteredDomainProcessor>(&reader, options)
                    ProcessorContainer.RegisteredDomain v
                | "remove" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RemoveProcessor>(&reader, options)
                    ProcessorContainer.Remove v
                | "rename" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RenameProcessor>(&reader, options)
                    ProcessorContainer.Rename v
                | "reroute" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RerouteProcessor>(&reader, options)
                    ProcessorContainer.Reroute v
                | "script" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ScriptProcessor>(&reader, options)
                    ProcessorContainer.Script v
                | "set" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SetProcessor>(&reader, options)
                    ProcessorContainer.Set v
                | "set_security_user" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SetSecurityUserProcessor>(&reader, options)
                    ProcessorContainer.SetSecurityUser v
                | "sort" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SortProcessor>(&reader, options)
                    ProcessorContainer.Sort v
                | "split" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SplitProcessor>(&reader, options)
                    ProcessorContainer.Split v
                | "terminate" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TerminateProcessor>(&reader, options)
                    ProcessorContainer.Terminate v
                | "trim" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TrimProcessor>(&reader, options)
                    ProcessorContainer.Trim v
                | "uppercase" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.UppercaseProcessor>(&reader, options)
                    ProcessorContainer.Uppercase v
                | "urldecode" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.UrlDecodeProcessor>(&reader, options)
                    ProcessorContainer.Urldecode v
                | "uri_parts" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.UriPartsProcessor>(&reader, options)
                    ProcessorContainer.UriParts v
                | "user_agent" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.UserAgentProcessor>(&reader, options)
                    ProcessorContainer.UserAgent v
                | other ->
                    let el = System.Text.Json.JsonElement.ParseValue(&reader)
                    ProcessorContainer.Unknown (other, el)
            reader.Read() |> ignore // EndObject
            result

    type ShapeTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ShapeType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ShapeType.GeoShape -> "geo_shape"
                | ShapeType.Shape -> "shape"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "geo_shape" -> ShapeType.GeoShape
            | "shape" -> ShapeType.Shape
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ShapeType"))

    type UserAgentPropertyConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<UserAgentProperty>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | UserAgentProperty.Name -> "name"
                | UserAgentProperty.Os -> "os"
                | UserAgentProperty.Device -> "device"
                | UserAgentProperty.Original -> "original"
                | UserAgentProperty.Version -> "version"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "name" -> UserAgentProperty.Name
            | "os" -> UserAgentProperty.Os
            | "device" -> UserAgentProperty.Device
            | "original" -> UserAgentProperty.Original
            | "version" -> UserAgentProperty.Version
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for UserAgentProperty"))

    type LicenseStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<LicenseStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | LicenseStatus.Active -> "active"
                | LicenseStatus.Valid -> "valid"
                | LicenseStatus.Invalid -> "invalid"
                | LicenseStatus.Expired -> "expired"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "active" -> LicenseStatus.Active
            | "valid" -> LicenseStatus.Valid
            | "invalid" -> LicenseStatus.Invalid
            | "expired" -> LicenseStatus.Expired
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for LicenseStatus"))

    type LicenseTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<LicenseType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | LicenseType.Missing -> "missing"
                | LicenseType.Trial -> "trial"
                | LicenseType.Basic -> "basic"
                | LicenseType.Standard -> "standard"
                | LicenseType.Dev -> "dev"
                | LicenseType.Silver -> "silver"
                | LicenseType.Gold -> "gold"
                | LicenseType.Platinum -> "platinum"
                | LicenseType.Enterprise -> "enterprise"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "missing" -> LicenseType.Missing
            | "trial" -> LicenseType.Trial
            | "basic" -> LicenseType.Basic
            | "standard" -> LicenseType.Standard
            | "dev" -> LicenseType.Dev
            | "silver" -> LicenseType.Silver
            | "gold" -> LicenseType.Gold
            | "platinum" -> LicenseType.Platinum
            | "enterprise" -> LicenseType.Enterprise
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for LicenseType"))

    type DeprecationLevelConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DeprecationLevel>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | DeprecationLevel.None -> "none"
                | DeprecationLevel.Info -> "info"
                | DeprecationLevel.Warning -> "warning"
                | DeprecationLevel.Critical -> "critical"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "none" -> DeprecationLevel.None
            | "info" -> DeprecationLevel.Info
            | "warning" -> DeprecationLevel.Warning
            | "critical" -> DeprecationLevel.Critical
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DeprecationLevel"))

    type MigrationStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MigrationStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MigrationStatus.NOMIGRATIONNEEDED -> "NO_MIGRATION_NEEDED"
                | MigrationStatus.MIGRATIONNEEDED -> "MIGRATION_NEEDED"
                | MigrationStatus.INPROGRESS -> "IN_PROGRESS"
                | MigrationStatus.ERROR -> "ERROR"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "NO_MIGRATION_NEEDED" -> MigrationStatus.NOMIGRATIONNEEDED
            | "MIGRATION_NEEDED" -> MigrationStatus.MIGRATIONNEEDED
            | "IN_PROGRESS" -> MigrationStatus.INPROGRESS
            | "ERROR" -> MigrationStatus.ERROR
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for MigrationStatus"))

    type AppliesToConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<AppliesTo>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | AppliesTo.Actual -> "actual"
                | AppliesTo.Typical -> "typical"
                | AppliesTo.DiffFromTypical -> "diff_from_typical"
                | AppliesTo.Time -> "time"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "actual" -> AppliesTo.Actual
            | "typical" -> AppliesTo.Typical
            | "diff_from_typical" -> AppliesTo.DiffFromTypical
            | "time" -> AppliesTo.Time
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AppliesTo"))

    type CategorizationStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CategorizationStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CategorizationStatus.Ok -> "ok"
                | CategorizationStatus.Warn -> "warn"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "ok" -> CategorizationStatus.Ok
            | "warn" -> CategorizationStatus.Warn
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CategorizationStatus"))

    type ChunkingModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ChunkingMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ChunkingMode.Auto -> "auto"
                | ChunkingMode.Manual -> "manual"
                | ChunkingMode.Off -> "off"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "auto" -> ChunkingMode.Auto
            | "manual" -> ChunkingMode.Manual
            | "off" -> ChunkingMode.Off
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ChunkingMode"))

    type ConditionOperatorConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ConditionOperator>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ConditionOperator.Gt -> "gt"
                | ConditionOperator.Gte -> "gte"
                | ConditionOperator.Lt -> "lt"
                | ConditionOperator.Lte -> "lte"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "gt" -> ConditionOperator.Gt
            | "gte" -> ConditionOperator.Gte
            | "lt" -> ConditionOperator.Lt
            | "lte" -> ConditionOperator.Lte
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ConditionOperator"))

    type DatafeedStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DatafeedState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | DatafeedState.Started -> "started"
                | DatafeedState.Stopped -> "stopped"
                | DatafeedState.Starting -> "starting"
                | DatafeedState.Stopping -> "stopping"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "started" -> DatafeedState.Started
            | "stopped" -> DatafeedState.Stopped
            | "starting" -> DatafeedState.Starting
            | "stopping" -> DatafeedState.Stopping
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DatafeedState"))

    type DataframeAnalysisContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DataframeAnalysisContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | DataframeAnalysisContainer.Classification v ->
                writer.WritePropertyName("classification")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | DataframeAnalysisContainer.OutlierDetection v ->
                writer.WritePropertyName("outlier_detection")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | DataframeAnalysisContainer.Regression v ->
                writer.WritePropertyName("regression")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for DataframeAnalysisContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for DataframeAnalysisContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "classification" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DataframeAnalysisClassification>(&reader, options)
                    DataframeAnalysisContainer.Classification v
                | "outlier_detection" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DataframeAnalysisOutlierDetection>(&reader, options)
                    DataframeAnalysisContainer.OutlierDetection v
                | "regression" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DataframeAnalysisRegression>(&reader, options)
                    DataframeAnalysisContainer.Regression v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for DataframeAnalysisContainer"))
            reader.Read() |> ignore // EndObject
            result

    type DataframeAnalysisFeatureProcessorConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DataframeAnalysisFeatureProcessor>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | DataframeAnalysisFeatureProcessor.FrequencyEncoding v ->
                writer.WritePropertyName("frequency_encoding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | DataframeAnalysisFeatureProcessor.MultiEncoding v ->
                writer.WritePropertyName("multi_encoding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | DataframeAnalysisFeatureProcessor.NGramEncoding v ->
                writer.WritePropertyName("n_gram_encoding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | DataframeAnalysisFeatureProcessor.OneHotEncoding v ->
                writer.WritePropertyName("one_hot_encoding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | DataframeAnalysisFeatureProcessor.TargetMeanEncoding v ->
                writer.WritePropertyName("target_mean_encoding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for DataframeAnalysisFeatureProcessor"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for DataframeAnalysisFeatureProcessor"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "frequency_encoding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DataframeAnalysisFeatureProcessorFrequencyEncoding>(&reader, options)
                    DataframeAnalysisFeatureProcessor.FrequencyEncoding v
                | "multi_encoding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DataframeAnalysisFeatureProcessorMultiEncoding>(&reader, options)
                    DataframeAnalysisFeatureProcessor.MultiEncoding v
                | "n_gram_encoding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DataframeAnalysisFeatureProcessorNGramEncoding>(&reader, options)
                    DataframeAnalysisFeatureProcessor.NGramEncoding v
                | "one_hot_encoding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DataframeAnalysisFeatureProcessorOneHotEncoding>(&reader, options)
                    DataframeAnalysisFeatureProcessor.OneHotEncoding v
                | "target_mean_encoding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DataframeAnalysisFeatureProcessorTargetMeanEncoding>(&reader, options)
                    DataframeAnalysisFeatureProcessor.TargetMeanEncoding v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for DataframeAnalysisFeatureProcessor"))
            reader.Read() |> ignore // EndObject
            result

    type DataframeAnalyticsStatsContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DataframeAnalyticsStatsContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | DataframeAnalyticsStatsContainer.ClassificationStats v ->
                writer.WritePropertyName("classification_stats")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | DataframeAnalyticsStatsContainer.OutlierDetectionStats v ->
                writer.WritePropertyName("outlier_detection_stats")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | DataframeAnalyticsStatsContainer.RegressionStats v ->
                writer.WritePropertyName("regression_stats")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for DataframeAnalyticsStatsContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for DataframeAnalyticsStatsContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "classification_stats" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DataframeAnalyticsStatsHyperparameters>(&reader, options)
                    DataframeAnalyticsStatsContainer.ClassificationStats v
                | "outlier_detection_stats" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DataframeAnalyticsStatsOutlierDetection>(&reader, options)
                    DataframeAnalyticsStatsContainer.OutlierDetectionStats v
                | "regression_stats" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DataframeAnalyticsStatsHyperparameters>(&reader, options)
                    DataframeAnalyticsStatsContainer.RegressionStats v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for DataframeAnalyticsStatsContainer"))
            reader.Read() |> ignore // EndObject
            result

    type DataframeEvaluationContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DataframeEvaluationContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | DataframeEvaluationContainer.Classification v ->
                writer.WritePropertyName("classification")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | DataframeEvaluationContainer.OutlierDetection v ->
                writer.WritePropertyName("outlier_detection")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | DataframeEvaluationContainer.Regression v ->
                writer.WritePropertyName("regression")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for DataframeEvaluationContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for DataframeEvaluationContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "classification" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DataframeEvaluationClassification>(&reader, options)
                    DataframeEvaluationContainer.Classification v
                | "outlier_detection" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DataframeEvaluationOutlierDetection>(&reader, options)
                    DataframeEvaluationContainer.OutlierDetection v
                | "regression" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DataframeEvaluationRegression>(&reader, options)
                    DataframeEvaluationContainer.Regression v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for DataframeEvaluationContainer"))
            reader.Read() |> ignore // EndObject
            result

    type DataframeStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DataframeState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | DataframeState.Started -> "started"
                | DataframeState.Stopped -> "stopped"
                | DataframeState.Starting -> "starting"
                | DataframeState.Stopping -> "stopping"
                | DataframeState.Failed -> "failed"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "started" -> DataframeState.Started
            | "stopped" -> DataframeState.Stopped
            | "starting" -> DataframeState.Starting
            | "stopping" -> DataframeState.Stopping
            | "failed" -> DataframeState.Failed
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DataframeState"))

    type DeploymentAllocationStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DeploymentAllocationState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | DeploymentAllocationState.Started -> "started"
                | DeploymentAllocationState.Starting -> "starting"
                | DeploymentAllocationState.FullyAllocated -> "fully_allocated"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "started" -> DeploymentAllocationState.Started
            | "starting" -> DeploymentAllocationState.Starting
            | "fully_allocated" -> DeploymentAllocationState.FullyAllocated
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DeploymentAllocationState"))

    type DeploymentAssignmentStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DeploymentAssignmentState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | DeploymentAssignmentState.Started -> "started"
                | DeploymentAssignmentState.Starting -> "starting"
                | DeploymentAssignmentState.Stopping -> "stopping"
                | DeploymentAssignmentState.Failed -> "failed"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "started" -> DeploymentAssignmentState.Started
            | "starting" -> DeploymentAssignmentState.Starting
            | "stopping" -> DeploymentAssignmentState.Stopping
            | "failed" -> DeploymentAssignmentState.Failed
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DeploymentAssignmentState"))

    type ExcludeFrequentConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ExcludeFrequent>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ExcludeFrequent.All -> "all"
                | ExcludeFrequent.None -> "none"
                | ExcludeFrequent.By -> "by"
                | ExcludeFrequent.Over -> "over"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "all" -> ExcludeFrequent.All
            | "none" -> ExcludeFrequent.None
            | "by" -> ExcludeFrequent.By
            | "over" -> ExcludeFrequent.Over
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ExcludeFrequent"))

    type FilterTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<FilterType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | FilterType.Include -> "include"
                | FilterType.Exclude -> "exclude"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "include" -> FilterType.Include
            | "exclude" -> FilterType.Exclude
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FilterType"))

    type IncludeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Include>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Include.Definition -> "definition"
                | Include.FeatureImportanceBaseline -> "feature_importance_baseline"
                | Include.Hyperparameters -> "hyperparameters"
                | Include.TotalFeatureImportance -> "total_feature_importance"
                | Include.DefinitionStatus -> "definition_status"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "definition" -> Include.Definition
            | "feature_importance_baseline" -> Include.FeatureImportanceBaseline
            | "hyperparameters" -> Include.Hyperparameters
            | "total_feature_importance" -> Include.TotalFeatureImportance
            | "definition_status" -> Include.DefinitionStatus
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Include"))

    type InferenceConfigCreateContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceConfigCreateContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | InferenceConfigCreateContainer.Regression v ->
                writer.WritePropertyName("regression")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceConfigCreateContainer.Classification v ->
                writer.WritePropertyName("classification")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceConfigCreateContainer.TextClassification v ->
                writer.WritePropertyName("text_classification")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceConfigCreateContainer.ZeroShotClassification v ->
                writer.WritePropertyName("zero_shot_classification")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceConfigCreateContainer.FillMask v ->
                writer.WritePropertyName("fill_mask")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceConfigCreateContainer.LearningToRank v ->
                writer.WritePropertyName("learning_to_rank")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceConfigCreateContainer.Ner v ->
                writer.WritePropertyName("ner")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceConfigCreateContainer.PassThrough v ->
                writer.WritePropertyName("pass_through")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceConfigCreateContainer.TextEmbedding v ->
                writer.WritePropertyName("text_embedding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceConfigCreateContainer.TextExpansion v ->
                writer.WritePropertyName("text_expansion")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceConfigCreateContainer.QuestionAnswering v ->
                writer.WritePropertyName("question_answering")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for InferenceConfigCreateContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for InferenceConfigCreateContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "regression" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RegressionInferenceOptions>(&reader, options)
                    InferenceConfigCreateContainer.Regression v
                | "classification" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ClassificationInferenceOptions>(&reader, options)
                    InferenceConfigCreateContainer.Classification v
                | "text_classification" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TextClassificationInferenceOptions>(&reader, options)
                    InferenceConfigCreateContainer.TextClassification v
                | "zero_shot_classification" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ZeroShotClassificationInferenceOptions>(&reader, options)
                    InferenceConfigCreateContainer.ZeroShotClassification v
                | "fill_mask" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.FillMaskInferenceOptions>(&reader, options)
                    InferenceConfigCreateContainer.FillMask v
                | "learning_to_rank" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.LearningToRankConfig>(&reader, options)
                    InferenceConfigCreateContainer.LearningToRank v
                | "ner" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.NerInferenceOptions>(&reader, options)
                    InferenceConfigCreateContainer.Ner v
                | "pass_through" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.PassThroughInferenceOptions>(&reader, options)
                    InferenceConfigCreateContainer.PassThrough v
                | "text_embedding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TextEmbeddingInferenceOptions>(&reader, options)
                    InferenceConfigCreateContainer.TextEmbedding v
                | "text_expansion" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TextExpansionInferenceOptions>(&reader, options)
                    InferenceConfigCreateContainer.TextExpansion v
                | "question_answering" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.QuestionAnsweringInferenceOptions>(&reader, options)
                    InferenceConfigCreateContainer.QuestionAnswering v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for InferenceConfigCreateContainer"))
            reader.Read() |> ignore // EndObject
            result

    type InferenceConfigUpdateContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceConfigUpdateContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | InferenceConfigUpdateContainer.Regression v ->
                writer.WritePropertyName("regression")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceConfigUpdateContainer.Classification v ->
                writer.WritePropertyName("classification")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceConfigUpdateContainer.TextClassification v ->
                writer.WritePropertyName("text_classification")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceConfigUpdateContainer.ZeroShotClassification v ->
                writer.WritePropertyName("zero_shot_classification")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceConfigUpdateContainer.FillMask v ->
                writer.WritePropertyName("fill_mask")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceConfigUpdateContainer.Ner v ->
                writer.WritePropertyName("ner")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceConfigUpdateContainer.PassThrough v ->
                writer.WritePropertyName("pass_through")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceConfigUpdateContainer.TextEmbedding v ->
                writer.WritePropertyName("text_embedding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceConfigUpdateContainer.TextExpansion v ->
                writer.WritePropertyName("text_expansion")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceConfigUpdateContainer.QuestionAnswering v ->
                writer.WritePropertyName("question_answering")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for InferenceConfigUpdateContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for InferenceConfigUpdateContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "regression" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RegressionInferenceOptions>(&reader, options)
                    InferenceConfigUpdateContainer.Regression v
                | "classification" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ClassificationInferenceOptions>(&reader, options)
                    InferenceConfigUpdateContainer.Classification v
                | "text_classification" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TextClassificationInferenceUpdateOptions>(&reader, options)
                    InferenceConfigUpdateContainer.TextClassification v
                | "zero_shot_classification" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ZeroShotClassificationInferenceUpdateOptions>(&reader, options)
                    InferenceConfigUpdateContainer.ZeroShotClassification v
                | "fill_mask" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.FillMaskInferenceUpdateOptions>(&reader, options)
                    InferenceConfigUpdateContainer.FillMask v
                | "ner" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.NerInferenceUpdateOptions>(&reader, options)
                    InferenceConfigUpdateContainer.Ner v
                | "pass_through" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.PassThroughInferenceUpdateOptions>(&reader, options)
                    InferenceConfigUpdateContainer.PassThrough v
                | "text_embedding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TextEmbeddingInferenceUpdateOptions>(&reader, options)
                    InferenceConfigUpdateContainer.TextEmbedding v
                | "text_expansion" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TextExpansionInferenceUpdateOptions>(&reader, options)
                    InferenceConfigUpdateContainer.TextExpansion v
                | "question_answering" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.QuestionAnsweringInferenceUpdateOptions>(&reader, options)
                    InferenceConfigUpdateContainer.QuestionAnswering v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for InferenceConfigUpdateContainer"))
            reader.Read() |> ignore // EndObject
            result

    type JobBlockedReasonConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<JobBlockedReason>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | JobBlockedReason.Delete -> "delete"
                | JobBlockedReason.Reset -> "reset"
                | JobBlockedReason.Revert -> "revert"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "delete" -> JobBlockedReason.Delete
            | "reset" -> JobBlockedReason.Reset
            | "revert" -> JobBlockedReason.Revert
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for JobBlockedReason"))

    type JobStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<JobState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | JobState.Closing -> "closing"
                | JobState.Closed -> "closed"
                | JobState.Opened -> "opened"
                | JobState.Failed -> "failed"
                | JobState.Opening -> "opening"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "closing" -> JobState.Closing
            | "closed" -> JobState.Closed
            | "opened" -> JobState.Opened
            | "failed" -> JobState.Failed
            | "opening" -> JobState.Opening
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for JobState"))

    type MemoryStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MemoryStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MemoryStatus.Ok -> "ok"
                | MemoryStatus.SoftLimit -> "soft_limit"
                | MemoryStatus.HardLimit -> "hard_limit"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "ok" -> MemoryStatus.Ok
            | "soft_limit" -> MemoryStatus.SoftLimit
            | "hard_limit" -> MemoryStatus.HardLimit
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for MemoryStatus"))

    type RoutingStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<RoutingState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | RoutingState.Failed -> "failed"
                | RoutingState.Started -> "started"
                | RoutingState.Starting -> "starting"
                | RoutingState.Stopped -> "stopped"
                | RoutingState.Stopping -> "stopping"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "failed" -> RoutingState.Failed
            | "started" -> RoutingState.Started
            | "starting" -> RoutingState.Starting
            | "stopped" -> RoutingState.Stopped
            | "stopping" -> RoutingState.Stopping
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for RoutingState"))

    type RuleActionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<RuleAction>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | RuleAction.SkipResult -> "skip_result"
                | RuleAction.SkipModelUpdate -> "skip_model_update"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "skip_result" -> RuleAction.SkipResult
            | "skip_model_update" -> RuleAction.SkipModelUpdate
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for RuleAction"))

    type SnapshotUpgradeStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SnapshotUpgradeState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SnapshotUpgradeState.LoadingOldState -> "loading_old_state"
                | SnapshotUpgradeState.SavingNewState -> "saving_new_state"
                | SnapshotUpgradeState.Stopped -> "stopped"
                | SnapshotUpgradeState.Failed -> "failed"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "loading_old_state" -> SnapshotUpgradeState.LoadingOldState
            | "saving_new_state" -> SnapshotUpgradeState.SavingNewState
            | "stopped" -> SnapshotUpgradeState.Stopped
            | "failed" -> SnapshotUpgradeState.Failed
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SnapshotUpgradeState"))

    type TokenizationConfigContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TokenizationConfigContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | TokenizationConfigContainer.Bert v ->
                writer.WritePropertyName("bert")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenizationConfigContainer.BertJa v ->
                writer.WritePropertyName("bert_ja")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenizationConfigContainer.Mpnet v ->
                writer.WritePropertyName("mpnet")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenizationConfigContainer.Roberta v ->
                writer.WritePropertyName("roberta")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TokenizationConfigContainer.XlmRoberta v ->
                writer.WritePropertyName("xlm_roberta")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for TokenizationConfigContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for TokenizationConfigContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "bert" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.NlpBertTokenizationConfig>(&reader, options)
                    TokenizationConfigContainer.Bert v
                | "bert_ja" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.NlpBertTokenizationConfig>(&reader, options)
                    TokenizationConfigContainer.BertJa v
                | "mpnet" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.NlpBertTokenizationConfig>(&reader, options)
                    TokenizationConfigContainer.Mpnet v
                | "roberta" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.NlpRobertaTokenizationConfig>(&reader, options)
                    TokenizationConfigContainer.Roberta v
                | "xlm_roberta" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.XlmRobertaTokenizationConfig>(&reader, options)
                    TokenizationConfigContainer.XlmRoberta v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for TokenizationConfigContainer"))
            reader.Read() |> ignore // EndObject
            result

    type TokenizationTruncateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TokenizationTruncate>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TokenizationTruncate.First -> "first"
                | TokenizationTruncate.Second -> "second"
                | TokenizationTruncate.None -> "none"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "first" -> TokenizationTruncate.First
            | "second" -> TokenizationTruncate.Second
            | "none" -> TokenizationTruncate.None
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TokenizationTruncate"))

    type TrainedModelTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TrainedModelType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TrainedModelType.TreeEnsemble -> "tree_ensemble"
                | TrainedModelType.LangIdent -> "lang_ident"
                | TrainedModelType.Pytorch -> "pytorch"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "tree_ensemble" -> TrainedModelType.TreeEnsemble
            | "lang_ident" -> TrainedModelType.LangIdent
            | "pytorch" -> TrainedModelType.Pytorch
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TrainedModelType"))

    type TrainingPriorityConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TrainingPriority>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TrainingPriority.Normal -> "normal"
                | TrainingPriority.Low -> "low"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "normal" -> TrainingPriority.Normal
            | "low" -> TrainingPriority.Low
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TrainingPriority"))

    type PreprocessorConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Preprocessor>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | Preprocessor.FrequencyEncoding v ->
                writer.WritePropertyName("frequency_encoding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Preprocessor.OneHotEncoding v ->
                writer.WritePropertyName("one_hot_encoding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Preprocessor.TargetMeanEncoding v ->
                writer.WritePropertyName("target_mean_encoding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for Preprocessor"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for Preprocessor"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "frequency_encoding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.FrequencyEncodingPreprocessor>(&reader, options)
                    Preprocessor.FrequencyEncoding v
                | "one_hot_encoding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.OneHotEncodingPreprocessor>(&reader, options)
                    Preprocessor.OneHotEncoding v
                | "target_mean_encoding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TargetMeanEncodingPreprocessor>(&reader, options)
                    Preprocessor.TargetMeanEncoding v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for Preprocessor"))
            reader.Read() |> ignore // EndObject
            result

    type NodesInfoMetricConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<NodesInfoMetric>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | NodesInfoMetric.All -> "_all"
                | NodesInfoMetric.None -> "_none"
                | NodesInfoMetric.Settings -> "settings"
                | NodesInfoMetric.Os -> "os"
                | NodesInfoMetric.Process -> "process"
                | NodesInfoMetric.Jvm -> "jvm"
                | NodesInfoMetric.ThreadPool -> "thread_pool"
                | NodesInfoMetric.Transport -> "transport"
                | NodesInfoMetric.Http -> "http"
                | NodesInfoMetric.RemoteClusterServer -> "remote_cluster_server"
                | NodesInfoMetric.Plugins -> "plugins"
                | NodesInfoMetric.Ingest -> "ingest"
                | NodesInfoMetric.Aggregations -> "aggregations"
                | NodesInfoMetric.Indices -> "indices"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "_all" -> NodesInfoMetric.All
            | "_none" -> NodesInfoMetric.None
            | "settings" -> NodesInfoMetric.Settings
            | "os" -> NodesInfoMetric.Os
            | "process" -> NodesInfoMetric.Process
            | "jvm" -> NodesInfoMetric.Jvm
            | "thread_pool" -> NodesInfoMetric.ThreadPool
            | "transport" -> NodesInfoMetric.Transport
            | "http" -> NodesInfoMetric.Http
            | "remote_cluster_server" -> NodesInfoMetric.RemoteClusterServer
            | "plugins" -> NodesInfoMetric.Plugins
            | "ingest" -> NodesInfoMetric.Ingest
            | "aggregations" -> NodesInfoMetric.Aggregations
            | "indices" -> NodesInfoMetric.Indices
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for NodesInfoMetric"))

    type NodeStatsMetricConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<NodeStatsMetric>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | NodeStatsMetric.All -> "_all"
                | NodeStatsMetric.None -> "_none"
                | NodeStatsMetric.Indices -> "indices"
                | NodeStatsMetric.Os -> "os"
                | NodeStatsMetric.Process -> "process"
                | NodeStatsMetric.Jvm -> "jvm"
                | NodeStatsMetric.ThreadPool -> "thread_pool"
                | NodeStatsMetric.Fs -> "fs"
                | NodeStatsMetric.Transport -> "transport"
                | NodeStatsMetric.Http -> "http"
                | NodeStatsMetric.Breaker -> "breaker"
                | NodeStatsMetric.Script -> "script"
                | NodeStatsMetric.Discovery -> "discovery"
                | NodeStatsMetric.Ingest -> "ingest"
                | NodeStatsMetric.AdaptiveSelection -> "adaptive_selection"
                | NodeStatsMetric.ScriptCache -> "script_cache"
                | NodeStatsMetric.IndexingPressure -> "indexing_pressure"
                | NodeStatsMetric.Repositories -> "repositories"
                | NodeStatsMetric.Allocations -> "allocations"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "_all" -> NodeStatsMetric.All
            | "_none" -> NodeStatsMetric.None
            | "indices" -> NodeStatsMetric.Indices
            | "os" -> NodeStatsMetric.Os
            | "process" -> NodeStatsMetric.Process
            | "jvm" -> NodeStatsMetric.Jvm
            | "thread_pool" -> NodeStatsMetric.ThreadPool
            | "fs" -> NodeStatsMetric.Fs
            | "transport" -> NodeStatsMetric.Transport
            | "http" -> NodeStatsMetric.Http
            | "breaker" -> NodeStatsMetric.Breaker
            | "script" -> NodeStatsMetric.Script
            | "discovery" -> NodeStatsMetric.Discovery
            | "ingest" -> NodeStatsMetric.Ingest
            | "adaptive_selection" -> NodeStatsMetric.AdaptiveSelection
            | "script_cache" -> NodeStatsMetric.ScriptCache
            | "indexing_pressure" -> NodeStatsMetric.IndexingPressure
            | "repositories" -> NodeStatsMetric.Repositories
            | "allocations" -> NodeStatsMetric.Allocations
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for NodeStatsMetric"))

    type NodesUsageMetricConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<NodesUsageMetric>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | NodesUsageMetric.All -> "_all"
                | NodesUsageMetric.RestActions -> "rest_actions"
                | NodesUsageMetric.Aggregations -> "aggregations"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "_all" -> NodesUsageMetric.All
            | "rest_actions" -> NodesUsageMetric.RestActions
            | "aggregations" -> NodesUsageMetric.Aggregations
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for NodesUsageMetric"))

    type ProfilingOperationModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ProfilingOperationMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ProfilingOperationMode.RUNNING -> "RUNNING"
                | ProfilingOperationMode.STOPPING -> "STOPPING"
                | ProfilingOperationMode.STOPPED -> "STOPPED"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "RUNNING" -> ProfilingOperationMode.RUNNING
            | "STOPPING" -> ProfilingOperationMode.STOPPING
            | "STOPPED" -> ProfilingOperationMode.STOPPED
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ProfilingOperationMode"))

    type QueryRuleCriteriaTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<QueryRuleCriteriaType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | QueryRuleCriteriaType.Global -> "global"
                | QueryRuleCriteriaType.Exact -> "exact"
                | QueryRuleCriteriaType.Fuzzy -> "fuzzy"
                | QueryRuleCriteriaType.Prefix -> "prefix"
                | QueryRuleCriteriaType.Suffix -> "suffix"
                | QueryRuleCriteriaType.Contains -> "contains"
                | QueryRuleCriteriaType.Lt -> "lt"
                | QueryRuleCriteriaType.Lte -> "lte"
                | QueryRuleCriteriaType.Gt -> "gt"
                | QueryRuleCriteriaType.Gte -> "gte"
                | QueryRuleCriteriaType.Always -> "always"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "global" -> QueryRuleCriteriaType.Global
            | "exact" -> QueryRuleCriteriaType.Exact
            | "fuzzy" -> QueryRuleCriteriaType.Fuzzy
            | "prefix" -> QueryRuleCriteriaType.Prefix
            | "suffix" -> QueryRuleCriteriaType.Suffix
            | "contains" -> QueryRuleCriteriaType.Contains
            | "lt" -> QueryRuleCriteriaType.Lt
            | "lte" -> QueryRuleCriteriaType.Lte
            | "gt" -> QueryRuleCriteriaType.Gt
            | "gte" -> QueryRuleCriteriaType.Gte
            | "always" -> QueryRuleCriteriaType.Always
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for QueryRuleCriteriaType"))

    type QueryRuleTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<QueryRuleType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | QueryRuleType.Pinned -> "pinned"
                | QueryRuleType.Exclude -> "exclude"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "pinned" -> QueryRuleType.Pinned
            | "exclude" -> QueryRuleType.Exclude
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for QueryRuleType"))

    type MetricConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Metric>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Metric.Min -> "min"
                | Metric.Max -> "max"
                | Metric.Sum -> "sum"
                | Metric.Avg -> "avg"
                | Metric.ValueCount -> "value_count"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "min" -> Metric.Min
            | "max" -> Metric.Max
            | "sum" -> Metric.Sum
            | "avg" -> Metric.Avg
            | "value_count" -> Metric.ValueCount
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Metric"))

    type IndexingJobStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndexingJobState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndexingJobState.Started -> "started"
                | IndexingJobState.Indexing -> "indexing"
                | IndexingJobState.Stopping -> "stopping"
                | IndexingJobState.Stopped -> "stopped"
                | IndexingJobState.Aborting -> "aborting"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "started" -> IndexingJobState.Started
            | "indexing" -> IndexingJobState.Indexing
            | "stopping" -> IndexingJobState.Stopping
            | "stopped" -> IndexingJobState.Stopped
            | "aborting" -> IndexingJobState.Aborting
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IndexingJobState"))

    type EventTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<EventType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | EventType.PageView -> "page_view"
                | EventType.Search -> "search"
                | EventType.SearchClick -> "search_click"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "page_view" -> EventType.PageView
            | "search" -> EventType.Search
            | "search_click" -> EventType.SearchClick
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for EventType"))

    type StatsLevelConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<StatsLevel>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | StatsLevel.Cluster -> "cluster"
                | StatsLevel.Indices -> "indices"
                | StatsLevel.Shards -> "shards"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cluster" -> StatsLevel.Cluster
            | "indices" -> StatsLevel.Indices
            | "shards" -> StatsLevel.Shards
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for StatsLevel"))

    type StorageOptionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<StorageOption>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | StorageOption.FullCopy -> "full_copy"
                | StorageOption.SharedCache -> "shared_cache"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "full_copy" -> StorageOption.FullCopy
            | "shared_cache" -> StorageOption.SharedCache
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for StorageOption"))

    type ApiKeyManagedByConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ApiKeyManagedBy>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ApiKeyManagedBy.Cloud -> "cloud"
                | ApiKeyManagedBy.Elasticsearch -> "elasticsearch"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cloud" -> ApiKeyManagedBy.Cloud
            | "elasticsearch" -> ApiKeyManagedBy.Elasticsearch
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ApiKeyManagedBy"))

    type ApiKeyTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ApiKeyType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ApiKeyType.Rest -> "rest"
                | ApiKeyType.CrossCluster -> "cross_cluster"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "rest" -> ApiKeyType.Rest
            | "cross_cluster" -> ApiKeyType.CrossCluster
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ApiKeyType"))

    type ClusterPrivilegeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ClusterPrivilege>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ClusterPrivilege.All -> "all"
                | ClusterPrivilege.CancelTask -> "cancel_task"
                | ClusterPrivilege.CreateSnapshot -> "create_snapshot"
                | ClusterPrivilege.CrossClusterReplication -> "cross_cluster_replication"
                | ClusterPrivilege.CrossClusterSearch -> "cross_cluster_search"
                | ClusterPrivilege.DelegatePki -> "delegate_pki"
                | ClusterPrivilege.GrantApiKey -> "grant_api_key"
                | ClusterPrivilege.Manage -> "manage"
                | ClusterPrivilege.ManageApiKey -> "manage_api_key"
                | ClusterPrivilege.ManageAutoscaling -> "manage_autoscaling"
                | ClusterPrivilege.ManageBehavioralAnalytics -> "manage_behavioral_analytics"
                | ClusterPrivilege.ManageCcr -> "manage_ccr"
                | ClusterPrivilege.ManageDataFrameTransforms -> "manage_data_frame_transforms"
                | ClusterPrivilege.ManageDataStreamGlobalRetention -> "manage_data_stream_global_retention"
                | ClusterPrivilege.ManageEnrich -> "manage_enrich"
                | ClusterPrivilege.ManageEsql -> "manage_esql"
                | ClusterPrivilege.ManageIlm -> "manage_ilm"
                | ClusterPrivilege.ManageIndexTemplates -> "manage_index_templates"
                | ClusterPrivilege.ManageInference -> "manage_inference"
                | ClusterPrivilege.ManageIngestPipelines -> "manage_ingest_pipelines"
                | ClusterPrivilege.ManageLogstashPipelines -> "manage_logstash_pipelines"
                | ClusterPrivilege.ManageMl -> "manage_ml"
                | ClusterPrivilege.ManageOidc -> "manage_oidc"
                | ClusterPrivilege.ManageOwnApiKey -> "manage_own_api_key"
                | ClusterPrivilege.ManagePipeline -> "manage_pipeline"
                | ClusterPrivilege.ManageRollup -> "manage_rollup"
                | ClusterPrivilege.ManageSaml -> "manage_saml"
                | ClusterPrivilege.ManageSearchApplication -> "manage_search_application"
                | ClusterPrivilege.ManageSearchQueryRules -> "manage_search_query_rules"
                | ClusterPrivilege.ManageSearchSynonyms -> "manage_search_synonyms"
                | ClusterPrivilege.ManageSecurity -> "manage_security"
                | ClusterPrivilege.ManageServiceAccount -> "manage_service_account"
                | ClusterPrivilege.ManageSlm -> "manage_slm"
                | ClusterPrivilege.ManageToken -> "manage_token"
                | ClusterPrivilege.ManageTransform -> "manage_transform"
                | ClusterPrivilege.ManageUserProfile -> "manage_user_profile"
                | ClusterPrivilege.ManageWatcher -> "manage_watcher"
                | ClusterPrivilege.Monitor -> "monitor"
                | ClusterPrivilege.MonitorDataFrameTransforms -> "monitor_data_frame_transforms"
                | ClusterPrivilege.MonitorDataStreamGlobalRetention -> "monitor_data_stream_global_retention"
                | ClusterPrivilege.MonitorEnrich -> "monitor_enrich"
                | ClusterPrivilege.MonitorEsql -> "monitor_esql"
                | ClusterPrivilege.MonitorInference -> "monitor_inference"
                | ClusterPrivilege.MonitorMl -> "monitor_ml"
                | ClusterPrivilege.MonitorRollup -> "monitor_rollup"
                | ClusterPrivilege.MonitorSnapshot -> "monitor_snapshot"
                | ClusterPrivilege.MonitorStats -> "monitor_stats"
                | ClusterPrivilege.MonitorTextStructure -> "monitor_text_structure"
                | ClusterPrivilege.MonitorTransform -> "monitor_transform"
                | ClusterPrivilege.MonitorWatcher -> "monitor_watcher"
                | ClusterPrivilege.None -> "none"
                | ClusterPrivilege.PostBehavioralAnalyticsEvent -> "post_behavioral_analytics_event"
                | ClusterPrivilege.ReadCcr -> "read_ccr"
                | ClusterPrivilege.ReadFleetSecrets -> "read_fleet_secrets"
                | ClusterPrivilege.ReadIlm -> "read_ilm"
                | ClusterPrivilege.ReadPipeline -> "read_pipeline"
                | ClusterPrivilege.ReadSecurity -> "read_security"
                | ClusterPrivilege.ReadSlm -> "read_slm"
                | ClusterPrivilege.TransportClient -> "transport_client"
                | ClusterPrivilege.WriteConnectorSecrets -> "write_connector_secrets"
                | ClusterPrivilege.WriteFleetSecrets -> "write_fleet_secrets"
                | ClusterPrivilege.ReadProjectRouting -> "read_project_routing"
                | ClusterPrivilege.ManageProjectRouting -> "manage_project_routing"
                | ClusterPrivilege.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "all" -> ClusterPrivilege.All
            | "cancel_task" -> ClusterPrivilege.CancelTask
            | "create_snapshot" -> ClusterPrivilege.CreateSnapshot
            | "cross_cluster_replication" -> ClusterPrivilege.CrossClusterReplication
            | "cross_cluster_search" -> ClusterPrivilege.CrossClusterSearch
            | "delegate_pki" -> ClusterPrivilege.DelegatePki
            | "grant_api_key" -> ClusterPrivilege.GrantApiKey
            | "manage" -> ClusterPrivilege.Manage
            | "manage_api_key" -> ClusterPrivilege.ManageApiKey
            | "manage_autoscaling" -> ClusterPrivilege.ManageAutoscaling
            | "manage_behavioral_analytics" -> ClusterPrivilege.ManageBehavioralAnalytics
            | "manage_ccr" -> ClusterPrivilege.ManageCcr
            | "manage_data_frame_transforms" -> ClusterPrivilege.ManageDataFrameTransforms
            | "manage_data_stream_global_retention" -> ClusterPrivilege.ManageDataStreamGlobalRetention
            | "manage_enrich" -> ClusterPrivilege.ManageEnrich
            | "manage_esql" -> ClusterPrivilege.ManageEsql
            | "manage_ilm" -> ClusterPrivilege.ManageIlm
            | "manage_index_templates" -> ClusterPrivilege.ManageIndexTemplates
            | "manage_inference" -> ClusterPrivilege.ManageInference
            | "manage_ingest_pipelines" -> ClusterPrivilege.ManageIngestPipelines
            | "manage_logstash_pipelines" -> ClusterPrivilege.ManageLogstashPipelines
            | "manage_ml" -> ClusterPrivilege.ManageMl
            | "manage_oidc" -> ClusterPrivilege.ManageOidc
            | "manage_own_api_key" -> ClusterPrivilege.ManageOwnApiKey
            | "manage_pipeline" -> ClusterPrivilege.ManagePipeline
            | "manage_rollup" -> ClusterPrivilege.ManageRollup
            | "manage_saml" -> ClusterPrivilege.ManageSaml
            | "manage_search_application" -> ClusterPrivilege.ManageSearchApplication
            | "manage_search_query_rules" -> ClusterPrivilege.ManageSearchQueryRules
            | "manage_search_synonyms" -> ClusterPrivilege.ManageSearchSynonyms
            | "manage_security" -> ClusterPrivilege.ManageSecurity
            | "manage_service_account" -> ClusterPrivilege.ManageServiceAccount
            | "manage_slm" -> ClusterPrivilege.ManageSlm
            | "manage_token" -> ClusterPrivilege.ManageToken
            | "manage_transform" -> ClusterPrivilege.ManageTransform
            | "manage_user_profile" -> ClusterPrivilege.ManageUserProfile
            | "manage_watcher" -> ClusterPrivilege.ManageWatcher
            | "monitor" -> ClusterPrivilege.Monitor
            | "monitor_data_frame_transforms" -> ClusterPrivilege.MonitorDataFrameTransforms
            | "monitor_data_stream_global_retention" -> ClusterPrivilege.MonitorDataStreamGlobalRetention
            | "monitor_enrich" -> ClusterPrivilege.MonitorEnrich
            | "monitor_esql" -> ClusterPrivilege.MonitorEsql
            | "monitor_inference" -> ClusterPrivilege.MonitorInference
            | "monitor_ml" -> ClusterPrivilege.MonitorMl
            | "monitor_rollup" -> ClusterPrivilege.MonitorRollup
            | "monitor_snapshot" -> ClusterPrivilege.MonitorSnapshot
            | "monitor_stats" -> ClusterPrivilege.MonitorStats
            | "monitor_text_structure" -> ClusterPrivilege.MonitorTextStructure
            | "monitor_transform" -> ClusterPrivilege.MonitorTransform
            | "monitor_watcher" -> ClusterPrivilege.MonitorWatcher
            | "none" -> ClusterPrivilege.None
            | "post_behavioral_analytics_event" -> ClusterPrivilege.PostBehavioralAnalyticsEvent
            | "read_ccr" -> ClusterPrivilege.ReadCcr
            | "read_fleet_secrets" -> ClusterPrivilege.ReadFleetSecrets
            | "read_ilm" -> ClusterPrivilege.ReadIlm
            | "read_pipeline" -> ClusterPrivilege.ReadPipeline
            | "read_security" -> ClusterPrivilege.ReadSecurity
            | "read_slm" -> ClusterPrivilege.ReadSlm
            | "transport_client" -> ClusterPrivilege.TransportClient
            | "write_connector_secrets" -> ClusterPrivilege.WriteConnectorSecrets
            | "write_fleet_secrets" -> ClusterPrivilege.WriteFleetSecrets
            | "read_project_routing" -> ClusterPrivilege.ReadProjectRouting
            | "manage_project_routing" -> ClusterPrivilege.ManageProjectRouting
            | other -> ClusterPrivilege.Custom other

    type GrantTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GrantType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GrantType.Password -> "password"
                | GrantType.AccessToken -> "access_token"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "password" -> GrantType.Password
            | "access_token" -> GrantType.AccessToken
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GrantType"))

    type IndexPrivilegeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndexPrivilege>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndexPrivilege.All -> "all"
                | IndexPrivilege.AutoConfigure -> "auto_configure"
                | IndexPrivilege.Create -> "create"
                | IndexPrivilege.CreateDoc -> "create_doc"
                | IndexPrivilege.CreateIndex -> "create_index"
                | IndexPrivilege.CreateView -> "create_view"
                | IndexPrivilege.CrossClusterReplication -> "cross_cluster_replication"
                | IndexPrivilege.CrossClusterReplicationInternal -> "cross_cluster_replication_internal"
                | IndexPrivilege.Delete -> "delete"
                | IndexPrivilege.DeleteIndex -> "delete_index"
                | IndexPrivilege.DeleteView -> "delete_view"
                | IndexPrivilege.Index -> "index"
                | IndexPrivilege.Maintenance -> "maintenance"
                | IndexPrivilege.Manage -> "manage"
                | IndexPrivilege.ManageDataStreamLifecycle -> "manage_data_stream_lifecycle"
                | IndexPrivilege.ManageFollowIndex -> "manage_follow_index"
                | IndexPrivilege.ManageIlm -> "manage_ilm"
                | IndexPrivilege.ManageLeaderIndex -> "manage_leader_index"
                | IndexPrivilege.ManageView -> "manage_view"
                | IndexPrivilege.Monitor -> "monitor"
                | IndexPrivilege.None -> "none"
                | IndexPrivilege.Read -> "read"
                | IndexPrivilege.ReadCrossCluster -> "read_cross_cluster"
                | IndexPrivilege.ReadViewMetadata -> "read_view_metadata"
                | IndexPrivilege.ViewIndexMetadata -> "view_index_metadata"
                | IndexPrivilege.Write -> "write"
                | IndexPrivilege.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "all" -> IndexPrivilege.All
            | "auto_configure" -> IndexPrivilege.AutoConfigure
            | "create" -> IndexPrivilege.Create
            | "create_doc" -> IndexPrivilege.CreateDoc
            | "create_index" -> IndexPrivilege.CreateIndex
            | "create_view" -> IndexPrivilege.CreateView
            | "cross_cluster_replication" -> IndexPrivilege.CrossClusterReplication
            | "cross_cluster_replication_internal" -> IndexPrivilege.CrossClusterReplicationInternal
            | "delete" -> IndexPrivilege.Delete
            | "delete_index" -> IndexPrivilege.DeleteIndex
            | "delete_view" -> IndexPrivilege.DeleteView
            | "index" -> IndexPrivilege.Index
            | "maintenance" -> IndexPrivilege.Maintenance
            | "manage" -> IndexPrivilege.Manage
            | "manage_data_stream_lifecycle" -> IndexPrivilege.ManageDataStreamLifecycle
            | "manage_follow_index" -> IndexPrivilege.ManageFollowIndex
            | "manage_ilm" -> IndexPrivilege.ManageIlm
            | "manage_leader_index" -> IndexPrivilege.ManageLeaderIndex
            | "manage_view" -> IndexPrivilege.ManageView
            | "monitor" -> IndexPrivilege.Monitor
            | "none" -> IndexPrivilege.None
            | "read" -> IndexPrivilege.Read
            | "read_cross_cluster" -> IndexPrivilege.ReadCrossCluster
            | "read_view_metadata" -> IndexPrivilege.ReadViewMetadata
            | "view_index_metadata" -> IndexPrivilege.ViewIndexMetadata
            | "write" -> IndexPrivilege.Write
            | other -> IndexPrivilege.Custom other

    type RemoteClusterPrivilegeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<RemoteClusterPrivilege>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | RemoteClusterPrivilege.MonitorEnrich -> "monitor_enrich"
                | RemoteClusterPrivilege.MonitorStats -> "monitor_stats"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "monitor_enrich" -> RemoteClusterPrivilege.MonitorEnrich
            | "monitor_stats" -> RemoteClusterPrivilege.MonitorStats
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for RemoteClusterPrivilege"))

    type RestrictionWorkflowConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<RestrictionWorkflow>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | RestrictionWorkflow.SearchApplicationQuery -> "search_application_query"
                | RestrictionWorkflow.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "search_application_query" -> RestrictionWorkflow.SearchApplicationQuery
            | other -> RestrictionWorkflow.Custom other

    type RoleMappingRuleConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<RoleMappingRule>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | RoleMappingRule.Any v ->
                writer.WritePropertyName("any")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | RoleMappingRule.All v ->
                writer.WritePropertyName("all")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | RoleMappingRule.Field (field, v) ->
                writer.WritePropertyName("field")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | RoleMappingRule.Except v ->
                writer.WritePropertyName("except")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for RoleMappingRule"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for RoleMappingRule"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "any" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RoleMappingRule list>(&reader, options)
                    RoleMappingRule.Any v
                | "all" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RoleMappingRule list>(&reader, options)
                    RoleMappingRule.All v
                | "field" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.FieldValue list>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    RoleMappingRule.Field (field, v)
                | "except" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RoleMappingRule>(&reader, options)
                    RoleMappingRule.Except v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for RoleMappingRule"))
            reader.Read() |> ignore // EndObject
            result

    type TemplateFormatConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TemplateFormat>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TemplateFormat.String -> "string"
                | TemplateFormat.Json -> "json"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "string" -> TemplateFormat.String
            | "json" -> TemplateFormat.Json
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TemplateFormat"))

    type AccessTokenGrantTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<AccessTokenGrantType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | AccessTokenGrantType.Password -> "password"
                | AccessTokenGrantType.ClientCredentials -> "client_credentials"
                | AccessTokenGrantType.Kerberos -> "_kerberos"
                | AccessTokenGrantType.RefreshToken -> "refresh_token"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "password" -> AccessTokenGrantType.Password
            | "client_credentials" -> AccessTokenGrantType.ClientCredentials
            | "_kerberos" -> AccessTokenGrantType.Kerberos
            | "refresh_token" -> AccessTokenGrantType.RefreshToken
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AccessTokenGrantType"))

    type ApiKeyGrantTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ApiKeyGrantType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ApiKeyGrantType.AccessToken -> "access_token"
                | ApiKeyGrantType.Password -> "password"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "access_token" -> ApiKeyGrantType.AccessToken
            | "password" -> ApiKeyGrantType.Password
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ApiKeyGrantType"))

    type ApiKeyAggregationContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ApiKeyAggregationContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | ApiKeyAggregationContainer.Cardinality v ->
                writer.WritePropertyName("cardinality")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ApiKeyAggregationContainer.Composite v ->
                writer.WritePropertyName("composite")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ApiKeyAggregationContainer.DateRange v ->
                writer.WritePropertyName("date_range")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ApiKeyAggregationContainer.Filter v ->
                writer.WritePropertyName("filter")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ApiKeyAggregationContainer.Filters v ->
                writer.WritePropertyName("filters")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ApiKeyAggregationContainer.Missing v ->
                writer.WritePropertyName("missing")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ApiKeyAggregationContainer.Range v ->
                writer.WritePropertyName("range")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ApiKeyAggregationContainer.Terms v ->
                writer.WritePropertyName("terms")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ApiKeyAggregationContainer.ValueCount v ->
                writer.WritePropertyName("value_count")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ApiKeyAggregationContainer.Unknown (name, el) ->
                writer.WritePropertyName(name)
                el.WriteTo(writer)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for ApiKeyAggregationContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for ApiKeyAggregationContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "cardinality" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.CardinalityAggregation>(&reader, options)
                    ApiKeyAggregationContainer.Cardinality v
                | "composite" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.CompositeAggregation>(&reader, options)
                    ApiKeyAggregationContainer.Composite v
                | "date_range" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DateRangeAggregation>(&reader, options)
                    ApiKeyAggregationContainer.DateRange v
                | "filter" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ApiKeyQueryContainer>(&reader, options)
                    ApiKeyAggregationContainer.Filter v
                | "filters" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ApiKeyFiltersAggregation>(&reader, options)
                    ApiKeyAggregationContainer.Filters v
                | "missing" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MissingAggregation>(&reader, options)
                    ApiKeyAggregationContainer.Missing v
                | "range" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RangeAggregation>(&reader, options)
                    ApiKeyAggregationContainer.Range v
                | "terms" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TermsAggregation>(&reader, options)
                    ApiKeyAggregationContainer.Terms v
                | "value_count" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ValueCountAggregation>(&reader, options)
                    ApiKeyAggregationContainer.ValueCount v
                | other ->
                    let el = System.Text.Json.JsonElement.ParseValue(&reader)
                    ApiKeyAggregationContainer.Unknown (other, el)
            reader.Read() |> ignore // EndObject
            result

    type ApiKeyQueryContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ApiKeyQueryContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | ApiKeyQueryContainer.Bool v ->
                writer.WritePropertyName("bool")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ApiKeyQueryContainer.Exists v ->
                writer.WritePropertyName("exists")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ApiKeyQueryContainer.Ids v ->
                writer.WritePropertyName("ids")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ApiKeyQueryContainer.Match (field, v) ->
                writer.WritePropertyName("match")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | ApiKeyQueryContainer.MatchAll v ->
                writer.WritePropertyName("match_all")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ApiKeyQueryContainer.Prefix (field, v) ->
                writer.WritePropertyName("prefix")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | ApiKeyQueryContainer.Range (field, v) ->
                writer.WritePropertyName("range")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | ApiKeyQueryContainer.SimpleQueryString v ->
                writer.WritePropertyName("simple_query_string")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ApiKeyQueryContainer.Term (field, v) ->
                writer.WritePropertyName("term")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | ApiKeyQueryContainer.Terms v ->
                writer.WritePropertyName("terms")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ApiKeyQueryContainer.Wildcard (field, v) ->
                writer.WritePropertyName("wildcard")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | ApiKeyQueryContainer.Unknown (name, el) ->
                writer.WritePropertyName(name)
                el.WriteTo(writer)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for ApiKeyQueryContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for ApiKeyQueryContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "bool" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.BoolQuery>(&reader, options)
                    ApiKeyQueryContainer.Bool v
                | "exists" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ExistsQuery>(&reader, options)
                    ApiKeyQueryContainer.Exists v
                | "ids" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IdsQuery>(&reader, options)
                    ApiKeyQueryContainer.Ids v
                | "match" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MatchQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    ApiKeyQueryContainer.Match (field, v)
                | "match_all" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MatchAllQuery>(&reader, options)
                    ApiKeyQueryContainer.MatchAll v
                | "prefix" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.PrefixQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    ApiKeyQueryContainer.Prefix (field, v)
                | "range" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RangeQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    ApiKeyQueryContainer.Range (field, v)
                | "simple_query_string" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SimpleQueryStringQuery>(&reader, options)
                    ApiKeyQueryContainer.SimpleQueryString v
                | "term" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TermQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    ApiKeyQueryContainer.Term (field, v)
                | "terms" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TermsQuery>(&reader, options)
                    ApiKeyQueryContainer.Terms v
                | "wildcard" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.WildcardQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    ApiKeyQueryContainer.Wildcard (field, v)
                | other ->
                    let el = System.Text.Json.JsonElement.ParseValue(&reader)
                    ApiKeyQueryContainer.Unknown (other, el)
            reader.Read() |> ignore // EndObject
            result

    type RoleQueryContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<RoleQueryContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | RoleQueryContainer.Bool v ->
                writer.WritePropertyName("bool")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | RoleQueryContainer.Exists v ->
                writer.WritePropertyName("exists")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | RoleQueryContainer.Ids v ->
                writer.WritePropertyName("ids")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | RoleQueryContainer.Match (field, v) ->
                writer.WritePropertyName("match")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | RoleQueryContainer.MatchAll v ->
                writer.WritePropertyName("match_all")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | RoleQueryContainer.Prefix (field, v) ->
                writer.WritePropertyName("prefix")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | RoleQueryContainer.Range (field, v) ->
                writer.WritePropertyName("range")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | RoleQueryContainer.SimpleQueryString v ->
                writer.WritePropertyName("simple_query_string")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | RoleQueryContainer.Term (field, v) ->
                writer.WritePropertyName("term")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | RoleQueryContainer.Terms v ->
                writer.WritePropertyName("terms")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | RoleQueryContainer.Wildcard (field, v) ->
                writer.WritePropertyName("wildcard")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | RoleQueryContainer.Unknown (name, el) ->
                writer.WritePropertyName(name)
                el.WriteTo(writer)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for RoleQueryContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for RoleQueryContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "bool" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.BoolQuery>(&reader, options)
                    RoleQueryContainer.Bool v
                | "exists" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ExistsQuery>(&reader, options)
                    RoleQueryContainer.Exists v
                | "ids" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IdsQuery>(&reader, options)
                    RoleQueryContainer.Ids v
                | "match" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MatchQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    RoleQueryContainer.Match (field, v)
                | "match_all" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MatchAllQuery>(&reader, options)
                    RoleQueryContainer.MatchAll v
                | "prefix" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.PrefixQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    RoleQueryContainer.Prefix (field, v)
                | "range" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RangeQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    RoleQueryContainer.Range (field, v)
                | "simple_query_string" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SimpleQueryStringQuery>(&reader, options)
                    RoleQueryContainer.SimpleQueryString v
                | "term" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TermQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    RoleQueryContainer.Term (field, v)
                | "terms" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TermsQuery>(&reader, options)
                    RoleQueryContainer.Terms v
                | "wildcard" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.WildcardQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    RoleQueryContainer.Wildcard (field, v)
                | other ->
                    let el = System.Text.Json.JsonElement.ParseValue(&reader)
                    RoleQueryContainer.Unknown (other, el)
            reader.Read() |> ignore // EndObject
            result

    type UserQueryContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<UserQueryContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | UserQueryContainer.Ids v ->
                writer.WritePropertyName("ids")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | UserQueryContainer.Bool v ->
                writer.WritePropertyName("bool")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | UserQueryContainer.Exists v ->
                writer.WritePropertyName("exists")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | UserQueryContainer.Match (field, v) ->
                writer.WritePropertyName("match")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | UserQueryContainer.MatchAll v ->
                writer.WritePropertyName("match_all")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | UserQueryContainer.Prefix (field, v) ->
                writer.WritePropertyName("prefix")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | UserQueryContainer.Range (field, v) ->
                writer.WritePropertyName("range")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | UserQueryContainer.SimpleQueryString v ->
                writer.WritePropertyName("simple_query_string")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | UserQueryContainer.Term (field, v) ->
                writer.WritePropertyName("term")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | UserQueryContainer.Terms v ->
                writer.WritePropertyName("terms")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | UserQueryContainer.Wildcard (field, v) ->
                writer.WritePropertyName("wildcard")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | UserQueryContainer.Unknown (name, el) ->
                writer.WritePropertyName(name)
                el.WriteTo(writer)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for UserQueryContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for UserQueryContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "ids" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.IdsQuery>(&reader, options)
                    UserQueryContainer.Ids v
                | "bool" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.BoolQuery>(&reader, options)
                    UserQueryContainer.Bool v
                | "exists" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ExistsQuery>(&reader, options)
                    UserQueryContainer.Exists v
                | "match" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MatchQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    UserQueryContainer.Match (field, v)
                | "match_all" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.MatchAllQuery>(&reader, options)
                    UserQueryContainer.MatchAll v
                | "prefix" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.PrefixQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    UserQueryContainer.Prefix (field, v)
                | "range" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RangeQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    UserQueryContainer.Range (field, v)
                | "simple_query_string" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SimpleQueryStringQuery>(&reader, options)
                    UserQueryContainer.SimpleQueryString v
                | "term" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TermQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    UserQueryContainer.Term (field, v)
                | "terms" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TermsQuery>(&reader, options)
                    UserQueryContainer.Terms v
                | "wildcard" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.WildcardQuery>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    UserQueryContainer.Wildcard (field, v)
                | other ->
                    let el = System.Text.Json.JsonElement.ParseValue(&reader)
                    UserQueryContainer.Unknown (other, el)
            reader.Read() |> ignore // EndObject
            result

    type TypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Type>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Type.Restart -> "restart"
                | Type.Remove -> "remove"
                | Type.Replace -> "replace"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "restart" -> Type.Restart
            | "remove" -> Type.Remove
            | "replace" -> Type.Replace
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Type"))

    type ShutdownStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ShutdownStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ShutdownStatus.NotStarted -> "not_started"
                | ShutdownStatus.InProgress -> "in_progress"
                | ShutdownStatus.Stalled -> "stalled"
                | ShutdownStatus.Complete -> "complete"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "not_started" -> ShutdownStatus.NotStarted
            | "in_progress" -> ShutdownStatus.InProgress
            | "stalled" -> ShutdownStatus.Stalled
            | "complete" -> ShutdownStatus.Complete
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ShutdownStatus"))

    type ShutdownTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ShutdownType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ShutdownType.Remove -> "remove"
                | ShutdownType.Restart -> "restart"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "remove" -> ShutdownType.Remove
            | "restart" -> ShutdownType.Restart
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ShutdownType"))

    type MergeTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MergeType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MergeType.Index -> "index"
                | MergeType.Template -> "template"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "index" -> MergeType.Index
            | "template" -> MergeType.Template
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for MergeType"))

    type RepositoryConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Repository>()

        override _.Write(writer, value, options) =
            match value with
            | Repository.AzureRepository v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Repository.GcsRepository v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Repository.S3Repository v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Repository.SharedFileSystemRepository v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Repository.ReadOnlyUrlRepository v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Repository.SourceOnlyRepository v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Repository.Unknown (_, el) -> el.WriteTo(writer)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(&reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("type") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "azurerepository" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.AzureRepository>(doc.RootElement.GetRawText(), options)
                Repository.AzureRepository v
            | "gcsrepository" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.GcsRepository>(doc.RootElement.GetRawText(), options)
                Repository.GcsRepository v
            | "s3repository" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.S3Repository>(doc.RootElement.GetRawText(), options)
                Repository.S3Repository v
            | "sharedfilesystemrepository" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SharedFileSystemRepository>(doc.RootElement.GetRawText(), options)
                Repository.SharedFileSystemRepository v
            | "readonlyurlrepository" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.ReadOnlyUrlRepository>(doc.RootElement.GetRawText(), options)
                Repository.ReadOnlyUrlRepository v
            | "sourceonlyrepository" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<Types.SourceOnlyRepository>(doc.RootElement.GetRawText(), options)
                Repository.SourceOnlyRepository v
            | _ -> Repository.Unknown (tagValue, doc.RootElement.Clone())

    type ShardsStatsStageConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ShardsStatsStage>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ShardsStatsStage.DONE -> "DONE"
                | ShardsStatsStage.FAILURE -> "FAILURE"
                | ShardsStatsStage.FINALIZE -> "FINALIZE"
                | ShardsStatsStage.INIT -> "INIT"
                | ShardsStatsStage.STARTED -> "STARTED"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "DONE" -> ShardsStatsStage.DONE
            | "FAILURE" -> ShardsStatsStage.FAILURE
            | "FINALIZE" -> ShardsStatsStage.FINALIZE
            | "INIT" -> ShardsStatsStage.INIT
            | "STARTED" -> ShardsStatsStage.STARTED
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ShardsStatsStage"))

    type SnapshotSortConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SnapshotSort>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SnapshotSort.StartTime -> "start_time"
                | SnapshotSort.Duration -> "duration"
                | SnapshotSort.Name -> "name"
                | SnapshotSort.IndexCount -> "index_count"
                | SnapshotSort.Repository -> "repository"
                | SnapshotSort.ShardCount -> "shard_count"
                | SnapshotSort.FailedShardCount -> "failed_shard_count"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "start_time" -> SnapshotSort.StartTime
            | "duration" -> SnapshotSort.Duration
            | "name" -> SnapshotSort.Name
            | "index_count" -> SnapshotSort.IndexCount
            | "repository" -> SnapshotSort.Repository
            | "shard_count" -> SnapshotSort.ShardCount
            | "failed_shard_count" -> SnapshotSort.FailedShardCount
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SnapshotSort"))

    type SnapshotStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SnapshotState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SnapshotState.INPROGRESS -> "IN_PROGRESS"
                | SnapshotState.SUCCESS -> "SUCCESS"
                | SnapshotState.FAILED -> "FAILED"
                | SnapshotState.PARTIAL -> "PARTIAL"
                | SnapshotState.INCOMPATIBLE -> "INCOMPATIBLE"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "IN_PROGRESS" -> SnapshotState.INPROGRESS
            | "SUCCESS" -> SnapshotState.SUCCESS
            | "FAILED" -> SnapshotState.FAILED
            | "PARTIAL" -> SnapshotState.PARTIAL
            | "INCOMPATIBLE" -> SnapshotState.INCOMPATIBLE
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SnapshotState"))

    type SqlFormatConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SqlFormat>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SqlFormat.Csv -> "csv"
                | SqlFormat.Json -> "json"
                | SqlFormat.Tsv -> "tsv"
                | SqlFormat.Txt -> "txt"
                | SqlFormat.Yaml -> "yaml"
                | SqlFormat.Cbor -> "cbor"
                | SqlFormat.Smile -> "smile"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "csv" -> SqlFormat.Csv
            | "json" -> SqlFormat.Json
            | "tsv" -> SqlFormat.Tsv
            | "txt" -> SqlFormat.Txt
            | "yaml" -> SqlFormat.Yaml
            | "cbor" -> SqlFormat.Cbor
            | "smile" -> SqlFormat.Smile
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SqlFormat"))

    type StreamTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<StreamType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | StreamType.Logs -> "logs"
                | StreamType.LogsOtel -> "logs.otel"
                | StreamType.LogsEcs -> "logs.ecs"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "logs" -> StreamType.Logs
            | "logs.otel" -> StreamType.LogsOtel
            | "logs.ecs" -> StreamType.LogsEcs
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for StreamType"))

    type GroupByConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GroupBy>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GroupBy.Nodes -> "nodes"
                | GroupBy.Parents -> "parents"
                | GroupBy.None -> "none"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "nodes" -> GroupBy.Nodes
            | "parents" -> GroupBy.Parents
            | "none" -> GroupBy.None
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GroupBy"))

    type EcsCompatibilityTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<EcsCompatibilityType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | EcsCompatibilityType.Disabled -> "disabled"
                | EcsCompatibilityType.V1 -> "v1"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "disabled" -> EcsCompatibilityType.Disabled
            | "v1" -> EcsCompatibilityType.V1
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for EcsCompatibilityType"))

    type FormatTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<FormatType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | FormatType.Delimited -> "delimited"
                | FormatType.Ndjson -> "ndjson"
                | FormatType.SemiStructuredText -> "semi_structured_text"
                | FormatType.Xml -> "xml"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "delimited" -> FormatType.Delimited
            | "ndjson" -> FormatType.Ndjson
            | "semi_structured_text" -> FormatType.SemiStructuredText
            | "xml" -> FormatType.Xml
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FormatType"))

    type FindStructureFormatConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<FindStructureFormat>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | FindStructureFormat.Ndjson -> "ndjson"
                | FindStructureFormat.Xml -> "xml"
                | FindStructureFormat.Delimited -> "delimited"
                | FindStructureFormat.SemiStructuredText -> "semi_structured_text"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "ndjson" -> FindStructureFormat.Ndjson
            | "xml" -> FindStructureFormat.Xml
            | "delimited" -> FindStructureFormat.Delimited
            | "semi_structured_text" -> FindStructureFormat.SemiStructuredText
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FindStructureFormat"))

    type PivotGroupByContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<PivotGroupByContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | PivotGroupByContainer.DateHistogram v ->
                writer.WritePropertyName("date_histogram")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | PivotGroupByContainer.GeotileGrid v ->
                writer.WritePropertyName("geotile_grid")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | PivotGroupByContainer.Histogram v ->
                writer.WritePropertyName("histogram")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | PivotGroupByContainer.Terms v ->
                writer.WritePropertyName("terms")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for PivotGroupByContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for PivotGroupByContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "date_histogram" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DateHistogramAggregation>(&reader, options)
                    PivotGroupByContainer.DateHistogram v
                | "geotile_grid" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoTileGridAggregation>(&reader, options)
                    PivotGroupByContainer.GeotileGrid v
                | "histogram" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.HistogramAggregation>(&reader, options)
                    PivotGroupByContainer.Histogram v
                | "terms" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TermsAggregation>(&reader, options)
                    PivotGroupByContainer.Terms v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for PivotGroupByContainer"))
            reader.Read() |> ignore // EndObject
            result

    type RetentionPolicyContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<RetentionPolicyContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | RetentionPolicyContainer.Time v ->
                writer.WritePropertyName("time")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for RetentionPolicyContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for RetentionPolicyContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "time" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RetentionPolicy>(&reader, options)
                    RetentionPolicyContainer.Time v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for RetentionPolicyContainer"))
            reader.Read() |> ignore // EndObject
            result

    type SyncContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SyncContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | SyncContainer.Time v ->
                writer.WritePropertyName("time")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for SyncContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for SyncContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "time" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TimeSync>(&reader, options)
                    SyncContainer.Time v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for SyncContainer"))
            reader.Read() |> ignore // EndObject
            result

    type AcknowledgementOptionsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<AcknowledgementOptions>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | AcknowledgementOptions.AwaitsSuccessfulExecution -> "awaits_successful_execution"
                | AcknowledgementOptions.Ackable -> "ackable"
                | AcknowledgementOptions.Acked -> "acked"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "awaits_successful_execution" -> AcknowledgementOptions.AwaitsSuccessfulExecution
            | "ackable" -> AcknowledgementOptions.Ackable
            | "acked" -> AcknowledgementOptions.Acked
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AcknowledgementOptions"))

    type ActionExecutionModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ActionExecutionMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ActionExecutionMode.Simulate -> "simulate"
                | ActionExecutionMode.ForceSimulate -> "force_simulate"
                | ActionExecutionMode.Execute -> "execute"
                | ActionExecutionMode.ForceExecute -> "force_execute"
                | ActionExecutionMode.Skip -> "skip"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "simulate" -> ActionExecutionMode.Simulate
            | "force_simulate" -> ActionExecutionMode.ForceSimulate
            | "execute" -> ActionExecutionMode.Execute
            | "force_execute" -> ActionExecutionMode.ForceExecute
            | "skip" -> ActionExecutionMode.Skip
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ActionExecutionMode"))

    type ActionStatusOptionsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ActionStatusOptions>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ActionStatusOptions.Success -> "success"
                | ActionStatusOptions.Failure -> "failure"
                | ActionStatusOptions.Simulated -> "simulated"
                | ActionStatusOptions.Throttled -> "throttled"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "success" -> ActionStatusOptions.Success
            | "failure" -> ActionStatusOptions.Failure
            | "simulated" -> ActionStatusOptions.Simulated
            | "throttled" -> ActionStatusOptions.Throttled
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ActionStatusOptions"))

    type ActionTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ActionType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ActionType.Email -> "email"
                | ActionType.Webhook -> "webhook"
                | ActionType.Index -> "index"
                | ActionType.Logging -> "logging"
                | ActionType.Slack -> "slack"
                | ActionType.Pagerduty -> "pagerduty"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "email" -> ActionType.Email
            | "webhook" -> ActionType.Webhook
            | "index" -> ActionType.Index
            | "logging" -> ActionType.Logging
            | "slack" -> ActionType.Slack
            | "pagerduty" -> ActionType.Pagerduty
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ActionType"))

    type ConditionContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ConditionContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | ConditionContainer.Always v ->
                writer.WritePropertyName("always")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ConditionContainer.ArrayCompare (field, v) ->
                writer.WritePropertyName("array_compare")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | ConditionContainer.Compare (field, v) ->
                writer.WritePropertyName("compare")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | ConditionContainer.Never v ->
                writer.WritePropertyName("never")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ConditionContainer.Script v ->
                writer.WritePropertyName("script")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for ConditionContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for ConditionContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "always" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.AlwaysCondition>(&reader, options)
                    ConditionContainer.Always v
                | "array_compare" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ArrayCompareCondition>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    ConditionContainer.ArrayCompare (field, v)
                | "compare" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Map<Types.ConditionOp, Types.FieldValue>>(&reader, options)
                    reader.Read() |> ignore // EndObject
                    ConditionContainer.Compare (field, v)
                | "never" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.NeverCondition>(&reader, options)
                    ConditionContainer.Never v
                | "script" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ScriptCondition>(&reader, options)
                    ConditionContainer.Script v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for ConditionContainer"))
            reader.Read() |> ignore // EndObject
            result

    type ConditionOpConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ConditionOp>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ConditionOp.NotEq -> "not_eq"
                | ConditionOp.Eq -> "eq"
                | ConditionOp.Lt -> "lt"
                | ConditionOp.Gt -> "gt"
                | ConditionOp.Lte -> "lte"
                | ConditionOp.Gte -> "gte"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "not_eq" -> ConditionOp.NotEq
            | "eq" -> ConditionOp.Eq
            | "lt" -> ConditionOp.Lt
            | "gt" -> ConditionOp.Gt
            | "lte" -> ConditionOp.Lte
            | "gte" -> ConditionOp.Gte
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ConditionOp"))

    type ConditionTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ConditionType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ConditionType.Always -> "always"
                | ConditionType.Never -> "never"
                | ConditionType.Script -> "script"
                | ConditionType.Compare -> "compare"
                | ConditionType.ArrayCompare -> "array_compare"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "always" -> ConditionType.Always
            | "never" -> ConditionType.Never
            | "script" -> ConditionType.Script
            | "compare" -> ConditionType.Compare
            | "array_compare" -> ConditionType.ArrayCompare
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ConditionType"))

    type ConnectionSchemeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ConnectionScheme>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ConnectionScheme.Http -> "http"
                | ConnectionScheme.Https -> "https"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "http" -> ConnectionScheme.Http
            | "https" -> ConnectionScheme.Https
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ConnectionScheme"))

    type DataAttachmentFormatConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<DataAttachmentFormat>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | DataAttachmentFormat.Json -> "json"
                | DataAttachmentFormat.Yaml -> "yaml"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "json" -> DataAttachmentFormat.Json
            | "yaml" -> DataAttachmentFormat.Yaml
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DataAttachmentFormat"))

    type DayConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Day>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Day.Sunday -> "sunday"
                | Day.Monday -> "monday"
                | Day.Tuesday -> "tuesday"
                | Day.Wednesday -> "wednesday"
                | Day.Thursday -> "thursday"
                | Day.Friday -> "friday"
                | Day.Saturday -> "saturday"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "sunday" -> Day.Sunday
            | "monday" -> Day.Monday
            | "tuesday" -> Day.Tuesday
            | "wednesday" -> Day.Wednesday
            | "thursday" -> Day.Thursday
            | "friday" -> Day.Friday
            | "saturday" -> Day.Saturday
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Day"))

    type EmailAttachmentContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<EmailAttachmentContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | EmailAttachmentContainer.Http v ->
                writer.WritePropertyName("http")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | EmailAttachmentContainer.Reporting v ->
                writer.WritePropertyName("reporting")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | EmailAttachmentContainer.Data v ->
                writer.WritePropertyName("data")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for EmailAttachmentContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for EmailAttachmentContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "http" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.HttpEmailAttachment>(&reader, options)
                    EmailAttachmentContainer.Http v
                | "reporting" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ReportingEmailAttachment>(&reader, options)
                    EmailAttachmentContainer.Reporting v
                | "data" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DataEmailAttachment>(&reader, options)
                    EmailAttachmentContainer.Data v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for EmailAttachmentContainer"))
            reader.Read() |> ignore // EndObject
            result

    type EmailPriorityConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<EmailPriority>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | EmailPriority.Lowest -> "lowest"
                | EmailPriority.Low -> "low"
                | EmailPriority.Normal -> "normal"
                | EmailPriority.High -> "high"
                | EmailPriority.Highest -> "highest"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "lowest" -> EmailPriority.Lowest
            | "low" -> EmailPriority.Low
            | "normal" -> EmailPriority.Normal
            | "high" -> EmailPriority.High
            | "highest" -> EmailPriority.Highest
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for EmailPriority"))

    type ExecutionPhaseConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ExecutionPhase>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ExecutionPhase.AwaitsExecution -> "awaits_execution"
                | ExecutionPhase.Started -> "started"
                | ExecutionPhase.Input -> "input"
                | ExecutionPhase.Condition -> "condition"
                | ExecutionPhase.Actions -> "actions"
                | ExecutionPhase.WatchTransform -> "watch_transform"
                | ExecutionPhase.Aborted -> "aborted"
                | ExecutionPhase.Finished -> "finished"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "awaits_execution" -> ExecutionPhase.AwaitsExecution
            | "started" -> ExecutionPhase.Started
            | "input" -> ExecutionPhase.Input
            | "condition" -> ExecutionPhase.Condition
            | "actions" -> ExecutionPhase.Actions
            | "watch_transform" -> ExecutionPhase.WatchTransform
            | "aborted" -> ExecutionPhase.Aborted
            | "finished" -> ExecutionPhase.Finished
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ExecutionPhase"))

    type ExecutionStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ExecutionStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ExecutionStatus.AwaitsExecution -> "awaits_execution"
                | ExecutionStatus.Checking -> "checking"
                | ExecutionStatus.ExecutionNotNeeded -> "execution_not_needed"
                | ExecutionStatus.Throttled -> "throttled"
                | ExecutionStatus.Executed -> "executed"
                | ExecutionStatus.Failed -> "failed"
                | ExecutionStatus.DeletedWhileQueued -> "deleted_while_queued"
                | ExecutionStatus.NotExecutedAlreadyQueued -> "not_executed_already_queued"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "awaits_execution" -> ExecutionStatus.AwaitsExecution
            | "checking" -> ExecutionStatus.Checking
            | "execution_not_needed" -> ExecutionStatus.ExecutionNotNeeded
            | "throttled" -> ExecutionStatus.Throttled
            | "executed" -> ExecutionStatus.Executed
            | "failed" -> ExecutionStatus.Failed
            | "deleted_while_queued" -> ExecutionStatus.DeletedWhileQueued
            | "not_executed_already_queued" -> ExecutionStatus.NotExecutedAlreadyQueued
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ExecutionStatus"))

    type HttpInputMethodConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<HttpInputMethod>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | HttpInputMethod.Head -> "head"
                | HttpInputMethod.Get -> "get"
                | HttpInputMethod.Post -> "post"
                | HttpInputMethod.Put -> "put"
                | HttpInputMethod.Delete -> "delete"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "head" -> HttpInputMethod.Head
            | "get" -> HttpInputMethod.Get
            | "post" -> HttpInputMethod.Post
            | "put" -> HttpInputMethod.Put
            | "delete" -> HttpInputMethod.Delete
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for HttpInputMethod"))

    type InputContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InputContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | InputContainer.Chain v ->
                writer.WritePropertyName("chain")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InputContainer.Http v ->
                writer.WritePropertyName("http")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InputContainer.Search v ->
                writer.WritePropertyName("search")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InputContainer.Simple v ->
                writer.WritePropertyName("simple")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for InputContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for InputContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "chain" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ChainInput>(&reader, options)
                    InputContainer.Chain v
                | "http" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.HttpInput>(&reader, options)
                    InputContainer.Http v
                | "search" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SearchInput>(&reader, options)
                    InputContainer.Search v
                | "simple" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Map<string, System.Text.Json.JsonElement>>(&reader, options)
                    InputContainer.Simple v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for InputContainer"))
            reader.Read() |> ignore // EndObject
            result

    type InputTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InputType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InputType.Http -> "http"
                | InputType.Search -> "search"
                | InputType.Simple -> "simple"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "http" -> InputType.Http
            | "search" -> InputType.Search
            | "simple" -> InputType.Simple
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for InputType"))

    type MonthConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Month>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Month.January -> "january"
                | Month.February -> "february"
                | Month.March -> "march"
                | Month.April -> "april"
                | Month.May -> "may"
                | Month.June -> "june"
                | Month.July -> "july"
                | Month.August -> "august"
                | Month.September -> "september"
                | Month.October -> "october"
                | Month.November -> "november"
                | Month.December -> "december"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "january" -> Month.January
            | "february" -> Month.February
            | "march" -> Month.March
            | "april" -> Month.April
            | "may" -> Month.May
            | "june" -> Month.June
            | "july" -> Month.July
            | "august" -> Month.August
            | "september" -> Month.September
            | "october" -> Month.October
            | "november" -> Month.November
            | "december" -> Month.December
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Month"))

    type PagerDutyContextTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<PagerDutyContextType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | PagerDutyContextType.Link -> "link"
                | PagerDutyContextType.Image -> "image"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "link" -> PagerDutyContextType.Link
            | "image" -> PagerDutyContextType.Image
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for PagerDutyContextType"))

    type PagerDutyEventTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<PagerDutyEventType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | PagerDutyEventType.Trigger -> "trigger"
                | PagerDutyEventType.Resolve -> "resolve"
                | PagerDutyEventType.Acknowledge -> "acknowledge"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "trigger" -> PagerDutyEventType.Trigger
            | "resolve" -> PagerDutyEventType.Resolve
            | "acknowledge" -> PagerDutyEventType.Acknowledge
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for PagerDutyEventType"))

    type QuantifierConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Quantifier>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Quantifier.Some -> "some"
                | Quantifier.All -> "all"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "some" -> Quantifier.Some
            | "all" -> Quantifier.All
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Quantifier"))

    type ResponseContentTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ResponseContentType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ResponseContentType.Json -> "json"
                | ResponseContentType.Yaml -> "yaml"
                | ResponseContentType.Text -> "text"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "json" -> ResponseContentType.Json
            | "yaml" -> ResponseContentType.Yaml
            | "text" -> ResponseContentType.Text
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ResponseContentType"))

    type ScheduleContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ScheduleContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | ScheduleContainer.Timezone v ->
                writer.WritePropertyName("timezone")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ScheduleContainer.Cron v ->
                writer.WritePropertyName("cron")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ScheduleContainer.Daily v ->
                writer.WritePropertyName("daily")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ScheduleContainer.Hourly v ->
                writer.WritePropertyName("hourly")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ScheduleContainer.Interval v ->
                writer.WritePropertyName("interval")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ScheduleContainer.Monthly v ->
                writer.WritePropertyName("monthly")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ScheduleContainer.Weekly v ->
                writer.WritePropertyName("weekly")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ScheduleContainer.Yearly v ->
                writer.WritePropertyName("yearly")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for ScheduleContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for ScheduleContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "timezone" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<string>(&reader, options)
                    ScheduleContainer.Timezone v
                | "cron" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.CronExpression>(&reader, options)
                    ScheduleContainer.Cron v
                | "daily" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DailySchedule>(&reader, options)
                    ScheduleContainer.Daily v
                | "hourly" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.HourlySchedule>(&reader, options)
                    ScheduleContainer.Hourly v
                | "interval" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.Duration>(&reader, options)
                    ScheduleContainer.Interval v
                | "monthly" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TimeOfMonth list>(&reader, options)
                    ScheduleContainer.Monthly v
                | "weekly" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TimeOfWeek list>(&reader, options)
                    ScheduleContainer.Weekly v
                | "yearly" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TimeOfYear list>(&reader, options)
                    ScheduleContainer.Yearly v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for ScheduleContainer"))
            reader.Read() |> ignore // EndObject
            result

    type TriggerContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TriggerContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | TriggerContainer.Schedule v ->
                writer.WritePropertyName("schedule")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for TriggerContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for TriggerContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "schedule" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ScheduleContainer>(&reader, options)
                    TriggerContainer.Schedule v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for TriggerContainer"))
            reader.Read() |> ignore // EndObject
            result

    type TriggerEventContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TriggerEventContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | TriggerEventContainer.Schedule v ->
                writer.WritePropertyName("schedule")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for TriggerEventContainer"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for TriggerEventContainer"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "schedule" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ScheduleTriggerEvent>(&reader, options)
                    TriggerEventContainer.Schedule v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for TriggerEventContainer"))
            reader.Read() |> ignore // EndObject
            result

    type WatcherMetricConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherMetric>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatcherMetric.All -> "_all"
                | WatcherMetric.QueuedWatches -> "queued_watches"
                | WatcherMetric.CurrentWatches -> "current_watches"
                | WatcherMetric.PendingWatches -> "pending_watches"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "_all" -> WatcherMetric.All
            | "queued_watches" -> WatcherMetric.QueuedWatches
            | "current_watches" -> WatcherMetric.CurrentWatches
            | "pending_watches" -> WatcherMetric.PendingWatches
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for WatcherMetric"))

    type WatcherStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatcherState.Stopped -> "stopped"
                | WatcherState.Starting -> "starting"
                | WatcherState.Started -> "started"
                | WatcherState.Stopping -> "stopping"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "stopped" -> WatcherState.Stopped
            | "starting" -> WatcherState.Starting
            | "started" -> WatcherState.Started
            | "stopping" -> WatcherState.Stopping
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for WatcherState"))

    type XPackCategoryConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<XPackCategory>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | XPackCategory.Build -> "build"
                | XPackCategory.Features -> "features"
                | XPackCategory.License -> "license"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "build" -> XPackCategory.Build
            | "features" -> XPackCategory.Features
            | "license" -> XPackCategory.License
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for XPackCategory"))


    let registerAll (options: System.Text.Json.JsonSerializerOptions) =
        options.Converters.Add(FailureStoreStatusConverter())
        options.Converters.Add(OperationContainerConverter())
        options.Converters.Add(OperationTypeConverter())
        options.Converters.Add(RestMethodConverter())
        options.Converters.Add(ImpactAreaConverter())
        options.Converters.Add(IndicatorHealthStatusConverter())
        options.Converters.Add(PainlessContextConverter())
        options.Converters.Add(BoundaryScannerConverter())
        options.Converters.Add(FieldSuggesterConverter())
        options.Converters.Add(HighlighterEncoderConverter())
        options.Converters.Add(HighlighterFragmenterConverter())
        options.Converters.Add(HighlighterOrderConverter())
        options.Converters.Add(HighlighterTagsSchemaConverter())
        options.Converters.Add(HighlighterTypeConverter())
        options.Converters.Add(RescoreConverter())
        options.Converters.Add(ScoreModeConverter())
        options.Converters.Add(SmoothingModelContainerConverter())
        options.Converters.Add(StringDistanceConverter())
        options.Converters.Add(SuggestSortConverter())
        options.Converters.Add(TotalHitsRelationConverter())
        options.Converters.Add(GridAggregationTypeConverter())
        options.Converters.Add(GridTypeConverter())
        options.Converters.Add(BytesConverter())
        options.Converters.Add(ClusterInfoTargetConverter())
        options.Converters.Add(ClusterSearchStatusConverter())
        options.Converters.Add(CommonStatsFlagConverter())
        options.Converters.Add(ConflictsConverter())
        options.Converters.Add(DFIIndependenceMeasureConverter())
        options.Converters.Add(DFRAfterEffectConverter())
        options.Converters.Add(DFRBasicModelConverter())
        options.Converters.Add(DistanceUnitConverter())
        options.Converters.Add(DiversifyRetrieverTypesConverter())
        options.Converters.Add(ExpandWildcardConverter())
        options.Converters.Add(FieldSortNumericTypeConverter())
        options.Converters.Add(GeoDistanceTypeConverter())
        options.Converters.Add(GeoShapeRelationConverter())
        options.Converters.Add(HealthStatusConverter())
        options.Converters.Add(IBDistributionConverter())
        options.Converters.Add(IBLambdaConverter())
        options.Converters.Add(LevelConverter())
        options.Converters.Add(LifecycleOperationModeConverter())
        options.Converters.Add(NodeRoleConverter())
        options.Converters.Add(NodeStatsLevelConverter())
        options.Converters.Add(NormalizationConverter())
        options.Converters.Add(OpTypeConverter())
        options.Converters.Add(QueryVectorBuilderConverter())
        options.Converters.Add(RankContainerConverter())
        options.Converters.Add(RefreshConverter())
        options.Converters.Add(ResultConverter())
        options.Converters.Add(RetrieverContainerConverter())
        options.Converters.Add(ScoreNormalizerConverter())
        options.Converters.Add(ScriptLanguageConverter())
        options.Converters.Add(ScriptSortTypeConverter())
        options.Converters.Add(SearchTypeConverter())
        options.Converters.Add(SlicesCalculationConverter())
        options.Converters.Add(SortModeConverter())
        options.Converters.Add(SortOptionsConverter())
        options.Converters.Add(SortOrderConverter())
        options.Converters.Add(SuggestModeConverter())
        options.Converters.Add(ThreadTypeConverter())
        options.Converters.Add(TimeUnitConverter())
        options.Converters.Add(TransformContainerConverter())
        options.Converters.Add(VersionTypeConverter())
        options.Converters.Add(WaitForActiveShardOptionsConverter())
        options.Converters.Add(WaitForEventsConverter())
        options.Converters.Add(AggregationContainerConverter())
        options.Converters.Add(CalendarIntervalConverter())
        options.Converters.Add(CardinalityExecutionModeConverter())
        options.Converters.Add(ChangeTypeConverter())
        options.Converters.Add(CompositeAggregationSourceConverter())
        options.Converters.Add(GapPolicyConverter())
        options.Converters.Add(HoltWintersTypeConverter())
        options.Converters.Add(InferenceConfigContainerConverter())
        options.Converters.Add(MinimumIntervalConverter())
        options.Converters.Add(MissingOrderConverter())
        options.Converters.Add(MovingAverageAggregationConverter())
        options.Converters.Add(MultiTermLookupConverter())
        options.Converters.Add(NormalizeMethodConverter())
        options.Converters.Add(RateModeConverter())
        options.Converters.Add(SamplerAggregationExecutionHintConverter())
        options.Converters.Add(TDigestExecutionHintConverter())
        options.Converters.Add(TTestTypeConverter())
        options.Converters.Add(TermsAggregationCollectModeConverter())
        options.Converters.Add(TermsAggregationExecutionHintConverter())
        options.Converters.Add(ValueTypeConverter())
        options.Converters.Add(AnalyzerConverter())
        options.Converters.Add(CharFilterDefinitionConverter())
        options.Converters.Add(CjkBigramIgnoredScriptConverter())
        options.Converters.Add(DelimitedPayloadEncodingConverter())
        options.Converters.Add(EdgeNGramSideConverter())
        options.Converters.Add(IcuCollationAlternateConverter())
        options.Converters.Add(IcuCollationCaseFirstConverter())
        options.Converters.Add(IcuCollationDecompositionConverter())
        options.Converters.Add(IcuCollationStrengthConverter())
        options.Converters.Add(IcuNormalizationModeConverter())
        options.Converters.Add(IcuNormalizationTypeConverter())
        options.Converters.Add(IcuTransformDirectionConverter())
        options.Converters.Add(KeepTypesModeConverter())
        options.Converters.Add(KuromojiTokenizationModeConverter())
        options.Converters.Add(LowercaseTokenFilterLanguagesConverter())
        options.Converters.Add(NoriDecompoundModeConverter())
        options.Converters.Add(NormalizerConverter())
        options.Converters.Add(PhoneticEncoderConverter())
        options.Converters.Add(PhoneticLanguageConverter())
        options.Converters.Add(PhoneticNameTypeConverter())
        options.Converters.Add(PhoneticRuleTypeConverter())
        options.Converters.Add(SnowballLanguageConverter())
        options.Converters.Add(StopWordLanguageConverter())
        options.Converters.Add(SynonymFormatConverter())
        options.Converters.Add(TokenCharConverter())
        options.Converters.Add(TokenFilterDefinitionConverter())
        options.Converters.Add(TokenizerDefinitionConverter())
        options.Converters.Add(DenseVectorElementTypeConverter())
        options.Converters.Add(DenseVectorIndexOptionsTypeConverter())
        options.Converters.Add(DenseVectorSimilarityConverter())
        options.Converters.Add(DynamicMappingConverter())
        options.Converters.Add(DynamicTemplateConverter())
        options.Converters.Add(FieldTypeConverter())
        options.Converters.Add(GeoOrientationConverter())
        options.Converters.Add(GeoPointMetricTypeConverter())
        options.Converters.Add(GeoStrategyConverter())
        options.Converters.Add(IndexOptionsConverter())
        options.Converters.Add(MatchTypeConverter())
        options.Converters.Add(OnScriptErrorConverter())
        options.Converters.Add(PropertyConverter())
        options.Converters.Add(RankVectorElementTypeConverter())
        options.Converters.Add(RuntimeFieldTypeConverter())
        options.Converters.Add(SourceFieldModeConverter())
        options.Converters.Add(SubobjectsConverter())
        options.Converters.Add(SyntheticSourceKeepEnumConverter())
        options.Converters.Add(TermVectorOptionConverter())
        options.Converters.Add(TimeSeriesMetricTypeConverter())
        options.Converters.Add(ChildScoreModeConverter())
        options.Converters.Add(CombinedFieldsOperatorConverter())
        options.Converters.Add(CombinedFieldsZeroTermsConverter())
        options.Converters.Add(FieldValueFactorModifierConverter())
        options.Converters.Add(FunctionBoostModeConverter())
        options.Converters.Add(FunctionScoreContainerConverter())
        options.Converters.Add(FunctionScoreModeConverter())
        options.Converters.Add(GeoExecutionConverter())
        options.Converters.Add(GeoGridQueryConverter())
        options.Converters.Add(GeoValidationMethodConverter())
        options.Converters.Add(IntervalsContainerConverter())
        options.Converters.Add(IntervalsFilterConverter())
        options.Converters.Add(IntervalsQueryConverter())
        options.Converters.Add(MultiValueModeConverter())
        options.Converters.Add(OperatorConverter())
        options.Converters.Add(PinnedQueryConverter())
        options.Converters.Add(QueryContainerConverter())
        options.Converters.Add(RangeRelationConverter())
        options.Converters.Add(SimpleQueryStringFlagConverter())
        options.Converters.Add(SpanQueryConverter())
        options.Converters.Add(SparseVectorQueryConverter())
        options.Converters.Add(TextQueryTypeConverter())
        options.Converters.Add(ZeroTermsQueryConverter())
        options.Converters.Add(CatAliasesColumnConverter())
        options.Converters.Add(CatAllocationColumnConverter())
        options.Converters.Add(CatAnomalyDetectorColumnConverter())
        options.Converters.Add(CatCircuitBreakerColumnConverter())
        options.Converters.Add(CatComponentColumnConverter())
        options.Converters.Add(CatCountColumnConverter())
        options.Converters.Add(CatDatafeedColumnConverter())
        options.Converters.Add(CatDfaColumnConverter())
        options.Converters.Add(CatFieldDataColumnConverter())
        options.Converters.Add(CatHealthColumnConverter())
        options.Converters.Add(CatIndicesColumnConverter())
        options.Converters.Add(CatMasterColumnConverter())
        options.Converters.Add(CatNodeColumnConverter())
        options.Converters.Add(CatNodeattrsColumnConverter())
        options.Converters.Add(CatPendingTasksColumnConverter())
        options.Converters.Add(CatPluginsColumnConverter())
        options.Converters.Add(CatRecoveryColumnConverter())
        options.Converters.Add(CatSegmentsColumnConverter())
        options.Converters.Add(CatShardColumnConverter())
        options.Converters.Add(CatSnapshotsColumnConverter())
        options.Converters.Add(CatTasksColumnConverter())
        options.Converters.Add(CatTemplatesColumnConverter())
        options.Converters.Add(CatThreadPoolColumnConverter())
        options.Converters.Add(CatTrainedModelsColumnConverter())
        options.Converters.Add(CatTransformColumnConverter())
        options.Converters.Add(FollowerIndexStatusConverter())
        options.Converters.Add(AllocationExplainDecisionConverter())
        options.Converters.Add(DecisionConverter())
        options.Converters.Add(UnassignedInformationReasonConverter())
        options.Converters.Add(ClusterRemoteInfoConverter())
        options.Converters.Add(ClusterStateMetricConverter())
        options.Converters.Add(ShardStateConverter())
        options.Converters.Add(SortTypeConverter())
        options.Converters.Add(ConnectorFieldTypeConverter())
        options.Converters.Add(ConnectorStatusConverter())
        options.Converters.Add(DisplayTypeConverter())
        options.Converters.Add(FilteringPolicyConverter())
        options.Converters.Add(FilteringRuleRuleConverter())
        options.Converters.Add(FilteringValidationStateConverter())
        options.Converters.Add(SyncJobTriggerMethodConverter())
        options.Converters.Add(SyncJobTypeConverter())
        options.Converters.Add(SyncStatusConverter())
        options.Converters.Add(ValidationConverter())
        options.Converters.Add(PolicyTypeConverter())
        options.Converters.Add(EnrichPolicyPhaseConverter())
        options.Converters.Add(ResultPositionConverter())
        options.Converters.Add(EsqlClusterStatusConverter())
        options.Converters.Add(EsqlFormatConverter())
        options.Converters.Add(TableValuesContainerConverter())
        options.Converters.Add(LifecycleExplainConverter())
        options.Converters.Add(IndexCheckOnStartupConverter())
        options.Converters.Add(IndexModeConverter())
        options.Converters.Add(IndexRoutingAllocationOptionsConverter())
        options.Converters.Add(IndexRoutingRebalanceOptionsConverter())
        options.Converters.Add(IndicesBlockOptionsConverter())
        options.Converters.Add(ManagedByConverter())
        options.Converters.Add(NumericFielddataFormatConverter())
        options.Converters.Add(SamplingMethodConverter())
        options.Converters.Add(SegmentSortMissingConverter())
        options.Converters.Add(SegmentSortModeConverter())
        options.Converters.Add(SegmentSortOrderConverter())
        options.Converters.Add(SettingsSimilarityConverter())
        options.Converters.Add(SourceModeConverter())
        options.Converters.Add(StorageTypeConverter())
        options.Converters.Add(TranslogDurabilityConverter())
        options.Converters.Add(IndicesGetFeatureConverter())
        options.Converters.Add(ModeEnumConverter())
        options.Converters.Add(IndicesModifyDataStreamActionConverter())
        options.Converters.Add(RecoveryStageConverter())
        options.Converters.Add(RecoveryTypeConverter())
        options.Converters.Add(ShardStoreAllocationConverter())
        options.Converters.Add(ShardStoreStatusConverter())
        options.Converters.Add(IndexMetadataStateConverter())
        options.Converters.Add(ShardRoutingStateConverter())
        options.Converters.Add(IndicesUpdateAliasesActionConverter())
        options.Converters.Add(Ai21ServiceTypeConverter())
        options.Converters.Add(Ai21TaskTypeConverter())
        options.Converters.Add(AlibabaCloudServiceTypeConverter())
        options.Converters.Add(AlibabaCloudTaskTypeConverter())
        options.Converters.Add(AmazonBedrockServiceTypeConverter())
        options.Converters.Add(AmazonBedrockTaskTypeConverter())
        options.Converters.Add(AmazonSageMakerApiConverter())
        options.Converters.Add(AmazonSageMakerServiceTypeConverter())
        options.Converters.Add(AnthropicServiceTypeConverter())
        options.Converters.Add(AnthropicTaskTypeConverter())
        options.Converters.Add(AzureAiStudioServiceTypeConverter())
        options.Converters.Add(AzureAiStudioTaskTypeConverter())
        options.Converters.Add(AzureOpenAIServiceTypeConverter())
        options.Converters.Add(AzureOpenAITaskTypeConverter())
        options.Converters.Add(CohereEmbeddingTypeConverter())
        options.Converters.Add(CohereInputTypeConverter())
        options.Converters.Add(CohereServiceTypeConverter())
        options.Converters.Add(CohereSimilarityTypeConverter())
        options.Converters.Add(CohereTaskTypeConverter())
        options.Converters.Add(CohereTruncateTypeConverter())
        options.Converters.Add(ContentTypeConverter())
        options.Converters.Add(ContextualAIServiceTypeConverter())
        options.Converters.Add(CustomServiceInputTypeConverter())
        options.Converters.Add(CustomServiceTypeConverter())
        options.Converters.Add(CustomTaskTypeConverter())
        options.Converters.Add(DeepSeekServiceTypeConverter())
        options.Converters.Add(ElasticsearchServiceTypeConverter())
        options.Converters.Add(ElasticsearchTaskTypeConverter())
        options.Converters.Add(ElserServiceTypeConverter())
        options.Converters.Add(ElserTaskTypeConverter())
        options.Converters.Add(EmbeddingContentFormatConverter())
        options.Converters.Add(EmbeddingContentTypeConverter())
        options.Converters.Add(EmbeddingInferenceResultConverter())
        options.Converters.Add(FireworksAIServiceTypeConverter())
        options.Converters.Add(FireworksAISimilarityTypeConverter())
        options.Converters.Add(FireworksAITaskTypeConverter())
        options.Converters.Add(GoogleAiServiceTypeConverter())
        options.Converters.Add(GoogleAiStudioTaskTypeConverter())
        options.Converters.Add(GoogleModelGardenProviderConverter())
        options.Converters.Add(GoogleVertexAIServiceTypeConverter())
        options.Converters.Add(GoogleVertexAITaskTypeConverter())
        options.Converters.Add(GroqServiceTypeConverter())
        options.Converters.Add(GroqTaskTypeConverter())
        options.Converters.Add(HuggingFaceServiceTypeConverter())
        options.Converters.Add(HuggingFaceTaskTypeConverter())
        options.Converters.Add(ImageUrlDetailConverter())
        options.Converters.Add(InferenceResultConverter())
        options.Converters.Add(JinaAIElementTypeConverter())
        options.Converters.Add(JinaAIServiceTypeConverter())
        options.Converters.Add(JinaAISimilarityTypeConverter())
        options.Converters.Add(JinaAITaskTypeConverter())
        options.Converters.Add(JinaAITextEmbeddingTaskConverter())
        options.Converters.Add(LlamaServiceTypeConverter())
        options.Converters.Add(LlamaSimilarityTypeConverter())
        options.Converters.Add(LlamaTaskTypeConverter())
        options.Converters.Add(MistralServiceTypeConverter())
        options.Converters.Add(MistralTaskTypeConverter())
        options.Converters.Add(NvidiaInputTypeConverter())
        options.Converters.Add(NvidiaServiceTypeConverter())
        options.Converters.Add(NvidiaSimilarityTypeConverter())
        options.Converters.Add(NvidiaTaskTypeConverter())
        options.Converters.Add(OpenAIServiceTypeConverter())
        options.Converters.Add(OpenAISimilarityTypeConverter())
        options.Converters.Add(OpenAITaskTypeConverter())
        options.Converters.Add(OpenShiftAiServiceTypeConverter())
        options.Converters.Add(OpenShiftAiSimilarityTypeConverter())
        options.Converters.Add(OpenShiftAiTaskTypeConverter())
        options.Converters.Add(ReasoningDetailConverter())
        options.Converters.Add(ReasoningEffortConverter())
        options.Converters.Add(ReasoningSummaryConverter())
        options.Converters.Add(TaskTypeConverter())
        options.Converters.Add(TaskTypeAi21Converter())
        options.Converters.Add(TaskTypeAlibabaCloudAIConverter())
        options.Converters.Add(TaskTypeAmazonBedrockConverter())
        options.Converters.Add(TaskTypeAmazonSageMakerConverter())
        options.Converters.Add(TaskTypeAnthropicConverter())
        options.Converters.Add(TaskTypeAzureAIStudioConverter())
        options.Converters.Add(TaskTypeAzureOpenAIConverter())
        options.Converters.Add(TaskTypeCohereConverter())
        options.Converters.Add(TaskTypeContextualAIConverter())
        options.Converters.Add(TaskTypeCustomConverter())
        options.Converters.Add(TaskTypeDeepSeekConverter())
        options.Converters.Add(TaskTypeELSERConverter())
        options.Converters.Add(TaskTypeElasticsearchConverter())
        options.Converters.Add(TaskTypeFireworksAIConverter())
        options.Converters.Add(TaskTypeGoogleAIStudioConverter())
        options.Converters.Add(TaskTypeGoogleVertexAIConverter())
        options.Converters.Add(TaskTypeGroqConverter())
        options.Converters.Add(TaskTypeHuggingFaceConverter())
        options.Converters.Add(TaskTypeJinaAiConverter())
        options.Converters.Add(TaskTypeLlamaConverter())
        options.Converters.Add(TaskTypeMistralConverter())
        options.Converters.Add(TaskTypeNvidiaConverter())
        options.Converters.Add(TaskTypeOpenAIConverter())
        options.Converters.Add(TaskTypeOpenShiftAiConverter())
        options.Converters.Add(TaskTypeVoyageAIConverter())
        options.Converters.Add(TaskTypeWatsonxConverter())
        options.Converters.Add(TextEmbeddingInferenceResultConverter())
        options.Converters.Add(VoyageAIServiceTypeConverter())
        options.Converters.Add(VoyageAITaskTypeConverter())
        options.Converters.Add(WatsonxServiceTypeConverter())
        options.Converters.Add(WatsonxTaskTypeConverter())
        options.Converters.Add(ConvertTypeConverter())
        options.Converters.Add(DatabaseConfigurationConverter())
        options.Converters.Add(DatabaseConfigurationFullConverter())
        options.Converters.Add(FieldAccessPatternConverter())
        options.Converters.Add(FingerprintDigestConverter())
        options.Converters.Add(GeoGridTargetFormatConverter())
        options.Converters.Add(GeoGridTileTypeConverter())
        options.Converters.Add(InferenceConfigConverter())
        options.Converters.Add(JsonProcessorConflictStrategyConverter())
        options.Converters.Add(PipelineSimulationStatusOptionsConverter())
        options.Converters.Add(ProcessorContainerConverter())
        options.Converters.Add(ShapeTypeConverter())
        options.Converters.Add(UserAgentPropertyConverter())
        options.Converters.Add(LicenseStatusConverter())
        options.Converters.Add(LicenseTypeConverter())
        options.Converters.Add(DeprecationLevelConverter())
        options.Converters.Add(MigrationStatusConverter())
        options.Converters.Add(AppliesToConverter())
        options.Converters.Add(CategorizationStatusConverter())
        options.Converters.Add(ChunkingModeConverter())
        options.Converters.Add(ConditionOperatorConverter())
        options.Converters.Add(DatafeedStateConverter())
        options.Converters.Add(DataframeAnalysisContainerConverter())
        options.Converters.Add(DataframeAnalysisFeatureProcessorConverter())
        options.Converters.Add(DataframeAnalyticsStatsContainerConverter())
        options.Converters.Add(DataframeEvaluationContainerConverter())
        options.Converters.Add(DataframeStateConverter())
        options.Converters.Add(DeploymentAllocationStateConverter())
        options.Converters.Add(DeploymentAssignmentStateConverter())
        options.Converters.Add(ExcludeFrequentConverter())
        options.Converters.Add(FilterTypeConverter())
        options.Converters.Add(IncludeConverter())
        options.Converters.Add(InferenceConfigCreateContainerConverter())
        options.Converters.Add(InferenceConfigUpdateContainerConverter())
        options.Converters.Add(JobBlockedReasonConverter())
        options.Converters.Add(JobStateConverter())
        options.Converters.Add(MemoryStatusConverter())
        options.Converters.Add(RoutingStateConverter())
        options.Converters.Add(RuleActionConverter())
        options.Converters.Add(SnapshotUpgradeStateConverter())
        options.Converters.Add(TokenizationConfigContainerConverter())
        options.Converters.Add(TokenizationTruncateConverter())
        options.Converters.Add(TrainedModelTypeConverter())
        options.Converters.Add(TrainingPriorityConverter())
        options.Converters.Add(PreprocessorConverter())
        options.Converters.Add(NodesInfoMetricConverter())
        options.Converters.Add(NodeStatsMetricConverter())
        options.Converters.Add(NodesUsageMetricConverter())
        options.Converters.Add(ProfilingOperationModeConverter())
        options.Converters.Add(QueryRuleCriteriaTypeConverter())
        options.Converters.Add(QueryRuleTypeConverter())
        options.Converters.Add(MetricConverter())
        options.Converters.Add(IndexingJobStateConverter())
        options.Converters.Add(EventTypeConverter())
        options.Converters.Add(StatsLevelConverter())
        options.Converters.Add(StorageOptionConverter())
        options.Converters.Add(ApiKeyManagedByConverter())
        options.Converters.Add(ApiKeyTypeConverter())
        options.Converters.Add(ClusterPrivilegeConverter())
        options.Converters.Add(GrantTypeConverter())
        options.Converters.Add(IndexPrivilegeConverter())
        options.Converters.Add(RemoteClusterPrivilegeConverter())
        options.Converters.Add(RestrictionWorkflowConverter())
        options.Converters.Add(RoleMappingRuleConverter())
        options.Converters.Add(TemplateFormatConverter())
        options.Converters.Add(AccessTokenGrantTypeConverter())
        options.Converters.Add(ApiKeyGrantTypeConverter())
        options.Converters.Add(ApiKeyAggregationContainerConverter())
        options.Converters.Add(ApiKeyQueryContainerConverter())
        options.Converters.Add(RoleQueryContainerConverter())
        options.Converters.Add(UserQueryContainerConverter())
        options.Converters.Add(TypeConverter())
        options.Converters.Add(ShutdownStatusConverter())
        options.Converters.Add(ShutdownTypeConverter())
        options.Converters.Add(MergeTypeConverter())
        options.Converters.Add(RepositoryConverter())
        options.Converters.Add(ShardsStatsStageConverter())
        options.Converters.Add(SnapshotSortConverter())
        options.Converters.Add(SnapshotStateConverter())
        options.Converters.Add(SqlFormatConverter())
        options.Converters.Add(StreamTypeConverter())
        options.Converters.Add(GroupByConverter())
        options.Converters.Add(EcsCompatibilityTypeConverter())
        options.Converters.Add(FormatTypeConverter())
        options.Converters.Add(FindStructureFormatConverter())
        options.Converters.Add(PivotGroupByContainerConverter())
        options.Converters.Add(RetentionPolicyContainerConverter())
        options.Converters.Add(SyncContainerConverter())
        options.Converters.Add(AcknowledgementOptionsConverter())
        options.Converters.Add(ActionExecutionModeConverter())
        options.Converters.Add(ActionStatusOptionsConverter())
        options.Converters.Add(ActionTypeConverter())
        options.Converters.Add(ConditionContainerConverter())
        options.Converters.Add(ConditionOpConverter())
        options.Converters.Add(ConditionTypeConverter())
        options.Converters.Add(ConnectionSchemeConverter())
        options.Converters.Add(DataAttachmentFormatConverter())
        options.Converters.Add(DayConverter())
        options.Converters.Add(EmailAttachmentContainerConverter())
        options.Converters.Add(EmailPriorityConverter())
        options.Converters.Add(ExecutionPhaseConverter())
        options.Converters.Add(ExecutionStatusConverter())
        options.Converters.Add(HttpInputMethodConverter())
        options.Converters.Add(InputContainerConverter())
        options.Converters.Add(InputTypeConverter())
        options.Converters.Add(MonthConverter())
        options.Converters.Add(PagerDutyContextTypeConverter())
        options.Converters.Add(PagerDutyEventTypeConverter())
        options.Converters.Add(QuantifierConverter())
        options.Converters.Add(ResponseContentTypeConverter())
        options.Converters.Add(ScheduleContainerConverter())
        options.Converters.Add(TriggerContainerConverter())
        options.Converters.Add(TriggerEventContainerConverter())
        options.Converters.Add(WatcherMetricConverter())
        options.Converters.Add(WatcherStateConverter())
        options.Converters.Add(XPackCategoryConverter())
